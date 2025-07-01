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
        private IContainer components;
        string[] products = { "Tools", "Grid", "Chart", "Edit", "Diagram", "XlsIO", "Grouping", "Calculate", "PDF", "HTMLUI", "DocIO" };
        string[] forms = { "Windows", "Web" };
        IWSection section1;
        IWParagraph paragraph = null;
        private GroupBox groupBox1;
        private Label label5;
        private RadioButton word2013RadioBtn;
        private Label label3;
        private Label label1;
        private Label label24;
        private RadioButton word2010RadioBtn;
        private RadioButton word2003RadioBtn;
        private RadioButton word2007RadioBtn;
        IWTextRange textRange = null;
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.button1.Location = new System.Drawing.Point(282, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
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
            this.label2.Location = new System.Drawing.Point(0, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 45);
            this.label2.TabIndex = 73;
            this.label2.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" +
    "ote that MS Word Viewer or MS Word is required to view the resultant document.";
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
            this.label3.Location = new System.Drawing.Point(107, 48);
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
            this.label24.Location = new System.Drawing.Point(107, 22);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(20, 18);
            this.label24.TabIndex = 100;
            this.toolTip1.SetToolTip(this.label24, "Saves the document in Word 97-2003 format\r\n");
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
            this.groupBox1.Location = new System.Drawing.Point(12, 162);
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
            this.ClientSize = new System.Drawing.Size(374, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Format Text";
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
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            //Random number generator.
            Random r = new Random();

            // List of FontNames.
            string[] fontNames = { "Arial", "Times New Roman", "Monotype Corsiva", " Book Antiqua ", "Bitstream Vera Sans", "Comic Sans MS", "Microsoft Sans Serif", "Batang" };

            // Create a new document.
            WordDocument document = new WordDocument();

            // Adding a new section to the document.
            IWSection section = document.AddSection();
            // Set Margin of the section
            section.PageSetup.Margins.All = 72;
            // Adding a new paragraph to the section.
            IWParagraph paragraph = section.AddParagraph();

            paragraph.AppendText("This sample demonstrates various text and paragraph formatting supported by Essential DocIO.");
            section.AddParagraph();
            section.AddParagraph();

            section = document.AddSection();
            section.BreakCode = SectionBreakCode.NoBreak;
            //Adding two columns to the section.
            section.AddColumn(250, 20);
            section.AddColumn(250, 20);

            #region Text Formatting
            //Create a TextRange
            IWTextRange text = null;

            // Writing Text with different Formatting styles.
            for (int i = 8, j = 0, k = 0; i <= 20; i++, j++, k++)
            {
                if (j >= fontNames.Length) j = 0;
                paragraph = section.AddParagraph();
                text = paragraph.AppendText("Essential DocIO " + "[" + fontNames[j] + "]");
                text.CharacterFormat.FontName = fontNames[j];
                text.CharacterFormat.UnderlineStyle = (UnderlineStyle)k;
                text.CharacterFormat.FontSize = i;
                text.CharacterFormat.TextColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            }

            // More formatting options.
            section.AddParagraph();
            paragraph.ParagraphFormat.ColumnBreakAfter = true;
            paragraph = section.AddParagraph();
            text = paragraph.AppendText("More formatting Options List...");
            text.CharacterFormat.FontName = fontNames[2];
            text.CharacterFormat.FontSize = 18;

            section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.AppendText("AllCaps \n\n").CharacterFormat.AllCaps = true;
            paragraph.AppendText("Bold \n\n").CharacterFormat.Bold = true;
            paragraph.AppendText("DoubleStrike \n\n").CharacterFormat.DoubleStrike = true;
            paragraph.AppendText("Emboss \n\n").CharacterFormat.Emboss = true;
            paragraph.AppendText("Engrave \n\n").CharacterFormat.Engrave = true;
            paragraph.AppendText("Italic \n\n").CharacterFormat.Italic = true;
            paragraph.AppendText("Shadow \n\n").CharacterFormat.Shadow = true;
            paragraph.AppendText("SmallCaps \n\n").CharacterFormat.SmallCaps = true;
            paragraph.AppendText("Strikeout \n\n").CharacterFormat.Strikeout = true;
            paragraph.AppendText("Some Text");
            paragraph.AppendText("SubScript \n\n").CharacterFormat.SubSuperScript = SubSuperScript.SubScript;
            paragraph.AppendText("Some Text");
            paragraph.AppendText("SuperScript \n\n").CharacterFormat.SubSuperScript = SubSuperScript.SuperScript;
            paragraph.AppendText("TextBackgroundColor \n\n").CharacterFormat.TextBackgroundColor = Color.LightBlue;

            #endregion

            #region Paragraph formattings

            section = document.AddSection();
            section.BreakCode = SectionBreakCode.NoBreak;
            paragraph = section.AddParagraph();
            paragraph.AppendText("Following paragraphs illustrates various paragraph formattings");

            paragraph = section.AddParagraph();
            paragraph.AppendText("We will use this paragraph to illustrate several Microsoft Word features using Essential DocIO. It will be used to illustrate Space Before, Space After, and Line Spacing. Space Before tells Microsoft Word how much space to leave before the paragraph. Space After tells Microsoft Word how much space to leave after the paragraph. Line Spacing sets the space between lines within a paragraph.It also explains about first line indentation,backcolor and paragraph border.");
            paragraph.ParagraphFormat.BeforeSpacing = 20f;
            paragraph.ParagraphFormat.AfterSpacing = 30f;
            paragraph.ParagraphFormat.BackColor = Color.LightGray;
            paragraph.ParagraphFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
            paragraph.ParagraphFormat.FirstLineIndent = 20f;
            paragraph.ParagraphFormat.LineSpacing = 20f;

            paragraph = section.AddParagraph();
            paragraph.AppendText("This is a sample paragraph. It is used to illustrate alignment. Left-justified text is aligned on the left. Right-justified text is aligned with on the right. Centered text is centered between the left and right margins. You can use Center to center your titles. Justified text is flush on both sides.");
            paragraph.ParagraphFormat.LineSpacing = 20f;
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right;
            paragraph.ParagraphFormat.LineSpacingRule = LineSpacingRule.Exactly;

            section.AddParagraph();

            //Adding a new paragraph to the section.
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.Keep = true;
            paragraph.AppendText("KEEP TOGETHER").CharacterFormat.Bold = true;
            paragraph.AppendText("This is a sample paragraph. It is used to illustrate Keep together of MsWord. You can control where Microsoft Word positions automatic page breaks (page break: The point at which one page ends and another begins. Microsoft Word inserts an 'automatic' (or soft) page break for you, or you can force a page break at a specific location by inserting a 'manual' (or hard) page break.) by setting pagination options.It keeps the lines in a paragraph together when there is page break").CharacterFormat.FontSize = 12f;
            for (int i = 0; i < 10; i++)
            {
                paragraph.AppendText("Text Body_Text Body_Text Body_Text Body_Text Body_Text Body_Text Body").CharacterFormat.FontSize = 12f;
                paragraph.ParagraphFormat.LineSpacing = 20f;
            }
            paragraph.AppendText("KEEP TOGETHER END").CharacterFormat.Bold = true;

            #endregion

            #region Bullets and Numbering
            // Adding a new section to the document.
            section = document.AddSection();
            //Set Margin of the document
            section.PageSetup.Margins.Top = 20;
            section.PageSetup.Margins.Bottom = 20;
            section.PageSetup.Margins.Left = 50;
            section.PageSetup.Margins.Right = 20;
            // Adding a new paragraph to the document.
            paragraph = section.AddParagraph();
            // Writing text to the current paragraph.
            paragraph.AppendText("This document demonstrates the Bullets and Numbering functionality available in Essential DocIO");

            //Add a new section
            section1 = document.AddSection();
            //Adding two columns to the section.
            section1.Columns.Add(new Column(document));
            section1.Columns.Add(new Column(document));
            //Set the columns to be of equal width.
            section1.MakeColumnsEqual();

            // Set section break code as NoBreak. 
            section1.BreakCode = SectionBreakCode.NoBreak;

            // Set formatting.
            ProductDetailsInBullets();

            // Set Formatting.
            ProductDetailsInNumbers();
            #endregion  Bullets and Numbering

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
        #region ProductDetailsInBullets
        private void ProductDetailsInBullets()
        {
            // Adding a new paragraph to the document.
            section1.AddParagraph();
            paragraph = section1.AddParagraph();

            // Writing text to the document with formatting.
            textRange = paragraph.AppendText("List of Syncfusion products.");
            paragraph.ListFormat.ApplyDefBulletStyle();
            textRange.CharacterFormat.FontName = "Monotype Corsiva";
            textRange.CharacterFormat.FontSize = 15;

            // Writing Product details to the document with the specified list type.
            section1.AddParagraph();
            foreach (string s in products)
            {
                section1.AddParagraph();
                paragraph = section1.AddParagraph();
                paragraph.AppendText(string.Concat("Essential ", s));
                paragraph.ListFormat.ContinueListNumbering();
                paragraph.ListFormat.ListLevelNumber = 1;

                section1.AddParagraph();
                foreach (string s1 in forms)
                {
                    if (String.Equals(s, "HTMLUI"))
                    {
                        paragraph = section1.AddParagraph();
                        paragraph.AppendText(string.Concat(s1, " Forms"));
                        paragraph.ListFormat.ContinueListNumbering();
                        paragraph.ListFormat.ListLevelNumber = 2;

                        break;
                    }
                    else
                    {
                        paragraph = section1.AddParagraph();
                        paragraph.AppendText(string.Concat(s1, " Forms"));
                        paragraph.ListFormat.ContinueListNumbering();
                        paragraph.ListFormat.ListLevelNumber = 2;


                    }
                }
            }
        }
        #endregion

        #region ProductDetailsInNumbers
        private void ProductDetailsInNumbers()
        {
            // Adding a new paragraph to the document.
            section1.AddParagraph();
            paragraph = section1.AddParagraph();

            // Writing text to the document with formatting.
            textRange = paragraph.AppendText("List of Syncfusion products.");
            paragraph.ListFormat.ApplyDefNumberedStyle();
            textRange.CharacterFormat.FontName = "Monotype Corsiva";
            textRange.CharacterFormat.FontSize = 15;

            // Writing Product details to the document with the specified list type.
            section1.AddParagraph();
            foreach (string s in products)
            {
                section1.AddParagraph();
                paragraph = section1.AddParagraph();
                paragraph.AppendText(string.Concat("Essential ", s));
                paragraph.ListFormat.ContinueListNumbering();

                paragraph.ListFormat.ListLevelNumber = 1;
                section1.AddParagraph();
                foreach (string s1 in forms)
                {
                    if (String.Equals(s, "HTMLUI"))
                    {
                        paragraph = section1.AddParagraph();
                        paragraph.AppendText(string.Concat(s1, " Forms"));
                        paragraph.ListFormat.ContinueListNumbering();

                        paragraph.ListFormat.ListLevelNumber = 2;
                        break;
                    }
                    else
                    {
                        paragraph = section1.AddParagraph();
                        paragraph.AppendText(string.Concat(s1, " Forms"));
                        paragraph.ListFormat.ContinueListNumbering();

                        paragraph.ListFormat.ListLevelNumber = 2;

                    }
                }
            }
        }
        #endregion

    }
}
