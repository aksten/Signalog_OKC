﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manufacturer_List_Maintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manufacturer_List_Maintenance))
        Me.Manuf = New System.Windows.Forms.ListBox()
        Me.MANFLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewButton = New System.Windows.Forms.ToolStripButton()
        Me.EditButton = New System.Windows.Forms.ToolStripButton()
        Me.DeleteButton = New System.Windows.Forms.ToolStripButton()
        Me.UndoButton = New System.Windows.Forms.ToolStripButton()
        Me.MANF_LISTTableAdapter = New Signalog.SignalogDataSetTableAdapters.MANF_LISTTableAdapter()
        Me.NO = New System.Windows.Forms.RadioButton()
        Me.YES = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.ManufDesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fwd = New System.Windows.Forms.Button()
        Me.bck = New System.Windows.Forms.Button()
        Me.ManufID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoadPanel = New System.Windows.Forms.Panel()
        Me.FilterBoth = New System.Windows.Forms.RadioButton()
        Me.FilterNO = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FilterYES = New System.Windows.Forms.RadioButton()
        Me.LoadByPanel = New System.Windows.Forms.Panel()
        Me.Filters = New System.Windows.Forms.RadioButton()
        Me.ID = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LOCKNEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCKNEWTableAdapter = New Signalog.SignalogDataSetTableAdapters.LOCKNEWTableAdapter()
        Me.LOCKEDITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCKEDITTableAdapter = New Signalog.SignalogDataSetTableAdapters.LOCKEDITTableAdapter()
        Me.EQUIPMENTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPMENTTableAdapter = New Signalog.SignalogDataSetTableAdapters.EQUIPMENTTableAdapter()
        Me.EQUIPMENT2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EQUIPMENT2TableAdapter = New Signalog.SignalogDataSetTableAdapters.EQUIPMENT2TableAdapter()
        CType(Me.MANFLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.LoadPanel.SuspendLayout()
        Me.LoadByPanel.SuspendLayout()
        CType(Me.LOCKNEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCKEDITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EQUIPMENT2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Manuf
        '
        Me.Manuf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Manuf.DataSource = Me.MANFLISTBindingSource
        Me.Manuf.DisplayMember = "MANUFACTURER"
        Me.Manuf.FormattingEnabled = True
        Me.Manuf.Location = New System.Drawing.Point(0, 29)
        Me.Manuf.Name = "Manuf"
        Me.Manuf.Size = New System.Drawing.Size(189, 238)
        Me.Manuf.TabIndex = 0
        Me.Manuf.ValueMember = "MANUFACTURER"
        '
        'MANFLISTBindingSource
        '
        Me.MANFLISTBindingSource.DataMember = "MANF LIST"
        Me.MANFLISTBindingSource.DataSource = Me.SignalogDataSet
        '
        'SignalogDataSet
        '
        Me.SignalogDataSet.DataSetName = "SignalogDataSet"
        Me.SignalogDataSet.EnforceConstraints = False
        Me.SignalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(17, 17)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.EditButton, Me.DeleteButton, Me.UndoButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(437, 25)
        Me.ToolStrip1.TabIndex = 1
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
        'MANF_LISTTableAdapter
        '
        Me.MANF_LISTTableAdapter.ClearBeforeFill = True
        '
        'NO
        '
        Me.NO.AutoSize = True
        Me.NO.Location = New System.Drawing.Point(339, 140)
        Me.NO.Name = "NO"
        Me.NO.Size = New System.Drawing.Size(43, 19)
        Me.NO.TabIndex = 33
        Me.NO.TabStop = True
        Me.NO.Text = "NO"
        Me.NO.UseVisualStyleBackColor = True
        '
        'YES
        '
        Me.YES.AutoSize = True
        Me.YES.Location = New System.Drawing.Point(287, 140)
        Me.YES.Name = "YES"
        Me.YES.Size = New System.Drawing.Size(48, 19)
        Me.YES.TabIndex = 32
        Me.YES.TabStop = True
        Me.YES.Text = "YES"
        Me.YES.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Show?"
        '
        'Submit
        '
        Me.Submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Submit.Location = New System.Drawing.Point(285, 258)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 30
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'ManufDesc
        '
        Me.ManufDesc.Location = New System.Drawing.Point(287, 104)
        Me.ManufDesc.MaxLength = 25
        Me.ManufDesc.Name = "ManufDesc"
        Me.ManufDesc.Size = New System.Drawing.Size(143, 20)
        Me.ManufDesc.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Manufacturer:"
        '
        'fwd
        '
        Me.fwd.Location = New System.Drawing.Point(403, 67)
        Me.fwd.Name = "fwd"
        Me.fwd.Size = New System.Drawing.Size(27, 23)
        Me.fwd.TabIndex = 25
        Me.fwd.Text = ">>"
        Me.fwd.UseVisualStyleBackColor = True
        '
        'bck
        '
        Me.bck.Location = New System.Drawing.Point(370, 67)
        Me.bck.Name = "bck"
        Me.bck.Size = New System.Drawing.Size(27, 23)
        Me.bck.TabIndex = 24
        Me.bck.Text = "<<"
        Me.bck.UseVisualStyleBackColor = True
        '
        'ManufID
        '
        Me.ManufID.Location = New System.Drawing.Point(287, 69)
        Me.ManufID.Name = "ManufID"
        Me.ManufID.Size = New System.Drawing.Size(60, 20)
        Me.ManufID.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Manuf. ID:"
        '
        'LoadPanel
        '
        Me.LoadPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LoadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoadPanel.Controls.Add(Me.FilterBoth)
        Me.LoadPanel.Controls.Add(Me.FilterNO)
        Me.LoadPanel.Controls.Add(Me.Label7)
        Me.LoadPanel.Controls.Add(Me.FilterYES)
        Me.LoadPanel.Controls.Add(Me.Manuf)
        Me.LoadPanel.Location = New System.Drawing.Point(0, 25)
        Me.LoadPanel.Name = "LoadPanel"
        Me.LoadPanel.Size = New System.Drawing.Size(194, 269)
        Me.LoadPanel.TabIndex = 34
        '
        'FilterBoth
        '
        Me.FilterBoth.AutoSize = True
        Me.FilterBoth.Location = New System.Drawing.Point(143, 7)
        Me.FilterBoth.Name = "FilterBoth"
        Me.FilterBoth.Size = New System.Drawing.Size(50, 19)
        Me.FilterBoth.TabIndex = 100
        Me.FilterBoth.TabStop = True
        Me.FilterBoth.Text = "Both"
        Me.FilterBoth.UseVisualStyleBackColor = True
        '
        'FilterNO
        '
        Me.FilterNO.AutoSize = True
        Me.FilterNO.Location = New System.Drawing.Point(98, 7)
        Me.FilterNO.Name = "FilterNO"
        Me.FilterNO.Size = New System.Drawing.Size(41, 19)
        Me.FilterNO.TabIndex = 99
        Me.FilterNO.TabStop = True
        Me.FilterNO.Text = "No"
        Me.FilterNO.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "Show?"
        '
        'FilterYES
        '
        Me.FilterYES.AutoSize = True
        Me.FilterYES.Location = New System.Drawing.Point(51, 7)
        Me.FilterYES.Name = "FilterYES"
        Me.FilterYES.Size = New System.Drawing.Size(45, 19)
        Me.FilterYES.TabIndex = 98
        Me.FilterYES.TabStop = True
        Me.FilterYES.Text = "Yes"
        Me.FilterYES.UseVisualStyleBackColor = True
        '
        'LoadByPanel
        '
        Me.LoadByPanel.Controls.Add(Me.Filters)
        Me.LoadByPanel.Controls.Add(Me.ID)
        Me.LoadByPanel.Location = New System.Drawing.Point(269, 32)
        Me.LoadByPanel.Name = "LoadByPanel"
        Me.LoadByPanel.Size = New System.Drawing.Size(98, 23)
        Me.LoadByPanel.TabIndex = 88
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
        Me.Label13.Location = New System.Drawing.Point(200, 37)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 15)
        Me.Label13.TabIndex = 87
        Me.Label13.Text = "Load By:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Show?"
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
        'Manufacturer_List_Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 293)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LoadByPanel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LoadPanel)
        Me.Controls.Add(Me.NO)
        Me.Controls.Add(Me.YES)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.ManufDesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fwd)
        Me.Controls.Add(Me.bck)
        Me.Controls.Add(Me.ManufID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Manufacturer_List_Maintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manufacturer List Maintenance"
        CType(Me.MANFLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.LoadPanel.ResumeLayout(False)
        Me.LoadPanel.PerformLayout()
        Me.LoadByPanel.ResumeLayout(False)
        Me.LoadByPanel.PerformLayout()
        CType(Me.LOCKNEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCKEDITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EQUIPMENT2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Manuf As System.Windows.Forms.ListBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents UndoButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents MANFLISTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MANF_LISTTableAdapter As Signalog.SignalogDataSetTableAdapters.MANF_LISTTableAdapter
    Friend WithEvents NO As System.Windows.Forms.RadioButton
    Friend WithEvents YES As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents ManufDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fwd As System.Windows.Forms.Button
    Friend WithEvents bck As System.Windows.Forms.Button
    Friend WithEvents ManufID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LoadPanel As System.Windows.Forms.Panel
    Friend WithEvents FilterBoth As System.Windows.Forms.RadioButton
    Friend WithEvents FilterNO As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FilterYES As System.Windows.Forms.RadioButton
    Friend WithEvents LoadByPanel As System.Windows.Forms.Panel
    Friend WithEvents Filters As System.Windows.Forms.RadioButton
    Friend WithEvents ID As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LOCKNEWBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKNEWTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKNEWTableAdapter
    Friend WithEvents LOCKEDITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKEDITTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKEDITTableAdapter
    Friend WithEvents EQUIPMENTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENTTableAdapter As Signalog.SignalogDataSetTableAdapters.EQUIPMENTTableAdapter
    Friend WithEvents EQUIPMENT2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EQUIPMENT2TableAdapter As Signalog.SignalogDataSetTableAdapters.EQUIPMENT2TableAdapter
End Class
