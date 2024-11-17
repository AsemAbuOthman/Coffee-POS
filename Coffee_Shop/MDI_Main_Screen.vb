Imports Microsoft.VisualBasic.Devices

Public Class frmMainScreen

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub lblLogOut_Click(sender As Object, e As EventArgs) Handles lblLogOut.Click
        btnLogOut_Click(sender, e)
    End Sub

    Private Sub lblUsers_Click(sender As Object, e As EventArgs) Handles lblAccount.Click
        btnUser.PerformClick()
    End Sub

    Private Sub lblCustomer_Click(sender As Object, e As EventArgs) Handles lblCustomer.Click
        btnCustomers.PerformClick()
    End Sub

    Private Sub lblProducts_Click(sender As Object, e As EventArgs) Handles lblProducts.Click
        btnProducts.PerformClick()
    End Sub

    Private Sub lblOrder_Click(sender As Object, e As EventArgs) Handles lblOrder.Click
        btnOrder.PerformClick()
    End Sub

    Private Sub frmMainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is MdiClient Then
                ctrl.BackColor = Color.WhiteSmoke
            End If
        Next

        btnUser.PerformClick()
    End Sub

    Private Sub btnCustomers_CheckedChanged(sender As Object, e As EventArgs) Handles btnCustomers.CheckedChanged


        If btnCustomers.Checked = True Then
            btnCustomers.BorderColor = Color.FromArgb(69, 38, 20)
            btnCustomers.BorderThickness = 1

            ClearMdiChildren()

            pnlCustomer.Visible = True

        Else
            btnCustomers.BorderColor = Color.Transparent
            btnCustomers.BorderThickness = 0

            ClearMdiChildren()

            pnlCustomer.Visible = False

        End If
    End Sub

    Private Sub btnProducts_CheckedChanged(sender As Object, e As EventArgs) Handles btnProducts.CheckedChanged
        If btnProducts.Checked = True Then
            btnProducts.BorderColor = Color.FromArgb(69, 38, 20)
            btnProducts.BorderThickness = 1

            ClearMdiChildren()

            pnlProducts.Visible = True

        Else
            btnProducts.BorderColor = Color.Transparent
            btnProducts.BorderThickness = 0

            ClearMdiChildren()

            pnlProducts.Visible = False


        End If
    End Sub

    Private Sub btnOrder_CheckedChanged(sender As Object, e As EventArgs) Handles btnOrder.CheckedChanged
        If btnOrder.Checked = True Then
            btnOrder.BorderColor = Color.FromArgb(69, 38, 20)
            btnOrder.BorderThickness = 1

            ClearMdiChildren()

            pnlOrder.Visible = True


        Else
            btnOrder.BorderColor = Color.Transparent
            btnOrder.BorderThickness = 0

            ClearMdiChildren()

            pnlOrder.Visible = False


        End If
    End Sub

    Private Sub btnUser_CheckedChanged(sender As Object, e As EventArgs) Handles btnUser.CheckedChanged
        If btnUser.Checked = True Then
            btnUser.BorderColor = Color.FromArgb(69, 38, 20)
            btnUser.BorderThickness = 1

            ClearMdiChildren()

            pnlChoices.Visible = True

        Else
            btnUser.BorderColor = Color.Transparent
            btnUser.BorderThickness = 0

            ClearMdiChildren()

            pnlChoices.Visible = False

        End If
    End Sub

    Private Sub ClearMdiChildren()

        For Each childForm As Form In Me.MdiChildren
            childForm.Close()
        Next

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        ClearMdiChildren()

        Dim child_frmUpdateUsres As New frmUpdateUsers
        child_frmUpdateUsres.MdiParent = Me

        child_frmUpdateUsres.StartPosition = FormStartPosition.Manual
        child_frmUpdateUsres.Location = New Point(350, 35)

        child_frmUpdateUsres.Show()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        ClearMdiChildren()

        Dim child_frmSignUp As New frmSignUp()

        child_frmSignUp.MdiParent = Me

        child_frmSignUp.StartPosition = FormStartPosition.Manual
        child_frmSignUp.Location = New Point(350, 35)

        child_frmSignUp.lblSignUp.Text = "Add User"
        child_frmSignUp.btnSingUp.Text = "Add"
        child_frmSignUp.btnExit.Visible = False

        child_frmSignUp.Show()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)

        ClearMdiChildren()

        Dim child_frmUsers As New frmUsers()
        child_frmUsers.MdiParent = Me

        child_frmUsers.StartPosition = FormStartPosition.Manual
        child_frmUsers.Location = New Point(350, 35)

        child_frmUsers.Show()

    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click

        ClearMdiChildren()

        Dim child_frmUsers As New frmUsers()
        child_frmUsers.MdiParent = Me

        child_frmUsers.StartPosition = FormStartPosition.Manual
        child_frmUsers.Location = New Point(350, 35)

        child_frmUsers.Show()
    End Sub



    Private Sub lblInfo_Click(sender As Object, e As EventArgs) Handles lblInfo.Click
        btnInfo.PerformClick()
    End Sub

    Private Sub lblAdd_Click(sender As Object, e As EventArgs) Handles lblAdd.Click
        btnAdd.PerformClick()

    End Sub

    Private Sub lblUpdate_Click(sender As Object, e As EventArgs) Handles lblUpdate.Click
        btnUpdate.PerformClick()
    End Sub


    Private Sub lblDeleteMe_Click(sender As Object, e As EventArgs) Handles lblDeleteMe.Click
        btnDeleteMe.PerformClick()
    End Sub

    Private Sub btnDeleteMe_Click(sender As Object, e As EventArgs) Handles btnDeleteMe.Click
        ClearMdiChildren()

        Dim child_frmDeleteMe As New frmDeleteMe()
        child_frmDeleteMe.MdiParent = Me

        child_frmDeleteMe.StartPosition = FormStartPosition.Manual
        child_frmDeleteMe.Location = New Point(350, 35)

        child_frmDeleteMe.Show()

    End Sub


    Private Sub btnEditPass_Click(sender As Object, e As EventArgs) Handles btnEditPass.Click
        ClearMdiChildren()

        Dim child_frmForgetPassword As New frmEditPass()
        child_frmForgetPassword.MdiParent = Me

        child_frmForgetPassword.StartPosition = FormStartPosition.Manual
        child_frmForgetPassword.Location = New Point(350, 100)

        child_frmForgetPassword.Show()

    End Sub

    Private Sub lblEditPass_Click(sender As Object, e As EventArgs) Handles lblEditPass.Click
        btnEditPass.PerformClick()
    End Sub


    Private Sub btnExitCustomers_Click(sender As Object, e As EventArgs) Handles btnExitCustomers.Click

        Application.Exit()

    End Sub

    Private Sub btnViewCustomers_Click(sender As Object, e As EventArgs) Handles btnViewCustomers.Click
        ClearMdiChildren()

        Dim child_frmViewCustomers As New frmViewCustomers()
        child_frmViewCustomers.MdiParent = Me

        child_frmViewCustomers.StartPosition = FormStartPosition.Manual
        child_frmViewCustomers.Location = New Point(120, 25)

        child_frmViewCustomers.Show()

    End Sub

    Private Sub lblViewCustomers_Click(sender As Object, e As EventArgs) Handles lblViewCustomers.Click
        btnViewCustomers.PerformClick()
    End Sub

    Private Sub btnAddCustomers_Click(sender As Object, e As EventArgs) Handles btnAddCustomers.Click
        ClearMdiChildren()

        Dim child_frmAddCustomers As New frmAddCustomers()
        child_frmAddCustomers.MdiParent = Me

        child_frmAddCustomers.StartPosition = FormStartPosition.Manual
        child_frmAddCustomers.Location = New Point(120, 25)

        child_frmAddCustomers.Show()
    End Sub

    Private Sub lblAddCutomers_Click(sender As Object, e As EventArgs) Handles lblAddCutomers.Click
        btnAddCustomers.PerformClick()
    End Sub

    Private Sub btnUpdateCustomer_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomer.Click
        ClearMdiChildren()

        Dim child_frmUpdateCustomers As New frmUpdateCustomers()
        child_frmUpdateCustomers.MdiParent = Me

        child_frmUpdateCustomers.StartPosition = FormStartPosition.Manual
        child_frmUpdateCustomers.Location = New Point(120, 25)

        child_frmUpdateCustomers.Show()
    End Sub

    Private Sub lblUpdateCustomers_Click(sender As Object, e As EventArgs) Handles lblUpdateCustomers.Click
        btnUpdateCustomer.PerformClick()
    End Sub

    Private Sub btnDeleteCustomers_Click(sender As Object, e As EventArgs) Handles btnDeleteCustomers.Click
        ClearMdiChildren()

        Dim child_frmDeleteCustomers As New frmDeleteCustomers()
        child_frmDeleteCustomers.MdiParent = Me

        child_frmDeleteCustomers.StartPosition = FormStartPosition.Manual
        child_frmDeleteCustomers.Location = New Point(120, 25)

        child_frmDeleteCustomers.Show()
    End Sub

    Private Sub lblDeleteCutomers_Click(sender As Object, e As EventArgs) Handles lblDeleteCutomers.Click
        btnDeleteCustomers.PerformClick()
    End Sub

    Private Sub btnViewProducts_Click(sender As Object, e As EventArgs) Handles btnViewProducts.Click
        ClearMdiChildren()

        Dim child_frmViewProductss As New frmViewProducts()
        child_frmViewProductss.MdiParent = Me

        child_frmViewProductss.StartPosition = FormStartPosition.Manual
        child_frmViewProductss.Location = New Point(120, 25)

        child_frmViewProductss.Show()
    End Sub

    Private Sub btnExitProducts_Click(sender As Object, e As EventArgs) Handles btnExitProducts.Click
        Application.Exit()
    End Sub

    Private Sub lblViewProducts_Click(sender As Object, e As EventArgs) Handles lblViewProducts.Click
        btnViewProducts.PerformClick()
    End Sub

    Private Sub btnAddProducts_CheckedChanged(sender As Object, e As EventArgs) Handles btnAddProducts.CheckedChanged
        ClearMdiChildren()

        Dim child_frmAddProducts As New frmAddProducts()
        child_frmAddProducts.MdiParent = Me

        child_frmAddProducts.StartPosition = FormStartPosition.Manual
        child_frmAddProducts.Location = New Point(120, 25)

        child_frmAddProducts.Show()
    End Sub

    Private Sub lblAddProducts_Click(sender As Object, e As EventArgs) Handles lblAddProducts.Click
        btnAddProducts.PerformClick()
    End Sub

    Private Sub btnUpdateProducts_Click(sender As Object, e As EventArgs) Handles btnUpdateProducts.Click
        ClearMdiChildren()

        Dim child_frmUpdateProducts As New frmUpdateProducts()
        child_frmUpdateProducts.MdiParent = Me

        child_frmUpdateProducts.StartPosition = FormStartPosition.Manual
        child_frmUpdateProducts.Location = New Point(120, 25)

        child_frmUpdateProducts.Show()
    End Sub

    Private Sub lblUpdateProducts_Click(sender As Object, e As EventArgs) Handles lblUpdateProducts.Click
        btnUpdateProducts.PerformClick()
    End Sub

    Private Sub btnDeleteProducts_Click(sender As Object, e As EventArgs) Handles btnDeleteProducts.Click
        ClearMdiChildren()

        Dim child_frmDeleteProducts As New frmDeleteProducts()
        child_frmDeleteProducts.MdiParent = Me

        child_frmDeleteProducts.StartPosition = FormStartPosition.Manual
        child_frmDeleteProducts.Location = New Point(120, 25)

        child_frmDeleteProducts.Show()
    End Sub

    Private Sub lblDeleteProducts_Click(sender As Object, e As EventArgs) Handles lblDeleteProducts.Click
        btnDeleteProducts.PerformClick()
    End Sub

    Private Sub btnMakeOrder_Click(sender As Object, e As EventArgs) Handles btnMakeOrder.Click
        ClearMdiChildren()

        Dim child_frmNewOrder As New frmNewOrder()
        child_frmNewOrder.MdiParent = Me

        child_frmNewOrder.StartPosition = FormStartPosition.Manual
        child_frmNewOrder.Location = New Point(120, 25)

        child_frmNewOrder.Show()
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click

    End Sub

    Private Sub btnOrderEixt_Click(sender As Object, e As EventArgs) Handles btnOrderEixt.Click
        Application.Exit()
    End Sub
End Class