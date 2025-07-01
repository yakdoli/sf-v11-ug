#Region "Copyright Syncfusion Inc. 2001 - 2005"
'
'  Copyright Syncfusion Inc. 2001 - 2005. All rights reserved.
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


Namespace EssentialPDFSamples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents btnImport As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
        Private WithEvents btnBrowse As Button
		Private label2 As Label
		Private txtUrl As TextBox
		Private txtStamp As TextBox
		Private label3 As Label
		Private chbWatermark As CheckBox
		Private label4 As Label
        Private label5 As Label
        Private WithEvents PictureBox3 As System.Windows.Forms.PictureBox

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
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
            Me.btnBrowse = New System.Windows.Forms.Button
            Me.label2 = New System.Windows.Forms.Label
            Me.txtUrl = New System.Windows.Forms.TextBox
            Me.txtStamp = New System.Windows.Forms.TextBox
            Me.label3 = New System.Windows.Forms.Label
            Me.chbWatermark = New System.Windows.Forms.CheckBox
            Me.label4 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.PictureBox3 = New System.Windows.Forms.PictureBox
            CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.btnImport.Location = New System.Drawing.Point(289, 268)
            Me.btnImport.Name = "btnImport"
            Me.btnImport.Size = New System.Drawing.Size(75, 23)
            Me.btnImport.TabIndex = 0
            Me.btnImport.Text = "PDF"
            Me.btnImport.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(0, 200)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(374, 67)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Click the button to view an PDF document generated by Essential PDF. Please note " & _
                "that Adobe Reader or its equivalent is required to view the resultant document."
            '
            'btnBrowse
            '
            Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnBrowse.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBrowse.Location = New System.Drawing.Point(284, 122)
            Me.btnBrowse.Name = "btnBrowse"
            Me.btnBrowse.Size = New System.Drawing.Size(62, 23)
            Me.btnBrowse.TabIndex = 25
            Me.btnBrowse.Text = "Browse"
            Me.btnBrowse.UseVisualStyleBackColor = True
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(26, 127)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(118, 14)
            Me.label2.TabIndex = 26
            Me.label2.Text = "Select a PDF document"
            '
            'txtUrl
            '
            Me.txtUrl.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtUrl.Location = New System.Drawing.Point(152, 124)
            Me.txtUrl.Name = "txtUrl"
            Me.txtUrl.Size = New System.Drawing.Size(118, 20)
            Me.txtUrl.TabIndex = 27
            '
            'txtStamp
            '
            Me.txtStamp.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtStamp.Location = New System.Drawing.Point(152, 150)
            Me.txtStamp.Name = "txtStamp"
            Me.txtStamp.Size = New System.Drawing.Size(168, 20)
            Me.txtStamp.TabIndex = 28
            Me.txtStamp.Text = "Imported using Essential PDF"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(26, 153)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(74, 14)
            Me.label3.TabIndex = 29
            Me.label3.Text = "Stamping Text"
            '
            'chbWatermark
            '
            Me.chbWatermark.AutoSize = True
            Me.chbWatermark.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.chbWatermark.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chbWatermark.Location = New System.Drawing.Point(29, 175)
            Me.chbWatermark.Name = "chbWatermark"
            Me.chbWatermark.Size = New System.Drawing.Size(115, 19)
            Me.chbWatermark.TabIndex = 30
            Me.chbWatermark.Text = "Image Watermark"
            Me.chbWatermark.UseVisualStyleBackColor = True
            '
            'label4
            '
            Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label4.Image = CType(resources.GetObject("label4.Image"), System.Drawing.Image)
            Me.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label4.Location = New System.Drawing.Point(12, 91)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(183, 20)
            Me.label4.TabIndex = 31
            Me.label4.Text = "Select a document to import"
            Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label5
            '
            Me.label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label5.Location = New System.Drawing.Point(19, 113)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(327, 1)
            Me.label5.TabIndex = 32
            '
            'PictureBox3
            '
            Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Top
            Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
            Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox3.Name = "PictureBox3"
            Me.PictureBox3.Size = New System.Drawing.Size(372, 90)
            Me.PictureBox3.TabIndex = 71
            Me.PictureBox3.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(372, 310)
            Me.Controls.Add(Me.PictureBox3)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.chbWatermark)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.txtStamp)
            Me.Controls.Add(Me.txtUrl)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.btnBrowse)
            Me.Controls.Add(Me.btnImport)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Stamp Document"
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
            Application.EnableVisualStyles()
            Application.Run(New Form1())
        End Sub

        Private Sub btnImport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnImport.Click
            Dim lDoc As PdfLoadedDocument = New PdfLoadedDocument(txtUrl.Tag.ToString())
            Dim font As PdfFont = New PdfStandardFont(PdfFontFamily.Helvetica, 36.0F)

            For Each lPage As PdfPageBase In lDoc.Pages
                Dim g As PdfGraphics = lPage.Graphics
                Dim state As PdfGraphicsState = g.Save()
                g.SetTransparency(0.25F)
                g.RotateTransform(-40)
                g.DrawString(txtStamp.Text, font, PdfPens.Red, PdfBrushes.Red, New PointF(-150, 450))

                If chbWatermark.Checked Then
                    Dim image As PdfImage = New PdfBitmap("..\..\..\..\..\..\..\..\..\Common\Images\PDF\Ani.gif")
                    g.Restore(state)
                    g.SetTransparency(0.25F)
                    g.DrawImage(image, 0, 0, lPage.Graphics.ClientSize.Width, lPage.Graphics.ClientSize.Height)
                End If

            Next lPage


            lDoc.Save("Sample.pdf")

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

        Private Sub btnBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowse.Click

            Dim file As OpenFileDialog = New OpenFileDialog()
            file.Filter = "PDF Documents (*.pdf)|*.PDF"

            If file.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txtUrl.Text = file.SafeFileName
                txtUrl.Tag = file.FileName
            End If
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            txtUrl.Text = "Essential_Studio.pdf"
            txtUrl.Tag = "..\..\..\..\..\..\..\..\..\Common\Data\PDF\Essential_Studio.pdf"
        End Sub
	End Class
End Namespace