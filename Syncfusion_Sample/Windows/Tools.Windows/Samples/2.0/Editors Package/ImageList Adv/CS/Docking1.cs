using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ImageListAdv_Demo
{
    public partial class Docking1 : UserControl
    {
        public Docking1()
        {
            InitializeComponent();
            ImageList imgList = this.imageListAdv1.ToImageList();
            imgList.ColorDepth = ColorDepth.Depth32Bit;
            this.dockingManager1.ImageList = imgList;
        
        }
    }
}
