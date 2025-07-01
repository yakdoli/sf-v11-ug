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


Namespace SimpleDrillDown

	#Region "SymbolForGrandMother"
	Friend Class GrandMotherSymbolClass
		Inherits Group
		Public mod1 As Syncfusion.Windows.Forms.Diagram.Model
		Public mod2 As Syncfusion.Windows.Forms.Diagram.Model
		Public dig As Syncfusion.Windows.Forms.Diagram.Controls.Diagram
		Private mysymbolA As New WomanSymbolClass()
		Private mysymbolB As New WomanSymbolClass()
		Private mysymbolB1 As New ManSymbolClass()
		Private bmpnode As BitmapNode=Nothing


		Private GM As GrandMotherSymbolClass
		Private GMDaughter As New WomanSymbolClass()
		Private GMSon As New ManSymbolClass()
		Private mySymbolGirl As GirlSymbolClass
		Private mySymbolBoy As BoySymbolClass
		Private m_bExpanded As Boolean = True

		Public Sub New(ByVal diagram As Syncfusion.Windows.Forms.Diagram.Controls.Diagram, ByVal model1 As Syncfusion.Windows.Forms.Diagram.Model, ByVal model2 As Syncfusion.Windows.Forms.Diagram.Model)

			bmpnode = New BitmapNode(New Bitmap("..\..\images\image2_48.png"))
			bmpnode.Name = "Grand Mother"
			bmpnode.PinPoint = New Point(300, 180)
			bmpnode.LineStyle.LineWidth = 0
			Me.AppendChild(bmpnode)

			Me.dig = diagram

			Me.mod1 = model1
			Me.mod2 = model2
		End Sub
		Public Sub New(ByVal diagram As Syncfusion.Windows.Forms.Diagram.Controls.Diagram, ByVal model1 As Syncfusion.Windows.Forms.Diagram.Model, ByVal model2 As Syncfusion.Windows.Forms.Diagram.Model, ByVal Previous As Boolean)

			bmpnode = New BitmapNode(New Bitmap("..\..\images\prev.png"))
			bmpnode.LineStyle.LineWidth = 0
			bmpnode.PinPoint = New Point(300, 180)
			Me.AppendChild(bmpnode)

			Me.dig = diagram

			Me.mod1 = model1
			Me.mod2 = model2
		End Sub
		Public Sub New()
			bmpnode = New BitmapNode(New Bitmap("..\..\images\image2_48.png"))
			bmpnode.Name = "Grand Mother"
			bmpnode.LineStyle.LineWidth = 0
			Me.AppendChild(bmpnode)
		End Sub

		#Region "ExpandAndCollapse"


		'protected override 
		Protected Overrides Sub OnMouseDoubleClick(ByVal e As EventArgs)
			' Get node root.
			Dim diagramModel As Syncfusion.Windows.Forms.Diagram.Model = Me.Root
			If diagramModel IsNot Nothing Then
				' Begin model update.
				diagramModel.BeginUpdate()

				' If node is expanded collapse its, else expand.
				If m_bExpanded = False Then
					Me.ExpandSubNodes(True)
				Else
					Me.CollapseSubNodes(TryCast(Me, IGraphNode))
				End If

				diagramModel.EndUpdate()
			End If

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

		Public Sub CollapseSubNodes(ByVal thisNode As IGraphNode)
			'IGraphNode thisNode = this as IGraphNode;
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
							CollapseSubNodes(TryCast(node1, IGraphNode))

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
			If HasChild() Then
				' Set symbol shapes to indicate a collapsed state.
				m_bExpanded = False
			End If

		End Sub

		Private Function HasChild() As Boolean
			Return Me.EdgesLeaving.Count > 0
		End Function
		#End Region

		#Region "DrillDown"
		' DrillDown is implemented by just changing the diagram models
		Protected Overrides Sub OnMouseClick(ByVal e As EventArgs)
			Try
				Dim flag As Integer = 0
				' Get node root.
				Dim diagramModel As Syncfusion.Windows.Forms.Diagram.Model = Me.Root
				Dim node As Node = TryCast(TryCast(Me, IGraphNode), Node)

					If TypeOf node Is TextNode Then
						'|| node is MyGroup2 || node is MyGroup3)
						node.EditStyle.AllowSelect = False
					Else
						If flag = 0 Then
							Me.dig.Controller.SelectAll()
							Me.dig.Controller.Delete()
							Me.mod1.Nodes.Clear()
							flag = 1
						End If

						Dim txtnode1 As Syncfusion.Windows.Forms.Diagram.TextNode = New TextNode(" Coevals Diagram ")
						txtnode1.FontStyle.Size = 16
						txtnode1.FontStyle.Family = "Arial"
						txtnode1.FontStyle.Bold = True

						txtnode1.FontColorStyle.Color = Color.MidnightBlue
						txtnode1.LineStyle.LineColor = Color.Transparent
						txtnode1.SizeToText(New Size(1000, 1000))
						txtnode1.PinPoint = New PointF(335, 25)
						Me.dig.Model.AppendChild(txtnode1)

						Me.dig.Model.AppendChild(New HomeNode(Me.dig, Me.mod1, Me.mod2))

						' Grand Mother
						GM = New GrandMotherSymbolClass()
						GM.PinPoint = New PointF(305, 145)

						Me.dig.Model.AppendChild(GM)

						' GrandMothers Daiughter
						GMDaughter.PinPoint = New PointF(150, 200)
						Me.dig.Model.AppendChild(GMDaughter)

						' Connection b/w Grandma and her daughter
						ConnectNodes(GM, GMDaughter)

						' GrandMothers Son
						GMSon = New ManSymbolClass()
						GMSon.PinPoint = New PointF(450, 200)
						Me.dig.Model.AppendChild(GMSon)

						' Connection b/w Grandma and her Son
						ConnectNodes(GM, GMSon)



						' Boy
						Dim mySymbolBoy3 As New BoySymbolClass("Boys", Me.dig, Me.mod1, Me.mod2)
						mySymbolBoy3.Name = "Boys"
						mySymbolBoy3.PinPoint = New PointF(450, 290)

						'ToolTip
						Me.dig.Model.AppendChild(mySymbolBoy3)


						'mySymbolBoy3 = new MySymbol4Girl();                      

						' Connection b/w Father and his girl
						ConnectNodes(GMSon, mySymbolBoy3)

						' Girl
						mySymbolGirl = New GirlSymbolClass()
						mySymbolGirl.PinPoint = New PointF(370, 290)
						Me.dig.Model.AppendChild(mySymbolGirl)

						' Connection b/w Father and his girl
						ConnectNodes(GMSon, mySymbolGirl)

						' Girl
						mySymbolGirl = New GirlSymbolClass()
						mySymbolGirl.PinPoint = New PointF(520, 290)
						Me.dig.Model.AppendChild(mySymbolGirl)

						' Connection b/w Father and his girl
						ConnectNodes(GMSon, mySymbolGirl)

						' Mother Childerns
						' Girl
						mySymbolGirl = New GirlSymbolClass()
						mySymbolGirl.PinPoint = New PointF(150, 290)
						Me.dig.Model.AppendChild(mySymbolGirl)

						' Connection b/w Father and his girl
						ConnectNodes(GMDaughter, mySymbolGirl)

						' Girl
						Dim mySymbolGirl3 As New GirlSymbolClass("Girls", Me.dig, Me.mod1, Me.mod2)
						mySymbolGirl3.Name = "Girls"
						mySymbolGirl3.PinPoint = New PointF(220, 290)
						Me.dig.Model.AppendChild(mySymbolGirl3)

						' Connection b/w Mother and his girl
						ConnectNodes(GMDaughter, mySymbolGirl3)

						' Boy
						mySymbolBoy = New BoySymbolClass()
						mySymbolBoy.PinPoint = New PointF(280, 290)
						Me.dig.Model.AppendChild(mySymbolBoy)
						' Connection b/w Mother and his girl
						ConnectNodes(GMDaughter, mySymbolBoy)

						' Boy
						mySymbolBoy = New BoySymbolClass()
						mySymbolBoy.PinPoint = New PointF(90, 290)
						Me.dig.Model.AppendChild(mySymbolBoy)

						' Connection b/w Mother and his Boy
						ConnectNodes(GMDaughter, mySymbolBoy)


						Me.Nodes.Clear()
						Me.dig.View.SelectionList.Clear()

					End If

			Catch
			End Try
		End Sub



		Private Sub ConnectNodes(ByVal parentNode As Node, ByVal subNode As Node)
			If parentNode.CentralPort Is Nothing OrElse subNode.CentralPort Is Nothing Then
				Return
			End If

			Me.dig.Model.BeginUpdate()

			' Create links
			Dim pts() As PointF = { PointF.Empty, New PointF(0, 1) }
			Dim line As New OrthogonalConnector(pts(0), pts(1))
			line.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
			line.HeadDecorator.Size = New SizeF(7, 7)
			line.HeadDecorator.LineStyle.LineColor = Color.LightGray
			line.HeadDecorator.FillStyle.Color = Color.LightGray
			line.LineStyle.LineColor = Color.LightGray
			Me.dig.Model.AppendChild(line)
			parentNode.CentralPort.TryConnect(line.TailEndPoint)
			subNode.CentralPort.TryConnect(line.HeadEndPoint)
			Me.dig.Model.SendToBack(line)
			Me.dig.Model.EndUpdate()
		End Sub
		#End Region



	End Class
	#End Region
End Namespace
