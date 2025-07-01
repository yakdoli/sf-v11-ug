#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace Syncfusion.Samples.GridPad
{
    /// <summary>
    ///    Summary description for SplitterFrame.
    /// </summary>
    public class SplitterFrame : Syncfusion.Windows.Forms.MetroForm 
    {
        /// <summary>
        ///    Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components;

        private SplitterControl splitterControl1;
		private SampleGrid grid1;
		private GridModel model;

		public SplitterFrame()
		{
            model = new GridModel();
            SampleGrid.SetupGridModel(model);
            InitializeComponent();

            grid1.Model = model;
		}

        /// <summary>
        ///    Clean up any resources being used.
        /// </summary>
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (components != null)
					components.Dispose();
			}
			base.Dispose(disposing);
		}
		
        /// <summary>
        ///    Required method for Designer support - do not modify
        ///    the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.splitterControl1 = new Syncfusion.Windows.Forms.SplitterControl();
            this.grid1 = new Syncfusion.Samples.GridPad.SampleGrid();
            this.splitterControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitterControl1
            // 
            this.splitterControl1.Controls.Add(this.grid1);
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitterControl1.Location = new System.Drawing.Point(0, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.ShowToolTips = true;
            this.splitterControl1.Size = new System.Drawing.Size(284, 262);
            this.splitterControl1.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.splitterControl1.TabIndex = 0;
            this.splitterControl1.ThemesEnabled = true;
            // 
            // grid1
            // 
            this.grid1.AllowDragSelectedCols = true;
            this.grid1.AllowDragSelectedRows = true;
            this.grid1.BackColor = System.Drawing.Color.White;
            this.grid1.ColCount = 0;
            this.grid1.DefaultColWidth = 0;
            this.grid1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.grid1.DefaultRowHeight = 0;
            this.grid1.ExcelLikeCurrentCell = true;
            this.grid1.ExcelLikeSelectionFrame = true;
            this.grid1.FillSplitterPane = true;
            this.grid1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.grid1.ForeColor = System.Drawing.SystemColors.WindowText;
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Font.Facename = "Verdana";
            gridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.MidnightBlue;
            this.grid1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1});
            this.grid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.grid1.HorizontalScrollTips = true;
            this.grid1.HorizontalThumbTrack = true;
            this.grid1.Location = new System.Drawing.Point(0, 0);
            this.grid1.Name = "grid1";
            this.grid1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grid1.RowCount = 0;
            this.grid1.Size = new System.Drawing.Size(263, 241);
            this.grid1.SmartSizeBox = false;
            this.grid1.ThemesEnabled = true;
            this.grid1.VerticalScrollTips = true;
            // 
            // SplitterFrame
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.splitterControl1);
            this.Name = "SplitterFrame";
            this.Text = "Grid Splitter";
            this.splitterControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

    }
}
