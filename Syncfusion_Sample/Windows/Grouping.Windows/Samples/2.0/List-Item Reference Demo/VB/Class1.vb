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
        
        Dim usStates As USStatesCollection = USStatesCollection.CreateDefaultCollection()
        Dim countries As CountriesCollection = CountriesCollection.CreateDefaultCollection()
        
        Me.engine1.SourceListSet.Add("Countries", countries)
        Me.engine1.SourceListSet.Add("USStates", usStates)
        
        Dim table As New DataTable()
        table.Columns.Add("Id", GetType(String))
        table.Columns.Add("Country", GetType(Country))
        table.Columns.Add("State", GetType(USState))
        
        ' and then add a few rows:
        Dim i As Integer
        For i = 0 To 51
            table.Rows.Add(table.NewRow())
            table.Rows(i)(0) = i
            table.Rows(i)(1) = countries((i Mod 8))
            If i Mod 8 = 0 Then
                table.Rows(i)(2) = usStates((i / 8))
            End If
        Next i 
        Dim mainTd As TableDescriptor = Me.engine1.TableDescriptor
        'mainTd.Fields.ExpandProperties = false;
        Dim usStatesRd As New RelationDescriptor()
        usStatesRd.Name = "State"
        usStatesRd.MappingName = "State" ' FieldName in table
        usStatesRd.ChildTableName = "USStates" ' SourceListSet name for lookup
        usStatesRd.RelationKind = RelationKind.ListItemReference
        usStatesRd.ChildTableDescriptor.SortedColumns.Add("Name")
        'usStatesRd.ChildTableDescriptor.AllowEdit = false;
        'usStatesRd.ChildTableDescriptor.AllowNew = false;  // Make pencil icon disappear, users can't modify states.
        mainTd.Relations.Add(usStatesRd)
        
        Dim countriesRd As New RelationDescriptor()
        countriesRd.Name = "Country"
        countriesRd.MappingName = "Country" ' FieldName in table
        countriesRd.ChildTableName = "Countries" ' SourceListSet name for lookup
        countriesRd.RelationKind = RelationKind.ListItemReference
        countriesRd.ChildTableDescriptor.AllowEdit = True
        countriesRd.ChildTableDescriptor.AllowNew = True ' Make pencil icon appear, allow user to add countries (these setting will be overriden by CountriesCollection.IsReadOnly / CountriesCollection.IsFixedSize properties if they are true).
        mainTd.Relations.Add(countriesRd)
        Me.engine1.SetSourceList(table.DefaultView)
    End Sub 'New
    
    
    Public Shared Sub Main()
        Dim c As New Class1()
        c.Run()
        Console.WriteLine("Please press <Enter> to continue.")
        Console.ReadLine()
    End Sub 'Main
    
    
    Public Sub Run()
        Dim r As Record
        For Each r In  engine1.Table.FilteredRecords
            ' Print record fields
            Console.WriteLine(r.ToString())

            Console.WriteLine(r.GetValue("State.Name"))
            
            ' Get related record in foreign table.
            Dim usStatesRd As RelationDescriptor = r.ParentTableDescriptor.Relations("State")
            If Not TypeOf r.GetValue("State") Is DBNull Then
                Dim state As USState = CType(r.GetValue("State"), USState)
                Console.WriteLine(state.Name)
            End If
        Next r
    End Sub 'Run
End Class 'Class1
