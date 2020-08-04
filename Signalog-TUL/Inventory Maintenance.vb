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
Imports System.Data.SqlClient
Public Class Inventory_Maintenance
    Dim PFilter, SelectedPart, SelectedSerial, SelectedManuf As String
    Dim sn, sh As String
    Dim c As Integer
    Dim SelectedStatus, SelectedArea As Integer
    Dim NewRecord As Boolean
    Dim EditRecord, flag As Boolean
    Public NewPart, NewManuf, NewArea As Boolean
    Dim con, cmd As String

    Private Sub Inventory_Maintenance_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Parts.NewPart = False
    End Sub

    Private Sub Inventory_Maintenance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Submit.Enabled = True Then
            If MsgBox("Are you sure you want to exit without saving changes?", MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                UndoButton.PerformClick()
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub Inventory_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WareHouse.Text = Login.DefWareHouse   'Set Warehouse to default (selected uppon login)

        Me.CUS0TableAdapter.Fill2(Me.SignalogDataSet.CUS0)
        Local.Checked = True
        con = My.Settings.SignalogConnectionString
        Me.Parts_ListTableAdapter.Fill(Me.SignalogDataSet.Parts_List)
        Me.MANF_LISTTableAdapter.Fill2(Me.SignalogDataSet.MANF_LIST)
        Me.Parts_Status_TypeTableAdapter.Fill(Me.SignalogDataSet.Parts_Status_Type)
        Me.PartTableAdapter.Fill2(Me.SignalogDataSet.Part, WareHouse.Text)
        Me.Part2TableAdapter.Fill2(Me.SignalogDataSet.Part2)

        SelectedPart = ""
        SelectedSerial = ""
        PFilter = "%"
        SerialTableAdapter.FillByPartDesc(Me.SignalogDataSet.Serial, PartDesc.SelectedValue, WareHouse.Text)
        Serial2TableAdapter.FillByPart(Me.SignalogDataSet.Serial2, PartDesc.SelectedValue)

        NoneSN.Checked = False
        NoneSN.Enabled = False
        ManAll.Checked = True
        ManFilter.Enabled = False
        StatAll.Checked = True
        StatusFilter.Enabled = False
        AreaAll.Checked = True
        AreaFilter.Enabled = False
        Desc.Enabled = False
        PartNum.Enabled = False
        SNtxt.Enabled = False
        Status.Enabled = False
        Manuf.Enabled = False
        ContCosttxt.Enabled = False
        NonContCosttxt.Enabled = False
        Quantity.Enabled = False
        PartWareHouse.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        NewRecord = False
        EditRecord = False
        Submit.Enabled = False
        UndoButton.Enabled = False

        Filters.Checked = True
        IDtxt.Enabled = False
        bck.Enabled = False
        fwd.Enabled = False
        NewPart = False
        NewManuf = False

        GetPart()
        GetSerial()
        load4()
    End Sub

    Private Sub PartFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartFilter.TextChanged
        PFilter = PartFilter.Text & "%"

        load4()
    End Sub

    Private Sub PartDesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartDesc.SelectedIndexChanged
        GetPart()
        Try
            If Local.Checked = True Then
                SFilter()
                If Filters.Checked = True Then
                    IDtxt.Text = Convert.ToString(EQUIPMENTTableAdapter.ReturnPartID(SelectedPart, SelectedSerial, WareHouse.Text))
                End If
                LoadData()
            Else
                SFilter2()
                If Filters.Checked = True Then
                    IDtxt.Text = Convert.ToString(EQUIPMENT2TableAdapter.ReturnPartID(SelectedPart, SelectedSerial))
                End If
                LoadData2()
                End If
        Catch
        End Try
    End Sub

    Private Sub SerialFilter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SerialFilter.TextChanged
        If Local.Checked = True Then
            SFilter()
            IDtxt.Text = Convert.ToString(EQUIPMENTTableAdapter.ReturnPartID(SelectedPart, SelectedSerial, WareHouse.Text))
            LoadData()
        Else
            SFilter2()
            IDtxt.Text = Convert.ToString(EQUIPMENT2TableAdapter.ReturnPartID(SelectedPart, SelectedSerial))
            LoadData2()
        End If
    End Sub

    Private Sub Serial_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Serial.SelectedIndexChanged
        GetSerial()
        Try
            If Local.Checked = True Then
                If Filters.Checked = True Then
                    IDtxt.Text = Convert.ToString(EQUIPMENTTableAdapter.ReturnPartID(SelectedPart, SelectedSerial, WareHouse.Text))
                End If
                LoadData()
            Else
                If Filters.Checked = True Then
                    IDtxt.Text = Convert.ToString(EQUIPMENT2TableAdapter.ReturnPartID(SelectedPart, SelectedSerial))
                End If
                LoadData2()
                End If
        Catch
        End Try
    End Sub

    Private Sub StatAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatAll.CheckedChanged
        If StatAll.Checked = True Then
            StatusFilter.Enabled = False
        Else
            StatusFilter.Enabled = True
        End If

        load4()
    End Sub

    Private Sub ManAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManAll.CheckedChanged
        If ManAll.Checked = True Then
            ManFilter.Enabled = False
        Else
            ManFilter.Enabled = True
        End If

        load4()
    End Sub

    Private Sub AreaAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaAll.CheckedChanged
        If AreaAll.Checked = True Then
            AreaFilter.Enabled = False
        Else
            AreaFilter.Enabled = True
        End If

        load4()
    End Sub

    Private Sub StatusFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StatusFilter.SelectedIndexChanged
        Try
            SelectedStatus = Parts_Status_TypeTableAdapter.ReturnOrderNum(StatusFilter.SelectedValue)
            load4()
        Catch
        End Try
    End Sub

    Private Sub ManFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManFilter.SelectedIndexChanged
        Try
            SelectedManuf = ManFilter.SelectedValue
            load4()
        Catch
        End Try
    End Sub

    Private Sub AreaFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaFilter.SelectedIndexChanged
        Try
            SelectedArea = CUS0TableAdapter.ReturnAREANUM(AreaFilter.SelectedValue)
            load4()
        Catch
        End Try
    End Sub

    Private Sub fwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwd.Click
        Dim i As Integer
        If Local.Checked = True Then    'Local Inventory
            If IDtxt.Text = "" Or IDtxt.Text = Convert.ToString(EQUIPMENTTableAdapter.ReturnMaxPartID(WareHouse.Text) - 1) Then
                IDtxt.Text = EQUIPMENTTableAdapter.ReturnMinPartID(WareHouse.Text)
            Else
                i = IDtxt.Text + 1
                While EQUIPMENTTableAdapter.ReturnPartCount(i, WareHouse.Text) = 0 And EQUIPMENTTableAdapter.ReturnMaxPartID(WareHouse.Text) - 1 > i
                    i += 1
                End While
                If EQUIPMENTTableAdapter.ReturnPartCount(i, WareHouse.Text) = 0 Then
                    IDtxt.Text = EQUIPMENTTableAdapter.ReturnMinPartID(WareHouse.Text)
                Else
                    IDtxt.Text = i
                End If
            End If
        Else    'City Owned Inventory
            If IDtxt.Text = "" Or IDtxt.Text = Convert.ToString(EQUIPMENT2TableAdapter.ReturnMaxPartID - 1) Then
                IDtxt.Text = EQUIPMENT2TableAdapter.ReturnMinPartID
            Else
                i = IDtxt.Text + 1
                While EQUIPMENT2TableAdapter.ReturnPartCount(i) = 0 And EQUIPMENT2TableAdapter.ReturnMaxPartID - 1 > i
                    i += 1
                End While
                If EQUIPMENT2TableAdapter.ReturnPartCount(i) = 0 Then
                    IDtxt.Text = EQUIPMENT2TableAdapter.ReturnMinPartID
                Else
                    IDtxt.Text = i
                End If
            End If
        End If
    End Sub

    Private Sub bck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bck.Click
        Dim i As Integer
        If Local.Checked = True Then
            If IDtxt.Text = "" Or IDtxt.Text = Convert.ToString(EQUIPMENTTableAdapter.ReturnMinPartID(WareHouse.Text)) Then
                If EQUIPMENTTableAdapter.ReturnPartCount(EQUIPMENTTableAdapter.ReturnMaxPartID(WareHouse.Text) - 1, WareHouse.Text) <> 0 Then
                    IDtxt.Text = EQUIPMENTTableAdapter.ReturnMaxPartID(WareHouse.Text) - 1
                Else
                    i = EQUIPMENTTableAdapter.ReturnMaxPartID(WareHouse.Text) - 1
                    While EQUIPMENTTableAdapter.ReturnPartCount(i, WareHouse.Text) = 0 And i > 1
                        i -= 1
                    End While
                    IDtxt.Text = i
                End If
            Else
                i = IDtxt.Text - 1
                While EQUIPMENTTableAdapter.ReturnPartCount(i, WareHouse.Text) = 0 And i > 1
                    i -= 1
                End While
                IDtxt.Text = i
            End If
        Else
            If IDtxt.Text = "" Or IDtxt.Text = Convert.ToString(EQUIPMENT2TableAdapter.ReturnMinPartID) Then
                If EQUIPMENT2TableAdapter.ReturnPartCount(EQUIPMENT2TableAdapter.ReturnMaxPartID - 1) <> 0 Then
                    IDtxt.Text = EQUIPMENT2TableAdapter.ReturnMaxPartID - 1
                Else
                    i = EQUIPMENT2TableAdapter.ReturnMaxPartID - 1
                    While EQUIPMENT2TableAdapter.ReturnPartCount(i) = 0 And i > 1
                        i -= 1
                    End While
                    IDtxt.Text = i
                End If
            Else
                i = IDtxt.Text - 1
                While EQUIPMENT2TableAdapter.ReturnPartCount(i) = 0 And i > 1
                    i -= 1
                End While
                IDtxt.Text = i
            End If
        End If
    End Sub

    Private Sub IDtxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IDtxt.TextChanged
        Dim PrevID As Integer
        If IDtxt.Text <> "" And NewRecord = False And ID.Checked = True Then
            If Local.Checked = True Then    'Local Inventory
                If (IDtxt.Text > EQUIPMENTTableAdapter.ReturnMaxPartID(WareHouse.Text) - 1) Or (EQUIPMENTTableAdapter.ReturnPartCount(IDtxt.Text, WareHouse.Text) = 0) Then
                    MsgBox("No record found for entered Part ID", MsgBoxStyle.Exclamation)
                    IDtxt.Text = ""
                    Desc.Text = ""
                    PartNum.Text = ""
                    SNtxt.Text = ""
                    Status.Text = ""
                    Manuf.Text = ""
                    ContCosttxt.Text = ""
                    NonContCosttxt.Text = ""
                    Quantity.Text = ""
                    PartWareHouse.Text = ""
                    YES.Checked = False
                    NO.Checked = False

                Else
                    Try
                        PrevID = IDtxt.Text
                        SelectedPart = Convert.ToString(EQUIPMENTTableAdapter.ReturnPartDesc(IDtxt.Text, WareHouse.Text))
                        PartDesc.SelectedValue = SelectedPart
                        SelectedSerial = Convert.ToString(EQUIPMENTTableAdapter.ReturnSerial(PrevID, WareHouse.Text))
                        Serial.SelectedValue = SelectedSerial
                        LoadData()
                    Catch
                    End Try
                End If
            Else    'City Owned Inventory
                If (IDtxt.Text > EQUIPMENT2TableAdapter.ReturnMaxPartID - 1) Or (EQUIPMENT2TableAdapter.ReturnPartCount(IDtxt.Text) = 0) Then
                    MsgBox("No record found for entered Part ID", MsgBoxStyle.Exclamation)
                    IDtxt.Text = ""
                    Desc.Text = ""
                    PartNum.Text = ""
                    Area.Text = ""
                    SNtxt.Text = ""
                    Status.Text = ""
                    Manuf.Text = ""
                    ContCosttxt.Text = ""
                    NonContCosttxt.Text = ""
                    PartWareHouse.Text = ""
                    YES.Checked = False
                    NO.Checked = False

                Else
                    Try
                        PrevID = IDtxt.Text
                        SelectedPart = Convert.ToString(EQUIPMENT2TableAdapter.ReturnPartDesc(IDtxt.Text))
                        PartDesc.SelectedValue = SelectedPart
                        SelectedSerial = Convert.ToString(EQUIPMENT2TableAdapter.ReturnSerial(PrevID))
                        Serial.SelectedValue = SelectedSerial
                        LoadData2()
                    Catch
                    End Try
                End If
            End If
        End If

        If IDtxt.Text = "" Then
            Desc.Text = ""
            PartNum.Text = ""
            Area.Text = ""
            SNtxt.Text = ""
            Status.Text = ""
            Manuf.Text = ""
            ContCosttxt.Text = ""
            NonContCosttxt.Text = ""
            Quantity.Text = ""
            PartWareHouse.Text = ""
            YES.Checked = False
            NO.Checked = False
        End If
    End Sub

    Private Sub IDtxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IDtxt.KeyPress
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
            IDtxt.Enabled = True
            bck.Enabled = True
            fwd.Enabled = True
            ManAll.Checked = True
            StatAll.Checked = True
            AreaAll.Checked = True
            PartFilter.Text = ""
            SerialFilter.Text = ""
        Else
            LoadPanel.Enabled = True
            IDtxt.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
        End If

        GetPart()
        GetSerial()
        If Local.Checked = True Then
            LoadData()
        Else
            LoadData2()
        End If
    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click
        Parts_ListTableAdapter.Fill(Me.SignalogDataSet.Parts_List)
        MANF_LISTTableAdapter.Fill(Me.SignalogDataSet.MANF_LIST)
        CUS0TableAdapter.Fill(Me.SignalogDataSet.CUS0)

        NewRecord = True
        NewButton.Enabled = False
        UndoButton.Enabled = True
        EditButton.Enabled = False
        DeleteButton.Enabled = False
        SrcPanel.Enabled = False
        LoadPanel.Enabled = False
        LoadBylbl.Visible = False
        LoadByPanel.Visible = False
        IDtxt.Enabled = False
        bck.Enabled = False
        fwd.Enabled = False
        Desc.Text = ""
        PartNum.Text = ""
        SNtxt.Text = ""
        NoneSN.Enabled = True
        NoneSN.Checked = False
        Status.Text = ""
        Manuf.Text = ""
        ContCosttxt.Text = ""
        NonContCosttxt.Text = ""
        Quantity.Text = 1
        PartWareHouse.Text = WareHouse.Text
        Submit.Enabled = True
        YES.Checked = False
        NO.Checked = False
        If Local.Checked = True Then    'Local Inventory
            If WareHouse.Text = "TUL" Then
                IDtxt.Text = LOCKNEWTableAdapter.ReturnLockValue("LOCInventoryTUL") + 1   'Assign PartID= highest LOCK value +1
                LOCKNEWTableAdapter.UpdateLockValue(IDtxt.Text, "LOCInventoryTUL")  'Update LOCK
            ElseIf WareHouse.Text = "OKC" Then
                IDtxt.Text = LOCKNEWTableAdapter.ReturnLockValue("LOCInventoryOKC") + 1   'Assign PartID= highest LOCK value +1
                LOCKNEWTableAdapter.UpdateLockValue(IDtxt.Text, "LOCInventoryOKC")  'Update LOCK
            ElseIf WareHouse.Text = "ARK" Then
                IDtxt.Text = LOCKNEWTableAdapter.ReturnLockValue("LOCInventoryARK") + 1   'Assign PartID= highest LOCK value +1
                LOCKNEWTableAdapter.UpdateLockValue(IDtxt.Text, "LOCInventoryARK")  'Update LOCK
            End If
        Else    'City Owned Inventory
            IDtxt.Text = LOCKNEWTableAdapter.ReturnLockValue("COInventory") + 1   'Assign PartID= highest LOCK value +1
            LOCKNEWTableAdapter.UpdateLockValue(IDtxt.Text, "COInventory")  'Update LOCK
        End If
        Desc.Enabled = True
        Area.Enabled = True
        SNtxt.Enabled = True
        Status.Enabled = True
        Manuf.Enabled = True
        ContCosttxt.Enabled = True
        NonContCosttxt.Enabled = True
        YES.Enabled = True
        NO.Enabled = True
    End Sub

    Private Sub UndoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoButton.Click
        If EditRecord = True Then   'Release edit lock
            If Local.Checked = True Then    'Local Inventory
                If WareHouse.Text = "TUL" Then
                    LOCKEDITTableAdapter.DeleteAtDescValue("LOCInventoryTUL", IDtxt.Text)
                ElseIf WareHouse.Text = "OKC" Then
                    LOCKEDITTableAdapter.DeleteAtDescValue("LOCInventoryOKC", IDtxt.Text)
                ElseIf WareHouse.Text = "ARK" Then
                    LOCKEDITTableAdapter.DeleteAtDescValue("LOCInventoryARK", IDtxt.Text)
                End If
            Else    'City Owned Inventory
                LOCKEDITTableAdapter.DeleteAtDescValue("COInventory", IDtxt.Text)
            End If
            MANF_LISTTableAdapter.Fill2(Me.SignalogDataSet.MANF_LIST)
            CUS0TableAdapter.Fill2(Me.SignalogDataSet.CUS0)
        End If

        If NewRecord = True Then
            Parts_ListTableAdapter.Fill(Me.SignalogDataSet.Parts_List)
            MANF_LISTTableAdapter.Fill2(Me.SignalogDataSet.MANF_LIST)
            CUS0TableAdapter.Fill2(Me.SignalogDataSet.CUS0)
        End If

        If Filters.Checked = True Then
            IDtxt.Enabled = False
            LoadPanel.Enabled = True
            bck.Enabled = False
            fwd.Enabled = False
        Else
            IDtxt.Enabled = True
            LoadPanel.Enabled = False
            bck.Enabled = True
            fwd.Enabled = True
        End If

        EditRecord = False
        NewRecord = False
        NewButton.Enabled = True
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        UndoButton.Enabled = False
        LoadBylbl.Visible = True
        LoadPanel.Enabled = True
        LoadByPanel.Visible = True
        SrcPanel.Enabled = True
        Desc.Enabled = False
        Area.Enabled = False
        SNtxt.Enabled = False
        NoneSN.Enabled = False
        Status.Enabled = False
        Manuf.Enabled = False
        ContCosttxt.Enabled = False
        NonContCosttxt.Enabled = False
        Quantity.Enabled = False
        PartWareHouse.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        Submit.Enabled = False

        If Parts.NewPart = True Then
            Parts.NewPart = False
        End If

        GetPart()
        GetSerial()
        If Local.Checked = True Then
            IDtxt.Text = EQUIPMENTTableAdapter.ReturnPartID(SelectedPart, SelectedSerial, WareHouse.Text)
            LoadData()
        Else
            IDtxt.Text = EQUIPMENT2TableAdapter.ReturnPartID(SelectedPart, SelectedSerial)
            LoadData2()
        End If
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Dim previousId As Integer
        previousId = IDtxt.Text
        flag = False
        If NewRecord = True Then
            If Local.Checked = True Then    'Local
                If EQUIPMENTTableAdapter.ReturnDescSerialCOUNTnew(Desc.SelectedValue, SNtxt.Text, WareHouse.Text) <> 0 Then
                    If MsgBox("Part already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new part entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        UndoButton.PerformClick()
                        GoTo ExitNewPart
                    Else
                        SNtxt.Text = ""
                        SNtxt.Focus()
                    End If
                    flag = True   'Don't submit
                Else
                    flag = False
                    GoTo NewPart
                End If
            Else    'City Owned
                If EQUIPMENT2TableAdapter.ReturnDescSerialCOUNTnew(Desc.SelectedValue, SNtxt.Text) <> 0 Then
                    If MsgBox("Part already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new part entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        UndoButton.PerformClick()
                        GoTo ExitNewPart
                    Else
                        SNtxt.Text = ""
                        SNtxt.Focus()
                    End If
                    flag = True   'Don't submit
                Else
                    flag = False
                    GoTo NewPart
                End If
            End If

NewPart:
            If flag = False Then
                If Desc.Text = String.Empty Or Desc.Text = "NEW" Then  'Or Desc.Text = "NEW", if part_list_maint closed without adding a new part
                    MsgBox("Please select part description", MsgBoxStyle.Exclamation, "Missing Field")
                    Desc.DroppedDown = True
                    flag = True
                ElseIf SNtxt.Text = String.Empty Then
                    MsgBox("Please enter serial number", MsgBoxStyle.Exclamation, "Missing Field")
                    SNtxt.Focus()
                    flag = True
                ElseIf Status.Text = String.Empty Or Status.Text = "NEW" Then
                    MsgBox("Please select status", MsgBoxStyle.Exclamation, "Missing Field")
                    Status.DroppedDown = True
                    flag = True
                ElseIf Manuf.Text = String.Empty Or Manuf.Text = "NEW" Then
                    MsgBox("Please select manufacturer", MsgBoxStyle.Exclamation, "Missing Field")
                    Manuf.DroppedDown = True
                    flag = True
                ElseIf YES.Checked = False And NO.Checked = False Then
                    MsgBox("Please select YES or NO for the Show field", MsgBoxStyle.Exclamation, "Missing Field")
                    flag = True
                Else
                    If Local.Checked = True Then
                        If NonContCosttxt.Text = String.Empty Then
                            MsgBox("Please enter Non-Contract Unit Cost", MsgBoxStyle.Exclamation, "Missing Field")
                            NonContCosttxt.Focus()
                            flag = True
                            GoTo ExitNewPart
                        End If
                        If ContCosttxt.Text = String.Empty Then
                            MsgBox("Please enter Contract Unit Cost", MsgBoxStyle.Exclamation, "Missing Field")
                            ContCosttxt.Focus()
                            flag = True
                            GoTo ExitNewPart
                        End If
                    End If
                    If YES.Checked = True Then
                        sh = "Y"
                    Else
                        sh = "N"
                    End If
                    If Local.Checked = True Then    'Local Inventory
                        If WareHouse.Text = "TUL" Then
                            EQUIPMENTTableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("LOCInventoryTUL") + 1, EQUIPMENTTableAdapter.ReturnPartID("NEW", "NEW", "TUL"), WareHouse.Text) 'Increment NEW ID
                        ElseIf WareHouse.Text = "OKC" Then
                            EQUIPMENTTableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("LOCInventoryOKC") + 1, EQUIPMENTTableAdapter.ReturnPartID("NEW", "NEW", "OKC"), WareHouse.Text) 'Increment NEW ID
                        ElseIf WareHouse.Text = "ARK" Then
                            EQUIPMENTTableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("LOCInventoryARK") + 1, EQUIPMENTTableAdapter.ReturnPartID("NEW", "NEW", "ARK"), WareHouse.Text) 'Increment NEW ID
                        End If
                        EQUIPMENTTableAdapter.Insert(IDtxt.Text, Desc.SelectedValue, SNtxt.Text, Parts_Status_TypeTableAdapter.ReturnOrderNum(Status.SelectedValue) _
                                                     , Quantity.Text, Manuf.SelectedValue, Convert.ToDouble(ContCosttxt.Text), Convert.ToDouble(NonContCosttxt.Text), PartWareHouse.Text, sh)

                    Else    'City Owned Inventory
                        EQUIPMENT2TableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("COInventory") + 1, EQUIPMENT2TableAdapter.ReturnPartID("NEW", "NEW")) 'Increment NEW ID
                        EQUIPMENT2TableAdapter.Insert(IDtxt.Text, Desc.SelectedValue, SNtxt.Text, Parts_Status_TypeTableAdapter.ReturnOrderNum(Status.SelectedValue) _
                                                      , CUS0TableAdapter.ReturnAREANUM(Area.SelectedValue), Manuf.SelectedValue, sh)
                    End If
                    NewRecord = False
                End If
            End If
        End If

