#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections.ObjectModel
Imports System.IO
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports Syncfusion.Windows.Forms

Namespace ObservableCollection_Demo
	Partial Public Class Form1
		Inherits MetroForm
		Private eventTracer As EngineEventTracer
		Public Sub New()
			InitializeComponent()
			Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
			Me.Icon = ico
			Me.gridGroupingControl1.DataSource = New Customer()
			Me.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro
			Me.gridGroupingControl1.ShowGroupDropArea = True
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowFilterBar = True
			Dim eng As GridEngine = Me.gridGroupingControl1.Engine
			eventTracer = New EngineEventTracer(eng, Me.listView1)
		End Sub

		Private Function GetIconFile(ByVal bitmapName As String) As String
			For n As Integer = 0 To 9
				If System.IO.File.Exists(bitmapName) Then
					Return bitmapName
				End If

				bitmapName = "..\" & bitmapName
			Next n

			Return bitmapName
		End Function

		#Region "EventHandlers"
		Private Sub buttonAdv1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv1.Click
			Me.listView1.Items.Clear()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			If Me.button1.Text = "Trace Events" Then
				Me.eventTracer.HookEvents()
				Me.button1.Text = "Disable Tracing"
			Else
				Me.eventTracer.UnhookEvents()
				Me.button1.Text = "Trace Events"
			End If
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			For Each col As GridColumnDescriptor In Me.gridGroupingControl1.TableDescriptor.Columns
				col.AllowFilter = True
			Next col
		End Sub

		Private Sub gridGroupingControl1_FilterBarSelectedItemChanged(ByVal sender As Object, ByVal e As FilterBarSelectedItemChangedEventArgs) Handles gridGroupingControl1.FilterBarSelectedItemChanged
			Me.eventTracer.AppendOutput("Filtered Column: ", e.Column.Name.ToString())
			Me.eventTracer.AppendOutput("SelectedText: ", e.SelectedText)
		End Sub
		#End Region
	End Class

	Public Class Customer
		Inherits ObservableCollection(Of Customers)
		Private northWind As Northwind

		Public Sub New()
			 Dim connectionString As String = String.Format("Data Source = {0}", FindFile("Northwind.sdf"))
			 northWind = New Northwind(connectionString)
			 Dim customer = northWind.Customers.Skip(0).Take(100).ToList()
			 For Each o In customer
				 Me.Add(o)
			 Next o
		End Sub

		Private Shared Function FindFile(ByVal fileName As String) As String
			Dim dataFileName As String = "Common\Data\" & fileName
			For n As Integer = 0 To 11
				If System.IO.File.Exists(fileName) Then
					Return New FileInfo(fileName).FullName
				End If
				If System.IO.File.Exists(dataFileName) Then
					Return New FileInfo(dataFileName).FullName
				End If
				fileName = "..\" & fileName
				dataFileName = "..\" & dataFileName
			Next n

			Return fileName
		End Function
	End Class
End Namespace
