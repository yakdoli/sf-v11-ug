::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Rotated Spline Chart {#rotated-spline-chart style="tab-stops: 0pt"}

 

A Rotated Spline Chart is similar to an ordinary Spline Chart. The only difference is that it would be rotated. It plots one or several series of data, and joins each series by smooth, rotated spline curves instead of straight lines.

 

The following image shows a sample Rotated Spline Chart.

 

![](ImagesExt/image84_46.jpg){border="0"}

 

Figure 44: Chart displaying a Rotated Spline Series

 

Chart Details

 

::: {align="center"}
+----------------------------------+-------------------------------------+
| Details                                                                |
+----------------------------------+-------------------------------------+
| **Number of Y values per point** | 1                                   |
+----------------------------------+-------------------------------------+
| **Number of Series         **    | One or More.                        |
+----------------------------------+-------------------------------------+
| **Cannot be Combined with   **   | Pie, Bar,Stacked Bar, Polar, Radar. |
+----------------------------------+-------------------------------------+
:::

 

Rotated Spline series can be added to the chart using the following code.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                          |
|                                                                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                |
|                                                                                                                                                                                                         |
| [// Create chart series and add data points into it.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}[  ]{style="COLOR: black; FONT-SIZE: 12pt"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                                                                                                         |
| [ChartSeries series1 = [this]{style="COLOR: blue"}.chartControl1.Model.NewSeries(\" Series 1\",ChartSeriesType.RotatedSpline );]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                         |
| [series1.Points.Add(1, 326);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                         |
| [series1.Points.Add(2, 491);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                         |
| [series1.Points.Add(3, 382);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                         |
| [series1.Points.Add(4, 482);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                       |
|                                                                                                                                                                                                         |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                  |
|                                                                                                                                                                                                         |
| [// Add the series to the chart series collection.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                   |
|                                                                                                                                                                                                         |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series.Add(series1);]{style="FONT-FAMILY: 'Courier New'"}                                                                        |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                    |
| [\' Create chart series and add data points into it.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                            |
|                                                                                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ series1 [As]{style="COLOR: blue"} ChartSeries = [Me]{style="COLOR: blue"}.chartControl1.Model.NewSeries(\" Series 1\",ChartSeriesType.RotatedSpline )]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                    |
| [series1.Points.Add(1, 326)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                    |
| [series1.Points.Add(2, 491)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                    |
| [series1.Points.Add(3, 382)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                    |
| [series1.Points.Add(4, 482)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                    |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                    |
| [\' Add the series to the chart series collection.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                              |
|                                                                                                                                                                                                                                                    |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series.Add(series1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                      |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| []{style="COLOR: black; FONT-SIZE: 8pt"}                                                                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                                         |
| **Customization Options**                                                                                                                                                                                                                                                                                                               |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [DisplayShadow]{style="COLOR: black"}, [DisplayText]{style="COLOR: black"}, [DrawSeriesNameInDepth]{style="COLOR: black"}, [ElementBorders]{style="COLOR: black"}, [HighlightInterior]{style="COLOR: black"}, [ImageIndex]{style="COLOR: black"}, [Images]{style="COLOR: black"}, [Spacing Between Series]{style="COLOR: black"}        |
|                                                                                                                                                                                                                                                                                                                                         |
| [ShadowInterior]{style="COLOR: black"}, [ShadowOffset]{style="COLOR: black"}, [FancyToolTip]{style="COLOR: black"}, [Font]{style="COLOR: black"}, [Interior]{style="COLOR: black"}, [LegendItem]{style="COLOR: black"}, [Name]{style="COLOR: black"}, [PointsToolTipFormat]{style="COLOR: black"}, [SmartLabels]{style="COLOR: black"}, |
|                                                                                                                                                                                                                                                                                                                                         |
| [Summary]{style="COLOR: black"}, [Text]{style="COLOR: black"}, [TextColor]{style="COLOR: black"}, [TextFormat]{style="COLOR: black"}, [TextOffset]{style="COLOR: black"}, [TextOrientation]{style="COLOR: black"}, [Visible]{style="COLOR: black"}                                                                                      |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p31} 

 

[]{#related-topics}
::::
