#region Copyright Syncfusion Inc. 2001 - 2005
//
//  Copyright Syncfusion Inc. 2001 - 2005. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.XlsIO;
using Syncfusion.Pdf;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using Syncfusion.Drawing;
using Syncfusion.Pdf.Graphics;

namespace ChartExportData
{
	
	public class Form1 : Syncfusion.Windows.Forms.Office2007Form
    {
        #region Private Members
        public Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
		private string fileName;
		private string exportFileName = null;
        private Form2 gridForm;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonDocIO;
        private Syncfusion.Windows.Forms.ButtonAdv buttonPdf;
        private Syncfusion.Windows.Forms.ButtonAdv buttonXLsIO;
        private Syncfusion.Windows.Forms.ButtonAdv buttonImage;
        private Syncfusion.Windows.Forms.ButtonAdv buttonSVG;
        private Syncfusion.Windows.Forms.ButtonAdv buttonEmf;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonGrid;
        private Syncfusion.Windows.Forms.ButtonAdv buttonPrint;
        Color[] color1 = new Color[] { Color.FromArgb(141, 100, 170), Color.FromArgb(200, 170, 222), Color.FromArgb(141, 100, 170) };
        Color[] color2 = new Color[] { Color.FromArgb(223, 111, 39), Color.FromArgb(251, 169, 113), Color.FromArgb(223, 111, 39) };
        private ToolTip toolTip1;
        private Label label32;
        private IContainer components;
        #endregion

