Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Web
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing
Imports System.Collections
Imports System.Runtime.Serialization
Imports System.Drawing.Drawing2D

''' <summary>
''' Summary description for EmpSymbol
''' </summary>
<Serializable, System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Assert, Name := "FullTrust")> _
Public Class EmpSymbol
	Inherits Group
	#Region "Class members"

	''' <summary>
	''' Flag indicated for explanded node state.
	''' </summary>
	Private m_bExpanded As Boolean = True
	Private m_bIsExpander As Boolean
	Private m_iCount As Integer = 0
	''' <summary>
	''' Create new instance of TextNode
	''' </summary>
	Private txtNode As New TextNode("")
	''' <summary>
	''' Create a enum for BackgroundShape .
	''' </summary>
	Public Enum BackgroundShape
		ellipse
		Rectangle
	End Enum
	''' <summary>
	''' Create a enum for SymbolShape
	''' </summary>
	Public Enum SymbolShape
		PlusMinus
		RightDownTriangle
	End Enum

	Private m_backGrndShp As BackgroundShape
	Private m_symbolShape As SymbolShape

	Private CollapsedCollection As New NodeCollection()
	Private ExpandedCollection As New NodeCollection()

	#End Region

	#Region "Class Initialize methods"
	''' <summary>
	''' Initialize a new instance of the class.
	''' </summary>
	''' <param name="fileName"></param>
	Public Sub New(ByVal fileName As String)
        Dim groupRect As New Syncfusion.Windows.Forms.Diagram.Rectangle(0, 0, 255, 75)
		groupRect.Name = "Rectangle"
		groupRect.FillStyle.Type = FillStyleType.LinearGradient
		groupRect.FillStyle.ForeColor = Color.White
		groupRect.FillStyle.Color = System.Drawing.Color.FromArgb(240, 242, 240)
		groupRect.LineStyle.LineColor = Color.Black
		groupRect.LineStyle.LineWidth = 1
		groupRect.EditStyle.AllowSelect = False
		Me.AppendChild(groupRect)

		Dim bitmap As New System.Drawing.Bitmap(fileName)
		Dim Image As System.Drawing.Image = bitmap.GetThumbnailImage(60, 50, Nothing, IntPtr.Zero)
		bitmap = New System.Drawing.Bitmap(Image)

		Dim bitmapNode As New BitmapNode(bitmap)
		bitmapNode.PinPoint = New PointF(bitmapNode.PinPoint.X + 10, bitmapNode.PinPoint.Y+10)
		bitmapNode.LineStyle.LineColor = Color.Transparent
		bitmapNode.EditStyle.AllowSelect = False
		Me.AppendChild(bitmapNode)

		txtNode.PinPoint = New PointF(bitmapNode.PinPoint.X + 40, bitmapNode.PinPoint.Y-30)
		txtNode.LineStyle.LineColor = Color.Transparent
		txtNode.FontStyle.Size = 9
		txtNode.FontStyle.Family = "Arial"

		txtNode.SizeToText(New SizeF(130, 100))
		Me.AppendChild(txtNode)
		BackgroundShapeType = BackgroundShape.ellipse
		SymbolShapeType = SymbolShape.RightDownTriangle
	End Sub

	''' <summary>
	''' Initializes a new instance of the <see cref="ExpanderSymbol"/> class.
	''' </summary>
	''' <param name="src">The source node.</param>
	Public Sub New(ByVal src As EmpSymbol)
		MyBase.New(src)
		m_bExpanded = src.m_bExpanded
	End Sub
	''' <summary>
	''' Initializes a new instance of the <see cref="Group"/> class.
	''' </summary>
	''' <param name="info">The serialization Info.</param>
	''' <param name="context">The streaming context.</param>
	''' <summary>
	''' Serialization constructor for symbols.
	''' </summary>
	''' <param name="info">Serialization state information</param>
	''' <param name="context">Streaming context information</param>
	Public Sub New(ByVal info As System.Runtime.Serialization.SerializationInfo, ByVal context As StreamingContext)
		MyBase.New(info, context)
		m_bExpanded = info.GetBoolean("isExpanded")
	End Sub

	Protected Overrides Sub GetObjectData(ByVal info As SerializationInfo, ByVal context As StreamingContext)
		MyBase.GetObjectData(info, context)
	End Sub
	#End Region

	#Region "Class properties"

	''' <summary>
	''' Get EmployeeName of current node.
	''' </summary>
	Public Property EmployeeName() As String
		Get
			Return Me.txtNode.Text
		End Get
		Set(ByVal value As String)
			Me.txtNode.Text = value
		End Set
	End Property

	''' <summary>
	''' Get BackgroundShape of current node
	''' </summary>
	Public Property BackgroundShapeType() As BackgroundShape
		Get
			Return m_backGrndShp
		End Get
		Set(ByVal value As BackgroundShape)
			m_backGrndShp = value
		End Set
	End Property

	''' <summary>
	''' Get symbolshape of current node
	''' </summary>
	Public Property SymbolShapeType() As SymbolShape
		Get
			Return m_symbolShape
		End Get
		Set(ByVal value As SymbolShape)
			m_symbolShape = value
		End Set
	End Property

	''' <summary>
	''' Get nodeCollection of current node
	''' </summary>
	Public ReadOnly Property SubNodes() As NodeCollection
		Get
			Return GetSubNodes()
		End Get
	End Property

	Public Property Count() As Integer
		Get
			Return m_iCount
		End Get
		Set(ByVal value As Integer)
			If value <> m_iCount AndAlso OnPropertyChanging(Me.FullContainerName, "Count", value) Then
				m_iCount = value
				OnPropertyChanged(Me.FullContainerName, "Count")
			End If
		End Set
	End Property

	Public Property IsExpanded() As Boolean
		Get
			Return m_bExpanded
		End Get
		Set(ByVal value As Boolean)
			If value <> m_bExpanded Then
				m_bExpanded = value
			End If
		End Set
	End Property

	Public Property IsExpander() As Boolean
		Get
			Return m_bIsExpander
		End Get
		Set(ByVal value As Boolean)
			If value <> m_bIsExpander AndAlso OnPropertyChanging(Me.FullContainerName, "IsExpander", value) Then
				m_bIsExpander = value
				OnPropertyChanged(Me.FullContainerName, "IsExpander")
			End If
		End Set
	End Property
	#End Region    

	#Region "Class overrides"
	Protected Overrides Sub OnMouseClick(ByVal e As EventArgs)
		MyBase.OnMouseClick(e)
		If m_bIsExpander Then
			Dim diagramModel As Syncfusion.Windows.Forms.Diagram.Model = Me.Root

			diagramModel.BeginUpdate()

			If m_bExpanded = False Then
				Me.ExpandSubNodes(True)
			Else
				Me.CollapseSubNodes(True)
			End If
			diagramModel.EndUpdate()
		End If
	End Sub
	Public Sub MouseMove(ByVal ptLocation As PointF)
		Dim pt As PointF = Me.ConvertToNodeCoordinates(ptLocation)
		Dim rect As New RectangleF(3, 3, 18, 18)
		If rect.Contains(pt) Then
			Me.IsExpander = True
		Else
			Me.IsExpander = False
		End If
	End Sub
	''' <summary>
	''' Clones this instance.
	''' </summary>
	''' <returns></returns>
	Public Overrides Function Clone() As Object
		Return New EmpSymbol(Me)
	End Function
	''' <summary>
	''' Renders the specified graphics.
	''' </summary>
	''' <param name="gfx">Graphics to draw on.</param>
	Protected Overrides Sub Render(ByVal gfx As Graphics)
		MyBase.Render(gfx)

		' draw helper plus/minus symbol
		DrawPlusMinus(gfx)
	End Sub
	#End Region

	#Region "Class Public Methods"
	''' <summary>
	''' Create new method for expand current node
	''' </summary>
	''' <param name="SelectedNode"></param>
	Public Function ExpandSubNodes(ByVal clickednode As Boolean) As NodeCollection
		Dim expandCollection As New NodeCollection()
		ExpandedCollection = New NodeCollection()
		Dim thisNode As IGraphNode = TryCast(Me, IGraphNode)

		If thisNode IsNot Nothing Then
			Dim edgesLeaving As ICollection = thisNode.EdgesLeaving
			If edgesLeaving IsNot Nothing Then
				For Each curEdge As IGraphEdge In edgesLeaving
					' Get from IGraphEdge link.
					Dim outlink As ConnectorBase = TryCast(curEdge, ConnectorBase)

					If outlink IsNot Nothing Then
						' Get from link children of current symbol.
						Dim cursymbol As EmpSymbol = TryCast(outlink.ToNode, EmpSymbol)
						If cursymbol IsNot Nothing Then
							' Check for explanded and explande nodes in child symbol.
							If cursymbol.IsExpanded Then
								cursymbol.ExpandSubNodes(False)
							End If

							' Set current symbol as visible.
							cursymbol.Visible = True
							expandCollection.Add(cursymbol)
						End If

						' Set connected link as visible too.
						outlink.Visible = True
						expandCollection.Add(outlink)
					End If
				Next curEdge
			End If
		End If
		ExpandedCollection = expandCollection
		' If this symbol is node under mouse click set node state as 
		' expaned by make plus vertical line visibly.
		If clickednode AndAlso HasChild() Then
			' Set symbol shapes to indicate an expanded state.
			m_bExpanded = True
		End If
		Return expandCollection
	End Function

	''' <summary>
	''' Create a new method for collapse current node
	''' </summary>
	''' <param name="SelectedNode"></param>


	Public Function CollapseSubNodes(ByVal clickednode As Boolean) As NodeCollection
		Dim collapsedCollection As New NodeCollection()
		Dim thisNode As IGraphNode = TryCast(Me, IGraphNode)
		If thisNode IsNot Nothing Then
			Dim edgesLeaving As ICollection = thisNode.EdgesLeaving
			If edgesLeaving IsNot Nothing Then
				' Convert to collection of IGraphEdges type.
				For Each curEdge As IGraphEdge In edgesLeaving
					' Get from IGraphEdge link.
					Dim outlink As ConnectorBase = TryCast(curEdge, ConnectorBase)
					If outlink IsNot Nothing Then
						' Get from link current symbol children.
						Dim cursymbol As EmpSymbol = TryCast(outlink.ToNode, EmpSymbol)
						If cursymbol IsNot Nothing Then
							' Colapse nodes in child symbol.
							cursymbol.CollapseSubNodes(False)

							' Set current symbol as invisible.
							cursymbol.Visible = False
						End If
						' Set connected link as invisible too.
						outlink.Visible = False
						'CollapsedCollection.Add(outlink);
					End If
				Next curEdge
			End If
		End If
		Me.CollapsedCollection = collapsedCollection
		' If this symbol is node under mouse click set node state as 
		' expaned by make plus vertical line visibly.
		If clickednode AndAlso HasChild() Then
			' Set symbol shapes to indicate a collapsed state.
			m_bExpanded = False

		End If
		Return collapsedCollection
	End Function

	#End Region 

	#Region "Class helper methods"
	''' <summary>
	''' Create a new method for whether current node has children or not.
	''' </summary>
	''' <returns></returns>
	Private Function HasChild() As Boolean
		Return Me.EdgesLeaving.Count > 0
	End Function
	''' <summary>
	''' Create a new method for Drawing in current node.
	''' </summary>
	''' <param name="gfx"></param>
	Public Sub DrawPlusMinus(ByVal gfx As Graphics)
		If HasChild() Then
			Dim length As Integer = 12
			Dim szOffset As New SizeF(length, length)

			' horizontal
			Dim ptsHorizontal() As PointF = { New PointF(szOffset.Width -length\2, szOffset.Height), New PointF(szOffset.Width + length\2, szOffset.Height) }

			' vertical
			Dim ptsVertical() As PointF = { New PointF(szOffset.Width, szOffset.Height-length\2), New PointF(szOffset.Width, szOffset.Height + length\2) }

			Using penHightlight As New Pen(Color.Gray, 1)
			Using pen As New Pen(Color.Black, 1)
				If Not m_bExpanded Then
					If SymbolShapeType = SymbolShape.PlusMinus Then
						gfx.DrawLine(pen, ptsVertical(0), ptsVertical(1))
						gfx.DrawLine(penHightlight, ptsVertical(0), ptsVertical(1))
					ElseIf SymbolShapeType = SymbolShape.RightDownTriangle Then
					   ' PointF[] pts = { new PointF(8, 12), new Point(16, 8), new PointF(16, 16) };
						Dim pts() As PointF = { New PointF(8, 8), New Point(8, 16), New PointF(12, 14), New PointF(16, 12) }

						gfx.DrawPolygon(pen, pts)
						gfx.FillPolygon(Brushes.LightGray, pts, FillMode.Winding)
					End If
				Else
					If SymbolShapeType = SymbolShape.RightDownTriangle Then
						Dim pts() As PointF = {New PointF (8,8),New PointF(16,8),New PointF(12,16) }
						gfx.DrawPolygon(pen, pts)
						gfx.FillPolygon(Brushes.LightGray, pts, FillMode.Winding)
					End If
				End If
				If SymbolShapeType = SymbolShape.PlusMinus Then
					gfx.DrawLine(pen, ptsHorizontal(0), ptsHorizontal(1))
					gfx.DrawLine(penHightlight, ptsHorizontal(0), ptsHorizontal(1))
				End If
				If BackgroundShapeType = BackgroundShape.ellipse Then
					gfx.DrawEllipse(pen, 3, 3, 18, 18)
				ElseIf BackgroundShapeType = BackgroundShape.Rectangle Then
					gfx.DrawRectangle(pen, 3, 3, 18, 18)
				End If
			End Using
			End Using
		End If
	End Sub
	''' <summary>
	''' Create a new method to get NodeCollection of current node.
	''' </summary>
	''' <returns></returns>
	Private Function GetSubNodes() As NodeCollection
		Dim nodes As New NodeCollection()

		For Each edge As IGraphEdge In Me.EdgesLeaving
			Dim toNode As Node = TryCast(edge.ToNode, Node)

			If toNode IsNot Nothing Then
				nodes.Add(toNode)
			End If
		Next edge

		Return nodes
	End Function

	#End Region
End Class
