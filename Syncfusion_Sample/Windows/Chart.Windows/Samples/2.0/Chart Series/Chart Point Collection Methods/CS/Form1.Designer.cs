namespace ChartPointCollectionMethods_2005
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdBtnFindMinValue = new System.Windows.Forms.RadioButton();
            this.rdBtnFindMaxValue = new System.Windows.Forms.RadioButton();
            this.rdBtnFindValue = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBxFindValue = new System.Windows.Forms.ComboBox();
            this.cbBxFindMaxValue = new System.Windows.Forms.ComboBox();
            this.txBxResult = new System.Windows.Forms.TextBox();
            this.cbBxFindMinValue = new System.Windows.Forms.ComboBox();
            this.txBxIndex = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.txBxString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txBxValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label25);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cbBxFindValue);
            this.panel2.Controls.Add(this.cbBxFindMaxValue);
            this.panel2.Controls.Add(this.txBxResult);
            this.panel2.Controls.Add(this.cbBxFindMinValue);
            this.panel2.Controls.Add(this.txBxIndex);
            this.panel2.Controls.Add(this.btnResult);
            this.panel2.Controls.Add(this.txBxString);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txBxValue);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(504, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 402);
            this.panel2.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(11, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 116);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Point collection methods";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdBtnFindMinValue);
            this.panel1.Controls.Add(this.rdBtnFindMaxValue);
            this.panel1.Controls.Add(this.rdBtnFindValue);
            this.panel1.Location = new System.Drawing.Point(11, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 88);
            this.panel1.TabIndex = 1;
            // 
            // rdBtnFindMinValue
            // 
            this.rdBtnFindMinValue.AutoSize = true;
            this.rdBtnFindMinValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdBtnFindMinValue.Location = new System.Drawing.Point(14, 60);
            this.rdBtnFindMinValue.Name = "rdBtnFindMinValue";
            this.rdBtnFindMinValue.Size = new System.Drawing.Size(89, 17);
            this.rdBtnFindMinValue.TabIndex = 2;
            this.rdBtnFindMinValue.TabStop = true;
            this.rdBtnFindMinValue.Text = "FindMinValue";
            this.rdBtnFindMinValue.UseVisualStyleBackColor = true;
            this.rdBtnFindMinValue.CheckedChanged += new System.EventHandler(this.rdBtnFindMinValue_CheckedChanged);
            // 
            // rdBtnFindMaxValue
            // 
            this.rdBtnFindMaxValue.AutoSize = true;
            this.rdBtnFindMaxValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdBtnFindMaxValue.Location = new System.Drawing.Point(14, 37);
            this.rdBtnFindMaxValue.Name = "rdBtnFindMaxValue";
            this.rdBtnFindMaxValue.Size = new System.Drawing.Size(92, 17);
            this.rdBtnFindMaxValue.TabIndex = 1;
            this.rdBtnFindMaxValue.TabStop = true;
            this.rdBtnFindMaxValue.Text = "FindMaxValue";
            this.rdBtnFindMaxValue.UseVisualStyleBackColor = true;
            this.rdBtnFindMaxValue.CheckedChanged += new System.EventHandler(this.rdBtnFindMaxValue_CheckedChanged);
            // 
            // rdBtnFindValue
            // 
            this.rdBtnFindValue.AutoSize = true;
            this.rdBtnFindValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdBtnFindValue.Location = new System.Drawing.Point(14, 14);
            this.rdBtnFindValue.Name = "rdBtnFindValue";
            this.rdBtnFindValue.Size = new System.Drawing.Size(72, 17);
            this.rdBtnFindValue.TabIndex = 0;
            this.rdBtnFindValue.TabStop = true;
            this.rdBtnFindValue.Text = "FindValue";
            this.rdBtnFindValue.UseVisualStyleBackColor = true;
            this.rdBtnFindValue.CheckedChanged += new System.EventHandler(this.rdBtnFindValue_CheckedChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label6.Location = new System.Drawing.Point(173, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 1);
            this.label6.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(5, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 24);
            this.label5.TabIndex = 61;
            this.label5.Text = "Select the method type";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label25.Image = ((System.Drawing.Image)(resources.GetObject("label25.Image")));
            this.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label25.Location = new System.Drawing.Point(5, 3);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(176, 24);
            this.label25.TabIndex = 60;
            this.label25.Text = "Find Min and Max methods";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label10.Location = new System.Drawing.Point(186, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 1);
            this.label10.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(5, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter Value(600,400,300,550,500,200)";
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(144, 328);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(5, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "End Index";
            // 
            // cbBxFindValue
            // 
            this.cbBxFindValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBxFindValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBxFindValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbBxFindValue.FormattingEnabled = true;
            this.cbBxFindValue.Items.AddRange(new object[] {
            "FindValue(Double)",
            "FindValue(Double, String)",
            "FindValue(Double, String, Index)",
            "FindValue(Double, String, Index, Index)"});
            this.cbBxFindValue.Location = new System.Drawing.Point(8, 195);
            this.cbBxFindValue.Name = "cbBxFindValue";
            this.cbBxFindValue.Size = new System.Drawing.Size(200, 21);
            this.cbBxFindValue.TabIndex = 2;
            this.cbBxFindValue.SelectedIndexChanged += new System.EventHandler(this.cbBxFindValue_SelectedIndexChanged);
            // 
            // cbBxFindMaxValue
            // 
            this.cbBxFindMaxValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBxFindMaxValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBxFindMaxValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbBxFindMaxValue.FormattingEnabled = true;
            this.cbBxFindMaxValue.Items.AddRange(new object[] {
            "FindMaxValue()",
            "FindMaxValue(String)",
            "FindMaxValue(String, Index)",
            "FindMaxValue(String, Index, Index)"});
            this.cbBxFindMaxValue.Location = new System.Drawing.Point(8, 196);
            this.cbBxFindMaxValue.Name = "cbBxFindMaxValue";
            this.cbBxFindMaxValue.Size = new System.Drawing.Size(200, 21);
            this.cbBxFindMaxValue.TabIndex = 3;
            this.cbBxFindMaxValue.SelectedIndexChanged += new System.EventHandler(this.cbBxFindMaxValue_SelectedIndexChanged);
            // 
            // txBxResult
            // 
            this.txBxResult.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txBxResult.Location = new System.Drawing.Point(8, 365);
            this.txBxResult.Name = "txBxResult";
            this.txBxResult.ReadOnly = true;
            this.txBxResult.Size = new System.Drawing.Size(220, 20);
            this.txBxResult.TabIndex = 12;
            // 
            // cbBxFindMinValue
            // 
            this.cbBxFindMinValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBxFindMinValue.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbBxFindMinValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbBxFindMinValue.FormattingEnabled = true;
            this.cbBxFindMinValue.Items.AddRange(new object[] {
            "FindMinValue()",
            "FindMinValue(String)",
            "FindMinValue(String, Index)",
            "FindMinValue(String, Index, Index)"});
            this.cbBxFindMinValue.Location = new System.Drawing.Point(8, 196);
            this.cbBxFindMinValue.Name = "cbBxFindMinValue";
            this.cbBxFindMinValue.Size = new System.Drawing.Size(200, 21);
            this.cbBxFindMinValue.TabIndex = 4;
            this.cbBxFindMinValue.SelectedIndexChanged += new System.EventHandler(this.cbBxFindMinValue_SelectedIndexChanged);
            // 
            // txBxIndex
            // 
            this.txBxIndex.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txBxIndex.Location = new System.Drawing.Point(144, 296);
            this.txBxIndex.Name = "txBxIndex";
            this.txBxIndex.Size = new System.Drawing.Size(53, 20);
            this.txBxIndex.TabIndex = 11;
            // 
            // btnResult
            // 
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnResult.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnResult.Location = new System.Drawing.Point(234, 362);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txBxString
            // 
            this.txBxString.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txBxString.Location = new System.Drawing.Point(144, 263);
            this.txBxString.Name = "txBxString";
            this.txBxString.Size = new System.Drawing.Size(53, 20);
            this.txBxString.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(5, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Enter String (like X,Y,Y1..)";
            // 
            // txBxValue
            // 
            this.txBxValue.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txBxValue.Location = new System.Drawing.Point(203, 234);
            this.txBxValue.Name = "txBxValue";
            this.txBxValue.Size = new System.Drawing.Size(100, 20);
            this.txBxValue.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(5, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Start Index";
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254))))));
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))));
            this.chartControl1.Legend.Location = new System.Drawing.Point(364, 31);
            this.chartControl1.Location = new System.Drawing.Point(13, 15);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.Size = new System.Drawing.Size(485, 372);
            this.chartControl1.TabIndex = 1;
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(815, 399);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart Point Collection Methods";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdBtnFindMinValue;
        private System.Windows.Forms.RadioButton rdBtnFindMaxValue;
        private System.Windows.Forms.RadioButton rdBtnFindValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBxFindValue;
        private System.Windows.Forms.ComboBox cbBxFindMaxValue;
        private System.Windows.Forms.TextBox txBxResult;
        private System.Windows.Forms.ComboBox cbBxFindMinValue;
        private System.Windows.Forms.TextBox txBxIndex;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txBxString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txBxValue;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

