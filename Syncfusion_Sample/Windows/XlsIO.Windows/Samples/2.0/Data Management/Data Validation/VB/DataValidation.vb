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
    Public Class DataValidation : Inherits System.Windows.Forms.Form

#Region "Fields"
        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents label2 As System.Windows.Forms.Label
        Private fileName As String
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents XmlRadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents excel2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents excel2007RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents excel2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents pictureBox3 As System.Windows.Forms.PictureBox
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents Label3 As System.Windows.Forms.Label
        Private WithEvents excel2013RadioBtn As System.Windows.Forms.RadioButton
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
            Me.excel2013RadioBtn.Checked = True
            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub
#End Region

#Region "Using DataValidation"
        Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click

            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel
            'Set the Default version as Excel 97to2003
            If Me.excel2003RadioBtn.Checked Then
                application.DefaultVersion = ExcelVersion.Excel97to2003
                fileName = "DataValidation.xls"
                'Set the Default version as Excel 2007
            ElseIf Me.excel2007RadioBtn.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2007
                fileName = "DataValidation.xlsx"
                'Set the Default version as Excel 2010
            ElseIf Me.excel2010RadioBtn.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2010
                fileName = "DataValidation.xlsx"
                'Set the Default version as Excel 2013
            ElseIf Me.excel2013RadioBtn.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2013
                fileName = "DataValidation.xlsx"
                'Set the Default version as Xml
            ElseIf Me.XmlRadioBtn.Checked Then
                fileName = "DataValidation.xml"
            End If
            'A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            'The new workbook will have 3 worksheets
            Dim workbook As IWorkbook = application.Workbooks.Create(3)
            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            'Data validation to list the values in the first cell
            Dim validation As IDataValidation = worksheet.Range("C7").DataValidation
            worksheet.Range("B7").Text = "Select an item from the validation list"
            validation.ListOfValues = New String() {"PDF", "XlsIO", "DocIO"}
            validation.PromptBoxText = "Data Validation list"
            validation.IsPromptBoxVisible = True
            validation.ShowPromptBox = True

            worksheet.Range("C7").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
            worksheet.Range("C7").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
            worksheet.Range("C7").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

            ' Data Validation for Numbers
            Dim validation1 As IDataValidation = worksheet.Range("C9").DataValidation
            worksheet.Range("B9").Text = "Enter a Number to validate"
            validation1.AllowType = ExcelDataType.Integer
            validation1.CompareOperator = ExcelDataValidationComparisonOperator.Between
            validation1.FirstFormula = "0"
            validation1.SecondFormula = "10"
            validation1.ShowErrorBox = True
            validation1.ErrorBoxText = "Enter Value between 0 to 10"
            validation1.ErrorBoxTitle = "ERROR"
            validation1.PromptBoxText = "Data Validation using Condition for Numbers"
            validation1.ShowPromptBox = True
            worksheet.Range("C9").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
            worksheet.Range("C9").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
            worksheet.Range("C9").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

            ' Data Validation for Date
            Dim validation2 As IDataValidation = worksheet.Range("C11").DataValidation
            worksheet.Range("B11").Text = "Enter the Date to validate"
            validation2.AllowType = ExcelDataType.Date
            validation2.CompareOperator = ExcelDataValidationComparisonOperator.Between
            validation2.FirstDateTime = New DateTime(2003, 5, 10)
            validation2.SecondDateTime = New DateTime(2004, 5, 10)
            validation2.ShowErrorBox = True
            validation2.ErrorBoxText = "Enter Value between 10/5/2003 to 10/5/2004"
            validation2.ErrorBoxTitle = "ERROR"
            validation2.PromptBoxText = "Data Validation using Condition for Date"
            validation2.ShowPromptBox = True
            worksheet.Range("C11").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
            worksheet.Range("C11").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
            worksheet.Range("C11").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

            ' Data Validation for TextLength
            Dim validation3 As IDataValidation = worksheet.Range("C13").DataValidation
            worksheet.Range("B13").Text = "Enter the Text to validate"
            validation3.AllowType = ExcelDataType.TextLength
            validation3.CompareOperator = ExcelDataValidationComparisonOperator.Between
            validation3.FirstFormula = "1"
            validation3.SecondFormula = "6"
            validation3.ShowErrorBox = True
            validation3.ErrorBoxText = "Retype text length to 6 character"
            validation3.ErrorBoxTitle = "ERROR"
            validation3.PromptBoxText = "Data Validation using Condition for TextLength"
            validation3.ShowPromptBox = True
            worksheet.Range("C13").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
            worksheet.Range("C13").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
            worksheet.Range("C13").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False

            ' Data Validation for Time
            Dim validation4 As IDataValidation = worksheet.Range("C15").DataValidation
            worksheet.Range("B15").Text = "Enter the Time to validate"
            validation4.AllowType = ExcelDataType.Time
            validation4.CompareOperator = ExcelDataValidationComparisonOperator.Between
            validation4.FirstFormula = "0.2"
            validation4.SecondFormula = "0.75"
            validation4.ShowErrorBox = True
            validation4.ErrorBoxText = "Enter the Correct time between 10 to 12 "
            validation4.ErrorBoxTitle = "ERROR"
            validation4.PromptBoxText = "Data Validation using Condition for Time"
            validation4.ShowPromptBox = True
            worksheet.Range("C15").CellStyle.Borders.LineStyle = ExcelLineStyle.Medium
            worksheet.Range("C15").CellStyle.Borders(ExcelBordersIndex.DiagonalDown).ShowDiagonalLine = False
            worksheet.Range("C15").CellStyle.Borders(ExcelBordersIndex.DiagonalUp).ShowDiagonalLine = False
            worksheet.Range("B2:C2").Merge()
            worksheet.Range("B2").Text = "Simple Data validation"
            worksheet.Range("B5").Text = "Validation criteria"
            worksheet.Range("C5").Text = "Validation"
            worksheet.Range("B5").CellStyle.Font.Bold = True
            worksheet.Range("C5").CellStyle.Font.Bold = True
            worksheet.Range("B2").CellStyle.Font.Bold = True
            worksheet.Range("B2").CellStyle.Font.Size = 16
            worksheet.Range("B2").CellStyle.HorizontalAlignment = ExcelHAlign.HAlignCenter
            worksheet.AutofitColumn(2)
            worksheet.UsedRange.AutofitRows()

            'Save the workbook
            If Me.XmlRadioBtn.Checked Then
                workbook.SaveAsXml(fileName, ExcelXmlSaveType.MSExcel)
            Else
                workbook.SaveAs(fileName)
            End If
            'Close the workbook.
            workbook.Close()

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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataValidation))
            Me.button1 = New System.Windows.Forms.Button
            Me.label2 = New System.Windows.Forms.Label
            Me.label1 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.XmlRadioBtn = New System.Windows.Forms.RadioButton
            Me.excel2010RadioBtn = New System.Windows.Forms.RadioButton
            Me.excel2007RadioBtn = New System.Windows.Forms.RadioButton
            Me.excel2003RadioBtn = New System.Windows.Forms.RadioButton
            Me.pictureBox3 = New System.Windows.Forms.PictureBox
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            Me.excel2013RadioBtn = New System.Windows.Forms.RadioButton
            Me.groupBox1.SuspendLayout()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'button1
            '
            Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button1.BackColor = System.Drawing.Color.Transparent
            Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
            Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.button1.Location = New System.Drawing.Point(398, 165)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(85, 26)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Create"
            Me.button1.UseVisualStyleBackColor = False
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 109)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(372, 48)
            Me.label2.TabIndex = 64
            Me.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" & _
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" & _
                "nt."
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(-36, 10)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(531, 56)
            Me.label1.TabIndex = 77
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.excel2013RadioBtn)
            Me.groupBox1.Controls.Add(Me.XmlRadioBtn)
            Me.groupBox1.Controls.Add(Me.excel2010RadioBtn)
            Me.groupBox1.Controls.Add(Me.excel2007RadioBtn)
            Me.groupBox1.Controls.Add(Me.excel2003RadioBtn)
            Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(3, 159)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(389, 37)
            Me.groupBox1.TabIndex = 80
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Save As"
            '
            'XmlRadioBtn
            '
            Me.XmlRadioBtn.AutoSize = True
            Me.XmlRadioBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.XmlRadioBtn.Location = New System.Drawing.Point(341, 13)
            Me.XmlRadioBtn.Name = "XmlRadioBtn"
            Me.XmlRadioBtn.Size = New System.Drawing.Size(42, 17)
            Me.XmlRadioBtn.TabIndex = 3
            Me.XmlRadioBtn.Text = "Xml"
            Me.XmlRadioBtn.UseVisualStyleBackColor = True
            '
            'excel2010RadioBtn
            '
            Me.excel2010RadioBtn.AutoSize = True
            Me.excel2010RadioBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.excel2010RadioBtn.Location = New System.Drawing.Point(164, 13)
            Me.excel2010RadioBtn.Name = "excel2010RadioBtn"
            Me.excel2010RadioBtn.Size = New System.Drawing.Size(78, 17)
            Me.excel2010RadioBtn.TabIndex = 2
            Me.excel2010RadioBtn.Text = "Excel 2010"
            Me.excel2010RadioBtn.UseVisualStyleBackColor = True
            '
            'excel2007RadioBtn
            '
            Me.excel2007RadioBtn.AutoSize = True
            Me.excel2007RadioBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.excel2007RadioBtn.Location = New System.Drawing.Point(85, 13)
            Me.excel2007RadioBtn.Name = "excel2007RadioBtn"
            Me.excel2007RadioBtn.Size = New System.Drawing.Size(78, 17)
            Me.excel2007RadioBtn.TabIndex = 1
            Me.excel2007RadioBtn.Text = "Excel 2007"
            Me.excel2007RadioBtn.UseVisualStyleBackColor = True
            '
            'excel2003RadioBtn
            '
            Me.excel2003RadioBtn.AutoSize = True
            Me.excel2003RadioBtn.Checked = True
            Me.excel2003RadioBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.excel2003RadioBtn.Location = New System.Drawing.Point(6, 13)
            Me.excel2003RadioBtn.Name = "excel2003RadioBtn"
            Me.excel2003RadioBtn.Size = New System.Drawing.Size(78, 17)
            Me.excel2003RadioBtn.TabIndex = 0
            Me.excel2003RadioBtn.TabStop = True
            Me.excel2003RadioBtn.Text = "Excel 2003"
            Me.excel2003RadioBtn.UseVisualStyleBackColor = True
            '
            'pictureBox3
            '
            Me.pictureBox3.Image = CType(resources.GetObject("pictureBox3.Image"), System.Drawing.Image)
            Me.pictureBox3.Location = New System.Drawing.Point(46, -11)
            Me.pictureBox3.Name = "pictureBox3"
            Me.pictureBox3.Size = New System.Drawing.Size(76, 89)
            Me.pictureBox3.TabIndex = 79
            Me.pictureBox3.TabStop = False
            '
            'pictureBox1
            '
            Me.pictureBox1.BackColor = System.Drawing.Color.Transparent
            Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(121, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(376, 96)
            Me.pictureBox1.TabIndex = 78
            Me.pictureBox1.TabStop = False
            '
            'Label3
            '
            Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label3.Location = New System.Drawing.Point(0, 0)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(495, 56)
            Me.Label3.TabIndex = 77
            '
            'PictureBox2
            '
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(-28, -22)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(75, 93)
            Me.PictureBox2.TabIndex = 81
            Me.PictureBox2.TabStop = False
            '
            'excel2013RadioBtn
            '
            Me.excel2013RadioBtn.AutoSize = True
            Me.excel2013RadioBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.excel2013RadioBtn.Location = New System.Drawing.Point(248, 13)
            Me.excel2013RadioBtn.Name = "excel2013RadioBtn"
            Me.excel2013RadioBtn.Size = New System.Drawing.Size(78, 17)
            Me.excel2013RadioBtn.TabIndex = 4
            Me.excel2013RadioBtn.Text = "Excel 2013"
            Me.excel2013RadioBtn.UseVisualStyleBackColor = True
            '
            'DataValidation
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.ClientSize = New System.Drawing.Size(495, 208)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.pictureBox3)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.button1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "DataValidation"
            Me.Text = "Data Validation"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Disposes"
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
            Application.Run(New DataValidation())
        End Sub
#End Region

    End Class
End Namespace
