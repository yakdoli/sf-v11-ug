using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;

namespace BubbleAndScatterChart
{
    public class Form1 : Office2007Form
    {
        #region Private Members
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private Label label9;
        private Label label5;
        private ChartControl chartControl1;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageListAdv1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private System.ComponentModel.IContainer components;
        Color[] color1 = new Color[] { Color.FromArgb(136, 197, 242), Color.FromArgb(139, 202, 245), Color.FromArgb(115, 161, 194) };
        Color[] color2 = new Color[] { Color.FromArgb(241, 153, 103), Color.FromArgb(242, 154, 104), Color.FromArgb(206, 133, 90) };
        private CheckBox checkBox1;
        Color[] color3 = new Color[] { Color.FromArgb(162, 161, 188), Color.FromArgb(176, 175, 202), Color.FromArgb(162, 161, 188) };


        #endregion

        #region Dispose
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(436, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 423);
            this.panel1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.checkBox1.Location = new System.Drawing.Point(20, 25);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Enable 3D";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(24, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 149);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.numericUpDown1.Location = new System.Drawing.Point(9, 115);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(88, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(6, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Spline Tension";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox2.Location = new System.Drawing.Point(9, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(88, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Scatter Connected Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Location = new System.Drawing.Point(20, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 95);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(11, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bubble Type";
            // 
            // comboBox3
            // 
            this.comboBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox3.Location = new System.Drawing.Point(14, 43);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label5.Location = new System.Drawing.Point(17, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 1);
            this.label5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(15, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chart Type";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(14, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Bubble and Scatter Chart";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox1.Items.AddRange(new object[] {
            "Bubble",
            "Scatter"});
            this.comboBox1.Location = new System.Drawing.Point(19, 119);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(193))))), System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(6, 6, 15, 6);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.Transparent, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192))))));
            this.chartControl1.ElementsSpacing = 0;
            this.chartControl1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.Legend.Location = new System.Drawing.Point(277, 216);
            this.chartControl1.Legend.Visible = false;
            this.chartControl1.Location = new System.Drawing.Point(20, 17);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Pastel;
            this.chartControl1.Size = new System.Drawing.Size(400, 382);
            this.chartControl1.TabIndex = 2;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // imageListAdv1
            // 
            this.imageListAdv1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images1"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images2")))});
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 423);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bubble and Scatter Charts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        #region Main & Constructor
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region FormLoad
        private void Form1_Load(object sender, System.EventArgs e)
        {
            FillControlPanel();
            IntializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);

            this.comboBox1.SelectedIndex = 0;
            this.comboBox2.Enabled = false;
            this.numericUpDown1.Enabled = false;
        }
        #endregion

        #region FillControlPanel
        protected void FillControlPanel()
        {
            foreach (string connect in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ScatterConnectType)))
                this.comboBox2.Items.Add(connect);
            this.comboBox2.SelectedIndex = 0;

            foreach (string type in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartBubbleType)))
                this.comboBox3.Items.Add(type);
            this.comboBox3.SelectedIndex = 0;
        }
        #endregion

        #region IntializeChartData
        private void IntializeChartData()
        {
            ChartSeries series1 = new ChartSeries("Technology AAA", ChartSeriesType.Bubble);
            series1.Text = series1.Name;
            series1.Points.Add(500, 356, 3);
            series1.Points.Add(1000, 491, 4);
            series1.Points.Add(1500, 382, 3);
            series1.Points.Add(2000, 437, 3);
            series1.Points.Add(2500, 351, 4);
            series1.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);

            ChartSeries series2 = new ChartSeries("Technology BBB", ChartSeriesType.Bubble);
            series2.Text = series2.Name;
            series2.Points.Add(500, 175, 4);
            series2.Points.Add(1000, 291, 3);
            series2.Points.Add(1500, 182, 2);
            series2.Points.Add(2000, 237, 4);
            series2.Points.Add(2500, 151, 4);
            series2.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            this.chartControl1.Legend.Visible = false;

            ChartSeries series3 = new ChartSeries("Technology BBB", ChartSeriesType.Bubble);
            series3.Text = series3.Name;
            series3.Points.Add(500, 250, 5);
            series3.Points.Add(1000, 391, 2);
            series3.Points.Add(1500, 282, 4);
            series3.Points.Add(2000, 387, 2);
            series3.Points.Add(2500, 251, 4);
            series3.Style.Images = new ChartImageCollection(this.imageListAdv1.Images);

            this.chartControl1.Series.Add(series1);
            this.chartControl1.Series.Add(series3);
            this.chartControl1.Series.Add(series2);


        }
        #endregion

        #region Chart Type
        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Bubble")
            {
                for (int i = 0; i <= 2; i++)
                {
                    this.chartControl1.Series[i].Type = ChartSeriesType.Bubble;
                }
                this.chartControl1.PrimaryYAxis.Range.Min = 100;
                this.chartControl1.Redraw(true);
                this.comboBox3.Enabled = true;
                this.comboBox2.Enabled = false;
                this.groupBox2.Visible = false;
                this.groupBox1.Visible = true;
            }
            else if ((comboBox1.SelectedItem.ToString() == "Scatter"))
            {
                for (int i = 0; i <= 2; i++)
                {
                    this.chartControl1.Series[i].Type = ChartSeriesType.Scatter;
                }
                this.chartControl1.Series[0].Style.Symbol.Color = Color.FromArgb(185, 247, 179, 78);
                this.chartControl1.Series[1].Style.Symbol.Color = Color.FromArgb(185, 73, 141, 238);
                this.chartControl1.Series[2].Style.Symbol.Color = Color.FromArgb(180, 150, 0, 50);

                this.chartControl1.Redraw(true);
                this.comboBox3.Enabled = false;
                this.comboBox2.Enabled = true;
                this.groupBox1.Visible = false;
                this.groupBox2.Location = new Point(20, 154);
                this.groupBox2.Visible = true;
            }
        }
        #endregion

        #region Helper Methods
        private void comboBox2_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBox2.SelectedItem.ToString() == "Spline")
                this.numericUpDown1.Enabled = true;
            else
                this.numericUpDown1.Enabled = false;

            if ((this.comboBox2.SelectedItem.ToString() == "Line"))
            {
                for (int i = 0; i <= 2; i++)
                {
                    this.chartControl1.Series[i].ScatterConnectType = ScatterConnectType.Line;
                }
                this.numericUpDown1.Value = 1;
            }
            else if ((this.comboBox2.SelectedItem.ToString() == "Spline"))
            {
                for (int i = 0; i <= 2; i++)
                {
                    this.chartControl1.Series[i].ScatterConnectType = ScatterConnectType.Spline;
                    this.chartControl1.Series[i].ScatterSplineTension = Convert.ToDouble(numericUpDown1.Value);
                }
           
            }

            else
            {
                try
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        this.chartControl1.Series[i].ScatterConnectType = ScatterConnectType.None;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

            }

        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            if ((comboBox1.SelectedItem.ToString() == "Scatter") && (this.comboBox2.SelectedItem.ToString() == "Spline"))
            {
                for (int i = 0; i <= 2; i++)
                {
                    this.chartControl1.Series[i].ScatterSplineTension = Convert.ToDouble(numericUpDown1.Value);
                }

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBox3.SelectedItem.ToString() == "Image")
            {

                this.chartControl1.Series[0].ConfigItems.BubbleItem.BubbleType = (ChartBubbleType)Enum.Parse(typeof(ChartBubbleType), this.comboBox3.SelectedItem.ToString(), true);
                this.chartControl1.Series[0].Style.ImageIndex = 0;
                this.chartControl1.Series[1].ConfigItems.BubbleItem.BubbleType = (ChartBubbleType)Enum.Parse(typeof(ChartBubbleType), this.comboBox3.SelectedItem.ToString(), true);
                this.chartControl1.Series[1].Style.ImageIndex = 1;
                this.chartControl1.Series[2].ConfigItems.BubbleItem.BubbleType = (ChartBubbleType)Enum.Parse(typeof(ChartBubbleType), this.comboBox3.SelectedItem.ToString(), true);
                this.chartControl1.Series[2].Style.ImageIndex = 2;

            }
            else
            {
                try
                {
                    this.chartControl1.Series[0].ConfigItems.BubbleItem.BubbleType = (ChartBubbleType)Enum.Parse(typeof(ChartBubbleType), this.comboBox3.SelectedItem.ToString(), true);
                    this.chartControl1.Series[1].ConfigItems.BubbleItem.BubbleType = (ChartBubbleType)Enum.Parse(typeof(ChartBubbleType), this.comboBox3.SelectedItem.ToString(), true);
                    this.chartControl1.Series[2].ConfigItems.BubbleItem.BubbleType = (ChartBubbleType)Enum.Parse(typeof(ChartBubbleType), this.comboBox3.SelectedItem.ToString(), true);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = checkBox1.Checked;
        }

        #endregion
    }
}
