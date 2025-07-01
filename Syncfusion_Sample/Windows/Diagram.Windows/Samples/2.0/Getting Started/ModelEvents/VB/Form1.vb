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


Namespace ModelEvents
	Partial Public Class Form1
		Inherits Form
		#Region "Members"
		Private mload As Boolean = True
		#End Region

		#Region "Form Initialize"
		Public Sub New()
			InitializeComponent()
			Me.diagram1.HScroll = False
			Me.diagram1.VScroll = False
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			diagram1.BeginUpdate()
			Me.diagram1.Model.SizeToContent = True
			Me.diagram1.Model.BoundaryConstraintsEnabled = False

			paletteGroupBar1.LoadPalette("..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Flowchart Symbols.edp")
			DiagramAppearance()
			GroupBarAppearance()
			diagram1.EndUpdate()

			AddHandler diagram1.Model.EventSink.NodeCollectionChanging, AddressOf EventSink_NodeCollectionChanging
			AddHandler diagram1.Model.EventSink.NodeCollectionChanged, AddressOf EventSink_NodeCollectionChanged
			AddHandler diagram1.Model.EventSink.ConnectionsChanging, AddressOf EventSink_ConnectionsChanging
			AddHandler diagram1.Model.EventSink.ConnectionsChanged, AddressOf EventSink_ConnectionsChanged
			AddHandler diagram1.Model.EventSink.PinPointChanging, AddressOf EventSink_PinPointChanging
			AddHandler diagram1.Model.EventSink.PinPointChanged, AddressOf EventSink_PinPointChanged
			AddHandler diagram1.Model.EventSink.SizeChanging, AddressOf EventSink_SizeChanging
			AddHandler diagram1.Model.EventSink.SizeChanged, AddressOf EventSink_SizeChanged
			AddHandler diagram1.Model.EventSink.PropertyChanging, AddressOf EventSink_PropertyChanging
			AddHandler diagram1.Model.EventSink.PropertyChanged, AddressOf EventSink_PropertyChanged
			AddHandler diagram1.Model.EventSink.FlipChanging, AddressOf EventSink_FlipChanging
			AddHandler diagram1.Model.EventSink.FlipChanged, AddressOf EventSink_FlipChanged
			AddHandler diagram1.Model.EventSink.ZOrderChanging, AddressOf EventSink_ZOrderChanging
			AddHandler diagram1.Model.EventSink.ZOrderChanged, AddressOf EventSink_ZOrderChanged
			AddHandler diagram1.Model.EventSink.VertexChanging, AddressOf EventSink_VertexChanging
			AddHandler diagram1.Model.EventSink.VertexChanged, AddressOf EventSink_VertexChanged
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
			Me.diagram1.View.HandleRenderer.HandleColor = Color.AliceBlue
			Me.diagram1.View.HandleRenderer.HandleOutlineColor = Color.SkyBlue
			Me.diagram1.Model.RenderingStyle.SmoothingMode = SmoothingMode.HighQuality
			Me.diagram1.Model.DocumentSize = New PageSize(Me.diagram1.View.ClientRectangle.Size.Width, diagram1.View.ClientRectangle.Size.Height)
			Me.diagram1.Model.BoundaryConstraintsEnabled = False
			Me.diagram1.Model.MinimumSize = diagram1.View.ClientRectangle.Size
			Me.diagram1.Model.SizeToContent = True
			diagram1.View.BackgroundColor = Color.White
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

		Private Sub EventSink_VertexChanged(ByVal evtArgs As VertexChangedEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "VertexChanged event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_VertexChanging(ByVal evtArgs As VertexChangingEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "VertexChanging event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_ZOrderChanged(ByVal evtArgs As ZOrderChangedEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "ZOrderChanged event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_ZOrderChanging(ByVal evtArgs As ZOrderChangingEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "ZOrderChanging event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_FlipChanged(ByVal evtArgs As FlipChangedEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "FlipChanged event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_FlipChanging(ByVal evtArgs As FlipChangingEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "FlipChanging event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_PropertyChanged(ByVal evtArgs As Syncfusion.Windows.Forms.Diagram.PropertyChangedEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "PropertyChanged event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_PropertyChanging(ByVal evtArgs As Syncfusion.Windows.Forms.Diagram.PropertyChangingEventArgs)
			listBox1.Items.Add(Constants.vbLf & "ropertyChanging event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_SizeChanged(ByVal evtArgs As SizeChangedEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "SizeChanged event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_SizeChanging(ByVal evtArgs As SizeChangingEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "SizeChanging event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_PinPointChanged(ByVal evtArgs As PinPointChangedEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "PinPointChanged event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_PinPointChanging(ByVal evtArgs As PinPointChangingEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "PinPointChanging event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_ConnectionsChanged(ByVal evtArgs As CollectionExEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "ConnectionsChanged event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_ConnectionsChanging(ByVal evtArgs As CollectionExEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "ConnectionsChanging event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_NodeCollectionChanged(ByVal evtArgs As CollectionExEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "NodeCollectionChanged event Fired." & Constants.vbLf)
		End Sub

		Private Sub EventSink_NodeCollectionChanging(ByVal evtArgs As CollectionExEventArgs)
			 listBox1.Items.Add(Constants.vbLf & "NodeCollectionChanging event Fired." & Constants.vbLf)
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			listBox1.Items.Clear()
		End Sub
		#End Region        
	End Class
End Namespace
