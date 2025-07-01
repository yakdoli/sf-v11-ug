::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### []{#DragMode}Change the Drag Mode at Runtime

[]{#SetDragMode} 

The DragMode property of DragAndDropManager is used to change the mode of the drag operation. The most suitable event handler to change the drag mode is QueryContinueDrag. The following code snippet explains this:

 

 

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                          |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ DragAndDropManager_QueryContinueDrag([object]{style="COLOR: blue"} sender, [DragDropEventArgs]{style="COLOR: #2b91af"}    ]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                          |
| [    args)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                          |
| [ {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                          |
| [  [if]{style="COLOR: blue"} (args.DragKey == [Key]{style="COLOR: #2b91af"}.Ctrl)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                          |
| [   {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                          |
| [    [DragAndDropManager]{style="COLOR: #2b91af"}.SetDragMode([this]{style="COLOR: blue"}, [DragMode]{style="COLOR: #2b91af"}.Copy);]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                                                          |
| [   }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                               |
|                                                                                                                                                                                                                          |
| [ [else]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                       |
|                                                                                                                                                                                                                          |
| [  {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                          |
| [   [DragAndDropManager]{style="COLOR: #2b91af"}.SetDragMode([this]{style="COLOR: blue"}, [DragMode]{style="COLOR: #2b91af"}.Move);]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                          |
| [  }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
|                                                                                                                                                                                                                          |
| [ }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
