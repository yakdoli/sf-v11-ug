Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Chart
Imports System.Drawing.Drawing2D
Imports Syncfusion.Drawing

Namespace MultiplePieChart_2005
	Partial Public Class Form1
		Inherits Office2007Form
		#Region "Private Member"
		Private color1(), color2(), color3(), color4(), color5(), color6(), color7(), color8() As Color
		#End Region

		#Region "Constructor And Form Load"
        Public Sub New()

            InitializeComponent()

        End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            InitialiseData()
			InitialiseControls()
			ChartAppearance.ApplyChartStyles(Me.chartControl1)
		End Sub
		#End Region

		#Region "Healper Methods"
		Public Sub InitialiseControls()
			For Each connect As String In System.Enum.GetNames(GetType(Syncfusion.Windows.Forms.Chart.ChartPieType))
				Me.cbBxPieType.Items.Add(connect)
			Next connect
            Me.cbBxPieType.SelectedIndex = 0
		End Sub

		Public Sub InitialiseData()
			chartControl1.Series.Clear()

			Dim random As New Random()
			Dim series1 As New ChartSeries()
			series1.Name = "Year 2006"
			series1.Text = series1.Name
			series1.Points.Add(0, 10)
			series1.Points.Add(2, 18)
			series1.Points.Add(3, 21)
			series1.Points.Add(4, 23)
			series1.Points.Add(5, 18)
			SeriesSettings(series1)
			Me.chartControl1.Series.Add(series1)

			Dim series2 As New ChartSeries()
			series2.Name = "Year 2007"
			series2.Text = series2.Name
			series2.Points.Add(0, 12)
			series2.Points.Add(2, 21)
			series2.Points.Add(3, 18)
			series2.Points.Add(4, 25)
			series2.Points.Add(5, 24)
			SeriesSettings(series2)
			Me.chartControl1.Series.Add(series2)

			Dim series3 As New ChartSeries()
			series3.Name = "Year 2008"
			series3.Text = series3.Name
			series3.Points.Add(0, 18)
			series3.Points.Add(2, 12)
			series3.Points.Add(3, 18)
			series3.Points.Add(4, 21)
			series3.Points.Add(5, 31)
			SeriesSettings(series3)
			Me.chartControl1.Series.Add(series3)

			'Enable MultiplePies property to enable this feature.
			chartControl1.ChartArea.MultiplePies = True

			series1.Type = ChartSeriesType.Pie
			series2.Type = ChartSeriesType.Pie
			series3.Type = ChartSeriesType.Pie

			'Each series must have DoughnutCoEfficient value [except the most inner series example: series1], to get the complete functionality of this feature.
			series2.ConfigItems.PieItem.DoughnutCoeficient = 0.7f
			series3.ConfigItems.PieItem.DoughnutCoeficient = 0.8f

			series3.ConfigItems.PieItem.AngleOffset = 130f
			series2.ConfigItems.PieItem.AngleOffset = 130f
			series1.ConfigItems.PieItem.AngleOffset = 130f

			Dim chartLegend As New ChartLegend()
			chartLegend.Name = "Legend 1"
            Dim label() As String = {"Engineering-13.33%", "Medical Sciences-17%", "BioTechnology-19%", "Information Services-23%", "Economics -24.33%"}
			Dim items As New List(Of ChartLegendItem)()
			For i As Integer = 0 To 4
				Dim legendItem As New ChartLegendItem(label(i))
				legendItem.Font = New Font("Verdana", 7, FontStyle.Regular)
				legendItem.RepresentationSize = New Size(16, 16)
				legendItem.TextColor = Color.MidnightBlue
				items.Add(legendItem)
			Next i

			chartControl1.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType
			chartControl1.Legend.CustomItems = items.ToArray()
            chartControl1.Legend.RowsCount = 5
			Me.chartControl1.LegendAlignment = ChartAlignment.Center
			Me.chartControl1.ShowLegend = True
			Me.chartControl1.SmoothingMode = SmoothingMode.AntiAlias

			If ckBxEnable3D.Checked Then
				Me.nUpDownPieHeight.Enabled = True
			Else
				Me.nUpDownPieHeight.Enabled = False
			End If
            'DrawItemText to customize the legend item text
            AddHandler chartControl1.Legend.DrawItemText, AddressOf Legend_DrawItemText
		End Sub
		Protected Sub SeriesSettings(ByVal series As ChartSeries)
			Dim newSeries As ChartSeries = series
			newSeries.Type = ChartSeriesType.Pie

			newSeries.Style.TextColor = Color.MidnightBlue
			newSeries.Style.Font.Bold = True
			newSeries.Style.Font.Size = 7
			newSeries.Style.DisplayText = Me.ckBxDisplayText.Checked

			newSeries.LegendName = "Legend 1"
			AddHandler newSeries.PrepareStyle, AddressOf series1_PrepareStyle

			For i As Integer = 0 To 4
				series.Styles(i).Font.Size = 7f
				series.Styles(i).TextFormat = String.Format("{0}%", series.Points(i).YValues(0))
			Next i
		End Sub
		#End Region

		#Region "Events"
		''' <summary>
		''' Handler for the PrepareStyle event of ChartSeries. 
		''' </summary>
		''' <param name="sender">The ChartSeries object that raises this event.</param>
		''' <param name="args">The event data. Can be modified to change series appearance.</param>
		Private Sub series1_PrepareStyle(ByVal sender As Object, ByVal args As ChartPrepareStyleInfoEventArgs)
			Dim series As ChartSeries = TryCast(sender, ChartSeries)
			series.Style.Border.Color = Color.SlateGray

			If series IsNot Nothing Then

				color1 = New Color() { Color.FromArgb(200, 130, 181, 182) }
				color2 = New Color() { Color.FromArgb(200, 206, 215, 41) }
				color3 = New Color() { Color.FromArgb(200, 250, 206, 35) }
				color4 = New Color() { Color.FromArgb(200, 155, 166, 184) }
				color5 = New Color() { Color.FromArgb(200, 9, 116, 210) }
				color6 = New Color() { Color.FromArgb(200, 191, 192, 98) }
				color7 = New Color() { Color.FromArgb(200, 234, 90, 95) }
				color8 = New Color() { Color.FromArgb(200, 191, 192, 98) }

				If args.Index = 0 Then
					args.Style.Interior = New BrushInfo(GradientStyle.None, color3)
					Me.chartControl1.Legend.Items(0).Interior = New BrushInfo(GradientStyle.None, color3)
				ElseIf args.Index = 1 Then
					args.Style.Interior = New BrushInfo(GradientStyle.None, color2)
					Me.chartControl1.Legend.Items(1).Interior = New BrushInfo(GradientStyle.None, color2)
				ElseIf args.Index = 2 Then
					args.Style.Interior = New BrushInfo(GradientStyle.None, color5)
					Me.chartControl1.Legend.Items(2).Interior = New BrushInfo(GradientStyle.None, color5)
				ElseIf args.Index = 3 Then
					args.Style.Interior = New BrushInfo(GradientStyle.None, color7)
					Me.chartControl1.Legend.Items(3).Interior = New BrushInfo(GradientStyle.None, color7)
				ElseIf args.Index = 4 Then
					args.Style.Interior = New BrushInfo(GradientStyle.None, color4)
					Me.chartControl1.Legend.Items(4).Interior = New BrushInfo(GradientStyle.None, color4)
				Else
					args.Style.Interior = New BrushInfo(GradientStyle.None, color1)
				End If
			End If
		End Sub

        Private Sub ckBxDisplayText_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ckBxDisplayText.CheckedChanged
            If (Me.chartControl1.Series.Count = 3) Then

                chartControl1.Series(0).Style.DisplayText = ckBxDisplayText.Checked
                chartControl1.Series(1).Style.DisplayText = ckBxDisplayText.Checked
                chartControl1.Series(2).Style.DisplayText = ckBxDisplayText.Checked
            End If
        End Sub

        Private Sub cbBxPieType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbBxPieType.SelectedIndexChanged
            If (Me.chartControl1.Series.Count = 3) Then
                chartControl1.Series(0).ConfigItems.PieItem.PieType = CType(System.Enum.Parse(GetType(ChartPieType), Me.cbBxPieType.SelectedItem.ToString(), True), ChartPieType)
                chartControl1.Series(1).ConfigItems.PieItem.PieType = CType(System.Enum.Parse(GetType(ChartPieType), Me.cbBxPieType.SelectedItem.ToString(), True), ChartPieType)
                chartControl1.Series(2).ConfigItems.PieItem.PieType = CType(System.Enum.Parse(GetType(ChartPieType), Me.cbBxPieType.SelectedItem.ToString(), True), ChartPieType)
            End If
        End Sub

        Private Sub ckBxEnable3D_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ckBxEnable3D.CheckedChanged
            chartControl1.Series3D = ckBxEnable3D.Checked
            If ckBxEnable3D.Checked Then
                Me.nUpDownPieHeight.Enabled = True
            Else
                Me.nUpDownPieHeight.Enabled = False
            End If
        End Sub

        Private Sub nUpDownPieHeight_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nUpDownPieHeight.ValueChanged
            If (Me.chartControl1.Series.Count = 3) Then

                chartControl1.Series(0).ConfigItems.PieItem.PieHeight = Convert.ToSingle(nUpDownPieHeight.Value)
                chartControl1.Series(1).ConfigItems.PieItem.PieHeight = Convert.ToSingle(nUpDownPieHeight.Value)
                chartControl1.Series(2).ConfigItems.PieItem.PieHeight = Convert.ToSingle(nUpDownPieHeight.Value)
            End If
        End Sub
        Private Sub Legend_DrawItemText(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Chart.ChartLegendDrawItemTextEventArgs)
            ' Get current Legend item
            Dim item As ChartLegendItem = TryCast(sender, ChartLegendItem)
            'current item bounds value
            Dim textRect As RectangleF = e.TextRect
            'Text split for description and value text by mentionted symbol in Text property
            Dim mulText() As String = e.Text.Split("-")
            'Get Max size of text from legend item collection
            Dim itemMaxSize() As Size = MeasureSize(e.Graphics, chartControl1.Legend.Items, mulText.Length)

            Dim i As Integer = 0
            Do While mulText.Length > i
                'Get current text size
                Dim currentText As SizeF = e.Graphics.MeasureString(mulText(i), item.Font)
                If i > 0 Then
                    'Calculate value text position
                    textRect.X = textRect.Width
                    'If you need more space between description and values text, add hard values for textRect.Widht( textRect.Width += itemMaxSize(i).Width+10)
                    textRect.Width += itemMaxSize(i).Width - 24
                    'Align text for "Far" alignment
                    textRect.X += (textRect.Width - textRect.X) - currentText.Width

                Else
                    'Calculate description text position
                    textRect = New RectangleF(textRect.X, textRect.Y, itemMaxSize(i).Width, currentText.Height)

                End If

                'Draw the text
                Using sb As Brush = New SolidBrush(item.TextColor)
                    e.Graphics.DrawString(mulText(i), item.Font, sb, textRect)
                End Using
                i += 1
            Loop

            'Set "True" to handled property to draw the legend custom text properly.
            e.Handled = True
        End Sub
        Private Function MeasureSize(ByVal g As Graphics, ByVal items() As ChartLegendItem, ByVal textcols As Integer) As Size()
            Dim itemsize() As Size = New Size(textcols - 1) {}
            Dim itemText() As String
            For j As Integer = 0 To textcols - 1
                Dim itemsize1 As Size = New Size(0, 0)
                For Each item As ChartLegendItem In items

                    If item.Visible Then
                        itemText = item.Text.Split("-")
                        If itemText.Length > j Then
                            Dim sz As SizeF = GetSize(g, itemText(j), item.Font)

                            itemsize1.Width = Math.Max(CInt(Fix(sz.Width)), itemsize1.Width)
                            itemsize1.Height = Math.Max(CInt(Fix(sz.Height)), itemsize1.Height)
                        End If
                    End If
                Next item
                'Set max size for desc and values separatly in itemsize array
                itemsize(j) = Size.Ceiling(itemsize1)
            Next j

            Return itemsize
        End Function
        Private Function GetSize(ByVal g As Graphics, ByVal m_text As String, ByVal font As Font) As SizeF
            Dim spacing As Single = Me.chartControl1.ElementsSpacing
            Dim result As SizeF = g.MeasureString(m_text, chartControl1.Legend.Font)

            'Calculate size with icon size of legend item
            Dim iconSize As Size = chartControl1.Legend.Items(0).RepresentationSize
            result.Width += spacing + iconSize.Width
            result.Height = Math.Max(result.Height, iconSize.Height)

            Return Size.Ceiling(result)
        End Function

#End Region
    End Class
End Namespace