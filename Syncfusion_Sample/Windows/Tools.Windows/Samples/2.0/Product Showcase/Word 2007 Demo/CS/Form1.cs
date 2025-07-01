#region Copyright Syncfusion Inc. 2001 - 2013
//
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
//
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using Word2007Demo_2005.Properties;
using Syncfusion.Drawing;
using System.IO;

namespace Word2007Demo_2005
{
	// RibbonForm class is derived from a System.Windows.Forms to have Office 2007 look and feel.
    public partial class Form1 : RibbonForm
    {
        private Font font;
		private Point pt;
		private ProgressBarAdv progressBarAdv;

        public Form1()
        {
            InitializeComponent();
           

            #region ProgressBarAdv Code
            progressBarAdv = new ProgressBarAdv();
            progressBarAdv.BackColor = System.Drawing.SystemColors.Control;
            progressBarAdv.BackGradientEndColor = System.Drawing.Color.White;
            progressBarAdv.BackGradientStartColor = System.Drawing.Color.LightGray;
            progressBarAdv.BackMultipleColors = new System.Drawing.Color[0];
            progressBarAdv.BackSegments = false;
            progressBarAdv.BackTubeEndColor = System.Drawing.Color.White;
            progressBarAdv.BackTubeStartColor = System.Drawing.Color.LightGray;
            progressBarAdv.BorderColor = System.Drawing.Color.Black;
            progressBarAdv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            progressBarAdv.CustomWaitingRender = false;
            progressBarAdv.FontColor = System.Drawing.Color.White;
            progressBarAdv.ForegroundImage = null;
            progressBarAdv.ForeSegments = false;
            progressBarAdv.GradientEndColor = System.Drawing.Color.Lime;
            progressBarAdv.GradientStartColor = System.Drawing.Color.Red;
            progressBarAdv.Location = new System.Drawing.Point(2, 3);
            progressBarAdv.MultipleColors = new System.Drawing.Color[0];
            progressBarAdv.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Tube;
            progressBarAdv.SegmentWidth = 12;
            progressBarAdv.Size = new System.Drawing.Size(113, 16);
            progressBarAdv.TabIndex = 1;
            progressBarAdv.TextVisible = false;
            progressBarAdv.ThemesEnabled = true;
            progressBarAdv.TubeEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(231)))), ((int)(((byte)(122)))));
            progressBarAdv.TubeStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(155)))), ((int)(((byte)(35)))));
            progressBarAdv.WaitingGradientWidth = 400;
            progressBarAdv.Text = "Progress";
            progressBarAdv.Value = 0;
            progressTimer.Start();
            progressTimer.Tick += new EventHandler(progressTimer_Tick); 
            #endregion

            //To host any .Net control into ToolStripEx, StatusStrip,
            // User can make use of ToolStripControlHost class
            // and host the control inside it and add the host
            // to item collection.
			ToolStripControlHost host = new ToolStripControlHost(progressBarAdv);
			this.statusStripEx1.Items.Add(host);
            this.splashControl1.ShowDialogSplash(this);
        }

        void EditorContextMenuStripEx_Opened(object sender, EventArgs e)
        {
            this.MiniToolBar.Visible = true;
        }		

        # region FormLoad

        private void Form1_Load(object sender, EventArgs e)
        {
            this.font = this.richTextBox1.SelectionFont;

            foreach (Object item in this.fontListBox1.Items)
            {
                this.toolStripFontfaceComboBox.Items.Add(item);
				this.FontFaceCombo.Items.Add(item);
            }

            this.toolStripFontfaceComboBox.SelectedItem = "Arial";
            this.toolStripFontSizeComboBox.SelectedIndex = 0;
            this.FontFaceCombo.SelectedItem = "Arial";
			this.FontSize.SelectedIndex = 0;

            this.richTextBox1.Text = "";
            string path = Application.StartupPath.ToString() + @"..\..\..\Introduction.rtf";
            if(File.Exists(path))
                this.richTextBox1.LoadFile(path, RichTextBoxStreamType.RichText);

			/////////////////////
			// Add items to QAT//
			////////////////////
			ToolStripButton saveItem = new ToolStripButton(Resources.save);
			this.ribbonControlAdv1.Header.AddQuickItem(saveItem);

			ToolStripButton undoItem = new ToolStripButton(Resources.undo);
			undoItem.Enabled = false;
			this.ribbonControlAdv1.Header.AddQuickItem(undoItem);

			ToolStripButton redoItem = new ToolStripButton(Resources.redo);
			redoItem.Enabled = false;
			this.ribbonControlAdv1.Header.AddQuickItem(redoItem);

            //Attach office2007 scrolls for richtextbox.
            this.scrollersFrame1.AttachedTo = this.richTextBox1;
            this.statusStripEx1.ContextMenuStrip.Opening += new CancelEventHandler(ContextMenuStrip_Opening);
            statusStripLabel1.Text = statusStripLabel1.Text+": "+statusStripLabel1.StatusString;

            this.MiniToolBar.AssociatedControl = this.richTextBox1;
            this.EditorContextMenuStripEx.Opened += new EventHandler(EditorContextMenuStripEx_Opened);

            this.toolStripGallery1.Items[4].Enabled = false;

            //Add tooltip
            this.toolStripGallery1.Items[0].ToolTipText = "No spacing";
            this.toolStripGallery1.Items[1].ToolTipText = "Heading 1";
            this.toolStripGallery1.Items[2].ToolTipText = "Subtle Reference";
            this.toolStripGallery1.Items[3].ToolTipText = "Heading 2";
            this.toolStripGallery1.Items[4].ToolTipText = "Intense Emphasis";
            this.toolStripGallery1.Items[5].ToolTipText = "Intense Reference";
            this.toolStripGallery1.Items[6].ToolTipText = "Title";
            this.toolStripGallery1.Items[7].ToolTipText = "Strong";
            this.toolStripGallery1.Items[8].ToolTipText = "BookTitle";
        }

        void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            statusStripEx1.ContextMenuStrip.Items[2].Text = "Page";  
        }

        # endregion
        
        # region Editor events

        private void growfontToolStripBtn_Click(object sender, EventArgs e)
        {
            if (this.toolStripFontSizeComboBox.SelectedItem.ToString() != "72")
                this.toolStripFontSizeComboBox.SelectedIndex++;
        }

        private void shrinkfontToolStripBtn_Click(object sender, EventArgs e)
        {
            if (this.toolStripFontSizeComboBox.SelectedItem.ToString() != "8")
                this.toolStripFontSizeComboBox.SelectedIndex--;
        }

        private void boldToolstripBtn_Click(object sender, EventArgs e)
        {
			this.boldToolstripBtn.Checked = !this.boldToolstripBtn.Checked;
            if (this.richTextBox1.SelectionFont != null)
            {
                if (!this.boldToolstripBtn.Checked)
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style & ~(richTextBox1.SelectionFont.Style & FontStyle.Bold)));
                else
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style | FontStyle.Bold);
            }
        }

        private void italicToolStripBtn_Click(object sender, EventArgs e)
        {
            this.italicToolStripBtn.Checked = !this.italicToolStripBtn.Checked;
            if (this.richTextBox1.SelectionFont != null)
            {
                if (!this.italicToolStripBtn.Checked)
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style & ~(richTextBox1.SelectionFont.Style & FontStyle.Italic)));
                else
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, this.richTextBox1.SelectionFont.Style | FontStyle.Italic);
            }
        }

        private void underlineToolStripSplitBtn_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.SelectionFont != null)
            {
                if (richTextBox1.SelectionFont.Underline)
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style & ~(richTextBox1.SelectionFont.Style & FontStyle.Underline)));
                else
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Underline);
            }
        }

        private void strikethroToolStripBtn_Click(object sender, EventArgs e)
        {
            this.strikethroToolStripBtn.Checked = !this.strikethroToolStripBtn.Checked;
            if (this.richTextBox1.SelectionFont != null)
            {
                if (!this.strikethroToolStripBtn.Checked)
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, (richTextBox1.SelectionFont.Style & ~(richTextBox1.SelectionFont.Style & FontStyle.Strikeout)));
                else
                    this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Strikeout);
            }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // this.richTextBox1.SelectionFont = new Font(this.toolStripFontfaceComboBox.SelectedItem.ToString(), this.richTextBox1.SelectionFont.Size);
        }

        private void toolStripComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont.Name, float.Parse(this.toolStripFontSizeComboBox.SelectedItem.ToString()));
        }

        private void cleartoolStripBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionFont = font;
            this.richTextBox1.Font = font;
        }

        private void toolStripBtnCopy_Click(object sender, EventArgs e)
        {
			if(this.richTextBox1.SelectedText != null)
				this.richTextBox1.Copy();
        }

        private void toolStripBtnCut_Click(object sender, EventArgs e)
        {
			if (this.richTextBox1.SelectedText != null)
				this.richTextBox1.Cut();
        }

        private void toolStripBtnPaste_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        private void deindentToolStripBtn_Click(object sender, EventArgs e)
        {
            if (this.richTextBox1.SelectionIndent > 0)
                this.richTextBox1.SelectionIndent = this.richTextBox1.SelectionIndent - 20;
        }

        private void inindentToolStripBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionIndent = this.richTextBox1.SelectionIndent + 20;
        }

		private void selectAllToolStripMenuItem1_Click (object sender, EventArgs e)
		{
			richTextBox1.SelectAll();
		}

        private void undoToolStripBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
        }

        private void redoToolStripBtn_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.undoToolStripBtn.Enabled = this.richTextBox1.CanUndo;
            this.redoToolStripBtn.Enabled = this.richTextBox1.CanRedo;
        }

        # endregion

        # region SwitchThemes

		private void ColorSchemeItemCheck ( )
		{
			this.blueToolStripMenuItem.Checked = false;
			this.silverToolStripMenuItem.Checked = false;
			this.blackToolStripMenuItem.Checked = false;
		}

        // Blue Theme
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ColorScheme = ColorSchemeType.Blue;
			this.MiniToolBar.ColorScheme = ToolStripEx.ColorScheme.Blue;
			this.scrollersFrame1.OfficeColorScheme = Office2007ColorScheme.Blue;

			ColorSchemeItemCheck();
			this.blueToolStripMenuItem.Checked = true;

            this.gradientPanel1.BackgroundColor = new BrushInfo(GradientStyle.PathEllipse, Color.RoyalBlue,Color.FromArgb(194, 217, 240));
            this.ribbonControlAdv1.Refresh();
        }

		// Silver Theme
		private void silverToolStripMenuItem_Click (object sender, EventArgs e)
		{
			this.ColorScheme = ColorSchemeType.Silver;
			this.MiniToolBar.ColorScheme = ToolStripEx.ColorScheme.Silver;
			this.scrollersFrame1.OfficeColorScheme = Office2007ColorScheme.Silver;

			ColorSchemeItemCheck();
			this.silverToolStripMenuItem.Checked = true;

			this.gradientPanel1.BackgroundColor = new BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(160, 164, 171), Color.FromArgb(204, 207, 216));
            this.ribbonControlAdv1.Refresh();
		}

		// Black theme
        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ColorScheme = ColorSchemeType.Black;
			this.MiniToolBar.ColorScheme = ToolStripEx.ColorScheme.Black;
			this.scrollersFrame1.OfficeColorScheme = Office2007ColorScheme.Black;

			ColorSchemeItemCheck();
            this.blackToolStripMenuItem.Checked = true;
            
			this.gradientPanel1.BackgroundColor = new BrushInfo(GradientStyle.PathEllipse, Color.FromArgb(57, 57, 57), Color.FromArgb(146, 148, 150));
            this.ribbonControlAdv1.Refresh();
        }

        # endregion

		private void richTextBox1_MouseUp (object sender, MouseEventArgs e)
		{
			if ( this.richTextBox1.SelectedText != String.Empty && e.Button == MouseButtons.Left )
			{
                // MiniToolbar will be shown above the mouse cursor
                // when text in RTE is selected
				pt = new Point(e.X, e.Y - 70);
				
                // Use show method to display the miniToolBar.
				this.MiniToolBar.Show(this.richTextBox1, pt);
				this.MiniToolBar.Opacity = 0.3;
                // Hiding the 'View' tabgroup
                this.ribbonControlAdv1.TabGroups[1].Visible = true;
			}
            else
                this.ribbonControlAdv1.TabGroups[1].Visible = false;
		}

        //////////////////////////////////////////////////
        // To trigger click event for the gallery items //
        //////////////////////////////////////////////////
        private void toolStripGallery2_GalleryItemClicked(object sender, ToolStripGalleryItemEventArgs args)
        {
            switch (args.GalleryItem.Tag as string)
            {
                case "H1":
                    //MessageBox.Show("Gallery Item 1 is clicked");
                    break;
            }
        }

        //////////////////////////////////////////////////////////////////
        // Application will be closed on double clicking the menu button//
        /////////////////////////////////////////////////////////////////
        private void ribbonControlAdv1_MenuButtonDoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        void progressTimer_Tick(object sender, EventArgs e)
        {
            this.progressBarAdv.Value += 1;
            if (progressBarAdv.Value >= 100)
            {
                progressTimer.Stop();
                progressBarAdv.Value = 0;
                progressTimer.Start();
            }
        }

        void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}