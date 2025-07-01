using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace GridProperties
{
	public class Form1 : MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Tools.XPTaskBar xpTaskBar1;
		private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton5;
		private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton4;
		private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton3;
		private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton2;
		private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton1;
        private Syncfusion.Windows.Forms.ButtonAdv button1;
		private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox1;
		private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Syncfusion.Windows.Forms.ButtonAdv button2;
		private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.ButtonAdv button3;
		private System.Windows.Forms.Panel panel1;
		private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private Syncfusion.Windows.Forms.ColorPickerButton colorPickerButton6;
        private ButtonAdv buttonAdv1;
        private bool temp1, temp2 = false;
        private CheckBoxAdv checkBoxAdv1;
        private CheckBoxAdv checkBoxAdv2;
        private CheckBoxAdv checkBoxAdv3;
        private CheckBoxAdv checkBoxAdv4;
        private CheckBoxAdv checkBoxAdv5;
        private CheckBoxAdv checkBoxAdv7;
        private CheckBoxAdv checkBoxAdv8;
        private CheckBoxAdv checkBoxAdv9;
        private CheckBoxAdv checkBoxAdv10;
        private CheckBoxAdv checkBoxAdv11;
        private CheckBoxAdv checkBoxAdv12;
        private CheckBoxAdv checkBoxAdv13;
        private CheckBoxAdv checkBoxAdv14;
        private CheckBoxAdv checkBoxAdv15;
        private CheckBoxAdv checkBoxAdv16;
        private CheckBoxAdv checkBoxAdv17;
        private IContainer components;
        #endregion

        public Form1()
		{
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
        }

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
		
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle1 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle2 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle3 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle4 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle5 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle6 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle7 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle8 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle9 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle10 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle11 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle12 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle13 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle14 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle15 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle16 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle17 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle18 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle19 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle20 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle21 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle22 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle23 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle24 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle25 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle26 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle27 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle28 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle29 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle30 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle31 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle32 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            this.xpTaskBar1 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.xpTaskBarBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.checkBoxAdv8 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv7 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv5 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.colorPickerButton6 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton1 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton2 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton3 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.colorPickerButton4 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.colorPickerButton5 = new Syncfusion.Windows.Forms.ColorPickerButton();
            this.button2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.xpTaskBarBox2 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.checkBoxAdv17 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv9 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv16 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv15 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv14 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv13 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv12 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv11 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv10 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.button3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).BeginInit();
            this.xpTaskBar1.SuspendLayout();
            this.xpTaskBarBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            this.xpTaskBarBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv10)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // xpTaskBar1
            // 
            this.xpTaskBar1.BackColor = System.Drawing.Color.White;
            this.xpTaskBar1.BorderColor = System.Drawing.Color.Black;
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox1);
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox2);
            this.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.xpTaskBar1.Location = new System.Drawing.Point(640, 0);
            this.xpTaskBar1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.xpTaskBar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar1.Name = "xpTaskBar1";
            this.xpTaskBar1.Size = new System.Drawing.Size(371, 488);
            this.xpTaskBar1.TabIndex = 0;
            // 
            // xpTaskBarBox1
            // 
            this.xpTaskBarBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xpTaskBarBox1.BackColor = System.Drawing.Color.White;
            this.xpTaskBarBox1.Controls.Add(this.gradientPanel1);
            this.xpTaskBarBox1.HeaderBackColor = System.Drawing.Color.Gray;
            this.xpTaskBarBox1.HeaderForeColor = System.Drawing.Color.White;
            this.xpTaskBarBox1.HeaderImageIndex = -1;
            this.xpTaskBarBox1.HitTaskBoxArea = false;
            this.xpTaskBarBox1.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox1.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.xpTaskBarBox1.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBarBox1.Name = "xpTaskBarBox1";
            this.xpTaskBarBox1.PreferredChildPanelHeight = 250;
            this.xpTaskBarBox1.Size = new System.Drawing.Size(371, 282);
            this.xpTaskBarBox1.TabIndex = 0;
            this.xpTaskBarBox1.Text = "Appearance";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.gradientPanel1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedInner;
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.checkBoxAdv8);
            this.gradientPanel1.Controls.Add(this.checkBoxAdv7);
            this.gradientPanel1.Controls.Add(this.checkBoxAdv5);
            this.gradientPanel1.Controls.Add(this.checkBoxAdv4);
            this.gradientPanel1.Controls.Add(this.checkBoxAdv3);
            this.gradientPanel1.Controls.Add(this.checkBoxAdv2);
            this.gradientPanel1.Controls.Add(this.checkBoxAdv1);
            this.gradientPanel1.Controls.Add(this.buttonAdv1);
            this.gradientPanel1.Controls.Add(this.colorPickerButton6);
            this.gradientPanel1.Controls.Add(this.colorPickerButton1);
            this.gradientPanel1.Controls.Add(this.colorPickerButton2);
            this.gradientPanel1.Controls.Add(this.colorPickerButton3);
            this.gradientPanel1.Controls.Add(this.button1);
            this.gradientPanel1.Controls.Add(this.colorPickerButton4);
            this.gradientPanel1.Controls.Add(this.colorPickerButton5);
            this.gradientPanel1.Controls.Add(this.button2);
            this.gradientPanel1.Location = new System.Drawing.Point(2, 30);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(367, 250);
            this.gradientPanel1.TabIndex = 0;
            // 
            // checkBoxAdv8
            // 
            this.checkBoxAdv8.Checked = true;
            this.checkBoxAdv8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv8.DrawFocusRectangle = false;
            this.checkBoxAdv8.Location = new System.Drawing.Point(13, 181);
            this.checkBoxAdv8.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv8.Name = "checkBoxAdv8";
            this.checkBoxAdv8.Size = new System.Drawing.Size(157, 21);
            this.checkBoxAdv8.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv8.TabIndex = 22;
            this.checkBoxAdv8.Text = "Buttons3D";
            this.checkBoxAdv8.ThemesEnabled = false;
            this.checkBoxAdv8.CheckStateChanged += new System.EventHandler(this.checkBoxAdv8_CheckStateChanged);
            // 
            // checkBoxAdv7
            // 
            this.checkBoxAdv7.DrawFocusRectangle = false;
            this.checkBoxAdv7.Location = new System.Drawing.Point(13, 215);
            this.checkBoxAdv7.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv7.Name = "checkBoxAdv7";
            this.checkBoxAdv7.Size = new System.Drawing.Size(157, 21);
            this.checkBoxAdv7.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv7.TabIndex = 21;
            this.checkBoxAdv7.Text = "Transparent Background";
            this.checkBoxAdv7.ThemesEnabled = false;
            this.checkBoxAdv7.CheckStateChanged += new System.EventHandler(this.checkBoxAdv7_CheckStateChanged);
            // 
            // checkBoxAdv5
            // 
            this.checkBoxAdv5.Checked = true;
            this.checkBoxAdv5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv5.DrawFocusRectangle = false;
            this.checkBoxAdv5.Location = new System.Drawing.Point(13, 147);
            this.checkBoxAdv5.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv5.Name = "checkBoxAdv5";
            this.checkBoxAdv5.Size = new System.Drawing.Size(157, 21);
            this.checkBoxAdv5.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv5.TabIndex = 19;
            this.checkBoxAdv5.Text = "Enabled";
            this.checkBoxAdv5.ThemesEnabled = false;
            this.checkBoxAdv5.CheckStateChanged += new System.EventHandler(this.checkBoxAdv5_CheckStateChanged);
            // 
            // checkBoxAdv4
            // 
            this.checkBoxAdv4.Checked = true;
            this.checkBoxAdv4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv4.DrawFocusRectangle = false;
            this.checkBoxAdv4.Location = new System.Drawing.Point(13, 111);
            this.checkBoxAdv4.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv4.Name = "checkBoxAdv4";
            this.checkBoxAdv4.Size = new System.Drawing.Size(163, 21);
            this.checkBoxAdv4.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv4.TabIndex = 18;
            this.checkBoxAdv4.Text = "Display Vrtcl Lines";
            this.checkBoxAdv4.ThemesEnabled = false;
            this.checkBoxAdv4.CheckStateChanged += new System.EventHandler(this.checkBoxAdv4_CheckStateChanged);
            // 
            // checkBoxAdv3
            // 
            this.checkBoxAdv3.Checked = true;
            this.checkBoxAdv3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv3.DrawFocusRectangle = false;
            this.checkBoxAdv3.Location = new System.Drawing.Point(13, 77);
            this.checkBoxAdv3.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv3.Name = "checkBoxAdv3";
            this.checkBoxAdv3.Size = new System.Drawing.Size(157, 21);
            this.checkBoxAdv3.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv3.TabIndex = 1;
            this.checkBoxAdv3.Text = "Display Horzntl Lines";
            this.checkBoxAdv3.ThemesEnabled = false;
            this.checkBoxAdv3.CheckStateChanged += new System.EventHandler(this.checkBoxAdv3_CheckStateChanged);
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.Checked = true;
            this.checkBoxAdv2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv2.DrawFocusRectangle = false;
            this.checkBoxAdv2.Location = new System.Drawing.Point(13, 42);
            this.checkBoxAdv2.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.Size = new System.Drawing.Size(157, 21);
            this.checkBoxAdv2.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv2.TabIndex = 1;
            this.checkBoxAdv2.Text = "Show RowHeaders";
            this.checkBoxAdv2.ThemesEnabled = false;
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv1.Checked = true;
            this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv1.DrawFocusRectangle = false;
            this.checkBoxAdv1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAdv1.Location = new System.Drawing.Point(13, 5);
            this.checkBoxAdv1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.Size = new System.Drawing.Size(150, 21);
            this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv1.TabIndex = 1;
            this.checkBoxAdv1.Text = "Show ColHeaders";
            this.checkBoxAdv1.ThemesEnabled = false;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.Location = new System.Drawing.Point(173, 258);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(185, 40);
            this.buttonAdv1.TabIndex = 16;
            this.buttonAdv1.Text = "Remove Numbering in Headers";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.UseVisualStyleBackColor = true;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // colorPickerButton6
            // 
            this.colorPickerButton6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.colorPickerButton6.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.colorPickerButton6.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton6.ForeColor = System.Drawing.Color.White;
            this.colorPickerButton6.Location = new System.Drawing.Point(182, 111);
            this.colorPickerButton6.Name = "colorPickerButton6";
            this.colorPickerButton6.Size = new System.Drawing.Size(161, 30);
            this.colorPickerButton6.TabIndex = 15;
            this.colorPickerButton6.Text = "Grid TextColor";
            this.colorPickerButton6.UseVisualStyle = true;
            this.colorPickerButton6.UseVisualStyleBackColor = true;
            // 
            // colorPickerButton1
            // 
            this.colorPickerButton1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.colorPickerButton1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.colorPickerButton1.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton1.ForeColor = System.Drawing.Color.White;
            this.colorPickerButton1.Location = new System.Drawing.Point(182, 5);
            this.colorPickerButton1.Name = "colorPickerButton1";
            this.colorPickerButton1.Size = new System.Drawing.Size(160, 28);
            this.colorPickerButton1.TabIndex = 10;
            this.colorPickerButton1.Text = "BackColor";
            this.colorPickerButton1.UseVisualStyle = true;
            this.colorPickerButton1.UseVisualStyleBackColor = true;
            // 
            // colorPickerButton2
            // 
            this.colorPickerButton2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.colorPickerButton2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.colorPickerButton2.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton2.ForeColor = System.Drawing.Color.White;
            this.colorPickerButton2.Location = new System.Drawing.Point(182, 42);
            this.colorPickerButton2.Name = "colorPickerButton2";
            this.colorPickerButton2.Size = new System.Drawing.Size(161, 28);
            this.colorPickerButton2.TabIndex = 11;
            this.colorPickerButton2.Text = "BackgroundColor";
            this.colorPickerButton2.UseVisualStyle = true;
            this.colorPickerButton2.UseVisualStyleBackColor = true;
            // 
            // colorPickerButton3
            // 
            this.colorPickerButton3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.colorPickerButton3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.colorPickerButton3.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton3.ForeColor = System.Drawing.Color.White;
            this.colorPickerButton3.Location = new System.Drawing.Point(182, 147);
            this.colorPickerButton3.Name = "colorPickerButton3";
            this.colorPickerButton3.Size = new System.Drawing.Size(160, 28);
            this.colorPickerButton3.TabIndex = 12;
            this.colorPickerButton3.Text = "Fixed Lines Color";
            this.colorPickerButton3.UseVisualStyle = true;
            this.colorPickerButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(182, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "BackgroundImage";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorPickerButton4
            // 
            this.colorPickerButton4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.colorPickerButton4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.colorPickerButton4.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton4.ForeColor = System.Drawing.Color.White;
            this.colorPickerButton4.Location = new System.Drawing.Point(182, 77);
            this.colorPickerButton4.Name = "colorPickerButton4";
            this.colorPickerButton4.Size = new System.Drawing.Size(161, 28);
            this.colorPickerButton4.TabIndex = 13;
            this.colorPickerButton4.Text = "Grid Line Color";
            this.colorPickerButton4.UseVisualStyle = true;
            this.colorPickerButton4.UseVisualStyleBackColor = true;
            // 
            // colorPickerButton5
            // 
            this.colorPickerButton5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.colorPickerButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.colorPickerButton5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.colorPickerButton5.ColorUISize = new System.Drawing.Size(208, 230);
            this.colorPickerButton5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorPickerButton5.ForeColor = System.Drawing.Color.White;
            this.colorPickerButton5.Location = new System.Drawing.Point(182, 181);
            this.colorPickerButton5.Name = "colorPickerButton5";
            this.colorPickerButton5.Size = new System.Drawing.Size(161, 28);
            this.colorPickerButton5.TabIndex = 14;
            this.colorPickerButton5.Text = "Resizing Cells Line Color";
            this.colorPickerButton5.UseVisualStyle = true;
            this.colorPickerButton5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.button2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(4, 249);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove Background Image";
            this.button2.UseVisualStyle = true;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // xpTaskBarBox2
            // 
            this.xpTaskBarBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xpTaskBarBox2.BackColor = System.Drawing.Color.White;
            this.xpTaskBarBox2.Controls.Add(this.gradientPanel2);
            this.xpTaskBarBox2.HeaderBackColor = System.Drawing.Color.Gray;
            this.xpTaskBarBox2.HeaderForeColor = System.Drawing.Color.White;
            this.xpTaskBarBox2.HeaderImageIndex = -1;
            this.xpTaskBarBox2.HitTaskBoxArea = false;
            this.xpTaskBarBox2.HotTrackColor = System.Drawing.Color.Empty;
            this.xpTaskBarBox2.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(171)))), ((int)(((byte)(201)))));
            this.xpTaskBarBox2.Location = new System.Drawing.Point(0, 282);
            this.xpTaskBarBox2.Name = "xpTaskBarBox2";
            this.xpTaskBarBox2.PreferredChildPanelHeight = 170;
            this.xpTaskBarBox2.Size = new System.Drawing.Size(371, 202);
            this.xpTaskBarBox2.TabIndex = 1;
            this.xpTaskBarBox2.Text = "PrintStyle";
            this.xpTaskBarBox2.ItemClick += new Syncfusion.Windows.Forms.Tools.XPTaskBarItemClickHandler(this.xpTaskBarBox2_ItemClick);
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.gradientPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.checkBoxAdv17);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv9);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv16);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv15);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv14);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv13);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv12);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv11);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv10);
            this.gradientPanel2.Controls.Add(this.button3);
            this.gradientPanel2.Location = new System.Drawing.Point(2, 30);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(367, 170);
            this.gradientPanel2.TabIndex = 0;
            // 
            // checkBoxAdv17
            // 
            this.checkBoxAdv17.DrawFocusRectangle = false;
            this.checkBoxAdv17.Location = new System.Drawing.Point(13, 130);
            this.checkBoxAdv17.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv17.Name = "checkBoxAdv17";
            this.checkBoxAdv17.Size = new System.Drawing.Size(157, 21);
            this.checkBoxAdv17.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv17.TabIndex = 13;
            this.checkBoxAdv17.Text = "Printing";
            this.checkBoxAdv17.ThemesEnabled = false;
            this.checkBoxAdv17.CheckStateChanged += new System.EventHandler(this.checkBoxAdv17_CheckStateChanged);
            // 
            // checkBoxAdv9
            // 
            this.checkBoxAdv9.Checked = true;
            this.checkBoxAdv9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv9.DrawFocusRectangle = false;
            this.checkBoxAdv9.Location = new System.Drawing.Point(13, 21);
            this.checkBoxAdv9.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv9.Name = "checkBoxAdv9";
            this.checkBoxAdv9.Size = new System.Drawing.Size(150, 21);
            this.checkBoxAdv9.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv9.TabIndex = 10;
            this.checkBoxAdv9.Text = "Center Horizontal";
            this.checkBoxAdv9.ThemesEnabled = false;
            this.checkBoxAdv9.CheckStateChanged += new System.EventHandler(this.checkBoxAdv9_CheckStateChanged);
            // 
            // checkBoxAdv16
            // 
            this.checkBoxAdv16.Checked = true;
            this.checkBoxAdv16.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv16.DrawFocusRectangle = false;
            this.checkBoxAdv16.Location = new System.Drawing.Point(182, 103);
            this.checkBoxAdv16.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv16.Name = "checkBoxAdv16";
            this.checkBoxAdv16.Size = new System.Drawing.Size(160, 21);
            this.checkBoxAdv16.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv16.TabIndex = 12;
            this.checkBoxAdv16.Text = "Black/White";
            this.checkBoxAdv16.ThemesEnabled = false;
            this.checkBoxAdv16.CheckStateChanged += new System.EventHandler(this.checkBoxAdv16_CheckStateChanged);
            // 
            // checkBoxAdv15
            // 
            this.checkBoxAdv15.Checked = true;
            this.checkBoxAdv15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv15.DrawFocusRectangle = false;
            this.checkBoxAdv15.Location = new System.Drawing.Point(13, 103);
            this.checkBoxAdv15.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv15.Name = "checkBoxAdv15";
            this.checkBoxAdv15.Size = new System.Drawing.Size(150, 21);
            this.checkBoxAdv15.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv15.TabIndex = 11;
            this.checkBoxAdv15.Text = "Print Frame";
            this.checkBoxAdv15.ThemesEnabled = false;
            this.checkBoxAdv15.CheckStateChanged += new System.EventHandler(this.checkBoxAdv15_CheckStateChanged);
            // 
            // checkBoxAdv14
            // 
            this.checkBoxAdv14.Checked = true;
            this.checkBoxAdv14.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv14.DrawFocusRectangle = false;
            this.checkBoxAdv14.Location = new System.Drawing.Point(182, 76);
            this.checkBoxAdv14.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv14.Name = "checkBoxAdv14";
            this.checkBoxAdv14.Size = new System.Drawing.Size(161, 21);
            this.checkBoxAdv14.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv14.TabIndex = 11;
            this.checkBoxAdv14.Text = "Print Vrtcl Lines";
            this.checkBoxAdv14.ThemesEnabled = false;
            this.checkBoxAdv14.CheckStateChanged += new System.EventHandler(this.checkBoxAdv14_CheckStateChanged);
            // 
            // checkBoxAdv13
            // 
            this.checkBoxAdv13.Checked = true;
            this.checkBoxAdv13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv13.DrawFocusRectangle = false;
            this.checkBoxAdv13.Location = new System.Drawing.Point(13, 76);
            this.checkBoxAdv13.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv13.Name = "checkBoxAdv13";
            this.checkBoxAdv13.Size = new System.Drawing.Size(157, 21);
            this.checkBoxAdv13.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv13.TabIndex = 11;
            this.checkBoxAdv13.Text = "Print Hzntl Lines";
            this.checkBoxAdv13.ThemesEnabled = false;
            this.checkBoxAdv13.CheckStateChanged += new System.EventHandler(this.checkBoxAdv13_CheckStateChanged);
            // 
            // checkBoxAdv12
            // 
            this.checkBoxAdv12.Checked = true;
            this.checkBoxAdv12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv12.DrawFocusRectangle = false;
            this.checkBoxAdv12.Location = new System.Drawing.Point(182, 49);
            this.checkBoxAdv12.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv12.Name = "checkBoxAdv12";
            this.checkBoxAdv12.Size = new System.Drawing.Size(150, 21);
            this.checkBoxAdv12.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv12.TabIndex = 11;
            this.checkBoxAdv12.Text = "Print RowHeader";
            this.checkBoxAdv12.ThemesEnabled = false;
            this.checkBoxAdv12.CheckStateChanged += new System.EventHandler(this.checkBoxAdv12_CheckStateChanged);
            // 
            // checkBoxAdv11
            // 
            this.checkBoxAdv11.Checked = true;
            this.checkBoxAdv11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv11.DrawFocusRectangle = false;
            this.checkBoxAdv11.Location = new System.Drawing.Point(13, 49);
            this.checkBoxAdv11.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv11.Name = "checkBoxAdv11";
            this.checkBoxAdv11.Size = new System.Drawing.Size(163, 21);
            this.checkBoxAdv11.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv11.TabIndex = 11;
            this.checkBoxAdv11.Text = "Print ColHeader";
            this.checkBoxAdv11.ThemesEnabled = false;
            this.checkBoxAdv11.CheckStateChanged += new System.EventHandler(this.checkBoxAdv11_CheckStateChanged);
            // 
            // checkBoxAdv10
            // 
            this.checkBoxAdv10.Checked = true;
            this.checkBoxAdv10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv10.DrawFocusRectangle = false;
            this.checkBoxAdv10.Location = new System.Drawing.Point(182, 21);
            this.checkBoxAdv10.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBoxAdv10.Name = "checkBoxAdv10";
            this.checkBoxAdv10.Size = new System.Drawing.Size(134, 20);
            this.checkBoxAdv10.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBoxAdv10.TabIndex = 10;
            this.checkBoxAdv10.Text = "Center Vertical";
            this.checkBoxAdv10.ThemesEnabled = false;
            this.checkBoxAdv10.CheckStateChanged += new System.EventHandler(this.checkBoxAdv10_CheckStateChanged);
            // 
            // button3
            // 
            this.button3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.button3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(182, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Print Preview";
            this.button3.UseVisualStyle = true;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.xpTaskBar1);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 488);
            this.panel1.TabIndex = 1;
            // 
            // gridControl1
            // 
            gridBaseStyle1.Name = "Row Header";
            gridBaseStyle1.StyleInfo.BaseStyle = "Header";
            gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.SystemColors.Window, System.Drawing.Color.Lavender);
            gridBaseStyle2.Name = "Column Header";
            gridBaseStyle2.StyleInfo.BaseStyle = "Header";
            gridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.SystemColors.Window, System.Drawing.Color.Lavender);
            gridBaseStyle3.Name = "Standard";
            gridBaseStyle3.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle4.Name = "Header";
            gridBaseStyle4.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle4.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle4.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle4.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle4.StyleInfo.CellType = "Header";
            gridBaseStyle4.StyleInfo.Font.Bold = true;
            gridBaseStyle4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathEllipse, System.Drawing.SystemColors.Window, System.Drawing.Color.Lavender);
            gridBaseStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.gridControl1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.DefaultRowHeight = 20;
            this.gridControl1.Font = new System.Drawing.Font("Verdana", 8.5F);
            this.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.Location = new System.Drawing.Point(12, 3);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            gridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle1.StyleInfo.Font.Bold = false;
            gridRangeStyle1.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle1.StyleInfo.Font.Italic = false;
            gridRangeStyle1.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle1.StyleInfo.Font.Strikeout = false;
            gridRangeStyle1.StyleInfo.Font.Underline = false;
            gridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle2.StyleInfo.Font.Bold = false;
            gridRangeStyle2.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle2.StyleInfo.Font.Italic = false;
            gridRangeStyle2.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle2.StyleInfo.Font.Strikeout = false;
            gridRangeStyle2.StyleInfo.Font.Underline = false;
            gridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle3.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle3.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle3.StyleInfo.Font.Bold = false;
            gridRangeStyle3.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle3.StyleInfo.Font.Italic = false;
            gridRangeStyle3.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle3.StyleInfo.Font.Strikeout = false;
            gridRangeStyle3.StyleInfo.Font.Underline = false;
            gridRangeStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle3.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle4.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle4.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle4.StyleInfo.Font.Bold = false;
            gridRangeStyle4.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle4.StyleInfo.Font.Italic = false;
            gridRangeStyle4.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle4.StyleInfo.Font.Strikeout = false;
            gridRangeStyle4.StyleInfo.Font.Underline = false;
            gridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle4.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle5.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle5.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle5.StyleInfo.Font.Bold = false;
            gridRangeStyle5.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle5.StyleInfo.Font.Italic = false;
            gridRangeStyle5.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle5.StyleInfo.Font.Strikeout = false;
            gridRangeStyle5.StyleInfo.Font.Underline = false;
            gridRangeStyle5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle5.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle5.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle6.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle6.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle6.StyleInfo.Font.Bold = false;
            gridRangeStyle6.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle6.StyleInfo.Font.Italic = false;
            gridRangeStyle6.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle6.StyleInfo.Font.Strikeout = false;
            gridRangeStyle6.StyleInfo.Font.Underline = false;
            gridRangeStyle6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle6.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle6.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle7.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle7.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle7.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle7.StyleInfo.Font.Bold = false;
            gridRangeStyle7.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle7.StyleInfo.Font.Italic = false;
            gridRangeStyle7.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle7.StyleInfo.Font.Strikeout = false;
            gridRangeStyle7.StyleInfo.Font.Underline = false;
            gridRangeStyle7.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle7.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle7.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle8.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle8.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle8.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle8.StyleInfo.Font.Bold = false;
            gridRangeStyle8.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle8.StyleInfo.Font.Italic = false;
            gridRangeStyle8.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle8.StyleInfo.Font.Strikeout = false;
            gridRangeStyle8.StyleInfo.Font.Underline = false;
            gridRangeStyle8.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle8.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle8.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle9.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle9.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle9.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle9.StyleInfo.Font.Bold = false;
            gridRangeStyle9.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle9.StyleInfo.Font.Italic = false;
            gridRangeStyle9.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle9.StyleInfo.Font.Strikeout = false;
            gridRangeStyle9.StyleInfo.Font.Underline = false;
            gridRangeStyle9.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle9.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle9.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle10.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle10.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle10.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle10.StyleInfo.Font.Bold = false;
            gridRangeStyle10.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle10.StyleInfo.Font.Italic = false;
            gridRangeStyle10.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle10.StyleInfo.Font.Strikeout = false;
            gridRangeStyle10.StyleInfo.Font.Underline = false;
            gridRangeStyle10.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle10.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle10.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle11.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle11.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle11.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle11.StyleInfo.Font.Bold = false;
            gridRangeStyle11.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle11.StyleInfo.Font.Italic = false;
            gridRangeStyle11.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle11.StyleInfo.Font.Strikeout = false;
            gridRangeStyle11.StyleInfo.Font.Underline = false;
            gridRangeStyle11.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle11.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle11.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle12.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle12.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle12.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle12.StyleInfo.Font.Bold = false;
            gridRangeStyle12.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle12.StyleInfo.Font.Italic = false;
            gridRangeStyle12.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle12.StyleInfo.Font.Strikeout = false;
            gridRangeStyle12.StyleInfo.Font.Underline = false;
            gridRangeStyle12.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle12.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle12.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle13.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle13.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle13.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle13.StyleInfo.Font.Bold = false;
            gridRangeStyle13.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle13.StyleInfo.Font.Italic = false;
            gridRangeStyle13.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle13.StyleInfo.Font.Strikeout = false;
            gridRangeStyle13.StyleInfo.Font.Underline = false;
            gridRangeStyle13.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle13.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle13.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle14.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle14.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle14.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle14.StyleInfo.Font.Bold = false;
            gridRangeStyle14.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle14.StyleInfo.Font.Italic = false;
            gridRangeStyle14.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle14.StyleInfo.Font.Strikeout = false;
            gridRangeStyle14.StyleInfo.Font.Underline = false;
            gridRangeStyle14.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle14.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle14.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle15.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle15.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle15.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle15.StyleInfo.Font.Bold = false;
            gridRangeStyle15.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle15.StyleInfo.Font.Italic = false;
            gridRangeStyle15.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle15.StyleInfo.Font.Strikeout = false;
            gridRangeStyle15.StyleInfo.Font.Underline = false;
            gridRangeStyle15.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle15.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle15.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle16.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle16.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle16.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle16.StyleInfo.Font.Bold = false;
            gridRangeStyle16.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle16.StyleInfo.Font.Italic = false;
            gridRangeStyle16.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle16.StyleInfo.Font.Strikeout = false;
            gridRangeStyle16.StyleInfo.Font.Underline = false;
            gridRangeStyle16.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle16.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle16.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle17.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle17.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle17.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle17.StyleInfo.Font.Bold = false;
            gridRangeStyle17.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle17.StyleInfo.Font.Italic = false;
            gridRangeStyle17.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle17.StyleInfo.Font.Strikeout = false;
            gridRangeStyle17.StyleInfo.Font.Underline = false;
            gridRangeStyle17.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle17.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle17.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle18.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle18.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle18.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle18.StyleInfo.Font.Bold = false;
            gridRangeStyle18.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle18.StyleInfo.Font.Italic = false;
            gridRangeStyle18.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle18.StyleInfo.Font.Strikeout = false;
            gridRangeStyle18.StyleInfo.Font.Underline = false;
            gridRangeStyle18.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle18.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle18.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle19.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle19.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle19.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle19.StyleInfo.Font.Bold = false;
            gridRangeStyle19.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle19.StyleInfo.Font.Italic = false;
            gridRangeStyle19.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle19.StyleInfo.Font.Strikeout = false;
            gridRangeStyle19.StyleInfo.Font.Underline = false;
            gridRangeStyle19.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle19.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle19.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle20.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle20.StyleInfo.Font.Bold = false;
            gridRangeStyle20.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle20.StyleInfo.Font.Italic = false;
            gridRangeStyle20.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle20.StyleInfo.Font.Strikeout = false;
            gridRangeStyle20.StyleInfo.Font.Underline = false;
            gridRangeStyle20.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle21.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle21.StyleInfo.Font.Bold = false;
            gridRangeStyle21.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle21.StyleInfo.Font.Italic = false;
            gridRangeStyle21.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle21.StyleInfo.Font.Strikeout = false;
            gridRangeStyle21.StyleInfo.Font.Underline = false;
            gridRangeStyle21.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle22.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle22.StyleInfo.Font.Bold = false;
            gridRangeStyle22.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle22.StyleInfo.Font.Italic = false;
            gridRangeStyle22.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle22.StyleInfo.Font.Strikeout = false;
            gridRangeStyle22.StyleInfo.Font.Underline = false;
            gridRangeStyle22.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle23.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle23.StyleInfo.Font.Bold = false;
            gridRangeStyle23.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle23.StyleInfo.Font.Italic = false;
            gridRangeStyle23.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle23.StyleInfo.Font.Strikeout = false;
            gridRangeStyle23.StyleInfo.Font.Underline = false;
            gridRangeStyle23.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle24.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle24.StyleInfo.Font.Bold = false;
            gridRangeStyle24.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle24.StyleInfo.Font.Italic = false;
            gridRangeStyle24.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle24.StyleInfo.Font.Strikeout = false;
            gridRangeStyle24.StyleInfo.Font.Underline = false;
            gridRangeStyle24.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle25.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle25.StyleInfo.Font.Bold = false;
            gridRangeStyle25.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle25.StyleInfo.Font.Italic = false;
            gridRangeStyle25.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle25.StyleInfo.Font.Strikeout = false;
            gridRangeStyle25.StyleInfo.Font.Underline = false;
            gridRangeStyle25.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle26.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle26.StyleInfo.Font.Bold = false;
            gridRangeStyle26.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle26.StyleInfo.Font.Italic = false;
            gridRangeStyle26.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle26.StyleInfo.Font.Strikeout = false;
            gridRangeStyle26.StyleInfo.Font.Underline = false;
            gridRangeStyle26.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle27.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle27.StyleInfo.Font.Bold = false;
            gridRangeStyle27.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle27.StyleInfo.Font.Italic = false;
            gridRangeStyle27.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle27.StyleInfo.Font.Strikeout = false;
            gridRangeStyle27.StyleInfo.Font.Underline = false;
            gridRangeStyle27.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle28.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle28.StyleInfo.Font.Bold = false;
            gridRangeStyle28.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle28.StyleInfo.Font.Italic = false;
            gridRangeStyle28.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle28.StyleInfo.Font.Strikeout = false;
            gridRangeStyle28.StyleInfo.Font.Underline = false;
            gridRangeStyle28.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle29.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle29.StyleInfo.Font.Bold = false;
            gridRangeStyle29.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle29.StyleInfo.Font.Italic = false;
            gridRangeStyle29.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle29.StyleInfo.Font.Strikeout = false;
            gridRangeStyle29.StyleInfo.Font.Underline = false;
            gridRangeStyle29.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle30.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle30.StyleInfo.Font.Bold = false;
            gridRangeStyle30.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle30.StyleInfo.Font.Italic = false;
            gridRangeStyle30.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle30.StyleInfo.Font.Strikeout = false;
            gridRangeStyle30.StyleInfo.Font.Underline = false;
            gridRangeStyle30.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle31.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle31.StyleInfo.Font.Bold = false;
            gridRangeStyle31.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle31.StyleInfo.Font.Italic = false;
            gridRangeStyle31.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle31.StyleInfo.Font.Strikeout = false;
            gridRangeStyle31.StyleInfo.Font.Underline = false;
            gridRangeStyle31.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle32.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle32.StyleInfo.Font.Bold = false;
            gridRangeStyle32.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle32.StyleInfo.Font.Italic = false;
            gridRangeStyle32.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle32.StyleInfo.Font.Strikeout = false;
            gridRangeStyle32.StyleInfo.Font.Underline = false;
            gridRangeStyle32.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            this.gridControl1.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
            gridRangeStyle1,
            gridRangeStyle2,
            gridRangeStyle3,
            gridRangeStyle4,
            gridRangeStyle5,
            gridRangeStyle6,
            gridRangeStyle7,
            gridRangeStyle8,
            gridRangeStyle9,
            gridRangeStyle10,
            gridRangeStyle11,
            gridRangeStyle12,
            gridRangeStyle13,
            gridRangeStyle14,
            gridRangeStyle15,
            gridRangeStyle16,
            gridRangeStyle17,
            gridRangeStyle18,
            gridRangeStyle19,
            gridRangeStyle20,
            gridRangeStyle21,
            gridRangeStyle22,
            gridRangeStyle23,
            gridRangeStyle24,
            gridRangeStyle25,
            gridRangeStyle26,
            gridRangeStyle27,
            gridRangeStyle28,
            gridRangeStyle29,
            gridRangeStyle30,
            gridRangeStyle31,
            gridRangeStyle32});
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowCount = 25;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(606, 481);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.TransparentBackground = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1024, 510);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grid Properties Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).EndInit();
            this.xpTaskBar1.ResumeLayout(false);
            this.xpTaskBarBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            this.xpTaskBarBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv10)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

    		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
        }
        #endregion

		#region Appearance Properties

		


        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //Enable or Disable the Grid
            if (this.checkBoxAdv5.Checked)
            {
                this.gridControl1.Enabled = true;
            }
            else
            {
                this.gridControl1.ShowDisabledGridAsGray = true;
                this.gridControl1.Enabled = false;
            }
        }

        private string FindImageFile(string bitmapName)
        {
            string bitmappath = "";
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    bitmappath = bitmapName;

                bitmapName = @"..\" + bitmapName;
            }
            return bitmappath;
        }

		string imageFileName = null;
		private void button1_Click(object sender, System.EventArgs e)
		{
			//Browse an image for grid background
			FileDialog dlg = new OpenFileDialog();
			dlg.Filter = "Bitmap files (*.bmp)|*.bmp|Jpeg Files (*.jpg)|*.jpg | All files (*.*)|*.*";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				this.checkBoxAdv7.Enabled = true;
				this.imageFileName = dlg.FileName;
				this.gridControl1.BackgroundImage = Image.FromFile(this.imageFileName);
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			//Remove background image
			this.gridControl1.BackgroundImage = null;
		}
		void colorPickerButton6_ColorSelected(object sender, EventArgs e)
		{
			//set grid textcolor
			this.gridControl1.TableStyle.TextColor = this.colorPickerButton6.SelectedColor;
		}
		void colorPickerButton5_ColorSelected(object sender, EventArgs e)
		{
			//set resizing cells linecolor
			this.gridControl1.Properties.ResizingCellsLinesColor = this.colorPickerButton5.SelectedColor;
		}

		void colorPickerButton4_ColorSelected(object sender, EventArgs e)
		{
			//set grid linecolor
            if (checkBoxAdv4.Checked)
            {
                this.gridControl1.TableStyle.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, this.colorPickerButton4.SelectedColor);
                this.gridControl1.TableStyle.Borders.Top = new GridBorder(GridBorderStyle.Solid, this.colorPickerButton4.SelectedColor);
                temp1 = true;
            }
            if (checkBoxAdv4.Checked)
            {
                this.gridControl1.TableStyle.Borders.Left = new GridBorder(GridBorderStyle.Solid, this.colorPickerButton4.SelectedColor);
                this.gridControl1.TableStyle.Borders.Right = new GridBorder(GridBorderStyle.Solid, this.colorPickerButton4.SelectedColor);
                temp2 = true;
            }
		}

		void colorPickerButton3_ColorSelected(object sender, EventArgs e)
		{
			//set fixed lines color
			this.gridControl1.Properties.FixedLinesColor = this.colorPickerButton3.SelectedColor;
			this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;
		}

		void colorPickerButton2_ColorSelected(object sender, EventArgs e)
		{
			//set grid background color
            this.gridControl1.BackColor = this.colorPickerButton2.SelectedColor;
		}

		void colorPickerButton1_ColorSelected(object sender, EventArgs e)
		{
			//set grid back color
			this.gridControl1.BackColor = this.colorPickerButton1.SelectedColor;
		}

		
		void gridControl1_QueryCellInfo(object sender, Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventArgs e)
		{
			if (e.RowIndex > 0 && e.ColIndex > 0)
				e.Style.Text = string.Format("Row{0}:Col{0}", e.RowIndex, e.ColIndex);
		}
		#endregion

		#region Printer related properties
		

		private void button3_Click(object sender, System.EventArgs e)
		{
			//Print Preview
			try
			{
				GridPrintDocument pd = new GridPrintDocument(this.gridControl1, true);
				PrintPreviewDialog dlg = new PrintPreviewDialog();
				dlg.Document = pd;
				dlg.ShowDialog();
			}
			catch (Exception excep)
			{
				MessageBox.Show("Error :" + excep.Message);
			}
		}
		#endregion
        
        #region Event Handlers

        private void Form1_Load(object sender, System.EventArgs e)
        {
            gridControl1.Model.BaseStylesMap["Header"].StyleInfo.Font.Bold = true;
            gridControl1.Model.Cols.FreezeRange(1, 1);
            this.gridControl1.QueryCellInfo += new Syncfusion.Windows.Forms.Grid.GridQueryCellInfoEventHandler(gridControl1_QueryCellInfo);
            this.colorPickerButton1.ColorSelected += new EventHandler(colorPickerButton1_ColorSelected);
            this.colorPickerButton2.ColorSelected += new EventHandler(colorPickerButton2_ColorSelected);
            this.colorPickerButton3.ColorSelected += new EventHandler(colorPickerButton3_ColorSelected);
            this.colorPickerButton4.ColorSelected += new EventHandler(colorPickerButton4_ColorSelected);
            this.colorPickerButton5.ColorSelected += new EventHandler(colorPickerButton5_ColorSelected);
            this.colorPickerButton6.ColorSelected += new EventHandler(colorPickerButton6_ColorSelected);
        }

        private void xpTaskBarBox2_ItemClick(object sender, XPTaskBarItemClickArgs e)
        {

        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            if (this.gridControl1.NumberedRowHeaders)
                this.gridControl1.NumberedRowHeaders = false;
            else
                this.gridControl1.NumberedRowHeaders = true;
            if (this.gridControl1.NumberedColHeaders)
                this.gridControl1.NumberedColHeaders = false;
            else
                this.gridControl1.NumberedColHeaders = true;
        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            //Enable or disable the disply of Column Headers
            if (this.checkBoxAdv1.Checked)
                this.gridControl1.Properties.ColHeaders = true;
            else
                this.gridControl1.Properties.ColHeaders = false;
        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            //Enable or disable the disply of Row Headers
            if (this.checkBoxAdv2.Checked)
                this.gridControl1.Properties.RowHeaders = true;
            else
                this.gridControl1.Properties.RowHeaders = false;
        }

        private void checkBoxAdv3_CheckStateChanged(object sender, EventArgs e)
        {

            //Enable or disable the disply of horizontal grid lines
            if (this.checkBoxAdv3.Checked)
            {
                this.gridControl1.Properties.DisplayHorzLines = true;
                if (temp1)
                {
                    this.gridControl1.TableStyle.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, this.colorPickerButton4.SelectedColor);
                    this.gridControl1.TableStyle.Borders.Top = new GridBorder(GridBorderStyle.Solid, this.colorPickerButton4.SelectedColor);
                }
            }
            else
            {
                this.gridControl1.Properties.DisplayHorzLines = false;
                if (temp1)
                {
                    this.gridControl1.TableStyle.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.Transparent);
                    this.gridControl1.TableStyle.Borders.Top = new GridBorder(GridBorderStyle.Solid, Color.Transparent);
                }
            }
        }

        private void checkBoxAdv4_CheckStateChanged(object sender, EventArgs e)
        {

            //Enable or disable the display of vertical grid lines
            if (this.checkBoxAdv4.Checked)
            {
                this.gridControl1.Properties.DisplayVertLines = true;
                if (temp2)
                {
                    this.gridControl1.TableStyle.Borders.Right = new GridBorder(GridBorderStyle.Solid, this.colorPickerButton4.SelectedColor);
                    this.gridControl1.TableStyle.Borders.Left = new GridBorder(GridBorderStyle.Solid, this.colorPickerButton4.SelectedColor);
                }
            }
            else
            {
                this.gridControl1.Properties.DisplayVertLines = false;
                if (temp2)
                {
                    this.gridControl1.TableStyle.Borders.Right = new GridBorder(GridBorderStyle.Solid, Color.Transparent);
                    this.gridControl1.TableStyle.Borders.Left = new GridBorder(GridBorderStyle.Solid, Color.Transparent);
                }
            }
        }

        private void checkBoxAdv5_CheckStateChanged(object sender, EventArgs e)
        {

            //Enable or Disable the Grid
            if (this.checkBoxAdv5.Checked)
            {
                this.gridControl1.Enabled = true;
            }
            else
            {
                this.gridControl1.ShowDisabledGridAsGray = true;
                this.gridControl1.Enabled = false;
            }
        }

        private void checkBoxAdv7_CheckStateChanged(object sender, EventArgs e)
        {
            //Enable or disable transparent background
            if (this.checkBoxAdv7.Checked)
            {
                this.gridControl1.TransparentBackground = false;
                //Specify background image
                this.gridControl1.BackgroundImage = Image.FromFile(FindImageFile(@"common\Images\Grid\GridProperties\pic.jpg"));
                this.colorPickerButton1.Enabled = true;
                this.button1.Enabled = true;
            }
            else
            {
                this.colorPickerButton1.Enabled = false;
                this.button1.Enabled = false;
                this.gridControl1.TransparentBackground = true;
                this.gridControl1.BackgroundImage = null;
            }
        }

        private void checkBoxAdv8_CheckStateChanged(object sender, EventArgs e)
        {
            //Specify if row/col headers should appear raised or flat
            if (this.checkBoxAdv8.Checked)
                this.gridControl1.Properties.Buttons3D = true;
            else
                this.gridControl1.Properties.Buttons3D = false;
        }

        private void checkBoxAdv9_CheckStateChanged(object sender, EventArgs e)
        {
            //Specify if the grid should be centered horizontally on printing
            if (this.checkBoxAdv9.Checked)
                this.gridControl1.Properties.CenterHorizontal = true;
            else
                this.gridControl1.Properties.CenterHorizontal = false;
        }

        private void checkBoxAdv10_CheckStateChanged(object sender, EventArgs e)
        {

            //Specify if the grid should be centered vertically on printing
            if (this.checkBoxAdv10.Checked)
                this.gridControl1.Properties.CenterVertical = true;
            else
                this.gridControl1.Properties.CenterVertical = false;
        }

        private void checkBoxAdv11_CheckStateChanged(object sender, EventArgs e)
        {
            //Specify if column headers should be printed 
            if (this.checkBoxAdv11.Checked)
                this.gridControl1.Properties.PrintColHeader = true;
            else
                this.gridControl1.Properties.PrintColHeader = false;
        }

        private void checkBoxAdv12_CheckStateChanged(object sender, EventArgs e)
        {
            //Specify if row headers should be printed
            if (this.checkBoxAdv12.Checked)
                this.gridControl1.Properties.PrintRowHeader = true;
            else
                this.gridControl1.Properties.PrintRowHeader = false;
        }

        private void checkBoxAdv13_CheckStateChanged(object sender, EventArgs e)
        {
            //Specify if grid horizontal lines should be printed
            if (this.checkBoxAdv13.Checked)
                this.gridControl1.Properties.PrintHorzLines = true;
            else
                this.gridControl1.Properties.PrintHorzLines = false;
        }

        private void checkBoxAdv14_CheckStateChanged(object sender, EventArgs e)
        {
            //Specify if grid vertical lines should be printed
            if (this.checkBoxAdv14.Checked)
                this.gridControl1.Properties.PrintVertLines = true;
            else
                this.gridControl1.Properties.PrintVertLines = false;
        }

        private void checkBoxAdv15_CheckStateChanged(object sender, EventArgs e)
        {
            //Specify if a frame should be drawn around the grid when printing
            if (this.checkBoxAdv15.Checked)
                this.gridControl1.Properties.PrintFrame = true;
            else
                this.gridControl1.Properties.PrintFrame = false;
        }

        private void checkBoxAdv16_CheckStateChanged(object sender, EventArgs e)
        {
            //Specify if the grid should be printed only in black and white
            if (this.checkBoxAdv16.Checked)
                this.gridControl1.Properties.BlackWhite = true;
            else
                this.gridControl1.Properties.BlackWhite = false;
        }

        private void checkBoxAdv17_CheckStateChanged(object sender, EventArgs e)
        {
            //Switch print mode
            if (this.checkBoxAdv17.Checked)
                this.gridControl1.Properties.Printing = true;
            else
                this.gridControl1.Properties.Printing = false;
        }

        #endregion


    }
}
