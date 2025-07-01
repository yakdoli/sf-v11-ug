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
using System.Linq;
using System.Windows.Forms;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System.Data.SqlClient;
using System.IO;
using Syncfusion.Windows.Forms;
using System.Data;
using System.Drawing;
using Syncfusion.Windows.Forms.Grid;
#endregion

namespace LinqGroupBy
{
    public partial class Form1 : MetroForm
    {
        #region Variable declaration

        private NorthwindwithImage db;
        public readonly static string conString = "Data Source=" + FindFile("NorthwindwithImage.sdf");

        #endregion

        #region Event handler

        public Form1()
        {

            InitializeComponent();

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }         
            this.comboBoxAdv1.SelectedIndex = 0;
            this.comboBoxAdv1.SelectedIndexChanged += new EventHandler(comboBoxAdv1_SelectedIndexChanged);
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemoCommon.AboutForm abtform = new DemoCommon.AboutForm(AppDomain.CurrentDomain.GetAssemblies());
            abtform.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnLoad(EventArgs e)
        {


            try
            {
                db = new NorthwindwithImage(conString);

                SampleQuery sq = new LinqGroupBy.CustomerQuery();
                sq.InitializeGrid(gridGroupingControl1, db);

                base.OnLoad(e);
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
                this.Close();
            }

        }

        void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv1.SelectedIndex)
            {
                case 0: ResetGrid(new CustomerQuery());
                    break;
                case 1: ResetGrid(new CustomerOrders());
                    break;
                case 2: ResetGrid(new CustomerOrdersDetails());
                    break;
                case 3: ResetGrid(new CustomerOrdersGroupedByShippers());
                    break;
                case 4: ResetGrid(new ProductsGroupedBySupplier());
                    break;
                case 5: ResetGrid(new ProductsGroupedBySupplierAndCategory());
                    break;
            }
        }

        #endregion       

        #region Method

        private void GridIntializationSettings()
        {
            this.gridGroupingControl1.BeginUpdate();
            this.gridGroupingControl1.TableModel.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridGroupingControl1.Table.TableOptions.RecordRowHeight = 22;
            this.gridGroupingControl1.Table.TableOptions.ColumnHeaderRowHeight = 22;
            this.gridGroupingControl1.Table.TableOptions.CaptionRowHeight = 22;
            this.gridGroupingControl1.EndUpdate(true);
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

        private static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string dataFileName = @"Common\Data\" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(fileName))
                {
                    return new FileInfo(fileName).FullName;
                }
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                fileName = @"..\" + fileName;
                dataFileName = @"..\" + dataFileName;
            }

            return fileName;
        }

        private void ResetGrid(SampleQuery sq)
         {
             gridGroupingControl1.DataSource = null;
             sq.InitializeGrid(gridGroupingControl1, db);
             this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;             
         }

        private static void ShowErrorMessage(SqlException ex)
        {
            if (ex.Number == 11001)
                MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 208)
                MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 156 || ex.Number == 102)
                MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        #endregion
      
    }

}
