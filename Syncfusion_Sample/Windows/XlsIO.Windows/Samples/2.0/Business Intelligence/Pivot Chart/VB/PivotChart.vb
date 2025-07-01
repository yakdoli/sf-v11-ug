Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.XlsIO

Public Class PivotChart

#Region "Constants"
    Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Adding Pivot Chart"
    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click


        'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
        'The instantiation process consists of two steps.

        'Step 1 : Instantiate the spreadsheet creation engine.
        Dim excelEngine As New ExcelEngine()
        'Step 2 : Instantiate the excel application object.
        Dim application As IApplication = excelEngine.Excel

        'Set the default version as Excel 2007;

        If Me.rdbExcel2007.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2007
        End If

        'Set the default version as Excel 2010;
        If Me.rdbExcel2010.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2010
        End If
        'Set the default version as Excel 2013
        If Me.rdbExcel2010.Checked Then
            application.DefaultVersion = ExcelVersion.Excel2013
        End If

        'Get the Path of the input file
        Dim inputPath As String = GetFullTemplatePath("PivotCodeDate.xlsx")
        Dim workbook As IWorkbook = application.Workbooks.Open(inputPath)

        ' The first worksheet object in the worksheets collection is accessed.
        Dim worksheet As IWorksheet = workbook.Worksheets(0)
        'Access the sheet to draw pivot table.
        Dim pivotSheet As IWorksheet = workbook.Worksheets(1)
        'Select the data to add in cache
        Dim cache As IPivotCache = workbook.PivotCaches.Add(worksheet("A1:H50"))

        'Insert the pivot table.
        Dim pivotTable As IPivotTable = pivotSheet.PivotTables.Add("PivotTable1", pivotSheet("A1"), cache)
        pivotTable.Fields(2).Axis = PivotAxisTypes.Row
        pivotTable.Fields(4).Axis = PivotAxisTypes.Row
        pivotTable.Fields(3).Axis = PivotAxisTypes.Column

        Dim field As IPivotField = pivotSheet.PivotTables(0).Fields(5)
        pivotTable.DataFields.Add(field, "Sum of Units", PivotSubtotalTypes.Sum)

        'Show expand/collapse button.
        pivotTable.ShowDrillIndicators = True

        'Shows row grand.
        pivotTable.RowGrand = True
        'Shows filter and field caption.
        pivotTable.DisplayFieldCaptions = True

        'Apply built in style.
        pivotTable.BuiltInStyle = PivotBuiltInStyles.PivotStyleMedium2

        'Add the Pivot chart sheet to the workbook.
        Dim pivotChartSheet As IChart = workbook.Charts.Add()
        pivotChartSheet.Name = "PivotChart"

        'Set the Pivot source for the Pivot Chart.
        pivotChartSheet.PivotSource = pivotTable

        'Set the Pivot Chart Type.
        pivotChartSheet.PivotChartType = ExcelChartType.Column_Clustered

        'Activate the pivot sheet.
        pivotChartSheet.Activate()

        'Saving the workbook to disk.
        workbook.SaveAs("PivotChart.xlsx")

        'Close the workbook.
        workbook.Close()

        'No exception will be thrown if there are unsaved workbooks.
        excelEngine.ThrowNotSavedOnDestroy = False
        excelEngine.Dispose()

        'Message box confirmation to view the created spreadsheet.
        If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
            Try
                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("PivotChart.xlsx")
                'Exit
                Me.Close()
            Catch ex As Win32Exception
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
        Return String.Format(DEFAULTPATH, inputFile)
    End Function
#End Region

    Private Sub PivotChart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdbExcel2013.Checked = True
    End Sub
End Class
