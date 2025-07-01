::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### OptimizePiePointPositions {#optimizepiepointpositions style="tab-stops: 0pt"}

 

Specifies if the data points with smaller values are grouped together and ordered. By default, they are ordered in the order in which the points are added to the series.

 

::: {align="center"}
+-------------------------------------+---------------------------------------------------------------------+
|                                                                                                           |
|                                                                                                           |
| **Details**                                                                                               |
+-------------------------------------+---------------------------------------------------------------------+
| **Possible Values**                 |                                                                     |
|                                     |                                                                     |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}True  - Enables optimization  |
|                                     |                                                                     |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}False - Disables optimization |
|                                     |                                                                     |
|                                     |                                                                     |
+-------------------------------------+---------------------------------------------------------------------+
| **Default Value    **               | **True**                                                            |
+-------------------------------------+---------------------------------------------------------------------+
| **2D / 3D Limitations**             | No.                                                                 |
+-------------------------------------+---------------------------------------------------------------------+
| **Applies to Chart Element**        | Any Series.                                                         |
+-------------------------------------+---------------------------------------------------------------------+
| **Applies to Chart Types**          | Pie Chart.                                                          |
+-------------------------------------+---------------------------------------------------------------------+
:::

 

Here is the code snippet using OptimizePiePointPositions.

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                |
| [ChartSeries]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ series = [this]{style="COLOR: blue"}.chartControl1.Model.NewSeries([\"Series Name\"]{style="COLOR: maroon"}, [ChartSeriesType]{style="COLOR: teal"}.Pie);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                |
| [series.Points.Add(0, 20);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                |
| [series.Points.Add(1, 28);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                |
| [series.Points.Add(2, 23);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                |
| [series.Points.Add(3, 10);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                |
| [series.Points.Add(4, 12);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                |
| [series.Points.Add(5, 3);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                |
| [series.Points.Add(6, 2);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                |
| [series.ExplodedIndex = 2;]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                |
| [series.OptimizePiePointPositions = [false]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series.Add(series);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[series[ ]{style="COLOR: black"}[As]{style="COLOR: blue"}[ ChartSeries = ]{style="COLOR: black"}[Me]{style="COLOR: blue"}[.chartControl1.Model.NewSeries(\"]{style="COLOR: black"}[Series Name]{style="COLOR: maroon"}[\",]{style="COLOR: black"}[ChartSeriesType]{style="COLOR: teal"}[.]{style="COLOR: black"}Pie[)]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [series.Points.Add(0, 20)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [series.Points.Add(1, 28)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [series.Points.Add(2, 23)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [series.Points.Add(3, 10)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [series.Points.Add(4, 12)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [series.Points.Add(5, 3)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [series.Points.Add(6, 2)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [series.ExplodedIndex = 2]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [series.OptimizePiePointPositions = [False]{style="COLOR: blue"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                        |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series.Add(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[series[)]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                     |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image84_167.jpg){border="0"}

 

Figure 167: OptimizePiePointPositions set to True

 

![](ImagesExt/image84_168.jpg){border="0"}

 

Figure 168: OptimizePiePointPositions set to False

 

See Also

[[]{style="BACKGROUND: windowtext"}]{style="BACKGROUND: yellow; COLOR: black"}

[[Pie Chart]{style="COLOR: blue"}]{.UGHyperlink}

 

[]{#p127} 

 

[]{#related-topics}
::::
