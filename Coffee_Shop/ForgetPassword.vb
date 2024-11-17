Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class frmForgetPassword

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

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


        If Not txtUsername.Text = "" And Not txtNewPassword.Text = "" And txtConfirmPassword.Text = txtNewPassword.Text Then

            Try
                Dim strUsername As String = txtUsername.Text.Trim()
                Dim strPassword As String = txtNewPassword.Text.Trim()

                Conn.Open()

                Dim strQuery As String = "SELECT Username, PasswordHash, Email FROM Users WHERE Username = @Username"

                Cmd.CommandText = strQuery
                Cmd.Connection = Conn

                Cmd.Parameters.AddWithValue("@Username", strUsername)

                Reader = Cmd.ExecuteReader

                Cmd.Parameters.Clear()

                If Reader.Read() Then


                    Dim strInsertUser As String = "UPDATE Users SET PasswordHash = @Password WHERE Username = @Username"

                    Cmd.Parameters.AddWithValue("@Username", strUsername)
                    Cmd.Parameters.AddWithValue("@Password", strPassword)

                    Cmd.Connection.Close()
                    Cmd.Connection.Open()
                    Cmd.CommandText = strInsertUser
                    Cmd.Connection = Conn

                    Cmd.ExecuteNonQuery()

                    frmSignUp_Sccessfully1.lblSignUp.Text = "Saved Successfully"
                    frmSignUp_Sccessfully1.lblSignUp.Location = New Point(90, 11)
                    frmSignUp_Sccessfully1.ShowDialog()

                    frmMainScreen.Close()
                Else

                    txtUsername.Focus()
                    MessageBox.Show("Username doesn't exist", "Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

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

    Private Sub frmForgetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.Focus()

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