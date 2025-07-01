Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram.Samples.gov.weather.graphical
Imports System.Xml
Imports System.Threading

Namespace Syncfusion.Windows.Forms.Diagram.Samples
	Partial Public Class MainForm
		Inherits DemoCommon.Diagram.DemoForm
		''' <summary>
		''' NDFD weather service
		''' </summary>
		Private weatherService As ndfdXML
		Private states As List(Of State)
		Private value As Integer = 0
		Private maximum As Integer = 0
		Private bIsLoading As Boolean
		Private records As NodeCollection
		Public Sub New()
			InitializeComponent()
			AddHandler diagram1.KeyDown, AddressOf diagram1_KeyDown
			diagram1.Model.BackgroundImageLayout = Syncfusion.Windows.Forms.Diagram.ImageLayout.Stretch
			diagram1.Model.BackgroundImage = Image.FromFile("..//..//Data//Map1.png")
			diagram1.Model.LogicalSize = diagram1.Model.BackgroundImage.Size
			Dim txtNode As New TextNode("Loading  0 %", New RectangleF(0,0,300,50))
			txtNode.FontStyle.Family = "Segoe UI"
			txtNode.FontStyle.Size = 14
			txtNode.FontColorStyle.Color = Color.Black
			txtNode.LineStyle.LineWidth = 0
			txtNode.PinPoint = New PointF(800,570)
			txtNode.EditStyle.AllowSelect = False
			txtNode.Name = "Status"
			diagram1.Model.AppendChild(txtNode)
			InitStates()
		End Sub

		#Region "Event Handlers"
		Private Sub diagram1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If Not bIsLoading Then
				If e.KeyCode = Keys.F5 Then
					bIsLoading = True
					diagram1.Model.Clear()
					Dim txtNode As New TextNode("Loading  0 %", New RectangleF(0, 0, 300, 50))
					txtNode.FontStyle.Family = "Segoe UI"
					txtNode.FontStyle.Size = 14
					txtNode.FontColorStyle.Color = Color.Black
					txtNode.LineStyle.LineWidth = 0
					txtNode.PinPoint = New PointF(800, 570)
					txtNode.EditStyle.AllowSelect = False
					txtNode.Name = "Status"
					diagram1.Model.AppendChild(txtNode)
					backgroundWorker1.RunWorkerAsync()
				End If
			End If
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			CType(diagram1.Model.Nodes("Status"), TextNode).Text = "Loading  0 %"
			backgroundWorker1.RunWorkerAsync()
		End Sub

		Private Sub backgroundWorker1_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles backgroundWorker1.DoWork
			bIsLoading = True
			GenerateReport()
		End Sub

		Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles backgroundWorker1.RunWorkerCompleted
			If records IsNot Nothing AndAlso (Not records.IsEmpty) Then
				Dim i As Integer
				diagram1.Model.AppendChildren(records, i)
				bIsLoading = False
				value = 0
			End If
		End Sub

		Private Sub backgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs) Handles backgroundWorker1.ProgressChanged
			Dim percent As Integer = e.ProgressPercentage * 100 \ maximum
			If percent = 100 Then
				CType(diagram1.Model.Nodes("Status"), TextNode).Text = "Hit F5 to refresh the report."
			Else
				CType(diagram1.Model.Nodes("Status"), TextNode).Text = "Loading  " & percent & " %"
			End If
		End Sub
		#End Region

		#Region "Initialize Diagram"
		''' <summary>
		''' Initiate state nodes
		''' </summary>
		Private Sub InitStates()
			weatherService = New ndfdXML()
			states = New List(Of State)()
			states.Add(New State("WA", 47.3030D, -120.1245D))
			states.Add(New State("TX", 31.1060D, -99.6475D))
			states.Add(New State("CA", 37.1700D, -119.7462D))
			states.Add(New State("GA", 32.9866D, -84.6487D))
			states.Add(New State("MT", 46.9048D, -110.3261D))
			states.Add(New State("CO", 39.0646D, -106.3272D))
			states.Add(New State("NV", 39.4199D, -117.1219D))
			states.Add(New State("AZ", 34.1112D, -112.0131D))
			states.Add(New State("MO", 38.4623D, -93.3020D))
			states.Add(New State("PA", 40.5773D, -79.2640D))
			states.Add(New State("WI", 44.2563D, -90.6385D))
			states.Add(New State("ND", 47.5362D, -100.7930D))
			states.Add(New State("NE", 41.1289D, -99.2883D))
		End Sub

		''' <summary>
		''' Converts latitude and longitude to (x,y) coordinates on the background map.
		''' </summary>
		Private Function ConvertCoordinates(ByVal latitude As Decimal, ByVal longitude As Decimal) As PointF
			Dim mapSize As SizeF = diagram1.Model.LogicalSize
			Dim y As Double = (CDbl(latitude) - 18R) * mapSize.Height / (55.5R - 18R)
			Dim x As Double = (-CDbl(longitude) - 70R) * mapSize.Width / (125R - 70R)
			Return New PointF(CSng(mapSize.Width) - CSng(x), CSng(mapSize.Height) - CSng(y))
		End Function

		''' <summary>
		''' Generate the reports
		''' </summary>
		Private Sub GenerateReport()
			records = New NodeCollection()
			maximum = states.Count
			For Each state As State In states
				Dim weatherType As New weatherParametersType()

				'specifies parameters maximum temperature, weather condition and cloud amount
				weatherType.maxt = True
				weatherType.sky = True
				weatherType.wx = True

				' call the weather service.                
				'weatherService.NDFDgenAsync(state.Latitude, state.Longitude, productType.timeseries, DateTime.Now.Date, DateTime.Now.AddDays(1).Date, unitType.e, weatherType, state);
				Dim str As String = weatherService.NDFDgenByDay(state.Latitude, state.Longitude, DateTime.Now.Date, "1", unitType.e, formatType.Item24hourly)
				Dim node As New WeatherNode()

				' get coordinates on map.
				Dim location As PointF = ConvertCoordinates(state.Latitude, state.Longitude)
				node.PinPoint = New PointF(location.X - node.Size.Width \ 2, location.Y - node.Size.Height \ 2)
				node.Name = state.Name
				node.State = node.Name
				If Not String.IsNullOrEmpty(str) Then
					Dim doc As New XmlDocument()
					doc.LoadXml(str)
					node.Temperature = XmlConvert.ToDecimal(doc.SelectSingleNode("dwml/data/parameters/temperature[@type='maximum']/value/text()").Value)
					Dim n As XmlNode = doc.SelectSingleNode("dwml/data/parameters/weather/weather-conditions/value")
					Dim weather As String = Nothing
					If n IsNot Nothing Then
						Dim attr As XmlAttribute = n.Attributes("weather-type")
						If attr IsNot Nothing Then
							weather = n.Attributes("weather-type").Value
						End If
					End If
					If weather = "freezing rain" OrElse weather = "rain" OrElse weather = "hail" OrElse weather = "rain showers" OrElse weather = "freezing drizzle" OrElse weather = "drizzle" Then
						node.WeatherCondition = WeatherCondition.Rain
					ElseIf weather = "show showers" OrElse weather = "blowing snow" OrElse weather = "snow" OrElse weather = "ice pellets" Then
						node.WeatherCondition = WeatherCondition.Snow
					ElseIf weather = "thunderstorms" Then
						node.WeatherCondition = WeatherCondition.ThunderStorm
					Else
						node.WeatherCondition = WeatherCondition.None
					End If

					records.Add(node)
					value += 1
					backgroundWorker1.ReportProgress(value)
				End If
			Next state
		End Sub

		#End Region
	End Class
End Namespace