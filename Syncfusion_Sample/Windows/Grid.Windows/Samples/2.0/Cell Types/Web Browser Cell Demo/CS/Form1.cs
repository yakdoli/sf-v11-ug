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
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Diagnostics;
using Syncfusion.Styles;

namespace GridSample
{
	public class Form1 : MetroForm
    {
        #region Private Members
        internal Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        internal Syncfusion.Windows.Forms.ButtonAdv printPreviewButton;
		internal System.Windows.Forms.PropertyGrid propertyGrid1;
		internal Syncfusion.Windows.Forms.SplitterControl splitterControl1;
		internal System.Windows.Forms.ListBox output;
        internal DataSet1 dataSet11;
        private System.Windows.Forms.CheckBox checkBoxMouseMessage;
        private IContainer components;
		private System.Windows.Forms.CheckBox checkBoxEnableTracing;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
        private GroupBox groupBox1;
		CurrentCellEventTracer tracer;
        #endregion

        public Form1()
		{
			dataSet11 = new DataSet1();

			InitializeComponent();

            #region Splitter
            this.ActiveControl = this.splitterControl1;
			splitterControl1.ThemesEnabled = true;
            #endregion

            #region Grid
            gridControl1.Initialize();
			gridControl1.ThemesEnabled = true;
			gridControl1.ControllerOptions &= ~(GridControllerOptions.OleDataSource|GridControllerOptions.OleDropTarget);
			gridControl1.CurrentCell.MoveTo(1, 1);
			gridControl1.BaseStylesMap["Header"].StyleInfo.Enabled = false;
			gridControl1.VScrollPixel = true;
			gridControl1.HScrollPixel = true;
            #endregion

            #region Tracer
            tracer = new CurrentCellEventTracer(this.splitterControl1, this.output);
			checkBoxMouseMessage.Checked = tracer.DisplayMouseMessages;
			checkBoxEnableTracing.Checked = tracer.Enabled;
            #endregion

            #region GridStyleInfo
            GridStyleInfo heading1 = gridControl1.BaseStylesMap["Heading 1"].StyleInfo;
			heading1.TextColor = Color.Blue;
			heading1.Font.Size = 14;
			heading1.Font.Bold = true;

			GridStyleInfo heading2 = gridControl1.BaseStylesMap["Heading 2"].StyleInfo;
			heading2.TextColor = Color.Blue;
			heading2.Font.Size = 14;
			heading2.Font.Bold = true;
            #endregion

            #region PropertyGrid
            this.output.ContextMenu = this.contextMenu1;
			this.propertyGrid1.CausesValidation = false;
			this.splitter1.CausesValidation = false;
			this.panel1.CausesValidation = false;
			this.panel2.CausesValidation = false;
            #endregion

            // read the data from a local XML file
			ReadXml(this.dataSet11, @"Data\GDBDdata.XML");
        }

