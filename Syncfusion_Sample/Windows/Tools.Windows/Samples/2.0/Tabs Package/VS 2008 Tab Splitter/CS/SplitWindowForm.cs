using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace TabSplitterContainer_2005
{
    public partial class SplitWindowForm : Form
    {
        private string basePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\..\..\Resources\";
        public SplitWindowForm()
        {
            InitializeComponent();
        }

        public SplitWindowForm(string title, string filename)
            : this()
        {
            this.Text = title;
            this.richTextBox1.LoadFile(basePath + filename);
        }

        public Image DesignWindow
        {
            get
            {
                return this.pictureBox1.Image;
            }
            set
            {
                this.pictureBox1.Image = value;
            }
        }

        public TabSplitterContainer SplitView
        {
            get {
                return this.tabSplitterContainer1;
            }
        }
    }
}