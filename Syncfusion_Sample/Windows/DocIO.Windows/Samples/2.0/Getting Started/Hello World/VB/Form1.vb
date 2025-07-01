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
#Region "Private Members"
        Private components As System.ComponentModel.IContainer
        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents Label6 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label1 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label5 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents word2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2007RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents label2 As System.Windows.Forms.Label
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.button1 = New System.Windows.Forms.Button()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
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
            Me.button1.Location = New System.Drawing.Point(282, 215)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(80, 25)
            Me.button1.TabIndex = 68
            Me.button1.Text = "Generate"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
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
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(8, 94)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(366, 58)
            Me.label2.TabIndex = 73
            Me.label2.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" & _
        "ote that MS Word Viewer or MS Word is required to view the resultant document."
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
            Me.GroupBox2.Location = New System.Drawing.Point(11, 167)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(251, 72)
            Me.GroupBox2.TabIndex = 105
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Save As"
            '
            'Label6
            '
            Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
            Me.Label6.Location = New System.Drawing.Point(221, 48)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(20, 18)
            Me.Label6.TabIndex = 106
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
            'Label1
            '
            Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
            Me.Label1.Location = New System.Drawing.Point(106, 48)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(20, 18)
            Me.Label1.TabIndex = 104
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
            'Label5
            '
            Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
            Me.Label5.Location = New System.Drawing.Point(221, 20)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(20, 18)
            Me.Label5.TabIndex = 101
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(106, 22)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
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
            Me.ClientSize = New System.Drawing.Size(374, 256)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.button1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Hello World"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Button Click"

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            'Getting Image files path.
            Dim dataPath As String = Application.StartupPath + "\..\..\..\..\..\..\..\..\..\Common\images\DocIO\"

            'A new document is created.
            Dim document As New WordDocument()
            'Adding a new section to the document.
            Dim section As WSection = TryCast(document.AddSection(), WSection)
            'Set Margin of the section
            section.PageSetup.Margins.All = 72
            'Set page size of the section
            section.PageSetup.PageSize = New SizeF(612, 792)
            'Create Paragraph styles
            Dim style As WParagraphStyle = TryCast(document.AddParagraphStyle("Normal"), WParagraphStyle)
            style.CharacterFormat.FontName = "Calibri"
            style.CharacterFormat.FontSize = 11.0F
            style.ParagraphFormat.BeforeSpacing = 0
            style.ParagraphFormat.AfterSpacing = 8
            style.ParagraphFormat.LineSpacing = 13.8F

            style = TryCast(document.AddParagraphStyle("Heading 1"), WParagraphStyle)
            style.ApplyBaseStyle("Normal")
            style.CharacterFormat.FontName = "Calibri Light"
            style.CharacterFormat.FontSize = 16.0F
            style.CharacterFormat.TextColor = Color.FromArgb(46, 116, 181)
            style.ParagraphFormat.BeforeSpacing = 12
            style.ParagraphFormat.AfterSpacing = 0
            style.ParagraphFormat.Keep = True
            style.ParagraphFormat.KeepFollow = True
            style.ParagraphFormat.OutlineLevel = OutlineLevel.Level1

            'Appends paragraph.
            Dim paragraph As IWParagraph = section.AddParagraph()
            paragraph.ApplyStyle("Heading 1")
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            Dim textRange As WTextRange = TryCast(paragraph.AppendText("Syncfusion Metro Studio"), WTextRange)
            textRange.CharacterFormat.FontSize = 18.0F
            textRange.CharacterFormat.FontName = "Calibri"

            'Appends paragraph.
            paragraph = section.AddParagraph()
            paragraph.ParagraphFormat.FirstLineIndent = 36

            'Appends paragraph.
            paragraph = section.AddParagraph()
            paragraph.ParagraphFormat.FirstLineIndent = 36
            paragraph.BreakCharacterFormat.FontSize = 12.0F
            textRange = TryCast(paragraph.AppendText("Syncfusion Metro Studio is a collection of over 1700 Metro-style icon templates that can be easily customized to create thousands of unique Metro icons. Metro is a design language so it can be applied to any platform or technology. At Syncfusion we have used these icons in everything from PowerPoint presentations to applications written in all .NET platforms including WPF, Silverlight, Windows Phone, Windows Forms, ASP.NET, and ASP.NET MVC."), WTextRange)
            textRange.CharacterFormat.FontSize = 12.0F


            'Appends table.
            Dim table As IWTable = section.AddTable()
            table.ResetCells(3, 2)
            table.TableFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.None
            table.TableFormat.IsAutoResized = True

            'Appends paragraph.
            paragraph = table(0, 0).AddParagraph()
            paragraph.ParagraphFormat.AfterSpacing = 0
            paragraph.BreakCharacterFormat.FontSize = 12.0F
            'Appends picture to the paragraph.
            Dim picture As WPicture = TryCast(paragraph.AppendPicture(Image.FromFile(dataPath + "MetroStudio1.png")), WPicture)
            picture.TextWrappingStyle = TextWrappingStyle.TopAndBottom
            picture.VerticalOrigin = VerticalOrigin.Paragraph
            picture.VerticalPosition = 0
            picture.HorizontalOrigin = HorizontalOrigin.Column
            picture.HorizontalPosition = -5.15F
            picture.WidthScale = 79
            picture.HeightScale = 79

            'Appends paragraph.
            paragraph = table(0, 1).AddParagraph()
            paragraph.ApplyStyle("Heading 1")
            paragraph.ParagraphFormat.AfterSpacing = 0
            paragraph.ParagraphFormat.LineSpacing = 12.0F
            paragraph.AppendText("Developer-friendly icon editor ")
            'Appends paragraph.
            paragraph = table(0, 1).AddParagraph()
            paragraph.ParagraphFormat.AfterSpacing = 0
            paragraph.ParagraphFormat.LineSpacing = 12.0F
            paragraph.BreakCharacterFormat.FontSize = 12.0F
            paragraph.BreakCharacterFormat.FontName = "Times New Roman"
            textRange = TryCast(paragraph.AppendText("Metro Studio includes a powerful icon editor that lets you quickly find and customize all the icons that you need in only a few minutes. "), WTextRange)
            textRange.CharacterFormat.FontSize = 12.0F
            textRange.CharacterFormat.FontName = "Times New Roman"
            'Appends paragraph.
            paragraph = table(0, 1).AddParagraph()
            paragraph.ParagraphFormat.AfterSpacing = 0
            paragraph.ParagraphFormat.LineSpacing = 12.0F
            paragraph.BreakCharacterFormat.FontSize = 12.0F

            'Appends paragraph.
            paragraph = table(1, 0).AddParagraph()
            paragraph.ApplyStyle("Heading 1")
            paragraph.ParagraphFormat.AfterSpacing = 0
            paragraph.ParagraphFormat.LineSpacing = 12.0F
            paragraph.AppendText("Convert fonts to icons ")
            'Appends paragraph.
            paragraph = table(1, 0).AddParagraph()
            paragraph.ParagraphFormat.AfterSpacing = 0
            paragraph.ParagraphFormat.LineSpacing = 12.0F
            paragraph.BreakCharacterFormat.FontSize = 12.0F
            paragraph.BreakCharacterFormat.FontName = "Times New Roman"
            textRange = TryCast(paragraph.AppendText("Easily customize thousands of font characters as icons and export them to the desired formats. "), WTextRange)
            textRange.CharacterFormat.FontSize = 12.0F
            textRange.CharacterFormat.FontName = "Times New Roman"
            'Appends paragraph.
            paragraph = table(1, 0).AddParagraph()
            paragraph.ParagraphFormat.AfterSpacing = 0
            paragraph.ParagraphFormat.LineSpacing = 12.0F
            paragraph.BreakCharacterFormat.FontSize = 12.0F

            'Appends paragraph.
            paragraph = table(1, 1).AddParagraph()
            paragraph.ApplyStyle("Heading 1")
            paragraph.ParagraphFormat.LineSpacing = 12.0F
            'Appends picture to the paragraph.
            picture = TryCast(paragraph.AppendPicture(Image.FromFile(dataPath + "MetroStudio2.png")), WPicture)
            picture.TextWrappingStyle = TextWrappingStyle.TopAndBottom
            picture.VerticalOrigin = VerticalOrigin.Paragraph
            picture.VerticalPosition = 8.2F
            picture.HorizontalOrigin = HorizontalOrigin.Column
            picture.HorizontalPosition = -14.95F
            picture.WidthScale = 75
            picture.HeightScale = 75

            'Appends paragraph.
            paragraph = table(2, 0).AddParagraph()
            paragraph.ApplyStyle("Heading 1")
            paragraph.ParagraphFormat.LineSpacing = 12.0F
            picture = TryCast(paragraph.AppendPicture(Image.FromFile(dataPath + "MetroStudio3.png")), WPicture)
            picture.TextWrappingStyle = TextWrappingStyle.TopAndBottom
            picture.VerticalOrigin = VerticalOrigin.Paragraph
            picture.VerticalPosition = 0
            picture.HorizontalOrigin = HorizontalOrigin.Column
            picture.HorizontalPosition = -4.9F
            picture.WidthScale = 92
            picture.HeightScale = 92

            'Appends paragraph.
            paragraph = table(2, 1).AddParagraph()
            paragraph.ApplyStyle("Heading 1")
            paragraph.ParagraphFormat.AfterSpacing = 0
            paragraph.ParagraphFormat.LineSpacing = 12.0F
            paragraph.AppendText("Organize icons as projects ")
            'Appends paragraph.
            paragraph = table(2, 1).AddParagraph()
            paragraph.ParagraphFormat.AfterSpacing = 0
            paragraph.ParagraphFormat.LineSpacing = 12.0F
            paragraph.BreakCharacterFormat.FontSize = 12.0F
            paragraph.BreakCharacterFormat.FontName = "Times New Roman"
            textRange = TryCast(paragraph.AppendText("Organize icons into projects that can be serialized for modification at a later time. Multiple icons in a project can be exported with a single click. "), WTextRange)
            textRange.CharacterFormat.FontSize = 12.0F
            textRange.CharacterFormat.FontName = "Times New Roman"
            'Appends paragraph.
            paragraph = table(2, 1).AddParagraph()
            paragraph.ApplyStyle("Heading 1")
            paragraph.ParagraphFormat.LineSpacing = 12.0F


            'Appends paragraph.
            section.AddParagraph()

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
