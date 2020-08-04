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

Public Class Restore_Status
    Dim PartId As Integer
    Dim WareHouse As String
    Dim flag As Boolean   'When closing without clicking update
    Private Sub Restore_Status_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If flag = False Then   'close without clicking update
            Trouble_Report.DeletePart = False
        End If
    End Sub

    Private Sub Restore_Status_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If flag = False And Trouble_Report.CommitEdit = True Then
            e.Cancel = True
            MsgBox("Can't close before restoring status of previous part", MsgBoxStyle.Exclamation)
        ElseIf flag = True And Trouble_Report.CommitEdit = True Then
            Trouble_Report.CommitEdit = False
        End If
    End Sub

    Private Sub Restore_Status_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        flag = False
        Me.Parts_Status_TypeTableAdapter.Fill(Me.SignalogDataSet.Parts_Status_Type)
        Area.Visible = False
        Dim stat As Integer
        
        If Trouble_Report.EditPartType = 1 Then    'Installed
            PartId = ACT3TableAdapter.ReturnPartID(Trouble_Report.txtactnum.Text, Trouble_Report.EditPartType, Trouble_Report.PartInsGroupNum(Trouble_Report.EquipInstalledGrid.CurrentRow.Index))
            WareHouse = ACT3TableAdapter.ReturnWareHouse(Trouble_Report.txtactnum.Text, Trouble_Report.EditPartType, Trouble_Report.PartInsGroupNum(Trouble_Report.EquipInstalledGrid.CurrentRow.Index))
        Else    'Removed
            PartId = ACT3TableAdapter.ReturnPartID(Trouble_Report.txtactnum.Text, Trouble_Report.EditPartType, Trouble_Report.PartRemGroupNum(Trouble_Report.EquipRemovedGrid.CurrentRow.Index))
            WareHouse = ACT3TableAdapter.ReturnWareHouse(Trouble_Report.txtactnum.Text, Trouble_Report.EditPartType, Trouble_Report.PartRemGroupNum(Trouble_Report.EquipRemovedGrid.CurrentRow.Index))
        End If

        If Trouble_Report.CommitEdit = True Then
            PartId = Trouble_Report.PrevPartID
            WareHouse = Trouble_Report.PrevPartWareHouse
        End If

        If Trouble_Report.EditPartSrc = 1 Then   'local
            Source.Text = "LOCAL"
            Desc.Text = EQUIPMENTTableAdapter.ReturnPartDesc(PartId, WareHouse)
            Serial.Text = EQUIPMENTTableAdapter.ReturnSerial(PartId, WareHouse)
            stat = EQUIPMENTTableAdapter.ReturnStatusAtID(PartId, WareHouse)
            CStatus.Text = Parts_Status_TypeTableAdapter.ReturnStatusType(stat)
        ElseIf Trouble_Report.EditPartSrc = 2 Then   'city owned
            Area.Visible = True
            Source.Text = "CITY OWNED"
            Area.Text = CUS0TableAdapter.ReturnAreaName(EQUIPMENT2TableAdapter.ReturnAREANUMAtID(PartId))
            Desc.Text = EQUIPMENT2TableAdapter.ReturnPartDesc(PartId)
            Serial.Text = EQUIPMENT2TableAdapter.ReturnSerial(PartId)
            stat = EQUIPMENT2TableAdapter.ReturnStatusAtID(PartId)
            CStatus.Text = Parts_Status_TypeTableAdapter.ReturnStatusType(stat)
        End If
    End Sub

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateStatus.Click
        If Status.Text = String.Empty Then
            MsgBox("Please select updated status")
        Else
            flag = True
            'For updating the status of edited or deleted part when tourble_report submit buttom is clicked
            Trouble_Report.UpdatePartStatusCount += 1
            Trouble_Report.UpdatePartStatus(Trouble_Report.UpdatePartStatusCount - 1, 0) = Trouble_Report.EditPartSrc
            Trouble_Report.UpdatePartStatus(Trouble_Report.UpdatePartStatusCount - 1, 1) = PartId
            Trouble_Report.UpdatePartStatus(Trouble_Report.UpdatePartStatusCount - 1, 2) = Parts_Status_TypeTableAdapter.ReturnOrderNum(Status.SelectedValue)
            Trouble_Report.UpdatePartStatus(Trouble_Report.UpdatePartStatusCount - 1, 3) = WareHouse

            If Trouble_Report.DeletePart = True Then    'Deleteing
                DeleteRecord()
                Me.Close()
            End If

            If Trouble_Report.CommitEdit = True Then     'Editing
                Trouble_Report.CommitEdit = False
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Restore_Status_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Status.Text = ""
    End Sub

    'Delete and shift (if necessary) textboxes and arrays related to parts in trouble report
    Public Sub DeleteRecord()
        If Trouble_Report.EditPartType = 1 Then    'Installed
            If Trouble_Report.EquipInstalledGrid.Rows.Count - 1 > 1 And Trouble_Report.EquipInstalledGrid.CurrentRow.Index + 1 <> Trouble_Report.EquipInstalledGrid.Rows.Count - 1 Then
                For i = Trouble_Report.EquipInstalledGrid.CurrentRow.Index + 1 To Trouble_Report.EquipInstalledGrid.Rows.Count - 2  'shift records to take deleted record place
                    For j = 0 To 3
                        Trouble_Report.PartInsID(i - 1, j) = Trouble_Report.PartInsID(i, j)
                    Next j
                    Trouble_Report.PartInsMemo(i - 1) = Trouble_Report.PartInsMemo(i)
                    Trouble_Report.PartInsWareHouse(i - 1) = Trouble_Report.PartInsWareHouse(i)
                    Trouble_Report.PartInsGroupNum(i - 1) = Trouble_Report.PartInsGroupNum(i)  'shift group num to take deleted record place
                Next i
                'empty last record
                For j = 0 To 3
                    Trouble_Report.PartInsID(Trouble_Report.EquipInstalledGrid.Rows.Count - 2, j) = 0
                Next j
                Trouble_Report.PartInsMemo(Trouble_Report.EquipInstalledGrid.Rows.Count - 2) = String.Empty
                Trouble_Report.PartInsWareHouse(Trouble_Report.EquipInstalledGrid.Rows.Count - 2) = String.Empty
                Trouble_Report.PartInsGroupNum(Trouble_Report.EquipInstalledGrid.Rows.Count - 2) = 0
            Else    'Only one record or it is the last record we are deleting
                'delete first(and only record) or last record in panel without shifting
                For i = 0 To 3
                    Trouble_Report.PartInsID(Trouble_Report.EquipInstalledGrid.CurrentRow.Index, i) = 0
                Next i
                Trouble_Report.PartInsMemo(Trouble_Report.EquipInstalledGrid.CurrentRow.Index) = String.Empty
                Trouble_Report.PartInsWareHouse(Trouble_Report.EquipInstalledGrid.CurrentRow.Index) = String.Empty
                Trouble_Report.PartInsGroupNum(Trouble_Report.EquipInstalledGrid.CurrentRow.Index) = 0
            End If

        ElseIf Trouble_Report.EditPartType = 2 Then    'Removed 
            If Trouble_Report.EquipRemovedGrid.Rows.Count - 1 > 1 And Trouble_Report.EquipRemovedGrid.CurrentRow.Index + 1 <> Trouble_Report.EquipRemovedGrid.Rows.Count - 1 Then
                For i = Trouble_Report.EquipRemovedGrid.CurrentRow.Index + 1 To Trouble_Report.EquipRemovedGrid.Rows.Count - 2  'shift records to take deleted record place
                    For j = 0 To 2
                        Trouble_Report.PartRemID(i - 1, j) = Trouble_Report.PartRemID(i, j)
                    Next j
                    Trouble_Report.PartRemMemo(i - 1) = Trouble_Report.PartRemMemo(i)
                    Trouble_Report.PartRemWareHouse(i - 1) = Trouble_Report.PartRemWareHouse(i)
                    Trouble_Report.PartsRemStat(i - 1) = Trouble_Report.PartsRemStat(i)
                    Trouble_Report.PartRemGroupNum(i - 1) = Trouble_Report.PartRemGroupNum(i)  'shift group num to take deleted record place
                Next i
                'empty last record
                For j = 0 To 2
                    Trouble_Report.PartRemID(Trouble_Report.EquipRemovedGrid.Rows.Count - 2, j) = 0
                Next j
                Trouble_Report.PartRemMemo(Trouble_Report.EquipRemovedGrid.Rows.Count - 2) = String.Empty
                Trouble_Report.PartRemWareHouse(Trouble_Report.EquipRemovedGrid.Rows.Count - 2) = String.Empty
                Trouble_Report.PartsRemStat(Trouble_Report.EquipRemovedGrid.Rows.Count - 2) = 0
                Trouble_Report.PartRemGroupNum(Trouble_Report.EquipRemovedGrid.Rows.Count - 2) = 0
            Else    'Only one record or it is the last record we are deleting
                'delete first(and only record) or last record in panel without shifting
                For i = 0 To 2
                    Trouble_Report.PartRemID(Trouble_Report.EquipRemovedGrid.CurrentRow.Index, i) = 0
                Next i
                Trouble_Report.PartRemMemo(Trouble_Report.EquipRemovedGrid.CurrentRow.Index) = String.Empty
                Trouble_Report.PartRemWareHouse(Trouble_Report.EquipRemovedGrid.CurrentRow.Index) = String.Empty
                Trouble_Report.PartsRemStat(Trouble_Report.EquipRemovedGrid.CurrentRow.Index) = 0
                Trouble_Report.PartRemGroupNum(Trouble_Report.EquipRemovedGrid.CurrentRow.Index) = 0
            End If
        End If

        Trouble_Report.DeletePart = False
    End Sub
End Class