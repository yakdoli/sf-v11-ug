::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=39b8b7d5-49f4-4f25-99cc-5f73502e23e4){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=0d329b33-6836-4156-8525-0a27036606c3){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Reporting Edition](ms-xhelp:///?Id=027aa5b6-6676-4f93-ad23-c20e8c45792e){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential DocIO](ms-xhelp:///?Id=b88d77b3-4c51-460f-a761-d2ef6d5b0ca6){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=c1881696-52ce-4414-9f3d-97433d8e9775){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Conversion](ms-xhelp:///?Id=40fa4de2-c2cf-4de2-b478-32fe4a79387b){.d2h_breadcrumbsNormal}
:::

### Doc to HTML {#doc-to-html style="tab-stops: 0pt"}

You can now open or create Word documents and save to the HTML format, enabling HTML conversion by using DocIO.

 

The following example illustrates how to save a Word document to HTML format.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                             |
|                                                                                                                                                                                                            |
| []{style="COLOR: black"}                                                                                                                                                                                   |
|                                                                                                                                                                                                            |
| [WordDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ doc = [new]{style="COLOR: blue"} WordDocument([@\"..\\..\\DocToHTML.doc\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                            |
| [HTMLExport htmlExport = [new]{style="COLOR: blue"} HTMLExport();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                            |
| [htmlExport.SaveAsXhtml(doc,  [\"doctohtml_res.html\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                     |
|                                                                                                                                                                                                                        |
| []{style="COLOR: black"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ doc [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} WordDocument([\"..\\..\\DocToHTML.doc\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ htmlExport [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} HTMLExport()]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                                                        |
| [htmlExport.SaveAsXhtml(doc, [\"doctohtml_res.html\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Document Elements

 

DocIO supports the following document elements.

[]{style="FONT-FAMILY: 'Courier New'"} 

::: {align="center"}
  ------------------------ ------------------------------ ----------- ---------------------------------------------------------------------
  Document Element         Attribute                      Supported   Notes
  Bookmark                 Position                       Yes         \-
  Border                   Color                          Yes         \-
  Border                   Distance from text             Yes         \-
  Border                   Line style                     Partial     Some line styles are rendered as solid.
  Border                   Line width                     Yes         \-
  Document Properties                                     Yes         \-
  Drawing objects          Shapes                         Partial     Images and horizontal rules are exported.
  Drawing objects          Text                           Partial     Text from text boxes and other shapes is rendered in the main text.
  Drawing objects          Images                         \-          \-
  Field                                                   Yes         Current field result is output, but the result is not recalculated.
  Footnotes and Endnotes                                  Yes         \-
  Form Field               Text input                     Yes         \-
  Header / Footer          Different per section          Partial     Only primary header is output at the beginning of a section.
  Hyperlink                External URL                   Yes         \-
  Hyperlink                Local                          Yes         \-
  Image                    Cropping                       Yes         \-
  Image                    Inline                         Yes         \-
  Image                    Scale                          Yes         \-
  List                     Custom bullets                 Yes         \-
  List                     Multi-level                    Yes         \-
  List                     Numbered                       Yes         \-
  List                     Restart numbering              Yes         \-
  List                     Standard bullets               Yes         \-
  Paragraph                Alignment                      Yes         \-
  Paragraph                Borders                        Yes         See Borders, for more details.
  Paragraph                First line indent or hanging   Yes         \-
  Paragraph                Keep together                  Yes         \-
  Paragraph                Keep with next                 Yes         \-
  Paragraph                Left and right indent          Yes         \-
  Paragraph                Line spacing                   Partial     All line spacing is output as atleast line spacing.
  Paragraph                Line spacing                   Yes         \-
  Paragraph                Page break before              Yes         \-
  Paragraph                Shading                        Yes         See Shading, for more details.
  Paragraph                Spacing before and after       Yes         \-
  Paragraph                Window control                 Yes         Output as both windows and orphans.
  Shading                  Background color               Partial     Solid background colors are supported.
  Shading                  Foreground color               Partial     Solid foreground color is used when background color is auto.
  Styles                   Paragraph styles               Yes         \-
  Styles                   Character styles               Yes         \-
  Styles                   List styles                    Partial     Not all formatting has effect. Considered in only inline styles.
  Table                    Alignment                      Yes         \-
  Table                    Cell margins                   Yes         \-
  Table                    Column widths                  Yes         \-
  Table                    Indent from left               Yes         \-
  Table                    Preferred width                Yes         \-
  Table                    Spacing between cells          Yes         \-
  Table Cell               Borders                        Partial     See Borders, for more details.
  Table Cell               Cell margins                   Partial     Only default table cell margins left and right are supported.
  Table Cell               Horizontal merge               Yes         \-
  Table Cell               Shading                        Partial     See Shading, for more details.
  Table Cell               Text direction                 Yes         \-
  Table Cell               Vertical alignment             Yes         \-
  Table Cell               Vertical merge                 Yes         \-
  Table Row                Height                         Yes         \-
  Table Row                Padding                        Yes         \-
  Text                     All caps                       Yes         \-
  Text                     Bold                           Yes         \-
  Text                     Character spacing              Yes         \-
  Text                     Color                          Yes         \-
  Text                     Emboss                         Partial     Rendered as bold.
  Text                     Engrave                        Partial     Rendered as bold.
  Text                     Font                           Yes         \-
  Text                     Hidden                         Yes         \-
  Text                     Highlighting                   Yes         \-
  Text                     Imprint                        Partial     Rendered as bold.
  Text                     Italic                         Yes         \-
  Text                     Line breaks                    Yes         \-
  Text                     Outline                        Partial     Rendered as bold.
  Text                     Page breaks                    Yes         \-
  Text                     Shading                        Partial     See Shading, for more details.
  Text                     Small caps                     Yes         \-
  Text                     Special symbols                Yes         \-
  Text                     Strike out                     Yes         \-
  Text                     Subscript / Superscript        Yes         \-
  Text                     Underline                      Partial     Underline types and colors are ignored.
  ------------------------ ------------------------------ ----------- ---------------------------------------------------------------------
:::

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
[]{#_Doc_to_PDF} 

![](ImagesExt/image24_1.jpg){border="0"}Notes: Currently Doc to Html conversion is not supported in Silverlight application.

 
:::

[]{#related-topics}
::::::
