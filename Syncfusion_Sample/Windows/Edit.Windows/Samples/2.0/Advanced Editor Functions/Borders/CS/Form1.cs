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
using System.IO;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Windows.Forms.Edit;
using Syncfusion.Windows.Forms.Edit.Implementation.Formatting;
using Syncfusion.Windows.Forms.Edit.Implementation.IO;
using Syncfusion.Windows.Forms.Edit.Implementation.Config;
using Syncfusion.Windows.Forms.Edit.Implementation.Parser;
using Syncfusion.Windows.Forms.Edit.Interfaces;
using Syncfusion.Windows.Forms.Edit.Utils;
using Syncfusion.Windows.Forms.Edit.Enums;

namespace BordersDemo
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
		private System.Windows.Forms.MenuItem menuItem9;
		private System.Windows.Forms.MenuItem menuItem23;
		private System.Windows.Forms.MenuItem menuItem24;
		private System.Windows.Forms.MenuItem menuItem25;
		private System.Windows.Forms.MenuItem menuItem26;
		private System.Windows.Forms.MenuItem menuItem27;
		private System.Windows.Forms.MenuItem menuItem28;
		private System.Windows.Forms.MenuItem menuItem29;
		private System.Windows.Forms.MenuItem menuItem30;
		private System.Windows.Forms.MenuItem menuItem31;
		
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private string filePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\Test.cs";

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.editControl1.LoadFile(filePath);
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
			this.menuItem31 = new System.Windows.Forms.MenuItem();
			this.menuItem8 = new System.Windows.Forms.MenuItem();
			this.menuItem12 = new System.Windows.Forms.MenuItem();
			this.menuItem13 = new System.Windows.Forms.MenuItem();
			this.menuItem21 = new System.Windows.Forms.MenuItem();
			this.menuItem14 = new System.Windows.Forms.MenuItem();
			this.menuItem15 = new System.Windows.Forms.MenuItem();
			this.menuItem16 = new System.Windows.Forms.MenuItem();
			this.menuItem22 = new System.Windows.Forms.MenuItem();
			this.menuItem17 = new System.Windows.Forms.MenuItem();
			this.menuItem18 = new System.Windows.Forms.MenuItem();
			this.menuItem19 = new System.Windows.Forms.MenuItem();
			this.menuItem20 = new System.Windows.Forms.MenuItem();
			this.menuItem26 = new System.Windows.Forms.MenuItem();
			this.menuItem27 = new System.Windows.Forms.MenuItem();
			this.menuItem28 = new System.Windows.Forms.MenuItem();
			this.menuItem29 = new System.Windows.Forms.MenuItem();
			this.menuItem30 = new System.Windows.Forms.MenuItem();
			this.menuItem10 = new System.Windows.Forms.MenuItem();
			this.menuItem9 = new System.Windows.Forms.MenuItem();
			this.menuItem23 = new System.Windows.Forms.MenuItem();
			this.menuItem11 = new System.Windows.Forms.MenuItem();
			this.menuItem24 = new System.Windows.Forms.MenuItem();
			this.menuItem25 = new System.Windows.Forms.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// editControl1
			// 
			this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editControl1.Name = "editControl1";
			this.editControl1.Size = new System.Drawing.Size(542, 445);
			this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
			this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.editControl1.TabIndex = 0;
			this.editControl1.Text = "edtCode";
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuItem1,
																					  this.menuItem12,
																					  this.menuItem17,
																					  this.menuItem26,
																					  this.menuItem10,
																					  this.menuItem11});
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
																					  this.menuItem31,
																					  this.menuItem8});
			this.menuItem1.Text = "&File";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "&New";
			this.menuItem2.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 1;
			this.menuItem3.Text = "&Open";
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
			this.menuItem5.Text = "&Save";
			this.menuItem5.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem6
			// 
			this.menuItem6.Index = 4;
			this.menuItem6.Text = "Save&As";
			this.menuItem6.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem7
			// 
			this.menuItem7.Index = 5;
			this.menuItem7.Text = "-";
			// 
			// menuItem31
			// 
			this.menuItem31.Index = 6;
			this.menuItem31.Text = "Close";
			this.menuItem31.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem8
			// 
			this.menuItem8.Index = 7;
			this.menuItem8.Text = "E&xit";
			this.menuItem8.Click += new System.EventHandler(this.MainMenuClick);
			// 
			// menuItem12
			// 
			this.menuItem12.Index = 1;
			this.menuItem12.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem13,
																					   this.menuItem21,
																					   this.menuItem14,
																					   this.menuItem15,
																					   this.menuItem16,
																					   this.menuItem22});
			this.menuItem12.Text = "BorderStyle";
			// 
			// menuItem13
			// 
			this.menuItem13.Index = 0;
			this.menuItem13.Text = "Dash";
			this.menuItem13.Click += new System.EventHandler(this.BorderStyle_Click);
			// 
			// menuItem21
			// 
			this.menuItem21.Index = 1;
			this.menuItem21.Text = "Dot";
			this.menuItem21.Click += new System.EventHandler(this.BorderStyle_Click);
			// 
			// menuItem14
			// 
			this.menuItem14.Index = 2;
			this.menuItem14.Text = "DotDash";
			this.menuItem14.Click += new System.EventHandler(this.BorderStyle_Click);
			// 
			// menuItem15
			// 
			this.menuItem15.Index = 3;
			this.menuItem15.Text = "Solid";
			this.menuItem15.Click += new System.EventHandler(this.BorderStyle_Click);
			// 
			// menuItem16
			// 
			this.menuItem16.Index = 4;
			this.menuItem16.Text = "Wave";
			this.menuItem16.Click += new System.EventHandler(this.BorderStyle_Click);
			// 
			// menuItem22
			// 
			this.menuItem22.Index = 5;
			this.menuItem22.Text = "None";
			this.menuItem22.Click += new System.EventHandler(this.BorderStyle_Click);
			// 
			// menuItem17
			// 
			this.menuItem17.Index = 2;
			this.menuItem17.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem18,
																					   this.menuItem19,
																					   this.menuItem20});
			this.menuItem17.Text = "BorderWeight";
			// 
			// menuItem18
			// 
			this.menuItem18.Index = 0;
			this.menuItem18.Text = "Thin";
			this.menuItem18.Click += new System.EventHandler(this.BorderWeight_Click);
			// 
			// menuItem19
			// 
			this.menuItem19.Index = 1;
			this.menuItem19.Text = "Double";
			this.menuItem19.Click += new System.EventHandler(this.BorderWeight_Click);
			// 
			// menuItem20
			// 
			this.menuItem20.Index = 2;
			this.menuItem20.Text = "Bold";
			this.menuItem20.Click += new System.EventHandler(this.BorderWeight_Click);
			// 
			// menuItem26
			// 
			this.menuItem26.Index = 3;
			this.menuItem26.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem27,
																					   this.menuItem28,
																					   this.menuItem29,
																					   this.menuItem30});
			this.menuItem26.Text = "BorderColor";
			// 
			// menuItem27
			// 
			this.menuItem27.Index = 0;
			this.menuItem27.Text = "Aqua";
			this.menuItem27.Click += new System.EventHandler(this.BorderColor_Click);
			// 
			// menuItem28
			// 
			this.menuItem28.Index = 1;
			this.menuItem28.Text = "Navy";
			this.menuItem28.Click += new System.EventHandler(this.BorderColor_Click);
			// 
			// menuItem29
			// 
			this.menuItem29.Index = 2;
			this.menuItem29.Text = "Khaki";
			this.menuItem29.Click += new System.EventHandler(this.BorderColor_Click);
			// 
			// menuItem30
			// 
			this.menuItem30.Index = 3;
			this.menuItem30.Text = "Salmon";
			this.menuItem30.Click += new System.EventHandler(this.BorderColor_Click);
			// 
			// menuItem10
			// 
			this.menuItem10.Index = 4;
			this.menuItem10.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem9,
																					   this.menuItem23});
			this.menuItem10.Text = "SetTextBorder";
			// 
			// menuItem9
			// 
			this.menuItem9.Index = 0;
			this.menuItem9.Text = "Selected Text";
			this.menuItem9.Click += new System.EventHandler(this.menuItem9_Click_1);
			// 
			// menuItem23
			// 
			this.menuItem23.Index = 1;
			this.menuItem23.Text = "Specify Text Range";
			this.menuItem23.Click += new System.EventHandler(this.menuItem23_Click);
			// 
			// menuItem11
			// 
			this.menuItem11.Index = 5;
			this.menuItem11.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					   this.menuItem24,
																					   this.menuItem25});
			this.menuItem11.Text = "RemoveTextBorder";
			// 
			// menuItem24
			// 
			this.menuItem24.Index = 0;
			this.menuItem24.Text = "Selected Text";
			this.menuItem24.Click += new System.EventHandler(this.menuItem24_Click);
			// 
			// menuItem25
			// 
			this.menuItem25.Index = 1;
			this.menuItem25.Text = "Specify Text Range";
			this.menuItem25.Click += new System.EventHandler(this.menuItem25_Click);
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
			this.Text = "Borders";
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

		

		private FrameBorderStyle borderstyle = FrameBorderStyle.Dash;
		private void BorderStyle_Click(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "Dash" :
					this.borderstyle = FrameBorderStyle.Dash;
					break;
				case "DotDash" :
					this.borderstyle = FrameBorderStyle.DashDot;
					break;
				case "Dot" :
					this.borderstyle = FrameBorderStyle.Dot;
					break;
				case "Solid" :
					this.borderstyle = FrameBorderStyle.Solid;
					break;
				case "Wave" :
					this.borderstyle = FrameBorderStyle.Wave;
					break;
				case "None" :
					this.borderstyle = FrameBorderStyle.None;
					break;
			}
		}

		private BorderWeight weight = BorderWeight.Thin;
		private void BorderWeight_Click(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "Thin" :
					this.weight = BorderWeight.Thin;
					break;
				case "Bold" :
					this.weight = BorderWeight.Bold;
					break;
				case "Double" :
					this.weight = BorderWeight.Double;
					break;
			}
		}

		private void menuItem9_Click_1(object sender, System.EventArgs e)
		{
            if (editControl1.SelectedText != String.Empty)
            {
                // Set borders to the selected text
                this.editControl1.SetTextBorder(this.editControl1.Selection.Top, this.editControl1.Selection.Bottom, color, this.borderstyle, this.weight);
            }
            else
                MessageBox.Show("Please select text.");
		}

		private void menuItem23_Click(object sender, System.EventArgs e)
		{
			Form2 dialog = new Form2(this);
			if(DialogResult.OK == dialog.ShowDialog())
			{
				int startline = dialog.startLine;
				int startcolumn = dialog.startColumn;

                CoordinatePoint startCoordinatePoint;
                CoordinatePoint endCoordinatePoint;	

				int endline = dialog.endLine;
				int endcolumn = dialog.endColumn;

                if ((startcolumn * startline * endcolumn * endline) == 0)
                {
                    MessageBox.Show(" Zero is not valid line number or column number");
                    return;
                }

                if (endcolumn < startcolumn)
                {
                    int temp= endcolumn;
                    endcolumn = startcolumn;
                    startcolumn = temp;
                }
                if (endline < startline)
                {
                    int temp = endline;
                    endline = startline;
                    startline = temp;
                }

                if ((startline < this.editControl1.PhysicalLineCount) && (endline < this.editControl1.PhysicalLineCount))
                {
                    if ((endcolumn < this.editControl1.GetLine(endline).LineLength) && (startcolumn < this.editControl1.GetLine(startline).LineLength))
                    {
                        // Creating the associated CoordinatePoints that indicate the text range                       
                       
                        startCoordinatePoint = this.editControl1.ConvertVirtualPointToCoordinatePoint(startcolumn, startline);
                        endCoordinatePoint = this.editControl1.ConvertVirtualPointToCoordinatePoint(endcolumn, endline);                      

                        // Set borders to the specified text range
                        this.editControl1.SetTextBorder(startCoordinatePoint, endCoordinatePoint, color, this.borderstyle, this.weight);
                    }
                    else
                    {
                        MessageBox.Show(this, "Starting or Ending column number is greater than the number of Columns in the line", "Wrong Column Number", MessageBoxButtons.OK);
                    }

                }
                else
                {
                    MessageBox.Show(this, "Starting or Ending line number is greater than the number of lines in EditControl", "Wrong Line Number", MessageBoxButtons.OK);
                }
			}
		
		}
		public int PhysicalLineCount
		{
		 get
			{
			 return this.editControl1.PhysicalLineCount;
			}
		}
		public int GetLineLength(int line)
		{
			return this.editControl1.GetLine(line).LineLength;
		}
		private void menuItem24_Click(object sender, System.EventArgs e)
		{
            if(this.editControl1.Selection!=null)
			// Remove borders from the selected text
			this.editControl1.RemoveTextBorder(this.editControl1.Selection.Top, this.editControl1.Selection.Bottom);
        else
            MessageBox.Show("Please select text containing border.");
		}

		private void menuItem25_Click(object sender, System.EventArgs e)
		{
			Form2 dialog = new Form2(this);
			if(DialogResult.OK == dialog.ShowDialog())
			{

				int startline = dialog.startLine;
				int startcolumn = dialog.startColumn;

                CoordinatePoint startCoordinatePoint;
                CoordinatePoint endCoordinatePoint;	

				int endline=dialog.endLine;
				int endcolumn=dialog.endColumn;

                if ((startcolumn * startline * endcolumn * endline) == 0)
                {
                    MessageBox.Show(" Zero is not valid line number or column number");
                    return;
                }

                if (endcolumn < startcolumn)
                {
                    int temp = endcolumn;
                    endcolumn = startcolumn;
                    startcolumn = temp;
                }
                if (endline < startline)
                {
                    int temp = endline;
                    endline = startline;
                    startline = temp;
                }


                if ((startline < this.editControl1.PhysicalLineCount) && (endline < this.editControl1.PhysicalLineCount))
				{
					if((endcolumn < this.editControl1.GetLine(endline).LineLength)&& (startcolumn < this.editControl1.GetLine(startline).LineLength))
					{
						// Creating the associated CoordinatePoints that indicate the text range
                        startCoordinatePoint = this.editControl1.ConvertVirtualPointToCoordinatePoint(startcolumn, startline);
                        endCoordinatePoint = this.editControl1.ConvertVirtualPointToCoordinatePoint(endcolumn, endline);                       

						// Remove borders to the specified text range
						this.editControl1.RemoveTextBorder(startCoordinatePoint, endCoordinatePoint); 
					}
					else
					{
						MessageBox.Show(this,"Starting or Ending column number is greater than the number of Columns in the line","Wrong Column Number",MessageBoxButtons.OK);
					}

				}
				else
				{
					MessageBox.Show(this,"Starting or Ending line number is greater than the number of lines in EditControl","Wrong Line Number",MessageBoxButtons.OK);
				}
			}
		}

		private Color color = Color.Aqua;
		private void BorderColor_Click(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "Aqua" :
					this.color = Color.Aqua;
					break;
				case "Navy" :
					this.color = Color.Navy;
					break;
				case "Khaki" :
					this.color = Color.Khaki;
					break;
				case "Salmon" :
					this.color = Color.Salmon;
					break;
			}
		}

		private void MainMenuClick(object sender, System.EventArgs e)
		{
			MenuItem mi = sender as MenuItem;

			switch (mi.Text)
			{
				case "&New" :
					this.editControl1.NewFile();
					break;
				case "&Open" :
					this.editControl1.LoadFile();
					break;
				case "&Save" :
					this.editControl1.Save();
					break;
				case "Save&As" :
					this.editControl1.SaveAs();
					break;
				case "Close" :
					this.editControl1.Close();
					break;
				case "E&xit" :
					this.Close();
					break;
			}
		}
	}
}
