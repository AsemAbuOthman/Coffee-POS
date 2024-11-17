Imports System.Data.SqlClient
Imports System.IO
Imports Guna.UI2.WinForms

Public Class frmViewProducts

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        fillTextBoxesWithCustomersDetails()

    End Sub

    Private Sub fillTextBoxesWithCustomersDetails()
        If dgvViewProducts.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvViewProducts.SelectedRows(0)

            txtProductName.Text = selectedRow.Cells("ProductName").Value
            txtProductPrice.Text = selectedRow.Cells("Price").Value
            txtProductDescription.Text = selectedRow.Cells("Description").Value
            cmbCategory.Text = selectedRow.Cells("Category").Value
            cmbProduceSize.Text = selectedRow.Cells("Size").Value

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

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

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
                                              Reader("Image_url").ToString,
                                              Reader("Image_data"))



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

    Private Sub txtSearchByFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtSearchByProductName.TextChanged

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

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click

    End Sub
End Class