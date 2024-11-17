Imports System.Media

Public Class frmConfirmUser
    Private Sub SignUp_Sccessfully_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        If txtPassword.Text = Modu_Sql_Conn.strPassword Then

            Try

                Dim areYouSure As DialogResult

                areYouSure = MessageBox.Show("Are your sure you want to Delete this Account", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If areYouSure = DialogResult.Yes Then

                    Conn.Open()

                    Dim strDeleteUser As String = "DELETE FROM Users WHERE Username = @Username"

                    Cmd.Parameters.AddWithValue("@Username", strUsername)

                    Cmd.CommandText = strDeleteUser
                    Cmd.Connection = Conn

                    Cmd.ExecuteNonQuery()

                    Me.Close()

                    Dim frmNotification As New frmSignUp_Sccessfully1

                    frmNotification.lblSignUp.Text = "Account Deleted Successfully"
                    frmNotification.ShowDialog()

                    frmNotification.Close()
                    frmMainScreen.Close()

                    frmLogin.Show()

                End If

            Catch ex As Exception

                MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)

            Finally

                If Conn.State = ConnectionState.Open Then

                    Conn.Close()

                End If

            End Try

        Else

            txtPassword.Focus()
            txtPassword.BorderColor = Color.FromArgb(250, 255, 0, 0)

            MessageBox.Show("Plz enter a valid password", "Wrong Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class