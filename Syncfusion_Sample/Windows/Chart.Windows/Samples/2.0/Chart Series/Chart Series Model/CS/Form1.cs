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

namespace ChartSeriesModel
{
    public class Form1 : Office2007Form
    {
        #region Private Members

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private RadioButton radioButtonSeries;
        private RadioButton radioButtonIndexed;
        private Panel panel2;
        private ChartControl chartControl1;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label2;
        private Label label3;
        private System.ComponentModel.Container components = null;
        #endregion

        #region Constructor, Main And Dispose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonIndexed = new System.Windows.Forms.RadioButton();
            this.radioButtonSeries = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBox6);
            this.panel1.Controls.Add(this.checkBox5);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButtonIndexed);
            this.panel1.Controls.Add(this.radioButtonSeries);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 139);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(17, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(402, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Series Style Dialog will be displayed while double click the Series points in the" +
                " Chart.";
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox6.Location = new System.Drawing.Point(146, 102);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(95, 17);
            this.checkBox6.TabIndex = 10;
            this.checkBox6.Text = "Show Text tab";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox5.Location = new System.Drawing.Point(20, 102);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(108, 17);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Show Symbol tab";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox4.Location = new System.Drawing.Point(146, 79);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(113, 17);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "Show Shadow tab";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox3.Location = new System.Drawing.Point(20, 79);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(106, 17);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Show Interior tab";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox2.Location = new System.Drawing.Point(146, 56);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(144, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Show FancyToolTips tab";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox1.Location = new System.Drawing.Point(20, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Show Border tab";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(17, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "StyleDialogOptions";
            // 
            // radioButtonIndexed
            // 
            this.radioButtonIndexed.AutoSize = true;
            this.radioButtonIndexed.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radioButtonIndexed.Location = new System.Drawing.Point(353, 45);
            this.radioButtonIndexed.Name = "radioButtonIndexed";
            this.radioButtonIndexed.Size = new System.Drawing.Size(121, 17);
            this.radioButtonIndexed.TabIndex = 3;
            this.radioButtonIndexed.TabStop = true;
            this.radioButtonIndexed.Text = "IndexedSeriesModel";
            this.radioButtonIndexed.UseVisualStyleBackColor = false;
            this.radioButtonIndexed.CheckedChanged += new System.EventHandler(this.SeriesModel_CheckedChanged);
            // 
            // radioButtonSeries
            // 
            this.radioButtonSeries.AutoSize = true;
            this.radioButtonSeries.ForeColor = System.Drawing.Color.MidnightBlue;
            this.radioButtonSeries.Location = new System.Drawing.Point(353, 29);
            this.radioButtonSeries.Name = "radioButtonSeries";
            this.radioButtonSeries.Size = new System.Drawing.Size(83, 17);
            this.radioButtonSeries.TabIndex = 2;
            this.radioButtonSeries.TabStop = true;
            this.radioButtonSeries.Text = "SeriesModel";
            this.radioButtonSeries.UseVisualStyleBackColor = false;
            this.radioButtonSeries.CheckedChanged += new System.EventHandler(this.SeriesModel_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(275, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ChartModel\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartControl1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(9, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(488, 529);
            this.panel2.TabIndex = 3;
            // 
            // chartControl1
            // 
            this.chartControl1.AllowUserEditStyles = true;
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            this.chartControl1.ChartArea.Watermark.TextColor = System.Drawing.SystemColors.ControlText;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(349, 87);
            this.chartControl1.Location = new System.Drawing.Point(4, 5);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.PrimaryXAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.White;
            this.chartControl1.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.White;
            this.chartControl1.PrimaryXAxis.Title = "Version";
            this.chartControl1.PrimaryXAxis.TitleColor = System.Drawing.Color.Black;
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.PrimaryYAxis.GridLineType.BackColor = System.Drawing.Color.White;
            this.chartControl1.PrimaryYAxis.GridLineType.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.White;
            this.chartControl1.PrimaryYAxis.LineType.BackColor = System.Drawing.Color.White;
            this.chartControl1.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.White;
            this.chartControl1.PrimaryYAxis.Title = "Documents Generated";
            this.chartControl1.PrimaryYAxis.TitleColor = System.Drawing.Color.Black;
            this.chartControl1.Size = new System.Drawing.Size(475, 362);
            this.chartControl1.TabIndex = 2;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(499, 539);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Series Model";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.radioButtonIndexed.Checked = true;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            InitializeChartData();
        }
        #endregion

        #region Helper Methods
        #region InitializeChartData
        protected void InitializeChartData()
        {
            this.chartControl1.Series.Clear();
            ChartSeries series = new ChartSeries();
            series.Name = "Machine 1";
            series.Text = series.Name;
            series.Type = ChartSeriesType.Line;
            this.chartControl1.PrimaryXAxis.ValueType = ChartValueType.Custom;

            //IndexedSeriesModel
            if (this.radioButtonIndexed.Checked)
            {
                //Indexed models do not have an associated X-axis value for their points.
                //The X-axis value is commonly just the position of the data within the series.
                series.SeriesIndexedModelImpl = new CustomIndexedSeriesModel();
                this.chartControl1.Indexed = true;
                this.chartControl1.Titles[0].Text = "Custom Indexed Series Model";
                this.chartControl1.PrimaryXAxis.LabelsImpl = new IndexedSeriesLabelModel();
                this.chartControl1.PrimaryXAxis.Title = "Version";
            }
            //SeriesModel
            else if (this.radioButtonSeries.Checked)
            {
                series.SeriesModel = new CustomSeriesModel();
                this.chartControl1.Indexed = false;
                this.chartControl1.Titles[0].Text = "Custom Series Model";
                this.chartControl1.PrimaryXAxis.LabelsImpl = new SeriesLabelModel(new string[] { "Mar", "Apr", "May", "Jun", "Jul" });
                this.chartControl1.PrimaryXAxis.Title = "Month";
            }
            series.Style.Symbol.Size = new Size(25, 25);
            series.Style.Symbol.Shape = ChartSymbolShape.Diamond;
            series.Style.Symbol.Color = Color.White;
            series.Style.DisplayText = true;
            series.Style.Border.Width = 3;
            this.chartControl1.Series.Add(series);
        }

        #endregion
        #endregion

        #region Event

        private void SeriesModel_CheckedChanged(object sender, EventArgs e)
        {
            InitializeChartData();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.StyleDialogOptions.ShowBorderTab = this.checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.StyleDialogOptions.ShowFancyToolTipsTab = this.checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.StyleDialogOptions.ShowInteriorTab = this.checkBox3.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.StyleDialogOptions.ShowShadowTab = this.checkBox4.Checked;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.StyleDialogOptions.ShowSymbolTab = this.checkBox5.Checked;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.StyleDialogOptions.ShowTextTab = this.checkBox6.Checked;
        }
        #endregion
    }
}