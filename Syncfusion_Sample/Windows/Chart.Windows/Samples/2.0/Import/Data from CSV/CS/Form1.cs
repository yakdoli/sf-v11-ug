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
        #region private Members
		private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
		private string tableName = "Products";
		private ChartDataBindModel model;
        private Panel panel2;
        private DataGrid dataGrid1;
		private System.ComponentModel.Container components = null;
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(113)))), ((int)(((byte)(173)))));
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Pinned;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(93, 241);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(178)))), ((int)(((byte)(201)))));
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(143)))), ((int)(((byte)(171)))));
            this.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryXAxis.TickColor = System.Drawing.Color.Transparent;
            this.chartControl1.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(178)))), ((int)(((byte)(201)))));
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(143)))), ((int)(((byte)(171)))));
            this.chartControl1.PrimaryYAxis.RangePaddingType = Syncfusion.Windows.Forms.Chart.ChartAxisRangePaddingType.None;
            this.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryYAxis.TickColor = System.Drawing.Color.Transparent;
            this.chartControl1.Size = new System.Drawing.Size(416, 353);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "Chart Data From CSV";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Chart Data From CSV";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.dataGrid1);
            this.panel2.Location = new System.Drawing.Point(365, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 134);
            this.panel2.TabIndex = 8;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackColor = System.Drawing.Color.White;
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGrid1.DataMember = "";
            this.dataGrid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid1.LinkColor = System.Drawing.Color.Black;
            this.dataGrid1.Location = new System.Drawing.Point(19, 20);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(150, 97);
            this.dataGrid1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 400);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data from CSV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartFromCSV();
            ChartAppearance.ApplyChartStyles(this.chartControl1);        
        }
        #endregion

        #region Helper Methods
        #region InitializeChartData
        /// <summary>
		/// Imports chart data from a CSV file.
		/// </summary>
		protected void InitializeChartFromCSV()
		{
            string fileName = WinFormsUtils.FindFile(@"..\..\..\..\..\..\..\Common\Data\", "ChartData.csv");
                        
			OleDbConnection csvConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + ";Extended Properties=\"Text;HDR=Yes;FMT=Delimited\"");
			csvConn.Open();

			//Query for retriving the data from the csv file.
			string query = "Select * From "+fileName;

			OleDbCommand csvCommand = new OleDbCommand(query,csvConn);

			OleDbDataReader csvReader = csvCommand.ExecuteReader(CommandBehavior.CloseConnection);

			//Load the contents to a dataset.
			DataSet csvDataSet = ConvertToDataSet(csvReader, "CSVTable");

			//Bind the dataset with the datagrid to display the chart data.
			this.dataGrid1.SetDataBinding(csvDataSet,"CSVTable");

			this.chartControl1.Indexed = true;

			//Initializes new chart series.
            ChartSeries series = new ChartSeries();
            series.Name = tableName;            

			model = new ChartDataBindModel(csvDataSet, "CSVTable");
			model.XName = "X Value";
			model.YNames = new string[]{"Y Value"};

			series.SeriesModel = model;

			//Adds the series to the ChartSeriesCollection.
			this.chartControl1.Series.Add(series);                        
                   
            ////Specifies the column width mode for the Column Type chart.
           this.chartControl1.ColumnWidthMode = ChartColumnWidthMode.FixedWidthMode;

			//Close the connection.
			csvReader.Close();
			csvConn.Close();
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.CaptionVisible = false;
            this.dataGrid1.PreferredColumnWidth = 55;
            this.dataGrid1.PreferredRowHeight = 7;
            this.dataGrid1.HeaderBackColor = Color.FromArgb(229, 234, 241);
            this.dataGrid1.BackColor = Color.FromArgb(239, 239, 239);
            this.dataGrid1.BorderStyle = BorderStyle.None;
            this.dataGrid1.RowHeadersVisible = false;
        }

        #endregion
        #endregion

        #region ConvertToDataSet
        /// <summary>
        /// Converts DataReader to DataSet.
        /// </summary>
        /// <param name="myReader"></param>
        /// <param name="tableName"></param>
        /// <returns></returns>
        protected DataSet ConvertToDataSet(OleDbDataReader dataReader, string tableName)
        {
            DataSet dataSet = new DataSet();
            do
            {
                // Create new data table

                DataTable schemaTable = dataReader.GetSchemaTable();
                DataTable dataTable = new DataTable(tableName);

                if (schemaTable != null)
                {
                    // A query returning records was executed

                    for (int i = 0; i < schemaTable.Rows.Count; i++)
                    {
                        DataRow dataRow = schemaTable.Rows[i];
                        // Create a column name that is unique in the data table
                        string columnName = (string)dataRow["ColumnName"]; //+ "<C" + i + "/>";
                        // Add the column definition to the data table
                        DataColumn column = new DataColumn(columnName, (Type)dataRow["DataType"]);
                        
                        dataTable.Columns.Add(column);
                    }

                    //Add the data table to the dataset.
                    dataSet.Tables.Add(dataTable);

                    // Fill the data table.
                    while (dataReader.Read())
                    {
                        DataRow dataRow = dataTable.NewRow();

                        for (int i = 0; i < dataReader.FieldCount; i++)
                            dataRow[i] = dataReader.GetValue(i);

                        dataTable.Rows.Add(dataRow);
                    }
                }
                else
                {
                    // No records were returned.

                    DataColumn column = new DataColumn("RowsAffected");
                    dataTable.Columns.Add(column);
                    dataSet.Tables.Add(dataTable);
                    DataRow dataRow = dataTable.NewRow();
                    dataRow[0] = dataReader.RecordsAffected;
                    dataTable.Rows.Add(dataRow);
                }
            }
            while (dataReader.NextResult());
            return dataSet;
        }
        #endregion
    }
}
