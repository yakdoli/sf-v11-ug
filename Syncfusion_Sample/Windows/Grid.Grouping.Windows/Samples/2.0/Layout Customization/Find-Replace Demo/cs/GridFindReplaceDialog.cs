#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;

namespace FindReplace
{
    public partial class GridFindReplaceDialog : MetroForm
    {
        GridFindReplaceDialogSink frDialog;
        GridFindReplaceEventArgs frEvents;
        object locInfo;
        GridFindTextOptions options;
        GridGroupingControl grid; 
        public GridFindReplaceDialog(GridGroupingControl groupinggrid, string themeStyle)
        {
            InitializeComponent();
            grid = groupinggrid;
            frDialog = new GridFindReplaceDialogSink(grid.TableControl);
            options = GridFindTextOptions.None;
            cmbOptions.SelectedIndex = 1;
            grid.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(grid_QueryCellStyleInfo);
        }

        void grid_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
            if (findAll)
            {
                DataRowView dr = e.TableCellIdentity.DisplayElement.GetData() as DataRowView;
                int rowIndex, colIndex;
                grid.TableControl.CurrentCell.GetCurrentCell(out rowIndex, out colIndex);
                GridRangeInfo range = grid.TableControl.Selections.Ranges.ActiveRange;
                if (cmbOptions.Text.Equals("WholeTable") && dr != null)
                {
                    if (e.Style.Text.Equals(txtSearch.Text) && e.TableCellIdentity.DisplayElement.Kind == DisplayElementKind.Record)
                        e.Style.BackColor = Color.Orange;
                }
                else if (cmbOptions.Text.Equals("ColumnOnly") && dr != null)
                {
                    if (e.TableCellIdentity.ColIndex == colIndex)
                    {
                        if (e.Style.Text.Equals(txtSearch.Text))
                            e.Style.BackColor = Color.Orange;
                    }
                }

            }
            else if (resetAll)
                e.Style.BackColor = SystemColors.Window;
        }

        private void findnextBtn_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                SetOptions();
                locInfo = GridRangeInfo.Table();
                frEvents = new GridFindReplaceEventArgs(txtSearch.Text, "", options, locInfo);
                frDialog.Find(frEvents);
            }
        }
        private void SetOptions()
        {
            options = GridFindTextOptions.None;
            if (matchChkbox.Checked)
                options = GridFindTextOptions.MatchCase;
            if (matchAllChkbox.Checked)
                options |= GridFindTextOptions.MatchWholeCell;
            if (searchupChkbox.Checked)
                options |= GridFindTextOptions.SearchUp;

            switch (cmbOptions.SelectedIndex)
            {
                case 0: options |= GridFindTextOptions.ColumnOnly; break;
                case 1: options |= GridFindTextOptions.WholeTable; break;
            }
        }
        bool findAll = false;
        bool resetAll = false;
        private void findallBtn_Click(object sender, EventArgs e)
        {
            findAll = true;
            resetAll = false;
            grid.Refresh();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            resetAll = true;
            findAll = false;
            grid.TableControl.Selections.Clear();
            grid.Refresh();
            this.grid.QueryCellStyleInfo-=new GridTableCellStyleInfoEventHandler(grid_QueryCellStyleInfo);
            this.Close();
        }

        private void ReplaceBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text) && !string.IsNullOrEmpty(txtReplace.Text))
            {
                SetOptions();
                frEvents = new GridFindReplaceEventArgs(txtSearch.Text, txtReplace.Text, options, locInfo);
                frDialog.Replace(frEvents);
            }
        }

        private void ReplaceAllBtn_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "" && txtReplace.Text != "")
            {
                SetOptions();
                frEvents = new GridFindReplaceEventArgs(txtSearch.Text, txtReplace.Text, options, locInfo);
                frDialog.ReplaceAll(frEvents);
            }
            resetAll = true;
            findAll = false;
            grid.Refresh();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84: m.Result = new IntPtr(0x2);
                    return;
            }
            base.WndProc(ref m);
        }
        private void GridFindReplaceDialog_Load(object sender, EventArgs e)
        {
        }
    }
}
