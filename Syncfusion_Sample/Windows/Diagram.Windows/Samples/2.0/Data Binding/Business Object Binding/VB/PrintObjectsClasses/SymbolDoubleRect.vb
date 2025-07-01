Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Text
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing

 Public Class SymbolDoubleRect
	 Inherits Group
		Public Sub New()
			Dim rects As Syncfusion.Windows.Forms.Diagram.Rectangle
			rects = New Syncfusion.Windows.Forms.Diagram.Rectangle(15, 0, 10, 10)
			rects.FillStyle.Color = Color.Yellow
			rects.LineStyle.LineColor = Color.Black
			Me.AppendChild(rects)
			Dim rects1 As Syncfusion.Windows.Forms.Diagram.Rectangle
			rects1 = New Syncfusion.Windows.Forms.Diagram.Rectangle(5, 5, 10, 10)
			rects1.FillStyle.Color = Color.Yellow
			rects1.LineStyle.LineColor = Color.Black
			Me.AppendChild(rects1)
			Me.EditStyle.AllowSelect = False
		End Sub

 End Class