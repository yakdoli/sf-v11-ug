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

Namespace Syncfusion.Windows.Forms.Chart.Samples
	''' <summary>
	''' This class replaces data provider (behaves like external data source).
	''' </summary>
	Public Class DataProvider
		Public timer1 As Timer = New Timer()

		Public Sub New()
			Me.timer1.Enabled = False
			Me.timer1.Interval = 800
		End Sub
	End Class
End Namespace