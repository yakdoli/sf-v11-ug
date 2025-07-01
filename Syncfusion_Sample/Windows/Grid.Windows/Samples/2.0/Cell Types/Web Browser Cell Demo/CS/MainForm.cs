#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Diagnostics;

namespace GridSample
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm
	{
		Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
		Syncfusion.Windows.Forms.SplitterControl splitterControl1;
		DataSet1 dataSet11;
		Form1 form;
		private AxSHDocVw.AxWebBrowser axWebBrowser1;

		public MainForm(Form1 form)
		{
			this.form = form;
			this.gridControl1 = form.gridControl1;
			this.splitterControl1 = form.splitterControl1;
			this.dataSet11 = form.dataSet11;
			InitializeForm();
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif		
			Form1 form = new Form1();
			MainForm main = new MainForm(form);
			Application.Run(form);
		}

		private void axWebBrowser1_NavigateComplete2(object sender, AxSHDocVw.DWebBrowserEvents2_NavigateComplete2Event e)
		{
			this.splitterControl1.ActivePane.Invalidate();
		}

		private void axWebBrowser1_ProgressChange(object sender, AxSHDocVw.DWebBrowserEvents2_ProgressChangeEvent e)
		{
			this.splitterControl1.ActivePane.Invalidate();
		}

		void InitializeForm()
		{
			// Form
            form.Text = "Web Browser Cell Demo";

			// disable splitting grid view - with this type of cell renderer,
			// only a single view is supported. 
			splitterControl1.SplitBars = DynamicSplitBars.None;

			// Web Browser
			this.axWebBrowser1 = new AxSHDocVw.AxWebBrowser();
			this.axWebBrowser1.BeginInit();

			// 
			// axWebBrowser1
			// 
			this.axWebBrowser1.Enabled = true;
			this.axWebBrowser1.Location = new System.Drawing.Point(72, 16);
			this.axWebBrowser1.Size = new System.Drawing.Size(300, 150);
			this.axWebBrowser1.TabIndex = 4;
			this.axWebBrowser1.CausesValidation = false;

			form.Controls.Add(this.axWebBrowser1);

			this.axWebBrowser1.EndInit();

			//this.axWebBrowser1.Visible = false;//.Location = new System.Drawing.Point(10000,10000);

			object url = "http://www.syncfusion.com";
			object flags = null;
			object tfn = null;
			object pd = null;
			object head = null;
			this.axWebBrowser1.Navigate2(ref url, ref flags, ref tfn, ref pd, ref head);
			this.axWebBrowser1.NavigateComplete2 += new AxSHDocVw.DWebBrowserEvents2_NavigateComplete2EventHandler(axWebBrowser1_NavigateComplete2);
			this.axWebBrowser1.ProgressChange += new AxSHDocVw.DWebBrowserEvents2_ProgressChangeEventHandler(axWebBrowser1_ProgressChange);

			// Grid
			gridControl1.BeginUpdate();
			gridControl1.AllowSelection = GridSelectionFlags.None;
			//gridControl1.CausesValidation = false;

			this.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(6, 2, 22, 10));
			this.gridControl1[6,2].CellType = "Control";
			this.gridControl1[6,2].Control = this.axWebBrowser1;

			this.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(4,2,5,6));
			this.gridControl1[4,2].Text = "Host Internet Explorer as CellType";
			this.gridControl1[4,2].Font.Facename = "Arial";
			this.gridControl1[4,2].Font.Bold = true;
			this.gridControl1[4,2].TextColor = Color.FromArgb( 255, 153, 51 );
			this.gridControl1[4,2].Font.Size = 14;
			this.gridControl1[4,2].VerticalAlignment = GridVerticalAlignment.Middle;			
			gridControl1.EndUpdate(true);
		}			
	}
}
