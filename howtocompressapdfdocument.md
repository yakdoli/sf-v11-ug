::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How To Compress a PDF Document? {#how-to-compress-a-pdf-document style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Compression is used for reducing the size of the created PDF document. Essential PDF controls the compression level of the document by using the **PdfCompressionLevel** class with the help of the LZW and zlib/deflate compression algorithms. Both LZW and Flate methods compress either binary data or ASCII text, but always produce binary data, even if the original data is text.

 

The following compression levels are supported by Essential PDF.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Best

[·      ]{style="FONT-FAMILY: Symbol"}BestSpeed

[·      ]{style="FONT-FAMILY: Symbol"}BelowNormal

[·      ]{style="FONT-FAMILY: Symbol"}AboveNormal

[·      ]{style="FONT-FAMILY: Symbol"}None

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                             |
|                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                       |
|                                                                                                            |
| [// Compressing PDF document]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                            |
|                                                                                                            |
| [doc.Compression = [PdfCompressionLevel]{style="COLOR: teal"}.Normal;]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                 |
|                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black; FONT-SIZE: 9pt"}                               |
|                                                                                                    |
| [\' Compressing PDF document]{style="FONT-FAMILY: 'Courier New'; COLOR: green; FONT-SIZE: 9pt"}    |
|                                                                                                    |
| [doc.Compression = PdfCompressionLevel.Normal]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
+----------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
