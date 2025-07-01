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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.IO;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms;

namespace ObservableCollection_Demo
{
    public partial class Form1 : MetroForm
    {
        EngineEventTracer eventTracer;
        public Form1()
        {
            InitializeComponent();
            System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
            this.Icon = ico;
            this.gridGroupingControl1.DataSource = new Customer();
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.ShowGroupDropArea = true;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowFilterBar = true;
            GridEngine eng = this.gridGroupingControl1.Engine;
            eventTracer = new EngineEventTracer(eng, this.listView1);
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

        #region EventHandlers
        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.Text == "Trace Events")
            {
                this.eventTracer.HookEvents();
                this.button1.Text = "Disable Tracing";
            }
            else
            {
                this.eventTracer.UnhookEvents();
                this.button1.Text = "Trace Events";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (GridColumnDescriptor col in this.gridGroupingControl1.TableDescriptor.Columns)
            {
                col.AllowFilter = true;
            }
        }

        void gridGroupingControl1_FilterBarSelectedItemChanged(object sender, FilterBarSelectedItemChangedEventArgs e)
        {
            this.eventTracer.AppendOutput("Filtered Column: ", e.Column.Name.ToString());
            this.eventTracer.AppendOutput("SelectedText: ", e.SelectedText);
        }
        #endregion
    }

    public class Customer : ObservableCollection<Customers>
    {
        Northwind northWind;

        public Customer()
        {
             string connectionString = string.Format(@"Data Source = {0}", FindFile("Northwind.sdf"));
             northWind = new Northwind(connectionString);
             var customer = northWind.Customers.Skip(0).Take(100).ToList();
             foreach (var o in customer)
             {
                 this.Add(o);
             }
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
