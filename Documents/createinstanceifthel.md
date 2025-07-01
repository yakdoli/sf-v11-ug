::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### []{#_Ref261548969}[]{#_Create_instance_if}Create instance if the live instance is missing while dock state load.

[]{style="FONT-FAMILY: 'Calibri','sans-serif'"} 

DockingManager finds if any control is not initialized while loading saved state. If so**, InitializeControlOnLoad** event will be fired. The event handler will have two parameters- sender and  InitializeControlOnLoadEventArgs.

InitializeControlOnLoadEventArgs has two properties:

 

  ---------- ------------------------------------------------------------
  Property   Description
  Caption    Caption of a control for which live instance is not found.
  Control    It contains the Control type as string.
  ---------- ------------------------------------------------------------

[]{style="FONT-SIZE: 14pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [\[C#\]]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                             |
| [void]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ dockingManager_InitializeControlOnLoad([object]{style="COLOR: blue"} sender, [InitializeControlOnLoadEventArgs]{style="COLOR: #2b91af"} args)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                             |
| [        {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
|                                                                                                                                                                                                                                             |
| [            [if]{style="COLOR: blue"} (args.Caption == [\"SolutionExplorer\"]{style="COLOR: #a31515"})]{style="FONT-FAMILY: 'Courier New'"}                                                                                                |
|                                                                                                                                                                                                                                             |
| [            {]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                             |
| [                [TreeView]{style="COLOR: #2b91af"} tree = [new]{style="COLOR: blue"} [TreeView]{style="COLOR: #2b91af"}();]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
|                                                                                                                                                                                                                                             |
| [                [DockingManager]{style="COLOR: #2b91af"}.SetHeader(tree, [\"SolutionExplorer\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                             |
|                                                                                                                                                                                                                                             |
| [                [DockingManager]{style="COLOR: #2b91af"}.SetWindowName(tree, [\"SolutionExplorer\"]{style="COLOR: #a31515"});]{style="FONT-FAMILY: 'Courier New'"}                                                                         |
|                                                                                                                                                                                                                                             |
| [                [this]{style="COLOR: blue"}.dockingManager.Children.Add(tree);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                        |
|                                                                                                                                                                                                                                             |
| [            }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                         |
|                                                                                                                                                                                                                                             |
| [        }]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                             |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 14pt"} 

Setting the window name is essential to identify it uniquely.

[]{#related-topics}
:::
