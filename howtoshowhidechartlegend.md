::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to Show/Hide chart legend? {#how-to-showhide-chart-legend style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

The ChartLegend has a visibility property using which you can show or hide the ChartLegend in an OlapChart. The following code snippets show how you can collapse the visibility of the ChartLegend:

 

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[XAML\]**                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                        |
| [\<]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[OlapChart.Legend]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}                                                                               |
|                                                                                                                                                                                                                                        |
| [        ]{style="COLOR: #a31515"}[\<]{style="COLOR: blue"}[baseChart]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[ChartLegend]{style="COLOR: #a31515"}[ Visibility]{style="COLOR: red"}[=\"Collapsed\" /\>]{style="COLOR: blue"}\ |
| [\</]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[OlapChart.Legend]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}                                                                              |
|                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                        |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+--------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                               |
|                                                                                                                          |
|                                                                                                                          |
|                                                                                                                          |
| [this]{style="COLOR: blue"}.olapChart.Legend.Visibility = System.Windows.[Visibility]{style="COLOR: #2b91af"}.Collapsed; |
|                                                                                                                          |
|                                                                                                                          |
+--------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+---------------------------------------------------------------------------------------------+
| **\[VB\]**                                                                                  |
|                                                                                             |
|                                                                                             |
|                                                                                             |
| [Me]{style="COLOR: blue"}.olapChart.Legend.Visibility = System.Windows.Visibility.Collapsed |
|                                                                                             |
|                                                                                             |
+---------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[]{#related-topics}
:::
