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
using System.Drawing.Imaging;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics;

using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;

namespace EssentialDocIOSamples
{
	public class Form1 : System.Windows.Forms.Form
    {

        #region Private Members

        private Button button1;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private NumericUpDown numericUpDown1;
        private Label label20;
        private Label label5;
        private Label label2;
        private Label label6;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private PictureBox pictureBox1;
        private Label label1;

        #endregion 

        private ToolTip toolTip1;
        private GroupBox groupBox1;
        private Label label7;
        private RadioButton word2013RadioBtn;
        private Label label8;
        private Label label9;
        private Label label24;
        private RadioButton word2010RadioBtn;
        private RadioButton word2003RadioBtn;
        private RadioButton word2007RadioBtn;
        private IContainer components;

        #region Constructor, Main And Dispose
        public Form1()
        {
            InitializeComponent();
            //Associate PageNumberStyle Enum values to comboBox
            foreach (String str in Enum.GetNames(typeof(PageNumberStyle)))
                this.comboBox1.Items.Add(str);
            this.comboBox1.SelectedIndex = 2;

        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
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

        #endregion 

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.word2013RadioBtn = new System.Windows.Forms.RadioButton();
            this.word2010RadioBtn = new System.Windows.Forms.RadioButton();
            this.word2003RadioBtn = new System.Windows.Forms.RadioButton();
            this.word2007RadioBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(293, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "Generate";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Number Format";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(278, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 21);
            this.comboBox1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Start at:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(278, 164);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(93, 20);
            this.numericUpDown1.TabIndex = 33;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label20.Location = new System.Drawing.Point(199, 115);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(170, 1);
            this.label20.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(199, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Page Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Header And Footer";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(164)))), ((int)(((byte)(190)))));
            this.label6.Location = new System.Drawing.Point(7, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 1);
            this.label6.TabIndex = 36;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(6, 134);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(186, 18);
            this.checkBox1.TabIndex = 38;
            this.checkBox1.Tag = "scrolls";
            this.checkBox1.Text = "Header and Footer For First Page";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(6, 165);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(182, 18);
            this.checkBox2.TabIndex = 39;
            this.checkBox2.Tag = "scrolls";
            this.checkBox2.Text = "Header and Footer For All Pages";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 77);
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 54);
            this.label1.TabIndex = 27;
            this.label1.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" +
    "ote that MS Word Viewer or MS Word is required to view the resultant document.";
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(221, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 18);
            this.label7.TabIndex = 104;
            this.toolTip1.SetToolTip(this.label7, "Saves the document in Word 2013 format");
            // 
            // label8
            // 
            this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
            this.label8.Location = new System.Drawing.Point(106, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 18);
            this.label8.TabIndex = 102;
            this.toolTip1.SetToolTip(this.label8, "Saves the document in Word 2010 format");
            // 
            // label9
            // 
            this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
            this.label9.Location = new System.Drawing.Point(221, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 18);
            this.label9.TabIndex = 101;
            this.toolTip1.SetToolTip(this.label9, "Saves the document in Word 2007 format");
            // 
            // label24
            // 
            this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
            this.label24.Location = new System.Drawing.Point(106, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 18);
            this.label24.TabIndex = 100;
            this.toolTip1.SetToolTip(this.label24, "Saves the document in Word 97-2003 format\r\n");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.word2013RadioBtn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.word2010RadioBtn);
            this.groupBox1.Controls.Add(this.word2003RadioBtn);
            this.groupBox1.Controls.Add(this.word2007RadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 76);
            this.groupBox1.TabIndex = 101;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Save As";
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
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(374, 345);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Header and Footer";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion		
     
