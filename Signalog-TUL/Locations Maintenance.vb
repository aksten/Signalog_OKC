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
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Public Class Locations_Maintenance
    Dim SelectedArea, SelectedEWLOC, SelectedNSLOC, AFilter As String
    Dim NewRecord As Boolean
    Dim EditRecord, flag, DelayLoad As Boolean
    Dim sh As String
    Dim BindNum, BindLOCNUM As Integer
    Public NewTypeDesc, NewArea As Boolean

    Private Sub Locations_Maintenance_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Submit.Enabled = True Then
            If MsgBox("Are you sure you want to exit without saving changes?", MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.No Then
                e.Cancel = True
            Else
                UndoButton.PerformClick()
                e.Cancel = False
            End If
        End If
    End Sub
    Private Sub Locations_Maintenance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.BindNSLOCTableAdapter.Fill(Me.SignalogDataSet.BindNSLOC)
        Me.BindEWLOCTableAdapter.Fill(Me.SignalogDataSet.BindEWLOC)
        Me.BindAreaTableAdapter.Fill(Me.SignalogDataSet.BindArea)
        Me.NSLOC2TableAdapter.Fill(Me.SignalogDataSet.NSLOC2)
        Me.EWLOC2TableAdapter.Fill(Me.SignalogDataSet.EWLOC2)
        Me.NSLOCTableAdapter.Fill2(Me.SignalogDataSet.NSLOC)
        Me.EWLOCTableAdapter.Fill2(Me.SignalogDataSet.EWLOC)
        Me.CUS0TableAdapter.Fill(Me.SignalogDataSet.CUS0)
        Me.LOC1TableAdapter.Fill(Me.SignalogDataSet.LOC1)
        Me.LOC0TableAdapter.Fill2(Me.SignalogDataSet.LOC0)

        AreaName.Enabled = False
        EWLOCbox.Enabled = False
        NSLOCbox.Enabled = False
        EWLOCtxt.Visible = False
        NSLOCtxt.Visible = False
        TypeDesc.Enabled = False
        INSERV.Enabled = False
        ISNoDate.Enabled = False
        OUTSERV.Enabled = False
        OSNoDate.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        Bind.Enabled = False
        BindArea.Enabled = False
        BindEWLOC.Enabled = False
        BindNSLOC.Enabled = False
        Submit.Enabled = False
        UndoButton.Enabled = False
        NewRecord = False
        EditRecord = False
        Filters.Checked = True
        FilterYES.Checked = True
        LOCNUM.Enabled = False
        bck.Enabled = False
        fwd.Enabled = False

        BindArea.Visible = False
        BindEWLOC.Visible = False
        BindNSLOC.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False

        AFilter = "%"
        Fill()
        GetArea()
        Fill2()
        GetEWLOC()
        Fill3()
        GetNSLOC()
        LoadData()

        DelayLoad = False
        NewTypeDesc = False
        NewArea = False
    End Sub

    Private Sub AREA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AREA.SelectedIndexChanged
        GetArea()
        Fill2()
        GetEWLOC()
        Fill3()
        GetNSLOC()
        If DelayLoad = False Then
            LoadData()
        End If
    End Sub

    Private Sub EWLOC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EWLOC.SelectedIndexChanged
        GetEWLOC()
        Fill3()
        GetNSLOC()
        If DelayLoad = False Then
            LoadData()
        End If
    End Sub

    Private Sub NSLOC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NSLOC.SelectedIndexChanged
        GetNSLOC()
        If DelayLoad = False Then
            LoadData()
        End If
    End Sub

    Private Sub FilterArea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterArea.TextChanged
        AFilter = FilterArea.Text & "%"
        Fill()
        GetArea()
        Fill2()
        GetEWLOC()
        Fill3()
        GetNSLOC()
        LoadData()
    End Sub

    Private Sub FilterYES_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterYES.CheckedChanged
        Fill()
        GetArea()
        Fill2()
        GetEWLOC()
        Fill3()
        GetNSLOC()
        LoadData()
    End Sub

    Private Sub FilterNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterNO.CheckedChanged
        Fill()
        GetArea()
        Fill2()
        GetEWLOC()
        Fill3()
        GetNSLOC()
        LoadData()
    End Sub

    Private Sub ID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ID.CheckedChanged
        If ID.Checked = True Then
            DelayLoad = True
            LoadPanel.Enabled = False
            LOCNUM.Enabled = True
            bck.Enabled = True
            fwd.Enabled = True
            FilterBoth.Checked = True
            FilterArea.Text = ""
        Else
            DelayLoad = False
            LoadPanel.Enabled = True
            LOCNUM.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
        End If

        Fill()
        GetArea()
        Fill2()
        GetEWLOC()
        Fill3()
        GetNSLOC()
        LoadData()
    End Sub

    Private Sub fwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fwd.Click
        Dim i As Integer
        If LOCNUM.Text = "" Or LOCNUM.Text = Convert.ToString(LOC0TableAdapter.ReturnMAXLOCNUM - 1) Then
            LOCNUM.Text = LOC0TableAdapter.ReturnMINLOCNUM
        Else
            i = LOCNUM.Text + 1
            While LOC0TableAdapter.ReturnLOCNUMCOUNT(i) = 0 And LOC0TableAdapter.ReturnMAXLOCNUM - 1 > i
                i += 1
            End While
            If LOC0TableAdapter.ReturnLOCNUMCOUNT(i) = 0 Then
                LOCNUM.Text = LOC0TableAdapter.ReturnMINLOCNUM
            Else
                LOCNUM.Text = i
            End If
        End If
    End Sub

    Private Sub bck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bck.Click
        Dim i As Integer
        If LOCNUM.Text = "" Or LOCNUM.Text = Convert.ToString(LOC0TableAdapter.ReturnMINLOCNUM) Then
            If LOC0TableAdapter.ReturnLOCNUMCOUNT(LOC0TableAdapter.ReturnMAXLOCNUM - 1) <> 0 Then
                LOCNUM.Text = LOC0TableAdapter.ReturnMAXLOCNUM - 1
            Else
                i = LOC0TableAdapter.ReturnMAXLOCNUM - 1
                While LOC0TableAdapter.ReturnLOCNUMCOUNT(i) = 0 And i > 1
                    i -= 1
                End While
                LOCNUM.Text = i
            End If
        Else
            i = LOCNUM.Text - 1
            While LOC0TableAdapter.ReturnLOCNUMCOUNT(i) = 0 And i > 1
                i -= 1
            End While
            LOCNUM.Text = i
        End If
    End Sub

    Private Sub LOCNUM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LOCNUM.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Function TrapKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function

    Private Sub LOCNUM_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOCNUM.TextChanged
        If LOCNUM.Text <> "" And NewRecord = False And ID.Checked = True Then
            If (LOCNUM.Text > LOC0TableAdapter.ReturnMAXLOCNUM - 1) Or (LOC0TableAdapter.ReturnLOCNUMCOUNT(LOCNUM.Text) = 0) Then
                MsgBox("No record found for entered LOCNUM")
                LOCNUM.Text = ""
                AreaName.Text = ""
                EWLOCbox.Text = ""
                NSLOCbox.Text = ""
                TypeDesc.Text = ""
                INSERV.Text = ""
                OUTSERV.Text = ""
                YES.Checked = False
                NO.Checked = False
                Bind.Checked = False
            Else
                Try
                    SelectedArea = LOC0TableAdapter.ReturnAREA(LOCNUM.Text)
                    AREA.SelectedValue = SelectedArea
                    SelectedEWLOC = LOC0TableAdapter.ReturnEWLOC(LOCNUM.Text)
                    EWLOC.SelectedValue = SelectedEWLOC
                    SelectedNSLOC = LOC0TableAdapter.ReturnNSLOC(LOCNUM.Text)
                    NSLOC.SelectedValue = SelectedNSLOC

                    AreaName.Text = SelectedArea
                    EWLOCbox.Text = SelectedEWLOC
                    NSLOCbox.Text = SelectedNSLOC
                    TypeDesc.Text = LOC1TableAdapter.ReturnTYPEDESC(LOC0TableAdapter.ReturnTYPENUM(LOCNUM.Text))
                    INSERV.Text = Convert.ToString(LOC0TableAdapter.ReturnINSERV(LOCNUM.Text))
                    OUTSERV.Text = Convert.ToString(LOC0TableAdapter.ReturnOUTSERV(LOCNUM.Text))

                    If Convert.ToString(LOC0TableAdapter.ReturnOUTSERV(LOCNUM.Text)) = String.Empty Then
                        OSNoDate.Checked = True
                        OUTSERV.CustomFormat = " "
                        OUTSERV.Format = DateTimePickerFormat.Custom
                    Else
                        OSNoDate.Checked = False
                        OUTSERV.Format = DateTimePickerFormat.Short
                    End If
                    If Convert.ToString(LOC0TableAdapter.ReturnINSERV(LOCNUM.Text)) = String.Empty Then
                        ISNoDate.Checked = True
                        INSERV.CustomFormat = " "
                        INSERV.Format = DateTimePickerFormat.Custom
                    Else
                        ISNoDate.Checked = False
                        INSERV.Format = DateTimePickerFormat.Short
                    End If

                    sh = LOC0TableAdapter.ReturnSHOW(LOCNUM.Text)
                    If sh = "Y" Then
                        YES.Checked = True
                        NO.Checked = False
                    Else
                        NO.Checked = True
                        YES.Checked = False
                    End If
                    BindNum = LOC0TableAdapter.ReturnBindNumber(LOCNUM.Text)
                    If BindNum <> 0 Then
                        Bind.Checked = True
                    Else
                        Bind.Checked = False
                    End If
                Catch
                End Try
            End If
        End If
        If LOCNUM.Text = String.Empty Then
            LOCNUM.Text = ""
            AreaName.Text = ""
            EWLOCbox.Text = ""
            NSLOCbox.Text = ""
            TypeDesc.Text = ""
            INSERV.Text = ""
            OUTSERV.Text = ""
            YES.Checked = False
            NO.Checked = False
            Bind.Checked = False
        End If
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If ACT0TableAdapter.ReturnLocNumCOUNT(LOCNUM.Text) <> 0 Then
            MsgBox("Delete forbidden, location is associated with one or more trouble reports", MsgBoxStyle.Exclamation, "Delete Forbidden")
        ElseIf Login.AccessType = "T" Or Login.User = "JButler" Then
            MsgBox("You do not have the access rights to delete information.", vbOKOnly, "Access Denied!")
        Else
            Dim result As MsgBoxResult
            result = MsgBox("Are you sure you want to delete the selected location?", MsgBoxStyle.YesNo, "Delete Location?")
            If result = MsgBoxResult.Yes Then
                LOC0TableAdapter.DeleteAtLOCNUM(LOCNUM.Text)
                Fill()
                GetArea()
                Fill2()
                GetEWLOC()
                Fill3()
                GetNSLOC()
                LoadData()
            End If
        End If
    End Sub

    Private Sub NewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewButton.Click
        If Login.AccessType = "T" Then
            MsgBox("You do not have the access rights to add information.", MsgBoxStyle.OkOnly, "Access Denied!")
        Else
            MsgBox("Please ensure the intersection doesn't already exist." & vbCrLf & "Check google maps for alternate road names.", MsgBoxStyle.OkOnly, "Warning!")
            NewRecord = True
            NewButton.Enabled = False
            UndoButton.Enabled = True
            EditButton.Enabled = False
            DeleteButton.Enabled = False
            LoadPanel.Enabled = False
            Label13.Visible = False
            LoadByPanel.Visible = False
            LOCNUM.Enabled = False
            fwd.Enabled = False
            bck.Enabled = False
            AreaName.Enabled = True
            EWLOCbox.Enabled = True
            NSLOCbox.Enabled = True
            TypeDesc.Enabled = True
            INSERV.Enabled = True
            ISNoDate.Enabled = True
            OUTSERV.Enabled = True
            OSNoDate.Enabled = True
            BindArea.Enabled = True
            BindEWLOC.Enabled = True
            BindNSLOC.Enabled = True
            YES.Enabled = True
            NO.Enabled = True
            Bind.Enabled = True
            Submit.Enabled = True

            LOCNUM.Text = ""
            AreaName.Text = ""
            EWLOCbox.Text = ""
            NSLOCbox.Text = ""
            EWLOCtxt.Text = ""
            NSLOCtxt.Text = ""
            TypeDesc.Text = ""
            INSERV.Text = ""
            OUTSERV.Text = ""
            YES.Checked = False
            NO.Checked = False
            LOCNUM.Text = LOCKNEWTableAdapter.ReturnLockValue("Locations") + 1   'Assign AREANUM= highest LOCK value +1
            LOCKNEWTableAdapter.UpdateLockValue(LOCNUM.Text, "Locations")  'Update LOCK
        End If
    End Sub


    Private Sub UndoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UndoButton.Click
        If EditRecord = True Then   'Release edit lock
            LOCKEDITTableAdapter.DeleteAtDescValue("Locations", LOCNUM.Text)
        End If
        EditRecord = False
        NewRecord = False
        NewButton.Enabled = True
        EditButton.Enabled = True
        DeleteButton.Enabled = True
        Label13.Visible = True
        LoadPanel.Enabled = True
        LoadByPanel.Visible = True

        If Filters.Checked = True Then
            LOCNUM.Enabled = False
            LoadPanel.Enabled = True
            bck.Enabled = False
            fwd.Enabled = False
        Else
            LOCNUM.Enabled = True
            LoadPanel.Enabled = False
            bck.Enabled = True
            fwd.Enabled = True
        End If

        UndoButton.Enabled = False
        AreaName.Enabled = False
        EWLOCbox.Enabled = False
        NSLOCbox.Enabled = False
        EWLOCtxt.Visible = False
        NSLOCtxt.Visible = False
        TypeDesc.Enabled = False
        INSERV.Enabled = False
        ISNoDate.Enabled = False
        OUTSERV.Enabled = False
        OSNoDate.Enabled = False
        YES.Enabled = False
        NO.Enabled = False
        Bind.Enabled = False
        BindArea.Enabled = False
        BindEWLOC.Enabled = False
        BindNSLOC.Enabled = False
        Submit.Enabled = False

        If Trouble_Report.NewEWLOC = True Then
            Trouble_Report.NewEWLOC = False
        End If

        If Trouble_Report.NewNSLOC = True Then
            Trouble_Report.NewNSLOC = False
        End If

        LoadData()
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        If LOCKEDITTableAdapter.ReturnDescValueCOUNT("Locations", LOCNUM.Text) <> 0 Then   'If locked for editing
            MsgBox("This location record is being edited by another user, please try editing later", MsgBoxStyle.Information)
        ElseIf Login.AccessType = "T" Then
            MsgBox("Please contact the Admin to make changes.", vbOKOnly, "Access Denied.")
        Else
            MsgBox("Please do not use the hide button unless the intersection no longer exists.", vbOKOnly, "Warning!")
            LOCKEDITTableAdapter.Insert("Locations", LOCNUM.Text)  'Lock for editing
            EditButton.Enabled = False
            EditRecord = True
            NewButton.Enabled = False
            DeleteButton.Enabled = False
            UndoButton.Enabled = True
            LoadByPanel.Visible = False
            LoadPanel.Enabled = False
            Label13.Visible = False
            LOCNUM.Enabled = False
            bck.Enabled = False
            fwd.Enabled = False
            AreaName.Enabled = True
            EWLOCbox.Enabled = True
            NSLOCbox.Enabled = True
            TypeDesc.Enabled = True
            INSERV.Enabled = True
            ISNoDate.Enabled = True
            OUTSERV.Enabled = True
            OSNoDate.Enabled = True
            BindArea.Enabled = True
            BindEWLOC.Enabled = True
            BindNSLOC.Enabled = True
            YES.Enabled = True
            NO.Enabled = True
            Bind.Enabled = True
            Submit.Enabled = True

            If Bind.Checked = True Then
                BindArea.Enabled = True
                BindEWLOC.Enabled = True
                BindNSLOC.Enabled = True
            End If
        End If
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Dim ew, ns As String
        flag = False
        Dim OutServDate As Date
        Dim previousId As Integer
        previousId = LOCNUM.Text
        If NewRecord = True Then
            If EWLOCbox.Text <> "NEW" And NSLOCbox.Text <> "NEW" Then
                If LOC0TableAdapter.ReturnLocationCOUNTnew(AreaName.Text, EWLOCbox.SelectedValue, NSLOCbox.SelectedValue) <> 0 Then
                    If MsgBox("Location already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new location entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        UndoButton.PerformClick()
                        GoTo ExitNewPart
                    End If
                    flag = True   'Don't submit
                Else
                    flag = False
                    GoTo NewPart
                End If
            ElseIf EWLOCbox.Text = "NEW" And NSLOCbox.Text = "NEW" Then
                If LOC0TableAdapter.ReturnLocationCOUNTnew(AreaName.Text, EWLOCtxt.Text, NSLOCtxt.Text) <> 0 Then
                    If MsgBox("Location already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new location entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        UndoButton.PerformClick()
                        GoTo ExitNewPart
                    Else
                        NSLOCtxt.Text = ""
                        NSLOCtxt.Focus()
                    End If
                    flag = True   'Don't submit
                Else
                    flag = False
                    GoTo NewPart
                End If
            ElseIf EWLOCbox.Text <> "NEW" And NSLOCbox.Text = "NEW" Then
                If LOC0TableAdapter.ReturnLocationCOUNTnew(AreaName.Text, EWLOCbox.SelectedValue, NSLOCtxt.Text) <> 0 Then
                    If MsgBox("Location already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new location entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        UndoButton.PerformClick()
                        GoTo ExitNewPart
                    Else
                        NSLOCtxt.Text = ""
                        NSLOCtxt.Focus()
                    End If
                    flag = True   'Don't submit
                Else
                    flag = False
                    GoTo NewPart
                End If
            End If
NewPart:
            If flag = False Then
                If AreaName.Text = String.Empty Or AreaName.Text = "NEW" Then   'Or AreaName.Text = "NEW",If closed Area_Maint without creating a new area
                    MsgBox("Please select Area")
                    AreaName.DroppedDown = True
                    flag = True
                ElseIf EWLOCbox.Text = String.Empty Then
                    MsgBox("Please enter EW Location")
                    EWLOCbox.DroppedDown = True
                    flag = True
                ElseIf EWLOCbox.SelectedValue = "NEW" And EWLOCtxt.Text = String.Empty Then
                    MsgBox("Please enter EW Location")
                    EWLOCtxt.Focus()
                    flag = True
                ElseIf NSLOCbox.Text = String.Empty Then
                    MsgBox("Please enter NS Location")
                    NSLOCbox.DroppedDown = True
                    flag = True
                ElseIf NSLOCbox.SelectedValue = "NEW" And NSLOCtxt.Text = String.Empty Then
                    MsgBox("Please enter NS Location")
                    NSLOCtxt.Focus()
                    flag = True
                ElseIf TypeDesc.Text = String.Empty Or TypeDesc.Text = "NEW" Then
                    MsgBox("Please select Location Type Description")
                    TypeDesc.DroppedDown = True
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

                    If Bind.Checked = True Then
                        BindNum = LOC0TableAdapter.ReturnBindNumber(LOC0TableAdapter.ReturnLOCNUM(BindArea.SelectedValue, BindEWLOC.SelectedValue, BindNSLOC.SelectedValue))
                        If BindNum = 0 Then
                            BindNum = LOC0TableAdapter.ReturnMaxBindNumber + 1
                            LOC0TableAdapter.UpdateBindNumber(BindNum, LOC0TableAdapter.ReturnLOCNUM(BindArea.SelectedValue, BindEWLOC.SelectedValue, BindNSLOC.SelectedValue))
                        End If
                    Else
                        BindNum = 0
                    End If

                    If EWLOCbox.SelectedValue <> "NEW" Then
                        ew = EWLOCbox.Text
                    Else
                        ew = EWLOCtxt.Text
                    End If

                    If NSLOCbox.SelectedValue <> "NEW" Then
                        ns = NSLOCbox.Text
                    Else
                        ns = NSLOCtxt.Text
                    End If

                    If OSNoDate.Checked = True Then
                        OutServDate = SqlTypes.SqlDateTime.Null    'This will enter 1/1/1900 with TableAdapter
                    Else
                        OutServDate = OUTSERV.Value.Date
                    End If

                    LOC0TableAdapter.UpdateID(LOCKNEWTableAdapter.ReturnLockValue("Locations") + 1, LOC0TableAdapter.ReturnLOCNUM("NEW", "NEW", "NEW")) 'Increment NEW ID

                    LOC0TableAdapter.Insert(LOCNUM.Text, ew, ns, CUS0TableAdapter.ReturnAREANUM(AreaName.SelectedValue) _
                                            , AreaName.SelectedValue, sh, LOC1TableAdapter.ReturnTYPENUM(TypeDesc.SelectedValue) _
                                            , INSERV.Value.Date, OutServDate, BindNum)

                    'Entering a NULL value in Date if OSNoDate is checked (since it can't be done with TableAdapters)
                    If OSNoDate.Checked = True Then
                        Dim sqlStmt As String
                        Dim conString As String
                        Dim cn As SqlConnection = Nothing
                        Dim cmd As SqlCommand
                        Dim sqldatenull As SqlDateTime
                        Try
                            sqlStmt = "UPDATE LOC0 SET OUTSERV=@OUTSERV WHERE LOCNUM=@LOCNUM"
                            conString = My.Settings.SignalogConnectionString
                            cn = New SqlConnection(conString)
                            cmd = New SqlCommand(sqlStmt, cn)

                            cmd.Parameters.Add(New SqlParameter("@OUTSERV", SqlDbType.Date))
                            cmd.Parameters.Add(New SqlParameter("@LOCNUM", SqlDbType.Int))

                            sqldatenull = SqlDateTime.Null

                            cmd.Parameters("@OUTSERV").Value = sqldatenull
                            cmd.Parameters("@LOCNUM").Value = LOCNUM.Text
                            cn.Open()
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            If Not cn Is Nothing Then cn.Close()
                        End Try
                    End If

                    If ISNoDate.Checked = True Then
                        Dim sqlStmt As String
                        Dim conString As String
                        Dim cn As SqlConnection = Nothing
                        Dim cmd As SqlCommand
                        Dim sqldatenull As SqlDateTime
                        Try
                            sqlStmt = "UPDATE LOC0 SET INSERV=@INSERV WHERE LOCNUM=@LOCNUM"
                            conString = My.Settings.SignalogConnectionString
                            cn = New SqlConnection(conString)
                            cmd = New SqlCommand(sqlStmt, cn)

                            cmd.Parameters.Add(New SqlParameter("@INSERV", SqlDbType.Date))
                            cmd.Parameters.Add(New SqlParameter("@LOCNUM", SqlDbType.Int))

                            sqldatenull = SqlDateTime.Null

                            cmd.Parameters("@INSERV").Value = sqldatenull
                            cmd.Parameters("@LOCNUM").Value = LOCNUM.Text
                            cn.Open()
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            cn.Close()
                        End Try
                    End If

                    LOC0TableAdapter.Fill2(Me.SignalogDataSet.LOC0)
                    EWLOCTableAdapter.Fill2(Me.SignalogDataSet.EWLOC)
                    NSLOCTableAdapter.Fill2(Me.SignalogDataSet.NSLOC)
                    EWLOC2TableAdapter.Fill(Me.SignalogDataSet.EWLOC2)
                    NSLOC2TableAdapter.Fill(Me.SignalogDataSet.NSLOC2)
                    BindEWLOCTableAdapter.Fill(Me.SignalogDataSet.BindEWLOC)
                    BindNSLOCTableAdapter.Fill(Me.SignalogDataSet.BindNSLOC)
                    NewRecord = False
                End If
            End If
        End If

ExitNewPart:
        If EditRecord = True Then
            If EWLOCbox.Text <> "NEW" And NSLOCbox.Text <> "NEW" Then
                If LOC0TableAdapter.ReturnLocationCOUNTedit(AreaName.Text, EWLOCbox.SelectedValue, NSLOCbox.SelectedValue, LOCNUM.Text) <> 0 Then
                    If MsgBox("Location already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new location entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        UndoButton.PerformClick()
                        GoTo ExitEditPart
                    End If
                    flag = True   'Don't submit
                Else
                    flag = False
                    GoTo EditPart
                End If
            ElseIf EWLOCbox.Text = "NEW" And NSLOCbox.Text = "NEW" Then
                If LOC0TableAdapter.ReturnLocationCOUNTedit(AreaName.Text, EWLOCtxt.Text, NSLOCtxt.Text, LOCNUM.Text) <> 0 Then
                    If MsgBox("Location already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new location entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        UndoButton.PerformClick()
                        GoTo ExitEditPart
                    Else
                        NSLOCtxt.Text = ""
                        NSLOCtxt.Focus()
                    End If
                    flag = True   'Don't submit
                Else
                    flag = False
                    GoTo EditPart
                End If
            ElseIf EWLOCbox.Text <> "NEW" And NSLOCbox.Text = "NEW" Then
                If LOC0TableAdapter.ReturnLocationCOUNTedit(AreaName.Text, EWLOCbox.SelectedValue, NSLOCtxt.Text, LOCNUM.Text) <> 0 Then
                    If MsgBox("Location already exists,would you like to go back and change it?" & vbCrLf & "If NO is clicked, new location entry will be ignored", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        UndoButton.PerformClick()
                        GoTo ExitEditPart
                    Else
                        NSLOCtxt.Text = ""
                        NSLOCtxt.Focus()
                    End If
                    flag = True   'Don't submit
                Else
                    flag = False
                    GoTo EditPart
                End If
            End If

EditPart:
            If flag = False Then
                If AreaName.Text = String.Empty Or AreaName.Text = "NEW" Then   'Or AreaName.Text = "NEW",If closed Area_Maint without creating a new area
                    MsgBox("Please select Area")
                    AreaName.DroppedDown = True
                    flag = True
                ElseIf EWLOCbox.Text = String.Empty Then
                    MsgBox("Please enter EW Location")
                    EWLOCbox.DroppedDown = True
                    flag = True
                ElseIf EWLOCbox.SelectedValue = "NEW" And EWLOCtxt.Text = String.Empty Then
                    MsgBox("Please enter EW Location")
                    EWLOCtxt.Focus()
                    flag = True
                ElseIf NSLOCbox.Text = String.Empty Then
                    MsgBox("Please enter NS Location")
                    NSLOCbox.DroppedDown = True
                    flag = True
                ElseIf NSLOCbox.SelectedValue = "NEW" And NSLOCtxt.Text = String.Empty Then
                    MsgBox("Please enter NS Location")
                    NSLOCtxt.Focus()
                    flag = True
                ElseIf TypeDesc.Text = String.Empty Or TypeDesc.Text = "NEW" Then
                    MsgBox("Please select Location Type Description")
                    TypeDesc.DroppedDown = True
                    flag = True
                ElseIf YES.Checked = False And NO.Checked = False Then
                    MsgBox("Please select YES or NO for the Show field")
                    flag = True
                    'Make sure user doesn't bind location to itself if bind is checked
                ElseIf Bind.Checked = True And LOC0TableAdapter.ReturnLOCNUM(BindArea.SelectedValue, BindEWLOC.SelectedValue, BindNSLOC.SelectedValue) = LOCNUM.Text Then
                    MsgBox("Can't bind this location to itself!, change the bind location or uncheck the bind option")
                    flag = True
                Else
                    If YES.Checked = True Then
                        sh = "Y"
                    Else
                        sh = "N"
                    End If

                    If Bind.Checked = True Then
                        BindNum = LOC0TableAdapter.ReturnBindNumber(LOC0TableAdapter.ReturnLOCNUM(BindArea.SelectedValue, BindEWLOC.SelectedValue, BindNSLOC.SelectedValue))
                        If BindNum = 0 Then
                            BindNum = LOC0TableAdapter.ReturnMaxBindNumber + 1
                            LOC0TableAdapter.UpdateBindNumber(BindNum, LOC0TableAdapter.ReturnLOCNUM(BindArea.SelectedValue, BindEWLOC.SelectedValue, BindNSLOC.SelectedValue))
                        End If
                    Else
                        BindNum = 0
                    End If

                    If EWLOCbox.SelectedValue <> "NEW" Then
                        ew = EWLOCbox.Text
                    Else
                        ew = EWLOCtxt.Text
                    End If

                    If NSLOCbox.SelectedValue <> "NEW" Then
                        ns = NSLOCbox.Text
                    Else
                        ns = NSLOCtxt.Text
                    End If

                    If OSNoDate.Checked = True Then
                        OutServDate = SqlTypes.SqlDateTime.Null    'This will enter 1/1/1900 with TableAdapter
                    Else
                        OutServDate = OUTSERV.Value.Date
                    End If

                    LOCKEDITTableAdapter.DeleteAtDescValue("Locations", LOCNUM.Text)   'Release Edit LOCK
                    LOC0TableAdapter.UpdateAtLOCNUM(ew, ns, CUS0TableAdapter.ReturnAREANUM(AreaName.SelectedValue) _
                                                      , AreaName.SelectedValue, sh, LOC1TableAdapter.ReturnTYPENUM(TypeDesc.SelectedValue) _
                                                      , INSERV.Value.Date, OutServDate, BindNum, LOCNUM.Text)

                    'Entering a NULL value in Date if OSNoDate is checked (since it can't be done with TableAdapters)
                    If OSNoDate.Checked = True Then
                        Dim sqlStmt As String
                        Dim conString As String
                        Dim cn As SqlConnection = Nothing
                        Dim cmd As SqlCommand
                        Dim sqldatenull As SqlDateTime
                        Try
                            sqlStmt = "UPDATE LOC0 SET OUTSERV=@OUTSERV WHERE LOCNUM=@LOCNUM"
                            conString = My.Settings.SignalogConnectionString
                            cn = New SqlConnection(conString)
                            cmd = New SqlCommand(sqlStmt, cn)

                            cmd.Parameters.Add(New SqlParameter("@OUTSERV", SqlDbType.Date))
                            cmd.Parameters.Add(New SqlParameter("@LOCNUM", SqlDbType.Int))

                            sqldatenull = SqlDateTime.Null

                            cmd.Parameters("@OUTSERV").Value = sqldatenull
                            cmd.Parameters("@LOCNUM").Value = LOCNUM.Text
                            cn.Open()
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            cn.Close()
                        End Try
                    End If

                    If ISNoDate.Checked = True Then
                        Dim sqlStmt As String
                        Dim conString As String
                        Dim cn As SqlConnection = Nothing
                        Dim cmd As SqlCommand
                        Dim sqldatenull As SqlDateTime
                        Try
                            sqlStmt = "UPDATE LOC0 SET INSERV=@INSERV WHERE LOCNUM=@LOCNUM"
                            conString = My.Settings.SignalogConnectionString
                            cn = New SqlConnection(conString)
                            cmd = New SqlCommand(sqlStmt, cn)

                            cmd.Parameters.Add(New SqlParameter("@INSERV", SqlDbType.Date))
                            cmd.Parameters.Add(New SqlParameter("@LOCNUM", SqlDbType.Int))

                            sqldatenull = SqlDateTime.Null

                            cmd.Parameters("@INSERV").Value = sqldatenull
                            cmd.Parameters("@LOCNUM").Value = LOCNUM.Text
                            cn.Open()
                            cmd.ExecuteNonQuery()
                        Catch ex As Exception
                            MsgBox(ex.Message)
                        Finally
                            cn.Close()
                        End Try
                    End If
                    
                    LOC0TableAdapter.Fill2(Me.SignalogDataSet.LOC0)
                    EWLOCTableAdapter.Fill2(Me.SignalogDataSet.EWLOC)
                    NSLOCTableAdapter.Fill2(Me.SignalogDataSet.NSLOC)
                    EWLOC2TableAdapter.Fill(Me.SignalogDataSet.EWLOC2)
                    NSLOC2TableAdapter.Fill(Me.SignalogDataSet.NSLOC2)
                    BindEWLOCTableAdapter.Fill(Me.SignalogDataSet.BindEWLOC)
                    BindNSLOCTableAdapter.Fill(Me.SignalogDataSet.BindNSLOC)
                    EditRecord = False
                End If
            End If
        End If

ExitEditPart:
        If flag = False Then
            NewButton.Enabled = True
            EditButton.Enabled = True
            DeleteButton.Enabled = True
            UndoButton.Enabled = False
            Label13.Visible = True
            LoadPanel.Enabled = True
            LoadByPanel.Visible = True

            If Filters.Checked = True Then
                LOCNUM.Enabled = False
                LoadPanel.Enabled = True
                bck.Enabled = False
                fwd.Enabled = False
            Else
                LOCNUM.Enabled = True
                LoadPanel.Enabled = False
                bck.Enabled = True
                fwd.Enabled = True
            End If

            AreaName.Enabled = False
            EWLOCbox.Enabled = False
            NSLOCbox.Enabled = False
            EWLOCtxt.Visible = False
            NSLOCtxt.Visible = False
            TypeDesc.Enabled = False
            INSERV.Enabled = False
            ISNoDate.Enabled = False
            OUTSERV.Enabled = False
            OSNoDate.Enabled = False
            YES.Enabled = False
            NO.Enabled = False
            Bind.Enabled = False
            BindArea.Enabled = False
            BindEWLOC.Enabled = False
            BindNSLOC.Enabled = False
            Submit.Enabled = False

            NewRecord = False
            EditRecord = False

            Fill()
            AREA.SelectedValue = LOC0TableAdapter.ReturnAREA(previousId)
            GetArea()
            Fill2()
            EWLOC.SelectedValue = LOC0TableAdapter.ReturnEWLOC(previousId)
            GetEWLOC()
            Fill3()
            NSLOC.SelectedValue = LOC0TableAdapter.ReturnNSLOC(previousId)
            GetNSLOC()
            LoadData()
        End If

        If Trouble_Report.NewEWLOC = True And flag = False Then
            Me.Close()
            Trouble_Report.Text = Trouble_Report.Text & "n"
        End If

        If Trouble_Report.NewNSLOC = True And flag = False Then
            Me.Close()
            Trouble_Report.Text = Trouble_Report.Text & "n"
        End If

    End Sub

    Sub GetArea()
        If Me.SignalogDataSet.CUS0.Rows.Count <> 0 Then
            SelectedArea = AREA.SelectedValue
        Else
            SelectedArea = ""
        End If
    End Sub

    Sub GetEWLOC()
        If Me.SignalogDataSet.EWLOC.Rows.Count <> 0 Then
            SelectedEWLOC = EWLOC.SelectedValue
        Else
            SelectedEWLOC = ""
        End If
    End Sub

    Sub GetNSLOC()
        If Me.SignalogDataSet.NSLOC.Rows.Count <> 0 Then
            SelectedNSLOC = NSLOC.SelectedValue
        Else
            SelectedNSLOC = ""
        End If
    End Sub

    Sub LoadData()
        Try
            Dim ID As Integer
            ID = LOC0TableAdapter.ReturnLOCNUM(SelectedArea, SelectedEWLOC, SelectedNSLOC)

            LOCNUM.Text = ID
            AreaName.Text = SelectedArea
            EWLOCbox.Text = SelectedEWLOC
            NSLOCbox.Text = SelectedNSLOC
            TypeDesc.Text = LOC1TableAdapter.ReturnTYPEDESC(LOC0TableAdapter.ReturnTYPENUM(ID))
            INSERV.Text = Convert.ToString(LOC0TableAdapter.ReturnINSERV(ID))
            OUTSERV.Text = Convert.ToString(LOC0TableAdapter.ReturnOUTSERV(ID))

            If Convert.ToString(LOC0TableAdapter.ReturnOUTSERV(ID)) = String.Empty Then
                OSNoDate.Checked = True
                OUTSERV.CustomFormat = " "
                OUTSERV.Format = DateTimePickerFormat.Custom
            Else
                OSNoDate.Checked = False
                OUTSERV.Format = DateTimePickerFormat.Short
            End If
            If Convert.ToString(LOC0TableAdapter.ReturnINSERV(ID)) = String.Empty Then
                ISNoDate.Checked = True
                INSERV.CustomFormat = " "
                INSERV.Format = DateTimePickerFormat.Custom
            Else
                ISNoDate.Checked = False
                INSERV.Format = DateTimePickerFormat.Short
            End If

            sh = LOC0TableAdapter.ReturnSHOW(ID)
            If sh = "Y" Then
                YES.Checked = True
                NO.Checked = False
            Else
                NO.Checked = True
                YES.Checked = False
            End If
            BindNum = LOC0TableAdapter.ReturnBindNumber(ID)
            If BindNum <> 0 Then
                Bind.Checked = True
                BindLOCNUM = LOC0TableAdapter.ReturnBindLOCNUM(BindNum, LOCNUM.Text)
                BindArea.SelectedValue = LOC0TableAdapter.ReturnAREA(BindLOCNUM)
                BindEWLOC.SelectedValue = LOC0TableAdapter.ReturnEWLOC(BindLOCNUM)
                BindNSLOC.SelectedValue = LOC0TableAdapter.ReturnNSLOC(BindLOCNUM)
            Else
                Bind.Checked = False
            End If
        Catch
        End Try
    End Sub

    Sub Fill()
        If FilterBoth.Checked = True Then
            LOC0TableAdapter.FillByFilter(Me.SignalogDataSet.LOC0, AFilter)
        Else
            If FilterYES.Checked = True Then
                LOC0TableAdapter.FillByFilterSHOW(Me.SignalogDataSet.LOC0, AFilter, "Y")
            Else
                LOC0TableAdapter.FillByFilterSHOW(Me.SignalogDataSet.LOC0, AFilter, "N")
            End If
        End If
    End Sub

    Sub Fill2()
        If FilterBoth.Checked = True Then
            EWLOCTableAdapter.FillByArea2(Me.SignalogDataSet.EWLOC, SelectedArea)
        Else
            If FilterYES.Checked = True Then
                EWLOCTableAdapter.FillByAreaSHOW(Me.SignalogDataSet.EWLOC, SelectedArea, "Y")
            Else
                EWLOCTableAdapter.FillByAreaSHOW(Me.SignalogDataSet.EWLOC, SelectedArea, "N")
            End If
        End If
    End Sub

    Sub Fill3()
        If FilterBoth.Checked = True Then
            NSLOCTableAdapter.FillByEWLOC2(Me.SignalogDataSet.NSLOC, SelectedArea, SelectedEWLOC)
        Else
            If FilterYES.Checked = True Then
                NSLOCTableAdapter.FillByEWLOCSHOW(Me.SignalogDataSet.NSLOC, SelectedArea, SelectedEWLOC, "Y")
            Else
                NSLOCTableAdapter.FillByEWLOCSHOW(Me.SignalogDataSet.NSLOC, SelectedArea, SelectedEWLOC, "N")
            End If
        End If
    End Sub

    Private Sub AreaName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaName.SelectedIndexChanged
        If AreaName.SelectedValue = "NEW" Then
            If Area_Maintenance.Visible = True Then
                MsgBox("Can't open Area Maintenance, form is already open" & vbCrLf & "Please close Area Maintenance and retry", MsgBoxStyle.Exclamation)
            Else
                NewArea = True
                Area_Maintenance.ShowDialog()
            End If
        Else
            EWLOC2TableAdapter.FillByArea(Me.SignalogDataSet.EWLOC2, AreaName.SelectedValue)
            NSLOC2TableAdapter.FillByAreaEWLOC(Me.SignalogDataSet.NSLOC2, AreaName.SelectedValue, EWLOCbox.SelectedValue)
        End If

    End Sub

    Private Sub EWLOCbox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EWLOCbox.SelectedIndexChanged
        If EWLOCbox.SelectedValue = "NEW" Then
            EWLOCtxt.Visible = True
            EWLOCtxt.Text = String.Empty
            NSLOCbox.SelectedValue = "NEW"
        Else
            EWLOCtxt.Visible = False
            NSLOC2TableAdapter.FillByAreaEWLOC(Me.SignalogDataSet.NSLOC2, AreaName.SelectedValue, EWLOCbox.SelectedValue)
        End If

    End Sub

    Private Sub NSLOCbox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NSLOCbox.SelectedIndexChanged
        If NSLOCbox.SelectedValue = "NEW" Then
            NSLOCtxt.Visible = True
            NSLOCtxt.Text = String.Empty
        Else
            NSLOCtxt.Visible = False
        End If
    End Sub

    Private Sub Bind_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bind.CheckedChanged
        If Bind.Checked = True Then
            BindArea.Visible = True
            BindEWLOC.Visible = True
            BindNSLOC.Visible = True
            Label14.Visible = True
            Label15.Visible = True
            Label16.Visible = True
            'Get location bound to, LAST (according to MAX(ID) and [Bind Number]) if more than a location
            BindLOCNUM = LOC0TableAdapter.ReturnBindLOCNUM(BindNum, LOCNUM.Text)
            BindArea.SelectedValue = LOC0TableAdapter.ReturnAREA(BindLOCNUM)
            BindEWLOC.SelectedValue = LOC0TableAdapter.ReturnEWLOC(BindLOCNUM)
            BindNSLOC.SelectedValue = LOC0TableAdapter.ReturnNSLOC(BindLOCNUM)
        Else
            BindArea.Visible = False
            BindEWLOC.Visible = False
            BindNSLOC.Visible = False
            Label14.Visible = False
            Label15.Visible = False
            Label16.Visible = False
        End If
    End Sub

    Private Sub BindArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindArea.SelectedIndexChanged
        BindEWLOCTableAdapter.FillByArea(Me.SignalogDataSet.BindEWLOC, BindArea.SelectedValue)
        BindNSLOCTableAdapter.FillByAreaEWLOC(Me.SignalogDataSet.BindNSLOC, BindArea.SelectedValue, BindEWLOC.SelectedValue)
    End Sub

    Private Sub BindEWLOC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindEWLOC.SelectedIndexChanged
        BindNSLOCTableAdapter.FillByAreaEWLOC(Me.SignalogDataSet.BindNSLOC, BindArea.SelectedValue, BindEWLOC.SelectedValue)
    End Sub

    Private Sub TypeDesc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TypeDesc.SelectedIndexChanged
        If TypeDesc.SelectedValue = "NEW" Then
            If Location_Type_Description_Maintenance.Visible = True Then
                MsgBox("Can't open Location Type Description Maintenance, form is already open" & vbCrLf & "Please close Location Type Description Maintenance and retry", MsgBoxStyle.Exclamation)
            Else
                NewTypeDesc = True
                Location_Type_Description_Maintenance.ShowDialog()
            End If
        End If
    End Sub

    Private Sub Locations_Maintenance_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        If Trouble_Report.NewEWLOC = True Then
            Me.NewButton.PerformClick()
            Me.YES.Checked = True
            Me.AreaName.Text = Trouble_Report.Area
            Me.EWLOCbox.SelectedValue = "NEW"
            Me.NSLOCbox.SelectedValue = "NEW"
        ElseIf Trouble_Report.NewNSLOC = True Then
            Me.NewButton.PerformClick()
            Me.YES.Checked = True
            Me.AreaName.Text = Trouble_Report.Area
            Me.EWLOCbox.Text = Trouble_Report.EWLOC
            Me.NSLOCbox.SelectedValue = "NEW"
        End If
    End Sub


    Private Sub Locations_Maintenance_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.TextChanged
        Me.Text = "Locations Maintenance"
        If NewTypeDesc = True Then
            NewTypeDesc = False
            Me.LOC1TableAdapter.Fill(Me.SignalogDataSet.LOC1)
            Try
                TypeDesc.SelectedValue = LOC1TableAdapter.ReturnTYPEDESC(LOC1TableAdapter.ReturnMAXTYPENUM - 1)
            Catch
            End Try
        End If

        If NewArea = True Then
            NewArea = False
            CUS0TableAdapter.Fill(Me.SignalogDataSet.CUS0)
            Try
                AreaName.SelectedValue = CUS0TableAdapter.ReturnAreaName(CUS0TableAdapter.ReturnMAXAREANUM - 1)
            Catch
            End Try
        End If
    End Sub

    Private Sub OSNoDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OSNoDate.CheckedChanged
        If EditRecord = True Or NewRecord = True Then
            If OSNoDate.Checked = True Then
                OUTSERV.Enabled = False
                OUTSERV.CustomFormat = " "
                OUTSERV.Format = DateTimePickerFormat.Custom
            Else
                OUTSERV.Enabled = True
                OUTSERV.Format = DateTimePickerFormat.Short
            End If
        End If
    End Sub

    Private Sub ISNoDate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ISNoDate.CheckedChanged
        If EditRecord = True Or NewRecord = True Then
            If ISNoDate.Checked = True Then
                INSERV.Enabled = False
                INSERV.CustomFormat = " "
                INSERV.Format = DateTimePickerFormat.Custom
            Else
                INSERV.Enabled = True
                INSERV.Format = DateTimePickerFormat.Short
            End If
        End If
    End Sub

End Class
