::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Events {#events style="tab-stops: 0pt"}

 

The important events in Grid control and Grid Data Bound Grid are as follows.

 

**Current Cell Related Events**

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellAcceptedChanges**-Occurs when the grid accepts changes made to the active current cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellMoved**-Occurs when current cell is moved to the new position.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellMoving**-Occurs when the current cell is about to be moved to a new position.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellMoveFailed-**Occurs when the current cell movement to a new position fails.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellActivating**-Occurs before the grid activates the specified cell as current cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellActivated**-Occurs after the grid activates the specified cell as current cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellActivateFailed**-Occurs after the grid fails to activate a specific cell as current cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellDeleting**-Occurs when the user presses the Delete key on an active current cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellStartEditing**-Occurs before the current cell switches into editing mode.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellChanging**-Occurs when the user wants to modify contents of the current cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellChanged**-Occurs when the user changes contents of the current cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellDeactivating**-Occurs before the grid deactivates the current cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellShowedDropDown**-Occurs after the drop-down is displayed.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellCloseDropDown**-Occurs when the drop-down in the current cell is closed.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellShowingDropDown**-Occurs when the drop-down is about to be shown.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellValidating**-Occurs when the grid validates content of the active current cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellValidated**-Occurs when the grid has successfully validated the content of the active current cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellAcceptedChanges**-Occurs when the grid accepted changes made to the active current cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellConfirmChangesFailed**-Occurs when the grid could not save changes made to the active current cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellRejectedChanges**-Occurs when the grid rejects changes made to the active current cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellEditingComplete**-Occurs when the grid completes editing mode, i.e., when the active current cell exits the editing mode.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellDeactivated**-Occurs after the grid deactivates current cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellDeactivateFailed**-Occurs after the grid fails to deactivate the current cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellControlGotFocus**-Occurs when the current cell has switched to in-place editing and the control associated with the current cell has received the focus.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellControlLostFocus**-Occurs when the current cell has switched to in-place editing and the control associated with the current cell has lost the focus.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellKeyPress**-Occurs before GridCellRendererBase.OnKeyPress is called.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellKeyDown**-Occurs before GridCellRendererBase.OnKeyDown is called.

[·      ]{style="FONT-FAMILY: Symbol"}**CurrentCellKeyUp**-Occurs before GridCellRendererBase.OnKeyUp is called.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Mouse Related Events

[         ]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}

[·      ]{style="FONT-FAMILY: Symbol"}**CellButtonClicked**-Occurs when the user has clicked on a  button element inside a cell renderer.

[·      ]{style="FONT-FAMILY: Symbol"}**CellClick**-Occurs when user clicks inside a cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CellDoubleClick**-Occurs when the user double-clicks inside a cell.

[·      ]{style="FONT-FAMILY: Symbol"}**CellMouseDown**-Occurs before the OnMouseDown method of a cell\'s renderer is called.

[·      ]{style="FONT-FAMILY: Symbol"}**CellMouseUp**-Occurs before the OnMouseUp method of a cell\'s renderer is called.

[·      ]{style="FONT-FAMILY: Symbol"}**CellMouseHoverEnter**-Occurs before the OnMouseHoverEnter method of a cell\'s renderer is called.

[·      ]{style="FONT-FAMILY: Symbol"}**CellMouseHoverLeave**-Occurs before the OnMouseHoverLeave method of a cell\'s renderer is called.

[·      ]{style="FONT-FAMILY: Symbol"}**CheckBoxClick**-Occurs when the user selects a check box in a cell.

[·      ]{style="FONT-FAMILY: Symbol"}**PushButtonClick**-Occurs when the user clicks a push button of the PushButton cell.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Other Events

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}**Click-**Occurs when control is clicked once.

[·      ]{style="FONT-FAMILY: Symbol"}**DoubleClick-**Occurs when control is double clicked.

[·      ]{style="FONT-FAMILY: Symbol"}**DragDrp**-Occurs when drag-drop operation is completed.

[·      ]{style="FONT-FAMILY: Symbol"}**DragEnter**-Occurs when an object is dragged into the control\'s bounds.

[·      ]{style="FONT-FAMILY: Symbol"}**DragLeave**-Occurs when the object is dragged out of the control\'s bound.

[·      ]{style="FONT-FAMILY: Symbol"}**DragOver**-Occurs when the object is dragged over the control.

[·      ]{style="FONT-FAMILY: Symbol"}**GotFocus**-Occurs when control receives focus.

[·      ]{style="FONT-FAMILY: Symbol"}**LostFocus**-Occurs when control loses focus.

[·      ]{style="FONT-FAMILY: Symbol"}**MouseDown**-Occurs when the mouse pointer is over the control and a mouse button is pressed.

[·      ]{style="FONT-FAMILY: Symbol"}**MouseUp**-Occurs when the mouse pointer is over the control and a mouse button is released.

[·      ]{style="FONT-FAMILY: Symbol"}**MouseEnter**-Occurs when mouse pointer enters the control.

[·      ]{style="FONT-FAMILY: Symbol"}**MouseLeave**-Occurs when mouse pointer leaves the control.

[·      ]{style="FONT-FAMILY: Symbol"}**QueryCanOleDragRange**-Occurs when the user hovers the mouse over the edge of a selected range.

[·      ]{style="FONT-FAMILY: Symbol"}**ResizingColumns**-Occurs when user is resizing a selected range of columns.

[·      ]{style="FONT-FAMILY: Symbol"}**ResizingRows**-Occurs when user is resizing a selected range of rows.

 

[]{#p387} 

 

[]{#related-topics}
:::
