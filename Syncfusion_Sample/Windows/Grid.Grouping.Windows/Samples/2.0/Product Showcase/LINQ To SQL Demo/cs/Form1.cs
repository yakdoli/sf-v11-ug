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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;
using LINQToSQLCE;
using Syncfusion.Windows.Forms.Grid;

#endregion

namespace LINQToSQL
{
    public partial class Form1 : MetroForm
    {
        # region Event Handler

        public Form1()
        {
            InitializeComponent();
            this.gridGroupingControl1.DataSource = bindingSource1;           
            this.comboBoxAdv1.DataSource = CreateTable();
            this.comboBoxAdv1.DisplayMember = "BindingType";
            this.comboBoxAdv1.ValueMember = "Id";
            this.comboBoxAdv1.SelectedIndex = 0;
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.SetStyle(ControlStyles.UserPaint, true);
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
            GridIntializationSettings();
        }

        private void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxAdv1.SelectedIndex)
            {
                case 0:
                    //ListItemReference
                    SetDataSource("ListItemReference");
                    break;
                case 1:
                    //MasterDetail/UniformChildList
                    //MasterDetail_CustomerOrders
                    SetDataSource("MasterDetail_CustomerOrders");
                    break;
                case 2:
                    //ManyToMany
                    SetDataSource("ManyToMany");
                    break;
            }
        }

        
        #endregion

        # region Method

        private void GridIntializationSettings()
        {
            this.gridGroupingControl1.BeginUpdate();
            this.gridGroupingControl1.TableModel.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            this.gridGroupingControl1.Table.TableOptions.RecordRowHeight = 22;
            this.gridGroupingControl1.Table.TableOptions.ColumnHeaderRowHeight = 22;
            this.gridGroupingControl1.Table.TableOptions.CaptionRowHeight = 22;
            this.gridGroupingControl1.EndUpdate(true);

        }
        private DataTable CreateTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("BindingType");
            dt.Columns.Add("Id");
            dt.Rows.Add("ListItemReference", 0);
            dt.Rows.Add("MasterDetail/UniformChildList (CustomerOrders)", 1);
            dt.Rows.Add("ManyToMany (EmployeeDetails)", 2);
            return dt;
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

        private void SetDataSource(string queryType)
        {
            IQueryable query;

            try
            {

                query = SetDataSource(queryType, new LINQToSQLCE.NorthwindGrid("Data Source=" + FindFile("NorthwindGrid.sdf")));

                this.gridGroupingControl1.UseLazyUniformChildListRelation = true;
                Cursor.Current = Cursors.WaitCursor;
                this.gridGroupingControl1.SuspendLayout();
                this.gridGroupingControl1.ResetTableDescriptor();
                this.gridGroupingControl1.TableDescriptor.ResetRelations();
                gridGroupingControl1.BeginUpdate();
                bindingSource1.DataSource = query;
                this.gridGroupingControl1.TableDescriptor.EnableOneTimePopulate();
                gridGroupingControl1.EndUpdate(true);
                this.gridGroupingControl1.ResumeLayout(true);
                Cursor.Current = Cursors.Default;
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
                this.Close();
            }

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

        //If SQL Express Server not installed then go for Compact SQL Server file.
        private IQueryable SetDataSource(string queryType, LINQToSQLCE.NorthwindGrid db)
        {
            // db.Connection.ConnectionString = "Data Source=" + FindFile("NorthwindGrid.sdf");

            IQueryable query;
            switch (queryType)
            {
                case "ListItemReference":
                    query = from p in db.Products
                            orderby p.ProductName ascending
                            select p;
                    break;

                case "MasterDetail_CustomerOrders":
                    query = from cust in db.Customers
                            orderby cust.CompanyName
                            select cust;
                    break;
                case "ManyToMany":
                    query = from emp in db.Employees
                            select new EmployeeInfo
                            {
                                ID = emp.EmployeeID,
                                Name = emp.FirstName + " " + emp.LastName,
                                Title = emp.Title,
                                Address = emp.Address,
                                TerritoryRegion = (from terri in db.Territories
                                                   join empterri in db.EmployeeTerritories
                                                     on terri.TerritoryID equals empterri.TerritoryID
                                                   where empterri.EmployeeID == emp.EmployeeID
                                                   select new TerritoryRegion
                                                   {
                                                       TerritoryID = terri.TerritoryID,
                                                       TerritoryDescription = terri.TerritoryDescription,
                                                       RegionID = terri.Region.RegionID,
                                                       RegionDescription = terri.Region.RegionDescription
                                                   }).ToList()
                            };

                    break;
                default:
                    //Using Extension Methods and Lambda Expression.
                    query = db.Customers.OrderBy(cust => cust.CustomerID);
                    break;
            }

            return query;
        }

        #endregion

    }
}
