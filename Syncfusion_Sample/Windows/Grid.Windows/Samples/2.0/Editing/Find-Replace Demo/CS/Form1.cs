using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms;

namespace GridFindReplace
{
    public partial class Form1 : MetroForm
    {
        GridFindReplaceDialogSink frDialog;
        GridFindReplaceEventArgs frEvents;
        GridFindTextOptions options;
        object locInfo;

        public Form1()
        {
            InitializeComponent();

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            #region Grid and its dialog 
             
            EnableControls(false);

            //Populate the grid control
            Random r = new Random();
            for (int i = 1; i <= gridControl1.RowCount; i++)
                for (int j = 1; j <= gridControl1.ColCount; j++)
                    gridControl1[i,j].Text = r.Next(100, 150).ToString();
            
            //Setup FindReplace dialog
            frDialog = new GridFindReplaceDialogSink(gridControl1);
            
            //Initial Settings
            options = GridFindTextOptions.None;
            cmbOptions.SelectedIndex = 2;
            this.gridControl1.ForceCurrentCellMoveTo = true;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.CurrentCell.MoveTo(1, 1);
            gridControl1.TableStyle.TextColor = Color.MidnightBlue;
            #endregion
        }
		
        #region Event Handlers

        //FindNext
        private void btnFindNext_Click(object sender, EventArgs e)
        {
            gridControl1.Selections.Clear();
            
            if(cmbSearch.Text != "")
            {
                AddToSearchedList(cmbSearch.Text);
               
                SetOptions();
                locInfo = GridRangeInfo.Table();
                clearHighlight();
                frEvents = new GridFindReplaceEventArgs(cmbSearch.Text, "", options, locInfo);
                frDialog.Find(frEvents);
                
            }
        }

        //FindAll - Loops through the cells in the grid and highlights all the values 
        //that match with the given search string.
        private void btnFindAll_Click(object sender, EventArgs e)
        {
            if (cmbSearch.Text != null)
            {
                AddToSearchedList(cmbSearch.Text);

                SetOptions();
                locInfo = GridRangeInfo.Table();
                GridRangeInfo selRange = GridRangeInfo.Empty;
                int rowIndex, colIndex;
                if ((options & GridFindTextOptions.SelectionOnly) != GridFindTextOptions.None)
                    selRange = gridControl1.Selections.Ranges.ActiveRange;

                else if ((options & GridFindTextOptions.ColumnOnly) != GridFindTextOptions.None)
                    selRange = GridRangeInfo.Col(gridControl1.CurrentCell.ColIndex);

                else if ((options & GridFindTextOptions.WholeTable) != GridFindTextOptions.None)
                    selRange = GridRangeInfo.Cells(1, 1, gridControl1.RowCount, gridControl1.ColCount);

                clearHighlight();

                int startTop = selRange.Top;
                int startLeft = selRange.Left;

                while (GridFindReplaceDialogSink.GetNextCell(selRange, ref startTop, ref startLeft, false, chkSearchUp.Checked))
                {
                    GridStyleInfo style = gridControl1[startTop, startLeft];
                    GridCellRendererBase renderer = gridControl1.CellRenderers[style.CellType];
                    if (renderer.FindText(cmbSearch.Text, startTop, startLeft, options, true))
                    {
                        gridControl1.CurrentCell.GetCurrentCell(out rowIndex, out colIndex);
                        gridControl1[rowIndex, colIndex].BackColor = Color.Orange;
                    }
                }
            }
        }

        //Replace
        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (cmbSearch.Text != "" && cmbReplace.Text != "")
            {
                AddToSearchedList(cmbSearch.Text);
                SetOptions();
                locInfo = GridRangeInfo.Table();
                frEvents = new GridFindReplaceEventArgs(cmbSearch.Text, cmbReplace.Text, options, locInfo);
                frDialog.Replace(frEvents);
            }
        }

        //ReplaceAll
        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            if (cmbSearch.Text != "" && cmbReplace.Text != "")
            {
                AddToSearchedList(cmbSearch.Text);
                SetOptions();
                locInfo = GridRangeInfo.Table();
                frEvents = new GridFindReplaceEventArgs(cmbSearch.Text, cmbReplace.Text, options, locInfo);
                frDialog.ReplaceAll(frEvents);
                clearHighlight();
            }
            else
                MessageBox.Show("Search/Replace value is missing");
        }

        private void cmbSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbSearch.Text != "")
                EnableControls(true);
            else
                EnableControls(false);
        }
        #endregion

        #region Helper methods

        //Setup the search options.
        private void SetOptions()
        {
            options = GridFindTextOptions.None;
            if (chkMatchCase.Checked)
                options = GridFindTextOptions.MatchCase;
            if (chkMatchWholeCell.Checked)
                options |= GridFindTextOptions.MatchWholeCell;
            if (chkSearchUp.Checked)
                options |= GridFindTextOptions.SearchUp;

            switch (cmbOptions.SelectedIndex)
            {
                case 0: options |= GridFindTextOptions.ColumnOnly; break;
                case 1: options |= GridFindTextOptions.SelectionOnly; break;
                case 2: options |= GridFindTextOptions.WholeTable; break;
            }
        }

        private void EnableControls(bool enable)
        {
            this.cmbReplace.Enabled = enable;
            btnFindNext.Enabled = enable;
            btnFindAll.Enabled = enable;
            btnReplace.Enabled = enable;
            btnReplaceAll.Enabled = enable;
            chkMatchCase.Enabled = enable;
            chkMatchWholeCell.Enabled = enable;
            chkSearchUp.Enabled = enable;
            cmbOptions.Enabled = enable;
            lblReplaceWith.Enabled = enable;
        }

        //Set the backcolor of the cells being highlighted to their original color.
        private void clearHighlight()
        {
            for (int i = 1; i <= gridControl1.RowCount; i++)
                for (int j = 1; j <= gridControl1.ColCount; j++)
                    gridControl1[i, j].BackColor = SystemColors.Window;
        }

        //Keep track of the search strings being entered.
        private void AddToSearchedList(string txt)
        {
            if (!cmbSearch.Items.Contains(txt))
                cmbSearch.Items.Insert(0, txt);
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
        #endregion
    }
}