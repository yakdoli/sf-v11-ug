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
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1 : Inherits System.Windows.Forms.Form
        Private WithEvents button1 As Button
        Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private section, section1 As IWSection
        Private paragraph As IWParagraph = Nothing
        Private textRange As IWTextRange = Nothing
        Private products As String() = {"Tools", "Grid", "Chart", "Edit", "Diagram", "XlsIO", "Grouping", "Calculate", "PDF", "HTMLUI", "DocIO"}
        Private forms As String() = {"Windows", "Web"}
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
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
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
            Me.button1.Location = New System.Drawing.Point(284, 217)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(78, 25)
            Me.button1.TabIndex = 26
            Me.button1.Text = "Generate"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 106)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(374, 47)
            Me.label2.TabIndex = 74
            Me.label2.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" & _
        "ote that MS Word Viewer or MS Word is required to view the resultant document."
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
            Me.label24.Location = New System.Drawing.Point(106, 22)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.toolTip1.SetToolTip(Me.label24, "Saves the document in Word 97-2003 format")
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
            Me.GroupBox2.Location = New System.Drawing.Point(12, 170)
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
            Me.ClientSize = New System.Drawing.Size(374, 266)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.button1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Format Text"
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
            'Random number generator.
            Dim r As Random = New Random()

            ' List of FontNames.
            Dim fontNames As String() = {"Arial", "Times New Roman", "Monotype Corsiva", " Book Antiqua ", "Bitstream Vera Sans", "Comic Sans MS", "Microsoft Sans Serif", "Batang"}

            ' Create a new document.
            Dim document As WordDocument = New WordDocument()

            ' Adding a new section to the document.
            Dim section As IWSection = document.AddSection()
            'Set Margin of the document
            section.PageSetup.Margins.All = 72
            ' Adding a new paragraph to the section.
            Dim paragraph As IWParagraph = section.AddParagraph()

            paragraph.AppendText("This sample demonstrates various text and paragraph formatting supported by Essential DocIO.")
            section.AddParagraph()
            section.AddParagraph()

            section = document.AddSection()
            section.BreakCode = SectionBreakCode.NoBreak
            'Adding two columns to the section.
            section.AddColumn(250, 20)
            section.AddColumn(250, 20)

            ' "Text Formatting"
            'Create a TextRange
            Dim text As IWTextRange = Nothing

            ' Writing Text with different Formatting styles.
            Dim i As Integer = 8
            Dim j As Integer = 0
            Dim k As Integer = 0

            Do While i <= 20
                If j >= fontNames.Length Then
                    j = 0
                End If
                paragraph = section.AddParagraph()
                text = paragraph.AppendText("Essential DocIO " & "[" & fontNames(j) & "]")
                text.CharacterFormat.FontName = fontNames(j)
                text.CharacterFormat.UnderlineStyle = CType(k, UnderlineStyle)
                text.CharacterFormat.FontSize = i
                text.CharacterFormat.TextColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255))
                i += 1
                j += 1
                k += 1
            Loop

            ' More formatting options.
            section.AddParagraph()
            paragraph.ParagraphFormat.ColumnBreakAfter = True
            paragraph = section.AddParagraph()
            text = paragraph.AppendText("More formatting Options List...")
            text.CharacterFormat.FontName = fontNames(2)
            text.CharacterFormat.FontSize = 18

            section.AddParagraph()
            paragraph = section.AddParagraph()
            paragraph.AppendText("AllCaps " & Constants.vbLf + Constants.vbLf).CharacterFormat.AllCaps = True
            paragraph.AppendText("Bold " & Constants.vbLf + Constants.vbLf).CharacterFormat.Bold = True
            paragraph.AppendText("DoubleStrike " & Constants.vbLf + Constants.vbLf).CharacterFormat.DoubleStrike = True
            paragraph.AppendText("Emboss " & Constants.vbLf + Constants.vbLf).CharacterFormat.Emboss = True
            paragraph.AppendText("Engrave " & Constants.vbLf + Constants.vbLf).CharacterFormat.Engrave = True
            paragraph.AppendText("Italic " & Constants.vbLf + Constants.vbLf).CharacterFormat.Italic = True
            paragraph.AppendText("Shadow " & Constants.vbLf + Constants.vbLf).CharacterFormat.Shadow = True
            paragraph.AppendText("SmallCaps " & Constants.vbLf + Constants.vbLf).CharacterFormat.SmallCaps = True
            paragraph.AppendText("Strikeout " & Constants.vbLf + Constants.vbLf).CharacterFormat.Strikeout = True
            paragraph.AppendText("Some Text")
            paragraph.AppendText("SubScript " & Constants.vbLf + Constants.vbLf).CharacterFormat.SubSuperScript = SubSuperScript.SubScript
            paragraph.AppendText("Some Text")
            paragraph.AppendText("SuperScript " & Constants.vbLf + Constants.vbLf).CharacterFormat.SubSuperScript = SubSuperScript.SuperScript
            paragraph.AppendText("TextBackgroundColor " & Constants.vbLf + Constants.vbLf).CharacterFormat.TextBackgroundColor = Color.LightBlue

            ' "Paragraph formattings"

            section = document.AddSection()
            section.BreakCode = SectionBreakCode.NoBreak
            paragraph = section.AddParagraph()
            paragraph.AppendText("Following paragraphs illustrates various paragraph formattings")

            paragraph = section.AddParagraph()
            paragraph.AppendText("We will use this paragraph to illustrate several Microsoft Word features using Essential DocIO. It will be used to illustrate Space Before, Space After, and Line Spacing. Space Before tells Microsoft Word how much space to leave before the paragraph. Space After tells Microsoft Word how much space to leave after the paragraph. Line Spacing sets the space between lines within a paragraph.It also explains about first line indentation,backcolor and paragraph border.")
            paragraph.ParagraphFormat.BeforeSpacing = 20.0F
            paragraph.ParagraphFormat.AfterSpacing = 30.0F
            paragraph.ParagraphFormat.BackColor = Color.LightGray
            paragraph.ParagraphFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single
            paragraph.ParagraphFormat.FirstLineIndent = 20.0F
            paragraph.ParagraphFormat.LineSpacing = 20.0F

            paragraph = section.AddParagraph()
            paragraph.AppendText("This is a sample paragraph. It is used to illustrate alignment. Left-justified text is aligned on the left. Right-justified text is aligned with on the right. Centered text is centered between the left and right margins. You can use Center to center your titles. Justified text is flush on both sides.")
            paragraph.ParagraphFormat.LineSpacing = 20.0F
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right
            paragraph.ParagraphFormat.LineSpacingRule = LineSpacingRule.Exactly

            section.AddParagraph()

            'Adding a new paragraph to the section.
            paragraph = section.AddParagraph()
            paragraph.ParagraphFormat.Keep = True
            paragraph.AppendText("KEEP TOGETHER").CharacterFormat.Bold = True
            paragraph.AppendText("This is a sample paragraph. It is used to illustrate Keep together of MsWord. You can control where Microsoft Word positions automatic page breaks (page break: The point at which one page ends and another begins. Microsoft Word inserts an 'automatic' (or soft) page break for you, or you can force a page break at a specific location by inserting a 'manual' (or hard) page break.) by setting pagination options.It keeps the lines in a paragraph together when there is page break").CharacterFormat.FontSize = 12.0F

            For i = 0 To 9
                paragraph.AppendText("Text Body_Text Body_Text Body_Text Body_Text Body_Text Body_Text Body").CharacterFormat.FontSize = 12.0F
                paragraph.ParagraphFormat.LineSpacing = 20.0F
            Next i
            paragraph.AppendText("KEEP TOGETHER END").CharacterFormat.Bold = True

            ' Adding a new section to the document.
            section = document.AddSection()
            ' Set Margin of the document
            section.PageSetup.Margins.Top = 20
            section.PageSetup.Margins.Bottom = 20
            section.PageSetup.Margins.Left = 50
            section.PageSetup.Margins.Right = 20
            ' Adding a new paragraph to the document.
            paragraph = section.AddParagraph()
            ' Writing text to the current paragraph.
            paragraph.AppendText("This document demonstrates the Bullets and Numbering functionality available in Essential DocIO")

            'Add a new section
            section1 = document.AddSection()
            'Adding two columns to the section.
            section1.Columns.Add(New Column(document))
            section1.Columns.Add(New Column(document))
            'Set the columns to be of equal width.
            section1.MakeColumnsEqual()

            ' Set section break code as NoBreak. 
            section1.BreakCode = SectionBreakCode.NoBreak

            ' Set formatting.
            ProductDetailsInBullets()

            ' Set Formatting.
            ProductDetailsInNumbers()

            ' Saving the document to disk.
            document.Save("Sample.doc", FormatType.Doc)

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

