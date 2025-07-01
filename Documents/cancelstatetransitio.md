::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### []{#_Ref261334228}[]{#_Cancel_state_transition}Cancel state transition completely

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

State transition can be cancelled using **DockStateChanging** event. This event can be cancelled. The event handler has two parameters- sender object and DockStateChangingEventArgs.

DockStateChangingEventArgs has three properties:

 

  ------------ ----------------------------------------------------------------------------
  Properties   Description
  UIElement    The element which changes the state
  OldState     It contains the previous DockState of the element
  NewState     It contains the new DockState to which the element is going to be changed.
  ------------ ----------------------------------------------------------------------------

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                 |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dockingManager_DockStateChanging([object]{style="COLOR: blue"} sender, [DockStateChangingEventArgs]{style="COLOR: #2b91af"} args)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                 |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                 |
| [           args.Cancel = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                     |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 14pt"} 

State transition can also be cancelled by setting the following properties to false,

[·      ]{style="FONT-FAMILY: Symbol"}CanDock

[·      ]{style="FONT-FAMILY: Symbol"}CanDrag

[·      ]{style="FONT-FAMILY: Symbol"}CanFloat

[·      ]{style="FONT-FAMILY: Symbol"}CanAutoHide

[·      ]{style="FONT-FAMILY: Symbol"}CanClose

[]{#related-topics}
:::
