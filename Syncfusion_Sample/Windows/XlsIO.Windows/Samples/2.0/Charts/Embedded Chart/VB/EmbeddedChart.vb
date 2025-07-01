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
    Public Class EmbeddedChart : Inherits System.Windows.Forms.Form

#Region "Constants"
        Private Const DEFAULTPATH As String = "..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}"
#End Region

#Region "Fields"
        Private WithEvents btnCreate As System.Windows.Forms.Button
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private fileName As String
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents rdbExcel2010 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExcel2007 As System.Windows.Forms.RadioButton
        Friend WithEvents rdbExcel97 As System.Windows.Forms.RadioButton
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

#Region "Create Embedded Chart"
        Private Sub btncreate_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreate.Click
            'Instantiate the spreadsheet creation engine.
            Dim excelEngine As ExcelEngine = New ExcelEngine()

            'A new workbook is created.[Equivalent to creating a new workbook in MS Excel]
            'Open workbook with Data
            Dim workbook As IWorkbook
            If (rdbExcel97.Checked) Then
                Dim inputPath As String = GetTemplatePath("EmbeddedChart.xls")
                workbook = excelEngine.Excel.Workbooks.Open(inputPath)
            Else
                Dim inputPath As String = GetTemplatePath("EmbeddedChart.xlsx")
                workbook = excelEngine.Excel.Workbooks.Open(inputPath, ExcelOpenType.Automatic)
            End If

            'The first worksheet object in the worksheets collection is accessed.
            Dim worksheet As IWorksheet = workbook.Worksheets(0)


            'The first worksheet object in the worksheets collection is accessed.
            Dim sheet As IWorksheet = workbook.Worksheets(0)
            sheet.Name = "EmbeddedChart"

            ' Adding a New chart to the Existing Worksheet   
            Dim chart As IChartShape = workbook.Worksheets(0).Charts.Add()


            chart.DataRange = worksheet.Range("A3:C15")
            chart.ChartTitle = "Crescent City, CA"
            chart.IsSeriesInRows = False

            chart.PrimaryValueAxis.Title = "Precipitation,in."
            chart.PrimaryValueAxis.TitleArea.TextRotationAngle = 90
            chart.PrimaryValueAxis.MaximumValue = 14.0
            chart.PrimaryValueAxis.NumberFormat = "0.0"

            chart.PrimaryCategoryAxis.Title = "Month"

            Dim serieOne As IChartSerie = chart.Series(0)

            'set the Chart Type
            chart.ChartType = ExcelChartType.Column_Clustered_3D

            'set the Backwall fill option
            chart.BackWall.Fill.FillType = ExcelFillType.Gradient

            'set the Texture Type
            chart.BackWall.Fill.GradientColorType = ExcelGradientColor.TwoColor
            chart.BackWall.Fill.GradientStyle = ExcelGradientStyle.Diagonl_Down
            chart.BackWall.Fill.ForeColor = System.Drawing.Color.WhiteSmoke
            chart.BackWall.Fill.BackColor = System.Drawing.Color.LightBlue

            'set the Border Linecolor 
            chart.BackWall.Border.LineColor = System.Drawing.Color.Wheat

            'set the Picture Type     
            chart.BackWall.PictureUnit = ExcelChartPictureType.stretch

            'set the Backwall thickness
            chart.BackWall.Thickness = 10

            'set the sidewall fill option
            chart.SideWall.Fill.FillType = ExcelFillType.SolidColor

            'set the sidewall foreground and backcolor
            chart.SideWall.Fill.BackColor = System.Drawing.Color.White
            chart.SideWall.Fill.ForeColor = System.Drawing.Color.White

            'set the side wall Border color
            chart.SideWall.Border.LineColor = System.Drawing.Color.Beige

            'set floor fill option
            chart.Floor.Fill.FillType = ExcelFillType.Pattern

            'set the floor pattern Type
            chart.Floor.Fill.Pattern = ExcelGradientPattern.Pat_Divot

            'Set the floor fore and Back ground color
            chart.Floor.Fill.ForeColor = System.Drawing.Color.Blue
            chart.Floor.Fill.BackColor = System.Drawing.Color.White

            'set the floor thickness
            chart.Floor.Thickness = 3

            Dim serieTwo As IChartSerie = chart.Series(1)
            'Show value as data labels
            serieOne.DataPoints.DefaultDataPoint.DataLabels.IsValue = True
            serieTwo.DataPoints.DefaultDataPoint.DataLabels.IsValue = True

            'Embedded Chart Position
            chart.TopRow = 2
            chart.BottomRow = 30
            chart.LeftColumn = 5
            chart.RightColumn = 18
            serieTwo.Name = "Temperature,deg.F"

            ' Legend setting
            chart.Legend.Position = ExcelLegendPosition.Right
            chart.Legend.IsVerticalLegend = False

            'chart.Scale(50, 50);
            'Set the Workbook version as Excel 97to2003
            If Me.rdbExcel97.Checked Then
                workbook.Version = ExcelVersion.Excel97to2003
                fileName = "EmbeddedChart.xls"
                'Set the Workbook version as Excel 2007
            ElseIf Me.rdbExcel2007.Checked Then
                workbook.Version = ExcelVersion.Excel2007
                fileName = "EmbeddedChart.xlsx"
                'Set the Workbook version as Excel 2010
            ElseIf Me.rdbExcel2010.Checked Then
                workbook.Version = ExcelVersion.Excel2010
                fileName = "EmbeddedChart.xlsx"
                'Set the Workbook version as Excel 2013
            ElseIf Me.rdbExcel2013.Checked Then
                workbook.Version = ExcelVersion.Excel2013
                fileName = "EmbeddedChart.xlsx"
                chart.Series(0).IsFiltered = True
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmbeddedChart))
            Me.btnCreate = New System.Windows.Forms.Button()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.rdbExcel2010 = New System.Windows.Forms.RadioButton()
            Me.rdbExcel2007 = New System.Windows.Forms.RadioButton()
            Me.rdbExcel97 = New System.Windows.Forms.RadioButton()
            Me.rdbExcel2013 = New System.Windows.Forms.RadioButton()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'btnCreate
            '
            Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnCreate.BackColor = System.Drawing.Color.Transparent
            Me.btnCreate.Image = CType(resources.GetObject("btnCreate.Image"), System.Drawing.Image)
            Me.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnCreate.Location = New System.Drawing.Point(368, 165)
            Me.btnCreate.Name = "btnCreate"
            Me.btnCreate.Size = New System.Drawing.Size(85, 26)
            Me.btnCreate.TabIndex = 0
            Me.btnCreate.Text = "Create"
            Me.btnCreate.UseVisualStyleBackColor = False
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(465, 96)
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
            Me.GroupBox1.Size = New System.Drawing.Size(333, 37)
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
            Me.rdbExcel2010.TabStop = True
            Me.rdbExcel2010.Text = "Excel 2010"
            Me.rdbExcel2010.UseVisualStyleBackColor = True
            '
            'rdbExcel2007
            '
            Me.rdbExcel2007.AutoSize = True
            Me.rdbExcel2007.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.rdbExcel2007.Location = New System.Drawing.Point(84, 13)
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
            Me.rdbExcel2013.Location = New System.Drawing.Point(248, 12)
            Me.rdbExcel2013.Name = "rdbExcel2013"
            Me.rdbExcel2013.Size = New System.Drawing.Size(78, 17)
            Me.rdbExcel2013.TabIndex = 3
            Me.rdbExcel2013.TabStop = True
            Me.rdbExcel2013.Text = "Excel 2013"
            Me.rdbExcel2013.UseVisualStyleBackColor = True
            '
            'EmbeddedChart
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(465, 214)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.btnCreate)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "EmbeddedChart"
            Me.Text = "Embedded Chart"
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
            Application.EnableVisualStyles()
            Application.Run(New EmbeddedChart())
        End Sub
#End Region
    End Class
End Namespace
