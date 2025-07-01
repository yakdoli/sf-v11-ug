#region Copyright Syncfusion Inc. 2001 - 2013
// Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
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
namespace EncryptDocument_2005
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Encrypt the selected Word document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.txtEncryptSource.Text != null && this.txtEncryptSource.Text != "")
            {
                WordDocument document = new WordDocument(this.txtEncryptSource.Text);

                // Getting last section of the document.
                IWSection section = document.LastSection;

                // Adding a paragraph to the section.
                IWParagraph paragraph = section.AddParagraph();

                // Writing text
                IWTextRange text = paragraph.AppendText("This document was encrypted with password");
                text.CharacterFormat.FontSize = 16f;
                text.CharacterFormat.FontName = "Bitstream Vera Serif";

                // Encrypt the document by giving password
                document.EncryptDocument(txtEnOpen.Text);

                # region Save Document
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
                # endregion
            }
            else
            {
                MessageBox.Show("Please browse the document to encrypt");
            }
        }
        /// <summary>
        /// Gets the source document to encrypt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\";
            openFileDialog1.Title = "Choose a Word document to Encrypt";

            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txtEncryptSource.Text = openFileDialog1.FileName;               
            }
           
        }
        /// <summary>
        /// Gets the source document to decrypt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecryptSource_Click(object sender, EventArgs e)
        {
            openFileDialog2.InitialDirectory = Application.StartupPath + @"..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\";
            openFileDialog2.Title = "Choose a Word document to Decrypt";

            openFileDialog2.RestoreDirectory = true;
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                this.txtDecryptSource.Text = openFileDialog2.FileName;
                
            }
          
        }
        /// <summary>
        /// Decrypt the selected Word document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtDecryptSource.Text != null && this.txtDecryptSource.Text != "")
                {
                    WordDocument document = new WordDocument(this.txtDecryptSource.Text, txtDeOpen.Text);

                    // Getting last section of the document.
                    IWSection section = document.LastSection;

                    // Adding a paragraph to the section.
                    IWParagraph paragraph = section.AddParagraph();

                    // Writing text
                    IWTextRange text = paragraph.AppendText("\nDemo For Document Decryption with Essential DocIO");
                    text.CharacterFormat.FontSize = 16f;
                    text.CharacterFormat.FontName = "Bitstream Vera Serif";

                    text = paragraph.AppendText("\nThis document is Decrypted");
                    text.CharacterFormat.FontSize = 16f;
                    text.CharacterFormat.FontName = "Bitstream Vera Serif";

                    # region Save Document
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
                    # endregion
                }
                else
                {
                    MessageBox.Show("Please browse the document to decrypt");
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message,"Error Message");   
            }
        }
    
    }
    
}