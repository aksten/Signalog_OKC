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

Public Class Dispatch_By_Maintenance
    Dim DispatchBy As String
    Dim sh, Fsh As String
    Dim NewRecord As Boolean
    Dim EditRecord, flag As Boolean

    Private Sub Dispatch_By_Maintenance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Submit.Enabled = True Then
            If MsgBox("Are you sure you want to exit without saving changes?", MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                UndoButton.PerformClick()
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub Dispatch_By_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DispBySEQTableAdapter.Fill(Me.SignalogDataSet.DispBySEQ)
        DispBytxt.Enabled = False
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
        DispNum.Enabled = False
        bck.Enabled = False
        fwd.Enabled = False

        Me.DISP0TableAdapter.Fill2(Me.SignalogDataSet.DISP0)
        GetDispBy()
        LoadData()
    End Sub

    Private Sub DispBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispBy.SelectedIndexChanged
        GetDispBy()
        LoadData()
    End Sub

    Private Sub DispNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispNum.TextChanged
        If DispNum.Text <> "" And NewRecord = False And ID.Checked = True Then
            If (DispNum.Text > DISP0TableAdapter.ReturnMAXDISPNUM - 1) Or (DISP0TableAdapter.ReturnDISPNUMCOUNT(DispNum.Text) = 0) Then
                MsgBox("No record found for entered DISPNUM", MsgBoxStyle.Exclamation)
                DispNum.Text = ""
                DispBytxt.Text = ""
                Seqtxt.Text = ""
                YES.Checked = False
                NO.Checked = False
            Else
                Try
                    DispatchBy = DISP0TableAdapter.ReturnDISPBY(DispNum.Text)
                    DispBy.SelectedValue = DispatchBy
                    DispBytxt.Text = DispatchBy
                    Seqtxt.Text = DISP0TableAdapter.ReturnSEQ(DispatchBy)
                    sh = DISP0TableAdapter.ReturnSHOW(DispatchBy)
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
        If DispNum.Text = String.Empty Then
            DispBytxt.Text = ""
            Seqtxt.Text = ""
            YES.Checked = False
            NO.Checked = False
        End If
    End Sub

    Private Sub fwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwd.Click
        Dim i As Integer
        If DispNum.Text = "" Or DispNum.Text = Convert.ToString(DISP0TableAdapter.ReturnMAXDISPNUM - 1) Then
            DispNum.Text = DISP0TableAdapter.ReturnMINDISPNUM
        Else
            i = DispNum.Text + 1
            While DISP0TableAdapter.ReturnDISPNUMCOUNT(i) = 0 And DISP0TableAdapter.ReturnMAXDISPNUM - 1 > i
                i += 1
            End While
            If DISP0TableAdapter.ReturnDISPNUMCOUNT(i) = 0 Then
                DispNum.Text = DISP0TableAdapter.ReturnMINDISPNUM
            Else
                DispNum.Text = i
            End If
        End If
    End Sub

    Private Sub bck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bck.Click
        Dim i As Integer
        If DispNum.Text = "" Or DispNum.Text = Convert.ToString(DISP0TableAdapter.ReturnMINDISPNUM) Then
            If DISP0TableAdapter.ReturnDISPNUMCOUNT(DISP0TableAdapter.ReturnMAXDISPNUM - 1) <> 0 Then
                DispNum.Text = DISP0TableAdapter.ReturnMAXDISPNUM - 1
            Else
                i = DISP0TableAdapter.ReturnMAXDISPNUM - 1
                While DISP0TableAdapter.ReturnDISPNUMCOUNT(i) = 0 And i > 1
                    i -= 1
                End While
                DispNum.Text = i
            End If
        Else
            i = DispNum.Text - 1
            While DISP0TableAdapter.ReturnDISPNUMCOUNT(i) = 0 And i > 1
                i -= 1
            End While
            DispNum.Text = i
        End If
    End Sub

    'To make sure user enters only numeric value in txtactnum
    Private Sub DispNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DispNum.KeyPress
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
            DispNum.Enabled = True
            bck.Enabled = True
            fwd.Enabled = True
            FilterBoth.Checked = True
            SeqAll.Checked = True
        Else
            LoadPanel.Enabled = True
            DispNum.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
        End If

        Fill()
        GetDispBy()
        LoadData()
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If ACT0TableAdapter.ReturnDispNumCOUNT(DispNum.Text) <> 0 Then
            MsgBox("Delete forbidden, dispatch by personnel is associated with one or more trouble reports", MsgBoxStyle.Exclamation, "Delete Forbidden")
        Else
            Dim result As MsgBoxResult
            result = MsgBox("Are you sure you want to delete the selected record?", MsgBoxStyle.YesNo, "Delete Record?")
            If result = MsgBoxResult.Yes Then
                DISP0TableAdapter.DeleteAtDISPNUM(DispNum.Text)
                Fill()
                GetDispBy()
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
        DispNum.Enabled = False
        fwd.Enabled = False
        bck.Enabled = False
        DispBytxt.Enabled = True
        Seqtxt.Enabled = True
        YES.Enabled = True
        NO.Enabled = True
        Submit.Enabled = True
        DispBytxt.Text = ""
        Seqtxt.Text = ""
        YES.Checked = False
        NO.Checked = False

        DispNum.Text = LOCKNEWTableAdapter.ReturnLockValue("DispatchBy") + 1   'Assign AREANUM= highest LOCK value +1
        LOCKNEWTableAdapter.UpdateLockValue(DispNum.Text, "DispatchBy")  'Update LOCK
    End Sub

    Private Sub UndoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoButton.Click
        If EditRecord = True Then   'Release edit lock
            LOCKEDITTableAdapter.DeleteAtDescValue("DispatchBy", DispNum.Text)
        End If
        EditRecord = False
        NewRecord = False
        NewButton.Enabled = True
        DispBy.Enabled = True
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        Label13.Visible = True
        LoadPanel.Enabled = True
        LoadByPanel.Visible = True
        If Filters.Checked = True Then
            DispNum.Enabled = False
            LoadPanel.Enabled = True
            bck.Enabled = False
            fwd.Enabled = False
        Else
            DispNum.Enabled = True
            LoadPanel.Enabled = False
            bck.Enabled = True
            fwd.Enabled = True
        End If
        UndoButton.Enabled = False
        DispBytxt.Enabled = False
        Seqtxt.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        Submit.Enabled = False

        If Trouble_Report.NewReportedBy = True Then
            Trouble_Report.NewReportedBy = False
        End If

        GetDispBy()
        LoadData()
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        flag = False
        Dim previousID As Integer
        previousID = DispNum.Text
        If NewRecord = True Then
            If DISP0TableAdapter.ReturnDispatchByCOUNTnew(DispBytxt.Text) <> 0 And DispBytxt.Text <> String.Empty Then
                If MsgBox("Dipatch by already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new dispatch by entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    DispBytxt.Text = ""
                    DispBytxt.Focus()
                End If
                flag = True   'Don't submit
            Else
                If DispBytxt.Text = String.Empty Then
                    MsgBox("Please enter Dispatch By", MsgBoxStyle.Exclamation, "Missing Field")
                    DispBytxt.Focus()
                    flag = True
                ElseIf Seqtxt.Text = String.Empty Then
                    MsgBox("Please enter Sequence Number", MsgBoxStyle.Exclamation, "Missing Field")
                    Seqtxt.Focus()
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

                    DISP0TableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("DispatchBy") + 1, DISP0TableAdapter.ReturnDISPNUM("NEW")) 'Increment NEW ID
                    DISP0TableAdapter.Insert(DispNum.Text, DispBytxt.Text, Seqtxt.Text, sh)
                    Me.DISP0TableAdapter.Fill2(Me.SignalogDataSet.DISP0)
                    Me.DispBySEQTableAdapter.Fill(Me.SignalogDataSet.DispBySEQ)
                    NewRecord = False
                End If
            End If
        End If

        If EditRecord = True Then
            If DISP0TableAdapter.ReturnDispatchByCOUNTedit(DispBytxt.Text, DispNum.Text) <> 0 And DispBytxt.Text <> String.Empty Then
                If MsgBox("Dipatch by already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new dispatch by entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    DispBytxt.Text = ""
                    DispBytxt.Focus()
                End If
                flag = True   'Don't submit
            Else
                If DispBytxt.Text = String.Empty Then
                    MsgBox("Please enter Dispatch By", MsgBoxStyle.Exclamation, "Missing Field")
                    DispBytxt.Focus()
                    flag = True
                ElseIf Seqtxt.Text = String.Empty Then
                    MsgBox("Please enter Sequence Number", MsgBoxStyle.Exclamation, "Missing Field")
                    flag = True
                Else
                    If YES.Checked = True Then
                        sh = "Y"
                    Else
                        sh = "N"
                    End If
                    LOCKEDITTableAdapter.DeleteAtDescValue("DispatchBy", DispNum.Text)   'Release Edit LOCK
                    DISP0TableAdapter.UpdateAtDISPNUM(DispBytxt.Text, Seqtxt.Text, sh, DispNum.Text)
                    Me.DISP0TableAdapter.Fill2(Me.SignalogDataSet.DISP0)
                    Me.DispBySEQTableAdapter.Fill(Me.SignalogDataSet.DispBySEQ)
                    EditRecord = False
                End If
            End If
        End If

        If flag = False Then
            NewButton.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = True
            UndoButton.Enabled = False
            DispBy.Enabled = True
            Label13.Visible = True
            LoadPanel.Enabled = True
            LoadByPanel.Visible = True
            FilterBoth.Checked = True

            If Filters.Checked = True Then
                DispNum.Enabled = False
                LoadPanel.Enabled = True
                bck.Enabled = False
                fwd.Enabled = False
            Else
                DispNum.Enabled = True
                LoadPanel.Enabled = False
                bck.Enabled = True
                fwd.Enabled = True
            End If


            DispBytxt.Enabled = False
            Seqtxt.Enabled = False
            YES.Enabled = False
            NO.Enabled = False
            Submit.Enabled = False

            NewRecord = False
            EditRecord = False

            Fill()
            DispBy.SelectedValue = DISP0TableAdapter.ReturnDISPBY(previousID)
        End If

        If Trouble_Report.NewReportedBy = True And flag = False Then
            Me.Close()
            Trouble_Report.Text = Trouble_Report.Text & "n"
        End If

    End Sub

    Private Sub SeqAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeqAll.CheckedChanged
        If SeqAll.Checked = True Then
            FilterSeq.Enabled = False
        Else
            FilterSeq.Enabled = True
        End If
        Fill()
        GetDispBy()
        LoadData()
    End Sub

    Private Sub FilterYES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterYES.CheckedChanged
        If FilterYES.Checked = True Then
            Fsh = "Y"
        ElseIf FilterNO.Checked = True Then
            Fsh = "N"
        End If
        Fill()
        GetDispBy()
        LoadData()
    End Sub

    Private Sub FilterNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterNO.CheckedChanged
        If FilterYES.Checked = True Then
            Fsh = "Y"
        ElseIf FilterNO.Checked = True Then
            Fsh = "N"
        End If
        Fill()
        GetDispBy()
        LoadData()
    End Sub

    Private Sub FilterSeq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterSeq.SelectedIndexChanged
        Fill()
        GetDispBy()
        LoadData()
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        If LOCKEDITTableAdapter.ReturnDescValueCOUNT("DispatchBy", DispNum.Text) <> 0 Then   'If locked for editing
            MsgBox("This dispatch by record is being edited by another user, please try editing later", MsgBoxStyle.Information)
        Else
            LOCKEDITTableAdapter.Insert("DispatchBy", DispNum.Text)  'Lock for editing
            GetDispBy()
            LoadData()

            EditButton.Enabled = False
            EditRecord = True
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            UndoButton.Enabled = True
            LoadByPanel.Visible = False
            LoadPanel.Enabled = False
            Label13.Visible = False
            DispNum.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
            DispBy.Enabled = False
            DispBytxt.Enabled = True
            Seqtxt.Enabled = True
            YES.Enabled = True
            NO.Enabled = True
            Submit.Enabled = True
        End If
    End Sub

    Sub GetDispBy()
        If Me.SignalogDataSet.DISP0.Rows.Count <> 0 Then
            DispatchBy = DispBy.SelectedValue
        Else
            DispatchBy = ""
        End If
    End Sub

    Sub LoadData()
        Try
            DispNum.Text = DISP0TableAdapter.ReturnDISPNUM2(DispatchBy)
            DispBytxt.Text = DispatchBy
            Seqtxt.Text = DISP0TableAdapter.ReturnSEQ(DispatchBy)
            sh = DISP0TableAdapter.ReturnSHOW(DispatchBy)
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
                DISP0TableAdapter.Fill2(Me.SignalogDataSet.DISP0)
            Else
                DISP0TableAdapter.FillByShow(Me.SignalogDataSet.DISP0, Fsh)
            End If
        Else
            If FilterBoth.Checked = True Then
                DISP0TableAdapter.FillBySeq(Me.SignalogDataSet.DISP0, FilterSeq.SelectedValue)
            Else
                DISP0TableAdapter.FillBySeqShow(Me.SignalogDataSet.DISP0, FilterSeq.SelectedValue, Fsh)
            End If
        End If
    End Sub

    Private Sub Dispatch_By_Maintenance_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Trouble_Report.NewReportedBy = True Then
            Me.NewButton.PerformClick()
            Me.YES.Checked = True
        End If
    End Sub
End Class