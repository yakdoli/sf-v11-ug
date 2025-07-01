::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### RowsRemoved and ColumnsRemoved {#rowsremoved-and-columnsremoved style="tab-stops: 0pt"}

These events are triggered when a range of rows or columns are removed from the grid. Their event handlers receive an argument of type GridRangeRemovedEventArgs containing data related to these events. Following are the event argument properties that provides information about the rows or columns removal.

 

Table 30: Property

::: {align="center"}
  ---------- --------------------------------------------------------
  Property   Description
  Count      The index of the last row or column that was removed.
  RemoveAt   The index of the first row or column that was removed.
  ---------- --------------------------------------------------------
:::

 

Example

 

This event can be triggered using the following code:

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                   |
|                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                              |
| [grid.Model.RowsRemoved += [new]{style="COLOR: blue"} [GridRangeRemovedEventHandler ]{style="COLOR: #2b91af"}(Model_RowsRemoved);]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                              |
| [grid.Model.ColumnsRemoved += [new]{style="COLOR: blue"} [GridRangeRemovedEventHandler ]{style="COLOR: #2b91af"}(Model_ColumnsRemoved);]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Event Handlers

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                            |
|                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                       |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Model_RowsRemoved([object]{style="COLOR: blue"} sender, GridRangeRemovedEventArgs e)]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                       |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                       |
| [    Console.WriteLine(e.RemoveAt + 1 - e.Count + [\" row(s) are removed from position \"]{style="COLOR: #a31515"} + e.RemoveAt);]{style="FONT-FAMILY: 'Courier New'"}                |
|                                                                                                                                                                                       |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                |
|                                                                                                                                                                                       |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Model_ColumnsRemoved([object]{style="COLOR: blue"} sender, GridRangeRemovedEventArgs e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                       |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                       |
| [    Console.WriteLine(e.RemoveAt + 1 - e.Count + [\" column(s) are removed from position \"]{style="COLOR: #a31515"} + e.RemoveAt);]{style="FONT-FAMILY: 'Courier New'"}             |
|                                                                                                                                                                                       |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
::::
