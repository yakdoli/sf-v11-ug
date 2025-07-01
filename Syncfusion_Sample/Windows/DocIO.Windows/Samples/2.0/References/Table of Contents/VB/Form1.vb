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
Imports System.Windows.Forms
Imports Syncfusion.DocIO.DLS
Namespace TableOfContents_2005
	Public Partial Class Form1
		Inherits Form
		#Region "Constructor"
		Public Sub New()
			InitializeComponent()

		End Sub
		#End Region

		#Region "Table Of Content"
		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim doc As WordDocument = New WordDocument()
			doc.EnsureMinimal()

			Dim para As WParagraph = doc.LastParagraph

            para.AppendText(Constants.vbTab + Constants.vbTab + Constants.vbTab + Constants.vbTab & "Essential DocIO - Table of Contents" & Constants.vbLf + Constants.vbLf).CharacterFormat.Bold = True
            If Not Me.CheckBox6.Checked Then
                para.AppendText(Constants.vbTab + Constants.vbTab & "Select TOC and press F9 to update the Table of Contents" & Constants.vbTab + Constants.vbLf + Constants.vbLf).CharacterFormat.HighlightColor = Color.Yellow
            End If

			Dim title As String = Me.textBox1.Text + Constants.vbLf
			para.AppendText(title).CharacterFormat.Bold = True

			'Insert TOC
			Dim toc As TableOfContent = para.AppendTOC(1, 3)

			para.ApplyStyle(BuiltinStyle.Heading4)
			'Apply built-in paragraph formatting
            Dim section As WSection = doc.LastSection
            ' Set Margin of the document
            section.PageSetup.Margins.All = 72
			If radioButton1.Checked Then
                'Default Styles
			Dim newPara As WParagraph = TryCast(section.AddParagraph(), WParagraph)
			newPara = TryCast(section.AddParagraph(), WParagraph)
			newPara.AppendBreak(BreakType.PageBreak)
			Dim text As WTextRange = TryCast(newPara.AppendText("Document with Default styles"), WTextRange)
			newPara.ApplyStyle(BuiltinStyle.Heading1)
			newPara = TryCast(section.AddParagraph(), WParagraph)
			newPara.AppendText("This is the heading1 of built in style. This sample demonstrates the TOC insertion in a word document. Note that DocIO can only insert TOC field in a word document. It can not refresh or create TOC field. MS Word refreshes the TOC field after insertion. Please update the field or press F9 key to refresh the TOC.")

			section.AddParagraph()
			newPara = TryCast(section.AddParagraph(), WParagraph)
			text = TryCast(newPara.AppendText("Section1"), WTextRange)
			newPara.ApplyStyle(BuiltinStyle.Heading2)
			newPara = TryCast(section.AddParagraph(), WParagraph)
			newPara.AppendText("This is the heading2 of built in style. A document can contain any number of sections. Sections are used to apply same formatting for a group of paragraphs. You can insert sections by inserting section breaks.")

			section.AddParagraph()
			newPara = TryCast(section.AddParagraph(), WParagraph)
			text = TryCast(newPara.AppendText("Paragraph1"), WTextRange)
			newPara.ApplyStyle(BuiltinStyle.Heading3)
			newPara = TryCast(section.AddParagraph(), WParagraph)
			newPara.AppendText("This is the heading3 of built in style. Each section contains any number of paragraphs. A paragraph is a set of statements that gives a meaning for the text.")

			section.AddParagraph()
			newPara = TryCast(section.AddParagraph(), WParagraph)
			text = TryCast(newPara.AppendText("Paragraph2"), WTextRange)
			newPara.ApplyStyle(BuiltinStyle.Heading3)
			newPara = TryCast(section.AddParagraph(), WParagraph)
			newPara.AppendText("This is the heading3 of built in style. This demonstrates the paragraphs at the same level and style as that of the previous one. A paragraph can have any number formatting. This can be attained by formatting each text range in the paragraph.")

			section.AddParagraph()
			section = TryCast(doc.AddSection(), WSection)
			section.BreakCode = SectionBreakCode.NewPage
			newPara = TryCast(section.AddParagraph(), WParagraph)
			text = TryCast(newPara.AppendText("Section2"), WTextRange)
			newPara.ApplyStyle(BuiltinStyle.Heading2)
			newPara = TryCast(section.AddParagraph(), WParagraph)
			newPara.AppendText("This is the heading2 of built in style. A document can contain any number of sections. Sections are used to apply same formatting for a group of paragraphs. You can insert sections by inserting section breaks.")

			section.AddParagraph()
			newPara = TryCast(section.AddParagraph(), WParagraph)
			text = TryCast(newPara.AppendText("Paragraph1"), WTextRange)
			newPara.ApplyStyle(BuiltinStyle.Heading3)
			newPara = TryCast(section.AddParagraph(), WParagraph)
			newPara.AppendText("This is the heading3 of built in style. Each section contains any number of paragraphs. A paragraph is a set of statements that gives a meaning for the text.")

			section.AddParagraph()
			newPara = TryCast(section.AddParagraph(), WParagraph)
			text = TryCast(newPara.AppendText("Paragraph2"), WTextRange)
			newPara.ApplyStyle(BuiltinStyle.Heading3)
			newPara = TryCast(section.AddParagraph(), WParagraph)
			newPara.AppendText("This is the heading3 of built in style. This demonstrates the paragraphs at the same level and style as that of the previous one. A paragraph can have any number formatting. This can be attained by formatting each text range in the paragraph.")

            Else

                'Custom styles.
                Dim pStyle1 As WParagraphStyle = CType(doc.AddParagraphStyle("MyStyle1"), WParagraphStyle)
                Dim pStyle2 As WParagraphStyle = CType(doc.AddParagraphStyle("MyStyle2"), WParagraphStyle)
                Dim pStyle3 As WParagraphStyle = CType(doc.AddParagraphStyle("MyStyle3"), WParagraphStyle)

                'Set the Heading Styles to false in order to define custom levels to TOC.
                toc.UseHeadingStyles = False

                'Set the TOC level style which determines; based on which the TOC should be created.
                toc.SetTOCLevelStyle(1, "MyStyle1")
                toc.SetTOCLevelStyle(2, "MyStyle2")
                toc.SetTOCLevelStyle(3, "MyStyle3")
                section = TryCast(doc.AddSection(), WSection)

                pStyle1.CharacterFormat.FontName = "Cambria"
                pStyle1.CharacterFormat.FontSize = 30.0F

                para = TryCast(section.AddParagraph(), WParagraph)

                Dim text As WTextRange = TryCast(para.AppendText("Document with Custom Styles"), WTextRange)
                para.ApplyStyle("MyStyle1")
                para = TryCast(doc.LastSection.AddParagraph(), WParagraph)
                para.AppendText("This is the heading1 of built in style. This sample demonstrates the TOC insertion in a word document. Note that DocIO can only insert TOC field in a word document. It can not refresh or create TOC field. MS Word refreshes the TOC field after insertion. Please update the field or press F9 key to refresh the TOC.")

                pStyle2.CharacterFormat.FontName = "Cambria"
                pStyle2.CharacterFormat.FontSize = 20.0F

                doc.LastSection.AddParagraph()

                para = TryCast(doc.LastSection.AddParagraph(), WParagraph)
                text = TryCast(para.AppendText("Section1"), WTextRange)
                para.ApplyStyle("MyStyle2")
                para = TryCast(doc.LastSection.AddParagraph(), WParagraph)
                para.AppendText("This is the heading2 of built in style. A document can contain any number of sections. Sections are used to apply same formatting for a group of paragraphs. You can insert sections by inserting section breaks.")

                pStyle3.CharacterFormat.FontName = "Cambria"
                pStyle3.CharacterFormat.FontSize = 14.0F

                doc.LastSection.AddParagraph()

                para = TryCast(doc.LastSection.AddParagraph(), WParagraph)
                text = TryCast(para.AppendText("Section2"), WTextRange)
                para.ApplyStyle("MyStyle3")
                para = TryCast(doc.LastSection.AddParagraph(), WParagraph)
                para.AppendText("This is the heading2 of built in style. A document can contain any number of sections. Sections are used to apply same formatting for a group of paragraphs. You can insert sections by inserting section breaks.")


			End If
			If Me.numericUpDown2.Value < Me.numericUpDown1.Value Then
				MessageBox.Show("Not a valid heading level range. UpperHeadingLevel must be greater than LowerHeadingLevel")
			Else
				toc.IncludePageNumbers = checkBox1.Checked
				toc.RightAlignPageNumbers = checkBox2.Checked
				toc.UseHyperlinks = checkBox3.Checked
				toc.LowerHeadingLevel = Convert.ToInt32(Me.numericUpDown1.Value)
				toc.UpperHeadingLevel = Convert.ToInt32(Me.numericUpDown2.Value)
				'Right click text. Select Paragraph option. Set OutlineLevel. Update TOC toc see the text added in TOC.
				toc.UseOutlineLevels = Me.checkBox4.Checked
				'Select the text that should be marked as Table of contents.
				'Press ALT+SHIFT+O. A dialog box will appear with options to enter the text, select the table identifier and level.
                'Choose the table identifier and level for the test and click �Mark�. Update TOC toc see the text added in TOC.
                'Sets the Table Identifier if necessary.
                'toc.TableID = "B";
                toc.UseTableEntryFields = Me.checkBox5.Checked
                'Updates the table of contents.
                If Me.CheckBox6.Checked Then
                    doc.UpdateTableOfContents()
                End If
                'Save as word 2003  format
                If word2003RadioBtn.Checked Then
                    'Saving the document to disk.
                    doc.Save("Sample.doc")

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
                    doc.Save("Sample.docx", Syncfusion.DocIO.FormatType.Word2007)
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
                    doc.Save("Sample.docx", Syncfusion.DocIO.FormatType.Word2010)
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
                    doc.Save("Sample.docx", Syncfusion.DocIO.FormatType.Word2013)
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
			End If
		End Sub
		#End Region
	End Class
End Namespace