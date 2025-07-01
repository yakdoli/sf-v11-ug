::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Properties, Methods and Events tables {#properties-methods-and-events-tables style="tab-stops: 0pt"}

###### 3.14.7.7.2.1        Methods {#methods style="tab-stops: 0pt"}

+----------------------------------+----------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+----------------------------+-------------------------------+-----------------------------------------------------------------------------------------------------------+
| Method                           | Description                                                                                                    | Parameters                                              | Type                       | Return Type                   | Reference links                                                                                           |
+----------------------------------+----------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+----------------------------+-------------------------------+-----------------------------------------------------------------------------------------------------------+
| **AddToTargetManagersList**      |  Adds the DockingManager to the Target Providers List, belonging to the current manager. The parameter is,     |  (DockingManager dockingmanager)                        | NA                         | void                          | http://help.syncfusion.com/ug_92/User%20Interface/Windows%20Forms/Tools/index.htm                         |
|                                  |                                                                                                                |                                                         |                            |                               |                                                                                                           |
|                                  |  dockingmgr - docking manager to be added to the target list.                                                  |                                                         |                            |                               |                                                                                                           |
+----------------------------------+----------------------------------------------------------------------------------------------------------------+---------------------------------------------------------+----------------------------+-------------------------------+-----------------------------------------------------------------------------------------------------------+
| **RemoveFromTargetManagersList** | Removes the DockingManager from the Target Providers List, belonging to the current manager. The parameter is, | [(DockingManager dockingmanager)]{style="COLOR: black"} | [NA]{style="COLOR: black"} | [void ]{style="COLOR: black"} | [http://help.syncfusion.com/ug_92/User%20Interface/Windows%20Forms/Tools/index.htm]{style="COLOR: black"} |
|                                  |                                                                                                                |                                                         |                            |                               |                                                                                                           |
|                                  |  *dockingmgr* - docking manager to be removed from the target list.[]{style="COLOR: #c00000"}                  |                                                         |                            |                               |                                                                                                           |
+==================================+================================================================================================================+=========================================================+============================+===============================+===========================================================================================================+

 

###### 3.14.7.7.2.2        Events {#events style="tab-stops: 0pt"}

  Event                         Description                                                                                                                                                                                               Arguments                                                                                                              Type                                               Reference links
  ----------------------------- --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- ---------------------------------------------------------------------------------------------------------------------- -------------------------------------------------- -------------------------------------------------------------------------------------------------------------------------------------
  **TransferredToManager**      The TransferredToManager event occurs after a dockable control that previously belonged to some other Docking Manager has been transferred to the docking layout hosted by the current Docking Manager.   [DockingManager PreviousManager, FrameworkElement TargetElement, DockingManager TargetManager]{style="COLOR: black"}   [TransferManagerEventArgs]{style="COLOR: black"}   [http://help.syncfusion.com/ug_92/User%20Interface/Windows%20Forms/Tools/index.htm]{style="COLOR: black"}[]{style="COLOR: #c00000"}
  **TransferringFromManager**   The TransferringFromManager event occurs when a dockable control hosted by a Docking Manager is about to be transferred to the docking layout hosted by some other Docking Manager.                       [DockingManager PreviousManager, FrameworkElement TargetElement, DockingManager TargetManager]{style="COLOR: black"}   [TransferManagerEventArgs]{style="COLOR: black"}   [http://help.syncfusion.com/ug_92/User%20Interface/Windows%20Forms/Tools/index.htm]{style="COLOR: black"}[]{style="COLOR: #c00000"}

 

[]{#related-topics}
:::
