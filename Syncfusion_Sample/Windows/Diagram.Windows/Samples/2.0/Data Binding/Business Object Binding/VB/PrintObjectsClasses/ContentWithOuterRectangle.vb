Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing

Public Class ContentWithOuterRectangle
	Inherits Group
		Private units As MeasureUnits = MeasureUnits.Pixel
		Public Sub New(ByVal content As String, ByVal tip As String, ByVal BackColor As Color, ByVal tipBackColor As Color)
			Dim ContentEmpty As New Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 200, 10,units)
			ContentEmpty.FillStyle.Color = Color.Transparent
			ContentEmpty.LineStyle.LineWidth = 0
			Dim rect As New RectangleF(0, 15, 200, 45)

			Dim nodeRectHeader As New TextNode(content, rect)
			nodeRectHeader.EnableCentralPort = False
			nodeRectHeader.BackgroundStyle.Color = BackColor
			nodeRectHeader.BackgroundStyle.Color = Color.White
			nodeRectHeader.LineStyle.LineWidth = 1
			nodeRectHeader.FontStyle.Size = 10
			nodeRectHeader.ReadOnly = True
			nodeRectHeader.HorizontalAlignment = StringAlignment.Near
			nodeRectHeader.VerticalAlignment = StringAlignment.Near

			Dim roundrect As New Syncfusion.Windows.Forms.Diagram.RoundRect(ContentEmpty.Size.Width-20,0,40,15, units)
			roundrect.EnableCentralPort = False
			' Add an outer RoundRectangle.	
			roundrect.FillStyle.ForeColor = System.Drawing.Color.SkyBlue
			roundrect.LineStyle.LineColor = Color.FromArgb(253, 188, 140)
			roundrect.FillStyle.Color =tipBackColor
			roundrect.EnableShading = False

			Dim lblr As New Syncfusion.Windows.Forms.Diagram.Label()
			lblr.Text = tip
			lblr.SizeToNode = True
			lblr.Position = Position.Center
			lblr.FontStyle.Size = 14
			lblr.FontStyle.Bold = True
			roundrect.Labels.Add(lblr)
			Me.EnableCentralPort = True
			ContentEmpty.EnableCentralPort = True
			roundrect.EnableCentralPort = True
			Me.AppendChild(ContentEmpty)
			Me.AppendChild(nodeRectHeader)
			Me.AppendChild(roundrect)
			Me.EditStyle.AllowSelect = False
		End Sub
End Class
