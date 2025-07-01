::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Selection Features {#selection-features style="tab-stops: 0pt"}

GridTree control does not use the selection support inherited from the Grid control, because the selections in the Grid Tree need to be persisted, as the nodes are expanded/collapsed and sorted. The GridTreeNode.IsSelected property indicates whether the node is selected or not and the GridTreeNode.SelectedColumns property contains the names of the columns selected for the node. You can access selected nodes by using the GridTreeControl.SelectedNodes property.

The following code example illustrates cell range selections in the Grid Tree.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                      |
|                                                                                                                                                                                                 |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}**                                                                                                                                         |
|                                                                                                                                                                                                 |
| [foreach]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ([GridTreeNode]{style="COLOR: #2b91af"} node [in]{style="COLOR: blue"} treeGrid.SelectedNodes)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                 |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                 |
| [    [foreach]{style="COLOR: blue"} ([string]{style="COLOR: blue"} columnName [in]{style="COLOR: blue"} node.SelectedColumns)]{style="FONT-FAMILY: 'Courier New'"}                              |
|                                                                                                                                                                                                 |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                 |
| [        [Console]{style="COLOR: #2b91af"}.Write([\"{0} \"]{style="COLOR: #a31515"}, treeGrid.InternalGrid.GetValueFromNode(columnName, node));]{style="FONT-FAMILY: 'Courier New'"}            |
|                                                                                                                                                                                                 |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                                 |
| [    [Console]{style="COLOR: #2b91af"}.WriteLine();]{style="FONT-FAMILY: 'Courier New'"}                                                                                                        |
|                                                                                                                                                                                                 |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::
