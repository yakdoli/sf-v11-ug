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

namespace Office2007Form_2005
{
    public partial class MainForm : Office2007Form
    {
        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            this.checkBoxAdv3.Checked = true;
            
            foreach (String str in Enum.GetNames(typeof(FontStyle)))
                this.comboBox3.Items.Add(str);

            this.comboBox3.SelectedIndex = 1;
            this.comboBox1.SelectedIndex = 0;
            this.colorPickerButton1.SelectedColor = Color.Green;
            this.CaptionForeColor = this.colorPickerButton1.SelectedColor;
            this.colorPickerButton1.SelectedAsText = true;
        }
        #endregion

        #region Themes
        private void radioButtonAdv1_CheckChanged(object sender, EventArgs e)
        {
            this.ColorScheme = Office2007Theme.Blue;
            this.BackColor = Color.FromArgb(241, 244, 254);          
            
        }

        private void radioButtonAdv2_CheckChanged(object sender, EventArgs e)
        {
            this.ColorScheme = Office2007Theme.Silver;
            this.BackColor = Color.FromArgb(202, 207, 217);
       }

        private void radioButtonAdv3_CheckChanged(object sender, EventArgs e)
        {
            this.ColorScheme = Office2007Theme.Black;
            this.BackColor = Color.FromArgb(113, 113, 113);
             }
        #endregion

        #region Help Button
        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv1.Checked)
            {
                this.MaximizeBox = false;
                this.MinimizeBox = false;
            }
            else
            {
                this.MaximizeBox = false;
                
                this.MinimizeBox = true;
            }

        }
        #endregion 

        #region RightToLeft

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv2.Checked)
            {
                this.RightToLeft = RightToLeft.Yes;
            }
            else
            {
                this.RightToLeft = RightToLeft.No;
            }
        }
        #endregion

        #region Show Icon
        private void checkBoxAdv3_CheckStateChanged(object sender, EventArgs e)
        {
            if (this.checkBoxAdv3.Checked)
            {
                this.ShowIcon = true;
            }
            else
            {
                this.ShowIcon = false;
            }
        }
        #endregion

        #region Caption settings
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    this.CaptionAlign = HorizontalAlignment.Left;
                    break;
                case 1:
                    this.CaptionAlign = HorizontalAlignment.Center;
                    break;
                case 2:
                    this.CaptionAlign = HorizontalAlignment.Right;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCaptionFont();
        }

        protected void SetCaptionFont()
        {
            FontStyle fs = (FontStyle)Enum.Parse(typeof(FontStyle), this.comboBox3.SelectedItem.ToString(), true);
            this.CaptionFont = new Font(this.comboBox2.SelectedItem.ToString(), (int)this.numericUpDown1.Value, fs);
        
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            SetCaptionFont();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetCaptionFont();
        }

        private void colorPickerButton1_ColorSelected(object sender, EventArgs e)
        {
            this.CaptionForeColor = this.colorPickerButton1.SelectedColor;
        }
        #endregion
        
    }
}