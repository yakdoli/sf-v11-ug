Imports Microsoft.VisualBasic
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
Imports System.Collections.Specialized
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms.Grid
Imports System.Reflection
Imports System.IO
Imports Syncfusion.Diagnostics
Imports Syncfusion.Windows.Forms

Namespace ContentCellDemo

	Public Class Form1
		Inherits MetroForm
		Private gridControl1 As GridControl
		Private components As IContainer

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

			InitializeGrid()
		End Sub

		Private Sub InitializeGrid()

'			#Region "Style prerequistes"
			Dim standard As GridStyleInfo = gridControl1.BaseStylesMap("Standard").StyleInfo
			standard.Font.Bold = False
			standard.Font.Facename = "Verdana" '"Verdana";
			standard.Font.Size = 10
			standard.TextColor = Color.FromArgb(240, 0, 21, 84)
			gridControl1.Font = New System.Drawing.Font("Verdana", 8.5F)


			' grab some images...
			Dim imageList As New ImageList()
			imageList.Images.Add(SystemIcons.Warning.ToBitmap())
			imageList.Images.Add(SystemIcons.Application.ToBitmap())
			imageList.Images.Add(SystemIcons.Asterisk.ToBitmap())
			imageList.Images.Add(SystemIcons.Error.ToBitmap())
			imageList.Images.Add(SystemIcons.Exclamation.ToBitmap())
			imageList.Images.Add(SystemIcons.Hand.ToBitmap())
			imageList.Images.Add(SystemIcons.Information.ToBitmap())
			imageList.Images.Add(SystemIcons.Question.ToBitmap())
			'standard.ImageList = imageList;

			Dim icon As New Icon(Me.GetType().Module.Assembly.GetManifestResourceStream("gridform.ico"))
			imageList.Images.Add(icon.ToBitmap())

			icon = New Icon(Me.GetType().Module.Assembly.GetManifestResourceStream("toolsform.ico"))
			imageList.Images.Add(icon.ToBitmap())
			standard.ImageList = imageList

'			#End Region

'			#Region "Codes to apply celltypes in Grid"
			Me.gridControl1.BeginUpdate()

'			#Region "Style declaration"
			Dim headerstyle As New GridStyleInfo()
			headerstyle.Font.Size = 12
			headerstyle.Font.Bold = True
			headerstyle.VerticalAlignment = GridVerticalAlignment.Middle
			headerstyle.HorizontalAlignment = GridHorizontalAlignment.Center
			headerstyle.CellType = GridCellTypeName.Static

			Dim subheaderstyle As New GridStyleInfo()
			subheaderstyle.Font.Bold = True
			subheaderstyle.VerticalAlignment = GridVerticalAlignment.Middle
			subheaderstyle.HorizontalAlignment = GridHorizontalAlignment.Center
			subheaderstyle.CellType = GridCellTypeName.Static

			gridControl1.Model.ColWidths(4) = 90
			gridControl1.Model.ColWidths(6) = 100
'			#End Region

'			#Region "Static Cells"
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(1, 1, 2, gridControl1.ColCount))
			gridControl1(1, 1) = headerstyle
			gridControl1(1, 1).Text = "Static Cells"

			Dim rowIndex As Integer = 3, colIndex As Integer = 4
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = subheaderstyle
			gridControl1(rowIndex, 1).Text = "Static Cells - cannot be edited which represented as a read-only cell"
			rowIndex += 1
			gridControl1(rowIndex, colIndex).Text = "Static cell"
			gridControl1(rowIndex, colIndex).CellType = GridCellTypeName.Static
			gridControl1(rowIndex, colIndex + 2).Text = "Static cell"
			gridControl1(rowIndex, colIndex + 2).CellType = GridCellTypeName.Static
			gridControl1(rowIndex, colIndex + 2).ImageIndex = 8
'			#End Region

'			#Region "ImageCells with PictureBox"
			rowIndex = 7
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Image Cells"

			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(9, 2, 13, 4))
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(9, 6, 13, 8))

'			#Region "Register CellModel"
#If HELPERCLASS Then
			RegisterCellModel.GridCellType(gridControl1, CustomCellTypes.PictureBox)
			Dim tsp As New Syncfusion.GridHelperClasses.PictureBoxStyleProperties(New GridStyleInfo(gridControl1.TableStyle))
			tsp.SizeMode = PictureBoxSizeMode.AutoSize
			Dim sp As Syncfusion.GridHelperClasses.PictureBoxStyleProperties
