Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports System.IO
Imports IEnumerableDemo

Namespace IEnumerableDemo_2005
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Try
                Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid1.ico"))
				Me.Icon = ico
			Catch
			End Try
			Me.gridDataBoundGrid1.Model.EnableLegacyStyle = False
			Me.gridDataBoundGrid1.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2010Blue
			Me.StartPosition = FormStartPosition.CenterScreen

			Dim customers As CustomerCollection = PopulateCustomers.CreateCustomers()
			Me.gridDataBoundGrid1.DataSource = customers
			Me.gridDataBoundGrid1.EnableAddNew = False
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
	End Class
End Namespace