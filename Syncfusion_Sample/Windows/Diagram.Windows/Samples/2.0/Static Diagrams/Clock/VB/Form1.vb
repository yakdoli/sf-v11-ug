Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Imports Syncfusion.Windows.Forms.Diagram
Imports Syncfusion.Windows.Forms
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Soap
Imports System.Runtime.Serialization
Imports Syncfusion
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Collections
Imports DemoCommon.Diagram


Namespace Clock
	Partial Public Class Form1
		Inherits DemoForm
		#Region "Members"
		Private x As Integer = 0
		Private mynode As Node
		Private centerNode As Node
		Private secondsNode As Node
		Private hoursNode As Node
		Private minutesNode As Node
		Private palette As SymbolPalette
		Private digitalPalette As New SymbolPalette()
		Private digit, digit1, digit2, digit3, digit4, digit5, digit6, colon1, colon2 As Group
		Private hour, min, sec, ms As Integer
		Private zero() As Integer = { 1, 2, 3, 4, 5, 6 }
		Private one() As Integer = { 3, 6 }
		Private two() As Integer = { 2, 3, 4, 5, 7 }
		Private three() As Integer = { 2, 3, 5, 6, 7 }
		Private four() As Integer = { 1, 3, 6, 7 }
		Private five() As Integer = { 1, 2, 5, 6, 7 }
		Private six() As Integer = { 1, 2, 4, 5, 6, 7 }
		Private seven() As Integer = { 2, 3, 6 }
		Private eight() As Integer = { 1, 2, 3, 4, 5, 6, 7 }
		Private nine() As Integer = { 1, 2, 3, 5, 6, 7 }

		Private bitList As New ArrayList()
		#End Region

		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			DiagramAppearance()

			' Load Palette
			palette = Me.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\ClockSymbols.edp")

			diagram1.BeginUpdate()
			' populate Diagram with nodes
			AddingNodesToTheDrawingArea()
			diagram1.EndUpdate()

			Me.timer1.Start()

		End Sub
		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Change's the appearance of Diagram
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.HorizontalRuler.BackgroundColor = Color.White
			Me.diagram1.VerticalRuler.BackgroundColor = Color.White
			Me.diagram1.View.Grid.GridStyle = GridStyle.Line
			Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.diagram1.View.Grid.Color = Color.LightGray
			Me.diagram1.View.Grid.VerticalSpacing = 15
			Me.diagram1.View.Grid.HorizontalSpacing = 15
			Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f
			Me.diagram1.View.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.View.SelectionList.Clear()
		End Sub

		#End Region

		#Region "Helper methods"

		''' <summary>
		''' Insert nodes from the palete 
		''' </summary>
		Public Sub AddingNodesToTheDrawingArea()
			InsertNodeFromPallete(0, New PointF(85, 60))
			InsertNodeFromPallete(3, New PointF(173, 150))
			InsertNodeFromPallete(4, New PointF(173, 150))
			InsertNodeFromPallete(5, New PointF(173, 153))
			InsertNodeFromPallete(6, New PointF(171, 145))

			For Each node As Node In Me.diagram1.Model.Nodes
				If node.Name.Equals("ClockHead") Then
					mynode = TryCast(node, Node)
				ElseIf node.Name.Equals("Oscillator") Then
					centerNode = TryCast(node, Node)
				ElseIf node.Name.Equals("Seconds") Then
					secondsNode = TryCast(node, Node)
				ElseIf node.Name.Equals("Hours") Then
					hoursNode = TryCast(node, Node)
				ElseIf node.Name.Equals("Minutes") Then
					minutesNode = TryCast(node, Node)
				End If
				node.EditStyle.AllowSelect = False
			Next node

'			#Region "Digital clock"

			Dim outerRect As New Syncfusion.Windows.Forms.Diagram.RoundRect(325, 70, 420, 160,MeasureUnits.Pixel)
			outerRect.FillStyle.Color = ColorTranslator.FromHtml("#FF119EDA")
			outerRect.LineStyle.LineWidth = 0
			outerRect.EditStyle.AllowSelect = False
			diagram1.Model.AppendChild(outerRect)
			Dim innerRect As New Syncfusion.Windows.Forms.Diagram.RoundRect(335, 80, 400, 140, MeasureUnits.Pixel)
			innerRect.FillStyle.Color = ColorTranslator.FromHtml("#FF96D3ED")
			innerRect.LineStyle.LineWidth = 0
			innerRect.EditStyle.AllowSelect = False
			diagram1.Model.AppendChild(innerRect)
			Dim innerRect1 As New Syncfusion.Windows.Forms.Diagram.RoundRect(345, 90, 380, 120,7, MeasureUnits.Pixel)
			innerRect1.FillStyle.Color = Color.White
			innerRect1.LineStyle.LineWidth = 0
			innerRect1.EditStyle.AllowSelect = False
			diagram1.Model.AppendChild(innerRect1)

			bitList.Add(zero)
			bitList.Add(one)
			bitList.Add(two)
			bitList.Add(three)
			bitList.Add(four)
			bitList.Add(five)
			bitList.Add(six)
			bitList.Add(seven)
			bitList.Add(eight)
			bitList.Add(nine)

			digit = New Group(TryCast(palette.Nodes(7), Group))
			ApplyStyle(digit)
			digit.PinPoint = New PointF(380, 150)
			digit.EditStyle.AllowSelect = False
			digit.Visible = False
			diagram1.Model.AppendChild(digit)

			digit1 = New Group(TryCast(palette.Nodes(7), Group))
			ApplyStyle(digit1)
			digit1.PinPoint = New PointF(430, 150)
			digit1.EditStyle.AllowSelect = False
			digit1.Visible = False
			diagram1.Model.AppendChild(digit1)

			digit2 = New Group(TryCast(palette.Nodes(7), Group))
			ApplyStyle(digit2)
			digit2.PinPoint = New PointF(515, 150)
			digit2.EditStyle.AllowSelect = False
			digit2.Visible = False
			diagram1.Model.AppendChild(digit2)

			digit3 = New Group(TryCast(palette.Nodes(7), Group))
			ApplyStyle(digit3)
			digit3.PinPoint = New PointF(565, 150)
			digit3.EditStyle.AllowSelect = False
			digit3.Visible = False
			diagram1.Model.AppendChild(digit3)

			digit4 = New Group(TryCast(palette.Nodes(7), Group))
			ApplyStyle(digit4)
			digit4.PinPoint = New PointF(640, 150)
			digit4.EditStyle.AllowSelect = False
			digit4.Visible = False
			diagram1.Model.AppendChild(digit4)

			digit5 = New Group(TryCast(palette.Nodes(7), Group))
			ApplyStyle(digit5)
			digit5.PinPoint = New PointF(690, 150)
			digit5.EditStyle.AllowSelect = False
			digit5.Visible = False
			diagram1.Model.AppendChild(digit5)

			colon1 = New Group(TryCast(palette.Nodes(8), Group))
			ApplyStyle(colon1)
			colon1.PinPoint = New PointF(470, 150)
			colon1.EditStyle.AllowSelect = False
			diagram1.Model.AppendChild(colon1)

			colon2 = New Group(TryCast(palette.Nodes(8), Group))
			ApplyStyle(colon2)
			colon2.PinPoint = New PointF(600, 150)
			colon2.EditStyle.AllowSelect = False
			diagram1.Model.AppendChild(colon2)

'			#End Region

			Me.diagram1.Controller.SelectionList.Clear()
		End Sub

		''' <summary>
		''' Apply fill color for nodes
		''' </summary>
		''' <param name="gNode">Group Node</param>
		Private Sub ApplyStyle(ByVal gNode As Group)
			For Each node As Node In gNode.Nodes
				If TypeOf node Is FilledPath Then
					CType(node, FilledPath).FillStyle.Color = ColorTranslator.FromHtml("#FF333333")
				End If
			Next node
		End Sub

		''' <summary>
		'''  Get the SymbolPalette by deserializing the SymbolPalette file
		''' </summary>
		''' <param name="filepath">Path of the file</param>
		''' <returns>returns palette</returns>
		Public Function LoadPalette(ByVal filepath As String) As SymbolPalette
			Dim curSymbolPalette As SymbolPalette = Nothing
			Dim iStream As New FileStream(filepath, FileMode.Open, FileAccess.Read)
			If iStream IsNot Nothing Then
				Dim formatter As IFormatter = New BinaryFormatter()
				formatter.Binder = New OldToNewDeserializationBinder()
				Try
					AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf DiagramBaseAssembly.AssemblyResolver
					curSymbolPalette = CType(formatter.Deserialize(iStream), SymbolPalette)
				Catch e1 As SerializationException
					Try
						formatter = New SoapFormatter()
						formatter.Binder = New OldToNewDeserializationBinder()
						iStream.Position = 0
						curSymbolPalette = CType(formatter.Deserialize(iStream), SymbolPalette)
					Catch se As Exception
						' To get the version from the edp file
						Dim strRegex As String = "version\w*=\w*\d+\.\d+\.\d+(\.\d+)+\w*,"
						Dim regex As New System.Text.RegularExpressions.Regex(strRegex, System.Text.RegularExpressions.RegexOptions.IgnoreCase Or System.Text.RegularExpressions.RegexOptions.Singleline)
						Dim sr As StreamReader = File.OpenText(filepath)
						Dim strFileContent As String = sr.ReadToEnd()
						Dim version As System.Text.RegularExpressions.Match = regex.Match(strFileContent)
						Dim strVersion As String = version.Value

						If String.IsNullOrEmpty(strVersion) Then
							Throw New System.Exception("Incompatible with older version." & Constants.vbLf & "Please use the converter utility to make it compatible with newer version", se)
						Else
							Throw New System.Exception("Unable to parse the palette file " & strVersion, se)
						End If
					End Try
				Finally
					iStream.Close()
					RemoveHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf DiagramBaseAssembly.AssemblyResolver
				End Try
			End If
			Return curSymbolPalette
		End Function

		''' <summary>
		''' Insert the node from the palette
		''' </summary>
		''' <param name="nNodeIndex">Node's index</param>
		''' <param name="ptLocation">Node's location</param>
		''' <returns></returns>
		Private Function InsertNodeFromPallete(ByVal nNodeIndex As Integer, ByVal ptLocation As PointF) As Node
			Dim node As Node = Nothing
			Dim nodes As NodeCollection = palette.Nodes

			If nNodeIndex >= 0 AndAlso nNodeIndex < nodes.Count Then
				node = CType(nodes(nNodeIndex).Clone(), Node)
				InsertNode(node, ptLocation)
			End If

			Return node
		End Function
		''' <summary>
		''' Insert the node into the diagram
		''' </summary>
		''' <param name="node">Node</param>
		''' <param name="ptLocation">Node's location</param>
		''' <returns></returns>
		Private Function InsertNode(ByVal node As Node, ByVal ptLocation As PointF) As Node
			Dim units As MeasureUnits = MeasureUnits.Pixel
			Dim szPinOffset As SizeF = (CType(node, IUnitIndependent)).GetPinPointOffset(units)

			ptLocation.X += szPinOffset.Width
			ptLocation.Y += szPinOffset.Height

			CType(node, IUnitIndependent).SetPinPoint(ptLocation, units)
			If node.Name = "ClockHead" AndAlso TypeOf node Is Group Then
				If TypeOf (CType(node, Group)).Nodes(0) Is FilledPath Then
					CType((CType(node, Group)).Nodes(0), FilledPath).FillStyle.Color = ColorTranslator.FromHtml("#FF119EDA")
				End If
				If TypeOf (CType(node, Group)).Nodes(1) Is FilledPath Then
					CType((CType(node, Group)).Nodes(1), FilledPath).FillStyle.Color = ColorTranslator.FromHtml("#FF96D3ED")
				End If
			End If
			If node.Name = "CenterPiece" AndAlso TypeOf node Is Group Then
				If TypeOf (CType(node, Group)).Nodes(0) Is FilledPath Then
					CType((CType(node, Group)).Nodes(0), FilledPath).FillStyle.Color = ColorTranslator.FromHtml("#FF96D3ED")
				End If
				If TypeOf (CType(node, Group)).Nodes(1) Is FilledPath Then
					CType((CType(node, Group)).Nodes(1), FilledPath).FillStyle.Color = ColorTranslator.FromHtml("#FF119EDA")
				End If

			End If
			If node.Name = "Seconds" Then
				If TypeOf node Is FilledPath Then
					CType(node, FilledPath).FillStyle.Color = ColorTranslator.FromHtml("#FF119EDA")
				End If
			End If

			Me.diagram1.Model.AppendChild(node)
			Return node
		End Function

		''' <summary>
		''' Hide/Show digit nodes
		''' </summary>
		''' <param name="p">Index</param>
		''' <param name="displayNode">Node to show</param>
		Private Sub DrawClock(ByVal p As Integer, ByVal displayNode As Group)
			diagram1.BeginUpdate()

			Dim bits() As Integer = TryCast(bitList(p), Integer())
			'int j = 0;
			Dim i As Integer = 0
			Dim j As Integer = 0
			Do While i < displayNode.Nodes.Count
				displayNode.Visible = True
				If i = bits(j) - 1 Then
					Dim node As Node = displayNode.Nodes(bits(j) - 1)
					If node IsNot Nothing Then
						node.Visible = True
					End If
					If j < bits.Length - 1 Then
						j += 1
					End If
				Else
					Dim node As Node = displayNode.Nodes(i)
					If node IsNot Nothing Then
						node.Visible = False
					End If
				End If
				i += 1
			Loop
			diagram1.EndUpdate()
		End Sub


		#End Region

		#Region "Event Handlers"

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick

			secondsNode.RotationAngle = DateTime.Now.Second * (360 \ 60) + 270

			minutesNode.RotationAngle = DateTime.Now.Minute * (360 \ 60) + 270

			' Calculate the hour
			Dim hour As Integer = DateTime.Now.Hour
			If hour >= 12 Then
				hour -= 12
			End If
			' Calculate minutes passed of the current hour
			Dim passedMinutes As Integer = hour * 60 + DateTime.Now.Minute

			hoursNode.RotationAngle = passedMinutes / 720F * 360 + 270

			Dim dt As DateTime = DateTime.Now

			hour = dt.Hour
			min = dt.Minute
			sec = dt.Second
			ms = dt.Millisecond

			DrawClock(hour \ 10, digit)
			DrawClock(hour Mod 10, digit1)
			DrawClock(min \ 10, digit2)
			DrawClock(min Mod 10, digit3)
			DrawClock(sec \ 10, digit4)
			DrawClock(sec Mod 10, digit5)
		End Sub
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Me.timer1.Start()
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			Me.timer1.Stop()
		End Sub


		#End Region       
	End Class

End Namespace