#Else
			gridControl1.CellModels.Add("PictureBox", New PictureBoxCellModel(gridControl1.Model))
			Dim tsp As New PictureBoxStyleProperties(New GridStyleInfo(gridControl1.TableStyle))
			tsp.SizeMode = PictureBoxSizeMode.AutoSize
			Dim sp As PictureBoxStyleProperties
#End If
'			#End Region

'			#Region "ApplyImages"
			Dim style As GridStyleInfo
			style = gridControl1(9, 2)
			style.CellType = "PictureBox"
#If HELPERCLASS Then
			sp = New Syncfusion.GridHelperClasses.PictureBoxStyleProperties(style)
#Else
			sp = New PictureBoxStyleProperties(style)
#End If
			sp.Image = Image.FromFile("..\..\Resources\Car1.jpg")
			sp.SizeMode = PictureBoxSizeMode.StretchImage

			style = gridControl1(9, 6)
			style.CellType = "PictureBox"


#If HELPERCLASS Then
			sp = New Syncfusion.GridHelperClasses.PictureBoxStyleProperties(style)
#Else
			sp = New PictureBoxStyleProperties(style)
#End If
			sp.Image = Image.FromFile("..\..\Resources\car2.jpg")
			sp.SizeMode = PictureBoxSizeMode.StretchImage

'			#End Region

'			#End Region

'			#Region "HeaderCells"
			rowIndex = 14
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, 15, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = headerstyle
			gridControl1(rowIndex, 1).Text = "Header Cells"

			rowIndex = 16
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = subheaderstyle
			gridControl1(rowIndex, 1).Text = "Header Cells - Used as Column Header and RowHeader cells"
			rowIndex += 1
			rowIndex += 1
			gridControl1(rowIndex, colIndex).Text = "Header Text"
			gridControl1(rowIndex, colIndex).CellType = GridCellTypeName.Header
			gridControl1(rowIndex, colIndex + 2).Text = "Header Text"
			gridControl1(rowIndex, colIndex + 2).CellType = GridCellTypeName.Header
'			#End Region

