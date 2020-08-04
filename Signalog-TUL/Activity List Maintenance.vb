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

Public Class Activity_List_Maintenance
    Dim i As Integer
    Dim lnklabel, actcode As String

    Private Sub Activity_List_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ASUBTableAdapter.Fill(Me.SignalogDataSet.ASUB)
        Me.Height = 300
        ASUB2Panel.Visible = False
        ASUB3Panel.Visible = False
        ASUB4Panel.Visible = False
        ASUB5Panel.Visible = False
        ASUB6Panel.Visible = False
        NewActCode.Text = ASUBTableAdapter.ReturnMaxACTCODE + 1
        If NewActCode.Text.Count = 3 Then
            NewActCode.Text = "0" & NewActCode.Text
        End If
    End Sub

    Private Sub ActCat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActCat.SelectedIndexChanged
        If ActCat.Text = "PROBLEM REPORTED" Then
            Me.ASUB1TableAdapter.FillByProbRep(Me.SignalogDataSet.ASUB1)
        ElseIf ActCat.Text = "ARRIVAL CONDITION" Then
            Me.ASUB1TableAdapter.FillByArrCond(Me.SignalogDataSet.ASUB1)
        ElseIf ActCat.Text = "ACTION TAKEN" Then
            Me.ASUB1TableAdapter.FillByActTak(Me.SignalogDataSet.ASUB1)
        ElseIf ActCat.Text = "DEFERRED ACTION" Then
            Me.ASUB1TableAdapter.FillByDefAct(Me.SignalogDataSet.ASUB1)
        ElseIf ActCat.Text = "DEPARTING CONDITION NOTES" Then
            Me.ASUB1TableAdapter.FillByDepCond(Me.SignalogDataSet.ASUB1)
        End If
        ASUB2Panel.Visible = False
        ASUB3Panel.Visible = False
        ASUB4Panel.Visible = False
        ASUB5Panel.Visible = False
        ASUB6Panel.Visible = False
        Me.Height = 300
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click

        'Me.Validate()
        'Me.ASUB1BindingSource.EndEdit()
        Me.ASUB1TableAdapter.Update(Me.SignalogDataSet.ASUB1)

        ASUB2TableAdapter.Update(Me.SignalogDataSet.ASUB2)
        ASUB3TableAdapter.Update(Me.SignalogDataSet.ASUB3)
        ASUB4TableAdapter.Update(Me.SignalogDataSet.ASUB4)
        ASUB5TableAdapter.Update(Me.SignalogDataSet.ASUB5)
        ASUB6TableAdapter.Update(Me.SignalogDataSet.ASUB6)

            Me.ASUBTableAdapter.Fill(Me.SignalogDataSet.ASUB)
            NewActCode.Text = ASUBTableAdapter.ReturnMaxACTCODE + 1
            If NewActCode.Text.Count = 3 Then
                NewActCode.Text = "0" & NewActCode.Text
            End If
    End Sub

    Private Sub ASUB1GridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ASUB1GridView.SelectionChanged
        Try
            i = ASUB1GridView.CurrentRow.Index
            If i <> ASUB1GridView.RowCount - 1 Then
                lnklabel = SignalogDataSet.ASUB1.Rows(i)(3)
                If lnklabel <> String.Empty Then
                    ASUB2Panel.Visible = True
                    ASUB3Panel.Visible = False
                    ASUB4Panel.Visible = False
                    ASUB5Panel.Visible = False
                    ASUB6Panel.Visible = False
                    Me.Height = 527
                Else
                    ASUB2Panel.Visible = False
                    ASUB3Panel.Visible = False
                    ASUB4Panel.Visible = False
                    ASUB5Panel.Visible = False
                    ASUB6Panel.Visible = False
                    Me.Height = 300
                End If
                actcode = SignalogDataSet.ASUB1.Rows(i)(4)
                Me.ASUB2TableAdapter.FillByLNKLBL(Me.SignalogDataSet.ASUB2, lnklabel)
                If Me.SignalogDataSet.ASUB2.Rows.Count = 0 Then
                    ASUB2Panel.Visible = False
                    Me.Height = 300
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub ASUB2GridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ASUB2GridView.SelectionChanged
        Try
            i = ASUB2GridView.CurrentRow.Index
            If i <> ASUB2GridView.RowCount - 1 Then
                lnklabel = SignalogDataSet.ASUB2.Rows(i)(3)
                If lnklabel <> String.Empty Then
                    ASUB3Panel.Visible = True
                    ASUB4Panel.Visible = False
                    ASUB5Panel.Visible = False
                    ASUB6Panel.Visible = False
                    Me.Height = 749
                Else
                    ASUB3Panel.Visible = False
                    ASUB4Panel.Visible = False
                    ASUB5Panel.Visible = False
                    ASUB6Panel.Visible = False
                    Me.Height = 527
                End If
                actcode = SignalogDataSet.ASUB2.Rows(i)(4)
                Me.ASUB3TableAdapter.FillByLNKLBL(Me.SignalogDataSet.ASUB3, lnklabel)
                If Me.SignalogDataSet.ASUB3.Rows.Count = 0 Then
                    ASUB3Panel.Visible = False
                    Me.Height = 527
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub ASUB3GridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ASUB3GridView.SelectionChanged
        Try
            i = ASUB3GridView.CurrentRow.Index
            If i <> ASUB3GridView.RowCount - 1 Then
                lnklabel = SignalogDataSet.ASUB3.Rows(i)(3)
                If lnklabel <> String.Empty Then
                    ASUB4Panel.Visible = True
                    ASUB5Panel.Visible = False
                    ASUB6Panel.Visible = False
                Else
                    ASUB4Panel.Visible = False
                    ASUB5Panel.Visible = False
                    ASUB6Panel.Visible = False
                End If
                actcode = SignalogDataSet.ASUB3.Rows(i)(4)
                Me.ASUB4TableAdapter.FillByLNKLBL(Me.SignalogDataSet.ASUB4, lnklabel)
            End If
            If Me.SignalogDataSet.ASUB4.Rows.Count = 0 Then
                ASUB4Panel.Visible = False
                Me.Height = 757
            End If
        Catch
        End Try
    End Sub

    Private Sub ASUB4GridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ASUB4GridView.SelectionChanged
        Try
            i = ASUB4GridView.CurrentRow.Index
            If i <> ASUB4GridView.RowCount - 1 Then
                lnklabel = SignalogDataSet.ASUB4.Rows(i)(3)
                If lnklabel <> String.Empty Then
                    ASUB5Panel.Visible = True
                    ASUB6Panel.Visible = False
                Else
                    ASUB5Panel.Visible = False
                    ASUB6Panel.Visible = False
                End If
                actcode = SignalogDataSet.ASUB4.Rows(i)(4)
                Me.ASUB5TableAdapter.FillByLNKLBL(Me.SignalogDataSet.ASUB5, lnklabel)
            End If
            If Me.SignalogDataSet.ASUB5.Rows.Count = 0 Then
                ASUB5Panel.Visible = False
            End If
        Catch
        End Try
    End Sub

    Private Sub ASUB5GridView_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ASUB5GridView.SelectionChanged
        Try
            i = ASUB5GridView.CurrentRow.Index
            If i <> ASUB5GridView.RowCount - 1 Then
                lnklabel = SignalogDataSet.ASUB5.Rows(i)(3)
                If lnklabel <> String.Empty Then
                    ASUB6Panel.Visible = True
                Else
                    ASUB6Panel.Visible = False
                End If
                actcode = SignalogDataSet.ASUB5.Rows(i)(4)
                Me.ASUB6TableAdapter.FillByLNKLBL(Me.SignalogDataSet.ASUB6, lnklabel)
            End If
            If Me.SignalogDataSet.ASUB6.Rows.Count = 0 Then
                ASUB6Panel.Visible = False
            End If
        Catch
        End Try
    End Sub

    Private Sub ASUB1GridView_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles ASUB1GridView.UserDeletingRow
        If ACT1TableAdapter.ReturnCodeCOUNT(ASUB1GridView.CurrentRow.Cells.Item(4).Value) <> 0 Then
            e.Cancel = True
            MsgBox("Can't delete activity, it is being used in one or more trouble reports", MsgBoxStyle.Exclamation, "Delete Forbidden")
        End If
    End Sub

    Private Sub ASUB2GridView_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles ASUB2GridView.UserDeletingRow
        If ACT1TableAdapter.ReturnCodeCOUNT(ASUB2GridView.CurrentRow.Cells.Item(4).Value) <> 0 Then
            e.Cancel = True
            MsgBox("Can't delete activity, it is being used in one or more trouble reports", MsgBoxStyle.Exclamation, "Delete Forbidden")
        End If
    End Sub

    Private Sub ASUB3GridView_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles ASUB3GridView.UserDeletingRow
        If ACT1TableAdapter.ReturnCodeCOUNT(ASUB3GridView.CurrentRow.Cells.Item(4).Value) <> 0 Then
            e.Cancel = True
            MsgBox("Can't delete activity, it is being used in one or more trouble reports", MsgBoxStyle.Exclamation, "Delete Forbidden")
        End If
    End Sub

    Private Sub ASUB4GridView_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles ASUB4GridView.UserDeletingRow
        If ACT1TableAdapter.ReturnCodeCOUNT(ASUB4GridView.CurrentRow.Cells.Item(4).Value) <> 0 Then
            e.Cancel = True
            MsgBox("Can't delete activity, it is being used in one or more trouble reports", MsgBoxStyle.Exclamation, "Delete Forbidden")
        End If
    End Sub

    Private Sub ASUB5GridView_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles ASUB5GridView.UserDeletingRow
        If ACT1TableAdapter.ReturnCodeCOUNT(ASUB5GridView.CurrentRow.Cells.Item(4).Value) <> 0 Then
            e.Cancel = True
            MsgBox("Can't delete activity, it is being used in one or more trouble reports", MsgBoxStyle.Exclamation, "Delete Forbidden")
        End If
    End Sub

    Private Sub ASUB6GridView_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles ASUB6GridView.UserDeletingRow
        If ACT1TableAdapter.ReturnCodeCOUNT(ASUB6GridView.CurrentRow.Cells.Item(4).Value) <> 0 Then
            e.Cancel = True
            MsgBox("Can't delete activity, it is being used in one or more trouble reports", MsgBoxStyle.Exclamation, "Delete Forbidden")
        End If
    End Sub

    Private Sub ASUB1GridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles ASUB1GridView.CellBeginEdit
        If ASUB1GridView.CurrentCellAddress.X = 4 Then
            If ASUB1GridView.CurrentRow.Cells.Item(4).Value.ToString <> String.Empty Then
                If ACT1TableAdapter.ReturnCodeCOUNT(ASUB1GridView.CurrentRow.Cells.Item(4).Value) <> 0 Then
                    e.Cancel = True
                    MsgBox("Can't change activity code, it is being used by one or more trouble reports", MsgBoxStyle.Exclamation, "Edit Forbidden")
                End If
            End If
        End If
    End Sub

    Private Sub ASUB2GridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles ASUB2GridView.CellBeginEdit
        If ASUB2GridView.CurrentCellAddress.X = 4 Then
            If ASUB2GridView.CurrentRow.Cells.Item(4).Value.ToString <> String.Empty Then
                If ACT1TableAdapter.ReturnCodeCOUNT(ASUB2GridView.CurrentRow.Cells.Item(4).Value) <> 0 Then
                    e.Cancel = True
                    MsgBox("Can't change activity code, it is being used by one or more trouble reports", MsgBoxStyle.Exclamation, "Edit Forbidden")
                End If
            End If
        End If
    End Sub

    Private Sub ASUB3GridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles ASUB3GridView.CellBeginEdit
        If ASUB3GridView.CurrentCellAddress.X = 4 Then
            If ASUB3GridView.CurrentRow.Cells.Item(4).Value.ToString <> String.Empty Then
                If ACT1TableAdapter.ReturnCodeCOUNT(ASUB3GridView.CurrentRow.Cells.Item(4).Value) <> 0 Then
                    e.Cancel = True
                    MsgBox("Can't change activity code, it is being used by one or more trouble reports", MsgBoxStyle.Exclamation, "Edit Forbidden")
                End If
            End If
        End If
    End Sub

    Private Sub ASUB4GridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles ASUB4GridView.CellBeginEdit
        If ASUB4GridView.CurrentCellAddress.X = 4 Then
            If ASUB4GridView.CurrentRow.Cells.Item(4).Value.ToString <> String.Empty Then
                If ACT1TableAdapter.ReturnCodeCOUNT(ASUB4GridView.CurrentRow.Cells.Item(4).Value) <> 0 Then
                    e.Cancel = True
                    MsgBox("Can't change activity code, it is being used by one or more trouble reports", MsgBoxStyle.Exclamation, "Edit Forbidden")
                End If
            End If
        End If
    End Sub

    Private Sub ASUB5GridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles ASUB5GridView.CellBeginEdit
        If ASUB5GridView.CurrentCellAddress.X = 4 Then
            If ASUB5GridView.CurrentRow.Cells.Item(4).Value.ToString <> String.Empty Then
                If ACT1TableAdapter.ReturnCodeCOUNT(ASUB5GridView.CurrentRow.Cells.Item(4).Value) <> 0 Then
                    e.Cancel = True
                    MsgBox("Can't change activity code, it is being used by one or more trouble reports", MsgBoxStyle.Exclamation, "Edit Forbidden")
                End If
            End If
        End If
    End Sub

    Private Sub ASUB6GridView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles ASUB6GridView.CellBeginEdit
        If ASUB6GridView.CurrentCellAddress.X = 4 Then
            If ASUB6GridView.CurrentRow.Cells.Item(4).Value.ToString <> String.Empty Then
                If ACT1TableAdapter.ReturnCodeCOUNT(ASUB6GridView.CurrentRow.Cells.Item(4).Value) <> 0 Then
                    e.Cancel = True
                    MsgBox("Can't change activity code, it is being used by one or more trouble reports", MsgBoxStyle.Exclamation, "Edit Forbidden")
                End If
            End If
        End If
    End Sub
    
End Class