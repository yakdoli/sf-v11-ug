::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Docking Events {#docking-events style="tab-stops: 0pt"}

 

[]{#p84}The Essential Tools DockingManager provides the functionality for creating and working with enhanced docking windows that support attaching to a host form\'s border, dragging around and docking to different edges within the form and also be dragged off the host form and floated as an individual top-level window.

 

The Essential Tools docking framework allows just about any child control on a form to be made into a fully qualified docking window. The Docking manager provides programmatic access to the interaction between these dockable windows and other complex features like multiple docking levels, nested docking, tabbed docking, tear-off tabs, autohide mode, state persistence etc., by raising several events.

 

The list of events and a detailed explanation about each of them is given in the following sections.

 

::: {align="center"}
+-----------------------------------+-----------------------------------------------------------------------------------------+
| Docking Events                    | Description                                                                             |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| AutoHideAnimationStart            | The AutoHideAnimationStart event occurs just before the start of an autohide animation. |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| AutoHideAnimationStop             | The AutoHideAnimationStop event occurs                                                  |
|                                   |                                                                                         |
|                                   | immediately after the end of an autohide                                                |
|                                   |                                                                                         |
|                                   | animation.                                                                              |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| AutoHideTabContextMenu            | This event occurs when the right mouse button is clicked over a AutoHideTabControl.     |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| DockMenuClick                     | This event occurs when the redock context menu item has been clicked.                   |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| ControlMaximized                  | This event occurs after the control is maximized.                                       |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| ControlMaximizing                 | This event occurs before the control is going to maximize.                              |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| ControlMinimized                  | This event occurs after the control is minimized.                                       |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| ControlRestored                   | This event occurs after the control is restored.                                        |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| DockAllow                         | The DockAllow event occurs when a docking                                               |
|                                   |                                                                                         |
|                                   | window is dragged over a potential dock target.                                         |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| DockContextMenu                   | The DockContextMenu event occurs when the                                               |
|                                   |                                                                                         |
|                                   | right mouse button is clicked over a docking                                            |
|                                   |                                                                                         |
|                                   | window\'s caption.                                                                      |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| DockControlActivated              | The DockControlActivated event occurs when a                                            |
|                                   |                                                                                         |
|                                   | dockable control gets activated.                                                        |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| DockControlDeactivated            | The DockControlDeactivated event occurs when a                                          |
|                                   |                                                                                         |
|                                   | dockable control gets deactivated.                                                      |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| DockStateChanged                  | The DockStateChanged event occurs immediately                                           |
|                                   |                                                                                         |
|                                   | after a dock operation.                                                                 |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| DockStateChanging                 | The DockStateChanging event occurs just before                                          |
|                                   |                                                                                         |
|                                   | a dock operation takes place.                                                           |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| DockStateUnavailable              | The DockStateUnavailable event occurs if                                                |
|                                   |                                                                                         |
|                                   | serialized information is not available for a                                           |
|                                   |                                                                                         |
|                                   | dockable control when loading a persisted dock                                          |
|                                   |                                                                                         |
|                                   | state.                                                                                  |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| DockVisibilityChanged             | The DockVisibilityChanged event occurs after a                                          |
|                                   |                                                                                         |
|                                   | control\'s DockVisibility state has changed.                                            |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| DockVisibilityChanging            | The DockVisibilityChanging event occurs during                                          |
|                                   |                                                                                         |
|                                   | a control\'s DockVisibility state is changing.                                          |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| DragAllow                         | The DragAllow event occurs when a docking                                               |
|                                   |                                                                                         |
|                                   | window is about to be dragged.                                                          |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| DragFeedbackStart                 | The DragFeedbackStart event occurs just before                                          |
|                                   |                                                                                         |
|                                   | the start of feedback of a drag operation.                                              |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| DragFeedbackStop                  | The DragFeedbackStop event occurs immediately                                           |
|                                   |                                                                                         |
|                                   | after the end of feedback of a drag operation.                                          |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| ImageListChanged                  | Occurs when the ImageList property changes.                                             |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| InitializeControlOnLoad           | The InitializeControlOnLoad event occurs when                                           |
|                                   |                                                                                         |
|                                   | the DockingManager is not able to locate a                                              |
|                                   |                                                                                         |
|                                   | control during a LoadDockState call.                                                    |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| NewDockStateBeginLoad             | The NewDockStateBeginLoad event occurs just                                             |
|                                   |                                                                                         |
|                                   | before a new dock state is loaded.                                                      |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| NewDockStateEndLoad               | The NewDockStateEndLoad event occurs                                                    |
|                                   |                                                                                         |
|                                   | immediately after a new dock state has been                                             |
|                                   |                                                                                         |
|                                   | loaded.                                                                                 |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| ProvideGraphicsItems              | The ProvideGraphicsItems event occurs whenever                                          |
|                                   |                                                                                         |
|                                   | a dockable control\'s caption needs to be painted.                                      |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| ProvidePersistenceID              | Lets you specify a unique ID used to distinguish                                        |
|                                   |                                                                                         |
|                                   | the persistence information of different instances                                      |
|                                   |                                                                                         |
|                                   | of the Form type.                                                                       |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| TransferredToManager              | The TransferredToManager event occurs after a                                           |
|                                   |                                                                                         |
|                                   | dockable control that previously belonged to some                                       |
|                                   |                                                                                         |
|                                   | other DockingManager has been transferred to the                                        |
|                                   |                                                                                         |
|                                   | docking layout hosted by this DockingManager.                                           |
+-----------------------------------+-----------------------------------------------------------------------------------------+
| TransferringFromManager           | The TransferringFromManager event occurs when                                           |
|                                   |                                                                                         |
|                                   | a dockable control hosted by this                                                       |
|                                   |                                                                                         |
|                                   | DockingManager is about to be transferred to the                                        |
|                                   |                                                                                         |
|                                   | docking layout hosted by some other                                                     |
|                                   |                                                                                         |
|                                   | DockingManager.                                                                         |
+-----------------------------------+-----------------------------------------------------------------------------------------+
:::

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Docking](ms-xhelp:///?Id=09967d16-4838-478b-a0a4-d09bf40be9f7){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}AutoHide Animation](ms-xhelp:///?Id=d6956b6d-67db-4bea-9ed0-3764ec9d6d3b){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Context Menu](ms-xhelp:///?Id=a06f4e14-de6c-46ab-b8d4-96583cf837b8){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Docked Control](ms-xhelp:///?Id=1a8b9166-6263-46c5-abc0-8d0a598dd38d){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Dock State](ms-xhelp:///?Id=8ef0a5f1-e570-4aa6-bc93-1d526906a606){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Dock Visibility State](ms-xhelp:///?Id=4d160e2c-b377-45fa-aafe-980d28e46ce8){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Drag Events](ms-xhelp:///?Id=343eed91-37ad-49b0-a39a-80f0f41f3594){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Linked Managers](ms-xhelp:///?Id=13735e2d-8ad7-4839-83a3-713930fafdc7){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ImageListChanged Event](ms-xhelp:///?Id=6836e039-6b1f-4a4f-882c-10c8b59cf6ec){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}InitializeControlOnLoad Event](ms-xhelp:///?Id=12cbb776-eb4e-46cb-9f1f-d978d665ac1a){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ProvideGraphicsItems Event](ms-xhelp:///?Id=fc7a461c-bec0-4333-88a8-329d9b1dde55){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}ProvidePersistenceID Event](ms-xhelp:///?Id=9c2fedc5-1c15-4064-9b8d-3bc615134998){style="TEXT-DECORATION: none"}
::::
