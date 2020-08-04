<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reindex
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reindex))
        Me.Start = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SelTable = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.CUS0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUS0TableAdapter = New Signalog.SignalogDataSetTableAdapters.CUS0TableAdapter()
        Me.LOCKNEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCKNEWTableAdapter = New Signalog.SignalogDataSetTableAdapters.LOCKNEWTableAdapter()
        Me.EQUIPMENT2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPMENT2TableAdapter = New Signalog.SignalogDataSetTableAdapters.EQUIPMENT2TableAdapter()
        Me.LOC0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOC0TableAdapter = New Signalog.SignalogDataSetTableAdapters.LOC0TableAdapter()
        Me.DISP0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DISP0TableAdapter = New Signalog.SignalogDataSetTableAdapters.DISP0TableAdapter()
        Me.ACT0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT0TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT0TableAdapter()
        Me.EQUIPMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPMENTTableAdapter = New Signalog.SignalogDataSetTableAdapters.EQUIPMENTTableAdapter()
        Me.ACT3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT3TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT3TableAdapter()
        Me.HolidayListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Holiday_ListTableAdapter = New Signalog.SignalogDataSetTableAdapters.Holiday_ListTableAdapter()
        Me.HolidaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HolidaysTableAdapter = New Signalog.SignalogDataSetTableAdapters.HolidaysTableAdapter()
        Me.LOC0BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCKEDITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCKEDITTableAdapter = New Signalog.SignalogDataSetTableAdapters.LOCKEDITTableAdapter()
        Me.LOC1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOC1TableAdapter = New Signalog.SignalogDataSetTableAdapters.LOC1TableAdapter()
        Me.MANFLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MANF_LISTTableAdapter = New Signalog.SignalogDataSetTableAdapters.MANF_LISTTableAdapter()
        Me.PartsListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Parts_ListTableAdapter = New Signalog.SignalogDataSetTableAdapters.Parts_ListTableAdapter()
        Me.PERS0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PERS0TableAdapter = New Signalog.SignalogDataSetTableAdapters.PERS0TableAdapter()
        Me.VEHICLEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VEHICLETableAdapter = New Signalog.SignalogDataSetTableAdapters.VEHICLETableAdapter()
        Me.StockControlBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockControlTableAdapter = New Signalog.SignalogDataSetTableAdapters.StockControlTableAdapter()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUS0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCKNEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENT2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOC0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DISP0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidayListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOC0BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCKEDITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOC1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MANFLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartsListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERS0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VEHICLEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockControlBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(238, 60)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 0
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(11, 89)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(302, 23)
        Me.ProgressBar1.TabIndex = 1
        '
        'SelTable
        '
        Me.SelTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SelTable.FormattingEnabled = True
        Me.SelTable.Items.AddRange(New Object() {"Areas ", "Dispatch By ", "Local Inventory ", "City Owned Inventory", "Holidays List ", "Holidays", "Locations", "Location Type Description", "Manufacturers List", "Parts List", "Employees", "Vehicles List", "Stock Control", "ALL"})
        Me.SelTable.Location = New System.Drawing.Point(11, 60)
        Me.SelTable.Name = "SelTable"
        Me.SelTable.Size = New System.Drawing.Size(212, 21)
        Me.SelTable.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Please select database table and click start"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "To reindex all tables, select ""ALL"""
        '
        'SignalogDataSet
        '
        Me.SignalogDataSet.DataSetName = "SignalogDataSet"
        Me.SignalogDataSet.EnforceConstraints = False
        Me.SignalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'LOCKNEWBindingSource
        '
        Me.LOCKNEWBindingSource.DataMember = "LOCKNEW"
        Me.LOCKNEWBindingSource.DataSource = Me.SignalogDataSet
        '
        'LOCKNEWTableAdapter
        '
        Me.LOCKNEWTableAdapter.ClearBeforeFill = True
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
        'LOC0BindingSource
        '
        Me.LOC0BindingSource.DataMember = "LOC0"
        Me.LOC0BindingSource.DataSource = Me.SignalogDataSet
        '
        'LOC0TableAdapter
        '
        Me.LOC0TableAdapter.ClearBeforeFill = True
        '
        'DISP0BindingSource
        '
        Me.DISP0BindingSource.DataMember = "DISP0"
        Me.DISP0BindingSource.DataSource = Me.SignalogDataSet
        '
        'DISP0TableAdapter
        '
        Me.DISP0TableAdapter.ClearBeforeFill = True
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
        'EQUIPMENTBindingSource
        '
        Me.EQUIPMENTBindingSource.DataMember = "EQUIPMENT"
        Me.EQUIPMENTBindingSource.DataSource = Me.SignalogDataSet
        '
        'EQUIPMENTTableAdapter
        '
        Me.EQUIPMENTTableAdapter.ClearBeforeFill = True
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
        'HolidayListBindingSource
        '
        Me.HolidayListBindingSource.DataMember = "Holiday List"
        Me.HolidayListBindingSource.DataSource = Me.SignalogDataSet
        '
        'Holiday_ListTableAdapter
        '
        Me.Holiday_ListTableAdapter.ClearBeforeFill = True
        '
        'HolidaysBindingSource
        '
        Me.HolidaysBindingSource.DataMember = "Holidays"
        Me.HolidaysBindingSource.DataSource = Me.SignalogDataSet
        '
        'HolidaysTableAdapter
        '
        Me.HolidaysTableAdapter.ClearBeforeFill = True
        '
        'LOC0BindingSource1
        '
        Me.LOC0BindingSource1.DataMember = "LOC0"
        Me.LOC0BindingSource1.DataSource = Me.SignalogDataSet
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
        'LOC1BindingSource
        '
        Me.LOC1BindingSource.DataMember = "LOC1"
        Me.LOC1BindingSource.DataSource = Me.SignalogDataSet
        '
        'LOC1TableAdapter
        '
        Me.LOC1TableAdapter.ClearBeforeFill = True
        '
        'MANFLISTBindingSource
        '
        Me.MANFLISTBindingSource.DataMember = "MANF LIST"
        Me.MANFLISTBindingSource.DataSource = Me.SignalogDataSet
        '
        'MANF_LISTTableAdapter
        '
        Me.MANF_LISTTableAdapter.ClearBeforeFill = True
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
        'PERS0BindingSource
        '
        Me.PERS0BindingSource.DataMember = "PERS0"
        Me.PERS0BindingSource.DataSource = Me.SignalogDataSet
        '
        'PERS0TableAdapter
        '
        Me.PERS0TableAdapter.ClearBeforeFill = True
        '
        'VEHICLEBindingSource
        '
        Me.VEHICLEBindingSource.DataMember = "VEHICLE"
        Me.VEHICLEBindingSource.DataSource = Me.SignalogDataSet
        '
        'VEHICLETableAdapter
        '
        Me.VEHICLETableAdapter.ClearBeforeFill = True
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
        'Reindex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 122)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SelTable)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Start)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Reindex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reindex"
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUS0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCKNEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENT2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOC0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DISP0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidayListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOC0BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCKEDITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOC1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MANFLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartsListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERS0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VEHICLEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockControlBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents SelTable As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents CUS0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUS0TableAdapter As Signalog.SignalogDataSetTableAdapters.CUS0TableAdapter
    Friend WithEvents LOCKNEWBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKNEWTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKNEWTableAdapter
    Friend WithEvents EQUIPMENT2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENT2TableAdapter As Signalog.SignalogDataSetTableAdapters.EQUIPMENT2TableAdapter
    Friend WithEvents LOC0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOC0TableAdapter As Signalog.SignalogDataSetTableAdapters.LOC0TableAdapter
    Friend WithEvents DISP0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DISP0TableAdapter As Signalog.SignalogDataSetTableAdapters.DISP0TableAdapter
    Friend WithEvents ACT0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT0TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT0TableAdapter
    Friend WithEvents EQUIPMENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENTTableAdapter As Signalog.SignalogDataSetTableAdapters.EQUIPMENTTableAdapter
    Friend WithEvents ACT3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT3TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT3TableAdapter
    Friend WithEvents HolidayListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Holiday_ListTableAdapter As Signalog.SignalogDataSetTableAdapters.Holiday_ListTableAdapter
    Friend WithEvents HolidaysBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HolidaysTableAdapter As Signalog.SignalogDataSetTableAdapters.HolidaysTableAdapter
    Friend WithEvents LOC0BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKEDITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKEDITTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKEDITTableAdapter
    Friend WithEvents LOC1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOC1TableAdapter As Signalog.SignalogDataSetTableAdapters.LOC1TableAdapter
    Friend WithEvents MANFLISTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MANF_LISTTableAdapter As Signalog.SignalogDataSetTableAdapters.MANF_LISTTableAdapter
    Friend WithEvents PartsListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Parts_ListTableAdapter As Signalog.SignalogDataSetTableAdapters.Parts_ListTableAdapter
    Friend WithEvents PERS0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PERS0TableAdapter As Signalog.SignalogDataSetTableAdapters.PERS0TableAdapter
    Friend WithEvents VEHICLEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VEHICLETableAdapter As Signalog.SignalogDataSetTableAdapters.VEHICLETableAdapter
    Friend WithEvents StockControlBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockControlTableAdapter As Signalog.SignalogDataSetTableAdapters.StockControlTableAdapter
End Class
