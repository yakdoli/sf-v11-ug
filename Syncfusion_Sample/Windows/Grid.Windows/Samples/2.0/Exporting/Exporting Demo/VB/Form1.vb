Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
'
'  Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
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
Imports System.IO
Imports System.Drawing.Imaging

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS
Imports System.Collections.Generic
Imports Syncfusion.Windows.Forms
Imports System.Collections.Specialized
Imports System.Diagnostics
Imports Syncfusion.Drawing
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Pdf
Imports Syncfusion.Diagnostics
Imports Syncfusion.XlsIO
Imports Syncfusion.GridExcelConverter
Imports Syncfusion.GridHelperClasses
Imports System.Text


Namespace ExportingDemo
	Public Class Form1
		Inherits MetroForm

		Private WithEvents gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private panel1 As System.Windows.Forms.Panel
		Private groupBox11 As GroupBox
		Private WithEvents buttonAdv7 As ButtonAdv
		Public domainUpDown1 As DomainUpDown
		Private comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private groupBox1 As GroupBox
		Private WithEvents buttonAdv1 As ButtonAdv
		Private xpTaskBar1 As Syncfusion.Windows.Forms.Tools.XPTaskBar
		Private WithEvents xpTaskBarBox1 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private xpTaskBarBox2 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private xpTaskBarBox4 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private gradientPanel4 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private WithEvents xpTaskBarBox3 As Syncfusion.Windows.Forms.Tools.XPTaskBarBox
		Private gradientPanel3 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private gradientPanel5 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private groupBox9 As GroupBox
		Private comboBox1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
		Private WithEvents buttonAdv5 As ButtonAdv
		Private WithEvents buttonAdv4 As ButtonAdv
		Private WithEvents buttonAdv6 As ButtonAdv
		Private gradientPanel1 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private groupBox2 As GroupBox
		Private WithEvents buttonAdv8 As ButtonAdv
		Private WithEvents buttonAdv3 As ButtonAdv
		Private WithEvents buttonAdv2 As ButtonAdv
		Private components As IContainer

		#Region "Form1()"
		Public Sub New()
			InitializeComponent()
			Try
				Dim ico As New Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

			Dim model As GridModel = gridControl1.Model
			model.Options.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation
			Dim boldFont As New GridFontInfo()
			boldFont.Bold = True
			boldFont.Size = 10
			boldFont.Underline = True
			gridControl1.Rows.DefaultSize += 2
			Dim boldfontRowHeight As Integer = gridControl1.Rows.DefaultSize + 6

			'String collections...
			Dim ar As New StringCollection()
			ar.Add("Range Export")
			ar.Add("Selected Export")
			ar.Add("Entire Export")
			comboBox1.DataSource = ar

			Dim ar1 As New StringCollection()
			ar1.Add("SelectedRange")
			ar1.Add("Merged")
			ar1.Add("Entire")
			comboBoxAdv1.DataSource = ar1


			For i As Integer = 0 To 90
				Me.domainUpDown1.Items.Add(i)
				If i <= Me.gridControl1.RowCount Then
					Me.domainUpDown1.Items.Add(i)
				End If
			Next i
			domainUpDown1.SelectedIndex = 10
			model.Options.ControllerOptions = GridControllerOptions.All
			model.Options.DataObjectConsumerOptions = GridDataObjectConsumerOptions.All
			Dim standard As GridStyleInfo = model.BaseStylesMap("Standard").StyleInfo
			Dim header As GridStyleInfo = model.BaseStylesMap("Header").StyleInfo
			Dim rowHeader As GridStyleInfo = model.BaseStylesMap("Row Header").StyleInfo
			Dim colHeader As GridStyleInfo = model.BaseStylesMap("Column Header").StyleInfo
			header.Interior = New BrushInfo(SystemColors.Control)
			rowHeader.Interior = New BrushInfo(SystemColors.Control)
			standard.Font.Facename = "Helvetica"
			standard.VerticalAlignment = GridVerticalAlignment.Middle
			Me.gridControl1.RowCount = 50
			Me.xpTaskBarBox1.Collapsed = True
			Me.xpTaskBarBox2.Collapsed = True
			Me.xpTaskBarBox3.Collapsed = True
			Me.xpTaskBarBox4.Collapsed = True
			AddHandler xpTaskBarBox4.AfterAnimation, AddressOf xpTaskBarBox4_AfterAnimation
			AddHandler xpTaskBarBox3.AfterAnimation, AddressOf xpTaskBarBox3_AfterAnimation
			AddHandler xpTaskBarBox2.AfterAnimation, AddressOf xpTaskBarBox2_AfterAnimation
			AddHandler xpTaskBarBox1.AfterAnimation, AddressOf xpTaskBarBox1_AfterAnimation
		End Sub

		Private Sub xpTaskBarBox1_AfterAnimation(ByVal sender As Object, ByVal e As EventArgs)
			Me.gridControl1.Model.ClearCells(GridRangeInfo.Table(), True)
			Me.gridControl1.ResetColWidthEntries()
			Me.gridControl1.ResetRowHeightEntries()
			Me.xpTaskBarBox2.Collapsed = True
			Me.xpTaskBarBox3.Collapsed = True
			Me.xpTaskBarBox4.Collapsed = True
			If xpTaskBarBox1.Collapsed = False Then
				Me.PopulateTheGridPdf()
			End If
		End Sub

		Private Sub xpTaskBarBox2_AfterAnimation(ByVal sender As Object, ByVal e As EventArgs)
			Me.gridControl1.Model.ClearCells(GridRangeInfo.Table(), True)
			Me.gridControl1.ResetColWidthEntries()
			Me.gridControl1.ResetRowHeightEntries()
			Me.xpTaskBarBox1.Collapsed = True
			Me.xpTaskBarBox3.Collapsed = True
			Me.xpTaskBarBox4.Collapsed = True
			If xpTaskBarBox2.Collapsed = False Then
				Me.PopulateTheGridHtml()
			End If
		End Sub

		Private Sub xpTaskBarBox3_AfterAnimation(ByVal sender As Object, ByVal e As EventArgs)
			Me.gridControl1.Model.ClearCells(GridRangeInfo.Table(), True)
			Me.gridControl1.ResetColWidthEntries()
			Me.gridControl1.ResetRowHeightEntries()
			Me.xpTaskBarBox1.Collapsed = True
			Me.xpTaskBarBox2.Collapsed = True
			Me.xpTaskBarBox4.Collapsed = True
			If xpTaskBarBox3.Collapsed = False Then
				Me.PopulateTheGridExcel()
			End If
		End Sub
		Private Sub xpTaskBarBox4_AfterAnimation(ByVal sender As Object, ByVal e As EventArgs)
			Me.gridControl1.Model.ClearCells(GridRangeInfo.Table(), True)
			Me.gridControl1.ResetColWidthEntries()
			Me.gridControl1.ResetRowHeightEntries()
			Me.xpTaskBarBox1.Collapsed = True
			Me.xpTaskBarBox2.Collapsed = True
			Me.xpTaskBarBox3.Collapsed = True
			If xpTaskBarBox4.Collapsed = False Then
				Me.populateTheGridWord()
			End If
		End Sub
		#End Region

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			Dim ToolTip1 As New System.Windows.Forms.ToolTip()
			ToolTip1.SetToolTip(Me.buttonAdv8, "click Select table and copy to clipboard")
			Me.PopulateTheGridExcel()
			Me.xpTaskBarBox3.Collapsed = False
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

		#Region "Dispose"
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
		#End Region

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim gridBaseStyle1 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle2 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle3 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle4 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridCellInfo1 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.xpTaskBar1 = New Syncfusion.Windows.Forms.Tools.XPTaskBar()
			Me.xpTaskBarBox3 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.gradientPanel3 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.groupBox9 = New System.Windows.Forms.GroupBox()
			Me.comboBox1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.buttonAdv5 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv4 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv6 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.xpTaskBarBox1 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.gradientPanel5 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.groupBox11 = New System.Windows.Forms.GroupBox()
			Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
			Me.domainUpDown1 = New System.Windows.Forms.DomainUpDown()
			Me.buttonAdv7 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.xpTaskBarBox2 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.gradientPanel1 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.buttonAdv8 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv3 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv()
			Me.xpTaskBarBox4 = New Syncfusion.Windows.Forms.Tools.XPTaskBarBox()
			Me.gradientPanel4 = New Syncfusion.Windows.Forms.Tools.GradientPanel()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBar1.SuspendLayout()
			Me.xpTaskBarBox3.SuspendLayout()
			CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel3.SuspendLayout()
			Me.groupBox9.SuspendLayout()
			CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBarBox1.SuspendLayout()
			CType(Me.gradientPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel5.SuspendLayout()
			Me.groupBox11.SuspendLayout()
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.xpTaskBarBox2.SuspendLayout()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel1.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.xpTaskBarBox4.SuspendLayout()
			CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.gradientPanel4.SuspendLayout()
			Me.groupBox1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			gridBaseStyle1.Name = "Header"
			gridBaseStyle1.StyleInfo.CellType = "Header"
			gridBaseStyle1.StyleInfo.Font.Bold = True
			gridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(184)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(216)))))))
			gridBaseStyle1.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
			gridBaseStyle2.Name = "Standard"
			gridBaseStyle2.StyleInfo.Font.Facename = "Tahoma"
			gridBaseStyle2.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
			gridBaseStyle3.Name = "Column Header"
			gridBaseStyle3.StyleInfo.BaseStyle = "Header"
			gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridBaseStyle4.Name = "Row Header"
			gridBaseStyle4.StyleInfo.BaseStyle = "Header"
			gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
			gridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(184)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(216)))))))
			Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() { gridBaseStyle1, gridBaseStyle2, gridBaseStyle3, gridBaseStyle4})
			Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gridControl1.ColCount = 9
			Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() { New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35), New Syncfusion.Windows.Forms.Grid.GridColWidth(3, 179), New Syncfusion.Windows.Forms.Grid.GridColWidth(4, 196)})
			Me.gridControl1.DefaultColWidth = 70
			Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
			Me.gridControl1.DefaultRowHeight = 20
			Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.5F)
			Me.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue
			gridCellInfo1.Col = -1
			gridCellInfo1.Row = -1
			gridCellInfo1.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo1.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridCellInfo1.StyleInfo.Font.Bold = False
			gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI"
			gridCellInfo1.StyleInfo.Font.Italic = False
			gridCellInfo1.StyleInfo.Font.Size = 8.5F
			gridCellInfo1.StyleInfo.Font.Strikeout = False
			gridCellInfo1.StyleInfo.Font.Underline = False
			gridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridCellInfo1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridControl1.GridCells.AddRange(New Syncfusion.Windows.Forms.Grid.GridCellInfo() { gridCellInfo1})
			Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
			Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridControl1.HorizontalThumbTrack = True
			Me.gridControl1.Location = New System.Drawing.Point(11, 7)
			Me.gridControl1.MetroScrollBars = True
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255))))))
			Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(215))))), (CInt(Fix((CByte(229))))))
			Me.gridControl1.Properties.MarkColHeader = False
			Me.gridControl1.Properties.MarkRowHeader = False
			Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.gridControl1.RowCount = 30
			Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() { New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
			Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
			Me.gridControl1.Size = New System.Drawing.Size(657, 442)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 3
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.VerticalThumbTrack = True
'			Me.gridControl1.SaveCellText += New Syncfusion.Windows.Forms.Grid.GridCellTextEventHandler(Me.gridControl1_SaveCellText)
'			Me.gridControl1.SaveCellFormattedText += New Syncfusion.Windows.Forms.Grid.GridCellTextEventHandler(Me.gridControl1_SaveCellFormattedText)
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.White
			Me.panel1.Controls.Add(Me.xpTaskBar1)
			Me.panel1.Controls.Add(Me.gridControl1)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(1001, 468)
			Me.panel1.TabIndex = 4
			' 
			' xpTaskBar1
			' 
			Me.xpTaskBar1.AutoSize = True
			Me.xpTaskBar1.BackColor = System.Drawing.Color.White
			Me.xpTaskBar1.BorderColor = System.Drawing.Color.Black
			Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox3)
			Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox1)
			Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox2)
			Me.xpTaskBar1.Controls.Add(Me.xpTaskBarBox4)
			Me.xpTaskBar1.Location = New System.Drawing.Point(685, 7)
			Me.xpTaskBar1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.xpTaskBar1.MinimumSize = New System.Drawing.Size(0, 0)
			Me.xpTaskBar1.Name = "xpTaskBar1"
			Me.xpTaskBar1.Size = New System.Drawing.Size(310, 442)
			Me.xpTaskBar1.TabIndex = 20
			' 
			' xpTaskBarBox3
			' 
			Me.xpTaskBarBox3.BackColor = System.Drawing.Color.White
			Me.xpTaskBarBox3.Controls.Add(Me.gradientPanel3)
			Me.xpTaskBarBox3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xpTaskBarBox3.ForeColor = System.Drawing.Color.White
			Me.xpTaskBarBox3.HeaderBackColor = System.Drawing.Color.DarkGray
			Me.xpTaskBarBox3.HeaderForeColor = System.Drawing.Color.White
			Me.xpTaskBarBox3.HeaderImageIndex = -1
			Me.xpTaskBarBox3.HitTaskBoxArea = False
			Me.xpTaskBarBox3.HotTrackColor = System.Drawing.Color.White
			Me.xpTaskBarBox3.ItemBackColor = System.Drawing.Color.White
			Me.xpTaskBarBox3.Location = New System.Drawing.Point(0, 0)
			Me.xpTaskBarBox3.Name = "xpTaskBarBox3"
			Me.xpTaskBarBox3.PreferredChildPanelHeight = 179
			Me.xpTaskBarBox3.Size = New System.Drawing.Size(310, 210)
			Me.xpTaskBarBox3.TabIndex = 2
			Me.xpTaskBarBox3.Text = "EXCEL"
