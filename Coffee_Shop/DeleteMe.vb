Imports System.Data.SqlClient
Imports Guna.UI2.WinForms

Public Class frmDeleteMe

    Dim dtDate As DateTime = DateTime.Now

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

                Dim strGender As String = Reader("Gender").ToString

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

    Private Sub btnDeleteMe_Click(sender As Object, e As EventArgs) Handles btnDeleteMe.Click
        frmConfirmUser.ShowDialog()
    End Sub
End Class