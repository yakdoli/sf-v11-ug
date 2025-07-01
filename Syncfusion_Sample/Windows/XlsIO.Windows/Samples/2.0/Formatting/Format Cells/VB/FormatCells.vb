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
    Public Class FormatCells : Inherits System.Windows.Forms.Form

#Region "Constants"
        Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Images\XlsIO\{0}"
#End Region

#Region "Fields"
        Private WithEvents btnCreate As System.Windows.Forms.Button
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents rdbExcel2010 As System.Windows.Forms.RadioButton
        Private WithEvents rdbExcel2007 As System.Windows.Forms.RadioButton
        Private WithEvents rdbExcel97 As System.Windows.Forms.RadioButton
        Private fileName As String
        Private WithEvents rdbExcel2013 As System.Windows.Forms.RadioButton
        Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
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
            Me.FormBorderStyle = FormBorderStyle.FixedSingle
            Me.MinimizeBox = False
            Me.MaximizeBox = False
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.rdbExcel2013.Checked = True
            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub
#End Region

#Region "Format Cells Event"
        Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel
            'Set the Default Version as Excel 97to2003
            If Me.rdbExcel97.Checked Then
                application.DefaultVersion = ExcelVersion.Excel97to2003
                fileName = "FormatCells.xls"
                'Set the Default Version as Excel 2007
            ElseIf Me.rdbExcel2007.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2007
                fileName = "FormatCells.xlsx"
                'Set the Default Version as Excel 2010
            ElseIf Me.rdbExcel2010.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2010
                fileName = "FormatCells.xlsx"
            ElseIf Me.rdbExcel2013.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2013
                fileName = "FormatCells13.xlsx"
            End If
            'A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            'The new workbook will have 3 worksheets
            Dim workbook As IWorkbook = application.Workbooks.Create(3)
            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)
            worksheet.IsGridLinesVisible = False

            'RTF
            'Insert Rich Text
            Dim range As IRange = worksheet.Range("D3")
            range.Text = "Employee Report"
            Dim rtf As IRichTextString = range.RichText

            'Formatting the text
            Dim redFont As IFont = workbook.CreateFont()
            redFont.Size = 16
            redFont.Bold = True
            redFont.Italic = True
            redFont.RGBColor = Color.FromArgb(&H82, &H2E, &H1B)
            rtf.SetFont(0, 14, redFont)

            'Number Formatting

            worksheet.Range("H24").Number = 5000
            worksheet.Range("H24").NumberFormat = "$#,##0.00"
            worksheet.Range("H14").NumberFormat = "dd/mm/yyyy"
            worksheet.Range("H14").DateTime = DateTime.Parse(" 8/3/1963")
            worksheet.Range("H16").NumberFormat = "mm/dd/yyyy"
            worksheet.Range("H16").DateTime = DateTime.Parse(" 4/1/1992")

            'Alignment settings

            'Text alignment
            worksheet.Range("F10:F24").HorizontalAlignment = ExcelHAlign.HAlignRight
            worksheet.Range("D3").HorizontalAlignment = ExcelHAlign.HAlignCenter
            worksheet.Range("H10:H24").HorizontalAlignment = ExcelHAlign.HAlignLeft
            worksheet.Range("F10:F24").VerticalAlignment = ExcelVAlign.VAlignCenter

            'Text Control
            worksheet.Range("F27").WrapText = True
            worksheet.Range("F27").Text = "Antony Jose graduated from St. Andrews University, Scotland, with a BSC degree in 1976.  Upon joining the company as a sales representative in 1992, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London.  He was promoted to sales manager in March 1993."

            'Cell merging
            worksheet.Range("F27:H28").Merge()
            worksheet.Range("D3:F3").Merge()
            worksheet.Range("B7:J8").Merge()
            worksheet.Range("F27").RowHeight = 64
            worksheet.Range("H10:H24").ColumnWidth = 25
            worksheet.Range("C10:D28").Merge()
            worksheet.Range("B10:C28").ColumnWidth = 1
            worksheet.Range("E10:E28").ColumnWidth = 5
            worksheet.Range("D10:D28").ColumnWidth = 15

            'Text Direction
            worksheet.Range("B7").Text = "Antony Jose"
            worksheet.Range("B7").CellStyle.ReadingOrder = Syncfusion.XlsIO.ExcelReadingOrderType.LeftToRight
            worksheet.Range("B7").CellStyle.HorizontalAlignment = ExcelHAlign.HAlignLeft
            worksheet.Range("B7").CellStyle.VerticalAlignment = ExcelVAlign.VAlignCenter

            'Text Indent

            worksheet.Range("D7").CellStyle.IndentLevel = 6

            'Font settings

            ' Setting Font Type
            worksheet.Range("F10:F24").CellStyle.Font.FontName = "Arial"
            worksheet.Range("D3").CellStyle.Font.FontName = "Arial"
            worksheet.Range("B7").CellStyle.Font.FontName = "Arial"
            worksheet.Range("B7").CellStyle.Font.Size = 12.0F
            worksheet.Range("B7").CellStyle.Font.Bold = True

            ' Setting Font Styles
            worksheet.Range("F10:F24").CellStyle.Font.Bold = True
            worksheet.Range("D3").CellStyle.Font.Bold = True

            ' Setting Font Size
            worksheet.Range("F10:F24").CellStyle.Font.Size = 10
            worksheet.Range("D3").CellStyle.Font.Size = 14
            worksheet.Range("F27:H28").CellStyle.Font.Size = 9.0F

            ' Setting Font Color
            worksheet.Range("B7").CellStyle.Font.RGBColor = Color.White
            worksheet.Range("D28").CellStyle.Font.RGBColor = Color.White


            ' Setting UnderLine 
            worksheet.Range("D3").CellStyle.Font.Underline = ExcelUnderline.Double

            worksheet.Range("F10").Text = "Name"
            worksheet.Range("F12").Text = "Title"
            worksheet.Range("F14").Text = "Birth Date"
            worksheet.Range("F16").Text = "Hire date"
            worksheet.Range("F18").Text = "Home phone"
            worksheet.Range("F20").Text = "Extension"
            worksheet.Range("F22").Text = "Home address"
            worksheet.Range("F24").Text = "Salary"

            worksheet.Range("H10").Text = "Antony Jose"
            worksheet.Range("H12").Text = "Sales Manager"
            worksheet.Range("H18").Text = "(206) 555-3412"
            worksheet.Range("H20").Number = 3355
            worksheet.Range("H22").Text = "722 Moss Bay Blvd"

            'Insert Image
            'Get the Path of the Image
            Dim imagePath As String = GetFullImagePath("EMPID1.png")
            worksheet.Pictures.AddPicture(11, 4, imagePath, 55, 65)

            'Border settings

            worksheet.Range("H10").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
            worksheet.Range("H10").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
            worksheet.Range("H10").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

            worksheet.Range("H12").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
            worksheet.Range("H12").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
            worksheet.Range("H12").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

            worksheet.Range("H14").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
            worksheet.Range("H14").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
            worksheet.Range("H14").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

            worksheet.Range("H16").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
            worksheet.Range("H16").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
            worksheet.Range("H16").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

            worksheet.Range("H18").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
            worksheet.Range("H18").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
            worksheet.Range("H18").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

            worksheet.Range("H20").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
            worksheet.Range("H20").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
            worksheet.Range("H20").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

            worksheet.Range("H22").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
            worksheet.Range("H22").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
            worksheet.Range("H22").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

            worksheet.Range("H24").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
            worksheet.Range("H24").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
            worksheet.Range("H24").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

            worksheet.Range("F27:H28").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
            worksheet.Range("F27:H28").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
            worksheet.Range("F27:H28").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

            worksheet.Range("C10:D28").CellStyle.Borders.LineStyle = ExcelLineStyle.Thin
            worksheet.Range("C10:D28").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
            worksheet.Range("C10:D28").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

            'Pattern settings
            worksheet.Range("B9:I29").CellStyle.Color = Color.FromArgb(198, 215, 239)
            worksheet.Range("A7:J8").CellStyle.Color = Color.FromArgb(57, 93, 148)

            worksheet.Range("A7:A30").CellStyle.Color = Color.FromArgb(57, 93, 148)
            worksheet.Range("A7:A30").ColumnWidth = 2.29

            worksheet.Range("J7:J30").CellStyle.Color = Color.FromArgb(57, 93, 148)
            worksheet.Range("J7:J30").ColumnWidth = 2.29

            worksheet.Range("A30:J30").CellStyle.Color = Color.FromArgb(57, 93, 148)

            worksheet.Range("C10:D28").CellStyle.Color = Color.FromArgb(231, 235, 247)
            worksheet.Range("F27:H28").CellStyle.Color = Color.FromArgb(231, 235, 247)


            'Saving the workbook to disk.
            workbook.SaveAs(fileName)

            'Close the workbook.
            workbook.Close()

            'No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = False
            excelEngine.Dispose()

            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
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
        Private Function GetFullImagePath(ByVal inputFile As String) As String
            Return String.Format(DEFAULTPATH, inputFile)
        End Function
