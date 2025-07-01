namespace WindowsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.cbInterlacedGridXAxis = new System.Windows.Forms.CheckBox();
            this.cbInterlacedGridYAxis = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(1, 1, 10, 1);
            this.chartControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            // 
            // 
            // 
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Legend.Location = new System.Drawing.Point(462, 66);
            this.chartControl1.Location = new System.Drawing.Point(9, 10);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.PrimaryXAxis.GridLineType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.chartControl1.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.chartControl1.PrimaryXAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 14, 1);
            this.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.PrimaryYAxis.ForceZero = true;
            this.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.Black;
            this.chartControl1.PrimaryYAxis.GridLineType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.chartControl1.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(47)))), ((int)(((byte)(50)))));
            this.chartControl1.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(-100, 100, 20);
            this.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.Size = new System.Drawing.Size(577, 359);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "Market Shares";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // imageListAdv1
            // 
            this.imageListAdv1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images1"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images2")))});
            // 
            // cbInterlacedGridXAxis
            // 
            this.cbInterlacedGridXAxis.AutoSize = true;
            this.cbInterlacedGridXAxis.Checked = true;
            this.cbInterlacedGridXAxis.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInterlacedGridXAxis.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbInterlacedGridXAxis.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbInterlacedGridXAxis.Location = new System.Drawing.Point(323, 0);
            this.cbInterlacedGridXAxis.Name = "cbInterlacedGridXAxis";
            this.cbInterlacedGridXAxis.Size = new System.Drawing.Size(127, 21);
            this.cbInterlacedGridXAxis.TabIndex = 1;
            this.cbInterlacedGridXAxis.Text = "X Axis Interlaced Grid";
            this.cbInterlacedGridXAxis.UseVisualStyleBackColor = true;
            this.cbInterlacedGridXAxis.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbInterlacedGridYAxis
            // 
            this.cbInterlacedGridYAxis.AutoSize = true;
            this.cbInterlacedGridYAxis.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbInterlacedGridYAxis.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbInterlacedGridYAxis.Location = new System.Drawing.Point(450, 0);
            this.cbInterlacedGridYAxis.Name = "cbInterlacedGridYAxis";
            this.cbInterlacedGridYAxis.Size = new System.Drawing.Size(127, 21);
            this.cbInterlacedGridYAxis.TabIndex = 2;
            this.cbInterlacedGridYAxis.Text = "Y Axis Interlaced Grid";
            this.cbInterlacedGridYAxis.UseVisualStyleBackColor = true;
            this.cbInterlacedGridYAxis.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbInterlacedGridXAxis);
            this.panel1.Controls.Add(this.cbInterlacedGridYAxis);
            this.panel1.Location = new System.Drawing.Point(10, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 21);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 410);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Interlaced Grid";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageListAdv1;
        private System.Windows.Forms.CheckBox cbInterlacedGridXAxis;
        private System.Windows.Forms.CheckBox cbInterlacedGridYAxis;
        private System.Windows.Forms.Panel panel1;
    }
}

