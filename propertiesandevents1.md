::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Properties and Events {#properties-and-events style="tab-stops: 0pt"}

[]{#_Constructors_for_PDF}Properties

+-------------------------------+------------------------------------------------------------------------+----------------------+----------------------+------------------+
| **Property**                  | **Description**                                                        | **Type of Property** | **Value it Accepts** | **Dependencies** |
+-------------------------------+------------------------------------------------------------------------+----------------------+----------------------+------------------+
| NavigationMode                | Used to set the navigation format.                                     | Enum                 | Default              | NA               |
|                               |                                                                        |                      |                      |                  |
|                               |                                                                        |                      | Windows7             |                  |
+-------------------------------+------------------------------------------------------------------------+----------------------+----------------------+------------------+
| AutoPostBackOnCalendarZoomIn  | Used to postback the server while calendar zooms in.                   | Bool                 | True                 | NA               |
|                               |                                                                        |                      |                      |                  |
|                               |                                                                        |                      | False                |                  |
+-------------------------------+------------------------------------------------------------------------+----------------------+----------------------+------------------+
| AutoPostBackOnCalendarZoomOut | This property is used to postback the server while calendar zooms out. | Bool                 | True                 | NA               |
|                               |                                                                        |                      |                      |                  |
|                               |                                                                        |                      | False                |                  |
+-------------------------------+------------------------------------------------------------------------+----------------------+----------------------+------------------+

 

Events

  --------------------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ -----------------------------
  **Name**              **Description**                                                                                                                                                                                        **Arguments**
  ClientSideOnZoomIn    This event is triggered in client-side function while the calendar zooms in. The event arguments (this) have Current View, Selected Date.                                                              This
  ClientSideOnZoomOut   This event is triggered in client-side function while the calendar zooms out. The event arguments (this) have Current View, Selected Date.                                                             This
  OnCalendarZoomIn      This event is triggered on the server side while the calendar zooms in. The event arguments are current view in calendar (Month, Year, FullYear), selected date, selected month, and selected year.    object, ZoomChangeEventArgs
  OnCalendarZoomOut     This event is triggered in the server side while the calendar zooms out. The event arguments have current view in calendar (Month, Year, FullYear), selected date, selected month and selected Year.   object, ZoomChangeEventArgs
  --------------------- ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ -----------------------------

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[]{#related-topics}
:::
