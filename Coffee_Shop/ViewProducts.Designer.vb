﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewProducts
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvViewProducts = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CreateDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Available = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Image_url = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Image_data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumberOfRow = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pnlProductImage = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnAddImage = New Guna.UI2.WinForms.Guna2Button()
        Me.lblProductImage = New System.Windows.Forms.Label()
        Me.cmbCategory = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cmbProduceSize = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.lblAvailablity = New System.Windows.Forms.Label()
        Me.rdoNotAvailable = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.rdoAvailable = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.txtProductDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.lblProductSize = New System.Windows.Forms.Label()
        Me.picSearch = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtSearchByProductName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnView = New Guna.UI2.WinForms.Guna2Button()
        Me.lblProductsInfo = New System.Windows.Forms.Label()
        Me.lblLine = New System.Windows.Forms.Label()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.txtProductPrice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtProductName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvViewProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.pnlProductImage.SuspendLayout()
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.dgvViewProducts)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(973, 631)
        Me.Panel1.TabIndex = 25
        '
        'dgvViewProducts
        '
        Me.dgvViewProducts.AllowUserToOrderColumns = True
        Me.dgvViewProducts.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.5!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvViewProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvViewProducts.BackgroundColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViewProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvViewProducts.ColumnHeadersHeight = 45
        Me.dgvViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvViewProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductName, Me.Description, Me.Category, Me.Price, Me.Size, Me.CreateDate, Me.Available, Me.Image_url, Me.Image_data, Me.NumberOfRow})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvViewProducts.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvViewProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvViewProducts.GridColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvViewProducts.Location = New System.Drawing.Point(0, 0)
        Me.dgvViewProducts.Name = "dgvViewProducts"
        Me.dgvViewProducts.ReadOnly = True
        Me.dgvViewProducts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvViewProducts.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvViewProducts.RowHeadersVisible = False
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        Me.dgvViewProducts.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvViewProducts.Size = New System.Drawing.Size(973, 214)
        Me.dgvViewProducts.TabIndex = 30
        Me.dgvViewProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvViewProducts.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvViewProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvViewProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvViewProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvViewProducts.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvViewProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvViewProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.dgvViewProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvViewProducts.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.dgvViewProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvViewProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgvViewProducts.ThemeStyle.HeaderStyle.Height = 45
        Me.dgvViewProducts.ThemeStyle.ReadOnly = True
        Me.dgvViewProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvViewProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvViewProducts.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dgvViewProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.dgvViewProducts.ThemeStyle.RowsStyle.Height = 22
        Me.dgvViewProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.dgvViewProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(80, Byte), Integer))
        '
        'ProductName
        '
        Me.ProductName.FillWeight = 120.0!
        Me.ProductName.HeaderText = "Product name"
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        '
        'Description
        '
        Me.Description.FillWeight = 120.0!
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Category
        '
        Me.Category.FillWeight = 160.0!
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        Me.Category.ReadOnly = True
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        '
        'Size
        '
        Me.Size.HeaderText = "Size"
        Me.Size.Name = "Size"
        Me.Size.ReadOnly = True
        '
        'CreateDate
        '
        Me.CreateDate.FillWeight = 120.0!
        Me.CreateDate.HeaderText = "Create Date"
        Me.CreateDate.Name = "CreateDate"
        Me.CreateDate.ReadOnly = True
        '
        'Available
        '
        Me.Available.HeaderText = "Available"
        Me.Available.Name = "Available"
        Me.Available.ReadOnly = True
        Me.Available.Visible = False
        '
        'Image_url
        '
        Me.Image_url.HeaderText = "Imgae_url"
        Me.Image_url.Name = "Image_url"
        Me.Image_url.ReadOnly = True
        Me.Image_url.Visible = False
        '
        'Image_data
        '
        Me.Image_data.HeaderText = "Image_date"
        Me.Image_data.Name = "Image_data"
        Me.Image_data.ReadOnly = True
        Me.Image_data.Visible = False
        '
        'NumberOfRow
        '
        Me.NumberOfRow.HeaderText = "No"
        Me.NumberOfRow.Name = "NumberOfRow"
        Me.NumberOfRow.ReadOnly = True
        Me.NumberOfRow.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pnlProductImage)
        Me.Panel2.Controls.Add(Me.lblProductImage)
        Me.Panel2.Controls.Add(Me.cmbCategory)
        Me.Panel2.Controls.Add(Me.cmbProduceSize)
        Me.Panel2.Controls.Add(Me.lblAvailablity)
        Me.Panel2.Controls.Add(Me.rdoNotAvailable)
        Me.Panel2.Controls.Add(Me.rdoAvailable)
        Me.Panel2.Controls.Add(Me.txtProductDescription)
        Me.Panel2.Controls.Add(Me.lblCategory)
        Me.Panel2.Controls.Add(Me.lblProductSize)
        Me.Panel2.Controls.Add(Me.picSearch)
        Me.Panel2.Controls.Add(Me.txtSearchByProductName)
        Me.Panel2.Controls.Add(Me.btnView)
        Me.Panel2.Controls.Add(Me.lblProductsInfo)
        Me.Panel2.Controls.Add(Me.lblLine)
        Me.Panel2.Controls.Add(Me.lblProductPrice)
        Me.Panel2.Controls.Add(Me.lblProductName)
        Me.Panel2.Controls.Add(Me.txtProductPrice)
        Me.Panel2.Controls.Add(Me.txtProductName)
        Me.Panel2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.ForeColor = System.Drawing.Color.Transparent
        Me.Panel2.Location = New System.Drawing.Point(0, 220)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(973, 411)
        Me.Panel2.TabIndex = 34
        '
        'pnlProductImage
        '
        Me.pnlProductImage.Controls.Add(Me.btnAddImage)
        Me.pnlProductImage.Location = New System.Drawing.Point(15, 100)
        Me.pnlProductImage.Name = "pnlProductImage"
        Me.pnlProductImage.Size = New System.Drawing.Size(130, 126)
        Me.pnlProductImage.TabIndex = 52
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
        Me.btnAddImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAddImage.Enabled = False
        Me.btnAddImage.FillColor = System.Drawing.Color.Transparent
        Me.btnAddImage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnAddImage.ForeColor = System.Drawing.Color.Transparent
        Me.btnAddImage.Location = New System.Drawing.Point(0, 0)
        Me.btnAddImage.Name = "btnAddImage"
        Me.btnAddImage.Size = New System.Drawing.Size(130, 126)
        Me.btnAddImage.TabIndex = 46
        '
        'lblProductImage
        '
        Me.lblProductImage.AutoSize = True
        Me.lblProductImage.BackColor = System.Drawing.Color.Transparent
        Me.lblProductImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblProductImage.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblProductImage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblProductImage.Location = New System.Drawing.Point(23, 229)
        Me.lblProductImage.Name = "lblProductImage"
        Me.lblProductImage.Size = New System.Drawing.Size(122, 21)
        Me.lblProductImage.TabIndex = 51
        Me.lblProductImage.Text = "Product Image."
        '
        'cmbCategory
        '
        Me.cmbCategory.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbCategory.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.cmbCategory.BorderRadius = 5
        Me.cmbCategory.BorderThickness = 2
        Me.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbCategory.DropDownHeight = 120
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.Enabled = False
        Me.cmbCategory.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbCategory.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.cmbCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbCategory.IntegralHeight = False
        Me.cmbCategory.ItemHeight = 30
        Me.cmbCategory.Items.AddRange(New Object() {"Coffee", "Tea", "Soda", "Milk", "Juice", "Water"})
        Me.cmbCategory.Location = New System.Drawing.Point(624, 162)
        Me.cmbCategory.MaxDropDownItems = 3
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(153, 36)
        Me.cmbCategory.TabIndex = 41
        '
        'cmbProduceSize
        '
        Me.cmbProduceSize.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbProduceSize.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.cmbProduceSize.BorderRadius = 5
        Me.cmbProduceSize.BorderThickness = 2
        Me.cmbProduceSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbProduceSize.DropDownHeight = 120
        Me.cmbProduceSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProduceSize.Enabled = False
        Me.cmbProduceSize.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbProduceSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbProduceSize.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.cmbProduceSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbProduceSize.IntegralHeight = False
        Me.cmbProduceSize.ItemHeight = 30
        Me.cmbProduceSize.Items.AddRange(New Object() {"Small", "Meduim", "Large"})
        Me.cmbProduceSize.Location = New System.Drawing.Point(798, 162)
        Me.cmbProduceSize.MaxDropDownItems = 3
        Me.cmbProduceSize.Name = "cmbProduceSize"
        Me.cmbProduceSize.Size = New System.Drawing.Size(148, 36)
        Me.cmbProduceSize.TabIndex = 39
        '
        'lblAvailablity
        '
        Me.lblAvailablity.AutoSize = True
        Me.lblAvailablity.BackColor = System.Drawing.Color.Transparent
        Me.lblAvailablity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblAvailablity.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblAvailablity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblAvailablity.Location = New System.Drawing.Point(620, 219)
        Me.lblAvailablity.Name = "lblAvailablity"
        Me.lblAvailablity.Size = New System.Drawing.Size(96, 21)
        Me.lblAvailablity.TabIndex = 49
        Me.lblAvailablity.Text = "Availablity ?"
        '
        'rdoNotAvailable
        '
        Me.rdoNotAvailable.Animated = True
        Me.rdoNotAvailable.AutoSize = True
        Me.rdoNotAvailable.BackColor = System.Drawing.Color.Gainsboro
        Me.rdoNotAvailable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rdoNotAvailable.CheckedState.BorderThickness = 2
        Me.rdoNotAvailable.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdoNotAvailable.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rdoNotAvailable.CheckedState.InnerOffset = -4
        Me.rdoNotAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoNotAvailable.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.rdoNotAvailable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rdoNotAvailable.Location = New System.Drawing.Point(786, 274)
        Me.rdoNotAvailable.Name = "rdoNotAvailable"
        Me.rdoNotAvailable.Size = New System.Drawing.Size(159, 34)
        Me.rdoNotAvailable.TabIndex = 48
        Me.rdoNotAvailable.Text = "Not Available"
        Me.rdoNotAvailable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rdoNotAvailable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.rdoNotAvailable.UncheckedState.BorderThickness = 2
        Me.rdoNotAvailable.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rdoNotAvailable.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rdoNotAvailable.UncheckedState.InnerOffset = -4
        Me.rdoNotAvailable.UseVisualStyleBackColor = False
        Me.rdoNotAvailable.Visible = False
        '
        'rdoAvailable
        '
        Me.rdoAvailable.Animated = True
        Me.rdoAvailable.AutoSize = True
        Me.rdoAvailable.BackColor = System.Drawing.Color.Gainsboro
        Me.rdoAvailable.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rdoAvailable.CheckedState.BorderThickness = 2
        Me.rdoAvailable.CheckedState.FillColor = System.Drawing.Color.Transparent
        Me.rdoAvailable.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rdoAvailable.CheckedState.InnerOffset = -4
        Me.rdoAvailable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoAvailable.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.rdoAvailable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.rdoAvailable.Location = New System.Drawing.Point(626, 274)
        Me.rdoAvailable.Name = "rdoAvailable"
        Me.rdoAvailable.Size = New System.Drawing.Size(117, 34)
        Me.rdoAvailable.TabIndex = 47
        Me.rdoAvailable.Text = "Available"
        Me.rdoAvailable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.rdoAvailable.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.rdoAvailable.UncheckedState.BorderThickness = 2
        Me.rdoAvailable.UncheckedState.FillColor = System.Drawing.Color.White
        Me.rdoAvailable.UncheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.rdoAvailable.UncheckedState.InnerOffset = -4
        Me.rdoAvailable.UseVisualStyleBackColor = False
        Me.rdoAvailable.Visible = False
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Animated = True
        Me.txtProductDescription.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtProductDescription.BorderRadius = 5
        Me.txtProductDescription.BorderThickness = 2
        Me.txtProductDescription.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtProductDescription.DefaultText = ""
        Me.txtProductDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductDescription.FillColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtProductDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductDescription.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtProductDescription.ForeColor = System.Drawing.Color.Empty
        Me.txtProductDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductDescription.Location = New System.Drawing.Point(185, 208)
        Me.txtProductDescription.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtProductDescription.MaxLength = 50
        Me.txtProductDescription.Multiline = True
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductDescription.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtProductDescription.PlaceholderText = "Product Descripton*"
        Me.txtProductDescription.ReadOnly = True
        Me.txtProductDescription.SelectedText = ""
        Me.txtProductDescription.Size = New System.Drawing.Size(386, 100)
        Me.txtProductDescription.TabIndex = 45
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BackColor = System.Drawing.Color.Transparent
        Me.lblCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblCategory.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblCategory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblCategory.Location = New System.Drawing.Point(620, 121)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(77, 21)
        Me.lblCategory.TabIndex = 42
        Me.lblCategory.Text = "Category"
        '
        'lblProductSize
        '
        Me.lblProductSize.AutoSize = True
        Me.lblProductSize.BackColor = System.Drawing.Color.Transparent
        Me.lblProductSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblProductSize.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblProductSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblProductSize.Location = New System.Drawing.Point(794, 121)
        Me.lblProductSize.Name = "lblProductSize"
        Me.lblProductSize.Size = New System.Drawing.Size(101, 21)
        Me.lblProductSize.TabIndex = 40
        Me.lblProductSize.Text = "Product Size"
        '
        'picSearch
        '
        Me.picSearch.BackgroundImage = Global.Coffee_Shop.My.Resources.Resources.icons8_search_80
        Me.picSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picSearch.FillColor = System.Drawing.Color.Transparent
        Me.picSearch.ImageRotate = 0!
        Me.picSearch.Location = New System.Drawing.Point(460, 24)
        Me.picSearch.Name = "picSearch"
        Me.picSearch.Size = New System.Drawing.Size(35, 35)
        Me.picSearch.TabIndex = 38
        Me.picSearch.TabStop = False
        '
        'txtSearchByProductName
        '
        Me.txtSearchByProductName.Animated = True
        Me.txtSearchByProductName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtSearchByProductName.BorderRadius = 5
        Me.txtSearchByProductName.BorderThickness = 2
        Me.txtSearchByProductName.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtSearchByProductName.DefaultText = ""
        Me.txtSearchByProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSearchByProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSearchByProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchByProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSearchByProductName.FillColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtSearchByProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchByProductName.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtSearchByProductName.ForeColor = System.Drawing.Color.Empty
        Me.txtSearchByProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSearchByProductName.Location = New System.Drawing.Point(502, 15)
        Me.txtSearchByProductName.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtSearchByProductName.MaxLength = 50
        Me.txtSearchByProductName.Name = "txtSearchByProductName"
        Me.txtSearchByProductName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSearchByProductName.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtSearchByProductName.PlaceholderText = "Search by Product name"
        Me.txtSearchByProductName.SelectedText = ""
        Me.txtSearchByProductName.Size = New System.Drawing.Size(443, 51)
        Me.txtSearchByProductName.TabIndex = 36
        '
        'btnView
        '
        Me.btnView.Animated = True
        Me.btnView.AutoRoundedCorners = True
        Me.btnView.BackColor = System.Drawing.Color.Transparent
        Me.btnView.BorderColor = System.Drawing.Color.White
        Me.btnView.BorderRadius = 27
        Me.btnView.BorderThickness = 2
        Me.btnView.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnView.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnView.FillColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.btnView.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnView.ForeColor = System.Drawing.Color.White
        Me.btnView.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnView.Location = New System.Drawing.Point(374, 343)
        Me.btnView.Name = "btnView"
        Me.btnView.PressedColor = System.Drawing.Color.Transparent
        Me.btnView.PressedDepth = 100
        Me.btnView.Size = New System.Drawing.Size(241, 56)
        Me.btnView.TabIndex = 31
        Me.btnView.Text = "View"
        Me.btnView.UseTransparentBackground = True
        '
        'lblProductsInfo
        '
        Me.lblProductsInfo.AutoSize = True
        Me.lblProductsInfo.BackColor = System.Drawing.Color.Transparent
        Me.lblProductsInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblProductsInfo.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 28.0!, System.Drawing.FontStyle.Bold)
        Me.lblProductsInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblProductsInfo.Location = New System.Drawing.Point(16, 15)
        Me.lblProductsInfo.Name = "lblProductsInfo"
        Me.lblProductsInfo.Size = New System.Drawing.Size(237, 51)
        Me.lblProductsInfo.TabIndex = 33
        Me.lblProductsInfo.Text = "Product Info"
        '
        'lblLine
        '
        Me.lblLine.AutoSize = True
        Me.lblLine.BackColor = System.Drawing.Color.Transparent
        Me.lblLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLine.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.lblLine.Location = New System.Drawing.Point(9, 51)
        Me.lblLine.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLine.Name = "lblLine"
        Me.lblLine.Size = New System.Drawing.Size(950, 33)
        Me.lblLine.TabIndex = 32
        Me.lblLine.Text = "_______________________________________________________"
        '
        'lblProductPrice
        '
        Me.lblProductPrice.AutoSize = True
        Me.lblProductPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblProductPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblProductPrice.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblProductPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblProductPrice.Location = New System.Drawing.Point(388, 121)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(108, 21)
        Me.lblProductPrice.TabIndex = 26
        Me.lblProductPrice.Text = "Product Price"
        '
        'lblProductName
        '
        Me.lblProductName.AutoSize = True
        Me.lblProductName.BackColor = System.Drawing.Color.Transparent
        Me.lblProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblProductName.Font = New System.Drawing.Font("Segoe UI Variable Text Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblProductName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblProductName.Location = New System.Drawing.Point(181, 121)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(112, 21)
        Me.lblProductName.TabIndex = 25
        Me.lblProductName.Text = "Product name"
        '
        'txtProductPrice
        '
        Me.txtProductPrice.Animated = True
        Me.txtProductPrice.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtProductPrice.BorderRadius = 5
        Me.txtProductPrice.BorderThickness = 2
        Me.txtProductPrice.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtProductPrice.DefaultText = ""
        Me.txtProductPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductPrice.FillColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtProductPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductPrice.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtProductPrice.ForeColor = System.Drawing.Color.Empty
        Me.txtProductPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductPrice.Location = New System.Drawing.Point(392, 147)
        Me.txtProductPrice.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtProductPrice.MaxLength = 30
        Me.txtProductPrice.Name = "txtProductPrice"
        Me.txtProductPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductPrice.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtProductPrice.PlaceholderText = "Product Price*"
        Me.txtProductPrice.ReadOnly = True
        Me.txtProductPrice.SelectedText = ""
        Me.txtProductPrice.Size = New System.Drawing.Size(179, 51)
        Me.txtProductPrice.TabIndex = 1
        '
        'txtProductName
        '
        Me.txtProductName.Animated = True
        Me.txtProductName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtProductName.BorderRadius = 5
        Me.txtProductName.BorderThickness = 2
        Me.txtProductName.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtProductName.DefaultText = ""
        Me.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtProductName.FillColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductName.Font = New System.Drawing.Font("Segoe UI", 12.75!)
        Me.txtProductName.ForeColor = System.Drawing.Color.Empty
        Me.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtProductName.Location = New System.Drawing.Point(183, 147)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtProductName.MaxLength = 30
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProductName.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.txtProductName.PlaceholderText = "Product Name*"
        Me.txtProductName.ReadOnly = True
        Me.txtProductName.SelectedText = ""
        Me.txtProductName.Size = New System.Drawing.Size(200, 51)
        Me.txtProductName.TabIndex = 0
        '
        'frmViewProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(973, 631)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SignUp"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvViewProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlProductImage.ResumeLayout(False)
        CType(Me.picSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvViewProducts As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnView As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblProductsInfo As Label
    Friend WithEvents lblLine As Label
    Friend WithEvents lblProductName As Label
    Friend WithEvents txtProductName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSearchByProductName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents picSearch As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtProductDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtProductPrice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblAvailablity As Label
    Friend WithEvents rdoNotAvailable As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents rdoAvailable As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents lblCategory As Label
    Friend WithEvents cmbCategory As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblProductSize As Label
    Friend WithEvents cmbProduceSize As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents lblProductPrice As Label
    Friend WithEvents pnlProductImage As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnAddImage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblProductImage As Label
    Friend WithEvents ProductName As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Category As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Size As DataGridViewTextBoxColumn
    Friend WithEvents CreateDate As DataGridViewTextBoxColumn
    Friend WithEvents Available As DataGridViewTextBoxColumn
    Friend WithEvents Image_url As DataGridViewTextBoxColumn
    Friend WithEvents Image_data As DataGridViewTextBoxColumn
    Friend WithEvents NumberOfRow As DataGridViewTextBoxColumn
End Class
