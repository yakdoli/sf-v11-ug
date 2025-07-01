using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms;

namespace ColumnChart2005
{

    public class Form1 : Office2007Form
    {
        #region Private Members
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxChartType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown udSpacing;
        private System.Windows.Forms.RadioButton rbRelativeMode;
        private System.Windows.Forms.RadioButton rbFixedMode;
        private System.Windows.Forms.RadioButton rbDefaultMode;
        private Label label4;
        private Label label3;
        private Label label5;
        private Label label2;
        private GroupBox groupBox2;
        private Label label8;
        private Label label7;
        private ComboBox ColTypeCombo;
        private CheckBox checkBox1;
        private ChartControl chartControl1;
        private System.ComponentModel.Container components = null;
        Color[] color1 = new Color[] { Color.FromArgb(136, 197, 242), Color.FromArgb(139, 202, 245), Color.FromArgb(115, 161, 194) };
        Color[] color2 = new Color[] { Color.FromArgb(241, 153, 103), Color.FromArgb(242, 154, 104), Color.FromArgb(206, 133, 90) };
        private CheckBox checkBox2;

        private Label label10;


        #endregion

        #region Form's Constructor
        public Form1()
        {
            InitializeComponent();
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
        #endregion

        #region Dispose
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ColTypeCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbDefaultMode = new System.Windows.Forms.RadioButton();
            this.rbFixedMode = new System.Windows.Forms.RadioButton();
            this.rbRelativeMode = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.udSpacing = new System.Windows.Forms.NumericUpDown();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSpacing)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.ColTypeCombo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.udSpacing);
            this.panel1.Controls.Add(this.comboBoxChartType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(448, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 389);
            this.panel1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label10.Location = new System.Drawing.Point(16, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 1);
            this.label10.TabIndex = 16;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(18, 342);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(68, 18);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "3D View";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ColTypeCombo
            // 
            this.ColTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColTypeCombo.Enabled = false;
            this.ColTypeCombo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ColTypeCombo.FormattingEnabled = true;
            this.ColTypeCombo.Location = new System.Drawing.Point(16, 308);
            this.ColTypeCombo.Name = "ColTypeCombo";
            this.ColTypeCombo.Size = new System.Drawing.Size(121, 21);
            this.ColTypeCombo.TabIndex = 14;
            this.ColTypeCombo.SelectedIndexChanged += new System.EventHandler(this.ColTypeCombo_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(166)))), ((int)(((byte)(231)))));
            this.label8.Location = new System.Drawing.Point(16, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 1);
            this.label8.TabIndex = 13;
            this.label8.Text = "label8";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(16, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 14);
            this.label7.TabIndex = 12;
            this.label7.Text = "Column Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbDefaultMode);
            this.groupBox2.Controls.Add(this.rbFixedMode);
            this.groupBox2.Controls.Add(this.rbRelativeMode);
            this.groupBox2.Location = new System.Drawing.Point(16, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 96);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // rbDefaultMode
            // 
            this.rbDefaultMode.Checked = true;
            this.rbDefaultMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbDefaultMode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDefaultMode.Location = new System.Drawing.Point(6, 19);
            this.rbDefaultMode.Name = "rbDefaultMode";
            this.rbDefaultMode.Size = new System.Drawing.Size(72, 16);
            this.rbDefaultMode.TabIndex = 0;
            this.rbDefaultMode.TabStop = true;
            this.rbDefaultMode.Text = "Default";
            this.rbDefaultMode.CheckedChanged += new System.EventHandler(this.radioButtonWidthMode_CheckedChanged);
            // 
            // rbFixedMode
            // 
            this.rbFixedMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbFixedMode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFixedMode.Location = new System.Drawing.Point(6, 46);
            this.rbFixedMode.Name = "rbFixedMode";
            this.rbFixedMode.Size = new System.Drawing.Size(72, 16);
            this.rbFixedMode.TabIndex = 1;
            this.rbFixedMode.Text = "Fixed";
            this.rbFixedMode.CheckedChanged += new System.EventHandler(this.radioButtonWidthMode_CheckedChanged);
            // 
            // rbRelativeMode
            // 
            this.rbRelativeMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rbRelativeMode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRelativeMode.Location = new System.Drawing.Point(6, 72);
            this.rbRelativeMode.Name = "rbRelativeMode";
            this.rbRelativeMode.Size = new System.Drawing.Size(72, 16);
            this.rbRelativeMode.TabIndex = 2;
            this.rbRelativeMode.Text = "Relative";
            this.rbRelativeMode.CheckedChanged += new System.EventHandler(this.radioButtonWidthMode_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label2.Location = new System.Drawing.Point(16, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 1);
            this.label2.TabIndex = 8;
            // 
            // udSpacing
            // 
            this.udSpacing.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udSpacing.Location = new System.Drawing.Point(16, 246);
            this.udSpacing.Name = "udSpacing";
            this.udSpacing.ReadOnly = true;
            this.udSpacing.Size = new System.Drawing.Size(88, 20);
            this.udSpacing.TabIndex = 0;
            this.udSpacing.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxChartType.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBoxChartType.Location = new System.Drawing.Point(16, 61);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(112, 21);
            this.comboBoxChartType.TabIndex = 4;
            this.comboBoxChartType.SelectedIndexChanged += new System.EventHandler(this.comboBoxChartType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "ChartType";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label4.Location = new System.Drawing.Point(16, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 1);
            this.label4.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Width Mode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(16, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Spacing";
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(193))))), System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(6, 6, 15, 6);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ElementsSpacing = 0;
            this.chartControl1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.Legend.Border.ForeColor = System.Drawing.Color.Transparent;
            this.chartControl1.Legend.Location = new System.Drawing.Point(333, 41);
            this.chartControl1.Location = new System.Drawing.Point(15, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Pastel;
            this.chartControl1.Size = new System.Drawing.Size(427, 362);
            this.chartControl1.TabIndex = 5;
            this.chartControl1.Text = "Essential Chart";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Essential Chart";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(18, 366);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 18);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "3D Style";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 389);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Column Charts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.udSpacing)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.comboBoxChartType.Items.Add(ChartSeriesType.Column);
            this.comboBoxChartType.Items.Add(ChartSeriesType.ColumnRange);
            this.comboBoxChartType.Items.Add(ChartSeriesType.StackingColumn);
            this.comboBoxChartType.SelectedIndex = 0;

            this.udSpacing.Value = (decimal)this.chartControl1.Spacing;

            InitializeChartData();
            ChartAppearance.ApplyChartStyles(this.chartControl1);

            foreach (string columnType in Enum.GetNames(typeof(ChartColumnType)))
            {
                this.ColTypeCombo.Items.Add(columnType);

            }
            this.ColTypeCombo.SelectedIndex = 0;
            this.chartControl1.Series[0].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[1].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[2].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());

        }
        #endregion

        #region Helper Methods

        #region InitializeChartData

        protected void InitializeChartData()
        {
            int numPoints = 4;

            this.chartControl1.Series.Clear();

            ChartSeries series = new ChartSeries("Team 1");
            for (int j = 1; j < numPoints; j++)
            {
                if (rbDefaultMode.Checked)
                    series.Points.Add(j + 1, new double[] { j * 12 + 12 });
                else if (rbFixedMode.Checked)
                    series.Points.Add(j + 1, new double[] { j * 12 + 12, 12 });
                else if (rbRelativeMode.Checked)
                    series.Points.Add(j + 1, new double[] { j * 12 + 12, 0.75 });
            }
            series.Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);
            series.Text = series.Name;
            this.chartControl1.Series.Add(series);

            series = new ChartSeries("Team 2");
            for (int k = 1; k < numPoints; k++)
            {
                if (rbDefaultMode.Checked)
                    series.Points.Add(k + 1, new double[] { k * 14 + 14 });
                else if (rbFixedMode.Checked)
                    series.Points.Add(k + 1, new double[] { k * 14 + 14, 14 });
                else if (rbRelativeMode.Checked)
                    series.Points.Add(k + 1, new double[] { k * 14 + 14, 0.75 });
            }
            series.Text = series.Name;
            series.Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);
            this.chartControl1.Series.Add(series);

            series = new ChartSeries("Team 3");
            for (int k = 1; k < numPoints; k++)
            {
                if (rbDefaultMode.Checked)
                    series.Points.Add(k + 1, new double[] { k * 16 + 16 });
                else if (rbFixedMode.Checked)
                    series.Points.Add(k + 1, new double[] { k * 16 + 16, 16 });
                else if (rbRelativeMode.Checked)
                    series.Points.Add(k + 1, new double[] { k * 16 + 16, 0.75 });
            }
            series.Text = series.Name;
            series.Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);
            this.chartControl1.Series.Add(series);

            this.chartControl1.Series[0].Style.Border.Color = Color.Transparent;
            this.chartControl1.Series[1].Style.Border.Color = Color.Transparent;
            this.chartControl1.Series[2].Style.Border.Color = Color.Transparent;

        }
        #endregion

        private void comboBoxChartType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.comboBoxChartType.SelectedIndex == 1)
            {
                this.rbDefaultMode.Enabled = false;
                this.rbRelativeMode.Enabled = false;
                this.rbFixedMode.Checked = true;
            }
            else
            {
                this.rbDefaultMode.Enabled = true;
                this.rbDefaultMode.Checked = true;
            }
            if (this.comboBoxChartType.SelectedIndex == 2)
            {
                this.rbFixedMode.Enabled = false;
                 this.checkBox2.Enabled = false;
                this.rbDefaultMode.Checked = true;
            }
            else
            {
                this.rbFixedMode.Enabled = true;
                if (this.checkBox1.Checked) this.checkBox2.Enabled = true;
                this.rbRelativeMode.Enabled = true;
            }
            for (int i = 0; i < this.chartControl1.Series.Count; i++)
            {
                this.chartControl1.Series[i].Type = (ChartSeriesType)Enum.Parse(typeof(ChartSeriesType), this.comboBoxChartType.SelectedItem.ToString(), true);
                
            }
            SetColumnType();
        }
       private void SetColumnType()
        {
            if (checkBox1.Checked)
            {
                this.chartControl1.Series[0].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
                this.chartControl1.Series[1].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
                this.chartControl1.Series[2].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            }
        }
        private void radioButtonWidthMode_CheckedChanged(object sender, System.EventArgs e)
        {
            InitializeChartData();
            RadioButton rbtn = sender as RadioButton;
            if (rbtn == this.rbDefaultMode) // default
                this.chartControl1.ColumnWidthMode = ChartColumnWidthMode.DefaultWidthMode;
            else if (rbtn == this.rbFixedMode) // fixed
            {
                // YValues[1] set as 12 for each series point in InitializeChartData
                this.chartControl1.ColumnWidthMode = ChartColumnWidthMode.FixedWidthMode;

            }
            else if (rbtn == this.rbRelativeMode) //relative
            {
                // YValues[1] set as 0.75 for each series point in InitializeChartData
                this.chartControl1.ColumnWidthMode = ChartColumnWidthMode.RelativeWidthMode;
            }

            if (rbtn == this.rbFixedMode || rbtn == this.rbRelativeMode)
                this.udSpacing.Enabled = false;
            else
                this.udSpacing.Enabled = true;
            this.chartControl1.Series[0].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[1].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[2].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
        }

        private void radioButtonMultipleY_CheckedChanged(object sender, System.EventArgs e)
        {
            InitializeChartData();
            this.chartControl1.Series[0].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[1].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[2].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
        }

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Spacing = (float)this.udSpacing.Value;
        }

        private void ColTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[1].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
            this.chartControl1.Series[2].ConfigItems.ColumnItem.ColumnType = (ChartColumnType)Enum.Parse(typeof(ChartColumnType), this.ColTypeCombo.SelectedItem.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series3D = this.checkBox1.Checked;
            if (!this.checkBox1.Checked)
            {
                this.ColTypeCombo.Enabled = false;
                this.checkBox2.Enabled = false;
            }
            else
            {
                this.ColTypeCombo.Enabled = true;
               if(this.comboBoxChartType.SelectedIndex != 2) this.checkBox2.Enabled = true;
            }
        }
        #endregion

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.chartControl1.Style3D = true;
            }
            else
            {
                this.chartControl1.Style3D = false;

            }
        }
    }
}
