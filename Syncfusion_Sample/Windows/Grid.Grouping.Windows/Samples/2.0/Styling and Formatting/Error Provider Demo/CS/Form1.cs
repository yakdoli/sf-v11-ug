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
using Syncfusion.Windows.Forms.Grid;

namespace ErrorProvider
{
    public partial class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            try
            {
                Icon ico = new Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch
            { }
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


        private void Form1_Load(object sender, EventArgs e)
        {
            this.GridGroupingControl1.DataSource = GetTable();
            this.GridGroupingControl1.ThemesEnabled = true;
            //Error provider Properties
            this.GridGroupingControl1.TableControl.ShowRowHeaderErroricon = false;
            this.GridGroupingControl1.TableControl.CurrentCell.ShowErrorIcon = false;
            this.GridGroupingControl1.TableControl.CurrentCell.ShowErrorMessageBox = false;
            this.GridGroupingControl1.TableControl.CurrentCell.ValidationErrorText = string.Empty;
            this.GridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.GridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.textBox1.Enabled = false;
            this.textBox2.Enabled = false;
            this.GridGroupingControl1.TableControl.CurrentCellValidating += new CancelEventHandler(GridGroupingControl1_CurrentCellValidating);
            this.GridGroupingControl1.TableControl.CurrentCellErrorMessage += new GridCurrentCellErrorMessageEventHandler(GridGroupingControl1_CurrentCellErrorMessage);           
        }


        void GridGroupingControl1_CurrentCellErrorMessage(object sender, GridCurrentCellErrorMessageEventArgs e)
        {
            //   e.Cancel=true;
        }

        void GridGroupingControl1_CurrentCellValidating(object sender, CancelEventArgs e)
        {
            long output;
            if (chkSetError.Checked)
            {
                long.TryParse(this.GridGroupingControl1.TableControl.CurrentCell.Renderer.ControlText, out output);
                if (this.GridGroupingControl1.TableControl.CurrentCell.ColIndex == 1 && output > 5)
                {
                    if (string.IsNullOrEmpty(textBox2.Text))
                        this.GridGroupingControl1.TableControl.CurrentCell.SetError("Please enter valid number");
                    else
                        this.GridGroupingControl1.TableControl.CurrentCell.SetError(textBox2.Text);

                }
            }
        }

        private DataTable GetTable()
        {
            DataTable dt = new DataTable("MyTable");

            dt.Columns.Add(new DataColumn("S.NO", typeof(int)));
            dt.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("History", typeof(string)));
            for (int i = 1; i <= 14; i++)
                dt.Rows.Add(new object[] { i, DateTime.Today.AddDays(i), "Trader "+i });

            return dt;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                this.GridGroupingControl1.TableControl.ShowRowHeaderErroricon = true;
            else
                this.GridGroupingControl1.TableControl.ShowRowHeaderErroricon = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                this.GridGroupingControl1.TableControl.CurrentCell.ValidationErrorText = textBox1.Text;
            else
                this.GridGroupingControl1.TableControl.CurrentCell.ValidationErrorText = string.Empty;
        }



        private void checkBox5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkSetError.Checked)
            {
                checkBox3.Checked = true;
                textBox2.Enabled = true;
            }
            else
            {
                checkBox3.Checked = false;
                textBox2.Enabled = false ;
            }
        }

        private void checkBox4_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {             
                checkBox3.Checked = true;
                this.textBox1.Enabled = true;
            }
            else
            {
                this.GridGroupingControl1.TableControl.CurrentCell.ValidationErrorText = string.Empty;
                this.textBox1.Clear();
                checkBox3.Checked = false;
                this.textBox1.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                this.GridGroupingControl1.TableControl.ShowRowHeaderErroricon = true;
            else
                this.GridGroupingControl1.TableControl.ShowRowHeaderErroricon = false;
        }

        private void checkBox3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                this.GridGroupingControl1.TableControl.CurrentCell.ShowErrorMessageBox = true;
            else
                this.GridGroupingControl1.TableControl.CurrentCell.ShowErrorMessageBox = false;
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                this.GridGroupingControl1.TableControl.CurrentCell.ShowErrorIcon = true;
            else
                this.GridGroupingControl1.TableControl.CurrentCell.ShowErrorIcon = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.GridGroupingControl1.TableControl.CurrentCell.ValidationErrorText = textBox1.Text;
        }
    }
}
