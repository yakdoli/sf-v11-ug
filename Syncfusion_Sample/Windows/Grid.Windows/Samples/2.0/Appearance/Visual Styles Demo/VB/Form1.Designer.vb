Imports Microsoft.VisualBasic
Imports System
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Grid
Namespace VisualStyle_Demo
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim gridBaseStyle9 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle10 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle11 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle12 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridRangeStyle65 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle66 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle67 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle68 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle69 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle70 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle71 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle72 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle73 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle74 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle75 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle76 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle77 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle78 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle79 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle80 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle81 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle82 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle83 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle84 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle85 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle86 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle87 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle88 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle89 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle90 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle91 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle92 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle93 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle94 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle95 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim gridRangeStyle96 As New Syncfusion.Windows.Forms.Grid.GridRangeStyle()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			Me.pictureBox1 = New System.Windows.Forms.PictureBox()
			Me.pictureBox2 = New System.Windows.Forms.PictureBox()
			Me.pictureBox3 = New System.Windows.Forms.PictureBox()
			Me.pictureBox4 = New System.Windows.Forms.PictureBox()
			Me.pictureBox5 = New System.Windows.Forms.PictureBox()
			Me.pictureBox6 = New System.Windows.Forms.PictureBox()
			Me.pictureBox7 = New System.Windows.Forms.PictureBox()
			Me.groupBox1 = New System.Windows.Forms.GroupBox()
			Me.groupBox3 = New System.Windows.Forms.GroupBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.panel2 = New System.Windows.Forms.Panel()
			Me.groupBox2 = New System.Windows.Forms.GroupBox()
			Me.label6 = New System.Windows.Forms.Label()
			Me.label5 = New System.Windows.Forms.Label()
			Me.label4 = New System.Windows.Forms.Label()
			Me.label3 = New System.Windows.Forms.Label()
			Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
			Me.label8 = New System.Windows.Forms.Label()
			Me.label7 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupBox1.SuspendLayout()
			Me.groupBox3.SuspendLayout()
			Me.groupBox2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			gridBaseStyle9.Name = "Row Header"
			gridBaseStyle9.StyleInfo.BaseStyle = "Header"
			gridBaseStyle9.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
			gridBaseStyle9.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(184)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(216)))))))
			gridBaseStyle10.Name = "Column Header"
			gridBaseStyle10.StyleInfo.BaseStyle = "Header"
			gridBaseStyle10.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridBaseStyle11.Name = "Standard"
			gridBaseStyle11.StyleInfo.Font.Facename = "Tahoma"
			gridBaseStyle11.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
			gridBaseStyle12.Name = "Header"
			gridBaseStyle12.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle12.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle12.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle12.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle12.StyleInfo.CellType = "Header"
			gridBaseStyle12.StyleInfo.Font.Bold = True
			gridBaseStyle12.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(184)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(216)))))))
			gridBaseStyle12.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
			Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() { gridBaseStyle9, gridBaseStyle10, gridBaseStyle11, gridBaseStyle12})
			Me.gridControl1.ColCount = 8
			Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() { New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
			Me.gridControl1.DefaultRowHeight = 20
			Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25F)
			Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2010
			Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2010Black
			Me.gridControl1.HScrollBehavior = Syncfusion.Windows.Forms.Grid.GridScrollbarMode.Enabled
			Me.gridControl1.Location = New System.Drawing.Point(23, 48)
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Office2010ScrollBarsColorScheme = Syncfusion.Windows.Forms.Office2010ColorScheme.Black
			gridRangeStyle65.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle65.StyleInfo.Font.Bold = False
			gridRangeStyle65.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle65.StyleInfo.Font.Italic = False
			gridRangeStyle65.StyleInfo.Font.Size = 8.25F
			gridRangeStyle65.StyleInfo.Font.Strikeout = False
			gridRangeStyle65.StyleInfo.Font.Underline = False
			gridRangeStyle65.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle66.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle66.StyleInfo.Font.Bold = False
			gridRangeStyle66.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle66.StyleInfo.Font.Italic = False
			gridRangeStyle66.StyleInfo.Font.Size = 8.25F
			gridRangeStyle66.StyleInfo.Font.Strikeout = False
			gridRangeStyle66.StyleInfo.Font.Underline = False
			gridRangeStyle66.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle67.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle67.StyleInfo.Font.Bold = False
			gridRangeStyle67.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle67.StyleInfo.Font.Italic = False
			gridRangeStyle67.StyleInfo.Font.Size = 8.25F
			gridRangeStyle67.StyleInfo.Font.Strikeout = False
			gridRangeStyle67.StyleInfo.Font.Underline = False
			gridRangeStyle67.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle68.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle68.StyleInfo.Font.Bold = False
			gridRangeStyle68.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle68.StyleInfo.Font.Italic = False
			gridRangeStyle68.StyleInfo.Font.Size = 8.25F
			gridRangeStyle68.StyleInfo.Font.Strikeout = False
			gridRangeStyle68.StyleInfo.Font.Underline = False
			gridRangeStyle68.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle69.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle69.StyleInfo.Font.Bold = False
			gridRangeStyle69.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle69.StyleInfo.Font.Italic = False
			gridRangeStyle69.StyleInfo.Font.Size = 8.25F
			gridRangeStyle69.StyleInfo.Font.Strikeout = False
			gridRangeStyle69.StyleInfo.Font.Underline = False
			gridRangeStyle69.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle70.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle70.StyleInfo.Font.Bold = False
			gridRangeStyle70.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle70.StyleInfo.Font.Italic = False
			gridRangeStyle70.StyleInfo.Font.Size = 8.25F
			gridRangeStyle70.StyleInfo.Font.Strikeout = False
			gridRangeStyle70.StyleInfo.Font.Underline = False
			gridRangeStyle70.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle71.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle71.StyleInfo.Font.Bold = False
			gridRangeStyle71.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle71.StyleInfo.Font.Italic = False
			gridRangeStyle71.StyleInfo.Font.Size = 8.25F
			gridRangeStyle71.StyleInfo.Font.Strikeout = False
			gridRangeStyle71.StyleInfo.Font.Underline = False
			gridRangeStyle71.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle72.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle72.StyleInfo.Font.Bold = False
			gridRangeStyle72.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle72.StyleInfo.Font.Italic = False
			gridRangeStyle72.StyleInfo.Font.Size = 8.25F
			gridRangeStyle72.StyleInfo.Font.Strikeout = False
			gridRangeStyle72.StyleInfo.Font.Underline = False
			gridRangeStyle72.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle73.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle73.StyleInfo.Font.Bold = False
			gridRangeStyle73.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle73.StyleInfo.Font.Italic = False
			gridRangeStyle73.StyleInfo.Font.Size = 8.25F
			gridRangeStyle73.StyleInfo.Font.Strikeout = False
			gridRangeStyle73.StyleInfo.Font.Underline = False
			gridRangeStyle73.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle74.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle74.StyleInfo.Font.Bold = False
			gridRangeStyle74.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle74.StyleInfo.Font.Italic = False
			gridRangeStyle74.StyleInfo.Font.Size = 8.25F
			gridRangeStyle74.StyleInfo.Font.Strikeout = False
			gridRangeStyle74.StyleInfo.Font.Underline = False
			gridRangeStyle74.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle75.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle75.StyleInfo.Font.Bold = False
			gridRangeStyle75.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle75.StyleInfo.Font.Italic = False
			gridRangeStyle75.StyleInfo.Font.Size = 8.25F
			gridRangeStyle75.StyleInfo.Font.Strikeout = False
			gridRangeStyle75.StyleInfo.Font.Underline = False
			gridRangeStyle75.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle76.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle76.StyleInfo.Font.Bold = False
			gridRangeStyle76.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle76.StyleInfo.Font.Italic = False
			gridRangeStyle76.StyleInfo.Font.Size = 8.25F
			gridRangeStyle76.StyleInfo.Font.Strikeout = False
			gridRangeStyle76.StyleInfo.Font.Underline = False
			gridRangeStyle76.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle77.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle77.StyleInfo.Font.Bold = False
			gridRangeStyle77.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle77.StyleInfo.Font.Italic = False
			gridRangeStyle77.StyleInfo.Font.Size = 8.25F
			gridRangeStyle77.StyleInfo.Font.Strikeout = False
			gridRangeStyle77.StyleInfo.Font.Underline = False
			gridRangeStyle77.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle78.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle78.StyleInfo.Font.Bold = False
			gridRangeStyle78.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle78.StyleInfo.Font.Italic = False
			gridRangeStyle78.StyleInfo.Font.Size = 8.25F
			gridRangeStyle78.StyleInfo.Font.Strikeout = False
			gridRangeStyle78.StyleInfo.Font.Underline = False
			gridRangeStyle78.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle79.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle79.StyleInfo.Font.Bold = False
			gridRangeStyle79.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle79.StyleInfo.Font.Italic = False
			gridRangeStyle79.StyleInfo.Font.Size = 8.25F
			gridRangeStyle79.StyleInfo.Font.Strikeout = False
			gridRangeStyle79.StyleInfo.Font.Underline = False
			gridRangeStyle79.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle80.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle80.StyleInfo.Font.Bold = False
			gridRangeStyle80.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle80.StyleInfo.Font.Italic = False
			gridRangeStyle80.StyleInfo.Font.Size = 8.25F
			gridRangeStyle80.StyleInfo.Font.Strikeout = False
			gridRangeStyle80.StyleInfo.Font.Underline = False
			gridRangeStyle80.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle81.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle81.StyleInfo.Font.Bold = False
			gridRangeStyle81.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle81.StyleInfo.Font.Italic = False
			gridRangeStyle81.StyleInfo.Font.Size = 8.25F
			gridRangeStyle81.StyleInfo.Font.Strikeout = False
			gridRangeStyle81.StyleInfo.Font.Underline = False
			gridRangeStyle81.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle82.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle82.StyleInfo.Font.Bold = False
			gridRangeStyle82.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle82.StyleInfo.Font.Italic = False
			gridRangeStyle82.StyleInfo.Font.Size = 8.25F
			gridRangeStyle82.StyleInfo.Font.Strikeout = False
			gridRangeStyle82.StyleInfo.Font.Underline = False
			gridRangeStyle82.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle83.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle83.StyleInfo.Font.Bold = False
			gridRangeStyle83.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle83.StyleInfo.Font.Italic = False
			gridRangeStyle83.StyleInfo.Font.Size = 8.25F
			gridRangeStyle83.StyleInfo.Font.Strikeout = False
			gridRangeStyle83.StyleInfo.Font.Underline = False
			gridRangeStyle83.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle84.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle84.StyleInfo.Font.Bold = False
			gridRangeStyle84.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle84.StyleInfo.Font.Italic = False
			gridRangeStyle84.StyleInfo.Font.Size = 8.25F
			gridRangeStyle84.StyleInfo.Font.Strikeout = False
			gridRangeStyle84.StyleInfo.Font.Underline = False
			gridRangeStyle84.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle85.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle85.StyleInfo.Font.Bold = False
			gridRangeStyle85.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle85.StyleInfo.Font.Italic = False
			gridRangeStyle85.StyleInfo.Font.Size = 8.25F
			gridRangeStyle85.StyleInfo.Font.Strikeout = False
			gridRangeStyle85.StyleInfo.Font.Underline = False
			gridRangeStyle85.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle86.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle86.StyleInfo.Font.Bold = False
			gridRangeStyle86.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle86.StyleInfo.Font.Italic = False
			gridRangeStyle86.StyleInfo.Font.Size = 8.25F
			gridRangeStyle86.StyleInfo.Font.Strikeout = False
			gridRangeStyle86.StyleInfo.Font.Underline = False
			gridRangeStyle86.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle87.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle87.StyleInfo.Font.Bold = False
			gridRangeStyle87.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle87.StyleInfo.Font.Italic = False
			gridRangeStyle87.StyleInfo.Font.Size = 8.25F
			gridRangeStyle87.StyleInfo.Font.Strikeout = False
			gridRangeStyle87.StyleInfo.Font.Underline = False
			gridRangeStyle87.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle88.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle88.StyleInfo.Font.Bold = False
			gridRangeStyle88.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle88.StyleInfo.Font.Italic = False
			gridRangeStyle88.StyleInfo.Font.Size = 8.25F
			gridRangeStyle88.StyleInfo.Font.Strikeout = False
			gridRangeStyle88.StyleInfo.Font.Underline = False
			gridRangeStyle88.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle89.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle89.StyleInfo.Font.Bold = False
			gridRangeStyle89.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle89.StyleInfo.Font.Italic = False
			gridRangeStyle89.StyleInfo.Font.Size = 8.25F
			gridRangeStyle89.StyleInfo.Font.Strikeout = False
			gridRangeStyle89.StyleInfo.Font.Underline = False
			gridRangeStyle89.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle90.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle90.StyleInfo.Font.Bold = False
			gridRangeStyle90.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle90.StyleInfo.Font.Italic = False
			gridRangeStyle90.StyleInfo.Font.Size = 8.25F
			gridRangeStyle90.StyleInfo.Font.Strikeout = False
			gridRangeStyle90.StyleInfo.Font.Underline = False
			gridRangeStyle90.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle91.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle91.StyleInfo.Font.Bold = False
			gridRangeStyle91.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle91.StyleInfo.Font.Italic = False
			gridRangeStyle91.StyleInfo.Font.Size = 8.25F
			gridRangeStyle91.StyleInfo.Font.Strikeout = False
			gridRangeStyle91.StyleInfo.Font.Underline = False
			gridRangeStyle91.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle92.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle92.StyleInfo.Font.Bold = False
			gridRangeStyle92.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle92.StyleInfo.Font.Italic = False
			gridRangeStyle92.StyleInfo.Font.Size = 8.25F
			gridRangeStyle92.StyleInfo.Font.Strikeout = False
			gridRangeStyle92.StyleInfo.Font.Underline = False
			gridRangeStyle92.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle93.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle93.StyleInfo.Font.Bold = False
			gridRangeStyle93.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle93.StyleInfo.Font.Italic = False
			gridRangeStyle93.StyleInfo.Font.Size = 8.25F
			gridRangeStyle93.StyleInfo.Font.Strikeout = False
			gridRangeStyle93.StyleInfo.Font.Underline = False
			gridRangeStyle93.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle94.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle94.StyleInfo.Font.Bold = False
			gridRangeStyle94.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle94.StyleInfo.Font.Italic = False
			gridRangeStyle94.StyleInfo.Font.Size = 8.25F
			gridRangeStyle94.StyleInfo.Font.Strikeout = False
			gridRangeStyle94.StyleInfo.Font.Underline = False
			gridRangeStyle94.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle95.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle95.StyleInfo.Font.Bold = False
			gridRangeStyle95.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle95.StyleInfo.Font.Italic = False
			gridRangeStyle95.StyleInfo.Font.Size = 8.25F
			gridRangeStyle95.StyleInfo.Font.Strikeout = False
			gridRangeStyle95.StyleInfo.Font.Underline = False
			gridRangeStyle95.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
			gridRangeStyle96.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table()
			gridRangeStyle96.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle96.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb((CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(234)))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
			gridRangeStyle96.StyleInfo.Font.Facename = "Segoe UI"
			gridRangeStyle96.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
			gridRangeStyle96.StyleInfo.TextColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))), (CInt(Fix((CByte(138))))))
			Me.gridControl1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() { gridRangeStyle65, gridRangeStyle66, gridRangeStyle67, gridRangeStyle68, gridRangeStyle69, gridRangeStyle70, gridRangeStyle71, gridRangeStyle72, gridRangeStyle73, gridRangeStyle74, gridRangeStyle75, gridRangeStyle76, gridRangeStyle77, gridRangeStyle78, gridRangeStyle79, gridRangeStyle80, gridRangeStyle81, gridRangeStyle82, gridRangeStyle83, gridRangeStyle84, gridRangeStyle85, gridRangeStyle86, gridRangeStyle87, gridRangeStyle88, gridRangeStyle89, gridRangeStyle90, gridRangeStyle91, gridRangeStyle92, gridRangeStyle93, gridRangeStyle94, gridRangeStyle95, gridRangeStyle96})
			Me.gridControl1.RowCount = 40
			Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() { New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)})
			Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
			Me.gridControl1.Size = New System.Drawing.Size(610, 509)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 4
			Me.gridControl1.Text = "gridControl1"
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.UseRightToLeftCompatibleTextBox = True
			Me.gridControl1.VScrollBehavior = Syncfusion.Windows.Forms.Grid.GridScrollbarMode.Enabled
			Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
