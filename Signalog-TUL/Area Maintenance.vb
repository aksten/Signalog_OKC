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

Public Class Area_Maintenance
    Dim SelectedArea, AFilter As String
    Dim NewRecord As Boolean
    Dim EditRecord, flag As Boolean
    Dim sh, MaintCont, ReptType As String

    Private Sub Area_Maintenance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Submit.Enabled = True Then
            If MsgBox("Are you sure you want to exit without saving changes?", MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                UndoButton.PerformClick()
                e.Cancel = False
            End If
        End If

    End Sub
    Private Sub Area_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CUS0TableAdapter.Fill2(Me.SignalogDataSet.CUS0)
        MaintYES.Enabled = False
        MaintNO.Enabled = False
        CustomerName.Enabled = False
        AccountNo.Enabled = False
        PicklistId.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        InvAttn.Enabled = False
        InvAddr1.Enabled = False
        InvAddr2.Enabled = False
        InvCity.Enabled = False
        InvState.Enabled = False
        InvZip.Enabled = False
        InvTele.Enabled = False
        InvTerms.Enabled = False
        ConAttn.Enabled = False
        ConTitle.Enabled = False
        ConAddr1.Enabled = False
        ConAddr2.Enabled = False
        ConCity.Enabled = False
        ConState.Enabled = False
        ConZip.Enabled = False
        ConTele.Enabled = False
        PeriodRate.Enabled = False
        PeriodLength.Enabled = False
        Full.Enabled = False
        Brief.Enabled = False
        RegRate.Enabled = False
        OTRate.Enabled = False
        MinHrs.Enabled = False
        MileageRate.Enabled = False

        Submit.Enabled = False
        UndoButton.Enabled = False
        NewRecord = False
        EditRecord = False
        Filters.Checked = True
        FilterYES.Checked = True
        AREANUM.Enabled = False
        bck.Enabled = False
        fwd.Enabled = False

        AFilter = "%"
        Fill()
        GetArea()
        LoadData()

    End Sub

    Private Sub AREA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AREA.SelectedIndexChanged
        GetArea()
        LoadData()
    End Sub

    Private Sub FilterArea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterArea.TextChanged
        AFilter = FilterArea.Text & "%"
        Fill()
        GetArea()
        LoadData()
    End Sub

    Private Sub FilterYES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterYES.CheckedChanged
        Fill()
        GetArea()
        LoadData()
    End Sub

    Private Sub FilterNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterNO.CheckedChanged
        Fill()
        GetArea()
        LoadData()
    End Sub

    Private Sub ID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID.CheckedChanged
        If ID.Checked = True Then
            LoadPanel.Enabled = False
            AREANUM.Enabled = True
            bck.Enabled = True
            fwd.Enabled = True
            FilterBoth.Checked = True
            FilterArea.Text = ""
        Else
            LoadPanel.Enabled = True
            AREANUM.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
        End If

        Fill()
        GetArea()
        LoadData()
    End Sub

    Private Sub fwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwd.Click
        Dim i As Integer
        If AREANUM.Text = "" Or AREANUM.Text = Convert.ToString(CUS0TableAdapter.ReturnMAXAREANUM - 1) Then
            AREANUM.Text = CUS0TableAdapter.ReturnMINAREANUM
        Else
            i = AREANUM.Text + 1
            While CUS0TableAdapter.ReturnAREANUMCOUNT(i) = 0 And CUS0TableAdapter.ReturnMAXAREANUM - 1 > i
                i += 1
            End While
            If CUS0TableAdapter.ReturnAREANUMCOUNT(i) = 0 Then
                AREANUM.Text = CUS0TableAdapter.ReturnMINAREANUM
            Else
                AREANUM.Text = i
            End If
        End If
    End Sub

    Private Sub bck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bck.Click
        Dim i As Integer
        If AREANUM.Text = "" Or AREANUM.Text = Convert.ToString(CUS0TableAdapter.ReturnMINAREANUM) Then
            If CUS0TableAdapter.ReturnAREANUMCOUNT(CUS0TableAdapter.ReturnMAXAREANUM - 1) <> 0 Then
                AREANUM.Text = CUS0TableAdapter.ReturnMAXAREANUM - 1
            Else
                i = CUS0TableAdapter.ReturnMAXAREANUM - 1
                While CUS0TableAdapter.ReturnAREANUMCOUNT(i) = 0 And i > 1
                    i -= 1
                End While
                AREANUM.Text = i
            End If
        Else
            i = AREANUM.Text - 1
            While CUS0TableAdapter.ReturnAREANUMCOUNT(i) = 0 And i > 1
                i -= 1
            End While
            AREANUM.Text = i
        End If
    End Sub

    Private Sub AREANUM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles AREANUM.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Sub PeriodRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PeriodRate.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Sub RegRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RegRate.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Sub OTRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles OTRate.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Sub MinHrs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MinHrs.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Sub AREANUM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AREANUM.TextChanged
        If AREANUM.Text <> "" And NewRecord = False And ID.Checked = True Then
            If (AREANUM.Text > CUS0TableAdapter.ReturnMAXAREANUM - 1) Or (CUS0TableAdapter.ReturnAREANUMCOUNT(AREANUM.Text) = 0) Then
                MsgBox("No record found for entered AREANUM", MsgBoxStyle.Exclamation)
                AREANUM.Text = ""
                MaintNO.Checked = False
                MaintYES.Checked = False
                CustomerName.Text = ""
                AccountNo.Text = ""
                PicklistId.Text = ""
                YES.Checked = False
                NO.Checked = False
                InvAttn.Text = ""
                InvAddr1.Text = ""
                InvAddr2.Text = ""
                InvCity.Text = ""
                InvState.Text = ""
                InvZip.Text = ""
                InvTele.Text = ""
                InvTerms.Text = ""
                ConAttn.Text = ""
                ConTitle.Text = ""
                ConAddr1.Text = ""
                ConAddr2.Text = ""
                ConCity.Text = ""
                ConState.Text = ""
                ConZip.Text = ""
                ConTele.Text = ""
                PeriodRate.Text = ""
                PeriodLength.Text = ""
                Full.Checked = False
                Brief.Checked = False
                RegRate.Text = ""
                OTRate.Text = ""
                MinHrs.Text = ""
                MileageRate.Text = ""
            Else
                Try
                    SelectedArea = CUS0TableAdapter.ReturnAreaName(AREANUM.Text)
                    AREA.SelectedValue = SelectedArea
                    LoadData()
                Catch
                End Try
            End If
        End If
        If AREANUM.Text = String.Empty Then
            AREANUM.Text = ""
            MaintNO.Checked = False
            MaintYES.Checked = False
            CustomerName.Text = ""
            AccountNo.Text = ""
            PicklistId.Text = ""
            YES.Checked = False
            NO.Checked = False
            InvAttn.Text = ""
            InvAddr1.Text = ""
            InvAddr2.Text = ""
            InvCity.Text = ""
            InvState.Text = ""
            InvZip.Text = ""
            InvTele.Text = ""
            InvTerms.Text = ""
            ConAttn.Text = ""
            ConTitle.Text = ""
            ConAddr1.Text = ""
            ConAddr2.Text = ""
            ConCity.Text = ""
            ConState.Text = ""
            ConZip.Text = ""
            ConTele.Text = ""
            PeriodRate.Text = ""
            PeriodLength.Text = ""
            Full.Checked = False
            Brief.Checked = False
            RegRate.Text = ""
            OTRate.Text = ""
            MinHrs.Text = ""
            MileageRate.Text = ""
        End If
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If LOC0TableAdapter.ReturnAreaNumCOUNT(AREANUM.Text) <> 0 Then
            MsgBox("Delete forbidden, area is associated with one or more locations", MsgBoxStyle.Exclamation, "Delete Forbidden")
        ElseIf EQUIPMENT2TableAdapter.ReturnAreaNumCOUNT(AREANUM.Text) <> 0 Then
            MsgBox("Delete forbidden, area is associated with one or more inventory items", MsgBoxStyle.Exclamation, "Delete Forbidden")
        ElseIf Login.AccessType = "T" Then
            MsgBox("Please contact the administrator to make changes.", MsgBoxStyle.OkOnly, "Access Denied!")
        ElseIf Login.User = "JButler" Or Login.User = "JFissel" Then
            MsgBox("Please contact the administrator to make changes.", MsgBoxStyle.OkOnly, "Access Denied!")
        Else
            Dim result As MsgBoxResult
            result = MsgBox("Are you sure you want to delete the selected area?", MsgBoxStyle.YesNo, "Delete Area?")
            If result = MsgBoxResult.Yes Then
                CUS0TableAdapter.DeleteAtAREANUM(AREANUM.Text)
                Fill()
                GetArea()
                LoadData()
            End If
        End If
    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click
        If Login.AccessType = "T" Then
        ElseIf Login.AccessType = "T" Then
            MsgBox("Please contact the administrator to make changes.", MsgBoxStyle.OkOnly, "Access Denied!")
        Else
            NewRecord = True
            NewButton.Enabled = False
            UndoButton.Enabled = True
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            LoadPanel.Enabled = False
            Label13.Visible = False
            LoadByPanel.Visible = False
            AREANUM.Enabled = False
            fwd.Enabled = False
            bck.Enabled = False

            MaintYES.Enabled = True
            MaintNO.Enabled = True
            CustomerName.Enabled = True
            AccountNo.Enabled = True
            PicklistId.Enabled = True
            YES.Enabled = True
            NO.Enabled = True
            InvAttn.Enabled = True
            InvAddr1.Enabled = True
            InvAddr2.Enabled = True
            InvCity.Enabled = True
            InvState.Enabled = True
            InvZip.Enabled = True
            InvTele.Enabled = True
            InvTerms.Enabled = True
            ConAttn.Enabled = True
            ConTitle.Enabled = True
            ConAddr1.Enabled = True
            ConAddr2.Enabled = True
            ConCity.Enabled = True
            ConState.Enabled = True
            ConZip.Enabled = True
            ConTele.Enabled = True
            PeriodRate.Enabled = True
            PeriodLength.Enabled = True
            Full.Enabled = True
            Brief.Enabled = True
            RegRate.Enabled = True
            OTRate.Enabled = True
            MinHrs.Enabled = True
            YES.Enabled = True
            NO.Enabled = True
            MileageRate.Enabled = True
            Submit.Enabled = True

            MaintNO.Checked = False
            MaintYES.Checked = False
            CustomerName.Text = ""
            AccountNo.Text = ""
            PicklistId.Text = ""
            YES.Checked = False
            NO.Checked = False
            InvAttn.Text = ""
            InvAddr1.Text = ""
            InvAddr2.Text = ""
            InvCity.Text = ""
            InvState.Text = ""
            InvZip.Text = ""
            InvTele.Text = ""
            InvTerms.Text = ""
            ConAttn.Text = ""
            ConTitle.Text = ""
            ConAddr1.Text = ""
            ConAddr2.Text = ""
            ConCity.Text = ""
            ConState.Text = ""
            ConZip.Text = ""
            ConTele.Text = ""
            PeriodRate.Text = ""
            PeriodLength.Text = ""
            Full.Checked = False
            Brief.Checked = False
            RegRate.Text = ""
            OTRate.Text = ""
            MinHrs.Text = ""
            MileageRate.Text = ""

            AREANUM.Text = LOCKNEWTableAdapter.ReturnLockValue("Area") + 1   'Assign AREANUM= highest LOCK value +1
            LOCKNEWTableAdapter.UpdateLockValue(AREANUM.Text, "Area")  'Update LOCK
        End If
    End Sub

    Private Sub UndoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoButton.Click
        If EditRecord = True Then
            LOCKEDITTableAdapter.DeleteAtDescValue("Area", AREANUM.Text)
        End If

        EditRecord = False
        NewRecord = False
        NewButton.Enabled = True
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        UndoButton.Enabled = False
        Label13.Visible = True
        LoadPanel.Enabled = True
        LoadByPanel.Visible = True

        If Filters.Checked = True Then
            AREANUM.Enabled = False
            LoadPanel.Enabled = True
            bck.Enabled = False
            fwd.Enabled = False
        Else
            AREANUM.Enabled = True
            LoadPanel.Enabled = False
            bck.Enabled = True
            fwd.Enabled = True
        End If

        MaintYES.Enabled = False
        MaintNO.Enabled = False
        CustomerName.Enabled = False
        AccountNo.Enabled = False
        PicklistId.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        InvAttn.Enabled = False
        InvAddr1.Enabled = False
        InvAddr2.Enabled = False
        InvCity.Enabled = False
        InvState.Enabled = False
        InvZip.Enabled = False
        InvTele.Enabled = False
        InvTerms.Enabled = False
        ConAttn.Enabled = False
        ConTitle.Enabled = False
        ConAddr1.Enabled = False
        ConAddr2.Enabled = False
        ConCity.Enabled = False
        ConState.Enabled = False
        ConZip.Enabled = False
        ConTele.Enabled = False
        PeriodRate.Enabled = False
        PeriodLength.Enabled = False
        Full.Enabled = False
        Brief.Enabled = False
        RegRate.Enabled = False
        OTRate.Enabled = False
        MinHrs.Enabled = False
        MileageRate.Enabled = False

        Submit.Enabled = False

        If Trouble_Report.NewArea = True Then
            Trouble_Report.NewArea = False
        End If

        If Inventory_Maintenance.NewArea = True Then
            Inventory_Maintenance.NewArea = False
        End If

        If Locations_Maintenance.NewArea = True Then
            Locations_Maintenance.NewArea = False
        End If

        If Parts.NewArea = True Then
            Parts.NewArea = False
        End If

        LoadData()
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        flag = False
        Dim previousID As Integer
        previousID = AREANUM.Text

        If NewRecord = True Then
            If CUS0TableAdapter.ReturnCustomerNameCOUNTnew(CustomerName.Text) <> 0 And CustomerName.Text <> String.Empty Then
                If MsgBox("Customer name already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new area entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    CustomerName.Text = ""
                    CustomerName.Focus()
                End If
                flag = True   'Don't submit
            ElseIf CUS0TableAdapter.ReturnPicklistCOUNTnew(PicklistId.Text) <> 0 And PicklistId.Text <> String.Empty Then
                If MsgBox("Picklist ID already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new area entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    PicklistId.Text = ""
                    PicklistId.Focus()
                End If
                flag = True   'Don't submit
            ElseIf CUS0TableAdapter.ReturnAccountNoCOUNTnew(AccountNo.Text) <> 0 And AccountNo.Text <> String.Empty Then   'And AccountNo.Text <> String.Empty b/c AccountNo may be empty
                If MsgBox("Accout number already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new area entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    AccountNo.Text = ""
                    AccountNo.Focus()
                End If
                flag = True   'Don't submit
            Else
                If CustomerName.Text = String.Empty Then
                    MsgBox("Please enter Customer Name", MsgBoxStyle.Exclamation, "Missing Field")
                    CustomerName.Focus()
                    flag = True
                ElseIf PicklistId.Text = String.Empty Then
                    MsgBox("Please enter Picklist ID", MsgBoxStyle.Exclamation, "Missing Field")
                    PicklistId.Focus()
                    flag = True
                ElseIf YES.Checked = False And NO.Checked = False Then
                    MsgBox("Please select YES or NO for the Show field", MsgBoxStyle.Exclamation, "Missing Field")
                    flag = True
                ElseIf MaintYES.Checked = False And MaintNO.Checked = False Then
                    MsgBox("Please select Maint_Contract YES or NO", MsgBoxStyle.Exclamation, "Missing Field")
                    flag = True
                ElseIf Full.Checked = False And Brief.Checked = False Then
                    MsgBox("Please select Rept Type", MsgBoxStyle.Exclamation, "Missing Field")
                    flag = True
                ElseIf RegRate.Text = String.Empty Then
                    MsgBox("Please enter Regular Hr Rate", MsgBoxStyle.Exclamation, "Missing Field")
                    RegRate.Focus()
                    flag = True
                ElseIf OTRate.Text = String.Empty Then
                    MsgBox("Please enter OverTime Hr Rate", MsgBoxStyle.Exclamation, "Missing Field")
                    OTRate.Focus()
                    flag = True
                ElseIf MinHrs.Text = String.Empty Then
                    MsgBox("Please enter Minimum Hours", MsgBoxStyle.Exclamation, "Missing Field")
                    MinHrs.Focus()
                    flag = True
                ElseIf PeriodRate.Text = String.Empty Then
                    MsgBox("Please enter Period Rate", MsgBoxStyle.Exclamation, "Missing Field")
                    PeriodRate.Focus()
                    flag = True
                ElseIf MileageRate.Text = String.Empty Then
                    MsgBox("Please enter Mileage Rate", MsgBoxStyle.Exclamation, "Missing Field")
                    MileageRate.Focus()
                    flag = True
                Else
                    If MaintYES.Checked = True Then
                        MaintCont = "Y"
                    Else
                        MaintCont = "N"
                    End If
                    If YES.Checked = True Then
                        sh = "Y"
                    Else
                        sh = "N"
                    End If
                    If Full.Checked = True Then
                        ReptType = "F"
                    Else
                        ReptType = "B"
                    End If

                    CUS0TableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("Area") + 1, CUS0TableAdapter.ReturnAREANUM("NEW")) 'Increment NEW ID

                    CUS0TableAdapter.Insert(AREANUM.Text, PicklistId.Text, sh, CustomerName.Text, AccountNo.Text _
                                              , InvAttn.Text, InvAddr1.Text, InvAddr2.Text, InvCity.Text, InvState.Text _
                                              , InvZip.Text, InvTele.Text, InvTerms.Text, ConAttn.Text, ConTitle.Text _
                                              , ConAddr1.Text, ConAddr2.Text, ConCity.Text, ConState.Text, ConZip.Text _
                                              , ConTele.Text, ReptType, PeriodRate.Text, PeriodLength.Text, RegRate.Text _
                                              , OTRate.Text, MinHrs.Text, MileageRate.Text, MaintCont)

                    Me.CUS0TableAdapter.Fill2(Me.SignalogDataSet.CUS0)
                    NewRecord = False
                End If
            End If
        End If

        If EditRecord = True Then
            If CUS0TableAdapter.ReturnCustomerNameCOUNTedit(CustomerName.Text, AREANUM.Text) <> 0 And CustomerName.Text <> String.Empty Then
                If MsgBox("Customer name already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new area entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    CustomerName.Text = ""
                    CustomerName.Focus()
                End If
                flag = True   'Don't submit
            ElseIf CUS0TableAdapter.ReturnPicklistCOUNTedit(PicklistId.Text, AREANUM.Text) <> 0 And PicklistId.Text <> String.Empty Then
                If MsgBox("Picklist ID already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new area entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    PicklistId.Text = ""
                    PicklistId.Focus()
                End If
                flag = True   'Don't submit
            ElseIf CUS0TableAdapter.ReturnAccountNoCOUNTedit(AccountNo.Text, AREANUM.Text) <> 0 And AccountNo.Text <> String.Empty Then   'And AccountNo.Text <> String.Empty b/c AccountNo may be empty
                If MsgBox("Accout number already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new area entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    AccountNo.Text = ""
                    AccountNo.Focus()
                End If
                flag = True   'Don't submit
            Else
                If CustomerName.Text = String.Empty Then
                    MsgBox("Please enter Customer Name", MsgBoxStyle.Exclamation, "Missing Field")
                    CustomerName.Focus()
                    flag = True
                ElseIf PicklistId.Text = String.Empty Then
                    MsgBox("Please enter Picklist ID", MsgBoxStyle.Exclamation, "Missing Field")
                    PicklistId.Focus()
                    flag = True
                ElseIf RegRate.Text = String.Empty Then
                    MsgBox("Please enter Regular Hr Rate", MsgBoxStyle.Exclamation, "Missing Field")
                    RegRate.Focus()
                    flag = True
                ElseIf OTRate.Text = String.Empty Then
                    MsgBox("Please enter OverTime Hr Rate", MsgBoxStyle.Exclamation, "Missing Field")
                    OTRate.Focus()
                    flag = True
                ElseIf MinHrs.Text = String.Empty Then
                    MsgBox("Please enter Minimum Hours", MsgBoxStyle.Exclamation, "Missing Field")
                    MinHrs.Focus()
                    flag = True
                ElseIf PeriodRate.Text = String.Empty Then
                    MsgBox("Please enter Period Rate", MsgBoxStyle.Exclamation, "Missing Field")
                    PeriodRate.Focus()
                    flag = True
                ElseIf MileageRate.Text = String.Empty Then
                    MsgBox("Please enter Mileage Rate", MsgBoxStyle.Exclamation, "Missing Field")
                    MileageRate.Focus()
                    flag = True
                Else
                    If MaintYES.Checked = True Then
                        MaintCont = "Y"
                    Else
                        MaintCont = "N"
                    End If
                    If YES.Checked = True Then
                        sh = "Y"
                    Else
                        sh = "N"
                    End If
                    If Full.Checked = True Then
                        ReptType = "F"
                    Else
                        ReptType = "B"
                    End If

                    LOCKEDITTableAdapter.DeleteAtDescValue("Area", AREANUM.Text)

                    CUS0TableAdapter.UpdateAtAREANUM(PicklistId.Text, sh, CustomerName.Text, AccountNo.Text, InvAttn.Text _
                                                     , InvAddr1.Text, InvAddr2.Text, InvCity.Text, InvState.Text, InvZip.Text _
                                                     , InvTele.Text, InvTerms.Text, ConAttn.Text, ConTitle.Text, ConAddr1.Text _
                                                     , ConAddr2.Text, ConCity.Text, ConState.Text, ConZip.Text, ConTele.Text _
                                                     , ReptType, PeriodRate.Text, PeriodLength.Text, RegRate.Text, OTRate.Text _
                                                     , MinHrs.Text, MaintCont, MileageRate.Text, AREANUM.Text)

                    LOC0TableAdapter.UpdateArea(PicklistId.Text, AREANUM.Text)   'Update desc at LOC0
                    Me.CUS0TableAdapter.Fill2(Me.SignalogDataSet.CUS0)
                    EditRecord = False
                End If
            End If
        End If

        If flag = False Then
            NewButton.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = True
            UndoButton.Enabled = False
            Label13.Visible = True
            LoadPanel.Enabled = True
            LoadByPanel.Visible = True

            If Filters.Checked = True Then
                AREANUM.Enabled = False
                LoadPanel.Enabled = True
                bck.Enabled = False
                fwd.Enabled = False
            Else
                AREANUM.Enabled = True
                LoadPanel.Enabled = False
                bck.Enabled = True
                fwd.Enabled = True
            End If

            MaintYES.Enabled = False
            MaintNO.Enabled = False
            CustomerName.Enabled = False
            AccountNo.Enabled = False
            PicklistId.Enabled = False
            YES.Enabled = False
            NO.Enabled = False
            InvAttn.Enabled = False
            InvAddr1.Enabled = False
            InvAddr2.Enabled = False
            InvCity.Enabled = False
            InvState.Enabled = False
            InvZip.Enabled = False
            InvTele.Enabled = False
            InvTerms.Enabled = False
            ConAttn.Enabled = False
            ConTitle.Enabled = False
            ConAddr1.Enabled = False
            ConAddr2.Enabled = False
            ConCity.Enabled = False
            ConState.Enabled = False
            ConZip.Enabled = False
            ConTele.Enabled = False
            PeriodRate.Enabled = False
            PeriodLength.Enabled = False
            Full.Enabled = False
            Brief.Enabled = False
            RegRate.Enabled = False
            OTRate.Enabled = False
            MinHrs.Enabled = False
            MileageRate.Enabled = False
            Submit.Enabled = False

            NewRecord = False
            EditRecord = False

            Fill()
            AREA.SelectedValue = CUS0TableAdapter.ReturnAreaName(previousID)
            SelectedArea = AREA.SelectedValue  'b/c in case we edit first entry, area.selectedindex changed will not lunch and therefore no reload occurs
            LoadData()
        End If

        If Locations_Maintenance.NewArea = True And flag = False Then
            Me.Close()
            Locations_Maintenance.Text = Locations_Maintenance.Text & "n"
        End If

        If Parts.NewArea = True And flag = False Then
            Me.Close()
            Parts.Text = Parts.Text & "n"
        End If

        If Trouble_Report.NewArea = True And flag = False Then
            Me.Close()
            Trouble_Report.Text = Trouble_Report.Text & "n"
        End If

        If Inventory_Maintenance.NewArea = True And flag = False Then
            Me.Close()
            Inventory_Maintenance.Text = Inventory_Maintenance.Text & "n"
        End If

    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        If LOCKEDITTableAdapter.ReturnDescValueCOUNT("Area", AREANUM.Text) <> 0 Then   'If locked for editing
            MsgBox("This area is being edited by another user, please try editing later", MsgBoxStyle.Information)
        ElseIf Login.AccessType = "T" Then
            MsgBox("Please contact the administrator to make changes.", MsgBoxStyle.OkOnly, "Access Denied!")
        Else
            MsgBox("Please only hide a customer if they are no longer in business with us at all." & vbCrLf & "This will help prevent duplicate entries.", vbOKOnly, "Advice")
            LOCKEDITTableAdapter.Insert("Area", AREANUM.Text)  'Lock for editing
            EditButton.Enabled = False
            EditRecord = True
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            UndoButton.Enabled = True
            LoadByPanel.Visible = False
            LoadPanel.Enabled = False
            Label13.Visible = False
            AREANUM.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False

            MaintYES.Enabled = True
            MaintNO.Enabled = True
            CustomerName.Enabled = True
            AccountNo.Enabled = True
            PicklistId.Enabled = True
            YES.Enabled = True
            NO.Enabled = True
            InvAttn.Enabled = True
            InvAddr1.Enabled = True
            InvAddr2.Enabled = True
            InvCity.Enabled = True
            InvState.Enabled = True
            InvZip.Enabled = True
            InvTele.Enabled = True
            InvTerms.Enabled = True
            ConAttn.Enabled = True
            ConTitle.Enabled = True
            ConAddr1.Enabled = True
            ConAddr2.Enabled = True
            ConCity.Enabled = True
            ConState.Enabled = True
            ConZip.Enabled = True
            ConTele.Enabled = True
            PeriodRate.Enabled = True
            PeriodLength.Enabled = True
            Full.Enabled = True
            Brief.Enabled = True
            RegRate.Enabled = True
            OTRate.Enabled = True
            MinHrs.Enabled = True
            MileageRate.Enabled = True
            YES.Enabled = True
            NO.Enabled = True
            Submit.Enabled = True
        End If
        
    End Sub

    Private Function TrapKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Or KCode = 46 Then   '46 for ".", 8 for "Backspace"
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function

    Sub GetArea()
        If Me.SignalogDataSet.CUS0.Rows.Count <> 0 Then
            SelectedArea = AREA.SelectedValue
        Else
            SelectedArea = ""
        End If
    End Sub

    Sub Fill()
        If FilterBoth.Checked = True Then
            CUS0TableAdapter.FillByFilter(Me.SignalogDataSet.CUS0, AFilter)
        Else
            If FilterYES.Checked = True Then
                CUS0TableAdapter.FillByFilterShow(Me.SignalogDataSet.CUS0, AFilter, "Y")
            Else
                CUS0TableAdapter.FillByFilterShow(Me.SignalogDataSet.CUS0, AFilter, "N")
            End If
        End If
    End Sub

    Sub LoadData()
        Dim ID As Integer

        Try
            ID = CUS0TableAdapter.ReturnAREANUM(SelectedArea)
            AREANUM.Text = ID
            MaintCont = CUS0TableAdapter.ReturnMaintCont(ID)
            If MaintCont = "Y" Then
                MaintYES.Checked = True
                MaintNO.Checked = False
            Else
                MaintYES.Checked = False
                MaintNO.Checked = True
            End If
            CustomerName.Text = CUS0TableAdapter.ReturnCustomerName(ID)
            PicklistId.Text = SelectedArea
            AccountNo.Text = CUS0TableAdapter.ReturnACCTNUM(ID)
            sh = CUS0TableAdapter.ReturnShow(ID)
            If sh = "Y" Then
                YES.Checked = True
                NO.Checked = False
            Else
                YES.Checked = False
                NO.Checked = True
            End If
            InvAttn.Text = CUS0TableAdapter.ReturnINVATTN(ID)
            InvAddr1.Text = CUS0TableAdapter.ReturnINVADDR1(ID)
            InvAddr2.Text = CUS0TableAdapter.ReturnINVADDR2(ID)
            InvCity.Text = CUS0TableAdapter.ReturnINVCITY(ID)
            InvState.Text = CUS0TableAdapter.ReturnINVSTATE(ID)
            InvZip.Text = CUS0TableAdapter.ReturnINVZIP(ID)
            InvTele.Text = CUS0TableAdapter.ReturnINVTELE(ID)
            InvTerms.Text = CUS0TableAdapter.ReturnINVTERMS(ID)

            ConAttn.Text = CUS0TableAdapter.ReturnCONATTN(ID)
            ConTitle.Text = CUS0TableAdapter.ReturnCONTITLE(ID)
            ConAddr1.Text = CUS0TableAdapter.ReturnCONADDR1(ID)
            ConAddr2.Text = CUS0TableAdapter.ReturnCONADDR2(ID)
            ConCity.Text = CUS0TableAdapter.ReturnCONCITY(ID)
            ConState.Text = CUS0TableAdapter.ReturnCONSTATE(ID)
            ConZip.Text = CUS0TableAdapter.ReturnCONZIP(ID)
            ConTele.Text = CUS0TableAdapter.ReturnCONTELE(ID)

            PeriodRate.Text = CUS0TableAdapter.ReturnPERIODRATE(ID)
            PeriodLength.Text = CUS0TableAdapter.ReturnPERIODLEN(ID)
            ReptType = CUS0TableAdapter.ReturnREPTTYPE(ID)
            If ReptType = "F" Then
                Full.Checked = True
                Brief.Checked = False
            Else
                Full.Checked = False
                Brief.Checked = True
            End If
            RegRate.Text = CUS0TableAdapter.ReturnRegRate(ID)
            OTRate.Text = CUS0TableAdapter.ReturnOTRate(ID)
            MinHrs.Text = CUS0TableAdapter.ReturnMinHrs(ID)
            MileageRate.Text = CUS0TableAdapter.ReturnMileageRate(ID)
        Catch
        End Try
    End Sub

    Private Sub RegRate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RegRate.TextChanged
        If NewRecord = True Or EditRecord = True Then
            Try
                If RegRate.Text = String.Empty Then
                    OTRate.Text = String.Empty
                Else
                    OTRate.Text = 1.5 * Convert.ToDecimal(RegRate.Text)
                End If
            Catch
            End Try
        End If
    End Sub

    Private Sub Area_Maintenance_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Trouble_Report.NewArea = True Or Locations_Maintenance.NewArea = True Or Parts.NewArea = True Or Inventory_Maintenance.NewArea = True Then
            Me.NewButton.PerformClick()
            Me.YES.Checked = True
        End If
    End Sub


    Private Sub NO_Click(sender As Object, e As EventArgs) Handles NO.Click
        MsgBox("Please do not hide the customer unless they are no longer a customer.", vbOKOnly, "Warning!")
    End Sub


End Class