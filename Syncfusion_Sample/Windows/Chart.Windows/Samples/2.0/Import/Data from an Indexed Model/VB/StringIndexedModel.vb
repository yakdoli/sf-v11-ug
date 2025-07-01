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
Imports System.Diagnostics
Imports System.ComponentModel

Imports Syncfusion.Windows.Forms.Chart

Namespace ChartImportData
	''' <summary>
	''' Summary description for SimpleModel.
	''' </summary>
	Public Class StringIndexedModel
		Implements IChartSeriesIndexedModel
		Private y As Double()
		Public Sub New(ByVal series As ChartSeries, ByVal y As Double())
			Me.y = y
		End Sub
		Public ReadOnly Property Count() As Integer Implements IChartSeriesIndexedModel.Count
			Get
				Return Me.y.GetLength(0)
			End Get
		End Property
		Public Function GetY(ByVal xIndex As Integer) As Double() Implements IChartSeriesIndexedModel.GetY
			Return New Double(){y(xIndex)}
		End Function
		Public Function GetEmpty(ByVal index As Integer) As Boolean Implements IChartSeriesIndexedModel.GetEmpty
			Return False
		End Function

		Public Event Changed As ListChangedEventHandler Implements IChartSeriesIndexedModel.Changed
	End Class
End Namespace
