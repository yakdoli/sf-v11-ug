#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Data

Imports Syncfusion.Grouping



Public Class Class1
    Private engine1 As Syncfusion.Grouping.Engine

    Public Sub New()
        engine1 = New Engine()

        Dim parentTable As DataTable = GetParentTable()
        Dim childTable As DataTable = GetChildTable()
        Dim grandChildTable As DataTable = GetGrandChildTable()

        ' Manually specify relations in grouping engine. The DataSet does not need to have any DataRelations.
        ' This is the same approach that should be used if you want to set up relation ships
        ' between independent IList.
        Dim parentToChildRelationDescriptor As New RelationDescriptor()
        parentToChildRelationDescriptor.ChildTableName = "MyChildTable" ' same as SourceListSetEntry.Name for childTable (see below)
        parentToChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails
        parentToChildRelationDescriptor.RelationKeys.Add("parentID", "ParentID")

        ' Add relation to ParentTable 
        engine1.TableDescriptor.Relations.Add(parentToChildRelationDescriptor)

        Dim childToGrandChildRelationDescriptor As New RelationDescriptor()
        childToGrandChildRelationDescriptor.ChildTableName = "MyGrandChildTable" ' same as SourceListSetEntry.Name for grandChhildTable (see below)
        childToGrandChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails
        childToGrandChildRelationDescriptor.RelationKeys.Add("childID", "ChildID")

        ' Add relation to ChildTable 
        parentToChildRelationDescriptor.ChildTableDescriptor.Relations.Add(childToGrandChildRelationDescriptor)

        ' Register any DataTable/IList with SourceListSet, so that RelationDescriptor can resolve the name
        Me.engine1.SourceListSet.Add("MyParentTable", parentTable)
        Me.engine1.SourceListSet.Add("MyChildTable", childTable)
        Me.engine1.SourceListSet.Add("MyGrandChildTable", grandChildTable)

        Me.engine1.SetSourceList(parentTable.DefaultView)
    End Sub 'New


    Private numberParentRows As Integer = 5
    Private numberChildRows As Integer = 20
    Private numberGrandChildRows As Integer = 50

    Private Function GetParentTable() As DataTable
        Dim dt As New DataTable("ParentTable")


        dt.Columns.Add(New DataColumn("parentID")) 'lower case p
        dt.Columns.Add(New DataColumn("ParentName"))
        dt.Columns.Add(New DataColumn("ParentDec"))

        Dim i As Integer
        For i = 0 To numberParentRows - 1
            Dim dr As DataRow = dt.NewRow()
            dr(0) = i '.ToString();
            dr(1) = String.Format("parentName{0}", i)
            dr(1) = String.Format("parentName{0}", i)
            dt.Rows.Add(dr)
        Next i

        Return dt
    End Function 'GetParentTable


    Private Function GetChildTable() As DataTable
        Dim dt As New DataTable("ChildTable")

        dt.Columns.Add(New DataColumn("childID")) 'lower case c
        dt.Columns.Add(New DataColumn("Name"))
        dt.Columns.Add(New DataColumn("ParentID")) 'upper case P
        Dim i As Integer
        For i = 0 To numberChildRows - 1
            Dim dr As DataRow = dt.NewRow()
            dr(0) = i.ToString()
            dr(1) = String.Format("ChildName{0}", i)
            dr(2) = (i Mod numberParentRows).ToString()
            dt.Rows.Add(dr)
        Next i

        Return dt
    End Function 'GetChildTable


    Private Function GetGrandChildTable() As DataTable
        Dim dt As New DataTable("GrandChildTable")

        dt.Columns.Add(New DataColumn("GrandChildID"))
        dt.Columns.Add(New DataColumn("Name"))
        dt.Columns.Add(New DataColumn("ChildID")) 'upper case C
        Dim i As Integer
        For i = 0 To numberGrandChildRows - 1
            Dim dr As DataRow = dt.NewRow()
            dr(0) = i.ToString()
            dr(1) = String.Format("GrandChildName{0}", i)
            dr(2) = (i Mod numberChildRows).ToString()
            dt.Rows.Add(dr)
        Next i

        Return dt
    End Function 'GetGrandChildTable


    Public Shared Sub Main()
        Dim c As New Class1()
        c.Run()

        Console.WriteLine("Please press <Enter> to continue.")
        Console.ReadLine()
    End Sub 'Main


    Public Sub Run()
        engine1.Table.ExpandAllRecords()
        Dim el As Element
        For Each el In engine1.Table.NestedDisplayElements
            Console.WriteLine(el.ToString())
        Next el
    End Sub 'Run
End Class 'Class1
