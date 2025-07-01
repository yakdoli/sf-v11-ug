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
using Syncfusion.Windows.Forms;
using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using Syncfusion.Grouping;

namespace ExcelToolTip
{
    public partial class Form1 : MetroForm
    {
        CommentMouseController commentMouseController;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            String commandstring = "select * from Customers";
            String connection = @"Data Source=" + FindFile("NorthwindwithImage.sdf");
            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connection);
            try
            {
                da.Fill(ds, "Customers");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.DataSource = ds.Tables["Customers"];

            // Commants insert based on RecordID and Column Name, Because Sorting and Grouping is supported in GridGroupingControl            
            Hashtable comments = new Hashtable();
            foreach (Record rec in this.gridGroupingControl1.Table.Records)
            {
                string key = rec.Id + "CustomerID";
                comments.Add(key, rec.GetValue("ContactName"));
            }

            //create the Comment mousecontroller.
            //commentMouseController = new CommentMouseController(gridGroupingControl1.TableControl);
            commentMouseController = new CommentMouseController(gridGroupingControl1.TableControl, comments);
            
            //allow context menu to edit/add comments
            commentMouseController.ContextMenuEnabled = true;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            //register the controller
            gridGroupingControl1.TableControl.MouseControllerDispatcher.Add(commentMouseController);             
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
    }
}