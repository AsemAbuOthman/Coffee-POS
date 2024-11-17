Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class frmViewCustomers

    Dim dtDate As DateTime = DateTime.Now
    Dim dtViewCustomers As New DataTable
    Dim intIndexOfRow As Integer
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

            ElseIf selectedRow.Cells("Gender").Value = "Female" Then
                rdoFemale.Visible = True
                rdoFemale.Checked = True
                rdoFemale.Enabled = True

                rdoMale.Visible = False
                rdoMale.Checked = False
                rdoMale.Enabled = False

            Else

                rdoMale.Visible = False
                rdoMale.Checked = False
                rdoMale.Enabled = False

                rdoFemale.Visible = False
                rdoFemale.Checked = False
                rdoFemale.Enabled = False

            End If

            Dim dtBirthDate As DateTime

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

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

        fillTextBoxesWithCustomersDetails()

        dgvViewCustomers.Rows.Clear()

        Try

            Conn.Open()

            Dim strQuery As String

            If String.IsNullOrEmpty(txtSearchByFirstName.Text.Trim()) Then
                strQuery = "SELECT FirstName, LastName, Email, PhoneNumber, DateOfBirth, DateJoined, Gender FROM CUSTOMERS"
            Else
                strQuery = "SELECT FirstName, LastName, Email, PhoneNumber, DateOfBirth, DateJoined, Gender FROM CUSTOMERS WHERE FirstName LIKE @FirstName"
                Cmd.Parameters.AddWithValue("@FirstName", "%" & txtSearchByFirstName.Text.Trim() & "%")
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

    Private Sub dgvViewCustomers_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgvViewCustomers.RowEnter

        fillTextBoxesWithCustomersDetails()

    End Sub


End Class