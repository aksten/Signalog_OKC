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

Public Class Employees_Maintenance
    Dim selectedEmployee As String
    Dim NewRecord As Boolean
    Dim EditRecord, flag As Boolean
    Dim FFilter, LFilter As String
    Dim sh, Fsh, AT As String

    Private Sub Employees_Maintenance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Submit.Enabled = True Then
            If MsgBox("Are you sure you want to exit without saving changes?", MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                UndoButton.PerformClick()
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub Employees_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EmployeeSEQTableAdapter.Fill(Me.SignalogDataSet.EmployeeSEQ)
        Fname.Enabled = False
        Lname.Enabled = False
        PListName.Enabled = False
        SeqNum.Enabled = False
        YES.Enabled = False
        NO.Enabled = False

        UserName.Enabled = False
        Password.Enabled = False
        AccessType.Enabled = False
        Submit.Enabled = False
        UndoButton.Enabled = False
        NewRecord = False
        EditRecord = False
        SeqAll.Checked = True
        FilterYES.Checked = True
        FFilter = "%"
        LFilter = "%"

        If FilterYES.Checked = True Then
            Fsh = "Y"
        ElseIf FilterNO.Checked = True Then
            Fsh = "N"
        End If

        PERS0TableAdapter.FillByNFiltersShow(Me.SignalogDataSet.PERS0, FFilter, LFilter, Fsh)
        GetEmp()
        LoadData()

        Filters.Checked = True
        EmpID.Enabled = False
        bck.Enabled = False
        fwd.Enabled = False

    End Sub

    Private Sub Employees_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Employees.SelectedIndexChanged
        GetEmp()
        LoadData()
    End Sub

    Private Sub EmpID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles EmpID.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Sub SeqNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles SeqNum.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Function TrapKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function

    Private Sub EmpID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpID.TextChanged
        If EmpID.Text <> "" And NewRecord = False And ID.Checked = True Then
            If (EmpID.Text > PERS0TableAdapter.ReturnMaxID - 1) Or (PERS0TableAdapter.ReturnCountID(EmpID.Text) = 0) Then
                MsgBox("No record found for entered Employee ID", MsgBoxStyle.Exclamation)
                EmpID.Text = ""
                Fname.Text = ""
                Lname.Text = ""
                PListName.Text = ""
                SeqNum.Text = ""
                NO.Checked = False
                YES.Checked = False
            Else
                Try
                    selectedEmployee = PERS0TableAdapter.ReturnPLISTNAME(EmpID.Text)
                    Employees.SelectedValue = selectedEmployee
                    Fname.Text = PERS0TableAdapter.ReturnFname(selectedEmployee)
                    Lname.Text = PERS0TableAdapter.ReturnLname(selectedEmployee)
                    PListName.Text = selectedEmployee
                    SeqNum.Text = PERS0TableAdapter.ReturnSeq(selectedEmployee)
                    sh = PERS0TableAdapter.ReturnShow(selectedEmployee)
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
        If EmpID.Text = String.Empty Then
            Fname.Text = ""
            Lname.Text = ""
            PListName.Text = ""
            SeqNum.Text = ""
            NO.Checked = False
            YES.Checked = False
        End If
    End Sub

    Private Sub fwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwd.Click
        Dim i As Integer
        If EmpID.Text = "" Or EmpID.Text = Convert.ToString(PERS0TableAdapter.ReturnMaxID - 1) Then
            EmpID.Text = PERS0TableAdapter.ReturnMinID
        Else
            i = EmpID.Text + 1
            While PERS0TableAdapter.ReturnCountID(i) = 0 And PERS0TableAdapter.ReturnMaxID - 1 > i
                i += 1
            End While
            If PERS0TableAdapter.ReturnCountID(i) = 0 Then
                EmpID.Text = PERS0TableAdapter.ReturnMinID
            Else
                EmpID.Text = i
            End If
        End If
    End Sub

    Private Sub bck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bck.Click
        Dim i As Integer
        If EmpID.Text = "" Or EmpID.Text = Convert.ToString(PERS0TableAdapter.ReturnMinID) Then
            If PERS0TableAdapter.ReturnCountID(PERS0TableAdapter.ReturnMaxID - 1) <> 0 Then
                EmpID.Text = PERS0TableAdapter.ReturnMaxID - 1
            Else
                i = PERS0TableAdapter.ReturnMaxID - 1
                While PERS0TableAdapter.ReturnCountID(i) = 0 And i > 1
                    i -= 1
                End While
                EmpID.Text = i
            End If
        Else
            i = EmpID.Text - 1
            While PERS0TableAdapter.ReturnCountID(i) = 0 And i > 1
                i -= 1
            End While
            EmpID.Text = i
        End If
    End Sub

    Private Sub ID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID.CheckedChanged
        If ID.Checked = True Then
            LoadPanel.Enabled = False
            EmpID.Enabled = True
            bck.Enabled = True
            fwd.Enabled = True
            FilterBoth.Checked = True
            SeqAll.Checked = True
            FilterFname.Text = ""
            FilterLname.Text = ""
        Else
            LoadPanel.Enabled = True
            EmpID.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
        End If

        Fill()
        GetEmp()
        LoadData()
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If ACT0TableAdapter.ReturnEmpNumCOUNT(EmpID.Text) <> 0 Then
            MsgBox("Delete forbidden, employee is associated with one or more trouble reports", MsgBoxStyle.Exclamation, "Delete Forbidden")
        ElseIf PERS0TableAdapter.ReturnAccessType(PERS0TableAdapter.ReturnUSERNAME(EmpID.Text)) = "A" Then
            MsgBox("Delete forbidden, this user is an administrator", MsgBoxStyle.Exclamation, "Delete Forbidden")
        ElseIf PERS0TableAdapter.ReturnAccessType(Login.User) <> "A" Then
            MsgBox("Delete forbidden, only administrators are allowed to delete users", MsgBoxStyle.Exclamation, "Delete Forbidden")
        Else
            Dim result As MsgBoxResult
            result = MsgBox("Are you sure you want to delete the selected employee?", MsgBoxStyle.YesNo, "Delete Employee?")
            If result = MsgBoxResult.Yes Then
                PERS0TableAdapter.DeleteAtID(EmpID.Text)
                Fill()
                GetEmp()
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
        Parts.Enabled = False
        LoadPanel.Enabled = False
        Label13.Visible = False
        LoadByPanel.Visible = False
        EmpID.Enabled = False
        fwd.Enabled = False
        bck.Enabled = False
        Fname.Enabled = True
        Lname.Enabled = True
        PListName.Enabled = True
        SeqNum.Enabled = True
        YES.Enabled = True
        NO.Enabled = True
        If Login.AccessType = "A" Then
            UserName.Enabled = True
            Password.Enabled = True
            AccessType.Enabled = True
        End If
        Submit.Enabled = True
        Fname.Text = ""
        Lname.Text = ""
        PListName.Text = ""
        SeqNum.Text = ""
        UserName.Text = ""
        Password.Text = ""
        AccessType.Text = ""
        YES.Checked = False
        NO.Checked = False
        EmpID.Text = LOCKNEWTableAdapter.ReturnLockValue("Employees") + 1   'Assign AREANUM= highest LOCK value +1
        LOCKNEWTableAdapter.UpdateLockValue(EmpID.Text, "Employees")  'Update LOCK
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        If LOCKEDITTableAdapter.ReturnDescValueCOUNT("Employees", EmpID.Text) <> 0 Then   'If locked for editing
            MsgBox("This employee record is being edited by another user, please try editing later", MsgBoxStyle.Information)
        Else
            LOCKEDITTableAdapter.Insert("Employees", EmpID.Text)  'Lock for editing
            GetEmp()
            LoadData()

            EditButton.Enabled = False
            EditRecord = True
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            UndoButton.Enabled = True
            LoadByPanel.Visible = False
            LoadPanel.Enabled = False
            Label13.Visible = False
            EmpID.Enabled = False
            Fname.Enabled = True
            Lname.Enabled = True
            PListName.Enabled = True
            SeqNum.Enabled = True
            bck.Enabled = False
            fwd.Enabled = False
            YES.Enabled = True
            NO.Enabled = True
            If Login.AccessType = "A" Then  'Admin or user editing his own profile
                UserName.Enabled = True
                Password.Enabled = True
                AccessType.Enabled = True
            End If
            Submit.Enabled = True
        End If
    End Sub

    Private Sub UndoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoButton.Click
        If EditRecord = True Then
            LOCKEDITTableAdapter.DeleteAtDescValue("Employees", EmpID.Text)
        End If
        EditRecord = False
        NewRecord = False
        NewButton.Enabled = True
        Employees.Enabled = True
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        UndoButton.Enabled = False
        Label13.Visible = True
        LoadPanel.Enabled = True
        LoadByPanel.Visible = True

        If Filters.Checked = True Then
            EmpID.Enabled = False
            LoadPanel.Enabled = True
            bck.Enabled = False
            fwd.Enabled = False
        Else
            EmpID.Enabled = True
            LoadPanel.Enabled = False
            bck.Enabled = True
            fwd.Enabled = True
        End If


        Fname.Enabled = False
        Lname.Enabled = False
        PListName.Enabled = False
        SeqNum.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        UserName.Enabled = False
        Password.Enabled = False
        AccessType.Enabled = False
        Submit.Enabled = False

        If Trouble_Report.NewEnterBy = True Then
            Trouble_Report.NewEnterBy = False
        End If

        GetEmp()
        LoadData()
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        flag = False
        Dim previousID As Integer
        previousID = EmpID.Text
        If NewRecord = True Then
            If Login.AccessType = "A" Then    'Admin
                If PERS0TableAdapter.ReturnUserNameCOUNTnew(UserName.Text) <> 0 And UserName.Text <> String.Empty Then
                    If MsgBox("UserName already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new employee entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        UndoButton.PerformClick()
                        GoTo EXITNEWEMP
                    Else
                        UserName.Text = ""
                        UserName.Focus()
                    End If
                    flag = True   'Don't submit
                Else
                    GoTo NEWEMP
                End If
            End If
            If PERS0TableAdapter.ReturnPListNameCOUNTnew(PListName.Text) <> 0 And PListName.Text <> String.Empty Then
                If MsgBox("PListName already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new employee entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    PListName.Text = ""
                    PListName.Focus()
                End If
                flag = True   'Don't submit
            Else
NEWEMP:
                If Fname.Text = String.Empty Then
                    MsgBox("Please enter First Name", MsgBoxStyle.Exclamation, "Missing Field")
                    Fname.Focus()
                    flag = True
                ElseIf Lname.Text = String.Empty Then
                    MsgBox("Please enter Last Name", MsgBoxStyle.Exclamation, "Missing Field")
                    Lname.Focus()
                    flag = True
                ElseIf PListName.Text = String.Empty Then
                    MsgBox("Please enter PickList Name", MsgBoxStyle.Exclamation, "Missing Field")
                    PListName.Focus()
                    flag = True
                ElseIf SeqNum.Text = "" Then
                    MsgBox("Please enter SEQ Number", MsgBoxStyle.Exclamation, "Missing Field")
                    SeqNum.Focus()
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
                    If AccessType.SelectedIndex = 0 Then
                        AT = "A"
                    ElseIf AccessType.SelectedIndex = 1 Then
                        AT = "T"
                    Else
                        AT = "R"
                    End If
                    PERS0TableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("Employees") + 1, PERS0TableAdapter.ReturnEmpID("NEW")) 'Increment NEW ID
                    If Login.AccessType = "A" Then    'Admin
                        PERS0TableAdapter.Insert(EmpID.Text, PListName.Text, SeqNum.Text, sh, Lname.Text, Fname.Text, UserName.Text, Password.Text, AT)
                    Else    'Technician
                        PERS0TableAdapter.Insert(EmpID.Text, PListName.Text, SeqNum.Text, sh, Lname.Text, Fname.Text, "", "", "")
                    End If
                    Me.PERS0TableAdapter.Fill(Me.SignalogDataSet.PERS0)
                    Me.EmployeeSEQTableAdapter.Fill(Me.SignalogDataSet.EmployeeSEQ)
                    NewRecord = False
                End If
            End If
        End If

EXITNEWEMP:
        If EditRecord = True Then
            If Login.AccessType = "A" Then    'Admin 
                If PERS0TableAdapter.ReturnUserNameCOUNTedit(UserName.Text, EmpID.Text) <> 0 And UserName.Text <> String.Empty Then
                    If MsgBox("UserName already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new employee entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        UndoButton.PerformClick()
                        GoTo EXITEDITEMP
                    Else
                        UserName.Text = ""
                        UserName.Focus()
                    End If
                    flag = True   'Don't submit
                Else
                    GoTo EDITEMP
                End If
            End If
            If PERS0TableAdapter.ReturnPListNameCOUNTedit(PListName.Text, EmpID.Text) <> 0 And PListName.Text <> String.Empty Then
                If MsgBox("PListName already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new employee entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    UndoButton.PerformClick()
                Else
                    PListName.Text = ""
                    PListName.Focus()
                End If
                flag = True   'Don't submit
            Else
EDITEMP:
                If Fname.Text = String.Empty Then
                    MsgBox("Please enter First Name", MsgBoxStyle.Exclamation, "Missing Field")
                    Fname.Focus()
                    flag = True
                ElseIf Lname.Text = String.Empty Then
                    MsgBox("Please enter Last Name", MsgBoxStyle.Exclamation, "Missing Field")
                    Lname.Focus()
                    flag = True
                ElseIf PListName.Text = String.Empty Then
                    MsgBox("Please enter PickList Name", MsgBoxStyle.Exclamation, "Missing Field")
                    PListName.Focus()
                    flag = True
                ElseIf SeqNum.Text = "" Then
                    MsgBox("Please enter SEQ Number", MsgBoxStyle.Exclamation, "Missing Field")
                    SeqNum.Focus()
                    flag = True
                Else
                    If YES.Checked = True Then
                        sh = "Y"
                    Else
                        sh = "N"
                    End If
                    If AccessType.SelectedIndex = 0 Then
                        AT = "A"
                    ElseIf AccessType.SelectedIndex = 1 Then
                        AT = "T"
                    Else
                        AT = "R"
                    End If
                    LOCKEDITTableAdapter.DeleteAtDescValue("Employees", EmpID.Text)   'Release Edit LOCK
                    If Login.AccessType = "A" Then    'Admin
                        PERS0TableAdapter.UpdateLoginInfoAtID(UserName.Text, Password.Text, AT, EmpID.Text)
                    End If
                    PERS0TableAdapter.UpdateAtID(PListName.Text, SeqNum.Text, sh, Lname.Text, Fname.Text, EmpID.Text)
                    Me.PERS0TableAdapter.Fill(Me.SignalogDataSet.PERS0)
                    Me.EmployeeSEQTableAdapter.Fill(Me.SignalogDataSet.EmployeeSEQ)
                    EditRecord = False
                End If
            End If
        End If

EXITEDITEMP:
        If flag = False Then
            NewButton.Enabled = True
            Employees.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = True
            Label13.Visible = True
            LoadPanel.Enabled = True
            LoadByPanel.Visible = True

            If Filters.Checked = True Then
                EmpID.Enabled = False
                LoadPanel.Enabled = True
                bck.Enabled = False
                fwd.Enabled = False
            Else
                EmpID.Enabled = True
                LoadPanel.Enabled = False
                bck.Enabled = True
                fwd.Enabled = True
            End If

            UndoButton.Enabled = False
            Fname.Enabled = False
            Lname.Enabled = False
            PListName.Enabled = False
            SeqNum.Enabled = False
            YES.Enabled = False
            NO.Enabled = False
            UserName.Enabled = False
            Password.Enabled = False
            AccessType.Enabled = False
            Submit.Enabled = False

            Fill()
            Employees.SelectedValue = PERS0TableAdapter.ReturnPLISTNAME(previousID)

            selectedEmployee = Employees.SelectedValue    'In case ID was 1 (Index in Employees list will not change after Fill)
            LoadData()    'In case ID was 1 (Index in Employees list will not change after Fill)
        End If

        If Trouble_Report.NewEnterBy = True And flag = False Then
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
        GetEmp()
        LoadData()
    End Sub

    Private Sub FilterLname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterLname.TextChanged
        FFilter = FilterFname.Text & "%"
        LFilter = FilterLname.Text & "%"
        Fill()
        GetEmp()
        LoadData()
    End Sub

    Sub GetEmp()
        If Me.SignalogDataSet.PERS0.Rows.Count <> 0 Then
            selectedEmployee = Employees.SelectedValue
        Else
            selectedEmployee = ""
        End If
    End Sub

    Sub LoadData()
        Try
            EmpID.Text = Convert.ToString(PERS0TableAdapter.ReturnEmpID(selectedEmployee))
            Fname.Text = PERS0TableAdapter.ReturnFname(selectedEmployee)
            Lname.Text = PERS0TableAdapter.ReturnLname(selectedEmployee)
            PListName.Text = selectedEmployee
            SeqNum.Text = PERS0TableAdapter.ReturnSeq(selectedEmployee)
            sh = PERS0TableAdapter.ReturnShow(selectedEmployee)
            If sh = "Y" Then
                YES.Checked = True
                NO.Checked = False
            Else
                NO.Checked = True
                YES.Checked = False
            End If
            If Login.AccessType = "A" Then
                Label11.Visible = True
                Label12.Visible = True
                Label14.Visible = True
                UserName.Visible = True
                Password.Visible = True
                AccessType.Visible = True
                UserName.Text = PERS0TableAdapter.ReturnUSERNAME(EmpID.Text)
                Password.Text = PERS0TableAdapter.ReturnPASSWORD(EmpID.Text)
                AT = PERS0TableAdapter.ReturnAccessType(UserName.Text)
                If AT = "A" Then
                    AccessType.SelectedIndex = 0
                ElseIf AT = "T" Then
                    AccessType.SelectedIndex = 1
                Else
                    AccessType.SelectedIndex = 2
                End If
                EditButton.Enabled = True   'Only admin can edit 
            ElseIf PERS0TableAdapter.ReturnUSERNAME(EmpID.Text) = Login.User Then  'user can edit his own profile except login info
                EditButton.Enabled = True
                Label11.Visible = False
                Label12.Visible = False
                Label14.Visible = False
                UserName.Visible = False
                Password.Visible = False
                AccessType.Visible = False
            Else
                EditButton.Enabled = False
                Label11.Visible = False
                Label12.Visible = False
                Label14.Visible = False
                UserName.Visible = False
                Password.Visible = False
                AccessType.Visible = False
            End If
        Catch
        End Try
    End Sub

    Private Sub FilterYES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterYES.CheckedChanged
        If FilterYES.Checked = True Then
            Fsh = "Y"
        ElseIf FilterNO.Checked = True Then
            Fsh = "N"
        End If
        Fill()
        GetEmp()
        LoadData()
    End Sub

    Private Sub FilterNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterNO.CheckedChanged
        If FilterYES.Checked = True Then
            Fsh = "Y"
        ElseIf FilterNO.Checked = True Then
            Fsh = "N"
        End If
        Fill()
        GetEmp()
        LoadData()
    End Sub

    Private Sub FilterFname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterFname.TextChanged
        FFilter = FilterFname.Text & "%"
        LFilter = FilterLname.Text & "%"
        Fill()
        GetEmp()
        LoadData()
    End Sub

    Private Sub FilterSeq_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterSeq.SelectedIndexChanged
        Fill()
        GetEmp()
        LoadData()
    End Sub

    Sub Fill()
        If SeqAll.Checked = True Then
            If FilterBoth.Checked = True Then
                PERS0TableAdapter.FillByNFilters(Me.SignalogDataSet.PERS0, FFilter, LFilter)
            Else
                PERS0TableAdapter.FillByNFiltersShow(Me.SignalogDataSet.PERS0, FFilter, LFilter, Fsh)
            End If
        Else
            If FilterBoth.Checked = True Then
                PERS0TableAdapter.FillByNFiltersSeq(Me.SignalogDataSet.PERS0, FFilter, LFilter, FilterSeq.SelectedValue)
            Else
                PERS0TableAdapter.FillByNFiltersSeqShow(Me.SignalogDataSet.PERS0, FFilter, LFilter, FilterSeq.SelectedValue, Fsh)
            End If
        End If
    End Sub

    Private Sub Employees_Maintenance_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Trouble_Report.NewEnterBy = True Then
            Me.NewButton.PerformClick()
            Me.YES.Checked = True
        End If
    End Sub

End Class