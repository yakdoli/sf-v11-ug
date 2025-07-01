::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How do I paint the GroupBarItem image without scaling the image? {#how-do-i-paint-the-groupbaritem-image-without-scaling-the-image style="tab-stops: 0pt"}

 

You can draw the image of GroupBarItem (without scaling it), by overriding the DrawGroupBarImage method of the GroupBar. ****

+-------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                      |
|                                                                                                       |
| [// For this callback to occur LargeImageMode must be set to true.\                                   |
|  this.groupBarItem1.LargeImageMode = true;]{style="FONT-FAMILY: 'Courier New'"}                       |
|                                                                                                       |
| [protected override void DrawGroupBarImage(Graphics gph, int nindex, Rectangle rcbar)\                |
| {\                                                                                                    |
| Point location = new Point(rcbar.X + 20, rcbar.Y);\                                                   |
| gph.DrawImage(this.VisibleGroupBarItems\[nindex\].Image, new Rectangle(location, new Size(20, 20)));\ |
| }]{style="FONT-FAMILY: 'Courier New'"}                                                                |
+-------------------------------------------------------------------------------------------------------+

**** 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                             |
| [\' For this callback to occur LargeImageMode must be set to true.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.groupBarItem1.LargeImageMode = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                             |
| [Overrides ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Sub]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[DrawGroupBarImage(Graphics gph, [Integer]{style="COLOR: blue"} n]{style="FONT-FAMILY: 'Courier New'"}[index, Rectangle rcbar)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ location [As]{style="COLOR: blue"} [New]{style="COLOR: blue"} Point(rcbar.X + 20, rcbar.Y)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                             |
| [gph.DrawImage([Me]{style="COLOR: blue"}.VisibleGroupBarItems(nindex).Image, [New]{style="COLOR: blue"} Rectangle(location, [New]{style="COLOR: blue"} Size(20, 20)))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                             |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Sub]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                           |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#_GroupView} 

 

[]{#related-topics}
:::
