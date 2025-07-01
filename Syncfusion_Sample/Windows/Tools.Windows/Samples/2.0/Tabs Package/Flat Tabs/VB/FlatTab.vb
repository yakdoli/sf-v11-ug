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


Public Class FlatTab
    Inherits TabControlAdv
    'Fields
    'Constructors
    'Events
    'Methods
    Public Sub New()
        'Warning: Implementation not found
    End Sub
    Protected Overloads Overrides Sub RendererChanged(ByVal rendererNew As TabPanelRenderer)

        Dim renderer As FlatTabPanelRenderer
        renderer = Nothing
        If (Me.Multiline = False) Then
            renderer = New FlatTabPanelRenderer(Me)
        End If
        MyBase.RendererChanged(renderer)

    End Sub
    Protected Overloads Overrides Sub OnPaint(ByVal e As PaintEventArgs)

        ' Background
        If NeedLayout Then
            Me.Layout(e.Graphics, True)
        End If
        e.Graphics.FillRectangle(New SolidBrush(Me.BackColor), Me.ClientRectangle)
        DrawPanelBackground(e.Graphics)
        'Draw3DBorder(e.Graphics, Rectangle.Round(GetBorderRect()));
        Me.Renderer.OnPaint(e.Graphics, e.ClipRectangle)

    End Sub
End Class

