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
using System.IO;

namespace SyntaxColoringDemo
{
	/// <summary>
	/// Summary description for Form2.
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TreeView treeView1;
		private Syncfusion.Windows.Forms.Edit.EditControl editControl1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private string BasePath = Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Test Files\Config.xml";

		public Form2()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.treeView1.ExpandAll();

			this.editControl1.LoadFile(BasePath);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form2));
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.editControl1 = new Syncfusion.Windows.Forms.Edit.EditControl();
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
			this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.treeView1.ImageIndex = -1;
			this.treeView1.ItemHeight = 20;
			this.treeView1.Name = "treeView1";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
																				  new System.Windows.Forms.TreeNode("Prebuilt Configurations", new System.Windows.Forms.TreeNode[] {
																																													   new System.Windows.Forms.TreeNode("CSharp"),
																																													   new System.Windows.Forms.TreeNode("VB.NET"),
																																													   new System.Windows.Forms.TreeNode("HTML"),
																																													   new System.Windows.Forms.TreeNode("XML"),
																																													   new System.Windows.Forms.TreeNode("Pascal"),
																																													   new System.Windows.Forms.TreeNode("SQL"),
																																													   new System.Windows.Forms.TreeNode("Java"),
																																													   new System.Windows.Forms.TreeNode("VBScript"),
																																													   new System.Windows.Forms.TreeNode("JScript"),
																																													   new System.Windows.Forms.TreeNode("Default")})});
			this.treeView1.SelectedImageIndex = -1;
			this.treeView1.Size = new System.Drawing.Size(176, 430);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// editControl1
			// 
			this.editControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.editControl1.ChangedLinesMarkingLineColor = System.Drawing.Color.Yellow;
			this.editControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.editControl1.GraphicsTextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
			this.editControl1.Location = new System.Drawing.Point(176, 0);
			this.editControl1.Name = "editControl1";
			this.editControl1.SharedFileMode = true;
			this.editControl1.ShowHorizontalSplitters = false;
			this.editControl1.ShowIndicatorMargin = false;
			this.editControl1.ShowSelectionMargin = false;
			this.editControl1.ShowVerticalSplitters = false;
			this.editControl1.Size = new System.Drawing.Size(528, 430);
			this.editControl1.StatusBarSettings.EncodingPanel.MinWidth = 0;
			this.editControl1.StatusBarSettings.StatusPanel.MinWidth = 70;
			this.editControl1.StatusBarSettings.TextPanel.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring;
			this.editControl1.TabIndex = 1;
			this.editControl1.Text = "";
			this.editControl1.TransferFocusOnTab = true;
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(704, 430);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.editControl1,
																		  this.treeView1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.Text = "Configuration Settings Display";
			((System.ComponentModel.ISupportInitialize)(this.editControl1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			switch (this.treeView1.SelectedNode.Text)
			{
				case "CSharp" :
					this.editControl1.GoTo(168,3);
					break;
				case "HTML" :
					this.editControl1.GoTo(834,3);
					break;
				case "XML" :
					this.editControl1.GoTo(734,3);
					break;
				case "Pascal" :
					this.editControl1.GoTo(589,3);
					break;
				case "VB.NET" :
					this.editControl1.GoTo(1697,3);
					break;
				case "SQL" :
					this.editControl1.GoTo(1945,3);
					break;
				case "Java" :
					this.editControl1.GoTo(3209,3);
					break;
				case "Default" :
					this.editControl1.GoTo(3,2);
					break;
				case "VBScript" :
					this.editControl1.GoTo(3346,3);
					break;
				case "JScript" :
					this.editControl1.GoTo(3772,3);
					break;
			}
		}
	}
}
