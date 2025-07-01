Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Collections
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports Syncfusion.Windows.Forms.Tools
Imports System.Drawing.Drawing2D
Imports System.IO
Imports Syncfusion.SVG.IO
Imports System.Drawing.Imaging
Imports Syncfusion.Windows.Forms

Namespace Network_Diagram
	Partial Public Class Form1
		Inherits Form
		#Region "Members"
		Private needSave As Boolean = False
		Public fileName As String
		#End Region

		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
			Me.diagram1.BeginUpdate()
			paletteGroupBar1.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\NetworkSymbols.edp")
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			GroupBarAppearance()
			InitailizeDiagram()
			Me.diagram1.View.SelectionList.Clear()
			comboLayers.SelectedIndex = 0
			Me.diagram1.EndUpdate()
		End Sub
		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Change's the appearance of GroupBar
		''' </summary>
		Private Sub GroupBarAppearance()
		   Me.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA")
		   For Each item As GroupBarItem In paletteGroupBar1.GroupBarItems
				'palette view settings
				If TypeOf item.Client Is PaletteGroupView Then
					Dim view As PaletteGroupView = TryCast(item.Client, PaletteGroupView)
					view.Font = New Font("Segoe UI", 9, System.Drawing.FontStyle.Regular)
					view.ForeColor = Color.Black
					view.FlowView = True
					view.ShowToolTips = True
					view.ShowFlowViewItemText = True
					view.SelectedItemColor = Color.FromArgb(255, 219, 118)
					view.HighlightItemColor = Color.FromArgb(255, 227, 149)
					view.SelectingItemColor = Color.FromArgb(255, 238, 184)
					view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115)
					view.FlowViewItemTextLength = 80
					view.BackColor = Color.White
					view.TextWrap = True
					view.FlatLook = True
					view.BorderStyle = BorderStyle.FixedSingle
				End If
		   Next item
		End Sub

		''' <summary>
		''' Changes the appearance of the Diagram
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.HorizontalRuler.BackgroundColor = Color.White
			Me.diagram1.VerticalRuler.BackgroundColor = Color.White
			Me.diagram1.View.Grid.GridStyle = GridStyle.Line
			Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.diagram1.View.Grid.Color = Color.LightGray
			Me.diagram1.View.Grid.VerticalSpacing = 15
			Me.diagram1.View.Grid.HorizontalSpacing = 15
			Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f
			Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.Model.DocumentSize = New PageSize(Me.diagram1.View.ClientRectangle.Size.Width, diagram1.View.ClientRectangle.Size.Height)
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			Me.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size
			Me.diagram1.Model.SizeToContent = True
			Me.diagram1.View.SelectionList.Clear()
		End Sub
		#End Region

		#Region "InitializeDiagram"
		''' <summary>
		''' Initialize the Diagram
		''' </summary>
		Protected Sub InitailizeDiagram()
			Dim ethnet As Layer = CreateLayer("Ethernet Layer")
			Dim controlnet As Layer = CreateLayer("ControlNet Layer")
			Dim devicenet As Layer = CreateLayer("DeviceNet Layer")

			'	Add TextNodes to display Layer Names
			InsertTextNode("Ethernet", New PointF(350, 180), ethnet)
			InsertTextNode("Control Net", New PointF(320, 370), controlnet)
			InsertTextNode("Device Net", New PointF(500, 550), devicenet)

			' Add  TextNodes to highlight Various SymbolName.
			' Add a TextNode to highlight the Diagram Name
			Dim txtnode As Syncfusion.Windows.Forms.Diagram.TextNode = New TextNode("WIRELESS NETWORK FLOW DIAGRAM")
			txtnode.FontStyle.Size = 17
			txtnode.FontStyle.Bold = True
			txtnode.FontStyle.Family = "Arial"
			txtnode.FontColorStyle.Color = Color.Black
			txtnode.LineStyle.LineColor = Color.Transparent
			txtnode.SizeToText(Size.Empty)
			InsertNode(txtnode, New PointF(415, 25), Nothing)

			If Me.paletteGroupBar1.CurrentSymbolPalette Is Nothing Then
				Return
			End If

			' TextNode For Servers
			InsertHighlightTextNode("Servers", New PointF(250, 100), ethnet)
			' TextNode For WorkStations
			InsertHighlightTextNode("WorkStations", New PointF(480, 100), ethnet)
			' TextNode For Modem
			InsertHighlightTextNode("Modem", New PointF(600, 175), ethnet)
			' TextNode For Modem1
			InsertHighlightTextNode("Modem1", New PointF(730, 120), ethnet)
			' TextNode For RemoteController
			InsertHighlightTextNode("RemoteController", New PointF(870, 100), ethnet)
			' TextNode For RemoteWorkStations
			InsertHighlightTextNode("Remote WorkStations", New PointF(930, 250), ethnet)
			' TextNode For Modem2
			InsertHighlightTextNode("Modem2", New PointF(650, 270), ethnet)
			' TextNode For PortableWorkStations
			InsertHighlightTextNode("Portable WorkStation", New PointF(930, 320), ethnet)
			' TextNode For Modem3
			InsertHighlightTextNode("Modem3", New PointF(500, 350), ethnet)
			' TextNode For Modem4
			InsertHighlightTextNode("Modem4", New PointF(450, 230), ethnet)

			' TextNode For ControlLogic
			InsertHighlightTextNode("ControlLogic", New PointF(170, 400), controlnet)
			' TextNode For ControlLogic1
			InsertHighlightTextNode("ControlLogic1", New PointF(750, 360), controlnet)

			' TextNode For Hub Management Interface
			InsertHighlightTextNode("HMI", New PointF(910, 410), devicenet)
			' TextNode For DriveC
			InsertHighlightTextNode("DriveC", New PointF(800, 520), devicenet)
			' TextNode For DriveB
			InsertHighlightTextNode("DriveB", New PointF(650, 520), devicenet)
			' TextNode For DriveA
			InsertHighlightTextNode("DriveA", New PointF(550, 520), devicenet)
			' TextNode For Sensor
			InsertHighlightTextNode("Sensor", New PointF(400, 510), devicenet)
			' TextNode For AnalogI/O Device
			InsertHighlightTextNode("Analog I/O Device", New PointF(250, 550), devicenet)

			' Insert the Network Symbols.
			' Insert server  
			Dim server As Node = InsertNodeFromPallete(0, New PointF(236, 100), ethnet)
			'Insert server1  
			Dim server1 As Node = InsertNodeFromPallete(0, New PointF(186, 100), ethnet)
			' Insert WorkStation
			Dim ws As Node = InsertNodeFromPallete(1, New PointF(420, 100), ethnet)
			'Insert WorkStation 
			Dim ws1 As Node = InsertNodeFromPallete(1, New PointF(520, 100), ethnet)
			' Insert modem
			Dim modem As Node = InsertNodeFromPallete(2, New PointF(630, 140), ethnet)
			'Insert modem1 
			Dim modem1 As Node = InsertNodeFromPallete(2, New PointF(760, 140), ethnet)
			'Insert Portable WS
			Dim rc As Node = InsertNodeFromPallete(3, New PointF(890, 110), ethnet)
			'Insert RemoteWorkStations
			Dim rws As Node = InsertNodeFromPallete(1, New PointF(850, 230), ethnet)
			'Insert modem2
			Dim modem2 As Node = InsertNodeFromPallete(2, New PointF(650, 220), ethnet)
			'Insert RemoteController
			Dim pws As Node = InsertNodeFromPallete(1, New PointF(850, 320), ethnet)
			'Insert modem3
			Dim modem3 As Node = InsertNodeFromPallete(2, New PointF(500, 300), ethnet)
			'Insert modem4  
			Dim modem4 As Node = InsertNodeFromPallete(2, New PointF(500, 200), ethnet)

			'Insert ControlLogic
			Dim clx As Node = InsertNodeFromPallete(3, New PointF(800, 360), controlnet)
			'Insert ControlLogic1
			Dim clx1 As Node = InsertNodeFromPallete(3, New PointF(252, 360), controlnet)

			' Insert HMI
			Dim hmi As Node = InsertNodeFromPallete(4, New PointF(880, 410), devicenet)
			' Insert Analog I/O Device
			Dim analog As Node = InsertNodeFromPallete(5, New PointF(250, 470), devicenet)
			' InsertSensor Device
			Dim sensor As Node = InsertNodeFromPallete(6, New PointF(450, 470), devicenet)
			'Insert DriveA
			Dim driveA As Node = InsertNodeFromPallete(7, New PointF(550, 470), devicenet)
			'Insert DriveB
			Dim driveB As Node = InsertNodeFromPallete(7, New PointF(650, 470), devicenet)
			'Insert DriveC
			Dim driveC As Node = InsertNodeFromPallete(7, New PointF(800, 470), devicenet)

			 'Insert Arrows to indicate the Network Flow.
			InsertNodeFromPallete(8, New PointF(400, 170),0, ethnet)

			InsertNodeFromPallete(8, New PointF(250, 170), 90, ethnet)
			InsertNodeFromPallete(8, New PointF(565, 340),0, controlnet)
			InsertNodeFromPallete(8, New PointF(270, 420), 90, devicenet)
			InsertNodeFromPallete(8, New PointF(575, 420), 90, devicenet)
			InsertNodeFromPallete(8, New PointF(250, 280), 90, ethnet)

			' Create Links between the NetworkSymbols.
			ConnectNodes(server, server1)
			ConnectNodes(server1, ws)
			ConnectNodes(modem4, server1)
			ConnectNodes(server, clx1)
			ConnectNodes(ws, ws1)
			ConnectNodes(ws1, modem)
			ConnectNodes(ws1, modem4)
			ConnectNodes(modem1, modem)
			ConnectNodes(modem1, rc)
			ConnectNodes(modem2, rws)
			ConnectNodes(modem3, pws)
			ConnectNodes(modem3, modem4)
			ConnectNodes(modem2, modem4)
			ConnectNodes(clx, clx1)
			ConnectNodes(clx, driveB)
			ConnectNodes(clx1, analog)
			ConnectNodes(clx, driveA)
			ConnectNodes(clx1, sensor)
			ConnectNodes(hmi, driveC)
			ConnectNodes(hmi, driveB)
		End Sub
		''' <summary>
		''' Creates the Layer with given name
		''' </summary>
		''' <param name="strName">Layer's Name</param>
		''' <returns>returns the layer</returns>
		Private Function CreateLayer(ByVal strName As String) As Layer
			Dim layer As New Layer(Me.diagram1.Model, strName)

			Me.diagram1.Controller.Model.Layers.Add(layer)
			Return layer
		End Function

		''' <summary>
		''' Connects the nodes
		''' </summary>
		''' <param name="parentNode">Parent node</param>
		''' <param name="subNode">Child node</param>
		Private Sub ConnectNodes(ByVal parentNode As Node, ByVal subNode As Node)
			If parentNode.CentralPort Is Nothing OrElse subNode.CentralPort Is Nothing Then
				Return
			End If

			Me.diagram1.Model.BeginUpdate()

			' Create directed link
			Dim pts() As PointF = { PointF.Empty, New PointF(0, 1) }
			Dim line As New OrthogonalConnector(pts(0), pts(1))
			line.HeadDecorator.DecoratorShape = DecoratorShape.Filled45Arrow
			line.HeadDecorator.FillStyle.Color = Color.Black
			line.LineStyle.LineColor = Color.Black

			Me.diagram1.Model.AppendChild(line)

			parentNode.CentralPort.TryConnect(line.TailEndPoint)
			subNode.CentralPort.TryConnect(line.HeadEndPoint)
			Me.diagram1.Model.SendToBack(line)

			Me.diagram1.Model.EndUpdate()
		End Sub

		''' <summary>
		''' Insert the node from palette
		''' </summary>
		''' <param name="nNodeIndex">Index</param>
		''' <param name="ptPinPoint">Node's Location</param>
		''' <param name="angle">Rotation angle</param>
		''' <param name="layer">Layer</param>
		''' <returns></returns>
		Private Function InsertNodeFromPallete(ByVal nNodeIndex As Integer, ByVal ptPinPoint As PointF, ByVal angle As Single, ByVal layer As Layer) As Node
			Dim node As Node = InsertNodeFromPallete(nNodeIndex, ptPinPoint, layer)
			node.Rotate(angle)
			node.Size = New SizeF(20, 20)
			Return node
		End Function

		''' <summary>
		''' Insert the node from palette
		''' </summary>
		''' <param name="nNodeIndex">Index</param>
		''' <param name="ptPinPoint">Node's Location</param>
		''' <param name="layer">Layer</param>
		''' <returns>returns the node</returns>
		Private Function InsertNodeFromPallete(ByVal nNodeIndex As Integer, ByVal ptPinPoint As PointF, ByVal layer As Layer) As Node
			Dim node As Node = Nothing
			Dim nodes As NodeCollection = paletteGroupBar1.CurrentSymbolPalette.Nodes

			If nNodeIndex >= 0 AndAlso nNodeIndex < nodes.Count Then
				node = CType(nodes(nNodeIndex).Clone(), Node)
				InsertNode(node, ptPinPoint, layer)
			End If
			node.Size = New SizeF(50, 50)
			Return node
		End Function

		''' <summary>
		''' Insert Node into the diagram
		''' </summary>
		''' <param name="node">Node</param>
		''' <param name="ptPinPoint">Node's Location</param>
		''' <param name="layer">Layer</param>
		''' <returns>returns the node</returns>
		Private Function InsertNode(ByVal node As Node, ByVal ptPinPoint As PointF, ByVal layer As Layer) As Node
			Dim units As MeasureUnits = MeasureUnits.Pixel

			Dim szPinOffset As SizeF = (CType(node, IUnitIndependent)).GetPinPointOffset(units)
			ptPinPoint.X += szPinOffset.Width
			ptPinPoint.Y += szPinOffset.Height
			CType(node, IUnitIndependent).SetPinPoint(ptPinPoint, units)

			node.EnableCentralPort = True
			node.ShadowStyle.Visible = False
			Me.diagram1.Model.AppendChild(node)

			If layer IsNot Nothing Then
				layer.Nodes.Add(node)
				node.Layers.Add(layer)
			End If

			Return node
		End Function

		''' <summary>
		''' Insert the TextNode
		''' </summary>
		''' <param name="strText">TextNode's Text</param>
		''' <param name="ptPinPoint">Node's Location</param>
		''' <param name="layer">Layer</param>
		''' <returns>returns the text node</returns>
		Private Function InsertTextNode(ByVal strText As String, ByVal ptPinPoint As PointF, ByVal layer As Layer) As TextNode
			Dim txtnode As Syncfusion.Windows.Forms.Diagram.TextNode = New TextNode(strText)
			txtnode.FontStyle.Size = 15
			txtnode.FontStyle.Family = "Arial"
			txtnode.FontColorStyle.Color = Color.Black
			txtnode.LineStyle.LineColor = Color.Transparent
			txtnode.SizeToText(SizeF.Empty)
			InsertNode(txtnode, ptPinPoint, layer)

			Return txtnode
		End Function
		''' <summary>
		''' Insert the TextNode
		''' </summary>
		''' <param name="strText">TextNode's Text</param>
		''' <param name="ptPinPoint">Node's Location</param>
		''' <param name="layer">Layer</param>
		''' <returns>returns the text node</returns>
		Private Function InsertHighlightTextNode(ByVal strText As String, ByVal ptPinPoint As PointF, ByVal layer As Layer) As TextNode
			Dim txtnode As Syncfusion.Windows.Forms.Diagram.TextNode = New TextNode(strText)
			txtnode.FontStyle.Size = 10
			txtnode.FontStyle.Family = "Arial"
			txtnode.FontColorStyle.Color = Color.Black
			txtnode.LineStyle.LineColor = Color.Transparent
			txtnode.SizeToText(SizeF.Empty)

			InsertNode(txtnode, ptPinPoint, layer)

			Return txtnode
		End Function

		''' <summary>
		''' Set the visibility state for the links that enter or exit the symbols in this layer. 
		''' </summary>
		Private Sub SetConnectingLinksVisibility()
			Dim layers As LayerCollection = Me.diagram1.Controller.Model.Layers

			For Each layer As Layer In layers
				SetConnectingLinksVisibility(layer)
			Next layer
		End Sub

		''' <summary>
		''' Set the visibility state for the links that enter or exit the symbols in this layer. 
		''' </summary>
		''' <param name="layer">Layer</param>
		Private Sub SetConnectingLinksVisibility(ByVal layer As Layer)
			Me.diagram1.Model.BeginUpdate()
			Dim nodes As NodeCollection = layer.Nodes
			Dim bVisible As Boolean = True

			For Each endnode1 As Node In nodes
				Dim linksinlayer As ICollection = endnode1.Edges

				For Each lnk As ConnectorBase In linksinlayer
					Dim endnode2 As Node
					If (lnk.FromNode Is endnode1) Then
						endnode2 = TryCast(lnk.ToNode, Node)
					Else
						endnode2 = TryCast(lnk.FromNode, Node)
					End If

					' Show the link only if the symbols on both ends of the link are visible. 						
					For Each lr As Layer In endnode1.Layers
						If Not lr.Visible Then
							bVisible = False
							Exit For
						End If
					Next lr

					If endnode2 IsNot Nothing Then
						For Each lr As Layer In endnode2.Layers
							If Not lr.Visible Then
								bVisible = False
								Exit For
							End If
						Next lr
					Else
						Console.WriteLine("Nodes has been deleted...")
					End If

					lnk.Visible = bVisible
					bVisible = True
				Next lnk
			Next endnode1
			Me.diagram1.Model.EndUpdate()
		End Sub
		#End Region

		#Region "Properties"

		Public Property SaveChanges() As Boolean
			Get
				If diagram1.Model.Modified OrElse needSave Then
					Return True
				Else
					Return False
				End If
			End Get
			Set(ByVal value As Boolean)
				needSave = value
			End Set
		End Property

		Public ReadOnly Property HasFileName() As Boolean
			Get
				Return (Me.fileName IsNot Nothing AndAlso Me.fileName.Length > 0)
			End Get
		End Property

		#End Region

		#Region "Event Handlers"

		Private Sub createLyr_Click(ByVal sender As Object, ByVal e As EventArgs) Handles createLyr.Click
			Dim nwLayer As New Layer()
			nwLayer.Name = txtLayerName.Text
            nwLayer.Enabled = chkEnableNewlayer.Checked
            comboLayers.Items.Add(nwLayer.Name)
			diagram1.Model.Layers.Add(nwLayer)
			diagram1.Model.ActiveLayers.Add(nwLayer)
		End Sub

		Private Sub apply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles apply.Click
			Me.diagram1.Model.BeginUpdate()
			Dim curLayer As Layer = Me.diagram1.Model.Layers(comboLayers.SelectedItem.ToString())
			If chkVisibleLyr.Checked Then
                curLayer.Visible = True
                Me.SetConnectingLinksVisibility()
			Else
                curLayer.Visible = False
                Me.SetConnectingLinksVisibility()
			End If

			If chkEnableLyr.Checked Then
				curLayer.Enabled = True
			Else
				curLayer.Enabled = False
			End If
			If chkRemoveLyr.Checked Then
                Dim lyr As Layer = diagram1.Model.Layers(comboLayers.SelectedItem.ToString())
                For i As Integer = lyr.Nodes.Count - 1 To 0 Step -1
                    Dim lnklayer As ICollection = lyr.Nodes(i).Edges
                    For Each lnk As ConnectorBase In lnklayer
                        diagram1.Model.Nodes.Remove(lnk)
                    Next lnk
                    diagram1.Model.Nodes.Remove(lyr.Nodes(i))
                Next i
                diagram1.Model.Layers.Remove(lyr)
                comboLayers.Items.Remove(comboLayers.SelectedItem)
			End If

			Me.diagram1.EndUpdate()
			Me.diagram1.Invalidate(True)
		End Sub

		Private Sub comboLayers_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboLayers.SelectedIndexChanged
			Dim lyr As Layer = Me.diagram1.Model.Layers(comboLayers.SelectedItem.ToString())
			chkEnableLyr.Checked = lyr.Enabled
			chkVisibleLyr.Checked = lyr.Visible
		End Sub

		#Region "Hide/show layers"
		Private Sub Ethernet_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.diagram1.Model.BeginUpdate()
			Dim ethernet As Layer = Me.diagram1.Model.Layers("Ethernet Layer")
			If ethernet.Visible Then
				ethernet.Visible = False
			Else
				ethernet.Visible = True
			End If
			Me.SetConnectingLinksVisibility()
			Me.diagram1.EndUpdate()
			Me.diagram1.Invalidate(True)

		End Sub

		Private Sub ControlNet_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.diagram1.Model.BeginUpdate()
			Dim controlnet As Layer = Me.diagram1.Model.Layers("ControlNet Layer")
			If controlnet.Visible Then
				controlnet.Visible = False
			Else
				controlnet.Visible = True
			End If
			Me.SetConnectingLinksVisibility()
			Me.diagram1.EndUpdate()
			Me.diagram1.Invalidate(True)
		End Sub

		Private Sub DeviceNet_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.diagram1.Model.BeginUpdate()
			Dim devicenet As Layer = Me.diagram1.Model.Layers("DeviceNet Layer")
			If devicenet.Visible Then
				devicenet.Visible = False
			Else
				devicenet.Visible = True
			End If
			Me.SetConnectingLinksVisibility()
			Me.diagram1.EndUpdate()
			Me.diagram1.Invalidate(True)
		End Sub
		#End Region


		Private Sub newToolStripButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles newToolStripButton.Click
			If Me.SaveChanges Then
				Dim res As DialogResult = MessageBoxAdv.Show(Me, "The diagram or its association has been modified. Save changes?", "Save changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
				If res = System.Windows.Forms.DialogResult.Yes Then
					Me.saveFileDialog1.FileName = "Diagram"
					saveFileDialog1.Filter = "EDD file(*.edd)|*.edd|XML file(*.xml)|*.xml|All files|*.*"
					saveFileDialog1.Title = "Save File As:"

					If Me.HasFileName Then
						Me.saveFileDialog1.FileName = Me.fileName
					End If
					If Me.saveFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
						Me.fileName = Me.saveFileDialog1.FileName
						SaveDiagramAs(saveFileDialog1.FileName, saveFileDialog1.FilterIndex)
						diagram1.Model.Clear()
						Dim model As New Model()
						model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
						model.LineStyle.LineColor = Color.LightGray
						diagram1.Model = model
					End If
				ElseIf res = System.Windows.Forms.DialogResult.No Then
					diagram1.Model.Clear()
					Dim model As New Model()
					model.RenderingStyle.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
					model.LineStyle.LineColor = Color.LightGray
                    diagram1.Model = model
                    comboLayers.Items.Clear()
                    comboLayers.Text = ""
				End If
			End If
		End Sub


		#End Region      

		#Region "Helper Methods"
		Private Sub SaveDiagramAs(ByVal filename As String, ByVal index As Integer)
			Select Case index
				Case 1
					diagram1.SaveBinary(filename)
				Case 2
					diagram1.SaveSoap(filename)
				Case Else
					diagram1.SaveBinary(filename)
			End Select
		End Sub

		#End Region       

	End Class
End Namespace


