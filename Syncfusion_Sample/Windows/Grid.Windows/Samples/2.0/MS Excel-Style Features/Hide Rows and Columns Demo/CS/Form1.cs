using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Styles;
using Syncfusion.Windows.Forms;

namespace HideRowCols
{
    public partial class Form1 : MetroForm
    {
        int visibleColCount, visibleRowCount;

        public Form1()
        {
            InitializeComponent();

            #region Setup Grid

            this.gridControl1.BeginUpdate();

            // 2500 x 2500 grid
            visibleColCount = this.gridControl1.ColCount = 2500;
            visibleRowCount = this.gridControl1.RowCount = 2500;

            // Fill the grid
            for (int n = 0; n < gridControl1.ColCount; n++)
            {
                GridStyleInfo style = new GridStyleInfo();
                style.CellValue = n + 1;
                for (int i = 0; i < gridControl1.RowCount; i++)
                {
                    this.gridControl1.SetCellInfo(i + 1, n + 1, style, StyleModifyType.Copy, true, true);
                }
            }

            this.gridControl1.ListBoxSelectionMode = SelectionMode.One;
            gridControl1.CurrentCell.MoveTo(1, 1);
            this.gridControl1.EndUpdate();

            #endregion 
            
            this.label1.Text = "    Row Count: " + (this.gridControl1.RowCount) + "\n Col Count: " + (this.gridControl1.ColCount);

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

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
        #endregion

        #region Event Handlers

        bool flag = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                this.gridControl1.HideCols.SetRange(1, (int)upDownCol.Value, true);
                this.gridControl1.HideRows.SetRange(1, (int)upDownRow.Value, true);
                this.gridControl1.CurrentCell.MoveTo((int)upDownRow.Value + 1, (int)upDownCol.Value + 1);
                flag = false;
                this.upDownRow.Enabled = false;
                this.upDownCol.Enabled = false;

                btnHide.Text = "Show Hidden Rows and Columns";
                this.label1.Text = "    Row Count: " + (gridControl1.RowCount - upDownRow.Value) + ";    Col Count:  " + (gridControl1.ColCount - upDownCol.Value);
            }
            else
            {
                this.gridControl1.HideCols.SetRange(1, (int)upDownCol.Value, false);
                this.gridControl1.HideRows.SetRange(1, (int)upDownRow.Value, false);
                this.gridControl1.CurrentCell.MoveTo(1, 1);
                this.gridControl1.ScrollCellInView(1, 1, GridScrollCurrentCellReason.MoveTo);
                this.upDownCol.Value = 0;
                this.upDownRow.Value = 0;
                flag = true;
                this.upDownRow.Enabled = true;
                this.upDownCol.Enabled = true;
                btnHide.Text = "Hide Rows and Columns";
                this.label1.Text = "    Row Count: " + (gridControl1.RowCount - upDownRow.Value) + ";    Col Count: " + (gridControl1.ColCount - upDownCol.Value);
            }
            this.gridControl1.Refresh();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}