::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Excel Like Drag and Drop {#excel-like-drag-and-drop style="tab-stops: 0pt"}

The Excel-like Drag and Drop feature enables dragging content with their styles from cells to different locations and grids.

You can use this feature to copy data to one or more locations.

 

You can use this feature by using the following code:

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [this]{style="FONT-FAMILY: Consolas; COLOR: blue"}[.grid.AllowDragDrop = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: Consolas"}                                                              |
|                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: Consolas; COLOR: blue"}[.grid.Model.Options.DataObjectConsumerOptions = [GridDataObjectConsumerOptions]{style="COLOR: #2b91af"}.Styles;]{style="FONT-FAMILY: Consolas"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

Excel Like Drag and Drop has the following features:

 

[·      ]{style="FONT-FAMILY: Symbol"}Uses IDataObject to copy, store, and retrieve data.

[·    ]{style="FONT-FAMILY: Symbol; FONT-SIZE: 11pt"}Uses DragDrop API, which is available in WPF, to initiate drag-and-drop.**[]{style="FONT-SIZE: 11pt"}**

**[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}** 

Table 19: Property[]{style="COLOR: #15428b"}

::: {align="center"}
+-------------------------------+-------------------------------------------------------------------------------------------------------------------------+------------------+------------------+---------------------------------------------------------------------------------------------------------------------------------------------+
| Name of the Property          | Description                                                                                                             | Type of Property | Value it Accepts | PropertySyntax                                                                                                                              |
+-------------------------------+-------------------------------------------------------------------------------------------------------------------------+------------------+------------------+---------------------------------------------------------------------------------------------------------------------------------------------+
| AllowDragDrop                 | Allows dragging and dropping content and enables ExcelLike MouseController, which helps in the drag-and-drop operation. | Normal           | Boolean          |  [this]{style="COLOR: blue"}.grid.AllowDragDrop = [true]{style="COLOR: blue"};                                                              |
|                               |                                                                                                                         |                  |                  |                                                                                                                                             |
|                               |                                                                                                                         |                  |                  | **[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}**                                                                        |
+-------------------------------+-------------------------------------------------------------------------------------------------------------------------+------------------+------------------+---------------------------------------------------------------------------------------------------------------------------------------------+
| GridDataObjectConsumerOptions | Gets or sets the enum value for the DragDrop Consumer Option.                                                           | Normal           | Enum             |  [this]{style="COLOR: blue"}.grid.Model.Options.DataObjectConsumerOptions = [GridDataObjectConsumerOptions]{style="COLOR: #2b91af"}.Styles; |
|                               |                                                                                                                         |                  |                  |                                                                                                                                             |
|                               |                                                                                                                         |                  |                  | **[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}**                                                                        |
+-------------------------------+-------------------------------------------------------------------------------------------------------------------------+------------------+------------------+---------------------------------------------------------------------------------------------------------------------------------------------+
| DragDropDropTargetFlags       | Gets or sets the enum value for values that can be copied or moved and provides other options for DragDropTargetFlags.  | Normal           | Enum             |   [this]{style="COLOR: blue"}.grid.Model.Options.DragDropDropTargetFlags                                                                    |
|                               |                                                                                                                         |                  |                  |                                                                                                                                             |
|                               |                                                                                                                         |                  |                  | **[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}**                                                                        |
+-------------------------------+-------------------------------------------------------------------------------------------------------------------------+------------------+------------------+---------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

Table 20:Event[]{style="COLOR: #15428b"}

::: {align="center"}
+----------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+------------------------------------------------+-------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| When is the event triggered?                                                                                                                 | How is it handled?                                                           | Method (event handler) that handles the event? | What are the event args associated? | Purpose of the Event                                                                                                                                                                         |
+----------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+------------------------------------------------+-------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Occurs when the user releases the mouse over a cell at the end of an OLE drag-and-drop operation and before the data is applied to the grid. | Handled by setting the Handled flag as True.                                 | GridOleDropAtRowColEventHandler                | GridOleDropAtRowColEventArgs        | This event allows you to customize the paste data behavior.                                                                                                                                  |
|                                                                                                                                              |                                                                              |                                                |                                     |                                                                                                                                                                                              |
|                                                                                                                                              |                                                                              |                                                |                                     |                                                                                                                                                                                              |
+----------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+------------------------------------------------+-------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| The event is initiated when the user rolls the mouse over the edge of a selected range.                                                      | You can disallow the specified range to be used as the OLE Data Source when\ | GridExcelLikeDragRangeEventHandler             | GridQueryCanDragRangeEventArgs      | GridQueryCanOleDragRangeEventArgs is a custom event argument class used by the GridControlBase.QueryCanOleDragRange event to determine if a specified range can serve as an OLE drag source. |
|                                                                                                                                              | assigning true to "Cancel" flag.                                             |                                                |                                     |                                                                                                                                                                                              |
|                                                                                                                                              |                                                                              |                                                |                                     |                                                                                                                                                                                              |
+----------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+------------------------------------------------+-------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| This event is initiated when a user drags a range of selected cells by using the OLE drag-and-drop.                                          | Handled by setting the Handled flag as True.                                 | GridQueryOleDataSourceDataEventHandler         | GridQueryOleDataSourceDataEventArgs | This event allows you to provide customized clipboard formats or add support for pasting the additional clipboard content.                                                                   |
|                                                                                                                                              |                                                                              |                                                |                                     |                                                                                                                                                                                              |
|                                                                                                                                              |                                                                              |                                                |                                     |                                                                                                                                                                                              |
+----------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+------------------------------------------------+-------------------------------------+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

 

 

[]{#related-topics}
:::::
