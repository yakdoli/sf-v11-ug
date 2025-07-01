﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using System.Collections.Specialized;
using System.Collections;
using Syncfusion.Windows.Forms.Tools;

namespace VisualStyle_Demo
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

            InitializeGrid();

            
        }

        #region Icon and Image Handlers
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

        //private Image GetImage(string bitmapName)
        //{
        //    Image bitmap = null;

        //    try
        //    {
        //        Assembly ass = typeof(Form1).Assembly;
        //        string name = ass.GetName().Name;
        //        Stream stream = ass.GetManifestResourceStream(name + "." + bitmapName);
        //        bitmap = Image.FromStream(stream);
        //    }
        //    catch (Exception ex)
        //    {
        //        TraceUtil.TraceExceptionCatched(ex);
        //    }

        //    return bitmap;
        //}
        #endregion

        #region EventHandlers

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            
            PictureBox pBox = (PictureBox)sender;
           
            switch (pBox.Name)
            {
                case "pictureBox1":
                    this.gridControl1.GridVisualStyles = GridVisualStyles.Metro;
                    break;
                case "pictureBox2":
                    this.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Blue;
                    gridControl1.Office2007ScrollBars = true;
                    gridControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    break;
                case "pictureBox3":
                    this.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Black;
                    gridControl1.Office2007ScrollBars = true;
                    gridControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    break;
                case "pictureBox4":
                    this.gridControl1.GridVisualStyles = GridVisualStyles.Office2007Silver;
                    gridControl1.Office2007ScrollBars = true;
                    gridControl1.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    break;
                case "pictureBox5":
                    this.gridControl1.GridVisualStyles = GridVisualStyles.Office2010Blue;
                    gridControl1.Office2007ScrollBars = false;
                    gridControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Blue;
                    break;
                case "pictureBox6":
                    this.gridControl1.GridVisualStyles = GridVisualStyles.Office2010Black;
                    gridControl1.Office2007ScrollBars = false;
                    gridControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black;
                    break;
                case "pictureBox7":
                    this.gridControl1.GridVisualStyles = GridVisualStyles.Office2010Silver;
                    gridControl1.Office2007ScrollBars = false;
                    gridControl1.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Silver;
                    break;

            }

            label6.Text = gridControl1.GridVisualStyles.ToString();
            label4.Text = label6.Text;

            panel1.Location = new Point(pBox.Location.X + 3, panel2.Location.Y);
            panel1.Visible = true;

            this.gridControl1.Refresh();
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            this.SuspendLayout();
            PictureBox pBox = (PictureBox)sender;
            panel2.Location = new Point(pBox.Location.X + 3, panel2.Location.Y);
            panel2.Visible = true;
            WriteStyles(pBox);
            this.ResumeLayout(true);
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = false;
            label1.Visible = false;
        }

        private void WriteStyles(PictureBox pBox)
        {
            switch(pBox.Name)
            {
                case "pictureBox1":
                    label1.Text = "GridVisualStyles : Metro";
                    break;
                case "pictureBox2":
                    label1.Text = "GridVisualStyles : Office2007Blue";
                    break;
                case "pictureBox3":
                    label1.Text = "GridVisualStyles : Office2007Black";
                    break;
                case "pictureBox4":
                    label1.Text = "GridVisualStyles : Office2007Silver";
                    break;
                case "pictureBox5":
                    label1.Text = "GridVisualStyles : Office2010Blue";
                    break;
                case "pictureBox6":
                    label1.Text = "GridVisualStyles : Office2010Black";
                    break;
                case "pictureBox7":
                    label1.Text = "GridVisualStyles : Office2010Silver";
                    break;
            }
            label1.Visible = true;
        }

        void gridControl1_CheckBoxClick(object sender, GridCellClickEventArgs e)
        {
            this.gridControl1.BeginUpdate();
            switch (e.RowIndex)
            {
                case 10:
                    for (int i = 11; i <= 14; i++)
                    {
                        gridControl1.HideRows[i] = !gridControl1.HideRows[i];
                    }
                    break;
            }
            this.gridControl1.EndUpdate(true);
            this.gridControl1.Refresh();
        }
        #endregion

        private void InitializeGrid()
        {
            #region Style declaration
            this.gridControl1.DefaultRowHeight = 18;
            GridStyleInfo headerstyle = new GridStyleInfo();
            headerstyle.Font.Size = 12;
            headerstyle.Font.Bold = true;
            headerstyle.TextColor = Color.Black;
            headerstyle.VerticalAlignment = GridVerticalAlignment.Middle;
            headerstyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            headerstyle.CellType = GridCellTypeName.Static;

            GridStyleInfo subheaderstyle = new GridStyleInfo();
            subheaderstyle.Font.Bold = true;
            subheaderstyle.VerticalAlignment = GridVerticalAlignment.Middle;
            subheaderstyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            subheaderstyle.CellType = GridCellTypeName.Static;

            GridStyleInfo valuestyle = new GridStyleInfo();
            valuestyle.BackColor = SystemColors.Menu;
            valuestyle.TextColor = Color.Black;
            valuestyle.VerticalAlignment = GridVerticalAlignment.Middle;
            valuestyle.HorizontalAlignment = GridHorizontalAlignment.Center;

            gridControl1.FloatCellsMode = GridFloatCellsMode.BeforeDisplayCalculation;
            gridControl1.Model.EnableLegacyStyle = true;
            int rowIndex = 1, colIndex = 2;
            #endregion

            #region ComboBoxCell (1 to 15)
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "DropDown Cells";

            rowIndex += 3;

            ArrayList USStates = new ArrayList();
            USStates.Add(new USState("Alabama", "AL", 0));
            USStates.Add(new USState("Alaska", "AK", 1));
            USStates.Add(new USState("Arizona", "AZ", 2));
            USStates.Add(new USState("Arkansas", "AS", 3));
            USStates.Add(new USState("California", "CA", 4));
            USStates.Add(new USState("NewJersey", "NJ", 5));
            USStates.Add(new USState("Seattle", "ST", 6));

            gridControl1[rowIndex, colIndex].FloatCell = true;
            gridControl1.Model.ColWidths[5] = 120;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex, 4));
            gridControl1[rowIndex, 3].Text = "ComboBox Cells";
            gridControl1[rowIndex, 3].TextColor = Color.Black;
            gridControl1[rowIndex, 3].CellType = GridCellTypeName.Static;
            gridControl1[rowIndex, 5].Text = "Select your choice";
            gridControl1[rowIndex, 5].CellType = GridCellTypeName.ComboBox;
            gridControl1[rowIndex, 5].DataSource = USStates;
            gridControl1[rowIndex, 5].DisplayMember = "LongName";
            gridControl1[rowIndex, 5].ValueMember = "ShortName";

            rowIndex++; rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex, 4));
            gridControl1[rowIndex, 3].Text = "GridListControl Cells";
            gridControl1[rowIndex, 3].TextColor = Color.Black;
            gridControl1[rowIndex, 3].CellType = GridCellTypeName.Static;
            gridControl1[rowIndex, 5].Text = "Select your choice";
            gridControl1[rowIndex, 5].CellType = GridCellTypeName.GridListControl;
            gridControl1[rowIndex, 5].DataSource = USStates;
            gridControl1[rowIndex, 5].DisplayMember = "LongName";
            gridControl1[rowIndex, 5].ValueMember = "ShortName";

            rowIndex++; rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex, 4));
            gridControl1[rowIndex, 3].Text = "DropDown Grid Cells";
            gridControl1[rowIndex, 3].TextColor = Color.Black;
            gridControl1[rowIndex, 3].CellType = GridCellTypeName.Static;
            gridControl1[rowIndex, 5].CellType = GridCellTypeName.DropDownGrid;
            //gridControl1[rowIndex, 5].DataSource = USStates;
            //gridControl1[rowIndex, 5].DisplayMember = "LongName";
            //gridControl1[rowIndex, 5].ValueMember = "ShortName";
            rowIndex += 2;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex, 7));
            gridControl1[rowIndex, 3].CellType = GridCellTypeName.CheckBox;
            gridControl1[rowIndex, 3].Description = "For themed scrollbars in DropDown";
            rowIndex++;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 3, rowIndex + 3, 7));
            gridControl1[rowIndex, 3].TextColor = Color.Black;
            gridControl1[rowIndex, 3].CellType = GridCellTypeName.Static;
            gridControl1[rowIndex, 3].Text
                = "Dropdown can use the themed scrollbars only when. \n\n 1. LegacyStyles should be disabled which will applies the ColorStyles \n 2. \"EnableGridListControlInComboBox\" property should be enabled.";
            gridControl1[rowIndex, 3].FloatCell = true;

            for (int i = rowIndex; i <= rowIndex + 3; i++)
                gridControl1.HideRows[i] = true;

            rowIndex = 14;
            #endregion

            #region RadioButtons ( 16 to 18)
            rowIndex += 2;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Radio Buttons";

            rowIndex += 2;
            StringCollection sc = new StringCollection();
            sc.AddRange(new String[]{	"Button 0", 
										"Disabled/disabled", 
										"Button 2", 
										"Button 3"});
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex, gridControl1.ColCount - 1));
            this.gridControl1[rowIndex, 1].ChoiceList = sc;
            this.gridControl1[rowIndex, 1].CellType = "RadioButton";
            this.gridControl1[rowIndex, 1].Font.Bold = true;
            this.gridControl1[rowIndex, 1].CellValue = 0;//selected button
            this.gridControl1[rowIndex, 1].TextAlign = GridTextAlign.Left;//where descriptions are
            this.gridControl1[rowIndex, 1].TextMargins.Left = 5;
            this.gridControl1[rowIndex, 1].TextMargins.Right = 5;
            #endregion

            #region PushButtons 20 to 23
            rowIndex += 2;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex+1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "Push Buttons";

            rowIndex += 3;
            gridControl1.RowHeights[rowIndex] = 22;
            gridControl1[rowIndex, colIndex].Description = "Raised";
            gridControl1[rowIndex, colIndex].CellType = GridCellTypeName.PushButton;
            gridControl1[rowIndex, colIndex].CellAppearance = GridCellAppearance.Raised;
            gridControl1[rowIndex, colIndex].Font.Size = 8;
            gridControl1[rowIndex, colIndex + 2].Description = "Flat";
            gridControl1[rowIndex, colIndex + 2].CellType = GridCellTypeName.PushButton;
            gridControl1[rowIndex, colIndex + 2].Font.Size = 8;
            gridControl1[rowIndex, colIndex + 4].Description = "Sunken";
            gridControl1[rowIndex, colIndex + 4].CellType = GridCellTypeName.PushButton;
            gridControl1[rowIndex, colIndex + 4].Font.Size = 8;
            gridControl1[rowIndex, colIndex + 4].CellAppearance = GridCellAppearance.Sunken;
            #endregion

            #region CheckBox cells
            rowIndex += 2;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "CheckBox Cells";

            rowIndex += 3;

            gridControl1.TableStyle.CheckBoxOptions = new GridCheckBoxCellInfo("True", "False", "", false);
            gridControl1[rowIndex, colIndex].CellValue = false;
            gridControl1[rowIndex, colIndex].Description = "Click Me";
            gridControl1[rowIndex, colIndex].CellType = "CheckBox";
            gridControl1[rowIndex, colIndex].TriState = false;
            gridControl1[rowIndex, colIndex + 2].CellValue = true;
            gridControl1[rowIndex, colIndex + 2].CellType = "CheckBox";
            gridControl1[rowIndex, colIndex + 2].TriState = true;
            gridControl1[rowIndex, colIndex + 2].Description = "TriState";
            gridControl1[rowIndex, colIndex + 2].VerticalAlignment = GridVerticalAlignment.Middle;
            gridControl1[rowIndex, colIndex + 4].Text = "True";
            gridControl1[rowIndex, colIndex + 4].CellType = "CheckBox";
            gridControl1[rowIndex, colIndex + 4].TriState = false;
            gridControl1[rowIndex, colIndex + 4].Description = "Disabled";
            gridControl1[rowIndex, colIndex + 4].Enabled = false;
            gridControl1[rowIndex, colIndex + 4].VerticalAlignment = GridVerticalAlignment.Bottom;
            #endregion

            #region Header cells
            rowIndex += 2;
            gridControl1.CoveredRanges.Add(GridRangeInfo.Cells(rowIndex, 1, rowIndex + 1, gridControl1.ColCount));
            gridControl1[rowIndex, 1] = headerstyle;
            gridControl1[rowIndex, 1].Text = "CheckBox Cells";

            rowIndex += 3;

            gridControl1[rowIndex, colIndex].Text = "Header";
            gridControl1[rowIndex, colIndex].CellType = GridCellTypeName.Header;
            gridControl1[rowIndex, colIndex + 2].Text = "Column Header";
            gridControl1[rowIndex, colIndex + 2].CellType = GridCellTypeName.Header;
            gridControl1[rowIndex, colIndex + 4].Text = "Row Header";
            gridControl1[rowIndex, colIndex + 4].CellType = GridCellTypeName.Header;

            gridControl1.ColWidths[4] = 90;
            gridControl1.ColWidths[6] = 90;
            //gridControl1.ColWidths[8] = 90;
            #endregion
        }

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
}