'			Me.xpTaskBarBox3.ItemClick += New Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickHandler(Me.xpTaskBarBox3_ItemClick)
			' 
			' gradientPanel3
			' 
			Me.gradientPanel3.AutoSize = True
			Me.gradientPanel3.BackColor = System.Drawing.Color.White
			Me.gradientPanel3.BorderColor = System.Drawing.Color.White
			Me.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gradientPanel3.Controls.Add(Me.groupBox9)
			Me.gradientPanel3.Location = New System.Drawing.Point(2, 29)
			Me.gradientPanel3.Name = "gradientPanel3"
			Me.gradientPanel3.Size = New System.Drawing.Size(306, 179)
			Me.gradientPanel3.TabIndex = 0
			' 
			' groupBox9
			' 
			Me.groupBox9.BackColor = System.Drawing.Color.White
			Me.groupBox9.Controls.Add(Me.comboBox1)
			Me.groupBox9.Controls.Add(Me.buttonAdv5)
			Me.groupBox9.Controls.Add(Me.buttonAdv4)
			Me.groupBox9.Controls.Add(Me.buttonAdv6)
			Me.groupBox9.Location = New System.Drawing.Point(0, -2)
			Me.groupBox9.Name = "groupBox9"
			Me.groupBox9.Size = New System.Drawing.Size(300, 176)
			Me.groupBox9.TabIndex = 16
			Me.groupBox9.TabStop = False
			' 
			' comboBox1
			' 
			Me.comboBox1.BackColor = System.Drawing.Color.White
			Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.comboBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBox1.Location = New System.Drawing.Point(88, 29)
			Me.comboBox1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.comboBox1.Name = "comboBox1"
			Me.comboBox1.Size = New System.Drawing.Size(121, 21)
			Me.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
			Me.comboBox1.TabIndex = 18
			' 
			' buttonAdv5
			' 
			Me.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv5.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.buttonAdv5.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv5.ForeColor = System.Drawing.Color.White
			Me.buttonAdv5.Location = New System.Drawing.Point(89, 128)
			Me.buttonAdv5.Name = "buttonAdv5"
			Me.buttonAdv5.Size = New System.Drawing.Size(120, 30)
			Me.buttonAdv5.TabIndex = 8
			Me.buttonAdv5.Text = "Clear Grid"
			Me.buttonAdv5.UseVisualStyle = True
'			Me.buttonAdv5.Click += New System.EventHandler(Me.buttonAdv5_Click)
			' 
			' buttonAdv4
			' 
			Me.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv4.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.buttonAdv4.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv4.ForeColor = System.Drawing.Color.White
			Me.buttonAdv4.Location = New System.Drawing.Point(169, 71)
			Me.buttonAdv4.Name = "buttonAdv4"
			Me.buttonAdv4.Size = New System.Drawing.Size(120, 32)
			Me.buttonAdv4.TabIndex = 7
			Me.buttonAdv4.Text = "Export"
			Me.buttonAdv4.UseVisualStyle = True
'			Me.buttonAdv4.Click += New System.EventHandler(Me.buttonAdv4_Click)
			' 
			' buttonAdv6
			' 
			Me.buttonAdv6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv6.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.buttonAdv6.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv6.ForeColor = System.Drawing.Color.White
			Me.buttonAdv6.Location = New System.Drawing.Point(12, 71)
			Me.buttonAdv6.Name = "buttonAdv6"
			Me.buttonAdv6.Size = New System.Drawing.Size(119, 32)
			Me.buttonAdv6.TabIndex = 9
			Me.buttonAdv6.Text = "Import"
			Me.buttonAdv6.UseVisualStyle = True
