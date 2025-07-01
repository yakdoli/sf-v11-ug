using System;
using System.Globalization;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Syncfusion.Windows.Forms.Grid;

namespace CrossSheetReference
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.TabBarSplitterControl tabBarSplitterControl1;
		private Syncfusion.Windows.Forms.TabBarPage tabBarPage1;
		private Syncfusion.Windows.Forms.TabBarPage tabBarPage2;
		private Syncfusion.Windows.Forms.Grid.GridControl gridDisplay;
		private Syncfusion.Windows.Forms.Grid.GridControl gridCalculations;
		private GridAwareTextBox gridAwareTextBox1;
		private Syncfusion.Windows.Forms.Tools.CheckBoxAdv showFormula;
		private System.Windows.Forms.Label label1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
        #endregion

        public Form1()
		{ 
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

            #region Grid Style Settings
            gridDisplay.ThemesEnabled = true;
			gridCalculations.ThemesEnabled=true;   
            gridCalculations.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            gridDisplay.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
			this.gridDisplay.BorderStyle=BorderStyle.FixedSingle;
			this.gridCalculations.BorderStyle=BorderStyle.FixedSingle;

			//Settings to give Excel like Flat Look to the grid
			this.gridDisplay.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
			this.gridCalculations.Model.Options.DefaultGridBorderStyle = GridBorderStyle.Solid;
            #endregion

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }
        }

        #region Form handlers
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
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle1 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle2 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle3 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle4 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle5 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle6 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle7 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle8 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle9 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle10 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle11 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle12 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle13 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle14 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle15 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle16 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle17 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle18 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle19 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle20 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle21 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle22 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle23 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle24 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle25 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle26 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle27 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle28 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle29 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle30 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle31 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle32 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle33 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle34 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle35 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle36 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle37 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle38 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle39 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle40 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle41 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle42 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle43 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle44 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle45 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle46 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle47 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle48 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle49 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle50 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle51 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle52 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle53 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle54 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle55 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle56 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle57 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle58 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle59 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle60 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle61 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle62 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle63 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridRangeStyle gridRangeStyle64 = new Syncfusion.Windows.Forms.Grid.GridRangeStyle();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo1 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo2 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo3 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo4 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo5 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo6 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo7 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo8 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo9 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo10 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo11 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo12 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo13 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo14 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo15 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo16 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo17 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo18 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo19 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo20 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo21 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo22 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo23 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo24 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo25 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo26 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo27 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo28 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo29 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo30 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo31 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo32 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo33 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo34 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo35 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo36 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo37 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo38 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo39 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo40 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo41 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo42 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            Syncfusion.Windows.Forms.Grid.GridCellInfo gridCellInfo43 = new Syncfusion.Windows.Forms.Grid.GridCellInfo();
            this.tabBarSplitterControl1 = new Syncfusion.Windows.Forms.TabBarSplitterControl();
            this.tabBarPage1 = new Syncfusion.Windows.Forms.TabBarPage();
            this.gridDisplay = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.tabBarPage2 = new Syncfusion.Windows.Forms.TabBarPage();
            this.gridCalculations = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.gridAwareTextBox1 = new Syncfusion.Windows.Forms.Grid.GridAwareTextBox();
            this.showFormula = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBarSplitterControl1.SuspendLayout();
            this.tabBarPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDisplay)).BeginInit();
            this.tabBarPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCalculations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBarSplitterControl1
            // 
            this.tabBarSplitterControl1.BackColor = System.Drawing.Color.White;
            this.tabBarSplitterControl1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage1);
            this.tabBarSplitterControl1.Controls.Add(this.tabBarPage2);
            this.tabBarSplitterControl1.EnabledColor = System.Drawing.SystemColors.WindowText;
            this.tabBarSplitterControl1.Location = new System.Drawing.Point(12, 48);
            this.tabBarSplitterControl1.Name = "tabBarSplitterControl1";
            this.tabBarSplitterControl1.Size = new System.Drawing.Size(728, 384);
            this.tabBarSplitterControl1.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarSplitterControl1.Style = Syncfusion.Windows.Forms.TabBarSplitterStyle.Metro;
            this.tabBarSplitterControl1.TabFolderDelta = 11;
            this.tabBarSplitterControl1.TabIndex = 0;
            this.tabBarSplitterControl1.Text = "tabBarSplitterControl1";
            this.tabBarSplitterControl1.ThemesEnabled = true;
            // 
            // tabBarPage1
            // 
            this.tabBarPage1.Controls.Add(this.gridDisplay);
            this.tabBarPage1.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage1.Name = "tabBarPage1";
            this.tabBarPage1.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPage1.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage1.Text = "Display";
            this.tabBarPage1.ThemesEnabled = true;
            // 
            // gridDisplay
            // 
            this.gridDisplay.AllowSelection = ((Syncfusion.Windows.Forms.Grid.GridSelectionFlags)(((((Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Table | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Cell)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Shift)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Keyboard)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.AlphaBlend)));
            this.gridDisplay.BackColor = System.Drawing.Color.White;
            this.gridDisplay.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(1, 199),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(2, 82),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(3, 135)});
            this.gridDisplay.CoveredRanges.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeInfo[] {
            Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(3, 1, 3, 4)});
            this.gridDisplay.DefaultColWidth = 70;
            this.gridDisplay.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridDisplay.DefaultRowHeight = 18;
            this.gridDisplay.FillSplitterPane = true;
            this.gridDisplay.FloatCellsMode = Syncfusion.Windows.Forms.Grid.GridFloatCellsMode.OnDemandCalculation;
            this.gridDisplay.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gridDisplay.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gridDisplay.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridDisplay.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridDisplay.Location = new System.Drawing.Point(0, 0);
            this.gridDisplay.Name = "gridDisplay";
            this.gridDisplay.Properties.GridLineColor = System.Drawing.Color.LightGray;
            this.gridDisplay.Properties.MarkColHeader = false;
            this.gridDisplay.Properties.MarkRowHeader = false;
            gridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle1.StyleInfo.Font.Bold = false;
            gridRangeStyle1.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle1.StyleInfo.Font.Italic = false;
            gridRangeStyle1.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle1.StyleInfo.Font.Strikeout = false;
            gridRangeStyle1.StyleInfo.Font.Underline = false;
            gridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle2.StyleInfo.Font.Bold = false;
            gridRangeStyle2.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle2.StyleInfo.Font.Italic = false;
            gridRangeStyle2.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle2.StyleInfo.Font.Strikeout = false;
            gridRangeStyle2.StyleInfo.Font.Underline = false;
            gridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle3.StyleInfo.Font.Bold = false;
            gridRangeStyle3.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle3.StyleInfo.Font.Italic = false;
            gridRangeStyle3.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle3.StyleInfo.Font.Strikeout = false;
            gridRangeStyle3.StyleInfo.Font.Underline = false;
            gridRangeStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle4.StyleInfo.Font.Bold = false;
            gridRangeStyle4.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle4.StyleInfo.Font.Italic = false;
            gridRangeStyle4.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle4.StyleInfo.Font.Strikeout = false;
            gridRangeStyle4.StyleInfo.Font.Underline = false;
            gridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle5.StyleInfo.Font.Bold = false;
            gridRangeStyle5.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle5.StyleInfo.Font.Italic = false;
            gridRangeStyle5.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle5.StyleInfo.Font.Strikeout = false;
            gridRangeStyle5.StyleInfo.Font.Underline = false;
            gridRangeStyle5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle6.StyleInfo.Font.Bold = false;
            gridRangeStyle6.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle6.StyleInfo.Font.Italic = false;
            gridRangeStyle6.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle6.StyleInfo.Font.Strikeout = false;
            gridRangeStyle6.StyleInfo.Font.Underline = false;
            gridRangeStyle6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle7.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle7.StyleInfo.Font.Bold = false;
            gridRangeStyle7.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle7.StyleInfo.Font.Italic = false;
            gridRangeStyle7.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle7.StyleInfo.Font.Strikeout = false;
            gridRangeStyle7.StyleInfo.Font.Underline = false;
            gridRangeStyle7.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle8.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle8.StyleInfo.Font.Bold = false;
            gridRangeStyle8.StyleInfo.Font.Facename = "Verdana";
            gridRangeStyle8.StyleInfo.Font.Italic = false;
            gridRangeStyle8.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle8.StyleInfo.Font.Strikeout = false;
            gridRangeStyle8.StyleInfo.Font.Underline = false;
            gridRangeStyle8.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle9.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle9.StyleInfo.Font.Bold = false;
            gridRangeStyle9.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle9.StyleInfo.Font.Italic = false;
            gridRangeStyle9.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle9.StyleInfo.Font.Strikeout = false;
            gridRangeStyle9.StyleInfo.Font.Underline = false;
            gridRangeStyle9.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle10.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle10.StyleInfo.Font.Bold = false;
            gridRangeStyle10.StyleInfo.Font.Facename = "Arial";
            gridRangeStyle10.StyleInfo.Font.Italic = false;
            gridRangeStyle10.StyleInfo.Font.Size = 9.75F;
            gridRangeStyle10.StyleInfo.Font.Strikeout = false;
            gridRangeStyle10.StyleInfo.Font.Underline = false;
            gridRangeStyle10.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle11.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Col(1);
            gridRangeStyle11.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Right;
            gridRangeStyle11.StyleInfo.Text = "";
            gridRangeStyle12.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Col(2);
            gridRangeStyle12.StyleInfo.Font.Bold = true;
            gridRangeStyle13.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Col(3);
            gridRangeStyle13.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Right;
            gridRangeStyle14.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Col(4);
            gridRangeStyle14.StyleInfo.Font.Bold = true;
            gridRangeStyle15.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(3, 1);
            gridRangeStyle15.StyleInfo.Font.Bold = true;
            gridRangeStyle15.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridRangeStyle15.StyleInfo.Text = "Payroll";
            gridRangeStyle15.StyleInfo.TextColor = System.Drawing.Color.DodgerBlue;
            gridRangeStyle16.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(3, 2);
            gridRangeStyle16.StyleInfo.Font.Bold = true;
            gridRangeStyle16.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridRangeStyle16.StyleInfo.Text = "";
            gridRangeStyle16.StyleInfo.TextColor = System.Drawing.Color.DodgerBlue;
            gridRangeStyle17.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(3, 3, 3, 4);
            gridRangeStyle17.StyleInfo.TextColor = System.Drawing.Color.DodgerBlue;
            gridRangeStyle18.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(4, 0);
            gridRangeStyle18.StyleInfo.Text = "4";
            gridRangeStyle19.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(4, 1, 4, 4);
            gridRangeStyle19.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle20.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(5, 0);
            gridRangeStyle20.StyleInfo.Text = "5";
            gridRangeStyle21.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(5, 1, 5, 2);
            gridRangeStyle21.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle21.StyleInfo.Text = "";
            gridRangeStyle22.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(5, 3, 5, 4);
            gridRangeStyle22.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle23.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(6, 0);
            gridRangeStyle23.StyleInfo.Text = "6";
            gridRangeStyle24.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(6, 1);
            gridRangeStyle24.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle24.StyleInfo.Text = "Name:";
            gridRangeStyle25.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(6, 2, 9, 2);
            gridRangeStyle25.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle25.StyleInfo.Text = "";
            gridRangeStyle26.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(6, 3);
            gridRangeStyle26.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle26.StyleInfo.Text = "DA:";
            gridRangeStyle27.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(6, 4, 20, 4);
            gridRangeStyle27.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle28.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(7, 0);
            gridRangeStyle28.StyleInfo.Text = "7";
            gridRangeStyle29.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(7, 1);
            gridRangeStyle29.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle29.StyleInfo.Text = "Qualification:";
            gridRangeStyle30.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(7, 3);
            gridRangeStyle30.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle30.StyleInfo.Text = "Gross Pay:";
            gridRangeStyle31.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(8, 0);
            gridRangeStyle31.StyleInfo.Text = "8";
            gridRangeStyle32.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(8, 1);
            gridRangeStyle32.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle32.StyleInfo.Text = "Experience:";
            gridRangeStyle33.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(8, 3);
            gridRangeStyle33.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle33.StyleInfo.Text = "PF:";
            gridRangeStyle34.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(9, 0);
            gridRangeStyle34.StyleInfo.Text = "9";
            gridRangeStyle35.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(9, 1);
            gridRangeStyle35.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle35.StyleInfo.Text = "Basic Pay:";
            gridRangeStyle36.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(9, 3);
            gridRangeStyle36.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle36.StyleInfo.Text = "Net Pay:";
            gridRangeStyle37.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(10, 0);
            gridRangeStyle37.StyleInfo.Text = "10";
            gridRangeStyle38.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(10, 1, 10, 2);
            gridRangeStyle38.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle39.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(10, 3);
            gridRangeStyle39.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle39.StyleInfo.Text = "Annual Income:";
            gridRangeStyle40.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(11, 0);
            gridRangeStyle40.StyleInfo.Text = "11";
            gridRangeStyle41.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(11, 1);
            gridRangeStyle41.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle41.StyleInfo.Font.Underline = true;
            gridRangeStyle41.StyleInfo.Text = "LIC Policy Details";
            gridRangeStyle42.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(11, 2, 11, 4);
            gridRangeStyle42.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle43.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(12, 0);
            gridRangeStyle43.StyleInfo.Text = "12";
            gridRangeStyle44.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(12, 1);
            gridRangeStyle44.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle44.StyleInfo.Text = "Policy No:";
            gridRangeStyle45.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(12, 2, 14, 2);
            gridRangeStyle45.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle45.StyleInfo.Text = "";
            gridRangeStyle46.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(12, 3, 20, 4);
            gridRangeStyle46.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle47.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(13, 0);
            gridRangeStyle47.StyleInfo.Text = "13";
            gridRangeStyle48.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(13, 1);
            gridRangeStyle48.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle48.StyleInfo.Text = "Policy Type:";
            gridRangeStyle49.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(14, 0);
            gridRangeStyle49.StyleInfo.Text = "14";
            gridRangeStyle50.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(14, 1);
            gridRangeStyle50.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle50.StyleInfo.Text = "Premium:";
            gridRangeStyle51.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(15, 0);
            gridRangeStyle51.StyleInfo.Text = "15";
            gridRangeStyle52.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(15, 1, 15, 4);
            gridRangeStyle52.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle53.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(16, 0);
            gridRangeStyle53.StyleInfo.Text = "16";
            gridRangeStyle54.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(16, 1);
            gridRangeStyle54.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle54.StyleInfo.Font.Underline = true;
            gridRangeStyle54.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Right;
            gridRangeStyle54.StyleInfo.Text = "Personal Loan Details";
            gridRangeStyle55.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(16, 2, 16, 4);
            gridRangeStyle55.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle56.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(17, 0);
            gridRangeStyle56.StyleInfo.Text = "17";
            gridRangeStyle57.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(17, 1);
            gridRangeStyle57.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle57.StyleInfo.Text = "Loan No:";
            gridRangeStyle58.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(17, 2, 19, 2);
            gridRangeStyle58.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle58.StyleInfo.Text = "";
            gridRangeStyle59.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(18, 0);
            gridRangeStyle59.StyleInfo.Text = "18";
            gridRangeStyle60.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(18, 1);
            gridRangeStyle60.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle60.StyleInfo.Text = "Loan Amount:";
            gridRangeStyle61.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(19, 0);
            gridRangeStyle61.StyleInfo.Text = "19";
            gridRangeStyle62.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(19, 1);
            gridRangeStyle62.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            gridRangeStyle62.StyleInfo.Text = "Monthly Due:";
            gridRangeStyle63.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(20, 0);
            gridRangeStyle63.StyleInfo.Text = "20";
            gridRangeStyle64.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cells(20, 1, 20, 4);
            gridRangeStyle64.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Standard, System.Drawing.SystemColors.WindowFrame);
            this.gridDisplay.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
            gridRangeStyle1,
            gridRangeStyle2,
            gridRangeStyle3,
            gridRangeStyle4,
            gridRangeStyle5,
            gridRangeStyle6,
            gridRangeStyle7,
            gridRangeStyle8,
            gridRangeStyle9,
            gridRangeStyle10,
            gridRangeStyle11,
            gridRangeStyle12,
            gridRangeStyle13,
            gridRangeStyle14,
            gridRangeStyle15,
            gridRangeStyle16,
            gridRangeStyle17,
            gridRangeStyle18,
            gridRangeStyle19,
            gridRangeStyle20,
            gridRangeStyle21,
            gridRangeStyle22,
            gridRangeStyle23,
            gridRangeStyle24,
            gridRangeStyle25,
            gridRangeStyle26,
            gridRangeStyle27,
            gridRangeStyle28,
            gridRangeStyle29,
            gridRangeStyle30,
            gridRangeStyle31,
            gridRangeStyle32,
            gridRangeStyle33,
            gridRangeStyle34,
            gridRangeStyle35,
            gridRangeStyle36,
            gridRangeStyle37,
            gridRangeStyle38,
            gridRangeStyle39,
            gridRangeStyle40,
            gridRangeStyle41,
            gridRangeStyle42,
            gridRangeStyle43,
            gridRangeStyle44,
            gridRangeStyle45,
            gridRangeStyle46,
            gridRangeStyle47,
            gridRangeStyle48,
            gridRangeStyle49,
            gridRangeStyle50,
            gridRangeStyle51,
            gridRangeStyle52,
            gridRangeStyle53,
            gridRangeStyle54,
            gridRangeStyle55,
            gridRangeStyle56,
            gridRangeStyle57,
            gridRangeStyle58,
            gridRangeStyle59,
            gridRangeStyle60,
            gridRangeStyle61,
            gridRangeStyle62,
            gridRangeStyle63,
            gridRangeStyle64});
            this.gridDisplay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridDisplay.RowCount = 20;
            this.gridDisplay.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridDisplay.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridDisplay.Size = new System.Drawing.Size(711, 367);
            this.gridDisplay.SmartSizeBox = false;
            this.gridDisplay.ThemesEnabled = true;
            // 
            // tabBarPage2
            // 
            this.tabBarPage2.Controls.Add(this.gridCalculations);
            this.tabBarPage2.Location = new System.Drawing.Point(0, 0);
            this.tabBarPage2.Name = "tabBarPage2";
            this.tabBarPage2.SplitBars = ((Syncfusion.Windows.Forms.DynamicSplitBars)((Syncfusion.Windows.Forms.DynamicSplitBars.SplitRows | Syncfusion.Windows.Forms.DynamicSplitBars.SplitColumns)));
            this.tabBarPage2.TabBackColor = System.Drawing.SystemColors.Control;
            this.tabBarPage2.Text = "Calculations";
            this.tabBarPage2.ThemesEnabled = true;
            // 
            // gridCalculations
            // 
            this.gridCalculations.AllowSelection = ((Syncfusion.Windows.Forms.Grid.GridSelectionFlags)(((((Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Table | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Cell)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Shift)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Keyboard)
                        | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.AlphaBlend)));
            this.gridCalculations.BackColor = System.Drawing.Color.White;
            this.gridCalculations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridCalculations.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(2, 139),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(3, 79),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(4, 70)});
            this.gridCalculations.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridCalculations.FillSplitterPane = true;
            this.gridCalculations.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.gridCalculations.ForeColor = System.Drawing.Color.MidnightBlue;
            gridCellInfo1.Col = -1;
            gridCellInfo1.Row = -1;
            gridCellInfo1.StyleInfo.Font.Bold = false;
            gridCellInfo1.StyleInfo.Font.Facename = "Verdana";
            gridCellInfo1.StyleInfo.Font.Italic = false;
            gridCellInfo1.StyleInfo.Font.Size = 8.25F;
            gridCellInfo1.StyleInfo.Font.Strikeout = false;
            gridCellInfo1.StyleInfo.Font.Underline = false;
            gridCellInfo1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo2.Col = -1;
            gridCellInfo2.Row = -1;
            gridCellInfo2.StyleInfo.Font.Bold = false;
            gridCellInfo2.StyleInfo.Font.Facename = "Verdana";
            gridCellInfo2.StyleInfo.Font.Italic = false;
            gridCellInfo2.StyleInfo.Font.Size = 8.25F;
            gridCellInfo2.StyleInfo.Font.Strikeout = false;
            gridCellInfo2.StyleInfo.Font.Underline = false;
            gridCellInfo2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridCellInfo3.Col = 1;
            gridCellInfo3.Row = 3;
            gridCellInfo4.Col = 2;
            gridCellInfo4.Row = 3;
            gridCellInfo4.StyleInfo.Font.Bold = true;
            gridCellInfo4.StyleInfo.Text = "LIC Policy Details";
            gridCellInfo5.Col = 3;
            gridCellInfo5.Row = 3;
            gridCellInfo6.Col = 4;
            gridCellInfo6.Row = 3;
            gridCellInfo7.Col = 5;
            gridCellInfo7.Row = 3;
            gridCellInfo8.Col = 0;
            gridCellInfo8.Row = 4;
            gridCellInfo8.StyleInfo.Text = "4";
            gridCellInfo9.Col = 1;
            gridCellInfo9.Row = 4;
            gridCellInfo10.Col = 2;
            gridCellInfo10.Row = 4;
            gridCellInfo10.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo10.StyleInfo.Text = "Policy No";
            gridCellInfo11.Col = 3;
            gridCellInfo11.Row = 4;
            gridCellInfo11.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo11.StyleInfo.Text = "Policy Type";
            gridCellInfo12.Col = 4;
            gridCellInfo12.Row = 4;
            gridCellInfo12.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo12.StyleInfo.Text = "Premium";
            gridCellInfo13.Col = 5;
            gridCellInfo13.Row = 4;
            gridCellInfo13.StyleInfo.Text = "Deductions";
            gridCellInfo14.Col = 0;
            gridCellInfo14.Row = 5;
            gridCellInfo14.StyleInfo.Text = "5";
            gridCellInfo15.Col = 1;
            gridCellInfo15.Row = 5;
            gridCellInfo16.Col = 2;
            gridCellInfo16.Row = 5;
            gridCellInfo16.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo17.Col = 3;
            gridCellInfo17.Row = 5;
            gridCellInfo17.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo18.Col = 4;
            gridCellInfo18.Row = 5;
            gridCellInfo18.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo19.Col = 5;
            gridCellInfo19.Row = 5;
            gridCellInfo19.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo20.Col = 0;
            gridCellInfo20.Row = 6;
            gridCellInfo20.StyleInfo.Text = "6";
            gridCellInfo21.Col = 1;
            gridCellInfo21.Row = 6;
            gridCellInfo22.Col = 2;
            gridCellInfo22.Row = 6;
            gridCellInfo23.Col = 3;
            gridCellInfo23.Row = 6;
            gridCellInfo24.Col = 4;
            gridCellInfo24.Row = 6;
            gridCellInfo25.Col = 5;
            gridCellInfo25.Row = 6;
            gridCellInfo26.Col = 0;
            gridCellInfo26.Row = 7;
            gridCellInfo26.StyleInfo.Text = "7";
            gridCellInfo27.Col = 1;
            gridCellInfo27.Row = 7;
            gridCellInfo28.Col = 2;
            gridCellInfo28.Row = 7;
            gridCellInfo28.StyleInfo.Font.Bold = true;
            gridCellInfo28.StyleInfo.Text = "Personal Loan Details";
            gridCellInfo29.Col = 3;
            gridCellInfo29.Row = 7;
            gridCellInfo30.Col = 4;
            gridCellInfo30.Row = 7;
            gridCellInfo31.Col = 5;
            gridCellInfo31.Row = 7;
            gridCellInfo32.Col = 0;
            gridCellInfo32.Row = 8;
            gridCellInfo32.StyleInfo.Text = "8";
            gridCellInfo33.Col = 1;
            gridCellInfo33.Row = 8;
            gridCellInfo34.Col = 2;
            gridCellInfo34.Row = 8;
            gridCellInfo34.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo34.StyleInfo.Text = "Loan No";
            gridCellInfo35.Col = 3;
            gridCellInfo35.Row = 8;
            gridCellInfo35.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo35.StyleInfo.Text = "Loan Amount";
            gridCellInfo36.Col = 4;
            gridCellInfo36.Row = 8;
            gridCellInfo36.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo36.StyleInfo.Text = "Monthly Due";
            gridCellInfo37.Col = 5;
            gridCellInfo37.Row = 8;
            gridCellInfo37.StyleInfo.Text = "Deductions";
            gridCellInfo38.Col = 0;
            gridCellInfo38.Row = 9;
            gridCellInfo38.StyleInfo.Text = "9";
            gridCellInfo39.Col = 1;
            gridCellInfo39.Row = 9;
            gridCellInfo40.Col = 2;
            gridCellInfo40.Row = 9;
            gridCellInfo40.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo40.StyleInfo.Text = "";
            gridCellInfo41.Col = 3;
            gridCellInfo41.Row = 9;
            gridCellInfo41.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo42.Col = 4;
            gridCellInfo42.Row = 9;
            gridCellInfo42.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridCellInfo43.Col = 5;
            gridCellInfo43.Row = 9;
            gridCellInfo43.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            this.gridCalculations.GridCells.AddRange(new Syncfusion.Windows.Forms.Grid.GridCellInfo[] {
            gridCellInfo1,
            gridCellInfo2,
            gridCellInfo3,
            gridCellInfo4,
            gridCellInfo5,
            gridCellInfo6,
            gridCellInfo7,
            gridCellInfo8,
            gridCellInfo9,
            gridCellInfo10,
            gridCellInfo11,
            gridCellInfo12,
            gridCellInfo13,
            gridCellInfo14,
            gridCellInfo15,
            gridCellInfo16,
            gridCellInfo17,
            gridCellInfo18,
            gridCellInfo19,
            gridCellInfo20,
            gridCellInfo21,
            gridCellInfo22,
            gridCellInfo23,
            gridCellInfo24,
            gridCellInfo25,
            gridCellInfo26,
            gridCellInfo27,
            gridCellInfo28,
            gridCellInfo29,
            gridCellInfo30,
            gridCellInfo31,
            gridCellInfo32,
            gridCellInfo33,
            gridCellInfo34,
            gridCellInfo35,
            gridCellInfo36,
            gridCellInfo37,
            gridCellInfo38,
            gridCellInfo39,
            gridCellInfo40,
            gridCellInfo41,
            gridCellInfo42,
            gridCellInfo43});
            this.gridCalculations.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridCalculations.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridCalculations.Location = new System.Drawing.Point(0, 0);
            this.gridCalculations.MetroScrollBars = true;
            this.gridCalculations.Name = "gridCalculations";
            this.gridCalculations.Properties.GridLineColor = System.Drawing.Color.LightGray;
            this.gridCalculations.Properties.MarkColHeader = false;
            this.gridCalculations.Properties.MarkRowHeader = false;
            this.gridCalculations.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridCalculations.RowCount = 20;
            this.gridCalculations.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21),
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(1, 18)});
            this.gridCalculations.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeIntoCode;
            this.gridCalculations.Size = new System.Drawing.Size(711, 367);
            this.gridCalculations.SmartSizeBox = false;
            this.gridCalculations.ThemesEnabled = true;
            // 
            // gridAwareTextBox1
            // 
            this.gridAwareTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridAwareTextBox1.DisabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox1.EnabledBackColor = System.Drawing.SystemColors.Window;
            this.gridAwareTextBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridAwareTextBox1.Location = new System.Drawing.Point(88, 15);
            this.gridAwareTextBox1.Name = "gridAwareTextBox1";
            this.gridAwareTextBox1.Size = new System.Drawing.Size(536, 22);
            this.gridAwareTextBox1.TabIndex = 1;
            // 
            // showFormula
            // 
            this.showFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showFormula.DrawFocusRectangle = false;
            this.showFormula.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFormula.Location = new System.Drawing.Point(632, 15);
            this.showFormula.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.showFormula.Name = "showFormula";
            this.showFormula.Size = new System.Drawing.Size(108, 18);
            this.showFormula.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.showFormula.TabIndex = 2;
            this.showFormula.Text = "Show Formula";
            this.showFormula.ThemesEnabled = false;
            this.showFormula.CheckStateChanged += new EventHandler(showFormula_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Formula Bar";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(752, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showFormula);
            this.Controls.Add(this.gridAwareTextBox1);
            this.Controls.Add(this.tabBarSplitterControl1);
            this.DropShadow = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cross-Reference Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabBarSplitterControl1.ResumeLayout(false);
            this.tabBarPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDisplay)).EndInit();
            this.tabBarPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCalculations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showFormula)).EndInit();
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
			Application.Run(new Form1());
        }
