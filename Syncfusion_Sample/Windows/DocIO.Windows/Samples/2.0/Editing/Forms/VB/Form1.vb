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

Imports Syncfusion.DocIO.DLS
Imports Syncfusion.DocIO

Namespace EssentialDocIOSamples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form

        Private components As System.ComponentModel.IContainer
        Private WithEvents btnFill As System.Windows.Forms.Button
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents word2007RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents label1 As System.Windows.Forms.Label
        Private WithEvents label3 As System.Windows.Forms.Label
        Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
        Private WithEvents Label4 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents button1 As System.Windows.Forms.Button
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.button1 = New System.Windows.Forms.Button()
            Me.btnFill = New System.Windows.Forms.Button()
            Me.pictureBox1 = New System.Windows.Forms.PictureBox()
            Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
            Me.label24 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.Label4 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.word2007RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2003RadioBtn = New System.Windows.Forms.RadioButton()
            Me.word2010RadioBtn = New System.Windows.Forms.RadioButton()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.word2013RadioBtn = New System.Windows.Forms.RadioButton()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'button1
            '
            Me.button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.button1.BackColor = System.Drawing.Color.Transparent
            Me.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.button1.ForeColor = System.Drawing.SystemColors.ControlText
            Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
            Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.button1.Location = New System.Drawing.Point(272, 180)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(89, 23)
            Me.button1.TabIndex = 74
            Me.button1.Text = "Create Form"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
            '
            'btnFill
            '
            Me.btnFill.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnFill.BackColor = System.Drawing.Color.Transparent
            Me.btnFill.Enabled = False
            Me.btnFill.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.btnFill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnFill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.btnFill.ForeColor = System.Drawing.SystemColors.ControlText
            Me.btnFill.Image = CType(resources.GetObject("btnFill.Image"), System.Drawing.Image)
            Me.btnFill.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnFill.Location = New System.Drawing.Point(272, 213)
            Me.btnFill.Name = "btnFill"
            Me.btnFill.Size = New System.Drawing.Size(89, 23)
            Me.btnFill.TabIndex = 75
            Me.btnFill.Text = "Fill Form"
            Me.btnFill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnFill.UseVisualStyleBackColor = False
            '
            'pictureBox1
            '
            Me.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top
            Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
            Me.pictureBox1.Location = New System.Drawing.Point(0, 0)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(373, 97)
            Me.pictureBox1.TabIndex = 76
            Me.pictureBox1.TabStop = False
            '
            'label24
            '
            Me.label24.Image = CType(resources.GetObject("label24.Image"), System.Drawing.Image)
            Me.label24.Location = New System.Drawing.Point(106, 20)
            Me.label24.Name = "label24"
            Me.label24.Size = New System.Drawing.Size(20, 18)
            Me.label24.TabIndex = 100
            Me.toolTip1.SetToolTip(Me.label24, "Saves the document in Word 97-2003 format" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
            '
            'label1
            '
            Me.label1.Image = CType(resources.GetObject("label1.Image"), System.Drawing.Image)
            Me.label1.Location = New System.Drawing.Point(221, 20)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(20, 18)
            Me.label1.TabIndex = 101
            Me.toolTip1.SetToolTip(Me.label1, "Saves the document in Word 2007 format")
            '
            'label3
            '
            Me.label3.Image = CType(resources.GetObject("label3.Image"), System.Drawing.Image)
            Me.label3.Location = New System.Drawing.Point(106, 45)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(20, 18)
            Me.label3.TabIndex = 102
            Me.toolTip1.SetToolTip(Me.label3, "Saves the document in Word 2010 format")
            '
            'Label4
            '
            Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
            Me.Label4.Location = New System.Drawing.Point(221, 45)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(20, 18)
            Me.Label4.TabIndex = 104
            Me.toolTip1.SetToolTip(Me.Label4, "Saves the document in Word 2013 format")
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 108)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(373, 58)
            Me.label2.TabIndex = 80
            Me.label2.Text = "Click the button to view the Word document generated by Essential DocIO. Please n" & _
        "ote that MS Word Viewer or MS Word is required to view the resultant document."
            '
            'word2007RadioBtn
            '
            Me.word2007RadioBtn.AutoSize = True
            Me.word2007RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.word2007RadioBtn.ForeColor = System.Drawing.Color.Black
            Me.word2007RadioBtn.Location = New System.Drawing.Point(139, 20)
            Me.word2007RadioBtn.Name = "word2007RadioBtn"
            Me.word2007RadioBtn.Size = New System.Drawing.Size(86, 17)
            Me.word2007RadioBtn.TabIndex = 45
            Me.word2007RadioBtn.Text = "Word 2007"
            Me.word2007RadioBtn.UseVisualStyleBackColor = True
            '
            'word2003RadioBtn
            '
            Me.word2003RadioBtn.AutoSize = True
            Me.word2003RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.word2003RadioBtn.ForeColor = System.Drawing.Color.Black
            Me.word2003RadioBtn.Location = New System.Drawing.Point(6, 20)
            Me.word2003RadioBtn.Name = "word2003RadioBtn"
            Me.word2003RadioBtn.Size = New System.Drawing.Size(105, 17)
            Me.word2003RadioBtn.TabIndex = 44
            Me.word2003RadioBtn.Text = "Word 97-2003"
            Me.word2003RadioBtn.UseVisualStyleBackColor = True
            '
            'word2010RadioBtn
            '
            Me.word2010RadioBtn.AutoSize = True
            Me.word2010RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.word2010RadioBtn.ForeColor = System.Drawing.Color.Black
            Me.word2010RadioBtn.Location = New System.Drawing.Point(6, 43)
            Me.word2010RadioBtn.Name = "word2010RadioBtn"
            Me.word2010RadioBtn.Size = New System.Drawing.Size(86, 17)
            Me.word2010RadioBtn.TabIndex = 46
            Me.word2010RadioBtn.Text = "Word 2010"
            Me.word2010RadioBtn.UseVisualStyleBackColor = True
            '
            'groupBox1
            '
            Me.groupBox1.Controls.Add(Me.Label4)
            Me.groupBox1.Controls.Add(Me.word2013RadioBtn)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.label24)
            Me.groupBox1.Controls.Add(Me.word2010RadioBtn)
            Me.groupBox1.Controls.Add(Me.word2003RadioBtn)
            Me.groupBox1.Controls.Add(Me.word2007RadioBtn)
            Me.groupBox1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.groupBox1.Location = New System.Drawing.Point(12, 166)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(247, 70)
            Me.groupBox1.TabIndex = 100
            Me.groupBox1.TabStop = False
            Me.groupBox1.Text = "Save As"
            '
            'word2013RadioBtn
            '
            Me.word2013RadioBtn.AutoSize = True
            Me.word2013RadioBtn.Checked = True
            Me.word2013RadioBtn.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.word2013RadioBtn.ForeColor = System.Drawing.Color.Black
            Me.word2013RadioBtn.Location = New System.Drawing.Point(139, 43)
            Me.word2013RadioBtn.Name = "word2013RadioBtn"
            Me.word2013RadioBtn.Size = New System.Drawing.Size(86, 17)
            Me.word2013RadioBtn.TabIndex = 103
            Me.word2013RadioBtn.TabStop = True
            Me.word2013RadioBtn.Text = "Word 2013"
            Me.word2013RadioBtn.UseVisualStyleBackColor = True
            '
            'Form1
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(373, 247)
            Me.Controls.Add(Me.groupBox1)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.btnFill)
            Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Forms"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
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

