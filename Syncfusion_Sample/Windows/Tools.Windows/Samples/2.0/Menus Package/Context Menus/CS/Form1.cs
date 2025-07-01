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

namespace XPToolbarsAndContextMenus
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	using Syncfusion.Windows.Forms.Tools;
	using Syncfusion.Windows.Forms.Tools.XPMenus;
	using Syncfusion.Windows.Forms;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Office2007Form
    {
		private System.Windows.Forms.GroupBox groupBox1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager popupMenusManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private System.Windows.Forms.ImageList imageList1;
		private Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu popupMenu2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem copyItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem cutItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem pasteItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem undoItem;
		private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem redoItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem fontColorItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem aboutItem;
        private System.Windows.Forms.TextBox textBox1;
        private PopupControlContainer popupControlContainer1;
        private ColorPickerUIAdv colorPickerUIAdv1;
        private ComboBox comboBox1;
        private Label label1;
		private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            comboBox1.SelectedIndex = 3;

            colorPickerUIAdv1.MoreColorsButton.Visible = false;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.colorPickerUIAdv1 = new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv();
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.popupMenusManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenusManager(this.components);
            this.popupMenu2 = new Syncfusion.Windows.Forms.Tools.XPMenus.PopupMenu(this.components);
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.copyItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cutItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.pasteItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.undoItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.redoItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fontColorItem = new Syncfusion.Windows.Forms.Tools.XPMenus.DropDownBarItem();
            this.aboutItem = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.popupControlContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.popupControlContainer1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PopupMenus";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(6, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(504, 196);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.popupMenusManager1.SetXPContextMenu(this.textBox1, this.popupMenu2);
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.Controls.Add(this.colorPickerUIAdv1);
            this.popupControlContainer1.Location = new System.Drawing.Point(299, 19);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.Size = new System.Drawing.Size(174, 193);
            this.popupControlContainer1.TabIndex = 3;
            // 
            // colorPickerUIAdv1.RecentGroup
            // 
            this.colorPickerUIAdv1.RecentGroup.Name = "RecentColors";
            this.colorPickerUIAdv1.RecentGroup.Visible = false;
            // 
            // colorPickerUIAdv1.StandardGroup
            // 
            this.colorPickerUIAdv1.StandardGroup.Name = "StandardColors";
            // 
            // colorPickerUIAdv1.ThemeGroup
            // 
            this.colorPickerUIAdv1.ThemeGroup.IsSubItemsVisible = true;
            this.colorPickerUIAdv1.ThemeGroup.Name = "ThemeColors";
            // 
            // colorPickerUIAdv1
            // 
            this.colorPickerUIAdv1.ColorItemSize = new System.Drawing.Size(13, 13);
            this.colorPickerUIAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPickerUIAdv1.Location = new System.Drawing.Point(0, 0);
            this.colorPickerUIAdv1.MinimumSize = new System.Drawing.Size(136, 195);
            this.colorPickerUIAdv1.Name = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.Size = new System.Drawing.Size(174, 195);
            this.colorPickerUIAdv1.TabIndex = 0;
            this.colorPickerUIAdv1.Text = "colorPickerUIAdv1";
            this.colorPickerUIAdv1.ItemSelection += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_ItemSelection);
            this.colorPickerUIAdv1.Picked += new Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventHandler(this.colorPickerUIAdv1_Picked);
            // 
            // popupMenusManager1
            // 
            this.popupMenusManager1.ParentForm = this;
            // 
            // popupMenu2
            // 
            this.popupMenu2.ParentBarItem = this.parentBarItem2;
            this.popupMenu2.BeforePopup += new Syncfusion.Windows.Forms.CancelMouseEventHandler(this.popupMenu2_BeforePopup);
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem2.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.copyItem,
            this.cutItem,
            this.pasteItem,
            this.undoItem,
            this.redoItem,
            this.fontColorItem,
            this.aboutItem});
            this.parentBarItem2.SeparatorIndices.AddRange(new int[] {
            3,
            5,
            6});
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // copyItem
            // 
            this.copyItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyItem.ID = "&Copy";
            this.copyItem.ImageIndex = 1;
            this.copyItem.ImageList = this.imageList1;
            this.copyItem.Text = "&Copy";
            this.copyItem.Click += new System.EventHandler(this.copyItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "CutHS.png");
            this.imageList1.Images.SetKeyName(1, "CopyHS.png");
            this.imageList1.Images.SetKeyName(2, "PasteHS.png");
            this.imageList1.Images.SetKeyName(3, "Edit_RedoHS.png");
            this.imageList1.Images.SetKeyName(4, "Edit_UndoHS.png");
            this.imageList1.Images.SetKeyName(5, "Color_font.png");
            this.imageList1.Images.SetKeyName(6, "syncfusion_icon_16.png");
            // 
            // cutItem
            // 
            this.cutItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutItem.ID = "Cu&t";
            this.cutItem.ImageIndex = 0;
            this.cutItem.ImageList = this.imageList1;
            this.cutItem.Text = "Cu&t";
            this.cutItem.Click += new System.EventHandler(this.cutItem_Click);
            // 
            // pasteItem
            // 
            this.pasteItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.pasteItem.ID = "&Paste";
            this.pasteItem.ImageIndex = 2;
            this.pasteItem.ImageList = this.imageList1;
            this.pasteItem.Text = "&Paste";
            this.pasteItem.Click += new System.EventHandler(this.pasteItem_Click);
            // 
            // undoItem
            // 
            this.undoItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.undoItem.ID = "&Undo";
            this.undoItem.ImageIndex = 4;
            this.undoItem.ImageList = this.imageList1;
            this.undoItem.Text = "&Undo";
            this.undoItem.Click += new System.EventHandler(this.undoItem_Click);
            // 
            // redoItem
            // 
            this.redoItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.redoItem.ID = "&Redo";
            this.redoItem.ImageIndex = 3;
            this.redoItem.ImageList = this.imageList1;
            this.redoItem.Text = "&Redo";
            this.redoItem.Click += new System.EventHandler(this.redoItem_Click);
            // 
            // fontColorItem
            // 
            this.fontColorItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.fontColorItem.ID = "Font Color";
            this.fontColorItem.ImageIndex = 5;
            this.fontColorItem.ImageList = this.imageList1;
            this.fontColorItem.PopupControlContainer = this.popupControlContainer1;
            this.fontColorItem.Text = "Font Color";
            // 
            // aboutItem
            // 
            this.aboutItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.aboutItem.ID = "&About Syncfusion";
            this.aboutItem.ImageIndex = 6;
            this.aboutItem.ImageList = this.imageList1;
            this.aboutItem.Text = "&About Syncfusion...";
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Office2003",
            "VS2005",
            "Office2007Blue",
            "Office2007Black",
            "Office2007Silver",
            "Office2007Managed",
            "Offic2007Outlook"});
            this.comboBox1.Location = new System.Drawing.Point(16, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "PopupMenu Style";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(538, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Context Menus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.popupControlContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
			Application.Run(new Form1());
		}

		# region AboutForm_Logic
		DemoCommon.AboutForm aboutForm = null;
		private void aboutItem_Click(object sender, System.EventArgs e)
		{
			aboutForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
			aboutForm.ShowDialog();
		}
		#endregion

        private void colorPickerUIAdv1_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            this.textBox1.ForeColor = this.colorPickerUIAdv1.SelectedItem.Color;
            this.popupControlContainer1.HidePopup(PopupCloseType.Done);
        }

        private void colorPickerUIAdv1_ItemSelection(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            this.textBox1.ForeColor = args.Color;
        }

        private void popupMenu2_BeforePopup(object sender, CancelMouseEventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    popupMenu2.ParentBarItem.Style = VisualStyle.Default;
                    break;
                case 1:
                    popupMenu2.ParentBarItem.Style = VisualStyle.Office2003;
                    break;
                case 2:
                    popupMenu2.ParentBarItem.Style = VisualStyle.VS2005;
                    break;
                case 3:
                    popupMenu2.ParentBarItem.Style = VisualStyle.Office2007;
                    popupMenu2.ParentBarItem.Office2007Theme = Office2007Theme.Blue;                    
                    break;
                case 4:
                    popupMenu2.ParentBarItem.Style = VisualStyle.Office2007;
                    popupMenu2.ParentBarItem.Office2007Theme = Office2007Theme.Black;                
                    break;
                case 5:
                    popupMenu2.ParentBarItem.Style = VisualStyle.Office2007;
                    popupMenu2.ParentBarItem.Office2007Theme = Office2007Theme.Silver;                   
                    break;
                case 6:
                    popupMenu2.ParentBarItem.Style = VisualStyle.Office2007;
                    popupMenu2.ParentBarItem.Office2007Theme = Office2007Theme.Managed;
                    break;

                case 7:
                    popupMenu2.ParentBarItem.Style = VisualStyle.Office2007Outlook;
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                case 1:
                case 3:
                case 2:
                case 7:
                      this.ColorScheme = Office2007Theme.Blue;
                      break;
                  case 4:
                    this.ColorScheme = Office2007Theme.Black;
                    break;
                case 5:
                    this.ColorScheme = Office2007Theme.Silver;
                    break;
                case 6:
                    this.ColorScheme = Office2007Theme.Managed;
                    Office2007Colors.ApplyManagedColors(this, Color.Red);
                    break;

              
            }
        }

        private void copyItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Copy();
        }

        private void cutItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Cut();
        }

        private void pasteItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Paste();
        }

        private void redoItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }

        private void undoItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Undo();
        }
	
	}
}


