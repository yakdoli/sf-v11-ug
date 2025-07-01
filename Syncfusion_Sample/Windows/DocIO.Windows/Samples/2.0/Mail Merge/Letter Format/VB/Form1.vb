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

Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS
Imports System.Data.SqlServerCe

Namespace LetterFormatting
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
		#Region "Private Members"

		Private WithEvents button1 As Button
        Private dataGrid1 As DataGrid
		Private dr As DataRow
		Private table As DataTable
		Private panel1 As Panel
		Private label2 As Label
		Private pictureBox2 As PictureBox
		Private label3 As Label
		Private checkBoxChoose As CheckBox
		Private toolTip1 As ToolTip
		Private label4 As Label
		Private imageList1 As ImageList
        Private pictureBox3 As PictureBox
        Private WithEvents templateBtn As System.Windows.Forms.Button
        Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents Label6 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label1 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label5 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents word2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2007RadioBtn As System.Windows.Forms.RadioButton
        Private components As IContainer

#End Region

#Region "Constructor and Form Load"

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
            Me.dataGrid1 = New System.Windows.Forms.DataGrid()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.label2 = New System.Windows.Forms.Label()
            Me.pictureBox3 = New System.Windows.Forms.PictureBox()
            Me.checkBoxChoose = New System.Windows.Forms.CheckBox()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.label3 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.pictureBox2 = New System.Windows.Forms.PictureBox()
            Me.button1 = New System.Windows.Forms.Button()
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.templateBtn = New System.Windows.Forms.Button()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2003RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2007RadioBtn = New System.Windows.Forms.RadioButton()
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'dataGrid1
            '
            Me.dataGrid1.DataMember = ""
            Me.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
            Me.dataGrid1.Location = New System.Drawing.Point(7, 197)
            Me.dataGrid1.Name = "dataGrid1"
            Me.dataGrid1.Size = New System.Drawing.Size(362, 204)
            Me.dataGrid1.TabIndex = 24
            '
            'panel1
            '
            Me.panel1.BackColor = System.Drawing.Color.OldLace
            Me.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel1.Controls.Add(Me.label2)
            Me.panel1.Controls.Add(Me.pictureBox3)
            Me.panel1.Location = New System.Drawing.Point(7, 102)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(363, 64)
            Me.panel1.TabIndex = 72
            '
            'label2
            '
            Me.label2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(47, 0)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(314, 62)
            Me.label2.TabIndex = 68
            Me.label2.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" & _
        "ote that MS Word Viewer or MS Word is required to view the resultant document."
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'pictureBox3
            '
            Me.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left
            Me.pictureBox3.Image = Global.My.Resources.Resources.label1_Image
            Me.pictureBox3.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox3.Name = "pictureBox3"
            Me.pictureBox3.Size = New System.Drawing.Size(47, 62)
            Me.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
            Me.pictureBox3.TabIndex = 86
            Me.pictureBox3.TabStop = False
            '
            'checkBoxChoose
            '
            Me.checkBoxChoose.AutoSize = True
            Me.checkBoxChoose.Checked = True
            Me.checkBoxChoose.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBoxChoose.Location = New System.Drawing.Point(9, 492)
            Me.checkBoxChoose.Name = "checkBoxChoose"
            Me.checkBoxChoose.Size = New System.Drawing.Size(100, 17)
            Me.checkBoxChoose.TabIndex = 83
            Me.checkBoxChoose.Text = "Map DataFields"
            Me.checkBoxChoose.UseVisualStyleBackColor = True
            '
            'label3
            '
            Me.label3.Image = Global.My.Resources.Resources.label8_Image
            Me.label3.Location = New System.Drawing.Point(113, 493)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(20, 16)
            Me.label3.TabIndex = 84
            Me.toolTip1.SetToolTip(Me.label3, "Map datafields for merging that are not same as the Column Name in the data sourc" & _
            "e.")
            '
            'Label6
            '
            Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
            Me.Label6.Location = New System.Drawing.Point(221, 48)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(20, 18)
            Me.Label6.TabIndex = 106
            Me.toolTip1.SetToolTip(Me.Label6, "Saves the document in Word 2013 format")
            '
            'Label1
            '
            Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
            Me.Label1.Location = New System.Drawing.Point(107, 48)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(20, 18)
            Me.Label1.TabIndex = 104
            Me.toolTip1.SetToolTip(Me.Label1, "Saves the document in Word 2010 format")
            '
            'Label5
            '
            Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
            Me.Label5.Location = New System.Drawing.Point(221, 20)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(20, 18)
            Me.Label5.TabIndex = 101
            Me.toolTip1.SetToolTip(Me.Label5, "Saves the document in Word 2007 format")
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(107, 22)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.toolTip1.SetToolTip(Me.label24, "Saves the document in Word 97-2003 format")
            '
            'label4
            '
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label4.Image = Global.My.Resources.Resources.label_Image
            Me.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label4.Location = New System.Drawing.Point(4, 172)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(232, 20)
            Me.label4.TabIndex = 85
            Me.label4.Text = "Select any row from the grid below"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'pictureBox2
            '
            Me.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
            Me.pictureBox2.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox2.Name = "pictureBox2"
            Me.pictureBox2.Size = New System.Drawing.Size(374, 90)
            Me.pictureBox2.TabIndex = 73
            Me.pictureBox2.TabStop = False
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
            Me.button1.Location = New System.Drawing.Point(257, 487)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(102, 25)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Generate"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
            '
            'imageList1
            '
            Me.imageList1.ImageStream = CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imageList1.TransparentColor = System.Drawing.Color.OldLace
            Me.imageList1.Images.SetKeyName(0, "label1.Image.png")
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
            Me.templateBtn.Location = New System.Drawing.Point(145, 487)
            Me.templateBtn.Name = "templateBtn"
            Me.templateBtn.Size = New System.Drawing.Size(102, 25)
            Me.templateBtn.TabIndex = 102
            Me.templateBtn.Text = "View Template"
            Me.templateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.templateBtn.UseVisualStyleBackColor = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.word2013RadioBtn)
            Me.GroupBox2.Controls.Add(Me.Label1)
            Me.GroupBox2.Controls.Add(Me.word2010RadioBtn)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.label24)
            Me.GroupBox2.Controls.Add(Me.word2003RadioBtn)
            Me.GroupBox2.Controls.Add(Me.word2007RadioBtn)
            Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(58, 409)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(251, 72)
            Me.GroupBox2.TabIndex = 103
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Save As"
            '
            'word2013RadioBtn
            '
            Me.word2013RadioBtn.AutoSize = True
            Me.word2013RadioBtn.Checked = True
            Me.word2013RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.word2013RadioBtn.Location = New System.Drawing.Point(139, 46)
            Me.word2013RadioBtn.Name = "word2013RadioBtn"
            Me.word2013RadioBtn.Size = New System.Drawing.Size(86, 17)
            Me.word2013RadioBtn.TabIndex = 105
            Me.word2013RadioBtn.TabStop = True
            Me.word2013RadioBtn.Text = "Word 2013"
            Me.word2013RadioBtn.UseVisualStyleBackColor = True
            '
            'word2010RadioBtn
            '
            Me.word2010RadioBtn.AutoSize = True
            Me.word2010RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.word2010RadioBtn.Location = New System.Drawing.Point(6, 46)
            Me.word2010RadioBtn.Name = "word2010RadioBtn"
            Me.word2010RadioBtn.Size = New System.Drawing.Size(86, 17)
            Me.word2010RadioBtn.TabIndex = 103
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
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(374, 519)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.templateBtn)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.checkBoxChoose)
            Me.Controls.Add(Me.pictureBox2)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.dataGrid1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Letter Format"
            CType(Me.dataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            CType(Me.pictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

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

        ''' <summary>
        ''' Updates the datagrid with the datasource on Form Load
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

            'SDF the database and get the NorthWind 
            'SDF  database and get the NorthWind 
            Dim dataPath As String = Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\Data\"

            AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", True)
            'SDF and get the NorthWind 
            Dim connectionstring As String = "Data Source = " & dataPath & "NorthwindIO.sdf"
            table = New DataTable()
            Dim conn As SqlCeConnection = New SqlCeConnection(connectionstring)
            conn.Open()
            Dim adapter As SqlCeDataAdapter = New SqlCeDataAdapter("Select * from Customers", conn)
            adapter.Fill(table)
            adapter.Dispose()
            conn.Close()

            'Initializes the data grid
            Me.dataGrid1.DataSource = table
            Me.dataGrid1.ReadOnly = True
            Me.dataGrid1.RowHeadersVisible = False
            Me.dataGrid1.CaptionVisible = False

            'Selects the first row by default
            Me.dataGrid1.Select(Me.dataGrid1.CurrentCell.RowNumber)
            AddHandler dataGrid1.MouseUp, AddressOf dataGrid1_MouseUp
        End Sub
#End Region

#Region "Events"
        ''' <summary>
        ''' Creates word document and executes mail merge
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub buttonSubmit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            ' Get Template document and database path.
            Dim dataPath As String = Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"

            Try
                ' Create a new document.
                Dim document As WordDocument = New WordDocument()

                ' Loading Template.
                document.Open(System.IO.Path.Combine(dataPath, "Letter Formatting.doc"), FormatType.Doc)

                ' Checks if data field mapping should be enabled
                If checkBoxChoose.Checked Then
                    ' Merge Template fields with user entered data.
                    document.MailMerge.RemoveEmptyParagraphs = True

                    'To clear the fields with empty value
                    document.MailMerge.ClearFields = True

                    'Clear the map fields
                    document.MailMerge.MappedFields.Clear()

                    'Update the mapping fields
                    document.MailMerge.MappedFields.Add("Contact Name", "ContactName")
                    document.MailMerge.MappedFields.Add("Company Name", "CompanyName")
                    document.MailMerge.MappedFields.Add("CompanyAddress", "Address")
                    document.MailMerge.MappedFields.Add("Residing City", "City")
                    document.MailMerge.MappedFields.Add("Current Region", "Region")
                    document.MailMerge.MappedFields.Add("Home Country", "Country")
                End If

                ' Gets the selected row from the datagrid
                dr = table.Rows(Me.dataGrid1.CurrentCell.RowNumber)

                'Mailmerge can be performed with the input as either DataRow, DataField, DataView, IDataReader 
                'or a set of merge field names and values. Here, one particular row is extraced from the table and used.

                'Executes mail merge for the selected record or row
                document.MailMerge.Execute(dr)
                'Add Text Watermark
                document.Watermark = New TextWatermark()
                TryCast(document.Watermark, TextWatermark).Text = "Demo"
                TryCast(document.Watermark, TextWatermark).Size = 144
                'Save as word 2003  format
                If word2003RadioBtn.Checked Then
                    'Saving the document to disk.
                    document.Save("Sample.doc")

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
                    document.Save("Sample.docx", FormatType.Word2007)
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
                    document.Save("Sample.docx", FormatType.Word2010)
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
                    document.Save("Sample.docx", FormatType.Word2013)
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
                MessageBox.Show(Ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End Try
        End Sub

        ''' <summary>
        ''' Selects the entire row when the user selects a cell
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub dataGrid1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hitTestInfo As DataGrid.HitTestInfo = dataGrid1.HitTest(New Point(e.X, e.Y))
            If hitTestInfo.Type = DataGrid.HitTestType.Cell Then
                Me.dataGrid1.CurrentCell = New DataGridCell(hitTestInfo.Row, hitTestInfo.Column)
                Me.dataGrid1.Select(hitTestInfo.Row)
            End If
        End Sub
        ''' <summary>
        ''' The source template document.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub templateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles templateBtn.Click
            Process.Start(Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\Letter Formatting.doc")
        End Sub
#End Region
    End Class
End Namespace