'			#Region "ProgressBar Cells"

			rowIndex = 21
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount))
			gridControl1(rowIndex, 1) = subheaderstyle
			gridControl1(rowIndex, 1).Font.Size = 10
			gridControl1(rowIndex, 1).CellType = GridCellTypeName.CheckBox
			gridControl1(rowIndex, 1).Description = "ProgressBar Cells"


			rowIndex = 24
			Dim style1 As GridStyleInfo = gridControl1(rowIndex, 2)
			Dim progressBarEx1 As GridProgressBarInfo = style1.ProgressBar
			style1.CellType = "ProgressBar"
			style1.Themed = False
			style1.BackColor = System.Drawing.SystemColors.Control
			style1.CellAppearance = GridCellAppearance.Raised

			progressBarEx1.BackGradientEndColor = System.Drawing.SystemColors.ControlLightLight
			progressBarEx1.BackGradientStartColor = System.Drawing.SystemColors.ControlDark
			progressBarEx1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient
			progressBarEx1.BackMultipleColors = New System.Drawing.Color() { System.Drawing.SystemColors.ControlDark, System.Drawing.SystemColors.ControlLightLight, System.Drawing.SystemColors.Control}
			progressBarEx1.BackSegments = False
			progressBarEx1.BackTubeEndColor = System.Drawing.SystemColors.ControlLightLight
			progressBarEx1.BackTubeStartColor = System.Drawing.SystemColors.ControlDark
			'progressBarEx1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
			'progressBarEx1.BorderColor = System.Drawing.Color.Black;
			progressBarEx1.FontColor = System.Drawing.SystemColors.HighlightText
			progressBarEx1.ForeColor = System.Drawing.Color.MediumBlue
			progressBarEx1.ForegroundImage = Nothing
			progressBarEx1.GradientEndColor = System.Drawing.Color.Lime
			progressBarEx1.GradientStartColor = System.Drawing.Color.Red
			progressBarEx1.MultipleColors = New System.Drawing.Color() { System.Drawing.Color.DarkRed, System.Drawing.Color.Red, System.Drawing.Color.Black}
			progressBarEx1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube
			progressBarEx1.SegmentWidth = 20
			progressBarEx1.StretchImage = False
			progressBarEx1.StretchMultGrad = False
			progressBarEx1.TextShadow = False
			progressBarEx1.TubeEndColor = System.Drawing.SystemColors.Control
			progressBarEx1.TubeStartColor = System.Drawing.SystemColors.ControlDark
			progressBarEx1.ProgressValue = 79

			gridControl1.RowHeights(rowIndex) = 23
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 2, rowIndex, 6))


			Dim rowIndex1 As Integer = rowIndex
			Dim colIndex1 As Integer = 2
			gridControl1.ColWidths(8) = 23


			' Vertical
			rowIndex += 2

			Dim stylev3 As GridStyleInfo = gridControl1(rowIndex, 8)
			Dim progressBarExv3 As GridProgressBarInfo = stylev3.ProgressBar
			stylev3.CellType = "ProgressBar"
			stylev3.Themed = False

			progressBarExv3.ProgressOrientation = Orientation.Vertical
			progressBarExv3.BackGradientEndColor = System.Drawing.Color.White
			progressBarExv3.BackGradientStartColor = System.Drawing.Color.LightGray
			progressBarExv3.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.System
			progressBarExv3.BackSegments = False
			progressBarExv3.BackTubeEndColor = System.Drawing.Color.White
			progressBarExv3.BackTubeStartColor = System.Drawing.Color.LightGray
			progressBarExv3.FontColor = System.Drawing.Color.White
			progressBarExv3.ForegroundImage = Nothing
			progressBarExv3.GradientEndColor = System.Drawing.Color.Lime
			progressBarExv3.GradientStartColor = System.Drawing.Color.Red
			progressBarExv3.MultipleColors = New System.Drawing.Color(){}
			progressBarExv3.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.System
			progressBarExv3.SegmentWidth = 12
			progressBarExv3.TubeEndColor = System.Drawing.Color.Black
			progressBarExv3.TubeStartColor = System.Drawing.Color.Red
			progressBarExv3.ProgressValue = 75

			gridControl1.RowHeights(rowIndex) = 23
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 8, rowIndex + 8, 8))




			' Horizontal
			Dim style3 As GridStyleInfo = gridControl1(rowIndex, colIndex1)
			Dim progressBarEx3 As GridProgressBarInfo = style3.ProgressBar
			style3.CellType = "ProgressBar"
			style3.Themed = False

			progressBarEx3.BackGradientEndColor = System.Drawing.Color.RosyBrown
			progressBarEx3.BackGradientStartColor = System.Drawing.Color.DarkRed
			progressBarEx3.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient
			progressBarEx3.BackMultipleColors = New System.Drawing.Color(){}
			progressBarEx3.BackSegments = False
			progressBarEx3.BackTubeEndColor = System.Drawing.SystemColors.Control
			progressBarEx3.BackTubeStartColor = System.Drawing.Color.LightGray
			progressBarEx3.FontColor = System.Drawing.Color.Lime
			progressBarEx3.ForegroundImage = Nothing
			progressBarEx3.GradientEndColor = System.Drawing.Color.Lime
			progressBarEx3.GradientStartColor = System.Drawing.Color.Red
			progressBarEx3.MultipleColors = New System.Drawing.Color() { System.Drawing.SystemColors.ControlDarkDark, System.Drawing.SystemColors.ControlLight, System.Drawing.SystemColors.ControlDark, System.Drawing.SystemColors.Control}
			progressBarEx3.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube
			progressBarEx3.TextVisible = False
			progressBarEx3.TubeEndColor = System.Drawing.Color.Black
			progressBarEx3.TubeStartColor = System.Drawing.Color.Red
			progressBarEx3.ProgressValue = 75

			gridControl1.RowHeights(rowIndex) = 23
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 2, rowIndex, 6))



			' Horizontal
			rowIndex += 2

			Dim style4 As GridStyleInfo = gridControl1(rowIndex, colIndex1)
			Dim progressBarEx4 As GridProgressBarInfo = style4.ProgressBar
			style4.CellType = "ProgressBar"
			style4.Themed = False

			' 
			' progressBarEx4
			' 
			progressBarEx4.BackGradientEndColor = System.Drawing.Color.White
			progressBarEx4.BackGradientStartColor = System.Drawing.Color.LightGray
			progressBarEx4.ForegroundImage = GetBitmap("Coffee Bean.bmp")
			progressBarEx4.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Image
			progressBarEx4.BackMultipleColors = New System.Drawing.Color(){}
			progressBarEx4.BackSegments = False
			progressBarEx4.BackTubeEndColor = System.Drawing.Color.White
			progressBarEx4.BackTubeStartColor = System.Drawing.Color.LightGray
			progressBarEx4.FontColor = System.Drawing.SystemColors.Control
			progressBarEx4.BackgroundImage = GetBitmap("Soap-Bubbles.jpg")

			progressBarEx4.GradientEndColor = System.Drawing.Color.Lime
			progressBarEx4.GradientStartColor = System.Drawing.Color.Red
			progressBarEx4.MultipleColors = New System.Drawing.Color(){}
			progressBarEx4.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Image
			progressBarEx4.SegmentWidth = 12
			progressBarEx4.StretchImage = False
			progressBarEx4.TubeEndColor = System.Drawing.Color.Black
			progressBarEx4.TubeStartColor = System.Drawing.Color.Red
			progressBarEx4.ProgressValue = 75

			gridControl1.RowHeights(rowIndex) = 23
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 2, rowIndex, 6))


			' Horizontal
			rowIndex += 2

			Dim style7 As GridStyleInfo = gridControl1(rowIndex, colIndex1)
			Dim progressBarEx7 As GridProgressBarInfo = style7.ProgressBar
			style7.CellType = "ProgressBar"
			style7.Themed = False

			' 
			' progressBarEx7
			' 
			progressBarEx7.BackGradientEndColor = System.Drawing.SystemColors.ControlLightLight
			progressBarEx7.BackGradientStartColor = System.Drawing.SystemColors.ControlDark
			progressBarEx7.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient
			progressBarEx7.BackMultipleColors = New System.Drawing.Color(){}
			progressBarEx7.BackSegments = False
			progressBarEx7.BackTubeEndColor = System.Drawing.Color.Silver
			progressBarEx7.BackTubeStartColor = System.Drawing.Color.White
			progressBarEx7.FontColor = System.Drawing.Color.White
			progressBarEx7.ForegroundImage = Nothing
			progressBarEx7.GradientEndColor = System.Drawing.Color.Lime
			progressBarEx7.GradientStartColor = System.Drawing.Color.Red
			progressBarEx7.MultipleColors = New System.Drawing.Color() { System.Drawing.SystemColors.ControlDarkDark, System.Drawing.SystemColors.ControlLightLight, System.Drawing.SystemColors.ActiveCaption}
			progressBarEx7.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube
			progressBarEx7.SegmentWidth = 8
			progressBarEx7.StretchImage = False
			progressBarEx7.TextVisible = False
			progressBarEx7.TubeEndColor = System.Drawing.Color.Honeydew
			progressBarEx7.TubeStartColor = System.Drawing.Color.Green
			progressBarEx7.ProgressValue = 75

			gridControl1.RowHeights(rowIndex) = 23
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 2, rowIndex, 6))



			' Horizontal
			rowIndex += 2

			Dim style9 As GridStyleInfo = gridControl1(rowIndex, colIndex1)
			Dim progressBarEx9 As GridProgressBarInfo = style9.ProgressBar
			style9.CellType = "ProgressBar"
			style9.Themed = False

			' 
			' progressBarEx9
			' 
			progressBarEx9.BackGradientEndColor = System.Drawing.Color.White
			progressBarEx9.BackGradientStartColor = System.Drawing.Color.LightGray
			progressBarEx9.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Tube
			progressBarEx9.BackMultipleColors = New System.Drawing.Color(){}
			progressBarEx9.BackSegments = False
			progressBarEx9.BackTubeEndColor = System.Drawing.Color.White
			progressBarEx9.BackTubeStartColor = System.Drawing.Color.LightGray
			progressBarEx9.ForegroundImage = Nothing
			progressBarEx9.GradientEndColor = System.Drawing.Color.Yellow
			progressBarEx9.GradientStartColor = System.Drawing.Color.Red
			progressBarEx9.MultipleColors = New System.Drawing.Color(){}
			progressBarEx9.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Gradient
			progressBarEx9.SegmentWidth = 12
			progressBarEx9.TubeEndColor = System.Drawing.Color.Black
			progressBarEx9.TubeStartColor = System.Drawing.Color.Red
			progressBarEx9.ProgressValue = 75

			gridControl1.RowHeights(rowIndex) = 23
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 2, rowIndex, 6))


			' Horizontal
			rowIndex += 2

			Dim style14 As GridStyleInfo = gridControl1(rowIndex, colIndex1)
			Dim progressBarEx14 As GridProgressBarInfo = style14.ProgressBar
			style14.CellType = "ProgressBar"
			style14.Themed = True

			' 
			' progressBarEx14
			' 
			progressBarEx14.BackGradientEndColor = System.Drawing.Color.White
			progressBarEx14.BackGradientStartColor = System.Drawing.Color.LightGray
			progressBarEx14.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.System
			progressBarEx14.BackSegments = False
			progressBarEx14.BackTubeEndColor = System.Drawing.Color.White
			progressBarEx14.BackTubeStartColor = System.Drawing.Color.LightGray
			progressBarEx14.FontColor = System.Drawing.Color.White
			progressBarEx14.ForegroundImage = Nothing
			progressBarEx14.GradientEndColor = System.Drawing.Color.FromArgb(255, 187, 111)
			progressBarEx14.GradientStartColor = System.Drawing.Color.FromArgb(0, 21, 84)
			progressBarEx14.MultipleColors = New System.Drawing.Color(){}
			progressBarEx14.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient
			progressBarEx14.SegmentWidth = 12
			progressBarEx14.TubeEndColor = System.Drawing.Color.Black
			progressBarEx14.TubeStartColor = System.Drawing.Color.Red
			progressBarEx14.ProgressValue = 75

			gridControl1.RowHeights(rowIndex) = 23
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 2, rowIndex, 6))

			rowIndex += 2
			Dim styleCheckBox As GridStyleInfo = gridControl1(rowIndex, colIndex1)
			styleCheckBox.CellType = "CheckBox"
			styleCheckBox.Description = "Animate"
			styleCheckBox.Themed = True
			styleCheckBox.CellValue = "False"
			styleCheckBox.CheckBoxOptions.UncheckedValue = "False"
			styleCheckBox.CheckBoxOptions.CheckedValue = "True"
			styleCheckBox.FloatCell = True
			'gridControl1.CurrentCellChanged += new EventHandler(gridControl1_CurrentCellChanged);
			AddHandler gridControl1.CheckBoxClick, AddressOf gridControl1_CheckBoxClick
			For i As Integer = 23 To 36
				gridControl1.HideRows(i) = True
			Next i
