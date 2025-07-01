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
using Syncfusion.DocIO.DLS;
using System.IO;
namespace Doc_To_RTF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string path = Application.StartupPath + @"..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\";
            openFileDialog1.InitialDirectory = new DirectoryInfo(path).FullName;

        }
        private string fullPath;
        #region Convert To RTF

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.textBox1.Text != String.Empty && fullPath != string.Empty)
            {
                if (this.textBox1.Text.Contains("//")) // in case user copy-paste the path in the textbox
                {
                    fullPath = this.textBox1.Text;
                }

                if (File.Exists(fullPath))
                {
                    WordDocument doc = new WordDocument(fullPath);
                    //Export the doc to RTF and save as .rtf file
                    doc.Save("DocToRtf.rtf", FormatType.Rtf);
                    //Message box confirmation to view the created document.
                    if (MessageBox.Show("Do you want to view the RTF file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(@"DocToRtf.rtf");
                            //Exit
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }

                else
                {
                    MessageBox.Show("File doesn�t exist");
                }
            }
            else
            {
                MessageBox.Show("Browse a word document and click the button to convert as a RTF.");
            }
        }

        #endregion

        #region Browse Document
        private void button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";   
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.SafeFileName;
                fullPath = openFileDialog1.FileName;
            }

        }
        #endregion Browse Document

        private void Form1_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = "DocToRTF.doc";
            fullPath = Application.StartupPath + @"..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\DocToRTF.doc";


        }
    }
}