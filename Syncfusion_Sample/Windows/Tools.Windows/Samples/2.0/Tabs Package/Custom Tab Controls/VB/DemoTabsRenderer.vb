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
Imports System.Collections
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace CustomTabControls
    ' Custom tab renderer
    Public Class DemoTabsRenderer
        Inherits TabRenderer3D
        ' Use the above DemoTabPanelProperty as my default properties provider.
        Private Shared tabPropertyExtender As DemoTabPanelProperty
        'Fields
        'Constructors
        'Methods
        Shared Sub New()

            tabPropertyExtender = New DemoTabPanelProperty()
            TabRendererFactory.RegisterTabType(TabStyleName, GetType(DemoTabsRenderer), TabPanelPropertyExtender)

        End Sub
        Public Sub New(ByVal parent As ITabControl, ByVal panelRenderer As ITabPanelRenderer)
            MyBase.New(parent, panelRenderer)

        End Sub
        Public Shared Shadows ReadOnly Property TabPanelPropertyExtender() As DemoTabPanelProperty
            Get

                Return tabPropertyExtender

            End Get
        End Property
        Public Shared Shadows ReadOnly Property TabStyleName() As String
            Get

                Return "DemoTabs"

            End Get
        End Property

        Public Overloads Overrides Function HitTest(ByVal mousePosition As PointF) As Boolean
            ' Use the same path as the DrawBorders method.

            Dim path As GraphicsPath
            path = Nothing
            If (Me.panelRenderer.TabPanelData.TabsData(Me.panelRenderer.TabPanelData.SelectedIndex) Is Me.TabData) Then
                path = Me.GetSelectedTabBorderPathFromBounds(Me.GetCurrentBounds)
            Else
                path = Me.GetBorderPathFromBounds(Me.GetCurrentBounds)
                path.CloseFigure()
            End If
            Dim [region] As [Region]
            [region] = New [Region](path)
            ' Hittest the region to verify if the point is in the rect
            If region.IsVisible(mousePosition) Then
                Return True
            Else
                Return False
            End If

        End Function
        Public Overloads Overrides Function GetOverlapSize(ByVal tabSize As SizeF) As SizeF

            Return tabPropertyExtender.GetOverlapSize(tabSize)

        End Function
        Protected Overloads Overrides Function GetForeColor() As Color

            Return Color.Gray

        End Function
        ' Same as the base class except this one does not draw the focus rect.
        Protected Overloads Overrides Sub DrawInterior(ByVal drawItemInfo As DrawTabEventArgs)

            Dim g As Graphics
            g = drawItemInfo.Graphics
            Dim bounds As Rectangle
            bounds = drawItemInfo.BoundsInterior
            Dim rectTextAndImage As RectangleF
            rectTextAndImage = TabUtils.ApplyTransform(g, Me.TabAlignment, RectangleF.FromLTRB(bounds.Left, bounds.Top, bounds.Right, bounds.Bottom), True)
            ApplyTransform(g)
            DrawTextAndImage(g, rectTextAndImage, drawItemInfo)
            g.ResetTransform()

        End Sub
        Protected Overloads Overrides Sub DrawBorders(ByVal drawItemInfo As DrawTabEventArgs)

            Dim r As RectangleF
            r = New RectangleF(drawItemInfo.Bounds.Left, drawItemInfo.Bounds.Top, drawItemInfo.Bounds.Width, drawItemInfo.Bounds.Height)
            Dim g As Graphics
            g = drawItemInfo.Graphics
            Dim oldSM As SmoothingMode
            oldSM = g.SmoothingMode
            g.SmoothingMode = SmoothingMode.AntiAlias
            ' Get appropriate path and draw the border.
            If ((drawItemInfo.State And DrawItemState.Selected) _
                        > 0) Then
                drawItemInfo.Graphics.DrawPath(New Pen(Color.FromArgb(42, 67, 126), 1), Me.GetSelectedTabBorderPathFromBounds(r))
            Else
                drawItemInfo.Graphics.DrawPath(New Pen(Color.FromArgb(42, 67, 126), 1), Me.GetBorderPathFromBounds(r))
            End If
            g.SmoothingMode = oldSM

        End Sub
        Protected Overloads Overrides Sub DrawBackground(ByVal drawItemInfo As DrawTabEventArgs)

            Dim g As Graphics
            g = drawItemInfo.Graphics
            Dim curBounds As RectangleF
            curBounds = New RectangleF(drawItemInfo.Bounds.Left, drawItemInfo.Bounds.Top, drawItemInfo.Bounds.Width, drawItemInfo.Bounds.Height)
            Dim bgColor As Color
            bgColor = drawItemInfo.BackColor
            ' Get the border path and fill it.
            Dim path As GraphicsPath
            path = Nothing
            If ((drawItemInfo.State And DrawItemState.Selected) _
                        > 0) Then
                path = Me.GetSelectedTabBorderPathFromBounds(curBounds)
                g.FillPath(New SolidBrush(bgColor), path)
            Else
                path = Me.GetBorderPathFromBounds(curBounds)
                path.CloseFigure()
                Dim brush As LinearGradientBrush
                brush = New LinearGradientBrush(curBounds, Color.FromArgb(50, bgColor), Color.FromArgb(150, bgColor), LinearGradientMode.ForwardDiagonal)
                g.FillPath(brush, path)
            End If

        End Sub
        ' Border path for inactive tabs.
        Private Function GetBorderPathFromBounds(ByVal bounds As RectangleF) As GraphicsPath

            Dim path As GraphicsPath
            path = New GraphicsPath()
            path.AddLine(New PointF(bounds.Left, (bounds.Bottom - 1)), New PointF(bounds.Left, (bounds.Top + 5)))
            path.AddBezier(New PointF(bounds.Left, (bounds.Top + 5)), New PointF((bounds.Left + 1), (bounds.Top + 3)), New PointF((bounds.Left + 3), (bounds.Top + 1)), New PointF((bounds.Left + 5), bounds.Top))
            path.AddLine(New PointF((bounds.Left + 5), bounds.Top), New PointF((bounds.Right - 6), bounds.Top))
            path.AddBezier(New PointF((bounds.Right - 7), bounds.Top), New PointF((bounds.Right - 2), (bounds.Top + 1)), New PointF((bounds.Right - 1), (bounds.Top + 4)), New PointF((bounds.Right - 1), (bounds.Top + 5)))
            path.AddLine(New PointF(bounds.Right, (bounds.Top + 5)), New PointF(bounds.Right, bounds.Bottom))
            Return path

        End Function
        ' Border path for selected tabs.
        Private Function GetSelectedTabBorderPathFromBounds(ByVal bounds As RectangleF) As GraphicsPath

            Dim path As GraphicsPath
            path = New GraphicsPath()
            path.AddBezier(New PointF(bounds.Left, (bounds.Bottom - 1)), New PointF((bounds.Left + 12), (bounds.Bottom - 7)), New PointF((bounds.Left + 10), bounds.Top), New PointF((bounds.Left + 25), bounds.Top))
            path.AddLine(New PointF((bounds.Left + 25), bounds.Top), New PointF((bounds.Right - 26), bounds.Top))
            path.AddBezier(New PointF((bounds.Right - 26), bounds.Top), New PointF((bounds.Right - 12), (bounds.Top + 3)), New PointF((bounds.Right - 15), (bounds.Bottom - 5)), New PointF(bounds.Right, bounds.Bottom))
            Return path

        End Function
    End Class
End Namespace
