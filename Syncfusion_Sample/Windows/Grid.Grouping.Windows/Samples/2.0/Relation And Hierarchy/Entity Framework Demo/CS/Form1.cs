#region Copyright Syncfusion Inc. 2001 - 2013
//
//  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Data.EntityClient;
using System.Data.Common;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System.Linq;
using System.IO;
using System.Data.SqlClient;
using Syncfusion.Grouping;

namespace Entity_Framework
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : MetroForm
    {
        private NorthwindGridEntities db;
        static string str = "Data Source=" + FindFile("NorthwindwithImage.sdf");
        public readonly static string conString = str;
        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            try
            {
                Icon ico = new Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch
            { }
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
            this.propertyGrid1.SelectedObject = this.gridGroupingControl1;
        }

        /// <summary>
        /// Get the customer table from NorthWind database.
        /// </summary>
        /// <returns>Customers details.</returns>
        private IQueryable<Customers> GetAllCustomers()
        {
            var customers = from c in db.Customers
                            select c;
            return customers;
        }

        /// <summary>
        /// Get the customer table from NorthWind database.
        /// </summary>
        /// <returns>Customers details.</returns>
        private IQueryable<Customers> GetAllOrders()
        {
            var order = from o in db.Customers
                        orderby o.CustomerID ascending
                        select o;
            return order;
        }

        /// <summary>
        /// Get the path of the icon file.
        /// </summary>
        /// <param name="bitmapName">IconFile name.</param>
        /// <returns>Icon file location.</returns>
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
        /// Get the path of image file.
        /// </summary>
        /// <param name="bitmapName">ImageFile name.</param>
        /// <returns>ImageFile location.</returns>
        private static string FindFile(string fileName)
        {
            // Check both in parent folder and Parent\Data folders.
            //string dataFileName = @"Common\Data\" + fileName;
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


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Create a connection object for entity connection.
                EntityConnection con = new EntityConnection("name=NorthwindGridEntities");
                con.StoreConnection.ConnectionString = conString;
                db = new NorthwindGridEntities(con);
                this.gridGroupingControl1.DataSource = GetAllOrders().ToList<Customers>();
                this.gridGroupingControl1.TableDescriptor.Relations.Clear();
                this.gridGroupingControl1.Engine.SourceListSet.Add("Customers", GetAllCustomers().ToList<Customers>());
                GridRelationDescriptor relation = new GridRelationDescriptor();
                relation.Name = "Customer";
                relation.ChildTableName = "Customers";  // SourceListSet name for lookup
                relation.RelationKind = RelationKind.RelatedMasterDetails;
                relation.RelationKeys.Add("CustomerID", "CustomerID");
                //Add relation to parent table.
                this.gridGroupingControl1.TableDescriptor.Relations.Add(relation);
            }
            catch (SqlException)
            {
                this.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error in Connection. " + err.Message);
                Application.Exit();
            }

        }

        /// <summary>
        /// Create a method for exit in file menuitem.
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }  

}