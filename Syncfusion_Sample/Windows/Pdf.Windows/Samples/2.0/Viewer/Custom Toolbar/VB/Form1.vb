Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2011"
' Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace ToolbarCustomization_2005
	Partial Public Class Form1
		Inherits Form
		#Region "Constructor"
		Public Sub New()
			InitializeComponent()

			' Layout controls.
			Dim rect As Rectangle = System.Windows.Forms.Screen.PrimaryScreen.Bounds
			Me.MinimumSize = New Size(rect.Width * 2 \ 3, rect.Height * (3 \ 2))
			Me.Location = New Point(rect.Width \ 6, 0)

			Me.DefaultToolbar.Height = 24
		End Sub
		#End Region

		#Region "Events"
		''' <summary>
		''' Load PDF into PDF Viewer.
		''' </summary>
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			LoadDocument(GetFullTemplatePath("TextFormatting.pdf"))
		End Sub

		''' <summary>
		''' Toggles between default and custom toolbar.
		''' </summary>
		Private Sub DefaultToolbar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DefaultToolbar.CheckedChanged, CustomToolbar.CheckedChanged
			If DefaultToolbar.Checked Then
				pdfViewerControl1.ShowToolBar = True
				CustomPanel.Visible = False
			Else
				pdfViewerControl1.ShowToolBar = False
				CustomPanel.Visible = True
				SetPageNumber()
			End If
		End Sub

		''' <summary>
		''' Handles open button in the custom toolbar.
		''' </summary>
		Private Sub toolStripButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton1.Click
			Dim dialog As New OpenFileDialog()
			dialog.Filter = "Pdf Files (.pdf)|*.pdf"
			dialog.ShowDialog()
			If Not String.IsNullOrEmpty(dialog.FileName) Then
				LoadDocument(dialog.FileName)
			End If
		End Sub

		Private Sub btnFirst_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFirst.Click
			pdfViewerControl1.GoToPageAtIndex(1)
			SetPageNumber()
		End Sub

		Private Sub btnLast_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLast.Click
			pdfViewerControl1.GoToPageAtIndex(pdfViewerControl1.PageCount)
			SetPageNumber()
		End Sub

		Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
			If pdfViewerControl1.CurrentPageIndex <> 1 Then
				pdfViewerControl1.GoToPageAtIndex(pdfViewerControl1.CurrentPageIndex - 1)
			End If

			SetPageNumber()
		End Sub

		Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
			If pdfViewerControl1.CurrentPageIndex <> pdfViewerControl1.PageCount Then
				pdfViewerControl1.GoToPageAtIndex(pdfViewerControl1.CurrentPageIndex + 1)
			End If

			SetPageNumber()
		End Sub

		#End Region

		#Region "Helper methods"
		''' <summary>
		''' Loads PDF into PDF Viewer.
		''' </summary>
		Private Sub LoadDocument(ByVal fileName As String)
			pdfViewerControl1.Load(fileName)
		End Sub

		''' <summary>
		''' Gets the full path of the PDF template or image.
		''' </summary>
		''' <param name="fileName">Name of the file</param>
		''' <param name="image">True if image</param>
		''' <returns>Path of the file</returns>
		Private Function GetFullTemplatePath(ByVal fileName As String) As String
			Dim fullPath As String = "..\..\..\..\..\..\..\..\..\Common\Data\PDF\"

			Return String.Format("{0}{1}", fullPath, fileName)
		End Function

		Private Sub SetPageNumber()
			txtPageNumber.Text = pdfViewerControl1.CurrentPageIndex.ToString()
		End Sub

		#End Region
	End Class
End Namespace