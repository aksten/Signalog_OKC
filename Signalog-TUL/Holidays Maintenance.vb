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

Public Class Holidays_Maintenance
    Dim selectedYear As String
    Dim selectedHoliday As String
    Dim NewRecord As Boolean
    Dim EditRecord, flag As Boolean
    Public NewHoliday As Boolean

    Private Sub Holidays_Maintenance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Submit.Enabled = True Then
            If MsgBox("Are you sure you want to exit without saving changes?", MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                UndoButton.PerformClick()
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub Holidays_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Holiday_ListTableAdapter.Fill(Me.SignalogDataSet.Holiday_List)
        Me.HolidayYearTableAdapter.Fill(Me.SignalogDataSet.HolidayYear)
        HolidayName.Enabled = False
        HolidayDate.Enabled = False
        Submit.Enabled = False
        UndoButton.Enabled = False
        LoadData2()
        NewHoliday = False
    End Sub

    Private Sub Year_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Year.SelectedIndexChanged
        If Year.SelectedValue <> String.Empty Then
            LoadData2()
        End If
    End Sub

    Private Sub Holidays_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Holidays.SelectedIndexChanged
        If Holidays.SelectedValue <> String.Empty Then
            LoadData1()
        End If
    End Sub

    Private Sub fwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwd.Click
        Dim i As Integer
        If HolidayID.Text = "" Or HolidayID.Text = Convert.ToString(HolidaysTableAdapter.ReturnMaxID) Then
            HolidayID.Text = HolidaysTableAdapter.ReturnMinID
        Else
            i = HolidayID.Text + 1
            While HolidaysTableAdapter.ReturnCountID(i) = 0 And HolidaysTableAdapter.ReturnMaxID > i
                i += 1
            End While
            If HolidaysTableAdapter.ReturnCountID(i) = 0 Then
                HolidayID.Text = HolidaysTableAdapter.ReturnMinID
            Else
                HolidayID.Text = i
            End If
        End If
    End Sub

    Private Sub bck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bck.Click
        Dim i As Integer
        If HolidayID.Text = "" Or HolidayID.Text = Convert.ToString(HolidaysTableAdapter.ReturnMinID) Then
            If HolidaysTableAdapter.ReturnCountID(HolidaysTableAdapter.ReturnMaxID) <> 0 Then
                HolidayID.Text = HolidaysTableAdapter.ReturnMaxID
            Else
                i = HolidaysTableAdapter.ReturnMaxID
                While HolidaysTableAdapter.ReturnCountID(i) = 0 And i > 1
                    i -= 1
                End While
                HolidayID.Text = i
            End If
        Else
            i = HolidayID.Text - 1
            While HolidaysTableAdapter.ReturnCountID(i) = 0 And i > 1
                i -= 1
            End While
            HolidayID.Text = i
        End If
    End Sub

    Private Sub HolidayID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles HolidayID.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Sub LoadData1()
        Try
            selectedHoliday = Holidays.SelectedValue
            HolidayID.Text = HolidaysTableAdapter.ReturnID(selectedHoliday, selectedYear)
            HolidayName.Text = selectedHoliday
            HolidayDate.Text = HolidaysTableAdapter.ReturnDate(selectedHoliday, selectedYear)
        Catch
        End Try
    End Sub

    Sub LoadData2()
        Try
            selectedYear = Year.SelectedValue
            HolidaysTableAdapter.FillByYear(Me.SignalogDataSet.Holidays, selectedYear)
            selectedHoliday = Holidays.SelectedValue
            HolidayID.Text = HolidaysTableAdapter.ReturnID(selectedHoliday, selectedYear)
            HolidayName.Text = selectedHoliday
            HolidayDate.Text = HolidaysTableAdapter.ReturnDate(selectedHoliday, selectedYear)
        Catch
        End Try
    End Sub

    Private Function TrapKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function

    Private Sub HolidayID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HolidayID.TextChanged
        Dim Id As String
        Id = HolidayID.Text
        If HolidayID.Text <> "" And NewRecord = False Then
            If (HolidayID.Text > HolidaysTableAdapter.ReturnMaxID) Or (HolidaysTableAdapter.ReturnCountID(HolidayID.Text) = 0) Then
                MsgBox("No record found for the entered Holiday ID", MsgBoxStyle.Exclamation)
                HolidayID.Text = ""
                HolidayName.Text = ""
                HolidayDate.Text = ""
            Else
                Try
                    selectedYear = HolidaysTableAdapter.ReturnYear(Id)
                    Year.SelectedValue = selectedYear
                    selectedHoliday = HolidaysTableAdapter.ReturnHol(Id)
                    Holidays.SelectedValue = selectedHoliday
                    HolidayName.Text = selectedHoliday
                    HolidayDate.Text = HolidaysTableAdapter.ReturnDateAtID(Id)
                Catch
                End Try
            End If
        End If
        If HolidayID.Text = String.Empty Then
            HolidayID.Text = ""
            HolidayName.Text = ""
            HolidayDate.Text = ""
        End If
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to delete the selected holiday?", MsgBoxStyle.YesNo, "Delete Holiday?")
        If result = MsgBoxResult.Yes Then
            HolidaysTableAdapter.DeleteAtID(HolidayID.Text)
            LoadData2()
        End If
    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click
        NewRecord = True
        NewButton.Enabled = False
        UndoButton.Enabled = True
        EditButton.Enabled = False
        DeleteButton.Enabled = False
        Holidays.Enabled = False
        Year.Enabled = False
        HolidayID.Enabled = False
        fwd.Enabled = False
        bck.Enabled = False
        HolidayName.Enabled = True
        HolidayDate.Enabled = True
        Submit.Enabled = True
        HolidayName.Text = ""
        HolidayID.Text = LOCKNEWTableAdapter.ReturnLockValue("Holiday") + 1   'Assign AREANUM= highest LOCK value +1
        LOCKNEWTableAdapter.UpdateLockValue(HolidayID.Text, "Holiday")  'Update LOCK
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        If LOCKEDITTableAdapter.ReturnDescValueCOUNT("Holiday", HolidayID.Text) <> 0 Then   'If locked for editing
            MsgBox("This holiday record is being edited by another user, please try editing later", MsgBoxStyle.Information)
        Else
            LOCKEDITTableAdapter.Insert("Holiday", HolidayID.Text)  'Lock for editing
            LoadData1()

            EditButton.Enabled = False
            EditRecord = True
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            UndoButton.Enabled = True
            HolidayID.Enabled = False
            Year.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
            Holidays.Enabled = False
            HolidayName.Enabled = True
            HolidayDate.Enabled = True
            Submit.Enabled = True
        End If
    End Sub

    Private Sub UndoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoButton.Click
        If EditRecord = True Then   'Release edit lock
            LOCKEDITTableAdapter.DeleteAtDescValue("Holiday", HolidayID.Text)
        End If
        EditRecord = False
        NewRecord = False
        NewButton.Enabled = True
        Holidays.Enabled = True
        Year.Enabled = True
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        HolidayID.Enabled = True
        bck.Enabled = True
        fwd.Enabled = True
        UndoButton.Enabled = False
        HolidayName.Enabled = False
        HolidayDate.Enabled = False
        Submit.Enabled = False

        If Holidays.SelectedValue <> String.Empty Then   'Reloading
            LoadData1()
        End If
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        flag = False
        Dim previousID As Integer
        previousID = HolidayID.Text
        If NewRecord = True Then
            If HolidaysTableAdapter.ReturnHolidayYearCOUNTnew(HolidayName.SelectedValue, HolidayDate.Value.Year) <> 0 Then
                If MsgBox("Holiday already exists for this year,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new holiday entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    HolidayName.DroppedDown = True
                End If
                flag = True   'Don't submit
            Else
                If HolidayName.Text = String.Empty Or HolidayName.Text = "NEW" Then  'or HolidayName .Text ="NEW", if closed holiday_list_maint without creating a new holiday
                    MsgBox("Please select Holiday", MsgBoxStyle.Exclamation, "Missing Field")
                    HolidayName.DroppedDown = True
                    flag = True
                Else
                    HolidaysTableAdapter.Insert(HolidayID.Text, HolidayName.SelectedValue, HolidayDate.Value.Date, HolidayDate.Value.Year)
                    NewRecord = False
                End If
            End If
        End If

        If EditRecord = True Then
            If HolidaysTableAdapter.ReturnHolidayYearCOUNTedit(HolidayName.SelectedValue, HolidayDate.Value.Year, HolidayID.Text) <> 0 Then
                If MsgBox("Holiday already exists for this year,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new holiday entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    HolidayName.DroppedDown = True
                End If
                flag = True   'Don't submit
            Else
                If HolidayName.Text = String.Empty Or HolidayName.Text = "NEW" Then  'or HolidayName .Text ="NEW", if closed holiday_list_maint without creating a new holiday
                    MsgBox("Please select Holiday", MsgBoxStyle.Exclamation, "Missing Field")
                    HolidayName.DroppedDown = True
                    flag = True
                Else
                    LOCKEDITTableAdapter.DeleteAtDescValue("Holiday", HolidayID.Text)   'Release Edit LOCK
                    HolidaysTableAdapter.UpdateAtHolID(HolidayName.SelectedValue, HolidayDate.Value.Date, HolidayDate.Value.Year, HolidayID.Text)
                    EditRecord = False
                End If
            End If
        End If

        If flag = False Then
            NewButton.Enabled = True
            Holidays.Enabled = True
            Year.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = True
            HolidayID.Enabled = True
            bck.Enabled = True
            fwd.Enabled = True
            UndoButton.Enabled = False
            HolidayName.Enabled = False
            HolidayDate.Enabled = False
            Submit.Enabled = False

            If Holidays.SelectedValue <> String.Empty Then   'Reloading
                Holidays.SelectedValue = HolidaysTableAdapter.ReturnHol(previousID)
                Me.HolidaysTableAdapter.FillByYear(Me.SignalogDataSet.Holidays, HolidayDate.Value.Year)
                Year.SelectedValue = HolidayDate.Value.Year
            End If
            HolidayYearTableAdapter.Fill(Me.SignalogDataSet.HolidayYear)
        End If
    End Sub

    Private Sub HolidayName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HolidayName.SelectedIndexChanged
        If HolidayName.SelectedValue = "NEW" Then
            If Holiday_List_Maintenance.Visible = True Then
                MsgBox("Can't open Holiday List Maintenance, form is already open" & vbCrLf & "Please close Holiday List Maintenance and retry", MsgBoxStyle.Exclamation)
            Else
                NewHoliday = True
                Holiday_List_Maintenance.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Holidays_Maintenance_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.TextChanged
        Me.Text = "Holidays Maintenance"
        Me.Holiday_ListTableAdapter.Fill(Me.SignalogDataSet.Holiday_List)
        Try
            HolidayName.SelectedValue = Holiday_ListTableAdapter.ReturnHol(Holiday_ListTableAdapter.ReturnMaxID - 1)
        Catch
        End Try
    End Sub

End Class