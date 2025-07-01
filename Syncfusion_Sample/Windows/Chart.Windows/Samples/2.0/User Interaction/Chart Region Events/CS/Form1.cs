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

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    public class Form1 : Syncfusion.Windows.Forms.Office2007Form
    {
        #region Private Members
        private TextBox textBox1;
        private Button btnClearLog;
        private CheckBox chkRegionClick;
        private CheckBox chkMouseDown;
        private CheckBox chkMouseUp;
        private CheckBox chkMouseHover;
        private CheckBox chkMouseLeave;
        private CheckBox chkMouseEnter;
        private CheckBox chkMouseMove;
        private ChartControl chartControl1;
        private Label label1;
        private Label label12;
        private ChartControl chartControl2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private Panel panel1;
        Color[] color1 = new Color[] { Color.FromArgb(132, 101, 173), Color.FromArgb(46, 238, 255), Color.FromArgb(132, 101, 173) };
        private CheckBox chkRegionDoubleClick;
        private IContainer components = null;
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
            this.chartControl2 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkRegionClick = new System.Windows.Forms.CheckBox();
            this.chkMouseDown = new System.Windows.Forms.CheckBox();
            this.chkMouseUp = new System.Windows.Forms.CheckBox();
            this.chkMouseEnter = new System.Windows.Forms.CheckBox();
            this.chkMouseMove = new System.Windows.Forms.CheckBox();
            this.chkMouseLeave = new System.Windows.Forms.CheckBox();
            this.chkMouseHover = new System.Windows.Forms.CheckBox();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.chkRegionDoubleClick = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl2
            // 
            this.chartControl2.AcceptFocus = false;
            this.chartControl2.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl2.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl2.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(5, 1, 1, 5);
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Indexed = true;
            // 
            // 
            // 
            this.chartControl2.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl2.Legend.Location = new System.Drawing.Point(267, 31);
            this.chartControl2.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.chartControl2.Legend.Visible = false;
            this.chartControl2.Location = new System.Drawing.Point(0, 0);
            this.chartControl2.MinZoomFactorX = 1E-05;
            this.chartControl2.MinZoomFactorY = 1E-05;
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl2.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl2.Series3D = true;
            this.chartControl2.Size = new System.Drawing.Size(128, 128);
            this.chartControl2.TabIndex = 111;
            // 
            // 
            // 
            this.chartControl2.Title.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl2.Title.Margin = 1;
            this.chartControl2.Title.Name = "Def_title";
            this.chartControl2.Title.Text = "";
            this.chartControl2.Titles.Add(this.chartControl2.Title);
            this.chartControl2.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.chartControl2.ToolBar.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.chartControl2.ZoomOutIncrement = 1.5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(4, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 110;
            this.label1.Text = "Event Log";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 18);
            this.label12.TabIndex = 109;
            this.label12.Text = "Turn On/Off event handlers";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClearLog
            // 
            this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnClearLog.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClearLog.Location = new System.Drawing.Point(453, 317);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(74, 24);
            this.btnClearLog.TabIndex = 7;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(231)))), ((int)(((byte)(247)))));
            this.textBox1.Location = new System.Drawing.Point(7, 137);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(520, 176);
            this.textBox1.TabIndex = 2;
            // 
            // chkRegionClick
            // 
            this.chkRegionClick.AutoSize = true;
            this.chkRegionClick.Checked = true;
            this.chkRegionClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRegionClick.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkRegionClick.Location = new System.Drawing.Point(7, 4);
            this.chkRegionClick.Name = "chkRegionClick";
            this.chkRegionClick.Size = new System.Drawing.Size(117, 18);
            this.chkRegionClick.TabIndex = 6;
            this.chkRegionClick.Text = "ChartRegion Click";
            // 
            // chkMouseDown
            // 
            this.chkMouseDown.AutoSize = true;
            this.chkMouseDown.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMouseDown.Location = new System.Drawing.Point(7, 28);
            this.chkMouseDown.Name = "chkMouseDown";
            this.chkMouseDown.Size = new System.Drawing.Size(154, 18);
            this.chkMouseDown.TabIndex = 0;
            this.chkMouseDown.Text = "ChartRegion MouseDown";
            // 
            // chkMouseUp
            // 
            this.chkMouseUp.AutoSize = true;
            this.chkMouseUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMouseUp.Location = new System.Drawing.Point(168, 80);
            this.chkMouseUp.Name = "chkMouseUp";
            this.chkMouseUp.Size = new System.Drawing.Size(140, 18);
            this.chkMouseUp.TabIndex = 5;
            this.chkMouseUp.Text = "ChartRegion MouseUp";
            // 
            // chkMouseEnter
            // 
            this.chkMouseEnter.AutoSize = true;
            this.chkMouseEnter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMouseEnter.Location = new System.Drawing.Point(7, 54);
            this.chkMouseEnter.Name = "chkMouseEnter";
            this.chkMouseEnter.Size = new System.Drawing.Size(151, 18);
            this.chkMouseEnter.TabIndex = 1;
            this.chkMouseEnter.Text = "ChartRegion MouseEnter";
            // 
            // chkMouseMove
            // 
            this.chkMouseMove.AutoSize = true;
            this.chkMouseMove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMouseMove.Location = new System.Drawing.Point(168, 54);
            this.chkMouseMove.Name = "chkMouseMove";
            this.chkMouseMove.Size = new System.Drawing.Size(153, 18);
            this.chkMouseMove.TabIndex = 4;
            this.chkMouseMove.Text = "ChartRegion MouseMove";
            // 
            // chkMouseLeave
            // 
            this.chkMouseLeave.AutoSize = true;
            this.chkMouseLeave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMouseLeave.Location = new System.Drawing.Point(168, 28);
            this.chkMouseLeave.Name = "chkMouseLeave";
            this.chkMouseLeave.Size = new System.Drawing.Size(156, 18);
            this.chkMouseLeave.TabIndex = 3;
            this.chkMouseLeave.Text = "ChartRegion MouseLeave";
            // 
            // chkMouseHover
            // 
            this.chkMouseHover.AutoSize = true;
            this.chkMouseHover.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkMouseHover.Location = new System.Drawing.Point(7, 80);
            this.chkMouseHover.Name = "chkMouseHover";
            this.chkMouseHover.Size = new System.Drawing.Size(155, 18);
            this.chkMouseHover.TabIndex = 2;
            this.chkMouseHover.Text = "ChartRegion MouseHover";
            // 
            // chartControl1
            // 
            this.chartControl1.AcceptFocus = false;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(186)))), ((int)(((byte)(239))))), System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(186)))), ((int)(((byte)(239))))));
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Indexed = true;
            // 
            // 
            // 
            this.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(277, 146);
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.MinZoomFactorX = 1E-05;
            this.chartControl1.MinZoomFactorY = 1E-05;
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Size = new System.Drawing.Size(398, 299);
            this.chartControl1.TabIndex = 8;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(199)))), ((int)(((byte)(165)))));
            this.chartControl1.ToolBar.ButtonBackColor = System.Drawing.SystemColors.ControlLight;
            this.chartControl1.ToolBar.ButtonForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.chartControl1.ToolBar.ButtonSize = new System.Drawing.Size(26, 26);
            this.chartControl1.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.ToolBar.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.chartControl1.ZoomOutIncrement = 1.5;
            this.chartControl1.ChartRegionMouseLeave += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseLeave);
            this.chartControl1.ChartRegionMouseEnter += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseEnter);
            this.chartControl1.ChartRegionMouseMove += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseMove);
            this.chartControl1.ChartRegionDoubleClick += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionDoubleClick);
            this.chartControl1.ChartRegionMouseDown += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseDown);
            this.chartControl1.ChartRegionMouseHover += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseHover);
            this.chartControl1.ChartRegionMouseUp += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseUp);
            this.chartControl1.ChartRegionClick += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionClick);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.White;
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label12);
            this.gradientPanel1.Location = new System.Drawing.Point(574, 62);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(182, 243);
            this.gradientPanel1.TabIndex = 113;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.White;
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.chkRegionDoubleClick);
            this.gradientPanel2.Controls.Add(this.panel1);
            this.gradientPanel2.Controls.Add(this.chkRegionClick);
            this.gradientPanel2.Controls.Add(this.chkMouseLeave);
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Controls.Add(this.chkMouseMove);
            this.gradientPanel2.Controls.Add(this.chkMouseHover);
            this.gradientPanel2.Controls.Add(this.chkMouseUp);
            this.gradientPanel2.Controls.Add(this.textBox1);
            this.gradientPanel2.Controls.Add(this.btnClearLog);
            this.gradientPanel2.Controls.Add(this.chkMouseDown);
            this.gradientPanel2.Controls.Add(this.chkMouseEnter);
            this.gradientPanel2.Location = new System.Drawing.Point(6, 316);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(533, 346);
            this.gradientPanel2.TabIndex = 114;
            // 
            // chkRegionDoubleClick
            // 
            this.chkRegionDoubleClick.AutoSize = true;
            this.chkRegionDoubleClick.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkRegionDoubleClick.Location = new System.Drawing.Point(168, 5);
            this.chkRegionDoubleClick.Name = "chkRegionDoubleClick";
            this.chkRegionDoubleClick.Size = new System.Drawing.Size(154, 18);
            this.chkRegionDoubleClick.TabIndex = 114;
            this.chkRegionDoubleClick.Text = "ChartRegion Double Click";
            this.chkRegionDoubleClick.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartControl2);
            this.panel1.Location = new System.Drawing.Point(400, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 128);
            this.panel1.TabIndex = 113;
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BackColor = System.Drawing.Color.White;
            this.gradientPanel4.BorderColor = System.Drawing.Color.White;
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel4.Controls.Add(this.chartControl1);
            this.gradientPanel4.Location = new System.Drawing.Point(71, 6);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(400, 301);
            this.gradientPanel4.TabIndex = 116;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 666);
            this.Controls.Add(this.gradientPanel4);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.gradientPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Region Events";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
       
        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();            
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            ChartAppearance.ApplyChartStyles1(this.chartControl2);
        }
        #endregion

        #region Helper Methods
        
        #region InitializeChartData
        private void InitializeChartData()
        {
            ChartSeries c1series1 = new ChartSeries();
            c1series1.Name = "Sales";
            c1series1.Type = ChartSeriesType.Column;
            c1series1.Text = c1series1.Name;
            c1series1.Points.Add(1, 256);
            c1series1.Points.Add(2, 491);
            c1series1.Points.Add(3, 382);
            c1series1.Points.Add(4, 437);
            this.chartControl1.Series.Add(c1series1);
            
            ChartSeries c2series1 = new ChartSeries();
            c2series1.Name = "Sales";
            c2series1.Type = ChartSeriesType.Column;
            c2series1.Text = c2series1.Name;
            c2series1.Points.Add(1, 2);
            c2series1.Points.Add(2, 5);
            c2series1.Points.Add(3, 3);
            c2series1.Points.Add(4, 4);
            this.chartControl2.Series.Add(c2series1);
            this.panel1.Visible = false;
        }
        #endregion

        #region OutputText
        private void OutputText(string output)
        {
            this.textBox1.Text += output + "\r\n";
            this.textBox1.SelectionStart = this.textBox1.Text.Length - 1;
            this.textBox1.SelectionLength = 0;
            this.textBox1.ScrollToCaret();
        }
        #endregion

        #region ShowChartRegion
        protected void ShowChartRegion(string regionName)
        {
            this.panel1.Visible = true;
            if (regionName == "ChartArea region")
            {
                this.chartControl2.Titles[0].Text = "Chart Area";
                this.chartControl2.Series[0].Visible = false;
                this.chartControl2.ChartArea.RequireAxes = true;
                this.chartControl2.PrimaryXAxis.ValueType = ChartValueType.Custom;
                this.chartControl2.PrimaryYAxis.ValueType = ChartValueType.Custom;
                this.chartControl2.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartInterior = new Syncfusion.Drawing.BrushInfo(Color.White);

            }
            else if (regionName == "Axes region")
            {
                this.chartControl2.Titles[0].Text = "Chart Axes";
                this.chartControl2.Series[0].Visible = false;
                this.chartControl2.ChartArea.RequireAxes = true;
                this.chartControl2.PrimaryXAxis.ValueType = ChartValueType.Double;
                this.chartControl2.PrimaryYAxis.ValueType = ChartValueType.Double;
                this.chartControl2.PrimaryYAxis.RangeType = ChartAxisRangeType.Set;
                this.chartControl2.PrimaryYAxis.Range = new MinMaxInfo(0, 6, 2);
                this.chartControl2.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartInterior = new Syncfusion.Drawing.BrushInfo(Color.White);

            }
            else if (regionName == "ChartSeries")
            {
                this.chartControl2.Titles[0].Text = "Chart Series";
                this.chartControl2.Series[0].Visible = true;
                this.chartControl2.ChartArea.RequireAxes = false;
                this.chartControl2.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
            }
            else
            {
                this.chartControl2.Titles[0].Text = "Chart Control";
                this.chartControl2.Series[0].Visible = false;
                this.chartControl2.ChartArea.RequireAxes = false;
                this.chartControl2.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
                this.chartControl2.ChartInterior = new Syncfusion.Drawing.BrushInfo(Color.White);
            }
        }
        #endregion

        #endregion

        #region Events
        #region ChartRegionMouseDown
        private void chartControl1_ChartRegionMouseDown(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.chkMouseDown.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("MouseDown over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("MouseDown over {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }
            }
        }
        #endregion
        
        #region ChartRegionMouseEnter
        private void chartControl1_ChartRegionMouseEnter(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.chkMouseEnter.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("MouseEnter over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("MouseEnter over  {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }
            }
        }
        #endregion

        #region ChartRegionMouseHover
        private void chartControl1_ChartRegionMouseHover(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.chkMouseHover.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("MouseHover over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("MouseHover over {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }
            }
        }
        #endregion

        #region ChartRegionMouseLeave
        private void chartControl1_ChartRegionMouseLeave(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.chkMouseLeave.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("MouseLeave over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("MouseLeave over {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }
            }
        }
        #endregion

        #region ChartRegionMouseMove
        private void chartControl1_ChartRegionMouseMove(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.chkMouseMove.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("MouseMove over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("MouseMove over {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }
            }
        }
        #endregion

        #region ChartRegionMouseUp
        private void chartControl1_ChartRegionMouseUp(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.chkMouseUp.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("MouseUp over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("MouseUp over {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }
            }
        }
        #endregion

        #region ChartRegionClick
        private void chartControl1_ChartRegionClick(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
        {
            if (this.chkRegionClick.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("Click over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("Click over {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }

            }
        }
        #endregion

        #region ChartRegionDoubleClick
        private void chartControl1_ChartRegionDoubleClick(object sender, ChartRegionMouseEventArgs e)
        {
            if (this.chkRegionDoubleClick.Checked)
            {
                if (e.Region.SeriesIndex == 0)
                {
                    OutputText(String.Format("Double Click over Series 1 Column {0} Point : {1}", e.Region.PointIndex, e.Point));
                    ShowChartRegion("ChartSeries");
                }
                else
                {
                    OutputText(String.Format("Double Click over {0}", e.Region.Description.ToString()));
                    ShowChartRegion(e.Region.Description.ToString());
                }

            }
        }
         #endregion

        #region Clear Log
        private void button1_Click(object sender, System.EventArgs e)
        {
            this.textBox1.Clear();

        }
       #endregion

       

        #endregion

    }
}