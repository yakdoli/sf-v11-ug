::: {style="DISPLAY: none"}
[](ms-xhelp:///?Id=d2h_url_template){#d2h_url_template}![](!package_url!){#d2h_package_url style="WIDTH: 0px; DISPLAY: none; HEIGHT: 0px"}
:::

:::: {.d2h_secondary_topic style="PADDING-BOTTOM: 10pt; MARGIN: 0pt; PADDING-LEFT: 0pt; PADDING-RIGHT: 0pt; PADDING-TOP: 0pt"}
#### HighlightInterior {#highlightinterior style="tab-stops: 0pt"}

 

The auto highlight color for any series can be changed by setting the color at the **HighlightInterior** property of **ChartStyleInfo** class.

 

::: {align="center"}
+------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| Details                                                                                                                                                                                                                                      |
+------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Possible Values**          | RBG values ranges from 0 to 255                                                                                                                                                                               |
+------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Default Value    **        | **None**                                                                                                                                                                                                      |
+------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **2D / 3D Limitations**      | No                                                                                                                                                                                                            |
+------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Applies to Chart Element** | All series                                                                                                                                                                                                    |
+------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **Applies to Chart Types**   | Bar Charts, Pie, Funnel, Pyramid,Bubble, Column, Area, Stacking Area, Stacking Area100, Line Charts, Box and Whisker, Gantt Chart , Tornado Chart, Polar And Radar Chart, Hi Lo Chart, Hi Lo Open Close Chart |
+------------------------------+---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
:::

 

Here is some sample code.

 

Series Wide Setting

 

+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[C#\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                   |
|                                                                                                                                                                                                                                                                  |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                         |
|                                                                                                                                                                                                                                                                  |
| [this]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.AutoHighlight = [true]{style="COLOR: blue"};]{style="FONT-FAMILY: 'Courier New'"}                                                                                                         |
|                                                                                                                                                                                                                                                                  |
| [ChartSeries]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[ series1 = [this]{style="COLOR: blue"}.chartControl1.Series\[0\];]{style="FONT-FAMILY: 'Courier New'"}                                                                                            |
|                                                                                                                                                                                                                                                                  |
| [series1.Style.HighlightInterior = [new]{style="COLOR: blue"} [BrushInfo]{style="COLOR: teal"}([GradientStyle]{style="COLOR: teal"}.ForwardDiagonal, [Color]{style="COLOR: teal"}.Red, [Color]{style="COLOR: teal"}.White);]{style="FONT-FAMILY: 'Courier New'"} |
+------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
| **[\[VB.NET\]]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| **[]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}**                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [Me]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[.chartControl1.AutoHighlight = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[True]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [Dim]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ series1 [As]{style="COLOR: blue"} [ChartSeries]{style="COLOR: teal"} = [Me]{style="COLOR: blue"}.chartControl1.Series(0)]{style="FONT-FAMILY: 'Courier New'"}                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
|                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [series1.Style.HighlightInterior = ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[New]{style="FONT-FAMILY: 'Courier New'; COLOR: blue"}[ ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[BrushInfo]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[(]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[GradientStyle]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.ForwardDiagonal, ]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Color]{style="FONT-FAMILY: 'Courier New'; COLOR: teal"}[.]{style="FONT-FAMILY: 'Courier New'; COLOR: black"}[Red[, ]{style="COLOR: black"}[Color]{style="COLOR: teal"}[.]{style="COLOR: black"}White[)]{style="COLOR: black"}]{style="FONT-FAMILY: 'Courier New'"} |
+-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+

 

![](ImagesExt/image84_148.jpg){border="0"}

 

Figure 148: Column Chart with HighlightInterior

 

Specific Data Point Setting

 

To set interior color for individual highlighted datapoints,

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

 

**See Also**

[]{style="FONT-FAMILY: 'Segoe UI','sans-serif'; COLOR: black"} 

[Bar Charts]{.UGHyperlink}, [Pie Chart]{.UGHyperlink}, [Funnel Chart]{.UGHyperlink}, [Pyramid Chart]{.UGHyperlink}, [Bubble Chart]{.UGHyperlink}, [Column Chart]{.UGHyperlink}, [Area Chart]{.UGHyperlink}, [Stacking Area Chart]{.UGHyperlink}, [Stacking Area100 Chart]{.UGHyperlink}, [Line Charts]{.UGHyperlink},[ ]{.UGHyperlink}[Box and Whisker Chart]{.UGHyperlink}, [Gantt Chart]{.UGHyperlink}, [Tornado Chart]{.UGHyperlink}, [Polar And Radar Chart]{.UGHyperlink}, [Hi Lo Chart]{.UGHyperlink}, [Hi Lo Open Close Chart]{.UGHyperlink}[]{style="COLOR: black"}

 

[]{#p113} 

 

[]{#related-topics}
::::
