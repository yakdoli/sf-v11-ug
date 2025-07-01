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

Namespace ExcelMarker
    Public Class ImageCellRenderer
        Inherits GridStaticCellRenderer
        'Fields
        'Constructors
        'Methods
        Public Sub New(ByVal grid As GridControlBase, ByVal cellModel As GridCellModelBase)
            MyBase.New(grid, cellModel)

        End Sub
        Protected Overloads Overrides Sub OnDraw(ByVal g As Graphics, ByVal clientRectangle As Rectangle, ByVal rowIndex As Integer, ByVal colIndex As Integer, ByVal style As GridStyleInfo)

            ' CellLayout layout = GetCellLayout(int rowIndex, int colIndex, GridStyleInfo style)
            If clientRectangle.IsEmpty Then
                Return
            End If
            If TypeOf (style.Tag) Is Bitmap Then
                g.DrawImage(CType(style.Tag, Bitmap), clientRectangle)
            End If

        End Sub
    End Class
End Namespace
