
#region Copyright Syncfusion Inc. 2001 - 2008
//
//  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using System.Collections.Generic;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    /// <summary>
    /// The ChartControl sample form.
    /// </summary>
    public class FormMain : Office2007Form
    {
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private DesignerPanel designerPanel1;
        private ButtonAdv buttonAdv3;
        private ButtonAdv buttonAdv2;
        private ButtonAdv buttonAdv1;
        private ButtonAdv buttonAdv4;
        private CheckBox checkBox1;
        private IContainer components = null;
        private Color[] color1, color2, color3, color4, color5, color6, color7, color8;
        private CheckBox checkBox2;

        #region Form's  Constructor, Main And Dispose
        public FormMain()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new FormMain());
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.designerPanel1 = new DesignerPanel();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel1)).BeginInit();
            this.designerPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.Blue;
            this.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.Watermark.TextColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(40, 10, 40, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.chartControl1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(88, 441);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Location = new System.Drawing.Point(159, 22);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.Size = new System.Drawing.Size(590, 518);
            this.chartControl1.TabIndex = 2;
            this.chartControl1.Text = "Students Admission Statistics - Pie Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Title.Margin = 2;
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Students Admission Statistics - Pie Chart";
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
            this.chartControl1.ZoomOutIncrement = 1.5;
            this.chartControl1.ChartAreaPaint += new System.Windows.Forms.PaintEventHandler(this.chartControl1_ChartAreaPaint);
            // 
            // designerPanel1
            // 
            this.designerPanel1.BackColor = System.Drawing.Color.White;
            this.designerPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(237))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(242))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(243))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(245))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))))});
            this.designerPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(220)))), ((int)(((byte)(231)))));
            this.designerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designerPanel1.Controls.Add(this.buttonAdv1);
            this.designerPanel1.Controls.Add(this.checkBox2);
            this.designerPanel1.Controls.Add(this.buttonAdv4);
            this.designerPanel1.Controls.Add(this.checkBox1);
            this.designerPanel1.Controls.Add(this.buttonAdv3);
            this.designerPanel1.Controls.Add(this.buttonAdv2);
            this.designerPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.designerPanel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designerPanel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.designerPanel1.HeaderImage = null;
            this.designerPanel1.HeaderText = "       Chart Type";
            this.designerPanel1.Location = new System.Drawing.Point(0, 0);
            this.designerPanel1.Name = "designerPanel1";
            this.designerPanel1.Size = new System.Drawing.Size(140, 561);
            this.designerPanel1.TabIndex = 3;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv1.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv1.Image")));
            this.buttonAdv1.Location = new System.Drawing.Point(29, 53);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(80, 81);
            this.buttonAdv1.TabIndex = 1;
            this.buttonAdv1.Text = "Pie";
            this.buttonAdv1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(9, 521);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(135, 18);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "PieWithSameRadius";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv4.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv4.Image")));
            this.buttonAdv4.Location = new System.Drawing.Point(27, 157);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(80, 80);
            this.buttonAdv4.TabIndex = 4;
            this.buttonAdv4.Text = "Doughnut";
            this.buttonAdv4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdv4.UseVisualStyle = true;
            this.buttonAdv4.Click += new System.EventHandler(this.buttonAdv_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 486);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 18);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Enable 3D";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv3.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv3.Image")));
            this.buttonAdv3.Location = new System.Drawing.Point(27, 372);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(80, 80);
            this.buttonAdv3.TabIndex = 3;
            this.buttonAdv3.Text = "Pyramid";
            this.buttonAdv3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdv3.UseVisualStyle = true;
            this.buttonAdv3.Click += new System.EventHandler(this.buttonAdv_Click);
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv2.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv2.Image")));
            this.buttonAdv2.Location = new System.Drawing.Point(27, 264);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(80, 80);
            this.buttonAdv2.TabIndex = 2;
            this.buttonAdv2.Text = "Funnel";
            this.buttonAdv2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdv2.UseVisualStyle = true;
            this.buttonAdv2.Click += new System.EventHandler(this.buttonAdv_Click);
            // 
            // FormMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 561);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.designerPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Divide Area";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel1)).EndInit();
            this.designerPanel1.ResumeLayout(false);
            this.designerPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void FormMain_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

        #region InitializeChartData
        /// <summary>
        /// Initializes the ChartControl's data and sets the Chart type
        /// </summary>
        protected void InitializeChartData()
        {
            Random random = new Random();
            ChartSeries series1 = new ChartSeries();
            series1.Name = "Year 2004 \n Details";
            series1.Text = series1.Name;
            series1.Points.Add(0, 10);
            //series1.Points.Add(1, 2);
            series1.Points.Add(2, 8);
            series1.Points.Add(3, 11);
            series1.Points.Add(4, 23);
            series1.Points.Add(5, 24);
            series1.Points.Add(6, 10);
            series1.Points.Add(7, 24);
            SeriesSettings(series1);
            this.chartControl1.Series.Add(series1);
            series1.ConfigItems.PieItem.ShowSeriesTitle = true;

            ChartSeries series2 = new ChartSeries();
            series2.Name = "Year 2005";
            series2.Text = series2.Name;
            series2.Points.Add(0, 12);
            series2.Points.Add(2, 11);
            series2.Points.Add(3, 8);
            series2.Points.Add(4, 25);
            series2.Points.Add(5, 22);
            series2.Points.Add(6, 13);
            series2.Points.Add(7, 22);
            SeriesSettings(series2);
            this.chartControl1.Series.Add(series2);
            series2.ConfigItems.PieItem.ShowSeriesTitle = true;

            ChartSeries series3 = new ChartSeries();
            series3.Name = "Year 2006";
            series3.Text = series3.Name;
            series3.Points.Add(0, 8);
            series3.Points.Add(2, 12);
            series3.Points.Add(3, 8);
            series3.Points.Add(4, 21);
            series3.Points.Add(5, 26);
            series3.Points.Add(6, 12);
            series3.Points.Add(7, 26);
            SeriesSettings(series3);
            this.chartControl1.Series.Add(series3);
            series3.ConfigItems.PieItem.ShowSeriesTitle = true;

            ChartSeries series4 = new ChartSeries();
            series4.Name = "Year 2007";
            series4.Text = series4.Name;
            series4.Points.Add(0, 10);
            series4.Points.Add(2, 9);
            series4.Points.Add(3, 9);
            series4.Points.Add(4, 20);
            series4.Points.Add(5, 23);
            series4.Points.Add(6, 9);
            series4.Points.Add(7, 19);
            SeriesSettings(series4);
            this.chartControl1.Series.Add(series4);
            series4.ConfigItems.PieItem.ShowSeriesTitle = true;

            this.chartControl1.ChartArea.DivideArea = true;

            ChartLegend chartLegend = new ChartLegend();
            chartLegend.Name = "Legend 1";
            string[] label = new string[] { "Engineering", "Medical Sciences", "BioTechnology", "Information Services", "Art and Humanities", "Geography", "Economics" };
            List<ChartLegendItem> items = new List<ChartLegendItem>();
            for (int i = 0; i < 7; i++)
            {
                ChartLegendItem legendItem = new ChartLegendItem(label[i]);
                legendItem.Font = new Font("Verdana", 7, FontStyle.Regular);
                legendItem.RepresentationSize = new Size(16, 16);
                legendItem.TextColor = Color.MidnightBlue;
                items.Add(legendItem);
            }
            chartControl1.Legend.RepresentationType = ChartLegendRepresentationType.SeriesType;

            chartControl1.Legend.CustomItems = items.ToArray();
            chartControl1.Legend.RowsCount = 2;
            this.chartControl1.LegendAlignment = ChartAlignment.Center;
            this.chartControl1.LegendPosition = ChartDock.Bottom;
            this.chartControl1.LegendsPlacement = ChartPlacement.Outside;
            this.chartControl1.ShowLegend = true;
            this.chartControl1.SmoothingMode = SmoothingMode.AntiAlias;
        }

        protected void SeriesSettings(ChartSeries series)
        {
            ChartSeries newSeries = series;
            newSeries.Style.DisplayText = true;

            newSeries.Type = ChartSeriesType.Pie;

            newSeries.Style.TextColor = Color.MidnightBlue;
            newSeries.Style.Font.Bold = true;
            newSeries.Style.Font.Size = 7;

            newSeries.LegendName = "Legend 1";
            newSeries.PrepareStyle += new ChartPrepareStyleInfoHandler(series1_PrepareStyle);

            for (int i = 0; i < 7; i++)
            {
                series.Styles[i].Font.Size = 7f;
                series.Styles[i].TextFormat = string.Format("{0}%", series.Points[i].YValues[0]);
            }
        }
        #endregion

        #region Events
        #region Series_PrepareStyle
        /// <summary>
        /// Handler for the PrepareStyle event of ChartSeries. 
        /// </summary>
        /// <param name="sender">The ChartSeries object that raises this event.</param>
        /// <param name="args">The event data. Can be modified to change series appearance.</param>
        void series1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = sender as ChartSeries;
            series.Style.Border.Color = Color.SlateGray;

            series.ConfigItems.PieItem.PieType = ChartPieType.OutSide;

            if (series != null)
            {

                color1 = new Color[] { Color.FromArgb(175, 130, 181, 182) };
                color2 = new Color[] { Color.FromArgb(175, 206, 215, 41) };
                color3 = new Color[] { Color.FromArgb(175, 250, 206, 35) };
                color4 = new Color[] { Color.FromArgb(175, 155, 166, 184) };
                color5 = new Color[] { Color.FromArgb(175, 9, 116, 210) };
                color6 = new Color[] { Color.FromArgb(175, 191, 192, 98) };
                color7 = new Color[] { Color.FromArgb(175, 234, 90, 81) };
                color8 = new Color[] { Color.FromArgb(175, 191, 192, 98) };

                if (args.Index == 0)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.None, color1);
                    this.chartControl1.Legend.Items[0].Interior = new BrushInfo(GradientStyle.None, color1);
                }
                else if (args.Index == 1)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.None, color2);
                    this.chartControl1.Legend.Items[1].Interior = new BrushInfo(GradientStyle.None, color2);
                }
                else if (args.Index == 2)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.None, color6);
                    this.chartControl1.Legend.Items[2].Interior = new BrushInfo(GradientStyle.None, color6);
                }
                else if (args.Index == 3)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.None, color4);
                    this.chartControl1.Legend.Items[3].Interior = new BrushInfo(GradientStyle.None, color4);
                }
                else if (args.Index == 4)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.None, color5);
                    this.chartControl1.Legend.Items[4].Interior = new BrushInfo(GradientStyle.None, color5);
                }
                else if (args.Index == 5)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.None, color3);
                    this.chartControl1.Legend.Items[5].Interior = new BrushInfo(GradientStyle.None, color3);
                }
                else if (args.Index == 6)
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.None, color7);
                    this.chartControl1.Legend.Items[6].Interior = new BrushInfo(GradientStyle.None, color7);
                }
                else
                {
                    args.Style.Interior = new BrushInfo(GradientStyle.None, color1);
                }
            }
        }
        Rectangle rectY;
        private void chartControl1_ChartAreaPaint(object sender, PaintEventArgs e)
        {
            foreach (ChartSeries series in this.chartControl1.Series)
            {
                RectangleF rectX = this.chartControl1.ChartArea.GetSeriesBounds(series);
                rectY = new Rectangle(Convert.ToInt16(rectX.X), Convert.ToInt16(rectX.Y), Convert.ToInt16(rectX.Width), Convert.ToInt16(rectX.Height));

                e.Graphics.DrawRectangle(new Pen(Color.MidnightBlue, 1), rectY);
            }
        }

        #endregion

        private void buttonAdv_Click(object sender, EventArgs e)
        {
            ButtonAdv buttonAdv = sender as ButtonAdv;
            if (buttonAdv.Text == "Pie")
            {
                foreach (ChartSeries series in this.chartControl1.Series)
                {
                    series.Type = ChartSeriesType.Pie;
                    series.ConfigItems.PieItem.ShowSeriesTitle = true;

                    series.ConfigItems.PieItem.DoughnutCoeficient = 0;
                    series.ConfigItems.PieItem.LabelStyle = ChartAccumulationLabelStyle.Outside;
                    this.chartControl1.Text = "Students Admission Statistics - Pie Chart";
                }
            }
            else if (buttonAdv.Text == "Doughnut")
            {
                foreach (ChartSeries series in this.chartControl1.Series)
                {
                    series.Type = ChartSeriesType.Pie;
                    series.ConfigItems.PieItem.DoughnutCoeficient = 0.5f;
                    series.ConfigItems.PieItem.ShowSeriesTitle = true;
                    series.ConfigItems.PieItem.LabelStyle = ChartAccumulationLabelStyle.Outside; ;
                    this.chartControl1.Text = "Students Admission Statistics - Doughnut Chart";
                }
            }
            else if (buttonAdv.Text == "Funnel")
            {
                foreach (ChartSeries series in this.chartControl1.Series)
                {
                    series.Type = ChartSeriesType.Funnel;
                    series.ConfigItems.FunnelItem.ShowSeriesTitle = true;
                    series.ConfigItems.FunnelItem.LabelStyle = ChartAccumulationLabelStyle.OutsideInColumn;
                    series.ConfigItems.FunnelItem.FigureBase = ChartFigureBase.Square;
                    this.chartControl1.Text = "Students Admission Statistics - Funnel Chart";
                }
            }
            else if (buttonAdv.Text == "Pyramid")
            {
                foreach (ChartSeries series in this.chartControl1.Series)
                {
                    series.Type = ChartSeriesType.Pyramid;
                    series.ConfigItems.PyramidItem.ShowSeriesTitle = true;
                    series.ConfigItems.PyramidItem.LabelStyle = ChartAccumulationLabelStyle.OutsideInColumn;
                    series.ConfigItems.PyramidItem.FigureBase = ChartFigureBase.Square;
                    this.chartControl1.Text = "Students Admission Statistics - Pyramid Chart";
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ChartSeries series in this.chartControl1.Series)
            {
                series.ConfigItems.PieItem.PieWithSameRadius = checkBox2.Checked;
            }
        }
        #endregion
    }
}