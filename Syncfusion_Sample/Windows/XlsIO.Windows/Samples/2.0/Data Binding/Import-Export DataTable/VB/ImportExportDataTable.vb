#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region


Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports Syncfusion.XlsIO

Namespace EssentialXlsIOSamples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
    Public Class ImportExportDataTable : Inherits System.Windows.Forms.Form

#Region "Constants"
        Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Fields"
        Private dataGrid1 As System.Windows.Forms.DataGrid
        Private WithEvents btnExport As System.Windows.Forms.Button
        Private WithEvents btnImport As System.Windows.Forms.Button
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbExcel2010 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExcel2007 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExcel97 As System.Windows.Forms.RadioButton
        Private fileName As String
        Friend WithEvents rdbExcel2013 As System.Windows.Forms.RadioButton

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Initialize"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            Me.rdbExcel2013.Checked = True
            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub
#End Region

#Region "Import Data From Excel to DataGrid"
        Private Sub btnImport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImport.Click
            'Imports Data from the Template spreadsheet into the Grid.

            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            'Get Path of the Input File
            Dim inputPath As String = GetTemplatePath("NorthwindDataTemplate.xls")
			
            'Open an existing spreadsheet which will be used as a template for generating the new spreadsheet.
            'After opening, the workbook object represents the complete in-memory object model of the template spreadsheet.
            Dim workbook As IWorkbook = application.Workbooks.Open(inputPath)
            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            'Read data from spreadsheet.
            Dim customersTable As DataTable = worksheet.ExportDataTable(worksheet.UsedRange, ExcelExportDataTableOptions.ColumnNames)
            Me.dataGrid1.DataSource = customersTable

            btnExport.Enabled = True

            'Close the workbook.
            workbook.Close()

            'No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = False
            excelEngine.Dispose()

        End Sub
#End Region

#Region "Export Data From DataGrid to Excel"
        Private Sub btnExport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExport.Click
            'Exports the DataTable to a spreadsheet.

            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()

            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            'Set the Workbook version as Excel 97to2003
            If Me.rdbExcel97.Checked Then
                application.DefaultVersion = ExcelVersion.Excel97to2003
                fileName = "ExportToExcel.xls"
                'Set the Workbook version as Excel 2007
            ElseIf Me.rdbExcel2007.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2007
                fileName = "ExportToExcel.xlsx"
                'Set the Workbook version as Excel 2010
            ElseIf Me.rdbExcel2010.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2010
                fileName = "ExportToExcel.xlsx"
                'Set the Workbook version as Excel 2013
            ElseIf Me.rdbExcel2013.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2013
                fileName = "ExportToExcel.xlsx"
            End If
            'A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            'The new workbook will have 3 worksheets
            Dim workbook As IWorkbook = application.Workbooks.Create(1)

            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)


            'Export DataTable.
            If Not Me.dataGrid1.DataSource Is Nothing Then
                worksheet.ImportDataTable(CType(Me.dataGrid1.DataSource, DataTable), True, 3, 1, -1, -1)
            Else
                MessageBox.Show("There is no datatable to export, Please import a datatable first", "Error")

                'Close the workbook.
                workbook.Close()
                Return
            End If

            'Formatting the Report

            'Body Style
            Dim bodyStyle As IStyle = workbook.Styles.Add("BodyStyle")
            bodyStyle.BeginUpdate()

            'Add custom colors to the palette.
            workbook.SetPaletteColor(9, Color.FromArgb(239, 242, 247))
            bodyStyle.Color = Color.FromArgb(239, 243, 247)
            bodyStyle.Borders(ExcelBordersIndex.EdgeLeft).LineStyle = ExcelLineStyle.Thin
            bodyStyle.Borders(ExcelBordersIndex.EdgeRight).LineStyle = ExcelLineStyle.Thin

            'Apply Style
            worksheet.UsedRange.CellStyleName = "BodyStyle"
            bodyStyle.EndUpdate()


            'Header Style
            Dim headerStyle As IStyle = workbook.Styles.Add("HeaderStyle")
            headerStyle.BeginUpdate()

            'Add custom colors to the palette.
            workbook.SetPaletteColor(8, Color.FromArgb(182, 189, 218))
            headerStyle.Color = Color.FromArgb(182, 189, 218)
            headerStyle.Font.Bold = True
            headerStyle.Borders(ExcelBordersIndex.EdgeLeft).LineStyle = ExcelLineStyle.Thin
            headerStyle.Borders(ExcelBordersIndex.EdgeRight).LineStyle = ExcelLineStyle.Thin
            headerStyle.Borders(ExcelBordersIndex.EdgeTop).LineStyle = ExcelLineStyle.Thin
            headerStyle.Borders(ExcelBordersIndex.EdgeBottom).LineStyle = ExcelLineStyle.Thin

            'Apply Style
            worksheet.Range("A1:K3").CellStyleName = "HeaderStyle"
            headerStyle.EndUpdate()

            'Remove grid lines in the worksheet.
            worksheet.IsGridLinesVisible = False

            'Autofit Rows and Columns
            worksheet.UsedRange.AutofitRows()
            worksheet.UsedRange.AutofitColumns()

            'Adjust Row Height.
            worksheet.Rows(1).RowHeight = 25

            'Freeze header row.
            worksheet.Range("A4").FreezePanes()

            worksheet.Range("C2").Text = "Customer Details"
            worksheet.Range("C2:D2").Merge()
            worksheet.Range("C2").CellStyle.Font.Size = 14
            worksheet.Range("C2").CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter

            'Saving the workbook to disk.
            workbook.SaveAs(fileName)

            'No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = False
            excelEngine.Dispose()

            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
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
        Private Function GetTemplatePath(ByVal inputFile As String) As String
            Return String.Format(DEFAULTPATH, inputFile)
        End Function
