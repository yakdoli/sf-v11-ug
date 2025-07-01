::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

::::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Covariance {#covariance style="tab-stops: 0pt"}

 

**Covariance** is a statistical formula that measures the extent to which the y values of two series vary together. It is basically used to measure the fluctuations between two quantities. For a given pairs of series y values, the covariance can be calculated by taking their differences from their mean values and multiplying these differences together. That is,

 

*Cov(x,y) =* *Σ{\[ x-Σ(x) \]\[ y-Σ(y) \]}*

 

If this product is **positive**, then the values would be varying in the same direction; if it is **negative**, then the values would be varying in opposite directions. If the product is **zero**, then we can conclude that there is no linear relationship between the series values. The above formula can be simplified as below.

 

*Cov(x,y) =* *Σ{xy} -* *Σ{x}Σ{y}*

 

**Using the Formula**

 

The Covariance can easily be calculated by using the **Covariance** method available with the **BasicStatisticalFormulas** class. The following table describes the details of this method.

 

::: {align="center"}
+-----------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+-----------------------------------------------------------------------------------------+
| Method Name           | Parameters                                                                                                                                                                            | Return Value                                                                            |
+-----------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+-----------------------------------------------------------------------------------------+
| Covariance            | 1\. **FirstInputSeriesName**: A ChartSeries object that stores the first group\'s data.                                                                                               | A **double** value that represents the covariance value between the two groups of data. |
|                       |                                                                                                                                                                                       |                                                                                         |
|                       | 2\. **SecondInputSeriesName**: A ChartSeries object that stores the second group\'s data. An exception will be raised if the input series do not have the same number of data points. |                                                                                         |
+-----------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+-----------------------------------------------------------------------------------------+
:::

 

Example

 

Here is the code snippet that demonstrates the usage of this method.

 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                              |
|                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                    |
|                                                                                                                                                                                             |
| [using Syncfusion.Windows.Forms.Chart.Statistics;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                        |
|                                                                                                                                                                                             |
| [\...\...\...\...]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                        |
|                                                                                                                                                                                             |
| [double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Covariance1= Statistics.BasicStatisticalFormulas.Covariance(series1,series2);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                  |
|                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                            |
|                                                                                                                                                                                     |
| [Imports Syncfusion.Windows.Forms.Chart.Statistics]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                               |
|                                                                                                                                                                                     |
| [\...\...\...\....]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                               |
|                                                                                                                                                                                     |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Covariance1 ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[As Double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"} |
|                                                                                                                                                                                     |
| [Covariance1=BasicStatisticalFormulas.Covariance (series,series1)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

::: {style="BORDER-BOTTOM: windowtext 1pt solid; BORDER-LEFT: medium none; PADDING-BOTTOM: 1pt; MARGIN-TOP: 9pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; MARGIN-BOTTOM: 9pt; BORDER-TOP: windowtext 1pt solid; BORDER-RIGHT: medium none; PADDING-TOP: 1pt"}
![](ImagesExt/image84_1.jpg){border="0"}Note: For further details, refer to this Browser Sample:
:::

 

[\[Installed drive\]:\\Documents and Settings\\\[User name\]\\My Documents\\Syncfusion\\EssentialStudio\\\[Installed version\]\\Windows\\Chart.Windows\\Samples\\2.0\\Statistical Analysis\\Chart Statistical Formulas]{.UGHyperlink}

 

[]{#p220} 

[]{#related-topics}
:::::
