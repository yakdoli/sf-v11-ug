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
using Syncfusion.Drawing;

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;

namespace EssentialChartSamples
{
    public class Form1 : Office2007Form
    {
        #region Private Members

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        Color[] color1 = new Color[] { Color.FromArgb(192, 126, 44), Color.FromArgb(255, 221, 158), Color.FromArgb(192, 126, 44) };
        Color[] color2 = new Color[] { Color.FromArgb(118, 147, 58), Color.FromArgb(200, 224, 150), Color.FromArgb(118, 147, 58) };
        private ComboBox comboBox1;
        private Label label12;
        private Panel panel1;
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
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.Moccasin;
            this.chartControl1.BorderAppearance.FrameThickness = new Syncfusion.Windows.Forms.Chart.ChartThickness(15F, 15F, 15F, 15F);
            this.chartControl1.BorderAppearance.Interior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(328, 81);
            this.chartControl1.Location = new System.Drawing.Point(14, 17);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 600, 100);
            this.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.Size = new System.Drawing.Size(464, 369);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Margin = 1;
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 0.20000000298023224;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox1.Location = new System.Drawing.Point(367, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 93;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(367, 23);
            this.label12.TabIndex = 92;
            this.label12.Text = "SkinStyle";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 404);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 23);
            this.panel1.TabIndex = 94;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Borders";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Form_Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Creates series and associate with the Chart control
            InitializeChartData();

            foreach (String str in Enum.GetNames(typeof(ChartBorderSkinStyle)))
                this.comboBox1.Items.Add(str);
            this.comboBox1.SelectedIndex = 1;

            // Customize the basic appearance and behaviour of Chart Control
            ChartAppearance.ApplyChartStyles(this.chartControl1);

        }
        #endregion

        #region Helper Methods
        
        #region InitializeChartData
        /// <summary>
        /// Initializes Chart Data
        /// </summary>
        private void InitializeChartData()
        {
            this.chartControl1.Series.Clear();           

            ChartSeries series2 = new ChartSeries();
            
            series2.Name = "Sales";          
            series2.Points.Add(1995, 370);
            series2.Points.Add(1996, 420);
            series2.Points.Add(1997, 330);
            series2.Points.Add(1998, 440);
            series2.Points.Add(1999, 230);
            series2.Points.Add(2000, 540);
            series2.Type = ChartSeriesType.Column;
            series2.Text = series2.Name;
            this.chartControl1.Series.Add(series2);

            ChartSeries series1 = new ChartSeries();

            series1.Name = "Profit";           
            series1.Points.Add(1995, 300);
            series1.Points.Add(1996, 240);
            series1.Points.Add(1997, 300);
            series1.Points.Add(1998, 240);
            series1.Points.Add(1999, 300);
            series1.Points.Add(2000, 240);
            series1.Type = ChartSeriesType.Column;
            series1.Text = series1.Name;
            this.chartControl1.Series.Add(series1);
        }
        #endregion      

        #endregion

        #region Border Settings
        /// <summary>
        /// Changes the border appearance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.BorderAppearance.SkinStyle = (ChartBorderSkinStyle)Enum.Parse(typeof(ChartBorderSkinStyle), this.comboBox1.SelectedItem.ToString(), true);
            if (this.comboBox1.SelectedIndex == 0)
                this.chartControl1.Titles[0].Text = "Essential Chart";
            else
                this.chartControl1.Titles[0].Text = this.chartControl1.BorderAppearance.SkinStyle.ToString() + " Border ";
        }
        #endregion
    }
}