        #region Events
        private void button1_Click(object sender, System.EventArgs e)
		{
			// Creating a new document.
            WordDocument doc = new WordDocument();
			
			// Add a new section to the document.
             IWSection section1 = doc.AddSection();
			
			
            #region Header Footer
            //Add different Header Footer for first and other pages
            if (checkBox1.Checked && checkBox2.Checked)
            {
                // Set the header/footer setup.
			    section1.PageSetup.DifferentFirstPage = true;
                // Inserting Header Footer to first page
                InsertFirstPageHeaderFooter(doc, section1);
                // Inserting Header Footer to all pages
                InsertPageHeaderFooter(doc, section1);
            }
            //Add Header Footer only for first page
            if (checkBox1.Checked && !checkBox2.Checked)
            {
                // Set the header/footer setup.
                section1.PageSetup.DifferentFirstPage = true;
                // Inserting Header Footer to first page
                InsertFirstPageHeaderFooter(doc, section1);
            }
            //Add same Header Footer for all the pages
            if (checkBox2.Checked && !checkBox1.Checked)
            {
                // Inserting Header Footer to all pages
                InsertPageHeaderFooter(doc, section1);
            }
            #endregion

            // Add text to the document body section.
            IWParagraph par;
            par = section1.AddParagraph();
            //Insert Text into the word Document.
            StreamReader reader = new StreamReader(@"..\..\..\..\..\..\..\..\..\Common\Data\DocIO\WinFAQ.txt", System.Text.Encoding.ASCII);
            string text = reader.ReadToEnd();
            par.AppendText(text);

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
        #endregion

        #region Helper Methods

        #region InsertFirstPageHeaderFooter
        private void InsertFirstPageHeaderFooter(WordDocument doc, IWSection section)
        {
            // Add a new paragraph for header to the document.
            IWParagraph headerPar = new WParagraph(doc);

            // Add a new table to the header.
            IWTable table = section.HeadersFooters.FirstPageHeader.AddTable();

            RowFormat format = new RowFormat();

            // Setting cleared table border style.
            format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Cleared;

            // Inserting table with a row and two columns.
            table.ResetCells(1, 2, format, 265);

            // Inserting logo image to the table first cell.
            headerPar = table[0, 0].AddParagraph() as WParagraph;
            headerPar.AppendPicture(Image.FromFile(@"..\..\..\..\..\..\..\..\..\Common\images\DocIO\syncfusion_logo.gif"));
            //Set Image size
            (headerPar.Items[0] as WPicture).Width = 232.5f;
            (headerPar.Items[0] as WPicture).Height = 54.75f;
            // Inserting text to the table second cell.
            headerPar = table[0, 1].AddParagraph() as WParagraph;
            IWTextRange txt = headerPar.AppendText("Company Headquarters,\n2501 Aerial Center Parkway,\nSuite 110, Morrisville, NC 27560,\nTEL 1-888-936-8638.");
            txt.CharacterFormat.FontSize = 12;
            txt.CharacterFormat.CharacterSpacing = 1.7f;
            headerPar.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right;
            // Add a new paragraph to the header with address text.
            headerPar = new WParagraph(doc);
            headerPar.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            txt = headerPar.AppendText("\nFirst Page Header");
            txt.CharacterFormat.CharacterSpacing = 1.7f;
            section.HeadersFooters.FirstPageHeader.Paragraphs.Add(headerPar);

            // Add a footer paragraph text to the document.
            WParagraph footerPar = new WParagraph(doc);
            footerPar.ParagraphFormat.Tabs.AddTab(523f, TabJustification.Right, TabLeader.NoLeader);
            // Add text.
            footerPar.AppendText("Copyright Syncfusion Inc. 2001 - 2012");
            // Add page and Number of pages field to the document.
            footerPar.AppendText("\tFirst Page ");
            footerPar.AppendField("Page", FieldType.FieldPage);
            section.HeadersFooters.FirstPageFooter.Paragraphs.Add(footerPar);
            #region Page Number Settings
            section.PageSetup.RestartPageNumbering = true;
            section.PageSetup.PageStartingNumber = Convert.ToInt32(this.numericUpDown1.Value);
            section.PageSetup.PageNumberStyle = (PageNumberStyle)Enum.Parse(typeof(PageNumberStyle), this.comboBox1.SelectedItem.ToString(), true);
            #endregion
        }

        #endregion

        #region InsertPageHeaderFooter
        private void InsertPageHeaderFooter(WordDocument doc, IWSection section1)
        {
             // Add a new paragraph for header to the document.
            IWParagraph headerPar = new WParagraph(doc);

            // Add a new table to the header
            IWTable table = section1.HeadersFooters.Header.AddTable();

            RowFormat format = new RowFormat();

            // Setting Single table border style.
            format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;

            // Inserting table with a row and two columns.
            table.ResetCells(1, 2, format, 265);

            // Inserting logo image to the table first cell.
            headerPar = table[0, 0].AddParagraph() as WParagraph;
            headerPar.AppendPicture(Image.FromFile(@"..\..\..\..\..\..\..\..\..\Common\images\DocIO\syncfusion_logo.gif"));
            //Set Image size.
            (headerPar.Items[0] as WPicture).Width = 232.5f;
            (headerPar.Items[0] as WPicture).Height = 54.75f;
            // Inserting text to the table second cell.
            headerPar = table[0, 1].AddParagraph() as WParagraph;
            IWTextRange txt = headerPar.AppendText("Company Headquarters,\n2501 Aerial Center Parkway,\nSuite 110, Morrisville, NC 27560,\nTEL 1-888-936-8638.");
            txt.CharacterFormat.FontSize = 12;
            txt.CharacterFormat.CharacterSpacing = 1.7f;
            headerPar.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right;

            // Add a footer paragraph text to the document.
            WParagraph footerPar = new WParagraph(doc);
            footerPar.ParagraphFormat.Tabs.AddTab(523f, TabJustification.Right, TabLeader.NoLeader);
            // Add text.
            footerPar.AppendText("Copyright Syncfusion Inc. 2001 - 2012");
            // Add page and Number of pages field to the document.
            footerPar.AppendText("\tPage ");
            IWField ff = footerPar.AppendField("Page", FieldType.FieldPage);

            section1.HeadersFooters.Footer.Paragraphs.Add(footerPar);

            #region Page Number Settings
            section1.PageSetup.RestartPageNumbering = true;
            section1.PageSetup.PageStartingNumber = Convert.ToInt32(this.numericUpDown1.Value);
            section1.PageSetup.PageNumberStyle = (PageNumberStyle)Enum.Parse(typeof(PageNumberStyle), this.comboBox1.SelectedItem.ToString(), true);
            #endregion

        }



        #endregion
             

        #endregion 
	}
}
