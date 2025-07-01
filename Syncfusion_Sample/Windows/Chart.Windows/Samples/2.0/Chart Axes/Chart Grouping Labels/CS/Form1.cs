using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace GridLabelsChartSample_2002
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : Syncfusion.Windows.Forms.Office2007Form
    {
        private ChartControl chartControl1;
        private Panel panel1;
        private Label label14;
        private Label label15;
        private CheckBox checkBox2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(498, 75);
            this.chartControl1.Location = new System.Drawing.Point(12, 14);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Size = new System.Drawing.Size(629, 427);
            this.chartControl1.TabIndex = 4;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ZoomOutIncrement = 1.5;
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 49);
            this.panel1.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(166)))), ((int)(((byte)(231)))));
            this.label14.Location = new System.Drawing.Point(479, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 1);
            this.label14.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label15.Location = new System.Drawing.Point(476, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 14);
            this.label15.TabIndex = 28;
            this.label15.Text = "Axes Format";
            // 
            // checkBox2
            // 
            this.checkBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox2.ForeColor = System.Drawing.Color.Black;
            this.checkBox2.Location = new System.Drawing.Point(476, 23);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(152, 23);
            this.checkBox2.TabIndex = 22;
            this.checkBox2.Text = "Using ChartFormatAxisLabel";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 499);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Grouping Labels";
            this.Load += new System.EventHandler(this.Form1_Load);
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
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{			
			InitializeChartData();	
			InitializeChartAppearance();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
         }

		protected void InitializeChartData()
		{
			ChartSeries series1 = new ChartSeries("Food Products",ChartSeriesType.Scatter);
			ChartSeries series2 = new ChartSeries("Crude Material",ChartSeriesType.Scatter);
			ChartSeries series3 = new ChartSeries("Mineral Fuels",ChartSeriesType.Scatter);

			series1.Text = series1.Name;
			series2.Text = series2.Name;
			series3.Text = series3.Name;

			series1.Points.Add(1.1,110);
			series1.Points.Add(2,250);
			series1.Points.Add(3,280);
			series1.Points.Add(4,390);
			series1.Points.Add(5,530);
			series1.Points.Add(6,600);

			series2.Points.Add(1,100);
			series2.Points.Add(2.2,210);
			series2.Points.Add(3.1,320);
			series2.Points.Add(3.9,430);
			series2.Points.Add(5,510);
			series2.Points.Add(6.2,590);

			series3.Points.Add(1,90);
			series3.Points.Add(2.9,190);
			series3.Points.Add(3,300);
			series3.Points.Add(4.3,400);
			series3.Points.Add(5,450);
			series3.Points.Add(5.6,610);

			this.chartControl1.Series.Add(series1);
			this.chartControl1.Series.Add(series2);
			this.chartControl1.Series.Add(series3);         
		}       

		protected void InitializeChartAppearance()
		{
			// adding grouping labels
            ChartAxisGroupingLabel cagl = new ChartAxisGroupingLabel(new DoubleRange(0.5, 2.5), "GroupingLabel1");
            cagl.BorderStyle = ChartAxisGroupingLabelBorderStyle.Rectangle;
            cagl.RotateAngle = 90;
            cagl.MaxTextWidth = 80;
            this.chartControl1.PrimaryXAxis.GroupingLabels.Add(cagl);

            cagl = new ChartAxisGroupingLabel(new DoubleRange(100, 400), "GroupingLabel3");
            cagl.BorderStyle = ChartAxisGroupingLabelBorderStyle.Rectangle;
            cagl.RotateAngle = 90;
            cagl.Row = 0;
            this.chartControl1.PrimaryYAxis.GroupingLabels.Add(cagl);

            cagl = new ChartAxisGroupingLabel(new DoubleRange(0.5, 6.5), "All X Axis Range", Color.Red, new Pen(Color.Red, 1f), new Font("Arial", 10f));
            cagl.BorderStyle = ChartAxisGroupingLabelBorderStyle.Brace;
            cagl.Row = 1;
            this.chartControl1.PrimaryXAxis.GroupingLabels.Add(cagl);
		}

        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.PrimaryXAxis.Labels.Clear();
            this.chartControl1.PrimaryYAxis.Labels.Clear();
           
            if (! this.checkBox2.Checked)
            {
                CustomLabel();             
            }
        }

        private void CustomLabel()
        {
            // adding custom labels
            this.chartControl1.PrimaryXAxis.Labels.Add(new ChartAxisLabel("Label1", Color.Black, new Font("Monospace", 10), 1, "", ChartValueType.Custom));
            this.chartControl1.PrimaryXAxis.Labels.Add(new ChartAxisLabel("Label2", Color.Black, new Font("Monospace", 10), 2, "", ChartValueType.Custom));
            this.chartControl1.PrimaryXAxis.Labels.Add(new ChartAxisLabel("Label3", Color.Black, new Font("Monospace", 10), 3, "", ChartValueType.Custom));
            this.chartControl1.PrimaryXAxis.Labels.Add(new ChartAxisLabel("Label4", Color.Black, new Font("Monospace", 10), 4, "", ChartValueType.Custom));
            this.chartControl1.PrimaryXAxis.Labels.Add(new ChartAxisLabel("Label5", Color.Black, new Font("Monospace", 10), 5, "", ChartValueType.Custom));
            this.chartControl1.PrimaryXAxis.Labels.Add(new ChartAxisLabel("Label6", Color.Black, new Font("Monospace", 10), 6, "", ChartValueType.Custom));

            this.chartControl1.PrimaryYAxis.Labels.Add(new ChartAxisLabel("Label1", Color.Black, new Font("Monospace", 10), 100, "", ChartValueType.Custom));
            this.chartControl1.PrimaryYAxis.Labels.Add(new ChartAxisLabel("Label2", Color.Black, new Font("Monospace", 10), 200, "", ChartValueType.Custom));
            this.chartControl1.PrimaryYAxis.Labels.Add(new ChartAxisLabel("Label3", Color.Black, new Font("Monospace", 10), 300, "", ChartValueType.Custom));
            this.chartControl1.PrimaryYAxis.Labels.Add(new ChartAxisLabel("Label4", Color.Black, new Font("Monospace", 10), 400, "", ChartValueType.Custom));
            this.chartControl1.PrimaryYAxis.Labels.Add(new ChartAxisLabel("Label5", Color.Black, new Font("Monospace", 10), 500, "", ChartValueType.Custom));
            this.chartControl1.PrimaryYAxis.Labels.Add(new ChartAxisLabel("Label6", Color.Black, new Font("Monospace", 10), 600, "", ChartValueType.Custom));

            this.chartControl1.PrimaryXAxis.LabelRotate = false;

            this.chartControl1.PrimaryXAxis.LabelIntersectAction = ChartLabelIntersectAction.Wrap;
            this.chartControl1.PrimaryXAxis.OpposedPosition = false;
            this.chartControl1.PrimaryXAxis.OpposedPosition = false;
            this.chartControl1.PrimaryYAxis.OpposedPosition = false;
        }

        private void chartControl1_ChartFormatAxisLabel(object sender, Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventArgs e)
        {
            if (this.checkBox2.Checked)
            {
               e.Label = e.Value.ToString(".00");
               e.Handled = true;
            }

        }        
	}
}
