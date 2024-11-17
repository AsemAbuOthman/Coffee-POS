Imports Guna.UI2.WinForms

Public Class ProductAddToBilling

    Private Sub btnAddProductQuantity_Click(sender As Object, e As EventArgs) Handles btnAddProductQuantity.Click

        Dim btnAddProductQuantity As Guna2Button = CType(sender, Guna2Button)
        Dim productWidget As Control = btnAddProductQuantity.Parent

        While productWidget IsNot Nothing AndAlso Not TypeOf productWidget Is ProductAddToBilling

            productWidget = productWidget.Parent

        End While

        If productWidget IsNot Nothing Then

            Dim billingProduct As ProductAddToBilling = CType(productWidget, ProductAddToBilling)
            Dim quantity As Integer = Integer.Parse(billingProduct.lblQunantity.Text)

            billingProduct.lblQunantity.Text = (quantity + 1).ToString()

        End If
    End Sub

    Private Sub btnLessProductQuntity_Click(sender As Object, e As EventArgs) Handles btnLessProductQuntity.Click

        Dim btnLessProductQuntity As Guna2Button = CType(sender, Guna2Button)
        Dim productWidget As Control = btnLessProductQuntity.Parent

        While productWidget IsNot Nothing AndAlso Not TypeOf productWidget Is ProductAddToBilling

            productWidget = productWidget.Parent

        End While

        If productWidget IsNot Nothing Then

            Dim billingProduct As ProductAddToBilling = CType(productWidget, ProductAddToBilling)
            Dim quantity As Integer = Integer.Parse(billingProduct.lblQunantity.Text)

            If quantity > 0 Then

                billingProduct.lblQunantity.Text = (quantity - 1).ToString()

            End If

            If quantity <= 1 Then

                Dim frmNewOrder As frmNewOrder = CType(FindForm(), frmNewOrder)

                If frmNewOrder.flpBilling.Controls.Contains(billingProduct) Then

                    frmNewOrder.flpBilling.Controls.Remove(billingProduct)
                    frmNewOrder.flpBilling.Refresh() ' Refresh the display

                Else

                    MessageBox.Show("Control not found in FlowLayoutPanel2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            End If

        End If

    End Sub
End Class
