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
Imports System.Diagnostics
Imports Syncfusion.XlsIO

Namespace EssentialXlsIOSamples
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Performance : Inherits System.Windows.Forms.Form

#Region "Fields"
        Private WithEvents btnCreate As System.Windows.Forms.Button
        Private label2 As System.Windows.Forms.Label
        Private label3 As System.Windows.Forms.Label
        Private groupBox1 As System.Windows.Forms.GroupBox

        'Measurement variables.
        Private startTime As DateTime
        Private endTime As TimeSpan
        Private startMemory As Long
        Private endMemory As Long
        Private rowCount As Integer
        Private colCount As Integer
        Private fileName As String
        Private numRowCount As System.Windows.Forms.NumericUpDown
        Private numColCount As System.Windows.Forms.NumericUpDown
        Private WithEvents Log As System.Windows.Forms.TextBox
        Private chbColumnStyle As System.Windows.Forms.CheckBox
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbExcel2010 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExcel2007 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExcel97 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExcel2013 As System.Windows.Forms.RadioButton
        Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Initialze"
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

#Region "Performance Checking"
        Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click

            'Start Time
            startTime = DateTime.Now

            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel
            'Set the Default version as Excel 97to2003
            If Me.rdbExcel97.Checked Then
                application.DefaultVersion = ExcelVersion.Excel97to2003
                fileName = "PerformanceChecking.xls"
                'Set the Default version as Excel 2007
            ElseIf Me.rdbExcel2007.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2007
                fileName = "PerformanceChecking.xlsx"
                'Set the Default version as Excel 2010
            ElseIf Me.rdbExcel2010.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2010
                fileName = "PerformanceChecking.xlsx"
                'Set the Default version as Excel 2013
            ElseIf Me.rdbExcel2013.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2013
                fileName = "PerformanceChecking.xlsx"
            End If
            'A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            'The new workbook will have 3 worksheets
            Dim workbook As IWorkbook = application.Workbooks.Create(3)

            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            rowCount = CInt(numRowCount.Value)
            colCount = CInt(numColCount.Value)

            workbook.DetectDateTimeInValue = False
            Dim migrantRange As IMigrantRange = worksheet.MigrantRange

            'Header Style
            Dim headerStyle As IStyle = workbook.Styles.Add("HeaderStyle")

            headerStyle.BeginUpdate()
            'Add custom colors to the palette.
            workbook.SetPaletteColor(8, Color.FromArgb(255, 174, 33))
            headerStyle.Color = Color.FromArgb(255, 174, 33)
            headerStyle.Font.Bold = True
            headerStyle.Borders(ExcelBordersIndex.EdgeLeft).LineStyle = ExcelLineStyle.Thin
            headerStyle.Borders(ExcelBordersIndex.EdgeRight).LineStyle = ExcelLineStyle.Thin
            headerStyle.Borders(ExcelBordersIndex.EdgeTop).LineStyle = ExcelLineStyle.Thin
            headerStyle.Borders(ExcelBordersIndex.EdgeBottom).LineStyle = ExcelLineStyle.Thin
            headerStyle.EndUpdate()

            If chbColumnStyle.Checked Then
                'Body Style
                Dim bodyStyle As IStyle = workbook.Styles.Add("BodyStyle")
                bodyStyle.BeginUpdate()

                'Add custom colors to the palette.
                workbook.SetPaletteColor(9, Color.FromArgb(239, 243, 247))
                bodyStyle.Color = Color.FromArgb(239, 243, 247)
                bodyStyle.Borders(ExcelBordersIndex.EdgeLeft).LineStyle = ExcelLineStyle.Thin
                bodyStyle.Borders(ExcelBordersIndex.EdgeRight).LineStyle = ExcelLineStyle.Thin
                bodyStyle.EndUpdate()

                worksheet.SetDefaultColumnStyle(1, colCount, bodyStyle)

            End If
            Dim column As Integer = 1

            Do While column <= colCount
                migrantRange.ResetRowColumn(1, column)
                migrantRange.Text = "Column: " & column.ToString()
                migrantRange.CellStyle = headerStyle
                column += 1
            Loop

            'Writing Data using normal interface
            Dim row As Integer = 2

            Do While row <= rowCount

                column = 1

                Do While column <= colCount
                    'Writing number
                    migrantRange.ResetRowColumn(row, column)
                    migrantRange.Number = row * column
                    column += 1
                Loop
                row += 1
            Loop

            workbook.SaveAs(fileName)
            workbook.Close()
            excelEngine.Dispose()

            'End Time
            endTime = DateTime.Now.Subtract(startTime)
            LogDetails(endTime)


            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then


                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start(fileName)
                'Exit
                Me.Close()
            End If
        End Sub
#End Region

#Region "Get LogDetails"
        Private Sub LogDetails(ByVal endtime_Renamed As TimeSpan)
            ' Force garbage collection and get used memory size
            GC.Collect()
            System.Threading.Thread.Sleep(10)
            GC.Collect()
            System.Threading.Thread.Sleep(100)
            GC.Collect()
            'Log.Text ="Optimizations for {0}: ";

            Dim myProcess As Process = Process.GetCurrentProcess()

            Dim workingSetSizeinKiloBytes As Double = myProcess.WorkingSet64 / 1000

            Dim s As String = "Number of rows : " & numRowCount.Value.ToString() + Constants.vbCrLf & "Number of columns: " & numColCount.Value.ToString() + Constants.vbCrLf & "Process's physical memory usage: " & workingSetSizeinKiloBytes.ToString() & " kb " & Constants.vbCrLf
            Log.Text = s & Constants.vbCrLf & "Time taken : " & endTime.Minutes & "Mins : " & endTime.Seconds & "secs : " & endTime.Milliseconds & "msec"
        End Sub
