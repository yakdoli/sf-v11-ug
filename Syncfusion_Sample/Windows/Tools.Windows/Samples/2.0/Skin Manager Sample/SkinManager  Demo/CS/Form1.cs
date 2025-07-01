using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace SkinManagerDemo_2008
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
                  
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Changed();
        }
        Control ctrl = null;
        bool Clicked = false;
        public void Changed()
        {
           
            if (comboBox1.Text == "Form")
            {
                ctrl = this;
                apply();
            }
            else if (comboBox1.Text == "DockingManager")
            {
                ctrl = this.groupBar1;
                if (comboBox2.Text == "Office 2007 Blue")
                {
                    this.dockingManager1.VisualStyle = VisualStyle.Office2007;
                    this.dockingManager1.Office2007Theme = Office2007Theme.Blue;
                }
                if (comboBox2.Text == "Office 2007 Black")
                {
                    this.dockingManager1.VisualStyle = VisualStyle.Office2007;
                    this.dockingManager1.Office2007Theme = Office2007Theme.Black ;
                }
                if (comboBox2.Text == "Office 2007 Silver")
                {
                    this.dockingManager1.VisualStyle = VisualStyle.Office2007;
                    this.dockingManager1.Office2007Theme = Office2007Theme.Silver ;
                }
                if (comboBox2.Text == "Managed")
                {
                    this.dockingManager1.VisualStyle = VisualStyle.Office2007;
                    this.dockingManager1.Office2007Theme = Office2007Theme.Managed ;
                }
                apply();
            }
            else if (comboBox1.Text == "Calculator")
            {
                ctrl = this.calculatorControl1 ;
                apply();
            }
            else if (comboBox1.Text == "Button")
            {
                 apply();
            }
            else if (comboBox1.Text == "GroupBar")
            {
                ctrl = this.groupBar1 ;
                apply();
            }


        


        }

        public void apply()
        {
             if (comboBox2.Text == "Office 2007 Blue")
            {
                SkinManager.SetVisualStyle(ctrl, VisualTheme.Office2007Blue);
                Clicked = false;
                 if(ctrl == this)
                this.BackColor = Color.LightBlue;
            }
            if (comboBox2.Text == "Office 2007 Black")
            {
                SkinManager.SetVisualStyle(ctrl , VisualTheme.Office2007Black);
                Clicked = false;
                if (ctrl == this)
                this.BackColor = Color.Gray;
            }
            if (comboBox2.Text == "Office 2007 Silver")
            {
                SkinManager.SetVisualStyle(ctrl, VisualTheme.Office2007Silver);
                Clicked = false;
                if (ctrl == this)
                this.BackColor = Color.LightGray;
            }
            if (comboBox2.Text == "Managed")
            {   
                SkinManager.SetVisualStyle(ctrl, VisualTheme.Managed);
                Clicked = true;
                comboBox1.Items.Add("Form");
            }
        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            SkinManager.SetVisualStyle(this, VisualTheme.Office2007Blue);
            Changed();
        }

        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            SkinManager.SetVisualStyle(this, VisualTheme.Office2007Blue);
            if (this.comboBox2.Text != "Managed")
                this.autoLabel1 .Visible = false;
            else
                this.autoLabel1 .Visible = true;
            Changed();
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            SkinManager.SetVisualStyle(this, VisualTheme.Office2007Blue);
               
        }

        private void colorPickerUIAdv1_Picked(object sender, Syncfusion.Windows.Forms.Tools.ColorPickerUIAdv.ColorPickedEventArgs args)
        {
            if (Clicked)
            {
                Office12ColorTable.ApplyManagedColors(this, this.colorPickerUIAdv1.SelectedColor);
               // this.BackColor = this.colorPickerUIAdv1.SelectedColor;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void autoLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
