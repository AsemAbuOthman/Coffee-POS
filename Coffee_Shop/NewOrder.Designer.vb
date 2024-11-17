<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.flpBilling = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnConfirmOrder = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.pnlTotalBilling = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblOrderingProduct = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.pnlTotalBilling.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimationInterval = 250
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER
        Me.Guna2BorderlessForm1.BorderRadius = 5
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockForm = False
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 1.0R
        Me.Guna2BorderlessForm1.DragForm = False
        Me.Guna2BorderlessForm1.DragOrientation = Guna.UI2.WinForms.Enums.DragOrientation.Vertical
        Me.Guna2BorderlessForm1.DragStartTransparencyValue = 0.5R
        Me.Guna2BorderlessForm1.HasFormShadow = False
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(980, 646)
        Me.Panel1.TabIndex = 25
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Guna2GradientPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SplitContainer1.Panel2.Controls.Add(Me.flpBilling)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pnlTotalBilling)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Guna2Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(980, 646)
        Me.SplitContainer1.SplitterDistance = 735
        Me.SplitContainer1.TabIndex = 0
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.AutoScroll = True
        Me.Guna2GradientPanel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(735, 646)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(735, 646)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'flpBilling
        '
        Me.flpBilling.AutoScroll = True
        Me.flpBilling.BackColor = System.Drawing.Color.Gainsboro
        Me.flpBilling.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.flpBilling.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.flpBilling.Location = New System.Drawing.Point(0, 95)
        Me.flpBilling.Margin = New System.Windows.Forms.Padding(0)
        Me.flpBilling.Name = "flpBilling"
        Me.flpBilling.Size = New System.Drawing.Size(241, 423)
        Me.flpBilling.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel1.Controls.Add(Me.btnConfirmOrder)
        Me.Guna2Panel1.Controls.Add(Me.lblTotalPrice)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 518)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(241, 128)
        Me.Guna2Panel1.TabIndex = 1
        '
        'btnConfirmOrder
        '
        Me.btnConfirmOrder.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConfirmOrder.Animated = True
        Me.btnConfirmOrder.AutoRoundedCorners = True
        Me.btnConfirmOrder.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirmOrder.BorderColor = System.Drawing.Color.White
        Me.btnConfirmOrder.BorderRadius = 23
        Me.btnConfirmOrder.BorderThickness = 2
        Me.btnConfirmOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnConfirmOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnConfirmOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnConfirmOrder.FillColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnConfirmOrder.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnConfirmOrder.ForeColor = System.Drawing.Color.White
        Me.btnConfirmOrder.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnConfirmOrder.Location = New System.Drawing.Point(38, 68)
        Me.btnConfirmOrder.Name = "btnConfirmOrder"
        Me.btnConfirmOrder.PressedColor = System.Drawing.Color.Transparent
        Me.btnConfirmOrder.PressedDepth = 100
        Me.btnConfirmOrder.Size = New System.Drawing.Size(166, 48)
        Me.btnConfirmOrder.TabIndex = 62
        Me.btnConfirmOrder.Text = "Confirm"
        Me.btnConfirmOrder.UseTransparentBackground = True
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotalPrice.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblTotalPrice.Location = New System.Drawing.Point(3, 12)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(127, 32)
        Me.lblTotalPrice.TabIndex = 61
        Me.lblTotalPrice.Text = "Total price"
        '
        'pnlTotalBilling
        '
        Me.pnlTotalBilling.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlTotalBilling.Controls.Add(Me.lblOrderingProduct)
        Me.pnlTotalBilling.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTotalBilling.Location = New System.Drawing.Point(0, 0)
        Me.pnlTotalBilling.Name = "pnlTotalBilling"
        Me.pnlTotalBilling.Size = New System.Drawing.Size(241, 100)
        Me.pnlTotalBilling.TabIndex = 2
        '
        'lblOrderingProduct
        '
        Me.lblOrderingProduct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblOrderingProduct.AutoSize = True
        Me.lblOrderingProduct.BackColor = System.Drawing.Color.Transparent
        Me.lblOrderingProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblOrderingProduct.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 30.0!, System.Drawing.FontStyle.Bold)
        Me.lblOrderingProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblOrderingProduct.Location = New System.Drawing.Point(29, 18)
        Me.lblOrderingProduct.Name = "lblOrderingProduct"
        Me.lblOrderingProduct.Size = New System.Drawing.Size(134, 53)
        Me.lblOrderingProduct.TabIndex = 56
        Me.lblOrderingProduct.Text = "Billing"
        '
        'frmNewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(980, 646)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNewOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SignUp"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.pnlTotalBilling.ResumeLayout(False)
        Me.pnlTotalBilling.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents flpBilling As FlowLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents btnConfirmOrder As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnlTotalBilling As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblOrderingProduct As Label
End Class
