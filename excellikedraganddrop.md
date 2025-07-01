::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Excel Like Drag and Drop {#excel-like-drag-and-drop style="tab-stops: 0pt"}

 

This Feature enables you to drag the content of cells including styles to different position of the grid and also to other grids. This enables you to copy data to one or more place.

**IDataObject** is used to copy data, store information and also to retrieve data.  DragDrop API available in WPF is used to initiate drag and drop operation in GridControl.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"}** 

Table 12: Drag and drop operation

::: {align="center"}
+-------------------------------+-------------------------------------------------------------------------------------------------------------------+------------------+------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Name of the Property          | Description                                                                                                       | Type of Property | Value it Accepts | PropertySyntax                                                                                                                                                               |
+-------------------------------+-------------------------------------------------------------------------------------------------------------------+------------------+------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| AllowDragDrop                 | Enables ExcelLike MouseController which helps in Drag and Drop Operation.                                         | Normal           | Boolean          | [ [this]{style="COLOR: blue"}.grid.AllowDragDrop = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: Consolas"}                                                              |
|                               |                                                                                                                   |                  |                  |                                                                                                                                                                              |
|                               |                                                                                                                   |                  |                  |                                                                                                                                                                              |
+-------------------------------+-------------------------------------------------------------------------------------------------------------------+------------------+------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| GridDataObjectConsumerOptions | Gets/Sets enum value for DragDrop Consumer Option.                                                                | Normal           | Enum             | [ [this]{style="COLOR: blue"}.grid.Model.Options.DataObjectConsumerOptions = [GridDataObjectConsumerOptions]{style="COLOR: #2b91af"}.Styles;]{style="FONT-FAMILY: Consolas"} |
|                               |                                                                                                                   |                  |                  |                                                                                                                                                                              |
|                               |                                                                                                                   |                  |                  |                                                                                                                                                                              |
+-------------------------------+-------------------------------------------------------------------------------------------------------------------+------------------+------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| DragDropDropTargetFlags       | Gets/Sets enum value for value that can be copied/Moved and also provides other options for DragDropTargetFlags.. | Normal           | Enum             | [  [this]{style="COLOR: blue"}.grid.Model.Options.DragDropDropTargetFlags]{style="FONT-FAMILY: Consolas"}                                                                    |
|                               |                                                                                                                   |                  |                  |                                                                                                                                                                              |
|                               |                                                                                                                   |                  |                  |                                                                                                                                                                              |
+-------------------------------+-------------------------------------------------------------------------------------------------------------------+------------------+------------------+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

Table 13

::: {align="center"}
+-----------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+------------------------------------------------+-------------------------------------+----------------------------------------------------------------------------------------------------------------+
| When is the event triggered?                                                                                                                  | How is it handled?                                                           | Method (event handler) that handles the event? | What are the event args associated? | Purpose of the event                                                                                           |
+-----------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+------------------------------------------------+-------------------------------------+----------------------------------------------------------------------------------------------------------------+
| Occurs when the user releases the mouse over a cell at the end of an OLE drag-and-drop operation and before the data are applied to the grid. |                                                                              | GridOleDropAtRowColEventHandler                | GridOleDropAtRowColEventArgs        | This event lets you toprovide your own customized paste data behavior.                                         |
|                                                                                                                                               |                                                                              |                                                |                                     |                                                                                                                |
|                                                                                                                                               | Handled by setting Handled flag as True.                                     |                                                |                                     |                                                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+------------------------------------------------+-------------------------------------+----------------------------------------------------------------------------------------------------------------+
| The event is fired when the user hovers the mouse over the edge of a selected range.                                                          |     You can disallow the specified range to be used as OLE Data Source when\ | GridExcelLikeDragRangeEventHandler             | GridQueryCanDragRangeEventArgs      |    GridQueryCanOleDragRangeEventArgs is a custom event argument class used by the\                             |
|                                                                                                                                               | you assign true to "Cancel" flag.                                            |                                                |                                     |     GridControlBase.QueryCanOleDragRange event to determine whether\                                           |
|                                                                                                                                               |                                                                              |                                                |                                     | a specified range can serve as an OLE drag source.                                                             |
|                                                                                                                                               |                                                                              |                                                |                                     |                                                                                                                |
|                                                                                                                                               |                                                                              |                                                |                                     |                                                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+------------------------------------------------+-------------------------------------+----------------------------------------------------------------------------------------------------------------+
| This event is fired when a user starts dragging a range of selected cells\                                                                    | Handled by setting  Handled flag as True                                     | GridQueryOleDataSourceDataEventHandler         | GridQueryOleDataSourceDataEventArgs | This event lets you supply your own clipboard formats or add support for pasting additional clipboard content. |
|      using OLE drag-and-drop.                                                                                                                 |                                                                              |                                                |                                     |                                                                                                                |
|                                                                                                                                               |                                                                              |                                                |                                     |                                                                                                                |
|                                                                                                                                               |                                                                              |                                                |                                     |                                                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------+------------------------------------------------------------------------------+------------------------------------------------+-------------------------------------+----------------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image61_140.png){border="0"}Note:  Silverlight Grid do not support OLE Drag and Drop i.e from one grid to another but within itself.
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Following are the properties for Enum properties:

Available Enum Values GridDataObjectConsumerOptions:

::: {align="center"}
+-----------------------------------+----------------------------------------------------------------------------------------------------------+
| Enum Value                        | Details                                                                                                  |
+-----------------------------------+----------------------------------------------------------------------------------------------------------+
| None                              | No default data objects supported.                                                                       |
|                                   |                                                                                                          |
|                                   |                                                                                                          |
+-----------------------------------+----------------------------------------------------------------------------------------------------------+
| Styles                            | Enable styles (internal) data objects. This allows you to drag / copy / paste complete cell information. |
|                                   |                                                                                                          |
|                                   |                                                                                                          |
+-----------------------------------+----------------------------------------------------------------------------------------------------------+
| Text                              | Enable text data format. This allows you to drag cell values.                                            |
|                                   |                                                                                                          |
|                                   |                                                                                                          |
+-----------------------------------+----------------------------------------------------------------------------------------------------------+
| All                               | Enable support for all default data objects.                                                             |
+-----------------------------------+----------------------------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

Available Enum Values for DragDropTargetFlags:

::: {align="center"}
+-----------------------------------+----------------------------------------------------------------+
| Enum Value                        | Details                                                        |
+-----------------------------------+----------------------------------------------------------------+
| Disabled                          | Disable drop target.                                           |
|                                   |                                                                |
|                                   |                                                                |
+-----------------------------------+----------------------------------------------------------------+
| Text                              | Force dragging of CF_TEXT clipboard format.                    |
|                                   |                                                                |
|                                   |                                                                |
+-----------------------------------+----------------------------------------------------------------+
| Styles                            | Force dragging of internal styles format.                      |
|                                   |                                                                |
|                                   |                                                                |
+-----------------------------------+----------------------------------------------------------------+
| EdgeScroll                        | Enable edgescroll when user drags to the corner of the window. |
|                                   |                                                                |
|                                   |                                                                |
+-----------------------------------+----------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: #15428b; FONT-SIZE: 9pt"} 

[]{#related-topics}
::::::::
