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

'This Form is used to control movements of misc. parts in local inventory

Imports System.Data.SqlClient
Public Class Inventory_Control
    Dim OldQ As Integer

    Private Sub Inventory_Control_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'StockControlTableAdapter.Update(Me.SignalogDataSet.StockControl)   'update changes made to dataset to StockControl table in databse
    End Sub
    Private Sub Inventory_Control_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WareHouseFilter.Text = Login.DefWareHouse
        Me.StockControlTableAdapter.FillByWarehouse(Me.SignalogDataSet.StockControl, WareHouseFilter.Text)
        Me.PartTableAdapter.FillMiscParts(Me.SignalogDataSet.Part, WareHouseFilter.Text)
        DateAll.Checked = True
        ActAll.Checked = True
        PartAll.Checked = True
        Add.Checked = False
        Remove.Checked = False
        Part.Text = ""
        Quantity.Text = ""
        Note.Text = ""
    End Sub

    Private Sub Quantity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Quantity.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Sub ACTNUM_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ACTNUM.KeyPress
        e.Handled = TrapKey(Asc(e.KeyChar))
    End Sub

    Private Function TrapKey(ByVal KCode As String) As Boolean
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            TrapKey = False
        Else
            TrapKey = True
        End If
    End Function

    Private Sub Add_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.CheckedChanged
        If Add.Checked = True Then  'Adding 
            Note.Items.Clear()
            Note.Items.Add("Purchase New")
            Note.Items.Add("Add From Another WareHouse")
        Else  'Removing
            Note.Items.Clear()
            Note.Items.Add("Damaged")
            Note.Items.Add("Defective")
            Note.Items.Add("Obsolete")
            Note.Items.Add("Move To Another WareHouse")
        End If
    End Sub

    Private Sub Remove_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Remove.CheckedChanged
        If Add.Checked = True Then  'Adding 
            Note.Items.Clear()
            Note.Items.Add("Purchase New")
            Note.Items.Add("Add From Another WareHouse")
        Else  'Removing
            Note.Items.Clear()
            Note.Items.Add("Damaged")
            Note.Items.Add("Defective")
            Note.Items.Add("Obsolete")
            Note.Items.Add("Move To Another WareHouse")
        End If
    End Sub

    Private Sub Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Submit.Click
        If Add.Checked = False And Remove.Checked = False Then       'Checking for missing information
            MsgBox("Please select Add or Remove", MsgBoxStyle.Exclamation, "Missing Information")
        ElseIf Part.Text = String.Empty Then
            MsgBox("Please select part", MsgBoxStyle.Exclamation, "Missing Information")
        ElseIf Quantity.Text = String.Empty Then
            MsgBox("Please enter quantity", MsgBoxStyle.Exclamation, "Missing Information")
        ElseIf Note.Text = String.Empty Then
            MsgBox("Please specify note", MsgBoxStyle.Exclamation, "Missing Information")
        ElseIf WareHouseFilter.Text = String.Empty Then
            MsgBox("Please select WareHouse", MsgBoxStyle.Exclamation, "Missing Information")
        Else
            Dim id, PartID As Integer
            Dim PartDesc As String
            If SignalogDataSet.StockControl.Rows.Count = 0 Then   'First Entry
                id = 1
            Else
                id = StockControlTableAdapter.ReturnMaxID(WareHouseFilter.Text) + 1
            End If

            If Add.Checked = True Then  'Add
                Try
                    PartID = EQUIPMENTTableAdapter.ReturnMiscPartID(Part.SelectedValue, WareHouseFilter.Text)
                    PartDesc = EQUIPMENTTableAdapter.ReturnPartDesc(PartID, WareHouseFilter.Text)
                    'Insert Record in Stock Control
                    StockControlTableAdapter.Insert(id, Date.Now.Date, PartID, PartDesc, 0, WareHouseFilter.Text, "Add", Quantity.Text, Note.Text, 0)
                    'Update Quantity in Equipment (Local Inventory)
                    Dim Q As Integer
                    Q = EQUIPMENTTableAdapter.ReturnQuantity(Part.SelectedValue, "None", WareHouseFilter.Text)
                    Q += Quantity.Text
                    EQUIPMENTTableAdapter.UpdateQuantity(Q, PartID, WareHouseFilter.Text)
                Catch ex As Exception
                    MsgBox(ex, MsgBoxStyle.Critical, "Error!")
                End Try
            Else   'Remove
                Try
                    PartID = EQUIPMENTTableAdapter.ReturnMiscPartID(Part.SelectedValue, WareHouseFilter.Text)
                    'Insert Record in Stock Control
                    PartDesc = EQUIPMENTTableAdapter.ReturnPartDesc(PartID, WareHouseFilter.Text)
                    StockControlTableAdapter.Insert(id, Date.Now.Date, PartID, PartDesc, 0, WareHouseFilter.Text, "Rem", Quantity.Text, Note.Text, 0)
                    'Update Quantity in Equipment (Local Inventory)
                    Dim Q As Integer
                    Q = EQUIPMENTTableAdapter.ReturnQuantity(Part.SelectedValue, "None", WareHouseFilter.Text)
                    Q -= Quantity.Text
                    EQUIPMENTTableAdapter.UpdateQuantity(Q, PartID, WareHouseFilter.Text)
                Catch ex As Exception
                    MsgBox(ex, MsgBoxStyle.Critical, "Error!")
                End Try
            End If
            Me.StockControlTableAdapter.FillByWarehouse(Me.SignalogDataSet.StockControl, WareHouseFilter.Text)
            Quantity.Text = String.Empty
        End If

    End Sub

    Private Sub StockContView_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles StockContView.CellBeginEdit
        If StockContView.CurrentCellAddress.X = 1 Then    'Editing Date
            If StockContView.CurrentRow.Cells.Item(4).Value <> 0 Then
                MsgBox("This record is associated with activity " & StockContView.CurrentRow.Cells.Item(4).Value.ToString _
                   & ", Date can be edited from corresponding trouble report", MsgBoxStyle.Exclamation, "Edit Forbidden!")
                e.Cancel = True
            End If
        End If
        If StockContView.CurrentCellAddress.X = 7 Then   'Editing Quantity
            If StockContView.CurrentRow.Cells.Item(4).Value <> 0 Then
                MsgBox("This record is associated with activity " & StockContView.CurrentRow.Cells.Item(4).Value.ToString _
                    & ", Qauntity can be edited from corresponding trouble report", MsgBoxStyle.Exclamation, "Edit Forbidden!")
                e.Cancel = True
            Else
                OldQ = StockContView.CurrentRow.Cells.Item(7).Value
            End If
        End If
    End Sub

    Private Sub StockContView_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles StockContView.CellEndEdit
        If StockContView.CurrentCellAddress.X = 7 Then
            Dim Q As Integer
            If StockContView.CurrentRow.Cells.Item(6).Value = "Add" Then
                Q = EQUIPMENTTableAdapter.ReturnQuantityAtID(StockContView.CurrentRow.Cells.Item(2).Value, WareHouseFilter.Text)
                Q += StockContView.CurrentRow.Cells.Item(7).Value - OldQ
                EQUIPMENTTableAdapter.UpdateQuantity(Q, StockContView.CurrentRow.Cells.Item(2).Value, WareHouseFilter.Text)
            Else
                Q = EQUIPMENTTableAdapter.ReturnQuantityAtID(StockContView.CurrentRow.Cells.Item(2).Value, WareHouseFilter.Text)
                Q -= StockContView.CurrentRow.Cells.Item(7).Value - OldQ
                EQUIPMENTTableAdapter.UpdateQuantity(Q, StockContView.CurrentRow.Cells.Item(2).Value, WareHouseFilter.Text)
            End If
            OldQ = 0
            StockControlTableAdapter.UpdateQuantity(StockContView.CurrentRow.Cells.Item(7).Value, StockContView.CurrentRow.Cells.Item(0).Value, WareHouseFilter.Text)
        End If
    End Sub

    Private Sub StockContView_UserDeletedRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles StockContView.UserDeletedRow
        StockControlTableAdapter.Update(Me.SignalogDataSet.StockControl)
        Me.StockControlTableAdapter.FillByWarehouse(Me.SignalogDataSet.StockControl, WareHouseFilter.Text)
    End Sub

    Private Sub StockContView_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles StockContView.UserDeletingRow
        If StockContView.CurrentRow.Cells.Item(4).Value <> 0 Then
            MsgBox("Can't delete, this record is associated with activity " & StockContView.CurrentRow.Cells.Item(4).Value.ToString _
                    , MsgBoxStyle.Exclamation, "Delete Forbidden!")
            e.Cancel = True
        Else
            Dim result As MsgBoxResult
            result = MsgBox("Are you sure you want to delete the selected record?", MsgBoxStyle.YesNo, "Delete Record?")
            If result = MsgBoxResult.Yes Then
                Dim Q As Integer
                'Update quantity in local Inventory after deleting the record
                If StockContView.CurrentRow.Cells.Item(6).Value = "Add" Then   'Deleting an Add record
                    Q = EQUIPMENTTableAdapter.ReturnQuantityAtID(StockContView.CurrentRow.Cells.Item(2).Value, WareHouseFilter.Text)
                    Q -= StockContView.CurrentRow.Cells.Item(7).Value
                    EQUIPMENTTableAdapter.UpdateQuantity(Q, StockContView.CurrentRow.Cells.Item(2).Value, WareHouseFilter.Text)
                Else   'Deleting a Remove record
                    Q = EQUIPMENTTableAdapter.ReturnQuantityAtID(StockContView.CurrentRow.Cells.Item(2).Value, WareHouseFilter.Text)
                    Q += StockContView.CurrentRow.Cells.Item(7).Value
                    EQUIPMENTTableAdapter.UpdateQuantity(Q, StockContView.CurrentRow.Cells.Item(2).Value, WareHouseFilter.Text)
                End If
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Filter.Click
        Dim con, cmd As String
        Dim FirstFilter As Boolean = True
        con = My.Settings.SignalogConnectionString

        'Constructing the SQL command according to user selections
        cmd = "SELECT * FROM StockControl "
        'Filtering

        If DateAll.Checked = False Then
            cmd += "WHERE Date BETWEEN '" & FromDate.Text & "' AND '" & ToDate.Text & "' "
            FirstFilter = False
        End If

        If ActAll.Checked = False Then
            If ACTNUM.Text = String.Empty Then
                MsgBox("Please enter ACTNUM for filtering, or check all", MsgBoxStyle.Exclamation, "Filtering Error!")
            Else
                If FirstFilter = True Then
                    cmd += "WHERE ACTNUM='" & ACTNUM.Text & "' "
                    FirstFilter = False
                Else
                    cmd += "AND ACTNUM='" & ACTNUM.Text & "' "
                End If
            End If
        End If

        If PartAll.Checked = False Then
            If PartFilter.Text = String.Empty Then
                MsgBox("Please enter Part for filtering, or check all", MsgBoxStyle.Exclamation, "Filtering Error!")
            Else
                If FirstFilter = True Then
                    cmd += "WHERE PartID='" & EQUIPMENTTableAdapter.ReturnPartID(PartFilter.SelectedValue, "None", WareHouseFilter.Text) & "' "
                    FirstFilter = False
                Else
                    cmd += "AND PartID='" & EQUIPMENTTableAdapter.ReturnPartID(PartFilter.SelectedValue, "None", WareHouseFilter.Text) & "' "
                End If
            End If
        End If

        If FirstFilter = True Then
            cmd += "WHERE WareHouse='" & WareHouseFilter.Text & "'"
        Else
            cmd += "AND WareHouse='" & WareHouseFilter.Text & "'"
        End If

        Dim myDataAdapter As New SqlDataAdapter(cmd, con)
        SignalogDataSet.StockControl.Clear()
        myDataAdapter.Fill(SignalogDataSet.StockControl)

    End Sub

    Private Sub DateAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateAll.CheckedChanged
        If DateAll.Checked = True Then
            FromDate.Enabled = False
            ToDate.Enabled = False
        Else
            FromDate.Enabled = True
            ToDate.Enabled = True
        End If
    End Sub

    Private Sub ActAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActAll.CheckedChanged
        If ActAll.Checked = True Then
            ACTNUM.Enabled = False
            ACTNUM.Text = ""
        Else
            ACTNUM.Enabled = True
        End If
    End Sub

    Private Sub PartAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PartAll.CheckedChanged
        If PartAll.Checked = True Then
            PartFilter.Enabled = False
            PartFilter.Text = ""
        Else
            PartFilter.Enabled = True
        End If
    End Sub

    Private Sub WareHouseFilter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WareHouseFilter.SelectedIndexChanged
        Me.StockControlTableAdapter.FillByWarehouse(Me.SignalogDataSet.StockControl, WareHouseFilter.Text)
        Me.PartTableAdapter.FillMiscParts(Me.SignalogDataSet.Part, WareHouseFilter.Text)
        Part.Text = ""
        Quantity.Text = ""
        Note.Text = ""
    End Sub
End Class