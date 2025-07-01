::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### RowsInserted and ColumnsInserted[]{#p224} {#rowsinserted-and-columnsinserted style="tab-stops: 0pt"}

These events are triggered when one or more rows or columns are inserted. The event handler receives an argument of type GridRangeInsertedEventArgs containing data related to this event. The following GridRangeInsertedEventArgs properties provide information specific to these events.

 

Table 28: Property

::: {align="center"}
  ---------- --------------------------------------------------------------------
  Property   Description
  Count      The number of rows or columns.
  InsertAt   The row or column index where the cells should be inserted before.
  ---------- --------------------------------------------------------------------
:::

 

Example

 

This event can be triggered using the following code:

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                      |
|                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                          |
|                                                                                                                                                                                 |
| [grid.Model.RowsInserted += [new]{style="COLOR: blue"} [GridRangeInsertedEventHandler ]{style="COLOR: #2b91af"}(Model_RowsInserted);]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                 |
| [grid.Model.ColumnsInserted += [new]{style="COLOR: blue"} [GridRangeInsertedEventHandler ]{style="COLOR: #2b91af"}(Model_ColumnsInserted);]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Event Handlers

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                        |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                   |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Model_ColumnsInserted([object]{style="COLOR: blue"} sender, [GridRangeInsertedEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                   |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                   |
| [     [Console]{style="COLOR: #2b91af"}.WriteLine(e.Count + [\" columns are inserted at \"]{style="COLOR: #a31515"} + e.InsertAt);]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                                                                                                                   |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                   |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Model_RowsInserted([object]{style="COLOR: blue"} sender, [GridRangeInsertedEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                   |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
|                                                                                                                                                                                                                   |
| [     [Console]{style="COLOR: #2b91af"}.WriteLine(e.Count + [\" rows are inserted at \"]{style="COLOR: #a31515"} + e.InsertAt);]{style="FONT-FAMILY: 'Courier New'"}                                              |
|                                                                                                                                                                                                                   |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                           |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
::::
