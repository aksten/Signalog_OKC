<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Parts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Parts))
        Me.Part = New System.Windows.Forms.ComboBox()
        Me.PartBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.Serial = New System.Windows.Forms.ComboBox()
        Me.SerialBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Filter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CityOwned = New System.Windows.Forms.RadioButton()
        Me.Local = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Area = New System.Windows.Forms.ComboBox()
        Me.CUS0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PartTableAdapter = New Signalog.SignalogDataSetTableAdapters.PartTableAdapter()
        Me.SerialTableAdapter = New Signalog.SignalogDataSetTableAdapters.SerialTableAdapter()
        Me.EQUIPMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPMENTTableAdapter = New Signalog.SignalogDataSetTableAdapters.EQUIPMENTTableAdapter()
        Me.CUS0TableAdapter = New Signalog.SignalogDataSetTableAdapters.CUS0TableAdapter()
        Me.Part2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Part2TableAdapter = New Signalog.SignalogDataSetTableAdapters.Part2TableAdapter()
        Me.Serial2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Serial2TableAdapter = New Signalog.SignalogDataSetTableAdapters.Serial2TableAdapter()
        Me.EQUIPMENT2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPMENT2TableAdapter = New Signalog.SignalogDataSetTableAdapters.EQUIPMENT2TableAdapter()
        Me.Quantlbl = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.Memolbl = New System.Windows.Forms.Label()
        Me.Memo = New System.Windows.Forms.TextBox()
        Me.Costlbl = New System.Windows.Forms.Label()
        Me.Cost = New System.Windows.Forms.TextBox()
        Me.ACT3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT3TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT3TableAdapter()
        Me.PartsStatusTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Parts_Status_TypeTableAdapter = New Signalog.SignalogDataSetTableAdapters.Parts_Status_TypeTableAdapter()
        Me.StockControlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockControlTableAdapter = New Signalog.SignalogDataSetTableAdapters.StockControlTableAdapter()
        Me.WareHouselbl = New System.Windows.Forms.Label()
        Me.WareHouse = New System.Windows.Forms.ComboBox()
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SerialBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUS0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Part2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Serial2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENT2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartsStatusTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockControlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Part
        '
        Me.Part.DataSource = Me.PartBindingSource
        Me.Part.DisplayMember = "PartDesc"
        Me.Part.DropDownWidth = 350
        Me.Part.FormattingEnabled = True
        Me.Part.Location = New System.Drawing.Point(12, 66)
        Me.Part.Name = "Part"
        Me.Part.Size = New System.Drawing.Size(200, 21)
        Me.Part.TabIndex = 0
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
        'Serial
        '
        Me.Serial.DataSource = Me.SerialBindingSource
        Me.Serial.DisplayMember = "Serial"
        Me.Serial.FormattingEnabled = True
        Me.Serial.Location = New System.Drawing.Point(218, 66)
        Me.Serial.MaxLength = 35
        Me.Serial.Name = "Serial"
        Me.Serial.Size = New System.Drawing.Size(160, 21)
        Me.Serial.TabIndex = 1
        Me.Serial.ValueMember = "Serial"
        '
        'SerialBindingSource
        '
        Me.SerialBindingSource.DataMember = "Serial"
        Me.SerialBindingSource.DataSource = Me.SignalogDataSet
        '
        'Filter
        '
        Me.Filter.Location = New System.Drawing.Point(384, 66)
        Me.Filter.MaxLength = 3
        Me.Filter.Name = "Filter"
        Me.Filter.Size = New System.Drawing.Size(30, 20)
        Me.Filter.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Part Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Serial Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(337, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Filter ( Last 3 Digits )"
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(366, 192)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 6
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Status
        '
        Me.Status.FormattingEnabled = True
        Me.Status.Items.AddRange(New Object() {"In Inventory", "Out for repair", "Not Repairable-Out of service"})
        Me.Status.Location = New System.Drawing.Point(123, 194)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(155, 21)
        Me.Status.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Removed part status:"
        '
        'CityOwned
        '
        Me.CityOwned.AutoSize = True
        Me.CityOwned.Location = New System.Drawing.Point(69, 12)
        Me.CityOwned.Name = "CityOwned"
        Me.CityOwned.Size = New System.Drawing.Size(86, 19)
        Me.CityOwned.TabIndex = 29
        Me.CityOwned.TabStop = True
        Me.CityOwned.Text = "City Owned"
        Me.CityOwned.UseVisualStyleBackColor = True
        '
        'Local
        '
        Me.Local.AutoSize = True
        Me.Local.Location = New System.Drawing.Point(12, 12)
        Me.Local.Name = "Local"
        Me.Local.Size = New System.Drawing.Size(55, 19)
        Me.Local.TabIndex = 28
        Me.Local.TabStop = True
        Me.Local.Text = "Local"
        Me.Local.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(241, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 15)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Area:"
        '
        'Area
        '
        Me.Area.DataSource = Me.CUS0BindingSource
        Me.Area.DisplayMember = "AREANAME"
        Me.Area.FormattingEnabled = True
        Me.Area.Location = New System.Drawing.Point(283, 11)
        Me.Area.Name = "Area"
        Me.Area.Size = New System.Drawing.Size(158, 21)
        Me.Area.TabIndex = 33
        Me.Area.ValueMember = "AREANAME"
        '
        'CUS0BindingSource
        '
        Me.CUS0BindingSource.DataMember = "CUS0"
        Me.CUS0BindingSource.DataSource = Me.SignalogDataSet
        '
        'PartTableAdapter
        '
        Me.PartTableAdapter.ClearBeforeFill = True
        '
        'SerialTableAdapter
        '
        Me.SerialTableAdapter.ClearBeforeFill = True
        '
        'EQUIPMENTTableAdapter
        '
        Me.EQUIPMENTTableAdapter.ClearBeforeFill = True
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
        'Quantlbl
        '
        Me.Quantlbl.AutoSize = True
        Me.Quantlbl.Location = New System.Drawing.Point(9, 105)
        Me.Quantlbl.Name = "Quantlbl"
        Me.Quantlbl.Size = New System.Drawing.Size(54, 15)
        Me.Quantlbl.TabIndex = 34
        Me.Quantlbl.Text = "Quantity:"
        '
        'Quantity
        '
        Me.Quantity.Location = New System.Drawing.Point(64, 102)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(35, 20)
        Me.Quantity.TabIndex = 35
        '
        'Memolbl
        '
        Me.Memolbl.AutoSize = True
        Me.Memolbl.Location = New System.Drawing.Point(9, 139)
        Me.Memolbl.Name = "Memolbl"
        Me.Memolbl.Size = New System.Drawing.Size(46, 15)
        Me.Memolbl.TabIndex = 36
        Me.Memolbl.Text = "Memo:"
        '
        'Memo
        '
        Me.Memo.Location = New System.Drawing.Point(64, 136)
        Me.Memo.Multiline = True
        Me.Memo.Name = "Memo"
        Me.Memo.Size = New System.Drawing.Size(377, 50)
        Me.Memo.TabIndex = 37
        '
        'Costlbl
        '
        Me.Costlbl.AutoSize = True
        Me.Costlbl.Location = New System.Drawing.Point(129, 105)
        Me.Costlbl.Name = "Costlbl"
        Me.Costlbl.Size = New System.Drawing.Size(63, 15)
        Me.Costlbl.TabIndex = 38
        Me.Costlbl.Text = "Unit Price:"
        '
        'Cost
        '
        Me.Cost.Location = New System.Drawing.Point(190, 102)
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(50, 20)
        Me.Cost.TabIndex = 39
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
        'PartsStatusTypeBindingSource
        '
        Me.PartsStatusTypeBindingSource.DataMember = "Parts Status Type"
        Me.PartsStatusTypeBindingSource.DataSource = Me.SignalogDataSet
        '
        'Parts_Status_TypeTableAdapter
        '
        Me.Parts_Status_TypeTableAdapter.ClearBeforeFill = True
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
        'WareHouselbl
        '
        Me.WareHouselbl.AutoSize = True
        Me.WareHouselbl.Location = New System.Drawing.Point(205, 14)
        Me.WareHouselbl.Name = "WareHouselbl"
        Me.WareHouselbl.Size = New System.Drawing.Size(75, 15)
        Me.WareHouselbl.TabIndex = 40
        Me.WareHouselbl.Text = "WareHouse:"
        '
        'WareHouse
        '
        Me.WareHouse.FormattingEnabled = True
        Me.WareHouse.Items.AddRange(New Object() {"TUL", "OKC", "ARK"})
        Me.WareHouse.Location = New System.Drawing.Point(283, 11)
        Me.WareHouse.Name = "WareHouse"
        Me.WareHouse.Size = New System.Drawing.Size(158, 21)
        Me.WareHouse.TabIndex = 41
        '
        'Parts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 222)
        Me.Controls.Add(Me.WareHouse)
        Me.Controls.Add(Me.WareHouselbl)
        Me.Controls.Add(Me.Cost)
        Me.Controls.Add(Me.Costlbl)
        Me.Controls.Add(Me.Memo)
        Me.Controls.Add(Me.Memolbl)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.Quantlbl)
        Me.Controls.Add(Me.Area)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CityOwned)
        Me.Controls.Add(Me.Local)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Filter)
        Me.Controls.Add(Me.Serial)
        Me.Controls.Add(Me.Part)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Parts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parts"
        CType(Me.PartBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SerialBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUS0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Part2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Serial2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENT2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartsStatusTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockControlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Part As System.Windows.Forms.ComboBox
    Friend WithEvents Serial As System.Windows.Forms.ComboBox
    Friend WithEvents Filter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents PartBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PartTableAdapter As Signalog.SignalogDataSetTableAdapters.PartTableAdapter
    Friend WithEvents SerialBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SerialTableAdapter As Signalog.SignalogDataSetTableAdapters.SerialTableAdapter
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents EQUIPMENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENTTableAdapter As Signalog.SignalogDataSetTableAdapters.EQUIPMENTTableAdapter
    Friend WithEvents Status As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CityOwned As System.Windows.Forms.RadioButton
    Friend WithEvents Local As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Area As System.Windows.Forms.ComboBox
    Friend WithEvents CUS0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUS0TableAdapter As Signalog.SignalogDataSetTableAdapters.CUS0TableAdapter
    Friend WithEvents Part2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Part2TableAdapter As Signalog.SignalogDataSetTableAdapters.Part2TableAdapter
    Friend WithEvents Serial2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Serial2TableAdapter As Signalog.SignalogDataSetTableAdapters.Serial2TableAdapter
    Friend WithEvents EQUIPMENT2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENT2TableAdapter As Signalog.SignalogDataSetTableAdapters.EQUIPMENT2TableAdapter
    Friend WithEvents Quantlbl As System.Windows.Forms.Label
    Friend WithEvents Quantity As System.Windows.Forms.TextBox
    Friend WithEvents Memolbl As System.Windows.Forms.Label
    Friend WithEvents Memo As System.Windows.Forms.TextBox
    Friend WithEvents Costlbl As System.Windows.Forms.Label
    Friend WithEvents Cost As System.Windows.Forms.TextBox
    Friend WithEvents ACT3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT3TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT3TableAdapter
    Friend WithEvents PartsStatusTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Parts_Status_TypeTableAdapter As Signalog.SignalogDataSetTableAdapters.Parts_Status_TypeTableAdapter
    Friend WithEvents StockControlBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockControlTableAdapter As Signalog.SignalogDataSetTableAdapters.StockControlTableAdapter
    Friend WithEvents WareHouselbl As System.Windows.Forms.Label
    Friend WithEvents WareHouse As System.Windows.Forms.ComboBox
End Class
