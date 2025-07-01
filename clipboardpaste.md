::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### ClipboardPaste {#clipboardpaste style="tab-stops: 0pt"}

This event gets fired when some grid data is being pasted from the clipboard. Inside this event handler, you can check for the data and range of cells being pasted and cancel the operation if you don't want to paste the data. You can also provide custom formatted data for saving into grid cells. It receives an argument of type GridCutCopyPasteEventArgs containing data related to this event. The following are the event argument properties.

**[]{style="COLOR: #15428b"}** 

Table 36: Property

::: {align="center"}
  ------------ ------------------------------------------------------------------------------------------------------------
  Property     Description
  DataObject   Data being pasted.
  RangeList    List of cell ranges that are selected for pasting.
  Handled      When true, indicates that the event has been handled and no further processing of the event should happen.
  ------------ ------------------------------------------------------------------------------------------------------------
:::

[]{style="COLOR: #15428b"} 

Example

 

This event can be triggered using the following code:    

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                     |
|                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                       |
|                                                                                                                                                                                |
| [gridControl.Model.ClipboardPaste += [new]{style="COLOR: blue"} [GridCutPasteEventHandler]{style="COLOR: #2b91af"}(Model_ClipboardPaste);]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

Event Handler

[]{style="COLOR: #15428b"} 

The following event handler sets up new data for clipboard paste.

**[]{style="COLOR: #15428b"}** 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                        |
|                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                   |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Model_ClipboardPaste([object]{style="COLOR: blue"} sender, GridCutPasteEventArgs e)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                   |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
|                                                                                                                                                                                   |
| [    [if]{style="COLOR: blue"} (e.RangeList.Contains(GridRangeInfo.Row(2)))]{style="FONT-FAMILY: 'Courier New'"}                                                                  |
|                                                                                                                                                                                   |
| [    {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                   |
| [        [string]{style="COLOR: blue"} newData = [\"Data for Row2\"]{style="COLOR: #a31515"};]{style="FONT-FAMILY: 'Courier New'"}                                                |
|                                                                                                                                                                                   |
| [        e.DataObject = [new]{style="COLOR: blue"} DataObject(newData);]{style="FONT-FAMILY: 'Courier New'"}                                                                      |
|                                                                                                                                                                                   |
| [        e.Handled = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                   |
| [    }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                   |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                           |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
::::
