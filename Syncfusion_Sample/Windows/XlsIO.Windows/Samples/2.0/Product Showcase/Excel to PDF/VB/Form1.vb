Imports System.ComponentModel
Imports System.Text
Imports Syncfusion.XlsIO
Imports Syncfusion.ExcelToPdfConverter
Imports Syncfusion.Pdf

Namespace ExceltoPDF
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub browseExcelFileBtnClick(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
			openFileDialog1.InitialDirectory = Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\"
			openFileDialog1.FileName = ""
			Dim result As DialogResult = openFileDialog1.ShowDialog()
			If result = DialogResult.OK Then
				Me.textBox1.Text = openFileDialog1.SafeFileName
				Me.textBox1.Tag = openFileDialog1.FileName
			End If
		End Sub
		Private Sub excelToPdfConvertBtnClick(ByVal sender As Object, ByVal e As EventArgs) Handles excelToPdfConvertbtn.Click
			If Me.textBox1.Text <> String.Empty Then
			
				'Open the Excel Document to Convert
				Dim converter As New ExcelToPdfConverter(CStr(textBox1.Tag))
				
				'Intialize the PDFDocument
				Dim pdfDoc As New PdfDocument()

				'Intialize the ExcelToPdfconverterSettings
				Dim settings As New ExcelToPdfConverterSettings()

                'Set the Layout Options for the output Pdf page.
                If noScaleRadioBtn.Checked Then
                    settings.LayoutOptions = LayoutOptions.NoScaling
                ElseIf allRowsRadioBtn.Checked Then
                    settings.LayoutOptions = LayoutOptions.FitAllRowsOnOnePage
                ElseIf allColumnRadioBtn.Checked Then
                    settings.LayoutOptions = LayoutOptions.FitAllColumnsOnOnePage
                Else
                    settings.LayoutOptions = LayoutOptions.FitSheetOnOnePage
                End If
				
				'Assign the PDFDocument to the TemplateDocument property of ExcelToPdfConverterSettings
				settings.TemplateDocument = pdfDoc
				settings.DisplayGridLines = GridLinesDisplayStyle.Invisible
				'Convert Excel document into PDF document
				pdfDoc = converter.Convert(settings)
				
				'Save the PDF file
				pdfDoc.Save("ExceltoPDF.pdf")
				
				'Message box confirmation to view the created document.
				If MessageBox.Show("Do you want to view the PDF file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
					Try
						Process.Start("ExceltoPDF.pdf")
						'Exit
						Me.Close()
					Catch ex As Exception
						Console.WriteLine(ex.ToString())
					End Try
				End If
			Else
				MessageBox.Show("Browse a word document and click the button to convert as a PDF.")
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.textBox1.Text = "ExceltoPDF.xlsx"
			Me.textBox1.Tag = Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\ExcelToPDF.xlsx"
		End Sub
	End Class
End Namespace