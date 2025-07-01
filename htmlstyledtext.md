::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Html Styled Text {#html-styled-text style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Essential PDF provides support to render the HTML string in a PDF document, which can flow to multiple pages by using the **PdfHTMLTextElement** class. The PdfHTMLTextElement class contains methods, which are used to render the specified HTML string in the PDF document. It draws the specified text string at the specified location with the specified size, brush and font. You can also align the text by using the **TextAlign** property.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The **PdfMetafileLayoutFormat** class enables to break the HTML text into multiple pages.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Supported Tags (Should be XHTML-compliant)

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Font

[·      ]{style="FONT-FAMILY: Symbol"}B

[·      ]{style="FONT-FAMILY: Symbol"}I

[·      ]{style="FONT-FAMILY: Symbol"}U

[·      ]{style="FONT-FAMILY: Symbol"}St

[·      ]{style="FONT-FAMILY: Symbol"}sub

[·      ]{style="FONT-FAMILY: Symbol"}sup

[·      ]{style="FONT-FAMILY: Symbol"}BR

 

The following code example illustrates how to render the HTML string in a PDF document.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                              |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                        |
|                                                                                                                                                                                                                             |
| [// HtmlString]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                           |
|                                                                                                                                                                                                                             |
| [string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ longText = [\"\<font color=\'#0000F8\'\>Essential PDF\</font\> is a \<u\>\<i\>.NET\</i\>\</u\> \"]{style="COLOR: maroon"} +]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                             |
| [\"library with the capability to produce Adobe PDF files \"]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[;]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                        |
|                                                                                                                                                                                                                             |
| [// Rendering HtmlText]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [PdfHTMLTextElement]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ richTextElement = [new]{style="COLOR: blue"} [PdfHTMLTextElement]{style="COLOR: teal"}(longText, font, brush);]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                                             |
| [richTextElement.TextAlign = [TextAlign]{style="COLOR: teal"}.Justify;            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                        |
|                                                                                                                                                                                                                             |
| [// Formatting Layout]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                    |
|                                                                                                                                                                                                                             |
| [PdfMetafileLayoutFormat]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ format = [new]{style="COLOR: blue"} [PdfMetafileLayoutFormat]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                                             |
| [format.Layout = [PdfLayoutType]{style="COLOR: teal"}.OnePage;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                         |
|                                                                                                                                                                                                                             |
| [format.Break = [PdfLayoutBreakType]{style="COLOR: teal"}.FitPage;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                     |
|                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                        |
|                                                                                                                                                                                                                             |
| [// Drawing htmlString]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                   |
|                                                                                                                                                                                                                             |
| [richTextElement.Draw(page, [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: teal"}(30, 30, 600, page.GetClientSize().Height), format);]{style="FONT-FAMILY: 'Courier New'"}                                           |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black; FONT-SIZE: 8pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                  |
| [\' HtmlString]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ longText [As]{style="COLOR: blue"} [String]{style="COLOR: blue"} = [\"\<font color=\'#0000F8\'\>Essential PDF\</font\> is a \<u\>\<i\>.NET\</i\>\</u\> \"]{style="COLOR: maroon"} +]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                  |
| [\"library with the capability to produce Adobe PDF files \"]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                  |
| [\' Rendering HtmlText]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ richTextElement [As]{style="COLOR: blue"} PdfHTMLTextElement = [New]{style="COLOR: blue"} PdfHTMLTextElement(longText, font, brush)]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                                                                                  |
| [richTextElement.TextAlign = TextAlign.Justify]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                  |
| [\' Formatting Layout]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ format [As]{style="COLOR: blue"} PdfMetafileLayoutFormat = [New]{style="COLOR: blue"} PdfMetafileLayoutFormat()]{style="FONT-FAMILY: 'Courier New'"}                                                                     |
|                                                                                                                                                                                                                                                                                  |
| [format.Layout = PdfLayoutType.OnePage]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                  |
| [format.Break = PdfLayoutBreakType.FitPage]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                  |
| [\' Drawing htmlString]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                  |
| [richTextElement.Draw(page, [New]{style="COLOR: blue"} RectangleF(30, 30, 600, page.GetClientSize().Height), format)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
