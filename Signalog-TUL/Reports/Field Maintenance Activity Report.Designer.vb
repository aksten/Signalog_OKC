<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Field_Maintenance_Activity_Report
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Field_Maintenance_Activity_Report))
        Me.ViewReport = New System.Windows.Forms.Button()
        Me.Area = New System.Windows.Forms.ComboBox()
        Me.AREANAMEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.ACT0RPTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT1RPTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT0TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT0TableAdapter()
        Me.LOC0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOC0TableAdapter = New Signalog.SignalogDataSetTableAdapters.LOC0TableAdapter()
        Me.ACT0_RPTTableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT0_RPTTableAdapter()
        Me.AREANAMETableAdapter = New Signalog.SignalogDataSetTableAdapters.AREANAMETableAdapter()
        Me.ACT1TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT1TableAdapter()
        Me.ACT1_RPTTableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT1_RPTTableAdapter()
        Me.ASUBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASUBTableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUBTableAdapter()
        Me.field_Maintenance_Activity1 = New Signalog.Field_Maintenance_Activity()
        Me.CUS0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUS0TableAdapter = New Signalog.SignalogDataSetTableAdapters.CUS0TableAdapter()
        Me.ACT2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT2TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT2TableAdapter()
        Me.ACT9BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT9TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT9TableAdapter()
        Me.ACT3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT3TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT3TableAdapter()
        Me.PartsInsRPTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartsIns_RPTTableAdapter = New Signalog.SignalogDataSetTableAdapters.PartsIns_RPTTableAdapter()
        Me.PartsRemRPTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartsRem_RPTTableAdapter = New Signalog.SignalogDataSetTableAdapters.PartsRem_RPTTableAdapter()
        Me.EQUIPMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPMENTTableAdapter = New Signalog.SignalogDataSetTableAdapters.EQUIPMENTTableAdapter()
        Me.EQUIPMENT2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPMENT2TableAdapter = New Signalog.SignalogDataSetTableAdapters.EQUIPMENT2TableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NSLOC = New System.Windows.Forms.ComboBox()
        Me.NSLOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EWLOC = New System.Windows.Forms.ComboBox()
        Me.EWLOCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.EWLOCAll = New System.Windows.Forms.CheckBox()
        Me.NSLOCAll = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.IssueDateAll = New System.Windows.Forms.CheckBox()
        Me.EndWorkDateAll = New System.Windows.Forms.CheckBox()
        Me.EEndWorkDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BEndWorkDate = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DispBy = New System.Windows.Forms.ComboBox()
        Me.DISP0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignalogDataSet1 = New Signalog.SignalogDataSet()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.EnterBy = New System.Windows.Forms.ComboBox()
        Me.PERS0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Technician = New System.Windows.Forms.ComboBox()
        Me.PERS01BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepByAll = New System.Windows.Forms.CheckBox()
        Me.EnterByAll = New System.Windows.Forms.CheckBox()
        Me.TechAll = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.VehNum = New System.Windows.Forms.ComboBox()
        Me.VEHICLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignalogDataSet2 = New Signalog.SignalogDataSet()
        Me.VehNumAll = New System.Windows.Forms.CheckBox()
        Me.ShowPanel = New System.Windows.Forms.Panel()
        Me.FilterBoth = New System.Windows.Forms.RadioButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.FilterNO = New System.Windows.Forms.RadioButton()
        Me.FilterYES = New System.Windows.Forms.RadioButton()
        Me.LocationPanel = New System.Windows.Forms.Panel()
        Me.AreaAll = New System.Windows.Forms.CheckBox()
        Me.PersonnelPanel = New System.Windows.Forms.Panel()
        Me.DatesPanel = New System.Windows.Forms.Panel()
        Me.EWLOCTableAdapter = New Signalog.SignalogDataSetTableAdapters.EWLOCTableAdapter()
        Me.NSLOCTableAdapter = New Signalog.SignalogDataSetTableAdapters.NSLOCTableAdapter()
        Me.DISP0TableAdapter = New Signalog.SignalogDataSetTableAdapters.DISP0TableAdapter()
        Me.PERS0TableAdapter = New Signalog.SignalogDataSetTableAdapters.PERS0TableAdapter()
        Me.PERS01TableAdapter = New Signalog.SignalogDataSetTableAdapters.PERS01TableAdapter()
        Me.VEHICLETableAdapter = New Signalog.SignalogDataSetTableAdapters.VEHICLETableAdapter()
        Me.PartsListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Parts_ListTableAdapter = New Signalog.SignalogDataSetTableAdapters.Parts_ListTableAdapter()
        Me.LaborTypePanel = New System.Windows.Forms.Panel()
        Me.LaborBoth = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.OverTime = New System.Windows.Forms.RadioButton()
        Me.RegTime = New System.Windows.Forms.RadioButton()
        Me.ActivityGrid = New System.Windows.Forms.DataGridView()
        Me.Activity_Type = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Activity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnnualInspectionPanel = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.AnnInsNo = New System.Windows.Forms.RadioButton()
        Me.AnnInsYes = New System.Windows.Forms.RadioButton()
        CType(Me.AREANAMEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT0RPTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT1RPTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOC0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASUBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUS0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT9BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartsInsRPTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartsRemRPTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENT2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NSLOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EWLOCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DISP0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalogDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERS0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERS01BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VEHICLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalogDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ShowPanel.SuspendLayout()
        Me.LocationPanel.SuspendLayout()
        Me.PersonnelPanel.SuspendLayout()
        Me.DatesPanel.SuspendLayout()
        CType(Me.PartsListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LaborTypePanel.SuspendLayout()
        CType(Me.ActivityGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnnualInspectionPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ViewReport
        '
        Me.ViewReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ViewReport.Location = New System.Drawing.Point(348, 531)
        Me.ViewReport.Name = "ViewReport"
        Me.ViewReport.Size = New System.Drawing.Size(96, 23)
        Me.ViewReport.TabIndex = 1
        Me.ViewReport.Text = "Generate Report"
        Me.ViewReport.UseVisualStyleBackColor = True
        '
        'Area
        '
        Me.Area.DataSource = Me.AREANAMEBindingSource
        Me.Area.DisplayMember = "AREANAME"
        Me.Area.DropDownWidth = 200
        Me.Area.FormattingEnabled = True
        Me.Area.Location = New System.Drawing.Point(114, 3)
        Me.Area.Name = "Area"
        Me.Area.Size = New System.Drawing.Size(161, 21)
        Me.Area.TabIndex = 8
        Me.Area.ValueMember = "AREANAME"
        '
        'AREANAMEBindingSource
        '
        Me.AREANAMEBindingSource.DataMember = "AREANAME"
        Me.AREANAMEBindingSource.DataSource = Me.SignalogDataSet
        '
        'SignalogDataSet
        '
        Me.SignalogDataSet.DataSetName = "SignalogDataSet"
        Me.SignalogDataSet.EnforceConstraints = False
        Me.SignalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ACT0RPTBindingSource
        '
        Me.ACT0RPTBindingSource.DataMember = "ACT0_RPT"
        Me.ACT0RPTBindingSource.DataSource = Me.SignalogDataSet
        '
        'ACT0BindingSource
        '
        Me.ACT0BindingSource.DataMember = "ACT0"
        Me.ACT0BindingSource.DataSource = Me.SignalogDataSet
        '
        'ACT1RPTBindingSource
        '
        Me.ACT1RPTBindingSource.DataMember = "ACT1_RPT"
        Me.ACT1RPTBindingSource.DataSource = Me.SignalogDataSet
        '
        'ACT1BindingSource
        '
        Me.ACT1BindingSource.DataMember = "ACT1"
        Me.ACT1BindingSource.DataSource = Me.SignalogDataSet
        '
        'ACT0TableAdapter
        '
        Me.ACT0TableAdapter.ClearBeforeFill = True
        '
        'LOC0BindingSource
        '
        Me.LOC0BindingSource.DataMember = "LOC0"
        Me.LOC0BindingSource.DataSource = Me.SignalogDataSet
        '
        'LOC0TableAdapter
        '
        Me.LOC0TableAdapter.ClearBeforeFill = True
        '
        'ACT0_RPTTableAdapter
        '
        Me.ACT0_RPTTableAdapter.ClearBeforeFill = True
        '
        'AREANAMETableAdapter
        '
        Me.AREANAMETableAdapter.ClearBeforeFill = True
        '
        'ACT1TableAdapter
        '
        Me.ACT1TableAdapter.ClearBeforeFill = True
        '
        'ACT1_RPTTableAdapter
        '
        Me.ACT1_RPTTableAdapter.ClearBeforeFill = True
        '
        'ASUBBindingSource
        '
        Me.ASUBBindingSource.DataMember = "ASUB"
        Me.ASUBBindingSource.DataSource = Me.SignalogDataSet
        '
        'ASUBTableAdapter
        '
        Me.ASUBTableAdapter.ClearBeforeFill = True
        '
        'CUS0BindingSource
        '
        Me.CUS0BindingSource.DataMember = "CUS0"
        Me.CUS0BindingSource.DataSource = Me.SignalogDataSet
        '
        'CUS0TableAdapter
        '
        Me.CUS0TableAdapter.ClearBeforeFill = True
        '
        'ACT2BindingSource
        '
        Me.ACT2BindingSource.DataMember = "ACT2"
        Me.ACT2BindingSource.DataSource = Me.SignalogDataSet
        '
        'ACT2TableAdapter
        '
        Me.ACT2TableAdapter.ClearBeforeFill = True
        '
        'ACT9BindingSource
        '
        Me.ACT9BindingSource.DataMember = "ACT9"
        Me.ACT9BindingSource.DataSource = Me.SignalogDataSet
        '
        'ACT9TableAdapter
        '
        Me.ACT9TableAdapter.ClearBeforeFill = True
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
        'PartsInsRPTBindingSource
        '
        Me.PartsInsRPTBindingSource.DataMember = "PartsIns_RPT"
        Me.PartsInsRPTBindingSource.DataSource = Me.SignalogDataSet
        '
        'PartsIns_RPTTableAdapter
        '
        Me.PartsIns_RPTTableAdapter.ClearBeforeFill = True
        '
        'PartsRemRPTBindingSource
        '
        Me.PartsRemRPTBindingSource.DataMember = "PartsRem_RPT"
        Me.PartsRemRPTBindingSource.DataSource = Me.SignalogDataSet
        '
        'PartsRem_RPTTableAdapter
        '
        Me.PartsRem_RPTTableAdapter.ClearBeforeFill = True
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
        'EQUIPMENT2BindingSource
        '
        Me.EQUIPMENT2BindingSource.DataMember = "EQUIPMENT2"
        Me.EQUIPMENT2BindingSource.DataSource = Me.SignalogDataSet
        '
        'EQUIPMENT2TableAdapter
        '
        Me.EQUIPMENT2TableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "NS LOCATION:"
        '
        'NSLOC
        '
        Me.NSLOC.DataSource = Me.NSLOCBindingSource
        Me.NSLOC.DisplayMember = "NSLOC"
        Me.NSLOC.DropDownWidth = 200
        Me.NSLOC.FormattingEnabled = True
        Me.NSLOC.Location = New System.Drawing.Point(114, 66)
        Me.NSLOC.Name = "NSLOC"
        Me.NSLOC.Size = New System.Drawing.Size(161, 21)
        Me.NSLOC.TabIndex = 23
        Me.NSLOC.ValueMember = "NSLOC"
        '
        'NSLOCBindingSource
        '
        Me.NSLOCBindingSource.DataMember = "NSLOC"
        Me.NSLOCBindingSource.DataSource = Me.SignalogDataSet
        '
        'EWLOC
        '
        Me.EWLOC.DataSource = Me.EWLOCBindingSource
        Me.EWLOC.DisplayMember = "EWLOC"
        Me.EWLOC.DropDownWidth = 200
        Me.EWLOC.FormattingEnabled = True
        Me.EWLOC.IntegralHeight = False
        Me.EWLOC.Location = New System.Drawing.Point(114, 34)
        Me.EWLOC.Name = "EWLOC"
        Me.EWLOC.Size = New System.Drawing.Size(161, 21)
        Me.EWLOC.TabIndex = 22
        Me.EWLOC.ValueMember = "EWLOC"
        '
        'EWLOCBindingSource
        '
        Me.EWLOCBindingSource.DataMember = "EWLOC"
        Me.EWLOCBindingSource.DataSource = Me.SignalogDataSet
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "EW LOCATION:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "CITY/AGENCY:"
        '
        'EWLOCAll
        '
        Me.EWLOCAll.AutoSize = True
        Me.EWLOCAll.Location = New System.Drawing.Point(284, 36)
        Me.EWLOCAll.Name = "EWLOCAll"
        Me.EWLOCAll.Size = New System.Drawing.Size(37, 17)
        Me.EWLOCAll.TabIndex = 27
        Me.EWLOCAll.Text = "All"
        Me.EWLOCAll.UseVisualStyleBackColor = True
        '
        'NSLOCAll
        '
        Me.NSLOCAll.AutoSize = True
        Me.NSLOCAll.Location = New System.Drawing.Point(284, 68)
        Me.NSLOCAll.Name = "NSLOCAll"
        Me.NSLOCAll.Size = New System.Drawing.Size(37, 17)
        Me.NSLOCAll.TabIndex = 28
        Me.NSLOCAll.Text = "All"
        Me.NSLOCAll.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "ISSUE DATE:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(111, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "From:"
        '
        'BIssueDate
        '
        Me.BIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BIssueDate.Location = New System.Drawing.Point(150, 5)
        Me.BIssueDate.Name = "BIssueDate"
        Me.BIssueDate.Size = New System.Drawing.Size(89, 20)
        Me.BIssueDate.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(252, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "To:"
        '
        'EIssueDate
        '
        Me.EIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EIssueDate.Location = New System.Drawing.Point(281, 5)
        Me.EIssueDate.Name = "EIssueDate"
        Me.EIssueDate.Size = New System.Drawing.Size(89, 20)
        Me.EIssueDate.TabIndex = 33
        '
        'IssueDateAll
        '
        Me.IssueDateAll.AutoSize = True
        Me.IssueDateAll.Location = New System.Drawing.Point(376, 8)
        Me.IssueDateAll.Name = "IssueDateAll"
        Me.IssueDateAll.Size = New System.Drawing.Size(37, 17)
        Me.IssueDateAll.TabIndex = 34
        Me.IssueDateAll.Text = "All"
        Me.IssueDateAll.UseVisualStyleBackColor = True
        '
        'EndWorkDateAll
        '
        Me.EndWorkDateAll.AutoSize = True
        Me.EndWorkDateAll.Location = New System.Drawing.Point(376, 40)
        Me.EndWorkDateAll.Name = "EndWorkDateAll"
        Me.EndWorkDateAll.Size = New System.Drawing.Size(37, 17)
        Me.EndWorkDateAll.TabIndex = 40
        Me.EndWorkDateAll.Text = "All"
        Me.EndWorkDateAll.UseVisualStyleBackColor = True
        '
        'EEndWorkDate
        '
        Me.EEndWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.EEndWorkDate.Location = New System.Drawing.Point(281, 37)
        Me.EEndWorkDate.Name = "EEndWorkDate"
        Me.EEndWorkDate.Size = New System.Drawing.Size(89, 20)
        Me.EEndWorkDate.TabIndex = 39
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(252, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "To:"
        '
        'BEndWorkDate
        '
        Me.BEndWorkDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BEndWorkDate.Location = New System.Drawing.Point(150, 37)
        Me.BEndWorkDate.Name = "BEndWorkDate"
        Me.BEndWorkDate.Size = New System.Drawing.Size(89, 20)
        Me.BEndWorkDate.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(111, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "From:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "END WORK DATE:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "REPORTED BY:"
        '
        'DispBy
        '
        Me.DispBy.DataSource = Me.DISP0BindingSource
        Me.DispBy.DisplayMember = "DISPBY"
        Me.DispBy.FormattingEnabled = True
        Me.DispBy.Location = New System.Drawing.Point(114, 8)
        Me.DispBy.Name = "DispBy"
        Me.DispBy.Size = New System.Drawing.Size(161, 21)
        Me.DispBy.TabIndex = 42
        Me.DispBy.ValueMember = "DISPBY"
        '
        'DISP0BindingSource
        '
        Me.DISP0BindingSource.DataMember = "DISP0"
        Me.DISP0BindingSource.DataSource = Me.SignalogDataSet1
        '
        'SignalogDataSet1
        '
        Me.SignalogDataSet1.DataSetName = "SignalogDataSet"
        Me.SignalogDataSet1.EnforceConstraints = False
        Me.SignalogDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 13)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "ENTERED BY:"
        '
        'EnterBy
        '
        Me.EnterBy.DataSource = Me.PERS0BindingSource
        Me.EnterBy.DisplayMember = "PLISTNAME"
        Me.EnterBy.FormattingEnabled = True
        Me.EnterBy.Location = New System.Drawing.Point(114, 40)
        Me.EnterBy.Name = "EnterBy"
        Me.EnterBy.Size = New System.Drawing.Size(161, 21)
        Me.EnterBy.TabIndex = 44
        Me.EnterBy.ValueMember = "PLISTNAME"
        '
        'PERS0BindingSource
        '
        Me.PERS0BindingSource.DataMember = "PERS0"
        Me.PERS0BindingSource.DataSource = Me.SignalogDataSet
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 13)
        Me.Label12.TabIndex = 45
        Me.Label12.Text = "TECHNICIAN:"
        '
        'Technician
        '
        Me.Technician.DataSource = Me.PERS01BindingSource
        Me.Technician.DisplayMember = "PLISTNAME"
        Me.Technician.FormattingEnabled = True
        Me.Technician.Location = New System.Drawing.Point(114, 72)
        Me.Technician.Name = "Technician"
        Me.Technician.Size = New System.Drawing.Size(161, 21)
        Me.Technician.TabIndex = 46
        Me.Technician.ValueMember = "PLISTNAME"
        '
        'PERS01BindingSource
        '
        Me.PERS01BindingSource.DataMember = "PERS01"
        Me.PERS01BindingSource.DataSource = Me.SignalogDataSet
        '
        'RepByAll
        '
        Me.RepByAll.AutoSize = True
        Me.RepByAll.Location = New System.Drawing.Point(281, 10)
        Me.RepByAll.Name = "RepByAll"
        Me.RepByAll.Size = New System.Drawing.Size(37, 17)
        Me.RepByAll.TabIndex = 47
        Me.RepByAll.Text = "All"
        Me.RepByAll.UseVisualStyleBackColor = True
        '
        'EnterByAll
        '
        Me.EnterByAll.AutoSize = True
        Me.EnterByAll.Location = New System.Drawing.Point(281, 42)
        Me.EnterByAll.Name = "EnterByAll"
        Me.EnterByAll.Size = New System.Drawing.Size(37, 17)
        Me.EnterByAll.TabIndex = 48
        Me.EnterByAll.Text = "All"
        Me.EnterByAll.UseVisualStyleBackColor = True
        '
        'TechAll
        '
        Me.TechAll.AutoSize = True
        Me.TechAll.Location = New System.Drawing.Point(281, 74)
        Me.TechAll.Name = "TechAll"
        Me.TechAll.Size = New System.Drawing.Size(37, 17)
        Me.TechAll.TabIndex = 49
        Me.TechAll.Text = "All"
        Me.TechAll.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "VEHICLE NUM:"
        '
        'VehNum
        '
        Me.VehNum.DataSource = Me.VEHICLEBindingSource
        Me.VehNum.DisplayMember = "VEHNUM"
        Me.VehNum.FormattingEnabled = True
        Me.VehNum.Location = New System.Drawing.Point(114, 104)
        Me.VehNum.Name = "VehNum"
        Me.VehNum.Size = New System.Drawing.Size(161, 21)
        Me.VehNum.TabIndex = 51
        Me.VehNum.ValueMember = "VEHNUM"
        '
        'VEHICLEBindingSource
        '
        Me.VEHICLEBindingSource.DataMember = "VEHICLE"
        Me.VEHICLEBindingSource.DataSource = Me.SignalogDataSet2
        '
        'SignalogDataSet2
        '
        Me.SignalogDataSet2.DataSetName = "SignalogDataSet"
        Me.SignalogDataSet2.EnforceConstraints = False
        Me.SignalogDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VehNumAll
        '
        Me.VehNumAll.AutoSize = True
        Me.VehNumAll.Location = New System.Drawing.Point(281, 106)
        Me.VehNumAll.Name = "VehNumAll"
        Me.VehNumAll.Size = New System.Drawing.Size(37, 17)
        Me.VehNumAll.TabIndex = 52
        Me.VehNumAll.Text = "All"
        Me.VehNumAll.UseVisualStyleBackColor = True
        '
        'ShowPanel
        '
        Me.ShowPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ShowPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ShowPanel.Controls.Add(Me.FilterBoth)
        Me.ShowPanel.Controls.Add(Me.Label14)
        Me.ShowPanel.Controls.Add(Me.FilterNO)
        Me.ShowPanel.Controls.Add(Me.FilterYES)
        Me.ShowPanel.Location = New System.Drawing.Point(345, 125)
        Me.ShowPanel.Name = "ShowPanel"
        Me.ShowPanel.Size = New System.Drawing.Size(281, 31)
        Me.ShowPanel.TabIndex = 53
        '
        'FilterBoth
        '
        Me.FilterBoth.AutoSize = True
        Me.FilterBoth.Location = New System.Drawing.Point(230, 6)
        Me.FilterBoth.Name = "FilterBoth"
        Me.FilterBoth.Size = New System.Drawing.Size(47, 17)
        Me.FilterBoth.TabIndex = 100
        Me.FilterBoth.TabStop = True
        Me.FilterBoth.Text = "Both"
        Me.FilterBoth.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(131, 13)
        Me.Label14.TabIndex = 97
        Me.Label14.Text = "FIELD ACTIVITY SHOW?"
        '
        'FilterNO
        '
        Me.FilterNO.AutoSize = True
        Me.FilterNO.Location = New System.Drawing.Point(185, 6)
        Me.FilterNO.Name = "FilterNO"
        Me.FilterNO.Size = New System.Drawing.Size(39, 17)
        Me.FilterNO.TabIndex = 99
        Me.FilterNO.TabStop = True
        Me.FilterNO.Text = "No"
        Me.FilterNO.UseVisualStyleBackColor = True
        '
        'FilterYES
        '
        Me.FilterYES.AutoSize = True
        Me.FilterYES.Location = New System.Drawing.Point(138, 6)
        Me.FilterYES.Name = "FilterYES"
        Me.FilterYES.Size = New System.Drawing.Size(43, 17)
        Me.FilterYES.TabIndex = 98
        Me.FilterYES.TabStop = True
        Me.FilterYES.Text = "Yes"
        Me.FilterYES.UseVisualStyleBackColor = True
        '
        'LocationPanel
        '
        Me.LocationPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LocationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LocationPanel.Controls.Add(Me.AreaAll)
        Me.LocationPanel.Controls.Add(Me.Label1)
        Me.LocationPanel.Controls.Add(Me.Area)
        Me.LocationPanel.Controls.Add(Me.Label2)
        Me.LocationPanel.Controls.Add(Me.EWLOC)
        Me.LocationPanel.Controls.Add(Me.NSLOC)
        Me.LocationPanel.Controls.Add(Me.Label3)
        Me.LocationPanel.Controls.Add(Me.EWLOCAll)
        Me.LocationPanel.Controls.Add(Me.NSLOCAll)
        Me.LocationPanel.Location = New System.Drawing.Point(12, 18)
        Me.LocationPanel.Name = "LocationPanel"
        Me.LocationPanel.Size = New System.Drawing.Size(327, 95)
        Me.LocationPanel.TabIndex = 54
        '
        'AreaAll
        '
        Me.AreaAll.AutoSize = True
        Me.AreaAll.Location = New System.Drawing.Point(284, 5)
        Me.AreaAll.Name = "AreaAll"
        Me.AreaAll.Size = New System.Drawing.Size(37, 17)
        Me.AreaAll.TabIndex = 29
        Me.AreaAll.Text = "All"
        Me.AreaAll.UseVisualStyleBackColor = True
        '
        'PersonnelPanel
        '
        Me.PersonnelPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PersonnelPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PersonnelPanel.Controls.Add(Me.Label10)
        Me.PersonnelPanel.Controls.Add(Me.DispBy)
        Me.PersonnelPanel.Controls.Add(Me.Label11)
        Me.PersonnelPanel.Controls.Add(Me.VehNumAll)
        Me.PersonnelPanel.Controls.Add(Me.EnterBy)
        Me.PersonnelPanel.Controls.Add(Me.VehNum)
        Me.PersonnelPanel.Controls.Add(Me.Label12)
        Me.PersonnelPanel.Controls.Add(Me.Label13)
        Me.PersonnelPanel.Controls.Add(Me.Technician)
        Me.PersonnelPanel.Controls.Add(Me.TechAll)
        Me.PersonnelPanel.Controls.Add(Me.RepByAll)
        Me.PersonnelPanel.Controls.Add(Me.EnterByAll)
        Me.PersonnelPanel.Location = New System.Drawing.Point(12, 125)
        Me.PersonnelPanel.Name = "PersonnelPanel"
        Me.PersonnelPanel.Size = New System.Drawing.Size(327, 135)
        Me.PersonnelPanel.TabIndex = 55
        '
        'DatesPanel
        '
        Me.DatesPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DatesPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DatesPanel.Controls.Add(Me.Label4)
        Me.DatesPanel.Controls.Add(Me.Label5)
        Me.DatesPanel.Controls.Add(Me.BIssueDate)
        Me.DatesPanel.Controls.Add(Me.Label6)
        Me.DatesPanel.Controls.Add(Me.EndWorkDateAll)
        Me.DatesPanel.Controls.Add(Me.EIssueDate)
        Me.DatesPanel.Controls.Add(Me.EEndWorkDate)
        Me.DatesPanel.Controls.Add(Me.IssueDateAll)
        Me.DatesPanel.Controls.Add(Me.Label7)
        Me.DatesPanel.Controls.Add(Me.Label9)
        Me.DatesPanel.Controls.Add(Me.BEndWorkDate)
        Me.DatesPanel.Controls.Add(Me.Label8)
        Me.DatesPanel.Location = New System.Drawing.Point(345, 18)
        Me.DatesPanel.Name = "DatesPanel"
        Me.DatesPanel.Size = New System.Drawing.Size(437, 74)
        Me.DatesPanel.TabIndex = 56
        '
        'EWLOCTableAdapter
        '
        Me.EWLOCTableAdapter.ClearBeforeFill = True
        '
        'NSLOCTableAdapter
        '
        Me.NSLOCTableAdapter.ClearBeforeFill = True
        '
        'DISP0TableAdapter
        '
        Me.DISP0TableAdapter.ClearBeforeFill = True
        '
        'PERS0TableAdapter
        '
        Me.PERS0TableAdapter.ClearBeforeFill = True
        '
        'PERS01TableAdapter
        '
        Me.PERS01TableAdapter.ClearBeforeFill = True
        '
        'VEHICLETableAdapter
        '
        Me.VEHICLETableAdapter.ClearBeforeFill = True
        '
        'PartsListBindingSource
        '
        Me.PartsListBindingSource.DataMember = "Parts List"
        Me.PartsListBindingSource.DataSource = Me.SignalogDataSet
        '
        'Parts_ListTableAdapter
        '
        Me.Parts_ListTableAdapter.ClearBeforeFill = True
        '
        'LaborTypePanel
        '
        Me.LaborTypePanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LaborTypePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LaborTypePanel.Controls.Add(Me.LaborBoth)
        Me.LaborTypePanel.Controls.Add(Me.Label15)
        Me.LaborTypePanel.Controls.Add(Me.OverTime)
        Me.LaborTypePanel.Controls.Add(Me.RegTime)
        Me.LaborTypePanel.Location = New System.Drawing.Point(345, 167)
        Me.LaborTypePanel.Name = "LaborTypePanel"
        Me.LaborTypePanel.Size = New System.Drawing.Size(281, 31)
        Me.LaborTypePanel.TabIndex = 101
        '
        'LaborBoth
        '
        Me.LaborBoth.AutoSize = True
        Me.LaborBoth.Location = New System.Drawing.Point(230, 6)
        Me.LaborBoth.Name = "LaborBoth"
        Me.LaborBoth.Size = New System.Drawing.Size(47, 17)
        Me.LaborBoth.TabIndex = 100
        Me.LaborBoth.TabStop = True
        Me.LaborBoth.Text = "Both"
        Me.LaborBoth.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 97
        Me.Label15.Text = "LABOR:"
        '
        'OverTime
        '
        Me.OverTime.AutoSize = True
        Me.OverTime.Location = New System.Drawing.Point(150, 6)
        Me.OverTime.Name = "OverTime"
        Me.OverTime.Size = New System.Drawing.Size(74, 17)
        Me.OverTime.TabIndex = 99
        Me.OverTime.TabStop = True
        Me.OverTime.Text = "Over Time"
        Me.OverTime.UseVisualStyleBackColor = True
        '
        'RegTime
        '
        Me.RegTime.AutoSize = True
        Me.RegTime.Location = New System.Drawing.Point(56, 6)
        Me.RegTime.Name = "RegTime"
        Me.RegTime.Size = New System.Drawing.Size(88, 17)
        Me.RegTime.TabIndex = 98
        Me.RegTime.TabStop = True
        Me.RegTime.Text = "Regular Time"
        Me.RegTime.UseVisualStyleBackColor = True
        '
        'ActivityGrid
        '
        Me.ActivityGrid.AllowUserToResizeColumns = False
        Me.ActivityGrid.AllowUserToResizeRows = False
        Me.ActivityGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActivityGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ActivityGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ActivityGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ActivityGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Activity_Type, Me.Activity})
        Me.ActivityGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ActivityGrid.Location = New System.Drawing.Point(12, 266)
        Me.ActivityGrid.Name = "ActivityGrid"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ActivityGrid.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.ActivityGrid.Size = New System.Drawing.Size(770, 259)
        Me.ActivityGrid.TabIndex = 102
        '
        'Activity_Type
        '
        Me.Activity_Type.HeaderText = "ACTIVITY TYPE"
        Me.Activity_Type.Items.AddRange(New Object() {"Reported Problem", "Arrival Condition", "Action Taken", "Deferred Action", "Departing Condition Notes"})
        Me.Activity_Type.Name = "Activity_Type"
        Me.Activity_Type.Width = 160
        '
        'Activity
        '
        Me.Activity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Activity.HeaderText = "ACTIVITY"
        Me.Activity.Name = "Activity"
        Me.Activity.ReadOnly = True
        '
        'AnnualInspectionPanel
        '
        Me.AnnualInspectionPanel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.AnnualInspectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AnnualInspectionPanel.Controls.Add(Me.Label16)
        Me.AnnualInspectionPanel.Controls.Add(Me.AnnInsNo)
        Me.AnnualInspectionPanel.Controls.Add(Me.AnnInsYes)
        Me.AnnualInspectionPanel.Location = New System.Drawing.Point(345, 204)
        Me.AnnualInspectionPanel.Name = "AnnualInspectionPanel"
        Me.AnnualInspectionPanel.Size = New System.Drawing.Size(281, 31)
        Me.AnnualInspectionPanel.TabIndex = 103
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(163, 13)
        Me.Label16.TabIndex = 97
        Me.Label16.Text = "Include ANNUAL INSPECTION?"
        '
        'AnnInsNo
        '
        Me.AnnInsNo.AutoSize = True
        Me.AnnInsNo.Location = New System.Drawing.Point(230, 6)
        Me.AnnInsNo.Name = "AnnInsNo"
        Me.AnnInsNo.Size = New System.Drawing.Size(39, 17)
        Me.AnnInsNo.TabIndex = 99
        Me.AnnInsNo.TabStop = True
        Me.AnnInsNo.Text = "No"
        Me.AnnInsNo.UseVisualStyleBackColor = True
        '
        'AnnInsYes
        '
        Me.AnnInsYes.AutoSize = True
        Me.AnnInsYes.Location = New System.Drawing.Point(183, 6)
        Me.AnnInsYes.Name = "AnnInsYes"
        Me.AnnInsYes.Size = New System.Drawing.Size(43, 17)
        Me.AnnInsYes.TabIndex = 98
        Me.AnnInsYes.TabStop = True
        Me.AnnInsYes.Text = "Yes"
        Me.AnnInsYes.UseVisualStyleBackColor = True
        '
        'Field_Maintenance_Activity_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.AnnualInspectionPanel)
        Me.Controls.Add(Me.ActivityGrid)
        Me.Controls.Add(Me.LaborTypePanel)
        Me.Controls.Add(Me.DatesPanel)
        Me.Controls.Add(Me.PersonnelPanel)
        Me.Controls.Add(Me.LocationPanel)
        Me.Controls.Add(Me.ShowPanel)
        Me.Controls.Add(Me.ViewReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Field_Maintenance_Activity_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Field Maintenance Activity Report"
        CType(Me.AREANAMEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT0RPTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT1RPTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOC0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASUBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUS0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT9BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartsInsRPTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartsRemRPTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENT2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NSLOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EWLOCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DISP0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalogDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERS0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERS01BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VEHICLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalogDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ShowPanel.ResumeLayout(False)
        Me.ShowPanel.PerformLayout()
        Me.LocationPanel.ResumeLayout(False)
        Me.LocationPanel.PerformLayout()
        Me.PersonnelPanel.ResumeLayout(False)
        Me.PersonnelPanel.PerformLayout()
        Me.DatesPanel.ResumeLayout(False)
        Me.DatesPanel.PerformLayout()
        CType(Me.PartsListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LaborTypePanel.ResumeLayout(False)
        Me.LaborTypePanel.PerformLayout()
        CType(Me.ActivityGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnnualInspectionPanel.ResumeLayout(False)
        Me.AnnualInspectionPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents ACT0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT0TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT0TableAdapter
    Friend WithEvents ViewReport As System.Windows.Forms.Button
    Friend WithEvents Area As System.Windows.Forms.ComboBox
    Friend WithEvents LOC0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOC0TableAdapter As Signalog.SignalogDataSetTableAdapters.LOC0TableAdapter
    Friend WithEvents ACT0RPTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT0_RPTTableAdapter As Signalog.SignalogDataSetTableAdapters.ACT0_RPTTableAdapter
    Friend WithEvents AREANAMEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AREANAMETableAdapter As Signalog.SignalogDataSetTableAdapters.AREANAMETableAdapter
    Friend WithEvents ACT1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT1TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT1TableAdapter
    Friend WithEvents ACT1RPTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT1_RPTTableAdapter As Signalog.SignalogDataSetTableAdapters.ACT1_RPTTableAdapter
    Friend WithEvents ASUBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUBTableAdapter As Signalog.SignalogDataSetTableAdapters.ASUBTableAdapter
    Friend WithEvents field_Maintenance_Activity1 As Signalog.Field_Maintenance_Activity
    Friend WithEvents EWLOCDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NSLOCDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CUS0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUS0TableAdapter As Signalog.SignalogDataSetTableAdapters.CUS0TableAdapter
    Friend WithEvents ACT2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT2TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT2TableAdapter
    Friend WithEvents ACT9BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT9TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT9TableAdapter
    Friend WithEvents ACT3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT3TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT3TableAdapter
    Friend WithEvents PartsInsRPTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartsIns_RPTTableAdapter As Signalog.SignalogDataSetTableAdapters.PartsIns_RPTTableAdapter
    Friend WithEvents PartsRemRPTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartsRem_RPTTableAdapter As Signalog.SignalogDataSetTableAdapters.PartsRem_RPTTableAdapter
    Friend WithEvents EQUIPMENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENTTableAdapter As Signalog.SignalogDataSetTableAdapters.EQUIPMENTTableAdapter
    Friend WithEvents EQUIPMENT2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENT2TableAdapter As Signalog.SignalogDataSetTableAdapters.EQUIPMENT2TableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NSLOC As System.Windows.Forms.ComboBox
    Friend WithEvents EWLOC As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EWLOCAll As System.Windows.Forms.CheckBox
    Friend WithEvents NSLOCAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents EIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents IssueDateAll As System.Windows.Forms.CheckBox
    Friend WithEvents EndWorkDateAll As System.Windows.Forms.CheckBox
    Friend WithEvents EEndWorkDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BEndWorkDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DispBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents EnterBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Technician As System.Windows.Forms.ComboBox
    Friend WithEvents RepByAll As System.Windows.Forms.CheckBox
    Friend WithEvents EnterByAll As System.Windows.Forms.CheckBox
    Friend WithEvents TechAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents VehNum As System.Windows.Forms.ComboBox
    Friend WithEvents VehNumAll As System.Windows.Forms.CheckBox
    Friend WithEvents FilterBoth As System.Windows.Forms.RadioButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents FilterNO As System.Windows.Forms.RadioButton
    Friend WithEvents FilterYES As System.Windows.Forms.RadioButton
    Friend WithEvents ShowPanel As System.Windows.Forms.Panel
    Friend WithEvents LocationPanel As System.Windows.Forms.Panel
    Friend WithEvents PersonnelPanel As System.Windows.Forms.Panel
    Friend WithEvents DatesPanel As System.Windows.Forms.Panel
    Friend WithEvents EWLOCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EWLOCTableAdapter As Signalog.SignalogDataSetTableAdapters.EWLOCTableAdapter
    Friend WithEvents NSLOCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NSLOCTableAdapter As Signalog.SignalogDataSetTableAdapters.NSLOCTableAdapter
    Friend WithEvents SignalogDataSet1 As Signalog.SignalogDataSet
    Friend WithEvents DISP0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DISP0TableAdapter As Signalog.SignalogDataSetTableAdapters.DISP0TableAdapter
    Friend WithEvents PERS0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PERS0TableAdapter As Signalog.SignalogDataSetTableAdapters.PERS0TableAdapter
    Friend WithEvents PERS01BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PERS01TableAdapter As Signalog.SignalogDataSetTableAdapters.PERS01TableAdapter
    Friend WithEvents SignalogDataSet2 As Signalog.SignalogDataSet
    Friend WithEvents VEHICLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VEHICLETableAdapter As Signalog.SignalogDataSetTableAdapters.VEHICLETableAdapter
    Friend WithEvents PartsListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Parts_ListTableAdapter As Signalog.SignalogDataSetTableAdapters.Parts_ListTableAdapter
    Friend WithEvents LaborTypePanel As System.Windows.Forms.Panel
    Friend WithEvents LaborBoth As System.Windows.Forms.RadioButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents OverTime As System.Windows.Forms.RadioButton
    Friend WithEvents RegTime As System.Windows.Forms.RadioButton
    Friend WithEvents AreaAll As System.Windows.Forms.CheckBox
    Friend WithEvents ActivityGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Activity_Type As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Activity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnnualInspectionPanel As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents AnnInsNo As System.Windows.Forms.RadioButton
    Friend WithEvents AnnInsYes As System.Windows.Forms.RadioButton
End Class
