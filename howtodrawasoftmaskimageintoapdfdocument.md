::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How To Draw a SoftMask Image Into a PDF Document? {#how-to-draw-a-softmask-image-into-a-pdf-document style="tab-stops: 0pt"}

 

Essential PDF supports drawing mask images over other images. The **Mask** property of the **PdfBitmap** class is used for drawing masked images.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                        |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                        |
| [// Bitmap with Tiff image mask.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                    |
|                                                                                                                                                                                                                                                        |
| [PdfBitmap]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ image = [new]{style="COLOR: blue"} [PdfBitmap]{style="COLOR: teal"}(tifImage);]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                                                                                        |
| [(image [as]{style="COLOR: blue"} [PdfBitmap]{style="COLOR: teal"}).Mask = [new]{style="COLOR: blue"} [PdfImageMask]{style="COLOR: teal"}([new]{style="COLOR: blue"} [PdfBitmap]{style="COLOR: teal"}(bmpImage));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                        |
| [page.Graphics.DrawString([\"Image mask\"]{style="COLOR: maroon"}, font, brush, [new]{style="COLOR: blue"} [PointF]{style="COLOR: teal"}(10, 350));]{style="FONT-FAMILY: 'Courier New'"}                                                               |
|                                                                                                                                                                                                                                                        |
| [g.DrawImage(image, 10, 450);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                     |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                      |
|                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                    |
|                                                                                                                                                                                         |
| [\' Bitmap with Tiff image mask.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ image [As]{style="COLOR: blue"} PdfBitmap = [New]{style="COLOR: blue"} PdfBitmap(tifImage)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                         |
| [([TryCast]{style="COLOR: blue"}(image, PdfBitmap)).Mask = [New]{style="COLOR: blue"} PdfImageMask([New]{style="COLOR: blue"} PdfBitmap(bmpImage))]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                         |
| [page.Graphics.DrawString([\"Image mask\"]{style="COLOR: maroon"}, font, brush, [New]{style="COLOR: blue"} PointF(10, 350))]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                         |
| [g.DrawImage(image, 10, 450)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                       |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

[]{#related-topics}
:::
