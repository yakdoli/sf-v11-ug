#Region "Copyright Syncfusion Inc. 2001 - 2013"
' Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
' Use of this code is subject to the terms of our license.
' A copy of the current license can be obtained at any time by e-mailing
' licensing@syncfusion.com. Any infringement will be prosecuted under
' applicable laws. 
#End Region

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS
Namespace EncryptDocument_2005
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub
        ''' <summary>
        ''' Encrypt the selected Word document
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
            If Me.txtEncryptSource.Text IsNot Nothing AndAlso Me.txtEncryptSource.Text <> "" Then
                Dim document As WordDocument = New WordDocument(Me.txtEncryptSource.Text)

                ' Getting last section of the document.
                Dim section As IWSection = document.LastSection

                ' Adding a paragraph to the section.
                Dim paragraph As IWParagraph = section.AddParagraph()

                ' Writing text
                Dim text As IWTextRange = paragraph.AppendText("This document was encrypted with password")
                text.CharacterFormat.FontSize = 16.0F
                text.CharacterFormat.FontName = "Bitstream Vera Serif"

                ' Encrypt the document by giving password
                document.EncryptDocument(txtEnOpen.Text)

                'Save as word 2003 format
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
                    'Save as word 2010  format
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
                            MessageBox.Show("Word 2010 is not installed in this system")
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
            Else
                MessageBox.Show("Please browse the document to encrypt")
            End If
        End Sub
        ''' <summary>
        ''' Gets the source document to encrypt
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
            OpenFileDialog1.InitialDirectory = Application.StartupPath + "..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"
            OpenFileDialog1.Title = "Choose a Word document to Encrypt"

            OpenFileDialog1.RestoreDirectory = True
            If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.txtEncryptSource.Text = OpenFileDialog1.FileName
            End If
        End Sub
        ''' <summary>
        ''' Gets the source document to decrypt
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnDecryptSource_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDecryptSource.Click
            OpenFileDialog2.InitialDirectory = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"
            OpenFileDialog2.Title = "Choose a Word document to Decrypt"
            OpenFileDialog2.RestoreDirectory = True
            If OpenFileDialog2.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Me.txtDecryptSource.Text = OpenFileDialog2.FileName
            End If

        End Sub
        ''' <summary>
        ''' Decrypt the selected Word document
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
            Try
                If Me.txtDecryptSource.Text IsNot Nothing AndAlso Me.txtDecryptSource.Text <> "" Then
                    Dim document As WordDocument = New WordDocument(Me.txtDecryptSource.Text, txtDeOpen.Text)

                    ' Getting last section of the document.
                    Dim section As IWSection = document.LastSection

                    ' Adding a paragraph to the section.
                    Dim paragraph As IWParagraph = section.AddParagraph()

                    ' Writing text
                    Dim text As IWTextRange = paragraph.AppendText(Constants.vbLf & "Demo For Document Decryption with Essential DocIO")
                    text.CharacterFormat.FontSize = 16.0F
                    text.CharacterFormat.FontName = "Bitstream Vera Serif"

                    text = paragraph.AppendText(Constants.vbLf & "This document is Decrypted")
                    text.CharacterFormat.FontSize = 16.0F
                    text.CharacterFormat.FontName = "Bitstream Vera Serif"

                    'Save as word 2003 format
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
                        'Save as word 2010  format
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
                                MessageBox.Show("Word 2010 is not installed in this system")
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
                Else
                    MessageBox.Show("Please browse the document to decrypt")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents groupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents label14 As System.Windows.Forms.Label
        Private WithEvents button3 As System.Windows.Forms.Button
        Private WithEvents label13 As System.Windows.Forms.Label
        Private WithEvents btnDecryptSource As System.Windows.Forms.Button
        Private WithEvents txtDecryptSource As System.Windows.Forms.TextBox
        Private WithEvents label5 As System.Windows.Forms.Label
        Private WithEvents txtDeOpen As System.Windows.Forms.TextBox
        Private WithEvents label6 As System.Windows.Forms.Label
        Private WithEvents label11 As System.Windows.Forms.Label
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents label7 As System.Windows.Forms.Label
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents button2 As System.Windows.Forms.Button
        Private WithEvents txtEncryptSource As System.Windows.Forms.TextBox
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents txtEnOpen As System.Windows.Forms.TextBox
        Private WithEvents label4 As System.Windows.Forms.Label
        Private WithEvents label8 As System.Windows.Forms.Label
        Private WithEvents label10 As System.Windows.Forms.Label
        Private WithEvents label2 As System.Windows.Forms.Label
        Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.Label12 = New System.Windows.Forms.Label()
            Me.Label9 = New System.Windows.Forms.Label()
            Me.label14 = New System.Windows.Forms.Label()
            Me.button3 = New System.Windows.Forms.Button()
            Me.label13 = New System.Windows.Forms.Label()
            Me.btnDecryptSource = New System.Windows.Forms.Button()
            Me.txtDecryptSource = New System.Windows.Forms.TextBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.txtDeOpen = New System.Windows.Forms.TextBox()
            Me.label6 = New System.Windows.Forms.Label()
            Me.label11 = New System.Windows.Forms.Label()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.button2 = New System.Windows.Forms.Button()
            Me.txtEncryptSource = New System.Windows.Forms.TextBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.button1 = New System.Windows.Forms.Button()
            Me.txtEnOpen = New System.Windows.Forms.TextBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label10 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Label15 = New System.Windows.Forms.Label()
            Me.Label16 = New System.Windows.Forms.Label()
            Me.Label17 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
            Me.GroupBox3 = New System.Windows.Forms.GroupBox()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2003RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2007RadioBtn = New System.Windows.Forms.RadioButton()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox2.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            Me.GroupBox3.SuspendLayout()
            Me.SuspendLayout()
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(370, 97)
            Me.pictureBox1.TabIndex = 78
            Me.pictureBox1.TabStop = False
            '
            'groupBox2
            '
            Me.groupBox2.Controls.Add(Me.Label12)
            Me.groupBox2.Controls.Add(Me.Label9)
            Me.groupBox2.Controls.Add(Me.label14)
            Me.groupBox2.Controls.Add(Me.button3)
            Me.groupBox2.Controls.Add(Me.label13)
            Me.groupBox2.Controls.Add(Me.btnDecryptSource)
            Me.groupBox2.Controls.Add(Me.txtDecryptSource)
            Me.groupBox2.Controls.Add(Me.label5)
            Me.groupBox2.Controls.Add(Me.txtDeOpen)
            Me.groupBox2.Controls.Add(Me.label6)
            Me.groupBox2.Controls.Add(Me.label11)
            Me.groupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.groupBox2.Location = New System.Drawing.Point(10, 375)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(348, 122)
            Me.groupBox2.TabIndex = 89
            Me.groupBox2.TabStop = False
            Me.groupBox2.Text = "     Decrypt Document"
            '
            'Label12
            '
            Me.Label12.Image = Global.My.Resources.Resources.label8_Image
            Me.Label12.Location = New System.Drawing.Point(326, 33)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(20, 16)
            Me.Label12.TabIndex = 91
            Me.toolTip1.SetToolTip(Me.Label12, "Browse the word document to Decrypt")
            '
            'Label9
            '
            Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
            Me.Label9.Location = New System.Drawing.Point(6, 0)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(21, 17)
            Me.Label9.TabIndex = 90
            '
            'label14
            '
            Me.label14.Location = New System.Drawing.Point(325, 32)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(20, 16)
            Me.label14.TabIndex = 88
            '
            'button3
            '
            Me.button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button3.BackColor = System.Drawing.Color.Transparent
            Me.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button3.Image = CType(resources.GetObject("button3.Image"), System.Drawing.Image)
            Me.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.button3.Location = New System.Drawing.Point(256, 94)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(86, 25)
            Me.button3.TabIndex = 77
            Me.button3.Text = "Decrypt"
            Me.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button3.UseVisualStyleBackColor = False
            '
            'label13
            '
            Me.label13.Location = New System.Drawing.Point(322, 33)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(20, 16)
            Me.label13.TabIndex = 10
            '
            'btnDecryptSource
            '
            Me.btnDecryptSource.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnDecryptSource.BackColor = System.Drawing.Color.Transparent
            Me.btnDecryptSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnDecryptSource.ForeColor = System.Drawing.SystemColors.ControlText
            Me.btnDecryptSource.Location = New System.Drawing.Point(299, 29)
            Me.btnDecryptSource.Name = "btnDecryptSource"
            Me.btnDecryptSource.Size = New System.Drawing.Size(24, 20)
            Me.btnDecryptSource.TabIndex = 6
            Me.btnDecryptSource.Text = "..."
            Me.btnDecryptSource.UseVisualStyleBackColor = False
            '
            'txtDecryptSource
            '
            Me.txtDecryptSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDecryptSource.Location = New System.Drawing.Point(123, 29)
            Me.txtDecryptSource.Name = "txtDecryptSource"
            Me.txtDecryptSource.Size = New System.Drawing.Size(172, 20)
            Me.txtDecryptSource.TabIndex = 7
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label5.Location = New System.Drawing.Point(6, 32)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(93, 13)
            Me.label5.TabIndex = 8
            Me.label5.Text = "Source Document"
            '
            'txtDeOpen
            '
            Me.txtDeOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDeOpen.Location = New System.Drawing.Point(123, 60)
            Me.txtDeOpen.Name = "txtDeOpen"
            Me.txtDeOpen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtDeOpen.Size = New System.Drawing.Size(219, 20)
            Me.txtDeOpen.TabIndex = 8
            '
            'label6
            '
            Me.label6.AutoSize = True
            Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label6.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label6.Location = New System.Drawing.Point(6, 63)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(98, 13)
            Me.label6.TabIndex = 3
            Me.label6.Text = "Password To Open"
            '
            'label11
            '
            Me.label11.BackColor = System.Drawing.Color.MidnightBlue
            Me.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.label11.Location = New System.Drawing.Point(29, 13)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(118, 1)
            Me.label11.TabIndex = 2
            Me.label11.Text = "label11"
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.label7)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.button2)
            Me.groupBox1.Controls.Add(Me.txtEncryptSource)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.button1)
            Me.groupBox1.Controls.Add(Me.txtEnOpen)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.label8)
            Me.groupBox1.Controls.Add(Me.label10)
            Me.groupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue
            Me.groupBox1.Location = New System.Drawing.Point(10, 230)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(348, 132)
            Me.groupBox1.TabIndex = 88
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "     Encrypt Document"
            '
            'label7
            '
            Me.label7.Image = Global.My.Resources.Resources.label8_Image
            Me.label7.Location = New System.Drawing.Point(322, 32)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(20, 16)
            Me.label7.TabIndex = 87
            Me.toolTip1.SetToolTip(Me.label7, "Browse the word document to Encrypt")
            '
            'label1
            '
            Me.label1.Location = New System.Drawing.Point(322, 32)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(20, 16)
            Me.label1.TabIndex = 9
            '
            'button2
            '
            Me.button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button2.BackColor = System.Drawing.Color.Transparent
            Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.button2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.button2.Location = New System.Drawing.Point(299, 29)
            Me.button2.Name = "button2"
            Me.button2.Size = New System.Drawing.Size(24, 20)
            Me.button2.TabIndex = 0
            Me.button2.Text = "..."
            Me.button2.UseVisualStyleBackColor = False
            '
            'txtEncryptSource
            '
            Me.txtEncryptSource.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEncryptSource.Location = New System.Drawing.Point(123, 29)
            Me.txtEncryptSource.Name = "txtEncryptSource"
            Me.txtEncryptSource.Size = New System.Drawing.Size(172, 20)
            Me.txtEncryptSource.TabIndex = 1
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label3.Location = New System.Drawing.Point(6, 32)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(93, 13)
            Me.label3.TabIndex = 8
            Me.label3.Text = "Source Document"
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
            Me.button1.Location = New System.Drawing.Point(256, 101)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(86, 25)
            Me.button1.TabIndex = 76
            Me.button1.Text = "Encrypt"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
            '
            'txtEnOpen
            '
            Me.txtEnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtEnOpen.Location = New System.Drawing.Point(123, 60)
            Me.txtEnOpen.Name = "txtEnOpen"
            Me.txtEnOpen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.txtEnOpen.Size = New System.Drawing.Size(219, 20)
            Me.txtEnOpen.TabIndex = 2
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label4.Location = New System.Drawing.Point(6, 63)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(106, 13)
            Me.label4.TabIndex = 3
            Me.label4.Text = "Password To Protect"
            '
            'label8
            '
            Me.label8.BackColor = System.Drawing.Color.MidnightBlue
            Me.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.label8.Location = New System.Drawing.Point(29, 13)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(118, 1)
            Me.label8.TabIndex = 2
            Me.label8.Text = "label8"
            '
            'label10
            '
            Me.label10.Image = Global.My.Resources.Resources.label_Image
            Me.label10.Location = New System.Drawing.Point(9, 0)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(21, 17)
            Me.label10.TabIndex = 1
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 97)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(370, 58)
            Me.label2.TabIndex = 87
            Me.label2.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" & _
        "ote that MS Word Viewer or MS Word is required to view the resultant document."
            '
            'OpenFileDialog1
            '
            Me.OpenFileDialog1.FileName = "OpenFileDialog1"
            '
            'Label15
            '
            Me.Label15.Image = CType(resources.GetObject("Label15.Image"), System.Drawing.Image)
            Me.Label15.Location = New System.Drawing.Point(221, 48)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(20, 18)
            Me.Label15.TabIndex = 104
            Me.toolTip1.SetToolTip(Me.Label15, "Saves the document in Word 2013 format")
            '
            'Label16
            '
            Me.Label16.Image = CType(resources.GetObject("Label16.Image"), System.Drawing.Image)
            Me.Label16.Location = New System.Drawing.Point(107, 48)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(20, 18)
            Me.Label16.TabIndex = 102
            Me.toolTip1.SetToolTip(Me.Label16, "Saves the document in Word 2010 format")
            '
            'Label17
            '
            Me.Label17.Image = CType(resources.GetObject("Label17.Image"), System.Drawing.Image)
            Me.Label17.Location = New System.Drawing.Point(221, 20)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(20, 18)
            Me.Label17.TabIndex = 101
            Me.toolTip1.SetToolTip(Me.Label17, "Saves the document in Word 2007 format")
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(107, 22)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.toolTip1.SetToolTip(Me.label24, "Saves the document in Word 97-2003 format" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'OpenFileDialog2
            '
            Me.OpenFileDialog2.FileName = "OpenFileDialog1"
            '
            'GroupBox3
            '
            Me.GroupBox3.Controls.Add(Me.Label15)
            Me.GroupBox3.Controls.Add(Me.word2013RadioBtn)
            Me.GroupBox3.Controls.Add(Me.Label16)
            Me.GroupBox3.Controls.Add(Me.Label17)
            Me.GroupBox3.Controls.Add(Me.label24)
            Me.GroupBox3.Controls.Add(Me.word2010RadioBtn)
            Me.GroupBox3.Controls.Add(Me.word2003RadioBtn)
            Me.GroupBox3.Controls.Add(Me.word2007RadioBtn)
            Me.GroupBox3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox3.Location = New System.Drawing.Point(54, 145)
            Me.GroupBox3.Name = "GroupBox3"
            Me.GroupBox3.Size = New System.Drawing.Size(251, 70)
            Me.GroupBox3.TabIndex = 101
            Me.GroupBox3.TabStop = False
            Me.GroupBox3.Text = "Save As"
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
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(370, 506)
            Me.Controls.Add(Me.GroupBox3)
            Me.Controls.Add(Me.groupBox2)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Name = "Form1"
            Me.ShowIcon = False
            Me.Text = "Encrypt and Decrypt"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            Me.GroupBox3.ResumeLayout(False)
            Me.GroupBox3.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents Label12 As System.Windows.Forms.Label
        Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
        Private components As System.ComponentModel.IContainer
        Private WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
        Private WithEvents GroupBox3 As System.Windows.Forms.GroupBox
        Private WithEvents Label15 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label16 As System.Windows.Forms.Label
        Private WithEvents Label17 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2007RadioBtn As System.Windows.Forms.RadioButton
    End Class

End Namespace