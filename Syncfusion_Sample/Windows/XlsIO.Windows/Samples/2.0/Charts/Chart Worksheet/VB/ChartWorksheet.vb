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
    Public Class ChartWorksheet : Inherits System.Windows.Forms.Form

#Region "Fields"
        Private WithEvents btnCreate As System.Windows.Forms.Button
        Private WithEvents pictureBox4 As System.Windows.Forms.PictureBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private fileName As String
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbExcel2010 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExcel2007 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExcel97 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExcel2013 As System.Windows.Forms.RadioButton
        Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox

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

#Region "Create Chartsheet"
        Private Sub btnCreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click
            'New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            'The instantiation process consists of two steps.

            'Step 1 : Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()
            'Step 2 : Instantiate the excel application object.
            Dim application As IApplication = excelEngine.Excel

            'Set the application default version as Excel97to2003
            If Me.rdbExcel97.Checked Then
                application.DefaultVersion = ExcelVersion.Excel97to2003
                fileName = "ChartWorksheet.xls"
                'Set the default version as Excel 2007;
            ElseIf Me.rdbExcel2007.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2007
                fileName = "ChartWorksheet.xlsx"
                'Set the default version as Excel 2010;
            ElseIf Me.rdbExcel2010.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2010
                fileName = "ChartWorksheet.xlsx"
                'Set the default version as Excel 2013
            ElseIf Me.rdbExcel2013.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2013
                fileName = "ChartWorksheet.xlsx"
            ElseIf Me.rdbExcel2013.Checked Then
                application.DefaultVersion = ExcelVersion.Excel2013
                fileName = "ChartWorksheet.xlsx"
            End If
            'A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            'The new workbook will have 1 worksheet.
            Dim workbook As IWorkbook = application.Workbooks.Create(1)
            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)

            ' Entering the Datas for the chart
            worksheet.Range("A1").Text = "Crescent City, CA"
            worksheet.Range("A1:D1").Merge()
            worksheet.Range("A1").CellStyle.Font.Bold = True

            worksheet.Range("B3").Text = "Precipitation,in."
            worksheet.Range("C3").Text = "Temperature,deg.F"

            worksheet.Range("A4").Text = "Jan"
            worksheet.Range("A5").Text = "Feb"
            worksheet.Range("A6").Text = "March"
            worksheet.Range("A7").Text = "Apr"
            worksheet.Range("A8").Text = "May"
            worksheet.Range("A9").Text = "June"
            worksheet.Range("A10").Text = "July"
            worksheet.Range("A11").Text = "Aug"
            worksheet.Range("A12").Text = "Sept"
            worksheet.Range("A13").Text = "Oct"
            worksheet.Range("A14").Text = "Nov"
            worksheet.Range("A15").Text = "Dec"

            worksheet.Range("B4").Number = 10.9
            worksheet.Range("B5").Number = 8.9
            worksheet.Range("B6").Number = 8.6
            worksheet.Range("B7").Number = 4.8
            worksheet.Range("B8").Number = 3.2
            worksheet.Range("B9").Number = 1.4
            worksheet.Range("B10").Number = 0.6
            worksheet.Range("B11").Number = 0.7
            worksheet.Range("B12").Number = 1.7
            worksheet.Range("B13").Number = 5.4
            worksheet.Range("B14").Number = 9.0
            worksheet.Range("B15").Number = 10.4

            worksheet.Range("C4").Number = 47.5
            worksheet.Range("C5").Number = 48.7
            worksheet.Range("C6").Number = 48.9
            worksheet.Range("C7").Number = 50.2
            worksheet.Range("C8").Number = 53.1
            worksheet.Range("C9").Number = 56.3
            worksheet.Range("C10").Number = 58.1
            worksheet.Range("C11").Number = 59.0
            worksheet.Range("C12").Number = 58.5
            worksheet.Range("C13").Number = 55.4
            worksheet.Range("C14").Number = 51.1
            worksheet.Range("C15").Number = 47.8
            worksheet.UsedRange.AutofitColumns()

            ' Adding a New chart to the Existing Worksheet   
            Dim chart As IChart = workbook.Charts.Add()
            chart.DataRange = worksheet.Range("A3:C15")
            chart.Name = "CrescentCity,CA"
            chart.ChartTitle = "Crescent City, CA"
            chart.IsSeriesInRows = False

            chart.PrimaryValueAxis.Title = "Precipitation,in."
            chart.PrimaryValueAxis.TitleArea.TextRotationAngle = 90
            chart.PrimaryValueAxis.MaximumValue = 14.0
            chart.PrimaryValueAxis.NumberFormat = "0.0"
            ' Format serie
            Dim serieOne As IChartSerie = chart.Series(0)
            serieOne.Name = "Precipitation,in."
            serieOne.SerieFormat.Fill.FillType = ExcelFillType.Gradient
            serieOne.SerieFormat.Fill.TwoColorGradient(ExcelGradientStyle.Vertical, ExcelGradientVariants.ShadingVariants_2)
            serieOne.SerieFormat.Fill.GradientColorType = ExcelGradientColor.TwoColor
            serieOne.SerieFormat.Fill.ForeColor = Color.Plum

            'Show value as data labels
            serieOne.DataPoints.DefaultDataPoint.DataLabels.IsValue = True
            serieOne.DataPoints.DefaultDataPoint.DataLabels.Position = ExcelDataLabelPosition.Outside

            'Format the second serie
            Dim serieTwo As IChartSerie = chart.Series(1)
            serieTwo.SerieType = ExcelChartType.Line_Markers
            serieTwo.Name = "Temperature,deg.F"

            'Format marker
            serieTwo.SerieFormat.MarkerStyle = ExcelChartMarkerType.Diamond
            serieTwo.SerieFormat.MarkerSize = 8
            serieTwo.SerieFormat.MarkerBackgroundColor = Color.DarkGreen
            serieTwo.SerieFormat.MarkerForegroundColor = Color.DarkGreen
            serieTwo.SerieFormat.LineProperties.LineColor = Color.DarkGreen

            'Use Secondary Axis
            serieTwo.UsePrimaryAxis = False

            'Display secondary axis for the series.
            chart.SecondaryCategoryAxis.IsMaxCross = True
            chart.SecondaryValueAxis.IsMaxCross = True

            'Set the title
            chart.SecondaryValueAxis.Title = "Temperature,deg.F"
            chart.SecondaryValueAxis.TitleArea.TextRotationAngle = 90

            'Hide the secondary category axis
            chart.SecondaryCategoryAxis.Border.LineColor = Color.Transparent
            chart.SecondaryCategoryAxis.MajorTickMark = ExcelTickMark.TickMark_None
            chart.SecondaryCategoryAxis.TickLabelPosition = ExcelTickLabelPosition.TickLabelPosition_None

            'Set the title
            chart.SecondaryValueAxis.Title = "Temperature,deg.F"
            chart.SecondaryValueAxis.TitleArea.TextRotationAngle = 90
            chart.SecondaryCategoryAxis.Border.LineColor = Color.Transparent

            chart.Legend.Position = ExcelLegendPosition.Bottom
            chart.Legend.IsVerticalLegend = False

            worksheet.Move(1)
            chart.Activate()

            'Excel2013 Filter Enabled
            If Me.rdbExcel2013.Checked Then
                chart.Series(1).IsFiltered = True
                chart.Categories(0).IsFiltered = True
                chart.Categories(1).IsFiltered = True
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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChartWorksheet))
            Me.btnCreate = New System.Windows.Forms.Button
            Me.pictureBox4 = New System.Windows.Forms.PictureBox
            Me.label2 = New System.Windows.Forms.Label
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.rdbExcel2013 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2010 = New System.Windows.Forms.RadioButton
            Me.rdbExcel2007 = New System.Windows.Forms.RadioButton
            Me.rdbExcel97 = New System.Windows.Forms.RadioButton
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnCreate
            '
            Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
            Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCreate.Location = New System.Drawing.Point(345, 166)
            Me.btnCreate.Name = "btnCreate"
            Me.btnCreate.Size = New System.Drawing.Size(85, 26)
            Me.btnCreate.TabIndex = 0
            Me.btnCreate.Text = "Create"
            '
            'pictureBox4
            '
            Me.pictureBox4.Image = CType(resources.GetObject("pictureBox4.Image"), System.Drawing.Image)
            Me.pictureBox4.Location = New System.Drawing.Point(70, 0)
            Me.pictureBox4.Name = "pictureBox4"
            Me.pictureBox4.Size = New System.Drawing.Size(478, 96)
            Me.pictureBox4.TabIndex = 71
            Me.pictureBox4.TabStop = False
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 109)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(442, 48)
            Me.label2.TabIndex = 72
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
            Me.GroupBox1.Size = New System.Drawing.Size(326, 37)
            Me.GroupBox1.TabIndex = 73
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Save As"
            '
            'rdbExcel2013
            '
            Me.rdbExcel2013.AutoSize = True
            Me.rdbExcel2013.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbExcel2013.Location = New System.Drawing.Point(239, 13)
            Me.rdbExcel2013.Name = "rdbExcel2013"
            Me.rdbExcel2013.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2013.TabIndex = 3
            Me.rdbExcel2013.Text = "Excel 2013"
            Me.rdbExcel2013.UseVisualStyleBackColor = True
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
            'PictureBox1
            '
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(-6, -11)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(121, 96)
            Me.PictureBox1.TabIndex = 74
            Me.PictureBox1.TabStop = False
            '
            'ChartWorksheet
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(442, 208)
            Me.Controls.Add(Me.pictureBox4)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.btnCreate)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "ChartWorksheet"
            Me.Text = "Chart Worksheet"
            CType(Me.pictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
            Application.Run(New ChartWorksheet())
        End Sub
#End Region

    End Class
End Namespace
