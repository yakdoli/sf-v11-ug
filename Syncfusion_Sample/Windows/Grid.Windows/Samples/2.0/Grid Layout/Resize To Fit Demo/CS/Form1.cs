using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;

namespace ResizeToFit
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private GroupBox groupBox3;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv3;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv4;
        private GroupBox groupBox2;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv11;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv12;
        private GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv2;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv1;
        private GroupBox groupBox4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private ButtonAdv ButtonAdv5;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv8;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv7;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv6;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv5;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        #endregion

        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
            this.radioButtonAdv5.Checked = true;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

        }

        #region Helper Methods
        private DataTable GetTable()
        {
            DataTable dt = new DataTable("MyTable");

            int nCols = 12;
            int nRows = 30;
            long n=10000;
            for (int i = 0; i < nCols; i++)
                dt.Columns.Add(new DataColumn(string.Format("Col{0}", i)));

            for (int i = 0; i < nRows; ++i)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < nCols; j++)
                {
                    n+=10;
                    if (j == 0)
                        dr[j] = n * n*n;
                    else
                        dr[j] = string.Format("row{0} col{1}", i, j);
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
        #endregion

        #region Form Handlers
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
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
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle4 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle5 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle6 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonAdv3 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv4 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonAdv11 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv12 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAdv2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonAdv5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.radioButtonAdv8 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv7 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv6 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv5 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv4)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv12)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv5)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gridControl1.ApplyVisualStyles = false;
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 12;
            this.gridControl1.DefaultRowHeight = 20;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.Location = new System.Drawing.Point(12, 19);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            gridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle4.StyleInfo.Font.Bold = false;
            gridRangeStyle4.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle4.StyleInfo.Font.Italic = false;
            gridRangeStyle4.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle4.StyleInfo.Font.Strikeout = false;
            gridRangeStyle4.StyleInfo.Font.Underline = false;
            gridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle5.StyleInfo.Font.Bold = false;
            gridRangeStyle5.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle5.StyleInfo.Font.Italic = false;
            gridRangeStyle5.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle5.StyleInfo.Font.Strikeout = false;
            gridRangeStyle5.StyleInfo.Font.Underline = false;
            gridRangeStyle5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle6.StyleInfo.Font.Bold = false;
            gridRangeStyle6.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle6.StyleInfo.Font.Italic = false;
            gridRangeStyle6.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle6.StyleInfo.Font.Strikeout = false;
            gridRangeStyle6.StyleInfo.Font.Underline = false;
            gridRangeStyle6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            this.gridControl1.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
            gridRangeStyle4,
            gridRangeStyle5,
            gridRangeStyle6});
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowCount = 30;
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(603, 459);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ThemesEnabled = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonAdv3);
            this.groupBox3.Controls.Add(this.radioButtonAdv4);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(632, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 75);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ReSizeToFitOptimized";
            // 
            // radioButtonAdv3
            // 
            this.radioButtonAdv3.DrawFocusRectangle = false;
            this.radioButtonAdv3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv3.Location = new System.Drawing.Point(16, 48);
            this.radioButtonAdv3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv3.Name = "radioButtonAdv3";
            this.radioButtonAdv3.Size = new System.Drawing.Size(121, 21);
            this.radioButtonAdv3.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv3.TabIndex = 3;
            this.radioButtonAdv3.Text = "RowHeight";
            this.radioButtonAdv3.ThemesEnabled = false;
            this.radioButtonAdv3.CheckChanged += new System.EventHandler(this.radioButtonAdv3_CheckChanged);
            // 
            // radioButtonAdv4
            // 
            this.radioButtonAdv4.DrawFocusRectangle = false;
            this.radioButtonAdv4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv4.Location = new System.Drawing.Point(16, 21);
            this.radioButtonAdv4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv4.Name = "radioButtonAdv4";
            this.radioButtonAdv4.Size = new System.Drawing.Size(121, 21);
            this.radioButtonAdv4.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv4.TabIndex = 2;
            this.radioButtonAdv4.Text = "ColWidths";
            this.radioButtonAdv4.ThemesEnabled = false;
            this.radioButtonAdv4.CheckChanged += new System.EventHandler(this.radioButtonAdv4_CheckChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonAdv11);
            this.groupBox2.Controls.Add(this.radioButtonAdv12);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(632, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 72);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ReSizeToFit";
            // 
            // radioButtonAdv11
            // 
            this.radioButtonAdv11.DrawFocusRectangle = false;
            this.radioButtonAdv11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv11.Location = new System.Drawing.Point(16, 48);
            this.radioButtonAdv11.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv11.Name = "radioButtonAdv11";
            this.radioButtonAdv11.Size = new System.Drawing.Size(121, 21);
            this.radioButtonAdv11.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv11.TabIndex = 3;
            this.radioButtonAdv11.Text = "RowHeight";
            this.radioButtonAdv11.ThemesEnabled = false;
            this.radioButtonAdv11.CheckChanged += new System.EventHandler(this.radioButtonAdv11_CheckChanged);
            // 
            // radioButtonAdv12
            // 
            this.radioButtonAdv12.DrawFocusRectangle = false;
            this.radioButtonAdv12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv12.Location = new System.Drawing.Point(16, 21);
            this.radioButtonAdv12.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv12.Name = "radioButtonAdv12";
            this.radioButtonAdv12.Size = new System.Drawing.Size(121, 21);
            this.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv12.TabIndex = 2;
            this.radioButtonAdv12.Text = "ColWidths";
            this.radioButtonAdv12.ThemesEnabled = false;
            this.radioButtonAdv12.CheckChanged += new System.EventHandler(this.radioButtonAdv12_CheckChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAdv2);
            this.groupBox1.Controls.Add(this.radioButtonAdv1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(632, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 77);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // radioButtonAdv2
            // 
            this.radioButtonAdv2.DrawFocusRectangle = false;
            this.radioButtonAdv2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv2.Location = new System.Drawing.Point(16, 48);
            this.radioButtonAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv2.Name = "radioButtonAdv2";
            this.radioButtonAdv2.Size = new System.Drawing.Size(121, 21);
            this.radioButtonAdv2.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv2.TabIndex = 1;
            this.radioButtonAdv2.Text = "Set Column Width";
            this.radioButtonAdv2.ThemesEnabled = false;
            this.radioButtonAdv2.CheckChanged += new System.EventHandler(this.radioButtonAdv2_CheckChanged);
            // 
            // radioButtonAdv1
            // 
            this.radioButtonAdv1.DrawFocusRectangle = false;
            this.radioButtonAdv1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv1.Location = new System.Drawing.Point(16, 21);
            this.radioButtonAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv1.Name = "radioButtonAdv1";
            this.radioButtonAdv1.Size = new System.Drawing.Size(121, 21);
            this.radioButtonAdv1.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv1.TabIndex = 0;
            this.radioButtonAdv1.Text = "Set RowHeight";
            this.radioButtonAdv1.ThemesEnabled = false;
            this.radioButtonAdv1.CheckChanged += new System.EventHandler(this.radioButtonAdv1_CheckChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.ButtonAdv5);
            this.groupBox4.Controls.Add(this.radioButtonAdv8);
            this.groupBox4.Controls.Add(this.radioButtonAdv7);
            this.groupBox4.Controls.Add(this.radioButtonAdv6);
            this.groupBox4.Controls.Add(this.radioButtonAdv5);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(632, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(261, 263);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AutoFit";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(129, 47);
            this.textBox3.MaxLength = 1;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(46, 22);
            this.textBox3.TabIndex = 26;
            this.textBox3.Text = "#";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Enter the Character:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Enter your Choice:";
            // 
            // ButtonAdv5
            // 
            this.ButtonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.ButtonAdv5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.ButtonAdv5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.ButtonAdv5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAdv5.ForeColor = System.Drawing.Color.White;
            this.ButtonAdv5.Location = new System.Drawing.Point(57, 211);
            this.ButtonAdv5.Name = "ButtonAdv5";
            this.ButtonAdv5.Size = new System.Drawing.Size(118, 27);
            this.ButtonAdv5.TabIndex = 23;
            this.ButtonAdv5.Text = "Update";
            this.ButtonAdv5.UseVisualStyle = true;
            this.ButtonAdv5.Click += new System.EventHandler(this.ButtonAdv5_Click);
            // 
            // radioButtonAdv8
            // 
            this.radioButtonAdv8.DrawFocusRectangle = false;
            this.radioButtonAdv8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv8.Location = new System.Drawing.Point(54, 184);
            this.radioButtonAdv8.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv8.Name = "radioButtonAdv8";
            this.radioButtonAdv8.Size = new System.Drawing.Size(121, 21);
            this.radioButtonAdv8.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv8.TabIndex = 22;
            this.radioButtonAdv8.Text = "Both";
            this.radioButtonAdv8.ThemesEnabled = false;
            this.radioButtonAdv8.CheckChanged += new System.EventHandler(this.radioButtonAdv8_CheckChanged);
            // 
            // radioButtonAdv7
            // 
            this.radioButtonAdv7.DrawFocusRectangle = false;
            this.radioButtonAdv7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv7.Location = new System.Drawing.Point(54, 157);
            this.radioButtonAdv7.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv7.Name = "radioButtonAdv7";
            this.radioButtonAdv7.Size = new System.Drawing.Size(121, 21);
            this.radioButtonAdv7.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv7.TabIndex = 21;
            this.radioButtonAdv7.Text = "Numbers";
            this.radioButtonAdv7.ThemesEnabled = false;
            this.radioButtonAdv7.CheckChanged += new System.EventHandler(this.radioButtonAdv7_CheckChanged);
            // 
            // radioButtonAdv6
            // 
            this.radioButtonAdv6.DrawFocusRectangle = false;
            this.radioButtonAdv6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv6.Location = new System.Drawing.Point(54, 130);
            this.radioButtonAdv6.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv6.Name = "radioButtonAdv6";
            this.radioButtonAdv6.Size = new System.Drawing.Size(121, 21);
            this.radioButtonAdv6.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv6.TabIndex = 20;
            this.radioButtonAdv6.Text = "Alphabets";
            this.radioButtonAdv6.ThemesEnabled = false;
            this.radioButtonAdv6.CheckChanged += new System.EventHandler(this.radioButtonAdv6_CheckChanged);
            // 
            // radioButtonAdv5
            // 
            this.radioButtonAdv5.DrawFocusRectangle = false;
            this.radioButtonAdv5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonAdv5.Location = new System.Drawing.Point(54, 103);
            this.radioButtonAdv5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radioButtonAdv5.Name = "radioButtonAdv5";
            this.radioButtonAdv5.Size = new System.Drawing.Size(121, 21);
            this.radioButtonAdv5.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radioButtonAdv5.TabIndex = 19;
            this.radioButtonAdv5.Text = "None";
            this.radioButtonAdv5.ThemesEnabled = false;
            this.radioButtonAdv5.CheckChanged += new System.EventHandler(this.radioButtonAdv5_CheckChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(76, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 22);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(181, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(36, 22);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ColIndex:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "RowIndex:";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(917, 512);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.DropShadow = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resize To Fit Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv4)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv12)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv5)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
        }
        #endregion

        #region EventHandler
        private void radioButtonAdv1_CheckChanged(object sender, EventArgs e)
        {
            // Set the Rowheight of the 1 st row
            this.gridControl1.RowHeights[1] = 20;

            // Set the Rowheight of the 2 st row
            this.gridControl1.RowHeights[2] = 50;

            // Set the Rowheight of the 3 st row
            this.gridControl1.RowHeights[3] = 70;
        }

        private void radioButtonAdv2_CheckChanged(object sender, EventArgs e)
        {            
            //Set the ColWidth of the 1 st column
            this.gridControl1.ColWidths[1] = 20;

            //Set the ColWidth of the 1 st column
            this.gridControl1.ColWidths[2] = 50;

            //Set the ColWidth of the 1 st column
            this.gridControl1.ColWidths[3] = 70;
        }

        private void radioButtonAdv12_CheckChanged(object sender, EventArgs e)
        {            
            // ResizeToFit - Resizes a range of rows or column to optimally fit 
            // contents of the specified range of cells.
            this.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cols(1, 5));
        }

        private void radioButtonAdv11_CheckChanged(object sender, EventArgs e)
        {
            this.gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Rows(1, 5));
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, 30, 12), GetTable());
        }

        private void radioButtonAdv4_CheckChanged(object sender, EventArgs e)
        {
            this.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cols(1, 5));
        }

        private void radioButtonAdv3_CheckChanged(object sender, EventArgs e)
        {
            this.gridControl1.RowHeights.ResizeToFitOptimized(GridRangeInfo.Rows(1, 5));
        }
        
        #endregion        
    

        private void radioButtonAdv5_CheckChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
                this.gridControl1[int.Parse(textBox1.Text), int.Parse(textBox2.Text)].AutoFit = AutoFitOptions.None;
           
        }

        private void radioButtonAdv6_CheckChanged(object sender, EventArgs e)
        {

            if ((textBox3.Text != "")&&(textBox1.Text != "" && textBox2.Text != ""))
                this.gridControl1[int.Parse(textBox1.Text), int.Parse(textBox2.Text)].AutoFitChar = char.Parse(textBox3.Text);

            if (textBox1.Text != "" && textBox2.Text != "")
                this.gridControl1[int.Parse(textBox1.Text), int.Parse(textBox2.Text)].AutoFit = AutoFitOptions.Alphabet;
            else
                MessageBox.Show("Please Enter the Correct Index Values");
        }
        

        private void radioButtonAdv7_CheckChanged(object sender, EventArgs e)
        {
            if ((textBox3.Text != "")&&(textBox1.Text != "" && textBox2.Text != ""))
                this.gridControl1[int.Parse(textBox1.Text), int.Parse(textBox2.Text)].AutoFitChar = char.Parse(textBox3.Text);
            if (textBox1.Text != "" && textBox2.Text != "")
                this.gridControl1[int.Parse(textBox1.Text), int.Parse(textBox2.Text)].AutoFit = AutoFitOptions.Numeric;
            else
                MessageBox.Show("Please Enter the Correct Index Values");
            
        }

        private void radioButtonAdv8_CheckChanged(object sender, EventArgs e)
        {
            if ((textBox3.Text != "")&&(textBox1.Text != "" && textBox2.Text != ""))
                this.gridControl1[int.Parse(textBox1.Text), int.Parse(textBox2.Text)].AutoFitChar = char.Parse(textBox3.Text);
            if (textBox1.Text != "" && textBox2.Text != "")
                this.gridControl1[int.Parse(textBox1.Text), int.Parse(textBox2.Text)].AutoFit = AutoFitOptions.Both;
            else
                MessageBox.Show("Please Enter the Correct Index Values");
            
        }

        private void ButtonAdv5_Click(object sender, EventArgs e)
        {

            if (radioButtonAdv5.Checked)
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                    this.gridControl1[int.Parse(textBox1.Text), int.Parse(textBox2.Text)].AutoFit = AutoFitOptions.None;
            }
            else if (radioButtonAdv6.Checked)
            {
                if ((textBox3.Text != "")&&(textBox1.Text != "" && textBox2.Text != ""))
                    this.gridControl1[int.Parse(textBox1.Text), int.Parse(textBox2.Text)].AutoFitChar = char.Parse(textBox3.Text);
                if (textBox1.Text != "" && textBox2.Text != "")
                    this.gridControl1[int.Parse(textBox1.Text), int.Parse(textBox2.Text)].AutoFit = AutoFitOptions.Alphabet;
                else
                    MessageBox.Show("Please Enter the Correct Index Values");
            }
            else if (radioButtonAdv7.Checked)
            {
                if ((textBox3.Text != "") && (textBox1.Text != "" && textBox2.Text != ""))
                    this.gridControl1[int.Parse(textBox1.Text), int.Parse(textBox2.Text)].AutoFitChar =char.Parse(textBox3.Text);
                if (textBox1.Text != "" && textBox2.Text != "")
                    this.gridControl1[int.Parse(textBox1.Text), int.Parse(textBox2.Text)].AutoFit = AutoFitOptions.Numeric;
                else
                    MessageBox.Show("Please Enter the Correct Index Values");
            }
            else if (radioButtonAdv8.Checked)
            {
                if ((textBox3.Text != "") && (textBox1.Text != "" && textBox2.Text != ""))
                    this.gridControl1[int.Parse(textBox1.Text), int.Parse(textBox2.Text)].AutoFitChar = char.Parse(textBox3.Text);
                if (textBox1.Text != "" && textBox2.Text != "")
                    this.gridControl1[int.Parse(textBox1.Text), int.Parse(textBox2.Text)].AutoFit = AutoFitOptions.Both;
                else
                    MessageBox.Show("Please Enter the Correct Index Values");
            }
        }
	}
}
