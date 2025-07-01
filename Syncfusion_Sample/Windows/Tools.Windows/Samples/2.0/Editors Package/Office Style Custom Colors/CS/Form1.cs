#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using System.IO;
using Syncfusion.Drawing;

namespace CustomColors_2005
{
    
    public partial class Form1 : RibbonForm
    {
        #region Form constructor
        Color customColor;
        
        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            #region Default settings
            ToolStripControlHost host = new ToolStripControlHost(this.colorPickerUIAdv1);
            host.Size = new Size(200, 250);
            this.colorPickerUIAdv1.Dock = DockStyle.Fill;
            ToolStripDropDown dd = new ToolStripDropDown();
            dd.Items.Add(host);
            dd.Renderer = new BorderlessRenderer();
            this.toolStripDropDownButton1.DropDown = dd;
            string path = Application.StartupPath.ToString() + @"..\..\..\Text.rtf";
            if (File.Exists(path))
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            customColor = Color.FromArgb(127, 102, 160);
              Office2007Colors.ApplyManagedColors(this, Color.FromArgb(127, 102, 160));
              SetColors();
              this.groupBar1.SelectedItem = 0;

              this.xpTaskBarBox1.DrawFocusRect = false;
              this.xpTaskBarBox2.DrawFocusRect = false;

            #endregion

            #region Control's Visual Styles
            //To set custom colors, the Visual styles of the control
            //need to be set as Office2007 and the the color scheme 
            //should be set as Managed.

            //MonthaCalendarAdv Visual Styles
            //this.monthCalendarAdv1.Style = VisualStyle.Office2007;
            //this.monthCalendarAdv1.Office2007Theme = Office2007Theme.Managed;

              //ButtonAdv Visual Styles
            //this.buttonAdv2.UseVisualStyle = true;
            //this.buttonAdv2.Appearance = ButtonAppearance.Office2007;
            //this.buttonAdv2.Office2007ColorScheme = Office2007Theme.Managed;

              //NumericUpDown Visual Styles
            //this.numericUpDownExt1.VisualStyle = VisualStyle.Office2007;
            //this.numericUpDownExt1.ColorScheme = Office2007Theme.Managed;

              //CheckBoxAdv Visual Styles
            //this.checkBoxAdv1.Style = CheckBoxAdvStyle.Office2007;
            //this.checkBoxAdv1.Office2007ColorScheme = Office2007Theme.Managed;

              //Calculator Visual Styles
              //this.calculatorControl1.ButtonStyle = ButtonAppearance.Office2007;
            //this.calculatorControl1.Office2007Theme = Office2007Theme.Managed;

              //XPTaskBar Visual Styles
              //this.xpTaskBar1.Style = XPTaskBarStyle.Office2007;
              //this.xpTaskBar1.Office2007ColorScheme = Office2007Theme.Managed;

              //MonthaCalendarAdv Visual Styles
              //this.xpTaskPane1.VisualStyle = VisualStyle.Office2007;
              //this.xpTaskPane1.Office2007ColorScheme = Office2007Theme.Managed;

              //RibbonControlAdv Visual Styles
              //this.ribbonControlAdv1.OfficeColorScheme = ToolStripEx.ColorScheme.Managed;
#endregion
          }

