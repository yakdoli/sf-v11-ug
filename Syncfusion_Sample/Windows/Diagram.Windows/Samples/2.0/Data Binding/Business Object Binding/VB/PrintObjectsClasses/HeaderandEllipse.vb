Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing
Public Class HeaderandEllipse
	Inherits Group

		Public Sub New(ByVal number As Integer, ByVal content As String, ByVal ContentColor As Color, ByVal Background As Color, ByVal fontsize As Integer)
			Dim rect As New RectangleF(55, 3, 140, 45)
			Dim txtContent As New TextNode(content,rect)
			txtContent.BackgroundStyle.Color = Color.LightBlue
			txtContent.LineStyle.LineWidth = 0
			txtContent.FontStyle.Size = fontsize
			txtContent.FontStyle.Bold = True
			txtContent.FontStyle.Italic = True
			txtContent.FontColorStyle.Color = ContentColor
			txtContent.ReadOnly = True
			txtContent.HorizontalAlignment = StringAlignment.Near
			txtContent.VerticalAlignment = StringAlignment.Center

			Dim numberEllipse As New Syncfusion.Windows.Forms.Diagram.Ellipse(5, 3, 35, 35)
			numberEllipse.FillStyle.Color = Color.White
			Dim lble As New Syncfusion.Windows.Forms.Diagram.Label()
			lble.Text = number.ToString()
			lble.SizeToNode = True
			lble.Position = Position.Center
			lble.FontStyle.Size = 12
			lble.FontStyle.Bold = True
			numberEllipse.Labels.Add(lble)

			Dim nodeRectBorder As New Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 200, 50)
			nodeRectBorder.FillStyle.Color = Background
			nodeRectBorder.LineStyle.LineWidth = 1
			'nodeRectBorder.EnableCentralPort = true;
			'numberEllipse.EnableCentralPort = true;
			'nodeRectHeader.EnableCentralPort = true;
			Me.AppendChild(nodeRectBorder)
			Me.AppendChild(numberEllipse)
			Me.AppendChild(txtContent)
			Me.EditStyle.AllowSelect = False
		End Sub
End Class