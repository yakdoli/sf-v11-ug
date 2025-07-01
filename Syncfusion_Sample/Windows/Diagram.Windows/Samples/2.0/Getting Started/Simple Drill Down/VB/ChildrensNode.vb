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
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing
Imports System.Collections
Imports System.Runtime.Serialization
Imports System.Windows.Forms


Namespace SimpleDrillDown

	#Region "SymbolClassForMan"
	Friend Class ManSymbolClass
		Inherits Group
		Public rrect As Syncfusion.Windows.Forms.Diagram.RoundRect = Nothing
		Private bmpnode As BitmapNode = Nothing
		Public Sub New()

			bmpnode = New BitmapNode(New Bitmap("..\..\images\image3_48.png"))
			bmpnode.Name = "Father"
			bmpnode.LineStyle.LineWidth = 0
			bmpnode.PinPoint = New Point(305, 130)

			Me.AppendChild(bmpnode)

		End Sub

		Private m_bExpanded As Boolean = True

		#Region "ExpandAndCollapse"
		Protected Overrides Sub OnMouseDoubleClick(ByVal e As EventArgs)
			' Get node root.
			Dim diagramModel As Syncfusion.Windows.Forms.Diagram.Model = Me.Root

			' Begin model update.
			diagramModel.BeginUpdate()

			' If node is expanded collapse its, else expand.
			If m_bExpanded = False Then
				Me.ExpandSubNodes(True)
			Else
				Me.CollapseSubNodes(True)
			End If


			diagramModel.EndUpdate()


		End Sub
		Public Sub ExpandSubNodes(ByVal clickednode As Boolean)
			Dim thisNode As IGraphNode = TryCast(Me, IGraphNode)

			If thisNode IsNot Nothing Then
				Dim edgesLeaving As ICollection = thisNode.EdgesLeaving
				If edgesLeaving IsNot Nothing Then
					For Each curEdge As IGraphEdge In edgesLeaving
						' Get from IGraphEdge link.
						Dim outlink As ConnectorBase = TryCast(curEdge, ConnectorBase)

						If outlink IsNot Nothing Then
							 ' Set connected link as visible too.
							Dim node1 As Node = TryCast(outlink.ToNode, Node)
							If node1 IsNot Nothing Then
								' Set current symbol as invisible.
								node1.Visible = True
							End If

							outlink.Visible = True
						End If
					Next curEdge
				End If
			End If

			' If this symbol is node under mouse click set node state as 
			' expaned by make plus vertical line visibly.
			If clickednode AndAlso HasChild() Then
				' Set symbol shapes to indicate an expanded state.
				m_bExpanded = True
			End If
		End Sub

		Public Sub CollapseSubNodes(ByVal clickednode As Boolean)
			Dim thisNode As IGraphNode = TryCast(Me, IGraphNode)
			If thisNode IsNot Nothing Then
				Dim edgesLeaving As ICollection = thisNode.EdgesLeaving
				If edgesLeaving IsNot Nothing Then
					' Convert to collection of IGraphEdges type.
					For Each curEdge As IGraphEdge In edgesLeaving
						' Get from IGraphEdge link.
						Dim outlink As ConnectorBase = TryCast(curEdge, ConnectorBase)
						If outlink IsNot Nothing Then
							' Set connected link as invisible too.

							Dim node1 As Node = TryCast(outlink.ToNode, Node)
							If node1 IsNot Nothing Then
								' Set current symbol as invisible.
								node1.Visible = False
							End If

							outlink.Visible = False

						End If
					Next curEdge
				End If
			End If

			' If this symbol is node under mouse click set node state as 
			' expaned by make plus vertical line visibly.
			If clickednode AndAlso HasChild() Then
				' Set symbol shapes to indicate a collapsed state.
				m_bExpanded = False
			End If

		End Sub
		Private Function HasChild() As Boolean
			Return Me.EdgesLeaving.Count > 0
		End Function
		#End Region
	End Class
	#End Region

	#Region "SymbolClassForWoman"
	Friend Class WomanSymbolClass
		Inherits Group
		Private bmpnode As BitmapNode = Nothing

		Private m_bExpanded As Boolean = True

		Public Sub New()

			bmpnode = New BitmapNode(New Bitmap("..\..\images\image7_48.png"))
			bmpnode.Name = "Grand Mother"
			bmpnode.LineStyle.LineWidth = 0
			bmpnode.PinPoint = New Point(305, 130)

			Me.AppendChild(bmpnode)

		End Sub

		#Region "ExpandAndCollapse"
		Protected Overrides Sub OnMouseDoubleClick(ByVal e As EventArgs)

			' Get node root.
			Dim diagramModel As Syncfusion.Windows.Forms.Diagram.Model = Me.Root
			' Begin model update.
			diagramModel.BeginUpdate()

			' If node is expanded collapse its, else expand.
			If m_bExpanded = False Then
				Me.ExpandSubNodes(True)
			Else
				Me.CollapseSubNodes(True)
			End If

			diagramModel.EndUpdate()


		End Sub
		Public Sub ExpandSubNodes(ByVal clickednode As Boolean)
			Dim thisNode As IGraphNode = TryCast(Me, IGraphNode)

			If thisNode IsNot Nothing Then
				Dim edgesLeaving As ICollection = thisNode.EdgesLeaving
				If edgesLeaving IsNot Nothing Then
					For Each curEdge As IGraphEdge In edgesLeaving
						' Get from IGraphEdge link.
						Dim outlink As ConnectorBase = TryCast(curEdge, ConnectorBase)

						If outlink IsNot Nothing Then
							' Set connected link as visible too.
							Dim node1 As Node = TryCast(outlink.ToNode, Node)
							If node1 IsNot Nothing Then
								' Set current symbol as invisible.
								node1.Visible = True
							End If

							outlink.Visible = True
						End If
					Next curEdge
				End If
			End If

			' If this symbol is node under mouse click set node state as 
			' expaned by make plus vertical line visibly.
			If clickednode AndAlso HasChild() Then
				' Set symbol shapes to indicate an expanded state.
				m_bExpanded = True
			End If
		End Sub

		Public Sub CollapseSubNodes(ByVal clickednode As Boolean)
			Dim thisNode As IGraphNode = TryCast(Me, IGraphNode)
			If thisNode IsNot Nothing Then
				Dim edgesLeaving As ICollection = thisNode.EdgesLeaving
				If edgesLeaving IsNot Nothing Then
					' Convert to collection of IGraphEdges type.
					For Each curEdge As IGraphEdge In edgesLeaving
						' Get from IGraphEdge link.
						Dim outlink As ConnectorBase = TryCast(curEdge, ConnectorBase)
						If outlink IsNot Nothing Then
							' Set connected link as invisible too.

							Dim node1 As Node = TryCast(outlink.ToNode, Node)
							If node1 IsNot Nothing Then
								' Set current symbol as invisible.
								node1.Visible = False
							End If

							outlink.Visible = False

						End If
					Next curEdge
				End If
			End If

			' If this symbol is node under mouse click set node state as 
			' expaned by make plus vertical line visibly.
			If clickednode AndAlso HasChild() Then
				' Set symbol shapes to indicate a collapsed state.
				m_bExpanded = False
			End If

		End Sub
		Private Function HasChild() As Boolean
			Return Me.EdgesLeaving.Count > 0
		End Function
		#End Region
	End Class
	#End Region

	#Region "SymbolClassForGirlSymbol"
	Friend Class GirlSymbolClass
		Inherits Group
		Private bmpnode As BitmapNode = Nothing

		Public mod1 As Syncfusion.Windows.Forms.Diagram.Model
		Public mod2 As Syncfusion.Windows.Forms.Diagram.Model
		Public dig As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private tooltips As New ToolTip()
		Public Sub New()
			bmpnode = New BitmapNode(New Bitmap("..\..\images\image5_48.png"))
			bmpnode.Name = "Girl"
			bmpnode.LineStyle.LineWidth = 0
			bmpnode.PinPoint = New Point(305, 130)

			Me.AppendChild(bmpnode)

		End Sub

		Public Sub New(ByVal name As String, ByVal diagram As Syncfusion.Windows.Forms.Diagram.Controls.Diagram, ByVal model1 As Syncfusion.Windows.Forms.Diagram.Model, ByVal model2 As Syncfusion.Windows.Forms.Diagram.Model)
			bmpnode = New BitmapNode(New Bitmap("..\..\images\image5_48.png"))
			bmpnode.Name = name
			bmpnode.PinPoint = New Point(305, 130)
			bmpnode.LineStyle.LineWidth = 0
			Me.AppendChild(bmpnode)
			Me.dig = diagram

			Me.mod1 = model1
			Me.mod2 = model2
		End Sub

		Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
			MyBase.OnMouseEnter(e)

			Dim diagramModel As Syncfusion.Windows.Forms.Diagram.Model = Me.Root
			Dim thisNode As Node = TryCast(TryCast(Me, IGraphNode), Node)

			If thisNode.Name.ToString() = "Girls" Then
				tooltips.IsBalloon = True
				tooltips.SetToolTip(Me.dig, "Click Here!")
				tooltips.Active = True
			Else
				tooltips.Active = False
			End If
		End Sub

		Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
			MyBase.OnMouseLeave(e)
			tooltips.Active = False

		End Sub

		Protected Overrides Sub OnMouseClick(ByVal e As EventArgs)
			' Get node root.
			Dim diagramModel As Syncfusion.Windows.Forms.Diagram.Model = Me.Root
			Dim thisNode As Node = TryCast(TryCast(Me, IGraphNode), Node)

			If thisNode.Name.ToString() = "Girls" Then
				Me.dig.Controller.SelectAll()
				Me.dig.Controller.Delete()
				Me.mod1.Nodes.Clear()

				Dim txtnode1 As Syncfusion.Windows.Forms.Diagram.TextNode = New TextNode(" Coevals Diagram ")
				txtnode1.FontStyle.Size = 20
				txtnode1.FontStyle.Bold = True
				txtnode1.FontStyle.Family = "Segoe UI"
				txtnode1.LineStyle.LineColor = Color.Transparent
				txtnode1.SizeToText(New Size(1000, 1000))
				txtnode1.PinPoint = New PointF(335, 25)
				Me.dig.Model.AppendChild(txtnode1)

				Dim txtnode2 As Syncfusion.Windows.Forms.Diagram.TextNode = New TextNode("Friends!")
				txtnode2.FontStyle.Size = 8
				txtnode2.FontStyle.Family = "Segoe UI"
				txtnode2.LineStyle.LineColor = Color.Transparent
				txtnode2.PinPoint = New PointF(280, 150)
				txtnode1.SizeToText(New Size(1000, 1000))
				Me.dig.Model.AppendChild(txtnode2)

				Me.dig.Model.AppendChild(New HomeNode(Me.dig, Me.mod1, Me.mod2))

				Dim symbol1 As New GirlSymbolClass()
				symbol1.PinPoint = New PointF(280, 120)
				Me.dig.Model.AppendChild(symbol1)

				Dim symbol2 As New GirlSymbolClass()
				symbol2.PinPoint = New PointF(380, 180)
				Me.dig.Model.AppendChild(symbol2)

				Dim symbol3 As New GirlSymbolClass()
				symbol3.PinPoint = New PointF(380, 280)
				Me.dig.Model.AppendChild(symbol3)

				Dim symbol4 As New GirlSymbolClass()
				symbol4.PinPoint = New PointF(280, 320)
				Me.dig.Model.AppendChild(symbol4)

				Dim symbol5 As New GirlSymbolClass()
				symbol5.PinPoint = New PointF(180, 280)
				Me.dig.Model.AppendChild(symbol5)

				Dim symbol6 As New GirlSymbolClass()
				symbol6.PinPoint = New PointF(180, 180)
				Me.dig.Model.AppendChild(symbol6)

				' Grand Mother
				Dim gm As New GrandMotherSymbolClass(Me.dig, Me.mod1, Me.mod2, True)
				gm.PinPoint = New PointF(65, 30)
				gm.Size = New SizeF(20, 20)
				gm.LineStyle.LineColor = Color.Transparent
				Me.dig.Model.AppendChild(gm)

				ConnectNodes(symbol1, symbol2)
				ConnectNodes(symbol2, symbol3)
				ConnectNodes(symbol4, symbol3)
				ConnectNodes(symbol4, symbol5)
				ConnectNodes(symbol5, symbol6)
				ConnectNodes(symbol1, symbol6)
				Me.dig.View.SelectionList.Clear()
				Me.Nodes.Clear()
			End If
		End Sub
		Private Sub ConnectNodes(ByVal parentNode As Node, ByVal subNode As Node)
			If parentNode.CentralPort Is Nothing OrElse subNode.CentralPort Is Nothing Then
				Return
			End If

			Me.dig.Model.BeginUpdate()

			' Create links
			Dim pts() As PointF = { PointF.Empty, New PointF(0, 1) }
			Dim line As New OrthogonalConnector(pts(0), pts(1))
			line.HeadDecorator.FillStyle.Color = Color.Black
			line.LineStyle.LineColor = Color.LightGray
			Me.dig.Model.AppendChild(line)

			parentNode.CentralPort.TryConnect(line.TailEndPoint)
			subNode.CentralPort.TryConnect(line.HeadEndPoint)
			Me.dig.Model.SendToBack(line)
			Me.dig.Model.EndUpdate()
		End Sub


	End Class
	#End Region

	#Region "SymbolClassForBoys"
	Friend Class BoySymbolClass
		Inherits Group
		Private bmpnode As BitmapNode = Nothing

		Public mod1 As Syncfusion.Windows.Forms.Diagram.Model
		Public mod2 As Syncfusion.Windows.Forms.Diagram.Model
		Public dig As Syncfusion.Windows.Forms.Diagram.Controls.Diagram

		Private tooltips As New ToolTip()
		Public Sub New()
			bmpnode = New BitmapNode(New Bitmap("..\..\images\image6_48.png"))
			bmpnode.Name = "Boy"
			bmpnode.LineStyle.LineWidth = 0
			bmpnode.PinPoint = New Point(305, 130)

			Me.AppendChild(bmpnode)
		End Sub

		Public Sub New(ByVal name As String, ByVal diagram As Syncfusion.Windows.Forms.Diagram.Controls.Diagram, ByVal model1 As Syncfusion.Windows.Forms.Diagram.Model, ByVal model2 As Syncfusion.Windows.Forms.Diagram.Model)

			bmpnode = New BitmapNode(New Bitmap("..\..\images\image6_48.png"))
			bmpnode.Name = name
			bmpnode.PinPoint = New Point(305, 130)
			bmpnode.LineStyle.LineWidth = 0



			Me.AppendChild(bmpnode)
			Me.dig = diagram

			Me.mod1 = model1
			Me.mod2 = model2
		End Sub
		Protected Overrides Sub OnMouseEnter(ByVal e As EventArgs)
			MyBase.OnMouseEnter(e)

			Dim diagramModel As Syncfusion.Windows.Forms.Diagram.Model = Me.Root
			Dim thisNode As Node = TryCast(TryCast(Me, IGraphNode), Node)

			If thisNode.Name.ToString() = "Boys" Then
				tooltips.IsBalloon = True
				tooltips.SetToolTip(Me.dig, "Click Here!")
				tooltips.Active = True
			Else
				tooltips.Active = False
			End If
		End Sub

		Protected Overrides Sub OnMouseLeave(ByVal e As EventArgs)
			MyBase.OnMouseLeave(e)
			tooltips.Active = False

		End Sub
		Protected Overrides Sub OnMouseClick(ByVal e As EventArgs)
			' Get node root.
			Dim diagramModel As Syncfusion.Windows.Forms.Diagram.Model = Me.Root
			Dim thisNode As Node = TryCast(TryCast(Me, IGraphNode), Node)

			If thisNode.Name.ToString() = "Boys" Then
				Me.dig.Controller.SelectAll()
				Me.dig.Controller.Delete()
				Me.mod1.Nodes.Clear()


				Dim txtnode1 As Syncfusion.Windows.Forms.Diagram.TextNode = New TextNode(" Coevals Diagram ")
				txtnode1.FontStyle.Size = 20
				txtnode1.FontStyle.Bold = True
				txtnode1.FontStyle.Family = "Segoe UI"
				txtnode1.LineStyle.LineColor = Color.Transparent
				txtnode1.SizeToText(New Size(1000, 1000))
				txtnode1.PinPoint = New PointF(335, 25)
				Me.dig.Model.AppendChild(txtnode1)

				Dim txtnode2 As Syncfusion.Windows.Forms.Diagram.TextNode = New TextNode("Friends!")
				txtnode2.FontStyle.Size = 8
				txtnode2.FontStyle.Family = "Segoe UI"
				txtnode2.LineStyle.LineColor = Color.Transparent
				txtnode2.PinPoint = New PointF(280, 150)
				txtnode1.SizeToText(New Size(1000, 1000))
				Me.dig.Model.AppendChild(txtnode2)

				Me.dig.Model.AppendChild(New HomeNode(Me.dig, Me.mod1, Me.mod2))

				Dim symbol1 As New BoySymbolClass()
				symbol1.PinPoint = New PointF(280, 120)
				Me.dig.Model.AppendChild(symbol1)

				Dim symbol2 As New BoySymbolClass()
				symbol2.PinPoint = New PointF(380, 180)
				Me.dig.Model.AppendChild(symbol2)

				Dim symbol3 As New BoySymbolClass()
				symbol3.PinPoint = New PointF(380, 280)
				Me.dig.Model.AppendChild(symbol3)

				Dim symbol4 As New BoySymbolClass()
				symbol4.PinPoint = New PointF(280, 320)
				Me.dig.Model.AppendChild(symbol4)

				Dim symbol5 As New BoySymbolClass()
				symbol5.PinPoint = New PointF(180, 280)
				Me.dig.Model.AppendChild(symbol5)

				Dim symbol6 As New BoySymbolClass()
				symbol6.PinPoint = New PointF(180, 180)
				Me.dig.Model.AppendChild(symbol6)

				' Grand Mother
				Dim gm As New GrandMotherSymbolClass(Me.dig, Me.mod1, Me.mod2,True)
				gm.PinPoint = New PointF(65,30)
				gm.Size = New SizeF(20, 20)
				gm.LineStyle.LineColor = Color.Transparent
				Me.dig.Model.AppendChild(gm)


				ConnectNodes(symbol1, symbol2)
				ConnectNodes(symbol2, symbol3)
				ConnectNodes(symbol4, symbol3)
				ConnectNodes(symbol4, symbol5)
				ConnectNodes(symbol5, symbol6)
				ConnectNodes(symbol1, symbol6)
				Me.dig.View.SelectionList.Clear()
				Me.Nodes.Clear()

			End If
		End Sub
		Private Sub ConnectNodes(ByVal parentNode As Node, ByVal subNode As Node)
			If parentNode.CentralPort Is Nothing OrElse subNode.CentralPort Is Nothing Then
				Return
			End If

			Me.dig.Model.BeginUpdate()

			' Create links
			Dim pts() As PointF = { PointF.Empty, New PointF(0, 1) }
			Dim line As New OrthogonalConnector(pts(0), pts(1))
			line.HeadDecorator.FillStyle.Color = Color.LightGray
			line.LineStyle.LineColor = Color.LightGray

			Me.dig.Model.AppendChild(line)

			parentNode.CentralPort.TryConnect(line.TailEndPoint)
			subNode.CentralPort.TryConnect(line.HeadEndPoint)
			Me.dig.Model.SendToBack(line)
			Me.dig.Model.EndUpdate()
		End Sub
	End Class
	#End Region
End Namespace
