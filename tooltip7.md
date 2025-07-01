::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### ToolTip {#tooltip style="tab-stops: 0pt"}

 

Sets the tooltip of the style object associated with the series.

[]{style="COLOR: red; FONT-SIZE: 8pt"} 

::: {align="center"}
+-------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                               |
| Details                                                                                                                                                                                                                                                                                       |
+-------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Possible Values**                 | Any string value                                                                                                                                                                                                                                        |
+-------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Default Value    **               | **Nil**                                                                                                                                                                                                                                                 |
+-------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **2D / 3D Limitations**             | No                                                                                                                                                                                                                                                      |
+-------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Applies to Chart Element**        | Any Series                                                                                                                                                                                                                                              |
+-------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Applies to Chart Types**          | Scatter Chart, Hilo Open Close Chart(3D),Column Charts, BarCharts, Bubble Chart,Line Charts,  BoxandWhisker Chart, Tornado Chart, Combination Chart, Gantt Chart,Candle Chart, HiLo Chart(3D), PolarAndRadar, PieChart,Accumulation Charts, Area Charts |
+-------------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

 

Property  

 Table 1: Property Table

::: {align="center"}
  -------------- --------------------------------------------------- ------------- --------------- ---------------------
  **Property**   **Description**                                     **Type**      **Data Type**   **Reference links**
  ShowToolTips   Specifies whether tooltip has to be displayed.      Server side   Boolean         NA
  -------------- --------------------------------------------------- ------------- --------------- ---------------------
:::

[]{style="FONT-FAMILY: 'Calibri','sans-serif'; COLOR: black"} 

 

Here is sample code snippet using ToolTip in the Column Chart.

 

Series Wide Setting

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                               |
|                                                                                                                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                     |
|                                                                                                                                                                                                              |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ShowToolTips = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                      |
|                                                                                                                                                                                                              |
| [series1.PointsToolTipFormat = \"{1}\";]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                              |
| [series1.Style.ToolTip = \"]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Tooltip of Series1]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\";]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                          |
|                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                    |
|                                                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.ShowToolTips = [True]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                        |
|                                                                                                                                                                                                             |
| [series1.PointsToolTipFormat = \"{1}\"]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                             |
| [series1.Style.ToolTip = \"]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Tooltip of Series1]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\"]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**                                                                                            **

![](ImagesExt/image84_223.jpg){border="0"}

 

Figure 223: ToolTip set for Chart Series

 

Specific Data Point Setting

 

ToolTip can be applied to individual points of a Series.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [for]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ (]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[int]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i = 0; i \< series1.Points.Count; i++)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [{                ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [    series1.Styles\[i\].ToolTip = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[string]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.Format(\"]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[X = {0}, Y = {1}]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\", series1.Points\[0\].X.ToString(),                          series1.Points\[i\].YValues\[0\]);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [}]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                   |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As Integer]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ = 0]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [Do While]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ i \< series1.Points.Count]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [      series1.Styles(i).ToolTip = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[String]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.Format(\"]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[X = {0}, Y = {1}]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\", series1.Points(0).X.ToString(),          series1.Points(i).YValues(0))]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [  i += 1]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [Loop]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                          |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**                                            **

![](ImagesExt/image84_224.jpg){border="0"}

**** 

Figure 224**[: ToolTip set for Data Point in the Series ]{style="FONT-STYLE: normal"}**

 

**See Also**

 

[Scatter Chart]{.UGHyperlink}, [Hilo Open Close Chart]{.UGHyperlink}(3D), [Column Charts]{.UGHyperlink}, [BarCharts]{.UGHyperlink}, [Bubble Chart]{.UGHyperlink}, [Line Charts]{.UGHyperlink}, [BoxandWhisker Chart]{.UGHyperlink}, [Tornado Chart]{.UGHyperlink}, [Combination Chart]{.UGHyperlink}, [Gantt Chart]{.UGHyperlink}, [Candle Chart]{.UGHyperlink}, [HiLo Chart]{.UGHyperlink}(3D), [PolarAndRadar chart]{.UGHyperlink}, [PieChart]{.UGHyperlink}, [Accumulation Charts]{.UGHyperlink}, [Area Charts]{.UGHyperlink}[]{style="COLOR: black"}

 

[]{#p163} 

[]{#related-topics}
:::::
