::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to avoid flickering while loading dock state? {#how-to-avoid-flickering-while-loading-dock-state style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

Flickering can be avoided by calling the below methods.

**[]{style="COLOR: #15428b"}** 

**LockDockPanelsUpdate and** **UnLockDockPanelsUpdate Methods -** The LockDockPanelsUpdate and UnLockDockPanelsUpdate methods are used to lock and unlock the panel\'s repainting respectively. For example to avoid flickering while loading a dock state, these methods can be used in the following way.

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                        |
|                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                              |
|                                                                                                                                       |
| [//Avoids flickering while loading dock state]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                      |
|                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.LockHostFormUpdate();]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.LoadDockState();]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                       |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.UnlockHostFormUpdate();]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                 |
|                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                           |
|                                                                                                                                    |
| [\'Avoids flickering while loading dock state]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                   |
|                                                                                                                                    |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.LockHostFormUpdate()]{style="FONT-FAMILY: 'Courier New'"}   |
|                                                                                                                                    |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.LoadDockState()]{style="FONT-FAMILY: 'Courier New'"}        |
|                                                                                                                                    |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.dockingManager1.UnlockHostFormUpdate()]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

See Also

[]{style="COLOR: #15428b"} 

[Persistence]{.UGHyperlink}[]{.UGHyperlink}

[]{#related-topics}
:::
