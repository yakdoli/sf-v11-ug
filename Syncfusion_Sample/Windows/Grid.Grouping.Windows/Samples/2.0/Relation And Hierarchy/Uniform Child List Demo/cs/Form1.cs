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
using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms;

namespace UniformChildList
{

    public partial class Form1 : MetroForm 
    {

        BindingList<ParentObj> topList = new BindingList<ParentObj>();
        BindingList<ChildObj> childList = new BindingList<ChildObj>();
        
        public Form1() {
            InitializeComponent();
            SetupLists();
            
            grid.DataSource = topList;
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            this.grid.TableOptions.ShowRecordPlusMinus = true;
            this.grid.NestedTableGroupOptions.ShowCaptionPlusMinus = false;
            this.grid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.grid.TopLevelGroupOptions.ShowAddNewRecordAfterDetails = false;
            this.grid.NestedTableGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.grid.NestedTableGroupOptions.ShowAddNewRecordAfterDetails = false;
            this.grid.ChildGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.grid.ChildGroupOptions.ShowAddNewRecordAfterDetails = false;

            this.grid.Appearance.AlternateRecordFieldCell.BackColor = Color.FromArgb(255, 233, 176);
            this.grid.Appearance.AnyRecordFieldCell.TextColor = Color.FromArgb(0, 0, 102);

            GridRelationDescriptor relation = new GridRelationDescriptor();
            relation.RelationKind = RelationKind.UniformChildList;
            relation.MappingName = "Child";
            relation.Name = "Child";
            relation.ChildTableName = "ChildTable";
            grid.TableDescriptor.Relations.Add(relation);

            this.grid.ShowGroupDropArea = true;
            GridTable chiltTable = grid.GetTable("ChildTable");
            this.grid.AddGroupDropArea(chiltTable);
            chiltTable.TableDescriptor.GroupedColumns.Add("Field1");
           
            this.grid.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.grid.TopLevelGroupOptions.ShowCaption = false;
          //  this.BackColor = Color.FromArgb(223, 227, 239);
            this.grid.GridVisualStyles = GridVisualStyles.Metro;
            this.grid.GridOfficeScrollBars = OfficeScrollBars.Metro;
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

		
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        Random r = new Random();
        private void SetupLists() 
        {

            for(int i =0;i<30;i++)
                childList.Add(new ChildObj(string.Format("Name{0}", r.Next(10)), string.Format("Desc{0}", r.Next(20)), r.Next(30)));

            for (int i = 0; i < 5; i++)
            {
                topList.Add(new ParentObj(string.Format("Name{0}",r.Next(5)),string.Format("Desc{0}",r.Next(15)),r.Next(20)));
                for (int j = i * 5; j < (i * 5) + 5; j++)
                    topList[i].Child.Add(childList[j]);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Record rec = grid.Table.Records[grid.Table.Records.Count - 1];
            string field1 = rec.GetValue("Field1").ToString();
            for (int i = 0; i < topList.Count; i++)
            {
                if(field1 == topList[i].Field1)
                    topList[i].Child.Add(new ChildObj(string.Format("Name{0}", r.Next(10)), string.Format("Desc{0}", r.Next(20)), r.Next(30)));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
                childList.Add(new ChildObj(string.Format("Name{0}", r.Next(10)), string.Format("Desc{0}", r.Next(20)), r.Next(30)));

            topList.Add(new ParentObj(string.Format("Name{0}", r.Next(2)), string.Format("Desc{0}", r.Next(15)), r.Next(20)));
            for (int j = 0; j < 5 ; j++)
                topList[topList.Count - 1].Child.Add(childList[childList.Count - (1+j)]);
        }
    }
}