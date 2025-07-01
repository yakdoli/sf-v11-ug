using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace Stacked100Charts
{
	public class Form1 : Office2007Form
    {

        #region Private Members
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private ChartControl chartControl1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        #endregion 
		
        #region Constructor, Main and Dispose
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(246, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chart Type";
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.Items.AddRange(new object[] {
            "StackingArea100",
            "StackingBar100",
            "StackingColumn100"});
            this.comboBox1.Location = new System.Drawing.Point(315, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 29);
            this.panel1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Enable 3D";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(219))))), System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(1, 10, 17, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(235)))), ((int)(((byte)(218))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(190)))), ((int)(((byte)(135))))));
            this.chartControl1.Font = new System.Drawing.Font("Arial", 13F);
            // 
            // 
            // 
            this.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.Legend.Location = new System.Drawing.Point(161, 49);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartControl1.Location = new System.Drawing.Point(12, 13);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.GridLineType.Width = 0F;
            this.chartControl1.PrimaryXAxis.LineType.Width = 0F;
            this.chartControl1.Size = new System.Drawing.Size(412, 375);
            this.chartControl1.TabIndex = 4;
            this.chartControl1.Text = "Essential Chart-Stacked 100% Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart-Stacked 100% Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(113, 2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Enable Group";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(436, 424);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stacked 100 Charts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }

        #endregion 

        #region Helper Methods

        #region InitializeChartData

        protected void InitializeChartData()
        {
            ChartSeries series1 = new ChartSeries("Series1", ChartSeriesType.StackingArea100);
            series1.Points.Add(1, 20);
            series1.Points.Add(2, 30);
            series1.Points.Add(3, 10);
            series1.Points.Add(4, 15);
            series1.Points.Add(5, 25);
            this.chartControl1.Series.Add(series1);

            ChartSeries series2 = new ChartSeries("Series2", ChartSeriesType.StackingArea100);
            series2.Points.Add(1, 20);
            series2.Points.Add(2, 10);
            series2.Points.Add(3, 50);
            series2.Points.Add(4, 15);
            series2.Points.Add(5, 5);
            this.chartControl1.Series.Add(series2);

            ChartSeries series3 = new ChartSeries("Series3", ChartSeriesType.StackingArea100);
            series3.Points.Add(1, 20);
            series3.Points.Add(2, 40);
            series3.Points.Add(3, 10);
            series3.Points.Add(4, 5);
            series3.Points.Add(5, 20);
            this.chartControl1.Series.Add(series3);

            ChartSeries series4 = new ChartSeries("Series4", ChartSeriesType.StackingArea100);
            series4.Points.Add(1, 30);
            series4.Points.Add(2, 20);
            series4.Points.Add(3, 15);
            series4.Points.Add(4, 23);
            series4.Points.Add(5, 5);
            this.chartControl1.Series.Add(series4);
            this.comboBox1.SelectedIndex = 0;
            this.checkBox2.Enabled = false;
        }

        #endregion

        #endregion 

        #region Events
        bool stackedBar = false;
        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series[0].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Series[1].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Series[2].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBox1.SelectedItem.ToString(), true);
            this.chartControl1.Series[3].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBox1.SelectedItem.ToString(), true);
            switch (this.comboBox1.SelectedIndex)
            {
                case 0:
                    this.chartControl1.Titles[0].Text = "100% Stacked Area Chart";
                    this.checkBox2.Enabled = false;
                    stackedBar = false;
                    break;
                    case 1:
                        this.chartControl1.Titles[0].Text = "100% Stacked Bar Chart";
                        this.checkBox2.Enabled = true;
                        stackedBar = true;
                    break;
                    case 2:
                        this.chartControl1.Titles[0].Text = "100% Stacked Column Chart";
                        this.checkBox2.Enabled = true;
                        stackedBar = false;
                    break;
            }
        }

       

        #region Axis Labels
        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (stackedBar == true)
            {
                if (e.AxisOrientation == ChartOrientation.Horizontal)
                {
                    //Applying Formatted Axis label values.
                    e.Label = string.Format("{0}%", e.Value);
                }
            }
            else
            {
                if (e.AxisOrientation == ChartOrientation.Vertical)
                {
                    //Applying Formatted Axis label values.
                    e.Label = string.Format("{0}%", e.Value);
                }
        }
            e.Handled = true;
        }
        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = checkBox1.Checked;
        }

      #endregion

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.chartControl1.Series[0].StackingGroup = "First";
                this.chartControl1.Series[1].StackingGroup = "First";

                this.chartControl1.Series[2].StackingGroup = "Second";
                this.chartControl1.Series[3].StackingGroup = "Second";
                
            }
            else
            {
                this.chartControl1.Series[0].StackingGroup = "";
                this.chartControl1.Series[1].StackingGroup = "";

                this.chartControl1.Series[2].StackingGroup = "";
                this.chartControl1.Series[3].StackingGroup = "";

            }
            this.chartControl1.Redraw(true);
        }

    }
}
