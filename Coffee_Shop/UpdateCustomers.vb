Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class frmUpdateCustomers

    Dim dtDate As DateTime = DateTime.Now
    Dim dtViewCustomers As New DataTable
    Dim intIndexOfRow As Integer
    Dim dtBirthdate As DateTime
    Dim strGender As String

    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDay.Text = dtDate.Day.ToString
        cmbMonth.Text = dtDate.ToString("MMMM")
        cmbYear.Text = dtDate.Year.ToString


    End Sub

    Private Sub fillTextBoxesWithCustomersDetails()
        If dgvViewCustomers.SelectedRows.Count > 0 Then

            Dim selectedRow As DataGridViewRow = dgvViewCustomers.SelectedRows(0)

            txtFirstName.Text = selectedRow.Cells("FirstName").Value
            txtLastName.Text = selectedRow.Cells("LastName").Value
            txtEmail.Text = selectedRow.Cells("Email").Value
            txtPhoneNo.Text = selectedRow.Cells("Phone").Value


            If selectedRow.Cells("Gender").Value = "Male" Then
                rdoMale.Visible = True
                rdoMale.Checked = True
                rdoMale.Enabled = True

                rdoFemale.Visible = False
                rdoFemale.Checked = False
                rdoFemale.Enabled = False

                strGender = "Male"

            ElseIf selectedRow.Cells("Gender").Value = "Female" Then
                rdoFemale.Visible = True
                rdoFemale.Checked = True
                rdoFemale.Enabled = True

                rdoMale.Visible = False
                rdoMale.Checked = False
                rdoMale.Enabled = False

                strGender = "Female"

            Else

                rdoMale.Visible = False
                rdoMale.Checked = False
                rdoMale.Enabled = False

                rdoFemale.Visible = False
                rdoFemale.Checked = False
                rdoFemale.Enabled = False


            End If

            If Not String.IsNullOrEmpty(selectedRow.Cells("BirthDate").Value) Then

                dtBirthDate = Convert.ToDateTime(selectedRow.Cells("BirthDate").Value)

                cmbDay.Text = dtBirthDate.Day
                cmbMonth.Text = dtBirthDate.Month
                cmbYear.Text = dtBirthDate.Year

            End If

        Else

            txtFirstName.Clear()
            txtLastName.Clear()
            txtEmail.Clear()
            txtPhoneNo.Clear()

            rdoMale.Visible = False
            rdoMale.Checked = False
            rdoMale.Enabled = False

            rdoFemale.Visible = False
            rdoFemale.Checked = False
            rdoFemale.Enabled = False


            Dim dtDateNow As DateTime = Date.Now

            cmbDay.Text = dtDateNow.Day
            cmbMonth.Text = dtDateNow.Month
            cmbYear.Text = dtDateNow.Year

        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        'fillTextBoxesWithCustomersDetails()


        If Not txtFirstName.Text = "" And
            Not txtLastName.Text = "" And
            Not txtPhoneNo.Text = "" And
            Not cmbDay.IsDisposed And
            Not cmbMonth.IsDisposed And
            Not cmbYear.IsDisposed And
            Not (rdoMale.Checked = False And rdoFemale.Checked = False) Then

            dgvViewCustomers.Rows.Clear()


            Try

                Dim areYouSure As DialogResult

                areYouSure = MessageBox.Show("Are your sure you want to Update this Customer", "Update Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                Conn.Open()

                If areYouSure = DialogResult.Yes Then


                    Cmd.CommandText = "UPDATE CUSTOMERS SET FirstName = @FirstName,  LastName = @LastName, PhoneNumber = @PhoneNumber, DateOfBirth = @DateOfBirth, Gender = @Gender WHERE Email = @Email"
                    Cmd.Connection = Conn

                    Cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                    Cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                    Cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                    Cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNo.Text)
                    Cmd.Parameters.AddWithValue("@DateOfBirth", dtBirthdate)
                    Cmd.Parameters.AddWithValue("@Gender", strGender)

                    Cmd.ExecuteNonQuery()

                    Cmd.Parameters.Clear()


                    Dim obj_frmSignUp_Sccessfully1 As New frmSignUp_Sccessfully1

                    obj_frmSignUp_Sccessfully1.lblSignUp.Text = "Customer Updated Sccessfully"


                    obj_frmSignUp_Sccessfully1.ShowDialog()

                End If


                Dim strQuery As String = "SELECT FirstName, LastName, Email, PhoneNumber, DateOfBirth, DateJoined, Gender FROM CUSTOMERS"


                Cmd.CommandText = strQuery
                Cmd.Connection = Conn

                Reader = Cmd.ExecuteReader

                If Reader.HasRows Then

                    While Reader.Read()

                        dgvViewCustomers.Rows.Add(Reader("FirstName").ToString,
                                                  Reader("LastName").ToString,
                                                  Reader("Email").ToString,
                                                  Reader("PhoneNumber").ToString,
                                                  Reader("DateOfBirth").ToString,
                                                  Reader("DateJoined").ToString,
                                                  Reader("Gender").ToString)

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

    Private Sub dgvViewCustomers_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvViewCustomers.RowEnter

        fillTextBoxesWithCustomersDetails()

    End Sub

    Private Sub txtSearchByFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtSearchByFirstName.TextChanged

        fillTextBoxesWithCustomersDetails()

        dgvViewCustomers.Rows.Clear()

        Try

            Conn.Open()

            Dim strQuery As String

            If String.IsNullOrEmpty(txtSearchByFirstName.Text.Trim()) Then
                strQuery = "SELECT FirstName, LastName, Email, PhoneNumber, DateOfBirth, DateJoined, Gender FROM CUSTOMERS"
            Else
                strQuery = "SELECT FirstName, LastName, Email, PhoneNumber, DateOfBirth, DateJoined, Gender FROM CUSTOMERS WHERE FirstName LIKE @FirstName"
                Cmd.Parameters.AddWithValue("@FirstName", txtSearchByFirstName.Text.Trim() & "%")
            End If

            Cmd.CommandText = strQuery
            Cmd.Connection = Conn

            Reader = Cmd.ExecuteReader

            If Reader.HasRows Then

                While Reader.Read()

                    dgvViewCustomers.Rows.Add(Reader("FirstName").ToString,
                                              Reader("LastName").ToString,
                                              Reader("Email").ToString,
                                              Reader("PhoneNumber").ToString,
                                              Reader("DateOfBirth").ToString,
                                              Reader("DateJoined").ToString,
                                              Reader("Gender").ToString)

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
End Class