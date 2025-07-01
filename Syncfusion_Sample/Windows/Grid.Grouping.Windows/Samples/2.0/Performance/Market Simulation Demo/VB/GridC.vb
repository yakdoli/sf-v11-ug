#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Grid
Imports System.Data
Imports System.Drawing
Imports Syncfusion.Grouping

Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports System.Windows.Forms
Imports System.ComponentModel

#If (Not SyncfusionFramework2_0) Then
Namespace System.Collections.Generic
End Namespace
#End If

Namespace MarketSimulation
    Friend Class GridC : Inherits GridGroupingControl
        Public Sub SetStyles()

            Me.BlinkTime = 700
            '            this.UpdateDisplayFrequency = 0; // manually call Update for grid.
            '            this.UpdateDisplayFrequency = 1; // paint after each change.
            Me.UpdateDisplayFrequency = 50 ' paint every 50 ms. (but scroll window will force immediate paint ...)
            Me.SortPositionChangedBehavior = GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate
            Me.InsertRemoveBehavior = GridListChangedInsertRemoveBehavior.ScrollWithImmediateUpdate
            Me.BindToCurrencyManager = False
            Me.UseDefaultsForFasterDrawing = True

            ShowNavigationBar = False
            ShowGroupDropArea = True
            TopLevelGroupOptions.ShowCaption = False

            'TableDescriptor.ChildGroupOptions.ShowCaptionSummaryCells = true;
            TableDescriptor.ChildGroupOptions.ShowSummaries = False

            ' Fonts
            Me.Font = New Font("Verdana", System.Convert.ToSingle(8.5), FontStyle.Regular)
            GridGroupDropArea.Font = Me.Font

            ' General Cell Colour
            Appearance.AnyRecordFieldCell.BackColor = Color.FromArgb(255, 245, 227)

            ' Column Headers Cells
            Appearance.ColumnHeaderCell.Font.Bold = True

            ' Caption Cells
            Appearance.GroupCaptionCell.BackColor = Appearance.AnyRecordFieldCell.BackColor
            Appearance.GroupCaptionCell.TextColor = Appearance.AnyRecordFieldCell.TextColor
            Appearance.GroupCaptionCell.Borders.Top = New GridBorder(GridBorderStyle.Standard)
            Appearance.GroupCaptionCell.CellType = "Static"

            ' General Table Options
            TableOptions.CaptionRowHeight = TableOptions.RecordRowHeight
            TableOptions.IndentWidth = 16
            TableOptions.ListBoxSelectionMode = System.Windows.Forms.SelectionMode.One
            TableOptions.ListBoxSelectionCurrentCellOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionCurrentCellOptions.HideCurrentCell
            TableOptions.ListBoxSelectionColorOptions = Syncfusion.Windows.Forms.Grid.Grouping.GridListBoxSelectionColorOptions.ApplySelectionColor
            TableOptions.ShowRowHeader = False

            ' Highlighted Cells - doesn't seem to work
            TableOptions.SelectionBackColor = Color.Khaki
            TableOptions.SelectionTextColor = Color.Black

            ' Can't add rows
            ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
            TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
            NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
            TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue
            TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
            TopLevelGroupOptions.ShowCaption = False
            Appearance.AnyCell.Font.Facename = "Verdana"
            Appearance.AnyCell.TextColor = Color.MidnightBlue

            AddHandler Engine.QueryAddColumn, AddressOf Engine_QueryAddColumn

        End Sub

        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            MyBase.Dispose(disposing)
        End Sub

        'SetBoundList

        Public Shared Function CreateDataTable(ByVal ocList As OrderAgreementListC) As DataTable
            Dim table As DataTable = New DataTable

            If ocList Is Nothing Then
                Return table
            End If

            Dim record As OrderAgreementC

            If ocList.Count = 0 Then
                record = New OrderAgreementC
            Else
                record = ocList(0)
            End If

            Dim recordKeys As TypeSystemC.FidEnum() = New TypeSystemC.FidEnum(record.Count - 1) {}
            record.Keys.CopyTo(recordKeys, 0)

#If SyncfusionFramework2_0 Then
			For Each fid As TypeSystemC.FidEnum In recordKeys
#Else
            Dim n As Integer
            For n = recordKeys.Length - 1 To 0 Step -1
                Dim fid As TypeSystemC.FidEnum = recordKeys(n)
#End If
                'foreach (TypeSystemC.FidEnum fid in record.Keys)

                Dim name As String = TypeSystemC.FidName(fid)
                Dim type As type = TypeSystemC.FidType(fid)

                Dim col As DataColumn = New DataColumn(name, type)
                table.Columns.Add(col)
            Next n
            Dim oc As OrderAgreementC
            For Each oc In ocList
                Dim row As Object() = New Object(oc.Count - 1) {}

#If SyncfusionFramework2_0 Then
				Dim i As Integer = 0
				For Each o As Object In oc.Values
                    row(i) = o
                    i += 1
				Next o
#Else
                Dim i As Integer = oc.Count - 1
                Dim o As Object
                For Each o In oc.Values
                    row(i) = o
                    i -= 1
                Next o
#End If

                table.Rows.Add(row)
            Next oc

            Return table

        End Function

        Private Sub Engine_QueryAddColumn(ByVal sender As Object, ByVal e As GridQueryAddColumnEventArgs)
            e.GridColumn.AllowBlink = True
        End Sub 'Engine_QueryAddColumn   
    End Class
End Namespace
