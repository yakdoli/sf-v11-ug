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
namespace SplitContainerAdv
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : Office2007Form
    {
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox2;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Syncfusion.Windows.Forms.Tools.SplitContainerAdv splitContainerAdv2;
        private Label label4;
        private ComboBox comboBox2;
        private Syncfusion.Windows.Forms.Tools.TreeViewAdv treeViewAdv1;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private Syncfusion.Windows.Forms.Tools.GradientPanel panel2;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv1;
        private GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radioButtonAdv2;
        private Label label7;
        private Label label6;
        private Label label21;
        private ToolTip toolTip1;
        private IContainer components;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            
            this.comboBox2.SelectedIndex = 0;

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

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo treeNodeAdvStyleInfo1 = new Syncfusion.Windows.Forms.Tools.TreeNodeAdvStyleInfo();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainerAdv1 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.treeViewAdv1 = new Syncfusion.Windows.Forms.Tools.TreeViewAdv();
            this.splitContainerAdv2 = new Syncfusion.Windows.Forms.Tools.SplitContainerAdv();
            this.panel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAdv2 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.radioButtonAdv1 = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.checkBox2 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).BeginInit();
            this.splitContainerAdv1.Panel1.SuspendLayout();
            this.splitContainerAdv1.Panel2.SuspendLayout();
            this.splitContainerAdv1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv2)).BeginInit();
            this.splitContainerAdv2.Panel1.SuspendLayout();
            this.splitContainerAdv2.Panel2.SuspendLayout();
            this.splitContainerAdv2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerAdv1
            // 
            this.splitContainerAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv1.FixedPanel = Syncfusion.Windows.Forms.Tools.Enums.FixedPanel.Panel1;
            this.splitContainerAdv1.GripDark = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Salmon);
            this.splitContainerAdv1.GripLight = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Yellow);
            this.splitContainerAdv1.HotGripDark = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.SystemColors.Info, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255))))));
            this.splitContainerAdv1.HotGripLight = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.PatternStyle.Percent20, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Red);
            this.splitContainerAdv1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv1.Name = "splitContainerAdv1";
            // 
            // splitContainerAdv1.Panel1
            // 
            this.splitContainerAdv1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.splitContainerAdv1.Panel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(252))))), System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255))))));
            this.splitContainerAdv1.Panel1.Controls.Add(this.treeViewAdv1);
            // 
            // splitContainerAdv1.Panel2
            // 
            this.splitContainerAdv1.Panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(252))))), System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255))))));
            this.splitContainerAdv1.Panel2.Controls.Add(this.splitContainerAdv2);
            this.splitContainerAdv1.PanelToBeCollapsed = Syncfusion.Windows.Forms.Tools.Enums.CollapsedPanel.Panel1;
            this.splitContainerAdv1.Size = new System.Drawing.Size(713, 461);
            this.splitContainerAdv1.SplitterDistance = 245;
            this.splitContainerAdv1.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue;
            this.splitContainerAdv1.TabIndex = 0;
            this.splitContainerAdv1.Text = "splitContainerAdv1";
            this.splitContainerAdv1.ThemesEnabled = true;
            this.splitContainerAdv1.SplitterMoving += new Syncfusion.Windows.Forms.Tools.Events.SplitterMoveEventHandler(this.splitContainerAdv1_SplitterMoving);
            // 
            // treeViewAdv1
            // 
            this.treeViewAdv1.AllowDrop = true;
            this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(211)))), ((int)(((byte)(241))))), System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(229)))), ((int)(((byte)(241))))));
            treeNodeAdvStyleInfo1.EnsureDefaultOptionedChild = true;
            this.treeViewAdv1.BaseStylePairs.AddRange(new Syncfusion.Windows.Forms.Tools.StyleNamePair[] {
            new Syncfusion.Windows.Forms.Tools.StyleNamePair("Standard", treeNodeAdvStyleInfo1)});
            this.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewAdv1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            this.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.HelpTextControl.Location = new System.Drawing.Point(732, 0);
            this.treeViewAdv1.HelpTextControl.Name = "helpText";
            this.treeViewAdv1.HelpTextControl.Size = new System.Drawing.Size(50, 17);
            this.treeViewAdv1.HelpTextControl.TabIndex = 0;
            this.treeViewAdv1.HelpTextControl.Text = "help text";
            this.treeViewAdv1.Location = new System.Drawing.Point(0, 0);
            this.treeViewAdv1.Name = "treeViewAdv1";
            this.treeViewAdv1.NoChildrenImgIndex = -1;
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.EnsureDefaultOptionedChild = true;
            treeNodeAdv1.Expanded = true;
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.EnsureDefaultOptionedChild = true;
            treeNodeAdv2.Optioned = true;
            treeNodeAdv2.ShowOptionButton = true;
            treeNodeAdv2.Text = "Single";
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.EnsureDefaultOptionedChild = true;
            treeNodeAdv3.ShowOptionButton = true;
            treeNodeAdv3.Text = "Married";
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.EnsureDefaultOptionedChild = true;
            treeNodeAdv4.ShowOptionButton = true;
            treeNodeAdv4.Text = "Married with children";
            treeNodeAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv2,
            treeNodeAdv3,
            treeNodeAdv4});
            treeNodeAdv1.Text = "Marital Status";
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.EnsureDefaultOptionedChild = true;
            treeNodeAdv5.Expanded = true;
            treeNodeAdv6.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.EnsureDefaultOptionedChild = true;
            treeNodeAdv6.Optioned = true;
            treeNodeAdv6.Text = "Hepatitis B";
            treeNodeAdv7.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.EnsureDefaultOptionedChild = true;
            treeNodeAdv7.Text = "Tetanus";
            treeNodeAdv8.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.EnsureDefaultOptionedChild = true;
            treeNodeAdv8.Text = "Polio";
            treeNodeAdv9.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.EnsureDefaultOptionedChild = true;
            treeNodeAdv9.Text = "Measles";
            treeNodeAdv5.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv6,
            treeNodeAdv7,
            treeNodeAdv8,
            treeNodeAdv9});
            treeNodeAdv5.Text = "Baby Vaccines";
            treeNodeAdv10.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.EnsureDefaultOptionedChild = true;
            treeNodeAdv10.Expanded = true;
            treeNodeAdv11.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.EnsureDefaultOptionedChild = true;
            treeNodeAdv11.Optioned = true;
            treeNodeAdv11.Text = "Canada";
            treeNodeAdv12.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.EnsureDefaultOptionedChild = true;
            treeNodeAdv12.Text = "France";
            treeNodeAdv13.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.EnsureDefaultOptionedChild = true;
            treeNodeAdv13.Text = "Germany";
            treeNodeAdv14.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.EnsureDefaultOptionedChild = true;
            treeNodeAdv14.Text = "UK";
            treeNodeAdv10.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv11,
            treeNodeAdv12,
            treeNodeAdv13,
            treeNodeAdv14});
            treeNodeAdv10.Text = "Node9";
            treeNodeAdv15.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.EnsureDefaultOptionedChild = true;
            treeNodeAdv15.Expanded = true;
            treeNodeAdv16.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.EnsureDefaultOptionedChild = true;
            treeNodeAdv16.Optioned = true;
            treeNodeAdv16.Text = "Finding Nemo";
            treeNodeAdv17.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.EnsureDefaultOptionedChild = true;
            treeNodeAdv17.Text = "Lord of the Rings";
            treeNodeAdv18.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.EnsureDefaultOptionedChild = true;
            treeNodeAdv18.Text = "Matrix Reloaded";
            treeNodeAdv19.ChildStyle.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.EnsureDefaultOptionedChild = true;
            treeNodeAdv19.Text = "T3";
            treeNodeAdv15.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv16,
            treeNodeAdv17,
            treeNodeAdv18,
            treeNodeAdv19});
            treeNodeAdv15.Text = "Top 2003 Movies";
            this.treeViewAdv1.Nodes.AddRange(new Syncfusion.Windows.Forms.Tools.TreeNodeAdv[] {
            treeNodeAdv1,
            treeNodeAdv5,
            treeNodeAdv10,
            treeNodeAdv15});
            this.treeViewAdv1.PathSeparator = "/";
            this.treeViewAdv1.Size = new System.Drawing.Size(245, 461);
            this.treeViewAdv1.TabIndex = 1;
            this.treeViewAdv1.Text = "treeViewAdv1";
            // 
            // 
            // 
            this.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info;
            this.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeViewAdv1.ToolTipControl.Location = new System.Drawing.Point(642, 0);
            this.treeViewAdv1.ToolTipControl.Name = "toolTip";
            this.treeViewAdv1.ToolTipControl.Size = new System.Drawing.Size(41, 17);
            this.treeViewAdv1.ToolTipControl.TabIndex = 1;
            this.treeViewAdv1.ToolTipControl.Text = "toolTip";
            // 
            // splitContainerAdv2
            // 
            this.splitContainerAdv2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207))))));
            this.splitContainerAdv2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerAdv2.ExpandFill = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Blue);
            this.splitContainerAdv2.FixedPanel = Syncfusion.Windows.Forms.Tools.Enums.FixedPanel.Panel1;
            this.splitContainerAdv2.HotBackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61))))), System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94))))));
            this.splitContainerAdv2.HotExpandFill = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Blue);
            this.splitContainerAdv2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerAdv2.Name = "splitContainerAdv2";
            this.splitContainerAdv2.Orientation = System.Windows.Forms.Orientation.Vertical;
            // 
            // splitContainerAdv2.Panel1
            // 
            this.splitContainerAdv2.Panel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(252))))), System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255))))));
            this.splitContainerAdv2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainerAdv2.Panel2
            // 
            this.splitContainerAdv2.Panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(209)))), ((int)(((byte)(252))))), System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255))))));
            this.splitContainerAdv2.Panel2.Controls.Add(this.gradientLabel1);
            this.splitContainerAdv2.PanelToBeCollapsed = Syncfusion.Windows.Forms.Tools.Enums.CollapsedPanel.Panel1;
            this.splitContainerAdv2.Size = new System.Drawing.Size(461, 461);
            this.splitContainerAdv2.SplitterDistance = 273;
            this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue;
            this.splitContainerAdv2.TabIndex = 0;
            this.splitContainerAdv2.Text = "splitContainerAdv2";
            this.splitContainerAdv2.ThemesEnabled = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(213)))), ((int)(((byte)(252))))), System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255))))));
            this.panel2.BorderColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numericUpDown2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Location = new System.Drawing.Point(26, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 206);
            this.panel2.TabIndex = 18;
            // 
            // label21
            // 
            this.label21.Image = ((System.Drawing.Image)(resources.GetObject("label21.Image")));
            this.label21.Location = new System.Drawing.Point(119, 148);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 20);
            this.label21.TabIndex = 25;
            this.toolTip1.SetToolTip(this.label21, "Set to true, disallows user from dragging the splitter. However toggling the pane" +
                    "l is possible.");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAdv2);
            this.groupBox1.Controls.Add(this.radioButtonAdv1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(198, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 76);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toggle Panel On";
            // 
            // radioButtonAdv2
            // 
            this.radioButtonAdv2.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv2.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAdv2.GradientStart = System.Drawing.SystemColors.Control;
            this.radioButtonAdv2.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv2.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.radioButtonAdv2.Location = new System.Drawing.Point(6, 43);
            this.radioButtonAdv2.Name = "radioButtonAdv2";
            this.radioButtonAdv2.ShadowColor = System.Drawing.Color.Black;
            this.radioButtonAdv2.ShadowOffset = new System.Drawing.Point(2, 2);
            this.radioButtonAdv2.Size = new System.Drawing.Size(100, 27);
            this.radioButtonAdv2.TabIndex = 7;
            this.radioButtonAdv2.Text = "Double Click";
            this.radioButtonAdv2.ThemesEnabled = true;
            // 
            // radioButtonAdv1
            // 
            this.radioButtonAdv1.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv1.Checked = true;
            this.radioButtonAdv1.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAdv1.GradientStart = System.Drawing.SystemColors.Control;
            this.radioButtonAdv1.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.radioButtonAdv1.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.radioButtonAdv1.Location = new System.Drawing.Point(6, 16);
            this.radioButtonAdv1.Name = "radioButtonAdv1";
            this.radioButtonAdv1.ShadowColor = System.Drawing.Color.Black;
            this.radioButtonAdv1.ShadowOffset = new System.Drawing.Point(2, 2);
            this.radioButtonAdv1.Size = new System.Drawing.Size(100, 27);
            this.radioButtonAdv1.TabIndex = 6;
            this.radioButtonAdv1.Text = "Click";
            this.radioButtonAdv1.ThemesEnabled = true;
            this.radioButtonAdv1.CheckChanged += new System.EventHandler(this.radioButtonAdv1_CheckChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label7.Location = new System.Drawing.Point(6, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 1);
            this.label7.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Properties";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Style";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoHeight = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBox1.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBox1.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBox1.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBox1.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBox1.Location = new System.Drawing.Point(9, 147);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.ShadowColor = System.Drawing.Color.Black;
            this.checkBox1.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBox1.Size = new System.Drawing.Size(104, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "IsSplitter Fixed";
            this.checkBox1.ThemesEnabled = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Items.AddRange(new object[] {
            "None"});
            this.comboBox2.Location = new System.Drawing.Point(66, 46);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(104, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoHeight = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBox3.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBox3.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBox3.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBox3.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBox3.Location = new System.Drawing.Point(9, 112);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.ShadowColor = System.Drawing.Color.Black;
            this.checkBox3.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBox3.Size = new System.Drawing.Size(183, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Panel2 Collapsed";
            this.checkBox3.ThemesEnabled = true;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoHeight = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBox2.GradientEnd = System.Drawing.SystemColors.ControlDark;
            this.checkBox2.GradientStart = System.Drawing.SystemColors.Control;
            this.checkBox2.HotBorderColor = System.Drawing.SystemColors.WindowFrame;
            this.checkBox2.ImageCheckBoxSize = new System.Drawing.Size(13, 13);
            this.checkBox2.Location = new System.Drawing.Point(9, 77);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.ShadowColor = System.Drawing.Color.Black;
            this.checkBox2.ShadowOffset = new System.Drawing.Point(2, 2);
            this.checkBox2.Size = new System.Drawing.Size(183, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Panel1 Collapsed";
            this.checkBox2.ThemesEnabled = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(198, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Splitter Distance";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(288, 72);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(104, 20);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(198, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Splitter Width";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(288, 46);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(104, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            191,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top)
                        | System.Windows.Forms.Border3DSide.Right)
                        | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.gradientLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gradientLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradientLabel1.Location = new System.Drawing.Point(42, 36);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(392, 108);
            this.gradientLabel1.TabIndex = 0;
            this.gradientLabel1.Text = resources.GetString("gradientLabel1.Text");
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(713, 461);
            this.Controls.Add(this.splitContainerAdv1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Split ContainerAdv";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainerAdv1.Panel1.ResumeLayout(false);
            this.splitContainerAdv1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv1)).EndInit();
            this.splitContainerAdv1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeViewAdv1)).EndInit();
            this.splitContainerAdv2.Panel1.ResumeLayout(false);
            this.splitContainerAdv2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerAdv2)).EndInit();
            this.splitContainerAdv2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioButtonAdv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            this.comboBox2.DataSource = Enum.GetValues(typeof(Syncfusion.Windows.Forms.Tools.Enums.Style));
            this.splitContainerAdv2.Style = Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue;
            this.comboBox2.SelectedIndex = 2;
        }

       
       

        private void numericUpDown1_ValueChanged(object sender, System.EventArgs e)
        {
            this.splitContainerAdv1.SplitterDistance = (int)this.numericUpDown1.Value;
        }

        private void splitContainerAdv1_SplitterMoving(object sender, Syncfusion.Windows.Forms.Tools.Events.SplitterMoveEventArgs e)
        {
            this.numericUpDown1.Value = this.splitContainerAdv1.SplitterDistance;
        }

        private void numericUpDown2_ValueChanged(object sender, System.EventArgs e)
        {
            this.splitContainerAdv1.SplitterWidth = (int)this.numericUpDown2.Value;
        }

        private void checkBox2_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox2.Checked)
            {
                this.splitContainerAdv1.Panel1Collapsed = true;
                this.checkBox3.Checked = false;
            }
            else
                this.splitContainerAdv1.Panel1Collapsed = false;


        }

        private void checkBox3_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox3.Checked)
            {
                this.splitContainerAdv2.Panel2Collapsed = true;
                this.checkBox2.Checked = false;
            }
            else
                this.splitContainerAdv2.Panel2Collapsed = false;


        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                this.splitContainerAdv1.IsSplitterFixed = true;
                this.splitContainerAdv2.IsSplitterFixed = true;
            }
            else
            {
                this.splitContainerAdv1.IsSplitterFixed = false;
                this.splitContainerAdv2.IsSplitterFixed = false;
            }
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.comboBox2.SelectedValue != null)
            {
                Syncfusion.Windows.Forms.Tools.Enums.Style v = (Syncfusion.Windows.Forms.Tools.Enums.Style)this.comboBox2.SelectedValue;
                this.splitContainerAdv2.Style = v;
                this.splitContainerAdv1.Style = v;
                SetTheme(v);
            }
        }

        private void SetTheme(Syncfusion.Windows.Forms.Tools.Enums.Style style)
        {
            switch (style)
            {
                case Syncfusion.Windows.Forms.Tools.Enums.Style.None:
                    this.panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
                    this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo();
                    this.treeViewAdv1.BackColor = Color.Transparent;
                    this.panel2.BackColor = Color.Transparent;
                    this.ColorScheme = Office2007Theme.Blue;
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.Default:
                    SetBackGroundColorToPanels(134, 134, 134, 134, 134, 134);
                    this.ColorScheme = Office2007Theme.Black;
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.Mozilla:
                    SetBackGroundColorToPanels(134, 134, 134, 134, 134, 134);
                    this.ColorScheme = Office2007Theme.Black;
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Black:
                    SetBackGroundColorToPanels(90, 90, 90, 134, 134, 134);
                    this.ColorScheme = Office2007Theme.Black;
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Blue:
                    SetBackGroundColorToPanels(186, 213, 252, 228, 240, 255);
                    this.ColorScheme = Office2007Theme.Blue;
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.Office2007Silver:
                    SetBackGroundColorToPanels(192, 196, 205, 221, 225, 229);
                    this.ColorScheme = Office2007Theme.Silver;
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.Office2003:
                    SetBackGroundColorToPanels(181, 196, 235, 197, 213, 233);
                    this.ColorScheme = Office2007Theme.Blue;
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.OfficeXP:
                    SetBackGroundColorToPanels(181, 196, 235, 197, 213, 233);
                    this.ColorScheme = Office2007Theme.Blue;
                    break;
                case Syncfusion.Windows.Forms.Tools.Enums.Style.VS2005:
                    SetBackGroundColorToPanels(134, 134, 134, 134, 134, 134);
                    this.ColorScheme = Office2007Theme.Black;
                    break;
            }
        }

        private void SetBackGroundColorToPanels(int r1, int g1, int b1, int r, int g, int b)
        {
            this.treeViewAdv1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(r1)))), ((int)(((byte)(g1)))), ((int)(((byte)(b1))))), System.Drawing.Color.FromArgb(((int)(((byte)(r)))), ((int)(((byte)(g)))), ((int)(((byte)(b))))));
          this.panel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(r1)))), ((int)(((byte)(g1)))), ((int)(((byte)(b1))))), System.Drawing.Color.FromArgb(((int)(((byte)(r)))), ((int)(((byte)(g)))), ((int)(((byte)(b))))));
        }

       

        private void radioButtonAdv1_CheckChanged(object sender, EventArgs e)
        {
            if (this.radioButtonAdv1.Checked)
            {
                this.splitContainerAdv1.TogglePanelOn = Syncfusion.Windows.Forms.Tools.Enums.TogglePanelOn.Click;
                this.splitContainerAdv2.TogglePanelOn = Syncfusion.Windows.Forms.Tools.Enums.TogglePanelOn.Click;
            }
            else
            {
                this.splitContainerAdv1.TogglePanelOn = Syncfusion.Windows.Forms.Tools.Enums.TogglePanelOn.DoubleClick;
                this.splitContainerAdv2.TogglePanelOn = Syncfusion.Windows.Forms.Tools.Enums.TogglePanelOn.DoubleClick;
            }
        }

    }
}
