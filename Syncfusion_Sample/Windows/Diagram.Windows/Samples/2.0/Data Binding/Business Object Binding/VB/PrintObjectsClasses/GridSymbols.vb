Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Text
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing
Public Class GridSymbols
	Inherits Group
		Public Sub New(ByVal plan() As String, ByVal actual() As String, ByVal tip As String)
			Dim x As Integer = 0
			For i As Integer = 0 To 11
				Dim numRect As New Syncfusion.Windows.Forms.Diagram.Rectangle(x, 0, 20, 25f)
				numRect.FillStyle.Color = Color.White
				Me.AppendChild(numRect)

				Select Case plan(i)
					Case "P-0"
						Dim symbol As New SymbolDoubleRect()
						symbol.PinPoint = New PointF(x+symbol.BoundingRectangle.Width\2+2.5f,symbol.BoundingRectangle.Height\2 +2.5f)
						Me.AppendChild(symbol)
					Case "P-1"
						Dim triangle As Polygon = getTriangle()
						triangle.PinPoint = New PointF(x + triangle.BoundingRectangle.Width \ 2, triangle.BoundingRectangle.Height \ 2 + 5f)
						Me.AppendChild(triangle)
					Case "P-2"
						Dim poly As PolylineNode = getPolyLine()
						poly.PinPoint = New PointF(x + poly.BoundingRectangle.Width \ 2, poly.BoundingRectangle.Height \ 2 + 2.5f)
						Me.AppendChild(poly)
					Case "P-3"
						Dim dcircle As New SymbolDoubleEllipse()
						dcircle.PinPoint = New PointF(x + dcircle.BoundingRectangle.Width \ 2, dcircle.BoundingRectangle.Height \ 2 + 2.5f)
						Me.AppendChild(dcircle)
					Case "P-4"
						Dim star As Polygon = getStar()
						star.PinPoint = New PointF(x + star.BoundingRectangle.Width \ 2, star.BoundingRectangle.Height \ 2 + 2.5f)
						Me.AppendChild(star)

				End Select
				x += 20
			Next i

			x = 0
			For i As Integer = 0 To 11
				Dim numRect As New Syncfusion.Windows.Forms.Diagram.Rectangle(x, 25f, 20, 25f)
				numRect.FillStyle.Color = Color.White
				Me.AppendChild(numRect)

				Select Case actual(i)
					Case "A-0"
						Dim green As Ellipse = getEllipse(x+3,-45f,Color.Green)
						Me.AppendChild(green)
					Case "A-1"
						Dim yellow As Ellipse = getEllipse(x + 3, -45f, Color.Yellow)
						Me.AppendChild(yellow)
					Case "A-2"
						Dim red As Ellipse = getEllipse(x + 3, -45f, Color.Red)
						Me.AppendChild(red)
					Case "A-3"
						Dim blue As Ellipse = getEllipse(x + 3, -45f, Color.Blue)
						Me.AppendChild(blue)
				End Select
				x += 20

			Next i
			Dim HeadContent As New Syncfusion.Windows.Forms.Diagram.Rectangle(100, -4, 100, 8)
			HeadContent.FillStyle.Color = Color.LightYellow
			Dim lbl As New Syncfusion.Windows.Forms.Diagram.Label()
			lbl.Text = tip
			lbl.SizeToNode = True
			lbl.Position = Position.Center
			lbl.FontStyle.Size = 10
			HeadContent.Labels.Add(lbl)
			Me.AppendChild(HeadContent)
			Me.EditStyle.AllowSelect = False
		End Sub
		Private Function getEllipse(ByVal x As Single, ByVal y As Single, ByVal color As Color) As Ellipse
			Dim Ellipse As New Syncfusion.Windows.Forms.Diagram.Ellipse(x,y+75f,15, 15)
			Ellipse.FillStyle.Color = color
			Return Ellipse
		End Function
		Private Function getStar() As Polygon
			Dim pts() As PointF = { New PointF(0, 5), New PointF(5, 5), New PointF(10, 0), New PointF(15, 5), New PointF(20, 5), New PointF(15, 10), New PointF(20, 15), New PointF(15, 15), New PointF(10, 20), New PointF(5, 15), New PointF(0, 15), New PointF(5, 10), New PointF(0, 5) }
			Dim star As New Syncfusion.Windows.Forms.Diagram.Polygon(pts)
			star.FillStyle.Color = Color.Gray
			Return star
		End Function
		Private Function getTriangle() As Polygon
			Dim pts() As PointF = { New PointF(25, 5), New PointF(5, 5), New PointF(15, 15) }
			Dim triangle As New Syncfusion.Windows.Forms.Diagram.Polygon(pts)
			triangle.FillStyle.Color = Color.White
			Return triangle
		End Function
		Private Function getPolyLine() As PolylineNode
			Dim pts() As PointF = { New PointF(15, 15), New PointF(0, 15), New PointF(5, 5), New PointF(10, 5), New PointF(10, 0), New PointF(15, 0) }
			Dim poly As New Syncfusion.Windows.Forms.Diagram.PolylineNode(pts)
			poly.LineStyle.LineColor = Color.Black
			Return poly
		End Function


End Class