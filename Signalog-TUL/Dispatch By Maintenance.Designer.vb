<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dispatch_By_Maintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dispatch_By_Maintenance))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewButton = New System.Windows.Forms.ToolStripButton()
        Me.EditButton = New System.Windows.Forms.ToolStripButton()
        Me.DeleteButton = New System.Windows.Forms.ToolStripButton()
        Me.UndoButton = New System.Windows.Forms.ToolStripButton()
        Me.DispBy = New System.Windows.Forms.ListBox()
        Me.DISP0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.DISP0TableAdapter = New Signalog.SignalogDataSetTableAdapters.DISP0TableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DispNum = New System.Windows.Forms.TextBox()
        Me.bck = New System.Windows.Forms.Button()
        Me.fwd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DispBytxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Seqtxt = New System.Windows.Forms.TextBox()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.YES = New System.Windows.Forms.RadioButton()
        Me.NO = New System.Windows.Forms.RadioButton()
        Me.LoadPanel = New System.Windows.Forms.Panel()
        Me.SeqAll = New System.Windows.Forms.CheckBox()
        Me.FilterSeq = New System.Windows.Forms.ComboBox()
        Me.DispBySEQBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FilterBoth = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FilterNO = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FilterYES = New System.Windows.Forms.RadioButton()
        Me.DispBySEQTableAdapter = New Signalog.SignalogDataSetTableAdapters.DispBySEQTableAdapter()
        Me.LoadByPanel = New System.Windows.Forms.Panel()
        Me.Filters = New System.Windows.Forms.RadioButton()
        Me.ID = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LOCKNEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCKNEWTableAdapter = New Signalog.SignalogDataSetTableAdapters.LOCKNEWTableAdapter()
        Me.LOCKEDITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCKEDITTableAdapter = New Signalog.SignalogDataSetTableAdapters.LOCKEDITTableAdapter()
        Me.ACT0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ACT0TableAdapter = New Signalog.SignalogDataSetTableAdapters.ACT0TableAdapter()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DISP0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoadPanel.SuspendLayout()
        CType(Me.DispBySEQBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoadByPanel.SuspendLayout()
        CType(Me.LOCKNEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCKEDITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ACT0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(17, 17)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.EditButton, Me.DeleteButton, Me.UndoButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(437, 25)
        Me.ToolStrip1.TabIndex = 0
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
        'DispBy
        '
        Me.DispBy.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DispBy.DataSource = Me.DISP0BindingSource
        Me.DispBy.DisplayMember = "DISPBY"
        Me.DispBy.FormattingEnabled = True
        Me.DispBy.HorizontalScrollbar = True
        Me.DispBy.Location = New System.Drawing.Point(0, 71)
        Me.DispBy.Name = "DispBy"
        Me.DispBy.Size = New System.Drawing.Size(140, 238)
        Me.DispBy.TabIndex = 1
        Me.DispBy.ValueMember = "DISPBY"
        '
        'DISP0BindingSource
        '
        Me.DISP0BindingSource.DataMember = "DISP0"
        Me.DISP0BindingSource.DataSource = Me.SignalogDataSet
        '
        'SignalogDataSet
        '
        Me.SignalogDataSet.DataSetName = "SignalogDataSet"
        Me.SignalogDataSet.EnforceConstraints = False
        Me.SignalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DISP0TableAdapter
        '
        Me.DISP0TableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DISPNUM:"
        '
        'DispNum
        '
        Me.DispNum.Location = New System.Drawing.Point(287, 71)
        Me.DispNum.Name = "DispNum"
        Me.DispNum.Size = New System.Drawing.Size(60, 20)
        Me.DispNum.TabIndex = 3
        '
        'bck
        '
        Me.bck.Location = New System.Drawing.Point(370, 69)
        Me.bck.Name = "bck"
        Me.bck.Size = New System.Drawing.Size(27, 23)
        Me.bck.TabIndex = 4
        Me.bck.Text = "<<"
        Me.bck.UseVisualStyleBackColor = True
        '
        'fwd
        '
        Me.fwd.Location = New System.Drawing.Point(403, 69)
        Me.fwd.Name = "fwd"
        Me.fwd.Size = New System.Drawing.Size(27, 23)
        Me.fwd.TabIndex = 5
        Me.fwd.Text = ">>"
        Me.fwd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Dispatch By:"
        '
        'DispBytxt
        '
        Me.DispBytxt.Location = New System.Drawing.Point(287, 106)
        Me.DispBytxt.MaxLength = 20
        Me.DispBytxt.Name = "DispBytxt"
        Me.DispBytxt.Size = New System.Drawing.Size(143, 20)
        Me.DispBytxt.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "SEQ Number:"
        '
        'Seqtxt
        '
        Me.Seqtxt.Location = New System.Drawing.Point(287, 141)
        Me.Seqtxt.Name = "Seqtxt"
        Me.Seqtxt.Size = New System.Drawing.Size(60, 20)
        Me.Seqtxt.TabIndex = 17
        '
        'Submit
        '
        Me.Submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Submit.Location = New System.Drawing.Point(282, 301)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 18
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(200, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Show?"
        '
        'YES
        '
        Me.YES.AutoSize = True
        Me.YES.Location = New System.Drawing.Point(253, 177)
        Me.YES.Name = "YES"
        Me.YES.Size = New System.Drawing.Size(48, 19)
        Me.YES.TabIndex = 20
        Me.YES.TabStop = True
        Me.YES.Text = "YES"
        Me.YES.UseVisualStyleBackColor = True
        '
        'NO
        '
        Me.NO.AutoSize = True
        Me.NO.Location = New System.Drawing.Point(305, 177)
        Me.NO.Name = "NO"
        Me.NO.Size = New System.Drawing.Size(43, 19)
        Me.NO.TabIndex = 21
        Me.NO.TabStop = True
        Me.NO.Text = "NO"
        Me.NO.UseVisualStyleBackColor = True
        '
        'LoadPanel
        '
        Me.LoadPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LoadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoadPanel.Controls.Add(Me.SeqAll)
        Me.LoadPanel.Controls.Add(Me.FilterSeq)
        Me.LoadPanel.Controls.Add(Me.FilterBoth)
        Me.LoadPanel.Controls.Add(Me.Label8)
        Me.LoadPanel.Controls.Add(Me.FilterNO)
        Me.LoadPanel.Controls.Add(Me.Label7)
        Me.LoadPanel.Controls.Add(Me.FilterYES)
        Me.LoadPanel.Controls.Add(Me.DispBy)
        Me.LoadPanel.Location = New System.Drawing.Point(0, 25)
        Me.LoadPanel.Name = "LoadPanel"
        Me.LoadPanel.Size = New System.Drawing.Size(194, 311)
        Me.LoadPanel.TabIndex = 22
        '
        'SeqAll
        '
        Me.SeqAll.AutoSize = True
        Me.SeqAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SeqAll.Location = New System.Drawing.Point(144, 41)
        Me.SeqAll.Name = "SeqAll"
        Me.SeqAll.Size = New System.Drawing.Size(47, 19)
        Me.SeqAll.TabIndex = 93
        Me.SeqAll.Text = "ALL"
        Me.SeqAll.UseVisualStyleBackColor = True
        '
        'FilterSeq
        '
        Me.FilterSeq.DataSource = Me.DispBySEQBindingSource
        Me.FilterSeq.DisplayMember = "SEQ"
        Me.FilterSeq.FormattingEnabled = True
        Me.FilterSeq.Location = New System.Drawing.Point(77, 38)
        Me.FilterSeq.Name = "FilterSeq"
        Me.FilterSeq.Size = New System.Drawing.Size(62, 21)
        Me.FilterSeq.TabIndex = 88
        Me.FilterSeq.ValueMember = "SEQ"
        '
        'DispBySEQBindingSource
        '
        Me.DispBySEQBindingSource.DataMember = "DispBySEQ"
        Me.DispBySEQBindingSource.DataSource = Me.SignalogDataSet
        '
        'FilterBoth
        '
        Me.FilterBoth.AutoSize = True
        Me.FilterBoth.Location = New System.Drawing.Point(143, 11)
        Me.FilterBoth.Name = "FilterBoth"
        Me.FilterBoth.Size = New System.Drawing.Size(50, 19)
        Me.FilterBoth.TabIndex = 92
        Me.FilterBoth.TabStop = True
        Me.FilterBoth.Text = "Both"
        Me.FilterBoth.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 15)
        Me.Label8.TabIndex = 91
        Me.Label8.Text = "SEQ Number:"
        '
        'FilterNO
        '
        Me.FilterNO.AutoSize = True
        Me.FilterNO.Location = New System.Drawing.Point(98, 11)
        Me.FilterNO.Name = "FilterNO"
        Me.FilterNO.Size = New System.Drawing.Size(41, 19)
        Me.FilterNO.TabIndex = 90
        Me.FilterNO.TabStop = True
        Me.FilterNO.Text = "No"
        Me.FilterNO.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "Show?"
        '
        'FilterYES
        '
        Me.FilterYES.AutoSize = True
        Me.FilterYES.Location = New System.Drawing.Point(51, 11)
        Me.FilterYES.Name = "FilterYES"
        Me.FilterYES.Size = New System.Drawing.Size(45, 19)
        Me.FilterYES.TabIndex = 89
        Me.FilterYES.TabStop = True
        Me.FilterYES.Text = "Yes"
        Me.FilterYES.UseVisualStyleBackColor = True
        '
        'DispBySEQTableAdapter
        '
        Me.DispBySEQTableAdapter.ClearBeforeFill = True
        '
        'LoadByPanel
        '
        Me.LoadByPanel.Controls.Add(Me.Filters)
        Me.LoadByPanel.Controls.Add(Me.ID)
        Me.LoadByPanel.Location = New System.Drawing.Point(269, 34)
        Me.LoadByPanel.Name = "LoadByPanel"
        Me.LoadByPanel.Size = New System.Drawing.Size(98, 23)
        Me.LoadByPanel.TabIndex = 84
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
        Me.Label13.Location = New System.Drawing.Point(200, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 15)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "Load By:"
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
        'ACT0BindingSource
        '
        Me.ACT0BindingSource.DataMember = "ACT0"
        Me.ACT0BindingSource.DataSource = Me.SignalogDataSet
        '
        'ACT0TableAdapter
        '
        Me.ACT0TableAdapter.ClearBeforeFill = True
        '
        'Dispatch_By_Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 334)
        Me.Controls.Add(Me.LoadByPanel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LoadPanel)
        Me.Controls.Add(Me.NO)
        Me.Controls.Add(Me.YES)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Seqtxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DispBytxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fwd)
        Me.Controls.Add(Me.bck)
        Me.Controls.Add(Me.DispNum)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dispatch_By_Maintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dispatch By Maintenance"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DISP0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoadPanel.ResumeLayout(False)
        Me.LoadPanel.PerformLayout()
        CType(Me.DispBySEQBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoadByPanel.ResumeLayout(False)
        Me.LoadByPanel.PerformLayout()
        CType(Me.LOCKNEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCKEDITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ACT0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents UndoButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DispBy As System.Windows.Forms.ListBox
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents DISP0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DISP0TableAdapter As Signalog.SignalogDataSetTableAdapters.DISP0TableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DispNum As System.Windows.Forms.TextBox
    Friend WithEvents bck As System.Windows.Forms.Button
    Friend WithEvents fwd As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DispBytxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Seqtxt As System.Windows.Forms.TextBox
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents YES As System.Windows.Forms.RadioButton
    Friend WithEvents NO As System.Windows.Forms.RadioButton
    Friend WithEvents LoadPanel As System.Windows.Forms.Panel
    Friend WithEvents SeqAll As System.Windows.Forms.CheckBox
    Friend WithEvents FilterSeq As System.Windows.Forms.ComboBox
    Friend WithEvents FilterBoth As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FilterNO As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FilterYES As System.Windows.Forms.RadioButton
    Friend WithEvents DispBySEQBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DispBySEQTableAdapter As Signalog.SignalogDataSetTableAdapters.DispBySEQTableAdapter
    Friend WithEvents LoadByPanel As System.Windows.Forms.Panel
    Friend WithEvents Filters As System.Windows.Forms.RadioButton
    Friend WithEvents ID As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LOCKNEWBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKNEWTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKNEWTableAdapter
    Friend WithEvents LOCKEDITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKEDITTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKEDITTableAdapter
    Friend WithEvents ACT0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT0TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT0TableAdapter
End Class