'			Me.gridControl1.CheckBoxClick += New Syncfusion.Windows.Forms.Grid.GridCellClickEventHandler(Me.gridControl1_CheckBoxClick)
			' 
			' pictureBox1
			' 
			Me.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox1.Image = (CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image))
			Me.pictureBox1.Location = New System.Drawing.Point(11, 24)
			Me.pictureBox1.Name = "pictureBox1"
			Me.pictureBox1.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox1.TabIndex = 0
			Me.pictureBox1.TabStop = False
'			Me.pictureBox1.MouseLeave += New System.EventHandler(Me.pictureBox_MouseLeave)
'			Me.pictureBox1.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox_MouseClick)
'			Me.pictureBox1.MouseHover += New System.EventHandler(Me.pictureBox_MouseHover)
			' 
			' pictureBox2
			' 
			Me.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox2.Image = (CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image))
			Me.pictureBox2.Location = New System.Drawing.Point(46, 24)
			Me.pictureBox2.Name = "pictureBox2"
			Me.pictureBox2.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox2.TabIndex = 1
			Me.pictureBox2.TabStop = False
'			Me.pictureBox2.MouseLeave += New System.EventHandler(Me.pictureBox_MouseLeave)
'			Me.pictureBox2.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox_MouseClick)
'			Me.pictureBox2.MouseHover += New System.EventHandler(Me.pictureBox_MouseHover)
			' 
			' pictureBox3
			' 
			Me.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox3.Image = (CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image))
			Me.pictureBox3.Location = New System.Drawing.Point(81, 24)
			Me.pictureBox3.Name = "pictureBox3"
			Me.pictureBox3.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox3.TabIndex = 2
			Me.pictureBox3.TabStop = False
