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

#Region "Private Members"


        Private components As System.ComponentModel.IContainer
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents ToolTip2 As System.Windows.Forms.ToolTip
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2007RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
#End Region

#Region "Constructor Main And Dispose"

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Application.EnableVisualStyles()
            '
            ' TODO: Add any constructor code after InitializeComponent call
            ''
        End Sub
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
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
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.label5 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.button1 = New System.Windows.Forms.Button()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2003RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2007RadioBtn = New System.Windows.Forms.RadioButton()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'label5
            '
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.Location = New System.Drawing.Point(221, 48)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(20, 18)
            Me.label5.TabIndex = 104
            Me.toolTip1.SetToolTip(Me.label5, "Saves the document in Word 2013 format")
            '
            'label3
            '
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Image)
            Me.label3.Location = New System.Drawing.Point(106, 48)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(20, 18)
            Me.label3.TabIndex = 102
            Me.toolTip1.SetToolTip(Me.label3, "Saves the document in Word 2010 format")
            '
            'label1
            '
            Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Image)
            Me.label1.Location = New System.Drawing.Point(221, 20)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(20, 18)
            Me.label1.TabIndex = 101
            Me.toolTip1.SetToolTip(Me.label1, "Saves the document in Word 2007 format")
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(104, 20)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.toolTip1.SetToolTip(Me.label24, "Saves the document in Word 97-2003 format" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 107)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(374, 47)
            Me.label2.TabIndex = 79
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
            Me.pictureBox1.TabIndex = 75
            Me.pictureBox1.TabStop = False
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
            Me.button1.Location = New System.Drawing.Point(283, 215)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(79, 25)
            Me.button1.TabIndex = 74
            Me.button1.Text = "Generate"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.word2013RadioBtn)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.label24)
            Me.groupBox1.Controls.Add(Me.word2010RadioBtn)
            Me.groupBox1.Controls.Add(Me.word2003RadioBtn)
            Me.groupBox1.Controls.Add(Me.word2007RadioBtn)
            Me.groupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(12, 170)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(251, 70)
            Me.groupBox1.TabIndex = 102
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Save As"
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
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(374, 252)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.button1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Insert Break"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Button Click"


        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            Dim reader As StreamReader
            Dim stringText As String
            'Getting Image files Path. 
            Dim dataPath As String = Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\images\DocIO\"
            'Getting text files Path.
            Dim dataPath1 As String = Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\ "
            'Creating a new document
            Dim document As WordDocument = New WordDocument()
            'Adding a new section.
            Dim section As IWSection = document.AddSection()
            section.PageSetup.Margins.All = 72.0F
            Dim paragraph As IWParagraph = section.AddParagraph()
            paragraph = section.AddParagraph()
            Dim text As IWTextRange = paragraph.AppendText("BackOffice products")
            'Formatting Text
            text.CharacterFormat.FontName = "Bitstream Vera Sans"
            text.CharacterFormat.FontSize = 12.0F
            text.CharacterFormat.Bold = True
            section.AddParagraph()
            paragraph = section.AddParagraph()
            paragraph.ParagraphFormat.LineSpacing = 20.0F
            paragraph.AppendText("Backoffice products allows you to create report of PDF, Doc and Excel format. This package includes Essential PDF,Essential DocIO and Essential XlsIO. Following are the backoffice product with some description on each of them: ")
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify

            '"Line break"
            paragraph.AppendBreak(BreakType.LineBreak)
            paragraph.AppendBreak(BreakType.LineBreak)


            section = document.AddSection()
            section.PageSetup.Margins.All = 72.0F

            section.BreakCode = SectionBreakCode.NoBreak
            'Adding three columns to section.
            section.AddColumn(100, 15)
            section.AddColumn(100, 15)
            section.AddColumn(100, 15)
            'Set the columns to be of equal width.
            section.MakeColumnsEqual()

            'Adding a new paragraph to the section.
            paragraph = section.AddParagraph()
            'Adding text.
            text = paragraph.AppendText("Essential PDF")
            'Formatting Text
            text.CharacterFormat.FontName = "Bitstream Vera Sans"
            text.CharacterFormat.FontSize = 12.0F
            text.CharacterFormat.Bold = True
            'Adding a new paragraph to the section.
            section.AddParagraph()
            paragraph = section.AddParagraph()
            'Inserting an Image.
            paragraph.AppendPicture(New Bitmap(Path.Combine(dataPath, "PDF.gif")))
            'Adding a new paragraph to the section.
            section.AddParagraph()
            paragraph = section.AddParagraph()
            paragraph.ParagraphFormat.LineSpacing = 20.0F
            'Adding text.
            reader = New StreamReader(Path.Combine(dataPath1, "PDF.txt"))
            stringText = reader.ReadToEnd()
            paragraph.AppendText(stringText)
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify

            ' Set column break as true. It navigates the cursor position to the next Column.
            paragraph.ParagraphFormat.ColumnBreakAfter = True

            paragraph = section.AddParagraph()
            text = paragraph.AppendText("Essential DocIO")
            text.CharacterFormat.FontName = "Bitstream Vera Sans"
            text.CharacterFormat.FontSize = 12.0F
            text.CharacterFormat.Bold = True

            section.AddParagraph()
            paragraph = section.AddParagraph()
            paragraph.AppendPicture(New Bitmap(Path.Combine(dataPath, "DocIO.gif")))
            section.AddParagraph()
            paragraph = section.AddParagraph()
            paragraph.ParagraphFormat.LineSpacing = 20.0F
            reader = New StreamReader(Path.Combine(dataPath1, "DocIO.txt"))
            stringText = reader.ReadToEnd()
            paragraph.AppendText(stringText)
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify

            paragraph.ParagraphFormat.ColumnBreakAfter = True

            paragraph = section.AddParagraph()
            text = paragraph.AppendText("Essential XlsIO")
            text.CharacterFormat.FontName = "Bitstream Vera Sans"
            text.CharacterFormat.FontSize = 12.0F
            text.CharacterFormat.Bold = True

            section.AddParagraph()
            paragraph = section.AddParagraph()
            paragraph.AppendPicture(New Bitmap(Path.Combine(dataPath, "XlsIO.gif")))
            section.AddParagraph()
            paragraph = section.AddParagraph()
            paragraph.ParagraphFormat.LineSpacing = 20.0F
            reader = New StreamReader(Path.Combine(dataPath1, "XlsIO.txt"))
            stringText = reader.ReadToEnd()
            paragraph.AppendText(stringText)
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify

            section = document.AddSection()
            section.PageSetup.Margins.All = 72.0F
            section.BreakCode = SectionBreakCode.NoBreak

            reader = New StreamReader(Path.Combine(dataPath1, "pdffeatures.txt"))
            stringText = reader.ReadToEnd()
            text = section.AddParagraph().AppendText("Essential PDF")
            'Formatting Text
            text.CharacterFormat.FontName = "Bitstream Vera Sans"
            text.CharacterFormat.FontSize = 12.0F
            text.CharacterFormat.Bold = True

            paragraph = section.AddParagraph()
            paragraph.ParagraphFormat.LineSpacing = 20.0F
            paragraph.AppendText(stringText)
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify

            reader = New StreamReader(Path.Combine(dataPath1, "docfeatures.txt"))
            stringText = reader.ReadToEnd()
            text = section.AddParagraph().AppendText("Essential DocIO")
            'Formatting Text
            text.CharacterFormat.FontName = "Bitstream Vera Sans"
            text.CharacterFormat.FontSize = 12.0F
            text.CharacterFormat.Bold = True
            paragraph = section.AddParagraph()
            paragraph.ParagraphFormat.LineSpacing = 20.0F
            paragraph.AppendText(stringText)
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify

            reader = New StreamReader(Path.Combine(dataPath1, "xlsfeatures.txt"))
            stringText = reader.ReadToEnd()
            paragraph = section.AddParagraph()
            paragraph.ParagraphFormat.PageBreakBefore = True
            text = paragraph.AppendText("Essential XlsIO")
            'Formatting Text
            text.CharacterFormat.FontName = "Bitstream Vera Sans"
            text.CharacterFormat.FontSize = 12.0F
            text.CharacterFormat.Bold = True
            paragraph = section.AddParagraph()
            paragraph.ParagraphFormat.LineSpacing = 20.0F
            paragraph.AppendText(stringText)
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Justify

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

        End Sub
#End Region

    End Class
End Namespace
