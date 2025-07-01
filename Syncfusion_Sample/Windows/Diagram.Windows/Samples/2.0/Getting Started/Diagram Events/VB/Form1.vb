Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing.Imaging
Imports Syncfusion.Windows.Forms.Tools
Imports Syncfusion.Windows.Forms.Diagram.Controls
Imports System.Drawing.Drawing2D
Imports Syncfusion.Windows.Forms
Imports System.IO
Imports System.Drawing.Printing
Imports Syncfusion.SVG.IO
Imports DemoCommon.Diagram


Namespace DiagramEvents
	Partial Public Class Form1
		Inherits Form
		#Region "Members"
		Private mload As Boolean = True
		#End Region

		#Region "Form Initialize "
		Public Sub New()
			InitializeComponent()
			paletteGroupBar1.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Flowchart Symbols.edp")
			GroupBarAppearance()
			diagram1.Model.LineStyle.LineColor = Color.LightGray
			'diagram view settings
			diagram1.View.Grid.GridStyle = Syncfusion.Windows.Forms.Diagram.GridStyle.Line
			diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid
			diagram1.View.Grid.Color = Color.LightGray
			diagram1.View.HandleRenderer.HandleColor = Color.White
			diagram1.View.HandleRenderer.HandleOutlineColor = Color.Gray
			diagram1.View.BackgroundColor = Color.White
			diagram1.View.Grid.HorizontalSpacing = 15
			diagram1.View.Grid.VerticalSpacing = 15

			Me.diagram1.HScroll = False
			Me.diagram1.VScroll = False
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			AddHandler diagram1.DragDrop, AddressOf diagram1_DragDrop
			AddHandler diagram1.EventSink.NodeCollectionChanging, AddressOf EventSink_NodeCollectionChanging
			AddHandler diagram1.EventSink.NodeCollectionChanged, AddressOf EventSink_NodeCollectionChanged
			AddHandler diagram1.EventSink.NodeSelected, AddressOf EventSink_NodeSelected
			AddHandler diagram1.EventSink.NodeDeselected, AddressOf EventSink_NodeDeselected
			AddHandler diagram1.EventSink.NodeClick, AddressOf EventSink_NodeClick
			AddHandler diagram1.EventSink.NodeDoubleClick, AddressOf EventSink_NodeDoubleClick
			AddHandler diagram1.EventSink.NodeMouseEnter, AddressOf EventSink_NodeMouseEnter
			AddHandler diagram1.EventSink.NodeMouseLeave, AddressOf EventSink_NodeMouseLeave
			AddHandler diagram1.EventSink.SelectionListChanged, AddressOf EventSink_SelectionListChanged
			AddHandler diagram1.EventSink.MagnificationChanged, AddressOf EventSink_MagnificationChanged
			AddHandler diagram1.EventSink.OriginChanged, AddressOf EventSink_OriginChanged
		End Sub
		#End Region

		#Region "Private Methods"
		''' <summary>
		''' Change's the appearance of Diagram
		''' </summary>
		Private Sub DiagramAppearance()
			Me.diagram1.Model.LineStyle.LineColor = Color.LightGray
			Me.diagram1.HorizontalRuler.BackgroundColor = Color.White
			Me.diagram1.VerticalRuler.BackgroundColor = Color.White
			Me.diagram1.View.Grid.GridStyle = GridStyle.Line
			Me.diagram1.View.Grid.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
			Me.diagram1.View.Grid.Color = Color.LightGray
			Me.diagram1.View.Grid.VerticalSpacing = 15
			Me.diagram1.View.Grid.HorizontalSpacing = 15
			Me.diagram1.Model.BackgroundStyle.GradientCenter = 0.5f
			Me.diagram1.View.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.Model.DocumentSize = New PageSize(Me.diagram1.View.ClientRectangle.Size.Width, diagram1.View.ClientRectangle.Size.Height)
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			Me.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size
			Me.diagram1.Model.SizeToContent = True
			Me.diagram1.View.BackgroundColor = Color.White
			Me.diagram1.View.SelectionList.Clear()
		End Sub

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
		#End Region

		#Region "Event Handlers"
		Private Sub MainForm_Activated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
			If Me.mload Then
				Me.mload = False
				MessageBoxAdv.Office2007Theme = Office2007Theme.Blue
				MessageBoxAdv.Show("Drag and drop a Symbol from the Symbol Palette and watch the events fired in the daigram control through Event log viewer", "Essential Diagram ", MessageBoxButtons.OK, MessageBoxIcon.Information)
				Me.Activate()
			End If
		End Sub
		Private Sub diagram1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
			listBox1.Items.Add(Constants.vbLf & "Drag drop event Fired." & Constants.vbLf)
		End Sub
		Private Sub EventSink_OriginChanged(ByVal evtArgs As ViewOriginEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "OriginChanged event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_MagnificationChanged(ByVal evtArgs As ViewMagnificationEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "MagnificationChanged event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_SelectionListChanged(ByVal evtArgs As CollectionExEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "SelectionListChanged event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_SelectionListChanging(ByVal evtArgs As CollectionExEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "SelectionListChanging event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_NodeMouseLeave(ByVal evtArgs As NodeMouseEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "NodeMouseLeave event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_NodeDoubleClick(ByVal evtArgs As NodeMouseEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "NodeDoubleClick event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_NodeClick(ByVal evtArgs As NodeMouseEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "NodeClick event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_NodeDeselected(ByVal evtArgs As NodeSelectedEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "NodeDeselected event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_NodeMouseEnter(ByVal evtArgs As NodeMouseEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "NodeMouseEnter event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_NodeSelected(ByVal evtArgs As NodeSelectedEventArgs)
			listBox1.Items.Add(Constants.vbLf & "NodeSelected event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_NodeCollectionChanged(ByVal evtArgs As CollectionExEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "NodeCollectionChanged event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_NodeCollectionChanging(ByVal evtArgs As CollectionExEventArgs)
			listBox1.Items.Add(Constants.vbLf & "NodeCollectionChanging event Fired." & Constants.vbLf)
		End Sub

		Private Sub clear_Click(ByVal sender As Object, ByVal e As EventArgs) Handles clear.Click
			listBox1.Items.Clear()
		End Sub

		#End Region

	End Class

End Namespace
