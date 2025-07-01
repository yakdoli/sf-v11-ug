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
using System.IO;
using System.Drawing.Drawing2D;

using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Enums;
using Syncfusion.Windows.Forms.Edit.Implementation;
using Syncfusion.Drawing;

namespace WordwrapDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private System.Windows.Forms.MenuItem menuItem9;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.MenuItem menuItem10;
		private System.Windows.Forms.MenuItem menuItem11;
		private System.Windows.Forms.MenuItem menuItem12;
		private System.Windows.Forms.MenuItem menuItem13;
		private System.Windows.Forms.MenuItem menuItem14;
		private System.Windows.Forms.MenuItem menuItem15;
		private System.Windows.Forms.MenuItem menuItem16;
		private System.Windows.Forms.MenuItem menuItem17;
		private System.Windows.Forms.MenuItem menuItem18;
		private System.Windows.Forms.MenuItem menuItem19;
		private System.Windows.Forms.MenuItem menuItem20;
		private System.Windows.Forms.MenuItem menuItem21;
		private System.Windows.Forms.MenuItem menuItem22;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem27;
		private System.Windows.Forms.MenuItem menuItem28;
		private System.Windows.Forms.MenuItem menuItem29;
		private System.Windows.Forms.MenuItem menuItem30;
		private System.Windows.Forms.MenuItem menuItem31;
		private System.Windows.Forms.MenuItem menuItem32;
		private System.Windows.Forms.MenuItem menuItem33;
		private System.Windows.Forms.MenuItem menuItem34;
		private System.Windows.Forms.MenuItem menuItem35;
		private System.Windows.Forms.MenuItem menuItem36;
		private System.Windows.Forms.MenuItem menuItem37;
		private System.Windows.Forms.MenuItem menuItem38;
		private System.Windows.Forms.MenuItem menuItem39;
		private System.Windows.Forms.MenuItem menuItem40;
		private System.Windows.Forms.MenuItem menuItem41;
		private System.Windows.Forms.MenuItem menuItem42;
		private System.Windows.Forms.MenuItem menuItem43;
		private System.Windows.Forms.MenuItem menuItem44;

		string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\VBSource.vb";

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.editControl1.LoadFile(filePath);

			this.editControl1.WordWrap = true;
			this.editControl1.WordWrapMode = WordWrapMode.WordWrapMargin;
			this.editControl1.WordWrapType = WordWrapType.WrapByChar;
			this.editControl1.TextAreaWidth = 350;
			this.editControl1.WordWrapMarginLineStyle = DashStyle.Dash;
			this.editControl1.WordWrapMarginLineColor = Color.Green;
			this.editControl1.WordWrapMarginBrush = new BrushInfo(gradientStyle, foreColor, backColor);
			this.editControl1.WordWrapMarginVisible = true;

			this.Size = new Size(568,408);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.menuItem25 = new System.Windows.Forms.MenuItem();
			this.menuItem26 = new System.Windows.Forms.MenuItem();
			this.menuItem27 = new System.Windows.Forms.MenuItem();
			this.menuItem28 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuItem29 = new System.Windows.Forms.MenuItem();
			this.menuItem30 = new System.Windows.Forms.MenuItem();
			this.menuItem31 = new System.Windows.Forms.MenuItem();
			this.menuItem32 = new System.Windows.Forms.MenuItem();
			this.menuItem24 = new System.Windows.Forms.MenuItem();
			this.menuItem33 = new System.Windows.Forms.MenuItem();
			this.menuItem34 = new System.Windows.Forms.MenuItem();
			this.menuItem35 = new System.Windows.Forms.MenuItem();
			this.menuItem36 = new System.Windows.Forms.MenuItem();
			this.menuItem37 = new System.Windows.Forms.MenuItem();
			this.menuItem38 = new System.Windows.Forms.MenuItem();
			this.menuItem39 = new System.Windows.Forms.MenuItem();
			this.menuItem40 = new System.Windows.Forms.MenuItem();
			this.menuItem41 = new System.Windows.Forms.MenuItem();
			this.menuItem42 = new System.Windows.Forms.MenuItem();
			this.menuItem43 = new System.Windows.Forms.MenuItem();
			this.menuItem44 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// editControl1
			// 
			this.editControl1.AutoIndentMode = AutoIndentMode.Smart;
			this.editControl1.BackColor = System.Drawing.SystemColors.Window;
			this.editControl1.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.editControl1.CurrentColumn = 1;
			this.editControl1.CurrentLine = 1;
			this.editControl1.CurrentPosition = new System.Drawing.Point(1, 1);
			this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editControl1.FileOpened = null;
			this.editControl1.GraphicsCompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default;
			this.editControl1.GraphicsInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
			this.editControl1.GraphicsSmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
			this.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.editControl1.IndentBlockHighlightingColor = System.Drawing.Color.LightBlue;
			this.editControl1.IndentLineColor = System.Drawing.Color.Gray;
			this.editControl1.Name = "editControl1";
			this.editControl1.SelectionMarginBackgroundColor = System.Drawing.Color.Empty;
			this.editControl1.SelectionMarginForegroundColor = System.Drawing.Color.Red;
			this.editControl1.ShowCollapse = true;
			this.editControl1.ShowHorizontalSplitters = true;
			this.editControl1.ShowIndentationGuidelines = true;
			this.editControl1.ShowLineNumbers = true;
			this.editControl1.ShowMarkers = false;
			this.editControl1.ShowSelectionMargin = false;
			this.editControl1.ShowVerticalSplitters = true;
			this.editControl1.ShowWhitespaces = false;
			this.editControl1.Size = new System.Drawing.Size(512, 445);
			this.editControl1.TabIndex = 0;
			this.editControl1.TabSize = 2;
			this.editControl1.Text = "";
			this.editControl1.TextAreaWidth = 600;
			this.editControl1.TransferFocusOnTab = true;
			this.editControl1.UserMarginBackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BurlyWood);
			this.editControl1.UserMarginWidth= 100;
			this.editControl1.UserMarginTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.editControl1.WordWrap = true;
			this.editControl1.WordWrapMarginBrush = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.BlanchedAlmond);
			this.editControl1.WordWrapMarginLineColor = System.Drawing.Color.Black;
			this.editControl1.WordWrapMarginLineStyle = System.Drawing.Drawing2D.DashStyle.Dot;
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem10,
																					  this.menuItem11,
																					  this.menuItem16,
																					  this.menuItem22,
																					  this.menuItem23,
																					  this.menuItem24,
																					  this.menuItem37});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem2,
																					  this.menuItem3,
																					  this.menuItem4,
																					  this.menuItem5,
																					  this.menuItem6,
																					  this.menuItem7,
																					  this.menuItem9,
																					  this.menuItem8});
			this.menuItem1.Text = "File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "New";
			this.menuItem2.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "Open";
			this.menuItem3.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 2;
			this.menuItem4.Text = "-";
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 3;
			this.menuItem5.Text = "Save";
			this.menuItem5.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 4;
			this.menuItem6.Text = "SaveAs";
			this.menuItem6.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 5;
			this.menuItem7.Text = "-";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 6;
			this.menuItem9.Text = "Close";
			this.menuItem9.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 7;
			this.menuItem8.Text = "Exit";
			this.menuItem8.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 1;
			this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem12,
																					   this.menuItem13});
			this.menuItem10.Text = "WrapMode";
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 0;
			this.menuItem12.Text = "Control";
			this.menuItem12.Click += new System.EventHandler(this.WrapModeClick);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 1;
			this.menuItem13.Text = "TextArea";
			this.menuItem13.Click += new System.EventHandler(this.WrapModeClick);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 2;
			this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem14,
																					   this.menuItem15});
			this.menuItem11.Text = " WrapType";
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 0;
			this.menuItem14.Text = "Character";
			this.menuItem14.Click += new System.EventHandler(this.WrapTypeClick);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 1;
			this.menuItem15.Text = "Word";
			this.menuItem15.Click += new System.EventHandler(this.WrapTypeClick);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 3;
			this.menuItem16.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem17,
																					   this.menuItem18,
																					   this.menuItem19,
																					   this.menuItem20,
																					   this.menuItem21});
			this.menuItem16.Text = "LineStyle";
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 0;
			this.menuItem17.Text = "Dash";
			this.menuItem17.Click += new System.EventHandler(this.LineStyleClick);
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 1;
			this.menuItem18.Text = "DashDot";
			this.menuItem18.Click += new System.EventHandler(this.LineStyleClick);
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 2;
			this.menuItem19.Text = "DashDotDot";
			this.menuItem19.Click += new System.EventHandler(this.LineStyleClick);
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 3;
			this.menuItem20.Text = "Dot";
			this.menuItem20.Click += new System.EventHandler(this.LineStyleClick);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 4;
			this.menuItem21.Text = "Solid";
			this.menuItem21.Click += new System.EventHandler(this.LineStyleClick);
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 4;
			this.menuItem22.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem25,
																					   this.menuItem26,
																					   this.menuItem27,
																					   this.menuItem28});
			this.menuItem22.Text = "LineColor";
			// 
			// menuItem25
			// 
			this.menuItem25.Index = 0;
			this.menuItem25.Text = "Green";
			this.menuItem25.Click += new System.EventHandler(this.LineColorClick);
			// 
			// menuItem26
			// 
			this.menuItem26.Index = 1;
			this.menuItem26.Text = "Navy";
			this.menuItem26.Click += new System.EventHandler(this.LineColorClick);
			// 
			// menuItem27
			// 
			this.menuItem27.Index = 2;
			this.menuItem27.Text = "IndianRed";
			this.menuItem27.Click += new System.EventHandler(this.LineColorClick);
			// 
			// menuItem28
			// 
			this.menuItem28.Index = 3;
			this.menuItem28.Text = "Aqua";
			this.menuItem28.Click += new System.EventHandler(this.LineColorClick);
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 5;
			this.menuItem23.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem29,
																					   this.menuItem30,
																					   this.menuItem31,
																					   this.menuItem32});
			this.menuItem23.Text = "ForeColor";
			// 
			// menuItem29
			// 
			this.menuItem29.Index = 0;
			this.menuItem29.Text = "Salmon";
			this.menuItem29.Click += new System.EventHandler(this.ForeColorClick);
			// 
			// menuItem30
			// 
			this.menuItem30.Index = 1;
			this.menuItem30.Text = "Orange";
			this.menuItem30.Click += new System.EventHandler(this.ForeColorClick);
			// 
			// menuItem31
			// 
			this.menuItem31.Index = 2;
			this.menuItem31.Text = "Blue";
			this.menuItem31.Click += new System.EventHandler(this.ForeColorClick);
			// 
			// menuItem32
			// 
			this.menuItem32.Index = 3;
			this.menuItem32.Text = "Pink";
			this.menuItem32.Click += new System.EventHandler(this.ForeColorClick);
			// 
			// menuItem24
			// 
			this.menuItem24.Index = 6;
			this.menuItem24.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem33,
																					   this.menuItem34,
																					   this.menuItem35,
																					   this.menuItem36});
			this.menuItem24.Text = "BackColor";
			// 
			// menuItem33
			// 
			this.menuItem33.Index = 0;
			this.menuItem33.Text = "Beige";
			this.menuItem33.Click += new System.EventHandler(this.BackColorClick);
			// 
			// menuItem34
			// 
			this.menuItem34.Index = 1;
			this.menuItem34.Text = "LightYellow";
			this.menuItem34.Click += new System.EventHandler(this.BackColorClick);
			// 
			// menuItem35
			// 
			this.menuItem35.Index = 2;
			this.menuItem35.Text = "LightSalmon";
			this.menuItem35.Click += new System.EventHandler(this.BackColorClick);
			// 
			// menuItem36
			// 
			this.menuItem36.Index = 3;
			this.menuItem36.Text = "Silver";
			this.menuItem36.Click += new System.EventHandler(this.BackColorClick);
			// 
			// menuItem37
			// 
			this.menuItem37.Index = 7;
			this.menuItem37.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem38,
																					   this.menuItem39,
																					   this.menuItem40,
																					   this.menuItem41,
																					   this.menuItem42,
																					   this.menuItem43,
																					   this.menuItem44});
			this.menuItem37.Text = "GradientStyle";
			// 
			// menuItem38
			// 
			this.menuItem38.Index = 0;
			this.menuItem38.Text = "BackwardDiagonal";
			this.menuItem38.Click += new System.EventHandler(this.GradientStyleClick);
			// 
			// menuItem39
			// 
			this.menuItem39.Index = 1;
			this.menuItem39.Text = "ForwardDiagonal";
			this.menuItem39.Click += new System.EventHandler(this.GradientStyleClick);
			// 
			// menuItem40
			// 
			this.menuItem40.Index = 2;
			this.menuItem40.Text = "Horizontal";
			this.menuItem40.Click += new System.EventHandler(this.GradientStyleClick);
			// 
			// menuItem41
			// 
			this.menuItem41.Index = 3;
			this.menuItem41.Text = "None";
			this.menuItem41.Click += new System.EventHandler(this.GradientStyleClick);
			// 
			// menuItem42
			// 
			this.menuItem42.Index = 4;
			this.menuItem42.Text = "PathEllipse";
			this.menuItem42.Click += new System.EventHandler(this.GradientStyleClick);
			// 
			// menuItem43
			// 
			this.menuItem43.Index = 5;
			this.menuItem43.Text = "PathRectangle";
			this.menuItem43.Click += new System.EventHandler(this.GradientStyleClick);
			// 
			// menuItem44
			// 
			this.menuItem44.Index = 6;
			this.menuItem44.Text = "Vertical";
			this.menuItem44.Click += new System.EventHandler(this.GradientStyleClick);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(512, 445);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.editControl1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Word Wrap";
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
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

		private void MainMenuClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "New" :
					this.editControl1.NewFile();
					break;
				case "Open" :
					this.editControl1.LoadFile();
					break;
				case "Save" :
					this.editControl1.Save();
					break;
				case "SaveAs" :
					this.editControl1.SaveAs();
					break;
				case "Close" :
					this.editControl1.Close();
					this.editControl1.NewFile();
					break;
				case "Exit" :
					this.Close();
					break;
			}
		}

		private void WrapModeClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;
			switch (mi.Text)
			{
				case "Control" :
					this.editControl1.WordWrapMode = WordWrapMode.Control;
					break;
				case "TextArea" :
					this.editControl1.WordWrapMode = WordWrapMode.WordWrapMargin;
					break;
			}
		}

		private void WrapTypeClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;
			switch (mi.Text)
			{
				case "Character" :
					this.editControl1.WordWrapType = WordWrapType.WrapByChar;
					break;
				case "Word" :
					this.editControl1.WordWrapType = WordWrapType.WrapByWord;
					break;
			}
		}

		private void LineStyleClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;
			switch (mi.Text)
			{
				case "Dash" :
					this.editControl1.WordWrapMarginLineStyle = DashStyle.Dash;
					break;
				case "DashDot" :
					this.editControl1.WordWrapMarginLineStyle = DashStyle.DashDot;
					break;
				case "DashDotDot" :
					this.editControl1.WordWrapMarginLineStyle = DashStyle.DashDotDot;
					break;
				case "Dot" :
					this.editControl1.WordWrapMarginLineStyle = DashStyle.Dot;
					break;
				case "Solid" :
					this.editControl1.WordWrapMarginLineStyle = DashStyle.Solid;
					break;
			}
		}

		private void LineColorClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;
			switch (mi.Text)
			{
				case "Green" :
					this.editControl1.WordWrapMarginLineColor = Color.Green;
					break;
				case "Navy" :
					this.editControl1.WordWrapMarginLineColor = Color.Navy;
					break;
				case "IndianRed" :
					this.editControl1.WordWrapMarginLineColor = Color.IndianRed;
					break;
				case "Aqua" :
					this.editControl1.WordWrapMarginLineColor = Color.Aqua;
					break;
			}
		}

		Color foreColor = Color.White;
		private void ForeColorClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;
			switch (mi.Text)
			{
				case "Salmon" :
					foreColor = Color.Salmon;
					break;
				case "Orange" :
					foreColor = Color.Orange;
					break;
				case "Blue" :
					foreColor = Color.Blue;
					break;
				case "Pink" :
					foreColor = Color.Pink;
					break;
			}
			this.editControl1.WordWrapMarginBrush = new BrushInfo(gradientStyle, foreColor, backColor);
		}

		Color backColor = Color.LightSalmon;
		private void BackColorClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;
			switch (mi.Text)
			{
				case "Beige" :
					backColor = Color.Beige;
					break;
				case "LightYellow" :
					backColor = Color.LightYellow;
					break;
				case "LightSalmon" :
					backColor = Color.LightSalmon;
					break;
				case "Silver" :
					backColor = Color.Silver;
					break;
			}

			this.editControl1.WordWrapMarginBrush = new BrushInfo(gradientStyle, foreColor, backColor);
		}

		GradientStyle gradientStyle = GradientStyle.Horizontal;	
		private void GradientStyleClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;
			switch (mi.Text)
			{
				case "BackwardDiagonal" :
					gradientStyle = GradientStyle.BackwardDiagonal;
					break;
				case "ForwardDiagonal" :
					gradientStyle = GradientStyle.ForwardDiagonal;
					break;
				case "Horizontal" :
					gradientStyle = GradientStyle.Horizontal;
					break;
				case "None" :
					gradientStyle = GradientStyle.None;
					break;
				case "PathEllipse" :
					gradientStyle = GradientStyle.PathEllipse;
					break;
				case "PathRectangle" :
					gradientStyle = GradientStyle.PathRectangle;
					break;
				case "Vertical" :
					gradientStyle = GradientStyle.Vertical;
					break;
			}

			this.editControl1.WordWrapMarginBrush = new BrushInfo(gradientStyle, foreColor, backColor);
		}
	}
}
