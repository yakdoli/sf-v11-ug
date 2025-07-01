using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using Syncfusion.Grouping;
using Syncfusion.Windows.Forms.Grid.Grouping;
using Syncfusion.Windows.Forms.Grid;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.IO;
using System.Collections.Generic;
using Syncfusion.GridHelperClasses;

namespace SelectionModes
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : Syncfusion.Windows.Forms.MetroForm
    {
        #region Private Members
        private Syncfusion.Windows.Forms.Tools.GradientPanel gradientPanel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private SelectionModes.DataSet1 dataSet11;
        private Syncfusion.Windows.Forms.Grid.GridControl gridControl1;
        #endregion
        private GridControl gridControl2;
        private GroupBox groupBox2;
        private Syncfusion.Windows.Forms.ButtonAdv button1;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv ShowHeaderFooter;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv RadCustomizePrintPage;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radMultiGridPrint;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv radScaleColumnToFit;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv RadPrintGridInNewPage;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv RadDefaultGridPrint;
        private Syncfusion.Windows.Forms.Tools.RadioButtonAdv RadMultgrdpnt;
        private Label label1;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt1;
        private GroupBox TypeOfPrintings;
        private IContainer components;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            #region Data Initialization
            String commandstring = "select * from Customers";
            String connection = @"Data Source=" + FindFile("NorthwindwithImage.sdf");
            SqlCeDataAdapter da = new SqlCeDataAdapter(commandstring, connection);
            try
            {
                da.Fill(dataSet11, "Customers");
            }
            catch (SqlException ex)
            {
                ShowErrorMessage(ex);
            }
            #endregion

            #region GridStyle settings
            this.gridControl1.RowCount = this.dataSet11.Customers.Rows.Count;
            this.gridControl1.ColCount = this.dataSet11.Customers.Columns.Count;

            this.gridControl1.PopulateValues(GridRangeInfo.Cells(1, 1, gridControl1.RowCount, gridControl1.ColCount), dataSet11.Customers);
            this.gridControl1.ColWidths.ResizeToFit(GridRangeInfo.Cols(1, gridControl1.ColCount));
            this.gridControl1.RowHeights.ResizeToFit(GridRangeInfo.Cols(1, gridControl1.RowCount));

            this.gridControl1.BackColor = Color.White;

            this.gridControl1.AlphaBlendSelectionColor = Color.CornflowerBlue;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            #endregion

            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(GetIconFile1(@"common\Images\Grid\Icon\sfgrid.ico"));
                this.Icon = ico;
            }
            catch { }

            InitializeGrid();
            this.radMultiGridPrint.Checked = true;
            this.RadMultgrdpnt.Checked = true;
            this.numericUpDownExt1.Hide();
            this.label1.Hide();
            this.RadCustomizePrintPage.Hide();
        }
        #region Form Handlers
        private string FindFile(string connstring)
        {
            connstring = @"Common\Data\" + connstring;//common\data
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(connstring))
                    return new FileInfo(connstring).FullName;
                connstring = @"..\" + connstring;
            }

            return connstring;
        }

        private string GetIconFile1(string bitmapName)
        {
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(bitmapName))
                    return bitmapName;

                bitmapName = @"..\" + bitmapName;
            }

            return bitmapName;
        }


        private static void ShowErrorMessage(SqlException ex)
        {
            if (ex.Number == 11001)
                MessageBox.Show("Host server is down or internet connection is lost.", "Error: Unable To Locate Host", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 208)
                MessageBox.Show("Queried table is invalid.", "Error: Unable To Locate Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (ex.Number == 156 || ex.Number == 102)
                MessageBox.Show("Check query syntax and try again.", "Error: Invalid Command", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void CheckAll(bool b)
        {
        }



        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
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
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
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
            this.gradientPanel2 = new Syncfusion.Windows.Forms.Tools.GradientPanel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gridControl2 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.gridControl1 = new Syncfusion.Windows.Forms.Grid.GridControl();
            this.dataSet11 = new SelectionModes.DataSet1();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TypeOfPrintings = new System.Windows.Forms.GroupBox();
            this.radMultiGridPrint = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.RadCustomizePrintPage = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownExt1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.radScaleColumnToFit = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.RadPrintGridInNewPage = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.RadDefaultGridPrint = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.RadMultgrdpnt = new Syncfusion.Windows.Forms.Tools.RadioButtonAdv();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.button1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.ShowHeaderFooter = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.TypeOfPrintings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radMultiGridPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadCustomizePrintPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScaleColumnToFit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadPrintGridInNewPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadDefaultGridPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadMultgrdpnt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowHeaderFooter)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.Maroon, System.Drawing.Color.IndianRed);
            this.gradientPanel2.Location = new System.Drawing.Point(2, 46);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.Size = new System.Drawing.Size(0, 0);
            this.gradientPanel2.TabIndex = 1;
            // 
            // radioButton3
            // 
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(8, 88);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(104, 24);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "MultiExtended";
            // 
            // radioButton2
            // 
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(8, 56);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(104, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "MultiSimple";
            // 
            // radioButton1
            // 
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(8, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(104, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "One";
            // 
            // gridControl2
            // 
            this.gridControl2.ApplyVisualStyles = false;
            this.gridControl2.BackColor = System.Drawing.Color.White;
            this.gridControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl2.DefaultRowHeight = 20;
            this.gridControl2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gridControl2.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl2.Location = new System.Drawing.Point(12, 12);
            this.gridControl2.MetroScrollBars = true;
            this.gridControl2.Name = "gridControl2";
            gridRangeStyle1.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle1.StyleInfo.Font.Bold = false;
            gridRangeStyle1.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle1.StyleInfo.Font.Italic = false;
            gridRangeStyle1.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle1.StyleInfo.Font.Strikeout = false;
            gridRangeStyle1.StyleInfo.Font.Underline = false;
            gridRangeStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle2.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle2.StyleInfo.Font.Bold = false;
            gridRangeStyle2.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle2.StyleInfo.Font.Italic = false;
            gridRangeStyle2.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle2.StyleInfo.Font.Strikeout = false;
            gridRangeStyle2.StyleInfo.Font.Underline = false;
            gridRangeStyle2.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle3.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle3.StyleInfo.Font.Bold = false;
            gridRangeStyle3.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle3.StyleInfo.Font.Italic = false;
            gridRangeStyle3.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle3.StyleInfo.Font.Strikeout = false;
            gridRangeStyle3.StyleInfo.Font.Underline = false;
            gridRangeStyle3.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle4.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle4.StyleInfo.Font.Bold = false;
            gridRangeStyle4.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle4.StyleInfo.Font.Italic = false;
            gridRangeStyle4.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle4.StyleInfo.Font.Strikeout = false;
            gridRangeStyle4.StyleInfo.Font.Underline = false;
            gridRangeStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle5.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle5.StyleInfo.Font.Bold = false;
            gridRangeStyle5.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle5.StyleInfo.Font.Italic = false;
            gridRangeStyle5.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle5.StyleInfo.Font.Strikeout = false;
            gridRangeStyle5.StyleInfo.Font.Underline = false;
            gridRangeStyle5.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle6.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle6.StyleInfo.Font.Bold = false;
            gridRangeStyle6.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle6.StyleInfo.Font.Italic = false;
            gridRangeStyle6.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle6.StyleInfo.Font.Strikeout = false;
            gridRangeStyle6.StyleInfo.Font.Underline = false;
            gridRangeStyle6.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle7.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle7.StyleInfo.Font.Bold = false;
            gridRangeStyle7.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle7.StyleInfo.Font.Italic = false;
            gridRangeStyle7.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle7.StyleInfo.Font.Strikeout = false;
            gridRangeStyle7.StyleInfo.Font.Underline = false;
            gridRangeStyle7.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle8.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle8.StyleInfo.Font.Bold = false;
            gridRangeStyle8.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle8.StyleInfo.Font.Italic = false;
            gridRangeStyle8.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle8.StyleInfo.Font.Strikeout = false;
            gridRangeStyle8.StyleInfo.Font.Underline = false;
            gridRangeStyle8.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle9.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle9.StyleInfo.Font.Bold = false;
            gridRangeStyle9.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle9.StyleInfo.Font.Italic = false;
            gridRangeStyle9.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle9.StyleInfo.Font.Strikeout = false;
            gridRangeStyle9.StyleInfo.Font.Underline = false;
            gridRangeStyle9.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle10.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle10.StyleInfo.Font.Bold = false;
            gridRangeStyle10.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle10.StyleInfo.Font.Italic = false;
            gridRangeStyle10.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle10.StyleInfo.Font.Strikeout = false;
            gridRangeStyle10.StyleInfo.Font.Underline = false;
            gridRangeStyle10.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle11.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle11.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle11.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle11.StyleInfo.Font.Bold = false;
            gridRangeStyle11.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle11.StyleInfo.Font.Italic = false;
            gridRangeStyle11.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle11.StyleInfo.Font.Strikeout = false;
            gridRangeStyle11.StyleInfo.Font.Underline = false;
            gridRangeStyle11.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle11.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle11.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle12.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle12.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle12.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle12.StyleInfo.Font.Bold = false;
            gridRangeStyle12.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle12.StyleInfo.Font.Italic = false;
            gridRangeStyle12.StyleInfo.Font.Size = 8.25F;
            gridRangeStyle12.StyleInfo.Font.Strikeout = false;
            gridRangeStyle12.StyleInfo.Font.Underline = false;
            gridRangeStyle12.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle12.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle12.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle13.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle13.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle13.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle13.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle13.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle13.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gridControl2.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
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
            gridRangeStyle13});
            this.gridControl2.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl2.Size = new System.Drawing.Size(493, 347);
            this.gridControl2.SmartSizeBox = false;
            this.gridControl2.TabIndex = 4;
            this.gridControl2.Text = "gridControl2";
            this.gridControl2.UseRightToLeftCompatibleTextBox = true;
            // 
            // gridControl1
            // 
            this.gridControl1.AllowSelection = ((Syncfusion.Windows.Forms.Grid.GridSelectionFlags)(((((((Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Row | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Table)
            | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Cell)
            | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Multiple)
            | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Shift)
            | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.Keyboard)
            | Syncfusion.Windows.Forms.Grid.GridSelectionFlags.AlphaBlend)));
            this.gridControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridControl1.ApplyVisualStyles = false;
            this.gridControl1.BackColor = System.Drawing.Color.White;
            gridBaseStyle1.Name = "Header";
            gridBaseStyle1.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle1.StyleInfo.CellType = "Header";
            gridBaseStyle1.StyleInfo.Font.Bold = true;
            gridBaseStyle1.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            gridBaseStyle1.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle2.Name = "Standard";
            gridBaseStyle2.StyleInfo.Font.Facename = "Tahoma";
            gridBaseStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle3.Name = "Column Header";
            gridBaseStyle3.StyleInfo.BaseStyle = "Header";
            gridBaseStyle3.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle4.Name = "Row Header";
            gridBaseStyle4.StyleInfo.BaseStyle = "Header";
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            gridBaseStyle4.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(199)))), ((int)(((byte)(184))))), System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(234)))), ((int)(((byte)(216))))));
            this.gridControl1.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.gridControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridControl1.ColCount = 5;
            this.gridControl1.ColWidthEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridColWidth[] {
            new Syncfusion.Windows.Forms.Grid.GridColWidth(0, 35),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(1, 126),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(2, 127),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(3, 113),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(4, 109),
            new Syncfusion.Windows.Forms.Grid.GridColWidth(5, 139)});
            this.gridControl1.DefaultGridBorderStyle = Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid;
            this.gridControl1.DefaultRowHeight = 20;
            this.gridControl1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.gridControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gridControl1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.gridControl1.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl1.Location = new System.Drawing.Point(511, 12);
            this.gridControl1.MetroScrollBars = true;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.NumberedColHeaders = false;
            this.gridControl1.NumberedRowHeaders = false;
            this.gridControl1.Properties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.gridControl1.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gridControl1.Properties.MarkColHeader = false;
            this.gridControl1.Properties.MarkRowHeader = false;
            gridRangeStyle14.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle14.StyleInfo.Font.Bold = false;
            gridRangeStyle14.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle14.StyleInfo.Font.Italic = false;
            gridRangeStyle14.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle14.StyleInfo.Font.Strikeout = false;
            gridRangeStyle14.StyleInfo.Font.Underline = false;
            gridRangeStyle14.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle15.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle15.StyleInfo.Font.Bold = false;
            gridRangeStyle15.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle15.StyleInfo.Font.Italic = false;
            gridRangeStyle15.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle15.StyleInfo.Font.Strikeout = false;
            gridRangeStyle15.StyleInfo.Font.Underline = false;
            gridRangeStyle15.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle16.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle16.StyleInfo.Font.Bold = false;
            gridRangeStyle16.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle16.StyleInfo.Font.Italic = false;
            gridRangeStyle16.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle16.StyleInfo.Font.Strikeout = false;
            gridRangeStyle16.StyleInfo.Font.Underline = false;
            gridRangeStyle16.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle17.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle17.StyleInfo.Font.Bold = false;
            gridRangeStyle17.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle17.StyleInfo.Font.Italic = false;
            gridRangeStyle17.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle17.StyleInfo.Font.Strikeout = false;
            gridRangeStyle17.StyleInfo.Font.Underline = false;
            gridRangeStyle17.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle18.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle18.StyleInfo.Font.Bold = false;
            gridRangeStyle18.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle18.StyleInfo.Font.Italic = false;
            gridRangeStyle18.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle18.StyleInfo.Font.Strikeout = false;
            gridRangeStyle18.StyleInfo.Font.Underline = false;
            gridRangeStyle18.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle19.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle19.StyleInfo.Font.Bold = false;
            gridRangeStyle19.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle19.StyleInfo.Font.Italic = false;
            gridRangeStyle19.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle19.StyleInfo.Font.Strikeout = false;
            gridRangeStyle19.StyleInfo.Font.Underline = false;
            gridRangeStyle19.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle20.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle20.StyleInfo.Font.Bold = false;
            gridRangeStyle20.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle20.StyleInfo.Font.Italic = false;
            gridRangeStyle20.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle20.StyleInfo.Font.Strikeout = false;
            gridRangeStyle20.StyleInfo.Font.Underline = false;
            gridRangeStyle20.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle21.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle21.StyleInfo.Font.Bold = false;
            gridRangeStyle21.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle21.StyleInfo.Font.Italic = false;
            gridRangeStyle21.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle21.StyleInfo.Font.Strikeout = false;
            gridRangeStyle21.StyleInfo.Font.Underline = false;
            gridRangeStyle21.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle22.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle22.StyleInfo.Font.Bold = false;
            gridRangeStyle22.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle22.StyleInfo.Font.Italic = false;
            gridRangeStyle22.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle22.StyleInfo.Font.Strikeout = false;
            gridRangeStyle22.StyleInfo.Font.Underline = false;
            gridRangeStyle22.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle23.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Table();
            gridRangeStyle23.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle23.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.Solid, System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))), Syncfusion.Windows.Forms.Grid.GridBorderWeight.ExtraThin);
            gridRangeStyle23.StyleInfo.Font.Bold = false;
            gridRangeStyle23.StyleInfo.Font.Facename = "Segoe UI";
            gridRangeStyle23.StyleInfo.Font.Italic = false;
            gridRangeStyle23.StyleInfo.Font.Size = 8.5F;
            gridRangeStyle23.StyleInfo.Font.Strikeout = false;
            gridRangeStyle23.StyleInfo.Font.Underline = false;
            gridRangeStyle23.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridRangeStyle23.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.White);
            gridRangeStyle23.StyleInfo.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            gridRangeStyle24.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 1);
            gridRangeStyle24.StyleInfo.Text = "Contact Name";
            gridRangeStyle25.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 2);
            gridRangeStyle25.StyleInfo.Text = "CompanyName";
            gridRangeStyle26.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 3);
            gridRangeStyle26.StyleInfo.Text = "Address";
            gridRangeStyle27.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 4);
            gridRangeStyle27.StyleInfo.Text = "City";
            gridRangeStyle28.Range = Syncfusion.Windows.Forms.Grid.GridRangeInfo.Cell(0, 5);
            gridRangeStyle28.StyleInfo.Text = "Country";
            this.gridControl1.RangeStyles.AddRange(new Syncfusion.Windows.Forms.Grid.GridRangeStyle[] {
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
            gridRangeStyle28});
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridControl1.RowHeightEntries.AddRange(new Syncfusion.Windows.Forms.Grid.GridRowHeight[] {
            new Syncfusion.Windows.Forms.Grid.GridRowHeight(0, 21)});
            this.gridControl1.SerializeCellsBehavior = Syncfusion.Windows.Forms.Grid.GridSerializeCellsBehavior.SerializeAsRangeStylesIntoCode;
            this.gridControl1.Size = new System.Drawing.Size(404, 347);
            this.gridControl1.SmartSizeBox = false;
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ThemesEnabled = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.TypeOfPrintings);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numericUpDownExt1);
            this.groupBox2.Controls.Add(this.radScaleColumnToFit);
            this.groupBox2.Controls.Add(this.RadPrintGridInNewPage);
            this.groupBox2.Controls.Add(this.RadDefaultGridPrint);
            this.groupBox2.Controls.Add(this.RadMultgrdpnt);
            this.groupBox2.Controls.Add(this.buttonAdv1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.ShowHeaderFooter);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox2.Location = new System.Drawing.Point(9, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(911, 75);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid Printing Options";
            // 
            // TypeOfPrintings
            // 
            this.TypeOfPrintings.Controls.Add(this.radMultiGridPrint);
            this.TypeOfPrintings.Controls.Add(this.RadCustomizePrintPage);
            this.TypeOfPrintings.ForeColor = System.Drawing.Color.DimGray;
            this.TypeOfPrintings.Location = new System.Drawing.Point(729, 0);
            this.TypeOfPrintings.Name = "TypeOfPrintings";
            this.TypeOfPrintings.Size = new System.Drawing.Size(182, 75);
            this.TypeOfPrintings.TabIndex = 12;
            this.TypeOfPrintings.TabStop = false;
            this.TypeOfPrintings.Text = "TypeOfPrinting";
            // 
            // radMultiGridPrint
            // 
            this.radMultiGridPrint.BackColor = System.Drawing.Color.White;
            this.radMultiGridPrint.DrawFocusRectangle = false;
            this.radMultiGridPrint.ForeColor = System.Drawing.Color.DimGray;
            this.radMultiGridPrint.Location = new System.Drawing.Point(20, 19);
            this.radMultiGridPrint.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radMultiGridPrint.Name = "radMultiGridPrint";
            this.radMultiGridPrint.Size = new System.Drawing.Size(144, 21);
            this.radMultiGridPrint.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radMultiGridPrint.TabIndex = 8;
            this.radMultiGridPrint.Text = "MultiGridPrint";
            this.radMultiGridPrint.ThemesEnabled = false;
            this.radMultiGridPrint.CheckChanged += new System.EventHandler(this.radMultiGridPrint_CheckChanged);
            // 
            // RadCustomizePrintPage
            // 
            this.RadCustomizePrintPage.BackColor = System.Drawing.Color.White;
            this.RadCustomizePrintPage.DrawFocusRectangle = false;
            this.RadCustomizePrintPage.ForeColor = System.Drawing.Color.DimGray;
            this.RadCustomizePrintPage.Location = new System.Drawing.Point(20, 41);
            this.RadCustomizePrintPage.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.RadCustomizePrintPage.Name = "RadCustomizePrintPage";
            this.RadCustomizePrintPage.Size = new System.Drawing.Size(144, 21);
            this.RadCustomizePrintPage.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.RadCustomizePrintPage.TabIndex = 9;
            this.RadCustomizePrintPage.Text = "CustomizePrintPage";
            this.RadCustomizePrintPage.ThemesEnabled = false;
            this.RadCustomizePrintPage.CheckChanged += new System.EventHandler(this.RadCusomizePrintPage_CheckChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(81, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "NoOfPagesToFit";
            // 
            // numericUpDownExt1
            // 
            this.numericUpDownExt1.BackColor = System.Drawing.Color.White;
            this.numericUpDownExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.numericUpDownExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownExt1.Location = new System.Drawing.Point(184, 35);
            this.numericUpDownExt1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(158)))), ((int)(((byte)(218)))));
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Size = new System.Drawing.Size(76, 23);
            this.numericUpDownExt1.TabIndex = 10;
            this.numericUpDownExt1.VisualStyle = Syncfusion.Windows.Forms.VisualStyle.Metro;
            // 
            // radScaleColumnToFit
            // 
            this.radScaleColumnToFit.BackColor = System.Drawing.Color.White;
            this.radScaleColumnToFit.DrawFocusRectangle = false;
            this.radScaleColumnToFit.ForeColor = System.Drawing.Color.DimGray;
            this.radScaleColumnToFit.Location = new System.Drawing.Point(149, 46);
            this.radScaleColumnToFit.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.radScaleColumnToFit.Name = "radScaleColumnToFit";
            this.radScaleColumnToFit.Size = new System.Drawing.Size(144, 21);
            this.radScaleColumnToFit.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.radScaleColumnToFit.TabIndex = 7;
            this.radScaleColumnToFit.Text = "ScaleColumnToFit";
            this.radScaleColumnToFit.ThemesEnabled = false;
            // 
            // RadPrintGridInNewPage
            // 
            this.RadPrintGridInNewPage.BackColor = System.Drawing.Color.White;
            this.RadPrintGridInNewPage.DrawFocusRectangle = false;
            this.RadPrintGridInNewPage.ForeColor = System.Drawing.Color.DimGray;
            this.RadPrintGridInNewPage.Location = new System.Drawing.Point(149, 22);
            this.RadPrintGridInNewPage.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.RadPrintGridInNewPage.Name = "RadPrintGridInNewPage";
            this.RadPrintGridInNewPage.Size = new System.Drawing.Size(144, 21);
            this.RadPrintGridInNewPage.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.RadPrintGridInNewPage.TabIndex = 6;
            this.RadPrintGridInNewPage.Text = "PrintGridInNewPage";
            this.RadPrintGridInNewPage.ThemesEnabled = false;
            // 
            // RadDefaultGridPrint
            // 
            this.RadDefaultGridPrint.BackColor = System.Drawing.Color.White;
            this.RadDefaultGridPrint.DrawFocusRectangle = false;
            this.RadDefaultGridPrint.ForeColor = System.Drawing.Color.DimGray;
            this.RadDefaultGridPrint.Location = new System.Drawing.Point(22, 46);
            this.RadDefaultGridPrint.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.RadDefaultGridPrint.Name = "RadDefaultGridPrint";
            this.RadDefaultGridPrint.Size = new System.Drawing.Size(121, 21);
            this.RadDefaultGridPrint.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.RadDefaultGridPrint.TabIndex = 5;
            this.RadDefaultGridPrint.Text = "DefaultGridPrint";
            this.RadDefaultGridPrint.ThemesEnabled = false;
            // 
            // RadMultgrdpnt
            // 
            this.RadMultgrdpnt.BackColor = System.Drawing.Color.White;
            this.RadMultgrdpnt.DrawFocusRectangle = false;
            this.RadMultgrdpnt.ForeColor = System.Drawing.Color.DimGray;
            this.RadMultgrdpnt.Location = new System.Drawing.Point(22, 22);
            this.RadMultgrdpnt.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.RadMultgrdpnt.Name = "RadMultgrdpnt";
            this.RadMultgrdpnt.Size = new System.Drawing.Size(121, 21);
            this.RadMultgrdpnt.Style = Syncfusion.Windows.Forms.Tools.RadioButtonAdvStyle.Metro;
            this.RadMultgrdpnt.TabIndex = 4;
            this.RadMultgrdpnt.Text = "MultiGridPrint";
            this.RadMultgrdpnt.ThemesEnabled = false;
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.buttonAdv1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.buttonAdv1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.buttonAdv1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdv1.ForeColor = System.Drawing.Color.White;
            this.buttonAdv1.Location = new System.Drawing.Point(587, 44);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(136, 23);
            this.buttonAdv1.TabIndex = 3;
            this.buttonAdv1.Text = "Print";
            this.buttonAdv1.UseVisualStyle = true;
            this.buttonAdv1.UseVisualStyleBackColor = true;
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // button1
            // 
            this.button1.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.button1.BorderStyleAdv = Syncfusion.Windows.Forms.ButtonAdvBorderStyle.RaisedInner;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(407, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Print Preview";
            this.button1.UseVisualStyle = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowHeaderFooter
            // 
            this.ShowHeaderFooter.BackColor = System.Drawing.Color.White;
            this.ShowHeaderFooter.DrawFocusRectangle = false;
            this.ShowHeaderFooter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowHeaderFooter.ForeColor = System.Drawing.Color.Black;
            this.ShowHeaderFooter.Location = new System.Drawing.Point(407, 21);
            this.ShowHeaderFooter.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ShowHeaderFooter.Name = "ShowHeaderFooter";
            this.ShowHeaderFooter.Size = new System.Drawing.Size(167, 19);
            this.ShowHeaderFooter.Style = Syncfusion.Windows.Forms.Tools.CheckBoxAdvStyle.Metro;
            this.ShowHeaderFooter.TabIndex = 0;
            this.ShowHeaderFooter.Text = "Show Header and Footer";
            this.ShowHeaderFooter.ThemesEnabled = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.BorderThickness = 2;
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(932, 446);
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupBox2);
            this.DropShadow = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(161)))), ((int)(((byte)(226)))));
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi-Grid Printing";
            ((System.ComponentModel.ISupportInitialize)(this.gradientPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.TypeOfPrintings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radMultiGridPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadCustomizePrintPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radScaleColumnToFit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadPrintGridInNewPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadDefaultGridPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RadMultgrdpnt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShowHeaderFooter)).EndInit();
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

        #region Helper Methods
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


        void InitializeGrid()
        {
            //Load Data
            string xmlName = GetFile("Orders.xml");

            DataSet orderDataSet = new DataSet();

            if (this.ReadXml(orderDataSet, xmlName))
            {
                DataTable orderTable = orderDataSet.Tables[0];
                this.gridControl2.RowCount = 100;
                this.gridControl2.ColCount = orderTable.Columns.Count - 1;

                this.gridControl2.PopulateValues(GridRangeInfo.Cells(1, 1, this.gridControl1.RowCount, this.gridControl1.ColCount), orderDataSet.Tables[0]);
                this.gridControl2.PopulateHeaders(GridRangeInfo.Cells(0, 1, 0, this.gridControl1.ColCount), orderTable);
            }

            for (int col = 4; col < 7; col++)
            {
                this.gridControl2.ColStyles[col].CellType = "MonthCalendar";
                this.gridControl2.ColStyles[col].ShowButtons = GridShowButtons.Hide;
                this.gridControl2.ColStyles[col].CellValueType = typeof(DateTime);
                this.gridControl2.ColStyles[col].Format = "MM/dd/yyyy";
            }

            //Set grid appearance
            this.gridControl2.ColWidths.ResizeToFit(GridRangeInfo.Table());
            this.gridControl2.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.gridControl2.ThemesEnabled = true;
            this.gridControl2.DefaultGridBorderStyle = GridBorderStyle.Solid;
        }

        private string GetFile(string fileName)
        {
            string dataFileName = @"Common\Data\Grid\" + fileName;
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

        bool ReadXml(DataSet ds, string xmlFileName)
        {
            // Check both in parent folder and Parent\Data folders.
            string xmlDataFileName = @"Common\Data\" + xmlFileName;
            for (int n = 0; n < 10; n++)
            {
                if (System.IO.File.Exists(xmlFileName))
                {
                    ds.ReadXml(xmlFileName);
                    return true;
                }
                if (System.IO.File.Exists(xmlDataFileName))
                {
                    ds.ReadXml(xmlDataFileName);
                    return true;
                }
                xmlFileName = @"..\" + xmlFileName;
                xmlDataFileName = @"..\" + xmlDataFileName;
            }

            return false;
        }
        #endregion

        #region Event Handlers

        void pd_DrawGridPrintHeader(object sender, Syncfusion.GridHelperClasses.GridPrintHeaderFooterTemplateArgs e)
        {
            // Get the rectangle area to draw
            Rectangle header = e.DrawRectangle;

            //IMAGE
            //scale the image
            SizeF imageSize = new SizeF(header.Width / 3, header.Height * 0.8f);
            //Locating the logo on the right corner of the Drawing Surface
            PointF imageLocation = new PointF(e.DrawRectangle.Width - imageSize.Width - 20, header.Y + 5);
            Bitmap img = new Bitmap(GetIconFile(@"Common\Images\Grid\PDF_logo\logo.png"));
            //Draw the image in the Header.
            e.Graphics.DrawImage(img, new RectangleF(imageLocation, imageSize));

            //TITLE
            Color activeColor = Color.FromArgb(44, 71, 120);
            SolidBrush brush = new SolidBrush(activeColor);
            Font font = new Font("Segoe UI", 20, FontStyle.Bold);
            //Set formattings for the text
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Near;
            format.LineAlignment = StringAlignment.Near;
            //Draw the title
            e.Graphics.DrawString("Customers Order Report", font, brush, new RectangleF(header.Location.X + 20, header.Location.Y + 20, e.DrawRectangle.Width, e.DrawRectangle.Height), format);

            ///BORDER LINES - Draw some lines in the header
            Pen pen = new Pen(Color.DarkBlue, 0.8f);
            e.Graphics.DrawLine(pen, new Point(header.Left, header.Top + 2), new Point(header.Right, header.Top + 2));
            e.Graphics.DrawLine(pen, new Point(header.Left, header.Top + 5), new Point(header.Right, header.Top + 5));
            e.Graphics.DrawLine(pen, new Point(header.Left, header.Bottom - 8), new Point(header.Right, header.Bottom - 8));
            e.Graphics.DrawLine(pen, new Point(header.Left, header.Bottom - 5), new Point(header.Right, header.Bottom - 5));

            //Dispose drawing resources
            font.Dispose();
            format.Dispose();
            pen.Dispose();
        }

        void pd_DrawGridPrintFooter(object sender, Syncfusion.GridHelperClasses.GridPrintHeaderFooterTemplateArgs e)
        {
            //Get the rectangle area to draw
            Rectangle footer = e.DrawRectangle;

            //Draw copy right
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            Font font = new Font("Segoe UI", 8);
            SolidBrush brush = new SolidBrush(Color.Red);
            e.Graphics.DrawString("@copyright", font, brush, GridUtil.CenterPoint(footer), format);

            //Draw page number
            format.LineAlignment = StringAlignment.Far;
            format.Alignment = StringAlignment.Far;
            e.Graphics.DrawString(string.Format("page {0} of {1}", e.PageNumber, e.PageCount), font, brush, new Point(footer.Right - 100, footer.Bottom - 20), format);

            //Dispose resources
            format.Dispose();
            font.Dispose();
            brush.Dispose();
        }

        #endregion

        private void radMultiGridPrint_CheckChanged(object sender, EventArgs e)
        {
            this.RadMultgrdpnt.Show();
            this.radScaleColumnToFit.Show();
            this.RadPrintGridInNewPage.Show();
            this.RadDefaultGridPrint.Show();
            this.numericUpDownExt1.Hide();
            this.label1.Hide();
            this.ShowHeaderFooter.Show();
        }

        private void RadCusomizePrintPage_CheckChanged(object sender, EventArgs e)
        {
            this.RadMultgrdpnt.Hide();
            this.radScaleColumnToFit.Hide();
            this.RadPrintGridInNewPage.Hide();
            this.RadDefaultGridPrint.Hide();
            this.numericUpDownExt1.Show();
            this.label1.Show();
            this.ShowHeaderFooter.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radMultiGridPrint.Checked)
            {
                List<Control> ctrls = new List<Control>();
                List<Control> gCtrls = new List<Control>();
                foreach (Control cd in this.Controls)
                {
                    if (cd is Control)
                    {
                        gCtrls.Add((Control)cd);
                    }
                }
                MultiGridPrintDocument pd = new MultiGridPrintDocument(gCtrls);
                if (RadMultgrdpnt.Checked)
                {
                    pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.MultipleGridPrint;
                }
                else if (RadPrintGridInNewPage.Checked)
                {
                    pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.PrintGridInNewPage;
                }
                else if (RadDefaultGridPrint.Checked)
                {
                    pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.DefaultGridPrint;
                }
                else if (radScaleColumnToFit.Checked)
                {
                    pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.ScaleColumnsToFit;
                }
                if (ShowHeaderFooter.Checked)
                {
                    pd.ShowHeaderFooterOnAllPages = true;
                }
                else
                {
                    pd.ShowHeaderFooterOnAllPages = false;
                }
                //pd.MultipleGridPrint += new MultiGridPrintDocument.RemoveGridEventHandler(pd_MultipleGridPrint);
                pd.HeaderHeight = 70;
                pd.FooterHeight = 50;
                pd.DrawGridPrintHeader += new GridPrintDocumentAdv.DrawGridHeaderFooterEventHandler(pd_DrawGridPrintHeader);
                pd.DrawGridPrintFooter += new GridPrintDocumentAdv.DrawGridHeaderFooterEventHandler(pd_DrawGridPrintFooter);
                PrintPreviewDialog printDialog = new PrintPreviewDialog();
                printDialog.Document = pd;
                printDialog.ShowDialog();
            }
            else if (RadCustomizePrintPage.Checked)
            {
                try
                {

                    this.gridControl1.Model.Properties.PrintFrame = false;

                    Syncfusion.GridHelperClasses.GridPrintDocumentAdv pd = new Syncfusion.GridHelperClasses.GridPrintDocumentAdv(this.gridControl1);
                    pd.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(25, 25, 25, 25);

                    if (this.ShowHeaderFooter.Checked)
                    {
                        pd.HeaderHeight = 70;
                        pd.FooterHeight = 50;
                    }
                    else
                    {
                        pd.HeaderHeight = 0;
                        pd.HeaderHeight = 0;
                    }
                    if (this.numericUpDownExt1.Value < this.gridControl1.Model.ColCount)
                    {
                        pd.PagesToFit = (int)this.numericUpDownExt1.Value;

                        pd.ScaleColumnsToFitPage = false;
                        pd.PrintColumnToFitPage = true;

                        pd.DrawGridPrintHeader += new Syncfusion.GridHelperClasses.GridPrintDocumentAdv.DrawGridHeaderFooterEventHandler(pd_DrawGridPrintHeader);
                        pd.DrawGridPrintFooter += new Syncfusion.GridHelperClasses.GridPrintDocumentAdv.DrawGridHeaderFooterEventHandler(pd_DrawGridPrintFooter);

                        PrintPreviewDialog previewDialog = new PrintPreviewDialog();
                        previewDialog.Document = pd;
                        previewDialog.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please give value less than colcount");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while print preview" + ex.ToString());
                }
            }
        }

        private void buttonAdv1_Click(object sender, EventArgs e)//print.
        {
            if (radMultiGridPrint.Checked)
            {
                List<Control> ctrls = new List<Control>();
                List<Control> gCtrls = new List<Control>();
                foreach (Control cd in this.Controls)
                {
                    if (cd is Control)
                    {
                        gCtrls.Add((Control)cd);
                    }
                }
                MultiGridPrintDocument pd = new MultiGridPrintDocument(gCtrls);
                if (RadMultgrdpnt.Checked)
                {
                    pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.MultipleGridPrint;
                }
                else if (RadPrintGridInNewPage.Checked)
                {
                    pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.PrintGridInNewPage;
                }
                else if (RadDefaultGridPrint.Checked)
                {
                    pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.DefaultGridPrint;
                }
                else if (radScaleColumnToFit.Checked)
                {
                    pd.GridPrintOption = MultiGridPrintDocument.GridPrintOptions.ScaleColumnsToFit;
                }
                if (ShowHeaderFooter.Checked)
                {
                    pd.ShowHeaderFooterOnAllPages = true;
                }
                else
                {
                    pd.ShowHeaderFooterOnAllPages = false;
                }

                //pd.MultipleGridPrint += new MultiGridPrintDocument.RemoveGridEventHandler(pd_MultipleGridPrint);
                pd.HeaderHeight = 70;
                pd.FooterHeight = 50;
                pd.DrawGridPrintHeader += new GridPrintDocumentAdv.DrawGridHeaderFooterEventHandler(pd_DrawGridPrintHeader);
                pd.DrawGridPrintFooter += new GridPrintDocumentAdv.DrawGridHeaderFooterEventHandler(pd_DrawGridPrintFooter);
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = pd;
                pd.DefaultPageSettings.Landscape = true;
                if (printDialog.ShowDialog() == DialogResult.OK)
                    pd.Print();
            }
            else if (RadCustomizePrintPage.Checked)
            {
                try
                {

                    this.gridControl1.Model.Properties.PrintFrame = false;

                    Syncfusion.GridHelperClasses.GridPrintDocumentAdv pd = new Syncfusion.GridHelperClasses.GridPrintDocumentAdv(this.gridControl1);
                    pd.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(25, 25, 25, 25);

                    if (this.ShowHeaderFooter.Checked)
                    {
                        pd.HeaderHeight = 70;
                        pd.FooterHeight = 50;
                    }
                    else
                    {
                        pd.HeaderHeight = 0;
                        pd.HeaderHeight = 0;
                    }
                    if (this.numericUpDownExt1.Value > this.gridControl1.Model.ColCount)
                    {
                        pd.PagesToFit = (int)this.numericUpDownExt1.Value;

                        pd.ScaleColumnsToFitPage = false;
                        pd.PrintColumnToFitPage = true;

                        pd.DrawGridPrintHeader += new Syncfusion.GridHelperClasses.GridPrintDocumentAdv.DrawGridHeaderFooterEventHandler(pd_DrawGridPrintHeader);
                        pd.DrawGridPrintFooter += new Syncfusion.GridHelperClasses.GridPrintDocumentAdv.DrawGridHeaderFooterEventHandler(pd_DrawGridPrintFooter);
                        PrintDialog printDialog = new PrintDialog();
                        printDialog.Document = pd;
                        pd.DefaultPageSettings.Landscape = true;
                        if (printDialog.ShowDialog() == DialogResult.OK)
                            pd.Print();
                    }
                    else
                    {
                        MessageBox.Show("Please give value greater than colcount");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while print preview" + ex.ToString());
                }
            }
        }
    }
}
