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
using System.Drawing.Drawing2D;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Globalization;
using System.Resources;

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.Reflection;
using System.IO;

namespace CalendarControlsDemo
{
	
	public class Form1 : Office2007Form
    {
        #region Declaration

        private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.PopupControlContainer popupControlContainer1;
        private Syncfusion.Windows.Forms.Tools.MonthCalendarAdv monthCalendarAdv1;
		private System.Windows.Forms.DataGrid dataGrid1;
		private System.ComponentModel.IContainer components;
		DataSet m_dataSetTbg=null;
        private DateTimePickerAdv dateTimePickerAdv15;
        private CheckBoxAdv checkBoxAdv1;
        private GradientLabel gradientLabel1;
        private ComboBox comboBox1;
        private Label label10;
        private CheckBoxAdv checkBoxAdv2;
        private CheckBoxAdv checkBoxAdv3;
        private CheckBoxAdv checkBoxAdv4;
        private Label label7;
        private ComboBox comboBox2;
        private CheckBoxAdv checkBoxAdv5;
        private Label label4;
        private ComboBox comboBox3;
        private Label label88;
        private CheckBoxAdv checkBoxAdv6;
        private Label label1;
        private ComboBox comboBox4;
        private Label label2;
        private ComboBox comboBox5;
        private Label label3;
        private Label label5;
        private GradientPanel gradientPanel3;
        private Label label116;
        private Label label6;
        private CheckBoxAdv checkBoxAdv7;
        private CheckBoxAdv checkBoxAdv8;
        private CheckBoxAdv checkBoxAdv9;
        private Label label36;
        private ToolTip toolTip1;
        private Label label11;
        private ComboBox comboBox7;
        private Label label12;
        private TabControlAdv tabControlAdv1;
        private TabPageAdv tabPageAdv1;
        private TabPageAdv tabPageAdv2;
        private CheckBoxAdv checkBoxAdv10;
        private Label label15;
        private ComboBox comboBox9;
        private Label label16;
        private ComboBox comboBox10;
        private CheckBoxAdv checkBoxAdv11;
        private Label label17;
        private Label label18;
        private CheckBoxAdv checkBoxAdv13;
        private CheckBoxAdv checkBoxAdv14;
        private MonthCalendarAdv monthCalendarAdv2;
        private Label label19;
        private ComboBox comboBox11;
        private Label label20;
        private ComboBox comboBox12;
        private Label label21;
        private Label label22;
        private CheckBoxAdv checkBoxAdv16;
        private CheckBoxAdv checkBoxAdv15;
        private Label label42;
        private ButtonEdit buttonEdit1;
        private ButtonEditChildButton buttonEditChildButton2;
        private ColorDialog colorDialog1;
        private Label label13;
        private ButtonEdit buttonEdit2;
        private ButtonEditChildButton buttonEditChildButton1;
        private Label label24;
        private ButtonEdit buttonEdit3;
        private ButtonEditChildButton buttonEditChildButton3;
        private Label label25;
        private ButtonEdit buttonEdit4;
        private ButtonEditChildButton buttonEditChildButton4;
        private CheckBoxAdv checkBoxAdv12;
        private Label label27;
        private ButtonEdit buttonEdit6;
        private ButtonEditChildButton buttonEditChildButton6;
        private Label label26;
        private ButtonEdit buttonEdit5;
        private ButtonEditChildButton buttonEditChildButton5;
        private Label label28;
        private GradientPanel gradientPanel1;
        private Label label14;
        private GradientPanel gradientPanel2;
        private GradientPanel gradientPanel4;
        private Panel panel1;
        private Panel panel2;
        private Label label9;
        private Label label23;
        private GradientPanel gradientPanel5;
        private Panel panel3;
        private Label label8;
        private Label label30;
        private GradientPanel gradientPanel8;
        private Panel panel6;
        private Label label33;
        private GradientPanel gradientPanel7;
        private Panel panel5;
        private Label label32;
        private GradientPanel gradientPanel6;
        private Panel panel4;
        private Label label31;
        private Label label29;
		DataTable table = null;
        #endregion

