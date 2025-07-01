#region Copyright Syncfusion Inc. 2001 - 2008
//
//  Copyright Syncfusion Inc. 2001 - 2008. All rights reserved.
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
using ComboboxCells;

namespace GridSample
{
	public class Form1 : MetroForm
    {
        #region Private Members
        internal Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
		internal System.Windows.Forms.PropertyGrid propertyGrid1;
        internal Syncfusion.Windows.Forms.SplitterControl splitterControl1;
        internal DataSet1 dataSet11;
        private System.Windows.Forms.CheckBox CheckBoxMouseEnable;
        private IContainer components;
		private System.Windows.Forms.CheckBox CheckBoxCurrentCellEnable;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;
        internal ButtonAdv button1;
        private EventTracer eventTracer;
        private CheckBox CheckBoxGridEnable;
        private GroupBox groupBox1;
		CurrentCellEventTracer tracer;
        #endregion

        public Form1()
		{
			dataSet11 = new DataSet1();
            eventTracer = new EventTracer();
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


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
            tracer = new CurrentCellEventTracer(this.splitterControl1, this.eventTracer);
			CheckBoxMouseEnable.Checked = tracer.DisplayMouseMessages;
			CheckBoxCurrentCellEnable.Checked = tracer.Enabled;
            #endregion

            #region GridStyleInfo
            GridStyleInfo heading1 = gridControl1.BaseStylesMap["Heading 1"].StyleInfo;
            heading1.TextColor = Color.Blue;//Color.FromArgb( 0xde, 0x64, 0x13 );
            heading1.Font.Facename = "Segoe UI";
			heading1.Font.Size = 12;
			heading1.Font.Bold = false;

			GridStyleInfo heading2 = gridControl1.BaseStylesMap["Heading 2"].StyleInfo;
			heading2.TextColor = Color.Orange;
			heading2.Font.Size = 12;
			heading2.Font.Bold = true;
            #endregion

            #region Trcaer and PropertyGrid
            this.eventTracer.ContextMenu = this.contextMenu1;

			this.propertyGrid1.CausesValidation = false;
			this.splitter1.CausesValidation = false;
			this.panel1.CausesValidation = false;
			this.panel2.CausesValidation = false;

			// read the data from a local XML file
			ReadXml(this.dataSet11, @"Common\Data\GDBDdata.XML");
            #endregion

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
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.splitterControl1 = new Syncfusion.Windows.Forms.SplitterControl();
            this.CheckBoxMouseEnable = new System.Windows.Forms.CheckBox();
            this.CheckBoxCurrentCellEnable = new System.Windows.Forms.CheckBox();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.CheckBoxGridEnable = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.eventTracer = new ComboboxCells.EventTracer();
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
            this.gridControl1.ColCount = 12;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35)});
            this.gridControl1.DefaultColWidth = 110;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.DefaultRowHeight = 20;
            this.gridControl1.FillSplitterPane = true;
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
            this.gridControl1.Size = new System.Drawing.Size(681, 255);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.VerticalThumbTrack = true;
            this.gridControl1.SelectionChanged += new Syncfusion.Windows.Forms.Grid.GridSelectionChangedEventHandler(this.grid_SelectionChanged);
            this.gridControl1.CurrentCellMoved += new Syncfusion.Windows.Forms.Grid.GridCurrentCellMovedEventHandler(this.grid_CurrentCellMoved);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertyGrid1.BackColor = System.Drawing.Color.White;
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(748, 12);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(250, 272);
            this.propertyGrid1.TabIndex = 2;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitterControl1.BackColor = System.Drawing.Color.White;
            this.splitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitterControl1.Controls.Add(this.gridControl1);
            this.splitterControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.splitterControl1.Location = new System.Drawing.Point(26, 12);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(698, 272);
            this.splitterControl1.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.splitterControl1.TabIndex = 6;
            this.splitterControl1.ThemesEnabled = true;
            this.splitterControl1.PaneClosing += new Syncfusion.Windows.Forms.SplitterPaneEventHandler(this.splitterControl1_PaneClosing);
            this.splitterControl1.PaneCreated += new Syncfusion.Windows.Forms.SplitterPaneEventHandler(this.splitterControl1_PaneCreated);
            // 
            // CheckBoxMouseEnable
            // 
            this.CheckBoxMouseEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxMouseEnable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckBoxMouseEnable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxMouseEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CheckBoxMouseEnable.Location = new System.Drawing.Point(43, 58);
            this.CheckBoxMouseEnable.Name = "CheckBoxMouseEnable";
            this.CheckBoxMouseEnable.Size = new System.Drawing.Size(182, 26);
            this.CheckBoxMouseEnable.TabIndex = 7;
            this.CheckBoxMouseEnable.Text = "Enable Mouse Events.";
            this.CheckBoxMouseEnable.CheckedChanged += new System.EventHandler(this.checkBoxMouseMessage_CheckedChanged);
            // 
            // CheckBoxCurrentCellEnable
            // 
            this.CheckBoxCurrentCellEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxCurrentCellEnable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckBoxCurrentCellEnable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxCurrentCellEnable.ForeColor = System.Drawing.Color.Black;
            this.CheckBoxCurrentCellEnable.Location = new System.Drawing.Point(43, 31);
            this.CheckBoxCurrentCellEnable.Name = "CheckBoxCurrentCellEnable";
            this.CheckBoxCurrentCellEnable.Size = new System.Drawing.Size(182, 21);
            this.CheckBoxCurrentCellEnable.TabIndex = 7;
            this.CheckBoxCurrentCellEnable.Text = "Enable CurrentCell Events.";
            this.CheckBoxCurrentCellEnable.CheckedChanged += new System.EventHandler(this.checkBoxEnableTracing_CheckedChanged);
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
            this.panel1.Controls.Add(this.splitterControl1);
            this.panel1.Controls.Add(this.propertyGrid1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 290);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.eventTracer);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 206);
            this.panel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.CheckBoxGridEnable);
            this.groupBox1.Controls.Add(this.CheckBoxCurrentCellEnable);
            this.groupBox1.Controls.Add(this.CheckBoxMouseEnable);
            this.groupBox1.Location = new System.Drawing.Point(748, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 177);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Event Trace Options";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(43, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear Tracer";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckBoxGridEnable
            // 
            this.CheckBoxGridEnable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxGridEnable.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CheckBoxGridEnable.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxGridEnable.ForeColor = System.Drawing.Color.Black;
            this.CheckBoxGridEnable.Location = new System.Drawing.Point(43, 90);
            this.CheckBoxGridEnable.Name = "CheckBoxGridEnable";
            this.CheckBoxGridEnable.Size = new System.Drawing.Size(182, 21);
            this.CheckBoxGridEnable.TabIndex = 9;
            this.CheckBoxGridEnable.Text = "Enable Grid Events.";
            this.CheckBoxGridEnable.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 290);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1020, 10);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // eventTracer
            // 
            this.eventTracer.BackColor = System.Drawing.Color.White;
            this.eventTracer.Enabled = false;
            this.eventTracer.Location = new System.Drawing.Point(26, 18);
            this.eventTracer.Name = "eventTracer";
            this.eventTracer.Size = new System.Drawing.Size(698, 183);
            this.eventTracer.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1020, 496);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grid Control Event Logger Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.splitterControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
