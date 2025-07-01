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
Imports System.Collections.Specialized
Imports Syncfusion.ComponentModel
Imports Syncfusion.Grouping
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.Windows.Forms.Grid.Grouping
Imports System.Collections

Namespace I58680b
	Partial Public Class Form1
		Inherits Syncfusion.Windows.Forms.MetroForm
		Private employees As New BindingList(Of Employee)()


		Public Sub New()
			InitializeComponent()
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

'			#Region "DataSource"
			employees.Add(New Employee("Ana Trujillo", Status.Divorced, Context.Employed))
			employees.Add(New Employee("Antonio Moreno", Status.Single, Context.Retired))
			employees.Add(New Employee("Thomas Hardy", Status.Single, Context.OnVacation))
			employees.Add(New Employee("Christina Berglund", Status.Single, Context.Sick))
			employees.Add(New Employee("Hanna Moos", Status.Single, Context.Employed))
			employees.Add(New Employee("Frédérique Citeaux", Status.Single, Context.OnVacation))
			employees.Add(New Employee("Katie Homes", Status.Married, Context.Employed))
			employees.Add(New Employee("Sam Anderson", Status.Married, Context.Sick))
			employees.Add(New Employee("Shan Tait", Status.Single, Context.OnVacation))
			employees.Add(New Employee("Adam Smith", Status.Widow, Context.Retired))
			employees.Add(New Employee("Steve Joseph", Status.Widow, Context.Retired))
'			#End Region

			AddHandler gridGroupingControl1.QueryCellStyleInfo, AddressOf gridGroupingControl1_QueryCellStyleInfo
			Me.gridGroupingControl1.DataSource = employees
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = False
			Me.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = False
			Me.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro

			Me.FormBorderStyle=System.Windows.Forms.FormBorderStyle.FixedSingle

			checkBox1.Checked = True
			AddHandler checkBox1.CheckedChanged, AddressOf checkBox1_CheckedChanged

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
		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			Me.gridGroupingControl1.Refresh()
		End Sub

		Private Sub gridGroupingControl1_QueryCellStyleInfo(ByVal sender As Object, ByVal e As GridTableCellStyleInfoEventArgs)
			Dim el = e.TableCellIdentity
			Dim item = If(el.DisplayElement IsNot Nothing, el.DisplayElement.GetData(), Nothing)

			If TypeOf item Is Employee AndAlso el.Column IsNot Nothing AndAlso el.Column.FieldDescriptor IsNot Nothing AndAlso el.Column.FieldDescriptor.FieldPropertyType.IsEnum AndAlso (el.DisplayElement.Kind = DisplayElementKind.Record OrElse el.DisplayElement.Kind = DisplayElementKind.AddNewRecord) Then
				Dim context = New TypeDescriptorContext(item, e.Style.PropertyDescriptor)
				Dim converter = e.Style.PropertyDescriptor.Converter
				If converter IsNot Nothing Then
					Dim contextualValues = converter.GetStandardValues(context).OfType(Of Object)().ToArray()
					e.Style.CellType = "ComboBox"
					If Not checkBox1.Checked Then
						e.Style.DataSource = contextualValues
					End If
				End If
			End If

		End Sub


	End Class
End Namespace
