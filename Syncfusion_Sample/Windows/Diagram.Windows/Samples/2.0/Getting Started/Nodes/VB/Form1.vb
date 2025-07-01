Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports System.IO
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms.Tools
Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing
Imports System.Drawing.Imaging
Imports Syncfusion.SVG.IO
Imports Syncfusion.Windows.Forms

Namespace NodesDemo
	Partial Public Class Form1
		Inherits Form
		#Region "From Initialize"
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		   Me.diagram1.BeginUpdate()
		   InitializeDiagram()
		   DiagramAppearance()
		   Me.diagram1.EndUpdate()
		End Sub

		#End Region

		#Region "Private Methods"
	   ''' <summary>
	   ''' Change's the appearance of Diagram
	   ''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.Model.LineStyle.LineColor = Color.LightGray
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
			Me.diagram1.View.Grid.Visible = False
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			Me.diagram1.View.SelectionList.Clear()
		End Sub
	   #End Region

		#Region "Initialize the diagram"

		''' <summary>
		''' initializes the Diagram data  
		''' </summary>
		Private Sub InitializeDiagram()
			Dim rect As New Syncfusion.Windows.Forms.Diagram.Rectangle(100, 25, 120, 75)
			rect.FillStyle.Color = Color.FromArgb(240, 242, 240)
			rect.FillStyle.ForeColor = Color.White
			rect.FillStyle.Type = FillStyleType.LinearGradient
			rect.LineStyle.LineColor = Color.DarkGray
			AddLabel(rect, "Rectangle", Position.Center)
			diagram1.Model.AppendChild(rect)

			Dim roundRect As New Syncfusion.Windows.Forms.Diagram.RoundRect(400, 25, 120, 75, MeasureUnits.Pixel)
			roundRect.FillStyle.Color = Color.FromArgb(240, 242, 240)
			roundRect.FillStyle.ForeColor = Color.White
			roundRect.LineStyle.LineColor = Color.DarkGray
			roundRect.FillStyle.Type = FillStyleType.LinearGradient
			AddLabel(roundRect, "RoundRect1", Position.Center)
			diagram1.Model.AppendChild(roundRect)

			Dim ellipse1 As New Ellipse(100, 125, 120, 80)
			ellipse1.FillStyle.Color = Color.FromArgb(240, 242, 240)
			ellipse1.FillStyle.ForeColor = Color.White
			ellipse1.LineStyle.LineColor = Color.DarkGray
			ellipse1.FillStyle.Type = FillStyleType.LinearGradient
			AddLabel(ellipse1, "Ellipse", Position.Center)
			diagram1.Model.AppendChild(ellipse1)

			Dim poly As New Polygon(New PointF() { New PointF(160, 235), New PointF(100, 265), New PointF(120, 325), New PointF(200, 325), New PointF(220, 265) })
			poly.FillStyle.Color = Color.FromArgb(240, 242, 240)
			poly.FillStyle.ForeColor = Color.White
			poly.FillStyle.Type = FillStyleType.LinearGradient
			poly.LineStyle.LineColor = Color.DarkGray
			AddLabel(poly, "Polygon", Position.Center)
			diagram1.Model.AppendChild(poly)

			Dim semiCircle As New SemiCircle(400, 125, 120, 75)
			semiCircle.FillStyle.Color = Color.FromArgb(240, 242, 240)
			semiCircle.FillStyle.ForeColor = Color.White
			semiCircle.FillStyle.Type = FillStyleType.LinearGradient
			semiCircle.LineStyle.LineColor = Color.DarkGray
			AddLabel(semiCircle, "SemiCircle", Position.Center)
			diagram1.Model.AppendChild(semiCircle)

			Dim textNode As New TextNode("TextNode1", New RectangleF(400,245, 120,50))
			textNode.FontStyle.Size = 9
			textNode.FontStyle.Family = "Segoe UI"
			textNode.HorizontalAlignment = StringAlignment.Center
			textNode.VerticalAlignment = StringAlignment.Center
			textNode.LineStyle.LineColor = Color.DarkGray
			textNode.FontColorStyle.Color = Color.Black
			diagram1.Model.AppendChild(textNode)

			Dim richTextNode As New RichTextNode("{\rtf1\ansi\ansicpg1252\deff0\deflang1033{\fonttbl{\f0\fnil\fcharset0 Meiryo UI;}{\f1\fnil\fcharset0 Microsoft Sans Serif;}}" & ControlChars.CrLf & "{\colortbl ;\red255\green0\blue0;\red0\green64\blue128;}" & ControlChars.CrLf & "\viewkind4\uc1\pard\b\f0\fs17 This is a text symbol\f1  \b0\f0 designed using the \cf1\b\i Essential Diagram\i0  \cf2\ul RichText\ulnone  node\cf0\b0 .\par" & ControlChars.CrLf & "\i\f1\fs20\par" & ControlChars.CrLf & "}", New RectangleF(400, 320, 120, 100))
			richTextNode.LineStyle.LineColor = Color.DarkGray
			diagram1.Model.AppendChild(richTextNode)


			Dim bmpNode As New BitmapNode("..//..//Data//Penguins.jpg")
			bmpNode.Name = "BitmapNode1"
			bmpNode.PinPoint = New PointF(700, 75)
			bmpNode.Size = New SizeF(120, 100)
			bmpNode.LineStyle.LineWidth = 0
			diagram1.Model.AppendChild(bmpNode)

			Dim curve As New ClosedCurveNode(New PointF() { New PointF(120, 350), New PointF(120, 450), New PointF(220, 400) })
			curve.FillStyle.Color = Color.FromArgb(240, 242, 240)
			curve.FillStyle.ForeColor = Color.White
			curve.FillStyle.Type = FillStyleType.LinearGradient
			curve.LineStyle.LineColor = Color.DarkGray
			AddLabel(curve, "ClosedCurve", Position.Center)
			diagram1.Model.AppendChild(curve)

			Dim curve1 As New CurveNode(New PointF() { New PointF(120, 100), New PointF(120, 200), New PointF(220, 150) })
			curve1 = New CurveNode(New PointF() { New PointF(0, 30), New PointF(4.99999952f, 25), New PointF(18.3333321f, 0), New PointF(30, 0), New PointF(41.66666641f, 0), New PointF(58.33333321f, 30), New PointF(70, 30), New PointF(81.66666f, 30), New PointF(95, 4.99999952f), New PointF(100, 0) })
			AddLabel(curve1, "CurveNode", Position.Center)
			diagram1.Model.AppendChild(curve1)

			Dim circular As New CircularArc(New RectangleF(640, 150, 100, 100), 0, 270)
			circular.FillStyle.Color = Color.FromArgb(240, 242, 240)
			circular.FillStyle.ForeColor = Color.White
			circular.FillStyle.Type = FillStyleType.LinearGradient
			circular.LineStyle.LineColor = Color.DarkGray
			circular.PinPoint = New PointF(700, 200)
			AddLabel(circular, "CircularArc", Position.Center)
			diagram1.Model.AppendChild(circular)

			Dim line1 As New Line(New PointF(700, 320), New PointF(700, 430))
			line1.LineStyle.LineColor = Color.DarkGray
			AddLabel(line1, "line", Position.TopCenter)
			diagram1.Model.AppendChild(line1)

			Dim polyLine As New PolylineNode(New PointF() { New PointF(640, 500), New PointF(760, 500), New PointF(640, 540), New PointF(760, 540) })
			polyLine.LineStyle.LineColor = Color.DarkGray
			polyLine.LineStyle.LineWidth = 1
			Dim label As New Syncfusion.Windows.Forms.Diagram.Label(polyLine, "PolyLine Node")
			label.OffsetX = polyLine.BoundingRectangle.Width / 5f
			label.OffsetY = polyLine.BoundingRectangle.Height + 10
			label.FontStyle.Family = "Segoe UI"
			label.FontColorStyle.Color = Color.Black
			label.FontStyle.Size = 9
			polyLine.Labels.Add(label)
			diagram1.Model.AppendChild(polyLine)

			Dim bezier As New BezierCurve(New PointF() { New PointF(100, 470), New PointF(160, 470), New PointF(160, 560), New PointF(220, 560) })
			AddLabel(bezier, "BezierCurve", Position.BottomCenter)
			diagram1.Model.AppendChild(bezier)

			Dim spline As New SplineNode(New PointF() { New PointF(400, 460), New PointF(520, 500), New PointF(400, 520) })
			spline.LineStyle.LineColor = Color.Black
			spline.LineStyle.LineWidth = 1
			AddLabel(spline, "Spline", Position.BottomCenter)
			diagram1.Model.AppendChild(spline)

		End Sub
		#End Region

		#Region "Event Handlers"

		Private Sub rectToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rectToolStripButton.Click
			SetActiveTool("RectangleTool")
		End Sub

		Private Sub ellpToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ellpToolStripButton.Click
			SetActiveTool("EllipseTool")
		End Sub

		Private Sub rrectToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rrectToolStripButton.Click
			SetActiveTool("RoundRectTool")
		End Sub

		Private Sub polyToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles polyToolStripButton.Click
			SetActiveTool("PolygonTool")
		End Sub

		Private Sub semiStripButton12_Click(ByVal sender As Object, ByVal e As EventArgs) Handles semiStripButton12.Click
			SetActiveTool("SemiCircleTool")
		End Sub

		Private Sub carcToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles carcToolStripButton.Click
			Dim carc As New CircularArc(New RectangleF(300,300,100,70))
			' set your custom node to the NodeToInsert property
			Me.diagram1.Controller.NodeToInsert = carc
			SetActiveTool("InsertNodeTool")
		End Sub

		Private Sub bmpToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bmpToolStripButton.Click
			SetActiveTool("BitmapTool")
		End Sub

		Private Sub textToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles textToolStripButton.Click
			SetActiveTool("TextTool")
		End Sub

		Private Sub rchtxtToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rchtxtToolStripButton.Click
			SetActiveTool("RichTextTool")
		End Sub

		Private Sub lineToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lineToolStripButton.Click
			SetActiveTool("LineTool")
		End Sub

		Private Sub polylneToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles polylneToolStripButton.Click
			SetActiveTool("PolyLineTool")
		End Sub

		Private Sub curveToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles curveToolStripButton.Click
			SetActiveTool("CurveTool")
		End Sub

		Private Sub closdCurvToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles closdCurvToolStripButton.Click
			SetActiveTool("ClosedCurveTool")
		End Sub

		Private Sub splineToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles splineToolStripButton.Click
			SetActiveTool("SplineTool")
		End Sub

		Private Sub bezierToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bezierToolStripButton.Click
			SetActiveTool("BezierTool")
        End Sub
        Private Sub pencilToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pencilToolStripButton.Click
            SetActiveTool("PencilTool")
        End Sub

		Private Sub helpToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim targetURL As String = "http://help.syncfusion.com/"
			System.Diagnostics.Process.Start(targetURL)
		End Sub

		#End Region

		#Region "Helper Methods"
		''' <summary>
		''' Adds the label to the given node
		''' </summary>
		''' <param name="rect">Node</param>
		''' <param name="labelText">Label's Text</param>
		''' <param name="position">Label's position</param>
		Private Shared Sub AddLabel(ByVal rect As Syncfusion.Windows.Forms.Diagram.PathNode, ByVal labelText As String, ByVal position As Position)
			Dim label As New Syncfusion.Windows.Forms.Diagram.Label(rect, labelText)
			label.Position = position
			label.UpdatePosition = True
			label.FontStyle.Family = "Segoe UI"
			label.FontColorStyle.Color = Color.Black
			label.FontStyle.Size = 9
			rect.Labels.Add(label)
		End Sub

		Private Function GetColors() As List(Of String)
			'create a generic list of strings
			Dim colors As New List(Of String)()
			'get the color names from the Known color enum
			Dim colorNames() As String = System.Enum.GetNames(GetType(KnownColor))
			'iterate thru each string in the colorNames array
			For Each colorName As String In colorNames
				'cast the colorName into a KnownColor
				Dim knownColor As KnownColor = CType(System.Enum.Parse(GetType(KnownColor), colorName), KnownColor)
				'check if the knownColor variable is a System color
				If knownColor > KnownColor.Transparent Then
					'add it to our list
					colors.Add(colorName)
				End If
			Next colorName
			'return the color list
			Return colors
		End Function

		''' <summary>
		''' Activates the given tool
		''' </summary>
		''' <param name="toolName">Tool to be activated</param>
		Private Sub SetActiveTool(ByVal toolName As String)
			Me.diagram1.Controller.ActivateTool(toolName)
		End Sub

		#End Region   
    End Class
End Namespace

