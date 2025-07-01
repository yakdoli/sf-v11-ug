::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### [DragThreshold]{#DragThreshold}

The DragThreshold sets the minimum distance that needs to be move the the mouse to start a drag operation. 

Use case Scenarios

DragThreshold, prevents accidental and unwanted dragging.  Because, the dragging process initiated only when the object dragged beyond the DragThreshold distance.

Adding DragThreshold to an Application

[]{#SetDragThreshold}The static method SetDragThreshold() in DragAndDropManager is used to set the DragThreshold. The most suitable moment to set a DragThreshold is to do so before firing any drag event. The following lines of code show this:

[]{style="COLOR: black"} 

+----------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                        |
| [public]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ MainPage()]{style="FONT-FAMILY: 'Courier New'"}                             |
|                                                                                                                                        |
| [ {]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                        |
| [  InitializeComponent();]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                        |
| [  [DragAndDropManager]{style="COLOR: #2b91af"}.SetDragThreshold([this]{style="COLOR: blue"}, 5);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                        |
| [ }]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
+----------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::
