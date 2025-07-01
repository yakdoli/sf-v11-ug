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

using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Grouping;


namespace CustomFieldType
{
	
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : MetroForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		GridGroupingControl gridGroupingControl1;

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
            

			Random rand = new Random();

			DataTable table = new DataTable();
			table.Columns.Add("FooColumn1", typeof(Foo));
			table.Columns.Add("FooColumn2", typeof(NestedFoo));
			table.Columns.Add("Boolean", typeof(bool));
			table.Columns.Add("Color", typeof(Color));
			table.Columns.Add("Font", typeof(Font));
			table.Columns.Add("PatternStyle", typeof(Syncfusion.Drawing.PatternStyle));
			table.Columns.Add("DockStyle", typeof(DockStyle));
			table.Columns.Add("FieldDescriptor", typeof(FieldDescriptor));
			table.Columns.Add("BordersInfo", typeof(GridBordersInfo));


			// and then add a few rows:
			for ( int i=0; i < 50; i++ )
			{
				table.Rows.Add(table.NewRow());
				
				// Simple nested properties
				Foo foo = new Foo();
				foo.PropertyOne = rand.Next().ToString();
				foo.PropertyTwo = rand.Next().ToString();
				table.Rows[i][0] = foo;
				
				// Nested with nested properties
				NestedFoo nestedFoo = new NestedFoo();
				nestedFoo.SomeProperty = rand.Next().ToString();
				nestedFoo.Inner.PropertyOne = rand.Next().ToString();
				nestedFoo.Inner.PropertyTwo = rand.Next().ToString();
				table.Rows[i][1] = nestedFoo;

				// Boolean
				if (i % 2 == 0)
					table.Rows[i][2] = (i % 4 == 0);

				// Color
				table.Rows[i][3] = SystemColors.ActiveBorder;

				// Font
				if (i % 4 == 0)
					table.Rows[i][4] = new Font("Arial", 12);

                table.Rows[i]["BordersInfo"] = new GridBordersInfo();
                table.Rows[i]["FieldDescriptor"] = new FieldDescriptor();
			}

			// now assign the datasource
			gridGroupingControl1 = new GridGroupingControl();
			gridGroupingControl1.Dock = DockStyle.Fill;
			gridGroupingControl1.DataSource = table;

			GridTableDescriptor td = this.gridGroupingControl1.TableDescriptor;
			FieldDescriptor unboundFd = new FieldDescriptor("Unbound");
			td.UnboundFields.Add(unboundFd);

			// In case you want to manually add fields here
			gridGroupingControl1.TableDescriptor.Columns.Clear();
			gridGroupingControl1.TableDescriptor.Columns.Add("FooColumn1_PropertyOne");
			gridGroupingControl1.TableDescriptor.Columns.Add("FooColumn1_PropertyTwo");
			gridGroupingControl1.TableDescriptor.Columns.Add("FooColumn2_SomeProperty");
			gridGroupingControl1.TableDescriptor.Columns.Add("FooColumn2_Inner_PropertyOne");
			gridGroupingControl1.TableDescriptor.Columns.Add("FooColumn2_Inner_PropertyTwo");
			gridGroupingControl1.TableDescriptor.Columns.Add("Boolean");
			gridGroupingControl1.TableDescriptor.Columns.Add("Color");
			gridGroupingControl1.TableDescriptor.Columns.Add("Font");
			gridGroupingControl1.TableDescriptor.Columns.Add("PatternStyle");
			gridGroupingControl1.TableDescriptor.Columns.Add("DockStyle");
			gridGroupingControl1.TableDescriptor.Columns.Add("FieldDescriptor");
			gridGroupingControl1.TableDescriptor.Columns.Add("BordersInfo");
			gridGroupingControl1.TableDescriptor.Columns.Add("Unbound");
            
			this.Controls.Add(gridGroupingControl1);

