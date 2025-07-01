Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics

Imports Syncfusion.XPS
Imports Syncfusion.Pdf

Namespace XPStoPDF_2005
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub btnXPS2PDF_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnXPS2PDF.Click
            If CStr(Me.textBox1.Tag) <> String.Empty Then
                ' Initialize XPS converter.
                Dim converter As New XPSToPdfConverter()

                ' Convert XPS document into PDF document.
                Dim document As PdfDocument = converter.Convert(CStr(textBox1.Tag))

                ' Save & close the pdf file.
                document.Save("Sample.pdf")
                document.Close(True)

                'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the PDF file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                    Try
                        System.Diagnostics.Process.Start("Sample.pdf")
                        'Exit
                        Me.Close()
                    Catch ex As Exception
                        Console.WriteLine(ex.ToString())
                    End Try
                Else
                    Me.Close()
                End If
            Else
                MessageBox.Show("Browse a XPS document and click the button to convert as a PDF.")
            End If
        End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.textBox1.Text = "XPStoPDF.xps"
			Me.textBox1.Tag = Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\Common\Data\PDF\XPStoPDF.xps"
		End Sub

        Private Sub browseBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles browseBtn.Click
            openFileDialog1.InitialDirectory = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\Common\Data\PDF\"
            openFileDialog1.FileName = ""
            openFileDialog1.Filter = "Xps files (*.XPS)|*.xps"
            Dim result As DialogResult = openFileDialog1.ShowDialog()

            If result = DialogResult.OK Then
                Me.textBox1.Text = openFileDialog1.SafeFileName
                Me.textBox1.Tag = openFileDialog1.FileName
            End If

        End Sub
    End Class
End Namespace