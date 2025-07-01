

namespace FolderBrowser
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using Syncfusion.Windows.Forms.Grid;
	using System.Runtime.Serialization;
	using System.Runtime.Serialization.Formatters.Binary;
	using System.IO;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class TreeGridForm : Syncfusion.Windows.Forms.MetroForm 
	{
		private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
		private System.Windows.Forms.ImageList imageList1;
		private System.ComponentModel.IContainer components;

		static public int NoChildBMP;
		static public int OpenedBMP;
		static public int ClosedBMP;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private Syncfusion.Windows.Forms.Tools.ComboBoxAdv comboBox1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;


		//sample data members...
		public static CollapsibleDataSource externalData;

		public TreeGridForm()
		{
			NoChildBMP = 2;
			OpenedBMP = 0;
			ClosedBMP = 1;
			
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			gridControl1.ControllerOptions = GridControllerOptions.All & (~GridControllerOptions.OleDataSource);
            
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle9 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle10 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle11 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle12 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo13 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo14 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo15 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo16 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo17 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo18 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TreeGridForm));
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.AllowSelection = ((Syncfusion.Windows.Forms.Grid.GridSelectionFlags)(((((((Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Row | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Table) 
            | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Cell) 
            | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Multiple) 
            | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Shift) 
            | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Keyboard) 
            | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.AlphaBlend)));
            this.gridControl1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gridControl1.BackColor = System.Drawing.Color.White;
            gridBaseStyle9.Name = "Header";
            gridBaseStyle9.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle9.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle9.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle9.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle9.StyleInfo.CellType = "Header";
            gridBaseStyle9.StyleInfo.Font.Bold = true;
            gridBaseStyle9.StyleInfo.Font.Facename = "Verdana";
            gridBaseStyle9.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle9.StyleInfo.TextColor = System.Drawing.Color.MidnightBlue;
            gridBaseStyle9.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle10.Name = "Standard";
            gridBaseStyle10.StyleInfo.Font.Facename = "Verdana";
            gridBaseStyle10.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle10.StyleInfo.TextColor = System.Drawing.Color.MidnightBlue;
            gridBaseStyle11.Name = "Row Header";
            gridBaseStyle11.StyleInfo.BaseStyle = "Header";
            gridBaseStyle11.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle11.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle12.Name = "Column Header";
            gridBaseStyle12.StyleInfo.BaseStyle = "Header";
            gridBaseStyle12.StyleInfo.Font.Facename = "Verdana";
            gridBaseStyle12.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            this.gridControl1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle9,
            gridBaseStyle10,
            gridBaseStyle11,
            gridBaseStyle12});
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridControl1.ColCount = 5;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(4, 89)});
            this.gridControl1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            gridCellInfo13.Col = -1;
            gridCellInfo13.Row = -1;
            gridCellInfo13.StyleInfo.Font.Bold = false;
            gridCellInfo13.StyleInfo.Font.Facename = "Verdana";
            gridCellInfo13.StyleInfo.Font.Italic = false;
            gridCellInfo13.StyleInfo.Font.Size = 8.25F;
            gridCellInfo13.StyleInfo.Font.Strikeout = false;
            gridCellInfo13.StyleInfo.Font.Underline = false;
            gridCellInfo13.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo14.Col = 1;
            gridCellInfo14.Row = 0;
            gridCellInfo14.StyleInfo.Text = "Name";
            gridCellInfo15.Col = 2;
            gridCellInfo15.Row = 0;
            gridCellInfo15.StyleInfo.Text = "Size";
            gridCellInfo16.Col = 3;
            gridCellInfo16.Row = 0;
            gridCellInfo16.StyleInfo.Text = "Path";
            gridCellInfo17.Col = 4;
            gridCellInfo17.Row = 0;
            gridCellInfo17.StyleInfo.Text = "Modified Time";
            gridCellInfo17.StyleInfo.Themed = true;
            gridCellInfo18.Col = 5;
            gridCellInfo18.Row = 0;
            gridCellInfo18.StyleInfo.Text = "Type";
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo13,
            gridCellInfo14,
            gridCellInfo15,
            gridCellInfo16,
            gridCellInfo17,
            gridCellInfo18});
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(-1, 50);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            this.gridControl1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.HideAlways;
            this.gridControl1.Size = new System.Drawing.Size(653, 407);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.VerticalThumbTrack = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(100)))), ((int)(((byte)(19)))));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Logical Drives";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 462);
            this.panel1.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Navy;
            this.checkBox1.Location = new System.Drawing.Point(407, 12);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(216)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Hide Details";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckedChanged += new Syncfusion.Windows.Forms.Tools.CheckedChangedEventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.Location = new System.Drawing.Point(162, 13);
            this.comboBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 23);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "[select drive]";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TreeGridForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(681, 489);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TreeGridForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grid Folder Browser Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
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
			Application.Run(new TreeGridForm());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			string[] drives = System.IO.Directory.GetLogicalDrives();
			foreach( string drv in drives )
				this.comboBox1.Items.Add( drv );
			this.comboBox1.SelectedIndex = 0;

			//add a custom cell control
			gridControl1.CellModels.Add("TreeCell", new TreeCellModel(gridControl1.Model));

			//make the imagelist available thru the tablestyle
			gridControl1.TableStyle.ImageList = this.imageList1;

			//create a sample data for a virtual grid
			externalData = new CollapsibleDataSource( this.comboBox1.SelectedItem.ToString() );
			externalData.InitData(); //initializes an external datasource
			externalData.CollapseData(); // c

			//hook up the events needed for virtual grid
			gridControl1.ResetVolatileData();
			gridControl1.QueryCellInfo += new GridQueryCellInfoEventHandler(GridQueryCellInfo);
			gridControl1.QueryRowCount += new GridRowColCountEventHandler(GridQueryRowCount);
			gridControl1.QueryColCount += new GridRowColCountEventHandler(GridQueryColCount);
			//gridControl1.QueryColWidth += new GridRowColSizeEventHandler(GridQueryColWidth);
			
			//handle saving data back to the data source...
			gridControl1.SaveCellInfo += new GridSaveCellInfoEventHandler(GridSaveCellInfo);
			this.gridControl1.DefaultRowHeight = 18;
			this.gridControl1.DefaultColWidth = 100;			
			this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.None;
			this.gridControl1.Properties.RowHeaders = false;
			this.gridControl1.CellDoubleClick+=new GridCellClickEventHandler(gridControl1_CellDoubleClick);
			this.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table());
			this.gridControl1.TableStyle.Trimming = StringTrimming.EllipsisCharacter;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.ListBoxSelectionMode = SelectionMode.One;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
		}
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

		void GridSaveCellInfo(object sender, GridSaveCellInfoEventArgs e)
		{
			try
			{
				//move the changes back to the external data object
				if(e.ColIndex == 1 && e.RowIndex > 0)
				{
					externalData[e.RowIndex - 1].ExpandState = (int) e.Style.ImageIndex;
					externalData[e.RowIndex - 1].IndentLevel = (int) e.Style.Tag;
				}

				if( e.ColIndex > 0 && e.RowIndex > 0)
				{
					externalData[e.RowIndex - 1].Items[e.ColIndex - 1] = (string) e.Style.CellValue;

				}
			}
			catch{}

			//refresh this row so change is displayed
			if(!externalData.Locked)
			{
				externalData.CollapseData();
				this.gridControl1.Refresh();
			}
			e.Handled = true;
		}

		void GridQueryColWidth(object sender, GridRowColSizeEventArgs e) 
		{
			if( e.Index == 1 || e.Index == 3)
				e.Size = 500;
			else if (e.Index > 0)
				e.Size = 100;
			else
				e.Size = 0;//hide the header

			e.Handled = true;
		}
		void GridQueryRowCount(object sender, GridRowColCountEventArgs e) 
		{
			if(externalData != null)
				e.Count = externalData.RowCount;
			e.Handled = true;
		}

		void GridQueryColCount(object sender, GridRowColCountEventArgs e) 
		{
			if(externalData != null)
				e.Count = externalData.ColCount;
			e.Handled = true;
		}

		void GridQueryCellInfo(object sender, GridQueryCellInfoEventArgs e) 
		{
			if (e.RowIndex > 0 && e.ColIndex > 0)
			{
				if(externalData != null)
				{
					e.Style.CellValue = externalData[e.RowIndex - 1].Items[e.ColIndex - 1];
					if (e.ColIndex == 1)
					{
						e.Style.CellType = "TreeCell";
						e.Style.Tag = externalData[e.RowIndex - 1].IndentLevel;
						e.Style.ImageIndex = (int) externalData[e.RowIndex - 1].ExpandState;
					}
				}
				e.Handled = true;

				if(e.ColIndex == 2)
				{
					double value = double.Parse(e.Style.Text);
					if(value < 1024)
					{
						e.Style.CellValue = value + " B";
					}
					else if(value < 1048575)
					{
						value = Math.Floor(value/1024);
						e.Style.CellValue = value + " KB";
					}
					else if(value < 1073741824)
					{
						value = Math.Floor(value/1048575);
						e.Style.CellValue = value + " MB";
					}
					else if(value > 1073741824)
					{
						value = Math.Floor(value/1073741824);
						e.Style.CellValue = value + " GB";
					}
				}
			}

		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			externalData = new CollapsibleDataSource( this.comboBox1.SelectedItem.ToString() );
			if(externalData.IsEmpty)
				externalData = null;
			else
			{
				externalData.InitData();
				externalData.CollapseData();
			}
			if(TreeCellRenderer.nodeList != null )
				TreeCellRenderer.nodeList.Clear();
			gridControl1.ResetVolatileData();
			gridControl1.Refresh();
		}

		private void gridControl1_CellDoubleClick(object sender, GridCellClickEventArgs e)
		{
			if( e.RowIndex > 0 && e.ColIndex == 1 )
			{
				if(this.gridControl1[e.RowIndex, e.ColIndex].ImageIndex == (int) TreeNodeState.Opened)
				{
					this.gridControl1[e.RowIndex, e.ColIndex].ImageIndex = (int) TreeNodeState.Closed;
				}
				else if(this.gridControl1[e.RowIndex, e.ColIndex].ImageIndex == (int) TreeNodeState.Closed)
				{
					this.gridControl1[e.RowIndex, e.ColIndex].ImageIndex = (int) TreeNodeState.Opened;
					if(! TreeCellRenderer.nodeList.Contains(this.gridControl1[e.RowIndex, 3].Text))
					{
						int indent = externalData[e.RowIndex-1].IndentLevel;
						externalData.InsertData(e.RowIndex, this.gridControl1[e.RowIndex,3].Text, indent);
						TreeCellRenderer.nodeList.Add(this.gridControl1[e.RowIndex,3].Text,"Added");
					}
					this.gridControl1.Refresh();
					this.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table());
				}
			}
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox1.Checked)
			{
				this.gridControl1.Cols.Hidden[2] = true;
				this.gridControl1.Cols.Hidden[3] = true;
				this.gridControl1.Cols.Hidden[4] = true;
				this.gridControl1.Cols.Hidden[5] = true;
			}
			else
			{
				this.gridControl1.Cols.Hidden[2] = false;
				this.gridControl1.Cols.Hidden[3] = false;
				this.gridControl1.Cols.Hidden[4] = false;
				this.gridControl1.Cols.Hidden[5] = false;
			}
		}
	}
}
