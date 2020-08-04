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

Public Class Action_Taken
    Dim lnklabel(0 To 4) As String
    Dim acttakdesc(0 To 5) As String
    Dim acttakcode(0 To 5) As String
    Dim rowcount As Integer

    Private Sub Action_Taken_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Field_Maintenance_Activity_Report.CallFromReport = True Then
            Field_Maintenance_Activity_Report.CallFromReport = False
            Field_Maintenance_Activity_Report.ActTakEdit = False
        Else
            Trouble_Report.ActTakEdit = False
        End If
    End Sub

    Private Sub Action_Taken_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = SUB1.Location.Y + SUB1.Size.Height + 50
        Dim j As Integer
        For j = 0 To 5
            acttakdesc(j) = String.Empty
            acttakcode(j) = String.Empty
        Next j
        For j = 0 To 4
            lnklabel(j) = String.Empty
        Next j
        Me.ASUBTableAdapter.Fill(Me.SignalogDataSet.ASUB)
        rowcount = Me.SignalogDataSet.ASUB.Rows.Count
        Me.ASUB1TableAdapter.FillByActTak(Me.SignalogDataSet.ASUB1)
        SUB2.Visible = False
        SUB3.Visible = False
        SUB4.Visible = False
        SUB5.Visible = False
        SUB6.Visible = False
        MemoBox.Visible = False
        Submit.Visible = False

        If Trouble_Report.ActTakEdit = True Or Field_Maintenance_Activity_Report.ActTakEdit = True Then   'Load previous selections and memo (if memo exists)
            Dim s1, s2, s3, s4, s5, s6 As String
            Dim d1, d2, d3, d4, d5, d6 As String
            Dim lnklabel(0 To 5) As String
            Dim memo As Boolean

            memo = False

            'Determining if memo exists and memonum
            Dim i As Integer
            If Trouble_Report.ActTakEdit = True Then
                i = Trouble_Report.ActionTakenGrid.CurrentRow.Index
                s1 = Trouble_Report.Act_Tak_Code(i, 0)  'Loading activity codes
                s2 = Trouble_Report.Act_Tak_Code(i, 1)
                s3 = Trouble_Report.Act_Tak_Code(i, 2)
                s4 = Trouble_Report.Act_Tak_Code(i, 3)
                s5 = Trouble_Report.Act_Tak_Code(i, 4)
                s6 = Trouble_Report.Act_Tak_Code(i, 5)
            ElseIf Field_Maintenance_Activity_Report.ActTakEdit = True Then
                i = Field_Maintenance_Activity_Report.ActivityGrid.CurrentRow.Index
                s1 = Field_Maintenance_Activity_Report.Activity_Code(i, 0)  'Loading activity codes
                s2 = Field_Maintenance_Activity_Report.Activity_Code(i, 1)
                s3 = Field_Maintenance_Activity_Report.Activity_Code(i, 2)
                s4 = Field_Maintenance_Activity_Report.Activity_Code(i, 3)
                s5 = Field_Maintenance_Activity_Report.Activity_Code(i, 4)
                s6 = Field_Maintenance_Activity_Report.Activity_Code(i, 5)
            Else
                i = Nothing
                s1 = Nothing
                s2 = Nothing
                s3 = Nothing
                s4 = Nothing
                s5 = Nothing
                s6 = Nothing
            End If

            lnklabel(0) = ASUBTableAdapter.ReturnLNKLABEL(s1)  'Loading LNKLABEL for each activity
            lnklabel(1) = ASUBTableAdapter.ReturnLNKLABEL(s2)
            lnklabel(2) = ASUBTableAdapter.ReturnLNKLABEL(s3)
            lnklabel(3) = ASUBTableAdapter.ReturnLNKLABEL(s4)
            lnklabel(4) = ASUBTableAdapter.ReturnLNKLABEL(s5)
            lnklabel(5) = ASUBTableAdapter.ReturnLNKLABEL(s6)
            For j = 0 To 5    ' checking for MEMO in LNKLABEL
                If lnklabel(j) = "MEMO" Then
                    memo = True
                End If
            Next j

            d1 = ASUBTableAdapter.RetrunDESC(s1)   'loading corresponding description for each activity code
            d2 = ASUBTableAdapter.RetrunDESC(s2)
            d3 = ASUBTableAdapter.RetrunDESC(s3)
            d4 = ASUBTableAdapter.RetrunDESC(s4)
            d5 = ASUBTableAdapter.RetrunDESC(s5)
            d6 = ASUBTableAdapter.RetrunDESC(s6)

            If s1 <> String.Empty Then
                SUB1.SelectedValue = d1
                Call SUB1_SelectedIndexChanged(sender, e)
            End If

            If s2 <> String.Empty Then
                SUB2.SelectedValue = d2
                Call SUB2_SelectedIndexChanged(sender, e)
            End If

            If s3 <> String.Empty Then
                SUB3.SelectedValue = d3
                Call SUB3_SelectedIndexChanged(sender, e)
            End If

            If s4 <> String.Empty Then
                SUB4.SelectedValue = d4
                Call SUB4_SelectedIndexChanged(sender, e)
            End If

            If s5 <> String.Empty Then
                SUB5.SelectedValue = d5
                Call SUB5_SelectedIndexChanged(sender, e)
            End If

            If s6 <> String.Empty Then
                SUB6.SelectedValue = d6
                Call SUB6_SelectedIndexChanged(sender, e)
            End If

            If memo = True And Trouble_Report.ActTakEdit = True Then
                MemoBox.Text = Trouble_Report.Act_Tak_Code(Trouble_Report.ActionTakenGrid.CurrentRow.Index, 6)
            End If

            Trouble_Report.ActTakEdit = False
            Field_Maintenance_Activity_Report.ActTakEdit = False
        End If
    End Sub

    Private Sub SUB1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUB1.SelectedIndexChanged
        MemoBox.Text = String.Empty
        Dim i As Integer
        For i = 0 To 5
            acttakdesc(i) = String.Empty
            acttakcode(i) = String.Empty
        Next i
        If SUB1.SelectedValue = String.Empty Then
            Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, SUB1.Location.Y + SUB1.Size.Height + 20)
            Me.Height = Submit.Location.Y + Submit.Size.Height + 50
            Submit.Visible = True
            SUB2.Visible = False
            SUB3.Visible = False
            SUB4.Visible = False
            SUB5.Visible = False
            SUB6.Visible = False
        Else
            acttakdesc(0) = SUB1.SelectedValue
            For i = 0 To rowcount - 1
                If SignalogDataSet.ASUB.Rows(i)(0) = "ACTN TAKN" Then
                    If SignalogDataSet.ASUB.Rows(i)(2) = acttakdesc(0) Then
                        acttakcode(0) = SignalogDataSet.ASUB.Rows(i)(4)
                        Try  'lnklanbel coukd be null
                            lnklabel(0) = SignalogDataSet.ASUB.Rows(i)(3)
                        Catch
                        End Try
                    End If
                End If
            Next i
            Me.ASUB2TableAdapter.FillByLNKLBL(Me.SignalogDataSet.ASUB2, lnklabel(0))
            If SignalogDataSet.ASUB2.Rows.Count <> 0 Then
                Me.Height = SUB2.Location.Y + SUB2.Size.Height + 50
                Submit.Visible = False
                MemoBox.Visible = False
                SUB2.Visible = True
                SUB3.Visible = False
                SUB4.Visible = False
                SUB5.Visible = False
                SUB6.Visible = False
            Else
                If lnklabel(0) = "MEMO" Then
                    MemoBox.Location = New Point(SUB1.Location.X, SUB1.Location.Y + SUB1.Size.Height + 20)
                    MemoBox.Visible = True
                    Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, MemoBox.Location.Y + MemoBox.Size.Height + 20)
                    Me.Height = Submit.Location.Y + Submit.Size.Height + 50
                    Submit.Visible = True
                Else
                    Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, SUB1.Location.Y + SUB1.Size.Height + 20)
                    Me.Height = Submit.Location.Y + Submit.Size.Height + 50
                    Submit.Visible = True
                    MemoBox.Visible = False
                End If
                SUB2.Visible = False
                SUB3.Visible = False
                SUB4.Visible = False
                SUB5.Visible = False
                SUB6.Visible = False
            End If
        End If
    End Sub

    Private Sub SUB2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUB2.SelectedIndexChanged
        MemoBox.Text = String.Empty
        Dim i As Integer
        For i = 1 To 5
            acttakdesc(i) = String.Empty
            acttakcode(i) = String.Empty
        Next i
        If SUB2.SelectedValue = String.Empty Then
            Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, SUB2.Location.Y + SUB2.Size.Height + 20)
            Me.Height = Submit.Location.Y + Submit.Size.Height + 50
            Submit.Visible = True
            SUB3.Visible = False
            SUB4.Visible = False
            SUB5.Visible = False
            SUB6.Visible = False
        Else
            acttakdesc(1) = SUB2.SelectedValue
            For i = 0 To rowcount - 1
                If SignalogDataSet.ASUB.Rows(i)(0) = lnklabel(0) Then
                    If SignalogDataSet.ASUB.Rows(i)(2) = acttakdesc(1) Then
                        acttakcode(1) = SignalogDataSet.ASUB.Rows(i)(4)
                        Try  'lnklanbel coukd be null
                            lnklabel(1) = SignalogDataSet.ASUB.Rows(i)(3)
                        Catch
                        End Try
                    End If
                End If
            Next i
            Me.ASUB3TableAdapter.FillByLNKLBL(Me.SignalogDataSet.ASUB3, lnklabel(1))
            If SignalogDataSet.ASUB3.Rows.Count <> 0 Then
                Me.Height = SUB3.Location.Y + SUB3.Size.Height + 50
                Submit.Visible = False
                SUB3.Visible = True
                SUB4.Visible = False
                SUB5.Visible = False
                SUB6.Visible = False
            Else
                If lnklabel(1) = "MEMO" Then
                    MemoBox.Location = New Point(SUB2.Location.X, SUB2.Location.Y + SUB2.Size.Height + 20)
                    MemoBox.Visible = True
                    Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, MemoBox.Location.Y + MemoBox.Size.Height + 20)
                    Me.Height = Submit.Location.Y + Submit.Size.Height + 50
                    Submit.Visible = True
                Else
                    Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, SUB2.Location.Y + SUB2.Size.Height + 20)
                    Me.Height = Submit.Location.Y + Submit.Size.Height + 50
                    Submit.Visible = True
                    MemoBox.Visible = False
                End If
                SUB3.Visible = False
                SUB4.Visible = False
                SUB5.Visible = False
                SUB6.Visible = False
            End If
        End If
    End Sub

    Private Sub SUB3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUB3.SelectedIndexChanged
        MemoBox.Text = String.Empty
        Dim i As Integer
        For i = 2 To 5
            acttakdesc(i) = String.Empty
            acttakcode(i) = String.Empty
        Next i
        If SUB3.SelectedValue = String.Empty Then
            Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, SUB3.Location.Y + SUB3.Size.Height + 20)
            Me.Height = Submit.Location.Y + Submit.Size.Height + 50
            Submit.Visible = True
            SUB4.Visible = False
            SUB5.Visible = False
            SUB6.Visible = False
        Else
            acttakdesc(2) = SUB3.SelectedValue
            For i = 0 To rowcount - 1
                If SignalogDataSet.ASUB.Rows(i)(0) = lnklabel(1) Then
                    If SignalogDataSet.ASUB.Rows(i)(2) = acttakdesc(2) Then
                        acttakcode(2) = SignalogDataSet.ASUB.Rows(i)(4)
                        Try  'lnklanbel coukd be null
                            lnklabel(2) = SignalogDataSet.ASUB.Rows(i)(3)
                        Catch
                        End Try
                    End If
                End If
            Next i
            Me.ASUB4TableAdapter.FillByLNKLBL(Me.SignalogDataSet.ASUB4, lnklabel(2))
            If SignalogDataSet.ASUB4.Rows.Count <> 0 Then
                Me.Height = SUB4.Location.Y + SUB4.Size.Height + 50
                Submit.Visible = False
                SUB4.Visible = True
                SUB5.Visible = False
                SUB6.Visible = False
            Else
                If lnklabel(2) = "MEMO" Then
                    MemoBox.Location = New Point(SUB3.Location.X, SUB3.Location.Y + SUB3.Size.Height + 20)
                    MemoBox.Visible = True
                    Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, MemoBox.Location.Y + MemoBox.Size.Height + 20)
                    Me.Height = Submit.Location.Y + Submit.Size.Height + 50
                    Submit.Visible = True
                Else
                    Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, SUB3.Location.Y + SUB3.Size.Height + 20)
                    Me.Height = Submit.Location.Y + Submit.Size.Height + 50
                    Submit.Visible = True
                    MemoBox.Visible = False
                End If
                SUB4.Visible = False
                SUB5.Visible = False
                SUB6.Visible = False
            End If
        End If
    End Sub

    Private Sub SUB4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUB4.SelectedIndexChanged
        MemoBox.Text = String.Empty
        Dim i As Integer
        For i = 3 To 5
            acttakdesc(i) = String.Empty
            acttakcode(i) = String.Empty
        Next i
        If SUB4.SelectedValue = String.Empty Then
            Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, SUB4.Location.Y + SUB4.Size.Height + 20)
            Me.Height = Submit.Location.Y + Submit.Size.Height + 50
            Submit.Visible = True
            SUB5.Visible = False
            SUB6.Visible = False
        Else
            acttakdesc(3) = SUB4.SelectedValue
            For i = 0 To rowcount - 1
                If SignalogDataSet.ASUB.Rows(i)(0) = lnklabel(2) Then
                    If SignalogDataSet.ASUB.Rows(i)(2) = acttakdesc(3) Then
                        acttakcode(3) = SignalogDataSet.ASUB.Rows(i)(4)
                        Try  'lnklanbel coukd be null
                            lnklabel(3) = SignalogDataSet.ASUB.Rows(i)(3)
                        Catch
                        End Try
                    End If
                End If
            Next i
            Me.ASUB5TableAdapter.FillByLNKLBL(Me.SignalogDataSet.ASUB5, lnklabel(3))
            If SignalogDataSet.ASUB5.Rows.Count <> 0 Then
                Me.Height = SUB5.Location.Y + SUB5.Size.Height + 50
                Submit.Visible = False
                SUB5.Visible = True
                SUB6.Visible = False
            Else
                If lnklabel(3) = "MEMO" Then
                    MemoBox.Location = New Point(SUB4.Location.X, SUB4.Location.Y + SUB4.Size.Height + 20)
                    MemoBox.Visible = True
                    Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, MemoBox.Location.Y + MemoBox.Size.Height + 20)
                    Me.Height = Submit.Location.Y + Submit.Size.Height + 50
                    Submit.Visible = True
                Else
                    Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, SUB4.Location.Y + SUB4.Size.Height + 20)
                    Me.Height = Submit.Location.Y + Submit.Size.Height + 50
                    Submit.Visible = True
                    MemoBox.Visible = False
                End If
                SUB5.Visible = False
                SUB6.Visible = False
            End If
        End If
    End Sub

    Private Sub SUB5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUB5.SelectedIndexChanged
        MemoBox.Text = String.Empty
        Dim i As Integer
        For i = 4 To 5
            acttakdesc(i) = String.Empty
            acttakcode(i) = String.Empty
        Next i
        If SUB5.SelectedValue = String.Empty Then
            Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, SUB5.Location.Y + SUB5.Size.Height + 20)
            Me.Height = Submit.Location.Y + Submit.Size.Height + 50
            Submit.Visible = True
            SUB6.Visible = False
        Else
            acttakdesc(4) = SUB5.SelectedValue
            For i = 0 To rowcount - 1
                If SignalogDataSet.ASUB.Rows(i)(0) = lnklabel(3) Then
                    If SignalogDataSet.ASUB.Rows(i)(2) = acttakdesc(4) Then
                        acttakcode(4) = SignalogDataSet.ASUB.Rows(i)(4)
                        Try  'lnklanbel coukd be null
                            lnklabel(4) = SignalogDataSet.ASUB.Rows(i)(3)
                        Catch
                        End Try
                    End If
                End If
            Next i
            Me.ASUB6TableAdapter.FillByLNKLBL(Me.SignalogDataSet.ASUB6, lnklabel(4))
            If SignalogDataSet.ASUB6.Rows.Count <> 0 Then
                Me.Height = SUB6.Location.Y + SUB6.Size.Height + 50
                Submit.Visible = False
                SUB6.Visible = True
            Else
                If lnklabel(4) = "MEMO" Then
                    MemoBox.Location = New Point(SUB5.Location.X, SUB5.Location.Y + SUB5.Size.Height + 20)
                    MemoBox.Visible = True
                    Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, MemoBox.Location.Y + MemoBox.Size.Height + 20)
                    Me.Height = Submit.Location.Y + Submit.Size.Height + 50
                    Submit.Visible = True
                Else
                    Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, SUB5.Location.Y + SUB5.Size.Height + 20)
                    Me.Height = Submit.Location.Y + Submit.Size.Height + 50
                    Submit.Visible = True
                    MemoBox.Visible = False
                End If
                SUB6.Visible = False
            End If
        End If
    End Sub

    Private Sub SUB6_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUB6.SelectedIndexChanged
        acttakdesc(5) = SUB6.SelectedValue
        For i = 0 To rowcount - 1
            If SignalogDataSet.ASUB.Rows(i)(0) = lnklabel(4) Then
                If SignalogDataSet.ASUB.Rows(i)(2) = acttakdesc(5) Then
                    acttakcode(5) = SignalogDataSet.ASUB.Rows(i)(4)
                End If
            End If
        Next i
        Submit.Location = New Point(Me.Width / 2 - Submit.Size.Width / 2, SUB6.Location.Y + SUB6.Size.Height + 20)
        Me.Height = Submit.Location.Y + Submit.Size.Height + 50
        Submit.Visible = True
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        Dim k As Integer
        If Field_Maintenance_Activity_Report.CallFromReport = True Then   'Called from Field Maintenance Activity Report
            Field_Maintenance_Activity_Report.CallFromReport = False

            Field_Maintenance_Activity_Report.ActivityGrid.CurrentCell = Field_Maintenance_Activity_Report.ActivityGrid.CurrentRow.Cells(1)
            Field_Maintenance_Activity_Report.ActivityGrid.CurrentCell.Value = String.Empty

            For k = 0 To 5
                If acttakdesc(k) <> String.Empty Then
                    If k = 5 Then
                        Field_Maintenance_Activity_Report.ActivityGrid.CurrentCell.Value += acttakdesc(k)
                    ElseIf acttakdesc(k + 1) = String.Empty Then
                        Field_Maintenance_Activity_Report.ActivityGrid.CurrentCell.Value += acttakdesc(k)
                    Else
                        Field_Maintenance_Activity_Report.ActivityGrid.CurrentCell.Value += acttakdesc(k) & ",  "
                    End If
                End If
                If acttakdesc(k) <> String.Empty Then
                    Field_Maintenance_Activity_Report.Activity_Code(Field_Maintenance_Activity_Report.ActivityGrid.CurrentRow.Index, k) = acttakcode(k)
                Else
                    Field_Maintenance_Activity_Report.Activity_Code(Field_Maintenance_Activity_Report.ActivityGrid.CurrentRow.Index, k) = String.Empty
                End If
            Next k
            Field_Maintenance_Activity_Report.Activity_Code(Field_Maintenance_Activity_Report.ActivityGrid.CurrentRow.Index, 6) = 3   'set ACTCODE
            Field_Maintenance_Activity_Report.ActivityGrid.CurrentRow.Selected = False

        Else    'Called from Trouble Report
            Trouble_Report.ActionTakenGrid.BeginEdit(True)
            Trouble_Report.ActionTakenGrid.EditingControl.Text = ""

            For k = 0 To 5
                If acttakdesc(k) <> String.Empty Then
                    If k = 5 Then
                        Trouble_Report.ActionTakenGrid.EditingControl.Text += acttakdesc(k)
                    ElseIf acttakdesc(k + 1) = String.Empty Then
                        Trouble_Report.ActionTakenGrid.EditingControl.Text += acttakdesc(k)
                    Else
                        Trouble_Report.ActionTakenGrid.EditingControl.Text += acttakdesc(k) & ",  "
                    End If
                End If
                If acttakdesc(k) <> String.Empty Then
                    Trouble_Report.Act_Tak_Code(Trouble_Report.ActionTakenGrid.CurrentRow.Index, k) = acttakcode(k)
                Else
                    Trouble_Report.Act_Tak_Code(Trouble_Report.ActionTakenGrid.CurrentRow.Index, k) = String.Empty
                End If
            Next k

            If MemoBox.Visible = True And MemoBox.Text <> "" Then
                Trouble_Report.Act_Tak_Code(Trouble_Report.ActionTakenGrid.CurrentRow.Index, 6) = MemoBox.Text
                Trouble_Report.ActionTakenGrid.EditingControl.Text += ",  " & MemoBox.Text
            End If

            Trouble_Report.ActionTakenGrid.EndEdit()
            Trouble_Report.ActionTakenGrid.CurrentRow.Selected = False
        End If
        Me.Close()
    End Sub

End Class
