Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Text
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing

	Public Class HeaderRectanglePlan
		Inherits Group
		Public Sub New()
			Dim MainRect As New Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 200, 150)
			MainRect.FillStyle.Color = Color.White
			MainRect.LineStyle.LineColor = Color.Black

			Dim HeadContent As New Syncfusion.Windows.Forms.Diagram.Rectangle(MainRect.BoundingRectangle.Width \ 2 - 50, -10, 100, 20)
			HeadContent.FillStyle.Color = Color.LightYellow
			Dim lbl As New Syncfusion.Windows.Forms.Diagram.Label()
			lbl.Text = "Plan"
			lbl.SizeToNode = True
			lbl.Position = Position.Center
			lbl.FontStyle.Size = 12
			lbl.FontStyle.Bold = True
			HeadContent.Labels.Add(lbl)
			Me.AppendChild(MainRect)
			Me.AppendChild(HeadContent)

			Dim rects As Syncfusion.Windows.Forms.Diagram.Rectangle
			rects = New Syncfusion.Windows.Forms.Diagram.Rectangle(15, 30, 10, 10)
			rects.FillStyle.Color = Color.Yellow
			rects.LineStyle.LineColor = Color.Black
			Me.AppendChild(rects)

			rects = New Syncfusion.Windows.Forms.Diagram.Rectangle(20, 35, 10, 10)
			rects.FillStyle.Color = Color.Yellow
			rects.LineStyle.LineColor = Color.Black
			Me.AppendChild(rects)

			Dim rect As New RectangleF(40, 30, 150, 25)
			Dim txtContent As New TextNode("-Planning", rect)
			txtContent.BackgroundStyle.Color = Color.Transparent
			txtContent.LineStyle.LineWidth = 0
			txtContent.FontStyle.Size = 10
			txtContent.ReadOnly = True
			txtContent.HorizontalAlignment = StringAlignment.Near
			txtContent.VerticalAlignment = StringAlignment.Center
			Me.AppendChild(txtContent)

			Dim pts() As PointF = { New PointF(25, 5), New PointF(5, 5), New PointF(15, 15) }
			Dim triangle As New Syncfusion.Windows.Forms.Diagram.Polygon(pts)
			triangle.PinPoint = New PointF(15+ triangle.BoundingRectangle.Width \ 2, 65)
			triangle.FillStyle.Color = Color.White
			Me.AppendChild(triangle)

			rect = New RectangleF(40, 52.5f, 150, 25)
			txtContent = New TextNode("-Activity", rect)
			txtContent.BackgroundStyle.Color = Color.Transparent
			txtContent.LineStyle.LineWidth = 0
			txtContent.FontStyle.Size = 10
			txtContent.ReadOnly = True
			txtContent.HorizontalAlignment = StringAlignment.Near
			txtContent.VerticalAlignment = StringAlignment.Center
			Me.AppendChild(txtContent)


			pts = New PointF() { New PointF(15, 15), New PointF(0, 15), New PointF(5, 5), New PointF(10, 5), New PointF(10, 0), New PointF(15, 0) }
			Dim star As New Syncfusion.Windows.Forms.Diagram.PolylineNode(pts)
			star.PinPoint = New PointF(15 + triangle.BoundingRectangle.Width \ 2, 88)
			star.LineStyle.LineColor = Color.Black
			Me.AppendChild(star)

			rect = New RectangleF(40, 77.5f, 150, 25)
			txtContent = New TextNode("-StartUp", rect)
			txtContent.BackgroundStyle.Color = Color.Transparent
			txtContent.LineStyle.LineWidth = 0
			txtContent.FontStyle.Size = 10
			txtContent.ReadOnly = True
			txtContent.HorizontalAlignment = StringAlignment.Near
			txtContent.VerticalAlignment = StringAlignment.Center
			Me.AppendChild(txtContent)

			Dim ellipse As Syncfusion.Windows.Forms.Diagram.Ellipse
			ellipse = New Syncfusion.Windows.Forms.Diagram.Ellipse(18, 105, 15, 15)
			ellipse.FillStyle.Color = Color.Blue
			ellipse.LineStyle.LineWidth = 0
			Me.AppendChild(ellipse)

			ellipse = New Syncfusion.Windows.Forms.Diagram.Ellipse(20.5f, 107.5f, 10, 10)
			ellipse.FillStyle.Color = Color.Gray
			ellipse.LineStyle.LineWidth = 0
			Me.AppendChild(ellipse)

			rect = New RectangleF(40, 100, 150, 25)
			txtContent = New TextNode("-Cost Savings Sort", rect)
			txtContent.BackgroundStyle.Color = Color.Transparent
			txtContent.LineStyle.LineWidth = 0
			txtContent.FontStyle.Size = 10
			txtContent.ReadOnly = True
			txtContent.HorizontalAlignment = StringAlignment.Near
			txtContent.VerticalAlignment = StringAlignment.Center
			Me.AppendChild(txtContent)

			pts = New PointF() { New PointF(0, 5), New PointF(5, 5), New PointF(10, 0), New PointF(15, 5), New PointF(20, 5), New PointF(15, 10), New PointF(20, 15), New PointF(15, 15), New PointF(10, 20), New PointF(5, 15), New PointF(0, 15), New PointF(5, 10), New PointF(0, 5) }
			Dim star1 As New Syncfusion.Windows.Forms.Diagram.Polygon(pts)
			star1.PinPoint = New PointF(17 + star1.BoundingRectangle.Width \ 2, 140)
			star1.FillStyle.Color = Color.Gray
			Me.AppendChild(star1)

			rect = New RectangleF(40, 127, 150, 25)
			txtContent = New TextNode("-Evaluate & Close", rect)
			txtContent.BackgroundStyle.Color = Color.Transparent
			txtContent.LineStyle.LineWidth = 0
			txtContent.FontStyle.Size = 10
			txtContent.ReadOnly = True
			txtContent.HorizontalAlignment = StringAlignment.Near
			txtContent.VerticalAlignment = StringAlignment.Center
			Me.AppendChild(txtContent)
			Me.EditStyle.AllowSelect = False
		End Sub
	End Class