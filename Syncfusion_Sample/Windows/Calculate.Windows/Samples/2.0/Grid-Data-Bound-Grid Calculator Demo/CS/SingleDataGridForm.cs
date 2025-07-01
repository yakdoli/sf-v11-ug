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
using Syncfusion.Calculate;

namespace GridDataBoundGridCalculator
{
	/// <summary>
	/// Summary description for SinglegridDataBoundGrid.
	/// </summary>
	public class SingleGridDataBoundGridForm : System.Windows.Forms.Form
	{
		private GridDataBoundGridCalculator.CalcGridDataBoundGrid gridDataBoundGrid1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SingleGridDataBoundGridForm()
		{
			//
			// Required for Windows Form Designer support.
			//
			InitializeComponent();

			System.Drawing.Icon ico = new System.Drawing.Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "sfgrid.ico"));
			this.Icon = ico ;

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
		/// Required method for Designer support; do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.gridDataBoundGrid1 = new GridDataBoundGridCalculator.CalcGridDataBoundGrid();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDataBoundGrid1
            // 
            this.gridDataBoundGrid1.ActivateCurrentCellBehavior = Syncfusion.Windows.Forms.Grid.GridCellActivateAction.DblClickOnCell;
            this.gridDataBoundGrid1.AllowDragSelectedCols = true;
            this.gridDataBoundGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridDataBoundGrid1.DataMember = "";
            this.gridDataBoundGrid1.Location = new System.Drawing.Point(24, 126);
            this.gridDataBoundGrid1.Name = "gridDataBoundGrid1";
            this.gridDataBoundGrid1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.gridDataBoundGrid1.Size = new System.Drawing.Size(376, 144);
            this.gridDataBoundGrid1.SmartSizeBox = false;
            this.gridDataBoundGrid1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.None;
            this.gridDataBoundGrid1.TabIndex = 0;
            this.gridDataBoundGrid1.ThemesEnabled = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(408, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(480, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Compute";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(409, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 40);
            this.label1.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(19, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(344, 16);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Show any formulas in the GridDataBoundGrid.";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Try entering formulas such as = A4 + B4 into a cell in this GridDataBoundGrid.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter a formula based on GridDataBoundGrid cells like    = A1 + B2 + Cos(B1).    " +
                "                              Then press Compute. ";
            // 
            // SingleGridDataBoundGridForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(696, 310);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gridDataBoundGrid1);
            this.Name = "SingleGridDataBoundGridForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grid-Data-Bound-Grid Calculator Demo";
            this.Load += new System.EventHandler(this.SinglegridDataBoundGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDataBoundGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion


		#region Adding a formula to the formula library - step 1

		//Adding a formula to the CalcEngine Library:
		//Step 1: Code it with this signature:
		//			public string MyLibraryFormula(string args)
		//   return the computed value as a string...
		//   use the Engine's public members as needed in your code.
		//   This sample computes the minimum of arbitary range:
		//     egs:		=myMin(A1:C3)
		//				=mymin(a1,c2,a4,b2)
		public string ComputeMyMin(string args)
		{
			double min = double.MaxValue;
			double d;
			string s1;

			foreach(string r in args.Split(new char[]{','}))
			{
				if(r.IndexOf(':') > -1) //cell range
				{
					foreach(string s in engine.GetCellsFromArgs(r))
					{
						//s is a cell line a21 or c3...
						try
						{
							s1 = engine.GetValueFromArg(s);
						}
						catch(Exception ex)
						{
							return ex.Message;
						}
						if(s1 != "")
						{
							if(double.TryParse(s1, System.Globalization.NumberStyles.Number, null, out d))
							{
								min = Math.Min(min, d);
							}
						}
					}
				}
				else
				{
					try
					{
						s1 = engine.GetValueFromArg(r);
					}
					catch(Exception ex)
					{
						return ex.Message;
					}
					if(s1 != "")
					{
						if(double.TryParse(s1, System.Globalization.NumberStyles.Number, null, out d))
						{
							min = Math.Min(min, d);
						}
					}
				}
			}	
			if(min != double.MaxValue)
				return min.ToString();
			return "";
		}


		#endregion
		
		private Syncfusion.Calculate.CalcEngine engine;
		private DataTable dt;

		private void SinglegridDataBoundGridForm_Load(object sender, System.EventArgs e)
		{
			#region create a DataTable

			this.dt = new DataTable("MyTable");

			int nCols = 5;
			int nRows = 7;

			for(int i = 0; i < nCols; i++)
				this.dt.Columns.Add(new DataColumn(string.Format("{0}", (char) ((int)'A' + i))));

			Random r = new Random();

			for(int i = 0; i < nRows; ++i)
			{
				
 				DataRow dr = this.dt.NewRow();

				for(int j = 0; j < nCols; j++)
				{
					 if(j == 0)
					{
						dr[j] = (i + 1).ToString();
					}
					 else if(j == 1)
					 {
						 if(i == 0)
							 dr[j] = 1;
						 else
							dr[j] = string.Format("=B{0} + {0}", i);
					 }
					 else
						dr[j] = r.Next(100).ToString();
				}
				this.dt.Rows.Add(dr);
			}
			#endregion

			this.gridDataBoundGrid1.DataSource = this.dt;
			this.gridDataBoundGrid1.AllowResizeToFit = false;
			this.gridDataBoundGrid1.DefaultColWidth = 60;
			
			//Call this to reset static members in case other form is loaded first:
			Syncfusion.Calculate.CalcEngine.ResetSheetFamilyID();
			//Create a CalcEngine object, tie it to the gridDataBoundGrid that implements ICalcData:
			engine = new Syncfusion.Calculate.CalcEngine(this.gridDataBoundGrid1);
			//Set the CalcEngine to track dependencies required for auto updating:
			engine.UseDependencies = true;

			//Call RecalculateRange so any formulas in the data can be initially computed.
			//Code for all cells:
			//engine.RecalculateRange(RangeInfo.Cells(1, 1, dt.Rows.Count, dt.Columns.Count), this.gridDataBoundGrid1); 

			//We only have formulas in column two, so just recalc that range:
			engine.RecalculateRange(RangeInfo.Cells(1, 2, dt.Rows.Count, 2), this.gridDataBoundGrid1);

            this.gridDataBoundGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.gridDataBoundGrid1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((System.Byte)(227)), ((System.Byte)(239)), ((System.Byte)(255)));
            this.gridDataBoundGrid1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((System.Byte)(208)), ((System.Byte)(215)), ((System.Byte)(229)));
            this.gridDataBoundGrid1.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridDataBoundGrid1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridDataBoundGrid1.Font = new System.Drawing.Font("Verdana", 8.5F);

			#region Adding a formula to the formula library - step 2
			//Adding formula to the CalcEngine Library.
			//Step 2: Call the AddFunction member of the engine.
			
			//Add formula name Min to the Library:
			engine.AddFunction("MyMin", new Syncfusion.Calculate.CalcEngine.LibraryFunction(ComputeMyMin));
			#endregion

		}


		private void textBox1_Enter(object sender, System.EventArgs e)
		{
			//Clear the display of last calculation value as the text box gets focus:
			this.label1.Text = "";
		}

		//Computes the value of a formula entered into textBox1.
		private void button1_Click(object sender, System.EventArgs e)
		{
			//-code to parse and compute a formula
			//-turn off dependency tracking as this formula comes from the
			//text box and is not entered into the grid.
			this.engine.UseDependencies = false;
			this.label1.Text = this.engine.ParseAndComputeFormula(this.textBox1.Text);
			this.engine.UseDependencies = true;
		}

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            this.gridDataBoundGrid1.Focus();
            this.gridDataBoundGrid1.CurrentCell.MoveTo(1, 1);
            this.gridDataBoundGrid1.Locked = this.checkBox1.Checked;
            this.gridDataBoundGrid1.TableStyle.TextColor = this.checkBox1.Checked ? Color.Gray : SystemColors.WindowText;

            DataTable dt = this.gridDataBoundGrid1.DataSource as DataTable;

            this.gridDataBoundGrid1.BeginUpdate();

            if (this.checkBox1.Checked)
            {
                engine.IgnoreValueChanged = true;
                for (int row = 0; row < dt.Rows.Count; ++row)
                {
                    for (int col = 0; col < dt.Columns.Count; ++col)
                    {
                        //All calls into CalcEngine are one-based:
                        string s = this.engine.GetFormulaRowCol(this.gridDataBoundGrid1, row + 1, col + 1);
                        if (s.Length > 0)
                        {
                            //No calculation as ValueChanged is not raised:
                            this.gridDataBoundGrid1[row + 1, col + 1].Text = s;
                        }
                    }
                }
                engine.IgnoreValueChanged = false;
            }
            else
            {
                for (int row = 0; row < dt.Rows.Count; ++row)
                {
                    for (int col = 0; col < dt.Columns.Count; ++col)
                    {
                        //All calls into CalcEngine are one-based:
                        string s = this.engine.GetFormulaRowCol(this.gridDataBoundGrid1, row + 1, col + 1);
                        if (s.Length > 0)
                        {
                            //Set the formula into the cell and force a calculation:
                            this.gridDataBoundGrid1[row + 1, col + 1].Text = s;
                        }
                    }
                }
                this.gridDataBoundGrid1.Binder.EndEdit();
            }
            this.gridDataBoundGrid1.EndUpdate();
            this.gridDataBoundGrid1.Refresh();
        }

	
	}
}