#Region "Create Form fields"
        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            ' Create a new document.
            Dim document As WordDocument = New WordDocument()

            ' Adding a new section to the document.
            Dim section As IWSection = document.AddSection()

            ' Adding a new paragraph to the section.
            Dim paragraph As IWParagraph = section.AddParagraph()

            'Create a TextRange
            Dim text As IWTextRange = Nothing

            'Set background color.
            document.Background.Gradient.Color1 = Color.FromArgb(232, 232, 232)
            document.Background.Gradient.Color2 = Color.FromArgb(255, 255, 255)
            document.Background.Type = BackgroundType.Gradient
            document.Background.Gradient.ShadingStyle = GradientShadingStyle.Horizontal
            document.Background.Gradient.ShadingVariant = GradientShadingVariant.ShadingDown

            section.PageSetup.Margins.All = 72.0F
            section.PageSetup.PageSize = New SizeF(612, 792)

            Dim table As IWTable = section.Body.AddTable()
            table.ResetCells(1, 2)

            Dim row As WTableRow = table.Rows(0)
            row.Height = 25.0F

            Dim cellPara As IWParagraph = row.Cells(0).AddParagraph()
            Dim img As Image = Image.FromFile("..\..\..\..\..\..\..\..\..\Common\images\DocIO\image.jpg")
            Dim pic As IWPicture = cellPara.AppendPicture(img)
            pic.Height = 80
            pic.Width = 180

            cellPara = row.Cells(1).AddParagraph()
            row.Cells(1).CellFormat.VerticalAlignment = VerticalAlignment.Middle
            row.Cells(1).CellFormat.BackColor = Color.FromArgb(173, 215, 255)
            Dim txt As IWTextRange = cellPara.AppendText("Job Application Form")
            cellPara.ParagraphFormat.HorizontalAlignment = Syncfusion.DocIO.DLS.HorizontalAlignment.Center
            txt.CharacterFormat.Bold = True
            txt.CharacterFormat.FontName = "Arial"
            txt.CharacterFormat.FontSize = 18.0F

            row.Cells(0).Width = 200
            row.Cells(1).Width = 300
            'row.Cells(1).CellFormat.FitText = True
            row.Cells(1).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Hairline

            section.AddParagraph()

            table = section.Body.AddTable()
            table.ResetCells(2, 1)
            row = table.Rows(0)
            row.Height = 20
            row.Cells(0).Width = 500
            cellPara = row.Cells(0).AddParagraph()
            row.Cells(0).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Thick
            row.Cells(0).CellFormat.Borders.Color = Color.FromArgb(155, 205, 255)
            row.Cells(0).CellFormat.BackColor = Color.FromArgb(198, 227, 255)
            row.Cells(0).CellFormat.VerticalAlignment = VerticalAlignment.Middle
            txt = cellPara.AppendText(" General Information")
            txt.CharacterFormat.FontName = "Arial"
            txt.CharacterFormat.Bold = True
            txt.CharacterFormat.FontSize = 11.0F

            row = table.Rows(1)
            cellPara = row.Cells(0).AddParagraph()
            row.Cells(0).Width = 500
            row.Cells(0).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Hairline
            row.Cells(0).CellFormat.Borders.Color = Color.FromArgb(155, 205, 255)
            row.Cells(0).CellFormat.BackColor = Color.FromArgb(222, 239, 255)

            txt = cellPara.AppendText(Constants.vbLf & " Full Name:" & Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab)
            txt.CharacterFormat.FontName = "Arial"
            txt.CharacterFormat.FontSize = 11.0F
            Dim txtField As WTextFormField = cellPara.AppendTextFormField(Nothing)
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue
            txtField.TextRange.CharacterFormat.FontName = "Arial"
            txtField.TextRange.CharacterFormat.FontSize = 11.0F

            txt = cellPara.AppendText(Constants.vbLf + Constants.vbLf & " Birth Date:" & Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab)
            txt.CharacterFormat.FontName = "Arial"
            txt.CharacterFormat.FontSize = 11.0F
            txtField = cellPara.AppendTextFormField("BirthDayField", DateTime.Now.ToString("M/dd/yyyy"))
            txtField.StringFormat = "M/dd/yyyy"
            txtField.Type = TextFormFieldType.DateText

            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue
            txtField.TextRange.CharacterFormat.FontName = "Arial"
            txtField.TextRange.CharacterFormat.FontSize = 11.0F

            txtField.CharacterFormat.TextColor = Color.MidnightBlue
            txtField.CharacterFormat.FontName = "Arial"
            txtField.CharacterFormat.FontSize = 11.0F

            txt = cellPara.AppendText(Constants.vbLf + Constants.vbLf & " Address:" & Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab)
            txt.CharacterFormat.FontName = "Arial"
            txt.CharacterFormat.FontSize = 11.0F
            txtField = cellPara.AppendTextFormField(Nothing)
            txtField.Type = TextFormFieldType.RegularText
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue
            txtField.TextRange.CharacterFormat.FontName = "Arial"
            txtField.TextRange.CharacterFormat.FontSize = 11.0F

            txt = cellPara.AppendText(Constants.vbLf + Constants.vbLf & " Phone:" & Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab)
            txt.CharacterFormat.FontName = "Arial"
            txt.CharacterFormat.FontSize = 11.0F
            txtField = cellPara.AppendTextFormField(Nothing)
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue
            txtField.TextRange.CharacterFormat.FontName = "Arial"
            txtField.TextRange.CharacterFormat.FontSize = 11.0F

            txt = cellPara.AppendText(Constants.vbLf + Constants.vbLf & " Email:" & Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab)
            txt.CharacterFormat.FontName = "Arial"
            txt.CharacterFormat.FontSize = 11.0F
            txtField = cellPara.AppendTextFormField(Nothing)
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue
            txtField.TextRange.CharacterFormat.FontName = "Arial"
            txtField.TextRange.CharacterFormat.FontSize = 11.0F
            cellPara.AppendText(Constants.vbLf)

            section.AddParagraph()

            table = section.Body.AddTable()
            table.ResetCells(2, 1)
            row = table.Rows(0)
            row.Height = 20
            row.Cells(0).Width = 500
            cellPara = row.Cells(0).AddParagraph()
            row.Cells(0).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Thick
            row.Cells(0).CellFormat.Borders.Color = Color.FromArgb(155, 205, 255)
            row.Cells(0).CellFormat.BackColor = Color.FromArgb(198, 227, 255)
            row.Cells(0).CellFormat.VerticalAlignment = VerticalAlignment.Middle
            txt = cellPara.AppendText(" Educational Qualification")
            txt.CharacterFormat.FontName = "Arial"
            txt.CharacterFormat.Bold = True
            txt.CharacterFormat.FontSize = 11.0F

            row = table.Rows(1)
            cellPara = row.Cells(0).AddParagraph()
            row.Cells(0).Width = 500
            row.Cells(0).CellFormat.Borders.BorderType = Syncfusion.DocIO.DLS.BorderStyle.Hairline
            row.Cells(0).CellFormat.Borders.Color = Color.FromArgb(155, 205, 255)
            row.Cells(0).CellFormat.BackColor = Color.FromArgb(222, 239, 255)

            txt = cellPara.AppendText(Constants.vbLf & " Type:" & Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab)
            txt.CharacterFormat.FontName = "Arial"
            txt.CharacterFormat.FontSize = 11.0F
            Dim dropField As WDropDownFormField = cellPara.AppendDropDownFormField()
            dropField.DropDownItems.Add("Higher")
            dropField.DropDownItems.Add("Vocational")
            dropField.DropDownItems.Add("Universal")
            dropField.CharacterFormat.TextColor = Color.MidnightBlue
            dropField.CharacterFormat.FontName = "Arial"
            dropField.CharacterFormat.FontSize = 11.0F

            txt = cellPara.AppendText(Constants.vbLf + Constants.vbLf & " Institution:" & Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab)
            txt.CharacterFormat.FontName = "Arial"
            txt.CharacterFormat.FontSize = 11.0F
            txtField = cellPara.AppendTextFormField(Nothing)
            txtField.TextRange.CharacterFormat.TextColor = Color.MidnightBlue
            txtField.TextRange.CharacterFormat.FontName = "Arial"
            txtField.CharacterFormat.FontSize = 11.0F

            txt = cellPara.AppendText(Constants.vbLf + Constants.vbLf & " Programming Languages:")
            txt.CharacterFormat.FontName = "Arial"
            txt.CharacterFormat.FontSize = 11.0F
            txt = cellPara.AppendText(Constants.vbLf + Constants.vbLf + Constants.vbTab & " C#:" & Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab)
            txt.CharacterFormat.FontName = "Arial"
            txt.CharacterFormat.FontSize = 9.0F
            dropField = cellPara.AppendDropDownFormField()
            dropField.DropDownItems.Add("Perfect")
            dropField.DropDownItems.Add("Good")
            dropField.DropDownItems.Add("Excellent")
            dropField.CharacterFormat.TextColor = Color.MidnightBlue
            dropField.CharacterFormat.FontName = "Arial"
            dropField.CharacterFormat.FontSize = 11.0F

            txt = cellPara.AppendText(Constants.vbLf + Constants.vbLf + Constants.vbTab & " VB:" & Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab)
            txt.CharacterFormat.FontName = "Arial"
            txt.CharacterFormat.FontSize = 9.0F
            dropField = cellPara.AppendDropDownFormField()
            dropField.DropDownItems.Add("Perfect")
            dropField.DropDownItems.Add("Good")
            dropField.DropDownItems.Add("Excellent")
            dropField.CharacterFormat.TextColor = Color.MidnightBlue
            dropField.CharacterFormat.FontName = "Arial"
            dropField.CharacterFormat.FontSize = 11.0F

            btnFill.Enabled = True

            'Protect document
            document.ProtectionType = ProtectionType.AllowOnlyFormFields
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

