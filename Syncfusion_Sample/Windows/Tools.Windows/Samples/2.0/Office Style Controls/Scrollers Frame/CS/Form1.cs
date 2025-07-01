#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
#region file using directives
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Tools.XPMenus;
#endregion

namespace ScrollersFrame_2005
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            InitializeComponent();

            treeView3.ExpandAll();
            
            // Add controls to the scrollers here.
            this.scrollersFrame2.HorizontalScroller.ControlsBefore.Add(buttonAdv3);
            this.scrollersFrame2.VerticalScroller.ControlsAfter.Add(buttonAdv1);
            this.scrollersFrame2.VerticalScroller.ControlsAfter.Add(buttonAdv2);                        
        }
        
        #region Office 2007 Themes
        private void barItem_Click(object sender, EventArgs e)
        {
            BarItem bitem = (BarItem)sender;
            UnCheckAll();

            switch(bitem.Text)
            {
                case "Blue":
                    barItem7.Checked = true;
                    this.ColorScheme = Office2007Theme.Blue;
                    this.scrollersFrame2.OfficeColorScheme = Office2007ColorScheme.Blue;
                    this.mainFrameBarManager1.Office2007Theme = Office2007Theme.Blue;
                    this.BackColor = Color.FromArgb(246, 249, 254);
                    this.buttonAdv1.Office2007ColorScheme = Office2007Theme.Blue;
                    this.buttonAdv2.Office2007ColorScheme = Office2007Theme.Blue;
                    this.buttonAdv3.Office2007ColorScheme = Office2007Theme.Blue;
                    this.gradientPanel1.BorderColor = Color.FromArgb(222, 231, 246);
                    break;
                case "Silver":
                    barItem8.Checked = true;
                    this.ColorScheme = Office2007Theme.Silver;
                    this.scrollersFrame2.OfficeColorScheme = Office2007ColorScheme.Silver;
                    this.mainFrameBarManager1.Office2007Theme = Office2007Theme.Silver;
                    this.BackColor = Color.FromArgb(202, 207, 217);
                    this.buttonAdv1.Office2007ColorScheme = Office2007Theme.Silver;
                    this.buttonAdv2.Office2007ColorScheme = Office2007Theme.Silver;
                    this.buttonAdv3.Office2007ColorScheme = Office2007Theme.Silver;
                    this.gradientPanel1.BorderColor = Color.Gray;
                    break;
                case "Black":                   
                    barItem9.Checked = true;
                    this.ColorScheme = Office2007Theme.Black;
                    this.scrollersFrame2.OfficeColorScheme = Office2007ColorScheme.Black;
                    this.mainFrameBarManager1.Office2007Theme = Office2007Theme.Black;
                    this.BackColor = Color.FromArgb(113, 113, 113);
                    this.buttonAdv1.Office2007ColorScheme = Office2007Theme.Black;
                    this.buttonAdv2.Office2007ColorScheme = Office2007Theme.Black;
                    this.buttonAdv3.Office2007ColorScheme = Office2007Theme.Black;
                    this.gradientPanel1.BorderColor = Color.LightGray;
                    break;
            }
        }
        #endregion
      
        private void UnCheckAll()
        {
            this.barItem7.Checked = false;
            this.barItem8.Checked = false;
            this.barItem9.Checked = false;
        }

        private void buttonAdv3_Click(object sender, EventArgs e)
        {
            treeView3.CollapseAll();
        }

    }
}