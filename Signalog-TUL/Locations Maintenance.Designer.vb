<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Locations_Maintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Locations_Maintenance))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewButton = New System.Windows.Forms.ToolStripButton()
        Me.EditButton = New System.Windows.Forms.ToolStripButton()
        Me.DeleteButton = New System.Windows.Forms.ToolStripButton()
        Me.UndoButton = New System.Windows.Forms.ToolStripButton()
        Me.LoadPanel = New System.Windows.Forms.Panel()
        Me.FilterArea = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NSLOC = New System.Windows.Forms.ListBox()
        Me.NSLOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EWLOC = New System.Windows.Forms.ListBox()
        Me.EWLOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AREA = New System.Windows.Forms.ListBox()
        Me.LOC0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FilterBoth = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FilterNO = New System.Windows.Forms.RadioButton()
        Me.FilterYES = New System.Windows.Forms.RadioButton()
        Me.CUS0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadByPanel = New System.Windows.Forms.Panel()
        Me.Filters = New System.Windows.Forms.RadioButton()
        Me.ID = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.AreaName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fwd = New System.Windows.Forms.Button()
        Me.bck = New System.Windows.Forms.Button()
        Me.LOCNUM = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EWLOCtxt = New System.Windows.Forms.TextBox()
        Me.NSLOCtxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TypeDesc = New System.Windows.Forms.ComboBox()
        Me.LOC1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOC1TableAdapter = New Signalog.SignalogDataSetTableAdapters.LOC1TableAdapter()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.OUTSERV = New System.Windows.Forms.DateTimePicker()
        Me.INSERV = New System.Windows.Forms.DateTimePicker()
        Me.NO = New System.Windows.Forms.RadioButton()
        Me.YES = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.LOC0TableAdapter = New Signalog.SignalogDataSetTableAdapters.LOC0TableAdapter()
        Me.CUS0TableAdapter = New Signalog.SignalogDataSetTableAdapters.CUS0TableAdapter()
        Me.EWLOCTableAdapter = New Signalog.SignalogDataSetTableAdapters.EWLOCTableAdapter()
        Me.NSLOCTableAdapter = New Signalog.SignalogDataSetTableAdapters.NSLOCTableAdapter()
        Me.EWLOCbox = New System.Windows.Forms.ComboBox()
        Me.EWLOC2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NSLOCbox = New System.Windows.Forms.ComboBox()
        Me.NSLOC2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EWLOC2TableAdapter = New Signalog.SignalogDataSetTableAdapters.EWLOC2TableAdapter()
        Me.NSLOC2TableAdapter = New Signalog.SignalogDataSetTableAdapters.NSLOC2TableAdapter()
        Me.Bind = New System.Windows.Forms.CheckBox()
        Me.BindNSLOC = New System.Windows.Forms.ComboBox()
        Me.BindNSLOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindEWLOC = New System.Windows.Forms.ComboBox()
        Me.BindEWLOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BindArea = New System.Windows.Forms.ComboBox()
        Me.BindAreaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BindAreaTableAdapter = New Signalog.SignalogDataSetTableAdapters.BindAreaTableAdapter()
        Me.BindEWLOCTableAdapter = New Signalog.SignalogDataSetTableAdapters.BindEWLOCTableAdapter()
        Me.BindNSLOCTableAdapter = New Signalog.SignalogDataSetTableAdapters.BindNSLOCTableAdapter()
        Me.LOCKNEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCKNEWTableAdapter = New Signalog.SignalogDataSetTableAdapters.LOCKNEWTableAdapter()
        Me.LOCKEDITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCKEDITTableAdapter = New Signalog.SignalogDataSetTableAdapters.LOCKEDITTableAdapter()
        Me.ACT0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT0TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT0TableAdapter()
        Me.OSNoDate = New System.Windows.Forms.CheckBox()
        Me.ISNoDate = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        Me.LoadPanel.SuspendLayout()
        CType(Me.NSLOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EWLOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOC0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUS0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoadByPanel.SuspendLayout()
        CType(Me.LOC1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EWLOC2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NSLOC2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindNSLOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindEWLOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindAreaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCKNEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCKEDITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(17, 17)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.EditButton, Me.DeleteButton, Me.UndoButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1143, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewButton
        '
        Me.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewButton.Image = CType(resources.GetObject("NewButton.Image"), System.Drawing.Image)
        Me.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(23, 22)
        Me.NewButton.Text = "New"
        '
        'EditButton
        '
        Me.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditButton.Image = CType(resources.GetObject("EditButton.Image"), System.Drawing.Image)
        Me.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(23, 22)
        Me.EditButton.Text = "Edit"
        '
        'DeleteButton
        '
        Me.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteButton.Image = CType(resources.GetObject("DeleteButton.Image"), System.Drawing.Image)
        Me.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(23, 22)
        Me.DeleteButton.Text = "Delete"
        '
        'UndoButton
        '
        Me.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoButton.Image = CType(resources.GetObject("UndoButton.Image"), System.Drawing.Image)
        Me.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoButton.Name = "UndoButton"
        Me.UndoButton.Size = New System.Drawing.Size(23, 22)
        Me.UndoButton.Text = "Undo"
        '
        'LoadPanel
        '
        Me.LoadPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LoadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoadPanel.Controls.Add(Me.FilterArea)
        Me.LoadPanel.Controls.Add(Me.Label3)
        Me.LoadPanel.Controls.Add(Me.NSLOC)
        Me.LoadPanel.Controls.Add(Me.Label2)
        Me.LoadPanel.Controls.Add(Me.Label1)
        Me.LoadPanel.Controls.Add(Me.EWLOC)
        Me.LoadPanel.Controls.Add(Me.AREA)
        Me.LoadPanel.Controls.Add(Me.FilterBoth)
        Me.LoadPanel.Controls.Add(Me.Label7)
        Me.LoadPanel.Controls.Add(Me.FilterNO)
        Me.LoadPanel.Controls.Add(Me.FilterYES)
        Me.LoadPanel.Location = New System.Drawing.Point(0, 25)
        Me.LoadPanel.Name = "LoadPanel"
        Me.LoadPanel.Size = New System.Drawing.Size(598, 571)
        Me.LoadPanel.TabIndex = 3
        '
        'FilterArea
        '
        Me.FilterArea.Location = New System.Drawing.Point(55, 34)
        Me.FilterArea.Name = "FilterArea"
        Me.FilterArea.Size = New System.Drawing.Size(138, 20)
        Me.FilterArea.TabIndex = 106
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(443, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 15)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "NS LOCATION"
        '
        'NSLOC
        '
        Me.NSLOC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NSLOC.DataSource = Me.NSLOCBindingSource
        Me.NSLOC.DisplayMember = "NSLOC"
        Me.NSLOC.FormattingEnabled = True
        Me.NSLOC.Location = New System.Drawing.Point(393, 57)
        Me.NSLOC.Name = "NSLOC"
        Me.NSLOC.Size = New System.Drawing.Size(188, 381)
        Me.NSLOC.TabIndex = 104
        Me.NSLOC.ValueMember = "NSLOC"
        '
        'NSLOCBindingSource
        '
        Me.NSLOCBindingSource.DataMember = "NSLOC"
        Me.NSLOCBindingSource.DataSource = Me.SignalogDataSet
        '
        'SignalogDataSet
        '
        Me.SignalogDataSet.DataSetName = "SignalogDataSet"
        Me.SignalogDataSet.EnforceConstraints = False
        Me.SignalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(250, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "EW LOCATION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "AREA"
        '
        'EWLOC
        '
        Me.EWLOC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EWLOC.DataSource = Me.EWLOCBindingSource
        Me.EWLOC.DisplayMember = "EWLOC"
        Me.EWLOC.FormattingEnabled = True
        Me.EWLOC.Location = New System.Drawing.Point(199, 57)
        Me.EWLOC.Name = "EWLOC"
        Me.EWLOC.Size = New System.Drawing.Size(188, 381)
        Me.EWLOC.TabIndex = 101
        Me.EWLOC.ValueMember = "EWLOC"
        '
        'EWLOCBindingSource
        '
        Me.EWLOCBindingSource.DataMember = "EWLOC"
        Me.EWLOCBindingSource.DataSource = Me.SignalogDataSet
        '
        'AREA
        '
        Me.AREA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AREA.DataSource = Me.LOC0BindingSource
        Me.AREA.DisplayMember = "AREA"
        Me.AREA.FormattingEnabled = True
        Me.AREA.Location = New System.Drawing.Point(0, 57)
        Me.AREA.Name = "AREA"
        Me.AREA.Size = New System.Drawing.Size(193, 511)
        Me.AREA.TabIndex = 100
        Me.AREA.ValueMember = "AREA"
        '
        'LOC0BindingSource
        '
        Me.LOC0BindingSource.DataMember = "LOC0"
        Me.LOC0BindingSource.DataSource = Me.SignalogDataSet
        '
        'FilterBoth
        '
        Me.FilterBoth.AutoSize = True
        Me.FilterBoth.Location = New System.Drawing.Point(143, 5)
        Me.FilterBoth.Name = "FilterBoth"
        Me.FilterBoth.Size = New System.Drawing.Size(50, 19)
        Me.FilterBoth.TabIndex = 96
        Me.FilterBoth.TabStop = True
        Me.FilterBoth.Text = "Both"
        Me.FilterBoth.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Show?"
        '
        'FilterNO
        '
        Me.FilterNO.AutoSize = True
        Me.FilterNO.Location = New System.Drawing.Point(98, 5)
        Me.FilterNO.Name = "FilterNO"
        Me.FilterNO.Size = New System.Drawing.Size(41, 19)
        Me.FilterNO.TabIndex = 95
        Me.FilterNO.TabStop = True
        Me.FilterNO.Text = "No"
        Me.FilterNO.UseVisualStyleBackColor = True
        '
        'FilterYES
        '
        Me.FilterYES.AutoSize = True
        Me.FilterYES.Location = New System.Drawing.Point(51, 5)
        Me.FilterYES.Name = "FilterYES"
        Me.FilterYES.Size = New System.Drawing.Size(45, 19)
        Me.FilterYES.TabIndex = 94
        Me.FilterYES.TabStop = True
        Me.FilterYES.Text = "Yes"
        Me.FilterYES.UseVisualStyleBackColor = True
        '
        'CUS0BindingSource
        '
        Me.CUS0BindingSource.DataMember = "CUS0"
        Me.CUS0BindingSource.DataSource = Me.SignalogDataSet
        '
        'LoadByPanel
        '
        Me.LoadByPanel.Controls.Add(Me.Filters)
        Me.LoadByPanel.Controls.Add(Me.ID)
        Me.LoadByPanel.Location = New System.Drawing.Point(689, 17)
        Me.LoadByPanel.Name = "LoadByPanel"
        Me.LoadByPanel.Size = New System.Drawing.Size(104, 23)
        Me.LoadByPanel.TabIndex = 37
        '
        'Filters
        '
        Me.Filters.AutoSize = True
        Me.Filters.Location = New System.Drawing.Point(3, 3)
        Me.Filters.Name = "Filters"
        Me.Filters.Size = New System.Drawing.Size(58, 19)
        Me.Filters.TabIndex = 27
        Me.Filters.TabStop = True
        Me.Filters.Text = "Filters"
        Me.Filters.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Location = New System.Drawing.Point(61, 3)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(37, 19)
        Me.ID.TabIndex = 28
        Me.ID.TabStop = True
        Me.ID.Text = "ID"
        Me.ID.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(629, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 15)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Load By:"
        '
        'AreaName
        '
        Me.AreaName.DataSource = Me.CUS0BindingSource
        Me.AreaName.DisplayMember = "AREANAME"
        Me.AreaName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AreaName.FormattingEnabled = True
        Me.AreaName.Location = New System.Drawing.Point(689, 102)
        Me.AreaName.MaxLength = 50
        Me.AreaName.Name = "AreaName"
        Me.AreaName.Size = New System.Drawing.Size(436, 21)
        Me.AreaName.TabIndex = 35
        Me.AreaName.ValueMember = "AREANAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(611, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Area Name:"
        '
        'fwd
        '
        Me.fwd.Location = New System.Drawing.Point(820, 56)
        Me.fwd.Name = "fwd"
        Me.fwd.Size = New System.Drawing.Size(27, 23)
        Me.fwd.TabIndex = 33
        Me.fwd.Text = ">>"
        Me.fwd.UseVisualStyleBackColor = True
        '
        'bck
        '
        Me.bck.Location = New System.Drawing.Point(787, 56)
        Me.bck.Name = "bck"
        Me.bck.Size = New System.Drawing.Size(27, 23)
        Me.bck.TabIndex = 32
        Me.bck.Text = "<<"
        Me.bck.UseVisualStyleBackColor = True
        '
        'LOCNUM
        '
        Me.LOCNUM.Location = New System.Drawing.Point(689, 59)
        Me.LOCNUM.Name = "LOCNUM"
        Me.LOCNUM.Size = New System.Drawing.Size(70, 20)
        Me.LOCNUM.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(611, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 15)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Location ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(606, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "NS Location:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(604, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "EW Location:"
        '
        'EWLOCtxt
        '
        Me.EWLOCtxt.Location = New System.Drawing.Point(929, 140)
        Me.EWLOCtxt.MaxLength = 50
        Me.EWLOCtxt.Name = "EWLOCtxt"
        Me.EWLOCtxt.Size = New System.Drawing.Size(196, 20)
        Me.EWLOCtxt.TabIndex = 40
        '
        'NSLOCtxt
        '
        Me.NSLOCtxt.Location = New System.Drawing.Point(929, 175)
        Me.NSLOCtxt.MaxLength = 50
        Me.NSLOCtxt.Name = "NSLOCtxt"
        Me.NSLOCtxt.Size = New System.Drawing.Size(196, 20)
        Me.NSLOCtxt.TabIndex = 41
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(616, 213)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Type Desc:"
        '
        'TypeDesc
        '
        Me.TypeDesc.DataSource = Me.LOC1BindingSource
        Me.TypeDesc.DisplayMember = "TYPEDESC"
        Me.TypeDesc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TypeDesc.DropDownWidth = 390
        Me.TypeDesc.FormattingEnabled = True
        Me.TypeDesc.Location = New System.Drawing.Point(689, 210)
        Me.TypeDesc.MaxLength = 50
        Me.TypeDesc.Name = "TypeDesc"
        Me.TypeDesc.Size = New System.Drawing.Size(436, 21)
        Me.TypeDesc.TabIndex = 43
        Me.TypeDesc.ValueMember = "TYPEDESC"
        '
        'LOC1BindingSource
        '
        Me.LOC1BindingSource.DataMember = "LOC1"
        Me.LOC1BindingSource.DataSource = Me.SignalogDataSet
        '
        'LOC1TableAdapter
        '
        Me.LOC1TableAdapter.ClearBeforeFill = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(696, 283)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 15)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Out of Service Date:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(696, 248)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 15)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "In Service Date:"
        '
        'OUTSERV
        '
        Me.OUTSERV.Checked = False
        Me.OUTSERV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.OUTSERV.Location = New System.Drawing.Point(806, 279)
        Me.OUTSERV.Name = "OUTSERV"
        Me.OUTSERV.Size = New System.Drawing.Size(126, 20)
        Me.OUTSERV.TabIndex = 47
        '
        'INSERV
        '
        Me.INSERV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.INSERV.Location = New System.Drawing.Point(806, 244)
        Me.INSERV.Name = "INSERV"
        Me.INSERV.Size = New System.Drawing.Size(126, 20)
        Me.INSERV.TabIndex = 46
        '
        'NO
        '
        Me.NO.AutoSize = True
        Me.NO.Location = New System.Drawing.Point(1082, 58)
        Me.NO.Name = "NO"
        Me.NO.Size = New System.Drawing.Size(43, 19)
        Me.NO.TabIndex = 50
        Me.NO.TabStop = True
        Me.NO.Text = "NO"
        Me.NO.UseVisualStyleBackColor = True
        '
        'YES
        '
        Me.YES.AutoSize = True
        Me.YES.Location = New System.Drawing.Point(1030, 58)
        Me.YES.Name = "YES"
        Me.YES.Size = New System.Drawing.Size(48, 19)
        Me.YES.TabIndex = 49
        Me.YES.TabStop = True
        Me.YES.Text = "YES"
        Me.YES.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(961, 60)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 15)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Show?"
        '
        'Submit
        '
        Me.Submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Submit.Location = New System.Drawing.Point(823, 473)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 51
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'LOC0TableAdapter
        '
        Me.LOC0TableAdapter.ClearBeforeFill = True
        '
        'CUS0TableAdapter
        '
        Me.CUS0TableAdapter.ClearBeforeFill = True
        '
        'EWLOCTableAdapter
        '
        Me.EWLOCTableAdapter.ClearBeforeFill = True
        '
        'NSLOCTableAdapter
        '
        Me.NSLOCTableAdapter.ClearBeforeFill = True
        '
        'EWLOCbox
        '
        Me.EWLOCbox.DataSource = Me.EWLOC2BindingSource
        Me.EWLOCbox.DisplayMember = "EWLOC"
        Me.EWLOCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EWLOCbox.FormattingEnabled = True
        Me.EWLOCbox.Location = New System.Drawing.Point(689, 140)
        Me.EWLOCbox.Name = "EWLOCbox"
        Me.EWLOCbox.Size = New System.Drawing.Size(235, 21)
        Me.EWLOCbox.TabIndex = 52
        Me.EWLOCbox.ValueMember = "EWLOC"
        '
        'EWLOC2BindingSource
        '
        Me.EWLOC2BindingSource.DataMember = "EWLOC2"
        Me.EWLOC2BindingSource.DataSource = Me.SignalogDataSet
        '
        'NSLOCbox
        '
        Me.NSLOCbox.DataSource = Me.NSLOC2BindingSource
        Me.NSLOCbox.DisplayMember = "NSLOC"
        Me.NSLOCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.NSLOCbox.FormattingEnabled = True
        Me.NSLOCbox.Location = New System.Drawing.Point(689, 175)
        Me.NSLOCbox.Name = "NSLOCbox"
        Me.NSLOCbox.Size = New System.Drawing.Size(235, 21)
        Me.NSLOCbox.TabIndex = 53
        Me.NSLOCbox.ValueMember = "NSLOC"
        '
        'NSLOC2BindingSource
        '
        Me.NSLOC2BindingSource.DataMember = "NSLOC2"
        Me.NSLOC2BindingSource.DataSource = Me.SignalogDataSet
        '
        'EWLOC2TableAdapter
        '
        Me.EWLOC2TableAdapter.ClearBeforeFill = True
        '
        'NSLOC2TableAdapter
        '
        Me.NSLOC2TableAdapter.ClearBeforeFill = True
        '
        'Bind
        '
        Me.Bind.AutoSize = True
        Me.Bind.Location = New System.Drawing.Point(887, 315)
        Me.Bind.Name = "Bind"
        Me.Bind.Size = New System.Drawing.Size(201, 19)
        Me.Bind.TabIndex = 54
        Me.Bind.Text = "Bind To The Following Location:"
        Me.Bind.UseVisualStyleBackColor = True
        '
        'BindNSLOC
        '
        Me.BindNSLOC.DataSource = Me.BindNSLOCBindingSource
        Me.BindNSLOC.DisplayMember = "NSLOC"
        Me.BindNSLOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BindNSLOC.FormattingEnabled = True
        Me.BindNSLOC.Location = New System.Drawing.Point(962, 423)
        Me.BindNSLOC.Name = "BindNSLOC"
        Me.BindNSLOC.Size = New System.Drawing.Size(158, 21)
        Me.BindNSLOC.TabIndex = 60
        Me.BindNSLOC.ValueMember = "NSLOC"
        '
        'BindNSLOCBindingSource
        '
        Me.BindNSLOCBindingSource.DataMember = "BindNSLOC"
        Me.BindNSLOCBindingSource.DataSource = Me.SignalogDataSet
        '
        'BindEWLOC
        '
        Me.BindEWLOC.DataSource = Me.BindEWLOCBindingSource
        Me.BindEWLOC.DisplayMember = "EWLOC"
        Me.BindEWLOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BindEWLOC.FormattingEnabled = True
        Me.BindEWLOC.Location = New System.Drawing.Point(962, 388)
        Me.BindEWLOC.Name = "BindEWLOC"
        Me.BindEWLOC.Size = New System.Drawing.Size(158, 21)
        Me.BindEWLOC.TabIndex = 59
        Me.BindEWLOC.ValueMember = "EWLOC"
        '
        'BindEWLOCBindingSource
        '
        Me.BindEWLOCBindingSource.DataMember = "BindEWLOC"
        Me.BindEWLOCBindingSource.DataSource = Me.SignalogDataSet
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(884, 391)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 15)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "EW Location:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(884, 426)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 15)
        Me.Label15.TabIndex = 57
        Me.Label15.Text = "NS Location:"
        '
        'BindArea
        '
        Me.BindArea.DataSource = Me.BindAreaBindingSource
        Me.BindArea.DisplayMember = "AREA"
        Me.BindArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BindArea.FormattingEnabled = True
        Me.BindArea.Location = New System.Drawing.Point(962, 353)
        Me.BindArea.Name = "BindArea"
        Me.BindArea.Size = New System.Drawing.Size(158, 21)
        Me.BindArea.TabIndex = 56
        Me.BindArea.ValueMember = "AREA"
        '
        'BindAreaBindingSource
        '
        Me.BindAreaBindingSource.DataMember = "BindArea"
        Me.BindAreaBindingSource.DataSource = Me.SignalogDataSet
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(884, 356)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 15)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Area Name:"
        '
        'BindAreaTableAdapter
        '
        Me.BindAreaTableAdapter.ClearBeforeFill = True
        '
        'BindEWLOCTableAdapter
        '
        Me.BindEWLOCTableAdapter.ClearBeforeFill = True
        '
        'BindNSLOCTableAdapter
        '
        Me.BindNSLOCTableAdapter.ClearBeforeFill = True
        '
        'LOCKNEWBindingSource
        '
        Me.LOCKNEWBindingSource.DataMember = "LOCKNEW"
        Me.LOCKNEWBindingSource.DataSource = Me.SignalogDataSet
        '
        'LOCKNEWTableAdapter
        '
        Me.LOCKNEWTableAdapter.ClearBeforeFill = True
        '
        'LOCKEDITBindingSource
        '
        Me.LOCKEDITBindingSource.DataMember = "LOCKEDIT"
        Me.LOCKEDITBindingSource.DataSource = Me.SignalogDataSet
        '
        'LOCKEDITTableAdapter
        '
        Me.LOCKEDITTableAdapter.ClearBeforeFill = True
        '
        'ACT0BindingSource
        '
        Me.ACT0BindingSource.DataMember = "ACT0"
        Me.ACT0BindingSource.DataSource = Me.SignalogDataSet
        '
        'ACT0TableAdapter
        '
        Me.ACT0TableAdapter.ClearBeforeFill = True
        '
        'OSNoDate
        '
        Me.OSNoDate.AutoSize = True
        Me.OSNoDate.Location = New System.Drawing.Point(950, 282)
        Me.OSNoDate.Name = "OSNoDate"
        Me.OSNoDate.Size = New System.Drawing.Size(99, 19)
        Me.OSNoDate.TabIndex = 61
        Me.OSNoDate.Text = "Not Specified"
        Me.OSNoDate.UseVisualStyleBackColor = True
        '
        'ISNoDate
        '
        Me.ISNoDate.AutoSize = True
        Me.ISNoDate.Location = New System.Drawing.Point(950, 247)
        Me.ISNoDate.Name = "ISNoDate"
        Me.ISNoDate.Size = New System.Drawing.Size(99, 19)
        Me.ISNoDate.TabIndex = 62
        Me.ISNoDate.Text = "Not Specified"
        Me.ISNoDate.UseVisualStyleBackColor = True
        '
        'Locations_Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 594)
        Me.Controls.Add(Me.ISNoDate)
        Me.Controls.Add(Me.OSNoDate)
        Me.Controls.Add(Me.BindNSLOC)
        Me.Controls.Add(Me.BindEWLOC)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BindArea)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Bind)
        Me.Controls.Add(Me.NSLOCbox)
        Me.Controls.Add(Me.EWLOCbox)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.NO)
        Me.Controls.Add(Me.YES)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.INSERV)
        Me.Controls.Add(Me.OUTSERV)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TypeDesc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.NSLOCtxt)
        Me.Controls.Add(Me.EWLOCtxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LoadByPanel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.AreaName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.fwd)
        Me.Controls.Add(Me.bck)
        Me.Controls.Add(Me.LOCNUM)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LoadPanel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Locations_Maintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Locations Maintenance"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.LoadPanel.ResumeLayout(False)
        Me.LoadPanel.PerformLayout()
        CType(Me.NSLOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EWLOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOC0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUS0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoadByPanel.ResumeLayout(False)
        Me.LoadByPanel.PerformLayout()
        CType(Me.LOC1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EWLOC2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NSLOC2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindNSLOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindEWLOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindAreaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCKNEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCKEDITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents UndoButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LoadPanel As System.Windows.Forms.Panel
    Friend WithEvents FilterBoth As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FilterNO As System.Windows.Forms.RadioButton
    Friend WithEvents FilterYES As System.Windows.Forms.RadioButton
    Friend WithEvents AREA As System.Windows.Forms.ListBox
    Friend WithEvents EWLOC As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NSLOC As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LoadByPanel As System.Windows.Forms.Panel
    Friend WithEvents ID As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents AreaName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fwd As System.Windows.Forms.Button
    Friend WithEvents bck As System.Windows.Forms.Button
    Friend WithEvents LOCNUM As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EWLOCtxt As System.Windows.Forms.TextBox
    Friend WithEvents NSLOCtxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TypeDesc As System.Windows.Forms.ComboBox
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents LOC1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOC1TableAdapter As Signalog.SignalogDataSetTableAdapters.LOC1TableAdapter
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents OUTSERV As System.Windows.Forms.DateTimePicker
    Friend WithEvents INSERV As System.Windows.Forms.DateTimePicker
    Friend WithEvents NO As System.Windows.Forms.RadioButton
    Friend WithEvents YES As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents LOC0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOC0TableAdapter As Signalog.SignalogDataSetTableAdapters.LOC0TableAdapter
    Friend WithEvents CUS0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUS0TableAdapter As Signalog.SignalogDataSetTableAdapters.CUS0TableAdapter
    Friend WithEvents EWLOCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EWLOCTableAdapter As Signalog.SignalogDataSetTableAdapters.EWLOCTableAdapter
    Friend WithEvents NSLOCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NSLOCTableAdapter As Signalog.SignalogDataSetTableAdapters.NSLOCTableAdapter
    Friend WithEvents FilterArea As System.Windows.Forms.TextBox
    Friend WithEvents EWLOCbox As System.Windows.Forms.ComboBox
    Friend WithEvents NSLOCbox As System.Windows.Forms.ComboBox
    Friend WithEvents EWLOC2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EWLOC2TableAdapter As Signalog.SignalogDataSetTableAdapters.EWLOC2TableAdapter
    Friend WithEvents NSLOC2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NSLOC2TableAdapter As Signalog.SignalogDataSetTableAdapters.NSLOC2TableAdapter
    Friend WithEvents Bind As System.Windows.Forms.CheckBox
    Friend WithEvents BindNSLOC As System.Windows.Forms.ComboBox
    Friend WithEvents BindEWLOC As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BindArea As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents BindAreaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindAreaTableAdapter As Signalog.SignalogDataSetTableAdapters.BindAreaTableAdapter
    Friend WithEvents BindEWLOCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindEWLOCTableAdapter As Signalog.SignalogDataSetTableAdapters.BindEWLOCTableAdapter
    Friend WithEvents BindNSLOCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BindNSLOCTableAdapter As Signalog.SignalogDataSetTableAdapters.BindNSLOCTableAdapter
    Friend WithEvents LOCKNEWBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKNEWTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKNEWTableAdapter
    Friend WithEvents LOCKEDITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKEDITTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKEDITTableAdapter
    Friend WithEvents ACT0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT0TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT0TableAdapter
    Friend WithEvents OSNoDate As System.Windows.Forms.CheckBox
    Friend WithEvents ISNoDate As System.Windows.Forms.CheckBox
    Friend WithEvents Filters As System.Windows.Forms.RadioButton
End Class
