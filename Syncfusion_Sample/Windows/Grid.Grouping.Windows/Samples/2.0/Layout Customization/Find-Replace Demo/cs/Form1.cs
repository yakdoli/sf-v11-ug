#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
# region Directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms;

#endregion

namespace FindReplace
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            #region Icon Settings
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            #endregion

            #region General
            this.gridGroupingControl1.DataSource = GetADataTable();
            this.SetStyle(ControlStyles.UserPaint, true);
            #endregion
        }

        

        # region HelperClass [Icon]

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

        #region Find and Replace

        #region EventHandlers

        void gridGroupingControl1_TableControlCurrentCellKeyDown(object sender, GridTableControlKeyEventArgs e)
        {

            if (e.Inner.Control)
            {
                if (e.Inner.KeyCode == Keys.F || e.Inner.KeyCode == Keys.H)
                {
                    GridFindReplaceDialog f = new GridFindReplaceDialog(this.gridGroupingControl1, "Metro");
                    f.ShowDialog();
                }
            }
        }
        #endregion

        #region DataTable
        private DataTable GetADataTable()
        {

            DataTable dt = new DataTable("MyTable");

            int nCols = 20;
            int nRows = 25;

            for (int i = 0; i < nCols; i++)
                dt.Columns.Add(new DataColumn(string.Format("Col{0}", i)));

            Random rand = new Random();

            for (int i = 0; i < nRows; ++i)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < nCols; j++)
                    dr[j] = rand.Next(100);
                dt.Rows.Add(dr);
            }
            return dt;

        }
        #endregion

        #endregion

    }
}