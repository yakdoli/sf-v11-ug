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

Namespace Syncfusion.Windows.Forms.Chart.Samples
	''' <summary>
	''' Summary description for Data.
	''' </summary>
	Public Class Data
		Public Sub New(ByVal x As Double, ByVal y As Double)
			Me.x_Renamed = x
			Me.y_Renamed = y
		End Sub

		Private x_Renamed As Double
		Private y_Renamed As Double = 0

		Public ReadOnly Property X() As Double
			Get
				Return Me.x_Renamed
			End Get
		End Property

		Public ReadOnly Property Y() As Double
			Get
				Return Me.y_Renamed
			End Get
		End Property
	End Class
End Namespace
