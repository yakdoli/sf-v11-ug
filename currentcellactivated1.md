::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### CurrentCellActivated {#currentcellactivated style="tab-stops: 0pt"}

[]{#p237}It occurs after the grid activates the specified cell as current cell. It receives an argument of type SyncfusionRoutedEventArgs that provides the cell co-ordinates, hence the location of the cell.

 

Example

 

This event can be triggered using the following code:

 

+--------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                       |
|                                                                                                                                                  |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                           |
|                                                                                                                                                  |
| [grid.CurrentCellActivated += [new]{style="COLOR: blue"} GridRoutedEventHandler(grid_CurrentCellActivated);]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------+

 

Event Handler

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                              |
|                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                         |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ grid_CurrentCellActivated([object]{style="COLOR: blue"} sender, SyncfusionRoutedEventArgs args)]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                                                         |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
|                                                                                                                                                                                                         |
| [    MessageBox.Show([\"CurrentCell is \"]{style="COLOR: #a31515"} + grid.CurrentCell.RowIndex + [\", \"]{style="COLOR: #a31515"} + grid.CurrentCell.ColumnIndex);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                         |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::
