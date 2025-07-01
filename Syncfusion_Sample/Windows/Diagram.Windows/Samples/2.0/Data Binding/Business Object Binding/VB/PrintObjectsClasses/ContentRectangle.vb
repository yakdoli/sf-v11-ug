Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Text
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing

	Public Class ContentRectangle
		Inherits Group
		Public Sub New(ByVal content As String, ByVal ForeColor As Color, ByVal BackColor As Color, ByVal bold As Boolean, ByVal fontsize As Integer, ByVal type As Boolean)
			Dim rect As RectangleF
			If type Then
				rect = New RectangleF(0, 0, 180, 45)
			Else
				rect = New RectangleF(0, 0, 200, 45)
			End If
			Dim ContentOne As New TextNode(content, rect)
			ContentOne.BackgroundStyle.Color = BackColor
			ContentOne.BackgroundStyle.Color = Color.White
			ContentOne.FontColorStyle.Color = ForeColor
			ContentOne.LineStyle.LineWidth = 1
			ContentOne.FontStyle.Size = fontsize
			ContentOne.FontStyle.Bold = bold
			ContentOne.ReadOnly = True
			ContentOne.HorizontalAlignment = StringAlignment.Near
			ContentOne.VerticalAlignment = StringAlignment.Near
			ContentOne.EnableCentralPort = False
			Me.AppendChild(ContentOne)
			'this.EditStyle.AllowSelect = false;
		End Sub
	End Class

