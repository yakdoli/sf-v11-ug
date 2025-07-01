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
Imports System.Collections
Imports System.ComponentModel

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.Grouping

Namespace Syncfusion.Windows.Forms.Chart.Samples
	''' <summary>
	''' Filtering of data is done in this class using the Grouping Engine.
	''' </summary>
	Public Class DataModel
		Implements IChartSeriesModel
		Private DataList As ArrayList = New ArrayList()
		Private group As Engine = New Engine()
		Private listChanged As ListChangedEventArgs

		Private r As Random = New Random()

		''' <summary>
		''' Constructor. Initializes a new instance of the DataModel class.
		''' </summary>
		Public Sub New()
			' Minimum requirement for Grouping Engine - DataSource should be a IList collection
			DataList.Add(New Data(DateTime.Now.ToOADate(), 0)) ' This is needed - otherwise grouping does not work
			group.SetSourceList (DataList)

			Dim exp As ExpressionFieldDescriptor = New ExpressionFieldDescriptor()
			exp.Expression = "[X] > " & DateTime.Now.AddMinutes(-5).ToOADate()

			Dim rfd As RecordFilterDescriptor = New RecordFilterDescriptor(exp.Expression)
			group.TableDescriptor.RecordFilters.Add (rfd)
		End Sub

		Public ReadOnly Property Count() As Integer Implements IChartSeriesModel.Count
			Get
				Return group.Table.FilteredRecords.Count
			End Get
		End Property

		Public Function GetY(ByVal index As Integer) As Double() Implements IChartSeriesModel.GetY
			Return New Double(){(CType(group.Table.FilteredRecords(index).GetData(), Data)).Y}
		End Function

		Public Function GetX(ByVal index As Integer) As Double Implements IChartSeriesModel.GetX
			Return (CType(group.Table.FilteredRecords(index).GetData(), Data)).X
		End Function

		Public Sub RaiseListChanged()
			If Not Me.ChangedEvent Is Nothing Then
				listChanged = New ListChangedEventArgs(ListChangedType.Reset,-1)
				RaiseEvent Changed(Me,listChanged)
			End If
		End Sub

		Public Function GetEmpty(ByVal i As Integer) As Boolean Implements IChartSeriesModel.GetEmpty
			Return False
		End Function

		Private Function GetDataUsage() As Data
			Dim time As DateTime = DateTime.Now
			Return New Data(time.ToOADate(),r.Next(100,900))
		End Function

		Public Sub Refresh()
			Me.DataList.Add(GetDataUsage())
			GetFilteredRecords()
		End Sub

		''' <summary>
		''' Filters the data added before 15 minutes.
		''' </summary>
		Private Sub GetFilteredRecords()
			Dim t As Double = DateTime.Now.AddMinutes(-5).ToOADate()
			group.TableDescriptor.RecordFilters(0).Expression = "[X] > " & t
			group.Table.TableDirty = True

			Me.RaiseListChanged()

'			System.Diagnostics.Trace.WriteLine(group.TableDescriptor.RecordFilters[0].Expression);
'			System.Diagnostics.Trace.WriteLine("Filtered Record Count:" + group.Table.FilteredRecords.Count);
		End Sub

		Public Event Changed As ListChangedEventHandler Implements IChartSeriesModel.Changed
	End Class
End Namespace
