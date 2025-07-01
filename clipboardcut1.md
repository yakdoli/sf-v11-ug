::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### ClipboardCut {#clipboardcut style="TEXT-ALIGN: justify; tab-stops: 0pt"}

This event is fired when some grid data is being moved to the clipboard. Inside this event handler, you can check for the data and range of cells being moved and cancel the operation if you don't want to move the data. You can also provide custom formatted data for moving to clipboard. It receives an argument of type **GridCutCopyPasteEventArgs** containing data related to this event. The following are the event argument properties.

 

 Properties

  ------------------------------------------------------------ ------------------------------------------------------------------------------------------------------------
  **[Property]{style="COLOR: black"}**                         **[Description]{style="COLOR: black"}[]{style="COLOR: black"}**
  DataObject[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'"}   Data to be moved.[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'"}
  RangeList                                                    List of cell ranges that are selected for transfer.
  Handled                                                      When true, indicates that the event has been handled and no further processing of the event should happen.
  ------------------------------------------------------------ ------------------------------------------------------------------------------------------------------------

 

[]{#related-topics}
:::
