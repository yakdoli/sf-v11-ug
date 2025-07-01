::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### ResizingRows and ResizingColumns {#resizingrows-and-resizingcolumns style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

These events are used to control over resizing of specific rows or columns. They are triggered when a row or column is being resized. The event handler receives an argument of type **GridResizingRowsEventArgs** or **GridResizingColumnsEventArgs** containing data related to the event. The following properties of the event arguments provide information specific to these events.

 

Properties of GridResizingRowsEventArgs

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

::: {align="center"}
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------+
| Property                          | Description                                                                                                                |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------+
| AllowResize                       | Boolean property; When false, disallow the resizing action.                                                                |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------+
| Rows                              | Used to get or set the index of range of rows being resized.                                                               |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------+
| Reason                            | Gives a hint about user action and reason for this event.                                                                  |
|                                   |                                                                                                                            |
|                                   |                                                                                                                            |
|                                   |                                                                                                                            |
|                                   | Accepts a value of type GridResizeCellsReason enumeration:                                                                 |
|                                   |                                                                                                                            |
|                                   | []{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}                                       |
|                                   |                                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**CancelMode**--Indicates current operation was cancelled.                           |
|                                   |                                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**DoubleClick**--Indicates user double-clicked.                                      |
|                                   |                                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**HitTest**--Indicates this is a Hit-Test query.                                     |
|                                   |                                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**MouseDown**--Indicates user pressed mouse down.                                    |
|                                   |                                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**MouseMove**--Indicates user is moving the mouse.                                   |
|                                   |                                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**MouseUp**--Indicates user released the mouse.                                      |
|                                   |                                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**ResetDefault**--Indicates changed row heights will be reset back to default value. |
|                                   |                                                                                                                            |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**ResetHide**--Indicates hidden rows will be made visible.                           |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------+
| Height                            | Specifies the row height.                                                                                                  |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------+
| Point                             | Indicates the point at which the mouse hits the row before resizing.                                                       |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Properties of GridResizingColumnsEventArgs

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------+
| Property                          | Description                                                                                                                  |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------+
| AllowResize                       | Boolean property; When false, disallow the resizing action.                                                                  |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------+
| Columns                           | Used to get or set the index of range of columns being resized.                                                              |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------+
| Reason                            | Gives a hint about user action and reason for this event.                                                                    |
|                                   |                                                                                                                              |
|                                   |                                                                                                                              |
|                                   |                                                                                                                              |
|                                   | Accepts a value of type GridResizeCellsReason enumeration:                                                                   |
|                                   |                                                                                                                              |
|                                   | []{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}                                         |
|                                   |                                                                                                                              |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**CancelMode**--Indicates current operation was cancelled.                             |
|                                   |                                                                                                                              |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**DoubleClick**--Indicates user double-clicked.                                        |
|                                   |                                                                                                                              |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**HitTest**--Indicates this is a Hit-Test query.                                       |
|                                   |                                                                                                                              |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**MouseDown**--Indicates user pressed mouse down.                                      |
|                                   |                                                                                                                              |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**MouseMove**--Indicates user is moving the mouse.                                     |
|                                   |                                                                                                                              |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**MouseUp**--Indicates user released the mouse.                                        |
|                                   |                                                                                                                              |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**ResetDefault**--Indicates changed column widths will be reset back to default value. |
|                                   |                                                                                                                              |
|                                   | [·      ]{style="FONT-FAMILY: Symbol"}**ResetHide**--Indicates hidden columns will be made visible.                          |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------+
| Width                             | Specifies the column width.                                                                                                  |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------+
| Point                             | Indicates the point at which the mouse hits the column before resizing.                                                      |
+-----------------------------------+------------------------------------------------------------------------------------------------------------------------------+
:::

[         ]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}

Example

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

These events can be invoked as follows:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                         |
|                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                               |
|                                                                                                                                                                        |
| [grid.ResizingRows += [new]{style="COLOR: blue"} [GridResizingRowsEventHandler]{style="COLOR: teal"}(grid_ResizingRows);]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                                        |
| [grid.ResizingColumns += [new]{style="COLOR: blue"} [GridResizingColumnsEventHandler]{style="COLOR: teal"}(grid_ResizingColumns);]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Event Handlers:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                     |
|                                                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                           |
|                                                                                                                                                                                                                    |
| [// Disallow resizing of row 2.      ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                           |
|                                                                                                                                                                                                                    |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ grid_ResizingRows([object]{style="COLOR: blue"} sender, [GridResizingRowsEventArgs]{style="COLOR: teal"} args)]{style="FONT-FAMILY: 'Courier New'"}       |
|                                                                                                                                                                                                                    |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                    |
| [if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (args.Rows.Top == 2)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                    |
| [args.AllowResize = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                    |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                    |
| [// Disallow resizing of column 3.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                              |
|                                                                                                                                                                                                                    |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ grid_ResizingColumns([object]{style="COLOR: blue"} sender, [GridResizingColumnsEventArgs]{style="COLOR: teal"} args)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                    |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
|                                                                                                                                                                                                                    |
| [if]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (args.Columns.Left == 3)]{style="FONT-FAMILY: 'Courier New'"}                                                                                               |
|                                                                                                                                                                                                                    |
| [args.AllowResize = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                    |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p202} 

 

[]{#related-topics}
:::::
