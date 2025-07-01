#Region "Copyright Syncfusion Inc. 2001 - 2005"
'
'  Copyright Syncfusion Inc. 2001 - 2005. All rights reserved.
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
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.Windows.Forms.Chart
Imports Syncfusion.XlsIO
Imports Syncfusion.Pdf
Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS
Imports Syncfusion.Drawing
Imports Syncfusion.Pdf.Graphics

Namespace ChartExportData

	Public Class Form1
		Inherits Syncfusion.Windows.Forms.Office2007Form
		#Region "Private Members"
		Public chartControl1 As Syncfusion.Windows.Forms.Chart.ChartControl
		Private fileName As String
		Private exportFileName As String = Nothing
		Private gridForm As Form2
		Private statusStrip1 As StatusStrip
		Private toolStripStatusLabel1 As ToolStripStatusLabel
		Private WithEvents buttonDocIO As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonPdf As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonXLsIO As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonImage As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonSVG As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonEmf As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonAdv2 As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonGrid As Syncfusion.Windows.Forms.ButtonAdv
		Private WithEvents buttonPrint As Syncfusion.Windows.Forms.ButtonAdv
		Private color1 As Color() = New Color() { Color.FromArgb(141, 100, 170), Color.FromArgb(200, 170, 222), Color.FromArgb(141, 100, 170) }
		Private color2 As Color() = New Color() { Color.FromArgb(223, 111, 39), Color.FromArgb(251, 169, 113), Color.FromArgb(223, 111, 39) }
		Private toolTip1 As ToolTip
		Private label32 As Label
		Private components As IContainer
		#End Region

		#Region "Form's Constructor, Main and Dispose"
		Public Sub New()
            InitializeComponent()
		End Sub
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If Not components Is Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
		 #End Region    

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.chartControl1 = New Syncfusion.Windows.Forms.Chart.ChartControl
            Me.statusStrip1 = New System.Windows.Forms.StatusStrip
            Me.toolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
            Me.buttonDocIO = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonPdf = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonXLsIO = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonImage = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonSVG = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonEmf = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonAdv2 = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonGrid = New Syncfusion.Windows.Forms.ButtonAdv
            Me.buttonPrint = New Syncfusion.Windows.Forms.ButtonAdv
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.label32 = New System.Windows.Forms.Label
            Me.statusStrip1.SuspendLayout()
            Me.SuspendLayout()
            '
            'chartControl1
            '
            Me.chartControl1.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.White)
            Me.chartControl1.ChartArea.BorderColor = System.Drawing.Color.Black
            Me.chartControl1.ChartArea.BorderWidth = 2
            Me.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide
            Me.chartControl1.ChartAreaMargins = New Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10)
            Me.chartControl1.ChartInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(243, Byte), Integer)))
            '
            '
            '
            Me.chartControl1.Legend.BackInterior = New Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(226, Byte), Integer)))
            Me.chartControl1.Legend.Font = New System.Drawing.Font("Verdana", 10.0!)
            Me.chartControl1.Legend.Location = New System.Drawing.Point(59, 283)
            Me.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal
            Me.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom
            Me.chartControl1.Location = New System.Drawing.Point(19, 22)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.Size = New System.Drawing.Size(491, 361)
            Me.chartControl1.TabIndex = 0
            Me.chartControl1.Text = "chartControl1"
            '
            '
            '
            Me.chartControl1.Title.Name = "Def_title"
            Me.chartControl1.Title.Text = "chartControl1"
            Me.chartControl1.Titles.Add(Me.chartControl1.Title)
            '
            'statusStrip1
            '
            Me.statusStrip1.BackColor = System.Drawing.Color.White
            Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripStatusLabel1})
            Me.statusStrip1.Location = New System.Drawing.Point(0, 474)
            Me.statusStrip1.Name = "statusStrip1"
            Me.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode
            Me.statusStrip1.Size = New System.Drawing.Size(524, 22)
            Me.statusStrip1.TabIndex = 3
            Me.statusStrip1.Text = "statusStrip1"
            '
            'toolStripStatusLabel1
            '
            Me.toolStripStatusLabel1.Name = "toolStripStatusLabel1"
            Me.toolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
            '
            'buttonDocIO
            '
            Me.buttonDocIO.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonDocIO.Image = CType(resources.GetObject("buttonDocIO.Image"), System.Drawing.Image)
            Me.buttonDocIO.KeepFocusRectangle = False
            Me.buttonDocIO.Location = New System.Drawing.Point(177, 402)
            Me.buttonDocIO.Name = "buttonDocIO"
            Me.buttonDocIO.Size = New System.Drawing.Size(50, 50)
            Me.buttonDocIO.TabIndex = 4
            Me.buttonDocIO.Tag = "Check"
            Me.buttonDocIO.UseVisualStyle = True
            '
            'buttonPdf
            '
            Me.buttonPdf.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonPdf.Image = CType(resources.GetObject("buttonPdf.Image"), System.Drawing.Image)
            Me.buttonPdf.KeepFocusRectangle = False
            Me.buttonPdf.Location = New System.Drawing.Point(230, 402)
            Me.buttonPdf.Name = "buttonPdf"
            Me.buttonPdf.Size = New System.Drawing.Size(50, 50)
            Me.buttonPdf.TabIndex = 5
            Me.buttonPdf.Tag = "Check"
            Me.buttonPdf.UseVisualStyle = True
            '
            'buttonXLsIO
            '
            Me.buttonXLsIO.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonXLsIO.Image = CType(resources.GetObject("buttonXLsIO.Image"), System.Drawing.Image)
            Me.buttonXLsIO.KeepFocusRectangle = False
            Me.buttonXLsIO.Location = New System.Drawing.Point(283, 402)
            Me.buttonXLsIO.Name = "buttonXLsIO"
            Me.buttonXLsIO.Size = New System.Drawing.Size(50, 50)
            Me.buttonXLsIO.TabIndex = 6
            Me.buttonXLsIO.Tag = "Check"
            Me.buttonXLsIO.UseVisualStyle = True
            '
            'buttonImage
            '
            Me.buttonImage.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonImage.Image = CType(resources.GetObject("buttonImage.Image"), System.Drawing.Image)
            Me.buttonImage.KeepFocusRectangle = False
            Me.buttonImage.Location = New System.Drawing.Point(71, 402)
            Me.buttonImage.Name = "buttonImage"
            Me.buttonImage.Size = New System.Drawing.Size(50, 50)
            Me.buttonImage.TabIndex = 7
            Me.buttonImage.UseVisualStyle = True
            '
            'buttonSVG
            '
            Me.buttonSVG.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonSVG.Image = CType(resources.GetObject("buttonSVG.Image"), System.Drawing.Image)
            Me.buttonSVG.KeepFocusRectangle = False
            Me.buttonSVG.Location = New System.Drawing.Point(124, 402)
            Me.buttonSVG.Name = "buttonSVG"
            Me.buttonSVG.Size = New System.Drawing.Size(50, 50)
            Me.buttonSVG.TabIndex = 8
            Me.buttonSVG.UseVisualStyle = True
            '
            'buttonEmf
            '
            Me.buttonEmf.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonEmf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.buttonEmf.Image = CType(resources.GetObject("buttonEmf.Image"), System.Drawing.Image)
            Me.buttonEmf.KeepFocusRectangle = False
            Me.buttonEmf.Location = New System.Drawing.Point(18, 402)
            Me.buttonEmf.Name = "buttonEmf"
            Me.buttonEmf.Size = New System.Drawing.Size(50, 50)
            Me.buttonEmf.TabIndex = 9
            Me.buttonEmf.UseVisualStyle = True
            '
            'buttonAdv2
            '
            Me.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonAdv2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.buttonAdv2.Image = CType(resources.GetObject("buttonAdv2.Image"), System.Drawing.Image)
            Me.buttonAdv2.KeepFocusRectangle = False
            Me.buttonAdv2.Location = New System.Drawing.Point(336, 402)
            Me.buttonAdv2.Name = "buttonAdv2"
            Me.buttonAdv2.Size = New System.Drawing.Size(50, 50)
            Me.buttonAdv2.TabIndex = 10
            Me.buttonAdv2.UseVisualStyle = True
            '
            'buttonGrid
            '
            Me.buttonGrid.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.buttonGrid.Image = CType(resources.GetObject("buttonGrid.Image"), System.Drawing.Image)
            Me.buttonGrid.KeepFocusRectangle = False
            Me.buttonGrid.Location = New System.Drawing.Point(389, 402)
            Me.buttonGrid.Name = "buttonGrid"
            Me.buttonGrid.Size = New System.Drawing.Size(50, 50)
            Me.buttonGrid.TabIndex = 11
            Me.buttonGrid.UseVisualStyle = True
            '
            'buttonPrint
            '
            Me.buttonPrint.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007
            Me.buttonPrint.Image = CType(resources.GetObject("buttonPrint.Image"), System.Drawing.Image)
            Me.buttonPrint.KeepFocusRectangle = False
            Me.buttonPrint.Location = New System.Drawing.Point(448, 402)
            Me.buttonPrint.Name = "buttonPrint"
            Me.buttonPrint.Size = New System.Drawing.Size(50, 50)
            Me.buttonPrint.TabIndex = 13
            Me.toolTip1.SetToolTip(Me.buttonPrint, "Print Chart")
            Me.buttonPrint.UseVisualStyle = True
            '
            'label32
            '
            Me.label32.Image = CType(resources.GetObject("label32.Image"), System.Drawing.Image)
            Me.label32.Location = New System.Drawing.Point(207, 462)
            Me.label32.Name = "label32"
            Me.label32.Size = New System.Drawing.Size(20, 20)
            Me.label32.TabIndex = 42
            Me.toolTip1.SetToolTip(Me.label32, "Will be shown if the no of tabs " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "exceed control width. Add more " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "tabs to see th" & _
                    "e scrolls.")
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(524, 496)
            Me.Controls.Add(Me.label32)
            Me.Controls.Add(Me.chartControl1)
            Me.Controls.Add(Me.buttonPrint)
            Me.Controls.Add(Me.buttonGrid)
            Me.Controls.Add(Me.buttonAdv2)
            Me.Controls.Add(Me.buttonEmf)
            Me.Controls.Add(Me.buttonSVG)
            Me.Controls.Add(Me.buttonImage)
            Me.Controls.Add(Me.buttonXLsIO)
            Me.Controls.Add(Me.buttonPdf)
            Me.Controls.Add(Me.buttonDocIO)
            Me.Controls.Add(Me.statusStrip1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Chart Export Data"
            Me.statusStrip1.ResumeLayout(False)
            Me.statusStrip1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
		#End Region

		#Region "FormLoad"

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

			InitializeChartData()
            ChartAppearance.ApplyChartStyles(Me.chartControl1)
			Me.toolStripStatusLabel1.Text = "Chart Export"
			Me.label32.Visible = False

		End Sub
			#End Region

		#Region "Helper Methods"
		#Region "InitializeChartData"
		''' <summary>
		''' Initializes Chart Data.
		''' </summary>
		Protected Sub InitializeChartData()

            Dim series1 As ChartSeries = New ChartSeries("Clothes", ChartSeriesType.Line)
            series1.Name = "Clothes"
            series1.Text = "Clothes"
            series1.Points.Add(1, 960)
            series1.Points.Add(2, 4300)
            series1.Points.Add(3, 5750)
            series1.Points.Add(4, 4500)
            series1.Points.Add(5, 3750)
            series1.Points.Add(6, 1800)
            series1.Points.Add(7, 500)
            series1.Points.Add(8, 200)
            series1.Points.Add(9, 100)
            Me.chartControl1.Series.Add(series1)

            Dim series As ChartSeries = New ChartSeries("Clothes", ChartSeriesType.Column)
            series.Name = "Clothes"
            series.Text = "Clothes"
            series.Points.Add(1, 960)
            series.Points.Add(2, 4300)
            series.Points.Add(3, 5750)
            series.Points.Add(4, 4500)
            series.Points.Add(5, 3750)
            series.Points.Add(6, 1800)
            series.Points.Add(7, 500)
            series.Points.Add(8, 200)
            series.Points.Add(9, 100)
            Me.chartControl1.Series.Add(series)

            fileName = Application.StartupPath & "\chartexport"
            gridForm = New Form2()
		End Sub
		#End Region

		#End Region

		#Region "Events"
		'Exports and saves the chart as Word document.
		#Region "DocIO"
		Private Sub buttonDocIO_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonDocIO.Click
			Try
				exportFileName = fileName & ".doc"
				Dim file As String = fileName & ".gif"

				If (Not System.IO.File.Exists(file)) Then
					Me.chartControl1.SaveImage(file)
				End If

				'Create a new document
				Dim document As WordDocument = New WordDocument()
				'Adding a new section to the document.
				Dim section As IWSection = document.AddSection()
				'Adding a paragraph to the section
				Dim paragraph As IWParagraph = section.AddParagraph()
				'Writing text.
				paragraph.AppendText("Essential Chart")
				'Adding a new paragraph		
				paragraph = section.AddParagraph()
				paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
				'Inserting chart.
				paragraph.AppendPicture(Image.FromFile(file))
				'Save the Document to disk.
				document.Save(exportFileName, Syncfusion.DocIO.FormatType.Doc)
				OpenFile("DocIO", exportFileName)

			Catch ex As Exception
				Me.toolStripStatusLabel1.Text = "Chart Export failed."
				Console.WriteLine(ex.ToString())
			End Try
		End Sub
		#End Region

		'Exports and saves the chart in Pdf.
		#Region "Pdf"
		Private Sub buttonPdf_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonPdf.Click
			Try
				exportFileName = fileName & ".pdf"
				Dim file As String = fileName & ".gif"

				If (Not System.IO.File.Exists(file)) Then
					Me.chartControl1.SaveImage(file)
				End If

				'Create a new PDF Document. The pdfDoc object represents the PDF document.
				'This document has one page by default and additional pages have to be added.
				Dim pdfDoc As PdfDocument = New PdfDocument()

				pdfDoc.Pages.Add()

				pdfDoc.Pages(0).Graphics.DrawImage(PdfImage.FromFile(file), New PointF(10, 30))

				'Save the PDF Document to disk.
				pdfDoc.Save(exportFileName)
				OpenFile("Pdf", exportFileName)

			Catch ex As Exception
				Me.toolStripStatusLabel1.Text = "Chart Export failed."
				Console.WriteLine(ex.ToString())
			End Try
		End Sub
		#End Region

		'Export and saves the chart in Excel Sheet
		#Region "XLsIO"
		Private Sub buttonXLsIO_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonXLsIO.Click
			Try
				exportFileName = fileName & ".xls"

				'A new workbook with a worksheet is created.
				Dim chartBook As IWorkbook = ExcelUtils.CreateWorkbook(1)
				Dim sheet As IWorksheet = chartBook.Worksheets(0)

				'Fill the worksheet by chart data.
				For i As Integer = 1 To 4
					sheet.Range(i, 1).Number = Me.chartControl1.Series(0).Points(i - 1).X
					sheet.Range(i, 2).Number = Me.chartControl1.Series(0).Points(i - 1).YValues(0)
				Next i
				For i As Integer = 1 To 4
					sheet.Range(i + 5, 1).Number = Me.chartControl1.Series(1).Points(i - 1).X
					sheet.Range(i + 5, 2).Number = Me.chartControl1.Series(1).Points(i - 1).YValues(0)
				Next i

				'Create a chart worksheet.
				Dim chart As IChart = chartBook.Charts.Add("Essential Chart")

				'Specifies the title of the Chart.
				chart.ChartTitle = "Essential Chart"

				'Initializes a new series instance and adds it to the series collection of the chart.
				Dim series1 As IChartSerie = chart.Series.Add()
				'Specify the chart type of the series.
				series1.SerieType = ExcelChartType.Column_Clustered
				'Specify the name of the series. This will be displayed as the text of the legend.
				series1.Name = "Sample Series"
				'Specify the value ranges for the series.
				series1.Values = sheet.Range("B1:B5")
				'Specify the Category labels for the series.
				series1.CategoryLabels = sheet.Range("A1:A5")


				Dim series2 As IChartSerie = chart.Series.Add()
				'Specify the chart type of the series.
				series2.SerieType = ExcelChartType.Column_Clustered
				'Specify the name of the series. This will be displayed as the text of the legend.
				series2.Name = "Sample Series"
				'Specify the value ranges for the series.
				series2.Values = sheet.Range("B6:B10")
				'Specify the Category labels for the series.
				series2.CategoryLabels = sheet.Range("A6:A10")


				'Makes the chart as active sheet.
				chart.Activate()
				'Save the Chart book.
				chartBook.SaveAs(exportFileName)
				chartBook.Close()
				ExcelUtils.Close()
				OpenFile("XLsIO", exportFileName)
				System.Diagnostics.Process.Start(exportFileName)

			Catch ex As Exception
				Me.toolStripStatusLabel1.Text = "Chart Export failed."
				Console.WriteLine(ex.ToString())
			End Try
		End Sub
		#End Region

		'Exports and saves chart as Image.
		#Region "Image"
		Private Sub buttonImage_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonImage.Click
			Try
				exportFileName = fileName & ".gif"

				Me.chartControl1.SaveImage(exportFileName)
				OpenFile("Image", exportFileName)

			Catch ex As Exception
				Me.toolStripStatusLabel1.Text = "Chart Export failed."
				Console.WriteLine(ex.ToString())
			End Try
		End Sub
		#End Region

		'Export and saves chart as Svg.        
		#Region "SVG"
			'If no application is associated with this file type, need to install an SVG plug-in. 
			'The Adobe plug-in, SVG viewer, could be downloaded for free from the link: 
			'http://www.adobe.com/svg/viewer/install/
			'Once the viewer is installed on your machine, IE will become automatically SVG-enabled. 
		Private Sub buttonSVG_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonSVG.Click
			Try
				exportFileName = fileName & ".svg"
				Me.chartControl1.SaveImage(exportFileName)
				OpenFile("Svg", exportFileName)
			Catch ex As Exception
				Me.toolStripStatusLabel1.Text = "Chart Export failed."
				Console.WriteLine(ex.ToString())
			End Try
		End Sub
			#End Region

		'Exports and saves the Image in vector format.
		#Region "Emf"
		Private Sub buttonEmf_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonEmf.Click
			Try
				exportFileName = fileName & ".emf"
				Me.chartControl1.SaveImage(exportFileName)

				OpenFile("Emf", exportFileName)
			Catch ex As Exception
				Me.toolStripStatusLabel1.Text = "Chart Export failed."
				Console.WriteLine(ex.ToString())
			End Try
		End Sub
		#End Region

		'Export and saves chart as csv.
		#Region "CSV"
		Private Sub buttonAdv2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonAdv2.Click
			Dim csvContent As String = String.Empty, csvLine As String = String.Empty
			Dim comma As String = ","
			exportFileName = fileName & ".csv"

			Try
				For Each series As ChartSeries In Me.chartControl1.Series
					Dim seriesName As String = series.Name
					Dim pointCount As Integer = series.Points.Count
					Dim seriesType As String = series.Type.ToString()

					For p As Integer = 0 To pointCount - 1
						Dim point As ChartPoint = series.Points(p)

						Dim yvaluescsv As String = String.Empty
						Dim count As Integer = point.YValues.Length
						For i As Integer = 0 To count - 1
							yvaluescsv &= point.YValues(i)
							If i <> count - 1 Then
								yvaluescsv &= comma
							End If
						Next i

						'The format of the csv can be given here.
						'csvLine = seriesName + "-" + seriesType + comma + point.X + comma + yvaluescsv;

						csvLine = point.X & comma & yvaluescsv
						csvContent &= csvLine & Constants.vbLf
					Next p
				Next series

				'Initializes the stream to write the contents in a file.
				Dim file As System.IO.StreamWriter = New System.IO.StreamWriter(exportFileName)
				file.WriteLine(csvContent)
				file.Close()

				OpenFile("CSV", exportFileName)
			Catch ex As Exception
				Me.toolStripStatusLabel1.Text = "Chart Export failed."
				Console.WriteLine(ex.ToString())
			End Try
		End Sub
		#End Region

		'Exports and displays the chart using Essential Grid.
		#Region "Grid"
		Private Sub buttonGrid_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonGrid.Click
			Try
				Dim file As String = fileName & ".gif"

				If (Not System.IO.File.Exists(file)) Then
					Me.chartControl1.SaveImage(file)
				End If

				'Specify the filename as the name of the form.
				gridForm.Name = file
				OpenFile("Grid", exportFileName)

			Catch ex As Exception
				Me.toolStripStatusLabel1.Text = "Chart Export failed."
				Console.WriteLine(ex.ToString())
			End Try
		End Sub


		#End Region

		#Region "OpenFile"
		Protected Sub OpenFile(ByVal filetype As String, ByVal exportFileName As String)
			Me.toolStripStatusLabel1.Text = "Chart Exported to " & filetype & " Successfully."
			Try
				If filetype = "Grid" Then
					gridForm.ShowDialog()
				Else
				   System.Diagnostics.Process.Start(exportFileName)
				End If
			   Me.label32.Visible = False
			Catch ex As Exception
				Console.WriteLine(ex.ToString())
				Me.label32.Visible = True
				Me.toolTip1.SetToolTip(Me.label32, "No application is associated with the " & Constants.vbLf & " specified file for this operation.")
			End Try
		End Sub
		#End Region   

		#Region "Print"
		Private Sub buttonPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonPrint.Click
			Dim printPreviewDialog1 As PrintPreviewDialog = New PrintPreviewDialog()
			printPreviewDialog1.Document = Me.chartControl1.PrintDocument
			printPreviewDialog1.ShowDialog()
		End Sub
		#End Region
		#End Region

	End Class
End Namespace
