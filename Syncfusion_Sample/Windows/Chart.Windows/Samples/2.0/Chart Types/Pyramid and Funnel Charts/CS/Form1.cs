using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Tools;

namespace PyramidAndFunnelChart
{
    public class Form1 : Office2007Form
    {
        #region Private Members
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private ChartControl chartControl1;
        private IContainer components = null;

        Color[] color1 = new Color[] { Color.FromArgb(223, 111, 39), Color.FromArgb(251, 169, 113), Color.FromArgb(223, 111, 39) };
        Color[] color5 = new Color[] { Color.FromArgb(208, 171, 110), Color.FromArgb(249, 208, 154), Color.FromArgb(208, 171, 110) };
        Color[] color2 = new Color[] { Color.FromArgb(90, 70, 114), Color.FromArgb(136, 109, 169), Color.FromArgb(90, 70, 114) };
        Color[] color3 = new Color[] { Color.FromArgb(110, 132, 63), Color.FromArgb(161, 192, 97), Color.FromArgb(110, 132, 63) };
        Color[] color4 = new Color[] { Color.FromArgb(129, 53, 50), Color.FromArgb(197, 88, 85), Color.FromArgb(129, 53, 50) };
        Color[] color6 = new Color[] { Color.FromArgb(57, 95, 140), Color.FromArgb(102, 139, 191), Color.FromArgb(57, 95, 140) };
        #endregion

