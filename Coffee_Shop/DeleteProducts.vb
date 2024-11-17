Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms.AxHost
Imports Guna.UI2.WinForms
Imports System.Drawing.Imaging

Public Class frmDeleteProducts

    Dim selectedImagePath As String = "none"
    Public destPath As String
    Dim OpenFileDialog1 As New OpenFileDialog
    Dim bolAvailable As Boolean

    Private ReadOnly imagesDirectory As String = Path.Combine(Application.StartupPath, "Images")

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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



    Private Sub fillTextBoxesWithCustomersDetails()
        If dgvViewProducts.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvViewProducts.SelectedRows(0)

            txtProductName.Text = selectedRow.Cells("ProductName").Value
            txtProductPrice.Text = selectedRow.Cells("Price").Value
            txtProductDescription.Text = selectedRow.Cells("Description").Value
            cmbCategory.Text = selectedRow.Cells("Category").Value
            cmbProduceSize.Text = selectedRow.Cells("Size").Value

            'Dim bytImage_data As Byte

            Dim picByte() As Byte = DirectCast(selectedRow.Cells("Image_data").Value, Byte())

            If picByte IsNot Nothing AndAlso picByte.Length > 0 Then

                Dim picStream As New System.IO.MemoryStream(picByte)

                If picStream.CanRead Then

                    btnAddImage.Enabled = True
                    btnAddImage.BackgroundImage = Image.FromStream(picStream)
                    btnAddImage.BackgroundImageLayout = ImageLayout.Zoom


                Else

                    btnAddImage.Enabled = False
                    btnAddImage.BackgroundImage = My.Resources.icons8_plus_80
                    btnAddImage.BackgroundImageLayout = ImageLayout.Center


                End If

                picStream.Close()


            End If


            If selectedRow.Cells("Available").Value = True Then
                rdoAvailable.Visible = True
                rdoAvailable.Checked = True
                rdoAvailable.Enabled = True

                rdoNotAvailable.Visible = False
                rdoNotAvailable.Checked = False
                rdoNotAvailable.Enabled = False

            ElseIf selectedRow.Cells("Available").Value = False Then
                rdoNotAvailable.Visible = True
                rdoNotAvailable.Checked = True
                rdoNotAvailable.Enabled = True
                rdoAvailable.Visible = False
                rdoAvailable.Checked = False
                rdoAvailable.Enabled = False
            Else
                rdoAvailable.Visible = False
                rdoAvailable.Checked = False
                rdoAvailable.Enabled = False
                rdoNotAvailable.Visible = False
                rdoNotAvailable.Checked = False
                rdoNotAvailable.Enabled = False

            End If


        Else
            txtProductName.Clear()
            txtProductPrice.Clear()
            txtProductDescription.Clear()
            cmbCategory.Text = ""
            cmbProduceSize.Text = ""

            btnAddImage.Enabled = False
            btnAddImage.BackgroundImage = My.Resources.icons8_plus_80
            btnAddImage.BackgroundImageLayout = ImageLayout.Center


            rdoAvailable.Visible = False
            rdoAvailable.Checked = False
            rdoAvailable.Enabled = False

            rdoNotAvailable.Visible = False
            rdoNotAvailable.Checked = False
            rdoNotAvailable.Enabled = False


        End If
    End Sub

    Private Sub txtSearchByProductName_TextChanged(sender As Object, e As EventArgs) Handles txtSearchByProductName.TextChanged

        fillTextBoxesWithCustomersDetails()

        dgvViewProducts.Rows.Clear()

        Try

            Conn.Open()

            Dim strQuery As String

            If String.IsNullOrEmpty(txtSearchByProductName.Text.Trim()) Then
                strQuery = "SELECT Name, Description, Category, Price, Size, Created_at, Available, Image_url, Image_data FROM PRODUCTS"
            Else
                strQuery = "SELECT Name, Description, Category, Price, Size, Created_at, Available, Image_url, Image_data FROM PRODUCTS WHERE Name LIKE @Name"
                Cmd.Parameters.AddWithValue("@Name", txtSearchByProductName.Text.Trim() & "%")
            End If

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
                                              Reader("Image_url").ToString, Reader("Image_data"))

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
    Private Sub dgvViewProducts_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvViewProducts.RowEnter
        fillTextBoxesWithCustomersDetails()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

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




        If rdoAvailable.Checked = False And rdoNotAvailable.Checked = False Then

            txtProductName.Focus()
            MessageBox.Show("Plz choose Availablity status", "Missing Availablity", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf rdoAvailable.Checked = True Then

            bolAvailable = 1

        Else

            bolAvailable = 0

        End If

        If Not txtProductDescription.Text = "" And
            Not txtProductPrice.Text = "" And IsNumeric(txtProductPrice.Text) And
            Not cmbCategory.IsDisposed And
            Not cmbProduceSize.IsDisposed And
            Not (rdoAvailable.Checked = False And rdoNotAvailable.Checked = False) Then

            dgvViewProducts.Rows.Clear()

            Try

                Dim areYouSure As DialogResult

                areYouSure = MessageBox.Show("Are your sure you want to Delete this Product", "Delete Prodcut", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                Conn.Open()

                If areYouSure = DialogResult.Yes Then


                    Dim mstream As New System.IO.MemoryStream
                    btnAddImage.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Png)
                    Dim arrImage() As Byte = mstream.GetBuffer()


                    Cmd.CommandText = "DELETE FROM PRODUCTS  WHERE Name = @Name"
                    Cmd.Connection = Conn

                    Cmd.Parameters.AddWithValue("@Name", txtProductName.Text.Trim)


                    Cmd.ExecuteNonQuery()

                    Cmd.Parameters.Clear()

                    My.Settings.LastImagePath = destPath
                    My.Settings.Save()


                    Dim obj_frmSignUp_Sccessfully1 As New frmSignUp_Sccessfully1

                    obj_frmSignUp_Sccessfully1.lblSignUp.Text = "  Product Deleted Sccessfully"


                    obj_frmSignUp_Sccessfully1.ShowDialog()

                End If


                Dim strQuery As String = "SELECT Name, Description, Category, Price, Size, Created_at, Available, Image_url,Image_data FROM PRODUCTS"

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
                                                  Reader("Image_url").ToString, Reader("Image_data"))

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