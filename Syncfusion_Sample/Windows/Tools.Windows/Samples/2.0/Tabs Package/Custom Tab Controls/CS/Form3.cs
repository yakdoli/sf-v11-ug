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

namespace CustomTabControls
{
	/// <summary>
	/// Summary description for Form3.
	/// </summary>
	public class Form3 : System.Windows.Forms.Form
	{
		private DemoTabControl tabControlAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
		private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv3;
		private Syncfusion.Reflection.TypeLoader designTimeTabTypeLoader;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components;

		public Form3()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form3));
			this.tabControlAdv1 = new CustomTabControls.DemoTabControl();
			this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
			this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
			this.tabPageAdv3 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
			this.designTimeTabTypeLoader = new Syncfusion.Reflection.TypeLoader(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
			this.tabControlAdv1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControlAdv1
			// 
			this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.FromArgb(((System.Byte)(218)), ((System.Byte)(229)), ((System.Byte)(245)));
			this.tabControlAdv1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.tabControlAdv1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(237)), ((System.Byte)(240)), ((System.Byte)(246)));
			this.tabControlAdv1.Controls.AddRange(new System.Windows.Forms.Control[] {
																						 this.tabPageAdv1,
																						 this.tabPageAdv2,
																						 this.tabPageAdv3});
			this.tabControlAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tabControlAdv1.InactiveTabColor = System.Drawing.Color.FromArgb(((System.Byte)(132)), ((System.Byte)(161)), ((System.Byte)(195)));
			this.tabControlAdv1.Location = new System.Drawing.Point(16, 64);
			this.tabControlAdv1.Name = "tabControlAdv1";
			this.tabControlAdv1.Size = new System.Drawing.Size(264, 152);
			this.tabControlAdv1.TabIndex = 0;
			this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.White;
			this.tabControlAdv1.TabStyle = typeof(CustomTabControls.DemoTabsRenderer);
			// 
			// tabPageAdv1
			// 
			this.tabPageAdv1.Location = new System.Drawing.Point(1, 34);
			this.tabPageAdv1.Name = "tabPageAdv1";
			this.tabPageAdv1.Size = new System.Drawing.Size(261, 116);
			this.tabPageAdv1.TabIndex = 0;
			this.tabPageAdv1.Text = "C#";
			// 
			// tabPageAdv2
			// 
			this.tabPageAdv2.Location = new System.Drawing.Point(1, 34);
			this.tabPageAdv2.Name = "tabPageAdv2";
			this.tabPageAdv2.Size = new System.Drawing.Size(261, 116);
			this.tabPageAdv2.TabIndex = 1;
			this.tabPageAdv2.Text = "VB";
			// 
			// tabPageAdv3
			// 
			this.tabPageAdv3.Location = new System.Drawing.Point(1, 34);
			this.tabPageAdv3.Name = "tabPageAdv3";
			this.tabPageAdv3.Size = new System.Drawing.Size(261, 116);
			this.tabPageAdv3.TabIndex = 2;
			this.tabPageAdv3.Text = "Description";
			// 
			// designTimeTabTypeLoader
			// 
			this.designTimeTabTypeLoader.TypesToLoadList.Add(new Syncfusion.Reflection.TypeName("CustomTabControls.DemoTabsRenderer"));
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Location = new System.Drawing.Point(16, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 40);
			this.label1.TabIndex = 1;
			this.label1.Text = "Custom renderer Flat Look Tabs";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(32, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 48);
			this.label2.TabIndex = 3;
			this.label2.Text = "Build this project for the tab to appear properly in this designer.";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label2.Visible = false;
			// 
			// Form3
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(296, 237);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.label2,
																		  this.label1,
																		  this.tabControlAdv1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form3";
			this.Text = "Custom Tabs: Flat Look";
			((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
			this.tabControlAdv1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
	}
}
