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

namespace MDIDemo
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Text;
    using System.Windows.Forms;
    using System.Diagnostics;
    using System.IO;
    using Syncfusion.Windows.Forms.Tools.XPMenus;

    public class Document :Syncfusion.Windows.Forms.Office2007Form
    {
        protected System.Windows.Forms.RichTextBox richTextBox1;

        private struct FontSizes
        {
            public static float Small;
            public static float Medium;
            public static float Large;

            // VB requires instance member.
            // private int n;

            static FontSizes()
            {
                FontSizes.Small = 8f;
                FontSizes.Medium = 12f;
                FontSizes.Large = 24f;
            }
        }

        private float fontSize = FontSizes.Medium;

        private FontFamily currentFontFamily_;
        private FontFamily courierNewFontFamily;
        private FontFamily sansSerifFontFamily;
        private FontFamily arialFontFamily;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager childFrameBarManager1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.Bar bar1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem parentBarItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem fontFaceParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem fontSizeParentBarItem;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem1;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem2;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem3;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem4;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem5;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem7;
        private Syncfusion.Windows.Forms.Tools.XPMenus.BarItem barItem6;
        private FontFamily timesNewRomanFontFamily;

        public String CurrentFontFamily
        {
            get
            {
                if (this.currentFontFamily_ == this.sansSerifFontFamily)
                    return "MS Sans Serif";
                else if (this.currentFontFamily_ == this.timesNewRomanFontFamily)
                    return "Times New Roman";
                else if (this.currentFontFamily_ == this.courierNewFontFamily)
                    return "Courier New";
                else
                    return "Arial";
            }

            set
            {
                FontFamily fontfamily = null;
                switch (value)
                {
                    case "MS Sans Serif":
                        fontfamily = this.sansSerifFontFamily;
                        break;
                    case "Times New Roman":
                        fontfamily = this.timesNewRomanFontFamily;
                        break;
                    case "Courier New":
                        fontfamily = this.courierNewFontFamily;
                        break;
                    case "Arial":
                        fontfamily = this.arialFontFamily;
                        break;
                        
                }
                if (this.currentFontFamily_ != fontfamily)
                {
                    this.currentFontFamily_ = fontfamily;
                    this.richTextBox1.Font = new Font(this.currentFontFamily_, this.fontSize);
                }
            }
        }

        public String CurrentFontSize
        {
            get
            {
                if (this.fontSize == FontSizes.Small)
                    return "Small";
                else if (this.fontSize == FontSizes.Medium)
                    return "Medium";
                return "Large";
            }

            set
            {
                float fontsize = 0;
                switch (value)
                {
                    case "Small":
                        fontsize = FontSizes.Small;
                        break;
                    case "Medium":
                        fontsize = FontSizes.Medium;
                        break;
                    case "Large":
                        fontsize = FontSizes.Large;
                        break;
                }

                if (this.fontSize != fontsize)
                {
                    this.fontSize = fontsize;
                    this.richTextBox1.Font = new Font(this.currentFontFamily_, this.fontSize);
                }
            }
        }

        public Document(string docName)
        {
            InitializeComponent();

            // Initialize fonts - use generic fonts to avoid problems across
            // different versions of the OS.
            courierNewFontFamily = new FontFamily(GenericFontFamilies.Monospace);
            sansSerifFontFamily = new FontFamily(GenericFontFamilies.SansSerif);
            timesNewRomanFontFamily = new FontFamily(GenericFontFamilies.Serif);
            arialFontFamily = new FontFamily("Arial");
            currentFontFamily_ = arialFontFamily;

            this.Text = docName;

            richTextBox1.Font = new System.Drawing.Font(currentFontFamily_, fontSize);
            richTextBox1.Text = docName;
            foreach (BarItem i in this.childFrameBarManager1.Items)
            {
                i.CustomTextFont = new Font("Microsoft Sans Seriff", 8.25f);
            }
        }

        #region Initialize Component
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Document));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.childFrameBarManager1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ChildFrameBarManager(this);
            this.bar1 = new Syncfusion.Windows.Forms.Tools.XPMenus.Bar(this.childFrameBarManager1, "FormatMenu");
            this.parentBarItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.fontFaceParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem1 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem2 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem3 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem4 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.fontSizeParentBarItem = new Syncfusion.Windows.Forms.Tools.XPMenus.ParentBarItem();
            this.barItem5 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem7 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            this.barItem6 = new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem();
            ((System.ComponentModel.ISupportInitialize)(this.childFrameBarManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(375, 229);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // childFrameBarManager1
            // 
            this.childFrameBarManager1.BarPositionInfo = ((System.IO.MemoryStream)(resources.GetObject("childFrameBarManager1.BarPositionInfo")));
            this.childFrameBarManager1.Bars.Add(this.bar1);
            this.childFrameBarManager1.Categories.Add("Format");
            this.childFrameBarManager1.CurrentBaseFormType = "Syncfusion.Windows.Forms.Office2007Form";
            this.childFrameBarManager1.Form = this;
            this.childFrameBarManager1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1,
            this.fontFaceParentBarItem,
            this.fontSizeParentBarItem,
            this.barItem3,
            this.barItem1,
            this.barItem2,
            this.barItem4,
            this.barItem5,
            this.barItem7,
            this.barItem6});
            this.childFrameBarManager1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // bar1
            // 
            this.bar1.BarName = "FormatMenu";
            this.bar1.BarStyle = ((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle)((((Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.AllowQuickCustomizing | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.IsMainMenu)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.Visible)
                        | Syncfusion.Windows.Forms.Tools.XPMenus.BarStyle.DrawDragBorder)));
            this.bar1.Caption = "FormatMenu";
            this.bar1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.parentBarItem1});
            this.bar1.Manager = this.childFrameBarManager1;
            // 
            // parentBarItem1
            // 
            this.parentBarItem1.CategoryIndex = 0;
            this.parentBarItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentBarItem1.ID = "F&ormat";
            this.parentBarItem1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.fontFaceParentBarItem,
            this.fontSizeParentBarItem});
            this.parentBarItem1.MergeOrder = 1;
            this.parentBarItem1.Text = "F&ormat";
            // 
            // fontFaceParentBarItem
            // 
            this.fontFaceParentBarItem.CategoryIndex = 0;
            this.fontFaceParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontFaceParentBarItem.ID = "FontFace";
            this.fontFaceParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem1,
            this.barItem2,
            this.barItem3,
            this.barItem4});
            this.fontFaceParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.fontFaceParentBarItem.Text = "FontFace";
            // 
            // barItem1
            // 
            this.barItem1.CategoryIndex = 0;
            this.barItem1.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem1.ID = "MS Sans Serif";
            this.barItem1.Text = "1. MS Sans Serif";
            this.barItem1.Click += new System.EventHandler(this.OnFontFaceBarItemClick);
            // 
            // barItem2
            // 
            this.barItem2.CategoryIndex = 0;
            this.barItem2.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem2.ID = "Times New Roman";
            this.barItem2.Text = "2. Times New Roman";
            this.barItem2.Click += new System.EventHandler(this.OnFontFaceBarItemClick);
            // 
            // barItem3
            // 
            this.barItem3.CategoryIndex = 0;
            this.barItem3.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem3.ID = "Courier New";
            this.barItem3.Text = "3. Courier New";
            this.barItem3.Click += new System.EventHandler(this.OnFontFaceBarItemClick);
            // 
            // barItem4
            // 
            this.barItem4.CategoryIndex = 0;
            this.barItem4.Checked = true;
            this.barItem4.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem4.ID = "Calibri";
            this.barItem4.Text = "4. Calibri";
            this.barItem4.Click += new System.EventHandler(this.OnFontFaceBarItemClick);
            // 
            // fontSizeParentBarItem
            // 
            this.fontSizeParentBarItem.CategoryIndex = 0;
            this.fontSizeParentBarItem.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontSizeParentBarItem.ID = "FontSize";
            this.fontSizeParentBarItem.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPMenus.BarItem[] {
            this.barItem5,
            this.barItem7,
            this.barItem6});
            this.fontSizeParentBarItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.fontSizeParentBarItem.Text = "FontSize";
            // 
            // barItem5
            // 
            this.barItem5.CategoryIndex = 0;
            this.barItem5.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem5.ID = "Small";
            this.barItem5.Text = "Small";
            this.barItem5.Click += new System.EventHandler(this.OnFontSizeBarItemClick);
            // 
            // barItem7
            // 
            this.barItem7.CategoryIndex = 0;
            this.barItem7.Checked = true;
            this.barItem7.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem7.ID = "Medium";
            this.barItem7.Text = "Medium";
            this.barItem7.Click += new System.EventHandler(this.OnFontSizeBarItemClick);
            // 
            // barItem6
            // 
            this.barItem6.CategoryIndex = 0;
            this.barItem6.CustomTextFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barItem6.ID = "Large";
            this.barItem6.Text = "Large";
            this.barItem6.Click += new System.EventHandler(this.OnFontSizeBarItemClick);
            // 
            // Document
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(354, 295);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Document";
            ((System.ComponentModel.ISupportInitialize)(this.childFrameBarManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private void OnFontFaceBarItemClick(object sender, EventArgs e)
        {
            BarItem item = sender as BarItem;
            Form f = this.ParentForm;
            if (f != null)
            {
                MainForm m = (MainForm)f;
                switch (item.ID)
                {
                    case "MS Sans Serif":
                        this.currentFontFamily_ = this.sansSerifFontFamily;
                        this.barItem1.Checked = true;
                        break;
                    case "Times New Roman":
                        this.currentFontFamily_ = this.timesNewRomanFontFamily;
                        this.barItem2.Checked = true;
                        break;
                    case "Courier New":
                        this.currentFontFamily_ = this.courierNewFontFamily;
                        this.barItem3.Checked = true;
                        break;
                    case "Arial":
                        this.currentFontFamily_ = this.arialFontFamily;
                        this.barItem4.Checked = true;
                        break;
                }
                this.richTextBox1.Font = new Font(this.currentFontFamily_, this.fontSize);
                CheckChildItem(this.fontFaceParentBarItem, item);
            }
        }

        private void OnFontSizeBarItemClick(object sender, EventArgs e)
        {
            BarItem item = sender as BarItem;
            Form f = this.ParentForm;
            if (f != null)
            {
                MainForm m = (MainForm)f;
                switch (item.ID)
                {
                    case "Small":
                        this.fontSize = FontSizes.Small;
                        break;
                    case "Medium":
                        this.fontSize = FontSizes.Medium;
                        break;
                    case "Large":
                        this.fontSize = FontSizes.Large;
                        break;
                }
                this.richTextBox1.Font = new Font(this.currentFontFamily_, this.fontSize);
                CheckChildItem(this.fontSizeParentBarItem, item);
            }
        }

        private void CheckChildItem(ParentBarItem parentBarItem, BarItem item)
        {
            foreach (BarItem i in parentBarItem.Items)
            {
                if (item.ID == i.ID)
                    i.Checked = true;
                else
                    i.Checked = false;
            }
        }

        public void DoLoadDocument(String filename)
        {
            this.richTextBox1.LoadFile(filename, RichTextBoxStreamType.PlainText);
        }

        public void DoSaveDocument(String filename)
        {
            this.richTextBox1.SaveFile(filename, RichTextBoxStreamType.PlainText);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

    }
}










