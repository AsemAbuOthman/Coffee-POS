Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class frmSignUp

    Dim dtDate As DateTime = DateTime.Now

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub frmSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDay.Text = dtDate.Day.ToString
        cmbMonth.Text = dtDate.ToString("MMMM")
        cmbYear.Text = dtDate.Year.ToString
    End Sub

    Private Sub btnSingUp_Click(sender As Object, e As EventArgs) Handles btnSingUp.Click

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

        If txtUsername.Text = "" Then

            txtUsername.Focus()
            txtUsername.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz Enter your Username!", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf txtUsername.TextLength >= 4 Then

            txtUsername.BorderColor = Color.FromArgb(0, 183, 190, 197)

        End If

        If txtNewPassword.Text = "" And txtUsername.TextLength >= 6 Then

            txtNewPassword.Focus()
            txtNewPassword.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz Enter your Password!", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf Not txtNewPassword.Text = "" And txtNewPassword.TextLength >= 8 Then

            txtNewPassword.BorderColor = Color.FromArgb(0, 183, 190, 197)

        ElseIf txtNewPassword.Text = "" Then

            txtNewPassword.Focus()
            txtNewPassword.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz Confirm your Password! (at least 8 charchter)", "Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

        If txtConfirmPassword.Text = "" Or txtConfirmPassword.TextLength < 8 Then

            txtConfirmPassword.Focus()
            txtConfirmPassword.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz Confirm your Password! (at least 8 charchter)", "Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        ElseIf txtConfirmPassword.Text = txtNewPassword.Text And txtConfirmPassword.TextLength >= 8 Then

            txtConfirmPassword.BorderColor = Color.FromArgb(0, 183, 190, 197)

        Else

            txtConfirmPassword.Focus()
            txtConfirmPassword.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Confirm Password isn't matched your password3", "Confirm Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)


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

        If Not txtUsername.Text = "" And
            Not txtNewPassword.Text = "" And
            Not txtUsername.Text = "" And
            Not txtNewPassword.Text = "" And
            Not cmbDay.IsDisposed And
            Not cmbMonth.IsDisposed And
            Not cmbYear.IsDisposed And
            (Not txtConfirmPassword.Text = "" And txtConfirmPassword.Text = txtNewPassword.Text) And Not (rdoMale.Checked = False And rdoFemale.Checked = False) Then

            Try
                Dim strUsername As String = txtUsername.Text.Trim()
                Dim strPassword As String = txtNewPassword.Text.Trim()
                Dim strEmail As String = txtEmail.Text.Trim()

                Conn.Open()

                Dim strQuery As String = "SELECT Username, PasswordHash, Email FROM Users WHERE Username = @Username And PasswordHash = @Password And Email = @Email"

                Cmd.CommandText = strQuery
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@Username", strUsername.ToLower)
                Cmd.Parameters.AddWithValue("@Password", strPassword)
                Cmd.Parameters.AddWithValue("@Email", strEmail)

                Reader = Cmd.ExecuteReader

                Cmd.Parameters.Clear()

                If Reader.Read() Then

                    MessageBox.Show("Username " & strUsername & " is already registerd !", "Sign Up Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                Else


                    Dim strInsertUser As String = "INSERT INTO Users (FirstName, LastName, Username, PasswordHash, Email, DateOfBirth, Gender) VALUES (@FirstName, @LastName, @Username, @Password, @Email, @DateOfBirth, @Gender)"

                    Cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                    Cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                    Cmd.Parameters.AddWithValue("@Username", strUsername.ToLower)
                    Cmd.Parameters.AddWithValue("@Password", strPassword)
                    Cmd.Parameters.AddWithValue("@Email", strEmail)
                    Cmd.Parameters.AddWithValue("@DateOfBirth", dtBirthdate)
                    Cmd.Parameters.AddWithValue("@Gender", strGender)

                    Cmd.Connection.Close()
                    Cmd.Connection.Open()
                    Cmd.CommandText = strInsertUser
                    Cmd.Connection = Conn

                    Cmd.ExecuteNonQuery()

                    Modu_Sql_Conn.WhichForm = "Sign Up"
                    frmSignUp_Sccessfully1.ShowDialog()

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
    Private Sub txtNewPassword_MouseDown(sender As Object, e As MouseEventArgs) Handles txtNewPassword.MouseDown

        If txtNewPassword.Focused = True Then

            txtNewPassword.PasswordChar = ""
            txtNewPassword.IconRight = My.Resources.eye__2_


        End If

    End Sub

    Private Sub txtNewPassword_MouseUp(sender As Object, e As MouseEventArgs) Handles txtNewPassword.MouseUp

        txtNewPassword.PasswordChar = "*"
        txtNewPassword.IconRight = My.Resources.eye__1_

    End Sub

    Private Sub txtConfirmPassword_MouseDown(sender As Object, e As MouseEventArgs) Handles txtConfirmPassword.MouseDown


        If txtConfirmPassword.Focused = True Then

            txtConfirmPassword.PasswordChar = ""
            txtConfirmPassword.IconRight = My.Resources.eye__2_

        End If

    End Sub

    Private Sub txtConfirmPassword_MouseUp(sender As Object, e As MouseEventArgs) Handles txtConfirmPassword.MouseUp

        txtConfirmPassword.PasswordChar = "*"
        txtConfirmPassword.IconRight = My.Resources.eye__1_

    End Sub
End Class