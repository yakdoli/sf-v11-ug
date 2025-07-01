::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### ImageListChanged Event {#imagelistchanged-event style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

When the imagelist property is changed, ImageListChanged event will be raised. Every docked control will have SetDockIcon property to set the icons for the control. When this property is changed, the above event will be triggered.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  --------- ----------------------------------------------------------------------
  Member    Description
  Control   Gets the docked control for which the imagelist property is changed.
  --------- ----------------------------------------------------------------------
:::

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                |
| [//Occurs when the ImageList property changes]{style="FONT-FAMILY: 'Courier New'; COLOR: #008100"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                |
| [private void ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[dockingManager1_ImageListChanged(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[object ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sender, System.EventArgs e)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                |
| [Console.WriteLine(\"ImageList Changed Event Is Triggered\");]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                |
| [//Here the code which set the Docking Icon dynamically.]{style="FONT-FAMILY: 'Courier New'; COLOR: #008100"}                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                |
| [dockingManager1.SetDockIcon(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.panel1,0);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                         |
|                                                                                                                                                                                                                                                                                                |
| [dockingManager1.SetDockIcon(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.panel2,1);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                         |
|                                                                                                                                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                      |
| [\'Occurs when the ImageList property changes]{style="FONT-FAMILY: 'Courier New'; COLOR: #008100"}                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                      |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} dockingManager1_ImageListChanged([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} e [As]{style="COLOR: blue"} System.EventArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                      |
| [Console.WriteLine([\"ImageList Changed Event Is Triggered\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                      |
| [\'Here the code which set the Docking Icon dynamically.]{style="FONT-FAMILY: 'Courier New'; COLOR: #008100"}                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                      |
| [dockingManager1.SetDockIcon([Me]{style="COLOR: blue"}.panel1, 0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                      |
| [dockingManager1.SetDockIcon([Me]{style="COLOR: blue"}.panel2, 1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                      |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p117}[]{#_InitializeControlOnLoad_Event} 

[]{#related-topics}
::::
