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
    ''' A CalcWorkbook-derived object that uses XlsIO to read / compute Excel XLS files.
    ''' </summary>
    ''' 
    Public Class ComputeFormulas : Inherits System.Windows.Forms.Form

#Region "Fields"
        Private fileName As String
        Private WithEvents btnCreate As System.Windows.Forms.Button
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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

#Region "Compute Formulas"
        Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel
            Dim fileName As String
            Dim myWorkbook As IWorkbook = Nothing
            Dim worksheet As IWorksheet = Nothing

            myWorkbook = excelEngine.Excel.Workbooks.Open("..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\TimelogTemplate.xls")
            worksheet = myWorkbook.Worksheets(0)

            'Set the Default version as Excel 97to2003
            If Me.rdbExcel97.Checked Then
                myWorkbook.Version = ExcelVersion.Excel97to2003
                fileName = "ComputeFormulas.xls"
                'Set the Default version as Excel 2007
            ElseIf Me.rdbExcel2007.Checked Then
                myWorkbook.Version = ExcelVersion.Excel2007
                fileName = "ComputeFormulas.xlsx"
                'Set the Default version as Excel 2010
            ElseIf Me.rdbExcel2010.Checked Then
                myWorkbook.Version = ExcelVersion.Excel2010
                fileName = "ComputeFormulas.xlsx"
                'Set the Default version as Excel 2013
            ElseIf Me.rdbExcel2013.Checked Then
                myWorkbook.Version = ExcelVersion.Excel2013
                fileName = "ComputeFormulas.xlsx"
            End If

            'Enable to calculate formulas in the sheet.
            worksheet.EnableSheetCalculations()

            'hourly rate
            worksheet.Range("G7").Number = 11

            'overtime rate.
            worksheet.Range("J7").Formula = "=SUM(G7*1.5)"

            'Regular hours
            worksheet.Range("F10").Formula = "=IF((((C10-B10)+(E10-D10))*24)>8,8,((C10-B10)+(E10-D10))*24)"
            worksheet.Range("F11").Formula = "=IF((((C11-B11)+(E11-D11))*24)>8,8,((C11-B11)+(E11-D11))*24)"
            worksheet.Range("F12").Formula = "=IF((((C12-B12)+(E12-D12))*24)>8,8,((C12-B12)+(E12-D12))*24)"
            worksheet.Range("F13").Formula = "=IF((((C13-B13)+(E13-D13))*24)>8,8,((C13-B13)+(E13-D13))*24)"
            worksheet.Range("F14").Formula = "=IF((((C14-B14)+(E14-D14))*24)>8,8,((C14-B14)+(E14-D14))*24)"
            worksheet.Range("F15").Formula = "=IF((((C15-B15)+(E15-D15))*24)>8,8,((C15-B15)+(E15-D15))*24)"

            'overtime hours
            worksheet.Range("G10").Formula = "=IF(((C10-B10)+(E10-D10))*24>8, ((C10-B10)+(E10-D10))*24-8,0)"
            worksheet.Range("G11").Formula = "=IF(((C11-B11)+(E11-D11))*24>8, ((C11-B11)+(E11-D11))*24-8,0)"
            worksheet.Range("G12").Formula = "=IF(((C12-B12)+(E12-D12))*24>8, ((C12-B12)+(E12-D12))*24-8,0)"
            worksheet.Range("G13").Formula = "=IF(((C13-B13)+(E13-D13))*24>8, ((C13-B13)+(E13-D13))*24-8,0)"
            worksheet.Range("G14").Formula = "=IF(((C14-B14)+(E14-D14))*24>8, ((C14-B14)+(E14-D14))*24-8,0)"
            worksheet.Range("G15").Formula = "=IF(((C15-B15)+(E15-D15))*24>8, ((C15-B15)+(E15-D15))*24-8,0)"

            'regular pay
            worksheet.Range("H10").Formula = "=SUM(F10*G7)"
            worksheet.Range("H11").Formula = "=SUM(F11*G7)"
            worksheet.Range("H12").Formula = "=SUM(F12*G7)"
            worksheet.Range("H13").Formula = "=SUM(F13*G7)"
            worksheet.Range("H14").Formula = "=SUM(F14*G7)"
            worksheet.Range("H15").Formula = "=SUM(F15*G7)"

            'overtime pay
            worksheet.Range("I10").Formula = "=SUM(G10*J7)"
            worksheet.Range("I11").Formula = "=SUM(G11*J7)"
            worksheet.Range("I12").Formula = "=SUM(G12*J7)"
            worksheet.Range("I13").Formula = "=SUM(G13*J7)"
            worksheet.Range("I14").Formula = "=SUM(G14*J7)"
            worksheet.Range("I15").Formula = "=SUM(G15*J7)"

            'total pay
            worksheet.Range("J10").Formula = "=SUM(H10+I10)"
            worksheet.Range("J11").Formula = "=SUM(H11+I11)"
            worksheet.Range("J12").Formula = "=SUM(H12+I12)"
            worksheet.Range("J13").Formula = "=SUM(H13+I13)"
            worksheet.Range("J14").Formula = "=SUM(H14+I14)"
            worksheet.Range("J15").Formula = "=SUM(H15+I15)"

            'total regular hours
            worksheet.Range("F17").Formula = "=SUM(F10:F15)"

            'total overtime hours
            worksheet.Range("G17").Formula = "=SUM(G10:G15)"

            'total regular pay
            worksheet.Range("H17").Formula = "=SUM(H10:H15)"

            'total overtime pay
            worksheet.Range("I17").Formula = "=SUM(I10:I15)"

            'total pay
            worksheet.Range("J17").Formula = "=SUM(J10:J15)"

            'consolidated pay
            worksheet.Range("C20").Formula = "=J17"

            'allowance
            worksheet.Range("C21").Number = 20

            'PF
            worksheet.Range("C22").Number = 38

            'Net pay
            worksheet.Range("C24").Formula = "=SUM(C20:C21)-C22"

            'Saving the workbook to disk.
            myWorkbook.SaveAs(fileName)

            'Close the workbook.
            myWorkbook.Close()

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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComputeFormulas))
            Me.btnCreate = New System.Windows.Forms.Button
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.label2 = New System.Windows.Forms.Label
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.rdbExcel2010 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2007 = New System.Windows.Forms.RadioButton
            Me.rdbExcel97 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2013 = New System.Windows.Forms.RadioButton
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
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
            Me.btnCreate.TabIndex = 2
            Me.btnCreate.Text = "Create"
            Me.btnCreate.UseVisualStyleBackColor = False
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(75, -4)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(372, 96)
            Me.pictureBox1.TabIndex = 63
            Me.pictureBox1.TabStop = False
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
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.rdbExcel2013)
            Me.GroupBox1.Controls.Add(Me.rdbExcel2010)
            Me.GroupBox1.Controls.Add(Me.rdbExcel2007)
            Me.GroupBox1.Controls.Add(Me.rdbExcel97)
            Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(12, 158)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(327, 37)
            Me.GroupBox1.TabIndex = 65
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Save As"
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
            Me.rdbExcel2013.Location = New System.Drawing.Point(243, 13)
            Me.rdbExcel2013.Name = "rdbExcel2013"
            Me.rdbExcel2013.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2013.TabIndex = 3
            Me.rdbExcel2013.Text = "Excel 2013"
            Me.rdbExcel2013.UseVisualStyleBackColor = True
            '
            'PictureBox2
            '
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(-6, -16)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(110, 96)
            Me.PictureBox2.TabIndex = 66
            Me.PictureBox2.TabStop = False
            '
            'ComputeFormulas
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(446, 208)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.btnCreate)
            Me.Name = "ComputeFormulas"
            Me.Text = "Compute All Formulas"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
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



        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New ComputeFormulas())
        End Sub
#End Region

    End Class
End Namespace





