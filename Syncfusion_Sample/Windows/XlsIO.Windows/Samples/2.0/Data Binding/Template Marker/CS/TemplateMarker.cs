#region Copyright Syncfusion Inc. 2001 - 2007
//
//  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
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
using System.Windows.Forms;
using System.Data;
using System.Collections.Generic;
using Syncfusion.XlsIO;

namespace EssentialXlsIOSamples
{
    /// <summary>
    /// Summary description for TemplateMarker.
    /// </summary>
    public class TemplateMarker : System.Windows.Forms.Form
    {

        #region Constants
        private const string DEFAULTPATH = @"..\..\..\..\..\..\..\..\..\Common\Data\XlsIO\{0}";
        #endregion

        #region Fields
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private DataTable northwindDt;
        IList<Customer> _customers = new List<Customer>();
        private DataTable numbersDt;
        private PictureBox pictureBox1;
        private Label label2;
        private String fileName;
        private GroupBox groupBox1;
        private RadioButton rdbDataTable;
        private RadioButton rdbObjects;
        private Button viewInputTemplate;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

        #region Initialize
        public TemplateMarker()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        #endregion

        #region Template Marker
        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            #region Initialize Workbook
            //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
            //The instantiation process consists of two steps.

            //Instantiate the spreadsheet creation engine.
            ExcelEngine excelEngine = new ExcelEngine();

            excelEngine.Excel.DefaultVersion = ExcelVersion.Excel2007;
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("TemplateMarker.xlsx");
            //Open an existing spreadsheet which will be used as a template for generating the new spreadsheet.
            //After opening, the workbook object represents the complete in-memory object model of the template spreadsheet.
            IWorkbook workbook = excelEngine.Excel.Workbooks.Open(inputPath);
            //The first worksheet object in the worksheets collection is accessed.
            IWorksheet worksheet1 = workbook.Worksheets[0];
            IWorksheet worksheet2 = workbook.Worksheets[1];
            #endregion

            #region Create Template Marker
            //Create Template Marker Processor
            ITemplateMarkersProcessor marker = workbook.CreateTemplateMarkersProcessor();

            IConditionalFormats conditionalFormats = marker.CreateConditionalFormats(worksheet1["C5"]);
            #region Data Bar
            //Apply markers using Formula

            IConditionalFormat condition = conditionalFormats.AddCondition();

            //Set Data bar and icon set for the same cell
            //Set the format type
            condition.FormatType = ExcelCFType.DataBar;
            IDataBar dataBar = condition.DataBar;

            //Set the constraint
            dataBar.MinPoint.Type = ConditionValueType.LowestValue;
            dataBar.MinPoint.Value = "0";
            dataBar.MaxPoint.Type = ConditionValueType.HighestValue;
            dataBar.MaxPoint.Value = "0";

            //Set color for Bar
            dataBar.BarColor = Color.FromArgb(156, 208, 243);

            //Hide the value in data bar
            dataBar.ShowValue = false;
            #endregion

            #region IconSet
            condition = conditionalFormats.AddCondition();
            condition.FormatType = ExcelCFType.IconSet;
            IIconSet iconSet = condition.IconSet;
            iconSet.IconSet = ExcelIconSetType.FourRating;
            iconSet.IconCriteria[0].Type = ConditionValueType.LowestValue;
            iconSet.IconCriteria[0].Value = "0";
            iconSet.IconCriteria[1].Type = ConditionValueType.HighestValue;
            iconSet.IconCriteria[1].Value = "0";
            iconSet.ShowIconOnly = true;
            #endregion

            conditionalFormats = marker.CreateConditionalFormats(worksheet1["D5"]);
            #region Color Scale

            condition = conditionalFormats.AddCondition();

            condition.FormatType = ExcelCFType.ColorScale;
            IColorScale colorScale = condition.ColorScale;

            //Sets 3 - color scale.
            colorScale.SetConditionCount(3);

            colorScale.Criteria[0].FormatColorRGB = Color.FromArgb(230, 197, 218);
            colorScale.Criteria[0].Type = ConditionValueType.LowestValue;
            colorScale.Criteria[0].Value = "0";

            colorScale.Criteria[1].FormatColorRGB = Color.FromArgb(244, 210, 178);
            colorScale.Criteria[1].Type = ConditionValueType.Percentile;
            colorScale.Criteria[1].Value = "50";

