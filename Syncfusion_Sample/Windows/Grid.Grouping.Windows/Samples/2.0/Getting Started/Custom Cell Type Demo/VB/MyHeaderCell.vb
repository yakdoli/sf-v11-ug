#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
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
Imports System.Data.OleDb
Imports System.IO
Imports System.Text
Imports System.Diagnostics
Imports Syncfusion.Drawing

Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping



Public Class MyHeaderCellModel
    Inherits GridTableColumnHeaderCellModel
    
    Public Sub New(grid As Syncfusion.Windows.Forms.Grid.GridModel)
        MyBase.New(grid)
        ButtonBarSize = New Size(10, 10)
    End Sub 'New
    
    
    Public Overrides Function CreateRenderer(control As Syncfusion.Windows.Forms.Grid.GridControlBase) As Syncfusion.Windows.Forms.Grid.GridCellRendererBase
        Return New MyHeaderCellRenderer(control, Me)
    End Function 'CreateRenderer
End Class 'MyHeaderCellModel


Public Class MyHeaderCellRenderer
    Inherits GridTableColumnHeaderCellRenderer
    
    Public Sub New(grid As Syncfusion.Windows.Forms.Grid.GridControlBase, cellModel As Syncfusion.Windows.Forms.Grid.GridCellModelBase)
        MyBase.New(grid, cellModel)
        Me.AddButton(New MyCellButton(Me))
    End Sub 'New

    Public Overrides Sub OnPrepareViewStyleInfo(ByVal e As Syncfusion.Windows.Forms.Grid.GridPrepareViewStyleInfoEventArgs)
        e.Style.Enabled = True
        e.Cancel = True
    End Sub
End Class 'MyHeaderCellRenderer


Public Class MyCellButton
    Inherits GridCellButton
    
    Public Sub New(r As MyHeaderCellRenderer)
        MyBase.New(r)
    End Sub 'New
    
    
    Public Overrides Sub MouseDown(e As System.Windows.Forms.MouseEventArgs, ht As Syncfusion.Windows.Forms.Grid.GridCellHitTestInfo)
        Console.WriteLine("MouseDown")
        MyBase.MouseDown(e, ht)
    End Sub 'MouseDown
    
    
    Public Overrides Sub DrawButton(g As System.Drawing.Graphics, rect As System.Drawing.Rectangle, buttonState As System.Windows.Forms.ButtonState, style As Syncfusion.Windows.Forms.Grid.GridStyleInfo)
        ControlPaint.DrawButton(g, rect, buttonState)
        
        ' Icon
        rect.Inflate(- 3, - 3)
        Syncfusion.Drawing.BrushPaint.FillRectangle(g, rect, New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, Color.Black, Color.Wheat))
    End Sub 'DrawButton
End Class 'MyCellButton