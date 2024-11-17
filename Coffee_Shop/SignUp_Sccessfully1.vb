Imports System.Media

Public Class frmSignUp_Sccessfully1
    Private Sub SignUp_Sccessfully_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Interval = 2300
        Timer1.Start()
        SystemSounds.Asterisk.Play()
        picNotify.Image = My.Resources.Correct_Answer

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        Me.Close()
        frmSignUp.Close()

        If WhichForm = "Sign Up" Then
            Me.Close()
            frmSignUp.Close()

        Else

            frmMainScreen.Show()

        End If

    End Sub
End Class