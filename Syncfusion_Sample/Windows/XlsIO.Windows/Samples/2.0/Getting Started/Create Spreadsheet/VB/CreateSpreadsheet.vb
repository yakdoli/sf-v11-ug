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
    Public Class CreateSpreadsheet : Inherits System.Windows.Forms.Form

#Region "Constants"
        Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Fields"
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents btnCreate As System.Windows.Forms.Button
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents rdbXml As System.Windows.Forms.RadioButton
        Private WithEvents rdbCsv As System.Windows.Forms.RadioButton
        Private WithEvents rdbExcel2007 As System.Windows.Forms.RadioButton
        Private WithEvents rdbExcel97 As System.Windows.Forms.RadioButton
        Private WithEvents rdbXltx As System.Windows.Forms.RadioButton
        Private WithEvents rdbXltm As System.Windows.Forms.RadioButton
        Friend WithEvents rdb2010 As System.Windows.Forms.RadioButton
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
        Dim fileName As String = ""
        Friend WithEvents rdb2013 As System.Windows.Forms.RadioButton
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
            Me.rdb2013.Checked = True
            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub
#End Region

#Region "CreateSpreadsheet"
        Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

            '#Region "Workbook Create"
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            'A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            'The new workbook will have 5 worksheets
            Dim workbook As IWorkbook

            Dim inputPath As String = GetFullTemplatePath("MacroTemplate.xltm")

            If (rdbXltm.Checked) Then
                workbook = application.Workbooks.Open(inputPath, ExcelOpenType.Automatic)
            Else
                workbook = application.Workbooks.Create(1)
            End If
            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)
            '#End Region

            If (rdbXltm.Checked) Then
                worksheet.IsGridLinesVisible = False
                worksheet(1, 1).Text = "Essential XlsIO supports opening of XLTM (Excel 2007 Macro Enabled Template) file and save it in either XLTM or XLSM formats."
                worksheet(3, 1).Text = "You can run the macro by triggering the click event of the button placed in this worksheet."
            ElseIf (rdbCsv.Checked) Then
                'Inserting sample text into the first cell of the first worksheet.
                worksheet.Range("A1:N30").Text = "Hello World"
            Else
                worksheet.Range("A2").ColumnWidth = 30
                worksheet.Range("B2").ColumnWidth = 30
                worksheet.Range("C2").ColumnWidth = 30
                worksheet.Range("D2").ColumnWidth = 30

                worksheet.Range("A2:D2").Merge(True)

                'Inserting sample text into the first cell of the first worksheet.
                worksheet.Range("A2").Text = "EXPENSE REPORT"
                worksheet.Range("A2").CellStyle.Font.FontName = "Verdana"
                worksheet.Range("A2").CellStyle.Font.Bold = True
                worksheet.Range("A2").CellStyle.Font.Size = 28
                worksheet.Range("A2").CellStyle.Font.RGBColor = System.Drawing.Color.FromArgb(0, 0, 112, 192)
                worksheet.Range("A2").HorizontalAlignment = ExcelHAlign.HAlignCenter

                worksheet.Range("A4").Text = "Employee"
                worksheet.Range("B4").Text = "Roger Federer"
                worksheet.Range("A4:B7").CellStyle.Font.FontName = "Verdana"
                worksheet.Range("A4:B7").CellStyle.Font.Bold = True
                worksheet.Range("A4:B7").CellStyle.Font.Size = 11
                worksheet.Range("A4:A7").CellStyle.Font.RGBColor = System.Drawing.Color.FromArgb(0, 128, 128, 128)
                worksheet.Range("A4:A7").HorizontalAlignment = ExcelHAlign.HAlignLeft
                worksheet.Range("B4:B7").CellStyle.Font.RGBColor = System.Drawing.Color.FromArgb(0, 174, 170, 170)
                worksheet.Range("B4:B7").HorizontalAlignment = ExcelHAlign.HAlignRight

                worksheet.Range("A9:D20").CellStyle.Font.FontName = "Verdana"
                worksheet.Range("A9:D20").CellStyle.Font.Size = 11

                worksheet.Range("A5").Text = "Department"
                worksheet.Range("B5").Text = "Administration"

                worksheet.Range("A6").Text = "Week Ending"
                worksheet.Range("B6").NumberFormat = "m/d/yyyy"
                worksheet.Range("B6").DateTime = DateTime.Parse("10/20/2012")

                worksheet.Range("A7").Text = "Mileage Rate"
                worksheet.Range("B7").NumberFormat = "$#,##0.00"
                worksheet.Range("B7").Number = 0.7

                worksheet.Range("A10").Text = "Miles Driven"
                worksheet.Range("A11").Text = "Miles Reimbursement"
                worksheet.Range("A12").Text = "Parking and Tolls"
                worksheet.Range("A13").Text = "Auto Rental"
                worksheet.Range("A14").Text = "Lodging"
                worksheet.Range("A15").Text = "Breakfast"
                worksheet.Range("A16").Text = "Lunch"
                worksheet.Range("A17").Text = "Dinner"
                worksheet.Range("A18").Text = "Snacks"
                worksheet.Range("A19").Text = "Others"
                worksheet.Range("A20").Text = "Total"
                worksheet.Range("A20:D20").CellStyle.Color = System.Drawing.Color.FromArgb(0, 0, 112, 192)
                worksheet.Range("A20:D20").CellStyle.Font.Color = ExcelKnownColors.White
                worksheet.Range("A20:D20").CellStyle.Font.Bold = True

                Dim style As IStyle = worksheet("B9:D9").CellStyle
                style.VerticalAlignment = ExcelVAlign.VAlignCenter
                style.HorizontalAlignment = ExcelHAlign.HAlignRight
                style.Color = System.Drawing.Color.FromArgb(0, 0, 112, 192)
                style.Font.Bold = True
                style.Font.Color = ExcelKnownColors.White

                worksheet.Range("A9").Text = "Expenses"
                worksheet.Range("A9").CellStyle.Color = System.Drawing.Color.FromArgb(0, 0, 112, 192)
                worksheet.Range("A9").CellStyle.Font.Color = ExcelKnownColors.White
                worksheet.Range("A9").CellStyle.Font.Bold = True
                worksheet.Range("B9").Text = "Day 1"
                worksheet.Range("B10").Number = 100
                worksheet.Range("B11").NumberFormat = "$#,##0.00"
                worksheet.Range("B11").Formula = "=(B7*B10)"
                worksheet.Range("B12").NumberFormat = "$#,##0.00"
                worksheet.Range("B12").Number = 0
                worksheet.Range("B13").NumberFormat = "$#,##0.00"
                worksheet.Range("B13").Number = 0
                worksheet.Range("B14").NumberFormat = "$#,##0.00"
                worksheet.Range("B14").Number = 0
                worksheet.Range("B15").NumberFormat = "$#,##0.00"
                worksheet.Range("B15").Number = 9
                worksheet.Range("B16").NumberFormat = "$#,##0.00"
                worksheet.Range("B16").Number = 12
                worksheet.Range("B17").NumberFormat = "$#,##0.00"
                worksheet.Range("B17").Number = 13
                worksheet.Range("B18").NumberFormat = "$#,##0.00"
                worksheet.Range("B18").Number = 9.5
                worksheet.Range("B19").NumberFormat = "$#,##0.00"
                worksheet.Range("B19").Number = 0
                worksheet.Range("B20").NumberFormat = "$#,##0.00"
                worksheet.Range("B20").Formula = "=SUM(B11:B19)"

                worksheet.Range("C9").Text = "Day 2"
                worksheet.Range("C10").Number = 145
                worksheet.Range("C11").NumberFormat = "$#,##0.00"
                worksheet.Range("C11").Formula = "=(B7*C10)"
                worksheet.Range("C12").NumberFormat = "$#,##0.00"
                worksheet.Range("C12").Number = 15
                worksheet.Range("C13").NumberFormat = "$#,##0.00"
                worksheet.Range("C13").Number = 0
                worksheet.Range("C14").NumberFormat = "$#,##0.00"
                worksheet.Range("C14").Number = 45
                worksheet.Range("C15").NumberFormat = "$#,##0.00"
                worksheet.Range("C15").Number = 9
                worksheet.Range("C16").NumberFormat = "$#,##0.00"
                worksheet.Range("C16").Number = 12
                worksheet.Range("C17").NumberFormat = "$#,##0.00"
                worksheet.Range("C17").Number = 15
                worksheet.Range("C18").NumberFormat = "$#,##0.00"
                worksheet.Range("C18").Number = 7
                worksheet.Range("C19").NumberFormat = "$#,##0.00"
                worksheet.Range("C19").Number = 0
                worksheet.Range("C20").NumberFormat = "$#,##0.00"
                worksheet.Range("C20").Formula = "=SUM(C11:C19)"

                worksheet.Range("D9").Text = "Day 3"
                worksheet.Range("D10").Number = 113
                worksheet.Range("D11").NumberFormat = "$#,##0.00"
                worksheet.Range("D11").Formula = "=(B7*D10)"
                worksheet.Range("D12").NumberFormat = "$#,##0.00"
                worksheet.Range("D12").Number = 17
                worksheet.Range("D13").NumberFormat = "$#,##0.00"
                worksheet.Range("D13").Number = 8
                worksheet.Range("D14").NumberFormat = "$#,##0.00"
                worksheet.Range("D14").Number = 45
                worksheet.Range("D15").NumberFormat = "$#,##0.00"
                worksheet.Range("D15").Number = 7
                worksheet.Range("D16").NumberFormat = "$#,##0.00"
                worksheet.Range("D16").Number = 11
                worksheet.Range("D17").NumberFormat = "$#,##0.00"
                worksheet.Range("D17").Number = 16
                worksheet.Range("D18").NumberFormat = "$#,##0.00"
                worksheet.Range("D18").Number = 7
                worksheet.Range("D19").NumberFormat = "$#,##0.00"
                worksheet.Range("D19").Number = 5
                worksheet.Range("D20").NumberFormat = "$#,##0.00"
                worksheet.Range("D20").Formula = "=SUM(D11:D19)"

                worksheet.UsedRange.AutofitRows()
            End If


            If rdbExcel97.Checked Then
                fileName = "Sample.xls"
                workbook.SaveAs(fileName)
            ElseIf rdbExcel2007.Checked Then
                fileName = "Sample.xlsx"
                workbook.Version = ExcelVersion.Excel2007
                workbook.SaveAs(fileName)
            ElseIf rdb2010.Checked Then
                fileName = "Sample.xlsx"
                workbook.Version = ExcelVersion.Excel2010
                workbook.SaveAs(fileName)
            ElseIf rdb2013.Checked Then
                fileName = "Sample.xlsx"
                workbook.Version = ExcelVersion.Excel2013
                workbook.SaveAs(fileName)
            ElseIf rdbCsv.Checked Then
                fileName = "Sample.csv"
                worksheet.SaveAs(fileName, ",")
            ElseIf (rdbXml.Checked) Then
                fileName = "Sample.xml"
                workbook.SaveAsXml(fileName, ExcelXmlSaveType.MSExcel)
            ElseIf (rdbXltx.Checked) Then
                fileName = "Sample.xltx"
                workbook.Version = ExcelVersion.Excel2007
                workbook.SaveAs(fileName, ExcelSaveType.SaveAsTemplate)
            ElseIf (rdbXltm.Checked) Then
                fileName = "Sample.xltm"
                workbook.Version = ExcelVersion.Excel2007
                workbook.SaveAs(fileName, ExcelSaveType.SaveAsTemplate)
            End If

            'Close the workbook.
            workbook.Close()
            excelEngine.Dispose()

            'Message box confirmation to view the created document.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                Try
                    'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                    System.Diagnostics.Process.Start(fileName)

                    'Exit
                    Me.Close()
                Catch ex As Win32Exception
                    MessageBox.Show("MS Excel is not installed in this system")
                    Console.WriteLine(ex.ToString())
                End Try
            Else
                Me.Close()
            End If
        End Sub
