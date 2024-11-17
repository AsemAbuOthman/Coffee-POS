Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports Guna.UI2.WinForms
Imports Microsoft.VisualBasic.ApplicationServices

Public Class frmNewOrder
    Private billingProduct As ProductAddToBilling ' Declare the billingProduct variable at the class level

    Private Sub frmNewOrder_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Conn.Open()

            Dim strQuery As String = "SELECT Product_id, Name, Description, Price, Image_data FROM Products"

            Cmd.CommandText = strQuery
            Reader = Cmd.ExecuteReader

            While Reader.Read()

                Dim product As New WidgetProductOrder()

                product.lblProductName.Text = Reader("Name").ToString()
                product.lblPrice.Text = Format(Reader("Price").ToString(), "Currency")
                product.txtProductDescription.Text = Reader("Description").ToString

                Dim picByte() As Byte = DirectCast(Reader("Image_data"), Byte())

                If picByte IsNot Nothing AndAlso picByte.Length > 0 Then

                    Dim picStream As New System.IO.MemoryStream(picByte)

                    If picStream.CanRead Then

                        product.btnAddImage.Enabled = True
                        product.btnAddImage.BackgroundImage = Image.FromStream(picStream)
                        product.btnAddImage.BackgroundImageLayout = ImageLayout.Zoom

                    End If

                    picStream.Close()

                End If

                product.Tag = picByte
                AddHandler product.btnAddToBilling.Click, AddressOf AddProductToOrder

                FlowLayoutPanel1.Controls.Add(product)

            End While

        Catch ex As Exception

            MessageBox.Show(ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        Finally

            If Conn.State = ConnectionState.Open Then

                Conn.Close()

            End If

        End Try

    End Sub

    Dim product As New WidgetProductOrder()

    Private Sub AddProductToOrder(sender As Object, e As EventArgs)
        Dim btnAddToOrder As Guna2Button = CType(sender, Guna2Button)
        Dim productWidget As Control = btnAddToOrder.Parent


        While productWidget IsNot Nothing AndAlso Not TypeOf productWidget Is WidgetProductOrder
            productWidget = productWidget.Parent
        End While

        If productWidget IsNot Nothing Then
            Dim productWidgetOrder As WidgetProductOrder = CType(productWidget, WidgetProductOrder)
            Dim productExists As Boolean = False

            For Each control As Control In flpBilling.Controls

                If TypeOf control Is ProductAddToBilling Then

                    Dim existingProduct As ProductAddToBilling = CType(control, ProductAddToBilling)

                    If existingProduct.lblProductName.Text = productWidgetOrder.lblProductName.Text Then

                        productExists = True

                        Exit For
                    End If
                End If
            Next

            If productExists Then
                MessageBox.Show("This product is already added.")
            Else
                ' Add new product to the billing panel
                billingProduct = New ProductAddToBilling()

                Dim picByte() As Byte = CType(productWidgetOrder.Tag, Byte())
                If picByte IsNot Nothing AndAlso picByte.Length > 0 Then
                    Using picStream As New MemoryStream(picByte)
                        If picStream.CanRead Then
                            billingProduct.btnAddImage.Enabled = True
                            billingProduct.btnAddImage.BackgroundImage = Image.FromStream(picStream)
                            billingProduct.btnAddImage.BackgroundImageLayout = ImageLayout.Zoom
                        End If
                    End Using
                End If

                billingProduct.lblQunantity.Text = "1"
                billingProduct.btnAddProductQuantity.Enabled = True
                billingProduct.btnAddProductQuantity.BackgroundImage = My.Resources.icons8_add_80
                billingProduct.btnAddProductQuantity.BackgroundImageLayout = ImageLayout.Zoom

                billingProduct.btnLessProductQuntity.Enabled = True
                billingProduct.btnLessProductQuntity.BackgroundImage = My.Resources.icons8_remove_80__2_
                billingProduct.btnLessProductQuntity.BackgroundImageLayout = ImageLayout.Zoom

                billingProduct.lblProductName.Text = productWidgetOrder.lblProductName.Text
                billingProduct.lblPrice.Text = Format(CDec(productWidgetOrder.lblPrice.Text.Replace("$", "")), "Currency")

                flpBilling.Controls.Add(billingProduct)

                lblTotalPrice.Text = "Total Price : " & Format(CalculateTotalPrice(), "Currency")
            End If
        Else
            MessageBox.Show("Parent WidgetProductOrder not found.")
        End If
    End Sub

    Private Sub btnConfirmOrder_Click_1(sender As Object, e As EventArgs) Handles btnConfirmOrder.Click

        frmRecipte.rtbRecipte.Text = ""

        Dim result As DialogResult = MessageBox.Show("Are you sure you want To confirm the order?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            ConfirmOrder()

        End If

    End Sub

    Private Sub ConfirmOrder()

        Dim orderID As Integer = GenerateReceipt()


        If orderID > 0 Then

            DisplayReceipt(orderID, CalculateTotalPrice)

        Else

            MessageBox.Show("Failed To generate receipt. Please Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Function GenerateReceipt() As Integer
        Dim receiptText As New StringBuilder()

        ' Order information
        Dim orderID As Integer = 12345
        Dim orderDate As DateTime = DateTime.Now

        receiptText.AppendLine($"Order ID: {orderID}")
        receiptText.AppendLine($"Order Date: {orderDate}")
        receiptText.AppendLine("Total Price: $10.50")
        receiptText.AppendLine()

        ' Order details
        receiptText.AppendLine("Order Details:")
        receiptText.AppendLine("--------------------------------------------")

        For Each control As Control In flpBilling.Controls
            If TypeOf control Is ProductAddToBilling Then
                Dim billingProduct As ProductAddToBilling = DirectCast(control, ProductAddToBilling)

                Dim productName As String = billingProduct.lblProductName.Text
                Dim unitPrice As Decimal = Decimal.Parse(billingProduct.lblPrice.Text.Replace("$", ""))
                Dim quantity As Integer = Integer.Parse(billingProduct.lblQunantity.Text)
                Dim totalProductPrice As Decimal = unitPrice * quantity

                receiptText.AppendLine($"{productName} (Unit Price: ${unitPrice}, Quantity: {quantity}, Total Price: ${totalProductPrice})")
            End If
        Next

        frmRecipte.rtbRecipte.Text = receiptText.ToString()

        Return orderID
    End Function

    Private Function CalculateTotalPrice() As Decimal

        Dim totalPrice As Decimal = 0

        For Each control As Control In flpBilling.Controls

            If TypeOf control Is ProductAddToBilling Then

                Dim billingProduct As ProductAddToBilling = DirectCast(control, ProductAddToBilling)

                Dim unitPrice As Decimal = Decimal.Parse(billingProduct.lblPrice.Text.Replace("$", ""))
                Dim quantity As Integer = Integer.Parse(billingProduct.lblQunantity.Text)

                totalPrice += unitPrice * quantity

            End If
        Next

        Return totalPrice
    End Function

    Private Function GetProductID(productName As String) As Integer
        Return 0
    End Function

    Private Sub DisplayReceipt(orderID As Integer, totalPrice As Decimal)

        frmRecipte.rtbRecipte.Text = ""


        Dim orderInfo As String = $"Order ID: {orderID}" & Environment.NewLine &
                              $"Order Date: {DateTime.Now}" & Environment.NewLine & Environment.NewLine


        frmRecipte.rtbRecipte.AppendText(orderInfo)


        Dim orderDetails As New StringBuilder()


        orderDetails.AppendLine("Items" & vbTab & vbTab & vbTab & vbTab & vbTab & "Qty" & vbTab & vbTab & "Rate" & vbTab & vbTab & "Amount")
        orderDetails.AppendLine("--------------------------------------------------------------------------------------")

        For Each control As Control In flpBilling.Controls

            If TypeOf control Is ProductAddToBilling Then

                Dim billingProduct As ProductAddToBilling = CType(control, ProductAddToBilling)

                Dim productName As String = billingProduct.lblProductName.Text
                Dim unitPrice As Decimal = Decimal.Parse(billingProduct.lblPrice.Text.Replace("$", ""))
                Dim quantity As Integer = Integer.Parse(billingProduct.lblQunantity.Text)
                Dim totalProductPrice As Decimal = unitPrice * quantity


                orderDetails.AppendLine(productName.PadRight(45) & quantity & vbTab & vbTab & unitPrice & vbTab & vbTab & totalProductPrice.ToString.PadLeft(0))

            End If
        Next

        orderDetails.AppendLine("--------------------------------------------------------------------------------------")
        orderDetails.AppendLine(Environment.NewLine & Environment.NewLine & $"Total Price: ${totalPrice}" & Environment.NewLine & Environment.NewLine)


        frmRecipte.rtbRecipte.AppendText(orderDetails.ToString())

        frmRecipte.ShowDialog()
    End Sub


End Class