ExitNewPart:
        If EditRecord = True Then
            If Local.Checked = True Then    'Local
                If EQUIPMENTTableAdapter.ReturnDescSerialCOUNTedit(Desc.SelectedValue, SNtxt.Text, IDtxt.Text, WareHouse.Text) <> 0 Then
                    If MsgBox("Part already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new part entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        UndoButton.PerformClick()
                        GoTo ExitEditPart
                    Else
                        SNtxt.Text = ""
                        SNtxt.Focus()
                    End If
                    flag = True   'Don't submit
                Else
                    flag = False
                    GoTo EditPart
                End If
            Else    'City Owned
                If EQUIPMENT2TableAdapter.ReturnDescSerialCOUNTedit(Desc.SelectedValue, SNtxt.Text, IDtxt.Text) <> 0 Then
                    If MsgBox("Part already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new part entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        UndoButton.PerformClick()
                        GoTo ExitEditPart
                    Else
                        SNtxt.Text = ""
                        SNtxt.Focus()
                    End If
                    flag = True   'Don't submit
                Else
                    flag = False
                    GoTo EditPart
                End If
            End If

EditPart:   If flag = False Then
                If Desc.Text = String.Empty Or Desc.Text = "NEW" Then  'Or Desc.Text = "NEW", if part_list_maint closed without adding a new part
                    MsgBox("Please select part description", MsgBoxStyle.Exclamation, "Missing Field")
                    Desc.DroppedDown = True
                    flag = True
                ElseIf SNtxt.Text = String.Empty Then
                    MsgBox("Please enter serial number", MsgBoxStyle.Exclamation, "Missing Field")
                    SNtxt.Focus()
                    flag = True
                ElseIf Status.Text = String.Empty Or Status.Text = "NEW" Then
                    MsgBox("Please select status", MsgBoxStyle.Exclamation, "Missing Field")
                    Status.DroppedDown = True
                    flag = True
                ElseIf Manuf.Text = String.Empty Or Manuf.Text = "NEW" Then
                    MsgBox("Please select manufacturer", MsgBoxStyle.Exclamation, "Missing Field")
                    Manuf.DroppedDown = True
                    flag = True
                ElseIf Local.Checked = True And PartWareHouse.Text = String.Empty Then
                    MsgBox("Please select warehouse", MsgBoxStyle.Exclamation, "Missing Field")
                    PartWareHouse.DroppedDown = True
                    flag = True
                Else
                    If Local.Checked = True Then
                        If NonContCosttxt.Text = String.Empty Then
                            MsgBox("Please enter Non-Contract Unit Cost", MsgBoxStyle.Exclamation, "Missing Field")
                            NonContCosttxt.Focus()
                            flag = True
                            GoTo ExitEditPart
                        End If
                        If ContCosttxt.Text = String.Empty Then
                            MsgBox("Please enter Contract Unit Cost", MsgBoxStyle.Exclamation, "Missing Field")
                            ContCosttxt.Focus()
                            flag = True
                            GoTo ExitEditPart
                        End If
                    End If
                    If YES.Checked = True Then
                        sh = "Y"
                    Else
                        sh = "N"
                    End If
                    If Local.Checked = True Then    'Local Inventory
                        If WareHouse.Text = "TUL" Then
                            LOCKEDITTableAdapter.DeleteAtDescValue("LOCInventoryTUL", IDtxt.Text)   'Release Edit LOCK
                        ElseIf WareHouse.Text = "OKC" Then
                            LOCKEDITTableAdapter.DeleteAtDescValue("LOCInventoryOKC", IDtxt.Text)   'Release Edit LOCK
                        ElseIf WareHouse.Text = "ARK" Then
                            LOCKEDITTableAdapter.DeleteAtDescValue("LOCInventoryARK", IDtxt.Text)   'Release Edit LOCK
                        End If

                        If PartWareHouse.Text = WareHouse.Text Then    'Part still in same warehouse
                            EQUIPMENTTableAdapter.UpdateAtPartID(Desc.SelectedValue, SNtxt.Text, Parts_Status_TypeTableAdapter.ReturnOrderNum(Status.SelectedValue) _
                                                                 , Manuf.SelectedValue, Quantity.Text, Convert.ToDouble(ContCosttxt.Text), Convert.ToDouble(NonContCosttxt.Text), sh, IDtxt.Text, WareHouse.Text)
                        Else    'Moving part to another warehouse
                            If ACT3TableAdapter.ReturnLocalPartIDCOUNT(IDtxt.Text, WareHouse.Text) <> 0 Then
                                MsgBox("Can't move part from one warehouse to another, item is associated with a trouble report", MsgBoxStyle.Exclamation, "Move Forbidden")
                                flag = True
                                GoTo ExitEditPart
                            Else
                                'Delete from current warehouse
                                EQUIPMENTTableAdapter.DeleteAtPartID(IDtxt.Text, WareHouse.Text)
                                'Add to new warehouse
                                If PartWareHouse.Text = "TUL" Then
                                    IDtxt.Text = LOCKNEWTableAdapter.ReturnLockValue("LOCInventoryTUL") + 1   'Assign PartID= highest LOCK value +1
                                    LOCKNEWTableAdapter.UpdateLockValue(IDtxt.Text, "LOCInventoryTUL")  'Update LOCK
                                    EQUIPMENTTableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("LOCInventoryTUL") + 1, EQUIPMENTTableAdapter.ReturnPartID("NEW", "NEW", "TUL"), PartWareHouse.Text) 'Increment NEW ID
                                ElseIf PartWareHouse.Text = "OKC" Then
                                    IDtxt.Text = LOCKNEWTableAdapter.ReturnLockValue("LOCInventoryOKC") + 1   'Assign PartID= highest LOCK value +1
                                    LOCKNEWTableAdapter.UpdateLockValue(IDtxt.Text, "LOCInventoryOKC")  'Update LOCK
                                    EQUIPMENTTableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("LOCInventoryOKC") + 1, EQUIPMENTTableAdapter.ReturnPartID("NEW", "NEW", "OKC"), PartWareHouse.Text) 'Increment NEW ID
                                ElseIf PartWareHouse.Text = "ARK" Then
                                    IDtxt.Text = LOCKNEWTableAdapter.ReturnLockValue("LOCInventoryARK") + 1   'Assign PartID= highest LOCK value +1
                                    LOCKNEWTableAdapter.UpdateLockValue(IDtxt.Text, "LOCInventoryARK")  'Update LOCK
                                    EQUIPMENTTableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("LOCInventoryARK") + 1, EQUIPMENTTableAdapter.ReturnPartID("NEW", "NEW", "ARK"), PartWareHouse.Text) 'Increment NEW ID
                                End If
                                EQUIPMENTTableAdapter.Insert(IDtxt.Text, Desc.SelectedValue, SNtxt.Text, Parts_Status_TypeTableAdapter.ReturnOrderNum(Status.SelectedValue) _
                                                         , Quantity.Text, Manuf.SelectedValue, Convert.ToDouble(ContCosttxt.Text), Convert.ToDouble(NonContCosttxt.Text), PartWareHouse.Text, sh)
                            End If
                        End If

                    Else    'City Owned Inventory
                            LOCKEDITTableAdapter.DeleteAtDescValue("COInventory", IDtxt.Text)   'Release Edit LOCK
                            EQUIPMENT2TableAdapter.UpdateAtPartID(Desc.SelectedValue, SNtxt.Text, Parts_Status_TypeTableAdapter.ReturnOrderNum(Status.SelectedValue) _
                                                                  , CUS0TableAdapter.ReturnAREANUM(Area.SelectedValue), Manuf.SelectedValue, sh, IDtxt.Text)
                    End If
                    EditRecord = False
                End If
            End If
        End If