        #region Form Constructor and Dispose
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.buttonEdit1.ShowTextBox = true;
            this.buttonEdit2.ShowTextBox = true;
            this.buttonEdit3.ShowTextBox = true;
            this.buttonEdit4.ShowTextBox = true;
            this.buttonEdit5.ShowTextBox = true;
            this.buttonEdit6.ShowTextBox = true;
           

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
        #endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.dataGrid1 = new System.Windows.Forms.DataGrid();
            this.popupControlContainer1 = new Syncfusion.Windows.Forms.PopupControlContainer();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.monthCalendarAdv1 = new Syncfusion.Windows.Forms.Tools.MonthCalendarAdv();
            this.dateTimePickerAdv15 = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxAdv2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv4 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBoxAdv5 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label88 = new System.Windows.Forms.Label();
            this.checkBoxAdv6 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gradientPanel3 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label116 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxAdv7 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv8 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv9 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label36 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.monthCalendarAdv2 = new Syncfusion.Windows.Forms.Tools.MonthCalendarAdv();
            this.gradientPanel8 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.buttonEdit2 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEdit4 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton4 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label25 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.buttonEdit1 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton2 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEdit6 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton6 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEdit3 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton3 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.label26 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.buttonEdit5 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton5 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.checkBoxAdv12 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label33 = new System.Windows.Forms.Label();
            this.gradientPanel7 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBoxAdv11 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBoxAdv15 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv16 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label32 = new System.Windows.Forms.Label();
            this.gradientPanel6 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.checkBoxAdv14 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv13 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBoxAdv10 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gradientPanel5 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.gradientPanel4 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label29 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.popupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendarAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv15.Calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).BeginInit();
            this.gradientPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendarAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).BeginInit();
            this.gradientPanel8.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).BeginInit();
            this.buttonEdit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).BeginInit();
            this.buttonEdit4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).BeginInit();
            this.buttonEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit6)).BeginInit();
            this.buttonEdit6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).BeginInit();
            this.buttonEdit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).BeginInit();
            this.buttonEdit5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).BeginInit();
            this.gradientPanel7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).BeginInit();
            this.gradientPanel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            this.tabPageAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).BeginInit();
            this.gradientPanel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).BeginInit();
            this.gradientPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            this.imageList1.Images.SetKeyName(10, "");
            this.imageList1.Images.SetKeyName(11, "");
            // 
            // dataGrid1
            // 
            this.dataGrid1.AlternatingBackColor = System.Drawing.Color.LightGray;
            this.dataGrid1.BackColor = System.Drawing.Color.DarkGray;
            this.dataGrid1.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.dataGrid1.CaptionFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGrid1.CaptionForeColor = System.Drawing.Color.Navy;
            this.dataGrid1.CaptionText = "Date";
            this.dataGrid1.DataMember = "";
            this.dataGrid1.ForeColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineColor = System.Drawing.Color.Black;
            this.dataGrid1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None;
            this.dataGrid1.HeaderBackColor = System.Drawing.Color.Silver;
            this.dataGrid1.HeaderForeColor = System.Drawing.Color.Black;
            this.dataGrid1.LinkColor = System.Drawing.Color.Navy;
            this.dataGrid1.Location = new System.Drawing.Point(54, 118);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.ParentRowsBackColor = System.Drawing.Color.White;
            this.dataGrid1.ParentRowsForeColor = System.Drawing.Color.Black;
            this.dataGrid1.SelectionBackColor = System.Drawing.Color.Navy;
            this.dataGrid1.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid1.Size = new System.Drawing.Size(122, 111);
            this.dataGrid1.TabIndex = 10;
            // 
            // popupControlContainer1
            // 
            this.popupControlContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(214)))), ((int)(((byte)(252)))));
            this.popupControlContainer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("popupControlContainer1.BackgroundImage")));
            this.popupControlContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.popupControlContainer1.Controls.Add(this.gradientLabel1);
            this.popupControlContainer1.Controls.Add(this.monthCalendarAdv1);
            this.popupControlContainer1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.popupControlContainer1.Location = new System.Drawing.Point(270, 504);
            this.popupControlContainer1.Name = "popupControlContainer1";
            this.popupControlContainer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.popupControlContainer1.Size = new System.Drawing.Size(272, 180);
            this.popupControlContainer1.TabIndex = 5;
            this.popupControlContainer1.Visible = false;
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top)
                        | System.Windows.Forms.Border3DSide.Right)
                        | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Adjust;
            this.gradientLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(179)))), ((int)(((byte)(106)))));
            this.gradientLabel1.Location = new System.Drawing.Point(8, 154);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(244, 18);
            this.gradientLabel1.TabIndex = 2;
            this.gradientLabel1.Text = "Custom Popup Window";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendarAdv1
            // 
            this.monthCalendarAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(203)))));
            this.monthCalendarAdv1.BorderColor = System.Drawing.Color.White;
            this.monthCalendarAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.monthCalendarAdv1.Culture = new System.Globalization.CultureInfo("");
            this.monthCalendarAdv1.DaysFont = new System.Drawing.Font("Verdana", 8F);
            this.monthCalendarAdv1.DaysHeaderInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            this.monthCalendarAdv1.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.monthCalendarAdv1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarAdv1.HeaderHeight = 20;
            this.monthCalendarAdv1.DateSelected += new EventHandler(monthCalendarAdv1_DateSelected);
            this.monthCalendarAdv1.HeaderStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(128)))), ((int)(((byte)(62)))));
            this.monthCalendarAdv1.Location = new System.Drawing.Point(77, 6);
            this.monthCalendarAdv1.Name = "monthCalendarAdv1";
            this.monthCalendarAdv1.ScrollButtonSize = new System.Drawing.Size(24, 24);
            this.monthCalendarAdv1.SelectedDates = new System.DateTime[] {
        new System.DateTime(2008, 4, 4, 6, 25, 49, 390)};
            this.monthCalendarAdv1.Size = new System.Drawing.Size(192, 145);
            this.monthCalendarAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Office2003;
            this.monthCalendarAdv1.TabIndex = 1;
            this.monthCalendarAdv1.WeekFont = new System.Drawing.Font("Verdana", 8F);
            this.monthCalendarAdv1.WeekInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite);
            // 
            // 
            // 
            this.monthCalendarAdv1.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2003;
            this.monthCalendarAdv1.NoneButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.monthCalendarAdv1.NoneButton.Location = new System.Drawing.Point(116, 0);
            this.monthCalendarAdv1.NoneButton.Size = new System.Drawing.Size(72, 20);
            this.monthCalendarAdv1.NoneButton.Text = "None";
            this.monthCalendarAdv1.NoneButton.UseVisualStyle = true;
            // 
            // 
            // 
            this.monthCalendarAdv1.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2003;
            this.monthCalendarAdv1.TodayButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.None;
            this.monthCalendarAdv1.TodayButton.Location = new System.Drawing.Point(0, 0);
            this.monthCalendarAdv1.TodayButton.Size = new System.Drawing.Size(116, 20);
            this.monthCalendarAdv1.TodayButton.Text = "Today";
            this.monthCalendarAdv1.TodayButton.UseVisualStyle = true;
            // 
            // dateTimePickerAdv15
            // 
            this.dateTimePickerAdv15.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.dateTimePickerAdv15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(193)))), ((int)(((byte)(222)))));
            this.dateTimePickerAdv15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dateTimePickerAdv15.Calendar.AllowMultipleSelection = false;
            this.dateTimePickerAdv15.Calendar.Culture = new System.Globalization.CultureInfo("");
            this.dateTimePickerAdv15.Calendar.DaysFont = new System.Drawing.Font("Verdana", 8F);
            this.dateTimePickerAdv15.Calendar.DaysHeaderInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            this.dateTimePickerAdv15.Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerAdv15.Calendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAdv15.Calendar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerAdv15.Calendar.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.dateTimePickerAdv15.Calendar.HeaderEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.dateTimePickerAdv15.Calendar.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePickerAdv15.Calendar.HeaderHeight = 20;
            this.dateTimePickerAdv15.Calendar.HeaderStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.dateTimePickerAdv15.Calendar.HeadForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerAdv15.Calendar.HeadGradient = true;
            this.dateTimePickerAdv15.Calendar.Location = new System.Drawing.Point(0, 0);
            this.dateTimePickerAdv15.Calendar.MinValue = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAdv15.Calendar.Name = "monthCalendar";
            this.dateTimePickerAdv15.Calendar.ScrollButtonSize = new System.Drawing.Size(24, 24);
            this.dateTimePickerAdv15.Calendar.SelectedDates = new System.DateTime[0];
            this.dateTimePickerAdv15.Calendar.Size = new System.Drawing.Size(211, 174);
            this.dateTimePickerAdv15.Calendar.SizeToFit = true;
            this.dateTimePickerAdv15.Calendar.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.dateTimePickerAdv15.Calendar.TabIndex = 0;
            this.dateTimePickerAdv15.Calendar.WeekFont = new System.Drawing.Font("Verdana", 8F);
            this.dateTimePickerAdv15.Calendar.WeekInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite);
            // 
            // 
            // 
            this.dateTimePickerAdv15.Calendar.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.dateTimePickerAdv15.Calendar.NoneButton.Location = new System.Drawing.Point(139, 0);
            this.dateTimePickerAdv15.Calendar.NoneButton.Size = new System.Drawing.Size(72, 20);
            this.dateTimePickerAdv15.Calendar.NoneButton.Text = "None";
            this.dateTimePickerAdv15.Calendar.NoneButton.UseVisualStyle = true;
            // 
            // 
            // 
            this.dateTimePickerAdv15.Calendar.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.dateTimePickerAdv15.Calendar.TodayButton.Location = new System.Drawing.Point(0, 0);
            this.dateTimePickerAdv15.Calendar.TodayButton.Size = new System.Drawing.Size(139, 20);
            this.dateTimePickerAdv15.Calendar.TodayButton.Text = "Today";
            this.dateTimePickerAdv15.Calendar.TodayButton.UseVisualStyle = true;
            this.dateTimePickerAdv15.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAdv15.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.dateTimePickerAdv15.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerAdv15.DropDownImage = null;
            this.dateTimePickerAdv15.Location = new System.Drawing.Point(173, 53);
            this.dateTimePickerAdv15.MinValue = new System.DateTime(((long)(0)));
            this.dateTimePickerAdv15.Name = "dateTimePickerAdv15";
            this.dateTimePickerAdv15.ShowCheckBox = false;
            this.dateTimePickerAdv15.Size = new System.Drawing.Size(241, 20);
            this.dateTimePickerAdv15.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.dateTimePickerAdv15.TabIndex = 9;
            this.dateTimePickerAdv15.Value = new System.DateTime(2007, 11, 21, 11, 34, 33, 781);
            this.dateTimePickerAdv15.VSLikeUpDown = true;
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv1.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv1.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv1.Location = new System.Drawing.Point(23, 47);
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv1.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv1.Size = new System.Drawing.Size(139, 21);
            this.checkBoxAdv1.TabIndex = 10;
            this.checkBoxAdv1.Text = "CustomPopupWindow";
            this.checkBoxAdv1.ThemesEnabled = true;
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(105, 96);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(4, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Culture Settings";
            // 
            // checkBoxAdv2
            // 
            this.checkBoxAdv2.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv2.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv2.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv2.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv2.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv2.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv2.Location = new System.Drawing.Point(6, 182);
            this.checkBoxAdv2.Name = "checkBoxAdv2";
            this.checkBoxAdv2.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv2.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv2.Size = new System.Drawing.Size(157, 21);
            this.checkBoxAdv2.TabIndex = 13;
            this.checkBoxAdv2.Text = "ShowUpDownOnFocus";
            this.checkBoxAdv2.ThemesEnabled = true;
            this.checkBoxAdv2.CheckStateChanged += new System.EventHandler(this.checkBoxAdv2_CheckStateChanged);
            // 
            // checkBoxAdv3
            // 
            this.checkBoxAdv3.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv3.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv3.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv3.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv3.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv3.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv3.Location = new System.Drawing.Point(6, 156);
            this.checkBoxAdv3.Name = "checkBoxAdv3";
            this.checkBoxAdv3.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv3.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv3.Size = new System.Drawing.Size(139, 21);
            this.checkBoxAdv3.TabIndex = 14;
            this.checkBoxAdv3.Text = "ShowCheckBox";
            this.checkBoxAdv3.ThemesEnabled = true;
            this.checkBoxAdv3.CheckStateChanged += new System.EventHandler(this.checkBoxAdv3_CheckStateChanged);
            // 
            // checkBoxAdv4
            // 
            this.checkBoxAdv4.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv4.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv4.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv4.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv4.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv4.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv4.Location = new System.Drawing.Point(6, 208);
            this.checkBoxAdv4.Name = "checkBoxAdv4";
            this.checkBoxAdv4.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv4.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv4.Size = new System.Drawing.Size(139, 21);
            this.checkBoxAdv4.TabIndex = 15;
            this.checkBoxAdv4.Text = "ShowUpDown";
            this.checkBoxAdv4.ThemesEnabled = true;
            this.checkBoxAdv4.CheckStateChanged += new System.EventHandler(this.checkBoxAdv4_CheckStateChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(4, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Custom Format";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "MMMM MMM MM dddd ddd dd yyyy hh mm ss",
            "dddd - dd MMMM yyyy",
            "HH:m , dd MM yyyy"});
            this.comboBox2.Location = new System.Drawing.Point(105, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(106, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // checkBoxAdv5
            // 
            this.checkBoxAdv5.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv5.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv5.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv5.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv5.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv5.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv5.Location = new System.Drawing.Point(23, 71);
            this.checkBoxAdv5.Name = "checkBoxAdv5";
            this.checkBoxAdv5.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv5.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv5.Size = new System.Drawing.Size(139, 21);
            this.checkBoxAdv5.TabIndex = 18;
            this.checkBoxAdv5.Text = "DataBinding";
            this.checkBoxAdv5.ThemesEnabled = true;
            this.checkBoxAdv5.CheckStateChanged += new System.EventHandler(this.checkBoxAdv5_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(4, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Format";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Long",
            "Short",
            "Time",
            "Custom"});
            this.comboBox3.Location = new System.Drawing.Point(105, 46);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(106, 21);
            this.comboBox3.TabIndex = 19;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label88
            // 
            this.label88.BackColor = System.Drawing.Color.Transparent;
            this.label88.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label88.Image = ((System.Drawing.Image)(resources.GetObject("label88.Image")));
            this.label88.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label88.Location = new System.Drawing.Point(6, 5);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(97, 24);
            this.label88.TabIndex = 131;
            this.label88.Text = "Appearance";
            this.label88.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxAdv6
            // 
            this.checkBoxAdv6.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv6.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv6.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv6.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv6.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv6.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv6.Location = new System.Drawing.Point(6, 130);
            this.checkBoxAdv6.Name = "checkBoxAdv6";
            this.checkBoxAdv6.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv6.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv6.Size = new System.Drawing.Size(117, 21);
            this.checkBoxAdv6.TabIndex = 133;
            this.checkBoxAdv6.Text = "ThemesEnabled";
            this.checkBoxAdv6.ThemesEnabled = true;
            this.checkBoxAdv6.CheckStateChanged += new System.EventHandler(this.checkBoxAdv6_CheckStateChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 135;
            this.label1.Text = "Visual Styles";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Default",
            "OfficeXP",
            "Office2007"});
            this.comboBox4.Location = new System.Drawing.Point(107, 47);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(106, 21);
            this.comboBox4.TabIndex = 134;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 137;
            this.label2.Text = "Office2007 Color Scheme";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Blue",
            "Silver",
            "Black"});
            this.comboBox5.Location = new System.Drawing.Point(107, 71);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(106, 21);
            this.comboBox5.TabIndex = 136;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 139;
            this.label3.Text = "Behavior";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(0, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 2);
            this.label5.TabIndex = 138;
            // 
            // gradientPanel3
            // 
            this.gradientPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.gradientPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel3.Controls.Add(this.dateTimePickerAdv15);
            this.gradientPanel3.Controls.Add(this.label116);
            this.gradientPanel3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel3.Location = new System.Drawing.Point(86, 34);
            this.gradientPanel3.Name = "gradientPanel3";
            this.gradientPanel3.Size = new System.Drawing.Size(576, 87);
            this.gradientPanel3.TabIndex = 140;
            // 
            // label116
            // 
            this.label116.BackColor = System.Drawing.Color.Transparent;
            this.label116.Dock = System.Windows.Forms.DockStyle.Top;
            this.label116.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label116.Image = ((System.Drawing.Image)(resources.GetObject("label116.Image")));
            this.label116.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label116.Location = new System.Drawing.Point(0, 0);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(574, 36);
            this.label116.TabIndex = 1;
            this.label116.Text = "DateTimePickerAdv is an advanced DateTimePicker control that provides an easy way" +
                " to implement a \r\nculture based DateTimePicker in an application. It has various" +
                " features as shown below.";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 24);
            this.label6.TabIndex = 142;
            this.label6.Text = "Data Association";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxAdv7
            // 
            this.checkBoxAdv7.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv7.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv7.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv7.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv7.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv7.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv7.Location = new System.Drawing.Point(4, 145);
            this.checkBoxAdv7.Name = "checkBoxAdv7";
            this.checkBoxAdv7.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv7.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv7.Size = new System.Drawing.Size(139, 21);
            this.checkBoxAdv7.TabIndex = 143;
            this.checkBoxAdv7.Text = "ReadOnly";
            this.checkBoxAdv7.ThemesEnabled = true;
            this.checkBoxAdv7.CheckStateChanged += new System.EventHandler(this.checkBoxAdv7_CheckStateChanged);
            // 
            // checkBoxAdv8
            // 
            this.checkBoxAdv8.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv8.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv8.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv8.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv8.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv8.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv8.Location = new System.Drawing.Point(4, 171);
            this.checkBoxAdv8.Name = "checkBoxAdv8";
            this.checkBoxAdv8.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv8.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv8.Size = new System.Drawing.Size(139, 21);
            this.checkBoxAdv8.TabIndex = 144;
            this.checkBoxAdv8.Text = "RightToLeft";
            this.checkBoxAdv8.ThemesEnabled = true;
            this.checkBoxAdv8.CheckStateChanged += new System.EventHandler(this.checkBoxAdv8_CheckStateChanged);
            // 
            // checkBoxAdv9
            // 
            this.checkBoxAdv9.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv9.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv9.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv9.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv9.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv9.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv9.Location = new System.Drawing.Point(6, 104);
            this.checkBoxAdv9.Name = "checkBoxAdv9";
            this.checkBoxAdv9.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv9.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv9.Size = new System.Drawing.Size(124, 21);
            this.checkBoxAdv9.TabIndex = 147;
            this.checkBoxAdv9.Text = "UseEnhancedMenu";
            this.checkBoxAdv9.ThemesEnabled = true;
            this.checkBoxAdv9.CheckStateChanged += new System.EventHandler(this.checkBoxAdv9_CheckStateChanged);
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Image = ((System.Drawing.Image)(resources.GetObject("label36.Image")));
            this.label36.Location = new System.Drawing.Point(132, 106);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(20, 20);
            this.label36.TabIndex = 148;
            this.toolTip1.SetToolTip(this.label36, "ContextMenu will be a Syncfusion XPMenu\r\nRight Click on the DateTimePickerAdv to " +
                    "\r\nview the contextmenu.");
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.Location = new System.Drawing.Point(212, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 20);
            this.label12.TabIndex = 151;
            this.toolTip1.SetToolTip(this.label12, "Click the None button in the calendar to clear the date.\r\nNow press keys to toggl" +
                    "e the date. These kays can be \r\nnumeric keys, arrow keys or any keys.");
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(4, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 18);
            this.label11.TabIndex = 150;
            this.label11.Text = "NullModeKeyReset";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "Arrow Keys",
            "Numeric Keys",
            "Any Key"});
            this.comboBox7.Location = new System.Drawing.Point(105, 121);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(106, 21);
            this.comboBox7.TabIndex = 149;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControlAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabControlAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(759, 534);
            this.tabControlAdv1.TabGap = 10;
            this.tabControlAdv1.TabIndex = 152;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(253)))));
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.Controls.Add(this.monthCalendarAdv2);
            this.tabPageAdv1.Controls.Add(this.gradientPanel8);
            this.tabPageAdv1.Controls.Add(this.label33);
            this.tabPageAdv1.Controls.Add(this.gradientPanel7);
            this.tabPageAdv1.Controls.Add(this.label32);
            this.tabPageAdv1.Controls.Add(this.gradientPanel6);
            this.tabPageAdv1.Controls.Add(this.gradientPanel1);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 29);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.Size = new System.Drawing.Size(757, 504);
            this.tabPageAdv1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPageAdv1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "MonthCalendarAdv";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // monthCalendarAdv2
            // 
            this.monthCalendarAdv2.BackColor = System.Drawing.Color.White;
            this.monthCalendarAdv2.Culture = new System.Globalization.CultureInfo("");
            this.monthCalendarAdv2.DayNamesColor = System.Drawing.Color.Black;
            this.monthCalendarAdv2.DaysColor = System.Drawing.Color.Black;
            this.monthCalendarAdv2.DaysFont = new System.Drawing.Font("Verdana", 8F);
            this.monthCalendarAdv2.DaysHeaderInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            this.monthCalendarAdv2.GridBackColor = System.Drawing.Color.White;
            this.monthCalendarAdv2.GridLines = Syncfusion.Windows.Forms.Grid.GridBorderStyle.None;
            this.monthCalendarAdv2.HeaderEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.monthCalendarAdv2.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.monthCalendarAdv2.HeaderHeight = 20;
            this.monthCalendarAdv2.HeaderStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(252)))));
            this.monthCalendarAdv2.HeadForeColor = System.Drawing.SystemColors.ControlText;
            this.monthCalendarAdv2.HeadGradient = true;
            this.monthCalendarAdv2.Location = new System.Drawing.Point(281, 32);
            this.monthCalendarAdv2.Name = "monthCalendarAdv2";
            this.monthCalendarAdv2.ScrollButtonSize = new System.Drawing.Size(24, 24);
            this.monthCalendarAdv2.SelectedDates = new System.DateTime[] {
        new System.DateTime(2008, 4, 4, 6, 25, 50, 921)};
            this.monthCalendarAdv2.Size = new System.Drawing.Size(192, 169);
            this.monthCalendarAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.monthCalendarAdv2.TabIndex = 0;
            this.monthCalendarAdv2.WeekFont = new System.Drawing.Font("Verdana", 8F);
            this.monthCalendarAdv2.WeekInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.PeachPuff, System.Drawing.Color.AntiqueWhite);
            this.monthCalendarAdv2.WeekTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.monthCalendarAdv2.NoneButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.monthCalendarAdv2.NoneButton.Size = new System.Drawing.Size(72, 20);
            this.monthCalendarAdv2.NoneButton.Text = "None";
            this.monthCalendarAdv2.NoneButton.UseVisualStyle = true;
            // 
            // 
            // 
            this.monthCalendarAdv2.TodayButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2007;
            this.monthCalendarAdv2.TodayButton.Location = new System.Drawing.Point(0, 0);
            this.monthCalendarAdv2.TodayButton.Size = new System.Drawing.Size(120, 20);
            this.monthCalendarAdv2.TodayButton.Text = "Today";
            this.monthCalendarAdv2.TodayButton.UseVisualStyle = true;
            // 
            // gradientPanel8
            // 
            this.gradientPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.gradientPanel8.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(248))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(248)))))});
            this.gradientPanel8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.gradientPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel8.Controls.Add(this.panel6);
            this.gradientPanel8.Controls.Add(this.label13);
            this.gradientPanel8.Controls.Add(this.buttonEdit2);
            this.gradientPanel8.Controls.Add(this.buttonEdit4);
            this.gradientPanel8.Controls.Add(this.label25);
            this.gradientPanel8.Controls.Add(this.label42);
            this.gradientPanel8.Controls.Add(this.label27);
            this.gradientPanel8.Controls.Add(this.buttonEdit1);
            this.gradientPanel8.Controls.Add(this.buttonEdit6);
            this.gradientPanel8.Controls.Add(this.buttonEdit3);
            this.gradientPanel8.Controls.Add(this.label26);
            this.gradientPanel8.Controls.Add(this.label24);
            this.gradientPanel8.Controls.Add(this.buttonEdit5);
            this.gradientPanel8.Controls.Add(this.checkBoxAdv12);
            this.gradientPanel8.Location = new System.Drawing.Point(511, 234);
            this.gradientPanel8.Name = "gradientPanel8";
            this.gradientPanel8.Size = new System.Drawing.Size(224, 246);
            this.gradientPanel8.TabIndex = 193;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.panel6.Controls.Add(this.label18);
            this.panel6.Controls.Add(this.label28);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(222, 35);
            this.panel6.TabIndex = 157;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label18.Location = new System.Drawing.Point(0, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(222, 2);
            this.label18.TabIndex = 152;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label28.Image = ((System.Drawing.Image)(resources.GetObject("label28.Image")));
            this.label28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label28.Location = new System.Drawing.Point(5, 4);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(106, 24);
            this.label28.TabIndex = 187;
            this.label28.Text = "Color Settings";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(10, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 175;
            this.label13.Text = "Back Color";
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.BackColor = System.Drawing.Color.White;
            this.buttonEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit2.Buttons.Add(this.buttonEditChildButton1);
            this.buttonEdit2.Controls.Add(this.buttonEditChildButton1);
            this.buttonEdit2.Location = new System.Drawing.Point(109, 45);
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.ShowTextBox = false;
            this.buttonEdit2.Size = new System.Drawing.Size(102, 26);
            this.buttonEdit2.TabIndex = 176;
            this.buttonEdit2.UseVisualStyle = true;
            this.buttonEdit2.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit2_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 18;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            // 
            // buttonEdit4
            // 
            this.buttonEdit4.BackColor = System.Drawing.Color.White;
            this.buttonEdit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit4.Buttons.Add(this.buttonEditChildButton4);
            this.buttonEdit4.Controls.Add(this.buttonEditChildButton4);
            this.buttonEdit4.Location = new System.Drawing.Point(109, 74);
            this.buttonEdit4.Name = "buttonEdit4";
            this.buttonEdit4.ShowTextBox = false;
            this.buttonEdit4.Size = new System.Drawing.Size(102, 26);
            this.buttonEdit4.TabIndex = 180;
            this.buttonEdit4.UseVisualStyle = true;
            this.buttonEdit4.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit4_ButtonClicked);
            // 
            // buttonEditChildButton4
            // 
            this.buttonEditChildButton4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton4.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton4.Image = null;
            this.buttonEditChildButton4.Name = "buttonEditChildButton4";
            this.buttonEditChildButton4.PreferredWidth = 18;
            this.buttonEditChildButton4.TabIndex = 1;
            this.buttonEditChildButton4.Text = "...";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(10, 74);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 13);
            this.label25.TabIndex = 179;
            this.label25.Text = "Grid BackColor";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Location = new System.Drawing.Point(10, 102);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(84, 13);
            this.label42.TabIndex = 173;
            this.label42.Text = "Day Name Color";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(10, 215);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(91, 13);
            this.label27.TabIndex = 184;
            this.label27.Text = "Header End Color";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.BackColor = System.Drawing.Color.White;
            this.buttonEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit1.Buttons.Add(this.buttonEditChildButton2);
            this.buttonEdit1.Controls.Add(this.buttonEditChildButton2);
            this.buttonEdit1.Location = new System.Drawing.Point(109, 102);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.ShowTextBox = false;
            this.buttonEdit1.Size = new System.Drawing.Size(102, 26);
            this.buttonEdit1.TabIndex = 174;
            this.buttonEdit1.UseVisualStyle = true;
            this.buttonEdit1.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit1_ButtonClicked);
            // 
            // buttonEditChildButton2
            // 
            this.buttonEditChildButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton2.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton2.Image = null;
            this.buttonEditChildButton2.Name = "buttonEditChildButton2";
            this.buttonEditChildButton2.PreferredWidth = 18;
            this.buttonEditChildButton2.TabIndex = 1;
            this.buttonEditChildButton2.Text = "...";
            // 
            // buttonEdit6
            // 
            this.buttonEdit6.BackColor = System.Drawing.Color.White;
            this.buttonEdit6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit6.Buttons.Add(this.buttonEditChildButton6);
            this.buttonEdit6.Controls.Add(this.buttonEditChildButton6);
            this.buttonEdit6.Location = new System.Drawing.Point(109, 213);
            this.buttonEdit6.Name = "buttonEdit6";
            this.buttonEdit6.ShowTextBox = false;
            this.buttonEdit6.Size = new System.Drawing.Size(102, 26);
            this.buttonEdit6.TabIndex = 185;
            this.buttonEdit6.UseVisualStyle = true;
            this.buttonEdit6.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit6_ButtonClicked);
            // 
            // buttonEditChildButton6
            // 
            this.buttonEditChildButton6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton6.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton6.Image = null;
            this.buttonEditChildButton6.Name = "buttonEditChildButton6";
            this.buttonEditChildButton6.PreferredWidth = 18;
            this.buttonEditChildButton6.TabIndex = 1;
            this.buttonEditChildButton6.Text = "...";
            // 
            // buttonEdit3
            // 
            this.buttonEdit3.BackColor = System.Drawing.Color.White;
            this.buttonEdit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit3.Buttons.Add(this.buttonEditChildButton3);
            this.buttonEdit3.Controls.Add(this.buttonEditChildButton3);
            this.buttonEdit3.Location = new System.Drawing.Point(109, 131);
            this.buttonEdit3.Name = "buttonEdit3";
            this.buttonEdit3.ShowTextBox = false;
            this.buttonEdit3.Size = new System.Drawing.Size(102, 26);
            this.buttonEdit3.TabIndex = 178;
            this.buttonEdit3.UseVisualStyle = true;
            this.buttonEdit3.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit3_ButtonClicked);
            // 
            // buttonEditChildButton3
            // 
            this.buttonEditChildButton3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton3.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton3.Image = null;
            this.buttonEditChildButton3.Name = "buttonEditChildButton3";
            this.buttonEditChildButton3.PreferredWidth = 18;
            this.buttonEditChildButton3.TabIndex = 1;
            this.buttonEditChildButton3.Text = "...";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(10, 186);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(94, 13);
            this.label26.TabIndex = 182;
            this.label26.Text = "Header Start Color";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(10, 131);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 13);
            this.label24.TabIndex = 177;
            this.label24.Text = "Day Color";
            // 
            // buttonEdit5
            // 
            this.buttonEdit5.BackColor = System.Drawing.Color.White;
            this.buttonEdit5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit5.Buttons.Add(this.buttonEditChildButton5);
            this.buttonEdit5.Controls.Add(this.buttonEditChildButton5);
            this.buttonEdit5.Location = new System.Drawing.Point(109, 184);
            this.buttonEdit5.Name = "buttonEdit5";
            this.buttonEdit5.ShowTextBox = false;
            this.buttonEdit5.Size = new System.Drawing.Size(102, 26);
            this.buttonEdit5.TabIndex = 183;
            this.buttonEdit5.UseVisualStyle = true;
            this.buttonEdit5.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit5_ButtonClicked);
            // 
            // buttonEditChildButton5
            // 
            this.buttonEditChildButton5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton5.ComboEditBackColor = System.Drawing.Color.White;
            this.buttonEditChildButton5.Image = null;
            this.buttonEditChildButton5.Name = "buttonEditChildButton5";
            this.buttonEditChildButton5.PreferredWidth = 18;
            this.buttonEditChildButton5.TabIndex = 1;
            this.buttonEditChildButton5.Text = "...";
            // 
            // checkBoxAdv12
            // 
            this.checkBoxAdv12.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv12.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv12.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv12.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv12.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv12.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv12.Location = new System.Drawing.Point(10, 159);
            this.checkBoxAdv12.Name = "checkBoxAdv12";
            this.checkBoxAdv12.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv12.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv12.Size = new System.Drawing.Size(105, 15);
            this.checkBoxAdv12.TabIndex = 181;
            this.checkBoxAdv12.Text = "HeaderVerticalGradient";
            this.checkBoxAdv12.ThemesEnabled = true;
            this.checkBoxAdv12.CheckStateChanged += new System.EventHandler(this.checkBoxAdv12_CheckStateChanged);
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.White;
            this.label33.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label33.Location = new System.Drawing.Point(0, 500);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(757, 2);
            this.label33.TabIndex = 192;
            // 
            // gradientPanel7
            // 
            this.gradientPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.gradientPanel7.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(248))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(248)))))});
            this.gradientPanel7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.gradientPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel7.Controls.Add(this.panel5);
            this.gradientPanel7.Controls.Add(this.label16);
            this.gradientPanel7.Controls.Add(this.checkBoxAdv11);
            this.gradientPanel7.Controls.Add(this.comboBox10);
            this.gradientPanel7.Controls.Add(this.comboBox9);
            this.gradientPanel7.Controls.Add(this.label15);
            this.gradientPanel7.Controls.Add(this.checkBoxAdv15);
            this.gradientPanel7.Controls.Add(this.checkBoxAdv16);
            this.gradientPanel7.Location = new System.Drawing.Point(263, 234);
            this.gradientPanel7.Name = "gradientPanel7";
            this.gradientPanel7.Size = new System.Drawing.Size(224, 246);
            this.gradientPanel7.TabIndex = 191;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.panel5.Controls.Add(this.label21);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(222, 35);
            this.panel5.TabIndex = 157;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label21.Location = new System.Drawing.Point(0, 33);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(222, 2);
            this.label21.TabIndex = 169;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label17.Location = new System.Drawing.Point(3, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 23);
            this.label17.TabIndex = 153;
            this.label17.Text = "Appearance";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(9, 47);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 20);
            this.label16.TabIndex = 156;
            this.label16.Text = "Visual Styles";
            // 
            // checkBoxAdv11
            // 
            this.checkBoxAdv11.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv11.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv11.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv11.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv11.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv11.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv11.Location = new System.Drawing.Point(9, 117);
            this.checkBoxAdv11.Name = "checkBoxAdv11";
            this.checkBoxAdv11.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv11.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv11.Size = new System.Drawing.Size(117, 21);
            this.checkBoxAdv11.TabIndex = 154;
            this.checkBoxAdv11.Text = "ThemesEnabled";
            this.checkBoxAdv11.ThemesEnabled = true;
            this.checkBoxAdv11.CheckStateChanged += new System.EventHandler(this.checkBoxAdv11_CheckStateChanged);
            // 
            // comboBox10
            // 
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(107, 47);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(106, 21);
            this.comboBox10.TabIndex = 155;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // comboBox9
            // 
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "Blue",
            "Silver",
            "Black"});
            this.comboBox9.Location = new System.Drawing.Point(107, 79);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(106, 21);
            this.comboBox9.TabIndex = 157;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(9, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 26);
            this.label15.TabIndex = 158;
            this.label15.Text = "Office2007 Color Scheme";
            // 
            // checkBoxAdv15
            // 
            this.checkBoxAdv15.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv15.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv15.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv15.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv15.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv15.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv15.Location = new System.Drawing.Point(9, 151);
            this.checkBoxAdv15.Name = "checkBoxAdv15";
            this.checkBoxAdv15.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv15.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv15.Size = new System.Drawing.Size(157, 21);
            this.checkBoxAdv15.TabIndex = 171;
            this.checkBoxAdv15.Text = "LeftScrollButtonImage";
            this.checkBoxAdv15.ThemesEnabled = true;
            this.checkBoxAdv15.CheckStateChanged += new System.EventHandler(this.checkBoxAdv15_CheckStateChanged);
            // 
            // checkBoxAdv16
            // 
            this.checkBoxAdv16.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv16.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv16.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv16.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv16.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv16.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv16.Location = new System.Drawing.Point(9, 184);
            this.checkBoxAdv16.Name = "checkBoxAdv16";
            this.checkBoxAdv16.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv16.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv16.Size = new System.Drawing.Size(159, 21);
            this.checkBoxAdv16.TabIndex = 172;
            this.checkBoxAdv16.Text = "RightScrollButtonImage";
            this.checkBoxAdv16.ThemesEnabled = true;
            this.checkBoxAdv16.CheckStateChanged += new System.EventHandler(this.checkBoxAdv16_CheckStateChanged);
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.White;
            this.label32.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label32.Location = new System.Drawing.Point(0, 502);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(757, 2);
            this.label32.TabIndex = 190;
            // 
            // gradientPanel6
            // 
            this.gradientPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.gradientPanel6.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(248))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(248)))))});
            this.gradientPanel6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.gradientPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel6.Controls.Add(this.panel4);
            this.gradientPanel6.Controls.Add(this.label20);
            this.gradientPanel6.Controls.Add(this.checkBoxAdv14);
            this.gradientPanel6.Controls.Add(this.checkBoxAdv13);
            this.gradientPanel6.Controls.Add(this.checkBoxAdv10);
            this.gradientPanel6.Controls.Add(this.label22);
            this.gradientPanel6.Controls.Add(this.comboBox12);
            this.gradientPanel6.Controls.Add(this.comboBox11);
            this.gradientPanel6.Location = new System.Drawing.Point(15, 234);
            this.gradientPanel6.Name = "gradientPanel6";
            this.gradientPanel6.Size = new System.Drawing.Size(224, 246);
            this.gradientPanel6.TabIndex = 189;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.panel4.Controls.Add(this.label31);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 35);
            this.panel4.TabIndex = 157;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.White;
            this.label31.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label31.Location = new System.Drawing.Point(0, 33);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(222, 2);
            this.label31.TabIndex = 139;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label19.Image = ((System.Drawing.Image)(resources.GetObject("label19.Image")));
            this.label19.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label19.Location = new System.Drawing.Point(10, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 24);
            this.label19.TabIndex = 170;
            this.label19.Text = "Behavior";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(10, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(85, 20);
            this.label20.TabIndex = 164;
            this.label20.Text = "Culture Settings";
            // 
            // checkBoxAdv14
            // 
            this.checkBoxAdv14.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv14.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv14.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv14.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv14.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv14.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv14.Location = new System.Drawing.Point(10, 183);
            this.checkBoxAdv14.Name = "checkBoxAdv14";
            this.checkBoxAdv14.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv14.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv14.Size = new System.Drawing.Size(157, 21);
            this.checkBoxAdv14.TabIndex = 149;
            this.checkBoxAdv14.Text = "MouseDragMultiSelect";
            this.checkBoxAdv14.ThemesEnabled = true;
            this.checkBoxAdv14.CheckStateChanged += new System.EventHandler(this.checkBoxAdv14_CheckStateChanged);
            // 
            // checkBoxAdv13
            // 
            this.checkBoxAdv13.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv13.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv13.Checked = true;
            this.checkBoxAdv13.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv13.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv13.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv13.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv13.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv13.Location = new System.Drawing.Point(10, 149);
            this.checkBoxAdv13.Name = "checkBoxAdv13";
            this.checkBoxAdv13.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv13.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv13.Size = new System.Drawing.Size(182, 21);
            this.checkBoxAdv13.TabIndex = 150;
            this.checkBoxAdv13.Text = "Allow Multiple Selection";
            this.checkBoxAdv13.ThemesEnabled = true;
            this.checkBoxAdv13.CheckStateChanged += new System.EventHandler(this.checkBoxAdv13_CheckStateChanged);
            // 
            // checkBoxAdv10
            // 
            this.checkBoxAdv10.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxAdv10.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv10.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBoxAdv10.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBoxAdv10.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv10.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBoxAdv10.Location = new System.Drawing.Point(10, 115);
            this.checkBoxAdv10.Name = "checkBoxAdv10";
            this.checkBoxAdv10.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv10.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv10.Size = new System.Drawing.Size(139, 21);
            this.checkBoxAdv10.TabIndex = 161;
            this.checkBoxAdv10.Text = "ShowWeekNumbers";
            this.checkBoxAdv10.ThemesEnabled = true;
            this.checkBoxAdv10.CheckStateChanged += new System.EventHandler(this.checkBoxAdv10_CheckStateChanged);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(10, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 20);
            this.label22.TabIndex = 166;
            this.label22.Text = "FirstDayOfWeek";
            // 
            // comboBox12
            // 
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox12.FormattingEnabled = true;
            this.comboBox12.Location = new System.Drawing.Point(101, 79);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(106, 21);
            this.comboBox12.TabIndex = 165;
            this.comboBox12.SelectedIndexChanged += new System.EventHandler(this.comboBox12_SelectedIndexChanged);
            // 
            // comboBox11
            // 
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(101, 49);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(106, 21);
            this.comboBox11.TabIndex = 163;
            this.comboBox11.SelectedIndexChanged += new System.EventHandler(this.comboBox11_SelectedIndexChanged);
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label14);
            this.gradientPanel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(99, 9);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(595, 203);
            this.gradientPanel1.TabIndex = 188;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(593, 39);
            this.label14.TabIndex = 1;
            this.label14.Text = "MonthCalendarAdv is an advanced calendar control that can display a full month of" +
                " the year.";
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.Controls.Add(this.gradientPanel5);
            this.tabPageAdv2.Controls.Add(this.label8);
            this.tabPageAdv2.Controls.Add(this.label30);
            this.tabPageAdv2.Controls.Add(this.label23);
            this.tabPageAdv2.Controls.Add(this.gradientPanel4);
            this.tabPageAdv2.Controls.Add(this.gradientPanel2);
            this.tabPageAdv2.Controls.Add(this.popupControlContainer1);
            this.tabPageAdv2.Controls.Add(this.gradientPanel3);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 29);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.Size = new System.Drawing.Size(757, 504);
            this.tabPageAdv2.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.tabPageAdv2.TabIndex = 1;
            this.tabPageAdv2.Text = "DateTimePickerAdv";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // gradientPanel5
            // 
            this.gradientPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.gradientPanel5.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(248))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(248)))))});
            this.gradientPanel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.gradientPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel5.Controls.Add(this.panel3);
            this.gradientPanel5.Controls.Add(this.label4);
            this.gradientPanel5.Controls.Add(this.label7);
            this.gradientPanel5.Controls.Add(this.label10);
            this.gradientPanel5.Controls.Add(this.checkBoxAdv7);
            this.gradientPanel5.Controls.Add(this.checkBoxAdv8);
            this.gradientPanel5.Controls.Add(this.label11);
            this.gradientPanel5.Controls.Add(this.label12);
            this.gradientPanel5.Controls.Add(this.comboBox3);
            this.gradientPanel5.Controls.Add(this.comboBox2);
            this.gradientPanel5.Controls.Add(this.comboBox7);
            this.gradientPanel5.Controls.Add(this.comboBox1);
            this.gradientPanel5.Location = new System.Drawing.Point(262, 192);
            this.gradientPanel5.Name = "gradientPanel5";
            this.gradientPanel5.Size = new System.Drawing.Size(231, 246);
            this.gradientPanel5.TabIndex = 158;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 35);
            this.panel3.TabIndex = 156;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Location = new System.Drawing.Point(0, 500);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(757, 2);
            this.label8.TabIndex = 156;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label30.Image = ((System.Drawing.Image)(resources.GetObject("label30.Image")));
            this.label30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label30.Location = new System.Drawing.Point(-184, -49);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(126, 24);
            this.label30.TabIndex = 157;
            this.label30.Text = "Data Association";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label23.Location = new System.Drawing.Point(0, 502);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(757, 2);
            this.label23.TabIndex = 155;
            // 
            // gradientPanel4
            // 
            this.gradientPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.gradientPanel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(248))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(248)))))});
            this.gradientPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.gradientPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel4.Controls.Add(this.panel2);
            this.gradientPanel4.Controls.Add(this.checkBoxAdv1);
            this.gradientPanel4.Controls.Add(this.checkBoxAdv5);
            this.gradientPanel4.Controls.Add(this.dataGrid1);
            this.gradientPanel4.Location = new System.Drawing.Point(512, 193);
            this.gradientPanel4.Name = "gradientPanel4";
            this.gradientPanel4.Size = new System.Drawing.Size(231, 246);
            this.gradientPanel4.TabIndex = 154;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(229, 35);
            this.panel2.TabIndex = 156;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(0, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 2);
            this.label9.TabIndex = 139;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(229)))), ((int)(((byte)(249)))));
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(248))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(236)))), ((int)(((byte)(254))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(227)))), ((int)(((byte)(248)))))});
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(199)))), ((int)(((byte)(235)))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.panel1);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv2);
            this.gradientPanel2.Controls.Add(this.label36);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv3);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv4);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv9);
            this.gradientPanel2.Controls.Add(this.checkBoxAdv6);
            this.gradientPanel2.Controls.Add(this.comboBox4);
            this.gradientPanel2.Controls.Add(this.label1);
            this.gradientPanel2.Controls.Add(this.label2);
            this.gradientPanel2.Controls.Add(this.comboBox5);
            this.gradientPanel2.Location = new System.Drawing.Point(12, 192);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(231, 246);
            this.gradientPanel2.TabIndex = 153;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(241)))), ((int)(((byte)(253)))));
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label88);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 35);
            this.panel1.TabIndex = 155;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.White;
            this.label29.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label29.Location = new System.Drawing.Point(0, 33);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(229, 2);
            this.label29.TabIndex = 139;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(759, 534);
            this.Controls.Add(this.tabControlAdv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendar Controls";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.popupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendarAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv15.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimePickerAdv15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel3)).EndInit();
            this.gradientPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monthCalendarAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel8)).EndInit();
            this.gradientPanel8.ResumeLayout(false);
            this.gradientPanel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).EndInit();
            this.buttonEdit2.ResumeLayout(false);
            this.buttonEdit2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).EndInit();
            this.buttonEdit4.ResumeLayout(false);
            this.buttonEdit4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).EndInit();
            this.buttonEdit1.ResumeLayout(false);
            this.buttonEdit1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit6)).EndInit();
            this.buttonEdit6.ResumeLayout(false);
            this.buttonEdit6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).EndInit();
            this.buttonEdit3.ResumeLayout(false);
            this.buttonEdit3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).EndInit();
            this.buttonEdit5.ResumeLayout(false);
            this.buttonEdit5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel7)).EndInit();
            this.gradientPanel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel6)).EndInit();
            this.gradientPanel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            this.tabPageAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel5)).EndInit();
            this.gradientPanel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel4)).EndInit();
            this.gradientPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        void monthCalendarAdv1_DateSelected(object sender, EventArgs e)
        {
            this.popupControlContainer1.HidePopup();
            this.dateTimePickerAdv15.Value = this.monthCalendarAdv1.SelectedDates[0];
        }
		#endregion

        #region Main
        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
        }
        #endregion

        #region FormLoad
        Image leftButtonImg;
        Image rightButtonImg;
        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assem = this.GetType().Assembly;
            Stream imgStr1 = assem.GetManifestResourceStream("CalendarControls.arrow_left_blue.png");
            Stream imgStr2 = assem.GetManifestResourceStream("CalendarControls.arrow_right_blue.png");
           leftButtonImg = Image.FromStream(imgStr1);
           rightButtonImg = Image.FromStream(imgStr2);

            // Load all Specific Cultures to the Combo Box
            foreach (CultureInfo info in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                comboBox1.Items.Add(info.Name);
                comboBox11.Items.Add(info.Name);
            }
           
            this.comboBox2.SelectedIndex = 0;
            this.comboBox2.Enabled = false;
            this.comboBox5.SelectedIndex = 0;
            this.comboBox5.Enabled = false;
            this.comboBox7.SelectedIndex = 0;
            this.comboBox9.SelectedIndex = 0;
            this.comboBox1.SelectedIndex = 8;
            this.comboBox11.SelectedIndex = 8;
            this.comboBox3.SelectedIndex = 0;
            
          
            // Populate Combo Box with VisualStyle
            string[] str = Enum.GetNames(typeof(VisualStyle));
            comboBox10.Items.AddRange(str);
            comboBox4.SelectedIndex = 2;
            comboBox10.SelectedIndex = 4;
            // Populate Week Days
            string[] str1 = Enum.GetNames(typeof(Day));
            comboBox12.Items.AddRange(str1);

            comboBox12.SelectedIndex = 0;
           
            #region DataBinding
            m_dataSetTbg = new DataSet();
            table = m_dataSetTbg.Tables.Add("tbgstrg");
            table.Columns.Add("Date", typeof(DateTime));
            table.Columns[0].AllowDBNull = true;
            table.Rows.Add(new object[] { DateTime.Now - TimeSpan.FromDays(60) });
            table.Rows.Add(new object[] { DateTime.Now });
            table.Rows.Add(new object[] { DBNull.Value });
            dataGrid1.DataSource = m_dataSetTbg;
            dataGrid1.DataMember = "tbgstrg";
