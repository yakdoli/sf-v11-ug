::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=91545f50-e8ab-4b79-8ce1-139be19e5d2f){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=71291c1d-369c-4264-9215-95fe5c7b6e10){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Find and Replace](ms-xhelp:///?Id=b4e6a0de-f2a4-41d4-8e20-2b69555a0cfb){.d2h_breadcrumbsNormal}
:::

### Replace {#replace style="tab-stops: 0pt"}

 

**Replace** method provides support to replace text in the Word document. The following are the possible input parameters of the Replace method.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Pattern**: character pattern ( object of Regex class)

[·      ]{style="FONT-FAMILY: Symbol"}**Replace**: replace string

[·      ]{style="FONT-FAMILY: Symbol"}**Given**: string to be replaced

[·      ]{style="FONT-FAMILY: Symbol"}**CaseSensitive**: defines if replace is case sensitive.

 

For example if case sensitive is set to false and you want to replace \"AA\" string, then in such case strings like \"aA\" and \"Aa\" also will be replaced.

 

[·      ]{style="FONT-FAMILY: Symbol"}**WholeWord**: if set to true, string given must be the whole word (not the part of the word)

[·      ]{style="FONT-FAMILY: Symbol"}**SaveFormatting**: if set to true, it will preserve the existing place holder formatting

 

The following are the variants of the Replace method.

 

[·      ]{style="FONT-FAMILY: Symbol"}**Replace(Regex pattern, string replace)**: replaces of all occurrences of a character pattern specified by a regular expression with replace string

[·      ]{style="FONT-FAMILY: Symbol"}**Replace(string given, string replace, bool caseSensitive, bool wholeWord)**: replaces all entries of given string with replace string, taking into consideration caseSensitive and wholeWord options

[·      ]{style="FONT-FAMILY: Symbol"}**Replace(Regex pattern, TextSelection textSelection)**: replaces all entries of given regular expression with TextRangesHolder (TextSelection)

[·      ]{style="FONT-FAMILY: Symbol"}**Replace(string given, TextSelection textSelection, bool caseSensitive, bool wholeWord)**: replaces all entries of given string with TextSelection, taking into consideration caseSensitive and wholeWord options

[·      ]{style="FONT-FAMILY: Symbol"}**Replace(Regex pattern, TextBodyPart bodyPart)**: replaces all entries of given regular expression with TextBodyPart

[·      ]{style="FONT-FAMILY: Symbol"}**Replace(string given, TextBodyPart bodyPart, bool caseSensitive, bool wholeWord)**: replaces all entries of given string with TextBodyPart, taking into consideration caseSensitive and wholeWord options

[·      ]{style="FONT-FAMILY: Symbol"}**Replace(string given, IWordDocument replaceDoc, bool caseSensitive, bool wholeWord, bool saveFormatting)**: replaces all entries of given string with given word document, taking into consideration caseSensitive, wholeWord options and formatting option (to preserve the formatting of the existing place holder or the new document place holder)

[·      ]{style="FONT-FAMILY: Symbol"}**Replace(string given, TextBodyPart bodyPart, bool caseSensitive, bool wholeWord, bool saveFormatting)**: replaces all entries of given string with given TextBodyPart, taking into consideration caseSensitive, wholeWord options and formatting option

[·      ]{style="FONT-FAMILY: Symbol"}**Replace(string given, TextSelection textSelection, bool caseSensitive, bool wholeWord, bool saveFormatting)**: replaces all entries of given string with TextSelection, taking into consideration caseSensitive, wholeWord options and formatting option

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                            |
|                                                                                                                                                                                                                           |
| []{style="COLOR: black"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                           |
| **[Example 1:]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                      |
|                                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                |
|                                                                                                                                                                                                                           |
| [//This sample replace specified regular expression with Picture]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                       |
|                                                                                                                                                                                                                           |
| [TextBodyPart]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ textBodyPart = [new]{style="COLOR: blue"} [TextBodyPart]{style="COLOR: teal"}( doc );]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                                                                           |
| [Image]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ image = [Image]{style="COLOR: teal"}.FromFile( ImagesPath + [\"Image.gif\"]{style="COLOR: maroon"} );]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                                           |
| [WPicture]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ pict = [new]{style="COLOR: blue"} [WPicture]{style="COLOR: teal"}( doc );]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                                                           |
| [pict.LoadImage( image );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                           |
| [WParagraph]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ para = [new]{style="COLOR: blue"} [WParagraph]{style="COLOR: teal"}( doc );]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                                           |
| [para.Items.Add( pict );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                           |
| [textBodyPart.BodyItems.Insert( 0, para );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                                           |
| [doc.Replace( [new]{style="COLOR: blue"} Regex( [\"A\"]{style="COLOR: maroon"} ), textBodyPart );]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                           |
| **[Example 2:]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                      |
|                                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                |
|                                                                                                                                                                                                                           |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ docSource1 = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                                                           |
| [docSource1.Open( DocumentsPath + FINDSOURCE1 );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                                           |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ docSource2 = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                                                           |
| [docSource2.Open( DocumentsPath + FINDSOURCE2 );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                                           |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ docTemplate = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                                                           |
| [docTemplate.Open( DocumentsPath + FINDTEMPLATE );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                      |
|                                                                                                                                                                                                                           |
| [//Finds and returns entry of specified regular expression along with formatting]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                       |
|                                                                                                                                                                                                                           |
| [TextSelection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ rangesHolder1 = docSource1.Find( [\"The PlaceHolder1 was replaced by ]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                                           |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ sample Text.[\", false, false );]{style="COLOR: maroon"}]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                      |
|                                                                                                                                                                                                                           |
| [//Create new TextSelection object, with text and it\'s formatting specified by ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                       |
|                                                                                                                                                                                                                           |
| [//character range.In current sample character range is a paragraph\'s range of ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                       |
|                                                                                                                                                                                                                           |
| [//symbols from 1 to 4 position.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                       |
|                                                                                                                                                                                                                           |
| [TextSelection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ rangesHolder2 = [new]{style="COLOR: blue"} [TextSelection]{style="COLOR: teal"}( docSource2.LastParagraph, 1, 4 );]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                           |
| [docTemplate.Replace( [new]{style="COLOR: blue"} Regex( [\"PlaceHolder1\"]{style="COLOR: maroon"} ), rangesHolder1 );]{style="FONT-FAMILY: 'Courier New'"}                                                                |
|                                                                                                                                                                                                                           |
| [docTemplate.Replace( [new]{style="COLOR: blue"} Regex( [\"PlaceHolder2\"]{style="COLOR: maroon"} ), rangesHolder2 );]{style="FONT-FAMILY: 'Courier New'"}                                                                |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                   |
| []{style="COLOR: black"}                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                   |
| **[Example 1:]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                   |
| [\'This sample replace specified regular expression with Picture]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ textBodyPart [As]{style="COLOR: blue"} TextBodyPart = [New]{style="COLOR: blue"} TextBodyPart(doc)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ image [As]{style="COLOR: blue"} Image = Image.FromFile(ImagesPath & [\"Image.gif\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                          |
|                                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pict [As]{style="COLOR: blue"} WPicture = [New]{style="COLOR: blue"} WPicture(doc)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                   |
| [pict.LoadImage(image)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ para [As]{style="COLOR: blue"} WParagraph = [New]{style="COLOR: blue"} WParagraph(doc)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                   |
| [para.Items.Add(pict)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                   |
| [textBodyPart.BodyItems.Insert(0, para)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                   |
| [doc.Replace([New]{style="COLOR: blue"} Regex([\"A\"]{style="COLOR: maroon"}), textBodyPart)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                   |
| **[Example 2:]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ docSource1 [As]{style="COLOR: blue"} WordDocument = [New]{style="COLOR: blue"} WordDocument()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                   |
| [docSource1.Open(DocumentsPath + FINDSOURCE1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ docSource2 [As]{style="COLOR: blue"} WordDocument = [New]{style="COLOR: blue"} WordDocument()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                   |
| [docSource2.Open(DocumentsPath + FINDSOURCE2)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ docTemplate [As]{style="COLOR: blue"} WordDocument = [New]{style="COLOR: blue"} WordDocument()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                   |
| [docTemplate.Open(DocumentsPath + FINDTEMPLATE)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                   |
| [\'Finds and returns entry of specified regular expression along with formatting]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ rangesHolder1 [As]{style="COLOR: blue"} TextSelection = docSource1.Find([\"The PlaceHolder1 was replaced by this sample Text.\"]{style="COLOR: maroon"}, [False]{style="COLOR: blue"}, [False]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                   |
| [\'Create new TextSelection object, with text and it\'s formatting specified by ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                   |
| [\'character range.In current sample character range is a paragraph\'s range of ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                   |
| [\'symbols from 1 to 4 position.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ rangesHolder2 [As]{style="COLOR: blue"} TextSelection = [New]{style="COLOR: blue"} TextSelection(docSource2.LastParagraph, 1, 4)]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
|                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                   |
| [docTemplate.Replace([New]{style="COLOR: blue"} Regex([\"PlaceHolder1\"]{style="COLOR: maroon"}), rangesHolder1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                   |
| [docTemplate.Replace([New]{style="COLOR: blue"} Regex([\"PlaceHolder2\"]{style="COLOR: maroon"}), rangesHolder2)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

If you want to replace the first occurrence of a particular text alone, which appears more than once, set **doc.ReplaceFirst** property to **True**.

 

+---------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                        |
|                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                  |
|                                                                                       |
| [doc.ReplaceFirst = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------+
| **\[VB.NET\]**                                                                        |
|                                                                                       |
|                                                                                       |
|                                                                                       |
| [doc.ReplaceFirst = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------+

 

**Replace with SingleLine Mode**

 

It is also possible to replace the string with .NET Regex **SingleLine** mode by using the **ReplaceSingleLine** method of DocIO. This enables the user to find the specified text of regular expression including the newline or carriage return, and replaces it with the given text.

 

The following table lists the overloads of this method.

 

::: {align="center"}
  ------------------------------------------------------------ ------------------------------------------------------------------------------------
  Name                                                         Description
  ReplaceSingleLine(Regex, TextBodyPart)                       Replaces the pattern with specified replacement in single-line mode.
  ReplaceSingleLine(Regex, TextSelection)                      Replaces the given pattern with replacement in single-line mode.
  ReplaceSingleLine(Regex, String)                             Replaces all entries with specified pattern with replace text in single-line mode.
  ReplaceSingleLine(String, TextBodyPart, Boolean, Boolean)    Replaces the given text with specified replacement in single-line mode.
  ReplaceSingleLine(String, TextSelection, Boolean, Boolean)   Replaces the given text with replacement in single-line mode.
  ReplaceSingleLine(String, String, Boolean, Boolean)          Replaces all entries of given text with replace text in single-line mode.
  ------------------------------------------------------------ ------------------------------------------------------------------------------------
:::

 

The following code snippet illustrates the SingleLine mode replacement.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                       |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                 |
|                                                                                                                                                                      |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ doc = new [WordDocument]{style="COLOR: teal"}(\"sample.doc\");]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                      |
| [string search = \"\\\\\|(.\|\\r\\n\|\\r\|\\n)\*?\\\\\|\";]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                      |
| [// The singleline option should cause \\r\\n to be included in .\*]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                               |
|                                                                                                                                                                      |
| [Regex expr = new Regex(search, RegexOptions.Singleline);]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                      |
| [doc.[ReplaceSingleLine]{style="COLOR: teal"}(expr, \"test\");]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                        |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
|                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc As New [WordDocument]{style="COLOR: teal"}(\"sample.doc\")]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ search As String = \"\\\|(.\|\" & vbCr & vbLf & \"\|\" & vbCr & \"\|\" & vbLf & \")\*?\\\|\"]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                      |
|                                                                                                                                                                                           |
| [\' The singleline option should cause \\r\\n to be included in .\*]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                    |
|                                                                                                                                                                                           |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ expr As New Regex(search, RegexOptions.Singleline)]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                           |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                    |
|                                                                                                                                                                                           |
| [doc.[ReplaceSingleLine]{style="COLOR: teal"}(expr, \"test\")]{style="FONT-FAMILY: 'Courier New'"}                                                                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::::
