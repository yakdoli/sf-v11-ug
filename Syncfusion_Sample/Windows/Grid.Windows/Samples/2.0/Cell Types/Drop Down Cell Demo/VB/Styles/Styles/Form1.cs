using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;

namespace Styles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"D:\icons\LOGO.ico"));
                this.Icon = ico;
            }
            catch { }

            #region DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("Name", Type.GetType("System.String"));
            dt.Columns.Add("ID", Type.GetType("System.Int32"));
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

            this.gridGroupingControl1.DataSource = dt;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
          
            this.gridGroupingControl1.TopLevelGroupOptions.ShowFilterBar = true;
            GridOffice2007Filter.EnableFilteredColumnIcon = true;
            gridGroupingControl1.TableModel.EnableLegacyStyle = false;
            //Enable the filter for each columns 
            for (int i = 0; i < gridGroupingControl1.TableDescriptor.Columns.Count; i++)
                gridGroupingControl1.TableDescriptor.Columns[i].AllowFilter = true;
            filter.WireGrid(this.gridGroupingControl1);
            //officefilter.WireGrid(this.gridGroupingControl1);

          
            this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2010Blue;
            this.gridGroupingControl1.TableModel.EnableGridListControlInComboBox = true;

            this.gridGroupingControl1.TableModel.QueryColWidth += new Syncfusion.Windows.Forms.Grid.GridRowColSizeEventHandler(TableModel_QueryColWidth);
        
        }

        void TableControl_ResizingRows(object sender, GridResizingRowsEventArgs e)
        {
            if (e.Reason == GridResizeCellsReason.MouseUp)
            {
                if (this.gridGroupingControl1.Table.DefaultRecordRowHeight > this.gridGroupingControl1.TableControl.DefaultRowHeight)
                    isresized = true;
                else
                    isresized = false;
            }
        }
        bool isresized = false;
        void gridGroupingControl1_QueryCellStyleInfo(object sender, Syncfusion.Windows.Forms.Grid.Grouping.GridTableCellStyleInfoEventArgs e)
        {
            if (e.TableCellIdentity.RowIndex >= this.gridGroupingControl1.TableControl.TopRowIndex && e.TableCellIdentity.ColIndex > 0)
            {
                if (isresized)
                {
                    e.Style.VerticalAlignment = GridVerticalAlignment.Middle;
                }
                else
                    e.Style.VerticalAlignment = GridVerticalAlignment.Top;

            }
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

        void TableModel_QueryColWidth(object sender, Syncfusion.Windows.Forms.Grid.GridRowColSizeEventArgs e)
        {
            if (e.Index > 0)
                e.Size = 80;
            e.Handled = true;
        }
        GridDynamicFilter filter = new GridDynamicFilter();
        GridOffice2007Filter officefilter = new GridOffice2007Filter();
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;

            switch (rdb.Name)
            {
                case "radioButton1":
                    this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
                    break;
                case "radioButton2":
                    this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Black;
                    break;
                case "radioButton3":
                    this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Silver;
                    break;
                case "radioButton4":
                    this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2010Blue;
                    break;
                case "radioButton5":
                    this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2010Black;
                    break;
                case "radioButton6":
                    this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2010Silver;
                    break;
                case "radioButton7":
                    this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
                    break;
                default:
                    this.gridGroupingControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.SystemTheme;
                    break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridVisualStyles style = this.gridGroupingControl1.GridVisualStyles;
            this.gridGroupingControl1.BeginUpdate();
            filter.UnWireGrid(this.gridGroupingControl1);
            this.gridGroupingControl1.TableModel.EnableLegacyStyle = !this.gridGroupingControl1.TableModel.EnableLegacyStyle;
            this.gridGroupingControl1.GridVisualStyles = style;
            filter.WireGrid(this.gridGroupingControl1);
            this.gridGroupingControl1.EndUpdate(true);
        }


    }
}
