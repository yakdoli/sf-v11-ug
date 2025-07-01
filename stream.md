::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Stream {#stream style="tab-stops: 0pt"}

Page can be exported into any streams such as FileStream and MemoryStream.

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                        |
| [System.IO.[FileStream]{style="COLOR: #2b91af"} filestream = [new]{style="COLOR: blue"} System.IO.[FileStream]{style="COLOR: #2b91af"}([\"Diagram.jpeg\"]{style="COLOR: #a31515"},System.IO.[FileMode]{style="COLOR: #2b91af"}.Create);[]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                        |
| [                ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                        |
| [diagramview.Save(filestream);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Stream with Rect and Encoder

You can also save to a stream with type of encoder and rectangle portion to be clipped.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                |
| [System.IO.[FileStream]{style="COLOR: #2b91af"} filestream = [new]{style="COLOR: blue"} System.IO.[FileStream]{style="COLOR: #2b91af"}([\"Diagram.jpeg\"]{style="COLOR: #a31515"},System.IO.[FileMode]{style="COLOR: #2b91af"}.Create);[]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}         |
|                                                                                                                                                                                                                                                                                                                |
| [TiffBitmapEncoder]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ encoder = [new]{style="COLOR: blue"} [TiffBitmapEncoder]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                              |
|                                                                                                                                                                                                                                                                                                                |
| [Rect]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ rect = [new]{style="COLOR: blue"} [Rect]{style="COLOR: #2b91af"}([new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(100, 100), [new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(300, 300));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                |
| [diagramview.Save(filestream, rect, encoder);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
