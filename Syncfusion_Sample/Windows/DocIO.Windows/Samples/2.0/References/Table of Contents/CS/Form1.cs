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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Syncfusion.DocIO.DLS;
using Syncfusion.DocIO;
namespace TableOfContents_2005
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();

        }
        #endregion

        #region Table Of Content
        private void button1_Click(object sender, EventArgs e)
        {
            WordDocument doc = new WordDocument();
            doc.EnsureMinimal();

            WParagraph para = doc.LastParagraph;

            para.AppendText("\t\t\t\tEssential DocIO - Table of Contents\n\n").CharacterFormat.Bold = true;
            if (!this.checkBox6.Checked) 
                para.AppendText("\t\tSelect TOC and press F9 to update the Table of Contents\t\n\n").CharacterFormat.HighlightColor = Color.Yellow;

            string title = this.textBox1.Text + "\n";
            para.AppendText(title).CharacterFormat.Bold = true;

            //Insert TOC
            TableOfContent toc = para.AppendTOC(1, 3);
            
            para.ApplyStyle(BuiltinStyle.Heading4);
            //Apply built-in paragraph formatting
            WSection section = doc.LastSection;
            // Set Margin of the document
            section.PageSetup.Margins.All = 72;
            if(radioButton1.Checked)
            {
                 #region Default Styles
            WParagraph newPara = section.AddParagraph() as WParagraph;
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendBreak(BreakType.PageBreak);
            WTextRange text = newPara.AppendText("Document with Default styles") as WTextRange;
            newPara.ApplyStyle(BuiltinStyle.Heading1);
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendText("This is the heading1 of built in style. This sample demonstrates the TOC insertion in a word document. Note that DocIO can only insert TOC field in a word document. It can not refresh or create TOC field. MS Word refreshes the TOC field after insertion. Please update the field or press F9 key to refresh the TOC.");
          
            section.AddParagraph();
            newPara = section.AddParagraph() as WParagraph;
            text = newPara.AppendText("Section1") as WTextRange;
            newPara.ApplyStyle(BuiltinStyle.Heading2);
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendText("This is the heading2 of built in style. A document can contain any number of sections. Sections are used to apply same formatting for a group of paragraphs. You can insert sections by inserting section breaks.");
           
            section.AddParagraph();
            newPara = section.AddParagraph() as WParagraph;
            text = newPara.AppendText("Paragraph1") as WTextRange;
            newPara.ApplyStyle(BuiltinStyle.Heading3);
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendText("This is the heading3 of built in style. Each section contains any number of paragraphs. A paragraph is a set of statements that gives a meaning for the text.");
           
            section.AddParagraph();
            newPara = section.AddParagraph() as WParagraph;
            text = newPara.AppendText("Paragraph2") as WTextRange;
            newPara.ApplyStyle(BuiltinStyle.Heading3);
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendText("This is the heading3 of built in style. This demonstrates the paragraphs at the same level and style as that of the previous one. A paragraph can have any number formatting. This can be attained by formatting each text range in the paragraph.");
            
            section.AddParagraph();
            section = doc.AddSection() as WSection;
            section.BreakCode = SectionBreakCode.NewPage;
            newPara = section.AddParagraph() as WParagraph;
            text = newPara.AppendText("Section2") as WTextRange;
            newPara.ApplyStyle(BuiltinStyle.Heading2);
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendText("This is the heading2 of built in style. A document can contain any number of sections. Sections are used to apply same formatting for a group of paragraphs. You can insert sections by inserting section breaks.");
           
            section.AddParagraph();
            newPara = section.AddParagraph() as WParagraph;
            text = newPara.AppendText("Paragraph1") as WTextRange;
            newPara.ApplyStyle(BuiltinStyle.Heading3);
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendText("This is the heading3 of built in style. Each section contains any number of paragraphs. A paragraph is a set of statements that gives a meaning for the text.");
           
            section.AddParagraph();
            newPara = section.AddParagraph() as WParagraph;
            text = newPara.AppendText("Paragraph2") as WTextRange;
            newPara.ApplyStyle(BuiltinStyle.Heading3);
            newPara = section.AddParagraph() as WParagraph;
            newPara.AppendText("This is the heading3 of built in style. This demonstrates the paragraphs at the same level and style as that of the previous one. A paragraph can have any number formatting. This can be attained by formatting each text range in the paragraph.");
           
            #endregion
            }
            else
         
            {
                #region Custom styles
            
            //Custom styles.
                WParagraphStyle pStyle1 = (WParagraphStyle)doc.AddParagraphStyle("MyStyle1");
                WParagraphStyle pStyle2 = (WParagraphStyle)doc.AddParagraphStyle("MyStyle2");
                WParagraphStyle pStyle3 = (WParagraphStyle)doc.AddParagraphStyle("MyStyle3");
            
                //Set the Heading Styles to false in order to define custom levels to TOC.
            toc.UseHeadingStyles = false;

            //Set the TOC level style which determines; based on which the TOC should be created.
            toc.SetTOCLevelStyle(1, "MyStyle1");
            toc.SetTOCLevelStyle(2, "MyStyle2");
            toc.SetTOCLevelStyle(3, "MyStyle3");
            section = doc.AddSection() as WSection;

            pStyle1.CharacterFormat.FontName = "Cambria";
            pStyle1.CharacterFormat.FontSize = 30f;

            para = section.AddParagraph() as WParagraph;

            WTextRange text = para.AppendText("Document with Custom Styles") as WTextRange;
            para.ApplyStyle("MyStyle1");
            para = doc.LastSection.AddParagraph() as WParagraph;
            para.AppendText("This is the heading1 of built in style. This sample demonstrates the TOC insertion in a word document. Note that DocIO can only insert TOC field in a word document. It can not refresh or create TOC field. MS Word refreshes the TOC field after insertion. Please update the field or press F9 key to refresh the TOC.");

            pStyle2.CharacterFormat.FontName = "Cambria";
            pStyle2.CharacterFormat.FontSize = 20f;

            doc.LastSection.AddParagraph();

            para = doc.LastSection.AddParagraph() as WParagraph;
            text = para.AppendText("Section1") as WTextRange;
            para.ApplyStyle("MyStyle2");
            para = doc.LastSection.AddParagraph() as WParagraph;
            para.AppendText("This is the heading2 of built in style. A document can contain any number of sections. Sections are used to apply same formatting for a group of paragraphs. You can insert sections by inserting section breaks.");

            pStyle3.CharacterFormat.FontName = "Cambria";
            pStyle3.CharacterFormat.FontSize = 14f;

            doc.LastSection.AddParagraph();

            para = doc.LastSection.AddParagraph() as WParagraph;
            text = para.AppendText("Section2") as WTextRange;
            para.ApplyStyle("MyStyle3");
            para = doc.LastSection.AddParagraph() as WParagraph;
            para.AppendText("This is the heading2 of built in style. A document can contain any number of sections. Sections are used to apply same formatting for a group of paragraphs. You can insert sections by inserting section breaks.");

#endregion
            }
            if (this.numericUpDown2.Value < this.numericUpDown1.Value)
            {
                MessageBox.Show("Not a valid heading level range. UpperHeadingLevel must be greater than LowerHeadingLevel");
            }
            else
            {
                toc.IncludePageNumbers = checkBox1.Checked;
                toc.RightAlignPageNumbers = checkBox2.Checked;
                toc.UseHyperlinks = checkBox3.Checked;
                toc.LowerHeadingLevel = Convert.ToInt32(this.numericUpDown1.Value);
                toc.UpperHeadingLevel = Convert.ToInt32(this.numericUpDown2.Value);
                //Right click text. Select Paragraph option. Set OutlineLevel. Update TOC toc see the text added in TOC.
                toc.UseOutlineLevels = this.checkBox4.Checked;
                //Select the text that should be marked as Table of contents.
                //Press ALT+SHIFT+O. A dialog box will appear with options to enter the text, select the table identifier and level.
                //Choose the table identifier and level for the test and click �Mark�. Update TOC toc see the text added in TOC.
                //Sets the Table Identifier if necessary.
                //toc.TableID = "B";              
                toc.UseTableEntryFields = this.checkBox5.Checked;
                //Updates the table of contents.
                if (this.checkBox6.Checked)
                    doc.UpdateTableOfContents();
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
        } 
        #endregion
    }
}