ExitEditPart:
        If flag = False Then
            Parts_ListTableAdapter.Fill(Me.SignalogDataSet.Parts_List)
            MANF_LISTTableAdapter.Fill2(Me.SignalogDataSet.MANF_LIST)
            CUS0TableAdapter.Fill2(Me.SignalogDataSet.CUS0)

            NewButton.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = True
            UndoButton.Enabled = False
            LoadBylbl.Visible = True
            LoadPanel.Enabled = True
            LoadByPanel.Visible = True
            SrcPanel.Enabled = True
            Filters.Checked = True
            Desc.Enabled = False
            Area.Enabled = False
            SNtxt.Enabled = False
            NoneSN.Enabled = False
            Status.Enabled = False
            Manuf.Enabled = False
            ContCosttxt.Enabled = False
            NonContCosttxt.Enabled = False
            Quantity.Enabled = False
            PartWareHouse.Enabled = False
            YES.Enabled = False
            NO.Enabled = False
            Submit.Enabled = False

            NewRecord = False
            EditRecord = False

            If Local.Checked = True Then
                SelectedPart = Convert.ToString(EQUIPMENTTableAdapter.ReturnPartDesc(previousId, WareHouse.Text))
                PartDesc.SelectedValue = SelectedPart
                SelectedSerial = Convert.ToString(EQUIPMENTTableAdapter.ReturnSerial(previousId, WareHouse.Text))
                Serial.SelectedValue = SelectedSerial
                LoadData()
            Else
                SelectedPart = Convert.ToString(EQUIPMENT2TableAdapter.ReturnPartDesc(previousId))
                PartDesc.SelectedValue = SelectedPart
                SelectedSerial = Convert.ToString(EQUIPMENT2TableAdapter.ReturnSerial(previousId))
                Serial.SelectedValue = SelectedSerial
                LoadData2()
            End If
        End If

        If Parts.NewPart = True And flag = False Then
            Me.Close()
            Parts.Text = Parts.Text & "n"
        End If

    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If SelectedPart = "Miscellaneous" Then
            MsgBox("Delete forbidden, you can't delete Miscellaneous part", MsgBoxStyle.Exclamation, "Delete Forbidden")
            GoTo ExitDelete
        End If
        If Local.Checked = True Then    'Local Inventory
            If ACT3TableAdapter.ReturnLocalPartIDCOUNT(IDtxt.Text, WareHouse.Text) <> 0 Then
                MsgBox("Delete forbidden, item is associated with one or more trouble reports", MsgBoxStyle.Exclamation, "Delete Forbidden")
                GoTo ExitDelete
            Else
                GoTo Delete
            End If
        Else    'City Owned Inventory
            If ACT3TableAdapter.ReturnCityOwnedPartIDCOUNT(IDtxt.Text) <> 0 Then
                MsgBox("Delete forbidden, item is associated with one or more trouble reports", MsgBoxStyle.Exclamation, "Delete Forbidden")
                GoTo ExitDelete
            Else
                GoTo Delete
            End If
        End If
