#Region "Copyright Syncfusion Inc. 2001 - 2007"
'
'  Copyright Syncfusion Inc. 2001 - 2007. All rights reserved.
'
'  Use of this code is subject to the terms of our license.
'  A copy of the current license can be obtained at any time by e-mailing
'  licensing@syncfusion.com. Re-distribution in any form is strictly
'  prohibited. Any infringement will be prosecuted under applicable laws. 
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
Imports Syncfusion.Pdf
Imports Syncfusion.Pdf.Graphics
Imports Syncfusion.Pdf.Parsing
Imports System.Text
Imports System.IO

Namespace EssentialPDFSamples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
        Inherits System.Windows.Forms.Form
#Region "Private Members"
        Private WithEvents button1 As System.Windows.Forms.Button
        Private label1 As Label
        Private WithEvents btnLoad As Button
        Private label2 As Label
        Private txtUrl As TextBox
        Private label5 As Label
        Private dlgOpen As OpenFileDialog
        Private WithEvents PictureBox3 As System.Windows.Forms.PictureBox

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Constructor"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            Application.EnableVisualStyles()
            txtUrl.Tag = GetFullTemplatePath("Manual.pdf", False)
            txtUrl.Text = "Manual.pdf"
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.label1 = New System.Windows.Forms.Label
            Me.btnLoad = New System.Windows.Forms.Button
            Me.label2 = New System.Windows.Forms.Label
            Me.txtUrl = New System.Windows.Forms.TextBox
            Me.label5 = New System.Windows.Forms.Label
            Me.button1 = New System.Windows.Forms.Button
            Me.dlgOpen = New System.Windows.Forms.OpenFileDialog
            Me.PictureBox3 = New System.Windows.Forms.PictureBox
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(0, 149)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(373, 52)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Clicking the button below will result in a new Text document.  At the end of the " & _
                "document generation, an option will be provided to view the generated text file." & _
                " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'btnLoad
            '
            Me.btnLoad.Location = New System.Drawing.Point(313, 120)
            Me.btnLoad.Name = "btnLoad"
            Me.btnLoad.Size = New System.Drawing.Size(24, 23)
            Me.btnLoad.TabIndex = 88
            Me.btnLoad.Text = "..."
            Me.btnLoad.UseVisualStyleBackColor = True
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.label2.Location = New System.Drawing.Point(34, 125)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(41, 13)
            Me.label2.TabIndex = 86
            Me.label2.Text = "Source"
            '
            'txtUrl
            '
            Me.txtUrl.Location = New System.Drawing.Point(81, 122)
            Me.txtUrl.Name = "txtUrl"
            Me.txtUrl.Size = New System.Drawing.Size(232, 20)
            Me.txtUrl.TabIndex = 84
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label5.Location = New System.Drawing.Point(6, 94)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(146, 19)
            Me.label5.TabIndex = 89
            Me.label5.Text = "Source Document"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
            Me.button1.Location = New System.Drawing.Point(271, 191)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(90, 24)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Extract Text"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
            '
            'dlgOpen
            '
            Me.dlgOpen.FileName = "openFileDialog1"
            '
            'PictureBox3
            '
            Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
            Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
            Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(373, 89)
            Me.PictureBox3.TabIndex = 90
            Me.PictureBox3.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(373, 232)
            Me.Controls.Add(Me.PictureBox3)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.btnLoad)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.txtUrl)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Text Extraction"
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
#End Region

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Application.Run(New Form1())
        End Sub
#End Region

#Region "Events"
        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            If txtUrl.Text = "" Then
                MessageBox.Show("Please select a PDF document")
                txtUrl.Focus()
            Else
                ' Load an existing PDF using PdfLoadedDocument class.
                Dim ldoc As PdfLoadedDocument = New PdfLoadedDocument(txtUrl.Tag.ToString())

                ' Loading Page collections
                Dim loadedPages As PdfLoadedPageCollection = ldoc.Pages

                Dim s As String = ""

                ' Extract text from PDF document pages
                For Each lpage As PdfLoadedPage In loadedPages
                    s &= lpage.ExtractText()
                Next lpage

                'Convert the string to byte array
                Dim b As Byte() = (New UnicodeEncoding()).GetBytes(s)

                ' Writing the byte array to text file
                Dim fStream As FileStream = File.Create("sample.txt")
                fStream.Write(b, 0, b.Length)
                fStream.Close()

                ' Close the document.
                ldoc.Close(True)

                'Message box confirmation to view the created PDF document.
                If MessageBox.Show("Do you want to view the Text file?", "Text File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    'Launching the PDF file using the default Application.[Acrobat Reader]
                    System.Diagnostics.Process.Start("sample.txt")
                    Me.Close()
                Else
                    ' Exit
                    Me.Close()
                End If
            End If
        End Sub

        ''' <summary>
        ''' Update the TextBox.
        ''' </summary>
        Private Sub btnLoad_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLoad.Click
            If dlgOpen.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                'assigns the url of the file to the text box
                txtUrl.Text = dlgOpen.SafeFileName
                txtUrl.Tag = dlgOpen.FileName
            End If
        End Sub
#End Region

#Region "Helpher Methods"
        ''' <summary>
        ''' Gets the full path of the PDF template or image.
        ''' </summary>
        ''' <param name="fileName">Name of the file</param>
        ''' <param name="image">True if image</param>
        ''' <returns>Path of the file</returns>
        Private Function GetFullTemplatePath(ByVal fileName As String, ByVal image As Boolean) As String
            Dim fullPath As String = "..\..\..\..\..\..\..\..\..\Common\"
            Dim folder As String
            If image Then
                folder = "Images"
            Else
                folder = "Data"
            End If

            Return String.Format("{0}{1}\PDF\{2}", fullPath, folder, fileName)
        End Function
#End Region

	End Class
End Namespace
