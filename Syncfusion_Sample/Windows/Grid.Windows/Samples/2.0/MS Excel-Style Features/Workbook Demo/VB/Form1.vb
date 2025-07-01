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
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
'/ <summary>
'/ Summary description for Form1.
'/ </summary>

Public Class Form1
    Inherits MetroForm
    Private tabBarSplitterControl1 As Syncfusion.Windows.Forms.TabBarSplitterControl
    Private tabBarPage1 As Syncfusion.Windows.Forms.TabBarPage
    Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
    Private tabBarPage2 As Syncfusion.Windows.Forms.TabBarPage
    Private gridControl2 As Syncfusion.Windows.Forms.Grid.GridControl
    Private tabBarPage3 As Syncfusion.Windows.Forms.TabBarPage
    Private gridControl3 As Syncfusion.Windows.Forms.Grid.GridControl
    Private panel1 As System.Windows.Forms.Panel
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
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			
        Me.gridControl1.DefaultRowHeight = 18
        Me.gridControl1.DefaultColWidth = 70
        Me.gridControl1.GridVisualStyles = GridVisualStyles.Metro
       
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


    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Dim GridCellInfo1 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
        Dim GridCellInfo2 As Syncfusion.Windows.Forms.Grid.GridCellInfo = New Syncfusion.Windows.Forms.Grid.GridCellInfo
        Me.tabBarSplitterControl1 = New Syncfusion.Windows.Forms.TabBarSplitterControl
        Me.tabBarPage1 = New Syncfusion.Windows.Forms.TabBarPage
        Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
        Me.tabBarPage2 = New Syncfusion.Windows.Forms.TabBarPage
        Me.gridControl2 = New Syncfusion.Windows.Forms.Grid.GridControl
        Me.tabBarPage3 = New Syncfusion.Windows.Forms.TabBarPage
        Me.gridControl3 = New Syncfusion.Windows.Forms.Grid.GridControl
        Me.panel1 = New System.Windows.Forms.Panel
        Me.tabBarSplitterControl1.SuspendLayout()
        Me.tabBarPage1.SuspendLayout()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBarPage2.SuspendLayout()
        CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabBarPage3.SuspendLayout()
        CType(Me.gridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabBarSplitterControl1
        '
        Me.tabBarSplitterControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabBarSplitterControl1.Controls.Add(Me.tabBarPage1)
        Me.tabBarSplitterControl1.Controls.Add(Me.tabBarPage2)
        Me.tabBarSplitterControl1.Controls.Add(Me.tabBarPage3)
        Me.tabBarSplitterControl1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.tabBarSplitterControl1.EnabledColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.tabBarSplitterControl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(19, Byte), Integer))
        Me.tabBarSplitterControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.tabBarSplitterControl1.Location = New System.Drawing.Point(12, 12)
        Me.tabBarSplitterControl1.Name = "tabBarSplitterControl1"
        Me.tabBarSplitterControl1.Office2007ScrollBars = True
        Me.tabBarSplitterControl1.RelativeWidth = 45
        Me.tabBarSplitterControl1.RepeatClickDelay = 80
        Me.tabBarSplitterControl1.Size = New System.Drawing.Size(758, 358)
        Me.tabBarSplitterControl1.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
        Me.tabBarSplitterControl1.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Metro
        Me.tabBarSplitterControl1.TabFolderDelta = 11
        Me.tabBarSplitterControl1.TabIndex = 0
        Me.tabBarSplitterControl1.Text = "tabBarSplitterControl1"
        Me.tabBarSplitterControl1.ThemesEnabled = True
		Me.tabBarSplitterControl1.BorderStyle=BorderStyle.FixedSingle
        '
        'tabBarPage1
        '
        Me.tabBarPage1.Controls.Add(Me.gridControl1)
        Me.tabBarPage1.Location = New System.Drawing.Point(0, 0)
        Me.tabBarPage1.Name = "tabBarPage1"
        Me.tabBarPage1.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
        Me.tabBarPage1.TabBackColor = System.Drawing.SystemColors.Control
        Me.tabBarPage1.Text = "tabBarPage1"
        Me.tabBarPage1.ThemesEnabled = True
        '
        'gridControl1
        '
        Me.gridControl1.DefaultColWidth = 70
        Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
        Me.gridControl1.DefaultRowHeight = 18
        Me.gridControl1.FillSplitterPane = True
        Me.gridControl1.HorizontalThumbTrack = True
        Me.gridControl1.Location = New System.Drawing.Point(0, 0)
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.RowCount = 20
        Me.gridControl1.Size = New System.Drawing.Size(741, 341)
        Me.gridControl1.SmartSizeBox = False
        Me.gridControl1.Text = "gridControl1"
        Me.gridControl1.ThemesEnabled = True
		Me.gridControl1.BorderStyle=BorderStyle.FixedSingle
        Me.gridControl1.VerticalThumbTrack = True
        '
        'tabBarPage2
        '
        Me.tabBarPage2.Controls.Add(Me.gridControl2)
        Me.tabBarPage2.HSplitPos = 80
        Me.tabBarPage2.Location = New System.Drawing.Point(0, 0)
        Me.tabBarPage2.Name = "tabBarPage2"
        Me.tabBarPage2.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
        Me.tabBarPage2.TabBackColor = System.Drawing.SystemColors.Control
        Me.tabBarPage2.Text = "tabBarPage2"
        Me.tabBarPage2.ThemesEnabled = True
        '
        'gridControl2
        '
        Me.gridControl2.ColCount = 40
        Me.gridControl2.DefaultColWidth = 70
        Me.gridControl2.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
        Me.gridControl2.DefaultRowHeight = 20
        Me.gridControl2.FillSplitterPane = True
        Me.gridControl2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        GridCellInfo1.Col = -1
        GridCellInfo1.Row = -1
        GridCellInfo1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        GridCellInfo1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        GridCellInfo1.StyleInfo.Font.Facename = "Segoe UI"
        GridCellInfo1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
        GridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gridControl2.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo1})
        Me.gridControl2.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.gridControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridControl2.HorizontalThumbTrack = True
        Me.gridControl2.Location = New System.Drawing.Point(0, 0)
        Me.gridControl2.MetroScrollBars = True
        Me.gridControl2.Name = "gridControl2"
        Me.gridControl2.RowCount = 1000
        Me.gridControl2.Size = New System.Drawing.Size(156, 98)
        Me.gridControl2.SmartSizeBox = False
        Me.gridControl2.Text = "gridControl2"
        Me.gridControl2.ThemesEnabled = True
        Me.gridControl2.VerticalThumbTrack = True
		Me.gridControl2.BorderStyle=BorderStyle.FixedSingle
        '
        'tabBarPage3
        '
        Me.tabBarPage3.Controls.Add(Me.gridControl3)
        Me.tabBarPage3.Location = New System.Drawing.Point(0, 0)
        Me.tabBarPage3.Name = "tabBarPage3"
        Me.tabBarPage3.SplitBars = CType((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows Or Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns), Syncfusion.Windows.Forms.DynamicSplitBars)
        Me.tabBarPage3.TabBackColor = System.Drawing.SystemColors.Control
        Me.tabBarPage3.Text = "tabBarPage3"
        Me.tabBarPage3.ThemesEnabled = True
        Me.tabBarPage3.VSplitPos = 50
        '
        'gridControl3
        '
        Me.gridControl3.ColCount = 16
        Me.gridControl3.DefaultColWidth = 70
        Me.gridControl3.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
        Me.gridControl3.DefaultRowHeight = 20
        Me.gridControl3.FillSplitterPane = True
        Me.gridControl3.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        GridCellInfo2.Col = -1
        GridCellInfo2.Row = -1
        GridCellInfo2.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        GridCellInfo2.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
        GridCellInfo2.StyleInfo.Font.Facename = "Segoe UI"
        GridCellInfo2.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
        GridCellInfo2.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.gridControl3.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() {GridCellInfo2})
        Me.gridControl3.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
        Me.gridControl3.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
        Me.gridControl3.HorizontalThumbTrack = True
        Me.gridControl3.Location = New System.Drawing.Point(0, 0)
        Me.gridControl3.MetroScrollBars = True
        Me.gridControl3.Name = "gridControl3"
        Me.gridControl3.RowCount = 20
        Me.gridControl3.Size = New System.Drawing.Size(156, 98)
        Me.gridControl3.SmartSizeBox = False
        Me.gridControl3.Text = "gridControl3"
        Me.gridControl3.ThemesEnabled = True
        Me.gridControl3.VerticalThumbTrack = True
		Me.gridControl3.BorderStyle=BorderStyle.FixedSingle
        '
        'panel1
        '
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(782, 382)
        Me.panel1.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.Color.White
        Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.BorderThickness = 2
		Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(782, 382)
        Me.Controls.Add(Me.tabBarSplitterControl1)
        Me.Controls.Add(Me.panel1)
        Me.DropShadow = True
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Workbook Demo"
        Me.tabBarSplitterControl1.ResumeLayout(False)
        Me.tabBarPage1.ResumeLayout(False)
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBarPage2.ResumeLayout(False)
        CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabBarPage3.ResumeLayout(False)
        CType(Me.gridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region

    '
    '/ <summary>
    '/ The main entry point for the application.
    '/ </summary>
    <STAThread()> _
    Public Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
        Application.Run(New Form1())
    End Sub 'Main
End Class 'Form1