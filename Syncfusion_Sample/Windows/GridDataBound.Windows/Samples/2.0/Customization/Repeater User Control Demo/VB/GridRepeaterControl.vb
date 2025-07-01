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
Imports System.Drawing
Imports System.Data
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid



 
Public Class GridRepeaterUserControl
   Inherits System.Windows.Forms.UserControl
   Public Grid As Syncfusion.Windows.Forms.Grid.GridControl
    
   Private components As System.ComponentModel.Container = Nothing
   
   
   Public Sub New()
      ' This call is required by the Windows.Forms Form Designer.
      InitializeComponent()
   End Sub 'New
    
    
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub 'Dispose

#Region "Component Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify 
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.Grid = New Syncfusion.Windows.Forms.Grid.GridControl()
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        ' 
        ' Grid
        ' 
        Me.Grid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid.Location = New System.Drawing.Point(2, 2)
        Me.Grid.Name = "Grid"
        Me.Grid.Size = New System.Drawing.Size(260, 292)
        Me.Grid.TabIndex = 0
        Me.Grid.Text = "Grid"
        Me.Grid.VerticalThumbTrack = True
        ' 
        ' GridRepeaterUserControl
        ' 
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Grid})
        Me.DockPadding.All = 2
        Me.Name = "GridRepeaterUserControl"
        Me.Size = New System.Drawing.Size(264, 296)
        CType(Me.Grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub 'InitializeComponent 
#End Region


    Private Sub GridRepeaterUserControl_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Grid.ColCount = 0
        Me.Grid.Cols.Hidden(0) = True
        Me.Grid.Rows.Hidden(0) = True
    End Sub 'GridRepeaterUserControl_Load

    Private activeControl1 As CellUserControl

    Public Sub AddUserControls(ByVal activeControl As CellUserControl, ByVal staticControl As CellUserControl, ByVal visibleControls As Integer)
        If visibleControls < 1 Then
            Throw New ArgumentOutOfRangeException("visibleControls", "must be more than 0")
        End If
        'turn off double buffering
        MakeUnBuffered(staticControl)
        staticControl.CausesValidation = False


        Me.Grid.BeginUpdate()

        Me.Grid.ColCount = 1
        Me.Grid.RowCount = 0

        'Me.Grid.VScrollPixel = True
        Me.Grid.HScrollPixel = True


        Me.Grid.Model.CellModels.Add("RepeaterCell", New GenericPanelCellModel(Me.Grid.Model))
        Me.Grid.ColStyles(1).CellType = "RepeaterCell"
        Dim cr As GenericPanelCellRenderer = CType(Me.Grid.CellRenderers("RepeaterCell"), GenericPanelCellRenderer) '
        cr.InitCellPanels(activeControl, staticControl)
        Me.activeControl1 = activeControl

        Me.Grid.DefaultRowHeight = activeControl.Height
        Me.Grid.DefaultColWidth = activeControl.Width

        Me.Grid.Model.Properties.GridLineColor = System.Drawing.Color.Silver
        Me.Grid.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid


        Dim width As Integer = Me.DockPadding.Left + Me.DockPadding.Right + activeControl.Width + SystemInformation.VerticalScrollBarWidth
        Dim height As Integer = Me.DockPadding.Top + Me.DockPadding.Bottom + visibleControls * activeControl.Height
        Me.Size = New Size(width, height)


        Me.Grid.WantTabKey = False
        Me.Grid.EndUpdate()
        Me.Grid.Refresh()
    End Sub 'AddUserControls


    Private Sub MakeUnBuffered(ByVal c As Control)
        Dim mInfo As System.Reflection.MethodInfo = GetType(Control).GetMethod("SetStyle", System.Reflection.BindingFlags.Instance Or System.Reflection.BindingFlags.InvokeMethod Or System.Reflection.BindingFlags.NonPublic)
        If Not (mInfo Is Nothing) Then
            mInfo.Invoke(c, New Object() {ControlStyles.DoubleBuffer, False})
        End If
        If c.Controls.Count > 0 Then
            Dim c1 As Control
            For Each c1 In c.Controls
                c1.CausesValidation = False
                MakeUnBuffered(c1) 'recursive call
            Next c1
        End If
    End Sub 'MakeUnBuffered

#Region "DataBinding"

    Private dv As DataView
    Private dataSource As Object
    Private dataMember As String


    Public Overloads Sub SetDataBinding(ByVal dataSource As Object)
        SetDataBinding(dataSource, "")
    End Sub 'SetDataBinding

    Private queryColCountHooked As Boolean = False

    Public Overloads Sub SetDataBinding(ByVal dataSource As Object, ByVal dataMember As String)
        If Not (Me.dv Is Nothing) Then
            RemoveHandler CType(Me.dv, IBindingList).ListChanged, AddressOf ibl_ListChanged
        End If


        Me.dataMember = dataMember
        Me.dataSource = dataSource
        Me.dv = Nothing

        If dataSource Is Nothing Then
            Me.dataMember = ""
        ElseIf TypeOf dataSource Is DataSet Then
            Me.dv = CType(dataSource, DataSet).Tables(dataMember).DefaultView
        ElseIf TypeOf dataSource Is DataTable AndAlso dataMember.Length = 0 Then
            Me.dv = CType(dataSource, DataTable).DefaultView
        ElseIf TypeOf dataSource Is DataView AndAlso dataMember.Length = 0 Then
            Me.dv = CType(dataSource, DataTable).DefaultView
        Else
            Throw New ArgumentException("dataSource and dataMember must define a DataView")
        End If
        Me.Grid.TableStyle.DataSource = Me.dv
        If Not (Me.dv Is Nothing) Then
            AddHandler CType(Me.dv, IBindingList).ListChanged, AddressOf ibl_ListChanged
        End If
        If Not queryColCountHooked Then
            AddHandler Me.Grid.QueryRowCount, AddressOf grid_QueryRowCount
            AddHandler Me.Grid.KeyDown, AddressOf grid_KeyDown
            queryColCountHooked = True
        End If
        Me.Grid.HScrollBehavior = GridScrollbarMode.Disabled
        Me.Grid.Refresh()

        Me.Grid.ResetVolatileData()
        Me.Grid.UpdateScrollBars()
    End Sub 'SetDataBinding


    Private Sub ibl_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs)
        Select Case e.ListChangedType
            Case ListChangedType.ItemAdded, ListChangedType.ItemDeleted, ListChangedType.ItemMoved, ListChangedType.Reset
                Me.Grid.RefreshRange(Me.Grid.ViewLayout.VisibleCellsRange, True)
            Case ListChangedType.ItemChanged
                Me.Grid.RefreshRange(GridRangeInfo.Cell(e.NewIndex + 1, 1), True)
            Case Else
        End Select
    End Sub 'ibl_ListChanged


    Private Sub grid_QueryRowCount(ByVal sender As Object, ByVal e As GridRowColCountEventArgs)
        e.Count = Me.dv.Count
        e.Handled = True
    End Sub 'grid_QueryRowCount


    Private Sub grid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Delete OrElse e.KeyCode = Keys.Left OrElse e.KeyCode = Keys.Right Then
            e.Handled = True
            Me.activeControl1.HandleKeyDown(e)
        End If
    End Sub 'grid_KeyDown

#End Region
End Class 'GridRepeaterUserControl