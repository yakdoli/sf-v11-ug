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
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Diagnostics
Imports System.IO

Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS
Imports System.Data.SqlServerCe

Namespace MailmergeWithGroup
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		Private label2 As System.Windows.Forms.Label

        Private dataPath As String = Nothing
        Private doc As WordDocument = Nothing
	
		Private WithEvents listBoxCustomer As System.Windows.Forms.ListBox
		Private groupBox1 As GroupBox
        Private WithEvents button1 As Button
        Private label1 As Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents templateBtn As System.Windows.Forms.Button
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents Label4 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2007RadioBtn As System.Windows.Forms.RadioButton
        Private components As System.ComponentModel.IContainer

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Not components Is Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.label2 = New System.Windows.Forms.Label()
            Me.listBoxCustomer = New System.Windows.Forms.ListBox()
            Me.button1 = New System.Windows.Forms.Button()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            Me.label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2003RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2007RadioBtn = New System.Windows.Forms.RadioButton()
            Me.templateBtn = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.groupBox1.SuspendLayout()
            Me.GroupBox2.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'label2
            '
            Me.label2.Location = New System.Drawing.Point(6, 16)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(105, 26)
            Me.label2.TabIndex = 1
            Me.label2.Text = "Select Customer ID"
            '
            'listBoxCustomer
            '
            Me.listBoxCustomer.Location = New System.Drawing.Point(11, 34)
            Me.listBoxCustomer.Name = "listBoxCustomer"
            Me.listBoxCustomer.Size = New System.Drawing.Size(87, 95)
            Me.listBoxCustomer.TabIndex = 2
            '
            'button1
            '
            Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button1.BackColor = System.Drawing.Color.Transparent
            Me.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
            Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.button1.Location = New System.Drawing.Point(251, 104)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(99, 25)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Create Invoice"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.GroupBox2)
            Me.groupBox1.Controls.Add(Me.templateBtn)
            Me.groupBox1.Controls.Add(Me.listBoxCustomer)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.button1)
            Me.groupBox1.Location = New System.Drawing.Point(3, 155)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(366, 137)
            Me.groupBox1.TabIndex = 4
            Me.groupBox1.TabStop = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.label5)
            Me.GroupBox2.Controls.Add(Me.word2013RadioBtn)
            Me.GroupBox2.Controls.Add(Me.label3)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.label24)
            Me.GroupBox2.Controls.Add(Me.word2010RadioBtn)
            Me.GroupBox2.Controls.Add(Me.word2003RadioBtn)
            Me.GroupBox2.Controls.Add(Me.word2007RadioBtn)
            Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(109, 31)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(251, 70)
            Me.GroupBox2.TabIndex = 101
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Save As"
            '
            'label5
            '
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.Location = New System.Drawing.Point(221, 48)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(20, 18)
            Me.label5.TabIndex = 104
            Me.ToolTip1.SetToolTip(Me.label5, "Saves the document in Word 2013 format")
            '
            'word2013RadioBtn
            '
            Me.word2013RadioBtn.AutoSize = True
            Me.word2013RadioBtn.Checked = True
            Me.word2013RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.word2013RadioBtn.Location = New System.Drawing.Point(139, 46)
            Me.word2013RadioBtn.Name = "word2013RadioBtn"
            Me.word2013RadioBtn.Size = New System.Drawing.Size(86, 17)
            Me.word2013RadioBtn.TabIndex = 103
            Me.word2013RadioBtn.TabStop = True
            Me.word2013RadioBtn.Text = "Word 2013"
            Me.word2013RadioBtn.UseVisualStyleBackColor = True
            '
            'label3
            '
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Image)
            Me.label3.Location = New System.Drawing.Point(107, 48)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(20, 18)
            Me.label3.TabIndex = 102
            Me.ToolTip1.SetToolTip(Me.label3, "Saves the document in Word 2010 format")
            '
            'Label4
            '
            Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
            Me.Label4.Location = New System.Drawing.Point(221, 20)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(20, 18)
            Me.Label4.TabIndex = 101
            Me.ToolTip1.SetToolTip(Me.Label4, "Saves the document in Word 2007 format")
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(107, 22)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.ToolTip1.SetToolTip(Me.label24, "Saves the document in Word 97-2003 format" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'word2010RadioBtn
            '
            Me.word2010RadioBtn.AutoSize = True
            Me.word2010RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.word2010RadioBtn.Location = New System.Drawing.Point(6, 46)
            Me.word2010RadioBtn.Name = "word2010RadioBtn"
            Me.word2010RadioBtn.Size = New System.Drawing.Size(86, 17)
            Me.word2010RadioBtn.TabIndex = 46
            Me.word2010RadioBtn.Text = "Word 2010"
            Me.word2010RadioBtn.UseVisualStyleBackColor = True
            '
            'word2003RadioBtn
            '
            Me.word2003RadioBtn.AutoSize = True
            Me.word2003RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.word2003RadioBtn.Location = New System.Drawing.Point(6, 20)
            Me.word2003RadioBtn.Name = "word2003RadioBtn"
            Me.word2003RadioBtn.Size = New System.Drawing.Size(105, 17)
            Me.word2003RadioBtn.TabIndex = 44
            Me.word2003RadioBtn.Text = "Word 97-2003"
            Me.word2003RadioBtn.UseVisualStyleBackColor = True
            '
            'word2007RadioBtn
            '
            Me.word2007RadioBtn.AutoSize = True
            Me.word2007RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.word2007RadioBtn.Location = New System.Drawing.Point(139, 20)
            Me.word2007RadioBtn.Name = "word2007RadioBtn"
            Me.word2007RadioBtn.Size = New System.Drawing.Size(86, 17)
            Me.word2007RadioBtn.TabIndex = 45
            Me.word2007RadioBtn.Text = "Word 2007"
            Me.word2007RadioBtn.UseVisualStyleBackColor = True
            '
            'templateBtn
            '
            Me.templateBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.templateBtn.BackColor = System.Drawing.Color.Transparent
            Me.templateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.templateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.templateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.templateBtn.Image = CType(resources.GetObject("templateBtn.Image"), System.Drawing.Image)
            Me.templateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.templateBtn.Location = New System.Drawing.Point(115, 104)
            Me.templateBtn.Name = "templateBtn"
            Me.templateBtn.Size = New System.Drawing.Size(99, 25)
            Me.templateBtn.TabIndex = 4
            Me.templateBtn.Text = "View Template"
            Me.templateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.templateBtn.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(0, 104)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(376, 46)
            Me.label1.TabIndex = 5
            Me.label1.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" & _
        "ote that MS Word Viewer or MS Word is required to view the resultant document."
            '
            'PictureBox1
            '
            Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
            Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(375, 92)
            Me.PictureBox1.TabIndex = 6
            Me.PictureBox1.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(375, 303)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.groupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Sales Invoice"
            Me.groupBox1.ResumeLayout(False)
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' Get all customer ID's from database and add to the list box.
            Try
                ' Get Template document and database path.
                dataPath = Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"

                ' Get Template document and database path.
                AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", True)

                Dim dt As DataTable = New DataTable()
                Dim connectionstring As String = "Data Source = " & dataPath & "NorthwindIO.sdf"
                Dim conn As SqlCeConnection = New SqlCeConnection(connectionstring)
                conn.Open()
                Dim adapter As SqlCeDataAdapter = New SqlCeDataAdapter("select OrderID  from SyncOrders Order By OrderID", conn)
                adapter.Fill(dt)
                adapter.Dispose()
                conn.Close()

                ' Add Customer ID to the list box.
                For Each row As DataRow In dt.Rows
                    listBoxCustomer.Items.Add(row("OrderID"))
                Next row
                listBoxCustomer.SelectedIndex = 0
            Catch Ex As Exception
                ' Shows the Message box with Exception message, if an exception is thrown.
                MessageBox.Show(Ex.Message, "Report", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles listBoxCustomer.DoubleClick, button1.Click
            ' Generate Invoice for the selected ID.
            ExecuteMail_Doc(CInt(listBoxCustomer.SelectedItem))

        End Sub
        Private Sub ExecuteMail_Doc(ByVal ID As Integer)
            Try
                ' Create a new document
                doc = New WordDocument()
                ' Load the template.
                doc.Open((System.IO.Path.Combine(dataPath, "SalesInvoiceDemo.doc")), FormatType.Automatic)
                ' Execute Mail Merge with groups.
                doc.MailMerge.ExecuteGroup(GetTestOrder(ID))
                doc.MailMerge.ExecuteGroup(GetTestOrderTotals(ID))

                ' Using Merge events to do conditional formatting during runtime.
                AddHandler doc.MailMerge.MergeField, AddressOf MailMerge_MergeField

                Dim orderDetails As DataView = New DataView(GetTestOrderDetails(ID))
                orderDetails.Sort = "ExtendedPrice DESC"
                doc.MailMerge.ExecuteGroup(orderDetails)


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
            Catch Ex As Exception
                MessageBox.Show(Ex.Message)
            End Try
        End Sub

        Private Function GetTestOrder(ByVal TestOrderId As Integer) As DataTable
            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", True)

            Dim table As DataTable = New DataTable()
            Dim connectionstring As String = "Data Source = " & dataPath & "NorthwindIO.sdf"
            Dim conn As SqlCeConnection = New SqlCeConnection(connectionstring)
            conn.Open()
            Dim adapter As SqlCeDataAdapter = New SqlCeDataAdapter("SELECT * FROM SyncOrders WHERE OrderId = " & TestOrderId, conn)
            adapter.Fill(table)
            adapter.Dispose()
            conn.Close()

            table.TableName = "Orders"
            Return table
        End Function

        Private Function GetTestOrderDetails(ByVal TestOrderId As Integer) As DataTable
            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", True)

            Dim table As DataTable = New DataTable()
            Dim connectionstring As String = "Data Source = " & dataPath & "NorthwindIO.sdf"
            Dim conn As SqlCeConnection = New SqlCeConnection(connectionstring)
            conn.Open()
            Dim adapter As SqlCeDataAdapter = New SqlCeDataAdapter("SELECT * FROM SyncOrderDetails WHERE OrderId = " & TestOrderId & " ORDER BY ProductID", conn)
            adapter.Fill(table)
            adapter.Dispose()
            conn.Close()

            table.TableName = "Order"
            Return table
        End Function

        Private Function GetTestOrderTotals(ByVal TestOrderId As Integer) As DataTable
            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", True)

            Dim table As DataTable = New DataTable()
            Dim connectionstring As String = "Data Source = " & dataPath & "NorthwindIO.sdf"
            Dim conn As SqlCeConnection = New SqlCeConnection(connectionstring)
            conn.Open()
            Dim adapter As SqlCeDataAdapter = New SqlCeDataAdapter("SELECT * FROM SyncOrderTotals WHERE OrderId = " & TestOrderId, conn)
            adapter.Fill(table)
            adapter.Dispose()
            conn.Close()

            table.TableName = "OrderTotals"
            Return table
        End Function

        Private Function ExecuteDataTable(ByVal commandText As String) As DataTable
            ' Return DataTable
            Try
                AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", True)

                Dim table As DataTable = New DataTable()
                Dim connectionstring As String = "Data Source = " & dataPath & "NorthwindIO.sdf"
                Dim conn As SqlCeConnection = New SqlCeConnection(connectionstring)
                conn.Open()
                Dim adapter As SqlCeDataAdapter = New SqlCeDataAdapter(commandText, conn)
                adapter.Fill(table)
                adapter.Dispose()
                conn.Close()

                Return table
            Finally
            End Try
		End Function

		Private Sub MailMerge_MergeField(ByVal sender As Object, ByVal args As MergeFieldEventArgs)
			' Conditionally format data during Merge.
			If args.RowIndex Mod 2 = 0 Then
				args.CharacterFormat.TextColor = Color.DarkBlue
			End If

		End Sub
        ''' <summary>
        ''' The source template document.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub templateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles templateBtn.Click
            Process.Start(dataPath & "SalesInvoiceDemo.doc")
        End Sub
    End Class
End Namespace
