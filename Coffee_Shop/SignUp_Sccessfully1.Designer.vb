<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSignUp_Sccessfully1
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
        Me.pnlNotify = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSignUp = New System.Windows.Forms.Label()
        Me.picNotify = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlNotify.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picNotify, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlNotify
        '
        Me.pnlNotify.Controls.Add(Me.Panel1)
        Me.pnlNotify.Controls.Add(Me.picNotify)
        Me.pnlNotify.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNotify.Location = New System.Drawing.Point(0, 0)
        Me.pnlNotify.Name = "pnlNotify"
        Me.pnlNotify.Size = New System.Drawing.Size(411, 258)
        Me.pnlNotify.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblSignUp)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 186)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(411, 72)
        Me.Panel1.TabIndex = 17
        '
        'lblSignUp
        '
        Me.lblSignUp.AutoSize = True
        Me.lblSignUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.lblSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblSignUp.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 20.0!)
        Me.lblSignUp.ForeColor = System.Drawing.Color.White
        Me.lblSignUp.Location = New System.Drawing.Point(10, 11)
        Me.lblSignUp.Name = "lblSignUp"
        Me.lblSignUp.Size = New System.Drawing.Size(389, 36)
        Me.lblSignUp.TabIndex = 16
        Me.lblSignUp.Text = "Account Created Successfully !"
        '
        'picNotify
        '
        Me.picNotify.BackColor = System.Drawing.Color.Gainsboro
        Me.picNotify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picNotify.Dock = System.Windows.Forms.DockStyle.Top
        Me.picNotify.FillColor = System.Drawing.Color.Transparent
        Me.picNotify.ImageRotate = 0!
        Me.picNotify.InitialImage = Global.Coffee_Shop.My.Resources.Resources.Correct
        Me.picNotify.Location = New System.Drawing.Point(0, 0)
        Me.picNotify.Name = "picNotify"
        Me.picNotify.Size = New System.Drawing.Size(411, 180)
        Me.picNotify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picNotify.TabIndex = 0
        Me.picNotify.TabStop = False
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.BorderRadius = 5
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Timer1
        '
        '
        'frmSignUp_Sccessfully
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(411, 258)
        Me.Controls.Add(Me.pnlNotify)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSignUp_Sccessfully"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SignUp_Sccessfully"
        Me.pnlNotify.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picNotify, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlNotify As Panel
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents picNotify As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblSignUp As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
End Class
