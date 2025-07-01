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

Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Imports Syncfusion.Diagnostics
Imports Syncfusion.Styles
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid

Namespace ExcelTipDLL
#Region "the Mouse Controller" '

    Public Class CommentMouseController
        Implements IMouseController

        Private Const redCornerSize As Integer = 10
        Private Const blackArrowSize As Integer = 5

        Private owner As GridControlBase
        Private lastHitTestCode As Integer = GridHitTestContext.None
        Private Const HitComment As Integer = 101

        Private commentWindow As GridCellComment
        Private cornerSize As Integer = 8
        Private redrawRect As Rectangle = Rectangle.Empty

        Private cursor1 As Cursor
        Private commentRow As Integer
        Private commentCol As Integer

        Private contextMenuEnabled1 As Boolean
        Private cornerBrush1 As Brush

        Public Sub New()

        End Sub 'New

        Public Sub New(ByVal owner As GridControlBase)
            Me.owner = owner
            commentWindow = New GridCellComment()
            commentWindow.CommentCorner = New Size(0, 0)
            owner.Controls.Add(commentWindow)

            AddHandler owner.CellDrawn, AddressOf grid_CellDrawn

            AddHandler owner.TopRowChanging, AddressOf grid_Scrolling
            AddHandler owner.LeftColChanging, AddressOf grid_Scrolling
            AddHandler owner.MouseDown, AddressOf grid_MouseDown

            cornerBrush1 = Brushes.Red 'default color
            GridExcelTipStyleProperties.Initialize()
        End Sub 'New

#Region "Properties"
        Public Property ContextMenuEnabled() As Boolean
            Get
                Return contextMenuEnabled1
            End Get
            Set(ByVal Value As Boolean)
                If Value <> contextMenuEnabled1 Then
                    contextMenuEnabled1 = Value
                    If contextMenuEnabled1 Then
                        AddHandler owner.MouseUp, AddressOf grid_ContextMouseUp
                    Else
                        RemoveHandler owner.MouseUp, AddressOf grid_ContextMouseUp
                    End If
                End If
            End Set
        End Property

        Public Property CornerBrush() As Brush
            Get
                Return cornerBrush1
            End Get
            Set(ByVal Value As Brush)
                cornerBrush1 = Value
            End Set
        End Property

        Public Property CommentCornerSize() As Integer
            Get
                Return cornerSize
            End Get
            Set(ByVal Value As Integer)
                cornerSize = Value
            End Set
        End Property
#End Region

