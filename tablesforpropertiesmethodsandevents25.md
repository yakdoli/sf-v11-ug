::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template} ![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Tables for Properties, Methods, and Events {#tables-for-properties-methods-and-events style="tab-stops: 0pt"}

###### 1.6.2.23.2.1        Properties {#properties style="tab-stops: 0pt"}

  ------------------------------------------------ -------------------------------------------------------------------------------------------- ------------ ---------------
  **Property**                                     **Description**                                                                              **Type**     **Data Type**
  [EnableContextMenu]{style="LINE-HEIGHT: 115%"}   Gets or sets the context menu for expander cells (row header and column header cells only)   Dependency   Boolean
  ------------------------------------------------ -------------------------------------------------------------------------------------------- ------------ ---------------

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

###### 1.6.2.23.2.2        Methods {#methods style="tab-stops: 0pt"}

+----------------------------------+-------------------------------------------------------------+----------------+-------------+-----------------+
| **Method**                       | **Description**                                             | **Parameters** | **Type**    | **Return Type** |
+----------------------------------+-------------------------------------------------------------+----------------+-------------+-----------------+
| ExpandRow(string)                | Expands the group for the given row UniqueText.             | string         | NA          | void            |
+----------------------------------+-------------------------------------------------------------+----------------+-------------+-----------------+
| ExpandColumn (string)            | Expands the group for the given column UniqueText.          | string         | NA          | void            |
|                                  |                                                             |                |             |                 |
|                                  |                                                             |                |             |                 |
+----------------------------------+-------------------------------------------------------------+----------------+-------------+-----------------+
| CollapseRow(string)              | Collapse the group for the given row UniqueText.            | string         | NA          | void            |
|                                  |                                                             |                |             |                 |
|                                  |                                                             |                |             |                 |
+----------------------------------+-------------------------------------------------------------+----------------+-------------+-----------------+
| CollapseColumn (string)          | Collapse the group for the given column UniqueText.         | string         | NA          | void            |
|                                  |                                                             |                |             |                 |
|                                  |                                                             |                |             |                 |
+----------------------------------+-------------------------------------------------------------+----------------+-------------+-----------------+
| ExpandRow(List\<string\>)        | Expands the group for the given list of row UniqueText.     | List\<string\> | NA          | void            |
|                                  |                                                             |                |             |                 |
|                                  |                                                             |                |             |                 |
+----------------------------------+-------------------------------------------------------------+----------------+-------------+-----------------+
| ExpandColumn (List\<string\>)    | Expands the group for the given list of column UniqueText.  | List\<string\> | NA          | void            |
|                                  |                                                             |                |             |                 |
|                                  |                                                             |                |             |                 |
+----------------------------------+-------------------------------------------------------------+----------------+-------------+-----------------+
| CollapseRow(List\<string\>)      | Collapse the group for the given list of row UniqueText.    | List\<string\> | NA          | void            |
|                                  |                                                             |                |             |                 |
|                                  |                                                             |                |             |                 |
+----------------------------------+-------------------------------------------------------------+----------------+-------------+-----------------+
| CollapseColumn (List\<string\>)  | Collapse the group for the given list of column UniqueText. | List\<string\> | NA          | void            |
|                                  |                                                             |                |             |                 |
|                                  |                                                             |                |             |                 |
+==================================+=============================================================+================+=============+=================+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

###### 1.6.2.23.2.3        Events {#events style="tab-stops: 0pt"}

+-----------------+-------------------------------------------------------------------------------------------------+-----------------+-----------------+
| **Event**       | **Description**                                                                                 | **Arguments**   | **Type**        |
+-----------------+-------------------------------------------------------------------------------------------------+-----------------+-----------------+
| ExpandCollapse  | Provides enabling/disabling option for expand/collapse for a specific group (using UniqueText). | NA              | Event           |
|                 |                                                                                                 |                 |                 |
|                 |                                                                                                 |                 |                 |
+=================+=================================================================================================+=================+=================+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} []{style="COLOR: #c00000"} 

Sample Link

A sample is available in the Syncfusion WPF BI dashboard in the following location.

**PivotAnalysis** \> **GroupingBar** \> **Context Menu Demo**

{InstalledDrive}\\Users\\ {User}\\AppData\\ Local \\Syncfusion\\ EssentialStudio\\{Installed Version}\\BI\\WPF\\PivotAnalysis.Wpf\\Samples\\Grouping Bar \\Context Menu Demo

[]{style="COLOR: #c00000"} 

[]{#related-topics}
:::
