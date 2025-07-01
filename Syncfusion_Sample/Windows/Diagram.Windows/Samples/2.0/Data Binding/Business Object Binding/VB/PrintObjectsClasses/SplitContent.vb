Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing

 Public Class SplitContent
	 Inherits Group
		Public Sub New(ByVal content1 As String, ByVal content2 As String, ByVal BackColor As Color, ByVal bold As Boolean, ByVal fontsize As Integer, ByVal IsHeader As Boolean)
			Dim rect As New RectangleF(0, 0, 115, 50)
			Dim ContentOne As New TextNode(content1, rect)
			ContentOne.BackgroundStyle.Color = BackColor
			ContentOne.BackgroundStyle.Color = Color.White
			ContentOne.LineStyle.LineWidth = 1
			ContentOne.FontStyle.Size = fontsize
			ContentOne.FontStyle.Bold = bold
			ContentOne.ReadOnly = True

			rect = New RectangleF(115, 0, 115, 50)
			Dim ContentTwo As New TextNode(content2, rect)
			ContentTwo.BackgroundStyle.Color = BackColor
			ContentTwo.BackgroundStyle.Color = Color.White
			ContentTwo.LineStyle.LineWidth = 1
			ContentTwo.FontStyle.Size = fontsize
			ContentTwo.FontStyle.Bold = bold
			ContentTwo.ReadOnly = True

			Me.AppendChild(ContentOne)
			Me.AppendChild(ContentTwo)
			Me.EditStyle.AllowSelect = False
		End Sub
 End Class