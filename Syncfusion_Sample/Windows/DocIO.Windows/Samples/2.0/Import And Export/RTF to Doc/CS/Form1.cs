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
using System.ComponentModel;
using System.Windows.Forms;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;

namespace RTFToDoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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
            this.textBox1.Text = "RTFToDoc.rtf";
            this.textBox1.Tag = Application.StartupPath + @"..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\RTFToDoc.rtf";

        }

        private void btnRTFToDoc_Click(object sender, EventArgs e)
        {
            WordDocument document = new WordDocument();
            document.Open((string)this.textBox1.Tag, FormatType.Rtf);            

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

            else
            {
                // Exit
                this.Close();
            }

        }
        
    }
}