'			Me.buttonAdv6.Click += New System.EventHandler(Me.buttonAdv6_Click)
			' 
			' xpTaskBarBox1
			' 
			Me.xpTaskBarBox1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.xpTaskBarBox1.BackColor = System.Drawing.Color.White
			Me.xpTaskBarBox1.Controls.Add(Me.gradientPanel5)
			Me.xpTaskBarBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xpTaskBarBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
			Me.xpTaskBarBox1.HeaderBackColor = System.Drawing.Color.DarkGray
			Me.xpTaskBarBox1.HeaderForeColor = System.Drawing.Color.White
			Me.xpTaskBarBox1.HeaderImageIndex = -1
			Me.xpTaskBarBox1.HitTaskBoxArea = False
			Me.xpTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty
			Me.xpTaskBarBox1.ItemBackColor = System.Drawing.Color.White
			Me.xpTaskBarBox1.Location = New System.Drawing.Point(0, 210)
			Me.xpTaskBarBox1.Name = "xpTaskBarBox1"
			Me.xpTaskBarBox1.PreferredChildPanelHeight = 154
			Me.xpTaskBarBox1.Size = New System.Drawing.Size(310, 185)
			Me.xpTaskBarBox1.TabIndex = 0
			Me.xpTaskBarBox1.Text = "PDF"
'			Me.xpTaskBarBox1.ItemClick += New Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickHandler(Me.xpTaskBarBox1_ItemClick)
			' 
			' gradientPanel5
			' 
			Me.gradientPanel5.AutoSize = True
			Me.gradientPanel5.BackColor = System.Drawing.Color.White
			Me.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanel5.Controls.Add(Me.groupBox11)
			Me.gradientPanel5.Location = New System.Drawing.Point(2, 29)
			Me.gradientPanel5.Name = "gradientPanel5"
			Me.gradientPanel5.Size = New System.Drawing.Size(306, 154)
			Me.gradientPanel5.TabIndex = 21
			' 
			' groupBox11
			' 
			Me.groupBox11.BackColor = System.Drawing.Color.White
			Me.groupBox11.Controls.Add(Me.comboBoxAdv1)
			Me.groupBox11.Controls.Add(Me.domainUpDown1)
			Me.groupBox11.Controls.Add(Me.buttonAdv7)
			Me.groupBox11.ForeColor = System.Drawing.Color.White
			Me.groupBox11.Location = New System.Drawing.Point(1, -2)
			Me.groupBox11.Name = "groupBox11"
			Me.groupBox11.Size = New System.Drawing.Size(300, 149)
			Me.groupBox11.TabIndex = 17
			Me.groupBox11.TabStop = False
			' 
			' comboBoxAdv1
			' 
			Me.comboBoxAdv1.BackColor = System.Drawing.Color.White
			Me.comboBoxAdv1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
			Me.comboBoxAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.comboBoxAdv1.Location = New System.Drawing.Point(12, 29)
			Me.comboBoxAdv1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(17))))), (CInt(Fix((CByte(158))))), (CInt(Fix((CByte(218))))))
			Me.comboBoxAdv1.Name = "comboBoxAdv1"
			Me.comboBoxAdv1.Size = New System.Drawing.Size(119, 21)
			Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
			Me.comboBoxAdv1.TabIndex = 18
			' 
			' domainUpDown1
			' 
			Me.domainUpDown1.Location = New System.Drawing.Point(158, 29)
			Me.domainUpDown1.Name = "domainUpDown1"
			Me.domainUpDown1.Size = New System.Drawing.Size(107, 22)
			Me.domainUpDown1.TabIndex = 22
			' 
			' buttonAdv7
			' 
			Me.buttonAdv7.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv7.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.buttonAdv7.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv7.ForeColor = System.Drawing.Color.White
			Me.buttonAdv7.Location = New System.Drawing.Point(89, 81)
			Me.buttonAdv7.Name = "buttonAdv7"
			Me.buttonAdv7.Size = New System.Drawing.Size(120, 28)
			Me.buttonAdv7.TabIndex = 20
			Me.buttonAdv7.Text = "Export"
			Me.buttonAdv7.UseVisualStyle = True
'			Me.buttonAdv7.Click += New System.EventHandler(Me.buttonAdv7_Click)
			' 
			' xpTaskBarBox2
			' 
			Me.xpTaskBarBox2.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.xpTaskBarBox2.BackColor = System.Drawing.SystemColors.Window
			Me.xpTaskBarBox2.Controls.Add(Me.gradientPanel1)
			Me.xpTaskBarBox2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xpTaskBarBox2.HeaderBackColor = System.Drawing.Color.DarkGray
			Me.xpTaskBarBox2.HeaderForeColor = System.Drawing.Color.White
			Me.xpTaskBarBox2.HeaderImageIndex = -1
			Me.xpTaskBarBox2.HitTaskBoxArea = False
			Me.xpTaskBarBox2.HotTrackColor = System.Drawing.Color.White
			Me.xpTaskBarBox2.ItemBackColor = System.Drawing.Color.White
			Me.xpTaskBarBox2.Location = New System.Drawing.Point(0, 395)
			Me.xpTaskBarBox2.Name = "xpTaskBarBox2"
			Me.xpTaskBarBox2.PreferredChildPanelHeight = 176
			Me.xpTaskBarBox2.Size = New System.Drawing.Size(310, 207)
			Me.xpTaskBarBox2.TabIndex = 1
			Me.xpTaskBarBox2.Text = "HTML"
			' 
			' gradientPanel1
			' 
			Me.gradientPanel1.AutoSize = True
			Me.gradientPanel1.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None
			Me.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanel1.Controls.Add(Me.groupBox2)
			Me.gradientPanel1.Location = New System.Drawing.Point(2, 29)
			Me.gradientPanel1.Name = "gradientPanel1"
			Me.gradientPanel1.Size = New System.Drawing.Size(306, 176)
			Me.gradientPanel1.TabIndex = 21
			' 
			' groupBox2
			' 
			Me.groupBox2.BackColor = System.Drawing.Color.White
			Me.groupBox2.Controls.Add(Me.buttonAdv8)
			Me.groupBox2.Controls.Add(Me.buttonAdv3)
			Me.groupBox2.Controls.Add(Me.buttonAdv2)
			Me.groupBox2.Location = New System.Drawing.Point(4, 3)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(302, 166)
			Me.groupBox2.TabIndex = 19
			Me.groupBox2.TabStop = False
			' 
			' buttonAdv8
			' 
			Me.buttonAdv8.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv8.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.buttonAdv8.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv8.ForeColor = System.Drawing.Color.White
			Me.buttonAdv8.Location = New System.Drawing.Point(12, 34)
			Me.buttonAdv8.Name = "buttonAdv8"
			Me.buttonAdv8.Size = New System.Drawing.Size(134, 30)
			Me.buttonAdv8.TabIndex = 2
			Me.buttonAdv8.Text = "Copy To Clipboard"
			Me.buttonAdv8.UseVisualStyle = True
'			Me.buttonAdv8.Click += New System.EventHandler(Me.buttonAdv8_Click)
			' 
			' buttonAdv3
			' 
			Me.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv3.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.buttonAdv3.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv3.ForeColor = System.Drawing.Color.White
			Me.buttonAdv3.Location = New System.Drawing.Point(169, 34)
			Me.buttonAdv3.Name = "buttonAdv3"
			Me.buttonAdv3.Size = New System.Drawing.Size(120, 30)
			Me.buttonAdv3.TabIndex = 1
			Me.buttonAdv3.Text = "Select Table"
			Me.buttonAdv3.UseVisualStyle = True
'			Me.buttonAdv3.Click += New System.EventHandler(Me.buttonAdv3_Click)
			' 
			' buttonAdv2
			' 
			Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv2.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.buttonAdv2.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv2.ForeColor = System.Drawing.Color.White
			Me.buttonAdv2.Location = New System.Drawing.Point(97, 96)
			Me.buttonAdv2.Name = "buttonAdv2"
			Me.buttonAdv2.Size = New System.Drawing.Size(112, 29)
			Me.buttonAdv2.TabIndex = 0
			Me.buttonAdv2.Text = "Export"
			Me.buttonAdv2.UseVisualStyle = True
