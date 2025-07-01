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

Namespace ConnectorsDemo
	Partial Public Class Form1
		Inherits Form
		#Region "Members"

		Private needSave As Boolean = False
		Public fileName As String

		#End Region

		#Region "Form Initialization"
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

		#Region "Initialize Diagram"

		''' <summary>
		''' Initializes the Diagram data  
		''' </summary>
		Private Sub InitializeDiagram()
			Dim line As New LineConnector(New PointF() { New PointF(320, 135), New PointF(480, 135) })
			line.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
			line.HeadDecorator.Size = New SizeF(10, 10)
			line.LineStyle.LineWidth = 1
			AddLabel(line, "DirectedLink", Position.BottomCenter)
			diagram1.Model.AppendChild(line)

			Dim orthogonalLine As New OrthogonalConnector(New PointF(50, 50), New PointF(245, 135))
			orthogonalLine.HeadDecorator.DecoratorShape = DecoratorShape.OpenFancyArrow
			orthogonalLine.HeadDecorator.Size = New SizeF(10, 10)
			orthogonalLine.TailDecorator.DecoratorShape = DecoratorShape.FilledFancyArrow
			orthogonalLine.TailDecorator.Size = New SizeF(10, 10)
			orthogonalLine.LineStyle.LineWidth = 1
			AddLabel(orthogonalLine, "OrthogonalLink", Position.BottomCenter)
			diagram1.Model.AppendChild(orthogonalLine)

			Dim orgLine As New OrgLineConnector(New PointF(245, 200), New PointF(50, 285))
			orgLine.HeadDecorator.DecoratorShape = DecoratorShape.FilledDiamond
			orgLine.HeadDecorator.Size = New SizeF(10, 10)
			orgLine.TailDecorator.DecoratorShape = DecoratorShape.Diamond
			orgLine.TailDecorator.Size = New SizeF(10, 10)
			orgLine.LineStyle.LineWidth = 1
			AddLabel(orgLine, "OrgLineLink", Position.BottomCenter)
			diagram1.Model.AppendChild(orgLine)

			Dim polyLine As New PolyLineConnector(New PointF() { New PointF(320, 225), New PointF(455, 225), New PointF(320, 265), New PointF(455, 265) })
			polyLine.HeadDecorator.DecoratorShape = DecoratorShape.Circle
			polyLine.HeadDecorator.Size = New SizeF(10, 10)
			polyLine.TailDecorator.DecoratorShape = DecoratorShape.FilledCircle
			polyLine.TailDecorator.Size = New SizeF(10, 10)
			polyLine.LineStyle.LineWidth = 1
			AddLabel(polyLine, "PloylineLink", Position.BottomCenter)
			diagram1.Model.AppendChild(polyLine)

			Dim spline As New SplineNode(New PointF() { New PointF(100, 400), New PointF(160, 430), New PointF(100, 480) })
			spline.HeadDecorator.DecoratorShape = DecoratorShape.FilledSquare
			spline.HeadDecorator.Size = New SizeF(10, 10)
			spline.TailDecorator.DecoratorShape = DecoratorShape.Square
			spline.TailDecorator.Size = New SizeF(10, 10)
			spline.LineStyle.LineWidth = 1
			AddLabel(spline, "Spline", Position.BottomCenter)
			diagram1.Model.AppendChild(spline)
		End Sub

		#End Region

		#Region "Event Handlers"

		Private Sub lineToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lineToolStripButton.Click
			SetActiveTool("LineLinkTool")
		End Sub

		Private Sub directLnToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles directLnToolStripButton.Click
			SetActiveTool("DirectedLineLinkTool")
		End Sub

		Private Sub orthoToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles orthoToolStripButton.Click
			SetActiveTool("OrthogonalLinkTool")
		End Sub

		Private Sub polyToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles polyToolStripButton.Click
			SetActiveTool("PolylineLinkTool")
		End Sub

		Private Sub splineToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles splineToolStripButton.Click
			SetActiveTool("SplineTool")
		End Sub

		Private Sub bezierToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bezierToolStripButton.Click
			SetActiveTool("BezierTool")
		End Sub


		Private Sub helpToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim targetURL As String = "http://help.syncfusion.com/"
			System.Diagnostics.Process.Start(targetURL)
		End Sub

		#End Region

		#Region "Helper Methods"
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

		''' <summary>
		''' Adds the Label to the given node.
		''' </summary>
		''' <param name="rect">Node</param>
		''' <param name="labelText">Label's Text</param>
		''' <param name="position">Label's Position</param>
		Private Shared Sub AddLabel(ByVal rect As Syncfusion.Windows.Forms.Diagram.PathNode, ByVal labelText As String, ByVal position As Position)
			Dim label As New Syncfusion.Windows.Forms.Diagram.Label(rect, labelText)
			label.Position = position
			label.UpdatePosition = True
			label.FontStyle.Family = "verdana"
			label.FontColorStyle.Color = Color.Black
			label.FontStyle.Size = 9
			rect.Labels.Add(label)
		End Sub

		''' <summary>
		''' Activate the given tool. 
		''' </summary>
		''' <param name="toolName">Tool to be activated</param>
		Private Sub SetActiveTool(ByVal toolName As String)
			Me.diagram1.Controller.ActivateTool(toolName)
		End Sub

		#End Region   
	End Class
End Namespace

