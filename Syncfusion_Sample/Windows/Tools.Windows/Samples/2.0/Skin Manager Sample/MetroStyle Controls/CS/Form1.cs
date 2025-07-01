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

namespace MetroStyleControls_2008
{
    public partial class Form1 : MetroForm
    {

        TrackBarEx trackBar = new TrackBarEx();
        public Form1()
        {
            InitializeComponent();

            trackBar.Location = new Point(180, 210);
            this.trackBar.Size = new Size(150, 100);
            trackBar.Style = TrackBarEx.Theme.Metro;
            this.Controls.Add(trackBar);
            trackBar.ValueChanged += new EventHandler(trackBar_ValueChanged);
            trackBar.Value = 1;
            this.radioButtonAdv8.Checked = true;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.radioButtonAdv1.MetroColor = Color.Black;
            this.radioButtonAdv2.MetroColor = Color.Black;
            this.radioButtonAdv3.MetroColor = Color.Black;
            this.radioButtonAdv4.MetroColor = Color.Black;
            this.radioButtonAdv5.MetroColor = Color.Black;
            this.radioButtonAdv6.MetroColor = Color.Black;
            this.radioButtonAdv7.MetroColor = Color.Black;
            this.radioButtonAdv8.MetroColor = Color.Black;
            this.checkBoxAdv1.MetroColor = Color.Black;



            
        }

        void trackBar_ValueChanged(object sender, EventArgs e)
        {
            this.BorderThickness = trackBar.Value;
        }

        private void label31_Click(object sender, EventArgs e)
        {
            if(this.radioButtonAdv1.Checked )
            this.MetroColor = (sender as Label).BackColor;
            if (this.radioButtonAdv2.Checked)
                this.CaptionBarColor = (sender as Label).BackColor;
            if (this.radioButtonAdv3.Checked)
                this.BorderColor = (sender as Label).BackColor;
            if (this.radioButtonAdv4.Checked)
                this.CaptionButtonColor = (sender as Label).BackColor;
            if (this.radioButtonAdv5.Checked)
                this.CaptionForeColor = (sender as Label).BackColor;

        }

        private void label31_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label31_MouseEnter(object sender, EventArgs e)
        {
            //(sender as Label).Left -= 1;
            //(sender as Label).Top -= 1;
            //(sender as Label).Width += 4;
            //(sender as Label).Height += 4;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void radioButtonAdv6_CheckChanged(object sender, EventArgs e)
        {
  
                if(this.radioButtonAdv6.Checked)
                this.CaptionAlign = HorizontalAlignment.Left;
                if (this.radioButtonAdv7.Checked)
                    this.CaptionAlign = HorizontalAlignment.Center;
                if (this.radioButtonAdv8.Checked)
                    this.CaptionAlign = HorizontalAlignment.Right;
            
        }

        private void showForm()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            MetroForm form = new MetroForm();
            
            form.DropShadow = this.checkBoxAdv1.Checked;
            if(this.checkBoxAdv1.Checked )
                form.Text = "MetroForm with shadow";
            else
                form.Text = "MetroForm without shadow";
            form.Show();
            Point point = new Point(this.Left + this.panel3.Left + 15, this.Top + panel3.Top + 55);
            form.Location = point;
            form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Size size = new Size(this.panel3.Width - 20, this.panel3.Height - 40);

            form.Size = size;
            
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            showForm();

        }

        private void label28_Click(object sender, EventArgs e)
        {
            showForm();
        }

        private void radioButtonAdv1_CheckChanged(object sender, EventArgs e)
        {

        }

        private void label31_MouseLeave(object sender, EventArgs e)
        {
            //(sender as Label).Left += 1;
            //(sender as Label).Top += 1;
            //(sender as Label).Width -= 4;
            //(sender as Label).Height -= 4;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {


        }

        private void Form1_Move(object sender, EventArgs e)
        {
           
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
         //   this.FormBorderStyle = FormBorderStyle.Sizable;
        }


        
    }
}
