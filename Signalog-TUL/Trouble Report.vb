'**************************************************************************************************
'**************************************************************************************************
'**  This software is the property of:
'**  Traffic & Lighting Systems, LLC.
'**  13305 N. SANTA FE
'**  OKLAHOMA CITY, OKLAHOMA 73114
'**  Phone (405) 524-1341
'**  FAX (405) 524-2386
'**************************************************************************************************
'**  Copyright 2009, 2010 - Traffic & Lighting Systems, LLC.
'**************************************************************************************************
'**  Traffic & Lighting Systems, LLC. reserves all rights in the Program as delivered.  
'**  The Program or any portion thereof may not be reproduced in any form whatsoever
'**  except as provided by license without the written consent of Traffic & Lighting Systems, LLC.  
'**  A license under Traffic & Lighting Systems, LLC.’s rights in the Program may be available 
'**  directly from Traffic & Lighting Systems, LLC.
'**************************************************************************************************
'**************************************************************************************************
Imports System.Data.SqlTypes
Public Class Trouble_Report
    Public TxtDynamic As TextBox
    Public LblDynamic As Label
    Dim PanelDynamic As Panel
    Dim ChkBoxDynamic As CheckBox
    Dim RadButDynamic As RadioButton
    Dim LabelDynamic As Label
    Dim ComboBoxDynamic As ComboBox
    Public Area, EWLOC, NSLOC, editable, sh, acthrs As String
    Dim EMPNUM, DISPNUM, LOCNUM, records(0 To 4) As Integer
    Public PartSrc As Integer
    Public Arr_Con_Code(0 To 9, 0 To 6) As String     '(i,6) is reserved for memo
    Public Act_Tak_Code(0 To 9, 0 To 6) As String
    Public Def_Act_Code(0 To 9, 0 To 6) As String
    Public Dep_Con_Code(0 To 9, 0 To 6) As String
    Public Prob_Rep_Code(0 To 9, 0 To 6) As String
    Public PartInsID(0 To 9, 0 To 3), PartRemID(0 To 9, 0 To 2), PartsIns, PartsRem, PartsRemStat(0 To 9) As Double  'PartsIns and PartsRem for loading
    Public PartInsMemo(0 To 9), PartRemMemo(0 To 9) As String
    Public PartInsWareHouse(0 To 9), PartRemWareHouse(0 To 9) As String
    Public PrevPartID As Integer  'Used to see if user changes part when editing or only changes other values such as quantity,cost,memo,status
    Public prevpartwarehouse As String
    Public EquipADorRM As Boolean   '1 if add equip, 0 if remove equip
    Dim EditRecord, NewRecord, EditSecondPart As Boolean
    Public NewReportedBy, NewEnterBy, NewVehNum, NewArea, NewEWLOC, NewNSLOC As Boolean
    Dim PreviousID As Integer   'To restore PreviousID when Undo Button is clicked
    Public RepProbEdit, ArrConEdit, ActTakEdit, DefActEdit, DepConEdit As Boolean
    Public CommitEdit As Boolean   'When a record is selected for editing
    Public EditPartNum, EditPartType, EditPartSrc As Integer   'Store part # to be edited/deleted ,Part installed or removed,local or city owned,edit part group number in act3
    Public DeletePart As Boolean   'To diffrentiaite between edit and delete for the Edit_Delete Part form
    Public PartInsGroupNum(0 To 9), PartRemGroupNum(0 To 9) As Integer  'keep track of part group num (used for deletion purposes in restore status)
    Public UpdatePartStatusCount As Integer
    Public UpdatePartStatus(0 To 9, 0 To 3) As String  'Store parts that need status update, 0:Local/City Owned, 1:PartID, 2:New Status, 3:WareHouse
    Dim Default_Size As Boolean 'used to restore default size when changing to windowsstate.normal

    Private Sub Trouble_Report_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Submit.Enabled = True Then
            If MsgBox("Are you sure you want to exit without saving changes?", MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                UndoButton.PerformClick()
                e.Cancel = False
                Me.Dispose()   '????   Releasing memory resources upon closing the form
                GC.Collect()   '????
            End If
        End If
    End Sub

    Private Sub Trouble_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtactnum.Text = String.Empty
        Call Load_Activity()

        EMPNUM = 0
        DISPNUM = 0
        LOCNUM = 0
        EWLOC = String.Empty
        NSLOC = String.Empty
        Area = String.Empty
        sh = String.Empty
        acthrs = String.Empty
        YES.Checked = False
        NO.Checked = False

        Me.LOC0TableAdapter.Fill(Me.SignalogDataSet.LOC0)
        Me.PERS0TableAdapter.Fill(Me.SignalogDataSet.PERS0)
        Me.CUS0TableAdapter.Fill(Me.SignalogDataSet.CUS0)
        Me.DISP0TableAdapter.Fill(Me.SignalogDataSet.DISP0)
        Me.ACT0TableAdapter.Fill(Me.SignalogDataSet.ACT0)
        Me.HolidaysTableAdapter.Fill(Me.SignalogDataSet.Holidays)
        Me.VEHICLETableAdapter.Fill(Me.SignalogDataSet.VEHICLE)

        Dim i, j As Integer

        For i = 0 To 9
            For j = 0 To 6
                Arr_Con_Code(i, j) = String.Empty
                Act_Tak_Code(i, j) = String.Empty
                Def_Act_Code(i, j) = String.Empty
                Dep_Con_Code(i, j) = String.Empty
                Prob_Rep_Code(i, j) = String.Empty
            Next j
            For j = 0 To 3
                PartInsID(i, j) = 0
            Next j
            For j = 0 To 2
                PartRemID(i, j) = 0
            Next j
            PartsRemStat(i) = 0
            PartInsGroupNum(i) = 0
            PartRemGroupNum(i) = 0
            PartInsMemo(i) = String.Empty
            PartRemMemo(i) = String.Empty
            PartInsWareHouse(i) = String.Empty
            PartRemWareHouse(i) = String.Empty
        Next i

        EnterBy.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        RcvDate.Enabled = False
        RcvTime.Enabled = False
        ReportedBy.Enabled = False
        CityAgency.Enabled = False
        EWLOCBox.Enabled = False
        NSLOCBox.Enabled = False
        PhoneNum.Enabled = False
        RepByName.Enabled = False
        ProbRepPanel.Enabled = False
        ArrConPanel.Enabled = False
        ActTakPanel.Enabled = False
        DefActPanel.Enabled = False
        DepConPanel.Enabled = False
        EquipInsPanel.Enabled = False
        EquipRemPanel.Enabled = False
        DateTimePanel.Enabled = False
        ActHrsYes.Checked = False
        ActHrsNo.Checked = False
        TechnicianPanel.Enabled = False
        Submit.Enabled = False

        NewReportedBy = False
        NewEnterBy = False
        NewVehNum = False
        NewArea = False
        NewEWLOC = False
        NewNSLOC = False

        UndoButton.Enabled = False
        DeleteButton.Enabled = False
        EditButton.Enabled = False
        NewRecord = False

        EditRecord = False
        EditSecondPart = False

        CommitEdit = False

        EditPartNum = 0
        EditPartType = 0
        EditPartSrc = 0
        DeletePart = False

        UpdatePartStatusCount = 0

        For i = 0 To 9
            For j = 0 To 2
                UpdatePartStatus(i, j) = 0
            Next
        Next

        Panel1.Width = ToolStrip1.Width
        ProbRepPanel.Width = ToolStrip1.Width
        ArrConPanel.Width = ToolStrip1.Width
        ActTakPanel.Width = ToolStrip1.Width
        DefActPanel.Width = ToolStrip1.Width
        DepConPanel.Width = ToolStrip1.Width
        EquipInsPanel.Width = ToolStrip1.Width
        EquipRemPanel.Width = ToolStrip1.Width
        DateTimePanel.Width = ToolStrip1.Width
        TechnicianPanel.Width = ToolStrip1.Width
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub ReportedProblemGrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ReportedProblemGrid.CellDoubleClick
        If ReportedProblemGrid.CurrentRow.IsNewRow = False Then   'If editing a record (not new record)
            RepProbEdit = True
        Else
            RepProbEdit = False
        End If
        Problem_Reported.ShowDialog()
    End Sub

    Private Sub ReportedProblemGrid_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles ReportedProblemGrid.UserDeletingRow
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to delete this reported problem entry?", MsgBoxStyle.YesNo, "Delete Row?")
        If result = MsgBoxResult.Yes Then
            If (ReportedProblemGrid.Rows.Count - 1) > 1 And (ReportedProblemGrid.CurrentRow.Index + 1) <> (ReportedProblemGrid.Rows.Count - 1) Then
                For i = (ReportedProblemGrid.CurrentRow.Index + 1) To (ReportedProblemGrid.Rows.Count - 2)  'shift records to take deleted record place
                    For j = 0 To 6
                        Prob_Rep_Code(i - 1, j) = Prob_Rep_Code(i, j)
                    Next j
                Next i
                For j = 0 To 6  'empty last record
                    Prob_Rep_Code(ReportedProblemGrid.Rows.Count - 2, j) = String.Empty
                Next j
            Else
                For j = 0 To 6   'delete first(and only record) or last record in panel without shifting
                    Prob_Rep_Code(ReportedProblemGrid.CurrentRow.Index, j) = String.Empty
                Next j
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ReportedProblemGrid_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles ReportedProblemGrid.UserDeletedRow
        ReportedProblemGrid.CurrentRow.Selected = False
    End Sub

    Private Sub ArrivalConditionGrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ArrivalConditionGrid.CellDoubleClick
        If ArrivalConditionGrid.CurrentRow.IsNewRow = False Then   'If editing a record (not new record)
            ArrConEdit = True
        Else
            ArrConEdit = False
        End If
        Arrival_Condition.ShowDialog()
    End Sub

    Private Sub ArrivalConditionGrid_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles ArrivalConditionGrid.UserDeletingRow
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to delete this arrival condition entry?", MsgBoxStyle.YesNo, "Delete Row?")
        If result = MsgBoxResult.Yes Then
            If (ArrivalConditionGrid.Rows.Count - 1) > 1 And (ArrivalConditionGrid.CurrentRow.Index + 1) <> (ArrivalConditionGrid.Rows.Count - 1) Then
                For i = (ArrivalConditionGrid.CurrentRow.Index + 1) To (ArrivalConditionGrid.Rows.Count - 2)  'shift records to take deleted record place
                    For j = 0 To 6
                        Arr_Con_Code(i - 1, j) = Arr_Con_Code(i, j)
                    Next j
                Next i
                For j = 0 To 6  'empty last record
                    Arr_Con_Code(ArrivalConditionGrid.Rows.Count - 2, j) = String.Empty
                Next j
            Else
                For j = 0 To 6   'delete first(and only record) or last record in panel without shifting
                    Arr_Con_Code(ArrivalConditionGrid.CurrentRow.Index, j) = String.Empty
                Next j
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ArrivalConditionGrid_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles ArrivalConditionGrid.UserDeletedRow
        ArrivalConditionGrid.CurrentRow.Selected = False
    End Sub

    Private Sub ActionTakenGrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ActionTakenGrid.CellDoubleClick
        If ActionTakenGrid.CurrentRow.IsNewRow = False Then   'If editing a record (not new record)
            ActTakEdit = True
        Else
            ActTakEdit = False
        End If
        Action_Taken.ShowDialog()
    End Sub

    Private Sub ActionTakenGrid_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles ActionTakenGrid.UserDeletingRow
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to delete this action taken entry?", MsgBoxStyle.YesNo, "Delete Row?")
        If result = MsgBoxResult.Yes Then
            If (ActionTakenGrid.Rows.Count - 1) > 1 And (ActionTakenGrid.CurrentRow.Index + 1) <> (ActionTakenGrid.Rows.Count - 1) Then
                For i = (ActionTakenGrid.CurrentRow.Index + 1) To (ActionTakenGrid.Rows.Count - 2)  'shift records to take deleted record place
                    For j = 0 To 6
                        Act_Tak_Code(i - 1, j) = Act_Tak_Code(i, j)
                    Next j
                Next i
                For j = 0 To 6  'empty last record
                    Act_Tak_Code(ActionTakenGrid.Rows.Count - 2, j) = String.Empty
                Next j
            Else
                For j = 0 To 6   'delete first(and only record) or last record in panel without shifting
                    Act_Tak_Code(ActionTakenGrid.CurrentRow.Index, j) = String.Empty
                Next j
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ActionTakenGrid_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles ActionTakenGrid.UserDeletedRow
        ActionTakenGrid.CurrentRow.Selected = False
    End Sub

    Private Sub DeferredActionGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DeferredActionGrid.DoubleClick
        If DeferredActionGrid.CurrentRow.IsNewRow = False Then   'If editing a record (not new record)
            DefActEdit = True
        Else
            DefActEdit = False
        End If
        Deferred_Action.ShowDialog()
    End Sub

    Private Sub DeferredActionGrid_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DeferredActionGrid.UserDeletingRow
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to delete this deferred action entry?", MsgBoxStyle.YesNo, "Delete Row?")
        If result = MsgBoxResult.Yes Then
            If (DeferredActionGrid.Rows.Count - 1) > 1 And (DeferredActionGrid.CurrentRow.Index + 1) <> (DeferredActionGrid.Rows.Count - 1) Then
                For i = (DeferredActionGrid.CurrentRow.Index + 1) To (DeferredActionGrid.Rows.Count - 2)  'shift records to take deleted record place
                    For j = 0 To 6
                        Def_Act_Code(i - 1, j) = Def_Act_Code(i, j)
                    Next j
                Next i
                For j = 0 To 6  'empty last record
                    Def_Act_Code(DeferredActionGrid.Rows.Count - 2, j) = String.Empty
                Next j
            Else
                For j = 0 To 6   'delete first(and only record) or last record in panel without shifting
                    Def_Act_Code(DeferredActionGrid.CurrentRow.Index, j) = String.Empty
                Next j
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub DeferredActionGrid_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DeferredActionGrid.UserDeletedRow
        DeferredActionGrid.CurrentRow.Selected = False
    End Sub

    Private Sub DepartingConditionNotesGrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DepartingConditionNotesGrid.CellDoubleClick
        If DepartingConditionNotesGrid.CurrentRow.IsNewRow = False Then   'If editing a record (not new record)
            DepConEdit = True
        Else
            DepConEdit = False
        End If
        Departing_Condition_Notes.ShowDialog()
    End Sub

    Private Sub DepartingConditionNotesGrid_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DepartingConditionNotesGrid.UserDeletingRow
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to delete this departing condition notes entry?", MsgBoxStyle.YesNo, "Delete Row?")
        If result = MsgBoxResult.Yes Then
            If (DepartingConditionNotesGrid.Rows.Count - 1) > 1 And (DepartingConditionNotesGrid.CurrentRow.Index + 1) <> (DepartingConditionNotesGrid.Rows.Count - 1) Then
                For i = (DepartingConditionNotesGrid.CurrentRow.Index + 1) To (DepartingConditionNotesGrid.Rows.Count - 2)  'shift records to take deleted record place
                    For j = 0 To 6
                        Dep_Con_Code(i - 1, j) = Dep_Con_Code(i, j)
                    Next j
                Next i
                For j = 0 To 6  'empty last record
                    Dep_Con_Code(DepartingConditionNotesGrid.Rows.Count - 2, j) = String.Empty
                Next j
            Else
                For j = 0 To 6   'delete first(and only record) or last record in panel without shifting
                    Dep_Con_Code(DepartingConditionNotesGrid.CurrentRow.Index, j) = String.Empty
                Next j
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub DepartingConditionNotesGrid_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DepartingConditionNotesGrid.UserDeletedRow
        DepartingConditionNotesGrid.CurrentRow.Selected = False
    End Sub

    Private Sub EquipInstalledGrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EquipInstalledGrid.CellDoubleClick
        EquipADorRM = True   'Determine if Equipment installed or removed entry
        If EquipInstalledGrid.CurrentRow.IsNewRow = False Then   'If editing a record (not new record)
            CommitEdit = True
            EditPartSrc = PartInsID(EquipInstalledGrid.CurrentRow.Index, 0)
            EditPartType = 1
            EditPartNum = EquipInstalledGrid.CurrentRow.Index + 1
        End If
        Parts.ShowDialog()
    End Sub

    Private Sub EquipInstalledGrid_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles EquipInstalledGrid.UserDeletingRow
        EditPartType = 1   'Installed
        DeletePart = True

        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to delete this equipment installed entry?", MsgBoxStyle.YesNo, "Delete Row?")
        If result = MsgBoxResult.Yes Then
            Dim PartID As Integer
            Dim WareHouse As String

            EditPartSrc = PartInsID(EquipInstalledGrid.CurrentRow.Index, 0)

            PartID = PartInsID(EquipInstalledGrid.CurrentRow.Index, 1)
            WareHouse = PartInsWareHouse(EquipInstalledGrid.CurrentRow.Index)
            If EditPartSrc = 1 Then  'Local
                If EQUIPMENTTableAdapter.ReturnPartDesc(PartID, WareHouse) <> "Miscellaneous" Then   'Not the specaial case
                    If EQUIPMENTTableAdapter.ReturnSerial(PartID, WareHouse) = "None" Then  'Deleting a non-Unique
                        Restore_Status.DeleteRecord()
                    Else  'Deleting a unique part
                        If ACT3TableAdapter.PartExistsInDatabase(txtactnum.Text, EditPartType, EquipInstalledGrid.CurrentRow.Index + 1, PartID) <> 0 Then  'written to database
                            'Delete & restore status
                            Restore_Status.ShowDialog()
                        Else   'Not written to database yet  (don't restore status because it has not changed in the first place)
                            'Only delete
                            Restore_Status.DeleteRecord()
                        End If

                    End If
                Else  'If the special case "Miscellaneous"
                    Restore_Status.DeleteRecord()
                End If
            ElseIf EditPartSrc = 2 Then   'City Owned
                If EQUIPMENT2TableAdapter.ReturnPartDesc(PartID) <> "Miscellaneous" Then   'Not the specaial case
                    If EQUIPMENT2TableAdapter.ReturnSerial(PartID) = "None" Then  'Deleting a non-Unique
                        Restore_Status.DeleteRecord()
                    Else  'Deleting a unique part
                        If ACT3TableAdapter.PartExistsInDatabase(txtactnum.Text, EditPartType, EquipInstalledGrid.CurrentRow.Index + 1, PartID) <> 0 Then  'written to database
                            Restore_Status.ShowDialog()
                        Else    'Not written to dartabase yet  (don't restore status because it has not changed in the first place)
                            Restore_Status.DeleteRecord()
                        End If
                    End If
                Else  'If the special case "Miscellaneous"
                    Restore_Status.DeleteRecord()
                End If
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub EquipInstalledGrid_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles EquipInstalledGrid.UserDeletedRow
        EquipInstalledGrid.CurrentRow.Selected = False
    End Sub

    Private Sub EquipRemovedGrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EquipRemovedGrid.CellDoubleClick
        EquipADorRM = False   'Determine if Equipment installed or removed entry
        If EquipRemovedGrid.CurrentRow.IsNewRow = False Then   'If editing a record (not new record)
            CommitEdit = True
            EditPartSrc = PartRemID(EquipRemovedGrid.CurrentRow.Index, 0)
            EditPartType = 2
            EditPartNum = EquipRemovedGrid.CurrentRow.Index + 1
        End If
        Parts.ShowDialog()
    End Sub

    Private Sub EquipRemovedGrid_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles EquipRemovedGrid.UserDeletingRow
        EditPartType = 2   'Removed
        DeletePart = True

        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to delete this equipment removed entry?", MsgBoxStyle.YesNo, "Delete Row?")
        If result = MsgBoxResult.Yes Then
            Dim PartID As Integer
            Dim WareHouse As String
            EditPartSrc = PartRemID(EquipRemovedGrid.CurrentRow.Index, 0)

            PartID = PartRemID(EquipRemovedGrid.CurrentRow.Index, 1)
            WareHouse = PartRemWareHouse(EquipRemovedGrid.CurrentRow.Index)
            If EditPartSrc = 1 Then  'Local
                If EQUIPMENTTableAdapter.ReturnPartDesc(PartID, WareHouse) <> "Miscellaneous" Then   'Not the specaial case
                    If EQUIPMENTTableAdapter.ReturnSerial(PartID, WareHouse) = "None" Then  'Deleting a non-Unique
                        Restore_Status.DeleteRecord()
                    Else  'Deleting a unique part
                        If ACT3TableAdapter.PartExistsInDatabase(txtactnum.Text, EditPartType, EquipRemovedGrid.CurrentRow.Index + 1, PartID) <> 0 Then  'written to database
                            Restore_Status.ShowDialog()
                        Else    'Not written to dartabase yet  (don't restore status because it has not changed in the first place)
                            Restore_Status.DeleteRecord()
                        End If

                    End If
                Else  'If the special case "Miscellaneous"
                    Restore_Status.DeleteRecord()
                End If
            ElseIf EditPartSrc = 2 Then   'City Owned
                If EQUIPMENT2TableAdapter.ReturnPartDesc(PartID) <> "Miscellaneous" Then   'Not the specaial case
                    If EQUIPMENT2TableAdapter.ReturnSerial(PartID) = "None" Then  'Deleting a non-Unique
                        Restore_Status.DeleteRecord()
                    Else  'Deleting a unique part
                        If ACT3TableAdapter.PartExistsInDatabase(txtactnum.Text, EditPartType, EquipRemovedGrid.CurrentRow.Index + 1, PartID) <> 0 Then  'written to database
                            Restore_Status.ShowDialog()
                        Else    'Not written to dartabase yet  (don't restore status because it has not changed in the first place)
                            Restore_Status.DeleteRecord()
                        End If
                    End If
                Else  'If the special case "Miscellaneous"
                    Restore_Status.DeleteRecord()
                End If
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub EquipRemovedGrid_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles EquipRemovedGrid.UserDeletedRow
        EquipRemovedGrid.CurrentRow.Selected = False
    End Sub

    Public Function GetTextboxByName(ByVal name As String, ByVal panel As Panel)
        Dim myVar As Object = Nothing
        For Each ctrl As Control In panel.Controls
            If TypeOf ctrl Is TextBox Then
                If ctrl.Name = name Then
                    myVar = ctrl
                End If
            End If
        Next
        Return myVar
    End Function

    Public Function GetLabelByName(ByVal name As String, ByVal panel As Panel)
        Dim myVar As Object = Nothing
        For Each ctrl As Control In panel.Controls
            If TypeOf ctrl Is Label Then
                If ctrl.Name = name Then
                    myVar = ctrl
                End If
            End If
        Next
        Return myVar
    End Function

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Dim i As Integer
        Dim ed As String
        Dim chgdate, actdate As Date
        Dim chgtime, acttime As System.TimeSpan
        Dim chgby As String = ""
        Dim ndate As Date
        ndate = Nothing
        Dim Q As Integer
        Dim flag As Boolean
        flag = True

        If (NewRecord = False And EditRecord = False) Or (EditRecord = True And EditSecondPart = True) Then  'Store second Part  
            ed = "N"
            If ArrivalConditionGrid.Rows.Count = 1 And ArrivalConditionGrid.Rows(0).Cells(0).Value = String.Empty Then
                MsgBox("Please enter arrival condition", MsgBoxStyle.Exclamation, "Missing Field")
                flag = False
            ElseIf ActionTakenGrid.Rows.Count = 1 And ActionTakenGrid.Rows(0).Cells(0).Value = String.Empty Then
                MsgBox("Please enter action taken", MsgBoxStyle.Exclamation, "Missing Field")
                flag = False
            ElseIf DeferredActionGrid.Rows.Count = 1 And DeferredActionGrid.Rows(0).Cells(0).Value = String.Empty Then
                MsgBox("Please enter deferred action", MsgBoxStyle.Exclamation, "Missing Field")
                flag = False
            ElseIf DepartingConditionNotesGrid.Rows.Count = 1 And DepartingConditionNotesGrid.Rows(0).Cells(0).Value = String.Empty Then
                MsgBox("Please enter departing condition notes", MsgBoxStyle.Exclamation, "Missing Field")
                flag = False
            ElseIf VehNum.Text = String.Empty Then
                MsgBox("Please select Vehicle Number", MsgBoxStyle.Exclamation, "Missing Field")
                flag = False
            ElseIf BegMil.Text = "" Then
                MsgBox("Please enter BegMil", MsgBoxStyle.Exclamation, "Missing Field")
                flag = False
            ElseIf EndMil.Text = "" Then
                MsgBox("Please enter EndMil", MsgBoxStyle.Exclamation, "Missing Field")
                flag = False
            ElseIf Technician.Text = String.Empty Then
                MsgBox("Please select Technician", MsgBoxStyle.Exclamation, "Missing Field")
                flag = False
            ElseIf EndDate.Value.Date < BegDate.Value.Date Then
                MsgBox("End Work Date can't be less than Begin Work Date", MsgBoxStyle.Exclamation, "Warning")
                flag = False
            ElseIf BegDate.Value.Date = EndDate.Value.Date And EndTime.Value.Hour < BegTime.Value.Hour Then
                MsgBox("End Work Time can't be less than Begin Work Time", MsgBoxStyle.Exclamation, "Warning")
                flag = False
            ElseIf RegHrstxt.Text = "" Then
                MsgBox("Please enter regular hours worked", MsgBoxStyle.Exclamation, "Missing Field")
                flag = False
            ElseIf RegRatetxt.Text = "" Then
                MsgBox("Please enter regular rate", MsgBoxStyle.Exclamation, "Missing Field")
                flag = False
            ElseIf RegAmttxt.Text = "" Then
                MsgBox("Please enter regular amount", MsgBoxStyle.Exclamation, "Missing Field")
                flag = False
            ElseIf OTHrstxt.Text = "" Then
                MsgBox("Please enter over time hours worked", MsgBoxStyle.Exclamation, "Missing Field")
                flag = False
            ElseIf OTRatetxt.Text = "" Then
                MsgBox("Please enter over time rate", MsgBoxStyle.Exclamation, "Missing Field")
                flag = False
            ElseIf OTAmttxt.Text = "" Then
                MsgBox("Please enter over time amount", MsgBoxStyle.Exclamation, "Missing Field")
                flag = False
            Else

                If EditRecord = True Then
                    chgdate = ACT0TableAdapter.ReturnCHGDATE(txtactnum.Text)
                    chgtime = ACT0TableAdapter.ReturnCHGTIME(txtactnum.Text)
                    Try  'If trouble report has not been changed yet, the next SQLcmd will return Null
                        chgby = ACT0TableAdapter.ReturnCHGBY(txtactnum.Text)
                    Catch
                    End Try
                    actdate = ACT0TableAdapter.ReturnACTDATE(txtactnum.Text)
                    acttime = ACT0TableAdapter.ReturnACTTIME(txtactnum.Text)
                    'Delete existing records in order to write the new updated ones
                    ACT0TableAdapter.DELETE_ACTNUM(txtactnum.Text)
                    ACT1TableAdapter.DELETE_ACTNUM(txtactnum.Text)
                    ACT2TableAdapter.DeleteAtACTNUM(txtactnum.Text)
                    ACT9TableAdapter.DeleteAtACTNUM(txtactnum.Text)
                    'Restoring quantity of previous installed local parts to stock before deducting from stock after resubmitting from array
                    Dim PartID As Integer
                    Dim WareHouse As String
                    For i = 1 To ACT3TableAdapter.ReturnRecords(txtactnum.Text, 1)    'Installed
                        If ACT3TableAdapter.ReturnSrc(txtactnum.Text, 1, i) = 1 Then    'Local
                            PartID = ACT3TableAdapter.ReturnPartID(txtactnum.Text, 1, i)
                            WareHouse = ACT3TableAdapter.ReturnWareHouse(txtactnum.Text, 1, i)
                            If EQUIPMENTTableAdapter.ReturnPartDesc(PartID, WareHouse) <> "Miscellaneous" Then 'Not the special case
                                If EQUIPMENTTableAdapter.ReturnSerial(PartID, WareHouse) = "None" Then  'A non-Unique
                                    Q = EQUIPMENTTableAdapter.ReturnQuantityAtID(PartID, WareHouse)
                                    Q += ACT3TableAdapter.ReturnQuantity(txtactnum.Text, 1, i)
                                    EQUIPMENTTableAdapter.UpdateQuantity(Q, PartID, WareHouse)
                                End If
                            End If
                        End If
                    Next i
                    ACT3TableAdapter.DeleteAtACTNUM(txtactnum.Text)
                    StockControlTableAdapter.DeleteAtACTNUM(txtactnum.Text)
                End If

                ACT0TableAdapter.DELETE_ACTNUM(txtactnum.Text)
                LOCNUM = LOC0TableAdapter.ReturnLOCNUM(Area, EWLOCBox.Text, NSLOCBox.Text)

                If YES.Checked = True Then
                    sh = "Y"
                Else
                    sh = "N"
                End If

                If NewRecord = False And EditRecord = False Then   'Filling second part
                    ACT0TableAdapter.Insert(txtactnum.Text, DateTime.Now.Date, DateTime.Now.TimeOfDay, EnterBy.Text, chgdate, chgtime, chgby, "", EMPNUM _
                                            , VehNum.SelectedValue, RcvDate.Text, RcvTime.Value.TimeOfDay, DISPNUM, LOCNUM _
                                            , BegDate.Value.Date, BegTime.Value.TimeOfDay, EndDate.Value.Date, EndTime.Value.TimeOfDay _
                                            , BegMil.Text, EndMil.Text, ArrDate.Value.Date, ArrTime.Value.TimeOfDay, DepDate.Value.Date _
                                            , DepTime.Value.TimeOfDay, PhoneNum.Text, ed, RepByName.Text, sh)

                ElseIf EditRecord = True And EditSecondPart = True Then    'Editing second part
                    ACT0TableAdapter.Insert(txtactnum.Text, actdate, acttime, EnterBy.Text, DateTime.Now.Date, DateTime.Now.TimeOfDay _
                                            , PERS0TableAdapter.ReturnPListNameAtUserName(Login.User), "", EMPNUM _
                                           , VehNum.SelectedValue, RcvDate.Text, RcvTime.Value.TimeOfDay, DISPNUM, LOCNUM _
                                           , BegDate.Value.Date, BegTime.Value.TimeOfDay, EndDate.Value.Date, EndTime.Value.TimeOfDay _
                                           , BegMil.Text, EndMil.Text, ArrDate.Value.Date, ArrTime.Value.TimeOfDay, DepDate.Value.Date _
                                           , DepTime.Value.TimeOfDay, PhoneNum.Text, ed, RepByName.Text, sh)
                End If
                '-----------------------------------------------------------------------------------------------------------------------------------------------
                If EditRecord = True Then
                    'Problem reported
                    For i = 0 To ReportedProblemGrid.Rows.Count - 2
                        ACT1TableAdapter.Insert(txtactnum.Text, 1, Prob_Rep_Code(i, 0), Prob_Rep_Code(i, 1), Prob_Rep_Code(i, 2) _
                                                  , Prob_Rep_Code(i, 3), Prob_Rep_Code(i, 4), Prob_Rep_Code(i, 5), i + 1)
                        If Prob_Rep_Code(i, 6) <> String.Empty Then 'MEMO (MEMO is stored in the 6th column)
                            ACT2TableAdapter.Insert(txtactnum.Text, 1, "Reported Problem: " & Prob_Rep_Code(i, 6), i + 1)
                        End If
                    Next i
                    LOCKEDITTableAdapter.DeleteAtDescValue("TroubleReport", txtactnum.Text)   'Release Edit LOCK
                End If

                ReportedProblemGrid.CurrentRow.Selected = False

                'Arrival Condition
                For i = 0 To ArrivalConditionGrid.Rows.Count - 2
                    ACT1TableAdapter.Insert(txtactnum.Text, 2, Arr_Con_Code(i, 0), Arr_Con_Code(i, 1), Arr_Con_Code(i, 2) _
                                              , Arr_Con_Code(i, 3), Arr_Con_Code(i, 4), Arr_Con_Code(i, 5), i + 1)
                    If Arr_Con_Code(i, 6) <> String.Empty Then 'MEMO
                        ACT2TableAdapter.Insert(txtactnum.Text, 2, "Arrival Condition: " & Arr_Con_Code(i, 6), i + 1)
                    End If
                Next i

                ArrivalConditionGrid.CurrentRow.Selected = False

                'Action Taken
                For i = 0 To ActionTakenGrid.Rows.Count - 2
                    ACT1TableAdapter.Insert(txtactnum.Text, 3, Act_Tak_Code(i, 0), Act_Tak_Code(i, 1), Act_Tak_Code(i, 2) _
                                              , Act_Tak_Code(i, 3), Act_Tak_Code(i, 4), Act_Tak_Code(i, 5), i + 1)
                    If Act_Tak_Code(i, 6) <> String.Empty Then 'MEMO
                        ACT2TableAdapter.Insert(txtactnum.Text, 3, "Action Taken: " & Act_Tak_Code(i, 6), i + 1)
                    End If
                Next i

                ActionTakenGrid.CurrentRow.Selected = False

                'Deferred Action
                For i = 0 To DeferredActionGrid.Rows.Count - 2
                    ACT1TableAdapter.Insert(txtactnum.Text, 4, Def_Act_Code(i, 0), Def_Act_Code(i, 1), Def_Act_Code(i, 2) _
                                              , Def_Act_Code(i, 3), Def_Act_Code(i, 4), Def_Act_Code(i, 5), i + 1)
                    If Def_Act_Code(i, 6) <> String.Empty Then 'MEMO
                        ACT2TableAdapter.Insert(txtactnum.Text, 4, "Deferred Action: " & Def_Act_Code(i, 6), i + 1)
                    End If
                Next i

                DeferredActionGrid.CurrentRow.Selected = False

                'Departing Condition
                For i = 0 To DepartingConditionNotesGrid.Rows.Count - 2
                    ACT1TableAdapter.Insert(txtactnum.Text, 5, Dep_Con_Code(i, 0), Dep_Con_Code(i, 1), Dep_Con_Code(i, 2) _
                                              , Dep_Con_Code(i, 3), Dep_Con_Code(i, 4), Dep_Con_Code(i, 5), i + 1)
                    If Dep_Con_Code(i, 6) <> String.Empty Then 'MEMO
                        ACT2TableAdapter.Insert(txtactnum.Text, 5, "Departing Condition: " & Dep_Con_Code(i, 6), i + 1)
                    End If
                Next i

                DepartingConditionNotesGrid.CurrentRow.Selected = False

                '------------------------------------------------------------------------------------------------------------------
                'ACT3 (Equipment Installed & Equipment Removed)
                'Installed
                For i = 0 To EquipInstalledGrid.Rows.Count - 2
                    'Change Status if unique part
                    If PartInsID(i, 0) = 1 Then  'Local 
                        'If Non-Unique part therefore change status to installed otherwise leave it (None for non-unique parts)
                        If EQUIPMENTTableAdapter.ReturnSerial(PartInsID(i, 1), PartInsWareHouse(i)) <> "None" Then
                            EQUIPMENTTableAdapter.UpdateStatus(2, PartInsID(i, 1), PartInsWareHouse(i))
                        Else   'Deduct Non-unique part from Stock (add entry to stock control and adjust quantity in local inventory)
                            If EQUIPMENTTableAdapter.ReturnPartDesc(PartInsID(i, 1), PartInsWareHouse(i)) <> "Miscellaneous" Then  'Don't deduct if part desc=Miscellaneous (special case)
                                StockControlTableAdapter.Insert(StockControlTableAdapter.ReturnMaxID(PartInsWareHouse(i)) + 1, ACT0TableAdapter.ReturnACTDATE(txtactnum.Text) _
                                                                , PartInsID(i, 1), EQUIPMENTTableAdapter.ReturnPartDesc(PartInsID(i, 1), PartInsWareHouse(i)) _
                                                                , txtactnum.Text, PartInsWareHouse(i), "Rem", PartInsID(i, 2), "Installed", i + 1)
                                Q = EQUIPMENTTableAdapter.ReturnQuantityAtID(PartInsID(i, 1), PartInsWareHouse(i))
                                Q -= PartInsID(i, 2)
                                EQUIPMENTTableAdapter.UpdateQuantity(Q, PartInsID(i, 1), PartInsWareHouse(i))
                            End If
                        End If
                    Else   'City Owned  (No Quantity)
                        'If Non-Unique part therefore change status to installed otherwise leave it (None for Misc parts)
                        If EQUIPMENT2TableAdapter.ReturnSerial(PartInsID(i, 1)) <> "None" Then
                            EQUIPMENT2TableAdapter.UpdateStatus(2, PartInsID(i, 1))
                        End If
                    End If
                    ACT3TableAdapter.Insert(txtactnum.Text, PartInsID(i, 1), 1, PartInsID(i, 0), PartInsID(i, 2), PartInsWareHouse(i), PartInsID(i, 3), i + 1, PartInsMemo(i))   'Ins/Rem=1  (Install)
                    PartInsGroupNum(i) = i + 1
                Next i

                'Removed
                For i = 0 To EquipRemovedGrid.Rows.Count - 2
                    If PartRemID(i, 0) = 1 Then  'Local
                        If EQUIPMENTTableAdapter.ReturnSerial(PartRemID(i, 1), PartRemWareHouse(i)) <> "None" Then
                            EQUIPMENTTableAdapter.UpdateStatus(PartsRemStat(i), PartRemID(i, 1), PartRemWareHouse(i))
                        End If
                    Else   'City Owned
                        If EQUIPMENT2TableAdapter.ReturnSerial(PartRemID(i, 1)) <> "None" Then
                            EQUIPMENT2TableAdapter.UpdateStatus(PartsRemStat(i), PartRemID(i, 1))
                        End If
                    End If
                    ACT3TableAdapter.Insert(txtactnum.Text, PartRemID(i, 1), 2, PartRemID(i, 0), PartRemID(i, 2), PartRemWareHouse(i), 0, i + 1, PartRemMemo(i))   'Ins/Rem=2  (Remove)
                    PartRemGroupNum(i) = i + 1
                Next i

                EQUIPMENTTableAdapter.Fill(Me.SignalogDataSet.EQUIPMENT)
                EQUIPMENT2TableAdapter.Fill(Me.SignalogDataSet.EQUIPMENT2)

                For i = 0 To UpdatePartStatusCount - 1   'Update Status for edited and deleted parts
                    If UpdatePartStatus(i, 0) = 1 Then  'local
                        EQUIPMENTTableAdapter.UpdateStatus(UpdatePartStatus(i, 2), UpdatePartStatus(i, 1), UpdatePartStatus(i, 3))
                    ElseIf UpdatePartStatus(i, 0) = 2 Then  'city owned
                        EQUIPMENT2TableAdapter.UpdateStatus(UpdatePartStatus(i, 2), UpdatePartStatus(i, 1))
                    End If
                Next

                For i = 0 To 9    'reset update part status after done updating0
                    For j = 0 To 2
                        UpdatePartStatus(i, j) = 0
                    Next
                Next
                UpdatePartStatusCount = 0
                '------------------------------------------------------------------------------------------------------------------------
                'ACT9
                If ActHrsYes.Checked = True Then
                    acthrs = "Y"
                Else
                    acthrs = "N"
                End If
                ACT9TableAdapter.Insert(txtactnum.Text, RegHrstxt.Text, OTHrstxt.Text, RegRatetxt.Text, OTRatetxt.Text, RegAmttxt.Text, OTAmttxt.Text _
                                        , CUS0TableAdapter.ReturnMinHrs(LOC0TableAdapter.ReturnAREANUM(LOCNUM)), acthrs)
                '------------------------------------------------------------------------------------------------------------------------------
                Submit.Enabled = False
                bck.Enabled = True
                fwd.Enabled = True
                LoadStuff.Enabled = True
                txtactnum.ReadOnly = False
                EnterBy.Enabled = False
                YES.Enabled = False
                NO.Enabled = False
                RcvDate.Enabled = False
                RcvTime.Enabled = False
                ReportedBy.Enabled = False
                CityAgency.Enabled = False
                EWLOCBox.Enabled = False
                NSLOCBox.Enabled = False
                PhoneNum.Enabled = False
                RepByName.Enabled = False
                ProbRepPanel.Enabled = False
                ArrConPanel.Enabled = False
                ActTakPanel.Enabled = False
                DefActPanel.Enabled = False
                DepConPanel.Enabled = False
                EquipInsPanel.Enabled = False
                EquipRemPanel.Enabled = False
                DateTimePanel.Enabled = False
                TechnicianPanel.Enabled = False

                UndoButton.Enabled = False
                NewButton.Enabled = True
                DeleteButton.Enabled = True
                EditButton.Enabled = True
                EditSecondPart = False
                EditRecord = False

            End If
        End If
        '--------------------------------------------------------------------------------------------------------------------------------------------
        If NewRecord = True Or (EditRecord = True And flag = True) Then  'New Trouble Report (Panel1 & Problem reported) or edit first part
            ed = "Y"
            If EnterBy.Text = String.Empty Then
                MsgBox("Please select Enter By", MsgBoxStyle.Exclamation, "Missing Field")
            ElseIf DISPNUM = 0 Then
                MsgBox("Please select reported by", MsgBoxStyle.Exclamation, "Missing Field")
            ElseIf Area = String.Empty Then
                MsgBox("Please select city or agency", MsgBoxStyle.Exclamation, "Missing Field")
            ElseIf EWLOC = String.Empty Then
                MsgBox("Please select EW location", MsgBoxStyle.Exclamation, "Missing Field")
            ElseIf NSLOC = String.Empty Then
                MsgBox("Please select NS location", MsgBoxStyle.Exclamation, "Missing Field")
            ElseIf ReportedProblemGrid.Rows.Count = 1 And ReportedProblemGrid.Rows(0).Cells(0).Value = String.Empty Then
                MsgBox("Please enter problem reported", MsgBoxStyle.Exclamation, "Missing Field")
            ElseIf YES.Checked = False And NO.Checked = False Then
                MsgBox("Please select YES or NO for the Show field", MsgBoxStyle.Exclamation, "Missing Field")
            Else
                Try
                    If EditRecord = True Then
                        ACT0TableAdapter.DELETE_ACTNUM(txtactnum.Text)
                        ACT1TableAdapter.DELETE_ACTNUM(txtactnum.Text)
                        ACT2TableAdapter.DeleteAtACTNUM(txtactnum.Text)
                        LOCKEDITTableAdapter.DeleteAtDescValue("TroubleReport", txtactnum.Text)   'Release Edit LOCK
                    End If
                    If NewRecord = True Then
                        LOCKNEWTableAdapter.UpdateLockValue(txtactnum.Text, "TroubleReport")  'Update LOCK
                    End If
                    If YES.Checked = True Then
                        sh = "Y"
                    Else
                        sh = "N"
                    End If
                    'ACT0
                    If NewRecord = True Then    'New trouble report
                        ACT0TableAdapter.Insert(txtactnum.Text, ndate.Date, TimeSpan.Zero, EnterBy.SelectedValue, ndate.Date, TimeSpan.Zero, "", "", 0 _
                                                , "", RcvDate.Value.Date, RcvTime.Value.TimeOfDay, DISPNUM, LOCNUM, ndate.Date, _
                                                TimeSpan.Zero, ndate.Date, TimeSpan.Zero, 0, 0, ndate.Date, TimeSpan.Zero, ndate.Date _
                                                , TimeSpan.Zero, PhoneNum.Text, ed, RepByName.Text, sh)
                    ElseIf EditRecord = True Then    'Editing first part
                        ACT0TableAdapter.Insert(txtactnum.Text, ndate.Date, TimeSpan.Zero, EnterBy.SelectedValue, DateTime.Now.Date _
                                                , DateTime.Now.TimeOfDay, PERS0TableAdapter.ReturnPListNameAtUserName(Login.User), "", 0 _
                                                , "", RcvDate.Value.Date, RcvTime.Value.TimeOfDay, DISPNUM, LOCNUM, ndate.Date, _
                                                TimeSpan.Zero, ndate.Date, TimeSpan.Zero, 0, 0, ndate.Date, TimeSpan.Zero, ndate.Date _
                                                , TimeSpan.Zero, PhoneNum.Text, ed, RepByName.Text, sh)
                    End If
                    'Problem reported
                    For i = 0 To ReportedProblemGrid.Rows.Count - 2
                        ACT1TableAdapter.Insert(txtactnum.Text, 1, Prob_Rep_Code(i, 0), Prob_Rep_Code(i, 1), Prob_Rep_Code(i, 2) _
                                                  , Prob_Rep_Code(i, 3), Prob_Rep_Code(i, 4), Prob_Rep_Code(i, 5), i + 1)
                        If Prob_Rep_Code(i, 6) <> String.Empty Then 'MEMO (MEMO is stored in the 6th column)
                            ACT2TableAdapter.Insert(txtactnum.Text, 1, "Reported Problem: " & Prob_Rep_Code(i, 6), i + 1)
                        End If
                    Next i

                    ReportedProblemGrid.CurrentRow.Selected = False

                    ActHrsNo.Checked = True   'By default upon creating a new activity report
                    OTHrstxt.Text = 0

                    Submit.Enabled = True
                    bck.Enabled = True
                    fwd.Enabled = True
                    LoadStuff.Enabled = True
                    txtactnum.ReadOnly = False
                    EnterBy.Enabled = False
                    YES.Enabled = False
                    NO.Enabled = False
                    RcvDate.Enabled = False
                    RcvTime.Enabled = False
                    ReportedBy.Enabled = False
                    CityAgency.Enabled = False
                    EWLOCBox.Enabled = False
                    NSLOCBox.Enabled = False
                    PhoneNum.Enabled = False
                    RepByName.Enabled = False
                    ProbRepPanel.Enabled = False

                    UndoButton.Enabled = False
                    NewButton.Enabled = True
                    DeleteButton.Enabled = True
                    EditButton.Enabled = True

                    ArrConPanel.Enabled = True
                    ActTakPanel.Enabled = True
                    DefActPanel.Enabled = True
                    DepConPanel.Enabled = True

                    EquipInsPanel.Enabled = True
                    EquipRemPanel.Enabled = True

                    DateTimePanel.Enabled = True
                    TechnicianPanel.Enabled = True
                    NewRecord = False
                    EditRecord = False
                    Technician.Text = PERS0TableAdapter.ReturnPListNameAtUserName(Login.User)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub CityAgency_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CityAgency.SelectedIndexChanged
        If CityAgency.SelectedValue = "NEW" Then   'To add a new item
            If Area_Maintenance.Visible = True Then
                MsgBox("Can't open Area Maintenance, form is already open" & vbCrLf & "Please close Area Maintenance and retry", MsgBoxStyle.Exclamation)
            Else
                NewArea = True
                Area_Maintenance.ShowDialog()
            End If
        Else
            Area = CityAgency.SelectedValue
            Me.EWLOCTableAdapter.FillByArea(Me.SignalogDataSet.EWLOC, Area)
        End If
    End Sub

    Private Sub EWLOCBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EWLOCBox.SelectedIndexChanged
        If EWLOCBox.SelectedValue = "NEW" Then  'To add a new item
            MsgBox("New Entries Must Be Added By Administrator!" & vbCrLf & "Please contact the Tulsa Office for assistance.", MsgBoxStyle.Exclamation)
        Else
            EWLOC = EWLOCBox.SelectedValue
            Me.NSLOCTableAdapter.FillByEWLOC(Me.SignalogDataSet.NSLOC, Area, EWLOC)
        End If
    End Sub

    Private Sub NSLOCBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NSLOCBox.SelectedIndexChanged
        If NSLOCBox.SelectedValue = "NEW" Then  'To add a new item
            MsgBox("New Entries Must Be Added By Administrator!" & vbCrLf & "Please contact the Tulsa Office for assistance.", MsgBoxStyle.Exclamation)
        Else
            NSLOC = NSLOCBox.SelectedValue
            LOCNUM = LOC0TableAdapter.ReturnLOCNUM(Area, EWLOC, NSLOC)
        End If
    End Sub

    Private Sub Technician_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Technician.SelectedIndexChanged
        If Technician.SelectedValue <> String.Empty Then
            If Technician.SelectedValue = "NEW" Then   'To add a new item
                MsgBox("New Entries Must Be Added By Administrator!" & vbCrLf & "Please contact the Tulsa Office for assistance.", MsgBoxStyle.Exclamation)
            Else
                EMPNUM = PERS0TableAdapter.ReturnEMPNUM(Technician.SelectedValue)
            End If
        End If
    End Sub

    Private Sub ReportedBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportedBy.SelectedIndexChanged
        If ReportedBy.SelectedValue <> String.Empty Then
            If ReportedBy.SelectedValue = "NEW" Then   'To add a new item
                MsgBox("New Entries Must Be Added By Administrator!" & vbCrLf & "Please contact the Tulsa Office for assistance.", MsgBoxStyle.Exclamation)
            Else
                DISPNUM = DISP0TableAdapter.ReturnDISPNUM(ReportedBy.SelectedValue)
            End If

        End If
    End Sub

    Private Sub Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadStuff.Click
        Call Load_Activity()
    End Sub

    Private Sub Load_Activity()
        Dim num As String
        Dim i, k, j, MemoNum As Integer
        Dim s1, s2, s3, s4, s5, s6 As String
        Dim d1, d2, d3, d4, d5, d6 As String
        Dim lnklabel(0 To 5), memotext As String
        Dim memo As Boolean
        Dim ndate As Date
        ndate = Nothing
        '------------------------------------------------------------------------------------------------------------------------------------------
        EMPNUM = 0  'Reset first panel variables
        DISPNUM = 0
        LOCNUM = 0
        EWLOC = String.Empty
        NSLOC = String.Empty
        Area = String.Empty
        sh = String.Empty
        acthrs = String.Empty

        EnterBy.Text = ""   'Reset Panel1 fields
        YES.Checked = False
        NO.Checked = False
        RcvDate.Text = ""
        RcvTime.Text = "00:00:00"
        CityAgency.Text = ""
        EWLOCBox.Text = ""
        NSLOCBox.Text = ""
        ReportedBy.Text = ""
        PhoneNum.Text = ""
        RepByName.Text = ""

        'Reset the 5 gridviews:
        ReportedProblemGrid.Rows.Clear()
        ArrivalConditionGrid.Rows.Clear()
        ActionTakenGrid.Rows.Clear()
        DeferredActionGrid.Rows.Clear()
        DepartingConditionNotesGrid.Rows.Clear()

        For i = 0 To 9          'empty action codes
            For j = 0 To 6
                Arr_Con_Code(i, j) = String.Empty
                Act_Tak_Code(i, j) = String.Empty
                Def_Act_Code(i, j) = String.Empty
                Dep_Con_Code(i, j) = String.Empty
                Prob_Rep_Code(i, j) = String.Empty
            Next j
        Next i

        MemoNum = 0

        'Reset equipment installed and removed gridviews
        EquipInstalledGrid.Rows.Clear()
        EquipRemovedGrid.Rows.Clear()

        'Reset PartInsID, PartRemID, PartRemStat
        For i = 0 To 9
            For j = 0 To 3
                PartInsID(i, j) = 0
            Next j
            For j = 0 To 2
                PartRemID(i, j) = 0
            Next j
            PartsRemStat(i) = 0
            PartInsGroupNum(i) = 0
            PartRemGroupNum(i) = 0
            PartInsMemo(i) = String.Empty
            PartRemMemo(i) = String.Empty
            PartInsWareHouse(i) = String.Empty
            PartRemWareHouse(i) = String.Empty
        Next i

        UpdatePartStatusCount = 0   'reset update part status

        BegTime.Text = "00:00:00" 'Reset fields
        BegMil.Text = ""
        EndMil.Text = ""
        ArrTime.Text = "00:00:00"
        DepTime.Text = "00:00:00"
        EndTime.Text = "00:00:00"
        ArrDate.Text = ""
        BegDate.Text = ""
        EndDate.Text = ""
        DepDate.Text = ""
        VehNum.Text = ""
        RegHrstxt.Text = ""
        RegRatetxt.Text = ""
        RegAmttxt.Text = ""
        OTHrstxt.Text = ""
        OTRatetxt.Text = ""
        OTAmttxt.Text = ""
        ActHrsYes.Checked = False
        ActHrsNo.Checked = False
        Technician.Text = ""

        NewReportedBy = False   'reset
        NewEnterBy = False
        NewVehNum = False
        NewArea = False
        NewEWLOC = False
        NewNSLOC = False

        num = txtactnum.Text
        '-----------------------------------------------------------------------------------------------------------------------------------
        If NewRecord = False Then
            If num = "" Then    'If textNum empty
                DeleteButton.Enabled = False
                EditButton.Enabled = False
                EnterBy.Enabled = False
                RcvDate.Enabled = False
                RcvTime.Enabled = False
                ReportedBy.Enabled = False
                YES.Enabled = False
                NO.Enabled = False
                YES.Checked = False
                NO.Checked = False
                CityAgency.Enabled = False
                EWLOCBox.Enabled = False
                NSLOCBox.Enabled = False
                PhoneNum.Enabled = False
                RepByName.Enabled = False
                ProbRepPanel.Enabled = False

                ArrConPanel.Enabled = False
                ActTakPanel.Enabled = False
                DefActPanel.Enabled = False
                DepConPanel.Enabled = False
                EquipInsPanel.Enabled = False
                EquipRemPanel.Enabled = False
                DateTimePanel.Enabled = False
                TechnicianPanel.Enabled = False
                Submit.Enabled = False

            Else   'If textnum not empty
                If (Convert.ToInt32(num) > ACT0TableAdapter.ReturnMaxACTNUM) Or (Convert.ToString(ACT0TableAdapter.ReturnACTNUM(num)) = String.Empty) Then
                    MsgBox("No record was found for the selected activity number")  'If activity number doesn't exist
                    txtactnum.Text = ""
                    Call Load_Activity()
                    DeleteButton.Enabled = False
                    ArrConPanel.Enabled = False
                    ActTakPanel.Enabled = False
                    DefActPanel.Enabled = False
                    DepConPanel.Enabled = False
                    EquipInsPanel.Enabled = False
                    EquipRemPanel.Enabled = False
                    DateTimePanel.Enabled = False
                    TechnicianPanel.Enabled = False
                    Submit.Enabled = False
                Else   'Load activity
                    DeleteButton.Enabled = True
                    EditButton.Enabled = True
                    EnterBy.Text = ACT0TableAdapter.ReturnENTERBY(num)   'Load Panel1 
                    sh = ACT0TableAdapter.ReturnSHOW(num)
                    If sh = "Y" Then
                        YES.Checked = True
                        NO.Checked = False
                    Else
                        NO.Checked = True
                        YES.Checked = False
                    End If
                    RcvDate.Text = ACT0TableAdapter.ReturnRcvDate(num)
                    RcvTime.Text = Convert.ToString(ACT0TableAdapter.ReturnRcvTime(num))
                    ReportedBy.Text = DISP0TableAdapter.ReturnDISPBY(ACT0TableAdapter.ReturnDispNum(num))

                    LOCNUM = ACT0TableAdapter.ReturnLOCNUM(num)
                    CityAgency.Text = CUS0TableAdapter.ReturnAreaName(LOC0TableAdapter.ReturnAREANUM(LOCNUM))
                    Area = CityAgency.Text
                    Me.EWLOCTableAdapter.FillByArea(Me.SignalogDataSet.EWLOC, Area)
                    LOCNUM = ACT0TableAdapter.ReturnLOCNUM(num)
                    EWLOCBox.Text = LOC0TableAdapter.ReturnEWLOC(LOCNUM)
                    EWLOC = EWLOCBox.Text
                    Me.NSLOCTableAdapter.FillByEWLOC(Me.SignalogDataSet.NSLOC, Area, EWLOC)
                    LOCNUM = ACT0TableAdapter.ReturnLOCNUM(num)
                    NSLOCBox.Text = LOC0TableAdapter.ReturnNSLOC(LOCNUM)
                    NSLOC = NSLOCBox.Text

                    PhoneNum.Text = ACT0TableAdapter.ReturnPHONENUM(num)
                    RepByName.Text = ACT0TableAdapter.ReturnREPBYNAME(num)
                    editable = ACT0TableAdapter.ReturnEDITABLE(num)

                    EMPNUM = PERS0TableAdapter.ReturnEMPNUM(Technician.SelectedValue)
                    DISPNUM = DISP0TableAdapter.ReturnDISPNUM(ReportedBy.SelectedValue)

                    If editable = "Y" Then  'Load problem reported
                        Technician.Text = PERS0TableAdapter.ReturnPListNameAtUserName(Login.User)   'Automatically set technician to user logged in
                        ArrConPanel.Enabled = True
                        ActTakPanel.Enabled = True
                        DefActPanel.Enabled = True
                        DepConPanel.Enabled = True
                        EquipInsPanel.Enabled = True
                        EquipRemPanel.Enabled = True
                        DateTimePanel.Enabled = True
                        ActHrsNo.Checked = True
                        TechnicianPanel.Enabled = True
                        Submit.Enabled = True
                        '-------------------------------------------------------------------------------------------------------------
                        records(0) = ACT1TableAdapter.ReturnRecords(txtactnum.Text, 1)
                        If records(0) <> 0 Then    'Loading problem reported
                            For k = 0 To records(0) - 1
                                memo = False

                                s1 = ACT1TableAdapter.ReturnASUB1(txtactnum.Text, 1, k + 1)  'Loading activity codes
                                s2 = ACT1TableAdapter.ReturnASUB2(txtactnum.Text, 1, k + 1)
                                s3 = ACT1TableAdapter.ReturnASUB3(txtactnum.Text, 1, k + 1)
                                s4 = ACT1TableAdapter.ReturnASUB4(txtactnum.Text, 1, k + 1)
                                s5 = ACT1TableAdapter.ReturnASUB5(txtactnum.Text, 1, k + 1)
                                s6 = ACT1TableAdapter.ReturnASUB6(txtactnum.Text, 1, k + 1)
                                d1 = ASUBTableAdapter.RetrunDESC(s1)   'loading corresponding description for each activity code
                                d2 = ASUBTableAdapter.RetrunDESC(s2)
                                d3 = ASUBTableAdapter.RetrunDESC(s3)
                                d4 = ASUBTableAdapter.RetrunDESC(s4)
                                d5 = ASUBTableAdapter.RetrunDESC(s5)
                                d6 = ASUBTableAdapter.RetrunDESC(s6)
                                lnklabel(0) = ASUBTableAdapter.ReturnLNKLABEL(s1)  'Loading LNKLABEL for each activity
                                lnklabel(1) = ASUBTableAdapter.ReturnLNKLABEL(s2)
                                lnklabel(2) = ASUBTableAdapter.ReturnLNKLABEL(s3)
                                lnklabel(3) = ASUBTableAdapter.ReturnLNKLABEL(s4)
                                lnklabel(4) = ASUBTableAdapter.ReturnLNKLABEL(s5)
                                lnklabel(5) = ASUBTableAdapter.ReturnLNKLABEL(s6)

                                For j = 0 To 5    ' checking for MEMO in LNKLABEL
                                    If lnklabel(j) = "MEMO" Then
                                        memo = True
                                        MemoNum += 1
                                    End If
                                Next j

                                ReportedProblemGrid.CurrentCell = ReportedProblemGrid.Rows(k).Cells(0)   'To select the cell (make it current cell)
                                ReportedProblemGrid.BeginEdit(True)

                                If s1 <> String.Empty Then   'loading description into textbox
                                    Prob_Rep_Code(k, 0) = s1  'Store ASUB1 code
                                    If s2 = String.Empty Then
                                        ReportedProblemGrid.EditingControl.Text += d1
                                    Else
                                        ReportedProblemGrid.EditingControl.Text += d1 & ",  "
                                    End If
                                End If
                                If s2 <> String.Empty Then
                                    Prob_Rep_Code(k, 1) = s2  'Store ASUB2 code
                                    If s3 = String.Empty Then
                                        ReportedProblemGrid.EditingControl.Text += d2
                                    Else
                                        ReportedProblemGrid.EditingControl.Text += d2 & ",  "
                                    End If
                                End If
                                If s3 <> String.Empty Then
                                    Prob_Rep_Code(k, 2) = s3  'Store ASUB3 code
                                    If s4 = String.Empty Then
                                        ReportedProblemGrid.EditingControl.Text += d3
                                    Else
                                        ReportedProblemGrid.EditingControl.Text += d3 & ",  "
                                    End If
                                End If
                                If s4 <> String.Empty Then
                                    Prob_Rep_Code(k, 3) = s4  'Store ASUB4 code
                                    If s5 = String.Empty Then
                                        ReportedProblemGrid.EditingControl.Text += d4
                                    Else
                                        ReportedProblemGrid.EditingControl.Text += d4 & ",  "
                                    End If
                                End If
                                If s5 <> String.Empty Then
                                    Prob_Rep_Code(k, 4) = s5  'Store ASUB5 code
                                    If s6 = String.Empty Then
                                        ReportedProblemGrid.EditingControl.Text += d5
                                    Else
                                        ReportedProblemGrid.EditingControl.Text += d5 & ",  "
                                    End If
                                End If
                                If s6 <> String.Empty Then
                                    Prob_Rep_Code(k, 5) = s6  'Store ASUB6 code
                                    ReportedProblemGrid.EditingControl.Text += d6
                                End If

                                If memo = True Then   'Loading memo text into textbox
                                    Try
                                        memotext = ACT2TableAdapter.ReturnMEMOTEXT(txtactnum.Text, 1, k + 1)
                                        memotext = memotext.Remove(0, 18)
                                        Prob_Rep_Code(k, 6) = memotext  'Store MEMO code
                                        ReportedProblemGrid.EditingControl.Text += ",  " & memotext
                                    Catch
                                    End Try
                                End If

                                ReportedProblemGrid.EndEdit()
                                ReportedProblemGrid.CurrentCell.Selected = False

                            Next k
                        End If
                        '-----------------------------------------------------------------------------------------------------------------
                    Else   'editable = No load the rest
                        ArrConPanel.Enabled = False
                        ActTakPanel.Enabled = False
                        DefActPanel.Enabled = False
                        DepConPanel.Enabled = False
                        EquipInsPanel.Enabled = False
                        EquipRemPanel.Enabled = False
                        DateTimePanel.Enabled = False
                        TechnicianPanel.Enabled = False
                        Submit.Enabled = False
                        'load the rest including problem reported
                        For i = 1 To 5
                            records(i - 1) = ACT1TableAdapter.ReturnRecords(txtactnum.Text, i)
                            If records(i - 1) <> 0 Then
                                For k = 0 To records(i - 1) - 1
                                    memo = False

                                    s1 = ACT1TableAdapter.ReturnASUB1(txtactnum.Text, i, k + 1)
                                    s2 = ACT1TableAdapter.ReturnASUB2(txtactnum.Text, i, k + 1)
                                    s3 = ACT1TableAdapter.ReturnASUB3(txtactnum.Text, i, k + 1)
                                    s4 = ACT1TableAdapter.ReturnASUB4(txtactnum.Text, i, k + 1)
                                    s5 = ACT1TableAdapter.ReturnASUB5(txtactnum.Text, i, k + 1)
                                    s6 = ACT1TableAdapter.ReturnASUB6(txtactnum.Text, i, k + 1)
                                    d1 = ASUBTableAdapter.RetrunDESC(s1)
                                    d2 = ASUBTableAdapter.RetrunDESC(s2)
                                    d3 = ASUBTableAdapter.RetrunDESC(s3)
                                    d4 = ASUBTableAdapter.RetrunDESC(s4)
                                    d5 = ASUBTableAdapter.RetrunDESC(s5)
                                    d6 = ASUBTableAdapter.RetrunDESC(s6)
                                    lnklabel(0) = ASUBTableAdapter.ReturnLNKLABEL(s1)    ' checking for memo
                                    lnklabel(1) = ASUBTableAdapter.ReturnLNKLABEL(s2)
                                    lnklabel(2) = ASUBTableAdapter.ReturnLNKLABEL(s3)
                                    lnklabel(3) = ASUBTableAdapter.ReturnLNKLABEL(s4)
                                    lnklabel(4) = ASUBTableAdapter.ReturnLNKLABEL(s5)
                                    lnklabel(5) = ASUBTableAdapter.ReturnLNKLABEL(s6)

                                    For j = 0 To 5
                                        If lnklabel(j) = "MEMO" Then
                                            memo = True
                                            MemoNum += 1
                                        End If
                                    Next j

                                    If i = 1 Then
                                        ReportedProblemGrid.CurrentCell = ReportedProblemGrid.Rows(k).Cells(0)   'To select the cell (make it current cell)
                                        ReportedProblemGrid.BeginEdit(True)
                                    ElseIf i = 2 Then
                                        ArrivalConditionGrid.CurrentCell = ArrivalConditionGrid.Rows(k).Cells(0)   'To select the cell (make it current cell)
                                        ArrivalConditionGrid.BeginEdit(True)
                                    ElseIf i = 3 Then
                                        ActionTakenGrid.CurrentCell = ActionTakenGrid.Rows(k).Cells(0)   'To select the cell (make it current cell)
                                        ActionTakenGrid.BeginEdit(True)
                                    ElseIf i = 4 Then
                                        DeferredActionGrid.CurrentCell = DeferredActionGrid.Rows(k).Cells(0)   'To select the cell (make it current cell)
                                        DeferredActionGrid.BeginEdit(True)
                                    ElseIf i = 5 Then
                                        DepartingConditionNotesGrid.CurrentCell = DepartingConditionNotesGrid.Rows(k).Cells(0)   'To select the cell (make it current cell)
                                        DepartingConditionNotesGrid.BeginEdit(True)
                                    End If

                                    If s1 <> String.Empty Then
                                        If i = 1 Then  'store ASUB1 code to corresponding event
                                            Prob_Rep_Code(k, 0) = s1
                                            If s2 = String.Empty Then
                                                ReportedProblemGrid.EditingControl.Text += d1
                                            Else
                                                ReportedProblemGrid.EditingControl.Text += d1 & ",  "
                                            End If
                                        ElseIf i = 2 Then
                                            Arr_Con_Code(k, 0) = s1
                                            If s2 = String.Empty Then
                                                ArrivalConditionGrid.EditingControl.Text += d1
                                            Else
                                                ArrivalConditionGrid.EditingControl.Text += d1 & ",  "
                                            End If
                                        ElseIf i = 3 Then
                                            Act_Tak_Code(k, 0) = s1
                                            If s2 = String.Empty Then
                                                ActionTakenGrid.EditingControl.Text += d1
                                            Else
                                                ActionTakenGrid.EditingControl.Text += d1 & ",  "
                                            End If
                                        ElseIf i = 4 Then
                                            Def_Act_Code(k, 0) = s1
                                            If s2 = String.Empty Then
                                                DeferredActionGrid.EditingControl.Text += d1
                                            Else
                                                DeferredActionGrid.EditingControl.Text += d1 & ",  "
                                            End If
                                        ElseIf i = 5 Then
                                            Dep_Con_Code(k, 0) = s1
                                            If s2 = String.Empty Then
                                                DepartingConditionNotesGrid.EditingControl.Text += d1
                                            Else
                                                DepartingConditionNotesGrid.EditingControl.Text += d1 & ",  "
                                            End If
                                        End If
                                    End If
                                    If s2 <> String.Empty Then
                                        If i = 1 Then  'store ASUB2 code to corresponding event
                                            Prob_Rep_Code(k, 1) = s2
                                            If s3 = String.Empty Then
                                                ReportedProblemGrid.EditingControl.Text += d2
                                            Else
                                                ReportedProblemGrid.EditingControl.Text += d2 & ",  "
                                            End If
                                        ElseIf i = 2 Then
                                            Arr_Con_Code(k, 1) = s2
                                            If s3 = String.Empty Then
                                                ArrivalConditionGrid.EditingControl.Text += d2
                                            Else
                                                ArrivalConditionGrid.EditingControl.Text += d2 & ",  "
                                            End If
                                        ElseIf i = 3 Then
                                            Act_Tak_Code(k, 1) = s2
                                            If s3 = String.Empty Then
                                                ActionTakenGrid.EditingControl.Text += d2
                                            Else
                                                ActionTakenGrid.EditingControl.Text += d2 & ",  "
                                            End If
                                        ElseIf i = 4 Then
                                            Def_Act_Code(k, 1) = s2
                                            If s3 = String.Empty Then
                                                DeferredActionGrid.EditingControl.Text += d2
                                            Else
                                                DeferredActionGrid.EditingControl.Text += d2 & ",  "
                                            End If
                                        ElseIf i = 5 Then
                                            Dep_Con_Code(k, 1) = s2
                                            If s3 = String.Empty Then
                                                DepartingConditionNotesGrid.EditingControl.Text += d2
                                            Else
                                                DepartingConditionNotesGrid.EditingControl.Text += d2 & ",  "
                                            End If
                                        End If
                                    End If
                                    If s3 <> String.Empty Then
                                        If i = 1 Then  'store ASUB3 code to corresponding event
                                            Prob_Rep_Code(k, 2) = s3
                                            If s4 = String.Empty Then
                                                ReportedProblemGrid.EditingControl.Text += d3
                                            Else
                                                ReportedProblemGrid.EditingControl.Text += d3 & ",  "
                                            End If
                                        ElseIf i = 2 Then
                                            Arr_Con_Code(k, 2) = s3
                                            If s4 = String.Empty Then
                                                ArrivalConditionGrid.EditingControl.Text += d3
                                            Else
                                                ArrivalConditionGrid.EditingControl.Text += d3 & ",  "
                                            End If
                                        ElseIf i = 3 Then
                                            Act_Tak_Code(k, 2) = s3
                                            If s4 = String.Empty Then
                                                ActionTakenGrid.EditingControl.Text += d3
                                            Else
                                                ActionTakenGrid.EditingControl.Text += d3 & ",  "
                                            End If
                                        ElseIf i = 4 Then
                                            Def_Act_Code(k, 2) = s3
                                            If s4 = String.Empty Then
                                                DeferredActionGrid.EditingControl.Text += d3
                                            Else
                                                DeferredActionGrid.EditingControl.Text += d3 & ",  "
                                            End If
                                        ElseIf i = 5 Then
                                            Dep_Con_Code(k, 2) = s3
                                            If s4 = String.Empty Then
                                                DepartingConditionNotesGrid.EditingControl.Text += d3
                                            Else
                                                DepartingConditionNotesGrid.EditingControl.Text += d3 & ",  "
                                            End If
                                        End If
                                    End If
                                    If s4 <> String.Empty Then
                                        If i = 1 Then  'store ASUB4 code to corresponding event
                                            Prob_Rep_Code(k, 3) = s4
                                            If s5 = String.Empty Then
                                                ReportedProblemGrid.EditingControl.Text += d4
                                            Else
                                                ReportedProblemGrid.EditingControl.Text += d4 & ",  "
                                            End If
                                        ElseIf i = 2 Then
                                            Arr_Con_Code(k, 3) = s4
                                            If s5 = String.Empty Then
                                                ArrivalConditionGrid.EditingControl.Text += d4
                                            Else
                                                ArrivalConditionGrid.EditingControl.Text += d4 & ",  "
                                            End If
                                        ElseIf i = 3 Then
                                            Act_Tak_Code(k, 3) = s4
                                            If s5 = String.Empty Then
                                                ActionTakenGrid.EditingControl.Text += d4
                                            Else
                                                ActionTakenGrid.EditingControl.Text += d4 & ",  "
                                            End If
                                        ElseIf i = 4 Then
                                            Def_Act_Code(k, 3) = s4
                                            If s5 = String.Empty Then
                                                DeferredActionGrid.EditingControl.Text += d4
                                            Else
                                                DeferredActionGrid.EditingControl.Text += d4 & ",  "
                                            End If
                                        ElseIf i = 5 Then
                                            Dep_Con_Code(k, 3) = s4
                                            If s5 = String.Empty Then
                                                DepartingConditionNotesGrid.EditingControl.Text += d4
                                            Else
                                                DepartingConditionNotesGrid.EditingControl.Text += d4 & ",  "
                                            End If
                                        End If
                                    End If
                                    If s5 <> String.Empty Then
                                        If i = 1 Then  'store ASUB5 code to corresponding event
                                            Prob_Rep_Code(k, 4) = s5
                                            If s6 = String.Empty Then
                                                ReportedProblemGrid.EditingControl.Text += d5
                                            Else
                                                ReportedProblemGrid.EditingControl.Text += d5 & ",  "
                                            End If
                                        ElseIf i = 2 Then
                                            Arr_Con_Code(k, 4) = s5
                                            If s6 = String.Empty Then
                                                ArrivalConditionGrid.EditingControl.Text += d5
                                            Else
                                                ArrivalConditionGrid.EditingControl.Text += d5 & ",  "
                                            End If
                                        ElseIf i = 3 Then
                                            Act_Tak_Code(k, 4) = s5
                                            If s6 = String.Empty Then
                                                ActionTakenGrid.EditingControl.Text += d5
                                            Else
                                                ActionTakenGrid.EditingControl.Text += d5 & ",  "
                                            End If
                                        ElseIf i = 4 Then
                                            Def_Act_Code(k, 4) = s5
                                            If s6 = String.Empty Then
                                                DeferredActionGrid.EditingControl.Text += d5
                                            Else
                                                DeferredActionGrid.EditingControl.Text += d5 & ",  "
                                            End If
                                        ElseIf i = 5 Then
                                            Dep_Con_Code(k, 4) = s5
                                            If s6 = String.Empty Then
                                                DepartingConditionNotesGrid.EditingControl.Text += d5
                                            Else
                                                DepartingConditionNotesGrid.EditingControl.Text += d5 & ",  "
                                            End If
                                        End If
                                    End If
                                    If s6 <> String.Empty Then
                                        If i = 1 Then  'store ASUB6 code to corresponding event
                                            Prob_Rep_Code(k, 5) = s6
                                            ReportedProblemGrid.EditingControl.Text += d6
                                        ElseIf i = 2 Then
                                            Arr_Con_Code(k, 5) = s6
                                            ArrivalConditionGrid.EditingControl.Text += d6
                                        ElseIf i = 3 Then
                                            Act_Tak_Code(k, 5) = s6
                                            ActionTakenGrid.EditingControl.Text += d6
                                        ElseIf i = 4 Then
                                            Def_Act_Code(k, 5) = s6
                                            DeferredActionGrid.EditingControl.Text += d6
                                        ElseIf i = 5 Then
                                            Dep_Con_Code(k, 5) = s6
                                            DepartingConditionNotesGrid.EditingControl.Text += d6
                                        End If
                                    End If

                                    If memo = True Then
                                        Try
                                            memotext = ACT2TableAdapter.ReturnMEMOTEXT(txtactnum.Text, i, k + 1)
                                            If i = 1 Then  'store MEMO to corresponding event
                                                memotext = memotext.Remove(0, 18)
                                                Prob_Rep_Code(k, 6) = memotext
                                                ReportedProblemGrid.EditingControl.Text += ",  " & memotext
                                            ElseIf i = 2 Then
                                                memotext = memotext.Remove(0, 19)
                                                Arr_Con_Code(k, 6) = memotext
                                                ArrivalConditionGrid.EditingControl.Text += ",  " & memotext
                                            ElseIf i = 3 Then
                                                memotext = memotext.Remove(0, 14)
                                                Act_Tak_Code(k, 6) = memotext
                                                ActionTakenGrid.EditingControl.Text += ",  " & memotext
                                            ElseIf i = 4 Then
                                                memotext = memotext.Remove(0, 17)
                                                Def_Act_Code(k, 6) = memotext
                                                DeferredActionGrid.EditingControl.Text += ",  " & memotext
                                            ElseIf i = 5 Then
                                                memotext = memotext.Remove(0, 21)
                                                Dep_Con_Code(k, 6) = memotext
                                                DepartingConditionNotesGrid.EditingControl.Text += ",  " & memotext
                                            End If
                                        Catch
                                        End Try
                                    End If

                                    If i = 1 Then
                                        ReportedProblemGrid.EndEdit()
                                        ReportedProblemGrid.CurrentCell.Selected = False
                                    ElseIf i = 2 Then
                                        ArrivalConditionGrid.EndEdit()
                                        ArrivalConditionGrid.CurrentCell.Selected = False
                                    ElseIf i = 3 Then
                                        ActionTakenGrid.EndEdit()
                                        ActionTakenGrid.CurrentCell.Selected = False
                                    ElseIf i = 4 Then
                                        DeferredActionGrid.EndEdit()
                                        DeferredActionGrid.CurrentCell.Selected = False
                                    ElseIf i = 5 Then
                                        DepartingConditionNotesGrid.EndEdit()
                                        DepartingConditionNotesGrid.CurrentCell.Selected = False
                                    End If
                                Next k
                            End If
                        Next i
                        '----------------------------------------------------------------------------------------------------------------------
                        'Loading Parts Panel
                        Dim PartID, PartQuant As Integer
                        Dim PartCost As Double
                        Dim PartWareHouse As String
                        Dim PartMemo As String
                        PartsIns = ACT3TableAdapter.ReturnRecords(num, 1)
                        PartsRem = ACT3TableAdapter.ReturnRecords(num, 2)
                        'Loading Parts Installed
                        For i = 0 To PartsIns - 1
                            PartID = ACT3TableAdapter.ReturnPartID(num, 1, i + 1)
                            PartSrc = ACT3TableAdapter.ReturnSrc(num, 1, i + 1)
                            PartQuant = ACT3TableAdapter.ReturnQuantity(num, 1, i + 1)
                            PartCost = ACT3TableAdapter.ReturnCost(num, 1, i + 1)
                            PartWareHouse = ACT3TableAdapter.ReturnWareHouse(num, 1, i + 1)
                            If ACT3TableAdapter.ReturnMemo(num, 1, i + 1) = SqlTypes.SqlString.Null Then
                                PartMemo = String.Empty
                            Else
                                PartMemo = ACT3TableAdapter.ReturnMemo(num, 1, i + 1)
                            End If

                            'Creating and filling textboxes

                            EquipInstalledGrid.CurrentCell = EquipInstalledGrid.Rows(i).Cells(0)   'select the Part cell
                            EquipInstalledGrid.BeginEdit(True)
                            If PartSrc = 1 Then  'Local
                                EquipInstalledGrid.EditingControl.Text = EQUIPMENTTableAdapter.ReturnPartDesc(PartID, PartWareHouse)
                            Else  'City Owned
                                EquipInstalledGrid.EditingControl.Text = EQUIPMENT2TableAdapter.ReturnPartDesc(PartID)
                            End If
                            EquipInstalledGrid.EndEdit()

                            EquipInstalledGrid.CurrentCell = EquipInstalledGrid.Rows(i).Cells(1)   'select the Serial cell
                            EquipInstalledGrid.BeginEdit(True)
                            If PartSrc = 1 Then  'Local
                                EquipInstalledGrid.EditingControl.Text = EQUIPMENTTableAdapter.ReturnSerial(PartID, PartWareHouse)
                            Else  'City Owned
                                EquipInstalledGrid.EditingControl.Text = EQUIPMENT2TableAdapter.ReturnSerial(PartID)
                            End If
                            EquipInstalledGrid.EndEdit()

                            EquipInstalledGrid.CurrentCell = EquipInstalledGrid.Rows(i).Cells(2)   'select the Quantity cell
                            EquipInstalledGrid.BeginEdit(True)
                            EquipInstalledGrid.EditingControl.Text = PartQuant
                            EquipInstalledGrid.EndEdit()

                            EquipInstalledGrid.CurrentCell = EquipInstalledGrid.Rows(i).Cells(3)   'select the Unit Price cell
                            EquipInstalledGrid.BeginEdit(True)
                            EquipInstalledGrid.EditingControl.Text = PartCost
                            EquipInstalledGrid.EndEdit()

                            EquipInstalledGrid.CurrentCell = EquipInstalledGrid.Rows(i).Cells(4)   'select the Source cell
                            EquipInstalledGrid.BeginEdit(True)
                            If PartSrc = 1 Then  'Local
                                EquipInstalledGrid.EditingControl.Text = "LOC - " & PartWareHouse
                            Else  'City Owned
                                EquipInstalledGrid.EditingControl.Text = "CO"
                            End If
                            EquipInstalledGrid.EndEdit()

                            EquipInstalledGrid.CurrentCell = EquipInstalledGrid.Rows(i).Cells(5)   'select the Memo cell
                            EquipInstalledGrid.BeginEdit(True)
                            EquipInstalledGrid.EditingControl.Text = PartMemo
                            EquipInstalledGrid.EndEdit()
                            EquipInstalledGrid.CurrentCell.Selected = False

                            'Storing values to corresponding arrays
                            PartInsID(i, 0) = PartSrc
                            PartInsID(i, 1) = PartID
                            PartInsID(i, 2) = PartQuant
                            PartInsID(i, 3) = PartCost
                            PartInsMemo(i) = PartMemo
                            PartInsWareHouse(i) = PartWareHouse

                            PartInsGroupNum(i) = i + 1

                        Next i
                        '---------------------------------------------------------------------------------------------------------------------------
                        'Loading Parts Removed
                        For i = 0 To PartsRem - 1
                            PartID = ACT3TableAdapter.ReturnPartID(num, 2, i + 1)
                            PartSrc = ACT3TableAdapter.ReturnSrc(num, 2, i + 1)
                            PartQuant = ACT3TableAdapter.ReturnQuantity(num, 2, i + 1)
                            PartWareHouse = ACT3TableAdapter.ReturnWareHouse(num, 2, i + 1)
                            If ACT3TableAdapter.ReturnMemo(num, 2, i + 1) = SqlTypes.SqlString.Null Then
                                PartMemo = String.Empty
                            Else
                                PartMemo = ACT3TableAdapter.ReturnMemo(num, 2, i + 1)
                            End If

                            'Creating and filling textboxes

                            EquipRemovedGrid.CurrentCell = EquipRemovedGrid.Rows(i).Cells(0)   'select the Part cell
                            EquipRemovedGrid.BeginEdit(True)
                            If PartSrc = 1 Then  'Local
                                EquipRemovedGrid.EditingControl.Text = EQUIPMENTTableAdapter.ReturnPartDesc(PartID, PartWareHouse)
                            Else  'City Owned
                                EquipRemovedGrid.EditingControl.Text = EQUIPMENT2TableAdapter.ReturnPartDesc(PartID)
                            End If
                            EquipRemovedGrid.EndEdit()

                            EquipRemovedGrid.CurrentCell = EquipRemovedGrid.Rows(i).Cells(1)   'select the Serial cell
                            EquipRemovedGrid.BeginEdit(True)
                            If PartSrc = 1 Then  'Local
                                EquipRemovedGrid.EditingControl.Text = EQUIPMENTTableAdapter.ReturnSerial(PartID, PartWareHouse)
                            Else   'City Owned
                                EquipRemovedGrid.EditingControl.Text = EQUIPMENT2TableAdapter.ReturnSerial(PartID)
                            End If
                            EquipRemovedGrid.EndEdit()

                            EquipRemovedGrid.CurrentCell = EquipRemovedGrid.Rows(i).Cells(2)   'select the Quantity cell
                            EquipRemovedGrid.BeginEdit(True)
                            EquipRemovedGrid.EditingControl.Text = PartQuant
                            EquipRemovedGrid.EndEdit()

                            EquipRemovedGrid.CurrentCell = EquipRemovedGrid.Rows(i).Cells(3)   'select the Source cell
                            EquipRemovedGrid.BeginEdit(True)
                            If PartSrc = 1 Then  'Local
                                EquipRemovedGrid.EditingControl.Text = "LOC - " & PartWareHouse
                            Else   'City Owned
                                EquipRemovedGrid.EditingControl.Text = "CO"
                            End If
                            EquipRemovedGrid.EndEdit()

                            EquipRemovedGrid.CurrentCell = EquipRemovedGrid.Rows(i).Cells(4)   'select the Memo cell
                            EquipRemovedGrid.BeginEdit(True)
                            EquipRemovedGrid.EditingControl.Text = PartMemo
                            EquipRemovedGrid.EndEdit()
                            EquipRemovedGrid.CurrentCell.Selected = False

                            'Storing values to corresponding arrays
                            PartRemID(i, 0) = PartSrc
                            PartRemID(i, 1) = PartID
                            PartRemID(i, 2) = PartQuant
                            PartRemMemo(i) = PartMemo
                            PartRemWareHouse(i) = PartWareHouse

                            PartRemGroupNum(i) = i + 1

                            If PartSrc = 1 Then  'local
                                PartsRemStat(i) = EQUIPMENTTableAdapter.ReturnStatusAtID(PartID, PartWareHouse)
                            ElseIf PartSrc = 2 Then  'city owned
                                PartsRemStat(i) = EQUIPMENT2TableAdapter.ReturnStatusAtID(PartID)
                            End If

                        Next i
                        '---------------------------------------------------------------------------------------------------------------------------
                        'Loading DateTimePanel

                        If ACT9TableAdapter.ReturnACTHRS(num) = "Y" Then
                            ActHrsYes.Checked = True
                        Else
                            ActHrsNo.Checked = True
                        End If

                        ArrTime.Text = Convert.ToString(ACT0TableAdapter.ReturnARRTIME(num))
                        BegTime.Text = Convert.ToString(ACT0TableAdapter.ReturnBegTime(num))
                        EndTime.Text = Convert.ToString(ACT0TableAdapter.ReturnEndTime(num))
                        DepTime.Text = Convert.ToString(ACT0TableAdapter.ReturnDEPTIME(num))
                        ArrDate.Text = ACT0TableAdapter.ReturnARRDATE(num)
                        BegDate.Text = ACT0TableAdapter.ReturnBEGDATE(num)
                        EndDate.Text = ACT0TableAdapter.ReturnENDDATE(num)
                        DepDate.Text = ACT0TableAdapter.ReturnDEPDATE(num)

                        BegMil.Text = ACT0TableAdapter.ReturnVEHSTART(num)
                        EndMil.Text = ACT0TableAdapter.ReturnVEHEND(num)

                        RegHrstxt.Text = ACT9TableAdapter.ReturnRegHrs(num)
                        RegRatetxt.Text = ACT9TableAdapter.ReturnRegRate(num)
                        RegAmttxt.Text = ACT9TableAdapter.ReturnRegAmt(num)
                        OTHrstxt.Text = ACT9TableAdapter.ReturnOTHrs(num)
                        OTRatetxt.Text = ACT9TableAdapter.ReturnOTRate(num)
                        OTAmttxt.Text = ACT9TableAdapter.ReturnOTAmt(num)

                        VehNum.Text = ACT0TableAdapter.ReturnVEHNUM(num)
                        '---------------------------------------------------------------------------------------------------------------------------
                        Dim em As Decimal
                        em = ACT0TableAdapter.ReturnEMPNUM(num)
                        Technician.Text = PERS0TableAdapter.ReturnPLISTNAME(em)

                    End If
                End If
            End If
        End If
    End Sub

    Private Sub fwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwd.Click
        Dim i As Integer
        If txtactnum.Text = "" Or txtactnum.Text = Convert.ToString(ACT0TableAdapter.ReturnMaxACTNUM) Then
            txtactnum.Text = ACT0TableAdapter.ReturnMINACTNUM
        Else
            i = txtactnum.Text + 1
            While ACT0TableAdapter.ReturnCountACTNUM(i) = 0 And ACT0TableAdapter.ReturnMaxACTNUM > i
                i += 1
            End While
            If ACT0TableAdapter.ReturnCountACTNUM(i) = 0 Then
                txtactnum.Text = ACT0TableAdapter.ReturnMINACTNUM
            Else
                txtactnum.Text = i
            End If
        End If
        Call Load_Activity()
    End Sub

    Private Sub bck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bck.Click
        Dim i As Integer
        If txtactnum.Text = "" Or txtactnum.Text = Convert.ToString(ACT0TableAdapter.ReturnMINACTNUM) Then
            If ACT0TableAdapter.ReturnCountACTNUM(ACT0TableAdapter.ReturnMaxACTNUM) <> 0 Then
                txtactnum.Text = ACT0TableAdapter.ReturnMaxACTNUM
            Else
                i = ACT0TableAdapter.ReturnMaxACTNUM
                While ACT0TableAdapter.ReturnCountACTNUM(i) = 0 And i > 1
                    i -= 1
                End While
                txtactnum.Text = i
            End If
        Else
            i = txtactnum.Text - 1
            While ACT0TableAdapter.ReturnCountACTNUM(i) = 0 And i > 1
                i -= 1
            End While
            txtactnum.Text = i
        End If
        Call Load_Activity()
    End Sub

    'To make sure user enters only numeric value in txtactnum
    Private Sub txtactnum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtactnum.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Function TrapKey(ByVal KCode As String) As Boolean    'allow only numbers
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then '8:backspace
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function

    Private Function TrapKey2(ByVal KCode As String) As Boolean    'allow only numbers (decimal too)
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Or KCode = 46 Then  '8:backspace , 46: .
            TrapKey2 = False
        Else
            TrapKey2 = True
        End If
    End Function

    Private Sub Trouble_Report_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        'refresh or redraw panels....
        Panel1.Width = ToolStrip1.Width
        ProbRepPanel.Width = ToolStrip1.Width
        ArrConPanel.Width = ToolStrip1.Width
        ActTakPanel.Width = ToolStrip1.Width
        DefActPanel.Width = ToolStrip1.Width
        DepConPanel.Width = ToolStrip1.Width
        EquipInsPanel.Width = ToolStrip1.Width
        EquipRemPanel.Width = ToolStrip1.Width
        DateTimePanel.Width = ToolStrip1.Width
        TechnicianPanel.Width = ToolStrip1.Width
    End Sub

    Private Sub Trouble_Report_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        If Me.WindowState = FormWindowState.Normal Then
            Try
                Me.WindowState = FormWindowState.Maximized
            Catch
            End Try
        End If
    End Sub

    Private Sub Trouble_Report_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.TextChanged
        Me.Text = "Trouble Report"
        'Used to return new created items from a maintenance form for one of the drop down list
        If NewReportedBy = True Then
            NewReportedBy = False
            DISP0TableAdapter.Fill(Me.SignalogDataSet.DISP0)  'Update to include the new item
            Try
                'Select the new item 
                ReportedBy.SelectedValue = DISP0TableAdapter.ReturnDISPBY(DISP0TableAdapter.ReturnMAXDISPNUM - 1)
            Catch
            End Try
        End If

        If NewEnterBy = True Then
            NewEnterBy = False
            Me.PERS0TableAdapter.Fill(Me.SignalogDataSet.PERS0)
            Try
                If NewRecord = False Then
                    Technician.SelectedValue = PERS0TableAdapter.ReturnPLISTNAME(PERS0TableAdapter.ReturnMaxID - 1)
                Else
                    EnterBy.SelectedValue = PERS0TableAdapter.ReturnPLISTNAME(PERS0TableAdapter.ReturnMaxID - 1)
                End If
            Catch
            End Try
        End If

        If NewVehNum = True Then
            NewVehNum = False
            Me.VEHICLETableAdapter.Fill(Me.SignalogDataSet.VEHICLE)
            Try
                VehNum.SelectedValue = VEHICLETableAdapter.ReturnVEHNUM(VEHICLETableAdapter.ReturnMaxID - 1)
            Catch
            End Try
        End If

        If NewArea = True Then
            NewArea = False
            Me.CUS0TableAdapter.Fill(Me.SignalogDataSet.CUS0)
            Try
                CityAgency.SelectedValue = CUS0TableAdapter.ReturnAreaName(CUS0TableAdapter.ReturnMAXAREANUM - 1)
            Catch
            End Try
        End If

        If NewEWLOC = True Then
            NewEWLOC = False
            Me.EWLOCTableAdapter.FillByArea(Me.SignalogDataSet.EWLOC, Area)
            Try
                EWLOCBox.SelectedValue = LOC0TableAdapter.ReturnEWLOC(LOC0TableAdapter.ReturnMAXLOCNUM - 1)
                NSLOCBox.SelectedValue = LOC0TableAdapter.ReturnNSLOC(LOC0TableAdapter.ReturnMAXLOCNUM - 1)
            Catch
            End Try
        End If


        If NewNSLOC = True Then
            NewNSLOC = False
            Me.NSLOCTableAdapter.FillByEWLOC(Me.SignalogDataSet.NSLOC, Area, EWLOC)
            Try
                NSLOCBox.SelectedValue = LOC0TableAdapter.ReturnNSLOC(LOC0TableAdapter.ReturnMAXLOCNUM - 1)
            Catch
            End Try
        End If
    End Sub

    Private Sub EnterBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterBy.SelectedIndexChanged
        If EnterBy.SelectedValue = "NEW" Then  'To add a new item
            MsgBox("New Entries Must Be Added By Administrator!" & vbCrLf & "Please contact the Tulsa Office for assistance.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub VehNum_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehNum.SelectedIndexChanged
        If VehNum.SelectedValue = "NEW" Then  'To add a new item
            MsgBox("New Entries Must Be Added By Administrator!" & vbCrLf & "Please contact the Tulsa Office for assistance.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click
        If txtactnum.Text <> String.Empty Then
            PreviousID = Convert.ToInt32(txtactnum.Text)
        Else
            PreviousID = 0
        End If
        NewRecord = True
        fwd.Enabled = False
        bck.Enabled = False
        LoadStuff.Enabled = False
        EnterBy.Enabled = True
        YES.Enabled = True
        NO.Enabled = True
        RcvDate.Enabled = True
        RcvTime.Enabled = True
        ReportedBy.Enabled = True
        CityAgency.Enabled = True
        EWLOCBox.Enabled = True
        NSLOCBox.Enabled = True
        PhoneNum.Enabled = True
        RepByName.Enabled = True
        ProbRepPanel.Enabled = True
        Submit.Enabled = True

        txtactnum.Text = LOCKNEWTableAdapter.ReturnLockValue("TroubleReport") + 1   'Assign AREANUM= highest LOCK value +1
        Call Load_Activity()
        txtactnum.ReadOnly = True
        PhoneNum.Text = ""
        RepByName.Text = ""

        NewButton.Enabled = False
        UndoButton.Enabled = True
        EditButton.Enabled = False
        DeleteButton.Enabled = False

        ArrConPanel.Enabled = False
        ActTakPanel.Enabled = False
        DefActPanel.Enabled = False
        DepConPanel.Enabled = False
        EquipInsPanel.Enabled = False
        EquipRemPanel.Enabled = False
        DateTimePanel.Enabled = False
        TechnicianPanel.Enabled = False

        EnterBy.Text = PERS0TableAdapter.ReturnPListNameAtUserName(Login.User)    'Automatically set enter by to user logged in
        YES.Checked = True    'By default show is YES
    End Sub

    Private Sub UndoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoButton.Click
        If NewRecord = True Then
            If txtactnum.Text = ACT0TableAdapter.ReturnMaxACTNUM Then    'Return to previous NewLock value
                LOCKNEWTableAdapter.UpdateLockValue(txtactnum.Text - 1, "TroubleReport")
            End If
        End If

        If EditRecord = True Then   'Release edit lock
            LOCKEDITTableAdapter.DeleteAtDescValue("TroubleReport", txtactnum.Text)
        End If
        EditRecord = False
        NewRecord = False
        NewButton.Enabled = True
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        bck.Enabled = True
        fwd.Enabled = True
        LoadStuff.Enabled = True
        txtactnum.ReadOnly = False
        txtactnum.Text = ""
        Call Load_Activity()
        If PreviousID <> 0 Then
            txtactnum.Text = PreviousID
            Call Load_Activity()
        End If

        UndoButton.Enabled = False
        If txtactnum.Text <> String.Empty Then
            If ACT0TableAdapter.ReturnEDITABLE(txtactnum.Text) = "Y" Then
                Submit.Enabled = True
            Else
                Submit.Enabled = False
            End If
        End If
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to delete the selected activity?", MsgBoxStyle.YesNo, "Delete Activity Record?")
        If result = MsgBoxResult.Yes Then
            If txtactnum.Text = ACT0TableAdapter.ReturnMaxACTNUM Then    'Return to previous NewLock value 
                LOCKNEWTableAdapter.UpdateLockValue(txtactnum.Text - 1, "TroubleReport")
            End If
            ACT0TableAdapter.DELETE_ACTNUM(txtactnum.Text)
            ACT1TableAdapter.DELETE_ACTNUM(txtactnum.Text)
            ACT2TableAdapter.DeleteAtACTNUM(txtactnum.Text)
            ACT9TableAdapter.DeleteAtACTNUM(txtactnum.Text)

            'If Installed & Unique -> restore status to In Inventory
            'If Removed & Unique -> restore status to Installed
            'If Installed & Local & Non-unique -> add quantity back to stock (EQUIPMENT Table)
            Dim PartID, Q As Integer
            Dim WareHouse As String
            For i = 1 To ACT3TableAdapter.ReturnRecords(txtactnum.Text, 1)    'Installed
                If ACT3TableAdapter.ReturnSrc(txtactnum.Text, 1, i) = 1 Then    'Local
                    PartID = ACT3TableAdapter.ReturnPartID(txtactnum.Text, 1, i)
                    WareHouse = ACT3TableAdapter.ReturnWareHouse(txtactnum.Text, 1, i)
                    If EQUIPMENTTableAdapter.ReturnPartDesc(PartID, WareHouse) <> "Miscellaneous" Then 'Not the special case
                        If EQUIPMENTTableAdapter.ReturnSerial(PartID, WareHouse) = "None" Then  'A non-Unique part
                            Q = EQUIPMENTTableAdapter.ReturnQuantityAtID(PartID, WareHouse)
                            Q += ACT3TableAdapter.ReturnQuantity(txtactnum.Text, 1, i)
                            EQUIPMENTTableAdapter.UpdateQuantity(Q, PartID, WareHouse)
                        Else   'Unique part
                            EQUIPMENTTableAdapter.UpdateStatus(1, PartID, WareHouse)
                        End If
                    End If
                End If
            Next i
            For i = 1 To ACT3TableAdapter.ReturnRecords(txtactnum.Text, 2)    'Removed
                PartID = ACT3TableAdapter.ReturnPartID(txtactnum.Text, 2, i)
                WareHouse = ACT3TableAdapter.ReturnWareHouse(txtactnum.Text, 2, i)
                If ACT3TableAdapter.ReturnSrc(txtactnum.Text, 2, i) = 1 Then    'Local
                    If EQUIPMENTTableAdapter.ReturnSerial(PartID, WareHouse) <> "None" Then    'Unique part
                        EQUIPMENTTableAdapter.UpdateStatus(2, PartID, WareHouse)
                    End If
                ElseIf ACT3TableAdapter.ReturnSrc(txtactnum.Text, 2, i) = 2 Then    'City Owned
                    If EQUIPMENT2TableAdapter.ReturnSerial(PartID) <> "None" Then    'Unique part
                        EQUIPMENT2TableAdapter.UpdateStatus(2, PartID)
                    End If
                End If
            Next

            ACT3TableAdapter.DeleteAtACTNUM(txtactnum.Text)
            StockControlTableAdapter.DeleteAtACTNUM(txtactnum.Text)

            txtactnum.Text = ""
            Call Load_Activity()
        End If
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        If LOCKEDITTableAdapter.ReturnDescValueCOUNT("TroubleReport", txtactnum.Text) <> 0 Then   'If locked for editing
            MsgBox("This trouble report record is being edited by another user, please try editing later", MsgBoxStyle.Information)
        Else
            LOCKEDITTableAdapter.Insert("TroubleReport", txtactnum.Text)  'Lock for editing
            PreviousID = Convert.ToInt32(txtactnum.Text)
            EditButton.Enabled = False
            EditRecord = True
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            UndoButton.Enabled = True
            txtactnum.ReadOnly = True
            bck.Enabled = False
            fwd.Enabled = False
            LoadStuff.Enabled = False
            Submit.Enabled = True

            editable = ACT0TableAdapter.ReturnEDITABLE(txtactnum.Text)

            If editable = "Y" Then
                EnterBy.Enabled = True
                YES.Enabled = True
                NO.Enabled = True
                RcvDate.Enabled = True
                RcvTime.Enabled = True
                ReportedBy.Enabled = True
                CityAgency.Enabled = True
                EWLOCBox.Enabled = True
                NSLOCBox.Enabled = True
                PhoneNum.Enabled = True
                RepByName.Enabled = True
                ProbRepPanel.Enabled = True
                ArrConPanel.Enabled = False
                ActTakPanel.Enabled = False
                DefActPanel.Enabled = False
                DepConPanel.Enabled = False
                EquipInsPanel.Enabled = False
                EquipRemPanel.Enabled = False
                DateTimePanel.Enabled = False
                TechnicianPanel.Enabled = False
                EditSecondPart = False

            Else  'Editable="N" which means have to edit all (including second part)
                EnterBy.Enabled = True
                YES.Enabled = True
                NO.Enabled = True
                RcvDate.Enabled = True
                RcvTime.Enabled = True
                ReportedBy.Enabled = True
                CityAgency.Enabled = True
                EWLOCBox.Enabled = True
                NSLOCBox.Enabled = True
                PhoneNum.Enabled = True
                RepByName.Enabled = True
                ProbRepPanel.Enabled = True
                ArrConPanel.Enabled = True
                ActTakPanel.Enabled = True
                DefActPanel.Enabled = True
                DepConPanel.Enabled = True
                EquipInsPanel.Enabled = True
                EquipRemPanel.Enabled = True
                DateTimePanel.Enabled = True
                TechnicianPanel.Enabled = True
                EditSecondPart = True
            End If
        End If
    End Sub

    Private Sub BegMil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BegMil.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))    'allow to enter numbers only 
    End Sub

    Private Sub EndMil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EndMil.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))    'allow to enter numbers only 
    End Sub

    Private Sub RcvDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RcvDate.ValueChanged
        BegDate.Value = RcvDate.Value
        ArrDate.Value = RcvDate.Value
        DepDate.Value = RcvDate.Value
        EndDate.Value = RcvDate.Value
    End Sub

    Private Sub BegDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BegDate.ValueChanged
        ArrDate.Value = BegDate.Value
        DepDate.Value = BegDate.Value
        EndDate.Value = BegDate.Value
    End Sub

    Private Sub WorkTime()
        Dim BegHr, BegMin, EndHr, EndMin, RegHrs, OTHrs, MinHrs, RegRate, OTRate, RegAmt, OTAmt As Decimal
        Dim WorkDate As Date
        Dim holiday As Integer

        WorkDate = EndDate.Value
        holiday = HolidaysTableAdapter.ReturnHoliday(WorkDate)
        Try
            LOCNUM = ACT0TableAdapter.ReturnLOCNUM(txtactnum.Text)
            RegRate = CUS0TableAdapter.ReturnRegRate(LOC0TableAdapter.ReturnAREANUM(LOCNUM))
            OTRate = CUS0TableAdapter.ReturnOTRate(LOC0TableAdapter.ReturnAREANUM(LOCNUM))
            MinHrs = CUS0TableAdapter.ReturnMinHrs(LOC0TableAdapter.ReturnAREANUM(LOCNUM))
        Catch
        End Try

        BegHr = BegTime.Value.Hour
        BegMin = BegTime.Value.Minute
        EndHr = EndTime.Value.Hour
        EndMin = EndTime.Value.Minute

        If EndDate.Value.Date <> BegDate.Value.Date Then   'Special case if beg work date and end work date are different
            EndHr += 24 * (EndDate.Value.Date.Subtract(BegDate.Value.Date).Days)
        End If

        'Weekend or holiday
        If WorkDate.DayOfWeek = DayOfWeek.Saturday Or WorkDate.DayOfWeek = DayOfWeek.Sunday Or holiday <> 0 Then
            OTHrs = (EndHr - BegHr - 1) + ((EndMin + (60 - BegMin)) / 60)
            RegHrs = 0
            If OTHrs < MinHrs And ActHrsNo.Checked = True Then
                OTHrs = MinHrs
            End If
        Else  'Monday to Fiday & not holiday
            If (BegHr >= 7 And BegHr < 17 And EndHr <> 17) Or (BegHr >= 7 And EndHr = 17 And EndMin = 0) Then     'regular only
                RegHrs = (EndHr - BegHr - 1) + ((EndMin + (60 - BegMin)) / 60)
                OTHrs = 0
                If RegHrs < MinHrs And ActHrsNo.Checked = True Then
                    RegHrs = MinHrs
                End If
            ElseIf (BegHr < 7 And EndHr < 7) Or (BegHr < 7 And EndHr = 7 And EndMin = 0) Or (BegHr >= 17 And EndHr > 17) Or (BegHr = 17 And EndHr = 17) Then   'overtime  only
                OTHrs = (EndHr - BegHr - 1) + ((EndMin + (60 - BegMin)) / 60)
                RegHrs = 0
                If OTHrs < MinHrs And ActHrsNo.Checked = True Then
                    OTHrs = MinHrs
                End If
            ElseIf (BegHr < 7 And EndHr > 7) Or (BegHr < 7 And EndHr = 7 And EndMin <> 0) Then   'regulartime and overtime
                OTHrs = (7 - BegHr - 1) + ((60 - BegMin) / 60)
                RegHrs = (EndHr - 7) + (EndMin / 60)
                If (OTHrs + RegHrs) < MinHrs And ActHrsNo.Checked = True Then
                    RegHrs = MinHrs - OTHrs
                End If
            ElseIf (BegHr < 17 And EndHr > 17) Or (BegHr < 17 And EndHr = 17 And EndMin <> 0) Then   'regulartime and overtime
                OTHrs = (EndHr - 17) + (EndMin / 60)
                RegHrs = (17 - BegHr - 1) + ((60 - BegMin) / 60)
                If (RegHrs + OTHrs) < MinHrs And ActHrsNo.Checked = True Then
                    RegHrs = MinHrs - OTHrs
                End If
            End If
        End If

        RegAmt = FormatNumber(RegHrs, 2) * FormatNumber(RegRate, 2)
        OTAmt = FormatNumber(OTHrs, 2) * FormatNumber(OTRate, 2)

        RegHrstxt.Text = FormatNumber(RegHrs, 2)
        RegRatetxt.Text = FormatNumber(RegRate, 2)
        RegAmttxt.Text = FormatNumber(RegAmt, 2)
        OTHrstxt.Text = FormatNumber(OTHrs, 2)
        OTRatetxt.Text = FormatNumber(OTRate, 2)
        OTAmttxt.Text = FormatNumber(OTAmt, 2)
    End Sub

    Private Sub RegHrstxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RegHrstxt.KeyPress
        e.Handled = TrapKey2(Asc(e.KeyChar))
    End Sub

    Private Sub RegRatetxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RegRatetxt.KeyPress
        e.Handled = TrapKey2(Asc(e.KeyChar))
    End Sub

    Private Sub RegAmttxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RegAmttxt.KeyPress
        e.Handled = TrapKey2(Asc(e.KeyChar))
    End Sub

    Private Sub OTHrstxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OTHrstxt.KeyPress
        e.Handled = TrapKey2(Asc(e.KeyChar))
    End Sub

    Private Sub OTRatetxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OTRatetxt.KeyPress
        e.Handled = TrapKey2(Asc(e.KeyChar))
    End Sub

    Private Sub OTAmttxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OTAmttxt.KeyPress
        e.Handled = TrapKey2(Asc(e.KeyChar))
    End Sub

    Private Sub BegTime_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BegTime.ValueChanged
        If NewRecord = False And txtactnum.Text <> "" Then
            WorkTime()
        End If
    End Sub

    Private Sub EndTime_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndTime.ValueChanged
        If NewRecord = False And txtactnum.Text <> "" Then
            WorkTime()
        End If
    End Sub

    Private Sub RegHrstxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegHrstxt.TextChanged
        If RegHrstxt.Text <> String.Empty And RegRatetxt.Text <> String.Empty Then
            Try
                RegAmttxt.Text = Convert.ToString(FormatNumber(Convert.ToDouble(RegHrstxt.Text), 2) * FormatNumber(Convert.ToDouble(RegRatetxt.Text), 2))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub RegRatetxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegRatetxt.TextChanged
        If RegHrstxt.Text <> String.Empty And RegRatetxt.Text <> String.Empty Then
            Try
                RegAmttxt.Text = Convert.ToString(FormatNumber(Convert.ToDouble(RegHrstxt.Text), 2) * FormatNumber(Convert.ToDouble(RegRatetxt.Text), 2))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub OTHrstxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OTHrstxt.TextChanged
        If OTHrstxt.Text <> String.Empty And OTRatetxt.Text <> String.Empty Then
            Try
                OTAmttxt.Text = Convert.ToString(FormatNumber(Convert.ToDouble(OTHrstxt.Text), 2) * FormatNumber(Convert.ToDouble(OTRatetxt.Text), 2))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub OTRatetxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OTRatetxt.TextChanged
        If OTHrstxt.Text <> String.Empty And OTRatetxt.Text <> String.Empty Then
            Try
                OTAmttxt.Text = Convert.ToString(FormatNumber(Convert.ToDouble(OTHrstxt.Text), 2) * FormatNumber(Convert.ToDouble(OTRatetxt.Text), 2))
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ActHrsYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActHrsYes.CheckedChanged
        WorkTime()
    End Sub

    Private Sub ActHrsNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActHrsNo.CheckedChanged
        WorkTime()
    End Sub

End Class
