using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Design;
using Syncfusion.Collections;
using Syncfusion.ComponentModel;
using System.Drawing.Design;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Reflection;
using Syncfusion.Runtime.Serialization;

using Syncfusion.Windows.Forms.Grid;

using Syncfusion.Windows.Forms.Tools;

namespace ExcelLikeUI_2005
{
    public partial class Form1 : RibbonForm
    {
        private static int accCount = 1;
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (workBook != null)
                workBook.tabBarSplitterControl.Controls[1].Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            QuickItems();
            this.toolStripFontfaceComboBox.SelectedIndex = 0;
            this.toolStripFontSizeComboBox.SelectedIndex = 3;

            // Create a new child
            WorkBook workBook = new WorkBook();
            workBook.MdiParent = this;
            workBook.Text = "WorkBook " + childWorkBookNumber++;
            workBook.Show();

            excelRibbon.Header.QuickItemAdded += new ToolStripItemEventHandler(Header_QuickItemAdded);
            excelRibbon.Header.QuickItemRemoved += new ToolStripItemEventHandler(Header_QuickItemRemoved);

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    MdiClient mdiClient = (MdiClient)ctrl;
                    mdiClient.BackColor = Color.FromArgb(165, 195, 239);
                }
            }
        }

        // Triggers when an item is added into quick access toolbar
        void Header_QuickItemAdded(object sender, ToolStripItemEventArgs e)
        {            
            this.superAccelerator1.SetAccelerator(e.Item, accCount.ToString());
            accCount++;
        }

        // Triggers when an item is removed into quick access toolbar
        void Header_QuickItemRemoved(object sender, ToolStripItemEventArgs e)
        {
            accCount--;
        }

        private void QuickItems()
        {
            ToolStripButton saveBtn = new ToolStripButton("Save");
            saveBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveBtn.Image = this.imageList1.Images[0];
            excelRibbon.Header.AddQuickItem(saveBtn);
            
            ToolStripButton undoBtn = new ToolStripButton("Undo");
            undoBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            undoBtn.Image  = this.imageList1.Images[1];
            excelRibbon.Header.AddQuickItem(undoBtn);

            ToolStripButton redoBtn = new ToolStripButton("Redo");
            redoBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            redoBtn.Image = this.imageList1.Images[2];
            redoBtn.Enabled = false;
            excelRibbon.Header.AddQuickItem(redoBtn);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.gridAwareTextBoxItem2.MinWidth = this.Width -( this.gridAwareTextBoxItem1.MinWidth + 66 );
        }
        
        // Triggers when double-clicking the menu button.
        private void excelRibbon_MenuButtonDoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton81_Click(object sender, EventArgs e)
        {
            WorkBook workBook = new WorkBook();
            workBook.MdiParent = this;
            workBook.Text = "WorkBook " + childWorkBookNumber++;
            workBook.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton89_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }
    }
}