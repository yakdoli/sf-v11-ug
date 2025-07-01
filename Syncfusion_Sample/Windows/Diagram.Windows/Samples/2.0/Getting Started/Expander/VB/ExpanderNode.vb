Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Syncfusion.Windows.Forms.Diagram
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.Windows.Forms


	Public Class ExpanderNode
		Inherits RoundRect
		#Region "Members        "
		Private m_bIsExpander As Boolean
		Private m_bExpanded As Boolean = True
		Private m_timer As Timer = Nothing
		Private m_iCount As Integer = 0
		Private CollapsedCollection As New NodeCollection()
		Private ExpandedCollection As New NodeCollection()
		#End Region

		#Region "Initialization             "
		Public Sub New(ByVal bounds As RectangleF)
			MyBase.New(bounds)

			Me.CurveRadius = 25
        Me.FillStyle.Color = Color.FromArgb(242, 242, 242)
        Me.FillStyle.ForeColor = Color.White
        Me.FillStyle.Type = FillStyleType.LinearGradient
        Me.FillStyle.GradientAngle = 90
        Me.FillStyle.GradientCenter = 1
			Me.EditStyle.AllowSelect = False

		End Sub
		#End Region

		#Region "Properties"
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
				If value <> m_bIsExpander AndAlso OnPropertyChanging(Me.FullContainerName, "IsExpander",value) Then
					m_bIsExpander = value
					OnPropertyChanged(Me.FullContainerName, "IsExpander")
				End If
			End Set
		End Property
		#End Region

		#Region "Overrides        "
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
    Protected Overrides Sub OnMouseLeave(ByVal e As System.EventArgs)
        MyBase.OnMouseLeave(e)
        Me.IsExpander = False
    End Sub

		Protected Overrides Sub Render(ByVal gfx As Graphics)
			MyBase.Render(gfx)
			DrawExpander(gfx)
		End Sub

		Public Sub MouseMove(ByVal ptLocation As PointF)
			Dim pt As PointF = Me.ConvertToNodeCoordinates(ptLocation)
			Dim rect As New RectangleF(Me.Size.Width \ 2 - 7.5f, Me.Size.Height - 20, 15, 15)
			If rect.Contains(pt) Then
				Me.IsExpander = True
			Else
				Me.IsExpander = False
			End If
		End Sub
		#End Region

		#Region "Public methods        "
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
							Dim cursymbol As ExpanderNode = TryCast(outlink.ToNode, ExpanderNode)
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
							Dim cursymbol As ExpanderNode = TryCast(outlink.ToNode, ExpanderNode)
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

		#Region "Helper methods        "

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

		Private Function HasChild() As Boolean
			Return Me.EdgesLeaving.Count > 0
		End Function

		Private Sub DrawExpander(ByVal gfx As Graphics)
			If HasChild() Then
				Dim state As GraphicsState = gfx.Save()
				Dim fillStyle As New FillStyle()
				fillStyle.Color = Color.FromArgb(242, 242, 242)
				fillStyle.ForeColor = Color.FromArgb(247, 247, 247)
				fillStyle.Type = FillStyleType.LinearGradient
            Using brush As Brush = fillStyle.CreateBrush(gfx, New RectangleF(Me.Size.Width / 2 - 7.5F, Me.Size.Height - 20, 15, 15))
                gfx.FillEllipse(brush, New RectangleF(Me.Size.Width / 2 - 7.5F, Me.Size.Height - 20, 15, 15))
                gfx.DrawEllipse(Pens.Gray, New RectangleF(Me.Size.Width / 2 - 7.5F, Me.Size.Height - 20, 15, 15))
            End Using
				Dim pen As Pen
				If m_bIsExpander Then
					pen = New Pen(Brushes.Black, 1.6f)
                gfx.DrawEllipse(pen, Me.Size.Width / 2 - 7.5F, Me.Size.Height - 20, 15, 15)
				End If
				pen = New Pen(Color.DarkRed, 2)
				If Not m_bExpanded Then
					pen.Color = Color.Green
                gfx.DrawLine(pen, New PointF(Me.Size.Width / 2, Me.Size.Height - 15), New PointF(Me.Size.Width / 2, Me.Size.Height - 9))
				End If
            gfx.DrawLine(pen, New PointF(Me.Size.Width / 2 - 3, Me.Size.Height - 12.0F), New PointF(Me.Size.Width / 2 - 3 + 6, Me.Size.Height - 12.0F))
				gfx.Restore(state)
			End If
		End Sub
		#End Region
	End Class