#endregion

        #region Event Handlers
        GridFormulaEngine engine;
		private void Form1_Load(object sender, System.EventArgs e)
		{
			//Registering grid as sheet for cross-reference
			int sheetFamilyID = GridFormulaEngine.CreateSheetFamilyID();
			GridFormulaEngine.RegisterGridAsSheet("Display", this.gridDisplay.Model, sheetFamilyID);
			GridFormulaEngine.RegisterGridAsSheet("Calculate", this.gridCalculations.Model, sheetFamilyID);
			SetUpDisplaySheet();
			SetUpCalcSheet();

			//setup copying formulas
			engine = ((GridFormulaCellModel)this.gridCalculations.CellModels["FormulaCell"]).Engine;
			engine.FormulaCopyFlags |= GridFormulaCopyFlags.ClipBoardFormula;

			//Subscribe to the necessary events
			this.gridDisplay.CurrentCellStartEditing += new CancelEventHandler(gridDisplay_CurrentCellStartEditing);
			this.gridDisplay.CellDoubleClick += new GridCellClickEventHandler(gridDisplay_CellDoubleClick);
			this.gridCalculations.CurrentCellStartEditing += new CancelEventHandler(gridCalculations_CurrentCellStartEditing);
			this.gridCalculations.CellDoubleClick += new GridCellClickEventHandler(gridCalculations_CellDoubleClick);
			this.gridDisplay.DrawCellDisplayText+=new GridDrawCellDisplayTextEventHandler(gridDisplay_DrawCellDisplayText);
			this.gridCalculations.DrawCellDisplayText+=new GridDrawCellDisplayTextEventHandler(gridCalculations_DrawCellDisplayText);
		}

		void gridCalculations_CellDoubleClick(object sender, GridCellClickEventArgs e)
		{
			editingLocked = false;
			this.gridCalculations.CurrentCell.BeginEdit(true);
			editingLocked = true;
		}

		void gridDisplay_CellDoubleClick(object sender, GridCellClickEventArgs e)
		{
			editingLocked = false;
			this.gridDisplay.CurrentCell.BeginEdit(true);
			editingLocked = true;
		}

		void gridCalculations_CurrentCellStartEditing(object sender, CancelEventArgs e)
		{
			e.Cancel = editingLocked;
		}

		void gridDisplay_CurrentCellStartEditing(object sender, CancelEventArgs e)
		{
			e.Cancel = editingLocked;
		}
		
		#region DisplaySheet

		private void SetUpDisplaySheet()
		{

			//General Settings
			int row = 6;
			int col = 4;

			this.gridDisplay[row, col].CellType = GridCellTypeName.FormulaCell;
			this.gridDisplay[row, col].Text = "=B9*0.81";

			this.gridDisplay[++row, col].CellType = GridCellTypeName.FormulaCell;
			this.gridDisplay[row, col].Text="=B9+D6";
            
			this.gridDisplay[++row, col].CellType = GridCellTypeName.FormulaCell;
			this.gridDisplay[row, col].Text="=D7*0.10";
            
			this.gridDisplay[++row, col].CellType = GridCellTypeName.FormulaCell;
			this.gridDisplay[row, col].Text = "=D7-D8";
            
			this.gridDisplay[++row, col].CellType = GridCellTypeName.FormulaCell;
			this.gridDisplay[row, col].Text = "=D9*12";
            
			row = 6;
			col = 2;
			//General Details
			this.gridDisplay[row, col].Text = "Vedha";
			this.gridDisplay[++row, col].Text = "B.E.";
			this.gridDisplay[++row, col].Text = "4 years";
			this.gridDisplay[++row, col].Text = "8,000.00";

			//Policy Details
			row += 3;
			this.gridDisplay[row, col].Text = "1234";
			this.gridDisplay[++row, col].Text = "Quarterly";
			this.gridDisplay[++row, col].Text = "2,000.00";

			//Loan Details
			row += 3;
			this.gridDisplay[row, col].Text = "5678";
			this.gridDisplay[++row, col].Text = "1,00,000.00";
			this.gridDisplay[++row, col].Text = "1,500.00";


			this.gridAwareTextBox1.WireGrid(this.gridDisplay);


		}


        #endregion

        #region CalculationSheet

		private void SetUpCalcSheet()
		{
			int row = 5;
			int col = 2;

			this.gridCalculations[row, col].CellType = GridCellTypeName.FormulaCell;
			this.gridCalculations[row, col].Text = "=Display!B12";

			this.gridCalculations[row, col + 1].CellType = GridCellTypeName.FormulaCell;
			this.gridCalculations[row, col + 1].Text = "=Display!B13";

			this.gridCalculations[row, col + 2].CellType = GridCellTypeName.FormulaCell;
			this.gridCalculations[row, col + 2].Text = "=Display!B14";

			this.gridCalculations[row, col + 3].CellType = GridCellTypeName.FormulaCell;
			this.gridCalculations[row, col + 3].Text = "=D5*4";

			row+=4;
			this.gridCalculations[row, col].CellType = GridCellTypeName.FormulaCell;
			this.gridCalculations[row, col].Text = "=Display!B17";

			this.gridCalculations[row, col + 1].CellType = GridCellTypeName.FormulaCell;
			this.gridCalculations[row, col + 1].Text = "=Display!B18";
            
			this.gridCalculations[row, col + 2].CellType = GridCellTypeName.FormulaCell;
			this.gridCalculations[row, col + 2].Text = "=Display!B19";

			this.gridCalculations[row, col + 3].CellType = GridCellTypeName.FormulaCell;
			this.gridCalculations[row, col + 3].Text = "=D9*12";

			this.gridCalculations.TableStyle.Format = "#,##0";

			this.gridAwareTextBox1.WireGrid(this.gridCalculations);
		}


        #endregion
		
		private void tabBarSplitterControl1_PaneCreated(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
		{
			GridControl grid = e.Control as GridControl;
			this.gridAwareTextBox1.WireGrid(grid);
		}

		private void tabBarSplitterControl1_PaneClosing(object sender, Syncfusion.Windows.Forms.SplitterPaneEventArgs e)
		{
			GridControl grid = e.Control as GridControl;
			this.gridAwareTextBox1.UnwireGrid(grid);
		}

		private bool editingLocked = true;
		bool flag=false;

		private void showFormula_CheckedChanged(object sender, EventArgs e)
		{
			if (showFormula.Checked)
			{
				//Display the formulas in Formula Cells
				flag=true;
				this.gridDisplay.RefreshRange(GridRangeInfo.Cells(6,4,10,4));
				this.gridCalculations.RefreshRange(GridRangeInfo.Row(5));
				this.gridCalculations.RefreshRange(GridRangeInfo.Row(9));
			}
			else
			{
				//Show the computed results in Formula Cells
				flag=false;
				this.gridDisplay.RefreshRange(GridRangeInfo.Cells(6,4,10,4));
				this.gridCalculations.RefreshRange(GridRangeInfo.Row(5));
				this.gridCalculations.RefreshRange(GridRangeInfo.Row(9));
			}
		}
	
		private void gridDisplay_DrawCellDisplayText(object sender, GridDrawCellDisplayTextEventArgs e)
		{
			if(e.Style.CellType=="FormulaCell" && flag)
			{
				e.DisplayText=e.Style.Text;
			}
		}
		private void gridCalculations_DrawCellDisplayText(object sender, GridDrawCellDisplayTextEventArgs e)
		{
			if(e.Style.CellType=="FormulaCell" && flag)
			{
				e.DisplayText=e.Style.Text;
			}
		}
#endregion
	}
}
