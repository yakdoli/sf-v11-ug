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
using Syncfusion.GridHelperClasses;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid.Grouping;
using System.Collections.Specialized;

namespace FormatCellDialog_2005
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            this.gridGroupingControl1.DataSource = CreateTable();
            this.gridGroupingControl1.Table.Records[0].SetCurrent();
            this.gridGroupingControl1.TableModel.Options.AllowSelection = GridSelectionFlags.Cell | GridSelectionFlags.AlphaBlend;
            this.gridGroupingControl1.TableModel.Options.SelectCellsMouseButtonsMask = MouseButtons.Left;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.comboBoxAdv2, "WrapGrid option is only for Left,Right,Up,Down,PageUp,PageDown");

            //String collections...

            StringCollection ar = new StringCollection();
            ar.Add("None");
            ar.Add("Left");
            ar.Add("Right");
            ar.Add("Up");
            ar.Add("Down");
            ar.Add("Top");
            ar.Add("Bottom");
            ar.Add("MostLeft");
            ar.Add("MostRight");
            ar.Add("TopLeft");
            ar.Add("BottomRight");
            ar.Add("PageUp");
            ar.Add("PageDown");
            comboBoxAdv1.DataSource = ar;

            StringCollection ad = new StringCollection();
            ad.Add("None");
            ad.Add("WrapGrid");
            comboBoxAdv2.DataSource = ad;
            this.comboBoxAdv1.SelectedIndexChanged += new EventHandler(comboBoxAdv1_SelectedIndexChanged);
            this.comboBoxAdv2.SelectedIndexChanged += new EventHandler(comboBoxAdv2_SelectedIndexChanged);
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
        void comboBoxAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAdv2.SelectedIndex == 1)
            {
                if (comboBoxAdv1.SelectedIndex == 1 || comboBoxAdv1.SelectedIndex == 2 || comboBoxAdv1.SelectedIndex == 3 || comboBoxAdv1.SelectedIndex == 4 || comboBoxAdv1.SelectedIndex == 11 || comboBoxAdv1.SelectedIndex == 12)
                {
                    this.gridGroupingControl1.TableModel.Options.WrapCellBehavior = GridWrapCellBehavior.WrapGrid;
                }
                else
                {
                    this.gridGroupingControl1.TableModel.Options.WrapCellBehavior = GridWrapCellBehavior.None;
                    this.comboBoxAdv2.SelectedIndex = 0;
                }
            }
            else
            {
                this.gridGroupingControl1.TableModel.Options.WrapCellBehavior = GridWrapCellBehavior.None;
            }
        }

        void comboBoxAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAdv1.SelectedIndex == 0)
            {
                gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.None;
            }
            if (comboBoxAdv1.SelectedIndex == 1)
            {
                gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.Left;
            }

            if (comboBoxAdv1.SelectedIndex == 2)
            {
                this.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.Right;
            }
            if (comboBoxAdv1.SelectedIndex == 3)
            {
                this.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.Up;
            }
            if (comboBoxAdv1.SelectedIndex == 4)
            {
                this.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.Down;
            }
            if (comboBoxAdv1.SelectedIndex == 5)
            {
                this.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.Top;
                this.comboBoxAdv2.SelectedIndex = 0;
            }
            if (comboBoxAdv1.SelectedIndex == 6)
            {
                this.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.Bottom;
            }
            if (comboBoxAdv1.SelectedIndex == 7)
            {
                this.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.MostLeft;
            }
            if (comboBoxAdv1.SelectedIndex == 8)
            {
                this.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.MostRight;
            }
            if (comboBoxAdv1.SelectedIndex == 9)
            {
                this.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.TopLeft;
            }
            if (comboBoxAdv1.SelectedIndex == 10)
            {
                this.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.BottomRight;
            }
            if (comboBoxAdv1.SelectedIndex == 11)
            {
                this.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.PageUp;
            }
            if (comboBoxAdv1.SelectedIndex == 12)
            {
                this.gridGroupingControl1.TableModel.Options.EnterKeyBehavior = GridDirectionType.PageDown;
            }
        }

        int rowcount = 20;
        string[] dept = { "CIVIL", "MECHANICAL", "EEE", "ECE", "IT", "CSE", "BIO-TECH", "AERO", "MARINE", "TEXTILE", "EEE", "ECE", "IT", "CSE", "BIO-TECH", "AERO", "MARINE", "CIVIL", "MECHANICAL", "TEXTILE" };
        string[] year = { "I", "II", "III", "IV", "III", "I", "IV", "II", "III", "I", "II", "III", "IV", "III", "I", "IV", "II", "II", "III", "IV" };
        string[] sem = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "One", "Two", "Three", "Four" };
        string[] grade = { "A", "B", "C", "D", "A", "B", "C", "D", "A", "B", "C", "D", "A", "B", "C", "D", "A", "B", "C", "D" };

        
        private DataTable CreateTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SNo");
            dt.Columns.Add("StudentID");
            dt.Columns.Add("Department");
            dt.Columns.Add("Year");
            dt.Columns.Add("Semester");
            dt.Columns.Add("Grade");
            for (int i = 0; i < rowcount; i++)
            {
                DataRow dr = dt.NewRow();
                if ((i + 1) < 10)
                {
                    dr[0] = "0" + (i + 1).ToString();
                    dr[1] = "S" + "0" + (i + 1).ToString();
                }
                else
                {
                    dr[0] = (i + 1).ToString();
                    dr[1] = "S" + (i + 1).ToString();
                }
                dr[2] = dept[i];
                dr[3] = year[i];
                dr[4] = sem[i];
                dr[5] = grade[i];
                dt.Rows.Add(dr);
            }
            return dt;
        }

        MetroForm form;
        GroupingGridFormatCellDialog dialog;
        private void formatCellsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form = new MetroForm();
            form.IsMdiContainer = true;
            dialog = new GroupingGridFormatCellDialog(this.gridGroupingControl1);
            dialog.FormBorderStyle = FormBorderStyle.None;
            dialog.Dock = DockStyle.Fill;
            dialog.MdiParent = form;
            form.Size = dialog.Size + new Size(17, 37);

            dialog.Controls[1].Click +=new EventHandler(ButtonClick);
            dialog.Controls[0].Click += new EventHandler(ButtonClick);
            form.DropShadow = true;
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            form.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            form.BorderThickness = 2;
            form.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            form.ShowIcon = false;
            form.MaximizeBox = false;
            form.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            form.MinimizeBox = false;
            form.Text = "Format Cell Dialog";
            dialog.Show();
            form.ShowDialog();
        }

        void ButtonClick(object sender, EventArgs e)
        {
            dialog.Close();
            form.Close();
        }

    }
}