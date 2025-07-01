using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;

namespace CustomDataBinding
{
	public class Form1 : Office2007Form
    {
        #region Members
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ChartControl chartControl2;
        private System.Windows.Forms.Panel panel1;
        private Label label1;
        private ButtonAdv btnAddEntry;
        private TextBox txtPopulation;
        private TextBox txtCountry;
        private Label label3;
        private Label label2;
        private System.ComponentModel.IContainer components = null;
        #endregion

        #region PopulationData
        /// <summary>
        /// User - defined class to store population details of different cities/countries. This will act as a datasource for chart.
        /// </summary>
        class PopulationData
		{
			private string cname;
			private double population;

            /// <summary>
            /// Create a population object given the name of a city/country and its population value.
            /// </summary>
            /// <param name="cname">City or Country Name</param>
            /// <param name="population">Population in millions</param>
            public PopulationData(string cname, double population)
            {
                this.cname = cname;
                this.population = population;
            }

            /// <summary>
            /// Gets or sets the name of a city or country.
            /// </summary>
            public string Name
			{
				get { return cname; }
				set { cname = value; }
			}

            /// <summary>
            /// Gets or sets the population of a city or country.
            /// </summary>
			public double Population
			{
				get { return population; }
				set { population = value; }
			}
        }
        #endregion

