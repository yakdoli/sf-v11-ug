#region Copyright Syncfusion Inc. 2001 - 2009
//
//  Copyright Syncfusion Inc. 2001 - 2009. All rights reserved.
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

namespace AxisLabelBinding
{
    public class Form1 : Syncfusion.Windows.Forms.Office2007Form
    {
        #region private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private DateTime lastTime = DateTime.Now;
        private ChartDataBindAxisLabelModel xAxisLabelModel = null;
        private System.Windows.Forms.DataGrid dataGrid1;
        private Label label1;
        private ComboBox comboBox1;
        private Panel panel2;
        private System.ComponentModel.Container components = null;
        #endregion

        #region Form's Constructor, Main And Dispose
        public Form1()
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
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
            this.chartControl1.Legend.Location = new System.Drawing.Point(93, 239);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Location = new System.Drawing.Point(12, 7);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 6, 1);
            this.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.PrimaryYAxis.RangePaddingType = Syncfusion.Windows.Forms.Chart.ChartAxisRangePaddingType.None;
            this.chartControl1.PrimaryYAxis.SmartDateZoomMonthLevelLabelFormat = "m";
            this.chartControl1.Size = new System.Drawing.Size(473, 351);
            this.chartControl1.Spacing = 20F;
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            this.chartControl1.ZoomOutIncrement = 1.5;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid1.DataMember = "";
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.MidnightBlue;
            this.dataGrid1.Location = new System.Drawing.Point(20, 20);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(226, 105);
            this.dataGrid1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(496, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Chart Type";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Column",
            "Pie",
            "Funnel",
            "Pyramid"});
            this.comboBox1.Location = new System.Drawing.Point(565, 234);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.dataGrid1);
            this.panel2.Location = new System.Drawing.Point(491, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 144);
            this.panel2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(763, 361);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Axis Label Binding";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
            InitializeControlSettings();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

        #region Helper Methods
        #region InitializeChartData
        /// <summary>
        /// Initializes chart data from access database.
        /// </summary>
        protected void InitializeChartData()
        {
            // The Access database
            string fileName = WinFormsUtils.FindFile(@"..\..\..\..\..\..\..\Common\Data\", "ChartData.mdb");
            string myConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName;

            // Define the database query    
            string mySelectQuery = "SELECT City, ID, Population FROM Demographics";

            // Create a database connection object using the connection string    
            OleDbConnection myConnection = new OleDbConnection(myConnectionString);

            // Create a database command on the connection using query    
            OleDbCommand myCommand = new OleDbCommand(mySelectQuery, myConnection);

            myCommand.Connection.Open();

            // Create a database reader    
            OleDbDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

            //Load the contents into a dataset.
            DataSet dataSet = ConvertToDataSet(myReader, "Demographics");

            //Bind the dataset with the datagrid to display the chart data.
            this.dataGrid1.SetDataBinding(dataSet, "Demographics");

            //Initializes new chart series.
            ChartSeries series = new ChartSeries();
            series.Name = "Products";
            series.Type = ChartSeriesType.Funnel;
            this.chartControl1.ElementsSpacing = 0;
            series.ConfigItems.FunnelItem.LabelStyle = ChartAccumulationLabelStyle.OutsideInColumn;

            ChartDataBindModel model = new ChartDataBindModel(dataSet, "Demographics");
            model.XName = "ID";
            model.YNames = new string[] { "Population" };

            series.SeriesModel = model;
            series.Style.DisplayText = true;
            series.ConfigItems.FunnelItem.ShowDataBindLabels = true;

            this.xAxisLabelModel = new ChartDataBindAxisLabelModel(dataSet, "Demographics");
            this.xAxisLabelModel.LabelName = "City";


            //Adds the series to the ChartSeriesCollection.
            this.chartControl1.Series.Add(series);

            this.xAxisLabelModel.PositionIndex = 1;
            this.chartControl1.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode;

            //this.chartControl1.PrimaryXAxis.AutoValueType = false;
            this.chartControl1.PrimaryXAxis.LabelsImpl = this.xAxisLabelModel;

            this.chartControl1.PrimaryXAxis.CustomLabelsParameter = ChartCustomLabelsParameter.Position;

            //Specifies the mode of displaying the label of the x-axis on intersection.
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows;

            //Specifies the column width mode for the Column Type chart.
            this.chartControl1.ColumnWidthMode = ChartColumnWidthMode.FixedWidthMode;

            // Close the reader and the connection
            myReader.Close();
            myConnection.Close();

        }
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

        #region InitializeControlSettings
        private void InitializeControlSettings()
        {
            this.dataGrid1.ReadOnly = true;
            this.dataGrid1.CaptionVisible = false;
            this.dataGrid1.PreferredColumnWidth = 55;
            this.dataGrid1.PreferredRowHeight = 7;
            this.dataGrid1.HeaderBackColor = Color.FromArgb(229, 234, 241);
            this.dataGrid1.BackColor = Color.FromArgb(239, 239, 239);
            this.dataGrid1.BorderStyle = BorderStyle.None;
            this.dataGrid1.RowHeadersVisible = false;
            this.comboBox1.SelectedIndex = 2;
        }

        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBox1.SelectedItem.ToString(), true);

            if (comboBox1.SelectedIndex == 0)
            {
                this.chartControl1.Series[0].Style.DisplayText = false;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                this.chartControl1.Series[0].ConfigItems.PieItem.PieType = ChartPieType.Round;
                this.chartControl1.Series[0].Style.DisplayText = true;
                this.chartControl1.Series[0].ConfigItems.PieItem.ShowDataBindLabels = true;
                this.chartControl1.Series[0].ConfigItems.PieItem.LabelStyle = ChartAccumulationLabelStyle.OutsideInColumn;
            }
            if (comboBox1.SelectedIndex == 2)
            {
                this.chartControl1.Series[0].Style.DisplayText = true;
                this.chartControl1.Series[0].ConfigItems.PyramidItem.ShowDataBindLabels = true;
                this.chartControl1.Series[0].ConfigItems.PyramidItem.LabelStyle = ChartAccumulationLabelStyle.OutsideInColumn;
                this.chartControl1.Series[0].ConfigItems.PyramidItem.LabelPlacement = ChartAccumulationLabelPlacement.Right;
            }
        }
        #endregion
    }
}