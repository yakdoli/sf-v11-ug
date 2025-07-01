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

Imports Microsoft.VisualBasic
Imports Syncfusion.Windows.Forms.Tools
Imports System
Imports System.Drawing
Imports System.Windows.Forms


Public Class FlatTabRenderer
    Inherits TabRenderer2D
    ' A custom name for the tab style.

    Public Shared Shadows ReadOnly Property TabStyleName() As String
        Get
            Return "FlatTab"
        End Get
    End Property
    Private Shared _tabPanelPropertyExtender As FlatTabPanelProperty

    ' Gets the ITabDefaultProperties
    ' instance that provides default properites for this renderer.

    Public Shared Shadows ReadOnly Property TabPanelPropertyExtender() As FlatTabPanelProperty
        Get
            Return _tabPanelPropertyExtender
        End Get
    End Property

    Shared Sub New()
        ' Create the ITabDefaultProperties corresponding to this tab style.
        _tabPanelPropertyExtender = New FlatTabPanelProperty()
        ' Register the custom tab style with the factory (to make it available to the framework).
        TabRendererFactory.RegisterTabType(TabStyleName, GetType(FlatTabRenderer), TabPanelPropertyExtender)

        ' Changing the Top border color.
        ' Though this border is "Top", it appears to the left of the tab when drawn
        ' because the implementation uses a transformed(rotated) Graphics rectangle 
        ' to draw the tabs.
        TabRenderer2D.buttonBorderColors(0) = SystemColors.ControlDarkDark
    End Sub 'New


    Public Sub New(ByVal parent As ITabControl, ByVal panelRenderer As ITabPanelRenderer)
        MyBase.New(parent, panelRenderer)
    End Sub 'New


    ' Overridden to only draw the top and left line.
    ' Assuming the tabs will be aligned to the left.
    ' The code here is copied from the base class and the portions drawing the right and bottom portion is removed.
    Protected Overrides Sub DrawBorders(ByVal drawItemInfo As DrawTabEventArgs)
        Dim g As Graphics = drawItemInfo.Graphics

        ' Transformed to horizontal alignment
        Dim currentBounds As RectangleF = New RectangleF(drawItemInfo.Bounds.X, drawItemInfo.Bounds.Y, drawItemInfo.Bounds.Width, drawItemInfo.Bounds.Height)
        currentBounds = TabUtils.ApplyTransform(g, Me.TabAlignment, currentBounds, True)

        Me.ApplyTransform(g)

        ' Though we draw the "top" and "right" borders, they end up being the "left" and "bottom"
        ' borders when drawn because the implementation uses a transformed(rotated) 
        ' Graphics rectangle to draw the tabs.
        ' top line
        g.DrawLine(New Pen(BorderColors(BorderSide.top, Me.TabAlignment)), New PointF(currentBounds.Left, currentBounds.Top), New PointF(currentBounds.Right - 1, currentBounds.Top))

        ' right line
        g.DrawLine(New Pen(BorderColors(BorderSide.right, Me.TabAlignment)), New PointF(currentBounds.Right - 1, currentBounds.Top), New PointF(currentBounds.Right - 1, currentBounds.Bottom - 1))

        g.ResetTransform()
    End Sub 'DrawBorders
End Class 'FlatTabRenderer
