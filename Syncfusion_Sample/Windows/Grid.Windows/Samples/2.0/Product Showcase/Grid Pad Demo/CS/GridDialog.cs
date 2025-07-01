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

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Drawing;
using Syncfusion.Styles;

namespace Syncfusion.Samples.GridPad
{
	/// <summary>
	/// Summary description for GridDialog.
	/// </summary>
	public class GridDialog : Syncfusion.Windows.Forms.MetroForm 
	{
		private GridModel model;
		private SampleGrid grid1;
		private System.Windows.Forms.VScrollBar vScrollBar1;
		private System.Windows.Forms.HScrollBar hScrollBar1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GridDialog()
		{
			//
			// Required for Windows Form Designer support
			//
			model = new GridModel();
			SampleGrid.SetupGridModel(model);
			InitializeComponent();

			grid1.Model = model;

			bool transparent = true;
			bool alpablend = false;

			if (transparent)
			{
				// Transparent
				if (alpablend)
				{
					// I can either do alphablending
					grid1.SupportsTransparentBackColor = true;
					grid1.TableStyle.Interior = new BrushInfo(Color.FromArgb(50, 204, 212, 230));
				}
				else
				{
					// or tell grid not to draw background of cells
					grid1.TransparentBackground = true;
				}

				// (grid.TransparentBackground completely disables background drawing for all cells
				// whereas SupportsTransparentBackColor = true  together with TransparentBackground
				// lets me do alphablending).

				Type type = typeof(Bitmap);
				System.IO.Stream stream = typeof(SampleGrid).Module.Assembly.GetManifestResourceStream(ApplicationMain.manifestNamespace + "logo_800_edf0f7.jpg");
				Bitmap bm = new Bitmap(stream);
				grid1.BackgroundImage = bm;
                grid1.GridVisualStyles = Windows.Forms.GridVisualStyles.Metro;
			}

			// attach my own scrollbars to grid
			grid1.HScrollBehavior = GridScrollbarMode.Shared;
			grid1.VScrollBehavior = GridScrollbarMode.Shared;
			grid1.UseSharedScrollBars = true;
			grid1.VScrollBar.InnerScrollBar = this.vScrollBar1;
			grid1.HScrollBar.InnerScrollBar = this.hScrollBar1;
			grid1.VerticalThumbTrack = true;
			grid1.HorizontalThumbTrack = true;

			// Have grid not occupy the whole client rectangle
//			Rectangle r = grid1.ClientRectangle;
//			r.Inflate(-20, -20);
//			grid1.GridBounds = r;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.grid1 = new Syncfusion.Samples.GridPad.SampleGrid();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid1
            // 
            this.grid1.AllowDragSelectedCols = true;
            this.grid1.AllowDragSelectedRows = true;
            this.grid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grid1.BackColor = System.Drawing.Color.White;
            this.grid1.ColCount = 0;
            this.grid1.DefaultColWidth = 0;
            this.grid1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.grid1.DefaultRowHeight = 0;
            this.grid1.ExcelLikeCurrentCell = true;
            this.grid1.ExcelLikeSelectionFrame = true;
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
            this.grid1.Location = new System.Drawing.Point(20, 16);
            this.grid1.Name = "grid1";
            this.grid1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.grid1.RowCount = 0;
            this.grid1.Size = new System.Drawing.Size(536, 288);
            this.grid1.SmartSizeBox = false;
            this.grid1.TabIndex = 0;
            this.grid1.Text = "grid1";
            this.grid1.ThemesEnabled = true;
            this.grid1.VerticalScrollTips = true;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(172)))), ((int)(((byte)(38)))));
            this.hScrollBar1.Location = new System.Drawing.Point(68, 336);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(464, 16);
            this.hScrollBar1.TabIndex = 1;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(172)))), ((int)(((byte)(38)))));
            this.vScrollBar1.Location = new System.Drawing.Point(584, 56);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(16, 224);
            this.vScrollBar1.TabIndex = 2;
            // 
            // GridDialog
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(616, 365);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.grid1);
            this.Name = "GridDialog";
            this.Text = "Grid Dialog";
            this.TransparencyKey = System.Drawing.SystemColors.Desktop;
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            this.ResumeLayout(false);

		}
	}
}
