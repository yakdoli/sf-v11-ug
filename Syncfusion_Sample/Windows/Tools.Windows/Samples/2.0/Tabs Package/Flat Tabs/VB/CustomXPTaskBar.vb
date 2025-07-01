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


'This class is overridden to better redraw performance.
'This is a special case because, in this app, the XPTaskBar gets drawn with
'a transparent background over a Control (tab control) that is not it's parent
'and also has it's background drawn with a gradient brush.
Public Class CustomXPTaskBar
    Inherits XPTaskBar
    'Fields
    'Constructors
    'Events
    'Methods
    Public Sub New()
        MyBase.New()
        ' To avoid flicker while the box collapses/expands.
        MyBase.SetStyle(ControlStyles.DoubleBuffer, True)

    End Sub
    'Overridden, to avoid flicker while the box collapses/expands.
    Protected Overloads Overrides Sub OnLayout(ByVal levent As LayoutEventArgs)

        MyBase.OnLayout(levent)

        If (NeedLayout) Then
            Me.Layout(Me.CreateGraphics())
        End If

    End Sub
End Class

