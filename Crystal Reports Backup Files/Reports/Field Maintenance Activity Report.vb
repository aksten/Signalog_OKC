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

Public Class Field_Maintenance_Activity_Report
    Dim SelectedArea, SelectedEWloc, SelectedNSloc As String
    Dim DISPNUM, EMPNUM As Integer
    Dim ENTER_BY, VEH_NUM As String
    Public Activity_Code(0 To 19, 0 To 6) As String  '6 stores ACTCAT not memo
    Public CallFromReport As Boolean
    Public RepProbEdit, ArrConEdit, ActTakEdit, DefActEdit, DepConEdit As Boolean

    Private Sub Field_Maintenance_Activity_Report_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.VEHICLETableAdapter.Fill2(Me.SignalogDataSet2.VEHICLE)
        Me.PERS01TableAdapter.Fill(Me.SignalogDataSet.PERS01)
        Me.PERS0TableAdapter.Fill2(Me.SignalogDataSet.PERS0)
        Me.DISP0TableAdapter.Fill3(Me.SignalogDataSet1.DISP0)
        Me.LOC0TableAdapter.Fill2(SignalogDataSet.LOC0)
        Me.CUS0TableAdapter.Fill2(Me.SignalogDataSet.CUS0)
        Me.AREANAMETableAdapter.Fill(Me.SignalogDataSet.AREANAME)

        SelectedArea = Area.Text
        Me.EWLOCTableAdapter.FillByArea3(Me.SignalogDataSet.EWLOC, SelectedArea)
        SelectedEWloc = EWLOC.Text
        Me.NSLOCTableAdapter.FillByEWLOC3(Me.SignalogDataSet.NSLOC, SelectedArea, SelectedEWloc)
        SelectedNSloc = NSLOC.Text

        DISPNUM = DISP0TableAdapter.ReturnDISPNUM(DispBy.Text)
        ENTER_BY = PERS0TableAdapter.ReturnEMPNUM(EnterBy.Text)
        EMPNUM = PERS0TableAdapter.ReturnEMPNUM(Technician.Text)
        VEH_NUM = VehNum.Text

        EWLOCAll.Checked = True
        NSLOCAll.Checked = True
        FilterYES.Checked = True
        LaborBoth.Checked = True
        AnnInsYes.Checked = True

        RepByAll.Checked = True
        EnterByAll.Checked = True
        TechAll.Checked = True
        VehNumAll.Checked = True
        IssueDateAll.Checked = True
        EndWorkDateAll.Checked = False

        Dim i, j As Integer   'Reset 
        For i = 0 To 19
            For j = 0 To 6
                Activity_Code(i, j) = String.Empty
            Next
        Next i

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewReport.Click
        ViewReport.Enabled = False
        Dim con, cmd As String
        con = My.Settings.SignalogConnectionString
        Dim myDataAdapter As SqlDataAdapter
        Dim ACT1_FILTER As New ArrayList

        ACT1_FILTER.Clear()
        If Activity_Code(0, 0) <> String.Empty Or AnnInsNo.Checked = True Then   'There is at least one activity filtering record and/or we want to exclude ANNUAL INSPECTION
            Dim j As Integer
            j = 0
            cmd = "Select ACTNUM FROM ACT1 "

            For i = 0 To 19
                If Activity_Code(i, 0) <> String.Empty Then
                    j += 1
                    If j = 1 Then
                        cmd += "WHERE "
                    Else
                        cmd += "AND "
                    End If
                    cmd += "(ACTNUM IN ( SELECT ACTNUM FROM ACT1 WHERE (ACTCAT='" & Activity_Code(i, 6) & "'" & " AND ACT1.ASUB1='" & Activity_Code(i, 0) & "' "
                    If Activity_Code(i, 1) <> String.Empty Then
                        cmd += "AND ACT1.ASUB2='" & Activity_Code(i, 1) & "' "
                    End If

                    If Activity_Code(i, 2) <> String.Empty Then
                        cmd += "AND ACT1.ASUB3='" & Activity_Code(i, 2) & "' "
                    End If

                    If Activity_Code(i, 3) <> String.Empty Then
                        cmd += "AND ACT1.ASUB4='" & Activity_Code(i, 3) & "' "
                    End If

                    If Activity_Code(i, 4) <> String.Empty Then
                        cmd += "AND ACT1.ASUB5='" & Activity_Code(i, 4) & "' "
                    End If

                    If Activity_Code(i, 5) <> String.Empty Then
                        cmd += "AND ACT1.ASUB6='" & Activity_Code(i, 5) & "' "
                    End If
                    cmd += ") "
                End If
            Next i

            If AnnInsNo.Checked = True Then
                Dim actcode As String
                actcode = ASUBTableAdapter.ReturnACTCODE("ANNUAL INSPECTION")
                If Activity_Code(0, 0) <> String.Empty Then
                    cmd += "AND"
                Else
                    cmd += "WHERE"
                End If
                cmd += " (ACTNUM NOT IN ( SELECT ACTNUM FROM ACT1 WHERE (ACTCAT='1' AND ASUB1='" & actcode & "')))"
            End If

            For i = 1 To j
                cmd += "))"
            Next

            cmd += " GROUP BY ACTNUM"

            SignalogDataSet.ACT1.Clear()
            myDataAdapter = New SqlDataAdapter(cmd, con)
            myDataAdapter.Fill(SignalogDataSet.ACT1)

            For i = 0 To SignalogDataSet.ACT1.Rows.Count - 1
                ACT1_FILTER.Add(SignalogDataSet.ACT1.Rows(i)(0))

            Next i
        End If

        '--------------------------------------------------------------------------------------------------------------------------------
        cmd = "Select ACT0.ACTNUM, ACT0.ENDWRK_DT, ACT0.LOCNUM, ACT0.VEHSTART, ACT0.VEHEND FROM ACT0, LOC0, ACT9 "
        cmd += "WHERE ACT0.LOCNUM=LOC0.LOCNUM "

        If ACT1_FILTER.Count <> 0 Then
            cmd += "AND ACT0.ACTNUM IN ("
            For i = 0 To ACT1_FILTER.Count - 1
                If i = ACT1_FILTER.Count - 1 Then
                    cmd += ACT1_FILTER.Item(i).ToString & ") "
                Else
                    cmd += ACT1_FILTER.Item(i).ToString & ","
                End If
            Next i
        End If

        If AreaAll.Checked = False Then
            cmd += "AND LOC0.AREA='" & SelectedArea & "' "
        End If

        cmd += "AND ACT0.ACTNUM=ACT9.ACTNUM "
        If EWLOCAll.Checked = False Then
            cmd += "AND LOC0.EWLOC='" & SelectedEWloc & "' "
        End If

        If NSLOCAll.Checked = False Then
            cmd += "AND LOC0.NSLOC='" & SelectedNSloc & "' "
        End If

        If RepByAll.Checked = False Then
            cmd += "AND ACT0.DISPNUM='" & DISPNUM & "' "
        End If

        If EnterByAll.Checked = False Then
            cmd += "AND ACT0.ENTERBY='" & ENTER_BY & "' "
        End If

        If TechAll.Checked = False Then
            cmd += "AND ACT0.EMPNUM='" & EMPNUM & "' "
        End If

        If VehNumAll.Checked = False Then
            cmd += "AND ACT0.VEHNUM='" & VEH_NUM & "' "
        End If

        If IssueDateAll.Checked = False Then
            cmd += "AND ACT0.DATEISSUE BETWEEN '" & BIssueDate.Text & "' AND '" & EIssueDate.Text & "' "
        End If

        If EndWorkDateAll.Checked = False Then
            cmd += "AND ACT0.ENDWRK_DT BETWEEN '" & BEndWorkDate.Text & "' AND '" & EEndWorkDate.Text & "' "
        End If

        If FilterYES.Checked = True Then
            cmd += "AND ACT0.SHOW='Y' "
        End If

        If FilterNO.Checked = True Then
            cmd += "AND ACT0.SHOW='N' "
        End If

        If RegTime.Checked = True Then  'Regular time only
            cmd += "AND ACT9.REGHRS <> 0 AND ACT9.OTHRS = 0 "
        End If

        If OverTime.Checked = True Then  'Over time only
            cmd += "AND ACT9.OTHRS <> 0 AND ACT9.REGHRS = 0 "
        End If

        cmd += " ORDER BY ACTNUM"

        myDataAdapter = New SqlDataAdapter(cmd, con)
        Me.SignalogDataSet.ACT0.Clear()
        myDataAdapter.Fill(SignalogDataSet.ACT0)

        ACT0_RPTTableAdapter.DeleteAll()
        Dim locnum, MaintCont As String
        Dim Miles, BegMile, EndMile As Integer
        Dim MilesRate, MilesFee As Decimal
        For i = 0 To SignalogDataSet.ACT0.Rows.Count - 1
            locnum = SignalogDataSet.ACT0.Rows(i)(13)

            BegMile = 0
            EndMile = 0
            BegMile = SignalogDataSet.ACT0.Rows(i)(18)
            EndMile = SignalogDataSet.ACT0.Rows(i)(19)
            Miles = EndMile - BegMile

            MilesRate = CUS0TableAdapter.ReturnMileageRate(LOC0TableAdapter.ReturnAREANUM(locnum))

            MaintCont = CUS0TableAdapter.ReturnMaintCont(LOC0TableAdapter.ReturnAREANUM(locnum))
            If MaintCont = "Y" Then   'First 80 files free of charge for customers that are on maintenance contract
                If Miles <= 80 Then
                    MilesFee = 0
                Else
                    MilesFee = MilesRate * (Miles - 80)
                End If
            Else  'Mileage fee = miles*rate per mile  for non-contract customers
                MilesFee = Miles * MilesRate
            End If

            ACT0_RPTTableAdapter.Insert(SignalogDataSet.ACT0.Rows(i)(0), SignalogDataSet.ACT0.Rows(i)(16), locnum, Miles, MilesRate, MilesFee)
        Next
        ACT0_RPTTableAdapter.Fill(SignalogDataSet.ACT0_RPT)
        '-------------------------------------------------------------------------------------------------------------------------
        cmd = "Select * FROM ACT1,ACT0_RPT WHERE ACT1.ACTNUM=ACT0_RPT.ACTNUM"
        SignalogDataSet.ACT1.Clear()
        myDataAdapter = New SqlDataAdapter(cmd, con)
        myDataAdapter.Fill(SignalogDataSet.ACT1)

        ACT1_RPTTableAdapter.DeleteAll()
        Dim desc As String = String.Empty
        Dim s1, s2, s3, s4, s5, s6 As String
        Dim d1, d2, d3, d4, d5, d6 As String
        Dim actcat As Integer
        Dim category As String

        For i = 0 To SignalogDataSet.ACT1.Rows.Count - 1
            actcat = SignalogDataSet.ACT1.Rows(i)(1)
            desc = String.Empty
            Select Case actcat
                Case 1
                    category = "Reported Problem:"
                Case 2
                    category = "Arrival Condition:"
                Case 3
                    category = "Action Taken:"
                Case 4
                    category = "Deferred Action:"
                Case 5
                    category = "Departing Condition:"
            End Select

            s1 = SignalogDataSet.ACT1.Rows(i)(2)
            s2 = SignalogDataSet.ACT1.Rows(i)(3)
            s3 = SignalogDataSet.ACT1.Rows(i)(4)
            s4 = SignalogDataSet.ACT1.Rows(i)(5)
            s5 = SignalogDataSet.ACT1.Rows(i)(6)
            s6 = SignalogDataSet.ACT1.Rows(i)(7)

            d1 = ASUBTableAdapter.RetrunDESC(s1)
            d2 = ASUBTableAdapter.RetrunDESC(s2)
            d3 = ASUBTableAdapter.RetrunDESC(s3)
            d4 = ASUBTableAdapter.RetrunDESC(s4)
            d5 = ASUBTableAdapter.RetrunDESC(s5)
            d6 = ASUBTableAdapter.RetrunDESC(s6)

            If s1 <> String.Empty Then
                If s2 = String.Empty Then
                    desc += d1
                Else
                    desc += d1 & ", "
                End If
            End If

            If s2 <> String.Empty Then
                If s3 = String.Empty Then
                    desc += d2
                Else
                    desc += d2 & ", "
                End If
            End If

            If s3 <> String.Empty Then
                If s4 = String.Empty Then
                    desc += d3
                Else
                    desc += d3 & ", "
                End If
            End If

            If s4 <> String.Empty Then
                If s5 = String.Empty Then
                    desc += d4
                Else
                    desc += d4 & ", "
                End If
            End If

            If s5 <> String.Empty Then
                If s6 = String.Empty Then
                    desc += d5
                Else
                    desc += d5 & ", "
                End If
            End If

            If s6 <> String.Empty Then
                desc += d6
            End If

            ACT1_RPTTableAdapter.Insert(SignalogDataSet.ACT1.Rows(i)(0), category, desc, Convert.ToString(SignalogDataSet.ACT1.Rows(i)(8)) & ".")
        Next
        ACT1_RPTTableAdapter.Fill(SignalogDataSet.ACT1_RPT)
        '-------------------------------------------------------------------------------------------------------------------------
        cmd = "Select * FROM ACT2,ACT0_RPT WHERE ACT2.ACTNUM=ACT0_RPT.ACTNUM"
        SignalogDataSet.ACT2.Clear()
        myDataAdapter = New SqlDataAdapter(cmd, con)
        myDataAdapter.Fill(SignalogDataSet.ACT2)
        '-------------------------------------------------------------------------------------------------------------------------
        cmd = "Select * FROM ACT3,ACT0_RPT WHERE ACT3.ACTNUM=ACT0_RPT.ACTNUM"
        SignalogDataSet.ACT3.Clear()
        myDataAdapter = New SqlDataAdapter(cmd, con)
        myDataAdapter.Fill(SignalogDataSet.ACT3)

        PartsIns_RPTTableAdapter.DeleteAll()
        PartsRem_RPTTableAdapter.DeleteAll()
        Dim PartID, InsRem, PartSrc As Integer
        Dim PartNumber, PartDesc, PartSerial, Warehouse, src As String

        For i = 0 To SignalogDataSet.ACT3.Rows.Count - 1
            PartID = SignalogDataSet.ACT3.Rows(i)(1)
            InsRem = SignalogDataSet.ACT3.Rows(i)(2)
            PartSrc = SignalogDataSet.ACT3.Rows(i)(4)
            Warehouse = SignalogDataSet.ACT3.Rows(i)(8)

            If PartSrc = 1 Then    'Local
                src = "STI"
                PartDesc = EQUIPMENTTableAdapter.ReturnPartDesc(PartID, Warehouse)
                PartSerial = EQUIPMENTTableAdapter.ReturnSerial(PartID, Warehouse)
                If PartSerial = "None" Then
                    PartSerial = "NA"
                End If
            Else    'City Owned
                src = "CO"
                PartDesc = EQUIPMENT2TableAdapter.ReturnPartDesc(PartID)
                PartSerial = EQUIPMENT2TableAdapter.ReturnSerial(PartID)
                If PartSerial = "None" Then
                    PartSerial = "NA"
                End If
                'Warehouse = "NA"
            End If

            PartNumber = Parts_ListTableAdapter.ReturnPartNumAtDesc(PartDesc)

            'If Warehouse = "TUL" Then
            '    Warehouse = "Tulsa"
            'ElseIf Warehouse = "OKC" Then
            '    Warehouse = "Oklahoma City"
            'ElseIf Warehouse = "ARK" Then
            '    Warehouse = "Arkansas"
            'End If

            If InsRem = 1 Then    'Installed
                PartsIns_RPTTableAdapter.Insert(SignalogDataSet.ACT3.Rows(i)(0), PartNumber, PartDesc, PartSerial, src _
                                                 , SignalogDataSet.ACT3.Rows(i)(7), SignalogDataSet.ACT3.Rows(i)(5) _
                                                 , SignalogDataSet.ACT3.Rows(i)(7) * SignalogDataSet.ACT3.Rows(i)(5) _
                                                 , SignalogDataSet.ACT3.Rows(i)(6))
            Else    'Removed
                PartsRem_RPTTableAdapter.Insert(SignalogDataSet.ACT3.Rows(i)(0), PartNumber, PartDesc, PartSerial, src _
                                                  , SignalogDataSet.ACT3.Rows(i)(6))
            End If
        Next
        PartsIns_RPTTableAdapter.Fill(SignalogDataSet.PartsIns_RPT)
        PartsRem_RPTTableAdapter.Fill(SignalogDataSet.PartsRem_RPT)
        '-------------------------------------------------------------------------------------------------------------------------
        cmd = "Select * FROM ACT9,ACT0_RPT WHERE ACT9.ACTNUM=ACT0_RPT.ACTNUM"
        SignalogDataSet.ACT9.Clear()
        myDataAdapter = New SqlDataAdapter(cmd, con)
        myDataAdapter.Fill(SignalogDataSet.ACT9)
        '-------------------------------------------------------------------------------------------------------------------------
        'Passing a value from winform to Crystal Report
        Dim param1Fields As New CrystalDecisions.Shared.ParameterFields
        Dim param1Field As New CrystalDecisions.Shared.ParameterField
        Dim param1Range As New CrystalDecisions.Shared.ParameterDiscreteValue

        param1Field.ParameterFieldName = "Report_Period" ' Parameter Name In Crystal Report
        If EndWorkDateAll.Checked = True Then
            param1Range.Value = "All" ' Value For Parameter Field 
        Else
            param1Range.Value = MonthName(BEndWorkDate.Value.Month) & " " & BEndWorkDate.Value.Day & ", " & BEndWorkDate.Value.Year & " - "
            param1Range.Value += MonthName(EEndWorkDate.Value.Month) & " " & EEndWorkDate.Value.Day & ", " & EEndWorkDate.Value.Year
        End If
        param1Field.CurrentValues.Add(param1Range)
        param1Fields.Add(param1Field) ' To add parameter in parameterslist
        Report_Viewer.CrystalReportViewer1.ParameterFieldInfo = param1Fields 'To pass parameter inf.to CRV (Crystal Report Viewer)
        '-------------------------------------------------------------------------------------------------------------------------
        field_Maintenance_Activity1.SetDataSource(Me.SignalogDataSet)
        Report_Viewer.CrystalReportViewer1.ReportSource = field_Maintenance_Activity1
        Report_Viewer.CrystalReportViewer1.Refresh()
        Report_Viewer.Text = "Field Maintenance Activity Report"
        Report_Viewer.ShowDialog()
    End Sub

    Private Sub CityAgency_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Area.SelectedIndexChanged
        SelectedArea = Area.Text
        Me.EWLOCTableAdapter.FillByArea3(Me.SignalogDataSet.EWLOC, SelectedArea)
        SelectedEWloc = EWLOC.Text
        Me.NSLOCTableAdapter.FillByEWLOC3(Me.SignalogDataSet.NSLOC, SelectedArea, SelectedEWloc)
        SelectedNSloc = NSLOC.Text
    End Sub

    Private Sub EWLOCAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EWLOCAll.CheckedChanged
        If EWLOCAll.Checked = True Then
            EWLOC.Enabled = False
        Else
            EWLOC.Enabled = True
        End If
    End Sub

    Private Sub NSLOCAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NSLOCAll.CheckedChanged
        If NSLOCAll.Checked = True Then
            NSLOC.Enabled = False
        Else
            NSLOC.Enabled = True
        End If
    End Sub

    Private Sub EWLOC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EWLOC.SelectedIndexChanged
        SelectedEWloc = EWLOC.Text
        Me.NSLOCTableAdapter.FillByEWLOC3(Me.SignalogDataSet.NSLOC, SelectedArea, SelectedEWloc)
        SelectedNSloc = NSLOC.Text
    End Sub

    Private Sub NSLOC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NSLOC.SelectedIndexChanged
        SelectedNSloc = NSLOC.Text
    End Sub

    Private Sub IssueDateNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IssueDateAll.CheckedChanged
        If IssueDateAll.Checked = True Then
            BIssueDate.Enabled = False
            EIssueDate.Enabled = False
        Else
            BIssueDate.Enabled = True
            EIssueDate.Enabled = True
        End If
    End Sub

    Private Sub EndWorkDateNone_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndWorkDateAll.CheckedChanged
        If EndWorkDateAll.Checked = True Then
            BEndWorkDate.Enabled = False
            EEndWorkDate.Enabled = False
        Else
            BEndWorkDate.Enabled = True
            EEndWorkDate.Enabled = True
        End If
    End Sub

    Private Sub RepByAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RepByAll.CheckedChanged
        If RepByAll.Checked = True Then
            DispBy.Enabled = False
        Else
            DispBy.Enabled = True
        End If
    End Sub

    Private Sub EnterByAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterByAll.CheckedChanged
        If EnterByAll.Checked = True Then
            EnterBy.Enabled = False
        Else
            EnterBy.Enabled = True
        End If
    End Sub

    Private Sub TechAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TechAll.CheckedChanged
        If TechAll.Checked = True Then
            Technician.Enabled = False
        Else
            Technician.Enabled = True
        End If
    End Sub

    Private Sub VehNumAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehNumAll.CheckedChanged
        If VehNumAll.Checked = True Then
            VehNum.Enabled = False
        Else
            VehNum.Enabled = True
        End If
    End Sub

    Private Sub DispBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispBy.SelectedIndexChanged
        DISPNUM = DISP0TableAdapter.ReturnDISPNUM(DispBy.Text)
    End Sub

    Private Sub EnterBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnterBy.SelectedIndexChanged
        ENTER_BY = PERS0TableAdapter.ReturnEMPNUM(EnterBy.Text)
    End Sub

    Private Sub Technician_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Technician.SelectedIndexChanged
        EMPNUM = PERS0TableAdapter.ReturnEMPNUM(Technician.Text)
    End Sub

    Private Sub VehNum_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehNum.SelectedIndexChanged
        VEH_NUM = VehNum.Text
    End Sub

    Private Sub AreaAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaAll.CheckedChanged
        If AreaAll.Checked = True Then
            Area.Enabled = False
        Else
            Area.Enabled = True
        End If
    End Sub

    Private Sub ActivityGrid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ActivityGrid.CellDoubleClick
        CallFromReport = True
        
        If ActivityGrid.CurrentRow.Cells(0).Value = "Reported Problem" Then
            If ActivityGrid.CurrentRow.Cells(1).Value = String.Empty Then   'If a new record
                RepProbEdit = False
            Else
                RepProbEdit = True
            End If
            Problem_Reported.ShowDialog()
        ElseIf ActivityGrid.CurrentRow.Cells(0).Value = "Arrival Condition" Then
            If ActivityGrid.CurrentRow.Cells(1).Value = String.Empty Then   'If a new record
                ArrConEdit = False
            Else
                ArrConEdit = True
            End If
            Arrival_Condition.ShowDialog()
        ElseIf ActivityGrid.CurrentRow.Cells(0).Value = "Action Taken" Then
            If ActivityGrid.CurrentRow.Cells(1).Value = String.Empty Then   'If a new record
                ActTakEdit = False
            Else
                ActTakEdit = True
            End If
            Action_Taken.ShowDialog()
        ElseIf ActivityGrid.CurrentRow.Cells(0).Value = "Deferred Action" Then
            If ActivityGrid.CurrentRow.Cells(1).Value = String.Empty Then   'If a new record
                DefActEdit = False
            Else
                DefActEdit = True
            End If
            Deferred_Action.ShowDialog()
        ElseIf ActivityGrid.CurrentRow.Cells(0).Value = "Departing Condition Notes" Then
            If ActivityGrid.CurrentRow.Cells(1).Value = String.Empty Then   'If a new record
                DepConEdit = False
            Else
                DepConEdit = True
            End If
            Departing_Condition_Notes.ShowDialog()
        ElseIf ActivityGrid.CurrentRow.Cells(0).Value = Nothing Then
            MsgBox("Please select Activity Type", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub ActivityGrid_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles ActivityGrid.UserDeletingRow
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to delete this activity entry?", MsgBoxStyle.YesNo, "Delete Row?")
        If result = MsgBoxResult.Yes Then
            If (ActivityGrid.Rows.Count - 1) > 1 And (ActivityGrid.CurrentRow.Index + 1) <> (ActivityGrid.Rows.Count - 1) Then
                For i = (ActivityGrid.CurrentRow.Index + 1) To (ActivityGrid.Rows.Count - 2)  'shift records to take deleted record place
                    For j = 0 To 6
                        Activity_Code(i - 1, j) = Activity_Code(i, j)
                    Next j
                Next i
                For j = 0 To 6  'empty last record
                    Activity_Code(ActivityGrid.Rows.Count - 2, j) = String.Empty
                Next j
            Else
                For j = 0 To 6   'delete first(and only record) or last record in panel without shifting
                    Activity_Code(ActivityGrid.CurrentRow.Index, j) = String.Empty
                Next j
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ActivityGrid_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles ActivityGrid.UserDeletedRow
        ActivityGrid.CurrentRow.Selected = False
    End Sub

End Class