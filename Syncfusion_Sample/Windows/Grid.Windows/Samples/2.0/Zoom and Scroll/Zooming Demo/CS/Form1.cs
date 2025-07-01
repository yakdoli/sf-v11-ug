﻿#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Drawing;
using Syncfusion.Styles;
using Syncfusion.GridHelperClasses;
using System.IO;
using System.Data.SqlClient;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;

namespace ZoomGrid1
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        #region Private Members
        private TrackBar trackBar1;
        private ComboBoxAdv comboBox1;
        private CheckBoxAdv checkBox1;
        private Label label2;
        private GridControl gridControl1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;     
        
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        ZoomGrid zoom;
        #endregion

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            #region Initial Settings
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(GetFile("Datasource.xml"));

            this.gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, 20, 9), dataSet.Tables[0]);
            this.gridControl1.PopulateHeaders(GridRangeInfo.Cells(0, 1, this.gridControl1.RowCount, this.gridControl1.ColCount), dataSet.Tables[0]);
            
            zoom = new ZoomGrid(this.gridControl1);
            ZoomGrid.ZoomGridControlCell = true;

            this.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Table());
            #endregion
        }

        #region Form Handlers
        private string GetFile(string fileName)
        {
            string dataFileName = @"" + fileName;
            for (int n = 0; n < 12; n++)
            {
                if (System.IO.File.Exists(dataFileName))
                {
                    return new FileInfo(dataFileName).FullName;
                }
                dataFileName = @"..\" + dataFileName;
            }
            return dataFileName;
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

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle1 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.comboBox1 = new Syncfusion.Windows.Forms.Tools.ComboBoxAdv();
            this.checkBox1 = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label2 = new System.Windows.Forms.Label();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.Color.White;
            this.trackBar1.Location = new System.Drawing.Point(99, 83);
            this.trackBar1.Maximum = 250;
            this.trackBar1.Minimum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(96, 28);
            this.trackBar1.TabIndex = 12;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 100;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Items.AddRange(new object[] {
            "50",
            "75",
            "100",
            "125"});
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "50"));
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "75"));
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "100"));
            this.comboBox1.ItemsImageIndexes.Add(new Syncfusion.Windows.Forms.Tools.ComboBoxAdv.ImageIndexItem(this.comboBox1, "125"));
            this.comboBox1.Location = new System.Drawing.Point(97, 28);
            this.comboBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 21);
            this.comboBox1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro;
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "100";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.Black;
            this.checkBox1.Location = new System.Drawing.Point(65, 21);
            this.checkBox1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 17);
            this.checkBox1.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Zoom Cell";
            this.checkBox1.ThemesEnabled = false;
            this.checkBox1.CheckedChanged += new Syncfusion.Windows.Forms.Tools.CheckedChangedEventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(22, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 65);
            this.label2.TabIndex = 15;
            this.label2.Text = "Click a cell to view in zoomed state. \r\n\r\nUse the above slider and dropdown to zo" +
                "om the grid in different values.";
            // 
            // gridControl1
            // 
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 5;
            this.gridControl1.DefaultColWidth = 85;
            this.gridControl1.DefaultRowHeight = 20;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.HorizontalThumbTrack = true;
            this.gridControl1.Location = new System.Drawing.Point(12, 17);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            gridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle1.StyleInfo.Font.Bold = false;
            gridRangeStyle1.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle1.StyleInfo.Font.Italic = false;
            gridRangeStyle1.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle1.StyleInfo.Font.Strikeout = false;
            gridRangeStyle1.StyleInfo.Font.Underline = false;
            gridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle1.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl1.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
            gridRangeStyle1});
            this.gridControl1.RowCount = 20;
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(476, 347);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 16;
            this.gridControl1.Text = "gridControl1";
            this.gridControl1.ThemesEnabled = true;
            this.gridControl1.UseRightToLeftCompatibleTextBox = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(502, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 347);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zooming Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(25, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(207, 57);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cell Level";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Location = new System.Drawing.Point(25, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 129);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Zoom Frequency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Zoom Level";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(768, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl1);
            this.DropShadow = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
			this.BorderThickness = 2;
            this.Text = "Zooming Demo";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

       
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }
        #endregion

        #region Event Handlers

        private void checkBox1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            ZoomGrid.ZoomGridControlCell = this.checkBox1.Checked;
            if (this.checkBox1.Checked) this.trackBar1.Value = 100;
        }      

        void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            zoom.zoomGrid(this.trackBar1.Value.ToString());
            this.comboBox1.Text = this.trackBar1.Value.ToString();
            if (this.trackBar1.Value == 100)
                this.checkBox1.Checked = true;
            else
                this.checkBox1.Checked = false;
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.SelectedItem != null)
            {
                zoom.zoomGrid(this.comboBox1.SelectedItem.ToString());
                if (this.comboBox1.SelectedItem.ToString() == "100")
                    this.checkBox1.Checked = true;
                else
                    this.checkBox1.Checked = false;
            }
        }
        #endregion

    }
}