'			#End Region

			Me.gridControl1.EndUpdate(True)
'			#End Region
		End Sub

		#Region "Helper Methods"
		Private Sub gridControl1_CheckBoxClick(ByVal sender As Object, ByVal e As GridCellClickEventArgs)
			If e.RowIndex = 21 Then
				For i As Integer = 23 To 36
					gridControl1.HideRows(i) = Not gridControl1.HideRows(i)
				Next i
			End If
			If e.RowIndex = 36 Then
				Animate(Not(gridControl1(e.RowIndex, e.ColIndex).Text = "True"))
			End If
		End Sub

		Private timer As New Timer()

		Private Sub Animate(ByVal enabled As Boolean)
			If enabled Then
				AddHandler timer.Tick, AddressOf timer_Tick
				timer.Interval = 10
				timer.Enabled = True
				timer.Start()
			Else
				RemoveHandler timer.Tick, AddressOf timer_Tick
				timer.Stop()
			End If
		End Sub

		Private Sub timer_Tick(ByVal sender As Object, ByVal e As EventArgs)
			gridControl1.BeginUpdate(BeginUpdateOptions.Invalidate)
			For rowIndex As Integer = 24 To 35 Step 2
				Dim style As GridStyleInfo = gridControl1(rowIndex, 2)
				Dim progressBarEx As GridProgressBarInfo = style.ProgressBar
				Dim pvalue As Integer = (progressBarEx.ProgressValue + rowIndex) Mod 100
				progressBarEx.ProgressValue = pvalue
			Next rowIndex

			Dim stylev As GridStyleInfo = gridControl1(26, 8)
			Dim progressBarExv As GridProgressBarInfo = stylev.ProgressBar
			Dim pvaluev As Integer = (progressBarExv.ProgressValue + 3) Mod 100
			progressBarExv.ProgressValue = pvaluev

			gridControl1.EndUpdate(True)
			Application.DoEvents()
		End Sub

		#End Region

		#Region "Form handlers"

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		Private Function GetBitmap(ByVal bitmapName As String) As Bitmap
			Dim bitmap As Bitmap = Nothing

			Try
				Dim ass As System.Reflection.Assembly = GetType(Form1).Assembly
				Dim name As String = ass.GetName().Name
				Dim stream As Stream = ass.GetManifestResourceStream(name & ".Resources." & bitmapName)
				bitmap = New Bitmap(stream)
			Catch ex As Exception
				TraceUtil.TraceExceptionCatched(ex)
			End Try

			Return bitmap
		End Function

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

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim gridBaseStyle1 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle2 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle3 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridBaseStyle4 As New Syncfusion.Windows.Forms.Grid.GridBaseStyle()
			Dim gridCellInfo1 As New Syncfusion.Windows.Forms.Grid.GridCellInfo()
			Me.gridControl1 = New Syncfusion.Windows.Forms.Grid.GridControl()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			gridBaseStyle1.Name = "Row Header"
			gridBaseStyle1.StyleInfo.BaseStyle = "Header"
			gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left
			gridBaseStyle1.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(184)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(216)))))))
			gridBaseStyle2.Name = "Column Header"
			gridBaseStyle2.StyleInfo.BaseStyle = "Header"
			gridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center
			gridBaseStyle3.Name = "Standard"
			gridBaseStyle3.StyleInfo.Font.Facename = "Tahoma"
			gridBaseStyle3.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window)
			gridBaseStyle4.Name = "Header"
			gridBaseStyle4.StyleInfo.Borders.Bottom = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.Borders.Left = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.Borders.Right = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.Borders.Top = New Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None)
			gridBaseStyle4.StyleInfo.CellType = "Header"
			gridBaseStyle4.StyleInfo.Font.Bold = True
			gridBaseStyle4.StyleInfo.Interior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb((CInt(Fix((CByte(203))))), (CInt(Fix((CByte(199))))), (CInt(Fix((CByte(184)))))), System.Drawing.Color.FromArgb((CInt(Fix((CByte(238))))), (CInt(Fix((CByte(234))))), (CInt(Fix((CByte(216)))))))
			gridBaseStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle
			Me.gridControl1.BaseStylesMap.AddRange(New Syncfusion.Windows.Forms.Grid.GridBaseStyle() { gridBaseStyle1, gridBaseStyle2, gridBaseStyle3, gridBaseStyle4})
			Me.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
			Me.gridControl1.ColCount = 9
			Me.gridControl1.ColWidthEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridColWidth() { New Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)})
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
			Me.gridControl1.Location = New System.Drawing.Point(12, 12)
			Me.gridControl1.MetroScrollBars = True
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(227))))), (CInt(Fix((CByte(239))))), (CInt(Fix((CByte(255))))))
			Me.gridControl1.Properties.FixedLinesColor = System.Drawing.Color.White
			Me.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(208))))), (CInt(Fix((CByte(215))))), (CInt(Fix((CByte(229))))))
			Me.gridControl1.Properties.MarkColHeader = False
			Me.gridControl1.Properties.MarkRowHeader = False
			Me.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No
			Me.gridControl1.RowCount = 42
			Me.gridControl1.RowHeightEntries.AddRange(New Syncfusion.Windows.Forms.Grid.GridRowHeight() { New Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)})
			Me.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode
			Me.gridControl1.Size = New System.Drawing.Size(670, 504)
			Me.gridControl1.SmartSizeBox = False
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ThemesEnabled = True
			Me.gridControl1.VerticalThumbTrack = True
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.CaptionForeColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.ClientSize = New System.Drawing.Size(692, 525)
			Me.Controls.Add(Me.gridControl1)
			Me.DropShadow = True
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.MinimizeBox = False
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.BorderColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(27))))), (CInt(Fix((CByte(161))))), (CInt(Fix((CByte(226))))))
			Me.BorderThickness = 2
			Me.Text = "Content Cell Demo"
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

	End Class


End Namespace
