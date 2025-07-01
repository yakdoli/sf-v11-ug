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

Namespace LayoutManagers
    ' <samplecodeblock name="Sample LayoutItemBase Derived Class">
    Public Class MyRectangle
        Inherits LayoutItemBase
        Protected WithEvents parent As Control
        Protected color As color
        Protected [text] As String
        Public Shared PrefSize As System.Drawing.Size
        'Fields
        'Constructors
        'Events
        'Methods
        Shared Sub New()
            'Warning: Implementation not found
        End Sub
        Public Sub New(ByVal parent As Control, ByVal color As color, ByVal [text] As String)
            MyBase.New()
            Me.parent = parent
            Me.color = color
            Me.text = [text]

        End Sub
        Public Overrides ReadOnly Property MinimumSize() As System.Drawing.Size
            Get

                Return MyRectangle.PrefSize

            End Get
        End Property
        Public Overrides ReadOnly Property PreferredSize() As System.Drawing.Size
            Get

                Return MyRectangle.PrefSize

            End Get
        End Property
        Protected Overloads Overrides Sub OnBoundsChanged()

            parent.Invalidate(New Rectangle(0, 0, Me.parent.Width, Me.parent.Height))

        End Sub
        Public Sub OnPaint(ByVal e As PaintEventArgs)

            e.Graphics.FillRectangle(New SolidBrush(color), Me.Bounds)
            Dim sf As StringFormat
            sf = New StringFormat()
            sf.Alignment = StringAlignment.Center
            sf.LineAlignment = StringAlignment.Center
            Dim r As RectangleF
            r = New RectangleF(Me.Bounds.Left, Me.Bounds.Top, Me.Bounds.Width, Me.Bounds.Height)
            e.Graphics.DrawString([text], Control.DefaultFont, SystemBrushes.ControlText, r, sf)

        End Sub
    End Class
    ' </samplecodeblock>
End Namespace