#Region "ProductDetailsInBullets"
        Private Sub ProductDetailsInBullets()
            ' Adding a new paragraph to the document.
            section1.AddParagraph()
            paragraph = section1.AddParagraph()

            ' Writing text to the document with formatting.
            textRange = paragraph.AppendText("List of Syncfusion products.")
            paragraph.ListFormat.ApplyDefBulletStyle()
            textRange.CharacterFormat.FontName = "Monotype Corsiva"
            textRange.CharacterFormat.FontSize = 15

            ' Writing Product details to the document with the specified list type.
            section1.AddParagraph()
            For Each s As String In products
                section1.AddParagraph()
                paragraph = section1.AddParagraph()
                paragraph.AppendText(String.Concat("Essential ", s))
                paragraph.ListFormat.ContinueListNumbering()
                paragraph.ListFormat.ListLevelNumber = 1

                section1.AddParagraph()
                For Each s1 As String In forms
                    If String.Equals(s, "HTMLUI") Then
                        paragraph = section1.AddParagraph()
                        paragraph.AppendText(String.Concat(s1, " Forms"))
                        paragraph.ListFormat.ContinueListNumbering()
                        paragraph.ListFormat.ListLevelNumber = 2

                        Exit For
                    Else
                        paragraph = section1.AddParagraph()
                        paragraph.AppendText(String.Concat(s1, " Forms"))
                        paragraph.ListFormat.ContinueListNumbering()
                        paragraph.ListFormat.ListLevelNumber = 2


                    End If
                Next s1
            Next s
        End Sub
