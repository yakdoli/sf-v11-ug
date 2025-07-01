Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Grid
Imports Syncfusion.GridHelperClasses
Imports Syncfusion.Windows.Forms

Namespace PrintPageLayout
	Partial Public Class Form1
		Inherits MetroForm
		Public Sub New()
			InitializeComponent()
			
			Try
				Dim ico As New System.Drawing.Icon(GetIconFile("common\Images\Grid\Icon\sfgrid.ico"))
				Me.Icon = ico
			Catch
			End Try
			
			gridControl1.RowCount = 153
			gridControl1.ColCount = 45
		End Sub

		Private layoutHelper As LayoutSupportHelper
		Private pd As GridPrintDocument
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			pd = New GridPrintDocument(gridControl1)
			If pd.PrinterSettings.IsValid Then
				layoutHelper = New LayoutSupportHelper(gridControl1)
			End If

			gridControl1.HorizontalThumbTrack = True
			gridControl1.VerticalThumbTrack = True
			AddHandler colorPickerButton1.ColorSelected, AddressOf colorPickerButton1_ColorSelected
			AddHandler colorPickerButton2.ColorSelected, AddressOf colorPickerButton2_ColorSelected
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

		Private Sub colorPickerButton1_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			If layoutHelper IsNot Nothing Then
				layoutHelper.LineColor = colorPickerButton1.SelectedColor
			End If
			gridControl1.Invalidate()
		End Sub

		Private Sub colorPickerButton2_ColorSelected(ByVal sender As Object, ByVal e As EventArgs)
			If layoutHelper IsNot Nothing Then
				layoutHelper.TextColor = colorPickerButton2.SelectedColor
			End If
			gridControl1.Invalidate()
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			If layoutHelper IsNot Nothing Then
				layoutHelper.ShowLayoutLines = Me.checkBox1.Checked
			End If
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim dlg As New PrintPreviewDialog()
			dlg.Document = pd
			dlg.ShowDialog()
		End Sub
	End Class
End Namespace