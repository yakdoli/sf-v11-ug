Imports Microsoft.VisualBasic
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

Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Namespace OutlookDemo
	''' <summary>
	''' Summary description for EntryPoint.
	''' </summary>
	Public Class EntryPoint
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
        <STAThread()> _
             Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub
	End Class
End Namespace
