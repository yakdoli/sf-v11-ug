Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.XlsIO

Namespace EssentailXlsIOSample
    Partial Public Class OleObject
        Inherits Form

#Region "Constants"
        Private Const DEFAULTFILEPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
        Private Const DEFAULTIMAGEPATH As String = "..\..\..\..\..\..\..\..\..\Common\Images\XlsIO\{0}"
#End Region

#Region "Initialize"
        Public Sub New()
            InitializeComponent()
            Me.btnExcel2013.Checked = True
        End Sub
#End Region

#Region "Using OleObject"
        Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreate.Click
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            If Me.btnExcel2007.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2007
            ElseIf Me.btnExcel2010.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2010
            Else
                application.DefaultVersion = ExcelVersion.Excel2013
            End If

            'A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            'The new workbook will have 3 worksheets
            Dim workbook As IWorkbook = application.Workbooks.Create(3)
            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)


            'Get the Path of the Header Image
            Dim headerImagePath As String = GetFullImagePath("header.gif")
            'Get the Path of the PDF file
            Dim pdfFilePath As String = GetFullTemplatePath("FaxOrderForm.pdf")
            'Get the path of the PDF Icon
            Dim pdfIconPath As String = GetFullImagePath("pdfIcon.jpg")
            'Get the Path of Work file
            Dim wordFilePath As String = GetFullTemplatePath("FaxOrderForm.doc")
            'Get the Path of Work Icon
            Dim wordIconPath As String = GetFullImagePath("wordIcon.jpg")

            worksheet.IsGridLinesVisible = False
            worksheet.Pictures.AddPicture(2, 5, headerImagePath)

            worksheet("E5:M6").Merge()
            worksheet(5, 5).Text = "Syncfusion accept fax orders from customers worldwide. You can also order online through our secure web server."
            worksheet(5, 5).WrapText = True

            worksheet(8, 6).Text = "PDF Order Form"
            'Add Oleobject for PDF file
            Dim oleObject1 As IOleObject = worksheet.OleObjects.Add(pdfFilePath, System.Drawing.Image.FromFile(pdfIconPath), OleLinkType.Embed)
            oleObject1.Location = worksheet(8, 11)
            oleObject1.Size = New Size(100, 100)

            worksheet(17, 6).Text = "Word Order Form"
            'Add OleObject for Word file
            Dim oleObject2 As IOleObject = worksheet.OleObjects.Add(wordFilePath, System.Drawing.Image.FromFile(wordIconPath), OleLinkType.Embed)
            oleObject2.Location = worksheet(17, 11)
            oleObject2.Size = New Size(100, 100)

            worksheet(25, 5).Text = "Download the order form, print it out and fill in the required information."

            If Me.btnExcel2007.Checked Then
                workbook.SaveAs("OleObectSample.xlsx")
            ElseIf Me.btnExcel2010.Checked Then
                workbook.SaveAs("OleObectSample.xlsx")
            Else
                workbook.SaveAs("OleObectSample.xlsx")
            End If
            workbook.Close()
            excelEngine.Dispose()

            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                Try
                    'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start("OleObectSample.xlsx")
                    'Exit
                    Me.Close()
                Catch e1 As Win32Exception
                    MessageBox.Show("MS Excel is not installed in this system")
                End Try
            Else
                ' Exit
                Me.Close()
            End If
        End Sub
#End Region

#Region "HelperMethod"
        ''' <summary>
        ''' Return the file path of the Input file
        ''' </summary>
        Private Function GetFullTemplatePath(ByVal inputFile As String) As String
            Return String.Format(DEFAULTFILEPATH, inputFile)
        End Function

        ''' <summary>
        ''' Return the file path of the Input Image file
        ''' </summary>
        Private Function GetFullImagePath(ByVal inputFile As String) As String
            Return String.Format(DEFAULTIMAGEPATH, inputFile)
        End Function
#End Region

    End Class
End Namespace