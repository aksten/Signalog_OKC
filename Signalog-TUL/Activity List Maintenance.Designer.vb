<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Activity_List_Maintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Activity_List_Maintenance))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ActCat = New System.Windows.Forms.ComboBox()
        Me.ASUB1Panel = New System.Windows.Forms.Panel()
        Me.ASUB1GridView = New System.Windows.Forms.DataGridView()
        Me.LABELDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEQDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DESCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNKLABELDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SHOWDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASUB1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ASUB2Panel = New System.Windows.Forms.Panel()
        Me.ASUB2GridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASUB2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ASUB3Panel = New System.Windows.Forms.Panel()
        Me.ASUB3GridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASUB3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ASUB4Panel = New System.Windows.Forms.Panel()
        Me.ASUB4GridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASUB4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ASUB5Panel = New System.Windows.Forms.Panel()
        Me.ASUB5GridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASUB5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ASUB6Panel = New System.Windows.Forms.Panel()
        Me.ASUB6GridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ASUB6BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Save = New System.Windows.Forms.Button()
        Me.NewActCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ASUB1TableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUB1TableAdapter()
        Me.ASUB2TableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUB2TableAdapter()
        Me.ASUB3TableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUB3TableAdapter()
        Me.ASUB4TableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUB4TableAdapter()
        Me.ASUB5TableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUB5TableAdapter()
        Me.ASUB6TableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUB6TableAdapter()
        Me.ASUBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASUBTableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUBTableAdapter()
        Me.ACT1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT1TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT1TableAdapter()
        Me.CachedField_Maintenance_Activity1 = New Signalog.CachedField_Maintenance_Activity()
        Me.ASUB1Panel.SuspendLayout()
        CType(Me.ASUB1GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASUB1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ASUB2Panel.SuspendLayout()
        CType(Me.ASUB2GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASUB2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ASUB3Panel.SuspendLayout()
        CType(Me.ASUB3GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASUB3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ASUB4Panel.SuspendLayout()
        CType(Me.ASUB4GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASUB4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ASUB5Panel.SuspendLayout()
        CType(Me.ASUB5GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASUB5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ASUB6Panel.SuspendLayout()
        CType(Me.ASUB6GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASUB6BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASUBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Activity Category:"
        '
        'ActCat
        '
        Me.ActCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ActCat.FormattingEnabled = True
        Me.ActCat.Items.AddRange(New Object() {"PROBLEM REPORTED", "ARRIVAL CONDITION", "ACTION TAKEN", "DEFERRED ACTION", "DEPARTING CONDITION NOTES"})
        Me.ActCat.Location = New System.Drawing.Point(98, 6)
        Me.ActCat.Name = "ActCat"
        Me.ActCat.Size = New System.Drawing.Size(180, 21)
        Me.ActCat.TabIndex = 1
        '
        'ASUB1Panel
        '
        Me.ASUB1Panel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ASUB1Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ASUB1Panel.Controls.Add(Me.ASUB1GridView)
        Me.ASUB1Panel.Controls.Add(Me.Label2)
        Me.ASUB1Panel.Location = New System.Drawing.Point(-68, 40)
        Me.ASUB1Panel.Name = "ASUB1Panel"
        Me.ASUB1Panel.Size = New System.Drawing.Size(577, 882)
        Me.ASUB1Panel.TabIndex = 2
        '
        'ASUB1GridView
        '
        Me.ASUB1GridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ASUB1GridView.AutoGenerateColumns = False
        Me.ASUB1GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ASUB1GridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LABELDataGridViewTextBoxColumn, Me.SEQDataGridViewTextBoxColumn, Me.DESCDataGridViewTextBoxColumn, Me.LNKLABELDataGridViewTextBoxColumn, Me.ACTCODEDataGridViewTextBoxColumn, Me.SHOWDataGridViewTextBoxColumn})
        Me.ASUB1GridView.DataSource = Me.ASUB1BindingSource
        Me.ASUB1GridView.Location = New System.Drawing.Point(6, 20)
        Me.ASUB1GridView.Name = "ASUB1GridView"
        Me.ASUB1GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ASUB1GridView.Size = New System.Drawing.Size(563, 199)
        Me.ASUB1GridView.TabIndex = 1
        '
        'LABELDataGridViewTextBoxColumn
        '
        Me.LABELDataGridViewTextBoxColumn.DataPropertyName = "LABEL"
        Me.LABELDataGridViewTextBoxColumn.HeaderText = "LABEL"
        Me.LABELDataGridViewTextBoxColumn.Name = "LABELDataGridViewTextBoxColumn"
        '
        'SEQDataGridViewTextBoxColumn
        '
        Me.SEQDataGridViewTextBoxColumn.DataPropertyName = "SEQ"
        Me.SEQDataGridViewTextBoxColumn.HeaderText = "SEQ"
        Me.SEQDataGridViewTextBoxColumn.Name = "SEQDataGridViewTextBoxColumn"
        Me.SEQDataGridViewTextBoxColumn.Width = 40
        '
        'DESCDataGridViewTextBoxColumn
        '
        Me.DESCDataGridViewTextBoxColumn.DataPropertyName = "DESC"
        Me.DESCDataGridViewTextBoxColumn.HeaderText = "DESC"
        Me.DESCDataGridViewTextBoxColumn.Name = "DESCDataGridViewTextBoxColumn"
        Me.DESCDataGridViewTextBoxColumn.Width = 160
        '
        'LNKLABELDataGridViewTextBoxColumn
        '
        Me.LNKLABELDataGridViewTextBoxColumn.DataPropertyName = "LNKLABEL"
        Me.LNKLABELDataGridViewTextBoxColumn.HeaderText = "LNKLABEL"
        Me.LNKLABELDataGridViewTextBoxColumn.Name = "LNKLABELDataGridViewTextBoxColumn"
        '
        'ACTCODEDataGridViewTextBoxColumn
        '
        Me.ACTCODEDataGridViewTextBoxColumn.DataPropertyName = "ACTCODE"
        Me.ACTCODEDataGridViewTextBoxColumn.HeaderText = "ACTCODE"
        Me.ACTCODEDataGridViewTextBoxColumn.Name = "ACTCODEDataGridViewTextBoxColumn"
        Me.ACTCODEDataGridViewTextBoxColumn.Width = 60
        '
        'SHOWDataGridViewTextBoxColumn
        '
        Me.SHOWDataGridViewTextBoxColumn.DataPropertyName = "SHOW"
        Me.SHOWDataGridViewTextBoxColumn.HeaderText = "SHOW"
        Me.SHOWDataGridViewTextBoxColumn.Name = "SHOWDataGridViewTextBoxColumn"
        Me.SHOWDataGridViewTextBoxColumn.Width = 43
        '
        'ASUB1BindingSource
        '
        Me.ASUB1BindingSource.DataMember = "ASUB1"
        Me.ASUB1BindingSource.DataSource = Me.SignalogDataSet
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
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(231, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Activity SubCategory 1"
        '
        'ASUB2Panel
        '
        Me.ASUB2Panel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ASUB2Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ASUB2Panel.Controls.Add(Me.ASUB2GridView)
        Me.ASUB2Panel.Controls.Add(Me.Label3)
        Me.ASUB2Panel.Location = New System.Drawing.Point(-68, 268)
        Me.ASUB2Panel.Name = "ASUB2Panel"
        Me.ASUB2Panel.Size = New System.Drawing.Size(577, 882)
        Me.ASUB2Panel.TabIndex = 3
        '
        'ASUB2GridView
        '
        Me.ASUB2GridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ASUB2GridView.AutoGenerateColumns = False
        Me.ASUB2GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ASUB2GridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ASUB2GridView.DataSource = Me.ASUB2BindingSource
        Me.ASUB2GridView.Location = New System.Drawing.Point(6, 20)
        Me.ASUB2GridView.Name = "ASUB2GridView"
        Me.ASUB2GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ASUB2GridView.Size = New System.Drawing.Size(563, 199)
        Me.ASUB2GridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "LABEL"
        Me.DataGridViewTextBoxColumn1.HeaderText = "LABEL"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SEQ"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SEQ"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 40
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DESC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "DESC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 160
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "LNKLABEL"
        Me.DataGridViewTextBoxColumn4.HeaderText = "LNKLABEL"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "ACTCODE"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ACTCODE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 60
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SHOW"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SHOW"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 43
        '
        'ASUB2BindingSource
        '
        Me.ASUB2BindingSource.DataMember = "ASUB2"
        Me.ASUB2BindingSource.DataSource = Me.SignalogDataSet
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(231, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Activity SubCategory 2"
        '
        'ASUB3Panel
        '
        Me.ASUB3Panel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ASUB3Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ASUB3Panel.Controls.Add(Me.ASUB3GridView)
        Me.ASUB3Panel.Controls.Add(Me.Label4)
        Me.ASUB3Panel.Location = New System.Drawing.Point(-68, 496)
        Me.ASUB3Panel.Name = "ASUB3Panel"
        Me.ASUB3Panel.Size = New System.Drawing.Size(577, 882)
        Me.ASUB3Panel.TabIndex = 4
        '
        'ASUB3GridView
        '
        Me.ASUB3GridView.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ASUB3GridView.AutoGenerateColumns = False
        Me.ASUB3GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ASUB3GridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.ASUB3GridView.DataSource = Me.ASUB3BindingSource
        Me.ASUB3GridView.Location = New System.Drawing.Point(6, 20)
        Me.ASUB3GridView.Name = "ASUB3GridView"
        Me.ASUB3GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ASUB3GridView.Size = New System.Drawing.Size(563, 199)
        Me.ASUB3GridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "LABEL"
        Me.DataGridViewTextBoxColumn7.HeaderText = "LABEL"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "SEQ"
        Me.DataGridViewTextBoxColumn8.HeaderText = "SEQ"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 40
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DESC"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DESC"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 160
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "LNKLABEL"
        Me.DataGridViewTextBoxColumn10.HeaderText = "LNKLABEL"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ACTCODE"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ACTCODE"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 60
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "SHOW"
        Me.DataGridViewTextBoxColumn12.HeaderText = "SHOW"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 43
        '
        'ASUB3BindingSource
        '
        Me.ASUB3BindingSource.DataMember = "ASUB3"
        Me.ASUB3BindingSource.DataSource = Me.SignalogDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(231, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Activity SubCategory 3"
        '
        'ASUB4Panel
        '
        Me.ASUB4Panel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ASUB4Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ASUB4Panel.Controls.Add(Me.ASUB4GridView)
        Me.ASUB4Panel.Controls.Add(Me.Label5)
        Me.ASUB4Panel.Location = New System.Drawing.Point(-68, 724)
        Me.ASUB4Panel.Name = "ASUB4Panel"
        Me.ASUB4Panel.Size = New System.Drawing.Size(577, 222)
        Me.ASUB4Panel.TabIndex = 5
        '
        'ASUB4GridView
        '
        Me.ASUB4GridView.AutoGenerateColumns = False
        Me.ASUB4GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ASUB4GridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.ASUB4GridView.DataSource = Me.ASUB4BindingSource
        Me.ASUB4GridView.Location = New System.Drawing.Point(6, 20)
        Me.ASUB4GridView.Name = "ASUB4GridView"
        Me.ASUB4GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ASUB4GridView.Size = New System.Drawing.Size(563, 199)
        Me.ASUB4GridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "LABEL"
        Me.DataGridViewTextBoxColumn13.HeaderText = "LABEL"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "SEQ"
        Me.DataGridViewTextBoxColumn14.HeaderText = "SEQ"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 40
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "DESC"
        Me.DataGridViewTextBoxColumn15.HeaderText = "DESC"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 160
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "LNKLABEL"
        Me.DataGridViewTextBoxColumn16.HeaderText = "LNKLABEL"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ACTCODE"
        Me.DataGridViewTextBoxColumn17.HeaderText = "ACTCODE"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 60
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "SHOW"
        Me.DataGridViewTextBoxColumn18.HeaderText = "SHOW"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 43
        '
        'ASUB4BindingSource
        '
        Me.ASUB4BindingSource.DataMember = "ASUB4"
        Me.ASUB4BindingSource.DataSource = Me.SignalogDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(231, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Activity SubCategory 4"
        '
        'ASUB5Panel
        '
        Me.ASUB5Panel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ASUB5Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ASUB5Panel.Controls.Add(Me.ASUB5GridView)
        Me.ASUB5Panel.Controls.Add(Me.Label6)
        Me.ASUB5Panel.Location = New System.Drawing.Point(-68, 952)
        Me.ASUB5Panel.Name = "ASUB5Panel"
        Me.ASUB5Panel.Size = New System.Drawing.Size(577, 222)
        Me.ASUB5Panel.TabIndex = 6
        '
        'ASUB5GridView
        '
        Me.ASUB5GridView.AutoGenerateColumns = False
        Me.ASUB5GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ASUB5GridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.ASUB5GridView.DataSource = Me.ASUB5BindingSource
        Me.ASUB5GridView.Location = New System.Drawing.Point(6, 20)
        Me.ASUB5GridView.Name = "ASUB5GridView"
        Me.ASUB5GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ASUB5GridView.Size = New System.Drawing.Size(563, 199)
        Me.ASUB5GridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "LABEL"
        Me.DataGridViewTextBoxColumn19.HeaderText = "LABEL"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "SEQ"
        Me.DataGridViewTextBoxColumn20.HeaderText = "SEQ"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 40
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "DESC"
        Me.DataGridViewTextBoxColumn21.HeaderText = "DESC"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 160
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "LNKLABEL"
        Me.DataGridViewTextBoxColumn22.HeaderText = "LNKLABEL"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "ACTCODE"
        Me.DataGridViewTextBoxColumn23.HeaderText = "ACTCODE"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 60
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "SHOW"
        Me.DataGridViewTextBoxColumn24.HeaderText = "SHOW"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Width = 43
        '
        'ASUB5BindingSource
        '
        Me.ASUB5BindingSource.DataMember = "ASUB5"
        Me.ASUB5BindingSource.DataSource = Me.SignalogDataSet
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(231, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Activity SubCategory 5"
        '
        'ASUB6Panel
        '
        Me.ASUB6Panel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ASUB6Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ASUB6Panel.Controls.Add(Me.ASUB6GridView)
        Me.ASUB6Panel.Controls.Add(Me.Label7)
        Me.ASUB6Panel.Location = New System.Drawing.Point(-68, 1180)
        Me.ASUB6Panel.Name = "ASUB6Panel"
        Me.ASUB6Panel.Size = New System.Drawing.Size(577, 222)
        Me.ASUB6Panel.TabIndex = 7
        '
        'ASUB6GridView
        '
        Me.ASUB6GridView.AutoGenerateColumns = False
        Me.ASUB6GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ASUB6GridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30})
        Me.ASUB6GridView.DataSource = Me.ASUB6BindingSource
        Me.ASUB6GridView.Location = New System.Drawing.Point(6, 20)
        Me.ASUB6GridView.Name = "ASUB6GridView"
        Me.ASUB6GridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ASUB6GridView.Size = New System.Drawing.Size(563, 199)
        Me.ASUB6GridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "LABEL"
        Me.DataGridViewTextBoxColumn25.HeaderText = "LABEL"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "SEQ"
        Me.DataGridViewTextBoxColumn26.HeaderText = "SEQ"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.Width = 40
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "DESC"
        Me.DataGridViewTextBoxColumn27.HeaderText = "DESC"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 160
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "LNKLABEL"
        Me.DataGridViewTextBoxColumn28.HeaderText = "LNKLABEL"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "ACTCODE"
        Me.DataGridViewTextBoxColumn29.HeaderText = "ACTCODE"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.Width = 60
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "SHOW"
        Me.DataGridViewTextBoxColumn30.HeaderText = "SHOW"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.Width = 43
        '
        'ASUB6BindingSource
        '
        Me.ASUB6BindingSource.DataMember = "ASUB6"
        Me.ASUB6BindingSource.DataSource = Me.SignalogDataSet
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(231, 3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Activity SubCategory 6"
        '
        'Save
        '
        Me.Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Save.Location = New System.Drawing.Point(338, 4)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(85, 23)
        Me.Save.TabIndex = 2
        Me.Save.Text = "Save Changes"
        Me.Save.UseVisualStyleBackColor = True
        '
        'NewActCode
        '
        Me.NewActCode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewActCode.Location = New System.Drawing.Point(273, 6)
        Me.NewActCode.Name = "NewActCode"
        Me.NewActCode.ReadOnly = True
        Me.NewActCode.Size = New System.Drawing.Size(41, 20)
        Me.NewActCode.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(177, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "NEW ACTCODE:"
        '
        'ASUB1TableAdapter
        '
        Me.ASUB1TableAdapter.ClearBeforeFill = True
        '
        'ASUB2TableAdapter
        '
        Me.ASUB2TableAdapter.ClearBeforeFill = True
        '
        'ASUB3TableAdapter
        '
        Me.ASUB3TableAdapter.ClearBeforeFill = True
        '
        'ASUB4TableAdapter
        '
        Me.ASUB4TableAdapter.ClearBeforeFill = True
        '
        'ASUB5TableAdapter
        '
        Me.ASUB5TableAdapter.ClearBeforeFill = True
        '
        'ASUB6TableAdapter
        '
        Me.ASUB6TableAdapter.ClearBeforeFill = True
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
        'ACT1BindingSource
        '
        Me.ACT1BindingSource.DataMember = "ACT1"
        Me.ACT1BindingSource.DataSource = Me.SignalogDataSet
        '
        'ACT1TableAdapter
        '
        Me.ACT1TableAdapter.ClearBeforeFill = True
        '
        'Activity_List_Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(584, 752)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NewActCode)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.ASUB6Panel)
        Me.Controls.Add(Me.ASUB5Panel)
        Me.Controls.Add(Me.ASUB4Panel)
        Me.Controls.Add(Me.ASUB3Panel)
        Me.Controls.Add(Me.ASUB2Panel)
        Me.Controls.Add(Me.ASUB1Panel)
        Me.Controls.Add(Me.ActCat)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(0, 30)
        Me.Name = "Activity_List_Maintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Activity List Maintenance"
        Me.ASUB1Panel.ResumeLayout(False)
        Me.ASUB1Panel.PerformLayout()
        CType(Me.ASUB1GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASUB1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ASUB2Panel.ResumeLayout(False)
        Me.ASUB2Panel.PerformLayout()
        CType(Me.ASUB2GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASUB2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ASUB3Panel.ResumeLayout(False)
        Me.ASUB3Panel.PerformLayout()
        CType(Me.ASUB3GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASUB3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ASUB4Panel.ResumeLayout(False)
        Me.ASUB4Panel.PerformLayout()
        CType(Me.ASUB4GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASUB4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ASUB5Panel.ResumeLayout(False)
        Me.ASUB5Panel.PerformLayout()
        CType(Me.ASUB5GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASUB5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ASUB6Panel.ResumeLayout(False)
        Me.ASUB6Panel.PerformLayout()
        CType(Me.ASUB6GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASUB6BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASUBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ActCat As System.Windows.Forms.ComboBox
    Friend WithEvents ASUB1Panel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ASUB1GridView As System.Windows.Forms.DataGridView
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents ASUB1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUB1TableAdapter As Signalog.SignalogDataSetTableAdapters.ASUB1TableAdapter
    Friend WithEvents LABELDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SEQDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DESCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LNKLABELDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACTCODEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SHOWDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ASUB2Panel As System.Windows.Forms.Panel
    Friend WithEvents ASUB2GridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ASUB2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUB2TableAdapter As Signalog.SignalogDataSetTableAdapters.ASUB2TableAdapter
    Friend WithEvents ASUB3Panel As System.Windows.Forms.Panel
    Friend WithEvents ASUB3GridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ASUB3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUB3TableAdapter As Signalog.SignalogDataSetTableAdapters.ASUB3TableAdapter
    Friend WithEvents ASUB4Panel As System.Windows.Forms.Panel
    Friend WithEvents ASUB4GridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ASUB4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUB4TableAdapter As Signalog.SignalogDataSetTableAdapters.ASUB4TableAdapter
    Friend WithEvents ASUB5Panel As System.Windows.Forms.Panel
    Friend WithEvents ASUB5GridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ASUB5BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUB5TableAdapter As Signalog.SignalogDataSetTableAdapters.ASUB5TableAdapter
    Friend WithEvents ASUB6Panel As System.Windows.Forms.Panel
    Friend WithEvents ASUB6GridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn25 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ASUB6BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUB6TableAdapter As Signalog.SignalogDataSetTableAdapters.ASUB6TableAdapter
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents NewActCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ASUBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUBTableAdapter As Signalog.SignalogDataSetTableAdapters.ASUBTableAdapter
    Friend WithEvents ACT1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT1TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT1TableAdapter
    Friend WithEvents CachedField_Maintenance_Activity1 As Signalog.CachedField_Maintenance_Activity
End Class
