::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### How to arrange the Tab groups equally using TabbedMDIManager {#how-to-arrange-the-tab-groups-equally-using-tabbedmdimanager style="MARGIN-LEFT: 18pt; tab-stops: 18.0pt"}

 

TabbedMDIManager has AdjustTabGroupWeightsEqually() method to arrange the Tabgroups equally.

[]{style="COLOR: #15428b"} 

::: {align="center"}
  Method                         Description
  ------------------------------ ---------------------------------------
  AdjustTabGroupWeightsEqually   Adjusts the TabGroups weights equally
:::

[]{style="COLOR: #15428b"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                     |
|                                                                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                      |
| [private void]{style="FONT-FAMILY: 'Courier New'; COLOR: #0047ff"}[ AddGroupButton_click([object]{style="COLOR: #0047ff"} sender, [EventArgs]{style="COLOR: #198a8a"} e)]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                                                      |
| [{]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
|                                                                                                                                                                                                                                      |
| [    ]{style="FONT-FAMILY: 'Times New Roman','serif'"}[this]{style="FONT-FAMILY: 'Courier New'; COLOR: #0047ff"}[.tabbedMDIManager.TabbedGroups.Add(new TabbedGroup(\"TabGroup2\"));]{style="FONT-FAMILY: 'Courier New'"}            |
|                                                                                                                                                                                                                                      |
| [    ]{style="FONT-FAMILY: 'Times New Roman','serif'"}[ChildForm]{style="FONT-FAMILY: 'Courier New'; COLOR: #198a8a"}[ f = [new]{style="COLOR: #0047ff"} [ChildForm]{style="COLOR: #198a8a"}();]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                      |
| [    ]{style="FONT-FAMILY: 'Times New Roman','serif'"}[this]{style="FONT-FAMILY: 'Courier New'; COLOR: #0047ff"}[.tabbedMDIManager.TabbedGroups\[\"TabGroup2\"\].AddForm(f);]{style="FONT-FAMILY: 'Courier New'"}                    |
|                                                                                                                                                                                                                                      |
| [    ]{style="FONT-FAMILY: 'Times New Roman','serif'"}[this]{style="FONT-FAMILY: 'Courier New'; COLOR: #0047ff"}[.tabbedMDIManager.AdjustTabGroupWeightsEqually();  ]{style="FONT-FAMILY: 'Courier New'"}                            |
|                                                                                                                                                                                                                                      |
| [}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                              |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: #15428b"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'"}**                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                             |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"} AddGroupButton_click([ByVal]{style="COLOR: blue"} sender [As]{style="COLOR: blue"} [Object]{style="COLOR: blue"}, [ByVal]{style="COLOR: blue"} e [As]{style="COLOR: blue"} [EventArgs]{style="COLOR: #198a8a"})]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                             |
| [     ]{style="FONT-FAMILY: 'Times New Roman','serif'"}[[Me]{style="COLOR: blue"}.tabbedMDIManager.TabbedGroups.Add([New]{style="COLOR: blue"} TabbedGroup(\"TabGroup2\"))]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                             |
| [   [Dim]{style="COLOR: blue"} f [As]{style="COLOR: blue"} [ChildForm]{style="COLOR: #198a8a"} = [New]{style="COLOR: blue"} [ChildForm]{style="COLOR: #198a8a"}()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                                             |
| [   [Me]{style="COLOR: blue"}.tabbedMDIManager.TabbedGroups(\"TabGroup2\").AddForm(f)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                                                             |
| [   [Me]{style="COLOR: blue"}.tabbedMDIManager.AdjustTabGroupWeightsEqually()]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                             |
| [End]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ [Sub]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                     |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

 

 

[]{#p943} 

[]{#related-topics}
::::
