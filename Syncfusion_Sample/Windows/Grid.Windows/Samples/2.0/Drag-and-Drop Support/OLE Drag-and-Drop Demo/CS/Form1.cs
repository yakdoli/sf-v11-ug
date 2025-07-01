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

namespace OleDragDrop
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;

	using Syncfusion.Windows.Forms.Grid;
	using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms;
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
		private Syncfusion.Windows.Forms.Grid.GridControl gridControl2;
		private DNDRichTextBox richTextBox1;
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


            #region Buffer Text
            gridControl1.Model.TextDataExchange.PasteTextFromBuffer( 
				"1\tDavolio	Nancy\r\n" +
				"2\tFuller	Andrew\r\n" +
				"3\tLeverling	Janet\r\n" +
				"4\tPeacock	Margaret\r\n" +
				"5\tBuchanan	Steven\r\n" +
				"6\tSuyama	Michael\r\n" +
				"7\tKing	Robert\r\n" +
				"8\tCallahan	Laura\r\n" +
				"9\tDodsworth	Anne\r\n",
				GridRangeInfo.Cell(1,1), int.MaxValue);

            #endregion
            
            #region GridStyleInfo
            GridStyleInfo style;

			style = new GridStyleInfo();
			style.Interior = new BrushInfo(Color.FromArgb(0xED, 0xF0, 0xF7));
			style.TextColor = Color.FromArgb( 238, 122, 3 ); //Color.Orange;
			gridControl1.ChangeCells(GridRangeInfo.Cells(1, 1, 9, 3), style);
			
			style = new GridStyleInfo();
			style.HorizontalAlignment = GridHorizontalAlignment.Right;
			style.CellValueType = typeof(int);
			style.Format = "000";
			gridControl1.ChangeCells(GridRangeInfo.Cells(1, 1, 9, 1), style);
            #endregion

            #region Properties
            gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cells(1, 1, 9, 3));

			gridControl1.CommandStack.Enabled = true;
			gridControl2.CommandStack.Enabled = true;

			gridControl1.AllowDrop = true;
			gridControl2.AllowDrop = true;

            gridControl1.ShowMessageBoxOnDrop = false;
            gridControl2.ShowMessageBoxOnDrop = false;
			//
			// TODO: Add any constructor code after InitializeComponent call
			//			
            richTextBox1.Text = "Drag content using OLE Drag-and-Drop between grids, any other application or use Copy Paste \r\n" +
				"Sample Data:\r\n" +
				"1	Davolio	    Nancy\r\n" +
				"2	Fuller	    Andrew\r\n" +
				"3	Leverling      Janet\r\n" +
				"4	Peacock	    Margaret\r\n" +
				"5	Buchanan    Steven\r\n" +
				"6	Suyama	    Michael\r\n" +
				"7	King	    Robert\r\n" +
				"8	Callahan    Laura\r\n" +
				"9	Dodsworth   Anne\r\n";

			this.gridControl1.DefaultRowHeight = 18;
			this.gridControl1.DefaultColWidth = 70;
            this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridControl1.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            style = gridControl1.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Segoe UI";	

			this.gridControl2.DefaultRowHeight = 18;
			this.gridControl2.DefaultColWidth = 70;
            this.gridControl2.GridVisualStyles = GridVisualStyles.Metro;
            this.gridControl2.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridControl2.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            style = gridControl2.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Segoe UI";
            this.BackColor = Color.White;// FromArgb(223, 227, 239);
            this.StartPosition = FormStartPosition.CenterScreen;
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
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle5 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle6 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle7 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle8 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.gridControl2 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new OleDragDrop.DNDRichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            gridBaseStyle1.Name = "Row Header";
            gridBaseStyle1.StyleInfo.BaseStyle = "Header";
            gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle2.Name = "Column Header";
            gridBaseStyle2.StyleInfo.BaseStyle = "Header";
            gridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle3.Name = "Standard";
            gridBaseStyle3.StyleInfo.Font.Facename = "Tahoma";
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
            this.gridControl1.ColCount = 55;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(22, 12);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RowCount = 100;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)});
            this.gridControl1.Size = new System.Drawing.Size(297, 295);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.VerticalThumbTrack = true;
			this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // gridControl2
            // 
            gridBaseStyle5.Name = "Row Header";
            gridBaseStyle5.StyleInfo.BaseStyle = "Header";
            gridBaseStyle5.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle5.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle6.Name = "Column Header";
            gridBaseStyle6.StyleInfo.BaseStyle = "Header";
            gridBaseStyle6.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle7.Name = "Standard";
            gridBaseStyle7.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle7.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle8.Name = "Header";
            gridBaseStyle8.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle8.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle8.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle8.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle8.StyleInfo.CellType = "Header";
            gridBaseStyle8.StyleInfo.Font.Bold = true;
            gridBaseStyle8.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle8.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.gridControl2.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle5,
            gridBaseStyle6,
            gridBaseStyle7,
            gridBaseStyle8});
            this.gridControl2.ColCount = 55;
            this.gridControl2.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            this.gridControl2.HorizontalThumbTrack = true;
            this.gridControl2.Location = new System.Drawing.Point(336, 12);
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RowCount = 100;
            this.gridControl2.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 25)});
            this.gridControl2.Size = new System.Drawing.Size(307, 295);
            this.gridControl2.SmartSizeBox = false;
            this.gridControl2.TabIndex = 0;
            this.gridControl2.Text = "gridControl1";
            this.gridControl2.ThemesEnabled = true;
            this.gridControl2.VerticalThumbTrack = true;
			this.gridControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Controls.Add(this.gridControl2);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 473);
            this.panel1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.AcceptsTab = true;
            this.richTextBox1.AllowDrop = true;
            this.richTextBox1.AutoWordSelection = true;
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(22, 322);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ShowSelectionMargin = true;
            this.richTextBox1.Size = new System.Drawing.Size(621, 135);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
			this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(663, 473);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "OLE Drag-and-Drop Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            this.panel1.ResumeLayout(false);
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

        #region Event handlers

        private void Form1_Load(object sender, EventArgs e)
		{
			this.gridControl1.DragOver+=new DragEventHandler(gridControl1_DragOver);
			this.gridControl2.DragOver+=new DragEventHandler(gridControl2_DragOver);
		}

		private void gridControl1_DragOver(object sender, DragEventArgs e)
		{
			e.Effect=DragDropEffects.Copy;
		}

		private void gridControl2_DragOver(object sender, DragEventArgs e)
		{
			e.Effect=DragDropEffects.Copy;
        }
        #endregion
    }

	public class DNDRichTextBox : RichTextBox
	{
		
		public DNDRichTextBox()
		{
			this.AllowDrop = true;
			this.DragEnter += new System.Windows.Forms.DragEventHandler(Handle_DragEnter);  
			this.DragDrop += new System.Windows.Forms.DragEventHandler(Handle_DragDrop); 
			this.MouseDown+=new MouseEventHandler(DNDRichTextBox_MouseDown);
		}

		private void Handle_DragEnter(object sender, System.Windows.Forms.DragEventArgs e) 
		{ 		
			if (((DragEventArgs)e).Data.GetDataPresent(DataFormats.Text)) 
				((DragEventArgs)e).Effect = DragDropEffects.Move | DragDropEffects.Copy; 
			else 
				((DragEventArgs)e).Effect = DragDropEffects.None; 
		}

		private void InitializeComponent()
		{
		} 
  
		private void Handle_DragDrop(object sender, DragEventArgs e) 
		{ 
			// Get start position to drop the text.
			int i = this.SelectionStart;
			string s = this.Text.Substring(i);
			this.Text = this.Text.Substring(0, i);

			// Drop the text on to the RichTextBox.
			this.Text = this.Text +	e.Data.GetData(DataFormats.Text).ToString()+ s;

			// Loads the file into the control. 
			//LoadFile((String)e.Data.GetData("Text"), System.Windows.Forms.RichTextBoxStreamType.RichText); 
		}

		private void DNDRichTextBox_MouseDown(object sender, MouseEventArgs e)
		{
			if(this.SelectionLength >0)
				DoDragDrop(this.SelectedText, DragDropEffects.Copy);
		}
	}
}
