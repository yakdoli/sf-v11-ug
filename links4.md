::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Links {#links style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

A hyperlink, which is more commonly called a link, is an electronic connection between one web page and other web pages on the same web site, or web pages located on another web site. More specifically, a hyperlink is a connection between one page of a hypertext document to another.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

You can create hyperlinks in a PDF document by using the **PdfTextWebLink** class. The **DrawTextWebLink** method is used to draw hyperlinks in PDF pages.

 

The following code example illustrates how to draw hyperlinks.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                         |
|                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                   |
|                                                                                                                                                                                        |
| [// Create the Text Web Link]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                        |
|                                                                                                                                                                                        |
| [PdfTextWebLink]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ textLink = [new]{style="COLOR: blue"} [PdfTextWebLink]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                        |
| [textLink.Url = [\"http://www.google.com\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                               |
|                                                                                                                                                                                        |
| [textLink.Text = [\"Google Search\"]{style="COLOR: maroon"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
|                                                                                                                                                                                        |
| [textLink.Brush = brush;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                                        |
| [textLink.Font = font;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                            |
|                                                                                                                                                                                        |
| [textLink.Pen = [PdfPens]{style="COLOR: teal"}.Brown;]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                        |
| [textLink.DrawTextWebLink(page, [new]{style="COLOR: blue"} [PointF]{style="COLOR: teal"}(10, 40));]{style="FONT-FAMILY: 'Courier New'"}                                                |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                           |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                              |
| [\' Create the Text Web Link]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                              |
|                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ textLink [As]{style="COLOR: blue"} PdfTextWebLink = [New]{style="COLOR: blue"} PdfTextWebLink()]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                              |
| [textLink.Url = \"http://www.google.com\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                              |
| [textLink.Text = \"Google Search\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
|                                                                                                                                                                                              |
| [textLink.Brush = brush]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                              |
| [textLink.Font = font]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                              |
| [textLink.Pen = PdfPens.Brown]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                              |
| [textLink.DrawTextWebLink(page, [New]{style="COLOR: blue"} PointF(10, 40))]{style="FONT-FAMILY: 'Courier New'"}                                                                              |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
