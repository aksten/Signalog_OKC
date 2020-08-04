Imports CrystalDecisions.CrystalReports.Engine

Public Class Report_Viewer

    Private Sub Report_Viewer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Field_Maintenance_Activity_Report.ViewReport.Enabled = True
    End Sub
    Private Sub Dispatch_By_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Height - 50
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Location = New Point(0, 50)
        CrystalReportViewer1.Size = New Size(Me.Width - 6, Me.Height - 24)
    End Sub
End Class