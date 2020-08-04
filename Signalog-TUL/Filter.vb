Public Class Filter
    Dim lnklabel As String
    Dim arrcondesc(0 To 5) As String
    Dim rowcount As Integer
    Private Sub Filter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Submit.Visible = False
        Me.Height = 85
        Dim j As Integer
        For j = 0 To 5
            arrcondesc(j) = ""
        Next j
        Me.ASUBTableAdapter.Fill(Me.SignalogDataSet.ASUB)
        rowcount = Me.SignalogDataSet.ASUB.Rows.Count
        Me.ASUB1TableAdapter.FillByArrCond(Me.SignalogDataSet.ASUB1)
        SUB2.Visible = False
        SUB3.Visible = False
        SUB4.Visible = False
        SUB5.Visible = False
        SUB6.Visible = False
    End Sub

    Private Sub SUB1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUB1.SelectedIndexChanged
        arrcondesc(0) = SUB1.SelectedValue
        Dim i As Integer
        For i = 0 To rowcount - 1
            If SignalogDataSet.ASUB.Rows(i)(0) = "ARRV COND" Then
                If SignalogDataSet.ASUB.Rows(i)(2) = arrcondesc(0) Then
                    lnklabel = SignalogDataSet.ASUB.Rows(i)(3)
                End If
            End If
        Next i
        Me.ASUB2TableAdapter.FillByLNKLBL(Me.SignalogDataSet.ASUB2, lnklabel)
        If SignalogDataSet.ASUB2.Rows.Count <> 0 Then
            Me.Height = 130
            SUB2.Visible = True
            SUB3.Visible = False
            SUB4.Visible = False
            SUB5.Visible = False
            SUB6.Visible = False
        Else
            Me.Height = 115

            SUB2.Visible = False
            SUB3.Visible = False
            SUB4.Visible = False
            SUB5.Visible = False
            SUB6.Visible = False
        End If
    End Sub

    Private Sub SUB2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUB2.SelectedIndexChanged
        arrcondesc(1) = SUB2.SelectedValue
        Dim i As Integer
        For i = 0 To rowcount - 1
            If SignalogDataSet.ASUB.Rows(i)(0) = lnklabel Then
                If SignalogDataSet.ASUB.Rows(i)(2) = arrcondesc(1) Then
                    lnklabel = SignalogDataSet.ASUB.Rows(i)(3)
                End If
            End If
        Next i
        Me.ASUB3TableAdapter.FillByLNKLBL(Me.SignalogDataSet.ASUB3, lnklabel)
        If SignalogDataSet.ASUB3.Rows.Count <> 0 Then
            Me.Height = 175
            SUB3.Visible = True
            SUB4.Visible = False
            SUB5.Visible = False
            SUB6.Visible = False
        Else
            Me.Height = 130
            SUB3.Visible = False
            SUB4.Visible = False
            SUB5.Visible = False
            SUB6.Visible = False
        End If
    End Sub

    Private Sub SUB3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUB3.SelectedIndexChanged
        arrcondesc(2) = SUB3.SelectedValue
        Dim i As Integer
        For i = 0 To rowcount - 1
            If SignalogDataSet.ASUB.Rows(i)(0) = lnklabel Then
                If SignalogDataSet.ASUB.Rows(i)(2) = arrcondesc(2) Then
                    lnklabel = SignalogDataSet.ASUB.Rows(i)(3)
                End If
            End If
        Next i
        Me.ASUB4TableAdapter.FillByLNKLBL(Me.SignalogDataSet.ASUB4, lnklabel)
        If SignalogDataSet.ASUB4.Rows.Count <> 0 Then
            Me.Height = 220
            SUB4.Visible = True
            SUB5.Visible = False
            SUB6.Visible = False
        Else
            Me.Height = 175
            SUB4.Visible = False
            SUB5.Visible = False
            SUB6.Visible = False
        End If
    End Sub

    Private Sub SUB4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUB4.SelectedIndexChanged
        arrcondesc(3) = SUB4.SelectedValue
        Dim i As Integer
        For i = 0 To rowcount - 1
            If SignalogDataSet.ASUB.Rows(i)(0) = lnklabel Then
                If SignalogDataSet.ASUB.Rows(i)(2) = arrcondesc(3) Then
                    lnklabel = SignalogDataSet.ASUB.Rows(i)(3)
                End If
            End If
        Next i
        Me.ASUB5TableAdapter.FillByLNKLBL(Me.SignalogDataSet.ASUB5, lnklabel)
        If SignalogDataSet.ASUB5.Rows.Count <> 0 Then
            Me.Height = 265
            SUB5.Visible = True
            SUB6.Visible = False
        Else
            Me.Height = 220
            SUB5.Visible = False
            SUB6.Visible = False
        End If
    End Sub

    Private Sub SUB5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SUB5.SelectedIndexChanged
        arrcondesc(4) = SUB5.SelectedValue
        Dim i As Integer
        For i = 0 To rowcount - 1
            If SignalogDataSet.ASUB.Rows(i)(0) = lnklabel Then
                If SignalogDataSet.ASUB.Rows(i)(2) = arrcondesc(4) Then
                    lnklabel = SignalogDataSet.ASUB.Rows(i)(3)
                End If
            End If
        Next i
        Me.ASUB6TableAdapter.FillByLNKLBL(Me.SignalogDataSet.ASUB6, lnklabel)
        If SignalogDataSet.ASUB6.Rows.Count <> 0 Then
            Me.Height = 310
            SUB6.Visible = True
        Else
            Me.Height = 265
            SUB6.Visible = False
        End If
    End Sub
End Class