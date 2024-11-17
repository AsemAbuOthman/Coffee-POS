Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.RemmberMe = True Then

            txtUsername.Text = My.Settings.Username
            txtPassword.Text = My.Settings.Password
            chkRemmberMe.Checked = True

        Else
            txtUsername.Focus()

        End If

    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        If txtUsername.Text = "" Then

            txtUsername.Focus()
            txtUsername.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz Enter your Username!", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            txtUsername.BorderColor = Color.FromArgb(0, 183, 190, 197)

        End If

        If txtPassword.Text = "" And Not txtUsername.Text = "" Then

            txtPassword.Focus()
            txtPassword.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz Enter your Password!", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else

            txtPassword.BorderColor = Color.FromArgb(0, 183, 190, 197)

        End If

        If Not txtUsername.Text = "" And Not txtPassword.Text = "" Then

            Try
                Dim strUsername As String = txtUsername.Text.Trim()
                Dim strPassword As String = txtPassword.Text.Trim()
                Modu_Sql_Conn.strUsername = strUsername
                Modu_Sql_Conn.strPassword = strPassword


                Conn.Open()

                'Dim strQuery As String = "Select Username, PasswordHash from Users where Username = @Username And PasswordHash = @Password"

                Dim strQuery As String = "Select Username, PasswordHash from Users where Username = '" & strUsername & "' And PasswordHash = '" & strPassword & "'"

                Cmd.CommandText = strQuery
                Cmd.Connection = Conn

                Cmd.Parameters.Clear()

                Cmd.Parameters.AddWithValue("@Username", strUsername.ToLower)
                Cmd.Parameters.AddWithValue("@Password", strPassword)

                Reader = Cmd.ExecuteReader

                If Reader.Read() Then

                    If chkRemmberMe.Checked = True Then

                        My.Settings.Username = txtUsername.Text
                        My.Settings.Password = txtPassword.Text
                        My.Settings.RemmberMe = True

                        My.Settings.Save()
                    Else

                        My.Settings.Username = ""
                        My.Settings.Password = ""
                        My.Settings.RemmberMe = False

                        My.Settings.Save()
                    End If


                    Me.Close()
                    frmMainScreen.Show()

                Else

                    MessageBox.Show("Invalid Username Or Password", "Log In Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        If Not txtUsername.Text = "" Then

            txtUsername.BorderColor = Color.FromArgb(0, 183, 190, 197)


        End If
    End Sub

    Private Sub btnSingUp_Click(sender As Object, e As EventArgs) Handles btnSingUp.Click
        frmSignUp.ShowDialog()
    End Sub

    Private Sub txtPassword_MouseDown(sender As Object, e As MouseEventArgs) Handles txtPassword.MouseDown

        If txtPassword.Focused = True Then

            txtPassword.PasswordChar = ""
            txtPassword.IconRight = My.Resources.eye__2_

        End If

    End Sub

    Private Sub txtPassword_MouseUp(sender As Object, e As MouseEventArgs) Handles txtPassword.MouseUp

        txtPassword.PasswordChar = "*"
        txtPassword.IconRight = My.Resources.eye__1_

    End Sub

    Private Sub lnkForgetPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgetPassword.LinkClicked

        frmForgetPassword.ShowDialog()

    End Sub


End Class


