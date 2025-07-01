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
using System.Globalization;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace Syncfusion.Windows.Forms.Chart.Samples
{
	public class FormMain : Office2007Form
	{
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
		private System.ComponentModel.Container components = null;

        #region Form Constructor, Main And Dispose
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
            Application.Run(new FormMain());
        }
                
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
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(0, 5, 5, 0);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            this.chartControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(417, 70);
            this.chartControl1.Location = new System.Drawing.Point(14, 15);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3;
            this.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.Size = new System.Drawing.Size(533, 347);
            this.chartControl1.TabIndex = 2;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5;
            // 
            // FormMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 374);
            this.Controls.Add(this.chartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Date Time Axes in Chart";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);

		}
		#endregion

        #region Form Load
       private void FormMain_Load(object sender, System.EventArgs e)
		{
			InitializeChartData();
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
			this.chartControl1.Indexed = false;
			this.chartControl1.LegendPosition = ChartDock.Top;
			
			// fill the series with random date data
			Random random = new Random();
			DateTime start = new DateTime(2008, 12, 1);
			DateTime rand = DateTime.Now;
			DateTimeFormatInfo dtInfo = new DateTimeFormatInfo();

            ChartSeries series1 = new ChartSeries();
            series1.Name = "Night Shift";
            series1.Type = ChartSeriesType.Column;
            series1.Text = series1.Name;

			series1.Points.Add(start.AddMonths(1), 363);
            series1.Points.Add(start.AddMonths(2), 417);
            series1.Points.Add(start.AddMonths(3), 563);
            series1.Points.Add(start.AddMonths(4), 453);
            series1.Points.Add(start.AddMonths(5), 478);

            ChartSeries series2 = new ChartSeries();
            series2.Name = "Day Shift";
            series2.Type = ChartSeriesType.Column;
			series2.Text = series2.Name;

            series2.Points.Add(start.AddMonths(1), 300);
            series2.Points.Add(start.AddMonths(2), 356);
            series2.Points.Add(start.AddMonths(3), 484);
            series2.Points.Add(start.AddMonths(4), 397);
            series2.Points.Add(start.AddMonths(5), 412);
			this.chartControl1.Series.Add(series1);
			this.chartControl1.Series.Add(series2); 
            
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows;
			this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
			this.chartControl1.PrimaryXAxis.RangeType=ChartAxisRangeType.Set;
			this.chartControl1.PrimaryXAxis.DateTimeRange=new ChartDateTimeRange(start,start.AddMonths(6),1,ChartDateTimeIntervalType.Months);             
        }
        #endregion
        #endregion

    }
}