            colorScale.Criteria[2].FormatColorRGB = Color.FromArgb(245, 247, 171);
            colorScale.Criteria[2].Type = ConditionValueType.HighestValue;
            colorScale.Criteria[2].Value = "0";
            #endregion

            conditionalFormats = marker.CreateConditionalFormats(worksheet1["E5"]);
            #region Iconset
            condition = conditionalFormats.AddCondition();
            condition.FormatType = ExcelCFType.IconSet;
            iconSet = condition.IconSet;
            iconSet.IconSet = ExcelIconSetType.ThreeSymbols;
            iconSet.IconCriteria[0].Type = ConditionValueType.LowestValue;
            iconSet.IconCriteria[0].Value = "0";
            iconSet.IconCriteria[1].Type = ConditionValueType.HighestValue;
            iconSet.IconCriteria[1].Value = "0";
            iconSet.ShowIconOnly = false;

            #endregion



            //Northwind customers table			
            if (rdbDataTable.Checked)
                marker.AddVariable("Customers", northwindDt);
            else
            {
                //New instance of XlsIO is created.[Equivalent to launching MS Excel with no workbooks open].
                //The instantiation process consists of two steps.
                if (this._customers.Count == 0)
                {
                    this._customers = GetCustomerAsObjects();
                }
                marker.AddVariable("Customers", _customers);
            }

            //Create markers
            worksheet1.Range["B9"].Text = "%Names;horizontal";
            worksheet1.Range["B10"].Text = "%Descriptions;horizontal";

            //Insert Array Horizontally
            string[] names = new string[] { "Essential DocIO", "Essential XlsIO", "Essential Pdf" };
            string[] descriptions = new string[] { "This is an efficient library for creating MSWord documents", "This is an efficient library for creating MSExcel documents", "This is an efficient library for creating Adobe PDF documents" };
            marker.AddVariable("Names", names);
            marker.AddVariable("Descriptions", descriptions);

            //Stretch Formula. This shows the data getting replaced in the marker specified in another worksheet.
            marker.AddVariable("NumbersTable", numbersDt);

            //Process the markers in the template.
            marker.ApplyMarkers();
            #endregion

            #region Save the Workbook
            workbook.Version = ExcelVersion.Excel2007;
            //Saving the workbook to disk. This spreadsheet is the result of opening and modifying
            //an existing spreadsheet and then saving the result to a new workbook.
            fileName = "TemplateMarker.xlsx";
            workbook.SaveAs(fileName);
            #endregion

            #region Workbook Close and Dispose
            //Close the workbook.
            workbook.Close();

            excelEngine.Dispose();
            #endregion

            #region View the Workbook
            //Message box confirmation to view the created spreadsheet.
            if (MessageBox.Show("Do you want to view the workbook?", "Workbook has been created",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
                System.Diagnostics.Process.Start(fileName);
            }
            // Exit
            this.Close();
            #endregion

        }
        #endregion

        #region View the Input Template
        private void viewInputTemplate_Click(object sender, EventArgs e)
        {
            //Get the path of the input file
            string inputPath = GetFullTemplatePath("TemplateMarker.xlsx");
            //Launching the Excel file using the default Application.[MS Excel Or Free ExcelViewer]
            System.Diagnostics.Process.Start(inputPath);
        }
        #endregion
    
        #region Form Load
        private void Form1_Load(object sender, System.EventArgs e)
        {
            //Load Data
            DataSet customersDataSet = new DataSet();
            //Get the path of the input file
            string inputXmlPath = GetFullTemplatePath("Customers.xml");
            customersDataSet.ReadXml(inputXmlPath, XmlReadMode.ReadSchema);
            northwindDt = customersDataSet.Tables[0];
            numbersDt = GetTable();
        }
        #endregion

        #region HelperMethods
        /// <summary>
        /// Get the file path of input file and return the same
        /// </summary>
        /// <param name="inputPath">Input file</param>
        /// <returns>path of the input file</returns>
        private string GetFullTemplatePath(string inputFile)
        {
            return string.Format(DEFAULTPATH, inputFile);
        }


        /// <summary>
        /// create datatable with numbers and returns the same
        /// </summary>
        /// <returns>datatable filled with number</returns>
        private DataTable GetTable()
        {
            Random r = new Random();
            DataTable dt = new DataTable("NumbersTable");

            int nCols = 4;
            int nRows = 10;

            for (int i = 0; i < nCols; i++)
                dt.Columns.Add(new DataColumn("Column" + i.ToString()));

            for (int i = 0; i < nRows; ++i)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < nCols; j++)
                    dr[j] = r.Next(0, 10);
                dt.Rows.Add(dr);
            }
            return dt;
        }

        /// <summary>
        /// Gets the Collection of objects from the XML data.
        /// </summary>
        /// <returns>Collection of Customer Objects</returns>
        private IList<Customer> GetCustomerAsObjects()
        {
            DataSet customersDataSet = new DataSet();
            //Get the path of the input file
            string inputXmlPath = GetFullTemplatePath("Customers.xml");
            customersDataSet.ReadXml(inputXmlPath, XmlReadMode.ReadSchema);
            northwindDt = customersDataSet.Tables[0];
            IList<Customer> tmpCustomers = new List<Customer>();
            Customer customer = new Customer();
            numbersDt = GetTable();
            //numbersDt = GetTable();
            DataColumnCollection columns = northwindDt.Columns;
            DataRowCollection rows = northwindDt.Rows;
            foreach (DataRow row in rows)
            {
                customer = new Customer();
                customer.SalesPerson = row[0].ToString();
                customer.SalesJanJune = row[1].ToString();
                customer.SalesJulyDec = row[2].ToString();
                customer.Change = Convert.ToInt32(row[3]);
                tmpCustomers.Add(customer);
            }

            return tmpCustomers;
        }

        #endregion

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateMarker));
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDataTable = new System.Windows.Forms.RadioButton();
            this.rdbObjects = new System.Windows.Forms.RadioButton();
            this.viewInputTemplate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.BackColor = System.Drawing.Color.Transparent;
            this.btnCreate.Image = ((System.Drawing.Image)(resources.GetObject("btnCreate.Image")));
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.Location = new System.Drawing.Point(77, 207);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 25);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 96);
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 48);
            this.label2.TabIndex = 63;
            this.label2.Text = "Click the button to view an Excel spreadsheet generated by Essential XlsIO. Pleas" +
                "e note that MS Excel Viewer or MS Excel is required to view the resultant docume" +
                "nt.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbDataTable);
            this.groupBox1.Controls.Add(this.rdbObjects);
            this.groupBox1.Location = new System.Drawing.Point(79, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(214, 43);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            // 
            // rdbDataTable
            // 
            this.rdbDataTable.AutoSize = true;
            this.rdbDataTable.Checked = true;
            this.rdbDataTable.Location = new System.Drawing.Point(9, 15);
            this.rdbDataTable.Name = "rdbDataTable";
            this.rdbDataTable.Size = new System.Drawing.Size(75, 17);
            this.rdbDataTable.TabIndex = 65;
            this.rdbDataTable.TabStop = true;
            this.rdbDataTable.Text = "DataTable";
            this.rdbDataTable.UseVisualStyleBackColor = true;
            // 
            // rdbObjects
            // 
            this.rdbObjects.AutoSize = true;
            this.rdbObjects.Location = new System.Drawing.Point(100, 14);
            this.rdbObjects.Name = "rdbObjects";
            this.rdbObjects.Size = new System.Drawing.Size(106, 17);
            this.rdbObjects.TabIndex = 64;
            this.rdbObjects.TabStop = true;
            this.rdbObjects.Text = "Business Objects";
            this.rdbObjects.UseVisualStyleBackColor = true;
            // 
            // viewInputTemplate
            // 
            this.viewInputTemplate.Location = new System.Drawing.Point(194, 206);
            this.viewInputTemplate.Name = "viewInputTemplate";
            this.viewInputTemplate.Size = new System.Drawing.Size(99, 26);
            this.viewInputTemplate.TabIndex = 68;
            this.viewInputTemplate.Text = "Input Template";
            this.viewInputTemplate.UseVisualStyleBackColor = true;
            this.viewInputTemplate.Click += new System.EventHandler(this.viewInputTemplate_Click);
            // 
            // TemplateMarker
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 243);
            this.Controls.Add(this.viewInputTemplate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TemplateMarker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Template Marker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
     
        #region Dispose
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
   /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new TemplateMarker());
        }
        #endregion
}
}
