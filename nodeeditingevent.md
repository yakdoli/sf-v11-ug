::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Node Editing Event {#node-editing-event style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

The following events are handled when the tree node is in Edit Mode.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**BeforeItemEdit**--Occurs when the **IsInEditMode** property changes. This event is handled before the TreeViewItemAdv enters the edit mode.

[·      ]{style="FONT-FAMILY: Symbol"}**AfterItemEdit**--Occurs when the **IsInEditMode** property changes. This event is handled after the edit operations are completed.

[·      ]{style="FONT-FAMILY: Symbol"}**EditKeyUp**--Occurs when a key is raised, when the item in edit mode. This event is handled when the item is in edit mode.

[·      ]{style="FONT-FAMILY: Symbol"}**EditKeyDown**--Occurs when a key is raised, when the item is in edit mode. This event is handled when the item is in edit mode.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                              |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ [void]{style="COLOR: blue"} TreeViewItemAdv_EditKeyDown([object]{style="COLOR: blue"} sender, KeyEventArgs e)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}               |
|                                                                                                                                                                                                                                                              |
| [{]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                              |
| [    Debug.WriteLine([\"Down: \"]{style="COLOR: #a31515"} + e.Key);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                     |
|                                                                                                                                                                                                                                                              |
| [}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                              |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ [void]{style="COLOR: blue"} TreeViewItemAdv_EditKeyUp([object]{style="COLOR: blue"} sender, KeyEventArgs e)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                 |
|                                                                                                                                                                                                                                                              |
| [{]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                              |
| [    Debug.WriteLine([\"Up: \"]{style="COLOR: #a31515"} + e.Key);]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                       |
|                                                                                                                                                                                                                                                              |
| [}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                              |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ [void]{style="COLOR: blue"} TreeViewItemAdv_AfterItemEdit([object]{style="COLOR: blue"} sender, EditModeChangeEventArgs e)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}  |
|                                                                                                                                                                                                                                                              |
| [{]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                              |
| [    Debug.WriteLine([\"AfterItemEdit: old( \"]{style="COLOR: #a31515"} + e.OldValue + [\"), new( \"]{style="COLOR: #a31515"} + e.NewValue + [\")\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                          |
|                                                                                                                                                                                                                                                              |
| [}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                              |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue; FONT-SIZE: 9pt"}[ [void]{style="COLOR: blue"} TreeViewItemAdv_BeforeItemEdit([object]{style="COLOR: blue"} sender, EditModeChangeEventArgs e)]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"} |
|                                                                                                                                                                                                                                                              |
| [{]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                              |
| [    Debug.WriteLine([\"BeforeItemEdit: old( \"]{style="COLOR: #a31515"} + e.OldValue + [\"), new( \"]{style="COLOR: #a31515"} + e.NewValue + [\")\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                         |
|                                                                                                                                                                                                                                                              |
| [}]{style="FONT-FAMILY: 'Courier New'; FONT-SIZE: 9pt"}                                                                                                                                                                                                      |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p596} 

 

 

[]{#related-topics}
:::
