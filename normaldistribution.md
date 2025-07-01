::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### Normal Distribution {#normal-distribution style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

This formula yields the value of the standard normal cumulative distribution. Normal distributions are symmetric and have bell-shaped density curves with a single peak. Two factors, the mean (*[μ]{style="COLOR: black; FONT-SIZE: 8pt"}*) and the standard deviation ([σ]{style="COLOR: black; FONT-SIZE: 8pt"}), come into place when we speak of normal distribution. The mean indicates the peak of the density curve and the standard deviation indicates the spread of the bell curve.

 

The normal density function is given by:

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

[![](ImagesExt/image64_337.jpg){border="0"}]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

![](ImagesExt/image64_338.jpg){border="0"}

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

Figure 309: Normal Density Function

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Different values of *[μ]{style="COLOR: black; FONT-SIZE: 8pt"}[ ]{style="FONT-FAMILY: 'Verdana','sans-serif'; COLOR: black; FONT-SIZE: 8pt"}*and [σ]{style="COLOR: black; FONT-SIZE: 8pt"} yield different normal density curves and hence different normal distributions.  All normal density curves satisfy the following property which is often referred to as the*[ ]{style="FONT-FAMILY: 'Segoe UI','sans-serif'"}*Empirical Rule.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

[·      ]{style="FONT-FAMILY: Symbol"}68% of the observations fall within 1 standard deviation of the mean, that is, between *[μ]{style="FONT-SIZE: 8pt"}* - [σ]{style="FONT-SIZE: 8pt"} and *[μ]{style="FONT-SIZE: 8pt"}* + [σ]{style="FONT-SIZE: 8pt"}.

[·      ]{style="FONT-FAMILY: Symbol"}95% of the observations fall within 2 standard deviations of the mean, that is, between *[μ]{style="FONT-SIZE: 8pt"}* - 2[σ]{style="FONT-SIZE: 8pt"} and *[μ]{style="FONT-SIZE: 8pt"}* + 2[σ]{style="FONT-SIZE: 8pt"}.

[·      ]{style="FONT-FAMILY: Symbol"}99.7% of the observations fall within 3 standard deviations of the mean, that is, between *[μ]{style="FONT-SIZE: 8pt"}* - 3[σ]{style="FONT-SIZE: 8pt"} and *[μ]{style="FONT-SIZE: 8pt"}* + 3[σ]{style="FONT-SIZE: 8pt"}.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Thus, for a normal distribution, almost all values lie within three standard deviations of the mean.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Using the Formula

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

NormalDistribution is calculated using the **Statistics.UtilityFunctions** class. The following table describes this formula\'s parameters and its values.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

::: {align="center"}
+-----------------------+-----------------------------------------------------------+-----------------------------------------------------------------------------+
|                       |                                                           |                                                                             |
|                       |                                                           |                                                                             |
| Method Name           | Parameters                                                | Return Value                                                                |
+-----------------------+-----------------------------------------------------------+-----------------------------------------------------------------------------+
| NormalDistribution    | zValue: The value for which the distribution is required. | A double that represents the standard normal cumulative distribution value. |
+-----------------------+-----------------------------------------------------------+-----------------------------------------------------------------------------+
:::

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Example

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Here is a code snippet that shows a sample usage.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                         |
|                                                                                                                                                                        |
| []{style="COLOR: black"}                                                                                                                                               |
|                                                                                                                                                                        |
| [using Syncfusion.Windows.Forms.Chart.Statistics;]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                   |
|                                                                                                                                                                        |
| [double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ x = Statistics.UtilityFunctions.NormalDistribution( p );]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                    |
|                                                                                                                                                                       |
| []{style="COLOR: black"}                                                                                                                                              |
|                                                                                                                                                                       |
| [Imports Syncfusion.Windows.Forms.Chart.Statistics]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}                                                                 |
|                                                                                                                                                                       |
| [double]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ x = Statistics.UtilityFunctions.NormalDistribution( p )]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{#p244} 

[]{#related-topics}
::::
