::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### How to disable vertical grid lines? {#how-to-disable-vertical-grid-lines style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

In general, for column type charts, the ***vertical grid line belongs to*** ***the primary axis***. To disable the vertical grid lines for these types of charts, you need to use the ShowGridLines property of the primary axis.

The following illustration describes how the chart will look after the vertical grid lines are disabled:

 

![](ImagesExt/image37_38.jpg){border="0"}

Figure 36: An OlapChart with vertical grid lines disabled[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}

***[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"}*** 

The following code snippet describes how to disable the horizontal grid lines:

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"} 

+-------------------------------------------------------------------------------------------------+
| **\[C#\]**                                                                                      |
|                                                                                                 |
|                                                                                                 |
|                                                                                                 |
| [      this]{style="COLOR: blue"}.olapChart.Series\[0\].Area.PrimaryAxis.SetValue(              |
|                                                                                                 |
| [      ChartArea]{style="COLOR: #2b91af"}.ShowGridLinesProperty, [false]{style="COLOR: blue"}); |
|                                                                                                 |
|                                                                                                 |
+-------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

+------------------------------------------------------------------------------------------------+
| **\[VB\]**                                                                                     |
|                                                                                                |
|                                                                                                |
|                                                                                                |
|           [Me]{style="COLOR: blue"}.olapChart.Series(0).Area.PrimaryAxis.SetValue(             |
|                                                                                                |
|       [ChartArea]{style="COLOR: #2b91af"}.ShowGridLinesProperty, [False]{style="COLOR: blue"}) |
|                                                                                                |
|                                                                                                |
+------------------------------------------------------------------------------------------------+

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
 

[![](ImagesExt/image37_1.jpg){border="0"}]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black; FONT-SIZE: 11pt"}Note: For bar type charts, such as Bar, Stacking bar, and Stacking100 Bar you can disable the vertical grid lines by using the ShowGridLinesProperty of the SecondaryAxis.
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; FONT-SIZE: 11pt"} 

[]{#related-topics}
::::