        #region FormConstructor
        public Form1()
		{
			InitializeComponent();
            BindChartToBindingList();
			BindChartToArrayList();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            ChartAppearance.ApplyChartStyles1(this.chartControl2);          
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddEntry = new Syncfusion.Windows.Forms.ButtonAdv();
            this.txtPopulation = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartControl2 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(237)))), ((int)(((byte)(255))))), System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(1, 5, 5, 5);
            this.chartControl1.ElementsSpacing = 8;
            this.chartControl1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.chartControl1.Legend.ItemsSize = new System.Drawing.Size(15, 15);
            this.chartControl1.Legend.Location = new System.Drawing.Point(64, 56);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.Legend.Spacing = 3;
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Location = new System.Drawing.Point(19, 16);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.chartControl1.PrimaryXAxis.HidePartialLabels = true;
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.chartControl1.PrimaryXAxis.Title = "City";
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.chartControl1.PrimaryYAxis.Title = "Population (Million)";
            this.chartControl1.Size = new System.Drawing.Size(484, 418);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "City Population";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Title.Name = "Default";
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
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(529, 475);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.chartControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(521, 449);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "BindingList Datasource";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAddEntry);
            this.panel1.Controls.Add(this.txtPopulation);
            this.panel1.Controls.Add(this.txtCountry);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 113);
            this.panel1.TabIndex = 2;
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.btnAddEntry.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEntry.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddEntry.KeepFocusRectangle = false;
            this.btnAddEntry.Location = new System.Drawing.Point(269, 60);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(137, 36);
            this.btnAddEntry.TabIndex = 6;
            this.btnAddEntry.Text = "Add To Datasource";
            this.btnAddEntry.UseVisualStyle = true;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            // 
            // txtPopulation
            // 
            this.txtPopulation.Location = new System.Drawing.Point(130, 83);
            this.txtPopulation.Name = "txtPopulation";
            this.txtPopulation.Size = new System.Drawing.Size(116, 21);
            this.txtPopulation.TabIndex = 5;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(130, 57);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(116, 21);
            this.txtCountry.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(34, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Population:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(34, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Country Name:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(26, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Essential Chart can listen to changes in BindingList data sources and can update " +
                "itself automatically. To check this feature, try adding a new entry to the Bindi" +
                "ngList.";
            // 
            // chartControl2
            // 
            this.chartControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl2.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.BackwardDiagonal, System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254))))), System.Drawing.Color.White);
            this.chartControl2.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(5, 5, 5, 5);
            this.chartControl2.ElementsSpacing = 5;
            // 
            // 
            // 
            this.chartControl2.Legend.ItemsSize = new System.Drawing.Size(15, 15);
            this.chartControl2.Legend.Location = new System.Drawing.Point(60, 47);
            this.chartControl2.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Left;
            this.chartControl2.Legend.Spacing = 3;
            this.chartControl2.Legend.Visible = false;
            this.chartControl2.Location = new System.Drawing.Point(19, 127);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.DefaultOld;
            this.chartControl2.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.chartControl2.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.chartControl2.PrimaryXAxis.Title = "Country";
            this.chartControl2.PrimaryYAxis.ForceZero = true;
            this.chartControl2.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.chartControl2.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.chartControl2.PrimaryYAxis.Title = "Population (Million)";
            this.chartControl2.Size = new System.Drawing.Size(487, 311);
            this.chartControl2.TabIndex = 0;
            this.chartControl2.Text = "Country Population";
            // 
            // 
            // 
            this.chartControl2.Title.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl2.Title.Name = "Default";
            this.chartControl2.Titles.Add(this.chartControl2.Title);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.chartControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(521, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ArrayList Datasource";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(529, 475);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Collections";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #region Main Function
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        #endregion

        #region Dispose
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region InitializeChartData

        BindingList<PopulationData> bindList;
        private void BindChartToBindingList()
        {
            //Datasource implements IBindingList interface. 
            bindList = new BindingList<PopulationData>();
            bindList.Add(new PopulationData("Indonesia", 341));
            bindList.Add(new PopulationData("India", 660));
            bindList.Add(new PopulationData("USA", 595));
            bindList.Add(new PopulationData("Nigeria", 248));
            bindList.Add(new PopulationData("China", 806));
            bindList.Add(new PopulationData("Bangladesh", 544));

            ChartSeries series = new ChartSeries("Populations");

            //Bind the above list to the chart control.
            ChartDataBindModel dataSeriesModel = new ChartDataBindModel(bindList);

            // If ChartDataBindModel.XName is empty or null, X value is index of point.
            dataSeriesModel.YNames = new string[] { "Population" };
            series.SeriesModel = dataSeriesModel;

            UpdateChartLabels();
            
            chartControl2.Series.Add(series);
            chartControl2.PrimaryXAxis.TickLabelsDrawingMode = ChartAxisTickLabelDrawingMode.UserMode;
            chartControl2.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.MultipleRows;
            this.chartControl2.PrimaryYAxis.Range = new MinMaxInfo(120, 820, 200);
        }

        private void UpdateChartLabels()
        {
            //Setup a datasource for chart axis and populate axis labels.
            ChartDataBindAxisLabelModel dataLabelsModel = new ChartDataBindAxisLabelModel(bindList);
            dataLabelsModel.LabelName = "Name";
            chartControl2.PrimaryXAxis.LabelsImpl = dataLabelsModel;
        }

        private void BindChartToArrayList()
        {
            // Data source implements IList or IListSource interface.
            //Create an array of PopulationData objects.
            ArrayList populations = new ArrayList();
            populations.Add(new PopulationData("New York", 13));
            populations.Add(new PopulationData("Houston", 11));
            populations.Add(new PopulationData("Tokyo", 17));
            populations.Add(new PopulationData("London", 12));
            populations.Add(new PopulationData("Chicago", 10));
            populations.Add(new PopulationData("Phoneix", 14));

            ChartSeries series = new ChartSeries("Populations");

            //Bind the above array to the chart control.
            ChartDataBindModel dataSeriesModel = new ChartDataBindModel(populations);

            // If ChartDataBindModel.XName is empty or null, X value is index of point.
            dataSeriesModel.YNames = new string[] { "Population" };
            series.SeriesModel = dataSeriesModel;

            //Setup a datasource for chart axis and populate axis labels.
            ChartDataBindAxisLabelModel dataLabelsModel = new ChartDataBindAxisLabelModel(populations);
            dataLabelsModel.LabelName = "Name";

            chartControl1.Series.Add(series);
            chartControl1.PrimaryXAxis.LabelsImpl = dataLabelsModel;            
        }

        #endregion

        #region ChangeListData
        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            if(txtCountry.Text != "" && txtPopulation.Text != "")
                bindList.Add(new PopulationData(txtCountry.Text, double.Parse(txtPopulation.Text.ToString())));
            UpdateChartLabels();
        }
        #endregion
    }
}