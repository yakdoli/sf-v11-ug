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
using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;

namespace ChartImportData
{
	public class Form1 : Syncfusion.Windows.Forms.Office2007Form
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
		private DateTime lastTime = DateTime.Now;
		private string tableName = "Products";
		private ChartDataBindModel model;
        private System.Windows.Forms.DataGrid dataGrid1;
        private Panel panel2;
		private System.ComponentModel.Container components = null;
#endregion        

        #region Form's Constructor, Main and Dispose
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
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(113)))), ((int)(((byte)(173)))));
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Pinned;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(93, 278);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Location = new System.Drawing.Point(7, 7);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryYAxis.RangePaddingType = Syncfusion.Windows.Forms.Chart.ChartAxisRangePaddingType.None;
            this.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.Size = new System.Drawing.Size(487, 390);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.Location = new System.Drawing.Point(20, 20);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(151, 138);
            this.dataGrid1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.dataGrid1);
            this.panel2.Location = new System.Drawing.Point(424, 281);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 182);
            this.panel2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 475);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data from XML";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion
        
        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeXMLData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

        #region Helper Methods
        #region InitializeXMLData
        /// <summary>
		/// Initializes chart data from XML.
		/// </summary>
		protected void InitializeXMLData()
		{
			//Initializes a new DataSet.
			DataSet xmlDataSet = new DataSet();

			//Loads the dataset with xml data.
			xmlDataSet.ReadXmlSchema(WinFormsUtils.FindFile(@"..\..\..\..\..\..\..\Common\Data\", "dataschema.xslt"));
			xmlDataSet.ReadXml(WinFormsUtils.FindFile(@"..\..\..\..\..\..\..\Common\Data\", "data.xml"));

			//Bind the dataset with the datagrid to display the chart data.
			this.dataGrid1.SetDataBinding(xmlDataSet,"Products");

			//Initializes new chart series.
            ChartSeries series = new ChartSeries();
            series.Name = tableName;
            
            model = new ChartDataBindModel(xmlDataSet,"Products");
			model.XName = "ExpiresDate";
			model.YNames = new string[]{"Quantity"};

			series.SeriesModel = model;

            //Adds the series to the ChartSeriesCollection.
            this.chartControl1.Series.Add(series);

            //Specifies the value type of the Chart Axis.
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.DateTime;
            
            //Specifies the format in which the Date-Time values display.
            this.chartControl1.PrimaryXAxis.DateTimeFormat = "MM/dd/yy";

            //Specifies the mode of displaying the label of the x-axis on intersection.
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows;

			//Specifies the column width mode for the Column Type chart.
			this.chartControl1.ColumnWidthMode = ChartColumnWidthMode.FixedWidthMode;


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
        #endregion
    }
}