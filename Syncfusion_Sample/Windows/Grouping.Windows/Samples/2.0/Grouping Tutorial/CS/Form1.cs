#region Copyright Syncfusion Inc. 2001 - 2006
//
//  Copyright Syncfusion Inc. 2001 - 2006. All rights reserved.
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
using Syncfusion.Grouping;

namespace GroupingWork
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button rawList;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button listSortedOnB;
		private System.Windows.Forms.Button listSortedOnBcomparer;
		private System.Windows.Forms.Button groupByC;
		private System.Windows.Forms.Button groupByCD;
		private System.Windows.Forms.NumericUpDown itemCount;
		private System.Windows.Forms.Button clearText;
		private System.Windows.Forms.Button filter;
		private System.Windows.Forms.TextBox filterString;
		private System.Windows.Forms.Button reset;
		private System.Windows.Forms.Button displayElements;
		private System.Windows.Forms.Button elements;
		private System.Windows.Forms.Button filteredRecords;
		private System.Windows.Forms.Button expandGroups;
		private System.Windows.Forms.Button collapseAll;
		private System.Windows.Forms.Button summaries;
		private System.Windows.Forms.ComboBox summaryMappingName;
		private System.Windows.Forms.ComboBox summaryType;
		private System.Windows.Forms.Button ClearSortsFiltersEtc;
		private System.Windows.Forms.Button sortedRecords;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			System.Drawing.Icon ico = new System.Drawing.Icon(Syncfusion.Windows.Forms.WinFormsUtils.FindFile("Icon", "sfgrid.ico"));
			this.Icon = ico ;	
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
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
            this.rawList = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listSortedOnB = new System.Windows.Forms.Button();
            this.clearText = new System.Windows.Forms.Button();
            this.listSortedOnBcomparer = new System.Windows.Forms.Button();
            this.groupByC = new System.Windows.Forms.Button();
            this.groupByCD = new System.Windows.Forms.Button();
            this.itemCount = new System.Windows.Forms.NumericUpDown();
            this.filter = new System.Windows.Forms.Button();
            this.filterString = new System.Windows.Forms.TextBox();
            this.reset = new System.Windows.Forms.Button();
            this.displayElements = new System.Windows.Forms.Button();
            this.elements = new System.Windows.Forms.Button();
            this.filteredRecords = new System.Windows.Forms.Button();
            this.sortedRecords = new System.Windows.Forms.Button();
            this.expandGroups = new System.Windows.Forms.Button();
            this.collapseAll = new System.Windows.Forms.Button();
            this.summaries = new System.Windows.Forms.Button();
            this.summaryMappingName = new System.Windows.Forms.ComboBox();
            this.summaryType = new System.Windows.Forms.ComboBox();
            this.ClearSortsFiltersEtc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.itemCount)).BeginInit();
            this.SuspendLayout();
            // 
            // rawList
            // 
            this.rawList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rawList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.rawList.Location = new System.Drawing.Point(376, 136);
            this.rawList.Name = "rawList";
            this.rawList.Size = new System.Drawing.Size(160, 23);
            this.rawList.TabIndex = 0;
            this.rawList.Text = "Display Raw Data";
            this.rawList.Click += new System.EventHandler(this.rawList_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(8, 80);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(344, 280);
            this.textBox1.TabIndex = 1;
            this.textBox1.WordWrap = false;
            // 
            // listSortedOnB
            // 
            this.listSortedOnB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.listSortedOnB.Location = new System.Drawing.Point(8, 8);
            this.listSortedOnB.Name = "listSortedOnB";
            this.listSortedOnB.Size = new System.Drawing.Size(168, 23);
            this.listSortedOnB.TabIndex = 2;
            this.listSortedOnB.Text = "Sorted on B using Default Sort";
            this.listSortedOnB.Click += new System.EventHandler(this.listSortedOnB_Click);
            // 
            // clearText
            // 
            this.clearText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.clearText.Location = new System.Drawing.Point(376, 104);
            this.clearText.Name = "clearText";
            this.clearText.Size = new System.Drawing.Size(160, 23);
            this.clearText.TabIndex = 3;
            this.clearText.Text = "Clear the Display Text";
            this.clearText.Click += new System.EventHandler(this.clear_Click);
            // 
            // listSortedOnBcomparer
            // 
            this.listSortedOnBcomparer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.listSortedOnBcomparer.Location = new System.Drawing.Point(8, 40);
            this.listSortedOnBcomparer.Name = "listSortedOnBcomparer";
            this.listSortedOnBcomparer.Size = new System.Drawing.Size(168, 23);
            this.listSortedOnBcomparer.TabIndex = 4;
            this.listSortedOnBcomparer.Text = "Sorted on B using Custom Sort";
            this.listSortedOnBcomparer.Click += new System.EventHandler(this.listSortedOnBcomparer_Click);
            // 
            // groupByC
            // 
            this.groupByC.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupByC.Location = new System.Drawing.Point(184, 8);
            this.groupByC.Name = "groupByC";
            this.groupByC.Size = new System.Drawing.Size(160, 23);
            this.groupByC.TabIndex = 5;
            this.groupByC.Text = "Group by property C";
            this.groupByC.Click += new System.EventHandler(this.groupByC_Click);
            // 
            // groupByCD
            // 
            this.groupByCD.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupByCD.Location = new System.Drawing.Point(184, 40);
            this.groupByCD.Name = "groupByCD";
            this.groupByCD.Size = new System.Drawing.Size(160, 23);
            this.groupByCD.TabIndex = 6;
            this.groupByCD.Text = "Group by properties C and D";
            this.groupByCD.Click += new System.EventHandler(this.groupByCD_Click);
            // 
            // itemCount
            // 
            this.itemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.itemCount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.itemCount.Location = new System.Drawing.Point(376, 168);
            this.itemCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.itemCount.Name = "itemCount";
            this.itemCount.Size = new System.Drawing.Size(40, 20);
            this.itemCount.TabIndex = 8;
            this.itemCount.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // filter
            // 
            this.filter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filter.Location = new System.Drawing.Point(352, 8);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(72, 23);
            this.filter.TabIndex = 11;
            this.filter.Text = "Filter";
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // filterString
            // 
            this.filterString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filterString.Location = new System.Drawing.Point(352, 32);
            this.filterString.Name = "filterString";
            this.filterString.Size = new System.Drawing.Size(72, 20);
            this.filterString.TabIndex = 12;
            this.filterString.Text = "D like d0*";
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reset.Location = new System.Drawing.Point(416, 168);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(120, 24);
            this.reset.TabIndex = 7;
            this.reset.Text = "Reset Raw Data";
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // displayElements
            // 
            this.displayElements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.displayElements.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.displayElements.Location = new System.Drawing.Point(376, 216);
            this.displayElements.Name = "displayElements";
            this.displayElements.Size = new System.Drawing.Size(160, 24);
            this.displayElements.TabIndex = 9;
            this.displayElements.Text = "Iterate Thru DisplayElements";
            this.displayElements.Click += new System.EventHandler(this.displayElements_Click);
            // 
            // elements
            // 
            this.elements.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.elements.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.elements.Location = new System.Drawing.Point(376, 248);
            this.elements.Name = "elements";
            this.elements.Size = new System.Drawing.Size(160, 23);
            this.elements.TabIndex = 10;
            this.elements.Text = "Iterate Thru Elements";
            this.elements.Click += new System.EventHandler(this.elements_Click);
            // 
            // filteredRecords
            // 
            this.filteredRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.filteredRecords.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.filteredRecords.Location = new System.Drawing.Point(376, 280);
            this.filteredRecords.Name = "filteredRecords";
            this.filteredRecords.Size = new System.Drawing.Size(160, 23);
            this.filteredRecords.TabIndex = 13;
            this.filteredRecords.Text = "Iterate Thru FilteredRecords";
            this.filteredRecords.Click += new System.EventHandler(this.filteredRecords_Click);
            // 
            // sortedRecords
            // 
            this.sortedRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sortedRecords.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sortedRecords.Location = new System.Drawing.Point(376, 312);
            this.sortedRecords.Name = "sortedRecords";
            this.sortedRecords.Size = new System.Drawing.Size(160, 23);
            this.sortedRecords.TabIndex = 14;
            this.sortedRecords.Text = "Iterate Thru Records";
            this.sortedRecords.Click += new System.EventHandler(this.sortedRecords_Click);
            // 
            // expandGroups
            // 
            this.expandGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.expandGroups.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.expandGroups.Location = new System.Drawing.Point(376, 344);
            this.expandGroups.Name = "expandGroups";
            this.expandGroups.Size = new System.Drawing.Size(72, 23);
            this.expandGroups.TabIndex = 16;
            this.expandGroups.Text = "ExpandAll";
            this.expandGroups.Click += new System.EventHandler(this.expandGroups_Click);
            // 
            // collapseAll
            // 
            this.collapseAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.collapseAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.collapseAll.Location = new System.Drawing.Point(464, 344);
            this.collapseAll.Name = "collapseAll";
            this.collapseAll.Size = new System.Drawing.Size(75, 23);
            this.collapseAll.TabIndex = 17;
            this.collapseAll.Text = "CollapseAll";
            this.collapseAll.Click += new System.EventHandler(this.collapseAll_Click);
            // 
            // summaries
            // 
            this.summaries.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.summaries.Location = new System.Drawing.Point(432, 8);
            this.summaries.Name = "summaries";
            this.summaries.Size = new System.Drawing.Size(120, 23);
            this.summaries.TabIndex = 18;
            this.summaries.Text = "Summary";
            this.summaries.Click += new System.EventHandler(this.summaries_Click);
            // 
            // summaryMappingName
            // 
            this.summaryMappingName.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.summaryMappingName.Location = new System.Drawing.Point(432, 32);
            this.summaryMappingName.Name = "summaryMappingName";
            this.summaryMappingName.Size = new System.Drawing.Size(32, 21);
            this.summaryMappingName.TabIndex = 19;
            this.summaryMappingName.Text = "D";
            // 
            // summaryType
            // 
            this.summaryType.Location = new System.Drawing.Point(464, 32);
            this.summaryType.Name = "summaryType";
            this.summaryType.Size = new System.Drawing.Size(88, 21);
            this.summaryType.TabIndex = 20;
            // 
            // ClearSortsFiltersEtc
            // 
            this.ClearSortsFiltersEtc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearSortsFiltersEtc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClearSortsFiltersEtc.Location = new System.Drawing.Point(376, 72);
            this.ClearSortsFiltersEtc.Name = "ClearSortsFiltersEtc";
            this.ClearSortsFiltersEtc.Size = new System.Drawing.Size(160, 23);
            this.ClearSortsFiltersEtc.TabIndex = 21;
            this.ClearSortsFiltersEtc.Text = "Clear Sorts/Filters/Groups";
            this.ClearSortsFiltersEtc.Click += new System.EventHandler(this.ClearSortsFiltersEtc_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(560, 374);
            this.Controls.Add(this.ClearSortsFiltersEtc);
            this.Controls.Add(this.summaryType);
            this.Controls.Add(this.summaryMappingName);
            this.Controls.Add(this.summaries);
            this.Controls.Add(this.collapseAll);
            this.Controls.Add(this.expandGroups);
            this.Controls.Add(this.sortedRecords);
            this.Controls.Add(this.filteredRecords);
            this.Controls.Add(this.filterString);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.elements);
            this.Controls.Add(this.displayElements);
            this.Controls.Add(this.itemCount);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.groupByCD);
            this.Controls.Add(this.groupByC);
            this.Controls.Add(this.listSortedOnBcomparer);
            this.Controls.Add(this.clearText);
            this.Controls.Add(this.listSortedOnB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rawList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grouping Tutorial";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
# if SyncfusionFramework1_1 || SyncfusionFramework2_0  
			Application.EnableVisualStyles();
# endif
			Application.Run(new Form1());
		}

		//the initial number of objects in the IList datasource
		private int nItems = 10;

		//used for display indentation
		private int indentSize = 8;
		private char indentChar = ' ';

		//grouping support objects 
		private Syncfusion.Grouping.Table theTable;
		private Syncfusion.Grouping.Engine engine;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			//create a new grouping engine and assign it a IList datasource
			engine = new Engine();
			engine.SetSourceList(CreateADataSource());
	        engine.RecordAsDisplayElements = true;

			//get a reference to the underlying grouping Table
			theTable = engine.Table;

			//set up the summary combobox with enums..(leaving out custom)
			for(int i = 0; i < 11; ++i)
				this.summaryType.Items.Add(((SummaryType)i).ToString());
			this.summaryType.SelectedItem = "Count";		
		}

		#region Display buttons
		private void displayElements_Click(object sender, System.EventArgs e)
		{
			Show("DisplayElements", theTable.DisplayElements);
		}

		private void elements_Click(object sender, System.EventArgs e)
		{
			Show("Elements", theTable.Elements);
		}

		private void filteredRecords_Click(object sender, System.EventArgs e)
		{
			Show("FilteredRecords", theTable.FilteredRecords);
		}

		private void sortedRecords_Click(object sender, System.EventArgs e)
		{
			Show("SortedRecords", theTable.Records);
		}
		private void expandGroups_Click(object sender, System.EventArgs e)
		{
			this.theTable.ExpandAllGroups();
			SetTitleLine("ExpandAllGroups");
			
		}

		private void collapseAll_Click(object sender, System.EventArgs e)
		{
			CollapseGroup(theTable.TopLevelGroup);
			SetTitleLine("CollapseAllGroups");
			
		}

		//called recursively
		private void CollapseGroup(Group aGroup)
		{
			foreach(Group g in aGroup.Groups)
			{
				CollapseGroup(g);
				g.IsExpanded = false;
			}
		}

		private void Show(string title, IList list)
		{
			SetTitleLine(title);
			string indent = "";
			string text = "";
			foreach(Element o in list)
			{
				int indents = (o is CaptionSection) ? o.GroupLevel : o.GroupLevel + 1;
				indent = new string(indentChar, indents * indentSize);
				
				if(o is Record)
				{
					Record r = o as Record;
					text += string.Format("       \t {0}",  r.GetData()) + Environment.NewLine;
				
				}
				else
					text += string.Format("{1}{0}", o, indent) +  Environment.NewLine;
			}
			this.textBox1.Text += text;
			this.textBox1.SelectionStart = this.textBox1.Text.Length;
			this.textBox1.SelectionLength = 0;
			this.textBox1.ScrollToCaret();

		}
		#endregion

		#region Data Creation
		private IList CreateADataSource()
		{
			//create a datasource - an arraylist of MyObject's
			Random r = new Random();
			ArrayList dataSource = new ArrayList();
			for(int i = 0; i < nItems; ++i)
			{
				dataSource.Add(new MyObject(r.Next(100)));
			}
			
			return dataSource;
		}
		#endregion

		#region Sorting 

		ListSortDirection lsd = ListSortDirection.Descending;
		private ListSortDirection GetSortDirection()
		{
			if(lsd == ListSortDirection.Descending)
				lsd = ListSortDirection.Ascending;
			else
				lsd = ListSortDirection.Descending;
			return lsd;
		}


		
		private void listSortedOnB_Click(object sender, System.EventArgs e)
		{//listSortedOnB

			ListSortDirection dir = GetSortDirection();
			theTable.TableDescriptor.SortedColumns.Clear();
			theTable.TableDescriptor.SortedColumns.Add("B", dir);

			SetTitleLine("Sorted On B using default " + dir.ToString());
		}

		
		
		private void listSortedOnBcomparer_Click(object sender, System.EventArgs e)
		{
			//listSortedOnBcomparer

			SetTitleLine("Sorted On B using custom Comparer");
			
			theTable.TableDescriptor.SortedColumns.Clear();
			theTable.TableDescriptor.SortedColumns.Add("B");
			theTable.TableDescriptor.SortedColumns["B"].Comparer = new BComparer();
						 

		
		}

		#endregion

		#region Grouping

		private void groupByC_Click(object sender, System.EventArgs e)
		{
			//groupByC
			SetTitleLine("GroupBy C");
			
			theTable.TableDescriptor.GroupedColumns.Clear();
			theTable.TableDescriptor.GroupedColumns.Add("C", GetSortDirection());
			
		//	ShowGrouping();
			
		}

		private void groupByCD_Click(object sender, System.EventArgs e)
		{
			//groupByC
			SetTitleLine("GroupBy CD");
			
			theTable.TableDescriptor.GroupedColumns.Clear();
			theTable.TableDescriptor.GroupedColumns.Add("C", GetSortDirection());
			theTable.TableDescriptor.GroupedColumns.Add("D", GetSortDirection());
			
			// ShowGrouping();
		}

		private void SetTitleLine(string title)
		{
			this.textBox1.Text += new string('-', 40) + title + Environment.NewLine;
			this.textBox1.SelectionStart = this.textBox1.Text.Length;
			this.textBox1.SelectionLength = 0;
			this.textBox1.ScrollToCaret();

		}

		

		#endregion

		#region Filtering
		private void filter_Click(object sender, System.EventArgs e)
		{
			//Filter
			string s = this.filterString.Text;
			FilterCompareOperator op;
			string name;
			string compareValue;
			if(ParseFilter(s, out name, out op, out compareValue))
			{
				theTable.TableDescriptor.RecordFilters.Clear();
				theTable.TableDescriptor.RecordFilters.Add(name, op, compareValue);
				SetTitleLine("Filter by: " + name + " " + op.ToString() + " " +compareValue.ToString());
			}
		}

		#region Code to parse filter string entry
		ArrayList ops = new ArrayList(new char[]{'=', '>', '^', '<', '%', '~', '!', '-'});
		string[] swapFrom = new string[]{">=", "<=", "like", "match", "<>"};
		string[] swapTo = new string[]{"^", "%", "~", "!", "-"};

		private bool ParseFilter(string inputString, out string name, out FilterCompareOperator op, out string compareValue)
		{
			name = "";
			op = FilterCompareOperator.Custom;
			compareValue  = "";
			string s = inputString.ToLower();

			bool b = true;
			try
			{
				for(int i = 0; i < swapFrom.GetLength(0); ++i)
					s = s.Replace(swapFrom[i], swapTo[i]);

				int locOp = s.IndexOfAny((char[])ops.ToArray(typeof(char)));
				name = inputString.Substring(0,locOp).Trim();
				op = (FilterCompareOperator) (ops.IndexOf(s[locOp]) + 1);
				int len = s.Length - locOp - 1;
				int start = inputString.Length - len;
				compareValue = inputString.Substring(start).Trim();
			}
			catch
			{
				b = false;
			}
			return b;
			 
		}
		#endregion

		#endregion

		#region Summaries
		
		private void summaries_Click(object sender, System.EventArgs e)
		{
			string mappingName = this.summaryMappingName.SelectedItem.ToString();
			string name = mappingName;
			this.theTable.TableDescriptor.Summaries.Add(name, mappingName, (SummaryType) this.summaryType.SelectedIndex);
		}

		#endregion

		#region Miscellaneous ButtonHandlers 

		private void ClearSortsFiltersEtc_Click(object sender, System.EventArgs e)
		{
			this.theTable.TableDescriptor.Summaries.Clear();
			this.theTable.TableDescriptor.GroupedColumns.Clear();
			this.theTable.TableDescriptor.SortedColumns.Clear();
			this.theTable.TableDescriptor.RecordFilters.Clear();
		}

		private void rawList_Click(object sender, System.EventArgs e)
		{ //rawList

			SetTitleLine("Raw List");

			//A.commented code shows particular property
			//PropertyDescriptorCollection pdc = theTable.GetItemProperties();
			//PropertyDescriptor pd = pdc["B"];

			int i = 0;
			foreach (Record r in theTable.UnsortedRecords)
			{
				//this.textBox1.Text += string.Format("[{0}]  \t {1}", i, r.GetData()) + Environment.NewLine;
				  this.textBox1.Text += string.Format("       \t {1}", i, r.GetData()) + Environment.NewLine;
				
				//B.commented code shows particular property
				//this.textBox1.Text += pd.GetValue(r.Data).ToString() + Environment.NewLine;
				++i;
			}
		
		}

		private void clear_Click(object sender, System.EventArgs e)
		{
			this.textBox1.Text = "";
		}

		private void reset_Click(object sender, System.EventArgs e)
		{
			nItems = (int) this.itemCount.Value;
			engine.SetSourceList(CreateADataSource());
			theTable = engine.Table;
		}

		#endregion

	}

	#region custom Comparer class
	public class BComparer : IComparer
	{
		#region Implementation of IComparer
		public int Compare(object x, object y)
		{
			if(x == null && y == null)
				return 0;
			else if(x == null)
				return -1;
			else if(y == null)
				return 1;
			else
			{
				int sx = 0;
				int sy = 0;
				try
				{
					sx = int.Parse(x.ToString().Substring(1));
					sy = int.Parse(y.ToString().Substring(1));
					return sy - sx;
				}
				catch 
				{
					throw new ArgumentException("B must be in the form 'bnnnn'");
				}
				
			
			}
		}
	
		#endregion
	}
	#endregion

	#region the object class
	public class MyObject
	{
		private string aValue;
		private string bValue;
		private string cValue;
		private string dValue;
		
		public MyObject(int i)
		{
			aValue = string.Format("a{0}", i);
			bValue = string.Format("b{0}", i);
			cValue = string.Format("c{0}", i%3);
			dValue = string.Format("d{0}", i%2);
		}

		public string A
		{
			get{return aValue;}
			set{aValue = value;}
		}
		public string B
		{
			get{return bValue;}
			set{bValue = value;}
		}
		public string C
		{
			get{return cValue;}
			set{cValue = value;}
		}
		public string D
		{
			get{return dValue;}
			set{dValue = value;}
		}

		public override string ToString()
		{
			return A + "\t" + B + "\t" + C + "\t" + D;
		}
	}
	#endregion
}
