
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
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    /// <summary>
    /// The ChartControl sample form.
    /// </summary>
    public class FormMain : Office2007Form
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxAutoHighlight;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        ChartSeries series1;
        private Label label21;
        private Label label22;
        private Panel panel2;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label22 = new System.Windows.Forms.Label();
            this.checkBoxAutoHighlight = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            this.chartControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chartControl1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(58, 292);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.Size = new System.Drawing.Size(478, 369);
            this.chartControl1.TabIndex = 2;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.colorPickerButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.checkBoxAutoHighlight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 56);
            this.panel1.TabIndex = 3;
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.Transparent;
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.colorPickerButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.colorPickerButton1.Location = new System.Drawing.Point(477, 25);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.Transparent;
            this.colorPickerButton1.SelectedColorGroup = Syncfusion.Windows.Forms.ColorUISelectedGroup.None;
            this.colorPickerButton1.Size = new System.Drawing.Size(20, 20);
            this.colorPickerButton1.TabIndex = 2;
            this.colorPickerButton1.Text = "...";
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.Color_Selected);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Location = new System.Drawing.Point(418, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 18);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Specific";
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label21.Location = new System.Drawing.Point(329, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(162, 1);
            this.label21.TabIndex = 5;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Location = new System.Drawing.Point(328, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(78, 18);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Automatic";
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label22.Location = new System.Drawing.Point(325, 4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 14);
            this.label22.TabIndex = 4;
            this.label22.Text = "Highlight Color";
            // 
            // checkBoxAutoHighlight
            // 
            this.checkBoxAutoHighlight.AutoSize = true;
            this.checkBoxAutoHighlight.Checked = true;
            this.checkBoxAutoHighlight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoHighlight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxAutoHighlight.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxAutoHighlight.Location = new System.Drawing.Point(18, 25);
            this.checkBoxAutoHighlight.Name = "checkBoxAutoHighlight";
            this.checkBoxAutoHighlight.Size = new System.Drawing.Size(98, 18);
            this.checkBoxAutoHighlight.TabIndex = 0;
            this.checkBoxAutoHighlight.Text = "Auto Highlight";
            this.checkBoxAutoHighlight.CheckedChanged += new System.EventHandler(this.checkBoxAutoHighlight_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.chartControl1);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(493, 393);
            this.panel2.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Auto Highlight ";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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

            series1 = new ChartSeries("Market");
            series1.Name = "Market";
            series1.Text = series1.Name;
            series1.Points.Add(0, 16);
            series1.Points.Add(1, 10);
            series1.Points.Add(2, 13);
            series1.Points.Add(3, 17);
            series1.Points.Add(4, 11);
            series1.Points.Add(5, 18);
            series1.Points.Add(6, 10);
            series1.Points.Add(7, 15);

            series1.Type = ChartSeriesType.Pie;
            this.chartControl1.AutoHighlight = this.checkBoxAutoHighlight.Checked;
            this.chartControl1.Series.Add(series1);
            series1.Style.DisplayText = true;
            series1.Style.TextColor = Color.Black;
            this.chartControl1.SmoothingMode = SmoothingMode.AntiAlias;
            series1.Styles[0].Text = string.Format("Production {0}%", series1.Points[0].YValues[0]);
            series1.Styles[1].Text = string.Format("Labor {0}%", series1.Points[1].YValues[0]);
            series1.Styles[2].Text = string.Format("Facilities {0}%", series1.Points[2].YValues[0]);
            series1.Styles[3].Text = string.Format("Taxes {0}%", series1.Points[3].YValues[0]);
            series1.Styles[4].Text = string.Format("Insurance{0}%", series1.Points[4].YValues[0]);
            series1.Styles[5].Text = string.Format("Licenses {0}%", series1.Points[5].YValues[0]);
            series1.Styles[6].Text = string.Format("Legal {0}%", series1.Points[6].YValues[0]);
            series1.Styles[7].Text = string.Format("Health {0}%", series1.Points[7].YValues[0]);
            this.chartControl1.ShowLegend = false;
            this.colorPickerButton1.SelectedColor = Color.Gold;
        }
        #endregion

        #region Events

        private void checkBoxAutoHighlight_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBoxAutoHighlight.Checked)
            {
                this.chartControl1.AutoHighlight = true;
                this.chartControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            }
            else
            {
                this.chartControl1.AutoHighlight = false;
                this.chartControl1.Cursor = System.Windows.Forms.Cursors.Default;
            }
        }

        private void Color_Selected(object sender, System.EventArgs e)
        {
            BrushInfo interior = this.chartControl1.Series[0].Style.HighlightInterior;
            if (interior == null)
                interior = new BrushInfo();
            if (this.radioButton2.Checked)
            {
                Color foreColor = interior.ForeColor;
                this.chartControl1.Series[0].Style.HighlightInterior = new BrushInfo(GradientStyle.None, foreColor, this.colorPickerButton1.SelectedColor);
                this.chartControl1.Refresh();
            }
        }

        private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.radioButton1.Checked)
                this.chartControl1.Series[0].Style.HighlightInterior = null;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BrushInfo interior = this.chartControl1.Series[0].Style.HighlightInterior;
            if (interior == null)
                interior = new BrushInfo();
            Color foreColor = interior.ForeColor;
            // Specifying a "Gold" highlight color.
            this.chartControl1.Series[0].Style.HighlightInterior = new BrushInfo(GradientStyle.None, foreColor, this.colorPickerButton1.SelectedColor);
        }
        #endregion
    }
}