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
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;

namespace ExcelMarker
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ExcelMarkerForm : MetroForm
    {
        #region Private Members
        private GridControl gridControl1;
		private ExcelMarkerMouseController excelMarker = null;
		private int mouseDownRow = -1;
		private int mouseDownCol = -1;
		private System.Collections.Queue oldSelections = null;
		int alphaBlendValue = 65;
		const int rowBase = 0;
		const int colBase = 0;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        #endregion

        public ExcelMarkerForm()
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


            #region MarkerForm
            System.IO.Stream strm = null; 
            
			this.gridControl1.ControllerOptions = GridControllerOptions.All & (~GridControllerOptions.OleDataSource);
			
			gridControl1.CommandStack.Enabled = false;

			this.excelMarker = new ExcelMarkerMouseController(gridControl1);
			gridControl1.MouseControllerDispatcher.Add(excelMarker);

			this.SuspendLayout();

			GridBorder thickBorder = new GridBorder(GridBorderStyle.Solid, Color.Gray, GridBorderWeight.Medium);

			int rowIndex = rowBase + 1;
			int colIndex = colBase + 1;

			gridControl1.TableStyle.CheckBoxOptions = new GridCheckBoxCellInfo("True", "False", "", false);
			
			gridControl1[rowIndex, colIndex].CellType = "CheckBox";
			gridControl1[rowIndex, colIndex].TriState = false;
			gridControl1[rowIndex, colIndex].Text = "True";
			gridControl1[rowIndex, colIndex].VerticalAlignment = GridVerticalAlignment.Middle;
			gridControl1[rowIndex, colIndex].Description = " ExcelLikeCurrentCell";

			rowIndex ++;
			gridControl1[rowIndex, colIndex].CellType = "CheckBox";
			gridControl1[rowIndex, colIndex].TriState = false;
			gridControl1[rowIndex, colIndex].Text = "True";
			gridControl1[rowIndex, colIndex].VerticalAlignment = GridVerticalAlignment.Middle;
			gridControl1[rowIndex, colIndex].Description = " ExcelLikeSelectionFrame";

			rowIndex++;
			gridControl1[rowIndex, colIndex].CellType = "CheckBox";
			gridControl1[rowIndex, colIndex].TriState = false;
			gridControl1[rowIndex, colIndex].Text = "True";
			gridControl1[rowIndex, colIndex].VerticalAlignment = GridVerticalAlignment.Middle;
			gridControl1[rowIndex, colIndex].Description = " ExcelMarker";

			rowIndex++;
			
			rowIndex++;
			gridControl1[rowIndex, colIndex].Borders.Top = thickBorder; 
			gridControl1[rowIndex, colIndex].Borders.Left = thickBorder; 
			gridControl1[rowIndex, colIndex].Borders.Right = thickBorder; 
			gridControl1[rowIndex, colIndex].Text = "Selection Color";
			gridControl1[rowIndex, colIndex].HorizontalAlignment = GridHorizontalAlignment.Center;
			gridControl1[rowIndex, colIndex].VerticalAlignment = GridVerticalAlignment.Bottom;
			gridControl1[rowIndex, colIndex].Font.Size = 8;
			gridControl1[rowIndex, colIndex].TextColor = Color.Gray;
			gridControl1[rowIndex, colIndex].Enabled = false;

			rowIndex++;
			gridControl1[rowIndex, colIndex].Borders.Left = thickBorder; 
			gridControl1[rowIndex, colIndex].Borders.Right = thickBorder; 
			gridControl1[rowIndex, colIndex].CellValue = Color.FromName("Highlight");//Color.FromArgb( 255, 187, 111 );
			gridControl1[rowIndex, colIndex].CellType = "ColorEdit";
			gridControl1[rowIndex, colIndex].TextColor = Color.White;
			gridControl1[rowIndex, colIndex].CellValueType = typeof(Color);
			gridControl1[rowIndex, colIndex].HorizontalAlignment = GridHorizontalAlignment.Center;
            gridControl1[rowIndex, colIndex].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
			gridControl1[rowIndex, colIndex].Font.Size = 8;

			rowIndex++;
			gridControl1[rowIndex, colIndex].Borders.Left = thickBorder; 
			gridControl1[rowIndex, colIndex].Borders.Right = thickBorder; 
			rowIndex++;
			gridControl1[rowIndex, colIndex].Borders.Left = thickBorder; 
			gridControl1[rowIndex, colIndex].Borders.Right = thickBorder; 
			gridControl1[rowIndex, colIndex].Text = "Alpha Blend Value (0-255)";
			gridControl1[rowIndex, colIndex].HorizontalAlignment = GridHorizontalAlignment.Center;
			gridControl1[rowIndex, colIndex].VerticalAlignment = GridVerticalAlignment.Bottom;
			gridControl1[rowIndex, colIndex].Font.Size = 8;
			gridControl1[rowIndex, colIndex].TextColor = Color.Gray;
			gridControl1[rowIndex, colIndex].Enabled = false;

			rowIndex++;
			gridControl1[rowIndex, colIndex].Borders.Left = thickBorder; 
			gridControl1[rowIndex, colIndex].Borders.Right = thickBorder; 
			gridControl1[rowIndex, colIndex].CellType = "NumericUpDown";
			gridControl1[rowIndex, colIndex].CellValue = alphaBlendValue;
			gridControl1[rowIndex, colIndex].CellValueType = typeof(int);
			gridControl1[rowIndex, colIndex].NumericUpDown = new GridNumericUpDownCellInfo(0, 255, 0, 1, true);
			gridControl1[rowIndex, colIndex].HorizontalAlignment = GridHorizontalAlignment.Center;
			gridControl1[rowIndex, colIndex].Font.Size = 8;
			
			rowIndex++;
			gridControl1[rowIndex, colIndex].Borders.Left = thickBorder; 
			gridControl1[rowIndex, colIndex].Borders.Right = thickBorder; 
			
			rowIndex++;
			gridControl1[rowIndex, colIndex].Borders.Bottom = thickBorder;
			gridControl1[rowIndex, colIndex].Borders.Left = thickBorder; 
			gridControl1[rowIndex, colIndex].Borders.Right = thickBorder;
			gridControl1[rowIndex, colIndex].CellType = "PushButton";
			gridControl1[rowIndex, colIndex].Description = "Apply";
            gridControl1[rowIndex, colIndex].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            gridControl1.Model.RowHeights[rowIndex] = 25;
            gridControl1.Rows.DefaultSize += 1;

			gridControl1.DefaultColWidth = 70;
			gridControl1.ColWidths.SetSize(colIndex, 230);

			//add a custom cell control that draws a mitmap
			gridControl1.CellModels.Add("ImageCell", new ImageCellModel(gridControl1.Model));
	
			//read a bitmap from resources
			//strm = this.GetType().Assembly.GetManifestResourceStream("ExcelMarker.grid.gif"); 
            Bitmap bm = GetImage(@"Common\Images\Grid\SelectionMarker\grid.gif");// new Bitmap(strm);
			
			//set up covered cell to show the bitmap
			gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(1, 2, 5, 9));
			gridControl1[1, 2].Tag = bm; //Tag used to hold the bitmap
			gridControl1[1, 2].CellType = "ImageCell";

			//set some grid properties
			gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation;
			gridControl1.AlphaBlendSelectionColor = Color.FromArgb( alphaBlendValue, Color.FromName("Highlight") );
			gridControl1.BorderStyle = BorderStyle.None;


			this.gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(7, 3, 10, 6));
			this.gridControl1[7, 3].Borders.All = new GridBorder(GridBorderStyle.Solid, Color.Orange, GridBorderWeight.Thick); 
			this.gridControl1[7, 3].Text =  "Make some selections and then change the Excel-Like properties and selection color properties listed to the left.";
			this.gridControl1[7, 3].Font.Size = 9;
			this.gridControl1[7, 3].Font.Bold = false;
			this.gridControl1[7, 3].Font.Facename = "Helvetica";
			this.gridControl1[7, 3].TextColor = Color.Orange;
			this.gridControl1[7, 3].Enabled = false;
			this.gridControl1[7, 3].VerticalAlignment = GridVerticalAlignment.Middle;
			this.gridControl1[7, 3].HorizontalAlignment = GridHorizontalAlignment.Left;
	
	
			gridControl1.CommandStack.Enabled = true;
			gridControl1.CommandStack.UndoStack.Clear();
			gridControl1.ThemesEnabled = true;

			gridControl1.Selections.Add(GridRangeInfo.Cells(12, 3, 14, 7));
			gridControl1.CurrentCell.MoveTo(12, 3);


			oldSelections = new Queue();
			oldSelections.Enqueue(GridRangeInfo.Cells(12, 3, 14, 7));
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridControl1.BackColor = Color.White;
			this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            GridStyleInfo style = gridControl1.BaseStylesMap["Header"].StyleInfo;
            style.Font.Facename = "Segoe UI";
            this.StartPosition = FormStartPosition.CenterScreen;
			this.ResumeLayout();
            #endregion 

        }

        #region Form handlers
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


        private Bitmap GetImage(string bitmapName)
        {
            Bitmap bitmap = null;

            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    bitmap = new Bitmap(bitmapName);

                bitmapName = @"..\" + bitmapName;
            }
            return bitmap;
        }


		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
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
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.gridControl1.ColCount = 23;
            this.gridControl1.DefaultColWidth = 66;
            this.gridControl1.ExcelLikeCurrentCell = true;
            this.gridControl1.ExcelLikeSelectionFrame = true;
            this.gridControl1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Font.Bold = true;
            gridCellInfo1.StyleInfo.Font.Facename = "Verdana";
            gridCellInfo1.StyleInfo.Font.Italic = false;
            gridCellInfo1.StyleInfo.Font.Size = 9.75F;
            gridCellInfo1.StyleInfo.Font.Strikeout = false;
            gridCellInfo1.StyleInfo.Font.Underline = false;
            gridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1});
            this.gridControl1.Location = new System.Drawing.Point(12, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RowCount = 65;
            this.gridControl1.Size = new System.Drawing.Size(718, 373);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseUp);
            this.gridControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridControl1_MouseDown);
            this.gridControl1.SelectionChanging += new Syncfusion.Windows.Forms.Grid.GridSelectionChangingEventHandler(this.gridControl1_SelectionChanging);
            // 
            // ExcelMarkerForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
			this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(742, 389);
            this.Controls.Add(this.gridControl1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "ExcelMarkerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection Marker Demo";
            this.Load += new System.EventHandler(this.ExcelMarkerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		public static void Main() 
		{
			Application.Run(new ExcelMarkerForm());
        }

        #endregion

        #region Event Handlers
        //save selections for use in mouseup
		private void gridControl1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
			gridControl1.PointToRowCol(new Point(e.X, e.Y), out this.mouseDownRow, out this.mouseDownCol);
			if(mouseDownCol == colBase && gridControl1.CurrentCell.ColIndex != colBase)
			{
				//save the old selections so we can reset them later
				oldSelections = new Queue();
				foreach(GridRangeInfo r in gridControl1.Selections.Ranges)
					oldSelections.Enqueue(r);
			}
			
		}


		//handle resetting selections after mouseclick in column 1
		private void gridControl1_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			
			int rowIndex, colIndex;
			gridControl1.PointToRowCol(new Point(e.X, e.Y), out rowIndex, out colIndex);

			if(rowIndex != mouseDownRow || colIndex != mouseDownCol)
			{
				//save the old selections so we can reset them later
				oldSelections = new Queue();
				foreach(GridRangeInfo r in gridControl1.Selections.Ranges)
					oldSelections.Enqueue(r);
			}
			if(rowIndex == mouseDownRow && colIndex == mouseDownCol
				&& (gridControl1[rowIndex, colIndex].CellType == "CheckBox"
				|| gridControl1[rowIndex, colIndex].CellType == "PushButton"))
			{
				gridControl1.BeginUpdate();

				switch(rowIndex - rowBase)
				{
					case 1://ExcelCurrentCell
						gridControl1.ExcelLikeCurrentCell = 
							(gridControl1[rowBase + 1, colBase + 1].Text == "True");
						break;
					case 2://ExcelSelectionFrame
						gridControl1.ExcelLikeSelectionFrame = 
							(gridControl1[rowBase + 2, colBase + 1].Text == "True");
						break;
					case 3://ExcelMarker
						if(gridControl1[rowBase + 3, colBase + 1].Text == "True"
							&& excelMarker == null)
						{
							this.excelMarker = new ExcelMarkerMouseController(gridControl1);
							gridControl1.MouseControllerDispatcher.Add(excelMarker);
						}
						else if(gridControl1[rowBase + 3,colBase + 1].Text == "False"
							&& excelMarker != null)
						{
							gridControl1.MouseControllerDispatcher.Remove(excelMarker);
							excelMarker = null;
						}
						break;
					case 11://apply
						object o = gridControl1[rowBase + 9, colBase + 1].CellValue;
						if( o is string)
							alphaBlendValue = int.Parse((string)o);
						else if(o is int)
							alphaBlendValue = (int)o;

						o = gridControl1[rowBase + 6, colBase + 1].CellValue;
						if( o  is string)
							gridControl1.AlphaBlendSelectionColor = 
								Color.FromArgb(alphaBlendValue, (Color)TypeDescriptor.GetConverter(typeof(Color)).ConvertFromString((string)o));
						else if (o is Color)
							gridControl1.AlphaBlendSelectionColor = 
								Color.FromArgb(alphaBlendValue, (Color)o);
						break;
				}


				//save the selections for later use if needed
				foreach(GridRangeInfo r in gridControl1.Selections.Ranges)
					oldSelections.Enqueue(r);
				
				gridControl1.EndUpdate();
			}
			mouseDownRow = -1;
			mouseDownCol = -1;		
		}


		//avoid selecting column 1
		private void gridControl1_SelectionChanging(object sender, Syncfusion.Windows.Forms.Grid.GridSelectionChangingEventArgs e)
		{
			//avoid selecting column 1...
			if(e.Range.Left == 1)
				e.Cancel = true;
		}

        private void ExcelMarkerForm_Load(object sender, EventArgs e)
        {

        }
        #endregion
    }
}