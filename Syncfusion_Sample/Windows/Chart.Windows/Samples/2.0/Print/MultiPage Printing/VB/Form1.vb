Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports System.Drawing.Drawing2D
Imports Syncfusion.Drawing
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Drawing.Printing
Imports System.Drawing.Text
Imports Syncfusion.Windows.Forms

Namespace MultiPagePrinting_2005
	Partial Public Class Form1
        Inherits Office2007Form
		Private m_currectAction As Nullable(Of PrintAction) = Nothing
		Private mx As Double = 0.0, mi As Double = 0.0
		Private start, [end] As Double
		Private Intervel As Double
		Public Sub New()
			InitializeComponent()
			Appearanceset()
			InitializeChartData()
			AddHandler chartControl1.PrintDocument.BeginPrint, AddressOf PrintDocument_BeginPrint
			AddHandler chartControl1.PrintDocument.EndPrint, AddressOf PrintDocument_EndPrint
            AddHandler chartControl1.PrintDocument.PrintPage, AddressOf PrintDocument_PrintPage
            Me.ComboBox1.SelectedIndex = 0
		End Sub
		Private Sub InitChart()
			Me.chartControl1.PrimaryXAxis.DrawGrid = False
			Me.chartControl1.PrimaryXAxis.DrawGrid = False

		End Sub
		Private Sub InitializeChartData()
			Me.chartControl1.Series.Clear()
			InitChart()
			Appearanceset()
			Dim ser As ChartSeries = New ChartSeries("MultiPage")
			ser.Points.Add(2, 45)
			ser.Points.Add(5, 100)
			ser.Points.Add(7, 210)
			ser.Points.Add(9, 110)
			ser.Points.Add(10, 150)
			ser.Points.Add(11, 180)
			ser.Points.Add(3, 45)
			ser.Points.Add(4, 100)
			ser.Points.Add(6, 210)
			ser.Points.Add(12, 110)
			ser.Points.Add(13, 150)
			ser.Points.Add(14, 180)
			ser.Points.Add(8, 45)
			ser.Points.Add(9, 100)
			ser.Points.Add(15, 210)
			ser.Points.Add(16, 110)
			ser.Points.Add(17, 150)
			ser.Points.Add(18, 180)
			ser.Points.Add(19, 100)
			ser.Points.Add(20, 210)
			ser.Points.Add(21, 110)
			ser.Points.Add(22, 150)
			ser.Points.Add(23, 180)
			ser.Points.Add(24, 150)
			ser.Points.Add(25, 180)
			ser.Points.Add(26, 210)
			ser.Points.Add(27, 110)
			ser.Points.Add(28, 150)
			ser.Points.Add(29, 180)
			ser.Points.Add(30, 150)
			ser.Points.Add(40, 210)
			ser.Points.Add(41, 110)
			ser.Points.Add(42, 150)
			ser.Points.Add(43, 180)
			ser.Points.Add(44, 150)
			ser.Points.Add(45, 180)
			ser.Points.Add(46, 210)
			ser.Points.Add(47, 110)
			ser.Points.Add(48, 150)
			ser.Points.Add(49, 180)
			ser.Points.Add(50, 150)
			ser.Points.Add(60, 210)
			ser.Points.Add(61, 110)
			ser.Points.Add(62, 150)
			ser.Points.Add(63, 180)
			ser.Points.Add(64, 150)
			ser.Points.Add(65, 180)
			ser.Points.Add(66, 210)
			ser.Points.Add(67, 110)
			ser.Points.Add(68, 150)
			ser.Points.Add(69, 180)
			ser.Points.Add(70, 150)
			ser.Points.Add(71, 110)
			ser.Points.Add(72, 150)
			ser.Points.Add(73, 180)
			ser.Points.Add(74, 150)
			ser.Points.Add(75, 180)
			ser.Points.Add(76, 210)
			ser.Points.Add(77, 110)
			ser.Points.Add(78, 150)
			ser.Points.Add(79, 180)
			ser.Points.Add(80, 150)
			Me.chartControl1.PrimaryXAxis.Range = New MinMaxInfo(0, 80, 5)
			ser.Type = ChartSeriesType.Column
			Me.chartControl1.Series.Add(ser)
			Me.chartControl1.Text = "Multiple Page Printing"

			start = Me.chartControl1.PrimaryXAxis.Range.Min
			[end] = Me.chartControl1.PrimaryXAxis.Range.Max
			Intervel = Me.chartControl1.PrimaryXAxis.Range.Interval
		End Sub
		Private Sub Appearanceset()
			chartControl1.Palette = ChartColorPalette.Custom
			chartControl1.CustomPalette = New System.Drawing.Color() { Color.FromArgb(200, 41,122,139), Color.FromArgb(200, 140,198,62), Color.FromArgb(200,247,148,29), Color.FromArgb(200, 163,48,45) }

