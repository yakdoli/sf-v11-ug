Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing


	Public Class HeaderRectangleActual
		Inherits Group
		Public Sub New()
			Dim MainRect As New Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 200, 150)
			MainRect.FillStyle.Color = Color.White
			MainRect.LineStyle.LineColor = Color.Black

			Dim HeadContent As New Syncfusion.Windows.Forms.Diagram.Rectangle(MainRect.BoundingRectangle.Width\2-50, -10, 100, 20)
			HeadContent.FillStyle.Color = Color.LightYellow
			Dim lbl As New Syncfusion.Windows.Forms.Diagram.Label()
			lbl.Text = "Actual"
			lbl.SizeToNode = True
			lbl.Position = Position.Center
			lbl.FontStyle.Size = 12
			lbl.FontStyle.Bold = True
			HeadContent.Labels.Add(lbl)
			Me.AppendChild(MainRect)
			Me.AppendChild(HeadContent)

			Dim ellipse As Syncfusion.Windows.Forms.Diagram.Ellipse
			ellipse = New Syncfusion.Windows.Forms.Diagram.Ellipse(10, 40, 15, 15)
			ellipse.FillStyle.Color = Color.Green

			Dim rect As New RectangleF(30, 35, 150, 25)
			Dim txtContent As New TextNode("=OnSchedule", rect)
			txtContent.BackgroundStyle.Color = Color.Transparent
			txtContent.LineStyle.LineWidth = 0
			txtContent.FontStyle.Size = 10
			txtContent.ReadOnly = True
			txtContent.HorizontalAlignment = StringAlignment.Near
			txtContent.VerticalAlignment = StringAlignment.Center
			Me.AppendChild(txtContent)
			Me.AppendChild(ellipse)

			ellipse = New Syncfusion.Windows.Forms.Diagram.Ellipse(10, 70, 15, 15)
			ellipse.FillStyle.Color = Color.Yellow

			rect = New RectangleF(30, 65, 150, 25)
			txtContent = New TextNode("=Behind Schedule", rect)
			txtContent.BackgroundStyle.Color = Color.Transparent
			txtContent.LineStyle.LineWidth = 0
			txtContent.FontStyle.Size = 10
			txtContent.ReadOnly = True
			txtContent.HorizontalAlignment = StringAlignment.Near
			txtContent.VerticalAlignment = StringAlignment.Center
			Me.AppendChild(txtContent)
			Me.AppendChild(ellipse)

			ellipse = New Syncfusion.Windows.Forms.Diagram.Ellipse(10, 100, 15, 15)
			ellipse.FillStyle.Color = Color.Red

			rect = New RectangleF(30, 95, 150, 25)
			txtContent = New TextNode("=Critically Behind", rect)
			txtContent.BackgroundStyle.Color = Color.Transparent
			txtContent.LineStyle.LineWidth = 0
			txtContent.FontStyle.Size = 10
			txtContent.ReadOnly = True
			txtContent.HorizontalAlignment = StringAlignment.Near
			txtContent.VerticalAlignment = StringAlignment.Center
			Me.AppendChild(txtContent)
			Me.AppendChild(ellipse)

			ellipse = New Syncfusion.Windows.Forms.Diagram.Ellipse(10, 130, 15, 15)
			ellipse.FillStyle.Color = Color.Blue

			rect = New RectangleF(30, 125, 120, 25)
			txtContent = New TextNode("=Complete", rect)
			txtContent.BackgroundStyle.Color = Color.Transparent
			txtContent.LineStyle.LineWidth = 0
			txtContent.FontStyle.Size = 10
			txtContent.ReadOnly = True
			txtContent.HorizontalAlignment = StringAlignment.Near
			txtContent.VerticalAlignment = StringAlignment.Center
			Me.AppendChild(txtContent)
			Me.AppendChild(ellipse)
			Me.EditStyle.AllowSelect = False
		End Sub
	End Class