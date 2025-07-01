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
    ' Some global properties for the DemoTabsRenderer Tab Style
    Public Class DemoTabPanelProperty
        Inherits TabUIDefaultProperties
        'Constructors
        'Methods
        Public Sub New()
            'Warning: Implementation not found
        End Sub
        ' The selected tab overlaps the inactive tabs by this much. 20 on both sides.
        Public Overloads Overrides Function GetOverlapSize(ByVal tabSize As SizeF) As SizeF

            Return New SizeF(20, 0)

        End Function
    End Class
End Namespace