#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ImportExportDataTable))
            Me.btnImport = New System.Windows.Forms.Button
            Me.btnExport = New System.Windows.Forms.Button
            Me.dataGrid1 = New System.Windows.Forms.DataGrid
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.rdbExcel2010 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2007 = New System.Windows.Forms.RadioButton
            Me.rdbExcel97 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2013 = New System.Windows.Forms.RadioButton
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnImport
            '
            Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnImport.BackColor = System.Drawing.Color.Transparent
            Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
            Me.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnImport.Location = New System.Drawing.Point(42, 447)
            Me.btnImport.Name = "btnImport"
            Me.btnImport.Size = New System.Drawing.Size(80, 23)
            Me.btnImport.TabIndex = 0
            Me.btnImport.Text = "Import"
            Me.btnImport.UseVisualStyleBackColor = False
            '
            'btnExport
            '
            Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnExport.BackColor = System.Drawing.Color.Transparent
            Me.btnExport.Enabled = False
            Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
            Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnExport.Location = New System.Drawing.Point(216, 447)
            Me.btnExport.Name = "btnExport"
            Me.btnExport.Size = New System.Drawing.Size(80, 23)
            Me.btnExport.TabIndex = 2
            Me.btnExport.Text = "Export"
            Me.btnExport.UseVisualStyleBackColor = False
            '
            'dataGrid1
            '
            Me.dataGrid1.DataMember = ""
            Me.dataGrid1.HeaderBackColor = System.Drawing.SystemColors.ControlDark
            Me.dataGrid1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dataGrid1.Location = New System.Drawing.Point(31, 112)
            Me.dataGrid1.Name = "dataGrid1"
            Me.dataGrid1.PreferredRowHeight = 19
            Me.dataGrid1.RowHeadersVisible = False
            Me.dataGrid1.SelectionBackColor = System.Drawing.SystemColors.ButtonFace
            Me.dataGrid1.Size = New System.Drawing.Size(312, 292)
            Me.dataGrid1.TabIndex = 3
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(372, 96)
            Me.pictureBox1.TabIndex = 63
            Me.pictureBox1.TabStop = False
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rdbExcel2013)
            Me.GroupBox1.Controls.Add(Me.rdbExcel2010)
            Me.GroupBox1.Controls.Add(Me.rdbExcel2007)
            Me.GroupBox1.Controls.Add(Me.rdbExcel97)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(30, 406)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(330, 35)
            Me.GroupBox1.TabIndex = 64
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Export As"
            '
            'rdbExcel2010
            '
            Me.rdbExcel2010.AutoSize = True
            Me.rdbExcel2010.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbExcel2010.Location = New System.Drawing.Point(164, 13)
            Me.rdbExcel2010.Name = "rdbExcel2010"
            Me.rdbExcel2010.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2010.TabIndex = 2
            Me.rdbExcel2010.Text = "Excel 2010"
            Me.rdbExcel2010.UseVisualStyleBackColor = True
            '
            'rdbExcel2007
            '
            Me.rdbExcel2007.AutoSize = True
            Me.rdbExcel2007.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbExcel2007.Location = New System.Drawing.Point(85, 13)
            Me.rdbExcel2007.Name = "rdbExcel2007"
            Me.rdbExcel2007.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2007.TabIndex = 1
            Me.rdbExcel2007.Text = "Excel 2007"
            Me.rdbExcel2007.UseVisualStyleBackColor = True
            '
            'rdbExcel97
            '
            Me.rdbExcel97.AutoSize = True
            Me.rdbExcel97.Checked = True
            Me.rdbExcel97.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbExcel97.Location = New System.Drawing.Point(6, 13)
            Me.rdbExcel97.Name = "rdbExcel97"
            Me.rdbExcel97.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel97.TabIndex = 0
            Me.rdbExcel97.TabStop = True
            Me.rdbExcel97.Text = "Excel 2003"
            Me.rdbExcel97.UseVisualStyleBackColor = True
            '
            'rdbExcel2013
            '
            Me.rdbExcel2013.AutoSize = True
            Me.rdbExcel2013.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbExcel2013.Location = New System.Drawing.Point(246, 13)
            Me.rdbExcel2013.Name = "rdbExcel2013"
            Me.rdbExcel2013.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2013.TabIndex = 3
            Me.rdbExcel2013.Text = "Excel 2013"
            Me.rdbExcel2013.UseVisualStyleBackColor = True
            '
            'ImportExportDataTable
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(372, 482)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.dataGrid1)
            Me.Controls.Add(Me.btnExport)
            Me.Controls.Add(Me.btnImport)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "ImportExportDataTable"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Import-Export Data Table"
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Dispose"
        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub



        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New ImportExportDataTable())
        End Sub
#End Region

    End Class
End Namespace
