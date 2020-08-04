<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employees_Maintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employees_Maintenance))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewButton = New System.Windows.Forms.ToolStripButton()
        Me.EditButton = New System.Windows.Forms.ToolStripButton()
        Me.DeleteButton = New System.Windows.Forms.ToolStripButton()
        Me.UndoButton = New System.Windows.Forms.ToolStripButton()
        Me.Employees = New System.Windows.Forms.ListBox()
        Me.PERS0BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.NO = New System.Windows.Forms.RadioButton()
        Me.YES = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Fname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fwd = New System.Windows.Forms.Button()
        Me.bck = New System.Windows.Forms.Button()
        Me.EmpID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SeqNum = New System.Windows.Forms.TextBox()
        Me.PERS0TableAdapter = New Signalog.SignalogDataSetTableAdapters.PERS0TableAdapter()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PListName = New System.Windows.Forms.TextBox()
        Me.LoadPanel = New System.Windows.Forms.Panel()
        Me.FilterFname = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SeqAll = New System.Windows.Forms.CheckBox()
        Me.FilterSeq = New System.Windows.Forms.ComboBox()
        Me.EmployeeSEQBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FilterLname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FilterBoth = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.FilterNO = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FilterYES = New System.Windows.Forms.RadioButton()
        Me.EmployeeSEQTableAdapter = New Signalog.SignalogDataSetTableAdapters.EmployeeSEQTableAdapter()
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.AccessType = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PERS0BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoadPanel.SuspendLayout()
        CType(Me.EmployeeSEQBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolStrip1.Size = New System.Drawing.Size(452, 25)
        Me.ToolStrip1.TabIndex = 5
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
        'Employees
        '
        Me.Employees.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Employees.DataSource = Me.PERS0BindingSource
        Me.Employees.DisplayMember = "PLISTNAME"
        Me.Employees.FormattingEnabled = True
        Me.Employees.Location = New System.Drawing.Point(0, 119)
        Me.Employees.Name = "Employees"
        Me.Employees.Size = New System.Drawing.Size(150, 316)
        Me.Employees.TabIndex = 6
        Me.Employees.ValueMember = "PLISTNAME"
        '
        'PERS0BindingSource
        '
        Me.PERS0BindingSource.DataMember = "PERS0"
        Me.PERS0BindingSource.DataSource = Me.SignalogDataSet
        '
        'SignalogDataSet
        '
        Me.SignalogDataSet.DataSetName = "SignalogDataSet"
        Me.SignalogDataSet.EnforceConstraints = False
        Me.SignalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NO
        '
        Me.NO.AutoSize = True
        Me.NO.Location = New System.Drawing.Point(338, 247)
        Me.NO.Name = "NO"
        Me.NO.Size = New System.Drawing.Size(43, 19)
        Me.NO.TabIndex = 74
        Me.NO.TabStop = True
        Me.NO.Text = "NO"
        Me.NO.UseVisualStyleBackColor = True
        '
        'YES
        '
        Me.YES.AutoSize = True
        Me.YES.Location = New System.Drawing.Point(286, 247)
        Me.YES.Name = "YES"
        Me.YES.Size = New System.Drawing.Size(48, 19)
        Me.YES.TabIndex = 73
        Me.YES.TabStop = True
        Me.YES.Text = "YES"
        Me.YES.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(199, 249)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 15)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Show?"
        '
        'Submit
        '
        Me.Submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Submit.Location = New System.Drawing.Point(286, 424)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 90
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Fname
        '
        Me.Fname.Location = New System.Drawing.Point(286, 106)
        Me.Fname.MaxLength = 15
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(120, 20)
        Me.Fname.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(199, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "First Name:"
        '
        'fwd
        '
        Me.fwd.Location = New System.Drawing.Point(402, 69)
        Me.fwd.Name = "fwd"
        Me.fwd.Size = New System.Drawing.Size(27, 23)
        Me.fwd.TabIndex = 67
        Me.fwd.Text = ">>"
        Me.fwd.UseVisualStyleBackColor = True
        '
        'bck
        '
        Me.bck.Location = New System.Drawing.Point(369, 69)
        Me.bck.Name = "bck"
        Me.bck.Size = New System.Drawing.Size(27, 23)
        Me.bck.TabIndex = 66
        Me.bck.Text = "<<"
        Me.bck.UseVisualStyleBackColor = True
        '
        'EmpID
        '
        Me.EmpID.Location = New System.Drawing.Point(286, 71)
        Me.EmpID.Name = "EmpID"
        Me.EmpID.Size = New System.Drawing.Size(60, 20)
        Me.EmpID.TabIndex = 65
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(199, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Employee ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 74
        Me.Label3.Text = "Last Name:"
        '
        'Lname
        '
        Me.Lname.Location = New System.Drawing.Point(286, 141)
        Me.Lname.MaxLength = 15
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(120, 20)
        Me.Lname.TabIndex = 70
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(199, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 15)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "SEQ Number:"
        '
        'SeqNum
        '
        Me.SeqNum.Location = New System.Drawing.Point(286, 211)
        Me.SeqNum.MaxLength = 10
        Me.SeqNum.Name = "SeqNum"
        Me.SeqNum.Size = New System.Drawing.Size(60, 20)
        Me.SeqNum.TabIndex = 72
        '
        'PERS0TableAdapter
        '
        Me.PERS0TableAdapter.ClearBeforeFill = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(199, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 15)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "PickList Name:"
        '
        'PListName
        '
        Me.PListName.Location = New System.Drawing.Point(286, 177)
        Me.PListName.MaxLength = 20
        Me.PListName.Name = "PListName"
        Me.PListName.Size = New System.Drawing.Size(154, 20)
        Me.PListName.TabIndex = 71
        '
        'LoadPanel
        '
        Me.LoadPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LoadPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoadPanel.Controls.Add(Me.FilterFname)
        Me.LoadPanel.Controls.Add(Me.Label10)
        Me.LoadPanel.Controls.Add(Me.SeqAll)
        Me.LoadPanel.Controls.Add(Me.FilterSeq)
        Me.LoadPanel.Controls.Add(Me.FilterLname)
        Me.LoadPanel.Controls.Add(Me.Label9)
        Me.LoadPanel.Controls.Add(Me.FilterBoth)
        Me.LoadPanel.Controls.Add(Me.Label8)
        Me.LoadPanel.Controls.Add(Me.FilterNO)
        Me.LoadPanel.Controls.Add(Me.Label7)
        Me.LoadPanel.Controls.Add(Me.FilterYES)
        Me.LoadPanel.Controls.Add(Me.Employees)
        Me.LoadPanel.Location = New System.Drawing.Point(0, 24)
        Me.LoadPanel.Name = "LoadPanel"
        Me.LoadPanel.Size = New System.Drawing.Size(193, 436)
        Me.LoadPanel.TabIndex = 80
        '
        'FilterFname
        '
        Me.FilterFname.Location = New System.Drawing.Point(75, 64)
        Me.FilterFname.Name = "FilterFname"
        Me.FilterFname.Size = New System.Drawing.Size(100, 20)
        Me.FilterFname.TabIndex = 88
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 15)
        Me.Label10.TabIndex = 87
        Me.Label10.Text = "First Name:"
        '
        'SeqAll
        '
        Me.SeqAll.AutoSize = True
        Me.SeqAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SeqAll.Location = New System.Drawing.Point(143, 35)
        Me.SeqAll.Name = "SeqAll"
        Me.SeqAll.Size = New System.Drawing.Size(47, 19)
        Me.SeqAll.TabIndex = 86
        Me.SeqAll.Text = "ALL"
        Me.SeqAll.UseVisualStyleBackColor = True
        '
        'FilterSeq
        '
        Me.FilterSeq.DataSource = Me.EmployeeSEQBindingSource
        Me.FilterSeq.DisplayMember = "SEQ"
        Me.FilterSeq.FormattingEnabled = True
        Me.FilterSeq.Location = New System.Drawing.Point(75, 32)
        Me.FilterSeq.Name = "FilterSeq"
        Me.FilterSeq.Size = New System.Drawing.Size(62, 21)
        Me.FilterSeq.TabIndex = 81
        Me.FilterSeq.ValueMember = "SEQ"
        '
        'EmployeeSEQBindingSource
        '
        Me.EmployeeSEQBindingSource.DataMember = "EmployeeSEQ"
        Me.EmployeeSEQBindingSource.DataSource = Me.SignalogDataSet
        '
        'FilterLname
        '
        Me.FilterLname.Location = New System.Drawing.Point(75, 94)
        Me.FilterLname.Name = "FilterLname"
        Me.FilterLname.Size = New System.Drawing.Size(100, 20)
        Me.FilterLname.TabIndex = 89
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(1, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 15)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Last Name:"
        '
        'FilterBoth
        '
        Me.FilterBoth.AutoSize = True
        Me.FilterBoth.Location = New System.Drawing.Point(141, 5)
        Me.FilterBoth.Name = "FilterBoth"
        Me.FilterBoth.Size = New System.Drawing.Size(50, 19)
        Me.FilterBoth.TabIndex = 84
        Me.FilterBoth.TabStop = True
        Me.FilterBoth.Text = "Both"
        Me.FilterBoth.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 15)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "SEQ Number:"
        '
        'FilterNO
        '
        Me.FilterNO.AutoSize = True
        Me.FilterNO.Location = New System.Drawing.Point(96, 5)
        Me.FilterNO.Name = "FilterNO"
        Me.FilterNO.Size = New System.Drawing.Size(41, 19)
        Me.FilterNO.TabIndex = 82
        Me.FilterNO.TabStop = True
        Me.FilterNO.Text = "No"
        Me.FilterNO.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1, 7)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Show?"
        '
        'FilterYES
        '
        Me.FilterYES.AutoSize = True
        Me.FilterYES.Location = New System.Drawing.Point(49, 5)
        Me.FilterYES.Name = "FilterYES"
        Me.FilterYES.Size = New System.Drawing.Size(45, 19)
        Me.FilterYES.TabIndex = 81
        Me.FilterYES.TabStop = True
        Me.FilterYES.Text = "Yes"
        Me.FilterYES.UseVisualStyleBackColor = True
        '
        'EmployeeSEQTableAdapter
        '
        Me.EmployeeSEQTableAdapter.ClearBeforeFill = True
        '
        'LoadByPanel
        '
        Me.LoadByPanel.Controls.Add(Me.Filters)
        Me.LoadByPanel.Controls.Add(Me.ID)
        Me.LoadByPanel.Location = New System.Drawing.Point(268, 29)
        Me.LoadByPanel.Name = "LoadByPanel"
        Me.LoadByPanel.Size = New System.Drawing.Size(98, 23)
        Me.LoadByPanel.TabIndex = 82
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
        Me.Label13.Location = New System.Drawing.Point(199, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 15)
        Me.Label13.TabIndex = 81
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
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(199, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 15)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "User Name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(199, 346)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 15)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Password:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(199, 381)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 15)
        Me.Label14.TabIndex = 85
        Me.Label14.Text = "Access Type:"
        '
        'UserName
        '
        Me.UserName.Location = New System.Drawing.Point(286, 308)
        Me.UserName.MaxLength = 20
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(100, 20)
        Me.UserName.TabIndex = 87
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(286, 343)
        Me.Password.MaxLength = 15
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(100, 20)
        Me.Password.TabIndex = 88
        '
        'AccessType
        '
        Me.AccessType.FormattingEnabled = True
        Me.AccessType.Items.AddRange(New Object() {"Administrator", "Technician", "Report Generator"})
        Me.AccessType.Location = New System.Drawing.Point(286, 378)
        Me.AccessType.Name = "AccessType"
        Me.AccessType.Size = New System.Drawing.Size(100, 21)
        Me.AccessType.TabIndex = 89
        '
        'Employees_Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 459)
        Me.Controls.Add(Me.AccessType)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LoadByPanel)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LoadPanel)
        Me.Controls.Add(Me.PListName)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SeqNum)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Lname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NO)
        Me.Controls.Add(Me.YES)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Fname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fwd)
        Me.Controls.Add(Me.bck)
        Me.Controls.Add(Me.EmpID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Employees_Maintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employees Maintenance"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PERS0BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoadPanel.ResumeLayout(False)
        Me.LoadPanel.PerformLayout()
        CType(Me.EmployeeSEQBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Employees As System.Windows.Forms.ListBox
    Friend WithEvents NO As System.Windows.Forms.RadioButton
    Friend WithEvents YES As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents Fname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fwd As System.Windows.Forms.Button
    Friend WithEvents bck As System.Windows.Forms.Button
    Friend WithEvents EmpID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SeqNum As System.Windows.Forms.TextBox
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents PERS0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PERS0TableAdapter As Signalog.SignalogDataSetTableAdapters.PERS0TableAdapter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PListName As System.Windows.Forms.TextBox
    Friend WithEvents LoadPanel As System.Windows.Forms.Panel
    Friend WithEvents FilterNO As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents FilterYES As System.Windows.Forms.RadioButton
    Friend WithEvents FilterBoth As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents FilterLname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents FilterSeq As System.Windows.Forms.ComboBox
    Friend WithEvents SeqAll As System.Windows.Forms.CheckBox
    Friend WithEvents EmployeeSEQBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeSEQTableAdapter As Signalog.SignalogDataSetTableAdapters.EmployeeSEQTableAdapter
    Friend WithEvents LoadByPanel As System.Windows.Forms.Panel
    Friend WithEvents Filters As System.Windows.Forms.RadioButton
    Friend WithEvents ID As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents FilterFname As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LOCKNEWBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKNEWTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKNEWTableAdapter
    Friend WithEvents LOCKEDITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKEDITTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKEDITTableAdapter
    Friend WithEvents ACT0BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ACT0TableAdapter As Signalog.SignalogDataSetTableAdapters.ACT0TableAdapter
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents AccessType As System.Windows.Forms.ComboBox
End Class
