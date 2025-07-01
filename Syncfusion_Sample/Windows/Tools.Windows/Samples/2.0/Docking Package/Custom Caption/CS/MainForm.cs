using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Microsoft.Win32;
namespace CustomCaption
{
    public partial class Form1 : Office2007Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();

            AddCaptionButtons();

            this.comboBoxBarItem1.ListBox.SelectedValueChanged += new EventHandler(ListBox_SelectedValueChanged);
            this.propertyGrid1.ToolbarVisible = false;
            this.propertyGrid1.SelectedObject = this.dockingManager1;
        }

        void ListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBoxBarItem1.ListBox.SelectedItem as string)
            {
                case "Default":
                    this.dockingManager1.VisualStyle = VisualStyle.Default;
                    this.ColorScheme = Office2007Theme.Silver;
                    xpToolBar1.Office2007Theme = Office2007Theme.Silver;
                    toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
                    GroupBar1.Office2007Theme = Office2007Theme.Silver;
                    SetDefault();
                    break;
                case "Office2003":
                    this.dockingManager1.VisualStyle = VisualStyle.Office2003;
                    this.ColorScheme = Office2007Theme.Silver;
                    xpToolBar1.Office2007Theme = Office2007Theme.Silver;
                    toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
                    GroupBar1.Office2007Theme = Office2007Theme.Silver;
                    SetDefault();
                    break;
                case "VS2005":
                    this.dockingManager1.VisualStyle = VisualStyle.VS2005;
                    this.ColorScheme = Office2007Theme.Silver;
                    xpToolBar1.Office2007Theme = Office2007Theme.Silver;
                    GroupBar1.Office2007Theme = Office2007Theme.Silver;
                    toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
                    SetDefault();
                    break;
                case "Office2007":
                    this.dockingManager1.VisualStyle = VisualStyle.Office2007;
                    this.ColorScheme = Office2007Theme.Blue;
                    xpToolBar1.Office2007Theme = Office2007Theme.Blue;
                    toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
                    GroupBar1.Office2007Theme = Office2007Theme.Blue;
                    SetOffice2007();
                    break;
                case "Office2007Outlook":
                    this.dockingManager1.VisualStyle = VisualStyle.Office2007Outlook;
                    this.ColorScheme = Office2007Theme.Blue;
                    xpToolBar1.Office2007Theme = Office2007Theme.Blue;
                    toolStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
                    GroupBar1.Office2007Theme = Office2007Theme.Blue;
                    SetOffice2007Outlook();
                    break;
                default:
                    break;
            }

        }
        #endregion

        #region AddCaptionButtons
        Syncfusion.Windows.Forms.Tools.CaptionButton plus = new Syncfusion.Windows.Forms.Tools.CaptionButton();
        Syncfusion.Windows.Forms.Tools.CaptionButton minus = new Syncfusion.Windows.Forms.Tools.CaptionButton();
        Syncfusion.Windows.Forms.Tools.CaptionButton next = new Syncfusion.Windows.Forms.Tools.CaptionButton();
        Syncfusion.Windows.Forms.Tools.CaptionButton previous = new Syncfusion.Windows.Forms.Tools.CaptionButton();
        Syncfusion.Windows.Forms.Tools.CaptionButton helpShow = new Syncfusion.Windows.Forms.Tools.CaptionButton();
        Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo1 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
        Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo2 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
        Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo3 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
        Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo4 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
        Syncfusion.Windows.Forms.Tools.ToolTipInfo toolTipInfo5 = new Syncfusion.Windows.Forms.Tools.ToolTipInfo();
            
        private void AddCaptionButtons()
        {
#region CaptionButton for TreeViewAdv through code
            
              plus.ImageIndex = 7;  
              plus.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Custom; 
              plus.TransparentImageColor = System.Drawing.Color.Transparent;
              plus.Click += new CancelEventHandler(plus_Click);

              //Set tooltip
              toolTipInfo1.BackColor = Color.Bisque;
              toolTipInfo1.Header.Text = "Collapse nodes";
              toolTipInfo1.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
              // To assign the created tooltip to the caption button
              plus.SuperToolTipInfo=toolTipInfo1;

              minus.ImageIndex = 6;
              minus.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Custom;
              minus.TransparentImageColor = System.Drawing.Color.Transparent;
              minus.Click += new CancelEventHandler(minus_Click);

              Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection cbTreeview = new Syncfusion.Windows.Forms.Tools.CaptionButtonsCollection();
              cbTreeview.Add(plus);
              cbTreeview.Add(minus);

              this.dockingManager1.SetCustomCaptionButtons(this.treeViewAdv1, cbTreeview);
              //Set tooltip
              toolTipInfo2.BackColor = Color.Bisque;
              toolTipInfo2.Header.Text = "Expand nodes";
              toolTipInfo2.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
              // To assign the created tooltip to a the caption button
              minus.SuperToolTipInfo = toolTipInfo2;
#endregion

             #region CaptionButton for GroupBar through code
              
               next.ImageIndex = 5;
               next.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Custom;
               next.TransparentImageColor = System.Drawing.Color.Transparent;
               //Set tooltip
               toolTipInfo3.BackColor = Color.Bisque;
               toolTipInfo3.Header.Text = "View Next Item";
               toolTipInfo3.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // To assign the created tooltip to a the caption button
               next.SuperToolTipInfo = toolTipInfo3;
              
               previous.ImageIndex = 4;
               previous.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Custom;
               previous.TransparentImageColor = System.Drawing.Color.Transparent;
               CaptionButtonsCollection cbGroupBar1 = new CaptionButtonsCollection();
               cbGroupBar1.Add(next);    
               cbGroupBar1.Add(previous);
                
               this.dockingManager1.SetCustomCaptionButtons(this.GroupBar1, cbGroupBar1);
               //Set tooltip
               toolTipInfo4.BackColor = Color.Bisque;
               toolTipInfo4.Header.Text = "View Previous Item";
               toolTipInfo4.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // To assign the created tooltip to the caption button
               previous.SuperToolTipInfo = toolTipInfo4;
              #endregion

              #region CaptionButton for propertyGrid through code
               
               helpShow.ImageIndex = 9;
               helpShow.Type = Syncfusion.Windows.Forms.Tools.CaptionButtonType.Custom;
               helpShow.TransparentImageColor = System.Drawing.Color.Transparent;
               helpShow.Click += new CancelEventHandler(helpShow_Click);
               CaptionButtonsCollection cbProperty = new CaptionButtonsCollection();
               cbProperty.Add(helpShow);
               this.dockingManager1.SetCustomCaptionButtons(this.propertyGrid1, cbProperty);
               //Set tooltip
               toolTipInfo5.BackColor = Color.Bisque;
               if (this.propertyGrid1.HelpVisible)
               {
                   toolTipInfo5.Header.Text = "Hide help bar";
               }
               else
               {
                   toolTipInfo5.Header.Text = "Show help bar";
               }
               toolTipInfo5.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // To assign the created tooltip to a the caption button
               helpShow.SuperToolTipInfo = toolTipInfo5;
               #endregion

           }
         #endregion

        #region Caption Button Events

        private void minus_Click(object sender, CancelEventArgs e)
        {
            this.treeViewAdv1.ExpandAll();
        }

        private void plus_Click(object sender, CancelEventArgs e)
        {
            this.treeViewAdv1.CollapseAll();
        }
        private void helpShow_Click(object sender, CancelEventArgs e)
        {
            if(this.propertyGrid1.HelpVisible)
            {
                this.propertyGrid1.HelpVisible = false;
                toolTipInfo5.Header.Text = "Show help bar";
                helpShow.ImageIndex = 8;
            }
            
            else
            {
                this.propertyGrid1.HelpVisible = true;
                toolTipInfo5.Header.Text = "Hide help bar";
                helpShow.ImageIndex = 9;
            }
        }
        #endregion

        #region Helper Methods
        private void SetDefault()
        {
            if (this.dockingManager1.VisualStyle == VisualStyle.Default)
            {
                this.comboBoxBarItem1.ListBox.SelectedIndex = 0;
            }
            //this.BackColor = Color.White;
            this.GroupBar1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBarItem3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBarItem4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBarItem5.BackColor = System.Drawing.SystemColors.Control;
            this.propertyGrid1.BackColor = Color.White;
            this.propertyGrid1.LineColor = Color.White;
            this.label1.BackColor = Color.White;
            this.groupView1.BackColor=Color.White;
            this.groupView2.BackColor=Color.White;
            this.groupView3.BackColor=Color.White;
       }
        private void SetOffice2007()
        {
            this.dockingManager1.VisualStyle = VisualStyle.Office2007;
            this.BackColor = Color.FromArgb(241, 244, 254);
            this.GroupBar1.BackColor = Color.FromArgb(241, 244, 254);
            this.groupBarItem3.BackColor = Color.FromArgb(241, 244, 254);
            this.groupBarItem4.BackColor = Color.FromArgb(241, 244, 254);
            this.groupBarItem5.BackColor = Color.FromArgb(241, 244, 254);
            this.propertyGrid1.BackColor = Color.FromArgb(241, 244, 254);
            this.propertyGrid1.LineColor = Color.FromArgb(241, 244, 254);
            this.label1.BackColor = Color.FromArgb(241, 244, 254);
            this.groupView1.BackColor = Color.FromArgb(241, 244, 254);
            this.groupView2.BackColor = Color.FromArgb(241, 244, 254);
            this.groupView3.BackColor = Color.FromArgb(241, 244, 254);
        }

        private void SetOffice2007Outlook()
        {
            this.dockingManager1.VisualStyle = VisualStyle.Office2007Outlook;
            this.BackColor = Color.FromArgb(241, 244, 254);
            this.GroupBar1.BackColor = Color.FromArgb(241, 244, 254);
            this.groupBarItem3.BackColor = Color.FromArgb(241, 244, 254);
            this.groupBarItem4.BackColor = Color.FromArgb(241, 244, 254);
            this.groupBarItem5.BackColor = Color.FromArgb(241, 244, 254);
            this.propertyGrid1.BackColor = Color.FromArgb(241, 244, 254);
            this.propertyGrid1.LineColor = Color.FromArgb(241, 244, 254);
            this.label1.BackColor = Color.FromArgb(241, 244, 254);
            this.groupView1.BackColor = Color.FromArgb(241, 244, 254);
            this.groupView2.BackColor = Color.FromArgb(241, 244, 254);
            this.groupView3.BackColor = Color.FromArgb(241, 244, 254);
        }
        #endregion
      
        
        private void ShowCaptionClick(object sender, EventArgs e)
        {
            this.barItem1.Checked = !this.barItem1.Checked;
            this.dockingManager1.ShowCaption = this.barItem1.Checked;
        }

        private void ShowCaptionImageClick(object sender, EventArgs e)
        {
            this.barItem2.Checked = !this.barItem2.Checked;
            this.dockingManager1.ShowCaptionImages = this.barItem2.Checked;
        }

        private void EnableSuperToolTipClick(object sender, EventArgs e)
        {
            this.barItem3.Checked = !this.barItem3.Checked;
            this.dockingManager1.EnableSuperToolTip = this.barItem3.Checked;
        }
        private void ShowCaptionInFloating_Click(object sender, EventArgs e)
        {
            this.barItem4.Checked = !this.barItem4.Checked;
            this.dockingManager1.ShowCustomButtonsInFloating  = this.barItem4.Checked;
        }
        private void InActiveCaptionBackGround_ButtonClicked(object sender, EventArgs e)
        {
            if (this.dockingManager1.VisualStyle != VisualStyle.Default)
            {
                MessageBoxAdv.Show("You should set Visual Style to Default to change the backcolor.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    inactiveCaptionBack.ForeColor = colorDialog1.Color;
                    this.dockingManager1.InActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(colorDialog1.Color);
                    this.dockingManager1.VisualStyle = VisualStyle.Default;
                    SetDefault();                    
                }
            }
        }

        private void activeCaptionBack_Click(object sender, EventArgs e)
        {
            if (this.dockingManager1.VisualStyle != VisualStyle.Default)
            {
                MessageBoxAdv.Show("You should set Visual Style to Default to change the backcolor.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    activeCaptionBack.ForeColor = colorDialog1.Color;
                    this.dockingManager1.ActiveCaptionBackground = new Syncfusion.Drawing.BrushInfo(colorDialog1.Color);
                    this.dockingManager1.VisualStyle = VisualStyle.Default;
                    SetDefault();
                }
            }
        }

        private void inactiveCaptionFore_Click(object sender, EventArgs e)
        {
            if (this.dockingManager1.VisualStyle != VisualStyle.Default)
            {
                MessageBoxAdv.Show("You should set Visual Style to Default to change the forecolor.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    inactiveCaptionFore.ForeColor = colorDialog1.Color;
                    this.dockingManager1.InActiveCaptionForeGround = colorDialog1.Color;
                    this.dockingManager1.VisualStyle = VisualStyle.Default;
                    SetDefault();
                }
            }
        }

        private void activeCaptionFore_Click(object sender, EventArgs e)
        {
            if (this.dockingManager1.VisualStyle != VisualStyle.Default)
            {
                MessageBoxAdv.Show("You should set Visual Style to Default to change the forecolor.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    activeCaptionFore.ForeColor = colorDialog1.Color;
                    this.dockingManager1.ActiveCaptionForeGround = colorDialog1.Color;
                    this.dockingManager1.VisualStyle = VisualStyle.Default;
                    SetDefault();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBoxBarItem1.ListBox.SelectedIndex = 3;
            this.comboBoxBarItem1.TextBoxValue = comboBoxBarItem1.ListBox.SelectedItem.ToString();
        }

    }
}