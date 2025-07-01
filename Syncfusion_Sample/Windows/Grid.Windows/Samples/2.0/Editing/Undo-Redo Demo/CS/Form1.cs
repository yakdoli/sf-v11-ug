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

namespace UndoRedoSample
{
	using System;
	using System.Drawing;
	using System.Collections;
	using System.ComponentModel;
	using System.Windows.Forms;
	using System.Data;
	using Syncfusion.Windows.Forms.Grid;
	using Syncfusion.ComponentModel;
    using Syncfusion.Windows.Forms;

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		#region members
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;

		//needed to conditionally display new stacks
		private int oldRedoCount;
        private int oldUndoCount;

        private System.Windows.Forms.Panel panel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem1;
        private ToolStripMenuItem beginToolStripMenuItem;
        private ToolStripMenuItem commitToolStripMenuItem1;
        private ToolStripMenuItem rollBackToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private TextBox textBox2;
        private TextBox textBox1;
		private System.ComponentModel.IContainer components;
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


            #region Grid Properties
            this.gridControl1.DefaultRowHeight = 18;
			this.gridControl1.DefaultColWidth = 70;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.ActivateCurrentCellBehavior = GridCellActivateAction.DblClickOnCell;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            #endregion

            #region Populate the Grid

            //turn off undo buffer so initial population cannot be undone
			this.gridControl1.CommandStack.Enabled = false;

			//call a routine to populate the grid somehow...
			PopulateMyGrid();

			//turn undo buffer back on...
			this.gridControl1.CommandStack.Enabled = true;

			//handle adding list changes -- handler allows the updating of the display
			this.gridControl1.Invalidated += new InvalidateEventHandler(UpdateListBoxes);

			oldRedoCount = 0;
			oldUndoCount = 0;

			this.gridControl1.RowHeights[0]=0;
			this.gridControl1.ColWidths[0]=0;

