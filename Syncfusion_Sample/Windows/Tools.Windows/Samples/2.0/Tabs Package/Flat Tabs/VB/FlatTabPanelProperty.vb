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
Imports System.Drawing

Public Class FlatTabPanelProperty
    Inherits TabPanelProperty2D
    'Constructors
    'Methods
    Public Sub New()
        'Warning: Implementation not found
    End Sub
    Public Overloads Overrides Function DefaultInactiveTabColor(ByVal panelData As ITabPanelData, ByVal tabControl As ITabControl) As Color

        Return Color.Empty

    End Function
End Class

