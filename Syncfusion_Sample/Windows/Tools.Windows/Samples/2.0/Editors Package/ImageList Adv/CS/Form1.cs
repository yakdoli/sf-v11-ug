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

namespace ImageListAdv_Demo
{   
    
    //Control that have a image property to directly associate 
    //image can use the ImageListeAdv's image property.
    //For controls that have to be associated with a imageList
    //the imageListAdv should be converted to imageList via the 
    //ImageListAdv.ToImageList method.
    public partial class Form1 : Office2007Form
    {
        #region Form's Constructor
        public Form1()
        {
            InitializeComponent();
            foreach (TabPageAdv tabPage in this.tabControlAdv3.TabPages)
            {
                tabPage.Hide();
            }
            this.tabPageAdv12.Show();
            this.treeViewAdv1.SelectedNode = this.treeViewAdv1.Nodes[0].Nodes[0];
            this.treeViewAdv1.Nodes[0].Nodes[0].BaseStyle = "Style1";
        }
        #endregion

        #region Form_Load
        ImageList imgList = new ImageList();
        private void Form1_Load(object sender, EventArgs e)
        {
            //Converting ImageListAdv to ImageList
            imgList = this.imageListAdv1.ToImageList();
            imgList.ColorDepth = ColorDepth.Depth32Bit;

            #region Assigning images to controls with direct image property.
            
            //BarItem Images through ImageListAdv
            this.barItem1.Image = (ImageExt)this.imageListAdv1.Images[0];
            this.barItem2.Image = (ImageExt)this.imageListAdv1.Images[1];
            this.barItem3.Image = (ImageExt)this.imageListAdv1.Images[2];
            this.barItem4.Image = (ImageExt)this.imageListAdv1.Images[17];
            this.barItem5.Image = (ImageExt)this.imageListAdv1.Images[18];
            this.barItem6.Image = (ImageExt)this.imageListAdv1.Images[19];

            //BarItem Images through ImageList
            this.barItem7.Image = (ImageExt)this.imageList1.Images[0];
            this.barItem8.Image = (ImageExt)this.imageList1.Images[1];
            this.barItem9.Image = (ImageExt)this.imageList1.Images[2];
            this.barItem10.Image = (ImageExt)this.imageList1.Images[17];
            this.barItem11.Image = (ImageExt)this.imageList1.Images[18];
            this.barItem12.Image = (ImageExt)this.imageList1.Images[19];
          
            
            //GroupBarItem Images through ImageListAdv
            this.groupBarItem1.Image = this.imageListAdv1.Images[23];
            this.groupBarItem3.Image = this.imageListAdv1.Images[24];

            //GroupBarItem Images through ImageList
            this.groupBarItem5.Image = this.imageList1.Images[23];
            this.groupBarItem6.Image = this.imageList1.Images[24];
             
            this.xpToolBar1.Size = new Size(150, 25);
            this.xpToolBar2.Size = new Size(150, 25);
            this.pictureBox1.Image = this.imageListAdv1.Images[16];
            this.pictureBox2.Image = this.imageList1.Images[16];
        #endregion

            #region Assigning images to controls with ImageList property.

            //TreeViewAdv Images through ImageListAdv
            this.treeViewAdv2.NodeStateImageList = imgList;
            this.treeViewAdv2.LeftImageList = imgList;
            this.treeViewAdv2.Nodes[0].LeftImageIndices = new int[] { 30 };
            this.treeViewAdv2.Nodes[0].Nodes[0].LeftImageIndices = new int[] { 27 };
            this.treeViewAdv2.Nodes[0].Nodes[1].LeftImageIndices = new int[] { 28 };
            this.treeViewAdv2.Nodes[0].Nodes[2].LeftImageIndices = new int[] { 29 };
          
            //TreeViewAdv Images through ImageList
            this.treeViewAdv3.NodeStateImageList = this.imageList1;
            this.treeViewAdv3.LeftImageList = this.imageList1;
            this.treeViewAdv3.Nodes[0].LeftImageIndices = new int[] { 30 };
            this.treeViewAdv3.Nodes[0].Nodes[0].LeftImageIndices = new int[] { 27 };
            this.treeViewAdv3.Nodes[0].Nodes[1].LeftImageIndices = new int[] { 28 };
            this.treeViewAdv3.Nodes[0].Nodes[2].LeftImageIndices = new int[] { 29 };

            //TabControlAdv Images through ImageListAdv
            this.tabControlAdv1.ImageList = imgList;
            this.tabPageAdv1.ImageIndex = 12;
            this.tabPageAdv2.ImageIndex = 13;
            this.tabPageAdv5.ImageIndex = 14;
            //TabControlAdv Images through ImageList
            this.tabControlAdv2.ImageList = this.imageList1;
            this.tabPageAdv3.ImageIndex = 12;
            this.tabPageAdv4.ImageIndex = 13;
            this.tabPageAdv6.ImageIndex = 14;
#endregion

          }
        #endregion

        #region TabPage Visibility
        private void treeViewAdv1_Click(object sender, EventArgs e)
        {
            this.treeViewAdv1.Nodes[0].Nodes[0].BaseStyle = "Style2";
            foreach (TabPageAdv tabPage in this.tabControlAdv3.TabPages)
            {
                tabPage.Hide();
            } 
            switch (this.treeViewAdv1.SelectedNode.Text)
            {
                case "Controls":
                    this.tabPageAdv12.Show();
                    break;
                case "DockingManager":
                    this.tabPageAdv12.Show();
                    break;
                case "GroupBar":
                    this.tabPageAdv9.Show();
                    break;
                case "TabControlAdv":
                    this.tabPageAdv10.Show();
                    break;
                case "TreeViewAdv":
                    this.tabPageAdv8.Show();
                    break;
                case "XPMenus":
                    this.tabPageAdv11.Show();
                    break;
                case "Image Size":
                    this.tabPageAdv13.Show();
                    break;
             }
        }
        #endregion

        #region Image Size
        private void trackBarEx1_ValueChanged(object sender, EventArgs e)
        {
            int  value = this.trackBarEx1.Value;
            this.pictureBox1.Size = new Size(value, value);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void trackBarEx2_ValueChanged(object sender, EventArgs e)
        {
            int value = this.trackBarEx2.Value;
            this.pictureBox2.Size = new Size(value, value);
            this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
         }
        #endregion

    }
}