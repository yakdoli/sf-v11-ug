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
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace CustomTabControls
    Public Class TabRendererNotched
        Inherits TabRendererBase
        Private Shared tabPanelPropertyExtender_ As TabUIDefaultProperties
        'Fields
        'Constructors
        'Methods
        Shared Sub New()

            tabPanelPropertyExtender_ = New TabPanelPropertyNotched()
            TabRendererFactory.RegisterTabType(TabStyleName, GetType(TabRendererNotched), TabPanelPropertyExtender)

        End Sub
        Public Sub New(ByVal parent As ITabControl, ByVal panelRenderer As ITabPanelRenderer)
            MyBase.New(parent, panelRenderer)

        End Sub
        Public Shared ReadOnly Property TabPanelPropertyExtender() As TabUIDefaultProperties
            Get

                Return tabPanelPropertyExtender_

            End Get
        End Property
        Public Shared ReadOnly Property TabStyleName() As String
            Get

                Return "Notched"

            End Get
        End Property
        Public Overloads Overrides Function GetOverlapSize(ByVal tabSize As SizeF) As SizeF

            Return TabPanelPropertyExtender.GetOverlapSize(tabSize)

        End Function
        Protected Overloads Overrides Sub DrawInterior(ByVal drawItemInfo As DrawTabEventArgs)

            Dim g As Graphics
            g = drawItemInfo.Graphics
            ' Convert to horizontal co-ords...
            Dim boundsF As RectangleF
            boundsF = RectangleF.FromLTRB(drawItemInfo.BoundsInterior.Left, drawItemInfo.BoundsInterior.Top, drawItemInfo.BoundsInterior.Right, drawItemInfo.BoundsInterior.Bottom)
            Dim rectTextAndImage As RectangleF
            rectTextAndImage = TabUtils.ApplyTransform(g, Me.TabAlignment, boundsF, True)
            ' ... and apply the same transform to g, so that we can have a single drawing logic
            ' for all alignments
            ApplyTransform(g)
            ' Use TabRendererBase's default drawing logic.
            DrawTextAndImage(g, rectTextAndImage, drawItemInfo)
            ' Uncomment this if the tabcontrol should draw a focus rect when in focus.
            '			if(((int)drawItemInfo.State & (int)DrawItemState.Focus) > 0)
            '				DrawFocusRect(g, this.Bounds, drawItemInfo.ForeColor, drawItemInfo.BackColor);
            g.ResetTransform()

        End Sub
        Protected Overloads Overrides Sub DrawBorders(ByVal drawItemInfo As DrawTabEventArgs)

            Dim g As Graphics
            g = drawItemInfo.Graphics
            Dim currentBounds As RectangleF
            currentBounds = RectangleF.FromLTRB(drawItemInfo.Bounds.Left, drawItemInfo.Bounds.Top, drawItemInfo.Bounds.Right, drawItemInfo.Bounds.Bottom)
            Dim oldClipRegion As [Region]
            oldClipRegion = g.Clip
            currentBounds = AdjustBoundsAndGraphicsForAlignment(g, currentBounds, Me.TabAlignment)
            Dim polygon() As PointF
            polygon = GetPolygonFromBounds(currentBounds, Me.TabAlignment)
            ' Draw left line
            g.DrawLine(New Pen(SystemColors.ControlLightLight), polygon(0), polygon(1))
            ' Draw Top-Left Hatch
            g.DrawLine(New Pen(SystemColors.ControlLightLight), polygon(1), polygon(2))
            ' top line
            g.DrawLine(New Pen(SystemColors.ControlLightLight), polygon(2), polygon(3))
            ' right hatch
            g.DrawLine(New Pen(SystemColors.ControlLightLight), polygon(3), polygon(4))
            ' right line
            g.DrawLine(New Pen(SystemColors.ControlDarkDark), polygon(4), polygon(5))
            ' right shade
            g.DrawLine(New Pen(Color.DarkGray), New PointF((polygon(4).X - 1), (polygon(4).Y - 1)), New PointF((polygon(5).X - 1), (polygon(5).Y + 2)))
            ' bottom line
            g.DrawLine(New Pen(SystemColors.ControlDarkDark), polygon(6), polygon(7))
            ' bottom shade
            g.DrawLine(New Pen(Color.DarkGray), New PointF((polygon(6).X + 1), (polygon(6).Y - 1)), New PointF((polygon(7).X - 2), (polygon(7).Y - 1)))
            ' Right-Bottom hatch
            Dim point2 As PointF
            point2 = New PointF((polygon(6).X - 1), (polygon(6).Y + 1))
            g.DrawLine(New Pen(SystemColors.ControlDarkDark), polygon(5), point2)
            ' left-bottom hatch
            If (Me.TabAlignment = TabAlignment.Left) Then
                point2 = New PointF(polygon(0).X, (polygon(0).Y - 1))
                g.DrawLine(New Pen(SystemColors.ControlDarkDark), polygon(7), point2)
            End If
            g.SetClip(oldClipRegion, CombineMode.Replace)

        End Sub
        Protected Overloads Overrides Sub DrawBackground(ByVal drawItemInfo As DrawTabEventArgs)

            Dim g As Graphics
            g = drawItemInfo.Graphics
            Dim currentBounds As RectangleF
            currentBounds = RectangleF.FromLTRB(drawItemInfo.Bounds.Left, drawItemInfo.Bounds.Top, drawItemInfo.Bounds.Right, drawItemInfo.Bounds.Bottom)
            Dim oldClipRegion As [Region]
            oldClipRegion = g.Clip
            currentBounds = AdjustBoundsAndGraphicsForAlignment(g, currentBounds, Me.TabAlignment)
            Dim polygon() As PointF
            polygon = GetPolygonFromBounds(currentBounds, Me.TabAlignment)
            g.FillPolygon(New SolidBrush(drawItemInfo.BackColor), polygon)
            g.SetClip(oldClipRegion, CombineMode.Replace)

        End Sub
        Protected Function AdjustBoundsAndGraphicsForAlignment(ByVal g As Graphics, ByVal oldBounds As RectangleF, ByVal align As TabAlignment) As RectangleF

            ' Increase tab bounds based on alignment
            Dim newBounds As RectangleF
            newBounds = oldBounds
            Select Case align
                Case TabAlignment.Top
                    newBounds.Height = (newBounds.Height + 3)
                    'End Section
                Case TabAlignment.Right
                    newBounds.Offset(-(3), 0)
                    newBounds.Width = (newBounds.Width + 3)
                    'End Section
                Case TabAlignment.Left
                    newBounds.Width = (newBounds.Width + 3)
                    'End Section
                Case TabAlignment.Bottom
                    newBounds.Offset(0, -(3))
                    newBounds.Height = (newBounds.Height + 3)
                    'End Section
            End Select
            g.SetClip(New [Region](oldBounds), CombineMode.Intersect)
            Return newBounds

        End Function
        Public Function GetPolygonFromBounds(ByVal bounds As RectangleF, ByVal curAlign As TabAlignment) As PointF()

            Dim polygon() As PointF
            polygon = Nothing
            Select Case curAlign
                Case TabAlignment.Top
                    polygon = New PointF() {New PointF(bounds.Left, (bounds.Bottom - 3)), New PointF(bounds.Left, (bounds.Top + 6)), New PointF((bounds.Left + 6), bounds.Top), New PointF((bounds.Right - 3), bounds.Top), New PointF((bounds.Right - 1), (bounds.Top + 2)), New PointF((bounds.Right - 1), (bounds.Bottom - 3)), New PointF((bounds.Right - 3), (bounds.Bottom - 1)), New PointF((bounds.Left + 2), (bounds.Bottom - 1))}
                    'End Section
                Case TabAlignment.Left
                    polygon = New PointF() {New PointF(bounds.Left, (bounds.Bottom - 6)), New PointF(bounds.Left, (bounds.Top + 2)), New PointF((bounds.Left + 2), bounds.Top), New PointF((bounds.Right - 3), bounds.Top), New PointF((bounds.Right - 1), (bounds.Top + 2)), New PointF((bounds.Right - 1), (bounds.Bottom - 3)), New PointF((bounds.Right - 3), (bounds.Bottom - 1)), New PointF((bounds.Left + 6), (bounds.Bottom - 1))}
                    'End Section
                Case TabAlignment.Bottom
                Case TabAlignment.Right
                    polygon = New PointF() {New PointF(bounds.Left, (bounds.Bottom - 3)), New PointF(bounds.Left, (bounds.Top + 2)), New PointF((bounds.Left + 2), bounds.Top), New PointF((bounds.Right - 3), bounds.Top), New PointF((bounds.Right - 1), (bounds.Top + 2)), New PointF((bounds.Right - 1), (bounds.Bottom - 8)), New PointF((bounds.Right - 8), (bounds.Bottom - 1)), New PointF((bounds.Left + 2), (bounds.Bottom - 1))}
                    'End Section
            End Select
            Return polygon

        End Function
    End Class
End Namespace
