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


Public Class FlatTabPanelRenderer
    Inherits SingleLineTabPanelRenderer
    'Fields
    'Constructors
    'Methods
    Public Sub New(ByVal tabControl As ITabControl)
        MyBase.New(tabControl)
        ' Proivdes indenting to the left of the tabs (4 pixels)
        '  Me.PadY = (Me.PadY + 4.0!)

    End Sub
    Public Overloads Overrides Function DefaultTabPanelBackgroundColor() As Color

        ' Ensures that the base class doesn't paint the bg.
        Return Color.Empty

    End Function
    Public Overloads Overrides Sub OnPaint(ByVal g As Graphics, ByVal clipRect As Rectangle)

        If (Me.tabRenderers.Count <= 0) Then
            Return
        End If
        ' Draw the linear background.
        If NeedLayout Then
            Me.Layout(g, True)
        End If
        Dim rectBG As RectangleF
        rectBG = Me.Bounds
        Dim lgb As LinearGradientBrush
        lgb = New LinearGradientBrush(rectBG, SystemColors.Control, SystemColors.ControlDark, LinearGradientMode.Horizontal)
        Dim blend As Blend
        blend = New Blend(2)
        blend.Factors(0) = 0.0!
        blend.Factors(1) = 0.3!
        blend.Positions(0) = 0.0!
        blend.Positions(1) = 1.0!
        lgb.Blend = blend
        g.FillRectangle(lgb, rectBG)
        ' Call the base class to continue with normal drawing.
        MyBase.OnPaint(g, clipRect)

    End Sub

    Public Overrides Function IsBackgroundSolid() As Boolean
        ' Since we are drawing transparent, there is a chance the bg will be non-solid
        ' so specifying false here.
        Return False
    End Function
End Class

