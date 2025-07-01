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
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms

 
Public Class Form1
   Inherits System.Windows.Forms.Form
   Private gridDataBoundGrid1 As Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
   Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
   Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
   Private WithEvents checkBox3 As System.Windows.Forms.CheckBox
    Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents button2 As Syncfusion.Windows.Forms.ButtonAdv
    Private WithEvents button3 As Syncfusion.Windows.Forms.ButtonAdv
    Private panel1 As System.Windows.Forms.Panel
    
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
      '
      ' Required for Windows Form Designer support
      '
        InitializeComponent()
        Try
            Dim ico As System.Drawing.Icon = New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
            Me.Icon = ico
        Catch ex As Exception

        End Try
        Me.gridDataBoundGrid1.GridVisualStyles = GridVisualStyles.Office2007Blue
        Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
        Me.gridDataBoundGrid1.Model.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
        Dim style As GridStyleInfo = gridDataBoundGrid1.BaseStylesMap("Header").StyleInfo
        style.TextColor = Color.MidnightBlue
        style.Font.Facename = "Verdana"
        Me.BackColor = Color.FromArgb(223, 227, 239)
        Me.StartPosition = FormStartPosition.CenterScreen
   End Sub 'New
    
    
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
        Dim GridStyleInfo1 As Syncfusion.Windows.Forms.Grid.GridStyleInfo = New Syncfusion.Windows.Forms.Grid.GridStyleInfo
        Me.gridDataBoundGrid1 = New Syncfusion.Windows.Forms.Grid.GridDataBoundGrid
        Me.checkBox1 = New System.Windows.Forms.CheckBox
        Me.checkBox2 = New System.Windows.Forms.CheckBox
        Me.checkBox3 = New System.Windows.Forms.CheckBox
        Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.button2 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.button3 = New Syncfusion.Windows.Forms.ButtonAdv
        Me.panel1 = New System.Windows.Forms.Panel
        CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridDataBoundGrid1
        '
        Me.gridDataBoundGrid1.AllowDragSelectedCols = True
        Me.gridDataBoundGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridDataBoundGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.gridDataBoundGrid1.DefaultColWidth = 70
        Me.gridDataBoundGrid1.DefaultRowHeight = 18
        Me.gridDataBoundGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gridDataBoundGrid1.Location = New System.Drawing.Point(18, 158)
        Me.gridDataBoundGrid1.Name = "gridDataBoundGrid1"
        Me.gridDataBoundGrid1.OptimizeInsertRemoveCells = True
        Me.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus
        Me.gridDataBoundGrid1.ShowTreeLines = True
        Me.gridDataBoundGrid1.Size = New System.Drawing.Size(406, 368)
        Me.gridDataBoundGrid1.SmartSizeBox = False
        Me.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick
        Me.gridDataBoundGrid1.TabIndex = 0
        GridStyleInfo1.Font.Bold = False
        GridStyleInfo1.Font.Facename = "Microsoft Sans Serif"
        GridStyleInfo1.Font.Italic = False
        GridStyleInfo1.Font.Size = 8.25!
        GridStyleInfo1.Font.Strikeout = False
        GridStyleInfo1.Font.Underline = False
        Me.gridDataBoundGrid1.TableStyle = GridStyleInfo1
        Me.gridDataBoundGrid1.Text = "gridDataBoundGrid1"
        Me.gridDataBoundGrid1.ThemesEnabled = True
        Me.gridDataBoundGrid1.UseListChangedEvent = True
        '
        'checkBox1
        '
        Me.checkBox1.Checked = True
        Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.checkBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox1.Location = New System.Drawing.Point(19, 40)
        Me.checkBox1.Name = "checkBox1"
        Me.checkBox1.Size = New System.Drawing.Size(125, 24)
        Me.checkBox1.TabIndex = 1
        Me.checkBox1.Text = "Hide Row Header"
        '
        'checkBox2
        '
        Me.checkBox2.Checked = True
        Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.checkBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox2.Location = New System.Drawing.Point(19, 64)
        Me.checkBox2.Name = "checkBox2"
        Me.checkBox2.Size = New System.Drawing.Size(104, 24)
        Me.checkBox2.TabIndex = 2
        Me.checkBox2.Text = "No Color"
        '
        'checkBox3
        '
        Me.checkBox3.Checked = True
        Me.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.checkBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkBox3.Location = New System.Drawing.Point(19, 88)
        Me.checkBox3.Name = "checkBox3"
        Me.checkBox3.Size = New System.Drawing.Size(104, 24)
        Me.checkBox3.TabIndex = 3
        Me.checkBox3.Text = "No Gridlines"
        '
        'button1
        '
        Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(246, 38)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(178, 23)
        Me.button1.TabIndex = 5
        Me.button1.Text = "Auto size TreelineCell Column"
        Me.button1.UseVisualStyle = True
        '
        'button2
        '
        Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(246, 70)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(178, 23)
        Me.button2.TabIndex = 6
        Me.button2.Text = "Expand All"
        Me.button2.UseVisualStyle = True
        '
        'button3
        '
        Me.button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(246, 102)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(178, 23)
        Me.button3.TabIndex = 7
        Me.button3.Text = "Collapse All"
        Me.button3.UseVisualStyle = True
        '
        'panel1
        '
        Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(440, 542)
        Me.panel1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 542)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.checkBox3)
        Me.Controls.Add(Me.checkBox2)
        Me.Controls.Add(Me.checkBox1)
        Me.Controls.Add(Me.gridDataBoundGrid1)
        Me.Controls.Add(Me.panel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GDBG Tree Lines Demo"
        CType(Me.gridDataBoundGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region


    Private level0 As GridHierarchyLevel
    Private level1 As GridHierarchyLevel
    Private level2 As GridHierarchyLevel
    Private level3 As GridHierarchyLevel
    Private level4 As GridHierarchyLevel

    <STAThread()> _
Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
        Application.Run(New Form1())
    End Sub 'Main


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim parentTable As DataTable = GetParentTable()
        Dim childTable As DataTable = GetChildTable()
        Dim grandChildTable As DataTable = GetGrandChildTable()
        Dim greatGrandChildTable As DataTable = GetGreatGrandChildTable()
        Dim greatGreatGrandChildTable As DataTable = GetGreatGreatGrandChildTable()

        Dim ds As New DataSet()
        ds.Tables.AddRange(New DataTable() {parentTable, childTable, grandChildTable, greatGrandChildTable, greatGreatGrandChildTable})

        ds.Relations.Add(New DataRelation("ParentToChild", ds.Tables(0).Columns("parentID"), ds.Tables(1).Columns("ParentID")))
        ds.Relations.Add(New DataRelation("ChildToGrandChild", ds.Tables(1).Columns("childID"), ds.Tables(2).Columns("ChildID")))
        ds.Relations.Add(New DataRelation("GrandChildToGreatGrandChild", ds.Tables(2).Columns("grandChildID"), ds.Tables(3).Columns("GrandChildID")))
        ds.Relations.Add(New DataRelation("GreatGrandChildToGreatGreatGrandChild", ds.Tables(3).Columns("greatGrandChildID"), ds.Tables(4).Columns("GreatGrandChildID")))

        Me.gridDataBoundGrid1.DataSource = ds
        Me.gridDataBoundGrid1.DataMember = parentTable.TableName

        level0 = Me.gridDataBoundGrid1.Binder.RootHierarchyLevel
        level1 = Me.gridDataBoundGrid1.Binder.AddRelation("ParentToChild")
        level2 = Me.gridDataBoundGrid1.Binder.AddRelation("ChildToGrandChild")
        level3 = Me.gridDataBoundGrid1.Binder.AddRelation("GrandChildToGreatGrandChild")
        level4 = Me.gridDataBoundGrid1.Binder.AddRelation("GreatGrandChildToGreatGreatGrandChild")

        Me.gridDataBoundGrid1.Model.Options.ResizeColsBehavior = Me.gridDataBoundGrid1.Model.Options.ResizeColsBehavior Or GridResizeCellsBehavior.InsideGrid

        Me.gridDataBoundGrid1.TableStyle.WrapText = False

        Me.gridDataBoundGrid1.CurrentCell.MoveTo(Me.gridDataBoundGrid1.Model.Rows.HeaderCount + 1, 3)
        Me.gridDataBoundGrid1.Binder.EnableAddNew = False
        Me.gridDataBoundGrid1.Properties.BackgroundColor = SystemColors.Window

        'set display to use initial settings
        checkBox1_CheckedChanged(Me, EventArgs.Empty)
        checkBox2_CheckedChanged(Me, EventArgs.Empty)
        checkBox3_CheckedChanged(Me, EventArgs.Empty)
    End Sub 'Form1_Load 
	
	Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function


#Region "DataTables"

    Private numberParentRows As Integer = 5
    Private numberChildRows As Integer = 20
    Private numberGrandChildRows As Integer = 50
    Private numberGreatGrandChildRows As Integer = 150
    Private numberGreatGreatGrandChildRows As Integer = 250


    Private Function GetParentTable() As DataTable
        Dim dt As New DataTable("ParentTable")


        dt.Columns.Add(New DataColumn("ParentName"))
        dt.Columns.Add(New DataColumn("parentID")) 'lower case p
        dt.Columns.Add(New DataColumn("ParentDec"))

        Dim i As Integer = 0

        While i < numberParentRows
            Dim dr As DataRow = dt.NewRow()
            dr(1) = i '.ToString();
            dr(0) = String.Format("parentName{0}", i)
            dr(2) = String.Format("desc{0}", i)
            dt.Rows.Add(dr)
            i += 1
        End While

        Return dt
    End Function 'GetParentTable

    Private r As New Random()

    Private Function GetChildTable() As DataTable
        Dim dt As New DataTable("ChildTable")

        dt.Columns.Add(New DataColumn("ChildName"))
        dt.Columns.Add(New DataColumn("childID")) 'lower case c
        dt.Columns.Add(New DataColumn("ParentID")) 'upper case P
        Dim i As Integer = 0

        While i < numberChildRows
            Dim dr As DataRow = dt.NewRow()
            dr(1) = i.ToString()
            dr(0) = String.Format("ChildName{0}", i)
            dr(2) = r.Next(numberParentRows).ToString() '(i % numberParentRows).ToString();
            dt.Rows.Add(dr)
            i += 1
        End While

        Return dt
    End Function 'GetChildTable


    Private Function GetGrandChildTable() As DataTable
        Dim dt As New DataTable("GrandChildTable")

        dt.Columns.Add(New DataColumn("GrandChildName"))
        dt.Columns.Add(New DataColumn("grandChildID"))
        dt.Columns.Add(New DataColumn("ChildID")) 'upper case C
        Dim i As Integer = 0

        While i < numberGrandChildRows
            Dim dr As DataRow = dt.NewRow()
            dr(1) = i.ToString()
            dr(0) = String.Format("GrandChildName{0}", i)
            dr(2) = r.Next(numberChildRows).ToString() '(i % numberChildRows).ToString();
            dt.Rows.Add(dr)
            i += 1
        End While

        Return dt
    End Function 'GetGrandChildTable


    Private Function GetGreatGrandChildTable() As DataTable
        Dim dt As New DataTable("GreatGrandChildTable")

        dt.Columns.Add(New DataColumn("GreatGrandChildName"))
        dt.Columns.Add(New DataColumn("greatGrandChildID"))
        dt.Columns.Add(New DataColumn("GrandChildID")) 'upper case C
        Dim i As Integer = 0

        While i < numberGreatGrandChildRows
            Dim dr As DataRow = dt.NewRow()
            dr(1) = i.ToString()
            dr(0) = String.Format("GreatGrandChildName{0}", i)
            dr(2) = r.Next(numberGrandChildRows).ToString() '(i % numberGrandChildRows).ToString();
            dt.Rows.Add(dr)
            i += 1
        End While

        Return dt
    End Function 'GetGreatGrandChildTable


    Private Function GetGreatGreatGrandChildTable() As DataTable
        Dim dt As New DataTable("GreatGreatGrandChildTable")

        dt.Columns.Add(New DataColumn("GreatGreatGrandChildName"))
        dt.Columns.Add(New DataColumn("greatGreatGrandChildID"))
        dt.Columns.Add(New DataColumn("GreatGrandChildID")) 'upper case C
        Dim i As Integer = 0

        While i < numberGreatGreatGrandChildRows
            Dim dr As DataRow = dt.NewRow()
            dr(1) = i.ToString()
            dr(0) = String.Format("GreatGreatGrandChildName{0}", i)
            dr(2) = r.Next(numberGreatGrandChildRows).ToString() '(i % numberGreatGrandChildRows).ToString();
            dt.Rows.Add(dr)
            i += 1
        End While

        Return dt
    End Function 'GetGreatGreatGrandChildTable
#End Region


    Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox1.CheckedChanged
        'hide row headers
        Me.gridDataBoundGrid1.Model.Properties.RowHeaders = Not checkBox1.Checked
    End Sub 'checkBox1_CheckedChanged


    Private Sub checkBox2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox2.CheckedChanged
        If level0 Is Nothing Then
            Return
        End If

        'no color
        If Me.checkBox2.Checked Then
            level0.RowStyle.BackColor = SystemColors.Window
            level1.RowStyle.BackColor = SystemColors.Window
            level2.RowStyle.BackColor = SystemColors.Window
            level3.RowStyle.BackColor = SystemColors.Window
            level4.RowStyle.BackColor = SystemColors.Window
            gridDataBoundGrid1.TableStyle.TextColor = Color.Black
        Else
            level0.RowStyle.BackColor = Color.FromArgb(132, 161, 195)
            level1.RowStyle.BackColor = Color.FromArgb(196, 214, 233)
            level2.RowStyle.BackColor = Color.FromArgb(204, 212, 230)
            level3.RowStyle.BackColor = Color.FromArgb(218, 229, 245)
            level4.RowStyle.BackColor = Color.FromArgb(237, 240, 246)
            gridDataBoundGrid1.TableStyle.TextColor = Color.FromArgb(238, 122, 3)
        End If

        Me.gridDataBoundGrid1.Refresh()
    End Sub 'checkBox2_CheckedChanged


    Private Sub checkBox3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBox3.CheckedChanged
        'no gridlines
        If Me.checkBox3.Checked Then
            Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.None
        Else
            Me.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid
            Me.gridDataBoundGrid1.Model.Properties.GridLineColor = System.Drawing.Color.Silver
        End If
        Me.gridDataBoundGrid1.Refresh()
    End Sub 'checkBox3_CheckedChanged

    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
        If Me.gridDataBoundGrid1.ShowTreeLines Then
            Me.gridDataBoundGrid1.Model.ColWidths.ResizeToFit(GridRangeInfo.Col(2))
        End If
    End Sub 'button1_Click


    Private Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.gridDataBoundGrid1.BeginUpdate()
        Me.gridDataBoundGrid1.ExpandAll()
        Me.gridDataBoundGrid1.EndUpdate()
        Me.gridDataBoundGrid1.Refresh()
    End Sub 'button2_Click


    Private Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
        Me.gridDataBoundGrid1.BeginUpdate()
        Me.gridDataBoundGrid1.CollapseAll()
        Me.gridDataBoundGrid1.EndUpdate()
        Me.gridDataBoundGrid1.Refresh()
    End Sub 'button3_Click
End Class 'Form1