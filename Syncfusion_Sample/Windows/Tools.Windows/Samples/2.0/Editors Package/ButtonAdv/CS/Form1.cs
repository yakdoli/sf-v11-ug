#region Copyright Syncfusion Inc. 2001 - 2013
//
//  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Windows.Forms;

namespace ButtonAdvDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : Office2007Form
    {
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv5;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv6;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv7;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv8;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv9;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv10;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv11;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv12;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv13;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv14;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.IContainer components;        
        private System.Windows.Forms.Label label5;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel3;
        private ButtonAdv buttonAdv18;
        private ButtonAdv buttonAdv17;
        private ButtonAdv buttonAdv16;
        private ButtonAdv buttonAdv15;
        private ButtonAdv buttonAdv4;
        private ButtonAdv buttonAdv1;
        private Label label1;
        private ButtonAdv buttonAdv22;
        private ButtonAdv buttonAdv21;
        private ButtonAdv buttonAdv20;
        private ButtonAdv buttonAdv19;
        private ButtonAdv buttonAdv24;
        private ButtonAdv buttonAdv23;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private ButtonAdv buttonAdv25;        

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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv14 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv13 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv12 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv11 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv10 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv9 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv8 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv7 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv6 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv5 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.buttonAdv24 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv23 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.buttonAdv22 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv20 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv19 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdv18 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv21 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv17 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv16 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv15 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv4 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAdv25 = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv2.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv2.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv2.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Calculator;
            this.buttonAdv2.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv2.KeepFocusRectangle = false;
            this.buttonAdv2.Location = new System.Drawing.Point(8, 33);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(48, 37);
            this.buttonAdv2.TabIndex = 2;
            this.buttonAdv2.Text = "buttonAdv2";
            this.buttonAdv2.UseVisualStyle = true;
            // 
            // buttonAdv14
            // 
            this.buttonAdv14.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv14.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv14.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv14.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.RightEnd;
            this.buttonAdv14.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv14.KeepFocusRectangle = false;
            this.buttonAdv14.Location = new System.Drawing.Point(232, 73);
            this.buttonAdv14.Name = "buttonAdv14";
            this.buttonAdv14.Size = new System.Drawing.Size(48, 37);
            this.buttonAdv14.TabIndex = 14;
            this.buttonAdv14.Text = "buttonAdv14";
            this.buttonAdv14.UseVisualStyle = true;
            // 
            // buttonAdv13
            // 
            this.buttonAdv13.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv13.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv13.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv13.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.LeftEnd;
            this.buttonAdv13.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv13.KeepFocusRectangle = false;
            this.buttonAdv13.Location = new System.Drawing.Point(176, 73);
            this.buttonAdv13.Name = "buttonAdv13";
            this.buttonAdv13.Size = new System.Drawing.Size(48, 37);
            this.buttonAdv13.TabIndex = 13;
            this.buttonAdv13.Text = "buttonAdv13";
            this.buttonAdv13.UseVisualStyle = true;
            // 
            // buttonAdv12
            // 
            this.buttonAdv12.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv12.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv12.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv12.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.buttonAdv12.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv12.KeepFocusRectangle = false;
            this.buttonAdv12.Location = new System.Drawing.Point(289, 73);
            this.buttonAdv12.Name = "buttonAdv12";
            this.buttonAdv12.Size = new System.Drawing.Size(48, 37);
            this.buttonAdv12.TabIndex = 12;
            this.buttonAdv12.Text = "buttonAdv12";
            this.buttonAdv12.UseVisualStyle = true;
            // 
            // buttonAdv11
            // 
            this.buttonAdv11.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv11.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv11.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv11.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Check;
            this.buttonAdv11.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv11.KeepFocusRectangle = false;
            this.buttonAdv11.Location = new System.Drawing.Point(288, 33);
            this.buttonAdv11.Name = "buttonAdv11";
            this.buttonAdv11.Size = new System.Drawing.Size(48, 37);
            this.buttonAdv11.TabIndex = 11;
            this.buttonAdv11.Text = "buttonAdv11";
            this.buttonAdv11.UseVisualStyle = true;
            // 
            // buttonAdv10
            // 
            this.buttonAdv10.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv10.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv10.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv10.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Undo;
            this.buttonAdv10.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv10.KeepFocusRectangle = false;
            this.buttonAdv10.Location = new System.Drawing.Point(64, 33);
            this.buttonAdv10.Name = "buttonAdv10";
            this.buttonAdv10.Size = new System.Drawing.Size(48, 37);
            this.buttonAdv10.TabIndex = 10;
            this.buttonAdv10.Text = "buttonAdv10";
            this.buttonAdv10.UseVisualStyle = true;
            // 
            // buttonAdv9
            // 
            this.buttonAdv9.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv9.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv9.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv9.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Redo;
            this.buttonAdv9.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv9.KeepFocusRectangle = false;
            this.buttonAdv9.Location = new System.Drawing.Point(64, 73);
            this.buttonAdv9.Name = "buttonAdv9";
            this.buttonAdv9.Size = new System.Drawing.Size(48, 37);
            this.buttonAdv9.TabIndex = 9;
            this.buttonAdv9.Text = "buttonAdv9";
            this.buttonAdv9.UseVisualStyle = true;
            // 
            // buttonAdv8
            // 
            this.buttonAdv8.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv8.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv8.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv8.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Right;
            this.buttonAdv8.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv8.KeepFocusRectangle = false;
            this.buttonAdv8.Location = new System.Drawing.Point(232, 33);
            this.buttonAdv8.Name = "buttonAdv8";
            this.buttonAdv8.Size = new System.Drawing.Size(48, 37);
            this.buttonAdv8.TabIndex = 8;
            this.buttonAdv8.Text = "buttonAdv8";
            this.buttonAdv8.UseVisualStyle = true;
            // 
            // buttonAdv7
            // 
            this.buttonAdv7.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv7.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv7.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv7.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Left;
            this.buttonAdv7.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv7.KeepFocusRectangle = false;
            this.buttonAdv7.Location = new System.Drawing.Point(176, 33);
            this.buttonAdv7.Name = "buttonAdv7";
            this.buttonAdv7.Size = new System.Drawing.Size(48, 37);
            this.buttonAdv7.TabIndex = 7;
            this.buttonAdv7.Text = "buttonAdv7";
            this.buttonAdv7.UseVisualStyle = true;
            // 
            // buttonAdv6
            // 
            this.buttonAdv6.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv6.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv6.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv6.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Up;
            this.buttonAdv6.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv6.KeepFocusRectangle = false;
            this.buttonAdv6.Location = new System.Drawing.Point(120, 33);
            this.buttonAdv6.Name = "buttonAdv6";
            this.buttonAdv6.Size = new System.Drawing.Size(48, 37);
            this.buttonAdv6.TabIndex = 6;
            this.buttonAdv6.Text = "buttonAdv6";
            this.buttonAdv6.UseVisualStyle = true;
            // 
            // buttonAdv5
            // 
            this.buttonAdv5.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv5.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv5.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv5.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Down;
            this.buttonAdv5.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv5.KeepFocusRectangle = false;
            this.buttonAdv5.Location = new System.Drawing.Point(120, 73);
            this.buttonAdv5.Name = "buttonAdv5";
            this.buttonAdv5.Size = new System.Drawing.Size(48, 37);
            this.buttonAdv5.TabIndex = 5;
            this.buttonAdv5.Text = "buttonAdv5";
            this.buttonAdv5.UseVisualStyle = true;
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv3.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv3.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv3.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Currency;
            this.buttonAdv3.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv3.KeepFocusRectangle = false;
            this.buttonAdv3.Location = new System.Drawing.Point(8, 73);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(48, 37);
            this.buttonAdv3.TabIndex = 3;
            this.buttonAdv3.Text = "buttonAdv3";
            this.buttonAdv3.UseVisualStyle = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(254))))), System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(254))))));
            this.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(215)))), ((int)(((byte)(252)))));
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.Controls.Add(this.buttonAdv24);
            this.gradientPanel3.Controls.Add(this.buttonAdv23);
            this.gradientPanel3.Controls.Add(this.gradientPanel1);
            this.gradientPanel3.Controls.Add(this.buttonAdv17);
            this.gradientPanel3.Controls.Add(this.buttonAdv16);
            this.gradientPanel3.Controls.Add(this.buttonAdv15);
            this.gradientPanel3.Controls.Add(this.buttonAdv4);
            this.gradientPanel3.Controls.Add(this.buttonAdv1);
            this.gradientPanel3.Location = new System.Drawing.Point(12, 160);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(456, 223);
            this.gradientPanel3.TabIndex = 37;
            // 
            // buttonAdv24
            // 
            this.buttonAdv24.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.WindowsXP;
            this.buttonAdv24.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAdv24.KeepFocusRectangle = false;
            this.buttonAdv24.Location = new System.Drawing.Point(89, 159);
            this.buttonAdv24.Name = "buttonAdv24";
            this.buttonAdv24.Size = new System.Drawing.Size(75, 23);
            this.buttonAdv24.TabIndex = 39;
            this.buttonAdv24.Text = "&Cancel";
            // 
            // buttonAdv23
            // 
            this.buttonAdv23.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.WindowsXP;
            this.buttonAdv23.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAdv23.KeepFocusRectangle = false;
            this.buttonAdv23.Location = new System.Drawing.Point(8, 159);
            this.buttonAdv23.Name = "buttonAdv23";
            this.buttonAdv23.Size = new System.Drawing.Size(75, 23);
            this.buttonAdv23.TabIndex = 38;
            this.buttonAdv23.Text = "&OK";
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(254))))));
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(159)))), ((int)(((byte)(69)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.buttonAdv25);
            this.gradientPanel1.Controls.Add(this.buttonAdv22);
            this.gradientPanel1.Controls.Add(this.buttonAdv20);
            this.gradientPanel1.Controls.Add(this.buttonAdv19);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.buttonAdv18);
            this.gradientPanel1.Controls.Add(this.buttonAdv21);
            this.gradientPanel1.Location = new System.Drawing.Point(188, 81);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(253, 128);
            this.gradientPanel1.TabIndex = 37;
            // 
            // buttonAdv22
            // 
            this.buttonAdv22.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2003;
            this.buttonAdv22.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv22.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv22.KeepFocusRectangle = false;
            this.buttonAdv22.Location = new System.Drawing.Point(121, 30);
            this.buttonAdv22.Name = "buttonAdv22";
            this.buttonAdv22.Size = new System.Drawing.Size(110, 24);
            this.buttonAdv22.TabIndex = 22;
            this.buttonAdv22.Text = "Office 2003";
            this.buttonAdv22.UseVisualStyle = true;
            // 
            // buttonAdv20
            // 
            this.buttonAdv20.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv20.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv20.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv20.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv20.KeepFocusRectangle = false;
            this.buttonAdv20.Location = new System.Drawing.Point(12, 60);
            this.buttonAdv20.Name = "buttonAdv20";
            this.buttonAdv20.Size = new System.Drawing.Size(102, 24);
            this.buttonAdv20.TabIndex = 20;
            this.buttonAdv20.Text = "Office 2007 Blue";
            this.buttonAdv20.UseVisualStyle = true;
            // 
            // buttonAdv19
            // 
            this.buttonAdv19.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv19.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv19.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv19.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv19.ForeColor = System.Drawing.Color.White;
            this.buttonAdv19.KeepFocusRectangle = false;
            this.buttonAdv19.Location = new System.Drawing.Point(120, 60);
            this.buttonAdv19.Name = "buttonAdv19";
            this.buttonAdv19.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonAdv19.Size = new System.Drawing.Size(110, 24);
            this.buttonAdv19.TabIndex = 19;
            this.buttonAdv19.Text = "Office 2007 Black";
            this.buttonAdv19.UseVisualStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 14);
            this.label1.TabIndex = 36;
            this.label1.Text = "Styles";
            // 
            // buttonAdv18
            // 
            this.buttonAdv18.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv18.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv18.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv18.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv18.KeepFocusRectangle = false;
            this.buttonAdv18.Location = new System.Drawing.Point(12, 92);
            this.buttonAdv18.Name = "buttonAdv18";
            this.buttonAdv18.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.buttonAdv18.Size = new System.Drawing.Size(103, 26);
            this.buttonAdv18.TabIndex = 18;
            this.buttonAdv18.Text = "Office 2007 Silver";
            this.buttonAdv18.UseVisualStyle = true;
            // 
            // buttonAdv21
            // 
            this.buttonAdv21.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2000;
            this.buttonAdv21.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv21.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv21.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv21.KeepFocusRectangle = false;
            this.buttonAdv21.Location = new System.Drawing.Point(12, 30);
            this.buttonAdv21.Name = "buttonAdv21";
            this.buttonAdv21.Size = new System.Drawing.Size(103, 24);
            this.buttonAdv21.TabIndex = 21;
            this.buttonAdv21.Text = "Office XP";
            this.buttonAdv21.UseVisualStyle = true;
            // 
            // buttonAdv17
            // 
            this.buttonAdv17.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv17.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv17.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv17.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv17.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv17.Image")));
            this.buttonAdv17.KeepFocusRectangle = false;
            this.buttonAdv17.Location = new System.Drawing.Point(152, 81);
            this.buttonAdv17.Name = "buttonAdv17";
            this.buttonAdv17.Size = new System.Drawing.Size(30, 28);
            this.buttonAdv17.TabIndex = 17;
            this.buttonAdv17.UseVisualStyle = true;
            // 
            // buttonAdv16
            // 
            this.buttonAdv16.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv16.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv16.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv16.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv16.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv16.Image")));
            this.buttonAdv16.KeepFocusRectangle = false;
            this.buttonAdv16.Location = new System.Drawing.Point(119, 81);
            this.buttonAdv16.Name = "buttonAdv16";
            this.buttonAdv16.Size = new System.Drawing.Size(30, 28);
            this.buttonAdv16.TabIndex = 16;
            this.buttonAdv16.UseVisualStyle = true;
            // 
            // buttonAdv15
            // 
            this.buttonAdv15.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv15.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv15.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv15.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv15.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv15.Image")));
            this.buttonAdv15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv15.KeepFocusRectangle = false;
            this.buttonAdv15.Location = new System.Drawing.Point(152, 13);
            this.buttonAdv15.Name = "buttonAdv15";
            this.buttonAdv15.Size = new System.Drawing.Size(174, 51);
            this.buttonAdv15.TabIndex = 15;
            this.buttonAdv15.Text = "Save a copy of item in one \r\nof the available formats.\r\n";
            this.buttonAdv15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv15.UseVisualStyle = true;
            // 
            // buttonAdv4
            // 
            this.buttonAdv4.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv4.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv4.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv4.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv4.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv4.Image")));
            this.buttonAdv4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAdv4.Location = new System.Drawing.Point(8, 13);
            this.buttonAdv4.Name = "buttonAdv4";
            this.buttonAdv4.Size = new System.Drawing.Size(122, 51);
            this.buttonAdv4.TabIndex = 14;
            this.buttonAdv4.Text = "&New Document";
            this.buttonAdv4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv4.UseVisualStyle = true;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv1.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv1.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv1.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv1.Image")));
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(8, 81);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.buttonAdv1.Size = new System.Drawing.Size(104, 57);
            this.buttonAdv1.TabIndex = 13;
            this.buttonAdv1.Text = "Image above Text";
            this.buttonAdv1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdv1.UseVisualStyle = true;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(254))))), System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(244)))), ((int)(((byte)(254))))));
            this.gradientPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(215)))), ((int)(((byte)(252)))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.buttonAdv6);
            this.gradientPanel2.Controls.Add(this.buttonAdv3);
            this.gradientPanel2.Controls.Add(this.buttonAdv2);
            this.gradientPanel2.Controls.Add(this.buttonAdv5);
            this.gradientPanel2.Controls.Add(this.buttonAdv14);
            this.gradientPanel2.Controls.Add(this.label5);
            this.gradientPanel2.Controls.Add(this.buttonAdv13);
            this.gradientPanel2.Controls.Add(this.buttonAdv7);
            this.gradientPanel2.Controls.Add(this.buttonAdv9);
            this.gradientPanel2.Controls.Add(this.buttonAdv8);
            this.gradientPanel2.Controls.Add(this.buttonAdv11);
            this.gradientPanel2.Controls.Add(this.buttonAdv12);
            this.gradientPanel2.Controls.Add(this.buttonAdv10);
            this.gradientPanel2.Location = new System.Drawing.Point(12, 12);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(456, 126);
            this.gradientPanel2.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 14);
            this.label5.TabIndex = 35;
            this.label5.Text = "Button Types";
            // 
            // buttonAdv25
            // 
            this.buttonAdv25.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv25.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAdv25.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.Dashed;
            this.buttonAdv25.ComboEditBackColor = System.Drawing.Color.Silver;
            this.buttonAdv25.ForeColor = System.Drawing.Color.Black;
            this.buttonAdv25.KeepFocusRectangle = false;
            this.buttonAdv25.Location = new System.Drawing.Point(121, 94);
            this.buttonAdv25.Name = "buttonAdv25";
            this.buttonAdv25.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.buttonAdv25.Size = new System.Drawing.Size(110, 24);
            this.buttonAdv25.TabIndex = 38;
            this.buttonAdv25.Text = "Office2007Managed";
            this.buttonAdv25.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAdv25.UseVisualStyle = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(482, 398);
            this.Controls.Add(this.gradientPanel2);
            this.Controls.Add(this.gradientPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ButtonAdv";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.gradientPanel2.PerformLayout();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ColorScheme = Office2007Theme.Blue;
            Office2007Colors.ApplyManagedColors(this, Color.HotPink);
        }
    }
}
