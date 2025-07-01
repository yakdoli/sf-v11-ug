#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

using System;
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Diagram;
using Syncfusion.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Threading;
using System.Globalization;
using System.Resources;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms.Diagram.Controls;

namespace CustomCommand
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1( ) {
            // Sets the culture to French (France)
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-EG");
            // Sets the UI culture to French (France)
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-EG");

            InitializeComponent( );
            this.diagram1.HScroll = false;
            this.diagram1.VScroll = false;
            this.diagram1.Model = this.model1;          
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// 
        protected override void OnLoad( EventArgs e ) {
            base.OnLoad( e );
            Application.Idle += new EventHandler( Application_Idle );
            
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( ) {
            // Sets the culture to French (France)
            Thread.CurrentThread.CurrentCulture = new CultureInfo("ar-EG");
            // Sets the UI culture to French (France)
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ar-EG");
            Application.EnableVisualStyles();
            Application.Run( new Form1( ) );
        }

        #region Class Events
        /// <summary>
        /// Loads the Symbol palette into the palettegroupBar
        /// </summary>
        protected void LoadSymbolPalette( ) {
            // Create a SymbolPalette for the PaletteGroupView control
            this.paletteGroupBar1.LoadPalette(@"..\..\..\..\..\..\..\..\..\Common\Data\Diagram\Flowchart Symbols.edp");
            

        }

        private void Application_Idle( object sender, EventArgs e ) {
            // update UI
            string strBIText = "Undo";

            string[] strDescriptions;
            int nDescWanted = 1;
            int nDescReturned = this.diagram1.Model.HistoryManager.GetUndoDescriptions( nDescWanted, out strDescriptions );

            if ( nDescReturned == nDescWanted )
                strBIText = strBIText + " " + strDescriptions[0];

            undoToolStripMenuItem.Text = strBIText;

            if ( nDescReturned == 0 )
                undoToolStripMenuItem.Enabled = false;
            else
                undoToolStripMenuItem.Enabled = true;

            strBIText = "Redo";
            // clear strDecsriptions.
            nDescReturned = this.diagram1.Model.HistoryManager.GetRedoDescriptions( nDescWanted, out strDescriptions );
            if ( nDescReturned == nDescWanted )
                strBIText = strBIText + " " + strDescriptions[0];

            redoToolStripMenuItem.Text = strBIText;

            if ( nDescReturned != 0 )
                redoToolStripMenuItem.Enabled = true;
            else
                redoToolStripMenuItem.Enabled = false;
        }

        

        private void Form1_Load( object sender, EventArgs e ) {
            this.LoadSymbolPalette();

            this.paletteGroupBar1.BorderColor = System.Drawing.ColorTranslator.FromHtml("#119EDA");
            foreach (GroupBarItem item in paletteGroupBar1.GroupBarItems)
            {
                //palette view settings
                if (item.Client is PaletteGroupView)
                {
                    PaletteGroupView view = item.Client as PaletteGroupView;
                    view.Font = new Font("Segoe UI", 9, System.Drawing.FontStyle.Regular);
                    view.ForeColor = Color.Black;
                    view.FlowView = true;
                    view.ShowToolTips = true;
                    view.ShowFlowViewItemText = true;
                    view.SelectedItemColor = Color.FromArgb(255, 219, 118);
                    view.HighlightItemColor = Color.FromArgb(255, 227, 149);
                    view.SelectingItemColor = Color.FromArgb(255, 238, 184);
                    view.SelectedHighlightItemColor = Color.FromArgb(255, 218, 115);
                    view.FlowViewItemTextLength = 80;
                    view.BackColor = Color.White;
                    view.TextWrap = true;
                    view.FlatLook = true;
                    view.BorderStyle = BorderStyle.FixedSingle;
                }
            }
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.HistoryManager.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.HistoryManager.Redo();
        }

        private void startAtomicActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.HistoryManager.StartAtomicAction("Custom Action");
        }

        private void endAtomicActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.diagram1.Model.HistoryManager.EndAtomicAction();
        }

       
        #endregion

       
    }
}
