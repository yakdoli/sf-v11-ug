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
Imports Syncfusion.DocIO.DLS
Imports System.Diagnostics
Imports System.IO
Imports Syncfusion.DocIO
Imports System.Xml.Schema

Namespace HTMLToDoc_2005
	Public Partial Class Form1
		Inherits Form
		#Region "Constructor"
		Public Sub New()
			InitializeComponent()
			Me.label4.Visible = True
			Me.panel4.Visible = False
            Me.Size = New Size(384, 650)
            Me.outpuTextBox.ReadOnly = True
			Dim read As StreamReader = New StreamReader("..\..\..\..\..\..\..\..\..\Common\Data\DocIO\Transitional.html")
            Dim text As String = read.ReadToEnd()
			Me.textBox1.Text = text
		End Sub
		#End Region

		#Region "Browse HTML content"
        Private text1 As String
		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
            openFileDialog1.InitialDirectory = "..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"
			openFileDialog1.FileName = ""
			openFileDialog1.Filter = "HTML files (*.html)|*.html"
			Dim result As DialogResult = openFileDialog1.ShowDialog()

			If result = System.Windows.Forms.DialogResult.OK Then
				Dim read As StreamReader = New StreamReader(openFileDialog1.OpenFile())
                text1 = read.ReadToEnd()
			End If
            Me.textBox1.Text = text1

			outpuTextBox.Clear()

		End Sub
		#End Region

		#Region "HTML to Doc"
		Private errorMessage As String = ""
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			If Me.textBox1.Text <> String.Empty Then
				Dim document As WordDocument = New WordDocument()
                Dim section As IWSection = document.AddSection()
                ' Set Margin of the document
                section.PageSetup.Margins.All = 72
                Dim para As IWParagraph = section.AddParagraph()
				' This manual validation check is optional. We do this here only for instructional purpose
				Dim valid As Boolean = section.Body.IsValidXHTML(Me.textBox1.Text, XHTMLValidationType.Transitional, errorMessage)
				If (Not valid) Then
					outpuTextBox.Text = "Content is not a welformatted XHTML content." & Constants.vbTab + Constants.vbTab + Constants.vbTab & "Error message:" & Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab & errorMessage
					Me.panel4.Visible = True
					Me.label4.Visible = False
					Me.button3.Text = "-"
                    Me.Size = New Size(384, 650)
				Else
					' By default, the input html will be validated for XHTML format. This will provide you understandable error messages, if the format is invalid.
					' However, if you are sure that the input html is valid, then you can skip the validation step to improve performance. However, any error messages 
					'you might get here will not be very useful as to where exactly in your html, the issue is.

					document.XHTMLValidateOption = XHTMLValidationType.Transitional
					section.Body.InsertXHTML(Me.textBox1.Text)

                    outpuTextBox.Text = "Conversion Successful"
                    Me.panel4.Visible = True
                    Me.label4.Visible = False
                    Me.button3.Text = "-"
                    Me.Size = New Size(384, 650)

'					#Region "Save and open Document"
                    'Save as word 2003  format
                    If word2003RadioBtn.Checked Then
                        'Saving the document to disk.
                        document.Save("Sample.doc")

                        'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                            System.Diagnostics.Process.Start("Sample.doc")
                            'Exit
                            Me.Close()
                        End If
                        'Save as word 2007 format
                    ElseIf word2007RadioBtn.Checked Then

                        'Saving the document as .docx
                        document.Save("Sample.docx", FormatType.Word2007)
                        'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            Try
                                'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                                System.Diagnostics.Process.Start("Sample.docx")
                                'Exit
                                Me.Close()
                            Catch ex As Win32Exception
                                MessageBox.Show("Word 2007 is not installed in this system")
                                Console.WriteLine(ex.ToString())
                            End Try
                        End If
                        'Save as word 2010 format
                    ElseIf word2010RadioBtn.Checked Then

                        'Saving the document as .docx
                        document.Save("Sample.docx", FormatType.Word2010)
                        'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            Try
                                'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                                System.Diagnostics.Process.Start("Sample.docx")
                                'Exit
                                Me.Close()
                            Catch ex As Win32Exception
                                MessageBox.Show("Word 2007 is not installed in this system")
                                Console.WriteLine(ex.ToString())
                            End Try
                        End If
                        'Save as word 2013 format
                    ElseIf word2013RadioBtn.Checked Then

                        'Saving the document as .docx
                        document.Save("Sample.docx", FormatType.Word2013)
                        'Message box confirmation to view the created document.
                        If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                            Try
                                'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                                System.Diagnostics.Process.Start("Sample.docx")
                                'Exit
                                Me.Close()
                            Catch ex As Win32Exception
                                MessageBox.Show("Word 2013 is not installed in this system")
                                Console.WriteLine(ex.ToString())
                            End Try
                        End If
                    Else
                        ' Exit
                        Me.Close()
                    End If
'					#End Region
				End If
			Else
				MessageBox.Show("Browse or type the HTML content to be converted to word document")
			End If
		End Sub
		#End Region

		#Region "Events"

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			If label4.Visible = True Then
				Me.panel4.Visible = True
				Me.label4.Visible = False
				Me.button3.Text = "--"
                Me.Size = New Size(384, 650)
			Else
				Me.panel4.Visible = False
				Me.label4.Visible = True
				Me.button3.Text = "+"
                Me.Size = New Size(384, 650)
			End If
		End Sub

		#End Region
	End Class
End Namespace