#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Performance))
            Me.btnCreate = New System.Windows.Forms.Button
            Me.numRowCount = New System.Windows.Forms.NumericUpDown
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.numColCount = New System.Windows.Forms.NumericUpDown
            Me.chbColumnStyle = New System.Windows.Forms.CheckBox
            Me.Log = New System.Windows.Forms.TextBox
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.GroupBox2 = New System.Windows.Forms.GroupBox
            Me.rdbExcel2010 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2007 = New System.Windows.Forms.RadioButton
            Me.rdbExcel97 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2013 = New System.Windows.Forms.RadioButton
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            CType(Me.numRowCount, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            CType(Me.numColCount, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnCreate
            '
            Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCreate.BackColor = System.Drawing.Color.Transparent
            Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
            Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCreate.Location = New System.Drawing.Point(344, 202)
            Me.btnCreate.Name = "btnCreate"
            Me.btnCreate.Size = New System.Drawing.Size(85, 26)
            Me.btnCreate.TabIndex = 0
            Me.btnCreate.Text = "Create"
            Me.btnCreate.UseVisualStyleBackColor = False
            '
            'numRowCount
            '
            Me.numRowCount.Increment = New Decimal(New Integer() {100, 0, 0, 0})
            Me.numRowCount.Location = New System.Drawing.Point(267, 14)
            Me.numRowCount.Maximum = New Decimal(New Integer() {65000, 0, 0, 0})
            Me.numRowCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.numRowCount.Name = "numRowCount"
            Me.numRowCount.Size = New System.Drawing.Size(120, 20)
            Me.numRowCount.TabIndex = 2
            Me.numRowCount.ThousandsSeparator = True
            Me.numRowCount.Value = New Decimal(New Integer() {65000, 0, 0, 0})
            '
            'label2
            '
            Me.label2.Location = New System.Drawing.Point(16, 16)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(143, 24)
            Me.label2.TabIndex = 4
            Me.label2.Text = "Select the number of Rows"
            '
            'label3
            '
            Me.label3.Location = New System.Drawing.Point(16, 48)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(154, 24)
            Me.label3.TabIndex = 5
            Me.label3.Text = "Select the number of columns"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.numRowCount)
            Me.groupBox1.Controls.Add(Me.numColCount)
            Me.groupBox1.Location = New System.Drawing.Point(12, 102)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(413, 86)
            Me.groupBox1.TabIndex = 6
            Me.groupBox1.TabStop = False
            '
            'numColCount
            '
            Me.numColCount.Location = New System.Drawing.Point(267, 46)
            Me.numColCount.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
            Me.numColCount.Name = "numColCount"
            Me.numColCount.Size = New System.Drawing.Size(120, 20)
            Me.numColCount.TabIndex = 3
            Me.numColCount.Value = New Decimal(New Integer() {10, 0, 0, 0})
            '
            'chbColumnStyle
            '
            Me.chbColumnStyle.Location = New System.Drawing.Point(279, 247)
            Me.chbColumnStyle.Name = "chbColumnStyle"
            Me.chbColumnStyle.Size = New System.Drawing.Size(96, 22)
            Me.chbColumnStyle.TabIndex = 9
            Me.chbColumnStyle.Text = "Column style"
            '
            'Log
            '
            Me.Log.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(255, Byte), Integer))
            Me.Log.Location = New System.Drawing.Point(12, 286)
            Me.Log.Multiline = True
            Me.Log.Name = "Log"
            Me.Log.ReadOnly = True
            Me.Log.Size = New System.Drawing.Size(413, 82)
            Me.Log.TabIndex = 8
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(63, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(375, 96)
            Me.pictureBox1.TabIndex = 64
            Me.pictureBox1.TabStop = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.rdbExcel2013)
            Me.GroupBox2.Controls.Add(Me.rdbExcel2010)
            Me.GroupBox2.Controls.Add(Me.rdbExcel2007)
            Me.GroupBox2.Controls.Add(Me.rdbExcel97)
            Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(10, 194)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(328, 37)
            Me.GroupBox2.TabIndex = 65
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Save As "
            '
            'rdbExcel2010
            '
            Me.rdbExcel2010.AutoSize = True
            Me.rdbExcel2010.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbExcel2010.Location = New System.Drawing.Point(164, 13)
            Me.rdbExcel2010.Name = "rdbExcel2010"
            Me.rdbExcel2010.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2010.TabIndex = 2
            Me.rdbExcel2010.TabStop = True
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
            Me.rdbExcel2007.TabStop = True
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
            Me.rdbExcel2013.Location = New System.Drawing.Point(244, 13)
            Me.rdbExcel2013.Name = "rdbExcel2013"
            Me.rdbExcel2013.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2013.TabIndex = 3
            Me.rdbExcel2013.TabStop = True
            Me.rdbExcel2013.Text = "Excel 2013"
            Me.rdbExcel2013.UseVisualStyleBackColor = True
            '
            'PictureBox2
            '
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(-13, -11)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(99, 96)
            Me.PictureBox2.TabIndex = 66
            Me.PictureBox2.TabStop = False
            '
            'Performance
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(437, 380)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.Log)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.chbColumnStyle)
            Me.Controls.Add(Me.btnCreate)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Performance"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Performance"
            CType(Me.numRowCount, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            CType(Me.numColCount, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

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
            Application.Run(New Performance())
        End Sub
#End Region

    End Class
End Namespace