        #region Form Handlers
        //hunt the folder tree for the data\*.xml file..
		void ReadXml(DataSet ds, string xmlFileName)
		{
			if (ds == null)
				return;

			for (int n = 0; n < 10; n++)
			{
				if (System.IO.File.Exists(xmlFileName))
				{
					ds.ReadXml(xmlFileName);
					break;
				}
				xmlFileName = @"..\" + xmlFileName;
			}
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
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo3 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.printPreviewButton = new Syncfusion.Windows.Forms.ButtonAdv();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.splitterControl1 = new Syncfusion.Windows.Forms.SplitterControl();
            this.output = new System.Windows.Forms.ListBox();
            this.checkBoxMouseMessage = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableTracing = new System.Windows.Forms.CheckBox();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.splitterControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            gridBaseStyle9.Name = "Row Header";
            gridBaseStyle9.StyleInfo.BaseStyle = "Header";
            gridBaseStyle9.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle9.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle10.Name = "Column Header";
            gridBaseStyle10.StyleInfo.BaseStyle = "Header";
            gridBaseStyle10.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle11.Name = "Standard";
            gridBaseStyle11.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle11.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle12.Name = "Header";
            gridBaseStyle12.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle12.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle12.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle12.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle12.StyleInfo.CellType = "Header";
            gridBaseStyle12.StyleInfo.Font.Bold = true;
            gridBaseStyle12.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle12.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            this.gridControl1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle9,
            gridBaseStyle10,
            gridBaseStyle11,
            gridBaseStyle12});
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 12;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.DefaultRowHeight = 20;
            this.gridControl1.FillSplitterPane = true;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.gridControl1.ForeColor = System.Drawing.Color.MidnightBlue;
            gridCellInfo3.Col = -1;
            gridCellInfo3.Row = -1;
            gridCellInfo3.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo3.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo3.StyleInfo.Font.Bold = false;
            gridCellInfo3.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo3.StyleInfo.Font.Italic = false;
            gridCellInfo3.StyleInfo.Font.Size = 8.5F;
            gridCellInfo3.StyleInfo.Font.Strikeout = false;
            gridCellInfo3.StyleInfo.Font.Underline = false;
            gridCellInfo3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo3.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo3});
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowCount = 120;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(609, 322);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.VerticalThumbTrack = true;
            this.gridControl1.SelectionChanged += new Syncfusion.Windows.Forms.Grid.GridSelectionChangedEventHandler(this.grid_SelectionChanged);
            this.gridControl1.CurrentCellMoved += new Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventHandler(this.grid_CurrentCellMoved);
            // 
            // printPreviewButton
            // 
            this.printPreviewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printPreviewButton.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.printPreviewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.printPreviewButton.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.printPreviewButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printPreviewButton.ForeColor = System.Drawing.Color.White;
            this.printPreviewButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printPreviewButton.Location = new System.Drawing.Point(699, 139);
            this.printPreviewButton.Name = "printPreviewButton";
            this.printPreviewButton.Size = new System.Drawing.Size(165, 34);
            this.printPreviewButton.TabIndex = 1;
            this.printPreviewButton.Text = "Print Preview";
            this.printPreviewButton.UseVisualStyle = true;
            this.printPreviewButton.UseVisualStyleBackColor = true;
            this.printPreviewButton.Click += new System.EventHandler(this.printPreviewButton_Click);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsBackColor = System.Drawing.Color.White;
            this.propertyGrid1.CommandsLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(659, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(263, 317);
            this.propertyGrid1.TabIndex = 2;
            // 
            // splitterControl1
            // 
            this.splitterControl1.BackColor = System.Drawing.Color.White;
            this.splitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.splitterControl1.Controls.Add(this.gridControl1);
            this.splitterControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.splitterControl1.Location = new System.Drawing.Point(12, 0);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(626, 339);
            this.splitterControl1.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.ThemesEnabled = true;
            this.splitterControl1.PaneClosing += new Syncfusion.Windows.Forms.SplitterPaneEventHandler(this.splitterControl1_PaneClosing);
            this.splitterControl1.PaneCreated += new Syncfusion.Windows.Forms.SplitterPaneEventHandler(this.splitterControl1_PaneCreated);
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(21)))), ((int)(((byte)(84)))));
            this.output.ItemHeight = 15;
            this.output.Location = new System.Drawing.Point(12, 6);
            this.output.Name = "output";
            this.output.ScrollAlwaysVisible = true;
            this.output.Size = new System.Drawing.Size(612, 182);
            this.output.TabIndex = 4;
            // 
            // checkBoxMouseMessage
            // 
            this.checkBoxMouseMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxMouseMessage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxMouseMessage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMouseMessage.Location = new System.Drawing.Point(31, 62);
            this.checkBoxMouseMessage.Name = "checkBoxMouseMessage";
            this.checkBoxMouseMessage.Size = new System.Drawing.Size(165, 33);
            this.checkBoxMouseMessage.TabIndex = 7;
            this.checkBoxMouseMessage.Text = "Trace Mouse and Control Messages";
            this.checkBoxMouseMessage.CheckedChanged += new System.EventHandler(this.checkBoxMouseMessage_CheckedChanged);
            // 
            // checkBoxEnableTracing
            // 
            this.checkBoxEnableTracing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEnableTracing.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxEnableTracing.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEnableTracing.Location = new System.Drawing.Point(31, 36);
            this.checkBoxEnableTracing.Name = "checkBoxEnableTracing";
            this.checkBoxEnableTracing.Size = new System.Drawing.Size(183, 20);
            this.checkBoxEnableTracing.TabIndex = 7;
            this.checkBoxEnableTracing.Text = "Enable Tracing";
            this.checkBoxEnableTracing.CheckedChanged += new System.EventHandler(this.checkBoxEnableTracing_CheckedChanged);
            // 
            // contextMenu1
            // 
            this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "&Clear Window";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.splitterControl1);
            this.panel1.Controls.Add(this.propertyGrid1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(926, 342);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.printPreviewButton);
            this.panel2.Controls.Add(this.output);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 363);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(926, 210);
            this.panel2.TabIndex = 9;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 342);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(926, 15);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxEnableTracing);
            this.groupBox1.Controls.Add(this.checkBoxMouseMessage);
            this.groupBox1.Location = new System.Drawing.Point(668, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 115);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event trace Options";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(926, 573);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Web Browser Cell Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.splitterControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
