<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WidgetProductOrder
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtProductDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAddToBilling = New Guna.UI2.WinForms.Guna2Button()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.btnAddImage = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtProductDescription)
        Me.Panel1.Controls.Add(Me.btnAddToBilling)
        Me.Panel1.Controls.Add(Me.lblPrice)
        Me.Panel1.Controls.Add(Me.lblProductName)
        Me.Panel1.Controls.Add(Me.btnAddImage)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 232)
        Me.Panel1.TabIndex = 26
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Animated = True
        Me.txtProductDescription.BackColor = System.Drawing.Color.Transparent
        Me.txtProductDescription.BorderColor = System.Drawing.Color.Gainsboro
        Me.txtProductDescription.BorderRadius = 5
        Me.txtProductDescription.BorderThickness = 2
        Me.txtProductDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtProductDescription.DefaultText = ""
        Me.txtProductDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductDescription.Enabled = False
        Me.txtProductDescription.FillColor = System.Drawing.Color.Gainsboro
        Me.txtProductDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductDescription.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtProductDescription.ForeColor = System.Drawing.Color.Empty
        Me.txtProductDescription.HideSelection = False
        Me.txtProductDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductDescription.Location = New System.Drawing.Point(151, 42)
        Me.txtProductDescription.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtProductDescription.MaxLength = 50
        Me.txtProductDescription.Multiline = True
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductDescription.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(118, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.txtProductDescription.PlaceholderText = "Product Descripton*"
        Me.txtProductDescription.ReadOnly = True
        Me.txtProductDescription.SelectedText = ""
        Me.txtProductDescription.Size = New System.Drawing.Size(181, 70)
        Me.txtProductDescription.TabIndex = 54
        '
        'btnAddToBilling
        '
        Me.btnAddToBilling.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAddToBilling.Animated = True
        Me.btnAddToBilling.AutoRoundedCorners = True
        Me.btnAddToBilling.BackColor = System.Drawing.Color.Transparent
        Me.btnAddToBilling.BorderColor = System.Drawing.Color.White
        Me.btnAddToBilling.BorderRadius = 27
        Me.btnAddToBilling.BorderThickness = 2
        Me.btnAddToBilling.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddToBilling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddToBilling.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddToBilling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddToBilling.FillColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnAddToBilling.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnAddToBilling.ForeColor = System.Drawing.Color.White
        Me.btnAddToBilling.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnAddToBilling.Location = New System.Drawing.Point(50, 158)
        Me.btnAddToBilling.Name = "btnAddToBilling"
        Me.btnAddToBilling.PressedColor = System.Drawing.Color.Transparent
        Me.btnAddToBilling.PressedDepth = 100
        Me.btnAddToBilling.Size = New System.Drawing.Size(249, 56)
        Me.btnAddToBilling.TabIndex = 32
        Me.btnAddToBilling.Text = "Add to billing"
        Me.btnAddToBilling.UseTransparentBackground = True
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrice.AutoSize = True
        Me.lblPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPrice.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 13.0!, System.Drawing.FontStyle.Bold)
        Me.lblPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblPrice.Location = New System.Drawing.Point(147, 117)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(51, 24)
        Me.lblPrice.TabIndex = 53
        Me.lblPrice.Text = "Price"
        '
        'lblProductName
        '
        Me.lblProductName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProductName.AutoSize = True
        Me.lblProductName.BackColor = System.Drawing.Color.Transparent
        Me.lblProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblProductName.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblProductName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblProductName.Location = New System.Drawing.Point(146, 11)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(136, 26)
        Me.lblProductName.TabIndex = 52
        Me.lblProductName.Text = "Product Name"
        '
        'btnAddImage
        '
        Me.btnAddImage.Animated = True
        Me.btnAddImage.BackColor = System.Drawing.Color.Transparent
        Me.btnAddImage.BackgroundImage = Global.Coffee_Shop.My.Resources.Resources.icons8_plus_80
        Me.btnAddImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
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
        Me.btnAddImage.Location = New System.Drawing.Point(12, 12)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(119, 129)
        Me.btnAddImage.TabIndex = 47
        '
        'WidgetProductOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "WidgetProductOrder"
        Me.Size = New System.Drawing.Size(357, 232)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtProductDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAddToBilling As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents btnAddImage As Guna.UI2.WinForms.Guna2Button
End Class