#Region "IMouseController"

        Public ReadOnly Property Name() As String Implements IMouseController.Name
            Get
                Return "Comment"
            End Get
        End Property

        Public ReadOnly Property Cursor() As Cursor Implements IMouseController.Cursor
            Get
                If cursor1 Is Nothing Then
                    Dim stream As System.IO.Stream = commentWindow.GetType().Module.Assembly.GetManifestResourceStream("ExcelTipDLL.cross.CUR")
                    If Not (stream Is Nothing) Then
                        cursor1 = New Cursor(stream)
                    Else
                        cursor1 = Cursors.Cross
                    End If
                Else
                    cursor1 = Cursors.Default
                End If
                ' could check latestHitTestCode here if this controller has
                ' different HitTest states. Cursor will only be called if 
                ' previous call to HitTest was successfull.
                Return cursor1
            End Get
        End Property

        Public Sub CancelMode() Implements IMouseController.CancelMode
            If Me.commentWindow.Visible Then
                Me.commentWindow.Hide()
                Me.owner.Invalidate(redrawRect)
            End If
        End Sub 'CancelMode


        Public Function HitTest(ByVal e As MouseEventArgs, ByVal controller As IMouseController) As Integer Implements IMouseController.HitTest
            lastHitTestCode = GridHitTestContext.None

            Dim pt As New Point(e.X, e.Y)
            Dim rowIndex, colIndex As Integer
            owner.PointToRowCol(pt, rowIndex, colIndex)
            Dim rect As Rectangle = GetCorner(rowIndex, colIndex)
            If rect.Contains(pt) AndAlso Not Me.commentWindow.editTextBox.Visible Then
                Dim style As GridStyleInfo = owner.Model(rowIndex, colIndex)
                If isExcelTipCell(style) Then
                    lastHitTestCode = HitComment
                End If
            End If

            Return lastHitTestCode
        End Function 'HitTest

        Public Sub MouseHoverEnter() Implements IMouseController.MouseHoverEnter
        End Sub 'MouseHoverEnter

        '/ <summary>
        '/ User is moving the mouse over the hot-test area
        '/ </summary>
        '/ <param name="e"></param>
        Public Sub MouseHover(ByVal e As MouseEventArgs) Implements IMouseController.MouseHover
            If Not Me.commentWindow.Visible Then ' && !inDraw)
                'inDraw = true;
                'translate the point to top right corner...
                Dim rowIndex, colIndex As Integer
                Dim pt As New Point(e.X, e.Y)

                owner.PointToRowCol(pt, rowIndex, colIndex, -1)
                Dim hidden As Boolean
                Dim clientRow As Integer = owner.ViewLayout.RowIndexToVisibleClient(rowIndex, hidden)
                Dim clientCol As Integer = owner.ViewLayout.ColIndexToVisibleClient(colIndex, hidden)
                pt = owner.ViewLayout.ClientRowColToPoint(clientRow, clientCol, GridCellSizeKind.ActualSize)

                pt.X += owner.Model.ColWidths(colIndex)


                Dim style As New GridExcelTipStyleProperties(owner.Model(rowIndex, colIndex))
                Me.commentWindow.InitializeComment(rowIndex, colIndex, pt, style)
                Dim ploc As Point = Me.commentWindow.Location
                Me.commentWindow.Location = New Point(10000, 10000)
                Me.commentWindow.comment.Visible = True
                Me.commentWindow.editTextBox.Visible = False

                'show the windows
                Me.commentWindow.Show()
                Me.commentWindow.Update()
                Me.owner.Update()

                'draw the pointer
                Dim g As Graphics = Graphics.FromHwnd(Me.owner.Handle)
                Dim pt1 As New Point(pt.X + Me.commentWindow.CommentCorner.Width, pt.Y - Me.commentWindow.CommentCorner.Height)
                redrawRect = New Rectangle(pt.X, pt.Y - Me.commentWindow.CommentCorner.Height, Me.commentWindow.CommentCorner.Width + 1, Me.commentWindow.CommentCorner.Height + 1)
                g.DrawLine(Pens.Black, pt, pt1)
                Dim topLeft As New Point(pt.X, pt.Y - blackArrowSize + 1)
                Dim bottomLeft As New Point(pt.X, pt.Y + 1)
                Dim bottomRight As New Point(pt.X + blackArrowSize - 1, pt.Y + 1)
                g.FillPolygon(Brushes.Black, New Point() {topLeft, bottomLeft, bottomRight, topLeft})
                g.Dispose()
                'Console.WriteLine("draw the pointer" + Environment.TickCount.ToString());  
                'inDraw = false;
                Me.commentWindow.Location = ploc
            End If
        End Sub 'MouseHover


        '/ <summary>
        '/ Called when the hovering ends, either when user has moved mouse away from hittest area
        '/ or when the user has pressed a mouse button.
        '/ </summary>
        Public Sub MouseHoverLeave(ByVal e As EventArgs) Implements IMouseController.MouseHoverLeave
            If Me.commentWindow.comment.Visible Then
                Me.commentWindow.Hide()
                Me.owner.Invalidate(redrawRect)
            End If
        End Sub 'MouseHoverLeave


        Public Sub MouseDown(ByVal e As MouseEventArgs) Implements IMouseController.MouseDown
        End Sub 'MouseDown


        '/ <summary>
        '/ User has dragged mouse. If mouse is down, set current position.
        '/ </summary>
        '/ <param name="e"></param>
        Public Sub MouseMove(ByVal e As MouseEventArgs) Implements IMouseController.MouseMove
        End Sub 'MouseMove



        '/ <summary>
        '/ User has release mouse button. Stop automatic scrolling.
        '/ </summary>
        '/ <param name="e"></param>
        Public Sub MouseUp(ByVal e As MouseEventArgs) Implements IMouseController.MouseUp
            If e.Button = MouseButtons.Left Then
                leftClickOnMark = True
                grid_ContextMouseUp(owner, e)
            End If
        End Sub 'MouseUp
#End Region

