Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO
Imports System.Collections.Generic
Imports Syncfusion.GridHelperClasses

Namespace SelectionModes
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		#Region "Private Members"
		Private gradientPanel2 As Syncfusion.Windows.Forms.Tools.GradientPanel
		Private radioButton1 As System.Windows.Forms.RadioButton
		Private radioButton2 As System.Windows.Forms.RadioButton
		Private radioButton3 As System.Windows.Forms.RadioButton
        Private dataSet11 As SelectionModes.DataSet1
		Private gridControl1 As Syncfusion.Windows.Forms.Grid.GridControl
		#End Region
		Private gridControl2 As GridControl
		Private groupBox2 As GroupBox
		Private WithEvents button1 As Syncfusion.Windows.Forms.ButtonAdv
		Private ShowHeaderFooter As Syncfusion.Windows.Forms.Tools.CheckBoxAdv
		Private WithEvents buttonAdv1 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents RadCustomizePrintPage As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private WithEvents radMultiGridPrint As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private radScaleColumnToFit As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private RadPrintGridInNewPage As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private RadDefaultGridPrint As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private RadMultgrdpnt As Syncfusion.Windows.Forms.Tools.RadioButtonAdv
		Private label1 As Label
		Private numericUpDownExt1 As Syncfusion.Windows.Forms.Tools.NumericUpDownExt
		Private TypeOfPrintings As GroupBox
		Private components As IContainer

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

'			#Region "Data Initialization"
			Dim commandstring As String = "select * from Customers"
			Dim connection As String = "Data Source=" & FindFile("NorthwindwithImage.sdf")
			Dim da As New SqlCeDataAdapter(commandstring, connection)
			Try
			   da.Fill(dataSet11, "Customers")
			Catch ex As SqlException
				ShowErrorMessage(ex)
			End Try
'			#End Region

'			#Region "GridStyle settings"
			Me.gridControl1.RowCount=Me.dataSet11.Customers.Rows.Count
			Me.gridControl1.ColCount=Me.dataSet11.Customers.Columns.Count

			Me.gridControl1.PopulateValues(GridRangeInfo.Cells(1,1,gridControl1.RowCount,gridControl1.ColCount),dataSet11.Customers)
			Me.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cols(1,gridControl1.ColCount))
			Me.gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Cols(1,gridControl1.RowCount))

			Me.gridControl1.BackColor=Color.White

			Me.gridControl1.AlphaBlendSelectionColor=Color.CornflowerBlue
			Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
