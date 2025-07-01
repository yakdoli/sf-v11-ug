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
Namespace InsertOLE_Object
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click

            Dim TemplatePath As String = Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"

            Dim dest As WordDocument = New WordDocument()
            dest.EnsureMinimal()
            ' Set Margin of the section
            dest.Sections(0).PageSetup.Margins.All = 72
            Dim oleSource As WordDocument
            If word2003RadioBtn.Checked Then
                oleSource = New WordDocument(TemplatePath & "OleTemplate.doc")
            Else
                oleSource = New WordDocument(TemplatePath & "OleTemplate.docx")
            End If
            Dim oleObject As WOleObject = Nothing
            ' Get OLE object from source document
            For i As Integer = 0 To oleSource.LastSection.Paragraphs(4).Items.Count - 1
                If TypeOf oleSource.LastSection.Paragraphs(4).Items(i) Is WOleObject Then
                    oleObject = TryCast(oleSource.LastSection.Paragraphs(4).Items(i), WOleObject)
                    Exit For
                End If
            Next

            Dim pic As WPicture = TryCast(oleObject.OlePicture.Clone(), WPicture)
            dest.LastParagraph.AppendText("OLE Object Demo")
            dest.LastParagraph.ApplyStyle(BuiltinStyle.Heading1)
            dest.LastParagraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center

            dest.Sections(0).AddParagraph()
            dest.LastParagraph.AppendText("MS Excel Object Inserted")
            dest.LastParagraph.ApplyStyle(BuiltinStyle.Heading2)

            dest.Sections(0).AddParagraph()
            ' AppendOLE object to the destination document
            oleObject = dest.LastParagraph.AppendOleObject(oleObject.Container, pic, OleLinkType.Embed)
            oleObject.DisplayAsIcon = CheckBoxChoose.Checked
            'Save as word 2003  format
            If word2003RadioBtn.Checked Then
                'Saving the document to disk.
                dest.Save("Sample.doc")

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
                dest.Save("Sample.docx", FormatType.Word2007)
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
                dest.Save("Sample.docx", FormatType.Word2010)
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
                dest.Save("Sample.docx", FormatType.Word2013)
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
        End Sub
    End Class
End Namespace