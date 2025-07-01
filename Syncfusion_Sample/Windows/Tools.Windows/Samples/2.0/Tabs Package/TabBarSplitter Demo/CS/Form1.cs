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

namespace TabBarSplitterDemo
{
    public partial class Form1 : RibbonForm
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        #region Helper Methods
        void QuickItems()
        {
            ToolStripButton saveBtn = new ToolStripButton("Save");
            saveBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveBtn.Image = this.imageList1.Images[0];
            ribbonControlAdv1.Header.AddQuickItem(saveBtn);
            
            ToolStripButton undoBtn = new ToolStripButton("Undo");
            undoBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            undoBtn.Image  = this.imageList1.Images[1];
            ribbonControlAdv1.Header.AddQuickItem(undoBtn);

            ToolStripButton redoBtn = new ToolStripButton("Redo");
            redoBtn.DisplayStyle = ToolStripItemDisplayStyle.Image;
            redoBtn.Image = this.imageList1.Images[2];
            redoBtn.Enabled = false;
            ribbonControlAdv1.Header.AddQuickItem(redoBtn);
        }

        GridControl CreateGridControl()
        {
            GridControl gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            
            gridControl1.ColCount = 20;
            gridControl1.RowCount = 100;

            return gridControl1;
        }

        void AddTabBarPage()
        {
            TabBarPage page = new TabBarPage("Sheet" + (this.tabBarSplitterControl1.TabBarPages.Count + 1));

            GridControl grid = CreateGridControl();
            page.Controls.Add(grid);

            grid.ThemesEnabled = true;
            grid.GridVisualStyles = GridVisualStyles.Office2007Blue;
            grid.Dock = DockStyle.Fill;

            this.tabBarSplitterControl1.TabBarPages.Add(page);
        }

        #endregion

        #region Event Handlers
        
        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            QuickItems();

            for (int i = 0; i < 3;i++)
                AddTabBarPage();
        }

        private void toolStripCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.tabBarSplitterControl1.ShowHorizontalScrollBar = !this.toolStripCheckBox1.Checked;
        }

        private void toolStripCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.tabBarSplitterControl1.ShowVerticalScrollBar = !this.toolStripCheckBox2.Checked;
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            AddTabBarPage();
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            if (this.tabBarSplitterControl1.TabBarPages.Count > 1)
                this.tabBarSplitterControl1.HidePage(this.tabBarSplitterControl1.ActivePage);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (this.tabBarSplitterControl1.TabBarPages.Count > 1)
                this.tabBarSplitterControl1.TabBarPages.Remove(this.tabBarSplitterControl1.ActivePage);
            else
                MessageBoxAdv.Show("One sheet alone exists! No more sheets to remove!", "Warning!");
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    this.tabBarSplitterControl1.Office2007ColorScheme = Office2007Theme.Blue;
                    this.tabBarSplitterControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    break;
                case 1:
                    this.tabBarSplitterControl1.Office2007ColorScheme = Office2007Theme.Black;
                    this.tabBarSplitterControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    break;
                case 2:
                    this.tabBarSplitterControl1.Office2007ColorScheme = Office2007Theme.Silver;
                    this.tabBarSplitterControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    break;
            }


        }
        #endregion
    }
}