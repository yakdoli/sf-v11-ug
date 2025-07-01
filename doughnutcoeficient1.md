::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### DoughnutCoeficient {#doughnutcoeficient style="tab-stops: 0pt"}

 

Specifies the percentage of the overall radius of the chart that will be used for the Doughnut center hole. For example, if it is set to 0, the doughnut hole will not exist, therefore, the chart will look like a Pie chart.

 

::: {align="center"}
+-------------------------------------+-------------------------------------+
|                                                                           |
|                                                                           |
| Details                                                                   |
+-------------------------------------+-------------------------------------+
| **Possible Values**                 | Ranges from 0.0 to 0.9              |
+-------------------------------------+-------------------------------------+
| **Default Value    **               | **0**                               |
+-------------------------------------+-------------------------------------+
| **2D / 3D Limitations**             | No.                                 |
+-------------------------------------+-------------------------------------+
| **Applies to Chart Element**        | All series.                         |
+-------------------------------------+-------------------------------------+
| **Applies to Chart Types**          | Doughnut Chart, Pie Chart.          |
+-------------------------------------+-------------------------------------+
:::

 

PieCharts with a **DoughnutCoeficient** specified will be rendered as doughnuts. By default, this value is set to 0.0 and hence the chart will be rendered as a full pie.

 

The DoughnutCoeficient property specifies the fraction of the radius occupied by the doughnut whole. Hence the value can range from 0.0 to 0.9.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                         |
|                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                               |
|                                                                                                                                                                        |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].ConfigItems.PieItem.DoughnutCoeficient = 0.5f;]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                |
|                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                          |
|                                                                                                                                                                   |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).ConfigItems.PieItem.DoughnutCoeficient = 0.5f]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image84_84.jpg){border="0"}

 

Figure 114: Pie Chart with DoughnutCoeficient Property Set

 

See Also

 

[Doughnut Chart]{.UGHyperlink}, [Pie Chart]{.UGHyperlink}[]{style="COLOR: black"}

 

[]{#p89} 

[]{#related-topics}
::::
