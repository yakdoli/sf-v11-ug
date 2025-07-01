Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing

Public Class GridGroup
	Inherits Group

		Public Sub New()
			Dim nodeRectBorder As New Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 350, 50)
			nodeRectBorder.FillStyle.Color = Color.LightBlue
			nodeRectBorder.LineStyle.LineWidth = 1
			'Row1
			Dim rect As RectangleF
			rect = New RectangleF(0, 0, 70, 20)
			Dim r1c1 As New TextNode("Rev #", rect)
			r1c1.BackgroundStyle.Color = Color.Gray
			r1c1.FontColorStyle.Color = Color.White
			r1c1.LineStyle.LineWidth = 1
			r1c1.FontStyle.Size = 11
			r1c1.ReadOnly = True
			r1c1.HorizontalAlignment = StringAlignment.Center

			rect = New RectangleF(70, 0, 120, 20)
			Dim r1c2 As New TextNode("Revison Date", rect)
			r1c2.BackgroundStyle.Color = Color.Gray
			r1c2.FontColorStyle.Color = Color.White
			r1c2.LineStyle.LineWidth = 1
			r1c2.FontStyle.Size = 11
			r1c2.ReadOnly = True
			r1c2.HorizontalAlignment = StringAlignment.Center
			rect = New RectangleF(190, 0, 150, 20)
			Dim r1c3 As New TextNode("Reason", rect)
			r1c3.BackgroundStyle.Color = Color.Gray
			r1c3.FontColorStyle.Color = Color.White
			r1c3.LineStyle.LineWidth = 1
			r1c3.FontStyle.Size = 11
			r1c3.ReadOnly = True
			r1c3.HorizontalAlignment = StringAlignment.Center
			rect = New RectangleF(340, 0, 100, 20)
			Dim r1c4 As New TextNode("Who", rect)
			r1c4.BackgroundStyle.Color = Color.Gray
			r1c4.FontColorStyle.Color = Color.White
			r1c4.LineStyle.LineWidth = 1
			r1c4.FontStyle.Size = 11
			r1c4.ReadOnly = True
			r1c4.HorizontalAlignment = StringAlignment.Center
			'Row2
			rect = New RectangleF(0, 20, 70, 20)
			Dim r2c1 As New TextNode("", rect)
			r2c1.BackgroundStyle.Color = Color.White
			r2c1.LineStyle.LineWidth = 1
			r2c1.FontStyle.Size = 11


			rect = New RectangleF(70, 20, 120, 20)
			Dim r2c2 As New TextNode("", rect)
			r2c2.BackgroundStyle.Color = Color.White
			r2c2.LineStyle.LineWidth = 1
			r2c2.FontStyle.Size = 11


			rect = New RectangleF(190, 20, 150, 20)
			Dim r2c3 As New TextNode("", rect)
			r2c3.BackgroundStyle.Color = Color.White
			r2c3.LineStyle.LineWidth = 1
			r2c3.FontStyle.Size = 11


			rect = New RectangleF(340, 20, 100, 20)
			Dim r2c4 As New TextNode("", rect)
			r2c4.BackgroundStyle.Color = Color.White
			r2c4.LineStyle.LineWidth = 1
			r2c4.FontStyle.Size = 11

			'Row3
			rect = New RectangleF(0, 40, 70, 20)
			Dim r3c1 As New TextNode("", rect)
			r3c1.BackgroundStyle.Color = Color.White
			r3c1.LineStyle.LineWidth = 1
			r3c1.FontStyle.Size = 11


			rect = New RectangleF(70, 40, 120, 20)
			Dim r3c2 As New TextNode("", rect)
			r3c2.BackgroundStyle.Color = Color.White
			r3c2.LineStyle.LineWidth = 1
			r3c2.FontStyle.Size = 11


			rect = New RectangleF(190, 40, 150,20)
			Dim r3c3 As New TextNode("", rect)
			r3c3.BackgroundStyle.Color = Color.White
			r3c3.LineStyle.LineWidth = 1
			r3c3.FontStyle.Size = 11


			rect = New RectangleF(340, 40, 100, 20)
			Dim r3c4 As New TextNode("", rect)
			r3c4.BackgroundStyle.Color = Color.White
			r3c4.LineStyle.LineWidth = 1
			r3c4.FontStyle.Size = 11

			'Row4
			rect = New RectangleF(0, 60, 70, 20)
			Dim r4c1 As New TextNode("", rect)
			r4c1.BackgroundStyle.Color = Color.White
			r4c1.LineStyle.LineWidth = 1
			r4c1.FontStyle.Size = 11


			rect = New RectangleF(70, 60, 120, 20)
			Dim r4c2 As New TextNode("", rect)
			r4c2.BackgroundStyle.Color = Color.White
			r4c2.LineStyle.LineWidth = 1
			r4c2.FontStyle.Size = 11


			rect = New RectangleF(190, 60, 150, 20)
			Dim r4c3 As New TextNode("", rect)
			r4c3.BackgroundStyle.Color = Color.White
			r4c3.LineStyle.LineWidth = 1
			r4c3.FontStyle.Size = 11


			rect = New RectangleF(340, 60, 100, 20)
			Dim r4c4 As New TextNode("", rect)
			r4c4.BackgroundStyle.Color = Color.White
			r4c4.LineStyle.LineWidth = 1
			r4c4.FontStyle.Size = 11

			Me.AppendChild(r1c1)
			Me.AppendChild(r1c2)
			Me.AppendChild(r1c3)
			Me.AppendChild(r1c4)
			Me.AppendChild(r2c1)
			Me.AppendChild(r2c2)
			Me.AppendChild(r2c3)
			Me.AppendChild(r2c4)
			Me.AppendChild(r3c1)
			Me.AppendChild(r3c2)
			Me.AppendChild(r3c3)
			Me.AppendChild(r3c4)
			Me.AppendChild(r4c1)
			Me.AppendChild(r4c2)
			Me.AppendChild(r4c3)
			Me.AppendChild(r4c4)
			Me.EditStyle.AllowSelect = False

		End Sub

End Class