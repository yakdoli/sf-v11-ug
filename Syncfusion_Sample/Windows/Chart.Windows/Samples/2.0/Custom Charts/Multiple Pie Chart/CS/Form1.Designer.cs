namespace MultiplePieChart_2005
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nUpDownPieHeight = new System.Windows.Forms.NumericUpDown();
            this.lblPieHeight = new System.Windows.Forms.Label();
            this.ckBxEnable3D = new System.Windows.Forms.CheckBox();
            this.ckBxDisplayText = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBxPieType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPieHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(366, 75);
            this.chartControl1.Location = new System.Drawing.Point(8, 11);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.Size = new System.Drawing.Size(475, 357);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "chartControl1";
            // 
            // 
            // 
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
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbBxPieType);
            this.panel1.Controls.Add(this.ckBxDisplayText);
            this.panel1.Controls.Add(this.nUpDownPieHeight);
            this.panel1.Controls.Add(this.lblPieHeight);
            this.panel1.Controls.Add(this.ckBxEnable3D);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(489, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 378);
            this.panel1.TabIndex = 1;
            // 
            // nUpDownPieHeight
            // 
            this.nUpDownPieHeight.ForeColor = System.Drawing.Color.MidnightBlue;
            this.nUpDownPieHeight.Location = new System.Drawing.Point(65, 150);
            this.nUpDownPieHeight.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nUpDownPieHeight.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nUpDownPieHeight.Name = "nUpDownPieHeight";
            this.nUpDownPieHeight.Size = new System.Drawing.Size(53, 20);
            this.nUpDownPieHeight.TabIndex = 9;
            this.nUpDownPieHeight.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nUpDownPieHeight.ValueChanged += new System.EventHandler(this.nUpDownPieHeight_ValueChanged);
            // 
            // lblPieHeight
            // 
            this.lblPieHeight.AutoSize = true;
            this.lblPieHeight.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPieHeight.Location = new System.Drawing.Point(5, 152);
            this.lblPieHeight.Name = "lblPieHeight";
            this.lblPieHeight.Size = new System.Drawing.Size(56, 13);
            this.lblPieHeight.TabIndex = 8;
            this.lblPieHeight.Text = "Pie Height";
            // 
            // ckBxEnable3D
            // 
            this.ckBxEnable3D.AutoSize = true;
            this.ckBxEnable3D.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ckBxEnable3D.Location = new System.Drawing.Point(9, 231);
            this.ckBxEnable3D.Name = "ckBxEnable3D";
            this.ckBxEnable3D.Size = new System.Drawing.Size(76, 17);
            this.ckBxEnable3D.TabIndex = 2;
            this.ckBxEnable3D.Text = "Enable 3D";
            this.ckBxEnable3D.UseVisualStyleBackColor = true;
            this.ckBxEnable3D.CheckedChanged += new System.EventHandler(this.ckBxEnable3D_CheckedChanged);
            // 
            // ckBxDisplayText
            // 
            this.ckBxDisplayText.AutoSize = true;
            this.ckBxDisplayText.Checked = true;
            this.ckBxDisplayText.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBxDisplayText.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ckBxDisplayText.Location = new System.Drawing.Point(9, 197);
            this.ckBxDisplayText.Name = "ckBxDisplayText";
            this.ckBxDisplayText.Size = new System.Drawing.Size(84, 17);
            this.ckBxDisplayText.TabIndex = 10;
            this.ckBxDisplayText.Text = "Display Text";
            this.ckBxDisplayText.UseVisualStyleBackColor = true;
            this.ckBxDisplayText.CheckedChanged += new System.EventHandler(this.ckBxDisplayText_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "PieType";
            // 
            // cbBxPieType
            // 
            this.cbBxPieType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBxPieType.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbBxPieType.FormattingEnabled = true;
            this.cbBxPieType.Location = new System.Drawing.Point(65, 119);
            this.cbBxPieType.Name = "cbBxPieType";
            this.cbBxPieType.Size = new System.Drawing.Size(77, 21);
            this.cbBxPieType.TabIndex = 11;
            this.cbBxPieType.SelectedIndexChanged += new System.EventHandler(this.cbBxPieType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 378);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Pie Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownPieHeight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ckBxEnable3D;
        private System.Windows.Forms.Label lblPieHeight;
        private System.Windows.Forms.NumericUpDown nUpDownPieHeight;
        private System.Windows.Forms.CheckBox ckBxDisplayText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBxPieType;
    }
}

