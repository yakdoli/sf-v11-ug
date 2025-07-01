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
    Public Class RowColumnManipulations : Inherits System.Windows.Forms.Form

#Region "Constants"
        Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Fields"
        Private WithEvents Create As System.Windows.Forms.Button
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents rdbExcel2010 As System.Windows.Forms.RadioButton
        Private WithEvents rdbExcel2007 As System.Windows.Forms.RadioButton
        Private WithEvents rdbExcel97 As System.Windows.Forms.RadioButton
        Private fileName As String
        Friend WithEvents viewInputTemplate As System.Windows.Forms.Button
        Private WithEvents rdbExcel2013 As System.Windows.Forms.RadioButton
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Initialization"

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

#Region "Row and Column Manipulation"

        Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Create.Click

            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            'A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            'The new workbook will have 3 worksheets

            'Get the path of the input file
            Dim inputPath As String = GetFullTemplatePath("monthly_sales.xls")

            'IWorkbook workbook = application.Workbooks.Create(3);
            Dim workbook As IWorkbook = application.Workbooks.Open(inputPath)

            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            ' Grouping by Rows
            worksheet.Range("C5:F7").Group(ExcelGroupBy.ByRows)

            ' Grouping by Columns
            worksheet.Range("C10:F10").Group(ExcelGroupBy.ByColumns)


            ' Hiding Sixth Column and tenth Row
            worksheet.ShowColumn(5, False)
            worksheet.ShowColumn(10, False)

            'Showing 28th row
            worksheet.ShowRow(28, True)

            'Deleting Row
            worksheet.DeleteRow(25)

            'Inserting Column
            worksheet.InsertColumn(7, 1, ExcelInsertOptions.FormatAsBefore)
            worksheet.Range("G4").Text = "Loss/Gain"

            'Deleting Column
            worksheet.DeleteColumn(8)

            ' Changing the Column Width
            worksheet.Range("D5").ColumnWidth = 15

            ' Changing the Row Height
            worksheet.Range("D29").RowHeight = 25

            'Set the default version as Excel 97to2003
            If Me.rdbExcel97.Checked Then
                workbook.Version = ExcelVersion.Excel97to2003
                fileName = "Sample.xls"
                'Set the default version as Excel 2007
            ElseIf Me.rdbExcel2007.Checked Then
                workbook.Version = ExcelVersion.Excel2007
                fileName = "Sample.xlsx"
                'Set the default version as Excel 2010
            ElseIf Me.rdbExcel2010.Checked Then
                workbook.Version = ExcelVersion.Excel2010
                fileName = "Sample.xlsx"
                'Set the default version as Excel 2013
            ElseIf Me.rdbExcel2013.Checked Then
                workbook.Version = ExcelVersion.Excel2013
                fileName = "Sample.xlsx"
            End If

            'Saving the workbook to disk.
            workbook.SaveAs(fileName)

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

#Region "View the Input Template"
        Private Sub viewInputTemplate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles viewInputTemplate.Click
            'Get the path of the Input File
            Dim inputPath As String = GetFullTemplatePath("monthly_sales.xls")
            'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath)
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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RowColumnManipulations))
            Me.Create = New System.Windows.Forms.Button
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.label2 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.rdbExcel2010 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2007 = New System.Windows.Forms.RadioButton
            Me.rdbExcel97 = New System.Windows.Forms.RadioButton
            Me.viewInputTemplate = New System.Windows.Forms.Button
            Me.rdbExcel2013 = New System.Windows.Forms.RadioButton
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'Create
            '
            Me.Create.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Create.BackColor = System.Drawing.Color.Transparent
            Me.Create.Image = CType(resources.GetObject("Create.Image"), System.Drawing.Image)
            Me.Create.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Create.Location = New System.Drawing.Point(69, 201)
            Me.Create.Name = "Create"
            Me.Create.Size = New System.Drawing.Size(85, 26)
            Me.Create.TabIndex = 0
            Me.Create.Text = "Create"
            Me.Create.UseVisualStyleBackColor = False
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
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
            Me.label2.Size = New System.Drawing.Size(372, 48)
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
            Me.groupBox1.Size = New System.Drawing.Size(335, 37)
            Me.groupBox1.TabIndex = 67
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
            'viewInputTemplate
            '
            Me.viewInputTemplate.Location = New System.Drawing.Point(176, 201)
            Me.viewInputTemplate.Name = "viewInputTemplate"
            Me.viewInputTemplate.Size = New System.Drawing.Size(100, 26)
            Me.viewInputTemplate.TabIndex = 68
            Me.viewInputTemplate.Text = "Input Template"
            Me.viewInputTemplate.UseVisualStyleBackColor = True
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
            'RowColumnManipulations
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(372, 237)
            Me.Controls.Add(Me.viewInputTemplate)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.Create)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimizeBox = False
            Me.Name = "RowColumnManipulations"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Row-Column Manipulations"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
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
            Application.Run(New RowColumnManipulations())
        End Sub
#End Region
    End Class
End Namespace
