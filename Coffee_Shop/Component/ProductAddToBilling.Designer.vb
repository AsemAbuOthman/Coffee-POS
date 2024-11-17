<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductAddToBilling
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.lblQunantity = New System.Windows.Forms.Label()
        Me.btnLessProductQuntity = New Guna.UI2.WinForms.Guna2Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.btnAddImage = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAddProductQuantity = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Guna2GradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2GradientPanel1.BorderRadius = 5
        Me.Guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.Guna2GradientPanel1.BorderThickness = 1
        Me.Guna2GradientPanel1.Controls.Add(Me.lblQunantity)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnLessProductQuntity)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblPrice)
        Me.Guna2GradientPanel1.Controls.Add(Me.lblProductName)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnAddImage)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnAddProductQuantity)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Color = System.Drawing.Color.Transparent
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(221, 113)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'lblQunantity
        '
        Me.lblQunantity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQunantity.AutoSize = True
        Me.lblQunantity.BackColor = System.Drawing.Color.Transparent
        Me.lblQunantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblQunantity.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblQunantity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblQunantity.Location = New System.Drawing.Point(143, 41)
        Me.lblQunantity.Name = "lblQunantity"
        Me.lblQunantity.Size = New System.Drawing.Size(17, 20)
        Me.lblQunantity.TabIndex = 64
        Me.lblQunantity.Text = "0"
        '
        'btnLessProductQuntity
        '
        Me.btnLessProductQuntity.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnLessProductQuntity.Animated = True
        Me.btnLessProductQuntity.AutoRoundedCorners = True
        Me.btnLessProductQuntity.BackColor = System.Drawing.Color.Transparent
        Me.btnLessProductQuntity.BackgroundImage = Global.Coffee_Shop.My.Resources.Resources.icons8_remove_80__2_
        Me.btnLessProductQuntity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLessProductQuntity.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnLessProductQuntity.BorderRadius = 16
        Me.btnLessProductQuntity.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLessProductQuntity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLessProductQuntity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLessProductQuntity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLessProductQuntity.Enabled = False
        Me.btnLessProductQuntity.FillColor = System.Drawing.Color.Empty
        Me.btnLessProductQuntity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLessProductQuntity.ForeColor = System.Drawing.Color.Transparent
        Me.btnLessProductQuntity.Location = New System.Drawing.Point(109, 64)
        Me.btnLessProductQuntity.Name = "btnLessProductQuntity"
        Me.btnLessProductQuntity.Size = New System.Drawing.Size(35, 35)
        Me.btnLessProductQuntity.TabIndex = 63
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(22, 79)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(43, 20)
        Me.lblPrice.TabIndex = 61
        Me.lblPrice.Text = "Price"
        '
        'lblProductName
        '
        Me.lblProductName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProductName.AutoSize = True
        Me.lblProductName.BackColor = System.Drawing.Color.Transparent
        Me.lblProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblProductName.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblProductName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblProductName.Location = New System.Drawing.Point(80, 16)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(115, 21)
        Me.lblProductName.TabIndex = 60
        Me.lblProductName.Text = "Product Name"
        '
        'btnAddImage
        '
        Me.btnAddImage.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAddImage.Animated = True
        Me.btnAddImage.BackColor = System.Drawing.Color.Transparent
        Me.btnAddImage.BackgroundImage = Global.Coffee_Shop.My.Resources.Resources.icons8_plus_80
        Me.btnAddImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddImage.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnAddImage.BorderRadius = 5
        Me.btnAddImage.BorderThickness = 2
        Me.btnAddImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddImage.Enabled = False
        Me.btnAddImage.FillColor = System.Drawing.Color.Transparent
        Me.btnAddImage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddImage.ForeColor = System.Drawing.Color.Transparent
        Me.btnAddImage.Location = New System.Drawing.Point(14, 16)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(60, 60)
        Me.btnAddImage.TabIndex = 59
        '
        'btnAddProductQuantity
        '
        Me.btnAddProductQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnAddProductQuantity.Animated = True
        Me.btnAddProductQuantity.AutoRoundedCorners = True
        Me.btnAddProductQuantity.BackColor = System.Drawing.Color.Transparent
        Me.btnAddProductQuantity.BackgroundImage = Global.Coffee_Shop.My.Resources.Resources.icons8_add_80
        Me.btnAddProductQuantity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddProductQuantity.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnAddProductQuantity.BorderRadius = 16
        Me.btnAddProductQuantity.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddProductQuantity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddProductQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddProductQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddProductQuantity.Enabled = False
        Me.btnAddProductQuantity.FillColor = System.Drawing.Color.Empty
        Me.btnAddProductQuantity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddProductQuantity.ForeColor = System.Drawing.Color.Transparent
        Me.btnAddProductQuantity.Location = New System.Drawing.Point(160, 64)
        Me.btnAddProductQuantity.Name = "btnAddProductQuantity"
        Me.btnAddProductQuantity.Size = New System.Drawing.Size(35, 35)
        Me.btnAddProductQuantity.TabIndex = 62
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 10
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Transparent
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'ProductAddToBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Name = "ProductAddToBilling"
        Me.Size = New System.Drawing.Size(221, 113)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnAddProductQuantity As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLessProductQuntity As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents btnAddImage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents lblQunantity As Label
End Class