'			#End Region

			Try
				Dim ico As New System.Drawing.Icon(GetIconFile1("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

			InitializeGrid()
            Me.radMultiGridPrint.Checked = True
            Me.RadMultgrdpnt.Checked = True
            Me.numericUpDownExt1.Hide()
            Me.label1.Hide()
            Me.RadCustomizePrintPage.Hide()
		End Sub
		#Region "Form Handlers"
		Private Function FindFile(ByVal connstring As String) As String
            connstring = "common\data\" & connstring 'common\data
			For n As Integer = 0 To 9
				If System.IO.File.Exists(connstring) Then
					Return New FileInfo(connstring).FullName
				End If
				connstring = "..\" & connstring
			Next n

			Return connstring
		End Function

		Private Function GetIconFile1(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function


		Private Shared Sub ShowErrorMessage(ByVal ex As SqlException)
			If ex.Number = 11001 Then
				MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
			If ex.Number = 208 Then
				MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
			If ex.Number = 156 OrElse ex.Number = 102 Then
				MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If

		End Sub

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

		Private Sub CheckAll(ByVal b As Boolean)
		End Sub



		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim GridRangeStyle1 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle2 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle3 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle4 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle5 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle6 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle7 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle8 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle9 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle10 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle11 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridBaseStyle1 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle2 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle3 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridBaseStyle4 As Syncfusion.Windows.Forms.Grid.GridBaseStyle = New Syncfusion.Windows.Forms.Grid.GridBaseStyle
            Dim GridRangeStyle12 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle13 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle14 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle15 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle16 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle17 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle18 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle19 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle20 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle21 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle22 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle23 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Dim GridRangeStyle24 As Syncfusion.Windows.Forms.Grid.GridRangeStyle = New Syncfusion.Windows.Forms.Grid.GridRangeStyle
            Me.gradientPanel2 = New Syncfusion.Windows.Forms.Tools.GradientPanel
            Me.radioButton3 = New System.Windows.Forms.RadioButton
            Me.radioButton2 = New System.Windows.Forms.RadioButton
            Me.radioButton1 = New System.Windows.Forms.RadioButton
            Me.gridControl2 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl
            Me.dataSet11 = New SelectionModes.DataSet1
            Me.groupBox2 = New System.Windows.Forms.GroupBox
            Me.TypeOfPrintings = New System.Windows.Forms.GroupBox
            Me.radMultiGridPrint = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.RadCustomizePrintPage = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.label1 = New System.Windows.Forms.Label
            Me.numericUpDownExt1 = New Syncfusion.Windows.Forms.Tools.NumericUpDownExt
            Me.radScaleColumnToFit = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.RadPrintGridInNewPage = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.RadDefaultGridPrint = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.RadMultgrdpnt = New Syncfusion.Windows.Forms.Tools.RadioButtonAdv
            Me.buttonAdv1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.button1 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.ShowHeaderFooter = New Syncfusion.Windows.Forms.Tools.CheckBoxAdv
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox2.SuspendLayout()
            Me.TypeOfPrintings.SuspendLayout()
            CType(Me.radMultiGridPrint, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadCustomizePrintPage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.numericUpDownExt1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.radScaleColumnToFit, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadPrintGridInNewPage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadDefaultGridPrint, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.RadMultgrdpnt, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ShowHeaderFooter, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'gradientPanel2
            '
            Me.gradientPanel2.BackgroundColor = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.Maroon, System.Drawing.Color.IndianRed)
            Me.gradientPanel2.Location = New System.Drawing.Point(2, 46)
            Me.gradientPanel2.Name = "gradientPanel2"
            Me.gradientPanel2.Size = New System.Drawing.Size(0, 0)
            Me.gradientPanel2.TabIndex = 1
            '
            'radioButton3
            '
            Me.radioButton3.ForeColor = System.Drawing.Color.White
            Me.radioButton3.Location = New System.Drawing.Point(8, 88)
            Me.radioButton3.Name = "radioButton3"
            Me.radioButton3.Size = New System.Drawing.Size(104, 24)
            Me.radioButton3.TabIndex = 2
            Me.radioButton3.Text = "MultiExtended"
            '
            'radioButton2
            '
            Me.radioButton2.ForeColor = System.Drawing.Color.White
            Me.radioButton2.Location = New System.Drawing.Point(8, 56)
            Me.radioButton2.Name = "radioButton2"
            Me.radioButton2.Size = New System.Drawing.Size(104, 24)
            Me.radioButton2.TabIndex = 1
            Me.radioButton2.Text = "MultiSimple"
            '
            'radioButton1
            '
            Me.radioButton1.ForeColor = System.Drawing.Color.White
            Me.radioButton1.Location = New System.Drawing.Point(8, 24)
            Me.radioButton1.Name = "radioButton1"
            Me.radioButton1.Size = New System.Drawing.Size(104, 24)
            Me.radioButton1.TabIndex = 0
            Me.radioButton1.Text = "One"
            '
            'gridControl2
            '
            Me.gridControl2.ApplyVisualStyles = False
            Me.gridControl2.BackColor = System.Drawing.Color.White
            Me.gridControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gridControl2.DefaultRowHeight = 20
            Me.gridControl2.Font = New System.Drawing.Font("Segoe UI", 8.25!)
            Me.gridControl2.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridControl2.Location = New System.Drawing.Point(9, 12)
            Me.gridControl2.MetroScrollBars = True
            Me.gridControl2.Name = "gridControl2"
            GridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle1.StyleInfo.Font.Bold = False
            GridRangeStyle1.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle1.StyleInfo.Font.Italic = False
            GridRangeStyle1.StyleInfo.Font.Size = 8.25!
            GridRangeStyle1.StyleInfo.Font.Strikeout = False
            GridRangeStyle1.StyleInfo.Font.Underline = False
            GridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle2.StyleInfo.Font.Bold = False
            GridRangeStyle2.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle2.StyleInfo.Font.Italic = False
            GridRangeStyle2.StyleInfo.Font.Size = 8.25!
            GridRangeStyle2.StyleInfo.Font.Strikeout = False
            GridRangeStyle2.StyleInfo.Font.Underline = False
            GridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle3.StyleInfo.Font.Bold = False
            GridRangeStyle3.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle3.StyleInfo.Font.Italic = False
            GridRangeStyle3.StyleInfo.Font.Size = 8.25!
            GridRangeStyle3.StyleInfo.Font.Strikeout = False
            GridRangeStyle3.StyleInfo.Font.Underline = False
            GridRangeStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle4.StyleInfo.Font.Bold = False
            GridRangeStyle4.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle4.StyleInfo.Font.Italic = False
            GridRangeStyle4.StyleInfo.Font.Size = 8.25!
            GridRangeStyle4.StyleInfo.Font.Strikeout = False
            GridRangeStyle4.StyleInfo.Font.Underline = False
            GridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle5.StyleInfo.Font.Bold = False
            GridRangeStyle5.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle5.StyleInfo.Font.Italic = False
            GridRangeStyle5.StyleInfo.Font.Size = 8.25!
            GridRangeStyle5.StyleInfo.Font.Strikeout = False
            GridRangeStyle5.StyleInfo.Font.Underline = False
            GridRangeStyle5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle6.StyleInfo.Font.Bold = False
            GridRangeStyle6.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle6.StyleInfo.Font.Italic = False
            GridRangeStyle6.StyleInfo.Font.Size = 8.25!
            GridRangeStyle6.StyleInfo.Font.Strikeout = False
            GridRangeStyle6.StyleInfo.Font.Underline = False
            GridRangeStyle6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle7.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle7.StyleInfo.Font.Bold = False
            GridRangeStyle7.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle7.StyleInfo.Font.Italic = False
            GridRangeStyle7.StyleInfo.Font.Size = 8.25!
            GridRangeStyle7.StyleInfo.Font.Strikeout = False
            GridRangeStyle7.StyleInfo.Font.Underline = False
            GridRangeStyle7.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle8.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle8.StyleInfo.Font.Bold = False
            GridRangeStyle8.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle8.StyleInfo.Font.Italic = False
            GridRangeStyle8.StyleInfo.Font.Size = 8.25!
            GridRangeStyle8.StyleInfo.Font.Strikeout = False
            GridRangeStyle8.StyleInfo.Font.Underline = False
            GridRangeStyle8.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle9.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle9.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle9.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle9.StyleInfo.Font.Bold = False
            GridRangeStyle9.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle9.StyleInfo.Font.Italic = False
            GridRangeStyle9.StyleInfo.Font.Size = 8.25!
            GridRangeStyle9.StyleInfo.Font.Strikeout = False
            GridRangeStyle9.StyleInfo.Font.Underline = False
            GridRangeStyle9.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle9.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle9.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle10.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle10.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle10.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle10.StyleInfo.Font.Bold = False
            GridRangeStyle10.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle10.StyleInfo.Font.Italic = False
            GridRangeStyle10.StyleInfo.Font.Size = 8.25!
            GridRangeStyle10.StyleInfo.Font.Strikeout = False
            GridRangeStyle10.StyleInfo.Font.Underline = False
            GridRangeStyle10.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle10.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle10.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle11.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle11.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle11.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle11.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle11.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle11.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            Me.gridControl2.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle1, GridRangeStyle2, GridRangeStyle3, GridRangeStyle4, GridRangeStyle5, GridRangeStyle6, GridRangeStyle7, GridRangeStyle8, GridRangeStyle9, GridRangeStyle10, GridRangeStyle11})
            Me.gridControl2.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridControl2.Size = New System.Drawing.Size(493, 347)
            Me.gridControl2.SmartSizeBox = False
            Me.gridControl2.TabIndex = 4
            Me.gridControl2.Text = "gridControl2"
            Me.gridControl2.UseRightToLeftCompatibleTextBox = True
            '
            'gridControl1
            '
            Me.gridControl1.AllowSelection = CType(((((((Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Row Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Table) _
                        Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Cell) _
                        Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Multiple) _
                        Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Shift) _
                        Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Keyboard) _
                        Or Syncfusion.Windows.Forms.Grid.GridSelectionFlags.AlphaBlend), Syncfusion.Windows.Forms.Grid.GridSelectionFlags)
            Me.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.gridControl1.ApplyVisualStyles = False
            Me.gridControl1.BackColor = System.Drawing.Color.White
            GridBaseStyle1.Name = "Row Header"
            GridBaseStyle1.StyleInfo.BaseStyle = "Header"
            GridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
            GridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle2.Name = "Column Header"
            GridBaseStyle2.StyleInfo.BaseStyle = "Header"
            GridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
            GridBaseStyle3.Name = "Standard"
            GridBaseStyle3.StyleInfo.Font.Facename = "Tahoma"
            GridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
            GridBaseStyle4.Name = "Header"
            GridBaseStyle4.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
            GridBaseStyle4.StyleInfo.CellType = "Header"
            GridBaseStyle4.StyleInfo.Font.Bold = True
            GridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(184, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(216, Byte), Integer)))
            GridBaseStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
            Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() {GridBaseStyle1, GridBaseStyle2, GridBaseStyle3, GridBaseStyle4})
            Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.gridControl1.ColCount = 5
            Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() {New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35), New Syncfusion.Windows.Forms.Grid.GridColWidth(1, 126), New Syncfusion.Windows.Forms.Grid.GridColWidth(2, 127), New Syncfusion.Windows.Forms.Grid.GridColWidth(3, 113), New Syncfusion.Windows.Forms.Grid.GridColWidth(4, 109), New Syncfusion.Windows.Forms.Grid.GridColWidth(5, 139)})
            Me.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid
            Me.gridControl1.DefaultRowHeight = 20
            Me.gridControl1.Font = New System.Drawing.Font("Segoe UI", 8.5!)
            Me.gridControl1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro
            Me.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
            Me.gridControl1.Location = New System.Drawing.Point(516, 12)
            Me.gridControl1.MetroScrollBars = True
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.NumberedColHeaders = False
            Me.gridControl1.NumberedRowHeaders = False
            Me.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
            Me.gridControl1.Properties.MarkColHeader = False
            Me.gridControl1.Properties.MarkRowHeader = False
            GridRangeStyle12.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle12.StyleInfo.Font.Bold = False
            GridRangeStyle12.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle12.StyleInfo.Font.Italic = False
            GridRangeStyle12.StyleInfo.Font.Size = 8.5!
            GridRangeStyle12.StyleInfo.Font.Strikeout = False
            GridRangeStyle12.StyleInfo.Font.Underline = False
            GridRangeStyle12.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle13.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle13.StyleInfo.Font.Bold = False
            GridRangeStyle13.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle13.StyleInfo.Font.Italic = False
            GridRangeStyle13.StyleInfo.Font.Size = 8.5!
            GridRangeStyle13.StyleInfo.Font.Strikeout = False
            GridRangeStyle13.StyleInfo.Font.Underline = False
            GridRangeStyle13.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle14.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle14.StyleInfo.Font.Bold = False
            GridRangeStyle14.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle14.StyleInfo.Font.Italic = False
            GridRangeStyle14.StyleInfo.Font.Size = 8.5!
            GridRangeStyle14.StyleInfo.Font.Strikeout = False
            GridRangeStyle14.StyleInfo.Font.Underline = False
            GridRangeStyle14.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle15.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle15.StyleInfo.Font.Bold = False
            GridRangeStyle15.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle15.StyleInfo.Font.Italic = False
            GridRangeStyle15.StyleInfo.Font.Size = 8.5!
            GridRangeStyle15.StyleInfo.Font.Strikeout = False
            GridRangeStyle15.StyleInfo.Font.Underline = False
            GridRangeStyle15.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle16.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle16.StyleInfo.Font.Bold = False
            GridRangeStyle16.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle16.StyleInfo.Font.Italic = False
            GridRangeStyle16.StyleInfo.Font.Size = 8.5!
            GridRangeStyle16.StyleInfo.Font.Strikeout = False
            GridRangeStyle16.StyleInfo.Font.Underline = False
            GridRangeStyle16.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle17.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle17.StyleInfo.Font.Bold = False
            GridRangeStyle17.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle17.StyleInfo.Font.Italic = False
            GridRangeStyle17.StyleInfo.Font.Size = 8.5!
            GridRangeStyle17.StyleInfo.Font.Strikeout = False
            GridRangeStyle17.StyleInfo.Font.Underline = False
            GridRangeStyle17.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle18.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle18.StyleInfo.Font.Bold = False
            GridRangeStyle18.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle18.StyleInfo.Font.Italic = False
            GridRangeStyle18.StyleInfo.Font.Size = 8.5!
            GridRangeStyle18.StyleInfo.Font.Strikeout = False
            GridRangeStyle18.StyleInfo.Font.Underline = False
            GridRangeStyle18.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle19.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table
            GridRangeStyle19.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle19.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer)), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin)
            GridRangeStyle19.StyleInfo.Font.Bold = False
            GridRangeStyle19.StyleInfo.Font.Facename = "Segoe UI"
            GridRangeStyle19.StyleInfo.Font.Italic = False
            GridRangeStyle19.StyleInfo.Font.Size = 8.5!
            GridRangeStyle19.StyleInfo.Font.Strikeout = False
            GridRangeStyle19.StyleInfo.Font.Underline = False
            GridRangeStyle19.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point
            GridRangeStyle19.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White)
            GridRangeStyle19.StyleInfo.TextColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
            GridRangeStyle20.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 1)
            GridRangeStyle20.StyleInfo.Text = "Contact Name"
            GridRangeStyle21.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 2)
            GridRangeStyle21.StyleInfo.Text = "CompanyName"
            GridRangeStyle22.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 3)
            GridRangeStyle22.StyleInfo.Text = "Address"
            GridRangeStyle23.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 4)
            GridRangeStyle23.StyleInfo.Text = "City"
            GridRangeStyle24.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 5)
            GridRangeStyle24.StyleInfo.Text = "Country"
            Me.gridControl1.RangeStyles.AddRange(New Syncfusion.Windows.Forms.Grid.GridRangeStyle() {GridRangeStyle12, GridRangeStyle13, GridRangeStyle14, GridRangeStyle15, GridRangeStyle16, GridRangeStyle17, GridRangeStyle18, GridRangeStyle19, GridRangeStyle20, GridRangeStyle21, GridRangeStyle22, GridRangeStyle23, GridRangeStyle24})
            Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() {New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
            Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode
            Me.gridControl1.Size = New System.Drawing.Size(404, 347)
            Me.gridControl1.SmartSizeBox = False
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ThemesEnabled = True
            '
            'dataSet11
            '
            Me.dataSet11.DataSetName = "DataSet1"
            Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'groupBox2
            '
            Me.groupBox2.BackColor = System.Drawing.Color.White
            Me.groupBox2.Controls.Add(Me.TypeOfPrintings)
            Me.groupBox2.Controls.Add(Me.label1)
            Me.groupBox2.Controls.Add(Me.numericUpDownExt1)
            Me.groupBox2.Controls.Add(Me.radScaleColumnToFit)
            Me.groupBox2.Controls.Add(Me.RadPrintGridInNewPage)
            Me.groupBox2.Controls.Add(Me.RadDefaultGridPrint)
            Me.groupBox2.Controls.Add(Me.RadMultgrdpnt)
            Me.groupBox2.Controls.Add(Me.buttonAdv1)
            Me.groupBox2.Controls.Add(Me.button1)
            Me.groupBox2.Controls.Add(Me.ShowHeaderFooter)
            Me.groupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox2.ForeColor = System.Drawing.Color.DimGray
            Me.groupBox2.Location = New System.Drawing.Point(9, 363)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(911, 75)
            Me.groupBox2.TabIndex = 5
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Grid Printing Options"
            '
            'TypeOfPrintings
            '
            Me.TypeOfPrintings.Controls.Add(Me.radMultiGridPrint)
            Me.TypeOfPrintings.Controls.Add(Me.RadCustomizePrintPage)
            Me.TypeOfPrintings.ForeColor = System.Drawing.Color.DimGray
            Me.TypeOfPrintings.Location = New System.Drawing.Point(729, 0)
            Me.TypeOfPrintings.Name = "TypeOfPrintings"
            Me.TypeOfPrintings.Size = New System.Drawing.Size(182, 75)
            Me.TypeOfPrintings.TabIndex = 12
            Me.TypeOfPrintings.TabStop = False
            Me.TypeOfPrintings.Text = "TypeOfPrinting"
            '
            'radMultiGridPrint
            '
            Me.radMultiGridPrint.BackColor = System.Drawing.Color.White
            Me.radMultiGridPrint.DrawFocusRectangle = False
            Me.radMultiGridPrint.ForeColor = System.Drawing.Color.DimGray
            Me.radMultiGridPrint.Location = New System.Drawing.Point(20, 19)
            Me.radMultiGridPrint.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.radMultiGridPrint.Name = "radMultiGridPrint"
            Me.radMultiGridPrint.Size = New System.Drawing.Size(144, 21)
            Me.radMultiGridPrint.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radMultiGridPrint.TabIndex = 8
            Me.radMultiGridPrint.Text = "MultiGridPrint"
            Me.radMultiGridPrint.ThemesEnabled = False
            '
            'RadCustomizePrintPage
            '
            Me.RadCustomizePrintPage.BackColor = System.Drawing.Color.White
            Me.RadCustomizePrintPage.DrawFocusRectangle = False
            Me.RadCustomizePrintPage.ForeColor = System.Drawing.Color.DimGray
            Me.RadCustomizePrintPage.Location = New System.Drawing.Point(20, 41)
            Me.RadCustomizePrintPage.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.RadCustomizePrintPage.Name = "RadCustomizePrintPage"
            Me.RadCustomizePrintPage.Size = New System.Drawing.Size(144, 21)
            Me.RadCustomizePrintPage.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.RadCustomizePrintPage.TabIndex = 9
            Me.RadCustomizePrintPage.Text = "CustomizePrintPage"
            Me.RadCustomizePrintPage.ThemesEnabled = False
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.ForeColor = System.Drawing.Color.DimGray
            Me.label1.Location = New System.Drawing.Point(81, 35)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(97, 15)
            Me.label1.TabIndex = 11
            Me.label1.Text = "NoOfPagesToFit"
            '
            'numericUpDownExt1
            '
            Me.numericUpDownExt1.BackColor = System.Drawing.Color.White
            Me.numericUpDownExt1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.numericUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.numericUpDownExt1.Location = New System.Drawing.Point(184, 35)
            Me.numericUpDownExt1.MetroColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(218, Byte), Integer))
            Me.numericUpDownExt1.Name = "numericUpDownExt1"
            Me.numericUpDownExt1.Size = New System.Drawing.Size(76, 23)
            Me.numericUpDownExt1.TabIndex = 10
            Me.numericUpDownExt1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro
            '
            'radScaleColumnToFit
            '
            Me.radScaleColumnToFit.BackColor = System.Drawing.Color.White
            Me.radScaleColumnToFit.DrawFocusRectangle = False
            Me.radScaleColumnToFit.ForeColor = System.Drawing.Color.DimGray
            Me.radScaleColumnToFit.Location = New System.Drawing.Point(149, 46)
            Me.radScaleColumnToFit.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.radScaleColumnToFit.Name = "radScaleColumnToFit"
            Me.radScaleColumnToFit.Size = New System.Drawing.Size(144, 21)
            Me.radScaleColumnToFit.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.radScaleColumnToFit.TabIndex = 7
            Me.radScaleColumnToFit.Text = "ScaleColumnToFit"
            Me.radScaleColumnToFit.ThemesEnabled = False
            '
            'RadPrintGridInNewPage
            '
            Me.RadPrintGridInNewPage.BackColor = System.Drawing.Color.White
            Me.RadPrintGridInNewPage.DrawFocusRectangle = False
            Me.RadPrintGridInNewPage.ForeColor = System.Drawing.Color.DimGray
            Me.RadPrintGridInNewPage.Location = New System.Drawing.Point(149, 22)
            Me.RadPrintGridInNewPage.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.RadPrintGridInNewPage.Name = "RadPrintGridInNewPage"
            Me.RadPrintGridInNewPage.Size = New System.Drawing.Size(144, 21)
            Me.RadPrintGridInNewPage.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.RadPrintGridInNewPage.TabIndex = 6
            Me.RadPrintGridInNewPage.Text = "PrintGridInNewPage"
            Me.RadPrintGridInNewPage.ThemesEnabled = False
            '
            'RadDefaultGridPrint
            '
            Me.RadDefaultGridPrint.BackColor = System.Drawing.Color.White
            Me.RadDefaultGridPrint.DrawFocusRectangle = False
            Me.RadDefaultGridPrint.ForeColor = System.Drawing.Color.DimGray
            Me.RadDefaultGridPrint.Location = New System.Drawing.Point(22, 46)
            Me.RadDefaultGridPrint.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.RadDefaultGridPrint.Name = "RadDefaultGridPrint"
            Me.RadDefaultGridPrint.Size = New System.Drawing.Size(121, 21)
            Me.RadDefaultGridPrint.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.RadDefaultGridPrint.TabIndex = 5
            Me.RadDefaultGridPrint.Text = "DefaultGridPrint"
            Me.RadDefaultGridPrint.ThemesEnabled = False
            '
            'RadMultgrdpnt
            '
            Me.RadMultgrdpnt.BackColor = System.Drawing.Color.White
            Me.RadMultgrdpnt.DrawFocusRectangle = False
            Me.RadMultgrdpnt.ForeColor = System.Drawing.Color.DimGray
            Me.RadMultgrdpnt.Location = New System.Drawing.Point(22, 22)
            Me.RadMultgrdpnt.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.RadMultgrdpnt.Name = "RadMultgrdpnt"
            Me.RadMultgrdpnt.Size = New System.Drawing.Size(121, 21)
            Me.RadMultgrdpnt.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro
            Me.RadMultgrdpnt.TabIndex = 4
            Me.RadMultgrdpnt.Text = "MultiGridPrint"
            Me.RadMultgrdpnt.ThemesEnabled = False
            '
            'buttonAdv1
            '
            Me.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.buttonAdv1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.buttonAdv1.ForeColor = System.Drawing.Color.White
            Me.buttonAdv1.Location = New System.Drawing.Point(587, 44)
            Me.buttonAdv1.Name = "buttonAdv1"
            Me.buttonAdv1.Size = New System.Drawing.Size(136, 23)
            Me.buttonAdv1.TabIndex = 3
            Me.buttonAdv1.Text = "Print"
            Me.buttonAdv1.UseVisualStyle = True
            Me.buttonAdv1.UseVisualStyleBackColor = True
            '
            'button1
            '
            Me.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro
            Me.button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(0, Byte), Integer))
            Me.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner
            Me.button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button1.ForeColor = System.Drawing.Color.White
            Me.button1.Location = New System.Drawing.Point(407, 44)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(136, 23)
            Me.button1.TabIndex = 2
            Me.button1.Text = "Print Preview"
            Me.button1.UseVisualStyle = True
            Me.button1.UseVisualStyleBackColor = True
            '
            'ShowHeaderFooter
            '
            Me.ShowHeaderFooter.BackColor = System.Drawing.Color.White
            Me.ShowHeaderFooter.DrawFocusRectangle = False
            Me.ShowHeaderFooter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ShowHeaderFooter.ForeColor = System.Drawing.Color.Black
            Me.ShowHeaderFooter.Location = New System.Drawing.Point(407, 21)
            Me.ShowHeaderFooter.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ShowHeaderFooter.Name = "ShowHeaderFooter"
            Me.ShowHeaderFooter.Size = New System.Drawing.Size(167, 19)
            Me.ShowHeaderFooter.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro
            Me.ShowHeaderFooter.TabIndex = 0
            Me.ShowHeaderFooter.Text = "Show Header and Footer"
            Me.ShowHeaderFooter.ThemesEnabled = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.BorderColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.BorderThickness = 2
            Me.CaptionForeColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(932, 446)
            Me.Controls.Add(Me.gridControl2)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.groupBox2)
            Me.DropShadow = True
            Me.ForeColor = System.Drawing.Color.White
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            Me.MetroColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Multi-Grid Printing"
            CType(Me.gradientPanel2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.TypeOfPrintings.ResumeLayout(False)
            CType(Me.radMultiGridPrint, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadCustomizePrintPage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.numericUpDownExt1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.radScaleColumnToFit, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadPrintGridInNewPage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadDefaultGridPrint, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.RadMultgrdpnt, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ShowHeaderFooter, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		#End Region

		#Region "Helper Methods"
		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function


		Private Sub InitializeGrid()
			'Load Data
			Dim xmlName As String = GetFile("Orders.xml")

			Dim orderDataSet As New DataSet()

			If Me.ReadXml(orderDataSet, xmlName) Then
				Dim orderTable As DataTable = orderDataSet.Tables(0)
				Me.gridControl2.RowCount = 100
				Me.gridControl2.ColCount = orderTable.Columns.Count - 1

				Me.gridControl2.PopulateValues(GridRangeInfo.Cells(1, 1, Me.gridControl1.RowCount, Me.gridControl1.ColCount), orderDataSet.Tables(0))
				Me.gridControl2.PopulateHeaders(GridRangeInfo.Cells(0, 1, 0, Me.gridControl1.ColCount), orderTable)
			End If

			For col As Integer = 4 To 6
				Me.gridControl2.ColStyles(col).CellType = "MonthCalendar"
				Me.gridControl2.ColStyles(col).ShowButtons = GridShowButtons.Hide
				Me.gridControl2.ColStyles(col).CellValueType = GetType(DateTime)
				Me.gridControl2.ColStyles(col).Format = "MM/dd/yyyy"
			Next col

			'Set grid appearance
			Me.gridControl2.ColWidths.ResizeToFit(GridRangeInfo.Table())
			Me.gridControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro
			Me.gridControl2.ThemesEnabled = True
			Me.gridControl2.DefaultGridBorderStyle = GridBorderStyle.Solid
		End Sub

		Private Function GetFile(ByVal fileName As String) As String
            Dim dataFileName As String = "Common\Data\Grid\" & fileName 'Common\Data\Grid\" + fileName;
			For n As Integer = 0 To 11
				If System.IO.File.Exists(dataFileName) Then
					Return New FileInfo(dataFileName).FullName
				End If
				dataFileName = "..\" & dataFileName
			Next n
			Return dataFileName
		End Function

		Private Function ReadXml(ByVal ds As DataSet, ByVal xmlFileName As String) As Boolean
			' Check both in parent folder and Parent\Data folders.
			Dim xmlDataFileName As String = "Common\Data\" & xmlFileName
			For n As Integer = 0 To 9
				If System.IO.File.Exists(xmlFileName) Then
					ds.ReadXml(xmlFileName)
					Return True
				End If
				If System.IO.File.Exists(xmlDataFileName) Then
					ds.ReadXml(xmlDataFileName)
					Return True
				End If
				xmlFileName = "..\" & xmlFileName
				xmlDataFileName = "..\" & xmlDataFileName
			Next n

			Return False
		End Function
		#End Region

		#Region "Event Handlers"

		Private Sub pd_DrawGridPrintHeader(ByVal sender As Object, ByVal e As Syncfusion.GridHelperClasses.GridPrintHeaderFooterTemplateArgs)
			' Get the rectangle area to draw
			Dim header As Rectangle = e.DrawRectangle

			'IMAGE
			'scale the image
			Dim imageSize As New SizeF(header.Width \ 3, header.Height * 0.8f)
			'Locating the logo on the right corner of the Drawing Surface
			Dim imageLocation As New PointF(e.DrawRectangle.Width - imageSize.Width - 20, header.Y + 5)
			Dim img As New Bitmap(GetIconFile("Common\Images\Grid\PDF_logo\logo.png"))
			'Draw the image in the Header.
			e.Graphics.DrawImage(img, New RectangleF(imageLocation, imageSize))

			'TITLE
			Dim activeColor As Color = Color.FromArgb(44, 71, 120)
			Dim brush As New SolidBrush(activeColor)
			Dim font As New Font("Segoe UI", 20, FontStyle.Bold)
			'Set formattings for the text
			Dim format As New StringFormat()
			format.Alignment = StringAlignment.Near
			format.LineAlignment = StringAlignment.Near
			'Draw the title
			e.Graphics.DrawString("Customers Order Report", font, brush, New RectangleF(header.Location.X + 20, header.Location.Y + 20, e.DrawRectangle.Width, e.DrawRectangle.Height), format)

			'''BORDER LINES - Draw some lines in the header
			Dim pen As New Pen(Color.DarkBlue, 0.8f)
			e.Graphics.DrawLine(pen, New Point(header.Left, header.Top + 2), New Point(header.Right, header.Top + 2))
			e.Graphics.DrawLine(pen, New Point(header.Left, header.Top + 5), New Point(header.Right, header.Top + 5))
			e.Graphics.DrawLine(pen, New Point(header.Left, header.Bottom - 8), New Point(header.Right, header.Bottom - 8))
			e.Graphics.DrawLine(pen, New Point(header.Left, header.Bottom - 5), New Point(header.Right, header.Bottom - 5))

			'Dispose drawing resources
			font.Dispose()
			format.Dispose()
			pen.Dispose()
		End Sub

		Private Sub pd_DrawGridPrintFooter(ByVal sender As Object, ByVal e As Syncfusion.GridHelperClasses.GridPrintHeaderFooterTemplateArgs)
			'Get the rectangle area to draw
			Dim footer As Rectangle = e.DrawRectangle

			'Draw copy right
			Dim format As New StringFormat()
			format.LineAlignment = StringAlignment.Center
			format.Alignment = StringAlignment.Center
			Dim font As New Font("Segoe UI", 8)
			Dim brush As New SolidBrush(Color.Red)
			e.Graphics.DrawString("@copyright", font, brush, GridUtil.CenterPoint(footer), format)

			'Draw page number
			format.LineAlignment = StringAlignment.Far
			format.Alignment = StringAlignment.Far
			e.Graphics.DrawString(String.Format("page {0} of {1}", e.PageNumber, e.PageCount), font, brush, New Point(footer.Right - 100, footer.Bottom - 20), format)

			'Dispose resources
			format.Dispose()
			font.Dispose()
			brush.Dispose()
		End Sub

		#End Region

		Private Sub radMultiGridPrint_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radMultiGridPrint.CheckChanged
			Me.RadMultgrdpnt.Show()
			Me.radScaleColumnToFit.Show()
			Me.RadPrintGridInNewPage.Show()
			Me.RadDefaultGridPrint.Show()
			Me.numericUpDownExt1.Hide()
			Me.label1.Hide()
			Me.ShowHeaderFooter.Show()
		End Sub

		Private Sub RadCusomizePrintPage_CheckChanged(ByVal sender As Object, ByVal e As EventArgs) Handles RadCustomizePrintPage.CheckChanged
			Me.RadMultgrdpnt.Hide()
			Me.radScaleColumnToFit.Hide()
			Me.RadPrintGridInNewPage.Hide()
			Me.RadDefaultGridPrint.Hide()
			Me.numericUpDownExt1.Show()
			Me.label1.Show()
			Me.ShowHeaderFooter.Hide()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			If radMultiGridPrint.Checked Then
				Dim ctrls As New List(Of Control)()
				Dim gCtrls As New List(Of Control)()
				For Each cd As Control In Me.Controls
					If TypeOf cd Is Control Then
						gCtrls.Add(CType(cd, Control))
					End If
				Next cd
				Dim pd As New MultiGridPrintDocument(gCtrls)
				If RadMultgrdpnt.Checked Then
					pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.MultipleGridPrint
				ElseIf RadPrintGridInNewPage.Checked Then
					pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.PrintGridInNewPage
				ElseIf RadDefaultGridPrint.Checked Then
					pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.DefaultGridPrint
				ElseIf radScaleColumnToFit.Checked Then
					pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.ScaleColumnsToFit
				End If
				If ShowHeaderFooter.Checked Then
					pd.ShowHeaderFooterOnAllPages = True
				Else
					pd.ShowHeaderFooterOnAllPages = False
				End If
                'AddHandler pd.MultipleGridPrint, AddressOf pd_MultipleGridPrint
				pd.HeaderHeight = 70
				pd.FooterHeight = 50
				AddHandler pd.DrawGridPrintHeader, AddressOf pd_DrawGridPrintHeader
				AddHandler pd.DrawGridPrintFooter, AddressOf pd_DrawGridPrintFooter
				Dim printDialog As New PrintPreviewDialog()
				printDialog.Document = pd
				printDialog.ShowDialog()
			ElseIf RadCustomizePrintPage.Checked Then
				Try

					Me.gridControl1.Model.Properties.PrintFrame = False

					Dim pd As New Syncfusion.GridHelperClasses.GridPrintDocumentAdv(Me.gridControl1)
					pd.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)

					If Me.ShowHeaderFooter.Checked Then
						pd.HeaderHeight = 70
						pd.FooterHeight = 50
					Else
						pd.HeaderHeight = 0
						pd.HeaderHeight = 0
					End If
					If Me.numericUpDownExt1.Value > Me.gridControl1.Model.ColCount Then
                        pd.PagesToFit = CType(Me.numericUpDownExt1.Value, Int16)
					
					pd.ScaleColumnsToFitPage = False
					pd.PrintColumnToFitPage = True

					AddHandler pd.DrawGridPrintHeader, AddressOf pd_DrawGridPrintHeader
					AddHandler pd.DrawGridPrintFooter, AddressOf pd_DrawGridPrintFooter

					Dim previewDialog As New PrintPreviewDialog()
					previewDialog.Document = pd
                        previewDialog.Show()
                    Else
                        MessageBox.Show("Please give value greater than colcount")
                    End If
				Catch ex As Exception
					MessageBox.Show("Error while print preview" & ex.ToString())
				End Try
			End If
		End Sub

		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.Click 'print.
			If radMultiGridPrint.Checked Then
				Dim ctrls As New List(Of Control)()
				Dim gCtrls As New List(Of Control)()
				For Each cd As Control In Me.Controls
					If TypeOf cd Is Control Then
						gCtrls.Add(CType(cd, Control))
					End If
				Next cd
				Dim pd As New MultiGridPrintDocument(gCtrls)
				If RadMultgrdpnt.Checked Then
					pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.MultipleGridPrint
				ElseIf RadPrintGridInNewPage.Checked Then
					pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.PrintGridInNewPage
				ElseIf RadDefaultGridPrint.Checked Then
					pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.DefaultGridPrint
				ElseIf radScaleColumnToFit.Checked Then
					pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.ScaleColumnsToFit
				End If
				If ShowHeaderFooter.Checked Then
					pd.ShowHeaderFooterOnAllPages = True
				Else
					pd.ShowHeaderFooterOnAllPages = False
				End If
                'AddHandler pd.MultipleGridPrint, AddressOf pd_MultipleGridPrint
				pd.HeaderHeight = 70
				pd.FooterHeight = 50
				AddHandler pd.DrawGridPrintHeader, AddressOf pd_DrawGridPrintHeader
				AddHandler pd.DrawGridPrintFooter, AddressOf pd_DrawGridPrintFooter
				Dim printDialog As New PrintDialog()
				printDialog.Document = pd
				pd.DefaultPageSettings.Landscape = True
				If printDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
					pd.Print()
				End If
			ElseIf RadCustomizePrintPage.Checked Then
				Try

					Me.gridControl1.Model.Properties.PrintFrame = False

					Dim pd As New Syncfusion.GridHelperClasses.GridPrintDocumentAdv(Me.gridControl1)
					pd.DefaultPageSettings.Margins = New System.Drawing.Printing.Margins(25, 25, 25, 25)

					If Me.ShowHeaderFooter.Checked Then
						pd.HeaderHeight = 70
						pd.FooterHeight = 50
					Else
						pd.HeaderHeight = 0
						pd.HeaderHeight = 0
					End If
					If Me.numericUpDownExt1.Value > Me.gridControl1.Model.ColCount Then
                        pd.PagesToFit = CType(Me.numericUpDownExt1.Value, Int16)
					
					pd.ScaleColumnsToFitPage = False
					pd.PrintColumnToFitPage = True

					AddHandler pd.DrawGridPrintHeader, AddressOf pd_DrawGridPrintHeader
					AddHandler pd.DrawGridPrintFooter, AddressOf pd_DrawGridPrintFooter
					Dim printDialog As New PrintDialog()
					printDialog.Document = pd
					pd.DefaultPageSettings.Landscape = True
					If printDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
						pd.Print()
					End If
                    Else
                        MessageBox.Show("Please give value less than colcount")
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error while print preview" & ex.ToString())
				End Try
			End If
		End Sub
		

	End Class
End Namespace
