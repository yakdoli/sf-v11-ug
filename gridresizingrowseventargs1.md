::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### GridResizingRowsEventArgs {#gridresizingrowseventargs style="tab-stops: 0pt"}

The following table provides information on the properties of the event:

 

Table 26: Property

::: {align="center"}
+-----------------------------------+------------------------------------------------------------------------------------+
| Property                          | Description                                                                        |
+-----------------------------------+------------------------------------------------------------------------------------+
| AllowResize                       | Boolean property;  When false, disallow the resizing action.                       |
+-----------------------------------+------------------------------------------------------------------------------------+
| Rows                              | Used to get or set the index of range of rows being resized.                       |
+-----------------------------------+------------------------------------------------------------------------------------+
| Reason                            | Gives a hint about user action and reason for this event.                          |
|                                   |                                                                                    |
|                                   | Accepts a value of type GridResizeCellsReason enumeration:                         |
|                                   |                                                                                    |
|                                   | CancelMode -- Indicates current operation was cancelled.                           |
|                                   |                                                                                    |
|                                   | DoubleClick -- Indicates user double-clicked.                                      |
|                                   |                                                                                    |
|                                   | HitTest -- Indicates this is a Hit-Test query.                                     |
|                                   |                                                                                    |
|                                   | MouseDown -- Indicates user pressed mouse down.                                    |
|                                   |                                                                                    |
|                                   | MouseMove -- Indicates user is moving the mouse.                                   |
|                                   |                                                                                    |
|                                   | MouseUp -- Indicates user released the mouse.                                      |
|                                   |                                                                                    |
|                                   | ResetDefault -- Indicates changed row heights will be reset back to default value. |
|                                   |                                                                                    |
|                                   | ResetHide -- Indicates hidden rows will be made visible.                           |
+-----------------------------------+------------------------------------------------------------------------------------+
| Height                            | Specifies the row height.                                                          |
+-----------------------------------+------------------------------------------------------------------------------------+
| Point                             | Indicates the point at which the mouse hits the row before resizing.               |
+-----------------------------------+------------------------------------------------------------------------------------+
:::

[]{#related-topics}
::::
