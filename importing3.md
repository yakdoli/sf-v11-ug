::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Importing {#importing style="tab-stops: 0pt"}

 

The integrated HTML to PDF Converter is implemented by using the **HtmlConverter** class. It basically includes the functionality of the HTML to PDF Converter product, and additionally offers the possibility to specify the position and the size of the PDF content.

 

The following code example illustrates this.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                       |
|                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                   |
|                                                                                                                                                                                                        |
| [// Convert web page into image.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                    |
|                                                                                                                                                                                                        |
| [HtmlConverter html = [new]{style="COLOR: blue"} HtmlConverter();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                                                        |
| [Image]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ img= html.ConvertToImage([\"www.syncfusion.com\"]{style="COLOR: maroon"}, ImageType.Metafile, 1024)]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                        |
| [// Draw the image into the PDF document as metafile]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                |
|                                                                                                                                                                                                        |
| [// Create metafile image]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                           |
|                                                                                                                                                                                                        |
| [PdfMetafile]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ metafile = ([PdfMetafile]{style="COLOR: teal"})[PdfImage]{style="COLOR: teal"}.FromImage(img);]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                        |
| [// Specify the quality of the metafile]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                             |
|                                                                                                                                                                                                        |
| [metafile.Quality = 100;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                        |
| [// Set the layout format]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                           |
|                                                                                                                                                                                                        |
| [PdfMetafileLayoutFormat]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ format = [new]{style="COLOR: blue"} [PdfMetafileLayoutFormat]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                        |
| [format.Break = [PdfLayoutBreakType]{style="COLOR: teal"}.FitPage;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                        |
| [format.Layout = [PdfLayoutType]{style="COLOR: teal"}.Paginate;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                        |
| [// Prevent text getting break at the page breaks]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                   |
|                                                                                                                                                                                                        |
| [format.SplitTextLines = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                            |
|                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                        |
| [// Draw the converted image to PDF]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                 |
|                                                                                                                                                                                                        |
| [metafile.Draw(page, [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: teal"}(0, 0, img.Width, img.Height), format);]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                        |
| [// Draw the image into the PDF document as bitmap]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                  |
|                                                                                                                                                                                                        |
| [PdfImage]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ image = [new]{style="COLOR: blue"} [PdfBitmap]{style="COLOR: teal"}(img);]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                        |
| [PdfLayoutFormat]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ format = [new]{style="COLOR: blue"} [PdfLayoutFormat]{style="COLOR: teal"}();]{style="FONT-FAMILY: 'Courier New'"}                 |
|                                                                                                                                                                                                        |
| [format.Break = [PdfLayoutBreakType]{style="COLOR: teal"}.FitPage;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                        |
| [format.Layout = [PdfLayoutType]{style="COLOR: teal"}.Paginate;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                        |
| [image.Draw(page, [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: teal"}(0, 0, pageSize.Width, pageSize.Height), format);]{style="FONT-FAMILY: 'Courier New'"}                                   |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                              |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                   |
| [\' Convert web page into image.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                               |
|                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ html [As]{style="COLOR: blue"} HtmlConverter = [New]{style="COLOR: blue"} HtmlConverter()]{style="FONT-FAMILY: 'Courier New'"}                                            |
|                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ img [As]{style="COLOR: blue"} Image = html.ConvertToImage([\"www.syncfusion.com\"]{style="COLOR: maroon"}, ImageType.Metafile, 1024)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                   |
| [\' Draw the image into the PDF document as metafile]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                           |
|                                                                                                                                                                                                                                   |
| [\' Create metafile image]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                      |
|                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ metafile [As]{style="COLOR: blue"} PdfMetafile = [CType]{style="COLOR: blue"}(PdfImage.FromImage(img), PdfMetafile)]{style="FONT-FAMILY: 'Courier New'"}                  |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                   |
| [\' Specify the quality of the metafile]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                        |
|                                                                                                                                                                                                                                   |
| [metafile.Quality = 100]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                   |
| [\' Set the layout format]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                      |
|                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ format [As]{style="COLOR: blue"} PdfMetafileLayoutFormat = [New]{style="COLOR: blue"} PdfMetafileLayoutFormat()]{style="FONT-FAMILY: 'Courier New'"}                      |
|                                                                                                                                                                                                                                   |
| [format.Break = PdfLayoutBreakType.FitPage]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                                   |
| [format.Layout = PdfLayoutType.Paginate]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                   |
| [\' Prevent text getting break at the page breaks]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                              |
|                                                                                                                                                                                                                                   |
| [format.SplitTextLines = [False]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                        |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                   |
| [\' Draw the converted image to PDF]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                            |
|                                                                                                                                                                                                                                   |
| [metafile.Draw(page, [New]{style="COLOR: blue"} RectangleF(0, 0, img.Width, img.Height), format)]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                   |
| [\' Draw the image into the PDF document as bitmap]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                             |
|                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ image [As]{style="COLOR: blue"} PdfImage = [New]{style="COLOR: blue"} PdfBitmap(img)]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ format [As]{style="COLOR: blue"} PdfLayoutFormat = [New]{style="COLOR: blue"} PdfLayoutFormat()]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                                                                   |
| [format.Break = PdfLayoutBreakType.FitPage]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                   |
|                                                                                                                                                                                                                                   |
| [format.Layout = PdfLayoutType.Paginate]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                                                                   |
| [image.Draw(page, [New]{style="COLOR: blue"} RectangleF(0, 0, pageSize.Width, pageSize.Height), format)]{style="FONT-FAMILY: 'Courier New'"}                                                                                      |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
