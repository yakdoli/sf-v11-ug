using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.IO;
using Syncfusion.Windows.Forms.Tools.Navigation;

namespace NavigationViewDemo_2005 
{
    public partial class Form1 : Office2007Form 
    {
        public Form1() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            this.listView1.BringToFront();
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo driveInfo in drives)
            {
                if (driveInfo.DriveType != DriveType.Fixed) continue;
                Bar node = new Bar();
                node.Tag = driveInfo;
                node.Text = "Local Disk " + driveInfo.Name.Replace(@"\", "");
                node.ImageIndex = 8;
                navigationView1.SelectedBar.Bars.Add(node);
                this.listView1.Items.Add(node.Text, 8);
            }

            this.VisStyleCmbBox.SelectedIndex = 0;            
            this.navigationView1.HistoryManager = new Syncfusion.Windows.Forms.Tools.Navigation.HistoryManager();
            this.navigationView1.HistoryEnabled = true;
            this.navigationView1.Refresh();
        }
  
        private void HistorycheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.HisbtnChkBox.Enabled = HistorycheckBox.Checked;
            this.navigationView1.HistoryEnabled = HistorycheckBox.Checked;
                
            this.navigationView1.ShowHistoryButtons = HistorycheckBox.Checked;
            this.HisbtnChkBox.Checked = HistorycheckBox.Checked;
        }

        private void HisbtnChkBox_CheckedChanged(object sender, EventArgs e) 
        {
            this.navigationView1.ShowHistoryButtons = HisbtnChkBox.Checked;
        }

        private void CutmBtnChkBox_CheckedChanged(object sender, EventArgs e) 
        {
            this.navigationView1.CustomButtons[0].Visible = this.CutmBtnChkBox.Checked;
        }

        private void BarImgChkBox_CheckedChanged(object sender, EventArgs e) 
        {
            if (this.BarImgChkBox.Checked) 
              this.navigationView1.ImageList = this.imageList1;
            else 
              this.navigationView1.ImageList = null;
        }

        private void RTLChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (this.RTLChkBox.Checked)
                this.navigationView1.RightToLeft = RightToLeft.Yes;
            else
                this.navigationView1.RightToLeft = RightToLeft.No;
        }

        private void VisStyleCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.VisStyleCmbBox.SelectedIndex == 0) 
                this.navigationView1.VisualStyle = Syncfusion.Windows.Forms.Tools.Navigation.VisualStyles.Vista;
            else
            {
                this.navigationView1.VisualStyle = Syncfusion.Windows.Forms.Tools.Navigation.VisualStyles.Office2007;
                this.navigationView1.Office2007ColorTheme = Office2007Theme.Blue;
                this.customButton1.Office2007ColorScheme = Office2007Theme.Blue;
            }
        }

        private void navigationView1_BarSelectionChanging(object sender, Syncfusion.Windows.Forms.Tools.Navigation.BarSelectionChangingEventArgs e)
        {
            this.listView1.Items.Clear();
            bool needToAdd = true;
            Syncfusion.Windows.Forms.Tools.Navigation.Bar parent = e.Bar;
            if (parent == null) return;
            if (parent.Bars.Count > 0)
            {
                needToAdd = false;
            }           
            DirectoryInfo dirInfo = null;
            if (parent.Tag is DriveInfo)
            {
                DriveInfo driveInfo = (DriveInfo)parent.Tag;
                dirInfo = driveInfo.RootDirectory;

            }
            else if (parent.Tag is DirectoryInfo)
            {
                dirInfo = (DirectoryInfo)parent.Tag;
            }
            if (dirInfo != null)
            {
                try
                {
                    DirectoryInfo[] subDirectories = dirInfo.GetDirectories();
                    FileInfo[] files = dirInfo.GetFiles();
                    foreach (DirectoryInfo directoryInfo in subDirectories)
                    {
                        Syncfusion.Windows.Forms.Tools.Navigation.Bar node = new Syncfusion.Windows.Forms.Tools.Navigation.Bar();
                        node.Tag = directoryInfo;
                        node.Text = directoryInfo.Name;
                        node.ImageIndex = 8;
                        if (needToAdd)
                        parent.Bars.Add(node);
                        this.listView1.Items.Add(node.Text, 8);
                    }
                    foreach (FileInfo file in files)
                    {
                        this.listView1.Items.Add(file.Name, 5);
                    }
                }
                catch (Exception ex)
                {
                    MessageBoxAdv.Show(this, ex.Message, "Info");
                }
            }
            else if (parent.Text == "MyComputer")
            {                
                this.listView1.Items.Add("Local Disk(C:)", 8);
            }
        }
    }
}