::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### ColumnDrawMode {#columndrawmode style="tab-stops: 0pt"}

 

Indicates the drawing mode of columns in charts when there are multiple series.

 

::: {align="center"}
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                                |
|                                                                                                                                                                |
| Details                                                                                                                                                        |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
| **Possible Values**                 | [·      ]{style="FONT-FAMILY: Symbol"}**InDepthMode** - Columns from different series are drawn at different depths.     |
|                                     |                                                                                                                          |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**PlaneMode** - Columns from all series are drawn side-by-side.                    |
|                                     |                                                                                                                          |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**ClusteredMode** - Columns from all series are drawn in depth with the same size. |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
| **Default Value    **               | **InDepthMode**                                                                                                          |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
| **2D / 3D Limitations**             | 3D only                                                                                                                  |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
| **Applies to Chart Element**        | All Series                                                                                                               |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
| **Applies to Chart Types**          | Column Chart, ColumnRange Chart,Bar Chart, BoxAndWhisker Chart, Gantt Chart                                              |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------+
:::

 

Here is the sample code snippet using **ColumnDrawMode** in Column Chart.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                     |
|                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                           |
|                                                                                                                                                                                    |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ColumnDrawMode = [ChartColumnDrawMode]{style="COLOR: teal"}.PlaneMode;]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-SIZE: 8pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                              |
|                                                                                                                                                                                 |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                        |
|                                                                                                                                                                                 |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ColumnDrawMode = [ChartColumnDrawMode]{style="COLOR: teal"}.PlaneMode]{style="FONT-FAMILY: 'Courier New'"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} 

![](ImagesExt/image84_102.jpg){border="0"}

 

Figure 100: ColumnDrawMode set to \"PlaneMode\"

 

![](ImagesExt/image84_103.jpg){border="0"}

 

Figure 101: ColumnDrawMode set to \"InDepthMode\"

 

![](ImagesExt/image84_104.jpg){border="0"}

 

Figure 102: ColumnDrawMode set to \"ClusteredMode\"

 

See Also

 

[Column Chart]{.UGHyperlink}, [ColumnRange Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Bar Chart]{.UGHyperlink}, [BoxAndWhisker Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Gantt Chart]{.UGHyperlink}[]{style="COLOR: black"}

 

[]{#p81} 

[]{#related-topics}
::::
