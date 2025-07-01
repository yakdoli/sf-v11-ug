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
        Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents textBox1 As System.Windows.Forms.TextBox
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents Label1 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents Label6 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
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
            Me.comboBox1 = New System.Windows.Forms.ComboBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            Me.label3 = New System.Windows.Forms.Label()
            Me.Label6 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2003RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2007RadioBtn = New System.Windows.Forms.RadioButton()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
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
            Me.button1.Location = New System.Drawing.Point(282, 262)
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
            Me.label2.Location = New System.Drawing.Point(0, 107)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(374, 58)
            Me.label2.TabIndex = 73
            Me.label2.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" & _
        "ote that MS Word Viewer or MS Word is required to view the resultant document."
            '
            'comboBox1
            '
            Me.comboBox1.FormattingEnabled = True
            Me.comboBox1.Items.AddRange(New Object() {"AllowOnlyFormFields", "AllowOnlyComments", "AllowOnlyRevisions", "AllowOnlyReading"})
            Me.comboBox1.Location = New System.Drawing.Point(124, 157)
            Me.comboBox1.Name = "comboBox1"
            Me.comboBox1.Size = New System.Drawing.Size(198, 21)
            Me.comboBox1.TabIndex = 112
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(0, 158)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(103, 16)
            Me.label5.TabIndex = 111
            Me.label5.Text = "Protection Type"
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(0, 191)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(68, 16)
            Me.label4.TabIndex = 110
            Me.label4.Text = "Password"
            '
            'textBox1
            '
            Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.textBox1.Location = New System.Drawing.Point(124, 185)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.textBox1.Size = New System.Drawing.Size(198, 26)
            Me.textBox1.TabIndex = 109
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.Label1)
            Me.groupBox1.Controls.Add(Me.word2013RadioBtn)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.Label6)
            Me.groupBox1.Controls.Add(Me.label24)
            Me.groupBox1.Controls.Add(Me.word2010RadioBtn)
            Me.groupBox1.Controls.Add(Me.word2003RadioBtn)
            Me.groupBox1.Controls.Add(Me.word2007RadioBtn)
            Me.groupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(3, 217)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(251, 70)
            Me.groupBox1.TabIndex = 113
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Save As"
            '
            'Label1
            '
            Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
            Me.Label1.Location = New System.Drawing.Point(221, 48)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(20, 18)
            Me.Label1.TabIndex = 104
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
            Me.label3.Location = New System.Drawing.Point(104, 48)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(20, 18)
            Me.label3.TabIndex = 102
            '
            'Label6
            '
            Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
            Me.Label6.Location = New System.Drawing.Point(221, 20)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(20, 18)
            Me.Label6.TabIndex = 101
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(104, 20)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
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
            Me.ClientSize = New System.Drawing.Size(374, 297)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.comboBox1)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.button1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Document Protection"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region

#Region "Button Click"

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            'Get Template document and database path.
            Dim dataPath As String = Application.StartupPath + "\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"

            Dim document As WordDocument
            Dim protectionType As ProtectionType

            'Loads the template document.
            If comboBox1.SelectedIndex = 0 Then
                document = New WordDocument(Path.Combine(dataPath, "TemplateFormFields.doc"))
                ' Sets the protection type as allow only Form Fields.
                protectionType = protectionType.AllowOnlyFormFields
            ElseIf comboBox1.SelectedIndex = 1 Then
                document = New WordDocument(Path.Combine(dataPath, "TemplateComments.doc"))
                ' Sets the protection type as allow only Comments.
                protectionType = protectionType.AllowOnlyComments
            ElseIf comboBox1.SelectedIndex = 2 Then
                document = New WordDocument(Path.Combine(dataPath, "TemplateRevisions.doc"))
                ' Enables track changes in the document.
                document.TrackChanges = True
                ' Sets the protection type as allow only Revisions.
                protectionType = protectionType.AllowOnlyRevisions
            Else
                document = New WordDocument(Path.Combine(dataPath, "Essential DocIO.doc"))
                ' Sets the protection type as allow only Reading.
                protectionType = protectionType.AllowOnlyReading
            End If

            ' Enforces protection of the document.
            If String.IsNullOrEmpty(textBox1.Text) Then
                document.Protect(protectionType)
            Else
                document.Protect(protectionType, textBox1.Text)
            End If

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

        Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
            comboBox1.SelectedIndex = 0
        End Sub
    End Class
End Namespace
