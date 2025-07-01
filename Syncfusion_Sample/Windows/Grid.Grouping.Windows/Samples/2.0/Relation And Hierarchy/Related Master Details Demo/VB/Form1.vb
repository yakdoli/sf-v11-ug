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

Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.MetroForm


'/ <summary>
'/ This sample demonstrates how to manually specify master-details relations 
'/ between three separate tables that primary keys and foreign key columns
'/ in common. 
'/ </summary>

Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    Private gridGroupingControl1 As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Private components As System.ComponentModel.Container = Nothing


    Public Sub New()
        InitializeComponent()
        Try
            Dim ico As Icon = New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
            Me.Icon = ico
        Catch
        End Try
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
        Me.gridGroupingControl1 = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridGroupingControl1
        '
        Me.gridGroupingControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridGroupingControl1.BackColor = System.Drawing.SystemColors.Window
        Me.gridGroupingControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridGroupingControl1.Location = New System.Drawing.Point(16, 14)
        Me.gridGroupingControl1.Name = "gridGroupingControl1"
        Me.gridGroupingControl1.Size = New System.Drawing.Size(332, 304)
        Me.gridGroupingControl1.TabIndex = 0
        Me.gridGroupingControl1.TableDescriptor.AllowNew = False
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI"
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer)))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        Me.gridGroupingControl1.TableDescriptor.Appearance.AnySummaryCell.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer)))
        Me.gridGroupingControl1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = True
        Me.gridGroupingControl1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader"
        Me.gridGroupingControl1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25
        Me.gridGroupingControl1.TableDescriptor.TableOptions.RecordRowHeight = 20
        Me.gridGroupingControl1.Text = "gridGroupingControl1"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(368, 334)
        Me.Controls.Add(Me.gridGroupingControl1)
        Me.DropShadow = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Related Master Details Demo"
        CType(Me.gridGroupingControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.Run(New Form1())
    End Sub 'Main


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim parentTable As DataTable = GetParentTable()
        Dim childTable As DataTable = GetChildTable()
        Dim grandChildTable As DataTable = GetGrandChildTable()

        ' Manually specify relations in grouping engine. The DataSet does not need to have any DataRelations.
        ' This is the same approach that should be used if you want to set up relation ships
        ' between independent IList.
        Dim parentToChildRelationDescriptor As New GridRelationDescriptor()
        parentToChildRelationDescriptor.ChildTableName = "MyChildTable" ' same as SourceListSetEntry.Name for childTable (see below)
        parentToChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails
        parentToChildRelationDescriptor.RelationKeys.Add("parentID", "ParentID")

        ' Add relation to ParentTable 
        gridGroupingControl1.TableDescriptor.Relations.Add(parentToChildRelationDescriptor)

        Dim childToGrandChildRelationDescriptor As New GridRelationDescriptor()
        childToGrandChildRelationDescriptor.ChildTableName = "MyGrandChildTable" ' same as SourceListSetEntry.Name for grandChhildTable (see below)
        childToGrandChildRelationDescriptor.RelationKind = RelationKind.RelatedMasterDetails
        childToGrandChildRelationDescriptor.RelationKeys.Add("childID", "ChildID")

        ' Add relation to ChildTable 
        parentToChildRelationDescriptor.ChildTableDescriptor.Relations.Add(childToGrandChildRelationDescriptor)

        ' Register any DataTable/IList with SourceListSet, so that RelationDescriptor can resolve the name
        Me.gridGroupingControl1.Engine.SourceListSet.Add("MyParentTable", parentTable)
        Me.gridGroupingControl1.Engine.SourceListSet.Add("MyChildTable", childTable)
        Me.gridGroupingControl1.Engine.SourceListSet.Add("MyGrandChildTable", grandChildTable)

        Me.gridGroupingControl1.DataSource = parentTable

        'Me.gridGroupingControl1.GridVisualStyles= gridvisual

       
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = False
        'Me.BackColor = Color.FromArgb(223, 227, 239)

    End Sub 'Form1_Load


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

End Class 'Form1