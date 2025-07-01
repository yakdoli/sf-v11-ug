#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace RibbonControlMerging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.toolStripTabItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.clipboardToolStripExt = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripPanelItem15 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripBtnPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownBtnPaste = new System.Windows.Forms.ToolStripDropDownButton();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteSpecialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteAsHyperlinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPanelItem1 = new Syncfusion.Windows.Forms.Tools.ToolStripPanelItem();
            this.toolStripBtnCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnPaint = new System.Windows.Forms.ToolStripButton();
            this.toolStripEx1 = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.statusStripEx1 = new Syncfusion.Windows.Forms.Tools.StatusStripEx();
            this.statusStripLabel1 = new Syncfusion.Windows.Forms.Tools.StatusStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).BeginInit();
            this.ribbonControlAdv1.SuspendLayout();
            this.toolStripTabItem1.Panel.SuspendLayout();
            this.clipboardToolStripExt.SuspendLayout();
            this.toolStripEx1.SuspendLayout();
            this.statusStripEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControlAdv1
            // 
            this.ribbonControlAdv1.Header.AddMainItem(toolStripTabItem1);
            this.ribbonControlAdv1.Header.AddQuickItem(new Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton2));
            this.ribbonControlAdv1.Header.AddQuickItem(new Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton3));
            this.ribbonControlAdv1.Header.AddQuickItem(new Syncfusion.Windows.Forms.Tools.QuickButtonReflectable(toolStripButton4));
            this.ribbonControlAdv1.Location = new System.Drawing.Point(1, 0);
            this.ribbonControlAdv1.MenuButtonImage = ((System.Drawing.Image)(resources.GetObject("ribbonControlAdv1.MenuButtonImage")));
            this.ribbonControlAdv1.Name = "ribbonControlAdv1";
            
            // 
            // ribbonControlAdv1.OfficeMenu
            // 
            this.ribbonControlAdv1.OfficeMenu.AuxPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripButton5});
            this.ribbonControlAdv1.OfficeMenu.MainPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.ribbonControlAdv1.OfficeMenu.Name = "OfficeMenu";
            this.ribbonControlAdv1.OfficeMenu.Size = new System.Drawing.Size(197, 162);
            this.ribbonControlAdv1.Size = new System.Drawing.Size(549, 159);
            this.ribbonControlAdv1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.ribbonControlAdv1.TabIndex = 0;
            this.ribbonControlAdv1.Text = "ribbonControlAdv1";
            // 
            // toolStripTabItem1
            // 
            this.toolStripTabItem1.Name = "toolStripTabItem1";
            this.toolStripTabItem1.Padding = new System.Windows.Forms.Padding(15, 1, 3, 1);
            // 
            // ribbonControlAdv1.ribbonPanel1
            // 
            this.toolStripTabItem1.Panel.Controls.Add(this.clipboardToolStripExt);
            this.toolStripTabItem1.Panel.Controls.Add(this.toolStripEx1);
            this.toolStripTabItem1.Panel.Name = "ribbonPanel1";
            this.toolStripTabItem1.Panel.ScrollPosition = 0;
            this.toolStripTabItem1.Panel.TabIndex = 2;
            this.toolStripTabItem1.Panel.Text = "Home";
            this.toolStripTabItem1.Size = new System.Drawing.Size(57, 19);
            this.toolStripTabItem1.Text = "Home";
            // 
            // clipboardToolStripExt
            // 
            this.clipboardToolStripExt.CollapsedDropDownButtonText = "Clipboard";
            this.clipboardToolStripExt.DefaultDropDownDirection = System.Windows.Forms.ToolStripDropDownDirection.BelowRight;
            this.clipboardToolStripExt.Dock = System.Windows.Forms.DockStyle.None;
            this.clipboardToolStripExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clipboardToolStripExt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.clipboardToolStripExt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.clipboardToolStripExt.Image = ((System.Drawing.Image)(resources.GetObject("clipboardToolStripExt.Image")));
            this.clipboardToolStripExt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPanelItem15,
            this.toolStripPanelItem1});
            this.clipboardToolStripExt.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office2007;
            this.clipboardToolStripExt.Location = new System.Drawing.Point(0, 1);
            this.clipboardToolStripExt.Name = "clipboardToolStripExt";
            this.clipboardToolStripExt.Size = new System.Drawing.Size(152, 97);
            this.clipboardToolStripExt.TabIndex = 1;
            this.clipboardToolStripExt.Text = "Clipboard";
            // 
            // toolStripPanelItem15
            // 
            this.toolStripPanelItem15.CausesValidation = false;
            this.toolStripPanelItem15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripPanelItem15.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem15.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnPaste,
            this.toolStripDropDownBtnPaste});
            this.toolStripPanelItem15.Name = "toolStripPanelItem15";
            this.toolStripPanelItem15.Size = new System.Drawing.Size(42, 79);
            this.toolStripPanelItem15.Text = "toolStripPanelItem15";
            this.toolStripPanelItem15.Transparent = true;
            // 
            // toolStripBtnPaste
            // 
            this.toolStripBtnPaste.AutoToolTip = false;
            this.toolStripBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPaste.Image")));
            this.toolStripBtnPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPaste.Name = "toolStripBtnPaste";
            this.toolStripBtnPaste.Size = new System.Drawing.Size(36, 36);
            this.toolStripBtnPaste.Text = "toolStripButton39";
            // 
            // toolStripDropDownBtnPaste
            // 
            this.toolStripDropDownBtnPaste.AutoToolTip = false;
            this.toolStripDropDownBtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownBtnPaste.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteToolStripMenuItem,
            this.pasteSpecialToolStripMenuItem,
            this.pasteAsHyperlinkToolStripMenuItem});
            this.toolStripDropDownBtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownBtnPaste.Image")));
            this.toolStripDropDownBtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownBtnPaste.Name = "toolStripDropDownBtnPaste";
            this.SetShortcut(this.toolStripDropDownBtnPaste, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V))));
            this.toolStripDropDownBtnPaste.ShowDropDownArrow = false;
            this.toolStripDropDownBtnPaste.Size = new System.Drawing.Size(38, 17);
            this.toolStripDropDownBtnPaste.Text = "Paste";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // pasteSpecialToolStripMenuItem
            // 
            this.pasteSpecialToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteSpecialToolStripMenuItem.Image")));
            this.pasteSpecialToolStripMenuItem.Name = "pasteSpecialToolStripMenuItem";
            this.pasteSpecialToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pasteSpecialToolStripMenuItem.Text = "Paste &Special...";
            // 
            // pasteAsHyperlinkToolStripMenuItem
            // 
            this.pasteAsHyperlinkToolStripMenuItem.Enabled = false;
            this.pasteAsHyperlinkToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteAsHyperlinkToolStripMenuItem.Image")));
            this.pasteAsHyperlinkToolStripMenuItem.Name = "pasteAsHyperlinkToolStripMenuItem";
            this.pasteAsHyperlinkToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.pasteAsHyperlinkToolStripMenuItem.Text = "Paste as &Hyperlink";
            // 
            // toolStripPanelItem1
            // 
            this.toolStripPanelItem1.CausesValidation = false;
            this.toolStripPanelItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripPanelItem1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripPanelItem1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnCut,
            this.toolStripBtnCopy,
            this.toolStripBtnPaint});
            this.toolStripPanelItem1.Name = "toolStripPanelItem1";
            this.toolStripPanelItem1.Size = new System.Drawing.Size(99, 79);
            this.toolStripPanelItem1.Text = "toolStripPanelItem1";
            this.toolStripPanelItem1.Transparent = true;
            // 
            // toolStripBtnCut
            // 
            this.toolStripBtnCut.AutoToolTip = false;
            this.toolStripBtnCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCut.Image")));
            this.toolStripBtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCut.Name = "toolStripBtnCut";
            this.SetShortcut(this.toolStripBtnCut, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X))));
            this.toolStripBtnCut.Size = new System.Drawing.Size(43, 20);
            this.toolStripBtnCut.Text = "Cut";
            // 
            // toolStripBtnCopy
            // 
            this.toolStripBtnCopy.AutoToolTip = false;
            this.toolStripBtnCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCopy.Image")));
            this.toolStripBtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCopy.Name = "toolStripBtnCopy";
            this.SetShortcut(this.toolStripBtnCopy, ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C))));
            this.toolStripBtnCopy.Size = new System.Drawing.Size(51, 20);
            this.toolStripBtnCopy.Text = "Copy";
            // 
            // toolStripBtnPaint
            // 
            this.toolStripBtnPaint.AutoToolTip = false;
            this.toolStripBtnPaint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnPaint.Image")));
            this.toolStripBtnPaint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnPaint.Name = "toolStripBtnPaint";
            this.SetShortcut(this.toolStripBtnPaint, ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                            | System.Windows.Forms.Keys.C))));
            this.toolStripBtnPaint.Size = new System.Drawing.Size(95, 20);
            this.toolStripBtnPaint.Text = "Format Painter";
            // 
            // toolStripEx1
            // 
            this.toolStripEx1.AutoSize = false;
            this.toolStripEx1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripEx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripEx1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.toolStripEx1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEx1.Image = null;
            this.toolStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStripEx1.Location = new System.Drawing.Point(152, 1);
            this.toolStripEx1.Name = "toolStripEx1";
            this.toolStripEx1.Size = new System.Drawing.Size(73, 97);
            this.toolStripEx1.TabIndex = 2;
            this.toolStripEx1.Text = "Insert";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.toolStripButton1.Size = new System.Drawing.Size(66, 76);
            this.toolStripButton1.Text = "New\r\nFile";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Padding = new System.Windows.Forms.Padding(4);
            this.toolStripButton2.Size = new System.Drawing.Size(69, 36);
            this.toolStripButton2.Text = "New";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Padding = new System.Windows.Forms.Padding(4);
            this.toolStripButton3.Size = new System.Drawing.Size(69, 36);
            this.toolStripButton3.Text = "Open";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Padding = new System.Windows.Forms.Padding(4);
            this.toolStripButton4.Size = new System.Drawing.Size(69, 36);
            this.toolStripButton4.Text = "Save";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(114, 13);
            this.toolStripLabel1.Text = "Recent Documents";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(98, 2);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(114, 17);
            this.toolStripButton5.Text = "Document1.doc";
            this.toolStripButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStripEx1
            // 
            this.statusStripEx1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Bottom;
            this.statusStripEx1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripLabel1});
            this.statusStripEx1.Location = new System.Drawing.Point(6, 492);
            this.statusStripEx1.Name = "statusStripEx1";
            this.statusStripEx1.Size = new System.Drawing.Size(539, 22);
            this.statusStripEx1.TabIndex = 2;
            this.statusStripEx1.Text = "statusStripEx1";
            // 
            // statusStripLabel1
            // 
            this.statusStripLabel1.Margin = new System.Windows.Forms.Padding(0, 4, 0, 2);
            this.statusStripLabel1.Name = "statusStripLabel1";
            this.statusStripLabel1.Size = new System.Drawing.Size(270, 15);
            this.statusStripLabel1.Text = "Please click on \'New File\' to create a child window";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.HelpButton = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 520);
            this.Controls.Add(this.statusStripEx1);
            this.Controls.Add(this.ribbonControlAdv1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ribbon Merging Demo";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlAdv1)).EndInit();
            this.ribbonControlAdv1.ResumeLayout(false);
            this.ribbonControlAdv1.PerformLayout();
            this.toolStripTabItem1.Panel.ResumeLayout(false);
            this.toolStripTabItem1.Panel.PerformLayout();
            this.clipboardToolStripExt.ResumeLayout(false);
            this.clipboardToolStripExt.PerformLayout();
            this.toolStripEx1.ResumeLayout(false);
            this.toolStripEx1.PerformLayout();
            this.statusStripEx1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem toolStripTabItem1;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx clipboardToolStripExt;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem15;
        private System.Windows.Forms.ToolStripButton toolStripBtnPaste;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownBtnPaste;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteSpecialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteAsHyperlinkToolStripMenuItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripPanelItem toolStripPanelItem1;
        private System.Windows.Forms.ToolStripButton toolStripBtnCut;
        private System.Windows.Forms.ToolStripButton toolStripBtnCopy;
        private System.Windows.Forms.ToolStripButton toolStripBtnPaint;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx toolStripEx1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private Syncfusion.Windows.Forms.Tools.StatusStripEx statusStripEx1;
        private Syncfusion.Windows.Forms.Tools.StatusStripLabel statusStripLabel1;
    }
}

