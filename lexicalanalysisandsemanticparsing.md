::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=b4235dc8-9f21-46bb-8e19-727d885592d8){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=8629fda6-ad48-4d6d-a648-9baa247658cb){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Edit]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts And Features](ms-xhelp:///?Id=7c39cee6-8434-4711-a18e-efaba8ac85c0){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[File Sharing and Stream Handling](ms-xhelp:///?Id=9cea4e18-36d3-40c5-b641-61dfaefd6bce){.d2h_breadcrumbsNormal}
:::

### Lexical Analysis And Semantic Parsing {#lexical-analysis-and-semantic-parsing style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Text parsing occurs when a new document is loaded or when modifications occur in an already loaded document. In case of modifications, the Edit Control intelligently reparses only what is necessary to ensure that the text model is up to date with the contents of the editor. Ideally, parsing the Edit Control occurs in a two-phase approach. The first phase is lexical analysis and the second one is semantic parsing.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Lexical Analysis breaks up text into tokens, while semantic parsing goes a step further and assigns extra contextual meaning to the tokens. Semantic relations recognized by the semantic parser are based on how human beings represent knowledge of the world. Semantic parsing allows tokens to be accessed and processed in a more meaningful way than lexical analysis, moving the automation of understanding the tokens to a higher level. A semantic parser consumes the output of the lexical analyzer, and operates by analyzing the sequence of tokens returned. The parser matches these sequences to an end state which may be one of the possible end states. The end states define the goals of the parser. When an end state is reached, the program using the parser implements some action-specific code.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Additionally, parsers can detect the situation when no legal end state can be reached, from the sequence of tokens that have been processed.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Lexical Analysis

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Lexical Analysis is the process of scanning text in a document and breaking it up into meaningful tokens. The purpose of lexical analyzers is to take a stream of input characters, and decode them into higher level tokens that a semantic parser can understand. In this stage, the text is split into tokens with the help of some special rules specified by the user. For instance, the user can specify \"=+\" or \"end if \" expressions as single tokens using the Split tag in the configuration file. Tokens are plain text, and have no additional information or meaning associated with them.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Semantic Parsing

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

In this stage, the syntax highlighting rules are applied. These rules can be as simple as identifying the format name of the token, and applying the appropriate font or color settings. But this simple two-phase procedure was not very flexible in complex scenarios involving embedded scripts. Hence the entire process has been enhanced from the very beginning, by merging the lexical analysis and semantic parsing.

 

The **Parser** property indicates the parser used for parsing the currently loaded document in the Edit Control. The parsing process could be performed for any (or all) of the following purposes - syntax highlighting, intellisense, outlining and so on. The rules for the parsing process are specified in the XML based configuration file used.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                   |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                             |
|                                                                                                                                                  |
| [// Indicates the parser used for parsing the currently loaded document in the Edit Control. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                  |
| [RenderableLexemParser lexemParser = [this]{style="COLOR: blue"}.editControl1.Parser;]{style="FONT-FAMILY: 'Courier New'"}                       |
+--------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                       |
|                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                     |
|                                                                                                                                                                                                          |
| [\' Indicates the parser used for parsing the currently loaded document in the Edit Control. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                         |
|                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ lexemParser [As]{style="COLOR: blue"} RenderableLexemParser = [Me]{style="COLOR: blue"}.editControl1.Parser]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Parsing Modes

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Edit Control supports several modes of text parsing which can be specified to the **ParsingMode** property by using the **TextParsingMode** enumerator. The default value of the ParsingMode property is set to **PartialParsingNoFallback**.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------+
| Edit Control Property             | Description                                                                                                                              |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------+
| ParsingMode                       | Gets / sets text parsing mode. User can select between high parsing speed or high syntax highlighting accuracy. The options provided are |
|                                   |                                                                                                                                          |
|                                   | *[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}*                                                       |
|                                   |                                                                                                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}FullParsing                                                                                        |
|                                   |                                                                                                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}PartialParsingNoFallback                                                                           |
|                                   |                                                                                                                                          |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}PartialParsingWithFallback                                                                         |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

When ParsingMode is set to **FullParsing**, the text in the Edit Control is parsed completely and accurately, and then features like syntax highlighting, outlining, bracket highlighting, indentation guidelines, and so on are applied. FullParsing is time consuming, and can potentially cause performance issues as Edit Control stays frozen till this process is completed. Ideally, it should be undertaken for small files only.

 

When ParsingMode is set to **PartialParsingNoFallback**, text parsing is done on a need basis, i.e., only those regions of the text in the Edit Control that have to be displayed get parsed. The text parsing is not always accurate in such scenarios, and hence features like syntax highlighting, outlining, bracket highlighting, indentation guidelines, and so on, maybe incorrectly applied. This is the fastest ParsingMode in the Edit Control, and hence should be used in large file handling scenarios.

 

When ParsingMode is set to **PartialParsingWithFallback**, text parsing is once again done on a need basis like in PartialParsingNoFallback mode. The only difference is that if the text gets incorrectly parsed, the incorrectly parsed text is treated as of type regular \"Text\" format, and features like syntax highlighting, outlining, bracket highlighting, indentation guidelines, and so on, get applied as per Text format specifications in the associated configuration settings.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                   |
|                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                             |
|                                                                                                                                                                                                                  |
| [// ParsingMode is set to FullParsing.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                        |
|                                                                                                                                                                                                                  |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.ParsingMode = Syncfusion.Windows.Forms.Edit.Enums.[TextParsingMode]{style="COLOR: teal"}.FullParsing;]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                     |
|                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                   |
|                                                                                                                                                                                        |
| [\' ParsingMode is set to FullParsing.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                              |
|                                                                                                                                                                                        |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.editControl1.ParsingMode = Syncfusion.Windows.Forms.Edit.Enums.TextParsingMode.FullParsing]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p91} 

[]{#related-topics}
:::::
