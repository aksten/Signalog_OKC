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

Public Class Location_Type_Description_Maintenance
    Dim SelectedTypeNum As String
    Dim sh, Fsh As String
    Dim NewRecord As Boolean
    Dim EditRecord, flag As Boolean

    Private Sub Location_Type_Description_Maintenance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Submit.Enabled = True Then
            If MsgBox("Are you sure you want to exit without saving changes?", MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                UndoButton.PerformClick()
                e.Cancel = False
            End If
        End If
    End Sub
    Private Sub Location_Type_Description_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TypeDescSeqTableAdapter.Fill(Me.SignalogDataSet.TypeDescSeq)
        TypeDesctxt.Enabled = False
        Seqtxt.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        Submit.Enabled = False
        UndoButton.Enabled = False
        NewRecord = False
        EditRecord = False
        SeqAll.Checked = True
        Filters.Checked = True
        FilterBoth.Checked = True
        TypeNum.Enabled = False
        bck.Enabled = False
        fwd.Enabled = False

        Me.LOC1TableAdapter.Fill2(Me.SignalogDataSet.LOC1)
        GetTypeDesc()
        LoadData()
    End Sub


    Private Sub TypeDesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeDesc.SelectedIndexChanged
        GetTypeDesc()
        LoadData()
    End Sub

    Private Sub TypeNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeNum.TextChanged
        If TypeNum.Text <> "" And NewRecord = False And ID.Checked = True Then
            If (TypeNum.Text > LOC1TableAdapter.ReturnMAXTYPENUM - 1) Or (LOC1TableAdapter.ReturnTYPENUMCOUNT(TypeNum.Text) = 0) Then
                MsgBox("No record found for entered TYPENUM")
                TypeNum.Text = ""
                TypeDesctxt.Text = ""
                Seqtxt.Text = ""
                YES.Checked = False
                NO.Checked = False
            Else
                Try
                    SelectedTypeNum = LOC1TableAdapter.ReturnTYPEDESC(TypeNum.Text)
                    TypeDesc.SelectedValue = SelectedTypeNum
                    TypeDesctxt.Text = SelectedTypeNum
                    Seqtxt.Text = LOC1TableAdapter.ReturnSEQ(SelectedTypeNum)
                    sh = LOC1TableAdapter.ReturnSHOW(SelectedTypeNum)
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
        If TypeNum.Text = String.Empty Then
            TypeDesctxt.Text = ""
            Seqtxt.Text = ""
            YES.Checked = False
            NO.Checked = False
        End If
    End Sub

    Private Sub fwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwd.Click
        Dim i As Integer
        If TypeNum.Text = "" Or TypeNum.Text = Convert.ToString(LOC1TableAdapter.ReturnMAXTYPENUM - 1) Then
            TypeNum.Text = LOC1TableAdapter.ReturnMINTYPENUM
        Else
            i = TypeNum.Text + 1
            While LOC1TableAdapter.ReturnTYPENUMCOUNT(i) = 0 And LOC1TableAdapter.ReturnMAXTYPENUM - 1 > i
                i += 1
            End While
            If LOC1TableAdapter.ReturnTYPENUMCOUNT(i) = 0 Then
                TypeNum.Text = LOC1TableAdapter.ReturnMINTYPENUM
            Else
                TypeNum.Text = i
            End If
        End If
    End Sub

    Private Sub bck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bck.Click
        Dim i As Integer
        If TypeNum.Text = "" Or TypeNum.Text = Convert.ToString(LOC1TableAdapter.ReturnMINTYPENUM) Then
            If LOC1TableAdapter.ReturnTYPENUMCOUNT(LOC1TableAdapter.ReturnMAXTYPENUM - 1) <> 0 Then
                TypeNum.Text = LOC1TableAdapter.ReturnMAXTYPENUM - 1
            Else
                i = LOC1TableAdapter.ReturnMAXTYPENUM - 1
                While LOC1TableAdapter.ReturnTYPENUMCOUNT(i) = 0 And i > 1
                    i -= 1
                End While
                TypeNum.Text = i
            End If
        Else
            i = TypeNum.Text - 1
            While LOC1TableAdapter.ReturnTYPENUMCOUNT(i) = 0 And i > 1
                i -= 1
            End While
            TypeNum.Text = i
        End If
    End Sub

    Private Sub TypeNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TypeNum.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Sub Seqtxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Seqtxt.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Function TrapKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function

    Private Sub ID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID.CheckedChanged
        If ID.Checked = True Then
            LoadPanel.Enabled = False
            TypeNum.Enabled = True
            bck.Enabled = True
            fwd.Enabled = True
            FilterBoth.Checked = True
            SeqAll.Checked = True
        Else
            LoadPanel.Enabled = True
            TypeNum.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
        End If

        Fill()
        GetTypeDesc()
        LoadData()
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If LOC0TableAdapter.ReturnTypeNumCOUNT(TypeNum.Text) <> 0 Then
            MsgBox("Delete forbidden, location type is associated with one or more locations", MsgBoxStyle.Exclamation, "Delete Forbidden")
        Else
            Dim result As MsgBoxResult
            result = MsgBox("Are you sure you want to delete the selected record?", MsgBoxStyle.YesNo, "Delete Record?")
            If result = MsgBoxResult.Yes Then
                LOC1TableAdapter.DeleteAtTYPENUM(TypeNum.Text)
                Fill()
                GetTypeDesc()
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
        TypeNum.Enabled = False
        fwd.Enabled = False
        bck.Enabled = False
        TypeDesctxt.Enabled = True
        Seqtxt.Enabled = True
        YES.Enabled = True
        NO.Enabled = True
        Submit.Enabled = True
        TypeDesctxt.Text = ""
        Seqtxt.Text = ""
        YES.Checked = False
        NO.Checked = False
        TypeNum.Text = LOCKNEWTableAdapter.ReturnLockValue("LocationsType") + 1   'Assign AREANUM= highest LOCK value +1
        LOCKNEWTableAdapter.UpdateLockValue(TypeNum.Text, "LocationsType")  'Update LOCK
    End Sub

    Private Sub UndoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoButton.Click
        If EditRecord = True Then   'Release edit lock
            LOCKEDITTableAdapter.DeleteAtDescValue("LocationsType", TypeNum.Text)
        End If
        EditRecord = False
        NewRecord = False
        NewButton.Enabled = True
        TypeDesc.Enabled = True
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        Label13.Visible = True
        LoadPanel.Enabled = True
        LoadByPanel.Visible = True

        If Filters.Checked = True Then
            TypeNum.Enabled = False
            LoadPanel.Enabled = True
            bck.Enabled = False
            fwd.Enabled = False
        Else
            TypeNum.Enabled = True
            LoadPanel.Enabled = False
            bck.Enabled = True
            fwd.Enabled = True
        End If

        UndoButton.Enabled = False
        TypeDesctxt.Enabled = False
        Seqtxt.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        Submit.Enabled = False

        If Locations_Maintenance.NewTypeDesc = True Then
            Locations_Maintenance.NewTypeDesc = False
        End If

        GetTypeDesc()
        LoadData()
    End Sub


    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        flag = False
        Dim previousID As Integer
        previousID = TypeNum.Text
        If NewRecord = True Then
            If LOC1TableAdapter.ReturnTypeDescCOUNTnew(TypeDesctxt.Text) <> 0 Then
                If MsgBox("Location type description already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new location type entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    TypeDesctxt.Text = ""
                    TypeDesctxt.Focus()
                End If
                flag = True   'Don't submit
            Else
                If TypeDesctxt.Text = String.Empty Then
                    MsgBox("Please enter Type Description")
                    TypeDesctxt.Focus()
                    flag = True
                ElseIf Seqtxt.Text = String.Empty Then
                    MsgBox("Please enter Sequence Number")
                    Seqtxt.Focus()
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
                    LOC1TableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("LocationsType") + 1, LOC1TableAdapter.ReturnTYPENUM("NEW")) 'Increment NEW ID
                    LOC1TableAdapter.Insert(TypeNum.Text, Seqtxt.Text, TypeDesctxt.Text, sh)
                    Me.LOC1TableAdapter.Fill2(Me.SignalogDataSet.LOC1)
                    Me.TypeDescSeqTableAdapter.Fill(Me.SignalogDataSet.TypeDescSeq)
                    NewRecord = False
                End If
            End If
        End If

        If EditRecord = True Then
            If LOC1TableAdapter.ReturnTypeDescCOUNTedit(TypeDesctxt.Text, TypeNum.Text) <> 0 Then
                If MsgBox("Location type description already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new location type entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    TypeDesctxt.Text = ""
                    TypeDesctxt.Focus()
                End If
                flag = True   'Don't submit
            Else
                If TypeDesctxt.Text = String.Empty Then
                    MsgBox("Please enter Type Description")
                    TypeDesctxt.Focus()
                    flag = True
                ElseIf Seqtxt.Text = String.Empty Then
                    MsgBox("Please enter Sequence Number")
                    Seqtxt.Focus()
                    flag = True
                Else
                    If YES.Checked = True Then
                        sh = "Y"
                    Else
                        sh = "N"
                    End If
                    LOCKEDITTableAdapter.DeleteAtDescValue("LocationsType", TypeNum.Text)   'Release Edit LOCK
                    LOC1TableAdapter.UpdateAtTYPENUM(TypeDesctxt.Text, Seqtxt.Text, sh, TypeNum.Text)
                    Me.LOC1TableAdapter.Fill2(Me.SignalogDataSet.LOC1)
                    Me.TypeDescSeqTableAdapter.Fill(Me.SignalogDataSet.TypeDescSeq)
                    EditRecord = False
                End If
            End If
        End If

        If flag = False Then
            NewButton.Enabled = True
            TypeDesc.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = True
            Label13.Visible = True
            LoadPanel.Enabled = True
            LoadByPanel.Visible = True

            If Filters.Checked = True Then
                TypeNum.Enabled = False
                LoadPanel.Enabled = True
                bck.Enabled = False
                fwd.Enabled = False
            Else
                TypeNum.Enabled = True
                LoadPanel.Enabled = False
                bck.Enabled = True
                fwd.Enabled = True
            End If

            UndoButton.Enabled = False
            TypeDesctxt.Enabled = False
            Seqtxt.Enabled = False
            YES.Enabled = False
            NO.Enabled = False
            Submit.Enabled = False

            Fill()
            TypeDesc.SelectedValue = LOC1TableAdapter.ReturnTYPEDESC(previousID)
        End If

        If Locations_Maintenance.NewTypeDesc = True And flag = False Then
            Me.Close()
            Locations_Maintenance.Text = Locations_Maintenance.Text & "n"
        End If

    End Sub

    Private Sub SeqAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeqAll.CheckedChanged
        If SeqAll.Checked = True Then
            FilterSeq.Enabled = False
        Else
            FilterSeq.Enabled = True
        End If
        Fill()
        GetTypeDesc()
        LoadData()
    End Sub

    Private Sub FilterYES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterYES.CheckedChanged
        If FilterYES.Checked = True Then
            Fsh = "Y"
        ElseIf FilterNO.Checked = True Then
            Fsh = "N"
        End If
        Fill()
        GetTypeDesc()
        LoadData()
    End Sub

    Private Sub FilterNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterNO.CheckedChanged
        If FilterYES.Checked = True Then
            Fsh = "Y"
        ElseIf FilterNO.Checked = True Then
            Fsh = "N"
        End If
        Fill()
        GetTypeDesc()
        LoadData()
    End Sub

    Private Sub FilterSeq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterSeq.SelectedIndexChanged
        Fill()
        GetTypeDesc()
        LoadData()
    End Sub


    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        If LOCKEDITTableAdapter.ReturnDescValueCOUNT("LocationsType", TypeNum.Text) <> 0 Then   'If locked for editing
            MsgBox("This location type record is being edited by another user, please try editing later", MsgBoxStyle.Information)
        Else
            LOCKEDITTableAdapter.Insert("LocationsType", TypeNum.Text)  'Lock for editing
            GetTypeDesc()
            LoadData()

            EditButton.Enabled = False
            EditRecord = True
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            UndoButton.Enabled = True
            LoadByPanel.Visible = False
            LoadPanel.Enabled = False
            Label13.Visible = False
            TypeNum.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
            TypeDesc.Enabled = False
            TypeDesctxt.Enabled = True
            Seqtxt.Enabled = True
            YES.Enabled = True
            NO.Enabled = True
            Submit.Enabled = True
        End If
    End Sub

    Sub GetTypeDesc()
        If Me.SignalogDataSet.LOC1.Rows.Count <> 0 Then
            SelectedTypeNum = TypeDesc.SelectedValue
        Else
            SelectedTypeNum = ""
        End If
    End Sub

    Sub LoadData()
        Try
            TypeNum.Text = LOC1TableAdapter.ReturnTYPENUM(SelectedTypeNum)
            TypeDesctxt.Text = SelectedTypeNum
            Seqtxt.Text = LOC1TableAdapter.ReturnSEQ(SelectedTypeNum)
            sh = LOC1TableAdapter.ReturnSHOW(SelectedTypeNum)
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
        If SeqAll.Checked = True Then
            If FilterBoth.Checked = True Then
                LOC1TableAdapter.Fill2(Me.SignalogDataSet.LOC1)
            Else
                LOC1TableAdapter.FillByShow(Me.SignalogDataSet.LOC1, Fsh)
            End If
        Else
            If FilterBoth.Checked = True Then
                LOC1TableAdapter.FillBySeq(Me.SignalogDataSet.LOC1, FilterSeq.SelectedValue)
            Else
                LOC1TableAdapter.FillBySeqShow(Me.SignalogDataSet.LOC1, FilterSeq.SelectedValue, Fsh)
            End If
        End If
    End Sub

    Private Sub Location_Type_Description_Maintenance_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Locations_Maintenance.NewTypeDesc = True Then
            Me.NewButton.PerformClick()
            Me.YES.Checked = True
        End If
    End Sub
End Class