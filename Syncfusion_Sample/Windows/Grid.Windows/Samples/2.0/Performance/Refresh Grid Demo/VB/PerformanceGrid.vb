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
Imports System.Threading

Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Styles
Imports Syncfusion.Drawing
Imports Syncfusion.ComponentModel



Public Class PerformanceGridModel
    Inherits GridModel
    
    Public Sub New()
        CommandStack.Enabled = False
        Rows.DefaultSize = 17
        Cols.DefaultSize = 65
        RowHeights(0) = 21
        ColWidths(0) = 35
        RowHeights.ResetModified()
        ColWidths.ResetModified()
        Options.ExcelLikeCurrentCell = False
        Options.ExcelLikeSelectionFrame = False
        Options.AllowDragSelectedCols = False
        Options.AllowDragSelectedRows = False
        CommandStack.Enabled = False
        Options.FloatCellsMode = GridFloatCellsMode.None
        
        BaseStylesMap.RegisterStandardStyles()
    End Sub 'New
    
    Private _useGridNonVirtualDataCache As Boolean
    
    '/ <summary>
    '/ Property UseGridNonVirtualDataCache (bool)
    '/ </summary>
    
    Public Property UseGridNonVirtualDataCache() As Boolean
        Get
            Return Me._useGridNonVirtualDataCache
        End Get
        Set
            If Me._useGridNonVirtualDataCache <> value Then
                Me.ResetVolatileData()
                
                ' Replace volatile data cache with a permanent array of objects that stays in memory 
                ' (but also eliminates support for QueryCellInfo and SaveCellInfo in gridModel)
                Me._useGridNonVirtualDataCache = value
                If value Then
                    VolatileData = New GridNonVirtualDataCache(Me.Model)
                Else
                    VolatileData = New GridVolatileData(Me.Model)
                End If
            End If
        End Set
    End Property
End Class 'PerformanceGridModel 

Public Class PerformanceGrid
    Inherits GridControl
    
    Public Sub New()
        MyBase.New(New PerformanceGridModel())
        UseGDI = True
        UseDoubleBuffer = False
        Model.UseGridNonVirtualDataCache = True
        Me.OptimizeDrawBackground = True
        Me.OptimizeInsertRemoveCells = True
        Me.SupportsPrepareViewStyleInfo = False
        
        Dim drawBorder As Boolean = True
        If drawBorder Then
            Model.TableStyle.Borders.Right = New GridBorder(GridBorderStyle.Solid, SystemColors.Control, GridBorderWeight.Thin)
            Model.TableStyle.Borders.Bottom = New GridBorder(GridBorderStyle.Solid, SystemColors.Control, GridBorderWeight.Thin)
        ' Use solid line - faster than dotted line
        ' No border at all is of course faster.
        Else
            Model.TableStyle.Borders.All = GridBorder.Empty
        End If 
    End Sub 'New
    
    
    Public Shadows Property Model() As PerformanceGridModel
        Get
            Return CType(MyBase.Model, PerformanceGridModel)
        End Get
        Set
            MyBase.Model = value
        End Set
    End Property
    
    Private _useGDI As Boolean
    
    '/ <summary>
    '/ Property UseGDI (bool)
    '/ </summary>
    
    Public Property UseGDI() As Boolean
        Get
            Return Me._useGDI
        End Get
        Set
            If Me._useGDI <> Value Then
                Me._useGDI = Value
                Invalidate()
            End If
        End Set
    End Property
    
    Private _useDoubleBuffer As Boolean = True
    
    '/ <summary>
    '/ Property UseDoubleBuffer (bool)
    '/ </summary>
    
    Public Property UseDoubleBuffer() As Boolean
        Get
            Return Me._useDoubleBuffer
        End Get
        Set
            If Me._useDoubleBuffer <> Value Then
                Me._useDoubleBuffer = Value
            End If
        End Set
    End Property
    
    
    Protected Overrides Sub OnPaintBackground(pevent As PaintEventArgs)
        If useDoubleBuffer Then
            MyBase.OnPaintBackground(pevent)
        End If
    End Sub 'OnPaintBackground
     
    Protected Overrides Sub OnDrawCellDisplayText(e As GridDrawCellDisplayTextEventArgs)
        MyBase.OnDrawCellDisplayText(e)
        
        If Not useGDI OrElse e.Cancel Then
            Return
        End If 
        e.Cancel = GridGdiPaint.Instance.DrawText(e.Graphics, e.DisplayText, e.TextRectangle, e.Style)
    End Sub 'OnDrawCellDisplayText
    
    
    Protected Overrides Sub OnFillRectangleHook(e As GridFillRectangleHookEventArgs)
        MyBase.OnFillRectangleHook(e)
        
        If Not useGDI OrElse e.Cancel Then
            Return
        End If 
        e.Cancel = GridGdiPaint.Instance.FillRectangle(e.Graphics, e.Bounds, e.Brush)
    End Sub 'OnFillRectangleHook
End Class 'PerformanceGrid 


