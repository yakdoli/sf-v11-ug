::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {#nsbanner .d2h_main_nsbanner style="BORDER-BOTTOM: #999999 1px solid; POSITION: relative; PADDING-BOTTOM: 0px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 0px; PADDING-RIGHT: 0px; DISPLAY: none; BORDER-TOP: #999999 1px solid; PADDING-TOP: 0px; LEFT: 0px"}
:::: {#TitleRow .d2h_main_titlerow style="PADDING-BOTTOM: 4px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; WIDTH: 100%; PADDING-RIGHT: 10px; DISPLAY: none; PADDING-TOP: 4px"}
::: {#ienav .d2h_main_ienav style="DISPLAY: none"}
[](ms-xhelp:///?Id=e6fe8284-cc11-4e3d-9a12-7bde7e953598){#D2HPrevious .D2HPreviousEnabled}  [](ms-xhelp:///?Id=e1f421a2-30fc-4bc4-8ae5-731ad60092bf){#D2HNext .D2HNextEnabled}
:::
::::
:::::

::::::: {#nstext .d2h_main_nstext style="PADDING-BOTTOM: 10px; BACKGROUND-COLOR: transparent; PADDING-LEFT: 22px; PADDING-RIGHT: 10px; HEIGHT: 100%; OVERFLOW: auto; PADDING-TOP: 5px" hasuserbackground="true" valign="bottom"}
::: {#d2h_breadcrumbs .d2h_breadcrumbs}
[Essential Studio User Guide Documentation](ms-xhelp:///?Id=12457748-09e3-4d74-a240-8e049cedf030){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[User Interface Edition](ms-xhelp:///?Id=c29296b7-531c-413b-a0ec-488ca1f7f669){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Windows](ms-xhelp:///?Id=e60759d8-47a4-4570-9d7a-16a68d63f2ea){.d2h_breadcrumbsNormal}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Essential Chart]{.d2h_breadcrumbsContentsOnly}[ \> ]{.d2h_breadcrumbsLinkSeparator}[Concepts and Features](ms-xhelp:///?Id=71321e9c-336c-4c1c-a127-be9f135ad4bb){.d2h_breadcrumbsNormal}
:::

## Chart Series {#chart-series style="tab-stops: 0pt"}

 

Provide data for the chart through the **ChartSeries**. ChartSeries acts as a wrapper around data that is to be displayed, and associates styles with the data. The data that is to be displayed is contained in either the **IChartSeriesModel** or the **IEditableChartSeriesModel** implementation. The style used to display the points is stored in a contained implementation of IChartSeriesStylesModel.

 

Here is some sample code to create a new series and add it to the chart.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                           |
|                                                                                                                                                                                                                                                                          |
| []{style="COLOR: black; FONT-SIZE: 12pt"}                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                          |
| [// 1) One way to create a series:]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                          |
| [ChartSeries]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ series = [new]{style="COLOR: blue"} [ChartSeries]{style="COLOR: teal"}([\"Sales Performance\"]{style="COLOR: maroon"}, [ChartSeriesType]{style="COLOR: teal"}.Bar);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                          |
| [series.Points.Add(0,200);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                          |
| [series.Points.Add(1,300);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                          |
| [// Remember to add the series to the chart.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                          |
| [chartControl1.Series.Add(series);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                          |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                          |
| [// 2) Another way to create a series]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                          |
| [// This will automatically add the series to the chart]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                               |
|                                                                                                                                                                                                                                                                          |
| [ChartSeries]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ series = chartControl1.Model.NewSeries([\"Sales Performance\"]{style="COLOR: maroon"}, [ChartSeriesType]{style="COLOR: teal"}.Bar);]{style="FONT-FAMILY: 'Courier New'"}                                 |
|                                                                                                                                                                                                                                                                          |
| [series.Points.Add(0,200);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                          |
| [series.Points.Add(1,300);]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                          |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                   |
| []{style="COLOR: black; FONT-SIZE: 12pt"}                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                   |
| [\' 1) One way to create a series:]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ series1 [As]{style="COLOR: blue"} ChartSeries = [New]{style="COLOR: blue"} ChartSeries([\"Sales Performance\"]{style="COLOR: maroon"}, ChartSeriesType.Bar)]{style="FONT-FAMILY: 'Courier New'"}          |
|                                                                                                                                                                                                                                                                   |
| [series.Points.Add(0,200)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                   |
| [series.Points.Add(1,300)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                   |
| [\' Remember to add the series to the chart.]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                   |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series.Add(series)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                      |
|                                                                                                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                   |
| [\' 2) Another way to create a series]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                   |
| [\' This will automatically add the series to the chart]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                                                                        |
|                                                                                                                                                                                                                                                                   |
| [ChartSeries]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ series = [Me]{style="COLOR: blue"}.chartControl1.Model.NewSeries([\"Sales Performance\"]{style="COLOR: maroon"}, [ChartSeriesType]{style="COLOR: teal"}.Bar)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                   |
| [series.Points.Add(0,200)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                   |
| [series.Points.Add(1,300)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                    |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image84_1.jpg){border="0"}Note: Same ChartSeries object being added to more than one chart is not supported. It binds the series to the default primary axis always.
:::

 

 

Chart Points

 

The ChartPoint class holds value information about a single point in a series (x and y values). The following table describes the kind of x and y values you can specify via a chart point.

 

::: {align="center"}
  ------ ------------------ --------------------
  Axis   Number of Values   Value Types
  X      1                  double or DateTime
  Y      1 or more          double or DateTime
  ------ ------------------ --------------------
:::

 

Here is some sample code that shows adding data points to the **Points** collection. You could also optionally create a ChartPoint instance first and then add it to the Points collection.

 

+-----------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                  |
|                                                                                                                 |
| []{style="COLOR: black; FONT-SIZE: 12pt"}                                                                       |
|                                                                                                                 |
| [// Option 1: 1 X double value; 2 double Y values in a point]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                 |
| [series1.Points.Add(0, 2.5, 3.5);]{style="FONT-FAMILY: 'Courier New'"}                                          |
|                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                 |
| [// Option 2: 1 X double value; 1 DateTime Y value]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}           |
|                                                                                                                 |
| [series2.Points.Add(1, DateTime.Now);]{style="FONT-FAMILY: 'Courier New'"}                                      |
|                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                 |
| [// Option 3: 1 X DateTime value; 1 double Y value]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}           |
|                                                                                                                 |
| [series1.Points.Add([DateTime]{style="COLOR: teal"}.Now, 5.3);]{style="FONT-FAMILY: 'Courier New'"}             |
+-----------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                              |
|                                                                                                                 |
| []{style="COLOR: black; FONT-SIZE: 12pt"}                                                                       |
|                                                                                                                 |
| [\' Option 1: 1 X double value; 2 double Y values in a point]{style="FONT-FAMILY: 'Courier New'; COLOR: green"} |
|                                                                                                                 |
| [series1.Points.Add(0, 2.5, 3.5)]{style="FONT-FAMILY: 'Courier New'"}                                           |
|                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                 |
| [\' Option 2: 1 X double value; 1 DateTime Y value]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}           |
|                                                                                                                 |
| [series2.Points.Add(1, DateTime.Now)]{style="FONT-FAMILY: 'Courier New'"}                                       |
|                                                                                                                 |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                          |
|                                                                                                                 |
| [\' Option 3: 1 X DateTime value; 1 double Y value]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}           |
|                                                                                                                 |
| [series1.Points.Add([DateTime]{style="COLOR: teal"}.Now, 5.3)]{style="FONT-FAMILY: 'Courier New'"}              |
+-----------------------------------------------------------------------------------------------------------------+

 

 

 

**ValueType**

 

Always use the **ChartAxis.ValueType** property to specify what kind of values you have added in the series data points for the corresponding axis.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                       |
|                                                                                                                                                                                      |
| []{style="COLOR: black; FONT-SIZE: 12pt"}                                                                                                                                            |
|                                                                                                                                                                                      |
| [// To specify DateTime values in the X axis]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                      |
|                                                                                                                                                                                      |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.PrimaryXAxis.ValueType = [ChartValueType]{style="COLOR: teal"}.DateTime;]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                      |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                               |
|                                                                                                                                                                                      |
| [// To specify Double values]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                      |
|                                                                                                                                                                                      |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.PrimaryXAxis.ValueType = [ChartValueType]{style="COLOR: teal"}.Double;]{style="FONT-FAMILY: 'Courier New'"}   |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black; FONT-SIZE: 8pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                |
|                                                                                                                                                                                   |
| []{style="COLOR: black; FONT-SIZE: 12pt"}                                                                                                                                         |
|                                                                                                                                                                                   |
| [\' To specify DateTime values in the X axis]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                   |
|                                                                                                                                                                                   |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.PrimaryXAxis.ValueType = [ChartValueType]{style="COLOR: teal"}.DateTime]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                   |
| []{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                            |
|                                                                                                                                                                                   |
| [\' To specify Double values]{style="FONT-FAMILY: 'Courier New'; COLOR: green"}                                                                                                   |
|                                                                                                                                                                                   |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.PrimaryXAxis.ValueType = [ChartValueType]{style="COLOR: teal"}.Double]{style="FONT-FAMILY: 'Courier New'"}   |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: red; FONT-SIZE: 8pt"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
Note : To display the text right next to the data points, the [DisplayText]{style="COLOR: black"} property of the data point\'s style should be set.

 
:::

The Chart Series features are elaborated in more detail in the following sub-topics.

 

[]{#p76} 

More:

[ ]{#related-topics}

[![](button.gif){border="0" align="absMiddle"}Series Customization](ms-xhelp:///?Id=e1f421a2-30fc-4bc4-8ae5-731ad60092bf){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Data Point Labels, Tooltips and Symbols](ms-xhelp:///?Id=d7448f12-46cf-43fb-b4a9-243e35c0ef96){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Custom Points](ms-xhelp:///?Id=6d99025c-88aa-4eec-918d-26648ad8a392){style="TEXT-DECORATION: none"}

[![](button.gif){border="0" align="absMiddle"}Empty Points](ms-xhelp:///?Id=429d9c55-f760-467f-ae74-ba858d8868da){style="TEXT-DECORATION: none"}
:::::::