            this.gridControl1.TableStyle.BackColor = System.Drawing.Color.White;
//			this.gridControl1.ActivateCurrentCellBehavior=GridCellActivateAction.ClickOnCell;
//          this.gridControl1.ShowCurrentCellBorderBehavior=GridShowCurrentCellBorder.WhenGridActive;
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
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.beginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rollBackToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.AllowDragSelectedCols = true;
            this.gridControl1.AllowDragSelectedRows = true;
            this.gridControl1.AllowDrop = true;
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            gridBaseStyle1.Name = "Row Header";
            gridBaseStyle1.StyleInfo.BaseStyle = "Header";
            gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridBaseStyle2.Name = "Column Header";
            gridBaseStyle2.StyleInfo.BaseStyle = "Header";
            gridBaseStyle2.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle3.Name = "Standard";
            gridBaseStyle3.StyleInfo.AllowEnter = false;
            gridBaseStyle3.StyleInfo.AutoSize = false;
            gridBaseStyle3.StyleInfo.BaseStyle = "";
            gridBaseStyle3.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridBaseStyle3.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridBaseStyle3.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridBaseStyle3.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridBaseStyle3.StyleInfo.CellAppearance = Syncfusion.Windows.Forms.Grid.GridCellAppearance.Flat;
            gridBaseStyle3.StyleInfo.CellType = "TextBox";
            gridBaseStyle3.StyleInfo.CellValueType = null;
            gridBaseStyle3.StyleInfo.Clickable = true;
            gridBaseStyle3.StyleInfo.CultureInfo = null;
            gridBaseStyle3.StyleInfo.Description = "";
            gridBaseStyle3.StyleInfo.DropDownStyle = Syncfusion.Windows.Forms.Grid.GridDropDownStyle.Editable;
            gridBaseStyle3.StyleInfo.Enabled = true;
            gridBaseStyle3.StyleInfo.FloatCell = true;
            gridBaseStyle3.StyleInfo.FloodCell = true;
            gridBaseStyle3.StyleInfo.Font.Bold = false;
            gridBaseStyle3.StyleInfo.Font.Facename = "Segoe UI";
            gridBaseStyle3.StyleInfo.Font.Italic = false;
            gridBaseStyle3.StyleInfo.Font.Size = 8.25F;
            gridBaseStyle3.StyleInfo.Font.Strikeout = false;
            gridBaseStyle3.StyleInfo.Font.Underline = false;
            gridBaseStyle3.StyleInfo.Format = "";
            gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle3.StyleInfo.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show;
            gridBaseStyle3.StyleInfo.ImageList = null;
            gridBaseStyle3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle3.StyleInfo.MaxLength = 0;
            gridBaseStyle3.StyleInfo.ReadOnly = false;
            gridBaseStyle3.StyleInfo.ShowButtons = Syncfusion.Windows.Forms.Grid.GridShowButtons.Show;
            gridBaseStyle3.StyleInfo.Text = "";
            gridBaseStyle3.StyleInfo.TextAlign = Syncfusion.Windows.Forms.Grid.GridTextAlign.Default;
            gridBaseStyle3.StyleInfo.TextColor = System.Drawing.Color.MidnightBlue;
            gridBaseStyle3.StyleInfo.TextMargins.Bottom = 1;
            gridBaseStyle3.StyleInfo.TextMargins.Left = 1;
            gridBaseStyle3.StyleInfo.TextMargins.Right = 1;
            gridBaseStyle3.StyleInfo.TextMargins.Top = 1;
            gridBaseStyle3.StyleInfo.Trimming = System.Drawing.StringTrimming.Character;
            gridBaseStyle3.StyleInfo.TriState = false;
            gridBaseStyle3.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Top;
            gridBaseStyle3.StyleInfo.VerticalScrollbar = false;
            gridBaseStyle3.StyleInfo.WrapText = true;
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
            this.gridControl1.DefaultColWidth = 70;
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.DefaultRowHeight = 20;
            this.gridControl1.DragSelectedCellsMouseButtonsMask = System.Windows.Forms.MouseButtons.None;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridCellInfo1.StyleInfo.Font.Facename = "Segoe UI";
            gridCellInfo1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridCellInfo1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl1.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1});
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RowCount = 30;
            this.gridControl1.Size = new System.Drawing.Size(546, 355);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
			this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(565, 221);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(269, 137);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(565, 43);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(269, 122);
            this.listBox2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(12, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 370);
            this.panel1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(565, 192);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(565, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 23);
            this.textBox1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(100, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.transactionsToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem1
            // 
            this.transactionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beginToolStripMenuItem,
            this.commitToolStripMenuItem1,
            this.rollBackToolStripMenuItem1});
            this.transactionsToolStripMenuItem1.Name = "transactionsToolStripMenuItem1";
            this.transactionsToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
            this.transactionsToolStripMenuItem1.Text = "Transactions";
            // 
            // beginToolStripMenuItem
            // 
            this.beginToolStripMenuItem.Name = "beginToolStripMenuItem";
            this.beginToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.beginToolStripMenuItem.Text = "Begin";
            this.beginToolStripMenuItem.Click += new System.EventHandler(this.beginToolStripMenuItem_Click);
            // 
            // commitToolStripMenuItem1
            // 
            this.commitToolStripMenuItem1.Name = "commitToolStripMenuItem1";
            this.commitToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.commitToolStripMenuItem1.Text = "Commit";
            this.commitToolStripMenuItem1.Click += new System.EventHandler(this.commitToolStripMenuItem1_Click);
            // 
            // rollBackToolStripMenuItem1
            // 
            this.rollBackToolStripMenuItem1.Name = "rollBackToolStripMenuItem1";
            this.rollBackToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.rollBackToolStripMenuItem1.Text = "RollBack";
            this.rollBackToolStripMenuItem1.Click += new System.EventHandler(this.rollBackToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 16);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
			this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(868, 378);
            this.Controls.Add(this.panel1);
            this.DropShadow = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Undo-Redo Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		[STAThread]
		public static void Main() 
		{
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif		
			Application.Run(new Form1());
		}