        void Form1_Load(object sender, EventArgs e)
        {
            this.xpTaskPane1 = new Syncfusion.Windows.Forms.Tools.XPTaskPane();
            // 
            // xpTaskPane1
            // 
            this.xpTaskPane1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.xpTaskPane1.Controls.Add(this.wizardContainer1);
            this.xpTaskPane1.Dock = System.Windows.Forms.DockStyle.Right;
            // 
            // 
            // 
            this.xpTaskPane1.Header.BackColor = System.Drawing.Color.Transparent;
            this.xpTaskPane1.Header.BorderColor = System.Drawing.Color.Black;
            this.xpTaskPane1.Header.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xpTaskPane1.Header.Controls.Add(this.xpTaskPane1.HeaderLabel);
            this.xpTaskPane1.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.xpTaskPane1.Header.Location = new System.Drawing.Point(0, 0);
            this.xpTaskPane1.Header.Name = "header";
            this.xpTaskPane1.Header.Size = new System.Drawing.Size(229, 22);
            this.xpTaskPane1.Header.TabIndex = 2;
            // 
            // 
            // 
            this.xpTaskPane1.HeaderMenuItem.ImageIndex = 2;
            this.xpTaskPane1.HeaderMenuItem.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.xpTaskPane1.HeaderMenuItem.Style = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            this.xpTaskPane1.Location = new System.Drawing.Point(642, 157);
            this.xpTaskPane1.Name = "xpTaskPane1";
            this.xpTaskPane1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.xpTaskPane1.SelectedPage = this.xpTaskPage1;
            this.xpTaskPane1.Size = new System.Drawing.Size(233, 395);
            this.xpTaskPane1.TabIndex = 7;
            this.xpTaskPane1.TaskPages = new Syncfusion.Windows.Forms.Tools.XPTaskPage[] {
        this.xpTaskPage1,
        this.xpTaskPage2,
        this.xpTaskPage3};
            this.xpTaskPane1.TaskPanePageContainer = this.wizardContainer1;
            this.xpTaskPane1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Office2007;
            // 
            // wizardContainer1
            // 
            this.wizardContainer1.Controls.Add(this.xpTaskPage1);
            this.wizardContainer1.Controls.Add(this.xpTaskPage2);
            this.wizardContainer1.Controls.Add(this.xpTaskPage3);
            // 
            // xpTaskPage1
            // 
            this.xpTaskPage1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(146)))), ((int)(((byte)(206)))));
            this.xpTaskPage1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.xpTaskPage1.Controls.Add(this.panel4);
            this.xpTaskPage1.Controls.Add(this.multiColumnComboBox1);
            this.xpTaskPage1.Controls.Add(this.textBoxExt2);
            this.xpTaskPage1.Controls.Add(this.comboBoxBase1);
            this.xpTaskPage1.Controls.Add(this.buttonAdv6);
            this.xpTaskPage1.Controls.Add(this.buttonAdv5);
            this.xpTaskPage1.Controls.Add(this.label31);
            this.xpTaskPage1.Controls.Add(this.label11);
            this.xpTaskPage1.Controls.Add(this.linkLabel15);
            this.xpTaskPage1.Controls.Add(this.linkLabel16);
            this.xpTaskPage1.Controls.Add(this.label9);
            this.xpTaskPage1.Controls.Add(this.label12);
            this.xpTaskPage1.Controls.Add(this.label8);
            this.xpTaskPage1.Controls.Add(this.label10);
            this.xpTaskPage1.LayoutName = "Card1";
            this.xpTaskPage1.Location = new System.Drawing.Point(0, 25);
            this.xpTaskPage1.Name = "xpTaskPage1";
            this.xpTaskPage1.NextPage = null;
            this.xpTaskPage1.PreviousPage = null;
            this.xpTaskPage1.Size = new System.Drawing.Size(229, 369);
            this.xpTaskPage1.TabIndex = 0;
            this.xpTaskPage1.Title = "Basic Search";
            this.Controls.Add(this.xpTaskPane1);
        }

      
        #endregion

        #region Apply custom Color
        
        private void colorPickerUIAdv1_Picked(object sender, ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            customColor = args.Color;
            //Applies custom colors for syncfusion controls whose color scheme
            //is set as Managed and Visual styles set as Office2007
            Office2007Colors.ApplyManagedColors(this, customColor);
            SetColors();
            
            // Ensures that the PopupControlContainer is closed after the selection of a color.
            ColorPickerUIAdv cc = sender as ColorPickerUIAdv;
           ToolStripDropDown dd = cc.Parent as ToolStripDropDown;
           dd.Hide();
           this.Focus();
           
        }

        #region Colors for other controls
        private void SetColors()
        {
            this.trackBarItem1.TrackBarExControl.ButtonColor = customColor;
            Color[] color = new Color[] { Color.White, customColor };
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(GradientStyle.Vertical, color);
            this.richTextBox1.ForeColor = customColor;
            this.gradientPanel3.BorderColor = customColor;
            this.gradientPanel1.BorderColor = customColor;
        }
        #endregion
        #endregion

        #region AboutForm
        DemoCommon.AboutForm aboutForm = null;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            aboutForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            aboutForm.ShowDialog();
            Office2007Colors.ApplyManagedColors(aboutForm, customColor);
        }
        #endregion

        private void xpTaskBarBox1_ItemClick(object sender, XPTaskBarItemClickArgs e)
        {

        }

        private void ribbonControlAdv1_Click(object sender, EventArgs e)
        {

        }

     
    }
    #region BorderlessRenderer - For ColorPickerUIAdv
    public class BorderlessRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            // do nothing
        }
    }
    #endregion

}