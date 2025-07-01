#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
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
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.MetroForm




'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    Private gridGroupingControl1 As GridGroupingControl
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()
        Try

            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico

        Catch ex As Exception

        End Try

        Dim rand As New Random()
        
        Dim table As New DataTable()
        table.Columns.Add("FooColumn1", GetType(Foo))
        table.Columns.Add("FooColumn2", GetType(NestedFoo))
        table.Columns.Add("Boolean", GetType(Boolean))
        table.Columns.Add("Color", GetType(Color))
        table.Columns.Add("Font", GetType(Font))
        table.Columns.Add("PatternStyle", GetType(Syncfusion.Drawing.PatternStyle))
        table.Columns.Add("DockStyle", GetType(DockStyle))
        table.Columns.Add("FieldDescriptor", GetType(FieldDescriptor))
        table.Columns.Add("BordersInfo", GetType(GridBordersInfo))
        
        
        ' and then add a few rows:
        Dim i As Integer
        For i = 0 To 51
            table.Rows.Add(table.NewRow())
            
            ' Simple nested properties
            Dim foo As New Foo()
            foo.PropertyOne = rand.Next().ToString()
            foo.PropertyTwo = rand.Next().ToString()
            table.Rows(i)(0) = foo
            
            ' Nested with nested properties
            Dim nestedFoo As New NestedFoo()
            nestedFoo.SomeProperty = rand.Next().ToString()
            nestedFoo.Inner.PropertyOne = rand.Next().ToString()
            nestedFoo.Inner.PropertyTwo = rand.Next().ToString()
            table.Rows(i)(1) = nestedFoo
            
            ' Boolean
            If i Mod 2 = 0 Then
                table.Rows(i)(2) = i Mod 4 = 0
            End If 
            ' Color
            table.Rows(i)(3) = SystemColors.ActiveBorder
            
            ' Font
            If i Mod 4 = 0 Then
                table.Rows(i)(4) = New Font("Arial", 12)
            End If

            table.Rows(i)("BordersInfo") = New GridBordersInfo()
            table.Rows(i)("FieldDescriptor") = New FieldDescriptor()

        Next i 
        ' now assign the datasource
        gridGroupingControl1 = New GridGroupingControl()
        gridGroupingControl1.Dock = DockStyle.Fill
        gridGroupingControl1.DataSource = table
        
        Dim td As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
        Dim unboundFd As New FieldDescriptor("Unbound")
        td.UnboundFields.Add(unboundFd)
        
        
        ' In case you want to manually add fields here
		gridGroupingControl1.TableDescriptor.Columns.Clear()
        gridGroupingControl1.TableDescriptor.Columns.Add("FooColumn1_PropertyOne")
        gridGroupingControl1.TableDescriptor.Columns.Add("FooColumn1_PropertyTwo")
        gridGroupingControl1.TableDescriptor.Columns.Add("FooColumn2_SomeProperty")
        gridGroupingControl1.TableDescriptor.Columns.Add("FooColumn2_Inner_PropertyOne")
        gridGroupingControl1.TableDescriptor.Columns.Add("FooColumn2_Inner_PropertyTwo")
        gridGroupingControl1.TableDescriptor.Columns.Add("Boolean")
        gridGroupingControl1.TableDescriptor.Columns.Add("Color")
        gridGroupingControl1.TableDescriptor.Columns.Add("Font")
        gridGroupingControl1.TableDescriptor.Columns.Add("PatternStyle")
        gridGroupingControl1.TableDescriptor.Columns.Add("DockStyle")
        gridGroupingControl1.TableDescriptor.Columns.Add("FieldDescriptor")
        gridGroupingControl1.TableDescriptor.Columns.Add("BordersInfo")
        gridGroupingControl1.TableDescriptor.Columns.Add("Unbound")
        
        Me.Controls.Add(gridGroupingControl1)
        
        AddHandler gridGroupingControl1.SaveValue, AddressOf grid_SaveValue
        AddHandler gridGroupingControl1.QueryValue, AddressOf grid_QueryValue
        Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro

        ' enable/disable UITYpeEditors for cells.
        Dim showUITypeEditors As Boolean = True
        Me.gridGroupingControl1.TableOptions.AllowDropDownCell = showUITypeEditors
        Me.gridGroupingControl1.TableDescriptor.Columns("Boolean").Appearance.AnyRecordFieldCell.CellType = "ComboBox"

        Console.WriteLine(GridPropertyTypeDefaultStyleCollection.Default("System.Boolean").Style)

        ' enable/disable UITYpeEditors for boolean cells only and show checkbox instead.
        Dim displayCheckBoxForBooleanFields As Boolean = False
        If displayCheckBoxForBooleanFields Then
            Dim booleanDefault As GridPropertyTypeDefaultStyle = Me.gridGroupingControl1.Engine.PropertyTypeDefaultStyles("System.Boolean")
             booleanDefault.AllowDropDown = False
        End If


        ' Sample code to get the row and column index in the grid for a column (works also
        ' if column sets with multiple rows are specified).
        Dim useOldCodeToGetCellInfo As Boolean = False
        If useOldCodeToGetCellInfo Then
            Dim cd As GridColumnDescriptor = Me.gridGroupingControl1.TableDescriptor.Columns("Boolean")
            Dim relativeRowIndex, colIndex As Integer
            Me.gridGroupingControl1.TableDescriptor.ColumnToRowColIndex(cd.MappingName, relativeRowIndex, colIndex)

            Dim r As Record = Me.gridGroupingControl1.Table.Records(0)
            Dim recordRowIndex As Integer = Me.gridGroupingControl1.Table.DisplayElements.IndexOf(r)

            Dim rowIndex As Integer = recordRowIndex + relativeRowIndex
            Dim style As GridTableCellStyleInfo = Me.gridGroupingControl1.Table.GetTableCellStyle(rowIndex, colIndex + Me.gridGroupingControl1.TableDescriptor.GetColumnIndentCount())

            Console.WriteLine(style.TableCellIdentity.ToString())
            Console.WriteLine(style.ToString())
        Else
            ' Newer code using new GetTableCellStyle overloads after version 3.0.0.16
            Dim r As Record = Me.gridGroupingControl1.Table.Records(0)
            Dim style As GridTableCellStyleInfo = Me.gridGroupingControl1.Table.GetTableCellStyle(r, "Boolean")

            Console.WriteLine(style.TableCellIdentity.ToString())
            Console.WriteLine(style.ToString())
        End If

        gridGroupingControl1.TableOptions.GridVisualStyles = GridVisualStyles.Metro
        gridGroupingControl1.TableOptions.GridLineBorder = New GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin)
        gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
        Me.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana"
        Me.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue

    End Sub 'New

    	Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

	
    '/ <summary>
    '/ Clean up any resources being used.
    '/ </summary>
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.DropShadow = True
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Custom Field Type Demo"
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
Application.EnableVisualStyles()
        Application.Run(New Form1())
    End Sub 'Main


    Private Sub grid_SaveValue(ByVal sender As Object, ByVal e As FieldValueEventArgs)
        Console.WriteLine("grid_SaveValue: " + e.ToString())
    End Sub 'grid_SaveValue


    Private Sub grid_QueryValue(ByVal sender As Object, ByVal e As FieldValueEventArgs)
        e.Value = e.Record.ParentTable.Records.IndexOf(e.Record)
    End Sub 'grid_QueryValue
End Class 'Form1

<TypeConverter(GetType(ExpandableObjectConverter))> _
Public Class Foo
    Private _someProperty As String
    Private _someProperty2 As String


    Public Property PropertyOne() As String
        Get
            Return _someProperty
        End Get
        Set(ByVal Value As String)
            _someProperty = Value
        End Set
    End Property


    Public Property PropertyTwo() As String
        Get
            Return _someProperty2
        End Get
        Set(ByVal Value As String)
            _someProperty2 = Value
        End Set
    End Property
End Class 'Foo

<TypeConverter(GetType(ExpandableObjectConverter))> _
Public Class NestedFoo
    Private _someProperty As String
    Private someFoo As New Foo


    Public Property SomeProperty() As String
        Get
            Return _someProperty
        End Get
        Set(ByVal Value As String)
            _someProperty = Value
        End Set
    End Property


    Public ReadOnly Property Inner() As Foo
        Get
            Return someFoo
        End Get
    End Property
End Class 'NestedFoo
