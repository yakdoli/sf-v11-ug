#Region "Copyright Syncfusion Inc. 2001 - 2013"
'
'  Copyright Syncfusion Inc. 2001 - 2013. All rights reserved.
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
Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS
Imports System.IO


Namespace EssentialPDFSamples
	Public Class Form1
		Inherits System.Windows.Forms.Form
		#Region "Private Members"
		Private WithEvents button1 As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
		Private pictureBox1 As System.Windows.Forms.PictureBox
		Private WithEvents button3 As Button
		Private textBox1 As TextBox
		Private label9 As Label
		Private openFileDialog1 As OpenFileDialog
        Private toolTip1 As ToolTip
		Private label24 As Label
		Private components As IContainer
		#End Region

		#Region "Form's Constructor, Main And Dispose"
		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()
            Application.EnableVisualStyles()
            Me.textBox1.Text = "DocToHTML.doc"
            Me.textBox1.Tag = Application.StartupPath & "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\Doc to HTML.doc"
			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub
		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
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
            Me.button1 = New System.Windows.Forms.Button()
            Me.label1 = New System.Windows.Forms.Label()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.button3 = New System.Windows.Forms.Button()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.label9 = New System.Windows.Forms.Label()
            Me.openFileDialog1 = New System.Windows.Forms.OpenFileDialog()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.label24 = New System.Windows.Forms.Label()
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
            Me.button1.Location = New System.Drawing.Point(233, 224)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(130, 30)
            Me.button1.TabIndex = 0
            Me.button1.Text = "Doc To HTML"
            Me.button1.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(0, 105)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(372, 55)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Click the button to view the PDF document converted from a word document using Es" & _
                "sential DocIO and PDF. Please note Adobe reader or its equivalent is required to" & _
                " view the resultant document." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(372, 97)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.pictureBox1.TabIndex = 24
            Me.pictureBox1.TabStop = False
            '
            'button3
            '
            Me.button3.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.button3.Location = New System.Drawing.Point(342, 187)
            Me.button3.Name = "button3"
            Me.button3.Size = New System.Drawing.Size(21, 21)
            Me.button3.TabIndex = 76
            Me.button3.Text = ". . ."
            Me.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter
            Me.button3.UseVisualStyleBackColor = True
            '
            'textBox1
            '
            Me.textBox1.Location = New System.Drawing.Point(4, 188)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(333, 20)
            Me.textBox1.TabIndex = 75
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label9.Location = New System.Drawing.Point(6, 170)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(110, 13)
            Me.label9.TabIndex = 74
            Me.label9.Text = "Word Document"
            '
            'openFileDialog1
            '
            Me.openFileDialog1.FileName = "openFileDialog1"
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(118, 169)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 78
            Me.toolTip1.SetToolTip(Me.label24, "Browse for a word document to convert it to HTML")
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(372, 266)
            Me.Controls.Add(Me.label24)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.button3)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.label9)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.pictureBox1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Doc to HTML"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
		#End Region

		#Region "Events"
		#Region "Browse Word Document"
		Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button3.Click
            openFileDialog1.InitialDirectory = New DirectoryInfo(Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\Common\Data\DocIO\").FullName

			openFileDialog1.FileName = ""			
			Dim result As DialogResult = openFileDialog1.ShowDialog()

			If result = System.Windows.Forms.DialogResult.OK Then
				Me.textBox1.Text = openFileDialog1.FileName

			End If
		End Sub
#End Region

		#Region "Convert To HTML"
		Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
			If Me.textBox1.Text <> String.Empty Then
				'Open the document to conert from word to HTML
                Dim doc As WordDocument = New WordDocument(textBox1.Tag.ToString())
                Dim htmlExport As HTMLExport = New HTMLExport()
                doc.SaveOptions.HtmlExportImagesFolder = Application.StartupPath
				'Export the doc to HTML and save as .html file
                htmlExport.SaveAsXhtml(doc, Application.StartupPath + "\DocToHtml.html")
				'Message box confirmation to view the created document.
				If MessageBox.Show("Do you want to view the HTML file?", "File has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
					Try
                        System.Diagnostics.Process.Start(Application.StartupPath + "\DocToHtml.html")
						'Exit
						Me.Close()
					Catch ex As Exception
						Console.WriteLine(ex.ToString())
					End Try
				End If
			Else
				MessageBox.Show("Browse a word document and click the button to convert as a HTML.")
			End If
        End Sub

		#End Region
		#End Region


    End Class
End Namespace
