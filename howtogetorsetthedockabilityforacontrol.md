::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to get or set the dock ability for a control? {#how-to-get-or-set-the-dock-ability-for-a-control style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

The current dock ability for the controls can be retrieved or set using the below methods.

[]{style="COLOR: #15428b"} 

::: {align="center"}
+-----------------------------------+---------------------------------------------------------------------------------+
| Methods                           | Description                                                                     |
+-----------------------------------+---------------------------------------------------------------------------------+
| GetDockAbility                    | Retrieves the dock ability of the control. The parameter is,                    |
|                                   |                                                                                 |
|                                   | *[]{style="COLOR: black; FONT-SIZE: 8pt"}*                                      |
|                                   |                                                                                 |
|                                   | *Ctrl* - Indicates the docked control for which DockAbility has to be obtained. |
+-----------------------------------+---------------------------------------------------------------------------------+
| SetDockAbility                    | Sets the dock ability of the control.                                           |
|                                   |                                                                                 |
|                                   |                                                                                 |
|                                   |                                                                                 |
|                                   | *Ctrl* - Indicates the docked control for which DockAbility need to be set.     |
+-----------------------------------+---------------------------------------------------------------------------------+
:::

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                     |
|                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                               |
|                                                                                                                                                                                                                    |
| [//Getting the Dock Ability]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                     |
|                                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.GetDockAbility([this]{style="COLOR: blue"}.panel2);]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                               |
|                                                                                                                                                                                                                    |
| [//Setting the Dock Ability]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                     |
|                                                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SetDockAbility([this]{style="COLOR: blue"}.panel2, [\"Bottom, Horizontal\"]{style="COLOR: maroon"});]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                            |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                          |
|                                                                                                                                                                                                               |
| [\'Getting the Dock Ability]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                |
|                                                                                                                                                                                                               |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.GetDockAbility([Me]{style="COLOR: blue"}.panel2)]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                                               |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                        |
|                                                                                                                                                                                                               |
| [\'Setting the Dock Ability]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                |
|                                                                                                                                                                                                               |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.SetDockAbility([Me]{style="COLOR: blue"}.panel2, [\"Bottom, Horizontal\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
::::
