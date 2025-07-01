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
Imports Syncfusion.Pdf.Lists

Namespace EssentialPDFSamples
    ''' <summary>
    ''' Summary description for Form1.
    ''' </summary>
    Public Class Form1 : Inherits System.Windows.Forms.Form
#Region "Private Members"
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents button1 As System.Windows.Forms.Button
        Private WithEvents label1 As System.Windows.Forms.Label
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.Container = Nothing
#End Region

#Region "Constructors"
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
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.button1 = New System.Windows.Forms.Button
            Me.label1 = New System.Windows.Forms.Label
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(373, 90)
            Me.pictureBox1.TabIndex = 28
            Me.pictureBox1.TabStop = False
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
            Me.button1.Location = New System.Drawing.Point(286, 157)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(75, 24)
            Me.button1.TabIndex = 26
            Me.button1.Text = "PDF"
            Me.button1.UseVisualStyleBackColor = False
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.label1.Location = New System.Drawing.Point(0, 111)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(373, 67)
            Me.label1.TabIndex = 27
            Me.label1.Text = "Click the button to view an PDF document generated by Essential PDF. Please note " & _
                "that Adobe Reader or its equivalent is required to view the resultant document."
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(373, 205)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.label1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Bullets and Lists"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

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
            'Create a new instance of PdfDocument class.
            Dim document As PdfDocument = New PdfDocument()

            'Add a new page to the document.
            Dim page As PdfPage = document.Pages.Add()
            Dim graphics As PdfGraphics = page.Graphics
            Dim sizef As SizeF = page.Graphics.ClientSize

            'Create an unordered list.
            Dim list As PdfUnorderedList = New PdfUnorderedList()

            'Set the marker style.
            list.Marker.Style = PdfUnorderedMarkerStyle.Disk

            'Create font and write title.
            Dim font As PdfFont = New PdfStandardFont(PdfFontFamily.Helvetica, 14, PdfFontStyle.Bold)
            graphics.DrawString("List Features", font, PdfBrushes.DarkBlue, New PointF(225, 10))

            Dim products As String() = {"Tools", "Grid", "Chart", "Edit", "Diagram", "XlsIO", "Grouping", "Calculate", "PDF", "HTMLUI", "DocIO"}
            Dim IO As String() = {"XlsIO", "PDF", "DocIO"}

            font = New PdfStandardFont(PdfFontFamily.Helvetica, 12, PdfFontStyle.Regular)

            graphics.DrawString("This sample demonstrates various features of bullets and lists. Alist can be ordered and Unordered. Essential PDF provides support for creating and formatting ordered and unordered lists.", font, PdfBrushes.Black, New RectangleF(0, 50, page.Graphics.ClientSize.Width, page.Graphics.ClientSize.Height))

            'Create string format
            Dim format As PdfStringFormat = New PdfStringFormat()
            format.LineSpacing = 20.0F

            font = New PdfStandardFont(PdfFontFamily.TimesRoman, 10, PdfFontStyle.Bold)

            ' Format list
            list.Font = font
            list.StringFormat = format

            'Set list indent
            list.Indent = 10

            'Add items to the list
            list.Items.Add("List of Essential Studio products")
            list.Items.Add("IO products")

            'Set text indent
            list.TextIndent = 10

            'Create Ordered list as sublist of parent list
            Dim subList As PdfOrderedList = New PdfOrderedList()
            subList.Marker.Brush = PdfBrushes.Black
            subList.Indent = 20
            list.Items(0).SubList = subList

            'Set format for sub list
            font = New PdfStandardFont(PdfFontFamily.TimesRoman, 10, PdfFontStyle.Italic)
            subList.Font = font
            subList.StringFormat = format
            For Each s As String In products
                subList.Items.Add(String.Concat("Essential ", s))
            Next s

            'Create unorderd sublist for the second item of parent list
            Dim SubsubList As PdfUnorderedList = New PdfUnorderedList()
            SubsubList.Marker.Brush = PdfBrushes.Black
            SubsubList.Indent = 20
            list.Items(1).SubList = SubsubList

            Dim image As PdfImage = PdfImage.FromFile(GetFullTemplatePath("syncfusion_logo.gif", True))
            font = New PdfStandardFont(PdfFontFamily.TimesRoman, 10, PdfFontStyle.Regular)
            SubsubList.Font = font
            SubsubList.StringFormat = format

            'Add subitems
            SubsubList.Items.Add("Essential PDF: It is a .NET library with the capability to produce Adobe PDF files. It features a full-fledged object model for the easy creation of PDF files from any .NET language. It does not use any external libraries and is built from scratch in C#. It can be used on the server side (ASP.NET or any other environment) or with Windows Forms applications. Essential PDF supports many features for creating a PDF document. Drawing Text, Images, Shapes, etc can be drawn easily in the PDF document.")
            SubsubList.Items.Add("Essential DocIO: It is a .NET library that can read and write Microsoft Word files. It features a full-fledged object model similar to the Microsoft Office COM libraries. It does not use COM interop and is built from scratch in C#. It can be used on systems that do not have Microsoft Word installed. Here are some of the most common questions that arise regarding the usage and functionality of Essential DocIO.")
            SubsubList.Items.Add("Essential XlsIO: It is a .NET library that can read and write Microsoft Excel files (BIFF 8 format). It features a full-fledged object model similar to the Microsoft Office COM libraries. It does not use COM interop and is built from scratch in C#. It can be used on systems that do not have Microsoft Excel installed, making it an excellent reporting engine for tabular data. ")

            'Set image as marker
            SubsubList.Marker.Image = image

            'Draw list
            list.Draw(page, New RectangleF(0, 130, page.Graphics.ClientSize.Width, page.Graphics.ClientSize.Height))

            ' Save and close the document.
            document.Save("Sample.pdf")
            document.Close(True)

            'Message box confirmation to view the created PDF document.
            If MessageBox.Show("Do you want to view the PDF file?", "PDF File Created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                'Launching the PDF file using the default Application.[Acrobat Reader]
                System.Diagnostics.Process.Start("Sample.pdf")
                Me.Close()
            Else
                ' Exit
                Me.Close()
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
