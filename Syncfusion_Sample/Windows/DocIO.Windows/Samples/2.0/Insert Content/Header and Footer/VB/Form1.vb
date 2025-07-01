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
Imports System.IO
Imports System.Diagnostics

Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS

Namespace EssentialDocIOSamples
    Public Class Form1 : Inherits System.Windows.Forms.Form

#Region " Private Members "

        Private WithEvents button1 As Button
        Private label1 As Label
        Private WithEvents checkBox2 As System.Windows.Forms.CheckBox
        Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents label20 As System.Windows.Forms.Label
        Private WithEvents numericUpDown1 As System.Windows.Forms.NumericUpDown
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents PictureBox3 As System.Windows.Forms.PictureBox
        Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
        Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents Label7 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label8 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label9 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents word2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2007RadioBtn As System.Windows.Forms.RadioButton
        Private components As System.ComponentModel.IContainer

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>

#End Region

#Region " Constructor, Main And Dispose "
        Public Sub New()
            InitializeComponent()
            For Each str As String In System.Enum.GetNames(GetType(PageNumberStyle))
                Me.comboBox1.Items.Add(str)
            Next str
            Me.comboBox1.SelectedIndex = 2
        End Sub
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.Run(New Form1())
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

#End Region

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.button1 = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.checkBox2 = New System.Windows.Forms.CheckBox()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.comboBox1 = New System.Windows.Forms.ComboBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label20 = New System.Windows.Forms.Label()
            Me.numericUpDown1 = New System.Windows.Forms.NumericUpDown()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.PictureBox3 = New System.Windows.Forms.PictureBox()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Label7 = New System.Windows.Forms.Label()
            Me.Label8 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2003RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2007RadioBtn = New System.Windows.Forms.RadioButton()
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.button1.Location = New System.Drawing.Point(280, 293)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(82, 25)
            Me.button1.TabIndex = 26
            Me.button1.Text = "Generate"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(0, 183)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(375, 51)
            Me.label1.TabIndex = 27
            Me.label1.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" & _
        "ote that MS Word Viewer or MS Word is required to view the resultant document."
            '
            'checkBox2
            '
            Me.checkBox2.AutoSize = True
            Me.checkBox2.Checked = True
            Me.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox2.Location = New System.Drawing.Point(5, 155)
            Me.checkBox2.Name = "checkBox2"
            Me.checkBox2.Size = New System.Drawing.Size(182, 18)
            Me.checkBox2.TabIndex = 49
            Me.checkBox2.Tag = "scrolls"
            Me.checkBox2.Text = "Header and Footer For All Pages"
            Me.checkBox2.UseVisualStyleBackColor = True
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.checkBox1.Location = New System.Drawing.Point(5, 128)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(186, 18)
            Me.checkBox1.TabIndex = 48
            Me.checkBox1.Tag = "scrolls"
            Me.checkBox1.Text = "Header and Footer For First Page"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Image = CType(resources.GetObject("label2.Image"), System.Drawing.Image)
            Me.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label2.Location = New System.Drawing.Point(5, 83)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(132, 24)
            Me.label2.TabIndex = 47
            Me.label2.Text = "Header And Footer"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label6
            '
            Me.label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label6.Location = New System.Drawing.Point(5, 109)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(170, 1)
            Me.label6.TabIndex = 46
            '
            'comboBox1
            '
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Location = New System.Drawing.Point(275, 126)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(93, 21)
            Me.comboBox1.TabIndex = 41
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label5.Location = New System.Drawing.Point(197, 83)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(102, 24)
            Me.label5.TabIndex = 45
            Me.label5.Text = "Page Number"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label20
            '
            Me.label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label20.Location = New System.Drawing.Point(197, 109)
            Me.label20.Name = "label20"
            Me.label20.Size = New System.Drawing.Size(170, 1)
            Me.label20.TabIndex = 44
            '
            'numericUpDown1
            '
            Me.numericUpDown1.Location = New System.Drawing.Point(275, 158)
            Me.numericUpDown1.Name = "numericUpDown1"
            Me.numericUpDown1.Size = New System.Drawing.Size(93, 20)
            Me.numericUpDown1.TabIndex = 43
            Me.numericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Location = New System.Drawing.Point(196, 160)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(44, 13)
            Me.label4.TabIndex = 42
            Me.label4.Text = "Start at:"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(196, 129)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(79, 13)
            Me.label3.TabIndex = 40
            Me.label3.Text = "Number Format"
            '
            'PictureBox3
            '
            Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
            Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
            Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(374, 74)
            Me.PictureBox3.TabIndex = 61
            Me.PictureBox3.TabStop = False
            '
            'Label7
            '
            Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
            Me.Label7.Location = New System.Drawing.Point(221, 48)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(20, 18)
            Me.Label7.TabIndex = 106
            Me.toolTip1.SetToolTip(Me.Label7, "Saves the document in Word 2013 format")
            '
            'Label8
            '
            Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
            Me.Label8.Location = New System.Drawing.Point(106, 48)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(20, 18)
            Me.Label8.TabIndex = 104
            Me.toolTip1.SetToolTip(Me.Label8, "Saves the document in Word 2010 format")
            '
            'Label9
            '
            Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
            Me.Label9.Location = New System.Drawing.Point(221, 20)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(20, 18)
            Me.Label9.TabIndex = 101
            Me.toolTip1.SetToolTip(Me.Label9, "Saves the document in Word 2007 format")
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(104, 20)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.toolTip1.SetToolTip(Me.label24, "Saves the document in Word 97-2003 format")
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Label7)
            Me.GroupBox2.Controls.Add(Me.word2013RadioBtn)
            Me.GroupBox2.Controls.Add(Me.Label8)
            Me.GroupBox2.Controls.Add(Me.word2010RadioBtn)
            Me.GroupBox2.Controls.Add(Me.Label9)
            Me.GroupBox2.Controls.Add(Me.label24)
            Me.GroupBox2.Controls.Add(Me.word2003RadioBtn)
            Me.GroupBox2.Controls.Add(Me.word2007RadioBtn)
            Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(5, 246)
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
            Me.ClientSize = New System.Drawing.Size(374, 328)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.PictureBox3)
            Me.Controls.Add(Me.checkBox2)
            Me.Controls.Add(Me.checkBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.comboBox1)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label20)
            Me.Controls.Add(Me.numericUpDown1)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Header and Footer"
            CType(Me.numericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region

#Region " Events "

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            ' Creating a new document.
            Dim doc As WordDocument = New WordDocument()

            ' Add a new section to the document.
            Dim section1 As IWSection = doc.AddSection()

            'Add different Header Footer for first and othe pages
            If checkBox1.Checked And checkBox2.Checked Then
                ' Set the header/footer setup.
                section1.PageSetup.DifferentFirstPage = True

                ' Inserting Header Footer to first page
                InsertFirstPageHeaderFooter(doc, section1)

                ' Inserting Header Footer to all pages
                InsertPageHeaderFooter(doc, section1)
            End If
            'Add header/footer for only first page
            If checkBox1.Checked And checkBox2.Checked <> True Then
                ' Set the header/footer setup.
                section1.PageSetup.DifferentFirstPage = True

                ' Inserting Header Footer to first page
                InsertFirstPageHeaderFooter(doc, section1)
            End If
            'Add header/footer for all the pages
            If checkBox2.Checked And checkBox1.Checked <> True Then
                ' Inserting Header Footer to all pages
                InsertPageHeaderFooter(doc, section1)
            End If
            ' Add text to the document body section.
            Dim par As IWParagraph
            par = section1.AddParagraph()
            'Insert Text into the word Document.
            Dim reader As StreamReader = New StreamReader("..\..\..\..\..\..\..\..\..\Common\Data\DocIO\WinFAQ.txt", System.Text.Encoding.ASCII)
            Dim text As String = reader.ReadToEnd()
            par.AppendText(text)


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

        End Sub

#End Region

#Region " Helper Methods "


#Region " InsertFirstPageHeaderFooter "
        Private Sub InsertFirstPageHeaderFooter(ByVal doc As WordDocument, ByVal section As IWSection)
            ' Add a new paragraph for header to the document.
            Dim headerPar As IWParagraph = New WParagraph(doc)

            ' Add a new table to the header.
            Dim table As IWTable = section.HeadersFooters.FirstPageHeader.AddTable()

            Dim format As New RowFormat()

            ' Setting cleared table border style.
            format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Cleared

            ' Inserting table with a row and two columns.
            table.ResetCells(1, 2, format, 265)

            ' Inserting logo image to the table first cell.
            headerPar = TryCast(table(0, 0).AddParagraph(), WParagraph)
            headerPar.AppendPicture(Image.FromFile("..\..\..\..\..\..\..\..\..\Common\images\DocIO\syncfusion_logo.gif"))
            'Set Image size
            TryCast(headerPar.Items(0), WPicture).Width = 232.5F
            TryCast(headerPar.Items(0), WPicture).Height = 54.75F
            ' Inserting text to the table second cell.
            headerPar = TryCast(table(0, 1).AddParagraph(), WParagraph)
            Dim txt As IWTextRange = headerPar.AppendText("Company Headquarters," & vbLf & "2501 Aerial Center Parkway," & vbLf & "Suite 110, Morrisville, NC 27560," & vbLf & "TEL 1-888-936-8638.")
            txt.CharacterFormat.FontSize = 12
            txt.CharacterFormat.CharacterSpacing = 1.7F
            headerPar.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right
            ' Add a new paragraph to the header with address text.
            headerPar = New WParagraph(doc)
            headerPar.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            txt = headerPar.AppendText(vbLf & "First Page Header")
            txt.CharacterFormat.CharacterSpacing = 1.7F
            section.HeadersFooters.FirstPageHeader.Paragraphs.Add(headerPar)

            ' Add a footer paragraph text to the document.
            Dim footerPar As New WParagraph(doc)
            footerPar.ParagraphFormat.Tabs.AddTab(523.0F, TabJustification.Right, TabLeader.NoLeader)
            ' Add text.
            footerPar.AppendText("Copyright Syncfusion Inc. 2001 - 2012")
            ' Add page and Number of pages field to the document.
            footerPar.AppendText(vbTab & "First Page ")
            footerPar.AppendField("Page", FieldType.FieldPage)
            section.HeadersFooters.FirstPageFooter.Paragraphs.Add(footerPar)

            'Page Number Settings
            section.PageSetup.RestartPageNumbering = True
            section.PageSetup.PageStartingNumber = Convert.ToInt32(Me.numericUpDown1.Value)
            section.PageSetup.PageNumberStyle = CType(System.Enum.Parse(GetType(PageNumberStyle), Me.comboBox1.SelectedItem.ToString(), True), PageNumberStyle)
        End Sub

#End Region

#Region " InsertPageHeaderFooter "
        Private Sub InsertPageHeaderFooter(ByVal doc As WordDocument, ByVal section1 As IWSection)

            ' Add a new paragraph for header to the document.
            Dim headerPar As IWParagraph = New WParagraph(doc)

            ' Add a new table to the header
            Dim table As IWTable = section1.HeadersFooters.Header.AddTable()

            Dim format As New RowFormat()

            ' Setting cleared table border style.
            format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.[Single]

            ' Inserting table with a row and two columns.
            table.ResetCells(1, 2, format, 265)

            ' Inserting logo image to the table first cell.
            headerPar = TryCast(table(0, 0).AddParagraph(), WParagraph)
            headerPar.AppendPicture(Image.FromFile("..\..\..\..\..\..\..\..\..\Common\images\DocIO\syncfusion_logo.gif"))
            'Set Image size.
            TryCast(headerPar.Items(0), WPicture).Width = 232.5F
            TryCast(headerPar.Items(0), WPicture).Height = 54.75F
            ' Inserting text to the table second cell.
            headerPar = TryCast(table(0, 1).AddParagraph(), WParagraph)
            Dim txt As IWTextRange = headerPar.AppendText("Company Headquarters," & vbLf & "2501 Aerial Center Parkway," & vbLf & "Suite 110, Morrisville, NC 27560," & vbLf & "TEL 1-888-936-8638.")
            txt.CharacterFormat.FontSize = 12
            txt.CharacterFormat.CharacterSpacing = 1.7F
            headerPar.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right

            ' Add a footer paragraph text to the document.
            Dim footerPar As New WParagraph(doc)
            footerPar.ParagraphFormat.Tabs.AddTab(523.0F, TabJustification.Right, TabLeader.NoLeader)
            ' Add text.
            footerPar.AppendText("Copyright Syncfusion Inc. 2001 - 2012")
            ' Add page and Number of pages field to the document.
            footerPar.AppendText(vbTab & "Page ")
            Dim ff As IWField = footerPar.AppendField("Page", FieldType.FieldPage)

            section1.HeadersFooters.Footer.Paragraphs.Add(footerPar)

            'Page Number Settings
            section1.PageSetup.RestartPageNumbering = True
            section1.PageSetup.PageStartingNumber = Convert.ToInt32(Me.numericUpDown1.Value)
            section1.PageSetup.PageNumberStyle = CType(System.Enum.Parse(GetType(PageNumberStyle), Me.comboBox1.SelectedItem.ToString(), True), PageNumberStyle)
        End Sub

#End Region


#End Region
    End Class
End Namespace
