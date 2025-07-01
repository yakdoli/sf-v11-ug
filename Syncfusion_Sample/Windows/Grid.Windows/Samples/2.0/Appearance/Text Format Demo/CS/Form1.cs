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
using Syncfusion.Drawing;
using Syncfusion.Diagnostics;
using Syncfusion.Windows.Forms;

namespace TextFormat
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
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
			//
			// TODO: Add any constructor code after InitializeComponent call
            //

            #region Style settings
            GridModel model = gridControl1.Model;
			model.Options.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation;

			GridFontInfo boldFont = new GridFontInfo();
			boldFont.Bold = true;			
			boldFont.Size = 10;
			boldFont.Underline = true;

			int rowIndex = 2;
			int colIndex = 1;

			gridControl1.Rows.DefaultSize += 2;
			int boldfontRowHeight = gridControl1.Rows.DefaultSize + 6;

			model.Options.ControllerOptions = GridControllerOptions.All;
			model.Options.DataObjectConsumerOptions = GridDataObjectConsumerOptions.All;

			GridStyleInfo standard = model.BaseStylesMap["Standard"].StyleInfo;
			GridStyleInfo header = model.BaseStylesMap["Header"].StyleInfo;
			GridStyleInfo rowHeader = model.BaseStylesMap["Row Header"].StyleInfo;
			GridStyleInfo colHeader = model.BaseStylesMap["Column Header"].StyleInfo;

			header.Interior = new BrushInfo(SystemColors.Control);
			rowHeader.Interior = new BrushInfo(SystemColors.Control);

            standard.Font.Facename = "Segoe UI";
			standard.VerticalAlignment = GridVerticalAlignment.Middle;

            #endregion

            #region Number Formats
            model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "Number Formats";
			model[rowIndex, 1].Font = boldFont;
			model.RowHeights[rowIndex] = boldfontRowHeight;
			rowIndex++;

			colIndex = 1;
			rowIndex++;
			foreach (string format in new string[] 
				{
			
					"0.00",
					"C",
					"0.00;(0.00)",
					"###0.##%",
					"#0.#E+00",
					"10:##,##0.#"
				})
			{
				model[rowIndex-1, colIndex].Text = format;
				model[rowIndex, colIndex].Format = format;
				model[rowIndex, colIndex].CellValue = Math.PI;
				model[rowIndex, colIndex].CellValueType = typeof(double);
				colIndex++;
            }
            #endregion

            #region Date Formats

            rowIndex++;
			rowIndex++;

			colIndex = 1;

			model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "DateTime Formats";
			model[rowIndex, 1].Font = boldFont;
			model.RowHeights[rowIndex] = boldfontRowHeight;
			rowIndex++;

			colIndex = 1;
			rowIndex++;
			foreach (string format in new string[] 
				{
			
					"d",
					"D",
					"f",
					"dddd, dd MMMM yyyy",
					"t",
					"s"
				})
			{
				model[rowIndex-1, colIndex].Text = format;
				model[rowIndex, colIndex].Format = format;
				model[rowIndex, colIndex].CellValue = DateTime.Now;
				model[rowIndex, colIndex].CellValueType = typeof(DateTime);
				colIndex++;
			}

			rowIndex++;
			rowIndex++;
            #endregion

            #region Validation
            model.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, 2));
			model[rowIndex, 1].Text = "Validation";
			model[rowIndex, 1].Font = boldFont;
			model.RowHeights[rowIndex] = boldfontRowHeight;
			rowIndex++;

			model[rowIndex, 1].Text = "Positive numbers";
			model.RowStyles[rowIndex].ValidateValue.NumberRequired = true;
			model.RowStyles[rowIndex].ValidateValue.Minimum = 0;
			model.RowStyles[rowIndex].ValidateValue.Maximum = float.NaN;
			model.RowStyles[rowIndex].ValidateValue.ErrorMessage = "Please enter a number greater than 0!";
			rowIndex++;

			model[rowIndex, 1].Text = "Validation (1-100 valid range)";
			model.RowStyles[rowIndex].ValidateValue = new GridCellValidateValueInfo(true, 1, 100, "Please enter a number between 1 and 100!");
			rowIndex++;
			rowIndex++;

			model[rowIndex, 1].Text = "Validation (allow strings to be entered into cells with CellValueType = typeof(double)";
			rowIndex++;
			model.RowStyles[rowIndex].CellValueType = typeof(double);
			model.RowStyles[rowIndex].CellValue = 1;
			model.RowStyles[rowIndex].Format = "C";
			model.RowStyles[rowIndex].StrictValueType = false;
			rowIndex++;
			rowIndex++;

			model[rowIndex, 1].Text = "Validation (do not allow strings to be entered)";
			rowIndex++;
			model.RowStyles[rowIndex].CellValueType = typeof(double);
			model.RowStyles[rowIndex].CellValue = 1;
			model.RowStyles[rowIndex].Format = "C";
			model.RowStyles[rowIndex].StrictValueType = true;
			rowIndex++;
			rowIndex++;

			model[rowIndex, 1].Text = "Validation (change CellValueType when strings is entered)";
			rowIndex++;
			model.RowStyles[rowIndex].CellValueType = typeof(double);
			model.RowStyles[rowIndex].CellValue = 1;
			model.RowStyles[rowIndex].Format = "C";
			model.RowStyles[rowIndex].Tag = "Custom";
			rowIndex++;
			rowIndex++;
            #endregion

            #region TableStyle
            model.RowHeights.ResizeToFit(GridRangeInfo.Rows(2, rowIndex));
			this.gridControl1.DefaultRowHeight = 18;
			this.gridControl1.DefaultColWidth = 70;			
			this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;	
			this.gridControl1.TableStyle.TextColor = Color.MidnightBlue;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            #endregion
        }

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
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            gridBaseStyle1.Name = "Row Header";
            gridBaseStyle1.StyleInfo.BaseStyle = "Header";
            gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle2.Name = "Column Header";
            gridBaseStyle2.StyleInfo.BaseStyle = "Header";
            gridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle3.Name = "Standard";
            gridBaseStyle3.StyleInfo.Font.Facename = "Segoe UI";
            gridBaseStyle3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle4.Name = "Header";
            gridBaseStyle4.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle4.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle4.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle4.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle4.StyleInfo.CellType = "Header";
            gridBaseStyle4.StyleInfo.Font.Bold = true;
            gridBaseStyle4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle4.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.gridControl1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridControl1.ColCount = 8;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(3, 179),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(4, 196)});
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.DefaultRowHeight = 20;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo1.StyleInfo.Font.Bold = false;
            gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo1.StyleInfo.Font.Italic = false;
            gridCellInfo1.StyleInfo.Font.Size = 8.5F;
            gridCellInfo1.StyleInfo.Font.Strikeout = false;
            gridCellInfo1.StyleInfo.Font.Underline = false;
            gridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1});
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowCount = 30;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(768, 312);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.VerticalThumbTrack = true;
			this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.SaveCellText += new Syncfusion.Windows.Forms.Grid.GridCellTextEventHandler(this.gridControl1_SaveCellText);
            this.gridControl1.SaveCellFormattedText += new Syncfusion.Windows.Forms.Grid.GridCellTextEventHandler(this.gridControl1_SaveCellFormattedText);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 336);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
			this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(792, 336);
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
            this.Text = "Text Format Demo";
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
#endregion

        #region Event Handlers
        private void gridControl1_SaveCellText(object sender, Syncfusion.Windows.Forms.Grid.GridCellTextEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfo(e);
			ParseText(e);
		}

		private void gridControl1_SaveCellFormattedText(object sender, GridCellTextEventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfo(e);
			ParseText(e);
		}

		void ParseText(GridCellTextEventArgs e)
		{
			// By default, the grid will display a warning message box informing the user
			// the entered value is not valid and the user will have to change the value.
			//
			// In this event handler we change the grid defaults behavior such that
			// when the user enters a value that does not fit the cells CellValueType,
			// the input text is accepted and no warning message is shown.
			if (e.Handled || e.Style.Tag == null || !e.Style.Tag.Equals("Custom"))
				return;

			System.Globalization.CultureInfo ci = e.Style.CultureInfo;
			System.Globalization.NumberFormatInfo nfi = ci != null ? ci.NumberFormat : null; 
			try
			{
				e.Style.CellValue = GridCellValueConvert.Parse(e.Text, e.Style.CellValueType, nfi, e.Style.Format);
			}
			catch (Exception ex)
			{
				if (ex is FormatException || ex.InnerException is FormatException)
				{
					e.Style.CellValue = e.Text;
					// possibly could also change CellValueType here 
					e.Style.CellValueType = typeof(string);
					Console.WriteLine("Changed e.Style.CellValueType = typeof(string) for " + e.Style.Identity.ToString());
					// - or -
					// you could also further analyze the input text and assign a type
					// that fits the input text, e.g.
					// e.Style.CellValueType = typeof(datetime);
					// - or - 
					// e.Style.CellValueType = typeof(decimal);
					// etc.
				}
				else
					throw;
			}
			e.Handled = true;
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			gridControl1.Model.BaseStylesMap["Header"].StyleInfo.Font.Bold = true;
		}
#endregion
	}
}
