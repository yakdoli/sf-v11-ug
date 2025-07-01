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
using System.Globalization;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Calculate;
using Syncfusion.XlsIO;

namespace XlsFileUsingExcelRW
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support.
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			try
			{
				System.Drawing.Icon ico = new System.Drawing.Icon(FindFile("Icon", "sfgrid.ico"));
				this.Icon = ico ;
			}
			catch{}
		}

		#region FindFile Utility
		/// <summary>
		/// Finds a file of the given name in the current directory or sibling "Data" directory.
		/// If file is not found, the parent folder is checked until the file is found. This method
		/// is used by our samples when they load data from a separate "Data" folder.
		/// </summary>
		/// <param name="dataDirName">The name of the "Data" folder.</param>
		/// <param name="fileName">The filename to be searched.</param>
		/// <returns>The full path of the file that was found; an empty string is returned if file is not found.</returns>

		public static string FindFile(string dataDirName, string fileName)
		{
			dataDirName = dataDirName.TrimEnd('\\', '/');
			// Check both in parent folder and Parent\Data folders.
			string dataFileName = dataDirName + "\\" + fileName;
			for (int n = 0; n < 10; n++)
			{
				if (System.IO.File.Exists(fileName))
				{
					return fileName;
				}
				if (System.IO.File.Exists(dataFileName))
				{
					return dataFileName;
				}
				fileName = @"..\" + fileName;
				dataFileName = @"..\" + dataFileName;
			}

			return "";
		}
        #endregion

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
		/// Required method for Designer support; do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPoints = new System.Windows.Forms.NumericUpDown();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.numericUpDownModelYear = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMultipleCars = new System.Windows.Forms.CheckBox();
            this.textBoxBaseAmount = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModelYear)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(52, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Age";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(52, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sex";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(52, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "State";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(52, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Points";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(52, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Model";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(52, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Model Year";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Discount for multiple cars";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(52, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 7;
            this.label8.Text = "Base Amount";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(168, 16);
            this.numericUpDownAge.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDownAge.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownAge.TabIndex = 9;
            this.numericUpDownAge.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // numericUpDownPoints
            // 
            this.numericUpDownPoints.Location = new System.Drawing.Point(168, 112);
            this.numericUpDownPoints.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownPoints.Name = "numericUpDownPoints";
            this.numericUpDownPoints.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownPoints.TabIndex = 10;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxSex.Location = new System.Drawing.Point(168, 48);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(64, 21);
            this.comboBoxSex.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(296, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Compute Annual Premium";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxState
            // 
            this.comboBoxState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxState.Items.AddRange(new object[] {
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KA",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.comboBoxState.Location = new System.Drawing.Point(168, 80);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(64, 21);
            this.comboBoxState.TabIndex = 13;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModel.Items.AddRange(new object[] {
            "Ford",
            "Chevrolet",
            "Buick",
            "Toyota",
            "BMW",
            "Mercedes",
            "Honda",
            "Hundai",
            "Mitsubishu",
            "Cadilac",
            "Lexis"});
            this.comboBoxModel.Location = new System.Drawing.Point(168, 144);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(80, 21);
            this.comboBoxModel.TabIndex = 14;
            // 
            // numericUpDownModelYear
            // 
            this.numericUpDownModelYear.Location = new System.Drawing.Point(168, 176);
            this.numericUpDownModelYear.Maximum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            this.numericUpDownModelYear.Minimum = new decimal(new int[] {
            1972,
            0,
            0,
            0});
            this.numericUpDownModelYear.Name = "numericUpDownModelYear";
            this.numericUpDownModelYear.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownModelYear.TabIndex = 15;
            this.numericUpDownModelYear.Value = new decimal(new int[] {
            2004,
            0,
            0,
            0});
            // 
            // checkBoxMultipleCars
            // 
            this.checkBoxMultipleCars.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxMultipleCars.Location = new System.Drawing.Point(168, 208);
            this.checkBoxMultipleCars.Name = "checkBoxMultipleCars";
            this.checkBoxMultipleCars.Size = new System.Drawing.Size(16, 24);
            this.checkBoxMultipleCars.TabIndex = 16;
            // 
            // textBoxBaseAmount
            // 
            this.textBoxBaseAmount.Location = new System.Drawing.Point(168, 240);
            this.textBoxBaseAmount.Name = "textBoxBaseAmount";
            this.textBoxBaseAmount.Size = new System.Drawing.Size(48, 20);
            this.textBoxBaseAmount.TabIndex = 17;
            this.textBoxBaseAmount.Text = "600";
            // 
            // labelPrice
            // 
            this.labelPrice.Location = new System.Drawing.Point(320, 80);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(128, 64);
            this.labelPrice.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(296, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Auto Process with Random Inputs";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(512, 294);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxBaseAmount);
            this.Controls.Add(this.checkBoxMultipleCars);
            this.Controls.Add(this.numericUpDownModelYear);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.comboBoxState);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.numericUpDownPoints);
            this.Controls.Add(this.numericUpDownAge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xls File Using CalcEngine Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModelYear)).EndInit();
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

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.NumericUpDown numericUpDownAge;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBoxSex;
		private System.Windows.Forms.ComboBox comboBoxState;
		private System.Windows.Forms.ComboBox comboBoxModel;
		private System.Windows.Forms.NumericUpDown numericUpDownModelYear;
		private System.Windows.Forms.CheckBox checkBoxMultipleCars;
		private System.Windows.Forms.TextBox textBoxBaseAmount;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.NumericUpDown numericUpDownPoints;
		private System.Windows.Forms.Button button2;


		private XlsIOCalcWorkbook calcWB;

		private void Form1_Load(object sender, System.EventArgs e)
		{
			calcWB = XlsIOCalcWorkbook.CreateFromXLS(@"..\..\..\CarIns.xls");

////
////				//Debug output:
////				Console.WriteLine(calcWB.sheetNames.Count);
////				for(int i = 0; i < calcWB.sheetNames.Count; ++i)
////					Console.WriteLine(calcWB.sheetNames[i]);
////	
////				foreach(string key in calcWB.Engine.NamedRanges.Keys)
////					Console.WriteLine(key + "  " + calcWB.Engine.NamedRanges[key].ToString());

			
			this.calcWB.Engine.LockDependencies = false;
			this.calcWB.CalculateAll();
			this.calcWB.Engine.LockDependencies = true;
			

			//Set some initial values on the form:
			this.comboBoxSex.SelectedIndex = 0;
			this.comboBoxState.SelectedIndex = 0;
			this.comboBoxModel.SelectedIndex = 0;

			if(Environment.CommandLine.EndsWith("automatedtest"))
			{
				this.button1.PerformClick();
			}

		}

		 
		private void button1_Click(object sender, System.EventArgs e)
		{
			//Initialize calcsheet with input values from the form:
			SetSheetInputs();

			// Calculations not suspended so just getting the value triggers the computation,
			// so these two lines are not needed.....
			//this.calcWB.Engine.UpdateCalcID();
			//this.calcWB.Engine.PullUpdatedValue(this.calcWB.GetSheetID("Outputs"), 1, 1);

			//Get the value from cell 1,1 on the output sheet:
			double d;
			if(double.TryParse(calcWB["Outputs"][1,1].ToString(), NumberStyles.Any, null, out d))
			{
				//Cell 1,1 on the output sheet has the result:
				this.labelPrice.Text = string.Format("{0:C2}", d); 
			}
			else
				this.labelPrice.Text = "---";
			 
		}

		private int ageRow = 3;
		private int sexRow = 4;
		private int stateRow = 5;
		private int pointsRow = 6;
		private int modelRow = 7;
		private int modelYearRow = 8;
		private int multipleDiscountRow = 9;

		//Set the input values into the CalcSheets:
		private void SetSheetInputs()
		{
			CalcSheet inputSheet = this.calcWB["Inputs"];
			inputSheet[ageRow,2] = this.numericUpDownAge.Value.ToString();
			inputSheet[sexRow,2] = this.comboBoxSex.Text[0].ToString();
			inputSheet[stateRow,2] = this.comboBoxState.Text;
			inputSheet[pointsRow,2] = this.numericUpDownPoints.Value.ToString();
			inputSheet[modelRow,2] = this.comboBoxModel.Text;
			inputSheet[modelYearRow,2] = this.numericUpDownModelYear.Value.ToString();
			inputSheet[multipleDiscountRow,2] = this.checkBoxMultipleCars.Checked ? "Yes" : "No";
			inputSheet[3, 5] = this.textBoxBaseAmount.Text;
		}

		//Do the calculation multiple times:
		private void button2_Click(object sender, System.EventArgs e)
		{
			//Run 1000 interations:
			int num = 1000;
			
			this.Cursor = Cursors.WaitCursor;
			DateTime start = DateTime.Now;
			CalcSheet inputSheet = this.calcWB["Inputs"];
			Random r = new Random();

			this.calcWB.Engine.CalculatingSuspended = true;

			for(int i = 0; i < num; ++ i)
			{
				//1) Set random values into the Inputs sheet:
				inputSheet[ageRow,2] = (r.Next(74) + 15).ToString();
				inputSheet[sexRow,2] = r.Next(2) == 1 ? "M" : "F";
				inputSheet[stateRow,2] = this.comboBoxState.Items[r.Next(50)];
				inputSheet[pointsRow,2] = r.Next(15).ToString();
				inputSheet[modelRow,2] = r.Next(11).ToString();
				inputSheet[modelYearRow,2] = (33 + r.Next(1972)).ToString();
				inputSheet[multipleDiscountRow,2] = r.Next(2) == 1 ? "Yes" : "No";
				inputSheet[3, 5] = this.textBoxBaseAmount.Text;

				//2) Calculations are suspended so need to pull the computed value to
				//make sure it has been calculated with the latest changes:
				this.calcWB.Engine.UpdateCalcID();
				this.calcWB.Engine.PullUpdatedValue(this.calcWB.GetSheetID("Outputs"), 1, 1);

				//3) Get the value from cell 1,1 on the output sheet:
				double d;
				if(double.TryParse(calcWB["Outputs"][1,1].ToString(), NumberStyles.Any, null, out d))
				{
					this.labelPrice.Text = string.Format("{0:C2}", d); //cell 1,1 on the outputs sheet has the result
				}
				else
					this.labelPrice.Text = "---";

				//Allow the label to update:
				this.labelPrice.Refresh();
			}

			this.calcWB.Engine.CalculatingSuspended = false;
			this.Cursor = Cursors.Default;
			this.labelPrice.Text = string.Format("{0} updates in {1} seconds", num,  (TimeSpan)(DateTime.Now - start) );
		}
	}
}
