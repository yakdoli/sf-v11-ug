::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Creating and Embedding PDF Layers in the PDF Document {#creating-and-embedding-pdf-layers-in-the-pdf-document style="tab-stops: 0pt"}

To create PDF Layers, optional content should be implemented. The following code snippets explain the creation of optional content and the embedding of layers in a PDF document.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [C#]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                         |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                           |
|                                                                                                                                                                                                                |
| [//Add the layer]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                            |
|                                                                                                                                                                                                                |
| [PdfPageLayer]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ layer = page.Layers.Add([\"Layer1\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                        |
|                                                                                                                                                                                                                |
| [PdfGraphics]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ graphics = layer.Graphics;]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                |
| [graphics.TranslateTransform(100, 60);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                    |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [//Draw Arc ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                |
|                                                                                                                                                                                                                |
| [PdfPen]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ pen = [new]{style="COLOR: blue"} [PdfPen]{style="COLOR: #2b91af"}([Color]{style="COLOR: #2b91af"}.Red, 50);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                |
| [RectangleF]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ rect = [new]{style="COLOR: blue"} [RectangleF]{style="COLOR: #2b91af"}(0, 0, 50, 50);]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                                |
| [graphics.DrawArc(pen, rect, 360, 360);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [pen = [new]{style="COLOR: blue"} [PdfPen]{style="COLOR: #2b91af"}([Color]{style="COLOR: #2b91af"}.Blue, 30);]{style="FONT-FAMILY: 'Courier New'"}                                                             |
|                                                                                                                                                                                                                |
| [graphics.DrawArc(pen, 0, 0, 50, 50, 360, 360);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [pen = [new]{style="COLOR: blue"} [PdfPen]{style="COLOR: #2b91af"}([Color]{style="COLOR: #2b91af"}.Yellow, 20);]{style="FONT-FAMILY: 'Courier New'"}                                                           |
|                                                                                                                                                                                                                |
| [graphics.DrawArc(pen, rect, 360, 360);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [pen = [new]{style="COLOR: blue"} [PdfPen]{style="COLOR: #2b91af"}([Color]{style="COLOR: #2b91af"}.Green, 10);]{style="FONT-FAMILY: 'Courier New'"}                                                            |
|                                                                                                                                                                                                                |
| [graphics.DrawArc(pen, 0, 0, 50, 50, 360, 360);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                           |
|                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                         |
|                                                                                                                                                                                                                |
| [            ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                             |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [VB  ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                          |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                              |
|                                                                                                                                                                                                   |
| [\'Add the layer]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ layer [As]{style="COLOR: blue"} PdfPageLayer = page.Layers.Add([\"Layer1\"]{style="COLOR: darkred"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ graphics [As]{style="COLOR: blue"} PdfGraphics = layer.Graphics]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                                                                                                   |
| [graphics.TranslateTransform(100, 60)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                   |
| [\'Draw Arc ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                             |
|                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ pen [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} PdfPen(Color.Red, 50)]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ rect [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} RectangleF(0, 0, 50, 50)]{style="FONT-FAMILY: 'Courier New'"}                   |
|                                                                                                                                                                                                   |
| [graphics.DrawArc(pen, rect, 360, 360)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                   |
| [pen = [New]{style="COLOR: blue"} PdfPen(Color.Blue, 30)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                     |
|                                                                                                                                                                                                   |
| [graphics.DrawArc(pen, 0, 0, 50, 50, 360, 360)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                               |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                   |
| [pen = [New]{style="COLOR: blue"} PdfPen(Color.Yellow, 20)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                   |
| [graphics.DrawArc(pen, rect, 360, 360)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                            |
|                                                                                                                                                                                                   |
| [pen = [New]{style="COLOR: blue"} PdfPen(Color.Green, 10)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                                   |
| [graphics.DrawArc(pen, 0, 0, 50, 50, 360, 360)[  ]{style="COLOR: green"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                     |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::