'			Me.buttonAdv2.Click += New System.EventHandler(Me.buttonAdv2_Click)
			' 
			' xpTaskBarBox4
			' 
			Me.xpTaskBarBox4.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.xpTaskBarBox4.BackColor = System.Drawing.Color.White
			Me.xpTaskBarBox4.Controls.Add(Me.gradientPanel4)
			Me.xpTaskBarBox4.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.xpTaskBarBox4.HeaderBackColor = System.Drawing.Color.DarkGray
			Me.xpTaskBarBox4.HeaderForeColor = System.Drawing.Color.White
			Me.xpTaskBarBox4.HeaderImageIndex = -1
			Me.xpTaskBarBox4.HitTaskBoxArea = False
			Me.xpTaskBarBox4.HotTrackColor = System.Drawing.Color.Empty
			Me.xpTaskBarBox4.ItemBackColor = System.Drawing.Color.White
			Me.xpTaskBarBox4.Location = New System.Drawing.Point(0, 602)
			Me.xpTaskBarBox4.Name = "xpTaskBarBox4"
			Me.xpTaskBarBox4.PreferredChildPanelHeight = 109
			Me.xpTaskBarBox4.Size = New System.Drawing.Size(310, 140)
			Me.xpTaskBarBox4.TabIndex = 3
			Me.xpTaskBarBox4.Text = "WORD"
			' 
			' gradientPanel4
			' 
			Me.gradientPanel4.AutoSize = True
			Me.gradientPanel4.BackColor = System.Drawing.Color.White
			Me.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.None
			Me.gradientPanel4.Controls.Add(Me.groupBox1)
			Me.gradientPanel4.Location = New System.Drawing.Point(2, 29)
			Me.gradientPanel4.Name = "gradientPanel4"
			Me.gradientPanel4.Size = New System.Drawing.Size(306, 109)
			Me.gradientPanel4.TabIndex = 0
			' 
			' groupBox1
			' 
			Me.groupBox1.BackColor = System.Drawing.Color.White
			Me.groupBox1.Controls.Add(Me.buttonAdv1)
			Me.groupBox1.Location = New System.Drawing.Point(7, 3)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(297, 96)
			Me.groupBox1.TabIndex = 18
			Me.groupBox1.TabStop = False
			' 
			' buttonAdv1
			' 
			Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
			Me.buttonAdv1.BackColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(163))))), (CInt(Fix((CByte(0))))))
			Me.buttonAdv1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.buttonAdv1.ForeColor = System.Drawing.Color.White
			Me.buttonAdv1.Location = New System.Drawing.Point(85, 48)
			Me.buttonAdv1.Name = "buttonAdv1"
			Me.buttonAdv1.Size = New System.Drawing.Size(121, 32)
			Me.buttonAdv1.TabIndex = 4
			Me.buttonAdv1.Text = "    Word Export"
			Me.buttonAdv1.UseVisualStyle = True
