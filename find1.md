::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=c88d080c-ec5e-4858-8ed9-c1b8e9e3d418){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=43a286db-8619-4eb5-b53a-e2dfb5bb38dd){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Find and Replace](ms-xhelp:///?Id=b4e6a0de-f2a4-41d4-8e20-2b69555a0cfb){.d2h_breadcrumbsNormal}
:::

### Find {#find style="tab-stops: 0pt"}

 

Essential DocIO provides various methods to improve the flexibility of the Find feature in the Word document.

 

**Find Method**

 

Find method is used to find an entry with a specified text of regular expression in the Word document.

 

Following are the possible input parameters of the Find method.

 

[·      ]{style="FONT-FAMILY: Symbol"}given string to find.

[·      ]{style="FONT-FAMILY: Symbol"}**caseSensitive**: defines if replace is case sensitive. For example, if case sensitive is set to false, and you want to find \"AA\" string, then in such case strings like \"aA\" and \"Aa\" also will be returned (will fit the search conditions).

[·      ]{style="FONT-FAMILY: Symbol"}**wholeWord**: if set to true, string given must be the whole word (not part of the word).

 

The following are the variants of the Find method.

 

[·      ]{style="FONT-FAMILY: Symbol"}**TextSelection Find(string given, bool caseSensitive, bool wholeWord)** - finds and returns an entry of specified string along with formatting, taking into consideration case-sensitive and whole word options.

[·      ]{style="FONT-FAMILY: Symbol"}**TextSelection Find(Regex pattern)** - finds and returns entry of specified regular expression along with formatting.

[·      ]{style="FONT-FAMILY: Symbol"}**TextSelection\[\] FindAll(Regex pattern)** - finds and returns all entries of specified regular expression along with formatting.

[·      ]{style="FONT-FAMILY: Symbol"}**TextSelection\[\] FindAll(string given, bool caseSensitive, bool wholeWord)** - finds and returns all entries of specified string along with formatting, taking into consideration case-sensitive and whole word options.

 

The following example illustrates how to use the Find method.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                |
|                                                                                                                                                                                                                                               |
| []{style="COLOR: black"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                               |
| [doc.Open( \"sample.doc\" );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                               |
| [TextSelection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ rangesHolder1 = doc.Find( [\"The PlaceHolder1\"]{style="COLOR: maroon"}, [false]{style="COLOR: blue"}, [false]{style="COLOR: blue"} );]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                          |
| [doc.Open([\"sample.doc\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ rangesHolder1 [As]{style="COLOR: blue"} TextSelection = doc.Find([\"The PlaceHolder1\"]{style="COLOR: maroon"}, [False]{style="COLOR: blue"}, [False]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**FindNext Method**

 

You can find a particular string from a paragraph region or table by using the **FindNext** method. The following code illustrates this.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                           |
|                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                     |
|                                                                                                                                                                                                                          |
| [//To find and replace particular table]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                               |
|                                                                                                                                                                                                                          |
| [IWTable table = doc.Sections\[0\].Tables\[0\];]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                                          |
| [TextSelection selc = doc.FindNext(table [as]{style="COLOR: blue"} TextBodyItem, [\"textAA\"]{style="COLOR: #a31515"}, [false]{style="COLOR: blue"}, [false]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                          |
| [WTextRange range = selc.GetAsOneRange();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                                                          |
| [range.Text = [\"TextReplaced\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                          |
| [//or To find and replace from particular paragraph]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                   |
|                                                                                                                                                                                                                          |
| [IWTable table1 = doc.Sections\[0\].Tables\[0\];]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                          |
| [IWParagraph par = table1.Rows\[1\].Cells\[0\].Paragraphs\[0\];]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                          |
| [TextSelection sel1 = doc.FindNext(par [as]{style="COLOR: blue"} TextBodyItem, [\"ref AA\"]{style="COLOR: #a31515"}, [false]{style="COLOR: blue"}, [false]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                          |
| [WTextRange range1 = sel1.GetAsOneRange();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                                          |
| [range1.Text = [\"New Text\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                |
| [\'To find and replace particular table]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ table [As]{style="COLOR: blue"} IWTable = doc.Sections(0).Tables(0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ selc [As]{style="COLOR: blue"} TextSelection = doc.FindNext(TryCast(table, TextBodyItem), \"textAA\", [False]{style="COLOR: blue"}, [False]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ range [As]{style="COLOR: blue"} WTextRange = selc.GetAsOneRange()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                                                                                |
| [range.Text = \"TextReplaced\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                |
| [\'or To find and replace from particular paragraph]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                         |
|                                                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ table1 [As]{style="COLOR: blue"} IWTable = doc.Sections(0).Tables(0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ par [As]{style="COLOR: blue"} IWParagraph = table1.Rows(1).Cells(0).Paragraphs(0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ sel1 [As]{style="COLOR: blue"} TextSelection = doc.FindNext(TryCast(par, TextBodyItem), \"ref AA\", [False]{style="COLOR: blue"}, [False]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ range1 [As]{style="COLOR: blue"} WTextRange = sel1.GetAsOneRange()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                                                                                |
| [range1.Text = \"New Text\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**Find with SingleLine mode**

**[]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black; FONT-SIZE: 8pt"}** 

**FindSingleLine** method is used to find an entry in a document with a specified text of regular expression, including the newline or carriage return. This works in the same way as the SingleLine mode of .NET Regex. Note that the Find method will find the text only in a single paragraph without any newlines or carriage return considerations.

 

::: {align="center"}
  ------------------------------------------ -----------------------------------------------------------------
  Name                                       Description
  FindSingleLine(Regex)                      Finds the first entry of specified pattern in single-line mode.
  FindSingleLine(String, Boolean, Boolean)   Finds the first entry of given text in single-line mode.
  ------------------------------------------ -----------------------------------------------------------------
:::

 

It is also possible to find the string with SingleLine mode from a particular region by using the **FindNextSingleLine** method of the WordDocument class.

 

::: {align="center"}
  ------------------------------------------------------------ --------------------------------------------------------------------------------------------------------------
  Name                                                         Description
  FindNextSingleLine(TextBodyItem, Regex)                      Finds the next text which fit the specified pattern starting from start TextBodyItem using single-line mode.
  FindNextSingleLine(TextBodyItem, String, Boolean, Boolean)   Finds the next given text starting from specified. TextBodyItem using single-line mode.
  ------------------------------------------------------------ --------------------------------------------------------------------------------------------------------------
:::

 

The following example illustrates how to find a string in the SingleLine mode.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                       |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                 |
|                                                                                                                                                                      |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ doc = new [WordDocument]{style="COLOR: teal"}(\"Sample.doc\");]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                      |
| [string search = \"\\\\\[start\\\\\](.\*)\\\\\[end\\\\\]\";]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                               |
|                                                                                                                                                                      |
| [// The singleline option should cause \\r\\n to be included in .\*]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                               |
|                                                                                                                                                                      |
| [Regex expr = new Regex(search, RegexOptions.Singleline);]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                      |
| [     ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                      |
| [WTable table = doc.Sections\[0\].Tables\[0\] as WTable;]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
|                                                                                                                                                                      |
| [TextSelection\[\] sel = doc.[FindNextSingleLine]{style="COLOR: teal"}(table as TextBodyItem, expr);]{style="FONT-FAMILY: 'Courier New'"}                            |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                    |
|                                                                                                                                                                                                       |
|                                                                                                                                                                                                       |
|                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc As New [WordDocument]{style="COLOR: teal"}(\"Sample.doc\")]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ search As String = \"\\\[start\\\](.\*)\\\[end\\\]\"]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                       |
| [\' The singleline option should cause \\r\\n to be included in .\*]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                |
|                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ expr As New [Regex]{style="COLOR: teal"}(search, RegexOptions.Singleline)]{style="FONT-FAMILY: 'Courier New'"}                                |
|                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ tab As WTable = TryCast(doc.Sections(0).Tables(0), WTable)]{style="FONT-FAMILY: 'Courier New'"}                                               |
|                                                                                                                                                                                                       |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ sel As TextSelection() = doc.[FindNextSingleLine]{style="COLOR: teal"}(TryCast(tab, TextBodyItem), expr)]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
::::::