'			#Region "Chart Appearance Customization"

			chartControl1.BackInterior = New BrushInfo(GradientStyle.ForwardDiagonal, Color.FromArgb(215, 228, 189), Color.White)
			chartControl1.ChartArea.BackInterior = New BrushInfo(GradientStyle.Vertical, Color.Transparent, Color.Transparent)
			chartControl1.ChartInterior = New BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(215, 228, 189), Color.White)
			chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Frame
			chartControl1.BorderAppearance.BaseColor = Color.DarkOliveGreen
			chartControl1.BorderAppearance.FrameThickness = New ChartThickness(-2, -2, 2, 2)
			chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias

			chartControl1.ElementsSpacing = 5

'			#End Region

'			#Region "Axes Customization"

			chartControl1.PrimaryXAxis.HidePartialLabels = True
			chartControl1.PrimaryXAxis.HidePartialLabels = True
			chartControl1.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27)
			chartControl1.PrimaryXAxis.LineType.ForeColor = Color.FromArgb(175, 129, 115, 27)
			chartControl1.PrimaryXAxis.LineType.Width = 2
			chartControl1.PrimaryXAxis.LineType.Width = 2
			chartControl1.PrimaryXAxis.TickColor = Color.Transparent
			chartControl1.PrimaryXAxis.TickColor = Color.Transparent
			chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.LightGray
			chartControl1.PrimaryXAxis.GridLineType.ForeColor = Color.LightGray
			chartControl1.Legend.Visible = False
			chartControl1.Series(0).Style.Symbol.Border.Color = Color.FromArgb(200, 129, 115, 27)
			chartControl1.Titles(0).Font = New Font("Verdana", 12.0f, FontStyle.Bold)

