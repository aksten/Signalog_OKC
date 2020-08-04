<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Departing_Condition_Notes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Departing_Condition_Notes))
        Me.Submit = New System.Windows.Forms.Button()
        Me.SUB6 = New System.Windows.Forms.ComboBox()
        Me.ASUB6BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.SUB5 = New System.Windows.Forms.ComboBox()
        Me.ASUB5BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUB4 = New System.Windows.Forms.ComboBox()
        Me.ASUB4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUB3 = New System.Windows.Forms.ComboBox()
        Me.ASUB3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUB2 = New System.Windows.Forms.ComboBox()
        Me.ASUB2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SUB1 = New System.Windows.Forms.ComboBox()
        Me.ASUB1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASUBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ASUBTableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUBTableAdapter()
        Me.ASUB1TableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUB1TableAdapter()
        Me.ASUB2TableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUB2TableAdapter()
        Me.ASUB3TableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUB3TableAdapter()
        Me.ASUB4TableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUB4TableAdapter()
        Me.ASUB5TableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUB5TableAdapter()
        Me.ASUB6TableAdapter = New Signalog.SignalogDataSetTableAdapters.ASUB6TableAdapter()
        Me.MemoBox = New System.Windows.Forms.TextBox()
        CType(Me.ASUB6BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASUB5BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASUB4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASUB3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASUB2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASUB1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ASUBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Submit
        '
        Me.Submit.Location = New System.Drawing.Point(73, 356)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(80, 23)
        Me.Submit.TabIndex = 27
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'SUB6
        '
        Me.SUB6.DataSource = Me.ASUB6BindingSource
        Me.SUB6.DisplayMember = "DESC"
        Me.SUB6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SUB6.FormattingEnabled = True
        Me.SUB6.Location = New System.Drawing.Point(12, 221)
        Me.SUB6.Name = "SUB6"
        Me.SUB6.Size = New System.Drawing.Size(200, 21)
        Me.SUB6.TabIndex = 26
        Me.SUB6.ValueMember = "DESC"
        '
        'ASUB6BindingSource
        '
        Me.ASUB6BindingSource.DataMember = "ASUB6"
        Me.ASUB6BindingSource.DataSource = Me.SignalogDataSet
        '
        'SignalogDataSet
        '
        Me.SignalogDataSet.DataSetName = "SignalogDataSet"
        Me.SignalogDataSet.EnforceConstraints = False
        Me.SignalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SUB5
        '
        Me.SUB5.DataSource = Me.ASUB5BindingSource
        Me.SUB5.DisplayMember = "DESC"
        Me.SUB5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SUB5.FormattingEnabled = True
        Me.SUB5.Location = New System.Drawing.Point(12, 181)
        Me.SUB5.Name = "SUB5"
        Me.SUB5.Size = New System.Drawing.Size(200, 21)
        Me.SUB5.TabIndex = 25
        Me.SUB5.ValueMember = "DESC"
        '
        'ASUB5BindingSource
        '
        Me.ASUB5BindingSource.DataMember = "ASUB5"
        Me.ASUB5BindingSource.DataSource = Me.SignalogDataSet
        '
        'SUB4
        '
        Me.SUB4.DataSource = Me.ASUB4BindingSource
        Me.SUB4.DisplayMember = "DESC"
        Me.SUB4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SUB4.FormattingEnabled = True
        Me.SUB4.Location = New System.Drawing.Point(12, 141)
        Me.SUB4.Name = "SUB4"
        Me.SUB4.Size = New System.Drawing.Size(200, 21)
        Me.SUB4.TabIndex = 24
        Me.SUB4.ValueMember = "DESC"
        '
        'ASUB4BindingSource
        '
        Me.ASUB4BindingSource.DataMember = "ASUB4"
        Me.ASUB4BindingSource.DataSource = Me.SignalogDataSet
        '
        'SUB3
        '
        Me.SUB3.DataSource = Me.ASUB3BindingSource
        Me.SUB3.DisplayMember = "DESC"
        Me.SUB3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SUB3.FormattingEnabled = True
        Me.SUB3.Location = New System.Drawing.Point(12, 101)
        Me.SUB3.Name = "SUB3"
        Me.SUB3.Size = New System.Drawing.Size(200, 21)
        Me.SUB3.TabIndex = 23
        Me.SUB3.ValueMember = "DESC"
        '
        'ASUB3BindingSource
        '
        Me.ASUB3BindingSource.DataMember = "ASUB3"
        Me.ASUB3BindingSource.DataSource = Me.SignalogDataSet
        '
        'SUB2
        '
        Me.SUB2.DataSource = Me.ASUB2BindingSource
        Me.SUB2.DisplayMember = "DESC"
        Me.SUB2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SUB2.FormattingEnabled = True
        Me.SUB2.Location = New System.Drawing.Point(12, 61)
        Me.SUB2.Name = "SUB2"
        Me.SUB2.Size = New System.Drawing.Size(200, 21)
        Me.SUB2.TabIndex = 22
        Me.SUB2.ValueMember = "DESC"
        '
        'ASUB2BindingSource
        '
        Me.ASUB2BindingSource.DataMember = "ASUB2"
        Me.ASUB2BindingSource.DataSource = Me.SignalogDataSet
        '
        'SUB1
        '
        Me.SUB1.DataSource = Me.ASUB1BindingSource
        Me.SUB1.DisplayMember = "DESC"
        Me.SUB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SUB1.FormattingEnabled = True
        Me.SUB1.Location = New System.Drawing.Point(12, 21)
        Me.SUB1.Name = "SUB1"
        Me.SUB1.Size = New System.Drawing.Size(200, 21)
        Me.SUB1.TabIndex = 21
        Me.SUB1.ValueMember = "DESC"
        '
        'ASUB1BindingSource
        '
        Me.ASUB1BindingSource.DataMember = "ASUB1"
        Me.ASUB1BindingSource.DataSource = Me.SignalogDataSet
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
        'MemoBox
        '
        Me.MemoBox.Location = New System.Drawing.Point(12, 261)
        Me.MemoBox.Multiline = True
        Me.MemoBox.Name = "MemoBox"
        Me.MemoBox.Size = New System.Drawing.Size(200, 80)
        Me.MemoBox.TabIndex = 28
        '
        'Departing_Condition_Notes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(227, 391)
        Me.Controls.Add(Me.MemoBox)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.SUB6)
        Me.Controls.Add(Me.SUB5)
        Me.Controls.Add(Me.SUB4)
        Me.Controls.Add(Me.SUB3)
        Me.Controls.Add(Me.SUB2)
        Me.Controls.Add(Me.SUB1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Departing_Condition_Notes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dept Cond Notes"
        CType(Me.ASUB6BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASUB5BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASUB4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASUB3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASUB2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASUB1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ASUBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents SUB6 As System.Windows.Forms.ComboBox
    Friend WithEvents SUB5 As System.Windows.Forms.ComboBox
    Friend WithEvents SUB4 As System.Windows.Forms.ComboBox
    Friend WithEvents SUB3 As System.Windows.Forms.ComboBox
    Friend WithEvents SUB2 As System.Windows.Forms.ComboBox
    Friend WithEvents SUB1 As System.Windows.Forms.ComboBox
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents ASUBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUBTableAdapter As Signalog.SignalogDataSetTableAdapters.ASUBTableAdapter
    Friend WithEvents ASUB1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUB1TableAdapter As Signalog.SignalogDataSetTableAdapters.ASUB1TableAdapter
    Friend WithEvents ASUB2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUB2TableAdapter As Signalog.SignalogDataSetTableAdapters.ASUB2TableAdapter
    Friend WithEvents ASUB3BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUB3TableAdapter As Signalog.SignalogDataSetTableAdapters.ASUB3TableAdapter
    Friend WithEvents ASUB4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUB4TableAdapter As Signalog.SignalogDataSetTableAdapters.ASUB4TableAdapter
    Friend WithEvents ASUB5BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUB5TableAdapter As Signalog.SignalogDataSetTableAdapters.ASUB5TableAdapter
    Friend WithEvents ASUB6BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ASUB6TableAdapter As Signalog.SignalogDataSetTableAdapters.ASUB6TableAdapter
    Friend WithEvents MemoBox As System.Windows.Forms.TextBox
End Class