#Region "Fill form fields"
        Private Sub btnFill_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFill.Click
            ' Create a new document.
            Dim document As WordDocument = New WordDocument("Sample.doc")
            Dim sec As IWSection = document.LastSection
            Dim textFF As WTextFormField
            Dim dropFF As WDropDownFormField

            'Access the text field
            textFF = CType(IIf(TypeOf sec.Body.FormFields(0) Is WTextFormField, sec.Body.FormFields(0), Nothing), WTextFormField)

            'Fill value for the textfield
            textFF.TextRange.Text = "John"

            'Access the form field with feild name
            textFF = CType(IIf(TypeOf sec.Body.FormFields("BirthDayField") Is WTextFormField, sec.Body.FormFields("BirthDayField"), Nothing), WTextFormField)
            textFF.TextRange.Text = "5.13.1980"

            textFF = CType(IIf(TypeOf sec.Body.FormFields(2) Is WTextFormField, sec.Body.FormFields(2), Nothing), WTextFormField)
            textFF.TextRange.Text = "221b Baker Street"

            textFF = CType(IIf(TypeOf sec.Body.FormFields(3) Is WTextFormField, sec.Body.FormFields(3), Nothing), WTextFormField)
            textFF.TextRange.Text = "(206)555-3412"

            textFF = CType(IIf(TypeOf sec.Body.FormFields(4) Is WTextFormField, sec.Body.FormFields(4), Nothing), WTextFormField)
            textFF.TextRange.Text = "John@company.com"


            dropFF = CType(IIf(TypeOf sec.Body.FormFields(5) Is WDropDownFormField, sec.Body.FormFields(5), Nothing), WDropDownFormField)

            'Set the value
            dropFF.DropDownSelectedIndex = 1

            textFF = CType(IIf(TypeOf sec.Body.FormFields(6) Is WTextFormField, sec.Body.FormFields(6), Nothing), WTextFormField)
            textFF.TextRange.Text = "Michigan University"


            dropFF = CType(IIf(TypeOf sec.Body.FormFields(7) Is WDropDownFormField, sec.Body.FormFields(7), Nothing), WDropDownFormField)
            dropFF.DropDownSelectedIndex = 1

            dropFF = CType(IIf(TypeOf sec.Body.FormFields(8) Is WDropDownFormField, sec.Body.FormFields(8), Nothing), WDropDownFormField)
            dropFF.DropDownSelectedIndex = 2

            'Allow only to fill the form.
            document.ProtectionType = ProtectionType.AllowOnlyFormFields

            'Save as word 2003  format
            If word2003RadioBtn.Checked Then
                'Saving the document to disk.
                document.Save("FormFillSample.doc")

                'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                    System.Diagnostics.Process.Start("FormFillSample.doc")
                    'Exit
                    Me.Close()
                End If
                'Save as word 2007 format
            ElseIf word2007RadioBtn.Checked Then

                'Saving the document as .docx
                document.Save("FormFillSample.docx", FormatType.Word2007)
                'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Try
                        'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                        System.Diagnostics.Process.Start("FormFillSample.docx")
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
                document.Save("FormFillSample.docx", FormatType.Word2010)
                'Message box confirmation to view the created document.
                If MessageBox.Show("Do you want to view the MS Word document?", "Document has been created", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Try
                        'Launching the MS Word file using the default Application.[MS Word Or Free WordViewer]
                        System.Diagnostics.Process.Start("FormFillSample.docx")
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
