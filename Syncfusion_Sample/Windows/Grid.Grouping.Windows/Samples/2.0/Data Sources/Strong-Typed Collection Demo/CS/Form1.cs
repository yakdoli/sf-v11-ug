#region Copyright Syncfusion Inc. 2001 - 2013
//
//  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
//
//  Use of this code is subject to the terms of our license.
//  A copy of the current license can be obtained at any time by e-mailing
//  licensing@syncfusion.com. Any infringement will be prosecuted under
//  applicable laws. 
//
#endregion

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Grouping;

using Syncfusion.Collections;
using Syncfusion.Drawing;
using Syncfusion.ComponentModel;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid.Grouping;

namespace StrongTypedCollectionSample
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : MetroForm
    {
        private Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl groupingGrid1;
        private PropertyGrid propertyGrid1;
        private Panel panel1;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

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
            CustomerCollection customers = PopulateCustomers.CreateCustomers();

            this.groupingGrid1.ShowNavigationBar = true;
            this.groupingGrid1.TableControl.HorizontalScrollTips = false;
            this.groupingGrid1.BorderStyle = BorderStyle.FixedSingle;
            this.groupingGrid1.FilterRuntimeProperties = true;

            this.groupingGrid1.DataSource = customers;

            GridEngine engine = this.groupingGrid1.Engine;
            engine.TopLevelGroupOptions.ShowCaption = true;

            GridRelationDescriptorCollection relations = new GridRelationDescriptorCollection();

            // First level
            GridRelationDescriptor rd = AddRelation("Level_0", relations);

            // Subsequent levels
            for (int level = 1; level < 5; level++)
            {
                rd = AddRelation("Level_" + level.ToString(), rd.ChildTableDescriptor.Relations);
            }

            this.groupingGrid1.TableDescriptor.Relations = relations;

            this.groupingGrid1.TableOptions.ShowRecordPlusMinus = true;
            this.groupingGrid1.NestedTableGroupOptions.ShowCaptionPlusMinus = false;
            this.groupingGrid1.Table.ExpandAllRecords();
            Syncfusion.Grouping.Diagnostics.IterateThroughNestedDisplayElement(this.groupingGrid1.Table);
            this.groupingGrid1.TableOptions.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2007Blue;
            this.groupingGrid1.TableOptions.GridLineBorder = new Syncfusion.Windows.Forms.Grid.GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.groupingGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.groupingGrid1.TopLevelGroupOptions.ShowCaption = false;
            this.groupingGrid1.Appearance.AnyCell.Font.Facename = "Verdana";
            this.groupingGrid1.Appearance.AnyCell.TextColor = Color.MidnightBlue;
            this.BackColor = Color.White;
            this.propertyGrid1.SelectedObject  = this.groupingGrid1;
            this.propertyGrid1.BackColor = Color.White;
            this.DropShadow = true;
            this.groupingGrid1.GridVisualStyles = GridVisualStyles.Metro;


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
		
        GridRelationDescriptor AddRelation(string name, GridRelationDescriptorCollection relations)
        {
            GridRelationDescriptor children = new GridRelationDescriptor();
            children.RelationKind = RelationKind.UniformChildList;
            children.MappingName = "Children";
            children.Name = name;
            relations.Add(children);
            return children;
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
            this.groupingGrid1 = new Syncfusion.Windows.Forms.Grid.Grouping.GridGroupingControl();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.groupingGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupingGrid1
            // 
            this.groupingGrid1.BackColor = System.Drawing.SystemColors.Window;
            this.groupingGrid1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.groupingGrid1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.groupingGrid1.Location = new System.Drawing.Point(21, 23);
            this.groupingGrid1.Name = "groupingGrid1";
            this.groupingGrid1.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.groupingGrid1.NestedTableGroupOptions.ShowCaption = true;
            this.groupingGrid1.Size = new System.Drawing.Size(536, 392);
            this.groupingGrid1.TabIndex = 1;
            this.groupingGrid1.TableDescriptor.AllowNew = false;
            this.groupingGrid1.TableDescriptor.Appearance.AnyCell.Font.Facename = "Segoe UI";
            this.groupingGrid1.TableDescriptor.Appearance.AnyCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))));
            this.groupingGrid1.TableDescriptor.Appearance.AnyGroupCell.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.groupingGrid1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnyRecordFieldCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnySummaryCell.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnySummaryCell.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            this.groupingGrid1.TableDescriptor.Appearance.AnySummaryCell.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))));
            this.groupingGrid1.TableDescriptor.Appearance.ColumnHeaderCell.Font.Bold = true;
            this.groupingGrid1.TableDescriptor.Appearance.GroupCaptionCell.CellType = "ColumnHeader";
            this.groupingGrid1.TableDescriptor.TableOptions.ColumnHeaderRowHeight = 25;
            this.groupingGrid1.TableDescriptor.TableOptions.RecordRowHeight = 20;
            this.groupingGrid1.Text = "groupingGrid1";
            this.groupingGrid1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.groupingGrid1.TopLevelGroupOptions.ShowCaption = false;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.CommandsDisabledLinkColor = System.Drawing.Color.White;
            this.propertyGrid1.HelpBackColor = System.Drawing.Color.White;
            this.propertyGrid1.LineColor = System.Drawing.Color.White;
            this.propertyGrid1.Location = new System.Drawing.Point(598, 23);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(229, 392);
            this.propertyGrid1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(577, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 364);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(845, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.groupingGrid1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strong-Typed Collection Demo";
            ((System.ComponentModel.ISupportInitialize)(this.groupingGrid1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
       
    }
}