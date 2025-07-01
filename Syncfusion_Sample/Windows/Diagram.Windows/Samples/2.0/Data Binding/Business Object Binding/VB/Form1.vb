Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing.Imaging
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports System.Drawing.Drawing2D
Imports Syncfusion.Windows.Forms
Imports System.IO
Imports System.Drawing.Printing
Imports Syncfusion.SVG.IO
Imports DemoCommon.Diagram
Imports System.Xml
Imports System.Collections


Namespace BusinessObjectBinding
	Partial Public Class Form1
		Inherits DemoForm
		#Region "Members"
		Private m_x, m_y As Long
		Public Property x() As Long
			Get
				Return m_x
			End Get
			Set(ByVal value As Long)
				m_x = value
			End Set
		End Property
		Public Property y() As Long
			Get
				Return m_y
			End Get
			Set(ByVal value As Long)
				m_y = value
			End Set
		End Property
		Private lineconnector As Syncfusion.Windows.Forms.Diagram.OrthogonalConnector
		Private orthogoanlConnector As Syncfusion.Windows.Forms.Diagram.OrthogonalConnector
		#End Region

		#Region "Form Initialization"
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			diagram1.BeginUpdate()
			y = 0
			x = y
			Me.diagram1.Model.SizeToContent = True
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			DiagramAppearance()
			GenerateList("b1")
			CreateDiagram("b1")
			Me.diagram1.View.SelectionList.Clear()
			diagram1.EndUpdate()
		End Sub
		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Change's the appearance of Diagram
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.Model.LineStyle.LineColor = Color.LightGray
			Me.diagram1.View.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			Me.diagram1.View.BackgroundColor = Color.White
		End Sub
		#End Region

		#Region "Initialization of Diagram"
		''' <summary>
		''' Generation of content for the diagram.
		''' </summary>
		''' <param name="businessType">Type of the Business object</param>
		''' <returns></returns>
		Private Function GenerateList(ByVal businessType As String) As List(Of HoshinKanriListItem)
			Dim hoshinList As New List(Of HoshinKanriListItem)()

			Dim Content() As String = { "  Goal1", "  Goal2", "  Goal3", "  Goal4", "  Goal5" }
			Dim Content1() As String = { "  Objective1", "  Objective2", "  Objective3", "  Objective4", "  Objective5" }
			Dim SubContent() As String = { "  Key Task1" & Constants.vbCrLf & "  Key Task2", "  Key Task1" & Constants.vbCrLf & "  Key Task2" & Constants.vbCrLf & "  Key Task3", "  Key Task1", "  Key Task1", "  Key Task1" }
			Dim IsOuterRectangle() As String = { "false " & Constants.vbCrLf & " true", "false " & Constants.vbCrLf & " false " & Constants.vbCrLf & " true", "false", "false", "true" }
			Dim Leader() As String = { "Tom Ray " & Constants.vbCrLf & " Tom Ray ,N Wayman", "Don Gabil " & Constants.vbCrLf & " Tom Ray " & Constants.vbCrLf & " Mariesa", "Tom Ray", "Tom Ray", "Tom Ray" }
			Dim Investor() As String = { "  Resource1" & Constants.vbCrLf & "  Resource2", "  Resource1" & Constants.vbCrLf & "  Resource2" & Constants.vbCrLf & "  Resource3", "  Resource1", "  Resource1", "  Resource1" }
			Dim comments() As String = { "  Comments1" & Constants.vbCrLf & "  Comments2", "  Comments1" & Constants.vbCrLf & "  Comments2" & Constants.vbCrLf & "  Comments3", "  Comments1", "  Comments1", "  Comments1" }
			Dim costSaving() As String = { "$0.00 " & Constants.vbCrLf & " $0.00", "$0.00 " & Constants.vbCrLf & " $0.00 " & Constants.vbCrLf & " $0.00", "$0.00", "$0.00", "$0.00" }
			Dim toolTip() As String = { "  Tooltip1" & Constants.vbCrLf & "  Tooltip2", "  Tooltip1" & Constants.vbCrLf & "  Tooltip2" & Constants.vbCrLf & "  Tooltip3", "  Tooltip1", "  Tooltip1", "  Tooltip1" }

			Dim plan As New List(Of String())()
			Dim actual As New List(Of String())()
			Dim listIndex As Integer = 0
			plan.Add(New String() { "", "", "P-1", "", "", "P-1", "P-2", "", "", "", "", "" })
			plan.Add(New String() { "P-0", "P-1", "", "", "P-1", "P-1", "", "P-1", "P-2", "", "", "" })
			plan.Add(New String() { "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-4", "P-0" })
			plan.Add(New String() { "P-0", "P-0", "P-1", "", "P-2", "P-1", "P-4", "P-3", "P-2", "", "P-2", "P-0" })
			plan.Add(New String() { "P-1", "", "", "", "", "P-1", "P-1", "", "", "P-1", "P-4", "P-0" })
			plan.Add(New String() { "", "", "P-0", "P-1", "", "", "P-0", "P-4", "", "", "P-4", "" })
			plan.Add(New String() { "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-1", "P-4", "P-0" })
			plan.Add(New String() { "P-0", "P-0", "P-1", "P-1", "", "", "P-1", "P-2", "", "", "", "P-0" })

			actual.Add(New String() { "", "A-0", "A-0", "A-0", "A-0", "A-1", "A-1", "", "", "", "", "" })
			actual.Add(New String() { "A-0", "A-0", "A-0", "A-0", "A-0", "A-0", "A-0", "", "", "", "", "" })
			actual.Add(New String() { "A-0", "A-0", "A-0", "A-0", "A-0", "A-0", "A-0", "", "", "", "", "A-0" })
			actual.Add(New String() { "A-0", "A-0", "A-1", "A-1", "A-1", "A-1", "A-2", "A-3", "", "", "", "" })
			actual.Add(New String() { "", "", "", "", "", "", "", "", "", "", "", "" })
			actual.Add(New String() { "", "", "", "A-0", "A-0", "A-1", "A-1", "", "", "", "", "" })
			actual.Add(New String() { "A-0", "A-0", "A-0", "A-0", "A-0", "A-0", "A-0", "", "", "", "", "A-0" })
			actual.Add(New String() { "A-0", "A-0", "A-1", "A-1", "A-1", "A-1", "A-2", "", "", "", "", "A-0" })


			For i As Integer = 0 To Content.Length - 1
				Dim hoshinItem As New HoshinKanriListItem()
				hoshinItem.Content = Content(i)
				hoshinItem.Content1 = Content1(i)
				If SubContent(i).Contains(Constants.vbCrLf) Then
					Dim subContent1() As String = SubContent(i).Split(New String() { Constants.vbCrLf }, StringSplitOptions.None)
					Dim leader1() As String = Leader(i).Split(New String() { Constants.vbCrLf }, StringSplitOptions.None)
					Dim Investor1() As String = Investor(i).Split(New String() { Constants.vbCrLf }, StringSplitOptions.None)
					Dim comments1() As String = comments(i).Split(New String() { Constants.vbCrLf }, StringSplitOptions.None)
					Dim costSaving1() As String = costSaving(i).Split(New String() { Constants.vbCrLf }, StringSplitOptions.None)
					Dim toolTip1() As String = toolTip(i).Split(New String() { Constants.vbCrLf }, StringSplitOptions.None)
					Dim isOuterRectangle1() As String = IsOuterRectangle(i).Split(New String() { Constants.vbCrLf }, StringSplitOptions.None)
					For j As Integer = 0 To subContent1.Length - 1
						hoshinItem.SubContent.Add(subContent1(j))
						hoshinItem.Leader.Add(leader1(j))
						hoshinItem.Resources.Add(Investor1(j))
						hoshinItem.Comments.Add(comments1(j))
						hoshinItem.CostSavings.Add(costSaving1(j))
						hoshinItem.ToolTip.Add(toolTip1(j))
						hoshinItem.Plan.Add(plan(listIndex))
						hoshinItem.Actual.Add(actual(listIndex))
						hoshinItem.IsOuterRectangle.Add(Convert.ToBoolean(isOuterRectangle1(j)))
						listIndex += 1
					Next j
				Else
					hoshinItem.SubContent.Add(SubContent(i))
					hoshinItem.Leader.Add(Leader(i))
					hoshinItem.Resources.Add(Investor(i))
					hoshinItem.Comments.Add(comments(i))
					hoshinItem.CostSavings.Add(costSaving(i))
					hoshinItem.ToolTip.Add(toolTip(i))
					hoshinItem.Plan.Add(plan(listIndex))
					hoshinItem.Actual.Add(actual(listIndex))
					hoshinItem.IsOuterRectangle.Add(Convert.ToBoolean(IsOuterRectangle(i)))
					listIndex += 1
				End If
				hoshinList.Add(hoshinItem)
			Next i
			Return hoshinList
		End Function

		''' <summary>
		''' Creates the daigram 
		''' </summary>
		''' <param name="businessType">Type of the List to be added</param>
		Private Sub CreateDiagram(ByVal businessType As String)

			Dim rect As New RectangleF(10, 10, 1400, 60)
			Dim nodeRectHeader As New TextNode("Safety", rect)
			nodeRectHeader.BackgroundStyle.Color = Color.FromArgb(84, 167, 167)
			nodeRectHeader.LineStyle.LineWidth = 1
			nodeRectHeader.FontStyle.Size = 32
			nodeRectHeader.FontStyle.Bold = True
			nodeRectHeader.FontStyle.Italic = True
			nodeRectHeader.FontColorStyle.Color = Color.White
			nodeRectHeader.ReadOnly = True
			nodeRectHeader.HorizontalAlignment = StringAlignment.Near
			nodeRectHeader.VerticalAlignment = StringAlignment.Center
			nodeRectHeader.EditStyle.AllowSelect = False
			'FY10 goal is to  provide a safe working environment for our employees.Achieve this through improvement in the key categorie of severity and frequency rates.
			Dim erg As New EllipseRectGroup(1, "Vision", "Vision-1", Color.Red, Color.Black, Color.LightBlue, Color.White)
			Dim gg As New GridGroup()

			Dim he1 As New HeaderandEllipse(2, "Goals", Color.Red, Color.LightBlue, 13)
			Dim he2 As New HeaderandEllipse(3, "Objectives", Color.Red, Color.LightBlue, 13)
			Dim he3 As New HeaderandEllipse(4, "Key Tasks", Color.Red, Color.LightBlue, 12)

			Dim spc As New SplitContent("Who " & Constants.vbLf & "(leader)", "Resources Investor", Color.LightBlue, True, 12, True)
			Dim ggsn As New GridGroupShapesandNumber("Schedule(Month)", Color.LightBlue)
			Dim spc2 As New SplitContent("Comments", "Cost Savings", Color.LightBlue, True, 12, True)

			Dim nameIndex As Integer = 0
			Dim hoshinList As List(Of HoshinKanriListItem) = GenerateList(businessType)
			Dim contentPinPointY As Single = 400, splitContentPinpointY As Single = 400, gridSymbolPinpointY As Single = 390, subContentPinPointY As Single = 400
			For i As Integer = 0 To hoshinList.Count - 1
				Dim content As New ContentRectangle(hoshinList(i).Content, Color.Black, Color.LightGreen, False, 13, True)
				content.PinPoint = New PointF(10 + content.BoundingRectangle.Width \ 2, contentPinPointY + content.BoundingRectangle.Height \ 2)
				diagram1.Model.AppendChild(content)

				Dim content1 As New ContentRectangle(hoshinList(i).Content1, Color.Black, Color.LightGreen, False, 10, True)
				content1.PinPoint = New PointF(230 + content1.BoundingRectangle.Width \ 2, contentPinPointY + content1.BoundingRectangle.Height \ 2)
				diagram1.Model.AppendChild(content1)

				lineconnector = getLineConnectorOrdinary(content.PinPoint, content1.PinPoint)
				content.CentralPort.TryConnect(lineconnector.HeadEndPoint)
				content1.CentralPort.TryConnect(lineconnector.TailEndPoint)
				Me.diagram1.Model.AppendChild(lineconnector)

				For j As Integer = 0 To hoshinList(i).Leader.Count - 1
					Dim splitContent As New SplitContent(hoshinList(i).Leader(j), hoshinList(i).Resources(j), Color.Gray, False, 10, False)
					splitContent.Name = "splitContent" & (nameIndex + 1)
					splitContent.PinPoint = New PointF(690 + splitContent.BoundingRectangle.Width \ 2, splitContentPinpointY + splitContent.BoundingRectangle.Height \ 2)
					diagram1.Model.AppendChild(splitContent)

					Dim gridSymbol As New GridSymbols(hoshinList(i).Plan(j), hoshinList(i).Actual(j), hoshinList(i).ToolTip(j))
					gridSymbol.Name = "gridSymbol" & (nameIndex + 1)
					gridSymbol.PinPoint = New PointF(920 + gridSymbol.BoundingRectangle.Width \ 2, 2+gridSymbolPinpointY + gridSymbol.BoundingRectangle.Height \ 2)
					diagram1.Model.AppendChild(gridSymbol)

					Dim splitContent1 As New SplitContent(hoshinList(i).Comments(j), hoshinList(i).CostSavings(j), Color.LightGray, False, 10, False)
					splitContent1.Name = "splitContent1" & (nameIndex + 1)
					splitContent1.PinPoint = New PointF(1160 + splitContent1.BoundingRectangle.Width \ 2, splitContentPinpointY + splitContent1.BoundingRectangle.Height \ 2)
					diagram1.Model.AppendChild(splitContent1)

					If Not hoshinList(i).IsOuterRectangle(j) Then
						Dim subContent As New ContentRectangle(hoshinList(i).SubContent(j), Color.Black, Color.LightGreen, False, 10, True)
						subContent.PinPoint = New PointF(460 + subContent.BoundingRectangle.Width \ 2, subContentPinPointY + subContent.BoundingRectangle.Height \ 2)
						diagram1.Model.AppendChild(subContent)

						lineconnector = getLineConnectorOrdinary(content1.PinPoint, subContent.PinPoint)
						content1.CentralPort.TryConnect(lineconnector.TailEndPoint)
						subContent.CentralPort.TryConnect(lineconnector.HeadEndPoint)
						Me.diagram1.Model.AppendChild(lineconnector)

						lineconnector = getLineConnectorOrdinary(subContent.PinPoint, splitContent.PinPoint)
						splitContent.CentralPort.TryConnect(lineconnector.TailEndPoint)
						subContent.CentralPort.TryConnect(lineconnector.HeadEndPoint)
						Me.diagram1.Model.AppendChild(lineconnector)
					Else

						Dim subContent1 As New ContentWithOuterRectangle(hoshinList(i).SubContent(j), "A3", Color.LightGreen, Color.Pink)
						subContent1.PinPoint = New PointF(460 + subContent1.BoundingRectangle.Width \ 2, subContentPinPointY + subContent1.BoundingRectangle.Height \ 2 - 20)
						diagram1.Model.AppendChild(subContent1)

						orthogoanlConnector = getOrthogonalConnector(content1.PinPoint, subContent1.PinPoint)
						content1.CentralPort.TryConnect(orthogoanlConnector.TailEndPoint)
						subContent1.CentralPort.TryConnect(orthogoanlConnector.HeadEndPoint)
						Me.diagram1.Model.AppendChild(orthogoanlConnector)

						lineconnector = getLineConnectorOrdinary(subContent1.PinPoint, splitContent.PinPoint)
						splitContent.CentralPort.TryConnect(lineconnector.TailEndPoint)
						subContent1.CentralPort.TryConnect(lineconnector.HeadEndPoint)
						Me.diagram1.Model.AppendChild(lineconnector)
					End If
					nameIndex += 1
					'if (!hoshinList[i].IsOuterRectangle[j])
					'{
					'    contentPinPointY += 65;
					'    splitContentPinpointY += 65; gridSymbolPinpointY += 65; subContentPinPointY += 65;
					'}
					'else
					'{

					'}
					contentPinPointY += 85
					splitContentPinpointY += 85
					gridSymbolPinpointY += 85
					subContentPinPointY += 85
					'if (j < hoshinList[i].Leader.Count)
					'{
					'    if (hoshinList[i].IsOuterRectangle[j])
					'    {
					'        contentPinPointY += (120-85);
					'        splitContentPinpointY += (130 - 85); gridSymbolPinpointY += (130 - 85); subContentPinPointY += (120 - 85);
					'    }
					'}
				Next j
			Next i

			Dim actualrect As New HeaderRectangleActual()
			Dim planrect As New HeaderRectanglePlan()

			erg.PinPoint = New PointF(10 + erg.BoundingRectangle.Width \ 2, erg.BoundingRectangle.Height \ 2 + 120)
			erg.CentralPort.OffsetX = he1.PinPoint.X
			he1.PinPoint = New PointF(10 + he1.BoundingRectangle.Width \ 2, 330 + he1.BoundingRectangle.Height \ 2)
			he2.PinPoint = New PointF(230 + he2.BoundingRectangle.Width \ 2, 330 + he2.BoundingRectangle.Height \ 2)
			he3.PinPoint = New PointF(460 + he3.BoundingRectangle.Width \ 2, 330 + he3.BoundingRectangle.Height \ 2)
			spc.PinPoint = New PointF(690 + spc.BoundingRectangle.Width \ 2, 330 + spc.BoundingRectangle.Height \ 2)
			ggsn.PinPoint = New PointF(920 + ggsn.BoundingRectangle.Width \ 2, 330 + ggsn.BoundingRectangle.Height \ 2)
			spc2.PinPoint = New PointF(1160 + spc2.BoundingRectangle.Width \ 2, 330 + spc2.BoundingRectangle.Height \ 2)
			actualrect.PinPoint = New PointF(630 + actualrect.BoundingRectangle.Width \ 2, actualrect.BoundingRectangle.Height \ 2 + 103)
			planrect.PinPoint = New PointF(400 + planrect.BoundingRectangle.Width \ 2, planrect.BoundingRectangle.Height \ 2 + 103)
			gg.PinPoint = New PointF(900 + gg.BoundingRectangle.Width \ 2, gg.BoundingRectangle.Height \ 2 + 143)

			Me.diagram1.Model.AppendChild(erg)
			Me.diagram1.Model.AppendChild(gg)
			Me.diagram1.Model.AppendChild(ggsn)
			Me.diagram1.Model.AppendChild(he1)
			Me.diagram1.Model.AppendChild(he2)
			Me.diagram1.Model.AppendChild(he3)
			Me.diagram1.Model.AppendChild(spc)
			Me.diagram1.Model.AppendChild(spc2)

			Me.diagram1.Model.AppendChild(planrect)
			Me.diagram1.Model.AppendChild(actualrect)

			Me.diagram1.Model.AppendChild(nodeRectHeader)

			lineconnector = getLineConnector(erg.PinPoint, he1.PinPoint)
			erg.CentralPort.TryConnect(lineconnector.TailEndPoint)
			he1.CentralPort.TryConnect(lineconnector.HeadEndPoint)

			Me.diagram1.Model.AppendChild(lineconnector)

			lineconnector = getLineConnector(he1.PinPoint, he2.PinPoint)
			he1.CentralPort.TryConnect(lineconnector.TailEndPoint)
			he2.CentralPort.TryConnect(lineconnector.HeadEndPoint)
			Me.diagram1.Model.AppendChild(lineconnector)

			lineconnector = getLineConnector(he2.PinPoint, he3.PinPoint)
			he2.CentralPort.TryConnect(lineconnector.TailEndPoint)
			he3.CentralPort.TryConnect(lineconnector.HeadEndPoint)
			Me.diagram1.Model.AppendChild(lineconnector)

			lineconnector = getLineConnector(he3.PinPoint, spc.PinPoint)
			he3.CentralPort.TryConnect(lineconnector.TailEndPoint)
			spc.CentralPort.TryConnect(lineconnector.HeadEndPoint)
			Me.diagram1.Model.AppendChild(lineconnector)

		End Sub

		''' <summary>
		''' Returns the Line Connector with Decorator.
		''' </summary>
		''' <param name="p1">Start Point</param>
		''' <param name="p2">End Point</param>
		''' <returns></returns>
		Private Function getLineConnector(ByVal p1 As PointF, ByVal p2 As PointF) As Syncfusion.Windows.Forms.Diagram.OrthogonalConnector
			Dim lineconnector As New Syncfusion.Windows.Forms.Diagram.OrthogonalConnector(p1, p2)
			lineconnector.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
			lineconnector.LineStyle.LineColor = Color.Black
			lineconnector.HeadDecorator.FillStyle.Color = Color.Black
			lineconnector.HeadDecorator.Size = New SizeF(10, 10)
			Return lineconnector
		End Function

		''' <summary>
		''' Returns the Line Connector
		''' </summary>
		''' <param name="p1">Start Point</param>
		''' <param name="p2">End Point</param>
		''' <returns></returns>
		Private Function getLineConnectorOrdinary(ByVal p1 As PointF, ByVal p2 As PointF) As Syncfusion.Windows.Forms.Diagram.OrthogonalConnector
			Dim lineconnector As New Syncfusion.Windows.Forms.Diagram.OrthogonalConnector(p1, p2)
			lineconnector.LineStyle.LineColor = Color.Black
			Return lineconnector
		End Function

		''' <summary>
		''' Returns the Orthogonal Connector
		''' </summary>
		''' <param name="p1">Start Point</param>
		''' <param name="p2">End Point</param>
		''' <returns></returns>
		Private Function getOrthogonalConnector(ByVal p1 As PointF, ByVal p2 As PointF) As Syncfusion.Windows.Forms.Diagram.OrthogonalConnector
			Dim lineconnector As New Syncfusion.Windows.Forms.Diagram.OrthogonalConnector(p1, p2)
			lineconnector.LineStyle.LineColor = Color.Black
			Return lineconnector
		End Function
		#End Region        

	End Class

End Namespace