Delete:
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to delete the selected part?", MsgBoxStyle.YesNo, "Delete Part?")
        If result = MsgBoxResult.Yes Then
            If Local.Checked = True Then     'Local Inventory
                EQUIPMENTTableAdapter.DeleteAtPartID(IDtxt.Text, WareHouse.Text)
            Else    'City Owned Inventory
                EQUIPMENT2TableAdapter.DeleteAtPartID(IDtxt.Text)
            End If
            Parts_ListTableAdapter.Fill(Me.SignalogDataSet.Parts_List)
            MANF_LISTTableAdapter.Fill(Me.SignalogDataSet.MANF_LIST)
            CUS0TableAdapter.Fill(Me.SignalogDataSet.CUS0)
            load4()
        End If
ExitDelete:
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        If Local.Checked = True Then    'Local Inventory
            If WareHouse.Text = "TUL" Then
                If LOCKEDITTableAdapter.ReturnDescValueCOUNT("LOCInventoryTUL", IDtxt.Text) <> 0 Then   'If locked for editing
                    MsgBox("This part is being edited by another user, please try editing later", MsgBoxStyle.Information)
                    GoTo EXITEDIT
                Else
                    LOCKEDITTableAdapter.Insert("LOCInventoryTUL", IDtxt.Text)  'Lock for editing
                    GoTo EDIT
                End If
            ElseIf WareHouse.Text = "OKC" Then
                If LOCKEDITTableAdapter.ReturnDescValueCOUNT("LOCInventoryOKC", IDtxt.Text) <> 0 Then   'If locked for editing
                    MsgBox("This part is being edited by another user, please try editing later", MsgBoxStyle.Information)
                    GoTo EXITEDIT
                Else
                    LOCKEDITTableAdapter.Insert("LOCInventoryOKC", IDtxt.Text)  'Lock for editing
                    GoTo EDIT
                End If
            ElseIf WareHouse.Text = "ARK" Then
                If LOCKEDITTableAdapter.ReturnDescValueCOUNT("LOCInventoryARK", IDtxt.Text) <> 0 Then   'If locked for editing
                    MsgBox("This part is being edited by another user, please try editing later", MsgBoxStyle.Information)
                    GoTo EXITEDIT
                Else
                    LOCKEDITTableAdapter.Insert("LOCInventoryARK", IDtxt.Text)  'Lock for editing
                    GoTo EDIT
                End If
            End If
        Else    'City Owned Inventory
            If LOCKEDITTableAdapter.ReturnDescValueCOUNT("COInventory", IDtxt.Text) <> 0 Then   'If locked for editing
                MsgBox("This part is being edited by another user, please try editing later", MsgBoxStyle.Information)
                GoTo EXITEDIT
            Else
                LOCKEDITTableAdapter.Insert("COInventory", IDtxt.Text)  'Lock for editing
                GoTo EDIT
            End If
        End If

