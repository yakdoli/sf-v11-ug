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
    public class Form1 : Office2007Form
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private DataSet prodDs1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.IContainer components;
        private ChartDataBindModel model = null;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;

        DateTime lastTime = DateTime.Now;
        #endregion

        #region Form Constructor, Main And Dispose
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.Teal;
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Open;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.Depth = 1F;
            this.chartControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Legend.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chartControl1.Legend.Location = new System.Drawing.Point(85, 419);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Location = new System.Drawing.Point(11, 11);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.Gray;
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.Color.MidnightBlue;
            this.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chartControl1.PrimaryYAxis.LineType.BackColor = System.Drawing.Color.MidnightBlue;
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.Color.MidnightBlue;
            this.chartControl1.Rotation = 0.1F;
            this.chartControl1.Size = new System.Drawing.Size(530, 394);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "Syncfusion Essential Chart";
            this.chartControl1.Tilt = 0.1F;
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Syncfusion Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 39);
            this.panel1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(428, 11);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(79, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(48, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Interval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(216, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Line Style";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(395, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.Location = new System.Drawing.Point(90, 12);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(79, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Location = new System.Drawing.Point(270, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(79, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 439);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Real Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            CreateDataSet();
            InitializeChartData();            
            InitializeControlSettings();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

        #region Helper Methods
        #region InitializeControlSettings

        private void InitializeControlSettings()
        {
            foreach (string dashstyle in Enum.GetNames(typeof(System.Drawing.Drawing2D.DashStyle)))
                this.comboBox1.Items.Add(dashstyle);
            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.Items.Add(100);
            this.comboBox2.Items.Add(200);
            this.comboBox2.Items.Add(400);
            this.comboBox2.Items.Add(600);
            this.comboBox2.Items.Add(800);
            this.comboBox2.Items.Add(1000);
            this.comboBox2.SelectedIndex = 3;
        }
        #endregion

        #region InitializeChartData
        protected void InitializeChartData()
        {
            this.chartControl1.Indexed = false;
            ChartSeries series = new ChartSeries();
            series.Name = "Products";
            series.Text = series.Name;
            model = new ChartDataBindModel(this.prodDs1, "Products");
            model.XName = "Date";
            model.YNames = new String[] { "Load" };
            series.SeriesModel = model;
            series.Type = ChartSeriesType.Spline;
            series.Style.DisplayShadow = false;
            this.chartControl1.Series.Add(series);
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            this.chartControl1.PrimaryXAxis.DateTimeFormat = "dd-hh:mm tt";
            this.chartControl1.PrimaryXAxis.RoundingPlaces = 12;
            this.chartControl1.PrimaryXAxis.RangeType = ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(lastTime, lastTime.AddDays(1), 4, ChartDateTimeIntervalType.Hours);
        }
        #endregion

        #region CreateDataSet
        private void CreateDataSet()
        {
            string tableName = "Products";
            prodDs1 = new DataSet();
            prodDs1.Tables.Add(tableName);

            DataColumn ExpiresDate = prodDs1.Tables[tableName].Columns.Add("Date", typeof(System.DateTime));
            DataColumn Quantity = prodDs1.Tables[tableName].Columns.Add("Load", typeof(double));

            this.timer1.Start();
        }
        #endregion
        #endregion

        #region Events
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            try
            {
                string tableName = "Products";
                Random rand = new Random();
                if (prodDs1 != null && prodDs1.Tables.Count > 0)
                {
                    DataRow drEmpty = prodDs1.Tables[tableName].NewRow();
                    prodDs1.Tables[tableName].Rows.Add(drEmpty);
                    int count = Math.Max(0, prodDs1.Tables[tableName].Rows.Count - 1);

                    prodDs1.Tables[tableName].Rows[count]["Load"] = (double)rand.Next(0, 60);
                    prodDs1.Tables[tableName].Rows[count]["Date"] = lastTime.AddMinutes(30);
                    lastTime = (DateTime)prodDs1.Tables[tableName].Rows[count]["Date"];

                    if (lastTime >= this.chartControl1.PrimaryXAxis.DateTimeRange.End)
                        this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(this.chartControl1.PrimaryXAxis.DateTimeRange.Start, this.chartControl1.PrimaryXAxis.DateTimeRange.End.AddDays(1), 4, ChartDateTimeIntervalType.Hours);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series[0].Style.Border.DashStyle = (DashStyle)Enum.Parse(typeof(DashStyle), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Redraw(true);
        }

        private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.timer1.Interval = (int)this.comboBox2.SelectedItem;
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series[0].Style.Border.Width = float.Parse(this.numericUpDown1.Value.ToString());
            this.chartControl1.Refresh();
        }

        #endregion
    }
}