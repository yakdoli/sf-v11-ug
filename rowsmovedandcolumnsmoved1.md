::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### RowsMoved and ColumnsMoved[]{#p225} {#rowsmoved-and-columnsmoved style="tab-stops: 0pt"}

These events are raised when a range of rows or columns are moved from one position to another. Their event handlers receive an argument of type GridRangeMovedEventArgs containing data related to these events. Following are the event argument properties information about the rows or columns migration.

 

Table 29: Property

::: {align="center"}
  ---------- --------------------------------------------------------------------
  Property   Description
  Count      The index of the last row or column that was removed.
  InsertAt   The row or column index where the cells should be inserted before.
  RemoveAt   The index of the first row or column that was removed.
  ---------- --------------------------------------------------------------------
:::

 

Example

 

This event can be triggered using the following code:

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                             |
|                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                               |
|                                                                                                                                                                        |
| [grid.Model.RowsMoved += [new]{style="COLOR: blue"} [GridRangeMovedEventHandler]{style="COLOR: #2b91af"}(Model_RowsMoved);]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                                                        |
| [grid.Model.ColumnsMoved += [new]{style="COLOR: blue"} [GridRangeMovedEventHandler ]{style="COLOR: #2b91af"}(Model_ColumnsMoved);]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Event Handlers

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                          |
|                                                                                                                                                                                                                                   |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Model_RowsMoved([object]{style="COLOR: blue"} sender, GridRangeMovedEventArgs e)]{style="FONT-FAMILY: 'Courier New'"}                                                    |
|                                                                                                                                                                                                                                   |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                   |
| [    Console.WriteLine(e.RemoveAt + 1 - e.Count + [\" row(s) are moved from position \"]{style="COLOR: #a31515"} + e.RemoveAt + [\" to position \"]{style="COLOR: #a31515"} + e.InsertAt);]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                                                                                                                   |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                            |
|                                                                                                                                                                                                                                   |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Model_ColumnsMoved([object]{style="COLOR: blue"} sender, GridRangeMovedEventArgs e)]{style="FONT-FAMILY: 'Courier New'"}                                                 |
|                                                                                                                                                                                                                                   |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                           |
|                                                                                                                                                                                                                                   |
| [    Console.WriteLine(e.RemoveAt+ 1 - e.Count + [\" column(s) are moved from position \"]{style="COLOR: #a31515"} + e.RemoveAt + [\" to position \"]{style="COLOR: #a31515"} + e.InsertAt);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                   |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                           |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
::::