EDIT:
        Dim selp, sels As String
        selp = SelectedPart
        sels = SelectedSerial
        Parts_ListTableAdapter.Fill(Me.SignalogDataSet.Parts_List)
        MANF_LISTTableAdapter.Fill(Me.SignalogDataSet.MANF_LIST)
        CUS0TableAdapter.Fill(Me.SignalogDataSet.CUS0)
        SelectedPart = selp
        PartDesc.SelectedValue = SelectedPart
        SelectedSerial = sels
        Serial.SelectedValue = SelectedSerial

        EditButton.Enabled = False
        EditRecord = True
        NewButton.Enabled = False
        DeleteButton.Enabled = False
        UndoButton.Enabled = True

        IDtxt.Enabled = False
        bck.Enabled = False
        fwd.Enabled = False
        LoadByPanel.Visible = False
        LoadPanel.Enabled = False
        LoadBylbl.Visible = False
        Desc.Enabled = True
        Area.Enabled = True
        SNtxt.Enabled = True
        NoneSN.Enabled = True
        Manuf.Enabled = True
        ContCosttxt.Enabled = True
        NonContCosttxt.Enabled = True
        Quantity.Enabled = True
        PartWareHouse.Enabled = True
        YES.Enabled = True
        NO.Enabled = True
        Submit.Enabled = True
        SrcPanel.Enabled = False

        If NoneSN.Checked = True Then
            SNtxt.ReadOnly = True
            Status.Enabled = False
            PartWareHouse.Enabled = False 'Can't move non-unique items betwwen warehouses from here (use stock control form to do that)
        Else
            SNtxt.ReadOnly = False
            Status.Enabled = True
        End If

