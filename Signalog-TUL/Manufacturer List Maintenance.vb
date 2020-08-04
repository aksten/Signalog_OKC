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

Public Class Manufacturer_List_Maintenance
    Dim selectedManuf As String
    Dim NewRecord As Boolean
    Dim EditRecord, flag As Boolean
    Dim sh, Fsh As String

    Private Sub Manufacturer_List_Maintenance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Submit.Enabled = True Then
            If MsgBox("Are you sure you want to exit without saving changes?", MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                UndoButton.PerformClick()
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub Manufacturer_List_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MANF_LISTTableAdapter.Fill2(Me.SignalogDataSet.MANF_LIST)
        ManufDesc.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        Submit.Enabled = False
        UndoButton.Enabled = False
        NewRecord = False
        EditRecord = False
        Filters.Checked = True
        FilterBoth.Checked = True
        ManufID.Enabled = False
        bck.Enabled = False
        fwd.Enabled = False
        Fill()
        GetManuf()
        LoadData()
    End Sub

    Private Sub Manuf_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Manuf.SelectedIndexChanged
        GetManuf()
        LoadData()
    End Sub

    Private Sub ID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID.CheckedChanged
        If ID.Checked = True Then
            LoadPanel.Enabled = False
            ManufID.Enabled = True
            bck.Enabled = True
            fwd.Enabled = True
            FilterBoth.Checked = True
        Else
            LoadPanel.Enabled = True
            ManufID.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
        End If

        Fill()
        GetManuf()
        LoadData()
    End Sub

    Private Sub ManufID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManufID.TextChanged
        If ManufID.Text <> "" And NewRecord = False Then
            If (ManufID.Text > MANF_LISTTableAdapter.ReturnMaxID - 1) Or (MANF_LISTTableAdapter.ReturnCountID(ManufID.Text) = 0) Then
                MsgBox("No record found for entered Manuf.ID")
                ManufID.Text = ""
                ManufDesc.Text = ""
                YES.Checked = False
                NO.Checked = False
            Else
                Try
                    selectedManuf = MANF_LISTTableAdapter.ReturnMANUF(ManufID.Text)
                    Manuf.SelectedValue = selectedManuf
                    ManufDesc.Text = selectedManuf
                    sh = MANF_LISTTableAdapter.ReturnShow(selectedManuf)
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
        If ManufID.Text = String.Empty Then
            ManufID.Text = ""
            ManufDesc.Text = ""
            YES.Checked = False
            NO.Checked = False
        End If
    End Sub

    Private Sub fwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwd.Click
        Dim i As Integer
        If ManufID.Text = "" Or ManufID.Text = Convert.ToString(MANF_LISTTableAdapter.ReturnMaxID - 1) Then
            ManufID.Text = MANF_LISTTableAdapter.ReturnMinID
        Else
            i = ManufID.Text + 1
            While MANF_LISTTableAdapter.ReturnCountID(i) = 0 And MANF_LISTTableAdapter.ReturnMaxID - 1 > i
                i += 1
            End While
            If MANF_LISTTableAdapter.ReturnCountID(i) = 0 Then
                ManufID.Text = MANF_LISTTableAdapter.ReturnMinID
            Else
                ManufID.Text = i
            End If
        End If
    End Sub

    Private Sub bck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bck.Click
        Dim i As Integer
        If ManufID.Text = "" Or ManufID.Text = Convert.ToString(MANF_LISTTableAdapter.ReturnMinID) Then
            If MANF_LISTTableAdapter.ReturnCountID(MANF_LISTTableAdapter.ReturnMaxID - 1) <> 0 Then
                ManufID.Text = MANF_LISTTableAdapter.ReturnMaxID - 1
            Else
                i = MANF_LISTTableAdapter.ReturnMaxID - 1
                While MANF_LISTTableAdapter.ReturnCountID(i) = 0 And i > 1
                    i -= 1
                End While
                ManufID.Text = i
            End If
        Else
            i = ManufID.Text - 1
            While MANF_LISTTableAdapter.ReturnCountID(i) = 0 And i > 1
                i -= 1
            End While
            ManufID.Text = i
        End If
    End Sub

    Private Sub ManufID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ManufID.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Function TrapKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If EQUIPMENTTableAdapter.ReturnManufCOUNT(ManufDesc.Text) <> 0 Then
            MsgBox("Delete forbidden, manufacturer is associated with one or more local inventory items", MsgBoxStyle.Exclamation, "Delete Forbidden")
        ElseIf EQUIPMENT2TableAdapter.ReturnManufCOUNT(ManufDesc.Text) <> 0 Then
            MsgBox("Delete forbidden, manufacturer is associated with one or more city owned inventory items", MsgBoxStyle.Exclamation, "Delete Forbidden")
        Else
            Dim result As MsgBoxResult
            result = MsgBox("Are you sure you want to delete the selected record?", MsgBoxStyle.YesNo, "Delete Record?")
            If result = MsgBoxResult.Yes Then
                MANF_LISTTableAdapter.DeleteAtID(ManufID.Text)
                Fill()
                GetManuf()
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
        ManufID.Enabled = False
        fwd.Enabled = False
        bck.Enabled = False
        ManufDesc.Enabled = True
        YES.Enabled = True
        NO.Enabled = True
        Submit.Enabled = True
        ManufDesc.Text = ""
        YES.Checked = False
        NO.Checked = False
        ManufID.Text = LOCKNEWTableAdapter.ReturnLockValue("ManufList") + 1   'Assign AREANUM= highest LOCK value +1
        LOCKNEWTableAdapter.UpdateLockValue(ManufID.Text, "ManufList")  'Update LOCK
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        If LOCKEDITTableAdapter.ReturnDescValueCOUNT("ManufList", ManufID.Text) <> 0 Then   'If locked for editing
            MsgBox("This manufacturer record is being edited by another user, please try editing later", MsgBoxStyle.Information)
        Else
            LOCKEDITTableAdapter.Insert("ManufList", ManufID.Text)  'Lock for editing
            GetManuf()
            LoadData()

            EditButton.Enabled = False
            EditRecord = True
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            UndoButton.Enabled = True
            LoadByPanel.Visible = False
            LoadPanel.Enabled = False
            Label13.Visible = False
            ManufID.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
            ManufDesc.Enabled = True
            YES.Enabled = True
            NO.Enabled = True
            Submit.Enabled = True
        End If
    End Sub

    Private Sub UndoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoButton.Click
        If EditRecord = True Then   'Release edit lock
            LOCKEDITTableAdapter.DeleteAtDescValue("ManufList", ManufID.Text)
        End If
        EditRecord = False
        NewRecord = False
        NewButton.Enabled = True
        Manuf.Enabled = True
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        Label13.Visible = True
        LoadPanel.Enabled = True
        LoadByPanel.Visible = True

        If Filters.Checked = True Then
            ManufID.Enabled = False
            LoadPanel.Enabled = True
            bck.Enabled = False
            fwd.Enabled = False
        Else
            ManufID.Enabled = True
            LoadPanel.Enabled = False
            bck.Enabled = True
            fwd.Enabled = True
        End If

        UndoButton.Enabled = False
        ManufDesc.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        Submit.Enabled = False

        If Inventory_Maintenance.NewManuf = True Then
            Inventory_Maintenance.NewManuf = False
        End If

        GetManuf()
        LoadData()
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        flag = False
        Dim previousID As Integer
        previousID = ManufID.Text
        If NewRecord = True Then
            If MANF_LISTTableAdapter.ReturnManufCOUNTnew(ManufDesc.Text) <> 0 Then
                If MsgBox("Manufacturer already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new manufacturer entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    ManufDesc.Text = ""
                    ManufDesc.Focus()
                End If
                flag = True   'Don't submit
            Else
                If ManufDesc.Text = String.Empty Then
                    MsgBox("Please enter Manufacturer")
                    ManufDesc.Focus()
                    flag = True
                ElseIf YES.Checked = False And NO.Checked = False Then
                    MsgBox("Please select YES or NO for the Show field")
                    flag = True
                Else
                    If YES.Checked = True Then
                        sh = "Y"
                    Else
                        sh = "N"
                    End If
                    MANF_LISTTableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("ManufList") + 1, MANF_LISTTableAdapter.ReturnID("NEW")) 'Increment NEW ID
                    MANF_LISTTableAdapter.Insert(ManufID.Text, ManufDesc.Text, sh)
                    Me.MANF_LISTTableAdapter.Fill2(Me.SignalogDataSet.MANF_LIST)
                    NewRecord = False
                End If
            End If
        End If

        If EditRecord = True Then
            If MANF_LISTTableAdapter.ReturnManufCOUNTedit(ManufDesc.Text, ManufID.Text) <> 0 Then
                If MsgBox("Manufacturer already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new manufacturer entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    ManufDesc.Text = ""
                    ManufDesc.Focus()
                End If
                flag = True   'Don't submit
            Else
                If ManufDesc.Text = String.Empty Then
                    MsgBox("Please enter Manufacturer")
                    ManufDesc.Focus()
                    flag = True
                Else
                    If YES.Checked = True Then
                        sh = "Y"
                    Else
                        sh = "N"
                    End If
                    LOCKEDITTableAdapter.DeleteAtDescValue("ManufList", ManufID.Text)   'Release Edit LOCK
                    MANF_LISTTableAdapter.UpdateAtManufID(ManufDesc.Text, sh, ManufID.Text)
                    Me.MANF_LISTTableAdapter.Fill2(Me.SignalogDataSet.MANF_LIST)
                    EditRecord = False
                End If
            End If
        End If

        If flag = False Then
            NewButton.Enabled = True
            Manuf.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = True
            Label13.Visible = True
            LoadPanel.Enabled = True
            LoadByPanel.Visible = True

            If Filters.Checked = True Then
                ManufID.Enabled = False
                LoadPanel.Enabled = True
                bck.Enabled = False
                fwd.Enabled = False
            Else
                ManufID.Enabled = True
                LoadPanel.Enabled = False
                bck.Enabled = True
                fwd.Enabled = True
            End If

            UndoButton.Enabled = False
            ManufDesc.Enabled = False
            YES.Enabled = False
            NO.Enabled = False
            Submit.Enabled = False

            Fill()
            Manuf.SelectedValue = MANF_LISTTableAdapter.ReturnMANUF(previousID)
            selectedManuf = Manuf.SelectedValue   'b/c if we edit the first record,Manuf selectedindex changed event will not be lunched (no change) hence no load will occur
            LoadData()
        End If

        If Inventory_Maintenance.NewManuf = True And flag = False Then
            Me.Close()
            Inventory_Maintenance.Text = Inventory_Maintenance.Text & "n"
        End If
    End Sub

    Sub LoadData()
        Try
            ManufID.Text = MANF_LISTTableAdapter.ReturnID(selectedManuf)
            ManufDesc.Text = selectedManuf
            sh = MANF_LISTTableAdapter.ReturnShow(selectedManuf)
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
            MANF_LISTTableAdapter.Fill2(Me.SignalogDataSet.MANF_LIST)
        Else
            MANF_LISTTableAdapter.FillByShow(Me.SignalogDataSet.MANF_LIST, Fsh)
        End If
    End Sub

    Private Sub FilterYES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterYES.CheckedChanged
        If FilterYES.Checked = True Then
            Fsh = "Y"
        ElseIf FilterNO.Checked = True Then
            Fsh = "N"
        End If
        Fill()
        GetManuf()
        LoadData()
    End Sub

    Private Sub FilterNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterNO.CheckedChanged
        If FilterYES.Checked = True Then
            Fsh = "Y"
        ElseIf FilterNO.Checked = True Then
            Fsh = "N"
        End If
        Fill()
        GetManuf()
        LoadData()
    End Sub

    Sub GetManuf()
        If Me.SignalogDataSet.MANF_LIST.Rows.Count <> 0 Then
            selectedManuf = Manuf.SelectedValue
        Else
            selectedManuf = ""
        End If
    End Sub

    Private Sub Manufacturer_List_Maintenance_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Inventory_Maintenance.NewManuf = True Then
            Me.NewButton.PerformClick()
            Me.YES.Checked = True
        End If
    End Sub
End Class