#endregion

            monthCalendarAdv1.TodayButton.Click += new EventHandler(TodayButton_Click);
            monthCalendarAdv1.NoneButtonClick += new EventHandler(monthCalendarAdv1_NoneButtonClick);
        }
        #endregion

		void monthCalendarAdv1_NoneButtonClick(object sender, EventArgs e)
        {
            this.popupControlContainer1.HidePopup();
            this.dateTimePickerAdv15.IsNullDate = true;
        }

        void TodayButton_Click(object sender, EventArgs e)
        {
            this.dateTimePickerAdv15.Value = this.monthCalendarAdv1.Value;
        }
		
        #region DateTimePickerAdv


        #region dateTimePickerAdv Culture


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			comboBox1.SelectedItem = "en-US";
            string culture = comboBox1.SelectedItem.ToString();            
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            this.dateTimePickerAdv15.Culture = new System.Globalization.CultureInfo(culture);

        }
        #endregion

        private void checkBoxAdv3_CheckStateChanged(object sender, EventArgs e)
        {
            this.dateTimePickerAdv15.ShowCheckBox = this.checkBoxAdv3.Checked;
        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            this.dateTimePickerAdv15.ShowUpDownOnFocus = this.checkBoxAdv2.Checked;
        }

        private void checkBoxAdv4_CheckStateChanged(object sender, EventArgs e)
        {
            this.dateTimePickerAdv15.ShowUpDown = this.checkBoxAdv4.Checked;
        }
       

        #region CustomFormat
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dateTimePickerAdv15.Format = DateTimePickerFormat.Custom;
            switch (this.comboBox2.SelectedIndex)
            {
               
                case 0:
                    {
                        this.dateTimePickerAdv15.CustomFormat = "MMMM MMM MM dddd ddd dd yyyy hh mm ss";
                        break;
                    }
                case 1:
                    {
                        this.dateTimePickerAdv15.CustomFormat = "dddd - dd MMMM yyyy";
                        break;
                    }
                case 2:
                    {
                        this.dateTimePickerAdv15.CustomFormat = "HH:m , dd MM yyyy";
                        break;
                    }
            }
        #endregion


        }


      

        private void checkBoxAdv5_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv5.Checked)
            {
                this.dateTimePickerAdv15.DataBindings.Add("BindableValue", m_dataSetTbg, "tbgstrg.Date");
            }
            else
            {
                this.dateTimePickerAdv15.DataBindings.Clear();
            }

        }
        #region Format
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox3.SelectedIndex)
            {

                case 0:
                    {
                        this.dateTimePickerAdv15.Format = DateTimePickerFormat.Long;
                        this.comboBox2.Enabled = false;
                        break;
                    }
                case 1:
                    {
                        this.dateTimePickerAdv15.Format = DateTimePickerFormat.Short;
                        this.comboBox2.Enabled = false;
                        break;
                    }
                case 2:
                    {
                        this.dateTimePickerAdv15.Format = DateTimePickerFormat.Time;
                        this.comboBox2.Enabled = false;
                        break;
                    }
                case 3:
                    {
                        this.dateTimePickerAdv15.Format = DateTimePickerFormat.Custom;
                        this.comboBox2.Enabled = true;
                        break;
                    }
            }
        }
        #endregion

        private void checkBoxAdv6_CheckStateChanged(object sender, EventArgs e)
        {
            this.dateTimePickerAdv15.ThemesEnabled = this.checkBoxAdv6.Checked;
        }

        #region Visual Style
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox4.SelectedItem.ToString())
            {

                case "Default":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.Default;
                        this.comboBox5.Enabled = false;
                        break;
                    }
                case "OfficeXP":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.OfficeXP;
                        this.comboBox5.Enabled = false;
                        break;
                    }
               
               case "Office2007":
                    {
                        this.dateTimePickerAdv15.Style = VisualStyle.Office2007;
                        this.comboBox5.Enabled = true;
                        break;
                    }
               
            }
           

        }
        #endregion

        #region Color Scheme
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox5.SelectedItem.ToString() == "Blue")
            {
                this.dateTimePickerAdv15.Office2007Theme = Office2007Theme.Blue;
            }
            else if (this.comboBox5.SelectedItem.ToString() == "Silver")
            {
                this.dateTimePickerAdv15.Office2007Theme = Office2007Theme.Silver;
            }
            else
            {
                this.dateTimePickerAdv15.Office2007Theme = Office2007Theme.Black;
            }
        }
        #endregion

        private void checkBoxAdv7_CheckStateChanged(object sender, EventArgs e)
        {
            this.dateTimePickerAdv15.ReadOnly = checkBoxAdv7.Checked;
            this.dateTimePickerAdv15.ReadOnlyValueChange = !checkBoxAdv7.Checked;
        }

        private void checkBoxAdv8_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv8.Checked)
            {
                this.dateTimePickerAdv15.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                this.dateTimePickerAdv15.RightToLeft = RightToLeft.No;
            }


        }

       

        private void checkBoxAdv9_CheckStateChanged(object sender, EventArgs e)
        {
            this.dateTimePickerAdv15.UseEnhancedMenu = checkBoxAdv9.Checked;
        }

