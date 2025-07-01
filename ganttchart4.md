::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Gantt Chart {#gantt-chart style="tab-stops: 0pt"}

 

A Gantt chart is a graphical representation of the duration of tasks against the progression of time. In a Gantt chart, each task takes up one row. The expected time for each task is represented by a horizontal bar whose left end marks the expected beginning of the task and whose right end marks the expected completion of the task. Tasks may run sequentially, in parallel or overlapping.

 

You could then use another series to represent the completed portion of the different tasks. This new series will then contain data points with their beginning values coinciding with the beginning values of the data points from the previous series and the ending value based on the fraction of the work that has been completed on the task. This way, one can get a quick reading of a project progress by drawing a vertical line through the chart at the current date.

 

 ![](ImagesExt/image84_51.jpg){border="0"}

 

Figure 49: Chart displaying Gantt Series

 

Chart Details

 

::: {align="center"}
+----------------------------------+--------------------------------------------------------------+
| Details                                                                                         |
+----------------------------------+--------------------------------------------------------------+
| **Number of Y values per point** | 2\. (1st is beginning value and the 2nd is the ending value) |
+----------------------------------+--------------------------------------------------------------+
| **Number of Series         **    | One or more.                                                 |
+----------------------------------+--------------------------------------------------------------+
| **Cannot be Combined with   **   | Pie, Bar, Polar, Radar.                                      |
+----------------------------------+--------------------------------------------------------------+
:::

 

Gantt series can be added to the chart using the following code.

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                            |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                            |
| [// Create chart series and add data points into it.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                    |
|                                                                                                                                                                                                                                                            |
| [ChartSeries series = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Model.NewSeries(\"Series Name\",ChartSeriesType.Gantt);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                                                                                                                            |
| [series.Points.Add(0, 1, 5);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                                            |
| [series.Points.Add(1, 3, 7);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                                            |
| [series.Points.Add(2, 4, 8);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                            |
|                                                                                                                                                                                                                                                            |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                            |
| [// Add the series to the chart series collection.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                      |
|                                                                                                                                                                                                                                                            |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series.Add(series);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                              |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                      |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                      |
| [// Create chart series and add data points into it.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                              |
|                                                                                                                                                                                                                                                                      |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ series [As]{style="COLOR: blue"} ChartSeries = [Me]{style="COLOR: blue"}.ChartControl1.Model.NewSeries([\"Series Name\"]{style="COLOR: maroon"}, ChartSeriesType.Gantt)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                      |
| [series.Points.Add(0, 1, 5)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                      |
| [series.Points.Add(1, 3, 7)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                      |
| [series.Points.Add(2, 4, 8)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                      |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartControl1.Series.Add(series)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                         |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| []{style="COLOR: black; FONT-SIZE: 8pt"}                                                                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                                                           |
| **Customization Options**                                                                                                                                                                                                                                                                                 |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [Border]{.UGHyperlink}, [ColumnDrawMode]{.UGHyperlink}, [DisplayShadow]{.UGHyperlink}, [DisplayText]{.UGHyperlink}, [ElementBorders]{.UGHyperlink}, [GanttDrawMode]{.UGHyperlink}, [HighlightInterior]{.UGHyperlink}, [ImageIndex]{.UGHyperlink}, [Images]{.UGHyperlink}                                  |
|                                                                                                                                                                                                                                                                                                           |
| [LightAngle]{.UGHyperlink}, [LightColor]{.UGHyperlink}, [PhongAlpha]{.UGHyperlink}, [PointWidth]{.UGHyperlink}, [RelatedPoints]{.UGHyperlink}, [Spacing]{.UGHyperlink}, [Spacing Between Series]{.UGHyperlink}, [ShadingMode]{.UGHyperlink}, [ShadowInterior]{.UGHyperlink}, [ShadowOffset]{.UGHyperlink} |
|                                                                                                                                                                                                                                                                                                           |
| [ZOrder]{.UGHyperlink}, [FancyToolTip]{.UGHyperlink}, [Font]{.UGHyperlink}, [Interior]{.UGHyperlink}, [LegendItem]{.UGHyperlink}, [Name]{.UGHyperlink}, [PointsToolTipFormat]{.UGHyperlink}, [SmartLabels]{.UGHyperlink},                                                                                 |
|                                                                                                                                                                                                                                                                                                           |
| [Summary]{.UGHyperlink}, [Text]{.UGHyperlink}, [TextColor]{.UGHyperlink}, [TextFormat]{.UGHyperlink}, [TextOffset]{.UGHyperlink}, [TextOrientation]{.UGHyperlink}, [Visible]{.UGHyperlink}[]{style="COLOR: black"}                                                                                        |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p37} 

 

[]{#related-topics}
::::
