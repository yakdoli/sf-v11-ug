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


Public Class OneTimeOnlyQueryCellInfoGridModel
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
        Me.UseGridOneTimeOnlyQueryCellInfoCache = True

        BaseStylesMap.RegisterStandardStyles()
    End Sub 'New

    Private _useGridOneTimeOnlyQueryCellInfoCache As Boolean

    '/ <summary>
    '/ Property UseGridOneTimeOnlyQueryCellInfoCache (bool)
    '/ </summary>

    Public Property UseGridOneTimeOnlyQueryCellInfoCache() As Boolean
        Get
            Return Me._useGridOneTimeOnlyQueryCellInfoCache
        End Get
        Set(ByVal Value As Boolean)
            If Me._useGridOneTimeOnlyQueryCellInfoCache <> Value Then
                Me.ResetVolatileData()

                ' Replace volatile data cache with a permanent array of objects that stays in memory 
                ' (but also eliminates support for QueryCellInfo and SaveCellInfo in gridModel)
                Me._useGridOneTimeOnlyQueryCellInfoCache = Value
                If Value Then
                    VolatileData = New GridOneTimeOnlyQueryCellInfoCache(Me.Model)
                Else
                    VolatileData = New GridVolatileData(Me.Model)
                End If
            End If
        End Set
    End Property

    
End Class 'OneTimeOnlyQueryCellInfoGridModel 


Public Class OneTimeOnlyQueryCellInfoGrid
    Inherits GridControl

    Public Sub New()
        MyBase.New(New OneTimeOnlyQueryCellInfoGridModel())
    End Sub 'New


    Public Shadows Property Model() As OneTimeOnlyQueryCellInfoGridModel
        Get
            Return CType(MyBase.Model, OneTimeOnlyQueryCellInfoGridModel)
        End Get
        Set(ByVal Value As OneTimeOnlyQueryCellInfoGridModel)
            MyBase.Model = Value
        End Set
    End Property
End Class 'OneTimeOnlyQueryCellInfoGrid
