Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Drawing.Imaging

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Drawing

Namespace PivotGridLibrary
	Public Class IconDrawingSupport

		Private Shared iconPainter As GridIconPaint

		Shared Sub New()
			iconPainter = New GridIconPaint("PivotGridControl.", GetType(IconDrawingSupport).Assembly)
		End Sub

		Public Shared Sub DrawImage(ByVal g As Graphics, ByVal imageFileName As String, ByVal rect As Rectangle, ByVal offSet As Point)
			Dim prefix As String = "icons." 'folder in project where the bitmaps are located
			Dim bitmapName As String = prefix & imageFileName

			iconPainter.PaintIcon(g, rect, offSet, bitmapName, Color.Black)
		End Sub
	End Class

End Namespace
