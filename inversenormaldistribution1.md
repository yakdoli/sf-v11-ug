::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Inverse Normal Distribution {#inverse-normal-distribution style="tab-stops: 0pt"}

 

This formula returns an approximation of the inverse of the standard normal cumulative distribution. That is, for a given P, it returns an approximation to the x satisfying P=Pr{z is smaller than x} where z is a random variable from the standard normal distribution.

 

Using the Formula

 

InverseNormalDistribution is calculated using the **Statistics.UtilityFunctions** class. The following table describes its parameters and its values.

 

::: {align="center"}
  --------------------------- -------------------------------------------------------------------------------------------- ---------------------------------------------------------------------------
  Method Name                 Parameters                                                                                   Example
  InverseNormalDistribution   **p**: the probability at which the function value is evaluated. p must be in (0,1) range.   A double that represents the inverse of the normal distribution function.
  --------------------------- -------------------------------------------------------------------------------------------- ---------------------------------------------------------------------------
:::

 

The algorithm uses a minimax approximation by rational functions and the result has a relative error whose absolute value is less than 1.15e-9.

 

**Example**

 

Here is a code snippet that shows a sample usage.

 

+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                |
|                                                                                                                                                                               |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                      |
|                                                                                                                                                                               |
| [using Syncfusion.Windows.Forms.Chart.Statistics;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                          |
|                                                                                                                                                                               |
| [double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ x = Statistics.UtilityFunctions.InverseNormalDistribution( p );]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                           |
|                                                                                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                     |
|                                                                                                                                                                              |
| [Imports Syncfusion.Windows.Forms.Chart.Statistics]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                        |
|                                                                                                                                                                              |
| [double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ x = Statistics.UtilityFunctions.InverseNormalDistribution( p )]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p243} 

[]{#related-topics}
::::
