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
		Private WithEvents btnSplit As System.Windows.Forms.Button
		Private label1 As System.Windows.Forms.Label
        Private label2 As Label
		Private label3 As Label
		Private label4 As Label
		Private txtSplitDoc As TextBox
		Private WithEvents btnBrowse As Button
		Private label5 As Label
		Private nudSplitPage As NumericUpDown
        Private ldoc As PdfLoadedDocument
        Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing

#Region "Form Constructor"
        Public Sub New()
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()

            txtSplitDoc.Text = "Essential_Studio.pdf"
            txtSplitDoc.Tag = "..\..\..\..\..\..\..\..\..\Common\Data\PDF\Essential_Studio.pdf"
            ' To load a existing document which has to be split
            ldoc = New PdfLoadedDocument(txtSplitDoc.Tag.ToString())
            nudSplitPage.Maximum = ldoc.Pages.Count

            AddHandler txtSplitDoc.Validating, AddressOf txtSplitDoc_Validating
            AddHandler nudSplitPage.Validating, AddressOf nudSplitPage_Validating

            '
            ' TODO: Add any constructor code after InitializeComponent call
            '
        End Sub
#End Region



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
            Me.btnSplit = New System.Windows.Forms.Button
            Me.label1 = New System.Windows.Forms.Label
            Me.label2 = New System.Windows.Forms.Label
            Me.label3 = New System.Windows.Forms.Label
            Me.label4 = New System.Windows.Forms.Label
            Me.txtSplitDoc = New System.Windows.Forms.TextBox
            Me.btnBrowse = New System.Windows.Forms.Button
            Me.label5 = New System.Windows.Forms.Label
            Me.nudSplitPage = New System.Windows.Forms.NumericUpDown
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            CType(Me.nudSplitPage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnSplit
            '
            Me.btnSplit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnSplit.BackColor = System.Drawing.Color.Transparent
            Me.btnSplit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.btnSplit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnSplit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnSplit.Image = CType(resources.GetObject("btnSplit.Image"), System.Drawing.Image)
            Me.btnSplit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnSplit.Location = New System.Drawing.Point(283, 251)
            Me.btnSplit.Name = "btnSplit"
            Me.btnSplit.Size = New System.Drawing.Size(77, 23)
            Me.btnSplit.TabIndex = 0
            Me.btnSplit.Text = "Split PDF"
            Me.btnSplit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnSplit.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(0, 182)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(374, 67)
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
            Me.label2.Location = New System.Drawing.Point(12, 96)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(162, 14)
            Me.label2.TabIndex = 25
            Me.label2.Text = "Split Document Settings"
            Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'label3
            '
            Me.label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(143, Byte), Integer), CType(CType(164, Byte), Integer), CType(CType(190, Byte), Integer))
            Me.label3.Location = New System.Drawing.Point(18, 112)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(328, 1)
            Me.label3.TabIndex = 26
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(18, 128)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(107, 14)
            Me.label4.TabIndex = 27
            Me.label4.Text = "Document to split up:"
            '
            'txtSplitDoc
            '
            Me.txtSplitDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtSplitDoc.Location = New System.Drawing.Point(131, 125)
            Me.txtSplitDoc.Name = "txtSplitDoc"
            Me.txtSplitDoc.Size = New System.Drawing.Size(147, 20)
            Me.txtSplitDoc.TabIndex = 28
            '
            'btnBrowse
            '
            Me.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.btnBrowse.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.btnBrowse.Location = New System.Drawing.Point(287, 123)
            Me.btnBrowse.Name = "btnBrowse"
            Me.btnBrowse.Size = New System.Drawing.Size(59, 23)
            Me.btnBrowse.TabIndex = 29
            Me.btnBrowse.Text = "Browse"
            Me.btnBrowse.UseVisualStyleBackColor = True
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(18, 153)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(82, 14)
            Me.label5.TabIndex = 30
            Me.label5.Text = "Page to Split-at:"
            '
            'nudSplitPage
            '
            Me.nudSplitPage.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.nudSplitPage.Location = New System.Drawing.Point(131, 153)
            Me.nudSplitPage.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.nudSplitPage.Name = "nudSplitPage"
            Me.nudSplitPage.Size = New System.Drawing.Size(95, 20)
            Me.nudSplitPage.TabIndex = 31
            Me.nudSplitPage.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'PictureBox2
            '
            Me.PictureBox2.BackColor = System.Drawing.Color.White
            Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Top
            Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
            Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(372, 89)
            Me.PictureBox2.TabIndex = 32
            Me.PictureBox2.TabStop = False
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(372, 291)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.nudSplitPage)
            Me.Controls.Add(Me.label5)
            Me.Controls.Add(Me.btnBrowse)
            Me.Controls.Add(Me.txtSplitDoc)
            Me.Controls.Add(Me.label4)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.btnSplit)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Split Documents"
            CType(Me.nudSplitPage, System.ComponentModel.ISupportInitialize).EndInit()
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

#Region "Events"
        Private Sub txtSplitDoc_Validating(ByVal sender As Object, ByVal e As CancelEventArgs)
            nudSplitPage.Maximum = ldoc.Pages.Count
        End Sub

        Private Sub nudSplitPage_Validating(ByVal sender As Object, ByVal e As CancelEventArgs)
            If CInt(Fix(nudSplitPage.Value)) >= ldoc.Pages.Count Then
                MessageBox.Show("Invalid page number")
            End If
        End Sub

        Private Sub btnSplitPDF_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSplit.Click

            'Create two pdf documents
            Dim doc1 As PdfDocument = New PdfDocument()
            Dim doc2 As PdfDocument = New PdfDocument()

            'Split the source document into two based on the split-at page value.
            Dim splitAtPage As Integer = CInt(Fix(nudSplitPage.Value))
            For i As Integer = 0 To splitAtPage - 1
                doc1.ImportPage(ldoc, i)
            Next i

            For j As Integer = splitAtPage To ldoc.Pages.Count - 1
                doc2.ImportPage(ldoc, j)
            Next j

            'Save pdf document1
            doc1.Save("Document1.pdf")

            'Save pdf document2
            doc2.Save("Document2.pdf")


            'Message box confirmation to view the created PDF document.
            If MessageBox.Show("Do you want to view the PDF file?", "PDF File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = System.Windows.Forms.DialogResult.Yes Then
                'Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Document1.pdf")
                System.Diagnostics.Process.Start("Document2.pdf")
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
                txtSplitDoc.Text = file.SafeFileName
                txtSplitDoc.Tag = file.FileName
                ldoc = New PdfLoadedDocument(txtSplitDoc.Tag.ToString())
                nudSplitPage.Maximum = ldoc.Pages.Count
            End If
        End Sub
#End Region

	End Class
End Namespace
