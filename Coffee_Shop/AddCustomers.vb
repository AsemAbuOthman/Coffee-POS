Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class frmAddCustomers

    Dim dtDate As DateTime = DateTime.Now
    Dim dtViewCustomers As New DataTable
    Dim intIndexOfRow As Integer
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDay.Text = dtDate.Day.ToString
        cmbMonth.Text = dtDate.ToString("MMMM")
        cmbYear.Text = dtDate.Year.ToString

        Try

            Conn.Open()

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

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtFirstName.Text = "" Then

            txtFirstName.Focus()
            txtFirstName.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz Enter your First name!", "Missing First name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf txtFirstName.TextLength <= 50 Then

            txtFirstName.BorderColor = Color.FromArgb(0, 183, 190, 197)

        End If

        If txtLastName.Text = "" Then

            txtLastName.Focus()
            txtLastName.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz Enter your Last name!", "Missing Last name", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf txtLastName.TextLength <= 50 Then

            txtLastName.BorderColor = Color.FromArgb(0, 183, 190, 197)

        End If

        If txtEmail.Text = "" Then

            txtEmail.Focus()
            txtEmail.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz Enter your Phone Number!", "Missing Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf txtEmail.TextLength >= 10 Then

            txtEmail.BorderColor = Color.FromArgb(0, 183, 190, 197)

        End If

        If txtPhoneNo.Text = "" Then

            txtPhoneNo.Focus()
            txtPhoneNo.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz Enter your Phone Number!", "Missing Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf txtPhoneNo.TextLength >= 10 Then

            txtPhoneNo.BorderColor = Color.FromArgb(0, 183, 190, 197)

        End If


        Dim intAge As Integer
        Dim dtBirthdate As DateTime = New DateTime(cmbYear.SelectedItem, cmbMonth.SelectedIndex + 1, cmbDay.SelectedItem)

        intAge = dtDate.Year - dtBirthdate.Year

        If intAge < 18 Then

            MessageBox.Show("You under 18 Years old", "Birthday", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else


        End If

        Dim strGender As String

        If rdoMale.Checked = False And rdoFemale.Checked = False Then

            txtFirstName.Focus()
            MessageBox.Show("Plz choose your gender", "Missing Gender", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf rdoMale.Checked = True Then

            strGender = "Male"

        Else

            strGender = "Female"

        End If


        If Not txtFirstName.Text = "" And
            Not txtLastName.Text = "" And
            Not txtPhoneNo.Text = "" And
            Not txtEmail.Text = "" And
            Not cmbDay.IsDisposed And
            Not cmbMonth.IsDisposed And
            Not cmbYear.IsDisposed And
            Not (rdoMale.Checked = False And rdoFemale.Checked = False) Then

            dgvViewCustomers.Rows.Clear()


            Try

                Conn.Open()

                Cmd.CommandText = "SELECT COUNT(*) FROM CUSTOMERS WHERE Email = @Email"
                Cmd.Parameters.AddWithValue("@Email", txtEmail.Text.Trim())

                Dim count As Integer = Convert.ToInt32(Cmd.ExecuteScalar())

                Cmd.Parameters.Clear()

                If count > 0 Then
                    MessageBox.Show("Customer with this email already exists!", "Add Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else

                    Cmd.CommandText = "INSERT INTO CUSTOMERS (FirstName, LastName, Email, PhoneNumber, DateOfBirth, Gender) VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @DateOfBirth, @Gender)"
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

                    obj_frmSignUp_Sccessfully1.lblSignUp.Text = "     Customer Add Sccessfully"


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
End Class