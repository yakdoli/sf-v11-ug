::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Exporting PDFs as Raster Images {#exporting-pdfs-as-raster-images style="tab-stops: 0pt"}

Essential PDF Viewer allows selected pages to be exported as raster images. It can be done using the ExportAsImage method. This option helps to convert a PDF into an image.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                  |
|                                                                                                                                                                                   |
| [Bitmap]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ img = pdfViewer1.ExportAsImage(0);]{style="FONT-FAMILY: 'Courier New'"}                                             |
|                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                   |
| [// Save the image]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                       |
|                                                                                                                                                                                   |
| [img.Save([\"Sample.png\"]{style="COLOR: #a31515"}, [ImageFormat]{style="COLOR: #2b91af"}.Png);]{style="FONT-FAMILY: 'Courier New'"}[]{style="BACKGROUND: #f2f2f2; COLOR: black"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                            |
|                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ img [As]{style="COLOR: blue"} Bitmap = pdfViewer1.ExportAsImage(0)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                          |
|                                                                                                                                                                 |
| [\' Save the image]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                     |
|                                                                                                                                                                 |
| [img.Save([\"Sample.png\"]{style="COLOR: darkred"}, ImageFormat.Png)]{style="FONT-FAMILY: 'Courier New'"}[]{style="BACKGROUND: #f2f2f2; COLOR: black"}          |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

You can also specify the page range instead of converting each page.

 

+----------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                             |
|                                                                                                                                              |
| [Bitmap\[\]]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ img = pdfViewer1.ExportAsImage(0, 3);]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                 |
|                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ img() [As]{style="COLOR: blue"} Bitmap = pdfViewer1.ExportAsImage(0, 3)]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
