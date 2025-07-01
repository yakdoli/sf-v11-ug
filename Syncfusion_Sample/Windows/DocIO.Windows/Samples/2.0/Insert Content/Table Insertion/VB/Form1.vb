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
Imports System.Drawing.Imaging
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data

Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS
Imports System.Data.SqlServerCe


Namespace EssentialDocIOSamples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
        Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents Label6 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label4 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label5 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
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
            Me.button1 = New System.Windows.Forms.Button()
            Me.label2 = New System.Windows.Forms.Label()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2003RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2007RadioBtn = New System.Windows.Forms.RadioButton()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
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
            Me.button1.Location = New System.Drawing.Point(281, 214)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(81, 25)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Generate"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 105)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(374, 58)
            Me.label2.TabIndex = 72
            Me.label2.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" & _
        "ote that MS Word Viewer or MS Word is required to view the resultant document."
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(374, 97)
            Me.pictureBox1.TabIndex = 70
            Me.pictureBox1.TabStop = False
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
            'Label4
            '
            Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
            Me.Label4.Location = New System.Drawing.Point(106, 48)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(20, 18)
            Me.Label4.TabIndex = 104
            Me.toolTip1.SetToolTip(Me.Label4, "Saves the document in Word 2010 format")
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
            Me.label24.Location = New System.Drawing.Point(106, 20)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.toolTip1.SetToolTip(Me.label24, "Saves the document in Word 97-2003 format")
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.word2013RadioBtn)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.word2010RadioBtn)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.label24)
            Me.GroupBox2.Controls.Add(Me.word2003RadioBtn)
            Me.GroupBox2.Controls.Add(Me.word2007RadioBtn)
            Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(12, 167)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(251, 72)
            Me.GroupBox2.TabIndex = 101
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
            Me.ClientSize = New System.Drawing.Size(374, 248)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.button1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Table Insertion"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
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

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            ' Get Template document and database path.
            Dim dataPath As String = Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\Data\"


            Try
                AppDomain.CurrentDomain.SetData("SQLServerCompactEditionUnderWebHosting", True)
                Dim table As DataTable = New DataTable()
                Dim connectionstring As String = "Data Source = " & dataPath & "Northwind.sdf"
                Dim conn As SqlCeConnection = New SqlCeConnection(connectionstring)
                conn.Open()
                Dim adapter As SqlCeDataAdapter = New SqlCeDataAdapter("Select [Customer ID],[Company Name],[Contact Name],Address,Country,Phone from Customers", conn)
                adapter.Fill(table)
                adapter.Dispose()
                conn.Close()

                ' Creating a new document.
                Dim document As WordDocument = New WordDocument()
                ' Adding a new section to the document.
                Dim section As IWSection = document.AddSection()
                ' Set Margin of the document
                section.PageSetup.Margins.All = 72
                Dim paragraph As IWParagraph = section.AddParagraph()

                'Format the heading.
                Dim text As IWTextRange = paragraph.AppendText("Northwind Report")
                text.CharacterFormat.Bold = True
                text.CharacterFormat.FontName = "Cambria"
                text.CharacterFormat.FontSize = 14.0F
                text.CharacterFormat.TextColor = Color.DarkBlue
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center

                paragraph = section.AddParagraph()
                paragraph.ParagraphFormat.BeforeSpacing = 18.0F

                'Create a new table
                Dim textBody As WTextBody = section.Body
                Dim docTable As IWTable = textBody.AddTable()

                'Set the format for rows
                Dim format As RowFormat = New RowFormat()
                format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single
                format.Borders.LineWidth = 1.0F
                format.Borders.Color = Color.Black

                'Initialize number of rows and cloumns.
                docTable.ResetCells(table.Rows.Count + 1, table.Columns.Count, format, 84)

                'Repeat the header.
                docTable.Rows(0).IsHeader = True

                Dim colName As String

                'Format the header rows
                Dim c As Integer = 0

                Do While c <= table.Columns.Count - 1

                    Dim Cols As String() = table.Columns(c).ColumnName.Split("|"c)
                    colName = Cols(Cols.Length - 1)
                    Dim theadertext As IWTextRange = docTable.Rows(0).Cells(c).AddParagraph().AppendText(colName)
                    theadertext.CharacterFormat.FontSize = 12.0F
                    theadertext.CharacterFormat.Bold = True
                    theadertext.CharacterFormat.TextColor = Color.White
                    docTable.Rows(0).Cells(c).CellFormat.BackColor = Color.FromArgb(33, 67, 126)
                    docTable.Rows(0).Cells(c).CellFormat.Borders.Color = Color.Black
                    docTable.Rows(0).Cells(c).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single
                    docTable.Rows(0).Cells(c).CellFormat.Borders.LineWidth = 1.0F

                    docTable.Rows(0).Cells(c).CellFormat.VerticalAlignment = VerticalAlignment.Middle

                    c += 1
                Loop

                'Format the table body rows
                Dim r As Integer = 0

                Do While r <= table.Rows.Count - 1
                    c = 0
                    Do While c <= table.Columns.Count - 1
                        Dim Value As String = table.Rows(r)(c).ToString()
                        Dim theadertext As IWTextRange = docTable.Rows(r + 1).Cells(c).AddParagraph().AppendText(Value)
                        theadertext.CharacterFormat.FontSize = 10

                        If ((r And 1) = 0) Then
                            docTable.Rows(r + 1).Cells(c).CellFormat.BackColor = Color.FromArgb(237, 240, 246)
                        Else
                            docTable.Rows(r + 1).Cells(c).CellFormat.BackColor = Color.FromArgb(192, 201, 219)
                        End If

                        docTable.Rows(r + 1).Cells(c).CellFormat.Borders.Color = Color.Black
                        docTable.Rows(r + 1).Cells(c).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single
                        docTable.Rows(r + 1).Cells(c).CellFormat.Borders.LineWidth = 0.5F
                        docTable.Rows(r + 1).Cells(c).CellFormat.VerticalAlignment = VerticalAlignment.Middle
                        c += 1
                    Loop
                    r += 1
                Loop

                ' Add a footer paragraph text to the document.
                Dim footerPar As WParagraph = New WParagraph(document)
                ' Add text.
                footerPar.AppendText("Copyright Syncfusion Inc. 2001 - 2012")
                ' Add page and Number of pages field to the document.
                footerPar.AppendText("			Page ")
                footerPar.AppendField("Page", FieldType.FieldPage)

                section.HeadersFooters.Footer.Paragraphs.Add(footerPar)


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
                ' Shows the Message box with Exception message, if an exception throws.
                MessageBox.Show(Ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally

            End Try
        End Sub

    End Class
End Namespace
