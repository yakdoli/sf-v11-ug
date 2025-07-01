Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.IO
Imports System.Windows.Forms
Imports Syncfusion.XlsIO
Imports System.Data.OleDb
Imports System.Diagnostics

Namespace EssentialXlsIOSamples
    Partial Public Class StockReport
        Inherits Form
#Region "Constants"
        ''' <summary>
        ''' Specifies database connection string
        ''' </summary>
        Private conString As String
        ''' <summary>
        ''' Specifies number of the first row in data grid in first worksheet.
        ''' </summary>
        Private Const DEF_FST_ROW_NUM_FS As Integer = 38
        ''' <summary>
        ''' Specifies number of the first row in data grid in first worksheet.
        ''' </summary>
        Private Const DEF_FST_ROW_NUM_SC As Integer = 25
        ''' <summary>
        ''' Default path of the input file
        ''' </summary>
        Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\"
#End Region

#Region "Fields"
        ''' <summary>
        ''' DataSet.
        ''' </summary>
        Private ds As DataSet
        ''' <summary>
        ''' Specifies workbook.
        ''' </summary>
        Private myWorkbook As IWorkbook
        ''' <summary>
        ''' Image for ChartArea background.
        ''' </summary>
        Private userImage As String
        ''' <summary>
        ''' Data directory
        ''' </summary>
        Private dataDirectory As DirectoryInfo
        ''' <summary>
        ''' Report's directory.
        ''' </summary>
        Private reportDirectory As String
#End Region

#Region "Initialize"
        Public Sub New()
            InitializeComponent()
        End Sub
#End Region

#Region "Events"
#Region "CreateReport"
        Private Sub btnCreateReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreateReport.Click
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            Dim application As IApplication = excelEngine.Excel
            ' A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            ' The number of default worksheets is the application setting in MS Excel.
            myWorkbook = excelEngine.Excel.Workbooks.Add(dataDirectory.FullName & "Template.xls")

            ' Adding new worksheets in workbook's sheets collection
            For count As Integer = 1 To StockList.SelectedItems.Count - 1
                myWorkbook.Worksheets.AddCopyAfter(myWorkbook.Worksheets(1), myWorkbook.Worksheets(0))
            Next count

            ' Adding hyperlinks to menu sheet 
            Dim menu_sheet As IWorksheet = myWorkbook.Worksheets(0)
            Dim InsertIndex As Integer = DEF_FST_ROW_NUM_SC - 3

            menu_sheet.HyperLinks.RemoveAt(0)
            menu_sheet.Range("G21").Text = ""

            For count As Integer = 0 To StockList.SelectedItems.Count - 1
                menu_sheet.InsertRow(InsertIndex, 2, ExcelInsertOptions.FormatAsBefore)
                Dim report_hyperlink As IHyperLink = menu_sheet.HyperLinks.Add(menu_sheet.Range("G" & InsertIndex & ":I" & InsertIndex))
                report_hyperlink.Type = ExcelHyperLinkType.Workbook
                report_hyperlink.Address = StockList.SelectedItems(count).ToString() & "!A1"
                report_hyperlink.TextToDisplay = StockList.SelectedItems(count).ToString()

                InsertIndex += 2
            Next count

            ' Creating Stock report
            Dim itemIndex As Integer = 1

            For Each StockListItem As Object In StockList.SelectedItems
                CreateStockReport(StockListItem.ToString(), itemIndex)
                FillAnalysisPortfolioSheet(StockListItem.ToString())
                itemIndex += 1
            Next StockListItem
            myWorkbook.Worksheets(0).Activate()
            ' Saving the workbook to disk.
            myWorkbook.SaveAs(reportDirectory & "\StockPortfolioOutput.xls")
            ' No exception will be thrown if there are unsaved workbooks. No use here since we are
            ' saving the workbook.
            excelEngine.ThrowNotSavedOnDestroy = False
            excelEngine.Dispose()
            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start(reportDirectory & "\StockPortfolioOutput.xls")
                'Exit
                Me.Close()
            Else
                ' Exit
                Me.Close()
            End If
        End Sub
#End Region

#Region "Form Load"
        Private Sub StockReport_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create the DataSet
            ds = New DataSet()

            StockList.SelectedIndex = 0
            dataDirectory = New DirectoryInfo(DEFAULTPATH)

            reportDirectory = Application.StartupPath
            conString = "Provider=Microsoft.JET.OLEDB.4.0;" & "data source=" & dataDirectory.FullName & "DataBase.mdb"

            ' Create an open the connection
            Dim conn As OleDbConnection = New OleDbConnection(conString)
            conn.Open()

            ' Create the adapter and fill the DataSet
            Dim command As OleDbCommand = New OleDbCommand("SELECT Min(Date) as MinDate, Max(Date) as MaxDate FROM StockData", conn)

            Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(command)
            adapter.Fill(ds)

            'Set the min and max date for Start and end date time picker
            Dim minDate As DateTime = DateTime.Parse(ds.Tables(0).Rows(0)("MinDate").ToString().Trim())
            Dim maxDate As DateTime = DateTime.Parse(ds.Tables(0).Rows(0)("MaxDate").ToString().Trim())

            StartDateTimePicker.MinDate = minDate
            StartDateTimePicker.MaxDate = maxDate

            EndDateTimePicker.MinDate = minDate
            EndDateTimePicker.MaxDate = maxDate

            ' Close the connection
            conn.Close()
        End Sub
#End Region

#Region "Browse Image"
        Private Sub bacgrimage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bacgrimage.Click
            ImageChDialog.Title = "Insert Image"

            If ImageChDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                userImage = ImageChDialog.FileName
            End If
        End Sub
#End Region

#Region "Browse Report Directory"
        Private Sub reportdir_Click(ByVal sender As Object, ByVal e As EventArgs) Handles reportdir.Click
            If FolderBrowserDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                reportDirectory = FolderBrowserDialog.SelectedPath
            End If
        End Sub
#End Region
#End Region

#Region "View the Input Template"
        Private Sub viewInputTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewInputTemplate.Click
            'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(dataDirectory.FullName & "Template.xls")
        End Sub
#End Region

#Region "Helper Methods"

#Region "FillAnalysisPortfolioSheet"
        Private Sub FillAnalysisPortfolioSheet(ByVal StockSymbol As String)
            ' Fill Portfolio Analysis sheet
            Dim AnalysisPortfolioSheetNum As Integer = myWorkbook.Worksheets.Count - 1

            Dim portf_analysis_sheet As IWorksheet = myWorkbook.Worksheets(AnalysisPortfolioSheetNum)

            Dim conn As OleDbConnection = New OleDbConnection(conString)
            conn.Open()

            ' Fill StockStyle
            ds.Tables.Clear()

            ' Create the adapter and fill the DataSet
            Dim command As OleDbCommand = New OleDbCommand("select * from StockStyles", conn)

            Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(command)
            adapter.Fill(ds)

            For count As Integer = 0 To ds.Tables(0).Rows.Count - 1
                portf_analysis_sheet.Range("D" & (DEF_FST_ROW_NUM_SC + count)).Value = ds.Tables(0).Rows(count)("StockStyle").ToString()
            Next count

            ' Fill StockTypes
            ds.Tables.Clear()

            command = New OleDbCommand("select * from StockTypes", conn)

            adapter = New OleDbDataAdapter(command)
            adapter.Fill(ds)

            For count As Integer = 0 To ds.Tables(0).Rows.Count - 1
                portf_analysis_sheet.Range("I" & (DEF_FST_ROW_NUM_SC + count)).Value = ds.Tables(0).Rows(count)("StockType").ToString()
            Next count

            ' Clear all tables in dataset
            ds.Tables.Clear()

            command = New OleDbCommand("select * from StockInfo where StockName = '" & StockSymbol & "'", conn)

            adapter = New OleDbDataAdapter(command)
            adapter.Fill(ds)

            Dim cell_num As Integer = DEF_FST_ROW_NUM_SC + Int32.Parse(ds.Tables(0).Rows(0)("StockStyle").ToString()) - 1

            Dim cell_value As Integer = 0

            If portf_analysis_sheet.Range("E" & cell_num.ToString()).Value.Length > 0 Then
                cell_value = Int32.Parse(portf_analysis_sheet.Range("E" & cell_num.ToString()).Value)
            End If

            cell_value += 1
            portf_analysis_sheet.Range("E" & cell_num.ToString()).Value2 = cell_value

            cell_num = DEF_FST_ROW_NUM_SC + Int32.Parse(ds.Tables(0).Rows(0)("StockType").ToString()) - 1

            cell_value = 0

            If portf_analysis_sheet.Range("E" & cell_num.ToString()).Value.Length > 0 Then
                cell_value = Int32.Parse(portf_analysis_sheet.Range("E" & cell_num.ToString()).Value)
            End If

            cell_value += 1

            portf_analysis_sheet.Range("J" & cell_num.ToString()).Value2 = cell_value

            ' Close the connection
            conn.Close()
        End Sub
#End Region

#Region "CreateStockReport"
        Private Sub CreateStockReport(ByVal StockSymbol As String, ByVal itemIndex As Integer)
            ' Clear all tables in dataset
            ds.Tables.Clear()

            ' Create an open the connection
            Dim conn As OleDbConnection = New OleDbConnection(conString)
            conn.Open()

            ' Create the adapter and fill the DataSet
            Dim command As OleDbCommand = New OleDbCommand("select Date, Volume, OpenPrice, HighPrice, LowPrice, ClosePrice from StockData where symbol = '" & StockSymbol & "' and Date between @FromDate and @ToDate order by Date", conn)

            command.Parameters.Add("@FromDate", OleDbType.Date).Value = StartDateTimePicker.Value
            command.Parameters.Add("@ToDate", OleDbType.Date).Value = EndDateTimePicker.Value

            Dim adapter As OleDbDataAdapter = New OleDbDataAdapter(command)
            adapter.Fill(ds)
            ' Close the connection
            conn.Close()

            Dim table As DataTable = ds.Tables(0)

            If table.Rows.Count > 0 Then
                If itemIndex > 1 Then
                    FillReport(itemIndex, table, StockSymbol, False)
                Else
                    FillReport(1, table, StockSymbol, False)
                End If
            End If
        End Sub
#End Region

#Region "FillReport"
        Private Sub FillReport(ByVal report As Integer, ByVal table As DataTable, ByVal StockSymbol As String, ByVal hasLegend As Boolean)
            Dim reportSheet As IWorksheet = myWorkbook.Worksheets(report)

            reportSheet.Name = StockSymbol

            If table.Rows.Count > 1 Then
                reportSheet.InsertRow(DEF_FST_ROW_NUM_FS + 1, table.Rows.Count - 1, ExcelInsertOptions.FormatAsBefore)
            End If
            ' Inserting data into the spreadsheet.
            reportSheet.ImportDataTable(table, True, (DEF_FST_ROW_NUM_FS - 1), 3)

            Dim rownum As Integer = DEF_FST_ROW_NUM_FS - 1

            reportSheet.Range("I3").Text = StockSymbol
            reportSheet.Range("C" & rownum.ToString()).Text = "Date"
            reportSheet.Range("D" & rownum.ToString()).Text = "Volume"
            reportSheet.Range("E" & rownum.ToString()).Text = "Open Price"
            reportSheet.Range("F" & rownum.ToString()).Text = "High Price"
            reportSheet.Range("G" & rownum.ToString()).Text = "Low Price"
            reportSheet.Range("H" & rownum.ToString()).Text = "Close Price"

            For count As Integer = 0 To table.Rows.Count - 1
                Dim cellNum As String = (count + DEF_FST_ROW_NUM_FS).ToString()
                reportSheet.Range("I" & cellNum).Formula = "$H" & cellNum & "-$E" & cellNum
            Next count

            Dim charts As IChartShapes = reportSheet.Charts
            For Each chart As IChartShape In charts
                chart.DataRange = reportSheet.Range("C" & DEF_FST_ROW_NUM_FS & ":H" & (table.Rows.Count + (DEF_FST_ROW_NUM_FS - 1)))
                chart.ChartType = ExcelChartType.Stock_VolumeOpenHighLowClose

                chart.ChartArea.IsBorderCornersRound = isCornersRound.Checked

                If userImage IsNot Nothing AndAlso userImage.Length > 0 Then
                    chart.ChartArea.Fill.UserPicture(userImage)
                End If

                chart.Series(0).SerieFormat.LineProperties.LinePattern = ExcelChartLinePattern.Solid
                chart.Series(0).SerieFormat.LineProperties.LineWeight = ExcelChartLineWeight.Narrow
                chart.Series(0).SerieFormat.LineProperties.LineColor = Color.Blue

                chart.Series(1).SerieFormat.LineProperties.LinePattern = ExcelChartLinePattern.Solid
                chart.Series(1).SerieFormat.LineProperties.LineWeight = ExcelChartLineWeight.Narrow
                chart.Series(1).SerieFormat.LineProperties.LineColor = Color.Blue

                chart.HasLegend = hasLegend
            Next chart
        End Sub
#End Region

#End Region

    End Class
End Namespace