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
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Drawing;

namespace TreeViewAdvStyles
{
	# region Class Form1 Description
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		#region Variable Declaration
		private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		#region Form Constructor Initialization and Disposing
		
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			#region Base Style
			// This code shows how to get and modify a Base Style from the BaseStyle's hash.
			// Synthesize a TextColor for these styles based on their BackColor:
			TreeNodeAdvStyleInfo panthers = this.treeViewAdv1.BaseStyles["Panthers"] as TreeNodeAdvStyleInfo;
			panthers.TextColor = this.GetGoodForeColor(panthers.Background.BackColor);

			TreeNodeAdvStyleInfo packers = this.treeViewAdv1.BaseStyles["Packers"]  as TreeNodeAdvStyleInfo;
			packers.TextColor = this.GetGoodForeColor(packers.Background.BackColor);

			TreeNodeAdvStyleInfo redSkins = this.treeViewAdv1.BaseStyles["Redskins"]  as TreeNodeAdvStyleInfo;
			redSkins.TextColor = this.GetGoodForeColor(redSkins.Background.BackColor);

			TreeNodeAdvStyleInfo chiefs = this.treeViewAdv1.BaseStyles["Chiefs"]  as TreeNodeAdvStyleInfo;
			chiefs.TextColor = this.GetGoodForeColor(chiefs.Background.BackColor);

