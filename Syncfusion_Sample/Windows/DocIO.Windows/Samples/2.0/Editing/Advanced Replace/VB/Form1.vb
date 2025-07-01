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
Imports System.Text.RegularExpressions
Imports System.Diagnostics

Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS

Namespace EssentialDocIOSamples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form
        Private WithEvents button1 As Button
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents RadioButton1 As System.Windows.Forms.RadioButton
        Private WithEvents RadioButton2 As System.Windows.Forms.RadioButton
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
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.RadioButton1 = New System.Windows.Forms.RadioButton()
            Me.RadioButton2 = New System.Windows.Forms.RadioButton()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.button1.Location = New System.Drawing.Point(281, 195)
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
            Me.label2.Location = New System.Drawing.Point(0, 109)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(372, 41)
            Me.label2.TabIndex = 74
            Me.label2.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" & _
                "ote that MS Word Viewer or MS Word is required to view the resultant document."
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(372, 97)
            Me.pictureBox1.TabIndex = 70
            Me.pictureBox1.TabStop = False
            '
            'RadioButton1
            '
            Me.RadioButton1.AutoSize = True
            Me.RadioButton1.Checked = True
            Me.RadioButton1.Location = New System.Drawing.Point(16, 161)
            Me.RadioButton1.Name = "RadioButton1"
            Me.RadioButton1.Size = New System.Drawing.Size(142, 17)
            Me.RadioButton1.TabIndex = 76
            Me.RadioButton1.TabStop = True
            Me.RadioButton1.Text = "Replace With Formatting"
            Me.RadioButton1.UseVisualStyleBackColor = True
            '
            'RadioButton2
            '
            Me.RadioButton2.AutoSize = True
            Me.RadioButton2.Location = New System.Drawing.Point(185, 161)
            Me.RadioButton2.Name = "RadioButton2"
            Me.RadioButton2.Size = New System.Drawing.Size(117, 17)
            Me.RadioButton2.TabIndex = 77
            Me.RadioButton2.Text = "Advanced Replace"
            Me.RadioButton2.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(372, 242)
            Me.Controls.Add(Me.RadioButton2)
            Me.Controls.Add(Me.RadioButton1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.button1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Advanced Replace"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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

            If RadioButton1.Checked Then
                ' Get Template files path.
                Dim dataPath As String = Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\"

                ' Creating new documents.
                Dim docSource1 As WordDocument = New WordDocument()
                Dim docSource2 As WordDocument = New WordDocument()
                Dim docMaster As WordDocument = New WordDocument()

                ' Load Templates.
                docSource1.Open(Path.Combine(dataPath, "TemplateSource1.doc"), FormatType.Doc)
                docSource2.Open(Path.Combine(dataPath, "TemplateSource2.doc"), FormatType.Doc)
                docMaster.Open(Path.Combine(dataPath, "TemplateMaster.doc"), FormatType.Doc)
                ' Set Margin of the section
                docMaster.LastSection.PageSetup.Margins.All = 72
                ' Search for a string and store in TextSelection
                'The TextSelection copies a text segment with formatting.
                Dim selection1 As TextSelection = docSource1.Find("PlaceHolder text is replaced with this formatted animated text", False, False)

                ' Search for a string and store in TextSelection
                Dim selection2 As TextSelection = docSource2.Find(New Regex("This is the second Sentence"))

                ' Replacing the placeholder inside Master Template with matches found while
                'search the two template documents. 
                docMaster.Replace(New Regex("PlaceHolder1"), selection1)
                docMaster.Replace(New Regex("PlaceHolder2"), selection2)

                ' Saving the document with replacment text to disk.
                docMaster.Save("Sample.doc", FormatType.Doc)

                'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                    System.Diagnostics.Process.Start("Sample.doc")
                    'Exit
                    Me.Close()
                Else
                    ' Exit
                    Me.Close()
                End If
            Else
                'Load template document
                Dim doc As WordDocument = New WordDocument("..\..\..\..\..\..\..\..\..\Common\Data\DocIO\Original.doc")

                'Load the document to be replaced 
                Dim replaceDoc As WordDocument = New WordDocument("..\..\..\..\..\..\..\..\..\Common\Data\DocIO\Replace.doc")

                'Select a table and add it to TextBodyPart
                Dim replacePart As TextBodyPart = New TextBodyPart(replaceDoc)
                replacePart.BodyItems.Add(CType(IIf(TypeOf replaceDoc.Sections(0).Body.Tables(0) Is WTable, replaceDoc.Sections(0).Body.Tables(0), Nothing), WTable))
                'Replace Text with table
                doc.Replace("INSERT TABLE", replacePart, True, True)

                'Select text and image
                replacePart = New TextBodyPart(replaceDoc)
                Dim textSel As TextBodySelection = New TextBodySelection(replaceDoc.LastSection.Body, 0, replaceDoc.LastSection.Paragraphs.Count, 0, 1)
                replacePart.Copy(textSel)

                'Replace Text with image and text.
                doc.Replace("INSERT PARAGRAPH ITEMS", replacePart, False, True)
                doc.Save("Sample.doc")

                'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                    System.Diagnostics.Process.Start("Sample.doc")
                    'Exit
                    Me.Close()
                Else
                    ' Exit
                    Me.Close()
                End If
            End If
        End Sub
    End Class
End Namespace
