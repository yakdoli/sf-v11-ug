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

Namespace GettingStarted
	Partial Public Class Form1
		Inherits Form
		#Region "Constructor"
		Public Sub New()
			InitializeComponent()

			' Layout controls.
			Dim rect As Rectangle = System.Windows.Forms.Screen.PrimaryScreen.Bounds
			Me.MinimumSize = New Size(rect.Width * 2 \ 3, rect.Height * (3 \ 2))
			Me.Location = New Point(rect.Width \ 6, 0)
            comboBox1.Items.AddRange(New Object() {"CorporateBrochure.pdf", "TextFormatting.pdf", "SimpleTable.pdf", "Graphics.pdf", "MultiColumnReports.pdf", "Barcode.pdf"})
			comboBox1.SelectedIndex = 0

			Dim toolbar As Control = Me.pdfViewerControl1.Controls("tableLayoutPanel1").Controls("DocumentToolbar")
			If toolbar IsNot Nothing Then
				lblText.Parent = Nothing
				toolbar.Controls.Add(lblText)
				lblText.Parent = toolbar
				lblText.Dock = DockStyle.Right

				comboBox1.Parent = Nothing
				comboBox1.Parent = toolbar
				comboBox1.Dock = DockStyle.Right
				toolbar.Controls.Add(comboBox1)
				AddHandler comboBox1.SelectedValueChanged, AddressOf comboBox1_SelectedValueChanged

				comboBox1_SelectedValueChanged(Nothing, Nothing)
			End If
		End Sub
		#End Region

		#Region "Events"

		''' <summary>
		''' Load files.
		''' </summary>
		Private Sub comboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			pdfViewerControl1.Load(GetFullTemplatePath(comboBox1.SelectedItem.ToString()))
			pdfViewerControl1.Focus()
		End Sub
		#End Region

		#Region "Helper Methods"
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
		#End Region
	End Class
End Namespace