#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Any infringement will be prosecuted under
'  applicable laws. 
'
#End Region
Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.DocIO.DLS
Imports Syncfusion.DocIO
Imports System.Collections
Imports System.Data.OleDb
Imports System.Diagnostics

Namespace NestedMailMerge_2005
	Public Partial Class Form1
		Inherits Form
		#Region "Private Members"
		Private fileName As String, dataBase As String = Nothing
		#End Region

		#Region "Constructor"
		''' <summary>
		''' Constructor
		''' </summary>
		Public Sub New()
			InitializeComponent()
            fileName = System.Environment.CurrentDirectory + "\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"
            dataBase = System.Environment.CurrentDirectory + "\..\..\..\..\..\..\..\..\..\Common\Data\Northwind.mdb"
		End Sub
		#End Region

		#Region "Events"
		''' <summary>
		''' Creates document
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles buttonCreate.Click
			'Executes mailmerge and creates document in report format
            '			#Region "Report Format"
            If Me.radioButtonReport.Checked Then
                'Open existing template
                Dim doc As WordDocument = New WordDocument(fileName & "Template_Report.doc", FormatType.Doc)

                ' Get Data from the Database.
                Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dataBase)
                conn.Open()

                ' Arraylist contains the list of commands
                Dim commands As ArrayList = New ArrayList()

                ' DictionaryEntry contain "Source table" (KEY) and "Command" (VALUE)
                Dim entry As DictionaryEntry = New DictionaryEntry("Employees", "Select TOP 10 * from Employees")
                commands.Add(entry)

                ' To retrive customer details
                entry = New DictionaryEntry("Customers", "SELECT DISTINCT TOP 10 Employees.EmployeeID, Customers.CustomerID,Customers.CompanyName, Customers.ContactName, Customers.Address, Customers.City, Customers.Country FROM ((Orders INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID) INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID) WHERE Employees.EmployeeID = %Employees.EmployeeID%")
                commands.Add(entry)

                ' To retrieve order details
                entry = New DictionaryEntry("Orders", "SELECT DISTINCT TOP 10 OrderID, OrderDate, RequiredDate, ShippedDate FROM Orders WHERE Orders.CustomerID = '%Customers.CustomerID%' AND Orders.EmployeeID = %Employees.EmployeeID%")
                commands.Add(entry)

                'Execute Mail merge
                doc.MailMerge.ExecuteNestedGroup(conn, commands)

                ' #Region "Save the document"
                'Save as word 2003  format
                If word2003RadioBtn.Checked Then
                    'Saving the document to disk.
                    doc.Save("Sample.doc")

                    'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                        System.Diagnostics.Process.Start("Sample.doc")
                        'Exit
                        Me.Close()
                    End If
                    'Save as word 2007 format
                ElseIf word2007RadioBtn.Checked Then

                    'Saving the document as .docx
                    doc.Save("Sample.docx", FormatType.Word2007)
                    'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Try
                            'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                            System.Diagnostics.Process.Start("Sample.docx")
                            'Exit
                            Me.Close()
                        Catch ex As Win32Exception
                            MessageBox.Show("Word 2007 is not installed in this system")
                            Console.WriteLine(ex.ToString())
                        End Try
                    End If
                    'Save as word 2010 format
                ElseIf word2010RadioBtn.Checked Then

                    'Saving the document as .docx
                    doc.Save("Sample.docx", FormatType.Word2010)
                    'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Try
                            'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                            System.Diagnostics.Process.Start("Sample.docx")
                            'Exit
                            Me.Close()
                        Catch ex As Win32Exception
                            MessageBox.Show("Word 2007 is not installed in this system")
                            Console.WriteLine(ex.ToString())
                        End Try
                    End If
                    'Save as word 2013 format
                ElseIf word2013RadioBtn.Checked Then

                    'Saving the document as .docx
                    doc.Save("Sample.docx", FormatType.Word2013)
                    'Message box confirmation to view the created document.
                    If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Try
                            'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                            System.Diagnostics.Process.Start("Sample.docx")
                            'Exit
                            Me.Close()
                        Catch ex As Win32Exception
                            MessageBox.Show("Word 2013 is not installed in this system")
                            Console.WriteLine(ex.ToString())
                        End Try
                    End If
                Else
                    ' Exit
                    Me.Close()
                End If

                '		#End Region
                '	#End Region

                'Executes mailmerge and creates document in letter format
                '			#Region "Letter Format"
            ElseIf Me.radioButtonLetter.Checked Then
            'Open existing template
            Dim doc As WordDocument = New WordDocument(fileName & "Template_Letter.doc", FormatType.Doc)

            ' Get Data from the Database.
            Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dataBase)
            conn.Open()

            ' Arraylist contains the list of commands
            Dim commands As ArrayList = New ArrayList()

            ' DictionaryEntry contain "Source table" (KEY) and "Command" (VALUE)
            Dim entry As DictionaryEntry = New DictionaryEntry("Employees", "Select TOP 3 * from Employees")
            commands.Add(entry)

            ' To retrive customer details
            entry = New DictionaryEntry("Customers", "SELECT DISTINCT TOP 2 Employees.EmployeeID, Customers.CustomerID,Customers.CompanyName, Customers.ContactName, Customers.Address, Customers.City, Customers.Country FROM ((Orders INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID) INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID) WHERE Employees.EmployeeID = %Employees.EmployeeID%")
            commands.Add(entry)

            'To retrieve order details
            entry = New DictionaryEntry("Orders", "SELECT DISTINCT TOP 2 OrderID, OrderDate, RequiredDate, ShippedDate FROM Orders WHERE Orders.CustomerID = '%Customers.CustomerID%' AND Orders.EmployeeID = %Employees.EmployeeID%")
            commands.Add(entry)

            'Execute Mail merge
            doc.MailMerge.ExecuteNestedGroup(conn, commands)

            '				#Region "Save the document"
            'Save as word 2003  format
            If word2003RadioBtn.Checked Then
                'Saving the document to disk.
                doc.Save("Sample.doc")

                'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                    System.Diagnostics.Process.Start("Sample.doc")
                    'Exit
                    Me.Close()
                End If
                'Save as word 2007 format
            ElseIf word2007RadioBtn.Checked Then

                'Saving the document as .docx
                doc.Save("Sample.docx", FormatType.Word2007)
                'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Try
                        'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                        System.Diagnostics.Process.Start("Sample.docx")
                        'Exit
                        Me.Close()
                    Catch ex As Win32Exception
                        MessageBox.Show("Word 2007 is not installed in this system")
                        Console.WriteLine(ex.ToString())
                    End Try
                End If
                'Save as word 2010 format
            ElseIf word2010RadioBtn.Checked Then

                'Saving the document as .docx
                doc.Save("Sample.docx", FormatType.Word2010)
                'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Try
                        'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                        System.Diagnostics.Process.Start("Sample.docx")
                        'Exit
                        Me.Close()
                    Catch ex As Win32Exception
                        MessageBox.Show("Word 2007 is not installed in this system")
                        Console.WriteLine(ex.ToString())
                    End Try
                    End If
                    'Save as word 2013 format
                ElseIf word2013RadioBtn.Checked Then

                    'Saving the document as .docx
                    doc.Save("Sample.docx", FormatType.Word2013)
                    'Message box confirmation to view the created document.
                    If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                        Try
                            'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                            System.Diagnostics.Process.Start("Sample.docx")
                            'Exit
                            Me.Close()
                        Catch ex As Win32Exception
                            MessageBox.Show("Word 2013 is not installed in this system")
                            Console.WriteLine(ex.ToString())
                        End Try
                    End If
            Else
                ' Exit
                Me.Close()
                End If
            End If

            ' #End Region
        End Sub
        ''' <summary>
        ''' The source template document.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub templateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles templateBtn.Click
            If Me.radioButtonReport.Checked Then
                Process.Start(fileName & "Template_Report.doc")
            ElseIf Me.radioButtonLetter.Checked Then
                Process.Start(fileName & "Template_Letter.doc")
            End If
        End Sub
		#End Region

        
    End Class
End Namespace