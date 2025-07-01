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
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.MetroForm
Imports Syncfusion.Windows.Forms.Grid.Grouping
Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    Private topList As BindingList(Of UniformChildList_2005.ParentObj) = New BindingList(Of UniformChildList_2005.ParentObj)()
    Private childList As BindingList(Of UniformChildList_2005.ChildObj) = New BindingList(Of UniformChildList_2005.ChildObj)()

    Public Sub New()
        InitializeComponent()
        SetupLists()

        GridGroupingControl1.DataSource = topList
        Try
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico

        Catch ex As Exception

        End Try


        Me.GridGroupingControl1.TableOptions.ShowRecordPlusMinus = True
        Me.GridGroupingControl1.NestedTableGroupOptions.ShowCaptionPlusMinus = False
        Me.GridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.GridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = False
        Me.GridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.GridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordAfterDetails = False
        Me.GridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.GridGroupingControl1.ChildGroupOptions.ShowAddNewRecordAfterDetails = False

        Me.GridGroupingControl1.Appearance.AlternateRecordFieldCell.BackColor = Color.FromArgb(255, 233, 176)
        Me.GridGroupingControl1.Appearance.AnyRecordFieldCell.TextColor = Color.FromArgb(0, 0, 102)

        Dim relation As GridRelationDescriptor = New GridRelationDescriptor()
        relation.RelationKind = RelationKind.UniformChildList
        relation.MappingName = "Child"
        relation.Name = "Child"
        relation.ChildTableName = "ChildTable"
        GridGroupingControl1.TableDescriptor.Relations.Add(relation)

        Me.GridGroupingControl1.ShowGroupDropArea = True
        Dim chiltTable As GridTable = GridGroupingControl1.GetTable("ChildTable")
        Me.GridGroupingControl1.AddGroupDropArea(chiltTable)
        chiltTable.TableDescriptor.GroupedColumns.Add("Field1")

        Me.GridGroupingControl1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.GridGroupingControl1.TableOptions.GridLineBorder = New Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
        Me.GridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.GridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
        Me.GridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
        Me.GridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue

    End Sub

    Private Function GetIconFile(ByVal bitmapName As String) As String
        For n As Integer = 0 To 9
            If System.IO.File.Exists(bitmapName) Then
                Return bitmapName
            End If

            bitmapName = "..\" & bitmapName
        Next n

        Return bitmapName
    End Function


    Private r As Random = New Random()
    Private Sub SetupLists()

        For i As Integer = 0 To 29
            childList.Add(New UniformChildList_2005.ChildObj(String.Format("Name{0}", r.Next(10)), String.Format("Desc{0}", r.Next(20)), r.Next(30)))
        Next i

        For i As Integer = 0 To 4
            topList.Add(New UniformChildList_2005.ParentObj(String.Format("Name{0}", r.Next(5)), String.Format("Desc{0}", r.Next(15)), r.Next(20)))
            Dim j As Integer = i * 5
            Do While j < (i * 5) + 5
                topList(i).Child.Add(childList(j))
                j += 1
            Loop
        Next i


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rec As Record = GridGroupingControl1.Table.Records(GridGroupingControl1.Table.Records.Count - 1)
        Dim field1 As String = rec.GetValue("Field1").ToString()
        Dim i As Integer = 0
        Do While i < topList.Count
            If field1 = topList(i).Field1 Then
                topList(i).Child.Add(New UniformChildList_2005.ChildObj(String.Format("Name{0}", r.Next(10)), String.Format("Desc{0}", r.Next(20)), r.Next(30)))
            End If
            i += 1
        Loop
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For i As Integer = 0 To 4
            childList.Add(New UniformChildList_2005.ChildObj(String.Format("Name{0}", r.Next(10)), String.Format("Desc{0}", r.Next(20)), r.Next(30)))
        Next i

        topList.Add(New UniformChildList_2005.ParentObj(String.Format("Name{0}", r.Next(2)), String.Format("Desc{0}", r.Next(15)), r.Next(20)))
        For j As Integer = 0 To 4
            topList(topList.Count - 1).Child.Add(childList(childList.Count - (1 + j)))
        Next j
    End Sub
End Class
