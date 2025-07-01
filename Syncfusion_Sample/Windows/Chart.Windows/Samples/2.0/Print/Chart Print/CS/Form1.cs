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
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Printing;

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace ChartPrintingSample
{
   public class Form1 : Syncfusion.Windows.Forms.Office2007Form
    {
        #region Private Members
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private PrintDocument printPreviewDocument;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonPrint;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Label label1;
        private Label label6;
        private Panel panel1;
       private CheckBox checkBox1;
       private Label label2;
       private ComboBox comboBox1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion
       
        #region Form's Constructor, Main And Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            //Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            //Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.buttonPrint = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // chartControl1
            // 
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Embed;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(70, 256);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Location = new System.Drawing.Point(12, 9);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.ShowToolbar = true;
            this.chartControl1.Size = new System.Drawing.Size(461, 345);
            this.chartControl1.TabIndex = 3;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            //this.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            this.chartControl1.ToolBar.Visible = true;
            this.chartControl1.ZoomOutIncrement = 0.20000000298023224;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonPrint.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrint.Image")));
            this.buttonPrint.KeepFocusRectangle = false;
            this.buttonPrint.Location = new System.Drawing.Point(423, 360);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(50, 50);
            this.buttonPrint.TabIndex = 14;
            this.buttonPrint.UseVisualStyle = true;
            this.buttonPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv1.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv1.Image")));
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(367, 360);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(50, 50);
            this.buttonAdv1.TabIndex = 15;
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(485, 33);
            this.label1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(485, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "        Properties";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 57);
            this.panel1.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox1.Location = new System.Drawing.Point(13, 362);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Print Toolbar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(12, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "ChartPrintColorMode";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CheckPrinter",
            "Color",
            "GrayScale"});
            this.comboBox1.Location = new System.Drawing.Point(122, 388);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(485, 473);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonAdv1);
            this.Controls.Add(this.chartControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Print";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
       
        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.Size = new Size(497, 450);
            this.panel1.Visible = false;
            this.comboBox1.SelectedIndex = 1;
            this.chartControl1.ToolBar.AutoSize = false;
            this.chartControl1.ToolBar.Size = new Size(250, 30);
        }
        #endregion

        #region InitializeChartData
        protected void InitializeChartData()
        {
            ChartSeries series3 = new ChartSeries();
            series3.Name = "Server 3";
            series3.Points.Add(1, 540);
            series3.Points.Add(2, 340);
            series3.Points.Add(3, 240);
            series3.Points.Add(4, 200);

            series3.Type = ChartSeriesType.Spline;
            series3.Text = series3.Name;
            series3.Style.Border.Width = 2;
            series3.Style.Symbol.Shape = ChartSymbolShape.Circle;
            series3.Style.Symbol.Color = Color.White;
            series3.Style.Symbol.Border.Width = 2;
            series3.Style.Symbol.Border.Color = Color.FromArgb(175, 36, 119, 51);
            this.chartControl1.Series.Add(series3);

            ChartSeries series = new ChartSeries();
            series.Name = "Server 1";
            series.Points.Add(1, 340);
            series.Points.Add(2, 240);
            series.Points.Add(3, 440);
            series.Points.Add(4, 500);

            series.Type = ChartSeriesType.Column;
            series.Text = series.Name;

            ChartSeries series2 = new ChartSeries();
            series2.Name = "Server 2";
            series2.Points.Add(1, 240);
            series2.Points.Add(2, 140);
            series2.Points.Add(3, 340);
            series2.Points.Add(4, 300);

            series2.Type = ChartSeriesType.Column;
            series2.Text = series2.Name;

            this.chartControl1.Series.Add(series);

            this.chartControl1.Series.Add(series2);            

            this.chartControl1.Text = "Daily Server Network Load Comparison";
            this.chartControl1.PrimaryYAxis.Title = "Server Load (MBytes)";
            this.chartControl1.PrimaryXAxis.Format = "Day 0";
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows;
            this.chartControl1.Indexed = true;
        }
        #endregion

        #region Events
        private void button1_Click(object sender, System.EventArgs e)
        {
            printDialog1.Document = this.chartControl1.PrintDocument;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                //this.chartControl1.PrintColorMode = ChartPrintColorMode.Color;
                this.chartControl1.PrintDocument.Print();
            }
            this.Size = new Size(497, 450);
            this.panel1.Visible = false;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            try
            {
                printPreviewDocument = this.chartControl1.PrintDocument;
                this.printPreviewDialog1.Document = printPreviewDocument;
                this.printPreviewDialog1.FormBorderStyle = FormBorderStyle.Fixed3D;
                this.printPreviewDialog1.ShowDialog();
            }
            catch (Exception exp)
            {
                this.Size = new Size(497, 509);
                this.panel1.Visible = true;
                this.label1.Text = exp.Message.ToString();
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrintDocument.PrintToolBar = this.checkBox1.Checked;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrintColorMode = (ChartPrintColorMode)Enum.Parse(typeof(ChartPrintColorMode), this.comboBox1.SelectedItem.ToString(), true);
        }
        #endregion      

    }
}