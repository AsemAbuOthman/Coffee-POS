<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnLogIn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnSingUp = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lnkForgetPassword = New System.Windows.Forms.LinkLabel()
        Me.chkRemmberMe = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.lblRemmberMe = New System.Windows.Forms.Label()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogIn
        '
        Me.btnLogIn.Animated = True
        Me.btnLogIn.BackColor = System.Drawing.Color.Transparent
        Me.btnLogIn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnLogIn.BorderRadius = 10
        Me.btnLogIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLogIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLogIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLogIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLogIn.FillColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnLogIn.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnLogIn.ForeColor = System.Drawing.Color.White
        Me.btnLogIn.HoverState.BorderColor = System.Drawing.Color.Transparent
        Me.btnLogIn.Location = New System.Drawing.Point(335, 284)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.PressedColor = System.Drawing.Color.Transparent
        Me.btnLogIn.PressedDepth = 100
        Me.btnLogIn.Size = New System.Drawing.Size(336, 56)
        Me.btnLogIn.TabIndex = 3
        Me.btnLogIn.Text = "Log In"
        Me.btnLogIn.UseTransparentBackground = True
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Guna2Panel1.Controls.Add(Me.btnSingUp)
        Me.Guna2Panel1.Controls.Add(Me.Label4)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(280, 430)
        Me.Guna2Panel1.TabIndex = 5
        '
        'btnSingUp
        '
        Me.btnSingUp.Animated = True
        Me.btnSingUp.AutoRoundedCorners = True
        Me.btnSingUp.BackColor = System.Drawing.Color.Transparent
        Me.btnSingUp.BorderColor = System.Drawing.Color.White
        Me.btnSingUp.BorderRadius = 27
        Me.btnSingUp.BorderThickness = 2
        Me.btnSingUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSingUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSingUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSingUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSingUp.FillColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnSingUp.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnSingUp.ForeColor = System.Drawing.Color.White
        Me.btnSingUp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSingUp.Location = New System.Drawing.Point(19, 301)
        Me.btnSingUp.Name = "btnSingUp"
        Me.btnSingUp.PressedColor = System.Drawing.Color.Transparent
        Me.btnSingUp.PressedDepth = 100
        Me.btnSingUp.Size = New System.Drawing.Size(241, 56)
        Me.btnSingUp.TabIndex = 0
        Me.btnSingUp.Text = "Sign Up"
        Me.btnSingUp.UseTransparentBackground = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(5, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(272, 64)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = """If you don't have an" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  account Create a one""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 53)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Welcome !"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.AutoRoundedCorners = True
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackgroundImage = Global.Coffee_Shop.My.Resources.Resources.cross__1_
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnExit.BorderColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnExit.BorderRadius = 25
        Me.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnExit.FillColor = System.Drawing.Color.Transparent
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnExit.ForeColor = System.Drawing.Color.Transparent
        Me.btnExit.IndicateFocus = True
        Me.btnExit.Location = New System.Drawing.Point(655, 1)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(63, 52)
        Me.btnExit.TabIndex = 5
        Me.btnExit.UseTransparentBackground = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(300, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 38)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Log In Here !"
        '
        'txtPassword
        '
        Me.txtPassword.Animated = True
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtPassword.BorderRadius = 5
        Me.txtPassword.BorderThickness = 2
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FillColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtPassword.ForeColor = System.Drawing.Color.Black
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.IconRight = Global.Coffee_Shop.My.Resources.Resources.eye__1_
        Me.txtPassword.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.txtPassword.IconRightSize = New System.Drawing.Size(30, 30)
        Me.txtPassword.Location = New System.Drawing.Point(335, 170)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtPassword.MaxLength = 50
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.Size = New System.Drawing.Size(336, 51)
        Me.txtPassword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(283, 324)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(440, 33)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "_________________________"
        '
        'txtUsername
        '
        Me.txtUsername.Animated = True
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtUsername.BorderRadius = 5
        Me.txtUsername.BorderThickness = 2
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FillColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtUsername.ForeColor = System.Drawing.Color.Black
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(335, 109)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(133, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.txtUsername.PlaceholderText = "Username "
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(336, 51)
        Me.txtUsername.TabIndex = 0
        '
        'lnkForgetPassword
        '
        Me.lnkForgetPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lnkForgetPassword.AutoSize = True
        Me.lnkForgetPassword.BackColor = System.Drawing.Color.Transparent
        Me.lnkForgetPassword.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lnkForgetPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lnkForgetPassword.LinkColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lnkForgetPassword.Location = New System.Drawing.Point(411, 371)
        Me.lnkForgetPassword.Name = "lnkForgetPassword"
        Me.lnkForgetPassword.Size = New System.Drawing.Size(192, 30)
        Me.lnkForgetPassword.TabIndex = 4
        Me.lnkForgetPassword.TabStop = True
        Me.lnkForgetPassword.Text = "Forget Password ?"
        Me.lnkForgetPassword.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        '
        'chkRemmberMe
        '
        Me.chkRemmberMe.Animated = True
        Me.chkRemmberMe.BackColor = System.Drawing.Color.Transparent
        Me.chkRemmberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chkRemmberMe.CheckedState.BorderRadius = 2
        Me.chkRemmberMe.CheckedState.BorderThickness = 1
        Me.chkRemmberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chkRemmberMe.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 18.0!)
        Me.chkRemmberMe.Location = New System.Drawing.Point(335, 242)
        Me.chkRemmberMe.Name = "chkRemmberMe"
        Me.chkRemmberMe.Size = New System.Drawing.Size(30, 25)
        Me.chkRemmberMe.TabIndex = 2
        Me.chkRemmberMe.Text = "Remmber me"
        Me.chkRemmberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.chkRemmberMe.UncheckedState.BorderRadius = 1
        Me.chkRemmberMe.UncheckedState.BorderThickness = 2
        Me.chkRemmberMe.UncheckedState.FillColor = System.Drawing.Color.Transparent
        '
        'lblRemmberMe
        '
        Me.lblRemmberMe.AutoSize = True
        Me.lblRemmberMe.BackColor = System.Drawing.Color.Transparent
        Me.lblRemmberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblRemmberMe.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 15.0!)
        Me.lblRemmberMe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(113, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lblRemmberMe.Location = New System.Drawing.Point(371, 240)
        Me.lblRemmberMe.Name = "lblRemmberMe"
        Me.lblRemmberMe.Size = New System.Drawing.Size(134, 27)
        Me.lblRemmberMe.TabIndex = 16
        Me.lblRemmberMe.Text = "Remmber me"
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 3
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(719, 430)
        Me.Panel1.TabIndex = 17
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(719, 430)
        Me.Controls.Add(Me.lblRemmberMe)
        Me.Controls.Add(Me.chkRemmberMe)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.lnkForgetPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnExit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSingUp As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lnkForgetPassword As LinkLabel
    Friend WithEvents chkRemmberMe As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents lblRemmberMe As Label
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Panel1 As Panel
End Class
