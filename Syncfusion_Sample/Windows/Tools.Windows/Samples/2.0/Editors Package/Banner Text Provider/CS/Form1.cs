using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;

namespace BannerTextDemo_2005
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
            Application.Idle += new EventHandler(Application_Idle);
        }

        void Application_Idle(object sender, EventArgs e)
        {
            ApplySelectedFont(this.comboBoxBarItem1.TextBoxValue.ToString(), this.comboBoxBarItem2.TextBoxValue.ToString());
        }

        private void ApplySelectedFont(string fontname, string fontsize)
        {
            float size = 8f;
            if (fontsize == "Small")
                size = 8f;
            else if (fontsize == "Medium")
                size = 12f;
            else if (fontsize == "Large")
                size = 16f;

            Font myFont = new Font(fontname, size, FontStyle.Regular);
            foreach (Control c in groupBox1.Controls)
            {
                if (c is Label)
                    continue;
                c.Font = new Font(fontname, size, FontStyle.Regular);
            }
            foreach (Control c in groupBox2.Controls)
            {
                if (c is Label)
                    continue;
                c.Font = new Font(fontname, size, FontStyle.Regular);
            }
        }
    }
}