::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=59f5b717-d79c-4335-b170-b6cd49e9632a){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=01252b51-e142-40c8-93cc-10c3522f111a){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential ASP.NET MVC](ms-xhelp:///?Id=4b14e7d1-65c4-4f67-b1aa-2c37709905a5){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Getting Started](ms-xhelp:///?Id=c7ed3902-b25b-4170-be58-1d3d0b57748a){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Feature Summary](ms-xhelp:///?Id=1923e679-441a-44e0-9bca-e0e50988a857){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=4a1657fa-4756-42b9-9153-aebf5dcfc503){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Drag and Drop](ms-xhelp:///?Id=59f5b717-d79c-4335-b170-b6cd49e9632a){.d2h_breadcrumbsNormal}
:::

### Dragging and Dropping Grid Rows into Any Other Element {#dragging-and-dropping-grid-rows-into-any-other-element style="tab-stops: 0pt"}

 

This feature allows you to select multiple rows (using **jQuery UI Selectable**) and drag and drop the selected rows to any other element which is specified using the **TargetHtmlElementId** property of the grid.

 

Properties

 

::: {align="center"}
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------+------------------+---------------------------+--------------------------------------------------+
| Property               | Description                                                                                                                               | Type of property | Value it accepts          | Any other dependencies/sub-properties associated |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------+------------------+---------------------------+--------------------------------------------------+
| TargetHtmlElementID    | Gets or sets the selector identification of the TargetElement to Drop.                                                                    | String           | Any string value          | AllowRowsDragging                                |
|                        |                                                                                                                                           |                  |                           |                                                  |
|                        | ie, To represent ID: "#TargetID",                                                                                                         |                  |                           |                                                  |
|                        |                                                                                                                                           |                  |                           |                                                  |
|                        |     To represent class: ".TargetClassname"                                                                                                |                  |                           |                                                  |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------+------------------+---------------------------+--------------------------------------------------+
| RowsDraggingMode       | This property sets the type of dragand drop mode. Options are Normal and GhostRows.                                                       | Enum             | DragandDropMode.GhostRows | AllowRowsDragging                                |
|                        |                                                                                                                                           |                  |                           |                                                  |
|                        |                                                                                                                                           |                  | DragandDropMode.Normal    |                                                  |
|                        |                                                                                                                                           |                  |                           |                                                  |
|                        |                                                                                                                                           |                  |                           |                                                  |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------+------------------+---------------------------+--------------------------------------------------+
| **AllowRowsDragging**  | This property enables this Rows Drag and Drop feature and JQuery UI Selection.                                                            | Boolean          | Any Boolean value         | NA                                               |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------+------------------+---------------------------+--------------------------------------------------+
| **RowsDroppingMapper** | This property sets the mapping string. To update the source grid while dropping the rows, if you need one Action means you can give here. | string           | Any string value          | AllowRowsDragging                                |
|                        |                                                                                                                                           |                  |                           |                                                  |
|                        |                                                                                                                                           |                  |                           |                                                  |
|                        |                                                                                                                                           |                  |                           |                                                  |
|                        | For Example: if you move rows from one grid to another grid in Source grid the rows needs to be removed from database.                    |                  |                           |                                                  |
|                        |                                                                                                                                           |                  |                           |                                                  |
|                        |                                                                                                                                           |                  |                           |                                                  |
+------------------------+-------------------------------------------------------------------------------------------------------------------------------------------+------------------+---------------------------+--------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

Methods

 

::: {align="center"}
+------------------------+---------------------------+-----------------+------------------------------------------------------------------------------------------------------------------------------------+
| Method                 | Parameters                | Return type     | Descriptions                                                                                                                       |
+------------------------+---------------------------+-----------------+------------------------------------------------------------------------------------------------------------------------------------+
| TargetHtmlElementID    | String                    | IGridBuilder    | Used to set the selector identification of the TargetElement to Drop.                                                              |
|                        |                           |                 |                                                                                                                                    |
|                        |                           |                 | ie, To represent ID: "#TargetID",                                                                                                  |
|                        |                           |                 |                                                                                                                                    |
|                        |                           |                 |     To represent class: ".TargetClassname"                                                                                         |
|                        |                           |                 |                                                                                                                                    |
|                        |                           |                 |                                                                                                                                    |
+------------------------+---------------------------+-----------------+------------------------------------------------------------------------------------------------------------------------------------+
| RowsDraggingMode       | DragandDropMode.GhostRows | IGridBuilder    | Used to set which type of dragand drop mode. Options are Normal and GhostRows.                                                     |
|                        |                           |                 |                                                                                                                                    |
|                        | DragandDropMode.Normal    |                 |                                                                                                                                    |
|                        |                           |                 |                                                                                                                                    |
|                        |                           |                 |                                                                                                                                    |
+------------------------+---------------------------+-----------------+------------------------------------------------------------------------------------------------------------------------------------+
| **AllowRowsDragging**  | Boolean                   | IGridBuilder    | Used to enable this Rows Drag and Drop feature and JQuery UI Selection.                                                            |
|                        |                           |                 |                                                                                                                                    |
|                        |                           |                 |                                                                                                                                    |
+------------------------+---------------------------+-----------------+------------------------------------------------------------------------------------------------------------------------------------+
| **RowsDroppingMapper** | String                    | IGridBuilder    | Used to set the mapping string, to update the source grid while dropping the rows, if you need one Action means you can give here. |
|                        |                           |                 |                                                                                                                                    |
|                        |                           |                 | For Example: if you move rows from one grid to another grid in Source grid the rows needs to be removed from database.             |
|                        |                           |                 |                                                                                                                                    |
|                        |                           |                 |                                                                                                                                    |
+------------------------+---------------------------+-----------------+------------------------------------------------------------------------------------------------------------------------------------+
:::

 

Events

 

::: {align="center"}
+-----------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+-----------------------+
| Name                  | Description                                                                                                                                                                                                                             | Arguments             |
+-----------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+-----------------------+
| OnRowDropping         | The event which call its handler after draging operation and before dropping operation. Here you are providing option to cancel the drop. gridObject contains DroppingCancel variable if it is set as True. Dropping will be cancelled. | Event,                |
|                       |                                                                                                                                                                                                                                         |                       |
|                       |                                                                                                                                                                                                                                         | Data                  |
+-----------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+-----------------------+
| OnRowDropped          | The event which calls the handler after dropped operation. By this event you can update your own target element by using ajax post.                                                                                                     | Event,                |
|                       |                                                                                                                                                                                                                                         |                       |
|                       |                                                                                                                                                                                                                                         | Data                  |
+-----------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+-----------------------+
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Through GridBuilder](ms-xhelp:///?Id=f3ef0bc1-ba1c-4246-b61c-466ce28b2cd2){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Through GridPropertiesModel](ms-xhelp:///?Id=85cdbf2a-56ff-444d-81d6-a5fe19d2764f){style="TEXT-DECORATION: none"}
:::::::
