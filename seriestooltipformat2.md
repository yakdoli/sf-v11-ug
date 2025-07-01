::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### SeriesToolTipFormat {#seriestooltipformat style="tab-stops: 0pt"}

 

Specifies the format for tooltip display in series.

 

::: {align="center"}
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
|                                                                                                                                                                                                    |
|                                                                                                                                                                                                    |
| Details                                                                                                                                                                                            |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Possible Values**                 | [·      ]{style="FONT-FAMILY: Symbol"}**{0}**  -  Series Name                                                                                                |
|                                     |                                                                                                                                                              |
|                                     | [·      ]{style="FONT-FAMILY: Symbol"}**{1}**  -  Series Style tooltip                                                                                       |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Default Value    **               | **{0}**                                                                                                                                                      |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **2D / 3D Limitations**             | No                                                                                                                                                           |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Applies to Chart Element**        | Any Series                                                                                                                                                   |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Applies to Chart Types**          | Area Charts, Radar Chart, Polar Chart, ThreeLineBreak Chart,PointAndFigure Chart, StepLine Chart, Spline Chart, HiloOpenClose(3D), RotatedSpline, Kagi Chart |
+-------------------------------------+--------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

Here is some sample code.

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                              |
|                                                                                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                             |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.Series\[1\].SeriesToolTipFormat=\"]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[{0}]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\";]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                |
| [Private]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ Me.chartControl1.Series(1).SeriesToolTipFormat=\"]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[{0}]{style="FONT-FAMILY: 'Courier New'; COLOR: maroon"}[\"]{style="FONT-FAMILY: 'Courier New'; COLOR: black"} |
+--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image84_192.jpg){border="0"}

**[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}** 

Figure 192: SeriesToolTipFormat set = \"{0}\"

 

See Also

 

[Area Charts]{.UGHyperlink}, [Radar Chart]{.UGHyperlink}, [Polar Chart]{.UGHyperlink}, [ThreeLineBreak Chart]{.UGHyperlink},[PointAndFigure Chart]{.UGHyperlink}, [StepLine Chart]{.UGHyperlink}, [Spline Chart]{.UGHyperlink}, [HiloOpenClose]{.UGHyperlink}(3D), [RotatedSpline]{.UGHyperlink}, [Kagi Chart]{.UGHyperlink}[]{style="COLOR: black"}

 

[]{#p143} 

 

[]{#related-topics}
::::
