Imports Microsoft.VisualBasic
#Region "Copyright Syncfusion Inc. 2001 - 2009"
'
'  Copyright Syncfusion Inc. 2001 - 2009. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.XlsIO
Imports System.Diagnostics
Imports Syncfusion.XlsIO.Implementation

Namespace EssentialXlsIOSamples
    Partial Public Class WorksheetToHTML
        Inherits Form

#Region "Constants"
        Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Initialize"
        Public Sub New()
            InitializeComponent()
        End Sub
#End Region

#Region "Convert Worksheet or Workbook to HTML"

        Private Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConvert.Click

            Dim fileName As String
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            'Get the path of the Input File 
            Dim inputPath As String = GetFullTemplatePath("NorthwindTemplate.xls")

            ' Existing workbook is opened
            Dim workbook As IWorkbook = application.Workbooks.Open(inputPath)

            ' The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            If (rdbWksheet.Checked) Then

                ' Save the Worksheet as HTML
                fileName = "WorksheetToHTML.html"
                worksheet.SaveAsHtml(fileName)

            Else
                'Save the Workbook as HTML
                fileName = "WorkbookToHTML.html"
                workbook.SaveAsHtml(fileName, HtmlSaveOptions.Default)
            End If

            ' Save and close the workbook and excelEngine
            workbook.Close()
            excelEngine.Dispose()

            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Do you want to view the HTML?", "Conversion successful", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start(fileName)
                'Exit
                Me.Close()
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
            Return String.Format(DEFAULTPATH, inputFile)
        End Function
#End Region

#Region "View the Input Template"
        Private Sub viewInputTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewInputTemplate.Click
            'Get the path of the Input File
            Dim inputPath As String = GetFullTemplatePath("NorthwindTemplate.xls")
            'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath)
        End Sub
#End Region
    End Class
End Namespace