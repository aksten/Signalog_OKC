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

Public Class Reindex
    Dim BusyFlag As Boolean

    Private Sub Reindex_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If BusyFlag = True Then
            MsgBox("Can't close, reindexing in progress...")
            e.Cancel = True
        End If
    End Sub

    Private Sub Reindex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BusyFlag = False
    End Sub

    Private Sub Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Click
        Me.LOCKEDITTableAdapter.Fill(Me.SignalogDataSet.LOCKEDIT)   'keep LOCKedit updated
        If SelTable.Text = String.Empty Then
            MsgBox("Please select table to reindex")
        ElseIf SignalogDataSet.LOCKEDIT.Rows.Count <> 0 Then   'If informarion is being edited
            MsgBox("Can't reindex while information is being edited, please try agin later")
        Else
            BusyFlag = True
            ProgressBar1.Style = ProgressBarStyle.Continuous
            Select Case SelTable.SelectedIndex
                Case 0
                    Reindex_Area()
                    MsgBox("Done!", MsgBoxStyle.Information, "Done")
                    ProgressBar1.Value = 0
                Case 1
                    Reindex_DispatchBy()
                    MsgBox("Done!", MsgBoxStyle.Information, "Done")
                    ProgressBar1.Value = 0
                Case 2
                    Reindex_Equipment()
                    MsgBox("Done!", MsgBoxStyle.Information, "Done")
                    ProgressBar1.Value = 0
                Case 3
                    Reindex_Equipment2()
                    MsgBox("Done!", MsgBoxStyle.Information, "Done")
                    ProgressBar1.Value = 0
                Case 4
                    Reindex_HolidayList()
                    MsgBox("Done!", MsgBoxStyle.Information, "Done")
                    ProgressBar1.Value = 0
                Case 5
                    Reindex_Holidays()
                    MsgBox("Done!", MsgBoxStyle.Information, "Done")
                    ProgressBar1.Value = 0
                Case 6
                    Reindex_Locations()
                    MsgBox("Done!", MsgBoxStyle.Information, "Done")
                    ProgressBar1.Value = 0
                Case 7
                    Reindex_Locations_Type()
                    MsgBox("Done!", MsgBoxStyle.Information, "Done")
                    ProgressBar1.Value = 0
                Case 8
                    Reindex_Manufacturer()
                    MsgBox("Done!", MsgBoxStyle.Information, "Done")
                    ProgressBar1.Value = 0
                Case 9
                    Reindex_Parts_List()
                    MsgBox("Done!", MsgBoxStyle.Information, "Done")
                    ProgressBar1.Value = 0
                Case 10
                    Reindex_Employees()
                    MsgBox("Done!", MsgBoxStyle.Information, "Done")
                    ProgressBar1.Value = 0
                Case 11
                    Reindex_Vehicles()
                    MsgBox("Done!", MsgBoxStyle.Information, "Done")
                    ProgressBar1.Value = 0
                Case 12
                    Reindex_StockControl()
                    MsgBox("Done!", MsgBoxStyle.Information, "Done")
                    ProgressBar1.Value = 0
                Case 13
                    Reindex_Area()
                    Reindex_DispatchBy()
                    Reindex_Equipment()
                    Reindex_Equipment2()
                    Reindex_HolidayList()
                    Reindex_Holidays()
                    Reindex_Locations()
                    Reindex_Locations_Type()
                    Reindex_Manufacturer()
                    Reindex_Parts_List()
                    Reindex_Employees()
                    Reindex_Vehicles()
                    Reindex_StockControl()
                    MsgBox("Done!", MsgBoxStyle.Information, "Done")
                    ProgressBar1.Value = 0
            End Select
            BusyFlag = False
        End If
    End Sub

    Sub Reindex_Area()
        Dim subtcount, i, j As Integer
        subtcount = 1
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = CUS0TableAdapter.ReturnMAXAREANUM
        ProgressBar1.Value = 0
        i = 1
        While i <= CUS0TableAdapter.ReturnMAXAREANUM
            If CUS0TableAdapter.ReturnAREANUMCOUNT(i) = 0 Then
                For j = i + 1 To CUS0TableAdapter.ReturnMAXAREANUM
                    If CUS0TableAdapter.ReturnAREANUMCOUNT(j) <> 0 Then
                        CUS0TableAdapter.UpdateID(j - subtcount, j)
                        EQUIPMENT2TableAdapter.UpdateAreaNumID(j - subtcount, j)
                        LOC0TableAdapter.UpdateAreaNumID(j - subtcount, j)
                    Else
                        subtcount += 1
                    End If
                Next j
                subtcount = 1
            End If
            ProgressBar1.Maximum = CUS0TableAdapter.ReturnMAXAREANUM
            ProgressBar1.Value = i
            i += 1
        End While
        LOCKNEWTableAdapter.UpdateLockValue(CUS0TableAdapter.ReturnMAXAREANUM - 1, "Area")
    End Sub

    Sub Reindex_DispatchBy()
        Dim subtcount, i, j As Integer
        subtcount = 1
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = DISP0TableAdapter.ReturnMAXDISPNUM
        ProgressBar1.Value = 0
        i = 1
        While i <= DISP0TableAdapter.ReturnMAXDISPNUM
            If DISP0TableAdapter.ReturnDISPNUMCOUNT(i) = 0 Then
                For j = i + 1 To DISP0TableAdapter.ReturnMAXDISPNUM
                    If DISP0TableAdapter.ReturnDISPNUMCOUNT(j) <> 0 Then
                        DISP0TableAdapter.UpdateID(j - subtcount, j)
                        ACT0TableAdapter.UpdateDispNumID(j - subtcount, j)
                    Else
                        subtcount += 1
                    End If
                Next j
                subtcount = 1
            End If
            ProgressBar1.Maximum = DISP0TableAdapter.ReturnMAXDISPNUM
            ProgressBar1.Value = i
            i += 1
        End While
        LOCKNEWTableAdapter.UpdateLockValue(DISP0TableAdapter.ReturnMAXDISPNUM - 1, "DispatchBy")
    End Sub

    Sub Reindex_Equipment()
        Dim subtcount, i, j As Integer
        Dim WareHouse As String
        subtcount = 1
        For k = 1 To 3
            If k = 1 Then
                WareHouse = "TUL"
            ElseIf k = 2 Then
                WareHouse = "OKC"
            ElseIf k = 3 Then
                WareHouse = "ARK"
            Else
                WareHouse = "N/A"
            End If

            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = EQUIPMENTTableAdapter.ReturnMaxPartID(WareHouse)
            ProgressBar1.Value = 0
            i = 1
            While i <= EQUIPMENTTableAdapter.ReturnMaxPartID(WareHouse)
                If EQUIPMENTTableAdapter.ReturnPartCount(i, WareHouse) = 0 Then
                    For j = i + 1 To EQUIPMENTTableAdapter.ReturnMaxPartID(WareHouse)
                        If EQUIPMENTTableAdapter.ReturnPartCount(j, WareHouse) <> 0 Then
                            EQUIPMENTTableAdapter.UpdateID(j - subtcount, j, WareHouse)
                            ACT3TableAdapter.UpdateLocalPartID(j - subtcount, j, WareHouse)
                            StockControlTableAdapter.UpdatePartID(j - subtcount, j, WareHouse)
                        Else
                            subtcount += 1
                        End If
                    Next j
                    subtcount = 1
                End If
                ProgressBar1.Maximum = EQUIPMENTTableAdapter.ReturnMaxPartID(WareHouse)
                ProgressBar1.Value = i
                i += 1
            End While
            LOCKNEWTableAdapter.UpdateLockValue(EQUIPMENTTableAdapter.ReturnMaxPartID(WareHouse) - 1, "LOCInventory" & WareHouse)
        Next k
    End Sub

    Sub Reindex_Equipment2()
        Dim subtcount, i, j As Integer
        subtcount = 1
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = EQUIPMENT2TableAdapter.ReturnMaxPartID
        ProgressBar1.Value = 0
        i = 1
        While i <= EQUIPMENT2TableAdapter.ReturnMaxPartID
            If EQUIPMENT2TableAdapter.ReturnPartCount(i) = 0 Then
                For j = i + 1 To EQUIPMENT2TableAdapter.ReturnMaxPartID
                    If EQUIPMENT2TableAdapter.ReturnPartCount(j) <> 0 Then
                        EQUIPMENT2TableAdapter.UpdateID(j - subtcount, j)
                        ACT3TableAdapter.UpdateCityOwnedPartID(j - subtcount, j)
                    Else
                        subtcount += 1
                    End If
                Next j
                subtcount = 1
            End If
            ProgressBar1.Maximum = EQUIPMENT2TableAdapter.ReturnMaxPartID
            ProgressBar1.Value = i
            i += 1
        End While
        LOCKNEWTableAdapter.UpdateLockValue(EQUIPMENT2TableAdapter.ReturnMaxPartID - 1, "COInventory")
    End Sub

    Sub Reindex_HolidayList()
        Dim subtcount, i, j As Integer
        subtcount = 1
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = Holiday_ListTableAdapter.ReturnMaxID
        ProgressBar1.Value = 0
        i = 1
        While i <= Holiday_ListTableAdapter.ReturnMaxID
            If Holiday_ListTableAdapter.ReturnCountID(i) = 0 Then
                For j = i + 1 To Holiday_ListTableAdapter.ReturnMaxID
                    If Holiday_ListTableAdapter.ReturnCountID(j) <> 0 Then
                        Holiday_ListTableAdapter.UpdateID(j - subtcount, j)
                    Else
                        subtcount += 1
                    End If
                Next j
                subtcount = 1
            End If
            ProgressBar1.Maximum = Holiday_ListTableAdapter.ReturnMaxID
            ProgressBar1.Value = i
            i += 1
        End While
        LOCKNEWTableAdapter.UpdateLockValue(Holiday_ListTableAdapter.ReturnMaxID - 1, "HolidayList")
    End Sub

    Sub Reindex_Holidays()
        Dim subtcount, i, j As Integer
        subtcount = 1
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = HolidaysTableAdapter.ReturnMaxID
        ProgressBar1.Value = 0
        i = 1
        While i <= HolidaysTableAdapter.ReturnMaxID
            If HolidaysTableAdapter.ReturnCountID(i) = 0 Then
                For j = i + 1 To HolidaysTableAdapter.ReturnMaxID
                    If HolidaysTableAdapter.ReturnCountID(j) <> 0 Then
                        HolidaysTableAdapter.UpdateID(j - subtcount, j)
                    Else
                        subtcount += 1
                    End If
                Next j
                subtcount = 1
            End If
            ProgressBar1.Maximum = HolidaysTableAdapter.ReturnMaxID
            ProgressBar1.Value = i
            i += 1
        End While
        LOCKNEWTableAdapter.UpdateLockValue(HolidaysTableAdapter.ReturnMaxID, "Holiday")
    End Sub

    Sub Reindex_Locations()
        Dim subtcount, i, j As Integer
        subtcount = 1
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = LOC0TableAdapter.ReturnMAXLOCNUM
        ProgressBar1.Value = 0
        i = 1
        While i <= LOC0TableAdapter.ReturnMAXLOCNUM
            If LOC0TableAdapter.ReturnLOCNUMCOUNT(i) = 0 Then
                For j = i + 1 To LOC0TableAdapter.ReturnMAXLOCNUM
                    If LOC0TableAdapter.ReturnLOCNUMCOUNT(j) <> 0 Then
                        LOC0TableAdapter.UpdateID(j - subtcount, j)
                        ACT0TableAdapter.UpdateLocNumID(j - subtcount, j)
                    Else
                        subtcount += 1
                    End If
                Next j
                subtcount = 1
            End If
            ProgressBar1.Maximum = LOC0TableAdapter.ReturnMAXLOCNUM
            ProgressBar1.Value = i
            i += 1
        End While
        LOCKNEWTableAdapter.UpdateLockValue(LOC0TableAdapter.ReturnMAXLOCNUM - 1, "Locations")
    End Sub

    Sub Reindex_Locations_Type()
        Dim subtcount, i, j As Integer
        subtcount = 1
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = LOC1TableAdapter.ReturnMAXTYPENUM
        ProgressBar1.Value = 0
        i = 1
        While i <= LOC1TableAdapter.ReturnMAXTYPENUM
            If LOC1TableAdapter.ReturnTYPENUMCOUNT(i) = 0 Then
                For j = i + 1 To LOC1TableAdapter.ReturnMAXTYPENUM
                    If LOC1TableAdapter.ReturnTYPENUMCOUNT(j) <> 0 Then
                        LOC1TableAdapter.UpdateID(j - subtcount, j)
                        LOC0TableAdapter.UpdateTypeNumID(j - subtcount, j)
                    Else
                        subtcount += 1
                    End If
                Next j
                subtcount = 1
            End If
            ProgressBar1.Maximum = LOC1TableAdapter.ReturnMAXTYPENUM
            ProgressBar1.Value = i
            i += 1
        End While
        LOCKNEWTableAdapter.UpdateLockValue(LOC1TableAdapter.ReturnMAXTYPENUM - 1, "LocationsType")
    End Sub

    Sub Reindex_Manufacturer()
        Dim subtcount, i, j As Integer
        subtcount = 1
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = MANF_LISTTableAdapter.ReturnMaxID
        ProgressBar1.Value = 0
        i = 1
        While i <= MANF_LISTTableAdapter.ReturnMaxID
            If MANF_LISTTableAdapter.ReturnCountID(i) = 0 Then
                For j = i + 1 To MANF_LISTTableAdapter.ReturnMaxID
                    If MANF_LISTTableAdapter.ReturnCountID(j) <> 0 Then
                        MANF_LISTTableAdapter.UpdateID(j - subtcount, j)
                    Else
                        subtcount += 1
                    End If
                Next j
                subtcount = 1
            End If
            ProgressBar1.Maximum = MANF_LISTTableAdapter.ReturnMaxID
            ProgressBar1.Value = i
            i += 1
        End While
        LOCKNEWTableAdapter.UpdateLockValue(MANF_LISTTableAdapter.ReturnMaxID - 1, "ManufList")
    End Sub

    Sub Reindex_Parts_List()
        Dim subtcount, i, j As Integer
        subtcount = 1
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = Parts_ListTableAdapter.ReturnMaxID
        ProgressBar1.Value = 0
        i = 1
        While i <= Parts_ListTableAdapter.ReturnMaxID
            If Parts_ListTableAdapter.ReturnCountID(i) = 0 Then
                For j = i + 1 To Parts_ListTableAdapter.ReturnMaxID
                    If Parts_ListTableAdapter.ReturnCountID(j) <> 0 Then
                        Parts_ListTableAdapter.UpdateID(j - subtcount, j)
                    Else
                        subtcount += 1
                    End If
                Next j
                subtcount = 1
            End If
            ProgressBar1.Maximum = Parts_ListTableAdapter.ReturnMaxID
            ProgressBar1.Value = i
            i += 1
        End While
        LOCKNEWTableAdapter.UpdateLockValue(Parts_ListTableAdapter.ReturnMaxID - 1, "PartList")
    End Sub

    Sub Reindex_Employees()
        Dim subtcount, i, j As Integer
        subtcount = 1
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = PERS0TableAdapter.ReturnMaxID
        ProgressBar1.Value = 0
        i = 1
        While i <= PERS0TableAdapter.ReturnMaxID
            If PERS0TableAdapter.ReturnCountID(i) = 0 Then
                For j = i + 1 To PERS0TableAdapter.ReturnMaxID
                    If PERS0TableAdapter.ReturnCountID(j) <> 0 Then
                        PERS0TableAdapter.UpdateID(j - subtcount, j)
                        ACT0TableAdapter.UpdateEmpNumID(j - subtcount, j)
                    Else
                        subtcount += 1
                    End If
                Next j
                subtcount = 1
            End If
            ProgressBar1.Maximum = PERS0TableAdapter.ReturnMaxID
            ProgressBar1.Value = i
            i += 1
        End While
        LOCKNEWTableAdapter.UpdateLockValue(PERS0TableAdapter.ReturnMaxID - 1, "Employees")
    End Sub

    Sub Reindex_Vehicles()
        Dim subtcount, i, j As Integer
        subtcount = 1
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = VEHICLETableAdapter.ReturnMaxID
        ProgressBar1.Value = 0
        i = 1
        While i <= VEHICLETableAdapter.ReturnMaxID
            If VEHICLETableAdapter.ReturnCountID(i) = 0 Then
                For j = i + 1 To VEHICLETableAdapter.ReturnMaxID
                    If VEHICLETableAdapter.ReturnCountID(j) <> 0 Then
                        VEHICLETableAdapter.UpdateID(j - subtcount, j)
                    Else
                        subtcount += 1
                    End If
                Next j
                subtcount = 1
            End If
            ProgressBar1.Maximum = VEHICLETableAdapter.ReturnMaxID
            ProgressBar1.Value = i
            i += 1
        End While
        LOCKNEWTableAdapter.UpdateLockValue(VEHICLETableAdapter.ReturnMaxID - 1, "Vehicle")
    End Sub

    Sub Reindex_StockControl()
        Dim subtcount, i, j As Integer
        Dim WareHouse As String
        For k = 1 To 3
            If k = 1 Then
                WareHouse = "TUL"
            ElseIf k = 2 Then
                WareHouse = "OKC"
            ElseIf k = 3 Then
                WareHouse = "ARK"
            Else
                WareHouse = "N/A"
            End If
            subtcount = 1
            ProgressBar1.Minimum = 0
            ProgressBar1.Maximum = StockControlTableAdapter.ReturnMaxID(WareHouse)
            ProgressBar1.Value = 0
            i = 1
            While i <= StockControlTableAdapter.ReturnMaxID(WareHouse)
                If StockControlTableAdapter.ReturnCountID(i, WareHouse) = 0 Then
                    For j = i + 1 To StockControlTableAdapter.ReturnMaxID(WareHouse)
                        If StockControlTableAdapter.ReturnCountID(j, WareHouse) <> 0 Then
                            StockControlTableAdapter.UpdateID(j - subtcount, j, WareHouse)
                        Else
                            subtcount += 1
                        End If
                    Next j
                    subtcount = 1
                End If
                ProgressBar1.Maximum = StockControlTableAdapter.ReturnMaxID(WareHouse)
                ProgressBar1.Value = i
                i += 1
            End While
        Next k
    End Sub

End Class