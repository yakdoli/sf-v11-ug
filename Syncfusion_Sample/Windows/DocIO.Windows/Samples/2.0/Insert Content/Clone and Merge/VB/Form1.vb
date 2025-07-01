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
        Private label2 As Label
        Private toolTip1 As ToolTip
        Private pictureBox1 As PictureBox
        Private WithEvents browseBtn As Button
        Private textBox1 As TextBox
        Private openFileDialog1 As OpenFileDialog
        Private WithEvents Button2 As Button
        Private textBox2 As TextBox
        Private Label4 As Label
        Private label9 As Label
        Private label5 As Label
        Private label6 As Label
        Private label7 As Label
        Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents comboBoxImportOptions As System.Windows.Forms.ComboBox
        Private WithEvents label8 As System.Windows.Forms.Label
        Private WithEvents radioButtonImport As System.Windows.Forms.RadioButton
        Private WithEvents radioButtonClone As System.Windows.Forms.RadioButton
        Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents Label1 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label3 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label10 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents word2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2007RadioBtn As System.Windows.Forms.RadioButton
        Private components As IContainer

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
            InitializeComponent()
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
            Me.label6 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label3 = New System.Windows.Forms.Label()
            Me.Label10 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.browseBtn = New System.Windows.Forms.Button()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.textBox2 = New System.Windows.Forms.TextBox()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.label9 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.comboBoxImportOptions = New System.Windows.Forms.ComboBox()
            Me.label8 = New System.Windows.Forms.Label()
            Me.radioButtonImport = New System.Windows.Forms.RadioButton()
            Me.radioButtonClone = New System.Windows.Forms.RadioButton()
            Me.GroupBox1 = New System.Windows.Forms.GroupBox()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2003RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2007RadioBtn = New System.Windows.Forms.RadioButton()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox2.SuspendLayout()
            Me.GroupBox1.SuspendLayout()
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
            Me.button1.Location = New System.Drawing.Point(266, 414)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(79, 25)
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
            'label6
            '
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Image)
            Me.label6.Location = New System.Drawing.Point(350, 188)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(20, 18)
            Me.label6.TabIndex = 118
            Me.toolTip1.SetToolTip(Me.label6, "Browse the word document to clone")
            '
            'label7
            '
            Me.label7.Image = CType(resources.GetObject("label7.Image"), System.Drawing.Image)
            Me.label7.Location = New System.Drawing.Point(350, 225)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(20, 18)
            Me.label7.TabIndex = 119
            Me.toolTip1.SetToolTip(Me.label7, "Browse the word document to clone")
            '
            'Label1
            '
            Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
            Me.Label1.Location = New System.Drawing.Point(221, 48)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(20, 18)
            Me.Label1.TabIndex = 106
            Me.toolTip1.SetToolTip(Me.Label1, "Saves the document in Word 2013 format")
            '
            'Label3
            '
            Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
            Me.Label3.Location = New System.Drawing.Point(107, 48)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(20, 18)
            Me.Label3.TabIndex = 104
            Me.toolTip1.SetToolTip(Me.Label3, "Saves the document in Word 2010 format")
            '
            'Label10
            '
            Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
            Me.Label10.Location = New System.Drawing.Point(221, 20)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(20, 18)
            Me.Label10.TabIndex = 101
            Me.toolTip1.SetToolTip(Me.Label10, "Saves the document in Word 2007 format")
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(107, 20)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.toolTip1.SetToolTip(Me.label24, "Saves the document in Word 97-2003 format")
            '
            'browseBtn
            '
            Me.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.browseBtn.Location = New System.Drawing.Point(324, 185)
            Me.browseBtn.Name = "browseBtn"
            Me.browseBtn.Size = New System.Drawing.Size(21, 21)
            Me.browseBtn.TabIndex = 103
            Me.browseBtn.Text = ". . ."
            Me.browseBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.browseBtn.UseVisualStyleBackColor = True
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(128, 185)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(190, 20)
            Me.textBox1.TabIndex = 102
            '
            'openFileDialog1
            '
            Me.openFileDialog1.FileName = "openFileDialog1"
            '
            'Button2
            '
            Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.Button2.Location = New System.Drawing.Point(324, 222)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(21, 21)
            Me.Button2.TabIndex = 116
            Me.Button2.Text = ". . ."
            Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.Button2.UseVisualStyleBackColor = True
            '
            'textBox2
            '
            Me.textBox2.Location = New System.Drawing.Point(127, 222)
            Me.textBox2.Name = "textBox2"
            Me.textBox2.Size = New System.Drawing.Size(191, 20)
            Me.textBox2.TabIndex = 115
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!)
            Me.Label4.Location = New System.Drawing.Point(12, 225)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(109, 13)
            Me.Label4.TabIndex = 114
            Me.Label4.Text = "Second document"
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Verdana", 8.25!)
            Me.label9.Location = New System.Drawing.Point(12, 188)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(91, 13)
            Me.label9.TabIndex = 113
            Me.label9.Text = "First document"
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label5.Location = New System.Drawing.Point(5, 153)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(209, 22)
            Me.label5.TabIndex = 117
            Me.label5.Text = "Select Word Documents to Clone"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.comboBoxImportOptions)
            Me.groupBox2.Controls.Add(Me.label8)
            Me.groupBox2.Controls.Add(Me.radioButtonImport)
            Me.groupBox2.Controls.Add(Me.radioButtonClone)
            Me.groupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.groupBox2.Location = New System.Drawing.Point(3, 252)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(369, 96)
            Me.groupBox2.TabIndex = 121
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "Clone and Merge Options"
            '
            'comboBoxImportOptions
            '
            Me.comboBoxImportOptions.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.comboBoxImportOptions.FormattingEnabled = True
            Me.comboBoxImportOptions.Items.AddRange(New Object() {"KeepSourceFormatting", "MergeFormatting", "KeepTextOnly", "UseDestinationStyles"})
            Me.comboBoxImportOptions.Location = New System.Drawing.Point(139, 64)
            Me.comboBoxImportOptions.Name = "comboBoxImportOptions"
            Me.comboBoxImportOptions.Size = New System.Drawing.Size(195, 21)
            Me.comboBoxImportOptions.TabIndex = 88
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Verdana", 8.25!)
            Me.label8.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label8.Location = New System.Drawing.Point(28, 67)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(91, 13)
            Me.label8.TabIndex = 87
            Me.label8.Text = "Import options"
            '
            'radioButtonImport
            '
            Me.radioButtonImport.AutoSize = True
            Me.radioButtonImport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
            Me.radioButtonImport.ForeColor = System.Drawing.SystemColors.ControlText
            Me.radioButtonImport.Location = New System.Drawing.Point(12, 43)
            Me.radioButtonImport.Name = "radioButtonImport"
            Me.radioButtonImport.Size = New System.Drawing.Size(244, 17)
            Me.radioButtonImport.TabIndex = 85
            Me.radioButtonImport.Text = "Use Import contents functionality"
            Me.radioButtonImport.UseVisualStyleBackColor = True
            '
            'radioButtonClone
            '
            Me.radioButtonClone.AutoSize = True
            Me.radioButtonClone.Checked = True
            Me.radioButtonClone.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
            Me.radioButtonClone.ForeColor = System.Drawing.SystemColors.ControlText
            Me.radioButtonClone.Location = New System.Drawing.Point(12, 20)
            Me.radioButtonClone.Name = "radioButtonClone"
            Me.radioButtonClone.Size = New System.Drawing.Size(175, 17)
            Me.radioButtonClone.TabIndex = 84
            Me.radioButtonClone.TabStop = True
            Me.radioButtonClone.Text = "Use Clone functionality"
            Me.radioButtonClone.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label1)
            Me.GroupBox1.Controls.Add(Me.word2013RadioBtn)
            Me.GroupBox1.Controls.Add(Me.Label3)
            Me.GroupBox1.Controls.Add(Me.word2010RadioBtn)
            Me.GroupBox1.Controls.Add(Me.Label10)
            Me.GroupBox1.Controls.Add(Me.label24)
            Me.GroupBox1.Controls.Add(Me.word2003RadioBtn)
            Me.GroupBox1.Controls.Add(Me.word2007RadioBtn)
            Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox1.Location = New System.Drawing.Point(3, 366)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(251, 72)
            Me.GroupBox1.TabIndex = 122
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Save As"
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
            Me.ClientSize = New System.Drawing.Size(374, 462)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.label7)
            Me.Controls.Add(Me.label6)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.textBox2)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.browseBtn)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.button1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Clone and Merge"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
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

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            ' Creating a new document.
            Dim doc As WordDocument = New WordDocument()

            If radioButtonImport.Checked Then
                ' Imports the first template document
                If DirectCast(textBox1.Tag, String) <> String.Empty Then
                    doc.ImportContent(New WordDocument(DirectCast(textBox1.Tag, String)), DirectCast(comboBoxImportOptions.SelectedIndex, ImportOptions))
                Else
                    MessageBox.Show("Browse a Word document to import", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                ' Imports the second template document
                If DirectCast(textBox2.Tag, String) <> String.Empty Then
                    doc.ImportContent(New WordDocument(DirectCast(textBox2.Tag, String)), DirectCast(comboBoxImportOptions.SelectedIndex, ImportOptions))
                Else
                    MessageBox.Show("Browse a Word document to import", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                ' Clones the first template document
                If DirectCast(textBox1.Tag, String) <> String.Empty Then
                    CloneDocument(doc, DirectCast(textBox1.Tag, String))
                Else
                    MessageBox.Show("Browse a Word document to clone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
                ' Clones the second template document
                If DirectCast(textBox2.Tag, String) <> String.Empty Then
                    CloneDocument(doc, DirectCast(textBox2.Tag, String))
                Else
                    MessageBox.Show("Browse a Word document to clone", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If

            'Save as word 2003 format
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
                'Save as word 2010  format
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
                        MessageBox.Show("Word 2010 is not installed in this system")
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

        ''' <summary>
        ''' Clones the document.
        ''' </summary>
        ''' <param name="srcDoc">The SRC doc.</param>
        ''' <param name="fileName">Name of the file.</param>
        Private Sub CloneDocument(ByVal srcDoc As WordDocument, ByVal fileName As String)
            If File.Exists(fileName) Then
                ' Read the template document
                Dim document As New WordDocument(fileName)
                ' Enumerate all the sections from the template document.
                For Each sec As IWSection In document.Sections
                    ' Cloning all the sections one by one and merging it to the new document.
                    srcDoc.Sections.Add(sec.Clone())
                    ' Setting section break code to be the same as the template.
                    srcDoc.LastSection.BreakCode = sec.BreakCode
                Next
            Else
                MessageBox.Show("File doesn�t exist")
            End If
        End Sub

        Private Sub browseBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles browseBtn.Click
            openFileDialog1.InitialDirectory = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"
            openFileDialog1.FileName = ""
            Dim result As DialogResult = openFileDialog1.ShowDialog()

            If result = DialogResult.OK Then
                Me.textBox1.Text = openFileDialog1.SafeFileName
                Me.textBox1.Tag = openFileDialog1.FileName
            End If
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Me.textBox1.Text = "Essential DocIO.doc"
            Me.textBox1.Tag = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\Essential DocIO.doc"
            Me.textBox2.Text = "Essential Pdf.doc"
            Me.textBox2.Tag = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\Essential Pdf.doc"
            Me.comboBoxImportOptions.SelectedIndex = 0
            Me.label8.Enabled = False
            Me.comboBoxImportOptions.Enabled = False
        End Sub

        Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button2.Click
            openFileDialog1.InitialDirectory = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"
            openFileDialog1.FileName = ""
            Dim result As DialogResult = openFileDialog1.ShowDialog()

            If result = DialogResult.OK Then
                Me.textBox2.Text = openFileDialog1.SafeFileName
                Me.textBox2.Tag = openFileDialog1.FileName
            End If
        End Sub

        Private Sub radioButtonImport_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioButtonImport.CheckedChanged
            If TryCast(sender, RadioButton).Checked Then
                Me.comboBoxImportOptions.Enabled = True
                Me.label8.Enabled = True
            Else
                Me.comboBoxImportOptions.Enabled = False
                Me.label8.Enabled = False
            End If
        End Sub
    End Class
End Namespace