#region NullModeKeyReset
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox7.SelectedIndex)
            {
                case 0:
                    {
                        this.dateTimePickerAdv15.NullModeKeyReset = NullModeKeyReset.ArrowKeys;
                        break;
                    }
                case 1:
                    {
                        this.dateTimePickerAdv15.NullModeKeyReset = NullModeKeyReset.NumericKeys;
                        break;
                    }
                case 2:
                    {
                        this.dateTimePickerAdv15.NullModeKeyReset = NullModeKeyReset.Any;
                        break;
                    }
            }
        }
#endregion

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv1.Checked)
            {
                this.dateTimePickerAdv15.CustomPopupWindow = this.popupControlContainer1;
                this.dateTimePickerAdv15.CustomDrop = true;
            }
            else
            {

                this.dateTimePickerAdv15.CustomDrop = false;

            }

        }

        #region PopUpControlContainer


        private void popupControlContainer1_Popup(object sender, System.EventArgs e)
        {
            this.monthCalendarAdv1.Focus();
        }
        #endregion
        #endregion

        #region MonthCalendarAdv
        #region Visual Styles
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
             switch (this.comboBox10.SelectedItem.ToString())
            {

                case "Default":
                    {
                        this.monthCalendarAdv2.Style = VisualStyle.Default;
                        this.comboBox9.Enabled = false;
                        break;
                    }
                case "OfficeXP":
                    {
                         this.monthCalendarAdv2.Style = VisualStyle.OfficeXP;
                        this.comboBox9.Enabled = false;
                        break;
                    }
               
                case "Office2003":
                    {    
                        this.monthCalendarAdv2.Style = VisualStyle.Office2003;
                        this.comboBox9.Enabled = false;
                        break;
                    }
                case "VS2005":
                    {
                  this.monthCalendarAdv2.Style = VisualStyle.VS2005;
                        this.comboBox9.Enabled = false;
                        break;
                    }
                case "Office2007":
                    {
                     this.monthCalendarAdv2.Style = VisualStyle.Office2007;
                        this.comboBox9.Enabled = true;
                        break;
                    }
                case "Office2007Outlook":
                    {
                       this.monthCalendarAdv2.Style = VisualStyle.Office2007Outlook;
                        this.comboBox9.Enabled = false;
                        break;
                    }
            }
        }
        #endregion

        #region Color Scheme
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox9.SelectedItem.ToString() == "Blue")
            {
                this.monthCalendarAdv2.Office2007Theme = Office2007Theme.Blue;
            }
            else if (this.comboBox9.SelectedItem.ToString() == "Silver")
            {
                this.monthCalendarAdv2.Office2007Theme = Office2007Theme.Silver;
            }
            else
            {
                this.monthCalendarAdv2.Office2007Theme = Office2007Theme.Black;
            }
        }
        #endregion
               
        #region Themes
        private void checkBoxAdv11_CheckStateChanged(object sender, EventArgs e)
        {
            this.monthCalendarAdv2.ThemedBorder = checkBoxAdv11.Checked;
            this.monthCalendarAdv2.ThemedEnabledGrid = checkBoxAdv11.Checked;
            this.monthCalendarAdv2.ThemedEnabledScrollButtons = checkBoxAdv11.Checked;
        }


        #endregion

        #region Select option
        private void checkBoxAdv13_CheckStateChanged(object sender, EventArgs e)
        {
            this.monthCalendarAdv2.AllowMultipleSelection = this.checkBoxAdv13.Checked;
        }

        private void checkBoxAdv14_CheckStateChanged(object sender, EventArgs e)
        {
            this.monthCalendarAdv2.MouseDragMultiselect = this.checkBoxAdv14.Checked;
        }
        #endregion


        #region Culture settings
        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            string culture = comboBox11.SelectedItem.ToString();            
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
            this.monthCalendarAdv2.Culture = new System.Globalization.CultureInfo(culture);

        }
        #endregion

        #region FirstDayOfWeek
        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
             switch (this.comboBox12.SelectedItem.ToString())
            {

                case "Default":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Default;
                        
                        break;
                    }
                 case "Friday":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Friday;
                        
                        break;
                    }
                 case "Monday":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Monday;
                        
                        break;
                    }
                 case "Saturday":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Saturday;
                        
                        break;
                    }
                 case "Sunday":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Sunday;
                        
                        break;
                    }
                 case "Thursday":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Thursday;
                        
                        break;
                    }
                 case "Tuesday":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Tuesday;
                        
                        break;
                    }
                 case "Wednesday":
                    {
                        this.monthCalendarAdv2.FirstDayOfWeek = Day.Wednesday;
                        
                        break;
                    }
             }
        }