			gridGroupingControl1.SaveValue += new FieldValueEventHandler(grid_SaveValue);
			gridGroupingControl1.QueryValue += new FieldValueEventHandler(grid_QueryValue);
            this.gridGroupingControl1.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.GridOfficeScrollBars = OfficeScrollBars.Metro;
			// enable/disable UITYpeEditors for cells.
			bool showUITypeEditors = true;
			this.gridGroupingControl1.TableOptions.AllowDropDownCell = showUITypeEditors;
			this.gridGroupingControl1.TableDescriptor.Columns["Boolean"].Appearance.AnyRecordFieldCell.CellType="ComboBox";

			Console.WriteLine(GridPropertyTypeDefaultStyleCollection.Default["System.Boolean"].Style);

			// enable/disable UITYpeEditors for boolean cells only and show checkbox instead.
			bool displayCheckBoxForBooleanFields = false;
			if (displayCheckBoxForBooleanFields)
			{
				GridPropertyTypeDefaultStyle booleanDefault = this.gridGroupingControl1.Engine.PropertyTypeDefaultStyles["System.Boolean"];
				booleanDefault.AllowDropDown = false;
			}

			
			// Sample code to get the row and column index in the grid for a column (works also
			// if column sets with multiple rows are specified).
			bool useOldCodeToGetCellInfo = false;
			if (useOldCodeToGetCellInfo)
			{
				GridColumnDescriptor cd = this.gridGroupingControl1.TableDescriptor.Columns["Boolean"];
				int relativeRowIndex, colIndex;
				this.gridGroupingControl1.TableDescriptor.ColumnToRowColIndex(cd.MappingName, out relativeRowIndex, out colIndex);
				
				Record r = this.gridGroupingControl1.Table.Records[0];
				int recordRowIndex = this.gridGroupingControl1.Table.DisplayElements.IndexOf(r);
				
				int rowIndex = recordRowIndex + relativeRowIndex;
				GridTableCellStyleInfo style = this.gridGroupingControl1.Table.GetTableCellStyle(rowIndex, colIndex + this.gridGroupingControl1.TableDescriptor.GetColumnIndentCount());

				Console.WriteLine(style.TableCellIdentity.ToString());
				Console.WriteLine(style.ToString());
			}
			else
			{
				// Newer code using new GetTableCellStyle overloads after version 3.0.0.16
				Record r = this.gridGroupingControl1.Table.Records[0];
				GridTableCellStyleInfo style = this.gridGroupingControl1.Table.GetTableCellStyle(r, "Boolean");

				Console.WriteLine(style.TableCellIdentity.ToString());
				Console.WriteLine(style.ToString());
			}

            this.gridGroupingControl1.TableOptions.GridVisualStyles = GridVisualStyles.Metro;
            this.gridGroupingControl1.TableOptions.GridLineBorder = new GridBorder(GridBorderStyle.Solid, Color.FromArgb(208, 215, 229), GridBorderWeight.Thin);
            this.gridGroupingControl1.TopLevelGroupOptions.ShowAddNewRecordBeforeDetails = false;
            this.gridGroupingControl1.TopLevelGroupOptions.ShowCaption = false;
            this.gridGroupingControl1.Appearance.AnyCell.Font.Facename = "Verdana";
            this.gridGroupingControl1.Appearance.AnyCell.TextColor = Color.MidnightBlue;
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
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.DropShadow = true;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            
            this.Text = "Custom Field Type Demo";
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

		private void grid_SaveValue(object sender, FieldValueEventArgs e)
		{
			Console.WriteLine("grid_SaveValue: " + e.ToString());
		}

		private void grid_QueryValue(object sender, FieldValueEventArgs e)
		{
			e.Value = e.Record.ParentTable.Records.IndexOf(e.Record);
		}
	}

	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class Foo
	{
		string someProperty;
		string someProperty2;

		public string PropertyOne
		{
			get
			{
				return someProperty;
			}
			set
			{
				someProperty = value;
			}
		}

		public string PropertyTwo
		{
			get
			{
				return someProperty2;
			}
			set
			{
				someProperty2 = value;
			}
		}
	} 

	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class NestedFoo
	{
		string someProperty;
		Foo someFoo = new Foo();

		public string SomeProperty
		{
			get
			{
				return someProperty;
			}
			set
			{
				someProperty = value;
			}
		}

		public Foo Inner
		{
			get
			{
				return someFoo;
			}
		}
	} 

}
