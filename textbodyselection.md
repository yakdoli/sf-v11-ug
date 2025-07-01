::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=14cfeba3-de3e-4180-bb9b-1b23016173ab){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=91545f50-e8ab-4b79-8ce1-139be19e5d2f){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Find and Replace](ms-xhelp:///?Id=b4e6a0de-f2a4-41d4-8e20-2b69555a0cfb){.d2h_breadcrumbsNormal}
:::

### TextBodySelection {#textbodyselection style="tab-stops: 0pt"}

 

**TextBodySelection** gives you an opportunity to select items in the TextBodyPart.

 

For example, you have the following text:

 

Text NEED [COPY]{style="COLOR: blue"}

  --- ---
       
       
  --- ---

 

THIS [TEXT]{style="COLOR: blue"} Other text

 

You may want to copy the \"NEED COPY\" table and \"THIS TEXT\", and paste in another location.

*[]{style="COLOR: red"}* 

Objects Tree is as follows.

 

TextBody

[·      ]{style="FONT-FAMILY: Symbol"}\[0\]Paragraph

[o  ]{style="FONT-FAMILY: 'Courier New'"}\[0\]TextRange -- \"Text\"

[o  ]{style="FONT-FAMILY: 'Courier New'"}\[1\]TextRange -- \"NEED\"

[o  ]{style="FONT-FAMILY: 'Courier New'"}\[2\]TextRange -- \"COPY\"

[·      ]{style="FONT-FAMILY: Symbol"}\[1\]Table

[·      ]{style="FONT-FAMILY: Symbol"}\[2\]Paragraph

[o  ]{style="FONT-FAMILY: 'Courier New'"}\[0\]TextRange -- \"THIS\"

[o  ]{style="FONT-FAMILY: 'Courier New'"}\[1\]TextRange -- \"TEXT\"

[o  ]{style="FONT-FAMILY: 'Courier New'"}\[2\]TextRange -- \"Other Text\"

 

The following code is used for this purpose.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                            |
| [TextBodySelection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ bodySelection = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[new]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ TextBodySelection( body, 0, 2, 1, 1 );]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

where, [ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}

0, 2, - paragraph starting index and ending index

1, - paragraph item starting index in first paragraph

1 - paragraph item ending index in last paragraph

 

**Public Constructors**

 

::: {align="center"}
  --------------------------------------------------------------------- ------------------------------------------------------------
  **Name**                                                              **Description**
  TextBodySelection.TextBodySelection (ITextBody, int, int, int, int)   Initializes a new instance of the TextBodySelection class.
  TextBodySelection.TextBodySelection (ParagraphItem, ParagraphItem)    Initializes a new instance of the TextBodySelection class.
  --------------------------------------------------------------------- ------------------------------------------------------------
:::

 

**Public Properties**

 

::: {align="center"}
  ------------------------- -------------------------------------------------------
  Name                      Description
  ItemEndIndex              Gets or sets the end index of the text body item.  
  ItemStartIndex            Gets or sets the start index of the text body item.  
  ParagraphItemEndIndex     Gets or sets the end index of the paragraph item.  
  ParagraphItemStartIndex   Gets or sets the start index of the paragraph item.  
  TextBody                  Gets the text body.  
  ------------------------- -------------------------------------------------------
:::

 

**Copy** and **Paste** methods of **TextBodyPart** of the **TextBodySelection** class are used to copy and paste the text and body element at any position in the document. The following code snippet illustrates this.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                         |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [// Create TextBodySelection and select the items of interest.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                        |
|                                                                                                                                                                                                                                          |
| [TextBodySelection]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ textSel = [new]{style="COLOR: blue"} [TextBodySelection]{style="COLOR: teal"}(sec.Body, 0, lastItemIndex, 0, lastPItemIndex);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                          |
| [        ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                          |
| [// Create TextBodyPart and copy the selected items.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                  |
|                                                                                                                                                                                                                                          |
| [TextBodyPart]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ replacePart = [new]{style="COLOR: blue"} [TextBodyPart]{style="COLOR: teal"}(doc);]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                                          |
| [replacePart.Copy(textSel);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                          |
| [// Paste the copied content at the end of the text body.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                             |
|                                                                                                                                                                                                                                          |
| [replacePart.PasteAt(txtbdy,itemIndex);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                |
| [\' Create TextBodySelection and select the items of interest.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                              |
|                                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ textSel [As]{style="COLOR: blue"} TextBodySelection = [New]{style="COLOR: blue"} TextBodySelection(sec.Body, 0, lastItemIndex, 0, lastPItemIndex)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                |
| [\' Create TextBodyPart and copy the selected items.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                        |
|                                                                                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ replacePart [As]{style="COLOR: blue"} TextBodyPart = [New]{style="COLOR: blue"} TextBodyPart(doc)]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                                                |
| [replacePart.Copy(textSel)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                |
| [\' Paste the copied text at the end of the text body.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                      |
|                                                                                                                                                                                                                                                |
| [replacePart.PasteAt(txtbdy,itemIndex)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                    |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
::::::
