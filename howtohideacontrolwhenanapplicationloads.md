::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to hide a control when an application loads? {#how-to-hide-a-control-when-an-application-loads style="tab-stops: 0pt"}

**[]{style="COLOR: #15428b; FONT-SIZE: 14pt"}** 

This is done programmatically, by calling SetHiddenOnLoad method or through Designer, by setting **HiddenOnLoad** property to true.

[]{style="COLOR: #15428b"} 

::: {align="center"}
+-----------------------------------+--------------------------------------------------------------------------+
| Method                            | Description                                                              |
+-----------------------------------+--------------------------------------------------------------------------+
| SetHiddenOnLoad                   | Hides the docked control when the application loads. The parameters are, |
|                                   |                                                                          |
|                                   | *[]{style="COLOR: black; FONT-SIZE: 8pt"}*                               |
|                                   |                                                                          |
|                                   | *Ctrl* - Indicates the docked control.                                   |
|                                   |                                                                          |
|                                   | *bhidden* - Value indicating true or false.                              |
+-----------------------------------+--------------------------------------------------------------------------+
:::

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                    |
|                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                              |
|                                                                                                                                                                                                   |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SetHiddenOnLoad([this]{style="COLOR: blue"}.listBox1, [true]{style="COLOR: blue"});]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                           |
|                                                                                                                                                                                              |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                         |
|                                                                                                                                                                                              |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SetHiddenOnLoad([Me]{style="COLOR: blue"}.listBox1, [True]{style="COLOR: blue"})]{style="FONT-FAMILY: 'Courier New'"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p156} 

[]{#related-topics}
::::
