::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Tagged PDF {#tagged-pdf style="tab-stops: 0pt"}

HTML to PDF conversion handled using MSHTML rendering library can now generate tagged PDF documents.

Tagged PDF is a stylized use of PDF that builds on the logical structure framework. It defines a set of standard structure types and attributes that allow page content (text, graphics, and images) to be extracted and reused. The contents are accessible to users with visual impairments.

HTML documents can be converted to tagged PDFs using the **ConvertToTaggedPDF** method. It returns **PdfLayoutResult** which provides the end rectangle bounds and PDF page after the conversion.

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                  |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [PdfLayoutResult]{style="COLOR: #2b91af"} ConvertToTaggedPDF([PdfDocument]{style="COLOR: #2b91af"} document, [string]{style="COLOR: blue"} url);]{style="FONT-FAMILY: 'Courier New'"}                                                                                 |
|                                                                                                                                                                                                                                                                                                                                  |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [PdfLayoutResult]{style="COLOR: #2b91af"} ConvertToTaggedPDF([PdfDocument]{style="COLOR: #2b91af"} document, [string]{style="COLOR: blue"} url, [string]{style="COLOR: blue"} userName, [string]{style="COLOR: blue"} password);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                  |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [PdfLayoutResult]{style="COLOR: #2b91af"} ConvertToTaggedPDF([PdfDocument]{style="COLOR: #2b91af"} document, [string]{style="COLOR: blue"} html, [string]{style="COLOR: blue"} baseURL);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-SIZE: 11pt"}              |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                                                                                                                |
|                                                                                                                                                                                                                                                                                   |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PdfLayoutResult ConvertToTaggedPDF(PdfDocument document, [String]{style="COLOR: blue"} url)]{style="FONT-FAMILY: 'Courier New'"}                                                                                       |
|                                                                                                                                                                                                                                                                                   |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PdfLayoutResult ConvertToTaggedPDF(PdfDocument document, [String]{style="COLOR: blue"} url, [String]{style="COLOR: blue"} userName, [String]{style="COLOR: blue"} password)]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                                                                                                                   |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ PdfLayoutResult ConvertToTaggedPDF(PdfDocument document, [String]{style="COLOR: blue"} html, [String]{style="COLOR: blue"} baseURL)]{style="FONT-FAMILY: 'Courier New'"}[]{style="LINE-HEIGHT: 115%; FONT-SIZE: 11pt"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

A tagged PDF can be converted from a Web page or HTML string by using the following code snippet:

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**                                                       |
|                                                                                                                                                                                                                      |
| [// Create a new PdfDocument.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                     |
|                                                                                                                                                                                                                      |
| [PdfDocument]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ document = [new]{style="COLOR: blue"} [PdfDocument]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                                                                                                                      |
| [PdfLayoutResult]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ result = [null]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                    |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [// Create a new instance of HtmlConverter class.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                 |
|                                                                                                                                                                                                                      |
| [using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([HtmlConverter]{style="COLOR: #2b91af"} html = [new]{style="COLOR: blue"} [HtmlConverter]{style="COLOR: #2b91af"}())]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                      |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                      |
| [    [// Turn on or off various options.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                                      |
| [    html.EnableJavaScript = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                                      |
| [    html.EnableActiveXContents = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                                      |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [    [// Convert to Tagged PDF.]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                                                      |
| [    result = html.ConvertToTaggedPDF(document, url);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                      |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                              |
|                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                      |
| [// Save and close the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                  |
|                                                                                                                                                                                                                      |
| [document.Save([@\"Sample.pdf\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                                                      |
| [document.Close([true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"}[]{style="LINE-HEIGHT: 115%; FONT-SIZE: 11pt"}                                                                                     |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Courier New'; FONT-SIZE: 11pt"}**             |
|                                                                                                                                                                                |
| [\' Create a new PdfDocument.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                         |
|                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ document [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfDocument()]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ result [As]{style="COLOR: blue"} PdfLayoutResult = [Nothing]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [\' Create a new instance of HtmlConverter class.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                     |
|                                                                                                                                                                                |
| [Using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ html [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} HtmlConverter()]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                |
| [      \' Turn on or off various options.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                                |
| [      html.EnableJavaScript = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                |
|                                                                                                                                                                                |
| [      html.EnableActiveXContents = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [      \' Convert to Tagged PDF.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                |
| [      result = html.ConvertToTaggedPDF(document, url)]{style="FONT-FAMILY: 'Courier New'"}                                                                                    |
|                                                                                                                                                                                |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Using]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
|                                                                                                                                                                                |
| [\' Save and close the document.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                |
| [document.Save([\"Sample.pdf\"]{style="COLOR: darkred"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                  |
|                                                                                                                                                                                |
| [document.Close([True]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"}[]{style="LINE-HEIGHT: 115%; FONT-SIZE: 11pt"}                                                |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="LINE-HEIGHT: 115%; FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

![](ImagesExt/image22_2.jpg){border="0"}***Note: The HTML to PDF conversion, which creates a metafile during the evolution, would interpret the content as either text or an image. The outcome of this PDF would contain only paragraph and figure tags; hyperlinks are not supported.***

 

[]{#related-topics}
:::