#endregion

		#region Populate the grid
		private void PopulateMyGrid()
		{
			//			//used to time things if desired
			//			int startTime = Environment.TickCount;

			//populate with random numbers
			//just place values directly into style, slow but straight-forward
			Random r = new Random();
			for(int i = 1; i <= this.gridControl1.RowCount; ++i)
				for(int j = 1; j <= this.gridControl1.ColCount; ++j)
					this.gridControl1[i,j].CellValue = r.Next(1000);

			//			//for more efficient population, could use a call to PopulateValues
			//			//for example, this code is more than a factor of ten quicker...
			//			Random r = new Random();
			//			int[,] table = new int[this.gridControl1.RowCount, this.gridControl1.ColCount];
			//			for(int i = 1; i <= this.gridControl1.RowCount; ++i)
			//				for(int j = 1; j <= this.gridControl1.ColCount; ++j)
			//					table[i-1, j-1] = r.Next(1000);
			//
			//			this.gridControl1.PopulateValues(
			//							GridRangeInfo.Cells(1, 1, this.gridControl1.RowCount, this.gridControl1.ColCount),
			//							table); 
		
			//			MessageBox.Show((Environment.TickCount - startTime).ToString() + " ticks");
	

		}

		#endregion

		#region Menu Handlers
		private void EditUndo_Click(object sender, System.EventArgs e)
		{
			if (!this.gridControl1.CommandStack.InTransaction)
			{
				this.gridControl1.CommandStack.Undo();
				ShowStacks();
			}
		}

		private void EditRedo_Click(object sender, System.EventArgs e)
		{
			if (!this.gridControl1.CommandStack.InTransaction)
			{
				this.gridControl1.CommandStack.Redo();
				ShowStacks();
			}
		}

		private void EditClearUndo_Click(object sender, System.EventArgs e)
		{
			if (!this.gridControl1.CommandStack.InTransaction)
			{
				this.gridControl1.CommandStack.UndoStack.Clear();
				ShowStacks();
			}
		}

		private void EditClearRedo_Click(object sender, System.EventArgs e)
		{
			this.gridControl1.CommandStack.RedoStack.Clear();
			ShowStacks();
		}

		private void EditTransactionsBegin_Click(object sender, System.EventArgs e)
		{
			this.gridControl1.CommandStack.BeginTrans("Transaction beginning-");
			ShowStacks();
			//this.toolBeginTrans.ImageIndex = 5;
		}

		private void EditTransactionsCommit_Click(object sender, System.EventArgs e)
		{
			if(this.gridControl1.CommandStack.InTransaction)
			{
				this.gridControl1.CommandStack.CommitTrans();
				//this.toolBeginTrans.ImageIndex = 2;
				ShowStacks();
			}
		}

		private void EditTransactionsRollBack_Click(object sender, System.EventArgs e)
		{
			if(this.gridControl1.CommandStack.InTransaction)
			{
				this.gridControl1.CommandStack.Rollback();
				//this.toolBeginTrans.ImageIndex = 2;
				ShowStacks();
			}
		}
		#endregion

		#region Updates to the display lists

		private void UpdateListBoxes(object sender, InvalidateEventArgs e)
		{
			ShowStacks();
		}

		private void ShowStacks()
		{
			ShowRedoStack();
			ShowUndoStack();
		}

		private void ShowUndoStack()
		{
			int numUndos = this.gridControl1.CommandStack.UndoStack.Count;
			if(numUndos != this.oldUndoCount || this.gridControl1.CommandStack.InTransaction)
			{
				this.listBox1.Items.Clear();
                this.textBox2.Text=string.Format("{0} Undo items", numUndos);
	
				if(numUndos > 0 || this.gridControl1.CommandStack.IsRecording)
					DisplayCommandsInStack(this.gridControl1.CommandStack.UndoStack.ToArray(), "", listBox1, true);
				this.oldUndoCount = numUndos;
			}

		}

		private void ShowRedoStack()
		{
			int numRedos = this.gridControl1.CommandStack.RedoStack.Count;
			if(numRedos != this.oldRedoCount || this.gridControl1.CommandStack.InTransaction)
			{
				this.listBox2.Items.Clear();
                this.textBox1.Text = string.Format("{0} Redo items", numRedos);
				if(numRedos > 0 || this.gridControl1.CommandStack.IsRecording)
					DisplayCommandsInStack(this.gridControl1.CommandStack.RedoStack.ToArray(), "", listBox2, false);
				this.oldRedoCount = numRedos;
			}
		}

		
		private void DisplayCommandsInStack(object[] items, string indent, ListBox _listbox, bool includeCurrentCommand)
		{
			string s;
			SyncfusionCommand c;
			GridTransactionCommand tc;
			int cutOff;

			//handle the case where we are recording a transaction
			if (includeCurrentCommand && this.gridControl1.CommandStack.InTransaction)
			{
				try
				{
					tc = this.gridControl1.CommandStack.CurrentTransactionCommand;
					DisplayCommandsInStack(tc.Stack.ToArray(), "    > ", _listbox, false);
				}
				catch{}
			}

			foreach(object o in items)
			{
				try
				{
					c = (SyncfusionCommand) o;
					if(c != null && c.Description != null)
						s = c.Description;
					else
						s = o.ToString();
					cutOff =  1 + Math.Max(s.LastIndexOf("+"), s.LastIndexOf("."));
					_listbox.Items.Add(indent + s.Substring(cutOff));
				}
				catch{}

				//check if is a transaction command
				try
				{
					tc = o as GridTransactionCommand;
					if(tc != null)
					{
						DisplayCommandsInStack(tc.Stack.ToArray(), "    > ", _listbox, false);
					}
				}
				catch{}

			}

			
		}

		#endregion

        #region Event Handlers
        private void menuHelp_Click(object sender, System.EventArgs e)
		{
			MessageBox.Show("Change some cells, or move columns or rows in the\r\ngrid. You will see the Undo list start to grow. \r\n\r\nClick the Undo button or use the menu to undo an action.\r\n You will see the Redo list change.\r\n\r\nUse the Begin Transaction to start a group of changes that\r\nare treated as a single Undo/Redo command. Use Commit \r\nTransaction to signal the end of a transaction group.");
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
            DemoCommon.AboutForm abtForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            abtForm.ShowDialog();
		}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.gridControl1.CommandStack.InTransaction)
            {
                this.gridControl1.CommandStack.Undo();
                ShowStacks();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.gridControl1.CommandStack.InTransaction)
            {
                this.gridControl1.CommandStack.Redo();
                ShowStacks();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void beginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.gridControl1.CommandStack.BeginTrans("Transaction beginning-");
            ShowStacks();
        }

        private void rollBackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.gridControl1.CommandStack.InTransaction)
            {
                this.gridControl1.CommandStack.Rollback();
                //this.toolBeginTrans.ImageIndex = 2;
                ShowStacks();
            }
        }

        private void commitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.gridControl1.CommandStack.InTransaction)
            {
                this.gridControl1.CommandStack.CommitTrans();
                //this.toolBeginTrans.ImageIndex = 2;
                ShowStacks();
            }
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Change some cells, or move columns or rows in the\r\ngrid. You will see the Undo list start to grow. \r\n\r\nClick the Undo button or use the menu to undo an action.\r\n You will see the Redo list change.\r\n\r\nUse the Begin Transaction to start a group of changes that\r\nare treated as a single Undo/Redo command. Use Commit \r\nTransaction to signal the end of a transaction group.");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemoCommon.AboutForm abtForm = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            abtForm.ShowDialog();
        }
        #endregion
    }
}
