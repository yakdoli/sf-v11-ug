::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Linked Managers {#linked-managers style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

Linked Manager concept allows the transfer of a docking window from one form to another form or usercontrol. It is done with a single method call.

 

**AddToTargetManagersList** method will let you add the DockingManager to the Target DockingManagers list, and hence transfers the docking window to the selected target form.

 

**RemoveFromTargetManagersList** method, removes the DockingManager from the TargetManagers List.

 

::: {align="center"}
+-----------------------------------+----------------------------------------------------------------------------------------------------------------+
| Method                            | Description                                                                                                    |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------+
| AddToTargetManagersList           | Adds the DockingManager to the Target Providers List, belonging to the current manager. The parameter is,      |
|                                   |                                                                                                                |
|                                   |                                                                                                                |
|                                   |                                                                                                                |
|                                   | *dockingmgr* - docking manager to be added to the target list.                                                 |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------+
| RemoveFromTargetManagersList      | Removes the DockingManager from the Target Providers List, belonging to the current manager. The parameter is, |
|                                   |                                                                                                                |
|                                   |                                                                                                                |
|                                   |                                                                                                                |
|                                   | *dockingmgr* - docking manager to be removed from the target list.                                             |
+-----------------------------------+----------------------------------------------------------------------------------------------------------------+
:::

**[]{style="COLOR: #15428b"}** 

+---------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                          |
|                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                |
|                                                                                                                                                         |
| [//Control from form2 to be transferred to form1]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                     |
|                                                                                                                                                         |
| [//dockingManager1 an instance of Form1 and dockingManager2 an instance of Form2]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                     |
|                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.AddToTargetManagersList(dockingManager2);]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                   |
|                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                             |
|                                                                                                                                                      |
| [\'Control from form2 to be transferred to form1]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                  |
|                                                                                                                                                      |
| [\'dockingManager1 an instance of Form1 and dockingManager2 an instance of Form2]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                  |
|                                                                                                                                                      |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.AddToTargetManagersList(dockingManager2)]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 8pt"} 

Events during the Transfer of Docking Manager

[]{style="COLOR: #15428b"} 

If any control comes from other docking manager, TransferredToManager event will be handled and if a control is transferred out to other docking managers, TransferredFromManager event will be handled.

[]{style="COLOR: #15428b"} 

Sample

[]{style="COLOR: #15428b"} 

A sample which demonstrates the Linked Managers concept is available in the below sample installation path.

 

..My Documents\\Syncfusion\\EssentialStudio\\***Version Number***\\Windows\\Tools.Windows\\Samples\\2.0\\Docking Package\\LinkedManagers

[]{#related-topics}
::::
