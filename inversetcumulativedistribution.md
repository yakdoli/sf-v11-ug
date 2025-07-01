::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Inverse T Cumulative Distribution {#inverse-t-cumulative-distribution style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

This formula computes the inverse of the cumulative distribution for T-statistic.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Using the Formula

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

InverseTCumulativeDistribution is calculated using the **Statistics.UtilityFunctions** class. The following table describes this function\'s parameters and its values.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+--------------------------------+--------------------------------------------------------------------------------------------------------+-----------------------------------------------------------------------------------------+
| Method Name                    | Parameters                                                                                             | Return Value                                                                            |
+--------------------------------+--------------------------------------------------------------------------------------------------------+-----------------------------------------------------------------------------------------+
| InverseTCumulativeDistribution | 1.   **p**: the alpha value (probability).                                                             | A double that represents the Inverse of T cumulative distribution function probability. |
|                                |                                                                                                        |                                                                                         |
|                                | 2.   **degreeOfFreedom**: an integer value that represents the degree of freedom.                      |                                                                                         |
|                                |                                                                                                        |                                                                                         |
|                                | 3.   **oneTail**: If true, one-tailed distribution is used; otherwise two-tailed distribution is used. |                                                                                         |
+--------------------------------+--------------------------------------------------------------------------------------------------------+-----------------------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Example

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Here is a code snippet that shows a sample usage.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                              |
|                                                                                                                                                                                                             |
| []{style="COLOR: black"}                                                                                                                                                                                    |
|                                                                                                                                                                                                             |
| [using Syncfusion.Windows.Forms.Chart.Statistics;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                        |
|                                                                                                                                                                                                             |
| [double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ x= Statistics.UtilityFunctions. InverseTCumulativelDistribution(p, degreeOfFreedom,OneTail );]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                         |
|                                                                                                                                                                                                            |
| []{style="COLOR: black"}                                                                                                                                                                                   |
|                                                                                                                                                                                                            |
| [Imports Syncfusion.Windows.Forms.Chart.Statistics]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                      |
|                                                                                                                                                                                                            |
| [double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ x= Statistics.UtilityFunctions. InverseTCumulativelDistribution(p, degreeOfFreedom,OneTail )]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p246} 

[]{#related-topics}
::::
