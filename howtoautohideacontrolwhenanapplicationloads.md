::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to auto hide a control when an application loads {#how-to-auto-hide-a-control-when-an-application-loads style="tab-stops: 0pt"}

 

A control can be autohidden on loading, by enabling the **AutoHideOnLoad** property through designer or by calling **SetAutoHideOnLoad** method programmatically.

 

::: {align="center"}
+-----------------------------------+------------------------------------------------------------------------------+
| Method                            | Description                                                                  |
+-----------------------------------+------------------------------------------------------------------------------+
| SetAutoHideOnLoad                 | AutoHides the docked control when the application loads. The parameters are, |
|                                   |                                                                              |
|                                   | *[]{style="COLOR: black; FONT-SIZE: 8pt"}*                                   |
|                                   |                                                                              |
|                                   | *Ctrl* - Indicates the docked control.                                       |
|                                   |                                                                              |
|                                   | *bautohide* - Value indicating true or false.                                |
+-----------------------------------+------------------------------------------------------------------------------+
:::

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                      |
|                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                |
|                                                                                                                                                                                                     |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SetAutoHideOnLoad([this]{style="COLOR: blue"}.listBox1, [true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                             |
|                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                           |
|                                                                                                                                                                                                |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.DockingManager1.SetAutoHideOnLoad([Me]{style="COLOR: blue"}.ListBox1, [True]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p154} 

[]{#related-topics}
::::
