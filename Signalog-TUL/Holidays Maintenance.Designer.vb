<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Holidays_Maintenance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Holidays_Maintenance))
        Me.Filter = New System.Windows.Forms.Panel()
        Me.Year = New System.Windows.Forms.ComboBox()
        Me.HolidayYearBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SignalogDataSet = New Signalog.SignalogDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Holidays = New System.Windows.Forms.ListBox()
        Me.HolidaysBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewButton = New System.Windows.Forms.ToolStripButton()
        Me.EditButton = New System.Windows.Forms.ToolStripButton()
        Me.DeleteButton = New System.Windows.Forms.ToolStripButton()
        Me.UndoButton = New System.Windows.Forms.ToolStripButton()
        Me.Submit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fwd = New System.Windows.Forms.Button()
        Me.bck = New System.Windows.Forms.Button()
        Me.HolidayID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HolidayName = New System.Windows.Forms.ComboBox()
        Me.HolidayListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HolidayDate = New System.Windows.Forms.DateTimePicker()
        Me.HolidaysTableAdapter = New Signalog.SignalogDataSetTableAdapters.HolidaysTableAdapter()
        Me.HolidayYearTableAdapter = New Signalog.SignalogDataSetTableAdapters.HolidayYearTableAdapter()
        Me.Holiday_ListTableAdapter = New Signalog.SignalogDataSetTableAdapters.Holiday_ListTableAdapter()
        Me.LOCKNEWBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCKNEWTableAdapter = New Signalog.SignalogDataSetTableAdapters.LOCKNEWTableAdapter()
        Me.LOCKEDITBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOCKEDITTableAdapter = New Signalog.SignalogDataSetTableAdapters.LOCKEDITTableAdapter()
        Me.Filter.SuspendLayout()
        CType(Me.HolidayYearBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HolidaysBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.HolidayListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCKNEWBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCKEDITBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Filter
        '
        Me.Filter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Filter.Controls.Add(Me.Year)
        Me.Filter.Controls.Add(Me.Label1)
        Me.Filter.Controls.Add(Me.Holidays)
        Me.Filter.Location = New System.Drawing.Point(0, 24)
        Me.Filter.Name = "Filter"
        Me.Filter.Size = New System.Drawing.Size(143, 295)
        Me.Filter.TabIndex = 0
        '
        'Year
        '
        Me.Year.DataSource = Me.HolidayYearBindingSource
        Me.Year.DisplayMember = "Year"
        Me.Year.FormattingEnabled = True
        Me.Year.Location = New System.Drawing.Point(63, 3)
        Me.Year.Name = "Year"
        Me.Year.Size = New System.Drawing.Size(75, 21)
        Me.Year.TabIndex = 64
        Me.Year.ValueMember = "Year"
        '
        'HolidayYearBindingSource
        '
        Me.HolidayYearBindingSource.DataMember = "HolidayYear"
        Me.HolidayYearBindingSource.DataSource = Me.SignalogDataSet
        '
        'SignalogDataSet
        '
        Me.SignalogDataSet.DataSetName = "SignalogDataSet"
        Me.SignalogDataSet.EnforceConstraints = False
        Me.SignalogDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Year:"
        '
        'Holidays
        '
        Me.Holidays.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Holidays.DataSource = Me.HolidaysBindingSource
        Me.Holidays.DisplayMember = "Holiday Name"
        Me.Holidays.FormattingEnabled = True
        Me.Holidays.Location = New System.Drawing.Point(-1, 29)
        Me.Holidays.Name = "Holidays"
        Me.Holidays.Size = New System.Drawing.Size(140, 264)
        Me.Holidays.TabIndex = 5
        Me.Holidays.ValueMember = "Holiday Name"
        '
        'HolidaysBindingSource
        '
        Me.HolidaysBindingSource.DataMember = "Holidays"
        Me.HolidaysBindingSource.DataSource = Me.SignalogDataSet
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(17, 17)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewButton, Me.EditButton, Me.DeleteButton, Me.UndoButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(387, 25)
        Me.ToolStrip1.TabIndex = 4
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
        'Submit
        '
        Me.Submit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Submit.Location = New System.Drawing.Point(231, 283)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(75, 23)
        Me.Submit.TabIndex = 60
        Me.Submit.Text = "Submit"
        Me.Submit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Holiday Name:"
        '
        'fwd
        '
        Me.fwd.Location = New System.Drawing.Point(352, 30)
        Me.fwd.Name = "fwd"
        Me.fwd.Size = New System.Drawing.Size(27, 23)
        Me.fwd.TabIndex = 57
        Me.fwd.Text = ">>"
        Me.fwd.UseVisualStyleBackColor = True
        '
        'bck
        '
        Me.bck.Location = New System.Drawing.Point(319, 30)
        Me.bck.Name = "bck"
        Me.bck.Size = New System.Drawing.Size(27, 23)
        Me.bck.TabIndex = 56
        Me.bck.Text = "<<"
        Me.bck.UseVisualStyleBackColor = True
        '
        'HolidayID
        '
        Me.HolidayID.Location = New System.Drawing.Point(231, 32)
        Me.HolidayID.Name = "HolidayID"
        Me.HolidayID.Size = New System.Drawing.Size(60, 20)
        Me.HolidayID.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Holiday ID:"
        '
        'HolidayName
        '
        Me.HolidayName.DataSource = Me.HolidayListBindingSource
        Me.HolidayName.DisplayMember = "Holiday Name"
        Me.HolidayName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.HolidayName.FormattingEnabled = True
        Me.HolidayName.Location = New System.Drawing.Point(231, 67)
        Me.HolidayName.Name = "HolidayName"
        Me.HolidayName.Size = New System.Drawing.Size(144, 21)
        Me.HolidayName.TabIndex = 61
        Me.HolidayName.ValueMember = "Holiday Name"
        '
        'HolidayListBindingSource
        '
        Me.HolidayListBindingSource.DataMember = "Holiday List"
        Me.HolidayListBindingSource.DataSource = Me.SignalogDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 15)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Holiday Date:"
        '
        'HolidayDate
        '
        Me.HolidayDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HolidayDate.Location = New System.Drawing.Point(231, 101)
        Me.HolidayDate.Name = "HolidayDate"
        Me.HolidayDate.Size = New System.Drawing.Size(103, 20)
        Me.HolidayDate.TabIndex = 63
        '
        'HolidaysTableAdapter
        '
        Me.HolidaysTableAdapter.ClearBeforeFill = True
        '
        'HolidayYearTableAdapter
        '
        Me.HolidayYearTableAdapter.ClearBeforeFill = True
        '
        'Holiday_ListTableAdapter
        '
        Me.Holiday_ListTableAdapter.ClearBeforeFill = True
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
        'Holidays_Maintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 318)
        Me.Controls.Add(Me.HolidayDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.HolidayName)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fwd)
        Me.Controls.Add(Me.bck)
        Me.Controls.Add(Me.HolidayID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Filter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Holidays_Maintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Holidays Maintenance"
        Me.Filter.ResumeLayout(False)
        Me.Filter.PerformLayout()
        CType(Me.HolidayYearBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SignalogDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HolidaysBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.HolidayListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCKNEWBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCKEDITBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Filter As System.Windows.Forms.Panel
    Friend WithEvents Holidays As System.Windows.Forms.ListBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NewButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents EditButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents DeleteButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents UndoButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Submit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fwd As System.Windows.Forms.Button
    Friend WithEvents bck As System.Windows.Forms.Button
    Friend WithEvents HolidayID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HolidayName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents HolidayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents SignalogDataSet As Signalog.SignalogDataSet
    Friend WithEvents HolidaysBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HolidaysTableAdapter As Signalog.SignalogDataSetTableAdapters.HolidaysTableAdapter
    Friend WithEvents Year As System.Windows.Forms.ComboBox
    Friend WithEvents HolidayYearBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HolidayYearTableAdapter As Signalog.SignalogDataSetTableAdapters.HolidayYearTableAdapter
    Friend WithEvents HolidayListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Holiday_ListTableAdapter As Signalog.SignalogDataSetTableAdapters.Holiday_ListTableAdapter
    Friend WithEvents LOCKNEWBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKNEWTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKNEWTableAdapter
    Friend WithEvents LOCKEDITBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCKEDITTableAdapter As Signalog.SignalogDataSetTableAdapters.LOCKEDITTableAdapter
End Class