'			Me.pictureBox3.MouseLeave += New System.EventHandler(Me.pictureBox_MouseLeave)
'			Me.pictureBox3.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox_MouseClick)
'			Me.pictureBox3.MouseHover += New System.EventHandler(Me.pictureBox_MouseHover)
			' 
			' pictureBox4
			' 
			Me.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox4.Image = (CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image))
			Me.pictureBox4.Location = New System.Drawing.Point(116, 24)
			Me.pictureBox4.Name = "pictureBox4"
			Me.pictureBox4.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox4.TabIndex = 3
			Me.pictureBox4.TabStop = False
'			Me.pictureBox4.MouseLeave += New System.EventHandler(Me.pictureBox_MouseLeave)
'			Me.pictureBox4.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox_MouseClick)
'			Me.pictureBox4.MouseHover += New System.EventHandler(Me.pictureBox_MouseHover)
			' 
			' pictureBox5
			' 
			Me.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox5.Image = (CType(resources.GetObject("pictureBox5.Image"), System.Drawing.Image))
			Me.pictureBox5.Location = New System.Drawing.Point(151, 24)
			Me.pictureBox5.Name = "pictureBox5"
			Me.pictureBox5.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox5.TabIndex = 4
			Me.pictureBox5.TabStop = False
