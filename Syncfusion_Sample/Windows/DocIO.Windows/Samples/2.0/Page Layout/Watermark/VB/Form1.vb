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

Imports Syncfusion.DocIO.DLS

Namespace EssentialDocIOSamples
    Public Class Form1 : Inherits System.Windows.Forms.Form

#Region "Private Members"

        Private components As System.ComponentModel.IContainer
        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents panel2 As System.Windows.Forms.Panel
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents rdbTextWatermark As System.Windows.Forms.RadioButton
        Private WithEvents rdbPicWatermark As System.Windows.Forms.RadioButton
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents label7 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2007RadioBtn As System.Windows.Forms.RadioButton
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
            Me.label3 = New System.Windows.Forms.Label()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.button1 = New System.Windows.Forms.Button()
            Me.label2 = New System.Windows.Forms.Label()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.panel2 = New System.Windows.Forms.Panel()
            Me.rdbTextWatermark = New System.Windows.Forms.RadioButton()
            Me.rdbPicWatermark = New System.Windows.Forms.RadioButton()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2003RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2007RadioBtn = New System.Windows.Forms.RadioButton()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel2.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'label3
            '
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Image)
            Me.label3.Location = New System.Drawing.Point(81, 14)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(20, 20)
            Me.label3.TabIndex = 52
            Me.toolTip1.SetToolTip(Me.label3, "Saves the Document in Microsoft Word 2003 format")
            '
            'label4
            '
            Me.label4.Image = CType(resources.GetObject("label4.Image"), System.Drawing.Image)
            Me.label4.Location = New System.Drawing.Point(81, 42)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(20, 20)
            Me.label4.TabIndex = 53
            Me.toolTip1.SetToolTip(Me.label4, "Saves the Document in Microsoft Word 2007 format")
            '
            'label1
            '
            Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Image)
            Me.label1.Location = New System.Drawing.Point(221, 48)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(20, 18)
            Me.label1.TabIndex = 104
            Me.toolTip1.SetToolTip(Me.label1, "Saves the document in Word 2013 format")
            '
            'label6
            '
            Me.label6.Image = CType(resources.GetObject("label6.Image"), System.Drawing.Image)
            Me.label6.Location = New System.Drawing.Point(106, 48)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(20, 18)
            Me.label6.TabIndex = 102
            Me.toolTip1.SetToolTip(Me.label6, "Saves the document in Word 2010 format")
            '
            'label7
            '
            Me.label7.Image = CType(resources.GetObject("label7.Image"), System.Drawing.Image)
            Me.label7.Location = New System.Drawing.Point(221, 20)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(20, 18)
            Me.label7.TabIndex = 101
            Me.toolTip1.SetToolTip(Me.label7, "Saves the document in Word 2007 format")
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(106, 22)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.toolTip1.SetToolTip(Me.label24, "Saves the document in Word 97-2003 format" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
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
            Me.button1.Location = New System.Drawing.Point(287, 255)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(88, 25)
            Me.button1.TabIndex = 76
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
            Me.label2.Size = New System.Drawing.Size(374, 44)
            Me.label2.TabIndex = 84
            Me.label2.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" & _
        "ote that MS Word Viewer or MS Word is required to view the resultant document."
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(392, 97)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 83
            Me.pictureBox1.TabStop = False
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label5.Location = New System.Drawing.Point(10, 159)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(95, 24)
            Me.label5.TabIndex = 106
            Me.label5.Text = "Watermark"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'panel2
            '
            Me.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.panel2.Controls.Add(Me.label3)
            Me.panel2.Controls.Add(Me.rdbTextWatermark)
            Me.panel2.Controls.Add(Me.rdbPicWatermark)
            Me.panel2.Controls.Add(Me.label4)
            Me.panel2.Location = New System.Drawing.Point(3, 173)
            Me.panel2.Name = "panel2"
            Me.panel2.Size = New System.Drawing.Size(125, 65)
            Me.panel2.TabIndex = 105
            '
            'rdbTextWatermark
            '
            Me.rdbTextWatermark.AutoSize = True
            Me.rdbTextWatermark.Location = New System.Drawing.Point(17, 40)
            Me.rdbTextWatermark.Name = "rdbTextWatermark"
            Me.rdbTextWatermark.Size = New System.Drawing.Size(46, 17)
            Me.rdbTextWatermark.TabIndex = 1
            Me.rdbTextWatermark.Text = "Text"
            '
            'rdbPicWatermark
            '
            Me.rdbPicWatermark.AutoSize = True
            Me.rdbPicWatermark.Checked = True
            Me.rdbPicWatermark.Location = New System.Drawing.Point(17, 14)
            Me.rdbPicWatermark.Name = "rdbPicWatermark"
            Me.rdbPicWatermark.Size = New System.Drawing.Size(58, 17)
            Me.rdbPicWatermark.TabIndex = 0
            Me.rdbPicWatermark.TabStop = True
            Me.rdbPicWatermark.Text = "Picture"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.word2013RadioBtn)
            Me.groupBox1.Controls.Add(Me.label6)
            Me.groupBox1.Controls.Add(Me.label7)
            Me.groupBox1.Controls.Add(Me.label24)
            Me.groupBox1.Controls.Add(Me.word2010RadioBtn)
            Me.groupBox1.Controls.Add(Me.word2003RadioBtn)
            Me.groupBox1.Controls.Add(Me.word2007RadioBtn)
            Me.groupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(134, 168)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(251, 70)
            Me.groupBox1.TabIndex = 104
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
            Me.ClientSize = New System.Drawing.Size(392, 289)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.panel2)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.button1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Watermark"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel2.ResumeLayout(False)
            Me.panel2.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Button Click"
        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click

            If Not (rdbPicWatermark.Checked) AndAlso Not (rdbTextWatermark.Checked) Then
                MessageBox.Show("Please select a watermark type")


            Else
                'Open an existing word document 
                Dim doc As WordDocument = New WordDocument("..\..\..\..\..\..\..\..\..\Common\Data\DocIO\Watermark.doc")

                If rdbTextWatermark.Checked Then
                    'Add text watermark.
                    Dim textWatermark As TextWatermark = New TextWatermark()
                    doc.Watermark = textWatermark

                    'Set the text for the watermark.
                    textWatermark.Text = "Demo"

                    'Set the color for the watermark text.
                    textWatermark.Color = Color.Gray

                    'Set the size.
                    textWatermark.Size = 120


                ElseIf rdbPicWatermark.Checked Then

                    'Add Picture watermark to the word document.
                    Dim picWatermark As PictureWatermark = New PictureWatermark()
                    doc.Watermark = picWatermark

                    'Set the picture.
                    picWatermark.Picture = Image.FromFile("..\..\..\..\..\..\..\..\..\Common\Images\DocIO\syncfusion_logo.gif")

                    'Set the properties for the watermark.
                    picWatermark.Scaling = 100.0F
                    picWatermark.Washout = False

                End If

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
                    doc.Save("Sample.docx", Syncfusion.DocIO.FormatType.Word2007)
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
                    doc.Save("Sample.docx", Syncfusion.DocIO.FormatType.Word2007)
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
                    doc.Save("Sample.docx", Syncfusion.DocIO.FormatType.Word2013)
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

            End If
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Me.Close()
        End Sub
#End Region
    End Class
End Namespace
