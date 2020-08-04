<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dispatch_By_Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dispatch_By_Report))
        Me.Generate_Report = New System.Windows.Forms.Button()
        Me.dispatch_By1 = New Signalog.Dispatch_By()
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.DISP0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DISP0TableAdapter = New Signalog.SignalogDataSetTableAdapters.DISP0TableAdapter()
        Me.FiltesrPanel = New System.Windows.Forms.Panel()
        Me.FilterBoth = New System.Windows.Forms.RadioButton()
        Me.FilterNO = New System.Windows.Forms.RadioButton()
        Me.FilterYES = New System.Windows.Forms.RadioButton()
        Me.SeqAll = New System.Windows.Forms.CheckBox()
        Me.SeqFilter = New System.Windows.Forms.ComboBox()
        Me.DispBySEQBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DispBySEQTableAdapter = New Signalog.SignalogDataSetTableAdapters.DispBySEQTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SortPanel = New System.Windows.Forms.Panel()
        Me.OrderPanel = New System.Windows.Forms.Panel()
        Me.OrderAsc = New System.Windows.Forms.RadioButton()
        Me.OrderDesc = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SortShow = New System.Windows.Forms.RadioButton()
        Me.SortSeq = New System.Windows.Forms.RadioButton()
        Me.SortDispBy = New System.Windows.Forms.RadioButton()
        Me.SortID = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FieldsAll = New System.Windows.Forms.CheckBox()
        Me.RptFields = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DISP0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FiltesrPanel.SuspendLayout()
        CType(Me.DispBySEQBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SortPanel.SuspendLayout()
        Me.OrderPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Generate_Report
        '
        Me.Generate_Report.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Generate_Report.Location = New System.Drawing.Point(106, 423)
        Me.Generate_Report.Name = "Generate_Report"
        Me.Generate_Report.Size = New System.Drawing.Size(94, 23)
        Me.Generate_Report.TabIndex = 0
        Me.Generate_Report.Text = "Generate Report"
        Me.Generate_Report.UseVisualStyleBackColor = True
        '
        'SignalogDataSet
        '
        Me.SignalogDataSet.DataSetName = "SignalogDataSet"
        Me.SignalogDataSet.EnforceConstraints = False
        Me.SignalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'FiltesrPanel
        '
        Me.FiltesrPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FiltesrPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FiltesrPanel.Controls.Add(Me.FilterBoth)
        Me.FiltesrPanel.Controls.Add(Me.FilterNO)
        Me.FiltesrPanel.Controls.Add(Me.FilterYES)
        Me.FiltesrPanel.Controls.Add(Me.SeqAll)
        Me.FiltesrPanel.Controls.Add(Me.SeqFilter)
        Me.FiltesrPanel.Controls.Add(Me.Label4)
        Me.FiltesrPanel.Controls.Add(Me.Label3)
        Me.FiltesrPanel.Location = New System.Drawing.Point(12, 23)
        Me.FiltesrPanel.Name = "FiltesrPanel"
        Me.FiltesrPanel.Size = New System.Drawing.Size(275, 70)
        Me.FiltesrPanel.TabIndex = 1
        '
        'FilterBoth
        '
        Me.FilterBoth.AutoSize = True
        Me.FilterBoth.Location = New System.Drawing.Point(185, 45)
        Me.FilterBoth.Name = "FilterBoth"
        Me.FilterBoth.Size = New System.Drawing.Size(47, 17)
        Me.FilterBoth.TabIndex = 121
        Me.FilterBoth.TabStop = True
        Me.FilterBoth.Text = "Both"
        Me.FilterBoth.UseVisualStyleBackColor = True
        '
        'FilterNO
        '
        Me.FilterNO.AutoSize = True
        Me.FilterNO.Location = New System.Drawing.Point(140, 45)
        Me.FilterNO.Name = "FilterNO"
        Me.FilterNO.Size = New System.Drawing.Size(39, 17)
        Me.FilterNO.TabIndex = 120
        Me.FilterNO.TabStop = True
        Me.FilterNO.Text = "No"
        Me.FilterNO.UseVisualStyleBackColor = True
        '
        'FilterYES
        '
        Me.FilterYES.AutoSize = True
        Me.FilterYES.Location = New System.Drawing.Point(93, 45)
        Me.FilterYES.Name = "FilterYES"
        Me.FilterYES.Size = New System.Drawing.Size(43, 17)
        Me.FilterYES.TabIndex = 119
        Me.FilterYES.TabStop = True
        Me.FilterYES.Text = "Yes"
        Me.FilterYES.UseVisualStyleBackColor = True
        '
        'SeqAll
        '
        Me.SeqAll.AutoSize = True
        Me.SeqAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SeqAll.Location = New System.Drawing.Point(220, 13)
        Me.SeqAll.Name = "SeqAll"
        Me.SeqAll.Size = New System.Drawing.Size(45, 17)
        Me.SeqAll.TabIndex = 118
        Me.SeqAll.Text = "ALL"
        Me.SeqAll.UseVisualStyleBackColor = True
        '
        'SeqFilter
        '
        Me.SeqFilter.DataSource = Me.DispBySEQBindingSource
        Me.SeqFilter.DisplayMember = "SEQ"
        Me.SeqFilter.FormattingEnabled = True
        Me.SeqFilter.Location = New System.Drawing.Point(93, 9)
        Me.SeqFilter.Name = "SeqFilter"
        Me.SeqFilter.Size = New System.Drawing.Size(121, 21)
        Me.SeqFilter.TabIndex = 2
        Me.SeqFilter.ValueMember = "SEQ"
        '
        'DispBySEQBindingSource
        '
        Me.DispBySEQBindingSource.DataMember = "DispBySEQ"
        Me.DispBySEQBindingSource.DataSource = Me.SignalogDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Show?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Sequence Num:"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(129, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filtering"
        '
        'DispBySEQTableAdapter
        '
        Me.DispBySEQTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sorting"
        '
        'SortPanel
        '
        Me.SortPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SortPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SortPanel.Controls.Add(Me.OrderPanel)
        Me.SortPanel.Controls.Add(Me.Label6)
        Me.SortPanel.Controls.Add(Me.SortShow)
        Me.SortPanel.Controls.Add(Me.SortSeq)
        Me.SortPanel.Controls.Add(Me.SortDispBy)
        Me.SortPanel.Controls.Add(Me.SortID)
        Me.SortPanel.Controls.Add(Me.Label5)
        Me.SortPanel.Location = New System.Drawing.Point(12, 124)
        Me.SortPanel.Name = "SortPanel"
        Me.SortPanel.Size = New System.Drawing.Size(275, 154)
        Me.SortPanel.TabIndex = 3
        '
        'OrderPanel
        '
        Me.OrderPanel.Controls.Add(Me.OrderAsc)
        Me.OrderPanel.Controls.Add(Me.OrderDesc)
        Me.OrderPanel.Location = New System.Drawing.Point(50, 99)
        Me.OrderPanel.Name = "OrderPanel"
        Me.OrderPanel.Size = New System.Drawing.Size(86, 50)
        Me.OrderPanel.TabIndex = 126
        '
        'OrderAsc
        '
        Me.OrderAsc.AutoSize = True
        Me.OrderAsc.Location = New System.Drawing.Point(3, 3)
        Me.OrderAsc.Name = "OrderAsc"
        Me.OrderAsc.Size = New System.Drawing.Size(75, 17)
        Me.OrderAsc.TabIndex = 124
        Me.OrderAsc.TabStop = True
        Me.OrderAsc.Text = "Ascending"
        Me.OrderAsc.UseVisualStyleBackColor = True
        '
        'OrderDesc
        '
        Me.OrderDesc.AutoSize = True
        Me.OrderDesc.Location = New System.Drawing.Point(3, 26)
        Me.OrderDesc.Name = "OrderDesc"
        Me.OrderDesc.Size = New System.Drawing.Size(82, 17)
        Me.OrderDesc.TabIndex = 125
        Me.OrderDesc.TabStop = True
        Me.OrderDesc.Text = "Descending"
        Me.OrderDesc.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 123
        Me.Label6.Text = "Order:"
        '
        'SortShow
        '
        Me.SortShow.AutoSize = True
        Me.SortShow.Location = New System.Drawing.Point(53, 79)
        Me.SortShow.Name = "SortShow"
        Me.SortShow.Size = New System.Drawing.Size(52, 17)
        Me.SortShow.TabIndex = 122
        Me.SortShow.TabStop = True
        Me.SortShow.Text = "Show"
        Me.SortShow.UseVisualStyleBackColor = True
        '
        'SortSeq
        '
        Me.SortSeq.AutoSize = True
        Me.SortSeq.Location = New System.Drawing.Point(53, 56)
        Me.SortSeq.Name = "SortSeq"
        Me.SortSeq.Size = New System.Drawing.Size(114, 17)
        Me.SortSeq.TabIndex = 121
        Me.SortSeq.TabStop = True
        Me.SortSeq.Text = "Sequence Number"
        Me.SortSeq.UseVisualStyleBackColor = True
        '
        'SortDispBy
        '
        Me.SortDispBy.AutoSize = True
        Me.SortDispBy.Location = New System.Drawing.Point(53, 33)
        Me.SortDispBy.Name = "SortDispBy"
        Me.SortDispBy.Size = New System.Drawing.Size(138, 17)
        Me.SortDispBy.TabIndex = 120
        Me.SortDispBy.TabStop = True
        Me.SortDispBy.Text = "Dispatch By Description"
        Me.SortDispBy.UseVisualStyleBackColor = True
        '
        'SortID
        '
        Me.SortID.AutoSize = True
        Me.SortID.Location = New System.Drawing.Point(53, 10)
        Me.SortID.Name = "SortID"
        Me.SortID.Size = New System.Drawing.Size(36, 17)
        Me.SortID.TabIndex = 119
        Me.SortID.TabStop = True
        Me.SortID.Text = "ID"
        Me.SortID.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Sort By:"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(111, 294)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Report Fields"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.FieldsAll)
        Me.Panel1.Controls.Add(Me.RptFields)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Location = New System.Drawing.Point(12, 310)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 97)
        Me.Panel1.TabIndex = 5
        '
        'FieldsAll
        '
        Me.FieldsAll.AutoSize = True
        Me.FieldsAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.FieldsAll.Location = New System.Drawing.Point(146, 49)
        Me.FieldsAll.Name = "FieldsAll"
        Me.FieldsAll.Size = New System.Drawing.Size(70, 17)
        Me.FieldsAll.TabIndex = 119
        Me.FieldsAll.Text = "Select All"
        Me.FieldsAll.UseVisualStyleBackColor = True
        '
        'RptFields
        '
        Me.RptFields.FormattingEnabled = True
        Me.RptFields.Items.AddRange(New Object() {"ID", "Dispatch By Description", "Sequence Number", "Show"})
        Me.RptFields.Location = New System.Drawing.Point(6, 29)
        Me.RptFields.Name = "RptFields"
        Me.RptFields.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.RptFields.Size = New System.Drawing.Size(126, 56)
        Me.RptFields.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(244, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "What fields do you want to include on your report?"
        '
        'Dispatch_By_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 458)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SortPanel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FiltesrPanel)
        Me.Controls.Add(Me.Generate_Report)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dispatch_By_Report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dispatch By Report"
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DISP0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FiltesrPanel.ResumeLayout(False)
        Me.FiltesrPanel.PerformLayout()
        CType(Me.DispBySEQBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SortPanel.ResumeLayout(False)
        Me.SortPanel.PerformLayout()
        Me.OrderPanel.ResumeLayout(False)
        Me.OrderPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Generate_Report As System.Windows.Forms.Button
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents DISP0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DISP0TableAdapter As Signalog.SignalogDataSetTableAdapters.DISP0TableAdapter
    Friend WithEvents dispatch_By1 As Signalog.Dispatch_By
    Friend WithEvents FiltesrPanel As System.Windows.Forms.Panel
    Friend WithEvents SeqFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DispBySEQBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DispBySEQTableAdapter As Signalog.SignalogDataSetTableAdapters.DispBySEQTableAdapter
    Friend WithEvents SeqAll As System.Windows.Forms.CheckBox
    Friend WithEvents FilterBoth As System.Windows.Forms.RadioButton
    Friend WithEvents FilterNO As System.Windows.Forms.RadioButton
    Friend WithEvents FilterYES As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SortPanel As System.Windows.Forms.Panel
    Friend WithEvents SortSeq As System.Windows.Forms.RadioButton
    Friend WithEvents SortDispBy As System.Windows.Forms.RadioButton
    Friend WithEvents SortID As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents SortShow As System.Windows.Forms.RadioButton
    Friend WithEvents OrderPanel As System.Windows.Forms.Panel
    Friend WithEvents OrderAsc As System.Windows.Forms.RadioButton
    Friend WithEvents OrderDesc As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents RptFields As System.Windows.Forms.ListBox
    Friend WithEvents FieldsAll As System.Windows.Forms.CheckBox
End Class
