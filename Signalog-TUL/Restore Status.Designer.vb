<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restore_Status
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Restore_Status))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Desc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Serial = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Source = New System.Windows.Forms.TextBox()
        Me.Area = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CStatus = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Status = New System.Windows.Forms.ComboBox()
        Me.PartsStatusTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.Parts_Status_TypeTableAdapter = New Signalog.SignalogDataSetTableAdapters.Parts_Status_TypeTableAdapter()
        Me.UpdateStatus = New System.Windows.Forms.Button()
        Me.EQUIPMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPMENTTableAdapter = New Signalog.SignalogDataSetTableAdapters.EQUIPMENTTableAdapter()
        Me.EQUIPMENT2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPMENT2TableAdapter = New Signalog.SignalogDataSetTableAdapters.EQUIPMENT2TableAdapter()
        Me.ACT3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT3TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT3TableAdapter()
        Me.CUS0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CUS0TableAdapter = New Signalog.SignalogDataSetTableAdapters.CUS0TableAdapter()
        CType(Me.PartsStatusTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENT2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUS0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Part Description:"
        '
        'Desc
        '
        Me.Desc.Location = New System.Drawing.Point(94, 6)
        Me.Desc.Name = "Desc"
        Me.Desc.ReadOnly = True
        Me.Desc.Size = New System.Drawing.Size(160, 20)
        Me.Desc.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Serial Number:"
        '
        'Serial
        '
        Me.Serial.Location = New System.Drawing.Point(94, 38)
        Me.Serial.Name = "Serial"
        Me.Serial.ReadOnly = True
        Me.Serial.Size = New System.Drawing.Size(160, 20)
        Me.Serial.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Part Source:"
        '
        'Source
        '
        Me.Source.Location = New System.Drawing.Point(94, 70)
        Me.Source.Name = "Source"
        Me.Source.ReadOnly = True
        Me.Source.Size = New System.Drawing.Size(80, 20)
        Me.Source.TabIndex = 5
        '
        'Area
        '
        Me.Area.Location = New System.Drawing.Point(180, 70)
        Me.Area.Name = "Area"
        Me.Area.ReadOnly = True
        Me.Area.Size = New System.Drawing.Size(120, 20)
        Me.Area.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Current Status:"
        '
        'CStatus
        '
        Me.CStatus.Location = New System.Drawing.Point(94, 102)
        Me.CStatus.Name = "CStatus"
        Me.CStatus.ReadOnly = True
        Me.CStatus.Size = New System.Drawing.Size(160, 20)
        Me.CStatus.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Update Status:"
        '
        'Status
        '
        Me.Status.DataSource = Me.PartsStatusTypeBindingSource
        Me.Status.DisplayMember = "Status Type"
        Me.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Status.FormattingEnabled = True
        Me.Status.Location = New System.Drawing.Point(94, 134)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(158, 21)
        Me.Status.TabIndex = 17
        Me.Status.ValueMember = "Status Type"
        '
        'PartsStatusTypeBindingSource
        '
        Me.PartsStatusTypeBindingSource.DataMember = "Parts Status Type"
        Me.PartsStatusTypeBindingSource.DataSource = Me.SignalogDataSet
        '
        'SignalogDataSet
        '
        Me.SignalogDataSet.DataSetName = "SignalogDataSet"
        Me.SignalogDataSet.EnforceConstraints = False
        Me.SignalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Parts_Status_TypeTableAdapter
        '
        Me.Parts_Status_TypeTableAdapter.ClearBeforeFill = True
        '
        'UpdateStatus
        '
        Me.UpdateStatus.Location = New System.Drawing.Point(122, 166)
        Me.UpdateStatus.Name = "UpdateStatus"
        Me.UpdateStatus.Size = New System.Drawing.Size(75, 23)
        Me.UpdateStatus.TabIndex = 18
        Me.UpdateStatus.Text = "Update"
        Me.UpdateStatus.UseVisualStyleBackColor = True
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
        'ACT3BindingSource
        '
        Me.ACT3BindingSource.DataMember = "ACT3"
        Me.ACT3BindingSource.DataSource = Me.SignalogDataSet
        '
        'ACT3TableAdapter
        '
        Me.ACT3TableAdapter.ClearBeforeFill = True
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
        'Restore_Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 201)
        Me.Controls.Add(Me.UpdateStatus)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Area)
        Me.Controls.Add(Me.Source)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Serial)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Desc)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Restore_Status"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restore Status"
        CType(Me.PartsStatusTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENT2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUS0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Desc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Serial As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Source As System.Windows.Forms.TextBox
    Friend WithEvents Area As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Status As System.Windows.Forms.ComboBox
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents PartsStatusTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Parts_Status_TypeTableAdapter As Signalog.SignalogDataSetTableAdapters.Parts_Status_TypeTableAdapter
    Friend WithEvents UpdateStatus As System.Windows.Forms.Button
    Friend WithEvents EQUIPMENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENTTableAdapter As Signalog.SignalogDataSetTableAdapters.EQUIPMENTTableAdapter
    Friend WithEvents EQUIPMENT2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENT2TableAdapter As Signalog.SignalogDataSetTableAdapters.EQUIPMENT2TableAdapter
    Friend WithEvents ACT3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT3TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT3TableAdapter
    Friend WithEvents CUS0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUS0TableAdapter As Signalog.SignalogDataSetTableAdapters.CUS0TableAdapter
End Class
