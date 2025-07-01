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
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		
		private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private ComboBox CBox_AxesLayoutMode;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel2;
		private ChartAxis secXAxis = new ChartAxis();

		public FormMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();


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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.autoLabel2 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.CBox_AxesLayoutMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(210)))), ((int)(((byte)(193))))), System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.ForwardDiagonal, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(2, -1, 5, 2);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.ForeColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Legend.ItemsSize = new System.Drawing.Size(15, 15);
            this.chartControl1.Legend.Location = new System.Drawing.Point(195, 54);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.Legend.Spacing = 3;
            this.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartControl1.Location = new System.Drawing.Point(19, 17);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.DrawGrid = false;
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(193)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryYAxis.DrawGrid = false;
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.PrimaryYAxis.GridLineType.BackColor = System.Drawing.Color.White;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.DarkGray;
            this.chartControl1.PrimaryYAxis.GridLineType.PenType = System.Drawing.Drawing2D.PenType.PathGradient;
            this.chartControl1.PrimaryYAxis.GridLineType.Width = 0F;
            this.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.ShowToolTips = true;
            this.chartControl1.Size = new System.Drawing.Size(461, 384);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "Weather Report";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.autoLabel2);
            this.panel1.Controls.Add(this.CBox_AxesLayoutMode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.autoLabel1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(499, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 415);
            this.panel1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Wrap",
            "Ellipsis"});
            this.comboBox1.Location = new System.Drawing.Point(8, 266);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 21);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(8, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 1);
            this.label5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(5, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 14);
            this.label6.TabIndex = 15;
            this.label6.Text = "Axes Title Draw Mode";
            // 
            // autoLabel2
            // 
            this.autoLabel2.DX = 0;
            this.autoLabel2.DY = 0;
            this.autoLabel2.Location = new System.Drawing.Point(6, 239);
            this.autoLabel2.Name = "autoLabel2";
            this.autoLabel2.Size = new System.Drawing.Size(85, 13);
            this.autoLabel2.TabIndex = 14;
            this.autoLabel2.Text = "Title Draw Mode";
            // 
            // CBox_AxesLayoutMode
            // 
            this.CBox_AxesLayoutMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBox_AxesLayoutMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBox_AxesLayoutMode.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CBox_AxesLayoutMode.Items.AddRange(new object[] {
            "SideBySide",
            "Stacking"});
            this.CBox_AxesLayoutMode.Location = new System.Drawing.Point(8, 166);
            this.CBox_AxesLayoutMode.Name = "CBox_AxesLayoutMode";
            this.CBox_AxesLayoutMode.Size = new System.Drawing.Size(143, 21);
            this.CBox_AxesLayoutMode.TabIndex = 13;
            this.CBox_AxesLayoutMode.SelectedIndexChanged += new System.EventHandler(this.CBox_AxesLayoutMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(7, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 1);
            this.label1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(4, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 14);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chart Mutiple Axes";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(8, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 1);
            this.label2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(5, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 9;
            this.label3.Text = "Axes layout Mode";
            // 
            // autoLabel1
            // 
            this.autoLabel1.DX = 0;
            this.autoLabel1.DY = 0;
            this.autoLabel1.Location = new System.Drawing.Point(6, 139);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(114, 13);
            this.autoLabel1.TabIndex = 1;
            this.autoLabel1.Text = "ChartAxesLayoutMode";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(10, 59);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 16);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Opposed Position";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkbox1_changed);
            // 
            // FormMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 415);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Multiple Axes";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

	    /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new FormMain());
		}
		
		private void FormMain_Load(object sender, System.EventArgs e)
        {
            CBox_AxesLayoutMode.SelectedIndex = 1;
            comboBox1.SelectedIndex = 2;            
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
          
         }
		
		#region InitializeChartData()
		/// <summary>
		/// Initializes the ChartControl's data and sets the Chart type
		/// </summary>
        
        ChartAxis secYAxis = new ChartAxis();
        protected void InitializeChartData()
        {

            //Scatter Line
            ChartSeries series1 = new ChartSeries(" Min.Temperature ");
            series1.Type = ChartSeriesType.Scatter;
            DateTime start = DateTime.Now;

            series1.Points.Add(start.AddMonths(0), -5);
            series1.Points.Add(start.AddMonths(1), 0);
            series1.Points.Add(start.AddMonths(2), 3);
            series1.Points.Add(start.AddMonths(3), 6);
            series1.Points.Add(start.AddMonths(4), 15);
            series1.Points.Add(start.AddMonths(5), 22);
            series1.Points.Add(start.AddMonths(6), 30);
            series1.Points.Add(start.AddMonths(7), 28);
            series1.Points.Add(start.AddMonths(8), 21);
            series1.Points.Add(start.AddMonths(9), 13);
            series1.Points.Add(start.AddMonths(10), 6);
            series1.Points.Add(start.AddMonths(11), 1);

            ChartSeries series2 = new ChartSeries(" Avg.Temperature ");
            series2.Text = series2.Name;
            series2.Type = ChartSeriesType.Scatter;

            series2.Points.Add(start.AddMonths(0), 2);
            series2.Points.Add(start.AddMonths(1), 4);
            series2.Points.Add(start.AddMonths(2), 5);
            series2.Points.Add(start.AddMonths(3), 11);
            series2.Points.Add(start.AddMonths(4), 19);
            series2.Points.Add(start.AddMonths(5), 26);
            series2.Points.Add(start.AddMonths(6), 35);
            series2.Points.Add(start.AddMonths(7), 32);
            series2.Points.Add(start.AddMonths(8), 25);
            series2.Points.Add(start.AddMonths(9), 16);
            series2.Points.Add(start.AddMonths(10), 9);
            series2.Points.Add(start.AddMonths(11), 2);


            ChartSeries series3 = new ChartSeries(" Avg. Rainfall");
            series3.Text = series3.Name;
            series3.Type = ChartSeriesType.Scatter;

            series3.Points.Add(start.AddMonths(0), 62);
            series3.Points.Add(start.AddMonths(1), 73);
            series3.Points.Add(start.AddMonths(2), 95);
            series3.Points.Add(start.AddMonths(3), 107);
            series3.Points.Add(start.AddMonths(4), 85);
            series3.Points.Add(start.AddMonths(5), 60);
            series3.Points.Add(start.AddMonths(6), 73);
            series3.Points.Add(start.AddMonths(7), 105);
            series3.Points.Add(start.AddMonths(9), 83);
            series3.Points.Add(start.AddMonths(10), 84);
            series3.Points.Add(start.AddMonths(11), 96);

            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series2);
            this.chartControl1.Series.Add(series3);
            this.chartControl1.Series[0].ScatterConnectType = ScatterConnectType.Line;
            this.chartControl1.Series[1].ScatterConnectType = ScatterConnectType.Line;
            this.chartControl1.Series[2].ScatterConnectType = ScatterConnectType.Line;
            this.chartControl1.PrimaryYAxis.Range = new MinMaxInfo(-10, 45, 5);
            this.chartControl1.PrimaryYAxis.HidePartialLabels = true;
            this.chartControl1.PrimaryXAxis.HidePartialLabels = true;
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            this.chartControl1.PrimaryXAxis.DateTimeFormat = "MMM";
            this.chartControl1.PrimaryXAxis.DateTimeRange = new ChartDateTimeRange(start.AddMonths(-1), start.AddMonths(12), 2, ChartDateTimeIntervalType.Months);
            this.chartControl1.PrimaryYAxis.ValueType = ChartValueType.Double;

            this.chartControl1.Indexed = false;
            secYAxis.DrawGrid = false;
            secYAxis.Range = new MinMaxInfo(0, 120, 12);
            secYAxis.HidePartialLabels = true;
            secYAxis.OpposedPosition = true;
            secYAxis.LabelIntersectAction = ChartLabelIntersectAction.Rotate;
            secYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);
            secYAxis.ValueType = ChartValueType.Double;
            secYAxis.Orientation = ChartOrientation.Vertical;
            secYAxis.GridLineType.BackColor = Color.FromArgb(250, 209, 150, 150);
            secYAxis.GridLineType.ForeColor = Color.FromArgb(250, 230, 193, 193);
            secYAxis.GridLineType.PenType = System.Drawing.Drawing2D.PenType.LinearGradient;
            secYAxis.GridLineType.Width = 0;
            secYAxis.LineType.ForeColor = Color.FromArgb(213, 219, 204);
            secYAxis.Font = new Font("Verdana", 8f);
            this.chartControl1.Axes.Add(secYAxis);
            this.chartControl1.Series[2].YAxis = secYAxis;
            this.chartControl1.ChartArea.YAxesLayoutMode = ChartAxesLayoutMode.Stacking;           
            secYAxis.Title = "Rainfall (Millimeter)";                   
            this.comboBox1.Enabled = false;
            
        }

		#endregion

		#region Opposed position and Location of the Axes
		private void checkbox1_changed(object sender, System.EventArgs e)
		{
			if(this.checkBox1.Checked )
			{
				this.secYAxis.LocationType = ChartAxisLocationType.Auto;
				this.secYAxis.OpposedPosition = true;
			}
				
			else
			{
				this.secYAxis.OpposedPosition = false;
								
			}
		}
		#endregion

        private void CBox_AxesLayoutMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBox_AxesLayoutMode.SelectedItem.ToString() == "SideBySide")
            {
                this.chartControl1.ChartArea.YAxesLayoutMode = ChartAxesLayoutMode.SideBySide;
            }
            else if(CBox_AxesLayoutMode.SelectedItem.ToString() == "Stacking")
            {
                this.chartControl1.ChartArea.YAxesLayoutMode = ChartAxesLayoutMode.Stacking;
            }
            if (CBox_AxesLayoutMode.SelectedIndex == 0)
            {
                this.comboBox1.Enabled = true;
            }
            else
            {
                this.comboBox1.Enabled = false;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryYAxis.TitleDrawMode = (ChartTitleDrawMode)Enum.Parse(typeof(ChartTitleDrawMode), this.comboBox1.SelectedItem.ToString(), true);
        }
	}
}