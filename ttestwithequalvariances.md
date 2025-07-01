::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
##### TTest with Equal Variances {#ttest-with-equal-variances style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

This type of TTest can be performed on two random series that have no relationship with each other. But they should be of equal sizes, i.e., the number of data points of the two series should be same.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Steps to perform the test

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'"}** 

1.   Specify the null hypothesis and alternate hypothesis.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}Null Hypothesis - Difference between the two means is **zero**.

[·      ]{style="FONT-FAMILY: Symbol"}Alternate Hypothesis - Difference between the two means is not **zero**.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

2.   Calculate the [means]{.UGHyperlink} of the two input series (µ1 and µ2)and calculate their difference (Md).

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Md = µ1 - µ2

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

1\. Calculate the variances of the two input series (s1 and s2).

2\. Let n1 and n2 be the number of data points in first and second series respectively.

3\. Calculate the degrees of freedom.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

D = n1 + n2 - 2

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

3.   As a next step, Calculate the Pooled Estimator as below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Sp = (n1 - 1) \* s1 + (n2 - 1) \* s2

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

4.   Calculate the T-statistic as given below.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

t = (µ1  - µ2 - Md) / Sqrt(Sp/n1 + Sp/n2)

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

5.   Construct a t-table at (n1+n2-2) degrees of freedom.

6.   Choose a level of significance(probability), say p = 0.05 and read the tabulated value.

7.   If the calculated tvalue exceeds the tabulated value we can say that the means are significantly different at that level of probability.

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

Using the Formula

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'"}** 

The TTest formula for equal variances can be calculated by using the **TTestEqualVariances** method of the **BasicStatisticalFormulas** class. The following table presents the details of this method. This method returns an instance of **TTestResult** class that stores the resultant values of this test such as means of the two series, T value, degrees of freedom, number of points in every series, T critical value and confidence level(probability).

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------+-----------------------------------------------------------------------------------------------------------------+-----------------------------------------------------------------------+
| Method Name           | Parameters                                                                                                      | Return Value                                                          |
+-----------------------+-----------------------------------------------------------------------------------------------------------------+-----------------------------------------------------------------------+
| TTestEqualVariances   | 1.   **HypothesizedMeanDifference**: A **double** value specifying the difference between two population means. | A TTestResult object that has the following members:                  |
|                       |                                                                                                                 |                                                                       |
|                       | 2.   **Probability**: A **double** value that gives the confidence level.                                       | []{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}  |
|                       |                                                                                                                 |                                                                       |
|                       | 3.   **FirstInputSeries**: A ChartSeries object that stores the first group of data.                            | [·      ]{style="FONT-FAMILY: Symbol"}FirstSeriesMean                 |
|                       |                                                                                                                 |                                                                       |
|                       | 4.   **SecondInputSeries**: A ChartSeries object that stores the second group of data.                          | [·      ]{style="FONT-FAMILY: Symbol"}SecondSeriesMean                |
|                       |                                                                                                                 |                                                                       |
|                       |                                                                                                                 | [·      ]{style="FONT-FAMILY: Symbol"}FirstSeriesVariance             |
|                       |                                                                                                                 |                                                                       |
|                       |                                                                                                                 | [·      ]{style="FONT-FAMILY: Symbol"}SecondSeriesVariance            |
|                       |                                                                                                                 |                                                                       |
|                       |                                                                                                                 | [·      ]{style="FONT-FAMILY: Symbol"}Tvalue                          |
|                       |                                                                                                                 |                                                                       |
|                       |                                                                                                                 | [·      ]{style="FONT-FAMILY: Symbol"}DegreeOfFreedom                 |
|                       |                                                                                                                 |                                                                       |
|                       |                                                                                                                 | [·      ]{style="FONT-FAMILY: Symbol"}ProbabilityTOneTail             |
|                       |                                                                                                                 |                                                                       |
|                       |                                                                                                                 | [·      ]{style="FONT-FAMILY: Symbol"}TCriticalValueOneTail           |
|                       |                                                                                                                 |                                                                       |
|                       |                                                                                                                 | [·      ]{style="FONT-FAMILY: Symbol"}ProbabilityTTwoTail             |
|                       |                                                                                                                 |                                                                       |
|                       |                                                                                                                 | [·      ]{style="FONT-FAMILY: Symbol"}TCriticalValueTwoTail           |
+-----------------------+-----------------------------------------------------------------------------------------------------------------+-----------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Example

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Here is a code snippet that shows a sample usage.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+---------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                          |
|                                                                                                                                                         |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                |
|                                                                                                                                                         |
| [using]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Windows.Forms.Chart.Statistics;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
|                                                                                                                                                         |
| [TTestResult ttr = BasicStatisticalFormulas.TTestEqualVariances (0.2, 0.05, series1, series2);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}       |
+---------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                |
|                                                                                                                                                                                                                                                                                                                   |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                   |
| [Imports]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Syncfusion.Windows.Forms.Chart.Statistics]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                   |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ttr ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ TTestResult = BasicStatisticalFormulas.TTestEqualVariances (0.2, 0.05, series1, series2)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p226} 

[]{#related-topics}
::::
