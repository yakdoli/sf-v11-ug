::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### ClipboardCanCopy {#clipboardcancopy style="TEXT-ALIGN: justify; tab-stops: 0pt"}

This event is triggered when some grid data is about to be copied to the clipboard. Inside this event handler, you can check for the data and range of cells that are going to be copied, and cancel the operation if you don't want to copy the data.

1.   The grid cell data and range of cells that are going to be moved to the clipboard can be accessed by using the **DataObject** and **RangeList** properties.

2.   If you don't want to move the data to the clipboard, you can cancel the operation by setting **e.Cancel** to **true**.

 

Properties

  ------------------------------------------------------------ ------------------------------------------------------------------------------------------------------------
  **[Property]{style="COLOR: black"}**                         **[Description]{style="COLOR: black"}[]{style="COLOR: black"}**
  DataObject[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'"}   Data to be copied.[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'"}
  RangeList                                                    List of cell ranges that are selected for copying.
  Handled                                                      When true, indicates that the event has been handled and no further processing of the event should happen.
  ------------------------------------------------------------ ------------------------------------------------------------------------------------------------------------

 

[]{#related-topics}
:::
