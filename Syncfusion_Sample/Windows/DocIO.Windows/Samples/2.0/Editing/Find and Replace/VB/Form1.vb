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
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private label3 As System.Windows.Forms.Label
		Private textBoxFileName As System.Windows.Forms.TextBox
		Private textBoxFind As System.Windows.Forms.TextBox
		Private textBoxReplace As System.Windows.Forms.TextBox
		Private WithEvents checkBoxMatchCase As System.Windows.Forms.CheckBox
		Private WithEvents checkBoxMatchWord As System.Windows.Forms.CheckBox
		Private groupBox1 As GroupBox
		Private WithEvents button1 As Button
		Private WithEvents buttonReplace As Button
        Private pictureBox1 As PictureBox
        Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
        Private WithEvents word2007RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents Label5 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label4 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label6 As System.Windows.Forms.Label
        Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
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
            Me.label1 = New System.Windows.Forms.Label()
            Me.textBoxFileName = New System.Windows.Forms.TextBox()
            Me.label2 = New System.Windows.Forms.Label()
            Me.textBoxFind = New System.Windows.Forms.TextBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.textBoxReplace = New System.Windows.Forms.TextBox()
            Me.checkBoxMatchCase = New System.Windows.Forms.CheckBox()
            Me.checkBoxMatchWord = New System.Windows.Forms.CheckBox()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.button1 = New System.Windows.Forms.Button()
            Me.buttonReplace = New System.Windows.Forms.Button()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.label24 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.word2007RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2003RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.groupBox1.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(12, 116)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(83, 15)
            Me.label1.TabIndex = 0
            Me.label1.Text = "&Look in          :  "
            '
            'textBoxFileName
            '
            Me.textBoxFileName.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxFileName.Location = New System.Drawing.Point(92, 116)
            Me.textBoxFileName.Name = "textBoxFileName"
            Me.textBoxFileName.Size = New System.Drawing.Size(232, 21)
            Me.textBoxFileName.TabIndex = 1
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(12, 146)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(77, 15)
            Me.label2.TabIndex = 3
            Me.label2.Text = "Fi&nd what      :"
            '
            'textBoxFind
            '
            Me.textBoxFind.Enabled = False
            Me.textBoxFind.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxFind.Location = New System.Drawing.Point(92, 146)
            Me.textBoxFind.Name = "textBoxFind"
            Me.textBoxFind.Size = New System.Drawing.Size(232, 21)
            Me.textBoxFind.TabIndex = 4
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(12, 176)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(82, 15)
            Me.label3.TabIndex = 5
            Me.label3.Text = "Re&place with  : "
            '
            'textBoxReplace
            '
            Me.textBoxReplace.Enabled = False
            Me.textBoxReplace.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBoxReplace.Location = New System.Drawing.Point(92, 176)
            Me.textBoxReplace.Name = "textBoxReplace"
            Me.textBoxReplace.Size = New System.Drawing.Size(232, 21)
            Me.textBoxReplace.TabIndex = 6
            '
            'checkBoxMatchCase
            '
            Me.checkBoxMatchCase.Enabled = False
            Me.checkBoxMatchCase.Location = New System.Drawing.Point(6, 19)
            Me.checkBoxMatchCase.Name = "checkBoxMatchCase"
            Me.checkBoxMatchCase.Size = New System.Drawing.Size(104, 17)
            Me.checkBoxMatchCase.TabIndex = 7
            Me.checkBoxMatchCase.Text = "Match &case"
            '
            'checkBoxMatchWord
            '
            Me.checkBoxMatchWord.Enabled = False
            Me.checkBoxMatchWord.Location = New System.Drawing.Point(6, 47)
            Me.checkBoxMatchWord.Name = "checkBoxMatchWord"
            Me.checkBoxMatchWord.Size = New System.Drawing.Size(128, 19)
            Me.checkBoxMatchWord.TabIndex = 8
            Me.checkBoxMatchWord.Text = "Match &whole word"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.checkBoxMatchWord)
            Me.groupBox1.Controls.Add(Me.checkBoxMatchCase)
            Me.groupBox1.Location = New System.Drawing.Point(15, 238)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(142, 75)
            Me.groupBox1.TabIndex = 12
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Search Options"
            '
            'button1
            '
            Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button1.BackColor = System.Drawing.Color.Transparent
            Me.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.button1.Location = New System.Drawing.Point(353, 116)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(55, 21)
            Me.button1.TabIndex = 13
            Me.button1.Text = "Browse"
            Me.button1.UseVisualStyleBackColor = False
            '
            'buttonReplace
            '
            Me.buttonReplace.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.buttonReplace.BackColor = System.Drawing.Color.Transparent
            Me.buttonReplace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.buttonReplace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.buttonReplace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.buttonReplace.Image = CType(resources.GetObject("buttonReplace.Image"), System.Drawing.Image)
            Me.buttonReplace.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.buttonReplace.Location = New System.Drawing.Point(337, 328)
            Me.buttonReplace.Name = "buttonReplace"
            Me.buttonReplace.Size = New System.Drawing.Size(71, 25)
            Me.buttonReplace.TabIndex = 14
            Me.buttonReplace.Text = "Replace"
            Me.buttonReplace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.buttonReplace.UseVisualStyleBackColor = False
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(-1, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(430, 95)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 26
            Me.pictureBox1.TabStop = False
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(106, 22)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.ToolTip1.SetToolTip(Me.label24, "Saves the document in Word 97-2003 format")
            '
            'Label5
            '
            Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
            Me.Label5.Location = New System.Drawing.Point(221, 20)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(20, 18)
            Me.Label5.TabIndex = 101
            Me.ToolTip1.SetToolTip(Me.Label5, "Saves the document in Word 2007 format")
            '
            'Label4
            '
            Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
            Me.Label4.Location = New System.Drawing.Point(106, 48)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(20, 18)
            Me.Label4.TabIndex = 104
            Me.ToolTip1.SetToolTip(Me.Label4, "Saves the document in Word 2010 format")
            '
            'Label6
            '
            Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
            Me.Label6.Location = New System.Drawing.Point(221, 48)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(20, 18)
            Me.Label6.TabIndex = 106
            Me.ToolTip1.SetToolTip(Me.Label6, "Saves the document in Word 2013 format")
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
            Me.GroupBox2.Location = New System.Drawing.Point(167, 241)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(251, 72)
            Me.GroupBox2.TabIndex = 100
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Save As"
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(426, 362)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.buttonReplace)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.textBoxReplace)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.textBoxFind)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.textBoxFileName)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.groupBox1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Find and Replace"
            Me.groupBox1.ResumeLayout(False)
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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

        Private docFileName As String = Nothing
        Private matchCase, wholeWord As Boolean
        Private doc As WordDocument

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' Initialize variables.
            matchCase = False
            wholeWord = False

        End Sub

        Private Sub buttonBrowse_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            ' Create a openfile dialog box for open an existing word document.
            Dim file As OpenFileDialog = New OpenFileDialog()
            ' set the file filter type as document.
            file.Filter = "Document Files (*.doc)|*.doc"
            file.InitialDirectory = Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"
            ' Show the open file dialog box.
            If file.ShowDialog() = DialogResult.OK Then
                docFileName = file.FileName
                textBoxFileName.Text = Path.GetFileName(docFileName)

                ' Make controls enable state.
                textBoxFileName.Enabled = False
                textBoxFind.Enabled = True
                textBoxReplace.Enabled = True
                checkBoxMatchCase.Enabled = True
                checkBoxMatchWord.Enabled = True
                buttonReplace.Enabled = True
            End If
        End Sub

        Private Sub buttonReplace_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonReplace.Click
            ' Checking whether the find and replacement text boxes are filled.
            If textBoxFind.Text.Trim() = "" OrElse textBoxReplace.Text.Trim() = "" Then
                MessageBox.Show("Please fill the find and replacement text in appropriate textboxes...", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Try
                ' Open an existing word document.
                doc = New WordDocument(docFileName)

                ' Replace the text.
                doc.Replace(textBoxFind.Text, textBoxReplace.Text, matchCase, wholeWord)

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
                MessageBox.Show(Ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Sub checkBoxMatchCase_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxMatchCase.CheckedChanged
            If checkBoxMatchCase.Checked Then
                matchCase = True
            Else
                matchCase = False
            End If
        End Sub

        Private Sub checkBoxMatchWord_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles checkBoxMatchWord.CheckedChanged
            If checkBoxMatchWord.Checked Then
                wholeWord = True
            Else
                wholeWord = False
            End If
        End Sub
    End Class
End Namespace