#End Region

#Region "ProductDetailsInNumbers"
        Private Sub ProductDetailsInNumbers()
            ' Adding a new paragraph to the document.
            section1.AddParagraph()
            paragraph = section1.AddParagraph()

            ' Writing text to the document with formatting.
            textRange = paragraph.AppendText("List of Syncfusion products.")
            paragraph.ListFormat.ApplyDefNumberedStyle()
            textRange.CharacterFormat.FontName = "Monotype Corsiva"
            textRange.CharacterFormat.FontSize = 15

            ' Writing Product details to the document with the specified list type.
            section1.AddParagraph()
            For Each s As String In products
                section1.AddParagraph()
                paragraph = section1.AddParagraph()
                paragraph.AppendText(String.Concat("Essential ", s))
                paragraph.ListFormat.ContinueListNumbering()

                paragraph.ListFormat.ListLevelNumber = 1
                section1.AddParagraph()
                For Each s1 As String In forms
                    If String.Equals(s, "HTMLUI") Then
                        paragraph = section1.AddParagraph()
                        paragraph.AppendText(String.Concat(s1, " Forms"))
                        paragraph.ListFormat.ContinueListNumbering()

                        paragraph.ListFormat.ListLevelNumber = 2
                        Exit For
                    Else
                        paragraph = section1.AddParagraph()
                        paragraph.AppendText(String.Concat(s1, " Forms"))
                        paragraph.ListFormat.ContinueListNumbering()

                        paragraph.ListFormat.ListLevelNumber = 2

                    End If
                Next s1
            Next s
        End Sub
#End Region

    End Class
End Namespace
