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
Imports System.Diagnostics

Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS

Namespace EssentialDocIOSamples

	Public Class Form1 : Inherits System.Windows.Forms.Form

#Region "Private Members"

		Private WithEvents button1 As Button
        Private toolTip1 As ToolTip
        Private label2 As Label
        Private pictureBox1 As PictureBox
        Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents Label6 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label4 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label5 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents word2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2007RadioBtn As System.Windows.Forms.RadioButton
        Private components As IContainer
#End Region

#Region "Constructor, Main and Dispose"

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
            Me.button1 = New System.Windows.Forms.Button()
            Me.label2 = New System.Windows.Forms.Label()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.Label6 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.Label5 = New System.Windows.Forms.Label()
            Me.label24 = New System.Windows.Forms.Label()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.GroupBox2 = New System.Windows.Forms.GroupBox()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2003RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2007RadioBtn = New System.Windows.Forms.RadioButton()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.GroupBox2.SuspendLayout()
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
            Me.button1.Location = New System.Drawing.Point(281, 214)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(81, 25)
            Me.button1.TabIndex = 68
            Me.button1.Text = "Generate"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 106)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(374, 58)
            Me.label2.TabIndex = 72
            Me.label2.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" & _
        "ote that MS Word Viewer or MS Word is required to view the resultant document."
            '
            'Label6
            '
            Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
            Me.Label6.Location = New System.Drawing.Point(221, 48)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(20, 18)
            Me.Label6.TabIndex = 106
            Me.toolTip1.SetToolTip(Me.Label6, "Saves the document in Word 2013 format")
            '
            'Label4
            '
            Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
            Me.Label4.Location = New System.Drawing.Point(106, 48)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(20, 18)
            Me.Label4.TabIndex = 104
            Me.toolTip1.SetToolTip(Me.Label4, "Saves the document in Word 2010 format")
            '
            'Label5
            '
            Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
            Me.Label5.Location = New System.Drawing.Point(221, 20)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(20, 18)
            Me.Label5.TabIndex = 101
            Me.toolTip1.SetToolTip(Me.Label5, "Saves the document in Word 2007 format")
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(106, 20)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.toolTip1.SetToolTip(Me.label24, "Saves the document in Word 97-2003 format")
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(374, 97)
            Me.pictureBox1.TabIndex = 70
            Me.pictureBox1.TabStop = False
            '
            'GroupBox2
            '
            Me.GroupBox2.Controls.Add(Me.Label6)
            Me.GroupBox2.Controls.Add(Me.word2013RadioBtn)
            Me.GroupBox2.Controls.Add(Me.Label4)
            Me.GroupBox2.Controls.Add(Me.word2010RadioBtn)
            Me.GroupBox2.Controls.Add(Me.Label5)
            Me.GroupBox2.Controls.Add(Me.label24)
            Me.GroupBox2.Controls.Add(Me.word2003RadioBtn)
            Me.GroupBox2.Controls.Add(Me.word2007RadioBtn)
            Me.GroupBox2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.GroupBox2.Location = New System.Drawing.Point(12, 167)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(251, 72)
            Me.GroupBox2.TabIndex = 101
            Me.GroupBox2.TabStop = False
            Me.GroupBox2.Text = "Save As"
            '
            'word2013RadioBtn
            '
            Me.word2013RadioBtn.AutoSize = True
            Me.word2013RadioBtn.Checked = True
            Me.word2013RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.word2013RadioBtn.Location = New System.Drawing.Point(139, 46)
            Me.word2013RadioBtn.Name = "word2013RadioBtn"
            Me.word2013RadioBtn.Size = New System.Drawing.Size(86, 17)
            Me.word2013RadioBtn.TabIndex = 105
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
            Me.word2010RadioBtn.TabIndex = 103
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
            Me.ClientSize = New System.Drawing.Size(374, 252)
            Me.Controls.Add(Me.GroupBox2)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.button1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Format Table"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
#End Region

