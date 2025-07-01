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

using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;

namespace EssentialDocIOSamples
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Button button1;
        private Button btnFill;
        private PictureBox pictureBox1;
        private ToolTip toolTip1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label5;
        private RadioButton word2013RadioBtn;
        private Label label3;
        private Label label1;
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
            Application.EnableVisualStyles();
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
            this.btnFill = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.word2013RadioBtn = new System.Windows.Forms.RadioButton();
            this.word2010RadioBtn = new System.Windows.Forms.RadioButton();
            this.word2003RadioBtn = new System.Windows.Forms.RadioButton();
            this.word2007RadioBtn = new System.Windows.Forms.RadioButton();
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
            this.button1.Location = new System.Drawing.Point(273, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Form";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFill
            // 
            this.btnFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFill.BackColor = System.Drawing.Color.Transparent;
            this.btnFill.Enabled = false;
            this.btnFill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnFill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFill.Image = ((System.Drawing.Image)(resources.GetObject("btnFill.Image")));
            this.btnFill.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFill.Location = new System.Drawing.Point(273, 212);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(89, 23);
            this.btnFill.TabIndex = 2;
            this.btnFill.Text = "Fill Form";
            this.btnFill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
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
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(221, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 18);
            this.label5.TabIndex = 104;
            this.toolTip1.SetToolTip(this.label5, "Saves the document in Word 2013 format");
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
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(221, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 18);
            this.label1.TabIndex = 101;
            this.toolTip1.SetToolTip(this.label1, "Saves the document in Word 2007 format");
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 58);
            this.label2.TabIndex = 74;
            this.label2.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" +
    "ote that MS Word Viewer or MS Word is required to view the resultant document.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.word2013RadioBtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.word2010RadioBtn);
            this.groupBox1.Controls.Add(this.word2003RadioBtn);
            this.groupBox1.Controls.Add(this.word2007RadioBtn);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 159);
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
            this.ClientSize = new System.Drawing.Size(374, 251);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFill);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forms";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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

        #region Create Form fields
        private void button1_Click(object sender, System.EventArgs e)
        {
            // Create a new document.
            WordDocument document = new WordDocument();

            // Adding a new section to the document.
            IWSection section = document.AddSection();

            // Adding a new paragraph to the section.
            IWParagraph paragraph = section.AddParagraph();


            #region Document formatting
            //Set background color.
            document.Background.Gradient.Color1 = Color.FromArgb(232, 232, 232);
            document.Background.Gradient.Color2 = Color.FromArgb(255, 255, 255);
            document.Background.Type = BackgroundType.Gradient;
            document.Background.Gradient.ShadingStyle = GradientShadingStyle.Horizontal;
            document.Background.Gradient.ShadingVariant = GradientShadingVariant.ShadingDown;

            section.PageSetup.Margins.All = 72f;
            section.PageSetup.PageSize = new SizeF(612, 792);

            #endregion

            #region Title Section
            IWTable table = section.Body.AddTable();
            table.ResetCells(1, 2);

            WTableRow row = table.Rows[0];
            row.Height = 25f;

            IWParagraph cellPara = row.Cells[0].AddParagraph();
            Image img = Image.FromFile(@"..\..\..\..\..\..\..\..\..\Common\images\DocIO\image.jpg");
            IWPicture pic = cellPara.AppendPicture(img);
            pic.Height = 80;
            pic.Width = 180;

            cellPara = row.Cells[1].AddParagraph();
            row.Cells[1].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            row.Cells[1].CellFormat.BackColor = Color.FromArgb(173, 215, 255);
            IWTextRange txt = cellPara.AppendText("Job Application Form");
            cellPara.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            txt.CharacterFormat.Bold = true;
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 18f;

            row.Cells[0].Width = 200;
            row.Cells[1].Width = 300;
            //row.Cells[1].CellFormat.FitText = true;
            row.Cells[1].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Hairline;
            #endregion

            section.AddParagraph();

            #region General Information
            table = section.Body.AddTable();
            table.ResetCells(2, 1);
            row = table.Rows[0];
            row.Height = 20;
            row.Cells[0].Width = 500;
            cellPara = row.Cells[0].AddParagraph();
            row.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Thick;
            row.Cells[0].CellFormat.Borders.Color = Color.FromArgb(155, 205, 255);
            row.Cells[0].CellFormat.BackColor = Color.FromArgb(198, 227, 255);
            row.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            txt = cellPara.AppendText(" General Information");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.Bold = true;
            txt.CharacterFormat.FontSize = 11f;

            row = table.Rows[1];
            cellPara = row.Cells[0].AddParagraph();
            row.Cells[0].Width = 500;
            row.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Hairline;
            row.Cells[0].CellFormat.Borders.Color = Color.FromArgb(155, 205, 255);
            row.Cells[0].CellFormat.BackColor = Color.FromArgb(222, 239, 255);

            txt = cellPara.AppendText("\n Full Name:\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            WTextFormField txtField = cellPara.AppendTextFormField(null);
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
            txtField.TextRange.CharacterFormat.FontName = "Arial";
            txtField.TextRange.CharacterFormat.FontSize = 11f;

            txt = cellPara.AppendText("\n\n Birth Date:\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            txtField = cellPara.AppendTextFormField("BirthDayField", DateTime.Now.ToString("M/d/yyyy"));
            txtField.StringFormat = "M/d/yyyy";
            txtField.Type = TextFormFieldType.DateText;
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
            txtField.TextRange.CharacterFormat.FontName = "Arial";
            txtField.TextRange.CharacterFormat.FontSize = 11f;
            txtField.CharacterFormat.TextColor = Color.MidnightBlue;
            txtField.CharacterFormat.FontName = "Arial";
            txtField.CharacterFormat.FontSize = 11f;

            txt = cellPara.AppendText("\n\n Address:\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            txtField = cellPara.AppendTextFormField(null);
            txtField.Type = TextFormFieldType.RegularText;
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
            txtField.TextRange.CharacterFormat.FontName = "Arial";
            txtField.TextRange.CharacterFormat.FontSize = 11f;

            txt = cellPara.AppendText("\n\n Phone:\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            txtField = cellPara.AppendTextFormField(null);
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
            txtField.TextRange.CharacterFormat.FontName = "Arial";
            txtField.TextRange.CharacterFormat.FontSize = 11f;

            txt = cellPara.AppendText("\n\n Email:\t\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            txtField = cellPara.AppendTextFormField(null);
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
            txtField.TextRange.CharacterFormat.FontName = "Arial";
            txtField.TextRange.CharacterFormat.FontSize = 11f;
            cellPara.AppendText("\n");
            #endregion

            section.AddParagraph();

            #region Educational Qualification
            table = section.Body.AddTable();
            table.ResetCells(2, 1);
            row = table.Rows[0];
            row.Height = 20;
            row.Cells[0].Width = 500;
            cellPara = row.Cells[0].AddParagraph();
            row.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Thick;
            row.Cells[0].CellFormat.Borders.Color = Color.FromArgb(155, 205, 255);
            row.Cells[0].CellFormat.BackColor = Color.FromArgb(198, 227, 255);
            row.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            txt = cellPara.AppendText(" Educational Qualification");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.Bold = true;
            txt.CharacterFormat.FontSize = 11f;

            row = table.Rows[1];
            cellPara = row.Cells[0].AddParagraph();
            row.Cells[0].Width = 500;
            row.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Hairline;
            row.Cells[0].CellFormat.Borders.Color = Color.FromArgb(155, 205, 255);
            row.Cells[0].CellFormat.BackColor = Color.FromArgb(222, 239, 255);

            txt = cellPara.AppendText("\n Type:\t\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            WDropDownFormField dropField = cellPara.AppendDropDownFormField();
            dropField.DropDownItems.Add("Higher");
            dropField.DropDownItems.Add("Vocational");
            dropField.DropDownItems.Add("Universal");
            dropField.CharacterFormat.TextColor = Color.MidnightBlue;
            dropField.CharacterFormat.FontName = "Arial";
            dropField.CharacterFormat.FontSize = 11f;

            txt = cellPara.AppendText("\n\n Institution:\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            txtField = cellPara.AppendTextFormField(null);
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue;
            txtField.TextRange.CharacterFormat.FontName = "Arial";
            txtField.CharacterFormat.FontSize = 11f;

            txt = cellPara.AppendText("\n\n Programming Languages:");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 11f;
            txt = cellPara.AppendText("\n\n\t C#:\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 9f;
            dropField = cellPara.AppendDropDownFormField();
            dropField.DropDownItems.Add("Perfect");
            dropField.DropDownItems.Add("Good");
            dropField.DropDownItems.Add("Excellent");
            dropField.CharacterFormat.TextColor = Color.MidnightBlue;
            dropField.CharacterFormat.FontName = "Arial";
            dropField.CharacterFormat.FontSize = 11f;

            txt = cellPara.AppendText("\n\n\t VB:\t\t\t\t");
            txt.CharacterFormat.FontName = "Arial";
            txt.CharacterFormat.FontSize = 9f;
            dropField = cellPara.AppendDropDownFormField();
            dropField.DropDownItems.Add("Perfect");
            dropField.DropDownItems.Add("Good");
            dropField.DropDownItems.Add("Excellent");
            dropField.CharacterFormat.TextColor = Color.MidnightBlue;
            dropField.CharacterFormat.FontName = "Arial";
            dropField.CharacterFormat.FontSize = 11f;
            #endregion

            btnFill.Enabled = true;

            //Protect document
            document.ProtectionType = ProtectionType.AllowOnlyFormFields;
            document.Save("Sample.doc", FormatType.Doc);
            //Save as word 2003 format
            if (word2003RadioBtn.Checked)
            {
                //Saving the document to disk.
                document.Save("Sample.doc");

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
                document.Save("Sample.docx", FormatType.Word2007);
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
                document.Save("Sample.docx", FormatType.Word2010);
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
                document.Save("Sample.docx", FormatType.Word2013);
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

        #region Fill form fields
        private void btnFill_Click(object sender, EventArgs e)
        {
            // Create a new document.
            WordDocument document = new WordDocument("Sample.doc");
            IWSection sec = document.LastSection;
            WTextFormField textFF;
            WDropDownFormField dropFF;

            //Access the text field
            textFF = sec.Body.FormFields[0] as WTextFormField;

            //Fill value for the textfield
            textFF.TextRange.Text = "John";

            //Access the form field with feild name
            textFF = sec.Body.FormFields["BirthDayField"] as WTextFormField;
            textFF.TextRange.Text = "5.13.1980";

            textFF = sec.Body.FormFields[2] as WTextFormField;
            textFF.TextRange.Text = "221b Baker Street";

            textFF = sec.Body.FormFields[3] as WTextFormField;
            textFF.TextRange.Text = "(206)555-3412";

            textFF = sec.Body.FormFields[4] as WTextFormField;
            textFF.TextRange.Text = "John@company.com";

            dropFF = sec.Body.FormFields[5] as WDropDownFormField;

            //Set the value
            dropFF.DropDownSelectedIndex = 1;

            textFF = sec.Body.FormFields[6] as WTextFormField;
            textFF.TextRange.Text = "Michigan University";

            dropFF = sec.Body.FormFields[7] as WDropDownFormField;
            dropFF.DropDownSelectedIndex = 1;

            dropFF = sec.Body.FormFields[8] as WDropDownFormField;
            dropFF.DropDownSelectedIndex = 2;

            //Allow only to fill the form.
            document.ProtectionType = ProtectionType.AllowOnlyFormFields;

            //Save as word 2003 format
            if (word2003RadioBtn.Checked)
            {
                //Saving the document to disk.
                document.Save("Sample.doc");

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
                document.Save("Sample.docx", FormatType.Word2007);
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
                document.Save("Sample.docx", FormatType.Word2010);
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
                document.Save("Sample.docx", FormatType.Word2013);
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
    }
}