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
  Friend Class Tokenizer
	Private iTest As Integer = 5 + 5
	Private chTest As Char = "a"c
	Private _token As Token
	Private _tokenValue As String
	Private _reader As TextReader
	Private _read As String = ""

	Public ReadOnly Property LastToken() As Token
	  Get
		Return _token
	  End Get
	End Property

	Public ReadOnly Property LastTokenValue() As String
	  Get
		Return _tokenValue
	  End Get
	End Property

	Public Sub New(ByVal reader As TextReader)
	  _reader = reader
	End Sub

	Private Sub PutBack(ByVal ch As Char)
	  If _read.Length = 0 Then
		_read = New String(ch, 1)
	  Else
		_read = ch & _read
	  End If
	End Sub

	Private Function Peek() As Integer
	  Dim l As Integer = _read.Length
	  If l = 0 Then
		Dim ch As Integer = _reader.Peek()
		Return ch
	  Else
		Return _read.Chars(0)
	  End If
	End Function

	Private Function ReadChar() As Integer
	  If _read = "" Then
		Return _reader.Read()
	  Else
		Dim ch As Integer = _read.Chars(0)
		_read = _read.Substring(1)
		Return ch
	  End If
	End Function

	Private Function SkipSpaces() As Boolean
	  Dim ch As Integer = Peek()
	  Do While ch = " "c OrElse ch = 10 OrElse ch = 12 OrElse ch = 13 OrElse ch = 9
		ReadChar()
		ch = Peek()
	  Loop
	  Return True
	End Function

	Private Function Probe(ByVal symbol As String) As Boolean
	  Dim l As Integer = symbol.Length
	  Dim missed As Integer = l - _read.Length
	  If missed > 0 Then
		Dim ch As Integer = 0
		Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder(_read)
		Do While missed > 0 AndAlso ch <> -1
		  ch = _reader.Read()
		  If ch = -1 Then
		  Exit Do
		  End If
		  sb.Append(CChar(ch))
		  missed -= 1
		Loop
		_read = sb.ToString()
	  End If
	  If _read.Length >= l AndAlso _read.Substring(0, l).ToLower() = symbol Then
		If _read.Length > l Then
		  _read = _read.Substring(l)
		Else
		  _read = ""
		End If
		Return True
	  Else
		Return False
	  End If
	End Function

	Private Function ProbeString(ByRef str As String) As Boolean
	  Dim delimiterChar As Integer
	  delimiterChar = Peek()
	  If delimiterChar = """"c OrElse delimiterChar = "'"c Then
		Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder()
		ReadChar()
		Dim ch As Integer = ReadChar()
		Do While ch <> delimiterChar AndAlso ch <> -1
		  If ch = "\"c Then
			ch = ReadChar()
		  End If
		  sb.Append(CChar(ch))
		  ch = ReadChar()
		Loop
		If ch = -1 Then
		  _read = delimiterChar + sb.ToString()
		  Return False
		End If
		str = sb.ToString()
		Return True
	  Else
		Return False
	  End If
	End Function

	Private Function ProbeIdent(ByRef str As String) As Boolean
	  Dim ch As Integer = Peek()
	  If (ch >= "a"c AndAlso ch <= "z"c) OrElse (ch >= "A"c AndAlso ch <= "Z"c) OrElse (ch >= 128 AndAlso ch <= 255) OrElse (ch > 255) OrElse (ch = "\"c) OrElse ch = "%"c OrElse ch = "*"c Then
		Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder(ch)
		If ch = "\"c Then
		  ReadChar()
		  ch = Peek()
		End If
		sb.Append(CChar(ch))
		ReadChar()
		ch = Peek()
		Do While (ch >= "a"c AndAlso ch <= "z"c) OrElse (ch >= "A"c AndAlso ch <= "Z"c) OrElse (ch >= 128 AndAlso ch <= 255) OrElse (ch >= "0"c AndAlso ch <= "9"c) OrElse ch = "-"c OrElse ch = "_"c OrElse ch = "%"c OrElse ch = "*"c OrElse ch = "\"c
		  If ch = "\"c Then
			ReadChar()
			ch = Peek()
		  End If
		  ReadChar()
		  sb.Append(CChar(ch))
		  ch = Peek()
		Loop
		str = sb.ToString()
		Return True
	  Else
		Return False
	  End If
	End Function

	Private Function ProbeName(ByRef str As String) As Boolean
	  Dim ch As Integer = Peek()
	  If (ch >= "a"c AndAlso ch <= "z"c) OrElse (ch >= "A"c AndAlso ch <= "Z"c) OrElse (ch >= 128 AndAlso ch <= 255) OrElse (ch >= "0"c AndAlso ch <= "9"c) OrElse ch = "-"c OrElse ch = "_"c OrElse ch = "%"c OrElse ch = "\"c Then
		If ch = "\"c Then
		  ReadChar()
		  ch = Peek()
		End If
		Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder(ch)
		ReadChar()
		ch = Peek()
		Do While (ch >= "a"c AndAlso ch <= "z"c) OrElse (ch >= "A"c AndAlso ch <= "Z"c) OrElse (ch >= 128 AndAlso ch <= 255) OrElse (ch >= "0"c AndAlso ch <= "9"c) OrElse ch = "-"c OrElse ch = "_"c OrElse ch = "%"c OrElse ch = "\"c
		  If ch = "\"c Then
			ReadChar()
			ch = Peek()
		  End If
		  ReadChar()
		  sb.Append(CChar(ch))
		  ch = Peek()
		Loop
		str = sb.ToString()
		Return True
	  Else
		Return False
	  End If
	End Function

	Private Function ProbeURL(ByRef str As String) As Boolean
	  Dim ch As Integer = Peek()
	  If (ch >= "a"c AndAlso ch <= "z"c) OrElse (ch >= "A"c AndAlso ch <= "Z"c) OrElse (ch >= 128 AndAlso ch <= 255) OrElse (ch >= "0"c AndAlso ch <= "9"c) OrElse ch = "-"c OrElse ch = "%"c OrElse ch = "!"c OrElse ch = "#"c OrElse ch = "$"c OrElse ch = "%"c OrElse ch = "&"c OrElse ch = "*"c OrElse ch = "~"c OrElse ch = "_"c Then
		Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder(ch)
		ReadChar()
		ch = Peek()
		Do While (ch >= "a"c AndAlso ch <= "z"c) OrElse (ch >= "A"c AndAlso ch <= "Z"c) OrElse (ch >= 128 AndAlso ch <= 255) OrElse (ch >= "0"c AndAlso ch <= "9"c) OrElse ch = "-"c OrElse ch = "%"c OrElse ch = "_"c
		  ReadChar()
		  sb.Append(CChar(ch))
		  ch = Peek()
		Loop
		str = sb.ToString()
		Return True
	  Else
		Return False
	  End If
	End Function

	Private Function ProbeNumber(ByRef str As String) As Boolean
	  Dim ch As Integer = Peek()

	  If (ch >= "0"c AndAlso ch <= "9"c) OrElse ch = "."c Then
		Dim sb As System.Text.StringBuilder = New System.Text.StringBuilder(ch)
		ReadChar()
		Dim chp As Integer = ch
		ch = Peek()
		If chp = "."c AndAlso Not(ch >= "0"c AndAlso ch <= "9"c) Then
		  PutBack(CChar(chp))
		  Return False
		End If
		Do While (ch >= "0"c AndAlso ch <= "9"c) OrElse ch = "."c
		  ReadChar()
		  sb.Append(CChar(ch))
		  ch = Peek()
		Loop
		str = sb.ToString()
		Return True
	  Else
		Return False
	  End If
	End Function
	Public Function ReadToken() As Token
	  _token = ReadTokenInternal()
	  Return _token
	End Function

	Private Function ReadTokenInternal() As Token
	  Dim tokenValue As String = ""
	  If Peek() = -1 Then
		Return Token.EOF
	  End If
	  If Probe("\x9") OrElse Probe("\xA") OrElse Probe("\xC") OrElse Probe("\xD") OrElse Probe(" ") Then
		_tokenValue = ""
		Return Token.S
	  Else If Probe("/*") Then
		Dim ch As Integer = Peek()
		Do While ch <> -1
		  ReadChar()
		  If ch = "*"c AndAlso Peek() = "/"c Then
			ReadChar()
			Exit Do
		  End If
		  ch = Peek()
		Loop
		Return Token.S
	  Else If Probe("<!--") Then
		Return Token.CDO
	  Else If Probe("-->") Then
		Return Token.CDC
	  Else If Probe("~=") Then
		Return Token.INCLUDES
	  Else If Probe("|=") Then
		Return Token.DASHMATCH
	  Else If ProbeString(tokenValue) Then
		_tokenValue = tokenValue
		Return Token.STRING
	  Else If ProbeIdent(tokenValue) Then
		_tokenValue = tokenValue
		If Probe("(") Then
		  Return Token.FUNCTION
		Else
		  Return Token.IDENT
		End If
	  Else If Probe("#") AndAlso ProbeName(tokenValue) Then
		_tokenValue = tokenValue
		Return Token.HASH
	  Else If Probe("@import") Then
		Return Token.IMPORT_SYM
	  Else If Probe("@page") Then
		Return Token.PAGE_SYM
	  Else If Probe("@media") Then
		Return Token.MEDIA_SYM
	  Else If Probe("@font-face") Then
		Return Token.FONT_FACE_SYM
	  Else If Probe("@charset") Then
		Return Token.CHARSET_SYM
	  Else If Probe("@") AndAlso ProbeIdent(tokenValue) Then
		_tokenValue = tokenValue
		Return Token.ATKEYWORD
	  Else If Probe("!") AndAlso SkipSpaces() AndAlso Probe("important") Then
		Return Token.IMPORTANT_SYM
	  Else If ProbeNumber(tokenValue) Then
		_tokenValue = tokenValue
		If Probe("em") Then
		  _tokenValue = _tokenValue & "em"
		  Return Token.EMS
		Else If Probe("ex") Then
		  _tokenValue = _tokenValue & "ex"
		  Return Token.EXS
		Else If Probe("px") Then
		  _tokenValue = _tokenValue & "px"
		  Return Token.LENGTH
		Else If Probe("cm") Then
		  _tokenValue = _tokenValue & "cm"
		  Return Token.LENGTH
		Else If Probe("mm") Then
		  _tokenValue = _tokenValue & "mm"
		  Return Token.LENGTH
		Else If Probe("in") Then
		  _tokenValue = _tokenValue & "in"
		  Return Token.LENGTH
		Else If Probe("pt") Then
		  _tokenValue = _tokenValue & "pt"
		  Return Token.LENGTH
		Else If Probe("pc") Then
		  _tokenValue = _tokenValue & "pc"
		  Return Token.LENGTH
		Else If Probe("deg") Then
		  _tokenValue = _tokenValue & "deg"
		  Return Token.ANGLE
		Else If Probe("rad") Then
		  _tokenValue = _tokenValue & "rad"
		  Return Token.ANGLE
		Else If Probe("grad") Then
		  _tokenValue = _tokenValue & "grad"
		  Return Token.ANGLE
		Else If Probe("ms") Then
		  _tokenValue = _tokenValue & "ms"
		  Return Token.TIME
		Else If Probe("s") Then
		  _tokenValue = _tokenValue & "s"
		  Return Token.TIME
		Else If Probe("hz") Then
		  _tokenValue = _tokenValue & "hz"
		  Return Token.FREQ
		Else If Probe("khz") Then
		  _tokenValue = _tokenValue & "khz"
		  Return Token.FREQ
		Else If Probe("%") Then
		  _tokenValue = _tokenValue & "%"
		  Return Token.PERCENTAGE
		Else If ProbeIdent(tokenValue) Then
		  _tokenValue = _tokenValue & tokenValue
		  Return Token.DIMEN
		Else
		  Return Token.NUMBER
		End If
	  Else If Probe("url(") Then
		SkipSpaces()
		If ProbeString(tokenValue) Then
		  _tokenValue = tokenValue
		  Return Token.URI
		Else If ProbeURL(tokenValue) Then
		  _tokenValue = tokenValue
		  Return Token.URI
		Else
		  _tokenValue = (CChar(ReadChar())).ToString()
		  Return Token.unrecognized
		End If
	  Else
		_tokenValue = (CChar(ReadChar())).ToString()
		Return Token.SYMBOL
	  End If
	End Function
  End Class

  Public Class CSSParser
	Private _reader As TextReader
	Private _writer As XmlWriter
	Private _tokenizer As Tokenizer
	Public Sub New(ByVal reader As TextReader, ByVal writer As XmlWriter)
	  _reader = reader
	  _tokenizer = New Tokenizer(reader)
	  _writer = writer
	End Sub

	Private Function TokenIs(ByVal token As Token) As Boolean
	  Return _tokenizer.LastToken Is token
	End Function

	Private Sub ReadToken()
	  _tokenizer.ReadToken()
	End Sub

	Private Sub SkipSpaces(ByVal write As Boolean)
	  Dim wasSpace As Boolean = False
	  Do While TokenIs(Token.S) OrElse TokenIs(Token.CDO) OrElse TokenIs(Token.CDC)
		_tokenizer.ReadToken()
		wasSpace = True
	  Loop
	  If write AndAlso wasSpace Then
	  _writer.WriteString(" ")
	  End If
	End Sub

	Private Function TokenExpected(ByVal token As Token) As String
	  If (Not TokenIs(token)) Then
		Throw New Exception(String.Format("Token {0} expected, but {1} foud", token, _tokenizer.LastToken))
	  End If
	  Dim s As String = _tokenizer.LastTokenValue
	  ReadToken()
	  Return s
	End Function

	Private Sub SymbolExpected(ByVal symbol As Char)
	  Dim wasToken As Token = Token.EOF
	  Dim s As String
	  Try
		wasToken = _tokenizer.LastToken
		s = TokenExpected(Token.SYMBOL)
	  Catch e As Exception
		Throw New Exception(String.Format("'{0}' expected, but '{1}' foud", symbol, wasToken), e)
	  End Try
	  If s <> New String(symbol, 1) Then
		Throw New Exception(String.Format("'{0}' expected, but '{1}' foud", symbol, s))
	  End If
	End Sub

	Private Sub ReadCharset()
	  TokenExpected(Token.CHARSET_SYM)
	  SkipSpaces(False)
	  Dim charset As String = TokenExpected(Token.STRING)
	  SkipSpaces(False)
	  SymbolExpected(";"c)
	  SkipSpaces(False)
	  _writer.WriteAttributeString("charset", charset)
	End Sub

	Private Sub ReadImport()
	  _writer.WriteStartElement("css:import")
	  TokenExpected(Token.IMPORT_SYM)
	  SkipSpaces(False)
	  Dim s As String
	  If TokenIs(Token.URI) Then
		s = TokenExpected(Token.URI)
	  Else
		s = TokenExpected(Token.STRING)
	  End If
	  SkipSpaces(False)
	  _writer.WriteAttributeString("uri", s)
	  Do While TokenIs(Token.IDENT)
		Dim medium As String = _tokenizer.LastTokenValue
		_writer.WriteStartElement("css:medium")
		_writer.WriteAttributeString("value", medium)
		_writer.WriteEndElement()
		SkipSpaces(False)
		ReadToken()
		If TokenIs(Token.SYMBOL) AndAlso _tokenizer.LastTokenValue = "," Then
		  ReadToken()
		  SkipSpaces(False)
		End If
	  Loop
	  SymbolExpected(";"c)
	  SkipSpaces(False)
	  _writer.WriteEndElement()
	End Sub

	Private Function ReadElementName() As Boolean
	  If TokenIs(Token.IDENT) OrElse (TokenIs(Token.SYMBOL) AndAlso _tokenizer.LastTokenValue = "*") Then
		If TokenIs(Token.IDENT) Then
		  _writer.WriteString(_tokenizer.LastTokenValue)
		Else
		  _writer.WriteString("*")
		End If
		ReadToken()
		Return True
	  Else
		Return False
	  End If
	End Function

	Private Sub ReadClass()
	  SymbolExpected("."c)
	  _writer.WriteString("." & _tokenizer.LastTokenValue)
	  TokenExpected(Token.IDENT)
	End Sub

	Private Sub ReadAttrib()
	  SymbolExpected("["c)
	  _writer.WriteString("[")

	  SkipSpaces(False)
	  _writer.WriteString(_tokenizer.LastTokenValue)
	  TokenExpected(Token.IDENT)
	  SkipSpaces(True)
	  If (TokenIs(Token.SYMBOL) AndAlso _tokenizer.LastTokenValue = "=") OrElse TokenIs(Token.INCLUDES) OrElse TokenIs(Token.DASHMATCH) Then
		_writer.WriteString(_tokenizer.LastTokenValue)
		ReadToken()
	  End If
	  SkipSpaces(True)
	  If TokenIs(Token.IDENT) OrElse TokenIs(Token.STRING) Then
		' TODO:		  _writer.WriteString(_tokenizer.LastTokenValue);
		ReadToken()
	  End If
	  SkipSpaces(False)
	  SymbolExpected("]"c)
	  _writer.WriteString("]")
	End Sub

	Private Sub ReadPseudo()
	  SymbolExpected(":"c)
	  _writer.WriteString(":")
	  If TokenIs(Token.IDENT) Then
		_writer.WriteString(_tokenizer.LastTokenValue)
		ReadToken()
	  Else
		_writer.WriteString(_tokenizer.LastTokenValue & "(")
		TokenExpected(Token.FUNCTION)
		SkipSpaces(False)
		_writer.WriteString(_tokenizer.LastTokenValue)
		TokenExpected(Token.IDENT)
		SkipSpaces(False)
		SymbolExpected(")"c)
		_writer.WriteString(")")
	  End If
	End Sub

	Private Function ReadSimpleSelector() As Boolean
	  Dim wasAnything As Boolean = ReadElementName()
'ORIGINAL LINE: for(;;)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
	  Do While True
		If TokenIs(Token.HASH) Then
		  _writer.WriteString("#" & _tokenizer.LastTokenValue)
		  ReadToken()
		  wasAnything = True
		Else If TokenIs(Token.SYMBOL) AndAlso _tokenizer.LastTokenValue = "." Then
		  ReadClass()
		  wasAnything = True
		Else If TokenIs(Token.SYMBOL) AndAlso _tokenizer.LastTokenValue = "[" Then
		  ReadAttrib()
		  wasAnything = True
		Else If TokenIs(Token.SYMBOL) AndAlso _tokenizer.LastTokenValue = ":" Then
		  ReadPseudo()
		  wasAnything = True
		Else
		  Exit Do
		End If
	  Loop
	  SkipSpaces(True)
	  Return wasAnything
	End Function

	Private Function ReadCombinator() As Boolean
	  Dim wasAnything As Boolean = False
	  If TokenIs(Token.SYMBOL) Then
		If _tokenizer.LastTokenValue = "+" Then
		  _writer.WriteString(_tokenizer.LastTokenValue)
		  ReadToken()
		  wasAnything = True
		  SkipSpaces(True)
		Else If _tokenizer.LastTokenValue = ">" Then
		  _writer.WriteString(_tokenizer.LastTokenValue)
		  ReadToken()
		  wasAnything = True
		  SkipSpaces(True)
		End If
	  End If
	  Return wasAnything
	End Function

	Private Sub ReadSelector()
	  _writer.WriteStartElement("css:selector")
	  ReadSimpleSelector()
	  Dim wasAnything As Boolean = True
	  Do While wasAnything
		wasAnything = ReadCombinator()
		wasAnything = wasAnything OrElse ReadSimpleSelector()
	  Loop
	  _writer.WriteEndElement()
	End Sub

	Private Sub ReadProperty()
	  _writer.WriteAttributeString("property-name", _tokenizer.LastTokenValue)
	  TokenExpected(Token.IDENT)
	  SkipSpaces(False)
	End Sub

	Private Sub ReadUnaryOperator()
	  If TokenIs(Token.SYMBOL) Then
		If _tokenizer.LastTokenValue = "+" Then
		  _writer.WriteString(_tokenizer.LastTokenValue)
		  ReadToken()
		Else
		  _writer.WriteString(_tokenizer.LastTokenValue)
		  SymbolExpected("-"c)
		End If
	  Else
		TokenExpected(Token.SYMBOL)
	  End If
	End Sub

	Private Sub ReadFunction()
	  _writer.WriteString(_tokenizer.LastTokenValue & "(")
	  TokenExpected(Token.FUNCTION)
	  SkipSpaces(False)
	  ReadExpr()
	  SymbolExpected(")"c)
	  _writer.WriteString(")")
	  SkipSpaces(False)
	End Sub

	Private Sub ReadTerm()
	  If (TokenIs(Token.SYMBOL) AndAlso (_tokenizer.LastTokenValue = "+" OrElse _tokenizer.LastTokenValue = "-")) Then
		ReadUnaryOperator()
	  Else If TokenIs(Token.NUMBER) OrElse TokenIs(Token.PERCENTAGE) OrElse TokenIs(Token.LENGTH) OrElse TokenIs(Token.EMS) OrElse TokenIs(Token.EXS) OrElse TokenIs(Token.ANGLE) OrElse TokenIs(Token.TIME) OrElse TokenIs(Token.FREQ) OrElse TokenIs(Token.STRING) OrElse TokenIs(Token.IDENT) OrElse TokenIs(Token.URI) OrElse TokenIs(Token.UNICODERANGE) Then
		_writer.WriteString(_tokenizer.LastTokenValue)
		ReadToken()
		SkipSpaces(True)
	  Else If TokenIs(Token.HASH) Then
		_writer.WriteString("#" & _tokenizer.LastTokenValue)
		ReadToken()
		SkipSpaces(True)
	  Else If TokenIs(Token.FUNCTION) Then
		ReadFunction()
	  Else
		'  int i = 0; // never used? 
	  End If

	End Sub

	Private Sub ReadOperator()
	  If TokenIs(Token.SYMBOL) Then
		If _tokenizer.LastTokenValue = "/" Then
		  _writer.WriteString(_tokenizer.LastTokenValue)
		  ReadToken()
		  SkipSpaces(True)
		Else If _tokenizer.LastTokenValue = "," Then
		  _writer.WriteString(_tokenizer.LastTokenValue)
		  ReadToken()
		  SkipSpaces(True)
		End If
	  End If
	End Sub

	Private Sub ReadExpr()
	  ReadTerm()
'ORIGINAL LINE: for (;;)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
	  Do While True
		ReadOperator() ' TODO: If somethis has been read then TERM must follow
		If (TokenIs(Token.SYMBOL) AndAlso (_tokenizer.LastTokenValue = "+" OrElse _tokenizer.LastTokenValue = "-")) Then
		  ReadTerm()
		Else If TokenIs(Token.NUMBER) OrElse TokenIs(Token.PERCENTAGE) OrElse TokenIs(Token.LENGTH) OrElse TokenIs(Token.EMS) OrElse TokenIs(Token.EXS) OrElse TokenIs(Token.ANGLE) OrElse TokenIs(Token.TIME) OrElse TokenIs(Token.FREQ) OrElse TokenIs(Token.STRING) OrElse TokenIs(Token.IDENT) OrElse TokenIs(Token.URI) OrElse TokenIs(Token.UNICODERANGE) Then
		  ReadTerm()
		Else If TokenIs(Token.HASH) Then
		  ReadTerm()
		Else If TokenIs(Token.FUNCTION) Then
		  ReadTerm()
		Else
		  Exit Do
		End If
	  Loop
	End Sub

	Private Sub ReadPrio()
	  TokenExpected(Token.IMPORTANT_SYM)
	  _writer.WriteAttributeString("important", "yes")
	  SkipSpaces(False)
	End Sub

	Private Sub ReadDeclaration()
	  If TokenIs(Token.IDENT) Then
		_writer.WriteStartElement("css:declaration")
		ReadProperty()
		SymbolExpected(":"c)
		SkipSpaces(False)
		ReadExpr()
		If TokenIs(Token.IMPORTANT_SYM) Then
		  ReadPrio()
		End If
		_writer.WriteEndElement()
	  End If
	End Sub

	Private Sub ReadRuleset()
	  _writer.WriteStartElement("css:ruleset")
	  ReadSelector()
	  Do While TokenIs(Token.SYMBOL) AndAlso _tokenizer.LastTokenValue = ","
		ReadToken()
		SkipSpaces(False)
		ReadSelector()
	  Loop
	  SymbolExpected("{"c)
	  SkipSpaces(False)
	  ReadDeclaration()
	  Do While TokenIs(Token.SYMBOL) AndAlso _tokenizer.LastTokenValue = ";"
		ReadToken()
		SkipSpaces(False)
		ReadDeclaration()
	  Loop
	  SymbolExpected("}"c)
	  SkipSpaces(False)
	  _writer.WriteEndElement()
	End Sub

	Private Sub ReadMedia()
	  _writer.WriteStartElement("css:media")
	  TokenExpected(Token.MEDIA_SYM)
	  SkipSpaces(False)
	  Dim medium As String = TokenExpected(Token.IDENT)
	  SkipSpaces(False)
	  _writer.WriteStartElement("css:medium")
	  _writer.WriteAttributeString("value", medium)
	  _writer.WriteEndElement()
	  Do While TokenIs(Token.SYMBOL) AndAlso _tokenizer.LastTokenValue = ","
		ReadToken()
		medium = TokenExpected(Token.IDENT)
		_writer.WriteStartElement("css:medium")
		_writer.WriteAttributeString("value", medium)
		_writer.WriteEndElement()
		SkipSpaces(False)
	  Loop

	  SymbolExpected("{"c)
	  SkipSpaces(False)
	  ReadRuleset()
	  SymbolExpected("}"c)
	  SkipSpaces(False)
	  _writer.WriteEndElement()
	End Sub

	Private Sub ReadPseudoPage()
	  SymbolExpected(":"c)
	  _writer.WriteAttributeString("pseudo", _tokenizer.LastTokenValue)
	  TokenExpected(Token.IDENT)
	End Sub

	Private Sub ReadPage()
	  _writer.WriteStartElement("css:page")
	  TokenExpected(Token.PAGE_SYM)
	  SkipSpaces(False)
	  If TokenIs(Token.IDENT) Then
		_writer.WriteAttributeString("page", _tokenizer.LastTokenValue)
		ReadToken()
	  End If
	  If TokenIs(Token.SYMBOL) AndAlso _tokenizer.LastTokenValue = ":" Then
		ReadPseudoPage()
	  End If
	  SkipSpaces(False)
	  SymbolExpected("{"c)
	  SkipSpaces(False)
	  ReadDeclaration()
	  Do While TokenIs(Token.SYMBOL) AndAlso _tokenizer.LastTokenValue = ";"
		SymbolExpected(";"c)
		SkipSpaces(False)
		ReadDeclaration()
	  Loop
	  SymbolExpected("}"c)
	  SkipSpaces(False)
	  _writer.WriteEndElement()
	End Sub

	Private Sub ReadATKEYWORD()
	  _writer.WriteStartElement("css:atkeyword")
	  _writer.WriteAttributeString("name", _tokenizer.LastTokenValue)
	  TokenExpected(Token.ATKEYWORD)
	  SkipSpaces(False)
	  ' if (TokenIs(Token.IDENT)) {
			  '_writer.WriteAttributeString("class-name", _tokenizer.LastTokenValue);
			  'ReadToken();
			'}
			'if (TokenIs(Token.SYMBOL) && _tokenizer.LastTokenValue == ":") {
			  'ReadPseudoPage();
			'}
	  '
	  ReadSelector()
	  SkipSpaces(False)
	  SymbolExpected("{"c)
	  SkipSpaces(False)
	  ReadDeclaration()
	  Do While TokenIs(Token.SYMBOL) AndAlso _tokenizer.LastTokenValue = ";"
		SymbolExpected(";"c)
		SkipSpaces(False)
		ReadDeclaration()
	  Loop
	  SymbolExpected("}"c)
	  SkipSpaces(False)
	  _writer.WriteEndElement()
	End Sub

	Private Sub ReadFontFace()
	  _writer.WriteStartElement("css:font-face")
	  TokenExpected(Token.FONT_FACE_SYM)
	  SkipSpaces(False)
	  SymbolExpected("{"c)
	  SkipSpaces(False)
	  ReadDeclaration()
	  Do While TokenIs(Token.SYMBOL) AndAlso _tokenizer.LastTokenValue = ";"
		SymbolExpected(";"c)
		SkipSpaces(False)
		ReadDeclaration()
	  Loop
	  SymbolExpected("}"c)
	  SkipSpaces(False)
	  _writer.WriteEndElement()
	End Sub

	Private Sub ReadStylesheet()
	  _writer.WriteStartElement("css", "stylesheet", "http://eleks.lviv.ua/NS/CSS-stylesheet")
	  ReadToken()
	  SkipSpaces(False)
	  If TokenIs(Token.CHARSET_SYM) Then
		ReadCharset()
	  End If
	  Do While TokenIs(Token.IMPORT_SYM)
		ReadImport()
	  Loop
'ORIGINAL LINE: for(;;)
'INSTANT VB NOTE: This 'for' loop was translated to a VB 'Do While' loop:
	  Do While True
		If TokenIs(Token.MEDIA_SYM) Then
		  ReadMedia()
		Else If TokenIs(Token.PAGE_SYM) Then
		  ReadPage()
		Else If TokenIs(Token.FONT_FACE_SYM) Then
		  ReadFontFace()
		Else If TokenIs(Token.ATKEYWORD) Then
		  ReadATKEYWORD()
		Else If TokenIs(Token.EOF) Then
		  Exit Do
		Else
		  ReadRuleset()
		End If
	  Loop
	  _writer.WriteEndElement()
	End Sub

	Public Sub Process()
	  ReadStylesheet()
	End Sub

	Public Sub ReadStyleAttribute()
	  ReadToken()

	  ReadDeclaration()
	  Do While TokenIs(Token.SYMBOL) AndAlso _tokenizer.LastTokenValue = ";"
		ReadToken()
		SkipSpaces(False)
		ReadDeclaration()
	  Loop
	  _writer.WriteEndElement()
	End Sub
  End Class
}