#Region "Context Menu Code"

        Private theContextMenu As ContextMenu
        Private rightClickRow, rightClickCol As Integer
        Private leftClickOnMark As Boolean = False

        Private Sub grid_ContextMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            If e.Button = MouseButtons.Right OrElse leftClickOnMark Then
                Dim pt As New Point(e.X, e.Y)
                If Me.owner.PointToRowCol(pt, rightClickRow, rightClickCol) Then
                    Dim menu As MenuItem

                    If isExcelTipCell(Me.owner.Model(rightClickRow, rightClickCol)) Then
                        menu = New MenuItem("Remove Comment", New EventHandler(AddressOf remove_Comment))
                        Dim menu1 As New MenuItem("Edit Comment", New EventHandler(AddressOf edit_Comment))
                        theContextMenu = New ContextMenu(New MenuItem() {menu, menu1})
                    Else
                        menu = New MenuItem("Add Comment", New EventHandler(AddressOf add_Comment))
                        theContextMenu = New ContextMenu(New MenuItem() {menu})
                    End If

                    theContextMenu.Show(Me.owner, pt)
                End If
            End If
            leftClickOnMark = False
        End Sub 'grid_ContextMouseUp


        Private Sub edit_Comment(ByVal sender As Object, ByVal e As EventArgs)
            StartEditing()
        End Sub 'edit_Comment


        Private Sub StartEditing()
            Dim style As New GridExcelTipStyleProperties(owner.Model(rightClickRow, rightClickCol))
            Dim pt As Point = Me.owner.ViewLayout.ClientRowColToPoint(rightClickRow, rightClickCol, GridCellSizeKind.ActualSize)
            pt.X += Me.owner.Model.ColWidths(rightClickCol)
            Me.commentWindow.InitializeComment(rightClickRow, rightClickCol, pt, style)

            EditComment(rightClickRow, rightClickCol)
        End Sub 'StartEditing


        Private Sub add_Comment(ByVal sender As Object, ByVal e As EventArgs)
            Dim style As New GridExcelTipStyleProperties(owner.Model(rightClickRow, rightClickCol))
            style.ExcelTipText = ""
            StartEditing()
        End Sub 'add_Comment


        Private Sub remove_Comment(ByVal sender As Object, ByVal e As EventArgs)
            Dim style As New GridExcelTipStyleProperties(owner.Model(rightClickRow, rightClickCol))
            style.ResetExcelTipText()
        End Sub 'remove_Comment
#End Region

#Region "Helpers"
        Function GetCorner(ByVal row As Integer, ByVal col As Integer) As Rectangle
            Dim bounds As Rectangle = owner.RangeInfoToRectangle(GridRangeInfo.Cell(row, col), GridRangeOptions.None)
            bounds = New Rectangle(bounds.X + bounds.Width - Me.CommentCornerSize - 1, bounds.Y, Me.CommentCornerSize, Me.CommentCornerSize)
            bounds.Intersect(owner.ClientRectangle)
            Return bounds
        End Function 'GetCorner


        Private Function isExcelTipCell(ByVal style As GridStyleInfo) As Boolean
            Dim style1 As New GridExcelTipStyleProperties(style)
            Return style1.HasExcelTipText
        End Function 'isExcelTipCell


        Private Sub grid_CellDrawn(ByVal sender As Object, ByVal e As GridDrawCellEventArgs)
            If isExcelTipCell(e.Style) AndAlso (Not Me.owner.CurrentCell.HasCurrentCellAt(e.RowIndex, e.ColIndex) OrElse Not Me.owner.CurrentCell.IsEditing) Then
                Dim topLeft As New Point(e.Bounds.X + e.Bounds.Width - CommentCornerSize, e.Bounds.Y)
                Dim topRight As New Point(e.Bounds.X + e.Bounds.Width, e.Bounds.Y)
                Dim bottomRight As New Point(e.Bounds.X + e.Bounds.Width, e.Bounds.Y + CommentCornerSize)
                e.Graphics.FillPolygon(cornerBrush1, New Point() {topLeft, topRight, bottomRight, topLeft})
            End If
        End Sub 'grid_CellDrawn
#End Region

