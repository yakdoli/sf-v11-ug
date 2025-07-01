::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to toggle the visibility of the legend check box? {#how-to-toggle-the-visibility-of-the-legend-check-box style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

The visibility of the legend check box can be toggled by using the CheckBoxVisibility property in the ChartLegend. The following code snippet shows how to toggle the visibility of the check box in the legend of an OlapChart:

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[XAML\]**                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                            |
| [\<]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[OlapChart.Legend]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}\                                                                                  |
| [    ]{style="COLOR: #a31515"}[\<]{style="COLOR: blue"}[baseChart]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[ChartLegend]{style="COLOR: #a31515"}[ CheckBoxVisibility]{style="COLOR: red"}[=\"Collapsed\" /\>]{style="COLOR: blue"}\ |
| [\</]{style="COLOR: blue"}[syncfusion]{style="COLOR: #a31515"}[:]{style="COLOR: blue"}[OlapChart.Legend]{style="COLOR: #a31515"}[\>]{style="COLOR: blue"}                                                                                  |
|                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                            |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+----------------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                                       |
|                                                                                                                                  |
|                                                                                                                                  |
|                                                                                                                                  |
| [this]{style="COLOR: blue"}.olapChart.Legend.CheckBoxVisibility = System.Windows.[Visibility]{style="COLOR: #2b91af"}.Collapsed; |
|                                                                                                                                  |
|                                                                                                                                  |
+----------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+-------------------------------------------------------------------------------------------------------------------------------+
| **\[VB\]**                                                                                                                    |
|                                                                                                                               |
|                                                                                                                               |
|                                                                                                                               |
| [Me]{style="COLOR: blue"}.olapChart.Legend.CheckBoxVisibility = System.Windows.[Visibility]{style="COLOR: #2b91af"}.Collapsed |
|                                                                                                                               |
|                                                                                                                               |
+-------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[]{#related-topics}
:::
