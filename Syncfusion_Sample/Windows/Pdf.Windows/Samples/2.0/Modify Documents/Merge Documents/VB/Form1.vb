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
Imports Syncfusion.Pdf.Parsing

Namespace EssentialPDFSamples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private WithEvents btnMerge As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
        Private txtDoc1 As TextBox
		Private txtDoc2 As TextBox
		Private WithEvents btnBrowse1 As Button
		Private WithEvents btnBrowse2 As Button
		Private label2 As Label
		Private label3 As Label
		Private label4 As Label
        Private label5 As Label
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
            Me.btnMerge = New System.Windows.Forms.Button
            Me.label1 = New System.Windows.Forms.Label
            Me.txtDoc1 = New System.Windows.Forms.TextBox
            Me.txtDoc2 = New System.Windows.Forms.TextBox
            Me.btnBrowse1 = New System.Windows.Forms.Button
            Me.btnBrowse2 = New System.Windows.Forms.Button
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.label5 = New System.Windows.Forms.Label
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnMerge
            '
            Me.btnMerge.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnMerge.BackColor = System.Drawing.Color.Transparent
            Me.btnMerge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.btnMerge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnMerge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnMerge.Image = CType(resources.GetObject("btnMerge.Image"), System.Drawing.Image)
            Me.btnMerge.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnMerge.Location = New System.Drawing.Point(267, 242)
            Me.btnMerge.Name = "btnMerge"
            Me.btnMerge.Size = New System.Drawing.Size(98, 23)
            Me.btnMerge.TabIndex = 0
            Me.btnMerge.Text = "Merge PDF"
            Me.btnMerge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnMerge.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(1, 182)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(365, 67)
            Me.label1.TabIndex = 1
            Me.label1.Text = "Click the button to view an PDF document generated by Essential PDF. Please note " & _
                "that Adobe Reader or its equivalent is required to view the resultant document."
            '
            'txtDoc1
            '
            Me.txtDoc1.Location = New System.Drawing.Point(153, 117)
            Me.txtDoc1.Name = "txtDoc1"
            Me.txtDoc1.Size = New System.Drawing.Size(132, 20)
            Me.txtDoc1.TabIndex = 25
            '
            'txtDoc2
            '
            Me.txtDoc2.Location = New System.Drawing.Point(153, 150)
            Me.txtDoc2.Name = "txtDoc2"
            Me.txtDoc2.Size = New System.Drawing.Size(132, 20)
            Me.txtDoc2.TabIndex = 26
            '
            'btnBrowse1
            '
            Me.btnBrowse1.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnBrowse1.Location = New System.Drawing.Point(291, 116)
            Me.btnBrowse1.Name = "btnBrowse1"
            Me.btnBrowse1.Size = New System.Drawing.Size(57, 23)
            Me.btnBrowse1.TabIndex = 27
            Me.btnBrowse1.Text = "Browse"
            Me.btnBrowse1.UseVisualStyleBackColor = True
            '
            'btnBrowse2
            '
            Me.btnBrowse2.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnBrowse2.Location = New System.Drawing.Point(291, 149)
            Me.btnBrowse2.Name = "btnBrowse2"
            Me.btnBrowse2.Size = New System.Drawing.Size(57, 23)
            Me.btnBrowse2.TabIndex = 28
            Me.btnBrowse2.Text = "Browse"
            Me.btnBrowse2.UseVisualStyleBackColor = True
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(21, 120)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(96, 13)
            Me.label2.TabIndex = 29
            Me.label2.Text = "Select a document"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Location = New System.Drawing.Point(21, 150)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(126, 13)
            Me.label3.TabIndex = 30
            Me.label3.Text = "Select another document"
            '
            'label4
            '
            Me.label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label4.Location = New System.Drawing.Point(23, 113)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(325, 1)
            Me.label4.TabIndex = 31
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.ForeColor = System.Drawing.Color.MidnightBlue
            Me.label5.Image = CType(resources.GetObject("label5.Image"), System.Drawing.Image)
            Me.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.label5.Location = New System.Drawing.Point(21, 91)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(181, 22)
            Me.label5.TabIndex = 32
            Me.label5.Text = "Select Documents to Merge"
            Me.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PictureBox2
            '
            Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(373, 90)
            Me.PictureBox2.TabIndex = 33
            Me.PictureBox2.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(373, 283)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.btnBrowse2)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.txtDoc2)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.btnBrowse1)
            Me.Controls.Add(Me.txtDoc1)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.btnMerge)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Merge Documents"
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

        Private Sub btnMerge_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnMerge.Click

            Dim paths As String() = {txtDoc1.Tag.ToString(), txtDoc2.Tag.ToString()}

            Dim doc As PdfDocument = PdfDocument.Merge(paths)

            doc.Save("Sample.pdf")

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

        Private Sub btnBrowse1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowse1.Click
            Dim file As OpenFileDialog = New OpenFileDialog()
            file.Filter = "PDF Documents (*.pdf)|*.PDF"

            If file.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txtDoc1.Text = file.SafeFileName
                txtDoc1.Tag = file.FileName
            End If
        End Sub

        Private Sub btnBrowse2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBrowse2.Click
            Dim file As OpenFileDialog = New OpenFileDialog()
            file.Filter = "PDF Documents (*.pdf)|*.PDF"

            If file.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                txtDoc2.Text = file.SafeFileName
                txtDoc2.Tag = file.FileName
            End If
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            txtDoc1.Tag = "..\..\..\..\..\..\..\..\..\Common\Data\PDF\Essential_Pdf.pdf"
            txtDoc1.Text = "Essential_Pdf.pdf"
            txtDoc2.Tag = "..\..\..\..\..\..\..\..\..\Common\Data\PDF\Essential_XlsIO.pdf"
            txtDoc2.Text = "Essential_XlsIO.pdf"
        End Sub
	End Class
End Namespace
