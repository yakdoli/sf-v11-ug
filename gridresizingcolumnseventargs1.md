::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### GridResizingColumnsEventArgs[]{#p223} {#gridresizingcolumnseventargs style="tab-stops: 0pt"}

The following table provides information on the properties of the event:

 

Table 27: Property

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------------------------+
| Property                          | Description                                                                          |
+-----------------------------------+--------------------------------------------------------------------------------------+
| AllowResize                       | Boolean property;  When false, disallow the resizing action.                         |
+-----------------------------------+--------------------------------------------------------------------------------------+
| Columns                           | Used to get or set the index of range of columns being resized.                      |
+-----------------------------------+--------------------------------------------------------------------------------------+
| Reason                            | Gives a hint about user action and reason for this event.                            |
|                                   |                                                                                      |
|                                   |                                                                                      |
|                                   |                                                                                      |
|                                   | Accepts a value of type GridResizeCellsReason enumeration:                           |
|                                   |                                                                                      |
|                                   | CancelMode -- Indicates current operation was cancelled.                             |
|                                   |                                                                                      |
|                                   | DoubleClick -- Indicates user double-clicked.                                        |
|                                   |                                                                                      |
|                                   | HitTest -- Indicates this is a Hit-Test query.                                       |
|                                   |                                                                                      |
|                                   | MouseDown -- Indicates user pressed mouse down.                                      |
|                                   |                                                                                      |
|                                   | MouseMove -- Indicates user is moving the mouse.                                     |
|                                   |                                                                                      |
|                                   | MouseUp -- Indicates user released the mouse.                                        |
|                                   |                                                                                      |
|                                   | ResetDefault -- Indicates changed column widths will be reset back to default value. |
|                                   |                                                                                      |
|                                   | ResetHide -- Indicates hidden columns will be made visible.                          |
|                                   |                                                                                      |
|                                   |                                                                                      |
+-----------------------------------+--------------------------------------------------------------------------------------+
| Width                             | Specifies the column width.                                                          |
+-----------------------------------+--------------------------------------------------------------------------------------+
| Point                             | Indicates the point at which the mouse hits the column before resizing.              |
+-----------------------------------+--------------------------------------------------------------------------------------+
:::

 

Example

 

This event can be triggered using the following code:

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                 |
|                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                            |
| [grid.ResizingRows += [new]{style="COLOR: blue"} [GridResizingRowsEventHandler]{style="COLOR: #2b91af"}(grid_ResizingRows);]{style="FONT-FAMILY: 'Courier New'"}           |
|                                                                                                                                                                            |
| [grid.ResizingColumns += [new]{style="COLOR: blue"} [GridResizingColumnsEventHandler ]{style="COLOR: #2b91af"}(grid_ResizingColumns);]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Event Handlers

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                  |
|                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                             |
| [//Disallow resizing of row 2.      ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                     |
|                                                                                                                                                                                             |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ grid_ResizingRows([object]{style="COLOR: blue"} sender, GridResizingRowsEventArgs args)]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                             |
| [    [if]{style="COLOR: blue"} (args.Rows.Top == 2)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                    |
|                                                                                                                                                                                             |
| [       args.AllowResize = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                      |
|                                                                                                                                                                                             |
| [//Disallow resizing of column 3.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                        |
|                                                                                                                                                                                             |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ grid_ResizingColumns([object]{style="COLOR: blue"} sender, GridResizingColumnsEventArgs args)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                             |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
|                                                                                                                                                                                             |
| [ [if]{style="COLOR: blue"} (args.Columns.Left == 3)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                             |
| [    args.AllowResize = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                  |
|                                                                                                                                                                                             |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                     |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
::::
