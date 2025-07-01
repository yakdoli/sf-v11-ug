#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
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
using Syncfusion.Drawing;

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;

namespace GettingStartedSample
{
    public class Form1 : Office2007Form
    {
        #region Private Members
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Label label6;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Form Constructor, Main, Dispose
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 348);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 160);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 56);
            this.label6.TabIndex = 5;
            this.label6.Text = "Getting Started with Essential Chart";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(0, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(515, 104);
            this.label2.TabIndex = 1;
            this.label2.Tag = "";
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Embed;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            // 
            // 
            // 
            this.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(171, 61);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartControl1.Location = new System.Drawing.Point(45, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 500, 100);
            this.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.Size = new System.Drawing.Size(432, 320);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 0.20000000298023224;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 508);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Getting Started";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Form_Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            //Creates series and associate with the Chart control
            InitializeChartData();
            
            //Customize the basic appearance and behaviour of Chart Control
            ChartAppearance.ApplyChartStyles(this.chartControl1);

        }
        #endregion

        #region Helper Method

        #region InitializeChartData

        private void InitializeChartData()
        {
            ChartSeries series = new ChartSeries();
            series.Name = "Sales";
            series.Points.Add(1999, 3);
            series.Points.Add(2000, 7);
            series.Points.Add(2001, 12);
            series.Points.Add(2002, 18);
            series.Points.Add(2003, 22);
            series.Points.Add(2004, 30);
            series.Points.Add(2005, 40);
            series.Points.Add(2006, 50);
            series.Points.Add(2007, 65);
            series.Points.Add(2008, 75);
            series.Type = ChartSeriesType.Column;
            series.Text = series.Name;
            this.chartControl1.Series.Add(series);           
            this.chartControl1.Series[0].PrepareStyle += new ChartPrepareStyleInfoHandler(Form1_PrepareStyle);
        }

        void Form1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            ChartSeries series = this.chartControl1.Series[0];
            if(series!=null)
            {

                if (args.Index == 0)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 41, 158, 214));
                }
                else if (args.Index == 1)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 206, 215, 41));
                }
                else if (args.Index == 2)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 255, 186, 0));
                }
                else if (args.Index == 3)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 247, 125, 16));
                }    
                else if (args.Index == 4)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 129,115,27));
                }
                else if (args.Index == 5)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 255, 136, 23));
                }
                else if (args.Index == 6)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 246, 100, 15));
                }
                else if (args.Index == 7)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 188, 200, 6));
                }
                else if (args.Index == 8)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 234, 90, 81));
                }
                else if (args.Index == 9)
                {
                    args.Style.Interior = new BrushInfo(Color.FromArgb(175, 191,192,98));
                }
            }
        }
        #endregion

        #endregion
    }
}
