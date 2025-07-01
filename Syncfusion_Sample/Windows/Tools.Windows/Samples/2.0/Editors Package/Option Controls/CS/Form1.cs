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
using Syncfusion.Windows.Forms;
namespace CheckBoxAdvDemo
{
    public class Form1 : Office2007Form
    {
        #region Declarations
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBoxAdv1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private Syncfusion.Windows.Forms.Tools.TabControlAdv tabControlAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv1;
        private Syncfusion.Windows.Forms.Tools.TabPageAdv tabPageAdv2;
        private Label label46;
        private Label label58;
        private Label label40;
        private ComboBox comboBox6;
        private Label label44;
        private Label label8;
        private Label label12;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv5;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv8;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv7;
        private ComboBox comboBox1;
        private Label label7;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv9;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv10;
        private Label label9;
        private Label label10;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv11;
        private ComboBox comboBox4;
        private Label label14;
        private Label label11;
        private Label label13;
        private Label label16;
        private Label label15;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit2;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton2;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit1;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv12;
        private Label label17;
        private Label label18;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit3;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton3;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit4;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton4;
        private ComboBox comboBox7;
        private Label label19;
        private Label label20;
        private Label label21;
        private ColorDialog colorDialog1;
        private ComboBox comboBox8;
        private ComboBox comboBox9;
        private ComboBox comboBox10;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label26;
        private Label label25;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit5;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton5;
        private ComboBox comboBox5;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private ComboBox comboBox11;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv13;
        private Label label31;
        private Label label32;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit6;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton6;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit7;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton7;
        private ComboBox comboBox12;
        private Label label33;
        private Label label34;
        private Label label35;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv14;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv15;
        private ComboBox comboBox13;
        private Label label36;
        private Label label37;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv16;
        private ComboBox comboBox14;
        private Label label39;
        private ComboBox comboBox15;
        private Label label38;
        private Label label41;
        private Syncfusion.Windows.Forms.Tools.ButtonEdit buttonEdit8;
        private Syncfusion.Windows.Forms.Tools.ButtonEditChildButton buttonEditChildButton8;
        private ButtonAdv buttonAdv1;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private ComboBox comboBox3;
        private Label label42;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox6;
        private CheckBox checkBox9;
        private Label label43;
        private Label label45;
        private ComboBox comboBox17;
        private Label label48;
        private Label label47;
        private ComboBox comboBox16;
        private ComboBox comboBox18;
        private Label label49;
        private Label label50;
        private ComboBox comboBox19;
        DataTable m_dt;
        private CheckBox checkBox7;
        private Label label1;
        private Label label51;
        private Label label54;
        private Label label55;
        private Label label52;
        private Label label53;
        private CheckBox checkBox8;
        private Label label56;
        private ToolTip toolTip1;
        private Panel panel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private Label label57;
        private Label label77;
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel1;
        private Label label59;
        private Label label60;
        private CheckBox checkBox2;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv2;
        private System.ComponentModel.IContainer components;
        #endregion