#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormatCells))
            Me.btnCreate = New System.Windows.Forms.Button
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.label2 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.rdbExcel2010 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2007 = New System.Windows.Forms.RadioButton
            Me.rdbExcel97 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2013 = New System.Windows.Forms.RadioButton
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnCreate
            '
            Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCreate.BackColor = System.Drawing.Color.Transparent
            Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
            Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCreate.Location = New System.Drawing.Point(349, 166)
            Me.btnCreate.Name = "btnCreate"
            Me.btnCreate.Size = New System.Drawing.Size(85, 26)
            Me.btnCreate.TabIndex = 0
            Me.btnCreate.Text = "Create"
            Me.btnCreate.UseVisualStyleBackColor = False
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(76, -2)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(372, 96)
            Me.pictureBox1.TabIndex = 64
            Me.pictureBox1.TabStop = False
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 107)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(448, 48)
            Me.label2.TabIndex = 65
            Me.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" & _
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" & _
                "nt."
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.rdbExcel2013)
            Me.groupBox1.Controls.Add(Me.rdbExcel2010)
            Me.groupBox1.Controls.Add(Me.rdbExcel2007)
            Me.groupBox1.Controls.Add(Me.rdbExcel97)
            Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(12, 158)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(329, 37)
            Me.groupBox1.TabIndex = 66
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Save As"
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
            Me.rdbExcel2013.Location = New System.Drawing.Point(248, 13)
            Me.rdbExcel2013.Name = "rdbExcel2013"
            Me.rdbExcel2013.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2013.TabIndex = 3
            Me.rdbExcel2013.Text = "Excel 2013"
            Me.rdbExcel2013.UseVisualStyleBackColor = True
            '
            'PictureBox2
            '
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(-10, -14)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(110, 96)
            Me.PictureBox2.TabIndex = 67
            Me.PictureBox2.TabStop = False
            '
            'FormatCells
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(446, 208)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.btnCreate)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimizeBox = False
            Me.Name = "FormatCells"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Format Cells"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
            Application.EnableVisualStyles()
            Application.Run(New FormatCells())
        End Sub
#End Region

    End Class
End Namespace
