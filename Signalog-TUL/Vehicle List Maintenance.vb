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

Public Class Vehicle_List_Maintenance
    Dim selectedVehicle, oldVEHNUM As String
    Dim NewRecord As Boolean
    Dim EditRecord, flag As Boolean
    Dim sh, Fsh As String

    Private Sub Vehicle_List_Maintenance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Submit.Enabled = True Then
            If MsgBox("Are you sure you want to exit without saving changes?", MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                UndoButton.PerformClick()
                e.Cancel = False
            End If
        End If
    End Sub
    Private Sub Vehicle_List_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.VEHICLETableAdapter.Fill2(Me.SignalogDataSet.VEHICLE)
        VehNum.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        Submit.Enabled = False
        UndoButton.Enabled = False
        NewRecord = False
        EditRecord = False
        Filters.Checked = True
        FilterBoth.Checked = True
        VehicleID.Enabled = False
        bck.Enabled = False
        fwd.Enabled = False
        Fill()
        GetVeh()
        LoadData()
    End Sub

    Private Sub Vehicles_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Vehicles.SelectedIndexChanged
        GetVeh()
        LoadData()
    End Sub

    Private Sub ID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID.CheckedChanged
        If ID.Checked = True Then
            LoadPanel.Enabled = False
            VehicleID.Enabled = True
            bck.Enabled = True
            fwd.Enabled = True
            FilterBoth.Checked = True
        Else
            LoadPanel.Enabled = True
            VehicleID.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
        End If

        Fill()
        GetVeh()
        LoadData()
    End Sub

    Private Sub VehicleID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VehicleID.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Function TrapKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function

    Private Sub VehicleID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehicleID.TextChanged
        If VehicleID.Text <> "" And NewRecord = False Then
            If (VehicleID.Text > VEHICLETableAdapter.ReturnMaxID - 1) Or (VEHICLETableAdapter.ReturnCountID(VehicleID.Text) = 0) Then
                MsgBox("No record found for entered Manuf.ID")
                VehicleID.Text = ""
                VehNum.Text = ""
                YES.Checked = False
                NO.Checked = False
            Else
                Try
                    selectedVehicle = VEHICLETableAdapter.ReturnVEHNUM(VehicleID.Text)
                    Vehicles.SelectedValue = selectedVehicle
                    VehNum.Text = selectedVehicle
                    sh = VEHICLETableAdapter.ReturnShow(selectedVehicle)
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
        If VehicleID.Text = String.Empty Then
            VehicleID.Text = ""
            VehNum.Text = ""
            YES.Checked = False
            NO.Checked = False
        End If
    End Sub

    Private Sub fwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwd.Click
        Dim i As Integer
        If VehicleID.Text = "" Or VehicleID.Text = Convert.ToString(VEHICLETableAdapter.ReturnMaxID - 1) Then
            VehicleID.Text = VEHICLETableAdapter.ReturnMinID
        Else
            i = VehicleID.Text + 1
            While VEHICLETableAdapter.ReturnCountID(i) = 0 And VEHICLETableAdapter.ReturnMaxID - 1 > i
                i += 1
            End While
            If VEHICLETableAdapter.ReturnCountID(i) = 0 Then
                VehicleID.Text = VEHICLETableAdapter.ReturnMinID
            Else
                VehicleID.Text = i
            End If
        End If
    End Sub

    Private Sub bck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bck.Click
        Dim i As Integer
        If VehicleID.Text = "" Or VehicleID.Text = Convert.ToString(VEHICLETableAdapter.ReturnMinID) Then
            If VEHICLETableAdapter.ReturnCountID(VEHICLETableAdapter.ReturnMaxID - 1) <> 0 Then
                VehicleID.Text = VEHICLETableAdapter.ReturnMaxID - 1
            Else
                i = VEHICLETableAdapter.ReturnMaxID - 1
                While VEHICLETableAdapter.ReturnCountID(i) = 0 And i > 1
                    i -= 1
                End While
                VehicleID.Text = i
            End If
        Else
            i = VehicleID.Text - 1
            While VEHICLETableAdapter.ReturnCountID(i) = 0 And i > 1
                i -= 1
            End While
            VehicleID.Text = i
        End If
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If ACT0TableAdapter.ReturnVehNumCOUNT(VehNum.Text) <> 0 Then
            MsgBox("Delete forbidden, vehicle is associated with one or more trouble reports", MsgBoxStyle.Exclamation, "Delete Forbidden")
        Else
            Dim result As MsgBoxResult
            result = MsgBox("Are you sure you want to delete the selected vehicle?", MsgBoxStyle.YesNo, "Delete Vehicle?")
            If result = MsgBoxResult.Yes Then
                VEHICLETableAdapter.DeleteAtID(VehicleID.Text)
                Me.VEHICLETableAdapter.Fill2(Me.SignalogDataSet.VEHICLE)
                Fill()
                GetVeh()
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
        VehicleID.Enabled = False
        fwd.Enabled = False
        bck.Enabled = False
        VehNum.Enabled = True
        YES.Enabled = True
        NO.Enabled = True
        Submit.Enabled = True
        VehNum.Text = ""
        YES.Checked = False
        NO.Checked = False
        VehicleID.Text = LOCKNEWTableAdapter.ReturnLockValue("Vehicle") + 1   'Assign AREANUM= highest LOCK value +1
        LOCKNEWTableAdapter.UpdateLockValue(VehicleID.Text, "Vehicle")  'Update LOCK
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        If LOCKEDITTableAdapter.ReturnDescValueCOUNT("Vehicle", VehicleID.Text) <> 0 Then   'If locked for editing
            MsgBox("This vehicle record is being edited by another user, please try editing later", MsgBoxStyle.Information)
        Else
            LOCKEDITTableAdapter.Insert("Vehicle", VehicleID.Text)  'Lock for editing
            GetVeh()
            LoadData()

            EditButton.Enabled = False
            EditRecord = True
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            UndoButton.Enabled = True
            LoadByPanel.Visible = False
            LoadPanel.Enabled = False
            Label13.Visible = False
            VehicleID.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
            VehNum.Enabled = True
            YES.Enabled = True
            NO.Enabled = True
            Submit.Enabled = True
            oldVEHNUM = VehNum.Text
        End If
    End Sub

    Private Sub UndoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoButton.Click
        If EditRecord = True Then   'Release edit lock
            LOCKEDITTableAdapter.DeleteAtDescValue("Vehicle", VehicleID.Text)
        End If
        EditRecord = False
        NewRecord = False
        NewButton.Enabled = True
        Vehicles.Enabled = True
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        Label13.Visible = True
        LoadPanel.Enabled = True
        LoadByPanel.Visible = True

        If Filters.Checked = True Then
            VehicleID.Enabled = False
            LoadPanel.Enabled = True
            bck.Enabled = False
            fwd.Enabled = False
        Else
            VehicleID.Enabled = True
            LoadPanel.Enabled = False
            bck.Enabled = True
            fwd.Enabled = True
        End If

        UndoButton.Enabled = False
        VehNum.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        Submit.Enabled = False

        If Trouble_Report.NewVehNum = True Then
            Trouble_Report.NewVehNum = False
        End If

        GetVeh()
        LoadData()
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        flag = False
        Dim previousID As Integer
        previousID = VehicleID.Text
        If NewRecord = True Then
            If VEHICLETableAdapter.ReturnVehNumCOUNTnew(VehNum.Text) <> 0 Then
                If MsgBox("Vehicle number already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new vehicle number entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    VehNum.Text = ""
                    VehNum.Focus()
                End If
                flag = True   'Don't submit
            Else
                If VehNum.Text = String.Empty Then
                    MsgBox("Please enter Vehicle Number")
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
                    VEHICLETableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("Vehicle") + 1, VEHICLETableAdapter.ReturnID("NEW")) 'Increment NEW ID
                    VEHICLETableAdapter.Insert(VehicleID.Text, VehNum.Text, sh)
                    Me.VEHICLETableAdapter.Fill2(Me.SignalogDataSet.VEHICLE)
                    NewRecord = False
                End If
            End If
        End If

        If EditRecord = True Then
            If VEHICLETableAdapter.ReturnVehNumCOUNTedit(VehNum.Text, VehicleID.Text) <> 0 Then
                If MsgBox("Vehicle number already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new vehicle number entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    VehNum.Text = ""
                    VehNum.Focus()
                End If
                flag = True   'Don't submit
            Else
                If VehNum.Text = String.Empty Then
                    MsgBox("Please enter Vehicle Number")
                    flag = True
                Else
                    If YES.Checked = True Then
                        sh = "Y"
                    Else
                        sh = "N"
                    End If
                    LOCKEDITTableAdapter.DeleteAtDescValue("Vehicle", VehicleID.Text)   'Release Edit LOCK
                    VEHICLETableAdapter.UpdateAtVEHID(VehNum.Text, sh, VehicleID.Text)
                    ACT0TableAdapter.UpdateVEHNUM(VehNum.Text, oldVEHNUM)
                    Me.VEHICLETableAdapter.Fill2(Me.SignalogDataSet.VEHICLE)
                    EditRecord = False
                End If
            End If
        End If

        If flag = False Then
            NewButton.Enabled = True
            Vehicles.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = True
            Label13.Visible = True
            LoadPanel.Enabled = True
            LoadByPanel.Visible = True

            If Filters.Checked = True Then
                VehicleID.Enabled = False
                LoadPanel.Enabled = True
                bck.Enabled = False
                fwd.Enabled = False
            Else
                VehicleID.Enabled = True
                LoadPanel.Enabled = False
                bck.Enabled = True
                fwd.Enabled = True
            End If

            UndoButton.Enabled = False
            VehNum.Enabled = False
            YES.Enabled = False
            NO.Enabled = False
            Submit.Enabled = False

            Fill()
            Vehicles.SelectedValue = VEHICLETableAdapter.ReturnVEHNUM(previousID)
        End If

        If Trouble_Report.NewVehNum = True And flag = False Then
            Me.Close()
            Trouble_Report.Text = Trouble_Report.Text & "n"
        End If
    End Sub

    Sub LoadData()
        Try
            VehicleID.Text = VEHICLETableAdapter.ReturnID(selectedVehicle)
            VehNum.Text = selectedVehicle
            sh = VEHICLETableAdapter.ReturnShow(selectedVehicle)
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
            VEHICLETableAdapter.Fill2(Me.SignalogDataSet.VEHICLE)
        Else
            VEHICLETableAdapter.FillBySHOW(Me.SignalogDataSet.VEHICLE, Fsh)
        End If
    End Sub

    Private Sub FilterYES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterYES.CheckedChanged
        If FilterYES.Checked = True Then
            Fsh = "Y"
        ElseIf FilterNO.Checked = True Then
            Fsh = "N"
        End If
        Fill()
        GetVeh()
        LoadData()
    End Sub

    Private Sub FilterNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterNO.CheckedChanged
        If FilterYES.Checked = True Then
            Fsh = "Y"
        ElseIf FilterNO.Checked = True Then
            Fsh = "N"
        End If
        Fill()
        GetVeh()
        LoadData()
    End Sub

    Sub GetVeh()
        If Me.SignalogDataSet.VEHICLE.Rows.Count <> 0 Then
            selectedVehicle = Vehicles.SelectedValue
        Else
            selectedVehicle = ""
        End If
    End Sub

    Private Sub Vehicle_List_Maintenance_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Trouble_Report.NewVehNum = True Then
            Me.NewButton.PerformClick()
            Me.YES.Checked = True
        End If
    End Sub
End Class