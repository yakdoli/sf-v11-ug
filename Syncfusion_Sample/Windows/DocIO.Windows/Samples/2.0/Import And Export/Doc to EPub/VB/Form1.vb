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
Imports Syncfusion.DocIO

Namespace DocToEPub_2005
	Partial Public Class Form1
		Inherits Form
		Private openFileDialog1 As New OpenFileDialog()

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			openFileDialog1.InitialDirectory = Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"
			openFileDialog1.Filter = "Word 97 to 2003 Document (*.doc)|*.doc|Word 2007 Document(*.docx)|*.docx"

			openFileDialog1.FileName = ""
			Dim result As DialogResult = openFileDialog1.ShowDialog()

			If result = System.Windows.Forms.DialogResult.OK Then
				Me.textBox1.Text = openFileDialog1.SafeFileName
				Me.textBox1.Tag = openFileDialog1.FileName
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.textBox1.Text = "Doc to EPub.doc"
			Me.textBox1.Tag = Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\Doc to EPub.doc"
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            If Not String.IsNullOrEmpty(Me.textBox1.Text) Then
                Try
                    'Open the document to convert from Word to EPub
                    Dim document As New WordDocument(CStr(textBox1.Tag))

                    document.SaveOptions.EPubExportFont = Me.checkBox1.Checked

                    document.Save("Sample.epub", FormatType.EPub)

                    document.Close()

                    'Message box confirmation to view the created document.
                    If MessageBox.Show("Do you want to view the EPub file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                        Try
                            Dim process As System.Diagnostics.Process = System.Diagnostics.Process.Start("Sample.epub")
                            If process IsNot Nothing AndAlso process.ProcessName IsNot Nothing AndAlso process.ProcessName.ToLower() = "rundll32" Then
                                process.Kill()
                                MessageBox.Show("EPub viewer is not installed in this system!", "Status")
                            End If
                            Me.Close()
                        Catch ex As Win32Exception
                            MessageBox.Show("EPub viewer is not installed in this system!", "Status")
                        Catch ex As Exception
                            MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        End Try
                    End If
                Catch ex As Exception
                    MessageBox.Show("The input document could not be processed, could you please email the document to support@syncfusion.com for troubleshooting?", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Try
            Else
                MessageBox.Show("Browse a word document and click the button to convert as a EPub.")
            End If
		End Sub
	End Class
End Namespace