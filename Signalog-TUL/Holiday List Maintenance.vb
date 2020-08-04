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

Public Class Holiday_List_Maintenance
    Dim selectedHol, oldHoliday As String
    Dim NewRecord As Boolean
    Dim EditRecord, flag As Boolean
    Dim sh, Fsh As String

    Private Sub Holiday_List_Maintenance_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Holidays_Maintenance.NewHoliday = False
    End Sub

    Private Sub Holiday_List_Maintenance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Submit.Enabled = True Then
            If MsgBox("Are you sure you want to exit without saving changes?", MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                UndoButton.PerformClick()
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub Holiday_List_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Holiday_ListTableAdapter.Fill2(Me.SignalogDataSet.Holiday_List)
        HolName.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        Submit.Enabled = False
        UndoButton.Enabled = False
        NewRecord = False
        EditRecord = False
        Filters.Checked = True
        FilterBoth.Checked = True
        HolidayID.Enabled = False
        bck.Enabled = False
        fwd.Enabled = False
        Fill()
        GetHol()
        LoadData()
    End Sub

    Private Sub Holidays_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Holidays.SelectedIndexChanged
        GetHol()
        LoadData()
    End Sub

    Private Sub HolidayID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles HolidayID.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Sub ID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID.CheckedChanged
        If ID.Checked = True Then
            LoadPanel.Enabled = False
            HolidayID.Enabled = True
            bck.Enabled = True
            fwd.Enabled = True
            FilterBoth.Checked = True
        Else
            LoadPanel.Enabled = True
            HolidayID.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
        End If

        Fill()
        GetHol()
        LoadData()
    End Sub

    Private Sub HolidayID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HolidayID.TextChanged
        If HolidayID.Text <> "" And NewRecord = False Then
            If (HolidayID.Text > Holiday_ListTableAdapter.ReturnMaxID - 1) Or (Holiday_ListTableAdapter.ReturnCountID(HolidayID.Text) = 0) Then
                MsgBox("No record found for entered Manuf.ID", MsgBoxStyle.Exclamation)
                HolidayID.Text = ""
                HolName.Text = ""
                YES.Checked = False
                NO.Checked = False
            Else
                Try
                    selectedHol = Holiday_ListTableAdapter.ReturnHol(HolidayID.Text)
                    Holidays.SelectedValue = selectedHol
                    HolName.Text = selectedHol
                    sh = Holiday_ListTableAdapter.ReturnShow(selectedHol)
                    If sh = "Y" Then
                        YES.Checked = True
                        NO.Checked = False
                    Else
                        NO.Checked = True
                        YES.Checked = False
                    End If
                Catch
                End Try
            End If
        End If
        If HolidayID.Text = String.Empty Then
            HolidayID.Text = ""
            HolName.Text = ""
            YES.Checked = False
            NO.Checked = False
        End If
    End Sub

    Private Sub fwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwd.Click
        Dim i As Integer
        If HolidayID.Text = "" Or HolidayID.Text = Convert.ToString(Holiday_ListTableAdapter.ReturnMaxID - 1) Then
            HolidayID.Text = Holiday_ListTableAdapter.ReturnMinID
        Else
            i = HolidayID.Text + 1
            While Holiday_ListTableAdapter.ReturnCountID(i) = 0 And Holiday_ListTableAdapter.ReturnMaxID - 1 > i
                i += 1
            End While
            If Holiday_ListTableAdapter.ReturnCountID(i) = 0 Then
                HolidayID.Text = Holiday_ListTableAdapter.ReturnMinID
            Else
                HolidayID.Text = i
            End If
        End If
    End Sub

    Private Sub bck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bck.Click
        Dim i As Integer
        If HolidayID.Text = "" Or HolidayID.Text = Convert.ToString(Holiday_ListTableAdapter.ReturnMinID) Then
            If Holiday_ListTableAdapter.ReturnCountID(Holiday_ListTableAdapter.ReturnMaxID - 1) <> 0 Then
                HolidayID.Text = Holiday_ListTableAdapter.ReturnMaxID - 1
            Else
                i = Holiday_ListTableAdapter.ReturnMaxID - 1
                While Holiday_ListTableAdapter.ReturnCountID(i) = 0 And i > 1
                    i -= 1
                End While
                HolidayID.Text = i
            End If
        Else
            i = HolidayID.Text - 1
            While Holiday_ListTableAdapter.ReturnCountID(i) = 0 And i > 1
                i -= 1
            End While
            HolidayID.Text = i
        End If
    End Sub

    Private Function TrapKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If HolidaysTableAdapter.ReturnHolidayNameCOUNT(HolName.Text) Then
            MsgBox("Delete forbidden, holiday name is associated with one or more holidays", MsgBoxStyle.Exclamation, "Delete Forbidden")
        Else
            Dim result As MsgBoxResult
            result = MsgBox("Are you sure you want to delete the selected holiday?", MsgBoxStyle.YesNo, "Delete Holiday?")
            If result = MsgBoxResult.Yes Then
                Holiday_ListTableAdapter.DeleteAtID(HolidayID.Text)
                Fill()
                GetHol()
                LoadData()
            End If
        End If
    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click
        NewRecord = True
        NewButton.Enabled = False
        UndoButton.Enabled = True
        EditButton.Enabled = False
        DeleteButton.Enabled = False
        LoadPanel.Enabled = False
        Label13.Visible = False
        LoadByPanel.Visible = False
        HolidayID.Enabled = False
        fwd.Enabled = False
        bck.Enabled = False
        HolName.Enabled = True
        YES.Enabled = True
        NO.Enabled = True
        Submit.Enabled = True
        HolName.Text = ""
        YES.Checked = False
        NO.Checked = False
        HolidayID.Text = LOCKNEWTableAdapter.ReturnLockValue("HolidayList") + 1   'Assign AREANUM= highest LOCK value +1
        LOCKNEWTableAdapter.UpdateLockValue(HolidayID.Text, "HolidayList")  'Update LOCK
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        If LOCKEDITTableAdapter.ReturnDescValueCOUNT("HolidayList", HolidayID.Text) <> 0 Then   'If locked for editing
            MsgBox("This holiday record is being edited by another user, please try editing later", MsgBoxStyle.Information)
        Else
            LOCKEDITTableAdapter.Insert("HolidayList", HolidayID.Text)  'Lock for editing
            GetHol()
            LoadData()

            EditButton.Enabled = False
            EditRecord = True
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            UndoButton.Enabled = True
            LoadByPanel.Visible = False
            LoadPanel.Enabled = False
            Label13.Visible = False
            HolidayID.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
            HolName.Enabled = True
            YES.Enabled = True
            NO.Enabled = True
            Submit.Enabled = True
            oldHoliday = HolName.Text
        End If
    End Sub

    Private Sub UndoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoButton.Click
        If EditRecord = True Then   'Release edit lock
            LOCKEDITTableAdapter.DeleteAtDescValue("HolidayList", HolidayID.Text)
        End If
        EditRecord = False
        NewRecord = False
        NewButton.Enabled = True
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        Label13.Visible = True
        LoadPanel.Enabled = True
        LoadByPanel.Visible = True

        If Filters.Checked = True Then
            HolidayID.Enabled = False
            LoadPanel.Enabled = True
            bck.Enabled = False
            fwd.Enabled = False
        Else
            HolidayID.Enabled = True
            LoadPanel.Enabled = False
            bck.Enabled = True
            fwd.Enabled = True
        End If

        UndoButton.Enabled = False
        HolName.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        Submit.Enabled = False

        If Holidays_Maintenance.NewHoliday = True Then
            Holidays_Maintenance.NewHoliday = False
        End If

        GetHol()
        LoadData()
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        flag = False
        Dim previousID As Integer
        previousID = HolidayID.Text
        If NewRecord = True Then
            If Holiday_ListTableAdapter.ReturnHolidayNameCOUNTnew(HolName.Text) <> 0 Then
                If MsgBox("Holiday already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new holiday entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    HolName.Text = ""
                    HolName.Focus()
                End If
                flag = True   'Don't submit
            Else
                If HolName.Text = String.Empty Then
                    MsgBox("Please enter Holiday Name", MsgBoxStyle.Exclamation, "Missing Field")
                    HolName.Focus()
                    flag = True
                ElseIf YES.Checked = False And NO.Checked = False Then
                    MsgBox("Please select YES or NO for the Show field", MsgBoxStyle.Exclamation, "Missing Field")
                    flag = True
                Else
                    If YES.Checked = True Then
                        sh = "Y"
                    Else
                        sh = "N"
                    End If
                    Holiday_ListTableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("HolidayList") + 1, Holiday_ListTableAdapter.ReturnID("NEW")) 'Increment NEW ID
                    Holiday_ListTableAdapter.Insert(HolidayID.Text, HolName.Text, sh)
                    Me.Holiday_ListTableAdapter.Fill2(Me.SignalogDataSet.Holiday_List)
                    NewRecord = False
                End If
            End If
        End If
        If EditRecord = True Then
            If Holiday_ListTableAdapter.ReturnHolidayNameCOUNTedit(HolName.Text, HolidayID.Text) <> 0 Then
                If MsgBox("Holiday already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new holiday entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    HolName.Text = ""
                    HolName.Focus()
                End If
                flag = True   'Don't submit
            Else
                If HolName.Text = String.Empty Then
                    MsgBox("Please enter Holiday Name", MsgBoxStyle.Exclamation, "Missing Field")
                    HolName.Focus()
                    flag = True
                Else
                    If YES.Checked = True Then
                        sh = "Y"
                    Else
                        sh = "N"
                    End If
                    LOCKEDITTableAdapter.DeleteAtDescValue("HolidayList", HolidayID.Text)   'Release Edit LOCK
                    Holiday_ListTableAdapter.UpdateAtHolID(HolName.Text, sh, HolidayID.Text)
                    HolidaysTableAdapter.UpdateHolidayName(HolName.Text, oldHoliday)
                    Me.Holiday_ListTableAdapter.Fill2(Me.SignalogDataSet.Holiday_List)
                    EditRecord = False
                End If
            End If
        End If

        If flag = False Then
            NewButton.Enabled = True
            Parts.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = True
            Label13.Visible = True
            LoadPanel.Enabled = True
            LoadByPanel.Visible = True

            If Filters.Checked = True Then
                HolidayID.Enabled = False
                LoadPanel.Enabled = True
                bck.Enabled = False
                fwd.Enabled = False
            Else
                HolidayID.Enabled = True
                LoadPanel.Enabled = False
                bck.Enabled = True
                fwd.Enabled = True
            End If

            UndoButton.Enabled = False
            HolName.Enabled = False
            YES.Enabled = False
            NO.Enabled = False
            Submit.Enabled = False

            Fill()
            Holidays.SelectedValue = Holiday_ListTableAdapter.ReturnHol(previousID)
        End If

        If Holidays_Maintenance.NewHoliday = True And flag = False Then
            Me.Close()
            Holidays_Maintenance.Text = Holidays_Maintenance.Text & "n"
        End If
    End Sub

    Sub LoadData()
        Try
            HolidayID.Text = Holiday_ListTableAdapter.ReturnID(selectedHol)
            HolName.Text = selectedHol
            sh = Holiday_ListTableAdapter.ReturnShow(selectedHol)
            If sh = "Y" Then
                YES.Checked = True
                NO.Checked = False
            Else
                NO.Checked = True
                YES.Checked = False
            End If
        Catch
        End Try
    End Sub

    Sub Fill()
        If FilterBoth.Checked = True Then
            Holiday_ListTableAdapter.Fill2(Me.SignalogDataSet.Holiday_List)
        Else
            Holiday_ListTableAdapter.FillBySHOW(Me.SignalogDataSet.Holiday_List, Fsh)
        End If
    End Sub

    Private Sub FilterYES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterYES.CheckedChanged
        If FilterYES.Checked = True Then
            Fsh = "Y"
        ElseIf FilterNO.Checked = True Then
            Fsh = "N"
        End If
        Fill()
        GetHol()
        LoadData()
    End Sub

    Private Sub FilterNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterNO.CheckedChanged
        If FilterYES.Checked = True Then
            Fsh = "Y"
        ElseIf FilterNO.Checked = True Then
            Fsh = "N"
        End If
        Fill()
        GetHol()
        LoadData()
    End Sub

    Sub GetHol()
        If Me.SignalogDataSet.Holiday_List.Rows.Count <> 0 Then
            selectedHol = Holidays.SelectedValue
        Else
            selectedHol = ""
        End If
    End Sub

    Private Sub Holiday_List_Maintenance_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Holidays_Maintenance.NewHoliday = True Then
            Me.NewButton.PerformClick()
            Me.YES.Checked = True
        End If
    End Sub

End Class