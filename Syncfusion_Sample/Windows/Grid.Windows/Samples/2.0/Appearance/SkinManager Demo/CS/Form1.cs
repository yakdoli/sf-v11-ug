using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;

namespace SkinManagerDemo_2008
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            Random r = new Random();
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
           
            #region DataSource

            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("EmployeeName", Type.GetType("System.String"));
            dt.Columns.Add("OrderID", Type.GetType("System.Int32"));
            dt.Columns.Add("Amount", Type.GetType("System.Decimal"));
            dt.Columns.Add("Cost", Type.GetType("System.Decimal"));
            dt.Columns.Add("Date", Type.GetType("System.String"));
            dt.Rows.Add(new object[] { "Sam", 1, 25.00, 13.00, "01/10/2007" });
            dt.Rows.Add(new object[] { "Sam", 2, 512.00, 1.00, "02/10/2007" });
            dt.Rows.Add(new object[] { "Sam", 3, 512.00, 1.00, "03/10/2007" });
            dt.Rows.Add(new object[] { "Tom", 4, 50.00, 1.00, "04/10/2007" });
            dt.Rows.Add(new object[] { "Tom", 5, 3.00, 7.00, "03/10/2007" });
            dt.Rows.Add(new object[] { "Tom", 6, 78.75, 12.00, "02/10/2007" });
            dt.Rows.Add(new object[] { "Sue", 7, 11.00, 7.00, "01/10/2007" });
            dt.Rows.Add(new object[] { "Sue", 8, 2.50, 66.20, "02/10/2007" });
            dt.Rows.Add(new object[] { "Sue", 9, 2.50, 22.00, "03/10/2007" });
            dt.Rows.Add(new object[] { "Jack", 10, 6.00, 23.00, "02/10/2007" });
            dt.Rows.Add(new object[] { "Jack", 11, 117.00, 199.00, "04/10/2007" });
            dt.Rows.Add(new object[] { "Jack", 12, 13.00, 2.60, "01/10/2007" });
            dt.Rows.Add(new object[] { "Jack", 13, 11.40, 99.80, "03/10/2007" });
            dt.Rows.Add(new object[] { "Phill", 14, 37.00, 2.10, "02/10/2007" });
            dt.Rows.Add(new object[] { "Phill", 15, 65.20, 99.30, "04/10/2007" });
            dt.Rows.Add(new object[] { "Phill", 16, 34.10, 27.00, "02/10/2007" });
            dt.Rows.Add(new object[] { "Phill", 17, 17.00, 959.00, "04/10/2007" });
            #endregion

            #region GridListControl
            this.gridListControl1.DataSource = dt;
            this.gridListControl1.DisplayMember = "EmployeeName";
            this.gridListControl1.ValueMember = "EmployeeName";
            this.gridListControl1.MultiColumn = true;
            this.gridListControl1.ShowColumnHeader = true;
            
            #endregion

            #region GridControl
            for (int i = 1; i <= this.gridControl1.RowCount; ++i)
            {
                for (int j = 1; j <= this.gridControl1.ColCount; ++j)
                {
                    this.gridControl1[i, j].CellValue = r.Next(1000);
                }
            }
            this.gridControl1.Refresh();
            
            #endregion

          

            #endregion

            #region InitialSettings
            this.comboBox1.Text = "Parent Container";
            this.comboBox2.Text = "Office2010Blue";
            SkinManager.SetVisualStyle(this, comboBox2.Text);
            #endregion
        }

        #region USState Class

        public class USState
        {
            private string myShortName;
            private string myLongName;
            private int _imageIndex;

            public USState(string strLongName, string strShortName, int _imageIndex)
            {
                this.myShortName = strShortName;
                this.myLongName = strLongName;
                this._imageIndex = _imageIndex;
            }

            public string ShortName
            {
                get { return myShortName; }
            }

            public string LongName
            {
                get { return myLongName; }
            }

            public int ImageIndex
            {
                get { return _imageIndex; }
                set { _imageIndex = value; }
            }

            public override string ToString()
            {
                return this.ShortName + " - " + this.LongName;
            }
        }
        #endregion

        #region Event Hanlder

        Control ctrl = null;
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Parent Container")
                ctrl = this.parent;
            else if (comboBox1.Text == "GridControl")
                ctrl = this.grid;
            else if (comboBox1.Text == "GridListControl")
                ctrl = this.gridList;
            else
                ctrl = this;

            SkinManager.SetVisualStyle(ctrl, comboBox2.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "ParentContainer")
                ctrl = this.parent;
            else if (comboBox1.Text == "GridControl")
                ctrl = this.grid;
            else if (comboBox1.Text == "GridListControl")
                ctrl = this.gridList;
            else
                ctrl = this;

            SkinManager.SetVisualStyle(ctrl, comboBox2.Text);
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

        #endregion
    }
}
