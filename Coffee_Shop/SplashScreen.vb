Public Class frmSplashScreen

    Private Sub frmSplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        timSplashScreen.Start()

    End Sub

    Private Sub timSplashScreen_Tick(sender As Object, e As EventArgs) Handles timSplashScreen.Tick
        timSplashScreen.Stop()

        Me.Hide()
        frmLogin.Show()
    End Sub
End Class