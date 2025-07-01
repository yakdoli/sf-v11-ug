#Region "Copyright Syncfusion Inc. 2001 - 2006"
'
'  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports Microsoft.VisualBasic
Imports System

Namespace CustomGridCell
    Public Class TreeNodeState
        Public Shared Opened As Integer
        Public Shared Closed As Integer
        Public Shared NoChildren As Integer
        'Fields
        'Constructors
        'Methods
        Shared Sub New()
            Opened = 0
            Closed = 1
            NoChildren = 2
        End Sub
        Public Sub New()
            'Warning: Implementation not found
        End Sub
    End Class
End Namespace
