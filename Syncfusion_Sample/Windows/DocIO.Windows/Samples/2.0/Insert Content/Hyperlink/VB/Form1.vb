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
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Diagnostics
Imports System.Windows.Forms
Imports Syncfusion.DocIO
Imports Syncfusion.DocIO.DLS
Imports System.Collections
Imports System.IO

Namespace Hyperlinks
	Partial Public Class Form1
		Inherits Form
		#Region "Fields"
		Private m_outPath, path As String
		Private document As WordDocument
		Private file As String()
		Private _WebLinks, _EmailLinks, _FileLinks, _Bookmarks As ArrayList
		#End Region

		#Region "Form Load and Constructor"
		''' <summary>
		''' Form Constructor
		''' </summary>
		Public Sub New()
			InitializeComponent()

			Me._WebLinks = New ArrayList()
			Me._EmailLinks = New ArrayList()
			Me._FileLinks = New ArrayList()
			Me._Bookmarks = New ArrayList()

			file = System.Environment.CurrentDirectory.Split(":"c)
			path = file(0)
			'm_outPath = System.Environment.CurrentDirectory & "\..\..\Output\"
		End Sub

		''' <summary>
		''' Form Load
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InsertHyperlink()
			Me.FindHyperLinks()
			Me.webRadioButton.Checked = True
		End Sub
		#End Region

		#Region "Helper Methods"

		#Region "InsertHyperlink"

		''' <summary>
		''' This methods creates hyperlinks and insert them in the document.
		''' </summary>
		Private Sub InsertHyperlink()
			Dim document As WordDocument = New WordDocument()
			Dim section As IWSection = document.AddSection()
			Dim para As IWParagraph = section.AddParagraph()

			para.AppendText("Inserting Hyperlink")
			para.ApplyStyle(BuiltinStyle.Title)

			section.AddParagraph()

'			#Region "Web Hyperlink"
			para = section.AddParagraph()
			para.AppendText("Web Hyperlinks")
			para.ApplyStyle(BuiltinStyle.Heading3)
			para = section.AddParagraph()
			para.AppendText("Hyperlinks to web pages creates a link to a web page, email address or to a program. " & Constants.vbLf & "Sample Links:")

			para = section.AddParagraph()
			Dim field As IWField = para.AppendField("Syncfusion", FieldType.FieldHyperlink)
			para.ApplyStyle(BuiltinStyle.Hyperlink)
			Dim hyperLink As Hyperlink = New Hyperlink(TryCast(field, WField))
			hyperLink.Type = HyperlinkType.WebLink
			hyperLink.Uri = "http://www.syncfusion.com"

			para = section.AddParagraph()
			para.ApplyStyle(BuiltinStyle.Hyperlink)
			field = para.AppendField("Google", FieldType.FieldHyperlink)
			hyperLink = New Hyperlink(TryCast(field, WField))
			hyperLink.Type = HyperlinkType.WebLink
			hyperLink.Uri = "http://www.google.com"

			para = section.AddParagraph()
			para.ApplyStyle(BuiltinStyle.Hyperlink)
			field = para.AppendField("MSN", FieldType.FieldHyperlink)
			hyperLink = New Hyperlink(TryCast(field, WField))
			hyperLink.Type = HyperlinkType.WebLink
			hyperLink.Uri = "http://www.msn.com"

			para = section.AddParagraph()
'			#End Region

