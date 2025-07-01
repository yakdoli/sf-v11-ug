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

Namespace LayerDemo
	Partial Public Class Form1
		Inherits Form
		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.diagram1.BeginUpdate()
			InitailizeDiagram()
			DiagramAppearance()
			Me.diagram1.EndUpdate()
			comboLayers.SelectedIndex = 0
			AddHandler comboLayers.SelectedIndexChanged, AddressOf comboLayers_SelectedIndexChanged
			Me.diagram1.Focus()
		End Sub
		#End Region

		#Region "Private Methods"
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
			Me.diagram1.View.SelectionList.Clear()
		End Sub

		#End Region

		#Region "InitializeDiagram"
		''' <summary>
		''' Initialize the Diagram
		''' </summary>
		Protected Sub InitailizeDiagram()
			Dim rectanglelayer As Layer = CreateLayer("Rectangle Layer")
			Dim ellipselayer As Layer = CreateLayer("Ellipse Layer")
			Dim roundRectlayer As Layer = CreateLayer("RoundRect Layer")

			Dim rectPinPointX As Single = 50, ellipsePinPointX As Single = 300, roundRectPinPointX As Single = 550, PinPointY As Single = 75
			For i As Integer = 0 To 3
				Dim rect As New Syncfusion.Windows.Forms.Diagram.Rectangle(rectPinPointX, PinPointY, 200, 50)
				rect.FillStyle.Color = Color.FromArgb(240, 242, 240)
				rect.FillStyle.ForeColor = Color.White
				rect.FillStyle.Type = FillStyleType.LinearGradient
				rect.LineStyle.LineColor = Color.DarkGray
				'rect.Name = "Rectangle" + (i + 1);
				AddLabel(rect.Name, rect)
				diagram1.Model.AppendChild(rect)
				rectanglelayer.Nodes.Add(rect)
				rect.Layers.Add(rectanglelayer)

				Dim ellipse As New Syncfusion.Windows.Forms.Diagram.Ellipse(ellipsePinPointX, PinPointY, 200, 50)
				ellipse.FillStyle.Color = Color.FromArgb(240, 242, 240)
				ellipse.FillStyle.ForeColor = Color.White
				ellipse.FillStyle.Type = FillStyleType.LinearGradient
				ellipse.LineStyle.LineColor = Color.DarkGray
				' ellipse.Name = "Ellipse" + (i + 1);
				AddLabel(ellipse.Name, ellipse)
				diagram1.Model.AppendChild(ellipse)
				ellipselayer.Nodes.Add(ellipse)
				ellipse.Layers.Add(ellipselayer)


				Dim roundRect As New Syncfusion.Windows.Forms.Diagram.RoundRect(roundRectPinPointX, PinPointY, 200, 50, MeasureUnits.Pixel)
				roundRect.FillStyle.Color = Color.FromArgb(240, 242, 240)
				roundRect.FillStyle.ForeColor = Color.White
				roundRect.FillStyle.Type = FillStyleType.LinearGradient
				roundRect.LineStyle.LineColor = Color.DarkGray
				' roundRect.Name = "RoundRect" + (i + 1);
				AddLabel(roundRect.Name, roundRect)
				diagram1.Model.AppendChild(roundRect)
				roundRectlayer.Nodes.Add(roundRect)
				roundRect.Layers.Add(roundRectlayer)

				PinPointY += 125

			Next i
		End Sub

		''' <summary>
		''' Creates the Layer 
		''' </summary>
		''' <param name="strName">Layer Name</param>
		''' <returns></returns>
		Private Function CreateLayer(ByVal strName As String) As Layer
			Dim layer As New Layer(Me.diagram1.Model, strName)
			Me.diagram1.Model.Layers.Add(layer)
			Return layer
		End Function

		''' <summary>
		''' Adds the label to the given node.
		''' </summary>
		''' <param name="Text">Label's text</param>
		''' <param name="node">Node</param>
		Private Sub AddLabel(ByVal Text As String, ByVal node As PathNode)
			Dim label As New Syncfusion.Windows.Forms.Diagram.Label(node, Text)
			label.Position = Position.Center
			label.FontStyle.Size = 9
			label.FontStyle.Family = "verdana"
			node.Labels.Add(label)
		End Sub

		''' <summary>
		''' Appends TextNode to the Layer
		''' </summary>
		''' <param name="strText">TextNode's Text</param>
		''' <param name="ptPinPoint">TextNode's Location</param>
		''' <param name="layer">layer</param>
		Private Sub InsertTextNode(ByVal strText As String, ByVal ptPinPoint As PointF, ByVal layer As Layer)
			Dim txtnode As Syncfusion.Windows.Forms.Diagram.TextNode = New TextNode(strText)
			txtnode.FontStyle.Size = 10
			txtnode.FontStyle.Family = "verdana"
			txtnode.FontColorStyle.Color = Color.Black
			txtnode.LineStyle.LineColor = Color.Transparent
			txtnode.SizeToText(SizeF.Empty)
			txtnode.PinPoint = ptPinPoint
			layer.Nodes.Add(txtnode)
			txtnode.Layers.Add(layer)
			diagram1.Model.AppendChild(txtnode)
			diagram1.Model.BringToFront(txtnode)
		End Sub
		#End Region

		#Region "Event Handlers"
		Private Sub rectangleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles rectangleToolStripMenuItem.Click
			diagram1.Controller.ActivateTool("RectangleTool")
		End Sub

		Private Sub roundRectToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles roundRectToolStripMenuItem.Click
			diagram1.Controller.ActivateTool("RoundRectTool")
		End Sub

		Private Sub ellipseToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ellipseToolStripMenuItem.Click
			diagram1.Controller.ActivateTool("EllipseTool")
		End Sub

		Private Sub polygonToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles polygonToolStripMenuItem.Click
			diagram1.Controller.ActivateTool("PolygonTool")
		End Sub
        Private Sub createLyr_Click(ByVal sender As Object, ByVal e As EventArgs) Handles createLyr.Click
            If chkEnableNewlayer.Checked Then
                For Each layer As Layer In diagram1.Model.Layers
                    If layer.Enabled Then
                        layer.Enabled = False
                    End If
                Next layer
            End If
            Dim nwLayer As New Layer()
            nwLayer.Name = txtLayerName.Text
            nwLayer.Enabled = chkEnableNewlayer.Checked
            comboLayers.Items.Add(nwLayer.Name)
            diagram1.Model.Layers.Add(nwLayer)
            comboLayers.SelectedIndex = comboLayers.Items.Count - 1
            If chkEnableNewlayer.Checked Then
                diagram1.Model.ActiveLayers.Add(nwLayer)
            End If
        End Sub

		Private Sub apply_Click(ByVal sender As Object, ByVal e As EventArgs) Handles apply.Click
			Me.diagram1.Model.BeginUpdate()
			Dim curLayer As Layer = Me.diagram1.Model.Layers(comboLayers.SelectedItem.ToString())
			If chkVisibleLyr.Checked Then
				curLayer.Visible = True
			Else
				curLayer.Visible = False
			End If

			If chkEnableLyr.Checked Then
				curLayer.Enabled = True
			Else
				curLayer.Enabled = False
			End If
			If chkRemoveLyr.Checked Then
				Me.diagram1.BeginUpdate()
				Dim lyr As Layer = diagram1.Model.Layers(comboLayers.SelectedItem.ToString())
				Do While diagram1.Model.Layers(comboLayers.SelectedItem.ToString()).Nodes.Count > 0
					diagram1.Model.Nodes.Remove(diagram1.Model.Layers(comboLayers.SelectedItem.ToString()).Nodes(0))
				Loop
				diagram1.Model.Layers.Remove(diagram1.Model.Layers(comboLayers.SelectedItem.ToString()))
				comboLayers.Items.Remove(comboLayers.SelectedItem)
				Me.diagram1.EndUpdate()
			End If
			Me.diagram1.EndUpdate()
			Me.diagram1.Invalidate(True)
		End Sub

		Private Sub comboLayers_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
			Dim lyr As Layer = Me.diagram1.Model.Layers(comboLayers.SelectedItem.ToString())
			chkEnableLyr.Checked = lyr.Enabled
			chkVisibleLyr.Checked = lyr.Visible
		End Sub

		#End Region      

	End Class
End Namespace