        #region Form's Constructor, Main and Dispose
        public Form1()
		{
			InitializeComponent();
			
		}
        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
        }
         #endregion    

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonDocIO = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonPdf = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonXLsIO = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonImage = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonSVG = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonEmf = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonGrid = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonPrint = new Syncfusion.Windows.Forms.ButtonAdv();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label32 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.White);
            this.chartControl1.ChartArea.BorderColor = System.Drawing.Color.Black;
            this.chartControl1.ChartArea.BorderWidth = 2;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            this.chartControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))));
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(59, 311);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Size = new System.Drawing.Size(522, 389);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(553, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // buttonDocIO
            // 
            this.buttonDocIO.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonDocIO.Image = ((System.Drawing.Image)(resources.GetObject("buttonDocIO.Image")));
            this.buttonDocIO.KeepFocusRectangle = false;
            this.buttonDocIO.Location = new System.Drawing.Point(188, 415);
            this.buttonDocIO.Name = "buttonDocIO";
            this.buttonDocIO.Size = new System.Drawing.Size(50, 50);
            this.buttonDocIO.TabIndex = 4;
            this.buttonDocIO.Tag = "Check";
            this.buttonDocIO.UseVisualStyle = true;
            this.buttonDocIO.Click += new System.EventHandler(this.buttonDocIO_Click);
            // 
            // buttonPdf
            // 
            this.buttonPdf.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonPdf.Image = ((System.Drawing.Image)(resources.GetObject("buttonPdf.Image")));
            this.buttonPdf.KeepFocusRectangle = false;
            this.buttonPdf.Location = new System.Drawing.Point(240, 415);
            this.buttonPdf.Name = "buttonPdf";
            this.buttonPdf.Size = new System.Drawing.Size(50, 50);
            this.buttonPdf.TabIndex = 5;
            this.buttonPdf.Tag = "Check";
            this.buttonPdf.UseVisualStyle = true;
            this.buttonPdf.Click += new System.EventHandler(this.buttonPdf_Click);
            // 
            // buttonXLsIO
            // 
            this.buttonXLsIO.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonXLsIO.Image = ((System.Drawing.Image)(resources.GetObject("buttonXLsIO.Image")));
            this.buttonXLsIO.KeepFocusRectangle = false;
            this.buttonXLsIO.Location = new System.Drawing.Point(292, 415);
            this.buttonXLsIO.Name = "buttonXLsIO";
            this.buttonXLsIO.Size = new System.Drawing.Size(50, 50);
            this.buttonXLsIO.TabIndex = 6;
            this.buttonXLsIO.Tag = "Check";
            this.buttonXLsIO.UseVisualStyle = true;
            this.buttonXLsIO.Click += new System.EventHandler(this.buttonXLsIO_Click);
            // 
            // buttonImage
            // 
            this.buttonImage.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonImage.Image = ((System.Drawing.Image)(resources.GetObject("buttonImage.Image")));
            this.buttonImage.KeepFocusRectangle = false;
            this.buttonImage.Location = new System.Drawing.Point(84, 415);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(50, 50);
            this.buttonImage.TabIndex = 7;
            this.buttonImage.UseVisualStyle = true;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            // 
            // buttonSVG
            // 
            this.buttonSVG.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonSVG.Image = ((System.Drawing.Image)(resources.GetObject("buttonSVG.Image")));
            this.buttonSVG.KeepFocusRectangle = false;
            this.buttonSVG.Location = new System.Drawing.Point(136, 415);
            this.buttonSVG.Name = "buttonSVG";
            this.buttonSVG.Size = new System.Drawing.Size(50, 50);
            this.buttonSVG.TabIndex = 8;
            this.buttonSVG.UseVisualStyle = true;
            this.buttonSVG.Click += new System.EventHandler(this.buttonSVG_Click);
            // 
            // buttonEmf
            // 
            this.buttonEmf.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonEmf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmf.Image = ((System.Drawing.Image)(resources.GetObject("buttonEmf.Image")));
            this.buttonEmf.KeepFocusRectangle = false;
            this.buttonEmf.Location = new System.Drawing.Point(32, 415);
            this.buttonEmf.Name = "buttonEmf";
            this.buttonEmf.Size = new System.Drawing.Size(50, 50);
            this.buttonEmf.TabIndex = 9;
            this.buttonEmf.UseVisualStyle = true;
            this.buttonEmf.Click += new System.EventHandler(this.buttonEmf_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdv2.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv2.Image")));
            this.buttonAdv2.KeepFocusRectangle = false;
            this.buttonAdv2.Location = new System.Drawing.Point(344, 415);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(50, 50);
            this.buttonAdv2.TabIndex = 10;
            this.buttonAdv2.UseVisualStyle = true;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv2_Click);
            // 
            // buttonGrid
            // 
            this.buttonGrid.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrid.Image = ((System.Drawing.Image)(resources.GetObject("buttonGrid.Image")));
            this.buttonGrid.KeepFocusRectangle = false;
            this.buttonGrid.Location = new System.Drawing.Point(396, 415);
            this.buttonGrid.Name = "buttonGrid";
            this.buttonGrid.Size = new System.Drawing.Size(50, 50);
            this.buttonGrid.TabIndex = 11;
            this.buttonGrid.UseVisualStyle = true;
            this.buttonGrid.Click += new System.EventHandler(this.buttonGrid_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
            this.buttonPrint.KeepFocusRectangle = false;
            this.buttonPrint.Location = new System.Drawing.Point(462, 415);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(50, 50);
            this.buttonPrint.TabIndex = 13;
            this.toolTip1.SetToolTip(this.buttonPrint, "Print Chart");
            this.buttonPrint.UseVisualStyle = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // label32
            // 
            this.label32.Image = ((System.Drawing.Image)(resources.GetObject("label32.Image")));
            this.label32.Location = new System.Drawing.Point(218, 457);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(20, 20);
            this.label32.TabIndex = 42;
            this.toolTip1.SetToolTip(this.label32, "Will be shown if the no of tabs \r\nexceed control width. Add more \r\ntabs to see th" +
                    "e scrolls.");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 497);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonGrid);
            this.Controls.Add(this.buttonAdv2);
            this.Controls.Add(this.buttonEmf);
            this.Controls.Add(this.buttonSVG);
            this.Controls.Add(this.buttonImage);
            this.Controls.Add(this.buttonXLsIO);
            this.Controls.Add(this.buttonPdf);
            this.Controls.Add(this.buttonDocIO);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Export Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

        #region FormLoad

        private void Form1_Load(object sender, System.EventArgs e)
		{
			InitializeChartData();         
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.toolStripStatusLabel1.Text = "Chart Export";
            this.label32.Visible = false;			
        }
            #endregion

        #region Helper Methods
        #region InitializeChartData
        /// <summary>
		/// Initializes Chart Data.
		/// </summary>
        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries("Clothes", ChartSeriesType.Line);
            series1.Name = "Clothes";
            series1.Text = "Clothes";
            series1.Points.Add(1, 960);
            series1.Points.Add(2, 4300);
            series1.Points.Add(3, 5750);
            series1.Points.Add(4, 4500);
            series1.Points.Add(5, 3750);
            series1.Points.Add(6, 1800);
            series1.Points.Add(7, 500);
            series1.Points.Add(8, 200);
            series1.Points.Add(9, 100);
            this.chartControl1.Series.Add(series1);         
            
            ChartSeries series = new ChartSeries("Clothes", ChartSeriesType.Column);
            series.Name = "Clothes";
            series.Text = "Clothes";
            series.Points.Add(1, 960);
            series.Points.Add(2, 4300);
            series.Points.Add(3, 5750);
            series.Points.Add(4, 4500);
            series.Points.Add(5, 3750);
            series.Points.Add(6, 1800);
            series.Points.Add(7, 500);
            series.Points.Add(8, 200);
            series.Points.Add(9, 100);
            this.chartControl1.Series.Add(series);

            fileName = Application.StartupPath + "\\chartexport";
            gridForm = new Form2();

        }
        #endregion       
            #endregion
       

        #region Events
        //Exports and saves the chart as Word document.
        #region DocIO
        private void buttonDocIO_Click(object sender, EventArgs e)
        {
            try
            {
                exportFileName = fileName + ".doc";
                string file = fileName + ".gif";

                if (!System.IO.File.Exists(file))
                    this.chartControl1.SaveImage(file);

                //Create a new document
                WordDocument document = new WordDocument();
                //Adding a new section to the document.
                IWSection section = document.AddSection();
                //Adding a paragraph to the section
                IWParagraph paragraph = section.AddParagraph();
                //Writing text.
                paragraph.AppendText("Essential Chart");
                //Adding a new paragraph		
                paragraph = section.AddParagraph();
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                //Inserting chart.
                paragraph.AppendPicture(Image.FromFile(file));
                //Save the Document to disk.
                document.Save(exportFileName, Syncfusion.DocIO.FormatType.Doc);
                OpenFile("DocIO", exportFileName);
                
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        //Exports and saves the chart in Pdf.
        #region Pdf
        private void buttonPdf_Click(object sender, EventArgs e)
        {
            try
            {
                exportFileName = fileName + ".pdf";
                string file = fileName + ".gif";

                if (!System.IO.File.Exists(file))
                    this.chartControl1.SaveImage(file);

                //Create a new PDF Document. The pdfDoc object represents the PDF document.
                //This document has one page by default and additional pages have to be added.
                PdfDocument pdfDoc = new PdfDocument();

                pdfDoc.Pages.Add();

                pdfDoc.Pages[0].Graphics.DrawImage(PdfImage.FromFile(file), new PointF(10, 30));

                //Save the PDF Document to disk.
                pdfDoc.Save(exportFileName);
                OpenFile("Pdf", exportFileName);
               
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        //Export and saves the chart in Excel Sheet
        #region XLsIO
        private void buttonXLsIO_Click(object sender, EventArgs e)
        {
            try
            {
                exportFileName = fileName + ".xls";

                //A new workbook with a worksheet is created.
                IWorkbook chartBook = ExcelUtils.CreateWorkbook(1);
                IWorksheet sheet = chartBook.Worksheets[0];
                
                //Fill the worksheet by chart data.
                for (int i = 1; i <= 4; i++)
                {
                    sheet.Range[i, 1].Number = this.chartControl1.Series[0].Points[i - 1].X;
                    sheet.Range[i, 2].Number = this.chartControl1.Series[0].Points[i - 1].YValues[0];
                }
                for (int i = 1; i <= 4; i++)
                {
                    sheet.Range[i + 5, 1].Number = this.chartControl1.Series[1].Points[i - 1].X;
                    sheet.Range[i + 5, 2].Number = this.chartControl1.Series[1].Points[i - 1].YValues[0];
                }

                //Create a chart worksheet.
                IChart chart = chartBook.Charts.Add("Essential Chart");

                //Specifies the title of the Chart.
                chart.ChartTitle = "Essential Chart";

                //Initializes a new series instance and adds it to the series collection of the chart.
                IChartSerie series1 = chart.Series.Add();
                //Specify the chart type of the series.
                series1.SerieType = ExcelChartType.Column_Clustered;
                //Specify the name of the series. This will be displayed as the text of the legend.
                series1.Name = "Sample Series";
                //Specify the value ranges for the series.
                series1.Values = sheet.Range["B1:B5"];
                //Specify the Category labels for the series.
                series1.CategoryLabels = sheet.Range["A1:A5"];


                IChartSerie series2 = chart.Series.Add();
                //Specify the chart type of the series.
                series2.SerieType = ExcelChartType.Column_Clustered;
                //Specify the name of the series. This will be displayed as the text of the legend.
                series2.Name = "Sample Series";
                //Specify the value ranges for the series.
                series2.Values = sheet.Range["B6:B10"];
                //Specify the Category labels for the series.
                series2.CategoryLabels = sheet.Range["A6:A10"];


                //Makes the chart as active sheet.
                chart.Activate();
                //Save the Chart book.
                chartBook.SaveAs(exportFileName);
                chartBook.Close();
                ExcelUtils.Close();
                OpenFile("XLsIO", exportFileName);
                System.Diagnostics.Process.Start(exportFileName);
               
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        //Exports and saves chart as Image.
        #region Image
        private void buttonImage_Click(object sender, EventArgs e)
        {
            try
            {
                exportFileName = fileName + ".gif";

                this.chartControl1.SaveImage(exportFileName);
                OpenFile("Image", exportFileName);
               
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
                }
            }
        #endregion

        //Export and saves chart as Svg.        
        #region SVG
            //If no application is associated with this file type, need to install an SVG plug-in. 
            //The Adobe plug-in, SVG viewer, could be downloaded for free from the link: 
            //http://www.adobe.com/svg/viewer/install/
            //Once the viewer is installed on your machine, IE will become automatically SVG-enabled. 
        private void buttonSVG_Click(object sender, EventArgs e)
        {
            try
            {
                exportFileName = fileName + ".svg";
                this.chartControl1.SaveImage(exportFileName);
                OpenFile("Svg", exportFileName);
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
            }
        }
            #endregion

        //Exports and saves the Image in vector format.
        #region Emf
        private void buttonEmf_Click(object sender, EventArgs e)
        {
            try
            {
                exportFileName = fileName + ".emf";
                this.chartControl1.SaveImage(exportFileName);

                OpenFile("Emf", exportFileName);
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        //Export and saves chart as csv.
        #region CSV
        private void buttonAdv2_Click(object sender, EventArgs e)
        {
            string csvContent = String.Empty, csvLine = String.Empty;
            string comma = ",";
            exportFileName = fileName + ".csv";

            try
            {
                foreach (ChartSeries series in this.chartControl1.Series)
                {
                    string seriesName = series.Name;
                    int pointCount = series.Points.Count;
                    string seriesType = series.Type.ToString();

                    for (int p = 0; p < pointCount; p++)
                    {
                        ChartPoint point = series.Points[p];

                        string yvaluescsv = String.Empty;
                        int count = point.YValues.Length;
                        for (int i = 0; i < count; i++)
                        {
                            yvaluescsv += point.YValues[i];
                            if (i != count - 1)
                                yvaluescsv += comma;
                        }

                        //The format of the csv can be given here.
                        //csvLine = seriesName + "-" + seriesType + comma + point.X + comma + yvaluescsv;

                        csvLine = point.X + comma + yvaluescsv;
                        csvContent += csvLine + "\n";
                    }
                }

                //Initializes the stream to write the contents in a file.
                System.IO.StreamWriter file = new System.IO.StreamWriter(exportFileName);
                file.WriteLine(csvContent);
                file.Close();

                OpenFile("CSV", exportFileName);
            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
            }
        }
        #endregion

        //Exports and displays the chart using Essential Grid.
        #region Grid
        private void buttonGrid_Click(object sender, EventArgs e)
        {
            try
            {
                string file = fileName + ".gif";

                if (!System.IO.File.Exists(file))
                    this.chartControl1.SaveImage(file);

                //Specify the filename as the name of the form.
                gridForm.Name = file;
                OpenFile("Grid", exportFileName);

            }
            catch (Exception ex)
            {
                this.toolStripStatusLabel1.Text = "Chart Export failed.";
                Console.WriteLine(ex.ToString());
            }
        }

            
        #endregion

        #region OpenFile
        protected void OpenFile(string filetype, string exportFileName)
        {
            this.toolStripStatusLabel1.Text = "Chart Exported to " + filetype + " Successfully.";
            try
            {
                if (filetype == "Grid")
                    gridForm.ShowDialog();
                else
                   System.Diagnostics.Process.Start(exportFileName);
               this.label32.Visible = false;
            }
            catch (Exception ex)
            {                
                Console.WriteLine(ex.ToString());
                this.label32.Visible = true;
                this.toolTip1.SetToolTip(this.label32, "No application is associated with the \n specified file for this operation.");
            }
        }
        #endregion   

        #region Print
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = this.chartControl1.PrintDocument;
            printPreviewDialog1.ShowDialog();
        }
        #endregion

        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                if (e.Value == 1)
                    e.Label = "10-19";
                else if (e.Value == 2)
                    e.Label = "20-29";
                else if (e.Value == 3)
                    e.Label = "30-39";
                else if (e.Value == 4)
                    e.Label = "40-49";
                else if (e.Value == 5)
                    e.Label = "50-59";
                else if (e.Value == 6)
                    e.Label = "60-69";
                else if (e.Value == 7)
                    e.Label = "70-79";
                else if (e.Value == 8)
                    e.Label = "80-89";
                else if (e.Value == 9)
                    e.Label = "90-99";
                else
                    e.Label = "";

                e.Handled = true;
            }
        }
        #endregion

    }
}
