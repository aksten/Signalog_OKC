<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Area_Maintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Area_Maintenance))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewButton = New System.Windows.Forms.ToolStripButton()
        Me.EditButton = New System.Windows.Forms.ToolStripButton()
        Me.DeleteButton = New System.Windows.Forms.ToolStripButton()
        Me.UndoButton = New System.Windows.Forms.ToolStripButton()
        Me.LoadPanel = New System.Windows.Forms.Panel()
        Me.FilterArea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AREA = New System.Windows.Forms.ListBox()
        Me.CUS0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.FilterBoth = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FilterNO = New System.Windows.Forms.RadioButton()
        Me.FilterYES = New System.Windows.Forms.RadioButton()
        Me.CUS0TableAdapter = New Signalog.SignalogDataSetTableAdapters.CUS0TableAdapter()
        Me.LoadByPanel = New System.Windows.Forms.Panel()
        Me.Filters = New System.Windows.Forms.RadioButton()
        Me.ID = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.fwd = New System.Windows.Forms.Button()
        Me.bck = New System.Windows.Forms.Button()
        Me.AREANUM = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.AreaPanel = New System.Windows.Forms.Panel()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.MaintNO = New System.Windows.Forms.RadioButton()
        Me.PicklistId = New System.Windows.Forms.TextBox()
        Me.MaintYES = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AccountNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CustomerName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NO = New System.Windows.Forms.RadioButton()
        Me.YES = New System.Windows.Forms.RadioButton()
        Me.InvPanel = New System.Windows.Forms.Panel()
        Me.InvTerms = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.InvTele = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.InvZip = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.InvState = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.InvCity = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.InvAddr2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.InvAddr1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.InvAttn = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ConPanel = New System.Windows.Forms.Panel()
        Me.ConTitle = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ConTele = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ConZip = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ConState = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ConCity = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ConAddr2 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.ConAddr1 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.ConAttn = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.PeriodPanel = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Brief = New System.Windows.Forms.RadioButton()
        Me.Full = New System.Windows.Forms.RadioButton()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.PeriodLength = New System.Windows.Forms.TextBox()
        Me.PeriodRate = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.RatePanel = New System.Windows.Forms.Panel()
        Me.MinHrs = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.OTRate = New System.Windows.Forms.TextBox()
        Me.RegRate = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.MaintContPanel = New System.Windows.Forms.Panel()
        Me.LOCKNEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCKNEWTableAdapter = New Signalog.SignalogDataSetTableAdapters.LOCKNEWTableAdapter()
        Me.LOCKEDITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCKEDITTableAdapter = New Signalog.SignalogDataSetTableAdapters.LOCKEDITTableAdapter()
        Me.LOC0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOC0TableAdapter = New Signalog.SignalogDataSetTableAdapters.LOC0TableAdapter()
        Me.EQUIPMENT2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPMENT2TableAdapter = New Signalog.SignalogDataSetTableAdapters.EQUIPMENT2TableAdapter()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.MileageRate = New System.Windows.Forms.TextBox()
        Me.MileageRatePanel = New System.Windows.Forms.Panel()
        Me.ToolStrip1.SuspendLayout()
        Me.LoadPanel.SuspendLayout()
        CType(Me.CUS0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoadByPanel.SuspendLayout()
        Me.AreaPanel.SuspendLayout()
        Me.InvPanel.SuspendLayout()
        Me.ConPanel.SuspendLayout()
        Me.PeriodPanel.SuspendLayout()
        Me.RatePanel.SuspendLayout()
        Me.MaintContPanel.SuspendLayout()
        CType(Me.LOCKNEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCKEDITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOC0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENT2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MileageRatePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(17, 17)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.EditButton, Me.DeleteButton, Me.UndoButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(876, 25)
        Me.ToolStrip1.TabIndex = 3
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
        'LoadPanel
        '
        Me.LoadPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LoadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoadPanel.Controls.Add(Me.FilterArea)
        Me.LoadPanel.Controls.Add(Me.Label1)
        Me.LoadPanel.Controls.Add(Me.AREA)
        Me.LoadPanel.Controls.Add(Me.FilterBoth)
        Me.LoadPanel.Controls.Add(Me.Label7)
        Me.LoadPanel.Controls.Add(Me.FilterNO)
        Me.LoadPanel.Controls.Add(Me.FilterYES)
        Me.LoadPanel.Location = New System.Drawing.Point(0, 25)
        Me.LoadPanel.Name = "LoadPanel"
        Me.LoadPanel.Size = New System.Drawing.Size(193, 571)
        Me.LoadPanel.TabIndex = 4
        '
        'FilterArea
        '
        Me.FilterArea.Location = New System.Drawing.Point(55, 34)
        Me.FilterArea.Name = "FilterArea"
        Me.FilterArea.Size = New System.Drawing.Size(133, 20)
        Me.FilterArea.TabIndex = 106
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
        'AREA
        '
        Me.AREA.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AREA.DataSource = Me.CUS0BindingSource
        Me.AREA.DisplayMember = "AREANAME"
        Me.AREA.FormattingEnabled = True
        Me.AREA.Location = New System.Drawing.Point(0, 57)
        Me.AREA.Name = "AREA"
        Me.AREA.Size = New System.Drawing.Size(188, 511)
        Me.AREA.TabIndex = 107
        Me.AREA.ValueMember = "AREANAME"
        '
        'CUS0BindingSource
        '
        Me.CUS0BindingSource.DataMember = "CUS0"
        Me.CUS0BindingSource.DataSource = Me.SignalogDataSet
        '
        'SignalogDataSet
        '
        Me.SignalogDataSet.DataSetName = "SignalogDataSet"
        Me.SignalogDataSet.EnforceConstraints = False
        Me.SignalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CUS0TableAdapter
        '
        Me.CUS0TableAdapter.ClearBeforeFill = True
        '
        'LoadByPanel
        '
        Me.LoadByPanel.Controls.Add(Me.Filters)
        Me.LoadByPanel.Controls.Add(Me.ID)
        Me.LoadByPanel.Location = New System.Drawing.Point(278, 28)
        Me.LoadByPanel.Name = "LoadByPanel"
        Me.LoadByPanel.Size = New System.Drawing.Size(110, 23)
        Me.LoadByPanel.TabIndex = 43
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
        Me.Label13.Location = New System.Drawing.Point(209, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 15)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Load By:"
        '
        'fwd
        '
        Me.fwd.Location = New System.Drawing.Point(408, 62)
        Me.fwd.Name = "fwd"
        Me.fwd.Size = New System.Drawing.Size(27, 23)
        Me.fwd.TabIndex = 41
        Me.fwd.Text = ">>"
        Me.fwd.UseVisualStyleBackColor = True
        '
        'bck
        '
        Me.bck.Location = New System.Drawing.Point(375, 62)
        Me.bck.Name = "bck"
        Me.bck.Size = New System.Drawing.Size(27, 23)
        Me.bck.TabIndex = 40
        Me.bck.Text = "<<"
        Me.bck.UseVisualStyleBackColor = True
        '
        'AREANUM
        '
        Me.AREANUM.Location = New System.Drawing.Point(278, 64)
        Me.AREANUM.Name = "AREANUM"
        Me.AREANUM.Size = New System.Drawing.Size(70, 20)
        Me.AREANUM.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(209, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Area ID:"
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(453, 559)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 52
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'AreaPanel
        '
        Me.AreaPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AreaPanel.Controls.Add(Me.Label31)
        Me.AreaPanel.Controls.Add(Me.MaintNO)
        Me.AreaPanel.Controls.Add(Me.PicklistId)
        Me.AreaPanel.Controls.Add(Me.MaintYES)
        Me.AreaPanel.Controls.Add(Me.Label4)
        Me.AreaPanel.Controls.Add(Me.AccountNo)
        Me.AreaPanel.Controls.Add(Me.Label3)
        Me.AreaPanel.Controls.Add(Me.CustomerName)
        Me.AreaPanel.Controls.Add(Me.Label2)
        Me.AreaPanel.Location = New System.Drawing.Point(202, 90)
        Me.AreaPanel.Name = "AreaPanel"
        Me.AreaPanel.Size = New System.Drawing.Size(607, 71)
        Me.AreaPanel.TabIndex = 53
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(446, 45)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(59, 15)
        Me.Label31.TabIndex = 110
        Me.Label31.Text = "Contract?"
        '
        'MaintNO
        '
        Me.MaintNO.AutoSize = True
        Me.MaintNO.Location = New System.Drawing.Point(558, 42)
        Me.MaintNO.Name = "MaintNO"
        Me.MaintNO.Size = New System.Drawing.Size(41, 19)
        Me.MaintNO.TabIndex = 112
        Me.MaintNO.TabStop = True
        Me.MaintNO.Text = "No"
        Me.MaintNO.UseVisualStyleBackColor = True
        '
        'PicklistId
        '
        Me.PicklistId.Location = New System.Drawing.Point(106, 42)
        Me.PicklistId.MaxLength = 50
        Me.PicklistId.Name = "PicklistId"
        Me.PicklistId.Size = New System.Drawing.Size(334, 20)
        Me.PicklistId.TabIndex = 6
        '
        'MaintYES
        '
        Me.MaintYES.AutoSize = True
        Me.MaintYES.Location = New System.Drawing.Point(511, 42)
        Me.MaintYES.Name = "MaintYES"
        Me.MaintYES.Size = New System.Drawing.Size(45, 19)
        Me.MaintYES.TabIndex = 111
        Me.MaintYES.TabStop = True
        Me.MaintYES.Text = "Yes"
        Me.MaintYES.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "PickList ID:"
        '
        'AccountNo
        '
        Me.AccountNo.Location = New System.Drawing.Point(519, 7)
        Me.AccountNo.MaxLength = 25
        Me.AccountNo.Name = "AccountNo"
        Me.AccountNo.Size = New System.Drawing.Size(82, 20)
        Me.AccountNo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(446, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Account No:"
        '
        'CustomerName
        '
        Me.CustomerName.Location = New System.Drawing.Point(106, 7)
        Me.CustomerName.MaxLength = 50
        Me.CustomerName.Name = "CustomerName"
        Me.CustomerName.Size = New System.Drawing.Size(334, 20)
        Me.CustomerName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 107
        Me.Label5.Text = "Show?"
        '
        'NO
        '
        Me.NO.AutoSize = True
        Me.NO.Location = New System.Drawing.Point(104, 8)
        Me.NO.Name = "NO"
        Me.NO.Size = New System.Drawing.Size(41, 19)
        Me.NO.TabIndex = 109
        Me.NO.TabStop = True
        Me.NO.Text = "No"
        Me.NO.UseVisualStyleBackColor = True
        '
        'YES
        '
        Me.YES.AutoSize = True
        Me.YES.Location = New System.Drawing.Point(57, 8)
        Me.YES.Name = "YES"
        Me.YES.Size = New System.Drawing.Size(45, 19)
        Me.YES.TabIndex = 108
        Me.YES.TabStop = True
        Me.YES.Text = "Yes"
        Me.YES.UseVisualStyleBackColor = True
        '
        'InvPanel
        '
        Me.InvPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.InvPanel.Controls.Add(Me.InvTerms)
        Me.InvPanel.Controls.Add(Me.Label16)
        Me.InvPanel.Controls.Add(Me.InvTele)
        Me.InvPanel.Controls.Add(Me.Label15)
        Me.InvPanel.Controls.Add(Me.InvZip)
        Me.InvPanel.Controls.Add(Me.Label14)
        Me.InvPanel.Controls.Add(Me.InvState)
        Me.InvPanel.Controls.Add(Me.Label12)
        Me.InvPanel.Controls.Add(Me.InvCity)
        Me.InvPanel.Controls.Add(Me.Label11)
        Me.InvPanel.Controls.Add(Me.InvAddr2)
        Me.InvPanel.Controls.Add(Me.Label10)
        Me.InvPanel.Controls.Add(Me.InvAddr1)
        Me.InvPanel.Controls.Add(Me.Label9)
        Me.InvPanel.Controls.Add(Me.InvAttn)
        Me.InvPanel.Controls.Add(Me.Label8)
        Me.InvPanel.Location = New System.Drawing.Point(203, 167)
        Me.InvPanel.Name = "InvPanel"
        Me.InvPanel.Size = New System.Drawing.Size(300, 248)
        Me.InvPanel.TabIndex = 54
        '
        'InvTerms
        '
        Me.InvTerms.Location = New System.Drawing.Point(56, 217)
        Me.InvTerms.MaxLength = 15
        Me.InvTerms.Name = "InvTerms"
        Me.InvTerms.Size = New System.Drawing.Size(237, 20)
        Me.InvTerms.TabIndex = 124
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 220)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 15)
        Me.Label16.TabIndex = 123
        Me.Label16.Text = "Terms:"
        '
        'InvTele
        '
        Me.InvTele.Location = New System.Drawing.Point(56, 182)
        Me.InvTele.Mask = "(999) 000-0000"
        Me.InvTele.Name = "InvTele"
        Me.InvTele.Size = New System.Drawing.Size(237, 20)
        Me.InvTele.TabIndex = 122
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(3, 185)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 15)
        Me.Label15.TabIndex = 121
        Me.Label15.Text = "Tele:"
        '
        'InvZip
        '
        Me.InvZip.Location = New System.Drawing.Point(187, 147)
        Me.InvZip.MaxLength = 10
        Me.InvZip.Name = "InvZip"
        Me.InvZip.Size = New System.Drawing.Size(106, 20)
        Me.InvZip.TabIndex = 120
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(156, 150)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(27, 15)
        Me.Label14.TabIndex = 119
        Me.Label14.Text = "Zip:"
        '
        'InvState
        '
        Me.InvState.Location = New System.Drawing.Point(56, 147)
        Me.InvState.MaxLength = 2
        Me.InvState.Name = "InvState"
        Me.InvState.Size = New System.Drawing.Size(94, 20)
        Me.InvState.TabIndex = 118
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 15)
        Me.Label12.TabIndex = 117
        Me.Label12.Text = "State:"
        '
        'InvCity
        '
        Me.InvCity.Location = New System.Drawing.Point(56, 112)
        Me.InvCity.MaxLength = 20
        Me.InvCity.Name = "InvCity"
        Me.InvCity.Size = New System.Drawing.Size(237, 20)
        Me.InvCity.TabIndex = 116
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 115)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 15)
        Me.Label11.TabIndex = 115
        Me.Label11.Text = "City:"
        '
        'InvAddr2
        '
        Me.InvAddr2.Location = New System.Drawing.Point(56, 77)
        Me.InvAddr2.MaxLength = 50
        Me.InvAddr2.Name = "InvAddr2"
        Me.InvAddr2.Size = New System.Drawing.Size(237, 20)
        Me.InvAddr2.TabIndex = 114
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 15)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Addr:"
        '
        'InvAddr1
        '
        Me.InvAddr1.Location = New System.Drawing.Point(56, 42)
        Me.InvAddr1.MaxLength = 75
        Me.InvAddr1.Name = "InvAddr1"
        Me.InvAddr1.Size = New System.Drawing.Size(237, 20)
        Me.InvAddr1.TabIndex = 112
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 45)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 15)
        Me.Label9.TabIndex = 111
        Me.Label9.Text = "Email:"
        '
        'InvAttn
        '
        Me.InvAttn.Location = New System.Drawing.Point(94, 7)
        Me.InvAttn.MaxLength = 50
        Me.InvAttn.Name = "InvAttn"
        Me.InvAttn.Size = New System.Drawing.Size(199, 20)
        Me.InvAttn.TabIndex = 110
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 15)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "Invoice Contact:"
        '
        'ConPanel
        '
        Me.ConPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ConPanel.Controls.Add(Me.ConTitle)
        Me.ConPanel.Controls.Add(Me.Label17)
        Me.ConPanel.Controls.Add(Me.ConTele)
        Me.ConPanel.Controls.Add(Me.Label18)
        Me.ConPanel.Controls.Add(Me.ConZip)
        Me.ConPanel.Controls.Add(Me.Label19)
        Me.ConPanel.Controls.Add(Me.ConState)
        Me.ConPanel.Controls.Add(Me.Label20)
        Me.ConPanel.Controls.Add(Me.ConCity)
        Me.ConPanel.Controls.Add(Me.Label21)
        Me.ConPanel.Controls.Add(Me.ConAddr2)
        Me.ConPanel.Controls.Add(Me.Label22)
        Me.ConPanel.Controls.Add(Me.ConAddr1)
        Me.ConPanel.Controls.Add(Me.Label23)
        Me.ConPanel.Controls.Add(Me.ConAttn)
        Me.ConPanel.Controls.Add(Me.Label24)
        Me.ConPanel.Location = New System.Drawing.Point(509, 167)
        Me.ConPanel.Name = "ConPanel"
        Me.ConPanel.Size = New System.Drawing.Size(300, 248)
        Me.ConPanel.TabIndex = 125
        '
        'ConTitle
        '
        Me.ConTitle.Location = New System.Drawing.Point(56, 42)
        Me.ConTitle.MaxLength = 50
        Me.ConTitle.Name = "ConTitle"
        Me.ConTitle.Size = New System.Drawing.Size(237, 20)
        Me.ConTitle.TabIndex = 124
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 15)
        Me.Label17.TabIndex = 123
        Me.Label17.Text = "Title:"
        '
        'ConTele
        '
        Me.ConTele.Location = New System.Drawing.Point(56, 217)
        Me.ConTele.Mask = "(999) 000-0000"
        Me.ConTele.Name = "ConTele"
        Me.ConTele.Size = New System.Drawing.Size(237, 20)
        Me.ConTele.TabIndex = 122
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 220)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 15)
        Me.Label18.TabIndex = 121
        Me.Label18.Text = "Tele:"
        '
        'ConZip
        '
        Me.ConZip.Location = New System.Drawing.Point(187, 182)
        Me.ConZip.MaxLength = 10
        Me.ConZip.Name = "ConZip"
        Me.ConZip.Size = New System.Drawing.Size(106, 20)
        Me.ConZip.TabIndex = 120
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(156, 185)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(27, 15)
        Me.Label19.TabIndex = 119
        Me.Label19.Text = "Zip:"
        '
        'ConState
        '
        Me.ConState.Location = New System.Drawing.Point(56, 182)
        Me.ConState.MaxLength = 2
        Me.ConState.Name = "ConState"
        Me.ConState.Size = New System.Drawing.Size(97, 20)
        Me.ConState.TabIndex = 118
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 185)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 15)
        Me.Label20.TabIndex = 117
        Me.Label20.Text = "State:"
        '
        'ConCity
        '
        Me.ConCity.Location = New System.Drawing.Point(56, 147)
        Me.ConCity.MaxLength = 20
        Me.ConCity.Name = "ConCity"
        Me.ConCity.Size = New System.Drawing.Size(237, 20)
        Me.ConCity.TabIndex = 116
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 150)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 15)
        Me.Label21.TabIndex = 115
        Me.Label21.Text = "City:"
        '
        'ConAddr2
        '
        Me.ConAddr2.Location = New System.Drawing.Point(56, 112)
        Me.ConAddr2.MaxLength = 50
        Me.ConAddr2.Name = "ConAddr2"
        Me.ConAddr2.Size = New System.Drawing.Size(237, 20)
        Me.ConAddr2.TabIndex = 114
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(3, 115)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(35, 15)
        Me.Label22.TabIndex = 113
        Me.Label22.Text = "Addr:"
        '
        'ConAddr1
        '
        Me.ConAddr1.Location = New System.Drawing.Point(56, 77)
        Me.ConAddr1.MaxLength = 75
        Me.ConAddr1.Name = "ConAddr1"
        Me.ConAddr1.Size = New System.Drawing.Size(237, 20)
        Me.ConAddr1.TabIndex = 112
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(42, 15)
        Me.Label23.TabIndex = 111
        Me.Label23.Text = "Email:"
        '
        'ConAttn
        '
        Me.ConAttn.Location = New System.Drawing.Point(83, 7)
        Me.ConAttn.MaxLength = 50
        Me.ConAttn.Name = "ConAttn"
        Me.ConAttn.Size = New System.Drawing.Size(210, 20)
        Me.ConAttn.TabIndex = 110
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 10)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(81, 15)
        Me.Label24.TabIndex = 110
        Me.Label24.Text = "Field Contact:"
        '
        'PeriodPanel
        '
        Me.PeriodPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PeriodPanel.Controls.Add(Me.Label25)
        Me.PeriodPanel.Controls.Add(Me.Brief)
        Me.PeriodPanel.Controls.Add(Me.Full)
        Me.PeriodPanel.Controls.Add(Me.Label26)
        Me.PeriodPanel.Controls.Add(Me.PeriodLength)
        Me.PeriodPanel.Controls.Add(Me.PeriodRate)
        Me.PeriodPanel.Controls.Add(Me.Label28)
        Me.PeriodPanel.Location = New System.Drawing.Point(202, 421)
        Me.PeriodPanel.Name = "PeriodPanel"
        Me.PeriodPanel.Size = New System.Drawing.Size(607, 37)
        Me.PeriodPanel.TabIndex = 110
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(420, 10)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 15)
        Me.Label25.TabIndex = 107
        Me.Label25.Text = "Rept Type:"
        '
        'Brief
        '
        Me.Brief.AutoSize = True
        Me.Brief.Location = New System.Drawing.Point(542, 8)
        Me.Brief.Name = "Brief"
        Me.Brief.Size = New System.Drawing.Size(50, 19)
        Me.Brief.TabIndex = 109
        Me.Brief.TabStop = True
        Me.Brief.Text = "Brief"
        Me.Brief.UseVisualStyleBackColor = True
        '
        'Full
        '
        Me.Full.AutoSize = True
        Me.Full.Location = New System.Drawing.Point(491, 8)
        Me.Full.Name = "Full"
        Me.Full.Size = New System.Drawing.Size(45, 19)
        Me.Full.TabIndex = 108
        Me.Full.TabStop = True
        Me.Full.Text = "Full"
        Me.Full.UseVisualStyleBackColor = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(197, 10)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 15)
        Me.Label26.TabIndex = 5
        Me.Label26.Text = "Period Length:"
        '
        'PeriodLength
        '
        Me.PeriodLength.Location = New System.Drawing.Point(290, 12)
        Me.PeriodLength.MaxLength = 6
        Me.PeriodLength.Name = "PeriodLength"
        Me.PeriodLength.Size = New System.Drawing.Size(77, 20)
        Me.PeriodLength.TabIndex = 4
        '
        'PeriodRate
        '
        Me.PeriodRate.Location = New System.Drawing.Point(83, 9)
        Me.PeriodRate.MaxLength = 10
        Me.PeriodRate.Name = "PeriodRate"
        Me.PeriodRate.Size = New System.Drawing.Size(91, 20)
        Me.PeriodRate.TabIndex = 2
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(3, 12)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(75, 15)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Period Rate:"
        '
        'RatePanel
        '
        Me.RatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RatePanel.Controls.Add(Me.MinHrs)
        Me.RatePanel.Controls.Add(Me.Label27)
        Me.RatePanel.Controls.Add(Me.Label29)
        Me.RatePanel.Controls.Add(Me.OTRate)
        Me.RatePanel.Controls.Add(Me.RegRate)
        Me.RatePanel.Controls.Add(Me.Label30)
        Me.RatePanel.Location = New System.Drawing.Point(202, 457)
        Me.RatePanel.Name = "RatePanel"
        Me.RatePanel.Size = New System.Drawing.Size(607, 37)
        Me.RatePanel.TabIndex = 111
        '
        'MinHrs
        '
        Me.MinHrs.Location = New System.Drawing.Point(477, 7)
        Me.MinHrs.MaxLength = 10
        Me.MinHrs.Name = "MinHrs"
        Me.MinHrs.Size = New System.Drawing.Size(124, 20)
        Me.MinHrs.TabIndex = 108
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(391, 10)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 15)
        Me.Label27.TabIndex = 107
        Me.Label27.Text = "Minimum Hrs:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(213, 10)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(71, 15)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "OT Hr Rate:"
        '
        'OTRate
        '
        Me.OTRate.Location = New System.Drawing.Point(290, 9)
        Me.OTRate.MaxLength = 10
        Me.OTRate.Name = "OTRate"
        Me.OTRate.Size = New System.Drawing.Size(77, 20)
        Me.OTRate.TabIndex = 4
        '
        'RegRate
        '
        Me.RegRate.Location = New System.Drawing.Point(83, 7)
        Me.RegRate.MaxLength = 10
        Me.RegRate.Name = "RegRate"
        Me.RegRate.Size = New System.Drawing.Size(90, 20)
        Me.RegRate.TabIndex = 2
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(3, 10)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(78, 15)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Reg Hr Rate:"
        '
        'MaintContPanel
        '
        Me.MaintContPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MaintContPanel.Controls.Add(Me.Label5)
        Me.MaintContPanel.Controls.Add(Me.NO)
        Me.MaintContPanel.Controls.Add(Me.YES)
        Me.MaintContPanel.Location = New System.Drawing.Point(652, 47)
        Me.MaintContPanel.Name = "MaintContPanel"
        Me.MaintContPanel.Size = New System.Drawing.Size(157, 37)
        Me.MaintContPanel.TabIndex = 126
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
        'LOC0BindingSource
        '
        Me.LOC0BindingSource.DataMember = "LOC0"
        Me.LOC0BindingSource.DataSource = Me.SignalogDataSet
        '
        'LOC0TableAdapter
        '
        Me.LOC0TableAdapter.ClearBeforeFill = True
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
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(5, 9)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(140, 15)
        Me.Label32.TabIndex = 109
        Me.Label32.Text = "Mileage Rate (per mile):"
        '
        'MileageRate
        '
        Me.MileageRate.Location = New System.Drawing.Point(146, 6)
        Me.MileageRate.MaxLength = 10
        Me.MileageRate.Name = "MileageRate"
        Me.MileageRate.Size = New System.Drawing.Size(84, 20)
        Me.MileageRate.TabIndex = 109
        '
        'MileageRatePanel
        '
        Me.MileageRatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MileageRatePanel.Controls.Add(Me.Label32)
        Me.MileageRatePanel.Controls.Add(Me.MileageRate)
        Me.MileageRatePanel.Location = New System.Drawing.Point(375, 493)
        Me.MileageRatePanel.Name = "MileageRatePanel"
        Me.MileageRatePanel.Size = New System.Drawing.Size(243, 37)
        Me.MileageRatePanel.TabIndex = 127
        '
        'Area_Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 594)
        Me.Controls.Add(Me.MileageRatePanel)
        Me.Controls.Add(Me.MaintContPanel)
        Me.Controls.Add(Me.RatePanel)
        Me.Controls.Add(Me.PeriodPanel)
        Me.Controls.Add(Me.ConPanel)
        Me.Controls.Add(Me.InvPanel)
        Me.Controls.Add(Me.AreaPanel)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.LoadByPanel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.fwd)
        Me.Controls.Add(Me.bck)
        Me.Controls.Add(Me.AREANUM)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LoadPanel)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Area_Maintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area Maintenance"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.LoadPanel.ResumeLayout(False)
        Me.LoadPanel.PerformLayout()
        CType(Me.CUS0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoadByPanel.ResumeLayout(False)
        Me.LoadByPanel.PerformLayout()
        Me.AreaPanel.ResumeLayout(False)
        Me.AreaPanel.PerformLayout()
        Me.InvPanel.ResumeLayout(False)
        Me.InvPanel.PerformLayout()
        Me.ConPanel.ResumeLayout(False)
        Me.ConPanel.PerformLayout()
        Me.PeriodPanel.ResumeLayout(False)
        Me.PeriodPanel.PerformLayout()
        Me.RatePanel.ResumeLayout(False)
        Me.RatePanel.PerformLayout()
        Me.MaintContPanel.ResumeLayout(False)
        Me.MaintContPanel.PerformLayout()
        CType(Me.LOCKNEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCKEDITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOC0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENT2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MileageRatePanel.ResumeLayout(False)
        Me.MileageRatePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents UndoButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LoadPanel As System.Windows.Forms.Panel
    Friend WithEvents FilterArea As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AREA As System.Windows.Forms.ListBox
    Friend WithEvents FilterBoth As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FilterNO As System.Windows.Forms.RadioButton
    Friend WithEvents FilterYES As System.Windows.Forms.RadioButton
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents CUS0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUS0TableAdapter As Signalog.SignalogDataSetTableAdapters.CUS0TableAdapter
    Friend WithEvents LoadByPanel As System.Windows.Forms.Panel
    Friend WithEvents Filters As System.Windows.Forms.RadioButton
    Friend WithEvents ID As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents fwd As System.Windows.Forms.Button
    Friend WithEvents bck As System.Windows.Forms.Button
    Friend WithEvents AREANUM As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents AreaPanel As System.Windows.Forms.Panel
    Friend WithEvents CustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PicklistId As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AccountNo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NO As System.Windows.Forms.RadioButton
    Friend WithEvents YES As System.Windows.Forms.RadioButton
    Friend WithEvents InvPanel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents InvAttn As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents InvAddr1 As System.Windows.Forms.TextBox
    Friend WithEvents InvAddr2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents InvState As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents InvCity As System.Windows.Forms.TextBox
    Friend WithEvents InvZip As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents InvTele As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents InvTerms As System.Windows.Forms.TextBox
    Friend WithEvents ConPanel As System.Windows.Forms.Panel
    Friend WithEvents ConTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ConTele As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ConZip As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ConState As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ConCity As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents ConAddr2 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents ConAddr1 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ConAttn As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents PeriodPanel As System.Windows.Forms.Panel
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Brief As System.Windows.Forms.RadioButton
    Friend WithEvents Full As System.Windows.Forms.RadioButton
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents PeriodLength As System.Windows.Forms.TextBox
    Friend WithEvents PeriodRate As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents RatePanel As System.Windows.Forms.Panel
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents OTRate As System.Windows.Forms.TextBox
    Friend WithEvents RegRate As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents MinHrs As System.Windows.Forms.TextBox
    Friend WithEvents MaintContPanel As System.Windows.Forms.Panel
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents MaintNO As System.Windows.Forms.RadioButton
    Friend WithEvents MaintYES As System.Windows.Forms.RadioButton
    Friend WithEvents LOCKNEWBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKNEWTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKNEWTableAdapter
    Friend WithEvents LOCKEDITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKEDITTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKEDITTableAdapter
    Friend WithEvents LOC0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOC0TableAdapter As Signalog.SignalogDataSetTableAdapters.LOC0TableAdapter
    Friend WithEvents EQUIPMENT2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENT2TableAdapter As Signalog.SignalogDataSetTableAdapters.EQUIPMENT2TableAdapter
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents MileageRate As System.Windows.Forms.TextBox
    Friend WithEvents MileageRatePanel As System.Windows.Forms.Panel
End Class
