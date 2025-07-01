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
using System.IO;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
namespace MiniToolBarDemo_2005
{
    public partial class Form1 : Office2007Form
    {
        #region Form Load And Constructor
        private Point pt;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
            if (File.Exists(path))
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);
            
            //Associating MiniToolBar with the Controls
            this.miniToolBar1.AssociatedControl = this.textBox1;
            this.miniToolBar2.AssociatedControl = this.richTextBox1;
            this.miniToolBar3.AssociatedControl = this.gridControl1;
        }
#endregion

        #region Helper Methods
        
        private void tabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlAdv1.SelectedIndex == 1)
            {
                //MessageBox.Show("h");
                this.textBox1.Focus();
            }
        }
        private void ToolStripButtonClickEvent(object sender, EventArgs e)
        {
            ToolStripButton tsb = sender as ToolStripButton;
            this.EventTrace(tsb.Text + " Clicked.");
        }

        private void EventTrace(string text)
        {
            this.autoLabel1.Text = text;

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            this.EventTrace(this.toolStripComboBox1.Name + " Clicked.");

        }

        #endregion

        #region MinToolBar in RichTextBox
        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.richTextBox1.SelectedText != String.Empty && e.Button == MouseButtons.Left)
            {
                // MiniToolbar will be shown above the mouse cursor
                // when text in RTE is selected
                pt = new Point(e.X, e.Y - 70);

                // Use show method to display the miniToolBar.
                this.miniToolBar2.Show(this.richTextBox1, pt);
            }
        }
        #endregion
       
        #region MinToolBar in TextBox
        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.textBox1.SelectedText != String.Empty && e.Button == MouseButtons.Left)
            {
                // MiniToolbar will be shown above the mouse cursor
                // when text in TextBox control is selected
                pt = new Point(e.X, e.Y - 70);

                // Use show method to display the miniToolBar.
                this.miniToolBar1.Show(this.textBox1, pt);
            }
        }
        #endregion

        #region ColorSchemes
        private void ColorToolStripButton_Click(object sender, EventArgs e)
        {
            ToolStripButton toolStripButton = sender as ToolStripButton;
            if (toolStripButton == this.toolStripButton10)
            {
                this.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Blue;
                this.gridControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
            }
            if (toolStripButton == this.toolStripButton11)
            {
                this.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Silver;
                this.gridControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
            }
            if (toolStripButton == this.toolStripButton12)
            {
                this.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Black;
                this.gridControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
            }
            this.EventTrace(toolStripButton.Text + " Clicked.");
        }
        #endregion

      
     }
}