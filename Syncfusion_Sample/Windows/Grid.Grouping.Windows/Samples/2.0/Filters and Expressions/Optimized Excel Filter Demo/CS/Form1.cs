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
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace Optimized_Excel_Filter
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            int count = 5000;
            DataTable childTable;
            DataTable parentTable = ProductSales.GetSalesData(count, out childTable);
            DataSet dset = new DataSet();
            dset.Tables.AddRange(new DataTable[] { parentTable, childTable });
            dset.Relations.Add(new DataRelation("ParentToChild", parentTable.Columns["id"], childTable.Columns["parentID"]));
            this.gridGroupingControl1.DataSource = parentTable;

            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Office2007Blue;

            this.gridGroupingControl1.TopLevelGroupOptions.ShowFilterBar = true;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowFilterBar = true;
            this.gridGroupingControl1.ChildGroupOptions.ShowFilterBar = true;

            this.gridGroupingControl1.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.ChildGroupOptions.ShowCaption = false;

            this.gridGroupingControl1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.NestedTableGroupOptions.ShowCaption = false;

            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            foreach (GridColumnDescriptor col in this.gridGroupingControl1.TableDescriptor.Columns)
            {
                col.AllowFilter = true;
            }

            GridTableDescriptor td = this.gridGroupingControl1.TableDescriptor.Relations["ParentToChild"].ChildTableDescriptor;
            foreach (GridColumnDescriptor col in td.Columns)
            {
                col.AllowFilter = true;
            }
            this.gridGroupingControl1.TableDescriptor.Columns["ID"].Width = 35;
            this.gridGroupingControl1.TableDescriptor.Columns["Quantity"].Appearance.AnyRecordFieldCell.Format = "0.0";

            this.gridGroupingControl1.OptimizeFilterPerformance = true;
            this.gridGroupingControl1.ShowNavigationBar = true;

            filter.WireGrid(gridGroupingControl1);
            this.DropShadow = true;
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.propertyGrid1.BackColor = Color.White;
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
            this.gridGroupingControl1.AllowProportionalColumnSizing = true;
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        GridExcelFilter filter = new GridExcelFilter();
        private void button1_Click(object sender, EventArgs e)
        {
            filter.ClearFilters(this.gridGroupingControl1);
        }       

        
    }

    #region sample data

    public abstract class ProductSales
    {
        public abstract string Product { get; set; }

        public abstract string Date { get; set; }

        public abstract string Country { get; set; }

        public abstract string State { get; set; }

        public abstract int Quantity { get; set; }

        public abstract double Amount { get; set; }

        public abstract int id { get; set; }



        public static DataTable GetSalesData(int numberOfRecords, out DataTable childTable)
        {


            #region implementation

            /// Geography
            string[] countries = new string[] { "Australia", "Canada", "France", "Germany", "United Kingdom", "United States" };
            string[] ausStates = new string[] { "New South Wales", "Queensland", "South Australia", "Tasmania", "Victoria" };
            string[] canadaStates = new string[] { "Alberta", "British Columbia", "Brunswick", "Manitoba", "Ontario", "Quebec" };
            string[] franceStates = new string[] { "Charente Maritime", "Essonne", "Garonne (Haute)", "Gers", };
            string[] germanyStates = new string[] { "Bayern", "Brandenburg", "Hamburg", "Hessen", "Nordrhein Westfalen", "Saarland" };
            string[] ukStates = new string[] { "England" };
            string[] ussStates = new string[] { "New York", "North Carolina", "Alabama", "California", "Colorado", "New Mexico", "South Carolina" };

            /// Time
            string[] dates = new string[] { "FY 2005", "FY 2006", "FY 2007", "FY 2008", "FY 2009" };

            /// Products
            string[] products = new string[] { "Bike", "Car" };

            childTable = new DataTable("Child");
            childTable.Columns.Add("ID");
            childTable.Columns.Add("Field2");
            childTable.Columns.Add("Field3");
            childTable.Columns.Add("parentID");

            DataTable dt = new DataTable("Parent");
            dt.Columns.Add("ID");
            dt.Columns.Add("Date");
            dt.Columns.Add("Product");
            dt.Columns.Add("Country");
            dt.Columns.Add("State");
            dt.Columns.Add("Amount", typeof(double));
            dt.Columns.Add("Quantity", typeof(int));

            Random r = new Random(123345345);

            dt.BeginLoadData();

            for (int i = 0; i < numberOfRecords; i++)
            {
                DataRow dr = dt.NewRow();
                dr["id"] = i;
                dr["Country"] = countries[r.Next(1, countries.GetLength(0))];
                dr["Quantity"] = r.Next(1, 12);

                dr["Amount"] = (30000 * (int)dr["Quantity"]);
                dr["Date"] = dates[r.Next(r.Next(dates.GetLength(0) + 1))];
                dr["Product"] = products[r.Next(r.Next(products.GetLength(0) + 1))];
                switch (dr["Country"].ToString())
                {
                    case "Australia":
                        {
                            dr["State"] = ausStates[r.Next(ausStates.GetLength(0))];
                            break;
                        }
                    case "Canada":
                        {
                            dr["State"] = canadaStates[r.Next(canadaStates.GetLength(0))];
                            break;
                        }
                    case "France":
                        {
                            dr["State"] = franceStates[r.Next(franceStates.GetLength(0))];
                            break;
                        }
                    case "Germany":
                        {
                            dr["State"] = germanyStates[r.Next(germanyStates.GetLength(0))];
                            break;
                        }
                    case "United Kingdom":
                        {
                            dr["State"] = ukStates[r.Next(ukStates.GetLength(0))];
                            break;
                        }
                    case "United States":
                        {
                            dr["State"] = ussStates[r.Next(ussStates.GetLength(0))];
                            break;
                        }

                }
               
                dt.Rows.Add(dr);

                int rows = r.Next(10);

                for (int k = 0; k < rows; ++k)
                {
                    DataRow dr1 = childTable.NewRow();
                    dr1[0] = k;
                    dr1[1] = string.Format("F2_{0}", r.Next(3));
                    dr1[2] = string.Format("F3_{0}", 100 + r.Next(3));
                    dr1[3] = i;
                    childTable.Rows.Add(dr1);
                }

            }
            dt.EndLoadData();
            #endregion

            return dt;
        }


        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", this.Country, this.State, this.Product);
        }

        public class ProductSalesCollection : List<ProductSales>
        {
        }
    }



    #endregion
}