'			#End Region
		End Sub

		Private Sub PrintDocument_EndPrint(ByVal sender As Object, ByVal e As PrintEventArgs)
			mx = 0.0
			mi = 0.0
		End Sub
		Private Sub PrintDocument_BeginPrint(ByVal sender As Object, ByVal e As PrintEventArgs)
			m_currectAction = e.PrintAction
		End Sub

		Private Sub PrintDocument_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
			
			e.HasMorePages = True
			Me.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Wrap
			If mx = 0.0 AndAlso mi = 0.0 Then

				mx = Convert.ToDouble(Me.ComboBox1.SelectedItem)
				mi = 0
			End If
			Dim grayScale As Boolean = Me.chartControl1.PrintDocument.ColorMode = ChartPrintColorMode.GrayScale
			Dim toolBatVisibility As Boolean = Me.chartControl1.ShowToolbar

			If (Not Me.chartControl1.PrintDocument.PrintToolBar) Then
				Me.chartControl1.ShowToolbar = False
			End If

			If m_currectAction.Value = PrintAction.PrintToPrinter AndAlso Me.chartControl1.PrintDocument.ColorMode = ChartPrintColorMode.CheckPrinter Then
				grayScale = Me.chartControl1.PrintDocument.PrinterSettings.SupportsColor
			End If
			
			If (Not grayScale) Then

				Me.chartControl1.PrimaryXAxis.Range.Min = mi
				Me.chartControl1.PrimaryXAxis.Range.Max = mx
				Me.chartControl1.PrimaryXAxis.Range.Interval = (Me.chartControl1.PrimaryXAxis.Range.Max - Me.chartControl1.PrimaryXAxis.Range.Min) / Me.chartControl1.PrimaryXAxis.Range.NumberOfIntervals
				mi = mx
                mx = mx + Convert.ToDouble(Me.ComboBox1.SelectedItem)
				Dim container As GraphicsContainer = BeginTransform(e.Graphics)
				e.Graphics.ResetTransform()
				Me.chartControl1.Draw(e.Graphics, e.MarginBounds)
				EndTransform(e.Graphics, container)
			ElseIf grayScale Then
				Dim tempStyles() As ChartStyleInfo = New ChartStyleInfo(Me.chartControl1.Series.Count - 1){}
				Dim ps As Array = System.Enum.GetValues(GetType(PatternStyle))
				Dim ds As Array = System.Enum.GetValues(GetType(DashStyle))

				For i As Integer = 0 To Me.chartControl1.Series.Count - 1
					tempStyles(i) = New ChartStyleInfo()
					tempStyles(i).CopyFrom(Me.chartControl1.Series(i).StylesImpl.Style)

					Me.chartControl1.Series(i).Style.Interior = New BrushInfo(CType(ps.GetValue(i Mod ps.Length), PatternStyle), Color.Black, Color.White)
					Me.chartControl1.Series(i).Style.Border.MakeCopy(tempStyles(i), Me.chartControl1.Series(i).Style.Border.Sip)
					Me.chartControl1.Series(i).Style.Border.Color = Color.Black
					Me.chartControl1.Series(i).Style.Border.DashStyle = CType(ds.GetValue(i Mod ds.Length), DashStyle)

					If Me.chartControl1.Series(i).Type = ChartSeriesType.Line OrElse Me.chartControl1.Series(i).Type = ChartSeriesType.Spline OrElse Me.chartControl1.Series(i).Type = ChartSeriesType.StepLine OrElse Me.chartControl1.Series(i).Type = ChartSeriesType.RotatedSpline Then
						Me.chartControl1.Series(i).Style.Interior = New BrushInfo(CType(ps.GetValue(i Mod ps.Length), PatternStyle), Color.White, Color.Black)

						If Me.chartControl1.Series3D OrElse Me.chartControl1.ChartInterior.BackColor = Color.Black Then
							Me.chartControl1.Series(i).Style.Interior = New BrushInfo(CType(ps.GetValue(i Mod ps.Length), PatternStyle), Color.Black, Color.White)
							Me.chartControl1.Series(i).Style.Border.Color = Color.Black

						End If
					End If
				Next i

				Dim container As GraphicsContainer = BeginTransform(e.Graphics)
				e.Graphics.ResetTransform()

				Using img As Image = New Bitmap(e.MarginBounds.Width, e.MarginBounds.Height)
					Using g As Graphics = Graphics.FromImage(img)
						Me.chartControl1.ChartArea.PrimaryXAxis.Range.Min = mi
						Me.chartControl1.ChartArea.PrimaryXAxis.Range.Max = mx
						Me.chartControl1.ChartArea.PrimaryXAxis.Range.Interval = (Me.chartControl1.ChartArea.PrimaryXAxis.Range.Max - Me.chartControl1.ChartArea.PrimaryXAxis.Range.Min) / Me.chartControl1.ChartArea.PrimaryXAxis.Range.NumberOfIntervals
						mi = mx
                        mx = mx + Convert.ToDouble(Me.ComboBox1.SelectedItem)
						Dim hdc As IntPtr = g.GetHdc()
						Dim stream As Stream = New MemoryStream()
						Dim mf As Metafile = New Metafile(stream, hdc)

						Me.chartControl1.Draw(mf, img.Size)

						DrawingUtils.DrawGrayedImage(e.Graphics, mf, e.MarginBounds, New Rectangle(Point.Empty, img.Size))

						g.ReleaseHdc(hdc)
						g.Dispose()
						mf.Dispose()
					End Using
				End Using

				EndTransform(e.Graphics, container)

				For i As Integer = 0 To Me.chartControl1.Series.Count - 1
					Me.chartControl1.Series(i).StylesImpl.Style.ResetInterior()
					Me.chartControl1.Series(i).StylesImpl.Style.ResetBorder()
					Me.chartControl1.Series(i).StylesImpl.Style.CopyFrom(tempStyles(i))
				Next i
			End If
			'//END A little experimental code

			If (Not Me.chartControl1.PrintDocument.PrintToolBar) Then
				Me.chartControl1.ShowToolbar = toolBatVisibility
			End If

			Me.chartControl1.Redraw(True)
			If mx > [end] Then
				e.HasMorePages = False
			End If


			Me.chartControl1.PrimaryXAxis.Range.Min = start
			Me.chartControl1.PrimaryXAxis.Range.Max = [end]
			Me.chartControl1.PrimaryXAxis.Range.Interval = Intervel
		End Sub

		Friend Shared Function BeginTransform(ByVal g As Graphics) As GraphicsContainer
			Dim mode As SmoothingMode = g.SmoothingMode
			Dim textRH As TextRenderingHint = g.TextRenderingHint
			Dim cont As GraphicsContainer = g.BeginContainer()
			g.SmoothingMode = mode
			g.TextRenderingHint = textRH
			Return cont
		End Function
		Friend Shared Sub EndTransform(ByVal g As Graphics, ByVal cont As GraphicsContainer)
			g.EndContainer(cont)
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			If Me.checkBox1.Checked Then
				Me.chartControl1.PrintDocument.ColorMode = ChartPrintColorMode.GrayScale
			Else
				Me.chartControl1.PrintDocument.ColorMode = ChartPrintColorMode.CheckPrinter
			End If
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim printDialog As PrintPreviewDialog = New PrintPreviewDialog()

			printDialog.Document = Me.chartControl1.PrintDocument
			printDialog.ShowDialog()

		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Dim printDialog As PrintDialog = New PrintDialog()
			printDialog.Document = Me.chartControl1.PrintDocument
			printDialog.UseEXDialog = True
			If printDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				Try
					Me.chartControl1.PrintDocument.Print()
				Catch ex As Exception
					MessageBox.Show(ex.Message)
				End Try
			End If
		End Sub


	End Class
End Namespace
