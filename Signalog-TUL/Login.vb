'**************************************************************************************************
'**************************************************************************************************
'**  This software is the property of:
'**  Traffic & Lighting Systems, LLC.
'**  13305 N. SANTA FE
'**  OKLAHOMA CITY, OKLAHOMA 73114
'**  Phone (405) 524-1341
'**  FAX (405) 524-2386
'**************************************************************************************************
'**  Copyright 2009, 2010, 2017 - Traffic & Lighting Systems, LLC.
'**************************************************************************************************
'**  Traffic & Lighting Systems, LLC. reserves all rights in the Program as delivered.  
'**  The Program or any portion thereof may not be reproduced in any form whatsoever 
'**  except as provided by license without the written consent of Traffic & Lighting Systems, LLC.  
'**  A license under Traffic & Lighting Systems, LLC.’s rights in the Program may be available 
'**  directly from Traffic & Lighting Systems, LLC.
'**************************************************************************************************
'**************************************************************************************************

Public Class Login
    Public User As String
    Public AccessType As String
    Public DefWareHouse As String

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If PERS0TableAdapter.ReturnUserPassCOUNT(Username.Text, Password.Text) = 0 Then
            MsgBox("Invalid credentials!", MsgBoxStyle.Exclamation, "Invalid Credentials!")
        ElseIf Username.Text = String.Empty And Password.Text = String.Empty Then
            MsgBox("Please enter Username and Password", MsgBoxStyle.Exclamation, "Missing Fields")

        Else
            User = Username.Text
            AccessType = PERS0TableAdapter.ReturnAccessType(User)
            DefWareHouse = "OKC"
            Main.Userlbl.Text = "User: " & User
            Main.Show()
            If AccessType = "R" Then
                Main.MaintenanceToolStripMenuItem.Enabled = False
                Main.ActivityMainteneacToolStripMenuItem.Enabled = False
                Main.AreaLocationMaintenanceToolStripMenuItem.Enabled = False
                Main.InventoryToolStripMenuItem.Enabled = False
                Main.PersonelToolStripMenuItem.Enabled = False
                Main.DataBaseToolStripMenuItem.Enabled = False
            ElseIf AccessType = "T" Then
                Main.ActivityMainteneacToolStripMenuItem.Enabled = False
                Main.AreaLocationMaintenanceToolStripMenuItem.Enabled = False
                Main.PersonelToolStripMenuItem.Enabled = False
                Main.ReindexToolStripMenuItem.Enabled = False
            End If
            Me.Hide()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

   
End Class
