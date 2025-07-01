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
using System.Reflection;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.GridHelperClasses;

namespace FormulaCellSelection
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        #region Private Members
        private GridAwareTextBox gridAwareTextBox1;
        private GridControl gridControl1;
		
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
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.gridAwareTextBox1 = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAwareTextBox1
            // 
            this.gridAwareTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gridAwareTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridAwareTextBox1.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox1.EnabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridAwareTextBox1.Location = new System.Drawing.Point(12, 12);
            this.gridAwareTextBox1.Name = "gridAwareTextBox1";
            this.gridAwareTextBox1.Size = new System.Drawing.Size(495, 20);
            this.gridAwareTextBox1.TabIndex = 4;
            // 
            // gridControl1
            // 
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.DefaultRowHeight = 20;
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
            this.gridControl1.Location = new System.Drawing.Point(12, 44);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RowCount = 30;
            this.gridControl1.Size = new System.Drawing.Size(495, 247);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 6;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(519, 299);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.gridAwareTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
			this.BorderThickness = 2;
            this.Text = "Formula Range Selection Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif
			Application.Run(new Form1());
        }
        #endregion

        #region Event Handler
        private void Form1_Load(object sender, System.EventArgs e)
		{
			//wire the grid to the textbox
			this.gridAwareTextBox1.WireGrid(this.gridControl1);
			
			//Excel properties if wanted
			this.gridControl1.ExcelLikeCurrentCell = true;
			this.gridControl1.ExcelLikeSelectionFrame = true;
			this.gridControl1.ShouldSynchronizeCurrentCell = true;
			
			//make enter key move down
			this.gridControl1.EnterKeyBehavior = GridDirectionType.Down;

			//make the whole table handle formulas
			//this.gridControl1.TableStyle.CellType = "FormulaCell";
			//or
			//set column 2 to hold formulas
			GridStyleInfo style = this.gridControl1.ColStyles[2];
			style.CellType = "FormulaCell";			
			this.gridControl1.ColWidths[2] = 100;

			//set column 3 to hold formulas
			style = this.gridControl1.ColStyles[3];
			style.CellType = "FormulaCell";			
			this.gridControl1.ColWidths[3] = 100;

			//add the mousecontroller that handles formularange selections
			FormulaRangeSelectionController formulaController = new FormulaRangeSelectionController(gridControl1);
			gridControl1.MouseControllerDispatcher.Add(formulaController);

			//if you want the user to have to hold down control before a 
			//drag is started, then uncomment this line
			//formulaController.MouseRequiresControlKey = true;

			//if you want the user to have to hold down control in order
			//to start a drag with the arrow keys, then uncomment this line
			//formulaController.KeyBoardRequiresControlKey = true;

			//turn off ole D&D
			//this.gridControl1.ControllerOptions = GridControllerOptions.All & (~GridControllerOptions.OleDataSource);

			//set cell 1,1 current
			this.gridControl1.ForceCurrentCellMoveTo = true; //required to get the move to take in FormLoad
			this.gridControl1.CurrentCell.MoveTo(1,1);

			//put some random values in column 1
			Random r = new Random();
			for(int row = 1; row <= this.gridControl1.RowCount; ++row)
			{
				this.gridControl1[row, 1].CellValue = r.Next(1000);
			}
           

			this.gridControl1.CurrentCell.MoveTo(5,2);
			this.gridControl1[5,2].Text = "=Sum(A1:A5)";
			this.gridAwareTextBox1.Text = "=Sum(A1:A5)";			
			this.gridControl1.DefaultRowHeight = 18;
			this.gridControl1.DefaultColWidth = 70;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
		}
        #endregion
        
        #region splitter event handlers - required
        //When a new splitter pane is created, a new GridControl is created. So, this new control
		//needs to be wired as the original control was.
		private void splitterControl1_PaneCreated(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
		{
			GridControlBase grid = (GridControlBase) e.Control;
			this.gridAwareTextBox1.WireGrid(grid);
		
			FormulaRangeSelectionController formulaController = new FormulaRangeSelectionController(grid);
			grid.MouseControllerDispatcher.Add(formulaController);
		}

		//When the pane goes away, the dynamically created GridControl goes away as well, so we
		//need to unwire things...
		private void splitterControl1_PaneClosing(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
		{
			GridControlBase grid = (GridControlBase) e.Control;
			this.gridAwareTextBox1.UnwireGrid(grid);
		}

		#endregion	
		
	}
}
