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

Public Class Parts_List_Maintenance
    Dim selectedPart As String
    Dim NewRecord As Boolean
    Dim EditRecord, flag As Boolean
    Dim sh, Fsh As String
    Dim oldDesc As String

    Private Sub Parts_List_Maintenance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Submit.Enabled = True Then
            If MsgBox("Are you sure you want to exit without saving changes?", MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                UndoButton.PerformClick()
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub Parts_List_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SignalogDataSet.StockControl' table. You can move, or remove it, as needed.
        Me.StockControlTableAdapter.Fill(Me.SignalogDataSet.StockControl)
        Me.Parts_ListTableAdapter.Fill2(Me.SignalogDataSet.Parts_List)
        PartDesc.Enabled = False
        PartNum.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        Submit.Enabled = False
        UndoButton.Enabled = False
        NewRecord = False
        EditRecord = False
        Filters.Checked = True
        FilterBoth.Checked = True
        PartID.Enabled = False
        bck.Enabled = False
        fwd.Enabled = False
        Fill()
        GetPart()
        LoadData()
    End Sub

    Private Sub Parts_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartsList.SelectedIndexChanged
        GetPart()
        LoadData()
    End Sub

    Private Sub ID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID.CheckedChanged
        If ID.Checked = True Then
            LoadPanel.Enabled = False
            PartID.Enabled = True
            bck.Enabled = True
            fwd.Enabled = True
            FilterBoth.Checked = True
        Else
            LoadPanel.Enabled = True
            PartID.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
        End If

        Fill()
        GetPart()
        LoadData()
    End Sub

    Private Sub PartID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PartID.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Sub PartID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartID.TextChanged
        If PartID.Text <> "" And NewRecord = False Then
            If (PartID.Text > Parts_ListTableAdapter.ReturnMaxID - 1) Or (Parts_ListTableAdapter.ReturnCountID(PartID.Text) = 0) Then
                MsgBox("No record found for entered Part ID")
                PartID.Text = ""
                PartDesc.Text = ""
                PartNum.Text = ""
                YES.Checked = False
                NO.Checked = False
            Else
                Try
                    selectedPart = Parts_ListTableAdapter.ReturnPart(PartID.Text)
                    PartsList.SelectedValue = selectedPart
                    PartDesc.Text = selectedPart
                    sh = Parts_ListTableAdapter.ReturnShow(selectedPart)
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
        If PartID.Text = String.Empty Then
            PartID.Text = ""
            PartDesc.Text = ""
            PartNum.Text = ""
            YES.Checked = False
            NO.Checked = False
        End If
    End Sub

    Private Sub fwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwd.Click
        Dim i As Integer
        If PartID.Text = "" Or PartID.Text = Convert.ToString(Parts_ListTableAdapter.ReturnMaxID - 1) Then
            PartID.Text = Parts_ListTableAdapter.ReturnMinID
        Else
            i = PartID.Text + 1
            While Parts_ListTableAdapter.ReturnCountID(i) = 0 And Parts_ListTableAdapter.ReturnMaxID - 1 > i
                i += 1
            End While
            If Parts_ListTableAdapter.ReturnCountID(i) = 0 Then
                PartID.Text = Parts_ListTableAdapter.ReturnMinID
            Else
                PartID.Text = i
            End If
        End If
    End Sub

    Private Sub bck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bck.Click
        Dim i As Integer
        If PartID.Text = "" Or PartID.Text = Convert.ToString(Parts_ListTableAdapter.ReturnMinID) Then
            If Parts_ListTableAdapter.ReturnCountID(Parts_ListTableAdapter.ReturnMaxID - 1) <> 0 Then
                PartID.Text = Parts_ListTableAdapter.ReturnMaxID - 1
            Else
                i = Parts_ListTableAdapter.ReturnMaxID - 1
                While Parts_ListTableAdapter.ReturnCountID(i) = 0 And i > 1
                    i -= 1
                End While
                PartID.Text = i
            End If
        Else
            i = PartID.Text - 1
            While Parts_ListTableAdapter.ReturnCountID(i) = 0 And i > 1
                i -= 1
            End While
            PartID.Text = i
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
        If EQUIPMENTTableAdapter.ReturnPartDescCOUNT(PartDesc.Text) <> 0 Then
            MsgBox("Delete forbidden, part is associated with one or more local inventory items", MsgBoxStyle.Exclamation, "Delete Forbidden")
        ElseIf EQUIPMENT2TableAdapter.ReturnPartDescCOUNT(PartDesc.Text) <> 0 Then
            MsgBox("Delete forbidden, part is associated with one or more city owned inventory items", MsgBoxStyle.Exclamation, "Delete Forbidden")
        Else
            Dim result As MsgBoxResult
            result = MsgBox("Are you sure you want to delete the selected record?", MsgBoxStyle.YesNo, "Delete Record?")
            If result = MsgBoxResult.Yes Then
                Parts_ListTableAdapter.DeleteAtID(PartID.Text)
                Fill()
                GetPart()
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
        PartID.Enabled = False
        fwd.Enabled = False
        bck.Enabled = False
        PartDesc.Enabled = True
        PartNum.Enabled = True
        YES.Enabled = True
        NO.Enabled = True
        Submit.Enabled = True
        PartDesc.Text = ""
        PartNum.Text = ""
        YES.Checked = False
        NO.Checked = False
        PartID.Text = LOCKNEWTableAdapter.ReturnLockValue("PartList") + 1   'Assign AREANUM= highest LOCK value +1
        LOCKNEWTableAdapter.UpdateLockValue(PartID.Text, "PartList")  'Update LOCK
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        If LOCKEDITTableAdapter.ReturnDescValueCOUNT("PartList", PartID.Text) <> 0 Then   'If locked for editing
            MsgBox("This part record is being edited by another user, please try editing later", MsgBoxStyle.Information)
        Else
            LOCKEDITTableAdapter.Insert("PartList", PartID.Text)  'Lock for editing
            GetPart()
            LoadData()

            EditButton.Enabled = False
            EditRecord = True
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            UndoButton.Enabled = True
            LoadByPanel.Visible = False
            LoadPanel.Enabled = False
            Label13.Visible = False
            PartID.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
            PartsList.Enabled = False
            PartDesc.Enabled = True
            PartNum.Enabled = True
            YES.Enabled = True
            NO.Enabled = True
            Submit.Enabled = True

            oldDesc = PartDesc.Text  'Save the old Part Desc (for updating EQUIP,EQUIP2,Stock Control)
        End If
    End Sub

    Private Sub UndoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoButton.Click
        If EditRecord = True Then   'Release edit lock
            LOCKEDITTableAdapter.DeleteAtDescValue("PartList", PartID.Text)
        End If
        EditRecord = False
        NewRecord = False
        NewButton.Enabled = True
        PartsList.Enabled = True
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        Label13.Visible = True
        LoadPanel.Enabled = True
        LoadByPanel.Visible = True

        If Filters.Checked = True Then
            PartID.Enabled = False
            LoadPanel.Enabled = True
            bck.Enabled = False
            fwd.Enabled = False
        Else
            PartID.Enabled = True
            LoadPanel.Enabled = False
            bck.Enabled = True
            fwd.Enabled = True
        End If

        UndoButton.Enabled = False
        PartDesc.Enabled = False
        PartNum.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        Submit.Enabled = False

        If Inventory_Maintenance.NewPart = True Then
            Inventory_Maintenance.NewPart = False
        End If

        GetPart()
        LoadData()
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        flag = False
        Dim previousID As Integer
        previousID = PartID.Text
        If NewRecord = True Then
            If Parts_ListTableAdapter.ReturnPartDescCOUNTnew(PartDesc.Text) <> 0 Then
                If MsgBox("Part Description already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new part entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    PartDesc.Text = ""
                    PartDesc.Focus()
                End If
                flag = True   'Don't submit
            ElseIf Parts_ListTableAdapter.ReturnPartNumberCOUNTnew(PartNum.Text) <> 0 Then
                If MsgBox("Part Number already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new part entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    PartNum.Text = ""
                    PartNum.Focus()
                End If
                flag = True   'Don't submit
            Else
                If PartDesc.Text = String.Empty Then
                    MsgBox("Please enter Part Description")
                    PartDesc.Focus()
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
                    Parts_ListTableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("PartList") + 1, Parts_ListTableAdapter.ReturnID("NEW")) 'Increment NEW ID
                    Parts_ListTableAdapter.Insert(PartID.Text, PartNum.Text, PartDesc.Text, sh)
                    Me.Parts_ListTableAdapter.Fill2(Me.SignalogDataSet.Parts_List)
                    NewRecord = False
                End If
            End If
        End If

        If EditRecord = True Then
            If Parts_ListTableAdapter.ReturnPartDescCOUNTedit(PartDesc.Text, PartID.Text) <> 0 Then
                If MsgBox("Part Description already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new part entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    PartDesc.Text = ""
                    PartDesc.Focus()
                End If
                flag = True   'Don't submit
            ElseIf Parts_ListTableAdapter.ReturnPartNumberCOUNTedit(PartNum.Text, PartID.Text) <> 0 Then
                If MsgBox("Part Number already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new part entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    PartNum.Text = ""
                    PartNum.Focus()
                End If
                flag = True   'Don't submit
            Else
                If PartDesc.Text = String.Empty Then
                    MsgBox("Please enter Part Description")
                    PartDesc.Focus()
                    flag = True
                Else
                    If YES.Checked = True Then
                        sh = "Y"
                    Else
                        sh = "N"
                    End If
                    LOCKEDITTableAdapter.DeleteAtDescValue("PartList", PartID.Text)   'Release Edit LOCK
                    Parts_ListTableAdapter.UpdateAtPartID(PartNum.Text, PartDesc.Text, sh, PartID.Text)

                    EQUIPMENTTableAdapter.UpdatePartDesc(PartDesc.Text, oldDesc)   'Update part description
                    EQUIPMENT2TableAdapter.UpdatePartDesc(PartDesc.Text, oldDesc)
                    StockControlTableAdapter.UpdatePartDesc(PartDesc.Text, oldDesc)

                    Me.Parts_ListTableAdapter.Fill2(Me.SignalogDataSet.Parts_List)
                    EditRecord = False
                End If
            End If
        End If

        If flag = False Then
            NewButton.Enabled = True
            PartsList.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = True
            Label13.Visible = True
            LoadPanel.Enabled = True
            LoadByPanel.Visible = True

            If Filters.Checked = True Then
                PartID.Enabled = False
                LoadPanel.Enabled = True
                bck.Enabled = False
                fwd.Enabled = False
            Else
                PartID.Enabled = True
                LoadPanel.Enabled = False
                bck.Enabled = True
                fwd.Enabled = True
            End If

            UndoButton.Enabled = False
            PartDesc.Enabled = False
            PartNum.Enabled = False
            YES.Enabled = False
            NO.Enabled = False
            Submit.Enabled = False

            Fill()
            PartsList.SelectedValue = Parts_ListTableAdapter.ReturnPart(previousID)
        End If

        If Inventory_Maintenance.NewPart = True And flag = False Then
            Me.Close()
            Inventory_Maintenance.Text = Inventory_Maintenance.Text & "n"
        End If

    End Sub

    Sub LoadData()
        Try
            PartID.Text = Parts_ListTableAdapter.ReturnID(selectedPart)
            PartDesc.Text = selectedPart
            PartNum.Text = Parts_ListTableAdapter.ReturnPartNum(PartID.Text)
            sh = Parts_ListTableAdapter.ReturnShow(selectedPart)
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
            Parts_ListTableAdapter.Fill2(Me.SignalogDataSet.Parts_List)
        Else
            Parts_ListTableAdapter.FillBySHOW(Me.SignalogDataSet.Parts_List, Fsh)
        End If
    End Sub

    Private Sub FilterYES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterYES.CheckedChanged
        If FilterYES.Checked = True Then
            Fsh = "Y"
        ElseIf FilterNO.Checked = True Then
            Fsh = "N"
        End If
        Fill()
        GetPart()
        LoadData()
    End Sub

    Private Sub FilterNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterNO.CheckedChanged
        If FilterYES.Checked = True Then
            Fsh = "Y"
        ElseIf FilterNO.Checked = True Then
            Fsh = "N"
        End If
        Fill()
        GetPart()
        LoadData()
    End Sub

    Sub GetPart()
        If Me.SignalogDataSet.Parts_List.Rows.Count <> 0 Then
            selectedPart = PartsList.SelectedValue
        Else
            selectedPart = ""
        End If
    End Sub

    Private Sub Parts_List_Maintenance_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Inventory_Maintenance.NewPart = True Then
            Me.NewButton.PerformClick()
            Me.YES.Checked = True
        End If
    End Sub

End Class