<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_Maintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory_Maintenance))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewButton = New System.Windows.Forms.ToolStripButton()
        Me.EditButton = New System.Windows.Forms.ToolStripButton()
        Me.DeleteButton = New System.Windows.Forms.ToolStripButton()
        Me.UndoButton = New System.Windows.Forms.ToolStripButton()
        Me.PartDesc = New System.Windows.Forms.ListBox()
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.PartTableAdapter = New Signalog.SignalogDataSetTableAdapters.PartTableAdapter()
        Me.PartFilter = New System.Windows.Forms.TextBox()
        Me.Serial = New System.Windows.Forms.ListBox()
        Me.SerialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadPanel = New System.Windows.Forms.Panel()
        Me.AreaAll = New System.Windows.Forms.CheckBox()
        Me.AreaFilter = New System.Windows.Forms.ComboBox()
        Me.CUS0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.StatAll = New System.Windows.Forms.CheckBox()
        Me.ManAll = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StatusFilter = New System.Windows.Forms.ComboBox()
        Me.PartsStatusTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ManFilter = New System.Windows.Forms.ComboBox()
        Me.MANFLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SerialFilter = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SerialTableAdapter = New Signalog.SignalogDataSetTableAdapters.SerialTableAdapter()
        Me.Parts_Status_TypeTableAdapter = New Signalog.SignalogDataSetTableAdapters.Parts_Status_TypeTableAdapter()
        Me.MANF_LISTTableAdapter = New Signalog.SignalogDataSetTableAdapters.MANF_LISTTableAdapter()
        Me.IDlbl = New System.Windows.Forms.Label()
        Me.IDtxt = New System.Windows.Forms.TextBox()
        Me.fwd = New System.Windows.Forms.Button()
        Me.bck = New System.Windows.Forms.Button()
        Me.Desclbl = New System.Windows.Forms.Label()
        Me.SNlbl = New System.Windows.Forms.Label()
        Me.SNtxt = New System.Windows.Forms.TextBox()
        Me.Desc = New System.Windows.Forms.ComboBox()
        Me.PartsListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Statuslbl = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.ComboBox()
        Me.PartsStatusTypeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Manuflbl = New System.Windows.Forms.Label()
        Me.Manuf = New System.Windows.Forms.ComboBox()
        Me.MANFLISTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Conlbl = New System.Windows.Forms.Label()
        Me.ContCosttxt = New System.Windows.Forms.TextBox()
        Me.Showlbl = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Parts_ListTableAdapter = New Signalog.SignalogDataSetTableAdapters.Parts_ListTableAdapter()
        Me.EQUIPMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPMENTTableAdapter = New Signalog.SignalogDataSetTableAdapters.EQUIPMENTTableAdapter()
        Me.LoadBylbl = New System.Windows.Forms.Label()
        Me.YES = New System.Windows.Forms.RadioButton()
        Me.NO = New System.Windows.Forms.RadioButton()
        Me.ID = New System.Windows.Forms.RadioButton()
        Me.Filters = New System.Windows.Forms.RadioButton()
        Me.LoadByPanel = New System.Windows.Forms.Panel()
        Me.SrcPanel = New System.Windows.Forms.Panel()
        Me.WareHouse = New System.Windows.Forms.ComboBox()
        Me.WareHouselbl = New System.Windows.Forms.Label()
        Me.CityOwned = New System.Windows.Forms.RadioButton()
        Me.Local = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Arealbl = New System.Windows.Forms.Label()
        Me.Area = New System.Windows.Forms.ComboBox()
        Me.CUS0BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUS0TableAdapter = New Signalog.SignalogDataSetTableAdapters.CUS0TableAdapter()
        Me.Part2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Part2TableAdapter = New Signalog.SignalogDataSetTableAdapters.Part2TableAdapter()
        Me.Serial2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Serial2TableAdapter = New Signalog.SignalogDataSetTableAdapters.Serial2TableAdapter()
        Me.EQUIPMENT2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPMENT2TableAdapter = New Signalog.SignalogDataSetTableAdapters.EQUIPMENT2TableAdapter()
        Me.LOCKNEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCKNEWTableAdapter = New Signalog.SignalogDataSetTableAdapters.LOCKNEWTableAdapter()
        Me.LOCKEDITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCKEDITTableAdapter = New Signalog.SignalogDataSetTableAdapters.LOCKEDITTableAdapter()
        Me.ACT3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT3TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT3TableAdapter()
        Me.NoneSN = New System.Windows.Forms.CheckBox()
        Me.Quantlbl = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.NonContCosttxt = New System.Windows.Forms.TextBox()
        Me.Nonconlbl = New System.Windows.Forms.Label()
        Me.PartWareHouselbl = New System.Windows.Forms.Label()
        Me.PartWareHouse = New System.Windows.Forms.ComboBox()
        Me.PartNumlbl = New System.Windows.Forms.Label()
        Me.PartNum = New System.Windows.Forms.TextBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SerialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoadPanel.SuspendLayout()
        CType(Me.CUS0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartsStatusTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANFLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartsListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartsStatusTypeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANFLISTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoadByPanel.SuspendLayout()
        Me.SrcPanel.SuspendLayout()
        CType(Me.CUS0BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Part2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Serial2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENT2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCKNEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCKEDITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(17, 17)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.EditButton, Me.DeleteButton, Me.UndoButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1051, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewButton
        '
        Me.NewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewButton.Image = Global.Signalog.My.Resources.Resources.new_256x256
        Me.NewButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewButton.Name = "NewButton"
        Me.NewButton.Size = New System.Drawing.Size(23, 22)
        Me.NewButton.Text = "New"
        '
        'EditButton
        '
        Me.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EditButton.Image = Global.Signalog.My.Resources.Resources.edit_256x256
        Me.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(23, 22)
        Me.EditButton.Text = "Edit"
        '
        'DeleteButton
        '
        Me.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DeleteButton.Image = Global.Signalog.My.Resources.Resources.delete_256x256
        Me.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(23, 22)
        Me.DeleteButton.Text = "Delete"
        '
        'UndoButton
        '
        Me.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoButton.Image = Global.Signalog.My.Resources.Resources.undo_32x32
        Me.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoButton.Name = "UndoButton"
        Me.UndoButton.Size = New System.Drawing.Size(23, 22)
        Me.UndoButton.Text = "Undo"
        '
        'PartDesc
        '
        Me.PartDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PartDesc.DataSource = Me.PartBindingSource
        Me.PartDesc.DisplayMember = "PartDesc"
        Me.PartDesc.FormattingEnabled = True
        Me.PartDesc.Location = New System.Drawing.Point(4, 134)
        Me.PartDesc.Name = "PartDesc"
        Me.PartDesc.Size = New System.Drawing.Size(462, 381)
        Me.PartDesc.TabIndex = 2
        Me.PartDesc.ValueMember = "PartDesc"
        '
        'PartBindingSource
        '
        Me.PartBindingSource.DataMember = "Part"
        Me.PartBindingSource.DataSource = Me.SignalogDataSet
        '
        'SignalogDataSet
        '
        Me.SignalogDataSet.DataSetName = "SignalogDataSet"
        Me.SignalogDataSet.EnforceConstraints = False
        Me.SignalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PartTableAdapter
        '
        Me.PartTableAdapter.ClearBeforeFill = True
        '
        'PartFilter
        '
        Me.PartFilter.Location = New System.Drawing.Point(4, 110)
        Me.PartFilter.Name = "PartFilter"
        Me.PartFilter.Size = New System.Drawing.Size(216, 20)
        Me.PartFilter.TabIndex = 3
        '
        'Serial
        '
        Me.Serial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Serial.DataSource = Me.SerialBindingSource
        Me.Serial.DisplayMember = "Serial"
        Me.Serial.FormattingEnabled = True
        Me.Serial.Location = New System.Drawing.Point(472, 134)
        Me.Serial.Name = "Serial"
        Me.Serial.Size = New System.Drawing.Size(191, 381)
        Me.Serial.TabIndex = 4
        Me.Serial.ValueMember = "Serial"
        '
        'SerialBindingSource
        '
        Me.SerialBindingSource.DataMember = "Serial"
        Me.SerialBindingSource.DataSource = Me.SignalogDataSet
        '
        'LoadPanel
        '
        Me.LoadPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LoadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoadPanel.Controls.Add(Me.AreaAll)
        Me.LoadPanel.Controls.Add(Me.AreaFilter)
        Me.LoadPanel.Controls.Add(Me.Label16)
        Me.LoadPanel.Controls.Add(Me.StatAll)
        Me.LoadPanel.Controls.Add(Me.ManAll)
        Me.LoadPanel.Controls.Add(Me.Label5)
        Me.LoadPanel.Controls.Add(Me.Label4)
        Me.LoadPanel.Controls.Add(Me.StatusFilter)
        Me.LoadPanel.Controls.Add(Me.ManFilter)
        Me.LoadPanel.Controls.Add(Me.Label3)
        Me.LoadPanel.Controls.Add(Me.SerialFilter)
        Me.LoadPanel.Controls.Add(Me.Label2)
        Me.LoadPanel.Controls.Add(Me.Label1)
        Me.LoadPanel.Controls.Add(Me.PartFilter)
        Me.LoadPanel.Controls.Add(Me.Serial)
        Me.LoadPanel.Controls.Add(Me.PartDesc)
        Me.LoadPanel.Location = New System.Drawing.Point(0, 54)
        Me.LoadPanel.Name = "LoadPanel"
        Me.LoadPanel.Size = New System.Drawing.Size(668, 515)
        Me.LoadPanel.TabIndex = 5
        '
        'AreaAll
        '
        Me.AreaAll.AutoSize = True
        Me.AreaAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AreaAll.Location = New System.Drawing.Point(226, 65)
        Me.AreaAll.Name = "AreaAll"
        Me.AreaAll.Size = New System.Drawing.Size(47, 19)
        Me.AreaAll.TabIndex = 18
        Me.AreaAll.Text = "ALL"
        Me.AreaAll.UseVisualStyleBackColor = True
        '
        'AreaFilter
        '
        Me.AreaFilter.DataSource = Me.CUS0BindingSource
        Me.AreaFilter.DisplayMember = "AREANAME"
        Me.AreaFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AreaFilter.FormattingEnabled = True
        Me.AreaFilter.Location = New System.Drawing.Point(47, 63)
        Me.AreaFilter.Name = "AreaFilter"
        Me.AreaFilter.Size = New System.Drawing.Size(173, 21)
        Me.AreaFilter.TabIndex = 17
        Me.AreaFilter.ValueMember = "AREANAME"
        '
        'CUS0BindingSource
        '
        Me.CUS0BindingSource.DataMember = "CUS0"
        Me.CUS0BindingSource.DataSource = Me.SignalogDataSet
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 66)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 15)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Area"
        '
        'StatAll
        '
        Me.StatAll.AutoSize = True
        Me.StatAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.StatAll.Location = New System.Drawing.Point(226, 35)
        Me.StatAll.Name = "StatAll"
        Me.StatAll.Size = New System.Drawing.Size(47, 19)
        Me.StatAll.TabIndex = 15
        Me.StatAll.Text = "ALL"
        Me.StatAll.UseVisualStyleBackColor = True
        '
        'ManAll
        '
        Me.ManAll.AutoSize = True
        Me.ManAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ManAll.Location = New System.Drawing.Point(226, 7)
        Me.ManAll.Name = "ManAll"
        Me.ManAll.Size = New System.Drawing.Size(47, 19)
        Me.ManAll.TabIndex = 14
        Me.ManAll.Text = "ALL"
        Me.ManAll.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 15)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Manuf."
        '
        'StatusFilter
        '
        Me.StatusFilter.DataSource = Me.PartsStatusTypeBindingSource
        Me.StatusFilter.DisplayMember = "Status Type"
        Me.StatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.StatusFilter.FormattingEnabled = True
        Me.StatusFilter.Location = New System.Drawing.Point(47, 33)
        Me.StatusFilter.Name = "StatusFilter"
        Me.StatusFilter.Size = New System.Drawing.Size(173, 21)
        Me.StatusFilter.TabIndex = 10
        Me.StatusFilter.ValueMember = "Status Type"
        '
        'PartsStatusTypeBindingSource
        '
        Me.PartsStatusTypeBindingSource.DataMember = "Parts Status Type"
        Me.PartsStatusTypeBindingSource.DataSource = Me.SignalogDataSet
        '
        'ManFilter
        '
        Me.ManFilter.DataSource = Me.MANFLISTBindingSource
        Me.ManFilter.DisplayMember = "MANUFACTURER"
        Me.ManFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ManFilter.FormattingEnabled = True
        Me.ManFilter.Location = New System.Drawing.Point(47, 3)
        Me.ManFilter.Name = "ManFilter"
        Me.ManFilter.Size = New System.Drawing.Size(173, 21)
        Me.ManFilter.TabIndex = 9
        Me.ManFilter.ValueMember = "MANUFACTURER"
        '
        'MANFLISTBindingSource
        '
        Me.MANFLISTBindingSource.DataMember = "MANF LIST"
        Me.MANFLISTBindingSource.DataSource = Me.SignalogDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(541, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Last 3 digits:"
        '
        'SerialFilter
        '
        Me.SerialFilter.Location = New System.Drawing.Point(618, 110)
        Me.SerialFilter.MaxLength = 3
        Me.SerialFilter.Name = "SerialFilter"
        Me.SerialFilter.Size = New System.Drawing.Size(45, 20)
        Me.SerialFilter.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(570, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Serial Number"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Part Description"
        '
        'SerialTableAdapter
        '
        Me.SerialTableAdapter.ClearBeforeFill = True
        '
        'Parts_Status_TypeTableAdapter
        '
        Me.Parts_Status_TypeTableAdapter.ClearBeforeFill = True
        '
        'MANF_LISTTableAdapter
        '
        Me.MANF_LISTTableAdapter.ClearBeforeFill = True
        '
        'IDlbl
        '
        Me.IDlbl.AutoSize = True
        Me.IDlbl.Location = New System.Drawing.Point(726, 102)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(47, 15)
        Me.IDlbl.TabIndex = 6
        Me.IDlbl.Text = "Part ID:"
        '
        'IDtxt
        '
        Me.IDtxt.Location = New System.Drawing.Point(776, 97)
        Me.IDtxt.Name = "IDtxt"
        Me.IDtxt.Size = New System.Drawing.Size(70, 20)
        Me.IDtxt.TabIndex = 7
        '
        'fwd
        '
        Me.fwd.Location = New System.Drawing.Point(907, 95)
        Me.fwd.Name = "fwd"
        Me.fwd.Size = New System.Drawing.Size(27, 23)
        Me.fwd.TabIndex = 9
        Me.fwd.Text = ">>"
        Me.fwd.UseVisualStyleBackColor = True
        '
        'bck
        '
        Me.bck.Location = New System.Drawing.Point(874, 95)
        Me.bck.Name = "bck"
        Me.bck.Size = New System.Drawing.Size(27, 23)
        Me.bck.TabIndex = 8
        Me.bck.Text = "<<"
        Me.bck.UseVisualStyleBackColor = True
        '
        'Desclbl
        '
        Me.Desclbl.AutoSize = True
        Me.Desclbl.Location = New System.Drawing.Point(703, 136)
        Me.Desclbl.Name = "Desclbl"
        Me.Desclbl.Size = New System.Drawing.Size(72, 15)
        Me.Desclbl.TabIndex = 10
        Me.Desclbl.Text = "Description:"
        '
        'SNlbl
        '
        Me.SNlbl.AutoSize = True
        Me.SNlbl.Location = New System.Drawing.Point(707, 171)
        Me.SNlbl.Name = "SNlbl"
        Me.SNlbl.Size = New System.Drawing.Size(66, 15)
        Me.SNlbl.TabIndex = 12
        Me.SNlbl.Text = "Model-SN:"
        '
        'SNtxt
        '
        Me.SNtxt.Location = New System.Drawing.Point(776, 168)
        Me.SNtxt.MaxLength = 35
        Me.SNtxt.Name = "SNtxt"
        Me.SNtxt.Size = New System.Drawing.Size(174, 20)
        Me.SNtxt.TabIndex = 14
        '
        'Desc
        '
        Me.Desc.DataSource = Me.PartsListBindingSource
        Me.Desc.DisplayMember = "Part Description"
        Me.Desc.DropDownHeight = 200
        Me.Desc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Desc.DropDownWidth = 350
        Me.Desc.FormattingEnabled = True
        Me.Desc.IntegralHeight = False
        Me.Desc.Location = New System.Drawing.Point(776, 133)
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(236, 21)
        Me.Desc.TabIndex = 13
        Me.Desc.ValueMember = "Part Description"
        '
        'PartsListBindingSource
        '
        Me.PartsListBindingSource.DataMember = "Parts List"
        Me.PartsListBindingSource.DataSource = Me.SignalogDataSet
        '
        'Statuslbl
        '
        Me.Statuslbl.AutoSize = True
        Me.Statuslbl.Location = New System.Drawing.Point(728, 206)
        Me.Statuslbl.Name = "Statuslbl"
        Me.Statuslbl.Size = New System.Drawing.Size(44, 15)
        Me.Statuslbl.TabIndex = 15
        Me.Statuslbl.Text = "Status:"
        '
        'Status
        '
        Me.Status.DataSource = Me.PartsStatusTypeBindingSource1
        Me.Status.DisplayMember = "Status Type"
        Me.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Status.FormattingEnabled = True
        Me.Status.Location = New System.Drawing.Point(776, 203)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(174, 21)
        Me.Status.TabIndex = 16
        Me.Status.ValueMember = "Status Type"
        '
        'PartsStatusTypeBindingSource1
        '
        Me.PartsStatusTypeBindingSource1.DataMember = "Parts Status Type"
        Me.PartsStatusTypeBindingSource1.DataSource = Me.SignalogDataSet
        '
        'Manuflbl
        '
        Me.Manuflbl.AutoSize = True
        Me.Manuflbl.Location = New System.Drawing.Point(724, 241)
        Me.Manuflbl.Name = "Manuflbl"
        Me.Manuflbl.Size = New System.Drawing.Size(48, 15)
        Me.Manuflbl.TabIndex = 17
        Me.Manuflbl.Text = "Manuf.:"
        '
        'Manuf
        '
        Me.Manuf.DataSource = Me.MANFLISTBindingSource1
        Me.Manuf.DisplayMember = "MANUFACTURER"
        Me.Manuf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Manuf.FormattingEnabled = True
        Me.Manuf.Location = New System.Drawing.Point(776, 238)
        Me.Manuf.Name = "Manuf"
        Me.Manuf.Size = New System.Drawing.Size(174, 21)
        Me.Manuf.TabIndex = 18
        Me.Manuf.ValueMember = "MANUFACTURER"
        '
        'MANFLISTBindingSource1
        '
        Me.MANFLISTBindingSource1.DataMember = "MANF LIST"
        Me.MANFLISTBindingSource1.DataSource = Me.SignalogDataSet
        '
        'Conlbl
        '
        Me.Conlbl.AutoSize = True
        Me.Conlbl.Location = New System.Drawing.Point(715, 276)
        Me.Conlbl.Name = "Conlbl"
        Me.Conlbl.Size = New System.Drawing.Size(111, 15)
        Me.Conlbl.TabIndex = 19
        Me.Conlbl.Text = "Contract Unit Price:"
        '
        'ContCosttxt
        '
        Me.ContCosttxt.Location = New System.Drawing.Point(829, 273)
        Me.ContCosttxt.Name = "ContCosttxt"
        Me.ContCosttxt.Size = New System.Drawing.Size(121, 20)
        Me.ContCosttxt.TabIndex = 20
        '
        'Showlbl
        '
        Me.Showlbl.AutoSize = True
        Me.Showlbl.Location = New System.Drawing.Point(725, 341)
        Me.Showlbl.Name = "Showlbl"
        Me.Showlbl.Size = New System.Drawing.Size(45, 15)
        Me.Showlbl.TabIndex = 22
        Me.Showlbl.Text = "Show?"
        '
        'Submit
        '
        Me.Submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Submit.Location = New System.Drawing.Point(826, 507)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 25
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Parts_ListTableAdapter
        '
        Me.Parts_ListTableAdapter.ClearBeforeFill = True
        '
        'EQUIPMENTBindingSource
        '
        Me.EQUIPMENTBindingSource.DataMember = "EQUIPMENT"
        Me.EQUIPMENTBindingSource.DataSource = Me.SignalogDataSet
        '
        'EQUIPMENTTableAdapter
        '
        Me.EQUIPMENTTableAdapter.ClearBeforeFill = True
        '
        'LoadBylbl
        '
        Me.LoadBylbl.AutoSize = True
        Me.LoadBylbl.Location = New System.Drawing.Point(707, 66)
        Me.LoadBylbl.Name = "LoadBylbl"
        Me.LoadBylbl.Size = New System.Drawing.Size(54, 15)
        Me.LoadBylbl.TabIndex = 26
        Me.LoadBylbl.Text = "Load By:"
        '
        'YES
        '
        Me.YES.AutoSize = True
        Me.YES.Location = New System.Drawing.Point(776, 339)
        Me.YES.Name = "YES"
        Me.YES.Size = New System.Drawing.Size(48, 19)
        Me.YES.TabIndex = 23
        Me.YES.TabStop = True
        Me.YES.Text = "YES"
        Me.YES.UseVisualStyleBackColor = True
        '
        'NO
        '
        Me.NO.AutoSize = True
        Me.NO.Location = New System.Drawing.Point(828, 339)
        Me.NO.Name = "NO"
        Me.NO.Size = New System.Drawing.Size(43, 19)
        Me.NO.TabIndex = 24
        Me.NO.TabStop = True
        Me.NO.Text = "NO"
        Me.NO.UseVisualStyleBackColor = True
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
        'LoadByPanel
        '
        Me.LoadByPanel.Controls.Add(Me.Filters)
        Me.LoadByPanel.Controls.Add(Me.ID)
        Me.LoadByPanel.Location = New System.Drawing.Point(776, 61)
        Me.LoadByPanel.Name = "LoadByPanel"
        Me.LoadByPanel.Size = New System.Drawing.Size(98, 23)
        Me.LoadByPanel.TabIndex = 29
        '
        'SrcPanel
        '
        Me.SrcPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SrcPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SrcPanel.Controls.Add(Me.WareHouse)
        Me.SrcPanel.Controls.Add(Me.WareHouselbl)
        Me.SrcPanel.Controls.Add(Me.CityOwned)
        Me.SrcPanel.Controls.Add(Me.Local)
        Me.SrcPanel.Controls.Add(Me.Label14)
        Me.SrcPanel.Location = New System.Drawing.Point(0, 24)
        Me.SrcPanel.Name = "SrcPanel"
        Me.SrcPanel.Size = New System.Drawing.Size(1051, 30)
        Me.SrcPanel.TabIndex = 30
        '
        'WareHouse
        '
        Me.WareHouse.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WareHouse.FormattingEnabled = True
        Me.WareHouse.Items.AddRange(New Object() {"TUL", "OKC", "ARK"})
        Me.WareHouse.Location = New System.Drawing.Point(970, 3)
        Me.WareHouse.Name = "WareHouse"
        Me.WareHouse.Size = New System.Drawing.Size(75, 21)
        Me.WareHouse.TabIndex = 28
        '
        'WareHouselbl
        '
        Me.WareHouselbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WareHouselbl.AutoSize = True
        Me.WareHouselbl.Location = New System.Drawing.Point(891, 7)
        Me.WareHouselbl.Name = "WareHouselbl"
        Me.WareHouselbl.Size = New System.Drawing.Size(75, 15)
        Me.WareHouselbl.TabIndex = 27
        Me.WareHouselbl.Text = "WareHouse:"
        '
        'CityOwned
        '
        Me.CityOwned.AutoSize = True
        Me.CityOwned.Location = New System.Drawing.Point(172, 5)
        Me.CityOwned.Name = "CityOwned"
        Me.CityOwned.Size = New System.Drawing.Size(86, 19)
        Me.CityOwned.TabIndex = 26
        Me.CityOwned.TabStop = True
        Me.CityOwned.Text = "City Owned"
        Me.CityOwned.UseVisualStyleBackColor = True
        '
        'Local
        '
        Me.Local.AutoSize = True
        Me.Local.Location = New System.Drawing.Point(115, 5)
        Me.Local.Name = "Local"
        Me.Local.Size = New System.Drawing.Size(55, 19)
        Me.Local.TabIndex = 25
        Me.Local.TabStop = True
        Me.Local.Text = "Local"
        Me.Local.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(1, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Equipment Source:"
        '
        'Arealbl
        '
        Me.Arealbl.AutoSize = True
        Me.Arealbl.Location = New System.Drawing.Point(738, 373)
        Me.Arealbl.Name = "Arealbl"
        Me.Arealbl.Size = New System.Drawing.Size(35, 15)
        Me.Arealbl.TabIndex = 31
        Me.Arealbl.Text = "Area:"
        '
        'Area
        '
        Me.Area.DataSource = Me.CUS0BindingSource1
        Me.Area.DisplayMember = "AREANAME"
        Me.Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Area.FormattingEnabled = True
        Me.Area.Location = New System.Drawing.Point(776, 370)
        Me.Area.Name = "Area"
        Me.Area.Size = New System.Drawing.Size(179, 21)
        Me.Area.TabIndex = 14
        Me.Area.ValueMember = "AREANAME"
        '
        'CUS0BindingSource1
        '
        Me.CUS0BindingSource1.DataMember = "CUS0"
        Me.CUS0BindingSource1.DataSource = Me.SignalogDataSet
        '
        'CUS0TableAdapter
        '
        Me.CUS0TableAdapter.ClearBeforeFill = True
        '
        'Part2BindingSource
        '
        Me.Part2BindingSource.DataMember = "Part2"
        Me.Part2BindingSource.DataSource = Me.SignalogDataSet
        '
        'Part2TableAdapter
        '
        Me.Part2TableAdapter.ClearBeforeFill = True
        '
        'Serial2BindingSource
        '
        Me.Serial2BindingSource.DataMember = "Serial2"
        Me.Serial2BindingSource.DataSource = Me.SignalogDataSet
        '
        'Serial2TableAdapter
        '
        Me.Serial2TableAdapter.ClearBeforeFill = True
        '
        'EQUIPMENT2BindingSource
        '
        Me.EQUIPMENT2BindingSource.DataMember = "EQUIPMENT2"
        Me.EQUIPMENT2BindingSource.DataSource = Me.SignalogDataSet
        '
        'EQUIPMENT2TableAdapter
        '
        Me.EQUIPMENT2TableAdapter.ClearBeforeFill = True
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
        'ACT3BindingSource
        '
        Me.ACT3BindingSource.DataMember = "ACT3"
        Me.ACT3BindingSource.DataSource = Me.SignalogDataSet
        '
        'ACT3TableAdapter
        '
        Me.ACT3TableAdapter.ClearBeforeFill = True
        '
        'NoneSN
        '
        Me.NoneSN.AutoSize = True
        Me.NoneSN.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NoneSN.Location = New System.Drawing.Point(956, 169)
        Me.NoneSN.Name = "NoneSN"
        Me.NoneSN.Size = New System.Drawing.Size(56, 19)
        Me.NoneSN.TabIndex = 15
        Me.NoneSN.Text = "None"
        Me.NoneSN.UseVisualStyleBackColor = True
        '
        'Quantlbl
        '
        Me.Quantlbl.AutoSize = True
        Me.Quantlbl.Location = New System.Drawing.Point(707, 405)
        Me.Quantlbl.Name = "Quantlbl"
        Me.Quantlbl.Size = New System.Drawing.Size(54, 15)
        Me.Quantlbl.TabIndex = 33
        Me.Quantlbl.Text = "Quantity:"
        '
        'Quantity
        '
        Me.Quantity.Location = New System.Drawing.Point(776, 402)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        Me.Quantity.Size = New System.Drawing.Size(100, 20)
        Me.Quantity.TabIndex = 22
        '
        'NonContCosttxt
        '
        Me.NonContCosttxt.Location = New System.Drawing.Point(829, 305)
        Me.NonContCosttxt.Name = "NonContCosttxt"
        Me.NonContCosttxt.Size = New System.Drawing.Size(121, 20)
        Me.NonContCosttxt.TabIndex = 21
        '
        'Nonconlbl
        '
        Me.Nonconlbl.AutoSize = True
        Me.Nonconlbl.Location = New System.Drawing.Point(693, 308)
        Me.Nonconlbl.Name = "Nonconlbl"
        Me.Nonconlbl.Size = New System.Drawing.Size(134, 15)
        Me.Nonconlbl.TabIndex = 34
        Me.Nonconlbl.Text = "NonContract Unit Price:"
        '
        'PartWareHouselbl
        '
        Me.PartWareHouselbl.AutoSize = True
        Me.PartWareHouselbl.Location = New System.Drawing.Point(698, 436)
        Me.PartWareHouselbl.Name = "PartWareHouselbl"
        Me.PartWareHouselbl.Size = New System.Drawing.Size(75, 15)
        Me.PartWareHouselbl.TabIndex = 35
        Me.PartWareHouselbl.Text = "WareHouse:"
        '
        'PartWareHouse
        '
        Me.PartWareHouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PartWareHouse.FormattingEnabled = True
        Me.PartWareHouse.Items.AddRange(New Object() {"TUL", "OKC", "ARK"})
        Me.PartWareHouse.Location = New System.Drawing.Point(776, 433)
        Me.PartWareHouse.Name = "PartWareHouse"
        Me.PartWareHouse.Size = New System.Drawing.Size(100, 21)
        Me.PartWareHouse.TabIndex = 29
        '
        'PartNumlbl
        '
        Me.PartNumlbl.AutoSize = True
        Me.PartNumlbl.Location = New System.Drawing.Point(694, 472)
        Me.PartNumlbl.Name = "PartNumlbl"
        Me.PartNumlbl.Size = New System.Drawing.Size(80, 15)
        Me.PartNumlbl.TabIndex = 36
        Me.PartNumlbl.Text = "Part Number:"
        '
        'PartNum
        '
        Me.PartNum.Location = New System.Drawing.Point(776, 469)
        Me.PartNum.Name = "PartNum"
        Me.PartNum.Size = New System.Drawing.Size(100, 20)
        Me.PartNum.TabIndex = 37
        '
        'Inventory_Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 568)
        Me.Controls.Add(Me.PartNum)
        Me.Controls.Add(Me.PartNumlbl)
        Me.Controls.Add(Me.PartWareHouse)
        Me.Controls.Add(Me.PartWareHouselbl)
        Me.Controls.Add(Me.NonContCosttxt)
        Me.Controls.Add(Me.Nonconlbl)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.Quantlbl)
        Me.Controls.Add(Me.NoneSN)
        Me.Controls.Add(Me.Area)
        Me.Controls.Add(Me.Arealbl)
        Me.Controls.Add(Me.SrcPanel)
        Me.Controls.Add(Me.LoadByPanel)
        Me.Controls.Add(Me.LoadBylbl)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.NO)
        Me.Controls.Add(Me.YES)
        Me.Controls.Add(Me.Showlbl)
        Me.Controls.Add(Me.ContCosttxt)
        Me.Controls.Add(Me.Conlbl)
        Me.Controls.Add(Me.Manuf)
        Me.Controls.Add(Me.Manuflbl)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Statuslbl)
        Me.Controls.Add(Me.Desc)
        Me.Controls.Add(Me.SNtxt)
        Me.Controls.Add(Me.SNlbl)
        Me.Controls.Add(Me.Desclbl)
        Me.Controls.Add(Me.fwd)
        Me.Controls.Add(Me.bck)
        Me.Controls.Add(Me.IDtxt)
        Me.Controls.Add(Me.IDlbl)
        Me.Controls.Add(Me.LoadPanel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inventory_Maintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Maintenance"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SerialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoadPanel.ResumeLayout(False)
        Me.LoadPanel.PerformLayout()
        CType(Me.CUS0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartsStatusTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANFLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartsListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartsStatusTypeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANFLISTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoadByPanel.ResumeLayout(False)
        Me.LoadByPanel.PerformLayout()
        Me.SrcPanel.ResumeLayout(False)
        Me.SrcPanel.PerformLayout()
        CType(Me.CUS0BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Part2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Serial2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENT2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCKNEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCKEDITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents UndoButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PartDesc As System.Windows.Forms.ListBox
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents PartTableAdapter As Signalog.SignalogDataSetTableAdapters.PartTableAdapter
    Friend WithEvents PartFilter As System.Windows.Forms.TextBox
    Friend WithEvents Serial As System.Windows.Forms.ListBox
    Friend WithEvents LoadPanel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SerialFilter As System.Windows.Forms.TextBox
    Friend WithEvents SerialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SerialTableAdapter As Signalog.SignalogDataSetTableAdapters.SerialTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StatusFilter As System.Windows.Forms.ComboBox
    Friend WithEvents ManFilter As System.Windows.Forms.ComboBox
    Friend WithEvents PartsStatusTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Parts_Status_TypeTableAdapter As Signalog.SignalogDataSetTableAdapters.Parts_Status_TypeTableAdapter
    Friend WithEvents StatAll As System.Windows.Forms.CheckBox
    Friend WithEvents ManAll As System.Windows.Forms.CheckBox
    Friend WithEvents MANFLISTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MANF_LISTTableAdapter As Signalog.SignalogDataSetTableAdapters.MANF_LISTTableAdapter
    Friend WithEvents IDlbl As System.Windows.Forms.Label
    Friend WithEvents IDtxt As System.Windows.Forms.TextBox
    Friend WithEvents fwd As System.Windows.Forms.Button
    Friend WithEvents bck As System.Windows.Forms.Button
    Friend WithEvents Desclbl As System.Windows.Forms.Label
    Friend WithEvents SNlbl As System.Windows.Forms.Label
    Friend WithEvents SNtxt As System.Windows.Forms.TextBox
    Friend WithEvents Desc As System.Windows.Forms.ComboBox
    Friend WithEvents Statuslbl As System.Windows.Forms.Label
    Friend WithEvents Status As System.Windows.Forms.ComboBox
    Friend WithEvents Manuflbl As System.Windows.Forms.Label
    Friend WithEvents Manuf As System.Windows.Forms.ComboBox
    Friend WithEvents Conlbl As System.Windows.Forms.Label
    Friend WithEvents ContCosttxt As System.Windows.Forms.TextBox
    Friend WithEvents Showlbl As System.Windows.Forms.Label
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents PartsListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Parts_ListTableAdapter As Signalog.SignalogDataSetTableAdapters.Parts_ListTableAdapter
    Friend WithEvents EQUIPMENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENTTableAdapter As Signalog.SignalogDataSetTableAdapters.EQUIPMENTTableAdapter
    Friend WithEvents LoadBylbl As System.Windows.Forms.Label
    Friend WithEvents YES As System.Windows.Forms.RadioButton
    Friend WithEvents NO As System.Windows.Forms.RadioButton
    Friend WithEvents ID As System.Windows.Forms.RadioButton
    Friend WithEvents Filters As System.Windows.Forms.RadioButton
    Friend WithEvents LoadByPanel As System.Windows.Forms.Panel
    Friend WithEvents SrcPanel As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CityOwned As System.Windows.Forms.RadioButton
    Friend WithEvents Local As System.Windows.Forms.RadioButton
    Friend WithEvents Arealbl As System.Windows.Forms.Label
    Friend WithEvents Area As System.Windows.Forms.ComboBox
    Friend WithEvents CUS0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUS0TableAdapter As Signalog.SignalogDataSetTableAdapters.CUS0TableAdapter
    Friend WithEvents Part2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Part2TableAdapter As Signalog.SignalogDataSetTableAdapters.Part2TableAdapter
    Friend WithEvents Serial2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Serial2TableAdapter As Signalog.SignalogDataSetTableAdapters.Serial2TableAdapter
    Friend WithEvents EQUIPMENT2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENT2TableAdapter As Signalog.SignalogDataSetTableAdapters.EQUIPMENT2TableAdapter
    Friend WithEvents PartsStatusTypeBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MANFLISTBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents AreaAll As System.Windows.Forms.CheckBox
    Friend WithEvents AreaFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CUS0BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKNEWBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKNEWTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKNEWTableAdapter
    Friend WithEvents LOCKEDITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKEDITTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKEDITTableAdapter
    Friend WithEvents ACT3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT3TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT3TableAdapter
    Friend WithEvents NoneSN As System.Windows.Forms.CheckBox
    Friend WithEvents PartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Quantlbl As System.Windows.Forms.Label
    Friend WithEvents Quantity As System.Windows.Forms.TextBox
    Friend WithEvents NonContCosttxt As System.Windows.Forms.TextBox
    Friend WithEvents Nonconlbl As System.Windows.Forms.Label
    Friend WithEvents WareHouselbl As System.Windows.Forms.Label
    Friend WithEvents WareHouse As System.Windows.Forms.ComboBox
    Friend WithEvents PartWareHouselbl As System.Windows.Forms.Label
    Friend WithEvents PartWareHouse As System.Windows.Forms.ComboBox
    Friend WithEvents PartNumlbl As System.Windows.Forms.Label
    Friend WithEvents PartNum As System.Windows.Forms.TextBox
End Class
