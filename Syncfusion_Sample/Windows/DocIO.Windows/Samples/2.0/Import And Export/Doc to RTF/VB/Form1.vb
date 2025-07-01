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
Imports System.IO

Namespace Doc_To_RTF
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
            Dim path As String = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"
            openFileDialog1.InitialDirectory = New DirectoryInfo(path).FullName
        End Sub
        Private fullPath As String
#Region "Convert To RTF       "

        Private Sub button1_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            If Me.textBox1.Text <> [String].Empty AndAlso fullPath <> String.Empty Then
                If Me.textBox1.Text.Contains("//") Then
                    ' in case user copy-paste the path in the textbox
                    fullPath = Me.textBox1.Text
                End If

                If File.Exists(fullPath) Then
                    Dim doc As New WordDocument(fullPath)
                    'Export the doc to RTF and save as .rtf file
                    doc.Save("DocToRtf.rtf", FormatType.Rtf)
                    'Message box confirmation to view the created document.
                    If MessageBox.Show("Do you want to view the RTF file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Try
                            System.Diagnostics.Process.Start("DocToRtf.rtf")
                            'Exit
                            Me.Close()
                        Catch ex As Exception
                            Console.WriteLine(ex.ToString())
                        End Try
                    End If
                Else
                    MessageBox.Show("File doesn?t exist")
                End If
            Else
            MessageBox.Show("Browse a word document and click the button to convert as a RTF.")
            End If
        End Sub
#End Region

#Region "Browse Document"
        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
            openFileDialog1.InitialDirectory = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"
            openFileDialog1.FileName = ""
            Dim result As DialogResult = openFileDialog1.ShowDialog()

            If result = System.Windows.Forms.DialogResult.OK Then
                Me.textBox1.Text = openFileDialog1.FileName

            End If
        End Sub
#End Region ' Browse Document

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            Me.textBox1.Text = "DocToRTF.doc"
            fullPath = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\DocToRTF.doc"
        End Sub
    End Class
End Namespace