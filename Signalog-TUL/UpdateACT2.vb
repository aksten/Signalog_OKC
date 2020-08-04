Public Class UpdateACT2
    Dim i, j, k, l As Integer
    Dim s1, s2, s3, s4, s5, s6 As String
    Dim lnklabel(0 To 5) As String
    Dim memonum, group As Integer
    Dim max As Integer
    Private Sub Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Click
        Start.Enabled = False
        Statuslbl.Text = String.Empty

        BackgroundWorker1.RunWorkerAsync()

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        max = ACT0TableAdapter.ReturnMaxACTNUM

        For i As Integer = 1 To max
            memonum = 0
            For l As Integer = 1 To 5    'ACTCAT
                group = 0
                Try    'In case activity doesn't exist
                    For j As Integer = 1 To ACT1TableAdapter.ReturnRecords(i, l)
                        s1 = ACT1TableAdapter.ReturnASUB1(i, l, j)  'Loading activity codes
                        s2 = ACT1TableAdapter.ReturnASUB2(i, l, j)
                        s3 = ACT1TableAdapter.ReturnASUB3(i, l, j)
                        s4 = ACT1TableAdapter.ReturnASUB4(i, l, j)
                        s5 = ACT1TableAdapter.ReturnASUB5(i, l, j)
                        s6 = ACT1TableAdapter.ReturnASUB6(i, l, j)
                        lnklabel(0) = ASUBTableAdapter.ReturnLNKLABEL(s1)  'Loading LNKLABEL for each activity
                        lnklabel(1) = ASUBTableAdapter.ReturnLNKLABEL(s2)
                        lnklabel(2) = ASUBTableAdapter.ReturnLNKLABEL(s3)
                        lnklabel(3) = ASUBTableAdapter.ReturnLNKLABEL(s4)
                        lnklabel(4) = ASUBTableAdapter.ReturnLNKLABEL(s5)
                        lnklabel(5) = ASUBTableAdapter.ReturnLNKLABEL(s6)
                        group += 1
                        For k As Integer = 0 To 5    ' checking for MEMO in LNKLABEL
                            If lnklabel(k) = "MEMO" Then
                                memonum += 1   'To keep track of memonum
                                ACT2TableAdapter.UpdateActcatGroup(l, group, i, memonum)
                            End If
                        Next k
                    Next j
                Catch
                End Try
            Next l
            BackgroundWorker1.ReportProgress((i / max) * 100)
        Next i
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
        Statuslbl.Text = "Updating Activity # " & i
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MsgBox("Done!")
    End Sub
End Class