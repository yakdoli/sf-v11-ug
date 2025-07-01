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
Imports System.Data.OleDb
Imports System.IO
Imports System.Diagnostics

Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS


Namespace EssentialDocIOSamples
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1 : Inherits System.Windows.Forms.Form

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
            Me.templateBtn = New System.Windows.Forms.Button()
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
            Me.button1.Location = New System.Drawing.Point(265, 214)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(99, 25)
            Me.button1.TabIndex = 26
            Me.button1.Text = "Generate"
            Me.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.button1.UseVisualStyleBackColor = False
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
            Me.label2.ForeColor = System.Drawing.SystemColors.ControlText
            Me.label2.Location = New System.Drawing.Point(0, 104)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(374, 46)
            Me.label2.TabIndex = 74
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
            Me.Label4.Location = New System.Drawing.Point(107, 48)
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
            Me.label24.Location = New System.Drawing.Point(107, 22)
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
            'templateBtn
            '
            Me.templateBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.templateBtn.BackColor = System.Drawing.Color.Transparent
            Me.templateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
            Me.templateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.templateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
            Me.templateBtn.Image = CType(resources.GetObject("templateBtn.Image"), System.Drawing.Image)
            Me.templateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.templateBtn.Location = New System.Drawing.Point(265, 178)
            Me.templateBtn.Name = "templateBtn"
            Me.templateBtn.Size = New System.Drawing.Size(99, 25)
            Me.templateBtn.TabIndex = 102
            Me.templateBtn.Text = "View Template"
            Me.templateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.templateBtn.UseVisualStyleBackColor = False
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
            Me.GroupBox2.Location = New System.Drawing.Point(3, 166)
            Me.GroupBox2.Name = "GroupBox2"
            Me.GroupBox2.Size = New System.Drawing.Size(251, 72)
            Me.GroupBox2.TabIndex = 103
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
            Me.Controls.Add(Me.templateBtn)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.pictureBox1)
            Me.Controls.Add(Me.button1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Mail Merge Event"
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.GroupBox2.ResumeLayout(False)
            Me.GroupBox2.PerformLayout()
            Me.ResumeLayout(False)

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
        ' Create a DataSet.
        Private ds As DataSet = New DataSet()
        Private WithEvents button1 As Button
        Private WithEvents label2 As System.Windows.Forms.Label
        Private WithEvents toolTip1 As System.Windows.Forms.ToolTip
        Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents templateBtn As System.Windows.Forms.Button
        Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
        Private WithEvents Label6 As System.Windows.Forms.Label
        Private WithEvents word2013RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label4 As System.Windows.Forms.Label
        Private WithEvents word2010RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents Label5 As System.Windows.Forms.Label
        Private WithEvents label24 As System.Windows.Forms.Label
        Private WithEvents word2003RadioBtn As System.Windows.Forms.RadioButton
        Private WithEvents word2007RadioBtn As System.Windows.Forms.RadioButton

        ' Creating a new document.
        Private document As WordDocument

        Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button1.Click
            Try
                ' Load the template.
                document = New WordDocument("..\..\..\..\..\..\..\..\..\Common\Data\DocIO\Template.doc")

                ' Get the tables from Data Set.
                GetDataTable()

                ' Using Merge events to do conditional formatting during runtime.
                AddHandler document.MailMerge.MergeField, AddressOf AlternateRows_MergeField
                AddHandler document.MailMerge.MergeImageField, AddressOf MergeField_ProductImage

                ' Execute Mail Merge with groups.
                document.MailMerge.ExecuteGroup(ds.Tables("Products"))
                document.MailMerge.ExecuteGroup(ds.Tables("Product_PriceList"))

                ds = Nothing
                ds = New DataSet()
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

            Catch Ex As Exception
                MessageBox.Show(Ex.Message + Constants.vbLf + Constants.vbLf + Constants.vbLf + Ex.StackTrace)
            End Try

        End Sub

        Private Sub GetDataTable()
            ' List of syncfusion products name.
            Dim products As String() = {"Studio", "Chart", "Edit", "Grid", "Tools", "Diagram", "XlsIO", "Grouping", "Calculate", "HTMLUI", "PDF", "DocIO"}

            ' Add new Tables to the data set.
            Dim row As DataRow
            ds.Tables.Add()
            ds.Tables.Add()

            ' Add fields to the Product_PriceList table.
            ds.Tables(0).TableName = "Product_PriceList"
            ds.Tables(0).Columns.Add("ProductName")
            ds.Tables(0).Columns.Add("Binary")
            ds.Tables(0).Columns.Add("Source")

            ' Add fields to the Products table.
            ds.Tables(1).TableName = "Products"
            ds.Tables(1).Columns.Add("SNO")
            ds.Tables(1).Columns.Add("ProductName")
            ds.Tables(1).Columns.Add("ProductImage")

            Dim count As Integer = 0

            ' Inserting values to the tables.
            For Each product As String In products
                row = ds.Tables("Product_PriceList").NewRow()
                row("ProductName") = String.Concat("Essential ", product)
                Select Case product
                    Case "Studio"
                        row("Binary") = "$1,295.00"
                    Case "Grid"
                        row("Binary") = "$595.00"
                    Case Else
                        row("Binary") = "$495.00"
                End Select

                Select Case product
                    Case "Studio"
                        row("Source") = "$1,995.00"
                    Case "Grid"
                        row("Source") = "$995.00"
                    Case Else
                        row("Source") = "$895.00"
                End Select
                ds.Tables("Product_PriceList").Rows.Add(row)

                count += 1
                row = ds.Tables("Products").NewRow()
                row("SNO") = count.ToString()
                row("ProductName") = String.Concat("Essential ", product)
                row("ProductImage") = String.Concat(product, ".gif")
                ds.Tables("Products").Rows.Add(row)
            Next product
        End Sub

        Private Sub AlternateRows_MergeField(ByVal sender As Object, ByVal args As MergeFieldEventArgs)
            ' Conditionally format data during Merge.
            If args.RowIndex Mod 2 = 0 Then
                args.CharacterFormat.TextColor = Color.FromArgb(255, 102, 0)
            End If
        End Sub

        Private Sub MergeField_ProductImage(ByVal sender As Object, ByVal args As MergeImageFieldEventArgs)
            ' Get the image from disk during Merge.
            If args.FieldName = "ProductImage" Then
                Dim ProductFileName As String = args.FieldValue.ToString()
                args.Image = Image.FromFile(Path.Combine("..\..\..\..\..\..\..\..\..\Common\images\DocIO\", ProductFileName))
            End If
        End Sub
        ''' <summary>
        ''' The source template document.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub templateBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles templateBtn.Click
            Process.Start("..\..\..\..\..\..\..\..\..\Common\Data\DocIO\Template.doc")
        End Sub
    End Class
End Namespace
