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
using System.Diagnostics;
using System.IO;
using Syncfusion.DocIO;
using System.Xml.Schema;

namespace HTMLToDoc_2005
{
    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            this.label4.Visible = true;
            this.panel4.Visible = false;
            this.Size = new Size(384, 650);
            this.outpuTextBox.ReadOnly = true;
            StreamReader read = new StreamReader(Application.StartupPath + @"..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\Transitional.html");
            text = read.ReadToEnd();
            this.textBox1.Text = text;
        }
        #endregion

        #region Browse HTML content
        String text;
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "HTML files (*.html)|*.html";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                StreamReader read = new StreamReader(openFileDialog1.OpenFile());
                text = read.ReadToEnd();
            }
            this.textBox1.Text = text;

            outpuTextBox.Clear();

        }
        #endregion

        #region HTML to Doc
        string errorMessage = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != string.Empty)
            {
                WordDocument document = new WordDocument();
                IWSection section = document.AddSection();
                // Set Margin of the document
                section.PageSetup.Margins.All = 72;
                IWParagraph para = section.AddParagraph();
                // This manual validation check is optional. We do this here only for instructional purpose
                bool valid = section.Body.IsValidXHTML(this.textBox1.Text, XHTMLValidationType.Transitional, out errorMessage);
                if (!valid)
                {
                    outpuTextBox.Text = "Content is not a welformatted XHTML content.\t\t\tError message:\t\t\t\t\t\t" + errorMessage;
                    this.panel4.Visible = true;
                    this.label4.Visible = false;
                    this.button3.Text = "-";
                    this.Size = new Size(384, 650);
                }
                else
                {
                    // By default, the input html will be validated for XHTML format. This will provide you understandable error messages, if the format is invalid.
                    // However, if you are sure that the input html is valid, then you can skip the validation step to improve performance. However, any error messages 
                    //you might get here will not be very useful as to where exactly in your html, the issue is.

                    document.XHTMLValidateOption = XHTMLValidationType.Transitional;
                    section.Body.InsertXHTML(this.textBox1.Text);

                    outpuTextBox.Text = "Conversion Successful";
                    this.panel4.Visible = true;
                    this.label4.Visible = false;
                    this.button3.Text = "-";
                    this.Size = new Size(384, 650);

                    #region Save and open Document
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
                    #endregion
                }
            }
            else
            {
                MessageBox.Show("Browse or type the HTML content to be converted to word document");
            }
        }
        #endregion

        #region Events

        private void button3_Click(object sender, EventArgs e)
        {
            if (label4.Visible == true)
            {
                this.panel4.Visible = true;
                this.label4.Visible = false;
                this.button3.Text = "--";
                this.Size = new Size(384, 650);
            }
            else
            {
                this.panel4.Visible = false;
                this.label4.Visible = true;
                this.button3.Text = "+";
                this.Size = new Size(384, 650);
            }
        }

        #endregion
    }
}