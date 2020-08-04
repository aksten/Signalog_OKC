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

Public Class Main
    Dim exitflag As Boolean
    Dim logoff As Boolean
    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If exitflag = False Then
            If logoff = False Then
                If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.No Then
                    e.Cancel = True
                Else
                    e.Cancel = False
                    Login.Close()
                End If
            End If
        End If
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.WindowState = FormWindowState.Maximized
        exitflag = False
        logoff = False
        'Me.BackColor = Color.FromArgb(255, 255, 255)
        Me.BackgroundImage = My.Resources.STLogo
        Me.BackgroundImageLayout = ImageLayout.Zoom
        Userlbl.Location = New Point(Me.Width - Userlbl.Width - 130, 5)
        Dim C As Control

        For Each C In Me.Controls
            If TypeOf C Is MdiClient Then
                C.BackColor = Color.White
                Exit For
            End If
        Next

        C = Nothing

    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If Trouble_Report.Visible = True Then
            Trouble_Report.Focus()
            If Trouble_Report.WindowState = FormWindowState.Minimized Then
                Trouble_Report.WindowState = FormWindowState.Maximized
            End If
        Else
            Trouble_Report.MdiParent = Me
            Trouble_Report.Show()
        End If

    End Sub

    Private Sub ActivityListMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivityListMaintenanceToolStripMenuItem.Click
        If Activity_List_Maintenance.Visible = True Then
            Activity_List_Maintenance.Focus()
            If Activity_List_Maintenance.WindowState = FormWindowState.Minimized Then
                Activity_List_Maintenance.WindowState = FormWindowState.Normal
            End If
        Else
            Activity_List_Maintenance.Location = New Point(Screen.PrimaryScreen.Bounds.Width / 2 - Activity_List_Maintenance.Width / 2, 55)
            Activity_List_Maintenance.MdiParent = Me
            Activity_List_Maintenance.Show()
        End If
    End Sub

    Private Sub VehicleListMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VehicleListMaintenanceToolStripMenuItem.Click
        If Vehicle_List_Maintenance.Visible = True Then
            Vehicle_List_Maintenance.Focus()
            If Vehicle_List_Maintenance.WindowState = FormWindowState.Minimized Then
                Vehicle_List_Maintenance.WindowState = FormWindowState.Normal
            End If
        Else
            Vehicle_List_Maintenance.MdiParent = Me
            Vehicle_List_Maintenance.Show()
        End If
    End Sub

    Private Sub HolidayListMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HolidayListMaintenanceToolStripMenuItem.Click
        If Holiday_List_Maintenance.Visible = True Then
            Holiday_List_Maintenance.Focus()
            If Holiday_List_Maintenance.WindowState = FormWindowState.Minimized Then
                Holiday_List_Maintenance.WindowState = FormWindowState.Normal
            End If
        Else
            Holiday_List_Maintenance.MdiParent = Me
            Holiday_List_Maintenance.Show()
        End If
    End Sub

    Private Sub HolidaysMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HolidaysMaintenanceToolStripMenuItem.Click
        If Holidays_Maintenance.Visible = True Then
            Holidays_Maintenance.Focus()
            If Holidays_Maintenance.WindowState = FormWindowState.Minimized Then
                Holidays_Maintenance.WindowState = FormWindowState.Normal
            End If
        Else
            Holidays_Maintenance.MdiParent = Me
            Holidays_Maintenance.Show()
        End If
    End Sub

    Private Sub AreaMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaMaintenanceToolStripMenuItem.Click
        If Area_Maintenance.Visible = True Then
            Area_Maintenance.Focus()
            If Area_Maintenance.WindowState = FormWindowState.Minimized Then
                Area_Maintenance.WindowState = FormWindowState.Normal
            End If
        Else
            Area_Maintenance.MdiParent = Me
            Area_Maintenance.Show()
        End If
    End Sub

    Private Sub LocationsMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocationsMaintenanceToolStripMenuItem.Click
        If Locations_Maintenance.Visible = True Then
            Locations_Maintenance.Focus()
            If Locations_Maintenance.WindowState = FormWindowState.Minimized Then
                Locations_Maintenance.WindowState = FormWindowState.Normal
            End If
        Else
            Locations_Maintenance.MdiParent = Me
            Locations_Maintenance.Show()
        End If
    End Sub

    Private Sub LocationTypeMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocationTypeMaintenanceToolStripMenuItem.Click
        If Location_Type_Description_Maintenance.Visible = True Then
            Location_Type_Description_Maintenance.Focus()
            If Location_Type_Description_Maintenance.WindowState = FormWindowState.Minimized Then
                Location_Type_Description_Maintenance.WindowState = FormWindowState.Normal
            End If
        Else
            Location_Type_Description_Maintenance.MdiParent = Me
            Location_Type_Description_Maintenance.Show()
        End If
    End Sub

    Private Sub InventoryMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryMaintenanceToolStripMenuItem.Click
        If Inventory_Maintenance.Visible = True Then
            Inventory_Maintenance.Focus()
            If Inventory_Maintenance.WindowState = FormWindowState.Minimized Then
                Inventory_Maintenance.WindowState = FormWindowState.Normal
            End If
        Else
            Inventory_Maintenance.MdiParent = Me
            Inventory_Maintenance.Show()
        End If
    End Sub

    Private Sub PartsListMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartsListMaintenanceToolStripMenuItem.Click
        If Parts_List_Maintenance.Visible = True Then
            Parts_List_Maintenance.Focus()
            If Parts_List_Maintenance.WindowState = FormWindowState.Minimized Then
                Parts_List_Maintenance.WindowState = FormWindowState.Normal
            End If
        Else
            Parts_List_Maintenance.MdiParent = Me
            Parts_List_Maintenance.Show()
        End If
    End Sub

    Private Sub ManufacturerListMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManufacturerListMaintenanceToolStripMenuItem.Click
        If Manufacturer_List_Maintenance.Visible = True Then
            Manufacturer_List_Maintenance.Focus()
            If Manufacturer_List_Maintenance.WindowState = FormWindowState.Minimized Then
                Manufacturer_List_Maintenance.WindowState = FormWindowState.Normal
            End If
        Else
            Manufacturer_List_Maintenance.MdiParent = Me
            Manufacturer_List_Maintenance.Show()
        End If
    End Sub

    Private Sub EmployeesMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeesMaintenanceToolStripMenuItem.Click
        If Employees_Maintenance.Visible = True Then
            Employees_Maintenance.Focus()
            If Employees_Maintenance.WindowState = FormWindowState.Minimized Then
                Employees_Maintenance.WindowState = FormWindowState.Normal
            End If
        Else
            Employees_Maintenance.MdiParent = Me
            Employees_Maintenance.Show()
        End If
    End Sub

    Private Sub DispatchByMaintenanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispatchByMaintenanceToolStripMenuItem.Click
        If Dispatch_By_Maintenance.Visible = True Then
            Dispatch_By_Maintenance.Focus()
            If Dispatch_By_Maintenance.WindowState = FormWindowState.Minimized Then
                Dispatch_By_Maintenance.WindowState = FormWindowState.Normal
            End If
        Else
            Dispatch_By_Maintenance.MdiParent = Me
            Dispatch_By_Maintenance.Show()
        End If
    End Sub

    Private Sub ReindexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReindexToolStripMenuItem.Click
        If Reindex.Visible = True Then
            Reindex.Focus()
            If Reindex.WindowState = FormWindowState.Minimized Then
                Reindex.WindowState = FormWindowState.Normal
            End If
        Else
            Reindex.MdiParent = Me
            Reindex.Show()
        End If
    End Sub

    Private Sub DispatchByReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DispatchByReportToolStripMenuItem.Click
        If Dispatch_By_Report.Visible = True Then
            Dispatch_By_Report.Focus()
            If Dispatch_By_Report.WindowState = FormWindowState.Minimized Then
                Dispatch_By_Report.WindowState = FormWindowState.Normal
            End If
        Else
            Dispatch_By_Report.MdiParent = Me
            Dispatch_By_Report.Show()
        End If
    End Sub

    Private Sub InventoryControlToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryControlToolStripMenuItem.Click
        If Inventory_Control.Visible = True Then
            Inventory_Control.Focus()
            If Inventory_Control.WindowState = FormWindowState.Minimized Then
                Inventory_Control.WindowState = FormWindowState.Normal
            End If
        Else
            Inventory_Control.MdiParent = Me
            Inventory_Control.Show()
        End If
    End Sub

    Private Sub FieldMaintenanceActivityReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FieldMaintenanceActivityReportToolStripMenuItem.Click
        If Field_Maintenance_Activity_Report.Visible = True Then
            Field_Maintenance_Activity_Report.Focus()
            If Field_Maintenance_Activity_Report.WindowState = FormWindowState.Minimized Then
                Field_Maintenance_Activity_Report.WindowState = FormWindowState.Normal
            End If
        Else
            Field_Maintenance_Activity_Report.MdiParent = Me
            Field_Maintenance_Activity_Report.Show()
        End If
    End Sub

    Private Sub ClearEditLocksToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearEditLocksToolStripMenuItem.Click
        If Clear_Edit_Locks.Visible = True Then
            Clear_Edit_Locks.Focus()
            If Clear_Edit_Locks.WindowState = FormWindowState.Minimized Then
                Clear_Edit_Locks.WindowState = FormWindowState.Normal
            End If
        Else
            Clear_Edit_Locks.MdiParent = Me
            Clear_Edit_Locks.Show()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Dim result As MsgBoxResult
        result = MsgBox("Are you sure you want to exit Signalog?", MsgBoxStyle.YesNo, "Exit?")
        If result = MsgBoxResult.Yes Then
            exitflag = True
            Me.Close()
        End If
    End Sub

    Private Sub LogoffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoffToolStripMenuItem.Click
        If MsgBox("Are you sure you want to Log Off?", MsgBoxStyle.YesNo, "Log Off?") = MsgBoxResult.Yes Then
            logoff = True
            Me.Close()
            Login.Show()
        End If
    End Sub

End Class