			TreeNodeAdvStyleInfo vikings = this.treeViewAdv1.BaseStyles["Vikings"] as TreeNodeAdvStyleInfo;
			vikings.TextColor = this.GetGoodForeColor(vikings.Background.BackColor);
			#endregion
		}

		#region Get the Good Forecolor based on the Back Color

		private Color GetGoodForeColor(Color backColor)
		{
			Color goodTextColor = SystemColors.ControlText;
			DrawingUtils.AdjustForeColorBrightnessForBackColor(ref goodTextColor, backColor, 0.75f);
			return goodTextColor;
		}
		#endregion

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
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo3 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo4 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo5 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo6 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo7 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv2 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv3 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv4 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv5 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv6 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv7 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv8 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv9 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv10 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv11 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv12 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv13 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv14 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv15 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv16 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv17 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv18 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			Syncfusion.Windows.Forms.Tools.TreeNodeAdv treeNodeAdv19 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdv();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
			((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
			this.SuspendLayout();
			// 
			// treeViewAdv1
			// 
			this.treeViewAdv1.ActiveNode = null;
			this.treeViewAdv1.AllowDrop = true;
			this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((System.Byte)(196)), ((System.Byte)(214)), ((System.Byte)(233))));
			treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
			treeNodeAdvStyleInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			treeNodeAdvStyleInfo2.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(51))));
			treeNodeAdvStyleInfo2.EnsureDefaultOptionedChild = true;
			treeNodeAdvStyleInfo2.TextColor = System.Drawing.Color.White;
			treeNodeAdvStyleInfo3.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((System.Byte)(238)), ((System.Byte)(122)), ((System.Byte)(3))));
			treeNodeAdvStyleInfo3.EnsureDefaultOptionedChild = true;
			treeNodeAdvStyleInfo4.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((System.Byte)(225)), ((System.Byte)(150)), ((System.Byte)(1))));
			treeNodeAdvStyleInfo4.EnsureDefaultOptionedChild = true;
			treeNodeAdvStyleInfo5.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(110)), ((System.Byte)(152))));
			treeNodeAdvStyleInfo5.EnsureDefaultOptionedChild = true;
			treeNodeAdvStyleInfo6.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((System.Byte)(218)), ((System.Byte)(229)), ((System.Byte)(245))));
			treeNodeAdvStyleInfo6.EnsureDefaultOptionedChild = true;
			treeNodeAdvStyleInfo7.Background = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((System.Byte)(133)), ((System.Byte)(191)), ((System.Byte)(117))));
			treeNodeAdvStyleInfo7.EnsureDefaultOptionedChild = true;
			this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
																											 new Syncfusion.Windows.Forms.Tools.StyleNamePair("NodeLevel3", treeNodeAdvStyleInfo1),
																											 new Syncfusion.Windows.Forms.Tools.StyleNamePair("Redskins", treeNodeAdvStyleInfo2),
																											 new Syncfusion.Windows.Forms.Tools.StyleNamePair("Panthers", treeNodeAdvStyleInfo3),
																											 new Syncfusion.Windows.Forms.Tools.StyleNamePair("Chiefs", treeNodeAdvStyleInfo4),
																											 new Syncfusion.Windows.Forms.Tools.StyleNamePair("Vikings", treeNodeAdvStyleInfo5),
																											 new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo6),
																											 new Syncfusion.Windows.Forms.Tools.StyleNamePair("Packers", treeNodeAdvStyleInfo7)});
			this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
			// 
			// treeViewAdv1.HelpTextControl
			// 
			this.treeViewAdv1.HelpTextControl.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(732, 0);
			this.treeViewAdv1.HelpTextControl.Name = "helpText";
			this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(50, 17);
			this.treeViewAdv1.HelpTextControl.TabIndex = 0;
			this.treeViewAdv1.HelpTextControl.Text = "help text";
			this.treeViewAdv1.Name = "treeViewAdv1";
			treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv1.ChildStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			treeNodeAdv1.ChildStyle.TextColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(128)), ((System.Byte)(128)));
			treeNodeAdv1.EnsureDefaultOptionedChild = true;
			treeNodeAdv1.Expanded = true;
			treeNodeAdv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv2.ChildStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			treeNodeAdv2.EnsureDefaultOptionedChild = true;
			treeNodeAdv2.Expanded = true;
			treeNodeAdv3.BaseStyle = "Panthers";
			treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv3.EnsureDefaultOptionedChild = true;
			treeNodeAdv3.Optioned = true;
			treeNodeAdv3.ShowPlusOnExpand = false;
			treeNodeAdv3.Text = "Jake Dellhomme";
			treeNodeAdv4.BaseStyle = "Packers";
			treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv4.EnsureDefaultOptionedChild = true;
			treeNodeAdv4.ShowPlusOnExpand = false;
			treeNodeAdv4.Text = "Brett Favre";
			treeNodeAdv5.BaseStyle = "Redskins";
			treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv5.EnsureDefaultOptionedChild = true;
			treeNodeAdv5.ShowPlusOnExpand = false;
			treeNodeAdv5.Text = "Patrick Ramsey";
			treeNodeAdv6.BaseStyle = "Chiefs";
			treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv6.EnsureDefaultOptionedChild = true;
			treeNodeAdv6.ShowPlusOnExpand = false;
			treeNodeAdv6.Text = "Trent Green";
			treeNodeAdv7.BaseStyle = "Vikings";
			treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv7.EnsureDefaultOptionedChild = true;
			treeNodeAdv7.ShowPlusOnExpand = false;
			treeNodeAdv7.Text = "Daunte Culpepper";
			treeNodeAdv2.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
																							 treeNodeAdv3,
																							 treeNodeAdv4,
																							 treeNodeAdv5,
																							 treeNodeAdv6,
																							 treeNodeAdv7});
			treeNodeAdv2.Optioned = true;
			treeNodeAdv2.ShowPlusOnExpand = false;
			treeNodeAdv2.Text = "Quarterbacks";
			treeNodeAdv2.TextColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(21)), ((System.Byte)(84)));
			treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv8.EnsureDefaultOptionedChild = true;
			treeNodeAdv8.Expanded = true;
			treeNodeAdv9.BaseStyle = "Panthers";
			treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv9.EnsureDefaultOptionedChild = true;
			treeNodeAdv9.Optioned = true;
			treeNodeAdv9.ShowPlusOnExpand = false;
			treeNodeAdv9.Text = "Stephen Davis";
			treeNodeAdv10.BaseStyle = "Packers";
			treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv10.EnsureDefaultOptionedChild = true;
			treeNodeAdv10.ShowPlusOnExpand = false;
			treeNodeAdv10.Text = "Ahman Green";
			treeNodeAdv11.BaseStyle = "Chiefs";
			treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv11.EnsureDefaultOptionedChild = true;
			treeNodeAdv11.ShowPlusOnExpand = false;
			treeNodeAdv11.Text = "Priest Holmes";
			treeNodeAdv12.BaseStyle = "Redskins";
			treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv12.EnsureDefaultOptionedChild = true;
			treeNodeAdv12.ShowPlusOnExpand = false;
			treeNodeAdv12.Text = "Trung Canidate";
			treeNodeAdv13.BaseStyle = "Vikings";
			treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv13.EnsureDefaultOptionedChild = true;
			treeNodeAdv13.ShowPlusOnExpand = false;
			treeNodeAdv13.Text = "Mo Lewis";
			treeNodeAdv8.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
																							 treeNodeAdv9,
																							 treeNodeAdv10,
																							 treeNodeAdv11,
																							 treeNodeAdv12,
																							 treeNodeAdv13});
			treeNodeAdv8.ShowPlusOnExpand = false;
			treeNodeAdv8.Text = "Runningbacks";
			treeNodeAdv8.TextColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(21)), ((System.Byte)(84)));
			treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv14.EnsureDefaultOptionedChild = true;
			treeNodeAdv14.Expanded = true;
			treeNodeAdv15.BaseStyle = "Panthers";
			treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv15.EnsureDefaultOptionedChild = true;
			treeNodeAdv15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			treeNodeAdv15.Optioned = true;
			treeNodeAdv15.ShowPlusOnExpand = false;
			treeNodeAdv15.Text = "Steve Smith";
			treeNodeAdv16.BaseStyle = "Vikings";
			treeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv16.EnsureDefaultOptionedChild = true;
			treeNodeAdv16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			treeNodeAdv16.ShowPlusOnExpand = false;
			treeNodeAdv16.Text = "Randy Moss";
			treeNodeAdv17.BaseStyle = "Chiefs";
			treeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv17.EnsureDefaultOptionedChild = true;
			treeNodeAdv17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			treeNodeAdv17.ShowPlusOnExpand = false;
			treeNodeAdv17.Text = "Dante Hall";
			treeNodeAdv18.BaseStyle = "Redskins";
			treeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv18.EnsureDefaultOptionedChild = true;
			treeNodeAdv18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			treeNodeAdv18.ShowPlusOnExpand = false;
			treeNodeAdv18.Text = "Rod Gardner";
			treeNodeAdv19.BaseStyle = "Packers";
			treeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = true;
			treeNodeAdv19.EnsureDefaultOptionedChild = true;
			treeNodeAdv19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			treeNodeAdv19.ShowPlusOnExpand = false;
			treeNodeAdv19.Text = "Antonio Freeman";
			treeNodeAdv14.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
																							  treeNodeAdv15,
																							  treeNodeAdv16,
																							  treeNodeAdv17,
																							  treeNodeAdv18,
																							  treeNodeAdv19});
			treeNodeAdv14.ShowPlusOnExpand = false;
			treeNodeAdv14.Text = "Receivers";
			treeNodeAdv14.TextColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(21)), ((System.Byte)(84)));
			treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
																							 treeNodeAdv2,
																							 treeNodeAdv8,
																							 treeNodeAdv14});
			treeNodeAdv1.ShowPlusOnExpand = false;
			treeNodeAdv1.Text = "NFL Top 5 2003 MVPs";
			treeNodeAdv1.TextColor = System.Drawing.Color.Magenta;
			this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
																								  treeNodeAdv1});
			this.treeViewAdv1.PathSeparator = "/";
			this.treeViewAdv1.Size = new System.Drawing.Size(264, 326);
			this.treeViewAdv1.TabIndex = 0;
			this.treeViewAdv1.Text = "treeViewAdv1";
			// 
			// treeViewAdv1.ToolTipControl
			// 
			this.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
			this.treeViewAdv1.ToolTipControl.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
			this.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.treeViewAdv1.ToolTipControl.Location = new System.Drawing.Point(642, 0);
			this.treeViewAdv1.ToolTipControl.Name = "toolTip";
			this.treeViewAdv1.ToolTipControl.Size = new System.Drawing.Size(41, 17);
			this.treeViewAdv1.ToolTipControl.TabIndex = 1;
			this.treeViewAdv1.ToolTipControl.Text = "toolTip";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(264, 326);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.treeViewAdv1});
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TreeViewAdv Styles";
			((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		#region Main Function Definition

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		#endregion
	}
#endregion
}
