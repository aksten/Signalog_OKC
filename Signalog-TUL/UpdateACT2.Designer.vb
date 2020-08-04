<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateACT2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateACT2))
        Me.Start = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.ACT0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT0TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT0TableAdapter()
        Me.ACT1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT1TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT1TableAdapter()
        Me.ASUBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASUBTableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUBTableAdapter()
        Me.ACT2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT2TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT2TableAdapter()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Statuslbl = New System.Windows.Forms.Label()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASUBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(12, 12)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 62)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(505, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'SignalogDataSet
        '
        Me.SignalogDataSet.DataSetName = "SignalogDataSet"
        Me.SignalogDataSet.EnforceConstraints = False
        Me.SignalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ACT1BindingSource
        '
        Me.ACT1BindingSource.DataMember = "ACT1"
        Me.ACT1BindingSource.DataSource = Me.SignalogDataSet
        '
        'ACT1TableAdapter
        '
        Me.ACT1TableAdapter.ClearBeforeFill = True
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
        'ACT2BindingSource
        '
        Me.ACT2BindingSource.DataMember = "ACT2"
        Me.ACT2BindingSource.DataSource = Me.SignalogDataSet
        '
        'ACT2TableAdapter
        '
        Me.ACT2TableAdapter.ClearBeforeFill = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'Statuslbl
        '
        Me.Statuslbl.AutoSize = True
        Me.Statuslbl.Location = New System.Drawing.Point(12, 42)
        Me.Statuslbl.Name = "Statuslbl"
        Me.Statuslbl.Size = New System.Drawing.Size(45, 15)
        Me.Statuslbl.TabIndex = 3
        Me.Statuslbl.Text = "Label1"
        '
        'UpdateACT2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 97)
        Me.Controls.Add(Me.Statuslbl)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Start)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdateACT2"
        Me.Text = "UpdateACT2"
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASUBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Start As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents ACT0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT0TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT0TableAdapter
    Friend WithEvents ACT1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT1TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT1TableAdapter
    Friend WithEvents ASUBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUBTableAdapter As Signalog.SignalogDataSetTableAdapters.ASUBTableAdapter
    Friend WithEvents ACT2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT2TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT2TableAdapter
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Statuslbl As System.Windows.Forms.Label
End Class
