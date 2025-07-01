::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Inverse Error Function {#inverse-error-function style="tab-stops: 0pt"}

 

The Inverse Error function, which is a rational approximation of the error function, gives the element-by-element inverse of the error function. The absolute value of the relative error is less than 1.15 -10.9 in the entire region.

 

Using the formula

 

The below table describes this function in detail.

 

::: {align="center"}
  ---------------------- ------------------------------- ----------------------------------------------------
  Method Name            Parameters                      Return Value
  InverseErrorFunction   x must be less than 1.15-10.9   A double that gives the inverse of error function.
  ---------------------- ------------------------------- ----------------------------------------------------
:::

 

Example

 

Here is a code snippet that shows a sample usage.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                      |
|                                                                                                                                                     |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                            |
|                                                                                                                                                     |
| [using Syncfusion.Windows.Forms.Chart.Statistics;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                |
|                                                                                                                                                     |
| [int]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ double = UtilityFunctions.InverseErf(x);]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                           |
|                                                                                                                                                              |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                     |
|                                                                                                                                                              |
| [Imports Syncfusion.Windows.Forms.Chart.Statistics]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                        |
|                                                                                                                                                              |
| [Dim double as]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ result = UtilityFunctions.InverseErf(x)]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

[]{#p241} 

 

[]{#related-topics}
::::
