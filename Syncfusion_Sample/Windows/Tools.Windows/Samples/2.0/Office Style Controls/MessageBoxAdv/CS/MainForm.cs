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

namespace MessageBoxAdv_2005
{
    public partial class MainForm : Office2007Form
    {
        #region Constructor
        public MainForm()
        {
            InitializeComponent();
            this.comboBoxAdv2.SelectedIndex = 0;
           
            this.comboBoxAdv1.SelectedIndex = 0;



        }
        #endregion

        #region Events


        #region Color Schemes
        private void radioButtonAdv1_CheckChanged(object sender, EventArgs e)
        {
            MessageBoxAdv.Office2007Theme = Office2007Theme.Blue;
        }
        private void radioButtonAdv2_CheckChanged(object sender, EventArgs e)
        {
            MessageBoxAdv.Office2007Theme = Office2007Theme.Silver;
        }
        private void radioButtonAdv3_CheckChanged(object sender, EventArgs e)
        {
            MessageBoxAdv.Office2007Theme = Office2007Theme.Black;
        }
        private void radioButtonAdv4_CheckChanged(object sender, EventArgs e)
        {
            MessageBoxAdv.Office2007Theme = Office2007Theme.Managed;
            Office2007Colors.ApplyManagedColors(this, messageBoxColor);
            this.ColorScheme = Office2007Theme.Blue;
        }
        #endregion


        #region Custom Color Schemes

        Color messageBoxColor;

        private void colorPickerUIAdv1_Picked(object sender, Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            messageBoxColor = args.Color;
            if (this.radioButtonAdv4.Checked)
            {
                MessageBoxAdv.Office2007Theme = Office2007Theme.Managed;
                Office2007Colors.ApplyManagedColors(this, messageBoxColor);
            }

            this.ColorScheme = Office2007Theme.Blue;
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, new System.Drawing.Color[] {
                Color.WhiteSmoke, messageBoxColor ,messageBoxColor, Color.WhiteSmoke});
            // Ensures that the PopupControlContainer is closed after the selection of a color.
            ColorPickerUIAdv cc = sender as ColorPickerUIAdv;
            Syncfusion.Windows.Forms.PopupControlContainer pcc = cc.Parent as Syncfusion.Windows.Forms.PopupControlContainer;
            pcc.HidePopup(Syncfusion.Windows.Forms.PopupCloseType.Done);
            this.popupControlContainer1.Size = this.colorPickerUIAdv1.Size;
        }



        private void buttonAdv2_MouseUp(object sender, MouseEventArgs e)
        {
            this.popupControlContainer1.ShowPopup(Point.Empty);
        }
        #endregion

        #region Show MessageBoxAdv
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            if (this.comboBoxAdv1.Enabled)
            {
                MessageBoxAdv.Show("Message BoxAdv with Default Icon", "Message BoxAdv " , MessageBoxButtons.OK, (MessageBoxIcon)Enum.Parse(typeof(MessageBoxIcon), this.comboBoxAdv1.SelectedItem.ToString(), true));
            }
            else
            {
                switch (this.comboBoxAdv2.SelectedIndex)
                {
                    case 0:
                        MessageBoxAdv.Show("Please view Online UG for futher reference", "Message BoxAdv " + MessageBoxAdv.Office2007Theme.ToString() + "Color Scheme", MessageBoxButtons.OK, this.imageListAdv1.Images[0], new Size(24, 24));
                        break;
                    case 1:
                        MessageBoxAdv.Show("Document Error. File format not supported", "Message BoxAdv " + MessageBoxAdv.Office2007Theme.ToString() + "Color Scheme", MessageBoxButtons.OK, this.imageListAdv1.Images[1], new Size(24, 24));
                        break;
                    case 2:
                        MessageBoxAdv.Show("Warning. This operation is not supported", "Message BoxAdv " + MessageBoxAdv.Office2007Theme.ToString() + "Color Scheme", MessageBoxButtons.OK, this.imageListAdv1.Images[2], new Size(24, 24));

                        break;
                    case 3:
                        MessageBoxAdv.Show("Message BoxAdv supports Custom Colors and custom images", "Message BoxAdv " + MessageBoxAdv.Office2007Theme.ToString() + "Color Scheme", MessageBoxButtons.OK);
                        break;
                }
            }
        }
        #endregion


        private void radioButtonAdv5_CheckChanged(object sender, EventArgs e)
        {
            this.comboBoxAdv1.Enabled = radioButtonAdv5.Checked;
            this.comboBoxAdv2.Enabled = !radioButtonAdv5.Checked;
        }
        #endregion
    }
}