'			#Region "Email Hyperlinks"
			para = section.AddParagraph()
			para.AppendText("E-mail Hyperlinks")
			para.ApplyStyle(BuiltinStyle.Heading3)
			para = section.AddParagraph()
			para.AppendText("Hyperlinks that links to e-mail.")

			para = section.AddParagraph()
			para.ApplyStyle(BuiltinStyle.Hyperlink)
			field = para.AppendField("John", FieldType.FieldHyperlink)
			hyperLink = New Hyperlink(TryCast(field, WField))
			hyperLink.Type = HyperlinkType.EMailLink
			hyperLink.Uri = "mailto:john@gmail.com"

			para = section.AddParagraph()
			para.ApplyStyle(BuiltinStyle.Hyperlink)
			field = para.AppendField("Eric", FieldType.FieldHyperlink)
			hyperLink = New Hyperlink(TryCast(field, WField))
			hyperLink.Type = HyperlinkType.EMailLink
			hyperLink.Uri = "mailto:eric@yahoo.com"

			para = section.AddParagraph()
			para.ApplyStyle(BuiltinStyle.Hyperlink)
			field = para.AppendField("David", FieldType.FieldHyperlink)
			hyperLink = New Hyperlink(TryCast(field, WField))
			hyperLink.Type = HyperlinkType.EMailLink
			hyperLink.Uri = "mailto:david@hotmail.com"

            '			#End Region

            '#Region "Image HyperLink"
            para = section.AddParagraph()
            para = section.AddParagraph()
            para.AppendText("Image Hyperlink")
            para.ApplyStyle(BuiltinStyle.Heading3)
            para = section.AddParagraph()
            para.AppendText("Hyperlinks to image creates link to a web page, email address or to a program.")

            para = section.AddParagraph()
            Dim mImage1 As WPicture = New WPicture(document)
            mImage1.LoadImage(Image.FromFile(Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\Images\DocIO\syncfusion_logo.gif"))

            field = para.AppendField("Hyperlink", FieldType.FieldHyperlink)

            hyperLink = New Hyperlink(TryCast(field, WField))
            hyperLink.Type = HyperlinkType.WebLink
            hyperLink.Uri = "http://www.syncfusion.com"
            hyperLink.PictureToDisplay = mImage1

            para = section.AddParagraph()
            Dim mImage2 As WPicture = New WPicture(document)
            mImage2.LoadImage(Image.FromFile(Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\Images\DocIO\google.png"))
            field = para.AppendField("Hyperlink", FieldType.FieldHyperlink)
            hyperLink = New Hyperlink(TryCast(field, WField))
            hyperLink.Type = HyperlinkType.WebLink
            hyperLink.Uri = "http://www.google.com"
            hyperLink.PictureToDisplay = mImage2

            para = section.AddParagraph()
            Dim mImage3 As WPicture = New WPicture(document)
            mImage3.LoadImage(Image.FromFile(Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\Images\DocIO\yahoo.gif"))
            field = para.AppendField("Hyperlink", FieldType.FieldHyperlink)
            hyperLink = New Hyperlink(TryCast(field, WField))
            hyperLink.Type = HyperlinkType.WebLink
            hyperLink.Uri = "http://www.yahoo.com"
            hyperLink.PictureToDisplay = mImage3
            '#End Region

'			#Region "File Hyperlinks"
			para = section.AddParagraph()
			para = section.AddParagraph()
			para.AppendText("File Hyperlinks")
			para.ApplyStyle(BuiltinStyle.Heading3)
			para = section.AddParagraph()
			para.AppendText("Hyperlinks to files creates links to other files, an image and so on.")

			para = section.AddParagraph()
			para.ApplyStyle(BuiltinStyle.Hyperlink)
			field = para.AppendField("File 1", FieldType.FieldHyperlink)
			hyperLink = New Hyperlink(TryCast(field, WField))
			hyperLink.Type = HyperlinkType.FileLink
			'hyperLink.TextToDisplay = "File 1";
			hyperLink.FilePath =Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\Images\DocIO\DocIO.gif"

			para = section.AddParagraph()
			para.ApplyStyle(BuiltinStyle.Hyperlink)
			field = para.AppendField("File 2", FieldType.FieldHyperlink)
			hyperLink = New Hyperlink(TryCast(field, WField))
			hyperLink.Type = HyperlinkType.FileLink
			hyperLink.FilePath =Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\Images\DocIO\XlsIO.gif"

			para = section.AddParagraph()
			para.ApplyStyle(BuiltinStyle.Hyperlink)
			field = para.AppendField("File 3", FieldType.FieldHyperlink)
			hyperLink = New Hyperlink(TryCast(field, WField))
			hyperLink.Type = HyperlinkType.FileLink
			hyperLink.FilePath =Application.StartupPath & "\..\..\..\..\..\..\..\..\..\Common\Images\DocIO\Pdf.gif"

'			#End Region

'			#Region "BookMarks"

'			#Region "Creating BookMarks"
			section = document.AddSection()
			section.BreakCode = SectionBreakCode.NewPage

			para = section.AddParagraph()
			para.AppendBookmarkStart("Introduction")
			para.AppendText("What is Hyperlink?").CharacterFormat.Bold = True
			para.AppendBookmarkEnd("Introduction")
			para.AppendText(Constants.vbLf & "A hyperlink is a reference or navigation element in a document to another section of the same document or to another document that may be on or part of a (different) domain.")

			para = section.AddParagraph()
			para = section.AddParagraph()
			para.AppendBookmarkStart("Insert")
			para.AppendText("How to create a Hyperlink?").CharacterFormat.Bold = True
			para.AppendBookmarkEnd("Insert")
			para.AppendText(Constants.vbLf & "Syncfusion.DocIO.DLS.IWField field = para.AppendField(""Syncfusion"", Syncfusion.DocIO.FieldType.FieldHyperlink);" & Constants.vbLf)
			para.AppendText("para.ApplyStyle(Syncfusion.DocIO.DLS.BuiltinStyle.Hyperlink);" & Constants.vbLf)
			para.AppendText("Syncfusion.DocIO.DLS.Hyperlink hyperLink = new Hyperlink(field as WField);" & Constants.vbLf)
			para.AppendText("hyperLink.Type = Syncfusion.DocIO.DLS.HyperlinkType.WebLink;" & Constants.vbLf)
			para.AppendText("hyperLink.Uri = ""http://www.syncfusion.com"";" & Constants.vbLf)

			para = section.AddParagraph()
			para.AppendBookmarkStart("Edit")
			para.AppendText("How to edit Hyperlink?").CharacterFormat.Bold = True
			para.AppendBookmarkEnd("Edit")
			para.AppendText(Constants.vbLf & "Syncfusion.DocIO.DLS.Hyperlink hlink = new Hyperlink(item as WField);" & Constants.vbLf)
			para.AppendText("if(hlink.Type = Syncfusion.DocIO.DLS.HyperlinkType.WebLink)" & Constants.vbLf)
			para.AppendText("{" & Constants.vbLf)
			para.AppendText("if (hlink.TextToDisplay == ""Syncfusion"")" & Constants.vbLf)
			para.AppendText("{" & Constants.vbLf)
			para.AppendText("hlink.TextToDisplay = ""Syncfusion Support"";" & Constants.vbLf)
			para.AppendText("hlink.Uri = ""http://www.syncfusion.com/support/default.aspx"";" & Constants.vbLf)
			para.AppendText("}" & Constants.vbLf)
			para.AppendText("}" & Constants.vbLf)

'			#End Region

'			#Region "Creating BookMark Hyperlinks"

			section = document.Sections(0)

			para = section.AddParagraph()
			para = section.AddParagraph()
			para.AppendText("Bookmark Hyperlinks")
			para.ApplyStyle(BuiltinStyle.Heading3)
			para = section.AddParagraph()
			para.AppendText("A bookmark is a location or selected text on a document that was marked. One can create a hyperlink to a bookmark.")

			para = section.AddParagraph()
			para.ApplyStyle(BuiltinStyle.Hyperlink)
			field = para.AppendField("What is Hyperlink?", FieldType.FieldHyperlink)
			hyperLink = New Hyperlink(TryCast(field, WField))
			hyperLink.Type = HyperlinkType.Bookmark
			hyperLink.BookmarkName = "Introduction"

			para = section.AddParagraph()
			para.ApplyStyle(BuiltinStyle.Hyperlink)
			field = para.AppendField("How to create a Hyperlink?", FieldType.FieldHyperlink)
			hyperLink = New Hyperlink(TryCast(field, WField))
			hyperLink.Type = HyperlinkType.Bookmark
			hyperLink.BookmarkName = "Insert"

			para = section.AddParagraph()
			para.ApplyStyle(BuiltinStyle.Hyperlink)
			field = para.AppendField("How to edit Hyperlink?", FieldType.FieldHyperlink)
			hyperLink = New Hyperlink(TryCast(field, WField))
			hyperLink.Type = HyperlinkType.Bookmark
			hyperLink.BookmarkName = "Edit"
'			#End Region

'			#End Region

			document.Save(Application.StartupPath & "\Template.doc", FormatType.Doc)
		End Sub

		#End Region

		#Region "FindHyperlinks"
		''' <summary>
		''' Find hyperlinks in the loaded document and updates the underlying database.
		''' </summary>
		Private Sub FindHyperLinks()
			document = New WordDocument(Application.StartupPath & "\Template.doc")
			For Each ent As Entity In document.ChildEntities
				If TypeOf ent Is WSection Then
					Dim section As WSection = TryCast(ent, WSection)
					For Each paragraph As WParagraph In section.Body.Paragraphs
						For Each item As ParagraphItem In paragraph.Items
							If TypeOf item Is WField AndAlso (TryCast(item, WField)).FieldType = FieldType.FieldHyperlink Then
								Dim hlink As Hyperlink = New Hyperlink(TryCast(item, WField))
								Select Case hlink.Type
									Case HyperlinkType.WebLink
										Me._WebLinks.Add(hlink)
									Case HyperlinkType.EMailLink
										Me._EmailLinks.Add(hlink)
									Case HyperlinkType.FileLink
										Me._FileLinks.Add(hlink)
									Case HyperlinkType.Bookmark
										Me._Bookmarks.Add(hlink)

									Case Else
								End Select
							End If
						Next item
					Next paragraph
				End If
			Next ent
		End Sub



		#End Region

		#Region "Update"
		''' <summary>
		''' Updates the database with the edited texts.
		''' </summary>
		''' <param name="list"></param>
		''' <param name="dataMember"></param>
		Private Sub UpdateListBindings(ByVal list As ArrayList, ByVal dataMember As String)
			' Bind the ListBox with the appropraite list
			Me.detailsListBox.DataSource = list
			If Me.bkRadioButton.Checked Then
				Me.detailsListBox.DisplayMember = "BookmarkName"
			Else
				Me.detailsListBox.DisplayMember = "TextToDisplay"
			End If

			Me.textBox2.DataBindings.Clear()
			Me.textBox1.DataBindings.Clear()

			' Bind the TextBox with the "current" element in the bound list (which would automatically change when the list's selection changes)
			Me.textBox2.DataBindings.Add("Text", list, dataMember)
		End Sub

		#End Region

		#End Region

		#Region "Events"

		''' <summary>
		''' Saves the edited hyperlink.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub createBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles createBtn.Click
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

		''' <summary>
		''' Updates the web hyperlinks
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub webRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles webRadioButton.CheckedChanged
			If webRadioButton.Checked Then
				Me.textBox1.ReadOnly = False
				Me.browseButton.Enabled = False
				Me.label4.Text = Me.webRadioButton.Text & " Text"
				Me.label3.Text = "Uri"
			End If
			Me.UpdateListBindings(Me._WebLinks, "Uri")
			Me.textBox1.DataBindings.Add("Text", Me._WebLinks, "TextToDisplay")
		End Sub

		''' <summary>
		''' Updates the mail hyperlinks
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub mailRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles mailRadioButton.CheckedChanged
			If mailRadioButton.Checked Then
				Me.textBox1.ReadOnly = False
				Me.browseButton.Enabled = False
				Me.label4.Text = Me.mailRadioButton.Text & " Text"
				Me.label3.Text = "Uri"
			End If
			Me.UpdateListBindings(Me._EmailLinks, "Uri")
			Me.textBox1.DataBindings.Add("Text", Me._EmailLinks, "TextToDisplay")
		End Sub

		''' <summary>
		''' Updates the file hyperlinks
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub fileRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles fileRadioButton.CheckedChanged
			If fileRadioButton.Checked Then
				Me.textBox1.ReadOnly = False
				Me.browseButton.Enabled = True
				Me.label4.Text = Me.fileRadioButton.Text & " Text"
				Me.label3.Text = "File Path"
			End If
			Me.UpdateListBindings(Me._FileLinks, "FilePath")
			Me.textBox1.DataBindings.Add("Text", Me._FileLinks, "TextToDisplay")
		End Sub

		''' <summary>
		''' Updates the bookmark hyperlinks.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub bkRadioButton_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles bkRadioButton.CheckedChanged
			If bkRadioButton.Checked Then
				Me.textBox1.ReadOnly = True
				Me.browseButton.Enabled = False
				Me.label4.Text = Me.bkRadioButton.Text & " Name"
				Me.label3.Text = "Bookmark Text"
			End If
			Me.UpdateListBindings(Me._Bookmarks, "TextToDisplay")
			Me.textBox1.DataBindings.Add("Text", Me._Bookmarks, "BookmarkName")
		End Sub

		''' <summary>
		''' The file browser used to upload in the File Hyperlink.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Private Sub browseButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles browseButton.Click
			Me.openFileDialog1.Filter = "All files (*.*)|*.*"
			Dim result As DialogResult = Me.openFileDialog1.ShowDialog()
			If result = System.Windows.Forms.DialogResult.OK Then
                Me.textBox2.Text = System.IO.Path.GetFullPath(Me.openFileDialog1.FileName)
				Me.textBox2.Focus()
			End If
		End Sub

		''' <summary>
		''' The source template document.
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
        Private Sub templateBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles templateBtn.Click
            Process.Start(Application.StartupPath & "\Template.doc")
        End Sub
		#End Region
    End Class
End Namespace