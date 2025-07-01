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
Imports Syncfusion.Windows.Forms.Grid
Imports System
Imports System.Drawing
Imports System.Drawing.Printing

Namespace PrintAsBitmap
    Public Class GridPrintToFitDocument
        Inherits GridPrintDocument
        Private WithEvents _grid As GridControlBase
        'Fields
        'Constructors
        'Events
        'Methods
        Public Sub New(ByVal grid As GridControlBase, ByVal printPreview As Boolean)
            MyBase.New(grid, printPreview)
            _grid = grid

        End Sub
        Protected Overloads Overrides Sub OnPrintPage(ByVal ev As PrintPageEventArgs)

            ev.HasMorePages = False
            'draw a fullsize bitmap of the grid...
            Dim gridHeight As Integer
            gridHeight = _grid.Model.RowHeights.GetTotal(0, _grid.Model.RowCount)
            Dim gridWidth As Integer
            gridWidth = _grid.Model.ColWidths.GetTotal(0, _grid.Model.ColCount)
            Dim gridBM As Bitmap
            gridBM = New Bitmap(gridWidth, gridHeight)
            Dim g As Graphics
            g = Graphics.FromImage(gridBM)
            Me._grid.GridBounds = New Rectangle(0, 0, gridWidth, gridHeight)
            Me._grid.DrawGrid(g)
            Me._grid.ResetGridBounds()
            g.Dispose()
            Dim destRect As Rectangle
            destRect = ev.MarginBounds
            'use the printer graphics
            g = ev.Graphics
            'draw grid bitmap into the rect on the print page
            Dim gu As System.Drawing.GraphicsUnit
            gu = System.Drawing.GraphicsUnit.Point
            Dim srcRect As RectangleF
            srcRect = gridBM.GetBounds(gu)
            'adjust destRect to make sizing proportional
            ' you can comment this out this block if you don't want proportional fit
            Dim srcRatio As Single
            srcRatio = (srcRect.Width / srcRect.Height)
            Dim tarRatio As Single
            tarRatio = (CType(destRect.Width, Single) / destRect.Height)
            If (tarRatio < srcRatio) Then
                destRect.Height = CType((destRect.Width / srcRatio), Integer)
            Else
                destRect.Width = CType((destRect.Height * srcRatio), Integer)
            End If
            '////////////endof proportional fit//////////////////////////


            Dim dest As RectangleF = New RectangleF(destRect.X, destRect.Y, destRect.Width, destRect.Height)
            g.DrawImage(gridBM, dest, srcRect, gu)

        End Sub
    End Class
End Namespace