#endregion

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
        #endregion

        #region Event Handlers
        private void Form1_Load(object sender, System.EventArgs e)
        {
            System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
            this.Icon = ico;
            this.gridControl1.DefaultRowHeight = 18;
            this.gridControl1.DefaultColWidth = 70;
            this.splitterControl1.HSplitPos = 80;
            this.splitter1.SplitPosition = this.Height - this.panel2.Height / 2;
        }
		
		private void printPreviewButton_Click(object sender, System.EventArgs e)
		{
			if (gridControl1 != null)
			{
				try 
				{
					GridControl grid = this.splitterControl1.ActivePane as GridControl;
					if (grid != null)
					{
						GridPrintDocument pd = new GridPrintDocument(gridControl1, true); //Assumes the default printer

						PrintPreviewDialog dlg = new PrintPreviewDialog() ;
						dlg.Document = pd;
						dlg.ShowDialog();
					}
				} 
				catch(Exception ex) 
				{ 
					MessageBox.Show("An error occurred attempting to preview the file to print - " + ex.Message);
				}
			}

		}

		private void checkBoxMouseMessage_CheckedChanged(object sender, System.EventArgs e)
		{
			tracer.DisplayMouseMessages = checkBoxMouseMessage.Checked;
		}

		private void checkBoxEnableTracing_CheckedChanged(object sender, System.EventArgs e)
		{
			tracer.Enabled = this.checkBoxEnableTracing.Checked;
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			this.output.Items.Clear();
		}

		private void splitterControl1_PaneClosing(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
		{
			GridControl grid = (GridControl) e.Control;
			grid.CurrentCellMoved -= new Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventHandler(this.grid_CurrentCellMoved);
			grid.SelectionChanged -= new GridSelectionChangedEventHandler(grid_SelectionChanged);
		}

		private void splitterControl1_PaneCreated(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
		{
			GridControl grid = (GridControl) e.Control;
			grid.CurrentCellMoved += new Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventHandler(this.grid_CurrentCellMoved);
			grid.SelectionChanged += new GridSelectionChangedEventHandler(grid_SelectionChanged);
		}

		private void grid_CurrentCellMoved(object sender, Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventArgs e)
		{
			grid = (GridControlBase) sender;
			DelayRefreshPropertyGrid(GridRangeInfo.Cell(grid.CurrentCell.RowIndex, grid.CurrentCell.ColIndex), 50);
		}

		private void grid_SelectionChanged(object sender, GridSelectionChangedEventArgs e)
		{
			DelayRefreshPropertyGrid(e.Range, 200);
		}

		private GridRangeInfo range = GridRangeInfo.Empty;
		private GridStyleInfo style = null;
		private GridControlBase grid = null;
		bool refreshPropertyGridNextIdle = false;
		Timer refreshTimer = null;

		private void DelayRefreshPropertyGrid(GridRangeInfo range, int interval)
		{
			if (refreshTimer != null)
			{
				refreshPropertyGridNextIdle = false;
				refreshTimer.Stop();
			}
			else
			{
				refreshTimer = new Timer();
				refreshTimer.Interval = interval;
				refreshTimer.Tick += new EventHandler(DelayedRefreshPropertyGrid);
			}
			refreshTimer.Start();
			refreshPropertyGridNextIdle = true;
			this.range = range;
		}

		void DelayedRefreshPropertyGrid(object sender, EventArgs e)
		{
			TraceUtil.TraceCurrentMethodInfo();
			Timer t = sender as Timer;
			t.Dispose();
			this.refreshTimer = null;

			if (refreshPropertyGridNextIdle)
				RefreshPropertyGrid();
		}

		public void RefreshPropertyGrid()
		{
			{
				refreshPropertyGridNextIdle = false;
				if (style != null)
				{
					style.Changed -= new StyleChangedEventHandler(GridStyleInfoChanged);
				}
				
				grid = (GridControlBase) splitterControl1.ActivePane;
				style = grid.Model.GetCombinedStyle(range);
				if (style != null)
				{
					propertyGrid1.SelectedObject = style;
					style.Changed += new StyleChangedEventHandler(GridStyleInfoChanged);
				}
				else
					range = GridRangeInfo.Empty;
			}
		}

		public void ShowPropertyGridItem(string category, string label)
		{
			RefreshPropertyGrid(); 
			GridItem gi = propertyGrid1.SelectedGridItem;
			while (gi != null && gi.GridItemType != GridItemType.Root)
				gi = gi.Parent;

			if (gi != null)
			{
				// Categories
				GridItemCollection categories = gi.GridItems;
				GridItem sliderCategory = categories[category];
				if (sliderCategory != null)
				{
					GridItemCollection items = sliderCategory.GridItems;
					GridItem item;
					if (label == "")
						item = items[Math.Min(10, items.Count-1)];
					else
						item = items[label];
					item.Select();
					if (item.Expandable)
					{
						propertyGrid1.ExpandAllGridItems();
						items = item.GridItems;
						items[Math.Min(10, items.Count-1)].Select();
					}
				}
			}
			RefreshPropertyGrid(); 
		}

		void GridStyleInfoChanged(object sender, StyleChangedEventArgs e)
		{
			if (!refreshPropertyGridNextIdle && !range.IsEmpty && grid != null && style != null)
			{
				grid.Model.ChangeCells(range, style, StyleModifyType.Changes);
			}
		}

        #endregion

    }


}
