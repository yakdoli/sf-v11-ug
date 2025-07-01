#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS
Imports Syncfusion.DocToPDFConverter
Imports Syncfusion.Pdf
Namespace Doc_To_RTF
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
            InitializeComponent()
           End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
            openFileDialog1.InitialDirectory = Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"
            openFileDialog1.FileName = ""
            Dim result As DialogResult = openFileDialog1.ShowDialog()

            If result = Windows.Forms.DialogResult.OK Then
                Me.textBox1.Text = openFileDialog1.SafeFileName
                Me.textBox1.Tag = openFileDialog1.FileName

            End If
        End Sub


        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.textBox1.Text = "DocToPDF.docx"
            Me.textBox1.Tag = Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\DocToPDF.docx"
        End Sub

        Private Sub btnconvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnconvert.Click
            If Me.textBox1.Text <> String.Empty Then
                Dim wordDoc As WordDocument = New WordDocument(CStr(textBox1.Tag), Syncfusion.DocIO.FormatType.Automatic)
                Dim converter As DocToPDFConverter = New DocToPDFConverter()
                'Convert word document into PDF document
                Dim pdfDoc As PdfDocument = converter.ConvertToPDF(wordDoc)
                'Save the pdf file
                pdfDoc.Save("DoctoPDF.pdf")
                'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the PDF file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Try
                        System.Diagnostics.Process.Start("DoctoPDF.pdf")
                        'Exit
                        Me.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.ToString())
                    End Try
                End If
            End If
        End Sub
    End Class
End Namespace