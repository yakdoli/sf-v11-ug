Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.DocIO.DLS
Imports Syncfusion.DocToPDFConverter
Imports Syncfusion.Pdf
Imports System.IO

Namespace Doc_to_PDF
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Dim path As String = Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"
			openFileDialog1.InitialDirectory = New DirectoryInfo(path).FullName
		End Sub

		Private fullPath As String
		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			openFileDialog1.FileName = ""
			Dim result As DialogResult = openFileDialog1.ShowDialog()

			If result = System.Windows.Forms.DialogResult.OK Then
				Me.textBox1.Text = openFileDialog1.SafeFileName
				fullPath = openFileDialog1.FileName
			End If

		End Sub

		Private Sub btnconvert_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles btnconvert.Click
			If Me.textBox1.Text <> String.Empty AndAlso fullPath <> String.Empty Then
				If Me.textBox1.Text.Contains("//") Then ' in case user copy-paste the path in the textbox
					fullPath = Me.textBox1.Text
				End If

				If File.Exists(fullPath) Then

					Dim wordDoc As WordDocument = New WordDocument(fullPath)
					Dim converter As DocToPDFConverter = New DocToPDFConverter()
					'Convert word document into PDF document
					Dim pdfDoc As PdfDocument = converter.ConvertToPDF(wordDoc)
					'Save the pdf file
					pdfDoc.Save("DoctoPDF.pdf")

					'Message box confirmation to view the created document.
					If MessageBox.Show("Do you want to view the PDF file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
						Try
							System.Diagnostics.Process.Start("DoctoPDF.pdf")
							'Exit
							Me.Close()
						Catch ex As Exception
							Console.WriteLine(ex.ToString())
						End Try
					End If
				Else
					MessageBox.Show("File doesn’t exist")
				End If

			Else
				MessageBox.Show("Browse a word document and click the button to convert as a PDF.")
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.textBox1.Text = "DocToPDF.doc"
			fullPath = Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\DocToPDF.doc"



		End Sub
	End Class
End Namespace