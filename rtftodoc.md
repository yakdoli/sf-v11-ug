::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=0d329b33-6836-4156-8525-0a27036606c3){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=41178bf6-e8e5-4eaf-a650-b7c95f241600){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Conversion](ms-xhelp:///?Id=40fa4de2-c2cf-4de2-b478-32fe4a79387b){.d2h_breadcrumbsNormal}
:::

### RTF to Doc {#rtf-to-doc style="tab-stops: 0pt"}

 

Essential DocIO allows to import the RTF document directly into the word document.  

 

The following code illustrates how RTF file can be opened and saved as a word document.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                       |
| [//Opening the RTF file]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                       |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ doc = [new]{style="COLOR: blue"} [WordDocument]{style="COLOR: #2b91af"}([\"Sample.rtf\"]{style="COLOR: #a31515"}, [FormatType]{style="COLOR: #2b91af"}.Rtf);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                       |
| [//Saving the RTF file as a word document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                       |
| [doc.Save ([\"RtfToDoc_Res.doc\"]{style="COLOR: #a31515"},[FormatType]{style="COLOR: #2b91af"}.Doc);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                       |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 8pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                        |
| [\'Opening the RTF file]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} [New ]{style="COLOR: blue"}WordDocument([\"Sample.rtf\"]{style="COLOR: #a31515"}, [FormatType]{style="COLOR: #2b91af"}.Rtf)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                        |
| [\'Saving the RTF file as a word document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                           |
|                                                                                                                                                                                                                                                        |
| [doc.Save([\"RtfToDoc_Res.doc\"]{style="COLOR: #a31515"}, FormatType.Doc);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Supported Elements

[ ]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 8pt"}This feature provides support for the following elements:

 

[·      ]{style="FONT-FAMILY: Symbol"}Paragraph and Character Formatting

[·      ]{style="FONT-FAMILY: Symbol"}Tables

[·      ]{style="FONT-FAMILY: Symbol"}Bookmarks

[·      ]{style="FONT-FAMILY: Symbol"}Headers and Footers

[·      ]{style="FONT-FAMILY: Symbol"}Images

[·      ]{style="FONT-FAMILY: Symbol"}List

[·      ]{style="FONT-FAMILY: Symbol"}Page setting

[·      ]{style="FONT-FAMILY: Symbol"}Multi column text

[·      ]{style="FONT-FAMILY: Symbol"}Breaks

[·      ]{style="FONT-FAMILY: Symbol"}Document properties

[·      ]{style="FONT-FAMILY: Symbol"}Fields

 

Fields

This feature supports the preservation of fields in Rtf to Doc conversion.[]{style="COLOR: #c00000"}

 

Paragraph and Character Formatting

This feature supports almost all the paragraph and character formatting. The supported formatting features are:[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 8pt"}

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 8pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Paragraph borders

[·      ]{style="FONT-FAMILY: Symbol"}Indentation and Pagination

[·      ]{style="FONT-FAMILY: Symbol"}Spacing and Tabs

[·      ]{style="FONT-FAMILY: Symbol"}Left, Right and Center justification

[·      ]{style="FONT-FAMILY: Symbol"}Font styles(Bold, Italic, Underline, Strike through)

[·      ]{style="FONT-FAMILY: Symbol"}Font sizeand font name for the character

[·      ]{style="FONT-FAMILY: Symbol"}Text highlighting and Text color    

 

+-----------------------------------------------------------------------+
| *[Known Limitation:]{style="FONT-SIZE: 8pt"}*                         |
|                                                                       |
| [·      ]{style="FONT-FAMILY: Symbol"}Subscript and Superscript       |
|                                                                       |
| [·      ]{style="FONT-FAMILY: Symbol"}Revision tracking               |
|                                                                       |
|                                                                       |
+-----------------------------------------------------------------------+

*[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 8pt"}* 

 

Tables

This feature supports both simple and the nested tables. This feature also provides support for Text formatting, Paragraph formatting and  images inside the tables

 

+-----------------------------------------------------------------------------------------------------+
| *[Known Limitation]{style="FONT-SIZE: 8pt"}*                                                        |
|                                                                                                     |
| [·      ]{style="FONT-FAMILY: Symbol"}Tables styles and 3D border for the tables are not supported. |
+-----------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 8pt"} 

Bookmarks

This feature fully supports  the bookmark present in the document.

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 8pt"} 

Headers and Footers

This feature supports page headers and footers.  The Page header and footer can contain paragraphs, tables and images.

 

Images

This feature support images present in the RTF document along with their position and size.

 

+------------------------------------------------------------------------------------------+
| *[Known Limitation:]{style="FONT-SIZE: 8pt"}*                                            |
|                                                                                          |
| [·      ]{style="FONT-FAMILY: Symbol"}Image Present inside the shapes are not supported. |
|                                                                                          |
|                                                                                          |
+------------------------------------------------------------------------------------------+

 

List

This feature support bullets, numbered and multi level bulleted list along with their alignment and indentation.

 

+-----------------------------------------------------------------------+
| *[Known limitaion:]{style="FONT-SIZE: 8pt"}*                          |
|                                                                       |
| [·      ]{style="FONT-FAMILY: Symbol"}Image bullets are not supported |
|                                                                       |
|                                                                       |
+-----------------------------------------------------------------------+

 

Page Settings

This feature support page settings such as Margin, Orientation, Paper size,Header distance and Footer distance.

 

+------------------------------------------------------------------------------------------------------------+
| *[Known Limitation:]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 8pt"}*                      |
|                                                                                                            |
| [·      ]{style="FONT-FAMILY: Symbol"}Background image and background color for the page is not supported. |
|                                                                                                            |
|                                                                                                            |
+------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 8pt"} 

Multi Column text

This feature fully supports multi column text within theRTF document.[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 8pt"}

 

Breaks

This feature supports breaks such as column break, section break, line break and page break.

 

Document properties

This feature supports  document properties present in the RTF document.

**[]{style="FONT-SIZE: 14pt"}** 

Unsupported elements

The following are the unsupported elements which will be supported in our future release:

[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 8pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Shapes and Auto Shapes

[·      ]{style="FONT-FAMILY: Symbol"}Footnotes and End notes

[·      ]{style="FONT-FAMILY: Symbol"}Comments

[·      ]{style="FONT-FAMILY: Symbol"}Table of contents

[·      ]{style="FONT-FAMILY: Symbol"}Hyperlinks

[·      ]{style="FONT-FAMILY: Symbol"}Table styles

[·      ]{style="FONT-FAMILY: Symbol"}OLE objects

[·      ]{style="FONT-FAMILY: Symbol"}Document protection

[·      ]{style="FONT-FAMILY: Symbol"}RTL support

[·      ]{style="FONT-FAMILY: Symbol"}Water marks

[·      ]{style="FONT-FAMILY: Symbol"}Symbols

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

![](ImagesExt/image24_1.jpg){border="0"}Notes: Currently RTF to Doc conversion is not supported in Silverlight application.

 
:::

[]{#related-topics}
:::::
