::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=40fa4de2-c2cf-4de2-b478-32fe4a79387b){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=bfab51b5-a6ff-477f-b687-e232fed1351a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Conversion](ms-xhelp:///?Id=40fa4de2-c2cf-4de2-b478-32fe4a79387b){.d2h_breadcrumbsNormal}
:::

### [[     ]{style="COLOR: windowtext"}](ms-xhelp:///?Id=bfab51b5-a6ff-477f-b687-e232fed1351a)Doc to RTF {#doc-to-rtf style="tab-stops: 0pt"}

 

You can now open or create Word documents and save to the .RTF format, enabling RTF conversion by using DocIO.

 

The following example illustrates how to save a Word document to RTF format.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                 |
|                                                                                                                                                                                                |
| []{style="COLOR: black"}                                                                                                                                                                       |
|                                                                                                                                                                                                |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ doc = [new]{style="COLOR: blue"} WordDocument([\"sample.doc\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                |
| [doc.Save( [\"samplertf.rtf\"]{style="COLOR: maroon"}, [FormatType]{style="COLOR: teal"}.Rtf );]{style="FONT-FAMILY: 'Courier New'"}                                                           |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                          |
|                                                                                                                                                                                                             |
| []{style="COLOR: black"}                                                                                                                                                                                    |
|                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} WordDocument([\"sample.doc\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                             |
| [doc.Save( [\"samplertf.rtf\"]{style="COLOR: maroon"}, [FormatType]{style="COLOR: teal"}.Rtf )]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Document Elements

 

DocIO supports the following document elements.

 

[·      ]{style="FONT-FAMILY: Symbol"}Element Name

[·      ]{style="FONT-FAMILY: Symbol"}Main Document and Document Properties

[·      ]{style="FONT-FAMILY: Symbol"}Paragraph

[·      ]{style="FONT-FAMILY: Symbol"}Table

[·      ]{style="FONT-FAMILY: Symbol"}Picture

[·      ]{style="FONT-FAMILY: Symbol"}Header / Footer

[·      ]{style="FONT-FAMILY: Symbol"}Field (Simple)

[·      ]{style="FONT-FAMILY: Symbol"}TOC Field

[·      ]{style="FONT-FAMILY: Symbol"}Bookmark

[·      ]{style="FONT-FAMILY: Symbol"}Break (Line, Page)

[·      ]{style="FONT-FAMILY: Symbol"}Section Property

[·      ]{style="FONT-FAMILY: Symbol"}Paragraph Format

[·      ]{style="FONT-FAMILY: Symbol"}Table Format

[·      ]{style="FONT-FAMILY: Symbol"}Character Format

[·      ]{style="FONT-FAMILY: Symbol"}Text Box

[·      ]{style="FONT-FAMILY: Symbol"}Form Fields

[·      ]{style="FONT-FAMILY: Symbol"}Document Background

[·      ]{style="FONT-FAMILY: Symbol"}Watermark

[·      ]{style="FONT-FAMILY: Symbol"}Nested Table

[·      ]{style="FONT-FAMILY: Symbol"}Footnote / Endnote

[·      ]{style="FONT-FAMILY: Symbol"}Lists

[·      ]{style="FONT-FAMILY: Symbol"}Hyperlink

[·      ]{style="FONT-FAMILY: Symbol"}Symbols \[Not all symbols are supported\]

 

DocIO does not support the following document elements.

 

[·      ]{style="FONT-FAMILY: Symbol"}OLE Object

[·      ]{style="FONT-FAMILY: Symbol"}RTL

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image24_1.jpg){border="0"}[]{#_Doc_to_HTML} Note: Currently Doc to RTF conversion is not supported in Silverlight application.Doc to HTML
:::

[]{#related-topics}
:::::
