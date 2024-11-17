Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class frmUpdateUsers

    Dim dtDate As DateTime = DateTime.Now
    Dim strGender As String
    Private Sub frmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDay.Text = dtDate.Day.ToString
        cmbMonth.Text = dtDate.ToString("MMMM")
        cmbYear.Text = dtDate.Year.ToString

        Try

            Conn.Open()

            Dim strQuery As String = "SELECT FirstName, LastName, Username, Email, DateOfBirth, Gender  FROM USERS WHERE Username = '" & Modu_Sql_Conn.strUsername & "'"

            Cmd.CommandText = strQuery
            Cmd.Connection = Conn

            Reader = Cmd.ExecuteReader

            If Reader.Read() Then

                txtFirstName.Text = Reader("FirstName").ToString
                txtLastName.Text = Reader("LastName").ToString
                txtUsername.Text = Reader("Username").ToString
                txtEmail.Text = Reader("Email").ToString

                Dim dtDateOfBirth As DateTime

                dtDateOfBirth = Reader.GetDateTime(Reader.GetOrdinal("DateOfBirth"))

                cmbDay.Text = dtDateOfBirth.Day.ToString
                cmbMonth.Text = dtDateOfBirth.ToString("MMMM")
                cmbYear.Text = dtDateOfBirth.Year.ToString

                dtDate = dtDateOfBirth

                strGender = Reader("Gender").ToString

                If strGender = "Male" Then
                    rdoMale.Visible = True
                    rdoMale.Checked = True

                ElseIf strGender = "Female" Then
                    rdoFemale.Visible = True
                    rdoFemale.Checked = True

                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Finally

            If Conn.State = ConnectionState.Open Then

                Conn.Close()

            End If
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Try

            Conn.Open()

            Dim areYouSure As DialogResult

            areYouSure = MessageBox.Show("Are your sure you want to Save editing info", "Update Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If areYouSure = DialogResult.Yes Then

                Dim strUpdateUser As String = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Email = @Email, DateOfBirth = @DateOfBirth, Gender = @Gender WHERE Username = @Username"

                Cmd.Parameters.AddWithValue("@Username", txtUsername.Text)

                Cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text)
                Cmd.Parameters.AddWithValue("@LastName", txtLastName.Text)
                Cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                Cmd.Parameters.AddWithValue("@DateOfBirth", dtDate)
                Cmd.Parameters.AddWithValue("@Gender", strGender)


                Cmd.CommandText = strUpdateUser
                Cmd.Connection = Conn

                Cmd.ExecuteNonQuery()

                Dim frmNotification As New frmSignUp_Sccessfully1

                frmNotification.lblSignUp.Text = "Account Updated Successfully"
                frmNotification.ShowDialog()

                Me.Activate()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Finally

            If Conn.State = ConnectionState.Open Then

                Conn.Close()

            End If

        End Try
    End Sub
End Class