#endregion

        #region Show Week numbers
        private void checkBoxAdv10_CheckStateChanged(object sender, EventArgs e)
        {
            this.monthCalendarAdv2.ShowWeekNumbers = checkBoxAdv10.Checked;
        }
        #endregion

        #region LeftButton Image
        private void checkBoxAdv15_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv15.Checked)
            {
               this.monthCalendarAdv2.LeftScrollButtonImage = leftButtonImg;
            }
            else
            {
                this.monthCalendarAdv2.LeftScrollButtonImage = null;
            }
        }
#endregion
        
        #region Rightutton Image
        private void checkBoxAdv16_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv16.Checked)
            {
                this.monthCalendarAdv2.RightScrollButtonImage = rightButtonImg;
            }
            else
            {
                this.monthCalendarAdv2.RightScrollButtonImage  = null;
            }
        }
#endregion

        #region ColorSettings
        private void buttonEdit1_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
           
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.buttonEdit1.TextBox.BackColor = colorDialog1.Color;
                this.monthCalendarAdv2.DayNamesColor = colorDialog1.Color;
            }
            
        }
      

        private void buttonEdit2_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.buttonEdit2.TextBox.BackColor = colorDialog1.Color;
                this.monthCalendarAdv2.BackColor = colorDialog1.Color;
            }
        }

        private void buttonEdit3_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.buttonEdit3.TextBox.BackColor = colorDialog1.Color;
                this.monthCalendarAdv2.DaysColor = colorDialog1.Color;
            }
        }

        private void buttonEdit4_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.buttonEdit4.TextBox.BackColor = colorDialog1.Color;
                this.monthCalendarAdv2.GridBackColor = colorDialog1.Color;
            }
        }

        private void checkBoxAdv12_CheckStateChanged(object sender, EventArgs e)
        {
            this.monthCalendarAdv2.HeaderVerticalGradient = this.checkBoxAdv12.Checked;
            this.monthCalendarAdv2.HeadGradient = this.checkBoxAdv12.Checked;
        }

        private void buttonEdit5_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.buttonEdit5.TextBox.BackColor = colorDialog1.Color;
                this.monthCalendarAdv2.HeaderEndColor = colorDialog1.Color;
            }
        }

        private void buttonEdit6_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.buttonEdit6.TextBox.BackColor = colorDialog1.Color;
                this.monthCalendarAdv2.HeaderStartColor = colorDialog1.Color;
            }
        }
        #endregion

       

        #endregion


    }
}
