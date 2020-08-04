<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_Control
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory_Control))
        Me.Part = New System.Windows.Forms.ComboBox()
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PartTableAdapter = New Signalog.SignalogDataSetTableAdapters.PartTableAdapter()
        Me.Add = New System.Windows.Forms.RadioButton()
        Me.Remove = New System.Windows.Forms.RadioButton()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Note = New System.Windows.Forms.ComboBox()
        Me.Notelbl = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.InputPanel = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StockControlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockControlTableAdapter = New Signalog.SignalogDataSetTableAdapters.StockControlTableAdapter()
        Me.EQUIPMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPMENTTableAdapter = New Signalog.SignalogDataSetTableAdapters.EQUIPMENTTableAdapter()
        Me.StockContView = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PartDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTNUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WareHouse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActionTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Filter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FromDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToDate = New System.Windows.Forms.DateTimePicker()
        Me.PartFilter = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ACTNUM = New System.Windows.Forms.TextBox()
        Me.DateAll = New System.Windows.Forms.CheckBox()
        Me.ActAll = New System.Windows.Forms.CheckBox()
        Me.PartAll = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.WareHouseFilter = New System.Windows.Forms.ComboBox()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InputPanel.SuspendLayout()
        CType(Me.StockControlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockContView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Part
        '
        Me.Part.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Part.DataSource = Me.PartBindingSource
        Me.Part.DisplayMember = "PartDesc"
        Me.Part.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Part.FormattingEnabled = True
        Me.Part.Location = New System.Drawing.Point(124, 47)
        Me.Part.Name = "Part"
        Me.Part.Size = New System.Drawing.Size(318, 21)
        Me.Part.TabIndex = 2
        Me.Part.ValueMember = "PartDesc"
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
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Part Description"
        '
        'PartTableAdapter
        '
        Me.PartTableAdapter.ClearBeforeFill = True
        '
        'Add
        '
        Me.Add.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Add.AutoSize = True
        Me.Add.Location = New System.Drawing.Point(3, 48)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(46, 19)
        Me.Add.TabIndex = 0
        Me.Add.TabStop = True
        Me.Add.Text = "Add"
        Me.Add.UseVisualStyleBackColor = True
        '
        'Remove
        '
        Me.Remove.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Remove.AutoSize = True
        Me.Remove.Location = New System.Drawing.Point(53, 48)
        Me.Remove.Name = "Remove"
        Me.Remove.Size = New System.Drawing.Size(71, 19)
        Me.Remove.TabIndex = 1
        Me.Remove.TabStop = True
        Me.Remove.Text = "Remove"
        Me.Remove.UseVisualStyleBackColor = True
        '
        'Quantity
        '
        Me.Quantity.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Quantity.Location = New System.Drawing.Point(464, 47)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(50, 20)
        Me.Quantity.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(461, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Quantity"
        '
        'Note
        '
        Me.Note.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Note.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Note.FormattingEnabled = True
        Me.Note.Location = New System.Drawing.Point(542, 46)
        Me.Note.Name = "Note"
        Me.Note.Size = New System.Drawing.Size(158, 21)
        Me.Note.TabIndex = 4
        '
        'Notelbl
        '
        Me.Notelbl.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Notelbl.AutoSize = True
        Me.Notelbl.Location = New System.Drawing.Point(539, 26)
        Me.Notelbl.Name = "Notelbl"
        Me.Notelbl.Size = New System.Drawing.Size(33, 15)
        Me.Notelbl.TabIndex = 7
        Me.Notelbl.Text = "Note"
        '
        'Submit
        '
        Me.Submit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Submit.Location = New System.Drawing.Point(706, 45)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 5
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'InputPanel
        '
        Me.InputPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.InputPanel.Controls.Add(Me.Label7)
        Me.InputPanel.Controls.Add(Me.Add)
        Me.InputPanel.Controls.Add(Me.Submit)
        Me.InputPanel.Controls.Add(Me.Part)
        Me.InputPanel.Controls.Add(Me.Notelbl)
        Me.InputPanel.Controls.Add(Me.Label1)
        Me.InputPanel.Controls.Add(Me.Note)
        Me.InputPanel.Controls.Add(Me.Remove)
        Me.InputPanel.Controls.Add(Me.Label2)
        Me.InputPanel.Controls.Add(Me.Quantity)
        Me.InputPanel.Location = New System.Drawing.Point(0, 31)
        Me.InputPanel.Name = "InputPanel"
        Me.InputPanel.Size = New System.Drawing.Size(794, 75)
        Me.InputPanel.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(343, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 15)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Modify Item's Quantity"
        '
        'StockControlBindingSource
        '
        Me.StockControlBindingSource.DataMember = "StockControl"
        Me.StockControlBindingSource.DataSource = Me.SignalogDataSet
        '
        'StockControlTableAdapter
        '
        Me.StockControlTableAdapter.ClearBeforeFill = True
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
        'StockContView
        '
        Me.StockContView.AllowUserToAddRows = False
        Me.StockContView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StockContView.AutoGenerateColumns = False
        Me.StockContView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StockContView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StockContView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn, Me.PartIDDataGridViewTextBoxColumn, Me.PartDesc, Me.ACTNUMDataGridViewTextBoxColumn, Me.WareHouse, Me.ActionTypeDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn})
        Me.StockContView.DataSource = Me.StockControlBindingSource
        Me.StockContView.Location = New System.Drawing.Point(4, 187)
        Me.StockContView.Name = "StockContView"
        Me.StockContView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.StockContView.Size = New System.Drawing.Size(785, 292)
        Me.StockContView.TabIndex = 14
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.FillWeight = 70.86613!
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.FillWeight = 84.72213!
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        '
        'PartIDDataGridViewTextBoxColumn
        '
        Me.PartIDDataGridViewTextBoxColumn.DataPropertyName = "PartID"
        Me.PartIDDataGridViewTextBoxColumn.FillWeight = 61.06732!
        Me.PartIDDataGridViewTextBoxColumn.HeaderText = "PartID"
        Me.PartIDDataGridViewTextBoxColumn.Name = "PartIDDataGridViewTextBoxColumn"
        Me.PartIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PartDesc
        '
        Me.PartDesc.DataPropertyName = "PartDesc"
        Me.PartDesc.FillWeight = 252.6839!
        Me.PartDesc.HeaderText = "PartDesc"
        Me.PartDesc.Name = "PartDesc"
        Me.PartDesc.ReadOnly = True
        '
        'ACTNUMDataGridViewTextBoxColumn
        '
        Me.ACTNUMDataGridViewTextBoxColumn.DataPropertyName = "ACTNUM"
        Me.ACTNUMDataGridViewTextBoxColumn.FillWeight = 63.24164!
        Me.ACTNUMDataGridViewTextBoxColumn.HeaderText = "ACTNUM"
        Me.ACTNUMDataGridViewTextBoxColumn.Name = "ACTNUMDataGridViewTextBoxColumn"
        Me.ACTNUMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WareHouse
        '
        Me.WareHouse.DataPropertyName = "WareHouse"
        Me.WareHouse.FillWeight = 76.52728!
        Me.WareHouse.HeaderText = "WareHouse"
        Me.WareHouse.Name = "WareHouse"
        Me.WareHouse.ReadOnly = True
        '
        'ActionTypeDataGridViewTextBoxColumn
        '
        Me.ActionTypeDataGridViewTextBoxColumn.DataPropertyName = "ActionType"
        Me.ActionTypeDataGridViewTextBoxColumn.FillWeight = 78.0522!
        Me.ActionTypeDataGridViewTextBoxColumn.HeaderText = "ActionType"
        Me.ActionTypeDataGridViewTextBoxColumn.Name = "ActionTypeDataGridViewTextBoxColumn"
        Me.ActionTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.FillWeight = 56.74074!
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "Note"
        Me.NoteDataGridViewTextBoxColumn.FillWeight = 156.0987!
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "Note"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        Me.NoteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Filter
        '
        Me.Filter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Filter.Location = New System.Drawing.Point(707, 131)
        Me.Filter.Name = "Filter"
        Me.Filter.Size = New System.Drawing.Size(75, 23)
        Me.Filter.TabIndex = 13
        Me.Filter.Text = "Filter"
        Me.Filter.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "From:"
        '
        'FromDate
        '
        Me.FromDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FromDate.Location = New System.Drawing.Point(40, 132)
        Me.FromDate.Name = "FromDate"
        Me.FromDate.Size = New System.Drawing.Size(89, 20)
        Me.FromDate.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(145, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "To:"
        '
        'ToDate
        '
        Me.ToDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ToDate.Location = New System.Drawing.Point(174, 132)
        Me.ToDate.Name = "ToDate"
        Me.ToDate.Size = New System.Drawing.Size(89, 20)
        Me.ToDate.TabIndex = 7
        '
        'PartFilter
        '
        Me.PartFilter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PartFilter.DataSource = Me.PartBindingSource
        Me.PartFilter.DisplayMember = "PartDesc"
        Me.PartFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.PartFilter.FormattingEnabled = True
        Me.PartFilter.Location = New System.Drawing.Point(40, 160)
        Me.PartFilter.Name = "PartFilter"
        Me.PartFilter.Size = New System.Drawing.Size(318, 21)
        Me.PartFilter.TabIndex = 11
        Me.PartFilter.ValueMember = "PartDesc"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Part:"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(320, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Activity Number:"
        '
        'ACTNUM
        '
        Me.ACTNUM.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ACTNUM.Location = New System.Drawing.Point(406, 133)
        Me.ACTNUM.Name = "ACTNUM"
        Me.ACTNUM.Size = New System.Drawing.Size(100, 20)
        Me.ACTNUM.TabIndex = 9
        '
        'DateAll
        '
        Me.DateAll.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateAll.AutoSize = True
        Me.DateAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.DateAll.Location = New System.Drawing.Point(269, 135)
        Me.DateAll.Name = "DateAll"
        Me.DateAll.Size = New System.Drawing.Size(47, 19)
        Me.DateAll.TabIndex = 8
        Me.DateAll.Text = "ALL"
        Me.DateAll.UseVisualStyleBackColor = True
        '
        'ActAll
        '
        Me.ActAll.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ActAll.AutoSize = True
        Me.ActAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ActAll.Location = New System.Drawing.Point(512, 136)
        Me.ActAll.Name = "ActAll"
        Me.ActAll.Size = New System.Drawing.Size(47, 19)
        Me.ActAll.TabIndex = 10
        Me.ActAll.Text = "ALL"
        Me.ActAll.UseVisualStyleBackColor = True
        '
        'PartAll
        '
        Me.PartAll.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PartAll.AutoSize = True
        Me.PartAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PartAll.Location = New System.Drawing.Point(364, 162)
        Me.PartAll.Name = "PartAll"
        Me.PartAll.Size = New System.Drawing.Size(47, 19)
        Me.PartAll.TabIndex = 12
        Me.PartAll.Text = "ALL"
        Me.PartAll.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(380, 109)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 15)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Filtering"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(2, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 15)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "WareHouse:"
        '
        'WareHouseFilter
        '
        Me.WareHouseFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.WareHouseFilter.FormattingEnabled = True
        Me.WareHouseFilter.Items.AddRange(New Object() {"TUL", "OKC", "ARK"})
        Me.WareHouseFilter.Location = New System.Drawing.Point(88, 5)
        Me.WareHouseFilter.Name = "WareHouseFilter"
        Me.WareHouseFilter.Size = New System.Drawing.Size(100, 21)
        Me.WareHouseFilter.TabIndex = 32
        '
        'Inventory_Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 483)
        Me.Controls.Add(Me.WareHouseFilter)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PartAll)
        Me.Controls.Add(Me.ActAll)
        Me.Controls.Add(Me.DateAll)
        Me.Controls.Add(Me.ACTNUM)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PartFilter)
        Me.Controls.Add(Me.ToDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FromDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Filter)
        Me.Controls.Add(Me.StockContView)
        Me.Controls.Add(Me.InputPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inventory_Control"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Control"
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InputPanel.ResumeLayout(False)
        Me.InputPanel.PerformLayout()
        CType(Me.StockControlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockContView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Part As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents PartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartTableAdapter As Signalog.SignalogDataSetTableAdapters.PartTableAdapter
    Friend WithEvents Add As System.Windows.Forms.RadioButton
    Friend WithEvents Remove As System.Windows.Forms.RadioButton
    Friend WithEvents Quantity As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Note As System.Windows.Forms.ComboBox
    Friend WithEvents Notelbl As System.Windows.Forms.Label
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents InputPanel As System.Windows.Forms.Panel
    Friend WithEvents StockControlBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockControlTableAdapter As Signalog.SignalogDataSetTableAdapters.StockControlTableAdapter
    Friend WithEvents EQUIPMENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENTTableAdapter As Signalog.SignalogDataSetTableAdapters.EQUIPMENTTableAdapter
    Friend WithEvents StockContView As System.Windows.Forms.DataGridView
    Friend WithEvents Filter As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PartFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ACTNUM As System.Windows.Forms.TextBox
    Friend WithEvents DateAll As System.Windows.Forms.CheckBox
    Friend WithEvents ActAll As System.Windows.Forms.CheckBox
    Friend WithEvents PartAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents WareHouseFilter As System.Windows.Forms.ComboBox
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PartDesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACTNUMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WareHouse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActionTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
