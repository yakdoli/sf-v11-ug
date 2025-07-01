::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Variance {#variance style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

**Variance** is a statistical formula that calculates the variance of series y values. A Variance can be defined as the square of the standard deviation of a sample.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Using the Formula

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

The variance can be computed for any series by using the method **Variance** of **BasicStatisticalFormulas** class. Below table shows the details of this method.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------+---------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------------------+
| Method Name           | Parameters                                                                                                                            | Return Value                                                        |
+-----------------------+---------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------------------+
| Variance              | 1.   **InputSeries**: A ChartSeries object that represents the input series.                                                          | A **double** that represents the variance within the group of data. |
|                       |                                                                                                                                       |                                                                     |
|                       | 2.   **SampleVariance**: A boolean value; **true** if the data is a sample of a population, **false** if it is the entire population. |                                                                     |
+-----------------------+---------------------------------------------------------------------------------------------------------------------------------------+---------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Example

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Variance is the square of the standard deviation for the given data.  

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                             |
|                                                                                                                                                                            |
| []{style="COLOR: black"}                                                                                                                                                   |
|                                                                                                                                                                            |
| [using Syncfusion.Windows.Forms.Chart.Statistics;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                       |
|                                                                                                                                                                            |
| [\...\...\...\...]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                       |
|                                                                                                                                                                            |
| [double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Variance1= BasicStatisticalFormulas.Variance(series1,false);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                          |
|                                                                                                                                                                             |
| []{style="COLOR: black"}                                                                                                                                                    |
|                                                                                                                                                                             |
| [Imports Syncfusion.Windows.Forms.Chart.Statistics]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                       |
|                                                                                                                                                                             |
| [\...\...\...\....]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                       |
|                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Variance1 ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As Double\                                            |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[Variance1=BasicStatisticalFormulas.Variance (series1,false)          ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p229} 

[]{#related-topics}
::::
