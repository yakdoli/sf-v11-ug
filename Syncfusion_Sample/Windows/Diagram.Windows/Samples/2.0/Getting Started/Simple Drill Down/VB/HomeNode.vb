Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2012"
' Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports Syncfusion.Windows.Forms.Diagram

Namespace SimpleDrillDown
	#Region "HomePage"
	Friend Class HomeNode
		Inherits Group
		Public homerect As Syncfusion.Windows.Forms.Diagram.Rectangle = Nothing
		Public mod1 As Syncfusion.Windows.Forms.Diagram.Model
		Public mod2 As Syncfusion.Windows.Forms.Diagram.Model
		Public dig As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private bmpnode As BitmapNode = Nothing
		Public Sub New()
			homerect = New Syncfusion.Windows.Forms.Diagram.Rectangle(30, 30, 80, 30)
			homerect.FillStyle.Color = System.Drawing.Color.RoyalBlue
			homerect.FillStyle.ForeColor = System.Drawing.Color.White
			Me.AppendChild(homerect)
		End Sub

		Public Sub New(ByVal diagram As Syncfusion.Windows.Forms.Diagram.Controls.Diagram, ByVal model1 As Syncfusion.Windows.Forms.Diagram.Model, ByVal model2 As Syncfusion.Windows.Forms.Diagram.Model)

			bmpnode = New BitmapNode(New Bitmap("..\..\images\house_48_hot(1).png"))
			bmpnode.Name = "Grand Mother"
			bmpnode.PinPoint = New Point(30, 30)
			bmpnode.Size = New SizeF(20, 20)
			bmpnode.LineStyle.LineWidth = 0
			Me.AppendChild(bmpnode)

			mod1 = model1
			mod2 = model2
			dig = diagram


		End Sub


		Protected Overrides Sub OnMouseClick(ByVal e As EventArgs)
			' Presents the Home page ( Model1 )

			Me.dig.Model = Me.mod1

			For Each node As Node In Me.mod1.Nodes
				If TypeOf node Is TextNode Then
					node.EditStyle.AllowSelect = False
				End If
				If node IsNot Nothing Then
					Me.dig.SelectAll()
					Me.dig.Controller.Delete()
					Me.mod1.Nodes.Clear()
					Exit For
				End If
			Next node
			Me.dig.Model.AppendChild(New GrandMotherSymbolClass(Me.dig, Me.mod1, Me.mod2))

			Dim txtnode1 As Syncfusion.Windows.Forms.Diagram.TextNode = New TextNode("Coevals Diagram ")
			txtnode1.FontStyle.Size = 16
			txtnode1.FontStyle.Family = "Segoe UI"
			txtnode1.FontStyle.Bold = True

			txtnode1.FontColorStyle.Color = Color.Black
			txtnode1.LineStyle.LineColor = Color.Transparent
			txtnode1.SizeToText(New Size(1000, 1000))
			txtnode1.PinPoint = New PointF(300, 25)
			Me.dig.Model.AppendChild(txtnode1)

			Me.dig.View.SelectionList.Clear()
			Me.Nodes.Clear()
		End Sub
	End Class
	#End Region
End Namespace
