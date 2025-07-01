Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Runtime.Serialization
Imports Syncfusion.Drawing
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Namespace FolderBrowser


	'we override the Model to create the create a new cell renderer for our control
	Public Class TreeCellModel : Inherits GridStaticCellModel

		Protected Sub New(ByVal info As SerializationInfo, ByVal context As StreamingContext)
			MyBase.New(info, context)
		End Sub

		Public Sub New(ByVal grid As GridModel)
			MyBase.New(grid)

		End Sub

		'note that this method create our new derived renderer
		Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
			Return New TreeCellRenderer(control, Me)
		End Function

	End Class

	' handles drawing our indented cell
	Public Class TreeCellRenderer: Inherits GridStaticCellRenderer
		Private _indentSize As Integer
		Private bitmapWidth As Integer
		Private bitmapHeight As Integer
		Public Shared nodeList As Hashtable

		Public Property IndentSize() As Integer
			Get
				Return _indentSize
			End Get
			Set
				If Value >= 0 Then
					_indentSize = Value
				Else
					_indentSize = 0
				End If
			End Set

		End Property
		Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
			MyBase.New(grid, cellModel)
			_indentSize = 20
			bitmapWidth = 20
			bitmapHeight = 17
			nodeList = New Hashtable()
			nodeList.Add(Me.Grid.Model(1, 3).Text, "Added")
		End Sub

		Protected Overrides Sub OnDraw(ByVal g As System.Drawing.Graphics, ByVal clientRectangle As System.Drawing.Rectangle, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As Syncfusion.Windows.Forms.Grid.GridStyleInfo)
			If clientRectangle.IsEmpty Then
				Return
			End If

			Dim imageIndex As Integer = style.ImageIndex
			Dim imageList As ImageList = style.ImageList
			If imageIndex <> -1 AndAlso Not imageList Is Nothing AndAlso imageIndex < imageList.Images.Count Then
                Try
                    Dim rect As Rectangle = GetCellBoundsCore(rowIndex, colIndex)
                    Dim X As Integer = rect.X + IndentSize * CInt(Fix(style.Tag))
                    If Me.Grid.Model(rowIndex, 5).CellValue.ToString() = "Directory" Then
                        g.DrawImage(CType(imageList.Images(imageIndex), Bitmap), X, rect.Y)
                    End If
                    'now draw text past the image...
                    Dim drawDisabled As Boolean = False
                    Dim displayText As String = String.Empty

                    X += imageList.Images(imageIndex).Width + 2


                    If Me.Grid.Model(rowIndex, 5).CellValue.ToString() = "Directory" Then
                        Dim imageIndex3 As Integer = imageIndex + 3
                        g.DrawImage(CType(imageList.Images(imageIndex3), Bitmap), X, rect.Y)
                        X += imageList.Images(imageIndex3).Width + 2
                    End If
                    If Me.Grid.Model(rowIndex, 5).CellValue.ToString() = "File" Then
                        Dim imageIndex4 As Integer = 5
                        g.DrawImage(CType(imageList.Images(imageIndex4), Bitmap), X, rect.Y)
                        X += imageList.Images(imageIndex4).Width + 2
                    End If

                    Dim textRectangle As Rectangle = RemoveMargins(clientRectangle, style)
                    Dim shift As Integer = X - textRectangle.X
                    textRectangle.X = X
                    textRectangle.Width -= shift
                    If textRectangle.IsEmpty Then
                        Return
                    End If

                    Try
                        displayText = Model.GetFormattedOrActiveTextAt(rowIndex, colIndex, style)
                    Catch
                        displayText = style.Text
                        'style.ToolTip = ex.Message;
                        drawDisabled = True
                    End Try

                    If style.HasError Then
                        displayText = style.Error
                        drawDisabled = True
                    End If

                    If displayText.Length > 0 Then
                        Dim font As Font = style.Font.GdipFont
                        Dim textColor As Color
                        If Grid.Model.Properties.BlackWhite Then
                            textColor = Color.Black
                        Else
                            textColor = style.TextColor
                        End If
                        DrawText(g, displayText, font, textRectangle, style, textColor, drawDisabled)
                    End If
                Catch
                End Try
			End If
		End Sub

		'		protected override void OnClick(int rowIndex, int colIndex, System.Windows.Forms.MouseEventArgs e)
		'		{
		'		//if you call ClickTreeNode here instead of OnMouseDown, 
		'		//then the action is done later after the mouseup...
		'		//	ClickTreeNode(rowIndex, colIndex, e);
		'			base.OnClick(rowIndex, colIndex, e);
		'			return;
		'		}


		Private Sub ClickTreeNode(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal e As System.Windows.Forms.MouseEventArgs)
			Dim rect As Rectangle = GetCellBoundsCore(rowIndex, colIndex)
			Dim X As Integer = rect.X + IndentSize * CInt(Me.Grid.Model(rowIndex, colIndex).Tag)

			rect.X = X
			rect.Width = Me.bitmapWidth
			rect.Height = Me.bitmapHeight

			If rect.Contains(New Point(e.X, e.Y)) Then
				If Me.Grid.Model(rowIndex, colIndex).ImageIndex = CInt(TreeNodeState.Opened) Then
					Me.Grid.Model(rowIndex, colIndex).ImageIndex = CInt(TreeNodeState.Closed)
					'OnCollapseRow(rowIndex);
				Else If Me.Grid.Model(rowIndex, colIndex).ImageIndex = CInt(TreeNodeState.Closed) Then
					Me.Grid.Model(rowIndex, colIndex).ImageIndex = CInt(TreeNodeState.Opened)
					If (Not nodeList.Contains(Me.Grid.Model(rowIndex, 3).Text)) Then
						OnExpandRow(rowIndex)
					End If
				End If
			End If

			Me.Grid.Refresh()
			Me.Grid.Model.ColWidths.ResizeToFit(GridRangeInfo.Table())
		End Sub


		Public Overridable Sub OnExpandRow(ByVal row As Integer)
			Dim indent As Integer = TreeGridForm.externalData(row-1).IndentLevel
			TreeGridForm.externalData.InsertData(row, Me.Grid.Model(row,3).Text, indent)
			nodeList.Add(Me.Grid.Model(row,3).Text,"Added")
		End Sub


		Public Overridable Sub OnCollapseRow(ByVal row As Integer)
            Console.WriteLine("OnCollapseRow " & row.ToString())
		End Sub

		'cheap way to get row col to menuhandler
		Private _rowIndex As Integer
		Private _colIndex As Integer

		Protected Overrides Sub OnMouseDown(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal e As System.Windows.Forms.MouseEventArgs)
			If e.Button = MouseButtons.Right Then
				_rowIndex = rowIndex
				_colIndex = colIndex

			Else
				MyBase.OnMouseDown(rowIndex, colIndex, e)
				ClickTreeNode(rowIndex, colIndex, e)
			End If
		End Sub

		Private Sub HandleIndent(ByVal sender As Object, ByVal e As EventArgs)
			Dim style As GridStyleInfo = Me.Grid.Model(_rowIndex, _colIndex)

			'use update to avoid multiple calls to SaveCellInfo..
			style.BeginUpdate()
			style.Tag = CInt(style.Tag) + 1
			style.ImageIndex = CInt(TreeNodeState.NoChildren)
			style.EndUpdate()
		End Sub

		Private Sub HandleMatch(ByVal sender As Object, ByVal e As EventArgs)
			If _rowIndex > 1 Then
				Dim style As GridStyleInfo = Me.Grid.Model(_rowIndex, _colIndex)

				'use update to avoid multiple calls to SaveCellInfo..
				style.BeginUpdate()
				style.Tag = CInt(Me.Grid.Model(_rowIndex - 1, _colIndex).Tag)
				style.EndUpdate()
			End If

		End Sub

		Private Sub HandleOutdent(ByVal sender As Object, ByVal e As EventArgs)
            Me.Grid.Model(_rowIndex, _colIndex).Tag = IIf((CInt(Me.Grid.Model(_rowIndex, _colIndex).Tag) > 0), CInt(Me.Grid.Model(_rowIndex, _colIndex).Tag - 1), 0)

		End Sub

		Protected Overrides Function OnHitTest(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal e As MouseEventArgs, ByVal controller As IMouseController) As Integer
			If e.Button <> MouseButtons.None Then
				'return a cell hit so OnMouseDown will be called later
				Return GridHitTestContext.Cell
			Else
				Return 0
			End If
		End Function

	End Class


End Namespace
