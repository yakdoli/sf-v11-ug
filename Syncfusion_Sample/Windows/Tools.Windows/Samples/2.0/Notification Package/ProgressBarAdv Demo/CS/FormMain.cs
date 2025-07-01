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
using Syncfusion.Windows.Forms.Tools;

namespace ProgressBarDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FormMain : System.Windows.Forms.Form
	{
		public ProgressBarAdv progressBarAdv1;
		private ProgressBarAdv progressBarAdv3;
		private ProgressBarAdv progressBarAdv4;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private ProgressBarAdv progressBarAdv7;
		private ProgressBarAdv progressBarAdv2;
		private ProgressBarAdv progressBarAdv5;
        private ProgressBarAdv progressBarAdv6;
		private ProgressBarAdv progressBarAdv9;
		private ProgressBarAdv progressBarAdv10;
		private ProgressBarAdv progressBarAdv11;
		private ProgressBarAdv progressBarAdv12;
		private ProgressBarAdv progressBarAdv13;
		private ProgressBarAdv progressBarAdv14;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.GroupBox groupBox1;
        private ProgressBarAdv progressBarWaiting;
		private System.ComponentModel.IContainer components;
	
		public FormMain()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.progressBarAdv1 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv3 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv4 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.progressBarAdv7 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv2 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv5 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv6 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv9 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv10 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv11 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv12 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv13 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.progressBarAdv14 = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.TestButton = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBarWaiting = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv14)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarWaiting)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarAdv1
            // 
            this.progressBarAdv1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarAdv1.BackGradientEndColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBarAdv1.BackGradientStartColor = System.Drawing.SystemColors.ControlDark;
            this.progressBarAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient;
            this.progressBarAdv1.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ControlDark,
        System.Drawing.SystemColors.ControlLightLight,
        System.Drawing.SystemColors.Control};
            this.progressBarAdv1.BackSegments = false;
            this.progressBarAdv1.BackTubeEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBarAdv1.BackTubeStartColor = System.Drawing.Color.Yellow;
            this.progressBarAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this.progressBarAdv1.BorderColor = System.Drawing.Color.Black;
            this.progressBarAdv1.CustomWaitingRender = false;
            this.progressBarAdv1.FontColor = System.Drawing.SystemColors.HighlightText;
            this.progressBarAdv1.ForeColor = System.Drawing.Color.MediumBlue;
            this.progressBarAdv1.ForegroundImage = null;
            this.progressBarAdv1.ForeSegments = false;
            this.progressBarAdv1.GradientEndColor = System.Drawing.Color.Magenta;
            this.progressBarAdv1.GradientStartColor = System.Drawing.Color.Orange;
            this.progressBarAdv1.Location = new System.Drawing.Point(236, 12);
            this.progressBarAdv1.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.DarkRed,
        System.Drawing.Color.Red,
        System.Drawing.Color.Black};
            this.progressBarAdv1.Name = "progressBarAdv1";
            this.progressBarAdv1.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            this.progressBarAdv1.SegmentWidth = 20;
            this.progressBarAdv1.Size = new System.Drawing.Size(240, 23);
            this.progressBarAdv1.StretchImage = false;
            this.progressBarAdv1.StretchMultGrad = false;
            this.progressBarAdv1.TabIndex = 0;
            this.progressBarAdv1.TextShadow = false;
            this.progressBarAdv1.TextVisible = false;
            this.progressBarAdv1.ThemesEnabled = false;
            this.progressBarAdv1.TubeEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.progressBarAdv1.TubeStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(151)))), ((int)(((byte)(226)))));
            this.progressBarAdv1.Value = 79;
            this.progressBarAdv1.WaitingGradientEnabled = true;
            this.progressBarAdv1.WaitingGradientWidth = 400;
            // 
            // progressBarAdv3
            // 
            this.progressBarAdv3.BackGradientEndColor = System.Drawing.Color.Green;
            this.progressBarAdv3.BackGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.progressBarAdv3.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient;
            this.progressBarAdv3.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv3.BackSegments = false;
            this.progressBarAdv3.BackTubeEndColor = System.Drawing.SystemColors.Control;
            this.progressBarAdv3.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv3.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.progressBarAdv3.BorderColor = System.Drawing.Color.Black;
            this.progressBarAdv3.CustomWaitingRender = false;
            this.progressBarAdv3.FontColor = System.Drawing.Color.Lime;
            this.progressBarAdv3.ForegroundImage = null;
            this.progressBarAdv3.GradientEndColor = System.Drawing.Color.Lime;
            this.progressBarAdv3.GradientStartColor = System.Drawing.Color.Red;
            this.progressBarAdv3.Location = new System.Drawing.Point(236, 44);
            this.progressBarAdv3.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ControlDarkDark,
        System.Drawing.SystemColors.ControlLight,
        System.Drawing.SystemColors.ControlDark,
        System.Drawing.SystemColors.Control};
            this.progressBarAdv3.Name = "progressBarAdv3";
            this.progressBarAdv3.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            this.progressBarAdv3.SegmentWidth = 12;
            this.progressBarAdv3.Size = new System.Drawing.Size(240, 23);
            this.progressBarAdv3.TabIndex = 2;
            this.progressBarAdv3.TextVisible = false;
            this.progressBarAdv3.ThemesEnabled = false;
            this.progressBarAdv3.TubeEndColor = System.Drawing.Color.Black;
            this.progressBarAdv3.TubeStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.progressBarAdv3.Value = 75;
            this.progressBarAdv3.WaitingGradientWidth = 400;
            // 
            // progressBarAdv4
            // 
            this.progressBarAdv4.BackGradientEndColor = System.Drawing.Color.White;
            this.progressBarAdv4.BackGradientStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBarAdv4.BackgroundImage")));
            this.progressBarAdv4.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Image;
            this.progressBarAdv4.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv4.BackSegments = false;
            this.progressBarAdv4.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarAdv4.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv4.BorderColor = System.Drawing.Color.Black;
            this.progressBarAdv4.CustomWaitingRender = false;
            this.progressBarAdv4.FontColor = System.Drawing.SystemColors.Control;
            this.progressBarAdv4.ForegroundImage = ((System.Drawing.Image)(resources.GetObject("progressBarAdv4.ForegroundImage")));
            this.progressBarAdv4.GradientEndColor = System.Drawing.Color.Lime;
            this.progressBarAdv4.GradientStartColor = System.Drawing.Color.Red;
            this.progressBarAdv4.Location = new System.Drawing.Point(236, 84);
            this.progressBarAdv4.MultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv4.Name = "progressBarAdv4";
            this.progressBarAdv4.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Image;
            this.progressBarAdv4.SegmentWidth = 12;
            this.progressBarAdv4.Size = new System.Drawing.Size(240, 23);
            this.progressBarAdv4.StretchImage = false;
            this.progressBarAdv4.TabIndex = 3;
            this.progressBarAdv4.ThemesEnabled = false;
            this.progressBarAdv4.TubeEndColor = System.Drawing.Color.Black;
            this.progressBarAdv4.TubeStartColor = System.Drawing.Color.Red;
            this.progressBarAdv4.Value = 75;
            this.progressBarAdv4.WaitingGradientWidth = 400;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(297, 18);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // progressBarAdv7
            // 
            this.progressBarAdv7.BackGradientEndColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBarAdv7.BackGradientStartColor = System.Drawing.SystemColors.ControlDark;
            this.progressBarAdv7.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient;
            this.progressBarAdv7.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv7.BackSegments = false;
            this.progressBarAdv7.BackTubeEndColor = System.Drawing.Color.Silver;
            this.progressBarAdv7.BackTubeStartColor = System.Drawing.Color.White;
            this.progressBarAdv7.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.progressBarAdv7.BorderColor = System.Drawing.Color.IndianRed;
            this.progressBarAdv7.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.progressBarAdv7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBarAdv7.CustomWaitingRender = false;
            this.progressBarAdv7.FontColor = System.Drawing.Color.White;
            this.progressBarAdv7.ForegroundImage = null;
            this.progressBarAdv7.GradientEndColor = System.Drawing.Color.Lime;
            this.progressBarAdv7.GradientStartColor = System.Drawing.Color.Red;
            this.progressBarAdv7.Location = new System.Drawing.Point(236, 116);
            this.progressBarAdv7.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ControlDarkDark,
        System.Drawing.SystemColors.ControlLightLight,
        System.Drawing.SystemColors.ActiveCaption};
            this.progressBarAdv7.Name = "progressBarAdv7";
            this.progressBarAdv7.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            this.progressBarAdv7.SegmentWidth = 8;
            this.progressBarAdv7.Size = new System.Drawing.Size(240, 23);
            this.progressBarAdv7.StretchImage = false;
            this.progressBarAdv7.TabIndex = 8;
            this.progressBarAdv7.TextVisible = false;
            this.progressBarAdv7.ThemesEnabled = false;
            this.progressBarAdv7.TubeEndColor = System.Drawing.Color.SpringGreen;
            this.progressBarAdv7.TubeStartColor = System.Drawing.Color.YellowGreen;
            this.progressBarAdv7.Value = 75;
            this.progressBarAdv7.WaitingGradientWidth = 400;
            // 
            // progressBarAdv2
            // 
            this.progressBarAdv2.BackGradientEndColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBarAdv2.BackGradientStartColor = System.Drawing.SystemColors.ControlDark;
            this.progressBarAdv2.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient;
            this.progressBarAdv2.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv2.BackSegments = false;
            this.progressBarAdv2.BackTubeEndColor = System.Drawing.Color.Silver;
            this.progressBarAdv2.BackTubeStartColor = System.Drawing.Color.White;
            this.progressBarAdv2.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.progressBarAdv2.BorderColor = System.Drawing.Color.Black;
            this.progressBarAdv2.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.progressBarAdv2.CustomWaitingRender = false;
            this.progressBarAdv2.FontColor = System.Drawing.Color.White;
            this.progressBarAdv2.ForegroundImage = null;
            this.progressBarAdv2.ForeSegments = false;
            this.progressBarAdv2.GradientEndColor = System.Drawing.Color.Lime;
            this.progressBarAdv2.GradientStartColor = System.Drawing.Color.Red;
            this.progressBarAdv2.Location = new System.Drawing.Point(100, 12);
            this.progressBarAdv2.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ControlDarkDark,
        System.Drawing.SystemColors.ControlLightLight,
        System.Drawing.SystemColors.ActiveCaption};
            this.progressBarAdv2.Name = "progressBarAdv2";
            this.progressBarAdv2.ProgressOrientation = System.Windows.Forms.Orientation.Vertical;
            this.progressBarAdv2.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            this.progressBarAdv2.SegmentWidth = 7;
            this.progressBarAdv2.Size = new System.Drawing.Size(23, 240);
            this.progressBarAdv2.StretchImage = false;
            this.progressBarAdv2.TabIndex = 14;
            this.progressBarAdv2.TextOrientation = System.Windows.Forms.Orientation.Vertical;
            this.progressBarAdv2.TextVisible = false;
            this.progressBarAdv2.ThemesEnabled = false;
            this.progressBarAdv2.TubeEndColor = System.Drawing.Color.Honeydew;
            this.progressBarAdv2.TubeStartColor = System.Drawing.Color.Green;
            this.progressBarAdv2.Value = 75;
            this.progressBarAdv2.WaitingGradientWidth = 400;
            // 
            // progressBarAdv5
            // 
            this.progressBarAdv5.BackGradientEndColor = System.Drawing.Color.White;
            this.progressBarAdv5.BackGradientStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("progressBarAdv5.BackgroundImage")));
            this.progressBarAdv5.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Image;
            this.progressBarAdv5.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv5.BackSegments = false;
            this.progressBarAdv5.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarAdv5.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv5.BorderColor = System.Drawing.Color.Black;
            this.progressBarAdv5.CustomWaitingRender = false;
            this.progressBarAdv5.FontColor = System.Drawing.SystemColors.Control;
            this.progressBarAdv5.ForegroundImage = ((System.Drawing.Image)(resources.GetObject("progressBarAdv5.ForegroundImage")));
            this.progressBarAdv5.GradientEndColor = System.Drawing.Color.Lime;
            this.progressBarAdv5.GradientStartColor = System.Drawing.Color.Red;
            this.progressBarAdv5.Location = new System.Drawing.Point(68, 12);
            this.progressBarAdv5.MultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv5.Name = "progressBarAdv5";
            this.progressBarAdv5.ProgressOrientation = System.Windows.Forms.Orientation.Vertical;
            this.progressBarAdv5.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Image;
            this.progressBarAdv5.SegmentWidth = 12;
            this.progressBarAdv5.Size = new System.Drawing.Size(23, 240);
            this.progressBarAdv5.StretchImage = false;
            this.progressBarAdv5.TabIndex = 13;
            this.progressBarAdv5.TextOrientation = System.Windows.Forms.Orientation.Vertical;
            this.progressBarAdv5.ThemesEnabled = false;
            this.progressBarAdv5.TubeEndColor = System.Drawing.Color.Black;
            this.progressBarAdv5.TubeStartColor = System.Drawing.Color.Red;
            this.progressBarAdv5.Value = 75;
            this.progressBarAdv5.WaitingGradientWidth = 400;
            // 
            // progressBarAdv6
            // 
            this.progressBarAdv6.BackGradientEndColor = System.Drawing.Color.RosyBrown;
            this.progressBarAdv6.BackGradientStartColor = System.Drawing.Color.DarkRed;
            this.progressBarAdv6.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient;
            this.progressBarAdv6.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv6.BackSegments = false;
            this.progressBarAdv6.BackTubeEndColor = System.Drawing.SystemColors.Control;
            this.progressBarAdv6.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv6.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.progressBarAdv6.BorderColor = System.Drawing.Color.Black;
            this.progressBarAdv6.CustomWaitingRender = false;
            this.progressBarAdv6.FontColor = System.Drawing.Color.Lime;
            this.progressBarAdv6.ForegroundImage = null;
            this.progressBarAdv6.ForeSegments = false;
            this.progressBarAdv6.GradientEndColor = System.Drawing.Color.Lime;
            this.progressBarAdv6.GradientStartColor = System.Drawing.Color.Red;
            this.progressBarAdv6.Location = new System.Drawing.Point(36, 12);
            this.progressBarAdv6.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.SystemColors.ControlDarkDark,
        System.Drawing.SystemColors.ControlLight,
        System.Drawing.SystemColors.ControlDark,
        System.Drawing.SystemColors.Control};
            this.progressBarAdv6.Name = "progressBarAdv6";
            this.progressBarAdv6.ProgressOrientation = System.Windows.Forms.Orientation.Vertical;
            this.progressBarAdv6.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            this.progressBarAdv6.SegmentWidth = 12;
            this.progressBarAdv6.Size = new System.Drawing.Size(23, 240);
            this.progressBarAdv6.TabIndex = 12;
            this.progressBarAdv6.TextOrientation = System.Windows.Forms.Orientation.Vertical;
            this.progressBarAdv6.TextVisible = false;
            this.progressBarAdv6.ThemesEnabled = false;
            this.progressBarAdv6.TubeEndColor = System.Drawing.Color.Black;
            this.progressBarAdv6.TubeStartColor = System.Drawing.Color.Red;
            this.progressBarAdv6.Value = 75;
            this.progressBarAdv6.WaitingGradientWidth = 400;
            // 
            // progressBarAdv9
            // 
            this.progressBarAdv9.BackGradientEndColor = System.Drawing.Color.White;
            this.progressBarAdv9.BackGradientStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv9.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Tube;
            this.progressBarAdv9.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv9.BackSegments = false;
            this.progressBarAdv9.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarAdv9.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv9.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.progressBarAdv9.BorderColor = System.Drawing.Color.Brown;
            this.progressBarAdv9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBarAdv9.CustomWaitingRender = false;
            this.progressBarAdv9.FontColor = System.Drawing.Color.LightSteelBlue;
            this.progressBarAdv9.ForegroundImage = null;
            this.progressBarAdv9.ForeSegments = false;
            this.progressBarAdv9.GradientEndColor = System.Drawing.Color.Olive;
            this.progressBarAdv9.GradientStartColor = System.Drawing.Color.WhiteSmoke;
            this.progressBarAdv9.Location = new System.Drawing.Point(236, 229);
            this.progressBarAdv9.MultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv9.Name = "progressBarAdv9";
            this.progressBarAdv9.ProgressFallbackStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.progressBarAdv9.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.progressBarAdv9.SegmentWidth = 0;
            this.progressBarAdv9.Size = new System.Drawing.Size(240, 23);
            this.progressBarAdv9.TabIndex = 15;
            this.progressBarAdv9.TextVisible = false;
            this.progressBarAdv9.ThemesEnabled = false;
            this.progressBarAdv9.TubeEndColor = System.Drawing.Color.Black;
            this.progressBarAdv9.TubeStartColor = System.Drawing.Color.Red;
            this.progressBarAdv9.Value = 75;
            this.progressBarAdv9.WaitingGradientEnabled = true;
            this.progressBarAdv9.WaitingGradientInterval = 50;
            this.progressBarAdv9.WaitingGradientWidth = 20;
            // 
            // progressBarAdv10
            // 
            this.progressBarAdv10.BackGradientEndColor = System.Drawing.Color.White;
            this.progressBarAdv10.BackGradientStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv10.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Tube;
            this.progressBarAdv10.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv10.BackSegments = false;
            this.progressBarAdv10.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarAdv10.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv10.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.progressBarAdv10.BorderColor = System.Drawing.Color.Black;
            this.progressBarAdv10.CustomWaitingRender = false;
            this.progressBarAdv10.FontColor = System.Drawing.Color.LightSteelBlue;
            this.progressBarAdv10.ForegroundImage = null;
            this.progressBarAdv10.ForeSegments = false;
            this.progressBarAdv10.GradientEndColor = System.Drawing.Color.Yellow;
            this.progressBarAdv10.GradientStartColor = System.Drawing.Color.Red;
            this.progressBarAdv10.Location = new System.Drawing.Point(132, 12);
            this.progressBarAdv10.MultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv10.Name = "progressBarAdv10";
            this.progressBarAdv10.ProgressOrientation = System.Windows.Forms.Orientation.Vertical;
            this.progressBarAdv10.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Gradient;
            this.progressBarAdv10.SegmentWidth = 12;
            this.progressBarAdv10.Size = new System.Drawing.Size(23, 240);
            this.progressBarAdv10.TabIndex = 16;
            this.progressBarAdv10.TextOrientation = System.Windows.Forms.Orientation.Vertical;
            this.progressBarAdv10.ThemesEnabled = false;
            this.progressBarAdv10.TubeEndColor = System.Drawing.Color.Black;
            this.progressBarAdv10.TubeStartColor = System.Drawing.Color.Red;
            this.progressBarAdv10.Value = 75;
            this.progressBarAdv10.WaitingGradientWidth = 400;
            // 
            // progressBarAdv11
            // 
            this.progressBarAdv11.BackGradientEndColor = System.Drawing.Color.White;
            this.progressBarAdv11.BackGradientStartColor = System.Drawing.Color.White;
            this.progressBarAdv11.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient;
            this.progressBarAdv11.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv11.BackSegments = false;
            this.progressBarAdv11.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarAdv11.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv11.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.progressBarAdv11.BorderColor = System.Drawing.Color.Black;
            this.progressBarAdv11.CustomWaitingRender = false;
            this.progressBarAdv11.FontColor = System.Drawing.Color.White;
            this.progressBarAdv11.ForeColor = System.Drawing.Color.White;
            this.progressBarAdv11.ForegroundImage = null;
            this.progressBarAdv11.GradientEndColor = System.Drawing.Color.DarkSeaGreen;
            this.progressBarAdv11.GradientStartColor = System.Drawing.Color.Red;
            this.progressBarAdv11.Location = new System.Drawing.Point(236, 154);
            this.progressBarAdv11.Maximum = 75;
            this.progressBarAdv11.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Brown,
        System.Drawing.Color.MidnightBlue,
        System.Drawing.Color.DarkSeaGreen,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.DarkOrange,
        System.Drawing.Color.LawnGreen};
            this.progressBarAdv11.Name = "progressBarAdv11";
            this.progressBarAdv11.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.MultipleGradient;
            this.progressBarAdv11.SegmentWidth = 12;
            this.progressBarAdv11.Size = new System.Drawing.Size(240, 23);
            this.progressBarAdv11.StretchMultGrad = false;
            this.progressBarAdv11.TabIndex = 17;
            this.progressBarAdv11.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value;
            this.progressBarAdv11.ThemesEnabled = false;
            this.progressBarAdv11.TubeEndColor = System.Drawing.Color.Black;
            this.progressBarAdv11.TubeStartColor = System.Drawing.Color.Red;
            this.progressBarAdv11.Value = 75;
            this.progressBarAdv11.WaitingGradientWidth = 400;
            // 
            // progressBarAdv12
            // 
            this.progressBarAdv12.BackGradientEndColor = System.Drawing.Color.White;
            this.progressBarAdv12.BackGradientStartColor = System.Drawing.Color.Lime;
            this.progressBarAdv12.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.VerticalGradient;
            this.progressBarAdv12.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv12.BackSegments = false;
            this.progressBarAdv12.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarAdv12.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv12.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.progressBarAdv12.BorderColor = System.Drawing.Color.Black;
            this.progressBarAdv12.CustomWaitingRender = false;
            this.progressBarAdv12.FontColor = System.Drawing.Color.White;
            this.progressBarAdv12.ForegroundImage = null;
            this.progressBarAdv12.ForeSegments = false;
            this.progressBarAdv12.GradientEndColor = System.Drawing.Color.Lime;
            this.progressBarAdv12.GradientStartColor = System.Drawing.Color.Red;
            this.progressBarAdv12.Location = new System.Drawing.Point(164, 12);
            this.progressBarAdv12.Maximum = 75;
            this.progressBarAdv12.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Brown,
        System.Drawing.Color.MidnightBlue,
        System.Drawing.Color.DarkSeaGreen,
        System.Drawing.Color.DeepPink,
        System.Drawing.Color.DarkOrange,
        System.Drawing.Color.LawnGreen};
            this.progressBarAdv12.Name = "progressBarAdv12";
            this.progressBarAdv12.ProgressOrientation = System.Windows.Forms.Orientation.Vertical;
            this.progressBarAdv12.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.MultipleGradient;
            this.progressBarAdv12.SegmentWidth = 12;
            this.progressBarAdv12.Size = new System.Drawing.Size(23, 240);
            this.progressBarAdv12.StretchMultGrad = false;
            this.progressBarAdv12.TabIndex = 18;
            this.progressBarAdv12.TextOrientation = System.Windows.Forms.Orientation.Vertical;
            this.progressBarAdv12.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value;
            this.progressBarAdv12.ThemesEnabled = false;
            this.progressBarAdv12.TubeEndColor = System.Drawing.Color.Black;
            this.progressBarAdv12.TubeStartColor = System.Drawing.Color.Red;
            this.progressBarAdv12.Value = 75;
            this.progressBarAdv12.WaitingGradientWidth = 400;
            // 
            // progressBarAdv13
            // 
            this.progressBarAdv13.BackGradientEndColor = System.Drawing.Color.White;
            this.progressBarAdv13.BackGradientStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv13.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.System;
            this.progressBarAdv13.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv13.BackSegments = false;
            this.progressBarAdv13.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarAdv13.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv13.BorderColor = System.Drawing.Color.Black;
            this.progressBarAdv13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarAdv13.CustomWaitingRender = false;
            this.progressBarAdv13.FontColor = System.Drawing.Color.White;
            this.progressBarAdv13.ForegroundImage = null;
            this.progressBarAdv13.GradientEndColor = System.Drawing.Color.Lime;
            this.progressBarAdv13.GradientStartColor = System.Drawing.Color.Red;
            this.progressBarAdv13.Location = new System.Drawing.Point(196, 12);
            this.progressBarAdv13.MultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv13.Name = "progressBarAdv13";
            this.progressBarAdv13.ProgressOrientation = System.Windows.Forms.Orientation.Vertical;
            this.progressBarAdv13.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.System;
            this.progressBarAdv13.SegmentWidth = 12;
            this.progressBarAdv13.Size = new System.Drawing.Size(23, 240);
            this.progressBarAdv13.TabIndex = 19;
            this.progressBarAdv13.TextOrientation = System.Windows.Forms.Orientation.Vertical;
            this.progressBarAdv13.ThemesEnabled = true;
            this.progressBarAdv13.TubeEndColor = System.Drawing.Color.Black;
            this.progressBarAdv13.TubeStartColor = System.Drawing.Color.Red;
            this.progressBarAdv13.Value = 75;
            this.progressBarAdv13.WaitingGradientWidth = 400;
            // 
            // progressBarAdv14
            // 
            this.progressBarAdv14.BackGradientEndColor = System.Drawing.Color.White;
            this.progressBarAdv14.BackGradientStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv14.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.System;
            this.progressBarAdv14.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv14.BackSegments = false;
            this.progressBarAdv14.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarAdv14.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBarAdv14.BorderColor = System.Drawing.Color.Black;
            this.progressBarAdv14.BorderSingle = System.Windows.Forms.ButtonBorderStyle.Dotted;
            this.progressBarAdv14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarAdv14.CustomWaitingRender = false;
            this.progressBarAdv14.FontColor = System.Drawing.Color.White;
            this.progressBarAdv14.ForegroundImage = null;
            this.progressBarAdv14.GradientEndColor = System.Drawing.Color.Lime;
            this.progressBarAdv14.GradientStartColor = System.Drawing.Color.Red;
            this.progressBarAdv14.Location = new System.Drawing.Point(236, 194);
            this.progressBarAdv14.MultipleColors = new System.Drawing.Color[0];
            this.progressBarAdv14.Name = "progressBarAdv14";
            this.progressBarAdv14.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.System;
            this.progressBarAdv14.SegmentWidth = 12;
            this.progressBarAdv14.Size = new System.Drawing.Size(240, 23);
            this.progressBarAdv14.TabIndex = 20;
            this.progressBarAdv14.ThemesEnabled = true;
            this.progressBarAdv14.TubeEndColor = System.Drawing.Color.Black;
            this.progressBarAdv14.TubeStartColor = System.Drawing.Color.Red;
            this.progressBarAdv14.Value = 75;
            this.progressBarAdv14.WaitingGradientWidth = 400;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // TestButton
            // 
            this.TestButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TestButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TestButton.ImageIndex = 0;
            this.TestButton.Location = new System.Drawing.Point(64, 16);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(80, 24);
            this.TestButton.TabIndex = 21;
            this.TestButton.Text = "Test";
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // Stop
            // 
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Stop.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Stop.ImageIndex = 1;
            this.Stop.Location = new System.Drawing.Point(179, 18);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(80, 24);
            this.Stop.TabIndex = 22;
            this.Stop.Text = "Stop";
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TestButton);
            this.groupBox1.Controls.Add(this.Stop);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(36, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 48);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // progressBarWaiting
            // 
            this.progressBarWaiting.BackColor = System.Drawing.Color.Lavender;
            this.progressBarWaiting.BackGradientEndColor = System.Drawing.Color.White;
            this.progressBarWaiting.BackGradientStartColor = System.Drawing.Color.LightGray;
            this.progressBarWaiting.BackMultipleColors = new System.Drawing.Color[0];
            this.progressBarWaiting.BackSegments = false;
            this.progressBarWaiting.BackTubeEndColor = System.Drawing.Color.White;
            this.progressBarWaiting.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.progressBarWaiting.BorderColor = System.Drawing.Color.Black;
            this.progressBarWaiting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.progressBarWaiting.CustomWaitingRender = false;
            this.progressBarWaiting.Dock = System.Windows.Forms.DockStyle.Top;
            this.progressBarWaiting.FontColor = System.Drawing.Color.White;
            this.progressBarWaiting.ForegroundImage = null;
            this.progressBarWaiting.ForeSegments = false;
            this.progressBarWaiting.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.progressBarWaiting.GradientStartColor = System.Drawing.Color.Lavender;
            this.progressBarWaiting.Location = new System.Drawing.Point(0, 0);
            this.progressBarWaiting.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Thistle,
        System.Drawing.Color.Blue};
            this.progressBarWaiting.Name = "progressBarWaiting";
            this.progressBarWaiting.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.WaitingGradient;
            this.progressBarWaiting.SegmentWidth = 12;
            this.progressBarWaiting.Size = new System.Drawing.Size(526, 6);
            this.progressBarWaiting.TabIndex = 2;
            this.progressBarWaiting.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Custom;
            this.progressBarWaiting.ThemesEnabled = false;
            this.progressBarWaiting.TubeEndColor = System.Drawing.Color.Black;
            this.progressBarWaiting.TubeStartColor = System.Drawing.Color.Red;
            this.progressBarWaiting.Value = 100;
            this.progressBarWaiting.WaitingGradientEnabled = true;
            this.progressBarWaiting.WaitingGradientInterval = 25;
            this.progressBarWaiting.WaitingGradientWidth = 600;
            // 
            // FormMain
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(526, 332);
            this.Controls.Add(this.progressBarWaiting);
            this.Controls.Add(this.progressBarAdv5);
            this.Controls.Add(this.progressBarAdv13);
            this.Controls.Add(this.progressBarAdv6);
            this.Controls.Add(this.progressBarAdv10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBarAdv12);
            this.Controls.Add(this.progressBarAdv14);
            this.Controls.Add(this.progressBarAdv3);
            this.Controls.Add(this.progressBarAdv2);
            this.Controls.Add(this.progressBarAdv1);
            this.Controls.Add(this.progressBarAdv9);
            this.Controls.Add(this.progressBarAdv11);
            this.Controls.Add(this.progressBarAdv7);
            this.Controls.Add(this.progressBarAdv4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBarAdv Demo";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarAdv14)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarWaiting)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new FormMain());
		}

		private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
		{
			SetProgressValue((int)numericUpDown1.Value);
		}

		private void timer_Tick(object sender, System.EventArgs e)
		{
			SetProgressValue(progressBarAdv1.Value+1);
			if(progressBarAdv1.Value >= 100) 
                SetProgressValue(0);
		}
		private void SetProgressValue(int val)
		{
			
			this.progressBarAdv1.Value = val;
			this.progressBarAdv2.Value = val;
			this.progressBarAdv3.Value = val;
			this.progressBarAdv4.Value = val;
			this.progressBarAdv5.Value = val;
			this.progressBarAdv6.Value = val;
			this.progressBarAdv7.Value = val;
			this.progressBarAdv9.Value = val;
			this.progressBarAdv10.Value = val;
			this.progressBarAdv11.Value = val;
			this.progressBarAdv12.Value = val;
			this.progressBarAdv13.Value = val;
			this.progressBarAdv14.Value = val;
		}

		private void TestButton_Click(object sender, System.EventArgs e)
		{
			timer.Enabled = true;
			if(progressBarAdv1.Value >= 100) 
                SetProgressValue(0);
		}

		private void Stop_Click(object sender, System.EventArgs e)
		{
			timer.Enabled = false;
		}  
	}
}