'			Me.pictureBox5.MouseLeave += New System.EventHandler(Me.pictureBox_MouseLeave)
'			Me.pictureBox5.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox_MouseClick)
'			Me.pictureBox5.MouseHover += New System.EventHandler(Me.pictureBox_MouseHover)
			' 
			' pictureBox6
			' 
			Me.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox6.Image = (CType(resources.GetObject("pictureBox6.Image"), System.Drawing.Image))
			Me.pictureBox6.Location = New System.Drawing.Point(186, 24)
			Me.pictureBox6.Name = "pictureBox6"
			Me.pictureBox6.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox6.TabIndex = 5
			Me.pictureBox6.TabStop = False
'			Me.pictureBox6.MouseLeave += New System.EventHandler(Me.pictureBox_MouseLeave)
'			Me.pictureBox6.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox_MouseClick)
'			Me.pictureBox6.MouseHover += New System.EventHandler(Me.pictureBox_MouseHover)
			' 
			' pictureBox7
			' 
			Me.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
			Me.pictureBox7.Image = (CType(resources.GetObject("pictureBox7.Image"), System.Drawing.Image))
			Me.pictureBox7.Location = New System.Drawing.Point(221, 24)
			Me.pictureBox7.Name = "pictureBox7"
			Me.pictureBox7.Size = New System.Drawing.Size(30, 30)
			Me.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
			Me.pictureBox7.TabIndex = 4
			Me.pictureBox7.TabStop = False