#End Region

#Region "HelperMethod"
        Private Function GetFullTemplatePath(ByVal inputFile As String) As String
            Return String.Format(DEFAULTPATH, inputFile)
        End Function
#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateSpreadsheet))
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.label2 = New System.Windows.Forms.Label
            Me.btnCreate = New System.Windows.Forms.Button
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.rdb2013 = New System.Windows.Forms.RadioButton
            Me.rdb2010 = New System.Windows.Forms.RadioButton
            Me.rdbXltx = New System.Windows.Forms.RadioButton
            Me.rdbXltm = New System.Windows.Forms.RadioButton
            Me.rdbXml = New System.Windows.Forms.RadioButton
            Me.rdbCsv = New System.Windows.Forms.RadioButton
            Me.rdbExcel2007 = New System.Windows.Forms.RadioButton
            Me.rdbExcel97 = New System.Windows.Forms.RadioButton
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            Me.PictureBox3 = New System.Windows.Forms.PictureBox
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(198, -1)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(377, 96)
            Me.pictureBox1.TabIndex = 64
            Me.pictureBox1.TabStop = False
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 89)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(490, 48)
            Me.label2.TabIndex = 65
            Me.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" & _
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" & _
                "nt."
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'btnCreate
            '
            Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCreate.BackColor = System.Drawing.Color.Transparent
            Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
            Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCreate.Location = New System.Drawing.Point(484, 194)
            Me.btnCreate.Name = "btnCreate"
            Me.btnCreate.Size = New System.Drawing.Size(85, 26)
            Me.btnCreate.TabIndex = 73
            Me.btnCreate.Text = "Create"
            Me.btnCreate.UseVisualStyleBackColor = False
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.rdb2013)
            Me.groupBox1.Controls.Add(Me.rdb2010)
            Me.groupBox1.Controls.Add(Me.rdbXltx)
            Me.groupBox1.Controls.Add(Me.rdbXltm)
            Me.groupBox1.Controls.Add(Me.rdbXml)
            Me.groupBox1.Controls.Add(Me.rdbCsv)
            Me.groupBox1.Controls.Add(Me.rdbExcel2007)
            Me.groupBox1.Controls.Add(Me.rdbExcel97)
            Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(8, 144)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(561, 40)
            Me.groupBox1.TabIndex = 74
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Save As"
            '
            'rdb2013
            '
            Me.rdb2013.AutoSize = True
            Me.rdb2013.Checked = True
            Me.rdb2013.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdb2013.Location = New System.Drawing.Point(483, 19)
            Me.rdb2013.Name = "rdb2013"
            Me.rdb2013.Size = New System.Drawing.Size(78, 17)
            Me.rdb2013.TabIndex = 7
            Me.rdb2013.TabStop = True
            Me.rdb2013.Text = "Excel 2013"
            Me.rdb2013.UseVisualStyleBackColor = True
            '
            'rdb2010
            '
            Me.rdb2010.AutoSize = True
            Me.rdb2010.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdb2010.Location = New System.Drawing.Point(399, 19)
            Me.rdb2010.Name = "rdb2010"
            Me.rdb2010.Size = New System.Drawing.Size(78, 17)
            Me.rdb2010.TabIndex = 6
            Me.rdb2010.Text = "Excel 2010"
            Me.rdb2010.UseVisualStyleBackColor = True
            '
            'rdbXltx
            '
            Me.rdbXltx.AutoSize = True
            Me.rdbXltx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbXltx.Location = New System.Drawing.Point(114, 19)
            Me.rdbXltx.Name = "rdbXltx"
            Me.rdbXltx.Size = New System.Drawing.Size(42, 17)
            Me.rdbXltx.TabIndex = 5
            Me.rdbXltx.Text = "Xltx"
            Me.rdbXltx.UseVisualStyleBackColor = True
            '
            'rdbXltm
            '
            Me.rdbXltm.AutoSize = True
            Me.rdbXltm.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbXltm.Location = New System.Drawing.Point(167, 19)
            Me.rdbXltm.Name = "rdbXltm"
            Me.rdbXltm.Size = New System.Drawing.Size(45, 17)
            Me.rdbXltm.TabIndex = 4
            Me.rdbXltm.Text = "Xltm"
            Me.rdbXltm.UseVisualStyleBackColor = True
            '
            'rdbXml
            '
            Me.rdbXml.AutoSize = True
            Me.rdbXml.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbXml.Location = New System.Drawing.Point(59, 19)
            Me.rdbXml.Name = "rdbXml"
            Me.rdbXml.Size = New System.Drawing.Size(42, 17)
            Me.rdbXml.TabIndex = 3
            Me.rdbXml.Text = "Xml"
            Me.rdbXml.UseVisualStyleBackColor = True
            '
            'rdbCsv
            '
            Me.rdbCsv.AutoSize = True
            Me.rdbCsv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbCsv.Location = New System.Drawing.Point(6, 19)
            Me.rdbCsv.Name = "rdbCsv"
            Me.rdbCsv.Size = New System.Drawing.Size(46, 17)
            Me.rdbCsv.TabIndex = 2
            Me.rdbCsv.Text = "CSV"
            Me.rdbCsv.UseVisualStyleBackColor = True
            '
            'rdbExcel2007
            '
            Me.rdbExcel2007.AutoSize = True
            Me.rdbExcel2007.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbExcel2007.Location = New System.Drawing.Point(308, 19)
            Me.rdbExcel2007.Name = "rdbExcel2007"
            Me.rdbExcel2007.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2007.TabIndex = 1
            Me.rdbExcel2007.Text = "Excel 2007"
            Me.rdbExcel2007.UseVisualStyleBackColor = True
            '
            'rdbExcel97
            '
            Me.rdbExcel97.AutoSize = True
            Me.rdbExcel97.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbExcel97.Location = New System.Drawing.Point(227, 19)
            Me.rdbExcel97.Name = "rdbExcel97"
            Me.rdbExcel97.Size = New System.Drawing.Size(66, 17)
            Me.rdbExcel97.TabIndex = 0
            Me.rdbExcel97.Text = "Excel 97"
            Me.rdbExcel97.UseVisualStyleBackColor = True
            '
            'PictureBox2
            '
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(100, -14)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(160, 100)
            Me.PictureBox2.TabIndex = 75
            Me.PictureBox2.TabStop = False
            '
            'PictureBox3
            '
            Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
            Me.PictureBox3.Location = New System.Drawing.Point(-7, -28)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(136, 100)
            Me.PictureBox3.TabIndex = 76
            Me.PictureBox3.TabStop = False
            '
            'CreateSpreadsheet
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(572, 230)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.btnCreate)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.PictureBox3)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "CreateSpreadsheet"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Create Spreadsheet"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Dispose Methods"
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
            Application.EnableVisualStyles()
            Application.Run(New CreateSpreadsheet())
        End Sub
#End Region
    End Class
End Namespace
