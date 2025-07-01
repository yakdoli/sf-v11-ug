namespace NavigationViewDemo_2005 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.Navigation.Bar bar1 = new Syncfusion.Windows.Forms.Tools.Navigation.Bar();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navigationView1 = new Syncfusion.Windows.Forms.Tools.NavigationView();
            this.customButton1 = new Syncfusion.Windows.Forms.Tools.Navigation.CustomButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.xpTaskBar1 = new Syncfusion.Windows.Forms.Tools.XPTaskBar();
            this.xpTaskBarBox1 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.xpTaskBarBox2 = new Syncfusion.Windows.Forms.Tools.XPTaskBarBox();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.HistorycheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RTLChkBox = new System.Windows.Forms.CheckBox();
            this.BarImgChkBox = new System.Windows.Forms.CheckBox();
            this.CutmBtnChkBox = new System.Windows.Forms.CheckBox();
            this.HisbtnChkBox = new System.Windows.Forms.CheckBox();
            this.VisStyleCmbBox = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.navigationView1)).BeginInit();
            this.navigationView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).BeginInit();
            this.xpTaskBar1.SuspendLayout();
            this.xpTaskBarBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // navigationView1
            // 
            bar1.ImageIndex = 2;
            bar1.Text = "My Computer";
            this.navigationView1.Bars.AddRange(new Syncfusion.Windows.Forms.Tools.Navigation.Bar[] {
            bar1});
            this.navigationView1.BorderColor = System.Drawing.Color.Navy;
            this.navigationView1.Controls.Add(this.customButton1);
            this.navigationView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationView1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.navigationView1.HistoryEnabled = true;
            this.navigationView1.ImageList = this.imageList1;
            this.navigationView1.Location = new System.Drawing.Point(0, 0);
            this.navigationView1.Name = "navigationView1";
            this.navigationView1.SelectedBar = bar1;
            this.navigationView1.ShowHistoryButtons = true;
            this.navigationView1.ShowRootBarText = true;
            this.navigationView1.Size = new System.Drawing.Size(565, 28);
            this.navigationView1.TabIndex = 0;
            this.navigationView1.Text = "navigationView1";
            this.navigationView1.BarSelectionChanging += new System.EventHandler<Syncfusion.Windows.Forms.Tools.Navigation.BarSelectionChangingEventArgs>(this.navigationView1_BarSelectionChanging);
            // 
            // customButton1
            // 
            this.customButton1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.customButton1.ImageIndex = 3;
            this.customButton1.ImageList = this.imageList1;
            this.customButton1.KeepFocusRectangle = false;
            this.customButton1.Location = new System.Drawing.Point(539, 3);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(26, 21);
            this.customButton1.TabIndex = 5;
            this.customButton1.UseVisualStyle = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "floppydrive2.ico");
            this.imageList1.Images.SetKeyName(1, "cddrive2.ico");
            this.imageList1.Images.SetKeyName(2, "COMPUTER.ico");
            this.imageList1.Images.SetKeyName(3, "SEARCH.gif");
            this.imageList1.Images.SetKeyName(4, "open_icon.png");
            this.imageList1.Images.SetKeyName(5, "file.ico");
            this.imageList1.Images.SetKeyName(6, "folder.ico");
            this.imageList1.Images.SetKeyName(7, "New.ico");
            this.imageList1.Images.SetKeyName(8, "folder.bmp");
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(254))))), System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(215)))), ((int)(((byte)(252))))));
            this.gradientPanel2.Border3DStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(215)))), ((int)(((byte)(252)))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.xpTaskBar1);
            this.gradientPanel2.Controls.Add(this.listView1);
            this.gradientPanel2.Controls.Add(this.navigationView1);
            this.gradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(567, 396);
            this.gradientPanel2.TabIndex = 37;
            // 
            // xpTaskBar1
            // 
            this.xpTaskBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox1);
            this.xpTaskBar1.Controls.Add(this.xpTaskBarBox2);
            this.xpTaskBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.xpTaskBar1.Location = new System.Drawing.Point(0, 28);
            this.xpTaskBar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.xpTaskBar1.Name = "xpTaskBar1";
            this.xpTaskBar1.Size = new System.Drawing.Size(139, 366);
            this.xpTaskBar1.Style = Syncfusion.Windows.Forms.Tools.XPTaskBarStyle.Office2007;
            this.xpTaskBar1.TabIndex = 34;
            this.xpTaskBar1.VerticalPadding = 9;
            // 
            // xpTaskBarBox1
            // 
            this.xpTaskBarBox1.DrawFocusRect = false;
            this.xpTaskBarBox1.FocusOnClick = false;
            this.xpTaskBarBox1.HeaderImageIndex = -1;
            this.xpTaskBarBox1.HitTaskBoxArea = false;
            this.xpTaskBarBox1.ImageList = this.imageList1;
            this.xpTaskBarBox1.Items.AddRange(new Syncfusion.Windows.Forms.Tools.XPTaskBarItem[] {
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Documents", System.Drawing.Color.Empty, 8, null, "", true, true, "XPTaskBarItem0", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 6),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Pictures", System.Drawing.Color.Empty, 8, null, "", true, true, "XPTaskBarItem1", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 6),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("Music", System.Drawing.Color.Empty, 8, null, "", true, true, "XPTaskBarItem2", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 6),
            new Syncfusion.Windows.Forms.Tools.XPTaskBarItem("More >>", System.Drawing.Color.Empty, -1, null, "", true, true, "XPTaskBarItem3", new System.Drawing.Font("Microsoft Sans Serif", 8.25F), 6)});
            this.xpTaskBarBox1.Location = new System.Drawing.Point(0, 0);
            this.xpTaskBarBox1.Name = "xpTaskBarBox1";
            this.xpTaskBarBox1.PreferredChildPanelHeight = 40;
            this.xpTaskBarBox1.Size = new System.Drawing.Size(137, 92);
            this.xpTaskBarBox1.TabIndex = 0;
            this.xpTaskBarBox1.Text = "Favorite Links";
            // 
            // xpTaskBarBox2
            // 
            this.xpTaskBarBox2.Controls.Add(this.gradientPanel4);
            this.xpTaskBarBox2.DrawFocusRect = false;
            this.xpTaskBarBox2.FocusOnClick = false;
            this.xpTaskBarBox2.HeaderImageIndex = -1;
            this.xpTaskBarBox2.HitTaskBoxArea = false;
            this.xpTaskBarBox2.Location = new System.Drawing.Point(0, 101);
            this.xpTaskBarBox2.Name = "xpTaskBarBox2";
            this.xpTaskBarBox2.PreferredChildPanelHeight = 250;
            this.xpTaskBarBox2.Size = new System.Drawing.Size(137, 274);
            this.xpTaskBarBox2.TabIndex = 1;
            this.xpTaskBarBox2.Text = "Features";
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(235)))), ((int)(((byte)(254))))), System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(215)))), ((int)(((byte)(252))))));
            this.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(215)))), ((int)(((byte)(252)))));
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel4.Controls.Add(this.HistorycheckBox);
            this.gradientPanel4.Controls.Add(this.label1);
            this.gradientPanel4.Controls.Add(this.RTLChkBox);
            this.gradientPanel4.Controls.Add(this.BarImgChkBox);
            this.gradientPanel4.Controls.Add(this.CutmBtnChkBox);
            this.gradientPanel4.Controls.Add(this.HisbtnChkBox);
            this.gradientPanel4.Controls.Add(this.VisStyleCmbBox);
            this.gradientPanel4.Location = new System.Drawing.Point(2, 22);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(133, 250);
            this.gradientPanel4.TabIndex = 32;
            // 
            // HistorycheckBox
            // 
            this.HistorycheckBox.AutoSize = true;
            this.HistorycheckBox.BackColor = System.Drawing.Color.Transparent;
            this.HistorycheckBox.Checked = true;
            this.HistorycheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HistorycheckBox.Location = new System.Drawing.Point(7, 16);
            this.HistorycheckBox.Name = "HistorycheckBox";
            this.HistorycheckBox.Size = new System.Drawing.Size(100, 17);
            this.HistorycheckBox.TabIndex = 1;
            this.HistorycheckBox.Text = "History Enabled";
            this.HistorycheckBox.UseVisualStyleBackColor = false;
            this.HistorycheckBox.CheckedChanged += new System.EventHandler(this.HistorycheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(4, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Visual Style";
            // 
            // RTLChkBox
            // 
            this.RTLChkBox.AutoSize = true;
            this.RTLChkBox.BackColor = System.Drawing.Color.Transparent;
            this.RTLChkBox.Location = new System.Drawing.Point(4, 204);
            this.RTLChkBox.Name = "RTLChkBox";
            this.RTLChkBox.Size = new System.Drawing.Size(82, 17);
            this.RTLChkBox.TabIndex = 4;
            this.RTLChkBox.Text = "RightToLeft";
            this.RTLChkBox.UseVisualStyleBackColor = false;
            this.RTLChkBox.CheckedChanged += new System.EventHandler(this.RTLChkBox_CheckedChanged);
            // 
            // BarImgChkBox
            // 
            this.BarImgChkBox.AutoSize = true;
            this.BarImgChkBox.BackColor = System.Drawing.Color.Transparent;
            this.BarImgChkBox.Checked = true;
            this.BarImgChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.BarImgChkBox.Location = new System.Drawing.Point(4, 167);
            this.BarImgChkBox.Name = "BarImgChkBox";
            this.BarImgChkBox.Size = new System.Drawing.Size(106, 17);
            this.BarImgChkBox.TabIndex = 3;
            this.BarImgChkBox.Text = "Show BarImages";
            this.BarImgChkBox.UseVisualStyleBackColor = false;
            this.BarImgChkBox.CheckedChanged += new System.EventHandler(this.BarImgChkBox_CheckedChanged);
            // 
            // CutmBtnChkBox
            // 
            this.CutmBtnChkBox.AutoSize = true;
            this.CutmBtnChkBox.BackColor = System.Drawing.Color.Transparent;
            this.CutmBtnChkBox.Checked = true;
            this.CutmBtnChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CutmBtnChkBox.Location = new System.Drawing.Point(4, 134);
            this.CutmBtnChkBox.Name = "CutmBtnChkBox";
            this.CutmBtnChkBox.Size = new System.Drawing.Size(125, 17);
            this.CutmBtnChkBox.TabIndex = 2;
            this.CutmBtnChkBox.Text = "Show Custom Button";
            this.CutmBtnChkBox.UseVisualStyleBackColor = false;
            this.CutmBtnChkBox.CheckedChanged += new System.EventHandler(this.CutmBtnChkBox_CheckedChanged);
            // 
            // HisbtnChkBox
            // 
            this.HisbtnChkBox.AutoSize = true;
            this.HisbtnChkBox.BackColor = System.Drawing.Color.Transparent;
            this.HisbtnChkBox.Checked = true;
            this.HisbtnChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.HisbtnChkBox.Location = new System.Drawing.Point(7, 48);
            this.HisbtnChkBox.Name = "HisbtnChkBox";
            this.HisbtnChkBox.Size = new System.Drawing.Size(127, 17);
            this.HisbtnChkBox.TabIndex = 0;
            this.HisbtnChkBox.Text = "Show History Buttons";
            this.HisbtnChkBox.UseVisualStyleBackColor = false;
            this.HisbtnChkBox.CheckedChanged += new System.EventHandler(this.HisbtnChkBox_CheckedChanged);
            // 
            // VisStyleCmbBox
            // 
            this.VisStyleCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VisStyleCmbBox.FormattingEnabled = true;
            this.VisStyleCmbBox.Items.AddRange(new object[] {
            "VistaStyle",
            "Office2007Style"});
            this.VisStyleCmbBox.Location = new System.Drawing.Point(3, 97);
            this.VisStyleCmbBox.Name = "VisStyleCmbBox";
            this.VisStyleCmbBox.Size = new System.Drawing.Size(121, 21);
            this.VisStyleCmbBox.TabIndex = 6;
            this.VisStyleCmbBox.SelectedIndexChanged += new System.EventHandler(this.VisStyleCmbBox_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(565, 366);
            this.listView1.TabIndex = 33;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 396);
            this.Controls.Add(this.gradientPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Navigation View";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navigationView1)).EndInit();
            this.navigationView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpTaskBar1)).EndInit();
            this.xpTaskBar1.ResumeLayout(false);
            this.xpTaskBarBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            this.gradientPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.NavigationView navigationView1;
        private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.Navigation.CustomButton customButton1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private System.Windows.Forms.ListView listView1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBar xpTaskBar1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox1;
        private Syncfusion.Windows.Forms.Tools.XPTaskBarBox xpTaskBarBox2;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel4;
        private System.Windows.Forms.CheckBox HistorycheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox RTLChkBox;
        private System.Windows.Forms.CheckBox BarImgChkBox;
        private System.Windows.Forms.CheckBox CutmBtnChkBox;
        private System.Windows.Forms.CheckBox HisbtnChkBox;
        private System.Windows.Forms.ComboBox VisStyleCmbBox;

    }
}

