Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing

	Public Class EllipseRectGroup
		Inherits Group

		Public Sub New(ByVal number As Integer, ByVal header As String, ByVal content As String, ByVal HeaderColor As Color, ByVal ContentColor As Color, ByVal HeaderBackColor As Color, ByVal ContentBackColor As Color)

			Dim rect As New RectangleF(55, 3, 290, 45)
			Dim nodeRectHeader As New TextNode(header, rect)
			nodeRectHeader.BackgroundStyle.Color = HeaderBackColor
			nodeRectHeader.LineStyle.LineWidth = 0
			nodeRectHeader.FontStyle.Size = 14
			nodeRectHeader.FontStyle.Bold = False
			nodeRectHeader.FontStyle.Italic = True
			nodeRectHeader.FontColorStyle.Color = HeaderColor
			nodeRectHeader.ReadOnly = True
			nodeRectHeader.HorizontalAlignment = StringAlignment.Near
			nodeRectHeader.VerticalAlignment = StringAlignment.Center

			rect = New RectangleF(0, 50, 350, 90)
			Dim nodeRectContent As New TextNode(content, rect)
			nodeRectContent.BackgroundStyle.Color = ContentBackColor
			nodeRectContent.LineStyle.LineWidth = 1
			nodeRectContent.FontStyle.Size = 11
			nodeRectContent.FontStyle.Bold = False
			nodeRectContent.FontColorStyle.Color = ContentColor
			nodeRectContent.ReadOnly = True

			Dim numberEllipse As New Syncfusion.Windows.Forms.Diagram.Ellipse(5, 3, 35, 35)
			numberEllipse.FillStyle.Color = Color.White
			Dim lble As New Syncfusion.Windows.Forms.Diagram.Label()
			lble.Text = number.ToString()
			lble.SizeToNode = True
			lble.Position = Position.Center
			lble.FontStyle.Size = 12
			lble.FontStyle.Bold = True
			numberEllipse.Labels.Add(lble)
			Dim nodeRectBorder As New Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 350, 50)
			nodeRectBorder.FillStyle.Color = Color.LightBlue
			nodeRectBorder.LineStyle.LineWidth = 1

			Me.AppendChild(nodeRectBorder)
			Me.AppendChild(numberEllipse)
			Me.AppendChild(nodeRectHeader)
			Me.AppendChild(nodeRectContent)
			Me.EditStyle.AllowSelect = False
		End Sub
	End Class