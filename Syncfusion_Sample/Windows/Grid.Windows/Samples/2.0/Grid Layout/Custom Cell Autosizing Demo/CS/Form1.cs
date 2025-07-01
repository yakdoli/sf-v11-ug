using System;
using System.Drawing;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.IO;
using System.Reflection;

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Diagnostics;
using Syncfusion.Windows.Forms.Tools;

namespace CustomCellAutoSizing
{
	public class Form1 : MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv checkBox1;
		public bool usePreferredClientSize = true;
		private System.Windows.Forms.Panel panel1;
		private System.ComponentModel.IContainer components=null;
        #endregion

        public Form1()
		{
			InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            #region GridSettings
            this.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Blue;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;
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
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle1 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle2 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            this.panel1.SuspendLayout();
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
            gridBaseStyle3.StyleInfo.Font.Facename = "Tahoma";
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
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 11;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(1, 176),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(2, 66)});
            this.gridControl1.DefaultRowHeight = 20;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.Location = new System.Drawing.Point(-2, -2);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            gridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle1.StyleInfo.Font.Bold = false;
            gridRangeStyle1.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle1.StyleInfo.Font.Italic = false;
            gridRangeStyle1.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle1.StyleInfo.Font.Strikeout = false;
            gridRangeStyle1.StyleInfo.Font.Underline = false;
            gridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle2.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle2.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle2.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle2.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl1.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
            gridRangeStyle1,
            gridRangeStyle2});
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(1, 17),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(2, 18),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(3, 17),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(4, 18)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(590, 416);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ThemesEnabled = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DrawFocusRectangle = false;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(510, 438);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(90, 24);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Resize To Fit";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckedChanged += new Syncfusion.Windows.Forms.Tools.CheckedChangedEventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 420);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(612, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkBox1);
            this.DropShadow = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
			this.BorderThickness = 2;
            this.Text = "Custom Cell Auotsizing Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
        }

        #endregion


        #region Event Handlers

        private void Form1_Load(object sender, System.EventArgs e)
        {
            InitializeForm();
        }
        int colsize, rowsize;
        void InitializeForm()
        {
            gridControl1.BeginUpdate();
            gridControl1.ThemesEnabled = true;
            gridControl1.TableStyle.FloatCell = true;
            gridControl1.FloatCellsMode = GridFloatCellsMode.OnDemandCalculation;
            gridControl1.AllowSelection = GridSelectionFlags.Any;
            //Register Custom Cell Types
            this.gridControl1.CellModels.Add("Slider", new CustomControlCellModel(this.gridControl1.Model));
            this.gridControl1.CellModels.Add("DataEntry", new CustomControlCellModel(gridControl1.Model));
            this.gridControl1.CellModels.Add("ChoiceList", new CustomControlCellModel(gridControl1.Model));

            Control control;
            GridStyleInfo style;

            //Setup DataEntry Cell
            style = gridControl1[2, 2];
            style.CellType = "DataEntry";
            control = new DataEntryControl();
            MakeUnBuffered(control);
            //Pass the type of CellControl to cell model class through its Tag
            style.Tag = control;

            //Setup ChoiceList Cell
            style = gridControl1[3, 3];
            style.CellType = "ChoiceList";
            control = new ChoiceListControl();
            MakeUnBuffered(control);
            //Pass the type of CellControl to cell model class through its Tag
            style.Tag = control;

            //Setup Slider Cell
            style = gridControl1[4, 4];
            style.CellType = "Slider";
            //Pass the type of CellControl to cell model class through its Tag
            style.Tag = new TrackBar();

            colsize = gridControl1.ColWidths[2];
            rowsize = gridControl1.RowHeights[2];

            //Call ResizeToFit which in turn calls OnQueryPreferredClientSize method in the cell model class
            //in order to retrieve the Correct size of the controls in grid cells and adjust respective 
            //RowHeights & ColWidths in order to make the cells to fit controls.
            gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Table());
            gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table());

            gridControl1.EndUpdate(true);
            //gridControl1.ResizingColumns += new GridResizingColumnsEventHandler(gridControl1_ResizingColumns);
            //gridControl1.ResizingRows += new GridResizingRowsEventHandler(gridControl1_ResizingRows);
            Application.Idle += new EventHandler(Application_Idle);
            for (int i = 1; i <= 4; i++)
            {
                widths.Add(i, gridControl1.ColWidths[i]);
            }
        }
        Hashtable widths = new Hashtable();
        void Application_Idle(object sender, EventArgs e)
        {
            for (int i = 1; i <= 4; i++)
            {
                if (gridControl1.ColWidths[i] < int.Parse(widths[i].ToString()))
                    gridControl1.ColWidths[i] = int.Parse(widths[i].ToString());
            }
        }

        private void gridControl1_ResizingColumns(object sender, GridResizingColumnsEventArgs e)
        {
            Control c = null;
            if (gridControl1[e.Columns.Left, e.Columns.Left].Tag != null)
                c = gridControl1[e.Columns.Left, e.Columns.Left].Tag as Control;
            else if (gridControl1[e.Columns.Right, e.Columns.Right].Tag != null)
                c = gridControl1[e.Columns.Right, e.Columns.Right].Tag as Control;

            if (c != null && gridControl1.ColWidths[e.Columns.Left] < c.Size.Width + 2)
                e.Cancel = true;
        }

        private void gridControl1_ResizingRows(object sender, GridResizingRowsEventArgs e)
        {

        }
        private void MakeUnBuffered(Control control)
        {

            System.Reflection.MethodInfo mInfo = typeof(Control).GetMethod("SetStyle",
                System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.InvokeMethod |
                System.Reflection.BindingFlags.NonPublic);
            if (mInfo != null)
            {
                mInfo.Invoke(control, new

                    object[] { Syncfusion.Windows.Forms.WhidbeyCompatibleControlStyles.DoubleBuffer, false });
            }
            foreach (Control cc in control.Controls)
            {
                cc.CausesValidation = false;
                MakeUnBuffered(cc);
            }
        }
        void checkBox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                gridControl1.BeginUpdate();
                gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Table());
                gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table());
                gridControl1.EndUpdate(true);
            }
            else
            {
                for (int i = 2; i <= 6; i++)
                {
                    gridControl1.RowHeights[i] = rowsize;
                    gridControl1.ColWidths[i] = colsize;
                }
            }
            this.gridControl1.Refresh();
        }
        #endregion
		
	}
}