'			Me.pictureBox7.MouseLeave += New System.EventHandler(Me.pictureBox_MouseLeave)
'			Me.pictureBox7.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.pictureBox_MouseClick)
'			Me.pictureBox7.MouseHover += New System.EventHandler(Me.pictureBox_MouseHover)
			' 
			' groupBox1
			' 
			Me.groupBox1.Controls.Add(Me.label8)
			Me.groupBox1.Controls.Add(Me.label7)
			Me.groupBox1.Controls.Add(Me.label2)
			Me.groupBox1.Controls.Add(Me.groupBox3)
			Me.groupBox1.Controls.Add(Me.groupBox2)
			Me.groupBox1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox1.Location = New System.Drawing.Point(10, 12)
			Me.groupBox1.Name = "groupBox1"
			Me.groupBox1.Size = New System.Drawing.Size(914, 558)
			Me.groupBox1.TabIndex = 7
			Me.groupBox1.TabStop = False
			Me.groupBox1.Text = "GridControl"
			' 
			' groupBox3
			' 
			Me.groupBox3.Controls.Add(Me.label1)
			Me.groupBox3.Controls.Add(Me.panel1)
			Me.groupBox3.Controls.Add(Me.pictureBox5)
			Me.groupBox3.Controls.Add(Me.panel2)
			Me.groupBox3.Controls.Add(Me.pictureBox3)
			Me.groupBox3.Controls.Add(Me.pictureBox4)
			Me.groupBox3.Controls.Add(Me.pictureBox7)
			Me.groupBox3.Controls.Add(Me.pictureBox2)
			Me.groupBox3.Controls.Add(Me.pictureBox6)
			Me.groupBox3.Controls.Add(Me.pictureBox1)
			Me.groupBox3.Location = New System.Drawing.Point(641, 30)
			Me.groupBox3.Name = "groupBox3"
			Me.groupBox3.Size = New System.Drawing.Size(259, 86)
			Me.groupBox3.TabIndex = 11
			Me.groupBox3.TabStop = False
			Me.groupBox3.Text = "Styles"
			' 
			' label1
			' 
			Me.label1.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(59, 69)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(176, 13)
			Me.label1.TabIndex = 13
			Me.label1.Text = "GridVisualStyles.Metro"
			Me.label1.Visible = False
			' 
			' panel1
			' 
			Me.panel1.BackColor = System.Drawing.Color.DimGray
			Me.panel1.Location = New System.Drawing.Point(190, 60)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(26, 4)
			Me.panel1.TabIndex = 12
			' 
			' panel2
			' 
			Me.panel2.BackColor = System.Drawing.Color.Orange
			Me.panel2.Location = New System.Drawing.Point(13, 60)
			Me.panel2.Name = "panel2"
			Me.panel2.Size = New System.Drawing.Size(26, 4)
			Me.panel2.TabIndex = 7
			Me.panel2.Visible = False
			' 
			' groupBox2
			' 
			Me.groupBox2.Controls.Add(Me.label6)
			Me.groupBox2.Controls.Add(Me.label5)
			Me.groupBox2.Controls.Add(Me.label4)
			Me.groupBox2.Controls.Add(Me.label3)
			Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.groupBox2.ForeColor = System.Drawing.Color.Black
			Me.groupBox2.Location = New System.Drawing.Point(641, 130)
			Me.groupBox2.Name = "groupBox2"
			Me.groupBox2.Size = New System.Drawing.Size(259, 89)
			Me.groupBox2.TabIndex = 10
			Me.groupBox2.TabStop = False
			Me.groupBox2.Text = "Applied Changes"
			' 
			' label6
			' 
			Me.label6.AutoSize = True
			Me.label6.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))))
			Me.label6.Location = New System.Drawing.Point(133, 32)
			Me.label6.Name = "label6"
			Me.label6.Size = New System.Drawing.Size(91, 15)
			Me.label6.TabIndex = 10
			Me.label6.Text = "Office2010Black"
			' 
			' label5
			' 
			Me.label5.AutoSize = True
			Me.label5.ForeColor = System.Drawing.Color.DimGray
			Me.label5.Location = New System.Drawing.Point(23, 32)
			Me.label5.Name = "label5"
			Me.label5.Size = New System.Drawing.Size(101, 15)
			Me.label5.TabIndex = 9
			Me.label5.Text = "Active Style          :"
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.ForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))), (CInt(Fix((CByte(64))))))
			Me.label4.Location = New System.Drawing.Point(132, 56)
			Me.label4.Name = "label4"
			Me.label4.Size = New System.Drawing.Size(91, 15)
			Me.label4.TabIndex = 8
			Me.label4.Text = "Office2010Black"
			' 
			' label3
			' 
			Me.label3.AutoSize = True
			Me.label3.ForeColor = System.Drawing.Color.DimGray
			Me.label3.Location = New System.Drawing.Point(23, 56)
			Me.label3.Name = "label3"
			Me.label3.Size = New System.Drawing.Size(100, 15)
			Me.label3.TabIndex = 7
			Me.label3.Text = "Active Scrollbars :"
			' 
			' toolTip1
			' 
			Me.toolTip1.IsBalloon = True
			' 
			' label8
			' 
			Me.label8.AutoSize = True
			Me.label8.Font = New System.Drawing.Font("Segoe UI", 8.25F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle)), System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label8.Location = New System.Drawing.Point(669, 382)
			Me.label8.Name = "label8"
			Me.label8.Size = New System.Drawing.Size(214, 13)
			Me.label8.TabIndex = 18
			Me.label8.Text = """Grid.Model.EnableLegacyStyle = false"""
			' 
			' label7
			' 
			Me.label7.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label7.Location = New System.Drawing.Point(642, 282)
			Me.label7.Name = "label7"
			Me.label7.Size = New System.Drawing.Size(261, 90)
			Me.label7.TabIndex = 17
			Me.label7.Text = Constants.vbCrLf & "The existing ColorStyles property is marked as deprecated, " & Constants.vbCrLf & Constants.vbCrLf & "So the colorsche" & "me used by ColorStyles will be applied to the Grid just by disabling its LegacyS" & "tyles."
			' 
			' label2
			' 
			Me.label2.Font = New System.Drawing.Font("Segoe UI", 8.25F, (CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle)), System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.Location = New System.Drawing.Point(642, 241)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(261, 32)
			Me.label2.TabIndex = 16
			Me.label2.Text = "This sample features the GridControl with the new colorscheme used for the ColorS" & "tyles. "
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(934, 579)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.groupBox1)
			Me.DropShadow = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.Text = "VisualStyle Demo"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupBox1.ResumeLayout(False)
			Me.groupBox1.PerformLayout()
			Me.groupBox3.ResumeLayout(False)
			Me.groupBox2.ResumeLayout(False)
			Me.groupBox2.PerformLayout()
			Me.ResumeLayout(False)

		End Sub



		#End Region

		Private WithEvents gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		Private groupBox1 As System.Windows.Forms.GroupBox
		Private groupBox2 As System.Windows.Forms.GroupBox
		Private label6 As System.Windows.Forms.Label
		Private label5 As System.Windows.Forms.Label
		Private label4 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private WithEvents pictureBox7 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox6 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox5 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox4 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox3 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
		Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
		Private panel2 As System.Windows.Forms.Panel
		Private groupBox3 As System.Windows.Forms.GroupBox
		Private panel1 As System.Windows.Forms.Panel
		Private label1 As System.Windows.Forms.Label
		Private toolTip1 As System.Windows.Forms.ToolTip
		Private label8 As System.Windows.Forms.Label
		Private label7 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
	End Class
End Namespace