        #region Constructor, Main & Dispose
        public Form1()
        {
            InitializeComponent();
            this.chartControl1.ChartArea.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 10, 10);
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 10, 10);
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
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(8, 271);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(101, 20);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "3D View     ";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Point Gap";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox2.Location = new System.Drawing.Point(97, 159);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(107, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Label Placement";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox1.Location = new System.Drawing.Point(97, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Label Style";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(440, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 374);
            this.panel1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label7.Location = new System.Drawing.Point(12, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 1);
            this.label7.TabIndex = 20;
            this.label7.Text = "                                                                       ";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(12, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Accumulation Chart ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox5.Items.AddRange(new object[] {
            "Pyramid",
            "Funnel"});
            this.comboBox5.Location = new System.Drawing.Point(97, 85);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(107, 21);
            this.comboBox5.TabIndex = 18;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Chart Type";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox4.Items.AddRange(new object[] {
            "Circle",
            "Square"});
            this.comboBox4.Location = new System.Drawing.Point(97, 233);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(107, 21);
            this.comboBox4.TabIndex = 16;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "FigureBase";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox3.Items.AddRange(new object[] {
            "0.0",
            "0.1",
            "0.2"});
            this.comboBox3.Location = new System.Drawing.Point(97, 196);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(107, 21);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged_1);
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240))))), System.Drawing.Color.White);
            //this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Emboss;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240))))));
            // 
            // 
            // 
            this.chartControl1.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Center;
            this.chartControl1.Legend.Cursor = System.Windows.Forms.Cursors.Default;
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(158, 66);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.LegendPosition = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            //this.chartControl1.LegendsPlacement = Syncfusion.Windows.Forms.Chart.ChartPlacement.Outside;
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.OriginDate = new System.DateTime(1899, 12, 30, 0, 0, 0, 0);
            this.chartControl1.PrimaryYAxis.OriginDate = new System.DateTime(1899, 12, 30, 0, 0, 0, 0);
            this.chartControl1.Size = new System.Drawing.Size(411, 350);
            this.chartControl1.TabIndex = 15;
            this.chartControl1.Text = "Project Cost Breakdown";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Project Cost Breakdown";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(656, 374);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pyramid and Funnel Charts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region FormLoad
        private void Form1_Load(object sender, System.EventArgs e)
        {
            foreach (string labelstyle in Enum.GetNames(typeof(ChartAccumulationLabelStyle)))
                this.comboBox1.Items.Add(labelstyle);
            this.comboBox1.SelectedIndex = 1;
            this.comboBox3.SelectedIndex = 0;
            this.comboBox5.SelectedIndex = 0;
            this.comboBox2.SelectedIndex = 1;
            this.comboBox4.SelectedIndex = 0;
            ChartData();
            this.checkBox1.Checked = false;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
        }
        #endregion

        #region Helper Methods

        #region ChartData
        private void ChartData()
        {
            ChartSeries series1 = new ChartSeries("Pyramid chart", ChartSeriesType.Pyramid);
            series1.Points.Add(0, 25);
            series1.Points.Add(1, 25);
            series1.Points.Add(2, 25);
            series1.Points.Add(3, 25);
            series1.Points.Add(4, 25);
            this.chartControl1.Series.Add(series1);

            this.chartControl1.Series[0].ConfigItems.PyramidItem.PyramidMode = ChartPyramidMode.Linear;
            this.chartControl1.Series[0].ConfigItems.PyramidItem.FigureBase = ChartFigureBase.Circle;

            series1.Styles[0].Text = "  Oats\n4.15%";
            series1.Styles[1].Text = "Barley\n12.89%";
            series1.Styles[2].Text = "Maize\n21.62%";
            series1.Styles[3].Text = " Rice\n23.75%";
            series1.Styles[4].Text = "Wheat\n37.5%";

            series1.Style.DisplayText = true;
            series1.Style.TextColor = Color.Black;

            this.chartControl1.Series[0].ConfigItems.PyramidItem.LabelStyle = ChartAccumulationLabelStyle.Inside;
            this.chartControl1.Series[0].ConfigItems.PyramidItem.LabelPlacement = ChartAccumulationLabelPlacement.Center;
        }
        #endregion

        #endregion

        #region Events

        private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
                this.chartControl1.Series[0].ConfigItems.PyramidItem.LabelPlacement = (ChartAccumulationLabelPlacement)Enum.Parse(typeof(ChartAccumulationLabelPlacement), this.comboBox2.SelectedItem.ToString(), true);
            else
                this.chartControl1.Series[0].ConfigItems.FunnelItem.LabelPlacement = (ChartAccumulationLabelPlacement)Enum.Parse(typeof(ChartAccumulationLabelPlacement), this.comboBox2.SelectedItem.ToString(), true);
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
                this.chartControl1.Series[0].ConfigItems.PyramidItem.LabelStyle = (ChartAccumulationLabelStyle)Enum.Parse(typeof(ChartAccumulationLabelStyle), this.comboBox1.SelectedItem.ToString(), true);
            else
                this.chartControl1.Series[0].ConfigItems.FunnelItem.LabelStyle = (ChartAccumulationLabelStyle)Enum.Parse(typeof(ChartAccumulationLabelStyle), this.comboBox1.SelectedItem.ToString(), true);
            if (comboBox1.SelectedIndex == 3 || comboBox1.SelectedIndex == 2)
            {
                this.comboBox2.Enabled = true;
                this.comboBox2.Items.Clear();
                comboBox2.Items.Add("Right");
                comboBox2.Items.Add("Left");
                this.comboBox2.SelectedIndex = 1;
            }
            if (comboBox1.SelectedIndex == 1)
            {
                this.comboBox2.Enabled = true;
                this.comboBox2.Items.Clear();
                comboBox2.Items.Add("Top");
                comboBox2.Items.Add("Bottom");
                comboBox2.Items.Add("Center");
                this.comboBox2.SelectedIndex = 2;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                this.comboBox2.Enabled = false;
            }
        }

        private void comboBox3_SelectedIndexChanged_1(object sender, System.EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
                this.chartControl1.Series[0].ConfigItems.PyramidItem.GapRatio = Convert.ToSingle(comboBox3.SelectedItem.ToString());
            else
                this.chartControl1.Series[0].ConfigItems.FunnelItem.GapRatio = Convert.ToSingle(comboBox3.SelectedItem.ToString());
        }

        private void comboBox4_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series[0].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBox5.SelectedItem.ToString(), true);
            if (comboBox5.SelectedIndex == 0)
                this.chartControl1.Series[0].ConfigItems.PyramidItem.FigureBase = (ChartFigureBase)Enum.Parse(typeof(ChartFigureBase), this.comboBox4.SelectedItem.ToString(), true);
            else
                this.chartControl1.Series[0].ConfigItems.FunnelItem.FigureBase = (ChartFigureBase)Enum.Parse(typeof(ChartFigureBase), this.comboBox4.SelectedItem.ToString(), true);
        }

        private void comboBox5_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series[0].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBox5.SelectedItem.ToString(), true);
            if (comboBox5.SelectedIndex == 0)
                this.chartControl1.Series[0].ConfigItems.PyramidItem.LabelStyle = (ChartAccumulationLabelStyle)Enum.Parse(typeof(ChartAccumulationLabelStyle), this.comboBox1.SelectedItem.ToString(), true);
            else
                this.chartControl1.Series[0].ConfigItems.FunnelItem.LabelStyle = (ChartAccumulationLabelStyle)Enum.Parse(typeof(ChartAccumulationLabelStyle), this.comboBox1.SelectedItem.ToString(), true);
            this.comboBox2_SelectedIndexChanged(comboBox2, EventArgs.Empty);
            ChangePointGap();
        }
        private void ChangePointGap()
        {
            if (comboBox5.SelectedIndex == 0)
                this.chartControl1.Series[0].ConfigItems.PyramidItem.GapRatio = Convert.ToSingle(comboBox3.SelectedItem.ToString());
            else
                this.chartControl1.Series[0].ConfigItems.FunnelItem.GapRatio = Convert.ToSingle(comboBox3.SelectedItem.ToString());
        }
        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series3D = this.checkBox1.Checked;
            this.label4.Enabled = this.checkBox1.Checked;
            this.comboBox4.Enabled = this.checkBox1.Checked;
        }

        #endregion
    }
}