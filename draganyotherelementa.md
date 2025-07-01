::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=12a08ff9-4431-493f-96ab-a03167143e48){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=43539208-4c11-49d2-a72f-b3d705a840b7){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Drag and Drop](ms-xhelp:///?Id=59f5b717-d79c-4335-b170-b6cd49e9632a){.d2h_breadcrumbsNormal}
:::

### Drag  Any Other Element and Drop into Grid: {#drag-any-other-element-and-drop-into-grid style="tab-stops: 0pt"}

This feature allows you to drag any element using **jQuery UI Draggable** and drop it into your grid. You can also drop any element into a specified row in the table.

 

Properties

 

::: {align="center"}
+---------------------------+-------------+-------------------+---------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Property                  | Type        | Value it accepts  | Dependency                                                    | Description                                                                                                                                                  |
+---------------------------+-------------+-------------------+---------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Droppable                 | Boolean     | Any boolean value | Normal                                                        | This property sets your Grid as Droppable.                                                                                                                   |
|                           |             |                   |                                                               |                                                                                                                                                              |
|                           |             |                   |                                                               |                                                                                                                                                              |
+---------------------------+-------------+-------------------+---------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ElementtoDrag             | String      | Any string value  | Dependecy on Droppable                                        | This property sets the Target element to be dragged. String must be like a normal selector.                                                                  |
|                           |             |                   |                                                               |                                                                                                                                                              |
|                           |             |                   |                                                               | ie, To represent ID: "#TargetID",                                                                                                                            |
|                           |             |                   |                                                               |                                                                                                                                                              |
|                           |             |                   |                                                               |     To represent class: ".TargetClassname"                                                                                                                   |
+---------------------------+-------------+-------------------+---------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| EnableSelectionOnDragging | Boolean     | Any boolean value | Dependecy on Droppable property                               | This property is set if a row needs to be selected while draggable element is dragging on your GridRow. This happens only if no row is already selected.     |
|                           |             |                   |                                                               |                                                                                                                                                              |
|                           |             |                   |                                                               |                                                                                                                                                              |
+---------------------------+-------------+-------------------+---------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| EnableHighlighting        | Boolean     | Any boolean value | Dependecy on Droppable and EnableSelectionOnDragging property | This property is set if a row(the current row which is accepting the Droppable) needs to be Highlighted while draggable element is dragging on your GridRow. |
|                           |             |                   |                                                               |                                                                                                                                                              |
|                           |             |                   |                                                               |                                                                                                                                                              |
+---------------------------+-------------+-------------------+---------------------------------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Methods

::: {align="center"}
+---------------------------+-----------------+-----------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Method                    | Parameter type  | Return type     | Description                                                                                                                                                  |
+---------------------------+-----------------+-----------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Droppable                 | Boolean         | IGridBuilder    | This property sets your Grid as Droppable.                                                                                                                   |
|                           |                 |                 |                                                                                                                                                              |
|                           |                 |                 |                                                                                                                                                              |
+---------------------------+-----------------+-----------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| ElementtoDrag             | String          | IGridBuilder    | This property sets the Target element to be dragged. String must be like a normal selector.                                                                  |
|                           |                 |                 |                                                                                                                                                              |
|                           |                 |                 | ie, To represent ID: "#TargetID",                                                                                                                            |
|                           |                 |                 |                                                                                                                                                              |
|                           |                 |                 |     To represent class: ".TargetClassname"                                                                                                                   |
|                           |                 |                 |                                                                                                                                                              |
|                           |                 |                 |                                                                                                                                                              |
+---------------------------+-----------------+-----------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| EnableSelectionOnDragging | Boolean         | IGridBuilder    | This property is set if a row needs to be selected while draggable element is dragging on your GridRow. This happens only if no row is already selected.     |
|                           |                 |                 |                                                                                                                                                              |
|                           |                 |                 |                                                                                                                                                              |
+---------------------------+-----------------+-----------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| EnableHighlighting        | Boolean         | IGridBuilder    | This property is set if a row(the current row which is accepting the Droppable) needs to be Highlighted while draggable element is dragging on your GridRow. |
|                           |                 |                 |                                                                                                                                                              |
|                           |                 |                 |                                                                                                                                                              |
+---------------------------+-----------------+-----------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

Events

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

::: {align="center"}
+-----------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+-----------------------+
| Name                  | Description                                                                                                                                                                                                                                         | Arguments             |
+-----------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+-----------------------+
| OnGridRowDragEvent    | The event which call its handler while dragging in any of the grid row. In this event you are passing the Grid object, Json Record of the selected row and the dragging element.                                                                    | Event,                |
|                       |                                                                                                                                                                                                                                                     |                       |
|                       |                                                                                                                                                                                                                                                     | Data,                 |
|                       |                                                                                                                                                                                                                                                     |                       |
|                       |                                                                                                                                                                                                                                                     | DragElement           |
+-----------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+-----------------------+
| OnGridRowsDropEvent   | The event which calls the handler after dropped operation. By this event you can update your own target element by using ajax post. In this event you are passing the Grid object, Json Record of the selected row and the element that is dropped. | Event,                |
|                       |                                                                                                                                                                                                                                                     |                       |
|                       |                                                                                                                                                                                                                                                     | Data,                 |
|                       |                                                                                                                                                                                                                                                     |                       |
|                       |                                                                                                                                                                                                                                                     | DragElement           |
+-----------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+-----------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Through Grid Builder](ms-xhelp:///?Id=d319e8ad-d884-4c53-8a34-73d67528fc80){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Through GridPropertiesModel:](ms-xhelp:///?Id=5e8bf4ae-481e-42f9-87e6-b761394b124d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Properties Explanation](ms-xhelp:///?Id=5b6d4c72-6e14-4722-8acc-aef58f4a062b){style="TEXT-DECORATION: none"}
:::::::
