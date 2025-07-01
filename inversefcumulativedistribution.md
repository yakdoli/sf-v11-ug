::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Inverse F Cumulative Distribution {#inverse-f-cumulative-distribution style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

This formula returns the inverse of the F cumulative distribution.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Using the Formula

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

InverseFCumulativeDistribution is calculated using the **Statistics.UtilityFunctions** class. The following table describes its parameters and its values.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+--------------------------------+------------------------------------------------------------------------------------------------+-----------------------------------------------------------------+
| Method Name                    | Parameters                                                                                     | Return Value                                                    |
+--------------------------------+------------------------------------------------------------------------------------------------+-----------------------------------------------------------------+
| InverseFCumulativeDistribution | 1.   **fValue**: The F value for which you need the distribution.                              | A double that represents the inverse F cumulative distribution. |
|                                |                                                                                                |                                                                 |
|                                | 2.   **firstDegreeOfFreedom**: an integer value that represents the first degree of freedom.   |                                                                 |
|                                |                                                                                                |                                                                 |
|                                | 3.   **secondDegreeOfFreedom**: an integer value that represents the second degree of freedom. |                                                                 |
+--------------------------------+------------------------------------------------------------------------------------------------+-----------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Example

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Here is a code snippet that shows a sample usage.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]\                                                                                                                                                                                                                             |
| \                                                                                                                                                                                                                                      |
| ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                  |
|                                                                                                                                                                                                                                        |
| [using Syncfusion.Windows.Forms.Chart.Statistics;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                   |
|                                                                                                                                                                                                                                        |
| [double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ x= Statistics.UtilityFunctions. InverseFCumulativelDistribution( fvalue, firstdegreeOf Freedom, secondDegreeOfFreedom );]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                  |
|                                                                                                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                            |
|                                                                                                                                                                                                                                     |
| [Imports Syncfusion.Windows.Forms.Chart.Statistics]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                               |
|                                                                                                                                                                                                                                     |
| [double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ x= Statistics.UtilityFunctions. InverseFCumulativelDistribution(fvalue, firstdegreeOf Freedom, secondDegreeOfFreedom)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p242} 

[]{#related-topics}
::::
