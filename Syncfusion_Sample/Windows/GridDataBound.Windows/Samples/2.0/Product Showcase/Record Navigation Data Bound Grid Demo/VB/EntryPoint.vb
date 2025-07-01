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
Imports System.Windows.Forms

Namespace RecordNavDataBoundGrid
    'ChrW(10)
    '<summary>
    'Summary description for EntryPoint.
    '</summary>
    Public Class EntryPoint
        Public Sub New()
            'Warning: Implementation not found
        End Sub
        <STAThread()>  _
        Public Shared Sub Main()
#If ((SyncfusionFramework1_1 OrElse SyncfusionFramework2_0)) Then
Application.EnableVisualStyles
#End If
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace
