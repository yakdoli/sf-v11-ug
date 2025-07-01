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
using System.Diagnostics;
using System.IO;

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;
using System.Data.SqlServerCe;

namespace MailmergeWithGroup
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Label label2;

        string dataPath = null;
        WordDocument doc = null;
    
       private System.Windows.Forms.ListBox listBoxCustomer;
       private GroupBox groupBox1;
        private Button button1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button templateBtn;
        private ToolTip toolTip1;
        private GroupBox groupBox2;
        private Label label5;
        private RadioButton word2013RadioBtn;
        private Label label3;
        private Label label4;
        private Label label24;
        private RadioButton word2010RadioBtn;
        private RadioButton word2003RadioBtn;
        private RadioButton word2007RadioBtn;
        private IContainer components;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxCustomer = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.templateBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.word2013RadioBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.word2010RadioBtn = new System.Windows.Forms.RadioButton();
            this.word2003RadioBtn = new System.Windows.Forms.RadioButton();
            this.word2007RadioBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Customer ID";
            // 
            // listBoxCustomer
            // 
            this.listBoxCustomer.Location = new System.Drawing.Point(11, 34);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.Size = new System.Drawing.Size(90, 95);
            this.listBoxCustomer.TabIndex = 2;
            this.listBoxCustomer.DoubleClick += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(254, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 25);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "Create Invoice";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.templateBtn);
            this.groupBox1.Controls.Add(this.listBoxCustomer);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 137);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // templateBtn
            // 
            this.templateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.templateBtn.BackColor = System.Drawing.Color.Transparent;
            this.templateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.templateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.templateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.templateBtn.Image = ((System.Drawing.Image)(resources.GetObject("templateBtn.Image")));
            this.templateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.templateBtn.Location = new System.Drawing.Point(118, 104);
            this.templateBtn.Name = "templateBtn";
            this.templateBtn.Size = new System.Drawing.Size(99, 25);
            this.templateBtn.TabIndex = 3;
            this.templateBtn.Text = "View Template";
            this.templateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.templateBtn.UseVisualStyleBackColor = false;
            this.templateBtn.Click += new System.EventHandler(this.templateBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.word2013RadioBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.word2010RadioBtn);
            this.groupBox2.Controls.Add(this.word2003RadioBtn);
            this.groupBox2.Controls.Add(this.word2007RadioBtn);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(112, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 70);
            this.groupBox2.TabIndex = 101;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Save As";
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(221, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 18);
            this.label5.TabIndex = 104;
            this.toolTip1.SetToolTip(this.label5, "Saves the document in Word 2013 format");
            // 
            // word2013RadioBtn
            // 
            this.word2013RadioBtn.AutoSize = true;
            this.word2013RadioBtn.Checked = true;
            this.word2013RadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word2013RadioBtn.Location = new System.Drawing.Point(139, 46);
            this.word2013RadioBtn.Name = "word2013RadioBtn";
            this.word2013RadioBtn.Size = new System.Drawing.Size(86, 17);
            this.word2013RadioBtn.TabIndex = 103;
            this.word2013RadioBtn.TabStop = true;
            this.word2013RadioBtn.Text = "Word 2013";
            this.word2013RadioBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(107, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 18);
            this.label3.TabIndex = 102;
            this.toolTip1.SetToolTip(this.label3, "Saves the document in Word 2010 format");
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(221, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 18);
            this.label4.TabIndex = 101;
            this.toolTip1.SetToolTip(this.label4, "Saves the document in Word 2007 format");
            // 
            // label24
            // 
            this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
            this.label24.Location = new System.Drawing.Point(107, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 18);
            this.label24.TabIndex = 100;
            this.toolTip1.SetToolTip(this.label24, "Saves the document in Word 97-2003 format\r\n");
            // 
            // word2010RadioBtn
            // 
            this.word2010RadioBtn.AutoSize = true;
            this.word2010RadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.word2010RadioBtn.Location = new System.Drawing.Point(6, 46);
            this.word2010RadioBtn.Name = "word2010RadioBtn";
            this.word2010RadioBtn.Size = new System.Drawing.Size(86, 17);
            this.word2010RadioBtn.TabIndex = 46;
            this.word2010RadioBtn.Text = "Word 2010";
            this.word2010RadioBtn.UseVisualStyleBackColor = true;
            // 
            // word2003RadioBtn
            // 
            this.word2003RadioBtn.AutoSize = true;
            this.word2003RadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.word2003RadioBtn.Location = new System.Drawing.Point(6, 20);
            this.word2003RadioBtn.Name = "word2003RadioBtn";
            this.word2003RadioBtn.Size = new System.Drawing.Size(105, 17);
            this.word2003RadioBtn.TabIndex = 44;
            this.word2003RadioBtn.Text = "Word 97-2003";
            this.word2003RadioBtn.UseVisualStyleBackColor = true;
            // 
            // word2007RadioBtn
            // 
            this.word2007RadioBtn.AutoSize = true;
            this.word2007RadioBtn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.word2007RadioBtn.Location = new System.Drawing.Point(139, 20);
            this.word2007RadioBtn.Name = "word2007RadioBtn";
            this.word2007RadioBtn.Size = new System.Drawing.Size(86, 17);
            this.word2007RadioBtn.TabIndex = 45;
            this.word2007RadioBtn.Text = "Word 2007";
            this.word2007RadioBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(0, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 51);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" +
    "ote that MS Word Viewer or MS Word is required to view the resultant document.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 97);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 301);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Invoice";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Get all customer ID's from database and add to the list box.
            try
            {
                // Get Template document and database path.
                dataPath = Application.StartupPath + @"\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\";                                           

                AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);

                DataTable dt = new DataTable();
                string connectionstring = "Data Source = " + dataPath + "NorthwindIO.sdf";
                SqlCeConnection conn = new SqlCeConnection(connectionstring);
                conn.Open();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter("select OrderID  from SyncOrders Order By OrderID", conn);
                adapter.Fill(dt);
                adapter.Dispose();
                conn.Close();


                // Add Customer ID to the list box.
                foreach (DataRow row in dt.Rows)
                    listBoxCustomer.Items.Add(row["OrderID"]);
                listBoxCustomer.SelectedIndex = 0;

            }
            catch (Exception Ex)
            {
                // Shows the Message box with Exception message, if an exception is thrown.
                MessageBox.Show(Ex.Message, "Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Generate Invoice for the selected ID.
            ExecuteMail_Doc((int)listBoxCustomer.SelectedItem);

        }
        private void ExecuteMail_Doc(int ID)
        {
            try
            {
                // Create a new document
                doc = new WordDocument();
                // Load the template.

                doc.Open((System.IO.Path.Combine(dataPath, @"SalesInvoiceDemo.doc")), FormatType.Doc);
                // Execute Mail Merge with groups.
                doc.MailMerge.ExecuteGroup(GetTestOrder(ID));
                doc.MailMerge.ExecuteGroup(GetTestOrderTotals(ID));

                // Using Merge events to do conditional formatting during runtime.
                doc.MailMerge.MergeField += new MergeFieldEventHandler(MailMerge_MergeField);

                DataView orderDetails = new DataView(GetTestOrderDetails(ID));
                orderDetails.Sort = "ExtendedPrice DESC";
                doc.MailMerge.ExecuteGroup(orderDetails);

                //Save as word 2003 format
                if (word2003RadioBtn.Checked)
                {
                    //Saving the document to disk.
                    doc.Save("Sample.doc");

                    //Message box confirmation to view the created document.
                    if (MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                        System.Diagnostics.Process.Start("Sample.doc");
                        //Exit
                        this.Close();
                    }
                }
                //Save as word 2007 format
                else if (word2007RadioBtn.Checked)
                {
                    //Saving the document as .docx
                    doc.Save("Sample.docx", FormatType.Word2007);
                    //Message box confirmation to view the created document.
                    if (MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                            System.Diagnostics.Process.Start("Sample.docx");
                            //Exit
                            this.Close();
                        }
                        catch (Win32Exception ex)
                        {
                            MessageBox.Show("Word 2007 is not installed in this system");
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                //Save as word 2010  format
                else if (word2010RadioBtn.Checked)
                {
                    //Saving the document as .docx
                    doc.Save("Sample.docx", FormatType.Word2010);
                    //Message box confirmation to view the created document.
                    if (MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                            System.Diagnostics.Process.Start("Sample.docx");
                            //Exit
                            this.Close();
                        }
                        catch (Win32Exception ex)
                        {
                            MessageBox.Show("Word 2010 is not installed in this system");
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                //Save as word 2013  format
                else if (word2013RadioBtn.Checked)
                {
                    //Saving the document as .docx
                    doc.Save("Sample.docx", FormatType.Word2013);
                    //Message box confirmation to view the created document.
                    if (MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            //Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                            System.Diagnostics.Process.Start("Sample.docx");
                            //Exit
                            this.Close();
                        }
                        catch (Win32Exception ex)
                        {
                            MessageBox.Show("Word 2013 is not installed in this system");
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                else
                {
                    // Exit
                    this.Close();
                }

           }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private DataTable GetTestOrder(int TestOrderId)
        {

            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);

            DataTable table = new DataTable();
            string connectionstring = "Data Source = " + dataPath + "NorthwindIO.sdf";
            SqlCeConnection conn = new SqlCeConnection(connectionstring);
            conn.Open();
            SqlCeDataAdapter adapter = new SqlCeDataAdapter("SELECT * FROM SyncOrders WHERE OrderId = " + TestOrderId , conn);
            adapter.Fill(table);
            adapter.Dispose();
            conn.Close();
                  
            table.TableName = "Orders";
            return table;
        }

        private DataTable GetTestOrderDetails(int TestOrderId)
        {
            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);

            DataTable table = new DataTable();
            string connectionstring = "Data Source = " + dataPath + "NorthwindIO.sdf";
            SqlCeConnection conn = new SqlCeConnection(connectionstring);
            conn.Open();
            SqlCeDataAdapter adapter = new SqlCeDataAdapter("SELECT * FROM SyncOrderDetails WHERE OrderId = " + TestOrderId +" ORDER BY ProductID", conn);
            adapter.Fill(table);
            adapter.Dispose();
            conn.Close();                  

            table.TableName = "Order";
            return table;
        }

        private DataTable GetTestOrderTotals(int TestOrderId)
        {

            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);

            DataTable table = new DataTable();
            string connectionstring = "Data Source = " + dataPath + "NorthwindIO.sdf";
            SqlCeConnection conn = new SqlCeConnection(connectionstring);
            conn.Open();
            SqlCeDataAdapter adapter = new SqlCeDataAdapter("SELECT * FROM SyncOrderTotals WHERE OrderId = " + TestOrderId, conn);
            adapter.Fill(table);
            adapter.Dispose();
            conn.Close();     
               
            table.TableName = "OrderTotals";
            return table;
        }

        private DataTable ExecuteDataTable(string commandText)
        {
            // Return DataTable
            try
            {
                AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", true);

                DataTable table = new DataTable();
                string connectionstring = "Data Source = " + dataPath + "NorthwindIO.sdf";
                SqlCeConnection conn = new SqlCeConnection(connectionstring);
                conn.Open();
                SqlCeDataAdapter adapter = new SqlCeDataAdapter(commandText, conn);
                adapter.Fill(table);
                adapter.Dispose();
                conn.Close();     
                return table;
            }
            finally
            {              
            }
        }

        private void MailMerge_MergeField(object sender, MergeFieldEventArgs args)
        {
            // Conditionally format data during Merge.
            if (args.RowIndex % 2 == 0)
            {
                args.CharacterFormat.TextColor = Color.DarkBlue;
            }

        }
        /// <summary>
        /// The source template document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void templateBtn_Click(object sender, EventArgs e)
        {
            Process.Start(dataPath + "SalesInvoiceDemo.doc");
        }
    }
}
