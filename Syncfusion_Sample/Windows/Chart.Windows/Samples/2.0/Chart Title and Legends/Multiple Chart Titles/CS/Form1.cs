#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
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
using Syncfusion.Drawing;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;


namespace ChartTitle
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : Office2007Form
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private TextBox txtChartTitle;
        private ComboBox cmbAlignment;
        private ComboBox cmbChartTitle;
        private ComboBox comboBox_TitlesDocking;
        private Button button_Addtitle;
        Syncfusion.Windows.Forms.Chart.ChartTitle title;

        private CheckBox chkVisible;
        private Button btnDeleteTitle;
        private ToolTip toolTip1;
        private Label label13;
        private Label label2;
        private Label label1;
        private Label label4;
        private Syncfusion.Windows.Forms.Chart.ChartTitle chartTitle1;
        private Syncfusion.Windows.Forms.Chart.ChartTitle chartTitle2;
        private DesignerPanel designerPanel1;
        private Syncfusion.Windows.Forms.Tools.ImageListAdv imageListAdv1;
        private BannerTextProvider bannerTextProvider1;
        private IContainer components;
        #endregion

        #region Form Constructor, Main and Dispose
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Syncfusion.Windows.Forms.BannerTextInfo bannerTextInfo1 = new Syncfusion.Windows.Forms.BannerTextInfo();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.chartTitle1 = new Syncfusion.Windows.Forms.Chart.ChartTitle();
            this.chartTitle2 = new Syncfusion.Windows.Forms.Chart.ChartTitle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imageListAdv1 = new Syncfusion.Windows.Forms.Tools.ImageListAdv(this.components);
            this.bannerTextProvider1 = new Syncfusion.Windows.Forms.BannerTextProvider(this.components);
            this.designerPanel1 = new DesignerPanel();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.txtChartTitle = new System.Windows.Forms.TextBox();
            this.cmbChartTitle = new System.Windows.Forms.ComboBox();
            this.cmbAlignment = new System.Windows.Forms.ComboBox();
            this.comboBox_TitlesDocking = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button_Addtitle = new System.Windows.Forms.Button();
            this.btnDeleteTitle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel1)).BeginInit();
            this.designerPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.White,
            System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(97)))), ((int)(((byte)(159))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(119)))), ((int)(((byte)(174))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(140)))), ((int)(((byte)(189))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(150)))), ((int)(((byte)(194))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(80)))), ((int)(((byte)(149)))))});
            this.chartControl1.BorderAppearance.SkinStyle = Syncfusion.Windows.Forms.Chart.ChartBorderSkinStyle.Embed;
            this.chartControl1.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.Transparent, System.Drawing.Color.Transparent);
            this.chartControl1.ChartArea.XAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartArea.YAxesLayoutMode = Syncfusion.Windows.Forms.Chart.ChartAxesLayoutMode.SideBySide;
            this.chartControl1.ChartAreaMargins = new Syncfusion.Windows.Forms.Chart.ChartMargins(1, 5, 3, 1);
            this.chartControl1.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.White, System.Drawing.Color.White);
            this.chartControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // 
            // 
            this.chartControl1.Legend.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))), System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(209)))), ((int)(((byte)(226))))));
            this.chartControl1.Legend.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartControl1.Legend.ForeColor = System.Drawing.Color.White;
            this.chartControl1.Legend.Location = new System.Drawing.Point(72, 243);
            this.chartControl1.Legend.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Horizontal;
            this.chartControl1.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartControl1.Legend.RepresentationType = Syncfusion.Windows.Forms.Chart.ChartLegendRepresentationType.None;
            this.chartControl1.Legend.ShowBorder = true;
            this.chartControl1.Location = new System.Drawing.Point(12, 12);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.BreakInfo.LineSpacing = 3;
            this.chartControl1.PrimaryXAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryXAxis.DrawGrid = false;
            this.chartControl1.PrimaryXAxis.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.PrimaryXAxis.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chartControl1.PrimaryXAxis.LabelIntersectAction = Syncfusion.Windows.Forms.Chart.ChartLabelIntersectAction.Wrap;
            this.chartControl1.PrimaryXAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(0, 3, 1);
            this.chartControl1.PrimaryXAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.PrimaryXAxis.SmallTickSize = new System.Drawing.Size(1, 2);
            this.chartControl1.PrimaryXAxis.SmallTicksPerInterval = 12;
            this.chartControl1.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(201)))), ((int)(((byte)(249)))));
            this.chartControl1.PrimaryXAxis.TickSize = new System.Drawing.Size(1, 3);
            this.chartControl1.PrimaryYAxis.BreakInfo.LineSpacing = 3;
            this.chartControl1.PrimaryYAxis.BreakInfo.LineType = Syncfusion.Windows.Forms.Chart.ChartBreakLineType.Straight;
            this.chartControl1.PrimaryYAxis.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.PrimaryYAxis.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chartControl1.PrimaryYAxis.Range = new Syncfusion.Windows.Forms.Chart.MinMaxInfo(6000, 16000, 2000);
            this.chartControl1.PrimaryYAxis.RangeType = Syncfusion.Windows.Forms.Chart.ChartAxisRangeType.Set;
            this.chartControl1.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(201)))), ((int)(((byte)(249)))));
            this.chartControl1.Size = new System.Drawing.Size(526, 358);
            this.chartControl1.TabIndex = 1;
            this.chartControl1.Text = "Imports from Mexico, Japan";
            // 
            // 
            // 
            this.chartControl1.Title.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartControl1.Title.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chartControl1.Title.Margin = 1;
            this.chartControl1.Title.Name = "Def_title";
            this.chartControl1.Title.Text = "Imports from Mexico, Japan";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.Titles.Add(this.chartTitle1);
            this.chartControl1.Titles.Add(this.chartTitle2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            this.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            this.chartControl1.ChartFormatAxisLabel += new Syncfusion.Windows.Forms.Chart.ChartFormatAxisLabelEventHandler(this.chartControl1_ChartFormatAxisLabel);

            // 
            // chartTitle1
            // 
            this.chartTitle1.Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.chartTitle1.Border.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.chartTitle1.Border.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(78)))), ((int)(((byte)(148)))));
            this.chartTitle1.Border.PenType = System.Drawing.Drawing2D.PenType.PathGradient;
            this.chartTitle1.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartTitle1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.chartTitle1.Margin = 1;
            this.chartTitle1.Name = "chartTitle1";
            this.chartTitle1.ShowBorder = true;
            this.chartTitle1.Text = "U.S. Imports, Reported in Millions of Dollars";
            // 
            // chartTitle2
            // 
            this.chartTitle2.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Near;
            this.chartTitle2.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.chartTitle2.ForeColor = System.Drawing.Color.DarkRed;
            this.chartTitle2.Margin = 1;
            this.chartTitle2.Name = "chartTitle2";
            this.chartTitle2.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Bottom;
            this.chartTitle2.Text = "Source: U.S. Bureau of the Census, \n             U.S. Bureau of Economic Analysis" +
                "";
            // 
            // imageListAdv1
            // 
            this.imageListAdv1.Images.AddRange(new System.Drawing.Image[] {
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images"))),
            ((System.Drawing.Image)(resources.GetObject("imageListAdv1.Images1")))});
            // 
            // designerPanel1
            // 
            this.designerPanel1.BackColor = System.Drawing.Color.White;
            this.designerPanel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(220)))), ((int)(((byte)(237))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(230)))), ((int)(((byte)(242))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(236)))), ((int)(((byte)(243))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(245))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))))});
            this.designerPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(220)))), ((int)(((byte)(231)))));
            this.designerPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designerPanel1.Controls.Add(this.chkVisible);
            this.designerPanel1.Controls.Add(this.txtChartTitle);
            this.designerPanel1.Controls.Add(this.cmbChartTitle);
            this.designerPanel1.Controls.Add(this.cmbAlignment);
            this.designerPanel1.Controls.Add(this.comboBox_TitlesDocking);
            this.designerPanel1.Controls.Add(this.label13);
            this.designerPanel1.Controls.Add(this.button_Addtitle);
            this.designerPanel1.Controls.Add(this.btnDeleteTitle);
            this.designerPanel1.Controls.Add(this.label2);
            this.designerPanel1.Controls.Add(this.label1);
            this.designerPanel1.Controls.Add(this.label4);
            this.designerPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designerPanel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.designerPanel1.HeaderImage = ((System.Drawing.Image)(resources.GetObject("designerPanel1.HeaderImage")));
            this.designerPanel1.HeaderText = "       Title";
            this.designerPanel1.Location = new System.Drawing.Point(8, 389);
            this.designerPanel1.Name = "designerPanel1";
            this.designerPanel1.Size = new System.Drawing.Size(535, 117);
            this.designerPanel1.TabIndex = 145;
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.Checked = true;
            this.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkVisible.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVisible.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkVisible.Location = new System.Drawing.Point(8, 35);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(76, 17);
            this.chkVisible.TabIndex = 59;
            this.chkVisible.Text = "Show Title";
            this.chkVisible.UseVisualStyleBackColor = true;
            this.chkVisible.CheckedChanged += new System.EventHandler(this.chkVisible_CheckedChanged);
            // 
            // txtChartTitle
            // 
            bannerTextInfo1.Text = "Enter the text and press + button";
            bannerTextInfo1.Visible = true;
            this.bannerTextProvider1.SetBannerText(this.txtChartTitle, bannerTextInfo1);
            this.txtChartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChartTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txtChartTitle.Location = new System.Drawing.Point(70, 64);
            this.txtChartTitle.Name = "txtChartTitle";
            this.txtChartTitle.Size = new System.Drawing.Size(228, 20);
            this.txtChartTitle.TabIndex = 50;
            this.txtChartTitle.TextChanged += new System.EventHandler(this.txtChartTitle_TextChanged);
            // 
            // cmbChartTitle
            // 
            this.cmbChartTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChartTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChartTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbChartTitle.FormattingEnabled = true;
            this.cmbChartTitle.Location = new System.Drawing.Point(70, 89);
            this.cmbChartTitle.Name = "cmbChartTitle";
            this.cmbChartTitle.Size = new System.Drawing.Size(228, 21);
            this.cmbChartTitle.TabIndex = 53;
            this.cmbChartTitle.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cmbAlignment
            // 
            this.cmbAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlignment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAlignment.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cmbAlignment.FormattingEnabled = true;
            this.cmbAlignment.Items.AddRange(new object[] {
            "Center",
            "Far",
            "Near"});
            this.cmbAlignment.Location = new System.Drawing.Point(419, 64);
            this.cmbAlignment.Name = "cmbAlignment";
            this.cmbAlignment.Size = new System.Drawing.Size(105, 21);
            this.cmbAlignment.TabIndex = 56;
            this.cmbAlignment.SelectedIndexChanged += new System.EventHandler(this.cmbAlignment_SelectedIndexChanged);
            // 
            // comboBox_TitlesDocking
            // 
            this.comboBox_TitlesDocking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TitlesDocking.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_TitlesDocking.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboBox_TitlesDocking.FormattingEnabled = true;
            this.comboBox_TitlesDocking.Items.AddRange(new object[] {
            "Left",
            "Right",
            "Top",
            "Bottom",
            "Floating"});
            this.comboBox_TitlesDocking.Location = new System.Drawing.Point(419, 89);
            this.comboBox_TitlesDocking.Name = "comboBox_TitlesDocking";
            this.comboBox_TitlesDocking.Size = new System.Drawing.Size(105, 21);
            this.comboBox_TitlesDocking.TabIndex = 52;
            this.comboBox_TitlesDocking.SelectedIndexChanged += new System.EventHandler(this.comboBox_TitlesDocking_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label13.Location = new System.Drawing.Point(8, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 126;
            this.label13.Text = "Add Title";
            // 
            // button_Addtitle
            // 
            this.button_Addtitle.Enabled = false;
            this.button_Addtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Addtitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_Addtitle.Location = new System.Drawing.Point(304, 64);
            this.button_Addtitle.Name = "button_Addtitle";
            this.button_Addtitle.Size = new System.Drawing.Size(20, 20);
            this.button_Addtitle.TabIndex = 51;
            this.button_Addtitle.Text = "+";
            this.toolTip1.SetToolTip(this.button_Addtitle, "Add Title");
            this.button_Addtitle.UseVisualStyleBackColor = true;
            this.button_Addtitle.Click += new System.EventHandler(this.button_Addtitle_Click);
            // 
            // btnDeleteTitle
            // 
            this.btnDeleteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteTitle.Location = new System.Drawing.Point(304, 89);
            this.btnDeleteTitle.Name = "btnDeleteTitle";
            this.btnDeleteTitle.Size = new System.Drawing.Size(20, 20);
            this.btnDeleteTitle.TabIndex = 72;
            this.btnDeleteTitle.Text = "-";
            this.toolTip1.SetToolTip(this.btnDeleteTitle, "Remove Title");
            this.btnDeleteTitle.UseVisualStyleBackColor = true;
            this.btnDeleteTitle.Click += new System.EventHandler(this.btnDeleteTitle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 127;
            this.label2.Text = "Select Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(357, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 128;
            this.label1.Text = "Alignment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(357, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 129;
            this.label4.Text = "Position";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 514);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.designerPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Chart Titles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.chartControl1.ResumeLayout(false);
            this.chartControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.designerPanel1)).EndInit();
            this.designerPanel1.ResumeLayout(false);
            this.designerPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeChartData();
            InitializeControlSettings();
            ChartAppearance.ApplyChartStyles(this.chartControl1);
            ResetControls();
        }
        #endregion

        #region Helper Methods

        #region InitializeChartData
        protected void InitializeChartData()
        {
            ChartSeries series = new ChartSeries();
            series.Name = "Series 0";
            series.Type = ChartSeriesType.Line;
            series.Text = "Mexico";
            series.Points.Add(0, 8500);
            series.Points.Add(0.1, 9000);
            series.Points.Add(0.2, 9500);
            series.Points.Add(0.3, 8800);
            series.Points.Add(0.4, 9000);
            series.Points.Add(0.5, 9500);
            series.Points.Add(0.6, 9200);
            series.Points.Add(0.7, 9500);
            series.Points.Add(0.8, 9900);
            series.Points.Add(0.9, 10000);
            series.Points.Add(0.10, 10000);
            series.Points.Add(0.11, 9400);

            series.Points.Add(1, 10000);
            series.Points.Add(1.1, 9500);
            series.Points.Add(1.2, 9900);
            series.Points.Add(1.3, 10000);
            series.Points.Add(1.4, 10100);
            series.Points.Add(1.5, 11000);
            series.Points.Add(1.6, 11100);
            series.Points.Add(1.7, 10000);
            series.Points.Add(1.8, 12500);
            series.Points.Add(1.9, 13000);
            series.Points.Add(1.10, 11000);
            series.Points.Add(1.11, 10000);

            series.Points.Add(2, 10400);
            series.Points.Add(2.1, 10100);
            series.Points.Add(2.2, 12000);
            series.Points.Add(2.3, 10250);
            series.Points.Add(2.4, 11200);
            series.Points.Add(2.5, 11300);
            series.Points.Add(2.6, 11800);
            series.Points.Add(2.7, 10500);
            series.Points.Add(2.8, 10000);
            series.Points.Add(2.9, 10200);
            series.Points.Add(2.10, 11600);
            series.Points.Add(2.11, 11800);
            series.Style.Font.Bold = true;
            this.chartControl1.Series.Add(series);

            ChartSeries series1 = new ChartSeries();
            series1.Name = "Series 1";
            series1.Type = ChartSeriesType.Line;
            series1.Text = "Japan";

            series1.Points.Add(0, 10500);
            series1.Points.Add(0.1, 11000);
            series1.Points.Add(0.2, 11500);
            series1.Points.Add(0.3, 10800);
            series1.Points.Add(0.4, 11000);
            series1.Points.Add(0.5, 11500);
            series1.Points.Add(0.6, 11200);
            series1.Points.Add(0.7, 11500);
            series1.Points.Add(0.8, 11900);
            series1.Points.Add(0.9, 12000);
            series1.Points.Add(0.10, 12000);
            series1.Points.Add(0.11, 11400);

            series1.Points.Add(1, 12300);
            series1.Points.Add(1.1, 12500);
            series1.Points.Add(1.2, 11000);
            series1.Points.Add(1.3, 12800);
            series1.Points.Add(1.4, 13000);
            series1.Points.Add(1.5, 13300);
            series1.Points.Add(1.6, 13500);
            series1.Points.Add(1.7, 13600);
            series1.Points.Add(1.8, 14500);
            series1.Points.Add(1.9, 13000);
            series1.Points.Add(1.10, 12200);
            series1.Points.Add(1.11, 12000);

            series1.Points.Add(2, 12400);
            series1.Points.Add(2.1, 12100);
            series1.Points.Add(2.2, 14000);
            series1.Points.Add(2.3, 12250);
            series1.Points.Add(2.4, 13200);
            series1.Points.Add(2.5, 14300);
            series.Points.Add(2.6, 13000);
            series1.Points.Add(2.7, 12500);
            series1.Points.Add(2.8, 12000);
            series1.Points.Add(2.9, 12200);
            series1.Points.Add(2.10, 13600);
            series1.Points.Add(2.11, 13000);
            series1.Style.Font.Bold = true;
            this.chartControl1.Series.Add(series1);
        }
        #endregion

        #region InitializeControlSettings
        private void InitializeControlSettings()
        {
            this.chartControl1.Series[0].Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            this.chartControl1.Series[0].Style.ImageIndex = 1;
            this.chartControl1.Series[1].Style.Images = new ChartImageCollection(this.imageListAdv1.Images);
            this.chartControl1.Series[1].Style.ImageIndex = 0;

            foreach (Syncfusion.Windows.Forms.Chart.ChartTitle cTitle in this.chartControl1.Titles)
                this.cmbChartTitle.Items.Add(cTitle.Text);
            this.cmbChartTitle.SelectedIndex = 0;
        }
        #endregion

        #region ResetControls
        private void ResetControls()
        {
            this.chkVisible.Checked = this.chartControl1.Titles[this.cmbChartTitle.SelectedIndex].Visible;
            this.cmbAlignment.SelectedItem = (this.chartControl1.Titles[this.cmbChartTitle.SelectedIndex].Alignment.ToString());
            this.comboBox_TitlesDocking.SelectedItem = this.chartControl1.Titles[this.cmbChartTitle.SelectedIndex].Position.ToString();
        }
        #endregion
        #endregion

        #region Events

        # region Titles
        private void button_Addtitle_Click(object sender, EventArgs e)
        {
            if (this.comboBox_TitlesDocking.SelectedItem != null)
            {
                // Add the title to the Chart control's Titles collection.                
                title = new Syncfusion.Windows.Forms.Chart.ChartTitle();
                title.Text = this.txtChartTitle.Text;
                this.cmbChartTitle.Items.Add(this.txtChartTitle.Text);
                title.Position = (ChartDock)Enum.Parse(typeof(ChartDock), this.comboBox_TitlesDocking.SelectedItem.ToString());


                this.chartControl1.Titles.Add(title);
                this.cmbChartTitle.SelectedItem = this.txtChartTitle.Text;
                this.chartControl1.Redraw(true);
                this.txtChartTitle.Text = "";
                this.button_Addtitle.Enabled = false;
            }
            else
                MessageBox.Show("Provide full valid data...");
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Perform customization to the selected Title
            if (this.cmbAlignment.SelectedItem != null)
            {
                ResetControls();
            }
        }
        private void chkVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cmbChartTitle.SelectedIndex > 0)
            {
                this.chartControl1.Titles[this.cmbChartTitle.SelectedIndex].Visible = this.chkVisible.Checked;
            }
        }
        private void cmbAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbChartTitle.SelectedIndex > 0)
            {
                this.chartControl1.Titles[this.cmbChartTitle.SelectedIndex].Alignment = (ChartAlignment)Enum.Parse(typeof(ChartAlignment), this.cmbAlignment.SelectedItem.ToString());
            }
        }
        private void comboBox_TitlesDocking_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbChartTitle.SelectedIndex > 0)
            {
                this.chartControl1.Titles[this.cmbChartTitle.SelectedIndex].Position = (ChartDock)Enum.Parse(typeof(ChartDock), this.comboBox_TitlesDocking.SelectedItem.ToString());
            }
            if (this.comboBox_TitlesDocking.SelectedIndex == 4)

                this.cmbAlignment.Enabled = false;
            else
                this.cmbAlignment.Enabled = true;
        }
        private void txtChartTitle_TextChanged(object sender, EventArgs e)
        {
            if (this.txtChartTitle.Text != "")
                this.button_Addtitle.Enabled = true;
            else
                this.button_Addtitle.Enabled = false;
        }
        private void btnDeleteTitle_Click(object sender, EventArgs e)
        {
            if (this.cmbChartTitle.SelectedItem != null)
            {
                title = new Syncfusion.Windows.Forms.Chart.ChartTitle();
                title.Text = this.cmbChartTitle.SelectedItem.ToString();
                this.chartControl1.Titles.RemoveAt(this.cmbChartTitle.SelectedIndex);
                this.cmbChartTitle.Items.Remove(this.cmbChartTitle.SelectedItem.ToString());

                if (this.chartControl1.Titles.Count.ToString() != "0")
                    this.cmbChartTitle.SelectedIndex = 0;
                this.chartControl1.Refresh();
            }
        }
        # endregion

        private void chartControl1_ChartFormatAxisLabel(object sender, ChartFormatAxisLabelEventArgs e)
        {
            if (e.AxisOrientation == ChartOrientation.Horizontal)
            {
                switch ((int)e.Value)
                {
                    case 0:
                        e.Label = "0";
                        break;
                    case 1:
                        e.Label = "1999";
                        break;
                    case 2:
                        e.Label = "2000";
                        break;
                    case 3:
                        e.Label = "2001";
                        break;
                }
                e.Axis.LabelAlignment = StringAlignment.Near;
            }
            e.Handled = true;
        }
        #endregion
    }
}