#endregion

        #endregion

        #region Event Handlers
        private void Form1_Load(object sender, System.EventArgs e)
		{
			this.gridControl1.DefaultRowHeight = 18;
			this.gridControl1.DefaultColWidth = 70;			
			
			this.gridControl1.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridControl1.ColWidths[1] = 150;
            this.gridControl1.ColWidths[2] = 150;
            eventTracer.BorderStyle = BorderStyle.FixedSingle;
            eventTracer.output.ControllerOptions = GridControllerOptions.All & (~GridControllerOptions.OleDataSource);

            eventTracer.output.ResetVolatileData();
            eventTracer.output.ColWidths[1] = 200;
            eventTracer.output.ColWidths[2] = 1000;
            eventTracer.output.GridVisualStyles = GridVisualStyles.Metro;
            eventTracer.output.DefaultGridBorderStyle = GridBorderStyle.Solid ;
            eventTracer.output.Properties.GridLineColor = Color.FromArgb(208, 215, 229);
            GridStyleInfo style = eventTracer.output.BaseStylesMap["Header"].StyleInfo;
            style.TextColor = Color.MidnightBlue;
            style.Font.Facename = "Segoe UI";

            eventTracer.output.RowHeights[0] = 0;
            eventTracer.output.ColWidths[0] = 0;
            eventTracer.output.RowCount = 0;
            eventTracer.output.ColCount = 2;
            eventTracer.output.ListBoxSelectionMode = SelectionMode.One;
            eventTracer.output.QueryCellInfo += new GridQueryCellInfoEventHandler(output_QueryCellInfo);
            this.gridControl1.QueryRowHeight += new GridRowColSizeEventHandler(gridControl1_QueryRowHeight);
        }

        void gridControl1_QueryRowHeight(object sender, GridRowColSizeEventArgs e)
        {
            if (e.Index > 0)
            {
                e.Size = 25;
                e.Handled = true;
            }
        }

        void output_QueryCellInfo(object sender, GridQueryCellInfoEventArgs e)
        {
            e.Style.CellType = "Static";
        }

		private void checkBoxMouseMessage_CheckedChanged(object sender, System.EventArgs e)
		{
			//tracer.DisplayMouseMessages = checkBoxMouseMessage.Checked;
            if (CheckBoxMouseEnable.Checked)
            {
                eventTracer.mouseCheck = "Mouse";
            }
            else
            {
                eventTracer.mouseCheck = "";
            }
		}

		private void checkBoxEnableTracing_CheckedChanged(object sender, System.EventArgs e)
		{
			//eventTracer.Enabled = this.enableCurrentCell.Checked;
            if (CheckBoxCurrentCellEnable.Checked)
            {
                eventTracer.cellCheck = "Cell";
            }
            else
            {
                eventTracer.cellCheck = "";
            }
        }

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
            this.eventTracer.output.Clear(true);
            this.eventTracer.output.RowCount = 0;
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

		private void splitter1_SplitterMoved(object sender, System.Windows.Forms.SplitterEventArgs e)
		{
		
		}

        private void button1_Click(object sender, EventArgs e)
        {
            eventTracer.clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxGridEnable.Checked)
            {
                eventTracer.gridCheck = "Grid";
            }
            else
            {
                eventTracer.gridCheck = "";
            }
        }
#endregion

	}
}
