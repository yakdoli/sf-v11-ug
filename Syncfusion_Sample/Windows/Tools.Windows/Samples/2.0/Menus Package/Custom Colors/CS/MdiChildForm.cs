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
using Syncfusion.Windows.Forms;
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace Tutorial
{
	/// <summary>
	/// Summary description for MdiChildForm.
	/// </summary>
	public class MdiChildForm : System.Windows.Forms.Form
	{
		private Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager childFrameBarManager1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar mainMenuBar;
		private Syncfusion.Windows.Forms.Tools.XPMenus.Bar standardBar;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
		private System.Windows.Forms.ImageList imageList1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu popupMenu1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem editDropDownItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager popupMenusManager1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar xpToolBar1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem10;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem11;
        private ImageList largeImageList;
		private System.ComponentModel.IContainer components;

		public MdiChildForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			this.barItem4.Enabled = false;
			this.barItem5.Enabled = false;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiChildForm));
            this.childFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(this);
            this.mainMenuBar = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager1, "MainMenu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.editDropDownItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.standardBar = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager1, "Standard");
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.popupMenu1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.popupMenusManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager(this.components);
            this.xpToolBar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.XPToolBar();
            this.barItem11 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem10 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.largeImageList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.childFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // childFrameBarManager1
            // 
            this.childFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("childFrameBarManager1.BarPositionInfo")));
            this.childFrameBarManager1.Bars.Add(this.mainMenuBar);
            this.childFrameBarManager1.Bars.Add(this.standardBar);
            this.childFrameBarManager1.Categories.Add("Popups");
            this.childFrameBarManager1.Categories.Add("File");
            this.childFrameBarManager1.Categories.Add("Edit");
            this.childFrameBarManager1.CurrentBaseFormType = "System.Windows.Forms.Form";
            this.childFrameBarManager1.Form = this;
            this.childFrameBarManager1.ImageList = this.imageList1;
            this.childFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem2,
            this.parentBarItem1,
            this.barItem3,
            this.barItem4,
            this.editDropDownItem,
            this.barItem5,
            this.barItem6,
            this.barItem1});
            this.childFrameBarManager1.LargeImageList = this.largeImageList;
            this.childFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // mainMenuBar
            // 
            this.mainMenuBar.BarName = "MainMenu";
            this.mainMenuBar.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.mainMenuBar.Caption = "MainMenu";
            this.mainMenuBar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.editDropDownItem});
            this.mainMenuBar.Manager = this.childFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.parentBarItem1.ID = "&File";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1});
            this.parentBarItem1.Text = "&File";
            // 
            // barItem1
            // 
            this.barItem1.CategoryIndex = 1;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.barItem1.ID = "&Save";
            this.barItem1.ImageIndex = 6;
            this.barItem1.MergeOrder = 2;
            this.barItem1.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem1.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.barItem1.Text = "&Save";
            this.barItem1.Click += new System.EventHandler(this.barItem1_Click);
            // 
            // editDropDownItem
            // 
            this.editDropDownItem.CategoryIndex = 0;
            this.editDropDownItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.editDropDownItem.ID = "&Edit";
            this.editDropDownItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem6});
            this.editDropDownItem.SeparatorIndices.AddRange(new int[] {
            2});
            this.editDropDownItem.Text = "&Edit";
            // 
            // barItem2
            // 
            this.barItem2.CategoryIndex = 2;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "&Undo";
            this.barItem2.ImageIndex = 4;
            this.barItem2.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem2.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.barItem2.Text = "&Undo";
            this.barItem2.Click += new System.EventHandler(this.barItem2_Click);
            // 
            // barItem3
            // 
            this.barItem3.CategoryIndex = 2;
            this.barItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "&Redo";
            this.barItem3.ImageIndex = 5;
            this.barItem3.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem3.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
            this.barItem3.Text = "&Redo";
            this.barItem3.Click += new System.EventHandler(this.barItem3_Click);
            // 
            // barItem4
            // 
            this.barItem4.CategoryIndex = 2;
            this.barItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem4.ID = "Cu&t";
            this.barItem4.ImageIndex = 1;
            this.barItem4.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem4.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.barItem4.Text = "Cu&t";
            this.barItem4.Click += new System.EventHandler(this.cmdItem_Click);
            // 
            // barItem5
            // 
            this.barItem5.CategoryIndex = 2;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "&Copy";
            this.barItem5.ImageIndex = 0;
            this.barItem5.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem5.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.barItem5.Text = "&Copy";
            this.barItem5.Click += new System.EventHandler(this.barItem5_Click);
            // 
            // barItem6
            // 
            this.barItem6.CategoryIndex = 2;
            this.barItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem6.ID = "&Paste";
            this.barItem6.ImageIndex = 2;
            this.barItem6.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem6.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.barItem6.Text = "&Paste";
            this.barItem6.Click += new System.EventHandler(this.barItem6_Click);
            // 
            // standardBar
            // 
            this.standardBar.BarName = "Standard";
            this.standardBar.Caption = "Standard";
            this.standardBar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1});
            this.standardBar.Manager = this.childFrameBarManager1;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Calibri", 12F);
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(194)))), ((int)(((byte)(69)))));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(456, 285);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "MDI Child";
            this.popupMenusManager1.SetXPContextMenu(this.richTextBox1, this.popupMenu1);
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            this.richTextBox1.SelectionChanged += new System.EventHandler(this.TextSelectionChanged);
            // 
            // popupMenu1
            // 
            this.popupMenu1.ParentBarItem = this.editDropDownItem;
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem9,
            this.barItem7,
            this.barItem8});
            // 
            // barItem9
            // 
            this.barItem9.ID = "Cut";
            this.barItem9.ImageIndex = 1;
            this.barItem9.ImageList = this.imageList1;
            this.barItem9.Text = "Cut";
            // 
            // barItem7
            // 
            this.barItem7.ID = "Copy";
            this.barItem7.ImageIndex = 0;
            this.barItem7.ImageList = this.imageList1;
            this.barItem7.Text = "Copy";
            // 
            // barItem8
            // 
            this.barItem8.ID = "Paste";
            this.barItem8.ImageIndex = 2;
            this.barItem8.ImageList = this.imageList1;
            this.barItem8.Text = "Paste";
            // 
            // xpToolBar1
            // 
            this.xpToolBar1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(182)))), ((int)(((byte)(234))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(182)))), ((int)(((byte)(234))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(182)))), ((int)(((byte)(234))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(208)))), ((int)(((byte)(247))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(208)))), ((int)(((byte)(247)))))});
            // 
            // 
            // 
            this.xpToolBar1.Bar.BarName = "";
            this.xpToolBar1.Bar.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem2,
            this.barItem3,
            this.barItem4,
            this.barItem5,
            this.barItem6});
            this.xpToolBar1.Bar.Manager = null;
            this.xpToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.xpToolBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xpToolBar1.Location = new System.Drawing.Point(0, 285);
            this.xpToolBar1.Name = "xpToolBar1";
            this.xpToolBar1.Size = new System.Drawing.Size(456, 25);
            this.xpToolBar1.Style = Syncfusion.Windows.Forms.VisualStyle.Default;
            this.xpToolBar1.TabIndex = 1;
            this.xpToolBar1.Text = "xpToolBar1";
            // 
            // barItem11
            // 
            this.barItem11.ID = "Find";
            this.barItem11.ImageIndex = 7;
            this.barItem11.ImageList = this.imageList1;
            this.barItem11.PaintStyle = Syncfusion.Windows.Forms.Tools.XPMenus.PaintStyle.ImageAndText;
            this.barItem11.Text = "FindString";
            // 
            // barItem10
            // 
            this.barItem10.ID = "sdf";
            this.barItem10.Text = "sdf";
            // 
            // largeImageList
            // 
            this.largeImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("largeImageList.ImageStream")));
            this.largeImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.largeImageList.Images.SetKeyName(0, "");
            this.largeImageList.Images.SetKeyName(1, "");
            this.largeImageList.Images.SetKeyName(2, "");
            this.largeImageList.Images.SetKeyName(3, "");
            this.largeImageList.Images.SetKeyName(4, "");
            this.largeImageList.Images.SetKeyName(5, "");
            this.largeImageList.Images.SetKeyName(6, "");
            // 
            // MdiChildForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 20);
            this.ClientSize = new System.Drawing.Size(456, 310);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.xpToolBar1);
            this.Font = new System.Drawing.Font("Calibri", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MdiChildForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.childFrameBarManager1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		#region Editor
		private void cmdItem_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.Cut();
		}

		private void barItem2_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.Undo();
		}

		private void barItem3_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.Redo();
		}

		private void barItem5_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.Copy();
		}

		private void barItem6_Click(object sender, System.EventArgs e)
		{
			this.richTextBox1.Paste();
		}
		# endregion

		private void richTextBox1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// This method lets you show a popup menu at any give point in a control.
			// This is not necessary in this form, since the popupMenu2 is associated with the RichTextBox via the
			// PopupMenusManager
			//this.popupMenu2.Show(this.richTextBox1, new Point(e.X, e.Y));
		}
		

		private void barItem1_Click(object sender, System.EventArgs e)
		{
			string filename="";
			SaveFileDialog savefDlg = new SaveFileDialog();
			savefDlg.Filter = "text files(*.txt)|*.txt";

			if (savefDlg.ShowDialog() == DialogResult.OK)
			{
				filename = savefDlg.FileName;
				StreamWriter wstr = new StreamWriter(filename, false, System.Text.Encoding.Unicode);

				foreach(string line in richTextBox1.Lines)
					wstr.WriteLine(line);
				wstr.Close();
			}
			
		}


		private void TextSelectionChanged(object sender, System.EventArgs e)
		{
			EnableItems();
		}


		private void EnableItems()
		{
			if(richTextBox1.SelectionLength == 0)
			{
				this.barItem4.Enabled = false;
				this.barItem5.Enabled = false;
			}
			else
			{
				this.barItem4.Enabled = true;
				this.barItem5.Enabled = true;
			}
		}
	}
}
