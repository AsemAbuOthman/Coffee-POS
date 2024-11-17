Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms.AxHost
Imports Guna.UI2.WinForms
Imports System.Drawing.Imaging

Public Class frmAddProducts

    Dim selectedImagePath As String
    Public destPath As String
    Dim OpenFileDialog1 As New OpenFileDialog

    Private ReadOnly imagesDirectory As String = Path.Combine(Application.StartupPath, "Images")

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'If Not Directory.Exists(imagesDirectory) Then
        '    Directory.CreateDirectory(imagesDirectory)
        'End If

        Try

            Conn.Open()

            Dim strQuery As String = "SELECT Name, Description, Category, Price, Size, Created_at, Available, Image_url FROM PRODUCTS"


            Cmd.CommandText = strQuery
            Cmd.Connection = Conn

            Reader = Cmd.ExecuteReader

            If Reader.HasRows Then

                While Reader.Read()

                    dgvViewProducts.Rows.Add(Reader("Name").ToString,
                                                  Reader("Description").ToString,
                                                  Reader("Category").ToString,
                                                  Format(Reader("Price").ToString, "Currency"),
                                                  Reader("Size").ToString,
                                                  Reader("Created_at").ToString,
                                                  Reader("Available").ToString,
                                                  Reader("Image_url").ToString)

                End While

            End If


        Catch ex As Exception

            MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Finally

            If Conn.State = ConnectionState.Open Then

                Conn.Close()

            End If

        End Try

        Cmd.Parameters.Clear()

    End Sub

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click


        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        OpenFileDialog1.Title = "Select an Image"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            selectedImagePath = OpenFileDialog1.FileName


            Dim fileName As String = Path.GetFileName(selectedImagePath)
            destPath = Path.Combine(imagesDirectory, fileName)

            If Not Directory.Exists(imagesDirectory) Then
                Directory.CreateDirectory(imagesDirectory)

                File.Copy(selectedImagePath, destPath, True)


            End If


            Dim selectedImage As Image = Image.FromFile(selectedImagePath)

            btnAddImage.BackgroundImage = selectedImage
            btnAddImage.BackgroundImageLayout = ImageLayout.Zoom

        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        If txtProductName.Text = "" Then

            txtProductName.Focus()
            txtProductName.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz Enter Product name!", "Missing Product Name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf txtProductName.TextLength <= 50 Then

            txtProductName.BorderColor = Color.FromArgb(0, 183, 190, 197)

        End If

        If txtProductPrice.Text = "" Or Not IsNumeric(txtProductPrice.Text) Then

            txtProductPrice.Focus()
            txtProductPrice.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Please enter a valid number!", "Price Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf txtProductPrice.TextLength >= 1 Then

            txtProductPrice.BorderColor = Color.FromArgb(0, 183, 190, 197)

        End If

        If txtProductDescription.Text = "" Then

            txtProductDescription.Focus()
            txtProductDescription.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz Enter Product Description!", "Missing Product Description", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf txtProductDescription.TextLength <= 50 Then

            txtProductDescription.BorderColor = Color.FromArgb(0, 183, 190, 197)

        End If

        If cmbCategory.SelectedIndex < 0 Then

            cmbCategory.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz Choose Category!", "Missing Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            cmbCategory.BorderColor = Color.FromArgb(0, 183, 190, 197)


        End If

        If cmbProduceSize.SelectedIndex < 0 Then

            cmbProduceSize.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz Choose Producte Size!!", "Missing Producte Size", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            cmbProduceSize.BorderColor = Color.FromArgb(0, 183, 190, 197)

        End If


        Dim bolAvailable As Boolean


        If rdoAvailable.Checked = False And rdoNotAvailable.Checked = False Then

            txtProductName.Focus()
            MessageBox.Show("Plz choose Availablity status", "Missing Availablity", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf rdoAvailable.Checked = True Then

            bolAvailable = 1

        Else

            bolAvailable = 0

        End If

        If String.IsNullOrEmpty(OpenFileDialog1.FileName) Then

            btnAddImage.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz Upload an image for product", "Missing Image", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            btnAddImage.BorderColor = Color.FromArgb(0, 183, 190, 197)


        End If


        If Not txtProductName.Text = "" And
            Not txtProductDescription.Text = "" And
            Not txtProductPrice.Text = "" And IsNumeric(txtProductPrice.Text) And
            Not cmbCategory.IsDisposed And
            Not cmbProduceSize.IsDisposed And
            Not (rdoAvailable.Checked = False And rdoNotAvailable.Checked = False) And Not String.IsNullOrEmpty(OpenFileDialog1.FileName) Then

            dgvViewProducts.Rows.Clear()

            Try

                Conn.Open()

                Cmd.CommandText = "SELECT COUNT(*) FROM PRODUCTS WHERE Name = @ProductName"
                Cmd.Parameters.AddWithValue("@ProductName", txtProductName.Text.Trim())

                Dim count As Integer = Convert.ToInt32(Cmd.ExecuteScalar())

                Cmd.Parameters.Clear()

                If count > 0 Then
                    MessageBox.Show("Product with this name already exists!", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else

                    Dim mstream As New System.IO.MemoryStream
                    btnAddImage.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
                    Dim arrImage() As Byte = mstream.GetBuffer()


                    Cmd.CommandText = "INSERT INTO PRODUCTS (Name, Description, Category, Price, Size, Available, Image_url, Image_data) VALUES (@Name, @Description, @Category, @Price, @Size, @Available, @Image_url, @Image_data)"
                    Cmd.Connection = Conn

                    Cmd.Parameters.AddWithValue("@Name", txtProductName.Text)
                    Cmd.Parameters.AddWithValue("@Description", txtProductDescription.Text)
                    Cmd.Parameters.AddWithValue("@Category", cmbCategory.Text)
                    Cmd.Parameters.AddWithValue("@Price", Val(txtProductPrice.Text))
                    Cmd.Parameters.AddWithValue("@Size", cmbProduceSize.Text)
                    Cmd.Parameters.AddWithValue("@Available", 1)
                    Cmd.Parameters.AddWithValue("@Image_url", Path.GetFileNameWithoutExtension(selectedImagePath))
                    Cmd.Parameters.AddWithValue("@Image_data", arrImage)


                    Cmd.ExecuteNonQuery()

                    Cmd.Parameters.Clear()

                    My.Settings.LastImagePath = destPath
                    My.Settings.Save()

                    Dim obj_frmSignUp_Sccessfully1 As New frmSignUp_Sccessfully1

                    obj_frmSignUp_Sccessfully1.lblSignUp.Text = "     Product Added Sccessfully"


                    obj_frmSignUp_Sccessfully1.ShowDialog()

                End If

                Dim strQuery As String = "SELECT Name, Description, Category, Price, Size, Created_at, Available, Image_url FROM PRODUCTS"

                Cmd.CommandText = strQuery
                Cmd.Connection = Conn

                Reader = Cmd.ExecuteReader

                If Reader.HasRows Then

                    While Reader.Read()

                        dgvViewProducts.Rows.Add(Reader("Name").ToString,
                                                  Reader("Description").ToString,
                                                  Reader("Category").ToString,
                                                  Format(Reader("Price").ToString, "Currency"),
                                                  Reader("Size").ToString,
                                                  Reader("Created_at").ToString,
                                                  Reader("Available").ToString,
                                                  Reader("Image_url").ToString)

                    End While

                End If

            Catch ex As Exception

                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            Finally

                If Conn.State = ConnectionState.Open Then

                    Conn.Close()

                End If

            End Try

            Cmd.Parameters.Clear()


        End If
    End Sub


End Class