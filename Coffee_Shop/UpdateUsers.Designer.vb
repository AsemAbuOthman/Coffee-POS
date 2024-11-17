<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUpdateUsers
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
        Me.txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblUpdateInfo = New System.Windows.Forms.Label()
        Me.btnUpdate = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.cmbDay = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbMonth = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbYear = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.rdoMale = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.rdoFemale = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Animated = True
        Me.txtFirstName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtFirstName.BorderRadius = 5
        Me.txtFirstName.BorderThickness = 2
        Me.txtFirstName.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtFirstName.DefaultText = ""
        Me.txtFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtFirstName.FillColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtFirstName.ForeColor = System.Drawing.Color.Empty
        Me.txtFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(21, 133)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtFirstName.MaxLength = 30
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtFirstName.PlaceholderText = "First name"
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.Size = New System.Drawing.Size(231, 51)
        Me.txtFirstName.TabIndex = 0
        '
        'txtUsername
        '
        Me.txtUsername.Animated = True
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtUsername.BorderRadius = 5
        Me.txtUsername.BorderThickness = 2
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtUsername.DefaultText = ""
        Me.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUsername.FillColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtUsername.ForeColor = System.Drawing.Color.Empty
        Me.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsername.IconRightCursor = System.Windows.Forms.Cursors.No
        Me.txtUsername.IconRightOffset = New System.Drawing.Point(2, 2)
        Me.txtUsername.IconRightSize = New System.Drawing.Size(30, 30)
        Me.txtUsername.Location = New System.Drawing.Point(22, 222)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtUsername.MaxLength = 50
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtUsername.PlaceholderText = "Username"
        Me.txtUsername.ReadOnly = True
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.Size = New System.Drawing.Size(493, 51)
        Me.txtUsername.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.Animated = True
        Me.txtLastName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtLastName.BorderRadius = 5
        Me.txtLastName.BorderThickness = 2
        Me.txtLastName.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtLastName.DefaultText = ""
        Me.txtLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLastName.FillColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtLastName.ForeColor = System.Drawing.Color.Empty
        Me.txtLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(283, 133)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtLastName.MaxLength = 30
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtLastName.PlaceholderText = "Last name"
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.Size = New System.Drawing.Size(231, 51)
        Me.txtLastName.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.Animated = True
        Me.txtEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtEmail.BorderRadius = 5
        Me.txtEmail.BorderThickness = 2
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FillColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtEmail.ForeColor = System.Drawing.Color.Empty
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(22, 320)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtEmail.PlaceholderText = "Email"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(493, 51)
        Me.txtEmail.TabIndex = 4
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.BackColor = System.Drawing.Color.Transparent
        Me.lblLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblLine.Location = New System.Drawing.Point(-1, 63)
        Me.lblLine.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(542, 33)
        Me.lblLine.TabIndex = 14
        Me.lblLine.Text = "_______________________________"
        '
        'lblUpdateInfo
        '
        Me.lblUpdateInfo.AutoSize = True
        Me.lblUpdateInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblUpdateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUpdateInfo.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblUpdateInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblUpdateInfo.Location = New System.Drawing.Point(12, 23)
        Me.lblUpdateInfo.Name = "lblUpdateInfo"
        Me.lblUpdateInfo.Size = New System.Drawing.Size(228, 51)
        Me.lblUpdateInfo.TabIndex = 15
        Me.lblUpdateInfo.Text = "Update Info"
        '
        'btnUpdate
        '
        Me.btnUpdate.Animated = True
        Me.btnUpdate.AutoRoundedCorners = True
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BorderColor = System.Drawing.Color.White
        Me.btnUpdate.BorderRadius = 27
        Me.btnUpdate.BorderThickness = 2
        Me.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUpdate.FillColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(145, 532)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.PressedColor = System.Drawing.Color.Transparent
        Me.btnUpdate.PressedDepth = 100
        Me.btnUpdate.Size = New System.Drawing.Size(241, 56)
        Me.btnUpdate.TabIndex = 10
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseTransparentBackground = True
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
        'cmbDay
        '
        Me.cmbDay.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbDay.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.cmbDay.BorderRadius = 5
        Me.cmbDay.BorderThickness = 2
        Me.cmbDay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbDay.DropDownHeight = 120
        Me.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDay.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbDay.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.cmbDay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbDay.IntegralHeight = False
        Me.cmbDay.ItemHeight = 30
        Me.cmbDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbDay.Location = New System.Drawing.Point(21, 411)
        Me.cmbDay.MaxDropDownItems = 3
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(149, 36)
        Me.cmbDay.TabIndex = 5
        '
        'cmbMonth
        '
        Me.cmbMonth.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbMonth.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.cmbMonth.BorderRadius = 5
        Me.cmbMonth.BorderThickness = 2
        Me.cmbMonth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbMonth.DropDownHeight = 120
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMonth.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbMonth.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.cmbMonth.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbMonth.IntegralHeight = False
        Me.cmbMonth.ItemHeight = 30
        Me.cmbMonth.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.Location = New System.Drawing.Point(176, 411)
        Me.cmbMonth.MaxDropDownItems = 3
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(183, 36)
        Me.cmbMonth.TabIndex = 6
        '
        'cmbYear
        '
        Me.cmbYear.AutoCompleteCustomSource.AddRange(New String() {"1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024"})
        Me.cmbYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbYear.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbYear.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.cmbYear.BorderRadius = 5
        Me.cmbYear.BorderThickness = 2
        Me.cmbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbYear.DropDownHeight = 120
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbYear.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.cmbYear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbYear.IntegralHeight = False
        Me.cmbYear.ItemHeight = 30
        Me.cmbYear.Items.AddRange(New Object() {"1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024"})
        Me.cmbYear.Location = New System.Drawing.Point(365, 411)
        Me.cmbYear.MaxDropDownItems = 3
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(149, 36)
        Me.cmbYear.TabIndex = 7
        '
        'rdoMale
        '
        Me.rdoMale.Animated = True
        Me.rdoMale.AutoSize = True
        Me.rdoMale.BackColor = System.Drawing.Color.Gainsboro
        Me.rdoMale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rdoMale.CheckedState.BorderThickness = 2
        Me.rdoMale.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdoMale.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rdoMale.CheckedState.InnerOffset = -4
        Me.rdoMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoMale.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.rdoMale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rdoMale.Location = New System.Drawing.Point(21, 483)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(78, 34)
        Me.rdoMale.TabIndex = 8
        Me.rdoMale.Text = "Male"
        Me.rdoMale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rdoMale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.rdoMale.UncheckedState.BorderThickness = 2
        Me.rdoMale.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rdoMale.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rdoMale.UncheckedState.InnerOffset = -4
        Me.rdoMale.UseVisualStyleBackColor = False
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.BackColor = System.Drawing.Color.Transparent
        Me.lblBirthday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblBirthday.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblBirthday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblBirthday.Location = New System.Drawing.Point(17, 387)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(82, 21)
        Me.lblBirthday.TabIndex = 22
        Me.lblBirthday.Text = "Birthday ?"
        '
        'rdoFemale
        '
        Me.rdoFemale.Animated = True
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.BackColor = System.Drawing.Color.Gainsboro
        Me.rdoFemale.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rdoFemale.CheckedState.BorderThickness = 2
        Me.rdoFemale.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdoFemale.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rdoFemale.CheckedState.InnerOffset = -4
        Me.rdoFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoFemale.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.rdoFemale.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rdoFemale.Location = New System.Drawing.Point(105, 483)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(100, 34)
        Me.rdoFemale.TabIndex = 9
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rdoFemale.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.rdoFemale.UncheckedState.BorderThickness = 2
        Me.rdoFemale.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rdoFemale.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rdoFemale.UncheckedState.InnerOffset = -4
        Me.rdoFemale.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 459)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 21)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Gender ?"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.rdoFemale)
        Me.Panel1.Controls.Add(Me.cmbMonth)
        Me.Panel1.Controls.Add(Me.lblBirthday)
        Me.Panel1.Controls.Add(Me.cmbDay)
        Me.Panel1.Controls.Add(Me.rdoMale)
        Me.Panel1.Controls.Add(Me.cmbYear)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 631)
        Me.Panel1.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(19, 293)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 21)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(21, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 21)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(279, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 21)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Last name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(19, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 21)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "First name"
        '
        'frmUpdateUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(540, 631)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.lblUpdateInfo)
        Me.Controls.Add(Me.lblLine)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateUsers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SignUp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblLine As Label
    Friend WithEvents lblUpdateInfo As Label
    Friend WithEvents btnUpdate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents cmbDay As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbYear As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cmbMonth As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblBirthday As Label
    Friend WithEvents rdoMale As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents rdoFemale As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
