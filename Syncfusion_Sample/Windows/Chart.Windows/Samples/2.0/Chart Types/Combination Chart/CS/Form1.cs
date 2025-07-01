using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace CombinationCharts
{
    public class Form1 : Office2007Form
    {

        #region Private Members

        private System.Windows.Forms.Panel panel1;

        private ChartStripLine line = new ChartStripLine();

        private ChartAxis secaxis = new ChartAxis();

        private System.Windows.Forms.CheckBox checkBox_3D;
        private ChartControl chartControl1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #endregion

        #region Constructor, Main And Dispose
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
            this.checkBox_3D = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_3D
            // 
            this.checkBox_3D.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox_3D.Location = new System.Drawing.Point(515, 0);
            this.checkBox_3D.Name = "checkBox_3D";
            this.checkBox_3D.Size = new System.Drawing.Size(77, 28);
            this.checkBox_3D.TabIndex = 2;
            this.checkBox_3D.Text = "3D View";
            this.checkBox_3D.CheckedChanged += new System.EventHandler(this.checkBox_3D_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.checkBox_3D);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 374);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 28);
            this.panel1.TabIndex = 2;
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(251)))), ((int)(((byte)(255))))), System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(174)))), ((int)(((byte)(206)))));
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(5, 5, 5, 5);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(251)))), ((int)(((byte)(255))))));
            this.chartControl1.ElementsSpacing = 0;
            this.chartControl1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Legend.ItemsSize = new System.Drawing.Size(15, 15);
            this.chartControl1.Legend.Location = new System.Drawing.Point(34, 65);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.Legend.ShowBorder = true;
            this.chartControl1.Legend.FilterItems += new Syncfusion.Windows.Forms.Chart.LegendFilterItemsEventHandler(this.chartControl1_Legend_FilterItems);
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Pastel;
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.Series3D = true;
            this.chartControl1.Size = new System.Drawing.Size(568, 351);
            this.chartControl1.TabIndex = 3;
            this.chartControl1.Text = "Combination Chart ";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Combination Chart ";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(226)))));
            this.chartControl1.ToolBar.ButtonBackColor = System.Drawing.SystemColors.ControlLight;
            this.chartControl1.ToolBar.ButtonForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.chartControl1.ToolBar.ButtonSize = new System.Drawing.Size(26, 26);
            this.chartControl1.ZoomOutIncrement = 1.5;
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 402);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combination Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.chartControl1.Series.Clear();
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }

        #endregion

        #region Helper Methods

        #region InitializeChartData
        protected void InitializeChartData()
        {
            this.secaxis.Labels.Clear();
            for (int i = 0; i < 3; i++)
            {
                ChartSeries Combination = new ChartSeries("Gold");
                if (i == 0)
                {
                    Combination.Text = "Bronze";
                    Combination.Points.Add(1, 36);
                    Combination.Points.Add(2, 28);
                    Combination.Points.Add(3, 28);
                    Combination.Points.Add(4, 15);
                    Combination.Points.Add(5, 15);
                    Combination.Points.Add(6, 17);
                    Combination.Type = ChartSeriesType.Spline;
                }
                else if (i == 1)
                {
                    Combination.Text = "Silver";
                    Combination.Points.Add(1, 38);
                    Combination.Points.Add(2, 21);
                    Combination.Points.Add(3, 21);
                    Combination.Points.Add(4, 13);
                    Combination.Points.Add(5, 10);
                    Combination.Points.Add(6, 15);
                    Combination.Type = ChartSeriesType.Line;
                }
                else
                {
                    Combination.Points.Add(1, 36);
                    Combination.Points.Add(2, 51);
                    Combination.Points.Add(3, 23);
                    Combination.Points.Add(4, 19);
                    Combination.Points.Add(5, 16);
                    Combination.Points.Add(6, 14);
                    Combination.Type = ChartSeriesType.Column;
                    
                }
                this.chartControl1.Series.Add(Combination);
            }
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(0, 60, 10);
            this.chartControl1.Rotation = 60;
            this.chartControl1.Series3D = false;
            this.checkBox_3D.Checked = false;
        }

        #endregion
        #endregion

        # region Events
        private void checkBox_3D_CheckedChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series3D = this.checkBox_3D.Checked;
            if (checkBox_3D.Checked)
            {
                this.chartControl1.Series[2].Style.Border.Color = Color.FromArgb(253, 171, 0);
            }
            else
            {
                this.chartControl1.Series[2].Style.Border.Color = Color.Transparent;
            }
        }
        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                if (e.Value == 1)
                    e.Label = "USA";
                else if (e.Value == 2)
                    e.Label = "China";
                else if (e.Value == 3)
                    e.Label = "Russia";
                else if (e.Value == 4)
                    e.Label = "Great Britian";
                else if (e.Value == 5)
                    e.Label = "Germany";
                else if (e.Value == 6)
                    e.Label = "Australia";
                else
                    e.Label = "";
                e.Handled = true;
            }
        }

        private void chartControl1_Legend_FilterItems(object sender, ChartLegendFilterItemsEventArgs e)
        {
            ChartLegendItemsCollection items = new ChartLegendItemsCollection();
            for (int i = e.Items.Count - 1; i >= 0; i--)
            {
                items.Add(e.Items[i]);
            }
            e.Items = items;
        }
        #endregion

    }
}