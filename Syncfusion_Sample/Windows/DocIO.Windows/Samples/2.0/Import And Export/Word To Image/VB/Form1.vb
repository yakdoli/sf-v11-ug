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
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Diagnostics

Namespace Doc_To_Image
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Me.textBox1.Text = "DocToImage.docx"
            Me.textBox1.Tag = Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\DocToImage.docx"
        End Sub
#Region "Button_Click Event"
        Private Sub button1_Click_1(sender As System.Object, e As System.EventArgs) Handles button1.Click
            If Me.textBox1.Text <> [String].Empty Then
                ' Load the Document
                Dim wordDoc As New WordDocument(DirectCast(textBox1.Tag, String), Syncfusion.DocIO.FormatType.Automatic)
                ' Convert Word Document into image
                Dim image As Image() = wordDoc.RenderAsImages(ImageType.Metafile)
                Dim pageNumber As Int32 = 0
                'Save as Bitmap image
                If bmpRadioBtn.Checked Then
                    For i As Integer = 0 To image.Length - 1
                        image(i).Save("WordToImage_" & System.Threading.Interlocked.Increment(pageNumber) & ".bmp", ImageFormat.Bmp)
                    Next
                    'Message box confirmation to view the Converted Image.
                    If MessageBox.Show("Do you want to view the Image file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Try
                            System.Diagnostics.Process.Start("WordToImage_1.bmp")
                            'Exit
                            Me.Close()
                        Catch ex As Exception
                            Console.WriteLine(ex.ToString())
                        End Try
                    End If
                    'Save as PNG image
                ElseIf pngRadioBtn.Checked Then
                    For i As Integer = 0 To image.Length - 1
                        image(i).Save("WordToImage_" & System.Threading.Interlocked.Increment(pageNumber) & ".png", ImageFormat.Png)
                    Next
                    'Message box confirmation to view the Converted Image.
                    If MessageBox.Show("Do you want to view the Image file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Try
                            System.Diagnostics.Process.Start("WordToImage_1.png")
                            'Exit
                            Me.Close()
                        Catch ex As Exception
                            Console.WriteLine(ex.ToString())
                        End Try
                    End If
                    'Save as JPEG image
                ElseIf jpegRadioBtn.Checked Then
                    For i As Integer = 0 To image.Length - 1
                        image(i).Save("WordToImage_" & System.Threading.Interlocked.Increment(pageNumber) & ".jpeg", ImageFormat.Jpeg)
                    Next
                    'Message box confirmation to view the Converted Image.
                    If MessageBox.Show("Do you want to view the Image file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Try
                            System.Diagnostics.Process.Start("WordToImage_1.jpeg")
                            'Exit
                            Me.Close()
                        Catch ex As Exception
                            Console.WriteLine(ex.ToString())
                        End Try
                    End If
                    'Save as EMF image
                ElseIf emfRadioBtn.Checked Then
                    For i As Integer = 0 To image.Length - 1
                        Dim stream As MemoryStream = DirectCast(wordDoc.RenderAsImages(i, ImageFormat.Emf), MemoryStream)
                        Using fstream As New FileStream("WordToImage_" & System.Threading.Interlocked.Increment(pageNumber) & ".emf", FileMode.OpenOrCreate)
                            stream.WriteTo(fstream)
                        End Using
                    Next
                    'Message box confirmation to view the Converted Image.
                    If MessageBox.Show("Do you want to view the Image file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Try
                            System.Diagnostics.Process.Start("WordToImage_1.emf")
                            'Exit
                            Me.Close()
                        Catch ex As Exception
                            Console.WriteLine(ex.ToString())
                        End Try
                    End If
                End If
            Else
                MessageBox.Show("Browse a word document and click the button to convert as a Image.")
            End If
        End Sub
        Private Sub button3_Click_1(sender As System.Object, e As System.EventArgs) Handles button3.Click
            openFileDialog1.InitialDirectory = Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"
            openFileDialog1.FileName = ""
            Dim result As DialogResult = openFileDialog1.ShowDialog()

            If result = DialogResult.OK Then
                Me.textBox1.Text = openFileDialog1.SafeFileName
                Me.textBox1.Tag = openFileDialog1.FileName
            End If
        End Sub
#End Region
    End Class
End Namespace