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
using System.Collections.Specialized;
using Syncfusion.ComponentModel;
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System.Collections;

namespace I58680b
{
    public partial class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        private BindingList<Employee> employees = new BindingList<Employee>();


        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            #region DataSource
            employees.Add(new Employee("Ana Trujillo", Status.Divorced, Context.Employed));
            employees.Add(new Employee("Antonio Moreno", Status.Single, Context.Retired));
            employees.Add(new Employee("Thomas Hardy", Status.Single, Context.OnVacation));
            employees.Add(new Employee("Christina Berglund", Status.Single, Context.Sick));
            employees.Add(new Employee("Hanna Moos", Status.Single, Context.Employed));
            employees.Add(new Employee("Frédérique Citeaux", Status.Single, Context.OnVacation));
            employees.Add(new Employee("Katie Homes", Status.Married, Context.Employed));
            employees.Add(new Employee("Sam Anderson", Status.Married, Context.Sick));
            employees.Add(new Employee("Shan Tait", Status.Single, Context.OnVacation));
            employees.Add(new Employee("Adam Smith", Status.Widow, Context.Retired));
            employees.Add(new Employee("Steve Joseph", Status.Widow, Context.Retired));
            #endregion

            gridGroupingControl1.QueryCellStyleInfo += new GridTableCellStyleInfoEventHandler(gridGroupingControl1_QueryCellStyleInfo);
            this.gridGroupingControl1.DataSource = employees;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
			
			this.FormBorderStyle = FormBorderStyle.FixedSingle;

            checkBox1.Checked = true;
            this.checkBox1.CheckedChanged +=new Syncfusion.Windows.Forms.Tools.CheckedChangedEventHandler(checkBox1_CheckedChanged);

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
        void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.gridGroupingControl1.Refresh();
        }

        void gridGroupingControl1_QueryCellStyleInfo(object sender, GridTableCellStyleInfoEventArgs e)
        {
            var el = e.TableCellIdentity;
            var item = el.DisplayElement != null ? el.DisplayElement.GetData() : null;

            if (item is Employee &&
                el.Column != null &&
                el.Column.FieldDescriptor != null &&
                el.Column.FieldDescriptor.FieldPropertyType.IsEnum &&
                (el.DisplayElement.Kind == DisplayElementKind.Record
                 || el.DisplayElement.Kind == DisplayElementKind.AddNewRecord))
            {
                var context = new TypeDescriptorContext(item, e.Style.PropertyDescriptor);
                var converter = e.Style.PropertyDescriptor.Converter;
                if (converter != null)
                {
                    var contextualValues = converter.GetStandardValues(context).OfType<object>().ToArray();
                    e.Style.CellType = "ComboBox";
                    if (!checkBox1.Checked)
                        e.Style.DataSource = contextualValues;
                }
            }

        }


    }
}
