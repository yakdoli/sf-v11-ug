::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### XPS {#xps style="tab-stops: 0pt"}

The DiagramPage can be exported in different ways:

[·      ]{style="FONT-FAMILY: Symbol"}Stream

[·      ]{style="FONT-FAMILY: Symbol"}Filename with Path

[·      ]{style="FONT-FAMILY: Symbol"}Filename with Rect

[·      ]{style="FONT-FAMILY: Symbol"}Stream with Rect

Stream

You can also save to a stream.

The following Code illustrates how to save the Page.

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                              |
| [System.IO.[FileStream]{style="COLOR: #2b91af"} filestream = [new]{style="COLOR: blue"} System.IO.[FileStream]{style="COLOR: #2b91af"}([\"Diagram.xps\"]{style="COLOR: #a31515"}, System.IO.[FileMode]{style="COLOR: #2b91af"}.Create);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                              |
| [diagramview.SaveToXps(filestream);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                               |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Stream with Rect

You can also save to a stream with specified size of the save area.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                             |
| [System.IO.[FileStream]{style="COLOR: #2b91af"} filestream = [new]{style="COLOR: blue"} System.IO.[FileStream]{style="COLOR: #2b91af"}([\"(@\"D:\\Diagram.xps\"]{style="COLOR: #a31515"},System.IO.[FileMode]{style="COLOR: #2b91af"}.Create);]{style="FONT-FAMILY: 'Courier New'"}                         |
|                                                                                                                                                                                                                                                                                                             |
| [Rect]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ rect = [new]{style="COLOR: blue"} [Rect]{style="COLOR: #2b91af"}([new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(200,200),[new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(500,500));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                             |
| [diagramview.SaveToXps(filestream,rect);]{style="FONT-FAMILY: 'Courier New'"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Filename with Path

You can also specify the name of the file directly in the save method.

 

+--------------------------------------------------------------------------------------------------------------------+
| **[\[C#]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                               |
|                                                                                                                    |
| [diagramview.SaveToXps([@\"D:\\Diagram.xps\"]{style="COLOR: #a31515"}, rect);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                             |
+--------------------------------------------------------------------------------------------------------------------+

 

Filename with Rect

You can also specify the name of the file directly; Specified size of the save area.in the save method.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                |
| [Rect]{style="FONT-FAMILY: 'Courier New'; COLOR: #2b91af"}[ rect = [new]{style="COLOR: blue"} [Rect]{style="COLOR: #2b91af"}([new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(100, 100), [new]{style="COLOR: blue"} [Point]{style="COLOR: #2b91af"}(500, 500));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                |
| [            diagramview.SaveToXps([@\"D:\\Diagram.xps\"]{style="COLOR: #a31515"}, rect);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                         |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

[]{#related-topics}
:::
