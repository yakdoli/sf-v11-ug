::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Inverse Beta Cumulative Distribution {#inverse-beta-cumulative-distribution style="tab-stops: 0pt"}

 

This formula returns the inverse of Beta Cumulative Distribution.

[]{style="COLOR: #4a5c8c; FONT-SIZE: 8pt"} 

Using the formula

 

The **InverseBetaCumulativeDistribution** method of the **UtilityFunctions** class returns the inverse of beta cumulative distribution ( for 1 \>= p \>= 0 , a \> 0, b \> 0 ).

 

::: {align="center"}
+-----------------------------------+-------------------------------------------+----------------------------------------------------------------+
| Method Name                       | Parameters                                | Return Value                                                   |
+-----------------------------------+-------------------------------------------+----------------------------------------------------------------+
| InverseBetaCumulativeDistribution | 1\. a: First Parameter of Beta function.  | A double that inverses the beta cumulative distribution value. |
|                                   |                                           |                                                                |
|                                   | 2\. b: Second Parameter of Beta function. |                                                                |
|                                   |                                           |                                                                |
|                                   | 3\. p: The probability.                   |                                                                |
+-----------------------------------+-------------------------------------------+----------------------------------------------------------------+
:::

 

 

Example

 

Here is a code snippet that shows a sample usage.

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                       |
|                                                                                                                                                                                      |
| []{style="COLOR: black"}                                                                                                                                                             |
|                                                                                                                                                                                      |
| [using Syncfusion.Windows.Forms.Chart.Statistics;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                 |
|                                                                                                                                                                                      |
| [double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ result = UtilityFunctions.InverseBetaCumulativeDistribution (a, b, p);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                          |
| []{style="COLOR: black"}                                                                                                                                                                                                                                                                                                                                                                                 |
|                                                                                                                                                                                                                                                                                                                                                                                                          |
| [Imports Syncfusion.Windows.Forms.Chart.Statistics]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                          |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[as]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ result = UtilityFunctions.InverseBetaCumulativeDistribution (a, b, p)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p235} 

[]{#related-topics}
::::
