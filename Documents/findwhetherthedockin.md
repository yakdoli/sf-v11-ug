::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### []{#_Ref264440163}[]{#_Find_whether_the}Find whether the docking window is being closed?

 

We can determine whether the docking window is closing in two ways,

 

PreviewWindowClosed

This event will be raised before a window is getting closed. CloseEventArgs contains two properties:

 

  ------------ -----------------------------------------
  Properties   Description
  element      The element which is being closed.
  Canceled     Event can be cancelled by setting true.
  ------------ -----------------------------------------

 

If the event is cancelled we cannot close the window.

[]{style="FONT-SIZE: 14pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                          |
|                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                   |
|                                                                                                                                                                                                                       |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dockingManager_PreviewWindowClosed([object]{style="COLOR: blue"} sender, [CloseEventArgs]{style="COLOR: #2b91af"} args)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                       |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                                       |
| [            args.Canceled = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                                       |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                       |
|                                                                                                                                                                                                                       |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 14pt"} 

DockStateChanging

This event is raised when DockState is changing for a window. If the DockState is changing to Hidden state it indicates that window is closing.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                 |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dockingManager_DockStateChanging([object]{style="COLOR: blue"} sender, [DockStateChangingEventArgs]{style="COLOR: #2b91af"} args)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                 |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                 |
| [            [if]{style="COLOR: blue"} (([DockState]{style="COLOR: #2b91af"})args.NewState == [DockState]{style="COLOR: #2b91af"}.Hidden)]{style="FONT-FAMILY: 'Courier New'"}                                                  |
|                                                                                                                                                                                                                                 |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                 |
| [                //window is closing]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[]{style="FONT-FAMILY: 'Courier New'"}                                                                                                   |
|                                                                                                                                                                                                                                 |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                 |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 14pt"} 

Refer also:

[[Cancel state transition completely[[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 14pt"}]{.underline}]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 14pt"}[]{style="FONT-FAMILY: 'Times New Roman','serif'; FONT-SIZE: 14pt"}]{.underline}

[[]{.UGHyperlink}[Cancel the floating of docking window]{.UGHyperlink}[]{.UGHyperlink}]{.UGHyperlink}[]{.UGHyperlink}[]{.UGHyperlink}

[[]{style="TEXT-DECORATION: none"}]{.UGHyperlink} 

[]{#related-topics}
:::
