
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

Public Class Parts
    Dim SelectedArea As Integer
    Dim SelPart As String
    Dim flag2 As Boolean
    Public NewPart, NewArea As Boolean
    Dim PrevQuant As Integer  'Used to see if user changes part when editing or only changes other values such as quantity,cost,memo,status

    Private Sub Parts_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Trouble_Report.CommitEdit = True Then  'close when editing 
            Trouble_Report.CommitEdit = False
        End If
        NewPart = False
        NewArea = False
    End Sub

    Private Sub Parts_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CUS0TableAdapter.Fill(Me.SignalogDataSet.CUS0)
        Local.Checked = True

        If Trouble_Report.EquipADorRM = True Then   'Installed
            Me.Text = "Parts Installed"
            Label4.Visible = False
            Status.Visible = False
            Costlbl.Visible = True
            Cost.Visible = True
            Me.PartTableAdapter.FillPartsIns(Me.SignalogDataSet.Part, WareHouse.Text)
            Me.Part2TableAdapter.FillPartsInsByArea(Me.SignalogDataSet.Part2, SelectedArea)
        Else   'Removed
            Me.Text = "Parts Removed"
            Label4.Visible = True
            Status.Visible = True
            Costlbl.Visible = False
            Cost.Visible = False
            Me.PartTableAdapter.FillPartsRem(Me.SignalogDataSet.Part, WareHouse.Text)
            Me.Part2TableAdapter.FillPartsRemByArea(Me.SignalogDataSet.Part2, SelectedArea)
        End If
        Me.EQUIPMENTTableAdapter.Fill(Me.SignalogDataSet.EQUIPMENT)
        Me.EQUIPMENT2TableAdapter.Fill(Me.SignalogDataSet.EQUIPMENT2)

        Submit.Enabled = False
        Area.SelectedValue = Trouble_Report.CityAgency.SelectedValue
    End Sub

    Private Sub Parts_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        flag2 = 0
        Part.Text = String.Empty
        Serial.Text = String.Empty
        Quantity.Text = String.Empty
        Cost.Text = String.Empty
        Memo.Text = String.Empty
        WareHouse.Text = Login.DefWareHouse

        If Trouble_Report.CommitEdit = True Then   'Loading from trouble report array
            flag2 = 0
            If Trouble_Report.EquipADorRM = True Then   'Installed
                Trouble_Report.PrevPartID = Trouble_Report.PartInsID(Trouble_Report.EquipInstalledGrid.CurrentRow.Index, 1)
                Trouble_Report.prevpartwarehouse = Trouble_Report.PartInsWareHouse(Trouble_Report.EquipInstalledGrid.CurrentRow.Index)
                PrevQuant = Trouble_Report.PartInsID(Trouble_Report.EquipInstalledGrid.CurrentRow.Index, 2)
            ElseIf Trouble_Report.EquipADorRM = False Then    'Removed
                Trouble_Report.PrevPartID = Trouble_Report.PartRemID(Trouble_Report.EquipRemovedGrid.CurrentRow.Index, 1)
                Trouble_Report.prevpartwarehouse = Trouble_Report.PartRemWareHouse(Trouble_Report.EquipRemovedGrid.CurrentRow.Index)
                PrevQuant = Trouble_Report.PartRemID(Trouble_Report.EquipRemovedGrid.CurrentRow.Index, 2)
            End If
            If Trouble_Report.EditPartSrc = 1 Then    'Local
                Local.Checked = True
                WareHouse.Text = Trouble_Report.PrevPartWareHouse  'Set Filter Warehouse to that of part being edited
                Part.Text = EQUIPMENTTableAdapter.ReturnPartDesc(Trouble_Report.PrevPartID, Trouble_Report.PrevPartWareHouse)
                Serial.Text = EQUIPMENTTableAdapter.ReturnSerial(Trouble_Report.PrevPartID, Trouble_Report.PrevPartWareHouse)
            ElseIf Trouble_Report.EditPartSrc = 2 Then    'City Owned
                CityOwned.Checked = True
                Part.Text = EQUIPMENT2TableAdapter.ReturnPartDesc(Trouble_Report.PrevPartID)
                Serial.Text = EQUIPMENT2TableAdapter.ReturnSerial(Trouble_Report.PrevPartID)
                Area.SelectedValue = Trouble_Report.Area
            End If
            If Serial.Text = "None" Then   'Misc Part
                Quantity.ReadOnly = False
            Else   'Unique Part
                Quantity.Text = 1
                Quantity.ReadOnly = True
            End If
            If Trouble_Report.EquipADorRM = True Then   'Installed
                Quantity.Text = PrevQuant
                Cost.Text = Trouble_Report.PartInsID(Trouble_Report.EquipInstalledGrid.CurrentRow.Index, 3)
                Memo.Text = Trouble_Report.PartInsMemo(Trouble_Report.EquipInstalledGrid.CurrentRow.Index)
            ElseIf Trouble_Report.EquipADorRM = False Then    'Removed
                Quantity.Text = PrevQuant
                Memo.Text = Trouble_Report.PartRemMemo(Trouble_Report.EquipRemovedGrid.CurrentRow.Index)
                Status.Text = Parts_Status_TypeTableAdapter.ReturnStatusType(Trouble_Report.PartsRemStat(Trouble_Report.EquipRemovedGrid.CurrentRow.Index))
            End If
            Memo.Focus()
            Submit.Enabled = True
        End If
    End Sub

    Private Sub Part_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Part.SelectedIndexChanged
        If Part.SelectedValue <> String.Empty Then
            SelPart = Part.SelectedValue
            If Trouble_Report.EquipADorRM = True Then    'Add
                If Local.Checked = True Then    'Local Inventory
                    Me.SerialTableAdapter.FillByPartIns(Me.SignalogDataSet.Serial, SelPart, WareHouse.Text)
                    If Part.SelectedValue <> String.Empty And Serial.SelectedValue <> String.Empty Then
                        Submit.Enabled = True
                    End If
                Else    'City Owned Inventory
                    Me.Serial2TableAdapter.FillByPartInsArea(Me.SignalogDataSet.Serial2, SelPart, SelectedArea)
                    If Part.SelectedValue <> String.Empty And Serial.SelectedValue <> String.Empty And Area.SelectedValue <> String.Empty Then
                        Submit.Enabled = True
                    End If
                End If
            Else    'Remove
                If Local.Checked = True Then    'Local Inventory
                    Me.SerialTableAdapter.FillByPartRem(Me.SignalogDataSet.Serial, SelPart, WareHouse.Text)
                    If Part.SelectedValue <> String.Empty And Serial.SelectedValue <> String.Empty And Status.SelectedItem <> String.Empty Then
                        Submit.Enabled = True
                    End If
                Else    'City Owned Inventory
                    Me.Serial2TableAdapter.FillByPartRemArea(Me.SignalogDataSet.Serial2, SelPart, SelectedArea)
                    If Part.SelectedValue <> String.Empty And Serial.SelectedValue <> String.Empty And Status.SelectedItem <> String.Empty And Area.SelectedValue <> String.Empty Then
                        Submit.Enabled = True
                    End If
                End If
            End If
        End If
        LoadStuff()
        If Part.SelectedValue = "NEW" Then
            If Inventory_Maintenance.Visible = True Then
                MsgBox("Can't open Inventory Maintenance, form is already open" & vbCrLf & "Please close Inventory Maintenance and retry", MsgBoxStyle.Exclamation)
            Else
                NewPart = True
                Inventory_Maintenance.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Filter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filter.TextChanged
        Dim sn As String
        Dim c As Integer
        sn = Filter.Text
        c = sn.Length
        If Local.Checked = True Then    'Local Inventory
            If Trouble_Report.EquipADorRM = True Then
                If c = 1 Then
                    Me.SerialTableAdapter.FillBySerialIns(Me.SignalogDataSet.Serial, SelPart, "%" & sn & "__", WareHouse.Text)
                ElseIf c = 2 Then
                    Me.SerialTableAdapter.FillBySerialIns(Me.SignalogDataSet.Serial, SelPart, "%" & sn & "_", WareHouse.Text)
                Else
                    Me.SerialTableAdapter.FillBySerialIns(Me.SignalogDataSet.Serial, SelPart, "%" & sn, WareHouse.Text)
                End If
            Else
                If c = 1 Then
                    Me.SerialTableAdapter.FillBySerialRem(Me.SignalogDataSet.Serial, SelPart, "%" & sn & "__", WareHouse.Text)
                ElseIf c = 2 Then
                    Me.SerialTableAdapter.FillBySerialRem(Me.SignalogDataSet.Serial, SelPart, "%" & sn & "_", WareHouse.Text)
                Else
                    Me.SerialTableAdapter.FillBySerialRem(Me.SignalogDataSet.Serial, SelPart, "%" & sn, WareHouse.Text)
                End If
            End If
        Else    'City Owned Inventory
            If Trouble_Report.EquipADorRM = True Then
                If c = 1 Then
                    Me.Serial2TableAdapter.FillBySerialInsArea(Me.SignalogDataSet.Serial2, SelPart, "%" & sn & "__", SelectedArea)
                ElseIf c = 2 Then
                    Me.Serial2TableAdapter.FillBySerialInsArea(Me.SignalogDataSet.Serial2, SelPart, "%" & sn & "_", SelectedArea)
                Else
                    Me.Serial2TableAdapter.FillBySerialInsArea(Me.SignalogDataSet.Serial2, SelPart, "%" & sn, SelectedArea)
                End If
            Else
                If c = 1 Then
                    Me.Serial2TableAdapter.FillBySerialRemArea(Me.SignalogDataSet.Serial2, SelPart, "%" & sn & "__", SelectedArea)
                ElseIf c = 2 Then
                    Me.Serial2TableAdapter.FillBySerialRemArea(Me.SignalogDataSet.Serial2, SelPart, "%" & sn & "_", SelectedArea)
                Else
                    Me.Serial2TableAdapter.FillBySerialRemArea(Me.SignalogDataSet.Serial2, SelPart, "%" & sn, SelectedArea)
                End If
            End If
        End If
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Dim SubmitFlag As Boolean = True
        '--------------------------------------------------------------------------------------------------------------------------------------
        '-----------------------------Adding or editing installed or part removed entry--------------------------------------------------------
        If Trouble_Report.EquipADorRM = True Then  'Equipment added (Installed)
            If Quantity.Text = String.Empty Then
                MsgBox("Please Enter Quantity", MsgBoxStyle.Exclamation, "Missing Info")
                SubmitFlag = False
            ElseIf Cost.Text = String.Empty Then
                MsgBox("Please Enter Cost", MsgBoxStyle.Exclamation, "Missing Info")
                SubmitFlag = False
            ElseIf Part.Text = String.Empty Then
                MsgBox("Please select part", MsgBoxStyle.Exclamation, "Missing Info")
                SubmitFlag = False
            ElseIf Serial.Text = String.Empty Then
                MsgBox("Please select serial", MsgBoxStyle.Exclamation, "Missing Info")
                SubmitFlag = False
            ElseIf Cost.Text = 0 Then
                If MsgBox("Unit cost is zero, is that OK?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Cost.Focus()
                    SubmitFlag = False
                Else
                    GoTo l2
                End If
            Else
l2:
                Trouble_Report.EquipInstalledGrid.CurrentCell = Trouble_Report.EquipInstalledGrid.CurrentRow.Cells(0)   'To select Part cell (make it current cell)
                Trouble_Report.EquipInstalledGrid.BeginEdit(True)
                Trouble_Report.EquipInstalledGrid.EditingControl.Text = Part.Text
                Trouble_Report.EquipInstalledGrid.EndEdit()

                Trouble_Report.EquipInstalledGrid.CurrentCell = Trouble_Report.EquipInstalledGrid.CurrentRow.Cells(1)   'To select Serial cell (make it current cell)
                Trouble_Report.EquipInstalledGrid.BeginEdit(True)
                Trouble_Report.EquipInstalledGrid.EditingControl.Text = Serial.Text
                Trouble_Report.EquipInstalledGrid.EndEdit()

                Trouble_Report.EquipInstalledGrid.CurrentCell = Trouble_Report.EquipInstalledGrid.CurrentRow.Cells(2)   'To select Quantity cell (make it current cell)
                Trouble_Report.EquipInstalledGrid.BeginEdit(True)
                Trouble_Report.EquipInstalledGrid.EditingControl.Text = Quantity.Text
                Trouble_Report.EquipInstalledGrid.EndEdit()

                Trouble_Report.EquipInstalledGrid.CurrentCell = Trouble_Report.EquipInstalledGrid.CurrentRow.Cells(3)   'To select Unit Price cell (make it current cell)
                Trouble_Report.EquipInstalledGrid.BeginEdit(True)
                Trouble_Report.EquipInstalledGrid.EditingControl.Text = Cost.Text
                Trouble_Report.EquipInstalledGrid.EndEdit()

                Trouble_Report.EquipInstalledGrid.CurrentCell = Trouble_Report.EquipInstalledGrid.CurrentRow.Cells(4)   'To select Source cell (make it current cell)
                Trouble_Report.EquipInstalledGrid.BeginEdit(True)
                If Local.Checked = True Then
                    Trouble_Report.EquipInstalledGrid.EditingControl.Text = "LOC - " & WareHouse.Text
                    Trouble_Report.PartInsID(Trouble_Report.EquipInstalledGrid.CurrentRow.Index, 0) = 1 'Local
                    Trouble_Report.PartInsID(Trouble_Report.EquipInstalledGrid.CurrentRow.Index, 1) = EQUIPMENTTableAdapter.ReturnPartID(Part.Text, Serial.Text, WareHouse.Text)
                    Trouble_Report.PartInsWareHouse(Trouble_Report.EquipInstalledGrid.CurrentRow.Index) = WareHouse.Text
                Else
                    Trouble_Report.EquipInstalledGrid.EditingControl.Text = "CO"
                    Trouble_Report.PartInsID(Trouble_Report.EquipInstalledGrid.CurrentRow.Index, 0) = 2  'City Owned
                    Trouble_Report.PartInsID(Trouble_Report.EquipInstalledGrid.CurrentRow.Index, 1) = EQUIPMENT2TableAdapter.ReturnPartID(Part.Text, Serial.Text)
                End If
                Trouble_Report.EquipInstalledGrid.EndEdit()

                Trouble_Report.EquipInstalledGrid.CurrentCell = Trouble_Report.EquipInstalledGrid.CurrentRow.Cells(5)   'To select Memo cell (make it current cell)
                Trouble_Report.EquipInstalledGrid.BeginEdit(True)
                Trouble_Report.EquipInstalledGrid.EditingControl.Text = Memo.Text
                Trouble_Report.EquipInstalledGrid.EndEdit()

                Trouble_Report.PartInsID(Trouble_Report.EquipInstalledGrid.CurrentRow.Index, 2) = Quantity.Text
                Trouble_Report.PartInsID(Trouble_Report.EquipInstalledGrid.CurrentRow.Index, 3) = Cost.Text
                Trouble_Report.PartInsMemo(Trouble_Report.EquipInstalledGrid.CurrentRow.Index) = Memo.Text
            End If
        Else    'Equipment removed
            'Trouble_Report.EquipRemAdd.Enabled = True
            If Quantity.Text = String.Empty Then
                MsgBox("Please Enter Quantity", MsgBoxStyle.Exclamation, "Missing Info")
                SubmitFlag = False
            ElseIf Part.Text = String.Empty Then
                MsgBox("Please select part", MsgBoxStyle.Exclamation, "Missing Info")
                SubmitFlag = False
            ElseIf Serial.Text = String.Empty Then
                MsgBox("Please select serial", MsgBoxStyle.Exclamation, "Missing Info")
                SubmitFlag = False
            Else
                Trouble_Report.EquipRemovedGrid.CurrentCell = Trouble_Report.EquipRemovedGrid.CurrentRow.Cells(0)   'To select Part cell (make it current cell)
                Trouble_Report.EquipRemovedGrid.BeginEdit(True)
                Trouble_Report.EquipRemovedGrid.EditingControl.Text = Part.Text
                Trouble_Report.EquipRemovedGrid.EndEdit()

                Trouble_Report.EquipRemovedGrid.CurrentCell = Trouble_Report.EquipRemovedGrid.CurrentRow.Cells(1)   'To select Serial cell (make it current cell)
                Trouble_Report.EquipRemovedGrid.BeginEdit(True)
                Trouble_Report.EquipRemovedGrid.EditingControl.Text = Serial.Text
                Trouble_Report.EquipRemovedGrid.EndEdit()

                Trouble_Report.EquipRemovedGrid.CurrentCell = Trouble_Report.EquipRemovedGrid.CurrentRow.Cells(2)   'To select Quantity cell (make it current cell)
                Trouble_Report.EquipRemovedGrid.BeginEdit(True)
                Trouble_Report.EquipRemovedGrid.EditingControl.Text = Quantity.Text
                Trouble_Report.EquipRemovedGrid.EndEdit()

                Trouble_Report.EquipRemovedGrid.CurrentCell = Trouble_Report.EquipRemovedGrid.CurrentRow.Cells(3)   'To select Source cell (make it current cell)
                Trouble_Report.EquipRemovedGrid.BeginEdit(True)
                If Local.Checked = True Then
                    Trouble_Report.EquipRemovedGrid.EditingControl.Text = "LOC - " & WareHouse.Text
                    Trouble_Report.PartRemID(Trouble_Report.EquipRemovedGrid.CurrentRow.Index, 0) = 1   'Local
                    Trouble_Report.PartRemID(Trouble_Report.EquipRemovedGrid.CurrentRow.Index, 1) = EQUIPMENTTableAdapter.ReturnPartID(Part.Text, Serial.Text, WareHouse.Text)
                    Trouble_Report.PartRemWareHouse(Trouble_Report.EquipRemovedGrid.CurrentRow.Index) = WareHouse.Text
                Else
                    Trouble_Report.EquipRemovedGrid.EditingControl.Text = "CO"
                    Trouble_Report.PartRemID(Trouble_Report.EquipRemovedGrid.CurrentRow.Index, 0) = 2   'City Owned
                    Trouble_Report.PartRemID(Trouble_Report.EquipRemovedGrid.CurrentRow.Index, 1) = EQUIPMENT2TableAdapter.ReturnPartID(Part.Text, Serial.Text)
                End If
                Trouble_Report.EquipRemovedGrid.EndEdit()

                Trouble_Report.EquipRemovedGrid.CurrentCell = Trouble_Report.EquipRemovedGrid.CurrentRow.Cells(4)   'To select Memo cell (make it current cell)
                Trouble_Report.EquipRemovedGrid.BeginEdit(True)
                Trouble_Report.EquipRemovedGrid.EditingControl.Text = Memo.Text
                Trouble_Report.EquipRemovedGrid.EndEdit()

                Trouble_Report.PartRemID(Trouble_Report.EquipRemovedGrid.CurrentRow.Index, 2) = Quantity.Text
                Trouble_Report.PartRemMemo(Trouble_Report.EquipRemovedGrid.CurrentRow.Index) = Memo.Text

                If Status.SelectedItem = "In Inventory" Then
                    Trouble_Report.PartsRemStat(Trouble_Report.EquipRemovedGrid.CurrentRow.Index) = 1
                ElseIf Status.SelectedItem = "Out for repair" Then
                    Trouble_Report.PartsRemStat(Trouble_Report.EquipRemovedGrid.CurrentRow.Index) = 3
                ElseIf Status.SelectedItem = "Not Repairable-Out of service" Then
                    Trouble_Report.PartsRemStat(Trouble_Report.EquipRemovedGrid.CurrentRow.Index) = 7
                End If
            End If
        End If

        '--------------------------------------If Editing a part installed or removed entry-------------------------------------------------
        '---------------------------------------------------Restore Status------------------------------------------------------------------
        If Trouble_Report.CommitEdit = True Then
            'Get PartID
            Dim PartID As Integer
            Dim NewWareHouse As String
            If Trouble_Report.EquipADorRM = True Then    'Installed
                PartID = Trouble_Report.PartInsID(Trouble_Report.EquipInstalledGrid.CurrentRow.Index, 1)
                NewWareHouse = Trouble_Report.PartInsWareHouse(Trouble_Report.EquipInstalledGrid.CurrentRow.Index)
            ElseIf Trouble_Report.EquipADorRM = False Then    'Removed
                PartID = Trouble_Report.PartRemID(Trouble_Report.EquipRemovedGrid.CurrentRow.Index, 1)
                NewWareHouse = Trouble_Report.PartRemWareHouse(Trouble_Report.EquipRemovedGrid.CurrentRow.Index)
            Else
                NewWareHouse = Nothing
            End If

            If Trouble_Report.PrevPartID <> PartID And Trouble_Report.prevpartwarehouse = NewWareHouse Then  'Part Changed so restore status if unique
                If ACT3TableAdapter.PartExistsInDatabase(Trouble_Report.txtactnum.Text, Trouble_Report.EditPartType, Trouble_Report.EditPartNum, Trouble_Report.PrevPartID) <> 0 Then
                    If Trouble_Report.EditPartSrc = 1 Then    'Local
                        If EQUIPMENTTableAdapter.ReturnStatusAtID(Trouble_Report.PrevPartID, Trouble_Report.prevpartwarehouse) <> 8 Then   'Unique part
                            Me.Close()
                            flag2 = 1    'Leave the selection on textboxes
                            Restore_Status.ShowDialog()
                        End If
                    ElseIf Trouble_Report.EditPartSrc = 2 Then   'City Owned
                        If EQUIPMENT2TableAdapter.ReturnStatusAtID(Trouble_Report.PrevPartID) <> 8 Then   'Unique part
                            Me.Close()
                            flag2 = 1    'Leave the selection on textboxes
                            Restore_Status.ShowDialog()
                        End If
                    End If
                End If
            End If
        End If

        If SubmitFlag = True Then
            Me.Close()
        End If
    End Sub

    Private Sub Serial_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Serial.SelectedIndexChanged
        LoadStuff()
    End Sub

    Private Sub Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Status.SelectedIndexChanged
        If Local.Checked = True Then    'Local Inventory
            If Trouble_Report.EquipADorRM = True Then
                If Part.SelectedValue <> String.Empty And Serial.SelectedValue <> String.Empty And WareHouse.Text <> String.Empty Then
                    Submit.Enabled = True
                End If
            Else
                If Part.SelectedValue <> String.Empty And Serial.SelectedValue <> String.Empty And Status.SelectedItem <> String.Empty And WareHouse.Text <> String.Empty Then
                    Submit.Enabled = True
                End If
            End If
        Else    'City Owned Inventory
            If Trouble_Report.EquipADorRM = True Then
                If Part.SelectedValue <> String.Empty And Serial.SelectedValue <> String.Empty And Area.SelectedValue <> String.Empty Then
                    Submit.Enabled = True
                End If
            Else
                If Part.SelectedValue <> String.Empty And Serial.SelectedValue <> String.Empty And Status.SelectedItem <> String.Empty And Area.SelectedValue <> String.Empty Then
                    Submit.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub Local_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Local.CheckedChanged
        Dim Xindent As Integer    'Indentation between label and its corresponding textbox 
        Xindent = Quantity.Location.X - (Quantlbl.Location.X + Quantlbl.Size.Width)

        If Local.Checked = True Then   'Local Inventory
            Label5.Visible = False
            Area.Visible = False
            WareHouselbl.Visible = True
            WareHouse.Visible = True
            WareHouse.Text = Login.DefWareHouse

            Costlbl.Text = "Unit Cost"
            Cost.Location = New Point(Costlbl.Location.X + Costlbl.Size.Width + Xindent, Quantity.Location.Y)

            SelectedArea = CUS0TableAdapter.ReturnAREANUM(Area.SelectedValue)
            Part.DataSource = PartBindingSource
            Serial.DataSource = SerialBindingSource

            If Trouble_Report.EquipADorRM = True Then   'Equipment Install
                Costlbl.Visible = True
                Cost.Visible = True
                PartTableAdapter.FillPartsIns(Me.SignalogDataSet.Part, WareHouse.Text)
            Else   'Equipment Remove
                Costlbl.Visible = False
                Cost.Visible = False
                PartTableAdapter.FillPartsRem(Me.SignalogDataSet.Part, WareHouse.Text)
            End If

        Else    'City Owned Inventory
            WareHouselbl.Visible = False
            WareHouse.Visible = False
            Label5.Visible = True
            Area.Visible = True
            Area.SelectedValue = Trouble_Report.CityAgency.SelectedValue
            Costlbl.Text = "Unit Repair Cost"
            Cost.Location = New Point(Costlbl.Location.X + Costlbl.Size.Width + Xindent, Quantity.Location.Y)

            SelectedArea = CUS0TableAdapter.ReturnAREANUM(Area.SelectedValue)
            Part.DataSource = Part2BindingSource
            Serial.DataSource = Serial2BindingSource

            If Trouble_Report.EquipADorRM = True Then   'Equipment Install
                Part2TableAdapter.FillPartsInsByArea(Me.SignalogDataSet.Part2, SelectedArea)
            Else   'Equipment Remove
                Costlbl.Visible = False
                Cost.Visible = False
                Part2TableAdapter.FillPartsRemByArea(Me.SignalogDataSet.Part2, SelectedArea)
            End If

        End If
    End Sub

    Private Sub Area_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Area.SelectedIndexChanged
        If Area.SelectedValue <> String.Empty Then
            If Area.SelectedValue = "NEW" Then
                If Area_Maintenance.Visible = True Then
                    MsgBox("Can't open Area Maintenance, form is already open" & vbCrLf & "Please close Area Maintenance and retry", MsgBoxStyle.Exclamation)
                Else
                    NewArea = True
                    Area_Maintenance.ShowDialog()
                End If
            Else
                SelectedArea = CUS0TableAdapter.ReturnAREANUM(Area.SelectedValue)
                If Trouble_Report.EquipADorRM = True Then
                    Part2TableAdapter.FillPartsInsByArea(Me.SignalogDataSet.Part2, SelectedArea)
                Else
                    Part2TableAdapter.FillPartsRemByArea(Me.SignalogDataSet.Part2, SelectedArea)
                End If
            End If
        End If
    End Sub

    Private Sub Parts_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.TextChanged
        Me.Text = "Parts"

        If NewArea = True Then    'When a new area is created from Area Maintenance
            NewArea = False
            Me.CUS0TableAdapter.Fill(Me.SignalogDataSet.CUS0)
            Try
                Area.SelectedValue = CUS0TableAdapter.ReturnAreaName(CUS0TableAdapter.ReturnMAXAREANUM - 1)
            Catch
            End Try
        End If

        If NewPart = True Then    'When a new part is created from Inventory Maintenance
            NewPart = False
            If Trouble_Report.EquipADorRM = True Then
                If Local.Checked = True Then    'Local Inventory
                    Me.PartTableAdapter.FillPartsIns(Me.SignalogDataSet.Part, WareHouse.Text)
                    Me.EQUIPMENTTableAdapter.Fill(Me.SignalogDataSet.EQUIPMENT)
                Else    'City Owned Inventory
                    Me.Part2TableAdapter.FillPartsInsByArea(Me.SignalogDataSet.Part2, SelectedArea)
                    Me.EQUIPMENT2TableAdapter.Fill(Me.SignalogDataSet.EQUIPMENT2)
                End If
            Else
                If Local.Checked = True Then    'Local Inventory
                    Me.PartTableAdapter.FillPartsRem(Me.SignalogDataSet.Part, WareHouse.Text)
                    Me.EQUIPMENTTableAdapter.Fill(Me.SignalogDataSet.EQUIPMENT)
                Else    'City Owned Inventory
                    Me.Part2TableAdapter.FillPartsRemByArea(Me.SignalogDataSet.Part2, SelectedArea)
                    Me.EQUIPMENT2TableAdapter.Fill(Me.SignalogDataSet.EQUIPMENT2)
                End If
            End If
            'Select the new part directly to the PART & SERIAL FIELDS
            Try
                If Local.Checked = True Then    'Local Inventory
                    Part.SelectedValue = EQUIPMENTTableAdapter.ReturnPartDesc(EQUIPMENTTableAdapter.ReturnMaxPartID(WareHouse.Text) - 1, WareHouse.Text)
                    Serial.SelectedValue = EQUIPMENTTableAdapter.ReturnSerial(EQUIPMENTTableAdapter.ReturnMaxPartID(WareHouse.Text) - 1, WareHouse.Text)
                Else    'City Owned Inventory
                    Part.SelectedValue = EQUIPMENT2TableAdapter.ReturnPartDesc(EQUIPMENT2TableAdapter.ReturnMaxPartID - 1)
                    Serial.SelectedValue = EQUIPMENT2TableAdapter.ReturnSerial(EQUIPMENT2TableAdapter.ReturnMaxPartID - 1)
                End If
            Catch
            End Try
        End If

    End Sub

    Private Function TrapKey(ByVal KCode As String) As Boolean  'allow only numbers
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then '8:backspace
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function

    Private Function TrapKey2(ByVal KCode As String) As Boolean  'allow only numbers (decimal)
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Or KCode = 46 Then '8:backspace  , 46: .
            TrapKey2 = False
        Else
            TrapKey2 = True
        End If
    End Function

    Private Sub Quantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Quantity.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Sub Cost_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cost.KeyPress
        e.Handled = TrapKey2(Asc(e.KeyChar))
    End Sub

    Private Sub WareHouse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WareHouse.SelectedIndexChanged
        If Trouble_Report.EquipADorRM = True Then   'Installed
            Me.PartTableAdapter.FillPartsIns(Me.SignalogDataSet.Part, WareHouse.Text)
        Else   'Removed
            Me.PartTableAdapter.FillPartsRem(Me.SignalogDataSet.Part, WareHouse.Text)
        End If
    End Sub

    Private Sub LoadStuff()   'Load Quantity,Cost when selected part or selected serial is changed
        Quantity.Text = String.Empty
        Cost.Text = String.Empty
        Memo.Text = String.Empty
        If Serial.SelectedValue = "NEW" Then   'If New Serial
            If Inventory_Maintenance.Visible = True Then
                MsgBox("Can't open Inventory Maintenance, form is already open" & vbCrLf & "Please close Inventory Maintenance and retry", MsgBoxStyle.Exclamation)
            Else
                NewPart = True
                Inventory_Maintenance.ShowDialog()
            End If
        Else   'If serial exists
            Try
                'Quantity
                If Serial.SelectedValue = "None" Then   'Misc Part
                    Quantity.ReadOnly = False
                Else   'Unique Part
                    Quantity.Text = 1
                    Quantity.ReadOnly = True
                End If
                If Local.Checked = True Then   'Local Inventory
                    If Trouble_Report.EquipADorRM = True Then   'Installed
                        If Part.SelectedValue <> String.Empty And Serial.SelectedValue <> String.Empty And WareHouse.Text <> String.Empty Then
                            Submit.Enabled = True
                            'Cost
                            If CUS0TableAdapter.ReturnMaintCont(CUS0TableAdapter.ReturnAREANUM(Trouble_Report.Area)) = "Y" Then  'Load Contract Cost
                                Cost.Text = EQUIPMENTTableAdapter.ReturnContractCost(Part.SelectedValue, Serial.SelectedValue, WareHouse.Text)
                            Else    'Load Non-Contract Cost
                                Cost.Text = EQUIPMENTTableAdapter.ReturnNonContractCost(Part.SelectedValue, Serial.SelectedValue, WareHouse.Text)
                            End If
                        End If
                    Else   'Removed
                        If Serial.SelectedValue = "None" Then   'Non-Unique part
                            Label4.Visible = False
                            Status.Visible = False
                            If Part.SelectedValue <> String.Empty And Serial.SelectedValue <> String.Empty And WareHouse.Text <> String.Empty Then
                                Submit.Enabled = True
                            Else
                                Submit.Enabled = False
                            End If
                        Else   'unique Part
                            Label4.Visible = True
                            Status.Visible = True
                            If Part.SelectedValue <> String.Empty And Serial.SelectedValue <> String.Empty And Status.SelectedItem <> String.Empty And WareHouse.Text <> String.Empty Then
                                Submit.Enabled = True
                            Else
                                Submit.Enabled = False
                            End If
                        End If
                    End If
                Else   'City Owned Inventory
                    If Trouble_Report.EquipADorRM = True Then   'Installed
                        If Part.SelectedValue <> String.Empty And Serial.SelectedValue <> String.Empty And Area.SelectedValue <> String.Empty Then
                            Submit.Enabled = True
                        End If
                    Else   'Removed
                        If Serial.SelectedValue = "None" Then   'Non-Unique part
                            Label4.Visible = False
                            Status.Visible = False
                            If Part.SelectedValue <> String.Empty And Serial.SelectedValue <> String.Empty And Area.SelectedValue <> String.Empty Then
                                Submit.Enabled = True
                            Else
                                Submit.Enabled = False
                            End If
                        Else   'unique Part
                            Label4.Visible = True
                            Status.Visible = True
                            If Part.SelectedValue <> String.Empty And Serial.SelectedValue <> String.Empty And Status.SelectedItem <> String.Empty And Area.SelectedValue <> String.Empty Then
                                Submit.Enabled = True
                            Else
                                Submit.Enabled = False
                            End If
                        End If
                    End If
                End If
            Catch
            End Try
        End If
    End Sub

End Class
