#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports Microsoft.VisualBasic
Imports Syncfusion.Styles
Imports Syncfusion.Windows.Forms.Grid
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace CustomGridCell
    Public Class TreeCellRenderer
        Inherits GridStaticCellRenderer
        Private _indentSize As Integer
        Private bitmapWidth As Integer
        Private bitmapHeight As Integer
        Private _rowIndex As Integer
        Private _colIndex As Integer
        'Fields
        'Constructors
        'Methods
        Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
            MyBase.New(grid, cellModel)
            _indentSize = 20
            bitmapWidth = 20
            bitmapHeight = 17

        End Sub
        Public Property IndentSize() As Integer
            Get

                Return _indentSize

            End Get
            Set(ByVal Value As Integer)

                If (Value >= 0) Then
                    _indentSize = Value
                Else
                    _indentSize = 0
                End If

            End Set
        End Property
       
        Protected Overloads Overrides Sub OnClick(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal e As MouseEventArgs)

           
            Dim rect As Rectangle
            rect = GetCellBoundsCore(rowIndex, colIndex)
            Dim X As Integer
            X = (rect.X _
                        + (IndentSize * CType(Me.Grid.Model(rowIndex, colIndex).Tag, Integer)))
            rect.X = X
            rect.Width = Me.bitmapWidth
            rect.Height = Me.bitmapHeight
            '			}
            If rect.Contains(New Point(e.X, e.Y)) Then
                If (Me.Grid.Model(rowIndex, colIndex).ImageIndex = CType(TreeNodeState.Opened, Integer)) Then
                    Me.Grid.Model(rowIndex, colIndex).ImageIndex = CType(TreeNodeState.Closed, Integer)

                Else
                    If (Me.Grid.Model(rowIndex, colIndex).ImageIndex = CType(TreeNodeState.Closed, Integer)) Then
                        Me.Grid.Model(rowIndex, colIndex).ImageIndex = CType(TreeNodeState.Opened, Integer)

                    End If
                End If
            End If
            MyBase.OnClick(rowIndex, colIndex, e)

        End Sub
        Protected Overloads Overrides Sub OnMouseDown(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal e As MouseEventArgs)

            If (e.Button = MouseButtons.Right) Then
                _rowIndex = rowIndex
                _colIndex = colIndex
                'add a context menu
                Dim contextMenu As ContextMenu
                contextMenu = New ContextMenu()
                Dim item As MenuItem
                item = New MenuItem("Indent", New EventHandler(AddressOf HandleIndent))
                contextMenu.MenuItems.Add(item)
                item = New MenuItem("Outdent", New EventHandler(AddressOf HandleOutdent))
                contextMenu.MenuItems.Add(item)
                item = New MenuItem("MatchTop", New EventHandler(AddressOf HandleMatch))
                contextMenu.MenuItems.Add(item)
                contextMenu.Show(Me.Grid, New Point(e.X, e.Y))
            Else
                MyBase.OnMouseDown(rowIndex, colIndex, e)
            End If

        End Sub
        Protected Overloads Overrides Function OnHitTest(ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal e As MouseEventArgs, ByVal controller As Syncfusion.Windows.Forms.IMouseController) As Integer

            If (e.Button = MouseButtons.Right) Then
                'return a cell hit so OnMouseDown will be called later
                Return GridHitTestContext.Cell
            Else
                Return 0
            End If

        End Function
        Protected Overloads Overrides Sub OnDraw(ByVal g As Graphics, ByVal clientRectangle As Rectangle, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo)

            If clientRectangle.IsEmpty Then
                Return
            End If
            Dim imageIndex As Integer
            imageIndex = style.ImageIndex
            Dim imageList As imageList
            imageList = style.ImageList
            If (((imageIndex <> -(1)) _
                        AndAlso (Not (imageList) Is Nothing)) _
                        AndAlso (imageIndex < imageList.Images.Count)) Then
                Try
                    Dim rect As Rectangle
                    rect = GetCellBoundsCore(rowIndex, colIndex)
                    Dim X As Integer
                    X = (rect.X _
                                + (IndentSize * CType(style.Tag, Integer)))
                    g.DrawImage(CType(imageList.Images(imageIndex), Bitmap), X, rect.Y)
                    'now draw text past the image...
                    Dim drawDisabled As Boolean
                    drawDisabled = False
                    Dim displayText As String
                    displayText = String.Empty
                    X = (X _
                                + (imageList.Images(imageIndex).Width + 2))
                    Dim textRectangle As Rectangle
                    textRectangle = RemoveMargins(clientRectangle, style)
                    Dim shift As Integer
                    shift = (X - textRectangle.X)
                    textRectangle.X = X
                    textRectangle.Width = (textRectangle.Width - shift)
                    If textRectangle.IsEmpty Then
                        Return
                    End If
                    Try
                        displayText = Model.GetFormattedOrActiveTextAt(rowIndex, colIndex, style)
                    Catch ex As System.Exception
                        displayText = style.Text

                        drawDisabled = True
                    End Try
                    If style.HasError Then
                        displayText = style.Error
                        drawDisabled = True
                    End If
                    If (displayText.Length > 0) Then
                        Dim font As font
                        font = style.Font.GdipFont
                        Dim textColor As Color
                        textColor = IIf(Grid.Model.Properties.BlackWhite, Color.Black, style.TextColor)
                        DrawText(g, displayText, font, textRectangle, style, textColor, drawDisabled)
                    End If
                Catch ex As System.Exception
                End Try
            End If

        End Sub
        Private Sub HandleIndent(ByVal sender As Object, ByVal e As EventArgs)

            Dim style As GridStyleInfo
            style = Me.Grid.Model(_rowIndex, _colIndex)
            'use update to avoid multiple calls to SaveCellInfo..
            style.BeginUpdate()
            style.Tag = (CType(style.Tag, Integer) + 1)
            style.ImageIndex = CType(TreeNodeState.NoChildren, Integer)
            style.EndUpdate()

        End Sub
        Private Sub HandleMatch(ByVal sender As Object, ByVal e As EventArgs)

            If (_rowIndex > 1) Then
                Dim style As GridStyleInfo
                style = Me.Grid.Model(_rowIndex, _colIndex)
                'use update to avoid multiple calls to SaveCellInfo..
                style.BeginUpdate()
                style.Tag = CType(Me.Grid.Model((_rowIndex - 1), _colIndex).Tag, Integer)
                style.EndUpdate()
            End If

        End Sub
        Private Sub HandleOutdent(ByVal sender As Object, ByVal e As EventArgs)

            Me.Grid.Model(_rowIndex, _colIndex).Tag = IIf((CType(Me.Grid.Model(_rowIndex, _colIndex).Tag, Integer) > 0), (CType(Me.Grid.Model(_rowIndex, _colIndex).Tag, Integer) - 1), 0)

        End Sub
    End Class
End Namespace
