::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=b4e6a0de-f2a4-41d4-8e20-2b69555a0cfb){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=14cfeba3-de3e-4180-bb9b-1b23016173ab){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Find and Replace](ms-xhelp:///?Id=b4e6a0de-f2a4-41d4-8e20-2b69555a0cfb){.d2h_breadcrumbsNormal}
:::

### TextSelection {#textselection style="tab-stops: 0pt"}

 

**TextSelection** represents selected text in the Word document with the following limitations.

 

[·      ]{style="FONT-FAMILY: Symbol"}Selected Text must be complete (text selection does not represent split selections).

[·      ]{style="FONT-FAMILY: Symbol"}Selected Text must be a single paragraph (text selection inside two or more paragraphs is ignored).

 

TextSelection uses the **Find** and **FindAll** methods to select text. For details, see [Find]{style="COLOR: black"}.

 

**Public Constructors**

 

::: {align="center"}
  --------------------------------------------------- --------------------------------------------------------
  Name                                                Description
  TextSelection.TextSelection(WParagraph, int, int)   Initializes a new instance of the TextSelection class.
  --------------------------------------------------- --------------------------------------------------------
:::

 

Public Properties

 

::: {align="center"}
  -------------- ----------------------------------
  Name           Description
  Count          Gets the count of text chunks.  
  SelectedText   Gets the selected text.  
  -------------- ----------------------------------
:::

 

Public Methods

 

::: {align="center"}
  --------------- -----------------------------------------------------------
  Name            Description
  GetAsOneRange   Gets as one range.  
  GetEnumerator   Returns an enumerator that iterates through a collection.
  GetRanges       Gets the ranges.
  this\[int\]     Gets the System.String at the specified index.  
  --------------- -----------------------------------------------------------
:::

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image24_1.jpg){border="0"}Note: TextSelection and GetAsOneRange should not be used for text replacement.
:::

 

The following example illustrates how to use the TextSelection class.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                      |
| []{style="COLOR: black"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                      |
| [docTemplate.Open( FINDTEMPLATE );]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                                                      |
| [TextSelection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ rangesHolder1 = docSource1.Find( [\"The PlaceHolder1\"]{style="COLOR: maroon"}, [false]{style="COLOR: blue"}, [false]{style="COLOR: blue"} );]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                 |
| []{style="COLOR: black"}                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                 |
| [docTemplate.Open(FINDTEMPLATE)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ rangesHolder1 [As]{style="COLOR: blue"} TextSelection = docSource1.Find([\"The PlaceHolder1\"]{style="COLOR: maroon"}, [False]{style="COLOR: blue"}, [False]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
::::::::
