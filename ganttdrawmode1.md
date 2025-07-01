::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### GanttDrawMode {#ganttdrawmode style="tab-stops: 0pt"}

 

Specifies the drawing mode of Gantt chart.

 

::: {align="center"}
+-------------------------------------+-------------------------------------------------------------------------------------------------------+
|                                                                                                                                             |
|                                                                                                                                             |
| Details                                                                                                                                     |
+-------------------------------------+-------------------------------------------------------------------------------------------------------+
| Possible Values                     | [·      ]{style="FONT-FAMILY: Symbol"}**AutoSizeMode** - Plots the Gantt Chart side by side.          |
|                                     |                                                                                                       |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**CustomPointWidthMode** - Plots the Gantt Chart as Overlapped. |
+-------------------------------------+-------------------------------------------------------------------------------------------------------+
| **Default Value    **               | **CustomPointWidthMode**                                                                              |
+-------------------------------------+-------------------------------------------------------------------------------------------------------+
| 2D / 3D Limitations                 | None                                                                                                  |
+-------------------------------------+-------------------------------------------------------------------------------------------------------+
| Applies to Chart Element            | All series                                                                                            |
+-------------------------------------+-------------------------------------------------------------------------------------------------------+
| Applies to Chart Types              | Gantt Chart                                                                                           |
+-------------------------------------+-------------------------------------------------------------------------------------------------------+
:::

 

Here is some sample code.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                          |
|                                                                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                |
|                                                                                                                                                                                                         |
| **[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**[// Specifies GenttDrawMode as CustomPointWidthMode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                         |
|                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].GanttDrawMode = [ChartGanttDrawMode]{style="COLOR: teal"}.CustomPointWidthMode;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].Style.PointWidth = 0.7f;]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[1\].GanttDrawMode = [ChartGanttDrawMode]{style="COLOR: teal"}.CustomPointWidthMode;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[1\].Style.PointWidth = 1f;]{style="FONT-FAMILY: 'Courier New'"}                                                          |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                 |
|                                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                           |
|                                                                                                                                                                                                    |
| [\' Specifies GenttDrawMode as CustomPointWidthMode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                             |
|                                                                                                                                                                                                    |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).GanttDrawMode = [ChartGanttDrawMode]{style="COLOR: teal"}.CustomPointWidthMode]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                    |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).Style.PointWidth = 0.7f]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                                    |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(1).GanttDrawMode = ChartGanttDrawMode.CustomPointWidthMode]{style="FONT-FAMILY: 'Courier New'"}                        |
|                                                                                                                                                                                                    |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(1).Style.PointWidth = 1f]{style="FONT-FAMILY: 'Courier New'"}                                                          |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                  |
|                                                                                                                                                                                                 |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                        |
|                                                                                                                                                                                                 |
| [// Specifies GenttDrawMode as AutoSizeMode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                  |
|                                                                                                                                                                                                 |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[0\].GanttDrawMode = [ChartGanttDrawMode]{style="COLOR: teal"}.AutoSizeMode;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                 |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[1\].GanttDrawMode = [ChartGanttDrawMode]{style="COLOR: teal"}.AutoSizeMode;]{style="FONT-FAMILY: 'Courier New'"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                         |
|                                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                   |
|                                                                                                                                                                                            |
| [\' Specifies GenttDrawMode as AutoSizeMode]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                             |
|                                                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(0).GanttDrawMode = [ChartGanttDrawMode]{style="COLOR: teal"}.AutoSizeMode]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                            |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series(1).GanttDrawMode = [ChartGanttDrawMode]{style="COLOR: teal"}.AutoSizeMode]{style="FONT-FAMILY: 'Courier New'"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

**![](ImagesExt/image84_139.jpg){border="0"}**

 

Figure 138: Gantt Chart with AutoSizeMode

 

**![](ImagesExt/image84_140.jpg){border="0"}**

 

Figure 139**[: Gantt Chart with CustomPointWidthMode]{style="FONT-STYLE: normal"}**

 

**See Also**

 

Gantt Chart[]{style="COLOR: black"}

 

[]{#p107} 

 

[]{#related-topics}
::::
