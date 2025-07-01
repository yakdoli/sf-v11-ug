::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=11e0007b-7856-4a78-8218-9b9d05cfeae2){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=c88d080c-ec5e-4858-8ed9-c1b8e9e3d418){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Find and Replace](ms-xhelp:///?Id=b4e6a0de-f2a4-41d4-8e20-2b69555a0cfb){.d2h_breadcrumbsNormal}
:::

### TextBodyPart {#textbodypart style="tab-stops: 0pt"}

 

**TextBodyPart** class contains the collection of body items (it means that TextBodyPart can contain paragraphs, tables and even sections). TextBodyPart is usually used with the Bookmark Navigator.

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image24_1.jpg){border="0"}Note:[ ]{style="COLOR: black; FONT-SIZE: 8pt"}TextBodyPart contains the copy of objects from the documents (paragraph(s), table(s), section(s), etc). So if you modify the content of the TextBodyPart, it does not affect the objects inside the document.
:::

 

[]{#DDE_LINK1}Public Constructors

 

::: {align="center"}
  ----------------------------------------------- -------------------------------------------------------
  Name                                            Description
  TextBodyPart.TextBodyPart ()                    Initializes a new instance of the TextBodyPart class.
  TextBodyPart.TextBodyPart (TextBodySelection)   Initializes a new instance of the TextBodyPart class.
  TextBodyPart.TextBodyPart (TextSelection)       Initializes a new instance of the TextBodyPart class.
  TextBodyPart.TextBodyPart (WordDocument)        Initializes a new instance of the TextBodyPart class.
  ----------------------------------------------- -------------------------------------------------------
:::

 

**Public Properties**

 

::: {align="center"}
  ----------- ------------------------
  Name        Description
  BodyItems   Gets the body items.  
  ----------- ------------------------
:::

 

**Public Methods**

 

::: {align="center"}
  ------------ ------------------------------------------------------------
  Name         Description
  Clear        Clears this instance.
  Copy         Copies the specified item.
  PasteAfter   Pastes ParagraphItem or TextBodyItem after specified item.
  PasteAt      Pastes ITextBody at specified position.
  PasteAtEnd   Pastes ITextBody at end of textbody.  
  ------------ ------------------------------------------------------------
:::

 

The following example illustrates how to use the TextBodyPart class.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                |
|                                                                                                                                                                                               |
| []{style="COLOR: black"}                                                                                                                                                                      |
|                                                                                                                                                                                               |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ doc = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: teal"}( \"sample.doc\" );]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                               |
| [      ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                  |
|                                                                                                                                                                                               |
| [BookmarksNavigator]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ bn = [new]{style="COLOR: blue"} [BookmarksNavigator]{style="COLOR: teal"}(doc);]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                               |
| [bn.MoveToBookmark([\"bookmark1\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                              |
|                                                                                                                                                                                               |
| [TextBodyPart]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ bodyPart = bn.GetBookmarkContent();]{style="FONT-FAMILY: 'Courier New'"}                                                     |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                         |
|                                                                                                                                                                                                                            |
| []{style="COLOR: black"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} WordDocument = [New]{style="COLOR: blue"} WordDocument([\"sample.doc\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ bn [As]{style="COLOR: blue"} BookmarksNavigator = [New]{style="COLOR: blue"} BookmarksNavigator(doc)]{style="FONT-FAMILY: 'Courier New'"}                          |
|                                                                                                                                                                                                                            |
| [bn.MoveToBookmark([\"bookmark1\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                                                            |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ bodyPart [As]{style="COLOR: blue"} TextBodyPart = bn.GetBookmarkContent()]{style="FONT-FAMILY: 'Courier New'"}                                                     |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
::::::::
