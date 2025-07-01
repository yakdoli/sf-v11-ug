::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### HighlightInterior {#highlightinterior style="tab-stops: 0pt"}

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

The auto highlight color for any series can be changed by setting the color at the **HighlightInterior** property of **ChartStyleInfo** class.

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

::: {align="center"}
+--------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Details                                                                                                                                                                                                                                  |
+--------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Possible Values          | RBG values ranges from 0 to 255                                                                                                                                                                               |
+--------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Default Value            | None                                                                                                                                                                                                          |
+--------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| 2D / 3D Limitations      | No                                                                                                                                                                                                            |
+--------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Applies to Chart Element | All series                                                                                                                                                                                                    |
+--------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Applies to Chart Types   | Bar Charts, Pie, Funnel, Pyramid,Bubble, Column, Area, Stacking Area, Stacking Area100, Line Charts, Box and Whisker, Gantt Chart , Tornado Chart, Polar And Radar Chart, Hi Lo Chart, Hi Lo Open Close Chart |
+--------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

Here is some sample code.

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

Series Wide Setting

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                  |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.AutoHighlight = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                      |
|                                                                                                                                                                                                                                                                  |
| [ChartSeries]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ series1 = [this]{style="COLOR: blue"}.ChartWebControl1.Series\[0\];]{style="FONT-FAMILY: 'Courier New'"}                                                                                         |
|                                                                                                                                                                                                                                                                  |
| [series1.Style.HighlightInterior = [new]{style="COLOR: blue"} [BrushInfo]{style="COLOR: teal"}([GradientStyle]{style="COLOR: teal"}.ForwardDiagonal, [Color]{style="COLOR: teal"}.Red, [Color]{style="COLOR: teal"}.White);]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.ChartWebControl1.AutoHighlight = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[True]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ series1 [As]{style="COLOR: blue"} [ChartSeries]{style="COLOR: teal"} = [Me]{style="COLOR: blue"}.ChartWebControl1.Series(0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [series1.Style.HighlightInterior = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[New]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[BrushInfo]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[GradientStyle]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.ForwardDiagonal, ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Red[, ]{style="COLOR: black"}[Color]{style="COLOR: teal"}[.]{style="COLOR: black"}White[)]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

![](ImagesExt/image64_148.jpg){border="0"}

**[]{style="COLOR: black; FONT-SIZE: 8pt"}** 

Figure 143: Column Chart with HighlightInterior

**[]{style="COLOR: black; FONT-SIZE: 8pt"}** 

Specific Data Point Setting

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

To set interior color for individual highlighted datapoints:

**[]{style="COLOR: black; FONT-SIZE: 8pt"}** 

+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                            |
|                                                                                                                                                                                                                                                                           |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                  |
|                                                                                                                                                                                                                                                                           |
| [series1.Styles\[0\].HighlightInterior = [new]{style="COLOR: blue"} [BrushInfo]{style="COLOR: teal"}([GradientStyle]{style="COLOR: teal"}.ForwardDiagonal, [Color]{style="COLOR: teal"}.Red, [Color]{style="COLOR: teal"}.White);]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                                                           |
| [series1.Styles\[1\].HighlightInterior = [new]{style="COLOR: blue"} [BrushInfo]{style="COLOR: teal"}([GradientStyle]{style="COLOR: teal"}.ForwardDiagonal, [Color]{style="COLOR: teal"}.Green, [Color]{style="COLOR: teal"}.White);]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                                                                                           |
| [series1.Styles\[2\].HighlightInterior = [new]{style="COLOR: blue"} [BrushInfo]{style="COLOR: teal"}([GradientStyle]{style="COLOR: teal"}.ForwardDiagonal, [Color]{style="COLOR: teal"}.Yellow, [Color]{style="COLOR: teal"}.White);]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                           |
| [series1.Styles\[3\].HighlightInterior = [new]{style="COLOR: blue"} [BrushInfo]{style="COLOR: teal"}([GradientStyle]{style="COLOR: teal"}.ForwardDiagonal, [Color]{style="COLOR: teal"}.Pink, [Color]{style="COLOR: teal"}.White);]{style="FONT-FAMILY: 'Courier New'"}   |
+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"} 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                     |
|                                                                                                                                                                                                                                                                        |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                               |
|                                                                                                                                                                                                                                                                        |
| [series1.Styles(0).HighlightInterior = [New]{style="COLOR: blue"} [BrushInfo]{style="COLOR: teal"}([GradientStyle]{style="COLOR: teal"}.ForwardDiagonal, [Color]{style="COLOR: teal"}.Red, [Color]{style="COLOR: teal"}.White)]{style="FONT-FAMILY: 'Courier New'"}    |
|                                                                                                                                                                                                                                                                        |
| [series1.Styles(1).HighlightInterior = [New]{style="COLOR: blue"} [BrushInfo]{style="COLOR: teal"}([GradientStyle]{style="COLOR: teal"}.ForwardDiagonal, [Color]{style="COLOR: teal"}.Green, [Color]{style="COLOR: teal"}.White)]{style="FONT-FAMILY: 'Courier New'"}  |
|                                                                                                                                                                                                                                                                        |
| [series1.Styles(2).HighlightInterior = [New]{style="COLOR: blue"} [BrushInfo]{style="COLOR: teal"}([GradientStyle]{style="COLOR: teal"}.ForwardDiagonal, [Color]{style="COLOR: teal"}.Yellow, [Color]{style="COLOR: teal"}.White)]{style="FONT-FAMILY: 'Courier New'"} |
|                                                                                                                                                                                                                                                                        |
| [series1.Styles(3).HighlightInterior = [New]{style="COLOR: blue"} [BrushInfo]{style="COLOR: teal"}([GradientStyle]{style="COLOR: teal"}.ForwardDiagonal, [Color]{style="COLOR: teal"}.Pink, [Color]{style="COLOR: teal"}.White)]{style="FONT-FAMILY: 'Courier New'"}   |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

**[]{style="FONT-FAMILY: 'Trebuchet MS','sans-serif'; FONT-SIZE: 9pt"}** 

See Also

 

[Pyramid Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Funnel Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Area Charts]{.UGHyperlink}[, ]{.UGHyperlink}[Bar Charts]{.UGHyperlink}[, ]{.UGHyperlink}[Bubble Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Column Charts]{.UGHyperlink}[, ]{.UGHyperlink}[Candle Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Renko chart]{.UGHyperlink}[, ]{.UGHyperlink}[Three Line Break Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Box and Whisker Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Gantt Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Histogram Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Tornado Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Polar and Radar Chart]{.UGHyperlink}[, ]{.UGHyperlink}[Pie Chart]{.UGHyperlink}[]{.UGHyperlink}

[]{#p114} 

[]{#related-topics}
::::
