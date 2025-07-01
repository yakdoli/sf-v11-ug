::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### ShadingMode {#shadingmode style="tab-stops: 0pt"}

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

Specifies the appearance of the chart series.                 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+---------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}**                                                                                                                                |
|                                                                                                                                                                                                         |
| Details                                                                                                                                                                                                 |
+---------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Possible Values                       | FlatRectangle - Displays in a flat rectangular format.                                                                                                          |
|                                       |                                                                                                                                                                 |
|                                       | PhongCylinder - Displays in a cylindrical format.                                                                                                               |
+---------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Default Value                         | PhongCylinder                                                                                                                                                   |
+---------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| 2D / 3D Limitations                   | No                                                                                                                                                              |
+---------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Applies to Chart Element              | All Series                                                                                                                                                      |
+---------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Applies to Chart Types                | Column Chart, BarCharts, Candle Chart, HiLO Chart, HiLoOpenClose Chart, Tornado chart, BoxandWhisker chart, Gantt Chart, Histogram Chart, Polar and Radar Chart |
+---------------------------------------+-----------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

Here is sample code snippet using ShadingMode.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                            |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series\[0\].ConfigItems.ColumnItem.ShadingMode = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartColumnShadingMode]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.FlatRectangle;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                                                                               |
| [Private Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.Series(0).ConfigItems.ColumnItem.ShadingMode = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[ChartColumnShadingMode]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.FlatRectangle]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

![](ImagesExt/image64_193.jpg){border="0"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Figure 187: Normal Column Chart (3D View)

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

![](ImagesExt/image64_194.jpg){border="0"}

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

Figure 188: Column Chart with ShadingMode set to \"FlatRectangle\"

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

See Also

 

[]{#p145}[[Column Charts]{style="COLOR: blue"}, ]{.UGHyperlink}[Bar Charts]{.UGHyperlink}[, ]{.UGHyperlink}[Area Charts]{.UGHyperlink}[,]{.UGHyperlink}[Histogram Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Tornado Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Polar and Radar Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Pie Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Three Line Break Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Box and Whisker Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Renko chart]{.UGHyperlink}[, ]{.UGHyperlink}[Line Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Spline Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Step line Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Kagi Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Bubble And Scatter Chart]{.UGHyperlink}[]{.UGHyperlink}

 

[]{#related-topics}
::::
