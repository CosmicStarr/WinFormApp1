<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim ZipCodeLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim CommentsLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PhoneBookInfoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.PhoneBookInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WinForm1DataSet = New WinFormApp1.WinForm1DataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.PhoneBookInfoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.PhoneBookInfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.CommentsTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.add_New_Button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.edit_Button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.delete_Button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.save_Button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.cancel_Button = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.PhoneBookInfoTableAdapter = New WinFormApp1.WinForm1DataSetTableAdapters.PhoneBookInfoTableAdapter()
        Me.TableAdapterManager = New WinFormApp1.WinForm1DataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        IdLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        ZipCodeLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        CommentsLabel = New System.Windows.Forms.Label()
        CType(Me.PhoneBookInfoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PhoneBookInfoBindingNavigator.SuspendLayout()
        CType(Me.PhoneBookInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinForm1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PhoneBookInfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(9, 24)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(21, 16)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(9, 52)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(75, 16)
        FirstNameLabel.TabIndex = 2
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(9, 80)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(75, 16)
        LastNameLabel.TabIndex = 4
        LastNameLabel.Text = "Last Name:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(9, 108)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(44, 16)
        EmailLabel.TabIndex = 6
        EmailLabel.Text = "Email:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(9, 136)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(61, 16)
        AddressLabel.TabIndex = 8
        AddressLabel.Text = "Address:"
        '
        'ZipCodeLabel
        '
        ZipCodeLabel.AutoSize = True
        ZipCodeLabel.Location = New System.Drawing.Point(9, 164)
        ZipCodeLabel.Name = "ZipCodeLabel"
        ZipCodeLabel.Size = New System.Drawing.Size(65, 16)
        ZipCodeLabel.TabIndex = 10
        ZipCodeLabel.Text = "Zip Code:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(9, 192)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(49, 16)
        PhoneLabel.TabIndex = 12
        PhoneLabel.Text = "Phone:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(9, 220)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(55, 16)
        CountryLabel.TabIndex = 14
        CountryLabel.Text = "Country:"
        '
        'CommentsLabel
        '
        CommentsLabel.AutoSize = True
        CommentsLabel.Location = New System.Drawing.Point(6, 248)
        CommentsLabel.Name = "CommentsLabel"
        CommentsLabel.Size = New System.Drawing.Size(74, 16)
        CommentsLabel.TabIndex = 16
        CommentsLabel.Text = "Comments:"
        '
        'PhoneBookInfoBindingNavigator
        '
        Me.PhoneBookInfoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PhoneBookInfoBindingNavigator.AutoSize = False
        Me.PhoneBookInfoBindingNavigator.BindingSource = Me.PhoneBookInfoBindingSource
        Me.PhoneBookInfoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PhoneBookInfoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PhoneBookInfoBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PhoneBookInfoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator1, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator3, Me.PhoneBookInfoBindingNavigatorSaveItem, Me.ToolStripButton2, Me.ToolStripSeparator8})
        Me.PhoneBookInfoBindingNavigator.Location = New System.Drawing.Point(0, 489)
        Me.PhoneBookInfoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PhoneBookInfoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PhoneBookInfoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PhoneBookInfoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PhoneBookInfoBindingNavigator.Name = "PhoneBookInfoBindingNavigator"
        Me.PhoneBookInfoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PhoneBookInfoBindingNavigator.Size = New System.Drawing.Size(1131, 68)
        Me.PhoneBookInfoBindingNavigator.TabIndex = 0
        Me.PhoneBookInfoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(82, 65)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'PhoneBookInfoBindingSource
        '
        Me.PhoneBookInfoBindingSource.DataMember = "PhoneBookInfo"
        Me.PhoneBookInfoBindingSource.DataSource = Me.WinForm1DataSet
        '
        'WinForm1DataSet
        '
        Me.WinForm1DataSet.DataSetName = "WinForm1DataSet"
        Me.WinForm1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 65)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 65)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 65)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 65)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 68)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 68)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 65)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 65)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 68)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 68)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 68)
        '
        'PhoneBookInfoBindingNavigatorSaveItem
        '
        Me.PhoneBookInfoBindingNavigatorSaveItem.Image = CType(resources.GetObject("PhoneBookInfoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PhoneBookInfoBindingNavigatorSaveItem.Name = "PhoneBookInfoBindingNavigatorSaveItem"
        Me.PhoneBookInfoBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 65)
        Me.PhoneBookInfoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(109, 65)
        Me.ToolStripButton2.Text = "Fill by Income"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 68)
        '
        'PhoneBookInfoDataGridView
        '
        Me.PhoneBookInfoDataGridView.AllowUserToResizeRows = False
        Me.PhoneBookInfoDataGridView.AutoGenerateColumns = False
        Me.PhoneBookInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PhoneBookInfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.PhoneBookInfoDataGridView.DataSource = Me.PhoneBookInfoBindingSource
        Me.PhoneBookInfoDataGridView.Location = New System.Drawing.Point(318, 71)
        Me.PhoneBookInfoDataGridView.Name = "PhoneBookInfoDataGridView"
        Me.PhoneBookInfoDataGridView.Size = New System.Drawing.Size(529, 350)
        Me.PhoneBookInfoDataGridView.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(FirstNameLabel)
        Me.GroupBox1.Controls.Add(CommentsLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.CommentsTextBox)
        Me.GroupBox1.Controls.Add(LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(EmailLabel)
        Me.GroupBox1.Controls.Add(Me.EmailTextBox)
        Me.GroupBox1.Controls.Add(AddressLabel)
        Me.GroupBox1.Controls.Add(Me.AddressTextBox)
        Me.GroupBox1.Controls.Add(ZipCodeLabel)
        Me.GroupBox1.Controls.Add(Me.ZipCodeTextBox)
        Me.GroupBox1.Controls.Add(PhoneLabel)
        Me.GroupBox1.Controls.Add(Me.PhoneTextBox)
        Me.GroupBox1.Controls.Add(CountryLabel)
        Me.GroupBox1.Controls.Add(Me.CountryTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 350)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhoneBookInfoBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(90, 21)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(189, 22)
        Me.IdTextBox.TabIndex = 1
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhoneBookInfoBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(90, 49)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(189, 22)
        Me.FirstNameTextBox.TabIndex = 3
        '
        'CommentsTextBox
        '
        Me.CommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhoneBookInfoBindingSource, "Comments", True))
        Me.CommentsTextBox.Location = New System.Drawing.Point(90, 245)
        Me.CommentsTextBox.Multiline = True
        Me.CommentsTextBox.Name = "CommentsTextBox"
        Me.CommentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.CommentsTextBox.Size = New System.Drawing.Size(189, 105)
        Me.CommentsTextBox.TabIndex = 17
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhoneBookInfoBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(90, 77)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(189, 22)
        Me.LastNameTextBox.TabIndex = 5
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhoneBookInfoBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(90, 105)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(189, 22)
        Me.EmailTextBox.TabIndex = 7
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhoneBookInfoBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(90, 133)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(189, 22)
        Me.AddressTextBox.TabIndex = 9
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhoneBookInfoBindingSource, "ZipCode", True))
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(90, 161)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(189, 22)
        Me.ZipCodeTextBox.TabIndex = 11
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhoneBookInfoBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(90, 189)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(189, 22)
        Me.PhoneTextBox.TabIndex = 13
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PhoneBookInfoBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(90, 217)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(189, 22)
        Me.CountryTextBox.TabIndex = 15
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.add_New_Button, Me.ToolStripSeparator5, Me.edit_Button, Me.ToolStripSeparator6, Me.delete_Button, Me.ToolStripSeparator2, Me.save_Button, Me.ToolStripSeparator4, Me.cancel_Button, Me.ToolStripSeparator7})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1131, 68)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'add_New_Button
        '
        Me.add_New_Button.Image = CType(resources.GetObject("add_New_Button.Image"), System.Drawing.Image)
        Me.add_New_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.add_New_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.add_New_Button.Name = "add_New_Button"
        Me.add_New_Button.Size = New System.Drawing.Size(84, 65)
        Me.add_New_Button.Text = "Add New"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 68)
        '
        'edit_Button
        '
        Me.edit_Button.Image = CType(resources.GetObject("edit_Button.Image"), System.Drawing.Image)
        Me.edit_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.edit_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.edit_Button.Name = "edit_Button"
        Me.edit_Button.Size = New System.Drawing.Size(55, 65)
        Me.edit_Button.Text = "Edit"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 68)
        '
        'delete_Button
        '
        Me.delete_Button.Image = CType(resources.GetObject("delete_Button.Image"), System.Drawing.Image)
        Me.delete_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.delete_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.delete_Button.Name = "delete_Button"
        Me.delete_Button.Size = New System.Drawing.Size(68, 65)
        Me.delete_Button.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 68)
        '
        'save_Button
        '
        Me.save_Button.Image = CType(resources.GetObject("save_Button.Image"), System.Drawing.Image)
        Me.save_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.save_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.save_Button.Name = "save_Button"
        Me.save_Button.Size = New System.Drawing.Size(59, 65)
        Me.save_Button.Text = "Save"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 68)
        '
        'cancel_Button
        '
        Me.cancel_Button.Image = CType(resources.GetObject("cancel_Button.Image"), System.Drawing.Image)
        Me.cancel_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cancel_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cancel_Button.Name = "cancel_Button"
        Me.cancel_Button.Size = New System.Drawing.Size(71, 65)
        Me.cancel_Button.Text = "Cancel"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 68)
        '
        'PhoneBookInfoTableAdapter
        '
        Me.PhoneBookInfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PhoneBookInfoTableAdapter = Me.PhoneBookInfoTableAdapter
        Me.TableAdapterManager.UpdateOrder = WinFormApp1.WinForm1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "FirstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "FirstName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ZipCode"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ZipCode"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Phone"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Country"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Country"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(918, 451)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 26)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Records"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(885, 454)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(777, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Record Count:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(853, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(268, 350)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(45, 217)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 35)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Browse"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(45, 74)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(182, 134)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1131, 557)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PhoneBookInfoDataGridView)
        Me.Controls.Add(Me.PhoneBookInfoBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Register"
        CType(Me.PhoneBookInfoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PhoneBookInfoBindingNavigator.ResumeLayout(False)
        Me.PhoneBookInfoBindingNavigator.PerformLayout()
        CType(Me.PhoneBookInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinForm1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PhoneBookInfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WinForm1DataSet As WinForm1DataSet
    Friend WithEvents PhoneBookInfoBindingSource As BindingSource
    Friend WithEvents PhoneBookInfoTableAdapter As WinForm1DataSetTableAdapters.PhoneBookInfoTableAdapter
    Friend WithEvents TableAdapterManager As WinForm1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents PhoneBookInfoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PhoneBookInfoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents PhoneBookInfoDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents CommentsTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents add_New_Button As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents edit_Button As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents delete_Button As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents save_Button As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents cancel_Button As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
End Class
