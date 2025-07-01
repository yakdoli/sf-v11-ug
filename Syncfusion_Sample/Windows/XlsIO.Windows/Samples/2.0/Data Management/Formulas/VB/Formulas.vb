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
    Public Class Formulas : Inherits System.Windows.Forms.Form

#Region "Constants"
        Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Fields"
        Private WithEvents btnWriteFormulas As System.Windows.Forms.Button
        Private WithEvents btnReadFormulas As Button
        Private txtCompute As TextBox
        Private label2 As Label
        Private groupBox1 As GroupBox
        Private txtFormula As TextBox
        Private label3 As Label
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox

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
            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub
#End Region

#Region "Write Formulas"
        Private Sub btnWriteFormulas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnWriteFormulas.Click
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            'A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            'The new workbook will have 3 worksheets
            Dim workbook As IWorkbook = application.Workbooks.Create(3)
            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            worksheet.Range("A2").Text = "Array formulas"
            worksheet.Range("B2:E2").FormulaArray = "{10,20,30,40}"
            worksheet.Names.Add("ArrayRange", worksheet.Range("B2:E2"))
            worksheet.Range("B3:E3").FormulaArray = "ArrayRange+100"
            worksheet.Range("A2").CellStyle.Font.Bold = True
            worksheet.Range("A2").CellStyle.Font.Size = 14

            worksheet.Range("A5").Text = "Formula"
            worksheet.Range("B5").Text = "Result"

            worksheet.Range("A7").Text = "ABS(ABS(-B3))"
            worksheet.Range("B7").Formula = "ABS(ABS(-B3))"

            worksheet.Range("A9").Text = "SUM(B3,C3)"
            worksheet.Range("B9").Formula = "SUM(B3,C3)"

            worksheet.Range("A11").Text = "MIN({10,20,30;5,15,35;6,16,36})"
            worksheet.Range("B11").Formula = "MIN({10,20,30;5,15,35;6,16,36})"

            worksheet.Range("A13").Text = "LOOKUP(B3,B3:E8)"
            worksheet.Range("B13").Formula = "LOOKUP(B3,B3:E3)"

            worksheet.Range("A5:B5").CellStyle.Font.Bold = True
            worksheet.Range("A5:B5").CellStyle.Font.Size = 14

            worksheet.Range("C7").Number = 10
            worksheet.Range("C9").Number = 10
            worksheet.Range("A15").Text = "C7+C9"
            worksheet.Range("B15").Formula = "C7+C9"

            worksheet.Range("B1").Text = "Excel formula support"
            worksheet.Range("B1").CellStyle.Font.Bold = True
            worksheet.Range("B1").CellStyle.Font.Size = 14
            worksheet.Range("B1:E1").Merge()
            worksheet.Range("A1:A15").AutofitColumns()

            'Saving the workbook to disk.
            workbook.SaveAs("WriteFormulas.xls")

            btnReadFormulas.Enabled = True
            'Close the workbook.
            workbook.Close()

            'No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = False
            excelEngine.Dispose()

            'Message box confirmation to view the created spreadsheet.
            If MessageBox.Show("Do you want to view the workbook?", "Workbook has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start("WriteFormulas.xls")

            End If


        End Sub
#End Region

#Region "Read Formulas"
        Private Sub btnReadFormulas_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReadFormulas.Click
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            'Get the Path of Input File
            Dim inputPath As String = GetFullTemplatePath("FormulaTemplate.xls")
            'Open the workbook
            Dim workbook As IWorkbook = application.Workbooks.Open(inputPath)

            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            'Read computed Formula Value. 
            Me.txtCompute.Text = worksheet.Range("C1").FormulaNumberValue.ToString()

            'Read Formula
            Me.txtFormula.Text = worksheet.Range("C1").Formula

            'Close the workbook.
            workbook.Close()

            'No exception will be thrown if there are unsaved workbooks.
            excelEngine.ThrowNotSavedOnDestroy = False
            excelEngine.Dispose()

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formulas))
            Me.btnWriteFormulas = New System.Windows.Forms.Button
            Me.btnReadFormulas = New System.Windows.Forms.Button
            Me.txtCompute = New System.Windows.Forms.TextBox
            Me.label2 = New System.Windows.Forms.Label
            Me.groupBox1 = New System.Windows.Forms.GroupBox
            Me.txtFormula = New System.Windows.Forms.TextBox
            Me.label3 = New System.Windows.Forms.Label
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.groupBox1.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnWriteFormulas
            '
            Me.btnWriteFormulas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnWriteFormulas.Image = CType(resources.GetObject("btnWriteFormulas.Image"), System.Drawing.Image)
            Me.btnWriteFormulas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnWriteFormulas.Location = New System.Drawing.Point(234, 207)
            Me.btnWriteFormulas.Name = "btnWriteFormulas"
            Me.btnWriteFormulas.Size = New System.Drawing.Size(106, 26)
            Me.btnWriteFormulas.TabIndex = 0
            Me.btnWriteFormulas.Text = "Write Formula"
            '
            'btnReadFormulas
            '
            Me.btnReadFormulas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnReadFormulas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnReadFormulas.Image = CType(resources.GetObject("btnReadFormulas.Image"), System.Drawing.Image)
            Me.btnReadFormulas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnReadFormulas.Location = New System.Drawing.Point(222, 51)
            Me.btnReadFormulas.Name = "btnReadFormulas"
            Me.btnReadFormulas.Size = New System.Drawing.Size(106, 23)
            Me.btnReadFormulas.TabIndex = 2
            Me.btnReadFormulas.Text = "Read Formula"
            '
            'txtCompute
            '
            Me.txtCompute.Location = New System.Drawing.Point(96, 26)
            Me.txtCompute.Name = "txtCompute"
            Me.txtCompute.Size = New System.Drawing.Size(122, 20)
            Me.txtCompute.TabIndex = 3
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(6, 29)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(84, 13)
            Me.label2.TabIndex = 4
            Me.label2.Text = "Computed value"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.txtFormula)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.txtCompute)
            Me.groupBox1.Controls.Add(Me.btnReadFormulas)
            Me.groupBox1.Location = New System.Drawing.Point(12, 113)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(334, 80)
            Me.groupBox1.TabIndex = 5
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Read Formula from Template document"
            '
            'txtFormula
            '
            Me.txtFormula.Location = New System.Drawing.Point(96, 54)
            Me.txtFormula.Name = "txtFormula"
            Me.txtFormula.Size = New System.Drawing.Size(122, 20)
            Me.txtFormula.TabIndex = 6
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(6, 57)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(74, 13)
            Me.label3.TabIndex = 5
            Me.label3.Text = "Formula String"
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(372, 97)
            Me.pictureBox1.TabIndex = 63
            Me.pictureBox1.TabStop = False
            '
            'Formulas
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(372, 238)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.btnWriteFormulas)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimizeBox = False
            Me.Name = "Formulas"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Formulas"
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
            Application.Run(New Formulas())
        End Sub
#End Region
    End Class
End Namespace
