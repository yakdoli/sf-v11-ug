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
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.Windows.Forms.Grid
Imports System.Runtime.InteropServices


#Region "Interface ICellUserControl"

Public Interface ICellUserControl
    'used to move data to the usercontrol from the datarow at position
    Sub UserControlSetValues(ByVal drv As DataRowView)

    'used to move data from the usercontrol to the datarow
    Sub UserControlGetValues(ByVal drv As DataRowView)

    'returns true when usercontrol values have changed
    Function UserControlIsModified() As Boolean
End Interface 'ICellUserControl

#End Region



  #region "Base CellUserControl class"
 
' the UserControl you want repeated
' 1) must be derived from this CellUserControl class
' 2) must implement its own ICellUserControl interface 

Public Class CellUserControl
    Inherits UserControl
    Implements ICellUserControl 'ToDo: Add Implements Clauses for implementation methods of these interface(s)

#Region "Implementation of ICellUserControl"

    Public Overridable Sub UserControlSetValues(ByVal drv As DataRowView) Implements ICellUserControl.UserControlSetValues
    End Sub 'UserControlSetValues


    Public Overridable Sub UserControlGetValues(ByVal drv As DataRowView) Implements ICellUserControl.UserControlGetValues
    End Sub 'UserControlGetValues


    Public Overridable Function UserControlIsModified() As Boolean Implements ICellUserControl.UserControlIsModified
        Return True
    End Function 'UserControlIsModified

#End Region


    Protected Overrides Function ProcessTabKey(ByVal forward As Boolean) As Boolean
        'Console.WriteLine("ProcessTabKey " + this.ActiveControl.Text);
        Return Me.SelectNextControl(Me.ActiveControl, forward, True, False, True)
    End Function 'ProcessTabKey


    Public Overridable Sub HandleKeyDown(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then

             If Me.ActiveControl.GetType() Is GetType(TextBoxBase) Then
                Dim tb As TextBoxBase = CType(Me.ActiveControl, TextBoxBase)
                If tb.SelectionLength = 0 AndAlso tb.SelectionStart < tb.TextLength Then
                    tb.SelectionLength = 1
                End If
                tb.SelectedText = ""
                e.Handled = True
                Return
            End If
        ElseIf e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right Then
            If Me.ActiveControl.GetType() Is GetType(TextBox) Then
                Dim tb As TextBoxBase = CType(Me.ActiveControl, TextBox)
                Dim increment As Integer = IIf(e.KeyCode = Keys.Right, IIf(tb.SelectionStart < tb.TextLength, 1, 0), IIf(tb.SelectionStart > 0, -1, 0))
                tb.SelectionLength = 0
                tb.SelectionStart += increment

                e.Handled = True
                Return
            End If
        End If

        MyBase.OnKeyDown(e)
    End Sub 'HandleKeyDown
End Class 'CellUserControl

#End Region


#Region "CellModel class"



Public Class GenericPanelCellModel
    Inherits GridGenericControlCellModel

    Public Sub New(ByVal grid As GridModel)
        MyBase.New(grid)
    End Sub 'New


    Public Overrides Function CreateRenderer(ByVal control As GridControlBase) As GridCellRendererBase
        Return New GenericPanelCellRenderer(control, Me)
    End Function 'CreateRenderer
End Class 'GenericPanelCellModel

#End Region


#Region "CellRenderer class"
 

Public Class GenericPanelCellRenderer
    Inherits GridGenericControlCellRenderer
    Private activeControl As CellUserControl
    Private staticControl As CellUserControl


    Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
        MyBase.New(grid, cellModel)
    End Sub 'New

#Region "CellRenderer overrides"


    'sets the style.COntrol which is drawn in the baseclass depending upon whether
    'the requested cell is active or not
    Protected Overrides Sub OnDraw(ByVal g As Graphics, ByVal clientRectangle As Rectangle, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo)
        clientRectangle.Inflate(-1, -1)

        If Me.ShouldDrawFocused(rowIndex, colIndex) Then
            style.Control = activeControl
        Else
            style.Control = staticControl
            staticControl.UserControlSetValues(GetDataRowView(rowIndex))
        End If
        MyBase.OnDraw(g, clientRectangle, rowIndex, colIndex, style)
    End Sub 'OnDraw


    'move the DateRowView into the activeControl
    Protected Overrides Sub OnInitialize(ByVal rowIndex As Integer, ByVal colIndex As Integer)
        activeControl.UserControlSetValues(GetDataRowView(rowIndex))
        Me.CurrentCell.IsModified = False
        Me.CurrentCell.BeginEdit()
    End Sub 'OnInitialize


    'save changes to the DataRowView from the activeControl
    Protected Overrides Function OnSaveChanges() As Boolean
        activeControl.UserControlGetValues(GetDataRowView(Me.RowIndex))
        Me.CurrentCell.IsModified = False
        Return True
    End Function 'OnSaveChanges

#End Region

#Region "InitCellPanels and GetDataRowView helper methods"


    'method used to initialize things. Should be call immedaitely after adding the derived
    'cell model to the grid's CellModels collection.
    Public Sub InitCellPanels(ByVal activeControl As CellUserControl, ByVal staticControl As CellUserControl)
        activeControl.Location = New Point(-1000, -1000)
        staticControl.Location = New Point(-1000, -1000)

        Me.activeControl = activeControl
        Me.Grid.Controls.Add(activeControl)
        Me.staticControl = staticControl
        Me.Grid.Controls.Add(staticControl)
        activeControl.Visible = False
        staticControl.Visible = False

        AddHandler Me.Grid.QueryCanOleDragRange, AddressOf grid_QueryCanOleDragRange
        AddHandler Me.Grid.DrawCurrentCellBorder, AddressOf grid_DrawCurrentCellBorder

        AddHandler Me.Grid.CurrentCellDeactivating, AddressOf grid_CurrentCellDeactivating
    End Sub 'InitCellPanels


    'helper method that maps grid's row index to a DataRowView
    Private Function GetDataRowView(ByVal rowIndex As Integer) As DataRowView
        Return CType(Me.Grid.Model.TableStyle.DataSource, DataView)((rowIndex - 1))
    End Function 'GetDataRowView
#End Region

#Region "Grid event handlers"

    'used to indicate changes have been made, so OnSaveChanges will be called by the grid
    Private Sub grid_CurrentCellDeactivating(ByVal sender As Object, ByVal e As CancelEventArgs)
        'Console.WriteLine("activeControl_Leave");
        If activeControl.UserControlIsModified() Then
            Me.CurrentCell.IsModified = True
        End If
    End Sub 'grid_CurrentCellDeactivating


    Private Sub grid_DrawCurrentCellBorder(ByVal sender As Object, ByVal e As GridDrawCurrentCellBorderEventArgs)
    End Sub 'grid_DrawCurrentCellBorder

    'if you want no currentcell border
    'e.Cancel = true;

    'turn off grid's default D&D cursor at cell edge
    Private Sub grid_QueryCanOleDragRange(ByVal sender As Object, ByVal e As Syncfusion.Windows.Forms.Grid.GridQueryCanOleDragRangeEventArgs)
        e.Cancel = True
    End Sub 'grid_QueryCanOleDragRange
#End Region
End Class 'GenericPanelCellRenderer
#End Region
 