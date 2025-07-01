::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to set the dock position of the legend? {#how-to-set-the-dock-position-of-the-legend style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

ChartLegend contains an enum property called *ChartDock*, which has the following values *Floating, Right, Left, Top, and Bottom.* You can choose the required docking position to dock the chart. The following code snippets explain how to set the docking position for an OlapChart legend:

 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                                                 |
|                                                                                                                                            |
|                                                                                                                                            |
|                                                                                                                                            |
| [ChartDockPanel]{style="COLOR: #2b91af"}.SetDock([this]{style="COLOR: blue"}.olapChart.Legend, [ChartDock]{style="COLOR: #2b91af"}.Right); |
|                                                                                                                                            |
|                                                                                                                                            |
+--------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------+
| **\[VB\]**                                                                                                                              |
|                                                                                                                                         |
|                                                                                                                                         |
|                                                                                                                                         |
| [ChartDockPanel]{style="COLOR: #2b91af"}.SetDock([Me]{style="COLOR: blue"}.olapChart.Legend, [ChartDock]{style="COLOR: #2b91af"}.Right) |
|                                                                                                                                         |
|                                                                                                                                         |
+-----------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[]{#related-topics}
:::
