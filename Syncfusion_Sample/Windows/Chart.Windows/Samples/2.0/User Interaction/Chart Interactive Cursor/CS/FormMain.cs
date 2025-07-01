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
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
    public class FormMain : Syncfusion.Windows.Forms.Office2007Form
    {
        private IContainer components = null;
        #region Private Members

        private System.Windows.Forms.Panel panel1;
        private ChartInteractiveCursor cursor1;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label1;
        private CheckBox checkBox1;
        private ChartControl chartControl1;
        #endregion

        #region Constructor, Main and Dispose
        public FormMain()
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
            System.Drawing.StringFormat stringFormat1 = new System.Drawing.StringFormat();
            System.Drawing.StringFormat stringFormat2 = new System.Drawing.StringFormat();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(382, 75);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(8, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Crossing = double.NaN;
            stringFormat1.Alignment = System.Drawing.StringAlignment.Near;
            stringFormat1.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat1.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat1.Trimming = System.Drawing.StringTrimming.Character;
            this.chartControl1.PrimaryXAxis.LabelStringFormat = stringFormat1;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.Crossing = double.NaN;
            stringFormat2.Alignment = System.Drawing.StringAlignment.Far;
            stringFormat2.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
            stringFormat2.LineAlignment = System.Drawing.StringAlignment.Near;
            stringFormat2.Trimming = System.Drawing.StringTrimming.Character;
            this.chartControl1.PrimaryYAxis.LabelStringFormat = stringFormat2;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(491, 345);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5D;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.colorPickerButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(614, 77);
            this.panel1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "100",
            "150",
            "200"});
            this.comboBox2.Location = new System.Drawing.Point(250, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "YInterval";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2",
            "4",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(250, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "XInterval";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(34, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "MoveTo ChartArea";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(478, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cursor Color";
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.BackColor = System.Drawing.Color.Black;
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorPickerButton1.Location = new System.Drawing.Point(566, 0);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.SelectedAsBackcolor = true;
            this.colorPickerButton1.SelectedColor = System.Drawing.Color.Black;
            this.colorPickerButton1.Size = new System.Drawing.Size(24, 24);
            this.colorPickerButton1.TabIndex = 2;
            this.colorPickerButton1.UseVisualStyleBackColor = false;
            this.colorPickerButton1.ColorSelected += new System.EventHandler(this.Color_selected);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(54, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(457, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Click on the interactive cursor line and drag the chart area or series points";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 458);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Interactive Cursor";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void FormMain_Load(object sender, EventArgs e)
        {
            InitializeChartData();
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 0;
            
            this.label1.Enabled = true;
            this.label4.Enabled = true;
            this.comboBox1.Enabled = true;
            this.comboBox2.Enabled = true;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            //InitializeControlSettings();
        }
        #endregion

        #region Helper Methods

        #region InitializeChartData
        /// <summary>
        /// Initializes the ChartControl's data and sets the Chart type
        /// </summary>
        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries();
            series1.Name = "Server 1";
            series1.Type = ChartSeriesType.Line;
            series1.Text = series1.Name;
            int[] r1 = new int[] { 256, 491, 382, 437, 321, 234, 425, 257, 382, 296, 437, 451, 490, 366, 422, 361, 185, 384, 461, 258 };
            for (int i = 2; i < 20; i = i + 2)
                series1.Points.Add(i, r1[i]);

            series1.PrepareStyle += new ChartPrepareStyleInfoHandler(ChartControlSeries_PrepareStyle);

            this.chartControl1.Series.Add(series1);
            this.chartControl1.Text = "Chart Interactive cursor";
            cursor1 = new ChartInteractiveCursor(this.chartControl1.Series[0]);
            this.chartControl1.ChartArea.InteractiveCursors.Add(cursor1);
            cursor1.Color = Color.Black;
            this.chartControl1.ChartArea.InteractiveCursors[0].XPosition = 2;
            this.chartControl1.ChartArea.InteractiveCursors[0].YPosition = 2;
            this.chartControl1.ChartArea.InteractiveCursors[0].MoveToChartArea = this.checkBox1.Checked;
            if (this.chartControl1.ChartArea.InteractiveCursors[0].MoveToChartArea)
            {
                this.chartControl1.ChartArea.InteractiveCursors[0].XInterval = 2;
                this.chartControl1.ChartArea.InteractiveCursors[0].YInterval = 50;
            }
        }
        #endregion
        #endregion

        #region Events
        #region PrepareStyle
        /// <summary>
        /// Handler for the PrepareStyle event of ChartSeries. 
        /// </summary>
        /// <param name="sender">The ChartSeries object that raises this event.</param>
        /// <param name="args">The event data. Can be modified to change series appearance.</param>
        protected void ChartControlSeries_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            // Style formatting using a callback. You can apply the same settings directly on the series style on the
            // point styles.
            ChartSeries series = sender as ChartSeries;
            if (series != null)
            {
                args.Style.DisplayText = true;
                args.Style.TextFormat = "{0}";
                args.Style.TextOrientation = ChartTextOrientation.Up;
                args.Style.Symbol.Shape = ChartSymbolShape.Circle;
                args.Style.Symbol.Size = new Size(10, 10);
                args.Style.Symbol.Color = Color.White;
                args.Style.Symbol.Border.Color = Color.FromArgb(129, 115, 27);
                args.Style.Symbol.Border.Width = 2;
            }
        }
        #endregion


        private void Color_selected(object sender, System.EventArgs e)
        {
            cursor1.Color = this.colorPickerButton1.SelectedColor;

            this.chartControl1.Redraw(true);
        }

       
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked && this.chartControl1.ChartArea.InteractiveCursors.Count >0)
            {
                this.chartControl1.ChartArea.InteractiveCursors[0].MoveToChartArea = this.checkBox1.Checked;
                this.label1.Enabled = true;
                this.label4.Enabled = true;
                this.comboBox1.Enabled = true;
                this.comboBox2.Enabled = true;
            }
            else
            {
                if (this.chartControl1.ChartArea.InteractiveCursors.Count > 0)
                {
                    this.chartControl1.ChartArea.InteractiveCursors[0].MoveToChartArea = this.checkBox1.Checked;
                }
                this.label1.Enabled = false;
                this.label4.Enabled = false;
                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
            }
            this.chartControl1.Redraw(true);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.ChartArea.InteractiveCursors[0].XInterval = Convert.ToDouble(this.comboBox1.SelectedItem);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.chartControl1.ChartArea.InteractiveCursors[0].YInterval = Convert.ToDouble(this.comboBox2.SelectedItem);
        }
    }
}