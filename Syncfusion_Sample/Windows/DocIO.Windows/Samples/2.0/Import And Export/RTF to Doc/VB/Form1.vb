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
Imports System.ComponentModel
Imports System.Text
Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS

Namespace RTFToDoc
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			openFileDialog1.InitialDirectory = Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"
			openFileDialog1.FileName = ""
			Dim result As DialogResult = openFileDialog1.ShowDialog()

			If result = DialogResult.OK Then
				Me.textBox1.Text = openFileDialog1.SafeFileName
				Me.textBox1.Tag = openFileDialog1.FileName

			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.textBox1.Text = "RTFToDoc.rtf"
			Me.textBox1.Tag = Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\RTFToDoc.rtf"

		End Sub

		Private Sub btnRTFToDoc_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRTFToDoc.Click
			Dim document As New WordDocument()
            document.Open(CStr(Me.textBox1.Tag), FormatType.Rtf)

            'Saving the document to disk.
            document.Save("Sample.doc")

            'Message box confirmation to view the created document.
            If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                System.Diagnostics.Process.Start("Sample.doc")
                'Exit
                Me.Close()
            Else
                ' Exit
                Me.Close()
            End If

		End Sub

	End Class
End Namespace
