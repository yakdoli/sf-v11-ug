#region Copyright Syncfusion Inc. 2001 - 2005
//
//  Copyright Syncfusion Inc. 2001 - 2005. All rights reserved.
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
using System.Xml;
using System.Data.OleDb;
using System.Drawing.Drawing2D;
using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;

namespace ChartImportData
{
	public class Form1 : Syncfusion.Windows.Forms.Office2007Form
    {
        #region Private Members
        private DateTime lastTime = DateTime.Now;
        private DataGrid dataGrid1;
        private ChartControl chartControl1;
        private Panel panel2;
		private System.ComponentModel.Container components = null;
        #endregion

        #region Form's Constructor, Main And Dispose
        public Form1()
		{
			InitializeComponent();
            Application.EnableVisualStyles();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid1.LinkColor = System.Drawing.Color.Black;
            this.dataGrid1.Location = new System.Drawing.Point(18, 20);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(126, 106);
            this.dataGrid1.TabIndex = 1;
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(113)))), ((int)(((byte)(173)))));
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Pinned;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(337, 110);
            this.chartControl1.Location = new System.Drawing.Point(10, 7);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.Rotation = 40F;
            this.chartControl1.Size = new System.Drawing.Size(481, 376);
            this.chartControl1.TabIndex = 5;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.dataGrid1);
            this.panel2.Location = new System.Drawing.Point(349, 297);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 142);
            this.panel2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data from an Array";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

        #region Form Load
		private void Form1_Load(object sender, System.EventArgs e)
		{
            InitializeChartFromArray();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            //Updates the datagrid.
            FillDataset(this.chartControl1.Series[0]);         
           
    	}	
	    #endregion

        #region Helper Methods
        #region InitializeChartFromArray
        /// <summary>
		/// Initializes chart data from array.
		/// </summary>
        protected void InitializeChartFromArray()
        {
            //Initializes new chart series.
            ChartSeries series = new ChartSeries();
            series.Type = ChartSeriesType.Pie;

            string[] names = { "New York", "Houston", "Tokyo", "London", "Los Angeles" };
            double[] values = { 13, 11, 17, 15, 14 };

            //Turns on the text display.
            series.Style.DisplayText = true;

            for (int i = 0; i < values.Length; i++)
            {
                series.Points.Add(i, values[i]);
                series.Styles[i].Text = names[i].ToString();
            }

            //Adds the series to the ChartSeriesCollection.
            this.chartControl1.Series.Add(series);
            series.PrepareStyle += new ChartPrepareStyleInfoHandler(series_PrepareStyle);
            this.chartControl1.Series[0].ConfigItems.PieItem.AngleOffset = 13;

            //Turns off the legend.
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Text = "Highest populated cities in the world";
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.CaptionVisible = false;
            this.dataGrid1.PreferredColumnWidth = 63;
            this.dataGrid1.PreferredRowHeight = 7;
            this.dataGrid1.HeaderBackColor = Color.FromArgb(229, 234, 241);
            this.dataGrid1.BackColor = Color.FromArgb(239, 239, 239);
            this.dataGrid1.BorderStyle = BorderStyle.None;
            this.dataGrid1.RowHeadersVisible = false;
        }
        #endregion     
		
        #region FillDataset
        /// <summary>
        /// Fills the dataset with the chart series.
        /// </summary>
        /// <param name="serie"></param>
        protected void FillDataset(ChartSeries serie)
        {
            //Creates data table
            DataTable dt = new DataTable("Data Table");

            //Initializes and adds the datarow to the table.
            DataRow dr;
            for (int i = 0; i < serie.Points.Count; i++)
            {
                dr = dt.NewRow();
                dt.Rows.Add(dr);
            }

            //Initializes and adds the datacolumn to the table.
            DataColumn XValue = dt.Columns.Add("X Value", typeof(string));
            DataColumn YValue = dt.Columns.Add("Y Value", typeof(int));

            //Populate the datatable with the series points.
            for (int i = 0; i < serie.Points.Count; i++)
            {
                dt.Rows[i]["X Value"] = serie.Styles[i].Text;                
                dt.Rows[i]["Y Value"] = serie.Points[i].YValues[0];
            }

            //Creates a new dataset.
            DataSet arrayDataSet = new DataSet("Data DataSet");

            //Add the populated datatable to the dataset.
            arrayDataSet.Tables.Add(dt);

            //Bind the dataset with the datagrid to display the chart data.
            this.dataGrid1.SetDataBinding(arrayDataSet, "Data Table");
           
        }
        #endregion
        #endregion

        #region Series_PrepareStyle Event
        void series_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
		{
			ChartSeries series = sender as ChartSeries;
			series.ConfigItems.PieItem.PieType=ChartPieType.OutSide;
			if (series != null)
			{
                Color[] color1 = new Color[] { Color.FromArgb(57, 120, 194), Color.FromArgb(67, 134, 216) };
                Color[] color2 = new Color[] { Color.FromArgb(213, 67, 63), Color.FromArgb(255, 114, 110) };
                Color[] color3 = new Color[] { Color.FromArgb(156, 197, 72), Color.FromArgb(168, 212, 79) };
                Color[] color4 = new Color[] { Color.FromArgb(130, 95, 173), Color.FromArgb(177, 139, 225) };
                Color[] color5 = new Color[] { Color.FromArgb(217, 117, 36), Color.FromArgb(255, 194, 102) };
                Color[] color6 = new Color[] { Color.FromArgb(55, 163, 193), Color.FromArgb(45, 141, 167) };
                Color[] color7 = new Color[] { Color.FromArgb(255, 255, 62), Color.FromArgb(255, 205, 5) };
                if (args.Index == 0)				
					args.Style.Interior = new BrushInfo(GradientStyle.Vertical,color1);				
				else if (args.Index==1)		
					args.Style.Interior = new BrushInfo(GradientStyle.Vertical,color2);				
				else if (args.Index == 2)				
					args.Style.Interior=new BrushInfo(GradientStyle.Vertical,color3);			
				else if (args.Index == 3)				
					args.Style.Interior = new BrushInfo(GradientStyle.Vertical,color4);				
				else if (args.Index == 4)				
					args.Style.Interior = new BrushInfo(GradientStyle.Vertical,color5);				
				else if (args.Index == 5)				
					args.Style.Interior = new BrushInfo(GradientStyle.Vertical,color6);			
				else 			
					args.Style.Interior = new BrushInfo(GradientStyle.Vertical,color7);

                args.Style.Border.Color = Color.Transparent;
			}
			
		}
        #endregion
       
     }
}