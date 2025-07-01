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
Imports System
Imports System.Windows.Forms

Namespace TestEngineOptimizations
	''' <summary>
	''' Summary description for EntryPoint.
	''' </summary>
	Public Class EntryPoint
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
#If SyncfusionFramework1_1 OrElse SyncfusionFramework2_0 Then
			Application.EnableVisualStyles()
#End If
            Dim f As New Form1()
            Application.Run(f)
        End Sub

	End Class
End Namespace
