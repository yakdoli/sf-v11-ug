Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms
Imports System.Collections
Imports System.Collections.Specialized

Namespace SkinManagerDemo_2008
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()
			Dim r As New Random()
			InitializeComponent()
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try

'			#Region "DataSource"

'			#Region "DataTable"
			Dim dt As New DataTable()
			dt.Columns.Add("EmployeeName", Type.GetType("System.String"))
			dt.Columns.Add("OrderID", Type.GetType("System.Int32"))
			dt.Columns.Add("Amount", Type.GetType("System.Decimal"))
			dt.Columns.Add("Cost", Type.GetType("System.Decimal"))
			dt.Columns.Add("Date", Type.GetType("System.String"))
			dt.Rows.Add(New Object() { "Sam", 1, 25.00, 13.00, "01/10/2007" })
			dt.Rows.Add(New Object() { "Sam", 2, 512.00, 1.00, "02/10/2007" })
			dt.Rows.Add(New Object() { "Sam", 3, 512.00, 1.00, "03/10/2007" })
			dt.Rows.Add(New Object() { "Tom", 4, 50.00, 1.00, "04/10/2007" })
			dt.Rows.Add(New Object() { "Tom", 5, 3.00, 7.00, "03/10/2007" })
			dt.Rows.Add(New Object() { "Tom", 6, 78.75, 12.00, "02/10/2007" })
			dt.Rows.Add(New Object() { "Sue", 7, 11.00, 7.00, "01/10/2007" })
			dt.Rows.Add(New Object() { "Sue", 8, 2.50, 66.20, "02/10/2007" })
			dt.Rows.Add(New Object() { "Sue", 9, 2.50, 22.00, "03/10/2007" })
			dt.Rows.Add(New Object() { "Jack", 10, 6.00, 23.00, "02/10/2007" })
			dt.Rows.Add(New Object() { "Jack", 11, 117.00, 199.00, "04/10/2007" })
			dt.Rows.Add(New Object() { "Jack", 12, 13.00, 2.60, "01/10/2007" })
			dt.Rows.Add(New Object() { "Jack", 13, 11.40, 99.80, "03/10/2007" })
			dt.Rows.Add(New Object() { "Phill", 14, 37.00, 2.10, "02/10/2007" })
			dt.Rows.Add(New Object() { "Phill", 15, 65.20, 99.30, "04/10/2007" })
			dt.Rows.Add(New Object() { "Phill", 16, 34.10, 27.00, "02/10/2007" })
			dt.Rows.Add(New Object() { "Phill", 17, 17.00, 959.00, "04/10/2007" })
'			#End Region

'			#Region "GridListControl"
			Me.gridListControl1.DataSource = dt
			Me.gridListControl1.DisplayMember = "EmployeeName"
			Me.gridListControl1.ValueMember = "EmployeeName"
			Me.gridListControl1.MultiColumn = True
			Me.gridListControl1.ShowColumnHeader = True

'			#End Region

'			#Region "GridControl"
			For i As Integer = 1 To Me.gridControl1.RowCount
				For j As Integer = 1 To Me.gridControl1.ColCount
					Me.gridControl1(i, j).CellValue = r.Next(1000)
				Next j
			Next i
			Me.gridControl1.Refresh()

'			#End Region



'			#End Region

'			#Region "InitialSettings"
			Me.comboBox1.Text = "Parent Container"
			Me.comboBox2.Text = "Office2010Blue"
			SkinManager.SetVisualStyle(Me, comboBox2.Text)
'			#End Region
		End Sub

		#Region "USState Class"

		Public Class USState
			Private myShortName As String
			Private myLongName As String
			Private _imageIndex As Integer

			Public Sub New(ByVal strLongName As String, ByVal strShortName As String, ByVal _imageIndex As Integer)
				Me.myShortName = strShortName
				Me.myLongName = strLongName
				Me._imageIndex = _imageIndex
			End Sub

			Public ReadOnly Property ShortName() As String
				Get
					Return myShortName
				End Get
			End Property

			Public ReadOnly Property LongName() As String
				Get
					Return myLongName
				End Get
			End Property

			Public Property ImageIndex() As Integer
				Get
					Return _imageIndex
				End Get
				Set(ByVal value As Integer)
					_imageIndex = value
				End Set
			End Property

			Public Overrides Function ToString() As String
				Return Me.ShortName & " - " & Me.LongName
			End Function
		End Class
		#End Region

		#Region "Event Hanlder"

		Private ctrl As Control = Nothing
		Private Sub comboBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox2.SelectedIndexChanged
			If comboBox1.Text = "Parent Container" Then
				ctrl = Me.parent_Renamed
			ElseIf comboBox1.Text = "GridControl" Then
				ctrl = Me.grid
			ElseIf comboBox1.Text = "GridListControl" Then
				ctrl = Me.gridList
			Else
				ctrl = Me
			End If

			SkinManager.SetVisualStyle(ctrl, comboBox2.Text)
		End Sub

		Private Sub comboBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles comboBox1.SelectedIndexChanged
			If comboBox1.Text = "ParentContainer" Then
				ctrl = Me.parent_Renamed
			ElseIf comboBox1.Text = "GridControl" Then
				ctrl = Me.grid
			ElseIf comboBox1.Text = "GridListControl" Then
				ctrl = Me.gridList
			Else
				ctrl = Me
			End If

			SkinManager.SetVisualStyle(ctrl, comboBox2.Text)
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

		#End Region
	End Class
End Namespace
