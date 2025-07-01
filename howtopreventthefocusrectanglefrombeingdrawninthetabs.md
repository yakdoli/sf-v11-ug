::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to prevent the Focus Rectangle from being drawn in the Tabs {#how-to-prevent-the-focus-rectangle-from-being-drawn-in-the-tabs style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

 

You can easily do this by handling the **DrawItem** event, adjusting the **DrawTabEventArgs** and delegating drawing to the default drawing logic.

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} TabControlExt_DrawItem([object]{style="COLOR: blue"} sender, Syncfusion.Windows.Forms.Tools.[DrawTabEventArgs]{style="COLOR: teal"} drawItemInfo)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                |
| [// To indicate that the tab gets drawn as if it's not focused (without the focus rect).]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                    |
|                                                                                                                                                                                                                                                                                |
| [drawItemInfo.State &= \~[DrawItemState]{style="COLOR: teal"}.Focus;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                |
| [// Then forward drawing to default drawing logic.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                |
| [drawItemInfo.DrawBackground();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                |
| [drawItemInfo.DrawInterior();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                |
| [drawItemInfo.DrawBorders();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                        |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                    |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                     |
| [\'To indicate that the tab gets drawn as if it's not focused (without the focus rect).]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                          |
|                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ & [As]{style="COLOR: blue"} drawItemInfo.State = \~DrawItemState.Focus]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                              |
|                                                                                                                                                                     |
| [\'Then forward drawing to default drawing logic.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                |
|                                                                                                                                                                     |
| [drawItemInfo.DrawBackground()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                 |
|                                                                                                                                                                     |
| [drawItemInfo.DrawInterior()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                     |
| [drawItemInfo.DrawBorders()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                     |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                             |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

[]{#p897} 

[]{#related-topics}
:::
