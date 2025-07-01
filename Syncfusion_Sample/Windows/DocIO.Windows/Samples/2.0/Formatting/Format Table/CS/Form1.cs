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
        private ToolTip toolTip1;
        private Label label2;
        private PictureBox pictureBox1;
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
        #endregion

        #region Constructor, Main and Dispose

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
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
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
            this.button1.Location = new System.Drawing.Point(284, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 25);
            this.button1.TabIndex = 68;
            this.button1.Text = "Generate";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(0, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 58);
            this.label2.TabIndex = 72;
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
            this.ClientSize = new System.Drawing.Size(374, 252);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Format Table";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        #region Button Click
        private void button1_Click(object sender, System.EventArgs e)
        {
            // Create a new document.
            WordDocument document = new WordDocument();

            // Adding a new section to the document.
            IWSection section = document.AddSection();
            //Set Margin of the document
            section.PageSetup.Margins.All = 72;
            section.PageSetup.DifferentFirstPage = true;
            IWTextRange textRange;
            IWParagraph paragraph = section.AddParagraph();

            // --------------------------------------------
            // Table in page header 
            // --------------------------------------------


            IWParagraph hParagraph = new WParagraph(document);
            hParagraph.AppendText("Header text\r\n").CharacterFormat.FontSize = 14;

            section.HeadersFooters.FirstPageHeader.Paragraphs.Add(hParagraph);


            IWTable hTable = document.LastSection.HeadersFooters.FirstPageHeader.AddTable();

            hTable.ResetCells(2, 2);

            hTable[0, 0].AddParagraph().AppendText("1");
            hTable[0, 1].AddParagraph().AppendText("2");
            hTable[1, 0].AddParagraph().AppendText("3");
            hTable[1, 1].AddParagraph().AppendText("4");


            // --------------------------------------------
            // Tiny table
            // --------------------------------------------

            paragraph = section.AddParagraph();

            paragraph.AppendText("Tiny table\r\n").CharacterFormat.FontSize = 14;
            paragraph = section.AddParagraph();
            WTextBody textBody = section.Body;
            IWTable table = textBody.AddTable();
            table.ResetCells(2, 2);

            WTableRow row_0 = table.Rows[0];
            row_0.Cells[0].AddParagraph().AppendText("A");
            row_0.Cells[0].AddParagraph().AppendText("AA");
            row_0.Cells[0].AddParagraph().AppendText("AAA");

            WTableRow row_1 = table.Rows[1];
            row_1.Cells[1].AddParagraph().AppendText("B");
            row_1.Cells[1].AddParagraph().AppendText("BB\r\nBBB");
            row_1.Cells[1].AddParagraph().AppendText("BBB");

            textBody.AddParagraph().AppendText("Text after table...").CharacterFormat.FontSize = 14;

            // --------------------------------------------
            // Table with different formatting 
            // --------------------------------------------

            section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.AppendText("Table with different formatting\r\n").CharacterFormat.FontSize = 14;
            paragraph = section.AddParagraph();
            textBody = section.Body;
            table = textBody.AddTable();
            table.ResetCells(3, 3);

            /* ------- First Row -------- */

            WTableRow row0 = table.Rows[0];

            paragraph = (IWParagraph)row0.Cells[0].AddParagraph();
            textRange = paragraph.AppendText("1");
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Left;
            textRange.CharacterFormat.FontName = "Arial";
            textRange.CharacterFormat.Bold = true;
            textRange.CharacterFormat.FontSize = 14f;
            row0.Cells[0].CellFormat.Borders.LineWidth = 2f;
            row0.Cells[0].CellFormat.Borders.Color = Color.Magenta;

            paragraph = (IWParagraph)row0.Cells[1].AddParagraph();
            textRange = paragraph.AppendText("2");
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right;
            textRange.CharacterFormat.Emboss = true;
            textRange.CharacterFormat.FontSize = 15f;
            row0.Cells[1].CellFormat.Borders.LineWidth = 1.3f;
            row0.Cells[1].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DoubleWave;

            paragraph = (IWParagraph)row0.Cells[2].AddParagraph();
            textRange = paragraph.AppendText("3");
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Left;
            textRange.CharacterFormat.Engrave = true;
            textRange.CharacterFormat.FontSize = 15f;
            row0.Cells[2].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Emboss3D;

            /* ------- Second Row -------- */

            WTableRow row1 = table.Rows[1];

            paragraph = (IWParagraph)row1.Cells[0].AddParagraph();
            textRange = paragraph.AppendText("4");
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            textRange.CharacterFormat.SmallCaps = true;
            textRange.CharacterFormat.FontName = "Comic Sans MS";
            textRange.CharacterFormat.FontSize = 16;
            row1.Cells[0].CellFormat.Borders.LineWidth = 2f;
            row1.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DashDotStroker;

            paragraph = (IWParagraph)row1.Cells[1].AddParagraph();
            textRange = paragraph.AppendText("5");
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            textRange.CharacterFormat.FontName = "Times New Roman";
            textRange.CharacterFormat.Shadow = true;
            textRange.CharacterFormat.TextBackgroundColor = Color.Orange;
            textRange.CharacterFormat.FontSize = 15f;
            row1.Cells[1].CellFormat.Borders.LineWidth = 2f;
            row1.Cells[1].CellFormat.Borders.Color = Color.Brown;

            paragraph = (IWParagraph)row1.Cells[2].AddParagraph();
            textRange = paragraph.AppendText("6");
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            textRange.CharacterFormat.Bold = true;
            textRange.CharacterFormat.FontSize = 14f;
            row1.Cells[2].CellFormat.BackColor = Color.FromArgb(51, 51, 101);
            row1.Cells[2].CellFormat.VerticalAlignment = VerticalAlignment.Middle;

            /* ------- Third Row -------- */

            WTableRow row2 = table.Rows[2];

            paragraph = (IWParagraph)row2.Cells[0].AddParagraph();
            textRange = paragraph.AppendText("7");
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right;
            textRange.CharacterFormat.FontSize = 13f;
            row2.Cells[0].CellFormat.Borders.LineWidth = 1.5f;
            row2.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DashLargeGap;

            paragraph = (IWParagraph)row2.Cells[1].AddParagraph();
            textRange = paragraph.AppendText("8");
            textRange.CharacterFormat.TextColor = Color.Blue;
            textRange.CharacterFormat.FontSize = 16f;
            row2.Cells[1].CellFormat.Borders.LineWidth = 3f;
            row2.Cells[1].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Wave;

            paragraph = (IWParagraph)row2.Cells[2].AddParagraph();
            textRange = paragraph.AppendText("9");
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right;
            row2.Cells[2].CellFormat.Borders.LineWidth = 2f;
            row2.Cells[2].CellFormat.Borders.Color = Color.Cyan;
            row2.Cells[2].CellFormat.Borders.Shadow = true;
            row2.Cells[2].CellFormat.Borders.Space = 20;

            // --------------------------------------------
            // Table Cell Merging.
            // --------------------------------------------

            section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.AppendText("Table Cell Merging...").CharacterFormat.FontSize = 14;
            section.AddParagraph();
            paragraph = section.AddParagraph();
            textBody = section.Body;

            // Adding a new Table to the textbody.
            table = textBody.AddTable();

            RowFormat format = new RowFormat();
            format.Paddings.All = 5;
            format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Dot;
            format.Borders.LineWidth = 2;

            // Inserting rows to the table.
            table.ResetCells(6, 6, format, 80);

            // Table formatting with cell merging.
            table.Rows[0].Cells[0].CellFormat.HorizontalMerge = CellMerge.Start;
            table.Rows[0].Cells[1].CellFormat.HorizontalMerge = CellMerge.Continue;
            table.Rows[0].Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            table.Rows[0].Cells[0].CellFormat.BackColor = Color.FromArgb(218, 230, 246);
            IWParagraph par = table.Rows[0].Cells[0].AddParagraph();
            par.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            par.AppendText("Horizontal Merge").CharacterFormat.Bold = true;


            table.Rows[2].Cells[3].CellFormat.VerticalMerge = CellMerge.Start;
            table.Rows[3].Cells[3].CellFormat.VerticalMerge = CellMerge.Continue;

            table.Rows[2].Cells[3].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            par = table.Rows[2].Cells[3].AddParagraph();
            table.Rows[2].Cells[3].CellFormat.BackColor = Color.FromArgb(252, 172, 85);
            par.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            par.AppendText("Vertical Merge").CharacterFormat.Bold = true;

            #region Table Cell Spacing.
            // --------------------------------------------
            // Table Cell Spacing.
            // --------------------------------------------

            section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.AppendText("Table Cell spacing...").CharacterFormat.FontSize = 14;

            section.AddParagraph();
            paragraph = section.AddParagraph();
            textBody = section.Body;

            // Adding a new Table to the textbody.
            table = textBody.AddTable();

            format = new RowFormat();

            format.CellSpacing = 5;
            format.Paddings.All = 5;
            format.CellSpacing = 2.5f;
            format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DotDash;
            format.IsBreakAcrossPages = true;
            table.ResetCells(25, 5, format, 100);
            IWTextRange text;
            table.Rows[0].IsHeader = true;

            for (int i = 0; i < table.Rows[0].Cells.Count; i++)
            {
                paragraph = table[0, i].AddParagraph() as WParagraph;
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                text = paragraph.AppendText(string.Format("Header {0}", i + 1));
                text.CharacterFormat.Font = new Font("Bitstream Vera Serif", 10);
                text.CharacterFormat.Bold = true;
                text.CharacterFormat.TextColor = Color.FromArgb(0, 21, 84);
                table[0, i].CellFormat.BackColor = Color.FromArgb(203, 211, 226);
            }

            for (int i = 1; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    paragraph = table[i, j].AddParagraph() as WParagraph;
                    paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

                    text = paragraph.AppendText(string.Format("Cell {0} , {1}", i, j + 1));
                    text.CharacterFormat.TextColor = Color.FromArgb(242, 151, 50);
                    text.CharacterFormat.Bold = true;
                    if (i % 2 != 1)
                        table[i, j].CellFormat.BackColor = Color.FromArgb(231, 235, 245);
                    else
                        table[i, j].CellFormat.BackColor = Color.FromArgb(246, 249, 255);

                }

            }
            #endregion Table Cell Spacing.

            #region Nested Table
            // --------------------------------------------
            // Nested Table.
            // --------------------------------------------

            section.AddParagraph();
            paragraph = section.AddParagraph();
            paragraph.ParagraphFormat.PageBreakBefore = true;
            paragraph.AppendText("Nested Table...").CharacterFormat.FontSize = 14;

            section.AddParagraph();
            paragraph = section.AddParagraph();
            textBody = section.Body;

            // Adding a new Table to the textbody.
            table = textBody.AddTable();

            format = new RowFormat();
            format.Paddings.All = 5;
            format.CellSpacing = 2.5f;
            format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DotDash;
            table.ResetCells(5, 3, format, 100);


            for (int i = 0; i < table.Rows[0].Cells.Count; i++)
            {
                paragraph = table[0, i].AddParagraph() as WParagraph;
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                text = paragraph.AppendText(string.Format("Header {0}", i + 1));
                text.CharacterFormat.Font = new Font("Bitstream Vera Serif", 10);
                text.CharacterFormat.Bold = true;
                text.CharacterFormat.TextColor = Color.FromArgb(0, 21, 84);
                table[0, i].CellFormat.BackColor = Color.FromArgb(242, 151, 50);
            }
            table[0, 2].Width = 200;
            for (int i = 1; i < table.Rows.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    paragraph = table[i, j].AddParagraph() as WParagraph;
                    paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

                    if ((i == 2) && (j == 2))
                    {
                        text = paragraph.AppendText("Nested Table");
                    }

                    else
                    {
                        text = paragraph.AppendText(string.Format("Cell {0} , {1}", i, j + 1));
                    }

                    if ((j == 2))
                        table[i, j].Width = 200;

                    text.CharacterFormat.TextColor = Color.FromArgb(242, 151, 50);
                    text.CharacterFormat.Bold = true;

                }

            }

            // Adding a nested Table.
            IWTable nestTable = table[2, 2].AddTable();

            format = new RowFormat();

            format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DotDash;
            format.HorizontalAlignment = RowAlignment.Center;
            nestTable.ResetCells(3, 3, format, 50);

            for (int i = 0; i < nestTable.Rows.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    paragraph = nestTable[i, j].AddParagraph() as WParagraph;
                    paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

                    nestTable[i, j].CellFormat.BackColor = Color.FromArgb(231, 235, 245);
                    text = paragraph.AppendText(string.Format("Cell {0} , {1}", i, j + 1));
                    text.CharacterFormat.TextColor = Color.Black;
                    text.CharacterFormat.Bold = true;
                }
            }
            #endregion Nested Table

            #region Table with Images
            string dataPath = Application.StartupPath + @"\..\..\..\..\..\..\..\..\..\Common\images\DocIO\";

            //Add a new section to the document.
            section = document.AddSection();
            //Add paragraph to the section.
            paragraph = section.AddParagraph();
            //Writing text.
            textRange = paragraph.AppendText("Table with Images");
            textRange.CharacterFormat.FontSize = 13f;
            textRange.CharacterFormat.TextColor = Color.DarkBlue;
            textRange.CharacterFormat.Bold = true;

            //Add paragraph to the section.
            section.AddParagraph();
            paragraph = section.AddParagraph();

            text = null;

            //Adding a new Table to the paragraph.
            table = section.Body.AddTable();
            table.ResetCells(1, 3);

            //Adding rows to the table.
            WTableRow row = table.Rows[0];
            //Set heading row height
            row.Height = 25f;
            //set heading values to the Table.
            for (int i = 0; i < 3; i++)
            {
                //Add paragraph for writing Text to the cells.
                paragraph = (IWParagraph)row.Cells[i].AddParagraph();
                //Set Horizontal Alignment as Center.
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
                //Writing Row Heading
                switch (i)
                {
                    case 0: text = paragraph.AppendText("SNO");
                        row.Cells[i].Width = 50f; break;
                    case 1: text = paragraph.AppendText("Product Name"); break;
                    case 2: text = paragraph.AppendText("Product Image"); row.Cells[i].Width = 200f; break;
                }
                //Set row Heading formatting
                text.CharacterFormat.Bold = true;
                text.CharacterFormat.FontName = "Cambria";
                text.CharacterFormat.FontSize = 11f;
                text.CharacterFormat.TextColor = Color.White;

                //Set row cells formatting
                row.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                row.Cells[i].CellFormat.BackColor = Color.FromArgb(157, 161, 190);

                row.Cells[i].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
            }

            int sno = 1;
            //Writing Sno, Product name and Product Images to the Table.

            row1 = table.AddRow(false);

            //Writing SNO to the table with formatting text.
            paragraph = (IWParagraph)row1.Cells[0].AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            text = paragraph.AppendText(sno.ToString());
            text.CharacterFormat.Bold = true;
            text.CharacterFormat.FontSize = 10f;
            row1.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            row1.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
            row1.Cells[0].CellFormat.BackColor = Color.FromArgb(217, 223, 239);
            //Writing Product Name to the table with Formatting.
            paragraph = (IWParagraph)row1.Cells[1].AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            text = paragraph.AppendText("Essential DocIO");
            text.CharacterFormat.Bold = true;
            text.CharacterFormat.FontSize = 10f;
            text.CharacterFormat.TextColor = Color.FromArgb(50, 65, 124);
            row1.Cells[1].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            row1.Cells[1].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
            row1.Cells[1].CellFormat.BackColor = Color.FromArgb(217, 223, 239);

            //Writing Product Images to the Table.
            paragraph = (IWParagraph)row1.Cells[2].AddParagraph();
            paragraph.AppendPicture(Image.FromFile(dataPath + "DocIO.gif"));
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            row1.Cells[2].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            row1.Cells[2].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
            row1.Cells[2].CellFormat.BackColor = Color.FromArgb(217, 223, 239);
            sno++;
            row1 = table.AddRow(false);

            //Writing SNO to the table with formatting text.
            paragraph = (IWParagraph)row1.Cells[0].AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            text = paragraph.AppendText(sno.ToString());
            text.CharacterFormat.Bold = true;
            text.CharacterFormat.FontSize = 10f;
            row1.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            row1.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
            row1.Cells[0].CellFormat.BackColor = Color.FromArgb(217, 223, 239);
            //Writing Product Name to the table with Formatting.
            paragraph = (IWParagraph)row1.Cells[1].AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            text = paragraph.AppendText("Essential PDF");
            text.CharacterFormat.Bold = true;
            text.CharacterFormat.FontSize = 10f;
            text.CharacterFormat.TextColor = Color.FromArgb(50, 65, 124);
            row1.Cells[1].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            row1.Cells[1].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
            row1.Cells[1].CellFormat.BackColor = Color.FromArgb(217, 223, 239);

            //Writing Product Images to the Table.
            paragraph = (IWParagraph)row1.Cells[2].AddParagraph();
            paragraph.AppendPicture(Image.FromFile(dataPath + "PDF.gif"));
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            row1.Cells[2].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            row1.Cells[2].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
            row1.Cells[2].CellFormat.BackColor = Color.FromArgb(217, 223, 239);
            sno++;
            row1 = table.AddRow(false);

            //Writing SNO to the table with formatting text.
            paragraph = (IWParagraph)row1.Cells[0].AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            text = paragraph.AppendText(sno.ToString());
            text.CharacterFormat.Bold = true;
            text.CharacterFormat.FontSize = 10f;
            row1.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            row1.Cells[0].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
            row1.Cells[0].CellFormat.BackColor = Color.FromArgb(217, 223, 239);
            //Writing Product Name to the table with Formatting.
            paragraph = (IWParagraph)row1.Cells[1].AddParagraph();
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            text = paragraph.AppendText("Essential XlsIO");
            text.CharacterFormat.Bold = true;
            text.CharacterFormat.FontSize = 10f;
            text.CharacterFormat.TextColor = Color.FromArgb(50, 65, 124);
            row1.Cells[1].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            row1.Cells[1].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
            row1.Cells[1].CellFormat.BackColor = Color.FromArgb(217, 223, 239);

            //Writing Product Images to the Table.
            paragraph = (IWParagraph)row1.Cells[2].AddParagraph();
            paragraph.AppendPicture(Image.FromFile(dataPath + "XlsIO.gif"));
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;
            row1.Cells[2].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
            row1.Cells[2].CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single;
            row1.Cells[2].CellFormat.BackColor = Color.FromArgb(217, 223, 239);
            sno++;
            #endregion Table with Images
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
