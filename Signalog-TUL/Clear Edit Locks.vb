Public Class Clear_Edit_Locks

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        Try
            LOCKEDITTableAdapter.DeleteAll()
            MsgBox("Done!")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class