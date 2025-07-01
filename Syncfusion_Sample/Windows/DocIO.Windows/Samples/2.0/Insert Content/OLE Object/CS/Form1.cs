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
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS ;
namespace InsertOLE_Object
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string TemplatePath =  @"..\..\..\..\..\..\..\..\..\Common\Data\DocIO\";
            
            WordDocument dest = new WordDocument();
            dest.EnsureMinimal();
            //Set Margin of the section
            dest.Sections[0].PageSetup.Margins.All = 72;
            WordDocument oleSource;
            if (word2003RadioBtn.Checked)
            {
                oleSource = new WordDocument(TemplatePath + "OleTemplate.doc");
            }
            else
            {
                oleSource = new WordDocument(TemplatePath + "OleTemplate.docx");
            }
            WOleObject oleObject = null;
            // Get OLE object from source document
            for (int i = 0; i < oleSource.LastSection.Paragraphs[4].Items.Count; i++)
            {
                if (oleSource.LastSection.Paragraphs[4].Items[i] is WOleObject)
                {
                    oleObject = oleSource.LastSection.Paragraphs[4].Items[i] as WOleObject;
                    break;
                }
            }
            WPicture pic = oleObject.OlePicture.Clone() as WPicture;
            dest.LastParagraph.AppendText("OLE Object Demo");
            dest.LastParagraph.ApplyStyle(BuiltinStyle.Heading1);
            dest.LastParagraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center;

            dest.Sections[0].AddParagraph();
            dest.LastParagraph.AppendText("MS Excel Object Inserted");
            dest.LastParagraph.ApplyStyle(BuiltinStyle.Heading2);

            dest.Sections[0].AddParagraph();
            // AppendOLE object to the destination document
            oleObject = dest.LastParagraph.AppendOleObject(oleObject.Container, pic, OleLinkType.Embed);
            oleObject.DisplayAsIcon = checkBoxChoose.Checked;
            //Save as word 2003 format
            if (word2003RadioBtn.Checked)
            {
                //Saving the document to disk.
                dest.Save("Sample.doc");

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
                dest.Save("Sample.docx", FormatType.Word2007);
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
                dest.Save("Sample.docx", FormatType.Word2010);
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
                dest.Save("Sample.docx", FormatType.Word2013);
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
}