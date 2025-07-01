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
using System.Collections;
using System.Data.OleDb;
using System.Diagnostics;

namespace NestedMailMerge_2005
{
    public partial class Form1 : Form
    {
        # region Private Members
        string fileName, dataBase = null;
        # endregion

        # region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
           fileName = System.Environment.CurrentDirectory + @"\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\";
           dataBase = System.Environment.CurrentDirectory + @"\..\..\..\..\..\..\..\..\..\Common\Data\Northwind.mdb";
        }
        # endregion

        # region Events
        /// <summary>
        /// Creates document
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //Executes mailmerge and creates document in report format
            # region Report Format
            if (this.radioButtonReport.Checked)
            {
                //Open existing template
                WordDocument doc = new WordDocument(fileName + "Template_Report.doc", FormatType.Doc);

                // Get Data from the Database.
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataBase);
                conn.Open();

                // Arraylist contains the list of commands
                ArrayList commands = new ArrayList();

                // DictionaryEntry contain "Source table" (KEY) and "Command" (VALUE)
                DictionaryEntry entry = new DictionaryEntry("Employees", "Select TOP 10 * from Employees");
                commands.Add(entry);

                // To retrive customer details
                entry = new DictionaryEntry("Customers", "SELECT DISTINCT TOP 10 Employees.EmployeeID, Customers.CustomerID,Customers.CompanyName, Customers.ContactName, Customers.Address, Customers.City, Customers.Country FROM ((Orders INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID) INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID) WHERE Employees.EmployeeID = %Employees.EmployeeID%");
                commands.Add(entry);

                // To retrieve order details
                entry = new DictionaryEntry("Orders", "SELECT DISTINCT TOP 10 OrderID, OrderDate, RequiredDate, ShippedDate FROM Orders WHERE Orders.CustomerID = '%Customers.CustomerID%' AND Orders.EmployeeID = %Employees.EmployeeID%");
                commands.Add(entry);

                //Execute Mail merge
                doc.MailMerge.ExecuteNestedGroup(conn, commands);

                # region Save the document
                //Save as word 2003 format
                if (word2003RadioBtn.Checked)
                {
                    //Saving the document to disk.
                    doc.Save("Sample.doc");

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
                    doc.Save("Sample.docx", FormatType.Word2007);
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
                    doc.Save("Sample.docx", FormatType.Word2010);
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

                # endregion
            }
            # endregion

            //Executes mailmerge and creates document in letter format
            # region Letter Format
            else if (this.radioButtonLetter.Checked)
            {
                //Open existing template
                WordDocument doc = new WordDocument(fileName + "Template_Letter.doc", FormatType.Doc);

                // Get Data from the Database.
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dataBase);
                conn.Open();

                // Arraylist contains the list of commands
                ArrayList commands = new ArrayList();

                // DictionaryEntry contain "Source table" (KEY) and "Command" (VALUE)
                DictionaryEntry entry = new DictionaryEntry("Employees", "Select TOP 3 * from Employees");
                commands.Add(entry);

                // To retrive customer details
                entry = new DictionaryEntry("Customers", "SELECT DISTINCT TOP 2 Employees.EmployeeID, Customers.CustomerID,Customers.CompanyName, Customers.ContactName, Customers.Address, Customers.City, Customers.Country FROM ((Orders INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID) INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID) WHERE Employees.EmployeeID = %Employees.EmployeeID%");
                commands.Add(entry);

                //To retrieve order details
                entry = new DictionaryEntry("Orders", "SELECT DISTINCT TOP 2 OrderID, OrderDate, RequiredDate, ShippedDate FROM Orders WHERE Orders.CustomerID = '%Customers.CustomerID%' AND Orders.EmployeeID = %Employees.EmployeeID%");
                commands.Add(entry);

                //Execute Mail merge
                doc.MailMerge.ExecuteNestedGroup(conn, commands);

                # region Save the document
                //Save as word 2003 format
                if (word2003RadioBtn.Checked)
                {
                    //Saving the document to disk.
                    doc.Save("Sample.doc");

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
                    doc.Save("Sample.docx", FormatType.Word2007);
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
                    doc.Save("Sample.docx", FormatType.Word2010);
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

                # endregion
            }
            # endregion
        }
        /// <summary>
        /// The source template document.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void templateBtn_Click(object sender, EventArgs e)
        {
            if (this.radioButtonReport.Checked)
                Process.Start(fileName + "Template_Report.doc");
            else if (this.radioButtonLetter.Checked)
                Process.Start(fileName + "Template_Letter.doc");
        }
        # endregion
    }
}