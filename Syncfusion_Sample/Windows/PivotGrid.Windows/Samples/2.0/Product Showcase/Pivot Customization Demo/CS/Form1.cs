#region Copyright Syncfusion Inc. 2001 - 2012
// Copyright Syncfusion Inc. 2001 - 2012. All rights reserved.
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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication11
{
    public partial class Form1 : MetroForm
    {
        #region Window Updates
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        internal static extern bool LockWindowUpdate(IntPtr hWndLock);
        #endregion

        public Form1()
        {
            InitializeComponent();

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }


            this.pivotGridControl1.ItemSource = ProductSales.GetSalesData();

            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Product", TotalHeader = "Total" });

            this.pivotGridControl1.PivotRows.Add(new PivotItem { FieldMappingName = "Date", TotalHeader = "Total" });


            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "Country", TotalHeader = "Total" });

            this.pivotGridControl1.PivotColumns.Add(new PivotItem { FieldMappingName = "State", TotalHeader = "Total" });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Amount", Format = "C", SummaryType = SummaryType.DoubleTotalSum });

            this.pivotGridControl1.PivotCalculations.Add(new PivotComputationInfo { FieldName = "Quantity", Format = "#,##0" });

            checkBox1.Checked = true;
           
            this.pivotGridControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.pivotGridControl1.ShowPivotTableFieldList = true;

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

        #region DataSource

        #region product sales class
        public class ProductSales
        {

            public string Product { get; set; }

            public string Date { get; set; }

            public string Country { get; set; }



            public string State { get; set; }



            public int Quantity { get; set; }



            public double Amount { get; set; }

            public double UnitPrice { get; set; }

            public double TotalPrice { get; set; }

            public static ProductSalesCollection GetSalesData()
            {

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

                Random r = new Random(123345345);



                int numberOfRecords = 2000;

                ProductSalesCollection listOfProductSales = new ProductSalesCollection();

                for (int i = 0; i < numberOfRecords; i++)
                {

                    ProductSales sales = new ProductSales();
                    sales.Country = countries[r.Next(1, countries.GetLength(0))];
                    sales.Quantity = r.Next(1, 12);

                    /// 1 percent discount for 1 quantity
                    double discount = (3000 * sales.Quantity) * (double.Parse(sales.Quantity.ToString()) / 100);
                    sales.Amount = (3000 * sales.Quantity) - discount;
                    sales.TotalPrice = sales.Amount * sales.Quantity;
                    sales.UnitPrice = sales.Amount / sales.Quantity;
                    sales.Date = dates[r.Next(r.Next(dates.GetLength(0) + 1))];
                    sales.Product = products[r.Next(r.Next(products.GetLength(0) + 1))];
                    switch (sales.Country)
                    {
                        case "Australia":
                            {
                                sales.State = ausStates[r.Next(ausStates.GetLength(0))];
                                break;
                            }
                        case "Canada":
                            {
                                sales.State = canadaStates[r.Next(canadaStates.GetLength(0))];
                                break;
                            }
                        case "France":
                            {
                                sales.State = franceStates[r.Next(franceStates.GetLength(0))];
                                break;
                            }
                        case "Germany":
                            {
                                sales.State = germanyStates[r.Next(germanyStates.GetLength(0))];
                                break;
                            }
                        case "United Kingdom":
                            {
                                sales.State = ukStates[r.Next(ukStates.GetLength(0))];
                                break;
                            }
                        case "United States":
                            {
                                sales.State = ussStates[r.Next(ussStates.GetLength(0))];
                                break;
                            }
                    }
                    listOfProductSales.Add(sales);

                }



                return listOfProductSales;

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

        #endregion

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.ShowGroupBar = !this.pivotGridControl1.ShowGroupBar;
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.ShowSubTotals = !this.pivotGridControl1.ShowSubTotals;
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.ShowGrandTotals = !this.pivotGridControl1.ShowGrandTotals;
        }

        private void checkBoxAdv1_CheckStateChanged(object sender, EventArgs e)
        {
            this.pivotGridControl1.SuspendLayout();
            this.pivotGridControl1.ShowPivotTableFieldList = !this.pivotGridControl1.ShowPivotTableFieldList;
            this.pivotGridControl1.ResumeLayout(true);
            this.pivotGridControl1.Refresh();
        }

        private void checkBoxAdv2_CheckStateChanged(object sender, EventArgs e)
        {
            LockWindowUpdate(this.Handle);
            if (this.checkBoxAdv2.Checked)
            {
                this.pivotGridControl1.RightToLeft = RightToLeft.Yes;
            }
            else
                this.pivotGridControl1.RightToLeft = RightToLeft.No;
            LockWindowUpdate(IntPtr.Zero);
            this.pivotGridControl1.TableControl.Refresh();
            this.pivotGridControl1.PivotSchemaDesigner.Refresh();
            this.pivotGridControl1.Refresh();
        }
    }
}
