Imports System.ComponentModel
Imports System.Text
Imports Syncfusion.XlsIO


Namespace EssentailXlsIOSample
    Partial Public Class LINQWrapper
        Inherits Form

#Region "Initialize"
        Public Sub New()
            InitializeComponent()
            Me.cmbName.SelectedIndex = 0
        End Sub
#End Region

#Region "Using LINQWrapper"
        Private Sub btnQueryData_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQueryData.Click

            'Workbook Initialize
            Dim excelEngine As New ExcelEngine()
            Dim application As IApplication = excelEngine.Excel
            Dim workbook As IWorkbook = application.Workbooks.Open("../../template.xls")
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            'Naming Ranges
            Dim name As IName = worksheet.Names.Add("FirstName")
            name.RefersToRange = worksheet("B5:B12")

            'Get data using LINQ query
            Dim result As String = String.Empty
            Dim foundDetails As String = String.Empty
            Dim range As IRange = worksheet("FirstName")
            'Option to get range by Name
            Dim matchingRanges = From s As IRange In range Where (s.Text = cmbName.SelectedItem.ToString()) Select s

            For Each range In matchingRanges
                result = range.Text & " Found at:" & range.Address & vbCrLf & "Cell Color:" & range.CellStyle.Color.ToString()
                foundDetails = range.Text
            Next range

            workbook.SaveAs("LINQWrapper.xls")
            workbook.Close()

            txtResult.Text = result & vbCrLf & "Sheet name is renamed as " & worksheet.Name

            'Use XlsIO to write the queried data
            workbook = application.Workbooks.Open("LINQWrapper.xls")

            workbook.Worksheets(0).Range("C17").Text = foundDetails & " is found"

            workbook.Save()
            workbook.Close()
            excelEngine.Dispose()

            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                Process.Start("LINQWrapper.xls")
                'Exit
                Me.Close()
            Else
                ' Exit
                Me.Close()
            End If
        End Sub
#End Region
    End Class
End Namespace
