::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Standard Deviation {#standard-deviation style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

**StandardDeviation** is the statistical formula that is basically used to measure the variability. That is, it can be used to measure how spread out your data is. It can be defined as the square root of the variance where a variance is the average of the squared differences between the data points and the mean. In other words, it is named as the \'root-mean-square\' of the data values.

It can be used to check how tightly the data values are clustered around the mean. If the data points are close to the mean, then the standard deviation will be small or if the points are far from the mean, then the standard deviation is large or if all the data values are equal, then the standard deviation is **zero**.

The Standard Deviation can be calculated for any series by using the **StandardDeviation** method of **BasicStatisticalFormulas** class. Below is the detailed description of this method.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------+--------------------------------------------------------------------------------------------------------------+-------------------------------------------------------------------------------+
|                       |                                                                                                              |                                                                               |
|                       |                                                                                                              |                                                                               |
| Method Name           | Parameters                                                                                                   | Return Value                                                                  |
+-----------------------+--------------------------------------------------------------------------------------------------------------+-------------------------------------------------------------------------------+
| StandardDeviation     | 1.   **InputSeries**: A ChartSeries type object for on whose Y values this formula should be applied.        | A **double** that represents the standard deviation within the group of data. |
|                       |                                                                                                              |                                                                               |
|                       | 2.   **SampleVariance**: true if the data is a sample of a population, false if it is the entire population. |                                                                               |
+-----------------------+--------------------------------------------------------------------------------------------------------------+-------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Example

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Here is a code snippet that shows a sample usage.

[  ]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                        |
|                                                                                                                                                                                       |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                              |
|                                                                                                                                                                                       |
| [using Syncfusion.Windows.Forms.Chart.Statistics;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                  |
|                                                                                                                                                                                       |
| [\...\...\...\...]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                  |
|                                                                                                                                                                                       |
| [double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Deviation1 = BasicStatisticalFormulas.StandartDeviation(series1,false);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                 |
|                                                                                                                                                                                    |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                           |
|                                                                                                                                                                                    |
| [Imports Syncfusion.Windows.Forms.Chart.Statistics]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                              |
|                                                                                                                                                                                    |
| [\...\...\...\....]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                              |
|                                                                                                                                                                                    |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Deviation1 ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As Double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                    |
| [Deviation1 = BasicStatisticalFormulas. StandartDeviation  (series1,false)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                      |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="COLOR: black"} 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
[![](ImagesExt/image64_1.jpg){border="0"}]{style="COLOR: black"}Note: For further details, refer the following Browser Sample:
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

\[Install Location\]\\Syncfusion\\EssentialStudio\\\[***Installed version***\]\\Web\\chart.web\\Samples\\3.5\\Statistics\\ChartStatisticalFormulas

[]{#p224} 

[]{#related-topics}
:::::
