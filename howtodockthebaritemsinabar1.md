::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to dock the bar items in a bar {#how-to-dock-the-bar-items-in-a-bar style="tab-stops: 0pt"}

[]{style="COLOR: #15428b"} 

We can dock the baritems in a bar using XPMenus CommandBarExt class as follows.

[]{style="COLOR: #15428b"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                      |
|                                                                                                                                                                                                     |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                              |
|                                                                                                                                                                                                     |
| [CommandBarExt cbe = [this]{style="COLOR: blue"}.mainFrameBarManager1.GetBarControl([this]{style="COLOR: blue"}.bar1) [as]{style="COLOR: blue"} CommandBarExt;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                     |
| [//Get the bar control that hold the baritems.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                   |
|                                                                                                                                                                                                     |
| [cbe.BarControl.Dock = System.Windows.Forms.[DockStyle]{style="COLOR: teal"}.Right;]{style="FONT-FAMILY: 'Courier New'"}                                                                            |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                        |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ cbe [As]{style="COLOR: blue"} CommandBarExt = [TryCast]{style="COLOR: blue"}([Me]{style="COLOR: blue"}.mainFrameBarManager1.GetBarControl([Me]{style="COLOR: blue"}.bar1), CommandBarExt)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                        |
| [\'Get the bar control that hold the baritems. ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                        |
| [cbe.BarControl.Dock = System.Windows.Forms.DockStyle.Right]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                       |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#related-topics}
:::