        #region Constructor And Dispose
        public Form1()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.checkBoxAdv1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.tabControlAdv1 = new Syncfusion.Windows.Forms.Tools.TabControlAdv();
            this.tabPageAdv1 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.gradientPanel1 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label59 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.comboBox18 = new System.Windows.Forms.ComboBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.comboBox19 = new System.Windows.Forms.ComboBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.buttonEdit5 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton5 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonEdit2 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton2 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEdit1 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton1 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButtonAdv8 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv7 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButtonAdv5 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPageAdv2 = new Syncfusion.Windows.Forms.Tools.TabPageAdv();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label60 = new System.Windows.Forms.Label();
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label57 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonAdv12 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label77 = new System.Windows.Forms.Label();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.comboBox17 = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.comboBox16 = new System.Windows.Forms.ComboBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.comboBox15 = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.buttonEdit8 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton8 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonEdit3 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton3 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEdit4 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton4 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.radioButtonAdv9 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv10 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButtonAdv11 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.radioButtonAdv13 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.buttonEdit6 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton6 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.buttonEdit7 = new Syncfusion.Windows.Forms.Tools.ButtonEdit();
            this.buttonEditChildButton7 = new Syncfusion.Windows.Forms.Tools.ButtonEditChildButton();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.radioButtonAdv14 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv15 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.radioButtonAdv16 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.radioButtonAdv1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).BeginInit();
            this.tabControlAdv1.SuspendLayout();
            this.tabPageAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).BeginInit();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).BeginInit();
            this.buttonEdit5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).BeginInit();
            this.buttonEdit2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).BeginInit();
            this.buttonEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv5)).BeginInit();
            this.tabPageAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            this.gradientPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit8)).BeginInit();
            this.buttonEdit8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).BeginInit();
            this.buttonEdit3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).BeginInit();
            this.buttonEdit4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit6)).BeginInit();
            this.buttonEdit6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit7)).BeginInit();
            this.buttonEdit7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxAdv1
            // 
            this.checkBoxAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.checkBoxAdv1.BorderColor = System.Drawing.Color.Black;
            this.checkBoxAdv1.Checked = true;
            this.checkBoxAdv1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("checkBoxAdv1.CheckedImage")));
            this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAdv1.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.checkBoxAdv1.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBoxAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBoxAdv1.ImageCheckBoxSize = new System.Drawing.Size(30, 30);
            this.checkBoxAdv1.IndeterminateImage = ((System.Drawing.Image)(resources.GetObject("checkBoxAdv1.IndeterminateImage")));
            this.checkBoxAdv1.Location = new System.Drawing.Point(235, 61);
            this.checkBoxAdv1.Name = "checkBoxAdv1";
            this.checkBoxAdv1.ShadowColor = System.Drawing.Color.Black;
            this.checkBoxAdv1.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBoxAdv1.Size = new System.Drawing.Size(129, 35);
            this.checkBoxAdv1.StretchImage = false;
            this.checkBoxAdv1.TabIndex = 22;
            this.checkBoxAdv1.Text = "CheckBoxAdv";
            this.checkBoxAdv1.ThemesEnabled = true;
            this.checkBoxAdv1.UncheckedImage = ((System.Drawing.Image)(resources.GetObject("checkBoxAdv1.UncheckedImage")));
            this.checkBoxAdv1.CheckStateChanged += new System.EventHandler(this.checkBoxAdv1_CheckStateChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Location = new System.Drawing.Point(495, 399);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(116, 21);
            this.comboBox2.TabIndex = 23;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(467, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 74);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select the bit value from the comboBox below to set state of the CheckBoxAdv whic" +
                "h is bound  to a field (containing only 0,1 or -1) column in a data table.";
            // 
            // tabControlAdv1
            // 
            this.tabControlAdv1.ActiveTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv1);
            this.tabControlAdv1.Controls.Add(this.tabPageAdv2);
            this.tabControlAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdv1.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdv1.Name = "tabControlAdv1";
            this.tabControlAdv1.Size = new System.Drawing.Size(664, 488);
            this.tabControlAdv1.TabGap = 10;
            this.tabControlAdv1.TabIndex = 34;
            this.tabControlAdv1.TabPanelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(242)))), ((int)(((byte)(253)))));
            this.tabControlAdv1.TabStyle = typeof(Syncfusion.Windows.Forms.Tools.TabRendererOffice2007);
            // 
            // tabPageAdv1
            // 
            this.tabPageAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.tabPageAdv1.Controls.Add(this.radioButtonAdv1);
            this.tabPageAdv1.Controls.Add(this.gradientPanel1);
            this.tabPageAdv1.Controls.Add(this.label56);
            this.tabPageAdv1.Controls.Add(this.checkBox7);
            this.tabPageAdv1.Controls.Add(this.label1);
            this.tabPageAdv1.Controls.Add(this.label51);
            this.tabPageAdv1.Controls.Add(this.comboBox18);
            this.tabPageAdv1.Controls.Add(this.label49);
            this.tabPageAdv1.Controls.Add(this.label50);
            this.tabPageAdv1.Controls.Add(this.comboBox19);
            this.tabPageAdv1.Controls.Add(this.checkBox6);
            this.tabPageAdv1.Controls.Add(this.checkBox5);
            this.tabPageAdv1.Controls.Add(this.checkBox4);
            this.tabPageAdv1.Controls.Add(this.checkBox3);
            this.tabPageAdv1.Controls.Add(this.comboBox14);
            this.tabPageAdv1.Controls.Add(this.label39);
            this.tabPageAdv1.Controls.Add(this.label25);
            this.tabPageAdv1.Controls.Add(this.buttonEdit5);
            this.tabPageAdv1.Controls.Add(this.comboBox8);
            this.tabPageAdv1.Controls.Add(this.label16);
            this.tabPageAdv1.Controls.Add(this.label15);
            this.tabPageAdv1.Controls.Add(this.buttonEdit2);
            this.tabPageAdv1.Controls.Add(this.buttonEdit1);
            this.tabPageAdv1.Controls.Add(this.comboBox4);
            this.tabPageAdv1.Controls.Add(this.label14);
            this.tabPageAdv1.Controls.Add(this.label11);
            this.tabPageAdv1.Controls.Add(this.label13);
            this.tabPageAdv1.Controls.Add(this.radioButtonAdv8);
            this.tabPageAdv1.Controls.Add(this.radioButtonAdv7);
            this.tabPageAdv1.Controls.Add(this.comboBox1);
            this.tabPageAdv1.Controls.Add(this.label7);
            this.tabPageAdv1.Controls.Add(this.label4);
            this.tabPageAdv1.Controls.Add(this.label6);
            this.tabPageAdv1.Controls.Add(this.radioButtonAdv5);
            this.tabPageAdv1.Controls.Add(this.label2);
            this.tabPageAdv1.Controls.Add(this.label3);
            this.tabPageAdv1.Controls.Add(this.label46);
            this.tabPageAdv1.Controls.Add(this.label58);
            this.tabPageAdv1.Controls.Add(this.label40);
            this.tabPageAdv1.Controls.Add(this.comboBox6);
            this.tabPageAdv1.Controls.Add(this.label44);
            this.tabPageAdv1.Controls.Add(this.comboBox2);
            this.tabPageAdv1.Controls.Add(this.label8);
            this.tabPageAdv1.Controls.Add(this.label5);
            this.tabPageAdv1.Controls.Add(this.label12);
            this.tabPageAdv1.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv1.Name = "tabPageAdv1";
            this.tabPageAdv1.Size = new System.Drawing.Size(661, 464);
            this.tabPageAdv1.TabBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.tabPageAdv1.TabIndex = 1;
            this.tabPageAdv1.Text = "CheckBoxAdv";
            this.tabPageAdv1.ThemesEnabled = false;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.gradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel1.Controls.Add(this.label59);
            this.gradientPanel1.Controls.Add(this.checkBoxAdv1);
            this.gradientPanel1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel1.Location = new System.Drawing.Point(25, 18);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(611, 109);
            this.gradientPanel1.TabIndex = 151;
            // 
            // label59
            // 
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.Dock = System.Windows.Forms.DockStyle.Top;
            this.label59.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label59.Image = ((System.Drawing.Image)(resources.GetObject("label59.Image")));
            this.label59.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label59.Location = new System.Drawing.Point(0, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(609, 48);
            this.label59.TabIndex = 1;
            this.label59.Text = resources.GetString("label59.Text");
            // 
            // label56
            // 
            this.label56.Image = ((System.Drawing.Image)(resources.GetObject("label56.Image")));
            this.label56.Location = new System.Drawing.Point(416, 252);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(20, 20);
            this.label56.TabIndex = 145;
            this.toolTip1.SetToolTip(this.label56, "Enabled when BorderStyle is FixedSingle");
            // 
            // checkBox7
            // 
            this.checkBox7.Location = new System.Drawing.Point(37, 404);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(112, 24);
            this.checkBox7.TabIndex = 144;
            this.checkBox7.Text = "Themes Enabled";
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(236, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 143;
            this.label1.Text = "Alignment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label51
            // 
            this.label51.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label51.Location = new System.Drawing.Point(258, 312);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(160, 1);
            this.label51.TabIndex = 142;
            // 
            // comboBox18
            // 
            this.comboBox18.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox18.ForeColor = System.Drawing.Color.Black;
            this.comboBox18.Location = new System.Drawing.Point(316, 375);
            this.comboBox18.Name = "comboBox18";
            this.comboBox18.Size = new System.Drawing.Size(99, 21);
            this.comboBox18.TabIndex = 141;
            this.comboBox18.SelectedIndexChanged += new System.EventHandler(this.comboBox18_SelectedIndexChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(254, 378);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(54, 13);
            this.label49.TabIndex = 140;
            this.label49.Text = "Text Align";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(254, 331);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(60, 13);
            this.label50.TabIndex = 139;
            this.label50.Text = "Glyph Align";
            // 
            // comboBox19
            // 
            this.comboBox19.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox19.ForeColor = System.Drawing.Color.Black;
            this.comboBox19.Location = new System.Drawing.Point(316, 331);
            this.comboBox19.Name = "comboBox19";
            this.comboBox19.Size = new System.Drawing.Size(99, 21);
            this.comboBox19.TabIndex = 138;
            this.comboBox19.SelectedIndexChanged += new System.EventHandler(this.comboBox19_SelectedIndexChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.Location = new System.Drawing.Point(37, 320);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(75, 24);
            this.checkBox6.TabIndex = 128;
            this.checkBox6.Text = "ReadOnly";
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.Location = new System.Drawing.Point(37, 348);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(67, 24);
            this.checkBox5.TabIndex = 127;
            this.checkBox5.Text = "TriState";
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(37, 376);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(92, 24);
            this.checkBox4.TabIndex = 126;
            this.checkBox4.Text = "ShowShadow";
            this.checkBox4.UseVisualStyleBackColor = false;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(37, 432);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(112, 24);
            this.checkBox3.TabIndex = 125;
            this.checkBox3.Text = "ImageCheckBox";
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // comboBox14
            // 
            this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox14.ForeColor = System.Drawing.Color.Black;
            this.comboBox14.Location = new System.Drawing.Point(314, 217);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(101, 21);
            this.comboBox14.TabIndex = 106;
            this.comboBox14.SelectedIndexChanged += new System.EventHandler(this.comboBox14_SelectedIndexChanged);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(236, 227);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(70, 13);
            this.label39.TabIndex = 105;
            this.label39.Text = "Border Single";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(236, 258);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(65, 13);
            this.label25.TabIndex = 104;
            this.label25.Text = "Border Color";
            // 
            // buttonEdit5
            // 
            this.buttonEdit5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit5.Buttons.Add(this.buttonEditChildButton5);
            this.buttonEdit5.Controls.Add(this.buttonEditChildButton5);
            this.buttonEdit5.Location = new System.Drawing.Point(316, 243);
            this.buttonEdit5.Name = "buttonEdit5";
            this.buttonEdit5.ShowTextBox = false;
            this.buttonEdit5.Size = new System.Drawing.Size(99, 26);
            this.buttonEdit5.TabIndex = 103;
            this.buttonEdit5.UseVisualStyle = true;
            this.buttonEdit5.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit5_ButtonClicked);
            // 
            // buttonEditChildButton5
            // 
            this.buttonEditChildButton5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton5.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton5.Image = null;
            this.buttonEditChildButton5.Name = "buttonEditChildButton5";
            this.buttonEditChildButton5.PreferredWidth = 18;
            this.buttonEditChildButton5.TabIndex = 1;
            this.buttonEditChildButton5.Text = "...";
            // 
            // comboBox8
            // 
            this.comboBox8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox8.ForeColor = System.Drawing.Color.Black;
            this.comboBox8.Items.AddRange(new object[] {
            "None",
            "FixedSingle",
            "Fixed3D"});
            this.comboBox8.Location = new System.Drawing.Point(314, 165);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(101, 21);
            this.comboBox8.TabIndex = 102;
            this.comboBox8.SelectedIndexChanged += new System.EventHandler(this.comboBox8_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(448, 243);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 26);
            this.label16.TabIndex = 101;
            this.label16.Text = "Gradient \r\nEnd Color";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(447, 204);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 26);
            this.label15.TabIndex = 100;
            this.label15.Text = "Gradient \r\nStart Color";
            // 
            // buttonEdit2
            // 
            this.buttonEdit2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit2.Buttons.Add(this.buttonEditChildButton2);
            this.buttonEdit2.Controls.Add(this.buttonEditChildButton2);
            this.buttonEdit2.Location = new System.Drawing.Point(524, 242);
            this.buttonEdit2.Name = "buttonEdit2";
            this.buttonEdit2.ShowTextBox = false;
            this.buttonEdit2.Size = new System.Drawing.Size(103, 26);
            this.buttonEdit2.TabIndex = 99;
            this.buttonEdit2.UseVisualStyle = true;
            this.buttonEdit2.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit2_ButtonClicked);
            // 
            // buttonEditChildButton2
            // 
            this.buttonEditChildButton2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton2.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton2.Image = null;
            this.buttonEditChildButton2.Name = "buttonEditChildButton2";
            this.buttonEditChildButton2.PreferredWidth = 18;
            this.buttonEditChildButton2.TabIndex = 1;
            this.buttonEditChildButton2.Text = "...";
            // 
            // buttonEdit1
            // 
            this.buttonEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit1.Buttons.Add(this.buttonEditChildButton1);
            this.buttonEdit1.Controls.Add(this.buttonEditChildButton1);
            this.buttonEdit1.Location = new System.Drawing.Point(524, 204);
            this.buttonEdit1.Name = "buttonEdit1";
            this.buttonEdit1.ShowTextBox = false;
            this.buttonEdit1.Size = new System.Drawing.Size(103, 26);
            this.buttonEdit1.TabIndex = 98;
            this.buttonEdit1.UseVisualStyle = true;
            this.buttonEdit1.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit1_ButtonClicked);
            // 
            // buttonEditChildButton1
            // 
            this.buttonEditChildButton1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton1.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton1.Image = null;
            this.buttonEditChildButton1.Name = "buttonEditChildButton1";
            this.buttonEditChildButton1.PreferredWidth = 18;
            this.buttonEditChildButton1.TabIndex = 1;
            this.buttonEditChildButton1.Text = "...";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.ForeColor = System.Drawing.Color.Black;
            this.comboBox4.Items.AddRange(new object[] {
            "Default",
            "HorizontalGradient",
            "VerticalGradient"});
            this.comboBox4.Location = new System.Drawing.Point(521, 167);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(106, 21);
            this.comboBox4.TabIndex = 97;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(448, 165);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 26);
            this.label14.TabIndex = 96;
            this.label14.Text = "BackGround \r\nStyle";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(448, 130);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 24);
            this.label11.TabIndex = 95;
            this.label11.Text = "Background Settings";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label13.Location = new System.Drawing.Point(451, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 1);
            this.label13.TabIndex = 94;
            // 
            // radioButtonAdv8
            // 
            this.radioButtonAdv8.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv8.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAdv8.GradientStart = System.Drawing.SystemColors.Control;
            this.radioButtonAdv8.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv8.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.radioButtonAdv8.Location = new System.Drawing.Point(37, 227);
            this.radioButtonAdv8.Name = "radioButtonAdv8";
            this.radioButtonAdv8.ShadowColor = System.Drawing.Color.Black;
            this.radioButtonAdv8.ShadowOffset = new System.Drawing.Point(2, 2);
            this.radioButtonAdv8.Size = new System.Drawing.Size(150, 21);
            this.radioButtonAdv8.StretchImage = false;
            this.radioButtonAdv8.TabIndex = 93;
            this.radioButtonAdv8.Text = "Office2007 - Black";
            this.radioButtonAdv8.ThemesEnabled = true;
            this.radioButtonAdv8.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // radioButtonAdv7
            // 
            this.radioButtonAdv7.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv7.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAdv7.GradientStart = System.Drawing.SystemColors.Control;
            this.radioButtonAdv7.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv7.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.radioButtonAdv7.Location = new System.Drawing.Point(37, 206);
            this.radioButtonAdv7.Name = "radioButtonAdv7";
            this.radioButtonAdv7.ShadowColor = System.Drawing.Color.Black;
            this.radioButtonAdv7.ShadowOffset = new System.Drawing.Point(2, 2);
            this.radioButtonAdv7.Size = new System.Drawing.Size(150, 21);
            this.radioButtonAdv7.StretchImage = false;
            this.radioButtonAdv7.TabIndex = 92;
            this.radioButtonAdv7.Text = "Office2007 - Silver";
            this.radioButtonAdv7.ThemesEnabled = true;
            this.radioButtonAdv7.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Office2007"});
            this.comboBox1.Location = new System.Drawing.Point(96, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 21);
            this.comboBox1.TabIndex = 91;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 90;
            this.label7.Text = "Style";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(34, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 24);
            this.label4.TabIndex = 89;
            this.label4.Text = "Visual Styles";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label6.Location = new System.Drawing.Point(34, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 1);
            this.label6.TabIndex = 88;
            // 
            // radioButtonAdv5
            // 
            this.radioButtonAdv5.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv5.Checked = true;
            this.radioButtonAdv5.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAdv5.GradientStart = System.Drawing.SystemColors.Control;
            this.radioButtonAdv5.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv5.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.radioButtonAdv5.Location = new System.Drawing.Point(37, 185);
            this.radioButtonAdv5.Name = "radioButtonAdv5";
            this.radioButtonAdv5.ShadowColor = System.Drawing.Color.Black;
            this.radioButtonAdv5.ShadowOffset = new System.Drawing.Point(2, 2);
            this.radioButtonAdv5.Size = new System.Drawing.Size(150, 21);
            this.radioButtonAdv5.StretchImage = false;
            this.radioButtonAdv5.TabIndex = 87;
            this.radioButtonAdv5.Text = "Office2007 - Blue";
            this.radioButtonAdv5.ThemesEnabled = true;
            this.radioButtonAdv5.CheckChanged += new System.EventHandler(this.VisualStyle_CheckChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(34, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 86;
            this.label2.Text = "Properties";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label3.Location = new System.Drawing.Point(40, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 1);
            this.label3.TabIndex = 85;
            // 
            // label46
            // 
            this.label46.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label46.Image = ((System.Drawing.Image)(resources.GetObject("label46.Image")));
            this.label46.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label46.Location = new System.Drawing.Point(236, 130);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(114, 24);
            this.label46.TabIndex = 84;
            this.label46.Text = "Border Settings";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label58
            // 
            this.label58.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label58.Location = new System.Drawing.Point(247, 154);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(160, 1);
            this.label58.TabIndex = 83;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(236, 165);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(64, 13);
            this.label40.TabIndex = 80;
            this.label40.Text = "Border Style";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox6.ForeColor = System.Drawing.Color.Black;
            this.comboBox6.Location = new System.Drawing.Point(314, 191);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(101, 21);
            this.comboBox6.TabIndex = 78;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(236, 196);
            this.label44.Margin = new System.Windows.Forms.Padding(0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(78, 13);
            this.label44.TabIndex = 76;
            this.label44.Text = "Border3D Style";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(467, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 24);
            this.label8.TabIndex = 34;
            this.label8.Text = "Data Binding";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label12.Location = new System.Drawing.Point(467, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 1);
            this.label12.TabIndex = 33;
            // 
            // tabPageAdv2
            // 
            this.tabPageAdv2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.tabPageAdv2.Controls.Add(this.radioButtonAdv2);
            this.tabPageAdv2.Controls.Add(this.checkBox2);
            this.tabPageAdv2.Controls.Add(this.label60);
            this.tabPageAdv2.Controls.Add(this.gradientPanel2);
            this.tabPageAdv2.Controls.Add(this.label77);
            this.tabPageAdv2.Controls.Add(this.checkBox8);
            this.tabPageAdv2.Controls.Add(this.label54);
            this.tabPageAdv2.Controls.Add(this.label55);
            this.tabPageAdv2.Controls.Add(this.label52);
            this.tabPageAdv2.Controls.Add(this.label53);
            this.tabPageAdv2.Controls.Add(this.comboBox17);
            this.tabPageAdv2.Controls.Add(this.label48);
            this.tabPageAdv2.Controls.Add(this.label47);
            this.tabPageAdv2.Controls.Add(this.comboBox16);
            this.tabPageAdv2.Controls.Add(this.checkBox9);
            this.tabPageAdv2.Controls.Add(this.label43);
            this.tabPageAdv2.Controls.Add(this.label45);
            this.tabPageAdv2.Controls.Add(this.comboBox3);
            this.tabPageAdv2.Controls.Add(this.label42);
            this.tabPageAdv2.Controls.Add(this.checkBox1);
            this.tabPageAdv2.Controls.Add(this.buttonAdv1);
            this.tabPageAdv2.Controls.Add(this.comboBox15);
            this.tabPageAdv2.Controls.Add(this.label38);
            this.tabPageAdv2.Controls.Add(this.label41);
            this.tabPageAdv2.Controls.Add(this.buttonEdit8);
            this.tabPageAdv2.Controls.Add(this.comboBox10);
            this.tabPageAdv2.Controls.Add(this.label22);
            this.tabPageAdv2.Controls.Add(this.label23);
            this.tabPageAdv2.Controls.Add(this.label24);
            this.tabPageAdv2.Controls.Add(this.label26);
            this.tabPageAdv2.Controls.Add(this.comboBox9);
            this.tabPageAdv2.Controls.Add(this.label17);
            this.tabPageAdv2.Controls.Add(this.label18);
            this.tabPageAdv2.Controls.Add(this.buttonEdit3);
            this.tabPageAdv2.Controls.Add(this.buttonEdit4);
            this.tabPageAdv2.Controls.Add(this.comboBox7);
            this.tabPageAdv2.Controls.Add(this.label19);
            this.tabPageAdv2.Controls.Add(this.label20);
            this.tabPageAdv2.Controls.Add(this.label21);
            this.tabPageAdv2.Controls.Add(this.radioButtonAdv9);
            this.tabPageAdv2.Controls.Add(this.radioButtonAdv10);
            this.tabPageAdv2.Controls.Add(this.label9);
            this.tabPageAdv2.Controls.Add(this.label10);
            this.tabPageAdv2.Controls.Add(this.radioButtonAdv11);
            this.tabPageAdv2.Location = new System.Drawing.Point(1, 22);
            this.tabPageAdv2.Name = "tabPageAdv2";
            this.tabPageAdv2.Size = new System.Drawing.Size(661, 464);
            this.tabPageAdv2.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPageAdv2.TabIndex = 1;
            this.tabPageAdv2.Text = "RadioButtonAdv";
            this.tabPageAdv2.ThemesEnabled = false;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(42, 379);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(102, 24);
            this.checkBox2.TabIndex = 153;
            this.checkBox2.Text = "Checked State";
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label60
            // 
            this.label60.Location = new System.Drawing.Point(452, 321);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(169, 27);
            this.label60.TabIndex = 152;
            this.label60.Text = "Set the RadioButton as checked through DataBase";
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(241)))), ((int)(((byte)(250)))));
            this.gradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(178)))), ((int)(((byte)(227)))));
            this.gradientPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradientPanel2.Controls.Add(this.label57);
            this.gradientPanel2.Controls.Add(this.panel1);
            this.gradientPanel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientPanel2.Location = new System.Drawing.Point(42, 16);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(592, 90);
            this.gradientPanel2.TabIndex = 150;
            // 
            // label57
            // 
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label57.Dock = System.Windows.Forms.DockStyle.Top;
            this.label57.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label57.Image = ((System.Drawing.Image)(resources.GetObject("label57.Image")));
            this.label57.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label57.Location = new System.Drawing.Point(0, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(590, 51);
            this.label57.TabIndex = 1;
            this.label57.Text = "RadioButtonAdv is an advanced RadioButton control that supports themes, gradient " +
                "colors and shadow text. \r\nIt has provisions to set images when checked and unche" +
                "cked. ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonAdv12);
            this.panel1.Location = new System.Drawing.Point(198, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 46);
            this.panel1.TabIndex = 151;
            // 
            // radioButtonAdv12
            // 
            this.radioButtonAdv12.Border3DStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.radioButtonAdv12.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv12.CheckedImage = ((System.Drawing.Image)(resources.GetObject("radioButtonAdv12.CheckedImage")));
            this.radioButtonAdv12.GradientEnd = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.radioButtonAdv12.GradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.radioButtonAdv12.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv12.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.radioButtonAdv12.Location = new System.Drawing.Point(30, 15);
            this.radioButtonAdv12.Name = "radioButtonAdv12";
            this.radioButtonAdv12.ShadowColor = System.Drawing.Color.Black;
            this.radioButtonAdv12.ShadowOffset = new System.Drawing.Point(2, 2);
            this.radioButtonAdv12.Size = new System.Drawing.Size(117, 17);
            this.radioButtonAdv12.TabIndex = 110;
            this.radioButtonAdv12.Text = "RadioButtonAdv";
            this.radioButtonAdv12.ThemesEnabled = true;
            this.radioButtonAdv12.UncheckedImage = ((System.Drawing.Image)(resources.GetObject("radioButtonAdv12.UncheckedImage")));
            // 
            // label77
            // 
            this.label77.Image = ((System.Drawing.Image)(resources.GetObject("label77.Image")));
            this.label77.Location = new System.Drawing.Point(404, 244);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(20, 20);
            this.label77.TabIndex = 149;
            this.toolTip1.SetToolTip(this.label77, "Enabled when BorderStyle is FixedSingle");
            // 
            // checkBox8
            // 
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Location = new System.Drawing.Point(42, 413);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(112, 24);
            this.checkBox8.TabIndex = 148;
            this.checkBox8.Text = "Themes Enabled";
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // label54
            // 
            this.label54.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label54.Image = ((System.Drawing.Image)(resources.GetObject("label54.Image")));
            this.label54.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label54.Location = new System.Drawing.Point(452, 283);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(99, 24);
            this.label54.TabIndex = 147;
            this.label54.Text = "Data Binding";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label55
            // 
            this.label55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label55.Location = new System.Drawing.Point(452, 307);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(160, 1);
            this.label55.TabIndex = 146;
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label52.Image = ((System.Drawing.Image)(resources.GetObject("label52.Image")));
            this.label52.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label52.Location = new System.Drawing.Point(234, 283);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(89, 24);
            this.label52.TabIndex = 145;
            this.label52.Text = "Alignment";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label53
            // 
            this.label53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label53.Location = new System.Drawing.Point(240, 307);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(160, 1);
            this.label53.TabIndex = 144;
            // 
            // comboBox17
            // 
            this.comboBox17.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox17.ForeColor = System.Drawing.Color.Black;
            this.comboBox17.Location = new System.Drawing.Point(315, 369);
            this.comboBox17.Name = "comboBox17";
            this.comboBox17.Size = new System.Drawing.Size(90, 21);
            this.comboBox17.TabIndex = 137;
            this.comboBox17.SelectedIndexChanged += new System.EventHandler(this.comboBox17_SelectedIndexChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(234, 372);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(54, 13);
            this.label48.TabIndex = 136;
            this.label48.Text = "Text Align";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(234, 327);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(60, 13);
            this.label47.TabIndex = 135;
            this.label47.Text = "Glyph Align";
            // 
            // comboBox16
            // 
            this.comboBox16.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox16.ForeColor = System.Drawing.Color.Black;
            this.comboBox16.Location = new System.Drawing.Point(315, 327);
            this.comboBox16.Name = "comboBox16";
            this.comboBox16.Size = new System.Drawing.Size(90, 21);
            this.comboBox16.TabIndex = 134;
            this.comboBox16.SelectedIndexChanged += new System.EventHandler(this.comboBox16_SelectedIndexChanged);
            // 
            // checkBox9
            // 
            this.checkBox9.Location = new System.Drawing.Point(42, 311);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(95, 24);
            this.checkBox9.TabIndex = 133;
            this.checkBox9.Text = "ShowShadow";
            this.checkBox9.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label43.Image = ((System.Drawing.Image)(resources.GetObject("label43.Image")));
            this.label43.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label43.Location = new System.Drawing.Point(36, 283);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(89, 24);
            this.label43.TabIndex = 131;
            this.label43.Text = "Properties";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label45
            // 
            this.label45.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label45.Location = new System.Drawing.Point(36, 307);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(160, 1);
            this.label45.TabIndex = 130;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.ForeColor = System.Drawing.Color.Black;
            this.comboBox3.Items.AddRange(new object[] {
            "Default",
            "Office2007"});
            this.comboBox3.Location = new System.Drawing.Point(77, 155);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(87, 21);
            this.comboBox3.TabIndex = 126;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(39, 158);
            this.label42.Margin = new System.Windows.Forms.Padding(0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(30, 13);
            this.label42.TabIndex = 125;
            this.label42.Text = "Style";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(42, 345);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 24);
            this.checkBox1.TabIndex = 124;
            this.checkBox1.Text = "ImageCheckBox";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.WindowsXP;
            this.buttonAdv1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdv1.Location = new System.Drawing.Point(492, 369);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(88, 23);
            this.buttonAdv1.TabIndex = 123;
            this.buttonAdv1.Text = "Checked";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // comboBox15
            // 
            this.comboBox15.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox15.ForeColor = System.Drawing.Color.Black;
            this.comboBox15.Location = new System.Drawing.Point(315, 213);
            this.comboBox15.Name = "comboBox15";
            this.comboBox15.Size = new System.Drawing.Size(87, 21);
            this.comboBox15.TabIndex = 121;
            this.comboBox15.SelectedIndexChanged += new System.EventHandler(this.comboBox15_SelectedIndexChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(234, 214);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(70, 13);
            this.label38.TabIndex = 120;
            this.label38.Text = "Border Single";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(234, 242);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(65, 13);
            this.label41.TabIndex = 119;
            this.label41.Text = "Border Color";
            // 
            // buttonEdit8
            // 
            this.buttonEdit8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit8.Buttons.Add(this.buttonEditChildButton8);
            this.buttonEdit8.Controls.Add(this.buttonEditChildButton8);
            this.buttonEdit8.Location = new System.Drawing.Point(315, 242);
            this.buttonEdit8.Name = "buttonEdit8";
            this.buttonEdit8.ShowTextBox = false;
            this.buttonEdit8.Size = new System.Drawing.Size(87, 26);
            this.buttonEdit8.TabIndex = 118;
            this.buttonEdit8.UseVisualStyle = true;
            this.buttonEdit8.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit8_ButtonClicked);
            // 
            // buttonEditChildButton8
            // 
            this.buttonEditChildButton8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton8.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton8.Image = null;
            this.buttonEditChildButton8.Name = "buttonEditChildButton8";
            this.buttonEditChildButton8.PreferredWidth = 18;
            this.buttonEditChildButton8.TabIndex = 1;
            this.buttonEditChildButton8.Text = "...";
            // 
            // comboBox10
            // 
            this.comboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox10.ForeColor = System.Drawing.Color.Black;
            this.comboBox10.Location = new System.Drawing.Point(315, 184);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(87, 21);
            this.comboBox10.TabIndex = 117;
            this.comboBox10.SelectedIndexChanged += new System.EventHandler(this.comboBox10_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label22.Image = ((System.Drawing.Image)(resources.GetObject("label22.Image")));
            this.label22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label22.Location = new System.Drawing.Point(234, 120);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(114, 24);
            this.label22.TabIndex = 116;
            this.label22.Text = "Border Settings";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label23.Location = new System.Drawing.Point(234, 144);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(160, 1);
            this.label23.TabIndex = 115;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(234, 158);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(64, 13);
            this.label24.TabIndex = 114;
            this.label24.Text = "Border Style";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(234, 186);
            this.label26.Margin = new System.Windows.Forms.Padding(0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(78, 13);
            this.label26.TabIndex = 112;
            this.label26.Text = "Border3D Style";
            // 
            // comboBox9
            // 
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox9.ForeColor = System.Drawing.Color.Black;
            this.comboBox9.Items.AddRange(new object[] {
            "None",
            "FixedSingle",
            "Fixed3D"});
            this.comboBox9.Location = new System.Drawing.Point(315, 155);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(87, 21);
            this.comboBox9.TabIndex = 111;
            this.comboBox9.SelectedIndexChanged += new System.EventHandler(this.comboBox9_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(449, 249);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 26);
            this.label17.TabIndex = 109;
            this.label17.Text = "Gradient \r\nEnd Color";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(449, 206);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 26);
            this.label18.TabIndex = 108;
            this.label18.Text = "Gradient \r\nStart Color";
            // 
            // buttonEdit3
            // 
            this.buttonEdit3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit3.Buttons.Add(this.buttonEditChildButton3);
            this.buttonEdit3.Controls.Add(this.buttonEditChildButton3);
            this.buttonEdit3.Location = new System.Drawing.Point(522, 242);
            this.buttonEdit3.Name = "buttonEdit3";
            this.buttonEdit3.ShowTextBox = false;
            this.buttonEdit3.Size = new System.Drawing.Size(99, 26);
            this.buttonEdit3.TabIndex = 107;
            this.buttonEdit3.UseVisualStyle = true;
            this.buttonEdit3.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit3_ButtonClicked);
            // 
            // buttonEditChildButton3
            // 
            this.buttonEditChildButton3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton3.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton3.Image = null;
            this.buttonEditChildButton3.Name = "buttonEditChildButton3";
            this.buttonEditChildButton3.PreferredWidth = 18;
            this.buttonEditChildButton3.TabIndex = 1;
            this.buttonEditChildButton3.Text = "...";
            // 
            // buttonEdit4
            // 
            this.buttonEdit4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit4.Buttons.Add(this.buttonEditChildButton4);
            this.buttonEdit4.Controls.Add(this.buttonEditChildButton4);
            this.buttonEdit4.Location = new System.Drawing.Point(522, 201);
            this.buttonEdit4.Name = "buttonEdit4";
            this.buttonEdit4.ShowTextBox = false;
            this.buttonEdit4.Size = new System.Drawing.Size(99, 26);
            this.buttonEdit4.TabIndex = 106;
            this.buttonEdit4.UseVisualStyle = true;
            this.buttonEdit4.ButtonClicked += new Syncfusion.Windows.Forms.Tools.ButtonClickedEventHandler(this.buttonEdit4_ButtonClicked);
            // 
            // buttonEditChildButton4
            // 
            this.buttonEditChildButton4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton4.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton4.Image = null;
            this.buttonEditChildButton4.Name = "buttonEditChildButton4";
            this.buttonEditChildButton4.PreferredWidth = 18;
            this.buttonEditChildButton4.TabIndex = 1;
            this.buttonEditChildButton4.Text = "...";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox7.ForeColor = System.Drawing.Color.Black;
            this.comboBox7.Items.AddRange(new object[] {
            "Default",
            "HorizontalGradient",
            "VerticalGradient"});
            this.comboBox7.Location = new System.Drawing.Point(522, 160);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(99, 21);
            this.comboBox7.TabIndex = 105;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(450, 163);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(70, 26);
            this.label19.TabIndex = 104;
            this.label19.Text = "BackGround \r\nStyle";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label20.Image = ((System.Drawing.Image)(resources.GetObject("label20.Image")));
            this.label20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label20.Location = new System.Drawing.Point(450, 120);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 24);
            this.label20.TabIndex = 103;
            this.label20.Text = "Background Settings";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label21.Location = new System.Drawing.Point(452, 144);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(160, 1);
            this.label21.TabIndex = 102;
            // 
            // radioButtonAdv9
            // 
            this.radioButtonAdv9.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv9.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAdv9.GradientStart = System.Drawing.SystemColors.Control;
            this.radioButtonAdv9.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv9.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.radioButtonAdv9.Location = new System.Drawing.Point(39, 234);
            this.radioButtonAdv9.Name = "radioButtonAdv9";
            this.radioButtonAdv9.ShadowColor = System.Drawing.Color.Black;
            this.radioButtonAdv9.ShadowOffset = new System.Drawing.Point(2, 2);
            this.radioButtonAdv9.Size = new System.Drawing.Size(125, 21);
            this.radioButtonAdv9.StretchImage = false;
            this.radioButtonAdv9.TabIndex = 99;
            this.radioButtonAdv9.Text = "Office2007 - Black";
            this.radioButtonAdv9.ThemesEnabled = true;
            this.radioButtonAdv9.CheckChanged += new System.EventHandler(this.radioButtonVisualStyle_CheckChanged);
            // 
            // radioButtonAdv10
            // 
            this.radioButtonAdv10.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv10.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAdv10.GradientStart = System.Drawing.SystemColors.Control;
            this.radioButtonAdv10.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv10.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.radioButtonAdv10.Location = new System.Drawing.Point(39, 206);
            this.radioButtonAdv10.Name = "radioButtonAdv10";
            this.radioButtonAdv10.ShadowColor = System.Drawing.Color.Black;
            this.radioButtonAdv10.ShadowOffset = new System.Drawing.Point(2, 2);
            this.radioButtonAdv10.Size = new System.Drawing.Size(125, 21);
            this.radioButtonAdv10.StretchImage = false;
            this.radioButtonAdv10.TabIndex = 98;
            this.radioButtonAdv10.Text = "Office2007 - Silver";
            this.radioButtonAdv10.ThemesEnabled = true;
            this.radioButtonAdv10.CheckChanged += new System.EventHandler(this.radioButtonVisualStyle_CheckChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(36, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 24);
            this.label9.TabIndex = 96;
            this.label9.Text = "Visual Styles";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label10.Location = new System.Drawing.Point(36, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 1);
            this.label10.TabIndex = 95;
            // 
            // radioButtonAdv11
            // 
            this.radioButtonAdv11.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv11.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAdv11.GradientStart = System.Drawing.SystemColors.Control;
            this.radioButtonAdv11.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv11.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.radioButtonAdv11.Location = new System.Drawing.Point(39, 178);
            this.radioButtonAdv11.Name = "radioButtonAdv11";
            this.radioButtonAdv11.ShadowColor = System.Drawing.Color.Black;
            this.radioButtonAdv11.ShadowOffset = new System.Drawing.Point(2, 2);
            this.radioButtonAdv11.Size = new System.Drawing.Size(113, 21);
            this.radioButtonAdv11.StretchImage = false;
            this.radioButtonAdv11.TabIndex = 94;
            this.radioButtonAdv11.Text = "Office2007 - Blue";
            this.radioButtonAdv11.ThemesEnabled = true;
            this.radioButtonAdv11.CheckChanged += new System.EventHandler(this.radioButtonVisualStyle_CheckChanged);
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt2.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.OverflowIndicatorToolTipText = null;
            this.textBoxExt2.Size = new System.Drawing.Size(49, 13);
            this.textBoxExt2.TabIndex = 0;
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxExt1.Location = new System.Drawing.Point(2, 4);
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.OverflowIndicatorToolTipText = null;
            this.textBoxExt1.Size = new System.Drawing.Size(42, 13);
            this.textBoxExt1.TabIndex = 0;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox5.ForeColor = System.Drawing.Color.Black;
            this.comboBox5.Location = new System.Drawing.Point(132, 331);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(75, 21);
            this.comboBox5.TabIndex = 117;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label27.Image = ((System.Drawing.Image)(resources.GetObject("label27.Image")));
            this.label27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label27.Location = new System.Drawing.Point(30, 255);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(114, 24);
            this.label27.TabIndex = 116;
            this.label27.Text = "Border Settings";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label28.Location = new System.Drawing.Point(30, 279);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(150, 1);
            this.label28.TabIndex = 115;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(25, 293);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 13);
            this.label29.TabIndex = 114;
            this.label29.Text = "Border Style";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(25, 331);
            this.label30.Margin = new System.Windows.Forms.Padding(0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(78, 13);
            this.label30.TabIndex = 112;
            this.label30.Text = "Border3D Style";
            // 
            // comboBox11
            // 
            this.comboBox11.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox11.ForeColor = System.Drawing.Color.Black;
            this.comboBox11.Items.AddRange(new object[] {
            "None",
            "FixedSingle",
            "Fixed3D"});
            this.comboBox11.Location = new System.Drawing.Point(139, 291);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(75, 21);
            this.comboBox11.TabIndex = 111;
            // 
            // radioButtonAdv13
            // 
            this.radioButtonAdv13.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv13.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAdv13.GradientStart = System.Drawing.SystemColors.Control;
            this.radioButtonAdv13.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv13.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.radioButtonAdv13.Location = new System.Drawing.Point(215, 28);
            this.radioButtonAdv13.Name = "radioButtonAdv13";
            this.radioButtonAdv13.ShadowColor = System.Drawing.Color.Black;
            this.radioButtonAdv13.ShadowOffset = new System.Drawing.Point(2, 2);
            this.radioButtonAdv13.Size = new System.Drawing.Size(190, 34);
            this.radioButtonAdv13.TabIndex = 110;
            this.radioButtonAdv13.Text = "radioButtonAdv12";
            this.radioButtonAdv13.ThemesEnabled = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(25, 217);
            this.label31.Margin = new System.Windows.Forms.Padding(0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(96, 13);
            this.label31.TabIndex = 109;
            this.label31.Text = "Gradient End Color";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(29, 190);
            this.label32.Margin = new System.Windows.Forms.Padding(0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(99, 13);
            this.label32.TabIndex = 108;
            this.label32.Text = "Gradient Start Color";
            // 
            // buttonEdit6
            // 
            this.buttonEdit6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit6.Buttons.Add(this.buttonEditChildButton6);
            this.buttonEdit6.Controls.Add(this.buttonEditChildButton6);
            this.buttonEdit6.Controls.Add(this.textBoxExt2);
            this.buttonEdit6.Location = new System.Drawing.Point(156, 209);
            this.buttonEdit6.Name = "buttonEdit6";
            this.buttonEdit6.ShowTextBox = false;
            this.buttonEdit6.Size = new System.Drawing.Size(71, 21);
            this.buttonEdit6.TabIndex = 107;
            this.buttonEdit6.TextBox = this.textBoxExt2;
            this.buttonEdit6.UseVisualStyle = true;
            // 
            // buttonEditChildButton6
            // 
            this.buttonEditChildButton6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton6.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton6.Image = null;
            this.buttonEditChildButton6.Name = "buttonEditChildButton6";
            this.buttonEditChildButton6.PreferredWidth = 18;
            this.buttonEditChildButton6.TabIndex = 1;
            this.buttonEditChildButton6.Text = "...";
            // 
            // buttonEdit7
            // 
            this.buttonEdit7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEdit7.Buttons.Add(this.buttonEditChildButton7);
            this.buttonEdit7.Controls.Add(this.buttonEditChildButton7);
            this.buttonEdit7.Controls.Add(this.textBoxExt1);
            this.buttonEdit7.Location = new System.Drawing.Point(149, 182);
            this.buttonEdit7.Name = "buttonEdit7";
            this.buttonEdit7.ShowTextBox = false;
            this.buttonEdit7.Size = new System.Drawing.Size(64, 21);
            this.buttonEdit7.TabIndex = 106;
            this.buttonEdit7.TextBox = this.textBoxExt1;
            this.buttonEdit7.UseVisualStyle = true;
            // 
            // buttonEditChildButton7
            // 
            this.buttonEditChildButton7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.buttonEditChildButton7.ComboEditBackColor = System.Drawing.SystemColors.Window;
            this.buttonEditChildButton7.Image = null;
            this.buttonEditChildButton7.Name = "buttonEditChildButton7";
            this.buttonEditChildButton7.PreferredWidth = 18;
            this.buttonEditChildButton7.TabIndex = 1;
            this.buttonEditChildButton7.Text = "...";
            // 
            // comboBox12
            // 
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox12.ForeColor = System.Drawing.Color.Black;
            this.comboBox12.Items.AddRange(new object[] {
            "Default",
            "HorizontalGradient",
            "VerticalGradient"});
            this.comboBox12.Location = new System.Drawing.Point(125, 155);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(75, 21);
            this.comboBox12.TabIndex = 105;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(29, 163);
            this.label33.Margin = new System.Windows.Forms.Padding(0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(93, 13);
            this.label33.TabIndex = 104;
            this.label33.Text = "BackGround Style";
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label34.Image = ((System.Drawing.Image)(resources.GetObject("label34.Image")));
            this.label34.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label34.Location = new System.Drawing.Point(25, 123);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(147, 24);
            this.label34.TabIndex = 103;
            this.label34.Text = "Background Settings";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label35.Location = new System.Drawing.Point(29, 147);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(150, 1);
            this.label35.TabIndex = 102;
            // 
            // radioButtonAdv14
            // 
            this.radioButtonAdv14.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv14.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAdv14.GradientStart = System.Drawing.SystemColors.Control;
            this.radioButtonAdv14.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv14.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.radioButtonAdv14.Location = new System.Drawing.Point(274, 291);
            this.radioButtonAdv14.Name = "radioButtonAdv14";
            this.radioButtonAdv14.ShadowColor = System.Drawing.Color.Black;
            this.radioButtonAdv14.ShadowOffset = new System.Drawing.Point(2, 2);
            this.radioButtonAdv14.Size = new System.Drawing.Size(150, 21);
            this.radioButtonAdv14.StretchImage = false;
            this.radioButtonAdv14.TabIndex = 99;
            this.radioButtonAdv14.Text = "Office2007 - Black";
            this.radioButtonAdv14.ThemesEnabled = true;
            // 
            // radioButtonAdv15
            // 
            this.radioButtonAdv15.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv15.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAdv15.GradientStart = System.Drawing.SystemColors.Control;
            this.radioButtonAdv15.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv15.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.radioButtonAdv15.Location = new System.Drawing.Point(274, 253);
            this.radioButtonAdv15.Name = "radioButtonAdv15";
            this.radioButtonAdv15.ShadowColor = System.Drawing.Color.Black;
            this.radioButtonAdv15.ShadowOffset = new System.Drawing.Point(2, 2);
            this.radioButtonAdv15.Size = new System.Drawing.Size(150, 21);
            this.radioButtonAdv15.StretchImage = false;
            this.radioButtonAdv15.TabIndex = 98;
            this.radioButtonAdv15.Text = "Office2007 - Silver";
            this.radioButtonAdv15.ThemesEnabled = true;
            // 
            // comboBox13
            // 
            this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox13.ForeColor = System.Drawing.Color.Black;
            this.comboBox13.Location = new System.Drawing.Point(315, 176);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(75, 21);
            this.comboBox13.TabIndex = 97;
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label36.Image = ((System.Drawing.Image)(resources.GetObject("label36.Image")));
            this.label36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label36.Location = new System.Drawing.Point(256, 99);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(95, 24);
            this.label36.TabIndex = 96;
            this.label36.Text = "Visual Styles";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label37.Location = new System.Drawing.Point(256, 123);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(150, 1);
            this.label37.TabIndex = 95;
            // 
            // radioButtonAdv16
            // 
            this.radioButtonAdv16.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv16.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAdv16.GradientStart = System.Drawing.SystemColors.Control;
            this.radioButtonAdv16.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv16.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.radioButtonAdv16.Location = new System.Drawing.Point(274, 219);
            this.radioButtonAdv16.Name = "radioButtonAdv16";
            this.radioButtonAdv16.ShadowColor = System.Drawing.Color.Black;
            this.radioButtonAdv16.ShadowOffset = new System.Drawing.Point(2, 2);
            this.radioButtonAdv16.Size = new System.Drawing.Size(150, 21);
            this.radioButtonAdv16.StretchImage = false;
            this.radioButtonAdv16.TabIndex = 94;
            this.radioButtonAdv16.Text = "Office2007 - Blue";
            this.radioButtonAdv16.ThemesEnabled = true;
            // 
            // radioButtonAdv1
            // 
            this.radioButtonAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAdv1.GradientStart = System.Drawing.SystemColors.Control;
            this.radioButtonAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv1.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.radioButtonAdv1.Location = new System.Drawing.Point(37, 248);
            this.radioButtonAdv1.Name = "radioButtonAdv1";
            this.radioButtonAdv1.ShadowColor = System.Drawing.Color.Black;
            this.radioButtonAdv1.ShadowOffset = new System.Drawing.Point(2, 2);
            this.radioButtonAdv1.Size = new System.Drawing.Size(150, 21);
            this.radioButtonAdv1.StretchImage = false;
            this.radioButtonAdv1.TabIndex = 152;
            this.radioButtonAdv1.Text = "Office2007 - Managed";
            this.radioButtonAdv1.ThemesEnabled = true;
            // 
            // radioButtonAdv2
            // 
            this.radioButtonAdv2.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv2.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAdv2.GradientStart = System.Drawing.SystemColors.Control;
            this.radioButtonAdv2.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv2.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.radioButtonAdv2.Location = new System.Drawing.Point(39, 261);
            this.radioButtonAdv2.Name = "radioButtonAdv2";
            this.radioButtonAdv2.ShadowColor = System.Drawing.Color.Black;
            this.radioButtonAdv2.ShadowOffset = new System.Drawing.Point(2, 2);
            this.radioButtonAdv2.Size = new System.Drawing.Size(157, 21);
            this.radioButtonAdv2.StretchImage = false;
            this.radioButtonAdv2.TabIndex = 154;
            this.radioButtonAdv2.Text = "Office2007 - Managed";
            this.radioButtonAdv2.ThemesEnabled = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(200)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(664, 488);
            this.Controls.Add(this.tabControlAdv1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Option Controls";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.checkBoxAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlAdv1)).EndInit();
            this.tabControlAdv1.ResumeLayout(false);
            this.tabPageAdv1.ResumeLayout(false);
            this.tabPageAdv1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel1)).EndInit();
            this.gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5)).EndInit();
            this.buttonEdit5.ResumeLayout(false);
            this.buttonEdit5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2)).EndInit();
            this.buttonEdit2.ResumeLayout(false);
            this.buttonEdit2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1)).EndInit();
            this.buttonEdit1.ResumeLayout(false);
            this.buttonEdit1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv5)).EndInit();
            this.tabPageAdv2.ResumeLayout(false);
            this.tabPageAdv2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            this.gradientPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit8)).EndInit();
            this.buttonEdit8.ResumeLayout(false);
            this.buttonEdit8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3)).EndInit();
            this.buttonEdit3.ResumeLayout(false);
            this.buttonEdit3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4)).EndInit();
            this.buttonEdit4.ResumeLayout(false);
            this.buttonEdit4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit6)).EndInit();
            this.buttonEdit6.ResumeLayout(false);
            this.buttonEdit6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit7)).EndInit();
            this.buttonEdit7.ResumeLayout(false);
            this.buttonEdit7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).EndInit();
            this.ResumeLayout(false);

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

        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            #region CheckBoxAdv DataBinding
            DataTable m_tbl = new DataTable();
            m_tbl.Columns.Add("ID", typeof(int));
            m_tbl.Columns.Add("ValueStr", typeof(string));

            m_tbl.LoadDataRow(new object[] { 1, "Checked" }, true);
            m_tbl.LoadDataRow(new object[] { -1, "Indeterminate" }, true);
            m_tbl.LoadDataRow(new object[] { 0, "UnChecked" }, true);
            this.checkBoxAdv1.DataBindings.Add("IntValue", m_tbl, "ID");
            this.comboBox2.DataSource = m_tbl;
            this.comboBox2.DisplayMember = "ID";
            #endregion

            #region RadioButtonAdv DataBinding
            m_dt = new DataTable();
            m_dt.Columns.Add("ID", typeof(int));
            m_dt.Columns.Add("ValueStr", typeof(string));
            m_dt.LoadDataRow(new object[] { 0, "N" }, false);
            m_dt.LoadDataRow(new object[] { 1, "Y" }, true);
            this.radioButtonAdv12.DataBindings.Add("IntValue", m_dt, "ID");
            #endregion
            this.ColorScheme = Office2007Theme.Blue;


            //Populate Border3DStyles
            string[] str1 = Enum.GetNames(typeof(Border3DStyle));
            comboBox6.Items.AddRange(str1);
            comboBox10.Items.AddRange(str1);

            //Populate BorderSingle
            string[] str2 = Enum.GetNames(typeof(ButtonBorderStyle));
            comboBox14.Items.AddRange(str2);
            comboBox15.Items.AddRange(str2);

            //Populate Content Alignment
            string[] str3 = Enum.GetNames(typeof(System.Drawing.ContentAlignment));
            comboBox16.Items.AddRange(str3);
            comboBox17.Items.AddRange(str3);
            comboBox19.Items.AddRange(str3);
            comboBox18.Items.AddRange(str3);


            this.comboBox1.SelectedIndex= 0;
            this.comboBox3.SelectedIndex = 0;
            this.comboBox4.SelectedIndex = 0;
            this.comboBox6.SelectedIndex= 1;
             this.comboBox7.SelectedIndex = 0;
             this.comboBox8.SelectedIndex = 0;
             this.comboBox9.SelectedIndex = 0;
             this.comboBox10.SelectedIndex = 1;
             this.comboBox14.SelectedIndex= 3;
             this.comboBox15.SelectedIndex = 3;
            this.comboBox16.SelectedIndex = 3;
             this.comboBox17.SelectedIndex = 3;
             this.comboBox19.SelectedIndex= 3;
             this.comboBox18.SelectedIndex=3;
             this.buttonEdit1.TextBox.BackColor = Color.FromArgb(192, 192, 255);
             this.buttonEdit4.TextBox.BackColor = Color.FromArgb(192, 192, 255);

             this.buttonEdit2.TextBox.BackColor = Color.FromArgb(255, 224, 192);
             this.buttonEdit3.TextBox.BackColor = Color.FromArgb(255, 224, 192);

            this.checkBoxAdv1.Size = new Size(129, 35);
         }
        #endregion

        #region CheckBoxAdv PRoperties
         #region TextShadow

         private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBoxAdv1.TextShadow = this.checkBox4.Checked;
        }


        #endregion

         #region ReadOnlyMode
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBoxAdv1.ReadOnlyMode = this.checkBox6.Checked;
        }

        #endregion

         #region  ImageCheckBox
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBoxAdv1.ImageCheckBox = this.checkBox3.Checked;
        }

        #endregion

         #region Tristate
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox5.Checked)
            {
                this.checkBoxAdv1.Tristate = true;
                //this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            }
            else
            {
                this.checkBoxAdv1.Tristate = false;
                this.checkBoxAdv1.CheckState = System.Windows.Forms.CheckState.Checked;
            }

        }
        #endregion

         #region CheckState
        private void checkBoxAdv1_CheckStateChanged(object sender, System.EventArgs e)
        {
            if (this.checkBoxAdv1.CheckState == System.Windows.Forms.CheckState.Checked)
            {
                this.checkBoxAdv1.Text = "Checked";
            }
            else if (this.checkBoxAdv1.CheckState == System.Windows.Forms.CheckState.Unchecked)
            {
                this.checkBoxAdv1.Text = "Unchecked";
            }

            else if (this.checkBoxAdv1.CheckState == System.Windows.Forms.CheckState.Indeterminate)
            {
                this.checkBoxAdv1.Text = "Indeterminate";
            }


        }
        #endregion

         #region  BackGroundStyle
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.Items[comboBox4.SelectedIndex].ToString())
            {
                case "Default":
                    this.checkBoxAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.Default;
                    break;
                case "HorizontalGradient":
                    this.checkBoxAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.HorizontalGradient;
                    break;
                case "VerticalGradient":
                    this.checkBoxAdv1.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.VerticalGradient;
                    break;
            }
        }

        #endregion
        
         #region Gradient Colors
        private void buttonEdit1_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonEdit1.TextBox.BackColor = colorDialog1.Color;
                this.checkBoxAdv1.GradientStart = colorDialog1.Color;
            }
        }

        private void buttonEdit2_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonEdit2.TextBox.BackColor = colorDialog1.Color;
                this.checkBoxAdv1.GradientEnd = colorDialog1.Color;
            }

        }
        #endregion

         #region  BorderStyle
        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox8.Items[comboBox8.SelectedIndex].ToString())
            {
                case "None":
                    this.checkBoxAdv1.BorderStyle = BorderStyle.None;
                    this.comboBox6.Enabled = false;
                    this.buttonEdit5.Enabled = false;
                    this.comboBox14.Enabled = false;
                    break;
                case "FixedSingle":
                    this.checkBoxAdv1.BorderStyle = BorderStyle.FixedSingle;
                    this.comboBox6.Enabled = false;
                    this.buttonEdit5.Enabled = true;
                    this.comboBox14.Enabled = true;
                    break;
                case "Fixed3D":
                    this.checkBoxAdv1.BorderStyle = BorderStyle.Fixed3D;
                    this.comboBox6.Enabled = true;
                    this.buttonEdit5.Enabled = false;
                    this.comboBox14.Enabled = false;
                    break;

            }
        }
        #endregion

         #region Border3DStyle
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox6.Items[comboBox6.SelectedIndex].ToString())
            {
                case "RaisedOuter":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.RaisedOuter;
                    break;
                case "Adjust":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.Adjust;
                    break;
                case "Bump":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.Bump;
                    break;
                case "Etched":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.Etched;
                    break;
                case "Flat":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.Flat;
                    break;
                case "Raised":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.Raised;
                    break;
                case "RaisedInner":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.RaisedInner;
                    break;
                case "Sunken":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.Sunken;
                    break;
                case "SunkenInner":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.SunkenInner;
                    break;
                case "SunkenOuter":
                    this.checkBoxAdv1.Border3DStyle = Border3DStyle.SunkenOuter;
                    break;
            }
        }
        #endregion

         #region BorderColor
        private void buttonEdit5_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonEdit5.TextBox.BackColor = colorDialog1.Color;
                this.checkBoxAdv1.BorderColor = colorDialog1.Color;
            }
        }
        #endregion

         #region BorderSingleStyle

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox14.Items[comboBox14.SelectedIndex].ToString())
            {
                case "Dashed":
                    this.checkBoxAdv1.BorderSingle = ButtonBorderStyle.Dashed;
                    break;
                case "Dotted":
                    this.checkBoxAdv1.BorderSingle = ButtonBorderStyle.Dotted;
                    break;
                case "Inset":
                    this.checkBoxAdv1.BorderSingle = ButtonBorderStyle.Inset;
                    break;
                case "None":
                    this.checkBoxAdv1.BorderSingle = ButtonBorderStyle.None;
                    break;
                case "Outset":
                    this.checkBoxAdv1.BorderSingle = ButtonBorderStyle.Outset;
                    break;
                case "Solid":
                    this.checkBoxAdv1.BorderSingle = ButtonBorderStyle.Solid;
                    break;
            }

        }
        #endregion

         #region VisualStyle
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
            {
                this.checkBox7.Checked = true;
                this.radioButtonAdv5.Enabled = false;
                this.radioButtonAdv7.Enabled = false;
                this.radioButtonAdv8.Enabled = false;
                this.radioButtonAdv1.Enabled = false;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Default;
            }
            else
            {
                this.checkBox7.Checked = false;
                this.radioButtonAdv5.Enabled = true;
                this.radioButtonAdv7.Enabled = true;
                this.radioButtonAdv8.Enabled = true;
                this.radioButtonAdv1.Enabled = true;
                this.checkBoxAdv1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Office2007;
            }
        }

        private void VisualStyle_CheckChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAdv5.Checked)
                this.checkBoxAdv1.Office2007ColorScheme = Office2007Theme.Blue;
            if (this.radioButtonAdv7.Checked)
                this.checkBoxAdv1.Office2007ColorScheme = Office2007Theme.Silver;
            if (this.radioButtonAdv8.Checked)
                this.checkBoxAdv1.Office2007ColorScheme = Office2007Theme.Black;
            if (this.radioButtonAdv1.Checked)
            {
                this.checkBoxAdv1.Office2007ColorScheme = Office2007Theme.Managed;
                Office2007Colors.ApplyManagedColors(this, Color.DarkRed);
            }

        }
        #endregion

         #region Glyph Align
        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox19.SelectedIndex)
            {
                case 0:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.TopLeft;
                    break;
                case 1:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.TopCenter;
                    break;
                case 2:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.TopRight;
                    break;
                case 3:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.MiddleLeft;
                    break;
                case 4:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.MiddleCenter;
                    break;
                case 5:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.MiddleRight;
                    break;
                case 6:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.BottomLeft;
                    break;
                case 7:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.BottomCenter;
                    break;
                case 8:
                    this.checkBoxAdv1.CheckAlign = ContentAlignment.BottomRight;
                    break;


            }


        }
        #endregion

         #region TextAlign
        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox18.SelectedIndex)
            {
                case 0:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.TopLeft;
                    break;
                case 1:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.TopCenter;
                    break;
                case 2:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.TopRight;
                    break;
                case 3:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.MiddleLeft;
                    break;
                case 4:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.MiddleCenter;
                    break;
                case 5:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.MiddleRight;
                    break;
                case 6:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.BottomLeft;
                    break;
                case 7:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.BottomCenter;
                    break;
                case 8:
                    this.checkBoxAdv1.TextContentAlignment = ContentAlignment.BottomRight;
                    break;


            }

        }
        #endregion

         #region ThemesEnabled
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            this.checkBoxAdv1.ThemesEnabled = checkBox7.Checked;
        }
        #endregion

      

        #endregion

        #region RadioButtonAdv properties

        #region ImageCheckBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonAdv12.ImageCheckBox = this.checkBox1.Checked;
        }
        #endregion
       
        #region BackGroundStyle
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox7.Items[comboBox7.SelectedIndex].ToString())
            {
                case "Default":
                    this.radioButtonAdv12.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.Default;
                    break;
                case "HorizontalGradient":
                    this.radioButtonAdv12.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.HorizontalGradient;
                    break;
                case "VerticalGradient":
                    this.radioButtonAdv12.BackgroundStyle = Syncfusion.Windows.Forms.Tools.CheckBoxAdvBackStyle.VerticalGradient;
                    break;
            }
        }
        #endregion

        #region Gradient Colors
        private void buttonEdit4_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonEdit4.TextBox.BackColor = colorDialog1.Color;
                this.radioButtonAdv12.GradientStart = colorDialog1.Color;
            }
        }

        private void buttonEdit3_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonEdit3.TextBox.BackColor = colorDialog1.Color;
                this.radioButtonAdv12.GradientEnd = colorDialog1.Color;
            }
        }
        #endregion

        #region BorderStyle

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox9.Items[comboBox9.SelectedIndex].ToString())
            {
                case "None":
                    this.radioButtonAdv12.BorderStyle = BorderStyle.None;
                    this.comboBox10.Enabled = false;
                    this.comboBox15.Enabled = false;
                    this.buttonEdit8.Enabled = false;
                    break;
                case "FixedSingle":
                    this.radioButtonAdv12.BorderStyle = BorderStyle.FixedSingle;
                    this.comboBox10.Enabled = false;
                    this.comboBox15.Enabled = true;
                    this.buttonEdit8.Enabled = true;
                    break;
                case "Fixed3D":
                    this.radioButtonAdv12.BorderStyle = BorderStyle.Fixed3D;
                    this.comboBox10.Enabled = true;
                    this.comboBox15.Enabled = false;
                    this.buttonEdit8.Enabled = false;
                    break;
            }
        }
        #endregion
        
        #region Border3DStyle
        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox10.Items[comboBox10.SelectedIndex].ToString())
            {
                case "RaisedOuter":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.RaisedOuter;
                    break;
                case "Adjust":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.Adjust;
                    break;
                case "Bump":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.Bump;
                    break;
                case "Etched":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.Etched;
                    break;
                case "Flat":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.Flat;
                    break;
                case "Raised":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.Raised;
                    break;
                case "RaisedInner":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.RaisedInner;
                    break;
                case "Sunken":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.Sunken;
                    break;
                case "SunkenInner":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.SunkenInner;
                    break;
                case "SunkenOuter":
                    this.radioButtonAdv12.Border3DStyle = Border3DStyle.SunkenOuter;
                    break;
            }
        }
        #endregion

        #region  BorderColor
        private void buttonEdit8_ButtonClicked(object sender, Syncfusion.Windows.Forms.Tools.ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonEdit8.TextBox.BackColor = colorDialog1.Color;
                this.radioButtonAdv12.BorderColor = colorDialog1.Color;
            }

        }
        #endregion

        #region BorderSingleStyle

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox15.Items[comboBox15.SelectedIndex].ToString())
            {
                case "Dashed":
                    this.radioButtonAdv12.BorderSingle = ButtonBorderStyle.Dashed;
                    break;
                case "Dotted":
                    this.radioButtonAdv12.BorderSingle = ButtonBorderStyle.Dotted;
                    break;
                case "Inset":
                    this.radioButtonAdv12.BorderSingle = ButtonBorderStyle.Inset;
                    break;
                case "None":
                    this.radioButtonAdv12.BorderSingle = ButtonBorderStyle.None;
                    break;
                case "Outset":
                    this.radioButtonAdv12.BorderSingle = ButtonBorderStyle.Outset;
                    break;
                case "Solid":
                    this.radioButtonAdv12.BorderSingle = ButtonBorderStyle.Solid;
                    break;
            }
        }
        #endregion

        #region DataBinding

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            CurrencyManager mgr = (CurrencyManager)(BindingContext[m_dt]);
            if (mgr.Position < mgr.Count - 1)
            {
                mgr.Position = mgr.Position + 1;
            }
            else if (mgr.Position > 0)
                mgr.Position = mgr.Position - 1;
        }
        #endregion

        #region VisualStyle
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox3.SelectedIndex == 0)
            {
                this.checkBox8.Checked = true;
                this.radioButtonAdv11.Enabled = false;
                this.radioButtonAdv10.Enabled = false;
                this.radioButtonAdv9.Enabled = false;
                this.radioButtonAdv2.Enabled = false;
                this.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Default;
            }
            else
            {
                this.checkBox8.Checked = false;
                this.radioButtonAdv11.Enabled = true;
                this.radioButtonAdv10.Enabled = true;
                this.radioButtonAdv9.Enabled = true;
                this.radioButtonAdv2.Enabled = true;
                this.radioButtonAdv12.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Office2007;
            }
        }
        private void radioButtonVisualStyle_CheckChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAdv11.Checked)
                this.radioButtonAdv12.Office2007ColorScheme = Office2007Theme.Blue;
            if (this.radioButtonAdv10.Checked)
                this.radioButtonAdv12.Office2007ColorScheme = Office2007Theme.Silver;
            if (this.radioButtonAdv9.Checked)
                this.radioButtonAdv12.Office2007ColorScheme = Office2007Theme.Black;
            if (this.radioButtonAdv2.Checked)
            {
                this.radioButtonAdv12.Office2007ColorScheme = Office2007Theme.Managed;
                Office2007Colors.ApplyManagedColors(this, Color.DarkRed);
            }

        }
        #endregion

        #region TextShadow
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonAdv12.TextShadow = this.checkBox9.Checked;
        }
        #endregion
        
        #region Glyph Align
        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox16.SelectedIndex)
            {
                case 0:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.TopLeft;
                    break;
                case 1:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.TopCenter;
                    break;
                case 2:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.TopRight;
                    break;
                case 3:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.MiddleLeft;
                    break;
                case 4:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.MiddleCenter;
                    break;
                case 5:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.MiddleRight;
                    break;
                case 6:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.BottomLeft;
                    break;
                case 7:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.BottomCenter;
                    break;
                case 8:
                    this.radioButtonAdv12.CheckAlign = ContentAlignment.BottomRight;
                    break;


            }

        }
        #endregion

        #region TextAlign
        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox17.SelectedIndex)
            {
                case 0:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.TopLeft;
                    break;
                case 1:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.TopCenter;
                    break;
                case 2:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.TopRight;
                    break;
                case 3:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.MiddleLeft;
                    break;
                case 4:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.MiddleCenter;
                    break;
                case 5:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.MiddleRight;
                    break;
                case 6:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.BottomLeft;
                    break;
                case 7:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.BottomCenter;
                    break;
                case 8:
                    this.radioButtonAdv12.TextContentAlignment = ContentAlignment.BottomRight;
                    break;


            }

        }
        #endregion
        
        #region ThemesEnabled
        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonAdv12.ThemesEnabled = checkBox8.Checked;
        }
        #endregion

        #region RadioButton State
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonAdv12.Checked = this.checkBox2.Checked;
        }
        #endregion

         #endregion

       
    }
}