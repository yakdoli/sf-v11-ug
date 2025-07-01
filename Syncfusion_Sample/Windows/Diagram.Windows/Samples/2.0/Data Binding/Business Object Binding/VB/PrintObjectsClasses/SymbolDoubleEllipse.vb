Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic

Imports System.Text
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing

Public Class SymbolDoubleEllipse
	Inherits Group
		Public Sub New()
			Dim ellipse As Syncfusion.Windows.Forms.Diagram.Ellipse
			ellipse = New Syncfusion.Windows.Forms.Diagram.Ellipse(0, 0, 15, 15)
			ellipse.FillStyle.Color = Color.Blue
			Me.AppendChild(ellipse)

			ellipse = New Syncfusion.Windows.Forms.Diagram.Ellipse(3, 3, 10, 10)
			ellipse.FillStyle.Color = Color.LightGray
			Me.AppendChild(ellipse)
			Me.EditStyle.AllowSelect = False
		End Sub
End Class
