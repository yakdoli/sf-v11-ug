#Region "Copyright Syncfusion Inc. 2001 - 2009"
'
'  Copyright Syncfusion Inc. 2001 - 2009. All rights reserved.
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
Imports Syncfusion.Pdf.Parsing

Imports Syncfusion.Pdf.Graphics

Namespace EssentialPDFSamples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents btnImport As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
        Private label2 As Label
		Private label3 As Label
		Private label4 As Label
		Private label5 As Label
		Private txtTemplate1 As TextBox
		Private txtTemplate2 As TextBox
        Private WithEvents btnBrowse As Button
        Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            'Specify the path for the template documents.
            txtTemplate1.Text = "BorderTemplate.pdf"
            txtTemplate1.Tag = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\Common\Data\PDF\BorderTemplate.pdf"
            txtTemplate2.Text = "SourceTemplate.pdf"
            txtTemplate2.Tag = Application.StartupPath + "..\..\..\..\..\..\..\..\..\..\Common\Data\PDF\SourceTemplate.pdf"

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
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
            Me.btnImport = New System.Windows.Forms.Button
            Me.label1 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.txtTemplate1 = New System.Windows.Forms.TextBox
            Me.txtTemplate2 = New System.Windows.Forms.TextBox
            Me.btnBrowse = New System.Windows.Forms.Button
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnImport
            '
            Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnImport.BackColor = System.Drawing.Color.Transparent
            Me.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Image)
            Me.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnImport.Location = New System.Drawing.Point(292, 238)
            Me.btnImport.Name = "btnImport"
            Me.btnImport.Size = New System.Drawing.Size(75, 23)
            Me.btnImport.TabIndex = 0
            Me.btnImport.Text = "PDF"
            Me.btnImport.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(0, 192)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(375, 80)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Click the button to view an PDF document generated by Essential PDF. Please note " & _
                "that Adobe Reader or its equivalent is required to view the resultant document."
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label2.Image = CType(resources.GetObject("label2.Image"), System.Drawing.Image)
            Me.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label2.Location = New System.Drawing.Point(12, 101)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(208, 18)
            Me.label2.TabIndex = 25
            Me.label2.Text = "Specify the template documents"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label3
            '
            Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label3.Location = New System.Drawing.Point(22, 119)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(308, 1)
            Me.label3.TabIndex = 26
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(22, 130)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(88, 14)
            Me.label4.TabIndex = 27
            Me.label4.Text = "Border Template:"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(22, 156)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(90, 14)
            Me.label5.TabIndex = 28
            Me.label5.Text = "Source Template:"
            '
            'txtTemplate1
            '
            Me.txtTemplate1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTemplate1.Location = New System.Drawing.Point(112, 127)
            Me.txtTemplate1.Name = "txtTemplate1"
            Me.txtTemplate1.ReadOnly = True
            Me.txtTemplate1.Size = New System.Drawing.Size(215, 20)
            Me.txtTemplate1.TabIndex = 29
            '
            'txtTemplate2
            '
            Me.txtTemplate2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtTemplate2.Location = New System.Drawing.Point(112, 153)
            Me.txtTemplate2.Name = "txtTemplate2"
            Me.txtTemplate2.Size = New System.Drawing.Size(147, 20)
            Me.txtTemplate2.TabIndex = 30
            '
            'btnBrowse
            '
            Me.btnBrowse.Location = New System.Drawing.Point(269, 151)
            Me.btnBrowse.Name = "btnBrowse"
            Me.btnBrowse.Size = New System.Drawing.Size(58, 23)
            Me.btnBrowse.TabIndex = 31
            Me.btnBrowse.Text = "Browse"
            Me.btnBrowse.UseVisualStyleBackColor = True
            '
            'PictureBox2
            '
            Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(375, 90)
            Me.PictureBox2.TabIndex = 32
            Me.PictureBox2.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(375, 272)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.btnBrowse)
            Me.Controls.Add(Me.txtTemplate2)
            Me.Controls.Add(Me.txtTemplate1)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.btnImport)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Overlay Documents"
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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

#Region "Import and Overlay PDF documents"

        Private Sub btnImport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImport.Click
            Dim ldDoc1 As PdfLoadedDocument = New PdfLoadedDocument(txtTemplate1.Tag.ToString())
            Dim ldDoc2 As PdfLoadedDocument = New PdfLoadedDocument(txtTemplate2.Tag.ToString())
            Dim doc As PdfDocument = New PdfDocument()

            Dim i As Integer = 0
            Dim count As Integer = ldDoc2.Pages.Count
            Do While i < count
                Dim page As PdfPage = doc.Pages.Add()
                Dim g As PdfGraphics = page.Graphics

                Dim lpage As PdfPageBase = ldDoc2.Pages(i)
                Dim template As PdfTemplate = lpage.CreateTemplate()

                g.DrawPdfTemplate(template, PointF.Empty, page.GetClientSize())

                lpage = ldDoc1.Pages(0)
                template = lpage.CreateTemplate()

                g.DrawPdfTemplate(template, PointF.Empty, page.GetClientSize())
                i += 1
            Loop

            doc.Save("sample.pdf")

            'Message box confirmation to view the created PDF document.
            If MessageBox.Show("Do you want to view the PDF file?", "PDF File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                'Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Sample.pdf")
                Me.Close()
            Else
                ' Exit
                Me.Close()
            End If
        End Sub
#End Region

        Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowse.Click
            Dim dialog As OpenFileDialog = New OpenFileDialog()
            dialog.Filter = "PDF Documents (*.pdf)|*.PDF"

            If dialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txtTemplate2.Text = dialog.SafeFileName
                txtTemplate2.Tag = dialog.FileName
            End If
        End Sub

	End Class
End Namespace
