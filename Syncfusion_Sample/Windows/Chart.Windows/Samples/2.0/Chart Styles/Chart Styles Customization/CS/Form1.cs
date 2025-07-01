using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Drawing;

namespace ChartStyles
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Office2007Form
	{
		private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkSeries1;
        private System.Windows.Forms.Label label2;
		private Syncfusion.Windows.Forms.Chart.EnumEditComboBox enumEditComboBoxTextOrientation;
		private System.Windows.Forms.CheckBox chkSeries2;
        private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ComboBox cmbSymbolStyle;
		private System.Windows.Forms.RadioButton rbSymbolSeries1;
        private System.Windows.Forms.RadioButton rbSymbolSeries2;
        private Label label9;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox chkItalics;
        private Button btnApplySymbol;
        bool flag = false;
        private NumericUpDown numericUpDown1;
        private Label label6;
        private Label label10;
        private NumericUpDown numericUpDown2;
        private Label label8;
        private Label label7;
		
		private System.ComponentModel.IContainer components;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnApplySymbol = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSymbolStyle = new System.Windows.Forms.ComboBox();
            this.rbSymbolSeries2 = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.rbSymbolSeries1 = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chkItalics = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkSeries2 = new System.Windows.Forms.CheckBox();
            this.enumEditComboBoxTextOrientation = new Syncfusion.Windows.Forms.Chart.EnumEditComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSeries1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ChartArea.Watermark.TextColor = System.Drawing.SystemColors.ControlText;
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(10, 10, 20, 10);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(232)))), ((int)(((byte)(243))))));
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 10F);
            this.chartControl1.Legend.Location = new System.Drawing.Point(58, 75);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Top;
            this.chartControl1.Location = new System.Drawing.Point(15, 25);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Size = new System.Drawing.Size(480, 372);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "chartControl1";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(501, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 415);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(6, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Spacing Between Series";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(138, 84);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(50, 20);
            this.numericUpDown2.TabIndex = 16;
            this.numericUpDown2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(7, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Spacing Between Points";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(129)))), ((int)(((byte)(115)))), ((int)(((byte)(27)))));
            this.label7.Location = new System.Drawing.Point(12, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 1);
            this.label7.TabIndex = 14;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(139, 54);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericUpDown1.TabIndex = 4;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 121);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(173, 281);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.btnApplySymbol);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmbSymbolStyle);
            this.tabPage2.Controls.Add(this.rbSymbolSeries2);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.rbSymbolSeries1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(165, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "SymbolStyle";
            // 
            // btnApplySymbol
            // 
            this.btnApplySymbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplySymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplySymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplySymbol.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnApplySymbol.Location = new System.Drawing.Point(16, 167);
            this.btnApplySymbol.Name = "btnApplySymbol";
            this.btnApplySymbol.Size = new System.Drawing.Size(112, 24);
            this.btnApplySymbol.TabIndex = 22;
            this.btnApplySymbol.Text = "Change Symbol";
            this.btnApplySymbol.Click += new System.EventHandler(this.Symbol_CheckedChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(166)))), ((int)(((byte)(231)))));
            this.label4.Location = new System.Drawing.Point(17, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 1);
            this.label4.TabIndex = 13;
            // 
            // cmbSymbolStyle
            // 
            this.cmbSymbolStyle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbSymbolStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSymbolStyle.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbSymbolStyle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbSymbolStyle.Location = new System.Drawing.Point(16, 128);
            this.cmbSymbolStyle.Name = "cmbSymbolStyle";
            this.cmbSymbolStyle.Size = new System.Drawing.Size(112, 21);
            this.cmbSymbolStyle.TabIndex = 12;
            // 
            // rbSymbolSeries2
            // 
            this.rbSymbolSeries2.BackColor = System.Drawing.Color.White;
            this.rbSymbolSeries2.Location = new System.Drawing.Point(16, 98);
            this.rbSymbolSeries2.Name = "rbSymbolSeries2";
            this.rbSymbolSeries2.Size = new System.Drawing.Size(104, 24);
            this.rbSymbolSeries2.TabIndex = 1;
            this.rbSymbolSeries2.Text = "Series 2";
            this.rbSymbolSeries2.UseVisualStyleBackColor = false;
            this.rbSymbolSeries2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(11, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 14);
            this.label9.TabIndex = 2;
            this.label9.Text = "Symbol";
            // 
            // rbSymbolSeries1
            // 
            this.rbSymbolSeries1.Location = new System.Drawing.Point(16, 67);
            this.rbSymbolSeries1.Name = "rbSymbolSeries1";
            this.rbSymbolSeries1.Size = new System.Drawing.Size(104, 24);
            this.rbSymbolSeries1.TabIndex = 0;
            this.rbSymbolSeries1.Text = "Series 1";
            this.rbSymbolSeries1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.chkItalics);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.chkSeries2);
            this.tabPage1.Controls.Add(this.enumEditComboBoxTextOrientation);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.chkSeries1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(165, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "PointTextStyle";
            // 
            // chkItalics
            // 
            this.chkItalics.AutoSize = true;
            this.chkItalics.ForeColor = System.Drawing.Color.Black;
            this.chkItalics.Location = new System.Drawing.Point(20, 212);
            this.chkItalics.Name = "chkItalics";
            this.chkItalics.Size = new System.Drawing.Size(75, 17);
            this.chkItalics.TabIndex = 7;
            this.chkItalics.Text = "Use Italics";
            this.chkItalics.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(166)))), ((int)(((byte)(231)))));
            this.label5.Location = new System.Drawing.Point(15, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 1);
            this.label5.TabIndex = 6;
            // 
            // chkSeries2
            // 
            this.chkSeries2.Checked = true;
            this.chkSeries2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSeries2.ForeColor = System.Drawing.Color.Black;
            this.chkSeries2.Location = new System.Drawing.Point(19, 112);
            this.chkSeries2.Name = "chkSeries2";
            this.chkSeries2.Size = new System.Drawing.Size(72, 24);
            this.chkSeries2.TabIndex = 4;
            this.chkSeries2.Text = "Series 2";
            this.chkSeries2.CheckedChanged += new System.EventHandler(this.Showtext_CheckedChanged);
            // 
            // enumEditComboBoxTextOrientation
            // 
            this.enumEditComboBoxTextOrientation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enumEditComboBoxTextOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.enumEditComboBoxTextOrientation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.enumEditComboBoxTextOrientation.ForeColor = System.Drawing.Color.MidnightBlue;
            this.enumEditComboBoxTextOrientation.Location = new System.Drawing.Point(18, 175);
            this.enumEditComboBoxTextOrientation.Name = "enumEditComboBoxTextOrientation";
            this.enumEditComboBoxTextOrientation.Size = new System.Drawing.Size(96, 21);
            this.enumEditComboBoxTextOrientation.TabIndex = 3;
            this.enumEditComboBoxTextOrientation.SelectedIndexChanged += new System.EventHandler(this.enumEditComboBoxTextOrientation_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(12, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "Point Text Style";
            // 
            // chkSeries1
            // 
            this.chkSeries1.Checked = true;
            this.chkSeries1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSeries1.ForeColor = System.Drawing.Color.Black;
            this.chkSeries1.Location = new System.Drawing.Point(20, 82);
            this.chkSeries1.Name = "chkSeries1";
            this.chkSeries1.Size = new System.Drawing.Size(72, 24);
            this.chkSeries1.TabIndex = 1;
            this.chkSeries1.Text = "Series 1";
            this.chkSeries1.CheckedChanged += new System.EventHandler(this.Showtext_CheckedChanged);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text Orientation";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ShowText";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "Spacing";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(699, 415);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Styles Customization";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        protected void InitializeChartData()
		{
			this.chartControl1.Indexed = true;
			ChartSeries series1 = new ChartSeries(" Volvo", ChartSeriesType.Column);
			series1.Text = series1.Name;
			series1.Points.Add(2001,451);
			series1.Points.Add(2002,437);
			series1.Points.Add(2003,234);
		    series1.Style.Images = new ChartImageCollection(this.imageList1.Images);
			series1.Style.DisplayText = this.chkSeries1.Checked;
            series1.Style.Images = new ChartImageCollection(this.imageList1.Images);
            series1.PrepareStyle += new ChartPrepareStyleInfoHandler(ChartControlSeries_PrepareStyle);

			ChartSeries series2 = new ChartSeries(" Saab",ChartSeriesType.Column);
			series2.Text = series2.Name;
			series2.Points.Add(2001,491);
			series2.Points.Add(2002,366);
			series2.Points.Add(2003,361);		
            series2.Style.Images = new ChartImageCollection(this.imageList1.Images);                                    
			this.chartControl1.Series.Add(series1);
			this.chartControl1.Series.Add(series2);
			
			this.chartControl1.Series[0].Style.DisplayText = this.chkSeries1.Checked;
			this.chartControl1.Series[1].Style.DisplayText = this.chkSeries1.Checked;
            series1.Style.TextFormat = "{0:C}";
            series2.Style.TextFormat = "{0:C}";      
		}
	
		protected void FillControlPanel()
		{
			foreach(string symbol in Enum.GetNames(typeof(Syncfusion.Windows.Forms.Chart.ChartSymbolShape)))
				this.cmbSymbolStyle.Items.Add(symbol);
			this.cmbSymbolStyle.SelectedIndex = 6;
		}

		protected void ChangeSymbol()
		{
			if(this.rbSymbolSeries1.Checked)
			{
				if(this.cmbSymbolStyle.SelectedItem.ToString() == "Image")
				{
					this.chartControl1.Series[0].Style.Symbol.Shape = (ChartSymbolShape) Enum.Parse(typeof(ChartSymbolShape ),this.cmbSymbolStyle.SelectedItem.ToString(),true);
					this.chartControl1.Series[0].Style.Symbol.Color=Color.Red;
					this.chartControl1.Series[0].Style.Symbol.ImageIndex = 0;
				}
				else
					this.chartControl1.Series[0].Style.Symbol.Shape = (ChartSymbolShape) Enum.Parse(typeof(ChartSymbolShape ),this.cmbSymbolStyle.SelectedItem.ToString(),true);
				this.chartControl1.Series[0].Style.Symbol.Color=Color.Red;
			}
			else
			{
                if (this.cmbSymbolStyle.SelectedItem.ToString() == "Image")
                {
                    this.chartControl1.Series[1].Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.cmbSymbolStyle.SelectedItem.ToString(), true);
                    this.chartControl1.Series[1].Style.Symbol.ImageIndex = 0;
                    this.chartControl1.Series[1].Style.Symbol.Color = Color.Red;
                }
                else                    
                    this.chartControl1.Series[1].Style.Symbol.Shape = (ChartSymbolShape) Enum.Parse(typeof(ChartSymbolShape ),this.cmbSymbolStyle.SelectedItem.ToString(),true);
				this.chartControl1.Series[1].Style.Symbol.Color=Color.Red;
			}
		}
        		
		private void Form1_Load(object sender, System.EventArgs e)
		{
			this.enumEditComboBoxTextOrientation.EnumType = typeof(ChartTextOrientation);
			InitializeChartData();		
            FillControlPanel();
            flag = true;
			this.rbSymbolSeries1.Checked = true;
            this.enumEditComboBoxTextOrientation.SelectedIndex = 9;
            ChartAppearance.ApplyChartStyles(this.chartControl1);
		}

        private void enumEditComboBoxTextOrientation_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (flag)
            {
                this.chartControl1.Series[1].Style.TextOrientation = (ChartTextOrientation)enumEditComboBoxTextOrientation.SelectedEnumValue;
                this.chartControl1.Series[0].Style.TextOrientation = (ChartTextOrientation)enumEditComboBoxTextOrientation.SelectedEnumValue;
                this.chartControl1.Redraw(true);
            }
        }

        private void Showtext_CheckedChanged(object sender, System.EventArgs e)
        {
            this.chartControl1.Series[0].Style.DisplayText = chkSeries1.Checked;
            this.chartControl1.Series[1].Style.DisplayText = chkSeries2.Checked;
            this.chartControl1.Redraw(true);
        }

        protected void ChartControlSeries_PrepareStyle(object sender, ChartPrepareStyleInfoEventArgs args)
        {
            // Style formatting using a callback. You can apply the same settings directly on the series style on the
            // point styles.
            ChartSeries series = sender as ChartSeries;
            Random rand = new Random();
            if (series != null)
            {
                if (rbSymbolSeries1.Checked)
                {
                    args.Style.Symbol.Shape = (ChartSymbolShape)Enum.Parse(typeof(ChartSymbolShape), this.cmbSymbolStyle.SelectedItem.ToString(), true);
                    args.Style.Symbol.Size = new Size(8, 8);
                    if (args.Index % 2 == 0)
                        args.Style.Symbol.Color = Color.Red;
                    else
                        args.Style.Symbol.Color = Color.White;
                }
            }
        }

		private void Symbol_CheckedChanged(object sender, System.EventArgs e)
		{
            ChangeSymbol();
            this.chartControl1.Redraw(true);
		}

		private void radioButton_CheckedChanged(object sender, System.EventArgs e)
		{
            ChangeSymbol();
			this.chartControl1.Redraw(true);
		}
		
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.chartControl1.Series[0].Style.Font.Italic = this.chkItalics.Checked;
            this.chartControl1.Series[1].Style.Font.Italic = this.chkItalics.Checked;            
            this.chartControl1.Redraw(true);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.SpacingBetweenPoints = Convert.ToSingle(this.numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.chartControl1.Spacing = Convert.ToSingle(this.numericUpDown2.Value);
        }  
	}
}
