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

namespace ChartDrillDown
{
	public class Form1 : Syncfusion.Windows.Forms.Office2007Form
    {
        #region Private Members

        private IContainer components;
		bool isDrilledDown = false;       
        private Panel panel1;
        private Label label1;
        private Timer timer1;
        private ToolTip toolTip1;
        Color[] color1 = new Color[] { Color.FromArgb(57, 120, 194), Color.FromArgb(67, 134, 216) };
        Color[] color2 = new Color[] { Color.FromArgb(213, 67, 63), Color.FromArgb(255, 114, 110) };
        Color[] color3 = new Color[] { Color.FromArgb(156, 197, 72), Color.FromArgb(168, 212, 79) };
        private ChartControl chartControl1;
        Color[] color4 = new Color[] { Color.FromArgb(130, 95, 173), Color.FromArgb(177, 139, 225) };
        
        #endregion

        #region Form constructor, Main and dispose
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 34);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click on the columns to drill down further";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.chartControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(326, 75);
            this.chartControl1.Location = new System.Drawing.Point(8, 10);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            chartSeries1.Name = "Default";
            chartSeries1.Points.Add(0, ((double)(18)), ((double)(127)), ((double)(112)), ((double)(108)));
            chartSeries1.Points.Add(1, ((double)(56)), ((double)(73)), ((double)(61)), ((double)(56)));
            chartSeries1.Points.Add(2, ((double)(4)), ((double)(212)), ((double)(82)), ((double)(107)));
            chartSeries1.Points.Add(3, ((double)(50)), ((double)(348)), ((double)(55)), ((double)(190)));
            chartSeries1.Points.Add(4, ((double)(87)), ((double)(246)), ((double)(136)), ((double)(192)));
            chartSeries1.Text = "Default";
            this.chartControl1.Series.Add(chartSeries1);
            this.chartControl1.Size = new System.Drawing.Size(430, 324);
            this.chartControl1.TabIndex = 2;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ChartRegionMouseHover += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionMouseHover);
            this.chartControl1.ChartRegionClick += new Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventHandler(this.chartControl1_ChartRegionClick);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 368);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Drill Down";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
		{
			InitializeChart();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            this.chartControl1.Indexed = true;
        }
        #endregion

        #region Helper Methods
        #region InitializeDrillDownChart
        /// <summary>
		/// Initializes the ChartControl's data and sets the Chart type
		/// </summary>
		protected void InitializeDrillDownChart(int index)
		{
            
			ChartSeries series1 = new ChartSeries("Market Breakdown");
			series1.Name = "Market";
			series1.Text = series1.Name;
			string[] labelArray = null;

			switch(index)
			{
				case 0:
					labelArray = new string[]{"Toyota", "Ford", "GM"};
                    this.chartControl1.Titles[0].Text = "Automobile sales in the SUV segment";
					break;
				case 1:
					labelArray = new string[]{"Toyota", "Ford", "GM"};
                    this.chartControl1.Titles[0].Text = "Automobile sales in the Car segment";
					break;
				case 2:
					labelArray = new string[]{"Mercedes", "Ford", "GM", "Chrysler"};
                    this.chartControl1.Titles[0].Text = "Automobile sales in the Pickup segment";
					
					break;
				case 3:
					labelArray = new string[]{"Nissan", "Ford", "GM"};
                    this.chartControl1.Titles[0].Text = "Automobile sales in the Minivan segment";
					break;
				default:
					labelArray = new string[]{"Toyota", "Ford", "GM"};
					break;
			}

			int count = this.chartControl1.Series[0].Points[index].YValues.Length -1;
			for(int i = 0; i < count; i++)
			{
				series1.Points.Add(i, this.chartControl1.Series[0].Points[index].YValues[i+1]);
                series1.Styles[i].Text = labelArray[i] + " - " + this.chartControl1.Series[0].Points[index].YValues[i + 1].ToString() + " %";
			}
			
			series1.Style.TextOrientation = ChartTextOrientation.RegionCenter;
            series1.Style.DisplayText = true;
           
			series1.Type = ChartSeriesType.Pie;	
		       

			this.chartControl1.Series.Clear();
			this.chartControl1.Series.Add(series1);
            this.chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            series1.PrepareStyle += new ChartPrepareStyleInfoHandler(series1_PrepareStyle);
           	this.chartControl1.Refresh();
            
		}
#endregion
        
