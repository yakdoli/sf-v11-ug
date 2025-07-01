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
Imports System.Text
Imports Syncfusion
Imports Syncfusion.Grouping

Imports Syncfusion.Collections
Imports Syncfusion.Drawing
Imports Syncfusion.ComponentModel



Public Class Class1
    Private engine1 As Syncfusion.Grouping.Engine
    
    
    Public Sub New()
        engine1 = New Engine()
        
        Dim customers As CustomerCollection = PopulateCustomers.CreateCustomers()
        
        Me.engine1.SetSourceList(customers)
        
        Dim relations As New RelationDescriptorCollection()
        
        ' First level
        Dim rd As RelationDescriptor = AddRelation("Level_0", relations)
        
        ' Subsequent levels
        Dim level As Integer
        For level = 1 To 6
            rd = AddRelation("Level_" + level.ToString(), rd.ChildTableDescriptor.Relations)
        Next level
        
        Me.engine1.TableDescriptor.Relations.InitializeFrom(relations)
        
        Me.engine1.Table.ExpandAllRecords()
    End Sub 'New
    
    
    Function AddRelation(name As String, relations As RelationDescriptorCollection) As RelationDescriptor
        Dim children As New RelationDescriptor()
        children.RelationKind = RelationKind.UniformChildList
        children.MappingName = "Children"
        children.Name = name
        relations.Add(children)
        Return children
    End Function 'AddRelation
    
    
    
    Public Shared Sub Main()
        Dim c As New Class1()
        c.Run()

        Console.WriteLine("Please press <Enter> to continue.")
        Console.ReadLine()
    End Sub 'Main
    
    
    Public Sub Run()
        Dim el As Element
        For Each el In  engine1.Table.NestedDisplayElements
            Console.WriteLine(el.ToString())
        Next el
    End Sub 'Run
End Class 'Class1 
