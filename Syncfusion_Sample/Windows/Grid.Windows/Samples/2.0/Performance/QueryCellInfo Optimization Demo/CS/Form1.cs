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

namespace GridOneTimeOnlyQueryCellInfo
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	using Syncfusion.Windows.Forms.Grid;
	using Syncfusion.Windows.Forms;
	using Syncfusion.Drawing;
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
    {
        #region Private Members
        private OneTimeOnlyQueryCellInfoGrid gridControl1;
		private System.Windows.Forms.Panel panel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        #endregion

        public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            #region turn off D&D support
			gridControl1.ControllerOptions = GridControllerOptions.All & (~GridControllerOptions.OleDataSource);			
			gridControl1.ResetVolatileData();
			gridControl1.QueryCellInfo += new GridQueryCellInfoEventHandler(GridQueryCellInfo);
			gridControl1.QueryRowCount += new GridRowColCountEventHandler(GridQueryRowCount);
			gridControl1.QueryRowHeight += new GridRowColSizeEventHandler(GridQueryRowHeight);
			gridControl1.ColWidths[0] += 10;
            #endregion

            #region GridSettings
            this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            GridStyleInfo style = gridControl1.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Verdana";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.panel1.BorderStyle = BorderStyle.None;

			//
			// TODO: Add any constructor code after InitializeComponent call
            //
            #endregion
        }
		
		

        #region EventHandlers
        void GridQueryRowCount(object sender, GridRowColCountEventArgs e) 
		{
			e.Count = 10000;
			e.Handled = true;
		}

		void GridQueryCellInfo(object sender, GridQueryCellInfoEventArgs e) 
		{
			if (e.RowIndex > 0)
			{
				if (e.ColIndex > 0)
				{
					if (e.ColIndex != 2)
						e.Style.CellValue = e.RowIndex.ToString() + "/" + e.ColIndex.ToString();

					if (e.RowIndex % 2 == 0)
					{
						e.Style.Interior = new BrushInfo(Color.FromArgb(0xED, 0xF0, 0xF7));
						e.Style.VerticalAlignment = GridVerticalAlignment.Middle;
					}
					
					if (e.ColIndex == 2)
					{
						if (e.RowIndex %2 == 0)
							e.Style.CellType = "PushButton";
						else
							e.Style.CellType = "CheckBox";
						e.Style.Description = "Click";
					}
					else
						e.Style.CellType = "Static";

					if (e.RowIndex % 4 == 0)
						e.Style.Borders.Bottom = new GridBorder(GridBorderStyle.Solid, Color.Orange, GridBorderWeight.Medium);
				}
				e.Handled = true;
				
			}
		}


		void GridQueryRowHeight(object sender, GridRowColSizeEventArgs e) 
		{
			if (e.Index % 2 == 0)
			{
				e.Size = 25;
				e.Handled = true;
			}
		}

		void GridQueryCoveredRange(object sender, GridQueryCoveredRangeEventArgs e) 
		{
			if (e.RowIndex % 2 == 1 && e.ColIndex >= 1 && e.ColIndex <= 3)
			{
				e.Range = GridRangeInfo.Cells(e.RowIndex, 1, e.ColIndex, 3);
				e.Handled = true;
			}
        }
        #endregion

        #region Form Handlers
        private string GetIconFile(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }


        /// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				gridControl1.QueryCellInfo -= new GridQueryCellInfoEventHandler(GridQueryCellInfo);
				gridControl1.QueryRowCount -= new GridRowColCountEventHandler(GridQueryRowCount);
				gridControl1.QueryCoveredRange -= new GridQueryCoveredRangeEventHandler(GridQueryCoveredRange);
				gridControl1.QueryRowHeight -= new GridRowColSizeEventHandler(GridQueryRowHeight);

				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo2 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo3 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo4 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo5 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo6 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo7 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo8 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo9 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo10 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo11 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo12 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo13 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo14 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo15 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo16 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo17 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo18 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo19 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo20 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo21 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo22 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo23 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo24 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo25 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo26 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo27 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo28 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo29 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo30 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo31 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo32 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo33 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo34 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo35 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo36 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo37 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo38 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo39 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo40 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo41 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo42 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo43 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo44 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo45 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo46 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo47 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo48 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo49 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo50 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo51 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo52 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo53 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo54 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo55 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo56 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo57 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo58 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo59 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo60 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo61 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo62 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo63 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo64 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo65 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo66 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo67 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo68 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo69 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo70 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo71 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo72 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo73 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo74 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo75 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo76 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo77 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo78 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo79 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo80 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo81 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo82 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo83 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo84 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo85 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo86 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo87 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo88 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo89 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo90 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo91 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo92 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo93 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo94 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo95 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo96 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo97 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo98 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo99 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo100 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo101 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo102 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo103 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo104 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo105 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo106 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo107 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo108 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo109 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo110 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo111 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo112 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo113 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo114 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo115 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo116 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo117 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo118 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo119 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo120 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo121 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo122 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo123 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo124 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo125 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo126 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo127 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo128 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo129 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo130 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo131 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo132 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo133 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo134 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo135 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo136 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo137 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo138 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo139 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo140 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo141 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo142 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo143 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo144 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo145 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo146 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo147 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo148 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo149 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo150 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo151 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo152 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo153 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo154 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo155 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo156 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo157 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo158 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo159 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo160 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo161 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo162 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo163 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo164 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo165 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo166 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo167 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo168 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo169 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo170 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo171 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo172 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo173 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo174 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo175 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo176 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo177 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo178 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo179 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo180 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo181 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo182 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo183 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo184 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo185 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo186 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo187 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo188 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo189 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo190 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo191 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo192 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo193 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo194 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo195 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo196 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo197 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo198 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo199 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo200 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo201 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo202 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo203 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo204 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo205 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo206 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo207 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo208 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo209 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo210 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo211 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo212 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo213 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo214 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo215 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo216 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo217 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo218 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo219 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo220 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo221 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo222 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo223 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo224 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo225 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo226 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo227 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo228 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo229 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo230 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo231 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo232 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo233 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo234 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo235 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo236 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo237 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo238 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo239 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo240 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo241 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo242 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo243 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo244 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo245 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo246 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.gridControl1 = new GridOneTimeOnlyQueryCellInfo.OneTimeOnlyQueryCellInfoGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 55;
            this.gridControl1.DefaultColWidth = 70;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.DefaultRowHeight = 20;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridCellInfo2.Col = 1;
            gridCellInfo2.Row = -1;
            gridCellInfo3.Col = 2;
            gridCellInfo3.Row = -1;
            gridCellInfo4.Col = 3;
            gridCellInfo4.Row = -1;
            gridCellInfo5.Col = 4;
            gridCellInfo5.Row = -1;
            gridCellInfo6.Col = 5;
            gridCellInfo6.Row = -1;
            gridCellInfo7.Col = 6;
            gridCellInfo7.Row = -1;
            gridCellInfo8.Col = 7;
            gridCellInfo8.Row = -1;
            gridCellInfo9.Col = 8;
            gridCellInfo9.Row = -1;
            gridCellInfo10.Col = 9;
            gridCellInfo10.Row = -1;
            gridCellInfo11.Col = 10;
            gridCellInfo11.Row = -1;
            gridCellInfo12.Col = 0;
            gridCellInfo12.Row = 0;
            gridCellInfo13.Col = 1;
            gridCellInfo13.Row = 0;
            gridCellInfo14.Col = 2;
            gridCellInfo14.Row = 0;
            gridCellInfo15.Col = 3;
            gridCellInfo15.Row = 0;
            gridCellInfo16.Col = 4;
            gridCellInfo16.Row = 0;
            gridCellInfo17.Col = 5;
            gridCellInfo17.Row = 0;
            gridCellInfo18.Col = 6;
            gridCellInfo18.Row = 0;
            gridCellInfo19.Col = 7;
            gridCellInfo19.Row = 0;
            gridCellInfo20.Col = 8;
            gridCellInfo20.Row = 0;
            gridCellInfo21.Col = 9;
            gridCellInfo21.Row = 0;
            gridCellInfo22.Col = 10;
            gridCellInfo22.Row = 0;
            gridCellInfo23.Col = -1;
            gridCellInfo23.Row = 1;
            gridCellInfo24.Col = 0;
            gridCellInfo24.Row = 1;
            gridCellInfo25.Col = 1;
            gridCellInfo25.Row = 1;
            gridCellInfo26.Col = 2;
            gridCellInfo26.Row = 1;
            gridCellInfo27.Col = 3;
            gridCellInfo27.Row = 1;
            gridCellInfo28.Col = 4;
            gridCellInfo28.Row = 1;
            gridCellInfo29.Col = 5;
            gridCellInfo29.Row = 1;
            gridCellInfo30.Col = 6;
            gridCellInfo30.Row = 1;
            gridCellInfo31.Col = 7;
            gridCellInfo31.Row = 1;
            gridCellInfo32.Col = 8;
            gridCellInfo32.Row = 1;
            gridCellInfo33.Col = 9;
            gridCellInfo33.Row = 1;
            gridCellInfo34.Col = 10;
            gridCellInfo34.Row = 1;
            gridCellInfo35.Col = -1;
            gridCellInfo35.Row = 2;
            gridCellInfo36.Col = 0;
            gridCellInfo36.Row = 2;
            gridCellInfo37.Col = 1;
            gridCellInfo37.Row = 2;
            gridCellInfo38.Col = 2;
            gridCellInfo38.Row = 2;
            gridCellInfo39.Col = 3;
            gridCellInfo39.Row = 2;
            gridCellInfo40.Col = 4;
            gridCellInfo40.Row = 2;
            gridCellInfo41.Col = 5;
            gridCellInfo41.Row = 2;
            gridCellInfo42.Col = 6;
            gridCellInfo42.Row = 2;
            gridCellInfo43.Col = 7;
            gridCellInfo43.Row = 2;
            gridCellInfo44.Col = 8;
            gridCellInfo44.Row = 2;
            gridCellInfo45.Col = 9;
            gridCellInfo45.Row = 2;
            gridCellInfo46.Col = 10;
            gridCellInfo46.Row = 2;
            gridCellInfo47.Col = -1;
            gridCellInfo47.Row = 3;
            gridCellInfo48.Col = 0;
            gridCellInfo48.Row = 3;
            gridCellInfo49.Col = 1;
            gridCellInfo49.Row = 3;
            gridCellInfo50.Col = 2;
            gridCellInfo50.Row = 3;
            gridCellInfo51.Col = 3;
            gridCellInfo51.Row = 3;
            gridCellInfo52.Col = 4;
            gridCellInfo52.Row = 3;
            gridCellInfo53.Col = 5;
            gridCellInfo53.Row = 3;
            gridCellInfo54.Col = 6;
            gridCellInfo54.Row = 3;
            gridCellInfo55.Col = 7;
            gridCellInfo55.Row = 3;
            gridCellInfo56.Col = 8;
            gridCellInfo56.Row = 3;
            gridCellInfo57.Col = 9;
            gridCellInfo57.Row = 3;
            gridCellInfo58.Col = 10;
            gridCellInfo58.Row = 3;
            gridCellInfo59.Col = -1;
            gridCellInfo59.Row = 4;
            gridCellInfo60.Col = 0;
            gridCellInfo60.Row = 4;
            gridCellInfo61.Col = 1;
            gridCellInfo61.Row = 4;
            gridCellInfo62.Col = 2;
            gridCellInfo62.Row = 4;
            gridCellInfo63.Col = 3;
            gridCellInfo63.Row = 4;
            gridCellInfo64.Col = 4;
            gridCellInfo64.Row = 4;
            gridCellInfo65.Col = 5;
            gridCellInfo65.Row = 4;
            gridCellInfo66.Col = 6;
            gridCellInfo66.Row = 4;
            gridCellInfo67.Col = 7;
            gridCellInfo67.Row = 4;
            gridCellInfo68.Col = 8;
            gridCellInfo68.Row = 4;
            gridCellInfo69.Col = 9;
            gridCellInfo69.Row = 4;
            gridCellInfo70.Col = 10;
            gridCellInfo70.Row = 4;
            gridCellInfo71.Col = -1;
            gridCellInfo71.Row = 5;
            gridCellInfo72.Col = 0;
            gridCellInfo72.Row = 5;
            gridCellInfo73.Col = 1;
            gridCellInfo73.Row = 5;
            gridCellInfo74.Col = 2;
            gridCellInfo74.Row = 5;
            gridCellInfo75.Col = 3;
            gridCellInfo75.Row = 5;
            gridCellInfo76.Col = 4;
            gridCellInfo76.Row = 5;
            gridCellInfo77.Col = 5;
            gridCellInfo77.Row = 5;
            gridCellInfo78.Col = 6;
            gridCellInfo78.Row = 5;
            gridCellInfo79.Col = 7;
            gridCellInfo79.Row = 5;
            gridCellInfo80.Col = 8;
            gridCellInfo80.Row = 5;
            gridCellInfo81.Col = 9;
            gridCellInfo81.Row = 5;
            gridCellInfo82.Col = 10;
            gridCellInfo82.Row = 5;
            gridCellInfo83.Col = -1;
            gridCellInfo83.Row = 6;
            gridCellInfo84.Col = 0;
            gridCellInfo84.Row = 6;
            gridCellInfo85.Col = 1;
            gridCellInfo85.Row = 6;
            gridCellInfo86.Col = 2;
            gridCellInfo86.Row = 6;
            gridCellInfo87.Col = 3;
            gridCellInfo87.Row = 6;
            gridCellInfo88.Col = 4;
            gridCellInfo88.Row = 6;
            gridCellInfo89.Col = 5;
            gridCellInfo89.Row = 6;
            gridCellInfo90.Col = 6;
            gridCellInfo90.Row = 6;
            gridCellInfo91.Col = 7;
            gridCellInfo91.Row = 6;
            gridCellInfo92.Col = 8;
            gridCellInfo92.Row = 6;
            gridCellInfo93.Col = 9;
            gridCellInfo93.Row = 6;
            gridCellInfo94.Col = 10;
            gridCellInfo94.Row = 6;
            gridCellInfo95.Col = -1;
            gridCellInfo95.Row = 7;
            gridCellInfo96.Col = 0;
            gridCellInfo96.Row = 7;
            gridCellInfo97.Col = 1;
            gridCellInfo97.Row = 7;
            gridCellInfo98.Col = 2;
            gridCellInfo98.Row = 7;
            gridCellInfo99.Col = 3;
            gridCellInfo99.Row = 7;
            gridCellInfo100.Col = 4;
            gridCellInfo100.Row = 7;
            gridCellInfo101.Col = 5;
            gridCellInfo101.Row = 7;
            gridCellInfo102.Col = 6;
            gridCellInfo102.Row = 7;
            gridCellInfo103.Col = 7;
            gridCellInfo103.Row = 7;
            gridCellInfo104.Col = 8;
            gridCellInfo104.Row = 7;
            gridCellInfo105.Col = 9;
            gridCellInfo105.Row = 7;
            gridCellInfo106.Col = 10;
            gridCellInfo106.Row = 7;
            gridCellInfo107.Col = -1;
            gridCellInfo107.Row = 8;
            gridCellInfo108.Col = 0;
            gridCellInfo108.Row = 8;
            gridCellInfo109.Col = 1;
            gridCellInfo109.Row = 8;
            gridCellInfo110.Col = 2;
            gridCellInfo110.Row = 8;
            gridCellInfo111.Col = 3;
            gridCellInfo111.Row = 8;
            gridCellInfo112.Col = 4;
            gridCellInfo112.Row = 8;
            gridCellInfo113.Col = 5;
            gridCellInfo113.Row = 8;
            gridCellInfo114.Col = 6;
            gridCellInfo114.Row = 8;
            gridCellInfo115.Col = 7;
            gridCellInfo115.Row = 8;
            gridCellInfo116.Col = 8;
            gridCellInfo116.Row = 8;
            gridCellInfo117.Col = 9;
            gridCellInfo117.Row = 8;
            gridCellInfo118.Col = 10;
            gridCellInfo118.Row = 8;
            gridCellInfo119.Col = -1;
            gridCellInfo119.Row = 9;
            gridCellInfo120.Col = 0;
            gridCellInfo120.Row = 9;
            gridCellInfo121.Col = 1;
            gridCellInfo121.Row = 9;
            gridCellInfo122.Col = 2;
            gridCellInfo122.Row = 9;
            gridCellInfo123.Col = 3;
            gridCellInfo123.Row = 9;
            gridCellInfo124.Col = 4;
            gridCellInfo124.Row = 9;
            gridCellInfo125.Col = 5;
            gridCellInfo125.Row = 9;
            gridCellInfo126.Col = 6;
            gridCellInfo126.Row = 9;
            gridCellInfo127.Col = 7;
            gridCellInfo127.Row = 9;
            gridCellInfo128.Col = 8;
            gridCellInfo128.Row = 9;
            gridCellInfo129.Col = 9;
            gridCellInfo129.Row = 9;
            gridCellInfo130.Col = 10;
            gridCellInfo130.Row = 9;
            gridCellInfo131.Col = -1;
            gridCellInfo131.Row = 10;
            gridCellInfo132.Col = 0;
            gridCellInfo132.Row = 10;
            gridCellInfo133.Col = 1;
            gridCellInfo133.Row = 10;
            gridCellInfo134.Col = 2;
            gridCellInfo134.Row = 10;
            gridCellInfo135.Col = 3;
            gridCellInfo135.Row = 10;
            gridCellInfo136.Col = 4;
            gridCellInfo136.Row = 10;
            gridCellInfo137.Col = 5;
            gridCellInfo137.Row = 10;
            gridCellInfo138.Col = 6;
            gridCellInfo138.Row = 10;
            gridCellInfo139.Col = 7;
            gridCellInfo139.Row = 10;
            gridCellInfo140.Col = 8;
            gridCellInfo140.Row = 10;
            gridCellInfo141.Col = 9;
            gridCellInfo141.Row = 10;
            gridCellInfo142.Col = 10;
            gridCellInfo142.Row = 10;
            gridCellInfo143.Col = -1;
            gridCellInfo143.Row = 11;
            gridCellInfo144.Col = 0;
            gridCellInfo144.Row = 11;
            gridCellInfo145.Col = 1;
            gridCellInfo145.Row = 11;
            gridCellInfo146.Col = 2;
            gridCellInfo146.Row = 11;
            gridCellInfo147.Col = 3;
            gridCellInfo147.Row = 11;
            gridCellInfo148.Col = 4;
            gridCellInfo148.Row = 11;
            gridCellInfo149.Col = 5;
            gridCellInfo149.Row = 11;
            gridCellInfo150.Col = 6;
            gridCellInfo150.Row = 11;
            gridCellInfo151.Col = 7;
            gridCellInfo151.Row = 11;
            gridCellInfo152.Col = 8;
            gridCellInfo152.Row = 11;
            gridCellInfo153.Col = 9;
            gridCellInfo153.Row = 11;
            gridCellInfo154.Col = 10;
            gridCellInfo154.Row = 11;
            gridCellInfo155.Col = -1;
            gridCellInfo155.Row = 12;
            gridCellInfo156.Col = 0;
            gridCellInfo156.Row = 12;
            gridCellInfo157.Col = 1;
            gridCellInfo157.Row = 12;
            gridCellInfo158.Col = 2;
            gridCellInfo158.Row = 12;
            gridCellInfo159.Col = 3;
            gridCellInfo159.Row = 12;
            gridCellInfo160.Col = 4;
            gridCellInfo160.Row = 12;
            gridCellInfo161.Col = 5;
            gridCellInfo161.Row = 12;
            gridCellInfo162.Col = 6;
            gridCellInfo162.Row = 12;
            gridCellInfo163.Col = 7;
            gridCellInfo163.Row = 12;
            gridCellInfo164.Col = 8;
            gridCellInfo164.Row = 12;
            gridCellInfo165.Col = 9;
            gridCellInfo165.Row = 12;
            gridCellInfo166.Col = 10;
            gridCellInfo166.Row = 12;
            gridCellInfo167.Col = -1;
            gridCellInfo167.Row = 13;
            gridCellInfo168.Col = 0;
            gridCellInfo168.Row = 13;
            gridCellInfo169.Col = 1;
            gridCellInfo169.Row = 13;
            gridCellInfo170.Col = 2;
            gridCellInfo170.Row = 13;
            gridCellInfo171.Col = 3;
            gridCellInfo171.Row = 13;
            gridCellInfo172.Col = 4;
            gridCellInfo172.Row = 13;
            gridCellInfo173.Col = 5;
            gridCellInfo173.Row = 13;
            gridCellInfo174.Col = 6;
            gridCellInfo174.Row = 13;
            gridCellInfo175.Col = 7;
            gridCellInfo175.Row = 13;
            gridCellInfo176.Col = 8;
            gridCellInfo176.Row = 13;
            gridCellInfo177.Col = 9;
            gridCellInfo177.Row = 13;
            gridCellInfo178.Col = 10;
            gridCellInfo178.Row = 13;
            gridCellInfo179.Col = -1;
            gridCellInfo179.Row = 14;
            gridCellInfo180.Col = 0;
            gridCellInfo180.Row = 14;
            gridCellInfo181.Col = 1;
            gridCellInfo181.Row = 14;
            gridCellInfo182.Col = 2;
            gridCellInfo182.Row = 14;
            gridCellInfo183.Col = 3;
            gridCellInfo183.Row = 14;
            gridCellInfo184.Col = 4;
            gridCellInfo184.Row = 14;
            gridCellInfo185.Col = 5;
            gridCellInfo185.Row = 14;
            gridCellInfo186.Col = 6;
            gridCellInfo186.Row = 14;
            gridCellInfo187.Col = 7;
            gridCellInfo187.Row = 14;
            gridCellInfo188.Col = 8;
            gridCellInfo188.Row = 14;
            gridCellInfo189.Col = 9;
            gridCellInfo189.Row = 14;
            gridCellInfo190.Col = 10;
            gridCellInfo190.Row = 14;
            gridCellInfo191.Col = -1;
            gridCellInfo191.Row = 15;
            gridCellInfo192.Col = 0;
            gridCellInfo192.Row = 15;
            gridCellInfo193.Col = 1;
            gridCellInfo193.Row = 15;
            gridCellInfo194.Col = 2;
            gridCellInfo194.Row = 15;
            gridCellInfo195.Col = 3;
            gridCellInfo195.Row = 15;
            gridCellInfo196.Col = 4;
            gridCellInfo196.Row = 15;
            gridCellInfo197.Col = 5;
            gridCellInfo197.Row = 15;
            gridCellInfo198.Col = 6;
            gridCellInfo198.Row = 15;
            gridCellInfo199.Col = 7;
            gridCellInfo199.Row = 15;
            gridCellInfo200.Col = 8;
            gridCellInfo200.Row = 15;
            gridCellInfo201.Col = 9;
            gridCellInfo201.Row = 15;
            gridCellInfo202.Col = 10;
            gridCellInfo202.Row = 15;
            gridCellInfo203.Col = -1;
            gridCellInfo203.Row = 16;
            gridCellInfo204.Col = 0;
            gridCellInfo204.Row = 16;
            gridCellInfo205.Col = 1;
            gridCellInfo205.Row = 16;
            gridCellInfo206.Col = 2;
            gridCellInfo206.Row = 16;
            gridCellInfo207.Col = 3;
            gridCellInfo207.Row = 16;
            gridCellInfo208.Col = 4;
            gridCellInfo208.Row = 16;
            gridCellInfo209.Col = 5;
            gridCellInfo209.Row = 16;
            gridCellInfo210.Col = 6;
            gridCellInfo210.Row = 16;
            gridCellInfo211.Col = 7;
            gridCellInfo211.Row = 16;
            gridCellInfo212.Col = 8;
            gridCellInfo212.Row = 16;
            gridCellInfo213.Col = 9;
            gridCellInfo213.Row = 16;
            gridCellInfo214.Col = 10;
            gridCellInfo214.Row = 16;
            gridCellInfo215.Col = -1;
            gridCellInfo215.Row = 17;
            gridCellInfo216.Col = 0;
            gridCellInfo216.Row = 17;
            gridCellInfo217.Col = 1;
            gridCellInfo217.Row = 17;
            gridCellInfo218.Col = 2;
            gridCellInfo218.Row = 17;
            gridCellInfo219.Col = 3;
            gridCellInfo219.Row = 17;
            gridCellInfo220.Col = 4;
            gridCellInfo220.Row = 17;
            gridCellInfo221.Col = 5;
            gridCellInfo221.Row = 17;
            gridCellInfo222.Col = 6;
            gridCellInfo222.Row = 17;
            gridCellInfo223.Col = 7;
            gridCellInfo223.Row = 17;
            gridCellInfo224.Col = 8;
            gridCellInfo224.Row = 17;
            gridCellInfo225.Col = 9;
            gridCellInfo225.Row = 17;
            gridCellInfo226.Col = 10;
            gridCellInfo226.Row = 17;
            gridCellInfo227.Col = -1;
            gridCellInfo227.Row = 18;
            gridCellInfo228.Col = 0;
            gridCellInfo228.Row = 18;
            gridCellInfo229.Col = 1;
            gridCellInfo229.Row = 18;
            gridCellInfo230.Col = 2;
            gridCellInfo230.Row = 18;
            gridCellInfo231.Col = 3;
            gridCellInfo231.Row = 18;
            gridCellInfo232.Col = 4;
            gridCellInfo232.Row = 18;
            gridCellInfo233.Col = 5;
            gridCellInfo233.Row = 18;
            gridCellInfo234.Col = 6;
            gridCellInfo234.Row = 18;
            gridCellInfo235.Col = 7;
            gridCellInfo235.Row = 18;
            gridCellInfo236.Col = 8;
            gridCellInfo236.Row = 18;
            gridCellInfo237.Col = -1;
            gridCellInfo237.Row = 19;
            gridCellInfo238.Col = 0;
            gridCellInfo238.Row = 19;
            gridCellInfo239.Col = 1;
            gridCellInfo239.Row = 19;
            gridCellInfo240.Col = 2;
            gridCellInfo240.Row = 19;
            gridCellInfo241.Col = 3;
            gridCellInfo241.Row = 19;
            gridCellInfo242.Col = 4;
            gridCellInfo242.Row = 19;
            gridCellInfo243.Col = 5;
            gridCellInfo243.Row = 19;
            gridCellInfo244.Col = 6;
            gridCellInfo244.Row = 19;
            gridCellInfo245.Col = 7;
            gridCellInfo245.Row = 19;
            gridCellInfo246.Col = 8;
            gridCellInfo246.Row = 19;
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1,
            gridCellInfo2,
            gridCellInfo3,
            gridCellInfo4,
            gridCellInfo5,
            gridCellInfo6,
            gridCellInfo7,
            gridCellInfo8,
            gridCellInfo9,
            gridCellInfo10,
            gridCellInfo11,
            gridCellInfo12,
            gridCellInfo13,
            gridCellInfo14,
            gridCellInfo15,
            gridCellInfo16,
            gridCellInfo17,
            gridCellInfo18,
            gridCellInfo19,
            gridCellInfo20,
            gridCellInfo21,
            gridCellInfo22,
            gridCellInfo23,
            gridCellInfo24,
            gridCellInfo25,
            gridCellInfo26,
            gridCellInfo27,
            gridCellInfo28,
            gridCellInfo29,
            gridCellInfo30,
            gridCellInfo31,
            gridCellInfo32,
            gridCellInfo33,
            gridCellInfo34,
            gridCellInfo35,
            gridCellInfo36,
            gridCellInfo37,
            gridCellInfo38,
            gridCellInfo39,
            gridCellInfo40,
            gridCellInfo41,
            gridCellInfo42,
            gridCellInfo43,
            gridCellInfo44,
            gridCellInfo45,
            gridCellInfo46,
            gridCellInfo47,
            gridCellInfo48,
            gridCellInfo49,
            gridCellInfo50,
            gridCellInfo51,
            gridCellInfo52,
            gridCellInfo53,
            gridCellInfo54,
            gridCellInfo55,
            gridCellInfo56,
            gridCellInfo57,
            gridCellInfo58,
            gridCellInfo59,
            gridCellInfo60,
            gridCellInfo61,
            gridCellInfo62,
            gridCellInfo63,
            gridCellInfo64,
            gridCellInfo65,
            gridCellInfo66,
            gridCellInfo67,
            gridCellInfo68,
            gridCellInfo69,
            gridCellInfo70,
            gridCellInfo71,
            gridCellInfo72,
            gridCellInfo73,
            gridCellInfo74,
            gridCellInfo75,
            gridCellInfo76,
            gridCellInfo77,
            gridCellInfo78,
            gridCellInfo79,
            gridCellInfo80,
            gridCellInfo81,
            gridCellInfo82,
            gridCellInfo83,
            gridCellInfo84,
            gridCellInfo85,
            gridCellInfo86,
            gridCellInfo87,
            gridCellInfo88,
            gridCellInfo89,
            gridCellInfo90,
            gridCellInfo91,
            gridCellInfo92,
            gridCellInfo93,
            gridCellInfo94,
            gridCellInfo95,
            gridCellInfo96,
            gridCellInfo97,
            gridCellInfo98,
            gridCellInfo99,
            gridCellInfo100,
            gridCellInfo101,
            gridCellInfo102,
            gridCellInfo103,
            gridCellInfo104,
            gridCellInfo105,
            gridCellInfo106,
            gridCellInfo107,
            gridCellInfo108,
            gridCellInfo109,
            gridCellInfo110,
            gridCellInfo111,
            gridCellInfo112,
            gridCellInfo113,
            gridCellInfo114,
            gridCellInfo115,
            gridCellInfo116,
            gridCellInfo117,
            gridCellInfo118,
            gridCellInfo119,
            gridCellInfo120,
            gridCellInfo121,
            gridCellInfo122,
            gridCellInfo123,
            gridCellInfo124,
            gridCellInfo125,
            gridCellInfo126,
            gridCellInfo127,
            gridCellInfo128,
            gridCellInfo129,
            gridCellInfo130,
            gridCellInfo131,
            gridCellInfo132,
            gridCellInfo133,
            gridCellInfo134,
            gridCellInfo135,
            gridCellInfo136,
            gridCellInfo137,
            gridCellInfo138,
            gridCellInfo139,
            gridCellInfo140,
            gridCellInfo141,
            gridCellInfo142,
            gridCellInfo143,
            gridCellInfo144,
            gridCellInfo145,
            gridCellInfo146,
            gridCellInfo147,
            gridCellInfo148,
            gridCellInfo149,
            gridCellInfo150,
            gridCellInfo151,
            gridCellInfo152,
            gridCellInfo153,
            gridCellInfo154,
            gridCellInfo155,
            gridCellInfo156,
            gridCellInfo157,
            gridCellInfo158,
            gridCellInfo159,
            gridCellInfo160,
            gridCellInfo161,
            gridCellInfo162,
            gridCellInfo163,
            gridCellInfo164,
            gridCellInfo165,
            gridCellInfo166,
            gridCellInfo167,
            gridCellInfo168,
            gridCellInfo169,
            gridCellInfo170,
            gridCellInfo171,
            gridCellInfo172,
            gridCellInfo173,
            gridCellInfo174,
            gridCellInfo175,
            gridCellInfo176,
            gridCellInfo177,
            gridCellInfo178,
            gridCellInfo179,
            gridCellInfo180,
            gridCellInfo181,
            gridCellInfo182,
            gridCellInfo183,
            gridCellInfo184,
            gridCellInfo185,
            gridCellInfo186,
            gridCellInfo187,
            gridCellInfo188,
            gridCellInfo189,
            gridCellInfo190,
            gridCellInfo191,
            gridCellInfo192,
            gridCellInfo193,
            gridCellInfo194,
            gridCellInfo195,
            gridCellInfo196,
            gridCellInfo197,
            gridCellInfo198,
            gridCellInfo199,
            gridCellInfo200,
            gridCellInfo201,
            gridCellInfo202,
            gridCellInfo203,
            gridCellInfo204,
            gridCellInfo205,
            gridCellInfo206,
            gridCellInfo207,
            gridCellInfo208,
            gridCellInfo209,
            gridCellInfo210,
            gridCellInfo211,
            gridCellInfo212,
            gridCellInfo213,
            gridCellInfo214,
            gridCellInfo215,
            gridCellInfo216,
            gridCellInfo217,
            gridCellInfo218,
            gridCellInfo219,
            gridCellInfo220,
            gridCellInfo221,
            gridCellInfo222,
            gridCellInfo223,
            gridCellInfo224,
            gridCellInfo225,
            gridCellInfo226,
            gridCellInfo227,
            gridCellInfo228,
            gridCellInfo229,
            gridCellInfo230,
            gridCellInfo231,
            gridCellInfo232,
            gridCellInfo233,
            gridCellInfo234,
            gridCellInfo235,
            gridCellInfo236,
            gridCellInfo237,
            gridCellInfo238,
            gridCellInfo239,
            gridCellInfo240,
            gridCellInfo241,
            gridCellInfo242,
            gridCellInfo243,
            gridCellInfo244,
            gridCellInfo245,
            gridCellInfo246});
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RowCount = 100;
            this.gridControl1.Size = new System.Drawing.Size(680, 328);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 1;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.VerticalThumbTrack = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(702, 350);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(702, 350);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueryCellInfo Optimization Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main() 
		{
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif
			Application.Run(new Form1());
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
