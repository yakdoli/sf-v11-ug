::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Box and Whisker Chart {#box-and-whisker-chart style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

In 1977, John Tukey published an efficient method for displaying a five-number data summary. The graph is called a Box and Whisker plot (also known as BoxPlot) and summarizes the following statistical measures.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}median

[·      ]{style="FONT-FAMILY: Symbol"}upper and lower quartiles (75 percentile to 25 percentile)

[·      ]{style="FONT-FAMILY: Symbol"}minimum and maximum data values

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

The following is an example of a Box and Whisker plot.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

![](ImagesExt/image64_81.jpg){border="0"}

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

Figure 78: Box and Whisker Chart

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

The Box and Whisker plot is interpreted as follows.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}The box itself contains the middle 50% of the data. The upper edge (hinge) of the box indicates the 75th percentile of the data set and the lower hinge indicates the 25th percentile. The range of the middle two quartiles is known as the inter-quartile range.

[·      ]{style="FONT-FAMILY: Symbol"}The line in the box indicates the median value of the data.

[·      ]{style="FONT-FAMILY: Symbol"}Box and Whisker chart has two modes, Normal mode and Percentile mode.

[·      ]{style="FONT-FAMILY: Symbol"}In Normal Mode, if the median line within the box is not equi-distant from the hinges, then the data is skewed. The ends of the vertical lines or \"whiskers\" indicate the minimum and maximum data values, unless outliers are present, in which case the whiskers extend to a maximum of 1.5 times the inter-quartile range.

[·      ]{style="FONT-FAMILY: Symbol"}In Percentile Mode: \[Set **Series1.ConfigItems.BoxAndWhiskerItem.PercentileMode** property to ***true***\], the ends of the vertical lines or \"whiskers\" will be decided by the Series1.ConfigItems.BoxAndWhiskerItem.Percentile property value. For example, if the \'Percentile\' value is 0.15, then the minimum value will be the 15th percentile of the overall data set and the maximum value will be 85th percentile of the overall data set.

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note:
:::

1.   The percentile value should lie between 0.0 to 0.25.

2.   It is not possible to set upper Percentile value. It is calculated automatically based on the Percentile value.

   

 For Ex:

          Percentile = 0.15

          Upper Percentile = 1 - Percentile = 0.85.

In Normal mode, Outliers are present in which case the whiskers extend to a maximum of 1.5 times the inter-quartile range. But in Percentile mode, Outliers will be calculated based on the Percentile value.

    

For example:

          Percentile = 0.15

Outliers are present in which case the whiskers extend to minimum and maximum of 15th and 85th percentile of overall data set, respectively. If \'Percentile\' value is Zero, then, there is no outliers in the Chart.

 

3.   The width of the Outliers can be adjusted by using this:

           \'Series1.ConfigItems.BoxAndWhiskerItem.OutLierWidth\' property.

        If it is zero, the width of the outlier will be calculated based on the data points range.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'"}** 

**[Chart Details]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'"}**

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'"}** 

