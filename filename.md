::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Filename {#filename style="tab-stops: 0pt"}

Filename with Path

You can also export Page as an image file with directory path and file name.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                |
|                                                                                                                                                 |
| [diagramview.Save([@\"D:\\ Diagram.jpeg\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------+

  

Filename with Rect and Encoder

You can also specify the name of the file directly, specified portions of the DiagramPage, type of encoder such as TiffBitmapEncoder and GifBitmapEncoder.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                     |
| [TiffBitmapEncoder]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ encoder = [new]{style="COLOR: blue"} [TiffBitmapEncoder]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                                   |
|                                                                                                                                                                                                                                                                                     |
| [ [Rect]{style="COLOR: #2b91af"} rect = [new]{style="COLOR: blue"} [Rect]{style="COLOR: #2b91af"}([new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(100, 100), [new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(300, 300));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                     |
| [ [string]{style="COLOR: blue"} filename = [\" Diagram.jpeg\"]{style="COLOR: #a31515"};[]{style="COLOR: #a31515"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                                                                                                                                     |
| [diagramview.Save(filename, rect, encoder);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                              |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
