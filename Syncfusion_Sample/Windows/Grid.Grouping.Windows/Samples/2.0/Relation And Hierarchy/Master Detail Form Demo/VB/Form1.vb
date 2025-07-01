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
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.MetroForm

'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits Syncfusion.Windows.Forms.MetroForm
    Private parentTableGrid As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Private parentToChildGrid As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Private hierarchyGrid As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private label3 As System.Windows.Forms.Label
    Private childToGrandChildGrid As Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl
    Private label4 As System.Windows.Forms.Label
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

     
    '
    ' TODO: Add any constructor code after InitializeComponent call
    '
    
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
        Me.parentTableGrid = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        Me.parentToChildGrid = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        Me.hierarchyGrid = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        Me.label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.childToGrandChildGrid = New Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl()
        Me.label4 = New System.Windows.Forms.Label()
        CType(Me.parentTableGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parentToChildGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hierarchyGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.childToGrandChildGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'parentTableGrid
        '
        Me.parentTableGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.parentTableGrid.BackColor = System.Drawing.SystemColors.Window
        Me.parentTableGrid.Location = New System.Drawing.Point(16, 32)
        Me.parentTableGrid.Name = "parentTableGrid"
        Me.parentTableGrid.Size = New System.Drawing.Size(320, 128)
        Me.parentTableGrid.TabIndex = 0
        Me.parentTableGrid.Text = "parentTableGrid"
        '
        'parentToChildGrid
        '
        Me.parentToChildGrid.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.parentToChildGrid.BackColor = System.Drawing.SystemColors.Window
        Me.parentToChildGrid.Location = New System.Drawing.Point(16, 200)
        Me.parentToChildGrid.Name = "parentToChildGrid"
        Me.parentToChildGrid.Size = New System.Drawing.Size(320, 128)
        Me.parentToChildGrid.TabIndex = 1
        Me.parentToChildGrid.Text = "parentToChildGrid"
        '
        'hierarchyGrid
        '
        Me.hierarchyGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.hierarchyGrid.BackColor = System.Drawing.SystemColors.Window
        Me.hierarchyGrid.Location = New System.Drawing.Point(368, 32)
        Me.hierarchyGrid.Name = "hierarchyGrid"
        Me.hierarchyGrid.Size = New System.Drawing.Size(304, 464)
        Me.hierarchyGrid.TabIndex = 2
        Me.hierarchyGrid.Text = "hierarchyGrid"
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(16, 8)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(320, 16)
        Me.label1.TabIndex = 3
        Me.label1.Text = "Parent"
        '
        'label2
        '
        Me.label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(16, 176)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(320, 16)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Child"
        '
        'label3
        '
        Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(16, 344)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(320, 16)
        Me.label3.TabIndex = 5
        Me.label3.Text = "GrandChild"
        '
        'childToGrandChildGrid
        '
        Me.childToGrandChildGrid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.childToGrandChildGrid.BackColor = System.Drawing.SystemColors.Window
        Me.childToGrandChildGrid.Location = New System.Drawing.Point(16, 368)
        Me.childToGrandChildGrid.Name = "childToGrandChildGrid"
        Me.childToGrandChildGrid.Size = New System.Drawing.Size(320, 128)
        Me.childToGrandChildGrid.TabIndex = 6
        Me.childToGrandChildGrid.Text = "childToGrandChildGrid"
        '
        'label4
        '
        Me.label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.Location = New System.Drawing.Point(368, 8)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(80, 16)
        Me.label4.TabIndex = 7
        Me.label4.Text = "HierarchyGrid"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
        Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(696, 518)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.childToGrandChildGrid)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.hierarchyGrid)
        Me.Controls.Add(Me.parentToChildGrid)
        Me.Controls.Add(Me.parentTableGrid)
        Me.DropShadow = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(704, 552)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Detail Form Demo"
        CType(Me.parentTableGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parentToChildGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hierarchyGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.childToGrandChildGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Shared Sub Main()
        Application.Run(New Form1)
    End Sub 'Main


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dSet As New DataSet

        'get the tables
        Dim parentTable As DataTable = GetParentTable()
        Dim childTable As DataTable = GetChildTable()
        Dim grandChildTable As DataTable = GetGrandChildTable()
        dSet.Tables.AddRange(New DataTable() {parentTable, childTable, grandChildTable})

        'setup the relations
        Dim parentColumn As DataColumn = parentTable.Columns("parentID")
        Dim childColumn As DataColumn = childTable.Columns("ParentID")
        dSet.Relations.Add("ParentToChild", parentColumn, childColumn)

        parentColumn = childTable.Columns("childID")
        childColumn = grandChildTable.Columns("ChildID")
        dSet.Relations.Add("ChildToGrandChild", parentColumn, childColumn)

        'set the master-detail-detail grids
        Me.parentTableGrid.DataSource = parentTable 'master
        Me.parentTableGrid.TableDescriptor.Relations.Clear() ' don't autopopulate relations
        Me.parentToChildGrid.DataSource = parentTable 'detail1
        Me.parentToChildGrid.DataMember = "ParentToChild" 'detail1
        Me.parentToChildGrid.TableDescriptor.Relations.Clear() ' don't autopopulate relations
        Me.childToGrandChildGrid.DataSource = parentTable 'detail2
        Me.childToGrandChildGrid.DataMember = "ParentToChild.ChildToGrandChild" 'detail2
        Me.childToGrandChildGrid.TableDescriptor.Relations.Clear() ' don't autopopulate relations

        Me.parentTableGrid.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.parentTableGrid.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.parentTableGrid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.parentTableGrid.TopLevelGroupOptions.ShowCaption = False
      

        Me.parentToChildGrid.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.parentToChildGrid.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.parentToChildGrid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.parentToChildGrid.TopLevelGroupOptions.ShowCaption = False
        

        Me.childToGrandChildGrid.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.childToGrandChildGrid.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.childToGrandChildGrid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.childToGrandChildGrid.TopLevelGroupOptions.ShowCaption = False
        

        ' hierarchyGrid grid with hierarchical view
        Me.hierarchyGrid.DataSource = parentTable
        Me.hierarchyGrid.Engine.BindToCurrencyManager = False ' don't attach this one to CurrencyManager.

        Me.hierarchyGrid.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.hierarchyGrid.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.hierarchyGrid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
        Me.hierarchyGrid.TopLevelGroupOptions.ShowCaption = False
        

    End Sub 'Form1_Load
    Private parentRows As Integer = 10
    Private ChildRows As Integer = 30
    Private GrandChildRows As Integer = 80


    Private Function GetParentTable() As DataTable
        Dim dt As New DataTable("ParentTable")

        dt.Columns.Add(New DataColumn("parentID")) 'lower case p
        dt.Columns.Add(New DataColumn("ParentName"))

        Dim i As Integer
        For i = 0 To parentRows
            Dim dr As DataRow = dt.NewRow()
            dr(0) = i.ToString()
            dr(1) = String.Format("parentName{0}", i)
            dt.Rows.Add(dr)
        Next i

        Return dt
    End Function 'GetParentTable

    Private r As New Random()


    Private Function GetChildTable() As DataTable
        Dim dt As New DataTable("ChildTable")

        dt.Columns.Add(New DataColumn("childID")) 'lower case c
        dt.Columns.Add(New DataColumn("Name"))
        dt.Columns.Add(New DataColumn("ParentID")) 'upper case P
        Dim i As Integer
        For i = 0 To ChildRows
            Dim dr As DataRow = dt.NewRow()
            dr(0) = i.ToString()
            dr(1) = String.Format("ChildName{0}", i)
            dr(2) = r.Next(parentRows).ToString() '(i % parentRows).ToString();
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
        For i = 0 To GrandChildRows
            Dim dr As DataRow = dt.NewRow()
            dr(0) = i.ToString()
            dr(1) = String.Format("GrandChildName{0}", i)
            dr(2) = r.Next(ChildRows).ToString() '(i % ChildRows).ToString();
            dt.Rows.Add(dr)
        Next i

        Return dt
    End Function 'GetGrandChildTable
End Class 'Form1 