#region InitializeChart

        protected void InitializeChart()
		{
			this.chartControl1.Series.Clear();

			ChartSeries series1 = new ChartSeries("Market");
			series1.Name = "Market";
			series1.Text = series1.Name;

            series1.Points.Add(0, 20, 50, 25, 25);//Only first Y value will be used by ColumnChart
            series1.Points.Add(1, 22, 50, 25, 35);
            series1.Points.Add(2, 23, 50, 25, 20, 20);
            series1.Points.Add(3, 24, 50, 25, 45);


			this.chartControl1.PrimaryXAxis.LabelsImpl = new LabelModel(new string[]{"","SUV", "Car", "Pickup", "Minivan"});
			this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Custom;
                     
            series1.Type = ChartSeriesType.Column;	
			this.chartControl1.Series.Add(series1);
            this.chartControl1.Titles[0].Text = "Automobile Sales by Category";
                      
            this.chartControl1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            this.chartControl1.Legend.Visible = false;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion
        #endregion

        #region Events
        #region series1_PrepareStyle
        void series1_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
		{
			ChartSeries series = sender as ChartSeries;
            series.ConfigItems.PieItem.PieType = ChartPieType.OutSide;
			if (series != null)
			{
				
				if (args.Index == 0)				
                    args.Style.Interior = new BrushInfo(GradientStyle.PathEllipse,color1);
                else if (args.Index == 1)
                    args.Style.Interior = new BrushInfo(GradientStyle.PathEllipse, color2);
                else if (args.Index == 2)
                    args.Style.Interior = new BrushInfo(GradientStyle.PathEllipse, color3);
                else
                    args.Style.Interior = new BrushInfo(GradientStyle.PathEllipse, color4);
                
                args.Style.Border.Color = Color.Transparent;
			}
        }
        #endregion

        #region ChartRegionClick
        private void chartControl1_ChartRegionClick(object sender, Syncfusion.Windows.Forms.Chart.ChartRegionMouseEventArgs e)
		{
			if(e.Region.IsChartPoint)
			{
				if(!isDrilledDown)
				{
					InitializeDrillDownChart(e.Region.PointIndex);
                    
                    this.label1.Text = "Click on the pie to go back and view \n 'Sales by category'";
				}
				else
				{
					InitializeChart();
                    
                    this.label1.Text = "Click on the columns to drill down further";
                   
				}
				isDrilledDown = !isDrilledDown;
			}
            ChartAppearance.ApplyChartStyles(this.chartControl1);
		
			this.chartControl1.Refresh();
        }
        #endregion
                
        #region Timer
        int x = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x =  x + this.timer1.Interval;
           if(x < 3000)
                this.label1.Location = new Point(this.label1.Location.X + 5, this.label1.Location.Y);//.X = this.label1.Location.X + 10;
            else if (x > 3000 && x < 6000)
            {
                this.label1.Location = new Point(this.label1.Location.X - 5, this.label1.Location.Y);//.X = this.label1.Location.X + 10;
             }
           else if( x > 6000)
                 x = 0;
         }
#endregion

        #region ChartRegionMouseHover
         private void chartControl1_ChartRegionMouseHover(object sender, ChartRegionMouseEventArgs e)
        {
            Point mousePoint = new Point(e.Point.X, e.Point.Y);
            ChartPoint chpt = chartControl1.ChartArea.GetValueByPoint(new Point(e.Point.X, e.Point.Y));
            Point pt = chartControl1.ChartArea.GetPointByValue(chpt);
             string text = "";
            switch (e.Region.PointIndex)
            {
                case 0:
                    text = "Automobile sales in the SUV segment";
             
                    break;
                case 1:
                    text = "Automobile sales in the Car segment";
					break;
				case 2:
                    text = "Automobile sales in the Pickup segment";
					break;
				case 3:
                    text = "Automobile sales in the Minivan segment";
                    break;
                default:
                    text = "";
                    break;
            }
            if(e.Region.PointIndex >= 0 &&  e.Region.PointIndex < 4)
                 this.chartControl1.Cursor = System.Windows.Forms.Cursors.Hand;
                else
                       this.chartControl1.Cursor = System.Windows.Forms.Cursors.Default;
                   if (this.chartControl1.Series[0].Type == ChartSeriesType.Column)
                   {
                       toolTip1.SetToolTip(chartControl1, text);
                   }
               }
         #endregion
#endregion

     }

    #region LabelModel
    public class LabelModel : IChartAxisLabelModel
    {
        private string[] labels;

        public LabelModel(string[] labels)
        {
            this.labels = labels;
        }

        public ChartAxisLabel GetLabelAt(int index)
        {
            return new ChartAxisLabel(this.labels[index]);
        }

        public int Count
        {
            get
            {
                return this.labels.GetLength(0);
            }
        }
    }
    #endregion
}