#Region "Comment Edit Code"


        Private Sub EditComment(ByVal row As Integer, ByVal col As Integer)
            commentRow = row
            commentCol = col

            Dim pt As Point = Me.commentWindow.comment.Location
            pt.Offset(5, 5)
            Me.commentWindow.editTextBox.Location = pt

            Me.commentWindow.editTextBox.Size = New Size(Me.commentWindow.comment.Width - 5, Me.commentWindow.comment.Height - 5)
            'this.commentWindow.Show();
            Me.commentWindow.comment.Hide()

            'make sure there is space for some more lines...
            Dim diff As Integer = Math.Max(Me.commentWindow.Height, 60) - Me.commentWindow.Height
            If diff > 0 Then
                Me.commentWindow.Height += diff
                Me.commentWindow.editTextBox.Height += diff
            End If

            'make wide enough
            Me.commentWindow.editTextBox.Width = Math.Max(Me.commentWindow.Width - 10, Me.commentWindow.editTextBox.Width)

            Me.commentWindow.editTextBox.Show()
            Me.commentWindow.ActiveControl = Me.commentWindow.editTextBox

            AddHandler commentWindow.Leave, AddressOf textBox_Leave
            AddHandler commentWindow.editTextBox.TextChanged, AddressOf textbox_Changed
            Dim p As Point = owner.PointToClient(owner.LastMousePosition)
            Me.commentWindow.Location = p
            'this.commentWindow.Parent = null;
            'this.commentWindow.TopLevel = true;
            Me.commentWindow.Show()
            Me.commentWindow.editTextBox.Focus()
            Me.owner.WantKeys = False
        End Sub 'EditComment



        Private Sub textBox_Leave(ByVal sender As Object, ByVal e As EventArgs)
            If Me.commentWindow.editTextBox.Modified Then
                Dim style As New GridExcelTipStyleProperties(owner.Model(commentRow, commentCol))
                style.ExcelTipText = Me.commentWindow.editTextBox.Text
                Me.commentWindow.editTextBox.Modified = False
            End If

            RemoveHandler commentWindow.Leave, AddressOf textBox_Leave
            RemoveHandler commentWindow.editTextBox.TextChanged, AddressOf textbox_Changed

            Me.commentWindow.editTextBox.Hide()
            Me.commentWindow.Hide()
            Me.owner.Invalidate(redrawRect)
            Me.owner.WantKeys = True
        End Sub 'textBox_Leave

        Private Sub textbox_Changed(ByVal sender As Object, ByVal e As EventArgs)
            Me.commentWindow.editTextBox.Modified = True
        End Sub 'textbox_Changed


        Private Sub grid_Scrolling(ByVal sender As Object, ByVal e As GridRowColIndexChangingEventArgs)
            Me.CancelMode()
        End Sub 'grid_Scrolling


        Private Sub grid_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim rowIndex, colIndex As Integer
            owner.PointToRowCol(New Point(e.X, e.Y), rowIndex, colIndex)
            If rowIndex <> Me.commentRow OrElse colIndex <> Me.commentRow AndAlso Me.commentWindow.editTextBox.Visible Then
                textBox_Leave(sender, e)
            End If
        End Sub 'grid_MouseDown 
#End Region
    End Class 'CommentMouseController 


#End Region

#Region "Custom style properties class"
    Public Class GridExcelTipStyleProperties
        Inherits GridStyleInfoCustomProperties
        ' static initialization of property descriptors
        Private Shared t As Type = GetType(GridExcelTipStyleProperties)

        Private Shared ExcelTipTextProperty As StyleInfoProperty = CreateStyleInfoProperty(t, "ExcelTipText")

        ' default settings for all properties this object holds
        Private Shared defaultObject As GridExcelTipStyleProperties


        ' initialize default settings for all properties in static ctor
        Shared Sub New()
            ' all properties must be initialized for the Default property
            defaultObject = New GridExcelTipStyleProperties(GridStyleInfo.Default)
            defaultObject.ExcelTipText = ""
        End Sub 'New

        Public Shared ReadOnly Property [Default]() As GridExcelTipStyleProperties
            Get
                Return defaultObject
            End Get
        End Property


        Public Shared Sub Initialize()
        End Sub 'Initialize


        Public Sub New(ByVal style As GridStyleInfo)
            MyBase.New(style)
        End Sub 'New


        Public Sub New()
        End Sub 'New

        <Description("Specifies if ..."), Browsable(True), Category("StyleCategoryBehavior")> _
     Public Property ExcelTipText() As String
            Get
                'TraceUtil.TraceCurrentMethodInfo()
                Return CType(style.GetValue(ExcelTipTextProperty), String)
            End Get
            Set(ByVal Value As String)
                'TraceUtil.TraceCurrentMethodInfo(Value)
                style.SetValue(ExcelTipTextProperty, Value)
            End Set
        End Property

        Public Sub ResetExcelTipText()
            style.ResetValue(ExcelTipTextProperty)
        End Sub 'ResetTheLocked

        <EditorBrowsableAttribute(EditorBrowsableState.Never)> _
        Private Function ShouldSerializeExcelTipText() As Boolean
            Return style.HasValue(ExcelTipTextProperty)
        End Function 'ShouldSerializeTheLocked

        <Browsable(False), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
        Public ReadOnly Property HasExcelTipText() As Boolean
            Get
                Return style.HasValue(ExcelTipTextProperty)
            End Get
        End Property


    End Class 'GridExcelTipStyleProperties

#End Region


End Namespace


