#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace ScrollersFrame_2005
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Deleted Items", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Junk Email", 0, 0);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Inbox", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Sent Items", 6, 6);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Search Folders", 4, 4);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Personal Folders                                          ", 7, 7, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Search Folders", 4, 4);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Sent Items", 6, 6);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Deleted Items", 1, 1);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Archive Folders", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Drafts", 5, 5);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Inbox", 2, 2);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Outbox", 3, 3);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Sent Items", 6, 6);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Public");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Syncfusion E-mail", 8, 8, new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.parentBarItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.scrollersFrame2 = new Syncfusion.Windows.Forms.ScrollersFrame(this.components);
            this.treeView3 = new System.Windows.Forms.TreeView();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.buttonAdv2 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.mainFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.mainFrameBarManager1, "Main Menu");
            this.parentBarItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem8 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem9 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.trackBarEx1 = new Syncfusion.Windows.Forms.Tools.TrackBarEx(0, 10);
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdv3 = new Syncfusion.Windows.Forms.ButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // parentBarItem2
            // 
            this.parentBarItem2.ID = "Themes";
            this.parentBarItem2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.parentBarItem2.Text = "Themes";
            // 
            // scrollersFrame2
            // 
            this.scrollersFrame2.AttachedTo = this.treeView3;
            this.scrollersFrame2.HorizontalSmallChange = 7;
            this.scrollersFrame2.SizeGripperVisibility = Syncfusion.Windows.Forms.SizeGripperVisibility.Auto;
            this.scrollersFrame2.VerticallSmallChange = 13;
            this.scrollersFrame2.VisualStyle = Syncfusion.Windows.Forms.ScrollBarCustomDrawStyles.Office2007;
            // 
            // treeView3
            // 
            this.treeView3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView3.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView3.Indent = 25;
            this.treeView3.ItemHeight = 22;
            this.treeView3.Location = new System.Drawing.Point(0, 24);
            this.treeView3.MinimumSize = new System.Drawing.Size(2, 110);
            this.treeView3.Name = "treeView3";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Deleted Items";
            treeNode2.ImageIndex = 0;
            treeNode2.Name = "";
            treeNode2.SelectedImageIndex = 0;
            treeNode2.Text = "Junk Email";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Text = "Inbox";
            treeNode4.ImageIndex = 6;
            treeNode4.Name = "";
            treeNode4.SelectedImageIndex = 6;
            treeNode4.Text = "Sent Items";
            treeNode5.ImageIndex = 4;
            treeNode5.Name = "";
            treeNode5.SelectedImageIndex = 4;
            treeNode5.Text = "Search Folders";
            treeNode6.ImageIndex = 7;
            treeNode6.Name = "";
            treeNode6.SelectedImageIndex = 7;
            treeNode6.Text = "Personal Folders                                          ";
            treeNode7.ImageIndex = 4;
            treeNode7.Name = "";
            treeNode7.SelectedImageIndex = 4;
            treeNode7.Text = "Search Folders";
            treeNode8.ImageIndex = 6;
            treeNode8.Name = "";
            treeNode8.SelectedImageIndex = 6;
            treeNode8.Text = "Sent Items";
            treeNode9.ImageIndex = 1;
            treeNode9.Name = "";
            treeNode9.SelectedImageIndex = 1;
            treeNode9.Text = "Deleted Items";
            treeNode10.ImageIndex = 8;
            treeNode10.Name = "";
            treeNode10.SelectedImageIndex = 8;
            treeNode10.Text = "Archive Folders";
            treeNode11.ImageIndex = 5;
            treeNode11.Name = "";
            treeNode11.SelectedImageIndex = 5;
            treeNode11.Text = "Drafts";
            treeNode12.ImageIndex = 2;
            treeNode12.Name = "";
            treeNode12.SelectedImageIndex = 2;
            treeNode12.Text = "Inbox";
            treeNode13.ImageIndex = 3;
            treeNode13.Name = "";
            treeNode13.SelectedImageIndex = 3;
            treeNode13.Text = "Outbox";
            treeNode14.ImageIndex = 6;
            treeNode14.Name = "";
            treeNode14.SelectedImageIndex = 6;
            treeNode14.Text = "Sent Items";
            treeNode15.Name = "";
            treeNode15.Text = "Public";
            treeNode16.ImageIndex = 8;
            treeNode16.Name = "";
            treeNode16.SelectedImageIndex = 8;
            treeNode16.Text = "Syncfusion E-mail";
            this.treeView3.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode10,
            treeNode16});
            this.treeView3.ShowLines = false;
            this.treeView3.Size = new System.Drawing.Size(148, 296);
            this.treeView3.TabIndex = 16;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv1.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Redo;
            this.buttonAdv1.KeepFocusRectangle = false;
            this.buttonAdv1.Location = new System.Drawing.Point(502, 596);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(18, 17);
            this.buttonAdv1.TabIndex = 9;
            this.buttonAdv1.Text = "buttonAdv1";
            this.buttonAdv1.UseVisualStyle = true;
            // 
            // buttonAdv2
            // 
            this.buttonAdv2.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv2.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Undo;
            this.buttonAdv2.KeepFocusRectangle = false;
            this.buttonAdv2.Location = new System.Drawing.Point(549, 596);
            this.buttonAdv2.Name = "buttonAdv2";
            this.buttonAdv2.Size = new System.Drawing.Size(18, 17);
            this.buttonAdv2.TabIndex = 12;
            this.buttonAdv2.Text = "buttonAdv2";
            this.buttonAdv2.UseVisualStyle = true;
            // 
            // mainFrameBarManager1
            // 
            this.mainFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("mainFrameBarManager1.BarPositionInfo")));
            this.mainFrameBarManager1.Bars.Add(this.bar1);
            this.mainFrameBarManager1.Categories.Add("Category1");
            this.mainFrameBarManager1.CurrentBaseFormType = "";
            this.mainFrameBarManager1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainFrameBarManager1.Form = this;
            this.mainFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem7,
            this.barItem8,
            this.barItem9,
            this.parentBarItem4});
            this.mainFrameBarManager1.ResetCustomization = false;
            this.mainFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main Menu";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)));
            this.bar1.Caption = "Main Menu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem4});
            this.bar1.Manager = this.mainFrameBarManager1;
            // 
            // parentBarItem4
            // 
            this.parentBarItem4.CategoryIndex = 0;
            this.parentBarItem4.CustomNormalTextColor = System.Drawing.Color.MidnightBlue;
            this.parentBarItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem4.ID = "Office2007 Styles";
            this.parentBarItem4.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem7,
            this.barItem8,
            this.barItem9});
            this.parentBarItem4.Text = "Office 2007 Styles";
            // 
            // barItem7
            // 
            this.barItem7.CategoryIndex = 0;
            this.barItem7.Checked = true;
            this.barItem7.CustomNormalTextColor = System.Drawing.Color.MidnightBlue;
            this.barItem7.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem7.ID = "Blue";
            this.barItem7.Text = "Blue";
            this.barItem7.Click += new System.EventHandler(this.barItem_Click);
            // 
            // barItem8
            // 
            this.barItem8.CategoryIndex = 0;
            this.barItem8.CustomNormalTextColor = System.Drawing.Color.MidnightBlue;
            this.barItem8.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem8.ID = "Silver";
            this.barItem8.Text = "Silver";
            this.barItem8.Click += new System.EventHandler(this.barItem_Click);
            // 
            // barItem9
            // 
            this.barItem9.CategoryIndex = 0;
            this.barItem9.CustomNormalTextColor = System.Drawing.Color.MidnightBlue;
            this.barItem9.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem9.ID = "Black";
            this.barItem9.Text = "Black";
            this.barItem9.Click += new System.EventHandler(this.barItem_Click);
            // 
            // trackBarEx1
            // 
            this.trackBarEx1.Location = new System.Drawing.Point(0, 0);
            this.trackBarEx1.Name = "trackBarEx1";
            this.trackBarEx1.Size = new System.Drawing.Size(250, 20);
            this.trackBarEx1.TabIndex = 0;
            this.trackBarEx1.TimerInterval = 100;
            this.trackBarEx1.Value = 5;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(231)))), ((int)(((byte)(246)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.buttonAdv3);
            this.gradientPanel1.Location = new System.Drawing.Point(161, 38);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(325, 127);
            this.gradientPanel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 125);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonAdv3
            // 
            this.buttonAdv3.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.buttonAdv3.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdv3.Image")));
            this.buttonAdv3.KeepFocusRectangle = false;
            this.buttonAdv3.Location = new System.Drawing.Point(225, 69);
            this.buttonAdv3.Name = "buttonAdv3";
            this.buttonAdv3.Size = new System.Drawing.Size(23, 23);
            this.buttonAdv3.TabIndex = 22;
            this.buttonAdv3.UseVisualStyle = true;
            this.buttonAdv3.Click += new System.EventHandler(this.buttonAdv3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(501, 320);
            this.Controls.Add(this.gradientPanel1);
            this.Controls.Add(this.treeView3);
            this.Controls.Add(this.buttonAdv2);
            this.Controls.Add(this.buttonAdv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scrollers Frame";
            ((System.ComponentModel.ISupportInitialize)(this.mainFrameBarManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem2;
        private Syncfusion.Windows.Forms.ScrollersFrame scrollersFrame2;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv2;
        private System.Windows.Forms.TreeView treeView3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.MainFrameBarManager mainFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem8;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem9;
        private Syncfusion.Windows.Forms.Tools.TrackBarEx trackBarEx1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv3;
    }
}