EXITEDIT:
    End Sub

    Private Sub Local_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Local.CheckedChanged
        Dim Xindent, Yindent1, Yindent2 As Integer
        Xindent = Desc.Location.X - (Desclbl.Location.X + Desclbl.Size.Width)

        Yindent1 = IDlbl.Location.Y - LoadBylbl.Location.Y    'Between lables
        Yindent2 = Desclbl.Location.Y - Desc.Location.Y       'Between lablel and its corresponding textboxes

        If CityOwned.Checked = True Then    'City Owned Inventory
            WareHouselbl.Visible = False
            WareHouse.Visible = False
            PartWareHouselbl.Visible = False
            PartWareHouse.Visible = False

            Arealbl.Visible = True
            Area.Visible = True
            Area.Enabled = False


            Label16.Visible = True
            AreaFilter.Visible = True
            AreaAll.Visible = True
            AreaAll.Checked = True
            AreaFilter.Enabled = False

            Arealbl.Location = New Point(LoadBylbl.Location.X, IDlbl.Location.Y + Yindent1)
            Area.Location = New Point(IDtxt.Location.X, Arealbl.Location.Y - Yindent2)
            Desclbl.Location = New Point(LoadBylbl.Location.X, Arealbl.Location.Y + Yindent1)
            Desc.Location = New Point(IDtxt.Location.X, Desclbl.Location.Y - Yindent2)
            PartNumlbl.Location = New Point(LoadBylbl.Location.X, Desclbl.Location.Y + Yindent1)
            PartNum.Location = New Point(IDtxt.Location.X, PartNumlbl.Location.Y - Yindent2)
            SNlbl.Location = New Point(LoadBylbl.Location.X, PartNumlbl.Location.Y + Yindent1)
            SNtxt.Location = New Point(IDtxt.Location.X, SNlbl.Location.Y - Yindent2)
            NoneSN.Location = New Point(IDtxt.Location.X + SNtxt.Size.Width + Xindent, SNlbl.Location.Y - Yindent2)
            Statuslbl.Location = New Point(LoadBylbl.Location.X, SNlbl.Location.Y + Yindent1)
            Status.Location = New Point(IDtxt.Location.X, Statuslbl.Location.Y - Yindent2)
            Manuflbl.Location = New Point(LoadBylbl.Location.X, Statuslbl.Location.Y + Yindent1)
            Manuf.Location = New Point(IDtxt.Location.X, Manuflbl.Location.Y - Yindent2)
            Showlbl.Location = New Point(LoadBylbl.Location.X, Manuflbl.Location.Y + Yindent1)
            YES.Location = New Point(IDtxt.Location.X, Showlbl.Location.Y - Yindent2)
            NO.Location = New Point(YES.Location.X + YES.Size.Width + Xindent, Showlbl.Location.Y - Yindent2)
            Submit.Location = New Point(Submit.Location.X, Showlbl.Location.Y + Yindent1)

            Quantlbl.Visible = False  'No qauntity for City Owned Inventory
            Quantity.Visible = False

            Conlbl.Visible = False  'No Contract cost for City Owned Inventory
            ContCosttxt.Visible = False

            Nonconlbl.Visible = False  'No Non-Contract cost for City Owned Inventory
            NonContCosttxt.Visible = False

            PartDesc.DataSource = Part2BindingSource
            Serial.DataSource = Serial2BindingSource
        Else    'Local Inventory
            WareHouselbl.Visible = True
            WareHouse.Visible = True
            PartWareHouselbl.Visible = True
            PartWareHouse.Visible = True

            Arealbl.Visible = False
            Area.Visible = False
            Label16.Visible = False
            AreaFilter.Visible = False
            AreaAll.Visible = False
            Quantlbl.Visible = True
            Quantity.Visible = True
            Conlbl.Visible = True
            ContCosttxt.Visible = True
            Nonconlbl.Visible = True
            NonContCosttxt.Visible = True

            Desclbl.Location = New Point(LoadBylbl.Location.X, IDlbl.Location.Y + Yindent1)
            Desc.Location = New Point(IDtxt.Location.X, Desclbl.Location.Y - Yindent2)
            PartNumlbl.Location = New Point(LoadBylbl.Location.X, Desclbl.Location.Y + Yindent1)
            PartNum.Location = New Point(IDtxt.Location.X, PartNumlbl.Location.Y - Yindent2)
            SNlbl.Location = New Point(LoadBylbl.Location.X, PartNumlbl.Location.Y + Yindent1)
            SNtxt.Location = New Point(IDtxt.Location.X, SNlbl.Location.Y - Yindent2)
            NoneSN.Location = New Point(IDtxt.Location.X + SNtxt.Size.Width + Xindent, SNlbl.Location.Y - Yindent2)
            Statuslbl.Location = New Point(LoadBylbl.Location.X, SNlbl.Location.Y + Yindent1)
            Status.Location = New Point(IDtxt.Location.X, Statuslbl.Location.Y - Yindent2)
            Manuflbl.Location = New Point(LoadBylbl.Location.X, Statuslbl.Location.Y + Yindent1)
            Manuf.Location = New Point(IDtxt.Location.X, Manuflbl.Location.Y - Yindent2)
            Conlbl.Location = New Point(LoadBylbl.Location.X, Manuflbl.Location.Y + Yindent1)
            ContCosttxt.Location = New Point(LoadBylbl.Location.X + Nonconlbl.Size.Width + Xindent, Conlbl.Location.Y - Yindent2)
            Nonconlbl.Location = New Point(LoadBylbl.Location.X, Conlbl.Location.Y + Yindent1)
            NonContCosttxt.Location = New Point(LoadBylbl.Location.X + Nonconlbl.Size.Width + Xindent, Nonconlbl.Location.Y - Yindent2)
            Quantlbl.Location = New Point(LoadBylbl.Location.X, Nonconlbl.Location.Y + Yindent1)
            Quantity.Location = New Point(IDtxt.Location.X, Quantlbl.Location.Y - Yindent2)
            PartWareHouselbl.Location = New Point(LoadBylbl.Location.X, Quantlbl.Location.Y + Yindent1)
            PartWareHouse.Location = New Point(IDtxt.Location.X, PartWareHouselbl.Location.Y - Yindent2)
            Showlbl.Location = New Point(LoadBylbl.Location.X, PartWareHouselbl.Location.Y + Yindent1)
            YES.Location = New Point(IDtxt.Location.X, Showlbl.Location.Y - Yindent2)
            NO.Location = New Point(YES.Location.X + YES.Size.Width + Xindent, Showlbl.Location.Y - Yindent2)
            Submit.Location = New Point(Submit.Location.X, Showlbl.Location.Y + Yindent1)

            PartDesc.DataSource = PartBindingSource
            Serial.DataSource = SerialBindingSource
        End If
        'Reloading
        PFilter = PartFilter.Text & "%"
        load4()

    End Sub

    Sub GetSerial()
        If Local.Checked = True Then
            If Me.SignalogDataSet.Serial.Rows.Count <> 0 Then
                SelectedSerial = Serial.SelectedValue
            Else
                SelectedSerial = ""
            End If
        Else
            If Me.SignalogDataSet.Serial2.Rows.Count <> 0 Then
                SelectedSerial = Serial.SelectedValue
            Else
                SelectedSerial = ""
            End If
        End If
    End Sub

    Sub GetPart()
        If Local.Checked = True Then
            If Me.SignalogDataSet.Part.Rows.Count <> 0 Then
                SelectedPart = PartDesc.SelectedValue
            Else
                SelectedPart = ""
            End If
        Else
            If Me.SignalogDataSet.Part2.Rows.Count <> 0 Then
                SelectedPart = PartDesc.SelectedValue
            Else
                SelectedPart = ""
            End If
        End If
    End Sub

    Sub SFilter()   'Filter serials for local inventory
        Dim sf As String
        sn = SerialFilter.Text
        c = sn.Length

        If c = 0 Then    'Building serial filter 
            sf = "%"
        ElseIf c = 1 Then
            sf = "%" & sn & "__"
        ElseIf c = 2 Then
            sf = "%" & sn & "_"
        Else
            sf = "%" & sn
        End If

        cmd = "SELECT Serial FROM EQUIPMENT "
        cmd += "WHERE PartDesc='" & SelectedPart & "' "
        cmd += "AND Serial LIKE '" & sf & "' "
        cmd += "AND PartDesc<>'NEW' "
        cmd += "AND WareHouse='" & WareHouse.Text & "' "

        If ManAll.Checked = False Then
            cmd += "AND Manufacturer ='" & SelectedManuf & "' "
        End If

        If StatAll.Checked = False Then
            cmd += "AND Status ='" & SelectedStatus & "' "
        End If

        cmd += "ORDER BY Serial"
        Dim myDataAdapter As New SqlDataAdapter(cmd, con)
        SignalogDataSet.Serial.Clear()
        myDataAdapter.Fill(SignalogDataSet.Serial)
        GetSerial()
    End Sub

    Sub SFilter2()    'Filter serials for city owned inventory
        Dim sf As String
        sn = SerialFilter.Text
        c = sn.Length

        If c = 0 Then    'Building serial filter 
            sf = "%"
        ElseIf c = 1 Then
            sf = "%" & sn & "__"
        ElseIf c = 2 Then
            sf = "%" & sn & "_"
        Else
            sf = "%" & sn
        End If

        cmd = "SELECT Serial FROM EQUIPMENT2 "
        cmd += "WHERE PartDesc='" & SelectedPart & "' "
        cmd += "AND Serial LIKE '" & sf & "' "
        cmd += "AND PartDesc<>'NEW' "

        If ManAll.Checked = False Then
            cmd += "AND Manufacturer ='" & SelectedManuf & "' "
        End If

        If StatAll.Checked = False Then
            cmd += "AND Status ='" & SelectedStatus & "' "
        End If

        If AreaAll.Checked = False Then
            cmd += "AND AREANUM ='" & SelectedArea & "' "
        End If

        cmd += "ORDER BY Serial"

        Dim myDataAdapter As New SqlDataAdapter(cmd, con)
        SignalogDataSet.Serial2.Clear()
        myDataAdapter.Fill(SignalogDataSet.Serial2)
        GetSerial()
    End Sub

    Sub LoadData()   'Local Inventory
        Try
            Desc.Text = SelectedPart
            PartNum.Text = Parts_ListTableAdapter.ReturnPartNumAtDesc(SelectedPart)
            SNtxt.Text = SelectedSerial
            If SNtxt.Text = "None" Then
                NoneSN.Checked = True
            Else
                NoneSN.Checked = False
            End If
            Status.Text = Parts_Status_TypeTableAdapter.ReturnStatusType(EQUIPMENTTableAdapter.ReturnStatus(SelectedPart, SelectedSerial, WareHouse.Text))
            Manuf.Text = EQUIPMENTTableAdapter.ReturnManuf(SelectedPart, SelectedSerial, WareHouse.Text)
            ContCosttxt.Text = Convert.ToString(EQUIPMENTTableAdapter.ReturnContractCost(SelectedPart, SelectedSerial, WareHouse.Text))
            NonContCosttxt.Text = Convert.ToString(EQUIPMENTTableAdapter.ReturnNonContractCost(SelectedPart, SelectedSerial, WareHouse.Text))
            Quantity.Text = Convert.ToString(EQUIPMENTTableAdapter.ReturnQuantity(SelectedPart, SelectedSerial, WareHouse.Text))
            PartWareHouse.Text = WareHouse.Text
            sh = EQUIPMENTTableAdapter.ReturnShow(SelectedPart, SelectedSerial, WareHouse.Text)
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

    Sub LoadData2()   'City Owned Inventory
        Try
            Desc.Text = SelectedPart
            PartNum.Text = Parts_ListTableAdapter.ReturnPartNumAtDesc(SelectedPart)
            SNtxt.Text = SelectedSerial
            If SNtxt.Text = "None" Then
                NoneSN.Checked = True
            Else
                NoneSN.Checked = False
            End If
            Area.Text = CUS0TableAdapter.ReturnAreaName(EQUIPMENT2TableAdapter.ReturnAREANUM(SelectedPart, SelectedSerial))
            Status.Text = Parts_Status_TypeTableAdapter.ReturnStatusType(EQUIPMENT2TableAdapter.ReturnStatus(SelectedPart, SelectedSerial))
            Manuf.Text = EQUIPMENT2TableAdapter.ReturnManuf(SelectedPart, SelectedSerial)
            sh = EQUIPMENT2TableAdapter.ReturnShow(SelectedPart, SelectedSerial)
            If sh = "Y" Then
                YES.Checked = True
                NO.Checked = False
            Else
                NO.Checked = True
                YES.Checked = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub load4()
        Try
            If Local.Checked = True Then    'Local Inventory
                'Replace by PFilter()  and remove unnecessary SQL commands from dataset
                If StatAll.Checked = False And ManAll.Checked = True Then
                    PartTableAdapter.FillByFilterStatus(Me.SignalogDataSet.Part, PFilter, SelectedStatus, WareHouse.Text)
                ElseIf StatAll.Checked = True And ManAll.Checked = False Then
                    PartTableAdapter.FillByFilterManuf(Me.SignalogDataSet.Part, PFilter, SelectedManuf, WareHouse.Text)
                ElseIf StatAll.Checked = False And ManAll.Checked = False Then
                    PartTableAdapter.FillByFilterStatusManuf(Me.SignalogDataSet.Part, PFilter, SelectedStatus, SelectedManuf, WareHouse.Text)
                ElseIf StatAll.Checked = True And ManAll.Checked = True Then
                    PartTableAdapter.FillByFilter(Me.SignalogDataSet.Part, PFilter, WareHouse.Text)
                End If

                GetPart()

                SFilter()

                IDtxt.Text = Convert.ToString(EQUIPMENTTableAdapter.ReturnPartID(SelectedPart, SelectedSerial, WareHouse.Text))
                LoadData()
            Else    'City Owned Inventory
                'Replace by PFilter2()  and remove unnecessary SQL commands from dataset
                If StatAll.Checked = False And ManAll.Checked = True And AreaAll.Checked = True Then
                    Part2TableAdapter.FillByFilterStatus(Me.SignalogDataSet.Part2, PFilter, SelectedStatus)
                ElseIf StatAll.Checked = True And ManAll.Checked = False And AreaAll.Checked = True Then
                    Part2TableAdapter.FillByFilterManuf(Me.SignalogDataSet.Part2, PFilter, SelectedManuf)
                ElseIf StatAll.Checked = False And ManAll.Checked = False And AreaAll.Checked = True Then
                    Part2TableAdapter.FillByFilterStatusManuf(Me.SignalogDataSet.Part2, PFilter, SelectedStatus, SelectedManuf)
                ElseIf StatAll.Checked = True And ManAll.Checked = True And AreaAll.Checked = True Then
                    Part2TableAdapter.FillByFilter(Me.SignalogDataSet.Part2, PFilter)
                ElseIf AreaAll.Checked = False And StatAll.Checked = True And ManAll.Checked = True Then
                    Part2TableAdapter.FillByFilterArea(Me.SignalogDataSet.Part2, PFilter, SelectedArea)
                ElseIf AreaAll.Checked = False And StatAll.Checked = False And ManAll.Checked = True Then
                    Part2TableAdapter.FillByFilterStatArea(Me.SignalogDataSet.Part2, PFilter, SelectedStatus, SelectedArea)
                ElseIf AreaAll.Checked = False And StatAll.Checked = True And ManAll.Checked = False Then
                    Part2TableAdapter.FillByFilterManufArea(Me.SignalogDataSet.Part2, PFilter, SelectedManuf, SelectedArea)
                ElseIf AreaAll.Checked = False And StatAll.Checked = False And ManAll.Checked = False Then
                    Part2TableAdapter.FillByFilterStatManufArea(Me.SignalogDataSet.Part2, PFilter, SelectedStatus, SelectedManuf, SelectedArea)
                End If

                GetPart()

                SFilter2()

                IDtxt.Text = Convert.ToString(EQUIPMENT2TableAdapter.ReturnPartID(SelectedPart, SelectedSerial))
                LoadData2()
            End If
        Catch
        End Try
    End Sub

    Private Sub Desc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Desc.SelectedIndexChanged
        PartNum.Text = Parts_ListTableAdapter.ReturnPartNumAtDesc(Desc.Text)
        If Desc.SelectedValue = "NEW" Then
            If Parts_List_Maintenance.Visible = True Then
                MsgBox("Can't open Parts List Maintenance, form is already open" & vbCrLf & "Please close Parts List Maintenance and retry", MsgBoxStyle.Exclamation)
            Else
                NewPart = True
                Parts_List_Maintenance.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Inventory_Maintenance_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Parts.NewPart = True Then
            If Parts.Local.Checked = True Then
                Me.Local.Checked = True
                Me.WareHouse.Text = Parts.WareHouse.Text    'select appropriate warehouse
            Else
                Me.CityOwned.Checked = True
            End If
            Me.NewButton.PerformClick()
            Me.Area.SelectedValue = Parts.Area.SelectedValue
            Me.YES.Checked = True
            If Parts.Part.SelectedValue <> "NEW" Then
                Try
                    Me.Desc.SelectedValue = Parts.Part.SelectedValue
                Catch
                End Try
            End If
        Else
            PartFilter.Text = ""
            SerialFilter.Text = ""
            PartFilter.Focus()
        End If
    End Sub

    Private Sub Inventory_Maintenance_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.TextChanged
        Dim s, s1, s2 As String
        If NewPart = True Then
            NewPart = False
            Me.Text = "Inventory Maintenance"
            Me.Parts_ListTableAdapter.Fill(Me.SignalogDataSet.Parts_List)
            Try
                Desc.SelectedValue = Parts_ListTableAdapter.ReturnPart(Parts_ListTableAdapter.ReturnMaxID - 1)
                PartNum.Text = Parts_ListTableAdapter.ReturnPartNumAtDesc(Desc.Text)
            Catch
            End Try
        ElseIf NewManuf = True Then
            NewManuf = False
            Me.Text = "Inventory Maintenance"
            s = Desc.SelectedValue
            s1 = Status.SelectedValue
            s2 = Area.SelectedValue
            Me.MANF_LISTTableAdapter.Fill(Me.SignalogDataSet.MANF_LIST)  'Will reload data in Desc,Status,Area so we use s,s1,s2 to restore user selections
            Try
                Manuf.SelectedValue = MANF_LISTTableAdapter.ReturnMANUF(MANF_LISTTableAdapter.ReturnMaxID - 1)
                Desc.SelectedValue = s
                Status.SelectedValue = s1
                Area.SelectedValue = s2
            Catch
            End Try
        ElseIf NewArea = True Then
            NewArea = False
            Me.Text = "Inventory Maintenance"
            s = Desc.SelectedValue
            s1 = Status.SelectedValue
            s2 = Manuf.SelectedValue
            Me.CUS0TableAdapter.Fill(Me.SignalogDataSet.CUS0)
            Try
                Area.SelectedValue = CUS0TableAdapter.ReturnAreaName(CUS0TableAdapter.ReturnMAXAREANUM - 1)
                Desc.SelectedValue = s
                Status.SelectedValue = s1
                Manuf.SelectedValue = s2
            Catch
            End Try
        End If
    End Sub

    Private Sub Manuf_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Manuf.SelectedIndexChanged
        If Manuf.SelectedValue = "NEW" Then
            If Manufacturer_List_Maintenance.Visible = True Then
                MsgBox("Can't open Manufacturer List Maintenance, form is already open" & vbCrLf & "Please close Manufacturer List Maintenance and retry", MsgBoxStyle.Exclamation)
            Else
                NewManuf = True
                Manufacturer_List_Maintenance.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Area_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Area.SelectedIndexChanged
        If Area.SelectedValue = "NEW" Then   'To add a new item
            If Area_Maintenance.Visible = True Then
                MsgBox("Can't open Area Maintenance, form is already open" & vbCrLf & "Please close Area Maintenance and retry", MsgBoxStyle.Exclamation)
            Else
                NewArea = True
                Area_Maintenance.ShowDialog()
            End If

        End If
    End Sub

    Private Sub NoneSN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoneSN.CheckedChanged
        If NewRecord = True Or EditRecord = True Then
            If NoneSN.Checked = True Then  'Misc Item
                SNtxt.ReadOnly = True
                SNtxt.Text = "None"
                Status.Enabled = False
                Status.Text = "None"
                Status.SelectedValue = "None"
                If NewRecord = True Then    'NEW Misc part so Q=0
                    Quantity.Text = "0"
                ElseIf EditRecord = True Then   'EDIT Misc part so restore Q
                    Quantity.Text = EQUIPMENTTableAdapter.ReturnQuantityAtID(IDtxt.Text, WareHouse.Text)
                End If
                PartWareHouse.Enabled = False 'Don't allow user to move non-unique parts to other warehouses 
                'Note: non-unique parts can be moved between warehouses via stock control form
            Else   'Part with unique serial
                SNtxt.ReadOnly = False
                SNtxt.Text = ""
                Status.Enabled = True
                Quantity.Text = "1"
                If EditRecord = True Then  'Allow user to move unique parts to other warehouses (when editing part)
                    PartWareHouse.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub WareHouse_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WareHouse.SelectedIndexChanged
        Me.PartTableAdapter.Fill2(Me.SignalogDataSet.Part, WareHouse.Text)
        SelectedPart = ""
        SelectedSerial = ""
        PFilter = "%"
        SerialTableAdapter.FillByPartDesc(Me.SignalogDataSet.Serial, PartDesc.SelectedValue, WareHouse.Text)
        load4()
    End Sub

    Private Sub ContCosttxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ContCosttxt.KeyPress
        e.Handled = TrapKey2(Asc(e.KeyChar))
    End Sub

    Private Sub NonContCosttxt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NonContCosttxt.KeyPress
        e.Handled = TrapKey2(Asc(e.KeyChar))
    End Sub

    Private Function TrapKey2(ByVal KCode As String) As Boolean  'allow only numbers (decimal)
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Or KCode = 46 Then  '8:backspace , 46: .
            TrapKey2 = False
        Else
            TrapKey2 = True
        End If
    End Function

End Class
