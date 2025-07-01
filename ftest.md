::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### F-Test {#f-test style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

The **F-Test** is a statistical test, which is carried out to find out whether two series have the same standard deviation with the specified confidence level. It is achieved by comparing the variances of the series values and thereby comparing their standard deviations. Here, the null hypothesis is that the two variances are equal. All hypothesis testing is done under the assumption that the null hypothesis is **true**.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Steps to perform F-Test

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Calculate the variances of both the series.

Calculate F Ratio as given below.

 

F Value = firstSeriesVariance / secondSeriesVariance.

 

F-Test can be easily performed by using the **FTest** method of **BasicStatisticalFormulas** class that returns the results as a type of **FTestResult**. The FTestResult is a class implemented to save the F test result as **FValue** and other computation results such as series means, series variances, FRatio and FCriticalValue of the test. Below is a detailed table for the FTest method. 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------+--------------------------------------------------------------------------------------------------+-------------------------------------------------------------+
|                       |                                                                                                  |                                                             |
|                       |                                                                                                  |                                                             |
| Method Name           | Parameters                                                                                       | Returns                                                     |
+-----------------------+--------------------------------------------------------------------------------------------------+-------------------------------------------------------------+
| FTest                 | 1.   **Probability**: Probability that gives the confidence level.                               | An FTestResult has the following members:                   |
|                       |                                                                                                  |                                                             |
|                       | 2.   **FirstInputSeries**: Type of ChartSeries object that represents the first group of data.   | [·      ]{style="FONT-FAMILY: Symbol"}FirstSeriesMean       |
|                       |                                                                                                  |                                                             |
|                       | 3.   **SecondInputSeries**: Type of ChartSeries object that represents the second group of data. | [·      ]{style="FONT-FAMILY: Symbol"}SecondSeriesMean      |
|                       |                                                                                                  |                                                             |
|                       |                                                                                                  | [·      ]{style="FONT-FAMILY: Symbol"}FirstSeriesVariance   |
|                       |                                                                                                  |                                                             |
|                       |                                                                                                  | [·      ]{style="FONT-FAMILY: Symbol"}SecondSeriesVariance  |
|                       |                                                                                                  |                                                             |
|                       |                                                                                                  | [·      ]{style="FONT-FAMILY: Symbol"}FValue                |
|                       |                                                                                                  |                                                             |
|                       |                                                                                                  | [·      ]{style="FONT-FAMILY: Symbol"}ProbabilityFOneTail   |
|                       |                                                                                                  |                                                             |
|                       |                                                                                                  | [·      ]{style="FONT-FAMILY: Symbol"}FCriticalValueOneTail |
+-----------------------+--------------------------------------------------------------------------------------------------+-------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Example

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Here is a code snippet that shows a sample usage.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                   |
|                                                                                                                                                                                  |
| []{style="COLOR: black"}                                                                                                                                                         |
|                                                                                                                                                                                  |
| [FTestResult ttr = Syncfusion.Windows.Forms.Chart.Statistics.BasicStatisticalFormulas.FTest(confidenceLevel,series1,series2);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                                                                                                  |
| []{style="COLOR: black"}                                                                                                                                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                                                                                                  |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ttr ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ FTestResult = Syncfusion.Windows.Forms.Chart.Statistics.BasicStatisticalFormulas.FTest(confidenceLevel,series1,series2)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image64_1.jpg){border="0"}Note: For further details, refer the following Browser Sample:
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

\[Install Location\]\\Syncfusion\\EssentialStudio\\\[***Installed version***\]\\Web\\chart.web\\Samples\\3.5\\Statistics\\ChartStatisticalFormulas

[]{#p221} 

[]{#related-topics}
:::::
