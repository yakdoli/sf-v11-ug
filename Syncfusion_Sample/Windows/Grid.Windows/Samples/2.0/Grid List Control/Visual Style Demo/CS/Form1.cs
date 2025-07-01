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

            #region Datasources
            ArrayList USStates = new ArrayList();
            USStates.Add(new USState("Alaska", "AK", 1));
            USStates.Add(new USState("Arizona", "AZ", 2));
            USStates.Add(new USState("Arkansas", "AK", 3));
            USStates.Add(new USState("California", "CA", 4));
            USStates.Add(new USState("Colorado", "CO", 5));
            USStates.Add(new USState("Connecticut", "CT", 6));
            USStates.Add(new USState("Delaware", "DE", 3));
            USStates.Add(new USState("Florida", "FL", 4));
            USStates.Add(new USState("Georgia", "GA", 1));
            USStates.Add(new USState("Hawaii", "HI", 0));
            USStates.Add(new USState("Idaho", "ID", 3));
            USStates.Add(new USState("Illinois", "IL", 2));
            USStates.Add(new USState("Indiana", "IN", 6));
            USStates.Add(new USState("Iowa", "IA", 5));
            USStates.Add(new USState("Kansas", "KA", 5));
            USStates.Add(new USState("Kentucky", "KY", 4));
            USStates.Add(new USState("Louisiana", "LA", 3));
            USStates.Add(new USState("Maine", "ME", 0));
            USStates.Add(new USState("Maryland", "MD", 0));
            USStates.Add(new USState("Massachusetts", "MA", 2));
            USStates.Add(new USState("Michigan", "MI", 1));
            USStates.Add(new USState("Minnesota", "MN", 6));
            USStates.Add(new USState("Mississippi", "MS", 5));
            USStates.Add(new USState("Missouri", "MO", 2));
            USStates.Add(new USState("Montana", "MT", 1));
            USStates.Add(new USState("Nebraska", "NE", 4));
            USStates.Add(new USState("Nevada", "NV", 0));
            USStates.Add(new USState("New Hampshire", "NH", 3));
            USStates.Add(new USState("New Jersey", "NJ", 3));
            USStates.Add(new USState("New Mexico", "NM", 2));
            USStates.Add(new USState("New York", "NY", 5));
            USStates.Add(new USState("North Carolina", "NC", 4));
            USStates.Add(new USState("North Dakota", "ND", 4));
            USStates.Add(new USState("Ohio", "OH", 1));
            USStates.Add(new USState("Oklahoma", "OK", 2));
            USStates.Add(new USState("Oregon", "OR", 5));
            USStates.Add(new USState("Pennsylvania", "PA", 0));
            USStates.Add(new USState("Rhode Island", "RI", 6));
            USStates.Add(new USState("South Carolina", "SC", 5));
            USStates.Add(new USState("South Dakota", "SD", 4));
            USStates.Add(new USState("Tennessee", "TN", 3));
            USStates.Add(new USState("Texas", "TX", 2));
            USStates.Add(new USState("Utah", "UT", 0));
            USStates.Add(new USState("Vermont", "VT", 1));
            USStates.Add(new USState("Virginia", "VA", 0));
            USStates.Add(new USState("Washington", "WA", 2));
            USStates.Add(new USState("West Virginia", "WV", 0));
            USStates.Add(new USState("Wisconsin", "WI", 3));
            USStates.Add(new USState("Wyoming", "WY", 5));
            #endregion

            #region Initialization settings
            this.gridControl1.DataSource = USStates;
            this.gridControl1.ShowColumnHeader = true;
            this.gridControl1.MultiColumn = true;
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.Grid.Model.EnableLegacyStyle = false;
            this.gridControl1.DataSource = USStates;
            this.gridControl1.DisplayMember = "ShortName";
            this.gridControl1.ValueMember = "LongName";
            this.gridControl1.Grid.Model.ColWidths[1] = 150;
            this.gridControl1.Grid.Model.ColWidths[2] = 150;
            this.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Office2010Black;
            this.gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2010;
            this.gridControl1.Grid.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black;
            #endregion

            
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
                    this.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Metro;
                    gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Metro;
                    break;
                case "pictureBox2":
                    this.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Office2007Blue;
                    gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2007;
                    gridControl1.Grid.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Blue;
                    break;
                case "pictureBox3":
                    this.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Office2007Black;
                    gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2007;
                    gridControl1.Grid.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Black;
                    break;
                case "pictureBox4":
                    this.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Office2007Silver;
                    gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2007;
                    gridControl1.Grid.Office2007ScrollBarsColorScheme = Office2007ColorScheme.Silver;
                    break;
                case "pictureBox5":
                    this.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Office2010Blue;
                    gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2010;
                    gridControl1.Grid.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Blue;
                    break;
                case "pictureBox6":
                    this.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Office2010Black;
                    gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2010;
                    gridControl1.Grid.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Black;
                    break;
                case "pictureBox7":
                    this.gridControl1.Grid.GridVisualStyles = GridVisualStyles.Office2010Silver;
                    gridControl1.Grid.GridOfficeScrollBars = OfficeScrollBars.Office2010;
                    gridControl1.Grid.Office2010ScrollBarsColorScheme = Office2010ColorScheme.Silver;
                    break;

            }

            label6.Text = gridControl1.Grid.GridVisualStyles.ToString();
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
}
