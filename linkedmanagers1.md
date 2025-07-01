::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Linked Managers {#linked-managers style="tab-stops: 0pt"}

This section covers the following events:

[]{style="COLOR: #15428b"} 

###### []{#_TransferredToManager_Event}3.2.3.8.8.1 TransferredToManager Event {#transferredtomanager-event style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

The TransferredToManager event occurs after a dockable control that previously belonged to some other DockingManager has been transferred to the docking layout hosted by the current DockingManager.

[]{style="COLOR: #15428b"} 

Event Data

**[]{style="COLOR: #15428b"}** 

The event handler receives an argument of type TransferManagerEventArgs containing data related to this event. The following TransferManagerEventArgs properties provide information specific to this event.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  --------- ----------------------------------------------------
  Member    Description
  Control   Gets the control which is undergoing the transfer.
  --------- ----------------------------------------------------
:::

**[]{style="COLOR: #15428b"}** 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                |
| [// A docking window is being transferred from one docking layout to another.]{style="FONT-FAMILY: 'Courier New'; COLOR: #008100"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                |
| [// Update the control\'s DockingManager reference.]{style="FONT-FAMILY: 'Courier New'; COLOR: #008100"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                |
| [protected void ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DockingManager_TransferredToManager(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[object ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sender, TransferManagerEventArgs args)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                                |
| [{]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                |
| [Console.WriteLine(\"Transferred to Manager Event has been Raised\");]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                |
| [DockableControlBase dockablecontrol = args.Control ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[as ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DockableControlBase;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                          |
|                                                                                                                                                                                                                                                                                                                |
| [dockablecontrol.CurrentDockingManager = sender ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[as ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DockingManager;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                   |
|                                                                                                                                                                                                                                                                                                                |
| [Console.WriteLine(\"HostControl Name (Target Page Name) : \"+dockablecontrol.CurrentDockingManager.HostControl.Name);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                |
| [}]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                          |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                      |
| [Protected]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} DockingManager_TransferredToManager([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} args [As]{style="COLOR: blue"} TransferManagerEventArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                      |
| [Console.WriteLine([\"Transferred to Manager Event has been Raised\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dockablecontrol [As]{style="COLOR: blue"} DockableControlBase = [CType]{style="COLOR: blue"}(ConversionHelpers.AsWorkaround(args.Control, [GetType]{style="COLOR: blue"}(DockableControlBase)), DockableControlBase)]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                                                                                                                                                                                                      |
| [dockablecontrol.CurrentDockingManager = [CType]{style="COLOR: blue"}(ConversionHelpers.AsWorkaround(sender, [GetType]{style="COLOR: blue"}(DockingManager)), DockingManager)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                      |
| [Console.WriteLine([\"HostControl Name (Target Page Name) : \"]{style="COLOR: maroon"} + dockablecontrol.CurrentDockingManager.HostControl.Name)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                      |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                              |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

Sample

[]{style="COLOR: #15428b"} 

A sample which demonstrates the Linked Managers concept is available in the below sample installation path.

 

..My Documents\\Syncfusion\\EssentialStudio\\***Version Number***\\Windows\\Tools.Windows\\Samples\\2.0\\Docking Package\\LinkedManagers

###### []{#p115}[]{#_TransferringFromManager_Event}3.2.3.8.8.2 TransferringFromManager Event {#transferringfrommanager-event style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

The TransferringFromManager event occurs when a dockable control hosted by a DockingManager is about to be transferred to the docking layout hosted by some other DockingManager.

[]{style="COLOR: #15428b"} 

Event Data

**[]{style="COLOR: #15428b"}** 

The event handler receives an argument of type TransferManagerEventArgs containing data related to this event. The following TransferManagerEventArgs property provide information specific to this event.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  --------- ----------------------------------------------------
  Member    Description
  Control   Gets the control which is undergoing the transfer.
  --------- ----------------------------------------------------
:::

**[]{style="COLOR: #15428b"}** 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                   |
| [//The TransferringFromManager event occurs when a dockable control hosted by this DockingManager is]{style="FONT-FAMILY: 'Courier New'; COLOR: #008100"}                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                   |
| [//about to be transferred to the docking layout hosted by some other DockingManager.]{style="FONT-FAMILY: 'Courier New'; COLOR: #008100"}                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                   |
| [protected void ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DockingManager_TransferringFromManager(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[object ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[sender, TransferManagerEventArgs args)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                                   |
| [{]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                   |
| [Console.WriteLine(\"Transferring From Manager Event has been raised\");]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                   |
| [DockableControlBase dockablecontrol = args.Control ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[as ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DockableControlBase;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                             |
|                                                                                                                                                                                                                                                                                                                   |
| [dockablecontrol.CurrentDockingManager = sender ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[as ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[DockingManager; ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                     |
|                                                                                                                                                                                                                                                                                                                   |
| [Console.WriteLine(\"HostControl name : \"+dockablecontrol.CurrentDockingManager.HostControl.Name);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                   |
| [}]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                             |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                         |
| [\'The TransferringFromManager event occurs when a dockable control hosted by this DockingManager is]{style="FONT-FAMILY: 'Courier New'; COLOR: #008100"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                         |
| [\'about to be transferred to the docking layout hosted by some other DockingManager.]{style="FONT-FAMILY: 'Courier New'; COLOR: #008100"}                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                                                                                                         |
| [Protected]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} DockingManager_TransferringFromManager([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} args [As]{style="COLOR: blue"} TransferManagerEventArgs)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                         |
| [Console.WriteLine([\"Transferring From Manager Event has been raised\"]{style="COLOR: maroon"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                         |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dockablecontrol [As]{style="COLOR: blue"} DockableControlBase = [CType]{style="COLOR: blue"}(ConversionHelpers.AsWorkaround(args.Control, [GetType]{style="COLOR: blue"}(DockableControlBase)), DockableControlBase)]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                                                                                                                                                                                                                                                         |
| [dockablecontrol.CurrentDockingManager = [CType]{style="COLOR: blue"}(ConversionHelpers.AsWorkaround(sender, [GetType]{style="COLOR: blue"}(DockingManager)), DockingManager)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                         |
| [Console.WriteLine([\"HostControl name : \"]{style="COLOR: maroon"} + dockablecontrol.CurrentDockingManager.HostControl.Name)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                                         |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

Sample

[]{style="COLOR: #15428b"} 

A sample which demonstrates the Linked Managers concept is available in the below sample installation path.

 

..My Documents\\Syncfusion\\EssentialStudio\\***Version Number***\\Windows\\Tools.Windows\\Samples\\2.0\\Docking Package\\LinkedManagers

 

[]{#related-topics}
:::::
