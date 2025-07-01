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
Imports System.Data
Imports System.Windows.Forms
Imports System.Collections

Imports Syncfusion.Windows.Forms.Chart

Namespace Syncfusion.Windows.Forms.Chart.Samples
	''' <summary>
	''' Summary description for SimpleModel.
	''' </summary>
	Public Class TopArrayModel
		Implements IChartSeriesModel
		Private xdata As ArrayList = New ArrayList()
		Private ydata As ArrayList = New ArrayList()

		Private topCount_Renamed As Integer

		Public Sub New()
		End Sub

		Public ReadOnly Property Count() As Integer Implements IChartSeriesModel.Count
			Get
				Try
'INSTANT VB NOTE: The local variable count was renamed since Visual Basic will not allow local variables with the same name as their enclosing function or property:
					Dim count_Renamed As Integer = 0
					If topCount_Renamed > 0 Then
						count_Renamed = Math.Min(topCount_Renamed, Me.xdata.Count)
					Else
						count_Renamed = Me.xdata.Count
					End If
					Return count_Renamed
				Catch e As Exception
					Console.WriteLine(e.Message)
				End Try

				Return 0
			End Get
		End Property

		Public Property TopCount() As Integer
			Get
				Return topCount_Renamed
			End Get

			Set(ByVal value As Integer)
				topCount_Renamed = value
			End Set
		End Property

		Public Function GetY(ByVal index As Integer) As Double() Implements IChartSeriesModel.GetY
			Dim topIndex As Integer =0
			Try
				If topCount_Renamed = 0 Then
					topIndex = index
				Else
					topIndex = Math.Max(0,Me.xdata.Count - topCount_Renamed + index -1)
				End If
				Return CType(ydata(topIndex), Double())
			Catch e As Exception
				Console.WriteLine(e.Message & " " & topIndex.ToString() & " " & Me.xdata.Count.ToString())
			End Try

			Return New Double(){0}
		End Function

		Public Function GetX(ByVal index As Integer) As Double Implements IChartSeriesModel.GetX
			Dim topIndex As Integer = 0
			Try
				If topCount_Renamed = 0 Then
					topIndex = index
				Else
					topIndex = Math.Max(0,Me.xdata.Count - topCount_Renamed + index -1)
				End If
				Return CDbl(xdata(topIndex))
			Catch e As Exception
				Console.WriteLine(e.Message & " " & topIndex.ToString() & " " & Me.xdata.Count.ToString())
			End Try

			Return 0
		End Function

		Public Sub RaiseListChanged()
			If Me.ChangedEvent IsNot Nothing Then
				RaiseEvent Changed(Me,New ListChangedEventArgs(ListChangedType.Reset,-1))
			End If
		End Sub

		Public Sub AddXY(ByVal xval As Double, ByVal yvalues As Double())
			xdata.Add(xval)
			ydata.Add(yvalues)
			Me.RaiseListChanged()
		End Sub

		Public Function GetEmpty(ByVal index As Integer) As Boolean Implements IChartSeriesModel.GetEmpty
			Return False
		End Function

		Public Event Changed As ListChangedEventHandler Implements IChartSeriesModel.Changed
	End Class
End Namespace