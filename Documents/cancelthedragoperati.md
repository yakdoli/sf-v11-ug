::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Cancel the Drag Operation Manually

[]{#CancelDrag}The CancelDrag() method in DragAndDropManager is used to cancel the drag and drop operation manually. The following code snippet explains this:

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                               |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ DragAndDropManager_Drag([object]{style="COLOR: blue"} sender, [DragDropEventArgs]{style="COLOR: #2b91af"} args)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                               |
| [  {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
|                                                                                                                                                                                                               |
| [ [if]{style="COLOR: blue"} (sender [is]{style="COLOR: blue"} [Panel]{style="COLOR: #2b91af"})]{style="FONT-FAMILY: 'Courier New'"}                                                                           |
|                                                                                                                                                                                                               |
| [     [DragAndDropManager]{style="COLOR: #2b91af"}.CancelDrag();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                               |
| [  }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                     |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
