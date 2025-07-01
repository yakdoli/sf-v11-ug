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
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private Button button1;
        private Label label2;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private Button browseBtn;
        private TextBox textBox1;
        private OpenFileDialog openFileDialog1;
        private Button Button2;
        private TextBox textBox2;
        private Label Label4;
        private Label label9;
        private Label label5;
        private Label label6;
        private Label label7;
        private GroupBox groupBox2;
        private RadioButton radioButtonImport;
        private RadioButton radioButtonClone;
        private ComboBox comboBoxImportOptions;
        private Label label8;
        private GroupBox groupBox1;
        private Label label1;
        private RadioButton word2013RadioBtn;
        private Label label3;
        private Label label10;
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.browseBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxImportOptions = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonImport = new System.Windows.Forms.RadioButton();
            this.radioButtonClone = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.word2013RadioBtn = new System.Windows.Forms.RadioButton();
            this.word2010RadioBtn = new System.Windows.Forms.RadioButton();
            this.word2003RadioBtn = new System.Windows.Forms.RadioButton();
            this.word2007RadioBtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.button1.Location = new System.Drawing.Point(266, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 25);
            this.button1.TabIndex = 26;
            this.button1.Text = "Generate";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 47);
            this.label2.TabIndex = 72;
            this.label2.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" +
    "ote that MS Word Viewer or MS Word is required to view the resultant document.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(374, 97);
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(350, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 18);
            this.label6.TabIndex = 118;
            this.toolTip1.SetToolTip(this.label6, "Browse the word document to clone");
            // 
            // label7
            // 
            this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
            this.label7.Location = new System.Drawing.Point(350, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 18);
            this.label7.TabIndex = 119;
            this.toolTip1.SetToolTip(this.label7, "Browse the word document to clone");
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(221, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 104;
            this.toolTip1.SetToolTip(this.label1, "Saves the document in Word 2013 format");
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(106, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 18);
            this.label3.TabIndex = 102;
            this.toolTip1.SetToolTip(this.label3, "Saves the document in Word 2010 format");
            // 
            // label10
            // 
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(221, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 18);
            this.label10.TabIndex = 101;
            this.toolTip1.SetToolTip(this.label10, "Saves the document in Word 2007 format");
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
            // browseBtn
            // 
            this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.browseBtn.Location = new System.Drawing.Point(324, 185);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(21, 21);
            this.browseBtn.TabIndex = 103;
            this.browseBtn.Text = ". . .";
            this.browseBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 102;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Button2
            // 
            this.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button2.Location = new System.Drawing.Point(324, 222);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(21, 21);
            this.Button2.TabIndex = 116;
            this.Button2.Text = ". . .";
            this.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(127, 222);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 20);
            this.textBox2.TabIndex = 115;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.Label4.Location = new System.Drawing.Point(12, 225);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(109, 13);
            this.Label4.TabIndex = 114;
            this.Label4.Text = "Second document";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label9.Location = new System.Drawing.Point(12, 188);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 113;
            this.label9.Text = "First document";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(5, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 22);
            this.label5.TabIndex = 117;
            this.label5.Text = "Select Word Documents to Clone";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxImportOptions);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.radioButtonImport);
            this.groupBox2.Controls.Add(this.radioButtonClone);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(3, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 96);
            this.groupBox2.TabIndex = 120;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clone and Merge Options";
            // 
            // comboBoxImportOptions
            // 
            this.comboBoxImportOptions.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxImportOptions.FormattingEnabled = true;
            this.comboBoxImportOptions.Items.AddRange(new object[] {
            "KeepSourceFormatting",
            "MergeFormatting",
            "KeepTextOnly",
            "UseDestinationStyles"});
            this.comboBoxImportOptions.Location = new System.Drawing.Point(139, 64);
            this.comboBoxImportOptions.Name = "comboBoxImportOptions";
            this.comboBoxImportOptions.Size = new System.Drawing.Size(195, 21);
            this.comboBoxImportOptions.TabIndex = 88;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(28, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 87;
            this.label8.Text = "Import options";
            // 
            // radioButtonImport
            // 
            this.radioButtonImport.AutoSize = true;
            this.radioButtonImport.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioButtonImport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonImport.Location = new System.Drawing.Point(12, 43);
            this.radioButtonImport.Name = "radioButtonImport";
            this.radioButtonImport.Size = new System.Drawing.Size(244, 17);
            this.radioButtonImport.TabIndex = 85;
            this.radioButtonImport.Text = "Use Import contents functionality";
            this.radioButtonImport.UseVisualStyleBackColor = true;
            this.radioButtonImport.CheckedChanged += new System.EventHandler(this.radioButtonImport_CheckedChanged);
            // 
            // radioButtonClone
            // 
            this.radioButtonClone.AutoSize = true;
            this.radioButtonClone.Checked = true;
            this.radioButtonClone.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
            this.radioButtonClone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioButtonClone.Location = new System.Drawing.Point(12, 20);
            this.radioButtonClone.Name = "radioButtonClone";
            this.radioButtonClone.Size = new System.Drawing.Size(175, 17);
            this.radioButtonClone.TabIndex = 84;
            this.radioButtonClone.TabStop = true;
            this.radioButtonClone.Text = "Use Clone functionality";
            this.radioButtonClone.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.word2013RadioBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.word2010RadioBtn);
            this.groupBox1.Controls.Add(this.word2003RadioBtn);
            this.groupBox1.Controls.Add(this.word2007RadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 362);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 76);
            this.groupBox1.TabIndex = 121;
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
            this.ClientSize = new System.Drawing.Size(374, 462);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clone and Merge";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            // Creating a new document.
            WordDocument doc = new WordDocument();

            if (radioButtonImport.Checked)
            {
                // Imports the first template document
                if ((string)textBox1.Tag != string.Empty)
                    doc.ImportContent(new WordDocument((string)textBox1.Tag), (ImportOptions)comboBoxImportOptions.SelectedIndex);
                else
                    MessageBox.Show("Browse a Word document to import", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Imports the second template document
                if ((string)textBox2.Tag != string.Empty)
                    doc.ImportContent(new WordDocument((string)textBox2.Tag), (ImportOptions)comboBoxImportOptions.SelectedIndex);
                else
                    MessageBox.Show("Browse a Word document to import", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                // Clones the first template document
                if ((string)textBox1.Tag != string.Empty)
                    CloneDocument(doc, (string)textBox1.Tag);
                else
                    MessageBox.Show("Browse a Word document to clone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Clones the second template document
                if ((string)textBox2.Tag != string.Empty)
                    CloneDocument(doc, (string)textBox2.Tag);
                else
                    MessageBox.Show("Browse a Word document to clone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            //Save as word 2003 format
            if (word2003RadioBtn.Checked)
            {
                //Saving the document to disk.
                doc.Save("Sample.doc");

                //Message box confirmation to view the created document.
                if (MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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

        /// <summary>
        /// Clones the document.
        /// </summary>
        /// <param name="srcDoc">The SRC doc.</param>
        /// <param name="fileName">Name of the file.</param>
        private void CloneDocument(WordDocument srcDoc, string fileName)
        {
            if (File.Exists(fileName))
            {
                // Read the template document
                WordDocument document = new WordDocument(fileName);
                // Enumerate all the sections from the template document.
                foreach (IWSection sec in document.Sections)
                {
                    // Cloning all the sections one by one and merging it to the new document.
                    srcDoc.Sections.Add(sec.Clone());
                    // Setting section break code to be the same as the template.
                    srcDoc.LastSection.BreakCode = sec.BreakCode;
                }
            }
            else
                MessageBox.Show("File doesn�t exist");
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\";
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.SafeFileName;
                this.textBox1.Tag = openFileDialog1.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "Essential DocIO.doc";
            this.textBox1.Tag = Application.StartupPath + @"..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\Essential DocIO.doc";
            this.textBox2.Text = "Essential Pdf.doc";
            this.textBox2.Tag = Application.StartupPath + @"..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\Essential Pdf.doc";
            this.comboBoxImportOptions.SelectedIndex = 0;
            this.comboBoxImportOptions.Enabled = false;
            this.label8.Enabled = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\";
            openFileDialog1.FileName = "";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBox2.Text = openFileDialog1.SafeFileName;
                this.textBox2.Tag = openFileDialog1.FileName;
            }
        }

        private void radioButtonImport_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                this.comboBoxImportOptions.Enabled = true;
                this.label8.Enabled = true;
            }
            else
            {
                this.comboBoxImportOptions.Enabled = false;
                this.label8.Enabled = false;
            }
        }
    }
}