'			Me.buttonAdv1.Click += New System.EventHandler(Me.buttonAdv1_Click)
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.CaptionButtonColor = System.Drawing.Color.Black
			Me.CaptionFont = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(1013, 468)
			Me.Controls.Add(Me.panel1)
			Me.DropShadow = True
			Me.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Exporting Demo"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			CType(Me.xpTaskBar1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBar1.ResumeLayout(False)
			Me.xpTaskBarBox3.ResumeLayout(False)
			Me.xpTaskBarBox3.PerformLayout()
			CType(Me.gradientPanel3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel3.ResumeLayout(False)
			Me.groupBox9.ResumeLayout(False)
			CType(Me.comboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBarBox1.ResumeLayout(False)
			Me.xpTaskBarBox1.PerformLayout()
			CType(Me.gradientPanel5, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel5.ResumeLayout(False)
			Me.groupBox11.ResumeLayout(False)
			CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.xpTaskBarBox2.ResumeLayout(False)
			Me.xpTaskBarBox2.PerformLayout()
			CType(Me.gradientPanel1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel1.ResumeLayout(False)
			Me.groupBox2.ResumeLayout(False)
			Me.xpTaskBarBox4.ResumeLayout(False)
			Me.xpTaskBarBox4.PerformLayout()
			CType(Me.gradientPanel4, System.ComponentModel.ISupportInitialize).EndInit()
			Me.gradientPanel4.ResumeLayout(False)
			Me.groupBox1.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub
		#End Region

		#Region "main"
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Public Shared Sub Main()
			#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
			Application.EnableVisualStyles()
			  #End If
			Application.Run(New Form1())
		End Sub
		#End Region

		#Region "Methods"

		Private Function RandomString(ByVal r As Random) As String
			Dim len As Integer = r.Next(12) + 1
			Dim sb As New System.Text.StringBuilder(len)

			For i As Integer = 0 To len - 1
                sb.Append(CChar(CChar(CStr(r.Next(26) + 65))))
			Next i

			Return sb.ToString()
		End Function
		Private Sub populateTheGridWord()
			Dim rand As New Random()
			For i As Integer = 1 To gridControl1.RowCount
				For j As Integer = 1 To gridControl1.ColCount
					Me.gridControl1(i, j).Text = (10 * (i * j)).ToString()
					Me.gridControl1(0, j).Text = "C" & j.ToString()
					Me.gridControl1(i, 0).Text = "R" & i.ToString()
				Next j
			Next i
		End Sub
		Private Sub PopulateTheGridHtml()
			gridControl1.Model.ColStyles(1).TextColor = Color.MidnightBlue
			gridControl1.Model.ColStyles(1).Font.Size = 30
			gridControl1.Model.ColStyles(3).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1.Model.ColStyles(3).HorizontalAlignment = GridHorizontalAlignment.Right
			gridControl1.Model.ColStyles(3).TextColor = Color.Red
			gridControl1.Model.ColStyles(3).Font.Bold = True
			gridControl1.Model.ColStyles(4).CellType = GridCellTypeName.CheckBox

			gridControl1.Model.ColStyles(5).Borders.All = New GridBorder(GridBorderStyle.Solid)
			gridControl1.Model.ColStyles(5).CellType = GridCellTypeName.RadioButton
			gridControl1.Model.ColStyles(5).ChoiceList = New System.Collections.Specialized.StringCollection()
			gridControl1.Model.ColStyles(5).ChoiceList.AddRange(New String() { "one", "two" })

			gridControl1.Model.ColWidths(1) = 180
			gridControl1.Model.ColWidths(5) = 110
			gridControl1.Model.RowHeights(1) = 80

			gridControl1(1, 1).Text = "Size"
			gridControl1(1, 3).Text = "Align"

			gridControl1.Model.ColStyles(7).CellType = GridCellTypeName.ComboBox
			gridControl1.Model.ColStyles(7).ChoiceList = Me.gridControl1.Model.ColStyles(5).ChoiceList
		End Sub
		Private Sub PopulateTheGridPdf()
			Dim r As New Random()
			Me.gridControl1.CommandStack.Enabled = False
			For row As Integer = 1 To Me.gridControl1.RowCount
				For col As Integer = 1 To Me.gridControl1.ColCount
					If col = 2 Then 'datetime col
						Dim dt As New DateTime(r.Next(50) + 1960, r.Next(11) + 1, r.Next(27) + 1)
						Me.gridControl1(row, col).CellValue = dt
					ElseIf col = 4 OrElse col = 5 Then 'formula col and text col
						If col = 5 Then
							Me.gridControl1(row, col).CellValue = RandomString(r)
						End If
                    ElseIf col = 6 Then 'float
                        If r.Next(2) = 0 Then
                            Me.gridControl1(row, col).CellValue = 1 * (CSng(r.Next(100000))) / 200
                        Else
                            Me.gridControl1(row, col).CellValue = -1 * (CSng(r.Next(100000))) / 200
                        End If
                    ElseIf col = 3 Then 'int count col
                        Me.gridControl1(row, col).CellValue = row
                    Else 'int
                        If r.Next(2) = 0 Then
                            Me.gridControl1(row, col).CellValue = 1 * r.Next(1000)
                        Else
                            Me.gridControl1(row, col).CellValue = -1 * r.Next(1000)
                        End If
                    End If
                Next col
			Next row
			Me.gridControl1.DefaultColWidth = 50

			If gridControl1.ColCount >= 1 Then
				Me.gridControl1.ColStyles(1).BackColor = Color.White
			End If
			'column 2 is a date column
			If gridControl1.ColCount >= 2 Then
				Me.gridControl1.ColStyles(2).CellValueType = GetType(DateTime)
				Me.gridControl1.ColStyles(2).Format = "dd MMM yyyy"
				Me.gridControl1.ColWidths(2) = 100
				Me.gridControl1(0, 2).Text = "Date"
				Me.gridControl1.ColStyles(2).BackColor = Color.FromArgb(237, 240, 246)
				Me.gridControl1.ColStyles(3).BackColor = Color.FromArgb(218, 229, 245)
			End If
			'column 4 is formula col which used relative notation (row = 0)
			'to enter the formulas as a simgle string as the default value
			'in the column
			If gridControl1.ColCount >= 4 Then
				Me.gridControl1.ColWidths(4) = 100
				Me.gridControl1(0, 4).Text = "FormulaCell"
				Me.gridControl1.ColStyles(4).CellType = "FormulaCell"
				Me.gridControl1.ColStyles(4).Text = "= A0 + C0"
				Me.gridControl1.ColStyles(4).BackColor = Color.FromArgb(218, 229, 245) 'row = 0 means use current row
			End If

			'col 6 is a text column
			If gridControl1.ColCount >= 5 Then
				Me.gridControl1.ColWidths(5) = 100
				Me.gridControl1(0, 5).Text = "Text"
				Me.gridControl1.ColStyles(5).BackColor = Color.FromArgb(102, 110, 152)
				Me.gridControl1.ColStyles(5).TextColor = Color.White
			End If

			'column 6 is a float column
			If gridControl1.ColCount >= 6 Then
				Me.gridControl1.ColStyles(6).CellValueType = GetType(Single)
				Me.gridControl1.ColStyles(6).Format = "####.##"
				Me.gridControl1.ColWidths(6) = 100
				Me.gridControl1(0, 6).Text = "floats"
				Me.gridControl1.ColStyles(6).BackColor = Color.FromArgb(252, 172, 38)
			End If
			'force the entire column to be computed, not just the visible cells
			'so if sort is done on formula column, all cells will have been computed.
			Dim engine As GridFormulaEngine = (CType(Me.gridControl1.CellModels("FormulaCell"), GridFormulaCellModel)).Engine
			engine.RecalculateRange(GridRangeInfo.Col(4), True, True)

			If gridControl1.ColCount >= 10 Then
				Me.gridControl1.ColStyles(7).BackColor = Color.FromArgb(255, 153, 51)
				Me.gridControl1.ColStyles(8).BackColor = Color.FromArgb(238, 122, 3)
				Me.gridControl1.ColStyles(9).BackColor = Color.FromArgb(238, 122, 3)
				Me.gridControl1.ColStyles(10).BackColor = Color.FromArgb(&Hde, &H64, &H13)
				Me.gridControl1.ColStyles(10).TextColor = Color.White
			End If

			Me.gridControl1.DefaultRowHeight = 18
			Me.gridControl1.DefaultColWidth = 70
			Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.Silver
			Me.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid

		End Sub
		Private Sub PopulateTheGridExcel()
			Dim boldFont As New GridFontInfo()
			boldFont.Bold = True
			boldFont.Size = 11
			boldFont.Underline = True

			Dim rowIndex As Integer = 2
			Dim colIndex As Integer = 1

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2))
			gridControl1(rowIndex, 1).Text = "TextColor"
			gridControl1(rowIndex, 1).Font = boldFont
			rowIndex += 1

			colIndex = 1
			For Each color As Color In New Color() { Color.Black, Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.DimGray}
				gridControl1(rowIndex, colIndex).TextColor = color
				gridControl1(rowIndex, colIndex).Text = ColorConvert.ColorToString(color, True)
				colIndex += 1
			Next color
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Rows(rowIndex - 1, rowIndex))
			rowIndex += 1

			rowIndex += 1
			colIndex = 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2))
			gridControl1(rowIndex, 1).Text = "BackColor"
			gridControl1(rowIndex, 1).Font = boldFont
			rowIndex += 1

			colIndex = 1
			For Each color As Color In New Color() { SystemColors.ActiveCaptionText, Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Black}
				gridControl1(rowIndex, colIndex).TextColor = Color.White
				gridControl1(rowIndex, colIndex).BackColor = color
				gridControl1(rowIndex, colIndex).Text = ColorConvert.ColorToString(color, True)
				colIndex += 1
			Next color
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Rows(rowIndex - 1, rowIndex))
			rowIndex += 1

			rowIndex += 1
			colIndex = 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2))
			gridControl1(rowIndex, 1).Text = "Font"
			gridControl1(rowIndex, 1).Font = boldFont
			rowIndex += 1

			For Each size As Integer In New Integer(){ 6, 7, 8, 10, 12, 14}
				gridControl1(rowIndex, colIndex).Font.Size = size
				gridControl1(rowIndex, colIndex).Text = size.ToString()
				colIndex += 1
			Next size
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Rows(rowIndex - 1, rowIndex))

			rowIndex += 1
			colIndex = 1
			For Each fontStyle As FontStyle In New FontStyle() { FontStyle.Bold, FontStyle.Italic, FontStyle.Regular, FontStyle.Strikeout, FontStyle.Underline, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Regular}
				gridControl1(rowIndex, colIndex).Font.FontStyle = fontStyle
				gridControl1(rowIndex, colIndex).Text = System.Enum.Format(GetType(FontStyle), fontStyle, "G")
				colIndex += 1
			Next fontStyle

			rowIndex += 1
			colIndex = 1
			For Each facename As String In New String() { "Comic Sans MS", "Arial", "Century", "Courier New", "Times New Roman", "Verdana"}
				gridControl1(rowIndex, colIndex).Font.Facename = facename
				gridControl1(rowIndex, colIndex).Text = facename
				colIndex += 1
			Next facename
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex))
			rowIndex += 1

			rowIndex += 1
			colIndex = 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2))
			gridControl1(rowIndex, 1).Text = "Alignment"
			gridControl1(rowIndex, 1).Font = boldFont
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex))
			rowIndex += 1

			gridControl1(rowIndex, colIndex).HorizontalAlignment = GridHorizontalAlignment.Left
			gridControl1(rowIndex, colIndex).VerticalAlignment = GridVerticalAlignment.Top
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, colIndex + 1))
			gridControl1(rowIndex, colIndex).Text = "Top Left"
			gridControl1.RowHeights(rowIndex) = 30
			colIndex += 2

			gridControl1(rowIndex, colIndex).HorizontalAlignment = GridHorizontalAlignment.Center
			gridControl1(rowIndex, colIndex).VerticalAlignment = GridVerticalAlignment.Middle
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, colIndex + 1))
			gridControl1(rowIndex, colIndex).Text = "Center"
			colIndex += 2

			gridControl1(rowIndex, colIndex).HorizontalAlignment = GridHorizontalAlignment.Right
			gridControl1(rowIndex, colIndex).VerticalAlignment = GridVerticalAlignment.Bottom
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, colIndex, rowIndex, colIndex + 1))
			gridControl1(rowIndex, colIndex).Text = "Bottom Right"
			rowIndex += 1

			rowIndex += 1
			colIndex = 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2))
			gridControl1(rowIndex, 1).Text = "Orientation"
			gridControl1(rowIndex, 1).Font = boldFont
			rowIndex += 1

			For Each orientation As Integer In New Integer() { 0, 30, 45, 60, 90, 270}
				Dim style1 As GridStyleInfo = gridControl1(rowIndex, colIndex)
				style1.HorizontalAlignment = GridHorizontalAlignment.Center
				style1.VerticalAlignment = GridVerticalAlignment.Middle
				Dim font As GridFontInfo = style1.Font
				font.Orientation = orientation
				font.Bold = True
				style1.Text = "Angle = " & font.Orientation.ToString()
				colIndex += 1
			Next orientation
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex))
			rowIndex += 1

			rowIndex += 1
			colIndex = 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2))
			gridControl1(rowIndex, 1).Text = "Formula Cell"
			gridControl1(rowIndex, 1).Font = boldFont
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex))
			rowIndex += 1

			Dim r As New Random()
			Do While colIndex <= 5
				gridControl1(rowIndex, colIndex).CellValue = r.Next(500)
				colIndex += 1
			Loop
			gridControl1(rowIndex, colIndex).CellType = "FormulaCell"
			gridControl1(rowIndex, colIndex).Text = "=SUM(A" & rowIndex & ":" & "E" & rowIndex & ")"

			gridControl1(rowIndex, colIndex).Borders.All = New GridBorder(GridBorderStyle.Solid, Color.Red, GridBorderWeight.ExtraExtraThick)
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex))
			rowIndex += 1

			rowIndex += 1
			colIndex = 1
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2))
			gridControl1(rowIndex, 1).Text = "Currency Cell"
			gridControl1(rowIndex, 1).Font = boldFont
			gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Row(rowIndex))
			rowIndex += 1

			Do While colIndex <= 6
				gridControl1(rowIndex, colIndex).CellType = "Currency"
				gridControl1(rowIndex, colIndex).CurrencyEdit.NegativeColor = Color.Black
				gridControl1(rowIndex, colIndex).CurrencyEdit.CurrencyNegativePattern = 2
				gridControl1(rowIndex, colIndex).CellValue = r.Next(-100, 100)
				colIndex += 1
			Loop
			Me.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229)
			Dim style As GridStyleInfo = gridControl1.BaseStylesMap("Header").StyleInfo
			style.TextColor = Color.MidnightBlue
			style.Font.Facename = "Verdana"
			Me.BackColor = Color.White
			Me.StartPosition = FormStartPosition.CenterScreen
		End Sub


		Private Sub gridControl1_SaveCellText(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridCellTextEventArgs) Handles gridControl1.SaveCellText
			TraceUtil.TraceCurrentMethodInfo(e)
			ParseText(e)
		End Sub

		Private Sub gridControl1_SaveCellFormattedText(ByVal sender As Object, ByVal e As GridCellTextEventArgs) Handles gridControl1.SaveCellFormattedText
			TraceUtil.TraceCurrentMethodInfo(e)
			ParseText(e)
		End Sub

		Private Sub ParseText(ByVal e As GridCellTextEventArgs)
			' By default, the grid will display a warning message box informing the user
			' the entered value is not valid and the user will have to change the value.
			'
			' In this event handler we change the grid defaults behavior such that
			' when the user enters a value that does not fit the cells CellValueType,
			' the input text is accepted and no warning message is shown.
			If e.Handled OrElse e.Style.Tag Is Nothing OrElse (Not e.Style.Tag.Equals("Custom")) Then
				Return
			End If
            Dim nfi As System.Globalization.NumberFormatInfo
            Dim ci As System.Globalization.CultureInfo = e.Style.CultureInfo
            If ci IsNot Nothing Then
                nfi = ci.NumberFormat
            Else
                nfi = Nothing
            End If

            Try
                e.Style.CellValue = GridCellValueConvert.Parse(e.Text, e.Style.CellValueType, nfi, e.Style.Format)
            Catch ex As Exception
                If TypeOf ex Is FormatException OrElse TypeOf ex.InnerException Is FormatException Then
                    e.Style.CellValue = e.Text
                    ' possibly could also change CellValueType here 
                    e.Style.CellValueType = GetType(String)
                    Console.WriteLine("Changed e.Style.CellValueType = typeof(string) for " & e.Style.Identity.ToString())
                    ' - or -
                    ' you could also further analyze the input text and assign a type
                    ' that fits the input text, e.g.
                    ' e.Style.CellValueType = typeof(datetime);
                    ' - or - 
                    ' e.Style.CellValueType = typeof(decimal);
                    ' etc.
                Else
                    Throw
                End If
            End Try
            e.Handled = True
        End Sub
		#End Region

		#Region "Word"
		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.Click
				Dim converter As New GridWordConverter(True, True)
				AddHandler converter.DrawHeader, AddressOf converter_DrawHeader
				AddHandler converter.DrawFooter, AddressOf converter_DrawFooter
				converter.GridToWord("Sample.doc", gridControl1)
				System.Diagnostics.Process.Start("Sample.doc")
		End Sub

		Private Sub converter_DrawFooter(ByVal sender As Object, ByVal e As DocHeaderFooterEventArgs)
			e.Footer.AddParagraph().AppendText("Copyright 2001-2008")
		End Sub

		Private Sub converter_DrawHeader(ByVal sender As Object, ByVal e As DocHeaderFooterEventArgs)
			e.Header.AddParagraph().AppendText("Syncfusion Inc.")
		End Sub

		#End Region

		#Region "Excel"


		Private Sub buttonAdv4_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv4.Click
			If comboBox1.SelectedIndex = 0 Then
				Dim engine As New ExcelEngine()
				Dim app As IApplication = engine.Excel.Application
				Dim book As IWorkbook = app.Workbooks.Create(1)

				Dim gecc As New Syncfusion.GridExcelConverter.GridExcelConverterControl()

				Dim saveFileDialog As New SaveFileDialog()
				saveFileDialog.Filter = "Files(*.xls)|*.xls"
				saveFileDialog.DefaultExt = ".xls"

				If saveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					gecc.ExportRange(GridRangeInfo.Rows(5, 8), Me.gridControl1.Model, book.Worksheets(0), ConverterOptions.Default)
					book.SaveAs(saveFileDialog.FileName)
					If MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
						Dim proc As New Process()
						proc.StartInfo.FileName = saveFileDialog.FileName
						proc.Start()
					End If
				End If
			End If

			If comboBox1.SelectedIndex = 1 Then
				If gridControl1.Selections.Ranges.Count < 1 Then
					MessageBox.Show("Please select ranges for export")
				Else
					Dim ExcelAdv As New GridExcelConverterControl()
					Dim saveFileDialog As New SaveFileDialog()
					saveFileDialog.Filter = "Files(*.xls)|*.xls"
					saveFileDialog.DefaultExt = ".xls"

					If saveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
						ExcelAdv.SelectedExport(Me.gridControl1.Model, saveFileDialog.FileName, ConverterOptions.Default)

						If MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
							Dim proc As New Process()
							proc.StartInfo.FileName = saveFileDialog.FileName
							proc.Start()
						End If
					End If
				End If
			End If
			If comboBox1.SelectedIndex = 2 Then
				Dim gecc As New Syncfusion.GridExcelConverter.GridExcelConverterControl()

				Dim saveFileDialog As New SaveFileDialog()
				saveFileDialog.Filter = "Files(*.xls)|*.xls"
				saveFileDialog.DefaultExt = ".xls"

				If saveFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					gecc.GridToExcel(Me.gridControl1.Model, saveFileDialog.FileName)

					If MessageBox.Show("Do you wish to open the xls file now?", "Export to Excel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes Then
						Dim proc As New Process()
						proc.StartInfo.FileName = saveFileDialog.FileName
						proc.Start()
					End If
				End If
			End If
		End Sub

		Private Sub buttonAdv5_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv5.Click
			Me.gridControl1.Model.ClearCells(GridRangeInfo.Table(), True)
			Me.gridControl1.ResetColWidthEntries()
			Me.gridControl1.ResetRowHeightEntries()
		End Sub
		#End Region

		#Region "PDF"


		Private Sub buttonAdv7_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv7.Click

			If comboBoxAdv1.SelectedIndex = 0 Then
				If gridControl1.Selections.Ranges.Count < 1 Then
					MessageBox.Show("Please select ranges for export")
				Else
					Dim pdfConvertor As New GridPDFConverter()

					pdfConvertor.ShowHeader = True
					pdfConvertor.ShowFooter = True
					pdfConvertor.Margins.All = 40

					AddHandler pdfConvertor.DrawPDFHeader, AddressOf pdfConvertor_DrawPDFHeader

					AddHandler pdfConvertor.DrawPDFFooter, AddressOf pdfConvertor_DrawPDFFooter

					AddHandler pdfConvertor.Exporting, AddressOf pdfConvertor_Exporting

					AddHandler pdfConvertor.Exported, AddressOf pdfConvertor_Exported

					Dim range As GridRangeInfoList
					If gridControl1.Selections.GetSelectedRanges(range, False) Then
						pdfConvertor.ExportToPdf("Sample1.pdf", Me.gridControl1, range.ActiveRange)
					Else
						'Export only the range passed as argument
						pdfConvertor.ExportToPdf("Sample1.pdf", Me.gridControl1, GridRangeInfo.Rows(5, 10))
					End If

					'Launching the PDF file using the default Application.[Acrobat Reader]
					System.Diagnostics.Process.Start("Sample1.pdf")
				End If
			End If

			If comboBoxAdv1.SelectedIndex = 1 Then
				Dim pdfConvertor As New GridPDFConverter()

				pdfConvertor.ShowHeader = True
				pdfConvertor.ShowFooter = True
				pdfConvertor.Margins.All = 40

				AddHandler pdfConvertor.DrawPDFHeader, AddressOf pdfConvertor_DrawPDFHeader

				AddHandler pdfConvertor.DrawPDFFooter, AddressOf pdfConvertor_DrawPDFFooter

				AddHandler pdfConvertor.Exporting, AddressOf pdfConvertor_Exporting

				AddHandler pdfConvertor.Exported, AddressOf pdfConvertor_Exported

				'Range of rows to be exported in a PDF file
				pdfConvertor.ExportRange = Integer.Parse(domainUpDown1.Text)

				If pdfConvertor.ExportRange > 0 AndAlso pdfConvertor.ExportRange <= gridControl1.RowCount Then
					'Merged Export
					pdfConvertor.ExportToPdfWithMerge("Sample1.pdf", Me.gridControl1)

					'Launching the PDF file using the default Application.[Acrobat Reader]
					System.Diagnostics.Process.Start("Sample1.pdf")
				Else
					pdfConvertor.ExportRange = 60000
					MessageBox.Show("Invalid Export Range!")
				End If
			End If

			If comboBoxAdv1.SelectedIndex = 2 Then
				Dim pdfConvertor As New GridPDFConverter()

				pdfConvertor.ShowHeader = True
				pdfConvertor.ShowFooter = True
				pdfConvertor.Margins.All = 40

				AddHandler pdfConvertor.DrawPDFHeader, AddressOf pdfConvertor_DrawPDFHeader

				AddHandler pdfConvertor.DrawPDFFooter, AddressOf pdfConvertor_DrawPDFFooter

				AddHandler pdfConvertor.Exporting, AddressOf pdfConvertor_Exporting

				AddHandler pdfConvertor.Exported, AddressOf pdfConvertor_Exported

				pdfConvertor.ExportToPdf("Sample1.pdf", Me.gridControl1)

				'Launching the PDF file using the default Application.[Acrobat Reader]
				System.Diagnostics.Process.Start("Sample1.pdf")
			End If
		End Sub
		Private Sub pdfConvertor_DrawPDFFooter(ByVal sender As Object, ByVal e As PDFHeaderFooterEventArgs)
			Dim footer As PdfPageTemplateElement = e.HeaderFooterTemplate

			Dim font As PdfFont = New PdfStandardFont(PdfFontFamily.Helvetica, 8)

			Dim brush As New PdfSolidBrush(Color.Gray)

			Dim pen As New PdfPen(Color.DarkBlue, 3f)
			font = New PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold)
			Dim format As New PdfStringFormat()
			format.Alignment = PdfTextAlignment.Center
			format.LineAlignment = PdfVerticalAlignment.Middle
			footer.Graphics.DrawString("@Copyright 2008", font, brush, New RectangleF(0, footer.Height - 40, footer.Width, footer.Height), format)

			format = New PdfStringFormat()
			format.Alignment = PdfTextAlignment.Right
			format.LineAlignment = PdfVerticalAlignment.Bottom

			'Create page number field
			Dim pageNumber As New PdfPageNumberField(font, brush)

			'Create page count field
			Dim count As New PdfPageCountField(font, brush)

			Dim compositeField As New PdfCompositeField(font, brush, "Page {0} of {1}", pageNumber, count)
			compositeField.Bounds = footer.Bounds
			compositeField.Draw(footer.Graphics, New PointF(470, footer.Height - 10))

		End Sub

		Private Sub pdfConvertor_DrawPDFHeader(ByVal sender As Object, ByVal e As PDFHeaderFooterEventArgs)
			Dim header As PdfPageTemplateElement = e.HeaderFooterTemplate

			Dim font As PdfFont = New PdfStandardFont(PdfFontFamily.Helvetica, 24)
			Dim doubleHeight As Single = font.Height * 2
			Dim activeColor As Color = Color.FromArgb(44, 71, 120)
			Dim imageSize As New SizeF(110f, 35f)
			'Locating the logo on the right corner of the Drawing Surface
			Dim imageLocation As New PointF(e.HeaderFooterTemplate.Width - imageSize.Width - 20, 5)

			Dim img As PdfImage = New PdfBitmap(FindImageFile("common\Images\Grid\PDF_logo\logo.png"))

			'Draw the image in the Header.
			header.Graphics.DrawImage(img, imageLocation, imageSize)

			Dim brush As New PdfSolidBrush(activeColor)

			Dim pen As New PdfPen(Color.DarkBlue, 3f)
			font = New PdfStandardFont(PdfFontFamily.Helvetica, 16, PdfFontStyle.Bold)

			'Set formattings for the text
			Dim format As New PdfStringFormat()
			format.Alignment = PdfTextAlignment.Center
			format.LineAlignment = PdfVerticalAlignment.Middle

			'Draw title
			header.Graphics.DrawString("Syncfusion Essential PDF", font, brush, New RectangleF(0, 0, header.Width, header.Height), format)
			brush = New PdfSolidBrush(Color.Gray)
			font = New PdfStandardFont(PdfFontFamily.Helvetica, 6, PdfFontStyle.Bold)

			format = New PdfStringFormat()
			format.Alignment = PdfTextAlignment.Left
			format.LineAlignment = PdfVerticalAlignment.Bottom

			'Draw description
			header.Graphics.DrawString("Header and Footer Demo", font, brush, New RectangleF(0, 0, header.Width, header.Height - 8), format)

			'Draw some lines in the header
			pen = New PdfPen(Color.DarkBlue, 0.7f)
			header.Graphics.DrawLine(pen, 0, 0, header.Width, 0)
			pen = New PdfPen(Color.DarkBlue, 2f)
			header.Graphics.DrawLine(pen, 0, 03, header.Width + 3, 03)
			pen = New PdfPen(Color.DarkBlue, 2f)
			header.Graphics.DrawLine(pen, 0, header.Height - 3, header.Width, header.Height - 3)
			header.Graphics.DrawLine(pen, 0, header.Height, header.Width, header.Height)
		End Sub

		Private Function FindImageFile(ByVal bitmapName As String) As String
			Dim bitmappath As String = ""
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					bitmappath = bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n
			Return bitmappath
		End Function

		Private Sub pdfConvertor_Exported(ByVal sender As Object, ByVal e As PDFExportedEventArgs)
			MessageBox.Show("Export Completed")
		End Sub

		Private Sub pdfConvertor_Exporting(ByVal sender As Object, ByVal e As PDFExportingEventArgs)
			MessageBox.Show("Export Begins")
		End Sub

		#End Region

		#Region "HTML"
		Private Sub buttonAdv6_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv6.Click
			Dim gecc As New Syncfusion.GridExcelConverter.GridExcelConverterControl()

			Dim openFileDialog As New OpenFileDialog()
			openFileDialog.Filter = "Files(*.xls)|*.xls"
			openFileDialog.DefaultExt = ".xls"

			If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				gecc.ExcelToGrid(openFileDialog.FileName, Me.gridControl1.Model)
			End If

			Me.gridControl1.Refresh()
		End Sub

		Private Sub buttonAdv3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv3.Click
			Me.gridControl1.Selections.Add(GridRangeInfo.Table())
		End Sub
		Private Sub buttonAdv8_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv8.Click
			CopyHtmlToClipBoard(ExportAsHTML(Me.gridControl1.Selections.Ranges).ToString(), False)
		End Sub

		Private Sub buttonAdv2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv2.Click
			Dim rL As New GridRangeInfoList()
			rL.Add(GridRangeInfo.Table())
			System.Diagnostics.Process.Start(CopyHtmlToClipBoard(ExportAsHTML(rL).ToString(), True))
		End Sub
		#Region "Borders to HTML STYLE"
		Private Function BorderAsStyle(ByVal border As GridBorder, ByVal header As HeaderInfo) As String
			Dim borderInfo As String = ""
			If (header And HeaderInfo.NotHeader) <> HeaderInfo.NotHeader Then
				Select Case header
					Case HeaderInfo.LightShade
						borderInfo &= "Solid #F1EFE2"
					Case HeaderInfo.DarkShade
						borderInfo &= "Solid #A9A9A9"
				End Select

            Else
                If border.Style = GridBorderStyle.Standard Then
                    borderInfo &= gridControl1.DefaultGridBorderStyle.ToString() & " " & ColorTranslator.ToHtml(Color.FromArgb(border.Color.A, border.Color.R, border.Color.G, border.Color.B))
                Else
                    borderInfo &= border.Style.ToString() & " " & ColorTranslator.ToHtml(Color.FromArgb(border.Color.A, border.Color.R, border.Color.G, border.Color.B))
                End If
            End If


			Return border.Width.ToString() & "px " & borderInfo
		End Function

		Private Function BordersAsStyle(ByVal borders As GridBordersInfo) As String
			Dim header As New HeaderInfo()
			If borders.GetGridStyleInfo().CellType IsNot GridCellTypeName.Header Then
				header = HeaderInfo.NotHeader
			End If

			Return "border-top:" & BorderAsStyle(borders.Top, header Or HeaderInfo.LightShade) & ";border-right:" & BorderAsStyle(borders.Right, header Or HeaderInfo.DarkShade) & ";border-bottom:" & BorderAsStyle(borders.Bottom, header Or HeaderInfo.DarkShade) & ";border-left:" & BorderAsStyle(borders.Left, header Or HeaderInfo.LightShade) & ";"
		End Function

		<Flags> _
		Public Enum HeaderInfo
			NotHeader = 4
			LightShade = 2
			DarkShade = 1
		End Enum

		#End Region
		#Region "Font to HTML STYLE"
        Private Function FontAsStyle(ByVal font As GridFontInfo, ByVal color As Color, ByVal halign As GridHorizontalAlignment) As String
            Dim gfont As String
            If font.Italic Then
                gfont = "italic "
            Else
                gfont = ""
            End If
            If font.Bold Then
                gfont = "bold "
            Else
                gfont = " "
            End If
            gfont = gfont + font.Size & "px " & font.Facename & ";text-decoration:"
            If font.Strikeout Then
                gfont = "strikeout "
            Else
                gfont = ""
            End If
            If font.Underline Then
                gfont = "underline "
            Else
                gfont = ""
            End If
            gfont = gfont & ColorTranslator.ToHtml(color.FromArgb(color.A, color.R, color.G, color.B)) & ";"
            Return gfont
            'Return "font: " & (If(font.Italic, "italic ", "")) + (If(font.Bold, "bold ", "")) + +font.Size & "px " & font.Facename & ";text-decoration:" & (If(font.Strikeout, " line-through", "")) + (If(font.Underline, " underline", "")) + (If(Not(font.Underline OrElse font.Strikeout), " none", "")) & ";text-align: " & halign.ToString() & ";color:" & ColorTranslator.ToHtml(Color.FromArgb(color.A, color.R, color.G, color.B)) & ";"
        End Function
		#End Region
		#Region "enrich HTML"
		Private Function ExportAsHTML(ByVal rangeList As GridRangeInfoList) As StringBuilder

			Dim expandedRange As GridRangeInfoList = rangeList.ExpandRanges(0, 0, Me.gridControl1.RowCount, Me.gridControl1.ColCount)
			Dim html As New StringBuilder()
			For Each r As GridRangeInfo In expandedRange
				html.Append("<table border=""0"">")
				For i As Integer = r.Top To r.Bottom
					html.Append("<tr>")
					For j As Integer = r.Left To r.Right
						Dim style As GridStyleInfo = Me.gridControl1.Model(i, j)

						Dim align As String = style.VerticalAlignment.ToString()
						Dim bcolor As String = ColorTranslator.ToHtml(Color.FromArgb(style.BackColor.A, style.BackColor.R, style.BackColor.G, style.BackColor.B))
						Dim fcolor As String = ColorTranslator.ToHtml(Color.FromArgb(style.TextColor.A, style.TextColor.R, style.TextColor.G, style.TextColor.B))
						Dim htmlStyle As String = BordersAsStyle(style.Borders)
						htmlStyle &= " " & FontAsStyle(style.Font, style.TextColor, style.HorizontalAlignment)

						Dim o As Object = CObj(style.FormattedText)
						Dim tag As String = "td"

						'add a non-breaking space (&nbsp;) to empty cells, to make the borders visible:
						If Not style.HasText Then
							o = CObj("&nbsp;")
						End If

						If style.CellType Is GridCellTypeName.Header Then
							If j > Me.gridControl1.Cols.HeaderCount AndAlso i = 0 AndAlso (Not style.HasText) Then
								o = CObj(GridRangeInfo.GetAlphaLabel(j))
							Else
								If j = 0 AndAlso i > Me.gridControl1.Rows.HeaderCount AndAlso (Not style.HasText) Then
									o = CObj(i)
								End If
							End If
							tag = "th"
						End If

						html.AppendFormat("<" & tag & " width=""{0}"" height = ""{1}"" valign =""{2}"" bgcolor=""{3}"" style=""{4}"">", Me.gridControl1.ColWidths(j), Me.gridControl1.RowHeights(i), align, bcolor, htmlStyle)

						If style.CellType Is GridCellTypeName.CheckBox OrElse style.CellType Is GridCellTypeName.PushButton OrElse style.CellType Is GridCellTypeName.RadioButton OrElse style.CellType Is GridCellTypeName.Image OrElse style.CellType Is GridCellTypeName.ComboBox Then
							Select Case style.CellType
                                Case "CheckBox"
                                    If style.CheckBoxOptions.HasCheckedValue Then
                                        If style.CheckBoxOptions.CheckedValue = style.CellValue.ToString() Then
                                            html.AppendFormat("<input type=""checkbox"" id=""checkboxR{0}C{1}"" name=""checkbox1"" {2}>", i, j, "checked")
                                        Else
                                            html.AppendFormat("<input type=""checkbox"" id=""checkboxR{0}C{1}"" name=""checkbox1"" {2}>", i, j, "checked")
                                        End If
                                    Else
                                        If style.CellValue.ToString() = "1" Then
                                            html.AppendFormat("<input type=""checkbox"" id=""checkboxR{0}C{1}"" name=""checkbox1"" {2}>", i, j, "checked")
                                        Else
                                            html.AppendFormat("<input type=""checkbox"" id=""checkboxR{0}C{1}"" name=""checkbox1"" {2}>", i, j, "checked")
                                        End If
                                    End If
                                    'html.AppendFormat("<input type=""checkbox"" id=""checkboxR{0}C{1}"" name=""checkbox1"" {2}>", i, j, (If(style.CheckBoxOptions.HasCheckedValue, (If(style.CheckBoxOptions.CheckedValue = style.CellValue.ToString(), "checked", "")), If((style.CellValue.ToString() = "1"), "checked", ""))))
                                    If style.HasDescription Then
                                        html.AppendFormat(style.Description)
                                    Else
                                        html.AppendFormat("")
                                    End If
                                    'html.AppendFormat(If(style.HasDescription, style.Description, ""))
								Case "Image"
									If style.ImageIndex <> -1 AndAlso style.ImageList IsNot Nothing AndAlso style.ImageList.Images.Count > style.ImageIndex Then
										Dim srcFile As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetTempFileName() & ".jpg")
										style.ImageList.Images(style.ImageIndex).Save(srcFile, System.Drawing.Imaging.ImageFormat.Jpeg)
										html.AppendFormat("<img src=""{0}"">", srcFile)
									End If
								Case "PushButton"
									'To show button uncomment below
									'html.AppendFormat("<input type=\"button\" value=\"{0}\">",style.Description);
									html.Append(style.Description)
                                Case "RadioButton"
                                    Dim state As String
                                    
                                    For rc As Integer = 0 To style.ChoiceList.Count - 1
                                        If rc.ToString() = style.CellValue.ToString() Then
                                            state = "checked"
                                        Else
                                            state = ""
                                        End If
                                        html.AppendFormat("{0}<input type=""radio"" id=""radio{1}R{2}C{3}"" value=""radio{1}"" name=""RadioGroup{4}"" {5}>", style.ChoiceList(rc), rc, i, j, i * Me.gridControl1.ColCount + j, state)
                                    Next rc
                                Case "ComboBox"
                                    If style.ChoiceList IsNot Nothing Then
                                        Dim choice As String
                                        html.Append("<select>")
                                        html.Append("<OPTION></OPTION>")
                                        For lc As Integer = 0 To style.ChoiceList.Count - 1
                                            If style.ChoiceList(lc) = style.CellValue.ToString() Then
                                                choice = "selected"
                                            Else
                                                choice = ""
                                            End If
                                            html.AppendFormat("<option value=""{0}"" {1}>{0}</option>", style.ChoiceList(lc), choice)
                                        Next lc
                                        html.Append("</select>")
                                    Else
                                        html.Append(style.FormattedText)
                                    End If
                            End Select
						Else
							html.AppendFormat("{0}", o)
						End If

						html.AppendFormat("</" & tag & ">")
					Next j
					html.Append("</tr>")
				Next i
				html.Append("</table>")
			Next r
			Return html
		End Function
		#End Region
		#Region "revamp HTML and place on Clipboard"
		Public Shared Function CopyHtmlToClipBoard(ByVal html As String, ByVal ie As Boolean) As String
			If html <> "" Then

                Dim enc As Encoding = Encoding.UTF8
                Dim begin As String
                If ie Then
                    begin = "<!--Syncfusion Essential Grid-->"
                Else
                    begin = "Version:0.9" & Constants.vbCrLf & "StartHTML:{0:000000}" & Constants.vbCrLf & "EndHTML:{1:000000}" & Constants.vbCrLf & "StartFragment:{2:000000}" & Constants.vbCrLf & "EndFragment:{3:000000}" & Constants.vbCrLf
                End If
                '= If(ie, "<!--Syncfusion Essential Grid-->", "Version:0.9" & Constants.vbCrLf & "StartHTML:{0:000000}" & Constants.vbCrLf & "EndHTML:{1:000000}" & Constants.vbCrLf & "StartFragment:{2:000000}" & Constants.vbCrLf & "EndFragment:{3:000000}" & Constants.vbCrLf)
				Dim html_begin As String = "<html>" & Constants.vbCrLf & "<head>" & Constants.vbCrLf & "<meta http-equiv=""Content-Type""" & " content=""text/html; charset=" & enc.WebName & """>" & Constants.vbCrLf & "<title>Syncfusion Essential Grid</title>" & Constants.vbCrLf & "</head>" & Constants.vbCrLf & "<body>" & Constants.vbCrLf & "<!--StartFragment-->"

				Dim html_end As String = "<!--EndFragment-->" & Constants.vbCrLf & "</body>" & Constants.vbCrLf & "</html>" & Constants.vbCrLf

				Dim begin_sample As String = String.Format(begin, 0, 0, 0, 0)

				Dim count_begin As Integer = enc.GetByteCount(begin_sample)
				Dim count_html_begin As Integer = enc.GetByteCount(html_begin)
				Dim count_html As Integer = enc.GetByteCount(html)
				Dim count_html_end As Integer = enc.GetByteCount(html_end)

				Dim html_total As String = String.Format(begin, count_begin, count_begin + count_html_begin + count_html + count_html_end, count_begin + count_html_begin, count_begin + count_html_begin + count_html) + html_begin & html & html_end

				Dim obj As New DataObject()
				obj.SetData(DataFormats.Html, New System.IO.MemoryStream(enc.GetBytes(html_total)))
				obj.SetData(DataFormats.Text, True, html_total)
				Clipboard.SetDataObject(obj, True)
				Dim htmlFile As String = System.IO.Path.Combine(System.IO.Path.GetTempPath(), System.IO.Path.GetTempFileName() & ".html")
				Dim sw As System.IO.StreamWriter = System.IO.File.CreateText(htmlFile)
				sw.Write(html_total)
				sw.Close()
				Return htmlFile
			End If
			Return ""
		End Function
		#End Region

		Private Sub xpTaskBarBox3_ItemClick(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickArgs) Handles xpTaskBarBox3.ItemClick

		End Sub


		#End Region

		Private Sub xpTaskBarBox1_ItemClick(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickArgs) Handles xpTaskBarBox1.ItemClick

		End Sub
	End Class
End Namespace
