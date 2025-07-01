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
Imports System.Collections
Imports System.Text

Imports Syncfusion.Windows.Forms.Edit.Interfaces
Imports Syncfusion.Windows.Forms.Edit.Enums

Namespace CustomCodeEditorDemo
	''' <summary>
	''' Autoformatter for CSharp.
	''' </summary>
	Public Class HTMLFormatter : Implements IAutoFormatter
		#Region "IAutoFormatter Members"
		''' <summary>
		''' Formats given list of lexem wrappers.
		''' </summary>
		''' <param name="lexems">List of ILexemWrapper instances.</param>
		''' <returns>String with formatted text.</returns>
		Public Function Format(ByVal lexems As IList) As String Implements IAutoFormatter.Format
			If Nothing Is lexems Then
				Throw New ArgumentNullException("lexems")
			End If

			' Whitespace at the beginning of first line. Is inserted at the beginning of every line.
			Dim strStartLineWhitespace As String = GetStartWhitespace(lexems)
			Dim starttag As Boolean=False
			If 0 = lexems.Count Then
			Return strStartLineWhitespace
			End If

			' Number of indentation tabs to insert at the begining of current line.
			Dim iIndents As Integer = 0

			Dim result As StringBuilder = New StringBuilder(strStartLineWhitespace)
			Dim curLex As ILexemWrapper = Nothing

			' Helper variable.
			Dim strLexText As String = String.Empty

			Do
				curLex = CType(lexems(0), ILexemWrapper)

				' Omit parsing of comments.
				If FormatType.Comment = curLex.Config.Type OrElse FormatType.String = curLex.Config.Type OrElse "CommentXML" = curLex.Config.FormatName Then
					AddFirstLexem(result, lexems)
					' If lexem is new line mark.
				Else If -1 <> curLex.Text.IndexOf(Constants.vbLf) Then
					'Removes whitespace from the end of string builder
                    RemoveEndWhitespace(result, False)
					'Add new line and indent to the string builder     
                    AddNewLineAndIndent(result, iIndents, strStartLineWhitespace, lexems)
					lexems.RemoveAt(0)
					'Removes all whitespace lexems from the beginning of lexems list
                    RemoveStartWhitespace(lexems, False)
				Else
					Select Case curLex.Text
						Case "<" 
							starttag=True
							strLexText = curLex.Text
							If iIndents>0 Then
                               'Add new line and indent to the string builder   
							   AddNewLineAndIndent(result, iIndents, strStartLineWhitespace, lexems)
							End If
							'Add "<" lexem to the string builder
                            AddFirstLexem(result, lexems)

							If 0 = lexems.Count Then
							Exit Select
							End If
                            'Add lexems in the tag to the string builder
							AddLexemsInBrackets(result, lexems)
                            'Removes whitespace from the end of string builder
							RemoveEndWhitespace(result, True)
							iIndents += 1
							'Removes all whitespace lexems from the beginning of lexems list
                            RemoveStartWhitespace(lexems, True)

						Case "</" 
							 strLexText = curLex.Text
							'Removes whitespace from the end of string builder
                            RemoveEndWhitespace(result, True)
							iIndents -= 1
							'Add new line and indent to the string builder 
                            AddNewLineAndIndent(result, iIndents, strStartLineWhitespace, lexems)
							'Add "</" lexem to the string builder
                            AddFirstLexem(result, lexems)
							If 0 = lexems.Count Then
							Exit Select
							End If
                             'Add lexems in the tag to the string builder 
							AddLexemsInBrackets(result, lexems)
							'Removes all whitespace until the second new line mark
                            RemoveFirstNewLineMark(lexems)

						Case Else
							If starttag Then
							   'Add new line and indent to the string builder 
                               AddNewLineAndIndent(result, iIndents, strStartLineWhitespace, lexems)
							   starttag=False
							End If
                            'Add current lexem to the string builder
							AddFirstLexem(result, lexems)
					End Select
				End If
			Loop While lexems.Count > 0

			Return result.ToString()
		End Function
		#End Region

		#Region "Class Utility Methods"
		''' <summary>
		''' Removes whitespace from the end of string builder.
		''' </summary>
		''' <param name="s">StringBuilder instance to remove whitespace from.</param>
		''' <param name="bRemoveNewLineMarks">Indicates whether new line marks should be removerd.</param>
		Private Sub RemoveEndWhitespace(ByVal s As StringBuilder, ByVal bRemoveNewLineMarks As Boolean)
			If Nothing Is s Then
				Throw New ArgumentNullException("s")
			End If

			Dim iWhitespaceLength As Integer = 0

            Dim i As Integer
            For i = s.Length - 1 To 0 Step -1
                If (" "c = s(i) OrElse ControlChars.Tab = s(i)) OrElse bRemoveNewLineMarks AndAlso (ControlChars.Lf = s(i) OrElse ControlChars.Cr = s(i)) Then
                    iWhitespaceLength += 1
                Else
                    Exit For
                End If
            Next i

            s.Remove(s.Length - iWhitespaceLength, iWhitespaceLength)
		End Sub
		''' <summary>
		''' Adds to string builder new line mark and required indentation whitespace at the begining of the next line.
		''' </summary>
		''' <param name="s">StringBuildet instance to work with.</param>
		''' <param name="iIndents">Number of required indents at the beginning of the next line.</param>
		''' <param name="strStartLineWhitespace">Whitespace to insert at the beginning
		''' of the next line (indentation follows it).</param>
		''' <param name="lexems">List of lexems. Used for checking whether current line is the last one.</param>
		Private Sub AddNewLineAndIndent(ByVal s As StringBuilder, ByVal iIndents As Integer, ByVal strStartLineWhitespace As String, ByVal lexems As IList)
			If Nothing Is s Then
				Throw New ArgumentNullException("s")
			End If
			If iIndents < 0 Then
				Throw New ArgumentOutOfRangeException("iIndents")
			End If
			If Nothing Is strStartLineWhitespace Then
				Throw New ArgumentNullException("strStartLineWhitespace")
			End If

			If 0 <> s.Length Then
			s.Append(ControlChars.Lf)
			End If

			If IsLastLine(lexems) Then
			Return
			End If

			s.Append(strStartLineWhitespace & New String(ControlChars.Tab, iIndents))
		End Sub
		''' <summary>
		''' Removes all whitespace lexems from the beginning of lexems list.
		''' </summary>
		''' <param name="lexems">List of lexems.</param>
		''' <param name="bRemoveNewLineMarks">Indicates whether new line marks should be removerd.</param>
		Private Sub RemoveStartWhitespace(ByVal lexems As IList, ByVal bRemoveNewLineMarks As Boolean)
			Dim lex As ILexemWrapper = Nothing

			Do While lexems.Count > 0
				lex = CType(lexems(0), ILexemWrapper)

				If FormatType.Whitespace = lex.Config.Type OrElse (bRemoveNewLineMarks AndAlso -1 <> lex.Text.IndexOf(Constants.vbLf)) Then
					lexems.RemoveAt(0)
				Else
					Return
				End If
			Loop
		End Sub
		''' <summary>
		''' Gets whitespace at the beginning of first line.
		''' </summary>
		''' <param name="lexems">List of lexem wrappers.</param>
		''' <returns>String with required whitespace.</returns>
		Private Function GetStartWhitespace(ByVal lexems As IList) As String
			If Nothing Is lexems Then
				Throw New ArgumentNullException("lexems")
			End If

			Dim result As String = String.Empty
			Dim lex As ILexemWrapper = Nothing

			Do While lexems.Count > 0
				lex = CType(lexems(0), ILexemWrapper)

				If FormatType.Whitespace = lex.Config.Type Then
					result &= lex.Text
					lexems.RemoveAt(0)
				Else
					Exit Do
				End If
			Loop

			Return result
		End Function
		''' <summary>
		''' Adds first lexem of list to string builder and removes it from list.
		''' </summary>
		''' <param name="s">StringBuilder instance to add lexem to.</param>
		''' <param name="lexems">List of lexems.</param>
		Private Sub AddFirstLexem(ByVal s As StringBuilder, ByVal lexems As IList)
			If Nothing Is s Then
				Throw New ArgumentNullException("s")
			End If
			If Nothing Is lexems Then
				Throw New ArgumentNullException("lexems")
			End If
			If lexems.Count < 1 Then
				Throw New ArgumentException("lexems")
			End If

			s.Append((CType(lexems(0), ILexemWrapper)).Text)
			lexems.RemoveAt(0)
		End Sub

		''' <summary>
		''' Adds lexems in brackets without changes.
		''' </summary>
		''' <param name="s">String builder to work with.</param>
		''' <param name="lexems">List of lexems.</param>
		Private Sub AddLexemsInBrackets(ByVal s As StringBuilder, ByVal lexems As IList)
			If Nothing Is s Then
				Throw New ArgumentNullException("s")
			End If
			If Nothing Is lexems Then
				Throw New ArgumentNullException("lexems")
			End If


			Dim curLexText As String = String.Empty


			Do While ">" <> curLexText AndAlso 0 <> lexems.Count
				curLexText = (CType(lexems(0), ILexemWrapper)).Text
				AddFirstLexem(s, lexems)
			Loop
		End Sub
		''' <summary>
		''' Adds lexems without any change until specefied
		''' </summary>
		''' <param name="s">String builder instance to add text to.</param>
		''' <param name="lexems">List of lexems.</param>
		''' <param name="lexem">Text of lexem that should and operation.</param>
		Private Sub AddUntilLexem(ByVal s As StringBuilder, ByVal lexems As IList, ByVal lexem As String)
			If Nothing Is s Then
				Throw New ArgumentNullException("s")
			End If
			If Nothing Is lexems Then
				Throw New ArgumentNullException("lexems")
			End If
			If Nothing Is lexem Then
				Throw New ArgumentNullException("lexem")
			End If
			If String.Empty = lexem Then
				Throw New ArgumentOutOfRangeException("lexem")
			End If

			Dim curLexText As String = String.Empty

			Do While lexem <> curLexText AndAlso 0 <> lexems.Count
				curLexText = (CType(lexems(0), ILexemWrapper)).Text
				AddFirstLexem(s, lexems)
			Loop
		End Sub
		''' <summary>
		''' Checks whether given line is the last in given list of lexems..
		''' </summary>
		''' <param name="lexems">List of lexems.</param>
		''' <returns>True if current line is the last; otherwise false.</returns>
		Private Function IsLastLine(ByVal lexems As IList) As Boolean
			Dim lex As ILexemWrapper

			If 0 = lexems.Count Then
			Return True
			End If

			Dim i As Integer = 0
			Do While i < lexems.Count - 1
				lex = CType(lexems(i), ILexemWrapper)

				If -1 <> lex.Text.IndexOf(Constants.vbLf) OrElse FormatType.Whitespace <> lex.Config.Type Then
				Return False
				End If
				i += 1
			Loop

			Return True
		End Function
		''' <summary>
		''' Removes all whitespace until the second new line mark.
		''' </summary>
		''' <param name="lexems">List of lexems.</param>
		Private Sub RemoveFirstNewLineMark(ByVal lexems As IList)
			Dim lex As ILexemWrapper = Nothing

			Dim bFirstNewLineFound As Boolean = False

			Do While lexems.Count > 0
				lex = CType(lexems(0), ILexemWrapper)

				If FormatType.Whitespace = lex.Config.Type Then
					lexems.RemoveAt(0)

				End If

				If -1 <> lex.Text.IndexOf(Constants.vbLf) AndAlso (Not bFirstNewLineFound) Then
					lexems.RemoveAt(0)
					bFirstNewLineFound = True

				End If

				Return
			Loop
		End Sub
		#End Region
	End Class
End Namespace