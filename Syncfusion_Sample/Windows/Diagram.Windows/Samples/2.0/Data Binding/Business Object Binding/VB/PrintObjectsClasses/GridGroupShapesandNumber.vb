Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing

Public Class GridGroupShapesandNumber
	Inherits Group
		Public Sub New(ByVal header As String, ByVal BackColor As Color)
			Dim rect As New RectangleF(0, 0, 240, 25)
			Dim headerRect As New TextNode(header, rect)
			headerRect.BackgroundStyle.Color = BackColor
			headerRect.LineStyle.LineWidth = 1
			headerRect.FontStyle.Size = 12
			headerRect.FontStyle.Bold = True
			headerRect.ReadOnly = True
			headerRect.HorizontalAlignment = StringAlignment.Center
			headerRect.VerticalAlignment = StringAlignment.Center

			Me.AppendChild(headerRect)
			Dim x As Integer = 0
			For i As Integer = 0 To 11
				rect = New RectangleF(x, 25, 20, 25)
				Dim numRect As New TextNode((i + 1).ToString(), rect)
				numRect.BackgroundStyle.Color = BackColor
				numRect.LineStyle.LineWidth = 1
				numRect.FontStyle.Size = 11
				numRect.FontStyle.Bold = False
				numRect.ReadOnly = True
				numRect.HorizontalAlignment = StringAlignment.Near
				numRect.VerticalAlignment = StringAlignment.Center
				x += 20

				Me.AppendChild(numRect)
			Next i
			Me.EditStyle.AllowSelect = False

		End Sub
End Class