::: {align="center"}
+---------------------------------------+--------------------------------------------------------------+
| **[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}**                             |
|                                                                                                      |
| Details                                                                                              |
+---------------------------------------+--------------------------------------------------------------+
| Number of Y values per point          | 5 (minimum, lower quartile, median, upper quartile, maximum) |
+---------------------------------------+--------------------------------------------------------------+
| Number of Series                      | One or more                                                  |
+---------------------------------------+--------------------------------------------------------------+
| Cannot be Combined with               | Pie, Bar, Polar, Radar                                       |
+---------------------------------------+--------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Box and Whisker series can be added to the chart using the following code.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                 |
|                                                                                                                                                                                                |
| []{style="COLOR: black"}                                                                                                                                                                       |
|                                                                                                                                                                                                |
| [// Create chart series and add data points into it.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                        |
|                                                                                                                                                                                                |
| [ChartSeries series1 = [this]{style="COLOR: blue"}.[ChartWebControl1]{style="COLOR: black"}.Model.NewSeries(\"Series 1\",ChartSeriesType.BoxAndWhisker );]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                |
| [series1.Points.Add(1, 5, 8 ,12, 15, 18);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                |
| [series1.Points.Add(2, 4, 6, 10, 12, 14);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                |
| [series1.Points.Add(3, 2, 4, 7, 14, 18);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                  |
|                                                                                                                                                                                                |
| [                        ]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                 |
|                                                                                                                                                                                                |
| [ChartSeries series2 = [this]{style="COLOR: blue"}.[ChartWebControl1]{style="COLOR: black"}.Model.NewSeries(\"Series 2\",ChartSeriesType.BoxAndWhisker );]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                |
| [series2.Points.Add(1, 6, 9, 15, 18, 20);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                |
| [series2.Points.Add(2, 7, 9, 13, 15, 16);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                |
| [series2.Points.Add(3, 6, 8, 10, 15, 19);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                 |
|                                                                                                                                                                                                |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                         |
|                                                                                                                                                                                                |
| [// Add the series to the chart series collection.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                          |
|                                                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.[ChartWebControl1]{style="COLOR: black"}.Series.Add(series1);]{style="FONT-FAMILY: 'Courier New'"}                                    |
|                                                                                                                                                                                                |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.[ChartWebControl1]{style="COLOR: black"}.Series.Add(series2);]{style="FONT-FAMILY: 'Courier New'"}                                    |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                             |
| []{style="COLOR: black"}                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                             |
| [\' Create chart series and add data points into it.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ series1 [As]{style="COLOR: blue"} ChartSeries = [Me]{style="COLOR: blue"}.[ChartWebControl1]{style="COLOR: black"}.Model.NewSeries(\"Series 1\",ChartSeriesType.BoxAndWhisker)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                             |
| [series1.Points.Add(1, 5, 8 ,12, 15, 18)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                             |
| [series1.Points.Add(2, 4, 6, 10, 12, 14)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                             |
| [series1.Points.Add(3, 2, 4, 7, 14, 18)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ series2 [As]{style="COLOR: blue"} ChartSeries = [Me]{style="COLOR: blue"}.[ChartWebControl1]{style="COLOR: black"}.Model.NewSeries(\"Series 2\",ChartSeriesType.BoxAndWhisker)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                             |
| [series2.Points.Add(1, 6, 9, 15, 18, 20)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                             |
| [series2.Points.Add(2, 7, 9, 13, 15, 16)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                             |
| [series2.Points.Add(3, 6, 8, 10, 15, 19)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                             |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                      |
|                                                                                                                                                                                                                                                                             |
| [\' Add the series to the chart series collection.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.[ChartWebControl1]{style="COLOR: black"}.Series.Add(series1)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
|                                                                                                                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.[ChartWebControl1]{style="COLOR: black"}.Series.Add(series2)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                    |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

[]{#p68} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| []{style="COLOR: black; FONT-SIZE: 8pt"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| Customization Options[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt; FONT-WEIGHT: normal"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| [[DisplayShadow]{.UGHyperlink}](ms-xhelp:///?Id=2b5f6627-1320-4a9f-8c8f-215f023234fe)[, ]{.UGHyperlink}[[DisplayText]{.UGHyperlink}](ms-xhelp:///?Id=997ed3c1-0166-44d9-b455-61cb06d07577)[, ]{.UGHyperlink}[[DrawErrorBars]{.UGHyperlink}](ms-xhelp:///?Id=717b660b-758f-4d1f-adf1-797d6889091a)[, ]{.UGHyperlink}[[DrawSeriesNameInDepth]{.UGHyperlink}](ms-xhelp:///?Id=997ed3c1-0166-44d9-b455-61cb06d07577)[, ]{.UGHyperlink}[[ElementBorders]{.UGHyperlink}](ms-xhelp:///?Id=4769607d-f657-43b2-a264-a5272d06b8a2)[, ]{.UGHyperlink}[[ErrorBarsSymbolShape]{.UGHyperlink}](ms-xhelp:///?Id=74ffa84a-cb1c-47b1-9851-bfe48de114bc)[, ]{.UGHyperlink}[[HighlightInterior]{.UGHyperlink}](ms-xhelp:///?Id=37c24013-c079-4c44-92c6-4e7f9387ece9)[, ]{.UGHyperlink}[[HitTestRadius]{.UGHyperlink}](ms-xhelp:///?Id=84d7688d-c008-487e-9091-7a24e7706c3a)[, ]{.UGHyperlink}[[Images]{.UGHyperlink}](ms-xhelp:///?Id=770e5177-f611-4433-a67c-23d7f05f95c0)[]{.UGHyperlink}                                                                                                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [[ImageIndex]{.UGHyperlink}](ms-xhelp:///?Id=2d82a5e3-8b5e-442a-a7cd-95558f6d1bb8)[, ]{.UGHyperlink}[[Rotate]{.UGHyperlink}](ms-xhelp:///?Id=9ac024a0-198b-48a3-bbae-5cd7f82ae041)[, ]{.UGHyperlink}[[Spacing Between Series]{.UGHyperlink}](ms-xhelp:///?Id=9ac024a0-198b-48a3-bbae-5cd7f82ae041)[, ]{.UGHyperlink}[[ShadowInterior]{.UGHyperlink}](ms-xhelp:///?Id=a78221a2-2f66-41bd-925e-bb300459b813)[, ]{.UGHyperlink}[[ShadowOffset]{.UGHyperlink}](ms-xhelp:///?Id=717b660b-758f-4d1f-adf1-797d6889091a)[, ]{.UGHyperlink}[[FancyToolTip]{.UGHyperlink}](ms-xhelp:///?Id=7b6937b1-502a-4e90-bd42-84d57d75bb35)[, ]{.UGHyperlink}[[Font]{.UGHyperlink}](ms-xhelp:///?Id=765192ed-b1af-4b4d-b2fa-5722124eee34)[, ]{.UGHyperlink}[[Interior]{.UGHyperlink}](ms-xhelp:///?Id=765192ed-b1af-4b4d-b2fa-5722124eee34)[, ]{.UGHyperlink}[[LegendItem]{.UGHyperlink}](ms-xhelp:///?Id=a78221a2-2f66-41bd-925e-bb300459b813)[, ]{.UGHyperlink}[[Name,]{.UGHyperlink}](ms-xhelp:///?Id=717b660b-758f-4d1f-adf1-797d6889091a)[ ]{.UGHyperlink}[[PointsToolTipFormat]{.UGHyperlink}](ms-xhelp:///?Id=a78221a2-2f66-41bd-925e-bb300459b813)[, ]{.UGHyperlink}[[SmartLabels]{.UGHyperlink}](ms-xhelp:///?Id=eccf7f5c-95ee-4cac-930c-66fe7a166f51)[, ]{.UGHyperlink} |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [[Summary]{.UGHyperlink}](ms-xhelp:///?Id=426775ae-2fb9-4c0d-bca3-cfe54898e2d6)[, ]{.UGHyperlink}[[Text]{.UGHyperlink}](ms-xhelp:///?Id=426775ae-2fb9-4c0d-bca3-cfe54898e2d6)[, ]{.UGHyperlink}[[TextColor]{.UGHyperlink}](ms-xhelp:///?Id=a78221a2-2f66-41bd-925e-bb300459b813)[, ]{.UGHyperlink}[[TextFormat]{.UGHyperlink}](ms-xhelp:///?Id=717b660b-758f-4d1f-adf1-797d6889091a)[, ]{.UGHyperlink}[[TextOffset]{.UGHyperlink}](ms-xhelp:///?Id=a78221a2-2f66-41bd-925e-bb300459b813)[, ]{.UGHyperlink}[[TextOrientation]{.UGHyperlink}](ms-xhelp:///?Id=019d58b7-ee8a-4575-bb82-1949ef53a613)[, ]{.UGHyperlink}[[Visible]{.UGHyperlink}](ms-xhelp:///?Id=49bb6867-ab99-4958-864c-15702fa03a00)[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; COLOR: black; FONT-SIZE: 9pt"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#related-topics}
:::::
