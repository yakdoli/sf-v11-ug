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

namespace CustomCursorDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.MenuItem menuItem6;
		private System.Windows.Forms.MenuItem menuItem7;
		private System.Windows.Forms.MenuItem menuItem8;
		private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.MenuItem menuItem9;
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
		private Cursor currentCursor = Cursors.Default;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.editControl1.LoadFile("..\\..\\Form1.cs");

			this.editControl1.Cursor = this.currentCursor;
			this.editControl1.MouseMove+=new MouseEventHandler(editControl1_MouseMove);
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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.menuItem6 = new System.Windows.Forms.MenuItem();
			this.menuItem7 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem9});
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
																					  this.menuItem8});
			this.menuItem1.Text = "File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "New";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "Open";
			this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
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
			this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 4;
			this.menuItem6.Text = "SaveAs";
			this.menuItem6.Click += new System.EventHandler(this.menuItem6_Click);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 5;
			this.menuItem7.Text = "-";
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 6;
			this.menuItem8.Text = "Exit";
			this.menuItem8.Click += new System.EventHandler(this.menuItem8_Click);
			// 
			// editControl1
			// 
			this.editControl1.AutoIndentMode = Syncfusion.Windows.Forms.Edit.Enums.AutoIndentMode.Smart;
			this.editControl1.CurrentColumn = 1;
			this.editControl1.CurrentLine = 1;
			this.editControl1.CurrentPosition = new System.Drawing.Point(1, 1);
			this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editControl1.FileOpened = null;
			this.editControl1.GraphicsCompositingQuality = System.Drawing.Drawing2D.CompositingQuality.Default;
			this.editControl1.GraphicsInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
			this.editControl1.GraphicsSmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
			this.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.editControl1.Name = "editControl1";
			this.editControl1.SelectionMarginBackgroundColor = System.Drawing.Color.Empty;
			this.editControl1.SelectionMarginForegroundColor = System.Drawing.Color.Red;
			this.editControl1.ShowCollapse = true;
			this.editControl1.ShowHorizontalSplitters = true;
			this.editControl1.ShowLineNumbers = true;
			this.editControl1.ShowMarkers = true;
			this.editControl1.ShowSelectionMargin = true;
			this.editControl1.ShowVerticalSplitters = true;
			this.editControl1.ShowWhitespaces = false;
			this.editControl1.Size = new System.Drawing.Size(542, 445);
			this.editControl1.TabIndex = 0;
			this.editControl1.TabSize = 2;
			this.editControl1.Text = "editControl1";
			this.editControl1.TransferFocusOnTab = true;
			this.editControl1.UserMarginWidth = 100;
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 1;
			this.menuItem9.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem10,
																					  this.menuItem11,
																					  this.menuItem12,
																					  this.menuItem13,
																					  this.menuItem14,
																					  this.menuItem15,
																					  this.menuItem16,
																					  this.menuItem17,
																					  this.menuItem18,
																					  this.menuItem19,
																					  this.menuItem20,
																					  this.menuItem21,
																					  this.menuItem22});
			this.menuItem9.Text = "Cursors";
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 0;
			this.menuItem10.Text = "AppStarting";
			this.menuItem10.Click += new System.EventHandler(this.menuItem_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 1;
			this.menuItem11.Text = "Arrow";
			this.menuItem11.Click += new System.EventHandler(this.menuItem_Click);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 2;
			this.menuItem12.Text = "Cross";
			this.menuItem12.Click += new System.EventHandler(this.menuItem_Click);
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 3;
			this.menuItem13.Text = "Default";
			this.menuItem13.Click += new System.EventHandler(this.menuItem_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 4;
			this.menuItem14.Text = "Hand";
			this.menuItem14.Click += new System.EventHandler(this.menuItem_Click);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 5;
			this.menuItem15.Text = "Help";
			this.menuItem15.Click += new System.EventHandler(this.menuItem_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 6;
			this.menuItem16.Text = "HSplit";
			this.menuItem16.Click += new System.EventHandler(this.menuItem_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 7;
			this.menuItem17.Text = "IBeam";
			this.menuItem17.Click += new System.EventHandler(this.menuItem_Click);
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 8;
			this.menuItem18.Text = "No";
			this.menuItem18.Click += new System.EventHandler(this.menuItem_Click);
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 9;
			this.menuItem19.Text = "SizeAll";
			this.menuItem19.Click += new System.EventHandler(this.menuItem_Click);
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 10;
			this.menuItem20.Text = "UpArrow";
			this.menuItem20.Click += new System.EventHandler(this.menuItem_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 11;
			this.menuItem21.Text = "VSplit";
			this.menuItem21.Click += new System.EventHandler(this.menuItem_Click);
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 12;
			this.menuItem22.Text = "WaitCursor";
			this.menuItem22.Click += new System.EventHandler(this.menuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(542, 445);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.editControl1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "Custom Cursor";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
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

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			this.editControl1.NewFile();
		}

		private void menuItem3_Click(object sender, System.EventArgs e)
		{
			this.editControl1.LoadFile();
		}

		private void menuItem5_Click(object sender, System.EventArgs e)
		{
			this.editControl1.Save();
		}

		private void menuItem6_Click(object sender, System.EventArgs e)
		{
			this.editControl1.SaveAs();
		}

		private void menuItem8_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
		}

		private void editControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			this.editControl1.Cursor = this.currentCursor;
		}

		private void menuItem_Click(object sender, System.EventArgs e)
		{
			MenuItem mitem = sender as MenuItem;

			if (mitem.Text == "AppStarting")
				this.currentCursor = Cursors.AppStarting;
			if (mitem.Text == "Arrow")
				this.currentCursor = Cursors.Arrow;
			if (mitem.Text == "Cross")
				this.currentCursor = Cursors.Cross;
			if (mitem.Text == "Default")
				this.currentCursor = Cursors.Default;
			if (mitem.Text == "Hand")
				this.currentCursor = Cursors.Hand;
			if (mitem.Text == "Help")
				this.currentCursor = Cursors.Help;
			if (mitem.Text == "HSplit")
				this.currentCursor = Cursors.HSplit;
			if (mitem.Text == "IBeam")
				this.currentCursor = Cursors.IBeam;
			if (mitem.Text == "No")
				this.currentCursor = Cursors.No;
			if (mitem.Text == "SizeAll")
				this.currentCursor = Cursors.SizeAll;
			if (mitem.Text == "UpArrow")
				this.currentCursor = Cursors.UpArrow;
			if (mitem.Text == "VSplit")
				this.currentCursor = Cursors.VSplit;
			if (mitem.Text == "WaitCursor")
				this.currentCursor = Cursors.WaitCursor;

			this.editControl1.Cursor = this.currentCursor;
		}
	}
}
