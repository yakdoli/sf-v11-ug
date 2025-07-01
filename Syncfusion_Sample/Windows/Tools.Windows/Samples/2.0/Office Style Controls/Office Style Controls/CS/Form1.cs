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
using Syncfusion.Windows.Forms.Tools.XPMenus;

namespace Office2007Controls
{
    public partial class Form1 : Office2007Form
    {

        #region Form's Constructor
        public Form1()
        {
            InitializeComponent();
            
            this.comboBox1.SelectedIndex = 0;
            this.comboBox4.SelectedIndex = 0;

            this.buttonEdit1.BackColor = Color.FromArgb(115, 150, 198);
            this.buttonEdit2.BackColor = Color.FromArgb(159, 191, 239);
            this.buttonEdit3.BackColor = Color.FromArgb(198, 222, 254);

            this.trackBarItem1.TrackBarExControl.Scroll += new EventHandler(TrackBarExControl_Scroll);
            this.statusStripEx1.Items["Progress"].Text = "Progress Bar";

            this.statusStripLabel1.Text = "Page:" + this.statusStripLabel1.StatusString;
            this.statusStripLabel2.Text = "Words: 1";

            this.statusStripEx1.ContextMenuStrip.Opening += new CancelEventHandler(ContextMenuStrip_Opening);
        }

        void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            statusStripEx1.ContextMenuStrip.Items[0].Text = "Page";
            statusStripEx1.ContextMenuStrip.Items[1].Text = "Words";  
        }

        void TrackBarExControl_Scroll(object sender, EventArgs e)
        {
            this.statusLabel.Text = this.trackBarItem1.Value.ToString() + "%";
        }
#endregion

        #region StatusStripEx

        #region Office2007ColorScheme
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedIndex == 0)
                this.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Blue;
            if (this.comboBox1.SelectedIndex == 1)
                this.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Silver;
            if (this.comboBox1.SelectedIndex == 2)
                this.statusStripEx1.OfficeColorScheme = ToolStripEx.ColorScheme.Black;

        }        
        #endregion

        #region sizing Grip
        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv2.Checked)
            {
                this.statusStripEx1.SizingGrip = true;
                this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            }
            else
            {
                this.statusStripEx1.SizingGrip = false;
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            }

        }        
#endregion

        #region RightToLeft
        private void checkBoxAdv3_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv3.Checked)
            {
                this.statusStripEx1.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                this.statusStripEx1.RightToLeft = RightToLeft.No;
            }
        }
        #endregion

        
#endregion
            
        #region TrackBarEx

        #region TrackBarColor
        private void buttonEdit1_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
               this.buttonEdit1.BackColor = colorDialog1.Color;
               this.trackBarEx1.TrackBarGradientStart = colorDialog1.Color;
            }
        }

        private void buttonEdit3_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.buttonEdit3.BackColor = colorDialog1.Color;
                this.trackBarEx1.TrackBarGradientEnd = colorDialog1.Color;
            }
        }
        #endregion

        #region ButtonColor
        private void buttonEdit2_ButtonClicked(object sender, ButtonClickedEventArgs args)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.buttonEdit2.BackColor = colorDialog1.Color;
                this.trackBarEx1.ButtonColor = colorDialog1.Color;
            }
        }
        #endregion

        #region ShowButtons
        private void checkBoxAdv4_CheckStateChanged(object sender, EventArgs e)
        {
            this.trackBarEx1.ShowButtons = this.checkBoxAdv4.Checked;
        }
        #endregion
        
        #region ButtonSize

        private void numericUpDownExt1_ValueChanged(object sender, EventArgs e)
        {
            this.trackBarEx1.DecreaseButtonSize = new Size(Convert.ToInt16(this.numericUpDownExt1.Value),Convert.ToInt16(this.numericUpDownExt1.Value));
        }

        private void numericUpDownExt2_ValueChanged(object sender, EventArgs e)
        {
            this.trackBarEx1.IncreaseButtonSize = new Size(Convert.ToInt16(this.numericUpDownExt2.Value), Convert.ToInt16(this.numericUpDownExt2.Value));
        }
#endregion
        
        #region TrackBarEx Right to left
        private void checkBoxAdv5_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv5.Checked)
            {
                this.trackBarEx1.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                this.trackBarEx1.RightToLeft = RightToLeft.No;
            }
        }
        #endregion

        

        private void trackBarEx1_Scroll(object sender, EventArgs e)
        {
            this.textBox1.Text = this.trackBarEx1.Value.ToString();
        }

        #endregion

        #region ContextMenuStripEx
        #region ContextMenuStripEx_RightToLeft
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {   if (this.checkBoxAdv1.Checked)
            {
                this.contextMenuStripEx1.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                this.contextMenuStripEx1.RightToLeft = RightToLeft.No;
            }
     }
        #endregion

        #region Header
     private void textBoxExt1_TextChanged(object sender, EventArgs e)
        {
            this.contextMenuStripEx1.Text = this.textBoxExt1.Text;
        }
     #endregion

        #region Office2007Color
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.comboBox4.SelectedIndex == 0)
            {
                if (this.textBoxExt1.Text ==String.Empty)
                {
                    this.contextMenuStripEx1.Text = "Blue";
                }
                this.contextMenuStripEx1.Renderer = new Office12ToolStripRenderer(new OfficeBlue());
            }
            if (this.comboBox4.SelectedIndex == 1)
            {
                if (this.textBoxExt1.Text == String.Empty)
                {
                    this.contextMenuStripEx1.Text = "Black";
                }
                this.contextMenuStripEx1.Renderer = new Office12ToolStripRenderer(new OfficeBlack());
            }
            if (this.comboBox4.SelectedIndex == 2)
            {
                if (this.textBoxExt1.Text == String.Empty)
                {
                    this.contextMenuStripEx1.Text = "Silver";
                }
                this.contextMenuStripEx1.Renderer = new Office12ToolStripRenderer(new Office12ColorTable());
            }
        }
        #endregion

        #region  DropShadow
          
private void checkBoxAdv6_CheckStateChanged(object sender, EventArgs e)
        {
            this.contextMenuStripEx1.DropShadowEnabled = this.checkBoxAdv6.Checked;
        }
        #endregion       
       
        #endregion

    }
}