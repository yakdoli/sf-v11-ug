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

Namespace CustomTabControls
    ' Subclassed control to do custom border drawing
    Public Class DemoTabControl
        Inherits TabControlAdv
        'Fields
        'Constructors
        'Events
        'Methods
        Public Sub New()
            'Warning: Implementation not found
        End Sub
        Protected Overloads Overrides Function GetRightBottomBorderShadeColor() As Color

            Return Color.Empty

        End Function
        Protected Overloads Overrides Function GetRightBottomBorderColor() As Color

            Return Color.FromArgb(42, 67, 126)

        End Function
        Protected Overloads Overrides Function GetTopLeftBorderColor() As Color

            Return Color.FromArgb(42, 67, 126)

        End Function
    End Class
End Namespace
