::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### Chart Points Labels {#chart-points-labels style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

The OLAP Chart provides support to customize the Labels and the Symbols of the chart points. This is illustrated in the following code example:

 

+---------------------------------------------------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                                                                  |
|                                                                                                                                             |
| [foreach]{style="COLOR: blue"} ([ChartSeries]{style="COLOR: #2b91af"} series [in]{style="COLOR: blue"} [this]{style="COLOR: blue"}.Series)\ |
| {\                                                                                                                                          |
|     series.AdornmentsInfo.Visible = [false]{style="COLOR: blue"};\                                                                          |
|     [ChartAdornmentInfo]{style="COLOR: #2b91af"} cai = series.AdornmentsInfo;\                                                              |
|  \                                                                                                                                          |
|     [// To display the x-axis label value.]{style="COLOR: green"}\                                                                          |
|     series.AdornmentsInfo.LabelContentPath = [\"DataPoint.X\"]{style="COLOR: #a31515"};\                                                    |
|  \                                                                                                                                          |
|     [// To display the y-axis label value.]{style="COLOR: green"}\                                                                          |
|     series.AdornmentsInfo.LabelContentPath = [\"DataPoint.Y\"]{style="COLOR: #a31515"};\                                                    |
|  \                                                                                                                                          |
|     [// To display the Series label value.]{style="COLOR: green"}\                                                                          |
|     series.AdornmentsInfo.LabelContentPath = [\"Series.Label\"]{style="COLOR: #a31515"};\                                                   |
| }                                                                                                                                           |
+---------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **\[VB\]**                                                                                                                                                                                |
|                                                                                                                                                                                           |
| [For]{style="COLOR: blue"} [Each]{style="COLOR: blue"} series [As]{style="COLOR: blue"} [ChartSeries]{style="COLOR: #2b91af"} [In]{style="COLOR: blue"} [Me]{style="COLOR: blue"}.Series\ |
|     series.AdornmentsInfo.Visible = [False]{style="COLOR: blue"}\                                                                                                                         |
|     [Dim]{style="COLOR: blue"} cai [As]{style="COLOR: blue"} [ChartAdornmentInfo]{style="COLOR: #2b91af"} = series.AdornmentsInfo\                                                        |
|  \                                                                                                                                                                                        |
|     [\' To display the x-axis label value.]{style="COLOR: green"}\                                                                                                                        |
|     series.AdornmentsInfo.LabelContentPath = [\"DataPoint.X\"]{style="COLOR: #a31515"}\                                                                                                   |
|  \                                                                                                                                                                                        |
|     [\' To display the y-axis label value.]{style="COLOR: green"}\                                                                                                                        |
|     series.AdornmentsInfo.LabelContentPath = [\"DataPoint.Y\"]{style="COLOR: #a31515"}\                                                                                                   |
|  \                                                                                                                                                                                        |
|     [\' To display the Series label value.]{style="COLOR: green"}\                                                                                                                        |
|     series.AdornmentsInfo.LabelContentPath = [\"Series.Label\"]{style="COLOR: #a31515"}\                                                                                                  |
| [Next]{style="COLOR: blue"} series                                                                                                                                                        |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

A sample, which demonstrates all the appearance properties, is available in the following installation location:

**..\\Syncfusion\\\<Version Number\>\\BI\\WPF\\OlapChart.WPF\\Samples\\Chart Appearance**

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[]{#related-topics}
:::
