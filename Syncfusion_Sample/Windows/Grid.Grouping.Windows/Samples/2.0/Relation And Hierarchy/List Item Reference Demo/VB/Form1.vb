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

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.MetroForm


'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    '/ <summary>
    '/ Required designer variable.
    '/ </summary>
    Private components As System.ComponentModel.Container = Nothing
    
    
    Public Sub New()
        '
        ' Required for Windows Form Designer support
        '
        InitializeComponent()

        Try
            Dim ico As Icon = New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try


        Dim usStates As USStatesCollection = USStatesCollection.CreateDefaultCollection()
        Dim countries As CountriesCollection = CountriesCollection.CreateDefaultCollection()

        Me.gridGroupingControl1.Engine.SourceListSet.Add("Countries", countries)
        Me.gridGroupingControl1.Engine.SourceListSet.Add("USStates", usStates)

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
        Dim mainTd As GridTableDescriptor = Me.gridGroupingControl1.TableDescriptor
        Dim usStatesRd As New GridRelationDescriptor()
        usStatesRd.Name = "State"
        usStatesRd.MappingName = "State" ' FieldName in table
        usStatesRd.ChildTableName = "USStates" ' SourceListSet name for lookup
        usStatesRd.RelationKind = RelationKind.ListItemReference
        usStatesRd.ChildTableDescriptor.Appearance.AlternateRecordFieldCell.BackColor = Color.FromArgb(255, 245, 227)
        usStatesRd.ChildTableDescriptor.VisibleColumns.Add("Name")
        usStatesRd.ChildTableDescriptor.SortedColumns.Add("Name")
       mainTd.Relations.Add(usStatesRd)

        Dim countriesRd As New GridRelationDescriptor()
        countriesRd.Name = "Country"
        countriesRd.MappingName = "Country" ' FieldName in table
        countriesRd.ChildTableName = "Countries" ' SourceListSet name for lookup
        countriesRd.RelationKind = RelationKind.ListItemReference
        countriesRd.ChildTableDescriptor.Appearance.AlternateRecordFieldCell.BackColor = Color.FromArgb(255, 245, 227)
        countriesRd.ChildTableDescriptor.AllowEdit = True
        countriesRd.ChildTableDescriptor.AllowNew = True ' Make pencil icon appear, allow user to add countries (these setting will be overriden by CountriesCollection.IsReadOnly / CountriesCollection.IsFixedSize properties if they are true).
        mainTd.Relations.Add(countriesRd)


        Me.gridGroupingControl1.DataSource = table
        
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
        Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
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

     
    ' After data source was set you could call LoadDefault and remove columns
    '			mainTd.Columns.LoadDefault();
    '			mainTd.Columns.Remove("Country.CountryCode");
    
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
        Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridGroupingControl1
        '
        Me.gridGroupingControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
        Me.gridGroupingControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridGroupingControl1.IntelliMousePanning = True
        Me.gridGroupingControl1.Location = New System.Drawing.Point(16, 16)
        Me.gridGroupingControl1.Name = "gridGroupingControl1"
        Me.gridGroupingControl1.Size = New System.Drawing.Size(713, 390)
        Me.gridGroupingControl1.TabIndex = 0
        Me.gridGroupingControl1.Text = "gridGroupingControl1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(747, 423)
        Me.Controls.Add(Me.gridGroupingControl1)
        Me.DropShadow = True
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Item Reference Demo"
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()

#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
        Application.EnableVisualStyles()
#End If
        Application.Run(New Form1())
    End Sub 'Main
End Class 'Form1