#Region "Button Click"
        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            ' Create a new document.
            Dim document As WordDocument = New WordDocument()

            ' Adding a new section to the document.
            Dim section As IWSection = document.AddSection()
            ' Set Margin of the document
            section.PageSetup.Margins.All = 72
            section.PageSetup.DifferentFirstPage = True
            Dim textRange As IWTextRange
            Dim paragraph As IWParagraph = section.AddParagraph()

            ' --------------------------------------------
            ' Table in page header 
            ' --------------------------------------------


            Dim hParagraph As IWParagraph = New WParagraph(document)
            hParagraph.AppendText("Header text" & Constants.vbCrLf).CharacterFormat.FontSize = 14

            section.HeadersFooters.FirstPageHeader.Paragraphs.Add(hParagraph)


            Dim hTable As IWTable = document.LastSection.HeadersFooters.FirstPageHeader.AddTable()

            hTable.ResetCells(2, 2)

            hTable(0, 0).AddParagraph().AppendText("1")
            hTable(0, 1).AddParagraph().AppendText("2")
            hTable(1, 0).AddParagraph().AppendText("3")
            hTable(1, 1).AddParagraph().AppendText("4")


            ' --------------------------------------------
            ' Tiny table
            ' --------------------------------------------

            paragraph = section.AddParagraph()

            paragraph.AppendText("Tiny table" & Constants.vbCrLf).CharacterFormat.FontSize = 14
            paragraph = section.AddParagraph()
            Dim textBody As WTextBody = section.Body
            Dim table As IWTable = textBody.AddTable()
            table.ResetCells(2, 2)

            Dim row_0 As WTableRow = table.Rows(0)
            row_0.Cells(0).AddParagraph().AppendText("A")
            row_0.Cells(0).AddParagraph().AppendText("AA")
            row_0.Cells(0).AddParagraph().AppendText("AAA")

            Dim row_1 As WTableRow = table.Rows(1)
            row_1.Cells(1).AddParagraph().AppendText("B")
            row_1.Cells(1).AddParagraph().AppendText("BB" & Constants.vbCrLf & "BBB")
            row_1.Cells(1).AddParagraph().AppendText("BBB")

            textBody.AddParagraph().AppendText("Text after table...").CharacterFormat.FontSize = 14

            ' --------------------------------------------
            ' Table with different formatting 
            ' --------------------------------------------

            section.AddParagraph()
            paragraph = section.AddParagraph()
            paragraph.AppendText("Table with different formatting" & Constants.vbCrLf).CharacterFormat.FontSize = 14
            paragraph = section.AddParagraph()
            textBody = section.Body
            table = textBody.AddTable()
            table.ResetCells(3, 3)

            ' ------- First Row -------- 

            Dim row0 As WTableRow = table.Rows(0)

            paragraph = CType(row0.Cells(0).AddParagraph(), IWParagraph)
            textRange = paragraph.AppendText("1")
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Left
            textRange.CharacterFormat.FontName = "Arial"
            textRange.CharacterFormat.Bold = True
            textRange.CharacterFormat.FontSize = 14.0F
            row0.Cells(0).CellFormat.Borders.LineWidth = 2.0F
            row0.Cells(0).CellFormat.Borders.Color = Color.Magenta

            paragraph = CType(row0.Cells(1).AddParagraph(), IWParagraph)
            textRange = paragraph.AppendText("2")
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right
            textRange.CharacterFormat.Emboss = True
            textRange.CharacterFormat.FontSize = 15.0F
            row0.Cells(1).CellFormat.Borders.LineWidth = 1.3F
            row0.Cells(1).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DoubleWave

            paragraph = CType(row0.Cells(2).AddParagraph(), IWParagraph)
            textRange = paragraph.AppendText("3")
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Left
            textRange.CharacterFormat.Engrave = True
            textRange.CharacterFormat.FontSize = 15.0F
            row0.Cells(2).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Emboss3D

            ' ------- Second Row -------- 

            Dim row1 As WTableRow = table.Rows(1)

            paragraph = CType(row1.Cells(0).AddParagraph(), IWParagraph)
            textRange = paragraph.AppendText("4")
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            textRange.CharacterFormat.SmallCaps = True
            textRange.CharacterFormat.FontName = "Comic Sans MS"
            textRange.CharacterFormat.FontSize = 16
            row1.Cells(0).CellFormat.Borders.LineWidth = 2.0F
            row1.Cells(0).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DashDotStroker

            paragraph = CType(row1.Cells(1).AddParagraph(), IWParagraph)
            textRange = paragraph.AppendText("5")
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            textRange.CharacterFormat.FontName = "Times New Roman"
            textRange.CharacterFormat.Shadow = True
            textRange.CharacterFormat.TextBackgroundColor = Color.Orange
            textRange.CharacterFormat.FontSize = 15.0F
            row1.Cells(1).CellFormat.Borders.LineWidth = 2.0F
            row1.Cells(1).CellFormat.Borders.Color = Color.Brown

            paragraph = CType(row1.Cells(2).AddParagraph(), IWParagraph)
            textRange = paragraph.AppendText("6")
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            textRange.CharacterFormat.Bold = True
            textRange.CharacterFormat.FontSize = 14.0F
            row1.Cells(2).CellFormat.BackColor = Color.FromArgb(51, 51, 101)
            row1.Cells(2).CellFormat.VerticalAlignment = VerticalAlignment.Middle

            ' ------- Third Row -------- 

            Dim row2 As WTableRow = table.Rows(2)

            paragraph = CType(row2.Cells(0).AddParagraph(), IWParagraph)
            textRange = paragraph.AppendText("7")
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right
            textRange.CharacterFormat.FontSize = 13.0F
            row2.Cells(0).CellFormat.Borders.LineWidth = 1.5F
            row2.Cells(0).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DashLargeGap

            paragraph = CType(row2.Cells(1).AddParagraph(), IWParagraph)
            textRange = paragraph.AppendText("8")
            textRange.CharacterFormat.TextColor = Color.Blue
            textRange.CharacterFormat.FontSize = 16.0F
            row2.Cells(1).CellFormat.Borders.LineWidth = 3.0F
            row2.Cells(1).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Wave

            paragraph = CType(row2.Cells(2).AddParagraph(), IWParagraph)
            textRange = paragraph.AppendText("9")
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Right
            row2.Cells(2).CellFormat.Borders.LineWidth = 2.0F
            row2.Cells(2).CellFormat.Borders.Color = Color.Cyan
            row2.Cells(2).CellFormat.Borders.Shadow = True
            row2.Cells(2).CellFormat.Borders.Space = 20

            ' --------------------------------------------
            ' Table Cell Merging.
            ' --------------------------------------------

            section.AddParagraph()
            paragraph = section.AddParagraph()
            paragraph.AppendText("Table Cell Merging...").CharacterFormat.FontSize = 14
            section.AddParagraph()
            paragraph = section.AddParagraph()
            textBody = section.Body

            ' Adding a new Table to the textbody.
            table = textBody.AddTable()

            Dim format As RowFormat = New RowFormat()
            format.Paddings.All = 5
            format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Dot
            format.Borders.LineWidth = 2

            ' Inserting rows to the table.
            table.ResetCells(6, 6, format, 80)

            ' Table formatting with cell merging.
            table.Rows(0).Cells(0).CellFormat.HorizontalMerge = CellMerge.Start
            table.Rows(0).Cells(1).CellFormat.HorizontalMerge = CellMerge.Continue
            table.Rows(0).Cells(0).CellFormat.VerticalAlignment = VerticalAlignment.Middle
            table.Rows(0).Cells(0).CellFormat.BackColor = Color.FromArgb(218, 230, 246)
            Dim par As IWParagraph = table.Rows(0).Cells(0).AddParagraph()
            par.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            par.AppendText("Horizontal Merge").CharacterFormat.Bold = True


            table.Rows(2).Cells(3).CellFormat.VerticalMerge = CellMerge.Start
            table.Rows(3).Cells(3).CellFormat.VerticalMerge = CellMerge.Continue

            table.Rows(2).Cells(3).CellFormat.VerticalAlignment = VerticalAlignment.Middle
            par = table.Rows(2).Cells(3).AddParagraph()
            table.Rows(2).Cells(3).CellFormat.BackColor = Color.FromArgb(252, 172, 85)
            par.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            par.AppendText("Vertical Merge").CharacterFormat.Bold = True


            ' --------------------------------------------
            ' Table Cell Spacing.
            ' --------------------------------------------

            section.AddParagraph()
            paragraph = section.AddParagraph()
            paragraph.AppendText("Table Cell spacing...").CharacterFormat.FontSize = 14

            section.AddParagraph()
            paragraph = section.AddParagraph()
            textBody = section.Body

            ' Adding a new Table to the textbody.
            table = textBody.AddTable()

            format = New RowFormat()

            format.CellSpacing = 5
            format.Paddings.All = 5
            format.CellSpacing = 2.5F
            format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DotDash
            format.IsBreakAcrossPages = True
            table.ResetCells(25, 5, format, 100)
            Dim text As IWTextRange
            table.Rows(0).IsHeader = True

            Dim i As Integer = 0
            'ORIGINAL LINE: for (int i = 0; i < table.Rows[0].Cells.Count; i += 1)
            'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
            Do While i < table.Rows(0).Cells.Count
                paragraph = TryCast(table(0, i).AddParagraph(), WParagraph)
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
                text = paragraph.AppendText(String.Format("Header {0}", i + 1))
                text.CharacterFormat.Font = New Font("Bitstream Vera Serif", 10)
                text.CharacterFormat.Bold = True
                text.CharacterFormat.TextColor = Color.FromArgb(0, 21, 84)
                table(0, i).CellFormat.BackColor = Color.FromArgb(203, 211, 226)
                i += 1
            Loop

            i = 1
            'ORIGINAL LINE: for (int i = 1; i < table.Rows.Count; i += 1)
            'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
            Do While i < table.Rows.Count
                For j As Integer = 0 To 4
                    paragraph = TryCast(table(i, j).AddParagraph(), WParagraph)
                    paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center

                    text = paragraph.AppendText(String.Format("Cell {0} , {1}", i, j + 1))
                    text.CharacterFormat.TextColor = Color.FromArgb(242, 151, 50)
                    text.CharacterFormat.Bold = True
                    If i Mod 2 <> 1 Then
                        table(i, j).CellFormat.BackColor = Color.FromArgb(231, 235, 245)
                    Else
                        table(i, j).CellFormat.BackColor = Color.FromArgb(246, 249, 255)
                    End If

                Next j

                i += 1
            Loop


            ' --------------------------------------------
            ' Nested Table.
            ' --------------------------------------------

            section.AddParagraph()
            paragraph = section.AddParagraph()
            paragraph.ParagraphFormat.PageBreakBefore = True
            paragraph.AppendText("Nested Table...").CharacterFormat.FontSize = 14

            section.AddParagraph()
            paragraph = section.AddParagraph()
            textBody = section.Body

            ' Adding a new Table to the textbody.
            table = textBody.AddTable()

            format = New RowFormat()
            format.Paddings.All = 5
            format.CellSpacing = 2.5F
            format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DotDash
            table.ResetCells(5, 3, format, 100)


            i = 0
            'ORIGINAL LINE: for (int i = 0; i < table.Rows[0].Cells.Count; i += 1)
            'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
            Do While i < table.Rows(0).Cells.Count
                paragraph = TryCast(table(0, i).AddParagraph(), WParagraph)
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
                text = paragraph.AppendText(String.Format("Header {0}", i + 1))
                text.CharacterFormat.Font = New Font("Bitstream Vera Serif", 10)
                text.CharacterFormat.Bold = True
                text.CharacterFormat.TextColor = Color.FromArgb(0, 21, 84)
                table(0, i).CellFormat.BackColor = Color.FromArgb(242, 151, 50)
                i += 1
            Loop
            table(0, 2).Width = 200
            i = 1
            'ORIGINAL LINE: for (int i = 1; i < table.Rows.Count; i += 1)
            'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
            Do While i < table.Rows.Count
                For j As Integer = 0 To 2
                    paragraph = TryCast(table(i, j).AddParagraph(), WParagraph)
                    paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center

                    If (i = 2) AndAlso (j = 2) Then
                        text = paragraph.AppendText("Nested Table")

                    Else
                        text = paragraph.AppendText(String.Format("Cell {0} , {1}", i, j + 1))
                    End If

                    If (j = 2) Then
                        table(i, j).Width = 200
                    End If

                    text.CharacterFormat.TextColor = Color.FromArgb(242, 151, 50)
                    text.CharacterFormat.Bold = True

                Next j

                i += 1
            Loop

            ' Adding a nested Table.
            Dim nestTable As IWTable = table(2, 2).AddTable()

            format = New RowFormat()

            format.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.DotDash
            format.HorizontalAlignment = RowAlignment.Center
            nestTable.ResetCells(3, 3, format, 50)

            i = 0
            'ORIGINAL LINE: for (int i = 0; i < nestTable.Rows.Count; i += 1)
            'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
            Do While i < nestTable.Rows.Count
                For j As Integer = 0 To 2
                    paragraph = TryCast(nestTable(i, j).AddParagraph(), WParagraph)
                    paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center

                    nestTable(i, j).CellFormat.BackColor = Color.FromArgb(231, 235, 245)
                    text = paragraph.AppendText(String.Format("Cell {0} , {1}", i, j + 1))
                    text.CharacterFormat.TextColor = Color.Black
                    text.CharacterFormat.Bold = True
                Next j
                i += 1
            Loop

            '	#Region "Table with Images"
            Dim dataPath As String = Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\images\DocIO\"

            'Add a new section to the document.
            section = document.AddSection()
            'Add paragraph to the section.
            paragraph = section.AddParagraph()
            'Writing text.
            textRange = paragraph.AppendText("Table with Images")
            textRange.CharacterFormat.FontSize = 13.0F
            textRange.CharacterFormat.TextColor = Color.DarkBlue
            textRange.CharacterFormat.Bold = True

            'Add paragraph to the section.
            section.AddParagraph()
            paragraph = section.AddParagraph()

            text = Nothing

            'Adding a new Table to the paragraph.
            table = section.Body.AddTable()
            table.ResetCells(1, 3)

            'Adding rows to the table.
            Dim row As WTableRow = table.Rows(0)
            'Set heading row height
            row.Height = 25.0F
            'set heading values to the Table.
            For i1 As Integer = 0 To 2
                'Add paragraph for writing Text to the cells.
                paragraph = CType(row.Cells(i1).AddParagraph(), IWParagraph)
                'Set Horizontal Alignment as Center.
                paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
                'Writing Row Heading
                Select Case i1
                    Case 0
                        text = paragraph.AppendText("SNO")
                        row.Cells(i1).Width = 50.0F
                    Case 1
                        text = paragraph.AppendText("Product Name")
                    Case 2
                        text = paragraph.AppendText("Product Image")
                        row.Cells(i1).Width = 200.0F
                End Select
                'Set row Heading formatting
                text.CharacterFormat.Bold = True
                text.CharacterFormat.FontName = "Cambria"
                text.CharacterFormat.FontSize = 11.0F
                text.CharacterFormat.TextColor = Color.White

                'Set row cells formatting
                row.Cells(i1).CellFormat.VerticalAlignment = VerticalAlignment.Middle
                row.Cells(i1).CellFormat.BackColor = Color.FromArgb(157, 161, 190)

                row.Cells(i1).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single
            Next i1

            Dim sno As Integer = 1
            'Writing Sno, Product name and Product Images to the Table.

            row1 = table.AddRow(False)

            'Writing SNO to the table with formatting text.
            paragraph = CType(row1.Cells(0).AddParagraph(), IWParagraph)
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            text = paragraph.AppendText(sno.ToString())
            text.CharacterFormat.Bold = True
            text.CharacterFormat.FontSize = 10.0F
            row1.Cells(0).CellFormat.VerticalAlignment = VerticalAlignment.Middle
            row1.Cells(0).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single
            row1.Cells(0).CellFormat.BackColor = Color.FromArgb(217, 223, 239)
            'Writing Product Name to the table with Formatting.
            paragraph = CType(row1.Cells(1).AddParagraph(), IWParagraph)
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            text = paragraph.AppendText("Essential DocIO")
            text.CharacterFormat.Bold = True
            text.CharacterFormat.FontSize = 10.0F
            text.CharacterFormat.TextColor = Color.FromArgb(50, 65, 124)
            row1.Cells(1).CellFormat.VerticalAlignment = VerticalAlignment.Middle
            row1.Cells(1).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single
            row1.Cells(1).CellFormat.BackColor = Color.FromArgb(217, 223, 239)

            'Writing Product Images to the Table.
            paragraph = CType(row1.Cells(2).AddParagraph(), IWParagraph)
            paragraph.AppendPicture(Image.FromFile(dataPath & "DocIO.gif"))
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            row1.Cells(2).CellFormat.VerticalAlignment = VerticalAlignment.Middle
            row1.Cells(2).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single
            row1.Cells(2).CellFormat.BackColor = Color.FromArgb(217, 223, 239)
            sno += 1
            row1 = table.AddRow(False)

            'Writing SNO to the table with formatting text.
            paragraph = CType(row1.Cells(0).AddParagraph(), IWParagraph)
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            text = paragraph.AppendText(sno.ToString())
            text.CharacterFormat.Bold = True
            text.CharacterFormat.FontSize = 10.0F
            row1.Cells(0).CellFormat.VerticalAlignment = VerticalAlignment.Middle
            row1.Cells(0).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single
            row1.Cells(0).CellFormat.BackColor = Color.FromArgb(217, 223, 239)
            'Writing Product Name to the table with Formatting.
            paragraph = CType(row1.Cells(1).AddParagraph(), IWParagraph)
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            text = paragraph.AppendText("Essential PDF")
            text.CharacterFormat.Bold = True
            text.CharacterFormat.FontSize = 10.0F
            text.CharacterFormat.TextColor = Color.FromArgb(50, 65, 124)
            row1.Cells(1).CellFormat.VerticalAlignment = VerticalAlignment.Middle
            row1.Cells(1).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single
            row1.Cells(1).CellFormat.BackColor = Color.FromArgb(217, 223, 239)

            'Writing Product Images to the Table.
            paragraph = CType(row1.Cells(2).AddParagraph(), IWParagraph)
            paragraph.AppendPicture(Image.FromFile(dataPath & "PDF.gif"))
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            row1.Cells(2).CellFormat.VerticalAlignment = VerticalAlignment.Middle
            row1.Cells(2).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single
            row1.Cells(2).CellFormat.BackColor = Color.FromArgb(217, 223, 239)
            sno += 1
            row1 = table.AddRow(False)

            'Writing SNO to the table with formatting text.
            paragraph = CType(row1.Cells(0).AddParagraph(), IWParagraph)
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            text = paragraph.AppendText(sno.ToString())
            text.CharacterFormat.Bold = True
            text.CharacterFormat.FontSize = 10.0F
            row1.Cells(0).CellFormat.VerticalAlignment = VerticalAlignment.Middle
            row1.Cells(0).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single
            row1.Cells(0).CellFormat.BackColor = Color.FromArgb(217, 223, 239)
            'Writing Product Name to the table with Formatting.
            paragraph = CType(row1.Cells(1).AddParagraph(), IWParagraph)
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            text = paragraph.AppendText("Essential XlsIO")
            text.CharacterFormat.Bold = True
            text.CharacterFormat.FontSize = 10.0F
            text.CharacterFormat.TextColor = Color.FromArgb(50, 65, 124)
            row1.Cells(1).CellFormat.VerticalAlignment = VerticalAlignment.Middle
            row1.Cells(1).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single
            row1.Cells(1).CellFormat.BackColor = Color.FromArgb(217, 223, 239)

            'Writing Product Images to the Table.
            paragraph = CType(row1.Cells(2).AddParagraph(), IWParagraph)
            paragraph.AppendPicture(Image.FromFile(dataPath & "XlsIO.gif"))
            paragraph.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            row1.Cells(2).CellFormat.VerticalAlignment = VerticalAlignment.Middle
            row1.Cells(2).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Single
            row1.Cells(2).CellFormat.BackColor = Color.FromArgb(217, 223, 239)
            sno += 1
            '			#End Region ' Table with Images
            'Save as word 2003  format
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
                'Save as word 2010 format
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
                        MessageBox.Show("Word 2007 is not installed in this system")
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

        End Sub
#End Region
	End Class
End Namespace
