::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=ae9b06df-29c1-4a96-b6c2-668aab38bd97){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=8fba608f-39b5-4dfd-b613-690a9f5af2a4){#D2HNext .D2HNextEnabled}
:::
::::
:::::

:::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential WPF](ms-xhelp:///?Id=7f4f82c5-151c-4262-94d0-75c4626c77bc){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Grid]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Installation and Deployment](ms-xhelp:///?Id=094c35c7-db8e-4341-9619-16644b2a4e34){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Grid WPF Controls](ms-xhelp:///?Id=1249c159-5431-465a-b1af-1cf1e5e90ac8){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[GridData Control](ms-xhelp:///?Id=e9aeb59d-d6ab-4862-87f7-4f169b1d763e){.d2h_breadcrumbsNormal}
:::

### Events[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} {#events style="tab-stops: 0pt"}

The GridData control declares a number of events that it can handle, in response to the activities either by the end user or by the system. An event is a message that is handled, to notify an object or a class of the occurrence of an action. When an event is handled, all the event handlers will be notified.

 

The GridData control offers technical benefits by declaring all its events as Routed Events. Hence, being the high level visual element in the visual tree, it need not hook the same event on all of its descendants (e.g. rows, columns and cells), such as MouseMove. Instead, it hooks the event on itself and hence, when the mouse moves over one of its descendants, the grid will be notified appropriately, whenever the event is handled without expecting its descendants to notify it.

 

Subscribing to Events

 

In order to get event notifications, the grid needs to be wired up with the required events. This process is called as subscribing to the events. It can be done using either XAML or C# code.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[XAML\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| [\<]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[syncfusion]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[GridDataControl]{style="FONT-FAMILY: 'Courier New'; COLOR: #a31515"}[ x]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[:]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Name]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"dataGrid\"]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [AutoPopulateColumns]{style="COLOR: red"}[=\"True\" ]{style="COLOR: blue"}[ItemsSource]{style="COLOR: red"}[=\"{]{style="COLOR: blue"}[StaticResource]{style="COLOR: #a31515"}[ ordersSource]{style="COLOR: red"}[}\"]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| [MouseMove]{style="FONT-FAMILY: 'Courier New'; COLOR: red"}[=\"dataGrid_MouseMove\"\>]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                    |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                           |
|                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dataGrid.MouseMove+=[new]{style="COLOR: blue"} [MouseEventHandler]{style="COLOR: #2b91af"}(dataGrid_MouseMove);]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

For either of the above code languages, you should have the following C# code to handle the MouseMove event.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                       |
| [private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [void]{style="COLOR: blue"} dataGrid_MouseMove([object]{style="COLOR: blue"} sender, [MouseEventArgs]{style="COLOR: #2b91af"} e)]{style="FONT-FAMILY: 'Courier New'"}     |
|                                                                                                                                                                                                                                       |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                       |
| [    [Console]{style="COLOR: #2b91af"}.WriteLine([\"Mouse cursor Postion:\"]{style="COLOR: #a31515"} + e.GetPosition(sender [as]{style="COLOR: blue"} [IInputElement]{style="COLOR: #2b91af"}));]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                       |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image28_3.jpg){border="0"}Note: These Grid WPF mouse events are more advantageous than using any other default mouse events; Because the default mouse events are controlled by Mouse Controller, which makes it very hard to access the underlying data. Whereas in case of Grid mouse events, it is directly possible to access the underlying data easily.
:::

**[]{style="COLOR: #15428b"}** 

Unsubscribing the events

 

If you do not want the grid to listen to the event, you can unwire the event from the grid as follows.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                    |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                               |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dataGrid.MouseMove-=[new]{style="COLOR: blue"} [MouseEventHandler]{style="COLOR: #2b91af"}(dataGrid_MouseMove);]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

Table 46: GridData Control Events

::: {align="center"}
  --------------------------------- -----------------------------------------------------------------------------------------------------------------------------------------------------------------------
  Event                             Description
  CurrentCellActivating             This event is handled before the grid activates the specified cell as current cell.
  CurrentCellActivated              This event is handled after the grid activates the specified cell as current cell.
  CurrentCellActivateFailed         This event is handled after the grid fails to activate a specific cell as current cell.
  CurrentCellDeactivating           This event is handled before the grid deactivates the current cell.
  CurrentCellDeactivated            This event is handled after the grid deactivates current cell.
  CurrentCellDeactivateFailed       This event is handled after the grid fails to deactivate the current cell.
  CurrentCellConfirmChangesFailed   This event is handled when the grid fails to save the changes made to the active current cell.
  CurrentCellAcceptedChanges        This event is handled when the grid accepts the changes made to the active current cell.
  CurrentCellChanging               This event is handled when the user wants to modify contents of the current cell.
  CurrentCellStartEditing           This event is handled before the current cell switches to the editing mode.
  CurrentCellEditingComplete        This event is handled when the grid completes editing the active current cell.
  CurrentCellRejectedChanges        This event is handled when the grid rejects the changes made to the active current cell.
  CurrentCellChanged                This event is handled when the user changes the contents of the current cell.
  CurrentCellMoved                  This event is handled when the current cell is successfully moved to a new position.
  CurrentCellMoveFailed             This event is handled when the current cell fails to move to a new position.
  CurrentCellMoving                 This event is handled when the current cell is about to be moved to a new position.
  CurrentCellValidating             This event is handled when the grid is validating the contents of the active current cell.
  CurrentCellValidated              This event is handled when the grid has completed validating the contents of the active current cell.
  CellButtonClick                   This event is handled when the button in the grid cell is clicked.
  DropDownSelectionChanged          This event is handled when the selected item in the grid drop-down is changed.
  CellClick                         This event is handled when the grid cell is clicked.
  CellCursor                        This event is handled when the cell has a cursor.
  CellMouseHoverEnter               This event is handled when the mouse hits the cell and signals that the cell wants to handle the mouse events. This event is handled before the CellMouseHover event.
  CellMouseHover                    This event is handled when the mouse is moved over a grid cell.
  CellMouseHoverLeave               This event is handled when the mouse leaves a cell.
  CellMouseDown                     This event is handled when the mouse button is pressed.
  CellMouseMove                     This event is handled when the mouse is moved over the cell.
  CellMouseUp                       This event is handled when the mouse button is released.
  CellCancelMode                    This event is handled when any current user interaction is canceled, example-Cancel select cells when Escape key is pressed.
  CellRestoreMode                   This event is handled when a cell is trying to restore the canceled changes.
  ResizingColumns                   This event is handled when the user is about to resize a column or is in the process of re-sizing a column.
  QueryAllowDragColumn              This event is handled when the user hovers over a column header  or drags a column header using mouse.
  ResizingRows                      This event is handled when the user is about to resize a row or is in the process of re-sizing a row.
  --------------------------------- -----------------------------------------------------------------------------------------------------------------------------------------------------------------------
:::

 

 

[]{#related-topics}
::::::
