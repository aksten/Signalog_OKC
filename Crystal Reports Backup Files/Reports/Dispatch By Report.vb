Imports System.Data.SqlClient
Public Class Dispatch_By_Report
    Dim FirstSel As Boolean
    Private Sub Dispatch_By_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DispBySEQTableAdapter.Fill(Me.SignalogDataSet.DispBySEQ)
        SeqAll.Checked = True
        FilterBoth.Checked = True
        SortID.Checked = True
        OrderAsc.Checked = True
        FieldsAll.Checked = True
        FirstSel = True
    End Sub

    Private Sub Generate_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Generate_Report.Click
        If SeqAll.Checked = False And SeqFilter.Text = String.Empty Then
            MsgBox("Please choose sequence number under filtering or check ALL to select all sequence numbers", MsgBoxStyle.Exclamation, "Missing Info")
        ElseIf RptFields.SelectedIndex = -1 Then  'No item selected
            MsgBox("Please select at least one item to view on the report", MsgBoxStyle.Exclamation, "No Items Selected!")
        Else
            Dim con, cmd As String
            con = My.Settings.SignalogConnectionString

            'Constructing the SQL command according to user selections
            cmd = "SELECT"
            If FieldsAll.Checked = True Then
                cmd += " *"
            Else
                If RptFields.GetSelected(0) = True Then
                    cmd += " DISPNUM"
                    FirstSel = False
                Else
                    'Suppress IDtxt field in section 1 and update the location of other fields
                End If
                If RptFields.GetSelected(1) = True Then
                    If FirstSel = True Then
                        cmd += " DISPBY"
                        FirstSel = False
                    Else
                        cmd += ", DISPBY"
                    End If
                End If
                If RptFields.GetSelected(2) = True Then
                    If FirstSel = True Then
                        cmd += " SEQ"
                        FirstSel = False
                    Else
                        cmd += ", SEQ"
                    End If
                End If
                If RptFields.GetSelected(3) = True Then
                    If FirstSel = True Then
                        cmd += " SHOW"
                        FirstSel = False
                    Else
                        cmd += ", SHOW"
                    End If
                End If
            End If

            cmd += " FROM DISP0 WHERE DISPBY<>'NEW'"
            If SeqAll.Checked = False Then       'Filtering
                cmd += " AND SEQ='" & SeqFilter.SelectedValue & "'"
            End If
            If FilterYES.Checked = True Then
                cmd += " AND SHOW='Y'"
            ElseIf FilterNO.Checked = True Then
                cmd += " AND SHOW='N'"

            End If

            If SortID.Checked = True Then         'Sorting
                cmd += " ORDER BY DISPNUM"
            ElseIf SortDispBy.Checked = True Then
                cmd += " ORDER BY DISPBY"
            ElseIf SortSeq.Checked = True Then
                cmd += " ORDER BY SEQ"
            ElseIf SortShow.Checked = True Then
                cmd += " ORDER BY SHOW"
            End If
            If OrderDesc.Checked = True Then
                cmd += " DESC"
            End If

            FirstSel = True   'To reset for the next SQL command

            Dim myDataAdapter As New SqlDataAdapter(cmd, con)
            SignalogDataSet.DISP0.Clear()
            myDataAdapter.Fill(SignalogDataSet.DISP0)

            dispatch_By1.SetDataSource(Me.SignalogDataSet)
            Report_Viewer.CrystalReportViewer1.ReportSource = dispatch_By1
            Report_Viewer.CrystalReportViewer1.Refresh()
            Report_Viewer.Text = "Dispatch By Report"
            Report_Viewer.ShowDialog()

        End If
    End Sub

    Private Sub SeqAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeqAll.CheckedChanged
        If SeqAll.Checked = True Then
            SeqFilter.Enabled = False
            SeqFilter.Text = ""
        Else
            SeqFilter.Enabled = True
        End If
    End Sub

    Private Sub FieldsAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldsAll.CheckedChanged
        If FieldsAll.Checked = True Then
            RptFields.Enabled = False
            RptFields.SetSelected(0, True)
            RptFields.SetSelected(1, True)
            RptFields.SetSelected(2, True)
            RptFields.SetSelected(3, True)
        Else
            RptFields.Enabled = True
            RptFields.SetSelected(0, False)
            RptFields.SetSelected(1, False)
            RptFields.SetSelected(2, False)
            RptFields.SetSelected(3, False)
        End If
    End Sub

End Class