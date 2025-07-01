::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Median {#median style="tab-stops: 0pt"}

 

**Median** is a statistical formula that is used to find the median of y values of a series. Median can be calculated by arranging the values from the lowest to the highest and picking up the middle one. If the total number of values is even, then pick up the two middle values after sorting the values in ascending order. The mean of these two middle values will give you the median. Hence half of the series points have values less than the median and the values of the other half will be greater than the median.

 

Median can be found out for any series by using the Median method of **BasicStatisticalFormulas** class. The below table shows the details of this method.

 

::: {align="center"}
  ------------- --------------------------------------------------------------------------------------- ----------------------------------------------------------------------------------------
  Method Name   Parameter                                                                               Return value
  Median        **InputSeries**: A ChartSeries type object for whose X values an average is required.   A **double** that represents the Median value of all the X values in the given series.
  ------------- --------------------------------------------------------------------------------------- ----------------------------------------------------------------------------------------
:::

 

Example

 

Here is a code snippet that shows a sample usage.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                        |
|                                                                                                                                                                                       |
| []{style="COLOR: black"}                                                                                                                                                              |
|                                                                                                                                                                                       |
| [using Syncfusion.Windows.Forms.Chart.Statistics;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                  |
|                                                                                                                                                                                       |
| [\...\...\...\...]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                  |
|                                                                                                                                                                                       |
| [double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ calculatedMedian = Statistics.BasicStatisticalFormulas.Median(series1);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                              |
|                                                                                                                                                                                 |
| []{style="COLOR: black"}                                                                                                                                                        |
|                                                                                                                                                                                 |
| [Imports Syncfusion.Windows.Forms.Chart.Statistics]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                           |
|                                                                                                                                                                                 |
| [\...\...\...\....]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                           |
|                                                                                                                                                                                 |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Median1 ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As Double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                 |
| [calculatedMedian = BasicStatisticalFormulas.Median(series1)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                 |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
[![](ImagesExt/image84_1.jpg){border="0"}]{style="COLOR: black"}Note: For further details, refer to this Browser Sample:
:::

 

[\[Installed drive\]:\\Documents and Settings\\\[User name\]\\My Documents\\Syncfusion\\EssentialStudio\\\[Installed version\]\\Windows\\Chart.Windows\\Samples\\2.0\\Statistical Analysis\\Chart Statistical Formulas]{.UGHyperlink}

[]{#p223} 

 

[]{#related-topics}
:::::
