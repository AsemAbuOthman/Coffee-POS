Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class frmSignUp

    Dim dtDate As DateTime = DateTime.Now

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

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

            MessageBox.Show("Plz Enter your Password!", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

        Dim intAge As Integer
        Dim dtBirthdate As DateTime

        dtBirthdate.AddDays(cmbDay.SelectedItem)
        dtBirthdate.AddMonths(cmbMonth.SelectedIndex + 1)
        dtBirthdate.AddYears(cmbYear.SelectedItem)

        intAge = dtDate.Year - cmbYear.SelectedItem

        If intAge < 18 Then

            MessageBox.Show("You under 18 Years old", "Birthday", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

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
            Not cmbYear.IsDisposed And Not (rdoMale.Checked = False And rdoFemale.Checked = False) Then

            Try
                Dim strUsername As String = txtUsername.Text.Trim()
                Dim strPassword As String = txtNewPassword.Text.Trim()
                Dim strEmail As String = txtEmail.Text.Trim()

                Conn.Open()

                Dim strQuery As String = "SELECT Username, PasswordHash, Email FROM Users WHERE Username = @Username And PasswordHash = @Password And Email = @Email"

                Cmd.CommandText = strQuery
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@Username", strUsername)
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
                    Cmd.Parameters.AddWithValue("@Username", strUsername)
                    Cmd.Parameters.AddWithValue("@Password", strPassword)
                    Cmd.Parameters.AddWithValue("@Email", strEmail)
                    Cmd.Parameters.AddWithValue("@DateOfBirth", dtDate)
                    Cmd.Parameters.AddWithValue("@Gender", strGender)

                    Cmd.Connection.Close()
                    Cmd.Connection.Open()
                    Cmd.CommandText = strInsertUser
                    Cmd.Connection = Conn

                    Cmd.ExecuteNonQuery()

                    'MessageBox.Show("Account created Successfully", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    frmSignUp_Sccessfully.ShowDialog()

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